
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

## 📖 **Introduction**

> 📚 Projects  —  seraJs

🔗(Portfolio)[https://seraprogrammer.github.io/seraportfolio/] 

🔗(Demo blog)[https://seraprogrammer.github.io/serajsBlogsDemo/] 

```bash
npx degit sera-js/template my-app
cd my-app
```

**SeraJS** is a lightweight, **signal-based reactive JavaScript library** for
building dynamic user interfaces.

At just **969 bytes gzipped** and only **135 lines** of code, it's a remarkably lightweight reactive UI library — offering powerful reactivity with minimal overhead.

> ⚡️ _SeraJS focuses on **minimalism** and **performance** without sacrificing
> developer experience._


*Bundle Size Comparison (Minified + Gzipped)*

| Library | Size (gzipped) | Build Step Required | Main Purpose | Key Features |
|---------|----------------|---------------------|-------------|--------------|
| SeraJS | 1.25kb | Optional 😎 | Reactive UI | 135 lines of code, extremely lightweight |
| React | ~40kb | Yes | UI components | Virtual DOM, component-based architecture, JSX |
| Vue | ~33kb | Optional | Progressive framework | Reactive data binding, component system, single-file components |
| Solid.js | ~7kb | Yes | Reactive UI | No virtual DOM, compiled templates, fine-grained reactivity |
| Alpine.js | ~7.1kb | No | Lightweight framework | Minimal DOM manipulation, declarative syntax, works with existing HTML |
| Preact | ~4kb | Yes | React alternative | API compatible with React, smaller size, faster performance |
| htmx | ~14kb | No | AJAX enhancements | HTML attributes for AJAX, minimal JavaScript, server-side rendering friendly |



---

## ⚙️ **Core Concepts**

### 🔄 **Signal-Based Reactivity**

SeraJS uses a **signal-based reactive system**, a modern approach to state
management that enables efficient updates:

- 🧠 **Signals**  
  Self-contained reactive values that notify subscribers when they change.

- 🌀 **Effects**  
  Functions that automatically re-execute when their dependencies (signals)  
  change.

- 🧭 **Memo**  
  A memoization helper similar to React's `useMemo`, used to cache the result  
  of a computation based on reactive dependencies to avoid unnecessary
  recalculations.

- 🔬 **Fine-Grained Updates**  
  Only the specific DOM elements affected by state changes are updated,  
  resulting in minimal re-rendering and high performance.

> 💡 **SeraJS is designed to be intuitive, fast, and easy to integrate into any
> project — making it a perfect choice for modern frontend development.**


## Why SeraJS?

SeraJS brings together the best parts of libraries like React, Solid, and Lit — blending familiar patterns with a fresh, minimal approach.

At just 1.25KB gzipped and only 135 lines of code, this reactive UI library stays ultra-light while still delivering powerful reactivity.

Whether you want a build system or prefer a no-build workflow, SeraJS has you covered. It’s flexible enough to fit your dev style — use it how *you* want.


## 🌱 **Sera.js Basic Example**

A minimal example showing a Hello World message using Sera.js.

### 📄 App.jsx

```jsx
import { h } from "serajs";

export default function App() {
  return (
    <h1>Hello world</h1>
  );
}
```

## No Build, No Dependencies

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

