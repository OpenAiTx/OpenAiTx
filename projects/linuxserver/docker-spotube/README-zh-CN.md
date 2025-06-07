<!-- 不要手动编辑此文件 -->
<!-- 请阅读 https://github.com/linuxserver/docker-spotube/blob/master/.github/CONTRIBUTING.md -->
[![linuxserver.io](https://raw.githubusercontent.com/linuxserver/docker-templates/master/linuxserver.io/img/linuxserver_medium.png)](https://linuxserver.io)

[![Blog](https://img.shields.io/static/v1.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=linuxserver.io&message=Blog)](https://blog.linuxserver.io "了解我们容器的所有使用方法，包括操作指南、观点以及更多内容！")
[![Discord](https://img.shields.io/discord/354974912613449730.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=Discord&logo=discord)](https://linuxserver.io/discord "与社区和团队进行实时支持/聊天。")
[![Discourse](https://img.shields.io/discourse/https/discourse.linuxserver.io/topics.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&logo=discourse)](https://discourse.linuxserver.io "在我们的社区论坛发帖。")
[![Fleet](https://img.shields.io/static/v1.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=linuxserver.io&message=Fleet)](https://fleet.linuxserver.io "一个在线 Web 界面，展示我们维护的所有镜像。")
[![GitHub](https://img.shields.io/static/v1.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=linuxserver.io&message=GitHub&logo=github)](https://github.com/linuxserver "查看我们所有仓库的源代码。")
[![Open Collective](https://img.shields.io/opencollective/all/linuxserver.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=Supporters&logo=open%20collective)](https://opencollective.com/linuxserver "请考虑通过捐赠或贡献预算来帮助我们")

[LinuxServer.io](https://linuxserver.io) 团队为你带来另一个容器发布，特性包括：

* 定期和及时的应用更新
* 简单的用户映射（PGID, PUID）
* 带有 s6 overlay 的自定义基础镜像
* 每周基础操作系统更新，整个 LinuxServer.io 生态使用通用层，最大限度减少空间占用、停机时间和带宽使用
* 定期安全更新

你可以在以下地方找到我们：

* [Blog](https://blog.linuxserver.io) - 了解我们容器的所有使用方法，包括操作指南、观点以及更多内容！
* [Discord](https://linuxserver.io/discord) - 与社区和团队进行实时支持/聊天。
* [Discourse](https://discourse.linuxserver.io) - 在我们的社区论坛发帖。
* [Fleet](https://fleet.linuxserver.io) - 一个在线 Web 界面，展示我们维护的所有镜像。
* [GitHub](https://github.com/linuxserver) - 查看我们所有仓库的源代码。
* [Open Collective](https://opencollective.com/linuxserver) - 请考虑通过捐赠或贡献预算来帮助我们

# [linuxserver/spotube](https://github.com/linuxserver/docker-spotube)

[![Scarf.io pulls](https://scarf.sh/installs-badge/linuxserver-ci/linuxserver%2Fspotube?color=94398d&label-color=555555&logo-color=ffffff&style=for-the-badge&package-type=docker)](https://scarf.sh)
[![GitHub Stars](https://img.shields.io/github/stars/linuxserver/docker-spotube.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&logo=github)](https://github.com/linuxserver/docker-spotube)
[![GitHub Release](https://img.shields.io/github/release/linuxserver/docker-spotube.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&logo=github)](https://github.com/linuxserver/docker-spotube/releases)
[![GitHub Package Repository](https://img.shields.io/static/v1.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=linuxserver.io&message=GitHub%20Package&logo=github)](https://github.com/linuxserver/docker-spotube/packages)
[![GitLab Container Registry](https://img.shields.io/static/v1.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=linuxserver.io&message=GitLab%20Registry&logo=gitlab)](https://gitlab.com/linuxserver.io/docker-spotube/container_registry)
[![Quay.io](https://img.shields.io/static/v1.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=linuxserver.io&message=Quay.io)](https://quay.io/repository/linuxserver.io/spotube)
[![Docker Pulls](https://img.shields.io/docker/pulls/linuxserver/spotube.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=pulls&logo=docker)](https://hub.docker.com/r/linuxserver/spotube)
[![Docker Stars](https://img.shields.io/docker/stars/linuxserver/spotube.svg?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=stars&logo=docker)](https://hub.docker.com/r/linuxserver/spotube)
[![Jenkins Build](https://img.shields.io/jenkins/build?labelColor=555555&logoColor=ffffff&style=for-the-badge&jobUrl=https%3A%2F%2Fci.linuxserver.io%2Fjob%2FDocker-Pipeline-Builders%2Fjob%2Fdocker-spotube%2Fjob%2Fmaster%2F&logo=jenkins)](https://ci.linuxserver.io/job/Docker-Pipeline-Builders/job/docker-spotube/job/master/)
[![LSIO CI](https://img.shields.io/badge/dynamic/yaml?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=CI&query=CI&url=https%3A%2F%2Fci-tests.linuxserver.io%2Flinuxserver%2Fspotube%2Flatest%2Fci-status.yml)](https://ci-tests.linuxserver.io/linuxserver/spotube/latest/index.html)

[Spotube](https://spotube.krtirtho.dev/) 是一个开源、跨平台的 Spotify 客户端，兼容多种平台，利用 Spotify 的数据 API 和 YouTube、Piped.video 或 JioSaavn 作为音频源，无需 Spotify Premium。

[![spotube](https://raw.githubusercontent.com/linuxserver/docker-templates/master/linuxserver.io/img/spotube-logo.png)](https://spotube.krtirtho.dev/)

## 支持的架构

我们使用 docker manifest 实现多平台感知。更多信息请参考 docker 的[文档](https://distribution.github.io/distribution/spec/manifest-v2-2/#manifest-list)以及我们的[公告](https://blog.linuxserver.io/2019/02/21/the-lsio-pipeline-project/)。

直接拉取 `lscr.io/linuxserver/spotube:latest` 即可获取与你架构相符的正确镜像，也可以通过标签拉取特定架构镜像。

此镜像支持的架构如下：

| 架构 | 可用性 | 标签 |
| :----: | :----: | ---- |
| x86-64 | ✅ | amd64-\<version tag\> |
| arm64 | ✅ | arm64v8-\<version tag\> |
| armhf | ❌ | |

## 应用设置

可通过以下地址访问应用：

* http://yourhost:3000/
* https://yourhost:3001/

**现代 GUI 桌面应用在最新 Docker 与 syscall 兼容性方面可能存在问题，你可以通过 Docker 设置 `--security-opt seccomp=unconfined`，以便在老内核或 libseccomp 主机上允许这些 syscalls。**

### 安全性

>[!WARNING]
>如果你不清楚自己在做什么，请不要将此服务暴露到互联网。

默认情况下，此容器没有认证，环境变量 `CUSTOM_USER` 和 `PASSWORD` 可选择开启基本 http 认证（通过内嵌的 NGINX 服务器），仅建议用于在本地网络中防止非授权访问。如果需要暴露到互联网，建议将其置于反向代理（如 [SWAG](https://github.com/linuxserver/docker-swag)）之后，并确保有安全的认证方案。Web 界面可启动终端，并配置为无密码 sudo，任何访问者都能安装、运行任意程序，同时可探测你的本地网络。

### 所有基于 KasmVNC GUI 容器的选项

此容器基于 [Docker Baseimage KasmVNC](https://github.com/linuxserver/docker-baseimage-kasmvnc)，因此可以通过环境变量和运行配置启用或禁用特定功能。

#### 可选环境变量

| 变量 | 说明 |
| :----: | --- |
| CUSTOM_PORT | 容器内部监听的 http 端口，如需更改默认 3000 可设置。 |
| CUSTOM_HTTPS_PORT | 容器内部监听的 https 端口，如需更改默认 3001 可设置。 |
| CUSTOM_USER | HTTP 基本认证用户名，默认 abc。 |
| PASSWORD | HTTP 基本认证密码，默认 abc。未设置则无认证。|
| SUBFOLDER | 如果通过子目录反向代理运行应用，需设置子目录，需加斜杠，如 `/subfolder/`。|
| TITLE | Web 浏览器显示的页面标题，默认为 "KasmVNC Client"。|
| FM_HOME | 文件管理器的主页目录（登陆目录），默认为 "/config"。|
| START_DOCKER | 若设为 false，则具有特权的容器不会自动启动 DinD Docker 设置。|
| DRINODE | 如挂载 /dev/dri 以启用 [DRI3 GPU 加速](https://www.kasmweb.com/kasmvnc/docs/master/gpu_acceleration.html)，可指定设备如 `/dev/dri/renderD128`。|
| DISABLE_IPV6 | 设为 true 或任意值将禁用 IPv6。|
| LC_ALL | 设置容器运行语言，如 `fr_FR.UTF-8`、`ar_AE.UTF-8` 等。|
| NO_DECOR | 设置后应用将在 openbox 中无窗口边框运行，适合用作 PWA。|
| NO_FULL | 使用 openbox 时，不自动全屏应用。|

#### 可选运行配置

| 变量 | 说明 |
| :----: | --- |
| `--privileged` | 在容器内启动 Docker in Docker (DinD) 设置，实现隔离环境中的 docker 使用。如需提升性能，可将宿主的 Docker 目录挂载到容器内，例如 `-v /home/user/docker-data:/var/lib/docker`。|
| `-v /var/run/docker.sock:/var/run/docker.sock` | 挂载宿主级 Docker socket，可用于 CLI 交互或 Docker 支持的应用。|
| `--device /dev/dri:/dev/dri` | 将 GPU 挂载到容器，可配合 `DRINODE` 环境变量，利用宿主视频卡实现 GPU 加速应用。仅支持**开源**驱动（如 Intel、AMDGPU、Radeon、ATI、Nouveau）。|

### 语言支持 - 国际化

环境变量 `LC_ALL` 可用于以非英语启动此容器。例如，启动桌面会话为法语 `LC_ALL=fr_FR.UTF-8`。部分语言如中文、日文、韩文将缺少正确渲染所需的字体（cjk 字体），其他语言字体可能也未安装，取决于基础发行版。我们仅确保拉丁字符字体存在。可通过 mod 在启动时安装字体。

以 Alpine 为例，启动时安装 cjk 字体：

```
-e DOCKER_MODS=linuxserver/mods:universal-package-install 
-e INSTALL_PACKAGES=fonts-noto-cjk
-e LC_ALL=zh_CN.UTF-8
```

Web 界面设置中有“IME 输入模式”选项，允许非 en_US 键盘输入非英文字符。启用后，其表现与本地 Linux 安装设置为你所用地区相同。

### DRI3 GPU 加速（KasmVNC 界面）

对于加速应用或游戏，可将渲染设备挂载到容器，并由应用调用：

`--device /dev/dri:/dev/dri`

此功能仅支持**开源**GPU 驱动：

| 驱动 | 说明 |
| :----: | --- |
| Intel | Intel iGPU 芯片的 i965 和 i915 驱动 |
| AMD | AMD 专用或 APU 芯片的 AMDGPU、Radeon 和 ATI 驱动 |
| NVIDIA | 仅支持 nouveau2 驱动，闭源 NVIDIA 驱动不支持 DRI3 |

`DRINODE` 环境变量可用于指定特定 GPU。
最新信息可参见[这里](https://www.kasmweb.com/kasmvnc/docs/master/gpu_acceleration.html)。

### Nvidia GPU 支持（KasmVNC 界面）

**Nvidia 支持与基于 Alpine 的镜像不兼容，因为 Alpine 缺少 Nvidia 驱动**

Nvidia 支持通过 Zink 实现 OpenGL 支持。可通过如下运行参数启用：

| 变量 | 说明 |
| :----: | --- |
| --gpus all | 可筛选，通常用于传递系统上的 Nvidia GPU |
| --runtime nvidia | 指定 Nvidia runtime，从宿主挂载驱动和工具 |

compose 语法略有不同，需要设置 nvidia 为默认 runtime：

```
sudo nvidia-ctk runtime configure --runtime=docker --set-as-default
sudo service docker restart
```

在 compose 中分配 GPU：

```
services:
  spotube:
    image: lscr.io/linuxserver/spotube:latest
    deploy:
      resources:
        reservations:
          devices:
            - driver: nvidia
              count: 1
              capabilities: [compute,video,graphics,utility]
```

### 应用管理

#### PRoot 应用

如需原生安装软件（如 `sudo apt-get install filezilla`），升级或重建容器后该软件将被移除，容器恢复为干净状态。部分用户接受此方案，可用系统原生命令（如 `apt-get upgrade`）升级包。如需 Docker 管理容器升级并保留应用及设置，我们提供了 [proot-apps](https://github.com/linuxserver/proot-apps)，可将便携应用安装到用户 `$HOME` 的持久存储，在 Docker 隔离环境中直接运行。这些应用及其设置在基础容器升级后仍会保留，并可实时挂载到不同的 KasmVNC 容器。命令行安装示例：

```
proot-apps install filezilla
```

PRoot Apps 已包含在所有 KasmVNC 基础容器中，linuxserver.io 支持的应用列表详见[此处](https://github.com/linuxserver/proot-apps?tab=readme-ov-file#supported-apps)。

#### 原生应用

可通过 [universal-package-install](https://github.com/linuxserver/docker-mods/tree/universal-package-install) 在容器启动时安装额外包，启动时间可能会明显增加，优先推荐使用 PRoot。

```yaml
  environment:
    - DOCKER_MODS=linuxserver/mods:universal-package-install
    - INSTALL_PACKAGES=libfuse2|git|gdb
```

## 用法

你可以使用 docker-compose 或 docker cli 创建此镜像的容器。

>[!NOTE]
>除非参数标注为“可选”，否则为*必填*，必须提供值。

### docker-compose（推荐，[点击此处了解更多](https://docs.linuxserver.io/general/docker-compose)）

```yaml
---
services:
  spotube:
    image: lscr.io/linuxserver/spotube:latest
    container_name: spotube
    security_opt:
      - seccomp:unconfined #可选
    environment:
      - PUID=1000
      - PGID=1000
      - TZ=Etc/UTC
    volumes:
      - /path/to/spotube/config:/config
    ports:
      - 3000:3000
      - 3001:3001
    restart: unless-stopped
```

### docker cli ([点击此处了解更多](https://docs.docker.com/engine/reference/commandline/cli/))

```bash
docker run -d \
  --name=spotube \
  --security-opt seccomp=unconfined `#可选` \
  -e PUID=1000 \
  -e PGID=1000 \
  -e TZ=Etc/UTC \
  -p 3000:3000 \
  -p 3001:3001 \
  -v /path/to/spotube/config:/config \
  --restart unless-stopped \
  lscr.io/linuxserver/spotube:latest
```

## 参数说明

容器通过运行时传递参数（如上所示）进行配置。这些参数以冒号分隔，分别表示 `<外部>:<内部>`。例如，`-p 8080:80` 表示将容器内的 80 端口暴露给宿主的 8080 端口。

| 参数 | 功能 |
| :----: | --- |
| `-p 3000:3000` | Spotube 桌面 GUI。|
| `-p 3001:3001` | Spotube 桌面 GUI 的 HTTPS。|
| `-e PUID=1000` | 用户 ID，详见下文说明 |
| `-e PGID=1000` | 用户组 ID，详见下文说明 |
| `-e TZ=Etc/UTC` | 指定使用的时区，详见 [列表](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#List)。|
| `-v /config` | 容器内用户主目录，存储本地文件和设置 |
| `--security-opt seccomp=unconfined` | 仅适用于 Docker Engine，许多现代 GUI 应用在老宿主机需要此项以支持未知 syscalls。|

## 来自文件的环境变量（Docker secrets）

可通过特殊前缀 `FILE__` 从文件设置任意环境变量。

示例：

```bash
-e FILE__MYVAR=/run/secrets/mysecretvariable
```

会根据 `/run/secrets/mysecretvariable` 文件内容设置环境变量 `MYVAR`。

## 运行应用的 umask

所有镜像均可通过可选参数 `-e UMASK=022` 覆盖服务的默认 umask 设置。
注意 umask 不是 chmod，而是基于其值“减去”权限，并不会增加权限。请在寻求支持前查阅[相关资料](https://en.wikipedia.org/wiki/Umask)。

## 用户 / 组标识

使用卷（`-v` 参数）时，宿主和容器之间可能会出现权限问题，我们允许你指定用户 `PUID` 和组 `PGID` 以避免此问题。

确保宿主上的卷目录属于你指定的用户，权限问题就会自动消失。

本例中 `PUID=1000` 和 `PGID=1000`，你可以通过如下命令查询：

```bash
id your_user
```

输出示例：

```text
uid=1000(your_user) gid=1000(your_user) groups=1000(your_user)
```

## Docker Mods

[![Docker Mods](https://img.shields.io/badge/dynamic/yaml?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=spotube&query=%24.mods%5B%27spotube%27%5D.mod_count&url=https%3A%2F%2Fraw.githubusercontent.com%2Flinuxserver%2Fdocker-mods%2Fmaster%2Fmod-list.yml)](https://mods.linuxserver.io/?mod=spotube "查看此容器可用的 mods。") [![Docker Universal Mods](https://img.shields.io/badge/dynamic/yaml?color=94398d&labelColor=555555&logoColor=ffffff&style=for-the-badge&label=universal&query=%24.mods%5B%27universal%27%5D.mod_count&url=https%3A%2F%2Fraw.githubusercontent.com%2Flinuxserver%2Fdocker-mods%2Fmaster%2Fmod-list.yml)](https://mods.linuxserver.io/?mod=universal "查看所有镜像通用 mods。")

我们发布了多种 [Docker Mods](https://github.com/linuxserver/docker-mods)，以便在容器内实现更多功能。可用 mods 列表（如有）以及可应用于任意镜像的通用 mods 可通过上方动态徽章访问。

## 支持信息

* 容器运行时获取 shell 访问：

    ```bash
    docker exec -it spotube /bin/bash
    ```

* 实时监控容器日志：

    ```bash
    docker logs -f spotube
    ```

* 容器版本号：

    ```bash
    docker inspect -f '{{ index .Config.Labels "build_version" }}' spotube
    ```

* 镜像版本号：

    ```bash
    docker inspect -f '{{ index .Config.Labels "build_version" }}' lscr.io/linuxserver/spotube:latest
    ```

## 更新说明

我们的大多数镜像为静态、版本化镜像，需通过更新镜像并重建容器来更新应用（如有例外将在相关 readme.md 说明）。不建议或支持在容器内部更新应用。请参考上方[应用设置](#application-setup)部分了解是否推荐在此镜像中更新应用。

以下为更新容器的说明：

### 通过 Docker Compose

* 更新镜像：
    * 所有镜像：

        ```bash
        docker-compose pull
        ```

    * 单个镜像：

        ```bash
        docker-compose pull spotube
        ```

* 更新容器：
    * 所有容器：

        ```bash
        docker-compose up -d
        ```

    * 单个容器：

        ```bash
        docker-compose up -d spotube
        ```

* 你还可以移除旧的悬空镜像：

    ```bash
    docker image prune
    ```

### 通过 Docker Run

* 更新镜像：

    ```bash
    docker pull lscr.io/linuxserver/spotube:latest
    ```

* 停止运行中的容器：

    ```bash
    docker stop spotube
    ```

* 删除容器：

    ```bash
    docker rm spotube
    ```

* 按上文说明重新创建新容器（如正确映射到宿主文件夹，你的 `/config` 及设置会被保留）
* 你还可以移除旧的悬空镜像：

    ```bash
    docker image prune
    ```

### 镜像更新通知 - Diun（Docker 镜像更新通知器）

>[!TIP]
>我们推荐 [Diun](https://crazymax.dev/diun/) 用于更新通知。不建议或支持其他自动无人值守更新容器的工具。

## 本地构建

如需出于开发或自定义逻辑目的对镜像进行本地修改：

```bash
git clone https://github.com/linuxserver/docker-spotube.git
cd docker-spotube
docker build \
  --no-cache \
  --pull \
  -t lscr.io/linuxserver/spotube:latest .
```

ARM 变体可在 x86_64 硬件上构建，反之亦然，需使用 `lscr.io/linuxserver/qemu-static`

```bash
docker run --rm --privileged lscr.io/linuxserver/qemu-static --reset
```

注册后，可通过 `-f Dockerfile.aarch64` 指定 dockerfile 构建。

## 版本

* **09.10.24:** - 增加 aarch64 支持。
* **26.04.24:** - 初始发布。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---