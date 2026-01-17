# UniControlHub

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)
![Downloads](https://img.shields.io/github/downloads/rohitsangwan01/uni_control_hub/total.svg)

<p align="center">
  <img src="https://github.com/user-attachments/assets/41c886c0-f08c-4186-bc98-153aa2769d13" height=150 />
</p>

UniControlHub：デバイスをシームレスに連携

UniControlHubは、複数のデバイス間でシームレスで直感的な操作体験を提供することで、デジタル環境とのやり取りを革新します。AppleのUniversal Controlの利便性と流動性に着想を得て、UniControlHubはAppleエコシステムを超えたこの革新的な機能を拡張します。マウスとキーボードを1つだけ使って、デバイスを簡単に操作・管理でき、UniControlHubは統一された生産的な作業環境を実現します。Flutterで構築されており、滑らかで応答性の高いユーザー体験を提供するこのアプリは、生産性向上とデジタルライフの効率化に最適なツールです。

![macOS](https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Linux](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)

<a href="https://buymeacoffee.com/rohitsangwan" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## はじめに

プラットフォーム向けのアプリは[リリース](https://github.com/rohitsangwan01/uni_control_hub/releases)セクションからダウンロードしてください

### MacOS

- libusbをインストール：`brew install libusb`

### Windows

- お使いの[x86](https://aka.ms/vs/17/release/vc_redist.x86.exe)または[x64](https://aka.ms/vs/17/release/vc_redist.x64.exe) OSに対応した`Microsoft Visual C++ 2015-2022`をインストールしてください。

- Androidデバイスが検出されない場合は、libusbの[ドライバー](https://github.com/libusb/libusb/wiki/Windows#driver-installation)がインストールされていることを確認してください。

### Linux

`libqt5dbus5`がインストールされていることを確認してください

Ubuntu/Debian系のシステムでは、以下を実行してください：

```bash
sudo apt update
sudo apt install libqt5dbus5
```

Fedora/RHEL/CentOSでは、次を実行してください：

```bash
sudo dnf install qt5-qtbase
```

Arch Linuxでは、以下を実行してください：

```bash
sudo pacman -S qt5-base
```
## 対応プラットフォーム

| プラットフォーム | Bluetooth | USB | ADB |
| -------- | --------- | --- | --- |
| IOS      | ✅        | ❌  | ❌  |
| Android  | ⏳        | ✅  | ✅  |

## スクリーンショット

<p align="start">
  <img src="https://github.com/rohitsangwan01/uni_control_hub/assets/59526499/7b2b87c3-4501-490b-a205-0e3815c4b583" height=400 />
</p>

## デモ

[![](http://markdown-videos-api.jorgenkh.no/youtube/KYsqdJkG2N0)](https://youtu.be/KYsqdJkG2N0)

## トラブルシューティング

- MacOSでは、アプリが`アクセシビリティ`と`Bluetooth`の許可を求めます（アップデート後、すでに許可されていても再度アクセシビリティの許可を求めることがあります。その場合はアクセシビリティからアプリを削除して再度実行してください）
- AndroidでUHIDモードを使用するには、`ADB`がインストールされていることを確認してください（AOAモードでは不要です）
- デスクトップおよびIOS接続の場合、Bluetoothがオンになっていることを確認してください
- Androidデバイス接続後は、更新ボタンをクリックしてください

## 開発者ガイド

このセクションでは、開発目的でUniControlHubをセットアップし実行する方法を案内します。

#### 前提条件：

- ご使用のOSに最新の[Flutter](https://flutter-ko.dev/get-started/install)をインストールしてください。公式Flutterウェブサイトで手順を確認できます。
- プラットフォームに応じた[Flutter](https://flutter-ko.dev/get-started/install)セットアップガイドに従ってください。AndroidやiOS向けの開発でなければ、それら特有のステップはスキップ可能です。

#### アプリの実行/デバッグ：

- Flutterのセットアップが完了したら、依存関係をダウンロードするために`flutter pub get`を実行し、アプリを起動するには`flutter run`を実行してください

## スポンサー


このプロジェクトが役立つと感じたら、ぜひスポンサーになってください！皆様のサポートが開発の継続、新機能の追加、安定性の向上に繋がります。また、[Discussions](https://github.com/rohitsangwan01/uni_control_hub/discussions)でアイデアやフィードバックを共有することもできます。ご支援ありがとうございます！🚀

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/rohitsangwan)

## 追加の注意事項：

UniControlHubはクロスプラットフォームのキーボード・マウス共有に[Synergyサーバー](https://github.com/symless/synergy-core)を使用しています。[Synergy](https://symless.com/synergy)の詳細は公式サイトをご覧ください。

UniControlHubへの貢献を歓迎します！バグを見つけた場合や機能要望がある場合は、GitHubリポジトリでIssueを開いてください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---