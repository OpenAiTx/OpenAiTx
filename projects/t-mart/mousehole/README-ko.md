# Mousehole, MAM용 시드박스 IP 업데이트 도구

MAM용 시드박스 IP를 업데이트하는 백그라운드 서비스와 이를 관리하는 HTTP 서버입니다.

![Mousehole Demo](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/demo.webp)

호스트/VPN/시드박스를 사용하여 시딩 중이고 IP 주소가 불안정할 때 유용할 수 있습니다.

특징:

- 호스트의 IP 주소를 주기적으로 MAM에 업데이트하는 백그라운드 서비스.

  업데이트 전, Mousehole은 호스트의 현재 IP 주소와 AS를 마지막 MAM 응답과 비교하여
  실제로 업데이트가 필요한지 확인합니다.

- 서비스를 관리할 수 있는 프런트엔드 웹사이트 제공:

  - MAM 쿠키 설정
  - 상태 정보 표시
  - 수동 검사 트리거

- 관리 엔드포인트가 포함된 API 서버 제공.

  자세한 내용은 [API.md](https://github.com/t-mart/mousehole/blob/master/docs/API.md)를 참고하세요.

## 시작하기

Mousehole을 사용하려면 다음을 수행해야 합니다:

1. [서비스 실행](#running-the-service)
2. [웹 인터페이스를 통해 MAM 쿠키 설정](#setting-your-mam-cookie)
3. [MAM 오류 처리](#handling-errors) (있는 경우)

### 서비스 실행

#### Docker Compose (권장)




```yaml
services:
  gluetun:
    image: qmcgaw/gluetun:latest
    cap_add:
      - NET_ADMIN
    devices:
      - /dev/net/tun:/dev/net/tun
    ports:
      - "5010:5010" # Mousehole port
      - "8080:8080" # qBittorrent Web UI port
      - "6881:6881/tcp" # qBittorrent TCP torrent port
      - "6881:6881/udp" # qBittorrent UDP torrent port
    environment:
      VPN_SERVICE_PROVIDER: "your-vpn-provider"
      FIREWALL_VPN_INPUT_PORTS: "6881" # qBittorrent torrent
      # more is needed here -- see Gluetun documentation
      # https://github.com/qdm12/gluetun-wiki
      # https://github.com/qdm12/gluetun-wiki/tree/main/setup/providers
    restart: unless-stopped

  qbittorrent:
    image: lscr.io/linuxserver/qbittorrent:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
      WEBUI_PORT: 8080
      TORRENTING_PORT: 6881
    restart: unless-stopped

  mousehole:
    image: tmmrtn/mousehole:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
    volumes:
      # persist cookie data across container restarts
      - "mousehole:/srv/mousehole"
    restart: unless-stopped

volumes:
  mousehole:
```


시작용 Docker Compose 예제:

- ⭐ [Gluetun + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/gluetun-qb.md)
- [Wireguard + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/wireguard-qb.md)
- [비-VPN 예제](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/non-vpn.md)

모든 VPN 설정은 Mousehole을 사이드카로 포함하도록 조정할 수 있습니다. 자세한 내용은
[Docker Compose에서 Mousehole을 사이드카로 사용하기](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/sidecars.md)를 참고하세요.

#### Unraid

설치 방법은 [Unraid 설치 가이드](https://raw.githubusercontent.com/t-mart/mousehole/master/./contrib/unraid/README.md)를 참고하세요.

#### 로컬

서버를 실행하려면:



```bash
bun run start
```

### MAM 쿠키 설정하기

Mousehole이 실행 중이면, 브라우저에서 `http://<host>:5010`의 웹 UI로 이동하세요.  
로컬에서 실행 중이라면 아마 <http://localhost:5010>일 것입니다.

처음 실행할 때(또는 쿠키가 동기화되지 않은 경우) Mousehole의 쿠키를 수동으로 설정해야 합니다.

Mousehole 웹 인터페이스로 이동하면 쿠키를 설정하는 폼이 표시됩니다 -- 쿠키를 붙여넣고 "Set" 버튼을 클릭하세요.

![Mousehole 쿠키 폼](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/cookie-form.png)

쿠키를 얻는 데 도움이 필요하면 "What do I enter here?" 버튼을 클릭하여 튜토리얼을 확인하세요.


### 오류 처리

Mousehole이 실행 중이어도, Mousehole이 자동으로 수정할 수 없는 문제가 발생할 수 있습니다. 여기 흔한 문제들이 있습니다:

- ["잘못된 세션 - ASN 불일치"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/asn-mismatch.md)
- ["잘못된 세션 - 잘못된 쿠키"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/invalid-cookie.md)
- ["최근 변경 너무 잦음"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/last-change-too-recent.md)

## Docker 태그

Mousehole은 여러 이미지 태그를  
[Docker Hub](https://hub.docker.com/r/tmmrtn/mousehole)에 게시합니다:

- SemVer 버전(`0`, `0.1`, `0.1.11` 등)
- `latest`, 최신 릴리스 버전
- `edge`, `master` 브랜치의 최신 커밋
- 테스트용 `master` 대상 풀 리퀘스트, `pr-<number>` 태그

어떤 것을 선택할지 모르면 `latest`를 선택하세요.






## 환경 변수

- `MOUSEHOLE_PORT`: _(기본값 `5010`)_ HTTP 서버가 수신 대기할 포트입니다.
- `MOUSEHOLE_STATE_DIR_PATH`: _(기본값 `/srv/mousehole`)_ 서비스가 데이터를 저장할 디렉터리입니다.
- `MOUSEHOLE_USER_AGENT`: _(기본값 `mousehole-by-timtimtim/<version>`)_ MAM에 요청할 때 사용할 사용자 에이전트입니다.
- `MOUSEHOLE_CHECK_INTERVAL_SECONDS`: _(기본값 `300` (5분))_ 검사 간격(초)입니다.
- `MOUSEHOLE_STALE_RESPONSE_SECONDS`: _(기본값 `86400` (1일))_ MAM 응답을 오래된 것으로 간주하는 초 수입니다. 이는 Mousehole이 정기적으로 MAM과 통신하며 쿠키의 외부 변경을 감지하고 있는지 확인합니다.
- `TZ`: _(기본값 `Etc/UTC`)_ 현지화된 시간 표시를 위한 타임존입니다.

## 기여

기여하고 싶으신가요? [기여 가이드라인](https://raw.githubusercontent.com/t-mart/mousehole/master/./CONTRIBUTING.md)을 확인하세요.

유용한 추가 기능이 포함된 [`contrib`](./contrib/) 디렉터리도 있습니다.

## 링크

- [저장소](https://github.com/t-mart/mousehole)
- [Docker Hub 이미지](https://hub.docker.com/r/tmmrtn/mousehole)
- [포럼 게시물](https://www.myanonamouse.net/f/t/84712/p/p1013257)

## 개발

- 개발 서버를 시작하려면:









  ```bash
  bun run dev
  ```
- 새 버전은 `package.json`의 버전을 변경하고 GitHub에 푸시하는 것만으로 태그 지정, 릴리스 및 Docker Hub에 푸시할 수 있습니다. CI 워크플로우가 나머지를 처리합니다.

## 저작권 표시

Mouse Hole by Sergey Demushkin from
[Noun Project](https://thenounproject.com/term/mouse-hole/) (CC BY 3.0)





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---