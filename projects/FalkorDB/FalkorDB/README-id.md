[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Database Graf untuk GraphRAG & GenAI

Database graf yang skalabel dan berlatensi rendah, dirancang untuk tim pengembang yang mengelola data terstruktur dan tidak terstruktur yang saling terhubung dalam lingkungan real-time atau interaktif.

[![Try Free](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## FITUR UNIK

Tujuan kami adalah membangun Knowledge Graph berkinerja tinggi yang disesuaikan untuk Large Language Models (LLM), dengan mengutamakan latensi yang sangat rendah untuk memastikan pengiriman informasi yang cepat dan efisien melalui Database Graf kami.

🆕 [FalkorDB](https://www.falkordb.com/) adalah **database [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) pertama yang dapat di-query yang memanfaatkan matriks jarang** untuk merepresentasikan [adjacency matrix](https://en.wikipedia.org/wiki/Adjacency_matrix) pada graf dan [aljabar linear](https://en.wikipedia.org/wiki/Adjacency_matrix) untuk melakukan query.

### Fitur Utama

* **Representasi Matriks Jarang**: Menggunakan matriks jarang untuk merepresentasikan adjacency matrix, mengoptimalkan penyimpanan dan performa.

* **Querying Aljabar Linear**: Menggunakan aljabar linear untuk eksekusi query, meningkatkan efisiensi komputasi.

* **Kepatuhan Model Property Graph**: Mendukung node dan relasi dengan atribut, sesuai dengan Model Property Graph.

* **Dukungan OpenCypher:** Kompatibel dengan bahasa query [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), termasuk ekstensi eksklusif untuk kemampuan query tingkat lanjut.

>Jelajahi FalkorDB dalam aksi dengan mengunjungi [Demo](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## DOKUMENTASI

[Dokumentasi Resmi](https://docs.falkordb.com/) | [Klien](https://docs.falkordb.com/clients.html) | [Perintah](https://docs.falkordb.com/commands/) | 📊 [Benchmark Performa Terbaru](https://benchmark.falkordb.com/)

### Komunitas dan Dukungan

* **Diskusi**: Bergabunglah dalam diskusi komunitas kami di [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) untuk bertanya, berbagi ide, dan terhubung dengan pengguna lain.

* **Kontribusi**: Kami menyambut kontribusi! Silakan lihat [Panduan Kontribusi](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) untuk detail lebih lanjut.

* **Lisensi**: Proyek ini dilisensikan di bawah Server Side Public License v1 (SSPLv1). Lihat berkas [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) untuk detail.

## MULAI

### Langkah 1

Untuk mencoba FalkorDB dengan cepat, jalankan sebuah instance menggunakan docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Atau, untuk menggunakan antarmuka berbasis browser bawaan, jalankan:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Langkah 2

Kemudian, buka browser Anda dan kunjungi `http://localhost:3000`.

Anda juga dapat berinteraksi dengan FalkorDB menggunakan salah satu [Library Klien](https://docs.falkordb.com/clients.html) yang didukung.

### Contoh Liga MotoGP

Pada contoh ini, kita akan menggunakan [klien Python FalkorDB](https://pypi.org/project/FalkorDB/) untuk membuat sebuah graf kecil yang merepresentasikan sebagian pembalap dan tim yang berpartisipasi dalam liga MotoGP. Setelah membuat graf, kita akan melakukan query untuk mengeksplorasi struktur dan relasinya.

```python
from falkordb import FalkorDB

# Koneksi ke FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Membuat graf 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Query pembalap mana yang mewakili Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Akan menampilkan: "Valentino Rossi"

# Query berapa banyak pembalap yang mewakili tim Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Akan menampilkan: 1
```

## MULAI MEMBANGUN

### Kompilasi

Pastikan telah memenuhi persyaratan berikut:

1️⃣ Repository FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>Pada Ubuntu Linux, jalankan: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>Pada OS X, pastikan `homebrew` sudah terpasang dan jalankan: `brew install cmake m4 automake peg libtool autoconf`.
>>Versi Clang yang disertakan dengan toolchain OS X tidak mendukung OpenMP, yang dibutuhkan oleh FalkorDB. Salah satu solusinya adalah menjalankan `brew install gcc g++` dan ikuti instruksi untuk memperbarui symbolic link. Perhatikan bahwa ini adalah perubahan sistem - mengatur variabel lingkungan `CC` dan `CXX` juga bisa menjadi solusi.

2️⃣ Build dengan menjalankan `make` di direktori proyek.

Selamat! Anda dapat menemukan binary hasil kompilasi di `bin/<arch>/src/falkordb.so`.

### Menjalankan tes

Mulai dengan menginstal package Python yang dibutuhkan dengan menjalankan ```pip install -r requirements.txt``` dari direktori ```tests```.

> Catatan: Jika Anda sudah memiliki ```redis-server``` di PATH, cukup jalankan ```make test```. Jika tidak, gunakan ```REDIS_SERVER=<lokasi-redis-server> make test```. Untuk output yang lebih detail, jalankan ```make test V=1```.

### Build di dalam docker

Sistem build FalkorDB berjalan di dalam docker. Untuk instruksi lengkap membangun, [lihat di sini](https://docs.falkordb.com/docker-examples/README.html).

## MEMUAT FALKORDB KE DALAM REDIS

FalkorDB di-host oleh [Redis](https://redis.io), jadi Anda harus memuatnya sebagai Modul ke server Redis. 
> Catatan: [Redis 6.2](https://redis.io/download) dibutuhkan untuk FalkorDB 2.12.

💡 Kami merekomendasikan agar Redis memuat FalkorDB saat startup dengan menambahkan baris berikut ke file redis.conf Anda:

```
loadmodule /path/to/module/src/falkordb.so
```

Ganti `/path/to/module/src/falkordb.so` dengan path sebenarnya ke library FalkorDB.
Jika Redis berjalan sebagai service, pastikan user `redis` (default) memiliki izin file/folder yang diperlukan
untuk mengakses `falkordb.so`.

Alternatifnya, Anda dapat membuat Redis memuat FalkorDB menggunakan argumen command line berikut:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Terakhir, Anda juga dapat menggunakan perintah [`MODULE LOAD`](http://redis.io/commands/module-load). Namun, perlu dicatat bahwa `MODULE LOAD` adalah perintah yang berbahaya dan dapat diblokir/dihapus di masa depan karena pertimbangan keamanan.

Setelah FalkorDB berhasil dimuat, log Redis Anda akan menampilkan baris seperti:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Jika server gagal dijalankan dengan output seperti:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

Sistem Anda belum memiliki dependensi run-time OpenMP. Ini dapat diinstal di Ubuntu dengan `apt-get install libgomp1`, di RHEL/CentOS dengan `yum install libgomp`, dan di OSX dengan `brew install libomp`.

## MENGGUNAKAN FALKORDB

Anda dapat memanggil perintah FalkorDB dari klien Redis mana pun. Berikut beberapa caranya:

### Dengan `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Dengan klien lain

Anda dapat berinteraksi dengan FalkorDB menggunakan kemampuan klien Anda untuk mengirim perintah Redis mentah.

>Catatan: Bergantung pada klien yang Anda gunakan, metode pastinya bisa berbeda.

#### Contoh: Menggunakan FalkorDB dengan klien Python

Potongan kode ini menunjukkan cara menggunakan FalkorDB dari Python menggunakan [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Koneksi ke FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Pilih graf social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## LIBRARY KLIEN

>Catatan: Beberapa bahasa memiliki library klien yang mendukung perintah FalkorDB:

### Klien Resmi

| Proyek                                                   | Bahasa     | Lisensi | Penulis                                      | Bintang                                                             | Paket | Komentar    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Klien Tambahan

| Proyek                                                   | Bahasa     | Lisensi | Penulis                                      | Bintang                                                             | Paket | Komentar    |
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

## LISENSI

Dilindungi oleh Server Side Public License v1 (SSPLv1). Lihat [LICENSE](LICENSE.txt).

### Dukung pekerjaan kami

⭐️ Jika Anda merasa repository ini bermanfaat, mohon pertimbangkan untuk memberikan bintang!

↗️ Graph, database graf, RAG, graphrag, Retrieval-Augmented Generation, Information Retrieval, Natural Language Processing, LLM, Embeddings, Semantic Search

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---