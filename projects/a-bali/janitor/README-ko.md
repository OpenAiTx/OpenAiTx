# janitor
## 목표
Janitor는 IOT 장치의 가용성을 모니터링하고 장치가 사라지거나 데이터 전송을 중단할 경우 알림을 보내는 독립형 도구입니다. 이는 특히 많은 센서가 있고 하드웨어나 연결이 불안정할 수 있는 경우 문제 발생 시 조치를 취하고 장치의 안정성을 모니터링하는 데 유용합니다.

Janitor는 추가 기능 구현을 목표로 하지 않으므로 다른 홈 자동화 소프트웨어(예: HASS)의 대안이 아닙니다. 이 기능에만 집중함으로써 도구를 간단하고 효율적으로 유지할 수 있습니다.

Janitor는 현재 다음 모니터링 방식을 지원합니다:
* **MQTT:** Janitor는 미리 정의된 MQTT 주제를 구독하여 들어오는 메시지를 모니터링합니다. 각 채널에 대해 평균 전송 빈도가 계산되며, 이 간격 내에 새 메시지가 수신되지 않으면 Janitor가 알림을 보냅니다(임계값은 평균 빈도의 배수나 주제별 절대값으로 구성 가능). 이 방법은 정기적으로 MQTT를 통해 데이터를 제출하는 센서(예: 온도)에 특히 유용합니다.
* **Ping:** Janitor는 미리 정의된 호스트를 미리 정의된 빈도(호스트별로 구성 가능)로 핑하고 응답이 없으면 알림을 보냅니다(연속적으로 놓친 핑 횟수에 대한 임계값 설정 가능). 이 방법은 센서, 카메라 등 모든 종류의 IOT 장치에 유용합니다.
* **HTTP:** Janitor는 미리 정의된 주소에 HTTP GET 요청을 보내고 응답 여부 및 선택적으로 응답에 미리 정의된 문자열 포함 여부를 확인합니다. 연속적으로 실패한 요청이 구성된 임계값을 초과하면 알림을 보냅니다. 빈도와 타임아웃도 주소별로 구성 가능합니다. 이 방법은 웹 인터페이스가 있는 서비스(예: API, 호스팅 서비스)에 유용합니다.
* **Exec:** Janitor는 미리 구성된 명령을 실행하고 종료 코드를 확인합니다. 연속적으로 실패한 실행이 임계값을 초과하면 알림을 보냅니다. 빈도와 타임아웃은 명령별로 구성 가능합니다. 이 방법으로 사용자 지정 모니터링을 구현할 수 있습니다.

Janitor는 현재 다음 알림 방식을 지원합니다:
* **Telegram:** Janitor는 미리 정의된 Telegram 채널로 메시지를 전송합니다.
* **Gotify:** Janitor는 Gotify로 푸시 메시지를 전송합니다.
* **MQTT:** Janitor는 미리 구성된 MQTT 서버의 미리 구성된 주제에 메시지를 게시합니다. 메시지에는 JSON 페이로드가 포함됩니다(예제 구성 참조). 이는 HASS 등 자동화에 적합합니다.
* **Exec:** Janitor는 미리 구성된 명령을 실행합니다. 이를 통해 사용자 지정 알림 방식을 만들 수 있습니다.

추가로, Janitor는 현재 상태 및 과거 데이터를 볼 수 있는 웹 인터페이스를 제공하며, 항목 제거, 타임아웃, 간격, 임계값 변경 및 구성 파일 재로드가 가능합니다(아래 스크린샷 참조).

마지막으로, Janitor는 다음 엔드포인트를 가진 간단한 JSON API를 포함합니다:
* `/api/data`는 모든 모니터링 관련 데이터 스냅샷을 제공합니다.
* `/api/stats`는 기능 정상/비정상 상태의 모니터링 대상 수를 제공합니다.
* `/api/metrics`는 Prometheus 메트릭 형식의 대상 통계를 제공합니다.

## 스크린샷
![Screenshot](https://raw.githubusercontent.com/a-bali/janitor/master/docs/screenshot.png)

## 빌드 및 설치

Janitor는 Go로 작성되었으며 단일 독립 실행형 바이너리로 컴파일됩니다. Janitor는 Linux와 Windows 모두에서 컴파일되고 작동해야 합니다.

컴파일하려면 최소 Go 버전 1.16 이상을 사용하고 다음 명령어를 실행하여 저장소를 복제하고 바이너리를 빌드하세요:

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ go build

이렇게 하면 `janitor`라는 이름의 독립 실행형 바이너리가 생성되며 원하는 위치에 둘 수 있습니다. 릴리스용으로 미리 빌드된 바이너리는 Github에서 이용 가능합니다.

## 구성 및 사용법

구성을 위해서는 YAML 형식의 파일이 필요합니다. [샘플 구성 파일](https://raw.githubusercontent.com/a-bali/janitor/master/config.yml)을 사용하고, 파일 내 주석을 참고하여 필요에 따라 변경하세요. 대부분의 변수는 선택 사항이며 합리적인 기본값이 설정되어 있으니, 자세한 내용은 주석을 참조하십시오. 환경 변수는 `$ENV_VAR` 또는 `${ENV_VAR}` 형식으로 참조할 수 있으며, 해당 변수가 존재하면 그 값으로 대체되고(존재하지 않으면 빈 문자열로 대체) 사용됩니다.

최소한의 구성으로도 다음과 같이 작동 가능한 설정이 가능합니다 (Janitor의 웹 인터페이스가 기본 포트인 8080에서 사용 가능하다고 가정):

    monitor:
      mqtt:
        server: mymqtt.server
        targets:
        - topic: "/sensors/#"
    alert:
      gotify:
        server: "http://mygotify.server:1234"
        token: gotify_token

구성 파일을 만들었다면, Janitor는 다음과 같이 실행할 수 있습니다:

    $ janitor path/to/your/configfile.yml

Janitor는 표준 출력으로 로그를 기록합니다. 로그는 웹 인터페이스에서도 확인할 수 있으며, 모니터링 대상 삭제 및 구성 파일 재로드(예: 새 대상을 추가하거나 설정을 변경한 경우)가 가능합니다.

Janitor는 자체적으로 데몬화하지 않습니다. 지속적으로 실행하려면 systemd 서비스를 생성하는 것이 권장됩니다.

## Docker로 실행하기

최신 버전의 Janitor는 Docker Hub [`abali/janitor`](https://hub.docker.com/repository/docker/abali/janitor)에서 이용 가능합니다. 이를 사용하려면 구성 파일을 `/janitor/config.yml`에 매핑하세요:

    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 abali/janitor

또는 제공된 Dockerfile을 사용하여 직접 컨테이너를 빌드할 수 있습니다:

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ docker build . -t janitor
    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 janitor

## 향후 계획 및 기여사항


Janitor의 목적은 명확하고 단순합니다: IoT 장치의 가용성과 작동 상태를 모니터링하고 문제가 발생할 경우 알림을 제공하는 것입니다. 향후 개선 사항은 이 목적을 따라야 하며, 새로운 모니터링 방법을 추가하거나 새로운 알림 방법을 추가해야 합니다.

Janitor는 오픈 소스 소프트웨어이며, 소프트웨어를 개선하는 풀 리퀘스트를 Github을 통해 제출하는 것을 권장합니다.

## 라이선스

Janitor는 GPL 3.0 라이선스 하에 배포됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-25

---