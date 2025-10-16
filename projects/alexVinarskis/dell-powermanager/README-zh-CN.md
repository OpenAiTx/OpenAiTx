[![构建](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml)
[![GitHub 发布（带过滤）](https://img.shields.io/github/v/release/alexVinarskis/dell-powermanager?label=Release)](https://github.com/alexVinarskis/dell-powermanager/releases/latest)
![GitHub 所有发布](https://img.shields.io/github/downloads/alexVinarskis/dell-powermanager/total?label=Downloads)

# Dell Power Manager
跨平台的 Dell Power Manager Flutter 重新实现。更多截图见[维基](https://github.com/alexVinarskis/dell-powermanager/wiki)。

![截图摘要](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/images/screenshot_summary.png)

## 为什么
Dell 机器（XPS 和 Precision 系列笔记本，可能还有其他）提供了高级的 BIOS 配置选项，如多种热管理配置文件、电池充电阈值等。动态调整这些设置非常有必要，但在操作系统中无法配置，除非使用 Dell 的专有工具（幸运的是这些工具已提供）。设置可以通过以下方式更改：
* 直接在 BIOS 中，需要重启
* [Dell Command | Configure](https://www.dell.com/support/kbdoc/en-us/000178000/dell-command-configure) 命令行工具，支持 Windows 和 Linux，功能列表十分丰富，详见[文档](https://dl.dell.com/topicspdf/command-configure_reference-guide4_en-us.pdf)。
* [Dell Power Manager](https://www.dell.com/support/contents/en-au/article/product-support/self-support-knowledgebase/software-and-downloads/dell-power-manager) 图形界面，仅支持 Windows。此外，该软件启动极其缓慢，且（主观）界面丑陋。

本应用是基于 Flutter 的现代 GUI，构建于 Dell Command | Configure CLI 之上，主要目标是为 Linux 用户复刻 Dell Power Manager 的功能，同时支持 Windows。

## 功能
* 通过 “Dell Command | Configure CLI”（CCTK） 实现控制
* 现代动画界面，支持暗黑模式
* 启动时间短，比 Dell Windows 应用快得多
* 在支持的机器上检测并处理不支持的模式
* 识别非 Dell 机器，显示错误信息
* 支持受保护的 BIOS（系统/设置/所有者密码）及安全密钥保存

对于基于 Debian/Ubuntu 的 Linux 和 Windows，应用更具产品化：
* 集成依赖下载和安装程序
* 打包为 `.deb`/`.msi`，含开始菜单快捷方式等
* 集成通过 Github API 的 OTA 更新

控制功能：
* 电池状态概览（健康等）
* 电池充电控制（当前不支持高级/每日定时模式）
* 热管理配置文件控制
* 检测操作系统的电源模式

计划待办事项：
* 高级电池充电控制/调度（[功能请求](https://github.com/alexVinarskis/dell-powermanager/issues/24)）
* “峰值转移”控制（[功能请求](https://github.com/alexVinarskis/dell-powermanager/issues/57)）

潜在的未来功能考虑：
* 添加基于 CPU 负载自动切换热配置的监控服务
* 添加基于电源设置（例如电池电量、插拔状态等）自动切换热配置的监控服务

## 开发状态
应用程序目前处于**稳定，维护中**状态。

* 集成了戴尔的 CCTK（带有针对部分操作系统的自动安装程序）
* 实现了更新检查（通过 Github API 的 OTA，适用于部分操作系统）
* UI 已测试，构建和打包由 CI 断言
* 打包为 `.msi`、`.deb`、`.tar.xz`。获取最新稳定版本请访问 [Releases](https://github.com/alexVinarskis/dell-powermanager/releases/latest)，或最新开发版本请访问 [CI artifacts](https://github.com/alexVinarskis/dell-powermanager/actions/workflows/build.yml?query=branch%3Amaster)
* 在多个平台上测试，见 [兼容性](#compatibility)。支持：
    * Windows，x86_64（原生 `.msi`）
    * Windows，arm64（x64_86 `.msi` 在仿真中运行）
    * Linux，x86_64（原生 `.deb`、`.tar`）
    * Linux，arm64*（原生 `.deb`、`.tar`）_仅电池信息部分有效——实际控制尚不支持，因为戴尔的 CCTK 还未提供 arm64 版本（可能未来会有？）_
## 从源码构建
### Linux
* 安装依赖项：
```
sudo apt-get install -y ninja-build libgtk-3-dev libsqlite3-dev libsecret-1-0 libsecret-1-dev
```
* 通过 `flutter run` 从源码运行，通过 `flutter build linux --release` 构建
* 通过 `./package.sh` 打包为 `.deb`，`.tar.xz`

注意：**不要**从 `snap` 安装 flutter，请使用原生[安装方式](https://docs.flutter.dev/get-started/install/linux/desktop) — 由于[snap 特定问题](https://github.com/juliansteenbakker/flutter_secure_storage/issues/676)，snap 提供的 flutter 无法编译此项目。

### Windows
* 通过 `flutter run` 从源码运行，通过 `flutter build windows --release` 构建
* 通过 `.\package.bat` 打包为 `.msi`

## 贡献

### 调试

默认情况下，所有日志均被抑制。运行应用前请在 CLI 中导出 `POWERMANAGER_DEBUG=true` 以获取日志。
例如：`export POWERMANAGER_DEBUG=true && ./dell-powermanager > file.log`。提交问题时，请保存并附上日志。

### 翻译
应用通过 Flutter 本地化库支持多语言。如果您想贡献：
* 查看 [lib/l10n/*.arb](https://raw.githubusercontent.com/alexVinarskis/dell-powermanager/master/lib/l10n/app_en.arb) 文件。
* 为您的语言创建类似文件，翻译字符串。
* 提交包含您更改的 PR。

## 兼容性
已在以下设备上测试：
* 戴尔 G3 15 3500
    * [Windows 11 24H2 (OS Build 26100.4061)](https://github.com/alexVinarskis/dell-powermanager/issues/65)
* 戴尔 Latitude 5400
    * [Ubuntu 24.04](https://github.com/alexVinarskis/dell-powermanager/issues/56)
* 戴尔 Precision 7560
    * [Fedora 41, 6.12.4](https://github.com/alexVinarskis/dell-powermanager/issues/47)
* 戴尔 XPS 17 9700
    * [Tumbleweed OpenSUSE, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
* 戴尔 XPS 15 9560
    * [Arch Linux, 6.11.6-arch1-1](https://github.com/alexVinarskis/dell-powermanager/issues/46)
* 戴尔 XPS 15 9530 (2023/Fiorano)
    * Ubuntu 23.04, 6.5.0-060500-generic
    * Ubuntu 23.10, 6.5.0-060500-generic
    * Windows 11 Pro 22H2, 22621.2428
* 戴尔 XPS 15 9520
    * [Arch, 6.7.5](https://github.com/alexVinarskis/dell-powermanager/issues/31)
    * Ubuntu 22.04，6.2.0
    * Windows 11 家庭版 22H2，22621.2428
* 戴尔 XPS 13 9345（Tributo）
    * Ubuntu 24.10，6.12.0-28-qcom-x1e（仅电池信息）
    * Windows 11 专业版
* 戴尔 XPS 13 9310
    * Ubuntu 22.04.3，6.2.0-26-generic
    * Windows 10 专业版 22H2，19045.3324
* 戴尔 Vostro 5401
    * [Ubuntu 23.10](https://github.com/alexVinarskis/dell-powermanager/issues/23) 

如果您在上述设备中遇到问题，请打开[**错误报告**](https://github.com/alexVinarskis/dell-powermanager/issues/new?template=bug_report.md&title=[BUG])。如果您在其他设备上测试过，请报告[**测试设备**](https://github.com/alexVinarskis/dell-powermanager/issues)。

## 已知问题
请参见[问题](https://github.com/alexVinarskis/dell-powermanager/issues)。
## 致谢
* 感谢戴尔提供“Dell Command | Configure CLI”
* 感谢谷歌创造了 Flutter :)

## 免责声明
根据许可协议，本软件按“原样”提供，不附带任何保证。它与戴尔没有任何关联。使用风险自负。本人或其他贡献者不对本软件引起的任何损害负责，包括但不限于数据丢失、硬件损坏、数据泄露等。在适用情况下，使用了集成的安全密钥保存解决方案，但不保证任何形式的安全性。使用前请了解风险和影响。作者或贡献者不承担任何法律责任。

## 许可协议
本应用程序采用 GPLv3 许可。简而言之，这意味着您可以免费使用/复制/修改/分发，但必须提供您修改的源代码，并保持相同的许可协议。您不能将其作为专有软件出售。详情请参见[LICENSE](LICENSE)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---