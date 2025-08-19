# Agent2Agent (A2A) サンプル

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Firebase Studio で試す"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
    </div>
  </details>
</div>

このリポジトリには、[Agent2Agent (A2A) プロトコル](https://goo.gle/a2a) を使用したコードサンプルとデモが含まれています。

## 関連リポジトリ

- [A2A](https://github.com/a2aproject/A2A) - A2A仕様およびドキュメント。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A対応エージェントの検査用UIツール。

## コントリビュートについて

貢献は歓迎します！ [コントリビュートガイド](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)をご覧ください。

## ヘルプの取得

提案、フィードバック、バグ報告には [issuesページ](https://github.com/a2aproject/a2a-samples/issues) をご利用ください。

## 免責事項

このリポジトリ自体はGoogleの公式製品としてサポートされているものではありません。本リポジトリのコードはデモンストレーション目的のみで提供されています。

重要: 提供されているサンプルコードはデモンストレーション目的であり、Agent-to-Agent (A2A) プロトコルの仕組みを説明するものです。本番アプリケーションを構築する際には、自分の直接管理下にないエージェントを潜在的に信頼できない存在として扱うことが重要です。

外部エージェントから受け取るすべてのデータ（AgentCard、メッセージ、アーティファクト、タスクステータスなどを含む）は、信頼できない入力として扱うべきです。例えば、悪意のあるエージェントが、フィールド（例: 説明、名前、skills.description）に細工したデータを含むAgentCardを提供する可能性があります。このデータをサニタイズせずに大規模言語モデル（LLM）のプロンプト生成に利用すると、プロンプトインジェクション攻撃にアプリケーションがさらされることがあります。データを利用する前に適切な検証やサニタイズを行わないと、アプリケーションにセキュリティ脆弱性が発生します。

開発者は、入力検証や認証情報の安全な取り扱いなど、適切なセキュリティ対策を講じ、システムとユーザーを保護する責任があります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---