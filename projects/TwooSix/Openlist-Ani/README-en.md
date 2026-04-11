<h1 align="center">Openlist-Ani</h1>

<p align="center">
  <b>🎬 RSS Subscription → Automatic Download → AI Renaming, One-stop Anime Automation Management</b>
</p>

<p align="center">
  Automatically obtain anime updates from related RSS feeds, download offline to the corresponding cloud drive via Openlist,<br/>
  and use LLM to analyze resource names, renaming them into formats parsable by Emby / Jellyfin.
</p>

---

## ✨ Features

- 📡 **Auto Anime Tracking** — Automatically fetch and download RSS anime updates
- 📦 **Multi-Cloud Support** — Based on OpenList, supports offline downloads for PikPak, 115, etc.
- 🤖 **AI Renaming** — AI analyzes resource names + TMDB search to accurately get anime title, season, episode
- 💬 **Smart Assistant** — Mounted on Telegram Bot, use natural language to let AI help you search and download resources
- 🔔 **Update Notifications** — Push updates via PushPlus, Telegram, and other channels

## 📋 Preparation

1. Deploy Openlist according to the [Openlist official documentation](https://doc.oplist.org/guide) and set up offline downloads
2. Prepare RSS subscription links (e.g., [Mikan Project](https://mikanani.me))
3. Prepare LLM API Key

## 🚀 Quick Start

<details open>
<summary><b>Method 1: PIP Installation (Recommended)</b></summary>

**1. Installation**

```bash
pip install openlist-ani
```

**2. Creating the Configuration File**

Create a new `config.toml` in the running directory and fill in the following content:

```toml
[rss]
urls = ["RSS订阅链接"]

[openlist]
url = "http://localhost:5244"       # Openlist 访问地址
token = ""                          # 令牌，见「设置 → 其他 → 令牌」
download_path = "/PikPak/Anime"     # 下载保存路径
offline_download_tool = "QBITTORRENT"  # 离线下载工具

[llm]
openai_api_key = ""                 # API Key
openai_base_url = "https://api.deepseek.com/v1"
openai_model = "deepseek-chat"
```

> 完整配置项请参考 [`config.toml.example`](https://raw.githubusercontent.com/TwooSix/Openlist-Ani/master/config.toml.example) 及 [配置说明](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

**3. 启动**

```bash
openlist-ani
```

**4. (Optional) Start the AI Assistant**

Run after adding the assistant configuration in the configuration file:

```toml
[assistant]
enabled = true

[assistant.telegram]
bot_token = ""        # 从 @BotFather 获取
allowed_users = []    # 允许的用户 ID 列表，留空则不限制
```

```bash
openlist-ani-assistant
```

</details>

<details>
<summary><b>Method 2: Docker Deployment</b></summary>

**1. Prepare Files**

Create in the running directory:
- `config.toml` — Configuration file (same content as above)
- `data/` — Data directory

**2. Start the container**

```bash
docker run -d \
  --name openlist-ani \
  --network host \
  -e ENABLE_ASSISTANT=false \
  -v /path/to/config.toml:/config.toml \
  -v /path/to/data:/data \
  twosix26/openlist-ani:latest
```

> Replace `/path/to/` with your actual path.  
> To enable the AI assistant, set `ENABLE_ASSISTANT` to `true` after completing the configuration.  
> For detailed instructions, see [Docker Deployment Guide](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南).

</details>

<details>
<summary><b>Method 3: Compile from Source</b></summary>

#### Prerequisite: Install uv

<table><tr><td>

**Linux / macOS**
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

</td><td>

**Windows**
```powershell
powershell -ExecutionPolicy ByPass -c "irm https://astral.sh/uv/install.ps1 | iex"
```

</td></tr></table>

> 更多安装方式参考 [uv 官方文档](https://github.com/astral-sh/uv)

#### 步骤

```bash
# 1. 克隆仓库
git clone https://github.com/TwooSix/Openlist-Ani.git && cd Openlist-Ani

# 2. 切换到最新版本（master 为开发分支，不保证稳定）
git checkout v***    # 替换为最新版本号

# 3. 安装依赖
uv sync --no-dev --frozen

# 4. 创建 config.toml 并填写配置（内容同上）

# 5. 启动
uv run openlist-ani

# 6.（可选）启动 AI 助理
uv run openlist-ani-assistant
```

</details>

## 📖 Documentation

- [Quick Start](https://github.com/TwooSix/Openlist-Ani/wiki/快速开始)
- [PIP Installation Guide](https://github.com/TwooSix/Openlist-Ani/wiki/PIP安装指南)
- [Docker Deployment Guide](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南)
- [Source Code Compilation Guide](https://github.com/TwooSix/Openlist-Ani/wiki/源码编译指南)
- [Configuration Instructions](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

## 🖼️ Demo

| Rename Result | Intelligent Assistant |
| :---: | :---: |
| <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic1.png" width="400"/> | <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic2.jpg" width="150"/> |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---