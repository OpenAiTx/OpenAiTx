[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Cơ sở dữ liệu đồ thị cho GraphRAG & GenAI

Một cơ sở dữ liệu đồ thị mở rộng, độ trễ thấp, được thiết kế cho các nhóm phát triển quản lý dữ liệu liên kết có cấu trúc và phi cấu trúc trong thời gian thực hoặc môi trường tương tác.

[![Dùng thử miễn phí](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## TÍNH NĂNG ĐỘC ĐÁO

Mục tiêu của chúng tôi là xây dựng một Đồ thị Tri thức hiệu năng cao phù hợp với Mô hình Ngôn ngữ Lớn (LLM), ưu tiên độ trễ cực thấp để đảm bảo cung cấp thông tin nhanh chóng và hiệu quả thông qua Cơ sở Dữ liệu Đồ thị của chúng tôi.

🆕 [FalkorDB](https://www.falkordb.com/) là **cơ sở dữ liệu [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) đầu tiên có thể truy vấn sử dụng ma trận thưa** để biểu diễn [ma trận kề](https://en.wikipedia.org/wiki/Adjacency_matrix) trong đồ thị và [đại số tuyến tính](https://en.wikipedia.org/wiki/Adjacency_matrix) để truy vấn.

### Tính năng chính

* **Biểu diễn Ma trận Thưa**: Sử dụng ma trận thưa để biểu diễn ma trận kề, tối ưu hóa lưu trữ và hiệu suất.

* **Truy vấn Đại số Tuyến tính**: Áp dụng đại số tuyến tính để thực thi truy vấn, nâng cao hiệu quả tính toán.

* **Tuân thủ Mô hình Property Graph**: Hỗ trợ các nút và quan hệ với thuộc tính, tuân thủ Mô hình Property Graph.

* **Hỗ trợ OpenCypher:** Tương thích với ngôn ngữ truy vấn [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), bao gồm mở rộng độc quyền để nâng cao khả năng truy vấn.

>Khám phá FalkorDB hoạt động thực tế tại [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## TÀI LIỆU HƯỚNG DẪN

[Tài liệu chính thức](https://docs.falkordb.com/) | [Thư viện khách hàng](https://docs.falkordb.com/clients.html) | [Lệnh](https://docs.falkordb.com/commands/) | 📊 [Hiệu năng mới nhất](https://benchmark.falkordb.com/)

### Cộng đồng và Hỗ trợ

* **Thảo luận**: Tham gia thảo luận cộng đồng tại [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) để đặt câu hỏi, chia sẻ ý tưởng và kết nối với người dùng khác.

* **Đóng góp**: Chúng tôi hoan nghênh sự đóng góp! Vui lòng xem [Hướng dẫn đóng góp](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) để biết thêm chi tiết.

* **Giấy phép**: Dự án này được cấp phép theo Server Side Public License v1 (SSPLv1). Xem tệp [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) để biết chi tiết.

## BẮT ĐẦU SỬ DỤNG

### Bước 1

Để thử nhanh FalkorDB, khởi động một phiên bản bằng docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Hoặc, để sử dụng giao diện trình duyệt tích hợp sẵn, chạy:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Bước 2

Sau đó, mở trình duyệt và truy cập `http://localhost:3000`.


Bạn cũng có thể tương tác với FalkorDB bằng bất kỳ [Thư viện khách hàng](https://docs.falkordb.com/clients.html) hỗ trợ nào.

### Ví dụ Giải đua MotoGP

Trong ví dụ này, chúng ta sẽ sử dụng [thư viện khách hàng Python của FalkorDB](https://pypi.org/project/FalkorDB/) để tạo một đồ thị nhỏ biểu diễn một tập hợp các tay đua và đội đua tham gia giải MotoGP. Sau khi tạo đồ thị, chúng ta sẽ truy vấn dữ liệu để khám phá cấu trúc và các mối quan hệ của nó.

```python
from falkordb import FalkorDB

# Kết nối tới FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Tạo đồ thị 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Truy vấn các tay đua đại diện cho Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Kết quả: "Valentino Rossi"

# Truy vấn có bao nhiêu tay đua đại diện cho đội Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Kết quả: 1
```

## BẮT ĐẦU XÂY DỰNG

### Biên dịch

Đảm bảo đã hoàn thành các yêu cầu sau:

1️⃣ Kho lưu trữ FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>Trên Ubuntu Linux, chạy: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>Trên OS X, đảm bảo đã cài đặt `homebrew` và chạy: `brew install cmake m4 automake peg libtool autoconf`.
>>Phiên bản Clang đi kèm với bộ công cụ OS X không hỗ trợ OpenMP, đây là yêu cầu cho FalkorDB. Một cách giải quyết là chạy `brew install gcc g++` và làm theo hướng dẫn để cập nhật symbolic links. Lưu ý rằng đây là thay đổi toàn hệ thống - thiết lập biến môi trường `CC` và `CXX` cũng hoạt động nếu không thể đổi symbolic link.

2️⃣ Biên dịch bằng cách chạy `make` trong thư mục dự án.

Chúc mừng! Bạn có thể tìm thấy tập tin nhị phân đã biên dịch tại `bin/<arch>/src/falkordb.so`.

### Chạy kiểm thử

Bắt đầu bằng cách cài đặt các gói Python cần thiết bằng lệnh ```pip install -r requirements.txt``` từ thư mục ```tests```.

> Lưu ý: Nếu bạn đã có ```redis-server``` trong PATH, chỉ cần chạy ```make test```. Nếu không, chạy ```REDIS_SERVER=<redis-server-location> make test```. Để có kết quả chi tiết hơn, chạy ```make test V=1```.

### Xây dựng bằng docker

Hệ thống xây dựng của FalkorDB chạy trong docker. Để biết hướng dẫn chi tiết về xây dựng, vui lòng [xem tại đây](https://docs.falkordb.com/docker-examples/README.html).

## NẠP FALKORDB VÀO REDIS

FalkorDB được lưu trữ bởi [Redis](https://redis.io), vì vậy bạn cần nạp nó như một Module vào máy chủ Redis. 
> Lưu ý: [Redis 6.2](https://redis.io/download) là yêu cầu cho FalkorDB 2.12.

💡 Chúng tôi khuyến nghị Redis nạp FalkorDB trong quá trình khởi động bằng cách thêm dòng sau vào tệp redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

Ở dòng trên, thay `/path/to/module/src/falkordb.so` bằng đường dẫn thực tế đến thư viện FalkorDB.
Nếu Redis chạy như một dịch vụ, bạn cần đảm bảo người dùng `redis` (mặc định) có đủ quyền truy cập tệp/thư mục để truy xuất `falkordb.so`.

Ngoài ra, bạn có thể để Redis nạp FalkorDB bằng cú pháp dòng lệnh sau:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Cuối cùng, bạn cũng có thể sử dụng lệnh [`MODULE LOAD`](http://redis.io/commands/module-load). Tuy nhiên, lưu ý rằng `MODULE LOAD` là lệnh nguy hiểm và có thể bị chặn hoặc không được hỗ trợ trong tương lai vì lý do bảo mật.

Sau khi bạn nạp FalkorDB thành công, log của Redis sẽ xuất hiện dòng tương tự:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Nếu máy chủ không khởi động được và xuất hiện lỗi tương tự:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

Hệ thống thiếu phụ thuộc thời gian chạy OpenMP. Có thể cài đặt trên Ubuntu bằng `apt-get install libgomp1`, trên RHEL/CentOS bằng `yum install libgomp`, và trên OSX bằng `brew install libomp`.

## SỬ DỤNG FALKORDB

Bạn có thể gọi các lệnh của FalkorDB từ bất kỳ client Redis nào. Dưới đây là một số cách:

### Với `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Với bất kỳ client nào khác

Bạn có thể tương tác với FalkorDB bằng khả năng gửi lệnh Redis thô của client.

>Lưu ý: Tùy vào client bạn sử dụng, phương thức thực hiện có thể khác nhau.

#### Ví dụ: Sử dụng FalkorDB với client Python

Đoạn mã này cho thấy cách sử dụng FalkorDB trong Python với [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Kết nối tới FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Chọn đồ thị social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## THƯ VIỆN KHÁCH HÀNG

>Lưu ý: Một số ngôn ngữ có thư viện hỗ trợ các lệnh của FalkorDB:

### Thư viện chính thức

| Dự án                                                   | Ngôn ngữ   | Giấy phép | Tác giả                                      | Số sao                                                             | Gói | Ghi chú    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Thư viện bổ sung

| Dự án                                                   | Ngôn ngữ   | Giấy phép | Tác giả                                      | Số sao                                                             | Gói | Ghi chú    |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Tài liệu](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## GIẤY PHÉP

Được cấp phép theo Server Side Public License v1 (SSPLv1). Xem [LICENSE](LICENSE.txt).

### Ủng hộ chúng tôi

⭐️ Nếu bạn thấy kho lưu trữ này hữu ích, hãy dành tặng một ngôi sao!

↗️ Đồ thị, cơ sở dữ liệu đồ thị, RAG, graphrag, Retrieval-Augmented Generation, Truy xuất thông tin, Xử lý ngôn ngữ tự nhiên, LLM, Embeddings, Tìm kiếm ngữ nghĩa

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---