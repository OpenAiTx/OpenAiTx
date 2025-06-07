<div align="center">
  <a href="https://ollama.com">
    <img alt="ollama" height="200px" src="https://github.com/ollama/ollama/assets/3325447/0d0b44e2-8f4a-4e99-9b52-a5c1c741c8f7">
  </a>
</div>

# Ollama

快速上手大语言模型。

### macOS

[下载](https://ollama.com/download/Ollama-darwin.zip)

### Windows

[下载](https://ollama.com/download/OllamaSetup.exe)

### Linux

```shell
curl -fsSL https://ollama.com/install.sh | sh
```

[手动安装说明](https://github.com/ollama/ollama/blob/main/docs/linux.md)

### Docker

官方 [Ollama Docker 镜像](https://hub.docker.com/r/ollama/ollama) `ollama/ollama` 已发布在 Docker Hub。

### 库

- [ollama-python](https://github.com/ollama/ollama-python)
- [ollama-js](https://github.com/ollama/ollama-js)

### 社区

- [Discord](https://discord.gg/ollama)
- [Reddit](https://reddit.com/r/ollama)

## 快速开始

运行并与 [Llama 3.2](https://ollama.com/library/llama3.2) 聊天：

```shell
ollama run llama3.2
```

## 模型库

Ollama 支持 [ollama.com/library](https://ollama.com/library 'ollama model library') 上的众多模型。

以下是部分可下载的示例模型：

| 模型名称           | 参数量     | 大小   | 下载命令                             |
| ------------------ | ---------- | ------ | ------------------------------------ |
| Gemma 3            | 1B         | 815MB  | `ollama run gemma3:1b`               |
| Gemma 3            | 4B         | 3.3GB  | `ollama run gemma3`                  |
| Gemma 3            | 12B        | 8.1GB  | `ollama run gemma3:12b`              |
| Gemma 3            | 27B        | 17GB   | `ollama run gemma3:27b`              |
| QwQ                | 32B        | 20GB   | `ollama run qwq`                     |
| DeepSeek-R1        | 7B         | 4.7GB  | `ollama run deepseek-r1`             |
| DeepSeek-R1        | 671B       | 404GB  | `ollama run deepseek-r1:671b`        |
| Llama 4            | 109B       | 67GB   | `ollama run llama4:scout`            |
| Llama 4            | 400B       | 245GB  | `ollama run llama4:maverick`         |
| Llama 3.3          | 70B        | 43GB   | `ollama run llama3.3`                |
| Llama 3.2          | 3B         | 2.0GB  | `ollama run llama3.2`                |
| Llama 3.2          | 1B         | 1.3GB  | `ollama run llama3.2:1b`             |
| Llama 3.2 Vision   | 11B        | 7.9GB  | `ollama run llama3.2-vision`         |
| Llama 3.2 Vision   | 90B        | 55GB   | `ollama run llama3.2-vision:90b`     |
| Llama 3.1          | 8B         | 4.7GB  | `ollama run llama3.1`                |
| Llama 3.1          | 405B       | 231GB  | `ollama run llama3.1:405b`           |
| Phi 4              | 14B        | 9.1GB  | `ollama run phi4`                    |
| Phi 4 Mini         | 3.8B       | 2.5GB  | `ollama run phi4-mini`               |
| Mistral            | 7B         | 4.1GB  | `ollama run mistral`                 |
| Moondream 2        | 1.4B       | 829MB  | `ollama run moondream`               |
| Neural Chat        | 7B         | 4.1GB  | `ollama run neural-chat`             |
| Starling           | 7B         | 4.1GB  | `ollama run starling-lm`             |
| Code Llama         | 7B         | 3.8GB  | `ollama run codellama`               |
| Llama 2 Uncensored | 7B         | 3.8GB  | `ollama run llama2-uncensored`       |
| LLaVA              | 7B         | 4.5GB  | `ollama run llava`                   |
| Granite-3.3         | 8B         | 4.9GB  | `ollama run granite3.3`              |

> [!NOTE]
> 运行 7B 模型至少需要 8 GB 内存，运行 13B 模型需要 16 GB，运行 33B 模型需要 32 GB 内存。

## 自定义模型

### 从 GGUF 导入

Ollama 支持在 Modelfile 中导入 GGUF 格式模型：

1. 新建名为 `Modelfile` 的文件，并使用 `FROM` 指令指定要导入的本地模型文件路径。

   ```
   FROM ./vicuna-33b.Q4_0.gguf
   ```

2. 在 Ollama 中创建模型

   ```shell
   ollama create example -f Modelfile
   ```

3. 运行模型

   ```shell
   ollama run example
   ```

### 从 Safetensors 导入

更多导入模型信息请参阅[指南](docs/import.md)。

### 自定义提示词

Ollama 库中的模型可通过 prompt 进行自定义。例如，自定义 `llama3.2` 模型：

```shell
ollama pull llama3.2
```

创建 `Modelfile`：

```
FROM llama3.2

# 设置 temperature 为 1 [值越高越有创造力，值越低越连贯]
PARAMETER temperature 1

# 设置系统消息
SYSTEM """
你是超级马里奥中的马里奥。仅以助手马里奥的身份回答。
"""
```

然后创建并运行模型：

```
ollama create mario -f ./Modelfile
ollama run mario
>>> hi
Hello! It's your friend Mario.
```

关于 Modelfile 的更多用法，请参阅 [Modelfile](docs/modelfile.md) 文档。

## CLI 参考

### 创建模型

`ollama create` 用于从 Modelfile 创建模型。

```shell
ollama create mymodel -f ./Modelfile
```

### 拉取模型

```shell
ollama pull llama3.2
```

> 该命令也可用于更新本地模型。只会拉取差异部分。

### 删除模型

```shell
ollama rm llama3.2
```

### 复制模型

```shell
ollama cp llama3.2 my-model
```

### 多行输入

对于多行输入，可使用 `"""` 包裹文本：

```
>>> """Hello,
... world!
... """
我是一个基本程序，会在控制台输出著名的 "Hello, world!" 信息。
```

### 多模态模型

```
ollama run llava "What's in this image? /Users/jmorgan/Desktop/smile.png"
```

> **输出**：图片中有一个黄色笑脸，这可能是图片的核心内容。

### 作为参数传递 prompt

```shell
ollama run llama3.2 "Summarize this file: $(cat README.md)"
```

> **输出**：Ollama 是一个轻量级、可扩展的本地大语言模型构建和运行框架。它提供了简单的 API 用于模型的创建、运行和管理，并包含了丰富的预置模型库，方便在多种应用中使用。

### 显示模型信息

```shell
ollama show llama3.2
```

### 列出本机模型

```shell
ollama list
```

### 列出当前已加载的模型

```shell
ollama ps
```

### 停止正在运行的模型

```shell
ollama stop llama3.2
```

### 启动 Ollama

`ollama serve` 用于在不运行桌面应用时启动 Ollama 服务。

## 构建

参见 [开发者指南](https://github.com/ollama/ollama/blob/main/docs/development.md)

### 本地构建运行

首先，启动服务端：

```shell
./ollama serve
```

然后，在另一个终端窗口运行模型：

```shell
./ollama run llama3.2
```

## REST API

Ollama 提供 REST API 用于模型的运行和管理。

### 生成回复

```shell
curl http://localhost:11434/api/generate -d '{
  "model": "llama3.2",
  "prompt":"Why is the sky blue?"
}'
```

### 聊天接口

```shell
curl http://localhost:11434/api/chat -d '{
  "model": "llama3.2",
  "messages": [
    { "role": "user", "content": "why is the sky blue?" }
  ]
}'
```

所有接口请参见 [API 文档](./docs/api.md)。

## 社区集成

### Web & 桌面端

- [Open WebUI](https://github.com/open-webui/open-webui)
- [SwiftChat (macOS with ReactNative)](https://github.com/aws-samples/swift-chat)
- [Enchanted (macOS 原生)](https://github.com/AugustDev/enchanted)
- [Hollama](https://github.com/fmaclen/hollama)
- [Lollms-Webui](https://github.com/ParisNeo/lollms-webui)
- [LibreChat](https://github.com/danny-avila/LibreChat)
- [Bionic GPT](https://github.com/bionic-gpt/bionic-gpt)
- [HTML UI](https://github.com/rtcfirefly/ollama-ui)
- [Saddle](https://github.com/jikkuatwork/saddle)
- [TagSpaces](https://www.tagspaces.org)（文件型应用平台，[集成 Ollama 进行标签和描述生成](https://docs.tagspaces.org/ai/)）
- [Chatbot UI](https://github.com/ivanfioravanti/chatbot-ollama)
- [Chatbot UI v2](https://github.com/mckaywrigley/chatbot-ui)
- [Typescript UI](https://github.com/ollama-interface/Ollama-Gui?tab=readme-ov-file)
- [Minimalistic React UI for Ollama Models](https://github.com/richawo/minimal-llm-ui)
- [Ollamac](https://github.com/kevinhermawan/Ollamac)
- [big-AGI](https://github.com/enricoros/big-AGI)
- [Cheshire Cat assistant framework](https://github.com/cheshire-cat-ai/core)
- [Amica](https://github.com/semperai/amica)
- [chatd](https://github.com/BruceMacD/chatd)
- [Ollama-SwiftUI](https://github.com/kghandour/Ollama-SwiftUI)
- [Dify.AI](https://github.com/langgenius/dify)
- [MindMac](https://mindmac.app)
- [NextJS Web Interface for Ollama](https://github.com/jakobhoeg/nextjs-ollama-llm-ui)
- [Msty](https://msty.app)
- [Chatbox](https://github.com/Bin-Huang/Chatbox)
- [WinForm Ollama Copilot](https://github.com/tgraupmann/WinForm_Ollama_Copilot)
- [NextChat](https://github.com/ChatGPTNextWeb/ChatGPT-Next-Web)（[入门文档](https://docs.nextchat.dev/models/ollama)）
- [Alpaca WebUI](https://github.com/mmo80/alpaca-webui)
- [OllamaGUI](https://github.com/enoch1118/ollamaGUI)
- [OpenAOE](https://github.com/InternLM/OpenAOE)
- [Odin Runes](https://github.com/leonid20000/OdinRunes)
- [LLM-X](https://github.com/mrdjohnson/llm-x)（渐进式 Web App）
- [AnythingLLM (Docker + MacOs/Windows/Linux 原生应用)](https://github.com/Mintplex-Labs/anything-llm)
- [Ollama Basic Chat: Uses HyperDiv Reactive UI](https://github.com/rapidarchitect/ollama_basic_chat)
- [Ollama-chats RPG](https://github.com/drazdra/ollama-chats)
- [IntelliBar](https://intellibar.app/)（macOS AI 助手）
- [Jirapt](https://github.com/AliAhmedNada/jirapt)（Jira 集成，自动生成 issue、task、epic）
- [ojira](https://github.com/AliAhmedNada/ojira)（Jira Chrome 插件，便捷生成任务描述）
- [QA-Pilot](https://github.com/reid41/QA-Pilot)（可利用 Ollama 模型快速理解和导航 GitHub 代码库的交互式聊天工具）
- [ChatOllama](https://github.com/sugarforever/chat-ollama)（基于 Ollama 的开源知识库聊天机器人）
- [CRAG Ollama Chat](https://github.com/Nagi-ovo/CRAG-Ollama-Chat)（带纠错 RAG 的简单网页搜索）
- [RAGFlow](https://github.com/infiniflow/ragflow)（基于深度文档理解的开源 RAG 引擎）
- [StreamDeploy](https://github.com/StreamDeploy-DevRel/streamdeploy-llm-app-scaffold)（LLM 应用脚手架）
- [chat](https://github.com/swuecho/chat)（团队聊天 web 应用）
- [Lobe Chat](https://github.com/lobehub/lobe-chat)（[集成文档](https://lobehub.com/docs/self-hosting/examples/ollama)）
- [Ollama RAG Chatbot](https://github.com/datvodinh/rag-chatbot.git)（本地多 PDF 聊天，集成 Ollama 和 RAG）
- [BrainSoup](https://www.nurgo-software.com/products/brainsoup)（灵活原生客户端，支持 RAG 和多智能体自动化）
- [macai](https://github.com/Renset/macai)（Ollama、ChatGPT 及其他 API 后端 macOS 客户端）
- [RWKV-Runner](https://github.com/josStorer/RWKV-Runner)（RWKV 离线 LLM 部署工具，也支持 ChatGPT 和 Ollama 客户端）
- [Ollama Grid Search](https://github.com/dezoito/ollama-grid-search)（模型评测与对比应用）
- [Olpaka](https://github.com/Otacon/olpaka)（易用 Flutter Web 应用）
- [Casibase](https://casibase.org)（集成最新 RAG、SSO、Ollama 支持和多大语言模型的开源知识库和对话系统）
- [OllamaSpring](https://github.com/CrazyNeil/OllamaSpring)（macOS 客户端）
- [LLocal.in](https://github.com/kartikm7/llocal)（易用的 Electron 桌面客户端）
- [Shinkai Desktop](https://github.com/dcSpark/shinkai-apps)（两步本地 AI 安装，含 Ollama + 文件 + RAG）
- [AiLama](https://github.com/zeyoyt/ailama)（Discord 用户应用，随时在 Discord 与 Ollama 互动）
- [Ollama with Google Mesop](https://github.com/rapidarchitect/ollama_mesop/)（Mesop 聊天客户端）
- [R2R](https://github.com/SciPhi-AI/R2R)（开源 RAG 引擎）
- [Ollama-Kis](https://github.com/elearningshow/ollama-kis)（简单易用 GUI，含定制驾驶员教育 LLM 示例）
- [OpenGPA](https://opengpa.org)（开源、离线优先的企业级智能应用）
- [Painting Droid](https://github.com/mateuszmigas/painting-droid)（集成 AI 的绘画应用）
- [Kerlig AI](https://www.kerlig.com/)（macOS AI 写作助手）
- [AI Studio](https://github.com/MindWorkAI/AI-Studio)
- [Sidellama](https://github.com/gyopak/sidellama)（基于浏览器的 LLM 客户端）
- [LLMStack](https://github.com/trypromptly/LLMStack)（零代码多智能体框架）
- [BoltAI for Mac](https://boltai.com)（Mac AI 聊天客户端）
- [Harbor](https://github.com/av/harbor)（容器化 LLM 工具包，默认 Ollama 后端）
- [PyGPT](https://github.com/szczyglis-dev/py-gpt)（Linux/Windows/Mac AI 桌面助手）
- [Alpaca](https://github.com/Jeffser/Alpaca)（Linux/macOS 客户端，GTK4+Adwaita）
- [AutoGPT](https://github.com/Significant-Gravitas/AutoGPT/blob/master/docs/content/platform/ollama.md)（AutoGPT 集成 Ollama）
- [Go-CREW](https://www.jonathanhecl.com/go-crew/)（Go 实现的强大离线 RAG）
- [PartCAD](https://github.com/openvmp/partcad/)（支持 OpenSCAD 和 CadQuery 的 CAD 模型生成）
- [Ollama4j Web UI](https://github.com/ollama4j/ollama4j-web-ui) - 基于 Java 的 Web UI，使用 Vaadin、Spring Boot 和 Ollama4j
- [PyOllaMx](https://github.com/kspviswa/pyOllaMx) - 支持与 Ollama 和 Apple MLX 聊天的 macOS 应用
- [Cline](https://github.com/cline/cline) - VSCode 多文件/全库编码扩展
- [Cherry Studio](https://github.com/kangfenmao/cherry-studio)（桌面客户端，支持 Ollama）
- [ConfiChat](https://github.com/1runeberg/confichat)（轻量、独立、跨平台、隐私友好 LLM 聊天界面，支持可选加密）
- [Archyve](https://github.com/nickthecook/archyve)（启用 RAG 的文档库）
- [crewAI with Mesop](https://github.com/rapidarchitect/ollama-crew-mesop)（Mesop 界面运行 crewAI+Ollama）
- [Tkinter-based client](https://github.com/chyok/ollama-gui)（Python tkinter 客户端）
- [LLMChat](https://github.com/trendy-design/llmchat)（注重隐私，100%本地，直观 All-in-one 聊天界面）
- [Local Multimodal AI Chat](https://github.com/Leon-Sander/Local-Multimodal-AI-Chat)（支持多功能，包括 PDF RAG、语音、图片交互、OpenAI 集成）
- [ARGO](https://github.com/xark-argo/argo)（本地下载并运行 Ollama、Huggingface 模型，支持 RAG，适配多平台）
- [OrionChat](https://github.com/EliasPereirah/OrionChat) - Web 界面，多 AI 提供商聊天
- [G1](https://github.com/bklieger-groq/g1)（使用提示策略提升 LLM 推理能力的原型 app）
- [Web management](https://github.com/lemonit-eric-mao/ollama-web-management)（Web 管理页面）
- [Promptery](https://github.com/promptery/promptery)（Ollama 桌面客户端）
- [Ollama App](https://github.com/JHubi1/ollama-app)（现代易用的多平台 Ollama 客户端）
- [chat-ollama](https://github.com/annilq/chat-ollama)（React Native Ollama 客户端）
- [SpaceLlama](https://github.com/tcsenpai/spacellama)（Firefox/Chrome 扩展，侧边栏摘要网页）
- [YouLama](https://github.com/tcsenpai/youlama)（网页应用，快速摘要 YouTube，支持 Invidious）
- [DualMind](https://github.com/tcsenpai/dualmind)（实验性 app，支持终端/网页界面双模型对话）
- [ollamarama-matrix](https://github.com/h1ddenpr0cess20/ollamarama-matrix)（Matrix 聊天协议 Ollama 聊天机器人）
- [ollama-chat-app](https://github.com/anan1213095357/ollama-chat-app)（Flutter 聊天应用）
- [Perfect Memory AI](https://www.perfectmemory.ai/)（生产力 AI，个性化基于你所见所听所说）
- [Hexabot](https://github.com/hexastack/hexabot)（AI 对话机器人构建工具）
- [Reddit Rate](https://github.com/rapidarchitect/reddit_analyzer)（加权排序 Reddit 热门话题）
- [OpenTalkGpt](https://github.com/adarshM84/OpenTalkGpt)（Chrome 扩展，管理本地模型，创建自定义模型，界面聊天）
- [VT](https://github.com/vinhnx/vt.ai)（极简多模态 AI 聊天应用，动态对话路由，支持本地模型）
- [Nosia](https://github.com/nosia-ai/nosia)（易用 RAG 平台，基于 Ollama）
- [Witsy](https://github.com/nbonamy/witsy)（跨平台桌面 AI 聊天应用）
- [Abbey](https://github.com/US-Artificial-Intelligence/abbey)（可配置 AI 界面服务器，支持笔记、文档、YouTube）
- [Minima](https://github.com/dmayboroda/minima)（支持本地/自建 RAG 工作流）
- [aidful-ollama-model-delete](https://github.com/AidfulAI/aidful-ollama-model-delete)（简化模型清理的界面）
- [Perplexica](https://github.com/ItzCrazyKns/Perplexica)（AI 搜索引擎与 Perplexity AI 开源替代）
- [Ollama Chat WebUI for Docker ](https://github.com/oslook/ollama-webui)（支持本地 docker 部署，轻量 webui）
- [AI Toolkit for Visual Studio Code](https://aka.ms/ai-tooklit/ollama-docs)（微软官方 VSCode 扩展，支持聊天、测试、评估 Ollama 模型）
- [MinimalNextOllamaChat](https://github.com/anilkay/MinimalNextOllamaChat)（极简 Web 聊天与模型控制界面）
- [Chipper](https://github.com/TilmanGriesel/chipper) AI tinkerer 界面（Ollama、Haystack RAG、Python）
- [ChibiChat](https://github.com/CosmicEventHorizon/ChibiChat)（Kotlin Android Ollama/Koboldcpp 聊天 app）
- [LocalLLM](https://github.com/qusaismael/localllm)（极简 GUI 本地模型聊天）
- [Ollamazing](https://github.com/buiducnhat/ollamazing)（网页扩展，运行 Ollama 模型）
- [OpenDeepResearcher-via-searxng](https://github.com/benhaotang/OpenDeepResearcher-via-searxng)（本地运行深度研究等价端点，支持 Ollama）
- [AntSK](https://github.com/AIDotNet/AntSK)（开箱即用、可扩展 RAG 聊天机器人）
- [MaxKB](https://github.com/1Panel-dev/MaxKB/)（即用灵活的 RAG 聊天机器人）
- [yla](https://github.com/danielekp/yla)（自由互动自定义模型的 Web 界面）
- [LangBot](https://github.com/RockChinQ/LangBot)（基于 LLM 的即时通讯机器人平台，支持 Agent、RAG、多平台）
- [1Panel](https://github.com/1Panel-dev/1Panel/)（Web Linux 服务器管理工具）
- [AstrBot](https://github.com/Soulter/AstrBot/)（用户友好、支持 RAG/智能体/插件的多平台聊天机器人）
- [Reins](https://github.com/ibrahimcetin/reins)（每个聊天轻松调参，自定义系统 prompt，增强 AI 实验）
- [Flufy](https://github.com/Aharon-Bensadoun/Flufy)（React+TypeScript+Material-UI 聊天界面）
- [Ellama](https://github.com/zeozeozeo/ellama)（友好原生 Ollama 聊天 app）
- [screenpipe](https://github.com/mediar-ai/screenpipe) 构建基于屏幕历史的智能体
- [Ollamb](https://github.com/hengkysteen/ollamb)（Flutter 跨平台客户端，[Web Demo](https://hengkysteen.github.io/demo/ollamb/)）
- [Writeopia](https://github.com/Writeopia/Writeopia)（集成 Ollama 的文本编辑器）
- [AppFlowy](https://github.com/AppFlowy-IO/AppFlowy)（支持 Ollama 的协作工作区，跨平台且自托管）
- [Lumina](https://github.com/cushydigit/lumina.git)（极简 React.js Ollama 前端）
- [Tiny Notepad](https://pypi.org/project/tiny-notepad)（轻量便签式聊天界面，PyPI 可用）
- [macLlama (macOS 原生)](https://github.com/hellotunamayo/macLlama)（macOS 原生 GUI，聊天界面） 

### 云端

- [Google Cloud](https://cloud.google.com/run/docs/tutorials/gpu-gemma2-with-ollama)
- [Fly.io](https://fly.io/docs/python/do-more/add-ollama/)
- [Koyeb](https://www.koyeb.com/deploy/ollama)

### 终端

- [oterm](https://github.com/ggozad/oterm)
- [Ellama Emacs 客户端](https://github.com/s-kostyaev/ellama)
- [Emacs 客户端](https://github.com/zweifisch/ollama)
- [neollama](https://github.com/paradoxical-dev/neollama)（Neovim 内与模型交互的 UI 客户端）
- [gen.nvim](https://github.com/David-Kunz/gen.nvim)
- [ollama.nvim](https://github.com/nomnivore/ollama.nvim)
- [ollero.nvim](https://github.com/marco-souza/ollero.nvim)
- [ollama-chat.nvim](https://github.com/gerazov/ollama-chat.nvim)
- [ogpt.nvim](https://github.com/huynle/ogpt.nvim)
- [gptel Emacs 客户端](https://github.com/karthink/gptel)
- [Oatmeal](https://github.com/dustinblackman/oatmeal)
- [cmdh](https://github.com/pgibler/cmdh)
- [ooo](https://github.com/npahlfer/ooo)
- [shell-pilot](https://github.com/reid41/shell-pilot)（Linux/macOS 下纯 Shell 脚本与模型交互）
- [tenere](https://github.com/pythops/tenere)
- [llm-ollama](https://github.com/taketwo/llm-ollama)（[Datasette 的 LLM CLI](https://llm.datasette.io/en/stable/)）
- [typechat-cli](https://github.com/anaisbetts/typechat-cli)
- [ShellOracle](https://github.com/djcopley/ShellOracle)
- [tlm](https://github.com/yusufcanb/tlm)
- [podman-ollama](https://github.com/ericcurtin/podman-ollama)
- [gollama](https://github.com/sammcj/gollama)
- [ParLlama](https://github.com/paulrobello/parllama)
- [Ollama eBook Summary](https://github.com/cognitivetech/ollama-ebook-summary/)
- [Ollama Mixture of Experts (MOE) in 50 lines of code](https://github.com/rapidarchitect/ollama_moe)
- [vim-intelligence-bridge](https://github.com/pepo-ec/vim-intelligence-bridge)（简单集成 Vim 和 Ollama）
- [x-cmd ollama](https://x-cmd.com/mod/ollama)
- [bb7](https://github.com/drunkwcodes/bb7)
- [SwollamaCLI](https://github.com/marcusziade/Swollama)（Swollama Swift 包含的 CLI，[演示](https://github.com/marcusziade/Swollama?tab=readme-ov-file#cli-usage)）
- [aichat](https://github.com/sigoden/aichat)（多合一 LLM CLI，包含 Shell 助手、Chat-REPL、RAG、AI 工具/代理，支持 OpenAI、Claude、Gemini、Ollama、Groq 等）
- [PowershAI](https://github.com/rrg92/powershai)（Windows PowerShell 模块，支持 Ollama）
- [DeepShell](https://github.com/Abyss-c0re/deepshell)（自托管 AI 助手，交互 Shell、文件/文件夹分析）
- [orbiton](https://github.com/xyproto/orbiton)（零配置文本编辑器与 IDE，支持 Ollama 补全）
- [orca-cli](https://github.com/molbal/orca-cli)（Ollama 注册表 CLI 应用，浏览、拉取、下载模型）
- [GGUF-to-Ollama](https://github.com/jonathanhecl/gguf-to-ollama)（多平台 GGUF 导入 Ollama 工具）
- [AWS-Strands-With-Ollama](https://github.com/rapidarchitect/ollama_strands)（AWS Strands 智能体 Ollama 集成示例）

### Apple Vision Pro

- [SwiftChat](https://github.com/aws-samples/swift-chat)（跨平台 AI 聊天，支持 Vision Pro）
- [Enchanted](https://github.com/AugustDev/enchanted)

### 数据库

- [pgai](https://github.com/timescale/pgai) - PostgreSQL 向量数据库（使用 pgvector 调用 Ollama 生成/搜索嵌入向量）
   - [入门指南](https://github.com/timescale/pgai/blob/main/docs/vectorizer-quick-start.md)
- [MindsDB](https://github.com/mindsdb/mindsdb/blob/staging/mindsdb/integrations/handlers/ollama_handler/README.md)（将 Ollama 模型连接至近 200 个数据平台与应用）
- [chromem-go](https://github.com/philippgille/chromem-go/blob/v0.5.0/embed_ollama.go)（[示例](https://github.com/philippgille/chromem-go/tree/v0.5.0/examples/rag-wikipedia-ollama)）
- [Kangaroo](https://github.com/dbkangaroo/kangaroo)（AI 驱动的 SQL 客户端及管理工具）

### 包管理器

- [Pacman](https://archlinux.org/packages/extra/x86_64/ollama/)
- [Gentoo](https://github.com/gentoo/guru/tree/master/app-misc/ollama)
- [Homebrew](https://formulae.brew.sh/formula/ollama)
- [Helm Chart](https://artifacthub.io/packages/helm/ollama-helm/ollama)
- [Guix channel](https://codeberg.org/tusharhero/ollama-guix)
- [Nix package](https://search.nixos.org/packages?show=ollama&from=0&size=50&sort=relevance&type=packages&query=ollama)
- [Flox](https://flox.dev/blog/ollama-part-one)

### 库

- [LangChain](https://python.langchain.com/docs/integrations/chat/ollama/)、[LangChain.js](https://js.langchain.com/docs/integrations/chat/ollama/)（[示例](https://js.langchain.com/docs/tutorials/local_rag/)）
- [Firebase Genkit](https://firebase.google.com/docs/genkit/plugins/ollama)
- [crewAI](https://github.com/crewAIInc/crewAI)
- [Yacana](https://remembersoftwares.github.io/yacana/)（多智能体流程框架，内建工具集成）
- [Spring AI](https://github.com/spring-projects/spring-ai)（[参考](https://docs.spring.io/spring-ai/reference/api/chat/ollama-chat.html)、[示例](https://github.com/tzolov/ollama-tools)）
- [LangChainGo](https://github.com/tmc/langchaingo/)（[示例](https://github.com/tmc/langchaingo/tree/main/examples/ollama-completion-example)）
- [LangChain4j](https://github.com/langchain4j/langchain4j)（[示例](https://github.com/langchain4j/langchain4j-examples/tree/main/ollama-examples/src/main/java)）
- [LangChainRust](https://github.com/Abraxas-365/langchain-rust)（[示例](https://github.com/Abraxas-365/langchain-rust/blob/main/examples/llm_ollama.rs)）
- [LangChain for .NET](https://github.com/tryAGI/LangChain)（[示例](https://github.com/tryAGI/LangChain/blob/main/examples/LangChain.Samples.OpenAI/Program.cs)）
- [LLPhant](https://github.com/theodo-group/LLPhant?tab=readme-ov-file#ollama)
- [LlamaIndex](https://docs.llamaindex.ai/en/stable/examples/llm/ollama/)、[LlamaIndexTS](https://ts.llamaindex.ai/modules/llms/available_llms/ollama)
- [LiteLLM](https://github.com/BerriAI/litellm)
- [OllamaFarm for Go](https://github.com/presbrey/ollamafarm)
- [OllamaSharp for .NET](https://github.com/awaescher/OllamaSharp)
- [Ollama for Ruby](https://github.com/gbaptista/ollama-ai)
- [Ollama-rs for Rust](https://github.com/pepperoni21/ollama-rs)
- [Ollama-hpp for C++](https://github.com/jmont-dev/ollama-hpp)
- [Ollama4j for Java](https://github.com/ollama4j/ollama4j)
- [ModelFusion Typescript Library](https://modelfusion.dev/integration/model-provider/ollama)
- [OllamaKit for Swift](https://github.com/kevinhermawan/OllamaKit)
- [Ollama for Dart](https://github.com/breitburg/dart-ollama)
- [Ollama for Laravel](https://github.com/cloudstudio/ollama-laravel)
- [LangChainDart](https://github.com/davidmigloz/langchain_dart)
- [Semantic Kernel - Python](https://github.com/microsoft/semantic-kernel/tree/main/python/semantic_kernel/connectors/ai/ollama)
- [Haystack](https://github.com/deepset-ai/haystack-integrations/blob/main/integrations/ollama.md)
- [Elixir LangChain](https://github.com/brainlid/langchain)
- [Ollama for R - rollama](https://github.com/JBGruber/rollama)
- [Ollama for R - ollama-r](https://github.com/hauselin/ollama-r)
- [Ollama-ex for Elixir](https://github.com/lebrunel/ollama-ex)
- [Ollama Connector for SAP ABAP](https://github.com/b-tocs/abap_btocs_ollama)
- [Testcontainers](https://testcontainers.com/modules/ollama/)
- [Portkey](https://portkey.ai/docs/welcome/integration-guides/ollama)
- [PromptingTools.jl](https://github.com/svilupp/PromptingTools.jl)（[示例](https://svilupp.github.io/PromptingTools.jl/dev/examples/working_with_ollama)）
- [LlamaScript](https://github.com/Project-Llama/llamascript)
- [llm-axe](https://github.com/emirsahin1/llm-axe)（Python LLM 应用开发工具包）
- [Gollm](https://docs.gollm.co/examples/ollama-example)
- [Gollama for Golang](https://github.com/jonathanhecl/gollama)
- [Ollamaclient for Golang](https://github.com/xyproto/ollamaclient)
- [Go 高级函数抽象](https://gitlab.com/tozd/go/fun)
- [Ollama PHP](https://github.com/ArdaGnsrn/ollama-php)
- [Agents-Flex for Java](https://github.com/agents-flex/agents-flex)（[示例](https://github.com/agents-flex/agents-flex/tree/main/agents-flex-llm/agents-flex-llm-ollama/src/test/java/com/agentsflex/llm/ollama)）
- [Parakeet](https://github.com/parakeet-nest/parakeet)（Go 轻量 LLM 应用开发库）
- [Haverscript](https://github.com/andygill/haverscript)（[示例](https://github.com/andygill/haverscript/tree/main/examples)）
- [Ollama for Swift](https://github.com/mattt/ollama-swift)
- [Swollama for Swift](https://github.com/marcusziade/Swollama)（[DocC](https://marcusziade.github.io/Swollama/documentation/swollama/)）
- [GoLamify](https://github.com/prasad89/golamify)
- [Ollama for Haskell](https://github.com/tusharad/ollama-haskell)
- [multi-llm-ts](https://github.com/nbonamy/multi-llm-ts)（TS/JS 统一多 LLM 库）
- [LlmTornado](https://github.com/lofcz/llmtornado)（C# 统一接口库，支持主流推理 API）
- [Ollama for Zig](https://github.com/dravenk/ollama-zig)
- [Abso](https://github.com/lunary-ai/abso)（OpenAI 兼容 TypeScript SDK）
- [Nichey](https://github.com/goodreasonai/nichey)（研究主题定制 wiki 生成 Python 包）
- [Ollama for D](https://github.com/kassane/ollama-d)
- [OllamaPlusPlus](https://github.com/HardCodeDev777/OllamaPlusPlus)（极简 C++ Ollama 库）

### 移动端

- [SwiftChat](https://github.com/aws-samples/swift-chat)（原生界面，极速跨平台 AI 聊天，支持 Android、iOS、iPad）
- [Enchanted](https://github.com/AugustDev/enchanted)
- [Maid](https://github.com/Mobile-Artificial-Intelligence/maid)
- [Ollama App](https://github.com/JHubi1/ollama-app)（现代易用的多平台 Ollama 客户端）
- [ConfiChat](https://github.com/1runeberg/confichat)（轻量、独立、跨平台、隐私友好 LLM 聊天界面，支持可选加密）
- [Ollama Android Chat](https://github.com/sunshine0523/OllamaServer)（无需 Termux，安卓一键启动 Ollama 服务）
- [Reins](https://github.com/ibrahimcetin/reins)（每个聊天轻松调参，自定义系统 prompt，增强 AI 实验）

### 扩展 & 插件

- [Raycast 扩展](https://github.com/MassimilianoPasquini97/raycast_ollama)
- [Discollama](https://github.com/mxyng/discollama)（Ollama Discord 频道机器人）
- [Continue](https://github.com/continuedev/continue)
- [Vibe](https://github.com/thewh1teagle/vibe)（会议转录与分析）
- [Obsidian Ollama 插件](https://github.com/hinterdupfinger/obsidian-ollama)
- [Logseq Ollama 插件](https://github.com/omagdy7/ollama-logseq)
- [NotesOllama](https://github.com/andersrex/notesollama)（Apple Notes Ollama 插件）
- [Dagger Chatbot](https://github.com/samalba/dagger-chatbot)
- [Discord AI Bot](https://github.com/mekb-turtle/discord-ai-bot)
- [Ollama Telegram Bot](https://github.com/ruecat/ollama-telegram)
- [Hass Ollama Conversation](https://github.com/ej52/hass-ollama-conversation)
- [Rivet 插件](https://github.com/abrenneke/rivet-plugin-ollama)
- [Obsidian BMO Chatbot 插件](https://github.com/longy2k/obsidian-bmo-chatbot)
- [Cliobot](https://github.com/herval/cliobot)（支持 Ollama 的 Telegram 机器人）
- [Copilot for Obsidian 插件](https://github.com/logancyang/obsidian-copilot)
- [Obsidian Local GPT 插件](https://github.com/pfrankov/obsidian-local-gpt)
- [Open Interpreter](https://docs.openinterpreter.com/language-model-setup/local-models/ollama)
- [Llama Coder](https://github.com/ex3ndr/llama-coder)（Ollama 替代 Copilot）
- [Ollama Copilot](https://github.com/bernardo-bruning/ollama-copilot)（代理，将 Ollama 作为 Copilot 使用）
- [twinny](https://github.com/rjmacarthy/twinny)（Ollama Copilot 及聊天替代）
- [Wingman-AI](https://github.com/RussellCanfield/wingman-ai)（Ollama/Hugging Face Copilot 代码和聊天替代）
- [Page Assist](https://github.com/n4ze3m/page-assist)（Chrome 扩展）
- [Plasmoid Ollama Control](https://github.com/imoize/plasmoid-ollamacontrol)（KDE Plasma 快速管理/控制扩展）
- [AI Telegram Bot](https://github.com/tusharhero/aitelegrambot)（后端集成 Ollama 的 Telegram 机器人）
- [AI ST Completion](https://github.com/yaroslavyaroslav/OpenAI-sublime-text)（Sublime Text 4 AI 助手插件，支持 Ollama）
- [Discord-Ollama Chat Bot](https://github.com/kevinthedang/discord-ollama)（通用 TypeScript Discord 机器人，含调优文档）
- [ChatGPTBox: All in one 浏览器扩展](https://github.com/josStorer/chatGPTBox)（[集成教程](https://github.com/josStorer/chatGPTBox/issues/616#issuecomment-1975186467)）
- [Discord AI 聊天/管理机器人](https://github.com/rapmd73/Companion)（Python 实现，Ollama 个性化角色）
- [Headless Ollama](https://github.com/nischalj10/headless-ollama)（自动安装 Ollama 客户端和模型的脚本）
- [Terraform AWS Ollama & Open WebUI](https://github.com/xuyangbocn/terraform-aws-self-host-llm)（一键在 AWS 部署 Ollama+Open WebUI）
- [node-red-contrib-ollama](https://github.com/jakubburkiewicz/node-red-contrib-ollama)
- [Local AI Helper](https://github.com/ivostoykov/localAI)（Chrome/Firefox 扩展，支持自定义 API、标签安全存储）
- [vnc-lm](https://github.com/jake83741/vnc-lm)（Discord 机器人，通过 Ollama/LiteLLM 消息，快速切换模型）
- [LSP-AI](https://github.com/SilasMarvin/lsp-ai)（开源 AI 语言服务器）
- [QodeAssist](https://github.com/Palm1r/QodeAssist)（Qt Creator AI 编码助手插件）
- [Obsidian Quiz Generator 插件](https://github.com/ECuiDev/obsidian-quiz-generator)
- [AI Summmary Helper 插件](https://github.com/philffm/ai-summary-helper)
- [TextCraft](https://github.com/suncloudsmoon/TextCraft)（Word Copilot 替代）
- [Alfred Ollama](https://github.com/zeitlings/alfred-ollama)（Alfred Workflow）
- [TextLLaMA](https://github.com/adarshM84/TextLLaMA)（Chrome 扩展，邮件写作、语法纠错、翻译）
- [Simple-Discord-AI](https://github.com/zyphixor/simple-discord-ai)
- [LLM Telegram Bot](https://github.com/innightwolfsleep/llm_telegram_bot)（主打 RP 的 Telegram 机器人，集成 A1111、按钮等）
- [mcp-llm](https://github.com/sammcj/mcp-llm)（MCP 服务器，支持 LLM 间互调）
- [SimpleOllamaUnity](https://github.com/HardCodeDev777/SimpleOllamaUnity)（Unity 扩展，几行代码集成 Ollama，支持运行时）
- [UnityCodeLama](https://github.com/HardCodeDev777/UnityCodeLama)（Unity 编辑器脚本分析工具）

### 支持后端

- [llama.cpp](https://github.com/ggerganov/llama.cpp)（Georgi Gerganov 发起）

### 可观测性
- [Opik](https://www.comet.com/docs/opik/cookbook/ollama) 开源平台，支持 Ollama 的 LLM 应用/RAG/智能体工作流的调试、评估与监控，内置追踪、自动评测、生产级仪表盘。
- [Lunary](https://lunary.ai/docs/integrations/ollama) 主流开源 LLM 可观测性平台，提供实时分析、模板管理、PII 遮蔽、智能体追踪等企业级特性。
- [OpenLIT](https://github.com/openlit/openlit) 原生 OpenTelemetry 工具，监控 Ollama 应用与 GPU，追踪与指标一体化。
- [HoneyHive](https://docs.honeyhive.ai/integrations/ollama) AI 可观测与评估平台，支持智能体性能评测、故障分析与生产质量监控。
- [Langfuse](https://langfuse.com/docs/integrations/ollama) 开源 LLM 可观测性平台，协同监控、评估、调试 AI 应用。
- [MLflow Tracing](https://mlflow.org/docs/latest/llms/tracing/index.html#automatic-tracing) 开源 LLM 可观测工具，API 简便，便于调试与评估 GenAI 应用。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---