<div align="center">
    <img src="https://raw.githubusercontent.com/TheAlexDev23/power-options/main/icon.png" width=120>
    <h1>
        电源选项
    </h1>
    <a href="https://discord.gg/KyZt97MvdU">
        <img src="https://img.shields.io/badge/Discord-%235865F2.svg?style=for-the-badge&logo=discord&logoColor=white">
    </a>
    <a href="https://www.paypal.com/paypalme/AlexanderKarpukhin2">
        <img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white">
    </a>
</div>

<br/>

一款集成的极快 Linux 图形界面应用程序，适用于任何设备上的简单和高级电源管理。

电源选项可以作为任何节能应用程序的替代品，包括 TLP、auto-cpufreq、cpupower-gui 等。电源选项涵盖了所有最常见的节能设置，并增加了其他应用程序中不存在的功能。

安装后，电源选项将分析系统并基于结果智能生成各种配置文件。这些配置文件经过高度优化，通常无需用户干预，除非用户需要更多控制。

大多数应用程序只允许两种配置文件：电池配置文件和交流电配置文件。这在某些情况下并不理想，当用户希望获得更大控制时。这就是本程序所使用的配置文件系统的创建原因：
- 用户可以拥有任意数量的配置文件
- 用户选择哪些配置文件将用于电池和交流电
- 用户可以临时覆盖配置文件选择，直到他们取消该覆盖
- 用户可以设置一个在重启后依然保持的持久覆盖

## 可用前端/界面

用户可以简单安装守护进程并手动编辑配置文件，因为它们是用 TOML 编写的。但该程序最大的优势是它提供的图形界面，因为几乎所有其他节能工具都没有










拥有一个并诉诸于配置文件。

### 原生 GTK 前端

简单、轻量且原生，界面简洁。推荐给大多数用户。

![gtk-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/gtk-slideshow.gif)

### WebKit 前端

更多高级选项和更强的控制力。不是那么轻量。推荐给高级用户及希望将 power-options 与其他电源管理解决方案结合使用的用户。

![webview-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/webview-slideshow.gif)

## 功能

Power options 基于对最大 Linux 维基和指南以及其他节能应用程序的所有技巧和建议的回顾制作。一些示例包括：
- https://wiki.archlinux.org/title/Power_management
- https://wiki.gentoo.org/wiki/Power_management/Guide
- https://en.wikipedia.org/wiki/Power_management
- https://github.com/supplantr/ftw
- https://github.com/linrunner/TLP
- https://github.com/AdnanHodzic/auto-cpufreq
- https://github.com/vagnum08/cpupower-gui

Power Option 包含以下功能：
- 比替代品更多的配置文件类型
- 可以通过分析用户系统智能生成配置文件。
- 系统睡眠选项（挂起，屏幕关闭）
- CPU 选项
- 单个 CPU 核心选项。大多数节能工具缺少此选项，这是本项目的主要动机之一。
- 屏幕选项
- 禁用无线电组件（例如蓝牙、WiFi、NFC）的选项
- 网络选项。允许比替代应用更大的控制，但






  需要重新加载网络驱动。仅限使用 iwlwifi 的英特尔网卡。
- ASPM 选项
- PCI 选项
- USB 选项
- SATA 选项
- 内核选项
- 固件设置
- 音频选项
- GPU 选项
- 英特尔平均功率限制（RAPL）设置

## 安装

### 推荐：DistroPack（GTK 前端，托盘和守护进程）

对于大多数用户，建议通过 [DistroPack](https://distropack.dev) 安装，该工具为 Debian/Ubuntu、Fedora/RHEL/Rocky 和 Arch Linux 提供软件包，并自动处理发行版特有的差异。

**GTK 前端：**
访问 [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk) 获取针对您发行版的安装说明。

**系统托盘：**
访问 [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray) 获取针对您发行版的安装说明。

**仅守护进程：**
访问 [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon) 获取针对您发行版的安装说明。

### Arch Linux（AUR）

对于 Arch Linux 用户，也提供了 AUR 包：

- GTK: `power-options-gtk`（稳定版）和 `power-options-gtk-git`（前沿版）
- Webview: `power-options-webview`（稳定版）和 `power-options-webview-git`（前沿版）
- 系统托盘: `power-options-tray`（稳定版）和 `power-options-tray-git`（前沿版）
- 仅守护进程: `power-options-daemon`（稳定版）和 `power-options-daemon-git`（前沿版）

### Webview 前端（仅源码或 AUR）

Webview 前端当前不在 DistroPack 上提供，必须从源码安装或通过 AUR（针对 Arch Linux 用户）安装。


**来自 AUR（仅限 Arch Linux）：**
```bash
yay -S power-options-webview  # or power-options-webview-git for bleeding edge
```

要构建，需要开发库 `libsoup-3.0-dev`、`libwebkit2gtk-4.1-dev` 和  
`libxdo-dev`（或您发行版中的等效库）


```bash
# dioxus-cli is required
cargo install dioxus-cli
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-webview.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

### 从源码安装（备用方法）

如果您更喜欢从源码构建或DistroPack不支持您的发行版：

- GTK：

构建时，需要开发库 `libgtk4-dev` `libadwaita-1-dev`（或您发行版中的等效版本）

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-gtk.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- 系统托盘图标：

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-tray.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- 仅守护进程：

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-daemon.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

## 依赖项

有关*构建*依赖项，请参阅上面的安装指南。

必需：
- lspci
- lsusb
- acpi

可选：
- 兼容 iwlwifi 的网络卡，用于网络配置
- Intel 声卡，用于音频配置
- Intel/AMD GPU，用于 GPU 配置
- xrandr：分辨率/刷新率控制
- brightnessctl：亮度控制
- ifconfig：以太网阻止
- xset：屏幕关闭超时
- xautolock：系统挂起超时

Webview 前端：
- webkit2gtk
- dioxus-cli

GTK 前端：
- yad
- libadwaita

## 更新

如果您使用 DistroPack 安装，您的包管理器应自动处理
更新（例如，Debian/Ubuntu 的 `sudo apt update && sudo apt upgrade`，
Fedora 的 `sudo dnf update`，或 Arch 的 `sudo pacman -Syu`）。

如果您使用 AUR 安装，您的包管理器应处理
更新。

如果您使用安装脚本安装，只需拉取最新更改并
重新运行安装脚本和 `./update.sh`。**重要，切勿运行
`./uninstall.sh`、`./setup.sh` 或 `power-daemon-mgr setup`，如果您
想要保留您的配置文件**

## 限制
- 网络配置仅适用于Intel网卡和使用iwlwifi的网卡
- 分辨率和刷新率控制仅适用于X11（但其他选项应该也能工作）。
- 音频配置仅适用于Intel网卡和使用`snd_hda_intel`或`snd_ac97_codec`的设备
- GPU配置仅适用于Intel和AMD网卡或使用`i915`、`amdgpu`或`radeon`驱动/模块的设备。
- 分辨率和刷新率控制的设置仅在webview前端可用。

## 贡献

帮助的最简单方式之一是遇到错误时提交问题报告。
这让开发者知道需要修复什么，也方便未来遇到相同问题的用户找到解决方案。

Linux是一个庞大的生态系统，几乎所有方面都有替代方案。
虽然power-options是为最流行的Linux软件设计的，
但您仍可以通过为您使用的其他替代方案移植power-options并提交PR来帮助项目。
例如，可以将power-options从systemd移植出去，
或为Wayland添加一些X独有的功能等。

`dev`分支几乎总是包含一些尚未合并到`main`分支的实验性功能。
如果您的硬件支持这些功能，开发者将非常感谢您能在系统中测试它们并反馈潜在问题。
建议在这些情况下使用power-options的Discord服务器。

## 致谢
- Arch Linux Wiki (https://wiki.archlinux.org)
- TLP (https://github.com/linrunner/TLP)
- 开源Figma图标集 (https://www.figma.com/community/file/1250041133606945841/8-000-free-icons-open-source-icon-set)









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---