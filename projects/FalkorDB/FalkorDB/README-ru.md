[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB — графовая база данных для GraphRAG и GenAI

Масштабируемая графовая база данных с низкой задержкой, предназначенная для команд разработчиков, управляющих структурированными и неструктурированными взаимосвязанными данными в режиме реального времени или в интерактивных средах.

[![Попробовать бесплатно](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## УНИКАЛЬНЫЕ ОСОБЕННОСТИ

Наша цель — создать высокопроизводительный граф знаний, адаптированный для крупных языковых моделей (LLM), уделяя приоритетное внимание исключительно низкой задержке для обеспечения быстрого и эффективного предоставления информации через нашу графовую базу данных.

🆕 [FalkorDB](https://www.falkordb.com/) — первая **запрашиваемая база данных [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), использующая разреженные матрицы** для представления [матрицы смежности](https://en.wikipedia.org/wiki/Adjacency_matrix) в графах и [линейную алгебру](https://en.wikipedia.org/wiki/Adjacency_matrix) для выполнения запросов.

### Ключевые особенности

* **Представление в виде разреженных матриц**: Использует разреженные матрицы для представления матриц смежности, оптимизируя хранение и производительность.

* **Запросы с помощью линейной алгебры**: Применяет линейную алгебру для выполнения запросов, повышая вычислительную эффективность.

* **Соответствие модели Property Graph**: Поддерживает узлы и связи с атрибутами, соответствуя модели Property Graph.

* **Поддержка OpenCypher**: Совместим с языком запросов [OpenCypher](ttps://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), включая собственные расширения для расширенных возможностей запросов.

>Изучите работу FalkorDB на практике, посетив раздел [Демо](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## ДОКУМЕНТАЦИЯ

[Официальная документация](https://docs.falkordb.com/) | [Клиенты](https://docs.falkordb.com/clients.html) | [Команды](https://docs.falkordb.com/commands/) | 📊 [Последние результаты производительности](https://benchmark.falkordb.com/)

### Сообщество и поддержка

* **Обсуждения**: Присоединяйтесь к обсуждениям в сообществе на [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions), чтобы задавать вопросы, делиться идеями и общаться с другими пользователями.

* **Вклад в проект**: Мы приветствуем ваши вклады! Пожалуйста, ознакомьтесь с нашим [Руководством по внесению вклада](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) для получения подробной информации.

* **Лицензия**: Этот проект лицензирован по лицензии Server Side Public License v1 (SSPLv1). Подробнее см. файл [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt).

## НАЧАЛО РАБОТЫ

### Шаг 1

Чтобы быстро попробовать FalkorDB, запустите экземпляр с помощью docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Или, чтобы использовать встроенный веб-интерфейс, выполните:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Шаг 2

Затем откройте браузер и перейдите по адресу `http://localhost:3000`.

Вы также можете взаимодействовать с FalkorDB, используя любую из поддерживаемых [клиентских библиотек](https://docs.falkordb.com/clients.html).

### Пример MotoGP League

В этом примере мы используем [Python-клиент FalkorDB](https://pypi.org/project/FalkorDB/) для создания небольшого графа, представляющего часть мотоциклистов и команд, участвующих в лиге MotoGP. После создания графа мы выполним запросы для изучения его структуры и связей.

```python
from falkordb import FalkorDB

# Подключение к FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Создание графа 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Какие гонщики представляют Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Выведет: "Valentino Rossi"

# Сколько гонщиков представляют команду Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Выведет: 1
```

## НАЧНИТЕ РАЗРАБОТКУ

### Сборка

Убедитесь, что выполнены следующие требования:

1️⃣ Репозиторий FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>На Ubuntu Linux выполните: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>На OS X убедитесь, что установлен `homebrew`, и выполните: `brew install cmake m4 automake peg libtool autoconf`.
>> Версия Clang, поставляемая с инструментарием OS X, не поддерживает OpenMP, который требуется для FalkorDB. Один из способов решения — выполнить `brew install gcc g++` и следовать инструкциям на экране для обновления символьных ссылок. Учтите, что это системное изменение — если это невозможно, можно установить переменные окружения `CC` и `CXX`.

2️⃣ Постройте проект, выполнив `make` в каталоге проекта.

Поздравляем! Скомпилированный бинарный файл будет находиться по пути `bin/<arch>/src/falkordb.so`.

### Запуск тестов

Начните с установки необходимых Python-пакетов командой ```pip install -r requirements.txt``` из директории ```tests```.

> Примечание: Если у вас есть ```redis-server``` в PATH, просто выполните ```make test```. В противном случае используйте ```REDIS_SERVER=<redis-server-location> make test```. Для более подробного вывода используйте ```make test V=1```.

### Сборка в docker

Система сборки FalkorDB запускается в docker. Для получения подробных инструкций по сборке, пожалуйста, [см. здесь](https://docs.falkordb.com/docker-examples/README.html).

## ЗАГРУЗКА FALKORDB В REDIS

FalkorDB размещается в [Redis](https://redis.io), поэтому сначала её необходимо загрузить как модуль в сервер Redis. 
> Примечание: Для FalkorDB 2.12 требуется [Redis 6.2](https://redis.io/download).

💡 Рекомендуем добавить загрузку FalkorDB при запуске Redis, добавив следующее в файл redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

В строке выше замените `/path/to/module/src/falkordb.so` на фактический путь к библиотеке FalkorDB.
Если Redis работает как сервис, убедитесь, что пользователь `redis` (по умолчанию) имеет необходимые права доступа к файлу/папке `falkordb.so`.

Альтернативно, можно загрузить FalkorDB с помощью следующего аргумента командной строки:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Также можно воспользоваться командой [`MODULE LOAD`](http://redis.io/commands/module-load). Однако обратите внимание, что `MODULE LOAD` — опасная команда, и в будущем она может быть заблокирована или снята по соображениям безопасности.

После успешной загрузки FalkorDB вы увидите в логе Redis строки, подобные следующим:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Если сервер не запускается и выдает что-то вроде:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

В системе отсутствует зависимость времени выполнения OpenMP. В Ubuntu установите её командой `apt-get install libgomp1`, в RHEL/CentOS — `yum install libgomp`, в OSX — `brew install libomp`.

## ИСПОЛЬЗОВАНИЕ FALKORDB

Вы можете вызывать команды FalkorDB из любого клиента Redis. Вот несколько способов:

### С помощью `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### С помощью любого другого клиента

Вы можете взаимодействовать с FalkorDB, используя возможность клиента отправлять сырые команды Redis.

>Примечание: В зависимости от выбранного клиента, способ отправки таких команд может отличаться.

#### Пример: Использование FalkorDB с Python-клиентом

Этот фрагмент кода показывает, как использовать FalkorDB из Python с помощью [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Подключение к FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Выбор графа social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## КЛИЕНТСКИЕ БИБЛИОТЕКИ

>Примечание: Для некоторых языков доступны клиентские библиотеки с поддержкой команд FalkorDB:

### Официальные клиенты

| Проект                                                   | Язык       | Лицензия | Автор                                      | Звёзды                                                             | Пакет   | Комментарий    |
| -------------------------------------------------------- | ---------- | -------- | ------------------------------------------ | ------------------------------------------------------------------ | ------- | -------------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |


### Дополнительные клиенты

| Проект                                                   | Язык       | Лицензия | Автор                                      | Звёзды                                                             | Пакет   | Комментарий    |
| -------------------------------------------------------- | ---------- | -------- | ------------------------------------------ | ------------------------------------------------------------------ | ------- | -------------- |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Документация](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## ЛИЦЕНЗИЯ

Лицензировано по Server Side Public License v1 (SSPLv1). См. [LICENSE](LICENSE.txt).

### Поддержите нашу работу

⭐️ Если этот репозиторий оказался для вас полезным, пожалуйста, поставьте ему звезду!

↗️ Graph, graph database, RAG, graphrag, Retrieval-Augmented Generation,Information Retrieval, Natural Language Processing, LLM, Embeddings, Semantic Search

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---