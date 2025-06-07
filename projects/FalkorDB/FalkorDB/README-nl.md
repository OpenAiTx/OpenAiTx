[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Grafendatabase voor GraphRAG & GenAI

Een schaalbare, laag-latente grafendatabase ontworpen voor ontwikkelteams die gestructureerde en ongestructureerde onderling verbonden data beheren in real-time of interactieve omgevingen.

[![Probeer Gratis](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## UNIEKE KENMERKEN

Ons doel is om een high-performance Knowledge Graph te bouwen, afgestemd op Large Language Models (LLM's), met een nadruk op uitzonderlijk lage latency om snelle en efficiënte informatielevering te garanderen via onze grafendatabase.

🆕 [FalkorDB](https://www.falkordb.com/) is de eerste **opvraagbare [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) database die gebruikmaakt van sparse matrices** voor het representeren van de [adjacentie matrix](https://en.wikipedia.org/wiki/Adjacency_matrix) in grafen en [lineaire algebra](https://en.wikipedia.org/wiki/Adjacency_matrix) voor queries.

### Belangrijkste kenmerken

* **Sparse Matrix Representatie**: Gebruikt sparse matrices om adjacentie matrices te representeren, wat opslag en prestaties optimaliseert.

* **Lineaire Algebra Querying**: Gebruikt lineaire algebra voor het uitvoeren van queries, wat de computationele efficiëntie verhoogt.

* **Property Graph Model Compatibiliteit**: Ondersteunt knooppunten en relaties met attributen, in overeenstemming met het Property Graph Model.

* **OpenCypher Ondersteuning:** Compatibel met de [OpenCypher](ttps://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) querytaal, inclusief eigen extensies voor geavanceerde querymogelijkheden.

>Ontdek FalkorDB in actie door de [Demo's](https://github.com/FalkorDB/FalkorDB/tree/master/demo) te bezoeken.

## DOCUMENTATIE

[Officiële Documentatie](https://docs.falkordb.com/) | [Clients](https://docs.falkordb.com/clients.html) | [Commando's](https://docs.falkordb.com/commands/) | 📊 [Nieuwste Prestatiebenchmarks](https://benchmark.falkordb.com/)

### Community en Ondersteuning

* **Discussies**: Neem deel aan onze community-discussies op [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) om vragen te stellen, ideeën te delen en contact te leggen met andere gebruikers.

* **Bijdragen**: We verwelkomen bijdragen! Zie onze [Contributie Gids](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) voor meer details.

* **Licentie**: Dit project is gelicenseerd onder de Server Side Public License v1 (SSPLv1). Zie het [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) bestand voor details.

## AAN DE SLAG

### Stap 1

Om FalkorDB snel uit te proberen, start een instantie met docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Of, om de ingebouwde browserinterface te gebruiken, voer uit:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Stap 2

Open vervolgens je browser en ga naar `http://localhost:3000`.

Je kunt ook interageren met FalkorDB met behulp van een van de ondersteunde [Client Libraries](https://docs.falkordb.com/clients.html)

### MotoGP League Voorbeeld

In dit voorbeeld gebruiken we de [FalkorDB Python client](https://pypi.org/project/FalkorDB/) om een kleine graaf te maken die een subset van motorrijders en teams in de MotoGP league representeert. Na het maken van de graaf, voeren we queries uit om de structuur en relaties te verkennen.

```python
from falkordb import FalkorDB

# Verbinding maken met FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Maak de 'MotoGP' graaf aan
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Query: welke rijders vertegenwoordigen Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Print: "Valentino Rossi"

# Query: hoeveel rijders vertegenwoordigen team Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Print: 1
```

## BEGIN MET BOUWEN

### Compileren

Zorg ervoor dat je aan deze vereisten voldoet:

1️⃣ De FalkorDB repository: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>Op Ubuntu Linux, voer uit: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>Op OS X, controleer of `homebrew` geïnstalleerd is en voer uit: `brew install cmake m4 automake peg libtool autoconf`.
>>De versie van Clang die met de OS X toolchain wordt geleverd ondersteunt geen OpenMP, wat vereist is voor FalkorDB. Een manier om dit op te lossen is door `brew install gcc g++` uit te voeren en de instructies op het scherm te volgen om de symbolische links bij te werken. Let op: dit is een systeemwijde wijziging - het instellen van de omgevingsvariabelen voor `CC` en `CXX` werkt als dat geen optie is.

2️⃣ Bouw door `make` uit te voeren in de projectmap.

Gefeliciteerd! Je kunt het gecompileerde binary-bestand vinden op `bin/<arch>/src/falkordb.so`.

### Testen uitvoeren

Begin met het installeren van de vereiste Python packages door ```pip install -r requirements.txt``` uit te voeren vanuit de ```tests``` directory.

> Opmerking: Als ```redis-server``` in PATH staat, voer dan gewoon ```make test``` uit. Anders voer je ```REDIS_SERVER=<redis-server-location> make test``` uit. Voor meer uitgebreide output, voer ```make test V=1``` uit.

### Bouwen in een docker

Het FalkorDB build-systeem draait binnen docker. Voor gedetailleerde instructies over bouwen, [zie hier](https://docs.falkordb.com/docker-examples/README.html).

## FALKORDB INLADEN IN REDIS

FalkorDB wordt gehost door [Redis](https://redis.io), dus je moet het eerst als module laden in een Redis-server. 
> Opmerking: [Redis 6.2](https://redis.io/download) is vereist voor FalkorDB 2.12.

💡 We raden aan om Redis FalkorDB te laten laden bij het opstarten door het volgende toe te voegen aan je redis.conf bestand:

```
loadmodule /path/to/module/src/falkordb.so
```

Vervang in de bovenstaande regel `/path/to/module/src/falkordb.so` door het daadwerkelijke pad naar de FalkorDB bibliotheek.
Als Redis als service draait, moet je ervoor zorgen dat de `redis` gebruiker (standaard) de benodigde rechten heeft
om `falkordb.so` te benaderen.

Je kunt Redis ook FalkorDB laten laden met het volgende commandoregelargument:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Ten slotte kun je ook het [`MODULE LOAD`](http://redis.io/commands/module-load) commando gebruiken. Let op: `MODULE LOAD` is een gevaarlijk commando en kan in de toekomst worden geblokkeerd of verwijderd vanwege veiligheidsredenen.

Zodra je FalkorDB succesvol hebt geladen, zie je in het Redis log bestand regels zoals:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Als de server niet kan starten en een output geeft zoals:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

Dan ontbreekt de OpenMP runtime afhankelijkheid op het systeem. Dit kan op Ubuntu geïnstalleerd worden met `apt-get install libgomp1`, op RHEL/CentOS met `yum install libgomp`, en op OSX met `brew install libomp`.

## FALKORDB GEBRUIKEN

Je kunt FalkorDB-commando's aanroepen vanuit elke Redis-client. Hier zijn verschillende methodes:

### Met `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Met een andere client

Je kunt met FalkorDB communiceren via de mogelijkheid van je client om ruwe Redis-commando's te versturen.

>Opmerking: Afhankelijk van je gekozen client kan de exacte methode hiervan verschillen.

#### Voorbeeld: FalkorDB gebruiken met een Python client

Deze code toont hoe je FalkorDB vanuit Python gebruikt met [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Verbinding maken met FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Selecteer de social graaf
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## CLIENT LIBRARIES

>Opmerking: Sommige talen hebben client libraries die ondersteuning bieden voor FalkorDB-commando's:

### Officiële Clients

| Project                                                   | Taal       | Licentie | Auteur                                      | Sterren                                                             | Package | Opmerking    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Aanvullende Clients

| Project                                                   | Taal       | Licentie | Auteur                                      | Sterren                                                             | Package | Opmerking    |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Documentatie](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## LICENTIE

Gelicenseerd onder de Server Side Public License v1 (SSPLv1). Zie [LICENSE](LICENSE.txt).

### Steun ons werk

⭐️ Vind je deze repository nuttig, overweeg dan om een ster te geven!

↗️ Graaf, grafendatabase, RAG, graphrag, Retrieval-Augmented Generation, Informatieopvraging, Natural Language Processing, LLM, Embeddings, Semantisch Zoeken

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---