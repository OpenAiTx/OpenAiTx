<div align="center" width="100%">

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png">
  <img alt="Docker Hytale Server Logo" src="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png" width="800">
</picture>

[![GitHub stars](https://img.shields.io/github/stars/deinfreu/hytale-server-container?style=for-the-badge&color=daaa3f)](https://github.com/deinfreu/hytale-server-container)
[![GitHub last commit](https://img.shields.io/github/last-commit/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container)
[![Discord](https://img.shields.io/discord/1458149014808821965?style=for-the-badge&label=Discord&labelColor=5865F2)](https://discord.gg/M8yrdnHb32)
[![Docker Pulls](https://img.shields.io/docker/pulls/deinfreu/hytale-server?style=for-the-badge)](https://hub.docker.com/r/deinfreu/hytale-server)
[![Docker Image Size (tag)](https://img.shields.io/docker/image-size/deinfreu/hytale-server/latest-alpine-liberica?sort=date&style=for-the-badge&label=ALPINE%20LIBERICA%20SIZE)](https://hub.docker.com/layers/deinfreu/hytale-server/latest-alpine-liberica/images/)
[![GitHub license](https://img.shields.io/github/license/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container/blob/main/LICENSE)

10명 이상의 기여자가 만든 커뮤니티 중심의 Docker 이미지로 Hytale 전용 서버를 배포하세요. 이 프로젝트는 내장된 보안, 네트워킹 및 디버깅 도구를 통해 Hytale 자체 호스팅을 간소화합니다. 직접 지원을 받고 다른 서버 소유자와 연결할 수 있는 활발한 Discord에 참여하세요. 모드를 테스트하든 영구적인 월드를 운영하든 이 컨테이너는 한 명령으로 일관되고 프로덕션 준비가 된 환경을 제공합니다.

</div>

## 지원 및 자료

* **문서:** 자세한 성능 최적화 및 보안 사양은 [프로젝트 문서](https://hytale-server-container.com/?utm_source=github&utm_medium=social&utm_campaign=github_readme)에서 확인할 수 있습니다.
* **문제 해결:** 문제를 보고하기 전에 [지원](https://hytale-server-container.com/installation/support//?utm_source=github&utm_medium=social&utm_campaign=github_readme) 페이지와 [보안 정책](https://raw.githubusercontent.com/deinfreu/hytale-server-container/main/SECURITY.md)을 확인하세요. 또한 [Discord](https://discord.com/invite/2kn2T6zpaV)를 방문할 수 있습니다.

## 빠른 시작

리눅스에서는 docker [CLI](https://docs.docker.com/engine/install/)를, 윈도우, macOS 및 리눅스에서는 [GUI](https://docs.docker.com/desktop)를 설치하세요.

CLI에서 다음 명령어를 실행하여 컨테이너를 실행할 수 있습니다.

```bash
docker run \
  --name hytale-server \
  -e SERVER_IP="0.0.0.0" \
  -e SERVER_PORT="5520" \
  -e PROD="FALSE" \
  -e DEBUG="FALSE" \
  -e TZ="Europe/Amsterdam" \
  -p 5520:5520/udp \
  -v "hytale-server:/home/container" \
  -v "/etc/machine-id:/etc/machine-id:ro" \
  --restart unless-stopped \
  deinfreu/hytale-server:latest
```
또는 Docker Compose를 사용하여 배포할 수 있습니다. 아래 구성을 사용하거나 더 고급 템플릿을 원한다면 [examples](https://github.com/deinfreu/hytale-server-container/tree/main/examples) 폴더를 탐색하세요.


```bash
services:
  hytale:
    image: deinfreu/hytale-server:latest
    container_name: hytale-server
    environment:
      SERVER_IP: "0.0.0.0"
      SERVER_PORT: "5520"
      PROD: "FALSE"
      DEBUG: "FALSE"
      TZ: "Europe/Amsterdam"
    restart: unless-stopped
    ports:
      - "5520:5520/udp"
    volumes:
      - ./data:/home/container
      - /etc/machine-id:/etc/machine-id:ro
    tty: true
    stdin_open: true
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---