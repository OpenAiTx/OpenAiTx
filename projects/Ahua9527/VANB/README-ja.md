# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB は GStreamer をベースにしたビデオ／オーディオストリーム変換ツールであり、NDI と RTMP プロトコル間の双方向変換をサポートします。NDI ソースを RTMP サーバーへ配信したり、RTMP ストリームを NDI 出力へ変換することができます。

本プロジェクトは [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) ライセンスでオープンソースとして公開されています。

## 対応プラットフォーム

現在、主に以下のプラットフォームをサポートしています：
- macOS (Apple Silicon)

## 動作環境

### システム依存
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### インストール手順
1. [NewTek NDI SDK](https://www.ndi.tv/sdk/) をインストール

2. Homebrew で GStreamer をインストール
```bash
brew install --cask --zap gstreamer-development
```

3. プロジェクトリポジトリをクローン
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Python 依存パッケージをインストール
```bash
pip install -r requirements.txt
```

5. 環境変数を設定（.env ファイルを参考にしてください）
```bash
# NDI SDK パスを設定
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# GStreamer プラグインパスを設定
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## 使い方

### NDI から RTMP へ（送信側）
```bash
python vanb_tx.py
```
プログラムが利用可能な NDI ソースを自動的にスキャンし、RTMP 配信アドレスの入力を促します。

### RTMP から NDI へ（受信側）
```bash
python vanb_rx.py
```
RTMP プルストリームアドレスを入力すると、プログラムが自動的に新しい NDI 出力を作成します。

## 開発状況

### 実装済み機能
- ✓ NDI から RTMP への変換
- ✓ RTMP から NDI への変換
- ✓ フレームレートと解像度の自動適応
- ✓ オーディオ・ビデオ同期
- ✓ NDI ソースの自動スキャン
- ✓ NDI 出力の自動命名
- ✓ VideoToolbox ハードウェアエンコード／デコード

### 今後実装予定の機能
- ⨯ 設定ファイルサポート (Profile/config.json)
  - 設定ファイルで入出力パラメータの制御
  - 複数のトランスコードプリセット設定のサポート
  - バッファサイズや遅延パラメータの設定
  - トランスコード品質とパフォーマンスのバランス設定
- ⨯ 複数ストリームの同時処理

## ライセンス声明

⚠️ **重要：ライセンスとコンプライアンスについて**

### ソフトウェアライセンス

本プロジェクトは [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html) でライセンスされています。

GPL-3.0 ライセンスを選択した理由：
1. 本プロジェクトは複数の GPL ライセンス GStreamer プラグインを使用しています：
   - `x264`: H.264 ビデオエンコーダー (GPL)
   - `x265`: HEVC/H.265 ビデオエンコーダー (GPL)
   - `faad`: AAC オーディオデコーダー (GPL)
2. GPL の伝播条項により、GPL コンポーネントを使用するソフトウェアも GPL ライセンスを採用する必要があります
3. GPL-3.0 を選択することで、すべての依存コンポーネントのライセンスと互換性を確保できます

### ライセンス要件

本プロジェクトを利用する際は、以下の要件を遵守してください：
1. **ソースコード公開**：本プロジェクトのコードを修正した場合や他プロジェクトに統合した場合、完全なソースコードを公開する必要があります
2. **ライセンス維持**：ご自身のプロジェクトも GPL-3.0 ライセンスを継続して使用する必要があります
3. **著作権表示**：元の著作権表示およびライセンス表示を保持してください
4. **変更の明示**：コードを修正した場合、修正内容を明確に表示してください
5. **特許許諾**：GPL-3.0 には明確な特許許諾条項が含まれています

### GStreamer コンポーネントライセンス
1. 本プロジェクトは開発およびテスト用途に限ってご利用ください
2. NDI® は NewTek, Inc. の登録商標です
3. 本プロジェクトの利用には NewTek NDI® SDK ライセンス契約の遵守が必要です
4. 本番環境でご利用の際は、すべての必要なライセンスおよび許可を取得してください

## 問題報告

問題が発生した場合は、以下をご確認ください：
1. 環境変数が正しく設定されているか
2. GStreamer プラグインが正しくインストールされているか
3. ログファイルで詳細なエラー情報を確認する
4. Issues から問題を報告し、ログと環境情報を添付してください

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---