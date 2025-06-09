![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## ガイド

NoteGenはクロスプラットフォームの`Markdown`ノートアプリケーションであり、AIを活用して記録と執筆をつなぎ、断片的な知識を読みやすいノートに整理することを目指しています。

🖥️ 公式ドキュメント: [https://notegen.top](https://notegen.top)

💬 [WeChat/QQグループに参加する](https://github.com/codexu/note-gen/discussions/110)

## NoteGenを選ぶ理由

- 軽量: [インストールパッケージ](https://github.com/codexu/note-gen/releases)は**わずか20MB**、無料で広告やバンドルソフトなし。
- クロスプラットフォーム: Mac、Windows、Linuxに対応し、`Tauri2`のクロスプラットフォーム機能のおかげで、将来的にはiOSやAndroidにも対応予定。
- `スクリーンショット`、`テキスト`、`イラスト`、`ファイル`、`リンク`など、複数の記録方法をサポートし、様々なシーンでの断片的な記録ニーズに対応。
- ネイティブな`Markdown(.md)`を保存形式に採用、変更なしで移行が容易。
- ネイティブオフライン利用に対応し、`GitHub、Giteeプライベートリポジトリ`へのリアルタイム同期や履歴ロールバック、WebDAV同期にも対応。
- AI強化: ChatGPT、Gemini、Ollama、LM Studio、Grokなどのモデルを自由に設定可能、カスタムサードパーティモデルの設定もサポート。
- RAG: ノートがそのままあなたのナレッジベースに。埋め込みモデルやリランキングモデルに対応。

## スクリーンショット

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

記録:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

執筆:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

テーマ:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## 記録から執筆へ

従来のノートアプリケーションは記録機能を提供していないことが多く、ユーザーは手動で内容をコピー＆ペーストして記録する必要があり、効率が大きく低下します。また、断片的に記録された内容を整理するには多くの手間がかかります。

NoteGenは`記録`と`執筆`ページに分かれており、両者は以下のような関係です。

- 記録内容をノートとして整理し、執筆ページに転送して深く書き込むことができます。
- 執筆中、いつでも記録を挿入することができます。

### 記録

記録機能は**AIチャットボット**に似ていますが、会話時に過去の記録内容と関連付けることができ、会話モードから整理モードに切り替えて、記録内容を読みやすいノートにまとめることができます。

以下の補助機能により、より効果的な記録が可能です。

- **タグ**で異なる記録シーンを区別
- **ペルソナ**（カスタムプロンプト対応）でAIアシスタントを細かく制御
- **クリップボードアシスタント**でクリップボード内のテキストや画像を自動認識してリストに記録

### 執筆

執筆セクションは**ファイルマネージャ**と**Markdownエディタ**の2つに分かれています。

**ファイルマネージャ**

- ローカルMarkdownファイルとGitHub同期ファイルの管理に対応
- 無制限のディレクトリ階層をサポート
- 複数の並び替え方法をサポート

**Markdownエディタ**

- WYSIWYG、インスタントレンダリング、画面分割プレビューモードに対応
- バージョン管理、履歴ロールバックに対応
- AIアシスタンスによる会話、続きの生成、推敲、翻訳機能に対応
- 画像アップロード、画像をMarkdown画像リンクへ自動変換
- HTMLからMarkdownへの変換、ブラウザのコピー内容を自動的にMarkdownに変換
- アウトライン、数式、マインドマップ、チャート、フローチャート、ガントチャート、シーケンス図、楽譜、マルチメディア、音声読み上げ、タイトルアンカー、コードハイライト・コピー、graphvizレンダリング、plantuml UML図にも対応
- ローカルでのリアルタイム保存、遅延（10秒間編集がなければ自動同期）、履歴ロールバックに対応

## その他の機能

- グローバル検索で特定の内容を素早く検索・ジャンプ
- 画像ホスティング管理で画像リポジトリの内容を便利に管理
- テーマ・外観設定、ダークテーマやMarkdown・コードなどの外観設定に対応
- 国際化対応、現在は中国語と英語に対応

## 使い方

### ダウンロード

現在はMac、Windows、Linuxに対応。Tauri2のクロスプラットフォーム機能により、今後iOSやAndroidにも対応予定。

[NoteGen (alpha)をダウンロード](https://github.com/codexu/note-gen/releases)

### 拡張

ノートアプリは設定なしでもそのまま使えます。より良い体験のためには、設定ページを開いてAIや同期を設定してください。

## コントリビュート

- [貢献ガイドを読む](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [アップデート計画](https://github.com/codexu/note-gen/issues/46)
- [バグや改善提案の提出](https://github.com/codexu/note-gen/issues)
- [ディスカッション](https://github.com/codexu/note-gen/discussions)

## コントリビューター

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---