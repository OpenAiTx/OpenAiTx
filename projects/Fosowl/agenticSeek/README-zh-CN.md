# AgenticSeek：本地私有的 Manus 替代方案

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*一个**100% 本地化的 Manus AI 替代方案**，此语音驱动的 AI 助手可自主浏览网页、编写代码、规划任务，所有数据都保存在您的设备上。为本地推理模型量身定制，完全在您的硬件上运行，确保数据隐私，无需依赖云端。*

[![访问 AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### 为什么选择 AgenticSeek？

* 🔒 完全本地&私有 —— 所有内容在您的计算机上运行，无云端、无数据共享。您的文件、对话和搜索都保持私密。

* 🌐 智能网页浏览 —— AgenticSeek 能自主上网搜索、阅读、提取信息、填写网页表单，全程免手动操作。

* 💻 自主编程助手 —— 需要代码？它能编写、调试并运行 Python、C、Go、Java 等多种程序，无需人工干预。

* 🧠 智能代理选择 —— 您只需提问，它会自动选择最适合的 AI 代理处理任务，就像有一支专家团队随时待命。

* 📋 规划并执行复杂任务 —— 从行程规划到复杂项目，能将大任务拆分为步骤，利用多智能体高效完成。

* 🎙️ 语音驱动 —— 干净、快速、未来感十足的语音与语音转文字功能，让您像在科幻电影中那样与个人 AI 对话。（开发中）

### **演示**

> *你能搜索 agenticSeek 项目，了解需要哪些技能，然后打开 CV_candidates.zip，告诉我哪个最匹配该项目吗*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

免责声明：该演示及所有出现的文件（如：CV_candidates.zip）均为虚构。我们不是公司，仅寻求开源贡献者而非候选人。

> 🛠⚠️️ **项目正在积极开发中**

> 🙏 本项目起初只是一个副业项目，没有明确的路线图和资金支持。它超出了我的预期并登上了 GitHub Trending。非常感谢您的贡献、反馈与耐心。

## 前置条件

在开始之前，请确保已安装以下软件：

*   **Git：** 用于克隆仓库。[下载 Git](https://git-scm.com/downloads)
*   **Python 3.10.x：** 强烈建议使用 Python 3.10.x 版本。其他版本可能会导致依赖错误。[下载 Python 3.10](https://www.python.org/downloads/release/python-3100/)（请选择 3.10.x 版本）。
*   **Docker Engine & Docker Compose：** 用于运行如 SearxNG 等捆绑服务。
    *   安装 Docker Desktop（包含 Docker Compose V2）：[Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   或者在 Linux 上分别安装 Docker Engine 和 Docker Compose：[Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/)（请确保安装 Compose V2，例如 `sudo apt-get install docker-compose-plugin`）。

### 1. **克隆仓库并进行设置**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. 修改 .env 文件内容

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

根据需要用您自己的值更新 `.env` 文件：

- **SEARXNG_BASE_URL**：保持不变
- **REDIS_BASE_URL**：保持不变
- **WORK_DIR**：本地机器上的工作目录路径。AgenticSeek 可以读取和操作这些文件。
- **OLLAMA_PORT**：Ollama 服务端口号。
- **LM_STUDIO_PORT**：LM Studio 服务端口号。
- **CUSTOM_ADDITIONAL_LLM_PORT**：任何自定义 LLM 服务的端口号。

**API Key 完全可选，针对选择本地运行 LLM 的用户。该项目的主要目标即为此。如果硬件足够请留空。**

### 3. **启动 Docker**

确保您的系统已安装并运行 Docker。可用以下命令启动 Docker：

- **在 Linux/macOS 上：**
    打开终端并运行：
    ```sh
    sudo systemctl start docker
    ```
    或者在应用程序菜单中启动 Docker Desktop（如已安装）。

- **在 Windows 上：**
    从开始菜单启动 Docker Desktop。

可通过以下命令验证 Docker 是否运行：
```sh
docker info
```
如果显示有关 Docker 安装的信息，则说明运行正常。

本地提供商的汇总见下表 [Local Providers](#list-of-local-providers)。

下一步：[本地运行 AgenticSeek](#start-services-and-run)

*如遇问题，请参阅 [故障排查](#troubleshooting) 部分。*
*如您的硬件无法本地运行 LLM，请参考 [API 运行设置](#setup-to-run-with-an-api)。*
*如需详细 `config.ini` 配置说明，请参见 [Config Section](#config)。*

---

## 本地运行 LLM 设置

**硬件要求：**

如需本地运行 LLM，需具备足够的硬件资源。最低需有可运行 Magistral、Qwen 或 Deepseek 14B 的 GPU。详细的模型/性能建议请参见 FAQ。

**设置本地提供商**

启动本地提供商，例如使用 ollama：

```sh
ollama serve
```

下方列出本地支持的提供商。

**更新 config.ini**

修改 config.ini，将 provider_name 设置为受支持的提供商，将 provider_model 设置为该提供商支持的 LLM。推荐推理模型如 *Magistral* 或 *Deepseek*。

所需硬件请参考 README 最后的 **FAQ**。

```sh
[MAIN]
is_local = True # 是否本地运行，或使用远程提供商
provider_name = ollama # 或 lm-studio、openai 等
provider_model = deepseek-r1:14b # 选择适合硬件的模型
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # AI 名称
recover_last_session = True # 是否恢复上次会话
save_session = True # 是否记住当前会话
speak = False # 文本转语音
listen = False # 语音转文本，仅 CLI，实验性
jarvis_personality = False # 是否使用更“Jarvis”风格的个性（实验性）
languages = en zh # 支持的语言列表，TTS 默认使用第一个
[BROWSER]
headless_browser = True # 除非在主机 CLI 使用，否则保持不变
stealth_mode = True # 使用 undetected selenium 降低被浏览器检测的概率
```

**注意事项**：

- `config.ini` 文件格式不支持注释。
请勿直接复制示例配置中的注释，否则会报错。请手动根据需求修改 `config.ini`，并去除所有注释。

- 如使用 LM-studio 本地运行 LLM，不要将 provider_name 设置为 `openai`，请设为 `lm-studio`。

- 某些提供商（如 lm-studio）需要在 IP 前加 `http://`，如 `http://127.0.0.1:1234`

**本地提供商列表**

| 提供商    | 本地？ | 描述                                                    |
|-----------|--------|---------------------------------------------------------|
| ollama    | 是     | 通过 ollama 作为 LLM 提供商，轻松本地运行 LLM           |
| lm-studio | 是     | 使用 LM studio 本地运行 LLM（`provider_name` 设为 `lm-studio`）|
| openai    | 是     | 使用 openai 兼容 API（如 llama.cpp server）             |

下一步：[启动服务并运行 AgenticSeek](#Start-services-and-Run)

*如遇问题，请参阅 [故障排查](#troubleshooting) 部分。*
*如您的硬件无法本地运行 LLM，请参考 [API 运行设置](#setup-to-run-with-an-api)。*
*如需详细 `config.ini` 配置说明，请参见 [Config Section](#config)。*

## 使用 API 运行设置

此方式使用外部云端 LLM 提供商。您需要从所选服务获取 API key。

**1. 选择 API 提供商并获取 API Key：**

参见下方 [API 提供商列表](#list-of-api-providers)。访问其官网注册并获得 API key。

**2. 将 API Key 设为环境变量：**

*   **Linux/macOS:**
    打开终端，使用 `export` 命令。建议添加到 shell 配置文件（如 `~/.bashrc`、`~/.zshrc`）以便持久生效。
    ```sh
    export PROVIDER_API_KEY="your_api_key_here"
    # 将 PROVIDER_API_KEY 替换为具体变量名，如 OPENAI_API_KEY、GOOGLE_API_KEY
    ```
    TogetherAI 示例：
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **命令提示符（当前会话临时生效）：**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell（当前会话临时生效）：**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **永久生效：** 在 Windows 搜索栏中搜索“环境变量”，点击“编辑系统环境变量”，然后点击“环境变量...”按钮。添加一个新的用户变量，名称为相应的变量名（如 `OPENAI_API_KEY`），值为你的密钥。

*（详见常见问题：[如何设置 API 密钥？](#how-do-i-set-api-keys)）*


**3. 更新 `config.ini`：**
```ini
[MAIN]
is_local = False
provider_name = openai # 或 google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # 或 gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 等
provider_server_address = # 当 is_local = False 时通常忽略或可留空，大多数 API 均如此
# ... 其他设置 ...
```
*警告：* 请确保 `config.ini` 的值中没有尾随空格。

**API 提供商列表**

| 提供商        | `provider_name` | 本地？ | 描述                                             | API 密钥链接（示例）                           |
|---------------|-----------------|--------|--------------------------------------------------|-----------------------------------------------|
| OpenAI        | `openai`        | 否     | 通过 OpenAI 的 API 使用 ChatGPT 模型。            | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini | `google`        | 否     | 通过 Google AI Studio 使用 Google Gemini 模型。   | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek      | `deepseek`      | 否     | 通过 Deepseek 的 API 使用 Deepseek 模型。         | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face  | `huggingface`   | 否     | 通过 Hugging Face Inference API 使用模型。        | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI    | `togetherAI`    | 否     | 通过 TogetherAI API 使用多种开源模型。            | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*注意：*
*   我们不建议在复杂网页浏览和任务规划场景下使用 `gpt-4o` 或其他 OpenAI 模型，因为当前的提示词优化主要面向 Deepseek 等模型。
*   在编码/bash 任务中，Gemini 可能无法严格遵循为 Deepseek 优化的格式化提示，可能会出现问题。
*   当 `is_local = False` 时，`config.ini` 中的 `provider_server_address` 一般不会被使用，因为各提供商库中通常已硬编码了 API 端点。

下一步：[启动服务并运行 AgenticSeek](#Start-services-and-Run)

*如遇问题请参见 **已知问题** 部分*

*详细配置文件说明请参见 **Config** 部分。*

---

## 启动服务并运行

默认情况下，AgenticSeek 完全在 Docker 中运行。

启动所需服务。这将启动 docker-compose.yml 中的所有服务，包括：
   - searxng
   - redis（searxng 需要）
   - 前端
   - 后端（如使用 `full`）

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**警告：** 此步骤将下载并加载所有 Docker 镜像，可能需要长达 30 分钟。启动服务后，请等待后端服务完全运行（你应该在日志中看到 **backend: "GET /health HTTP/1.1" 200 OK**）再发送任何消息。首次运行时后端服务可能需要 5 分钟启动。

访问 `http://localhost:3000/`，你应该可以看到 Web 界面。

*服务启动故障排查：* 如脚本启动失败，请确保 Docker Engine 已运行且 Docker Compose（V2，`docker compose`）已正确安装。检查终端输出的错误信息。参见 [常见问题：运行 AgenticSeek 或其脚本时报错怎么办？](#faq-troubleshooting)

**可选：** 在主机上运行（CLI 模式）：

如需用 CLI 界面运行，需要在主机上安装依赖包：

```sh
./install.sh
./install.bat # windows
```

启动服务：

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

使用 CLI：`python3 cli.py`


---

## 使用方法

请确保服务已通过 `./start_services.sh full` 启动，并访问 `localhost:3000` 打开 Web 界面。

你还可以通过在配置中设置 `listen = True` 启用语音转文字功能，仅限 CLI 模式。

退出时，只需说或输入 `goodbye`。

以下是一些使用示例：

> *用 python 制作一个贪吃蛇游戏！*

> *在网上搜索法国雷恩（Rennes）排名前列的咖啡馆，并保存其中三家的名称和地址到 rennes_cafes.txt 文件。*

> *写一个 Go 程序计算一个数的阶乘，将其保存为 workspace 目录下的 factorial.go*

> *在 summer_pictures 文件夹中查找所有 JPG 文件，用今天的日期重命名，并将重命名后的文件列表保存到 photos_list.txt*

> *在线搜索 2024 年流行的科幻电影，挑选三部今晚观看。将名单保存到 movie_night.txt。*

> *在网上搜索 2025 年最新 AI 新闻文章，选择三篇，用 Python 脚本抓取它们的标题和摘要。将脚本保存为 news_scraper.py，摘要保存到 /home/projects 下的 ai_news.txt*

> *周五，在网上搜索免费股票价格 API，用 supersuper7434567@gmail.com 注册账号，然后写一个 Python 脚本，利用该 API 获取特斯拉每天的股价，并将结果保存为 stock_prices.csv*

*请注意，自动表单填写功能仍处于实验阶段，可能会失败。*


当你输入查询后，AgenticSeek 会为任务分配最佳代理。

由于目前为早期原型，代理路由系统可能不会始终根据你的查询分配最合适的代理。

因此，你应尽量明确表达需求，并说明 AI 应如何操作。例如，如果希望它进行网页搜索，不要说：

`你知道哪些适合单人旅行的好国家吗？`

而应这样问：

`请进行网页搜索，找出最适合单人旅行的国家`

---

## **配置在你自己的服务器上运行 LLM**  

如果你有一台高性能电脑或服务器，希望从笔记本远程使用它，可以选择用我们的自定义 llm server 在远程服务器上运行 LLM。

在将运行 AI 模型的“服务器”上，获取 IP 地址

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # 本地 IP
curl https://ipinfo.io/ip # 公网 IP
```

注意：Windows 或 macOS 请分别用 ipconfig 或 ifconfig 查询 IP 地址。

克隆仓库并进入 `server/` 文件夹。

```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

安装服务器端依赖：

```sh
pip3 install -r requirements.txt
```

运行服务器脚本。

```sh
python3 app.py --provider ollama --port 3333
```

你可以选择用 `ollama` 或 `llamacpp` 作为 LLM 服务。

现在在你的个人电脑上：

修改 `config.ini`，将 `provider_name` 设为 `server`，`provider_model` 设为 `deepseek-r1:xxb`。
把 `provider_server_address` 设置为运行模型机器的 IP 地址。

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


下一步：[启动服务并运行 AgenticSeek](#Start-services-and-Run)  

---

## 语音转文字

警告：语音转文字目前仅支持 CLI 模式。

请注意，语音转文字目前仅支持英文。

语音转文字功能默认关闭。要启用，请在 config.ini 文件中设置 listen 选项为 True：

```
listen = True
```

启用后，语音转文字功能会在你说出触发关键词（即代理名称）后开始处理输入。你可以通过修改 *config.ini* 文件中的 `agent_name` 值来自定义代理名称：

```
agent_name = Friday
```

为了获得最佳识别效果，我们建议使用常见的英文名字作为代理名称，如 "John" 或 "Emma"。

当你看到转录文本开始出现时，大声说出代理的名字以唤醒它（例如，“Friday”）。

请清晰地表达你的请求。

在请求结束时，用确认短语作为信号提示系统继续。确认短语示例包括：
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## 配置

配置示例:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Ollama 示例；LM-Studio 请用 http://127.0.0.1:1234
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # 用于TTS及可能的路由的语言列表。
[BROWSER]
headless_browser = False
stealth_mode = False
```

**`config.ini` 配置项说明**:

*   **`[MAIN]` 部分:**
    *   `is_local`: 若使用本地LLM服务（Ollama、LM-Studio、本地OpenAI兼容服务器）或自托管服务器选项，设为 `True`。若使用云端API（OpenAI、Google等），设为 `False`。
    *   `provider_name`: 指定LLM服务提供商。
        *   本地选项：`ollama`、`lm-studio`、`openai`（本地OpenAI兼容服务器）、`server`（自托管服务器）。
        *   API选项：`openai`、`google`、`deepseek`、`huggingface`、`togetherAI`。
    *   `provider_model`: 选定服务商的具体模型名称或ID（如 Ollama 的 `deepseekcoder:6.7b`，OpenAI API 的 `gpt-3.5-turbo`，TogetherAI 的 `mistralai/Mixtral-8x7B-Instruct-v0.1`）。
    *   `provider_server_address`: 你的LLM服务提供商地址。
        *   本地服务示例：Ollama 用 `http://127.0.0.1:11434`，LM-Studio 用 `http://127.0.0.1:1234`。
        *   `server` 类型：自托管LLM服务器地址（如 `http://your_server_ip:3333`）。
        *   云端API（`is_local = False`）：通常忽略或留空，因为API端点通常由客户端库处理。
    *   `agent_name`: AI助手名称（如 Friday）。在启用语音转文本时用作唤醒词。
    *   `recover_last_session`: 设为 `True` 时尝试恢复上次会话状态，设为 `False` 时重新开始。
    *   `save_session`: 设为 `True` 保存当前会话以便恢复，否则为 `False`。
    *   `speak`: 设为 `True` 启用文字转语音输出，设为 `False` 关闭。
    *   `listen`: 设为 `True` 启用语音转文本输入（仅CLI模式），设为 `False` 关闭。
    *   `work_dir`: **重要：** AgenticSeek 读写文件的目录。**请确保该路径在你的系统中有效且可访问。**
    *   `jarvis_personality`: 设为 `True` 使用更“Jarvis风格”的系统提示（实验性），设为 `False` 使用标准提示。
    *   `languages`: 逗号分隔的语言列表（如 `en, zh, fr`）。用于TTS语音选择（默认第一项），也可辅助LLM路由。为提高效率，请勿设置过多或过于相似的语言。
*   **`[BROWSER]` 部分:**
    *   `headless_browser`: 设为 `True` 以无界面方式运行自动化浏览器（推荐用于网页界面或非交互场景）；设为 `False` 显示浏览器窗口（适合CLI模式或调试）。
    *   `stealth_mode`: 设为 `True` 启用反检测措施，使浏览器自动化更难被检测。可能需要手动安装诸如 anticaptcha 等浏览器扩展。

本节总结了支持的LLM服务类型。请在 `config.ini` 中进行配置。

**本地服务（在你自己的硬件上运行）:**

| `config.ini` 配置名称          | `is_local` | 描述                                                                         | 配置章节                                                        |
|-------------------------------|------------|------------------------------------------------------------------------------|------------------------------------------------------------------|
| `ollama`                      | `True`     | 使用 Ollama 提供本地LLM服务。                                                | [本地LLM运行配置](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | 使用 LM-Studio 提供本地LLM服务。                                             | [本地LLM运行配置](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (本地服务器)         | `True`     | 连接本地OpenAI兼容API服务器（如 llama.cpp）。                                 | [本地LLM运行配置](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | 连接运行在其他机器上的 AgenticSeek 自托管LLM服务器。                         | [自托管LLM服务器配置](#setup-to-run-the-llm-on-your-own-server)   |

**API服务（云端）:**

| `config.ini` 配置名称          | `is_local` | 描述                                       | 配置章节                                        |
|-------------------------------|------------|---------------------------------------------|-------------------------------------------------|
| `openai`                      | `False`    | 使用OpenAI官方API（如 GPT-3.5、GPT-4）。    | [API运行配置](#setup-to-run-with-an-api)         |
| `google`                      | `False`    | 通过API使用Google Gemini模型。              | [API运行配置](#setup-to-run-with-an-api)         |
| `deepseek`                    | `False`    | 使用Deepseek官方API。                       | [API运行配置](#setup-to-run-with-an-api)         |
| `huggingface`                 | `False`    | 使用 Hugging Face 推理API。                 | [API运行配置](#setup-to-run-with-an-api)         |
| `togetherAI`                  | `False`    | 使用 TogetherAI 的多种开源模型API。         | [API运行配置](#setup-to-run-with-an-api)         |

---
## 故障排查

遇到问题时，本节将为你提供指导。

# 已知问题

## ChromeDriver 问题

**错误示例:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **原因:** 你安装的 ChromeDriver 版本与 Google Chrome 浏览器版本不兼容。
*   **解决办法:**
    1.  **检查 Chrome 版本:** 打开 Google Chrome，进入 `设置 > 关于 Chrome` 查看版本号（如 "Version 120.0.6099.110"）。
    2.  **下载匹配的 ChromeDriver:**
        *   Chrome 115及以上版本：访问 [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/)。找到 “stable” 渠道，下载与你的Chrome主版本号对应的ChromeDriver。
        *   旧版本（较少见）：可在 [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads) 页面查找。
        *   下图为 CfT 页面示例：
            ![从Chrome for Testing页面下载特定版本Chromedriver](./media/chromedriver_readme.png)
    3.  **安装 ChromeDriver:**
        *   确保下载的 `chromedriver`（Windows 下为 `chromedriver.exe`）放在系统PATH环境变量指定的目录下（如 Linux/macOS的 `/usr/local/bin`，或Windows下已加入PATH的脚本文件夹）。
        *   或将其放在 `agenticSeek` 项目的根目录下。
        *   确保驱动为可执行文件（Linux/macOS下可用 `chmod +x chromedriver`）。
    4.  更多信息请参考主安装指南的 [ChromeDriver 安装](#chromedriver-installation) 部分。

如果本节内容不完整或遇到其他ChromeDriver问题，请搜索现有 [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) 或新建Issue反馈。

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

如浏览器与chromedriver版本不匹配，会出现此类问题。

你需要前往以下链接下载最新版：

https://developer.chrome.com/docs/chromedriver/downloads

如使用的是 Chrome 115及以上版本，请访问：

https://googlechromelabs.github.io/chrome-for-testing/

并下载与你操作系统匹配的chromedriver版本。

![alt text](./media/chromedriver_readme.png)

如本节内容不完整请提交Issue。

## 连接适配器问题

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (注意：端口可能不同)
```

*   **原因:** `config.ini` 中 `lm-studio`（或其他本地OpenAI兼容服务器）的 `provider_server_address` 缺少 `http://` 前缀或指向了错误的端口。
*   **解决办法:**
    *   确保地址包含 `http://`。LM-Studio 通常默认为 `http://127.0.0.1:1234`。
    *   正确的 `config.ini` 配置：`provider_server_address = http://127.0.0.1:1234`（或你实际的LM-Studio服务器端口）。

## 未提供 SearxNG 基础URL

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## 常见问题

**Q: 我需要什么硬件？**  

| 模型规模  | GPU  | 说明                                                |
|-----------|--------|------------------------------------------------------|
| 7B        | 8GB 显存 | ⚠️ 不推荐。性能差，易产生幻觉，规划型Agent可能失败。 |
| 14B       | 12GB 显存（如RTX 3060） | ✅ 可用于简单任务。网页浏览和计划任务可能有困难。|
| 32B       | 24GB+ 显存（如RTX 4090） | 🚀 大部分任务表现良好，但复杂规划仍有挑战。    |
| 70B+      | 48GB+ 显存 | 💪 优秀，推荐用于高阶场景。                       |

**Q: 出现错误怎么办？**  

确保本地服务已启动（如执行 `ollama serve`），`config.ini` 配置与你的服务商一致，且依赖项已安装。如仍有问题欢迎提交Issue反馈。

**Q: 真能100%本地运行吗？**  

是的。配合 Ollama、lm-studio 或 server 服务，所有语音转文本、LLM与TTS模型都可本地运行。非本地选项（如OpenAI等API）为可选。

**Q: 我有 Manus，为什么还要用 AgenticSeek？**

AgenticSeek 以不依赖外部系统为设计重点，给予你更多控制权、隐私和避免API费用。

**Q: 项目背后是谁？**

本项目由我和两位朋友共同发起与维护，均来自GitHub开源社区。我们只是热爱技术的个人，并非创业公司或任何组织成员。

除我的个人账号（https://x.com/Martin993886460）外，任何自称AgenticSeek的X账号都是冒充。

## 参与贡献

欢迎开发者参与改进AgenticSeek！请查看开放Issue或讨论区。

[贡献指南](./docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## 维护者:

 > [Fosowl](https://github.com/Fosowl) | 巴黎时间 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | 台北时间 

 > [steveh8758](https://github.com/steveh8758) | 台北时间 

## 特别感谢:

 > [tcsenpai](https://github.com/tcsenpai) 和 [plitc](https://github.com/plitc) 协助后端docker化

## 赞助者:

每月赞助5美元及以上将在此处展示：
- **tatra-labs**

Certainly! Please provide the content of Part 4 of 4 for translation.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---