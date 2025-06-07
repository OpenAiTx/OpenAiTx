# AutoGPT：建立、部署與運行 AI 代理

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** 是一個強大的平台，讓你能夠建立、部署並管理自動化複雜工作流程的持續 AI 代理。

## 主機選項
   - 下載以自架
   - [加入雲端託管測試版等候名單](https://bit.ly/3ZDijAI)

## 自架部署設定方式
> [!NOTE]
> 自行設定和託管 AutoGPT 平台是一個技術性流程。
> 如果你偏好「開箱即用」的服務，建議[加入雲端託管測試版等候名單](https://bit.ly/3ZDijAI)。

### 系統需求

在進行安裝前，請確保你的系統符合以下需求：

#### 硬體需求
- CPU：建議 4 核心以上
- RAM：最低 8GB，建議 16GB
- 儲存空間：至少 10GB 可用空間

#### 軟體需求
- 作業系統：
  - Linux（建議 Ubuntu 20.04 或更新版本）
  - macOS（10.15 或更新版本）
  - Windows 10/11（需啟用 WSL2）
- 所需軟體（含最低版本）：
  - Docker Engine（20.10.0 或更新版本）
  - Docker Compose（2.0.0 或更新版本）
  - Git（2.30 或更新版本）
  - Node.js（16.x 或更新版本）
  - npm（8.x 或更新版本）
  - VSCode（1.60 或更新版本）或任一現代程式編輯器

#### 網路需求
- 穩定的網際網路連線
- 可存取所需通訊埠（將於 Docker 設定）
- 能夠進行 HTTPS 對外連線

### 最新安裝說明
我們已遷移至完整維護並定期更新的文件網站。

👉 [請依照官方自架指南操作](https://docs.agpt.co/platform/getting-started/)

本教學假設你已安裝 Docker、VSCode、git 及 npm。

### 🧱 AutoGPT 前端

AutoGPT 前端是用戶與我們強大 AI 自動化平台互動的介面。它提供多種方式來啟用並發揮 AI 代理的威力。這就是你讓 AI 自動化構想成真的介面：

   **代理建構器：** 對於想自訂的用戶，我們直觀、低程式碼的介面讓你能設計並配置專屬 AI 代理。
   
   **工作流程管理：** 輕鬆建立、修改並最佳化你的自動化工作流程。你可以透過連接區塊來建立代理，每個區塊執行單一動作。
   
   **部署控管：** 管理你的代理生命週期，從測試到正式上線。
   
   **現成代理：** 不想自己建立？直接從我們預設代理庫中選擇，即刻投入運作。
   
   **代理互動：** 無論是自建還是預設代理，都可以透過我們友善的介面輕鬆運行與互動。

   **監控與分析：** 追蹤代理效能，獲得洞察，持續精進你的自動化流程。

[閱讀此指南](https://docs.agpt.co/platform/new_blocks/)以瞭解如何打造自訂區塊。

### 💽 AutoGPT 伺服器

AutoGPT 伺服器是平台的運算核心。你的代理即在這裡運行。代理部署後，可以由外部來源觸發並持續運作。它包含讓 AutoGPT 順暢運作的所有關鍵元件。

   **原始碼：** 推動代理與自動化流程的核心邏輯。
   
   **基礎設施：** 強健的系統，確保可靠且可擴展的效能。
   
   **市集：** 完整的代理市集，讓你能找到並部署多樣預建代理。

### 🐙 代理範例

以下是兩個 AutoGPT 應用範例：

1. **從熱門話題生成爆紅短影片**
   - 此代理讀取 Reddit 上的主題。
   - 它辨識熱門話題。
   - 然後自動根據內容製作短影音。

2. **為社群媒體從影片中找出精選金句**
   - 此代理訂閱你的 YouTube 頻道。
   - 當你發布新影片時，它會自動轉錄內容。
   - 透過 AI 辨識最具影響力的金句並產生摘要。
   - 然後自動撰寫貼文並發佈至你的社群媒體。

這些例子僅展現了 AutoGPT 的部分應用潛力！你可以依需求自訂工作流程，建立任何用途的代理。

---
### 使命與授權
我們的使命是提供工具，讓你專注於最重要的事：

- 🏗️ **建立** - 為驚人事物奠定基礎。
- 🧪 **測試** - 將你的代理調校至完美。
- 🤝 **委託** - 讓 AI 為你效力，實現你的創意。

加入這場革命！**AutoGPT** 將持續領先於 AI 創新前線。

**📖 [文件](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [貢獻說明](CONTRIBUTING.md)**

**授權說明：**

MIT 授權：AutoGPT 主要程式庫採 MIT 授權。

Polyform Shield 授權：適用於 autogpt_platform 資料夾。

詳情請見 https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT 經典版
> 以下為 AutoGPT 經典版的相關資訊。

**🛠️ [快速建立代理 - 快速入門](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**打造你的專屬代理！** &ndash; Forge 是一套開箱即用的工具組，用於建立你的代理應用。它幫你處理大部分樣板程式碼，讓你將創意專注於讓*你的*代理脫穎而出的要素。所有教學集中於[這裡](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec)。[`forge`](/classic/forge/) 內的元件亦可單獨使用，以加快開發速度並減少樣板程式碼。

🚀 [**Forge 入門指南**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
此指南將帶你一步步創建自己的代理並使用基準測試與使用者介面。

📘 [深入瞭解](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) Forge

### 🎯 基準測試

**評量你的代理效能！** `agbenchmark` 可用於任何支援代理協議的代理，並且與專案 [CLI] 的整合讓其更易於與 AutoGPT 和基於 forge 的代理搭配使用。基準測試提供嚴格的測試環境。我們的框架能進行自主、客觀的效能評估，確保你的代理已為實戰做好準備。

<!-- TODO: insert visual demonstrating the benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) on Pypi
&ensp;|&ensp;
📘 [深入瞭解](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) 基準測試

### 💻 UI

**讓代理易於使用！** `frontend` 提供一個使用者友善的介面來控制與監控你的代理。它透過 [agent protocol](#-agent-protocol) 連接代理，確保與我們生態系內外多數代理的相容性。

<!-- TODO: insert screenshot of front end -->

前端可即時支援本倉庫內所有代理。只需用 [CLI] 執行你選擇的代理即可！

📘 [深入瞭解](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) 前端

### ⌨️ CLI

[CLI]: #-cli

為了讓你能輕鬆使用本倉庫所有工具，repo 根目錄內內建了一個 CLI：

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

只需 clone 此 repo、以 `./run setup` 安裝依賴，即可開始使用！

## 🤔 有問題？遇到困難？有建議？

### 取得協助 - [Discord 💬](https://discord.gg/autogpt)

[![加入我們的 Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

若要回報錯誤或提出新功能，請在 [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose) 建立議題。請先確認是否已有相同主題的議題。

## 🤝 相關專案

### 🔄 Agent Protocol

為維持統一標準並確保與現有及未來眾多應用無縫相容，AutoGPT 採用 AI Engineer Foundation 所制定的 [agent protocol](https://agentprotocol.ai/) 標準。這讓你的代理與前端及基準測試的通訊路徑標準化。

---

## Stars 統計

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>

## ⚡ 貢獻者

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---