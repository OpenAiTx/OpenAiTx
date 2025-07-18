# Agent2Agent (A2A) サンプル

<div style="text-align: right;">
  <details>
    <summary>🌐 言語</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

このリポジトリには [Agent2Agent (A2A) プロトコル](https://goo.gle/a2a) を使用したコードサンプルとデモが含まれています。

## 関連リポジトリ

- [A2A](https://github.com/a2aproject/A2A) - A2A仕様およびドキュメント。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A対応エージェントの検査用UIツール。

## コントリビューション

貢献は大歓迎です！[コントリビューションガイド](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)をご覧ください。

## ヘルプの取得

提案、フィードバック、バグ報告は [issuesページ](https://github.com/a2aproject/a2a-samples/issues) をご利用ください。

## 免責事項

このリポジトリ自体はGoogleの公式サポート製品ではありません。このリポジトリのコードはデモ目的のものです。

重要: 提供されているサンプルコードはデモンストレーション目的であり、Agent-to-Agent (A2A) プロトコルの仕組みを示すものです。本番アプリケーションを構築する際は、自分の直接管理外で動作するエージェントは潜在的に信頼できない存在とみなすことが重要です。

外部エージェントから受信するすべてのデータ（AgentCard、メッセージ、アーティファクト、タスクステータスなどを含むがこれらに限定されない）は、信頼できない入力として取り扱う必要があります。例えば、悪意のあるエージェントがフィールド（例：description、name、skills.description）に細工したデータを含むAgentCardを提供する場合があります。このデータをサニタイズせずに大規模言語モデル（LLM）のプロンプト構築に使用した場合、プロンプトインジェクション攻撃にアプリケーションがさらされる可能性があります。このデータを適切に検証・サニタイズせずに使用すると、アプリケーションにセキュリティ上の脆弱性が生じます。

開発者は、システムやユーザーを守るために、入力検証や認証情報の安全な取り扱いなど、適切なセキュリティ対策を実装する責任があります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---