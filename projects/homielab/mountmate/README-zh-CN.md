# 🚀 MountMate

_一个简单的 macOS 菜单栏应用，用于管理你的外部驱动器。_

<p align="center">
  <img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/assets/icon.png" alt="MountMate 图标" width="100" height="100" style="border-radius: 22%; border: 0.5px solid rgba(0,0,0,0.1);" />
</p>

<p align="center">
  <a href="https://github.com/homielab/mountmate/releases">
    <img src="https://img.shields.io/github/v/release/homielab/mountmate?label=release&style=flat-square" />
  </a>
  <a href="https://github.com/homielab/mountmate">
    <img src="https://img.shields.io/github/downloads/homielab/mountmate/total?style=flat-square" />
  </a>
  <a href="https://brew.sh">
    <img src="https://img.shields.io/badge/homebrew-supported-blue?style=flat-square" />
  </a>
</p>

---

## ⚡️ 快速开始

通过 [Homebrew](https://brew.sh) 安装：

```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
或者[下载最新的 .dmg](https://github.com/homielab/mountmate/releases)，将 MountMate.app 拖入您的应用程序文件夹。

## 🧩 什么是 MountMate？

MountMate 是一个轻量级的 macOS 菜单栏工具，允许您**一键挂载和卸载外部驱动器**——无需终端，无需磁盘工具，无任何麻烦。

无论您是应对嘈杂的旋转硬盘，还是想更精细地控制驱动器的激活时机，MountMate 都能从菜单栏为您提供简洁且实用的解决方案。

## 🧠 我为何开发它

我有一个 4TB 的外接硬盘全天候连接到我的 Mac mini。由于它是旋转驱动器，macOS 会不断地使其旋转——仅仅是为了打开 Finder 或运行 Spotlight 这些琐碎操作。这意味着：

- 不必要的噪音
- 系统变慢
- 能源浪费

我尝试过：

- 磁盘工具 —— 太慢且笨重
- 自定义 shell 脚本 —— 太技术化
- 现有的第三方应用 —— 太臃肿或无法正常工作

于是我开发了**MountMate**。

## ✅ 功能

- 查看所有连接的**外部驱动器**
- 看到哪些是**已挂载**
- 点击即可**挂载/卸载**任何驱动器
- 检查可用的**剩余空间**
- 安静运行在**菜单栏**
- 完全原生 —— 无 Electron，无依赖

## ✨ 为什么使用 MountMate？

macOS 会在驱动器插入时自动挂载——但没有**简单的方式来稍后重新挂载**，除非使用终端或磁盘工具。MountMate 非常适合：

- 您并不总是需要使用的外部硬盘
- 仅用于备份的驱动器
- 减少磨损或噪音
- 提升系统响应速度

## 🔐 私密、快速且安全

MountMate 完全**离线运行**，使用 macOS 原生 API 和命令行工具。它：

- **不**跟踪任何信息
- **不**需要联网
- **不**访问您的文件
- **不**需要 root 权限

只是一个专注于做好一件事的干净工具。

## 🖼️ 截图

<img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light.png" width="300" /><img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/dark.png" width="300" />

![完整截图](https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light-full.png)

## 🛠️ 安装

### 手动安装

1. [下载最新的 `.dmg` 版本](https://github.com/homielab/mountmate/releases)
2. 打开 `.dmg` 文件
3. 将 `MountMate.app` 拖入**应用程序**文件夹
4. 弹出安装器磁盘映像
5. 从**应用程序**启动 MountMate

### 通过 Homebrew 安装

如果您已安装 [Homebrew](https://brew.sh)，可以直接从此仓库安装 MountMate：


```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
### macOS首次使用

- 如果看到MountMate来自未识别开发者的警告，请前往：  
  **系统设置 → 隐私与安全性 → 仍要打开**
- 确保已连接互联网，以便macOS验证应用并接收更新

## 📫 反馈与贡献

MountMate 是为解决我个人的工作流程问题而构建的，但我也希望为其他人改进它。  
欢迎随时[提交问题](https://github.com/homielab/mountmate/issues)或建议改进！

## 🤝 支持

如果您觉得MountMate有帮助，请考虑支持其开发：

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/homielab)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---