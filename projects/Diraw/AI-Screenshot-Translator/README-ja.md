# AI スクリーンショット翻訳ツール (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# 概要

本ツールは**簡単なスクリーンショット操作**で画像をAIモデルに送信し、テキスト認識および翻訳を行い、翻訳結果をインタラクティブなHTML形式で独立ウィンドウに表示します。

本ツールは**カスタムショートカットキーでの起動、複数ウィンドウでの結果管理、システムトレイでの常駐**をサポートしており、日常の業務や学習における翻訳効率を大幅に向上させます。

**ツールの特徴**：1、スクリーンショット翻訳、ショートカットキー起動；2、ピン留め可能なスクリーンショットと翻訳、自由にドラッグ＆ズーム、多数の翻訳ピンを作成可能；3、数式はオリジナルテキストへの切り替えができ、コピーに便利；4、カスタムAPIインターフェース

**解決したい課題**：1、現状主流のドキュメント全体翻訳の肥大化；2、PDFのテキストをコピー＆ペーストで翻訳する場合、数式ブロックが崩れたりコピーできないことがある；3、画像スキャンPDFではテキストコピーができない

# デモ

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# ウィンドウ表示

翻訳ウィンドウ：

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

設定ウィンドウ：

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

設定オプションの詳細な説明は、ソフトウェア内部またはウェブページで[ヒント](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)をご覧ください。

# インストール

ソースコードをダウンロードして実行するか、[Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases)ページから実行ファイルをダウンロードできます。

### 1. リポジトリをクローン

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. 仮想環境を作成し実行

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# アップデート計画

- ~~API設定用GUIウィンドウの追加、手動でのyamlファイル設定ロジックをソフトウェア自動生成に最適化（v0.3.0で完了）~~
- 画像・数式保存システムの追加、後からの呼び出しに便利（v0.4で実装予定）
- （他の機能についてはIssueまたはPRでご提案・ご協力ください）

# その他

- ソフトウェアアイコンは [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free) より
- Gemini 2.5 Flash と DeepSeek-V3-0324 にバグ発見の協力を感謝

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---