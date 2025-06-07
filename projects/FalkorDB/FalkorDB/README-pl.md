[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Baza Danych Grafowych dla GraphRAG & GenAI

Skalowalna, niskolatencyjna baza danych grafowych zaprojektowana dla zespołów deweloperskich zarządzających danymi połączonymi, zarówno strukturalnymi, jak i niestrukturalnymi, w środowiskach czasu rzeczywistego lub interaktywnych.

[![Wypróbuj za darmo](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## UNIKALNE CECHY

Naszym celem jest budowa wysokowydajnego Grafu Wiedzy dostosowanego do dużych modeli językowych (LLM), z naciskiem na wyjątkowo niską latencję, aby zapewnić szybkie i efektywne dostarczanie informacji przez naszą bazę danych grafowych.

🆕 [FalkorDB](https://www.falkordb.com/) to pierwsza **bazodanowa [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) umożliwiająca zapytania i wykorzystująca macierze rzadkie** do reprezentacji [macierzy sąsiedztwa](https://en.wikipedia.org/wiki/Adjacency_matrix) w grafach oraz [algebrę liniową](https://en.wikipedia.org/wiki/Adjacency_matrix) do zapytań.

### Kluczowe funkcje

* **Reprezentacja Macierzy Rzadkiej**: Wykorzystuje macierze rzadkie do reprezentacji macierzy sąsiedztwa, optymalizując przechowywanie i wydajność.

* **Zapytania z użyciem algebry liniowej**: Wykorzystuje algebrę liniową do realizacji zapytań, zwiększając efektywność obliczeniową.

* **Zgodność z modelem Property Graph**: Obsługuje węzły i relacje z atrybutami, zgodnie z modelem Property Graph.

* **Obsługa OpenCypher:** Kompatybilny z językiem zapytań [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), w tym z rozszerzeniami własnymi umożliwiającymi zaawansowane zapytania.

>Poznaj FalkorDB w działaniu, odwiedzając [Dema](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## DOKUMENTACJA

[Oficjalna dokumentacja](https://docs.falkordb.com/) | [Klienci](https://docs.falkordb.com/clients.html) | [Polecenia](https://docs.falkordb.com/commands/) | 📊 [Najnowsze Benchmarki Wydajności](https://benchmark.falkordb.com/)

### Społeczność i wsparcie

* **Dyskusje**: Dołącz do naszych dyskusji społecznościowych na [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions), aby zadawać pytania, dzielić się pomysłami i kontaktować się z innymi użytkownikami.

* **Współtworzenie**: Zapraszamy do współpracy! Zobacz nasz [Przewodnik Współtwórcy](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) po więcej szczegółów.

* **Licencja**: Ten projekt jest licencjonowany na zasadach Server Side Public License v1 (SSPLv1). Szczegóły w pliku [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt).

## ROZPOCZNIJ

### Krok 1

Aby szybko wypróbować FalkorDB, uruchom instancję za pomocą Dockera:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Lub, aby skorzystać z wbudowanego interfejsu przeglądarkowego, uruchom:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Krok 2

Następnie otwórz przeglądarkę i przejdź do `http://localhost:3000`.

Możesz również korzystać z FalkorDB za pomocą dowolnej z obsługiwanych [Bibliotek Klienta](https://docs.falkordb.com/clients.html)

### Przykład MotoGP League

W tym przykładzie użyjemy [klienta FalkorDB dla Pythona](https://pypi.org/project/FalkorDB/), aby utworzyć niewielki graf przedstawiający wybranych motocyklistów i zespoły uczestniczące w lidze MotoGP. Po utworzeniu grafu wykonamy zapytania, aby zbadać jego strukturę i zależności.

```python
from falkordb import FalkorDB

# Połącz z FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Utwórz graf 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Zapytanie: którzy zawodnicy reprezentują Yamahę?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Wyświetli: "Valentino Rossi"

# Zapytanie: ilu zawodników reprezentuje zespół Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Wyświetli: 1
```

## ZACZNIJ TWORZYĆ

### Kompilacja

Upewnij się, że spełniasz następujące wymagania:

1️⃣ Repozytorium FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>Na Ubuntu Linux uruchom: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>Na OS X upewnij się, że masz zainstalowany `homebrew` i uruchom: `brew install cmake m4 automake peg libtool autoconf`.
>>Wersja Clang dostarczana z narzędziami OS X nie obsługuje OpenMP, co jest wymagane przez FalkorDB. Jednym ze sposobów rozwiązania jest uruchomienie `brew install gcc g++` i postępowanie zgodnie z instrukcjami na ekranie, aby zaktualizować linki symboliczne. Jest to zmiana na poziomie systemu - ustawienie zmiennych środowiskowych `CC` i `CXX` także zadziała, jeśli to jest preferowane.

2️⃣ Zbuduj projekt poleceniem `make` w katalogu projektu.

Gratulacje! Skompilowany plik binarny znajdziesz w `bin/<arch>/src/falkordb.so`.

### Uruchamianie testów

Rozpocznij od instalacji wymaganych paczek Pythona, uruchamiając ```pip install -r requirements.txt``` w katalogu ```tests```.

> Uwaga: Jeśli masz ```redis-server``` w PATH, wystarczy uruchomić ```make test```. W przeciwnym razie uruchom ```REDIS_SERVER=<ścieżka-do-redis-server> make test```. Aby uzyskać bardziej szczegółowe logi, wykonaj ```make test V=1```.

### Budowanie w dockerze

System budowania FalkorDB działa w dockerze. Szczegółowe instrukcje budowania znajdziesz [tutaj](https://docs.falkordb.com/docker-examples/README.html).

## ŁADOWANIE FALKORDB DO REDIS

FalkorDB jest hostowany przez [Redis](https://redis.io), więc najpierw musisz załadować go jako Moduł do serwera Redis.
> Uwaga: [Redis 6.2](https://redis.io/download) jest wymagany dla FalkorDB 2.12.

💡 Zalecamy, aby Redis ładował FalkorDB podczas uruchamiania, dodając poniższą linię do pliku redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

W powyższej linii zamień `/path/to/module/src/falkordb.so` na rzeczywistą ścieżkę do biblioteki FalkorDB.
Jeśli Redis działa jako usługa, należy upewnić się, że użytkownik `redis` (domyślnie) ma odpowiednie uprawnienia do pliku/katalogu `falkordb.so`.

Alternatywnie możesz załadować FalkorDB do Redisa używając poniższej składni argumentów wiersza poleceń:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Możesz także użyć polecenia [`MODULE LOAD`](http://redis.io/commands/module-load). Pamiętaj jednak, że `MODULE LOAD` jest poleceniem niebezpiecznym i w przyszłości może być zablokowane/wycofane ze względu na bezpieczeństwo.

Po poprawnym załadowaniu FalkorDB w logu Redisa powinny pojawić się linie podobne do:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Jeśli serwer nie uruchomi się i pojawi się komunikat podobny do:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

W systemie brakuje zależności uruchomieniowej OpenMP. Na Ubuntu zainstaluj ją przez `apt-get install libgomp1`, na RHEL/CentOS przez `yum install libgomp`, a na OSX przez `brew install libomp`.

## UŻYWANIE FALKORDB

Możesz wywoływać polecenia FalkorDB z dowolnego klienta Redis. Oto kilka sposobów:

### Z `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Z dowolnym innym klientem

Możesz korzystać z FalkorDB, wykorzystując możliwość wysyłania surowych poleceń Redis przez swojego klienta.

>Uwaga: W zależności od wybranego klienta sposób realizacji może się różnić.

#### Przykład: Użycie FalkorDB z klientem Python

Ten fragment kodu pokazuje, jak korzystać z FalkorDB w Pythonie z użyciem [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Połącz z FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Wybierz graf "social"
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## BIBLIOTEKI KLIENTA

>Uwaga: Dla niektórych języków istnieją biblioteki klientów obsługujące polecenia FalkorDB:

### Oficjalni klienci

| Projekt                                                   | Język      | Licencja | Autor                                      | Gwiazdki                                                            | Pakiet  | Komentarz    |
| --------------------------------------------------------- | ---------- | -------- | ------------------------------------------ | ------------------------------------------------------------------- | ------- | ------------ |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Dodatkowi klienci

| Projekt                                                   | Język      | Licencja | Autor                                      | Gwiazdki                                                            | Pakiet  | Komentarz    |
| --------------------------------------------------------- | ---------- | -------- | ------------------------------------------ | ------------------------------------------------------------------- | ------- | ------------ |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Dokumentacja](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## LICENCJA

Licencjonowane na zasadach Server Side Public License v1 (SSPLv1). Zobacz [LICENSE](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/LICENSE.txt).

### Wesprzyj naszą pracę

⭐️ Jeśli uważasz to repozytorium za pomocne, rozważ zostawienie gwiazdki!

↗️ Graf, baza danych grafowych, RAG, graphrag, Retrieval-Augmented Generation, Wyszukiwanie informacji, Przetwarzanie języka naturalnego, LLM, Embeddingi, Wyszukiwanie semantyczne

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---