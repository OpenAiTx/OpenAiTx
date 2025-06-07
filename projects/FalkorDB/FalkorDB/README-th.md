[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - ฐานข้อมูลกราฟสำหรับ GraphRAG & GenAI

ฐานข้อมูลกราฟที่สามารถขยายขนาดได้และมีความหน่วงต่ำ ออกแบบมาสำหรับทีมพัฒนาที่ต้องการจัดการข้อมูลแบบมีโครงสร้างและไม่มีโครงสร้างที่มีความเชื่อมโยงกันแบบเรียลไทม์หรือในสภาพแวดล้อมแบบอินเทอร์แอคทีฟ

[![ลองใช้งานฟรี](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## คุณสมบัติเด่น

เป้าหมายของเราคือการสร้างกราฟความรู้ (Knowledge Graph) ประสิทธิภาพสูงที่ออกแบบมาโดยเฉพาะสำหรับ LLMs (Large Language Models) โดยให้ความสำคัญกับความหน่วงที่ต่ำเป็นพิเศษ เพื่อให้สามารถส่งข้อมูลได้อย่างรวดเร็วและมีประสิทธิภาพผ่านฐานข้อมูลกราฟของเรา

🆕 [FalkorDB](https://www.falkordb.com/) เป็นฐานข้อมูล **Property Graph** ตัวแรกที่สามารถสืบค้นได้ โดยอาศัย **สเมทริกซ์แบบเบาบาง (Sparse Matrices)** เพื่อใช้แทน [เมทริกซ์การเชื่อมต่อ (Adjacency Matrix)](https://en.wikipedia.org/wiki/Adjacency_matrix) ในกราฟ และใช้ [พีชคณิตเชิงเส้น (Linear Algebra)](https://en.wikipedia.org/wiki/Adjacency_matrix) สำหรับการสืบค้น

### คุณสมบัติสำคัญ

* **การแทนค่าแบบ Sparse Matrix**: ใช้สเมทริกซ์แบบเบาบางเพื่อแทนที่เมทริกซ์การเชื่อมต่อ ช่วยเพิ่มประสิทธิภาพการจัดเก็บและการประมวลผล

* **การสืบค้นด้วยพีชคณิตเชิงเส้น**: ใช้พีชคณิตเชิงเส้นในการประมวลผลคำสั่งสืบค้น เพิ่มประสิทธิภาพในการคำนวณ

* **รองรับ Property Graph Model**: สนับสนุนโหนดและความสัมพันธ์พร้อมแอตทริบิวต์ ตามแบบ Property Graph Model

* **รองรับ OpenCypher:** สามารถใช้งานร่วมกับภาษา [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) รวมถึงส่วนขยายสำหรับการสืบค้นขั้นสูง

>สำรวจการใช้งาน FalkorDB ได้ที่ [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo)

## เอกสารประกอบ

[เอกสารทางการ](https://docs.falkordb.com/) | [ไคลเอนต์](https://docs.falkordb.com/clients.html) | [คำสั่ง](https://docs.falkordb.com/commands/) | 📊 [ผลทดสอบประสิทธิภาพล่าสุด](https://benchmark.falkordb.com/)

### ชุมชนและการสนับสนุน

* **พูดคุย**: เข้าร่วมพูดคุยกับชุมชนที่ [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) เพื่อสอบถาม แชร์ไอเดีย และเชื่อมโยงกับผู้ใช้ท่านอื่น

* **ร่วมพัฒนา**: ยินดีต้อนรับทุกการมีส่วนร่วม! โปรดดูรายละเอียดเพิ่มเติมได้ที่ [Contributing Guide](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md)

* **สัญญาอนุญาต**: โครงการนี้อยู่ภายใต้ Server Side Public License v1 (SSPLv1) ดูรายละเอียดที่ไฟล์ [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt)

## เริ่มต้นใช้งาน

### ขั้นตอนที่ 1

ทดลองใช้งาน FalkorDB อย่างรวดเร็วด้วยการรันอินสแตนซ์ผ่าน docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

หรือหากต้องการใช้งานผ่านอินเทอร์เฟซบนเว็บบราวเซอร์ ให้รันคำสั่งนี้:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### ขั้นตอนที่ 2

จากนั้นเปิดบราวเซอร์และไปที่ `http://localhost:3000`

คุณสามารถโต้ตอบกับ FalkorDB ได้ผ่าน [Client Libraries](https://docs.falkordb.com/clients.html) ที่รองรับ

### ตัวอย่าง MotoGP League

ในตัวอย่างนี้ เราจะใช้ [FalkorDB Python client](https://pypi.org/project/FalkorDB/) เพื่อสร้างกราฟขนาดเล็ก แทนรายชื่อนักบิดและทีมที่เข้าร่วมการแข่งขัน MotoGP หลังจากสร้างกราฟแล้วจะมีการสืบค้นข้อมูลเพื่อดูโครงสร้างและความสัมพันธ์

```python
from falkordb import FalkorDB

# เชื่อมต่อกับ FalkorDB
db = FalkorDB(host='localhost', port=6379)

# สร้างกราฟ 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# คิวรี่หาว่าใครเป็นนักบิดของ Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# จะแสดง: "Valentino Rossi"

# คิวรี่หาว่ามีนักบิดกี่คนที่เป็นตัวแทนทีม Ducati ?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# จะแสดง: 1
```

## เริ่มต้นสร้างระบบ

### การคอมไพล์

ตรวจสอบให้แน่ใจว่าได้ดำเนินการตามข้อกำหนดเหล่านี้:

1️⃣ ดาวน์โหลดที่เก็บ FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>บน Ubuntu Linux รัน: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>บน OS X ตรวจสอบว่าติดตั้ง `homebrew` แล้วและรัน: `brew install cmake m4 automake peg libtool autoconf`
>>เวอร์ชัน Clang ที่มากับ OS X ไม่รองรับ OpenMP ซึ่งเป็นข้อกำหนดสำหรับ FalkorDB วิธีแก้ไขคือรัน `brew install gcc g++` และทำตามคำแนะนำบนหน้าจอเพื่ออัปเดต symbolic links (อาจเป็นการเปลี่ยนแปลงในระดับระบบ) หรือเซ็ต environment variable ของ `CC` และ `CXX`

2️⃣ สร้างโปรเจกต์ด้วยคำสั่ง `make` ในโฟลเดอร์โปรเจกต์

ขอแสดงความยินดี! คุณจะพบไฟล์ไบนารีที่คอมไพล์แล้วที่ `bin/<arch>/src/falkordb.so`

### การรันเทสต์

เริ่มต้นด้วยการติดตั้งแพ็คเกจ Python ที่ต้องใช้ โดยรัน ```pip install -r requirements.txt``` จากโฟลเดอร์ ```tests```

> หมายเหตุ: หากมี ```redis-server``` อยู่ใน PATH ให้ใช้คำสั่ง ```make test``` หากไม่เช่นนั้นให้ใช้ ```REDIS_SERVER=<redis-server-location> make test``` ถ้าต้องการแสดงผลแบบละเอียดให้รัน ```make test V=1```

### การสร้างภายใน docker

ระบบ build ของ FalkorDB รันภายใน docker ดูรายละเอียดวิธีการ build ได้ที่ [ที่นี่](https://docs.falkordb.com/docker-examples/README.html)

## การโหลด FalkorDB เข้า Redis

FalkorDB ทำงานบน [Redis](https://redis.io) ดังนั้นคุณต้องโหลดเป็นโมดูลเข้า Redis server ก่อน
> หมายเหตุ: [Redis 6.2](https://redis.io/download) คือเวอร์ชันที่ต้องใช้สำหรับ FalkorDB 2.12

💡 แนะนำให้ตั้งค่าให้ Redis โหลด FalkorDB ขณะเริ่มต้นโดยเพิ่มบรรทัดนี้ในไฟล์ redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

ในบรรทัดข้างต้น ให้แทนที่ `/path/to/module/src/falkordb.so` ด้วย path จริงของไลบรารี FalkorDB
หาก Redis รันเป็น service ตรวจสอบให้แน่ใจว่า user `redis` (ค่าเริ่มต้น) มีสิทธิ์เข้าถึงไฟล์/โฟลเดอร์ที่จำเป็น

อีกทางเลือกหนึ่ง คุณสามารถสั่งให้ Redis โหลด FalkorDB ด้วย argument บรรทัดคำสั่งดังนี้:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

สุดท้ายยังสามารถใช้คำสั่ง [`MODULE LOAD`](http://redis.io/commands/module-load) ได้ แต่โปรดทราบว่า `MODULE LOAD` เป็นคำสั่งที่อาจถูกปิดกั้น/ยกเลิกในอนาคตเนื่องจากเหตุผลด้านความปลอดภัย

เมื่อโหลด FalkorDB สำเร็จ จะพบข้อความใน log ของ Redis เช่นนี้:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

หากเซิร์ฟเวอร์เปิดไม่ขึ้นและแสดงข้อความลักษณะนี้:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

ระบบขาด dependency ที่จำเป็นคือ OpenMP สามารถติดตั้งได้บน Ubuntu ด้วย `apt-get install libgomp1` บน RHEL/CentOS ด้วย `yum install libgomp` และบน OSX ด้วย `brew install libomp`

## การใช้งาน FalkorDB

คุณสามารถเรียกใช้คำสั่งของ FalkorDB จากไคลเอนต์ Redis ใด ๆ ก็ได้ วิธีที่เป็นไปได้ เช่น

### ใช้งานผ่าน `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### ใช้งานผ่านไคลเอนต์อื่น

คุณสามารถโต้ตอบกับ FalkorDB โดยใช้ฟีเจอร์การส่งคำสั่ง raw ของไคลเอนต์ Redis ที่คุณใช้

>หมายเหตุ: วิธีการที่แน่นอนขึ้นกับไคลเอนต์แต่ละประเภท

#### ตัวอย่าง: ใช้งาน FalkorDB กับ Python client

ตัวอย่างนี้แสดงวิธีใช้ FalkorDB จาก Python ด้วย [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# เชื่อมต่อกับ FalkorDB
db = FalkorDB(host='localhost', port=6379)

# เลือกกราฟชื่อ social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## ไลบรารีไคลเอนต์

>หมายเหตุ: บางภาษาอาจมีไลบรารีไคลเอนต์ที่รองรับคำสั่งของ FalkorDB:

### ไคลเอนต์ทางการ


| โครงการ                                                    | ภาษา      | สัญญาอนุญาต | ผู้พัฒนา                                  | ดาว                                                             | แพ็คเกจ | หมายเหตุ    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |


### ไคลเอนต์เพิ่มเติม

| โครงการ                                                    | ภาษา      | สัญญาอนุญาต | ผู้พัฒนา                                  | ดาว                                                             | แพ็คเกจ | หมายเหตุ    |
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

## สัญญาอนุญาต

อยู่ภายใต้ Server Side Public License v1 (SSPLv1) ดูรายละเอียดที่ [LICENSE](LICENSE.txt)

### สนับสนุนการพัฒนาของเรา

⭐️ หากคุณพบว่า repository นี้เป็นประโยชน์ โปรดพิจารณาให้ดาว!

↗️ กราฟ, ฐานข้อมูลกราฟ, RAG, graphrag, Retrieval-Augmented Generation, Information Retrieval, Natural Language Processing, LLM, Embeddings, Semantic Search

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---