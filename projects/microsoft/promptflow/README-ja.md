# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> より良い prompt flow を共に作り上げるために、  
> [ディスカッション](https://github.com/microsoft/promptflow/discussions)への参加、  
> [イシュー](https://github.com/microsoft/promptflow/issues/new/choose)の登録、  
> [PR の提出](https://github.com/microsoft/promptflow/pulls)を歓迎します。

**Prompt flow** は、LLM ベースの AI アプリケーションのアイデア出し、プロトタイピング、テスト、評価から本番環境へのデプロイ・監視まで、エンドツーエンドの開発サイクルを効率化するために設計された開発ツール群です。プロンプトエンジニアリングを大幅に簡単にし、プロダクション品質の LLM アプリを構築できるようにします。

prompt flow を使うことで、以下が可能になります：

- **フローの作成と反復的な開発**
    - LLM、プロンプト、Python コード、その他の[ツール](https://microsoft.github.io/promptflow/concepts/concept-tools.html)を連携させた実行可能な[フロー](https://microsoft.github.io/promptflow/concepts/concept-flows.html)を作成できます。
    - フローのデバッグや反復開発、特に[LLM とのインタラクションのトレーシング](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html)も容易です。
- **フローの品質とパフォーマンスの評価**
    - より大きなデータセットを使ってフローの品質やパフォーマンスを評価できます。
    - テストや評価を CI/CD システムに組み込むことで、フローの品質を担保できます。
- **本番向けのスムーズな開発サイクル**
    - 選択したサービングプラットフォームやアプリケーションのコードベースにフローを容易にデプロイできます。
    - （オプションですが推奨）[Azure AI の Prompt flow](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) クラウド版を活用し、チームで協力して開発できます。

------

## インストール

すぐに始めたい場合は、ビルド済みの開発環境が利用できます。**下のボタンをクリック**してリポジトリを GitHub Codespaces で開き、この README の続きをご覧ください。

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

ローカル環境で始めたい場合は、まずパッケージをインストールします：

Python 環境が必要です。`python>=3.9, <=3.11` を推奨します。

```sh
pip install promptflow promptflow-tools
```

## クイックスタート ⚡

**prompt flow でチャットボットを作成する**

チャット用テンプレートから prompt flow を初期化するコマンドを実行します。`my_chatbot` というフォルダが作成され、必要なファイルが生成されます。

```sh
pf flow init --flow ./my_chatbot --type chat
```

**API キー用のコネクションをセットアップする**

OpenAI キーの場合、`my_chatbot` フォルダ内の `openai.yaml` ファイルを使ってコネクションを作成します（yaml ファイルの変更を避ける場合は --set でキーや名前を上書き指定できます）。

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Azure OpenAI キーの場合は、`azure_openai.yaml` ファイルを使ってコネクションを作成します。

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**フローでチャットする**

`my_chatbot` フォルダ内にある `flow.dag.yaml` ファイルは、入力／出力、ノード、コネクション、LLM モデルなどのフロー構成を定義しています。

> `chat` ノードでは、`connection` フィールドで指定された `open_ai_connection` コネクションと、`deployment_name` フィールドで指定された `gpt-35-turbo` モデルを利用しています。deployment_name フィールドは OpenAI モデルまたは Azure OpenAI デプロイメントリソースを指定します。

以下のコマンドでチャットボットと対話できます（`Ctrl + C` で終了）。

```sh
pf flow test --flow ./my_chatbot --interactive
```

**コアバリュー：「高品質」をプロトタイプから本番まで一貫して保証**

プロンプト調整 ➡ バッチテスト ➡ 評価という一連の流れを体験できる[**15分チュートリアル**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md)もご参照ください。すべて本番品質を保証するための設計です。

次のステップ！**チュートリアル**👇 セクションで prompt flow をさらに深く学びましょう。

## チュートリアル 🏃‍♂️

Prompt flow は **高品質な LLM アプリを構築するためのツール**です。prompt flow の開発プロセスは、フローの開発 → フロー品質の向上 → 本番環境へのデプロイというステップで進みます。

### 独自の LLM アプリを開発する

#### VS Code 拡張機能

UI でインタラクティブにフロー開発ができる VS Code 拡張機能（フローデザイナー）も提供しています。

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

<a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a> からインストールできます。

#### フロー開発をさらに深く学ぶ

[Getting started with prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): 初めてフローを実行するためのステップバイステップガイドです。

### ユースケースから学ぶ

[Tutorial: Chat with PDF](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/e2e-development/chat-with-pdf.md): prompt flow で高品質なチャットアプリを構築するエンドツーエンドチュートリアルです。フロー開発や評価（指標付き）も含まれています。
> 他のサンプルは[こちら](https://microsoft.github.io/promptflow/tutorials/index.html#samples)から参照できます。新たなユースケースの投稿も歓迎します！

### コントリビューター向けセットアップ

コントリビューションに興味がある方は、まず [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md) の開発者セットアップガイドをご覧ください。

次のステップ！**Contributing**👇 セクションで prompt flow への貢献方法を確認しましょう。

## コントリビューション

本プロジェクトはコントリビューションや提案を歓迎しています。ほとんどのコントリビューションには、コントリビューターライセンス契約（CLA）への同意が必要です。詳細は https://cla.opensource.microsoft.com をご覧ください。

Pull Request を送信すると CLA ボットが自動的に CLA 提出の要否を判定し、PR にステータスやコメントを付与します。ボットの指示に従ってください。一度同意すれば、すべての Microsoft CLA 対象リポジトリで有効です。

本プロジェクトは[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/)を採用しています。詳細は [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) または [opencode@microsoft.com](mailto:opencode@microsoft.com) までお問い合わせください。

## 商標について

本プロジェクトには、プロジェクト、製品、サービスの商標やロゴが含まれている場合があります。Microsoft の商標またはロゴの正式な使用は、[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general) に従う必要があります。
本プロジェクトの改変バージョンでの Microsoft 商標やロゴの使用は、混乱を招いたり Microsoft の後援を示唆してはなりません。
サードパーティの商標やロゴの使用は、各サードパーティのポリシーに従ってください。

## 行動規範

本プロジェクトは
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/)
を採用しています。詳細は
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
または [opencode@microsoft.com](mailto:opencode@microsoft.com)
までお問い合わせください。

## データ収集

本ソフトウェアは、設定によってはお客様やお客様の利用状況に関する情報を収集し、Microsoft に送信する場合があります。Microsoft はこの情報をサービス提供や製品・サービスの改善に利用する場合があります。リポジトリ記載の方法でテレメトリを有効化できます。
また、本ソフトウェアには、お客様や Microsoft がアプリケーションのユーザーからデータを収集できる機能も含まれる場合があります。これらの機能を利用する場合、関連法令を遵守し、ユーザーへの適切な通知および Microsoft のプライバシーステートメントの写しを提示してください。プライバシーステートメントは https://go.microsoft.com/fwlink/?LinkID=824704 にあります。データ収集と利用の詳細はヘルプドキュメントおよびプライバシーステートメントをご参照ください。ソフトウェアのご利用により、これらの実践に同意したものとみなされます。

### テレメトリ設定

テレメトリ収集はデフォルトで有効です。

オプトアウトするには、`pf config set telemetry.enabled=false` を実行してください。

## ライセンス

Copyright (c) Microsoft Corporation. All rights reserved.

[MIT](https://raw.githubusercontent.com/microsoft/promptflow/main/LICENSE) ライセンスで提供されています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---