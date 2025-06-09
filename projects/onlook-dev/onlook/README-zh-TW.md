<!-- 提升返回頂部鏈接的兼容性：參見：https://github.com/othneildrew/Best-README-Template/pull/73 -->

<div align="center">
<img width="800" alt="header image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/web-preview.png">
<h3 align="center">Onlook</h3>
  <p align="center">
    設計師的游標
    <br />
    <a href="https://docs.onlook.com"><strong>探索文件 »</strong></a>
    <br />
    <br />
    <a href="https://youtu.be/RSX_3EaO5eU?feature=shared">觀看演示</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=bug&template=bug-report---.md">回報錯誤</a>
    ·
    <a href="https://github.com/onlook-dev/onlook/issues/new?labels=enhancement&template=feature-request---.md">請求功能</a>
  </p>
  <!-- PROJECT SHIELDS -->
<!--
*** 我正在使用 markdown「參考樣式」鏈接以提高可讀性。
*** 參考鏈接用方括號 [ ] 括起，而不是圓括號 ( )。
*** 參見本文底部有關 contributors-url、forks-url 等變數的宣告。
*** 這是一種可選的簡潔語法，你可以使用。
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<!-- [![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Apache License][license-shield]][license-url] -->

[![Discord][discord-shield]][discord-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Twitter][twitter-shield]][twitter-url]

[中文](https://www.readme-i18n.com/onlook-dev/onlook?lang=zh) | 
[Español](https://www.readme-i18n.com/onlook-dev/onlook?lang=es) | 
[Deutsch](https://www.readme-i18n.com/onlook-dev/onlook?lang=de) | 
[français](https://www.readme-i18n.com/onlook-dev/onlook?lang=fr) | 
[Português](https://www.readme-i18n.com/onlook-dev/onlook?lang=pt) | 
[Русский](https://www.readme-i18n.com/onlook-dev/onlook?lang=ru) | 
[日本語](https://www.readme-i18n.com/onlook-dev/onlook?lang=ja) | 
[한국어](https://www.readme-i18n.com/onlook-dev/onlook?lang=ko)

</div>

# 設計師的游標 —— 一款開源、以視覺為先的程式碼編輯器

使用 AI 在 Next.js + TailwindCSS 中打造網站、原型和設計。直接在瀏覽器 DOM 內進行可視化編輯。即時以程式碼設計。這是 Bolt.new、Lovable、V0、Replit Agent、Figma Make、Webflow 等工具的開源替代品。

### 🚧 🚧 🚧 Onlook for Web 仍在開發中 🚧 🚧 🚧

我們正在積極尋找貢獻者，協助打造 Onlook for Web 的優秀 prompt-to-build 體驗。請查閱[公開議題](https://github.com/onlook-dev/onlook/issues)以獲取完整的功能提案（及已知問題）清單，並加入我們的 [Discord](https://discord.gg/hERDfFZCsH) 與數百位其他建設者協作。

## 你可以用 Onlook 做什麼：

- [x] 幾秒鐘內創建 Next.js 應用
  - [x] 從文字或圖片開始
  - [ ] 使用預建模板
  - [ ] 從 Figma 匯入
  - [ ] 從 GitHub 倉庫開始
- [x] 可視化編輯你的應用
  - [x] 使用類似 Figma 的 UI
  - [x] 即時預覽你的應用
  - [x] 管理品牌資產與代幣
  - [x] 創建並導航至頁面
  - [ ] 瀏覽圖層 —— _此前在 [Onlook Desktop](https://github.com/onlook-dev/desktop)_
  - [ ] 偵測並使用元件 —— _此前在 [Onlook Desktop](https://github.com/onlook-dev/desktop)_
  - [ ] 管理專案圖片 —— _此前在 [Onlook Desktop](https://github.com/onlook-dev/desktop)_
- [x] 開發工具
  - [x] 即時程式碼編輯器
  - [x] 儲存與還原檢查點
  - [x] 通過 CLI 執行指令
  - [x] 連接應用程式市集
  - [ ] 本地編輯程式碼 —— _此前在 [Onlook Desktop](https://github.com/onlook-dev/desktop)_
- [ ] 幾秒內部署你的應用
  - [ ] 產生可分享連結
  - [ ] 綁定自訂網域
- [ ] 與團隊協作
  - [ ] 即時協作編輯
  - [ ] 留下評論

![Onlook-GitHub-Example](https://github.com/user-attachments/assets/642de37a-72cc-4056-8eb7-8eb42714cdc4)

### Onlook for Desktop（又名 Onlook Alpha）

我們正處於 Onlook Web 的早期預覽階段。如果你正在尋找可下載的桌面 Electron 應用程式，請前往 [Onlook Desktop](https://github.com/onlook-dev/desktop)。

為什麼我們要遷移到 Web？閱讀我們的決策解釋：[從 Electron 遷移到 Web](https://docs.onlook.com/docs/developer/electron-to-web-migration)

## 入門指南

即將可以通過[雲端應用](https://onlook.com)或[本地運行](https://docs.onlook.com/docs/developer/running-locally)使用。

### 使用方式

Onlook 可在任何 Next.js + TailwindCSS 專案中運行，將你的專案匯入 Onlook，或直接在編輯器內從頭開始。

使用 AI 聊天來創建或編輯你正在進行的專案。隨時都可以右鍵點擊元素，直接打開該元素在程式碼中的精確位置。

<img width="600" alt="image" src="https://github.com/user-attachments/assets/4ad9f411-b172-4430-81ef-650f4f314666" />

<br>

繪製新 div 並在父容器中拖放重新排列它們。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/insert-div.png">

<br>

將程式碼與網站設計並排預覽。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/code-connect.png">

<br>

利用 Onlook 的編輯器工具列調整 Tailwind 樣式，直接操作物件並嘗試不同版型。

<img width="600" alt="image" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/text-styling.png" />

## 文件

完整文件請參閱 [docs.onlook.com](https://docs.onlook.com)

查看如何貢獻，請參閱文件中的[貢獻指南](https://docs.onlook.com/docs/developer/contributing)。

## 運作原理

<img width="676" alt="architecture" src="https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/architecture.png">

1. 當你創建應用時，我們將程式碼載入至網頁容器
2. 容器運行並服務這些程式碼
3. 編輯器接收預覽連結，並在 iFrame 顯示
4. 編輯器從容器讀取並索引程式碼
5. 我們對程式碼進行儀器化，以將元素對應至程式碼位置
6. 當元素被編輯時，會先在 iFrame 內編輯該元素，然後同步到程式碼
7. 我們的 AI 聊天同樣具備程式碼存取與理解、編輯的工具

此架構理論上可擴展至任何以宣告式方式顯示 DOM 元素的語言或框架（如 jsx/tsx/html）。目前我們專注於讓它在 Next.js 和 TailwindCSS 上運作良好。

完整流程請參閱我們的[架構文件](https://docs.onlook.com/docs/developer/architecture)。

### 技術棧

#### 前端

- [Next.js](https://nextjs.org/) - 全端
- [TailwindCSS](https://tailwindcss.com/) - 樣式
- [tRPC](https://trpc.io/) - 伺服器介面

#### 資料庫

- [Supabase](https://supabase.com/) - 驗證、資料庫、儲存
- [Drizzle](https://orm.drizzle.team/) - ORM

#### AI

- [AI SDK](https://ai-sdk.dev/) - LLM 客戶端
- [Anthropic](https://ai-sdk.dev/) - LLM 模型供應商
- [Morph Fast Apply](https://morphllm.com) - 快速應用模型供應商
- [Relace](https://relace.ai) - 快速應用模型供應商

#### 沙盒與託管

- [CodeSandboxSDK](https://codesandbox.io/docs/sdk) - 開發沙盒
- [Freestyle](https://www.freestyle.sh/) - 託管

#### 執行時

- [Bun](https://bun.sh/) - Monorepo、執行時、打包器
- [Docker](https://www.docker.com/) - 容器管理

## 貢獻指南

![image](https://github.com/user-attachments/assets/ecc94303-df23-46ae-87dc-66b040396e0b)

如果你有任何建議能讓這個專案變得更好，歡迎 fork 本儲存庫並建立 pull request。你也可以
[提交議題](https://github.com/onlook-dev/onlook/issues)。

請參閱 [CONTRIBUTING.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/CONTRIBUTING.md) 以取得相關指引與行為準則。

#### 貢獻者

<a href="https://github.com/onlook-dev/onlook/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=onlook-dev/onlook" />
</a>

## 聯絡方式

![image](https://github.com/user-attachments/assets/60684b68-1925-4550-8efd-51a1509fc953)

- 團隊：[Discord](https://discord.gg/hERDfFZCsH) -
  [Twitter](https://twitter.com/onlookdev) -
  [LinkedIn](https://www.linkedin.com/company/onlook-dev/) -
  [電子郵件](mailto:contact@onlook.com)
- 專案：
  [https://github.com/onlook-dev/onlook](https://github.com/onlook-dev/onlook)
- 官方網站：[https://onlook.com](https://onlook.com)

## 授權

本專案採用 Apache 2.0 授權條款。詳情請參閱 [LICENSE.md](https://raw.githubusercontent.com/onlook-dev/onlook/main/LICENSE.md)。

<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/onlook-dev/studio.svg?style=for-the-badge
[contributors-url]: https://github.com/onlook-dev/onlook/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/onlook-dev/studio.svg?style=for-the-badge
[forks-url]: https://github.com/onlook-dev/onlook/network/members
[stars-shield]: https://img.shields.io/github/stars/onlook-dev/studio.svg?style=for-the-badge
[stars-url]: https://github.com/onlook-dev/onlook/stargazers
[issues-shield]: https://img.shields.io/github/issues/onlook-dev/studio.svg?style=for-the-badge
[issues-url]: https://github.com/onlook-dev/onlook/issues
[license-shield]: https://img.shields.io/github/license/onlook-dev/studio.svg?style=for-the-badge
[license-url]: https://github.com/onlook-dev/onlook/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/onlook-dev
[twitter-shield]: https://img.shields.io/badge/-Twitter-black?logo=x&colorB=555
[twitter-url]: https://x.com/onlookdev
[discord-shield]: https://img.shields.io/badge/-Discord-black?logo=discord&colorB=555
[discord-url]: https://discord.gg/hERDfFZCsH
[React.js]: https://img.shields.io/badge/react-%2320232a.svg?logo=react&logoColor=%2361DAFB
[React-url]: https://reactjs.org/
[TailwindCSS]: https://img.shields.io/badge/tailwindcss-%2338B2AC.svg?logo=tailwind-css&logoColor=white
[Tailwind-url]: https://tailwindcss.com/
[Electron.js]: https://img.shields.io/badge/Electron-191970?logo=Electron&logoColor=white
[Electron-url]: https://www.electronjs.org/
[Vite.js]: https://img.shields.io/badge/vite-%23646CFF.svg?logo=vite&logoColor=white
[Vite-url]: https://vitejs.dev/
[product-screenshot]: https://raw.githubusercontent.com/onlook-dev/onlook/main/assets/brand.png
[weave-shield]: https://img.shields.io/endpoint?url=https%3A%2F%2Fapp.workweave.ai%2Fapi%2Frepository%2Fbadge%2Forg_pWcXBHJo3Li2Te2Y4WkCPA33%2F820087727&cacheSeconds=3600&labelColor=#131313
[weave-url]: https://app.workweave.ai/reports/repository/org_pWcXBHJo3Li2Te2Y4WkCPA33/820087727

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---