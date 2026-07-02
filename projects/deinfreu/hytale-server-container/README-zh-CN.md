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

通过 10 多位贡献者打造的社区驱动 Docker 镜像部署 Hytale 专用服务器。该项目通过内置的安全、网络和调试工具简化了 Hytale 的自托管。加入我们活跃的 Discord，获得直接支持并与其他服务器所有者交流。无论您是在测试模组还是运行持久世界，此容器都能以一条命令提供一致且适合生产的环境。

</div>

## 支持与资源

* **文档：** 详细的性能优化和安全规范请参见[项目文档](https://hytale-server-container.com/?utm_source=github&utm_medium=social&utm_campaign=github_readme)。
* **故障排除：** 报告问题前请先查看[支持](https://hytale-server-container.com/installation/support//?utm_source=github&utm_medium=social&utm_campaign=github_readme)页面和我们的[安全政策](https://raw.githubusercontent.com/deinfreu/hytale-server-container/main/SECURITY.md)。您也可以访问我们的[Discord](https://discord.com/invite/2kn2T6zpaV)。

## 快速开始

在 Linux 上安装 Docker [CLI](https://docs.docker.com/engine/install/)，或在 Windows、macOS 和 Linux 上安装 [GUI](https://docs.docker.com/desktop)。

您可以通过在命令行中运行以下命令启动容器。

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
另外，您也可以使用 Docker Compose 进行部署。使用以下配置，或浏览 [示例](https://github.com/deinfreu/hytale-server-container/tree/main/examples) 文件夹以获取更高级的模板。


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