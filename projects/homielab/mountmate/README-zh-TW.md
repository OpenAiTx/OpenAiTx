# 🚀 MountMate

_一款簡單的 macOS 選單列應用程式，用於管理您的外接硬碟。_

<p align="center">
  <img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/assets/icon.png" alt="MountMate Icon" width="100" height="100" style="border-radius: 22%; border: 0.5px solid rgba(0,0,0,0.1);" />
</p>

<p align="center">
  <a href="https://github.com/homielab/mountmate/releases">
    <img src="https://img.shields.io/github/v/release/homielab/mountmate?label=release&style=flat-square" />
  </a>
  <a href="https://github.com/homielab/mountmate">
    <img src="https://img.shields.io/github/downloads/homielab/mountmate/total?style=flat-square" />
  </a>
  <a href="https://brew.sh">
    <img src="https://img.shields.io/badge/homebrew-supported-blue?style=flat-square" />
  </a>
</p>

---

## ⚡️ 快速開始

透過 [Homebrew](https://brew.sh) 安裝：

```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
或者 [下載最新的 .dmg](https://github.com/homielab/mountmate/releases)，並將 MountMate.app 拖入您的應用程式資料夾。

## 🧩 什麼是 MountMate？

MountMate 是一款輕量級 macOS 選單列工具，讓您可以**一鍵掛載和卸載外接磁碟** — 不用終端機、不用磁碟工具，完全無負擔。

無論您是在處理吵雜的旋轉硬碟，或想更精細地控制磁碟何時啟用，MountMate 都能從選單列為您提供簡潔且有效的解決方案。

## 🧠 為什麼我開發它

我有一顆 4TB 外接硬碟 24/7 連接在 Mac mini。因為是旋轉硬碟，macOS 總是會把它轉起來 — 只是為了像是打開 Finder 或執行 Spotlight 這種小事。結果是：

- 不必要的噪音
- 系統變慢
- 浪費能源

我試過：

- 磁碟工具 — 太慢又笨重
- 自訂 shell 腳本 — 太技術
- 現有第三方應用程式 — 太肥大或運作不良

於是我做了 **MountMate**。

## ✅ 功能

- 檢視所有連接的 **外接磁碟**
- 查看哪些已經 **掛載**
- 點擊即可 **掛載/卸載** 任一磁碟
- 檢查可用的 **剩餘空間**
- 靜靜地運行於 **選單列**
- 完全原生 — 無 Electron，無依賴

## ✨ 為何使用 MountMate？

macOS 會自動掛載插入的磁碟 — 但沒有**簡單的方式可以重新掛載**，除非使用終端機或磁碟工具。MountMate 非常適合：

- 不常用的外接硬碟
- 僅用於備份的磁碟
- 降低磨損與噪音
- 提升系統反應速度

## 🔐 私密、快速且安全

MountMate **完全離線運作**，使用原生 macOS API 與命令列工具。它：

- 不會追蹤任何資訊
- 不需連網
- 不會存取您的檔案
- 不需 root 權限

就是一個專注做好一件事的乾淨工具。

## 🖼️ 截圖

<img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light.png" width="300" /><img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/dark.png" width="300" />

![完整截圖](https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light-full.png)

## 🛠️ 安裝

### 手動安裝

1. [下載最新的 `.dmg` 版本](https://github.com/homielab/mountmate/releases)
2. 開啟 `.dmg` 檔案
3. 將 `MountMate.app` 拖入 **應用程式** 資料夾
4. 卸載安裝器磁碟映像
5. 從 **應用程式** 啟動 MountMate

### 透過 Homebrew 安裝

如果您已安裝 [Homebrew](https://brew.sh)，可以直接從此儲存庫安裝 MountMate：


```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
### macOS 首次使用

- 如果看到 MountMate 來自未識別的開發者的警告，請前往：  
  **系統設定 → 隱私與安全性 → 仍要開啟**
- 確保你已連接網路，以讓 macOS 驗證應用程式並接收更新

## 📫 反饋與貢獻

MountMate 是為了解決我個人的工作流程問題而開發，但我也希望能為其他人改進。
歡迎隨時[開啟問題](https://github.com/homielab/mountmate/issues)或提出改進建議！

## 🤝 支持

如果你覺得 MountMate 有幫助，請考慮支持它的開發：

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/homielab)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---