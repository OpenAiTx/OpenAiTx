![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## 指南

NoteGen 是一款跨平台的 `Markdown` 筆記應用，致力於用 AI 打通記錄和寫作，將碎片化知識整理為可閱讀的筆記。

🖥️ 官方文件: [https://notegen.top](https://notegen.top)

💬 加入 [微信/QQ 群](https://github.com/codexu/note-gen/discussions/110)

## 為什麼選擇 NoteGen？

- 輕量級：[安裝包](https://github.com/codexu/note-gen/releases) **僅 20MB**，免費無廣告，無捆綁軟體。
- 跨平台：支持 Mac、Windows、Linux，並得益於 `Tauri2` 的跨平台能力，未來將支持 iOS 和 Android。
- 支持多種記錄方式，包括 `截圖`、`文字`、`插圖`、`檔案`、`鏈接`等，滿足各種場景下的碎片記錄需求。
- 原生 `Markdown(.md)` 作為存儲格式，無任何改動，便於遷移。
- 原生離線使用，支持實時同步到 `GitHub、Gitee 私有倉庫`，並可歷史回滾，同時支持 WebDAV 同步。
- AI 增強：可配置 ChatGPT、Gemini、Ollama、LM Studio、Grok 及其它模型，支持自定義第三方模型配置。
- RAG：你的筆記就是你的知識庫。支持嵌入模型和重排序模型。

## 截圖

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

記錄：

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

寫作：

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

主題：

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## 從記錄到寫作

傳統筆記應用通常不提供記錄功能，用戶需要手動複製粘貼內容進行記錄，極大影響效率。面對零散的記錄內容，還需耗費大量精力進行整理。

NoteGen 分為 `記錄` 頁和 `寫作` 頁，彼此關係如下：

- 記錄可以整理成筆記並轉入寫作頁進行深度創作。
- 寫作時可隨時插入記錄內容。

### 記錄

記錄功能類似於一個 **AI 聊天機器人**，但和它對話時可以關聯之前的記錄內容，從對話模式切換到整理模式，將記錄整理成可閱讀的筆記。

以下輔助功能幫助你更高效地記錄：

- **標籤**，區分不同記錄場景。
- **角色**，支持自定義提示詞，精確控制你的 AI 助手。
- **剪貼板助手**，自動識別剪貼板中的文字或圖片，並記錄到你的列表。

### 寫作

寫作部分分為 **檔案管理器** 和 **Markdown 編輯器** 兩大部分。

**檔案管理器**

- 支持本地 Markdown 檔案管理及 GitHub 同步檔案管理。
- 支持無限目錄層級。
- 支持多種排序方式。

**Markdown 編輯器**

- 支持所見即所得、即時渲染、分屏預覽模式。
- 支持版本控制及歷史回滾。
- 支持 AI 助手對話、續寫、潤色、翻譯等功能。
- 支持圖床，圖片上傳並轉換為 Markdown 圖片鏈接。
- 支持 HTML 轉 Markdown，自動將瀏覽器複製內容轉換為 Markdown 格式。
- 支持大綱、數學公式、心智圖、圖表、流程圖、甘特圖、時序圖、五線譜、多媒體、語音朗讀、標題錨點、程式碼高亮及複製、graphviz 渲染、plantuml UML 圖等。
- 支持本地內容即時保存、延遲（10 秒無編輯）自動同步及歷史回滾。

## 其他功能

- 全局搜尋，快速定位跳轉特定內容。
- 圖床管理，便捷管理圖床內容。
- 主題與外觀，支持暗色主題和 Markdown、程式碼等外觀設置。
- 國際化支持，目前提供中文和英文。

## 如何使用？

### 下載

目前支持 Mac、Windows、Linux。得益於 Tauri2 的跨平台能力，未來將支持 iOS 和 Android。

[下載 NoteGen（alpha 版）](https://github.com/codexu/note-gen/releases)

### 增強

筆記應用可直接使用無需配置，如需更好體驗，請打開設置頁配置 AI 和同步。

## 參與貢獻

- [閱讀貢獻指南](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [更新計劃](https://github.com/codexu/note-gen/issues/46)
- [提交 bug 或改進建議](https://github.com/codexu/note-gen/issues)
- [討論區](https://github.com/codexu/note-gen/discussions)

## 貢獻者

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---