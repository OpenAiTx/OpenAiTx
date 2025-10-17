# 予算重視のワイヤレスCorneキーボードの製作

約25ドルで作れるCorneレイアウトに基づくDIYワイヤレス分割キーボード。本プロジェクトはnrf52840チップ搭載のProMicroクローンを使用しており、従来のワイヤレス分割キーボード製作のコスト効果の高い代替案となっています。

## 特徴
- Bluetoothによる完全ワイヤレス
- 分割型エルゴノミックデザイン（Corneレイアウト）
- 携帯性に優れたロー・プロファイル設計
- 電源スイッチ付きバッテリー駆動
- ZMKファームウェア対応
- 推定バッテリー寿命：1ヶ月以上

## 材料リスト

| 部品 | 数量 | 価格（USD） | リンク |
|-----------|----------|------------|------|
| コントローラーボード（ProMicro nrf52840） | 2 | 6.82 | [AliExpress](https://a.aliexpress.com/_EIV3vwY) |
| バッテリー | 2 | 4.20 | [AliExpress](https://a.aliexpress.com/_Eynt9TK) |
| メカニカルスイッチ | 50 | 7.47 | [AliExpress](https://a.aliexpress.com/_EGhMxEC) |
| キーキャップ | セット | 3.79 | [Option 1](https://a.aliexpress.com/_EzQyNtA) / [Option 2](https://a.aliexpress.com/_EH8mNqs) |
| ダイオード（1N4148） | 100 | 0.85 | [AliExpress](https://a.aliexpress.com/_EwZoG2G) |
| スライドスイッチ | 2 | 0.11 | |
| 3Dプリントパーツ | セット | 1.80 | ファイル提供 |

**合計コスト**：$25.04（配線およびネジは除く）

## 現行キーマップ

![image](https://github.com/user-attachments/assets/362ff580-5528-4f7a-ad09-1fa24acbc6c7)
![image](https://github.com/user-attachments/assets/3da97ceb-8e2a-43c5-a241-cf9ad4206688)
![image](https://github.com/user-attachments/assets/e262846d-57bf-43b6-b32c-b7e37d3ebb8c)
![image](https://github.com/user-attachments/assets/2a8999cc-e58c-4d51-a142-067cb7ca768c)
![image](https://github.com/user-attachments/assets/06909fd8-bb4d-4956-88a1-f5d6a8b80e5f)

## 製作手順

### 前提条件
- 基本的なはんだ付けスキル
- 3Dプリンターの利用環境
- キーボードファームウェアの基本知識
### ケース組み立て
1. ケースファイルを印刷します（`3DFiles`ディレクトリにあるSTLファイルを使用）
2. 注意：以下の調整が必要な場合があります：
   - バッテリーコンパートメントのサイズ
   - スライドスイッチ用の穴

### 配線
1. スイッチをマトリックス構成で配線します
2. ダイオードを接続します：
   - 方向が重要です（黒い線がカソードを示します）
   - 行にはダイオードの脚を使用
   - 列には別の配線を使用
3. 配線はネジ穴から離して配線してください
4. バッテリーを接続します：
   - GNDをGNDピンに接続
   - プラスをスライドスイッチの側面脚の一つに接続
   - スライドスイッチの中央ピンをRAWピンに接続

### 行と列のピン接続
マトリックス構成はnRF52840 Pro MicroクローンのGPIOピンを使用します。以下が接続です：

![pinout](https://github.com/user-attachments/assets/ae1bf9eb-8071-4a8f-8cac-c95a39f61f9e)

#### 行と列の番号付け方法

- **行**：行は両半分とも常に上から下に番号が付けられます。
- **列**：列は常に左から右に番号が付けられます（配線がされているプレートの裏側から見た場合）。

⚠️ **注意**：誤って行または列を間違ったピンにハンダ付けしても、ハンダを外す必要はありません。マッピングはファームウェアの設定ファイルで修正可能です：
- `corne.dtsi`：両半分の行を定義します。
- `corne_left.overlay`：左半分の列を定義します。
- `corne_right.overlay`：右半分の列を定義します。

#### 左半分のピン割り当て
- **行（`row-gpios`に接続）**：
  - 行0：ピン21
  - 行1：ピン20
  - 行2：ピン19
  - 行3：ピン18

- **列（`col-gpios`に接続）**:
  - 列 0: ピン 2
  - 列 1: ピン 7
  - 列 2: ピン 6
  - 列 3: ピン 5
  - 列 4: ピン 4
  - 列 5: ピン 3

#### 右半分のピン割り当て
- **行（`row-gpios`）**:
  - 行 0: ピン 21
  - 行 1: ピン 20
  - 行 2: ピン 19
  - 行 3: ピン 18
- **列（`col-gpios`）**:
  - 列 0: ピン 3
  - 列 1: ピン 4
  - 列 2: ピン 5
  - 列 3: ピン 6
  - 列 4: ピン 7
  - 列 5: ピン 2

### ファームウェア設定
このキーボードはZMKファームウェアを使用しています。左半分がメインコントローラーとして機器に接続されます。

ファームウェアをフラッシュするには：
1. リセットボタンをダブルクリック
2. ボードがマスストレージデバイスとして表示される
3. 適切なファームウェアファイルをフラッシュする

デバイスからキーボードを忘れてしまい再接続できない場合：
1. `settings_reset-nice_nano_v2-zmk.uf2` ファイルをフラッシュ
2. 通常のファームウェアを再フラッシュ
3. ペアリング

## リポジトリ構成
```
├── .github/workflows/
│   └── build.yml
├── 3DFiles/
│   ├── STEP/
│   │   └── CorneSTEP.step
│   ├── STL/
│   │   ├── Case_Left.stl
│   │   ├── Case_Right.stl
│   │   └── PlateCorne.stl
├── config/
│   ├── boards/shields/corne/
│   │   ├── corne_left.conf
│   │   ├── corne_left.overlay
│   │   ├── corne_right.conf
│   │   ├── corne_right.overlay
│   │   ├── corne.conf
│   │   ├── corne.dtsi
│   │   ├── Kconfig.defconfig
│   │   └── Kconfig.shield
│   ├── corne.keymap
│   └── west.yml
├── firmware/
│   ├── corne_left-nice_nano_v2-zmk.uf2
│   ├── corne_right-nice_nano_v2-zmk.uf2
│   └── settings_reset-nice_nano_v2-zmk.uf2
└── zephyr/
    ├── module.yml
    └── build.yaml
```

## 既知の問題
- バッテリーが膨張すると左側のケースに歪みが生じる可能性があります
- スライドスイッチの穴は使用する部品によって調整が必要な場合があります

## 最終結果
![im1](https://github.com/user-attachments/assets/f57abe5a-585d-4f4e-b741-5c103c7af887)
![im3](https://github.com/user-attachments/assets/1ed52801-5bc1-44b9-8378-1a5e53600e92)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---