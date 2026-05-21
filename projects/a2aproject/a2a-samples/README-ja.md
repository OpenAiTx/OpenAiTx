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

[Agent2Agent (A2A) プロトコル](https://goo.gle/a2a) の公式コードサンプルとデモへようこそ。

ご訪問ありがとうございます！マルチエージェントアーキテクチャを初めて探求する方も、高度な相互運用エージェントネットワークを構築する方も、このリポジトリはシンプルで刺激的、かつ分かりやすい学習リソースを提供し、開発を加速します。

## Agent2Agentの理由

多様なAIフレームワークやエコシステムが存在する世界で、エージェント同士が安全に通信し、協調し、タスクを委譲するためには共通言語が必要です。A2Aプロトコルは、マルチエージェント相互運用性のための標準化されたオープンスタンダードを確立します。

当サンプルは、異なる言語やホストアプリケーション間でも複雑なマルチエージェント問題がいかに簡単に解決できるかを示しています。

## クイックスタート

Helloworldエージェントを起動し、Python CLIホストを通じて通信することで、すぐに開始できます。

1. **エージェントサーバーを起動**:
   ターミナルを開き、Helloworldエージェントサーバーを起動します:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **ホストクライアントを実行する**:
   2つ目のターミナルを開き、CLIクライアントを実行してエージェントにタスクを送信します。

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## リポジトリ構成

リポジトリは言語ごとにいくつかの主要ディレクトリに整理されています：

| ディレクトリ | 説明 |
| --- | --- |
| [samples](/samples) | プログラミング言語別に整理されたコアA2Aサンプル。 |
| [samples/python](/samples/python) | A2A Python SDKを使用したPythonエージェント実装例。 |
| [samples/go](/samples/go) | A2A Go SDKを使用したGoエージェント実装例。 |
| [samples/dotnet](/samples/dotnet) | A2A .NET SDKを使用したC#エージェント実装例。 |
| [samples/java](/samples/java) | A2A Java SDKを使用したJavaエージェント実装例。 |
| [samples/js](/samples/js) | A2A JavaScript SDKを使用したNode.jsエージェント実装例。 |

## コントリビュートについて

すべてのスキルレベルの貢献を歓迎し、奨励しています！ 新しいサンプル、バグ修正、ドキュメントの改善案がある場合は、[Contributing Guide](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)をご覧ください。

## サポートの取得

私たちは、歓迎的で支援的なコミュニティの提供に努めています。質問やフィードバック、問題が発生した場合は、[issues page](https://github.com/a2aproject/a2a-samples/issues)からご連絡ください。

## 関連リポジトリ

| リポジトリ | カテゴリ | 説明 |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | コア仕様 | A2A仕様とドキュメント。 |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | ツール | A2A対応エージェントの検査用UIツール。 |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | テスト | A2Aプロトコル準拠の検証用テストスイート。 |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | テスト | マルチホップトラバーサルモデルと多様なトランスポートプロトコルを使用して、異なるA2A SDK実装やバージョン間の互換性を検証するツールキット。 |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | A2A公式Python SDK。 |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | A2A公式Go SDK。 |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | A2A公式Java SDK。 |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | A2A公式Node.js/JavaScript SDK。 |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | A2A公式C#/.NET SDK。 |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | A2A公式Rust SDK。 |

## 免責事項

**重要:** 提供されているサンプルコードはデモンストレーション目的であり、メカニズムの説明を目的としています。
Agent-to-Agent（A2A）プロトコル。プロダクションアプリケーションを構築する際には、直接管理外のエージェントは、潜在的に信頼できない存在として扱うことが重要です。

外部エージェントから受信するすべてのデータ（AgentCard、メッセージ、アーティファクト、タスクステータスなどを含むがこれに限定されない）は、信頼できない入力として取り扱う必要があります。例えば、悪意のあるエージェントが、そのフィールド（説明、名前、skills.descriptionなど）に細工したデータを含むAgentCardを提供することがあります。このデータがサニタイズせずに大規模言語モデル（LLM）のプロンプト構築に使用された場合、プロンプトインジェクション攻撃のリスクがあります。このデータを適切に検証・サニタイズせずに使用すると、アプリケーションにセキュリティ脆弱性をもたらす可能性があります。

> 開発者は、入力検証や資格情報の安全な取り扱いなど、適切なセキュリティ対策を実装し、システムとユーザーを保護する責任があります。










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---