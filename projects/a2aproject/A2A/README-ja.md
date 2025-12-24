# Agent2Agent (A2A) プロトコル

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) プロトコル</h1>
  </div>
</div>

**不透明なエージェントアプリケーション間の通信と相互運用性を可能にするオープンプロトコル。**

Agent2Agent (A2A) プロトコルは、AIの世界における重要な課題に対処します：異なる企業が異なるフレームワーク上に構築し、別々のサーバーで動作するジェネレーティブAIエージェント同士が、単なるツールではなくエージェントとして効果的に通信し協働することを可能にします。A2Aはエージェント間の共通言語を提供し、より相互接続され強力で革新的なAIエコシステムを促進することを目指しています。

A2Aを使うことで、エージェントは以下が可能になります：

- お互いの能力を発見する。
- 交流モード（テキスト、フォーム、メディア）を交渉する。
- 長期間のタスクで安全に協力する。
- 内部状態、メモリ、ツールを公開せずに動作する。

## A2A紹介ビデオ

[![A2A Intro Video](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## なぜA2Aなのか？

AIエージェントが普及するにつれて、それらの相互運用性は複雑で多機能なアプリケーション構築に不可欠になります。A2Aは以下を目指します：

- **サイロの打破：** 異なるエコシステムのエージェントをつなぐ。
- **複雑な協働の実現：** 単一のエージェントでは対応できないタスクに対し、専門化されたエージェントが協力できるようにする。
- **オープンスタンダードの促進：** エージェント間通信に対するコミュニティ主導のアプローチを促し、革新と広範な採用を促進する。
- **不透明性の保持：** 内部メモリ、独自ロジック、特定のツール実装を共有せずに協力を可能にし、セキュリティと知的財産の保護を強化する。

### 主な特徴

- **標準化された通信:** HTTP(S) 上の JSON-RPC 2.0。
- **エージェント探索:** 機能と接続情報を詳細に記述した「エージェントカード」による。
- **柔軟なインタラクション:** 同期リクエスト/レスポンス、ストリーミング（SSE）、非同期プッシュ通知に対応。
- **豊富なデータ交換:** テキスト、ファイル、構造化された JSON データを扱う。
- **エンタープライズ対応:** セキュリティ、認証、可観測性を考慮して設計。

## はじめに

- 📚 **ドキュメントを探る:** [Agent2Agent プロトコル ドキュメントサイト](https://a2a-protocol.org) を訪れて、概要、完全なプロトコル仕様、チュートリアル、ガイドを確認。
- 📝 **仕様を見る:** [A2A プロトコル仕様](https://a2a-protocol.org/latest/specification/)
- SDK を利用:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven 使用
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A` 使用
- 🎬 [サンプル](https://github.com/a2aproject/a2a-samples) を使って A2A の動作を確認

## 貢献

A2A プロトコルの強化と進化のためにコミュニティからの貢献を歓迎します！

- **質問・議論:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) に参加。
- **問題・フィードバック:** [GitHub Issues](https://github.com/a2aproject/A2A/issues) で問題報告や改善提案。
- **貢献ガイド:** 貢献方法の詳細は [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) を参照。
- **非公開フィードバック:** [Googleフォーム](https://goo.gle/a2a-feedback) を利用。
- **パートナープログラム:** Google Cloud 顧客はこの [フォーム](https://goo.gle/a2a-partner) からパートナープログラムに参加可能。

## 今後の展望

### プロトコルの強化

- **エージェント探索:**
    - `AgentCard` 内に認可スキームとオプションの認証情報を正式に含めることを検討。
- **エージェント協調:**
    - 未対応または予期しないスキルを動的に確認するための `QuerySkill()` メソッドを検討。
- **タスクのライフサイクルとUX:**
    - タスクの _途中_ での動的な UX 交渉（例：会話中にエージェントが音声/映像を追加）をサポート。
- **クライアントメソッドとトランスポート:**
    - クライアント起動のメソッド（タスク管理以外）へのサポート拡張を検討。
    - ストリーミングの信頼性とプッシュ通知メカニズムの改善。

## About

A2Aプロトコルは、Googleが貢献するLinux Foundationのオープンソースプロジェクトです。[Apache License 2.0](LICENSE)の下でライセンスされており、コミュニティからの貢献を受け入れています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---