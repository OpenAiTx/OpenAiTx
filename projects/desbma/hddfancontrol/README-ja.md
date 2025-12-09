# HDDファン制御

[![CIステータス](https://img.shields.io/github/actions/workflow/status/desbma/hddfancontrol/ci.yml)](https://github.com/desbma/hddfancontrol/actions)
[![crates.ioバージョン](https://img.shields.io/crates/v/hddfancontrol)](https://crates.io/crates/hddfancontrol)
[![AURバージョン](https://img.shields.io/aur/version/hddfancontrol.svg?style=flat)](https://aur.archlinux.org/packages/hddfancontrol/)
[![ライセンス](https://img.shields.io/github/license/desbma/hddfancontrol.svg?style=flat)](https://github.com/desbma/hddfancontrol/blob/master/LICENSE)

---

バージョン2.0以降、このツールはRustで書き直されました。以前のPython版は[v1ブランチ](https://github.com/desbma/hddfancontrol/tree/v1)で見つけることができます。移行については[バージョン1.xからの移行](#migrating-from-v1x)を参照してください。

---

HDDファン制御は、Linux上でハードドライブの温度に応じてファン速度を動的に制御するコマンドラインツールです。

これには3つの利点があります：

- ハードドライブを理想的な温度範囲に保ち、最大の寿命を維持し過熱を防止できます

ファンは不要なときに減速または停止するため：

- ファンから発生する騒音を最小限に抑えます
- 同時に消費電力も最小限に抑えます

## 目次

- [いつ役立つのか？](#when-is-this-useful)
- [機能](#features)
- [前提条件](#prerequisites)
- [インストール](#installation)
  - [ディストリビューションパッケージ](#distribution-packages)
  - [ソースから](#from-source)
- [設定](#configuration)
  - [注意事項](#a-word-of-caution)
  - [ファン設定](#fan-configuration)
- [更新履歴](#changelog)
  - [バージョン1.xからの移行](#migrating-from-v1x)
- [コマンドライン使用法](#command-line-usage)
- [systemdサービス](#systemd-service)
- [ライセンス](#license)
## これはいつ役立つのか？

HDDファン制御は、1台または複数のハードドライブの近くに1台または複数のファンがあり、マザーボードにファン速度を制御させたくない場合に役立ちます。マザーボードはファン速度を静的に制御するか、実際のドライブ温度とは関係のない温度センサー（CPU上またはマザーボードの他の場所）を使って制御するためです。

理想的な使用例は、複数のハードドライブを搭載したNASで、低消費電力CPU（例えばARMやIntel Atom）をパッシブ冷却（ファンなし）で使用し、シャーシにハードドライブ近くにファンがある場合です。この場合、CPUはハードドライブよりも熱をあまり発生しないため、主要な熱源に応じてファン速度を制御するのが理にかなっています。

## 特長

- 複数のファンおよび／または複数のドライブを一度の呼び出しで制御可能
- 温度取得方法を6通りサポート：
  - `hddtemp`呼び出し
  - `hddtemp`デーモンクエリ
  - `hdparm`呼び出し
  - `smartctl`呼び出し（SCT）
  - `smartctl`呼び出し（SMART属性）
  - `drivetemp`ネイティブカーネルhwmon
- 異なるファン特性に適応可能
- ニーズに合わせてカスタマイズ可能：
  - カスタマイズ可能な温度でファンを停止または全速で動作させる
  - ファン速度を一定の下限以下に設定しない（HDDファン制御がシャーシ内で唯一のファン制御の場合に有用）
- オプションでCPU温度も監視し、それに応じてファン速度を制御可能

## 前提条件

- Linuxディストリビューション
- 少なくとも1台のSATA/SAS\*ハードドライブで、以下をサポートしていること：
  - 温度クエリ
  - 電源状態クエリ
- マザーボードは以下をOSに公開していること：
  - ファン速度制御用PWM
  - ファン速度クエリ用センサー

ほとんどのマザーボードおよびSATAドライブはこれらの要件に適合します。

\* SASドライブで`hddfancontrol`が良好に動作したとの報告はいくつかありますが、SATAよりテストは少なめです。

## インストール

### ディストリビューションパッケージ


いくつかのLinuxディストリビューションでは、リポジトリにhddfancontrolパッケージが用意されています：

- Alpine Linux（テスト版）：[hddfancontrol](https://pkgs.alpinelinux.org/package/edge/testing/x86_64/hddfancontrol)
- Arch Linux（AUR）：[hddfancontrol](https://aur.archlinux.org/packages/hddfancontrol/)
- Fedora：[hddfancontrol](https://packages.fedoraproject.org/pkgs/hddfancontrol/hddfancontrol/)

各タグ付けバージョン用にビルドされた他のパッケージやバイナリは[GitHubのリリース](https://github.com/desbma/hddfancontrol/releases)をご覧ください。

### ソースから

[rustup](https://rustup.rs/)などでRustのビルド環境が必要です。

現在のリポジトリで以下を実行してください：

```
cargo build --release
install -Dm 755 -t /usr/local/bin target/release/hddfancontrol
```

また、[hdparm](http://sourceforge.net/projects/hdparm/)、[smartctl](https://www.smartmontools.org/)、[sdparm](https://sg.danny.cz/sg/sdparm.html)（SASドライブ対応用）、およびオプションで[hddtemp](http://www.guzu.net/linux/hddtemp.php)をインストールしてください。  
最近のUbuntuやその他のDebian派生ディストリビューションでは、`sudo apt install hdparm sdparm smartmontools` を実行します。

デーモンの管理を簡単に行うには、[systemdサービス](#systemd-service)を参照してください。

### [`crates.io`](https://crates.io/)からのインストール

```
sudo cargo install --root /usr/local
```
## 設定

### 注意事項

デフォルトのパラメータでは、温度が50°Cを超えるとファンを100%の速度で回し、30°C未満の場合は20%の速度で回します。これは一般的に推奨されるドライブの動作温度に対応しています。システム内に大きな熱を発生させる他のコンポーネントがないことを確信している場合、他のファンでシステムを冷却している場合、またはパッシブ冷却に最適化されたケースを使用している場合は、最小速度を0%に設定できます。これにより温度が最小閾値を下回るとファンが停止します。

**このツールの設定ミスは、システムの冷却不良を引き起こし、コンポーネントに損傷を与えたり寿命を短くする可能性があることに注意してください。**

長時間無監視でHDDファン制御を使用する前に、安全のために最低ファンスピードを維持し、システムの温度が期待通りの範囲内にあることを確認することをお勧めします。

### ファンの設定

`--pwm` パラメータの開始/停止値を取得するには、以下のいずれかを行います：

- `pwm-test` コマンド（`hddfancontrol pwm-test ...`）を使用してテストを実行し、ファンが開始および停止する値を検出します。ただし、事前にPWMファイル（`--pwm` パラメータ）を特定しておく必要があります。
- [pwmconfigツール](http://www.lm-sensors.org/wiki/man/pwmconfig)を使用します。

## 変更履歴

初版2以降のすべての変更については、[詳細な変更履歴](https://raw.githubusercontent.com/desbma/hddfancontrol/master/./CHANGELOG.md)をご覧ください。

### v1.xからの移行

バージョン2では、`hddfancontrol` はRust言語で完全に書き直されました。バージョン1からの主な変更点は以下の通りです：

- `hddfancontrol` はコンパイル済みバイナリとなり、Pythonインタプリタは不要になりました。
- コマンドライン引数が若干変更されており、手動で調整する必要があります。`hddfancontrol` の呼び出し時か、systemdサービス経由で使用している場合は `/etc/conf.d/hddfancontrol` ファイルで調整してください。参照は `hddfancontrol daemon -h` をご覧ください。
- 自動ドライブスピンダウン機能は削除されました。必要な場合は、[hd-idle](https://github.com/adelolmo/hd-idle)（同名のプロジェクトが複数あるので注意）を使用することをお勧めします。`hddfancontrol` と併用可能です。

## コマンドライン使用法

`hddfancontrol -h` を実行すると、完全なコマンドラインリファレンスが表示されます。

例として、以下のコマンドラインはHDDファン制御に対して以下を指示します：

- `/dev/sda` と `/dev/sdb` のドライブ温度を監視
- `/sys/class/hwmon/hwmon1/device/` 内のPWM 2および3を使用してファンスピードを制御
- 両方のファンをPWM値200で開始
- ファンがPWM値75で停止すると見なす

- ファンを最大速度の10%未満で動作させないこと  
- 温度を少なくとも毎分チェックすること  

`hddfancontrol daemon -d /dev/sda /dev/sdb -p /sys/class/hwmon/hwmon1/device/pwm2:200:75 /sys/class/hwmon/hwmon1/device/pwm3:200:75 --min-fan-speed-prct 10 -i 1min`  

## systemd サービス  

systemdサービスファイルが提供されており、デーモンを簡単に制御できます。  
もしhddfancontrolをディストリビューションのパッケージからインストールしていれば、すでにインストールされている可能性が高いですが、そうでなければこのリポジトリのソースからインストールできます。

```
sudo install -Dm 644 ./systemd/hddfancontrol.service /etc/systemd/system/hddfancontrol.service
sudo install -Dm 644 ./systemd/hddfancontrol.conf /etc/conf.d/hddfancontrol
```

次に、パラメータ（ドライブ、温度範囲など）を設定するために、`/etc/conf.d/hddfancontrol` 内の `HDDFANCONTROL_DAEMON_ARGS` 変数を編集する必要があります。

その後、`sudo systemctl start hddfancontrol` でデーモンを起動し、`sudo systemctl status hddfancontrol` でその状態を確認し、`sudo systemctl enable hddfancontrol` で起動時の自動起動を有効にできます。

## ライセンス

[GPLv3](https://www.gnu.org/licenses/gpl-3.0-standalone.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-09

---