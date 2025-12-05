# ZigStar GW マルチツール
[![Build](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml/badge.svg)](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml)
[![GitHub version](https://img.shields.io/github/release/xyzroe/ZigStarGW-MT.svg)](https://github.com/xyzroe/ZigStarGW-MT/releases)
[![GitHub download](https://img.shields.io/github/downloads/xyzroe/ZigStarGW-MT/total.svg)](https://github.com/xyzroe/ZigStarGW-MT/latest)
[![License](https://img.shields.io/github/license/xyzroe/ZigStarGW-MT.svg)](LICENSE.txt)


> ⚠️ **アーカイブ済み / メンテナンス終了**
>
> 本プロジェクトは現在アーカイブされており、今後の更新は行われません。
> 
> 機能が向上し継続的にサポートされる新しいウェブベースのツール [XZG Multi-Tool](https://github.com/xyzroe/XZG-MT) をぜひお試しください。🚀

  
GUIラッパーは、もともとZig Star LAN GWの便利なサービス作業用に設計されましたが、  
現在はメーカーを問わず、TI CC1352/CC2538/CC2652ベースのZigbeeスティックやゲートウェイをサポートしています。

マルチツールは単一の実行ファイルにパッケージされています。  
Pythonや必要なモジュールをインストールせず、ターミナルも使わずに、ダウンロードして実行するだけで始められます。

## 機能:
- ZigbeeモジュールのNVRAMメモリの読み取り / 書き込み / 消去
- Zigbeeモジュールのファームウェアの書き込み / 検証 / 消去
- バックドアシリアルローダーが自動で起動
- ZigbeeモジュールまたはESP32の手動再起動が可能

#### スクリーンショット

<table>
<tr> 
<td width="50%">

##### Windows
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/win.png">
</td>
<td>

##### OS X
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/osx.png">
</td>
</tr>
</table>

## 使い方：
### 1. ポートの特定
#### ネットワークゲートウェイ：
ZigStar LAN GWを使用している場合、IPアドレスは自動的に検出されます。そうでない場合は、ゲートウェイのIP:PORTを入力してください。
#### USBスティック：
更新ボタンをクリックしてUSBドライブを特定し、ドロップダウンリストからデバイスを選択します。
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-1.png"></div>


### 2.A ファームウェアの更新
- ディスク上のファームウェア *.hex ファイルを選択します。
- 必要なオプションを選択します。通常は消去、書き込み、検証です。
- IEEEアドレスを変更する場合は入力し、「Write IEEE」チェックボックスをオンにします。
- 「Start」ボタンを押して選択した処理を開始します。

Multi Toolの右側で何らかの操作を行うと、プライマリIEEEアドレスが対応するフィールドに設定されます。（手動入力または以前に読み込んだものを置き換えます）

*ZigStar以外のゲートウェイやUSBスティックの場合は、手動でBSLを有効にする必要があるかもしれません。  
また、ZigStar以外のゲートウェイを使用する場合は、Auto-BSLのチェックを外してください。*
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-2.png"></div>


### 2.B NVRAMツール
Zigbeeネットワークに問題がある場合、NVRAMツールが役立つことがあります。

- **Read** ボタンは、現在のZigbeeモジュールのNVRAM状態を*.jsonファイルとしてディスクに保存し、将来の復元に備えます。
- **Write** ボタンは、保存されたNVRAM状態の*.jsonファイルをディスクから読み込み、Zigbeeモジュールに書き込みます。
- **Erase** ボタンは、ZigbeeモジュールのNVRAMをクリアして新規インストール用に初期化します。
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-3.png"></div>

### 気に入りましたか？♥️
[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/xyzroe)


### ベース情報
[zigpy/zigpy-znp](https://github.com/zigpy/zigpy-znp)  
[JelmerT/cc2538-bsl](https://github.com/JelmerT/cc2538-bsl)  

  

<br>  

xyzroe/ZigStarGW-MT is licensed under the  
##### [GNU General Public License v3.0](https://github.com/xyzroe/ZigStarGW-MT/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-05

---