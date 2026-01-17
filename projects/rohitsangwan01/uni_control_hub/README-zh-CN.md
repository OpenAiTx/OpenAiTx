# UniControlHub

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)
![Downloads](https://img.shields.io/github/downloads/rohitsangwan01/uni_control_hub/total.svg)

<p align="center">
  <img src="https://github.com/user-attachments/assets/41c886c0-f08c-4186-bc98-153aa2769d13" height=150 />
</p>

UniControlHub：无缝连接您的设备

UniControlHub 革新了您与数字环境交互的方式，提供跨多设备的无缝直观控制体验。受苹果 Universal Control 便捷流畅性的启发，UniControlHub 将这一创新功能扩展到苹果生态系统之外。只需一只鼠标和键盘，您即可轻松导航和管理设备，UniControlHub 确保工作空间的连贯与高效。该应用采用 Flutter 构建，带来流畅响应的用户体验，是提升生产力和简化数字生活的终极工具。

![macOS](https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Linux](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)

<a href="https://buymeacoffee.com/rohitsangwan" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## 快速开始

从[发布](https://github.com/rohitsangwan01/uni_control_hub/releases)部分下载适用于您的平台的应用

### MacOS

- 安装 libusb: `brew install libusb`

### Windows

- 为您的 [x86](https://aka.ms/vs/17/release/vc_redist.x86.exe) 或 [x64](https://aka.ms/vs/17/release/vc_redist.x64.exe) 操作系统安装 `Microsoft Visual C++ 2015-2022`。

- 如果 Android 设备无法被检测到，请确保已安装 libusb [驱动程序](https://github.com/libusb/libusb/wiki/Windows#driver-installation)。

### Linux

确保已安装 `libqt5dbus5`

基于 Ubuntu/Debian 的系统，运行：

```bash
sudo apt update
sudo apt install libqt5dbus5
```

在 Fedora/RHEL/CentOS 上，运行：

```bash
sudo dnf install qt5-qtbase
```

在 Arch Linux 上，运行：

```bash
sudo pacman -S qt5-base
```

## 支持的平台

| 平台     | 蓝牙       | USB | ADB |
| -------- | ---------- | --- | --- |
| IOS      | ✅         | ❌  | ❌  |
| Android  | ⏳         | ✅  | ✅  |

## 截图

<p align="start">
  <img src="https://github.com/rohitsangwan01/uni_control_hub/assets/59526499/7b2b87c3-4501-490b-a205-0e3815c4b583" height=400 />
</p>

## 演示

[![](http://markdown-videos-api.jorgenkh.no/youtube/KYsqdJkG2N0)](https://youtu.be/KYsqdJkG2N0)

## 故障排除

- 在 MacOS 上，应用程序会请求 MacOS 的 `辅助功能` 和 `蓝牙` 权限，（更新后，即使已经授权，应用可能会再次请求辅助功能权限，尝试从辅助功能中移除应用后重新运行）
- 要在 Android 上使用 UHID 模式，请确保已安装 `ADB`（AOA 模式不需要）
- 对于桌面和 IOS 连接，请确保蓝牙已开启
- 连接 Android 设备后，点击刷新按钮

## 开发者指南

本节指导您设置和运行 UniControlHub 以进行开发。

#### 前提条件：

- 安装适用于您操作系统的最新版本 [Flutter](https://flutter-ko.dev/get-started/install)。您可以在 Flutter 官方网站找到安装说明。
- 按照您平台的 [Flutter](https://flutter-ko.dev/get-started/install) 设置指南操作。如果不开发 Android 或 iOS 应用，可以跳过对应步骤。

#### 运行/调试应用：

- Flutter 设置完成后，运行 `flutter pub get` 下载依赖，然后运行 `flutter run` 启动应用

## 赞助者

如果您觉得这个项目有用，考虑赞助它！您的支持有助于保持开发活跃，添加新功能，并提升稳定性。您也可以在[讨论区](https://github.com/rohitsangwan01/uni_control_hub/discussions)分享您的想法或反馈。感谢您的支持！🚀

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/rohitsangwan)

## 其他说明：

UniControlHub 使用了[Synergy 服务器](https://github.com/symless/synergy-core)实现跨平台键盘和鼠标共享。您可以在其官网了解更多关于[Synergy](https://symless.com/synergy)的信息。

我们欢迎对 UniControlHub 的贡献！如果您发现了错误或有功能请求，请在我们的 GitHub 仓库中提交 issue。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---