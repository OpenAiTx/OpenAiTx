# 硬盘风扇控制

[![CI 状态](https://img.shields.io/github/actions/workflow/status/desbma/hddfancontrol/ci.yml)](https://github.com/desbma/hddfancontrol/actions)
[![crates.io 版本](https://img.shields.io/crates/v/hddfancontrol)](https://crates.io/crates/hddfancontrol)
[![AUR 版本](https://img.shields.io/aur/version/hddfancontrol.svg?style=flat)](https://aur.archlinux.org/packages/hddfancontrol/)
[![许可证](https://img.shields.io/github/license/desbma/hddfancontrol.svg?style=flat)](https://github.com/desbma/hddfancontrol/blob/master/LICENSE)

---

自 2.0 版本起，该工具已用 Rust 重写。之前的 Python 版本可在 [v1 分支](https://github.com/desbma/hddfancontrol/tree/v1) 中找到。有关迁移，请参见 [从 v1.x 迁移](#migrating-from-v1x)。

---

硬盘风扇控制是一个命令行工具，用于根据 Linux 上硬盘温度动态控制风扇转速。

这有三个好处：

- 它允许将硬盘保持在理想温度范围，以获得最大寿命并避免过热

因为风扇在不需要时会减速或停止：

- 它最大限度地减少风扇产生的噪音
- 同时最大限度地减少电力消耗

## 目录

- [何时有用？](#when-is-this-useful)
- [功能](#features)
- [先决条件](#prerequisites)
- [安装](#installation)
  - [发行版软件包](#distribution-packages)
  - [从源码安装](#from-source)
- [配置](#configuration)
  - [注意事项](#a-word-of-caution)
  - [风扇配置](#fan-configuration)
- [更新日志](#changelog)
  - [从 v1.x 迁移](#migrating-from-v1x)
- [命令行使用](#command-line-usage)
- [systemd 服务](#systemd-service)
- [许可证](#license)
## 什么时候有用？

HDD 风扇控制在您有一个或多个硬盘，并且有一个或多个风扇靠近它们时非常有用，且不希望主板控制风扇速度，因为主板要么静态控制，要么使用与实际硬盘温度无关的温度传感器（可能在 CPU 上或主板的其他位置）。

理想的使用场景是带有多个硬盘、低功耗 CPU（如 ARM 或 Intel Atom）且采用无风扇被动散热的 NAS，机箱中有靠近硬盘的风扇。在这种情况下，CPU 产生的热量比硬盘少，因此根据主要热源控制风扇速度更合理。

## 功能

- 可以通过一次调用控制多个风扇和/或多个硬盘
- 支持 6 种不同的温度查询方式：
  - 调用 `hddtemp`
  - 查询 `hddtemp` 守护进程
  - 调用 `hdparm`
  - 调用 `smartctl`（SCT）
  - 调用 `smartctl`（SMART 属性）
  - 内核 hwmon 原生 `drivetemp`
- 可以适应不同的风扇特性
- 可根据您的需求自定义：
  - 在可自定义温度下停止风扇或全速运行
  - 永远不将风扇速度设定低于某个值（当 HDD 风扇控制是机箱中唯一可用风扇时非常有用）
- 还可以选择监控 CPU 温度，并相应控制风扇速度

## 先决条件

- 一个 Linux 发行版
- 至少一个支持以下功能的 SATA/SAS\* 硬盘：
  - 温度查询
  - 电源状态查询
- 一个主板，能够：
  - 向操作系统暴露用于控制风扇速度的 PWM
  - 向操作系统暴露用于查询风扇速度的传感器

大多数主板和 SATA 硬盘均满足这些要求。

\* 有多份报告显示 `hddfancontrol` 在 SAS 硬盘上表现良好，但该情况测试少于 SATA。

## 安装

### 发行版软件包

一些 Linux 发行版在其仓库中提供了 hddfancontrol 软件包：

- Alpine Linux（测试版）：[hddfancontrol](https://pkgs.alpinelinux.org/package/edge/testing/x86_64/hddfancontrol)
- Arch Linux（AUR）：[hddfancontrol](https://aur.archlinux.org/packages/hddfancontrol/)
- Fedora：[hddfancontrol](https://packages.fedoraproject.org/pkgs/hddfancontrol/hddfancontrol/)

有关每个标记版本构建的其他软件包/二进制文件，请参见 [GitHub 发布页面](https://github.com/desbma/hddfancontrol/releases)。

### 从源码安装

您需要一个 Rust 构建环境，例如来自 [rustup](https://rustup.rs/)。

在当前仓库中运行：


```
cargo build --release
install -Dm 755 -t /usr/local/bin target/release/hddfancontrol
```
还需安装 [hdparm](http://sourceforge.net/projects/hdparm/)、[smartctl](https://www.smartmontools.org/)、[sdparm](https://sg.danny.cz/sg/sdparm.html)（用于支持 SAS 硬盘），以及可选的 [hddtemp](http://www.guzu.net/linux/hddtemp.php)。
在最新的 Ubuntu 和其他 Debian 衍生版本上：`sudo apt install hdparm sdparm smartmontools`。

参见 [systemd 服务](#systemd-service) 以便轻松管理守护进程。

### 来自 [`crates.io`](https://crates.io/)


```
sudo cargo install --root /usr/local
```
## 配置

### 注意事项

默认参数将在温度 > 50°C 时以 100% 转速运行风扇，在温度 < 30°C 时以 20% 转速运行风扇，这对应于通常推荐的驱动器工作温度。如果您确定系统中没有其他产生显著热量的组件，或者您有其他风扇来冷却系统，或者您有一个优化了被动冷却的机箱，您可以将最低转速设置为 0%，这样在温度低于最低阈值时风扇将停止转动。

**请注意，错误配置此工具可能导致系统无法正确冷却，从而损坏组件或缩短其寿命。**

在长时间无人监控使用 HDD 风扇控制前，建议保持最低风扇转速以确保安全，并检查系统温度是否保持在合理范围内。

### 风扇配置

要获取 `--pwm` 参数的启动/停止值，您可以：

- 使用 `pwm-test` 命令（`hddfancontrol pwm-test ...`），它将运行一些测试并检测风扇启动和停止时的值。但您需要事先确定 PWM 文件（`--pwm` 参数）。
- 使用 [pwmconfig 工具](http://www.lm-sensors.org/wiki/man/pwmconfig)。

## 更新日志

请参阅 [详细更新日志](https://raw.githubusercontent.com/desbma/hddfancontrol/master/./CHANGELOG.md) 查看自初始版本 2 以来的所有变更。

### 从 v1.x 迁移

在版本 2 中，`hddfancontrol` 完全用 Rust 语言重写。与版本 1 相比，主要变化包括：

- `hddfancontrol` 是编译后的二进制文件，不再需要 Python 解释器。
- 命令行参数稍有变化，您需要手动调整，无论是在调用 `hddfancontrol` 时，还是如果通过 systemd 服务使用，则在 `/etc/conf.d/hddfancontrol` 文件中。参考 `hddfancontrol daemon -h`。
- 自动硬盘休眠功能已被移除。如果您需要此功能，建议使用 [hd-idle](https://github.com/adelolmo/hd-idle)（注意有多个类似名称的项目），它能很好地与 `hddfancontrol` 配合使用。

## 命令行用法

运行 `hddfancontrol -h` 可获取完整命令行参考。

例如，下面的命令行将指示 HDD 风扇控制：

- 监控驱动器 `/dev/sda` 和 `/dev/sdb` 的温度
- 使用 `/sys/class/hwmon/hwmon1/device/` 中的 PWM 2 和 3 控制风扇转速
- 以 PWM 值 200 启动两个风扇
- 认为风扇在 PWM 值 75 时停止

- 风扇转速绝不低于最大转速的10%
- 至少每分钟检查一次温度

`hddfancontrol daemon -d /dev/sda /dev/sdb -p /sys/class/hwmon/hwmon1/device/pwm2:200:75 /sys/class/hwmon/hwmon1/device/pwm3:200:75 --min-fan-speed-prct 10 -i 1min`

## systemd 服务

提供了一个 systemd 服务文件以便轻松控制守护进程。
如果你是通过发行版包安装的 hddfancontrol，通常已经安装了该服务文件，否则你可以从本仓库源码安装：

```
sudo install -Dm 644 ./systemd/hddfancontrol.service /etc/systemd/system/hddfancontrol.service
sudo install -Dm 644 ./systemd/hddfancontrol.conf /etc/conf.d/hddfancontrol
```

然后您需要编辑 `/etc/conf.d/hddfancontrol` 中的 `HDDFANCONTROL_DAEMON_ARGS` 变量来设置参数（硬盘，温度范围等）。

然后您可以使用 `sudo systemctl start hddfancontrol` 启动守护进程，使用 `sudo systemctl status hddfancontrol` 查看其状态，并使用 `sudo systemctl enable hddfancontrol` 启用开机自动启动。

## 许可协议

[GPLv3](https://www.gnu.org/licenses/gpl-3.0-standalone.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-09

---