usb-gadget
==========

[![crates.io 页面](https://img.shields.io/crates/v/usb-gadget)](https://crates.io/crates/usb-gadget)
[![docs.rs 页面](https://docs.rs/usb-gadget/badge.svg)](https://docs.rs/usb-gadget)
[![Apache 2.0 许可证](https://img.shields.io/crates/l/usb-gadget)](https://github.com/surban/usb-gadget/blob/master/LICENSE)

此库允许在具有 USB 设备控制器 (UDC) 的 Linux 设备上实现 USB 外设，称为 **USB gadget**。
支持预定义的 USB 功能和完全自定义的 USB 接口实现。

以下由内核驱动实现的预定义 USB 功能可用：

* 网络接口
    * CDC ECM
    * CDC ECM（子集）
    * CDC EEM
    * CDC NCM
    * RNDIS
* 串口
    * CDC ACM
    * 通用
* 人机接口设备 (HID)
* 大容量存储设备 (MSD)
* 打印机设备
* 数字音乐接口 (MIDI)
* 音频设备 (UAC1 和 UAC2)
* 视频设备 (UVC)

此外，还可以在用户态 Rust 代码中实现完全自定义的 USB 功能。

还支持操作系统特定描述符和 WebUSB。

CLI 工具
--------

`usb-gadget` CLI 工具允许您通过 TOML 配置文件配置 USB gadget，而无需编写任何 Rust 代码。




### 安装

    cargo install usb-gadget --features cli

### 使用方法

创建一个描述您的设备的 TOML 配置文件，然后使用 CLI 来管理它：

    usb-gadget up gadget.toml       # 注册并绑定一个设备
    usb-gadget list                 # 列出已注册的设备
    usb-gadget down my-gadget       # 按名称移除一个设备
    usb-gadget down --all           # 移除所有设备
    usb-gadget check gadget.toml    # 验证配置文件

您也可以传递一个目录给 `up` 或 `check`，以处理其中的所有 `.toml` 文件。

### 示例配置

```toml
name = "serial-debug"

[device]
vendor = 0x1209
product = 0x0002
manufacturer = "Example Inc."
product_name = "Debug Console"
serial = "0001"

[[config]]
description = "Serial Config"

[[config.function]]
type = "serial"
class = "acm"
```
多个功能可以通过添加更多的 `[[config.function]]` 条目组合在一个设备中。运行 `usb-gadget template --list` 可查看所有可用的模板。

功能
--------

本crate提供以下可选功能：

* `cli`：构建用于从TOML文件配置设备的 `usb-gadget` CLI工具。
* `tokio`：启用基于Tokio运行时的自定义USB功能的异步支持。

要求
------------

最低支持的Rust版本（MSRV）是1.77。

需要Linux支持的USB设备控制器（UDC）。通常，标准PC *不*包含UDC。
Raspberry Pi 4包含一个UDC，连接到其USB-C端口。

以下Linux内核配置选项应启用以实现完整功能：

  * `CONFIG_USB_GADGET`
  * `CONFIG_USB_CONFIGFS`
  * `CONFIG_USB_CONFIGFS_SERIAL`
  * `CONFIG_USB_CONFIGFS_ACM`
  * `CONFIG_USB_CONFIGFS_NCM`
  * `CONFIG_USB_CONFIGFS_ECM`
  * `CONFIG_USB_CONFIGFS_ECM_SUBSET`
  * `CONFIG_USB_CONFIGFS_RNDIS`
  * `CONFIG_USB_CONFIGFS_EEM`
  * `CONFIG_USB_CONFIGFS_MASS_STORAGE`
  * `CONFIG_USB_CONFIGFS_F_FS`
  * `CONFIG_USB_CONFIGFS_F_HID`
  * `CONFIG_USB_CONFIGFS_F_PRINTER`
  * `CONFIG_USB_CONFIGFS_F_MIDI`
  * `CONFIG_USB_CONFIGFS_F_UAC1`
  * `CONFIG_USB_CONFIGFS_F_UAC2`
  * `CONFIG_USB_CONFIGFS_F_UVC`




在 Linux 上配置 USB 设备需要 root 权限，并且需要挂载 `configfs` 文件系统。


许可协议
-------

usb-gadget 采用 [Apache 2.0 许可协议] 进行许可。

[Apache 2.0 许可协议]: https://github.com/surban/usb-gadget/blob/master/LICENSE

### 贡献

除非您明确声明，否则您有意提交的任何用于包含在 usb-gadget 中的贡献，
均应按照 Apache 2.0 许可协议授权，且不附加任何额外条款或条件。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---