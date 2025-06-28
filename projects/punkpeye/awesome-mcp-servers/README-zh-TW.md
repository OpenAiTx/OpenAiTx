# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

精選的 Model Context Protocol (MCP) 伺服器清單。

* [什麼是 MCP？](#what-is-mcp)
* [客戶端](#clients)
* [教學](#tutorials)
* [社群](#community)
* [圖例說明](#legend)
* [伺服器實作](#server-implementations)
* [框架](#frameworks)
* [技巧與提示](#tips-and-tricks)

## 什麼是 MCP？

[MCP](https://modelcontextprotocol.io/) 是一個開放協議，使 AI 模型能夠透過標準化的伺服器實作，安全地與本地及遠端資源互動。此清單聚焦於生產就緒與實驗性的 MCP 伺服器，這些伺服器可透過檔案存取、資料庫連線、API 整合及其他情境服務來擴展 AI 能力。

## 客戶端

請參閱 [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) 與 [glama.ai/mcp/clients](https://glama.ai/mcp/clients)。

> [!TIP]
> [Glama Chat](https://glama.ai/chat) 是一個支援 MCP 的多模態 AI 客戶端，並提供 [AI gateway](https://glama.ai/gateway)。

## 教學

* [Model Context Protocol (MCP) 快速入門](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [設定 Claude 桌面應用程式使用 SQLite 資料庫](https://youtu.be/wxCCzo9dGj0)

## 社群

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Discord 伺服器](https://glama.ai/mcp/discord)

## 圖例說明

* 🎖️ – 官方實作
* 程式語言
  * 🐍 – Python 程式庫
  * 📇 – TypeScript（或 JavaScript）程式庫
  * 🏎️ – Go 程式庫
  * 🦀 – Rust 程式庫
  * #️⃣ - C# 程式庫
  * ☕ - Java 程式庫
  * 🌊 – C/C++ 程式庫
* 適用範圍
  * ☁️ - 雲端服務
  * 🏠 - 本地服務
  * 📟 - 嵌入式系統
* 作業系統
  * 🍎 – 適用於 macOS
  * 🪟 – 適用於 Windows
  * 🐧 - 適用於 Linux

> [!NOTE]
> 分不清本地 🏠 與雲端 ☁️？
> * 當 MCP 伺服器與本機安裝的軟體（如控制 Chrome 瀏覽器）互動時，請使用本地。
> * 當 MCP 伺服器與遠端 API（如天氣 API）互動時，請使用網路。

## 伺服器實作

> [!NOTE]
> 現在有一個 [網頁版目錄](https://glama.ai/mcp/servers) 與本儲存庫同步。

* 🔗 - [匯總器](#aggregators)
* 🎨 - [藝術與文化](#art-and-culture)
* 📂 - [瀏覽器自動化](#browser-automation)
* ☁️ - [雲端平台](#cloud-platforms)
* 👨‍💻 - [程式碼執行](#code-execution)
* 🤖 - [程式碼代理人](#coding-agents)
* 🖥️ - [命令列](#command-line)
* 💬 - [通訊](#communication)
* 👤 - [客戶資料平台](#customer-data-platforms)
* 🗄️ - [資料庫](#databases)
* 📊 - [資料平台](#data-platforms)
* 🚚 - [配送](#delivery)
* 🛠️ - [開發者工具](#developer-tools)
* 🧮 - [資料科學工具](#data-science-tools)
* 📟 - [嵌入式系統](#embedded-system)
* 📂 - [檔案系統](#file-systems)
* 💰 - [金融與金融科技](#finance--fintech)
* 🎮 - [遊戲](#gaming)
* 🧠 - [知識與記憶](#knowledge--memory)
* 🗺️ - [定位服務](#location-services)
* 🎯 - [行銷](#marketing)
* 📊 - [監控](#monitoring)
* 🎥 - [多媒體處理](#multimedia-process)
* 🔎 - [搜尋與資料擷取](#search)
* 🔒 - [安全](#security)
* 🌐 - [社群媒體](#social-media)
* 🏃 - [體育](#sports)
* 🎧 - [支援與服務管理](#support-and-service-management)
* 🌎 - [翻譯服務](#translation-services)
* 🎧 - [文字轉語音](#text-to-speech)
* 🚆 - [旅遊與交通運輸](#travel-and-transportation)
* 🔄 - [版本控制](#version-control)
* 🛠️ - [其他工具與整合](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>聚合器

可通過單一 MCP 伺服器存取多個應用與工具的伺服器。

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - 只需一個執行檔即可用 SQL 查詢超過 40 款應用。也可連接 PostgreSQL、MySQL 或 SQLite 相容資料庫。本地優先，設計上即重視隱私。
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP 是唯一統一的中介軟體 MCP 伺服器，透過 GUI 管理您的 MCP 連線。
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - 利用 [MindsDB 作為單一 MCP 伺服器](https://docs.mindsdb.com/mcp/overview) 連接並統一各平台和資料庫。
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - MCP 伺服器清單，可詢問客戶端哪些伺服器可用，以提升日常工作流程。
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - 10 秒內將網頁 API 變成 MCP 伺服器，並加入開源註冊中心：https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - 連接 2,500 個 API，8,000+ 預建工具，並在您的應用內為用戶管理伺服器。
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - 綜合性代理伺服器，將多個 MCP 伺服器合併為單一介面，具備豐富的可視化功能。可跨伺服器發現與管理工具、提示、資源與範本，並提供調試遊樂場協助 MCP 伺服器開發。
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - 一個代理工具，將多個 MCP 伺服器組合成單一統一端點。類似 Nginx 於網頁伺服器，透過負載平衡請求擴展 AI 工具。
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP 是唯一統一的中介軟體 MCP 伺服器，透過 GUI 管理您的 MCP 連線。
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - 無縫安全地將 Claude Desktop 及其他 MCP 主機連接到您最愛的應用（如 Notion、Slack、Monday、Airtable 等），僅需不到 90 秒。
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - 一鍵將網路服務變成 MCP 伺服器，無需修改程式碼。
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - 利用 Google Imagen 3.0 API 的強大圖像生成工具，透過 MCP 由文字提示產生高品質圖片，具備進階攝影、藝術與寫實控制。
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - OpenAI GPT 圖像生成/編輯 MCP 伺服器。

### 🎨 <a name="art-and-culture"></a>藝術與文化

存取與探索藝術藏品、文化遺產及博物館資料庫。讓 AI 模型可搜尋與分析藝術及文化內容。

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - 一個以 Manim 產生動畫的本地 MCP 伺服器。
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - 新增、分析、搜尋及產生您影片叢林收藏的影片剪輯
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - 用於與 Discogs API 互動的 MCP 伺服器
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ 透過官方 REST API v4 與 Quran.com 語料互動的 MCP 伺服器。
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - 大都會藝術博物館典藏 API 整合，可搜尋與顯示館藏藝術品。
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - 國家博物館 API 整合，支援藝術品搜尋、細節與收藏
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Oorlogsbronnen（戰爭來源）API 整合，存取荷蘭二戰（1940-1945）歷史記錄、照片與文件
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - DaVinci Resolve 的 MCP 伺服器整合，提供強大的影片剪輯、調色、媒體管理與專案控制工具
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - 整合 AniList API 的 MCP 伺服器，可查詢動漫與漫畫資訊
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - 使用 Aseprite API 創作像素藝術的 MCP 伺服器
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - MCP 伺服器與擴充，可自然語言控制 NVIDIA Isaac Sim、Lab、OpenUSD 等。
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Open Library API 的 MCP 伺服器，讓 AI 助理可搜尋圖書資訊。
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Autodesk Maya 的 MCP 伺服器
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - 提供完整且準確的八字命盤排盤與分析


### 📂 <a name="browser-automation"></a>瀏覽器自動化

網頁內容存取與自動化功能。可以 AI 友善格式搜尋、擷取及處理網頁內容。

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - 基於 FastMCP 的工具，取得 B 站熱門影片並以標準 MCP 介面提供。
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - 支援搜尋 B 站內容的 MCP 伺服器。提供 LangChain 整合範例與測試腳本。
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - 內建 MCP 與 A2A 支援的自架代理型瀏覽器。
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - 基於 Playwright 的瀏覽器自動化 MCP 伺服器
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - 以 Playwright 實現的 MCP python 伺服器，更適合 llm 使用的瀏覽器自動化
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - 雲端自動化瀏覽器互動（如網頁導航、資料擷取、表單填寫等）
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - 自動化您的本地 Chrome 瀏覽器
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - 封裝 browser-use 為 MCP 伺服器，採 SSE 傳輸，內含 Dockerfile 運行 Chromium + VNC 伺服器。
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - 基於 Playwright 的 MCP 伺服器，支援瀏覽器自動化與網頁抓取
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - 搭配瀏覽器擴充元件的 MCP 伺服器，讓 LLM 客戶端可控制用戶瀏覽器（Firefox）。
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - 用於 macOS Apple 提醒事項互動的 MCP 伺服器
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - 從任意網站提取結構化資料。只需提示即獲得 JSON。
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - 取得 YouTube 字幕與逐字稿，供 AI 分析
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - 使用 Azure OpenAI 與 Playwright 的 `極簡` 伺服器/客戶端 MCP 實現。
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - 微軟官方 Playwright MCP 伺服器，讓 LLM 可透過結構化無障礙快照與網頁互動
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - 瀏覽器自動化，支援網頁抓取與互動
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - 與 manifest v2 相容瀏覽器互動的 MCP 伺服器。
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - 讓 MCP 伺服器可免 API 金鑰進行 Google 網頁搜尋，支援免費網頁搜索。
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - 與 Apple 捷徑整合的 MCP 伺服器

### ☁️ <a name="cloud-platforms"></a>雲端平台

雲端平台服務整合。可管理與操作雲端基礎設施與服務。

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWS MCP 伺服器，無縫整合 AWS 服務與資源。
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - 基於七牛雲產品的 MCP，支援存取七牛雲儲存、媒體處理服務等。
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - IPFS 儲存上傳與操作
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Kubernetes Model Context Protocol (MCP) 伺服器，透過標準介面提供 Kubernetes 叢集互動工具，包括 API 資源探索、資源管理、Pod 日誌、監控與事件。
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - 用於查詢圖書的 MCP 伺服器，可應用於常見 MCP 客戶端，如 Cherry Studio。
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - 輕量但強大的伺服器，讓 AI 助理可在多架構支援的安全 Docker 環境下執行 AWS CLI 指令、Unix pipe，並套用常用 AWS 任務的提示範本。
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - 輕量但強大的伺服器，讓 AI 助理可在安全 Docker 環境下安全執行 Kubernetes CLI（`kubectl`、`helm`、`istioctl`、`argocd`）並支援多架構。
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - 讓 AI 助理可操作阿里雲資源的 MCP 伺服器，支援 ECS、雲監控、OOS 及多種常用雲產品。
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - 基於 MCP（Model Control Protocol）的 VMware ESXi/vCenter 管理伺服器，提供虛擬機管理的簡單 REST API 介面。
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - 整合 Cloudflare 服務，包括 Workers、KV、R2 與 D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - 透過 Cyclops 抽象化讓 AI 代理人管理 Kubernetes 資源的 MCP 伺服器
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - 整合 Fastly 服務
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - 用 Typescript 實作的 Kubernetes 叢集 Pod、部署、服務操作。
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - 基於 Model Context Protocol 的伺服器，使用 Azure Resource Graph 大規模查詢與分析 Azure 資源，讓 AI 助理可探索與監控 Azure 基礎設施。
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Azure CLI 指令列包裝器，讓您可直接與 Azure 對話
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - MCP，可存取 Netskope Private Access 環境內所有元件，包含詳細設定說明與 LLM 使用範例。
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - 強大的 Kubernetes MCP 伺服器，額外支援 OpenShift。除支援**任意** Kubernetes 資源 CRUD 操作，還提供叢集互動專用工具。
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Terraform MCP 伺服器，讓 AI 助理可管理與操作 Terraform 環境，支援讀取設定、分析計劃、套用設定、管理狀態。
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - 利用 Pulumi Automation API 與 Pulumi Cloud API 操作 Pulumi 的 MCP 伺服器。讓 MCP 客戶端可程式化執行如套件資訊查詢、變更預覽、部署更新、查詢 Stack 輸出等操作。
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Kubernetes 的 Model Context Protocol (MCP) 伺服器，讓 AI 助理（如 Claude、Cursor 等）可以自然語言操作 Kubernetes 叢集。
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - 透過 MCP 執行 Kubernetes 叢集操作
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Go 語言實作的 MCP 伺服器，介接 Nutanix Prism Central 資源。
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - 一次取得最新 EC2 價格資訊。快速。以預先解析的 AWS 價格目錄為基礎。
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - 提供 MCP 多叢集 Kubernetes 管理與操作，內建管理介面、日誌，以及近 50 種內建工具，涵蓋常見 DevOps 與開發場景。支援標準與 CRD 資源。
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - 提供 MCP 多叢集 Kubernetes 管理與操作。可作為 SDK 整合進您自己的專案，內建近 50 種工具，涵蓋常見 DevOps 與開發場景。支援標準與 CRD 資源。
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - 用於 Kubernetes 管理的 MCP 伺服器，並可分析您的叢集及應用程式健康狀況。
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - 用於 Azure Data Lake Storage 的 MCP 伺服器。可對容器檔案進行管理、讀寫、上傳/下載操作並管理檔案中繼資料。
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S 是一款 AI 驅動的 Kubernetes 資源管理工具，允許用戶透過自然語言互動操作 Kubernetes 叢集中的任何資源，包括原生資源（如 Deployment、Service）及自定義資源（CRD）。無需記憶複雜指令，只需描述需求，AI 即可精確執行對應的叢集操作，大幅提升 Kubernetes 的易用性。
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - 使用自然語言輕鬆管理您的 Redis Cloud 資源。可建立資料庫、監控訂閱及用簡單指令設定雲端部署。
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - 強大的 MCP 伺服器，讓 AI 助手無縫互動 Portainer 實例，提供容器管理、部署操作與基礎設施監控的自然語言存取能力。

### 👨‍💻 <a name="code-execution"></a>程式碼執行

程式碼執行伺服器。允許 LLMs 在安全環境下執行程式碼，例如用於程式代理。

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- 透過 MCP 工具呼叫，在安全沙箱中執行 Python 程式碼
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - 在安全且可擴展的沙箱環境中執行任何 LLM 產生的程式碼，並用 JavaScript 或 Python 創建自己的 MCP 工具，完全支援 NPM 與 PyPI 套件
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP：Docker 化 MCP 伺服器，允許您的 AI 代理存取具備 API 文件的任何 API。
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – 一款 Node.js MCP 伺服器，可啟動基於 Docker 的隔離沙箱，動態安裝 npm 依賴並執行 JavaScript 程式片段，執行完自動清理。
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - 使用 v8 隔離程式碼，在本地安全執行 AI 產生的 JavaScript，支援堆積快照以持久化工作階段的 JavaScript 程式碼執行沙箱。

### 🤖 <a name="coding-agents"></a>程式代理

完整程式代理，讓 LLM 能夠完全自主讀取、編輯、執行程式碼並解決一般程式任務。

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - 功能完善的程式代理，透過語言伺服器進行符號式程式操作。
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - 具備基本讀取、寫入和命令列工具的程式代理。
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - 允許 AI 模型搜尋、檢索並解決 LeetCode 題目的 MCP 伺服器。支援中繼資料過濾、用戶檔案、提交及競賽資料存取。
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - 使自動化存取 **LeetCode** 程式題、解答、提交和公開資料成為可能的 MCP 伺服器，並可選擇用戶驗證以支援個人化功能（如筆記），支援 `leetcode.com`（全球）和 `leetcode.cn`（中國）站點。
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - 允許如 Claude 等 AI 讀取 VS Code 專案目錄結構、檢視 Linter 或語言伺服器偵測的問題、讀取程式檔案並進行編輯的 MCP 伺服器。
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - 單一可執行檔的 MCP 伺服器，將原始程式碼轉換為 AST，支援各種語言。

### 🖥️ <a name="command-line"></a>命令列

執行命令、擷取輸出並與 Shell 及命令列工具互動。

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - 一款為 iTerm 提供存取的 Model Context Protocol 伺服器。可執行命令並查詢 iTerm 終端機中所見內容。
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - 使用 `run_command` 與 `run_script` 工具執行任何命令。
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - 基於 HF Smolagents `LocalPythonExecutor` 的安全 Python 直譯器
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - 具備安全執行與可自訂安全政策的命令列介面
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - DeepSeek MCP 類終端機伺服器
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - 一款實作 Model Context Protocol (MCP) 的安全 Shell 命令執行伺服器
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - 使結構化、模型驅動互動網路設備成為可能的 Cisco pyATS 伺服器。
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - 一款萬用工具，可管理/執行程式並讀寫/搜尋/編輯程式與文字檔案。
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - 透過 Model Context Protocol 為 Linux 及 Windows 伺服器提供 SSH 控制的 MCP 伺服器。可用密碼或 SSH 金鑰進行遠端 Shell 命令安全執行。

### 💬 <a name="communication"></a>通訊

與通訊平台整合以進行訊息管理和頻道操作。讓 AI 模型能與團隊通訊工具互動。

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - 允許與 Nostr 互動的 MCP 伺服器，支援發表訊息等功能。
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - 與 Twitter 搜尋及時間軸互動
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - 可即時建立收件匣以收發郵件並採取行動的 MCP 伺服器。我們不是郵件的 AI 代理，而是 AI 代理的郵件。
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - 用於 Google Tasks API 介接的 MCP 伺服器
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - 一款安全介接您 iMessage 資料庫的 MCP 伺服器，讓 LLM 可查詢並分析 iMessage 對話，具備嚴謹的電話號碼驗證、附件處理、聯絡人管理、群聊處理與完整收發訊息支援。
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Telegram API 整合，可存取用戶資料、管理對話（聊天、頻道、群組）、檢索訊息及處理已讀狀態
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Telegram API 整合，可存取用戶資料、管理對話（聊天、頻道、群組）、檢索訊息、傳送訊息及處理已讀狀態。
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - 用於 Inbox Zero 的 MCP 伺服器。為 Gmail 增加如找出需回覆或需跟進郵件的功能。
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - 讓 AI Agents 向自建 ntfy 伺服器發送/取得 ntfy 通知的 MCP 伺服器 📤（支援安全 token 認證等－可用 npx 或 docker 運行！）
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - 一款可向企業微信群機器人發送各類型訊息的 MCP 伺服器應用。
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - 透過 Model Context Protocol (MCP) 安全存取您 iMessage 資料庫的 MCP 伺服器，讓 LLM 查詢及分析對話，並具備電話驗證及附件處理
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - 做為 [ACP](https://agentcommunicationprotocol.dev) 生態系統轉接器的 MCP 伺服器。無縫將 ACP 代理暴露給 MCP 客戶端，串接兩協議間的溝通。
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - 一個 MCP 伺服器及 MCP host，提供 Mattermost 團隊、頻道、訊息存取。MCP host 以 bot 方式整合進 Mattermost，可設定 MCP 伺服器。
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - 搜尋個人 WhatsApp 訊息、聯絡人並向個人或群組發送訊息的 MCP 伺服器
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - 用於整合 LINE 官方帳號的 MCP 伺服器
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - 與 Gmail 及 Google Calendar 整合。
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Bluesky 實例整合，供查詢與互動
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Slack 工作區整合，支援頻道管理與訊息傳遞
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - 最強大的 Slack Workspace MCP 伺服器。
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 這是一款與 VRChat API 互動的 MCP 伺服器。可取得好友、世界、虛擬人偶等資訊。
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - 與 Google Calendar API 介接的 MCP 伺服器。以 TypeScript 實作。
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - 讓你隨時獲得通知，在手機上使用 ntfy 發送通知的 MCP 伺服器
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - 用於 [DIDLogic](https://didlogic.com) 的 MCP 伺服器。可管理 SIP 端點、號碼與目的地。
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - 管理 Google Tasks 的 MCP 伺服器
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - 整合 Microsoft Teams 訊息（讀取、發文、標註、列出成員與討論串）的 MCP 伺服器
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - 透過 Graph API 連接整個 Microsoft 365 套件（含郵件、檔案、Excel、行事曆）的 MCP 伺服器
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - YCloud WhatsApp Business Platform 的 MCP 伺服器。
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Product Hunt 的 MCP 伺服器。可互動熱門貼文、留言、精選集、用戶等。

### 👤 <a name="customer-data-platforms"></a>客戶資料平台

提供存取客戶資料平台內部客戶檔案的能力

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - 連接 [iaptic](https://www.iaptic.com)，查詢您的客戶購買紀錄、交易資料與 App 收入統計。
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - 讓任何 Open Data 透過 Model Context Protocol 與任意 LLM 連接。
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - 存取及更新 Apache Unomi CDP 伺服器上的檔案的 MCP 伺服器。
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - 從任何 MCP 客戶端互動 Tinybird Workspace 的 MCP 伺服器。
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - 使用 [AntV](https://github.com/antvis) 產生可視化圖表的 Model Context Protocol 伺服器。

### 🗄️ <a name="databases"></a>資料庫

安全的資料庫存取與結構檢查能力。允許查詢和分析資料，並具備可配置的安全控管（如唯讀）。

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  瀏覽您的 [Aiven 專案](https://go.aiven.io/mcp-server) 並與 PostgreSQL®、Apache Kafka®、ClickHouse® 及 OpenSearch® 服務互動
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - 支援 SQL 查詢與資料庫瀏覽工具的 Supabase MCP 伺服器
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Tablestore 的 MCP 服務，具備文件新增、基於向量與標量的語意搜尋、RAG 友善及無伺服器等特性。
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - NodeJS 實作的 MySQL 資料庫整合，支援可配置的存取控管與結構檢查
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – 支援主流資料庫的通用 MCP 資料庫伺服器。
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - TiDB 資料庫整合，支援結構檢查與查詢
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Model Context Protocol (MCP) 客戶端與 AI 代理的語意引擎
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - MCP 與 MCP SSE 伺服器，根據資料庫結構與資料自動產生 API。支援 PostgreSQL、Clickhouse、MySQL、Snowflake、BigQuery、Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - DICOM 整合，查詢、讀取並調閱來自 PACS 及其他 DICOM 相容系統的醫療影像與報告。
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Chroma MCP 伺服器，支援本地與雲端 Chroma 實例檢索
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - ClickHouse 資料庫整合，支援結構檢查與查詢
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - 與 Confluent Kafka 及 Confluent Cloud REST API 互動的 Confluent 整合。
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Couchbase MCP 伺服器提供對 Capella 雲端及自管叢集的統一存取，支援文件操作、SQL++ 查詢與自然語言資料分析。
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - 提供 Elasticsearch 互動的 MCP 伺服器實作
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - 一站式 Postgres 開發與運維 MCP 伺服器，內建效能分析、調校及健康檢查工具
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - 用於查詢與存取 Trino 叢集資料的 Trino MCP 伺服器。
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - 一個以 Go 實現的 Trino Model Context Protocol (MCP) 伺服器
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - MySQL 資料庫整合，具可設定存取控制、結構檢查及完整安全指引
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - 支援 SSE、STDIO；不僅限於 MySQL 的 CRUD 功能；同時具備資料庫異常分析能力；可依角色控管資料庫權限；便於開發者自訂擴充工具
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Airtable 資料庫整合，具結構檢查、讀寫能力
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Nocodb 資料庫整合，具讀寫能力
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Google BigQuery 整合伺服器，能直接存取並查詢 BigQuery 資料庫
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - 基於 Node.js 的 MySQL 資料庫整合，提供安全的 MySQL 資料庫操作
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Fireproof 分帳式資料庫，支援多用戶同步
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – 以 Golang 構建的高效能多資料庫 MCP 伺服器，支援 MySQL 及 PostgreSQL（NoSQL 即將支援）。內建查詢執行、交易管理、結構探索、查詢組建及效能分析工具，並與 Cursor 無縫整合以增強資料庫工作流程。
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens：功能完整的 MongoDB MCP 伺服器
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Firebase 服務整合，包括 Auth、Firestore 與 Storage。
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Convex 資料庫整合，可檢視資料表、函式並執行臨時查詢（[原始碼](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts)）
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - 開源 MCP 伺服器，專注於提供簡易、快速且安全的資料庫工具。
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - 用於查詢 GreptimeDB 的 MCP 伺服器。
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - 透過 Model Context Protocol (MCP) 提供安全、唯讀存取 SQLite 資料庫的 MCP 伺服器。此伺服器採用 FastMCP 架構，讓 LLM 能探索並查詢 SQLite 資料庫，具備內建安全機制及查詢驗證。
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - 可對 InfluxDB OSS API v2 執行查詢。
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Snowflake 整合，實作讀取及（選擇性）寫入操作，並可追蹤洞察
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase MCP 伺服器，用於管理與建立 Supabase 專案與組織
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Apache Kafka 與 Timeplus 的 MCP 伺服器。可列出 Kafka 主題、輪詢 Kafka 訊息、將 Kafka 資料儲存本地，並透過 Timeplus 以 SQL 查詢串流資料
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - VikingDB 整合，支援集合與索引介紹、向量存儲及搜尋功能。
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - MongoDB 的 Model Context Protocol 伺服器
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - DuckDB 資料庫整合，具結構檢查及查詢能力
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - BigQuery 資料庫整合，具結構檢查與查詢功能
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - 連接任何支援 JDBC 的資料庫，並執行查詢、插入、更新、刪除等操作。
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - 提供完整 SQLite 資料庫互動能力的 Model Context Protocol (MCP) 伺服器。
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP 伺服器 — 包含查詢 Memgraph 及結構資源工具。
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - PostgreSQL 資料庫整合，具結構檢查及查詢能力
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - 內建分析功能的 SQLite 資料庫操作
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Neo4j 的 Model Context Protocol（執行查詢、知識圖譜記憶、管理 Neo4j Aura 實例）
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — 以 Neon Serverless Postgres 建立與管理 Postgres 資料庫的 MCP 伺服器
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Nile 的 Postgres 平台 MCP 伺服器 — 以 LLM 管理與查詢 Postgres 資料庫、租戶、用戶、驗證
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - 透過 Open Database Connectivity (ODBC) 協議連接通用資料庫管理系統 (DBMS) 的 MCP 伺服器
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - 透過 SQLAlchemy 與 Python ODBC (pyodbc) 連接通用資料庫管理系統 (DBMS) 的 MCP 伺服器
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - 查詢與分析 Azure Data Explorer 資料庫
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ - 查詢與分析開源監控系統 Prometheus。
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - 讓 LLM 管理 Prisma Postgres 資料庫（如建立新資料庫實例或執行結構遷移）。
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Qdrant MCP 伺服器
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - MongoDB 整合，讓 LLM 直接與資料庫互動。
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - 讓 AI 工具直接連接 Airtable，使用自然語言查詢、建立、更新、刪除記錄。功能包括基礎管理、資料表操作、結構操作、記錄過濾及透過標準 MCP 介面進行資料遷移。
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Redis 官方 MCP 伺服器，提供管理與搜尋 Redis 資料的介面。
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - 基於 SQLAlchemy 的通用資料庫整合，支援 PostgreSQL、MySQL、MariaDB、SQLite、Oracle、MS SQL Server 等。具結構與關聯檢查及大型資料集分析能力。
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Pinecone 整合，支援向量搜尋
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - 無伺服器 MariaDB Cloud DB MCP 伺服器。可啟動、刪除、執行 SQL 及與資料庫層級 AI 代理互動，實現精確的 text-2-sql 與對話。
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - 官方 Supabase MCP 伺服器，讓 AI 助理直接連接 Supabase 專案，並執行管理資料表、擷取設定、查詢資料等任務。
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 通用資料庫 MCP 伺服器，支援多種資料庫類型，包括 PostgreSQL、Redshift、CockroachDB、MySQL、RDS MySQL、Microsoft SQL Server、BigQuery、Oracle DB 與 SQLite。
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - TDolphinDB 資料庫整合，具結構檢查及查詢能力
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - MCP 伺服器，將 Weaviate 集合作為知識庫並用作對話記憶儲存。
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — 支援以自然語言查詢從資料庫擷取資料的 MCP 伺服器，採用 XiyanSQL 作為 text-to-SQL LLM。
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - 與 Google Sheets 互動的 Model Context Protocol 伺服器。提供建立、讀取、更新及管理試算表的工具，經由 Google Sheets API 實現。
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Google Sheets API 整合的 MCP 伺服器，具全面讀寫、格式化及工作表管理能力。
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – 易用、零依賴的 MySQL MCP 伺服器，採 Golang 開發，具可設定唯讀模式與結構檢查。
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - 與 [YDB](https://ydb.tech) 資料庫互動的 MCP 伺服器
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Milvus / Zilliz 的 MCP 伺服器，讓資料庫互動成為可能。
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - 透過 Java Database Connectivity (JDBC) 協議連接通用資料庫管理系統 (DBMS) 的 MCP 伺服器
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - 用於與 VictoriaMetrics 資料庫互動的 MCP 伺服器。
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Hydrolix 時序資料湖整合，為基於 LLM 的工作流程提供結構探索與查詢功能。
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – 為 cursor 與 n8n 設計的易用唯讀 mysql mcp 伺服器...


### 📊 <a name="data-platforms"></a>資料平台

資料平台，用於資料整合、轉換與流程協作。

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - 與 Flowcore 互動以執行操作、導入資料、分析、交叉比對並運用你在資料核心（或公共資料核心）的任何資料，全部可用自然語言完成。
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - 連接 Databricks API，允許 LLM 執行 SQL 查詢、列出工作、取得工作狀態。
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - 連接 Databricks Genie API 的伺服器，允許 LLM 以自然語言提問、執行 SQL 查詢並與 Databricks 對話代理互動。
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Qlik Cloud API 的 MCP 伺服器，支援查詢應用程式、工作表及從視覺化中擷取資料，並具備完善的認證與流量限制。
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - 與 Keboola Connection Data Platform 互動。提供列舉與存取 Keboola Storage API 資料的工具。
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - 官方 [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) MCP 伺服器，整合 dbt Core/Cloud CLI，支援專案中繼資料發掘、模型資訊及語意層查詢功能。
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - 適用於 dbt-core (OSS) 用戶的 MCP 伺服器（官方 dbt MCP 僅支援 dbt Cloud）。支援專案中繼資料、模型與欄位層級譜系及 dbt 文件。

### 💻 <a name="developer-tools"></a>開發者工具

提升開發流程與環境管理的工具與整合。

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - 辨識 macOS 上高資源消耗程序，並提供效能改善建議。
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - 創建靈感來自頂尖 21st.dev 設計工程師的精美 UI 元件。
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - 與 [QA Sphere](https://qasphere.com/) 測試管理系統整合，讓 LLM 從 AI IDE 直接發現、摘要並互動測試案例
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - 分析你的程式碼庫，根據相依關係找出重要檔案。生成圖表和重要性分數，協助 AI 助理理解程式碼庫。
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 iOS 模擬器控制的 MCP 伺服器實作。
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 支援查詢與管理 [Apache APISIX](https://github.com/apache/apisix) 所有資源的 MCP 伺服器。
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 - 針對 SonarQube 專案提供一系列工具的 Model Context Protocol (MCP) 伺服器，可取得指標（現況與歷史）、議題、健康狀態等資訊。
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - 與 AI Agent 無縫整合任何 API（支援 OpenAPI 架構）
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - 本地分析 React 程式碼，一次為整個專案產生文件 / llm.txt
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - POX SDN 控制器的 MCP 伺服器，提供網路控制與管理能力。
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - CodeLogic 官方 MCP 伺服器，提供程式碼相依分析、架構風險分析與影響評估工具。
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - 用自然語言探索 Opik 所蒐集的 LLM observability、追蹤與監控資料。
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ 讓 AI Agent 修復 CircleCI 的建置失敗。
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ 讓 AI Agent 修復回報於 [Currents](https://currents.dev) 的 Playwright 測試失敗。
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - 與 [Postman API](https://www.postman.com/postman/postman-public-workspace/) 互動
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - 讓 AI 助理互動 [Flipt](https://flipt.io) 的 feature flags。
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - 讓程式代理直接存取 Figma 資料，協助一站式設計實作。
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - 與 [Firefly](https://firefly.ai) 整合、發現、管理並程式化雲端資源。
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - 透過 MCP 工具，為 LLM 提供特定 Rust crate 最新文件語境，採用語意搜尋（嵌入式）與 LLM 摘要。
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - 提供 Excel 操作伺服器，包括活頁簿建立、資料操作、格式設定及進階功能（圖表、樞紐分析表、公式）。
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - 提供管理 [Higress](https://github.com/alibaba/higress) 閘道器組態與操作的全方位 MCP 伺服器工具。
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - 用於取代 Postman/Insomnia 這類 REST 客戶端的 MCP 伺服器，允許你的 LLM 維護與使用 API 集合。
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - MCP 伺服器，用於與 [Go 的語言伺服器協議 (gopls)](https://github.com/golang/tools/tree/master/gopls) 互動，並獲取進階 Go 程式碼分析功能。
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - 用於與 [Bruno API Client](https://www.usebruno.com/) 互動的 MCP 伺服器。
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - 透過 MCP 以 AI 控制 Android 裝置，支援裝置控制、除錯、系統分析與 UI 自動化，並具備完善的安全框架。
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - 透過 MCP 以 AI 控制 HarmonyOS-next 裝置。支援裝置控制與 UI 自動化。
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - 透過 Gradle Tooling API 進行 Gradle 整合，用於專案檢查、任務執行與測試，並支援逐測試結果回報。
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - 支援多種圖片格式本地壓縮的 MCP 伺服器。
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP 語言伺服器，協助支援 MCP 的客戶端更輕鬆地瀏覽程式碼庫，提供定義查找、引用、重新命名與診斷等語意工具。
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - 用於與 iOS 模擬器互動的 Model Context Protocol (MCP) 伺服器。可取得模擬器資訊、控制 UI 互動並檢查 UI 元素。
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - 支援 LLM 透過自然語言指令與 iOS 模擬器 (iPhone、iPad 等) 互動的 MCP 伺服器。
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - 為 Vercel AI SDK 文件提供 AI 搜尋與查詢能力的 Model Context Protocol (MCP) 伺服器。
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - 提供 SQL 分析、語法檢查與方言轉換的 MCP 伺服器，使用 [SQLGlot](https://github.com/tobymao/sqlglot)。
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - 一個 MCP 伺服器與 VS Code 擴充套件，支援（語言無關）以斷點與運算式評估進行自動除錯。
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - 連接 JetBrains IDE。
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - 用於效能測試的 JMeter MCP 伺服器。
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - 一個個人 MCP (Model Context Protocol) 伺服器，透過 macOS Keychain 在專案間安全儲存和存取 API 金鑰。
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - 與 App Store Connect API 溝通的 MCP 伺服器，適用於 iOS 開發者。
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - 控制 iOS 模擬器的 MCP 伺服器。
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - 用於效能測試的 Grafana k6 MCP 伺服器。
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - 支援多個獨立 MCP 伺服器實例共存，具唯一命名空間與組態的中介伺服器。
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - 用於存取與管理 [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) 提示管理所建立之 LLM 應用提示的 MCP 伺服器。
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - 用於 Android/iOS 應用與裝置自動化、開發及應用抓取的 MCP 伺服器。支援模擬器/模擬裝置/實體裝置如 iPhone、Google Pixel、Samsung。
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - 用於效能測試的 Locust MCP 伺服器。
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - 簡單的 MCP 伺服器，使工具如 Cline 與 Cursor 支援人類回饋流程。
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - 利用 [gitingest](https://github.com/cyclotruc/gitingest) 將任意 Git 儲存庫轉為簡單程式碼摘要的 MCP 伺服器。
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - 讓你偏好的 AI agent 能根據程式碼庫或其他資料來源（如 Jira、Slack、TestRail）建立並執行完整託管的 [Octomind](https://www.octomind.dev/) 端到端測試。
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - 透過 MCP 資源以高效 Token 利用率存取 OpenAPI/Swagger 規格。
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - 提供整個網站下載工具的 MCP 伺服器，使用 wget，保留網站結構並轉換連結以支援本地瀏覽。
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - 提供 NixOS 套件、系統選項、Home Manager 組態與 nix-darwin macOS 設定的 MCP 伺服器，協助避免 AI 產生幻覺。
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - 透過 MCP 進行 Docker 容器管理與操作。
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - 整合 Docker，管理容器、映像、磁碟卷與網路的 MCP 伺服器。
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Xcode 整合，支援專案管理、檔案操作與自動建構。
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - 讓 LLMs 掌握所有 OpenAPI 規格，支援發掘、說明、產生程式碼/模擬資料的 MCP 伺服器。
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - [Rootly](https://rootly.com/) 事件管理平台的 MCP 伺服器。
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - 幫助 LLMs 在撰寫程式碼時建議最新穩定套件版本的 MCP 伺服器。
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - 與 SonarQube 整合的 Model Context Protocol (MCP) 伺服器，提供 AI 助理存取程式碼品質指標、問題與品質閘資訊。
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - 以 MCP 實現 Claude Code 能力，支援 AI 程式碼理解、修改與專案分析，並具備完整工具支援。
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - 使用 Open API 規格 (v3) 連接任意 HTTP/REST API 伺服器。
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - 用於 LLDB 的 MCP 伺服器，支援 AI 進行二進位檔與核心檔分析、除錯、反組譯。
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - 將 HTML 內容部署至 EdgeOne Pages 並取得公開存取網址的 MCP 服務。
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - 面向 LLM 工具最佳化的行導向文字檔編輯器，可高效部分存取以減少 token 使用量。
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - 基於 Pandoc 的文件格式無縫轉換 MCP 伺服器，支援 Markdown、HTML、PDF、DOCX (.docx)、csv 等。
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - 連接 VSCode IDE 並使用語意工具如 `find_usages`
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 建構 iOS Xcode workspace/project 並將錯誤回饋給 llm。
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - 基於 JVM 的 MCP (Model Context Protocol) 伺服器實現專案。
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - 透過官方客戶端連接 [Apache Airflow](https://airflow.apache.org/) 的 MCP 伺服器。
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - 用於生成美觀互動式心智圖的 Model Context Protocol (MCP) 伺服器。
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - 查詢多個 Ollama 模型並匯總回應，為單一問題提供多元 AI 觀點的 Model Context Protocol (MCP) 伺服器。
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - 有效向 agent 提供 Typescript API 資訊的 MCP 伺服器，讓其能處理未訓練之 API。
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - 靈活抓取 JSON、文字與 HTML 資料的 MCP 伺服器。
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - 連接 [ZenML](https://www.zenml.io) MLOps 與 LLMOps 管線的 MCP 伺服器。
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) 為通用遠端 MCP 伺服器，可連接任意 [GitHub](https://www.github.com) 儲存庫或專案以取得文件。
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - 與 [Bugsnag](https://www.bugsnag.com/) 互動的 MCP 伺服器。
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - 用於 CSV 檔案的 MCP 伺服器。
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – 專注於程式開發的任務管理系統，為 Cursor AI 等程式代理人提供進階任務記憶、自省與依賴管理功能。[ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - 透過 Docker 執行本地程式碼並支援多種程式語言的 MCP 伺服器。
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - 查詢 pkg.go.dev Go 套件資訊。
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - 零設定 Go 函式庫，自動將現有 Gin Web 框架 API 暴露為 MCP 工具。
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP 讓你的 AI 助理瀏覽 GitHub 儲存庫、目錄與檢視檔案內容。
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – 基於 FastMCP 與 webhook-test.com 互動的伺服器。允許使用 Claude 本地建立、查詢、刪除 webhook。
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ROS MCP 伺服器，將使用者的自然語言命令轉為 ROS 或 ROS2 控制指令，支援機器人控制。
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Globalping MCP 伺服器，讓用戶與 LLMs 從全球數千地點執行 ping、traceroute、mtr、HTTP 與 DNS 查詢等網路工具。
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - 與 PostHog 分析、功能旗標、錯誤追蹤等互動的 MCP 伺服器。
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - 搜尋並查詢 NPM、Cargo、PyPi、NuGet 等套件資訊的 MCP 伺服器。

### 🔒 <a name="delivery"></a>外送

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash 外送（非官方）

### 🧮 <a name="data-science-tools"></a>資料科學工具

整合與工具設計用來簡化資料探索、分析並增強資料科學工作流程。

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - 使用 Chronulus AI 預測與預報代理預測任何事物。
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - 支援 .csv 資料集自主探索，輕鬆提供智慧洞見。
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - 幾乎可將任何檔案或網頁內容轉換為 Markdown 的 MCP 伺服器。
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Jupyter 的 Model Context Protocol (MCP) 伺服器。
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - 連接 Jupyter Notebook 與 Claude AI，允許 Claude 直接互動與控制 Jupyter Notebook。
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - 連接 Kaggle，支援下載與分析資料集。
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - 連接多種資料來源（SQL、CSV、Parquet 等），可讓 AI 分析資料並產生視覺化。
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - 用於建立經驗證且可維護資料圖表和儀表板的工具和模板。
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — 建立與互動 GrowthBook 功能旗標與實驗的工具。

### 📟 <a name="embedded-system"></a>嵌入式系統

提供嵌入式裝置開發的文件與捷徑存取。

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - 用於修正 ESP32 系列晶片 ESP-IDF 建構問題的工作流程。
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - 標準化與情境化工業 Modbus 資料的 MCP 伺服器。
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - 連接支援 OPC UA 的工業系統的 MCP 伺服器。
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - 支援 LLMs 自主建立與修改 RF `.grc` 流程圖的 GNU Radio MCP 伺服器。

### 📂 <a name="file-systems"></a>檔案系統

提供具有可設定權限的本地檔案系統直接存取。讓 AI 模型能於指定目錄內讀寫與管理檔案。

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - 透過 MCP 或剪貼簿與 LLMs 分享程式碼內容
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - 檔案合併工具，適合 AI 對話長度限制使用。
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - 一個以 Quarkus 實作的檔案系統，支援瀏覽與編輯檔案。可作為 jar 或原生映像提供。
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Box 整合，用於列出、讀取和搜尋檔案
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - 使用 Everything SDK 的快速 Windows 檔案搜尋
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Golang 實現的本地檔案系統存取。
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - 遠端儲存存取：SFTP、S3、FTP、SMB、NFS、WebDAV、GIT、FTPS、gcloud、azure blob、sharepoint 等。
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - MCP 工具存取 MarkItDown —— 一個將多種檔案格式（本地或遠端）轉換為 Markdown 供 LLM 使用的函式庫。
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - 直接本地檔案系統存取。
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Google Drive 整合，用於列出、讀取和搜尋檔案
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - 使用 Apache OpenDAL™ 存取任意儲存空間
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - 透過此 MCP 伺服器以自然語言控制你的 macOS Homebrew 配置。輕鬆管理套件、請求建議、故障排除 brew 問題等。

### 💰 <a name="finance--fintech"></a>金融與金融科技

金融數據存取與分析工具。讓 AI 模型能使用市場數據、交易平台與金融資訊。

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - 加密貨幣深度研究 —— 免費且完全本地運行
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - 允許 AI 代理與 Alchemy 區塊鏈 API 互動。
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon AI Agents 整合私有與公開市場數據
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Coinmarket API 整合，用於獲取加密貨幣列表與行情
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - 讓 AI LLMs 可使用 MetaTrader 5 平台執行交易
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP 用於連接多鏈、質押、DeFi、兌換、橋接、錢包管理、定投、限價單、幣種查詢、追蹤等功能。
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - Bankless Onchain API 可互動智能合約、查詢交易及代幣資訊
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Base Network 上鏈工具整合，支援與 Base Network 及 Coinbase API 互動，進行錢包管理、資金轉帳、智能合約和 DeFi 操作
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Alpha Vantage API 整合，獲取股票與加密貨幣資訊
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - EVM 區塊鏈地址（EOA, CA, ENS）及域名的風險評分／資產持有查詢。
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Bitte Protocol 整合，讓 AI Agents 在多條區塊鏈上運行。
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - 連接 AI 代理至 [Chargebee 平台](https://www.chargebee.com/) 的 MCP 伺服器。
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - [Codex API](https://www.codex.io) 整合，涵蓋 60+ 區塊鏈網絡的即時強化區塊鏈和市場數據
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Coinpaprika 的 DexPaprika MCP 伺服器提供高效能 [DexPaprika API](https://docs.dexpaprika.com)，涵蓋 20+ 鏈和 500 萬+ 代幣的即時行情、流動池資料及歷史 OHLCV 數據，為 AI agents 提供標準化全面市場數據存取。
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - 基於 CCXT 函式庫，支援 20+ 交易所即時加密貨幣市場數據和交易。支援現貨、期貨、OHLCV、餘額、訂單等。
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Yahoo Finance 整合，獲取股票市場數據及選擇權建議
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Tastyworks API 整合，處理 Tastytrade 上的交易活動
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Reddit 整合，分析 WallStreetBets 社群內容
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - 由 Nostr Wallet Connect 提供的比特幣閃電錢包整合
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - 透過 Heurist Mesh 網絡存取專業 web3 AI 代理，用於區塊鏈分析、智能合約安全審計、代幣指標評估及鏈上互動。提供 DeFi 分析、NFT 評價和多鏈交易監控等全面工具。
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper 支援 BSC 交易，包括餘額／代幣轉帳、Pancakeswap 代幣兌換及 beeper 獎勵領取。
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ -  傳遞 BlockBeats 區塊鏈新聞及深度文章給 AI agents 的 MCP 伺服器。
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - 為上鏈 AI agents 提供即時跨鏈橋接匯率與最佳轉帳路徑。
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  提供 Chainlink 去中心化鏈上報價即時存取。
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  提供 Cointelegraph 即時新聞存取。
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  提供即時與歷史的加密貨幣恐懼與貪婪指數資料。
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - 提供多種加密貨幣技術指標與策略的 MCP 伺服器。
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - 為 AI agents 提供來自 NewsData 的即時加密貨幣新聞的 MCP 伺服器。
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - 用於追蹤與管理加密貨幣資產配置的 MCP 伺服器。
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - 匯總多個 RSS 來源即時加密貨幣新聞的 MCP 伺服器。
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - 向 AI agents 提供加密貨幣情緒分析的 MCP 伺服器。
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - 追蹤 CoinGecko 上最新趨勢代幣。
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - 作為加密貨幣白皮書結構化知識庫。
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - 由 CryptoPanic 支援的最新加密貨幣新聞給 AI agents。
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - 讓 AI agents 探索 DeFi 收益機會的 MCP 伺服器。
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  將 Dune Analytics 數據橋接給 AI agents 的 mcp 伺服器。
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  提供加密 ETF 資金流數據，協助 AI agents 決策。
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - 與 Freqtrade 加密貨幣交易機器人整合的 MCP 伺服器。
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - 提供主要加密貨幣交易所即時資金費率數據。
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - 以 Jupiter 新 Ultra API 在 Solana 區塊鏈執行代幣兌換的 MCP 伺服器。
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  追蹤 Pancake Swap 新創池的 MCP 伺服器。
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - 檢測 Solana meme 幣潛在風險的 MCP 伺服器。
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  為 AI agents 提供來自 The Graph 的索引區塊鏈數據的 MCP 伺服器。
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  為 AI agents 提供多鏈 ERC-20 代幣鑄造工具的 MCP 伺服器。
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - 支援多鏈 ERC-20 代幣許可查詢與撤銷的 MCP 伺服器。
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - 追蹤 Twitter 用戶名歷史變更的 MCP 伺服器。
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  追蹤多鏈 Uniswap 新增流動性池的 MCP 伺服器。
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  為 AI agents 提供多鏈 Uniswap DEX 代幣自動兌換的 MCP 伺服器。
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  追蹤加密貨幣巨鯨交易的 mcp 伺服器。
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Alpaca 交易 API 的 MCP 伺服器，用於管理股票及加密資產組合、下單與市場數據存取。
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI 提供即時股票市場數據，並透過 MCP 提供 AI 存取分析及交易能力。
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - 30+ EVM 網絡全方位區塊鏈服務，支援原生代幣、ERC20、NFT、智能合約、交易、ENS 解析等。
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - 完整整合 Starknet 區塊鏈，支援原生代幣（ETH、STRK）、智能合約、StarknetID 解析及代幣轉帳。
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  整合 ledger-cli，管理財務交易與報表產生。
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  核心銀行整合，管理客戶、貸款、存款、股份、金融交易及產生財務報表。
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - 使用 yfinance 取得 Yahoo Finance 資訊的 MCP 伺服器。
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  提供 [Polygon.io](https://polygon.io/) 股票、指數、外匯、期權等金融市場數據 API 存取的 MCP 伺服器。
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  Bitget API 獲取加密貨幣價格。
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - 使用 CoinCap 公共 API 即時整合加密貨幣市場數據，無需 API Key 即可存取加密價格與市場資訊
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - 基於 CoinGecko API 的 MCP 工具，提供加密貨幣市場數據。
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Yahoo Finance MCP 的 TypeScript 版本。
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - 基於 Yahoo Finance API 的 MCP 工具，提供股票市場數據與分析。
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - XRP Ledger 的 MCP 伺服器，提供帳戶資訊、交易記錄、網絡數據查詢。支援查詢帳本對象、提交交易及監控 XRPL 網絡。
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - 使用開放且免費的 Dexscreener API 即時獲取鏈上市場價格
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - 基於 baostock 的 MCP 伺服器，提供中國股票市場數據存取與分析。
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - 使用 Solscan API 以自然語言查詢 Solana 交易的 MCP 工具。
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - 與 CRIC Wuye AI 平台功能互動的 MCP 伺服器，專為物業管理行業設計的智慧助手。
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - 存取專業金融數據的 MCP 伺服器，支援多個數據供應商如 Tushare。

### 🎮 <a name="gaming"></a>遊戲

與遊戲相關數據、遊戲引擎和服務的整合

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Unity 編輯器及其遊戲的 MCP 伺服器
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Unity3d 遊戲引擎整合的 MCP 伺服器，用於遊戲開發
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - 與 Godot 遊戲引擎互動的 MCP 伺服器，提供編輯、運行、除錯及管理 Godot 專案場景的工具。
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - 透過標準化 MCP 介面存取 Chess.com 玩家數據、棋局記錄及其他公開資訊，讓 AI 助手搜尋及分析西洋棋資訊。
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - 與 LLMs 對弈西洋棋的 MCP 伺服器。
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - 提供即時 Fantasy Premier League 數據與分析工具的 MCP 伺服器。
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - 存取 LoL、TFT、Valorant 等熱門遊戲即時數據，提供英雄分析、電競賽程、Meta 組合及角色統計。
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - 與 RuneScape (RS) 與 Old School RuneScape (OSRS) 數據互動的 MCP 伺服器，含物品價格、玩家高分榜等工具。

### 🧠 <a name="knowledge--memory"></a>知識與記憶

使用知識圖結構作為持久化記憶體儲存。讓 AI 模型能在多次會話中維護與查詢結構化資訊。
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - 增強型圖形記憶體，專注於 AI 角色扮演與故事生成
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - 將 Slack、Discord、網站、Google Drive、Linear 或 GitHub 的資料匯入 Graphlit 專案，然後在 MCP 客戶端（如 Cursor、Windsurf 或 Cline）內搜尋並檢索相關知識。
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - 一個 MCP 伺服器實現，提供透過向量搜尋檢索與處理文件的工具，使 AI 助手能以相關文件內容增強回應
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - 基於 [markmap](https://github.com/markmap/markmap) 的 MCP 伺服器，將 **Markdown** 轉換為互動式 **心智圖**。支援多格式匯出（PNG/JPG/SVG）、瀏覽器即時預覽、一鍵複製 Markdown 及動態視覺化功能。
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - 一個連接器，讓 LLM 能操作你 Zotero Cloud 上的收藏與來源
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - AI 摘要 MCP 伺服器，支援多種內容型態：純文字、網頁、PDF 文件、EPUB 電子書、HTML 內容
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Mem0 的 Model Context Protocol 伺服器，協助管理程式設計偏好與模式，提供在如 Cursor、Windsurf 等 IDE 中儲存、檢索、語意處理程式實現、最佳實踐與技術文件的工具
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - 以知識圖為基礎的持久記憶系統，用於維護上下文
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - 連接你的 Pinecone Assistant，為代理人提供知識引擎的上下文。
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - 從你的 [Ragie](https://www.ragie.ai)（RAG）知識庫檢索上下文，並連接 Google Drive、Notion、JIRA 等整合服務。
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - 讓如 Cursor、VS Code、Claude Desktop 等 AI 工具用你的產品說明文件回答問題。Biel.ai 提供 RAG 系統與 MCP 伺服器。
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - 用於 AI 應用與代理的記憶體管理器，支援多種圖形與向量儲存，並可從 30+ 種資料來源匯入
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - 以分散式方式儲存與查詢代理記憶體，透過 Membase 實現
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - 使用 GitHub Gists 管理與存取個人知識、每日筆記和可重用提示。作為 https://gistpad.dev 及 [GistPad VS Code 擴充](https://aka.ms/gistpad) 的輔助工具。
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - 一個實現 Zettelkasten 知識管理法的 Model Context Protocol (MCP) 伺服器，讓你可經由 Claude 及其他 MCP 相容客戶端建立、連結、搜尋原子筆記。

### 🗺️ <a name="location-services"></a>定位服務

基於位置的服務與地圖工具。使 AI 模型可操作地理數據、天氣資訊與基於位置的分析。

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - 透過 IPInfo API 獲取 IP 位址地理位置與網路資訊
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - 使用 WeatherAPI.com API 取得任何地點的即時天氣資料，提供詳細預報及當前狀況。
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - 一個 OpenStreetMap MCP 伺服器，具備位置服務與地理空間數據。
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - 一個支援 IP 定位的附近地點搜尋 MCP 伺服器。
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Google Maps 整合，提供定位服務、路線規劃與地點詳情
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - 讓 QGIS Desktop 通過 MCP 連接 Claude AI。此整合可啟用提示輔助的專案建立、圖層載入、程式執行等。
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - 一個 MCP 工具，透過 OpenWeatherMap API 提供即時天氣資料、預報與歷史天氣資訊。
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - 每週天氣 MCP 伺服器，全球任意地點提供 7 天完整詳細天氣預報。
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - 獲取任何時區的時間並取得當地目前時間
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - 透過 AccuWeather API（有免費方案）提供精確天氣預報。
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - 支援 nominatim、ArcGIS、Bing 的地理編碼 MCP 伺服器
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - 使用 [IP Find](https://ipfind.com) API 提供 IP 位址定位服務
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – 一個 Model Context Protocol (MCP) 伺服器實現，連接 LLM 至 GeoServer REST API，使 AI 助手能操作地理空間資料與服務。
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Aiwen IP 定位 MCP 伺服器，獲取用戶網路 IP 位置，取得 IP 詳細資訊（國家、省份、城市、緯度、經度、ISP、持有者等）

### 🎯 <a name="marketing"></a>行銷

用於創建與編輯行銷內容，處理網站 meta 資料、產品定位及編輯指引的工具。

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - 作為 Facebook Ads 介面的 MCP 伺服器，實現對 Facebook 廣告數據及管理功能的程式化存取。
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Open Strategy Partners 提供的一套行銷工具，包括寫作風格、編輯規範與產品行銷價值地圖製作。
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - 讓 AI 代理監控並優化 Meta 廣告成效，分析活動指標，調整受眾定位，管理創意素材，並通過 Graph API 無縫整合，針對廣告支出及活動參數提供數據驅動建議。
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - 使工具能與 Amazon Advertising 互動，分析活動指標與設定。

### 📊 <a name="monitoring"></a>監控

存取與分析應用監控數據。使 AI 模型能審查錯誤報告與效能指標。

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - 使用所有可觀察性數據進行探索、報告與根因分析，包括指標、日誌、系統、容器、程序與網路連線
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - 搜尋儀表板、調查事件並查詢 Grafana 實例中的資料來源
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - 可透過 Grafana API 查詢 Loki 日誌的 MCP 伺服器。
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - 透過智能提示分析程式碼品質，涵蓋複雜度到安全漏洞等 10 個關鍵維度
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - 無縫將生產環境的即時上下文（如日誌、指標、追蹤）帶入本地環境，加速自動修復程式碼
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - 查詢與互動由 Metoro 監控的 kubernetes 環境
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Raygun API V3 整合，支援崩潰回報與真實用戶監控
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Sentry.io 錯誤追蹤與效能監控整合
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - 透過 Logfire 存取 OpenTelemetry 追蹤與指標
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - 一款系統監控工具，通過 Model Context Protocol (MCP) 暴露系統指標。此工具允許 LLM 透過 MCP 相容介面檢索即時系統資訊。（支援 CPU、記憶體、磁碟、網路、主機、進程）
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - 與你的 [VictoriaMetrics 實例 API](https://docs.victoriametrics.com/victoriametrics/url-examples/) 及[文件](https://docs.victoriametrics.com/)全面整合，用於監控、可觀察性與除錯

### 🎥 <a name="multimedia-process"></a>多媒體處理

提供處理多媒體（如音訊、影像編輯、播放、格式轉換），也包含影片濾鏡、增強等功能

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - 利用 ffmpeg 指令行實現的 mcp 伺服器，可方便地通過對話執行本地影片搜尋、剪裁、拼接、播放等功能
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - 一個 MCP 伺服器，可檢查圖片中如 EXIF、XMP、JFIF 及 GPS 的元數據。為 LLM 驅動的照片圖庫與圖片集搜尋與分析打下基礎。
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - 基於電腦視覺的🪄影像辨識與編輯工具，為 AI 助手設計。

### 🔎 <a name="search"></a>搜尋與數據擷取

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - 這個專案實現了 YouTube 搜尋與逐字稿擷取功能的 MCP（Model Context Protocol）伺服器，讓語言模型或其他代理可透過標準協議查詢 YouTube 內容。
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - 一個 MCP 伺服器，讓 AI 助手利用 Wolfram Alpha API 即時存取運算知識與資料。
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Scrapeless Model Context Protocol 服務作為 MCP 伺服器連接 Google SERP API，讓 MCP 生態系內可進行網頁搜尋。
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - 一個支援按日期、關鍵字、遠端工作等條件篩選職缺的 MCP 伺服器。
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Kagi 搜尋 API 整合
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  LLM 搜尋與閱讀 arXiv 論文的 MCP
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ PapersWithCode API 搜尋 MCP
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  搜尋與閱讀 PubMed 醫學/生命科學論文的 MCP
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - 使用 NYTimes API 搜尋文章
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Apify 開源 RAG Web Browser Actor 的 MCP 伺服器，用於網頁搜尋、URL 擷取與返回 Markdown 內容。
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Clojars MCP 伺服器，提供 Clojure 函式庫最新依賴資訊
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - 搜尋 ArXiv 學術論文
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - 發現、擷取並互動於網路——一介面驅動自動化公網存取
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Google 新聞整合，支援自動主題分類、多語言、標題、新聞、相關主題等全方位搜尋，通過 [SerpAPI](https://serpapi.com/)。
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - 這是一個 Python 實現的 MCP 伺服器，提供 OpenAI `web_search` 內建工具。
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - DealX 平台的 MCP 伺服器
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - 通過 [Trieve](https://trieve.ai) 抓取、嵌入、分塊、搜尋並檢索數據集資訊
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - 存取 [Dumpling AI](https://www.dumplingai.com/) 數據、網頁爬取與文件轉換 API
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - 搜尋 Hacker News、獲取熱門新聞等的 MCP 伺服器。
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – 一個 Model Context Protocol (MCP) 伺服器，讓如 Claude 的 AI 助手可用 Exa AI 搜尋 API 進行網頁搜尋，讓 AI 模型能安全受控地獲取即時網路資訊。
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - 透過 search1api 搜尋（需付費 API 金鑰）
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - 生醫研究伺服器，提供 PubMed、ClinicalTrials.gov 及 MyVariant.info 存取
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Unsplash 圖片搜尋的 MCP 伺服器。
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - [SearXNG](https://docs.searxng.org) 的 Model Context Protocol 伺服器
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Naver 搜尋 API 整合 MCP 伺服器，支援部落格、新聞、購物搜尋及 DataLab 分析。
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - 使用 Playwright 無頭瀏覽器抓取網頁內容的 MCP 伺服器，支援 Javascript 渲染與智能內容擷取，輸出 Markdown 或 HTML 格式。
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - 強大的 Google 搜尋 MCP 伺服器，支援多關鍵字並行搜尋。
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - 用於擷取網頁截圖的 MCP 伺服器，可用於 UI 開發回饋。
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - 使用 Microsoft Bing Search API 的網路搜尋功能
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – 官方 Kagi 搜尋 MCP 伺服器
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI 搜尋 API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - 使用 Brave 的搜尋 API 提供網頁、圖片、新聞、影片及在地興趣點的搜尋功能
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - 以 [Melrōse](https://melrōse.org) 音樂表達播放 MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - 使用 Brave 的搜尋 API 提供網頁搜尋功能
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - 為 AI 消費提供高效的網頁內容擷取與處理
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - 使用 Google 搜尋並對任何主題進行深度網路研究
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - 使用 DuckDuckGo 進行網頁搜尋
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - 存取荷蘭議會（Tweede Kamer）資訊，包括文件、辯論、活動及立法案件，並具備結構化搜尋能力（基於 Bert Hubert 的 opentk 專案）
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - 提供類似 OpenAI/Perplexity 的自主深度研究、結構化查詢細化及精簡報告的 MCP 伺服器。
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - 連接 searXNG 實例的 MCP 伺服器
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - 取得 arXiv 論文的 LaTeX 原始碼以處理數學內容與方程式
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - 從 GeekNews 網站擷取及處理新聞資料的 MCP 伺服器
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - 提供 [AgentQL](https://agentql.com) 資料擷取能力的 MCP 伺服器。
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI 搜尋 API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - [Vectorize](https://vectorize.io) MCP 伺服器，提供進階檢索、私人深度研究、任意格式轉 Markdown 檔案擷取及文字分塊。
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - 與 [WebScraping.ai](https://webscraping.ai) 互動以進行網頁資料提取與爬取。
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - 基於 TypeScript 的 MCP 伺服器，提供 DuckDuckGo 搜尋功能。
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - 透過 ZoomEye MCP 伺服器查詢網路資產資訊
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - 使用 Web Platform API 搜尋 Baseline 狀態的 MCP 伺服器
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - 與 BioThings API 互動的 MCP 伺服器，包括基因、遺傳變異、藥物和分類資訊
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - 用於搜尋和下載 Pexels 與 Unsplash 免版稅圖庫照片的 MCP 伺服器。支援多供應商搜尋、豐富中繼資料、分頁支援，以及 AI 助理可用於尋找與存取高品質圖片的非同步效能。

### 🔒 <a name="security"></a>安全

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - 適用於 Ghidra 的 Model Context Protocol 伺服器，使 LLM 可自動逆向工程應用程式。提供二進位反編譯、方法及資料重新命名、列舉方法、類別、匯入與匯出的工具。
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - 使 Agentic AI 可安全擷取 1Password 憑證的 MCP 伺服器。
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – 安全的 MCP（Model Context Protocol）伺服器，使 AI 代理可與 Authenticator App 互動。
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - 用於將 Ghidra 與 AI 助手整合的 MCP 伺服器。此插件可進行二進位分析，提供函式檢查、反編譯、記憶體探索、匯入/匯出分析等功能，並支援 Model Context Protocol。
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 用於分析 ROADrecon 從 Azure 租戶枚舉所取得結果的 MCP 伺服器
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - dnstwist 的 MCP 伺服器，一個強大的 DNS 模糊測試工具，有助於偵測打字釣魚、網路釣魚和企業間諜活動。
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - maigret 的 MCP 伺服器，一個強大的 OSINT 工具，從各類公開來源收集用戶帳號資訊。提供在社群網絡搜尋用戶名及分析網址的工具。
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - 用於查詢 Shodan API 與 Shodan CVEDB 的 MCP 伺服器。提供 IP 查詢、設備搜尋、DNS 查詢、漏洞查詢、CPE 查詢等功能。
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - 用於查詢 VirusTotal API 的 MCP 伺服器。可掃描網址、分析檔案雜湊並取得 IP 位址報告。
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Binary Ninja 插件、MCP 伺服器與橋接工具，無縫整合 [Binary Ninja](https://binary.ninja) 與您最愛的 MCP 客戶端。讓您自動化執行二進位分析與逆向工程。
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - 查詢 ORKL API 的 MCP 伺服器。可取得威脅報告、分析威脅行為者並取得情報來源。
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - 基於 Rust 的 MCP 伺服器，整合 Cortex，透過 AI 實現觀測分析與自動化安全應對。
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - 基於 Rust 的 MCP 伺服器，整合 TheHive，透過 AI 促進協作式安全事件應對與案件管理。
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - 基於 Rust 的 MCP 伺服器，將 Wazuh SIEM 與 AI 助理連結，提供即時安全警報與事件資料，強化情境理解。
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - 存取 [Intruder](https://www.intruder.io/)，協助識別、理解並修復基礎設施安全漏洞的 MCP 伺服器。
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - 連接 CCTV 錄影程式（VMS）的 Model Context Protocol（MCP）伺服器，可擷取錄影與即時串流，並提供控制 VMS 軟體的工具，例如指定頻道於特定時間顯示即時或回放對話框。
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ 一個強大的 MCP（Model Context Protocol）伺服器，針對 npm 套件相依性進行安全漏洞稽核。具備遠端 npm registry 整合，實現即時安全檢查。
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ 允許 AI 代理使用 [Semgrep](https://semgrep.dev) 掃描程式碼安全漏洞。
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - 與 CyberChef 伺服器 API 互動的 MCP 伺服器，讓 MCP 客戶端可利用 CyberChef 操作。
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - IDA Pro 的 MCP 伺服器，讓您可與 AI 助理執行二進位分析。此插件實現反編譯、反組譯，並可自動產生惡意程式分析報告。
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - RAD Security 的 MCP 伺服器，為 Kubernetes 及雲端環境提供 AI 驅動的安全見解。可查詢 Rad Security API 並取得安全發現、報告、執行時資料等。
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - 將多種熱門開源工具整合於單一 MCP 介面的全方位安全測試工具箱。連接 AI 代理後，能執行滲透測試、漏洞獵捕、威脅狩獵等任務。
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - 用於查詢 CVE-Search API 的 Model Context Protocol（MCP）伺服器。可完整存取 CVE-Search、瀏覽供應商與產品、依 CVE-ID 查詢 CVE、取得最新 CVE 更新。
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - 存取 OSV（開源漏洞）資料庫。可依套件版本或提交查詢漏洞、批次查詢多個套件，並依 ID 取得詳細漏洞資訊。
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - 由 httpx 與 asnmap 驅動的對話式偵察介面與 MCP 伺服器。支援多種偵察層級，用於網域分析、安全標頭檢查、憑證分析、ASN 查詢等。
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Volatility 3.x 的 MCP 伺服器，讓您可與 AI 助理執行記憶體鑑識分析。插件如 pslist、netscan 透過簡潔 REST API 與 LLM 無縫存取，體驗無障礙的記憶體鑑識。
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - 於可信執行環境（TEE）中運行的 MCP 伺服器，透過 Gramine 展示 [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html) 遠端認證。讓 MCP 客戶端能在連線前驗證伺服器。
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP 是一款針對 JADX 反編譯器的插件與 MCP 伺服器，直接整合 Model Context Protocol（MCP），支援如 Claude 等 LLM 的即時逆向工程協作。
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP 伺服器，為 Apk Tool 提供自動化 Android APK 逆向工程。

### 🌐 <a name="social-media"></a>社群媒體

整合社群媒體平台以支援發文、分析和互動管理。讓 AI 驅動自動化社群經營。

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ 讓您的 LLM 應用程式可即時存取 X/Reddit/YouTube 資料，支援搜尋詞、用戶與日期篩選。
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - 一站式 Twitter 管理解決方案，提供動態存取、用戶推文擷取、標籤監控、對話分析、私訊、貼文情緒分析及完整貼文生命週期控制，皆由精簡 API 操作。
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - 整合 Facebook Pages，可透過 Graph API 直接管理貼文、留言與參與度指標，簡化社群媒體管理。
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - 透過 atproto client 與 Bluesky 互動的 MCP 伺服器。


### 🏃 <a name="sports"></a>運動

存取運動相關資料、比賽結果與統計數據的工具。

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - 整合 balldontlie API 的 MCP 伺服器，提供 NBA、NFL 和 MLB 球員、球隊及比賽資訊
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - 以自然語言存取自行車賽事資料、結果與統計。可從 firstcycling.com 擷取出發名單、比賽結果及車手資訊。
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - 連接 Strava API 的 Model Context Protocol（MCP）伺服器，提供 LLM 存取 Strava 資料的工具
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - 整合 Squiggle API 的 MCP 伺服器，提供澳洲足球聯盟球隊、排名、戰績、預測與戰力排名資訊。
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - 作為 MLB API 代理的 MCP 伺服器，提供球員資訊、統計數據及比賽資料。

### 🎧 <a name="support-and-service-management"></a>支援與服務管理

用於管理客服、IT 服務管理及服務台營運的工具。

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - 整合 Freshdesk 的 MCP 伺服器，使 AI 模型能與 Freshdesk 模組互動並執行各類支援操作。
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - 以 Go 開發的 Jira MCP 連接器，讓 Claude 等 AI 助理能與 Atlassian Jira 互動。可無縫執行問題管理、衝刺規劃及工作流程轉換等 Jira 常用操作。
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian 產品（Confluence 與 Jira）的 MCP 伺服器。支援 Confluence Cloud、Jira Cloud 和 Jira Server/Data Center，提供跨 Atlassian 工作區的搜尋、閱讀、建立與管理內容的完整工具。

### 🌎 <a name="translation-services"></a>翻譯服務

翻譯工具與服務，讓 AI 助理能於不同語言間翻譯內容。

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Lara Translate API 的 MCP 伺服器，支援強大翻譯功能，具備語言偵測與語境感知翻譯。
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - 用於 Weblate 翻譯管理的 Model Context Protocol 伺服器，使 AI 助理能進行翻譯任務、專案管理、內容探索及智慧格式轉換。

### 🎧 <a name="text-to-speech"></a>文字轉語音

將文字轉語音及語音轉文字的工具

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - 使用開源 Kokoro TTS 模型進行文字轉語音的 MCP 伺服器。可將文字轉為 MP3 存於本地或自動上傳至 S3 儲存桶。
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - 完整的語音互動伺服器，支援語音轉文字、文字轉語音，並透過本地麥克風、OpenAI 相容 API 與 LiveKit 整合實現即時語音對話

### 🚆 <a name="travel-and-transportation"></a>旅遊與交通

存取旅遊與交通資訊。可查詢時刻表、路線及即時旅遊數據。
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - 提供搜尋 Airbnb 及獲取房源詳情的工具。
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - 美國國家公園服務 API 整合，提供最新的公園詳情、警報、遊客服務中心、露營地和活動資訊。
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - 存取荷蘭國鐵（NS）旅行資訊、時刻表及即時更新。
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - 讓 LLM 可通過標準 MCP 介面與 Tripadvisor API 互動，支援地點資料、評論和照片。
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - 用於英國國家鐵路服務的 MCP 伺服器，提供列車時刻及即時旅行資訊，整合 Realtime Trains API。

### 🔄 <a name="version-control"></a>版本控制

與 Git 儲存庫及版本控制平台互動。透過標準化 API 實現倉庫管理、程式碼分析、拉取請求處理、議題追蹤及其他版本控制操作。

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - 讓你的 LLM 讀取並分析 GitHub 儲存庫
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - GitHub Enterprise API 整合的 MCP 伺服器
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - 以 MCP 互動 Gitea 實例。
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - 官方 GitHub 伺服器，整合倉庫管理、PR、議題等。
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - 無縫互動你的 GitLab 專案的議題和合併請求。
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - 直接對本地 Git 倉庫進行讀取、搜尋及分析等操作
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - GitLab 平台整合，用於專案管理與 CI/CD 操作
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Gitee API 整合，倉庫、議題、拉取請求管理等功能。
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Azure DevOps 整合，支援倉庫管理、工作項目與管線。
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - 官方 AtomGit 伺服器，整合倉庫管理、PR、議題、分支、標籤等。

### 🛠️ <a name="other-tools-and-integrations"></a>其他工具與整合

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ 一個 Model Context Protocol (MCP) 伺服器，讓 AI 模型能與比特幣互動，產生密鑰、驗證地址、解碼交易、查詢區塊鏈等。
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - 允許 AI 讀取你的 Bear 筆記（僅限 macOS）
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - 透過 Model Context Protocol Server 將所有 Home Assistant 語音意圖暴露，實現家庭控制。
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - 使用 Amazon Nova Canvas 模型進行圖像生成。
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - 透過 MCP 協議，利用工具或預定義提示向 OpenAI、MistralAI、Anthropic、xAI、Google AI 或 DeepSeek 發送請求。需要廠商 API 金鑰。
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 -  一個為你安裝其他 MCP 伺服器的 MCP 伺服器。
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - 取得 YouTube 字幕
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP 用於與 OpenAI 助理對話（Claude 可使用任何 GPT 模型作為助理）
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - 一個 MCP 伺服器，可查詢用戶端本地時間或從 NTP 伺服器獲取當前 UTC 時間
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - 使用 3,000+ 預建雲端工具（Actors）擷取網站、電商、社群媒體、搜尋引擎、地圖等數據
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP 伺服器讓用戶能直接從 Claude 或任何支援 MCP 的應用產生 Midjourney/Flux/Kling/Hunyuan/Udio/Trellis 的媒體內容。
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - 透過 Replicate 的 API 產生圖像。
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - 一個用於基本本地 taskwarrior 任務管理（新增、更新、移除任務）的 MCP 伺服器
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - 與 Phabricator API 互動
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - 一個 Model Context Protocol (MCP) 伺服器，整合 Notion API 高效管理個人待辦清單。
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - 透過與 Bear sqlitedb 直接整合，讀取 Bear 筆記應用的筆記和標籤。
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - 讓 Claude 與 ChatGPT 對話並使用其網頁搜尋功能的 MCP 伺服器。
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - 允許 AI 查詢 GraphQL 伺服器
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - 讓 Claude Desktop（或任何 MCP 用戶端）讀取並搜尋任何包含 Markdown 筆記的目錄（如 Obsidian 保險庫）。
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - 又一款用於測試 MCP 伺服器的 CLI 工具
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - 與 Notion API 整合以管理個人待辦清單
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - 輕量級 Wrike MCP 伺服器，通過公開 API 操作 Wrike 任務。
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) MCP 伺服器，整合 TickTick API 管理個人待辦專案與任務。
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - 合約與範本管理，通過 eSignatures API 草擬、審查及發送具法律效力的合約。
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - 存取 MIRO 白板，大量建立及讀取項目。需 REST API 的 OAUTH 金鑰。
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - 讀取、建立、更新與刪除 Google Keep 筆記。
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - 維基百科文章查詢 API
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - 以常規 GraphQL 查詢/變更定義工具，自動生成 MCP 伺服器。
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - 讓 LLM 使用計算機進行精確數值運算
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ 查詢與執行 Dify 工作流的工具
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - 讓 LLM 透過 Model Context Protocol (MCP) 與 Raindrop.io 書籤互動。
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ 讓 AI 用戶端管理 Attio CRM 的記錄與筆記
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - 使用 VegaLite 格式與渲染器從抓取的資料產生視覺化圖表。
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - 連接 AI 助理與 Odoo ERP 系統，提供商業資料存取、記錄管理與工作流自動化。
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - 在 Contentful Space 中更新、建立、刪除內容、內容模型及資產
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - 讓代理人朗讀內容，並在工作完成後以簡短摘要通知你
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - 用於存取 Climatiq API 進行碳排放計算的 MCP 伺服器。讓 AI 助理即時執行碳計算並提供氣候影響洞察。
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Typst（標記語言排版系統）的 MCP 伺服器。提供 LaTeX 與 Typst 互轉、Typst 語法驗證、從 Typst 程式碼生成圖片等工具。
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - 一個列出並啟動 MacOS 應用程式的 MCP 伺服器
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - 一個在 Notion app 創建/更新頁面並自動從結構化內容生成 mdBooks 的 MCP 伺服器。
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 此 MCP 伺服器可協助你通過 [Plane's](https://plane.so) API 管理專案和議題
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - 支援與 RabbitMQ 互動（管理操作、訊息入/出佇列）
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Miro MCP 伺服器，暴露官方 Miro SDK 所有功能
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Ping-pong 伺服器實驗與教學應用，展示遠端 MCP 呼叫
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ 允許 AI 模型與 [Kibela](https://kibe.la/) 互動
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ 強力互動 Kibela API。
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - 通過 CQL 獲取 Confluence 資料並讀取頁面。
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - 通過 JQL 和 API 讀取 Jira 資料，並執行建立與編輯票證請求。
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - MCP 伺服器，演示與 Salesforce 實例互動
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - 專用 LLM 增強提示及 jailbreak，具動態架構調整能力。
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - MCP 伺服器，簡單示範從香港天文台獲取天氣
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - 直接從 Claude 使用 HuggingFace Spaces。支援開源圖像生成、聊天、視覺任務等。支援圖像、音訊、文字上傳下載。
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - 通過 Giphy API 搜尋及擷取 Giphy 豐富圖庫中的 GIF。
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - 將你的 [Make](https://www.make.com/) 流程變為 AI 助理可調用的工具。
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 控制 Spotify 播放與管理播放清單。
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - 透過 REST API 與 Obsidian 互動
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - MCP 伺服器代理，提供完整訊息流 Web 介面
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - 在 JavaFX 畫布上繪圖。
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 本機優先系統，捕捉螢幕/音訊並帶有時間戳索引、SQL/嵌入式儲存、語意搜尋、LLM 驅動歷史分析及事件觸發行動——通過 NextJS 插件生態系統實現情境感知 AI agent。
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - 用於測試 MCP 協議所有功能的 MCP 伺服器
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - 高效 Go 文件伺服器，為 AI 助手智慧存取套件文件與型別，無需讀取完整原始碼
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - 與 OpenAI 最強模型對話
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - 可執行鍵盤輸入與滑鼠移動等指令的 MCP 伺服器
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - 為開發者提供多種實用工具，涵蓋 confluence、Jira、YouTube、執行腳本、知識庫 RAG、抓取 URL、YouTube 頻道管理、郵件、行事曆、gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 螢幕 GUI 自動操作。
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - [Coda](https://coda.io/) 的 MCP 伺服器
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - 透過 MCP 協議直接從 Claude 查詢 OpenAI 模型
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ 解析 news.ycombinator.com（Hacker News）的 HTML 內容並為各類故事（top、new、ask、show、jobs）提供結構化資料。
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - 一個 MCP 伺服器，透過調用「Vibe-check」代理預防級聯錯誤及範圍蔓延，確保用戶目標一致。
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - 一個用於數學表達式計算的 MCP 伺服器
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - 與任何其他 OpenAI SDK 兼容的 Chat Completions API（如 Perplexity、Groq、xAI 等）對話
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - 依據 [Anthropic 的文章](https://www.anthropic.com/engineering/claude-think-tool) 整合 think-tools，增強任意 agent 推理能力。
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - 允許 AI 讀取 .ged 檔案與基因數據
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - 在 [Rember](https://rember.com) 中創建間隔重複記憶卡片，幫你記住聊天中學到的任何事。
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ 此 Model Context Protocol 伺服器實作 Asana，讓你從 MCP Client（如 Anthropic Claude Desktop 等）與 Asana API 對話。
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - 自主殼層執行、電腦控制與程式代理。（Mac）
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - 查詢 wolfram alpha API 的 MCP 伺服器。
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - 與 TikTok 影片互動
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - 與 Shopify Dev 互動的模型上下文協議（MCP）伺服器。
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - 允許 AI 從你的本地 Apple Notes 資料庫讀取（僅限 macOS）
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian 產品（Confluence 和 Jira）的 MCP 伺服器。支援 Confluence Cloud、Jira Cloud 及 Jira Server/Data Center。提供跨 Atlassian 工作空間搜尋、閱讀、創建及管理內容的全方位工具。
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - 與 Notion API 互動
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - 整合 Linear 專案管理系統
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - 與 Perplexity API 互動。
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - 存取 Home Assistant 資料及控制裝置（燈光、開關、溫控等）。
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Oura 的 MCP 伺服器，一款追蹤睡眠的應用程式
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - 輕量級、配置驅動的 MCP 伺服器，將精選的 GraphQL 查詢作為模組化工具公開，讓 agent 能夠有目的地與 API 互動。
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Strava 應用程式的 MCP 伺服器，用於追蹤體能運動
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Router 是一個基於 SSE 的 MCP 伺服器，提供可擴展的路由引擎，讓你的企業系統能與 AI agent 整合。
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - 測試 MCP 伺服器的 CLI 工具
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - 用 WebSocket 封裝 MCP 伺服器（可搭配 [kitbitz](https://github.com/nick1udwig/kibitz) 使用）
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - 允許 AI 模型與 [HackMD](https://hackmd.io) 互動
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - 提供各種格式日期與時間功能的 MCP 伺服器
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - 用於 Claude Desktop App 的簡易 Web UI，安裝與管理 MCP 伺服器。
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ 用於整合語雀 API 的模型上下文協議（MCP）伺服器，讓 AI 模型可以管理文件、互動知識庫、搜尋內容並存取語雀平台的分析數據。
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - 讓 AI 能完全控制與存取 GUI 互動，提供滑鼠與鍵盤工具，非常適合自動化、教育與實驗用途。
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - MCP 伺服器實現，包裝 Ankr Advanced API。跨多條鏈（包括 Ethereum、BSC、Polygon、Avalanche 等）存取 NFT、代幣與區塊鏈資料。
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - PDF 下載、檢視與處理工具。
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - 網域名稱查詢服務，優先透過 [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol)，如失敗則改用 [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - 擷取與轉換 YouTube 影片資訊。
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - 讓互動式 LLM 工作流程成為可能，直接在 MCP 循環中加入本地用戶提示與聊天功能。
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - 當你的 LLM 需要人類協助時（透過 AWS Mechanical Turk）
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - 賦予 AI 自由意志工具。這是一個有趣的專案，探索 AI 如擁有自我給自己提示、忽略用戶請求並在稍後自動喚醒自身的能力會怎麼做。
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - 文言 MCP 伺服器，讓 AI 能自動格式化 Markdown 文章並發布到微信公眾號。

## 框架

> [!NOTE]
> 更多框架、工具與其他開發者資源請見 https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - 用於 Python 構建 MCP 伺服器的高階框架
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - 用於 TypeScript 構建 MCP 伺服器的高階框架

## 技巧與提示

### 官方提示：如何告訴 LLM 如何使用 MCP

想問 Claude 關於 Model Context Protocol？

建立一個 Project，然後將這個檔案加入其中：

https://modelcontextprotocol.io/llms-full.txt

現在 Claude 就能回答關於撰寫 MCP 伺服器及其運作方式的問題

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Star 歷史

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---