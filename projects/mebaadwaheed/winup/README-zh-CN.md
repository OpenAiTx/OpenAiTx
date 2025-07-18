<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

![欢迎 PR](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![组件驱动](https://img.shields.io/badge/architecture-component--driven-orange)
![桌面应用](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI 支持](https://img.shields.io/badge/CLI-supported-critical)
![实时重载](https://img.shields.io/badge/live--reload-enabled-blue)

## 图片示例

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## 请务必下载最新稳定版（LSR），而不是最新/LFR！当前 LSR: 2.4.9

`pip install winup==2.4.9`

**一个极度 Pythonic 且强大的框架，用于构建美观的桌面应用。**

WinUp 是一个现代 Python UI 框架，将 PySide6（Qt）的强大功能封装在简单、声明式、开发者友好的 API 中。它旨在让你更快地构建应用，编写更简洁的代码，享受开发过程。

### ✨ 现已支持 Web！
WinUp 现在还支持使用同样以 Python 为中心、基于组件的方式来构建完全交互、可维护状态的 Web 应用。Web 模块底层采用 FastAPI 和 WebSockets，将 WinUp 的简易性带到浏览器端。

[Web 文档](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **免责声明：** Web 支持是可选特性。要使用它，必须安装 Web 相关依赖：
> ```bash
> pip install "winup[web]"
> ```

[贡献指南](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[更新日志](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[许可证](LICENSE)

---

## 为什么选择 WinUp？（而不是原生 PySide6 或 Tkinter）

Python 桌面开发体验可能很笨重。WinUp 正是为了解决这一问题而生。

| 特性                     | WinUp 方式 ✨                                                                 | 原生 PySide6 / Tkinter 方式 😟                                                      |
| ----------------------- | ------------------------------------------------------------------------------ | ----------------------------------------------------------------------------------- |
| **布局**                | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`          |
| **样式**                | `props={"background-color": "blue", "font-size": "16px"}`                      | 手写 QSS 字符串，`widget.setStyleSheet(...)`，复杂的样式对象。                      |
| **状态管理**            | `state.bind(widget, "prop", "key")`                                            | 手动回调函数，getter/setter，`StringVar()`，到处都是样板代码。                      |
| **双向绑定**            | `state.bind_two_way(input_widget, "key")`                                      | 不存在。需手动编写 `on_change` 处理函数来同步状态和界面。                           |
| **开发者工具**          | **内置热重载**，代码分析器，窗口工具开箱即用。                                | 不存在。每改一次界面就要重启整个应用。                                              |
| **代码结构**            | 可复用、独立组件，使用 `@component` 装饰。                                    | 通常导致代码臃肿的巨大类或流程化脚本。                                              |

**简而言之，WinUp 为桌面端带来了现代 Web 框架（如 React 或 Vue）中的“杀手级功能”，节省你的时间，让你专注于真正重要的：你的应用逻辑。**

# 🧊 WinUp vs 🧱 PyEdifice（Reddit 用户请求）

| 特性                              | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 架构                          | React 风格 + 状态       | React 风格 + 状态                |
| 🌐 内置路由                      | ✅ 是（`Router(routes={...})`）     | ❌ 无内置路由                     |
| ♻️ 生命周期钩子                  | ✅ `on_mount`, `on_unmount` 等     | ⚠️ 有限（`did_mount` 等）         |
| 🎨 主题/样式系统                | ✅ 全局与局部主题                  | ❌ 手动注入 CSS                   |
| 🔲 布局选项                      | ✅ 行、列、网格、堆叠、弹性盒      | ⚠️ 主要为 Box 与 HBox/VBox        |
| 🎞️ 动画                        | ✅ 内置（淡入、缩放等）            | ❌ 无内置动画                     |
| 🔁 热重载（LHR）                 | ✅ 稳定且快速（`loadup dev`）      | ⚠️ 实验性，支持有限               |
| 📦 打包                         | ✅ 配合 LoadUp（基于 PyInstaller） | ❌ 需手动集成 PyInstaller         |
| 🧩 组件复用性                   | ✅ 高，声明式                     | ✅ 高                             |

| 🛠 开发者工具                | ✅ 已规划DevTools，Inspector即将推出 | ❌ 暂无                          |
| 📱 移动端支持                 | ❌ 尚未支持                        | ❌ 不支持                        |
| 🧠 学习曲线                   | ✅ 对Python+React用户友好           | ✅ 容易，但工具较少              |

> ✅ = 内置或功能强大  
> ⚠️ = 部分或有限支持  
> ❌ = 完全缺失
---

## 核心特性

*   **声明式且Python风格UI：** 用简单的 `Row` 和 `Column` 对象构建复杂布局，摆脱繁琐的盒子布局。
*   **组件化架构：** 使用 `@component` 装饰器，从简单函数创建模块化、可复用的UI组件。
*   **强大的样式系统：** 用Python字典通过 `props` 为控件设置样式。利用 `style.add_style_dict` 创建全局“类CSS”样式。
*   **完整应用壳：** 通过声明式API为 `MenuBar`、`ToolBar`、`StatusBar` 和 `SystemTrayIcon` 构建专业应用。
*   **异步任务运行器：** 使用简单的 `@tasks.run` 装饰器在后台运行耗时操作，UI不卡顿。
*   **性能优先：** 提供可选的 `@memo` 装饰器，缓存组件渲染，避免无谓的重复计算。
*   **高级可扩展性：**
    *   **控件工厂：** 通过 `ui.register_widget()` 用自定义实现（如C++）替换任何默认控件。
    *   **多窗口支持：** 创建和管理多个独立窗口，适用于工具面板或音乐播放器等复杂应用。
*   **响应式状态管理：**
    *   **单向绑定：** 使用 `state.bind()` 数据变化自动更新UI。
    *   **双向绑定：** 用 `state.bind_two_way()` 轻松同步输入控件与状态。
    *   **订阅：** 用 `state.subscribe()` 响应状态变化触发任意函数。
*   **开发者友好工具：**
    *   **热重载：** UI变更即时可见，无需重启应用。
    *   **性能分析器：** 通过 `@profiler.measure()` 装饰器轻松测量任意函数性能。
    *   **窗口工具：** 轻松实现应用窗口居中、闪烁等管理操作。
*   **内置路由：** 通过直观、状态驱动的路由器轻松实现多页面应用。
*   **灵活数据层：** 内置简单一致的SQLite、PostgreSQL、MySQL、MongoDB、Firebase连接器。

---

# 文档

深入了解WinUp的特性：

## 核心概念
- [**组件模型与样式**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**状态管理**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**生命周期钩子**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**路由**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**绝对定位（高级）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## 开发者工具
- [**实时热重载（LHR）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**性能分析器**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**记忆化**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**异步任务运行器**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI组件
- [**完整组件库**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## 参与贡献

WinUp是一个开源项目，欢迎您的贡献！

## 许可证

本项目基于MIT许可证发布。详情请参阅**LICENSE**。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---