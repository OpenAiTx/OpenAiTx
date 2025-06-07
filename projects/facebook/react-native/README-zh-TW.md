<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>一次學習，隨處撰寫：</strong><br>
  使用 React 構建行動應用程式。
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native 採用 MIT 授權條款發佈。" />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="目前 npm 套件版本。" />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="歡迎 PRs!" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="追蹤 @reactnative" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">快速開始</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">學習基礎</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">展示案例</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">參與貢獻</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">社群</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">支援</a>
</h3>

React Native 將 [**React** 的][r] 宣告式 UI 框架帶到 iOS 和 Android 平台。利用 React Native，您可以使用原生 UI 控制項，並完全存取原生平台。

- **宣告式。** React 讓建立互動式 UI 變得輕鬆簡單。宣告式視圖讓您的程式碼更具可預測性且更易於除錯。
- **元件化。** 建立封裝良好的元件以管理其狀態，然後組合它們來製作複雜的 UI。
- **開發者效率。** 幾秒內即可看到本地變更。JavaScript 代碼的修改可即時重新載入，無需重新建構原生應用。
- **可攜性。** 跨 iOS、Android 及[其他平台][p]重複使用程式碼。

React Native 由許多公司與核心貢獻者共同開發與支援。更多資訊請參閱我們的[生態系總覽][e]。

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## 目錄

- [需求](#-requirements)
- [建立您的第一個 React Native 應用程式](#-building-your-first-react-native-app)
- [文件](#-documentation)
- [升級](#-upgrading)
- [如何貢獻](#-how-to-contribute)
- [行為守則](#code-of-conduct)
- [授權條款](#-license)


## 📋 需求

React Native 應用程式可支援 iOS 15.1 及 Android 7.0 (API 24) 或更新版本。您可以使用 Windows、macOS 或 Linux 作為開發作業系統，不過構建與執行 iOS 應用僅限於 macOS。可利用 [Expo](https://expo.dev) 等工具來繞過此限制。

## 🎉 建立您的第一個 React Native 應用程式

請依循 [快速開始指南](https://reactnative.dev/docs/getting-started)。建議安裝 React Native 的方式取決於您的專案需求。以下為最常見情境的簡要指南：

- [試用 React Native][hello-world]
- [建立新應用程式][new-app]
- [將 React Native 加入現有應用程式][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 文件

完整的 React Native 文件可在我們的[網站][docs]上找到。

React Native 文件涵蓋了專屬於 React Native 的元件、API 與主題。若需進一步瞭解 React Native 與 React DOM 共享的 React API，請參考 [React 文件][r-docs]。

React Native 文件與網站的原始碼託管於獨立的版本庫 [**@facebook/react-native-website**][repo-website]。

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 升級

升級至新版 React Native 可以獲得更多 API、視圖、開發工具及其他新功能。請參閱[升級指南][u]以獲得詳細說明。

React Native 的版本發佈與討論請參見[此討論倉庫](https://github.com/reactwg/react-native-releases/discussions)。

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 如何貢獻

本倉庫的主要目標是持續發展 React Native 核心。我們希望讓大家能夠簡單透明地參與本專案，非常感謝社群成員對於錯誤修復與改進的貢獻。請繼續閱讀了解如何參與改進 React Native。

### [行為守則][code]

Facebook 採納了一份行為守則，期望所有參與者遵守。請閱讀[完整內容][code]，以瞭解哪些行為是允許或禁止的。

[code]: https://code.fb.com/codeofconduct/

### [貢獻指南][contribute]

請閱讀我們的[**貢獻指南**][contribute]，了解我們的開發流程、如何提出錯誤修復與改進建議，以及如何構建與測試您對 React Native 所做的更動。

[contribute]: https://reactnative.dev/docs/contributing

### [開放原始碼藍圖][roadmap]

您可以在[**藍圖**][roadmap]中了解我們對 React Native 的願景。

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### 適合新手的議題

我們有一份[適合新手的議題][gfi]清單，這些是範圍相對有限的錯誤修復，非常適合初學者參與，累積經驗並熟悉我們的貢獻流程。

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### 討論區

更大範圍的討論與提案請至 [**@react-native-community/discussions-and-proposals**][repo-meta]。

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 授權條款

React Native 採用 MIT 授權條款，詳見 [LICENSE][l] 檔案。

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---