[![状态](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![许可证](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

一个容器化的 Node.js 应用程序，用于同步 **Last.fm** 的播放记录，将其存储在本地 **SQLite** 数据库中，并提供一个网页仪表盘。

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## 项目

**Your LastFM** 是一个 Node.js 应用，旨在 **自动同步 Last.fm 的音乐播放记录**。它将您的收听历史保存在本地 SQLite 数据库中，并提供一个用于数据可视化的网页界面。

该项目完全使用 **Docker** 容器化，采用自动化入口脚本来处理数据库初始化和顺序执行（先同步，再启动 Web API）。容器内还使用 **PM2** 作为进程管理器，确保网页服务持续运行且具有弹性。

## 功能
### 交互式网页仪表盘

- 干净、现代的网页界面，用于可视化您的音乐活动。

### 自动 Last.fm 播放记录同步

- 定期从 Last.fm 获取并存储您的收听历史（播放记录）。
- 确保您的数据始终保持最新，无需手动操作。

### 本地音乐历史数据库

- 将所有播放记录保存在本地 SQLite 数据库中。
- 支持快速查询和离线访问历史收听数据。

### 最近播放记录视图

- 显示您最近的曲目。
- 针对曲目、专辑和艺术家采用智能图片回退逻辑。

### 好友比较（兼容性视图）

- 与 Last.fm 好友比较您的音乐品味。
- 显示兼容性等级（非常低 → 超级）。
- 显示常见的顶级艺术家、专辑和曲目。
- 根据真实听歌数据计算并规范兼容性。

### 可分享的音乐卡片

- 根据您的听歌数据生成动态图片。
- 优化布局适用于动态消息和 Instagram 故事（9:16）
- 使用 node-canvas 构建，用于服务器端图像渲染。

## 先决条件

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## 安装

### 创建 `.env` 文件

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm：在[这里](https://www.last.fm/api/account/create)创建一个API账户以获取您的API密钥。

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

在终端中：  
`docker compose up -d`  

然后访问：
```
http://localhost:1533
```

（或将 `localhost` 替换为您的服务器IP）

## 许可证

本项目采用 MIT 许可证授权。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---