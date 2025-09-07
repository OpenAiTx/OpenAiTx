# Foca: あなたの条件でのクラスタメンバーシップ発見

Focaは、あなたのゴシップベースのクラスタ検出のためのビルディングブロックです。  
これは小さな`no_std` + `alloc`クレートで、SWIMプロトコルとその有用な拡張（`SWIM+Inf.+Susp.`）を実装しています。

プロジェクト:

* Gitリポジトリ: https://caio.co/de/foca/
* イシュートラッカー: https://github.com/caio/foca/issues
* CI: https://github.com/caio/foca/actions/workflows/ci.yml
* パッケージ: https://crates.io/crates/foca
* ドキュメント: https://docs.rs/foca


# はじめに

Focaの最も注目すべき点は、ほとんど何もしないという事実です。  
初期状態で提供するのは、[SWIMプロトコル][1]の信頼性が高く効率的な実装だけで、  
トランスポートや識別に依存しません。

SWIMの仕組みを知っていると便利ですが、このライブラリを使うのに必須ではありません。  
`Message`列挙型のドキュメントを読むことでプロトコルの概要は掴めますが、論文も非常に読みやすいです。

Focaはあらゆる種類のトランスポートに適合するよう設計されています。  
ネットワークがピア同士の通信を許すなら、どこにでもFocaを展開できます。  
一般的な帯域幅の要件が低いだけでなく、メンバーの識別方法（`./examples/identity_golf.rs`を参照）や  
メッセージのエンコード方法を完全に制御できます。


# 使用方法

`./examples/foca_insecure_udp_agent.rs`をご覧ください。  
これはシンプルなtokioベースのエージェントがどのようなものかを示し、  
実際にFocaが動作する様子を体験できます。






~~~
$ cargo run --features std,tracing,bincode-codec --example foca_insecure_udp_agent -- --help
foca_insecure_udp_agent 

USAGE:
    foca_insecure_udp_agent [OPTIONS] <BIND_ADDR>

FLAGS:
    -h, --help       ヘルプ情報を表示
    -V, --version    バージョン情報を表示

OPTIONS:
    -a, --announce <announce>    参加する他のFocaインスタンスのアドレス
    -f, --filename <filename>    すべてのアクティブメンバーを含むファイル名
    -i, --identity <identity>    クラスターのメンバーがあなたに話すために使用するアドレス。
                                 デフォルトはBIND_ADDR

ARGS:
    <BIND_ADDR>    バインドするソケットアドレス。例: 127.0.0.1:8080
~~~

一つのターミナルでエージェントを
`./foca_insecure_udp_agent 127.0.0.1:8000` と起動し、
異なる `BIND_ADDR` と `--announce` を使って
動作中のインスタンスに参加させることができます。
例：
`./foca_insecure_udp_agent 127.0.0.1:8001 -a 127.0.0.1:8000`。

エージェントは [tracing][] のサブスクライバーを通じて
コンソールに情報を出力します。デフォルトのログレベルは `INFO` で、
`RUST_LOG` 環境変数を使用して
[tracing_subscriberのEnvFilterディレクティブ][dir]により
カスタマイズ可能です。


## Cargo Features

すべての機能はオプションです。`default` セットは常に空です。

* `std`: `std::net::SocketAddr*` 用の `foca::Identity` を実装し、
  `Config::new_lan` と `Config::new_wan` を公開します。
* `tracing`: [tracing][] クレートを使用して Foca に計測を施します。ハイレベル
  プロトコルのやり取りは `DEBUG` トレースとして出力され、より詳細は `TRACE` レベルで表示されます。その他のレベルは出力されません。
* `serde`: Foca の公開型に対して `Serialize` と `Deserialize` を派生させます。
* `bincode-codec`: 内部で [bincode][] を使用する serde ベースのコーデック型 `BincodeCodec` を提供します。
* `postcard-codec`: 内部で [postcard][] を使用する serde ベースの `no_std` 対応コーデック `PostcardCodec` を提供します。
* `unstable-notifications`: 送受信されるメッセージの検査を可能にする新しい通知を提供します。


# 注意事項

このライブラリを作成する際の主な目標は、テストやシミュレーション、理解が容易なシンプルかつ小さなコアを持つことでした。論文を読んだ後にプロトコルをよりよく理解することが主な目的でした。

これらの目標に固執した結果、ハードウェアクロック、アトミック操作、スレッドなど多くのOS機能に依存しない実装となり、`no_std` クレート（ただしヒープ割り当ては必要）になるという偶然の良い特徴を持つことになり、それを採用することにしました。


## memberlist との比較

自身の実装に満足するまで [memberlist][2] は見ないようにしていました。その後、ざっとだけ確認しました：

* memberlist はカスタムブロードキャストをサポートしており、複雑なサービスディスカバリーシナリオに非常に便利な機能です。Foca もユーザーデータの伝播をサポートするようになりました（`BroadcastHandler` のドキュメント参照） :-)

* メンバー間の参加と定期的な状態マージに使用されるストリームベースの同期機構（プッシュプル）を持っています。これは Foca の責任範囲をはるかに超えていますが非常に興味深いアイデアなので、コードを可能にする `Foca::apply_many` メソッドを公開しています。



















  必要に応じて、同様のことを行うためにFocaを使用します。

* その設定パラメータは（現在の）クラスタサイズに基づいて変わります。ユーザーは `Config::new_{lan,wan}` と
  `Foca::set_config` を組み合わせて同様のことを実現できます。

# 参考文献

* 論文 [SWIM: Scalable Weakly-consistent Infection-style Process Group Membership
Protocol][1]
* HashiCorpの [memberlist][2]

[1]: https://www.cs.cornell.edu/projects/Quicksilver/public_pdfs/SWIM.pdf
[2]: https://github.com/hashicorp/memberlist
[bincode]: https://github.com/bincode-org/bincode
[postcard]: https://github.com/jamesmunns/postcard
[tracing]: https://docs.rs/tracing/latest/tracing/
[dir]: https://docs.rs/tracing-subscriber/0.3.17/tracing_subscriber/filter/struct.EnvFilter.html#directives

# ライセンス

特に明記されていない限り、すべての作品はMozilla Public License バージョン2.0の
条項に従います。

`examples/` ディレクトリ内のファイルはパブリックドメインに捧げられています。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-07

---