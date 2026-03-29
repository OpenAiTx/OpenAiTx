# `acexy` - Go로 작성된 AceStream 프록시! ⚡

[![Go Build](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml/badge.svg)](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml)
[![Docker Release](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml/badge.svg?event=release)](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml)

## 목차

- [작동 방식 🛠](#how-it-works-)
- [주요 기능 🔗](#key-features-)
- [사용법 📐](#usage-)
- [최적화 🚀](#optimizing-)
  - [대안 🧃](#alternative-)
- [설정 옵션 ⚙](#configuration-options-)

## 작동 방식 🛠

이 프로젝트는
[AceStream 미들웨어 HTTP API](https://docs.acestream.net/developers/start-playback/#using-middleware)를 감싸는 래퍼로,
[HLS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming) 및
[MPEG-TS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming) 스트림 재생을 지원합니다.

저는 AceStream의 제한 사항과 스트림 재생 시 발생하는 몇 가지 문제들에 지쳤습니다 📽. 예를 들어, 동일 채널을
**단일 클라이언트만** 재생할 수 있습니다. 여러 클라이언트가
**다른 스트림을** 재생하려면 각 클라이언트마다 고유한 `pid`를 수동으로 추가해야 합니다.
전송 중 오류가 발생하면 전체 스트림이 **중단**되는 등의 문제가 있습니다.

저는 단일 서버와 여러 클라이언트가 있는 홈 네트워크에서 AceStream을 사용하며 리소스를 최적화하려 했지만,
상당히 답답한 경험을 했습니다. 제가 사용하는 AceStream 네트워크 토폴로지는 다음과 같습니다:

![내 네트워크용 AceStream 토폴로지](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/topology.svg)

몇 가지 문제점이 있습니다:

* **한 번에 하나의 클라이언트만** 동일 스트림을 재생할 수 있습니다 🚫.
* 각 클라이언트가 자체적으로 AceStream을 실행하는 것은 리소스 낭비이며
  네트워크 과부하를 초래합니다 📉.




* 여러 클라이언트가 고유한 `pid`(플레이어 ID)를 가지고 있다면 서로 다른 스트림을 재생할 수 있습니다 🔓.
* 표준 AceStream HTTP API는 오류에 충분히 견고하지 않으며, 전송이 중단되면 모든 클라이언트에 대해 중단됩니다 ❌.

## 주요 기능 🔗

`acexy`를 사용하면 자동으로 다음을 갖게 됩니다:

* 모든 AceStream 스트림을 실행하는 단일 중앙 서버 ⛓.
* 클라이언트별 스트림별 고유 `pid`(플레이어 ID) 자동 할당 🪪.
* **스트림 다중화** 🕎: 동일한 스트림을 *여러 클라이언트에서 동시에* 재생할 수 있습니다.
* HTTP 미들웨어 덕분에 **견고하고 오류에 강한** 스트리밍 🛡.
* Go로 작성된 *초고속, 최소 프록시* ☄!

이 프록시를 사용하면 다음 아키텍처가 가능합니다:

![acexy 토폴로지](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/acexy.svg)

## 사용법 📐

`acexy`는 Docker 이미지로 제공 및 배포됩니다. 최신 [Docker](https://docker.com) 이미지가 설치되어 있고 사용 가능해야 합니다.

Acexy 컨테이너는 AceStream 서버에 연결합니다. Docker 이미지를 배포하고 Acexy를 같은 네트워크 내에 연결하거나, 호스트에서 실행 중인 AceStream 버전이 있다면 호스트 네트워크 모드로 Acexy를 실행해야 합니다.

> **정보**: 저장소에 `docker-compose.yml` 파일이 있어 전체 블록을 직접 실행할 수 있습니다. 이는 **`v0.2.0`부터 권장되는 설정**입니다.

서비스 블록을 실행하려면 먼저 `docker-compose.yml` 파일을 받고 다음을 실행하세요:










```shell
wget https://raw.githubusercontent.com/Javinator9889/acexy/refs/heads/main/docker-compose.yml
docker compose run -d
```
Docker Compose를 사용하고 싶지 않고, 이미 AceStream 서버가 있다고 가정하면,  
다른 방법은 다음과 같습니다:


```shell
docker run --network host ghcr.io/javinator9889/acexy
```

> **참고**: 편의를 위해 모든 조정 가능한 매개변수가 포함된 `docker-compose.yml` 파일이 제공됩니다.  
> 이 파일은 바로 실행할 준비가 되어 있으며, `v0.2.0`부터 권장되는 방법입니다.

기본적으로 프록시는 MPEG-TS 모드로 작동합니다. 모드를 전환하려면,  
**`-m3u8` 플래그**를 추가하거나 **`ACEXY_M3U8=true` 환경 변수**를 설정해야 합니다.

> **참고**: HLS 모드 - `ACEXY_M3U8` 또는 `-m3u8` 플래그 - 는 테스트되지 않은 상태입니다.  
> 사용을 권장하지 않으며 작동을 보장하지 않습니다.

사용 가능한 단일 엔드포인트는 `/ace/getstream`이며, 이는 표준  
[AceStream Middleware/HTTP API](https://docs.acestream.net/developers/api-reference/)와 동일한 매개변수를 받습니다.  
따라서 스트림을 실행하려면 선호하는 애플리케이션(예: VLC)에서 다음 링크를 열면 됩니다:




```
http://127.0.0.1:8080/ace/getstream?id=dd1e67078381739d14beca697356ab76d49d1a2
```
where `dd1e67078381739d14beca697356ab76d49d1a2` 는 AceStream 채널의 ID입니다.

## 최적화 🚀

프록시 뒤에서 실행 중인 AceStream 엔진은 성능 최적화를 위해 노출할 수 있는 여러 포트를 가지고 있습니다. 기본값은 다음과 같습니다:

- `8621/tcp`
- `8621/udp`

> 참고: Docker 내 `EXTRA_FLAGS` 변수에서 `--port` 플래그를 사용하여 조정할 수 있습니다.

이 포트들을 노출하면 보다 안정적인 스트리밍 경험을 얻는 데 도움이 됩니다. 게이트웨이에서도 해당 포트를 열어야 한다는 점을 유의하세요.

참고로, Docker 명령어는 다음과 같이 실행해야 합니다:






```shell
docker run -t -p 8080:8080 -p 8621:8621 ghcr.io/javinator9889/acexy
```
### 대안 🧃

AceStream은 내부적으로 UPnP IGD를 사용하여 원격 기계에 연결하려고 시도합니다.  
문제는 Docker에서 추가한 브리지 레이어 때문에 이것이 작동하지 않는다는 것입니다  
(참조: https://docs.docker.com/engine/network/drivers/bridge/).

Acexy의 단일 인스턴스와 AceStream의 단일 인스턴스를 실행 중이라면  
*호스트 네트워킹*으로 컨테이너를 실행해도 안전합니다. 이는 다음을 의미합니다:

- 컨테이너는 **메인 네트워크에 브리지된 다른 애플리케이션에 접근할 수 있습니다.**  
- 포트를 노출할 **필요가 없습니다.**  
- 성능이 **조금 최적화됩니다.**

> 참고: 이 방법은 Linux 환경에서만 작동합니다. 자세한 내용은 https://docs.docker.com/engine/network/drivers/host/  
> 를 참조하세요.

명령어는 매우 간단합니다:


```shell
docker run -t --network host ghcr.io/javinator9889/acexy
```
That should enable AceStream to use UPnP freely.

## Configuration Options ⚙

Acexy has tons of configuration options that allow you to customize the behavior. All of them have
default values that were tested for the optimal experience, but you may need to adjust them
to fit your needs.

> **PRO-TIP**: You can issue `acexy -help` to have a complete view of all the available options.

As Acexy was thought to be run inside a Docker container, all the variables and settings are
adjustable by using environment variables.


<table>
  <thead>
    <tr>
      <th>플래그</th>
      <th>환경 변수</th>
      <th>설명</th>
      <th>기본값</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th><code>-license</code></th>
      <th>-</th>
      <th>프로그램 라이선스를 출력하고 종료</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-help</code></th>
      <th>-</th>
      <th>도움말 메시지를 출력하고 종료</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-addr</code></th>
      <th><code>ACEXY_LISTEN_ADDR</code></th>

      <th>Acexy가 수신 대기하는 주소입니다. <code>host</code> 모드에서 실행할 때 유용합니다.</th>
      <th><code>:8080</code></th>
    <tr>
    <tr>
      <th><code>-scheme</code></th>
      <th><code>ACEXY_SCHEME</code></th>
      <th>
        AceStream 미들웨어의 스킴입니다. AceStream을 HTTPS로 설정한 경우 이 값을 조정해야 합니다.
      </th>
      <th><code>http</code></th>
    <tr>
    <tr>
      <th><code>-acestream-host</code></th>
      <th><code>ACEXY_HOST</code></th>
      <th>
        AceStream 미들웨어가 위치한 곳입니다. Acexy가 다른 AceStream 엔진에 연결해야 하는 경우 변경하세요.
      </th>
      <th><code>localhost</code></th>
    <tr>
    <tr>
      <th><code>-acestream-port</code></th>
      <th><code>ACEXY_PORT</code></th>
      <th>
        AceStream 미들웨어에 연결할 포트입니다. Acexy가 다른 AceStream 엔진에 연결해야 하는 경우 변경하세요.
      </th>
      <th><code>6878</code></th>
    <tr>
    <tr>
      <th><code>-m3u8-stream-timeout</code></th>
      <th><code>ACEXY_M3U8_STREAM_TIMEOUT</code></th>
      <th>
        Acexy를 M3U8 모드로 실행할 때, 스트림이 완료되었다고 간주하는 타임아웃 시간입니다.
      </th>
      <th><code>60s</code></th>
    <tr>
    <tr>
      <th><code>-m3u8</code></th>



      <th><code>ACEXY_M3U8</code></th>
      <th>
        Acexy에서 M3U8 모드를 활성화합니다. <b>경고</b>: 이 모드는 실험적이며 예상대로 작동하지 않을 수 있습니다.
      </th>
      <th>비활성화됨</th>
    <tr>
    <tr>
      <th><code>-empty-timeout</code></th>
      <th><code>ACEXY_EMPTY_TIMEOUT</code></th>
      <th>
        미들웨어로부터 빈 정보가 수신된 후 스트림이 종료된 것으로 간주하는 타임아웃입니다.
        M3U8 모드에서는 무의미합니다.
      </th>
      <th><code>1m</code></th>
    <tr>
    <tr>
      <th><code>-buffer-size</code></th>
      <th><code>ACEXY_BUFFER_SIZE</code></th>
      <th>
        플레이어로 데이터를 복사하기 전에 스트림의 최대 <code>buffer-size</code> 바이트를 버퍼링합니다.
        재생 중 안정성을 높이는 데 유용합니다.
      </th>
      <th><code>4.2MiB</code></th>
    <tr>
    <tr>
      <th><code>-no-response-timeout</code></th>
      <th><code>ACEXY_NO_RESPONSE_TIMEOUT</code></th>
      <th>
        새로 열린 스트림에 대해 AceStream 미들웨어가 응답을 반환할 때까지 대기하는 시간입니다.
        인터넷 연결이 매우 좋지 않은 경우(예: 매우 큰 지연 시간) 아니면 가능한 낮게 설정해야 합니다.
      </th>
      <th><code>1s</code></th>
    <tr>
  </tbody>
</table>

> **참고**: 옵션 목록은 방대하지만 최신이 아닐 수 있습니다. 의심스러울 경우 항상
> Acexy 바이너리의 `-help` 출력을 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---