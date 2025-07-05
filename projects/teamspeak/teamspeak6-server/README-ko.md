# TeamSpeak 6 서버 - 베타 릴리즈 README

TeamSpeak 6 서버의 베타 릴리즈에 오신 것을 환영합니다! 차세대 TeamSpeak를 경험해 주셔서 감사합니다. 이 문서는 시작하는 방법을 안내하며, 현재 베타 버전의 중요한 세부 사항을 강조합니다.

이 베타 버전에서는 일부 기능이 아직 개발 중이며, 버그가 발견될 수 있습니다. 여러분의 피드백은 매우 중요하며, 더 안정적이고 완성도 높은 최종 릴리즈를 만드는데 도움이 됩니다.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;TeamSpeak 소개</h2>

거의 25년에 걸쳐 검증된 저희 솔루션은 모든 사용자의 요구를 충족합니다. TeamSpeak는 게임, 교육 및 훈련, 내부 비즈니스 커뮤니케이션, 친구 및 가족과의 소통에 이상적인 음성 커뮤니케이션을 제공합니다. 저희의 주된 목표는 사용하기 쉽고, 높은 보안 표준, 우수한 음성 품질, 낮은 시스템 및 대역폭 사용량을 제공하는 솔루션을 전달하는 것입니다.

## ℹ️ 베타 상태 및 알려진 이슈
**이 릴리즈는 베타 버전입니다. 주요 목적은 다양한 피드백을 수집하고, 안정화 버전 출시 전에 잠재적인 문제를 식별하는 것입니다.**

**자가 호스팅 서버 파일:** TeamSpeak 6용 전용 서버 소프트웨어는 아직 활발히 개발 중이며, 아직 모든 기능이 완전히 구현된 상태는 아닙니다. 저희는 자가 호스팅 서버를 위한 완전한 TS6 경험을 제공하기 위해 최선을 다하고 있습니다.

**기능 불안정성:** 일부 새로운 기능은 아직 불안정하거나, 계속해서 개선되는 과정에서 변경될 수 있습니다.

**피드백이 필수적입니다:** 여러분의 경험은 매우 소중하며, 여러분의 의견은 저희에게 매우 중요합니다. [커뮤니티 포럼](https://community.teamspeak.com/c/teamspeak-6-server/45) 또는 [GitHub](https://github.com/teamspeak/teamspeak6-server/issues)를 통해 이슈를 보고하거나 제안을 공유해 주세요.

**제한 사항:** **TeamSpeak 3 서버 라이선스는 TeamSpeak 6 서버와 호환되지 않으며**, 현재 두 버전 간 **마이그레이션 경로가 제공되지 않습니다**.

**프리뷰 라이선스:** 여러분의 피드백에 따라, 서버에는 평가 기간 동안 더 유연하게 사용할 수 있도록 **임시** 32슬롯 프리뷰 라이선스가 포함되어 있습니다. 이 라이선스는 **2개월간만 유효**합니다.

또한, **TeamSpeak 6용 더 큰 라이선스를 획득하거나 업그레이드하는 것은 아직 불가능**합니다.

저희는 앞으로 더 나은 지원을 제공하기 위해 지속적으로 솔루션을 개발하고 있으니, 여러분의 인내와 이해에 진심으로 감사드립니다.

## 👇 TS6 시작하기
TeamSpeak 6 클라이언트를 시작하려면 [다운로드](https://teamspeak.com/en/downloads/) 페이지를 방문해 주세요.

자가 호스팅에 대한 정보는 아래의 간단한 가이드를 참고해 주세요. 최신 업데이트, 공지사항, 그리고 TeamSpeak 커뮤니티와의 교류를 원하신다면 [커뮤니티 포럼](https://community.teamspeak.com/)과 [Twitter](https://x.com/teamspeak)를 꼭 확인해 주세요.

자가 호스팅을 원하지 않거나, TeamSpeak 6를 더 쉽게 시작하고 싶으신가요? [TeamSpeak Communities](https://www.myteamspeak.com/communities)를 통해 공식 TeamSpeak 6 서버를 직접 임대할 수 있습니다.
## ⚙️ 설정
### 서버를 설정하는 주요 방법 세 가지:

1. **명령줄 인수:** 서버를 시작할 때 옵션을 직접 전달할 수 있습니다(예: ./tsserver --default-voice-port 9987). 임시 변경이나 스크립트 작성에 유용합니다.

2. **환경 변수:** 서버를 시작하기 전에 환경 변수를 설정할 수 있습니다. Docker 사용 시나 명령줄을 복잡하게 만들고 싶지 않을 때 유용합니다.

3. **YAML 설정 파일:** 영구적인 설정을 위해서는 tsserver.yaml 파일을 사용하는 것이 권장됩니다. --write-config-file 플래그를 이용하여 기본 설정 파일을 생성할 수 있습니다.

주요 설정 항목에는 네트워크 포트(음성, 파일 전송), 데이터베이스 연결(SQLite 및 MariaDB 지원), IP 바인딩, 로깅 옵션 등이 있습니다.

사용 가능한 전체 옵션 목록은 서버를 `--help` 플래그와 함께 실행하거나 [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md)를 참고하세요.

### 바이너리로 서버 실행하기
Docker를 사용하지 않는 경우, 운영 체제에서 직접 서버를 실행할 수 있습니다.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Linux에서:</h2>

서버 바이너리에 실행 권한을 부여합니다:
```sh
chmod +x tsserver
```

라이선스에 동의하며 터미널에서 서버를 실행합니다:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Windows에서:</h2>

명령 프롬프트 또는 PowerShell을 열고, 서버 파일을 추출한 디렉터리로 이동합니다.

서버 실행 파일을 실행하고, 라이선스에 동의합니다:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Docker로 서버 실행하기(권장):</h2>
Docker는 TeamSpeak 6 서버를 격리된 관리 환경에서 실행하는 가장 쉬운 방법입니다.

### 1. 간단한 docker run 명령:

빠른 시작을 위해 docker run 명령을 사용할 수 있습니다.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. docker-compose.yaml 사용(지속적인 운영을 위한 권장 방법):
서버를 장기간 운영할 계획이라면 이 방법이 가장 좋습니다. docker-compose.yaml 파일을 생성하세요:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # 음성 포트
      - "30033:30033/tcp" # 파일 전송
      # - "10080:10080/tcp" # 웹 쿼리
    environment:
```
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 유용한 링크
[공식 웹사이트](https://teamspeak.com/en/)<br>
[커뮤니티 포럼](https://community.teamspeak.com)<br>
[GitHub 이슈](https://github.com/teamspeak/teamspeak6-server/issues)<br>

여러분의 참여와 피드백이 TeamSpeak의 미래를 만들어갑니다! 💙<br>
TeamSpeak 6 베타 프로그램에 함께해 주시고 발전에 기여해 주셔서 감사합니다! 🫡


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---