# AutoGPT: AIエージェントの構築・デプロイ・実行

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT**は、複雑なワークフローを自動化する継続的なAIエージェントを作成・デプロイ・管理できる強力なプラットフォームです。

## ホスティングオプション
   - ダウンロードしてセルフホスト
   - [クラウドホストベータのウェイトリストに参加](https://bit.ly/3ZDijAI)

## セルフホスティングのセットアップ方法
> [!NOTE]
> AutoGPTプラットフォームのセットアップとホスティングは技術的なプロセスです。  
> すぐに使えるものをお求めの場合は、[クラウドホストベータのウェイトリスト](https://bit.ly/3ZDijAI)への参加をおすすめします。

### システム要件

インストールを進める前に、システムが以下の要件を満たしていることを確認してください。

#### ハードウェア要件
- CPU: 4コア以上推奨
- RAM: 最小8GB、16GB推奨
- ストレージ: 10GB以上の空き容量

#### ソフトウェア要件
- オペレーティングシステム:
  - Linux（Ubuntu 20.04以上推奨）
  - macOS（10.15以上）
  - Windows 10/11（WSL2必須）
- 必要なソフトウェア（最低バージョン）:
  - Docker Engine（20.10.0以上）
  - Docker Compose（2.0.0以上）
  - Git（2.30以上）
  - Node.js（16.x以上）
  - npm（8.x以上）
  - VSCode（1.60以上）または任意のモダンなコードエディタ

#### ネットワーク要件
- 安定したインターネット接続
- 必要なポートへのアクセス（Dockerで設定）
- HTTPSによる外部接続が可能であること

### 最新セットアップ手順
ドキュメントサイトにて、常に保守・更新されています。

👉 [公式セルフホスティングガイドはこちら](https://docs.agpt.co/platform/getting-started/)

このチュートリアルではDocker、VSCode、git、npmがインストールされていることを前提としています。

### 🧱 AutoGPT フロントエンド

AutoGPTフロントエンドは、ユーザーが強力なAI自動化プラットフォームと対話するための場所です。複数の方法でAIエージェントの活用が可能です。このインターフェースで、あなたのAI自動化アイデアを実現できます。

   **エージェントビルダー:** カスタマイズしたい方のために、直感的なローコードインターフェースで独自のAIエージェントを設計・設定できます。
   
   **ワークフロー管理:** 自動化ワークフローの構築、変更、最適化が簡単に行えます。ブロックをつなげてエージェントを組み立て、各ブロックが単一のアクションを実行します。
   
   **デプロイ管理:** テストから本番まで、エージェントのライフサイクルを管理します。
   
   **すぐに使えるエージェント:** 構築が不要な場合は、事前設定済みエージェントのライブラリから選択し、すぐに活用できます。
   
   **エージェントとの対話:** 独自に作成したものでも、事前設定済みエージェントでも、ユーザーフレンドリーなインターフェースで簡単に実行・対話できます。

   **モニタリングと分析:** エージェントのパフォーマンスを追跡し、継続的な自動化プロセスの改善に役立つインサイトを得られます。

[カスタムブロックの作成方法はこちらのガイドを参照](https://docs.agpt.co/platform/new_blocks/)

### 💽 AutoGPT サーバー

AutoGPTサーバーはプラットフォームの中核です。ここでエージェントが実行されます。デプロイ後、外部からのトリガーでエージェントが継続的に稼働可能です。AutoGPTを円滑に動作させるためのすべての主要コンポーネントを含みます。

   **ソースコード:** エージェントや自動化プロセスを駆動するコアロジック。
   
   **インフラ:** 信頼性とスケーラビリティを確保する堅牢なシステム。
   
   **マーケットプレイス:** 多様な事前構築済みエージェントを探してデプロイできる充実したマーケットプレイス。

### 🐙 エージェントの例

AutoGPTでできることの例を2つご紹介します。

1. **トレンドトピックからバイラル動画を生成**
   - このエージェントはRedditのトピックを読み込みます。
   - トレンドトピックを特定します。
   - コンテンツに基づき自動でショート動画を作成します。

2. **動画からSNS向けの注目引用を特定**
   - このエージェントはあなたのYouTubeチャンネルを購読します。
   - 新しい動画を投稿すると、その内容を文字起こしします。
   - AIで最も印象的な引用を特定し、要約を生成します。
   - そして自動的にSNSへ投稿します。

これらはAutoGPTで実現できることの一例に過ぎません。カスタマイズしたワークフローで、あらゆる用途向けのエージェントを作成できます。

---
### ミッションとライセンス
私たちのミッションは、あなたが本当に重要なことに集中できるツールを提供することです。

- 🏗️ **構築** - 何か素晴らしいものの土台を築く。
- 🧪 **テスト** - エージェントを完璧に仕上げる。
- 🤝 **委任** - AIに仕事を任せ、あなたのアイデアを形にする。

革命の一員になろう！**AutoGPT**はAIイノベーションの最前線に立ち続けます。

**📖 [ドキュメント](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [コントリビュート](CONTRIBUTING.md)**

**ライセンス:**

MITライセンス：AutoGPTリポジトリの大部分はMITライセンスです。

Polyform Shield License：このライセンスはautogpt_platformフォルダーに適用されます。

詳細は https://agpt.co/blog/introducing-the-autogpt-platform をご覧ください。

---
## 🤖 AutoGPTクラシック
> 以下はAutoGPTクラシックバージョンに関する情報です。

**🛠️ [独自エージェントの構築 - クイックスタート](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**独自エージェントをForgeで構築！** &ndash; Forgeは独自のエージェントアプリを構築するための即戦力ツールキットです。多くのボイラープレートコードを処理し、創造性をエージェントの差別化に集中できます。全チュートリアルは[こちら](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec)。[`forge`](/classic/forge/)のコンポーネントは個別にも利用でき、開発を加速しボイラープレートを削減します。

🚀 [**Forgeで始める**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
このガイドでは、独自エージェントの作成、ベンチマークやユーザーインターフェースの使用方法を解説します。

📘 [Forgeの詳細はこちら](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge)

### 🎯 ベンチマーク

**エージェントの性能を測定！** `agbenchmark`はエージェントプロトコルに対応する任意のエージェントで利用でき、プロジェクトの[CLI]との統合によりAutoGPTやforgeベースのエージェントでも簡単に使えます。厳格なテスト環境を提供し、自律的かつ客観的な性能評価が可能です。現実世界で即戦力となるようエージェントを鍛えます。

<!-- TODO: ベンチマークのビジュアルを挿入 -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) on Pypi
&ensp;|&ensp;
📘 [ベンチマークの詳細はこちら](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark)

### 💻 UI

**エージェントを簡単に使える！** `frontend`はエージェントの制御やモニタリングのためのユーザーフレンドリーなインターフェースを提供します。[エージェントプロトコル](#-agent-protocol)経由で多くのエージェントと互換性があります。

<!-- TODO: フロントエンドのスクリーンショットを挿入 -->

フロントエンドはリポジトリ内のすべてのエージェントとすぐに連携できます。お好みのエージェントを[CLI]で実行するだけ！

📘 [フロントエンドの詳細はこちら](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend)

### ⌨️ CLI

[CLI]: #-cli

リポジトリのすべてのツールを簡単に使えるよう、リポジトリのルートにCLIが含まれています。

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

リポジトリをクローンし、`./run setup`で依存関係をインストールするだけで準備完了です！

## 🤔 質問・問題・提案

### ヘルプ - [Discord 💬](https://discord.gg/autogpt)

[![Join us on Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

バグ報告や機能リクエストは[GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose)からどうぞ。同じトピックのIssueがないかご確認ください。

## 🤝 姉妹プロジェクト

### 🔄 エージェントプロトコル

現在および将来の多くのアプリケーションとの互換性維持と標準化のため、AutoGPTはAI Engineer Foundationによる[agent protocol](https://agentprotocol.ai/)標準を採用しています。これによりエージェントからフロントエンドやベンチマークへの通信経路が標準化されます。

---

## Stars stats

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>

## ⚡ コントリビューター

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---