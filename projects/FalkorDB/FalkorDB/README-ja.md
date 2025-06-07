[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - GraphRAG & GenAIのためのグラフデータベース

リアルタイムまたはインタラクティブ環境で構造化・非構造化された相互接続データを管理する開発チーム向けに設計された、スケーラブルかつ低遅延のグラフデータベースです。

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## 独自の特徴

私たちの目標は、大規模言語モデル（LLM）向けに最適化された高性能なナレッジグラフを構築し、グラフデータベースを通じて極めて低いレイテンシで迅速かつ効率的な情報提供を実現することです。

🆕 [FalkorDB](https://www.falkordb.com/) は、**グラフ内の[隣接行列](https://en.wikipedia.org/wiki/Adjacency_matrix)の表現にスパース行列を活用し、クエリに[線形代数](https://en.wikipedia.org/wiki/Adjacency_matrix)を用いる最初のクエリ可能な[プロパティグラフ](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc)データベース**です。

### 主な特徴

* **スパース行列表現**: 隣接行列をスパース行列で表現し、ストレージとパフォーマンスを最適化します。

* **線形代数によるクエリ**: クエリの実行に線形代数を用い、計算効率を向上させます。

* **プロパティグラフモデル準拠**: ノードとリレーションシップに属性を持たせ、プロパティグラフモデルに準拠しています。

* **OpenCypherサポート**: [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) クエリ言語に対応し、高度なクエリ機能のための独自拡張も含みます。

> FalkorDBの動作例は [デモ](https://github.com/FalkorDB/FalkorDB/tree/master/demo) でご覧いただけます。

## ドキュメント

[公式ドキュメント](https://docs.falkordb.com/) | [クライアント](https://docs.falkordb.com/clients.html) | [コマンド](https://docs.falkordb.com/commands/) | 📊 [最新パフォーマンスベンチマーク](https://benchmark.falkordb.com/)

### コミュニティとサポート

* **ディスカッション**: [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions)でコミュニティディスカッションに参加し、質問やアイディアの共有、他のユーザーとの交流ができます。

* **コントリビュート**: 貢献を歓迎します！詳細は [Contributing Guide](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) をご覧ください。

* **ライセンス**: 本プロジェクトはServer Side Public License v1 (SSPLv1)の下でライセンスされています。詳細は [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) をご確認ください。

## はじめよう

### ステップ1

FalkorDBをすぐに試すには、dockerでインスタンスを起動してください:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

または、ブラウザベースのインターフェースを使用する場合は:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### ステップ2

次に、ブラウザで `http://localhost:3000` にアクセスしてください。

また、サポートされているいずれかの[クライアントライブラリ](https://docs.falkordb.com/clients.html)を使用してFalkorDBと対話することもできます。

### MotoGPリーグ例

この例では、[FalkorDB Pythonクライアント](https://pypi.org/project/FalkorDB/)を使用して、MotoGPリーグに参加するバイクライダーとチームのサブセットを表す小さなグラフを作成します。グラフを作成した後、その構造や関係性をクエリして探索します。

```python
from falkordb import FalkorDB

# FalkorDBに接続
db = FalkorDB(host='localhost', port=6379)

# 'MotoGP'グラフを作成
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Yamahaを代表するライダーは？
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# 出力: "Valentino Rossi"

# Ducatiチームを代表するライダーは何人？
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# 出力: 1
```

## 開発を始める

### ビルド方法

以下を完了してください:

1️⃣ FalkorDBリポジトリを取得します: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

> Ubuntu Linuxでは、`apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip` を実行してください。
	
> OS Xの場合、`homebrew`がインストールされていることを確認し、`brew install cmake m4 automake peg libtool autoconf` を実行してください。  
>> OS Xツールチェーンに含まれるClangのバージョンはOpenMPをサポートしていません（FalkorDBの必須要件）。これを解決するには `brew install gcc g++` を実行し、表示される手順に従ってシンボリックリンクを更新してください。これはシステム全体の変更です。`CC`と`CXX`環境変数を設定する方法もあります。

2️⃣ プロジェクトディレクトリで `make` を実行してビルドします。

ビルドが完了したら、`bin/<arch>/src/falkordb.so` にバイナリが生成されます。

### テストの実行

```tests``` ディレクトリで ```pip install -r requirements.txt``` を実行し、必要なPythonパッケージをインストールします。

> 注意: ```redis-server``` がPATHにある場合は、```make test``` を実行するだけです。そうでない場合は ```REDIS_SERVER=<redis-server-location> make test``` を実行してください。詳細な出力が必要な場合は ```make test V=1``` を実行してください。

### dockerでのビルド

FalkorDBのビルドシステムはdocker内で動作します。詳細な手順は[こちら](https://docs.falkordb.com/docker-examples/README.html)をご参照ください。

## REDISへのFALKORDBのロード

FalkorDBは[Redis](https://redis.io)上で動作するため、最初にモジュールとしてRedisサーバーに読み込む必要があります。
> 注意: FalkorDB 2.12には[Redis 6.2](https://redis.io/download)が必要です。

💡 Redis起動時にFalkorDBを自動的に読み込むには、redis.confファイルに以下を追記してください:

```
loadmodule /path/to/module/src/falkordb.so
```

上記の`/path/to/module/src/falkordb.so`は、実際のFalkorDBライブラリのパスに置き換えてください。  
Redisをサービスとして実行している場合、`redis`ユーザー（デフォルト）が`falkordb.so`にアクセスできるよう、必要なファイル/フォルダ権限を付与してください。

または、以下のコマンドライン引数でFalkorDBを読み込むこともできます:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

最後に、[`MODULE LOAD`](http://redis.io/commands/module-load) コマンドも利用可能です。ただし、`MODULE LOAD`は危険なコマンドであり、将来的にセキュリティの観点からブロックまたは非推奨になる可能性があります。

FalkorDBが正常にロードされると、Redisログに以下のような出力が表示されます:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

もしサーバーの起動時に次のような出力で失敗した場合:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

これは実行時依存ライブラリOpenMPが不足している状態です。Ubuntuでは `apt-get install libgomp1`、RHEL/CentOSでは `yum install libgomp`、OSXでは `brew install libomp` でインストールできます。

## FALKORDBの利用方法

どのRedisクライアントからもFalkorDBのコマンドを呼び出せます。方法の例をいくつか示します。

### `redis-cli`を使う場合

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### その他のクライアント

お使いのクライアントで生のRedisコマンド送信機能を利用してFalkorDBと対話できます。

> 注意: クライアントによって送信方法が異なる場合があります。

#### 例: PythonクライアントからFalkorDBを利用

このコードスニペットは、Pythonで [falkordb-py](https://github.com/FalkorDB/falkordb-py) を使ったFalkorDB利用例です。

```Python
from falkordb import FalkorDB

# FalkorDBに接続
db = FalkorDB(host='localhost', port=6379)

# socialグラフを選択
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## クライアントライブラリ

> 注意: 一部言語にはFalkorDBコマンドをサポートするクライアントライブラリがあります。

### 公式クライアント


| プロジェクト                                                   | 言語      | ライセンス | 作者                                      | スター                                                             | パッケージ | コメント    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |


### サードパーティクライアント

| プロジェクト                                                   | 言語      | ライセンス | 作者                                      | スター                                                             | パッケージ | コメント    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [nredisstack][nredisstack-url] | .NET | MIT | [Redis][redis-url] | [![nredisstack-stars]][nredisstack-url] | [nuget][nredisstack-package]||
| [redisgraph-rb][redisgraph-rb-url]                        | Ruby       | BSD     | [Redis][redisgraph-rb-author]          | [![redisgraph-rb-stars]][redisgraph-rb-url]                       | [GitHub][redisgraph-rb-url] ||
| [redgraph][redgraph-url]                                  | Ruby       | MIT     | [pzac][redgraph-author]                | [![redgraph-stars]][redgraph-url]                                 | [GitHub][redgraph-url] ||
| [redisgraph-go][redisgraph-go-url]                        | Go         | BSD     | [Redis][redisgraph-go-author]          | [![redisgraph-go-stars]][redisgraph-go-url]                       | [GitHub][redisgraph-go-url]||
| [rueidis][rueidis-url]                                    | Go         | Apache 2.0 | [Rueian][rueidis-author]          | [![rueidis-stars]][rueidis-url]                       | [GitHub][rueidis-url] ||
| [ioredisgraph][ioredisgraph-url]                          | JavaScript | ISC     | [Jonah][ioredisgraph-author]                | [![ioredisgraph-stars]][ioredisgraph-url]                         | [GitHub][ioredisgraph-url] ||
| [@hydre/rgraph][rgraph-url]                               | JavaScript | MIT     | [Sceat][rgraph-author]                      | [![rgraph-stars]][rgraph-url]                                     | [GitHub][rgraph-url] ||
| [php-redis-graph][php-redis-graph-url]                    | PHP        | MIT     | [KJDev][php-redis-graph-author]             | [![php-redis-graph-stars]][php-redis-graph-url]                   | [GitHub][php-redis-graph-url] ||
| [redisgraph_php][redisgraph_php-url]                      | PHP        | MIT     | [jpbourbon][redisgraph_php-author]          | [![redisgraph_php-stars]][redisgraph_php-url]                     | [GitHub][redisgraph_php-url] ||
| [redisgraph-ex][redisgraph-ex-url]                        | Elixir     | MIT     | [crflynn][redisgraph-ex-author]             | [![redisgraph-ex-stars]][redisgraph-ex-url]                       | [GitHub][redisgraph-ex-url] ||
| [redisgraph-rs][redisgraph-rs-url]                        | Rust       | MIT     | [malte-v][redisgraph-rs-author]             | [![redisgraph-rs-stars]][redisgraph-rs-url]                       | [GitHub][redisgraph-rs-url] ||
| [redis_graph][redis_graph-url]                            | Rust       | BSD     | [tompro][redis_graph-author]                | [![redis_graph-stars]][redis_graph-url]                           | [GitHub][redis_graph-url] ||
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Documentation](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
| [NRedisGraph][NRedisGraph-url]                            | C#         | BSD     | [tombatron][NRedisGraph-author]             | [![NRedisGraph-stars]][NRedisGraph-url]                           | [GitHub][NRedisGraph-url] ||
| [RedisGraph.jl][RedisGraph.jl-url]                        | Julia      | MIT     | [xyxel][RedisGraph.jl-author]               | [![RedisGraph.jl-stars]][RedisGraph.jl-url]                       | [GitHub][RedisGraph.jl-url] ||

[redis-url]: https://redis.com
[falkordb-url]: https://www.falkordb.com

[falkordb-py-url]: http://github.com/falkorDB/falkordb-py
[falkordb-py-stars]: https://img.shields.io/github/stars/falkorDB/falkordb-py.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-py-package]: https://pypi.org/project/FalkorDB

[jfalkordb-url]: https://github.com/falkordb/jfalkordb
[jfalkordb-stars]: https://img.shields.io/github/stars/falkordb/jfalkordb.svg?style=social&amp;label=Star&amp;maxAge=2592000
[jfalkordb-package]: https://search.maven.org/artifact/com.falkordb/jfalkordb

[nfalkordb-url]: https://github.com/falkordb/NFalkorDB
[nfalkordb-stars]: https://img.shields.io/github/stars/falkordb/nfalkordb.svg?style=social&label=Star&maxAge=2592000
[nfalkordb-package]: https://www.nuget.org/packages/NFalkorDB

[nredisstack-url]: https://github.com/redis/nredisstack
[nredisstack-stars]: https://img.shields.io/github/stars/redis/nredisstack.svg?style=social&amp;label=Star&amp;maxAge=2592000
[nredisstack-package]: https://www.nuget.org/packages/nredisstack/

[falkordb-ts-url]: https://github.com/falkordb/falkordb-ts
[falkordb-ts-stars]: https://img.shields.io/github/stars/falkordb/falkordb-ts.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-ts-package]: https://www.npmjs.com/package/falkordb

[falkordb-rs-url]: https://github.com/falkordb/falkordb-rs
[falkordb-rs-stars]: https://img.shields.io/github/stars/falkordb/falkordb-rs.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-rs-package]: https://crates.io/crates/falkordb

[falkordb-go-url]: https://github.com/falkordb/falkordb-go
[falkordb-go-stars]: https://img.shields.io/github/stars/falkordb/falkordb-go.svg?style=social&amp;label=Star&amp;maxAge=2592000
[falkordb-go-package]: https://github.com/falkordb/falkordb-go

[redisgraph-rb-author]: https://redislabs.com
[redisgraph-rb-url]: https://github.com/RedisGraph/redisgraph-rb
[redisgraph-rb-stars]: https://img.shields.io/github/stars/RedisGraph/redisgraph-rb.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redgraph-author]: https://github.com/pzac
[redgraph-url]: https://github.com/pzac/redgraph
[redgraph-stars]: https://img.shields.io/github/stars/pzac/redgraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph-go-author]: https://redislabs.com
[redisgraph-go-url]: https://github.com/RedisGraph/redisgraph-go
[redisgraph-go-stars]: https://img.shields.io/github/stars/RedisGraph/redisgraph-go.svg?style=social&amp;label=Star&amp;maxAge=2592000

[rueidis-url]: https://github.com/rueian/rueidis
[rueidis-author]: https://github.com/rueian
[rueidis-stars]: https://img.shields.io/github/stars/rueian/rueidis.svg?style=social&amp;label=Star&amp;maxAge=2592000


[rgraph-author]: https://github.com/Sceat
[rgraph-url]: https://github.com/HydreIO/rgraph
[rgraph-stars]: https://img.shields.io/github/stars/HydreIO/rgraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[ioredisgraph-author]: https://github.com/Jonahss
[ioredisgraph-url]: https://github.com/Jonahss/ioredisgraph
[ioredisgraph-stars]: https://img.shields.io/github/stars/Jonahss/ioredisgraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[php-redis-graph-author]: https://github.com/kjdev
[php-redis-graph-url]: https://github.com/kjdev/php-redis-graph
[php-redis-graph-stars]: https://img.shields.io/github/stars/kjdev/php-redis-graph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph_php-author]: https://github.com/jpbourbon
[redisgraph_php-url]: https://github.com/jpbourbon/redisgraph_php
[redisgraph_php-stars]: https://img.shields.io/github/stars/jpbourbon/redisgraph_php.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redislabs-redisgraph-php-author]: https://github.com/mkorkmaz
[redislabs-redisgraph-php-url]: https://github.com/mkorkmaz/redislabs-redisgraph-php
[redislabs-redisgraph-php-stars]: https://img.shields.io/github/stars/mkorkmaz/redislabs-redisgraph-php.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph-ex-author]: https://github.com/crflynn
[redisgraph-ex-url]: https://github.com/crflynn/redisgraph-ex
[redisgraph-ex-stars]: https://img.shields.io/github/stars/crflynn/redisgraph-ex.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redisgraph-rs-author]: https://github.com/malte-v
[redisgraph-rs-url]: https://github.com/malte-v/redisgraph-rs
[redisgraph-rs-stars]: https://img.shields.io/github/stars/malte-v/redisgraph-rs.svg?style=social&amp;label=Star&amp;maxAge=2592000

[redis_graph-author]: https://github.com/tompro
[redis_graph-url]: https://github.com/tompro/redis_graph
[redis_graph-stars]: https://img.shields.io/github/stars/tompro/redis_graph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[NRedisGraph-author]: https://github.com/tombatron
[NRedisGraph-url]: https://github.com/tombatron/NRedisGraph
[NRedisGraph-stars]: https://img.shields.io/github/stars/tombatron/NRedisGraph.svg?style=social&amp;label=Star&amp;maxAge=2592000

[RedisGraphDotNet.Client-author]: https://github.com/Sgawrys
[RedisGraphDotNet.Client-url]: https://github.com/Sgawrys/RedisGraphDotNet.Client
[RedisGraphDotNet.Client-stars]: https://img.shields.io/github/stars/Sgawrys/RedisGraphDotNet.Client.svg?style=social&amp;label=Star&amp;maxAge=2592000

[RedisGraph.jl-author]: https://github.com/xyxel
[RedisGraph.jl-url]: https://github.com/xyxel/RedisGraph.jl
[RedisGraph.jl-stars]: https://img.shields.io/github/stars/xyxel/RedisGraph.jl.svg?style=social&amp;label=Star&amp;maxAge=2592000

[rustis-url]: https://github.com/dahomey-technologies/rustis
[rustis-author]: https://github.com/dahomey-technologies
[rustis-stars]: https://img.shields.io/github/stars/dahomey-technologies/rustis.svg?style=social&amp;label=Star&amp;maxAge=2592000

## ライセンス

Server Side Public License v1 (SSPLv1)の下でライセンスされています。[LICENSE](LICENSE.txt) をご確認ください。

### 私たちの活動をサポートしてください

⭐️ このリポジトリが役立った場合は、ぜひStarしてください！

↗️ グラフ、グラフデータベース、RAG、graphrag、検索拡張生成、情報検索、自然言語処理、LLM、埋め込み、セマンティックサーチ

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---