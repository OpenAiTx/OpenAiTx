# Home Assistantを介したESPHome PC電源制御

このプロジェクトは、HomeAssistantとESPHome ESP8266/ESP32ボードを使用したリモートPC電源制御を含みます。

私はこのプロジェクトを使用して、Wake-On-Lan（WOL）の既知の制限の代替として、Home Assistantを介してPCベースのNASの電源をリモートでオンオフしています。

## 特徴

* マザーボードに接続された物理的なPC電源ボタン（フロントパネル）を制御：
  * `電源オフ/サスペンド/ハイバネート`などの任意の電源状態からPCの電源をオンにする（短押し電源ボタンの動作）。
  * オペレーティングシステムの正常な`シャットダウン/サスペンド/ハイバネート`（短押し電源ボタンの動作）。
  * 強制的な電源オフ（長押し電源ボタンの動作）。
* マザーボードからPCの電源オン/オフ状態を読み取る。
* オペレーティングシステムに依存しない。
* フロントパネルの電源/リセットボタンは完全に機能したまま。
* Homeassistantによるユーザー認証。
* どの(micro/mini)-ATXコンピュータマザーボードでも使用可能。

Youtube動画：

[![Youtube video](https://img.youtube.com/vi/rAcvqaPf830/0.jpg)](https://www.youtube.com/watch?v=rAcvqaPf830)

Homeassistantのスクリーンショット：

![Screenshot Home Assistant](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ScreenshotHomeAssistant.jpg)

## Wake-On-Lan（WOL）マジックパケットとの違い

[Wake-On-Lan（WOL）](https://en.wikipedia.org/wiki/Wake-on-LAN)は、いわゆる`マジックパケット`を送信することによりイーサネット経由でコンピュータの電源をリモートでオンにすることを目的としています。これはいくつかの既知の制限があり、本ESPプロジェクトでは該当しません：

* Wake-On-Lan（WOL）には**認証がない**！WOLプロトコルにはパスワードを提供したり特定のコンピュータからのウェイクを許可する機能がありません。同じLAN上の任意のデバイスがマジックパケットを送信してPCをウェイクできます。ESPはHomeassistantを介してパスワード保護されています。
* Wake-On-Lan（WOL）はPCをサスペンドまたは電源オフ状態から`ウェイク`するのみで、シャットダウン/サスペンド機能はありません。
* Linuxマシンを`スリープ`状態にするには、例えば`pm-suspend`コマンドを実行してリモートPCにSSH接続できます（`sudo apt install pm-utils`でインストール）、参照：[Ubuntu pm-action ドキュメント](https://manpages.ubuntu.com/manpages/jammy/man8/pm-action.8.html)。欠点：
  * SSHログインが必要。
  * sudo権限が必要。
* マジックパケットは、WOLがBIOSで有効でも、電源供給装置に初めて主電源を接続した際には無視されます。理由は、多くのコンピュータで初回電源オン時にWOLが無効化されており、PCがマジックパケットに反応してウェイクするには動作中のOSによる有効化が必要だからです。参照：[Ubuntu Wake-On-Lan](https://help.ubuntu.com/community/WakeOnLan)。
* Homeassistant上でDockerコンテナで動作する[Wake-On-Lan](https://www.home-assistant.io/integrations/wake_on_lan)は、ブリッジネットワーク構成でブロードキャストマジックパケットを転送できません。マジックパケットを転送するためには外部Dockerコンテナをブリッジとして使用する必要があり、これはHomeassistantの範囲外です。これは現在Homeassistantのドキュメントには含まれていません。

## ハードウェア

ハードウェアはESP8266またはESP32と2つのIOピンで構成されており、PCIメタルプレートに取り付けられています（下記画像参照）。私の場合はESP8266 NodeMCUボードを使用しました。理論的には、任意のESP8266またはESP32ボードをこのプロジェクトに使用できます。

* 1つのピンは長押しまたは短押しを生成して電源ボタンを制御します
* 2つ目のピンはマザーボードの電源状態を読み取ります。

![Hardware](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/NodeMCU.jpg)

## 回路図

私のNASはIntel Core I7 ASRock Z97 ATXマザーボードをベースにしており、標準の2.5mm 2x5オスヘッダーを備えています：

![Schematic](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Schematic.png)

**ATXヘッダー USB 2.0:**

ヘッダー`J1`のピン1は、PCの電源がオフのときでも常に+5V電源が供給されており、NodeMCUへの電源供給に使用されます。ESP8266またはESP32は基板上の3V3レギュレーター経由で電源供給されます。

**ATXヘッダー システムパネル:**

ヘッダー`J2`は電源、リセット、GNDピンを含みます：

* 電源ボタン ピン6。
  * 短押し：PCをオンにするか、正常シャットダウンを生成。
  * 長押し：強制的な電源オフを生成。
* リセットボタン ピン7。
  * リセットボタンピンを通じて電源状態を読み取るために使用：
    * High：電源オン
    * Low：電源オフ
* GND ピン5。

* ピン`D1`はリセットピンから電源状態を読み取るために使用されます：Highがオン、Lowがオフ。抵抗`R1`はIOピンが誤って出力に設定された場合の電流を最小限に抑えるために使用されます。
* ピン`D2`は短押しまたは長押しを生成するために電源ボタンをLowに引き下げるために使用されます。トランジスタ`Q1`はESP8266とマザーボード間の安全な絶縁のために使用されます。

警告：すべてのATXおよびESPピンは3V3で動作している必要があります。

## ダウンロード

* [KiCad回路図 .SCH](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/kicad/ESP8266-ESPHome-PC-Power-HomeAssistant.pro)

## 配線
![Wiring](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Wiring.jpg)

DIYブレイクアウトPCBは、システムパネルヘッダーに取り付けて電源ボタン`SW1`とリセットボタン`SW2`を接続できます。

## WiFiの安定性

ATXコンピューターケース内にはESPボードを取り付ける十分なスペースがあります。しかし、コンピューターケースは金属シールドされているため、WiFiの基地局までの距離が短くなります。WiFi接続が不安定、または距離が短すぎる場合は、ESPをコンピューターケースの外に配置することを推奨します。ESP32は異なるWiFi接続の安定性をもたらす場合がありますが、全体的には環境に依存します。

PCケースの背面に取り付けられたESP8266 PCB：

![ESP PC mount](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ESPMount.jpg)

## ソフトウェア更新

ESPHomeアプリケーションのファームウェアはUSB接続（仮想シリアルポート）またはWiFi OTA（Over The Airアップデート）で更新できます。

WiFi経由でのファームウェア更新は、.yamlファイルで`ota`を設定すると有効になります。これはホストコンピューターとESP間のWiFi接続が必要です。WiFiの認証情報が間違っているためESPからWiFi基地局へのログインに失敗するとOTA更新は動作しません。この場合はシリアル経由での更新か、.yamlファイルで設定された`ap`フォールバック経由での更新が必要です。

## ESPHome

ESPHomeアプリケーションは2つのYamlファイルで構成されます。1つは設定ファイル、もう1つはパスワードを保存する`secrets.yaml`です。

ドキュメント：

* [ESPHome GPIOスイッチ](https://esphome.io/components/switch/gpio.html)
* [ESPHome バイナリーセンサー](https://esphome.io/components/binary_sensor/gpio.html)

### プロジェクト設定

以下のファイルを設定してください：
- [pc-power.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/pc-power.yaml)：`platform` と `board` を設定。
- [secrets.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/secrets.yaml)：WiFiのSSIDとパスワードを設定。

詳細は[ESPHomeドキュメント](https://esphome.io/components/esphome.html)を参照してください。

### ESP8266またはESP32のプログラム

USBケーブルをESP8266またはESP32ボードに接続し、以下のコマンドを実行します。（例はUbuntuでテスト済み）。詳細は[ESPHome.io](https://esphome.io/guides/getting_started_command_line.html)を参照してください。



```bash
# Clone this repository
$ git clone git@github.com:Erriez/ESPHomePCPowerControlHomeAssistant.git

# Install Python3 virtualenv
$ sudo apt install python3-virtualenv

# Create virtualenv
$ virtualenv venv

# Activate virtualenv
$ source venv/bin/activate

# Install ESPHome
$ pip install esphome

# Optional: Install platformio updates
$ platformio platform update
$ platformio upgrade

# Optional: Add user permission serial port
$ sudo usermod -a -G dialout <USERNAME>
$ sudo reboot now

# Check ESPHome installation
$ esphome --help

# Optional: Compile program without upload
$ esphome compile pc-power.yaml

# Upload program to ESP8266 or ESP32
$ esphome run pc-power.yaml

# Select serial port or WiFi to upload application

# Check logs
$ esphome logs pc-power.yaml
```
## Home Assistantの設定

このセクションではHome Assistantの設定について説明します。

### ESPデバイスの登録

* `Configuration | Integrations: Add Integration: ESPHome`
* ESPデバイスのホスト名またはIPアドレスを選択します。
* `secrets.yml` | `esphome_api_password`に設定したパスワードを入力します。

### Homeassistant | ダッシュボード編集 | RAW Configuration Editor

RAW編集を使ってダッシュボードにPC電源の統合を追加します：


```yaml
title: Home
views:
  - title: PC
    path: pc
    badges: []
    cards:
      - type: button
        entity: switch.pc_power_toggle
        show_name: true
      - type: button
        tap_action:
          action: none
        entity: binary_sensor.pc_power_state
        hold_action:
          action: none
      - type: button
        tap_action:
          action: toggle
        entity: switch.pc_hard_power_off
        icon_height: 40px
        show_state: false
        show_name: true
        show_icon: true
```

## バージョン履歴

Home Assistant を再起動して準備完了！

### 2024年10月11日更新

ESPHome の YAML ファイル形式が [ESPHome バージョン 2024.6.0](https://esphome.io/changelog/2024.6.0.html#) で変更されました。古い形式は以下のようなエラーを生成します：

```
$ esphome compile ESPHomePCPowerControlHomeAssistant/pc-power.yaml
INFO ESPHome 2024.9.2
INFO Reading configuration ESPHomePCPowerControlHomeAssistant/pc-power.yaml...
Failed config

ota.unknown: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:27]

  'ota' requires a 'platform' key but it was not specified.

and:

Failed config

switch.gpio: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:30]

  Pin 4 is used in multiple places.
```
この場合は、このプロジェクトで新しいファイル形式に更新してください。

### 2022年2月13日の更新

* Homeassistantスクリプトで制御されていたボタンピンのタイミングが安定していませんでした。電源ピンの制御は、はるかに正確なタイミングを生成するESPファームウェアに移動されました。
* 以下の名前が変更されました：
  * `switch.pc_power_button` を `switch.pc_power_toggle` に名前変更しました。
  * `switch.pc_power_button_long_press` を `switch.pc_hard_power_off` に名前変更しました。
  * `switch.pc_power_sense` を `switch.pc_power_state` に名前変更しました。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---