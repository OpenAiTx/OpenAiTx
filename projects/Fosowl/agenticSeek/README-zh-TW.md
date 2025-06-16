# AgenticSeek：私有，本地的 Manus 替代方案

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*一款**100% 本地運行的 Manus AI 替代品**，這個支援語音的 AI 助理可自主瀏覽網路、撰寫程式碼、規劃任務，同時所有資料皆儲存在您的裝置上。專為本地推理模型設計，完全在您的硬體上運行，確保絕對隱私及零雲端依賴。*

[![Visit AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### 為什麼選擇 AgenticSeek？

* 🔒 完全本地 & 私有 — 一切都在您的設備上運行，無雲端、無資料分享。您的檔案、對話與搜尋全都保密。

* 🌐 智慧網頁瀏覽 — AgenticSeek 可自動瀏覽網路：搜尋、閱讀、擷取資訊、自動填表，全程免動手。

* 💻 自主編程助理 — 需要程式碼？它可在無需監督下撰寫、除錯並執行 Python、C、Go、Java 等程式。

* 🧠 智慧代理選擇 — 您提問，它自動判斷並選擇最適合的代理人。就像有專家團隊隨時協助您。

* 📋 規劃與執行複雜任務 — 從旅行規劃到大型專案，能自動拆解步驟並召集多個 AI 代理人完成任務。

* 🎙️ 語音功能 — 乾淨、快速、未來感的語音與語音轉文字，讓您像在科幻電影中與個人 AI 對話。（開發中）

### **演示範例**

> *你可以搜尋 agenticSeek 專案，了解需要哪些技能，然後打開 CV_candidates.zip 並告訴我哪個最符合專案需求嗎*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

免責聲明：此演示範例（包括出現的所有檔案，例如 CV_candidates.zip）均為虛構。我們不是企業，我們尋求的是開源貢獻者而非求職者。

> 🛠⚠️️ **專案仍在積極開發中**

> 🙏 本專案最初僅為副業，沒有任何開發規劃及資金，卻意外登上 GitHub Trending。非常感謝大家的貢獻、回饋與耐心。

## 先決條件

在開始之前，請確保已安裝以下軟體：

*   **Git：** 用於複製程式庫。[下載 Git](https://git-scm.com/downloads)
*   **Python 3.10.x：** 強烈建議使用 Python 3.10.x 版本，其它版本可能會導致依賴錯誤。[下載 Python 3.10](https://www.python.org/downloads/release/python-3100/)（請選擇 3.10.x 版本）。
*   **Docker Engine & Docker Compose：** 用於運行如 SearxNG 等綑綁服務。
    *   安裝 Docker Desktop（內含 Docker Compose V2）：[Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   或者，於 Linux 上分別安裝 Docker Engine 與 Docker Compose：[Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/)（請確保安裝 Compose V2，如 `sudo apt-get install docker-compose-plugin`）。

### 1. **複製程式庫並進行設定**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. 修改 .env 檔案內容

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

請依需求以您的資訊更新 `.env` 檔案：

- **SEARXNG_BASE_URL**：保持不變
- **REDIS_BASE_URL**：保持不變
- **WORK_DIR**：您本地工作目錄的路徑。AgenticSeek 將能讀取並操作這些檔案。
- **OLLAMA_PORT**：Ollama 服務的埠號。
- **LM_STUDIO_PORT**：LM Studio 服務的埠號。
- **CUSTOM_ADDITIONAL_LLM_PORT**：自訂 LLM 服務的埠號。

**API Key 對於選擇本地運行 LLM 的用戶完全可選，本專案的主要目標即為本地推理。如您的硬體足夠，可保持空白。**

### 3. **啟動 Docker**

請確保您的系統已安裝並啟動 Docker。可使用下列指令啟動 Docker：

- **於 Linux/macOS 上：**  
    開啟終端機並執行：
    ```sh
    sudo systemctl start docker
    ```
    或於應用程式選單中啟動 Docker Desktop（若已安裝）。

- **於 Windows 上：**  
    於「開始」選單啟動 Docker Desktop。

您可透過下列指令確認 Docker 是否運行中：
```sh
docker info
```
若能看到 Docker 安裝資訊，即表示運行正常。

請參閱下方 [本地供應者列表](#list-of-local-providers) 取得摘要。

下一步：[本地運行 AgenticSeek](#start-services-and-run)

*若有問題，請參閱 [疑難排解](#troubleshooting) 小節。*
*若您的硬體無法本地運行 LLM，請參閱 [API 運行設定](#setup-to-run-with-an-api)。*
*有關 `config.ini` 詳細說明，請見 [設定說明](#config)。*

---

## 在本機運行 LLM 的設定

**硬體需求：**

若要本地運行 LLM，需具備足夠硬體。最低需能運行 Magistral、Qwen 或 Deepseek 14B 的 GPU。詳細模型/效能建議請參見 FAQ。

**設定本地供應者**  

啟動您的本地供應者，例如用 ollama：

```sh
ollama serve
```

下方列出所有受支援的本地供應者。

**更新 config.ini**

修改 config.ini 檔案，將 provider_name 設為受支援的供應者，provider_model 設為該供應者支援的 LLM。我們推薦如 *Magistral* 或 *Deepseek* 等推理模型。

有關硬體需求請參見本文件結尾的 **FAQ**。

```sh
[MAIN]
is_local = True # 無論是本地還是遠端運行
provider_name = ollama # 或 lm-studio、openai 等
provider_model = deepseek-r1:14b # 選擇適合您硬體的模型
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # 您的 AI 名稱
recover_last_session = True # 是否恢復上次工作階段
save_session = True # 是否記住目前工作階段
speak = False # 文字轉語音
listen = False # 語音轉文字，僅限 CLI，實驗性
jarvis_personality = False # 是否啟用更像 "Jarvis" 的個性（實驗性）
languages = en zh # 支援的語言列表，語音合成將預設第一個語言
[BROWSER]
headless_browser = True # 除非於主機 CLI 運行，否則保持不變
stealth_mode = True # 使用 undetected selenium 降低瀏覽器偵測
```

**注意：**

- `config.ini` 檔案格式不支援註解。
請勿直接複製貼上範例設定，註解將導致錯誤。請手動編輯 `config.ini`，移除所有註解後再保存。

- 若使用 LM-studio 運行 LLM，請*勿*將 provider_name 設為 `openai`，而要設為 `lm-studio`。

- 某些供應者（如 lm-studio）要求 IP 前需加上 `http://`，例如：`http://127.0.0.1:1234`

**本地供應者列表**

| 供應者    | 本地？ | 說明                                                         |
|-----------|--------|-------------------------------------------------------------|
| ollama    | 是     | 使用 ollama 作為 LLM 供應者，本地輕鬆運行 LLM                |
| lm-studio | 是     | 使用 LM studio 本地運行 LLM（`provider_name` 設為 `lm-studio`）|
| openai    | 是     | 使用 openai 相容 API（如 llama.cpp server）                   |

下一步：[啟動服務並運行 AgenticSeek](#Start-services-and-Run)  

*若有問題，請參閱 [疑難排解](#troubleshooting) 小節。*
*若您的硬體無法本地運行 LLM，請參閱 [API 運行設定](#setup-to-run-with-an-api)。*
*有關 `config.ini` 詳細說明，請見 [設定說明](#config)。*

## 使用 API 運行的設定

此方式採用外部雲端 LLM 供應者。您需從所選服務取得 API 金鑰。

**1. 選擇 API 供應者並取得 API 金鑰：**

請參閱下方 [API 供應者列表](#list-of-api-providers)。造訪相關網站註冊並取得 API 金鑰。

**2. 將 API 金鑰設為環境變數：**

*   **Linux/macOS：**
    開啟終端機，使用 `export` 指令。建議將其加入 shell 的設定檔（如 `~/.bashrc`、`~/.zshrc`），以便永久生效。
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # 請將 PROVIDER_API_KEY 替換為具體變數名稱，如 OPENAI_API_KEY、GOOGLE_API_KEY
    ```
    TogetherAI 範例：
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows：**
*   **命令提示字元（僅限目前工作階段暫時設定）：**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell（僅限目前工作階段暫時設定）：**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **永久設定：** 在 Windows 搜尋列輸入「環境變數」，點擊「編輯系統環境變數」，再點選「環境變數...」按鈕。新增一個使用者變數，名稱（例如 `OPENAI_API_KEY`）和你的金鑰作為值。

*（詳見常見問題：[如何設定 API 金鑰？](#how-do-i-set-api-keys)）*

**3. 更新 `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # 或 google、deepseek、togetherAI、huggingface
provider_model = gpt-3.5-turbo # 或 gemini-1.5-flash、deepseek-chat、mistralai/Mixtral-8x7B-Instruct-v0.1 等
provider_server_address = # 當 is_local = False 時，通常可忽略或留白，適用於大多數 API
# ... 其他設定 ...
```
*警告：* 請確保 `config.ini` 的值末尾沒有空格。

**API 提供商列表**

| 提供商        | `provider_name`   | 本地？ | 說明                                               | API 金鑰連結（範例）                                |
|--------------|-------------------|--------|----------------------------------------------------|------------------------------------------------------|
| OpenAI       | `openai`          | 否     | 透過 OpenAI API 使用 ChatGPT 模型。                 | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini| `google`          | 否     | 透過 Google AI Studio 使用 Google Gemini 模型。     | [aistudio.google.com/keys](https://aistudio.google.com/keys)     |
| Deepseek     | `deepseek`        | 否     | 透過他們的 API 使用 Deepseek 模型。                 | [platform.deepseek.com](https://platform.deepseek.com)           |
| Hugging Face | `huggingface`     | 否     | 透過 Hugging Face Inference API 使用模型。          | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI   | `togetherAI`      | 否     | 透過 TogetherAI API 使用多種開源模型。              | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*注意：*
*   建議不要在複雜的網頁瀏覽和任務規劃中使用 `gpt-4o` 或其他 OpenAI 模型，目前提示詞最佳化主要針對 Deepseek 等模型。
*   使用 Gemini 進行程式碼/bash 任務可能會遇到問題，因為其格式化回應不一定嚴格遵循針對 Deepseek 最佳化的提示。
*   當 `is_local = False` 時，`config.ini` 的 `provider_server_address` 一般不需要設定，API 端點通常已在各自的提供商函式庫中硬編碼。

下一步：[啟動服務並運行 AgenticSeek](#Start-services-and-Run)

*如果遇到問題，請參閱 **已知問題** 章節*

*完整的設定檔說明，請參閱 **Config** 章節。*

---

## 啟動服務並運行

預設情況下，AgenticSeek 完全在 docker 中運行。

啟動所需服務。這會從 docker-compose.yml 啟動所有服務，包括：
    - searxng
    - redis（searxng 所需）
    - frontend
    - backend（若使用 `full`）

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**警告：** 此步驟將下載並載入所有 Docker 映像檔，可能需要高達 30 分鐘。啟動服務後，請等到 backend 服務完全運行（你應該會在日誌中看到 **backend: "GET /health HTTP/1.1" 200 OK**）再發送任何訊息。backend 服務初次啟動可能需要 5 分鐘。

打開 `http://localhost:3000/`，你應該會看到網頁介面。

*服務啟動故障排除：* 如果這些腳本執行失敗，請確保 Docker Engine 已啟動，且 Docker Compose（V2，`docker compose`）已正確安裝。請檢查終端機輸出以獲取錯誤訊息。詳見 [常見問題：執行 AgenticSeek 或其腳本時出錯怎麼辦？](#faq-troubleshooting)

**可選：** 在主機運行（CLI 模式）：

若要使用 CLI 介面，必須在主機安裝套件：

```sh
./install.sh
./install.bat # windows
```

啟動服務：

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

使用 CLI：`python3 cli.py`

---

## 使用方式

請確保服務已經使用 `./start_services.sh full` 啟動，並前往 `localhost:3000` 使用網頁介面。

你也可以在設定檔中將 `listen = True` 來啟用語音轉文字（僅 CLI 模式）。

要離開，只需說/輸入 `goodbye`。

以下是一些使用範例：

> *用 python 做一個貪食蛇遊戲！*

> *搜尋網路上法國雷恩（Rennes）最棒的咖啡館，並將三家含地址保存於 rennes_cafes.txt。*

> *寫一個 Go 程式來計算一個數的階乘，並儲存為 factorial.go 於你的工作目錄*

> *搜尋我的 summer_pictures 資料夾內所有 JPG 檔案，將它們以今天日期重新命名，並將重新命名的檔案列表儲存於 photos_list.txt*

> *線上搜尋 2024 年熱門科幻電影，挑三部今晚要看。將片單儲存於 movie_night.txt。*

> *搜尋 2025 年最新 AI 新聞文章，選三篇，寫一個 Python 程式抓取其標題與摘要。將程式碼保存為 news_scraper.py，摘要存於 /home/projects 的 ai_news.txt*

> *週五，搜尋網路免費股票價格 API，使用 supersuper7434567@gmail.com 註冊，再寫一支 Python 腳本每天用 API 取得特斯拉股價，結果存於 stock_prices.csv*

*請注意，表單自動填寫功能仍屬實驗性，可能會失敗。*

當你輸入查詢後，AgenticSeek 會分配最佳代理來執行該任務。

由於這是早期原型，代理分流系統根據查詢分配的代理可能不是最合適的。

因此，請儘量明確說明你要做什麼，以及 AI 應該如何操作。例如，如果你想讓它進行網路搜尋，請不要這樣說：

`你知道哪些國家適合單獨旅行嗎？`

而要這樣問：

`請搜尋網路並找出最適合單獨旅行的國家`

---

## **設定在自己的伺服器上運行 LLM**  

如果你有一台強大的電腦或伺服器想要運行模型，但又想從筆電遠端使用，你可以透過自訂的 llm server 在遠端伺服器運行 LLM。

在將要運行 AI 模型的「伺服器」上，獲取 IP 位址

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # 本機 ip
curl https://ipinfo.io/ip # 公網 ip
```

注意：Windows 或 macOS 請分別使用 ipconfig 或 ifconfig 查詢 IP 位址。

複製專案並進入 `server/` 資料夾。

```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

安裝伺服器專用套件：

```sh
pip3 install -r requirements.txt
```

執行伺服器腳本。

```sh
python3 app.py --provider ollama --port 3333
```

你可以選擇使用 `ollama` 或 `llamacpp` 作為 LLM 服務。

現在在你的個人電腦上：

修改 `config.ini` 檔案，將 `provider_name` 設為 `server`，`provider_model` 設為 `deepseek-r1:xxb`。
把 `provider_server_address` 設成運行模型機器的 IP 位址。

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```

下一步：[啟動服務並運行 AgenticSeek](#Start-services-and-Run)

---

## 語音轉文字

警告：目前語音轉文字僅支援 CLI 模式。

請注意，目前語音轉文字僅支援英文。

語音轉文字功能預設為關閉。若要啟用，請在 config.ini 檔案中將 listen 選項設為 True：

```
listen = True
```

啟用後，語音轉文字會在你說出觸發關鍵字（即代理名稱）後開始接收輸入。你可以在 *config.ini* 檔案中修改 `agent_name` 來自訂代理名稱：

```
agent_name = Friday
```

為了最佳辨識效果，我們建議使用常見的英文名字作為 agent 名稱，例如 "John" 或 "Emma"

當你看到逐字稿開始出現時，請大聲說出 agent 的名字來喚醒它（例如："Friday"）。

清楚地說出你的查詢內容。

請在請求結尾使用確認語句，讓系統知道可以繼續執行。確認語句的範例包括：
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## 設定檔 Config

設定範例：
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Ollama 範例；LM-Studio 請用 http://127.0.0.1:1234
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # TTS 及路由語言清單
[BROWSER]
headless_browser = False
stealth_mode = False
```

**`config.ini` 設定說明**：

*   **`[MAIN]` 區段:**
    *   `is_local`：如果使用本地 LLM 供應商（Ollama、LM-Studio、本地 OpenAI 相容伺服器）或自架伺服器，請設為 `True`。若使用雲端 API（OpenAI、Google 等）請設為 `False`。
    *   `provider_name`：指定 LLM 供應商名稱。
        *   本地選項：`ollama`、`lm-studio`、`openai`（本地 OpenAI 相容伺服器）、`server`（自架伺服器）。
        *   API 選項：`openai`、`google`、`deepseek`、`huggingface`、`togetherAI`。
    *   `provider_model`：所選供應商的具體模型名稱或 ID（如 Ollama 的 `deepseekcoder:6.7b`，OpenAI API 的 `gpt-3.5-turbo`，TogetherAI 的 `mistralai/Mixtral-8x7B-Instruct-v0.1`）。
    *   `provider_server_address`：LLM 供應商伺服器位址。
        *   本地供應商範例：Ollama 請用 `http://127.0.0.1:11434`，LM-Studio 請用 `http://127.0.0.1:1234`。
        *   `server` 類型：填寫自架 LLM 伺服器地址（如 `http://your_server_ip:3333`）。
        *   雲端 API（`is_local = False`）：此欄多半可忽略，API 端點通常由客戶端處理。
    *   `agent_name`：AI 助手名稱（如 Friday）。啟用語音辨識時用作觸發詞。
    *   `recover_last_session`：設為 `True` 則嘗試回復前次狀態，`False` 則重新開始。
    *   `save_session`：設為 `True` 則儲存目前會話以便回復，否則為 `False`。
    *   `speak`：設為 `True` 開啟文字轉語音輸出，否則關閉。
    *   `listen`：設為 `True` 開啟語音辨識輸入（僅限 CLI 模式），否則關閉。
    *   `work_dir`：**重要：** AgenticSeek 讀寫檔案的目錄。**請確保此路徑在你的系統上有效且可存取。**
    *   `jarvis_personality`：`True` 使用更像 Jarvis 的提示詞（實驗性），`False` 則為標準提示。
    *   `languages`：逗號分隔的語言清單（如 `en, zh, fr`）。TTS 語音選擇（預設第一個），也可協助 LLM 路由。路由效率建議避免太多或太相似語言。
*   **`[BROWSER]` 區段:**
    *   `headless_browser`：設為 `True` 則無視窗運行自動化瀏覽器（推薦於網頁介面或非互動用途）。`False` 則顯示瀏覽器視窗（適用於 CLI 模式或除錯）。
    *   `stealth_mode`：`True` 啟用反偵測瀏覽器自動化，可能需手動安裝如 anticaptcha 等瀏覽器擴充套件。

本段落總結支援的 LLM 供應商類型。請於 `config.ini` 設定。

**本地供應商（在你自己的硬體執行）：**

| `config.ini` 供應商名稱       | `is_local` | 說明                                                                   | 相關設定章節                                                                    |
|-------------------------------|------------|------------------------------------------------------------------------|--------------------------------------------------------------------------------|
| `ollama`                      | `True`     | 使用 Ollama 服務本地 LLM。                                             | [本地執行 LLM 設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | 使用 LM-Studio 服務本地 LLM。                                          | [本地執行 LLM 設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `openai`（本地伺服器）        | `True`     | 連接本地 OpenAI 相容 API 伺服器（如 llama.cpp）。                      | [本地執行 LLM 設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | 連接運行於其他主機的 AgenticSeek 自架 LLM 伺服器。                     | [自架伺服器 LLM 設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-the-llm-on-your-own-server) |

**API 供應商（雲端）：**

| `config.ini` 供應商名稱       | `is_local` | 說明                                            | 相關設定章節                                                                |
|-------------------------------|------------|-------------------------------------------------|----------------------------------------------------------------------------|
| `openai`                      | `False`    | 使用 OpenAI 官方 API（如 GPT-3.5、GPT-4）。      | [API 運行設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `google`                      | `False`    | 使用 Google 的 Gemini 模型 API。                | [API 運行設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | 使用 Deepseek 官方 API。                        | [API 運行設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | 使用 Hugging Face 推論 API。                    | [API 運行設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | 使用 TogetherAI API 支援多種開放模型。           | [API 運行設定](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#setup-to-run-with-an-api) |

---
## 疑難排解

如遇問題請參考本節說明。

# 已知問題

## ChromeDriver 問題

**錯誤範例：** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **原因：** 你安裝的 ChromeDriver 版本與 Google Chrome 瀏覽器版本不相容。
*   **解決方式：**
    1.  **檢查 Chrome 版本：** 開啟 Google Chrome，至 `設定 > 關於 Chrome` 查詢版本（如 "版本 120.0.6099.110"）。
    2.  **下載對應的 ChromeDriver：**
        *   Chrome 115 版以上：至 [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/) 查詢 "stable" 頻道，下載對應你作業系統與 Chrome 主版本的 ChromeDriver。
        *   舊版（較少見）：可至 [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads) 尋找。
        *   下圖為 CfT 頁面範例：
            ![從 Chrome for Testing 頁面下載指定版本 Chromedriver](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **安裝 ChromeDriver：**
        *   請將下載的 `chromedriver`（Windows 為 `chromedriver.exe`）放到系統 PATH 目錄（如 Linux/macOS 的 `/usr/local/bin`，或 Windows 的自訂腳本資料夾）。
        *   或直接放在 `agenticSeek` 專案根目錄。
        *   確保驅動程式具有執行權限（如 Linux/macOS 執行 `chmod +x chromedriver`）。
    4.  詳細請參考主安裝指南內 [ChromeDriver 安裝說明](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/#chromedriver-installation)。

若本節說明不足或遇到其他 ChromeDriver 問題，請搜尋 [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) 或提出新問題。

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

當你的瀏覽器與 chromedriver 版本不符時會發生此錯誤。

你需要前往下載最新版本：

https://developer.chrome.com/docs/chromedriver/downloads

若你使用 Chrome 115 以上，請前往：

https://googlechromelabs.github.io/chrome-for-testing/

下載與你作業系統相符的 chromedriver 版本。

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

如本節說明不足請提出 issue。

##  connection adapters 問題

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (注意：port 可能不同)
```

*   **原因：** `config.ini` 內 `lm-studio`（或其他本地 OpenAI 相容伺服器）的 `provider_server_address` 缺少 `http://` 前綴或連到錯誤的埠號。
*   **解決方式：**
    *   請確保地址包含 `http://`。LM-Studio 預設為 `http://127.0.0.1:1234`。
    *   正確設定 `config.ini`：`provider_server_address = http://127.0.0.1:1234`（或你的實際伺服器埠號）。

## 未提供 SearxNG Base URL

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## 常見問題 FAQ

**Q: 我需要什麼硬體？**  

| 模型大小   | GPU          | 說明                                               |
|-----------|--------------|----------------------------------------------------|
| 7B        | 8GB Vram     | ⚠️ 不建議。效能不佳，易產生幻覺，規劃型 agent 可能失敗。|
| 14B       | 12GB Vram (如 RTX 3060) | ✅ 簡單任務可用。瀏覽網頁與規劃可能吃力。          |
| 32B       | 24GB 以上 Vram (如 RTX 4090) | 🚀 大多數任務可成功，規劃型任務仍有挑戰。       |
| 70B+      | 48GB 以上 Vram | 💪 極佳。推薦進階使用情境。                         |

**Q: 出現錯誤怎麼辦？**  

請確認本地服務（`ollama serve`）正常，`config.ini` 與供應商相符，且相關依賴已安裝。如皆無效歡迎提出 issue。

**Q: 能否 100% 本地執行？**  

可以，使用 Ollama、lm-studio 或 server 供應商時，語音辨識、LLM、文字轉語音皆於本地運行。非本地（OpenAI 等 API）選項為可選。

**Q: 已有 Manus，為什麼還要用 AgenticSeek？**

AgenticSeek 強調對外部系統的獨立性，讓你有更多控制權、隱私保障且避免 API 成本。

**Q: 專案是由誰維護？**

專案由我本人與兩位在 GitHub 開源社群活躍的朋友共同維護。我們只是熱愛開發的個人，並非新創公司或組織成員。

除了我的個人帳號（https://x.com/Martin993886460）以外，任何 AgenticSeek 在 X 上的帳戶皆為冒名。

## 貢獻

我們歡迎開發者參與改進 AgenticSeek！請參考 open issues 或討論區。

[貢獻指南](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## 維護者：

 > [Fosowl](https://github.com/Fosowl) | 巴黎時間 

 > [antoineVIVIES](https://github.com/antoineVIVIES) | 台北時間 

 > [steveh8758](https://github.com/steveh8758) | 台北時間 

## 特別感謝：

 > [tcsenpai](https://github.com/tcsenpai) 和 [plitc](https://github.com/plitc) 協助後端 Docker 化

## 贊助者：

每月贊助 5 美元或以上會顯示於此：
- **tatra-labs**

Sorry, but I need the content of Part 4 of 4 in order to translate it. Please provide the text you want translated.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---