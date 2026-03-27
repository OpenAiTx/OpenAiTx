
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![状态](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![许可证](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

一个容器化的 Node.js 应用程序，用于同步来自 **Last.fm** 的 scrobble，存储到本地 **SQLite** 数据库，并提供网页仪表盘。

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## 项目

**Your LastFM** 是一个 Node.js 应用程序，旨在**自动同步 Last.fm 的音乐 Scrobbles**。它会将你的收听历史保存在本地 SQLite 数据库，并提供一个 Web 界面用于数据可视化。

该项目完全采用 **Docker** 容器化，使用自动化入口点处理数据库初始化和顺序执行（先同步，再启动 Web API）。容器内部还使用 **PM2** 作为进程管理器，以确保 Web 服务始终保持活跃和高可用。

## 功能
### 交互式 Web 仪表板

- 干净、现代的网页界面，展示你的音乐活动。

### 自动 Last.fm Scrobble 同步

- 定期从 Last.fm 获取并存储你的收听历史（scrobbles）。
- 确保你的数据始终是最新的，无需手动操作。

### 本地音乐历史数据库

- 将所有 scrobbles 保存在本地 SQLite 数据库中。
- 支持快速查询和离线访问历史收听数据。

### 最近 Scrobbles 展示

- 显示你最近收听的曲目。
- 针对曲目、专辑和艺人使用智能图片回退逻辑。

### 好友对比（兼容性视图）

- 与 Last.fm 好友对比你的音乐品味。
- 显示兼容性等级（极低 → 超级）。
- 展示共同的热门艺人、专辑和曲目。
- 基于真实的收听数据计算并归一化兼容性。

### 可分享的音乐卡片

- 基于你的收听数据生成动态图片。
- 针对信息流和 Instagram 限时动态（9:16）优化布局。

- 使用 node-canvas 构建，实现服务器端图像渲染。

## 前置条件

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## 安装

### 创建一个 `.env` 文件

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---