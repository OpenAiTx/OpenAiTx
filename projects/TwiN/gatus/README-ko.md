
[![Gatus](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/logo-with-dark-text.png)](https://gatus.io)

![test](https://github.com/TwiN/gatus/actions/workflows/test.yml/badge.svg)
[![Go Report Card](https://goreportcard.com/badge/github.com/TwiN/gatus?)](https://goreportcard.com/report/github.com/TwiN/gatus)
[![codecov](https://codecov.io/gh/TwiN/gatus/branch/master/graph/badge.svg)](https://codecov.io/gh/TwiN/gatus)
[![Go version](https://img.shields.io/github/go-mod/go-version/TwiN/gatus.svg)](https://github.com/TwiN/gatus)
[![Docker pulls](https://img.shields.io/docker/pulls/twinproduction/gatus.svg)](https://cloud.docker.com/repository/docker/twinproduction/gatus)
[![Follow TwiN](https://img.shields.io/github/followers/TwiN?label=Follow&style=social)](https://github.com/TwiN)

Gatus는 HTTP, ICMP, TCP, 심지어 DNS 쿼리를 사용하여 서비스를 모니터링할 수 있는 개발자 지향 건강 대시보드입니다.  
상태 코드, 응답 시간, 인증서 만료, 본문 등과 같은 값에 대한 조건 목록을 사용하여 해당 쿼리 결과를 평가할 수 있습니다.  
특히 이러한 건강 검진 각각은 Slack, Teams, PagerDuty, Discord, Twilio 등 다양한 알림과 연동할 수 있습니다.

저는 개인적으로 Kubernetes 클러스터에 배포하여 핵심 애플리케이션의 상태를 모니터링합니다: https://status.twin.sh/

_관리형 솔루션을 찾고 계신가요? [Gatus.io](https://gatus.io)를 확인해보세요._

<details>
  <summary><b>빠른 시작</b></summary>




```console
docker run -p 8080:8080 --name gatus twinproduction/gatus:stable
```
원하는 경우 GitHub Container Registry를 사용할 수도 있습니다:
```console
docker run -p 8080:8080 --name gatus ghcr.io/twin/gatus:stable
```
자세한 내용은 [사용법](#usage)을 참조하세요.
</details>

> ❤ 이 프로젝트가 마음에 드시나요? [후원하기](https://github.com/sponsors/TwiN)를 고려해 주세요.

![Gatus 대시보드](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/dashboard-dark.png)

피드백이나 질문이 있으신가요? [토론 생성하기](https://github.com/TwiN/gatus/discussions/new).


## 목차
- [목차](#table-of-contents)
- [왜 Gatus인가?](#why-gatus)
- [기능](#features)
- [사용법](#usage)
- [설정](#configuration)
  - [엔드포인트](#endpoints)
  - [외부 엔드포인트](#external-endpoints)
  - [조건](#conditions)
    - [플레이스홀더](#placeholders)
    - [함수](#functions)
  - [저장소](#storage)
  - [클라이언트 설정](#client-configuration)
  - [알림](#alerting)
    - [AWS SES 알림 설정](#configuring-aws-ses-alerts)
    - [Discord 알림 설정](#configuring-discord-alerts)
    - [이메일 알림 설정](#configuring-email-alerts)
    - [Gitea 알림 설정](#configuring-gitea-alerts)
    - [GitHub 알림 설정](#configuring-github-alerts)
    - [GitLab 알림 설정](#configuring-gitlab-alerts)
    - [Google Chat 알림 설정](#configuring-google-chat-alerts)
    - [Gotify 알림 설정](#configuring-gotify-alerts)
    - [HomeAssistant 알림 설정](#configuring-homeassistant-alerts)
    - [Ilert 알림 설정](#configuring-ilert-alerts)
    - [Incident.io 알림 설정](#configuring-incidentio-alerts)
    - [JetBrains Space 알림 설정](#configuring-jetbrains-space-alerts)
    - [Matrix 알림 설정](#configuring-matrix-alerts)
    - [Mattermost 알림 설정](#configuring-mattermost-alerts)
    - [Messagebird 알림 설정](#configuring-messagebird-alerts)
    - [Ntfy 알림 설정](#configuring-ntfy-alerts)
    - [Opsgenie 알림 설정](#configuring-opsgenie-alerts)
    - [PagerDuty 알림 설정](#configuring-pagerduty-alerts)
    - [Pushover 알림 설정](#configuring-pushover-alerts)
    - [Slack 알림 설정](#configuring-slack-alerts)
    - [Teams 알림 설정 *(사용 중단됨)*](#configuring-teams-alerts-deprecated)
    - [Teams Workflow 알림 설정](#configuring-teams-workflow-alerts)
    - [Telegram 알림 설정](#configuring-telegram-alerts)
    - [Twilio 알림 설정](#configuring-twilio-alerts)
    - [Zulip 알림 설정](#configuring-zulip-alerts)
    - [사용자 정의 알림 설정](#configuring-custom-alerts)
    - [기본 알림 설정](#setting-a-default-alert)
  - [유지보수](#maintenance)
  - [보안](#security)
    - [기본 인증](#basic-authentication)
    - [OIDC](#oidc)
  - [TLS 암호화](#tls-encryption)
  - [메트릭](#metrics)
  - [연결성](#connectivity)
  - [원격 인스턴스 (실험적)](#remote-instances-experimental)
- [배포](#deployment)
  - [Docker](#docker)
  - [Helm 차트](#helm-chart)
  - [Terraform](#terraform)
- [테스트 실행](#running-the-tests)
- [프로덕션에서 사용하기](#using-in-production)
- [자주 묻는 질문](#faq)
  - [GraphQL 요청 보내기](#sending-a-graphql-request)
  - [권장 간격](#recommended-interval)
  - [기본 타임아웃](#default-timeouts)
  - [TCP 엔드포인트 모니터링](#monitoring-a-tcp-endpoint)
  - [UDP 엔드포인트 모니터링](#monitoring-a-udp-endpoint)
  - [SCTP 엔드포인트 모니터링](#monitoring-a-sctp-endpoint)
  - [WebSocket 엔드포인트 모니터링](#monitoring-a-websocket-endpoint)
  - [ICMP를 사용한 엔드포인트 모니터링](#monitoring-an-endpoint-using-icmp)
  - [DNS 쿼리를 사용한 엔드포인트 모니터링](#monitoring-an-endpoint-using-dns-queries)
  - [SSH를 사용한 엔드포인트 모니터링](#monitoring-an-endpoint-using-ssh)
  - [STARTTLS를 사용한 엔드포인트 모니터링](#monitoring-an-endpoint-using-starttls)
  - [TLS를 사용한 엔드포인트 모니터링](#monitoring-an-endpoint-using-tls)
  - [도메인 만료 모니터링](#monitoring-domain-expiration)
  - [모니터링 잠금 해제](#disable-monitoring-lock)
  - [실시간 구성 재로드](#reloading-configuration-on-the-fly)
  - [엔드포인트 그룹](#endpoint-groups)
  - [사용자 정의 경로에 Gatus 노출](#exposing-gatus-on-a-custom-path)
  - [사용자 정의 포트에 Gatus 노출](#exposing-gatus-on-a-custom-port)
  - [시작 지연 설정](#configuring-a-startup-delay)
  - [구성을 간결하게 유지하기](#keeping-your-configuration-small)
  - [프록시 클라이언트 설정](#proxy-client-configuration)
  - [431 Request Header Fields Too Large 오류 해결 방법](#how-to-fix-431-request-header-fields-too-large-error)
  - [배지](#badges)
    - [가동 시간](#uptime)
    - [상태](#health)
    - [상태 (Shields.io)](#health-shieldsio)
    - [응답 시간](#response-time)
    - [응답 시간 (차트)](#response-time-chart)
      - [응답 시간 배지의 색상 임계값 변경 방법](#how-to-change-the-color-thresholds-of-the-response-time-badge)
  - [API](#api)
    - [원시 데이터](#raw-data)
      - [가동 시간](#uptime-1)
      - [응답 시간](#response-time-1)
  - [바이너리로 설치하기](#installing-as-binary)
- [고수준 설계 개요](#high-level-design-overview)


## 왜 Gatus인가?
구체적인 내용에 들어가기 전에 가장 흔한 질문에 답하고자 합니다:
> Prometheus의 Alertmanager, Cloudwatch 또는 Splunk를 사용할 수 있는데 왜 Gatus를 사용해야 하나요?

이들 중 어느 것도 클라이언트가 활성적으로 엔드포인트를 호출하지 않으면 문제가 있다는 것을 알려줄 수 없습니다.
즉, 모니터링 메트릭은 대부분 기존 트래픽에 의존하기 때문에,
클라이언트가 이미 문제를 겪고 있지 않다면 알림을 받지 못한다는 의미입니다.

반면 Gatus는 각 기능에 대한 상태 점검을 구성할 수 있게 하여,
이 기능들을 모니터링하고 클라이언트가 영향을 받기 전에 잠재적으로 알림을 보낼 수 있습니다.

Gatus를 고려해야 할 신호는 로드 밸런서가 지금 당장 다운된다면 알림을 받을 수 있을지 스스로에게 묻는 것입니다.
기존 알림 중 어떤 것이 작동할까요? 트래픽이 애플리케이션에 도달하지 않으면 메트릭은 오류 증가를 보고하지 않습니다.
이 경우 서비스 저하를 알리는 쪽은 고객이 될 수밖에 없으며, 고객이 알기 전에 문제를 해결 중임을 확신시켜 줄 수 없습니다.


## 기능
Gatus의 주요 기능은 다음과 같습니다:

- **매우 유연한 상태 점검 조건**: 응답 상태 확인만으로 충분한 경우도 있지만, Gatus는 응답 시간, 응답 본문, IP 주소에 대한 조건도 추가할 수 있습니다.
- **사용자 수락 테스트에 활용 가능**: 위 기능 덕분에 자동화된 사용자 수락 테스트를 작성하는 데 이 애플리케이션을 활용할 수 있습니다.
- **매우 쉬운 구성**: 구성은 가능한 한 읽기 쉽게 설계되었으며, 새로운 서비스나 모니터링할 엔드포인트를 추가하는 것도 매우 쉽습니다.
- **알림 기능**: 시각적으로 보기 좋은 대시보드가 애플리케이션 상태를 추적하는 데 유용하지만, 하루 종일 쳐다보고 있을 수는 없습니다. 따라서 Slack, Mattermost, Messagebird, PagerDuty, Twilio, Google 채팅, Teams를 통한 알림을 기본 지원하며, 다른 제공자나 자동 롤백을 관리하는 맞춤 애플리케이션 등 필요에 따라 맞춤형 알림 제공자를 구성할 수 있습니다.
- **메트릭**
- **낮은 리소스 소비**: 대부분의 Go 애플리케이션과 마찬가지로 이 애플리케이션이 요구하는 리소스 사용량은 매우 적습니다.
- **[배지](#badges)**: ![가동시간 7일](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/7d/badge.svg) ![응답 시간 24시간](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/24h/badge.svg)
- **다크 모드**

![Gatus 대시보드 조건](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/dashboard-conditions.png)


## 사용법

<details>
  <summary><b>빠른 시작</b></summary>



```console
docker run -p 8080:8080 --name gatus twinproduction/gatus
```
GitHub Container Registry를 사용하는 것도 가능합니다:
```console
docker run -p 8080:8080 --name gatus ghcr.io/twin/gatus
```

자신만의 구성을 만들고 싶다면, 구성 파일을 마운트하는 방법에 대한 정보는 [Docker](#docker)를 참조하세요.
</details>

간단한 예는 다음과 같습니다:

```yaml
endpoints:
  - name: website                 # Name of your endpoint, can be anything
    url: "https://twin.sh/health"
    interval: 5m                  # Duration to wait between every status check (default: 60s)
    conditions:
      - "[STATUS] == 200"         # Status must be 200
      - "[BODY].status == UP"     # The json path "$.status" must be equal to UP
      - "[RESPONSE_TIME] < 300"   # Response time must be under 300ms

  - name: make-sure-header-is-rendered
    url: "https://example.org/"
    interval: 60s
    conditions:
      - "[STATUS] == 200"                          # Status must be 200
      - "[BODY] == pat(*<h1>Example Domain</h1>*)" # Body must contain the specified header
```
이 예제는 다음과 유사하게 보일 것입니다:

![Simple example](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/example.png)

기본적으로 구성 파일은 `config/config.yaml`에 있어야 합니다.

`GATUS_CONFIG_PATH` 환경 변수를 설정하여 사용자 지정 경로를 지정할 수 있습니다.

`GATUS_CONFIG_PATH`가 디렉터리를 가리키면 해당 디렉터리 및 하위 디렉터리 내의 모든 `*.yaml` 및 `*.yml` 파일이 다음과 같이 병합됩니다:
- 모든 맵/객체는 깊은 병합됩니다 (예: 한 파일에서 `alerting.slack`을 정의하고 다른 파일에서 `alerting.pagerduty`를 정의할 수 있습니다)
- 모든 슬라이스/배열은 추가됩니다 (즉, 여러 파일에서 `endpoints`를 정의할 수 있으며 각 엔드포인트가 최종 엔드포인트 목록에 추가됩니다)
- 원시 값(예: `metrics`, `alerting.slack.webhook-url` 등)을 가진 매개변수는 중복 정의를 방지하기 위해 한 번만 정의할 수 있습니다
    - 명확히 하자면, 이는 두 파일에서 서로 다른 값으로 `alerting.slack.webhook-url`을 정의할 수 없다는 의미입니다. 모든 파일은 처리되기 전에 하나로 병합됩니다. 이는 설계된 동작입니다.

> 💡 구성 파일에서 환경 변수를 사용할 수도 있습니다 (예: `$DOMAIN`, `${DOMAIN}`)
>
> 예제는 [examples/docker-compose-postgres-storage/config/config.yaml](https://raw.githubusercontent.com/TwiN/gatus/master/.examples/docker-compose-postgres-storage/config/config.yaml) 를 참고하세요.

로컬에서 테스트하려면 [Docker](#docker)를 참조하세요.


## 구성
| 매개변수                      | 설명                                                                                                                                | 기본값                     |
|:-----------------------------|:------------------------------------------------------------------------------------------------------------------------------------|:---------------------------|
| `metrics`                    | `/metrics`에서 메트릭을 노출할지 여부.                                                                                              | `false`                    |
| `storage`                    | [스토리지 구성](#storage).                                                                                                         | `{}`                       |
| `alerting`                   | [알림 구성](#alerting).                                                                                                            | `{}`                       |
| `endpoints`                  | [엔드포인트 구성](#endpoints).                                                                                                     | 필수 `[]`                  |
| `external-endpoints`         | [외부 엔드포인트 구성](#external-endpoints).                                                                                        | `[]`                       |
| `security`                   | [보안 구성](#security).                                                                                                            | `{}`                       |
| `disable-monitoring-lock`    | [모니터링 락 비활성화 여부](#disable-monitoring-lock).                                                                             | `false`                    |
| `skip-invalid-config-update` | 잘못된 구성 업데이트를 무시할지 여부. <br />[실시간 구성 재로드](#reloading-configuration-on-the-fly) 참고.                         | `false`                    |
| `web`                        | 웹 구성.                                                                                                                          | `{}`                       |
| `web.address`                | 수신할 주소.                                                                                                                      | `0.0.0.0`                  |
| `web.port`                   | 수신할 포트.                                                                                                                      | `8080`                     |
| `web.read-buffer-size`       | 연결에서 요청을 읽기 위한 버퍼 크기. 최대 헤더 크기의 제한도 포함.                                                                | `8192`                     |
| `web.tls.certificate-file`   | PEM 형식의 TLS용 공개 인증서 파일(선택 사항).                                                                                      | ``                         |
| `web.tls.private-key-file`   | PEM 형식의 TLS용 개인 키 파일(선택 사항).                                                                                          | ``                         |
| `ui`                         | UI 구성.                                                                                                                          | `{}`                       |
| `ui.title`                   | [문서 제목](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/title).                                                     | `Health Dashboard ǀ Gatus` |
| `ui.description`             | 페이지의 메타 설명.                                                                                                                | `Gatus is an advanced...`. |
| `ui.header`                  | 대시보드 상단의 헤더.                                                                                                              | `Health Status`            |
| `ui.logo`                    | 표시할 로고의 URL.                                                                                                                | `""`                       |
| `ui.link`                    | 로고 클릭 시 열 링크.                                                                                                              | `""`                       |
| `ui.buttons`                 | 헤더 아래에 표시할 버튼 목록.                                                                                                     | `[]`                       |
| `ui.buttons[].name`          | 버튼에 표시할 텍스트.                                                                                                              | 필수 `""`                  |
| `ui.buttons[].link`          | 버튼 클릭 시 열 링크.                                                                                                              | 필수 `""`                  |
| `ui.custom-css`              | 사용자 정의 CSS                                                                                                                   | `""`                       |
| `ui.dark-mode`               | 기본적으로 다크 모드 활성화 여부. 사용자의 운영 체제 테마 환경 설정이 우선합니다.                                                | `true`                     |
| `maintenance`                | [점검 구성](#maintenance).                                                                                                        | `{}`                       |

더 자세한 로깅을 원한다면 `GATUS_LOG_LEVEL` 환경 변수를 `DEBUG`로 설정하세요.
반대로, 덜 자세한 로깅을 원한다면 위 환경 변수를 `WARN`, `ERROR` 또는 `FATAL`로 설정할 수 있습니다.
`GATUS_LOG_LEVEL`의 기본값은 `INFO`입니다.

### 엔드포인트
엔드포인트는 모니터링하려는 URL, 애플리케이션 또는 서비스입니다. 각 엔드포인트는 지정한 간격으로 평가되는 조건 목록을 가집니다.
조건 중 하나라도 실패하면 해당 엔드포인트는 비정상으로 간주됩니다.
그 후 특정 임계값에 도달하면 엔드포인트가 비정상일 때 알림을 트리거하도록 구성할 수 있습니다.

| 매개변수                                        | 설명                                                                                                                                    | 기본값                     |
|:------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------|:---------------------------|
| `endpoints`                                     | 모니터링할 엔드포인트 목록.                                                                                                             | 필수 `[]`                  |
| `endpoints[].enabled`                           | 엔드포인트 모니터링 여부.                                                                                                               | `true`                     |
| `endpoints[].name`                              | 엔드포인트 이름. 아무 값이나 가능.                                                                                                      | 필수 `""`                  |
| `endpoints[].group`                             | 그룹 이름. 대시보드에서 여러 엔드포인트를 그룹화하는 데 사용. <br />[엔드포인트 그룹](#endpoint-groups) 참고.                            | `""`                       |
| `endpoints[].url`                               | 요청을 보낼 URL.                                                                                                                        | 필수 `""`                  |
| `endpoints[].method`                            | 요청 메서드.                                                                                                                           | `GET`                      |
| `endpoints[].conditions`                        | 엔드포인트 상태를 결정하는 데 사용되는 조건들. <br />[조건](#conditions) 참고.                                                          | `[]`                       |
| `endpoints[].interval`                          | 상태 확인 간 대기 시간.                                                                                                                  | `60s`                      |
| `endpoints[].graphql`                           | 본문을 쿼리 파라미터(`{"query":"$body"}`)로 래핑할지 여부.                                                                              | `false`                    |
| `endpoints[].body`                              | 요청 본문.                                                                                                                             | `""`                       |
| `endpoints[].headers`                           | 요청 헤더.                                                                                                                             | `{}`                       |
| `endpoints[].dns`                               | DNS 유형 엔드포인트 구성. <br />[DNS 쿼리를 사용한 엔드포인트 모니터링](#monitoring-an-endpoint-using-dns-queries) 참고.                | `""`                       |
| `endpoints[].dns.query-type`                    | 쿼리 타입 (예: MX).                                                                                                                    | `""`                       |
| `endpoints[].dns.query-name`                    | 쿼리 이름 (예: example.com).                                                                                                           | `""`                       |
| `endpoints[].ssh`                               | SSH 유형 엔드포인트 구성. <br />[SSH를 사용한 엔드포인트 모니터링](#monitoring-an-endpoint-using-ssh) 참고.                             | `""`                       |
| `endpoints[].ssh.username`                      | SSH 사용자 이름 (예: example).                                                                                                         | 필수 `""`                  |
| `endpoints[].ssh.password`                      | SSH 비밀번호 (예: password).                                                                                                           | 필수 `""`                  |
| `endpoints[].alerts`                            | 해당 엔드포인트에 대한 모든 알림 목록. <br />[알림](#alerting) 참고.                                                                    | `[]`                       |
| `endpoints[].maintenance-windows`               | 해당 엔드포인트에 대한 모든 점검 창 목록. <br />[점검](#maintenance) 참고.                                                              | `[]`                       |
| `endpoints[].client`                            | [클라이언트 구성](#client-configuration).                                                                                              | `{}`                       |
| `endpoints[].ui`                                | 엔드포인트 수준의 UI 구성.                                                                                                              | `{}`                       |
| `endpoints[].ui.hide-conditions`                | 결과에서 조건 숨김 여부. 이는 이 기능이 활성화된 시점 이후 평가된 결과에서만 조건을 숨깁니다.                                           | `false`                    |
| `endpoints[].ui.hide-hostname`                  | 결과에서 호스트명 숨김 여부.                                                                                                           | `false`                    |
| `endpoints[].ui.hide-port`                      | 결과에서 포트 숨김 여부.                                                                                                               | `false`                    |
| `endpoints[].ui.hide-url`                       | 결과에서 URL 숨김 여부. URL에 토큰이 포함된 경우 유용합니다.                                                                            | `false`                    |
| `endpoints[].ui.dont-resolve-failed-conditions` | UI를 위해 실패한 조건을 해석하지 않을지 여부.                                                                                           | `false`                    |
| `endpoints[].ui.badge.response-time`            | 응답 시간 임계값 목록. 임계값에 도달할 때마다 배지 색상이 달라집니다.                                                                   | `[50, 200, 300, 500, 750]` |

본문(`endpoints[].body`)에서 다음 플레이스홀더를 사용할 수 있습니다:
- `[ENDPOINT_NAME]` (`endpoints[].name`에서 해석됨)
- `[ENDPOINT_GROUP]` (`endpoints[].group`에서 해석됨)
- `[ENDPOINT_URL]` (`endpoints[].url`에서 해석됨)
- `[LOCAL_ADDRESS]` (로컬 IP 및 포트를 `192.0.2.1:25` 또는 `[2001:db8::1]:80` 형식으로 해석)
- `[RANDOM_STRING_N]` (길이 N의 숫자 및 문자로 이루어진 임의 문자열로 해석)




### 외부 엔드포인트
일반 엔드포인트와 달리 외부 엔드포인트는 Gatus에서 모니터링하지 않고 프로그램 방식으로 푸시됩니다.  
이를 통해 Gatus가 일반적으로 접근할 수 없는 환경에 있는 항목도 모니터링할 수 있습니다.

예를 들어:  
- 프라이빗 네트워크에 있는 자체 에이전트를 만들어 서비스를 공개된 Gatus 인스턴스로 상태를 푸시할 수 있습니다  
- Gatus에서 지원하지 않는 서비스를 모니터링할 수 있습니다  
- Gatus를 대시보드로 사용하면서 자체 모니터링 시스템을 구현할 수 있습니다  

| Parameter                      | Description                                                                                                            | Default       |
|:-------------------------------|:-----------------------------------------------------------------------------------------------------------------------|:--------------|
| `external-endpoints`           | 모니터링할 엔드포인트 목록입니다.                                                                                      | `[]`          |
| `external-endpoints[].enabled` | 엔드포인트를 모니터링할지 여부입니다.                                                                                  | `true`        |
| `external-endpoints[].name`    | 엔드포인트 이름입니다. 아무 값이나 가능합니다.                                                                          | 필수 `""`     |
| `external-endpoints[].group`   | 그룹 이름입니다. 대시보드에서 여러 엔드포인트를 함께 묶을 때 사용합니다. <br />[엔드포인트 그룹](#endpoint-groups) 참고 | `""`          |
| `external-endpoints[].token`   | 상태 푸시 시 필요한 Bearer 토큰입니다.                                                                                 | 필수 `""`     |
| `external-endpoints[].alerts`  | 특정 엔드포인트에 대한 모든 알림 목록입니다. <br />[알림](#alerting) 참고                                               | `[]`          |

예시:
```yaml
external-endpoints:
  - name: ext-ep-test
    group: core
    token: "potato"
    alerts:
      - type: discord
        description: "healthcheck failed"
        send-on-resolved: true
```
외부 엔드포인트의 상태를 푸시하려면 요청이 다음과 같이 표시되어야 합니다:

```
POST /api/v1/endpoints/{key}/external?success={success}&error={error}&duration={duration}
```

위치:
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 패턴을 가지며 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.
  - 위 예시 구성에서는 키가 `core_ext-ep-test`가 됩니다.
- `{success}`는 헬스 체크가 성공했는지를 나타내는 불리언 값(`true` 또는 `false`)입니다.
- `{error}` (선택 사항): 실패한 헬스 체크의 이유를 설명하는 문자열입니다. {success}가 false일 경우 에러 메시지를 포함해야 하며, 체크가 성공하면 포함하지 않습니다.
- `{duration}` (선택 사항): 요청에 소요된 시간을 duration 문자열(e.g. 10s)로 표시합니다.

토큰은 반드시 `Authorization` 헤더에 `Bearer` 토큰으로 전달해야 합니다.


### 조건
사용할 수 있는 조건의 예는 다음과 같습니다:

| 조건                             | 설명                                               | 통과 값                    | 실패 값          |
|:--------------------------------|:---------------------------------------------------|:---------------------------|------------------|
| `[STATUS] == 200`               | 상태가 200과 같아야 합니다                         | 200                        | 201, 404, ...    |
| `[STATUS] < 300`                | 상태가 300 미만이어야 합니다                        | 200, 201, 299              | 301, 302, ...    |
| `[STATUS] <= 299`               | 상태가 299 이하이어야 합니다                        | 200, 201, 299              | 301, 302, ...    |
| `[STATUS] > 400`                | 상태가 400 초과이어야 합니다                        | 401, 402, 403, 404         | 400, 200, ...    |
| `[STATUS] == any(200, 429)`     | 상태가 200 또는 429이어야 합니다                    | 200, 429                   | 201, 400, ...    |
| `[CONNECTED] == true`           | 호스트 연결이 성공적이어야 합니다                   | true                       | false            |
| `[RESPONSE_TIME] < 500`         | 응답 시간이 500ms 미만이어야 합니다                  | 100ms, 200ms, 300ms        | 500ms, 501ms     |
| `[IP] == 127.0.0.1`             | 대상 IP가 127.0.0.1이어야 합니다                    | 127.0.0.1                  | 0.0.0.0          |
| `[BODY] == 1`                   | 본문이 1과 같아야 합니다                            | 1                          | `{}`, `2`, ...   |
| `[BODY].user.name == john`      | JSONPath `$.user.name`의 값이 `john`과 같아야 합니다 | `{"user":{"name":"john"}}` |                  |
| `[BODY].data[0].id == 1`        | JSONPath `$.data[0].id`의 값이 1과 같아야 합니다    | `{"data":[{"id":1}]}`      |                  |
| `[BODY].age == [BODY].id`       | JSONPath `$.age`가 JSONPath `$.id`와 같아야 합니다  | `{"age":1,"id":1}`         |                  |
| `len([BODY].data) < 5`          | JSONPath `$.data` 배열의 요소 수가 5 미만이어야 합니다 | `{"data":[{"id":1}]}`      |                  |
| `len([BODY].name) == 8`         | JSONPath `$.name` 문자열 길이가 8이어야 합니다      | `{"name":"john.doe"}`      | `{"name":"bob"}` |
| `has([BODY].errors) == false`   | JSONPath `$.errors`가 존재하지 않아야 합니다       | `{"name":"john.doe"}`      | `{"errors":[]}`  |
| `has([BODY].users) == true`     | JSONPath `$.users`가 존재해야 합니다                | `{"users":[]}`             | `{}`             |
| `[BODY].name == pat(john*)`     | JSONPath `$.name` 문자열이 패턴 `john*`과 일치해야 합니다 | `{"name":"john.doe"}`      | `{"name":"bob"}` |
| `[BODY].id == any(1, 2)`        | JSONPath `$.id` 값이 1 또는 2와 같아야 합니다       | 1, 2                       | 3, 4, 5          |
| `[CERTIFICATE_EXPIRATION] > 48h`| 인증서 만료까지 48시간 이상이어야 합니다             | 49h, 50h, 123h             | 1h, 24h, ...     |
| `[DOMAIN_EXPIRATION] > 720h`    | 도메인 만료까지 720시간 이상이어야 합니다            | 4000h                      | 1h, 24h, ...     |


#### 플레이스홀더
| 플레이스홀더                  | 설명                                                                                         | 해결된 값 예시                              |
|:-----------------------------|:--------------------------------------------------------------------------------------------|:-------------------------------------------|
| `[STATUS]`                   | 요청의 HTTP 상태 코드로 해결됩니다                                                          | `404`                                      |
| `[RESPONSE_TIME]`            | 요청에 소요된 응답 시간(ms)로 해결됩니다                                                    | `10`                                       |
| `[IP]`                       | 대상 호스트의 IP로 해결됩니다                                                                | `192.168.0.232`                            |
| `[BODY]`                     | 응답 본문으로 해결됩니다. JSONPath를 지원합니다.                                             | `{"name":"john.doe"}`                      |
| `[CONNECTED]`                | 연결 가능 여부로 해결됩니다                                                                  | `true`                                     |
| `[CERTIFICATE_EXPIRATION]`   | 인증서 만료 전 남은 기간으로 해결됩니다(유효 단위: "s", "m", "h")                           | `24h`, `48h`, 0 (인증서 없는 프로토콜의 경우) |
| `[DOMAIN_EXPIRATION]`        | 도메인 만료 전 남은 기간으로 해결됩니다(유효 단위: "s", "m", "h")                           | `24h`, `48h`, `1234h56m78s`                |
| `[DNS_RCODE]`                | 응답의 DNS 상태로 해결됩니다                                                                 | `NOERROR`                                  |


#### 함수
| 함수      | 설명                                                                                                                                                                                                                   | 예시                              |
|:----------|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------|
| `len`     | 경로가 배열을 가리키면 그 길이를 반환합니다. 그렇지 않으면 경로의 JSON을 압축하여 문자열로 변환한 후 문자 수를 반환합니다. `[BODY]` 플레이스홀더에서만 작동합니다.                                                        | `len([BODY].username) > 8`       |
| `has`     | 주어진 경로가 유효한지에 따라 `true` 또는 `false`를 반환합니다. `[BODY]` 플레이스홀더에서만 작동합니다.                                                                                                                 | `has([BODY].errors) == false`    |
| `pat`     | 파라미터로 전달된 문자열을 패턴으로 평가해야 함을 지정합니다. `==` 및 `!=`에서만 작동합니다.                                                                                                                           | `[IP] == pat(192.168.*)`         |
| `any`     | 전달된 여러 값 중 하나라도 유효한 값임을 지정합니다. `==` 및 `!=`에서만 작동합니다.                                                                                                                                    | `[BODY].ip == any(127.0.0.1, ::1)` |

> 💡 `pat`는 필요한 경우에만 사용하세요. `[STATUS] == pat(2*)`는 `[STATUS] < 300`보다 훨씬 비용이 많이 듭니다.


### 저장소
| 파라미터                            | 설명                                                                                                                                            | 기본값      |
|:----------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------------|:------------|
| `storage`                         | 저장소 구성                                                                                                                                     | `{}`        |
| `storage.path`                    | 데이터를 저장할 경로입니다. `sqlite` 및 `postgres` 타입에서만 지원됩니다.                                                                        | `""`        |
| `storage.type`                    | 저장소 타입입니다. 유효한 타입: `memory`, `sqlite`, `postgres`.                                                                                | `"memory"`  |
| `storage.caching`                 | 쓰기-스루 캐싱 사용 여부입니다. 대형 대시보드의 로딩 시간을 개선합니다. <br />`storage.type`이 `sqlite` 또는 `postgres`일 때만 지원됩니다.           | `false`     |
| `storage.maximum-number-of-results` | 엔드포인트가 가질 수 있는 최대 결과 수                                                                                                         | `100`       |
| `storage.maximum-number-of-events`  | 엔드포인트가 가질 수 있는 최대 이벤트 수                                                                                                       | `50`        |

각 엔드포인트 헬스 체크 결과와 가동 시간 및 과거 이벤트 데이터는 대시보드에 표시될 수 있도록
저장되어야 합니다. 이 파라미터들은 해당 저장소를 구성할 수 있게 합니다.

- `storage.type`이 `memory`(기본값)인 경우:

```yaml
# Note that this is the default value, and you can omit the storage configuration altogether to achieve the same result.
# Because the data is stored in memory, the data will not survive a restart.
storage:
  type: memory
  maximum-number-of-results: 200
  maximum-number-of-events: 5
```
- `storage.type`이 `sqlite`인 경우, `storage.path`는 비워 둘 수 없습니다:
```yaml
storage:
  type: sqlite
  path: data.db
```
[examples/docker-compose-sqlite-storage](.examples/docker-compose-sqlite-storage)을 참조하세요.

- `storage.type`이 `postgres`인 경우, `storage.path`는 연결 URL이어야 합니다:
```yaml
storage:
  type: postgres
  path: "postgres://user:password@127.0.0.1:5432/gatus?sslmode=disable"
```
[examples/docker-compose-postgres-storage](.examples/docker-compose-postgres-storage)을 참고하세요.


### 클라이언트 구성
광범위한 환경을 지원하기 위해, 각 모니터링 대상 엔드포인트는
요청을 보내는 데 사용되는 클라이언트에 대해 고유한 구성을 가집니다.

| 매개변수                              | 설명                                                                        | 기본값          |
|:---------------------------------------|:----------------------------------------------------------------------------|:----------------|
| `client.insecure`                      | 서버의 인증서 체인과 호스트 이름 검증을 건너뛸지 여부입니다.                  | `false`         |
| `client.ignore-redirect`               | 리다이렉트를 무시할지(true) 아니면 따를지(false, 기본값)입니다.              | `false`         |
| `client.timeout`                       | 타임아웃까지의 시간입니다.                                                   | `10s`           |
| `client.dns-resolver`                  | `{proto}://{host}:{port}` 형식으로 DNS 리졸버를 재정의합니다.                 | `""`            |
| `client.oauth2`                        | OAuth2 클라이언트 구성입니다.                                                | `{}`            |
| `client.oauth2.token-url`              | 토큰 엔드포인트 URL입니다.                                                   | 필수 `""`       |
| `client.oauth2.client-id`              | `클라이언트 자격 증명 흐름`에 사용될 클라이언트 ID입니다.                    | 필수 `""`       |
| `client.oauth2.client-secret`          | `클라이언트 자격 증명 흐름`에 사용될 클라이언트 비밀키입니다.                | 필수 `""`       |
| `client.oauth2.scopes[]`               | `클라이언트 자격 증명 흐름`에 사용될 `scopes` 목록입니다.                    | 필수 `[""]`     |
| `client.proxy-url`                     | 클라이언트에 사용할 프록시 URL입니다.                                        | `""`            |
| `client.identity-aware-proxy`          | Google Identity-Aware-Proxy 클라이언트 구성입니다.                           | `{}`            |
| `client.identity-aware-proxy.audience` | Identity-Aware-Proxy 대상자입니다. (IAP oauth2 자격 증명의 client-id)         | 필수 `""`       |
| `client.tls.certificate-file`          | mTLS 구성을 위한 클라이언트 인증서 경로 (PEM 형식)입니다.                    | `""`            |
| `client.tls.private-key-file`          | mTLS 구성을 위한 클라이언트 개인 키 경로 (PEM 형식)입니다.                   | `""`            |
| `client.tls.renegotiation`             | 제공할 재협상 지원 유형입니다. (`never`, `freely`, `once`)                   | `"never"`       |
| `client.network`                       | ICMP 엔드포인트 클라이언트에 사용할 네트워크 (`ip`, `ip4` 또는 `ip6`)입니다. | `"ip"`          |


> 📝 일부 매개변수는 엔드포인트 유형에 따라 무시됩니다. 예를 들어, ICMP 요청(ping)에는 인증서가 필요 없으므로,
> 해당 유형의 엔드포인트에 대해 `client.insecure`를 `true`로 설정해도 아무런 효과가 없습니다.

기본 구성은 다음과 같습니다:

```yaml
client:
  insecure: false
  ignore-redirect: false
  timeout: 10s
```


이 구성은 `endpoints[]`, `alerting.mattermost` 및 `alerting.custom` 하에서만 사용할 수 있다는 점에 유의하십시오.

다음은 `endpoints[]` 아래에 클라이언트 구성이 있는 예입니다:


```yaml
endpoints:
  - name: website
    url: "https://twin.sh/health"
    client:
      insecure: false
      ignore-redirect: false
      timeout: 10s
    conditions:
      - "[STATUS] == 200"
```
이 예제는 사용자 지정 DNS 해석기를 지정하는 방법을 보여줍니다:


```yaml
endpoints:
  - name: with-custom-dns-resolver
    url: "https://your.health.api/health"
    client:
      dns-resolver: "tcp://8.8.8.8:53"
    conditions:
      - "[STATUS] == 200"
```
이 예제는 `client.oauth2` 구성을 사용하여 `Bearer token`으로 백엔드 API를 쿼리하는 방법을 보여줍니다:


```yaml
endpoints:
  - name: with-custom-oauth2
    url: "https://your.health.api/health"
    client:
      oauth2:
        token-url: https://your-token-server/token
        client-id: 00000000-0000-0000-0000-000000000000
        client-secret: your-client-secret
        scopes: ['https://your.health.api/.default']
    conditions:
      - "[STATUS] == 200"
```
이 예제는 Google Identity-Aware-Proxy를 사용하여 `Bearer token`으로 백엔드 API를 쿼리하기 위해 `client.identity-aware-proxy` 구성을 사용하는 방법을 보여줍니다:


```yaml
endpoints:
  - name: with-custom-iap
    url: "https://my.iap.protected.app/health"
    client:
      identity-aware-proxy:
        audience: "XXXXXXXX-XXXXXXXXXXXX.apps.googleusercontent.com"
    conditions:
      - "[STATUS] == 200"
```
> 📝 Gatus가 토큰을 생성하기 위해 환경 내에서 [gcloud 기본 자격 증명](https://cloud.google.com/docs/authentication/application-default-credentials)을 사용할 것임을 참고하세요.

이 예제는 `client.tls` 구성을 사용하여 백엔드 API에 mTLS 쿼리를 수행하는 방법을 보여줍니다:


```yaml
endpoints:
  - name: website
    url: "https://your.mtls.protected.app/health"
    client:
      tls:
        certificate-file: /path/to/user_cert.pem
        private-key-file: /path/to/user_key.pem
        renegotiation: once
    conditions:
      - "[STATUS] == 200"
```
> 📝 컨테이너에서 실행하는 경우, 인증서와 키를 컨테이너에 볼륨 마운트해야 한다는 점에 유의하세요.

### 알림
Gatus는 Slack, PagerDuty 등 여러 알림 제공자를 지원하며, 각 개별 엔드포인트에 대해 구성 가능한 설명과 임계값으로
서로 다른 알림을 지원합니다.

알림은 다음과 같이 엔드포인트 수준에서 구성됩니다:

| 매개변수                     | 설명                                                                            | 기본값        |
|:-----------------------------|:--------------------------------------------------------------------------------|:--------------|
| `alerts`                     | 주어진 엔드포인트에 대한 모든 알림 목록입니다.                                  | `[]`          |
| `alerts[].type`              | 알림 유형입니다. <br />모든 유효한 유형은 아래 표를 참조하세요.                 | 필수 `""`    |
| `alerts[].enabled`           | 알림 활성화 여부입니다.                                                         | `true`        |
| `alerts[].failure-threshold` | 알림을 트리거하기 전에 연속 실패 횟수입니다.                                   | `3`           |
| `alerts[].success-threshold` | 진행 중인 사건이 해결된 것으로 표시되기 전 연속 성공 횟수입니다.                 | `2`           |
| `alerts[].send-on-resolved`  | 트리거된 알림이 해결된 것으로 표시되면 알림을 보낼지 여부입니다.                 | `false`       |
| `alerts[].description`       | 알림에 포함될 알림 설명입니다.                                                  | `""`          |
| `alerts[].provider-override` | 주어진 알림 유형에 대한 알림 제공자 구성 재정의입니다.                          | `{}`          |

다음은 엔드포인트 수준에서 알림 구성이 어떻게 보일 수 있는지에 대한 예시입니다:

```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
        description: "healthcheck failed"
        send-on-resolved: true
```
글로벌 공급자 구성을 `alerts[].provider-override`를 사용하여 다음과 같이 재정의할 수도 있습니다:

```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
        provider-override:
          webhook-url: "https://hooks.slack.com/services/**********/**********/**********"
```
> 📝 경고 제공자가 올바르게 구성되지 않은 경우, 제공자 유형으로 구성된 모든 경고는
> 무시됩니다.

| Parameter                  | 설명                                                                                                                              | 기본값  |
|:---------------------------|:---------------------------------------------------------------------------------------------------------------------------------|:--------|
| `alerting.awsses`          | `awsses` 유형 경고 구성입니다. <br />자세한 내용은 [AWS SES 경고 구성하기](#configuring-aws-ses-alerts)를 참조하세요.          | `{}`    |
| `alerting.custom`          | 실패 또는 경고 시 사용자 지정 작업 구성입니다. <br />자세한 내용은 [사용자 지정 경고 구성하기](#configuring-custom-alerts)를 참조하세요. | `{}`    |
| `alerting.discord`         | `discord` 유형 경고 구성입니다. <br />자세한 내용은 [Discord 경고 구성하기](#configuring-discord-alerts)를 참조하세요.       | `{}`    |
| `alerting.email`           | `email` 유형 경고 구성입니다. <br />자세한 내용은 [이메일 경고 구성하기](#configuring-email-alerts)를 참조하세요.           | `{}`    |
| `alerting.gitea`           | `gitea` 유형 경고 구성입니다. <br />자세한 내용은 [Gitea 경고 구성하기](#configuring-gitea-alerts)를 참조하세요.             | `{}`    |
| `alerting.github`          | `github` 유형 경고 구성입니다. <br />자세한 내용은 [GitHub 경고 구성하기](#configuring-github-alerts)를 참조하세요.          | `{}`    |
| `alerting.gitlab`          | `gitlab` 유형 경고 구성입니다. <br />자세한 내용은 [GitLab 경고 구성하기](#configuring-gitlab-alerts)를 참조하세요.          | `{}`    |
| `alerting.googlechat`      | `googlechat` 유형 경고 구성입니다. <br />자세한 내용은 [Google Chat 경고 구성하기](#configuring-google-chat-alerts)를 참조하세요. | `{}`    |
| `alerting.gotify`          | `gotify` 유형 경고 구성입니다. <br />자세한 내용은 [Gotify 경고 구성하기](#configuring-gotify-alerts)를 참조하세요.          | `{}`    |
| `alerting.ilert`           | `ilert` 유형 경고 구성입니다. <br />자세한 내용은 [ilert 경고 구성하기](#configuring-ilert-alerts)를 참조하세요.             | `{}`    |
| `alerting.incident-io`     | `incident-io` 유형 경고 구성입니다. <br />자세한 내용은 [Incident.io 경고 구성하기](#configuring-incidentio-alerts)를 참조하세요. | `{}`    |
| `alerting.jetbrainsspace`  | `jetbrainsspace` 유형 경고 구성입니다. <br />자세한 내용은 [JetBrains Space 경고 구성하기](#configuring-jetbrains-space-alerts)를 참조하세요. | `{}`    |
| `alerting.matrix`          | `matrix` 유형 경고 구성입니다. <br />자세한 내용은 [Matrix 경고 구성하기](#configuring-matrix-alerts)를 참조하세요.          | `{}`    |
| `alerting.mattermost`      | `mattermost` 유형 경고 구성입니다. <br />자세한 내용은 [Mattermost 경고 구성하기](#configuring-mattermost-alerts)를 참조하세요. | `{}`    |
| `alerting.messagebird`     | `messagebird` 유형 경고 구성입니다. <br />자세한 내용은 [Messagebird 경고 구성하기](#configuring-messagebird-alerts)를 참조하세요. | `{}`    |
| `alerting.ntfy`            | `ntfy` 유형 경고 구성입니다. <br />자세한 내용은 [Ntfy 경고 구성하기](#configuring-ntfy-alerts)를 참조하세요.                | `{}`    |
| `alerting.opsgenie`        | `opsgenie` 유형 경고 구성입니다. <br />자세한 내용은 [Opsgenie 경고 구성하기](#configuring-opsgenie-alerts)를 참조하세요.    | `{}`    |
| `alerting.pagerduty`       | `pagerduty` 유형 경고 구성입니다. <br />자세한 내용은 [PagerDuty 경고 구성하기](#configuring-pagerduty-alerts)를 참조하세요.  | `{}`    |
| `alerting.pushover`        | `pushover` 유형 경고 구성입니다. <br />자세한 내용은 [Pushover 경고 구성하기](#configuring-pushover-alerts)를 참조하세요.    | `{}`    |
| `alerting.slack`           | `slack` 유형 경고 구성입니다. <br />자세한 내용은 [Slack 경고 구성하기](#configuring-slack-alerts)를 참조하세요.             | `{}`    |
| `alerting.teams`           | `teams` 유형 경고 구성입니다. *(더 이상 사용되지 않음)* <br />자세한 내용은 [Teams 경고 구성하기](#configuring-teams-alerts-deprecated)를 참조하세요. | `{}`    |
| `alerting.teams-workflows` | `teams-workflows` 유형 경고 구성입니다. <br />자세한 내용은 [Teams Workflow 경고 구성하기](#configuring-teams-workflow-alerts)를 참조하세요. | `{}`    |
| `alerting.telegram`        | `telegram` 유형 경고 구성입니다. <br />자세한 내용은 [Telegram 경고 구성하기](#configuring-telegram-alerts)를 참조하세요.    | `{}`    |
| `alerting.twilio`          | `twilio` 유형 경고 설정입니다. <br />자세한 내용은 [Twilio 경고 구성하기](#configuring-twilio-alerts)를 참조하세요.           | `{}`    |
| `alerting.zulip`           | `zulip` 유형 경고 구성입니다. <br />자세한 내용은 [Zulip 경고 구성하기](#configuring-zulip-alerts)를 참조하세요.             | `{}`    |
| `alerting.homeassistant`   | `homeassistant` 유형 경고 구성입니다. <br />자세한 내용은 [HomeAssistant 경고 구성하기](#configuring-homeassistant-alerts)를 참조하세요. | `{}`    |


#### AWS SES 경고 구성하기
| Parameter                            | 설명                                                                                       | 기본값        |
|:-------------------------------------|:------------------------------------------------------------------------------------------|:--------------|
| `alerting.aws-ses`                   | `aws-ses` 유형 경고 설정입니다.                                                           | `{}`          |
| `alerting.aws-ses.access-key-id`     | AWS 액세스 키 ID                                                                           | 선택 사항 `""` |
| `alerting.aws-ses.secret-access-key` | AWS 비밀 액세스 키                                                                         | 선택 사항 `""` |
| `alerting.aws-ses.region`            | AWS 리전                                                                                   | 필수 사항 `""` |
| `alerting.aws-ses.from`              | 이메일을 보낼 주소 (SES에 등록되어 있어야 함)                                            | 필수 사항 `""` |
| `alerting.aws-ses.to`                | 알림 받을 이메일 주소를 콤마로 구분한 목록                                               | 필수 사항 `""` |
| `alerting.aws-ses.default-alert`     | 기본 경고 구성입니다. <br />자세한 내용은 [기본 경고 설정하기](#setting-a-default-alert)를 참조하세요. | 해당 없음     |


```yaml
alerting:
  aws-ses:
    access-key-id: "..."
    secret-access-key: "..."
    region: "us-east-1"
    from: "status@example.com"
    to: "user@example.com"

endpoints:
  - name: website
    interval: 30s
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: aws-ses
        failure-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```


`access-key-id`와 `secret-access-key`가 정의되지 않은 경우 Gatus는 IAM 인증으로 대체합니다.

`ses:SendEmail`을 사용할 수 있는지 확인하세요.


#### Discord 알림 구성
| 매개변수                             | 설명                                                                                     | 기본값                              |
|:-------------------------------------|:-------------------------------------------------------------------------------------------|:------------------------------------|
| `alerting.discord`                   | `discord` 유형 알림 구성                                                                  | `{}`                                |
| `alerting.discord.webhook-url`       | Discord 웹후크 URL                                                                        | 필수 `""`                          |
| `alerting.discord.title`             | 알림 제목                                                                                 | `":helmet_with_white_cross: Gatus"` |
| `alerting.discord.default-alert`     | 기본 알림 구성입니다. <br />[기본 알림 설정](#setting-a-default-alert) 참조                  | 해당 없음                          |
| `alerting.discord.overrides`         | 기본 구성보다 우선시될 수 있는 오버라이드 목록                                            | `[]`                                |
| `alerting.discord.overrides[].group` | 이 구성으로 대체될 엔드포인트 그룹                                                        | `""`                                |
| `alerting.discord.overrides[].*`     | `alerting.discord.*` 매개변수 참조                                                        | `{}`                                |


```yaml
alerting:
  discord:
    webhook-url: "https://discord.com/api/webhooks/**********/**********"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: discord
        description: "healthcheck failed"
        send-on-resolved: true
```
#### 이메일 알림 구성
| 매개변수                            | 설명                                                                                          | 기본값        |
|:-----------------------------------|:----------------------------------------------------------------------------------------------|:--------------|
| `alerting.email`                   | `email` 유형 알림 구성                                                                         | `{}`          |
| `alerting.email.from`              | 알림을 보내는 데 사용되는 이메일                                                                | 필수 `""`     |
| `alerting.email.username`          | 알림을 보내는 데 사용되는 SMTP 서버의 사용자 이름. 비어 있으면 `alerting.email.from` 사용          | `""`          |
| `alerting.email.password`          | 알림을 보내는 데 사용되는 SMTP 서버의 비밀번호. 비어 있으면 인증을 수행하지 않음                    | `""`          |
| `alerting.email.host`              | 메일 서버 호스트 (예: `smtp.gmail.com`)                                                        | 필수 `""`     |
| `alerting.email.port`              | 메일 서버가 청취하는 포트 (예: `587`)                                                          | 필수 `0`      |
| `alerting.email.to`                | 알림을 보낼 이메일(들)                                                                          | 필수 `""`     |
| `alerting.email.default-alert`     | 기본 알림 구성 <br />[기본 알림 설정](#setting-a-default-alert) 참조                             | 해당 없음     |
| `alerting.email.client.insecure`   | TLS 검증을 건너뛸지 여부                                                                       | `false`       |
| `alerting.email.overrides`         | 기본 구성보다 우선시될 수 있는 재정의 목록                                                      | `[]`          |
| `alerting.email.overrides[].group` | 이 구성으로 재정의될 엔드포인트 그룹                                                           | `""`          |
| `alerting.email.overrides[].*`     | `alerting.email.*` 매개변수 참조                                                               | `{}`          |



```yaml
alerting:
  email:
    from: "from@example.com"
    username: "from@example.com"
    password: "hunter2"
    host: "mail.example.com"
    port: 587
    to: "recipient1@example.com,recipient2@example.com"
    client:
      insecure: false
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "core"
        to: "recipient3@example.com,recipient4@example.com"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: email
        description: "healthcheck failed"
        send-on-resolved: true

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: email
        description: "healthcheck failed"
        send-on-resolved: true
```
> ⚠ 일부 메일 서버는 매우 느릴 수 있습니다.

#### Gitea 알림 구성

| 매개변수                          | 설명                                                                                                     | 기본값         |
|:--------------------------------|:-------------------------------------------------------------------------------------------------------|:--------------|
| `alerting.gitea`                | `gitea` 유형 알림에 대한 구성                                                                             | `{}`          |
| `alerting.gitea.repository-url` | Gitea 저장소 URL (예: `https://gitea.com/TwiN/example`)                                                | 필수 `""`     |
| `alerting.gitea.token`          | 인증에 사용할 개인 액세스 토큰. <br />이슈에 대해 최소 RW, 메타데이터에 대해 RO 권한이 필요합니다.         | 필수 `""`     |
| `alerting.github.default-alert` | 기본 알림 구성. <br />자세한 내용은 [기본 알림 설정](#setting-a-default-alert)을 참조하세요.               | 해당 없음      |

Gitea 알림 공급자는 각 알림에 대해 `alert(gatus):`로 시작하고 엔드포인트 표시 이름으로 끝나는 이슈를 생성합니다.  
엔드포인트 알림에서 `send-on-resolved`가 `true`로 설정된 경우, 알림이 해결되면 이슈가 자동으로 닫힙니다.



```yaml
alerting:
  gitea:
    repository-url: "https://gitea.com/TwiN/test"
    token: "349d63f16......"

endpoints:
  - name: example
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 75"
    alerts:
      - type: gitea
        failure-threshold: 2
        success-threshold: 3
        send-on-resolved: true
        description: "Everything's burning AAAAAHHHHHHHHHHHHHHH"
```
![Gitea 경고](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gitea-alerts.png)

#### GitHub 경고 구성하기

| 매개변수                         | 설명                                                                                                   | 기본값         |
|:---------------------------------|:-------------------------------------------------------------------------------------------------------|:--------------|
| `alerting.github`                | `github` 유형의 경고 구성을 위한 설정                                                                    | `{}`          |
| `alerting.github.repository-url` | GitHub 저장소 URL (예: `https://github.com/TwiN/example`)                                               | 필수 `""`     |
| `alerting.github.token`          | 인증에 사용할 개인 액세스 토큰. <br />이슈에 대해 최소 RW 권한, 메타데이터에 대해 RO 권한이 필요합니다.    | 필수 `""`     |
| `alerting.github.default-alert`  | 기본 경고 구성. <br />자세한 내용은 [기본 경고 설정](#setting-a-default-alert)을 참조하세요.              | 해당 없음       |

GitHub 경고 제공자는 각 경고에 대해 `alert(gatus):`로 시작하고 엔드포인트 표시 이름으로 끝나는 이슈를 생성합니다.  
엔드포인트 경고에서 `send-on-resolved`가 `true`로 설정된 경우, 경고가 해결되면 이슈가 자동으로 닫힙니다.



```yaml
alerting:
  github:
    repository-url: "https://github.com/TwiN/test"
    token: "github_pat_12345..."

endpoints:
  - name: example
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 75"
    alerts:
      - type: github
        failure-threshold: 2
        success-threshold: 3
        send-on-resolved: true
        description: "Everything's burning AAAAAHHHHHHHHHHHHHHH"
```
![GitHub alert](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/github-alerts.png)

#### GitLab 알림 구성하기
| 매개변수                             | 설명                                                                                                               | 기본값        |
|:------------------------------------|:--------------------------------------------------------------------------------------------------------------------|:--------------|
| `alerting.gitlab`                   | `gitlab` 유형 알림 구성                                                                                             | `{}`          |
| `alerting.gitlab.webhook-url`       | GitLab 알림 웹훅 URL (예: `https://gitlab.com/yourusername/example/alerts/notify/gatus/xxxxxxxxxxxxxxxx.json`)         | 필수 `""`     |
| `alerting.gitlab.authorization-key` | GitLab 알림 인증 키.                                                                                                | 필수 `""`     |
| `alerting.gitlab.severity`          | 기본 심각도(critical) 재정의, `critical, high, medium, low, info, unknown` 중 하나일 수 있음                          | `""`          |
| `alerting.gitlab.monitoring-tool`   | 모니터링 도구 이름 재정의 (gatus)                                                                                    | `"gatus"`     |
| `alerting.gitlab.environment-name`  | GitLab 환경 이름 설정. 대시보드에 알림을 표시하려면 필수입니다.                                                     | `""`          |
| `alerting.gitlab.service`           | 엔드포인트 표시 이름 재정의                                                                                         | `""`          |
| `alerting.gitlab.default-alert`     | 기본 알림 구성. <br />[기본 알림 설정](#setting-a-default-alert) 참조                                               | 해당 없음     |

GitLab 알림 공급자는 각 알림에 대해 `alert(gatus):` 접두사와 엔드포인트 표시 이름 접미사가 붙은 알림을 생성합니다.  
엔드포인트 알림에서 `send-on-resolved`가 `true`로 설정된 경우, 알림이 해결되면 자동으로 닫힙니다.  
엔드포인트 구성을 위해 https://docs.gitlab.com/ee/operations/incident_management/integrations.html#configuration 를 참조하세요.



```yaml
alerting:
  gitlab:
    webhook-url: "https://gitlab.com/hlidotbe/example/alerts/notify/gatus/xxxxxxxxxxxxxxxx.json"
    authorization-key: "12345"

endpoints:
  - name: example
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 75"
    alerts:
      - type: gitlab
        failure-threshold: 2
        success-threshold: 3
        send-on-resolved: true
        description: "Everything's burning AAAAAHHHHHHHHHHHHHHH"
```
![GitLab alert](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gitlab-alerts.png)


#### Google Chat 알림 설정
| 매개변수                                | 설명                                                                                       | 기본값        |
|:----------------------------------------|:--------------------------------------------------------------------------------------------|:--------------|
| `alerting.googlechat`                   | `googlechat` 유형 알림 구성                                                                | `{}`          |
| `alerting.googlechat.webhook-url`       | Google Chat Webhook URL                                                                     | 필수 `""`     |
| `alerting.googlechat.client`            | 클라이언트 구성. <br />[클라이언트 구성](#client-configuration)을 참조하세요.                | `{}`          |
| `alerting.googlechat.default-alert`     | 기본 알림 구성. <br />[기본 알림 설정](#setting-a-default-alert)을 참조하세요.              | 해당 없음     |
| `alerting.googlechat.overrides`         | 기본 구성을 우선할 수 있는 재정의 목록                                                     | `[]`          |
| `alerting.googlechat.overrides[].group` | 이 구성이 재정의될 엔드포인트 그룹                                                         | `""`          |
| `alerting.googlechat.overrides[].*`     | `alerting.googlechat.*` 매개변수를 참조하세요                                            | `{}`          |


```yaml
alerting:
  googlechat:
    webhook-url: "https://chat.googleapis.com/v1/spaces/*******/messages?key=**********&token=********"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: googlechat
        description: "healthcheck failed"
        send-on-resolved: true
```
#### Gotify 알림 구성
| 매개변수                                    | 설명                                                                                        | 기본값                 |
|:----------------------------------------------|:--------------------------------------------------------------------------------------------|:----------------------|
| `alerting.gotify`                             | `gotify` 유형 알림 구성                                                                    | `{}`                  |
| `alerting.gotify.server-url`                  | Gotify 서버 URL                                                                             | 필수 `""`             |
| `alerting.gotify.token`                       | 인증에 사용되는 토큰                                                                        | 필수 `""`             |
| `alerting.gotify.priority`                    | Gotify 표준에 따른 알림 우선순위                                                           | `5`                   |
| `alerting.gotify.title`                       | 알림 제목                                                                                   | `"Gatus: <endpoint>"` |
| `alerting.gotify.default-alert`               | 기본 알림 구성 <br />[기본 알림 설정](#setting-a-default-alert) 참조                        | 해당 없음             |

#### ilert 알림 구성
| 매개변수                              | 설명                                                                                         | 기본값  |
|:---------------------------------------|:---------------------------------------------------------------------------------------------|:--------|
| `alerting.ilert`                   | `ilert` 유형 알림 구성                                                                     | `{}`    |
| `alerting.ilert.integration-key`   | ilert Alert Source 통합 키                                                                 | `""`    |
| `alerting.ilert.default-alert`     | 기본 알림 구성 <br />[기본 알림 설정](#setting-a-default-alert) 참조                         | 해당 없음 |
| `alerting.ilert.overrides`         | 기본 구성보다 우선시될 수 있는 재정의 목록                                                  | `[]`    |
| `alerting.ilert.overrides[].group` | 이 구성으로 재정의될 엔드포인트 그룹                                                        | `""`    |
| `alerting.ilert.overrides[].*`     | `alerting.ilert.*` 매개변수 참조                                                           | `{}`    |

`ilert` 유형 알림의 경우, `endpoints[].alerts[].send-on-resolved`를 `true`로 설정하는 것이 강력히 권장됩니다.  
이는 다른 알림과 달리, 이 매개변수를 `true`로 설정해도 새로운 알림이 생성되지 않고 대신 ilert에서 해당 알림이 해결됨으로 표시되기 때문입니다.

동작 방식:  
- 기본적으로 `alerting.ilert.integration-key`가 통합 키로 사용됩니다.  
- 평가 중인 엔드포인트가 `alerting.ilert.overrides[].group`의 값과 일치하는 그룹(`endpoints[].group`)에 속한 경우, 공급자는 `alerting.ilert.integration-key` 대신 해당 재정의의 통합 키를 사용합니다.





```yaml
alerting:
  ilert:
    integration-key: "********************************"
    # You can also add group-specific integration keys, which will
    # override the integration key above for the specified groups
    overrides:
      - group: "core"
        integration-key: "********************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: ilert
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```

```yaml
alerting:
  gotify:
    server-url: "https://gotify.example"
    token: "**************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: gotify
        description: "healthcheck failed"
        send-on-resolved: true
```


알림이 어떻게 표시되는지에 대한 예는 다음과 같습니다:

![Gotify 알림](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gotify-alerts.png)


#### HomeAssistant 알림 구성하기
HomeAssistant 알림을 구성하려면 구성 파일에 다음을 추가해야 합니다:


```yaml
alerting:
  homeassistant:
    url: "http://homeassistant:8123"  # URL of your HomeAssistant instance
    token: "YOUR_LONG_LIVED_ACCESS_TOKEN"  # Long-lived access token from HomeAssistant

endpoints:
  - name: my-service
    url: "https://my-service.com"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: homeassistant
        enabled: true
        send-on-resolved: true
        description: "My service health check"
        failure-threshold: 3
        success-threshold: 2
```


경고는 이벤트 유형 `gatus_alert`와 함께 HomeAssistant로 이벤트로 전송됩니다. 이벤트 데이터에는 다음이 포함됩니다:
- `status`: "triggered" 또는 "resolved"
- `endpoint`: 모니터링되는 엔드포인트의 이름
- `description`: 제공된 경우 경고 설명
- `conditions`: 조건 목록 및 그 결과
- `failure_count`: 연속 실패 횟수 (발생 시)
- `success_count`: 연속 성공 횟수 (해결 시)

이 이벤트들을 HomeAssistant 자동화에서 사용하여:
- 알림 전송
- 장치 제어
- 장면 트리거
- 기록에 로그
- 기타 등등

HomeAssistant 자동화 예시:


```yaml
automation:
  - alias: "Gatus Alert Handler"
    trigger:
      platform: event
      event_type: gatus_alert
    action:
      - service: notify.notify
        data_template:
          title: "Gatus Alert: {{ trigger.event.data.endpoint }}"
          message: >
            Status: {{ trigger.event.data.status }}
            {% if trigger.event.data.description %}
            Description: {{ trigger.event.data.description }}
            {% endif %}
            {% for condition in trigger.event.data.conditions %}
            {{ '✅' if condition.success else '❌' }} {{ condition.condition }}
            {% endfor %}
```
홈어시스턴트 장기 액세스 토큰을 얻으려면:
1. 홈어시스턴트를 엽니다
2. 프로필 이름을 클릭합니다 (왼쪽 하단)
3. "장기 액세스 토큰"까지 스크롤합니다
4. "토큰 생성"을 클릭합니다
5. 이름을 지정합니다 (예: "Gatus")
6. 토큰을 복사합니다 - 한 번만 볼 수 있습니다!


#### Incident.io 알림 구성
| 매개변수                                  | 설명                                                                                      | 기본값        |
|:-----------------------------------------|:------------------------------------------------------------------------------------------|:-------------|
| `alerting.incident-io`                   | `incident-io` 유형 알림 구성                                                              | `{}`         |
| `alerting.incident-io.url`               | 알림 이벤트를 트리거할 URL                                                                 | 필수 `""`    |
| `alerting.incident-io.auth-token`        | 인증에 사용되는 토큰                                                                       | 필수 `""`    |
| `alerting.incident-io.source-url`        | 소스 URL                                                                                   | `""`         |
| `alerting.incident-io.default-alert`     | 기본 알림 구성 <br />[기본 알림 설정](#setting-a-default-alert) 참조                       | N/A          |
| `alerting.incident-io.overrides`         | 기본 구성보다 우선할 수 있는 재정의 목록                                                   | `[]`         |
| `alerting.incident-io.overrides[].group` | 이 구성이 재정의될 엔드포인트 그룹                                                        | `""`         |
| `alerting.incident-io.overrides[].*`     | `alerting.incident-io.*` 매개변수 참조                                                    | `{}`         |


```yaml
alerting:
  incident-io:
    url: "*****************"
    auth-token: "********************************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: incident-io
        description: "healthcheck failed"
        send-on-resolved: true
```
In order to get the required alert source config id and authentication token, you must configure an HTTP alert source.

> **_NOTE:_**  the source config id is of the form `https://api.incident.io/v2/alert_events/http/$ID` and the token is expected to be passed as a bearer token like so: `Authorization: Bearer $TOKEN`


#### Configuring JetBrains Space alerts
| Parameter                                   | Description                                                                                | Default       |
|:--------------------------------------------|:-------------------------------------------------------------------------------------------|:--------------|
| `alerting.jetbrainsspace`                   | `jetbrainsspace` 유형 알림 구성을 위한 설정                                               | `{}`          |
| `alerting.jetbrainsspace.project`           | JetBrains Space 프로젝트 이름                                                              | 필수 `""`     |
| `alerting.jetbrainsspace.channel-id`        | JetBrains Space 채팅 채널 ID                                                               | 필수 `""`     |
| `alerting.jetbrainsspace.token`             | 인증에 사용되는 토큰                                                                        | 필수 `""`     |
| `alerting.jetbrainsspace.default-alert`     | 기본 알림 구성입니다. <br />자세한 내용은 [기본 알림 설정](#setting-a-default-alert) 참조 | 해당 없음      |
| `alerting.jetbrainsspace.overrides`         | 기본 구성보다 우선시될 수 있는 오버라이드 목록                                             | `[]`          |
| `alerting.jetbrainsspace.overrides[].group` | 이 구성으로 오버라이드될 엔드포인트 그룹                                                  | `""`          |
| `alerting.jetbrainsspace.overrides[].*`     | `alerting.jetbrainsspace.*` 매개변수 참조                                                 | `{}`          |

```yaml
alerting:
  jetbrainsspace:
    project: myproject
    channel-id: ABCDE12345
    token: "**************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: jetbrainsspace
        description: "healthcheck failed"
        send-on-resolved: true
```


알림이 어떻게 표시되는지에 대한 예시는 다음과 같습니다:

![JetBrains Space 알림](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/jetbrains-space-alerts.png)


#### Matrix 알림 구성하기
| 매개변수                                | 설명                                                                                      | 기본값                             |
|:-----------------------------------------|:-------------------------------------------------------------------------------------------|:-----------------------------------|
| `alerting.matrix`                        | `matrix` 유형 알림에 대한 구성                                                              | `{}`                               |
| `alerting.matrix.server-url`             | 홈서버 URL                                                                                | `https://matrix-client.matrix.org` |
| `alerting.matrix.access-token`           | 봇 사용자 액세스 토큰 (https://webapps.stackexchange.com/q/131056 참조)                      | 필수 `""`                         |
| `alerting.matrix.internal-room-id`       | 알림을 보낼 내부 룸 ID (룸 설정 > 고급에서 확인 가능)                                      | 필수 `""`                         |
| `alerting.matrix.default-alert`          | 기본 알림 구성입니다. <br />[기본 알림 설정](#setting-a-default-alert) 참조                 | 해당 없음                          |


```yaml
alerting:
  matrix:
    server-url: "https://matrix-client.matrix.org"
    access-token: "123456"
    internal-room-id: "!example:matrix.org"

endpoints:
  - name: website
    interval: 5m
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: matrix
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Mattermost 알림 구성
| 매개변수                                     | 설명                                                                                       | 기본값        |
|:----------------------------------------------|:--------------------------------------------------------------------------------------------|:--------------|
| `alerting.mattermost`                         | `mattermost` 유형 알림 구성                                                                | `{}`          |
| `alerting.mattermost.webhook-url`             | Mattermost Webhook URL                                                                      | 필수 `""`     |
| `alerting.mattermost.channel`                 | Mattermost 채널 이름 재정의 (선택 사항)                                                    | `""`          |
| `alerting.mattermost.client`                  | 클라이언트 구성. <br />[클라이언트 구성](#client-configuration)을 참조하세요.               | `{}`          |
| `alerting.mattermost.default-alert`           | 기본 알림 구성. <br />[기본 알림 설정](#setting-a-default-alert)을 참조하세요.              | 해당 없음      |
| `alerting.mattermost.overrides`               | 기본 구성을 우선시할 수 있는 재정의 목록                                                  | `[]`          |
| `alerting.mattermost.overrides[].group`       | 이 구성이 재정의될 엔드포인트 그룹                                                        | `""`          |
| `alerting.mattermost.overrides[].*`           | `alerting.mattermost.*` 매개변수를 참조하세요                                            | `{}`          |



```yaml
alerting:
  mattermost:
    webhook-url: "http://**********/hooks/**********"
    client:
      insecure: true

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: mattermost
        description: "healthcheck failed"
        send-on-resolved: true
```


알림이 어떻게 표시되는지에 대한 예시는 다음과 같습니다:

![Mattermost 알림](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/mattermost-alerts.png)


#### Messagebird 알림 구성하기
| 매개변수                            | 설명                                                                                     | 기본값        |
|:-------------------------------------|:-------------------------------------------------------------------------------------------|:--------------|
| `alerting.messagebird`               | `messagebird` 유형 알림 구성                                                               | `{}`          |
| `alerting.messagebird.access-key`    | Messagebird 액세스 키                                                                      | 필수 `""`     |
| `alerting.messagebird.originator`    | 메시지 발신자                                                                              | 필수 `""`     |
| `alerting.messagebird.recipients`    | 메시지 수신자                                                                              | 필수 `""`     |
| `alerting.messagebird.default-alert` | 기본 알림 구성입니다. <br />자세한 내용은 [기본 알림 설정](#setting-a-default-alert) 참조 | 해당 없음     |

Messagebird를 사용한 **SMS** 문자 메시지 알림 전송 예시는 다음과 같습니다:

```yaml
alerting:
  messagebird:
    access-key: "..."
    originator: "31619191918"
    recipients: "31619191919,31619191920"

endpoints:
  - name: website
    interval: 5m
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: messagebird
        failure-threshold: 3
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Ntfy 알림 구성하기
| 매개변수                             | 설명                                                                                                                                        | 기본값             |
|:-------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------|:------------------|
| `alerting.ntfy`                      | `ntfy` 유형 알림 구성                                                                                                                        | `{}`              |
| `alerting.ntfy.topic`                | 알림이 전송될 주제                                                                                                                           | 필수 `""`         |
| `alerting.ntfy.url`                  | 대상 서버의 URL                                                                                                                             | `https://ntfy.sh` |
| `alerting.ntfy.token`                | 제한된 주제를 위한 [액세스 토큰](https://docs.ntfy.sh/publish/#access-tokens)                                                               | `""`              |
| `alerting.ntfy.email`                | 추가 이메일 알림을 위한 이메일 주소                                                                                                          | `""`              |
| `alerting.ntfy.click`                | 알림 클릭 시 열리는 웹사이트                                                                                                                 | `""`              |
| `alerting.ntfy.priority`             | 알림의 우선순위                                                                                                                             | `3`               |
| `alerting.ntfy.disable-firebase`     | Firebase를 통한 메시지 푸시 전송을 비활성화할지 여부. [ntfy.sh는 기본적으로 활성화](https://docs.ntfy.sh/publish/#disable-firebase)되어 있음 | `false`           |
| `alerting.ntfy.disable-cache`        | 서버 측 메시지 캐싱을 비활성화할지 여부. [ntfy.sh는 기본적으로 활성화](https://docs.ntfy.sh/publish/#message-caching)되어 있음              | `false`           |
| `alerting.ntfy.default-alert`        | 기본 알림 구성. <br />[기본 알림 설정](#setting-a-default-alert) 참조                                                                        | 해당 없음          |
| `alerting.ntfy.overrides`            | 기본 구성보다 우선시될 수 있는 재정의 목록                                                                                                   | `[]`              |
| `alerting.ntfy.overrides[].group`    | 이 구성으로 재정의될 엔드포인트 그룹                                                                                                         | `""`              |
| `alerting.ntfy.overrides[].*`        | `alerting.ntfy.*` 매개변수 참조                                                                                                             | `{}`              |

[ntfy](https://github.com/binwiederhier/ntfy)는 데스크톱 및 모바일 알림을 구독할 수 있게 해주는 훌륭한 프로젝트로, Gatus에 멋진 추가 기능입니다.

예시:



```yaml
alerting:
  ntfy:
    topic: "gatus-test-topic"
    priority: 2
    token: faketoken
    default-alert:
      failure-threshold: 3
      send-on-resolved: true
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "other"
        topic: "gatus-other-test-topic"
        priority: 4
        click: "https://example.com"

endpoints:
  - name: website
    interval: 5m
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: ntfy
  - name: other example
    group: other
    interval: 30m
    url: "https://example.com"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
    alerts:
      - type: ntfy
        description: example
```
#### Opsgenie 경고 구성
| 매개변수                          | 설명                                                                                       | 기본값                |
|:----------------------------------|:-------------------------------------------------------------------------------------------|:---------------------|
| `alerting.opsgenie`               | `opsgenie` 유형 경고에 대한 구성                                                           | `{}`                 |
| `alerting.opsgenie.api-key`       | Opsgenie API 키                                                                            | 필수 `""`            |
| `alerting.opsgenie.priority`      | 경고의 우선순위 수준                                                                       | `P1`                 |
| `alerting.opsgenie.source`        | 경고의 출처 필드                                                                           | `gatus`              |
| `alerting.opsgenie.entity-prefix` | 엔터티 필드 접두사                                                                         | `gatus-`             |
| `alerting.opsgenie.alias-prefix`  | 별칭 필드 접두사                                                                           | `gatus-healthcheck-` |
| `alerting.opsgenie.tags`          | 경고의 태그                                                                               | `[]`                 |
| `alerting.opsgenie.default-alert` | 기본 경고 구성 <br />자세한 내용은 [기본 경고 설정하기](#setting-a-default-alert) 참조   | 해당 없음             |

Opsgenie 공급자는 경고를 자동으로 열고 닫습니다.



```yaml
alerting:
  opsgenie:
    api-key: "00000000-0000-0000-0000-000000000000"
```
#### PagerDuty 알림 구성
| 매개변수                              | 설명                                                                                      | 기본값   |
|:---------------------------------------|:-----------------------------------------------------------------------------------------|:--------|
| `alerting.pagerduty`                   | `pagerduty` 유형 알림에 대한 구성                                                         | `{}`    |
| `alerting.pagerduty.integration-key`   | PagerDuty Events API v2 통합 키                                                           | `""`    |
| `alerting.pagerduty.default-alert`     | 기본 알림 구성입니다. <br />[기본 알림 설정](#setting-a-default-alert) 참조                | N/A     |
| `alerting.pagerduty.overrides`         | 기본 구성보다 우선시될 수 있는 재정의 목록                                                | `[]`    |
| `alerting.pagerduty.overrides[].group` | 이 구성이 재정의할 엔드포인트 그룹                                                       | `""`    |
| `alerting.pagerduty.overrides[].*`     | `alerting.pagerduty.*` 매개변수 참조                                                    | `{}`    |

`pagerduty` 유형 알림에 대해 `endpoints[].alerts[].send-on-resolved`를 `true`로 설정하는 것이 강력히 권장됩니다,  
다른 알림과 달리 이 매개변수를 `true`로 설정하면 또 다른 인시던트를 생성하는 대신 PagerDuty에서 인시던트를 해결된 것으로 표시하기 때문입니다.

동작:
- 기본적으로 `alerting.pagerduty.integration-key`가 통합 키로 사용됩니다
- 평가 중인 엔드포인트가 `alerting.pagerduty.overrides[].group` 값과 일치하는 그룹(`endpoints[].group`)에 속하는 경우,  
  공급자는 `alerting.pagerduty.integration-key` 대신 해당 재정의의 통합 키를 사용합니다




```yaml
alerting:
  pagerduty:
    integration-key: "********************************"
    # You can also add group-specific integration keys, which will
    # override the integration key above for the specified groups
    overrides:
      - group: "core"
        integration-key: "********************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: pagerduty
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: pagerduty
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Pushover 알림 구성하기
| 매개변수                              | 설명                                                                                                   | 기본값                      |
|:--------------------------------------|:---------------------------------------------------------------------------------------------------------|:----------------------------|
| `alerting.pushover`                   | `pushover` 유형 알림 구성                                                                               | `{}`                        |
| `alerting.pushover.application-token` | Pushover 애플리케이션 토큰                                                                              | `""`                        |
| `alerting.pushover.user-key`          | 사용자 또는 그룹 키                                                                                      | `""`                        |
| `alerting.pushover.title`             | Pushover를 통해 전송되는 모든 메시지의 고정 제목                                                        | `"Gatus: <endpoint>"`       |
| `alerting.pushover.priority`          | 모든 메시지의 우선순위, -2(매우 낮음)부터 2(긴급)까지 범위                                            | `0`                         |
| `alerting.pushover.resolved-priority` | 해결된 메시지의 우선순위 재정의, -2(매우 낮음)부터 2(긴급)까지 범위                                     | `0`                         |
| `alerting.pushover.sound`             | 모든 메시지의 사운드<br />모든 유효한 선택지는 [sounds](https://pushover.net/api#sounds) 참조             | `""`                        |
| `alerting.pushover.ttl`               | pushover 알림에서 자동으로 삭제될 메시지의 수명 설정                                                    | `0`                         |
| `alerting.pushover.device`            | 메시지를 보낼 장치 (선택 사항)<br/>자세한 내용은 [devices](https://pushover.net/api#identifiers) 참조     | `""` (모든 장치)             |
| `alerting.pushover.default-alert`     | 기본 알림 구성<br />[기본 알림 설정](#setting-a-default-alert) 참조                                     | N/A                         |



```yaml
alerting:
  pushover:
    application-token: "******************************"
    user-key: "******************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: pushover
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Slack 알림 구성
| 매개변수                          | 설명                                                                                       | 기본값        |
|:-----------------------------------|:-------------------------------------------------------------------------------------------|:--------------|
| `alerting.slack`                   | `slack` 유형 알림 구성                                                                     | `{}`          |
| `alerting.slack.webhook-url`       | Slack 웹훅 URL                                                                             | 필수 `""`     |
| `alerting.slack.default-alert`     | 기본 알림 구성입니다. <br />[기본 알림 설정](#setting-a-default-alert) 참조                | 해당 없음     |
| `alerting.slack.overrides`         | 기본 구성보다 우선시될 수 있는 오버라이드 목록                                             | `[]`          |
| `alerting.slack.overrides[].group` | 이 구성으로 대체될 엔드포인트 그룹                                                        | `""`          |
| `alerting.slack.overrides[].*`     | `alerting.slack.*` 매개변수 참조                                                          | `{}`          |



```yaml
alerting:
  slack:
    webhook-url: "https://hooks.slack.com/services/**********/**********/**********"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: slack
        description: "healthcheck failed 3 times in a row"
        send-on-resolved: true
      - type: slack
        failure-threshold: 5
        description: "healthcheck failed 5 times in a row"
        send-on-resolved: true
```
Here's an example of what the notifications look like:

![Slack notifications](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/slack-alerts.png)


#### Teams 알림 구성 *(사용 중단)*

> [!CAUTION]
> **사용 중단:** Microsoft Teams 내의 Office 365 커넥터가 폐지될 예정입니다 ([출처: Microsoft DevBlog](https://devblogs.microsoft.com/microsoft365dev/retirement-of-office-365-connectors-within-microsoft-teams/)).
> 기존 커넥터는 2025년 12월까지 계속 작동합니다. 이 구식 구성을 대신하여 Microsoft Workflows와 함께 새로운 [Teams Workflow Alerts](#configuring-teams-workflow-alerts)를 사용해야 합니다.

| Parameter                          | Description                                                                                | Default             |
|:-----------------------------------|:-------------------------------------------------------------------------------------------|:--------------------|
| `alerting.teams`                   | `teams` 유형 알림 구성                                                                     | `{}`                |
| `alerting.teams.webhook-url`       | Teams 웹후크 URL                                                                           | 필수 `""`           |
| `alerting.teams.default-alert`     | 기본 알림 구성입니다. <br />[기본 알림 설정](#setting-a-default-alert) 참조                 | 해당 없음            |
| `alerting.teams.title`             | 알림 제목                                                                                  | `"&#x1F6A8; Gatus"` |
| `alerting.teams.client.insecure`   | TLS 검증 건너뛰기 여부                                                                     | `false`             |
| `alerting.teams.overrides`         | 기본 구성보다 우선시될 수 있는 재정의 목록                                                | `[]`                |
| `alerting.teams.overrides[].group` | 이 구성이 재정의될 엔드포인트 그룹                                                        | `""`                |
| `alerting.teams.overrides[].*`     | `alerting.teams.*` 매개변수 참조                                                          | `{}`                |


```yaml
alerting:
  teams:
    webhook-url: "https://********.webhook.office.com/webhookb2/************"
    client:
      insecure: false
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "core"
        webhook-url: "https://********.webhook.office.com/webhookb3/************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: teams
        description: "healthcheck failed"
        send-on-resolved: true

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: teams
        description: "healthcheck failed"
        send-on-resolved: true
```


다음은 알림이 어떻게 표시되는지에 대한 예입니다:

![Teams 알림](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/teams-alerts.png)

#### Teams Workflow 알림 구성하기

> [!NOTE]
> 이 알림은 Microsoft Teams용 워크플로우와 호환됩니다. 워크플로우를 설정하고 웹후크 URL을 얻으려면 [Microsoft 문서](https://support.microsoft.com/en-us/office/create-incoming-webhooks-with-workflows-for-microsoft-teams-8ae491c7-0394-4861-ba59-055e33f75498)를 참고하세요.

| 매개변수                                      | 설명                                                                                     | 기본값             |
|:---------------------------------------------|:-----------------------------------------------------------------------------------------|:-------------------|
| `alerting.teams-workflows`                   | `teams` 유형 알림 구성을 위한 설정                                                       | `{}`               |
| `alerting.teams-workflows.webhook-url`       | Teams 웹후크 URL                                                                          | 필수 `""`          |
| `alerting.teams-workflows.title`             | 알림 제목                                                                                | `"&#x26D1; Gatus"` |
| `alerting.teams-workflows.default-alert`     | 기본 알림 구성입니다. <br />[기본 알림 설정](#setting-a-default-alert)을 참조하세요       | 해당 없음           |
| `alerting.teams-workflows.overrides`         | 기본 구성보다 우선시될 수 있는 재정의 목록                                               | `[]`               |
| `alerting.teams-workflows.overrides[].group` | 이 구성으로 재정의될 엔드포인트 그룹                                                     | `""`               |
| `alerting.teams-workflows.overrides[].*`     | `alerting.teams-workflows.*` 매개변수 참조                                              | `{}`               |


```yaml
alerting:
  teams-workflows:
    webhook-url: "https://********.webhook.office.com/webhookb2/************"
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "core"
        webhook-url: "https://********.webhook.office.com/webhookb3/************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: teams-workflows
        description: "healthcheck failed"
        send-on-resolved: true

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: teams-workflows
        description: "healthcheck failed"
        send-on-resolved: true
```


알림이 어떻게 표시되는지에 대한 예시는 다음과 같습니다:

![Teams Workflow 알림](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/teams-workflows-alerts.png)


#### 텔레그램 알림 구성
| 매개변수                             | 설명                                                                                       | 기본값                     |
|:--------------------------------------|:-------------------------------------------------------------------------------------------|:---------------------------|
| `alerting.telegram`                   | `telegram` 유형 알림에 대한 구성                                                           | `{}`                       |
| `alerting.telegram.token`             | 텔레그램 봇 토큰                                                                           | 필수 `""`                  |
| `alerting.telegram.id`                | 텔레그램 사용자 ID                                                                         | 필수 `""`                  |
| `alerting.telegram.topic-id`          | 그룹 내 텔레그램 토픽 ID는 텔레그램 API에서 `message_thread_id`에 해당                      | `""`                       |    
| `alerting.telegram.api-url`           | 텔레그램 API URL                                                                          | `https://api.telegram.org` |
| `alerting.telegram.client`            | 클라이언트 구성. <br />자세한 내용은 [클라이언트 구성](#client-configuration) 참조           | `{}`                       |
| `alerting.telegram.default-alert`     | 기본 알림 구성. <br />자세한 내용은 [기본 알림 설정](#setting-a-default-alert) 참조          | 해당 없음                  |
| `alerting.telegram.overrides`         | 기본 구성보다 우선할 수 있는 재정의 목록                                                  | `[]`                       |
| `alerting.telegram.overrides[].group` | 이 구성으로 재정의될 엔드포인트 그룹                                                     | `""`                       |
| `alerting.telegram.overrides[].*`     | `alerting.telegram.*` 매개변수 참조                                                      | `{}`                       |


```yaml
alerting:
  telegram:
    token: "123456:ABC-DEF1234ghIkl-zyx57W2v1u123ew11"
    id: "0123456789"
    topic-id: "7"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
    alerts:
      - type: telegram
        send-on-resolved: true
```


알림이 어떻게 표시되는지에 대한 예시는 다음과 같습니다:

![Telegram notifications](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/telegram-alerts.png)


#### Twilio 알림 구성하기
| 매개변수                        | 설명                                                                                      | 기본값        |
|:--------------------------------|:-------------------------------------------------------------------------------------------|:--------------|
| `alerting.twilio`               | `twilio` 유형 알림 설정                                                                    | `{}`          |
| `alerting.twilio.sid`           | Twilio 계정 SID                                                                            | 필수 `""`     |
| `alerting.twilio.token`         | Twilio 인증 토큰                                                                           | 필수 `""`     |
| `alerting.twilio.from`          | Twilio 알림을 보낼 번호                                                                    | 필수 `""`     |
| `alerting.twilio.to`            | Twilio 알림을 받을 번호                                                                    | 필수 `""`     |
| `alerting.twilio.default-alert` | 기본 알림 구성. <br />자세한 내용은 [기본 알림 설정](#setting-a-default-alert) 참고          | 해당 없음      |


```yaml
alerting:
  twilio:
    sid: "..."
    token: "..."
    from: "+1-234-567-8901"
    to: "+1-234-567-8901"

endpoints:
  - name: website
    interval: 30s
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: twilio
        failure-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Zulip 알림 구성하기
| 매개변수                          | 설명                                                                               | 기본값        |
|:-----------------------------------|:------------------------------------------------------------------------------------|:--------------|
| `alerting.zulip`                   | `discord` 유형 알림에 대한 구성                                                    | `{}`          |
| `alerting.zulip.bot-email`         | 봇 이메일                                                                          | 필수 `""`     |
| `alerting.zulip.bot-api-key`       | 봇 API 키                                                                          | 필수 `""`     |
| `alerting.zulip.domain`            | 전체 조직 도메인 (예: yourZulipDomain.zulipchat.com)                              | 필수 `""`     |
| `alerting.zulip.channel-id`        | Gatus가 알림을 보낼 채널 ID                                                       | 필수 `""`     |
| `alerting.zulip.overrides`         | 기본 구성보다 우선시될 수 있는 재정의 목록                                        | `[]`          |
| `alerting.zulip.overrides[].group` | 이 구성이 재정의될 엔드포인트 그룹                                               | `""`          |
| `alerting.zulip.overrides[].*`     | `alerting.zulip.*` 매개변수 참조                                                  | `{}`          |



```yaml
alerting:
  zulip:
    bot-email: gatus-bot@some.zulip.org
    bot-api-key: "********************************"
    domain: some.zulip.org
    channel-id: 123456

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: zulip
        description: "healthcheck failed"
        send-on-resolved: true
```
#### 사용자 정의 알림 구성
| 매개변수                          | 설명                                                                                      | 기본값        |
|:---------------------------------|:------------------------------------------------------------------------------------------|:-------------|
| `alerting.custom`                | 실패 또는 알림 시 사용자 정의 작업 구성                                                    | `{}`         |
| `alerting.custom.url`            | 사용자 정의 알림 요청 URL                                                                  | 필수 `""`    |
| `alerting.custom.method`         | 요청 메서드                                                                               | `GET`        |
| `alerting.custom.body`           | 사용자 정의 알림 요청 본문                                                                | `""`         |
| `alerting.custom.headers`        | 사용자 정의 알림 요청 헤더                                                                | `{}`         |
| `alerting.custom.client`         | 클라이언트 구성. <br />[클라이언트 구성](#client-configuration) 참조                       | `{}`         |
| `alerting.custom.default-alert`  | 기본 알림 구성. <br />[기본 알림 설정](#setting-a-default-alert) 참조                      | N/A          |

알림이라고 불리지만, 이 기능을 사용하여 어떤 것이든 호출할 수 있습니다.

예를 들어, 새 배포를 추적하는 애플리케이션을 자동화하고,
Gatus를 활용하여 엔드포인트가 실패하기 시작할 때 해당 애플리케이션 엔드포인트를 호출하도록 할 수 있습니다.
그 후 애플리케이션은 실패하기 시작한 엔드포인트가 최근에 배포된 애플리케이션의 일부인지 확인하고,
그렇다면 자동으로 롤백할 수 있습니다.

또한, 본문(`alerting.custom.body`) 및 URL(`alerting.custom.url`)에서 다음 플레이스홀더를 사용할 수 있습니다:
- `[ALERT_DESCRIPTION]` (`endpoints[].alerts[].description`에서 해결)
- `[ENDPOINT_NAME]` (`endpoints[].name`에서 해결)
- `[ENDPOINT_GROUP]` (`endpoints[].group`에서 해결)
- `[ENDPOINT_URL]` (`endpoints[].url`에서 해결)
- `[RESULT_ERRORS]` (주어진 헬스 체크의 상태 평가에서 해결)

`send-on-resolved`가 `true`로 설정된 `custom` 공급자를 사용하는 알림이 있는 경우,
알림 구분을 위해 `[ALERT_TRIGGERED_OR_RESOLVED]` 플레이스홀더를 사용할 수 있습니다.
앞서 언급한 플레이스홀더는 각각 `TRIGGERED` 또는 `RESOLVED`로 대체되며,
(이 섹션 끝부분에서 세부사항을 수정할 수 있습니다).

모든 목적상, Slack 웹훅을 사용하여 사용자 정의 알림을 구성하지만, 원하는 것은 무엇이든 호출할 수 있습니다.


```yaml
alerting:
  custom:
    url: "https://hooks.slack.com/services/**********/**********/**********"
    method: "POST"
    body: |
      {
        "text": "[ALERT_TRIGGERED_OR_RESOLVED]: [ENDPOINT_GROUP] - [ENDPOINT_NAME] - [ALERT_DESCRIPTION] - [RESULT_ERRORS]"
      }
endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: custom
        failure-threshold: 10
        success-threshold: 3
        send-on-resolved: true
        description: "health check failed"
```


`[ALERT_TRIGGERED_OR_RESOLVED]` 자리 표시자의 해결된 값을 다음과 같이 사용자 지정할 수 있습니다:

```yaml
alerting:
  custom:
    placeholders:
      ALERT_TRIGGERED_OR_RESOLVED:
        TRIGGERED: "partial_outage"
        RESOLVED: "operational"
```
As a result, the `[ALERT_TRIGGERED_OR_RESOLVED]` in the body of first example of this section would be replaced by
`partial_outage` when an alert is triggered and `operational` when an alert is resolved.


#### 기본 알림 설정
| Parameter                                    | Description                                                                   | Default |
|:---------------------------------------------|:------------------------------------------------------------------------------|:--------|
| `alerting.*.default-alert.enabled`           | 알림 활성화 여부                                                             | N/A     |
| `alerting.*.default-alert.failure-threshold` | 알림을 트리거하기 전에 연속 실패 횟수                                        | N/A     |
| `alerting.*.default-alert.success-threshold` | 진행 중인 사고가 해결된 것으로 표시되기 전에 연속 성공 횟수                   | N/A     |
| `alerting.*.default-alert.send-on-resolved`  | 트리거된 알림이 해결된 것으로 표시되면 알림을 전송할지 여부                   | N/A     |
| `alerting.*.default-alert.description`       | 알림 설명. 전송되는 알림에 포함됨                                            | N/A     |

> ⚠ 공급자의 기본 알림을 설정하더라도 엔드포인트 구성에서 알림의 `type`을 반드시 지정해야 합니다.

엔드포인트 정의에서 알림 구성을 직접 지정할 수 있지만, 이는 번거롭고 매우
긴 구성 파일을 초래할 수 있습니다.

이러한 문제를 피하기 위해 각 공급자 구성에 있는 `default-alert` 매개변수를 사용할 수 있습니다:
```yaml
alerting:
  slack:
    webhook-url: "https://hooks.slack.com/services/**********/**********/**********"
    default-alert:
      description: "health check failed"
      send-on-resolved: true
      failure-threshold: 5
      success-threshold: 5
```
결과적으로, 귀하의 Gatus 구성은 훨씬 깔끔해 보입니다:

```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack

  - name: other-example
    url: "https://example.com"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
```


이것과 같은 작업을 수행할 수도 있습니다:

```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
        failure-threshold: 5
      - type: slack
        failure-threshold: 10
      - type: slack
        failure-threshold: 15
```
물론, 알림 유형을 혼합할 수도 있습니다:

```yaml
alerting:
  slack:
    webhook-url: "https://hooks.slack.com/services/**********/**********/**********"
    default-alert:
      failure-threshold: 3
  pagerduty:
    integration-key: "********************************"
    default-alert:
      failure-threshold: 5

endpoints:
  - name: endpoint-1
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
      - type: pagerduty

  - name: endpoint-2
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
      - type: pagerduty
```
### 유지보수
유지보수 시간이 있다면, 알림에 방해받고 싶지 않을 수 있습니다.
이를 위해서는 유지보수 구성을 사용해야 합니다:

| 매개변수                 | 설명                                                                                                                                                                                      | 기본값         |
|:-----------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------|
| `maintenance.enabled`  | 유지보수 기간이 활성화되어 있는지 여부                                                                                                                                                      | `true`        |
| `maintenance.start`    | 유지보수 창이 시작되는 시간 `hh:mm` 형식 (예: `23:00`)                                                                                                                                       | 필수 `""`     |
| `maintenance.duration` | 유지보수 창의 지속 시간 (예: `1h`, `30m`)                                                                                                                                                   | 필수 `""`     |
| `maintenance.timezone` | 유지보수 창의 시간대 형식 (예: `Europe/Amsterdam`).<br />자세한 내용은 [tz 데이터베이스 시간대 목록](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) 참조                      | `UTC`         |
| `maintenance.every`    | 유지보수 기간이 적용되는 요일 (예: `[Monday, Thursday]`).<br />비워두면 매일 유지보수 창이 적용됩니다                                                                                         | `[]`          |

예시는 다음과 같습니다:


```yaml
maintenance:
  start: 23:00
  duration: 1h
  timezone: "Europe/Amsterdam"
  every: [Monday, Thursday]
```
각 요일을 별도의 줄에 지정할 수도 있다는 점에 유의하세요:
```yaml
maintenance:
  start: 23:00
  duration: 1h
  timezone: "Europe/Amsterdam"
  every:
    - Monday
    - Thursday
```
엔드포인트별로 유지 관리 창을 지정할 수도 있습니다:
```yaml
endpoints:
  - name: endpoint-1
    url: "https://example.org"
    maintenance-windows:
      - start: "07:30"
        duration: 40m
        timezone: "Europe/Berlin"
      - start: "14:30"
        duration: 1h
        timezone: "Europe/Berlin"
```
### 보안
| 매개변수           | 설명                        | 기본값   |
|:------------------|:---------------------------|:--------|
| `security`        | 보안 구성                   | `{}`    |
| `security.basic`  | HTTP 기본 인증 구성          | `{}`    |
| `security.oidc`   | OpenID Connect 구성         | `{}`    |


#### 기본 인증
| 매개변수                               | 설명                                                                               | 기본값         |
|:-------------------------------------|:----------------------------------------------------------------------------------|:--------------|
| `security.basic`                     | HTTP 기본 인증 구성                                                                | `{}`          |
| `security.basic.username`            | 기본 인증용 사용자 이름                                                             | 필수 `""`     |
| `security.basic.password-bcrypt-base64` | 기본 인증용 비밀번호를 Bcrypt로 해시하고 base64로 인코딩한 값                         | 필수 `""`     |

아래 예시는 사용자 이름 `john.doe`와 비밀번호 `hunter2`로 인증해야 함을 요구합니다:


```yaml
security:
  basic:
    username: "john.doe"
    password-bcrypt-base64: "JDJhJDEwJHRiMnRFakxWazZLdXBzRERQazB1TE8vckRLY05Yb1hSdnoxWU0yQ1FaYXZRSW1McmladDYu"
```
> ⚠ bcrypt 해시의 비용(cost)을 신중하게 선택해야 합니다. 비용이 높을수록 해시 계산에 시간이 더 오래 걸리며,
> 기본 인증은 모든 요청마다 비밀번호를 해시와 대조하여 확인합니다. 2023-01-06 기준으로 비용 9를 권장합니다.


#### OIDC
| Parameter                        | 설명                                                           | 기본값        |
|:---------------------------------|:---------------------------------------------------------------|:--------------|
| `security.oidc`                  | OpenID Connect 구성                                            | `{}`          |
| `security.oidc.issuer-url`       | 발행자 URL                                                    | 필수 `""`     |
| `security.oidc.redirect-url`     | 리디렉션 URL. 반드시 `/authorization-code/callback`로 끝나야 합니다 | 필수 `""`     |
| `security.oidc.client-id`        | 클라이언트 아이디                                             | 필수 `""`     |
| `security.oidc.client-secret`    | 클라이언트 시크릿                                            | 필수 `""`     |
| `security.oidc.scopes`           | 요청할 범위. 필요한 범위는 `openid` 하나뿐입니다.              | 필수 `[]`     |
| `security.oidc.allowed-subjects` | 허용할 주체 목록. 비어 있으면 모든 주체가 허용됩니다.           | `[]`          |


```yaml
security:
  oidc:
    issuer-url: "https://example.okta.com"
    redirect-url: "https://status.example.com/authorization-code/callback"
    client-id: "123456789"
    client-secret: "abcdefghijk"
    scopes: ["openid"]
    # You may optionally specify a list of allowed subjects. If this is not specified, all subjects will be allowed.
    #allowed-subjects: ["johndoe@example.com"]
```
혼란스러우신가요? [Auth0를 사용한 OIDC로 Gatus 보안 설정](https://twin.sh/articles/56/securing-gatus-with-oidc-using-auth0)을 읽어보세요.


### TLS 암호화
Gatus는 기본 TLS 암호화를 지원합니다. 이를 활성화하려면 PEM 형식의 인증서 파일을 제공해야 합니다.

아래 예시는 Gatus가 포트 4443에서 HTTPS 요청에 응답하도록 설정하는 구성 예시를 보여줍니다:

```yaml
web:
  port: 4443
  tls:
    certificate-file: "certificate.crt"
    private-key-file: "private.key"
```
### 메트릭  
메트릭을 활성화하려면 `metrics`를 `true`로 설정해야 합니다. 이렇게 하면 애플리케이션이 실행되도록 구성된 동일한 포트(`web.port`)의 `/metrics` 엔드포인트에서 Prometheus 친화적인 메트릭이 노출됩니다.  

| 메트릭 이름                                  | 유형    | 설명                                                                | 라벨                            | 관련 엔드포인트 유형      |  
|:---------------------------------------------|:--------|:-------------------------------------------------------------------|:--------------------------------|:------------------------|  
| gatus_results_total                          | 카운터 | 성공 상태별 엔드포인트 결과 수                                      | key, group, name, type, success | 전체                     |  
| gatus_results_code_total                     | 카운터 | 코드별 총 결과 수                                                  | key, group, name, type, code    | DNS, HTTP               |  
| gatus_results_connected_total                | 카운터 | 연결이 성공적으로 설정된 결과의 총 수                              | key, group, name, type          | 전체                     |  
| gatus_results_duration_seconds               | 게이지 | 요청의 지속 시간(초)                                              | key, group, name, type          | 전체                     |  
| gatus_results_certificate_expiration_seconds | 게이지 | 인증서 만료까지 남은 초 수                                         | key, group, name, type          | HTTP, STARTTLS          |  
| gatus_results_endpoint_success               | 게이지 | 엔드포인트 성공 여부 표시 (0 실패, 1 성공)                        | key, group, name, type          | 전체                     |  

자세한 문서와 예제는 [examples/docker-compose-grafana-prometheus](.examples/docker-compose-grafana-prometheus)에서 확인하세요.  


### 연결성  
| 매개변수                        | 설명                                     | 기본값        |  
|:--------------------------------|:----------------------------------------|:-------------|  
| `connectivity`                  | 연결성 구성                             | `{}`         |  
| `connectivity.checker`          | 연결성 검사기 구성                      | 필수 `{}`    |  
| `connectivity.checker.target`   | 연결성 검증에 사용할 호스트             | 필수 `""`    |  
| `connectivity.checker.interval` | 연결성 검증 간격                        | `1m`         |  

Gatus는 다른 서비스를 모니터링하는 데 사용되지만, Gatus 자체가 인터넷 연결을 잃을 수도 있습니다.  
Gatus 자체가 비정상일 때 엔드포인트를 비정상으로 보고하는 것을 방지하기 위해,  
Gatus가 주기적으로 인터넷 연결을 확인하도록 구성할 수 있습니다.  

연결성 검사기가 연결이 끊긴 것으로 판단하는 동안 모든 엔드포인트 실행이 건너뛰어집니다.




```yaml
connectivity:
  checker:
    target: 1.1.1.1:53
    interval: 60s
```
### 원격 인스턴스 (실험적)
이 기능은 원격 Gatus 인스턴스에서 엔드포인트 상태를 가져올 수 있도록 합니다.

이 기능의 주요 사용 사례는 다음과 같습니다:
- 여러 대의 머신에서 여러 Gatus 인스턴스가 실행 중이며, 하나의 대시보드에서 상태를 시각적으로 노출하려는 경우
- 하나 이상의 Gatus 인스턴스가 공개적으로 접근 불가능한 경우(예: 방화벽 뒤에 있음) 상태를 가져오려는 경우

이 기능은 실험적입니다. 언제든지 제거되거나 호환성 문제를 일으키는 방식으로 업데이트될 수 있습니다. 또한,
이 기능에는 알려진 문제가 있습니다. 피드백을 원하시면 [#64](https://github.com/TwiN/gatus/issues/64)에 댓글을 작성해 주세요.
사용은 본인의 책임하에 하십시오.

| 매개변수                          | 설명                                       | 기본값        |
|:-----------------------------------|:---------------------------------------------|:--------------|
| `remote`                           | 원격 구성                                  | `{}`          |
| `remote.instances`                 | 원격 인스턴스 목록                         | 필수 `[]`     |
| `remote.instances.endpoint-prefix` | 모든 엔드포인트 이름에 접두어로 붙일 문자열 | `""`          |
| `remote.instances.url`             | 엔드포인트 상태를 가져올 URL               | 필수 `""`     |



```yaml
remote:
  instances:
    - endpoint-prefix: "status.example.org-"
      url: "https://status.example.org/api/v1/endpoints/statuses"
```



## 배포
많은 예제들은 [.examples](.examples) 폴더에서 찾을 수 있지만, 이 섹션은 Gatus를 배포하는 가장 인기 있는 방법에 중점을 둡니다.


### 도커
Docker를 사용하여 로컬에서 Gatus를 실행하려면:

```console
docker run -p 8080:8080 --name gatus twinproduction/gatus
```


[.examples](.examples) 폴더에 제공된 예제 중 하나를 사용하는 것 외에도,  
구성 파일을 생성하여 로컬에서 직접 시도해볼 수 있습니다. 이 예제에서는 `config.yaml`이라고 하겠습니다.  
그리고 다음 명령어를 실행하세요:  


```console
docker run -p 8080:8080 --mount type=bind,source="$(pwd)"/config.yaml,target=/config/config.yaml --name gatus twinproduction/gatus
```


Windows를 사용 중이라면 `"$(pwd)"`를 현재 디렉터리의 절대 경로로 바꾸십시오. 예를 들어:

```console
docker run -p 8080:8080 --mount type=bind,source=C:/Users/Chris/Desktop/config.yaml,target=/config/config.yaml --name gatus twinproduction/gatus
```


이미지를 로컬에서 빌드하려면:

```console
docker build . -t twinproduction/gatus
```



### Helm 차트
[Helm](https://helm.sh)을 사용하려면 설치되어 있어야 합니다.
시작하려면 Helm의 [문서](https://helm.sh/docs/)를 참조하세요.

Helm이 제대로 설정되면, 다음과 같이 저장소를 추가하십시오:


```console
helm repo add twin https://twin.github.io/helm-charts
helm repo update
helm install gatus twin/gatus
```
더 많은 세부 정보를 원하시면 [차트 구성](https://github.com/TwiN/helm-charts/blob/master/charts/gatus/README.md)을 확인해 주세요.


### Terraform
Gatus는 다음 모듈을 사용하여 Terraform에 배포할 수 있습니다: [terraform-kubernetes-gatus](https://github.com/TwiN/terraform-kubernetes-gatus).


## 테스트 실행하기

```console
go test -v ./...
```



## 운영 환경에서 사용하기
[배포](#deployment) 섹션을 참조하세요.


## 자주 묻는 질문
### GraphQL 요청 보내기
`endpoints[].graphql`을 true로 설정하면, 본문이 자동으로 표준 GraphQL `query` 파라미터로 감싸집니다.

예를 들어, 다음 구성은:

```yaml
endpoints:
  - name: filter-users-by-gender
    url: http://localhost:8080/playground
    method: POST
    graphql: true
    body: |
      {
        users(gender: "female") {
          id
          name
          gender
          avatar
        }
      }
    conditions:
      - "[STATUS] == 200"
      - "[BODY].data.users[0].gender == female"
```
`http://localhost:8080/playground`에 다음 본문과 함께 `POST` 요청을 보냅니다:

```json
{"query":"      {\n        users(gender: \"female\") {\n          id\n          name\n          gender\n          avatar\n        }\n      }"}
```
### 권장 간격
> 📝 `disable-monitoring-lock`가 `true`로 설정된 경우에는 적용되지 않습니다. 모니터링 락이 Gatus가 한 번에 하나의 엔드포인트만 평가하도록 지시하기 때문입니다.

Gatus가 신뢰할 수 있고 정확한 결과(예: 응답 시간)를 제공하도록 보장하기 위해, Gatus는 한 번에 하나의 엔드포인트만 평가합니다.
다시 말해, 같은 간격을 가진 여러 엔드포인트가 있더라도 동시에 실행되지 않습니다.

이를 직접 테스트하려면 매우 짧고 비현실적인 간격(예: 1ms)으로 여러 엔드포인트를 설정해 Gatus를 실행해 보세요.
응답 시간이 변동하지 않는 것을 알 수 있습니다 - 이는 엔드포인트가 서로 다른 고루틴에서 평가되지만,
여러 엔드포인트가 동시에 실행되지 않도록 하는 전역 락이 있기 때문입니다.

불행히도 단점이 있습니다. 많은 엔드포인트가 있고, 그 중 일부가 매우 느리거나 타임아웃이 발생하기 쉬운 경우
(기본 타임아웃은 10초), 요청이 진행되는 동안 다른 엔드포인트를 평가할 수 없습니다.

간격은 요청 자체의 지속 시간을 포함하지 않으므로, 엔드포인트의 간격이 30초이고
요청 완료에 2초가 걸리면 두 평가 간의 타임스탬프는 30초가 아닌 32초가 됩니다.

이는 Gatus가 다른 모든 엔드포인트에 대한 헬스 체크를 수행하지 못하게 하지는 않지만,
설정된 간격을 준수하지 못할 수 있습니다. 예를 들면:
- 엔드포인트 A의 간격은 5초이고, 완료까지 10초가 소요되어 타임아웃 발생
- 엔드포인트 B의 간격은 5초이고, 완료까지 1ms 소요
- 엔드포인트 B는 엔드포인트 A의 헬스 평가가 간격보다 오래 걸리므로 5초마다 실행할 수 없음

요약하면, Gatus는 어떤 간격도 처리할 수 있지만 느린 요청은 더 긴 간격으로 설정하는 것이 좋습니다.

개인적으로 복잡한 헬스 체크 간격은 `5m`(5분)로,
알림용(예: PagerDuty/Twilio) 간단한 헬스 체크는 `30s`로 설정하는 것을 권장합니다.


### 기본 타임아웃
| 엔드포인트 유형 | 타임아웃 |
|:--------------|:--------|
| HTTP          | 10초     |
| TCP           | 10초     |
| ICMP          | 10초     |

타임아웃을 수정하려면 [클라이언트 구성](#client-configuration)을 참조하세요.


### TCP 엔드포인트 모니터링
`endpoints[].url`에 `tcp://` 접두사를 붙이면 매우 기본적인 수준에서 TCP 엔드포인트를 모니터링할 수 있습니다:




```yaml
endpoints:
  - name: redis
    url: "tcp://127.0.0.1:6379"
    interval: 30s
    conditions:
      - "[CONNECTED] == true"
```

`endpoints[].body`가 설정된 경우 전송되며 응답의 처음 1024 바이트가 `[BODY]`에 포함됩니다.

플레이스홀더 `[STATUS]`와 `endpoints[].headers`,  
`endpoints[].method` 및 `endpoints[].graphql` 필드는 TCP 엔드포인트에 대해 지원되지 않습니다.

이 기능은 데이터베이스(Postgres, MySQL 등)와 캐시(Redis, Memcached 등)와 같은 애플리케이션에 적합합니다.

> 📝 `[CONNECTED] == true`는 엔드포인트 자체가 정상임을 보장하지 않습니다 -  
> 이는 주어진 주소에 지정된 포트를 수신하는 무언가가 있고, 해당 주소에 대한 연결이 성공적으로  
> 이루어졌음을 보장할 뿐입니다.


### UDP 엔드포인트 모니터링
`endpoints[].url`에 `udp://` 접두사를 붙이면 UDP 엔드포인트를 매우 기본적인 수준에서 모니터링할 수 있습니다:

```yaml
endpoints:
  - name: example
    url: "udp://example.org:80"
    conditions:
      - "[CONNECTED] == true"
```


`endpoints[].body`가 설정되어 있으면 전송되며 응답의 처음 1024바이트가 `[BODY]`에 포함됩니다.

자리 표시자 `[STATUS]`와 필드 `endpoints[].headers`,
`endpoints[].method` 및 `endpoints[].graphql`은 UDP 엔드포인트에서 지원되지 않습니다.

이 기능은 UDP 기반 애플리케이션에 적용됩니다.


### SCTP 엔드포인트 모니터링
`endpoints[].url` 앞에 `sctp://`를 붙이면 스트림 제어 전송 프로토콜(SCTP) 엔드포인트를 매우 기본적인 수준에서 모니터링할 수 있습니다:


```yaml
endpoints:
  - name: example
    url: "sctp://127.0.0.1:38412"
    conditions:
      - "[CONNECTED] == true"
```


자리 표시자 `[STATUS]` 및 `[BODY]`와 `endpoints[].body`, `endpoints[].headers`,  
`endpoints[].method` 및 `endpoints[].graphql` 필드는 SCTP 엔드포인트에서 지원되지 않습니다.  

이것은 SCTP 기반 애플리케이션에 적용됩니다.  


### WebSocket 엔드포인트 모니터링  
`endpoints[].url`에 `ws://` 또는 `wss://` 접두어를 붙이면, 매우 기본적인 수준에서 WebSocket 엔드포인트를 모니터링할 수 있습니다:

```yaml
endpoints:
  - name: example
    url: "wss://example.com/"
    body: "status"
    conditions:
      - "[CONNECTED] == true"
      - "[BODY].result >= 0"
```
[translate-content]
`[BODY]` 자리표시는 쿼리의 출력을 포함하며, `[CONNECTED]` 는 연결이 성공적으로 설정되었는지 여부를 표시합니다. Go 템플릿
구문을 사용할 수 있습니다. 길이를 지정한 LocalAddr 및 RandomString 함수를 사용할 수 있습니다.


### ICMP를 사용한 엔드포인트 모니터링
`endpoints[].url` 앞에 `icmp://`를 붙이면 ICMP, 즉 일반적으로 "핑" 또는 "에코"로 알려진 매우 기본적인 수준에서 엔드포인트를 모니터링할 수 있습니다:



```yaml
endpoints:
  - name: ping-example
    url: "icmp://example.com"
    conditions:
      - "[CONNECTED] == true"
```


ICMP 유형 엔드포인트에는 `[CONNECTED]`, `[IP]`, `[RESPONSE_TIME]` 자리 표시자만 지원됩니다.  
`icmp://`로 시작하는 도메인이나 `icmp://`로 시작하는 IP 주소를 지정할 수 있습니다.  

Linux에서 Gatus를 실행하는 경우 문제가 발생하면 https://github.com/prometheus-community/pro-bing#linux 의 Linux 섹션을 참조하세요.  


### DNS 쿼리를 사용한 엔드포인트 모니터링  
엔드포인트에 `dns` 구성을 정의하면 해당 엔드포인트가 자동으로 DNS 유형 엔드포인트로 표시됩니다:


```yaml
endpoints:
  - name: example-dns-query
    url: "8.8.8.8" # Address of the DNS server to use
    dns:
      query-name: "example.com"
      query-type: "A"
    conditions:
      - "[BODY] == 93.184.215.14"
      - "[DNS_RCODE] == NOERROR"
```


DNS 유형의 엔드포인트 조건에서 사용할 수 있는 두 가지 자리 표시자가 있습니다:
- 자리 표시자 `[BODY]`는 쿼리의 출력 결과로 해석됩니다. 예를 들어, `A` 유형의 쿼리는 IPv4를 반환합니다.
- 자리 표시자 `[DNS_RCODE]`는 쿼리에서 반환된 응답 코드에 연결된 이름으로 해석됩니다. 예: `NOERROR`, `FORMERR`, `SERVFAIL`, `NXDOMAIN` 등.


### SSH를 사용한 엔드포인트 모니터링
`endpoints[].url` 앞에 `ssh://`를 붙여 SSH를 통해 엔드포인트를 모니터링할 수 있습니다:


```yaml
endpoints:
  - name: ssh-example
    url: "ssh://example.com:22" # port is optional. Default is 22.
    ssh:
      username: "username"
      password: "password"
    body: |
      {
        "command": "uptime"
      }
    interval: 1m
    conditions:
      - "[CONNECTED] == true"
      - "[STATUS] == 0"
```


사용자 이름과 비밀번호 필드를 지정하지 않아 인증 없이도 엔드포인트를 모니터링할 수 있습니다.



```yaml
endpoints:
  - name: ssh-example
    url: "ssh://example.com:22" # port is optional. Default is 22.
    ssh:
      username: ""
      password: ""

    interval: 1m
    conditions:
      - "[CONNECTED] == true"
      - "[STATUS] == 0"
```
다음 자리 표시자는 SSH 유형의 엔드포인트에 대해 지원됩니다:
- `[CONNECTED]`는 SSH 연결이 성공하면 `true`, 그렇지 않으면 `false`로 해석됩니다
- `[STATUS]`는 원격 서버에서 실행된 명령의 종료 코드를 해석합니다 (예: 성공 시 `0`)


### STARTTLS를 사용한 엔드포인트 모니터링
문제가 없는지 확인하려는 이메일 서버가 있다면, STARTTLS를 통해 모니터링하는 것이
좋은 초기 지표가 될 것입니다:

```yaml
endpoints:
  - name: starttls-smtp-example
    url: "starttls://smtp.gmail.com:587"
    interval: 30m
    client:
      timeout: 5s
    conditions:
      - "[CONNECTED] == true"
      - "[CERTIFICATE_EXPIRATION] > 48h"
```
### TLS를 사용한 엔드포인트 모니터링
LDAP over TLS와 같은 SSL/TLS 암호화를 사용하는 엔드포인트 모니터링은 인증서 만료를 감지하는 데 도움이 됩니다:


```yaml
endpoints:
  - name: tls-ldaps-example
    url: "tls://ldap.example.com:636"
    interval: 30m
    client:
      timeout: 5s
    conditions:
      - "[CONNECTED] == true"
      - "[CERTIFICATE_EXPIRATION] > 48h"
```
If `endpoints[].body` 가 설정되면 전송되며 응답의 처음 1024 바이트는 `[BODY]` 에 포함됩니다.

플레이스홀더 `[STATUS]` 와 필드 `endpoints[].headers`,
`endpoints[].method` 및 `endpoints[].graphql` 은 TLS 엔드포인트에서 지원되지 않습니다.


### 도메인 만료 모니터링
DNS를 제외한 모든 엔드포인트 유형에서 `[DOMAIN_EXPIRATION]`
플레이스홀더를 사용하여 도메인 만료를 모니터링할 수 있습니다:

```yaml
endpoints:
  - name: check-domain-and-certificate-expiration
    url: "https://example.org"
    interval: 1h
    conditions:
      - "[DOMAIN_EXPIRATION] > 720h"
      - "[CERTIFICATE_EXPIRATION] > 240h"
```
> ⚠ `[DOMAIN_EXPIRATION]` 플레이스홀더를 사용하려면 Gatus가 공식 IANA WHOIS 서비스에 [라이브러리를 통해](https://github.com/TwiN/whois) 요청을 보내야 하며,  
> 경우에 따라 TLD별 WHOIS 서버(예: `whois.nic.sh`)에 두 번째 요청을 보내야 합니다.  
> 너무 많은 요청을 보내 WHOIS 서비스가 IP 주소를 제한하지 않도록, Gatus는  
> 간격이 `5m` 미만인 엔드포인트에서 `[DOMAIN_EXPIRATION]` 플레이스홀더 사용을 제한합니다.  


### disable-monitoring-lock
`disable-monitoring-lock`을 `true`로 설정하면 여러 엔드포인트를 동시에 모니터링할 수 있습니다(즉, 병렬 실행).

이 동작은 일반적으로 해롭지 않지만, `[RESPONSE_TIME]` 플레이스홀더를 사용하는 조건은  
여러 엔드포인트가 동시에 평가되면서 영향을 받을 수 있으므로, 이 매개변수의 기본값은 `false`입니다.

모니터링 잠금을 비활성화하려는 주요 이유는 세 가지입니다:  
- Gatus를 부하 테스트에 사용 중인 경우(각 엔드포인트가 다른 고루틴에서 주기적으로 평가되므로,  
기술적으로 1초 간격으로 100개 엔드포인트를 만들면 Gatus가 초당 100개의 요청을 보냅니다)  
- 모니터링할 엔드포인트가 _매우 많을 때_  
- 매우 짧은 간격(< 5초)으로 여러 엔드포인트를 테스트하려는 경우  


### 실행 중 구성 재로드
편의를 위해 Gatus는 실행 중 구성 파일이 업데이트되면 자동으로 구성을 재로드합니다.

기본적으로 업데이트된 구성이 유효하지 않으면 애플리케이션이 종료되지만,  
`skip-invalid-config-update`를 `true`로 설정하면  
구성 파일이 유효하지 않은 상태로 업데이트되어도 Gatus가 계속 실행되도록 할 수 있습니다.

Gatus가 실행되는 동안 구성 파일을 업데이트할 때마다 로그를 확인하여  
다음 메시지가 나타나지 않는지 확인하는 등 구성 파일의 유효성을 보장하는 것이 최선임을 기억하세요:



```
The configuration file was updated, but it is not valid. The old configuration will continue being used.
```

애플리케이션이 어떤 이유로든 다시 시작될 경우 Gatus가 시작하지 못할 수 있으므로 주의해야 합니다.

이와 같은 상황을 피하기 위해 `skip-invalid-config-update`를 `true`로 설정하지 않는 것을 권장하지만, 선택은 사용자에게 달려 있습니다.

**파일 스토리지를 사용하지 않는 경우**, Gatus가 실행 중일 때 구성 업데이트는 사실상
애플리케이션을 다시 시작하는 것과 동일합니다.

> 📝 구성 파일이 폴더가 아닌 파일에 바인딩된 경우 업데이트가 감지되지 않을 수 있습니다. 자세한 내용은 [#151](https://github.com/TwiN/gatus/issues/151)을 참조하세요.


### 엔드포인트 그룹
엔드포인트 그룹은 대시보드에서 여러 엔드포인트를 함께 그룹화하는 데 사용됩니다.



```yaml
endpoints:
  - name: frontend
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: backend
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: monitoring
    group: internal
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: nas
    group: internal
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: random endpoint that is not part of a group
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
```
위의 구성은 다음과 같은 대시보드를 생성합니다:

![Gatus Endpoint Groups](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/endpoint-groups.png)


### Gatus를 커스텀 경로에 노출하기
현재 Gatus UI는 `status.example.org`와 같은 완전한 도메인 이름(FQDN)을 사용하여 노출할 수 있습니다. 그러나 경로 기반 라우팅은 지원하지 않아 `example.org/status/`와 같은 URL을 통해 노출할 수 없습니다.

자세한 내용은 https://github.com/TwiN/gatus/issues/88 을 참조하세요.


### Gatus를 커스텀 포트에 노출하기
기본적으로 Gatus는 `8080` 포트에서 노출되지만, `web.port` 매개변수를 설정하여 다른 포트를 지정할 수 있습니다:

```yaml
web:
  port: 8081
```


Heroku와 같이 사용자 지정 포트를 설정할 수 없고 대신 환경 변수로 노출하는 PaaS를 사용하는 경우,  
구성 파일에서 해당 환경 변수를 직접 사용할 수 있습니다:  


```yaml
web:
  port: ${PORT}
```
### 시작 지연 구성하기
어떤 이유로든 애플리케이션 시작 시 엔드포인트 모니터링 전에 일정 시간 대기해야 한다면, `GATUS_DELAY_START_SECONDS` 환경 변수를 사용하여 Gatus가 시작 시 대기하도록 설정할 수 있습니다.


### 구성 파일을 간결하게 유지하기
Gatus에만 국한된 것은 아니지만, YAML 앵커를 활용하여 기본 구성을 만들 수 있습니다.
구성 파일이 클 경우, 이를 통해 깔끔하게 유지하는 데 도움이 될 것입니다.

<details>
  <summary>예시</summary>



```yaml
default-endpoint: &defaults
  group: core
  interval: 5m
  client:
    insecure: true
    timeout: 30s
  conditions:
    - "[STATUS] == 200"

endpoints:
  - name: anchor-example-1
    <<: *defaults               # This will merge the configuration under &defaults with this endpoint
    url: "https://example.org"

  - name: anchor-example-2
    <<: *defaults
    group: example              # This will override the group defined in &defaults
    url: "https://example.com"

  - name: anchor-example-3
    <<: *defaults
    url: "https://twin.sh/health"
    conditions:                # This will override the conditions defined in &defaults
      - "[STATUS] == 200"
      - "[BODY].status == UP"
```

</details>


### 프록시 클라이언트 구성
클라이언트 구성에서 `proxy-url` 매개변수를 설정하여 클라이언트가 사용할 프록시를 구성할 수 있습니다.


```yaml
endpoints:
  - name: website
    url: "https://twin.sh/health"
    client:
      proxy-url: http://proxy.example.com:8080
    conditions:
      - "[STATUS] == 200"
```
### 431 요청 헤더 필드가 너무 큽니다 오류 수정 방법
환경이 어디에 배포되어 있고 Gatus 앞에 어떤 미들웨어나 리버스 프록시가 있는지에 따라,
이 문제가 발생할 수 있습니다. 이는 요청 헤더가 너무 커서 발생할 수 있습니다. 예를 들어, 큰 쿠키 등입니다.

기본적으로 `web.read-buffer-size`는 `8192`로 설정되어 있지만, 다음과 같이 이 값을 늘리면 읽기 버퍼 크기가 증가합니다:


```yaml
web:
  read-buffer-size: 32768
```
### 배지
#### 가동 시간
![Uptime 1h](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/1h/badge.svg)
![Uptime 24h](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/24h/badge.svg)
![Uptime 7d](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/7d/badge.svg)
![Uptime 30d](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/30d/badge.svg)

Gatus는 모니터링 중인 엔드포인트 중 하나에 대한 SVG 배지를 자동으로 생성할 수 있습니다.
이를 통해 개별 애플리케이션의 README에 배지를 삽입하거나 원한다면 자체 상태 페이지를 만들 수도 있습니다.

배지를 생성하는 경로는 다음과 같습니다:



```
/api/v1/endpoints/{key}/uptimes/{duration}/badge.svg
```
어디에:
- `{duration}`는 `30d`, `7d`, `24h` 또는 `1h`입니다.
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 패턴을 가지며, 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.

예를 들어, 그룹 `core`의 엔드포인트 `frontend`에서 지난 24시간 동안의 가동 시간을 원한다면,
URL은 다음과 같이 표시됩니다:

```
https://example.com/api/v1/endpoints/core_frontend/uptimes/7d/badge.svg
```
그룹에 속하지 않은 엔드포인트를 표시하려면 그룹 값을 비워 두어야 합니다:
```
https://example.com/api/v1/endpoints/_frontend/uptimes/7d/badge.svg
```
예시:
```
![Uptime 24h](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/24h/badge.svg)
```

각 배지의 시각적 예시를 보고 싶다면, 엔드포인트 세부 페이지로 이동하면 됩니다.


#### 상태
![Health](https://status.twin.sh/api/v1/endpoints/core_blog-external/health/badge.svg)

배지를 생성하는 경로는 다음과 같습니다:

```
/api/v1/endpoints/{key}/health/badge.svg
```

위치:
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 패턴을 가지며, 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.

예를 들어, 그룹 `core`의 엔드포인트 `frontend`의 현재 상태를 원한다면,
URL은 다음과 같이 보일 것입니다:

```
https://example.com/api/v1/endpoints/core_frontend/health/badge.svg
```
#### Health (Shields.io)
![Health](https://img.shields.io/endpoint?url=https%3A%2F%2Fstatus.twin.sh%2Fapi%2Fv1%2Fendpoints%2Fcore_blog-external%2Fhealth%2Fbadge.shields)

배지를 생성하는 경로는 다음과 같습니다:


```
/api/v1/endpoints/{key}/health/badge.shields
```
어디에:
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 형식을 가지며, 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.

예를 들어, 그룹 `core`의 엔드포인트 `frontend`의 현재 상태를 원한다면,
URL은 다음과 같이 보일 것입니다:</
```
https://example.com/api/v1/endpoints/core_frontend/health/badge.shields
```

See more information about the Shields.io badge endpoint [here](https://shields.io/badges/endpoint-badge).


#### Response time
![Response time 1h](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/1h/badge.svg)
![Response time 24h](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/24h/badge.svg)
![Response time 7d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/7d/badge.svg)
![Response time 30d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/30d/badge.svg)

The endpoint to generate a badge is the following:
```
/api/v1/endpoints/{key}/response-times/{duration}/badge.svg
```
Where:
- `{duration}`는 `30d`, `7d`, `24h` 또는 `1h`입니다.
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 패턴이며, 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.

#### 응답 시간 (차트)
![Response time 24h](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/24h/chart.svg)
![Response time 7d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/7d/chart.svg)
![Response time 30d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/30d/chart.svg)

응답 시간 차트를 생성하는 엔드포인트는 다음과 같습니다:
```
/api/v1/endpoints/{key}/response-times/{duration}/chart.svg
```
Where:
- `{duration}`는 `30d`, `7d`, 또는 `24h`입니다.
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 형식이며, 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.

##### 응답 시간 배지의 색상 임계값 변경 방법
응답 시간 배지의 임계값을 변경하려면 해당 엔드포인트에 관련 구성을 추가할 수 있습니다.
배열의 값은 [Awesome, Great, Good, Passable, Bad] 레벨에 해당합니다.
모든 다섯 값은 밀리초(ms) 단위로 제공되어야 합니다.

```yaml
endpoints:
- name: nas
  group: internal
  url: "https://example.org/"
  interval: 5m
  conditions:
    - "[STATUS] == 200"
  ui:
    badge:
      response-time:
        thresholds: [550, 850, 1350, 1650, 1750]
```
### API
Gatus는 엔드포인트 상태 및 이력을 프로그래밍 방식으로 확인할 수 있는 간단한 읽기 전용 API를 제공합니다.

모든 엔드포인트는 다음 엔드포인트에 대한 GET 요청을 통해 사용할 수 있습니다:



```
/api/v1/endpoints/statuses
````
예제: https://status.twin.sh/api/v1/endpoints/statuses

특정 엔드포인트는 다음 패턴을 사용하여 조회할 수도 있습니다:
```
/api/v1/endpoints/{group}_{endpoint}/statuses
```
Example: https://status.twin.sh/api/v1/endpoints/core_blog-home/statuses

`Accept-Encoding` HTTP 헤더에 `gzip`이 포함되어 있으면 Gzip 압축이 사용됩니다.

API는 `Content-Type` 응답 헤더가 `application/json`으로 설정된 JSON 페이로드를 반환합니다.
API를 쿼리할 때 이러한 헤더는 필요하지 않습니다.

#### 원시 데이터
Gatus는 모니터링 중인 엔드포인트 중 하나에 대한 원시 데이터를 노출합니다.
이를 통해 모니터링된 엔드포인트의 데이터를 자체 애플리케이션에서 추적하고 집계할 수 있습니다. 예를 들어 7일보다 긴 기간 동안 가동 시간을 추적하려는 경우입니다.

##### 가동 시간
엔드포인트의 원시 가동 시간 데이터를 가져오는 경로는 다음과 같습니다:
```
/api/v1/endpoints/{key}/uptimes/{duration}
```
Where:
- `{duration}`는 `30d`, `7d`, `24h` 또는 `1h`입니다.
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 패턴이며, 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.

예를 들어, 그룹 `core`의 엔드포인트 `frontend`에서 지난 24시간 동안의 원시 가동 시간 데이터를 원한다면 URL은 다음과 같습니다:</
```
https://example.com/api/v1/endpoints/core_frontend/uptimes/24h
```
##### 응답 시간
엔드포인트의 원시 응답 시간 데이터를 얻는 경로는 다음과 같습니다:


```
/api/v1/endpoints/{key}/response-times/{duration}
```
Where:
- `{duration}`는 `30d`, `7d`, `24h` 또는 `1h`입니다.
- `{key}`는 `<GROUP_NAME>_<ENDPOINT_NAME>` 패턴을 가지며, 두 변수 모두 ` `, `/`, `_`, `,`, `.` 및 `#`가 `-`로 대체됩니다.

예를 들어, 그룹 `core`의 엔드포인트 `frontend`에서 지난 24시간 동안의 원시 응답 시간 데이터를 원할 경우, URL은 다음과 같습니다:</
```
https://example.com/api/v1/endpoints/core_frontend/response-times/24h
```
### 바이너리로 설치하기
다음 명령어를 사용하여 Gatus를 바이너리로 다운로드할 수 있습니다:

```
go install github.com/TwiN/gatus/v5@latest
```


### High level design overview
![Gatus diagram](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gatus-diagram.jpg)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---