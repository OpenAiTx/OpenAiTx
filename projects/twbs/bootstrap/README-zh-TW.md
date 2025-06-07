<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  俐落、直觀且強大的前端框架，讓網頁開發更快、更容易。
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>探索 Bootstrap 文件 »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">回報錯誤</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">需求新功能</a>
  ·
  <a href="https://themes.getbootstrap.com/">主題</a>
  ·
  <a href="https://blog.getbootstrap.com/">部落格</a>
</p>


## Bootstrap 5

我們的預設分支用於 Bootstrap 5 版本的開發。如需查看 Bootstrap 4 的說明文件與原始碼，請前往 [`v4-dev` 分支](https://github.com/twbs/bootstrap/tree/v4-dev)。


## 目錄

- [快速開始](#快速開始)
- [狀態](#狀態)
- [包含內容](#包含內容)
- [錯誤與功能請求](#錯誤與功能請求)
- [文件](#文件)
- [貢獻指南](#貢獻指南)
- [社群](#社群)
- [版本管理](#版本管理)
- [創作者](#創作者)
- [感謝](#感謝)
- [版權與授權](#版權與授權)


## 快速開始

有多種快速開始方式可供選擇：

- [下載最新版本](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- 複製原始碼庫：`git clone https://github.com/twbs/bootstrap.git`
- 使用 [npm](https://www.npmjs.com/) 安裝：`npm install bootstrap@v5.3.6`
- 使用 [yarn](https://yarnpkg.com/) 安裝：`yarn add bootstrap@v5.3.6`
- 使用 [Bun](https://bun.sh/) 安裝：`bun add bootstrap@v5.3.6`
- 使用 [Composer](https://getcomposer.org/) 安裝：`composer require twbs/bootstrap:5.3.6`
- 使用 [NuGet](https://www.nuget.org/) 安裝：CSS：`Install-Package bootstrap` Sass：`Install-Package bootstrap.sass`

請參閱 [入門頁面](https://getbootstrap.com/docs/5.3/getting-started/introduction/)，瞭解框架內容、範本、範例等資訊。


## 狀態

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## 包含內容

下載後，您會發現下列目錄和檔案，將常用資源做有邏輯的分組，並提供已編譯和壓縮的多種版本。

<details>
  <summary>下載內容</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

我們提供已編譯的 CSS 和 JS（`bootstrap.*`），以及已編譯並壓縮的 CSS 和 JS（`bootstrap.min.*`）。[原始碼對應地圖](https://web.dev/articles/source-maps)（`bootstrap.*.map`）可用於部分瀏覽器的開發者工具。打包的 JS 檔案（`bootstrap.bundle.js` 及壓縮版 `bootstrap.bundle.min.js`）已包含 [Popper](https://popper.js.org/docs/v2/)。


## 錯誤與功能請求

有錯誤或功能需求嗎？請先閱讀 [議題指南](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) 並搜尋現有與已關閉的議題。如果您的問題或想法尚未被提出，[請開啟新的議題](https://github.com/twbs/bootstrap/issues/new/choose)。


## 文件

Bootstrap 的文件包含在本原始碼庫的根目錄，並以 [Astro](https://astro.build/) 建構，公開託管於 GitHub Pages：<https://getbootstrap.com/>。文件也可在本地執行。

文件搜尋由 [Algolia 的 DocSearch](https://docsearch.algolia.com/) 提供支援。

### 在本地執行文件

1. 執行 `npm install` 以安裝 Node.js 相依套件（包括 Astro 網站建構工具）。
2. 執行 `npm run test`（或指定 npm 指令）以重新建構已發佈的 CSS、JavaScript 及文件資源。
3. 在 `/bootstrap` 根目錄下於命令列執行 `npm run docs-serve`。
4. 在瀏覽器開啟 `http://localhost:9001/`，即可瀏覽。

進一步瞭解 Astro 的使用，請閱讀其[官方文件](https://docs.astro.build/en/getting-started/)。

### 先前版本的文件

您可以在 <https://getbootstrap.com/docs/versions/> 找到我們所有先前版本的說明文件。

[歷史發行版本](https://github.com/twbs/bootstrap/releases)及其說明文件也可下載。


## 貢獻指南

請詳閱我們的 [貢獻指南](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md)。內含開啟議題、程式撰寫標準及開發注意事項。

此外，如您的 Pull Request 包含 JavaScript 修補或新功能，必須附上 [相關單元測試](https://github.com/twbs/bootstrap/tree/main/js/tests)。所有 HTML 和 CSS 應遵循 [Code Guide](https://github.com/mdo/code-guide)，由 [Mark Otto](https://github.com/mdo) 維護。

編輯器偏好設定可於 [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) 取得，方便於常用文字編輯器使用。更多資訊及外掛下載請見 <https://editorconfig.org/>。


## 社群

獲取 Bootstrap 開發動態，並與專案維護者與社群成員交流。

- 追蹤 [@getbootstrap on X](https://x.com/getbootstrap)。
- 閱讀並訂閱 [官方 Bootstrap 部落格](https://blog.getbootstrap.com/)。
- 發問與探索 [我們的 GitHub 討論區](https://github.com/twbs/bootstrap/discussions)。
- 於 [社群 Discord](https://discord.gg/bZUvakRU3M) 或 [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/) 討論、提問。
- 在 IRC 與其他 Bootstrappers 聊天。伺服器：`irc.libera.chat`，頻道：`#bootstrap`。
- 可於 Stack Overflow（標記 [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)）尋求實作協助。
- 開發者在通過 [npm](https://www.npmjs.com/browse/keyword/bootstrap) 或類似發佈機制分發套件時，應使用關鍵字 `bootstrap` 以利搜尋。


## 版本管理

為了讓發佈流程透明，並盡力維持向下相容，Bootstrap 依循 [語意化版本管理規範](https://semver.org/)。有時我們會犯錯，但盡可能遵守這些規則。

各版本變更日誌請參閱 [GitHub 專案的發行記錄](https://github.com/twbs/bootstrap/releases)。每次發佈的重大變動摘要可見於 [官方 Bootstrap 部落格](https://blog.getbootstrap.com/)。


## 創作者

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## 感謝

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

感謝 [BrowserStack](https://www.browserstack.com/) 提供可在真實瀏覽器中測試的基礎設施！

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

感謝 [Netlify](https://www.netlify.com/) 提供 Deploy Previews 服務！


## 贊助商

支持本專案，成為贊助商。您的標誌將顯示於此，並附上連結至您的網站。[[成為贊助商](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## 支持者

感謝所有支持者！🙏 [[成為支持者](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## 版權與授權

原始碼與文件著作權 2011-2025 [Bootstrap 作者群](https://github.com/twbs/bootstrap/graphs/contributors)。程式碼以 [MIT 授權條款](https://github.com/twbs/bootstrap/blob/main/LICENSE) 發佈。文件以 [Creative Commons](https://creativecommons.org/licenses/by/3.0/) 授權發佈。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---