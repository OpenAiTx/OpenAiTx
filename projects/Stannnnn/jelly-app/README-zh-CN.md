## Jelly Music App (JMA)

一个轻量且优雅的 Jellyfin 音乐界面。设计直观简洁，注重细节，是一个以音乐播放为中心的无杂乱网页应用。通过 Jellyfin API，提供无缝访问您的个人音乐库。[演示](https://stannnnn.github.io/jelly-app/login?demo=1)

**寻找视频播放器？** 请查看 [Jelly Video App](https://github.com/Stannnnn/jelly-video-app/) —— 适用于您的 Jellyfin 库的视频版！

<br/>

<div>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/light-variant.webp" alt="Light variant" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/dark-variant.webp" alt="Dark variant" width="49%">
</div>
<br/>

<details>
  <summary>更多截图</summary>
  <br/>
  <b>侧边栏搜索</b>
  <p>搜索曲目、艺术家、专辑、播放列表、流派</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-light-variant.png" alt="Sidenav search light variant" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-dark-variant.png" alt="Sidenav search dark variant" width="49%">
  <br/>
  <br/>
  <b>搜索结果</b>
  <p>在专用窗口查看更多搜索结果</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-light-variant.webp" alt="Search results light variant" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-dark-variant.webp" alt="Search results dark variant" width="49%">
  <br/>
  <br/>
  <b>艺术家</b>
  <p>展示最常播放的歌曲、专辑及其他合作作品</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-light-variant.webp" alt="Artist light variant" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-dark-variant.webp" alt="Artist dark variant" width="49%">
  <br/>
  <br/>
  <b>播放列表</b>
  <p>播放列表视图，带有编号曲目列表</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-light-variant.webp" alt="Playlist light variant" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-dark-variant.webp" alt="Playlist dark variant" width="49%">
</details>
### 功能特点

- **优雅简洁的设计：** 干净、无杂乱的界面，让音乐播放轻松愉快。使用 React 等现代工具构建，提供快速且可靠的体验。
- **设备友好：** 在移动端和桌面端均享受流畅、类似应用的体验，可作为 PWA 安装，实现即时访问。
- **无缝库访问：** 连接到您的 Jellyfin 服务器，轻松浏览您的个人音乐收藏。
- **发现您的收藏：**
    - **首页：** 通过最近播放的曲目、最常播放的收藏和新添加的媒体快速回归。
    - **艺术家：** 浏览您库中任一艺术家的热门曲目、专辑及合作作品。
    - **播放列表：** 查看带有清晰编号曲目的播放列表，快速导航。
    - **快速搜索：** 通过侧边导航搜索或专用结果页，轻松查找曲目、艺术家、专辑、播放列表或风格。
    - **即时混音：** 在独立页面享受从您的音乐库直接策划的播放列表。
- **播放队列：** 通过增强和改进的队列功能，轻松管理和重新排序曲目。
- **交叉渐变：** 在曲目间平滑过渡，带来无缝沉浸的听觉体验。
- **预加载：** 智能预加载下一曲，确保播放顺畅，无缓冲延迟。
- **同步歌词：** 以壮观的界面享受您喜爱的歌曲，歌词按行精准同步显示。
- **智能缓存：** 高效缓存您的音乐，实现即时流畅播放。
- **离线同步：** 下载单曲、整张专辑、播放列表或艺术家音乐，实现离线播放。
    - **自动同步：** 自动下载新添加的曲目到任何之前保存的播放列表、专辑或艺术家。
    - **持久队列：** 下载通过本地队列管理，跨会话无缝续传。
    - **转码或直传流：** 支持根据所选比特率下载原始品质或转码版本。
- **Docker 支持：** 使用预配置 Jellyfin 服务器 URL 的预构建 Docker 镜像拉取并部署应用，实现无缝自托管。

### 安装

Jelly Music App 可作为专用桌面应用安装，下载地址请见我们的 [GitHub 发布页面](https://github.com/Stannnnn/jelly-app/releases)。您也可以从中获取最新的生产构建版本，将压缩包内容放置于可通过网络访问的目录中，在您的网络服务器上部署。
<br/>
它同样以 **docker 镜像** 形式提供，方便部署，详见下方 docker 相关内容。
<br/>
<br/>

如果您希望自行构建项目或运行开发服务器，需要安装 [Yarn](https://classic.yarnpkg.com/lang/en/docs/install) (`npm i -g yarn`)。

#### 从源码构建

1. 克隆仓库：

    ```bash
    git clone https://github.com/Stannnnn/jelly-app.git
    ```
2. 安装依赖项：
    ```bash
    yarn
    ```
3. 构建生产文件：
    ```bash
    yarn build
    ```
4. 将 `dist` 文件夹的内容部署到可通过网络访问的目录。

或者，您可以直接运行开发服务器：`yarn dev` 或 `yarn dev:nocache`

如果您希望为应用程序使用根目录（`/`）以外的基础路径，必须在构建时手动设置 `URL_BASE_PATH` 为您首选的基础路径。

保持配置为默认，或根据需要更改 [`config.json`](https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/config.json)。配置说明见 [应用配置部分](#app-configuration)。
构建后的应用程序中可以直接更改 `config.json` 文件。仅更改配置变量时无需重新构建。

### Docker

您可以使用来自 ghcr.io 的预构建镜像，通过 Docker 轻松托管 Jelly Music 应用：

#### 拉取 docker 镜像

```bash
docker pull ghcr.io/stannnnn/jelly-music-app:latest
```

#### 运行 Docker 镜像

```bash
docker run --rm -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```

Docker 镜像也可以通过添加 -d 标志在后台运行 `docker run -d ...`

#### 使用配置变量运行 docker 镜像

```bash
docker run --rm \
    -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
    -e LOCK_JELLYFIN_URL=false \
    -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```

<br/>

以下是 Docker 可用的标签：

| 标签    | 描述                      |
| ------ | -------------------------- |
| latest | 跟踪最新发布版本           |
| main   | 跟踪主分支                 |
| vX.X.X | 版本特定标签               |

例如：`ghcr.io/stannnnn/jelly-music-app:latest`

#### Docker 容器构建

你也可以使用 Docker 构建 Jelly Music App。

1.  构建 Docker 镜像：

    ```bash
    docker build . --tag jelly-music-app
    ```

2.  运行 Docker 容器：

    ```bash
    docker run --rm -p 80:80 jelly-music-app:latest
    ```
您还可以使用环境变量提供配置。


    ```bash
    docker run --rm \
        -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
        -e LOCK_JELLYFIN_URL=false \
        -p 80:80 jelly-music-app:latest
    ```

#### Docker Compose

为了更方便地管理容器，您可以使用 Docker Compose。仓库中提供了一个带有合理默认设置的 `docker-compose.yaml` 文件。

1.  复制示例环境文件并根据您的设置进行自定义：

    ```bash
    cp .env.example .env
    ```
2.  编辑 `.env` 文件，填写您的 Jellyfin 服务器 URL 及偏好设置：


    ```env
    JELLYAPP_PORT=80
    JELLYAPP_DEFAULT_URL=https://demo.jellyfin.org/stable
    JELLYAPP_LOCK_URL=true
    ```

3. 使用 Docker Compose 启动容器：

    ```bash
    docker-compose up -d
    ```

`docker-compose.yaml` 文件使用以下默认环境变量：

- `JELLYAPP_PORT`：外部暴露端口（默认值：`80`）
- `JELLYAPP_DEFAULT_URL`：默认 Jellyfin 服务器 URL（默认值：`https://demo.jellyfin.org/stable`）
- `JELLYAPP_LOCK_URL`：锁定 Jellyfin URL 输入（默认值：`false`）

### 应用配置

应用配置可以在构建过程中或发布文件中通过编辑 `config.json` 文件进行修改。使用 Docker 时，可以通过环境变量提供配置。可用的配置选项如下：

- `DEFAULT_JELLYFIN_URL`：设置首次访问应用时加载的默认 Jellyfin 服务器 URL（如果本地存储中没有存储 URL）。
- `LOCK_JELLYFIN_URL`：如果设置为 `true`，则移除 URL 输入字段，并强制所有连接使用默认 URL（`DEFAULT_JELLYFIN_URL`），适合绑定单一服务器的自托管实例。

### 贡献

我们欢迎拉取请求，请将其合并到 `develop` 分支。如果您有任何建议或改进，欢迎提交 issue 或拉取请求。感谢您的贡献与支持！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---