# Agent2Agent (A2A) プロトコル

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 言語</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) プロトコル</h1>
  </div>
</div>

**不透明なエージェント型アプリケーション間の通信と相互運用性を可能にするオープンプロトコルです。**

Agent2Agent (A2A) プロトコルは、AI分野の重要な課題に取り組みます。それは、異なる企業が異なるフレームワーク上で構築し、別々のサーバーで稼働している生成AIエージェント同士が、単なるツールではなく「エージェント」として効果的に通信・協力できるようにすることです。A2Aは、エージェント同士の共通言語を提供し、より連携性が高く強力で革新的なAIエコシステムを目指します。

A2Aによって、エージェントは以下のことが可能になります：

- お互いの能力を発見する。
- インタラクションの方式（テキスト、フォーム、メディア）を交渉する。
- 長期間実行されるタスクを安全に協働する。
- 内部状態、メモリ、ツールを公開せずに動作する。

## DeepLearning.AI コース

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

[Holt Skinner](https://github.com/holtskinner)、[Ivan Nardini](https://github.com/inardini)、[Sandi Besen](https://github.com/sandijean90)が講師を務め、Google CloudとIBM Researchが共同で開発した[A2A: The Agent2Agent Protocol](https://goo.gle/dlai-a2a)の短期コースに参加しましょう。

**このコースで学べること：**

- **エージェントをA2A準拠にする:** Google ADK、LangGraph、BeeAIなどのフレームワークで構築したエージェントをA2Aサーバーとして公開する方法。
- **エージェントを接続する:** ゼロから、または既存の統合を利用してA2A準拠エージェントに接続できるA2Aクライアントを作成する方法。
- **ワークフローをオーケストレーション:** A2A準拠エージェントの逐次的・階層的なワークフローを構築する方法。
- **マルチエージェントシステム:** 様々なフレームワークを用いてヘルスケアのマルチエージェントシステムを構築し、A2Aがどのように協調を可能にするかを体験します。
- **A2AとMCP:** A2AがMCPを補完し、エージェント同士の協調を可能にする仕組みを学びます。

## なぜA2Aなのか？

AIエージェントが普及する中で、それらが相互運用できる能力は、複雑で多機能なアプリケーションの構築に不可欠です。A2Aは次のことを目指します：

- **サイロ化の打破:** 異なるエコシステム間のエージェントを接続する。
- **複雑な協調作業の実現:** 単独のエージェントでは対応できないタスクを、専門的なエージェント同士が協力して達成できるようにする。
- **オープンスタンダードの推進:** エージェント間通信のためのコミュニティ主導のアプローチを促進し、イノベーションと幅広い普及を目指す。
- **不透明性の維持:** エージェントが内部メモリや独自ロジック、特定のツール実装を公開することなく協力できるようにし、セキュリティや知的財産の保護を強化する。

### 主な特徴

- **標準化された通信:** HTTP(S)上でのJSON-RPC 2.0。
- **エージェント発見:** 機能や接続情報を詳細に記載した「エージェントカード」による。
- **柔軟なインタラクション:** 同期リクエスト/レスポンス、ストリーミング（SSE）、非同期プッシュ通知に対応。
- **豊富なデータ交換:** テキスト、ファイル、構造化JSONデータのやりとりが可能。
- **エンタープライズ対応:** セキュリティ、認証、可観測性を重視した設計。

## はじめに

- 📚 **ドキュメントを読む:** [Agent2Agent Protocol Documentation Site](https://a2a-protocol.org)で全体像、プロトコル仕様、チュートリアル、ガイドを参照できます。
- 📝 **仕様を見る:** [A2A Protocol Specification](https://a2a-protocol.org/latest/specification/)
- SDKを利用する:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven利用
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A)経由 `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 [サンプル](https://github.com/a2aproject/a2a-samples)を使ってA2Aの動作を確認

## コントリビューション

A2Aプロトコルの進化と向上のため、コミュニティからの貢献を歓迎します！

- **質問・議論:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)にご参加ください。
- **不具合・フィードバック:** [GitHub Issues](https://github.com/a2aproject/A2A/issues)で報告や提案が可能です。
- **貢献ガイド:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md)でコントリビュート方法を確認できます。
- **個別フィードバック:** この[Google フォーム](https://goo.gle/a2a-feedback)をご利用ください。
- **パートナープログラム:** Google Cloudのお客様は[こちらのフォーム](https://goo.gle/a2a-partner)からパートナープログラムに参加できます。

## 今後の予定

### プロトコル強化

- **エージェント発見:**
    - 認可方式やオプションの認証情報を`AgentCard`内に正式に含めることを検討。
- **エージェント協調:**
    - 未サポートまたは想定外のスキルを動的に確認する`QuerySkill()`メソッドを検討。
- **タスクライフサイクルとUX:**
    - タスク内での動的UX交渉のサポート（例：エージェントが会話中に音声/ビデオを追加）。
- **クライアントメソッドとトランスポート:**
    - クライアント主導のメソッド（タスク管理以外）への対応拡張を検討。
    - ストリーミングの信頼性やプッシュ通知メカニズムの改善。

## 概要

A2AプロトコルはLinux FoundationのもとでGoogleが貢献したオープンソースプロジェクトです。[Apache License 2.0](LICENSE) のもとでライセンスされており、コミュニティからの貢献も歓迎しています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---