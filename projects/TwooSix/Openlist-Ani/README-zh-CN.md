<h1 align="center">Openlist-Ani</h1>

<p align="center">
  <b>🎬 RSS 订阅 → 自动下载 → AI 重命名，一站式番剧自动化管理</b>
</p>

<p align="center">
  从动漫番剧相关的 RSS 订阅源中自动获取番剧更新，通过 Openlist 离线下载至对应网盘，<br/>
  并结合 LLM 分析资源名，将资源重命名为 Emby / Jellyfin 可解析的格式。
</p>

---

## ✨ 特点

- 📡 **自动追番** — 自动获取 RSS 番剧更新并下载
- 📦 **多网盘支持** — 基于OpenList实现，支持 PikPak、115 等离线下载
- 🤖 **AI 重命名** — AI 分析资源名 + TMDB 搜索，精准获取番剧名、季度、集数
- 💬 **智能助理** — 挂载至 Telegram Bot，通过自然语言让 AI 帮你搜索并下载资源
- 🔔 **更新通知** — 通过 PushPlus、Telegram 等渠道推送更新

## 📋 准备工作

1. 参照 [Openlist 官方文档](https://doc.oplist.org/guide) 部署 Openlist，并搭建好离线下载
2. 准备好 RSS 订阅链接（如 [Mikan Project](https://mikanani.me)）
3. 准备好 LLM API Key

## 🚀 快速开始

<details open>
<summary><b>方式一：PIP 安装（推荐）</b></summary>

**1. 安装**

```bash
pip install openlist-ani
```

**2. 创建配置文件**

在运行目录下新建 `config.toml`，填入以下内容：

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

**4.（可选）启动 AI 助理**

在配置文件中补充助理配置后运行：

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
<summary><b>方式二：Docker 部署</b></summary>

**1. 准备文件**

在运行目录下创建：
- `config.toml` — 配置文件（内容同上）
- `data/` — 数据目录

**2. 启动容器**

```bash
docker run -d \
  --name openlist-ani \
  --network host \
  -e ENABLE_ASSISTANT=false \
  -v /path/to/config.toml:/config.toml \
  -v /path/to/data:/data \
  twosix26/openlist-ani:latest
```
> 将 `/path/to/` 替换为你的实际路径。  
> 如需启用 AI 助理，填写好配置后将 `ENABLE_ASSISTANT` 设为 `true`。  
> 详细说明见 [Docker 部署指南](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南)。

</details>

<details>
<summary><b>方式三：从源码编译</b></summary>

#### 前置：安装 uv

<table><tr><td>

**Linux / macOS**

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

</td><td>

**Windows（窗口）**
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

## 📖 文档

- [快速开始](https://github.com/TwooSix/Openlist-Ani/wiki/快速开始)
- [PIP 安装指南](https://github.com/TwooSix/Openlist-Ani/wiki/PIP安装指南)
- [Docker 部署指南](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南)
- [源码编译指南](https://github.com/TwooSix/Openlist-Ani/wiki/源码编译指南)
- [配置说明](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

## 🖼️ 效果展示

| 重命名结果 | 智能助理 |
| :---: | :---: |
| <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic1.png" width="400"/> | <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic2.jpg" width="150"/> |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---