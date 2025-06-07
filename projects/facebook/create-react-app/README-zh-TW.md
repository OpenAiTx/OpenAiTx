## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## 已棄用
>
> Create React App 是 2017-2021 年間啟動 React 專案的關鍵工具之一，目前已進入長期維護狀態，我們建議你遷移到 [開始新的 React 專案](https://react.dev/learn/start-a-new-react-project) 中介紹的 React 框架之一。
>
> 如果你正在跟隨教學學習 React，繼續你的教學仍然有價值，但我們不建議以 Create React App 作為生產環境應用的起點。

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

建立無需建構設定的 React 應用程式。

- [建立應用程式](#creating-an-app) – 如何建立新應用程式。
- [使用者指南](https://facebook.github.io/create-react-app/) – 如何開發以 Create React App 建立的應用程式。

Create React App 支援 macOS、Windows 和 Linux。<br>
如果有任何問題，請[提交 Issue](https://github.com/facebook/create-react-app/issues/new)。<br>
如有疑問或需要協助，歡迎在 [GitHub Discussions](https://github.com/facebook/create-react-app/discussions) 詢問。

## 快速概覽

```sh
npx create-react-app my-app
cd my-app
npm start
```

如果你之前曾透過 `npm install -g create-react-app` 全域安裝過 `create-react-app`，建議你使用 `npm uninstall -g create-react-app` 或 `yarn global remove create-react-app` 卸載此套件，以確保 npx 總是使用最新版。

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) 內建於 npm 5.2+ 及更高版本，舊版 npm 使用者請參考[相關說明](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

然後開啟 [http://localhost:3000/](http://localhost:3000/) 以查看你的應用程式。<br>
當你準備好部署至生產環境時，請使用 `npm run build` 建立壓縮後的 bundle。

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### 立即開始

你**不需要**安裝或設定如 webpack 或 Babel 這類工具。<br>
它們已經預先配置並隱藏，讓你專注於撰寫程式碼。

建立專案後即可馬上開始。

## 建立應用程式

**你需要在本機開發機器上安裝 Node 14.0.0 或更高版本**（伺服器端不需安裝）。建議使用最新版 LTS。你可以使用 [nvm](https://github.com/creationix/nvm#installation)（macOS/Linux）或 [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) 在不同專案間切換 Node 版本。

建立新應用程式時，可以選擇以下其中一種方法：

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) 是 npm 5.2+ 版本內建的套件執行工具，舊版 npm 請參考[相關說明](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` 於 npm 6+ 可用_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) 於 Yarn 0.25+ 可用_

這會在目前資料夾下建立一個名為 `my-app` 的目錄。<br>
在該目錄中，會產生初始專案結構並安裝所有相依套件：

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

無需設定或複雜的資料夾結構，只有建立應用程式所需的檔案。<br>
安裝完成後，你可以打開專案資料夾：

```sh
cd my-app
```

在新建立的專案中，你可以執行一些內建指令：

### `npm start` 或 `yarn start`

以開發模式執行應用程式。<br>
開啟 [http://localhost:3000](http://localhost:3000) 在瀏覽器中檢視。

當你修改程式碼時，頁面會自動重新載入。<br>
你會在主控台看到建構錯誤和 lint 警告。

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` 或 `yarn test`

以互動模式執行測試監控。<br>
預設執行自上次提交以來變更檔案相關的測試。

[閱讀更多關於測試的說明。](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` 或 `yarn build`

將應用程式建構至 `build` 目錄以供生產環境使用。<br>
會以生產模式正確打包 React 並最佳化建構，以取得最佳效能。

建構結果已壓縮，檔名包含雜湊值。<br>

你的應用程式已可部署。

## 使用者指南

你可以在[官方文件](https://facebook.github.io/create-react-app/)找到詳細的 Create React App 使用說明及各種技巧。

## 如何升級至新版本？

請參考[使用者指南](https://facebook.github.io/create-react-app/docs/updating-to-new-releases)以獲得相關資訊。

## 設計理念

- **單一相依套件：** 只有一個建構相依。它底層使用 webpack、Babel、ESLint 及其他優秀專案，但在其上提供一致且完善的體驗。

- **無需設定：** 你不需要做任何設定。合理的開發與生產環境設定皆為你處理，讓你專注於撰寫程式碼。

- **無綁定：** 你可以隨時「彈出」（eject）到自訂設定。只需一個指令，所有設定與建構相依都會移到你的專案中，讓你直接接手管理。

## 內含什麼？

你的開發環境將擁有建構現代單頁 React 應用程式所需的一切：

- 支援 React、JSX、ES6、TypeScript 與 Flow 語法。
- 提供 ES6 以外的語法擴充，如物件展開運算子。
- 自動加前綴的 CSS，無需手動加入 `-webkit-` 等前綴。
- 內建覆蓋率報告的快速互動單元測試執行器。
- 可即時偵錯常見錯誤的開發伺服器。
- 可將 JS、CSS、圖片等檔案進行雜湊與原始碼對應的生產環境打包腳本。
- 支援離線的 [service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) 和 [web app manifest](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/)，符合所有 [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) 標準。（_注意：service worker 為 `react-scripts@2.0.0` 及以上版本選擇性啟用_）
- 只需一個相依，輕鬆更新上述工具。

參考[這份指南](https://github.com/nitishdayal/cra_closer_look)以了解這些工具如何整合。

這些工具**預設以特定方式配置**，如需更高自訂，請["彈出"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject)後自行維護設定。

## 常見替代方案

Create React App 非常適合：

- **學習 React**，提供舒適且功能豐富的開發環境。
- **啟動新的單頁 React 應用程式。**
- **為你的函式庫或元件建立範例。**

有些情境你可能會想選擇其他工具：

- 若你想要**試用 React**，但不希望安裝大量建構工具相依，建議[只用一個 HTML 檔案或線上沙盒](https://reactjs.org/docs/getting-started.html#try-react)。

- 若你需要將 React 程式碼**整合至伺服器端樣板框架**（如 Rails、Django 或 Symfony），或**不是製作單頁應用程式**，可考慮 [nwb](https://github.com/insin/nwb) 或更彈性的 [Neutrino](https://neutrino.js.org/)。Rails 可用 [Rails Webpacker](https://github.com/rails/webpacker)，Symfony 可用 [Symfony 的 webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html)。

- 若你需要**發佈 React 元件**，[nwb](https://github.com/insin/nwb) [也支援此功能](https://github.com/insin/nwb#react-components-and-libraries)，或使用 [Neutrino 的 react-components preset](https://neutrino.js.org/packages/react-components/)。

- 若你想用 React + Node.js 做**伺服器端渲染**，請參考 [Next.js](https://nextjs.org/) 或 [Razzle](https://github.com/jaredpalmer/razzle)。Create React App 與後端無關，只產生靜態 HTML/JS/CSS。

- 若你網站**大多為靜態內容**（如作品集或部落格），可考慮 [Gatsby](https://www.gatsbyjs.org/) 或 [Next.js](https://nextjs.org/)。不同於 Create React App，Gatsby 於建構時預先產生 HTML，Next.js 支援伺服器端渲染與預先渲染。

- 若你需要**更多自訂**，請參考 [Neutrino](https://neutrino.js.org/) 及其 [React preset](https://neutrino.js.org/packages/react/)。

上述所有工具皆可零設定或少量設定即可運作。

若你偏好自行配置建構，請[參考這份指南](https://reactjs.org/docs/add-react-to-a-website.html)。

## React Native

想找類似於 React Native 的工具嗎？<br>
請參考 [Expo CLI](https://github.com/expo/expo-cli)。

## 貢獻

我們非常歡迎你貢獻 `create-react-app`！請參考 [CONTRIBUTING.md](CONTRIBUTING.md) 以瞭解我們的需求與如何開始。

## 支持 Create React App

Create React App 是社群維護的專案，所有貢獻者皆為志工。如果你願意支持 Create React App 的未來發展，請考慮捐款至我們的 [Open Collective](https://opencollective.com/create-react-app)。

## 致謝

此專案能夠運作，多虧了所有[貢獻者](CONTRIBUTING.md)。<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

感謝 [Netlify](https://www.netlify.com/) 提供文件託管。

## 鳴謝

我們感謝相關專案作者的點子與協作：

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## 授權

Create React App 是開源軟體，[採用 MIT 授權](https://github.com/facebook/create-react-app/blob/main/LICENSE)。Create React App 標誌採用 [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/) 授權。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---