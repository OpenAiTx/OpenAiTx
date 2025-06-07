<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">你身邊親切的遊戲網站。</p>
<br>

歡迎來到 MonkeyGG2，一個為你打造、功能豐富的遊戲網站！MonkeyGG2 提供超過 150 款遊戲，帶來獨特且可自訂的遊戲體驗。無論你是玩家、開發者還是一般用戶，MonkeyGG2 都能提供流暢且愉快的遊戲環境。

> 歡迎給我們一顆星！特別是如果你 fork 了這個倉庫或從中獲得其他用途。

## 功能特色

-   超過 150 款遊戲
-   易於使用
-   易於部署
-   可自訂
-   代理功能
-   以及更多...

## 自訂功能

### 設定

#### 偽裝（Cloaking）

偽裝指的是在 `about:blank` 分頁中開啟頁面。此行為預設強制啟用，雖然也可以停用。重定向連結有預設選項，但也可以手動設定。

#### 掩飾（Masking）

掩飾指的是更改 about:blank 分頁的圖示和分頁標題。圖示與分頁標題有預設選項，也可以手動設定。

#### 快捷鍵

你可以自訂鍵盤快捷鍵來執行各種任務。例如，退出遊戲、掩飾分頁，以及執行自訂 JavaScript 等都受到支援。
> 注意：如果你想執行自訂 JavaScript，請確認你了解你在做什麼。如果真的出現問題，重新載入頁面通常都能解決。

#### 主題

目前支援以下主題自訂選項：
- 切換背景動畫（如果你擔心遊戲中效能問題，請放心，遊戲進行時會自動停用）
- 背景顏色
- 方塊顏色
- 按鈕顏色
- 遊戲標籤顏色
- 滑鼠懸停顏色
- 捲軸顏色
- 捲軸軌道顏色
- 字體顏色

> 注意：如果你不小心將顏色更改到網站無法使用，請清除 cookies 與本地儲存（local storage）。

### 進階自訂

> 聲明：以下自訂僅限於倉庫擁有者或 fork 此倉庫的用戶。

`config.jsonc` 檔案包含整個網站的設定。目前支援以下項目：
- 遊戲
- 主題（即將推出）
- 代理設定

#### 遊戲

每個遊戲條目都有一個代表顯示名稱的鍵，值則應該是含有三個鍵值對的物件：
- `"path"`：從 `./games` 目錄到遊戲的路徑
- `"aliases"`：用於增強搜尋的遊戲替代名稱清單
- `"categories"`：遊戲所屬分類清單（支援新增分類圖示即將推出）

可以手動新增條目，但如果你想按字母數字順序排序會比較繁瑣（不排序也不影響設定運作！）
這就是為什麼會有 `add-game-entry.js` 腳本，讓你輕鬆新增遊戲到設定檔，而不需手動編輯。

```bash
# 你可以用任何 JS 執行環境，例如 node.js、bun 或 deno
# 這裡以 bun 為例，因為會自動安裝依賴
bun add-game-script.js
# 按照指示回答，設定檔就會自動更新
```

#### 主題

主題標準尚未實作（TODO）

#### 代理

代理設定選項在 **"config"** 鍵下。
`"proxy"` 鍵的值為布林值，用以啟用或停用代理功能。如果設為 false，使用者嘗試存取代理時會看到錯誤對話框。
`"proxyPath"` 鍵的值為代理路徑，可以是絕對路徑或相對路徑，但代理頁面必須支援 **CORS**，因為代理頁會以 iframe 方式嵌入顯示。

## 部署方式

### 不使用代理

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

或者，你也可以直接在 [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) 或 [Codeberg](https://codeberg.org/MonkeyGG2/pages) 上 fork 本倉庫，分別部署到 GitHub Pages 或 Codeberg Pages。

### 使用代理

請參考 [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) 頁面以了解如何搭配代理主機部署 MonkeyGG2。

### 本地運行

```bash
# 警告：如果你有一個名為 "monkeygg2" 的資料夾，此指令會移除該資料夾內所有檔案
# 請在以下兩個指令中修改資料夾名稱
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# 之後你可以用任何靜態伺服器工具，這裡以 npm 的 "live-server" 為例
npm install -g live-server # 如果你尚未安裝
npx live-server
```

## 授權條款

本專案採用 WTFPL 授權條款發佈。詳情請參閱 [這裡](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---