<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChainロゴ" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![リリースノート](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - ライセンス](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - ダウンロード数](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHubスター推移](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![未解決イシュー数](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Dev Containersで開く](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Github Codespaceで開く" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> JS/TSライブラリをお探しですか？[LangChain.js](https://github.com/langchain-ai/langchainjs)をご覧ください。

LangChainは、LLMを活用したアプリケーション構築のためのフレームワークです。相互運用可能なコンポーネントやサードパーティ統合を組み合わせてAIアプリケーションの開発を簡素化し、基盤技術が進化しても将来性のある選択を可能にします。

```bash
pip install -U langchain
```

LangChainの詳細については、[ドキュメント](https://python.langchain.com/docs/introduction/)をご覧ください。より高度なカスタマイズやエージェントのオーケストレーションに興味がある場合は、[LangGraph](https://langchain-ai.github.io/langgraph/)（制御可能なエージェントワークフロー構築フレームワーク）もご参照ください。

## なぜLangChainを使うのか？

LangChainは、モデル、エンベディング、ベクトルストアなどに対する標準インターフェースを通じて、LLM搭載アプリケーションの開発をサポートします。

LangChainは以下の用途に最適です：
- **リアルタイムデータ拡張**：LLMを多様なデータソースや外部/内部システムに簡単に接続できます。モデルプロバイダー、ツール、ベクトルストア、リトリーバーなど、LangChainの豊富な統合ライブラリを活用できます。
- **モデルの相互運用性**：アプリケーションの要件に最適なモデルを見つけるため、エンジニアリングチームがモデルを入れ替えて試行できます。業界の最先端が進化しても迅速に適応でき、LangChainの抽象化によって勢いを失うことなく開発を継続できます。

## LangChainのエコシステム

LangChainフレームワークは単独でも使用できますが、他のLangChain製品とシームレスに統合できるため、LLMアプリケーション開発時に包括的なツールスイートを提供します。

LLMアプリケーション開発をさらに向上させるために、LangChainと次の製品を組み合わせてご利用ください：

- [LangSmith](http://www.langchain.com/langsmith) - エージェント評価や可観測性に役立ちます。パフォーマンスの低いLLMアプリの実行をデバッグし、エージェントの軌跡を評価し、本番環境での可視性を確保し、時間とともにパフォーマンスを改善できます。
- [LangGraph](https://langchain-ai.github.io/langgraph/) - 低レベルなエージェントオーケストレーションフレームワークであるLangGraphを使って、複雑なタスクを確実に処理できるエージェントを構築できます。LangGraphは、カスタマイズ可能なアーキテクチャ、長期記憶、人間が介在するワークフローを提供し、LinkedIn、Uber、Klarna、GitLabなどの企業で本番導入されています。
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - 長時間稼働するステートフルなワークフローのための専用デプロイメントプラットフォームで、エージェントを簡単に展開・スケールできます。チーム間でエージェントを発見、再利用、設定、共有でき、[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/)でビジュアルプロトタイピングを活用して素早く反復可能です。

## 追加リソース

- [チュートリアル](https://python.langchain.com/docs/tutorials/)：LangChainの導入に役立つガイド付きのシンプルなウォークスルー。
- [ハウツーガイド](https://python.langchain.com/docs/how_to/)：ツール呼び出しやRAGユースケースなど、様々なトピックに関する実用的なコードスニペット。
- [概念ガイド](https://python.langchain.com/docs/concepts/)：LangChainフレームワークの主要概念の解説。
- [APIリファレンス](https://python.langchain.com/api_reference/)：LangChainのベースパッケージや統合機能の詳細なリファレンス。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---