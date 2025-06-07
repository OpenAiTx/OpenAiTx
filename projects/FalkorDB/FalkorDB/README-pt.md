[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Banco de Dados de Grafos para GraphRAG & GenAI

Um banco de dados de grafos escalável e de baixa latência, projetado para equipes de desenvolvimento que gerenciam dados estruturados e não estruturados interconectados em ambientes em tempo real ou interativos.

[![Experimente Grátis](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![Banco de Dados de Grafos FalkorDB](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## FUNCIONALIDADES ÚNICAS

Nosso objetivo é construir um Grafo de Conhecimento de alto desempenho, adaptado para Modelos de Linguagem de Grande Porte (LLMs), priorizando latência excepcionalmente baixa para garantir entrega rápida e eficiente de informações através do nosso Banco de Dados de Grafos.

🆕 [FalkorDB](https://www.falkordb.com/) é o primeiro **banco de dados [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) consultável a aproveitar matrizes esparsas** para representar a [matriz de adjacência](https://en.wikipedia.org/wiki/Adjacency_matrix) em grafos e [álgebra linear](https://en.wikipedia.org/wiki/Adjacency_matrix) para consultas.

### Principais Características

* **Representação por Matriz Esparsa**: Utiliza matrizes esparsas para representar matrizes de adjacência, otimizando armazenamento e desempenho.

* **Consultas com Álgebra Linear**: Emprega álgebra linear para execução de consultas, aumentando a eficiência computacional.

* **Conformidade com Property Graph Model**: Suporta nós e relacionamentos com atributos, aderindo ao Property Graph Model.

* **Suporte ao OpenCypher:** Compatível com a linguagem de consulta [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), incluindo extensões proprietárias para capacidades avançadas de consulta.

>Explore o FalkorDB em ação visitando os [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## DOCUMENTAÇÃO

[Documentação Oficial](https://docs.falkordb.com/) | [Clientes](https://docs.falkordb.com/clients.html) | [Comandos](https://docs.falkordb.com/commands/) | 📊 [Benchmarks de Desempenho Mais Recentes](https://benchmark.falkordb.com/)

### Comunidade e Suporte

* **Discussões**: Participe das discussões da comunidade no [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) para tirar dúvidas, compartilhar ideias e conectar-se com outros usuários.

* **Contribuição**: Contribuições são bem-vindas! Consulte nosso [Guia de Contribuição](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) para mais detalhes.

* **Licença**: Este projeto está licenciado sob a Server Side Public License v1 (SSPLv1). Veja o arquivo [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) para detalhes.

## PRIMEIROS PASSOS

### Passo 1

Para experimentar rapidamente o FalkorDB, inicie uma instância usando docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Ou, para usar a interface incorporada baseada em navegador, execute:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Passo 2

Depois, abra seu navegador e acesse `http://localhost:3000`.

Você também pode interagir com o FalkorDB usando qualquer uma das [Bibliotecas de Cliente](https://docs.falkordb.com/clients.html) suportadas.

### Exemplo de Liga MotoGP

Neste exemplo, usaremos o [cliente Python FalkorDB](https://pypi.org/project/FalkorDB/) para criar um pequeno grafo representando um subconjunto de pilotos e equipes participantes da liga MotoGP. Após criar o grafo, consultaremos os dados para explorar sua estrutura e relacionamentos.

```python
from falkordb import FalkorDB

# Conectar ao FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Criar o grafo 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Consultar quais pilotos representam a Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Imprime: "Valentino Rossi"

# Consultar quantos pilotos representam a equipe Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Imprime: 1
```

## COMEÇANDO A DESENVOLVER

### Compilando

Certifique-se de cumprir estes requisitos:

1️⃣ Repositório FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>No Ubuntu Linux, execute: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>No OS X, verifique se o `homebrew` está instalado e execute: `brew install cmake m4 automake peg libtool autoconf`.
>>A versão do Clang que acompanha o toolchain do OS X não suporta OpenMP, que é um requisito para o FalkorDB. Uma maneira de resolver isso é executar `brew install gcc g++` e seguir as instruções na tela para atualizar os links simbólicos. Observe que esta é uma alteração em todo o sistema - definir as variáveis de ambiente `CC` e `CXX` funcionará caso não seja possível a alteração global.

2️⃣ Compile executando `make` no diretório do projeto.

Parabéns! Você pode encontrar o binário compilado em `bin/<arch>/src/falkordb.so`.

### Executando testes

Comece instalando os pacotes Python necessários executando ```pip install -r requirements.txt``` no diretório ```tests```.

> Nota: Se você tiver ```redis-server``` no PATH, basta executar ```make test```. Caso contrário, execute ```REDIS_SERVER=<redis-server-location> make test```. Para uma saída mais detalhada, execute ```make test V=1```.

### Construindo em um docker

O sistema de build do FalkorDB roda dentro do docker. Para instruções detalhadas sobre como compilar, por favor [veja aqui](https://docs.falkordb.com/docker-examples/README.html).

## CARREGANDO O FALKORDB NO REDIS

O FalkorDB é hospedado pelo [Redis](https://redis.io), então você precisa carregá-lo como um Módulo em um servidor Redis primeiro. 
> Nota: [Redis 6.2](https://redis.io/download) é necessário para o FalkorDB 2.12.

💡 Recomendamos configurar o Redis para carregar o FalkorDB durante a inicialização, adicionando o seguinte ao seu arquivo redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

Na linha acima, substitua `/path/to/module/src/falkordb.so` pelo caminho real para a biblioteca do FalkorDB.
Se o Redis estiver sendo executado como serviço, você deve garantir que o usuário `redis` (padrão) tenha as permissões de arquivos/pastas necessárias para acessar o `falkordb.so`.

Alternativamente, você pode fazer o Redis carregar o FalkorDB usando o seguinte argumento de linha de comando:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Por fim, você também pode usar o comando [`MODULE LOAD`](http://redis.io/commands/module-load). No entanto, note que o `MODULE LOAD` é um comando perigoso e pode ser bloqueado/descontinuado no futuro por questões de segurança.

Uma vez que você tenha carregado o FalkorDB com sucesso, seu log do Redis deverá mostrar linhas semelhantes a:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Se o servidor falhar ao iniciar com uma saída semelhante a:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

O sistema está faltando a dependência de tempo de execução OpenMP. Isso pode ser instalado no Ubuntu com `apt-get install libgomp1`, no RHEL/CentOS com `yum install libgomp`, e no OSX com `brew install libomp`.

## USANDO O FALKORDB

Você pode chamar os comandos do FalkorDB de qualquer cliente Redis. Aqui estão vários métodos:

### Com `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Com qualquer outro cliente

Você pode interagir com o FalkorDB usando a capacidade do seu cliente de enviar comandos brutos do Redis.

>Nota: Dependendo do cliente de sua escolha, o método exato pode variar.

#### Exemplo: Usando o FalkorDB com um cliente Python

Este trecho de código mostra como usar o FalkorDB a partir do Python usando [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Conectar ao FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Selecionar o grafo social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## BIBLIOTECAS DE CLIENTE

>Nota: Algumas linguagens possuem bibliotecas de cliente que fornecem suporte aos comandos do FalkorDB:

### Clientes Oficiais

| Projeto                                                   | Linguagem  | Licença | Autor                                      | Estrelas                                                          | Pacote  | Comentário |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Clientes Adicionais

| Projeto                                                   | Linguagem   | Licença | Autor                                      | Estrelas                                                           | Pacote | Comentário    |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Documentação](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## LICENÇA

Licenciado sob a Server Side Public License v1 (SSPLv1). Veja [LICENSE](LICENSE.txt).

### Apoie nosso trabalho

⭐️ Se você achou este repositório útil, considere deixar uma estrela!

↗️ Graph, banco de dados de grafos, RAG, graphrag, Retrieval-Augmented Generation, Recuperação de Informação, Processamento de Linguagem Natural, LLM, Embeddings, Busca Semântica

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---