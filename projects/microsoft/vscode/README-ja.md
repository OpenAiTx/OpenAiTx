# Visual Studio Code - オープンソース ("Code - OSS")

[![機能リクエスト](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![バグ](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## リポジトリについて

このリポジトリ（"`Code - OSS`"）は、私たち（Microsoft）がコミュニティと共に[Visual Studio Code](https://code.visualstudio.com)製品を開発している場所です。ここではコードや課題に取り組むだけでなく、[ロードマップ](https://github.com/microsoft/vscode/wiki/Roadmap)、[月次イテレーションプラン](https://github.com/microsoft/vscode/wiki/Iteration-Plans)、[エンドゲームプラン](https://github.com/microsoft/vscode/wiki/Running-the-Endgame)も公開しています。このソースコードは標準的な[MITライセンス](https://github.com/microsoft/vscode/blob/main/LICENSE.txt)の下、誰でも利用できます。

## Visual Studio Code

<p align="center">
  <img alt="VS Code in action" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com)は、Microsoftが独自のカスタマイズを施し、従来の[Microsoft製品ライセンス](https://code.visualstudio.com/License/)の下でリリースしている `Code - OSS` リポジトリのディストリビューションです。

[Visual Studio Code](https://code.visualstudio.com)は、コードエディターのシンプルさと、開発者がエディット・ビルド・デバッグのサイクルに必要な機能を兼ね備えています。包括的なコード編集、ナビゲーション、理解サポートに加え、軽量なデバッグ、豊富な拡張モデル、既存ツールとの軽量な統合を提供します。

Visual Studio Codeは毎月新機能やバグ修正とともに更新されます。[Visual Studio Code公式サイト](https://code.visualstudio.com/Download)からWindows、macOS、Linux用をダウンロードできます。毎日の最新版を利用したい場合は、[Insidersビルド](https://code.visualstudio.com/insiders)をインストールしてください。

## コントリビューション

このプロジェクトには、例えば以下のように様々な方法で参加できます：

* [バグや機能リクエストの送信](https://github.com/microsoft/vscode/issues)、またそれらの検証への協力
* [ソースコード変更のレビュー](https://github.com/microsoft/vscode/pulls)
* [ドキュメント](https://github.com/microsoft/vscode-docs)の見直しや、誤字修正から新規コンテンツ追加までのプルリクエスト

問題の修正やコードベースへの直接的な貢献に興味がある方は、
[コントリビューションガイド](https://github.com/microsoft/vscode/wiki/How-to-Contribute)を参照してください。そこでは以下について説明しています：

* [ソースからのビルドと実行方法](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [デバッグやテスト実行を含む開発ワークフロー](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [コーディングガイドライン](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [プルリクエストの提出方法](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [取り組むべき課題の見つけ方](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [翻訳への貢献](https://aka.ms/vscodeloc)

## フィードバック

* [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)で質問する
* [新機能をリクエストする](CONTRIBUTING.md)
* [人気の機能リクエストに投票する](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Issueを報告する](https://github.com/microsoft/vscode/issues)
* [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions)や[Slack](https://aka.ms/vscode-dev-community)で拡張機能作者コミュニティと交流する
* [@code](https://twitter.com/code)をフォローして、ご意見をお聞かせください！

これら各チャンネルの説明や、他のコミュニティ主導チャンネルについては[Wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels)をご覧ください。

## 関連プロジェクト

VS Codeのコアコンポーネントや拡張機能の多くは、それぞれ独自のGitHubリポジトリに存在します。例えば、[node debug adapter](https://github.com/microsoft/vscode-node-debug)や[mono debug adapter](https://github.com/microsoft/vscode-mono-debug)リポジトリなどです。完全なリストについては、[Wiki](https://github.com/microsoft/vscode/wiki)内の[関連プロジェクト](https://github.com/microsoft/vscode/wiki/Related-Projects)ページをご覧ください。

## バンドル拡張機能

VS Codeには、[extensions](extensions)フォルダーに配置された一連の組み込み拡張機能が含まれており、多くの言語向けの文法やスニペットも含まれています。ある言語の豊富な言語サポート（コード補完、定義へ移動など）を提供する拡張機能には、`language-features`というサフィックスが付いています。例えば、`json`拡張機能は`JSON`のカラーリングを提供し、`json-language-features`拡張機能は`JSON`の豊富な言語サポートを提供します。

## 開発用コンテナ

このリポジトリには、Visual Studio Code Dev Containers / GitHub Codespaces用の開発コンテナが含まれています。

* [Dev Containers](https://aka.ms/vscode-remote/download/containers)の場合、**Dev Containers: Clone Repository in Container Volume...** コマンドを使用してください。これはmacOSやWindowsでより良いディスクI/OのためにDockerボリュームを作成します。
  * すでにVS CodeとDockerがインストールされている場合は、[こちら](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode)をクリックして始められます。必要に応じてVS Codeが自動的にDev Containers拡張機能をインストールし、ソースコードをコンテナボリュームにクローンして、開発コンテナを起動します。

* Codespacesの場合、VS Codeに[GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces)拡張機能をインストールし、**Codespaces: Create New Codespace** コマンドを使用してください。

Docker／Codespaceは、フルビルドを実行するために**最低4コアおよび6GBのRAM（8GB推奨）**が必要です。詳細は[development container README](.devcontainer/README.md)をご覧ください。

## 行動規範

本プロジェクトは[Microsoft オープンソース行動規範](https://opensource.microsoft.com/codeofconduct/)を採用しています。詳細は[行動規範FAQ](https://opensource.microsoft.com/codeofconduct/faq/)をご覧いただくか、追加の質問やコメントは[opencode@microsoft.com](mailto:opencode@microsoft.com)までご連絡ください。

## ライセンス

Copyright (c) Microsoft Corporation. All rights reserved.

[MIT](LICENSE.txt)ライセンスの下でライセンスされています。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---