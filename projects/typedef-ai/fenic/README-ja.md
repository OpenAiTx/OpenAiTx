<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: LLM推論のために再構築されたデータフレーム

[![PyPI version](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versions](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![License](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **ドキュメント**: [docs.fenic.ai](https://docs.fenic.ai/)

fenicはtypedef.aiによる、意見を持ったPySpark風のDataFrameフレームワークであり、AIおよびエージェントアプリケーションの構築のために設計されています。おなじみのDataFrame操作にセマンティックインテリジェンスを加え、非構造化データや構造化データをインサイトに変換します。Markdown、トランスクリプト、セマンティックオペレーターを第一級でサポートし、あらゆるモデルプロバイダーに対して効率的なバッチ推論が可能です。
## インストール

fenic は Python `[3.10, 3.11, 3.12]` をサポートしています

```bash
pip install fenic
```

### LLM プロバイダーのセットアップ

fenic では、少なくとも 1 つの LLM プロバイダーの API キーが必要です。選択したプロバイダーに応じて、適切な環境変数を設定してください:

```bash
# OpenAI の場合
export OPENAI_API_KEY="your-openai-api-key"

# Anthropic の場合
export ANTHROPIC_API_KEY="your-anthropic-api-key"

# Google の場合
```
export GEMINI_API_KEY="your-google-api-key"
```

## クイックスタート

fenicを素早く学ぶ最良の方法は、サンプル例を確認することです。

以下は、このリポジトリに含まれているサンプル例の一覧です。

| サンプル例                                                                  | 説明                                                                                                                              |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                        | エラーログ分析を通じて、fenicのコアオペレーターによるセマンティック抽出および分類の導入。                                        |
| [Enrichment](examples/enrichment)                                           | テンプレートベースのテキスト抽出、結合、LLMによる変換を用いた多段階DataFrameの実例をログエンリッチメントで紹介。                   |
| [Meeting Transcript Processing](examples/meeting_transcript_processing)     | ネイティブなトランスクリプト解析、Pydanticスキーマ連携、複雑な集計処理を会議分析を通じて紹介。                                    |
| [News Analysis](examples/news_analysis)                                     | セマンティックオペレーターや構造化データ処理を用いてニュース記事からインサイトを分析・抽出。                                       |
| [Podcast Summarization](examples/podcast_summarization)                     | 話者情報を考慮した分析や主要ポイント抽出を通じて、ポッドキャストのトランスクリプトを処理・要約。                                   |
| [Semantic Join](examples/semantic_joins)                                    | 単純な曖昧一致の代わりに、fenicの強力なセマンティック結合機能を使ってテーブル間データをマッチング。                                |
| [Named Entity Recognition](examples/named_entity_recognition)               | セマンティック抽出と分類を用いてテキストから固有表現を抽出・分類。                                                               |
| [Markdown Processing](examples/markdown_processing)                         | 構造化データ抽出とフォーマット変換により、Markdownドキュメントを処理・変換。                                                     |
| [JSON Processing](examples/json_processing)                                 | セマンティック操作とスキーマ検証により、複雑なJSONデータ構造を処理。                                                             |
| [Feedback Clustering](examples/feedback_clustering)                         | セマンティック類似度とクラスタリング操作を利用してフィードバックをグループ化・分析。                                               |
| [Document Extraction](examples/document_extraction)                         | セマンティックオペレーターを用いて様々なドキュメント形式から構造化情報を抽出。                                                   |

（上記のいずれかのサンプル例をクリックすると、該当フォルダへジャンプします。）

## なぜfenicを使うのか？

fenicは、意見を持った、PySparkにインスパイアされたDataFrameフレームワークであり、プロダクションAIおよびエージェントアプリケーションの構築のために設計されています。

従来のLLM向けに後付けされたデータツールとは異なり、fenicのクエリエンジンは推論を念頭にゼロから構築されています。

構造化データと非構造化データを、意味的インテリジェンスで強化された使い慣れたDataFrame操作を用いてインサイトに変換できます。Markdown、トランスクリプト、セマンティックオペレータへのファーストクラスサポート、さらにあらゆるモデルプロバイダーを横断した効率的なバッチ推論が可能です。

fenicは、従来のデータパイプラインの信頼性をAIワークロードにもたらします。

### 主な機能

#### LLM推論のための専用設計

- AIワークロード向けにゼロから設計されたクエリエンジン（後付けではありません）
- APIコールの自動バッチ最適化
- 組み込みのリトライロジックとレート制限
- トークンカウントとコストトラッキング

#### セマンティックオペレータをファーストクラス市民として
- `semantic.analyze_sentiment` - 組み込みの感情分析
- `semantic.classify` - 少数の例でテキストを分類
- `semantic.extract` - 非構造化テキストをスキーマで構造化データに変換
- `semantic.group_by` - セマンティックな類似性でデータをグループ化
- `semantic.join` - 値だけでなく意味でDataFrameを結合
- `semantic.map` - 自然言語変換を適用
- `semantic.predicate` - 自然言語で述語を作成し、行をフィルタリング
- `semantic.reduce` - LLM操作でグループ化したデータを集計

#### ネイティブな非構造化データサポート

一般的なマルチモーダルデータ型（音声、画像）を超え、テキスト中心のワークロード向けに特化した型を作成：

- Markdownのパースと抽出を第一級データ型としてサポート
- スピーカーとタイムスタンプに対応したトランスクリプト処理（SRT、汎用フォーマット）
- ネストされたデータ向けのJQ式によるJSON操作
- 長文ドキュメントに対する設定可能なオーバーラップ付き自動テキスト分割

#### 本番環境対応インフラストラクチャ
- 複数プロバイダー対応（OpenAI、Anthropic、Gemini）
- ローカルおよびクラウド実行バックエンド
- 包括的なエラー処理とロギング
- 型安全性のためのPydantic統合

#### なじみのあるDataFrame API

- PySpark互換の操作
- 遅延評価とクエリ最適化
- 複雑なクエリのためのSQLサポート
- 既存のデータパイプラインとのシームレスな統合

### なぜLLMやエージェントアプリケーションにDataFrameを使うのか？

AIやエージェントアプリケーションは、本質的にパイプラインやワークフローです—まさにDataFrame APIが処理するために設計されたものです。データ変換、フィルタリング、集約のためのパターンを再発明するのではなく、fenicは長年にわたる実証済みのエンジニアリング手法を活用します。

#### より良いエージェントのための分離アーキテクチャ

fenicは、重い推論タスクとリアルタイムのエージェントインタラクションの間に明確な分離を作ります。バッチ処理をエージェントランタイムから分離することで、次のようなメリットが得られます：

- より予測可能で応答性の高いエージェント
- バッチ化されたLLM呼び出しによるリソースの有効活用
- 計画／オーケストレーションと実行の明確な分離
#### すべてのエンジニアのために作られた

DataFrameはデータの専門家だけのものではありません。流暢で合成可能なAPIデザインにより、あらゆるエンジニアが利用できます。

- 操作を自然にチェーンできる： `df.filter(...).semantic.group_by(...)`
- 命令型と宣言型のスタイルをシームレスに混在可能
- pandas/PySparkやSQLで馴染みのあるパターンですぐに始められる

## サポート

[Discord](https://discord.gg/GdqF3J7huR) のコミュニティに参加して、他のユーザーとつながったり、質問したり、fenicプロジェクトについてサポートを受けたりできます。私たちのコミュニティは新しい参加者をいつでも歓迎しています！

fenicが役立つと感じたら、このリポジトリのトップで ⭐ を付けていただけると嬉しいです。皆さんのサポートが、フレームワークの成長と改善につながります！

## コントリビューション

あらゆる種類の貢献を歓迎します！ コードの執筆、ドキュメントの改善、機能のテスト、新しいアイデアの提案など、どんな形でもあなたの協力は私たちにとって価値があります。

コード変更を提出しようと考えている開発者の方は、まずissueを作成してアイデアを議論してからPull Requestを作成することを推奨します。これにより、プロジェクトの方向性との整合性が保たれ、重複作業を防ぐことができます。

開発プロセスやプロジェクトのセットアップについて詳しくは、[コントリビューションガイドライン](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) をご参照ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---