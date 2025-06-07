<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>あらゆる用途に対応した、高速かつモジュール型のLightning Network実装（Rust製）。</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">プロジェクトホームページ</a>
  </h4>
</div>

## クレート

現在サポートされているクレートの完全なリストは以下の通りです：

| クレート       | 説明                                   | バージョン     |
|:------------|:---------------------------------------------:|------------:|
| lampod-cli  | Lampoデーモンを実行するためのコマンドラインインターフェース | _未対応_ |
| lampo-cli   | デーモンとやりとりするためのシンプルなLampoコマンドラインインターフェース | _未対応_ |

## インストール方法

すべての要件とLampoバイナリをインストールするには、Rustをインストールした上で、以下のコマンドを実行してください：

```
make install
```

`lampod-cli`と`lampo-cli`が利用可能になったら、次のコマンドでsignetモードでLampoを起動できます：

```
➜  ~ lampod-cli --network signet
✓ ウォレットが生成されました。以下の単語を安全な方法で保管してください
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
ウォレットの単語を必ず保存してください。`--restore-wallet`を使ってウォレットを復元する際に必要です。
単語をどこにも保存しない場合、Lampoを次回起動した際に資金が失われます！

`lampo.conf`が`~/.lampo/signet`パスに存在する必要があります。サンプル設定ファイルを使用する場合は、以下のコマンドを実行してください：

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

その後、次のコマンドでノード情報を取得できます：

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Core Lightningとの統合テストを実行するには

Core Lightningを開発者モードでビルドしておく必要があります。インストールガイドは[こちら](https://docs.corelightning.org/docs/installation)をご参照ください。

統合テストは以下のコマンドで実行できます：

```
make integration
```

## コントリビューションガイドライン

[コントリビューションガイド](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md)をお読みください。

## コミュニティ

明瞭な運営のため、以下の特定のチャンネルを設けています：
- 開発者の方は[Zulip](https://lampo-dev.zulipchat.com/)へご参加ください。
- コミュニティメンバーの皆さまは[Twitterコミュニティ](https://twitter.com/i/communities/1736414802849706087)へどうぞ。
- 技術的な質問や機能要望はGitHub Discussionsで受け付けています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---