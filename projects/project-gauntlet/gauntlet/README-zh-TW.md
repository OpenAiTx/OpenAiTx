# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

以網頁為主、跨平台的應用程式啟動器，支援基於 React 的插件

> [!WARNING]
> 啟動器由單一開發者在空閒時間開發。
> 變更可能會比較慢，但會持續進行
>
> 可能會有重大變更，這些會在 [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md) 中記錄。

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## 演示

略為過時的演示

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## 功能

- 以插件為優先
  - 插件使用 TypeScript 編寫
  - 完善的插件 API
      - 創建 UI 視圖
      - 一次性命令
      - 動態提供一次性命令清單
      - 根據主搜尋框中的值，直接在其下方渲染快速「內嵌」內容
      - 從剪貼簿獲取內容並新增內容到剪貼簿
  - 插件作為 Git 儲存庫中的獨立分支發佈，意味著插件分發不需要任何中央伺服器
  - 插件 ID 只需使用 Git 儲存庫網址
  - [React](https://github.com/facebook/react) 為插件提供 UI
    - 以自訂 React Reconciler 實現（非 Electron）
  - [Deno JavaScript 執行環境](https://github.com/denoland/deno)
    - Deno 允許對 JavaScript 插件程式碼進行沙盒化，以提升安全性
    - 插件必須明確指定需要的權限
    - Node.js 用於執行插件工具，但作為插件開發者，你始終編寫在 Deno 上運行的程式碼
- 從設計之初即考慮跨平台
- 命令與視圖可透過自訂全域快捷鍵執行／開啟
- 可以為命令或視圖分配自訂搜尋別名
- 支援自訂主題
- 內建功能由內建插件提供
  - 應用程式：在搜尋結果中顯示系統已安裝的應用程式
    - 插件同時追蹤視窗以及所屬應用程式，因此預設情況下，開啟已開啟的應用程式會喚醒先前建立的視窗
      - 目前並非所有系統都受支援。請參見 [功能支援情況](https://gauntlet.sh/docs/feature-support)
  - 計算機：在主搜尋框下方直接顯示數學運算結果
    - 包含利用匯率進行貨幣換算
    - 由 [Numbat](https://github.com/sharkdp/numbat) 提供技術支援
- 基於 Frecency 的搜尋結果排序
   - Frecency 為頻率與最近性的結合
   - 項目使用次數越多，在結果列表中排名越高，但過去常用但近期未用的項目，排名會低於近期頻繁使用的項目
   - 結果以子字串逐字比對每個單字

##### 作業系統支援

##### 官方支援
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### 最佳努力支援
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - 尚未支援 Gnome Wayland，請見 [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## 入門指南

### 安裝 Gauntlet

請參見 [安裝說明](https://gauntlet.sh/docs/installation)

### 全域快捷鍵

主視窗可透過全域快捷鍵或 CLI 指令開啟：
- 全域快捷鍵（可於設定中更改）
  - Windows：<kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11：<kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - 可能不支援全域快捷鍵，請參見 [功能支援情況](https://gauntlet.sh/docs/feature-support)
    - 請改用 CLI 指令，並依視窗管理器方式啟用
  - macOS：<kbd>CMD</kbd> + <kbd>Space</kbd>
- CLI 指令
  - `gauntlet open`

### 安裝插件

插件可於設定 UI 中安裝。請使用插件的 Git 儲存庫網址，例如 `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### 開發你自己的插件

請參見 [插件開發入門](https://gauntlet.sh/docs/plugin-development/getting-started)

## 主題設計

請參見 [主題設計](https://gauntlet.sh/docs/theming)

## 編譯 Gauntlet

你需要準備：
- NodeJS
- Rust
- Protobuf 編譯器
- CMake（專案本身未直接使用，但某些相依套件需要）
- Linux 系統需安裝：`libxkbcommon-dev`（注意：不同發行版名稱可能略有不同）

### 開發模式

進行開發編譯，請執行：
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
在開發模式（未啟用 "release" 功能）下，應用程式僅會在專案目錄內部建立資料夾以儲存狀態或快取，以避免影響全域安裝

### 尚未封裝發佈

編譯尚未封裝的發佈版本二進位檔，請執行：
```bash
npm ci
npm run build
cargo build --release --features release
```

### 已封裝發佈
要編譯特定作業系統的封裝套件，請依下列指令：

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

但新版本發佈需透過 GitHub Actions 完成

## 貢獻

如果你希望協助開發 Gauntlet，除了貢獻程式碼還有其他方式：
- 回報錯誤或 UI/UX 問題
- 創建插件

針對簡單問題，歡迎直接提交 Issue 或 PR 並自行處理。
若是重大更動，請先在 Discord（邀請連結在 README 頂部）聯絡開發者討論。

歡迎各種貢獻。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---