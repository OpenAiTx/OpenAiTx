# DisableCtrlClick for macOS

<p align="center">
  <img src="https://raw.githubusercontent.com/achendev/DisableCtrlClick/master/DisableCtrlClick.png" alt="App Icon" width="128">
</p>

<p align="center">
  <a href="https://github.com/achendev/DisableCtrlClick/releases">
    <img src="https://img.shields.io/github/downloads/achendev/DisableCtrlClick/total.svg" alt="Total Downloads">
  </a>
  <a href="https://github.com/achendev/DisableCtrlClick">
    <img src="https://img.shields.io/github/stars/achendev/DisableCtrlClick?style=social" alt="Star on GitHub">
  </a>
</p>

你是否厌倦了在仅仅想使用 Control 键时意外打开上下文菜单？我也是。

许多应用程序，尤其是在编程、设计和游戏中，使用 `Control` 作为主要操作的修饰键。如果你习惯用两指点击或专用鼠标按钮进行右键点击，默认的 `Ctrl-Click` 行为可能会令人烦恼。这个应用解决了这个问题。

## 它的作用

这是一个小巧的原生 macOS 工具，常驻在菜单栏，做一件事：强制 **`Control + 左键点击`** 表现得像正常的 **`左键点击`**，禁用默认的右键点击/上下文菜单行为。

就是这样。再也不会随机触发右键点击了。

## 功能

*   ✅ **轻量且原生：** 一个简单的 Swift 应用，资源占用极小。
*   ✅ **通过菜单栏配置：** 点击图标可临时禁用功能，切换“登录时启动”，或退出应用。
*   ✅ **菜单栏应用：** 低调驻留在菜单栏。按 Cmd+拖动可隐藏它，再次启动应用即可恢复显示。
*   ✅ **登录时启动（可选）：** 登录时自动启动，可通过应用菜单开关。
*   ✅ **零配置：** 只需运行并授权。就这么简单。
*   ✅ **现代且安全：** 使用现代 API 构建，除必要权限外无需特别权限。
*   ✅ **透明且小巧：** 体积小到你可以完整阅读应用代码，或交给任何 AI 理解它的具体功能和你在 Mac 上运行的内容。

## 安装与使用

1.  **下载：** 访问[**发布页面**](https://github.com/achendev/DisableCtrlClick/releases)，下载最新的 `DisableCtrlClick.dmg`。


2.  **安装：** 打开文件并将 `DisableCtrlClick.app` 拖动到你的 `/Applications` 文件夹中。
3.  **启动：** 从应用程序文件夹中打开该应用。
4.  **授权权限：** 首次启动时，应用会提示你授予权限然后退出。你必须在以下位置为 `DisableCtrlClick` 启用 **辅助功能** 和 **输入监控**：
    *   `系统设置 > 隐私与安全 > 辅助功能`
    > **为什么？** 任何需要系统范围查看和修改鼠标或键盘事件的应用都需要此权限。该应用仅检测 `Ctrl-点击`，不会执行其他操作。

5.  **完成！** 再次重新启动应用。现在它正在运行，并且默认情况下每次登录时会自动启动。你可以从菜单栏图标更改此行为。

该应用会在菜单栏显示一个小图标。
*   点击图标可打开菜单，在这里你可以临时禁用该功能，控制是否登录时自动启动，或退出应用。
*   你可以按住 `⌘`（Command）并将图标拖出菜单栏以隐藏它。如果想要恢复，只需重新启动该应用。

## 从源码构建

如果你更愿意自己构建应用：

1.  克隆此仓库：
    ```bash
    git clone https://github.com/achendev/DisableCtrlClick.git
    cd DisableCtrlClick
    ```
2.  确保已安装 Xcode 的命令行工具。  
3.  从终端运行构建脚本：
    ```bash
    ./build.sh
    ```
4.  `DisableCtrlClick.app` 软件包将会在项目目录中创建。然后您可以将其移动到 `/Applications` 文件夹。

5.  拖动到 /Applications，启动它。默认情况下，它将自动添加到“开机启动”中。

6.  在系统设置中授予辅助功能和输入监控权限。

## 故障排除

该应用按“原样”提供，不附带任何明示或暗示的保证。

需要 macOS 13.0（Ventura）或更高版本。

**如何退出**
点击菜单栏图标并选择“退出”。如果您隐藏了图标，可以重新启动应用以显示图标，或者在终端中使用命令 `killall DisableCtrlClick`。

**如何重置权限**
如果应用无法正常工作，尝试重置其权限：
    ```bash
    tccutil reset Accessibility com.usr.DisableCtrlClick
    ```

## 许可协议

本项目采用 MIT 许可证发布。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---