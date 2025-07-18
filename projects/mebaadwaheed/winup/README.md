
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Image Examples

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Make sure to download the Latest Stable Release (LSR) and not the latest/LFR! Current LSR: 2.4.9

`pip install winup==2.4.9`

**A ridiculously Pythonic and powerful framework for building beautiful desktop applications.**

WinUp is a modern UI framework for Python that wraps the power of PySide6 (Qt) in a simple, declarative, and developer-friendly API. It's designed to let you build applications faster, write cleaner code, and enjoy the development process.

### ✨ Now with Web Support!
WinUp now also supports building fully interactive, stateful web applications using the same Python-centric, component-based approach. The web module uses FastAPI and WebSockets under the hood to bring the simplicity of WinUp to the browser.

[Web Documentation](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Disclaimer:** Web support is an optional feature. To use it, you must install the web dependencies:
> ```bash
> pip install "winup[web]"
> ```

[Contributing](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Changelog](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[License](LICENSE)

---

## Why WinUp? (Instead of raw PySide6 or Tkinter)

Desktop development in Python can feel clunky. WinUp was built to fix that.

| Feature                 | WinUp Way ✨                                                                   | Raw PySide6 / Tkinter Way 😟                                                                |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- |
| **Layouts**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **Styling**             | `props={"background-color": "blue", "font-size": "16px"}`                      | Manual QSS strings, `widget.setStyleSheet(...)`, complex style objects.                     |
| **State Management**    | `state.bind(widget, "prop", "key")`                                            | Manual callback functions, getters/setters, `StringVar()`, boilerplate everywhere.          |
| **Two-Way Binding**     | `state.bind_two_way(input_widget, "key")`                                      | Non-existent. Requires manual `on_change` handlers to update state and UI.                  |
| **Developer Tools**     | **Built-in Hot Reloading**, code profiler, and window tools out of the box.    | Non-existent. Restart the entire app for every single UI change.                            |
| **Code Structure**      | Reusable, self-contained components with `@component`.                         | Often leads to large, monolithic classes or procedural scripts.                             |

**In short, WinUp provides the "killer features" of modern web frameworks (like React or Vue) for the desktop, saving you time and letting you focus on what matters: your application's logic.**

# 🧊 WinUp vs 🧱 PyEdifice (Reddit User Request)

| Feature                          | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Architecture                  | React-style + state       | React-style + state              |
| 🌐 Built-in Routing              | ✅ Yes (`Router(routes={...})`)      | ❌ No built-in routing            |
| ♻️ Lifecycle Hooks               | ✅ `on_mount`, `on_unmount`, etc.    | ⚠️ Limited (`did_mount`, etc.)   |
| 🎨 Theming / Styling System     | ✅ Global & Scoped themes             | ❌ Manual CSS injection           |
| 🔲 Layout Options                | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Mostly Box & HBox/VBox         |
| 🎞️ Animations                   | ✅ Built-in (fade, scale, etc.)      | ❌ None built-in                  |
| 🔁 Hot Reloading (LHR)          | ✅ Stable + fast (`loadup dev`)      | ⚠️ Experimental, limited support  |
| 📦 Packaging                    | ✅ With LoadUp (PyInstaller-based)   | ❌ Must integrate PyInstaller manually |
| 🧩 Component Reusability        | ✅ High, declarative                 | ✅ High                           |
| 🛠 Developer Tooling            | ✅ DevTools planned, Inspector soon  | ❌ None yet                       |
| 📱 Mobile Support               | ❌ Not yet                           | ❌ Not supported                  |
| 🧠 Learning Curve               | ✅ Easy for Python+React users       | ✅ Easy but less tooling          |

> ✅ = Built-in or robust  
> ⚠️ = Partial or limited  
> ❌ = Missing entirely
---

## Core Features

*   **Declarative & Pythonic UI:** Build complex layouts with simple `Row` and `Column` objects instead of clunky box layouts.
*   **Component-Based Architecture:** Use the `@component` decorator to create modular and reusable UI widgets from simple functions.
*   **Powerful Styling System:** Style your widgets with simple Python dictionaries using `props`. Create global "CSS-like" classes with `style.add_style_dict`.
*   **Full Application Shell:** Build professional applications with a declarative API for `MenuBar`, `ToolBar`, `StatusBar`, and `SystemTrayIcon`.
*   **Asynchronous Task Runner:** Run long-running operations in the background without freezing your UI using the simple `@tasks.run` decorator.
*   **Performance by Default:** Includes an opt-in `@memo` decorator to cache component renders and prevent needless re-computation.
*   **Advanced Extensibility:**
    *   **Widget Factory:** Replace any default widget with your own custom implementation (e.g., C++ based) using `ui.register_widget()`.
    *   **Multiple Windows:** Create and manage multiple independent windows for complex applications like tool palettes or music players.
*   **Reactive State Management:**
    *   **One-Way Binding:** Automatically update your UI when your data changes with `state.bind()`.
    *   **Two-Way Binding:** Effortlessly sync input widgets with your state using `state.bind_two_way()`.
    *   **Subscriptions:** Trigger any function in response to state changes with `state.subscribe()`.
*   **Developer-Friendly Tooling:**
    *   **Hot Reloading:** See your UI changes instantly without restarting your app.
    *   **Profiler:** Easily measure the performance of any function with the `@profiler.measure()` decorator.
    *   **Window Tools:** Center, flash, or manage your application window with ease.
*   **Built-in Routing:** Easily create multi-page applications with an intuitive, state-driven router.
*   **Flexible Data Layer:** Includes simple, consistent connectors for SQLite, PostgreSQL, MySQL, MongoDB, and Firebase.

---

# Documentation

Dive deeper into the features of WinUp:

## Core Concepts
- [**Component Model & Styling**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**State Management**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Lifecycle Hooks**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Routing**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Absolute Positioning (Advanced)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Developer Tools
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performance Profiler**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoization**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Async Task Runner**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI Components
- [**Full Component Library**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Contributing

WinUp is an open-source project. Contributions are welcome!

## License

This project is licensed under the MIT License. See **LICENSE** for more information.