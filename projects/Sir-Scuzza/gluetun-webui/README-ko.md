# Gluetun WebUI

Docker용 VPN 클라이언트 컨테이너인 [Gluetun](https://github.com/qdm12/gluetun)을 모니터링하고 제어하기 위한 가벼운 웹 UI입니다.

![Status: Connected](https://img.shields.io/badge/status-connected-brightgreen)
![Node 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## 기능

- ✨ **멀티 VPN 지원** — 최대 20개의 Gluetun 인스턴스를 동시에 모니터링 및 제어
- 실시간 VPN 상태 배너 (연결됨 / 일시중지 / 연결 끊김)
- 공용 출구 IP, 국가, 지역, 도시 및 조직 정보
- VPN 제공자, 프로토콜 (WireGuard / OpenVPN), 서버 세부정보
- 포트 포워딩 및 DNS 상태
- VPN 시작 / 중지 제어
- 설정 가능한 간격(5초 – 60초)으로 자동 새로고침
- 최근 30회의 폴링 상태를 색상으로 구분한 히스토리 바
- 반응형 디자인 (모바일, 태블릿, 데스크탑)

---

## 스크린샷
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## 요구사항

- Docker + Docker Compose
- HTTP 제어 서버가 활성화된 상태로 실행 중인 Gluetun (기본 포트 `8000`)
- 동일 Docker 네트워크 내의 Gluetun 및 gluetun-webui

> `linux/amd64` 및 `linux/arm64` 지원 (Mac Intel/Apple Silicon, Linux, Windows에서 작동).

---

## 빠른 시작
### 옵션 A1: 단일 인스턴스 (권장)

기존의 Gluetun과 함께 `gluetun-webui`를 compose 파일에 추가하세요:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    # Uncomment if Gluetun auth is enabled:
    #- GLUETUN_API_KEY=yourtoken
    #- GLUETUN_USER=username
    #- GLUETUN_PASSWORD=password
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
  healthcheck:
    test: ["CMD", "wget", "-qO-", "http://localhost:3000/api/health"]
    interval: 30s
    timeout: 5s
    start_period: 10s
    retries: 3
```
### 옵션 A2: 다중 인스턴스

별도의 대시보드로 2개 이상의 Gluetun 인스턴스 모니터링:


```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_1_NAME=VPN - London
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1
    
    - GLUETUN_2_NAME=VPN - Amsterdam  
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2
    
    - GLUETUN_3_NAME=VPN - Singapore
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_API_KEY=token3
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
```

### 옵션 B: 로컬에서 빌드하기

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

그런 다음 실행합니다(두 옵션 중 하나):

```bash
docker compose up -d
```

UI는 **http://localhost:3000** 에서 사용할 수 있습니다.

---

## 네트워크 설정

Gluetun과 gluetun-webui는 `http://gluetun:8000`이 올바르게 해석되도록 동일한 Docker 네트워크에 있어야 합니다.

**동일한 compose 파일** — 두 서비스를 동일한 네트워크에 추가하기만 하면 됩니다 (가장 일반적):

```yaml
services:
  gluetun:
    networks:
      - arr-stack
  gluetun-webui:
    networks:
      - arr-stack

networks:
  arr-stack:
    driver: bridge
```

**별도의 compose 파일** — Gluetun의 기존 네트워크를 외부로 참조합니다. `docker network ls`로 네트워크 이름을 찾으세요:

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## 다중 VPN 지원

### 다중 인스턴스

gluetun-webui는 **여러 Gluetun 인스턴스를 동시에** 모니터링하고 제어하는 것을 지원합니다. 각 인스턴스는 반응형 그리드 내 별도의 대시보드로 표시됩니다.

**구성**: 번호가 매겨진 환경 변수를 사용하세요:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    # Instance 1
    - GLUETUN_1_NAME=VPN 1
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1  # optional

    # Instance 2
    - GLUETUN_2_NAME=VPN 2
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2  # optional

    # Instance 3
    - GLUETUN_3_NAME=VPN 3
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_USER=admin
    - GLUETUN_3_PASSWORD=secret  # optional (HTTP Basic auth)
```

**지원됨**: 최대 20개 인스턴스 (`GLUETUN_1_URL`부터 `GLUETUN_20_URL`까지)  
**반응형**: 전체 너비 대시보드 1개 → 반 너비 2개 → 3분의 1 너비 3개 → 4분의 1 너비 4개 → 5개 이상부터 스크롤 가능

### 이전 버전 호환성

번호가 지정된 변수가 구성되지 않은 경우, **레거시 단일 인스턴스 모드**로 되돌아감:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### 인스턴스별 인증

각 인스턴스는 서로 다른 인증을 가질 수 있습니다:

```yaml
# Instance with API key
- GLUETUN_1_API_KEY=my-secret-token

# Instance with HTTP Basic auth
- GLUETUN_2_USER=admin
- GLUETUN_2_PASSWORD=mysecret

# Instance with no auth
- GLUETUN_3_URL=http://gluetun-3:8000  # auth optional
```

---

## 구성

| 변수 | 기본값 | 설명 |
|---|---|---|
| `GLUETUN_1_*` 에서 `GLUETUN_20_*` | _(비어 있음)_ | **다중 인스턴스 설정** (최대 20개 인스턴스) |
| `GLUETUN_{N}_URL` | – | 인스턴스 N용 Gluetun HTTP 제어 서버 URL |
| `GLUETUN_{N}_NAME` | `Instance {N}` | 인스턴스 N의 표시 이름 |
| `GLUETUN_{N}_API_KEY` | _(비어 있음)_ | 인스턴스 N용 베어러 토큰 (인증 활성화 시) |
| `GLUETUN_{N}_USER` | _(비어 있음)_ | HTTP 기본 인증용 사용자 이름 (인스턴스 N) |
| `GLUETUN_{N}_PASSWORD` | _(비어 있음)_ | HTTP 기본 인증용 비밀번호 (인스턴스 N) |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **레거시** – 단일 인스턴스 전용 (`GLUETUN_1_*` 변수가 없을 때 대체) |
| `GLUETUN_API_KEY` | _(비어 있음)_ | **레거시** – 단일 인스턴스용 베어러 토큰 |
| `GLUETUN_USER` | _(비어 있음)_ | **레거시** – HTTP 기본 인증용 사용자 이름 |
| `GLUETUN_PASSWORD` | _(비어 있음)_ | **레거시** – HTTP 기본 인증용 비밀번호 |
| `PORT` | `3000` | 웹 UI가 수신하는 포트 |
| `TRUST_PROXY` | `false` | 리버스 프록시(nginx, Traefik 등) 뒤에서 실행하는 경우 `true`로 설정 |

---

## 보안

- 포트는 `127.0.0.1`에 바인딩되어 네트워크에 노출되지 않음
- 컨테이너는 비루트 사용자로 읽기 전용 파일시스템과 권한 제한으로 실행
- 모든 API 경로에 속도 제한 적용
- 업스트림 오류 세부사항은 서버 측에만 기록되며 브라우저에는 일반 메시지 반환

### 리버스 프록시 구성

gluetun-webui를 리버스 프록시(nginx, Traefik, Caddy 등) 뒤에서 실행할 경우, 환경 변수에 `TRUST_PROXY=true`를 설정하세요:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```
이렇게 하면 앱이 `X-Forwarded-For` 및 관련 헤더를 올바르게 파싱하여 정확한 속도 제한 및 IP 감지를 할 수 있습니다. **참고:** 실제로 리버스 프록시 뒤에 있는 경우에만 활성화하세요. 이 설정은 리버스 프록시에서 오는 프록시 헤더를 신뢰하기 때문입니다.

### 리버스 프록시 인증

VPN 시작/중지 컨트롤에는 내장된 인증 기능이 없습니다. UI를 로컬호스트 외부에 노출하는 경우, HTTP 기본 인증이 적용된 리버스 프록시 뒤에 배치하세요.

**Caddy** (`Caddyfile`):

```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
`caddy hash-password` 명령어로 해시 생성

**Nginx** (`nginx.conf`):
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
`htpasswd -c /etc/nginx/.htpasswd user` 명령어로 비밀번호 파일 생성

**Traefik** (Docker 레이블):
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
`htpasswd -nb user password` 명령어로 해시 생성

---

## 감사의 글

- **[Gluetun](https://github.com/qdm12/gluetun)** — 이 웹 UI가 구축된 VPN 클라이언트 컨테이너
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — 이 웹 UI와 함께 사용하기 좋은 모니터링 도구
- **AI 지원 개발** — 이 프로젝트는 AI 지원으로 구축됨

---

## 라이선스

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---