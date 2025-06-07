[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Base de Datos de Grafos para GraphRAG & GenAI

Una base de datos de grafos escalable y de baja latencia diseñada para equipos de desarrollo que gestionan datos interconectados estructurados y no estructurados en entornos en tiempo real o interactivos.

[![Prueba Gratis](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## CARACTERÍSTICAS ÚNICAS

Nuestro objetivo es construir un Grafo de Conocimiento de alto rendimiento adaptado para Modelos de Lenguaje de Gran Tamaño (LLMs), priorizando una latencia excepcionalmente baja para asegurar una entrega de información rápida y eficiente a través de nuestra base de datos de grafos.

🆕 [FalkorDB](https://www.falkordb.com/) es la primera **base de datos de [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) consultable que aprovecha matrices dispersas** para representar la [matriz de adyacencia](https://en.wikipedia.org/wiki/Adjacency_matrix) en grafos y [álgebra lineal](https://en.wikipedia.org/wiki/Adjacency_matrix) para la consulta.

### Características Clave

* **Representación con Matrices Dispersas**: Utiliza matrices dispersas para representar matrices de adyacencia, optimizando almacenamiento y rendimiento.

* **Consulta mediante Álgebra Lineal**: Emplea álgebra lineal para la ejecución de consultas, mejorando la eficiencia computacional.

* **Cumplimiento del Modelo Property Graph**: Soporta nodos y relaciones con atributos, cumpliendo el Modelo Property Graph.

* **Soporte OpenCypher:** Compatible con el lenguaje de consulta [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), incluyendo extensiones propietarias para capacidades avanzadas de consulta.

>Explora FalkorDB en acción visitando las [Demos](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## DOCUMENTACIÓN

[Documentación Oficial](https://docs.falkordb.com/) | [Clientes](https://docs.falkordb.com/clients.html) | [Comandos](https://docs.falkordb.com/commands/) | 📊 [Últimos Benchmarks de Rendimiento](https://benchmark.falkordb.com/)

### Comunidad y Soporte

* **Debates**: Únete a nuestras discusiones en la comunidad en [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) para hacer preguntas, compartir ideas y conectar con otros usuarios.

* **Contribuir**: ¡Damos la bienvenida a contribuciones! Por favor, revisa nuestra [Guía de Contribución](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) para más detalles.

* **Licencia**: Este proyecto está licenciado bajo la Server Side Public License v1 (SSPLv1). Consulta el archivo [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) para más detalles.

## COMENZAR

### Paso 1

Para probar rápidamente FalkorDB, lanza una instancia usando docker:

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

O, para usar la interfaz incorporada basada en navegador, ejecuta:

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Paso 2

Luego, abre tu navegador y navega a `http://localhost:3000`.

También puedes interactuar con FalkorDB usando cualquiera de las [Librerías de Cliente](https://docs.falkordb.com/clients.html) soportadas.

### Ejemplo de Liga MotoGP

En este ejemplo, usaremos el [cliente Python de FalkorDB](https://pypi.org/project/FalkorDB/) para crear un pequeño grafo representando un subconjunto de pilotos de motocicletas y equipos que participan en la liga MotoGP. Después de crear el grafo, consultaremos los datos para explorar su estructura y relaciones.

```python
from falkordb import FalkorDB

# Conectar con FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Crear el grafo 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# ¿Qué pilotos representan a Yamaha?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Imprime: "Valentino Rossi"

# ¿Cuántos pilotos representan al equipo Ducati?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Imprime: 1
```

## EMPIEZA A CONSTRUIR

### Compilando

Asegúrate de completar estos requisitos:

1️⃣ El repositorio de FalkorDB: `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>En Ubuntu Linux, ejecuta: `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>En OS X, verifica que `homebrew` esté instalado y ejecuta: `brew install cmake m4 automake peg libtool autoconf`.
>>La versión de Clang que viene con la herramienta de OS X no soporta OpenMP, que es un requisito para FalkorDB. Una forma de resolver esto es ejecutar `brew install gcc g++` y seguir las instrucciones en pantalla para actualizar los enlaces simbólicos. Nota que esto es un cambio a nivel de sistema: configurar las variables de entorno `CC` y `CXX` funcionará si eso no es una opción.

2️⃣ Compila ejecutando `make` en el directorio del proyecto.

¡Felicidades! Puedes encontrar el binario compilado en `bin/<arch>/src/falkordb.so`.

### Ejecutando pruebas

Comienza instalando los paquetes de Python requeridos ejecutando ```pip install -r requirements.txt``` desde el directorio ```tests```.

> Nota: Si tienes ```redis-server``` en el PATH, simplemente ejecuta ```make test```. De lo contrario, ejecuta ```REDIS_SERVER=<redis-server-location> make test```. Para una salida más detallada, ejecuta ```make test V=1```.

### Compilar en docker

El sistema de compilación de FalkorDB se ejecuta dentro de docker. Para instrucciones detalladas sobre cómo compilar, por favor [consulta aquí](https://docs.falkordb.com/docker-examples/README.html).

## CARGAR FALKORDB EN REDIS

FalkorDB es alojado por [Redis](https://redis.io), así que primero tendrás que cargarlo como un Módulo en un servidor Redis. 
> Nota: [Redis 6.2](https://redis.io/download) es requerido para FalkorDB 2.12.

💡 Recomendamos que Redis cargue FalkorDB durante el arranque agregando lo siguiente a tu archivo redis.conf:

```
loadmodule /path/to/module/src/falkordb.so
```

En la línea anterior, reemplaza `/path/to/module/src/falkordb.so` con la ruta real a la biblioteca de FalkorDB.
Si Redis está ejecutándose como un servicio, debes asegurarte de que el usuario `redis` (por defecto) tenga los permisos necesarios de archivo/carpeta
para acceder a `falkordb.so`.

Alternativamente, puedes hacer que Redis cargue FalkorDB usando la siguiente sintaxis de argumento de línea de comandos:

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Por último, también puedes usar el comando [`MODULE LOAD`](http://redis.io/commands/module-load). Sin embargo, nota que `MODULE LOAD` es un comando peligroso y puede ser bloqueado/depreciado en el futuro debido a consideraciones de seguridad.

Una vez que hayas cargado FalkorDB exitosamente, tu log de Redis debería mostrar líneas similares a:

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Si el servidor falla al arrancar con una salida similar a:

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

El sistema no tiene la dependencia de tiempo de ejecución OpenMP. Esto se puede instalar en Ubuntu con `apt-get install libgomp1`, en RHEL/CentOS con `yum install libgomp`, y en OSX con `brew install libomp`.

## USANDO FALKORDB

Puedes llamar a los comandos de FalkorDB desde cualquier cliente Redis. Aquí hay varios métodos:

### Con `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Con cualquier otro cliente

Puedes interactuar con FalkorDB usando la capacidad de tu cliente para enviar comandos Redis en crudo.

>Nota: Dependiendo del cliente que elijas, el método exacto puede variar.

#### Ejemplo: Usando FalkorDB con un cliente Python

Este fragmento de código muestra cómo usar FalkorDB desde Python usando [falkordb-py](https://github.com/FalkorDB/falkordb-py):

```Python
from falkordb import FalkorDB

# Conectar con FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Seleccionar el grafo social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## LIBRERÍAS DE CLIENTE

>Nota: Algunos lenguajes tienen librerías de cliente que proveen soporte para los comandos de FalkorDB:

### Clientes Oficiales


| Proyecto                                                   | Lenguaje   | Licencia | Autor                                      | Estrellas                                                             | Paquete | Comentario    |
| --------------------------------------------------------- | ---------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | ---------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |


### Clientes Adicionales

| Proyecto                                                   | Lenguaje   | Licencia | Autor                                      | Estrellas                                                             | Paquete | Comentario    |
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
| [rustis][rustis-url]                                     | Rust       | MIT          | [Dahomey Technologies][rustis-author]       | [![rustis-stars]][rustis-url]    | [Crate](https://crates.io/crates/rustis) | [Documentación](https://docs.rs/rustis/latest/rustis/commands/trait.GraphCommands.html) |
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

## LICENCIA

Licenciado bajo la Server Side Public License v1 (SSPLv1). Consulta [LICENSE](LICENSE.txt).

### Apoya nuestro trabajo

⭐️ Si encuentras este repositorio útil, ¡considera darle una estrella!

↗️ Grafo, base de datos de grafos, RAG, graphrag, Retrieval-Augmented Generation, Recuperación de Información, Procesamiento de Lenguaje Natural, LLM, Embeddings, Búsqueda Semántica

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---