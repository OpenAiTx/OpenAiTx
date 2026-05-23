# 🖥️ PCTools

> WindowsとHome Assistantをシームレスに統合し、ハードウェア監視やリモート制御などの機能を実現するシンプルなPythonプログラム。

[![GitHub Release](https://img.shields.io/github/v/release/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools/releases/latest)
[![GitHub Downloads](https://img.shields.io/github/downloads/1812z/PCTools/total?style=flat-square&logo=github&label=Downloads)](https://github.com/1812z/PCTools/releases)
[![GitHub Stars](https://img.shields.io/github/stars/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools)
[![License](https://img.shields.io/github/license/1812z/PCTools?style=flat-square)](LICENSE)

---

## ✨ 機能特徴

| 機能 | 説明 |
|------|------|
| 📊 **Aida64 監視** | 選択したセンサーのデータを定期的に更新 |
| 🎮 **リモートコマンド** | `commands` フォルダ内の `.bat` `.lnk` ファイルを自動でHAに同期 |
| 📸 **Web監視** | スクリーンショット / カメラ / ライブ映像ストリーミング |
| 💬 **メッセージ通知** | HAのテキスト入力を監視し、Toastメッセージで表示 |
| 🌐 **サイドバーウェブ** | ショートカットキーでHAのウェブサイドバーを呼び出し |
| ⌨️ **ショートカット連動** | ショートカットキーでHAの二元センサーをトリガー |
| 📱 **フォアグラウンドアプリフィードバック** | 現在のアプリ名を自動報告、[Runtime Tracker](https://github.com/1812z/RunTime_Tracker)対応 |
| 🖥️ **ディスプレイ制御** | 複数ディスプレイの輝度 / 電源 / DDC-CIコマンド制御 |
| 🔊 **音量制御** | Windowsシステム音量を制御 |
| 🌙 **ダークモード** | システム／アプリのダークモード切替 |
| 📶 **Bluetooth制御** | システムのBluetoothオン/オフ |
| ⚡ **コマンドライン** | カスタムCMD/PowerShell実行 |
| 🎨 **Wallpaper Engine** | Wallpaper Engine制御 |
| ⌨️ **キーシミュレーション** | キーボード入力（メディアキー含む）をシミュレート |
| 🔗 **URLランチャー** | カスタムURLを開く |

**Web監視エンドポイント：**
- スクリーンショット：`http://127.0.0.1:5000/screenshot.jpg`
- カメラ：`http://127.0.0.1:5000/video_feed`
- ライブ映像：`http://127.0.0.1:5000/screen`

---

## 📷 スクリーンショット展示

<details>
<summary>🖼️ ソフトウェアインターフェース</summary>
<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/gui.png" alt="GUI" width="600"/>
</details>

<details>
<summary>📱 HA インターフェース</summary>

**別のサブディスプレイ** (推奨：[HA_Helper](https://github.com/1812z/Ha_Helper) と併用)

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/1743859715274.jpg" alt="サブディスプレイ" width="400"/>

**メインページ**

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/image.png" alt="メインページ" height="500"/>

</details>

---

## 🚀 クイックスタート

### 1️⃣ 環境のインストール

**方法1**： [Releases](https://github.com/1812z/PCTools/releases/latest) 内の圧縮ファイルをダウンロード（組み込み実行環境付き）

**方法2**：手動設定
```bash
# Python 3.12
pip install -r requirements.txt
```
### 2️⃣ インストールするサードパーティ依存ソフト（任意）

| 依存関係 | 用途 |
|------|------|
| MQTT サーバー | Home Assistant への接続 |
| [Aida64](https://github.com/1812z/PCTools/releases) | ハードウェア情報の監視 |
| [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray/releases) | モニターの輝度調整 |

### 3️⃣ 依存関係の設定

1. **Aida64**：メモリ共有を有効にし、必要なセンサーのデータにチェックを入れる
2. **Twinkle Tray**：モニター情報を正常に読み取れることを確認する
3. **壁紙エンジン**：関連操作をサポートするために起動する

> 💡 センサーの追加/変更後、競合がある場合は HA/MQTT 内のデバイスを削除し、ソフトを再起動してください

### 4️⃣ プログラムの実行

1. `打开GUI.bat` を実行してインターフェースを起動する
2. 設定に入りパラメータを構成する（**Enter キーで保存**）
3. 必要なプラグインを有効にする（**プログラムの再起動を推奨**）
4. 「起動」をクリックし、HA の MQTT 統合で新しいデバイスを確認する

### 5️⃣ 自動起動の設定（任意）

設定で **自動起動** をクリックすると、プログラムはバックグラウンドで動作し、システムトレイにアイコンが表示される

---

## 📋 開発計画

- [x] キーボードショートカット連携
- [x] コードの最適化
- [x] プラグインロジックの最適化
- [ ] パソコンファンの制御
- [ ] Toast 複数ボタンのコールバック
- [ ] プラグインマーケット
- [ ] メディアコントロール
- [ ] NetEase Cloud 歌詞同期


---

## 💡 推奨組み合わせ

| ソフトウェア | 説明 |
|------|------|
| [OpenRGB](https://openrgb.org/) | RGBライティング制御、HA接続対応 |
| [HASS.Agent](https://github.com/hass-agent/HASS.Agent) | より安定した同種ツール |

---

## 感謝

- [python_aida64](https://github.com/gwy15/python_aida64) - Aida64データ読み取り

---

## 📝 その他

- ヘッドレスモード対応：`python core.py`
- 一部のページは切り替え後に更新されます


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---