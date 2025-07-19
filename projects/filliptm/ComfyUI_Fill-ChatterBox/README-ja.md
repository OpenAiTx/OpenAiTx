<translate-content># ComfyUI_Fill-ChatterBox

このプロジェクトを楽しんでいただけたら、Patreonでのサポートを検討してください！
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Chatterboxライブラリを使用してテキスト読み上げ（TTS）と音声変換（VC）機能を追加するComfyUI用のカスタムノード拡張です。
最大40秒まで対応しています。この制限を解除しようと試みましたが、それ以上の長さではモデルが非常に不安定になるため、この制限を維持しています。

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## インストール

1. このリポジトリをComfyUIのcustom_nodesディレクトリにクローンします:</translate-content>
   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. 基本依存関係をインストールします:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. （オプション）透かしサポートをインストールします：

   ```bash
   pip install resemble-perth
   ```
**Note**: `resemble-perth`パッケージはPython 3.12以降で互換性の問題が発生する可能性があります。インポートエラーが発生しても、ノードはウォーターマークなしで機能します。

## 使用法

### テキスト読み上げノード（FL Chatterbox TTS）
- ワークフローに「FL Chatterbox TTS」ノードを追加
- テキスト入力とパラメータ（誇張、cfg_weight、温度）を設定
- 音声クローン用にオーディオプロンプトを任意で提供可能

### 音声変換ノード（FL Chatterbox VC）
- ワークフローに「FL Chatterbox VC」ノードを追加
- 入力音声とターゲット音声を接続
- 両ノードはCUDAエラー時にCPUフォールバックをサポート

## 変更履歴

### 2025/6/24
- TTSおよびVCノードに再現可能な生成用のシードパラメータを追加
- シード範囲：0〜4,294,967,295（32ビット整数）
- デバッグやワークフロー制御のために一貫した音声出力を可能に
- Python 3.12以降の互換性問題を解決するためにPerthウォーターマークをオプション化
- resemble-perthのインポート失敗時はウォーターマークなしでノードが機能

### 2025/5/31
- Persistentモデルの読み込みと読み込みバー機能を追加
- Mac対応を追加（要テストなので連絡ください）
- chatterbox-ttsライブラリを削除し、ネイティブ推論コードを実装




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---