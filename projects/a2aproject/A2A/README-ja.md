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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) プロトコル</h1>
  </div>
</div>

**ブラックボックス型のエージェントアプリケーション間の通信と相互運用性を可能にするオープンプロトコルです。**

Agent2Agent (A2A) プロトコルは、AI分野における重大な課題、すなわち異なる企業が異なるフレームワークで構築し、別々のサーバーで稼働している生成AIエージェント同士が、単なるツールではなくエージェントとして効果的に通信・協調できるようにする問題に取り組みます。A2Aは、エージェントの共通言語を提供し、より相互接続された、強力で革新的なAIエコシステムの実現を目指します。

A2Aを利用することで、エージェントは以下が可能となります：

- 相互の能力を発見する。
- インタラクションのモダリティ（テキスト、フォーム、メディア）を交渉する。
- 長期に渡るタスクを安全に協業する。
- 内部状態、メモリ、ツールを公開せずに動作する。

## DeepLearning.AI 講座

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

[Google Cloud](https://goo.gle/dlai-a2a)とIBM Researchとのパートナーシップで構築され、[Holt Skinner](https://github.com/holtskinner)、[Ivan Nardini](https://github.com/inardini)、[Sandi Besen](https://github.com/sandijean90)によって教えられる短期講座[A2A: The Agent2Agent Protocol](https://goo.gle/dlai-a2a)にご参加ください。

**この講座で学べること：**

- **エージェントをA2A準拠にする:** Google ADK、LangGraph、BeeAIなどのフレームワークで構築したエージェントをA2Aサーバーとして公開する方法。
- **エージェントを接続する:** A2A準拠のエージェントに接続するためのA2Aクライアントをゼロから、または統合を用いて作成する方法。
- **ワークフローをオーケストレーション:** A2A準拠エージェントの逐次的・階層的ワークフローを構築する方法。
- **マルチエージェントシステム:** 異なるフレームワークを使った医療分野のマルチエージェントシステムを構築し、A2Aがどのように協調を実現するかを学ぶ。
- **A2AとMCP:** A2AがMCPを補完し、エージェント同士の協調を可能にする仕組みを理解する。

## なぜA2Aか？

AIエージェントが普及する中で、相互運用性は複雑で多機能なアプリケーションを構築する上で不可欠です。A2Aの目的は以下の通りです：

- **サイロ化の打破:** 異なるエコシステムにまたがるエージェントを接続。
- **複雑な協調を実現:** 専門的なエージェント同士が、単一エージェントでは対応できないタスクを協力して処理できるようにする。
- **オープンスタンダードの推進:** エージェント間通信のコミュニティ主導型アプローチを促進し、イノベーションと幅広い採用を促す。
- **ブラックボックス性の維持:** 内部メモリや独自ロジック、特定のツール実装を共有せずに協調できるようにし、セキュリティや知的財産を保護する。

### 主な特徴

- **標準化された通信:** JSON-RPC 2.0 を HTTP(S) 上で使用。
- **エージェント発見:** 「エージェントカード」による能力と接続情報の詳細。
- **柔軟なインタラクション:** 同期リクエスト/レスポンス、ストリーミング（SSE）、非同期プッシュ通知をサポート。
- **豊富なデータ交換:** テキスト、ファイル、構造化JSONデータを処理。
- **エンタープライズ対応:** セキュリティ、認証、可観測性を考慮して設計。

## はじめに

- 📚 **ドキュメントを探索:** [Agent2Agent Protocol Documentation Site](https://a2a-protocol.org) で概要、プロトコル仕様、チュートリアル、ガイドを参照。
- 📝 **仕様書を見る:** [A2A Protocol Specification](https://a2a-protocol.org/latest/specification/)
- SDKを利用する:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) mavenを利用
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) を利用 `dotnet add package A2A`
- 🎬 [サンプル](https://github.com/a2aproject/a2a-samples)でA2Aの動作を確認

## コントリビューション

A2Aプロトコルの向上や進化のため、コミュニティの貢献を歓迎します！

- **質問・議論:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) に参加。
- **課題・フィードバック:** [GitHub Issues](https://github.com/a2aproject/A2A/issues) で課題報告や改善提案。
- **コントリビューションガイド:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) で詳細を確認。
- **プライベートフィードバック:** [Googleフォーム](https://goo.gle/a2a-feedback)を利用。
- **パートナープログラム:** Google Cloud顧客は [フォーム](https://goo.gle/a2a-partner) から参加可能。

## 次の展開

### プロトコル強化

- **エージェント発見:**
    - 認可方式やオプション認証情報を `AgentCard` に正式に含めることを検討。
- **エージェント協調:**
    - 未対応または予期しないスキルを動的に確認する `QuerySkill()` メソッドの検討。
- **タスクライフサイクルとUX:**
    - タスク内での動的なUXネゴシエーションのサポート（例：エージェントが会話中に音声/ビデオを追加）。
- **クライアントメソッドとトランスポート：**
    - クライアント主導のメソッド（タスク管理以外）への対応拡張の検討。
    - ストリーミングの信頼性向上およびプッシュ通知メカニズムの改善。

## 概要

A2Aプロトコルは、GoogleによってLinux Foundationに寄贈されたオープンソースプロジェクトです。[Apache License 2.0](LICENSE)の下でライセンスされており、コミュニティからの貢献を受け付けています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---