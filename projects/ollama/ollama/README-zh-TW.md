<div align="center">
  <a href="https://ollama.com">
    <img alt="ollama" height="200px" src="https://github.com/ollama/ollama/assets/3325447/0d0b44e2-8f4a-4e99-9b52-a5c1c741c8f7">
  </a>
</div>

# Ollama

快速啟動並運行大型語言模型。

### macOS

[下載](https://ollama.com/download/Ollama-darwin.zip)

### Windows

[下載](https://ollama.com/download/OllamaSetup.exe)

### Linux

```shell
curl -fsSL https://ollama.com/install.sh | sh
```

[手動安裝說明](https://github.com/ollama/ollama/blob/main/docs/linux.md)

### Docker

官方 [Ollama Docker 映像檔](https://hub.docker.com/r/ollama/ollama) `ollama/ollama` 可於 Docker Hub 取得。

### 程式庫

- [ollama-python](https://github.com/ollama/ollama-python)
- [ollama-js](https://github.com/ollama/ollama-js)

### 社群

- [Discord](https://discord.gg/ollama)
- [Reddit](https://reddit.com/r/ollama)

## 快速開始

要運行並與 [Llama 3.2](https://ollama.com/library/llama3.2) 聊天：

```shell
ollama run llama3.2
```

## 模型庫

Ollama 支援多種模型，詳見 [ollama.com/library](https://ollama.com/library 'ollama model library')

以下是部分可下載的範例模型：

| 模型                | 參數數量     | 大小   | 下載指令                            |
| ------------------- | ---------- | ----- | ------------------------------------ |
| Gemma 3            | 1B         | 815MB | `ollama run gemma3:1b`               |
| Gemma 3            | 4B         | 3.3GB | `ollama run gemma3`                  |
| Gemma 3            | 12B        | 8.1GB | `ollama run gemma3:12b`              |
| Gemma 3            | 27B        | 17GB  | `ollama run gemma3:27b`              |
| QwQ                | 32B        | 20GB  | `ollama run qwq`                     |
| DeepSeek-R1        | 7B         | 4.7GB | `ollama run deepseek-r1`             |
| DeepSeek-R1        | 671B       | 404GB | `ollama run deepseek-r1:671b`        |
| Llama 4            | 109B       | 67GB  | `ollama run llama4:scout`            |
| Llama 4            | 400B       | 245GB | `ollama run llama4:maverick`         |
| Llama 3.3          | 70B        | 43GB  | `ollama run llama3.3`                |
| Llama 3.2          | 3B         | 2.0GB | `ollama run llama3.2`                |
| Llama 3.2          | 1B         | 1.3GB | `ollama run llama3.2:1b`             |
| Llama 3.2 Vision   | 11B        | 7.9GB | `ollama run llama3.2-vision`         |
| Llama 3.2 Vision   | 90B        | 55GB  | `ollama run llama3.2-vision:90b`     |
| Llama 3.1          | 8B         | 4.7GB | `ollama run llama3.1`                |
| Llama 3.1          | 405B       | 231GB | `ollama run llama3.1:405b`           |
| Phi 4              | 14B        | 9.1GB | `ollama run phi4`                    |
| Phi 4 Mini         | 3.8B       | 2.5GB | `ollama run phi4-mini`               |
| Mistral            | 7B         | 4.1GB | `ollama run mistral`                 |
| Moondream 2        | 1.4B       | 829MB | `ollama run moondream`               |
| Neural Chat        | 7B         | 4.1GB | `ollama run neural-chat`             |
| Starling           | 7B         | 4.1GB | `ollama run starling-lm`             |
| Code Llama         | 7B         | 3.8GB | `ollama run codellama`               |
| Llama 2 Uncensored | 7B         | 3.8GB | `ollama run llama2-uncensored`       |
| LLaVA              | 7B         | 4.5GB | `ollama run llava`                   |
| Granite-3.3        | 8B         | 4.9GB | `ollama run granite3.3`              |

> [!NOTE]
> 運行 7B 模型建議至少 8 GB 記憶體，13B 模型需 16 GB，33B 模型需 32 GB 以上。

## 自訂模型

### 從 GGUF 匯入

Ollama 支援於 Modelfile 匯入 GGUF 模型：

1. 建立名為 `Modelfile` 的檔案，內容包含 `FROM` 指令，指定欲匯入模型的本機檔案路徑。

   ```
   FROM ./vicuna-33b.Q4_0.gguf
   ```

2. 在 Ollama 中建立模型

   ```shell
   ollama create example -f Modelfile
   ```

3. 運行該模型

   ```shell
   ollama run example
   ```

### 從 Safetensors 匯入

詳情請參閱[匯入模型指南](docs/import.md)。

### 自訂提示詞

Ollama 庫中的模型可透過提示詞進行自訂。例如要自訂 `llama3.2` 模型：

```shell
ollama pull llama3.2
```

建立一個 `Modelfile`：

```
FROM llama3.2

# 設定溫度為 1 [數值越高越有創意，越低越一致]
PARAMETER temperature 1

# 設定系統訊息
SYSTEM """
你是超級瑪利歐兄弟的瑪利歐。僅以瑪利歐（助理）身份回答。
"""
```

然後建立並運行模型：

```
ollama create mario -f ./Modelfile
ollama run mario
>>> hi
Hello! It's your friend Mario.
```

更多 Modelfile 操作資訊，請參閱 [Modelfile](docs/modelfile.md) 文件。

## CLI 參考

### 建立模型

`ollama create` 用於根據 Modelfile 建立模型。

```shell
ollama create mymodel -f ./Modelfile
```

### 拉取模型

```shell
ollama pull llama3.2
```

> 此指令亦可用於更新本地模型，只會拉取差異部分。

### 移除模型

```shell
ollama rm llama3.2
```

### 複製模型

```shell
ollama cp llama3.2 my-model
```

### 多行輸入

多行輸入可用 `"""` 包住文字：

```
>>> """Hello,
... world!
... """
I'm a basic program that prints the famous "Hello, world!" message to the console.
```

### 多模態模型

```
ollama run llava "What's in this image? /Users/jmorgan/Desktop/smile.png"
```

> **輸出**：這張圖像以黃色笑臉為主題，可能是畫面的焦點。

### 以參數傳遞提示詞

```shell
ollama run llama3.2 "Summarize this file: $(cat README.md)"
```

> **輸出**：Ollama 是一個輕量、可擴展的本地語言模型框架，提供簡單 API 以便建立、運行與管理模型，並有豐富的內建模型庫可於多種應用中輕易使用。

### 顯示模型資訊

```shell
ollama show llama3.2
```

### 列出本機所有模型

```shell
ollama list
```

### 列出當前載入的模型

```shell
ollama ps
```

### 停止當前運行的模型

```shell
ollama stop llama3.2
```

### 啟動 Ollama

`ollama serve` 用於在不啟動桌面應用時啟動 ollama 服務。

## 編譯建置

詳見 [開發人員指南](https://github.com/ollama/ollama/blob/main/docs/development.md)

### 運行本地編譯版本

啟動伺服器：

```shell
./ollama serve
```

另開一個終端視窗，運行模型：

```shell
./ollama run llama3.2
```

## REST API

Ollama 提供 REST API 以運行及管理模型。

### 產生回應

```shell
curl http://localhost:11434/api/generate -d '{
  "model": "llama3.2",
  "prompt":"Why is the sky blue?"
}'
```

### 與模型對話

```shell
curl http://localhost:11434/api/chat -d '{
  "model": "llama3.2",
  "messages": [
    { "role": "user", "content": "why is the sky blue?" }
  ]
}'
```

所有端點請參閱 [API 文件](./docs/api.md)。

## 社群整合

### 網頁與桌面

- [Open WebUI](https://github.com/open-webui/open-webui)
- [SwiftChat (macOS with ReactNative)](https://github.com/aws-samples/swift-chat)
- [Enchanted (macOS 原生)](https://github.com/AugustDev/enchanted)
- [Hollama](https://github.com/fmaclen/hollama)
- [Lollms-Webui](https://github.com/ParisNeo/lollms-webui)
- [LibreChat](https://github.com/danny-avila/LibreChat)
- [Bionic GPT](https://github.com/bionic-gpt/bionic-gpt)
- [HTML UI](https://github.com/rtcfirefly/ollama-ui)
- [Saddle](https://github.com/jikkuatwork/saddle)
- [TagSpaces](https://www.tagspaces.org)（文件型應用平台，[利用 Ollama](https://docs.tagspaces.org/ai/) 生成標籤與描述）
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
- [NextChat](https://github.com/ChatGPTNextWeb/ChatGPT-Next-Web)（[入門文檔](https://docs.nextchat.dev/models/ollama)）
- [Alpaca WebUI](https://github.com/mmo80/alpaca-webui)
- [OllamaGUI](https://github.com/enoch1118/ollamaGUI)
- [OpenAOE](https://github.com/InternLM/OpenAOE)
- [Odin Runes](https://github.com/leonid20000/OdinRunes)
- [LLM-X](https://github.com/mrdjohnson/llm-x)（PWA）
- [AnythingLLM (Docker + MacOs/Windows/Linux 原生應用)](https://github.com/Mintplex-Labs/anything-llm)
- [Ollama Basic Chat: Uses HyperDiv Reactive UI](https://github.com/rapidarchitect/ollama_basic_chat)
- [Ollama-chats RPG](https://github.com/drazdra/ollama-chats)
- [IntelliBar](https://intellibar.app/)（macOS AI 助理）
- [Jirapt](https://github.com/AliAhmedNada/jirapt)（Jira 整合，生成議題、任務、史詩）
- [ojira](https://github.com/AliAhmedNada/ojira)（Jira Chrome 插件，快速生成任務描述）
- [QA-Pilot](https://github.com/reid41/QA-Pilot)（互動聊天工具，支援 GitHub 倉庫理解與導航）
- [ChatOllama](https://github.com/sugarforever/chat-ollama)（知識庫型開源聊天機器人）
- [CRAG Ollama Chat](https://github.com/Nagi-ovo/CRAG-Ollama-Chat)（網頁搜尋與修正型RAG）
- [RAGFlow](https://github.com/infiniflow/ragflow)（基於深度文件理解的開源RAG引擎）
- [StreamDeploy](https://github.com/StreamDeploy-DevRel/streamdeploy-llm-app-scaffold)（LLM應用腳手架）
- [chat](https://github.com/swuecho/chat)（團隊聊天應用）
- [Lobe Chat](https://github.com/lobehub/lobe-chat)（[整合文檔](https://lobehub.com/docs/self-hosting/examples/ollama)）
- [Ollama RAG Chatbot](https://github.com/datvodinh/rag-chatbot.git)（本地聊天，支援多個PDF文件，結合 Ollama 與 RAG）
- [BrainSoup](https://www.nurgo-software.com/products/brainsoup)（靈活原生客戶端，支援 RAG 與多代理自動化）
- [macai](https://github.com/Renset/macai)（macOS 用戶端，支援 Ollama、ChatGPT、其他 API 後端）
- [RWKV-Runner](https://github.com/josStorer/RWKV-Runner)（RWKV 離線 LLM 部署工具，可作為 ChatGPT/Ollama 客戶端）
- [Ollama Grid Search](https://github.com/dezoito/ollama-grid-search)（模型評估與比較應用）
- [Olpaka](https://github.com/Otacon/olpaka)（Flutter Web UI，友善介面）
- [Casibase](https://casibase.org)（開源AI知識庫與對話系統，結合RAG、SSO、Ollama、多種大型模型）
- [OllamaSpring](https://github.com/CrazyNeil/OllamaSpring)（macOS Ollama 客戶端）
- [LLocal.in](https://github.com/kartikm7/llocal)（簡易 Electron 桌面 Ollama 客戶端）
- [Shinkai Desktop](https://github.com/dcSpark/shinkai-apps)（兩步安裝本地AI，結合 Ollama+文件+RAG）
- [AiLama](https://github.com/zeyoyt/ailama)（Discord 使用者應用，隨處互動 Ollama）
- [Ollama with Google Mesop](https://github.com/rapidarchitect/ollama_mesop/)（Mesop Chat Client 實現）
- [R2R](https://github.com/SciPhi-AI/R2R)（開源 RAG 引擎）
- [Ollama-Kis](https://github.com/elearningshow/ollama-kis)（簡易 GUI 與自訂 LLM 教育範例）
- [OpenGPA](https://opengpa.org)（開源離線優先企業代理應用）
- [Painting Droid](https://github.com/mateuszmigas/painting-droid)（AI繪圖應用）
- [Kerlig AI](https://www.kerlig.com/)（macOS AI寫作助理）
- [AI Studio](https://github.com/MindWorkAI/AI-Studio)
- [Sidellama](https://github.com/gyopak/sidellama)（瀏覽器型 LLM 客戶端）
- [LLMStack](https://github.com/trypromptly/LLMStack)（無程式碼多代理框架，構建LLM代理與工作流程）
- [BoltAI for Mac](https://boltai.com)（Mac AI 聊天客戶端）
- [Harbor](https://github.com/av/harbor)（容器化LLM工具箱，預設 Ollama 後端）
- [PyGPT](https://github.com/szczyglis-dev/py-gpt)（Linux/Windows/Mac AI 桌面助手）
- [Alpaca](https://github.com/Jeffser/Alpaca)（Linux/macOS Ollama 客戶端，GTK4/Adwaita 開發）
- [AutoGPT](https://github.com/Significant-Gravitas/AutoGPT/blob/master/docs/content/platform/ollama.md)（AutoGPT Ollama 整合）
- [Go-CREW](https://www.jonathanhecl.com/go-crew/)（Golang 離線 RAG）
- [PartCAD](https://github.com/openvmp/partcad/)（OpenSCAD+CadQuery CAD模型生成）
- [Ollama4j Web UI](https://github.com/ollama4j/ollama4j-web-ui)（Java Web UI，Vaadin/Spring Boot/Ollama4j）
- [PyOllaMx](https://github.com/kspviswa/pyOllaMx)（macOS 聊天應用，支援 Ollama 與 Apple MLX）
- [Cline](https://github.com/cline/cline)（VSCode 多檔案/整倉代碼助手）
- [Cherry Studio](https://github.com/kangfenmao/cherry-studio)（桌面 Ollama 客戶端）
- [ConfiChat](https://github.com/1runeberg/confichat)（輕量、獨立、多平台、注重隱私 LLM 聊天介面，支援加密）
- [Archyve](https://github.com/nickthecook/archyve)（RAG文件庫）
- [crewAI with Mesop](https://github.com/rapidarchitect/ollama-crew-mesop)（Mesop Web 介面運行 crewAI with Ollama）
- [Tkinter-based client](https://github.com/chyok/ollama-gui)（Python tkinter 客戶端）
- [LLMChat](https://github.com/trendy-design/llmchat)（注重隱私、完全本地、直觀聊天介面）
- [Local Multimodal AI Chat](https://github.com/Leon-Sander/Local-Multimodal-AI-Chat)（多功能本地LLM聊天，支援PDF RAG、語音、圖像等）
- [ARGO](https://github.com/xark-argo/argo)（本地下載/運行 Ollama/Huggingface 模型，支援RAG，跨平台）
- [OrionChat](https://github.com/EliasPereirah/OrionChat)（多AI供應商網頁聊天介面）
- [G1](https://github.com/bklieger-groq/g1)（探索提示策略提升 LLM 推理）
- [Web management](https://github.com/lemonit-eric-mao/ollama-web-management)（Web 管理頁面）
- [Promptery](https://github.com/promptery/promptery)（桌面 Ollama 客戶端）
- [Ollama App](https://github.com/JHubi1/ollama-app)（現代且易用的多平台 Ollama 客戶端）
- [chat-ollama](https://github.com/annilq/chat-ollama)（React Native 客戶端）
- [SpaceLlama](https://github.com/tcsenpai/spacellama)（Firefox/Chrome 擴充，側邊欄快速摘要網頁）
- [YouLama](https://github.com/tcsenpai/youlama)（YouTube影片摘要WebApp，支援Invidious）
- [DualMind](https://github.com/tcsenpai/dualmind)（實驗性雙模型對話，終端/網頁）
- [ollamarama-matrix](https://github.com/h1ddenpr0cess20/ollamarama-matrix)（Matrix 協議聊天機器人）
- [ollama-chat-app](https://github.com/anan1213095357/ollama-chat-app)（Flutter 聊天應用）
- [Perfect Memory AI](https://www.perfectmemory.ai/)（生產力 AI，根據你的螢幕、會議內容個人化助理）
- [Hexabot](https://github.com/hexastack/hexabot)（對話式AI構建器）
- [Reddit Rate](https://github.com/rapidarchitect/reddit_analyzer)（Reddit 主題加權評分與搜尋）
- [OpenTalkGpt](https://github.com/adarshM84/OpenTalkGpt)（Chrome 擴充，管理/自訂/聊天 UI）
- [VT](https://github.com/vinhnx/vt.ai)（極簡多模態 AI 聊天，支援本地 Ollama）
- [Nosia](https://github.com/nosia-ai/nosia)（易用 RAG 平台，基於 Ollama）
- [Witsy](https://github.com/nbonamy/witsy)（跨平台 AI 桌面應用）
- [Abbey](https://github.com/US-Artificial-Intelligence/abbey)（可配置 AI 介面伺服器，支援筆記、文件、YouTube）
- [Minima](https://github.com/dmayboroda/minima)（RAG，本地/內網工作流程）
- [aidful-ollama-model-delete](https://github.com/AidfulAI/aidful-ollama-model-delete)（簡化模型清理的 UI）
- [Perplexica](https://github.com/ItzCrazyKns/Perplexica)（AI 搜尋引擎，開源替代 Perplexity AI）
- [Ollama Chat WebUI for Docker](https://github.com/oslook/ollama-webui)（支援本地 Docker 部署的輕量 WebUI）
- [AI Toolkit for Visual Studio Code](https://aka.ms/ai-tooklit/ollama-docs)（微軟官方 VSCode 擴充，支援 Ollama 聊天、測試、評估、應用整合）
- [MinimalNextOllamaChat](https://github.com/anilkay/MinimalNextOllamaChat)（極簡聊天與模型控制 Web UI）
- [Chipper](https://github.com/TilmanGriesel/chipper)（AI 實驗室介面，支援 Ollama、Haystack RAG、Python）
- [ChibiChat](https://github.com/CosmicEventHorizon/ChibiChat)（Kotlin Android 聊天，支援 Ollama/Koboldcpp API）
- [LocalLLM](https://github.com/qusaismael/localllm)（極簡 Web 應用，GUI 運行 Ollama 模型）
- [Ollamazing](https://github.com/buiducnhat/ollamazing)（Ollama 瀏覽器擴充）
- [OpenDeepResearcher-via-searxng](https://github.com/benhaotang/OpenDeepResearcher-via-searxng)（深度研究端點，本地運行 Ollama）
- [AntSK](https://github.com/AIDotNet/AntSK)（即用型 RAG 聊天機器人）
- [MaxKB](https://github.com/1Panel-dev/MaxKB/)（彈性 RAG 聊天機器人）
- [yla](https://github.com/danielekp/yla)（自訂模型互動 Web 介面）
- [LangBot](https://github.com/RockChinQ/LangBot)（LLM 即時通訊平台，支援代理/RAG/多平台）
- [1Panel](https://github.com/1Panel-dev/1Panel/)（Linux 伺服器 Web 管理工具）
- [AstrBot](https://github.com/Soulter/AstrBot/)（多平台 LLM 聊天，WebUI，支援 RAG、代理、插件）
- [Reins](https://github.com/ibrahimcetin/reins)（易於調整參數、每聊自訂 system prompt，強化實驗性）
- [Flufy](https://github.com/Aharon-Bensadoun/Flufy)（美觀聊天介面，基於 React/TypeScript/Material-UI）
- [Ellama](https://github.com/zeozeozeo/ellama)（友善原生 Ollama 聊天應用）
- [screenpipe](https://github.com/mediar-ai/screenpipe)（基於螢幕歷史構建智能代理）
- [Ollamb](https://github.com/hengkysteen/ollamb)（簡潔且功能豐富，Flutter 跨平台，支援 [網頁試用](https://hengkysteen.github.io/demo/ollamb/)）
- [Writeopia](https://github.com/Writeopia/Writeopia)（整合 Ollama 的文字編輯器）
- [AppFlowy](https://github.com/AppFlowy-IO/AppFlowy)（AI 協作空間，跨平台且可自託管）
- [Lumina](https://github.com/cushydigit/lumina.git)（極輕量 React.js 前端）
- [Tiny Notepad](https://pypi.org/project/tiny-notepad)（極簡記事本風格 Ollama 聊天應用，PyPI 提供）
- [macLlama (macOS 原生)](https://github.com/hellotunamayo/macLlama)（macOS 原生 GUI，支援 Ollama 聊天）

### 雲端

- [Google Cloud](https://cloud.google.com/run/docs/tutorials/gpu-gemma2-with-ollama)
- [Fly.io](https://fly.io/docs/python/do-more/add-ollama/)
- [Koyeb](https://www.koyeb.com/deploy/ollama)

### 終端機

- [oterm](https://github.com/ggozad/oterm)
- [Ellama Emacs client](https://github.com/s-kostyaev/ellama)
- [Emacs client](https://github.com/zweifisch/ollama)
- [neollama](https://github.com/paradoxical-dev/neollama)（Neovim 互動用戶端）
- [gen.nvim](https://github.com/David-Kunz/gen.nvim)
- [ollama.nvim](https://github.com/nomnivore/ollama.nvim)
- [ollero.nvim](https://github.com/marco-souza/ollero.nvim)
- [ollama-chat.nvim](https://github.com/gerazov/ollama-chat.nvim)
- [ogpt.nvim](https://github.com/huynle/ogpt.nvim)
- [gptel Emacs client](https://github.com/karthink/gptel)
- [Oatmeal](https://github.com/dustinblackman/oatmeal)
- [cmdh](https://github.com/pgibler/cmdh)
- [ooo](https://github.com/npahlfer/ooo)
- [shell-pilot](https://github.com/reid41/shell-pilot)（Linux/macOS 純 shell 聊天）
- [tenere](https://github.com/pythops/tenere)
- [llm-ollama](https://github.com/taketwo/llm-ollama)（[Datasette's LLM CLI](https://llm.datasette.io/en/stable/)）
- [typechat-cli](https://github.com/anaisbetts/typechat-cli)
- [ShellOracle](https://github.com/djcopley/ShellOracle)
- [tlm](https://github.com/yusufcanb/tlm)
- [podman-ollama](https://github.com/ericcurtin/podman-ollama)
- [gollama](https://github.com/sammcj/gollama)
- [ParLlama](https://github.com/paulrobello/parllama)
- [Ollama eBook Summary](https://github.com/cognitivetech/ollama-ebook-summary/)
- [Ollama Mixture of Experts (MOE) in 50 lines of code](https://github.com/rapidarchitect/ollama_moe)
- [vim-intelligence-bridge](https://github.com/pepo-ec/vim-intelligence-bridge)（Vim Ollama互動）
- [x-cmd ollama](https://x-cmd.com/mod/ollama)
- [bb7](https://github.com/drunkwcodes/bb7)
- [SwollamaCLI](https://github.com/marcusziade/Swollama)（內建於 Swollama Swift 套件，[示範](https://github.com/marcusziade/Swollama?tab=readme-ov-file#cli-usage)）
- [aichat](https://github.com/sigoden/aichat)（全能LLM CLI，含Shell助理、Chat-REPL、RAG、AI工具/代理，支援多家API）
- [PowershAI](https://github.com/rrg92/powershai)（Windows PowerShell AI模組，含 Ollama 支援）
- [DeepShell](https://github.com/Abyss-c0re/deepshell)（自託管AI助理，支援Shell/檔案資料夾分析）
- [orbiton](https://github.com/xyproto/orbiton)（零配置編輯器/IDE，支援 Ollama 自動補全）
- [orca-cli](https://github.com/molbal/orca-cli)（Ollama 註冊 CLI，終端瀏覽/拉取/下載模型）
- [GGUF-to-Ollama](https://github.com/jonathanhecl/gguf-to-ollama)（多平台GGUF一鍵匯入 Ollama）
- [AWS-Strands-With-Ollama](https://github.com/rapidarchitect/ollama_strands)（AWS Strands 代理 Ollama 範例）

### Apple Vision Pro

- [SwiftChat](https://github.com/aws-samples/swift-chat)（跨平台 AI 聊天，支援 Apple Vision Pro）
- [Enchanted](https://github.com/AugustDev/enchanted)

### 資料庫

- [pgai](https://github.com/timescale/pgai) - PostgreSQL 向量資料庫（用 pgvector 建立與搜尋 Ollama 向量）
   - [入門指南](https://github.com/timescale/pgai/blob/main/docs/vectorizer-quick-start.md)
- [MindsDB](https://github.com/mindsdb/mindsdb/blob/staging/mindsdb/integrations/handlers/ollama_handler/README.md)（連接 Ollama 模型至近200個資料平台與應用）
- [chromem-go](https://github.com/philippgille/chromem-go/blob/v0.5.0/embed_ollama.go)  [範例](https://github.com/philippgille/chromem-go/tree/v0.5.0/examples/rag-wikipedia-ollama)
- [Kangaroo](https://github.com/dbkangaroo/kangaroo)（AI驅動SQL客戶端與管理工具）

### 套件管理

- [Pacman](https://archlinux.org/packages/extra/x86_64/ollama/)
- [Gentoo](https://github.com/gentoo/guru/tree/master/app-misc/ollama)
- [Homebrew](https://formulae.brew.sh/formula/ollama)
- [Helm Chart](https://artifacthub.io/packages/helm/ollama-helm/ollama)
- [Guix channel](https://codeberg.org/tusharhero/ollama-guix)
- [Nix package](https://search.nixos.org/packages?show=ollama&from=0&size=50&sort=relevance&type=packages&query=ollama)
- [Flox](https://flox.dev/blog/ollama-part-one)

### 程式庫

- [LangChain](https://python.langchain.com/docs/integrations/chat/ollama/) 與 [LangChain.js](https://js.langchain.com/docs/integrations/chat/ollama/)（[範例](https://js.langchain.com/docs/tutorials/local_rag/)）
- [Firebase Genkit](https://firebase.google.com/docs/genkit/plugins/ollama)
- [crewAI](https://github.com/crewAIInc/crewAI)
- [Yacana](https://remembersoftwares.github.io/yacana/)（友善多代理框架，內建工具整合）
- [Spring AI](https://github.com/spring-projects/spring-ai)（[參考](https://docs.spring.io/spring-ai/reference/api/chat/ollama-chat.html) 與 [範例](https://github.com/tzolov/ollama-tools)）
- [LangChainGo](https://github.com/tmc/langchaingo/)（[範例](https://github.com/tmc/langchaingo/tree/main/examples/ollama-completion-example)）
- [LangChain4j](https://github.com/langchain4j/langchain4j)（[範例](https://github.com/langchain4j/langchain4j-examples/tree/main/ollama-examples/src/main/java)）
- [LangChainRust](https://github.com/Abraxas-365/langchain-rust)（[範例](https://github.com/Abraxas-365/langchain-rust/blob/main/examples/llm_ollama.rs)）
- [LangChain for .NET](https://github.com/tryAGI/LangChain)（[範例](https://github.com/tryAGI/LangChain/blob/main/examples/LangChain.Samples.OpenAI/Program.cs)）
- [LLPhant](https://github.com/theodo-group/LLPhant?tab=readme-ov-file#ollama)
- [LlamaIndex](https://docs.llamaindex.ai/en/stable/examples/llm/ollama/) 與 [LlamaIndexTS](https://ts.llamaindex.ai/modules/llms/available_llms/ollama)
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
- [PromptingTools.jl](https://github.com/svilupp/PromptingTools.jl)（[範例](https://svilupp.github.io/PromptingTools.jl/dev/examples/working_with_ollama)）
- [LlamaScript](https://github.com/Project-Llama/llamascript)
- [llm-axe](https://github.com/emirsahin1/llm-axe)（Python LLM 應用工具包）
- [Gollm](https://docs.gollm.co/examples/ollama-example)
- [Gollama for Golang](https://github.com/jonathanhecl/gollama)
- [Ollamaclient for Golang](https://github.com/xyproto/ollamaclient)
- [High-level function abstraction in Go](https://gitlab.com/tozd/go/fun)
- [Ollama PHP](https://github.com/ArdaGnsrn/ollama-php)
- [Agents-Flex for Java](https://github.com/agents-flex/agents-flex)（[範例](https://github.com/agents-flex/agents-flex/tree/main/agents-flex-llm/agents-flex-llm-ollama/src/test/java/com/agentsflex/llm/ollama)）
- [Parakeet](https://github.com/parakeet-nest/parakeet)（GoLang 程式庫，簡化小型生成式AI應用開發）
- [Haverscript](https://github.com/andygill/haverscript)（[範例](https://github.com/andygill/haverscript/tree/main/examples)）
- [Ollama for Swift](https://github.com/mattt/ollama-swift)
- [Swollama for Swift](https://github.com/marcusziade/Swollama)（[DocC](https://marcusziade.github.io/Swollama/documentation/swollama/)）
- [GoLamify](https://github.com/prasad89/golamify)
- [Ollama for Haskell](https://github.com/tusharad/ollama-haskell)
- [multi-llm-ts](https://github.com/nbonamy/multi-llm-ts)（TypeScript/JavaScript 多LLM統一API庫）
- [LlmTornado](https://github.com/lofcz/llmtornado)（C# 統一API函式庫，支援主流FOSS與商業推理）
- [Ollama for Zig](https://github.com/dravenk/ollama-zig)
- [Abso](https://github.com/lunary-ai/abso)（OpenAI兼容TypeScript SDK，支援多家LLM）
- [Nichey](https://github.com/goodreasonai/nichey)（Python 套件，生成自訂主題維基）
- [Ollama for D](https://github.com/kassane/ollama-d)
- [OllamaPlusPlus](https://github.com/HardCodeDev777/OllamaPlusPlus)（極簡C++ Ollama程式庫）

### 行動裝置

- [SwiftChat](https://github.com/aws-samples/swift-chat)（極速跨平台 AI 聊天，原生支援 Android/iOS/iPad）
- [Enchanted](https://github.com/AugustDev/enchanted)
- [Maid](https://github.com/Mobile-Artificial-Intelligence/maid)
- [Ollama App](https://github.com/JHubi1/ollama-app)（現代且易用的多平台 Ollama 客戶端）
- [ConfiChat](https://github.com/1runeberg/confichat)（輕量、獨立、多平台、注重隱私 LLM 聊天介面，支援加密）
- [Ollama Android Chat](https://github.com/sunshine0523/OllamaServer)（無需 Termux，Android 一鍵啟動 Ollama 服務）
- [Reins](https://github.com/ibrahimcetin/reins)（易於調整參數、每聊自訂 system prompt，強化實驗性）

### 擴充與插件

- [Raycast 擴充](https://github.com/MassimilianoPasquini97/raycast_ollama)
- [Discollama](https://github.com/mxyng/discollama)（Ollama Discord 頻道機器人）
- [Continue](https://github.com/continuedev/continue)
- [Vibe](https://github.com/thewh1teagle/vibe)（會議錄音與分析）
- [Obsidian Ollama 插件](https://github.com/hinterdupfinger/obsidian-ollama)
- [Logseq Ollama 插件](https://github.com/omagdy7/ollama-logseq)
- [NotesOllama](https://github.com/andersrex/notesollama)（Apple Notes Ollama 插件）
- [Dagger Chatbot](https://github.com/samalba/dagger-chatbot)
- [Discord AI Bot](https://github.com/mekb-turtle/discord-ai-bot)
- [Ollama Telegram Bot](https://github.com/ruecat/ollama-telegram)
- [Hass Ollama Conversation](https://github.com/ej52/hass-ollama-conversation)
- [Rivet plugin](https://github.com/abrenneke/rivet-plugin-ollama)
- [Obsidian BMO Chatbot 插件](https://github.com/longy2k/obsidian-bmo-chatbot)
- [Cliobot](https://github.com/herval/cliobot)（Telegram 機器人，支援 Ollama）
- [Copilot for Obsidian 插件](https://github.com/logancyang/obsidian-copilot)
- [Obsidian Local GPT 插件](https://github.com/pfrankov/obsidian-local-gpt)
- [Open Interpreter](https://docs.openinterpreter.com/language-model-setup/local-models/ollama)
- [Llama Coder](https://github.com/ex3ndr/llama-coder)（Copilot替代品，使用 Ollama）
- [Ollama Copilot](https://github.com/bernardo-bruning/ollama-copilot)（代理，支援用 Ollama 作 Copilot）
- [twinny](https://github.com/rjmacarthy/twinny)（Copilot 及聊天替代品，使用 Ollama）
- [Wingman-AI](https://github.com/RussellCanfield/wingman-ai)（Copilot 代碼/聊天替代品，支援 Ollama/HuggingFace）
- [Page Assist](https://github.com/n4ze3m/page-assist)（Chrome 擴充）
- [Plasmoid Ollama Control](https://github.com/imoize/plasmoid-ollamacontrol)（KDE Plasma 擴充，快速管理/控制模型）
- [AI Telegram Bot](https://github.com/tusharhero/aitelegrambot)（後端用 Ollama 的 Telegram 機器人）
- [AI ST Completion](https://github.com/yaroslavyaroslav/OpenAI-sublime-text)（Sublime Text 4 AI 助手，支援 Ollama）
- [Discord-Ollama Chat Bot](https://github.com/kevinthedang/discord-ollama)（TypeScript Discord Bot，含調優文件）
- [ChatGPTBox: All in one 瀏覽器擴充](https://github.com/josStorer/chatGPTBox)（[整合教學](https://github.com/josStorer/chatGPTBox/issues/616#issuecomment-1975186467)）
- [Discord AI chat/moderation bot](https://github.com/rapmd73/Companion)（Python 聊天/管理機器人，利用 Ollama 生成多種人格）
- [Headless Ollama](https://github.com/nischalj10/headless-ollama)（自動安裝 ollama 客戶端/模型用於依賴 ollama 伺服器的應用）
- [Terraform AWS Ollama & Open WebUI](https://github.com/xuyangbocn/terraform-aws-self-host-llm)（一鍵 AWS 部署 Ollama 與前端 Open WebUI）
- [node-red-contrib-ollama](https://github.com/jakubburkiewicz/node-red-contrib-ollama)
- [Local AI Helper](https://github.com/ivostoykov/localAI)（Chrome/Firefox 擴充，支援 API 互動與安全儲存提示詞）
- [vnc-lm](https://github.com/jake83741/vnc-lm)（Discord 聊天機器人，支援 Ollama/LiteLLM）
- [LSP-AI](https://github.com/SilasMarvin/lsp-ai)（開源語言伺服器，支援 AI 功能）
- [QodeAssist](https://github.com/Palm1r/QodeAssist)（Qt Creator AI 編程助手插件）
- [Obsidian Quiz Generator 插件](https://github.com/ECuiDev/obsidian-quiz-generator)
- [AI Summmary Helper 插件](https://github.com/philffm/ai-summary-helper)
- [TextCraft](https://github.com/suncloudsmoon/TextCraft)（Word Copilot 替代品，支援 Ollama）
- [Alfred Ollama](https://github.com/zeitlings/alfred-ollama)（Alfred Workflow）
- [TextLLaMA](https://github.com/adarshM84/TextLLaMA)（Chrome 擴充，助你寫信、改文法、翻譯）
- [Simple-Discord-AI](https://github.com/zyphixor/simple-discord-ai)
- [LLM Telegram Bot](https://github.com/innightwolfsleep/llm_telegram_bot)（RP導向Telegram機器人，支援A1111 API等）
- [mcp-llm](https://github.com/sammcj/mcp-llm)（MCP伺服器允許LLM互調）
- [SimpleOllamaUnity](https://github.com/HardCodeDev777/SimpleOllamaUnity)（Unity擴充，簡單整合 Ollama）
- [UnityCodeLama](https://github.com/HardCodeDev777/UnityCodeLama)（Unity 編輯器分析腳本工具）

### 支援的後端

- [llama.cpp](https://github.com/ggerganov/llama.cpp)（Georgi Gerganov 發起）

### 可觀測性
- [Opik](https://www.comet.com/docs/opik/cookbook/ollama) 是開源平台，支援 LLM 應用、RAG 系統、代理流程之除錯、評估、監控，原生整合 Ollama。
- [Lunary](https://lunary.ai/docs/integrations/ollama) 領先的開源 LLM 可觀測平台，提供即時分析、提示模板管理、PII 遮蔽、代理追蹤等企業級功能。
- [OpenLIT](https://github.com/openlit/openlit) 是 OpenTelemetry 原生工具，用於 Ollama 應用與 GPU 監控（追蹤與度量）。
- [HoneyHive](https://docs.honeyhive.ai/integrations/ollama) 是 AI 代理的可觀測/評估平台，用於評估代理效能、追蹤錯誤、監控生產品質。
- [Langfuse](https://langfuse.com/docs/integrations/ollama) 開源 LLM 可觀測性平台，協助團隊協作監控、評估、除錯 AI 應用。
- [MLflow Tracing](https://mlflow.org/docs/latest/llms/tracing/index.html#automatic-tracing) 開源 LLM 可觀測工具，API 便於記錄與視覺化追蹤，助於 GenAI 應用除錯與評估。


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---