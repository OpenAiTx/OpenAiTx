<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>
# AI小説エディタ

PyQt6ベースのAI支援小説編集ツールで、インテリジェントな補完、プロジェクト管理、コンセプト整理などのプロフェッショナルな執筆ツールを提供します。

## インストール

1. プロジェクトをクローン
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. 仮想環境の作成
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
uvを使用
```bash
uv venv -p 3.11
```
3. 依存関係のインストール
```bash
pip install -r requirements.txt
```
uvの使用
```bash
uv sync
```

4. プログラムの実行
```bash
python -m src
```

## 主な機能

### プロジェクト管理
- 階層型ドキュメント構造（作品 > 章 > シーン）
- プロジェクトのインポート・エクスポート（TEXT、MARKDOWN、DOCX、PDF、HTML形式対応）
- 自動バックアップとバージョン管理
- 複数プロジェクトの管理
### AI補完機能
- 3つの補完モード：自動補完、手動補完（推奨 Tabキー1回でトリガー、もう1回で補完適用）、補完無効
- 3つのコンテキストモード：
  - 高速モード：軽量コンテキスト、迅速な応答
  - バランスモード：中程度のコンテキスト、品質と速度のバランス
  - グローバルモード：プロジェクト全体のコンテキスト、最良の効果
- 複数のAIサービスに対応：OpenAI、Claude、Tongyi Qianwen、Zhipu AI、DeepSeek、Groqなど

### アウトライン管理
- ビジュアルなアウトラインツリー構造
- ドラッグ＆ドロップで並び替えと階層調整
- ドキュメントの高速ナビゲーション
- アウトライン分析と最適化提案

### API設定
- 統一されたAI設定センター
- 複数プロバイダーのプリセット構成
- 接続テスト機能
- 設定プランの保存・インポート・エクスポート
### インテリジェント補完設定
- 調整可能なトリガー遅延
- 補完長さの制限
- コンテキスト長の設定
- ストリーミング応答のサポート

### プロンプト編集
- 複数の内蔵ライティングテンプレート
- カスタムプロンプトテンプレート
- テンプレートのカテゴリ管理
- モード別テンプレート設定

### インターフェース機能
- ライト／ダーク両テーマ
- 3カラムレイアウト（プロジェクトツリー、エディタ、コンセプトパネル）
- 折りたたみ可能なサイドバー
- フルスクリーン執筆モード
- 集中モード（文、段落、タイプライター、禅モード、没入モード）

### 検索と置換
- プロジェクト全体テキスト検索
- 正規表現サポート
- 一括置換機能
- 高度な検索オプション

### コンセプト管理
- 役割、場所、アイテムの自動検出
- コンセプト関係管理
- タグおよび分類システム
- コンセプトのクイック挿入

## ショートカットキー

- `Ctrl+N`: 新規プロジェクト
- `Ctrl+O`: プロジェクトを開く
- `Ctrl+S`: ドキュメントを保存
- `F11`: 全画面モード
- `Tab`: AI補完を手動でトリガー（手動モード時）
- `Ctrl+F`: 検索
- `Ctrl+H`: 検索置換
- `Ctrl+Shift+H`: 高度な検索置換
## システム要件

- Python 3.8+
- PyQt6
- オペレーティングシステム：Windows、macOS、Linux

## 作者

**inliver**
- メール：inliverapi@outlook.com  
- GitHub：https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---