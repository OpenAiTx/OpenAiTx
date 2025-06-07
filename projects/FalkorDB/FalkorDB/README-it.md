[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Database a Grafo per GraphRAG & GenAI

Un database a grafo scalabile e a bassa latenza progettato per i team di sviluppo che gestiscono dati strutturati e non strutturati interconnessi in ambienti real-time o interattivi.

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## CARATTERISTICHE UNICHE

Il nostro obiettivo è costruire un Knowledge Graph ad alte prestazioni su misura per i Large Language Model (LLM), dando priorità a una latenza eccezionalmente bassa per garantire una consegna rapida ed efficiente delle informazioni tramite il nostro Database a Grafo.

🆕 [FalkorDB](https://www.falkordb.com/) è il primo **database [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) interrogabile che sfrutta le matrici sparsa** per rappresentare la [matrice di adiacenza](https://en.wikipedia.org/wiki/Adjacency_matrix) nei grafi e l'[algebra lineare](https://en.wikipedia.org/wiki/Adjacency_matrix) per le interrogazioni.

### Caratteristiche principali

* **Rappresentazione tramite Matrice Sparsa**: Utilizza matrici sparse per rappresentare le matrici di adiacenza, ottimizzando archiviazione e prestazioni.

* **Interrogazione tramite Algebra Lineare**: Sfrutta l'algebra lineare per l'esecuzione delle query, migliorando l'efficienza computazionale.

* **Conformità al Modello Property Graph**: Supporta nodi e relazioni con attributi, aderendo al Property Graph Model.

* **Supporto OpenCypher:** Compatibile con il linguaggio di query [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), incluse estensioni proprietarie per capacità di interrogazione avanzate.

>Esplora FalkorDB in azione visitando la sezione [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## DOCUMENTAZIONE

[Documentazione Ufficiale](https://docs.falkordb.com/) | [Client](https://docs.falkordb.com/clients.html) | [Comandi](https://docs.falkordb.com/commands/) | 📊 [Ultimi Benchmark di Prestazioni](https://benchmark.falkordb.com/)

### Community e Supporto

* **Discussioni**: Unisciti alle nostre discussioni di community su [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) per porre domande, condividere idee e connetterti con altri utenti.

* **Contributi**: Accogliamo con favore i contributi! Consulta la nostra [Guida ai Contributi](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) per maggiori dettagli.

* **Licenza**: Questo progetto è rilasciato sotto la Server Side Public License v1 (SSPLv1). Vedi il file [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) per i dettagli.

## INIZIA SUBITO

### Passo 1

Per provare rapidamente FalkorDB, avvia un’istanza tramite docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Oppure, per utilizzare l’interfaccia web integrata, esegui:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Passo 2

Poi, apri il browser e vai su `http://localhost:3000`.

Puoi anche interagire con FalkorDB utilizzando una delle [Librerie Client supportate](https://docs.falkordb.com/clients.html)

### Esempio MotoGP League

In questo esempio, useremo il [client Python di FalkorDB](https://pypi.org/project/FalkorDB/) per creare un piccolo grafo che rappresenta un sottoinsieme di piloti di motociclismo e team che partecipano alla lega MotoGP. Dopo aver creato il grafo, interrogheremo i dati per esplorare la sua struttura e le relazioni.

```python
from falkordb import FalkorDB

# Connessione a FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Crea il grafo 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Quali piloti rappresentano Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Stampa: "Valentino Rossi"

# Quanti piloti rappresentano il team Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Stampa: 1
```

## INIZIA A COSTRUIRE

### Compilazione

Assicurati di soddisfare questi requisiti:

1️⃣ Repository FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>Su Ubuntu Linux, esegui: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>Su OS X, verifica che `homebrew` sia installato ed esegui: `brew install cmake m4 automake peg libtool autoconf`.
>>La versione di Clang fornita con il toolchain di OS X non supporta OpenMP, che è un requisito per FalkorDB. Un modo per risolvere è eseguire `brew install gcc g++` e seguire le istruzioni a schermo per aggiornare i collegamenti simbolici. Nota che questa è una modifica a livello di sistema - impostare le variabili d'ambiente per `CC` e `CXX` funzionerà se questa non è un'opzione.

2️⃣ Compila eseguendo `make` nella directory del progetto.

Congratulazioni! Troverai il binario compilato in `bin/<arch>/src/falkordb.so`.

### Esecuzione dei test

Inizia installando i pacchetti Python richiesti eseguendo ```pip install -r requirements.txt``` dalla directory ```tests```.

> Nota: Se hai ```redis-server``` nel PATH, invoca semplicemente ```make test```. Altrimenti, invoca ```REDIS_SERVER=<redis-server-location> make test```. Per un output più dettagliato, esegui ```make test V=1```.

### Compilazione in docker

Il sistema di build di FalkorDB funziona all'interno di docker. Per istruzioni dettagliate sulla compilazione, [vedi qui](https://docs.falkordb.com/docker-examples/README.html).

## CARICAMENTO DI FALKORDB IN REDIS

FalkorDB è ospitato da [Redis](https://redis.io), quindi dovrai prima caricarlo come Modulo su un server Redis. 
> Nota: [Redis 6.2](https://redis.io/download) è richiesto per FalkorDB 2.12.

💡 Si consiglia di fare in modo che Redis carichi FalkorDB all’avvio aggiungendo la seguente riga al file redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

Nella riga sopra, sostituisci `/path/to/module/src/falkordb.so` con il percorso effettivo della libreria di FalkorDB.
Se Redis viene eseguito come servizio, devi assicurarti che l’utente `redis` (predefinito) abbia i permessi necessari sui file/cartelle
per accedere a `falkordb.so`.

In alternativa, puoi far caricare a Redis FalkorDB utilizzando il seguente argomento nella riga di comando:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Infine, puoi anche utilizzare il comando [`MODULE LOAD`](http://redis.io/commands/module-load). Nota però che `MODULE LOAD` è un comando pericoloso e potrebbe essere bloccato/deprecato in futuro per considerazioni di sicurezza.

Una volta caricato correttamente FalkorDB, nel log di Redis dovresti vedere righe simili a:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Se il server non si avvia e mostra un output simile a:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

Il sistema manca della dipendenza run-time OpenMP. Può essere installata su Ubuntu con `apt-get install libgomp1`, su RHEL/CentOS con `yum install libgomp`, e su OSX con `brew install libomp`.

## UTILIZZO DI FALKORDB

Puoi chiamare i comandi di FalkorDB da qualsiasi client Redis. Ecco diversi metodi:

### Con `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Con qualsiasi altro client

Puoi interagire con FalkorDB usando la capacità del client di inviare comandi Redis raw.

>Nota: A seconda del client scelto, il metodo esatto può variare.

#### Esempio: Utilizzo di FalkorDB con un client Python

Questo snippet mostra come usare FalkorDB da Python tramite [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Connessione a FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Seleziona il grafo 'social'
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## LIBRERIE CLIENT

>Nota: Alcuni linguaggi dispongono di librerie client che supportano i comandi di FalkorDB:

### Client Ufficiali

| Progetto                                                   | Linguaggio   | Licenza | Autore                                      | Stelle                                                             | Pacchetto | Commento    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Client Aggiuntivi

| Progetto                                                   | Linguaggio   | Licenza | Autore                                      | Stelle                                                             | Pacchetto | Commento    |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Documentazione](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## LICENZA

Distribuito sotto la Server Side Public License v1 (SSPLv1). Vedi [LICENSE](LICENSE.txt).

### Supporta il nostro lavoro

⭐️ Se trovi utile questo repository, considera di lasciare una stella!

↗️ Graph, database a grafo, RAG, graphrag, Retrieval-Augmented Generation,Information Retrieval, Natural Language Processing, LLM, Embeddings, Semantic Search

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---