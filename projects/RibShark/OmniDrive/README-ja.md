# OmniDrive
Copyright © 2026 Rib

## 説明
OmniDriveは、Hitachi-LG Data Storage製のMediaTek MT1959ベースの光学ディスクドライブ向けのファームウェア改造で、専用のゲームディスクを含むディスクのより良く、より完全な読み取りを可能にする機能を提供します。

## 特徴
* CD/DVD/BDおよび派生ディスクのリードイン/リードアウト読み取り。
* CD/DVD/BDおよび派生ディスクの生データセクター読み取り（CDは2352バイト/セクター、DVDは2064バイト/セクター、BDは2072バイト/セクター）。
* FUA（キャッシュをバイパス）、生のアドレッシング（CDはMSF、DVD/BDはPSN）、および復号化（DVD/BD用）のフラグを備えたカスタムREAD DISC RAWコマンドによるディスク読み取り。
* 様々な専用ゲームディスクの読み取り機能（表参照）：

| ディスクタイプ | 対応 | 備考 |
| ---: | :---: | --- |
| CD (ROM/R/RW) | ☑️ |
| DVD (ROM/RAM/±R/±RW) | ☑️ |
| BD (ROM/R/RE) | ☑️ |
| BD-XL (R/RE) | ☑️ |
| UHD-BD | ☑️ |
| PlayStation 3 BD-ROM | ☑️ | ディスク内容は暗号化されており、ディスクキーは取得不可
| PlayStation 4 BD-ROM | ☑️ | ディスク内容は暗号化されており、ディスクキーは取得不可
| PlayStation 5 BD-ROM | ☑️ | ディスク内容は暗号化されており、ディスクキーは取得不可
| Xbox (XGD1) | ✅ |
| Xbox 360 (XGD2/XGD3) | ✅ |
| Xbox One/Series (XGD4) | ✅ | ディスク内容は暗号化されており、ディスクキーは取得不可
| GameCube (NROM)/Wii (RVL-ROM) | ✅ |
| GameCube (NR)/Wii (RVT-R) | ❓ |
| Wii U (WUP-ROM?) | ⚠️ | 生データとして読み取り可能だが、スクランブルアルゴリズムは現在不明 |
| Wii U (CAT-R) | ☑️ |
| Dreamcast (GD-ROM/GD-R) | ❎ | 低密度領域のみ読み取り可能 |

キー：
* ☑️ - ネイティブサポート（パッチなしファームウェアで対応）
* ✅ - OmniDriveでサポート
* ⚠️ - 部分対応（備考参照）
* ❓ - 対応不明（テスト必要）
* ❎ - 現時点で非対応

## ビルド
### 依存関係
* CMake  
* ninja  
* arm-none-eabi-gcc ツールチェーン  
* [armips](https://github.com/Kingcom/armips)  
* Python 3  
* pycryptodome  
### インストラクション  
1. ストックのLG BU40N 1.00およびASUS BW-16D1HT 3.02のファームウェアファイルを`firmware`フォルダに入れてください。ファイル名は以下の通りで、以下のチェックサムを持っている必要があります：  

| ファイル名 | CRC32 | MD5 | SHA-1 |  
| --- | --- | --- | --- |  
| HL-DT-ST_BD-RE_BU40N_1.00.bin | `E3C1A315` | `EDB28FCD7A239281ACE26A468D382A9C` | `9C48677B155154D24A3B95A32B4A29CA02FF40B3` |  
| ASUS_BW-16D1HT_3.02.bin | `84000B21` | `97F0EEABD0B675B4363B2C4749226016` | `F8DF5B579F25DA8D4E5AA5EF79F3005DAC5EB8C7` |  
2. `build`フォルダを作成し、buildフォルダ内で`cmake -G Ninja ..`を実行してください。  
3. `ninja`を実行してください。パッチ済みファームウェアファイルは`patched_firmware`フォルダに出力されます。  

## フラッシング  
現在、ドライブのフラッシュに推奨される方法は[MakeMKV](https://makemkv.com/)に含まれる`sdftool`を使用することです。BU40Nファームウェアはすべてのスリムドライブで動作し、BW-16D1HTファームウェアはすべてのデスクトップドライブで動作します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-09

---