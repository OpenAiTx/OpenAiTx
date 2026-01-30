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

**不透明なエージェント型アプリケーション間の通信と相互運用性を実現するオープンプロトコル。**

Agent2Agent (A2A) プロトコルは、AI分野における重要な課題：異なる企業が異なるフレームワークで構築し、別々のサーバー上で稼働している生成AIエージェント同士が、ツールとしてだけでなくエージェントとして効果的に通信・協働できることを解決します。A2Aはエージェント同士の共通言語を提供し、より相互接続され、強力で革新的なAIエコシステムを促進します。

A2Aにより、エージェントは次のことが可能になります：

- お互いの能力を発見する。
- インタラクションの形式（テキスト、フォーム、メディア）を交渉する。
- 長期間にわたるタスクを安全に協働する。
- 内部状態、メモリ、ツールを公開せずに運用する。

## A2A紹介動画

[![A2A紹介動画](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## なぜA2Aなのか？

AIエージェントが普及するにつれ、相互運用性が複雑で多機能なアプリケーションを構築するために重要となっています。A2Aの目的は：

- **サイロの解消:** 異なるエコシステム間でエージェントを接続。
- **複雑な協働の実現:** 単一のエージェントでは対処できないタスクを専門エージェント同士で協力して解決。
- **オープン標準の推進:** エージェント通信のコミュニティ主導型アプローチを促進し、イノベーションと広範な採用を促す。
- **不透明性の保持:** 内部メモリや独自ロジック、特定ツールの実装を開示せずに協働できることで、セキュリティや知的財産を保護。

### 主な特徴

- **標準化された通信:** HTTP(S)上のJSON-RPC 2.0。
- **エージェント発見:** 機能や接続情報を記載した「Agent Card」で実現。
- **柔軟なインタラクション:** 同期型リクエスト/レスポンス、ストリーミング（SSE）、非同期プッシュ通知に対応。
- **豊富なデータ交換:** テキスト、ファイル、構造化JSONデータのやり取りが可能。
- **エンタープライズ対応:** セキュリティ、認証、可観測性を重視した設計。

## はじめに
- 📚 **ドキュメントを参照:** [Agent2Agentプロトコルドキュメントサイト](https://a2a-protocol.org)で、完全な概要、プロトコル仕様、チュートリアル、ガイドをご覧ください。
- 📝 **仕様を閲覧:** [A2Aプロトコル仕様](https://a2a-protocol.org/latest/specification/)
- SDKを使用する:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) mavenを使用
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A)を使用 `dotnet add package A2A`
- 🎬 [サンプル](https://github.com/a2aproject/a2a-samples)を利用してA2Aの動作を確認できます

## コントリビューション

A2Aプロトコルの向上と進化のため、コミュニティからの貢献を歓迎します！

- **質問とディスカッション:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)にご参加ください。
- **課題とフィードバック:** [GitHub Issues](https://github.com/a2aproject/A2A/issues)から課題報告や改善提案をお願いします。
- **コントリビューションガイド:** [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md)で詳細をご確認ください。
- **プライベートフィードバック:** [Googleフォーム](https://goo.gle/a2a-feedback)をご利用ください。
- **パートナープログラム:** Google Cloudのお客様は[フォーム](https://goo.gle/a2a-partner)からパートナープログラムに参加できます。

## 次のステップ

### プロトコル拡張

- **エージェント発見:**
    - 認可方式やオプション資格情報を`AgentCard`内に正式に含めることを検討します。
- **エージェント協働:**
    - 未対応または予期しないスキルの動的確認のため`QuerySkill()`メソッドの検討。
- **タスクライフサイクル & UX:**
    - タスク内での動的UXネゴシエーションのサポート（例：会話中にエージェントが音声/映像を追加）。
- **クライアントメソッド & トランスポート:**
    - タスク管理以外のクライアント主導メソッド拡張を検討。
    - ストリーミングの信頼性とプッシュ通知機構の改善。

## 概要

A2AプロトコルはLinux Foundationのオープンソースプロジェクトで、Googleによって提供されています。[Apache License 2.0](LICENSE)でライセンスされており、コミュニティからの貢献を受け付けています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---