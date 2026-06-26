## <img width=16 src="https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/spectator/src/spectator/internal/assets/lucy_spectator.svg"> Spectator

[![Package Version](https://img.shields.io/hexpm/v/spectator)](https://hex.pm/packages/spectator)
[![Hex Docs](https://img.shields.io/badge/hex-docs-ffaff3)](https://hexdocs.pm/spectator/)

SpectatorはGleamで書かれたBEAMオブザーバーツールで、gleam_otpプロセスと良く連携します。

![](https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/screenshot.png)

## 機能

現在、spectatorは以下の機能を備えています：

- ソート可能なテーブルでプロセスを表示
- 個別プロセスにタグを付けて識別しやすくする
- プロセスの詳細を表示
- OTPプロセスの状態を表示
- OTPプロセスの一時停止／再開
- ETSテーブルの一覧表示
- ETSテーブルの内容表示
- アクティブなポートの一覧表示
- リソース間のクリック可能なリンク
- 基本統計を表示するダッシュボード
- 他のBEAMノードの検査

## 開発環境でSpectatorを使う

プロジェクトの依存関係としてspectatorをインストールし、アプリケーションの一部として実行することで開発中のアプリを検査できます。

```sh
gleam add spectator
```

詳細な手順については、[パッケージのREADME](https://hexdocs.pm/spectator/)を参照してください。

## 本番環境でSpectatorを使用する

Spectatorを単独のアプリケーションとして実行し、アプリケーションが動作しているErlangノードに分散接続することで、デプロイされたアプリケーションのBEAMノードを監視できます。

単独のSpectatorアプリケーションは、`ghcr.io/jonasgruenwald/spectator`のDockerイメージとして、また[リリースページ](https://github.com/JonasGruenwald/spectator/releases)からescriptとして入手可能です。

リポジトリには、[Docker経由でデプロイされたアプリをSpectatorで監視する完全な例](https://github.com/JonasGruenwald/spectator/tree/main/example#readme)が含まれています。

まず、アプリケーションがErlang名とクッキーを設定していることを確認してください。たとえば、アプリケーション開始前に`ERL_FLAGS`環境変数を設定する方法があります。

```sh
ERL_FLAGS="-name myapp@host -setcookie mycookie"
```

もしアプリケーションがDockerコンテナで実行されている場合、アプリケーションのコンテナとspectatorを実行しているコンテナを同じDockerネットワークに配置し、アプリケーションのコンテナのホスト名を把握している値に設定してください。

spectatorを起動し、アプリケーションの右上にある「Change Target」をクリックします。

調査したいノードの詳細を入力します。名前は `-sname` で設定した名前に続けて `@` とホスト名を入力してください。

最後に「Connect」をクリックして、アプリケーションノードを調査します。

対象のノードにはspectatorと同じErlangのクッキーが設定されている必要があります。アプリケーションと同様に、spectatorのクッキーは `ERL_FLAGS` 環境変数で設定可能です。例：`ERL_FLAGS="-name spectator@127.0.0.1 -setcookie mycookie"`。

## 注意点

spectatorを実行する際には以下の点にご注意ください：

- **Spectatorはシステムを遅くする可能性があります**  
  表示される全てのプロセスは、Erlangの `process_info/2` 関数を使用して設定された間隔で調査されます。この関数は調査対象プロセスに一時的なロックをかけます。もしプロセスが大量のメッセージを処理している場合、システムのパフォーマンスに影響を与える可能性があります。

- **Spectatorは動的にアトムを生成します**  
  他のErlangノードに接続する際、spectatorは提供されたノード名をアトムに変換する必要があります。そのため、ユーザーインターフェースを通じてspectatorを操作すると、アトムはガベージコレクションされないため、BEAMインスタンスのメモリを枯渇させる可能性があります。

- **Spectatorにはアクセス制御が含まれていません**  
  spectatorは、検査対象のランタイムに関する機密情報をウェブインターフェースを通じて公開し、現在アクセス制御を行っていません。  
  本番環境でspectatorを使用する場合は、自身でセキュリティを確保する責任があります。spectatorをインターネットに公開しないようにしてください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---