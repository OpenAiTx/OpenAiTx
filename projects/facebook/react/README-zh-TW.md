# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React 是一個用於構建使用者介面的 JavaScript 函式庫。

* **宣告式（Declarative）：**React 讓建立互動式 UI 變得輕鬆無痛。為應用程式中的每個狀態設計簡單的視圖，當你的資料變更時，React 會高效地更新並渲染正確的元件。宣告式視圖使你的程式碼更具可預測性、更易於理解且更容易除錯。
* **元件化（Component-Based）：**構建封裝自身狀態的元件，然後將它們組合以製作複雜的 UI。由於元件邏輯是用 JavaScript 而非模板撰寫，你可以輕鬆地在應用程式中傳遞豐富資料，並將狀態與 DOM 分離。
* **一次學會，到處撰寫（Learn Once, Write Anywhere）：**我們不對你的技術棧做假設，因此你可以在不重寫現有程式碼的情況下，在 React 中開發新功能。React 也可以利用 [Node](https://nodejs.org/en) 在伺服器端渲染，並透過 [React Native](https://reactnative.dev/) 推動行動應用程式。

[瞭解如何在你的專案中使用 React](https://react.dev/learn)。

## 安裝

React 從一開始就被設計為可逐步採用，**你可以根據需要使用少量或大量的 React**：

* 使用 [快速開始](https://react.dev/learn) 體驗 React。
* [將 React 加入現有專案](https://react.dev/learn/add-react-to-an-existing-project)，按需求選擇使用多少 React。
* [建立新的 React 應用程式](https://react.dev/learn/start-a-new-react-project)，如果你需要強大的 JavaScript 工具鏈。

## 文件

你可以在 [官方網站](https://react.dev/) 找到 React 的文件。

請參閱 [入門指南](https://react.dev/learn) 以快速瀏覽。

文件分為幾個部分：

* [快速開始](https://react.dev/learn)
* [教學課程](https://react.dev/learn/tutorial-tic-tac-toe)
* [React 思維](https://react.dev/learn/thinking-in-react)
* [安裝](https://react.dev/learn/installation)
* [描述 UI](https://react.dev/learn/describing-the-ui)
* [新增互動性](https://react.dev/learn/adding-interactivity)
* [狀態管理](https://react.dev/learn/managing-state)
* [進階指南](https://react.dev/learn/escape-hatches)
* [API 參考](https://react.dev/reference/react)
* [取得支援的管道](https://react.dev/community)
* [貢獻指南](https://legacy.reactjs.org/docs/how-to-contribute.html)

你可以透過向[此儲存庫](https://github.com/reactjs/react.dev)提交 pull request 來改進文件。

## 範例

我們在[官方網站](https://react.dev/)上有多個範例。這是第一個幫助你入門的範例：

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

此範例會將「Hello Taylor」渲染到頁面上的某個容器中。

你會發現我們使用了類似 HTML 的語法；[我們稱之為 JSX](https://react.dev/learn#writing-markup-with-jsx)。使用 React 並不強制需要 JSX，但它讓程式碼更易讀，撰寫時也更像寫 HTML。

## 貢獻

本儲存庫的主要目的是持續發展 React 核心，使其更快速且更易於使用。React 的開發在 GitHub 上公開進行，我們感謝社群對於錯誤修正及改進的貢獻。請閱讀下方內容，瞭解你如何參與 React 的改進。

### [行為準則](https://code.fb.com/codeofconduct)

Facebook 採用了行為準則，我們期望專案參與者能遵守。請閱讀[完整內容](https://code.fb.com/codeofconduct)，以便瞭解哪些行為是被接受或不被接受的。

### [貢獻指南](https://legacy.reactjs.org/docs/how-to-contribute.html)

請閱讀我們的[貢獻指南](https://legacy.reactjs.org/docs/how-to-contribute.html)，瞭解我們的開發流程、如何提出錯誤修正與改進建議，以及如何構建和測試你對 React 的變更。

### [Good First Issues](https://github.com/facebook/react/labels/good%20first%20issue)

為了幫助你初步參與並熟悉我們的貢獻流程，我們準備了一份 [good first issues](https://github.com/facebook/react/labels/good%20first%20issue) 清單，裡面包含範圍相對有限的錯誤。這是一個不錯的起點。

### 授權

React 採用 [MIT 授權](./LICENSE)。

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---