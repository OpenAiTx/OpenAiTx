usb-gadget
==========

[![crates.io page](https://img.shields.io/crates/v/usb-gadget)](https://crates.io/crates/usb-gadget)
[![docs.rs page](https://docs.rs/usb-gadget/badge.svg)](https://docs.rs/usb-gadget)
[![Apache 2.0 license](https://img.shields.io/crates/l/usb-gadget)](https://github.com/surban/usb-gadget/blob/master/LICENSE)

This library allows implementation of USB peripherals, so called **USB gadgets**,
on Linux devices that have a USB device controller (UDC).
Both, pre-defined USB functions and fully custom implementations of the USB
interface are supported.

The following pre-defined USB functions, implemented by kernel drivers, are available:

* network interface
    * CDC ECM
    * CDC ECM (subset)
    * CDC EEM
    * CDC NCM
    * RNDIS
* serial port
    * CDC ACM
    * generic
* human interface device (HID)
* mass-storage device (MSD)
* printer device
* musical instrument digital interface (MIDI)
* audio device (UAC1 and UAC2)
* video device (UVC)

In addition fully custom USB functions can be implemented in user-mode Rust code.

Support for OS-specific descriptors and WebUSB is also provided.

CLI tool
--------

The `usb-gadget` CLI tool allows you to configure USB gadgets from TOML configuration
files without writing any Rust code.

### Installation

    cargo install usb-gadget --features cli

### Usage

Create a TOML configuration file describing your gadget, then use the CLI to manage it:

    usb-gadget up gadget.toml       # register and bind a gadget
    usb-gadget list                 # list registered gadgets
    usb-gadget down my-gadget       # remove a gadget by name
    usb-gadget down --all           # remove all gadgets
    usb-gadget check gadget.toml    # validate a config file

You can also pass a directory to `up` or `check` to process all `.toml` files in it.

### Example configuration

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
Multiple functions can be combined in a single gadget by adding more `[[config.function]]`
entries. Run `usb-gadget template --list` to see all available templates.

Features
--------

This crate provides the following optional features:

* `cli`: builds the `usb-gadget` CLI tool for configuring gadgets from TOML files.
* `tokio`: enables async support for custom USB functions on top of the Tokio runtime.

Requirements
------------

The minimum supported Rust version (MSRV) is 1.77.

A USB device controller (UDC) supported by Linux is required. Normally, standard
PCs *do not* include an UDC.
A Raspberry Pi 4 contains an UDC, which is connected to its USB-C port.

The following Linux kernel configuration options should be enabled for full functionality:

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


root permissions are required to configure USB gadgets on Linux and
the `configfs` filesystem needs to be mounted.


License
-------

usb-gadget is licensed under the [Apache 2.0 license].

[Apache 2.0 license]: https://github.com/surban/usb-gadget/blob/master/LICENSE

### Contribution

Unless you explicitly state otherwise, any contribution intentionally submitted
for inclusion in usb-gadget by you, shall be licensed as Apache 2.0, without any
additional terms or conditions.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---