<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sera-js&project=sera&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


![serajs (2)](https://github.com/user-attachments/assets/7ccff260-491d-420b-8e22-4579f9bad50a)

## 📖 **簡介**

> 📚 專案  —  seraJs

🔗(作品集)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(部落格示範)[https://seraprogrammer.github.io/serajsBlogsDemo/] 


```bash
npx degit sera-js/template my-app
cd my-app
```
**SeraJS** 是一個輕量級、**以 signal 為基礎的反應式 JavaScript 函式庫**，用於構建動態用戶介面。

僅有 **969 字節（gzip 壓縮）**，而且只有 **135 行程式碼**，這是一個極其輕量的反應式 UI 函式庫——在極小負擔下提供強大的反應能力。

> ⚡️ _SeraJS 專注於 **極簡主義** 和 **高效能**，同時不犧牲開發者體驗。_


*套件大小比較（壓縮與最小化後）*

| 函式庫 | 大小（gzip） | 是否需要建置步驟 | 主要用途 | 主要特點 |
|---------|----------------|---------------------|-------------|--------------|
| SeraJS | 1.25kb | 可選 😎 | 反應式 UI | 135 行程式碼，極度輕量 |
| React | ~40kb | 是 | UI 元件 | 虛擬 DOM、元件化架構、JSX |
| Vue | ~33kb | 可選 | 漸進式框架 | 反應式資料綁定、元件系統、單檔元件 |
| Solid.js | ~7kb | 是 | 反應式 UI | 無虛擬 DOM、編譯模板、細粒度反應性 |
| Alpine.js | ~7.1kb | 否 | 輕量框架 | 最小 DOM 操作、宣告式語法、可與現有 HTML 搭配 |
| Preact | ~4kb | 是 | React 替代品 | 與 React API 相容、更小體積、更快效能 |
| htmx | ~14kb | 否 | AJAX 增強 | 以 HTML 屬性控制 AJAX、極少 JavaScript、支援伺服器渲染 |



---

## ⚙️ **核心概念**

### 🔄 **以 Signal 為基礎的反應性**

SeraJS 採用 **以 signal 為基礎的反應系統**，這是一種現代的狀態管理方式，可實現高效的更新：

- 🧠 **Signals**  
  具備自身狀態的反應性數值，當其變動時會通知訂閱者。

- 🌀 **Effects**  
  當其依賴（signals）變動時自動重新執行的函式。

- 🧭 **Memo**  
  類似於 React 的 `useMemo`，根據反應性依賴快取運算結果，避免不必要的重算。

- 🔬 **細粒度更新**  
  只有受狀態變化影響的 DOM 元素會被更新，帶來最小重繪與高效能。

> 💡 **SeraJS 設計直觀、快速且易於整合到任何專案中——是現代前端開發的理想選擇。**


## 為什麼選擇 SeraJS？

SeraJS 結合了如 React、Solid 和 Lit 等函式庫的優點——融合了熟悉的模式與全新極簡的實現方式。

僅 1.25KB（gzip）與 135 行程式碼，這個反應式 UI 函式庫在超輕量下仍然提供強大反應能力。

無論你想使用建置系統，還是喜歡無建置流程，SeraJS 都能滿足你的需求。它足夠靈活，適合你的開發風格——你可以隨心所欲地使用它。


## 🌱 **Sera.js 基本範例**

以下是 Sera.js 實現 Hello World 訊息的極簡範例。

### 📄 App.jsx










```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```
## 無需建置，無需依賴


```html
<!DOCTYPE html>
<html>
  <head>
    <title>Sera js 😎</title>
  </head>
  <body>
    <script type="module">
      import { h, setSignal, setEffect } from "//unpkg.com/serajs";

      function Hello() {
        const [count, setCount] = setSignal(0);

        setEffect(() => {
          console.log(count());
        });

        return h(
          "div",
          null,
          h("h1", null, "Hello World!"),
          h("p", { style: { color: "red" } }, "Do you Like Serajs?"),
          h("h1", null, () => `Count: ${count()}`),
          h(
            "button",
            { onclick: () => setCount(count() + 1) },
            "Increase Count"
          )
        );
      }

      const root = document.body;
      root.appendChild(Hello());
    </script>
  </body>
</html>
```





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---