<translate-content><!-- GitHub バッジ -->
<p align="center">
  <a href="https://github.com/oldjs/web-code-agent/stargazers"><img src="https://img.shields.io/github/stars/oldjs/web-code-agent?style=social" alt="GitHub stars"></a>
  <a href="https://github.com/oldjs/web-code-agent/network/members"><img src="https://img.shields.io/github/forks/oldjs/web-code-agent?style=social" alt="GitHub forks"></a>
  <a href="https://github.com/oldjs/web-code-agent/issues"><img src="https://img.shields.io/github/issues/oldjs/web-code-agent" alt="GitHub issues"></a>
</p>

<p align="center">
  <a href="https://github.com/oldjs/web-code-agent/blob/main/preview.md">
    <img src="https://img.shields.io/badge/Preview-Click%20Here-blue" alt="Preview">
  </a>
</p>

<p align="center">
  <a href="#zh-cn">简体中文</a> | <a href="#en-us">English</a>
</p>

# Folda-Scan: あなたのプライベートAIナビゲーター＆コードベースのQ&Aエンジン 🚀
[![ライセンス: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![GitHub リポジトリスター数](https://img.shields.io/github/stars/oldjs/web-code-agent?style=social)](https://github.com/oldjs/web-code-agent/stargazers)

---

<p align="center">
  <em>AIでコードベースを解放、すべてローカルで、プライバシーを守りながら。</em>xs
</p>

---

<a name="en-us"></a>

**コードの迷路で迷子になりましたか？AIと協働するための面倒なコンテキスト準備に疲れましたか？Folda-Scanが救います！** 💡

**Folda-Scan** は、**ブラウザ内で完全にローカル実行される**革新的なインテリジェントプロジェクトQ&Aツールです。高度なセマンティックベクトル化を用いてコードベースを対話型パートナーに変換し、コードの理解とAIとの協働をこれまでにないほど簡単かつ安全にします。

Folda-Scanは（[WebFS-Toolkit](https://github.com/oldjs/web-code-agent)の一部として）最先端のウェブ技術とAIアルゴリズムを駆使して、スムーズで効率的かつ安全なローカルコードインタラクション体験を提供します。

### ✨ 主要な特徴（なぜFolda-Scanなのか？）

- 🛡️ **完全なプライバシー、ローカル実行**：すべてのデータ処理はブラウザ内のローカルで行われ、コードは**決してマシンから出ません**。
- 💬 **自然言語でコードと「チャット」**：同僚と話すようにコードベースに質問し、正確な回答を得られます。
- 🧠 **深いセマンティック理解**：キーワード以上にコードの真の意図や複雑なロジックを把握します。
- 🎯 **即座に情報を特定**：あいまいな説明でも関連するコードスニペットやファイルを素早く見つけます。
- 🤖 **LLM協働アクセラレータ**：コンテキストに即したMarkdownをワンクリックで生成し、AIアシスタント（ChatGPT、Claudeなど）に最適に「供給」します。
- 💰 **トークンコスト削減**：LLMとのやり取りを最適化し、APIコールの費用とレイテンシを大幅に削減します。
- 🛠️ **スマート設定生成**：`Dockerfile`などのプロジェクト設定ファイル作成を支援します。
- 🚀 **即時オンボーディング**：コード探索を素早く始められる明確なガイド。

### 🚀 動作原理

Folda-Scanの魔法は革新的な**セマンティックベクトル化エンジン**にあります：

1.  **ローカルスキャン＆インデックス作成**：選択したローカルプロジェクトを安全にスキャンし、コードをセマンティック解析で高次元ベクトルに変換し、ブラウザ内に知識インデックスを構築します。
2.  **インテリジェントな自然言語処理（NLP）**：自然言語の質問を理解し、これもベクトルに変換します。
3.  **正確なセマンティックマッチング**：質問ベクトルとコード内容をベクトル空間で効率的にマッチングし、最も関連性の高い回答を提供します。
    _すべてブラウザ内で効率的に行われ、データプライバシーは完全に守られています。_

### 🛠️ 技術詳細（テックスタック）

- **コアフレームワーク:** [Next.js 14](https://nextjs.org/)
- **ローカルファイル操作:** [File System Access API](https://developer.mozilla.org/en-US/docs/Web/API/File_System_Access_API)
- **AI & NLP:** 高度なセマンティックベクトル解析、自然言語処理アルゴリズム
- **主要言語:** [JavaScript/TypeScript - ご指定ください]
  ### 🏁 はじめに

#### 前提条件

- Node.js（推奨v16+またはv18+、`package.json`参照）
- npm（`package.json`に準拠、例：npm@10.x.x）/ yarn / pnpm
- File System Access APIをサポートする最新ブラウザ（例：最新のChrome、Edge）

### 💡 基本的な使い方

1.  **フォルダを選択**：ブラウザにローカルのコードプロジェクトへのアクセスを許可します。
2.  **インデックス作成を待つ**：Folda-Scanが迅速にローカルでセマンティックインデックスを構築します。
3.  **質問を開始**：自然言語でコードベースに問いかけ、その秘密を明かしましょう！

### 🤝 貢献のお願い（Contributing）

あらゆる種類の貢献を歓迎します！バグ報告、機能提案、コード提出など、詳細は[Contribution Guidelines](https://raw.githubusercontent.com/oldjs/web-code-agent/main/CONTRIBUTING.md)をご覧ください。一緒により良いFolda-Scanを作りましょう！

### 📄 ライセンス

本プロジェクトは[MITライセンス](LICENSE)の下でライセンスされています。

---

<p align="center">
  <a href="#en-us">トップに戻る</a>
</p>
---

<a name="zh-cn"></a>

## 中国語

**代码迷宫中找不到方向？与 AI 协作时上下文准备太繁琐？ Folda-Scan 来拯救您！** 💡

**Folda-Scan** 是一款革命性的智能项目问答工具，它**完全在您的浏览器本地运行**，通过先进的语义向量化技术，将您的代码库转化为可对话的智能伙伴。告别繁琐，拥抱高效，让代码理解和 AI 协作变得前所未有地简单和安全。
</translate-content>
Folda-Scan（[WebFS-Toolkit](https://github.com/oldjs/web-code-agent) の一部として）は、最先端の Web 技術と AI アルゴリズムを採用し、滑らかで効率的かつ安全なローカルコードインタラクションの新体験をお届けします。

### ✨ コアハイライト (Why Folda-Scan?)

- 🛡️ **完全プライバシー、ローカル実行**：すべてのデータ処理はブラウザのローカルで行われ、コードは**決して**あなたのコンピュータを離れません。
- 💬 **自然言語で「コードと会話」**：同僚と話すようにコードベースに質問し、正確な答えを得られます。
- 🧠 **深い意味理解**：キーワードを超えて、コードの真の意図と複雑なロジックを理解します。
- 🎯 **秒単位の情報特定**：あいまいな記述でも関連するコード断片やファイルを素早く特定。
- 🤖 **LLM 協力アクセラレータ**：ワンクリックでコンテキスト認識の Markdown を生成し、AI アシスタント（ChatGPT、Claude など）に完璧な「エサ」を提供。
- 💰 **トークンコスト激減**：LLM インタラクションを最適化し、API 呼び出しコストと待機時間を大幅に削減。
- 🛠️ **スマート設定生成**：`Dockerfile` などのプロジェクト設定ファイル生成を支援。
- 🚀 **即時スタート**：明確なプロジェクト起動ガイドで、コード探索の旅を素早く開始。

### 🚀 仕組みは？ (How It Works)

Folda-Scan の魔法は、革新的な**意味ベクトル化エンジン**に由来します：

1.  **ローカルスキャンとインデックス作成**：選択したローカルプロジェクトを安全にスキャンし、意味解析を通じてコードを高次元ベクトルに変換、ブラウザ内で知識インデックスを構築。
2.  **スマート自然言語処理 (NLP)**：自然言語の質問を理解し、同様にベクトル化。
3.  **正確な意味マッチング**：ベクトル空間で質問とコード内容を効率的にマッチングし、最も関連性の高い回答を提供。
    _これらはすべてデータプライバシーを守りつつ、ブラウザ内で効率的に完了します。_

### 🛠️ 技術スタック (Tech Stack)

- **コアフレームワーク:** [Next.js 14](https://nextjs.org/)
- **ローカルファイル操作:** [File System Access API](https://developer.mozilla.org/en-US/docs/Web/API/File_System_Access_API)
- **AI & NLP:** 先進的意味ベクトル解析、自然言語処理アルゴリズム
- **主要言語:** [JavaScript/TypeScript - ご指定ください]
  ### 🏁 クイックスタート (Getting Started)

#### 環境要件 (Prerequisites)

- Node.js（推奨 v16+ または v18+、`package.json` 参照）
- npm（バージョンは `package.json` を参照、例：npm@10.x.x）/ yarn / pnpm
- File System Access API をサポートする最新のブラウザ（Chrome、Edge 最新版など）

### 💡 基本的な使い方 (Basic Usage)

1.  **フォルダを選択**：ブラウザにローカルコードプロジェクトへのアクセスを許可。
2.  **インデックス作成を待つ**：Folda-Scan がローカルで高速に意味インデックスを構築。
3.  **質問開始**：自然言語でコードベースに質問し、その秘密を探る！

### 🤝 貢献のお願い (Contributing)

あらゆる形の貢献を歓迎します！バグ報告、機能提案、コードの提出など、[貢献ガイド](https://raw.githubusercontent.com/oldjs/web-code-agent/main/CONTRIBUTING.md)（あれば）をご参照ください。より良い Folda-Scan を共に作り上げましょう！

### 📄 オープンソースライセンス (License)

本プロジェクトは [MIT ライセンス](LICENSE) のもとで公開されています。

---

<p align="center">
  <a href="#zh-cn">トップへ戻る (Back to Top)</a>
</p>
---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---