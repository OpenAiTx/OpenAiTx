[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB – Graphdatenbank für GraphRAG & GenAI

Eine skalierbare, latenzarme Graphdatenbank, entwickelt für Entwicklerteams, die strukturierte und unstrukturierte, miteinander verbundene Daten in Echtzeit oder in interaktiven Umgebungen verwalten.

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## EINZIGARTIGE MERKMALE

Unser Ziel ist es, einen leistungsstarken Knowledge Graph speziell für Large Language Models (LLMs) zu entwickeln, wobei wir eine besonders niedrige Latenz priorisieren, um eine schnelle und effiziente Informationsbereitstellung durch unsere Graphdatenbank zu gewährleisten.

🆕 [FalkorDB](https://www.falkordb.com/) ist die erste **abfragbare [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc)-Datenbank, die Sparse-Matrizen** zur Darstellung der [Adjazenzmatrix](https://en.wikipedia.org/wiki/Adjacency_matrix) in Graphen und [Lineare Algebra](https://en.wikipedia.org/wiki/Adjacency_matrix) für Abfragen nutzt.

### Hauptfunktionen

* **Sparse-Matrix-Darstellung**: Nutzt Sparse-Matrizen zur Darstellung von Adjazenzmatrizen und optimiert so Speicher und Performance.

* **Lineare Algebra für Abfragen**: Setzt lineare Algebra zur Abfrageausführung ein und verbessert dadurch die Recheneffizienz.

* **Property Graph Model-Konformität**: Unterstützt Knoten und Beziehungen mit Attributen gemäß dem Property Graph Model.

* **OpenCypher-Unterstützung:** Kompatibel mit der [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc)-Abfragesprache, einschließlich proprietärer Erweiterungen für fortgeschrittene Abfragemöglichkeiten.

>Entdecke FalkorDB in Aktion in unseren [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## DOKUMENTATION

[Offizielle Dokumentation](https://docs.falkordb.com/) | [Clients](https://docs.falkordb.com/clients.html) | [Befehle](https://docs.falkordb.com/commands/) | 📊 [Aktuelle Performance-Benchmarks](https://benchmark.falkordb.com/)

### Community und Support

* **Diskussionen**: Tritt unseren Community-Diskussionen auf [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) bei, um Fragen zu stellen, Ideen zu teilen und dich mit anderen Nutzern zu vernetzen.

* **Mitwirken**: Beiträge sind willkommen! Weitere Informationen findest du in unserem [Beitragsleitfaden](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md).

* **Lizenz**: Dieses Projekt ist lizenziert unter der Server Side Public License v1 (SSPLv1). Details findest du in der [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt).

## LOSLEGEN

### Schritt 1

Um FalkorDB schnell auszuprobieren, starte eine Instanz mit Docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Oder nutze das integrierte browserbasierte Interface:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Schritt 2

Öffne dann deinen Browser und rufe `http://localhost:3000` auf.

Du kannst auch mit einer der unterstützten [Client-Bibliotheken](https://docs.falkordb.com/clients.html) mit FalkorDB interagieren.

### MotoGP-Liga Beispiel

In diesem Beispiel verwenden wir den [FalkorDB Python Client](https://pypi.org/project/FalkorDB/), um einen kleinen Graphen zu erstellen, der eine Auswahl an Motorradfahrern und Teams der MotoGP-Liga repräsentiert. Nach dem Erstellen des Graphen werden wir die Daten abfragen, um die Struktur und Beziehungen zu untersuchen.

```python
from falkordb import FalkorDB

# Verbindung zu FalkorDB herstellen
db = FalkorDB(host='localhost', port=6379)

# Erstelle den 'MotoGP'-Graphen
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Abfrage: Welche Fahrer vertreten Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Ausgabe: "Valentino Rossi"

# Abfrage: Wie viele Fahrer vertreten das Team Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Ausgabe: 1
```

## START BUILDING

### Kompilieren

Stelle sicher, dass folgende Anforderungen erfüllt sind:

1️⃣ Das FalkorDB-Repository: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>Unter Ubuntu Linux führe aus: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>Unter OS X stelle sicher, dass `homebrew` installiert ist, und führe aus: `brew install cmake m4 automake peg libtool autoconf`.
>>Die mit dem OS X Toolchain gelieferte Clang-Version unterstützt kein OpenMP, das für FalkorDB erforderlich ist. Eine Möglichkeit ist: `brew install gcc g++` ausführen und den Anweisungen folgen, um die symbolischen Links zu aktualisieren. Beachte, dass dies eine systemweite Änderung ist – das Setzen der Umgebungsvariablen für `CC` und `CXX` funktioniert alternativ.

2️⃣ Baue das Projekt mit `make` im Projektverzeichnis.

Glückwunsch! Die kompilierte Binary befindet sich unter `bin/<arch>/src/falkordb.so`.

### Tests ausführen

Installiere die benötigten Python-Pakete mit ```pip install -r requirements.txt``` im Verzeichnis ```tests```.

> Hinweis: Wenn du ```redis-server``` im PATH hast, einfach ```make test``` ausführen. Andernfalls ```REDIS_SERVER=<redis-server-location> make test```. Für eine ausführlichere Ausgabe: ```make test V=1```.

### Bauen in einem Docker

Das FalkorDB-Buildsystem läuft auch in Docker. Für detaillierte Anweisungen siehe bitte [hier](https://docs.falkordb.com/docker-examples/README.html).

## FALKORDB IN REDIS LADEN

FalkorDB wird von [Redis](https://redis.io) gehostet, daher musst du es als Modul in einen Redis-Server laden.  
> Hinweis: [Redis 6.2](https://redis.io/download) ist für FalkorDB 2.12 erforderlich.

💡 Wir empfehlen, FalkorDB beim Redis-Start zu laden, indem du Folgendes zu deiner redis.conf hinzufügst:

```
loadmodule /path/to/module/src/falkordb.so
```

Ersetze `/path/to/module/src/falkordb.so` durch den tatsächlichen Pfad zur FalkorDB-Bibliothek.
Falls Redis als Dienst läuft, stelle sicher, dass der Benutzer `redis` (Standard) die notwendigen Rechte hat,
um auf `falkordb.so` zuzugreifen.

Alternativ kannst du FalkorDB auch per Kommandozeilenargument laden:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Zuletzt kannst du auch den Befehl [`MODULE LOAD`](http://redis.io/commands/module-load) nutzen. Beachte jedoch, dass `MODULE LOAD` ein gefährlicher Befehl ist und aus Sicherheitsgründen künftig eventuell blockiert oder abgeschafft wird.

Nach dem erfolgreichen Laden von FalkorDB solltest du in deinem Redis-Log Zeilen wie diese sehen:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Falls der Server mit einer Ausgabe wie dieser fehlschlägt:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

Fehlt die Laufzeitabhängigkeit OpenMP. Diese kann auf Ubuntu mit `apt-get install libgomp1`, auf RHEL/CentOS mit `yum install libgomp` und auf OSX mit `brew install libomp` installiert werden.

## FALKORDB VERWENDEN

Du kannst die FalkorDB-Befehle von jedem Redis-Client aus aufrufen. Hier einige Möglichkeiten:

### Mit `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Mit jedem anderen Client

Du kannst mit FalkorDB interagieren, indem dein Client rohe Redis-Befehle senden kann.

>Hinweis: Je nach verwendetem Client kann sich die genaue Methode unterscheiden.

#### Beispiel: FalkorDB mit einem Python-Client verwenden

Dieser Codeausschnitt zeigt, wie FalkorDB mit Python und [falkordb-py](https://github.com/FalkorDB/falkordb-py) genutzt werden kann:

```Python
from falkordb import FalkorDB

# Verbindung zu FalkorDB aufbauen
db = FalkorDB(host='localhost', port=6379)

# Wähle den 'social'-Graphen aus
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## CLIENT-BIBLIOTHEKEN

>Hinweis: Für einige Sprachen gibt es Client-Bibliotheken mit Unterstützung für FalkorDB-Befehle:

### Offizielle Clients

| Projekt                                                   | Sprache   | Lizenz | Autor                                      | Sterne                                                             | Paket | Kommentar    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Weitere Clients

| Projekt                                                   | Sprache   | Lizenz | Autor                                      | Sterne                                                             | Paket | Kommentar    |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Dokumentation](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## LIZENZ

Lizenziert unter der Server Side Public License v1 (SSPLv1). Siehe [LICENSE](LICENSE.txt).

### Unterstütze unsere Arbeit

⭐️ Wenn dir dieses Repository gefällt, gib uns bitte einen Stern!

↗️ Graph, Graphdatenbank, RAG, graphrag, Retrieval-Augmented Generation, Information Retrieval, Natural Language Processing, LLM, Embeddings, Semantic Search

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---