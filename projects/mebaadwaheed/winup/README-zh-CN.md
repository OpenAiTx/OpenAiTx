![PRs 欢迎](https://img.shields.io/badge/PRs-welcome-brightgreen)
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

## 请确保下载最新稳定版本（LSR），而非最新版本/LFR！当前 LSR：2.4.9

`pip install winup==2.4.9`

**一个极其 Pythonic 且强大的框架，用于构建漂亮的桌面应用。**

WinUp 是一个现代化的 Python UI 框架，封装了 PySide6（Qt）的强大功能，提供简单、声明式且开发者友好的 API。它旨在让你更快构建应用，编写更简洁代码，并享受开发过程。

### ✨ 现支持 Web！
WinUp 现在同样支持使用相同的以 Python 为中心、基于组件的方式构建完全交互式、有状态的 Web 应用。Web 模块底层采用 FastAPI 和 WebSockets，将 WinUp 的简洁带到浏览器端。

[Web 文档](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **免责声明：** Web 支持为可选功能。使用前需安装 Web 依赖：
> ```bash
> pip install "winup[web]"
> ```

[贡献指南](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[更新日志](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[许可协议](LICENSE)

---

## 为什么选择 WinUp？（而非原生 PySide6 或 Tkinter）

Python 的桌面开发常常显得笨拙。WinUp 诞生就是为了解决这个问题。

| 功能                     | WinUp 方式 ✨                                                                | 原生 PySide6 / Tkinter 方式 😟                                                       |
| ----------------------- | --------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| **布局**                | `ui.Column(children=[...])`，`ui.Row(children=[...])`                       | `QVBoxLayout()`，`QHBoxLayout()`，`layout.addWidget()`，`pack()`，`grid()`           |
| **样式**                | `props={"background-color": "blue", "font-size": "16px"}`                   | 手写 QSS 字符串，`widget.setStyleSheet(...)`，复杂的样式对象                          |
| **状态管理**            | `state.bind(widget, "prop", "key")`                                         | 手写回调函数，getter/setter，`StringVar()`，到处是样板代码                           |
| **双向绑定**            | `state.bind_two_way(input_widget, "key")`                                   | 不存在。需手动编写 `on_change` 处理器同步状态和 UI                                  |
| **开发者工具**          | **内置热重载**、代码性能分析器和窗口工具                                    | 不存在。每改 UI 都需重启整个应用                                                     |
| **代码结构**            | 使用 `@component` 创建可复用、独立组件                                      | 常导致庞大单体类或过程式脚本                                                       |

**简言之，WinUp 为桌面应用提供了现代 Web 框架（如 React 或 Vue）的“杀手级功能”，节省时间，让你专注于最重要的：应用逻辑。**

# 🧊 WinUp vs 🧱 PyEdifice（Reddit 用户请求）

| 功能                           | WinUp                       | PyEdifice                  |
|--------------------------------|-----------------------------|----------------------------|
| 🧱 架构                       | React 风格 + 状态            | React 风格 + 状态           |
| 🌐 内置路由                   | ✅ 支持 (`Router(routes={...})`) | ❌ 无内置路由               |
| ♻️ 生命周期钩子              | ✅ `on_mount`、`on_unmount` 等 | ⚠️ 有限 (`did_mount` 等)    |
| 🎨 主题 / 样式系统           | ✅ 全局 & 局部主题           | ❌ 手动注入 CSS             |
| 🔲 布局选项                  | ✅ 行、列、网格、堆叠、弹性布局 | ⚠️ 主要是 Box & HBox/VBox  |
| 🎞️ 动画                     | ✅ 内置（淡入淡出、缩放等）   | ❌ 无内置                   |
| 🔁 热重载 (LHR)              | ✅ 稳定且快速 (`loadup dev`)  | ⚠️ 实验性，支持有限          |
| 📦 打包                     | ✅ 基于 LoadUp（PyInstaller） | ❌ 需手动集成 PyInstaller    |
| 🧩 组件复用性                | ✅ 高，声明式                | ✅ 高                       |
| 🛠 开发工具                  | ✅ 计划开发 DevTools，Inspector 即将推出 | ❌ 暂无                     |
| 📱 移动支持                  | ❌ 尚未支持                  | ❌ 不支持                   |
| 🧠 学习曲线                  | ✅ 对 Python+React 用户友好   | ✅ 简单但工具较少            |

> ✅ = 内置或完善  
> ⚠️ = 部分或有限  
> ❌ = 完全缺失
---

## 核心功能

*   **声明式且 Pythonic 的 UI：** 用简单的 `Row` 和 `Column` 对象构建复杂布局，而非笨重的盒式布局。
*   **基于组件的架构：** 使用 `@component` 装饰器从简单函数创建模块化、可复用的 UI 组件。
*   **强大的样式系统：** 用简单的 Python 字典通过 `props` 为组件设置样式。用 `style.add_style_dict` 创建全局“类 CSS”样式。
*   **完整的应用壳层：** 用声明式 API 构建专业应用，包括 `MenuBar`、`ToolBar`、`StatusBar` 和 `SystemTrayIcon`。
*   **异步任务执行器：** 用简单的 `@tasks.run` 装饰器后台运行长时间任务，避免界面卡顿。
*   **默认性能优化：** 内置可选的 `@memo` 装饰器缓存组件渲染，避免不必要的重复计算。
*   **高级扩展性：**
    *   **组件工厂：** 用 `ui.register_widget()` 替换任何默认组件为你自定义实现（如基于 C++）。
    *   **多窗口管理：** 创建和管理多个独立窗口，适合复杂应用如工具面板或音乐播放器。
*   **响应式状态管理：**
    *   **单向绑定：** 数据变化时自动更新 UI，使用 `state.bind()`。
    *   **双向绑定：** 轻松同步输入组件和状态，使用 `state.bind_two_way()`。
    *   **订阅机制：** 状态变化时触发任意函数，使用 `state.subscribe()`。
*   **开发者友好工具：**
    *   **热重载：** UI 改动即时反映，无需重启应用。
    *   **性能分析器：** 用 `@profiler.measure()` 装饰器轻松测量函数性能。
    *   **窗口工具：** 轻松居中、闪烁或管理应用窗口。
*   **内置路由：** 轻松创建多页面应用，使用直观的状态驱动路由器。
*   **灵活数据层：** 提供 SQLite、PostgreSQL、MySQL、MongoDB 和 Firebase 的简单一致连接器。

---

# 文档

深入了解 WinUp 的功能：

## 核心概念
- [**组件模型与样式**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**状态管理**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**生命周期钩子**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**路由**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**绝对定位（高级）**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## 开发者工具
- [**实时热重载 (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**性能分析器**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**记忆化**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**异步任务运行器**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI 组件
- [**完整组件库**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## 贡献

WinUp 是一个开源项目。欢迎贡献！

## 许可证

本项目采用 MIT 许可证。更多信息请参见 **LICENSE**。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---