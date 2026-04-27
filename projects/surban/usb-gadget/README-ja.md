usb-gadget
==========

[![crates.io page](https://img.shields.io/crates/v/usb-gadget)](https://crates.io/crates/usb-gadget)
[![docs.rs page](https://docs.rs/usb-gadget/badge.svg)](https://docs.rs/usb-gadget)
[![Apache 2.0 license](https://img.shields.io/crates/l/usb-gadget)](https://github.com/surban/usb-gadget/blob/master/LICENSE)

このライブラリは、USBデバイスコントローラ（UDC）を搭載したLinuxデバイス上で、**USBガジェット**と呼ばれるUSB周辺機器の実装を可能にします。
あらかじめ定義されたUSB機能と、USBインターフェースの完全なカスタム実装の両方をサポートしています。

カーネルドライバによって実装された以下のあらかじめ定義されたUSB機能が利用可能です：

* ネットワークインターフェース
    * CDC ECM
    * CDC ECM（サブセット）
    * CDC EEM
    * CDC NCM
    * RNDIS
* シリアルポート
    * CDC ACM
    * ジェネリック
* ヒューマンインターフェースデバイス（HID）
* 大容量記憶装置デバイス（MSD）
* プリンタデバイス
* ミュージカルインストゥルメントデジタルインターフェース（MIDI）
* オーディオデバイス（UAC1およびUAC2）
* ビデオデバイス（UVC）

加えて、ユーザーモードのRustコードで完全にカスタムなUSB機能を実装することも可能です。

OS固有のディスクリプタおよびWebUSBのサポートも提供されています。

CLIツール
--------

`usb-gadget` CLIツールを使うと、Rustコードを書かずにTOML設定ファイルからUSBガジェットを構成できます。




### インストール

    cargo install usb-gadget --features cli

### 使い方

ガジェットを記述したTOML設定ファイルを作成し、CLIで管理します：

    usb-gadget up gadget.toml       # ガジェットを登録してバインドする
    usb-gadget list                 # 登録されたガジェットを一覧表示する
    usb-gadget down my-gadget       # 名前でガジェットを削除する
    usb-gadget down --all           # すべてのガジェットを削除する
    usb-gadget check gadget.toml    # 設定ファイルを検証する

`up` または `check` にディレクトリを渡すと、その中のすべての `.toml` ファイルを処理できます。

### 設定例

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
複数の機能は、より多くの `[[config.function]]` エントリを追加することで、単一のガジェットに組み合わせることができます。利用可能なテンプレートを確認するには、`usb-gadget template --list` を実行してください。

機能
--------

このクレートは以下のオプション機能を提供します:

* `cli`: TOMLファイルからガジェットを設定するための `usb-gadget` CLIツールをビルドします。
* `tokio`: Tokioランタイム上でのカスタムUSB機能の非同期サポートを有効にします。

要件
------------

サポートされる最低Rustバージョン（MSRV）は1.77です。

LinuxでサポートされているUSBデバイスコントローラ（UDC）が必要です。通常、標準的な
PCにはUDCは含まれていません。
Raspberry Pi 4にはUDCが含まれており、USB-Cポートに接続されています。

完全な機能を利用するためには、以下のLinuxカーネル設定オプションを有効にする必要があります:

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



USBガジェットをLinuxで設定するにはroot権限が必要であり、
`configfs`ファイルシステムをマウントする必要があります。


ライセンス
-------

usb-gadgetは[Apache 2.0ライセンス]の下でライセンスされています。

[Apache 2.0ライセンス]: https://github.com/surban/usb-gadget/blob/master/LICENSE

### 貢献

明示的に異なる記載がない限り、usb-gadgetへの含有を意図して提出された
貢献はすべて、追加の条件なしにApache 2.0ライセンスで提供されます。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---