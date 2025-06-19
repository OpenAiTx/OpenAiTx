# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

以 Web 为优先的跨平台应用启动器，支持基于 React 的插件

> [!WARNING]
> 启动器由一名开发者在业余时间开发。
> 变更可能会较慢，但会持续推进。
>
> 可能会有重大变更，这些变更会在 [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md) 中记录。

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## 演示

略微过时的演示

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## 功能特性

- 插件优先
  - 插件使用 TypeScript 编写
  - 丰富的插件 API
      - 创建 UI 视图
      - 一次性命令
      - 动态提供一次性命令列表
      - 根据主搜索栏中的内容，在其下方直接渲染快速“内联”内容
      - 从剪贴板获取内容并添加内容到剪贴板
  - 插件以 Git 仓库的单独分支形式分发，这意味着插件分发不需要任何中心服务器
  - 插件 ID 仅为 Git 仓库 URL
  - 基于 [React](https://github.com/facebook/react) 的插件 UI
    - 通过自定义 React Reconciler 实现（无 Electron）
  - [Deno JavaScript 运行时](https://github.com/denoland/deno)
    - Deno 允许为 JavaScript 插件代码提供沙箱以提升安全性
    - 插件需要显式声明其所需的权限
    - Node.js 用于运行插件工具，但作为插件开发者，你总是编写在 Deno 上运行的代码
- 从一开始就以跨平台为目标设计
- 命令和视图可以通过自定义全局快捷键运行/打开
- 可以为命令或视图分配自定义搜索别名
- 支持自定义主题
- 内置功能通过捆绑插件提供
  - 应用程序：在搜索结果中显示系统已安装的应用程序
    - 插件还会跟踪窗口及其所属的应用程序，因此打开已打开的应用程序时，默认会显示先前创建的窗口
      - 目前并非所有系统都支持。参见 [功能支持](https://gauntlet.sh/docs/feature-support)
  - 计算器：在主搜索栏下方直接显示数学运算结果
    - 包括使用汇率进行货币转换
    - 由 [Numbat](https://github.com/sharkdp/numbat) 提供支持
- 基于频率和最近使用的 Frecency 搜索结果排序
   - Frecency 是频率和最近使用的结合
   - 项目使用得越频繁，其在结果列表中的排名越高，但过去经常使用但近期未使用的项目，其排名会低于近期同等使用频率的项目
   - 结果按单词进行子串匹配

##### 操作系统支持

##### 官方支持
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### 尽力支持
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - 目前尚不支持 Gnome Wayland，参见 [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## 入门指南

### 安装 Gauntlet

参见 [安装指南](https://gauntlet.sh/docs/installation)

### 全局快捷键

主窗口可通过全局快捷键或 CLI 命令打开：
- 全局快捷键（可在设置中更改）
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - 可能不支持全局快捷键，参见 [功能支持](https://gauntlet.sh/docs/feature-support)
    - 请改用 CLI 命令，并通过窗口管理器的特定方式调用
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- CLI 命令
  - `gauntlet open`

### 安装插件

插件可在设置界面中安装。请使用插件的 Git 仓库 URL 进行安装，例如 `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### 创建你自己的插件

参见 [插件开发入门](https://gauntlet.sh/docs/plugin-development/getting-started)

## 主题

参见 [主题文档](https://gauntlet.sh/docs/theming)

## 构建 Gauntlet

你需要：
- NodeJS
- Rust
- Protobuf 编译器
- CMake（本项目本身不使用，但依赖项需要）
- 在 Linux 上：`libxkbcommon-dev`（注意：名称可能因发行版不同而异）

### 开发模式

开发构建运行如下：
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
在开发模式下（无 "release" 特性）应用只会在项目目录内的文件夹中存储状态或缓存，以避免影响全局安装

### 未打包版本

要构建未打包的 release 二进制文件，运行：
```bash
npm ci
npm run build
cargo build --release --features release
```

### 打包版本
要构建特定操作系统的安装包，请运行以下命令之一：

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

但新版本发布需要通过 GitHub Actions 完成

## 参与贡献

如果你希望帮助构建 Gauntlet，除了贡献代码，还可以通过以下方式参与：
- 报告 bug 或 UI/UX 问题
- 创建插件

对于简单问题，欢迎直接提交 issue 或 PR 并自行解决。
对于更重大更改，请先通过 Discord（README 顶部有邀请链接）联系开发者并沟通讨论。

欢迎任何形式的贡献。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---