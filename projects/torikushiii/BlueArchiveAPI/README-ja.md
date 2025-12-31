
# ブルーアーカイブAPI

## *このAPIはブルーアーカイブのグローバル版および日本版のデータを提供します。*

- [ブルーアーカイブEN](https://bluearchive.nexon.com/home): 公式ENサイト
- [ブルーアーカイブJP](https://bluearchive.jp/): 公式JPサイト

ゲーム「ブルーアーカイブ」から様々なデータを提供するAPIです。このプロジェクトに貢献したい場合は、プルリクエストやイシューを自由に開いてください。サポートしたい方は、私の[Ko-Fi](https://ko-fi.com/torikushiii)に寄付も可能です。

**ホストされているAPI：https://api.ennead.cc/buruaka**

## 必要条件

- [Go](https://go.dev/dl/): バージョン1.24以上
- APIからアクセス可能なMongoDBインスタンス（デフォルトのURIは`mongodb://localhost:27017`）

## 設定

実行時オプションはYAMLファイルから読み込みます。デフォルトではプロジェクトルートの`config.yaml`を読み込みます。必要に応じて`CONFIG_PATH`環境変数を設定し、別の設定ファイルを指定してください。

ローカルのデフォルト設定に合った例は`config.yaml`を参照してください。

## APIの起動

依存関係をビルドし、Goでサーバーを起動します：

```bash
go run ./cmd/server
```

リスナーのアドレスは設定によって制御されます（デフォルトは `0.0.0.0:9999`）。すべてのRESTエンドポイントは `/buruaka` ベースパスの下で提供されます（例：`/buruaka/character`）、サーバーは設定されたURIを使ってMongoDBに接続し、キャラクター、レイド、バナーデータを提供します。

スタンドアロンバイナリを生成するには：

```bash
go build -o server ./cmd/server
```

テストを実行するには：

```bash
go test ./...
```

## REST API ドキュメント

エンドポイントの詳細は[docs](https://github.com/torikushiii/BlueArchiveAPI/tree/main/docs)フォルダにあります。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---