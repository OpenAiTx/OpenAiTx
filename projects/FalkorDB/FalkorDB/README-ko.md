[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - GraphRAG 및 GenAI를 위한 그래프 데이터베이스

실시간 또는 인터랙티브 환경에서 구조화 및 비구조화된 상호 연결 데이터 관리를 담당하는 개발팀을 위해 설계된 확장 가능하고 저지연의 그래프 데이터베이스입니다.

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## 고유 기능

저희의 목표는 대형 언어 모델(LLM)에 최적화된 고성능 지식 그래프를 구축하는 것이며, 특히 매우 낮은 지연 시간을 우선시하여 저희 그래프 데이터베이스를 통해 신속하고 효율적인 정보 제공을 실현하고자 합니다.

🆕 [FalkorDB](https://www.falkordb.com/)는 **희소 행렬(sparse matrix)**을 사용하여 그래프의 [인접 행렬](https://en.wikipedia.org/wiki/Adjacency_matrix)을 표현하고, [선형대수](https://en.wikipedia.org/wiki/Adjacency_matrix)를 쿼리에 활용하는 최초의 **질의 가능한 [속성 그래프(Property Graph)](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) 데이터베이스**입니다.

### 주요 특징

* **희소 행렬 표현**: 인접 행렬을 희소 행렬로 표현하여 저장 공간과 성능을 최적화합니다.

* **선형대수 기반 쿼리**: 쿼리 실행에 선형대수를 활용하여 계산 효율성을 높입니다.

* **속성 그래프 모델 준수**: 속성(attribute)이 있는 노드와 관계(relationship)를 지원하며, Property Graph Model을 따릅니다.

* **OpenCypher 지원**: [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) 쿼리 언어와 호환되며, 고급 쿼리 기능을 위한 독자적 확장 기능도 제공합니다.

> 실제 동작 중인 FalkorDB를 살펴보려면 [데모](https://github.com/FalkorDB/FalkorDB/tree/master/demo)를 방문하세요.

## 문서

[공식 문서](https://docs.falkordb.com/) | [클라이언트](https://docs.falkordb.com/clients.html) | [명령어](https://docs.falkordb.com/commands/) | 📊 [최신 성능 벤치마크](https://benchmark.falkordb.com/)

### 커뮤니티 및 지원

* **토론**: [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions)에서 질문하고, 아이디어를 공유하며, 다른 사용자와 소통하세요.

* **기여하기**: 기여를 환영합니다! 자세한 내용은 [기여 가이드](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md)를 참고하세요.

* **라이선스**: 본 프로젝트는 Server Side Public License v1 (SSPLv1) 하에 라이선스됩니다. 자세한 내용은 [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) 파일을 참고하세요.

## 시작하기

### 1단계

FalkorDB를 빠르게 체험하려면 다음과 같이 Docker로 인스턴스를 실행하세요:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

또는, 내장 브라우저 기반 인터페이스를 사용하려면 다음을 실행하세요:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### 2단계

그런 다음, 브라우저를 열고 `http://localhost:3000`으로 이동하세요.

또한, 지원되는 [클라이언트 라이브러리](https://docs.falkordb.com/clients.html) 중 하나를 사용하여 FalkorDB와 상호작용할 수 있습니다.

### MotoGP 리그 예제

이 예제에서는 [FalkorDB Python 클라이언트](https://pypi.org/project/FalkorDB/)를 사용하여 MotoGP 리그에 참가하는 일부 모터사이클 라이더와 팀을 나타내는 소규모 그래프를 생성합니다. 그래프 생성 후, 데이터의 구조와 관계를 탐색하는 쿼리를 실행합니다.

```python
from falkordb import FalkorDB

# FalkorDB에 연결
db = FalkorDB(host='localhost', port=6379)

# 'MotoGP' 그래프 생성
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Yamaha를 대표하는 라이더는 누구인가?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# 출력: "Valentino Rossi"

# Ducati 팀을 대표하는 라이더 수는?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# 출력: 1
```

## 빌드 시작

### 컴파일

다음 요구사항을 먼저 충족하세요:

1️⃣ FalkorDB 저장소: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

> Ubuntu Linux에서는 `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`를 실행하세요.
	
> OS X에서는 `homebrew`가 설치되어 있는지 확인한 후 `brew install cmake m4 automake peg libtool autoconf`를 실행하세요.
>> OS X 도구 모음에 포함된 Clang 버전은 OpenMP를 지원하지 않으므로, 이는 FalkorDB에 필수입니다. 이를 해결하려면 `brew install gcc g++`를 실행하고 안내에 따라 심볼릭 링크를 업데이트하세요. 단, 이는 시스템 전체에 영향을 주는 변경사항입니다. 만약 옵션이 아니라면 환경 변수 `CC`와 `CXX`를 지정하는 방식도 사용할 수 있습니다.

2️⃣ 프로젝트 디렉터리에서 `make`를 실행하여 빌드하세요.

축하합니다! 컴파일된 바이너리는 `bin/<arch>/src/falkordb.so`에 위치합니다.

### 테스트 실행

먼저 ```tests``` 디렉터리에서 ```pip install -r requirements.txt```로 필요한 Python 패키지를 설치하세요.

> 참고: ```redis-server```가 PATH에 있다면 ```make test```만 실행하면 됩니다. 그렇지 않으면 ```REDIS_SERVER=<redis-server-location> make test```를 실행하세요. 보다 상세한 출력을 원한다면 ```make test V=1```을 실행하세요.

### Docker에서 빌드하기

FalkorDB 빌드 시스템은 Docker 내에서 실행됩니다. 자세한 빌드 지침은 [여기](https://docs.falkordb.com/docker-examples/README.html)를 참고하세요.

## REDIS에 FALKORDB 로드하기

FalkorDB는 [Redis](https://redis.io)에서 호스팅되므로, 먼저 Redis 서버에 모듈로 로드해야 합니다. 
> 참고: FalkorDB 2.12를 사용하려면 [Redis 6.2](https://redis.io/download)가 필요합니다.

💡 Redis가 시작 시 FalkorDB를 자동으로 로드하려면 redis.conf 파일에 다음을 추가하세요:

```
loadmodule /path/to/module/src/falkordb.so
```

위 줄에서 `/path/to/module/src/falkordb.so`를 실제 FalkorDB 라이브러리의 경로로 바꿔주세요.
Redis가 서비스로 실행 중이라면, `redis` 사용자(기본값)가 `falkordb.so`에 접근할 수 있도록 필요한 파일/폴더 권한을 부여해야 합니다.

또는, 다음 명령줄 인자 구문을 사용하여 Redis가 FalkorDB를 로드할 수 있습니다:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

마지막으로 [`MODULE LOAD`](http://redis.io/commands/module-load) 명령도 사용할 수 있습니다. 단, `MODULE LOAD`는 위험한 명령어이며, 보안상의 이유로 향후 차단/폐기될 수 있습니다.

FalkorDB가 성공적으로 로드되면, Redis 로그에 아래와 유사한 라인이 출력됩니다:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

만약 서버가 다음과 유사한 메시지와 함께 실행에 실패한다면:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

시스템에 런타임 의존성인 OpenMP가 누락된 것입니다. Ubuntu에서는 `apt-get install libgomp1`, RHEL/CentOS에서는 `yum install libgomp`, OSX에서는 `brew install libomp`로 설치할 수 있습니다.

## FALKORDB 사용하기

FalkorDB 명령은 모든 Redis 클라이언트에서 호출할 수 있습니다. 사용 방법은 다음과 같습니다:

### `redis-cli` 사용 시

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### 기타 클라이언트 사용 시

사용 중인 클라이언트의 raw Redis 명령 전송 기능을 활용하여 FalkorDB와 상호작용할 수 있습니다.

>참고: 사용하는 클라이언트에 따라 구체적인 방법은 다를 수 있습니다.

#### 예시: Python 클라이언트에서 FalkorDB 사용

이 코드 예시는 [falkordb-py](https://github.com/FalkorDB/falkordb-py)를 이용해 Python에서 FalkorDB를 사용하는 방법을 보여줍니다.

```Python
from falkordb import FalkorDB

# FalkorDB에 연결
db = FalkorDB(host='localhost', port=6379)

# social 그래프 선택
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## 클라이언트 라이브러리

>참고: 일부 언어에는 FalkorDB 명령을 지원하는 클라이언트 라이브러리가 있습니다.

### 공식 클라이언트


| 프로젝트                                                   | 언어   | 라이선스 | 작성자                                      | 별점                                                             | 패키지 | 비고    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |


### 추가 클라이언트

| 프로젝트                                                   | 언어   | 라이선스 | 작성자                                      | 별점                                                             | 패키지 | 비고    |
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

## 라이선스

Server Side Public License v1 (SSPLv1)에 따라 라이선스됩니다. [LICENSE](LICENSE.txt)를 참고하세요.

### 저희의 작업을 응원해주세요

⭐️ 이 저장소가 도움이 되었다면, Star를 눌러주세요!

↗️ Graph, graph database, RAG, graphrag, Retrieval-Augmented Generation,Information Retrieval, Natural Language Processing, LLM, Embeddings, Semantic Search

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---