[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - 面向GraphRAG与生成式AI的图数据库

一款可扩展、低延迟的图数据库，专为在实时或交互式环境中管理结构化与非结构化关联数据的开发团队设计。

[![免费试用](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB 图数据库](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## 独特特性

我们的目标是构建一个专为大语言模型（LLM）定制的高性能知识图谱，优先保证极低的延迟，通过我们的图数据库实现快速高效的信息交付。

🆕 [FalkorDB](https://www.falkordb.com/) 是首个**利用稀疏矩阵表示[邻接矩阵](https://en.wikipedia.org/wiki/Adjacency_matrix)并通过[线性代数](https://en.wikipedia.org/wiki/Adjacency_matrix)进行查询**的**可查询[属性图](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc)数据库**。

### 主要特性

* **稀疏矩阵表示**：使用稀疏矩阵来表示邻接矩阵，优化存储与性能。

* **线性代数查询**：采用线性代数执行查询，提高计算效率。

* **符合属性图模型**：支持具有属性的节点和关系，遵循属性图模型规范。

* **OpenCypher 支持**：兼容 [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) 查询语言，并包含专有扩展以实现高级查询能力。

> 访问 [演示示例](https://github.com/FalkorDB/FalkorDB/tree/master/demo) 了解 FalkorDB 的实际应用。

## 文档

[官方文档](https://docs.falkordb.com/) | [客户端](https://docs.falkordb.com/clients.html) | [命令](https://docs.falkordb.com/commands/) | 📊 [最新性能基准测试](https://benchmark.falkordb.com/)

### 社区与支持

* **讨论**：加入我们的 [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) 社区，提问、分享想法并与其他用户交流。
* **贡献**：欢迎社区贡献！请参阅我们的[贡献指南](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md)了解更多详情。
* **许可协议**：本项目采用 Server Side Public License v1 (SSPLv1) 授权。详见 [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) 文件。

## 快速开始

### 步骤1

要快速体验 FalkorDB，可通过 docker 启动一个实例：

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

或者，若需使用内置的基于浏览器的界面，请运行：

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### 步骤2

然后，在浏览器中打开 `http://localhost:3000`。

你也可以通过任意支持的[客户端库](https://docs.falkordb.com/clients.html)与 FalkorDB 交互。

### MotoGP 联赛示例

以下示例使用 [FalkorDB Python 客户端](https://pypi.org/project/FalkorDB/) 创建一个包含部分摩托车手和车队的 MotoGP 联赛小型图谱。创建图后，我们将查询数据以探索其结构和关系。

```python
from falkordb import FalkorDB

# 连接到 FalkorDB
db = FalkorDB(host='localhost', port=6379)

# 创建 'MotoGP' 图
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# 查询哪些车手代表 Yamaha？
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# 输出: "Valentino Rossi"

# 查询有多少车手代表 Ducati 车队？
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# 输出: 1
```

## 开始开发

### 编译

请确保完成以下准备工作：

1️⃣ 获取 FalkorDB 代码仓库：`git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

> 在 Ubuntu Linux 上，运行：`apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
> 在 OS X 上，确保已安装 `homebrew`，然后运行：`brew install cmake m4 automake peg libtool autoconf`。
>> OS X 自带的 Clang 版本不支持 OpenMP，而 FalkorDB 依赖 OpenMP。可通过 `brew install gcc g++` 并按提示更新符号链接来解决。注意：此为系统级更改——如不方便，也可通过设置环境变量 `CC` 和 `CXX` 指定编译器。

2️⃣ 在项目目录下运行 `make` 开始编译。

恭喜！你可以在 `bin/<arch>/src/falkordb.so` 找到已编译的二进制文件。

### 运行测试

首先在 `tests` 目录下运行 ```pip install -r requirements.txt``` 安装所需 Python 包。

> 注意：若你的 PATH 中有 ```redis-server```，直接运行 ```make test```。否则请运行 ```REDIS_SERVER=<redis-server-location> make test```。如需详细输出，运行 ```make test V=1```。

### 在 docker 中构建

FalkorDB 支持在 docker 环境下构建。详细构建说明请[点击这里](https://docs.falkordb.com/docker-examples/README.html)。

## 加载 FalkorDB 到 Redis

FalkorDB 依托于 [Redis](https://redis.io) 运行，因此需以模块形式加载到 Redis 服务器中。
> 注意：FalkorDB 2.12 需 [Redis 6.2](https://redis.io/download) 及以上版本。

💡 推荐在 redis.conf 文件中添加如下内容，使 Redis 启动时自动加载 FalkorDB：

```
loadmodule /path/to/module/src/falkordb.so
```

请将 `/path/to/module/src/falkordb.so` 替换为实际的 FalkorDB 库路径。
如 Redis 以服务方式运行，需确保 `redis` 用户（默认）拥有访问 `falkordb.so` 文件/文件夹的权限。

你也可以通过如下命令行参数让 Redis 加载 FalkorDB：

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

此外，还可以使用 [`MODULE LOAD`](http://redis.io/commands/module-load) 命令。但请注意，`MODULE LOAD` 存在安全风险，未来可能被禁用或废弃。

成功加载后，Redis 日志中应出现如下内容：

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

若启动失败，输出如下：

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

表示系统缺少运行时依赖 OpenMP。可在 Ubuntu 上运行 `apt-get install libgomp1`，在 RHEL/CentOS 上运行 `yum install libgomp`，在 OSX 上运行 `brew install libomp` 进行安装。

## 使用 FalkorDB

你可以通过任意 Redis 客户端调用 FalkorDB 的命令。常见方式如下：

### 使用 `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### 使用其他客户端

你可以利用客户端发送原生 Redis 命令的能力与 FalkorDB 交互。

> 注意：具体实现方法因客户端而异。

#### 示例：在 Python 客户端中使用 FalkorDB

以下代码展示如何在 Python 中通过 [falkordb-py](https://github.com/FalkorDB/falkordb-py) 使用 FalkorDB：

```Python
from falkordb import FalkorDB

# 连接到 FalkorDB
db = FalkorDB(host='localhost', port=6379)

# 选择 'social' 图
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## 客户端库

> 注意：部分语言拥有支持 FalkorDB 命令的客户端库：

### 官方客户端

| 项目                                                   | 语言   | 许可协议 | 作者                                      | Star数                                                             | 包管理 | 备注    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### 其他客户端

| 项目                                                   | 语言   | 许可协议 | 作者                                      | Star数                                                             | 包管理 | 备注    |
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

## 许可协议

本项目遵循 Server Side Public License v1 (SSPLv1)。详见 [LICENSE](LICENSE.txt)。

### 支持我们的工作

⭐️ 如果你觉得本仓库有帮助，欢迎 star！

↗️ 图、图数据库、RAG、graphrag、检索增强生成、信息检索、自然语言处理、LLM、嵌入、语义搜索

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---