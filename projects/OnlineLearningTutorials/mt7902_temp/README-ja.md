# 🎯 MT7902ドライバーはMT7921ドライバーのサブパートとして（✅ 動作確認済み）
Mediatek mt7902 wifi 6Eチップ BluetoothおよびWiFiサポート

> [!重要]
> Linux 7.1カーネルは公式にMT7902 WIFI 6Eチップをサポートしています


## 📁 リポジトリのクローン
リポジトリをローカルPCにクローンしてください
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
過去の履歴をクローンしたくない場合は
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## インストール


### 🚀 インストールガイドスクリプト（Ubuntuベースのシステム推奨）
スクリプトがまだ実行可能でない場合は、実行可能にします
```
chmod +x ./install_guide.sh
```
このスクリプトを実行してください
```
./install_guide.sh
```
必要に応じて自動的にパスワードを求められます  
* このスクリプトはファームウェア、Bluetooth、WiFiドライバーのインストールを順番に案内します  
* Ubuntuのlinux 7.0カーネルでテスト済み  

### 🚀 簡単自動修正（Archベースのシステムに推奨）  
最新のカーネルでWiFiとBluetoothを素早く修正したい場合は、以下の手順に従ってください。  

スクリプトをまだ実行可能にしていない場合は実行可能にする  
```
chmod +x ./fix_my_wifi.sh
```

**sudoを付けて自動修正スクリプトを実行する**:
```bash
sudo bash fix_my_wifi.sh
```
#### 📖 このスクリプトの機能:
* **依存関係のチェック:** `gcc`/`clang`、`make`、`bc`、および現在の`kernel-headers`がインストールされていることを確認します。未インストールの場合は、お好みのパッケージマネージャでインストールします。
* **ドライバーのコンパイル:** 正確なカーネルバージョンに対応したWiFiとBluetoothの両ドライバーを自動でビルドします。
* **永続的な修正:** コンピュータを再起動してもWiFiが有効なままであることを保証するシステムサービスをインストールします。
* **安全性:** モジュールはカスタムディレクトリ（`/lib/modules/mt7902_custom`）にインストールされ、既定のシステムファイルを汚染しません。

> [!注意]
> 初回実行時には必要なビルドツール（コンパイラ、linux-headersなど）をダウンロードするためにインターネット接続（Ethernetまたは電話からのUSBテザリング）が必要です。


## ✅ 動作確認済み環境
この修正は以下の環境で動作確認および検証済みです：

* **ブランド:** ASUS
* **モデル:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **チップセット:** MediaTek MT7902 (WiFi 6E)
* **カーネルバージョン:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **OS:** Arch, Ubuntu
* **パッケージマネージャ:** pacman, apt

## 対応環境:
* **OS**: いずれかのPMをサポートする任意のOS
* **推奨パッケージマネージャ:** apt, pacman, dnf, zypper, nix-shell
* **カーネルバージョン:** 6.14-7.0.7


## 🔧 使用ファームウェア
ファームウェアは`firmware`フォルダに保存されています。


## 📱 Bluetooth ✅ (動作確認済み)
> [!警告]
> bluetoothドライバーが`gen4-mt7902`と競合する場合は、干渉しないようにBluetoothファームウェアを削除してください
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> このプロジェクトで使用するファームウェアは
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Bluetoothを有効にするには、現在のカーネルバージョンのディレクトリへ移動してください。
例えば、カーネルがlinux-6.16の場合は、`./linux-6.16/drivers/bluetooth`ディレクトリに移動します。

このディレクトリでターミナルを開き、コマンド `make` でコンパイルします。  
2つのカーネルモジュール `btusb.ko` と `btmtk.ko` がコンパイルされます。  
デバイスでBluetoothを有効にするには、システムからbtusbとbtmtkを削除し、これら2つのファイルをインストールしてください。コマンドは以下の通りです。
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
今、Bluetoothが動作しているか確認してください。

## 💻 WiFi ✅（動作中）
> [!IMPORTANT]
> 制限付きで動作するリポジトリは[こちら](https://github.com/hmtheboy154/gen4-mt7902)です。

mediatekが最近リリースしたmt7902用のWiFiドライバは`latest`フォルダ内にあります。

Ubuntuを使用している場合は、`latest`フォルダに移動し、ターミナルで以下のコマンドを実行してください。
```
make
```
すべてのモジュールをコンパイルし、圧縮してインストールします（元のカーネルモジュールを変更されたモジュールに置き換えます）。他のディストリビューションを使用している場合や、すべての手順を実行せずにコードのコンパイルだけを行いたい場合は、ターミナルで次のコマンドを実行してください。

```
make module_compile
```
コンパイルしたモジュールを圧縮するには、ターミナルで次のコマンドを実行します
```
make module_compress
```
圧縮されたモジュールをシステムのカーネルモジュールにインストールするには、端末で以下を実行してください
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---