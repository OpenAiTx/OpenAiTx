[![Electron 標誌](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions 建置狀態](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord 邀請](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: 可用翻譯：🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪。
可於我們的 [Crowdin](https://crowdin.com/project/electron) 專案中查看這些文件的其他語言版本。

Electron 框架讓你能夠使用 JavaScript、HTML 和 CSS 編寫跨平台的桌面應用程式。它基於 [Node.js](https://nodejs.org/) 和 [Chromium](https://www.chromium.org)，並被 [Visual Studio Code](https://github.com/Microsoft/vscode/) 以及許多其他[應用程式](https://electronjs.org/apps)所使用。

請在 Twitter 上關注 [@electronjs](https://twitter.com/electronjs) 以獲取重要公告。

本專案遵循 Contributor Covenant 的[行為準則](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md)。
參與本專案即表示你同意遵守此準則。如有任何不可接受的行為，請回報至 [coc@electronjs.org](mailto:coc@electronjs.org)。

## 安裝

要安裝預建的 Electron 二進位檔，請使用 [`npm`](https://docs.npmjs.com/)。
建議的方法是在你的應用程式中將 Electron 作為開發依賴安裝：

```sh
npm install electron --save-dev
```

更多安裝選項與疑難排解技巧，請參閱
[安裝說明](docs/tutorial/installation.md)。如需如何管理應用中的 Electron 版本資訊，請參閱
[Electron 版本管理](docs/tutorial/electron-versioning.md)。

## 平台支援

每個 Electron 發行版本都會提供 macOS、Windows 與 Linux 的二進位檔。

* macOS（Big Sur 及以上）：Electron 為 macOS 提供 64 位元 Intel 以及 Apple Silicon / ARM 的二進位檔。
* Windows（Windows 10 及以上）：Electron 為 Windows 提供 `ia32`（`x86`）、`x64`（`amd64`）與 `arm64` 二進位檔。Windows on ARM 支援自 Electron 5.0.8 起加入。對 Windows 7、8 與 8.1 的支援已於 [Electron 23 移除，符合 Chromium 的 Windows 停用政策](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice)。
* Linux：Electron 的預建二進位檔基於 Ubuntu 20.04。亦已驗證可運行於：
  * Ubuntu 18.04 及更新版本
  * Fedora 32 及更新版本
  * Debian 10 及更新版本

## Electron Fiddle

使用 [`Electron Fiddle`](https://github.com/electron/fiddle)
來建構、執行與封裝小型 Electron 實驗，查看所有 Electron API 的程式碼範例，
並嘗試不同版本的 Electron。這個工具旨在讓你更容易開始使用 Electron。

## 學習 Electron 的資源

* [electronjs.org/docs](https://electronjs.org/docs) - 所有 Electron 的官方文件
* [electron/fiddle](https://github.com/electron/fiddle) - 用於建構、執行與封裝小型 Electron 實驗的工具
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - 社群創建的範例起始應用程式

## 程式化使用

大多數人會在命令列中使用 Electron，但如果你在 **Node 應用程式**（不是 Electron 應用）中 require `electron`，它會回傳二進位檔的檔案路徑。可用於從 Node 腳本啟動 Electron：

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// 會輸出類似 /Users/maf/.../Electron 的路徑
console.log(electron)

// 啟動 Electron
const child = proc.spawn(electron)
```

### 鏡像站

* [中國](https://npmmirror.com/mirrors/electron/)

請參閱[進階安裝說明](https://www.electronjs.org/docs/latest/tutorial/installation#mirror)以了解如何使用自訂鏡像站。

## 文件翻譯

我們透過 [Crowdin](https://crowdin.com/project/electron) 眾包方式翻譯文件。
目前接受簡體中文、法文、德文、日文、葡萄牙文、俄文及西班牙文的翻譯。

## 貢獻

如果你有興趣回報／修復問題，並直接貢獻程式碼，請參閱 [CONTRIBUTING.md](CONTRIBUTING.md) 以獲得更多我們所需內容及如何開始的資訊。

## 社群

關於回報錯誤、尋求協助、尋找第三方工具與範例應用程式等更多資訊，請參閱 [社群頁面](https://www.electronjs.org/community)。

## 授權

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

使用 Electron 標誌時，請遵循 [OpenJS Foundation 商標政策](https://trademark-policy.openjsf.org/)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---