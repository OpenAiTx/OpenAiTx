<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

このプロジェクトを気に入っていただけた場合は、Patreonでのご支援をご検討ください！
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Chatterboxライブラリを使用して、テキスト読み上げ（TTS）およびボイスコンバージョン（VC）機能を追加するComfyUI用のカスタムノード拡張です。
最大40秒までサポートしています。この制限を解除しようとしましたが、それ以上はモデルが大きく崩れてしまうため、この制限を維持しています。

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## インストール方法

1. このリポジトリをComfyUIのcustom_nodesディレクトリにクローンします：

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---