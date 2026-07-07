# Tail Tray
Tailscale 托盘菜单和 Plasma 桌面 UI

**免责声明** 请注意，我与 Tailscale Inc. 完全没有任何关联。

这是一个个人项目，Tailscale Inc. 并未以任何形式支持该项目。

### 功能
- [X] 从托盘控制您的 Tailscale 连接
- [X] 显示 IP 地址
- [X] 显示您设备的当前连接状态
- [X] 网络及网络状态概览
- [X] 设置和更改您的 Tailscale 出口节点
- [X] 适当的多账户处理
- [X] Mullvad 出口节点支持
- [X] Tail drive 支持 - 兼容 davfs2 支持 + 提供配置 davfs2 及挂载等的额外帮助
- [X] 直接从托盘菜单向 Tailnet 上的任何设备发送文件
- [X] 接收来自 Tailnet 上任何设备的通知和文件，保存到预定义的磁盘位置
- [X] 为主要发行版提供预编译二进制文件，并支持试验性 Windows 版本

### 许可
GNU 通用公共许可证 v3.0 - 详情见 [LICENSE](LICENSE)

### 安装
目前最简单且最可靠的安装方式是从源代码构建。
请参阅下方的入门章节了解详情。

### 先决条件
* 已安装并运行 Tailscale - https://tailscale.com 
* 已安装并配置 davfs2（如果您计划使用 Tail drive 或访问 Tail drive。Tail Tray 也帮助您自动配置该项）- https://wiki.archlinux.org/title/Davfs2

### 支持的架构
* x86_64
* ARM64
* 任何 QT 6 支持且能编译本项目且 Tailscale 能运行的其他架构

### 入门

### 预编译包

 * [基于 Debian / Ubuntu / Mint 的发行版](https://github.com/SneWs/tail-tray/releases)
 * [OpenSUSE 和 Fedora RPM 包](https://software.opensuse.org/download.html?project=home%3Aayankov&package=tail-tray)
 * [NixOS](/docs/nix-os.md)
 * [Windows（实验性！仅限最新不稳定版本，且未签名）](https://github.com/SneWs/tail-tray/releases/download/latest/Tail-Tray-Windows.zip)

### 从源码构建和安装
 * [在 Linux 上](/docs/build-from-src.md)
 * [在 Windows 上](/docs/build-from-src-windows.md)

### 脚本化操作
要了解如何编写和使用脚本化操作，请阅读 [脚本化操作指南](https://raw.githubusercontent.com/SneWs/tail-tray/master/docs/scriptable-actions.md)

### 参与开发与提交错误
* 如果您想参与本项目的开发，欢迎 fork 仓库并提交拉取请求。
* 出现错误是常有的事……请在 issues 选项卡中提交问题，我们将共同解决。

### 截图
![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/launcher.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/connected-tray.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/disconnected-tray.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/settings-ui.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/network-status.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/file-sharing.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/devices-ui.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/ui-settings.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives01.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives02.png)

![截图](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives03.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---