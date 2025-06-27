# AprilTag独立検出ライブラリ

これはpupil-apriltagsライブラリに基づくAprilTag認識ツールキットで、カメラ映像中のAprilTagの検出と追跡を行います。

<!-- Keep these links. Translations will automatically update with the README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## 依存ライブラリ

- Python 3.6以降
- OpenCV
- NumPy
- pupil-apriltags

## インストール

1. Python環境がインストールされていることを確認
2. 必要な依存関係をインストール：

```bash
pip install opencv-python numpy pupil-apriltags
```

## 使い方

### 基本的な使い方

```python
import cv2
from apriltag import Detector, DetectorOptions

# 検出器を作成
options = DetectorOptions(
    families="tag36h11",  # タグファミリー
    border=1,             # タグのボーダーサイズ
    nthreads=4,           # スレッド数
    quad_decimate=1.0,    # 画像ダウンサンプリング係数
    quad_blur=0.0,        # ガウスぼかし係数
    refine_edges=True     # エッジの精緻化
)
detector = Detector(options)

# 画像を読み込み
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# AprilTagを検出
detections = detector.detect(gray)

# 検出結果を表示
for detection in detections:
    print(f"タグファミリー: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"位置: {detection.center}")
    print(f"コーナー: {detection.corners}")
```

### 検出結果の描画

```python
import numpy as np
from apriltag import draw_detection_results

# カメラ内部パラメータ行列と歪み係数
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# 検出結果を描画
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# 結果を表示
cv2.imshow("AprilTag検出", result_img)
cv2.waitKey(0)
```

### テストスクリプトの実行

シンプルなテストスクリプトが用意されており、AprilTag検出機能の検証に利用できます：

```bash
python test_apriltag.py
```

これにより、パソコンのデフォルトカメラが起動し、AprilTagのリアルタイム検出を行います。"q"キーで終了します。

## 対応タグファミリー

pupil-apriltagsライブラリは以下のタグファミリーに対応しています：
- tag36h11（デフォルト）
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## 注意事項

- より良い性能を得るため、DetectorOptionsのパラメータを調整してください
- 計算リソースが限られているデバイスでは、quad_decimateパラメータを増やして計算負荷を下げることができます
- 使用するAprilTagマーカーのサイズが、コード内のtag_sizeパラメータと一致していることを確認してください
- 3D座標軸を描画する場合は、正確なカメラパラメータが必要です

## 機能特徴

- USBカメラによるリアルタイムAprilTag検出対応
- タグの3D姿勢（位置と向き）の計算・表示
- 元画像とマーク済み画像の保存に対応
- 設定やカメラパラメータのカスタマイズが可能
- 完全なカメラキャリブレーションツールを同梱
- ROS非依存、元のROSパッケージを純粋なPythonで独立実装

## インストール手順

### 1. AprilTag Cライブラリのインストール

AprilTagのCライブラリが必要です。以下の手順に従ってインストールしてください：

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windowsユーザーは自分でビルドするか、プリビルド済みのバイナリをダウンロードし、`apriltag.dll`がシステムのPATHまたはカレントディレクトリに存在することを確認してください。

### 2. Python依存パッケージのインストール

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## 使用ガイド

### クイックスタート（推奨）

最も簡単な使い方は、統合ツールを実行することです。対話的なメニューで全てのステップを案内します：

```bash
python apriltag_tool.py
```

このツールはメニューオプションを提供します：
1. チェスボードキャリブレーションパターンの生成
2. カメラキャリブレーション
3. AprilTag検出
4. ヘルプドキュメントの閲覧

メニューの案内に従って操作するだけで、一連のフローを完了できます。

### カメラキャリブレーション

AprilTag検出を行う前に、正確なカメラパラメータを取得するためキャリブレーションを行うことを推奨します：

```bash
# まずチェスボードキャリブレーションパターンを生成
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# チェスボードを印刷し、実際のマスサイズを測定してからキャリブレーションを実行
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

パラメータ説明:

**チェスボード生成ツール (create_chessboard.py):**
- `--size`: チェスボードの内部コーナー数、幅x高さ（デフォルト: 9x6）
- `--square`: マスのサイズ（ピクセル、デフォルト: 100）
- `--output`: 出力ファイルパス（デフォルト: chessboard.png）
- `--dpi`: 出力画像のDPI（デフォルト: 300）、印刷サイズに影響

**カメラキャリブレーションプログラム (camera_calibration.py):**
- `--size`: チェスボードの内部コーナー数、幅x高さ（デフォルト: 9x6）
- `--square`: チェスボードマスのサイズ（単位: m、デフォルト: 0.025）
- `--output`: 出力ファイルパス（デフォルト: config/camera/HSK_200W53_1080P.yaml）
- `--camera`: カメラデバイスID（デフォルト: 0）
- `--width`: カメラキャプチャ幅（デフォルト: 1280）
- `--height`: カメラキャプチャ高さ（デフォルト: 720）
- `--samples`: キャリブレーションに必要なサンプル数（デフォルト: 20）
- `--preview`: キャリブレーション完了後に補正結果をプレビュー

キャリブレーション手順：
1. チェスボードキャリブレーションパターンを生成・印刷
2. 実際のマスのサイズを測定（単位：メートル）
3. キャリブレーションプログラムを実行し、チェスボードをカメラの前で色々な角度から撮影してサンプルを取得
4. プログラムが自動でチェスボードを検出してサンプルを収集、または's'キーで手動保存も可能
5. 十分なサンプルが集まると、プログラムが自動でカメラパラメータを計算し、指定ファイルに保存

### AprilTag検出

キャリブレーション完了後、AprilTag検出プログラムを実行できます：
```bash
python apriltag_detector.py
```

### 高度な使い方

```bash
python apriltag_detector.py [設定ファイルパス] --camera カメラID --width 幅 --height 高さ --camera_info カメラパラメータファイル
```

パラメータ説明:
- `設定ファイルパス`: AprilTag設定ファイルのパス（デフォルト: `config/vision/tags_36h11_all.json`）
- `--camera`: カメラデバイスID（デフォルト: 0）
- `--camera_info`: カメラ内部パラメータファイルのパス（デフォルト: `config/camera/HSK_200W53_1080P.yaml`）
- `--width`: カメラキャプチャ幅（デフォルト: 1280）
- `--height`: カメラキャプチャ高さ（デフォルト: 720）

### キー操作

- `q`: プログラム終了

## 設定ファイルの説明

システムのすべての設定は `config/vision/table_setup.json` ファイルで行えます：

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // タグファミリー
        "size": 0.05,              // タグ物理サイズ（単位：メートル）
        "threads": 2,              // 処理スレッド数
        "max_hamming": 0,          // 最大ハミング距離
        "z_up": true,              // Z軸が上向き
        "decimate": 1.0,           // 画像ダウンサンプリング係数
        "blur": 0.8,               // ブラー係数
        "refine_edges": 1,         // エッジ精細化の有無
        "debug": 0                 // デバッグ有無
    },

    "Camera": {
        "device_id": 0,            // カメラデバイスID
        "width": 1280,             // カメラ幅解像度
        "height": 720,             // カメラ高さ解像度
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // カメラキャリブレーションパラメータファイル
    },

    "Archive": {
        "enable": true,            // データアーカイブ有効化
        "preview": true,           // プレビューウィンドウ表示
        "save_raw": false,         // 生画像保存有無
        "save_pred": false,        // 予測画像保存有無
        "path": "./data/table_tracking"  // データ保存パス
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 参照タグIDリスト
        "moving_tags": [4, 5, 6],            // 移動タグIDリスト
        "require_initialization": true,       // 初期化必要有無
        "tag_positions": {                    // プリセットタグ位置（存在する場合）
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

設定ファイルを編集することで、以下が可能です：
1. AprilTag検出器パラメータの設定
2. カメラパラメータの設定（デバイスID、解像度、パラメータファイル）
3. データアーカイブオプションの設定
4. 参照タグおよび移動タグIDのカスタマイズ
5. 初期化の有無（`require_initialization` を `false` に設定すると初期化をスキップ可能）
6. タグのプリセット位置情報の設定

### 使用方法

非常に簡単で、下記のコマンド一つでシステムを起動できます：

```
python table_tracking.py
```

カスタム設定ファイルを利用する場合：

```
python table_tracking.py --config カスタム設定ファイルパス
```

システム動作中に 'i' キーを押すことで、いつでも手動で初期化を実行できます。

## よくある質問

1. **apriltagライブラリが見つからない**
   
   apriltagライブラリが正しくインストールされており、システムでライブラリファイルが見つけられることを確認してください。

2. **カメラが起動できない**
   
   カメラデバイスIDが正しいか、また他のプログラムでカメラが使用されていないか確認してください。

3. **検出結果が正確でない**
   
   カメラが正しくキャリブレーションされているか、設定ファイルのタグサイズが正しいかを確認してください。

## ファイル構成

```
apriltag_standalone/
├── apriltag.py              # AprilTag検出ライブラリのコアコード
├── apriltag_detector.py     # AprilTag検出メインプログラム
├── apriltag_tool.py         # 統合ツール起動メニュー
├── camera_calibration.py    # カメラキャリブレーションプログラム
├── create_chessboard.py     # チェスボード生成ツール
├── configs.py               # 設定ファイル処理
├── config/                  # 設定ディレクトリ
│   ├── camera/              # カメラ設定
│   │   └── HSK_200W53_1080P.yaml  # カメラパラメータ
│   └── vision/              # ビジョン設定
│       └── tags_36h11_all.json # AprilTag設定
├── README.md                # 説明ドキュメント
└── requirements.txt         # Python依存パッケージ
```

## 技術的な説明

本プロジェクトはROS AprilTag検出パッケージから移植されたスタンドアロン版であり、ROS依存を排除し、コア機能のみを保持しています。
主に以下の技術を使用しています：

- OpenCV: 画像処理、カメラキャリブレーション、姿勢推定
- AprilTag Cライブラリ: タグ検出
- SciPy: 回転行列およびクォータニオン変換

## ライセンス

本プロジェクトはMITライセンスに基づきます

## 新機能の説明

### 複数タグトラッキングと遮蔽処理

本システムは以下の新機能をサポートしています：

1. **撮影による初期化**：システム起動時に自動で一度撮影初期化を行い、タグ間の位置関係を記録します。内容は以下の通りです：
   - 固定参照タグ（ID 0-3）の位置
   - 複数移動タグ（デフォルトID 4,5,6）間の相対位置関係

2. **遮蔽処理**：初期化後、一部のタグが遮蔽されていても、
   - 参照タグが遮蔽された場合、他の可視参照タグを利用して遮蔽タグの位置を推定可能
   - 移動タグが遮蔽された場合、他の可視移動タグを用いて遮蔽移動タグの位置を推定可能

3. **複数タグトラッキング**：複数の移動タグを同時にトラッキング可能（デフォルトID 4,5,6）
   - 移動タグ間の相対位置が固定であれば、一つでも可視であれば他のタグ位置も推定可能
   - 設定ファイルで移動タグIDをカスタマイズ可能

### 設定ファイルの説明

システムのすべての設定は `config/vision/table_setup.json` ファイルで行えます：

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 参照タグIDリスト
        "moving_tags": [4, 5, 6],            // 移動タグIDリスト
        "require_initialization": true,       // 初期化必要有無
        "tag_positions": {                    // プリセットタグ位置（存在する場合）
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

設定ファイルを編集することで、以下が可能です：
1. 参照タグおよび移動タグIDのカスタマイズ
2. 初期化の有無（`require_initialization` を `false` に設定すると初期化をスキップ可能）
3. タグのプリセット位置情報の設定

### 使用方法

1. デフォルト設定でシステムを起動する場合：
   ```
   python table_tracking.py
   ```

2. カスタム設定ファイルでシステムを起動する場合：
   ```
   python table_tracking.py --config カスタム設定ファイルパス
   ```

3. 手動初期化：システム動作中に 'i' キーを押す

### 実行要件

初期化時、すべてのタグがカメラに映るようにしてください。システムはタグ間の相対位置関係を記録します。初期化後は一部タグが遮蔽されても、すべてのタグ位置を正確に推定できます。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---