<div align="center">
    <img src="https://raw.githubusercontent.com/TheAlexDev23/power-options/main/icon.png" width=120>
    <h1>
        パワーオプション
    </h1>
    <a href="https://discord.gg/KyZt97MvdU">
        <img src="https://img.shields.io/badge/Discord-%235865F2.svg?style=for-the-badge&logo=discord&logoColor=white">
    </a>
    <a href="https://www.paypal.com/paypalme/AlexanderKarpukhin2">
        <img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white">
    </a>
</div>

<br/>

あらゆるデバイスでのシンプルかつ高度な電源管理のためのオールインワンで超高速なLinux GUIアプリケーション。

Power Optionsは、TLP、auto-cpufreq、cpupower-guiなど、あらゆる省電力アプリケーションの代替として利用可能です。Power Optionsは最も一般的な省電力設定を網羅し、他のアプリケーションにはない追加機能も備えています。

インストール時に、Power Optionsはシステムを解析し、その結果に基づいて幅広いプロファイルを賢く生成します。これらのプロファイルは高度に最適化されており、ユーザーがより細かく制御したい場合を除き介入は不要です。

ほとんどのアプリケーションはバッテリープロファイルとACプロファイルの2つのみを許可しています。これはより細かな制御を望む場合には最適ではありません。これがこのプログラムが採用するプロファイルシステムの創出につながりました：
- ユーザーは好きなだけ多くのプロファイルを持つことができる
- ユーザーはバッテリーとACに選択されるプロファイルを決定する
- ユーザーは一時的にプロファイル選択を別のものに上書きできる（上書き解除まで有効）
- ユーザーは再起動後も維持される永続的な上書きを設定できる

## 利用可能なフロントエンド／インターフェース

デーモンをインストールして設定ファイルを手動で編集することも可能で、これらはTOML形式で記述されています。しかし、このプログラムの最大の強みは、ほとんどの他の省電力ツールが提供しないGUIインターフェースにあります。










ひとつ持っていて、設定ファイルに頼る。

### ネイティブGTKフロントエンド

シンプルで軽量、ネイティブな簡単なインターフェース。ほとんどの
ユーザーに推奨されます。

![gtk-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/gtk-slideshow.gif)

### WebKitフロントエンド

より高度なオプションとより大きな制御が可能。軽量ではありません。より
高度なユーザーや、他の電源管理ソリューションと併用したいユーザーに
推奨されます。

![webview-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/webview-slideshow.gif)

## 機能

Power optionsは、最大のLinuxウィキやガイド、その他の省電力アプリ
ケーションからのすべてのヒントや推奨事項の記憶に基づいて作成され
ました。例としては以下が含まれます：
- https://wiki.archlinux.org/title/Power_management
- https://wiki.gentoo.org/wiki/Power_management/Guide
- https://en.wikipedia.org/wiki/Power_management
- https://github.com/supplantr/ftw
- https://github.com/linrunner/TLP
- https://github.com/AdnanHodzic/auto-cpufreq
- https://github.com/vagnum08/cpupower-gui

Power Optionには以下の機能があります：
- 他の代替品より多くのプロファイルタイプ
- ユーザーのシステムを分析してスマートにプロファイルを生成可能
- システムスリープオプション（サスペンド、画面オフ）
- CPUオプション
- 個別CPUコアオプション。ほとんどの省電力ツールに欠けているこの
  オプションは本プロジェクトの主な動機の一つでした。
- 画面オプション
- 無線コンポーネントの無効化オプション（例：Bluetooth、WiFi、NFC）
- ネットワークオプション。代替アプリケーションよりもはるかに大きな
  制御を可能にしますが
  ネットワークドライバーのリロードが必要です。iwlwifiを使用するIntelネットワークカードに限定されます。
- ASPMオプション
- PCIオプション
- USBオプション
- SATAオプション
- カーネルオプション
- ファームウェア設定
- オーディオオプション
- GPUオプション
- Intelのランニングアベレージパワーリミット（RAPL）設定

## インストール

### 推奨：DistroPack（GTKフロントエンド、トレイ＆デーモン）

ほとんどのユーザーには、ディストリビューション固有の問題を自動で処理するDebian/Ubuntu、Fedora/RHEL/Rocky、およびArch Linux用のパッケージを提供する[DistroPack](https://distropack.dev)を通じたインストールを推奨します。

**GTKフロントエンド：**  
お使いのディストリビューションに特化したインストール手順は、[https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk)をご覧ください。

**システムトレイ：**  
お使いのディストリビューションに特化したインストール手順は、[https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray)をご覧ください。

**デーモンのみ：**  
お使いのディストリビューションに特化したインストール手順は、[https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon)をご覧ください。

### Arch Linux（AUR）

Arch Linuxユーザー向けにAURパッケージも提供されています：

- GTK：`power-options-gtk`（安定版）および`power-options-gtk-git`（最先端版）
- Webview：`power-options-webview`（安定版）および`power-options-webview-git`（最先端版）
- システムトレイ：`power-options-tray`（安定版）および`power-options-tray-git`（最先端版）
- デーモンのみ：`power-options-daemon`（安定版）および`power-options-daemon-git`（最先端版）

### Webviewフロントエンド（ソースまたはAURのみ）

Webviewフロントエンドは現在DistroPackでは利用できず、ソースからのインストールかAUR（Arch Linuxユーザー向け）経由でのインストールが必要です。


**AUR（Arch Linuxのみ）から：**
```bash
yay -S power-options-webview  # or power-options-webview-git for bleeding edge
```
ビルドするには、開発ライブラリ `libsoup-3.0-dev`、`libwebkit2gtk-4.1-dev`、および
`libxdo-dev`（またはお使いのディストリビューションに相当するもの）が必要です。



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

### ソースからのインストール（代替方法）

ソースからビルドすることを希望する場合や、DistroPackがあなたのディストリビューションをサポートしていない場合：

- GTK：

ビルドには、開発ライブラリ `libgtk4-dev` `libadwaita-1-dev`（または
あなたのディストリビューションで同等のもの）が必要です
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

- システムトレイアイコン：

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

- デーモンのみ：

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
## 依存関係

*ビルド*依存関係については、上記のインストールガイドを参照してください。

必須:
- lspci
- lsusb
- acpi

オプション:
- ネットワーク設定用の iwlwifi 対応ネットワークカード
- オーディオ設定用の Intel サウンドカード
- GPU 設定用の Intel/AMD GPU
- xrandr: 解像度/リフレッシュレート制御
- brightnessctl: 輝度制御
- ifconfig: イーサネットブロック
- xset: 画面オフタイムアウト
- xautolock: システムサスペンドタイムアウト

Webview フロントエンド:
- webkit2gtk
- dioxus-cli

GTK フロントエンド:
- yad
- libadwaita

## 更新

DistroPack を使用してインストールした場合、パッケージマネージャーが自動的に
更新を処理します（例：Debian/Ubuntu では `sudo apt update && sudo apt upgrade`、
Fedora では `sudo dnf update`、Arch では `sudo pacman -Syu`）。

AUR を使用してインストールした場合も、パッケージマネージャーが
更新を処理します。

インストールスクリプトを使用してインストールした場合は、最新の変更をプルし、
インストールスクリプトを再実行し、`./update.sh` を実行してください。**重要: `./uninstall.sh`、`./setup.sh` または `power-daemon-mgr setup` を実行しないでください。**


want to keep your profiles**

## 制限事項
- ネットワーク設定はIntel製カードおよびiwlwifiを使用するカードでのみ動作します
- 解像度とリフレッシュレートの制御はX11でのみ動作します（他のオプションも動作するはずです）。
- オーディオ設定はIntel製カードおよび`snd_hda_intel`または`snd_ac97_codec`を使用するカードでのみ動作します
- GPU設定はIntelおよびAMD製カード、または`i915`、`amdgpu`、`radeon`ドライバー/モジュールを使用するカードでのみ動作します。
- 解像度とリフレッシュレート制御の設定はウェブビューのフロントエンドでのみ利用可能です。

## 貢献について

最も簡単な貢献方法の一つは、エラーに遭遇したときにIssueを開くことです。
これにより開発者は修正箇所を把握でき、同じ問題を持つ将来のユーザーが解決策を見つけやすくなります。

Linuxは大規模なエコシステムであり、ほぼすべてに代替手段があります。
power-optionsは最も人気のあるLinuxソフトウェア向けに作られていますが、
systemdからの移植、WaylandへのX限定機能の追加など、あなたが使っている他の代替手段向けに
power-optionsを移植しPRを開くことで支援することも可能です。

`dev`ブランチはほぼ常に`main`ブランチに統合される前の実験的な機能を含んでいます。
あなたのハードウェアがそれらの機能をサポートしている場合、システムでテストし
問題を報告していただけると開発者は非常に感謝します。
そのような場合にはpower-optionsのDiscordサーバーの利用を推奨します。

## 謝辞
- Arch Linux Wiki (https://wiki.archlinux.org)
- TLP (https://github.com/linrunner/TLP)
- Open Source Figma Icon set (https://www.figma.com/community/file/1250041133606945841/8-000-free-icons-open-source-icon-set)









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---