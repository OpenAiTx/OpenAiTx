<translate-content># Agent2Agent (A2A) サンプル

このリポジトリには、[Agent2Agent (A2A) プロトコル](https://goo.gle/a2a) を使用したコードサンプルとデモが含まれています。

## 関連リポジトリ

- [A2A](https://github.com/a2aproject/A2A) - A2A仕様書とドキュメント。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A対応エージェントを検査するためのUIツール。

## コントリビュート

コントリビューション歓迎！詳細は[Contributing Guide](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)をご覧ください。

## ヘルプを得るには

ご提案やフィードバック、バグ報告は[issuesページ](https://github.com/a2aproject/a2a-samples/issues)をご利用ください。

## 免責事項

このリポジトリ自体は公式にサポートされているGoogle製品ではありません。このリポジトリのコードはデモ目的のみです。

重要: 提供されるサンプルコードはデモ用であり、Agent-to-Agent (A2A) プロトコルの仕組みを示しています。実際のアプリケーションを構築する際は、直接管理していないエージェントを潜在的に信頼できない存在として扱うことが重要です。

外部エージェントから受信するすべてのデータ（AgentCard、メッセージ、アーティファクト、タスクステータスを含むがこれらに限定されない）は信頼できない入力として扱うべきです。例えば、悪意のあるエージェントがフィールド（例：description、name、skills.description）に細工されたデータを含むAgentCardを提供する可能性があります。このデータを無検証で使用して大規模言語モデル（LLM）へのプロンプトを生成すると、プロンプトインジェクション攻撃のリスクをアプリケーションに与える恐れがあります。使用前に適切な検証とサニタイズを行わないと、セキュリティ上の脆弱性が生じる可能性があります。

開発者はシステムとユーザーを保護するために、入力検証や資格情報の安全な取り扱いなど、適切なセキュリティ対策を実装する責任があります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---