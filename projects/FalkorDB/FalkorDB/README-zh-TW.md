[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - 用於 GraphRAG 與 GenAI 的圖形資料庫

一個可擴展、低延遲的圖形資料庫，專為在即時或互動式環境中管理結構化與非結構化關聯資料的開發團隊設計。

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## 獨特功能

我們的目標是打造一個高效能的知識圖譜，專為大型語言模型（LLM）量身定制，並以極低延遲為首要考量，確保通過我們的圖形資料庫能快速有效地傳遞資訊。

🆕 [FalkorDB](https://www.falkordb.com/) 是首個**可查詢的 [屬性圖（Property Graph）](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) 資料庫，利用稀疏矩陣來表示圖的 [鄰接矩陣](https://en.wikipedia.org/wiki/Adjacency_matrix) 並以[線性代數](https://en.wikipedia.org/wiki/Adjacency_matrix)進行查詢。**

### 主要特點

* **稀疏矩陣表示法**：使用稀疏矩陣表示鄰接矩陣，優化儲存與效能。

* **線性代數查詢**：利用線性代數執行查詢，提高計算效率。

* **符合屬性圖模型**：支援具有屬性的節點與關係，完全遵循屬性圖模型。

* **支援 OpenCypher**：相容於 [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) 查詢語言，並包含專有擴展以支援進階查詢能力。

>前往 [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo) 了解 FalkorDB 的實際應用。

## 文件資源

[官方文件](https://docs.falkordb.com/) | [客戶端](https://docs.falkordb.com/clients.html) | [指令集](https://docs.falkordb.com/commands/) | 📊 [最新效能基準](https://benchmark.falkordb.com/)

### 社群與支援

* **討論區**：歡迎加入我們的 [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) 社群，提問、分享想法並與其他用戶互動。

* **貢獻指南**：歡迎貢獻！詳情請參閱 [貢獻指南](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md)。

* **授權條款**：本專案採用 Server Side Public License v1 (SSPLv1)。詳情請參閱 [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) 檔案。

## 快速開始

### 步驟 1

快速體驗 FalkorDB，可透過 docker 啟動一個執行實例：

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

若要使用內建的瀏覽器介面，請執行：

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### 步驟 2

然後，打開瀏覽器並前往 `http://localhost:3000`。

你也可以使用任一支援的 [客戶端程式庫](https://docs.falkordb.com/clients.html) 與 FalkorDB 互動。

### MotoGP 聯盟範例

在此範例中，我們將使用 [FalkorDB Python 客戶端](https://pypi.org/project/FalkorDB/) 建立一個小型圖譜，表示參加 MotoGP 聯盟的部分摩托車車手與車隊。建立圖譜後，我們將查詢資料以探索其結構與關係。

```python
from falkordb import FalkorDB

# 連線至 FalkorDB
db = FalkorDB(host='localhost', port=6379)

# 創建 'MotoGP' 圖譜
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# 查詢哪些車手代表 Yamaha？
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# 輸出: "Valentino Rossi"

# 查詢有多少車手代表 Ducati 車隊？
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# 輸出: 1
```

## 開始開發

### 編譯

請確保完成以下需求：

1️⃣ FalkorDB 原始碼庫：`git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>在 Ubuntu Linux 上，執行：`apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>在 OS X 上，請確認已安裝 `homebrew`，並執行：`brew install cmake m4 automake peg libtool autoconf`。
>>OS X 工具鏈內建的 Clang 版本不支援 OpenMP，而這是 FalkorDB 的必要條件。解決方式之一是執行 `brew install gcc g++`，並依照畫面指示更新符號連結。請注意這會影響整個系統——若不想這樣，可以僅設定 `CC` 與 `CXX` 環境變數。

2️⃣ 進入專案目錄後執行 `make` 進行建置。

完成後，編譯後的二進位檔會位於 `bin/<arch>/src/falkordb.so`。

### 執行測試

請先於 `tests` 目錄下執行 ```pip install -r requirements.txt``` 以安裝必要的 Python 套件。

> 注意：若你的 PATH 裡已有 ```redis-server```，可直接執行 ```make test```。否則請執行 ```REDIS_SERVER=<redis-server-location> make test```。若需更詳細輸出，請執行 ```make test V=1```。

### 在 docker 中建置

FalkorDB 的建置系統可在 docker 環境中運行。詳細建置說明請參閱[此處](https://docs.falkordb.com/docker-examples/README.html)。

## 將 FALKORDB 載入 REDIS

FalkorDB 由 [Redis](https://redis.io) 承載，因此你必須先將其作為模組載入 Redis 伺服器。
> 注意：FalkorDB 2.12 需要 [Redis 6.2](https://redis.io/download)。

💡 我們建議在 Redis 啟動時自動載入 FalkorDB，於 redis.conf 中加入下列設定：

```
loadmodule /path/to/module/src/falkordb.so
```

請將上述 `/path/to/module/src/falkordb.so` 替換為實際的 FalkorDB 程式庫路徑。
若 Redis 以服務方式執行，請確保 `redis` 使用者（預設）具有存取 `falkordb.so` 檔案／目錄的權限。

另外，也可用以下指令於命令列載入 FalkorDB：

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

最後，也可以使用 [`MODULE LOAD`](http://redis.io/commands/module-load) 指令。但請注意，`MODULE LOAD` 具有風險，未來可能因安全考量而被阻擋／棄用。

成功載入後，你會在 Redis 日誌中看到類似以下訊息：

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

若伺服器啟動失敗，並出現如下訊息：

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

表示系統缺少 OpenMP 執行時依賴。在 Ubuntu 上可用 `apt-get install libgomp1` 安裝，RHEL/CentOS 上用 `yum install libgomp`，OSX 上用 `brew install libomp`。

## 使用 FALKORDB

你可以透過任何 Redis 客戶端呼叫 FalkorDB 的指令。以下是幾種方式：

### 使用 `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### 使用其他客戶端

你可用客戶端的原生方式發送原始 Redis 指令與 FalkorDB 互動。

>注意：具體方式依各客戶端實作而異。

#### 範例：Python 客戶端使用 FalkorDB

以下範例顯示如何在 Python 中使用 [falkordb-py](https://github.com/FalkorDB/falkordb-py) 操作 FalkorDB：

```Python
from falkordb import FalkorDB

# 連線至 FalkorDB
db = FalkorDB(host='localhost', port=6379)

# 選擇 social 圖譜
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## 客戶端程式庫

>注意：部分語言有支援 FalkorDB 指令的官方客戶端程式庫：

### 官方客戶端


| 專案                                                   | 語言   | 授權 | 作者                                      | 星數                                                             | 套件 | 備註    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |


### 其他客戶端

| 專案                                                   | 語言   | 授權 | 作者                                      | 星數                                                             | 套件 | 備註    |
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

## 授權

本專案採用 Server Side Public License v1 (SSPLv1)。詳情請參閱 [LICENSE](LICENSE.txt)。

### 支持我們

⭐️ 如果你覺得本專案有幫助，請考慮給我們一個 star！

↗️ Graph、圖形資料庫、RAG、graphrag、檢索增強生成、資訊檢索、自然語言處理、LLM、嵌入、語意搜尋

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---