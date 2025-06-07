[![Dockerhub](https://img.shields.io/docker/pulls/falkordb/falkordb?label=Docker)](https://hub.docker.com/r/falkordb/falkordb/)
[![Discord](https://img.shields.io/discord/1146782921294884966?style=flat-square)](https://discord.gg/6M4QwDXn2w)
[![codecov](https://codecov.io/gh/falkordb/falkordb/graph/badge.svg?token=0G4HBEJMW0)](https://codecov.io/gh/falkordb/falkordb)
[![Workflow](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/FalkorDB/FalkorDB/actions/workflows/build.yml)

# FalkorDB - Base de Données Graphes pour GraphRAG & GenAI

Une base de données graphe évolutive et à faible latence conçue pour les équipes de développement gérant des données structurées et non structurées interconnectées en temps réel ou dans des environnements interactifs.

[![Essayer Gratuitement](https://img.shields.io/badge/Try%20Free-FalkorDB%20Cloud-FF8101?labelColor=FDE900&style=for-the-badge&link=https://app.falkordb.cloud)](https://app.falkordb.cloud)<br>

![FalkorDB Graph Database](https://raw.githubusercontent.com/FalkorDB/FalkorDB/master/assets/header.jpg)

## FONCTIONNALITÉS UNIQUES

Notre objectif est de construire un graphe de connaissances haute performance adapté aux grands modèles de langage (LLM), en privilégiant une latence exceptionnellement faible pour garantir une livraison rapide et efficace de l'information via notre base de données graphe.

🆕 [FalkorDB](https://www.falkordb.com/) est la première **base de données [Property Graph](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc) interrogeable à exploiter les matrices creuses** pour représenter la [matrice d'adjacence](https://en.wikipedia.org/wiki/Adjacency_matrix) dans les graphes et l'[algèbre linéaire](https://en.wikipedia.org/wiki/Adjacency_matrix) pour les requêtes.

### Principales Fonctionnalités

* **Représentation par Matrices Creuses** : Utilise des matrices creuses pour représenter les matrices d'adjacence, optimisant le stockage et les performances.

* **Requêtes en Algèbre Linéaire** : Utilise l'algèbre linéaire pour l'exécution des requêtes, améliorant l'efficacité computationnelle.

* **Conformité au Modèle Property Graph** : Prend en charge les nœuds et relations avec attributs, conformément au modèle Property Graph.

* **Support OpenCypher :** Compatible avec le langage de requête [OpenCypher](https://github.com/opencypher/openCypher/blob/master/docs/property-graph-model.adoc), incluant des extensions propriétaires pour des capacités d'interrogation avancées.

>Découvrez FalkorDB en action en visitant les [Démos](https://github.com/FalkorDB/FalkorDB/tree/master/demo).

## DOCUMENTATION

[Documentation Officielle](https://docs.falkordb.com/) | [Clients](https://docs.falkordb.com/clients.html) | [Commandes](https://docs.falkordb.com/commands/) | 📊 [Derniers Résultats de Performance](https://benchmark.falkordb.com/)

### Communauté et Support

* **Discussions** : Rejoignez nos discussions communautaires sur [GitHub Discussions](https://github.com/FalkorDB/FalkorDB/discussions) pour poser des questions, partager des idées et échanger avec d'autres utilisateurs.

* **Contribuer** : Nous accueillons les contributions ! Veuillez consulter notre [Guide de Contribution](https://github.com/FalkorDB/FalkorDB/blob/master/CONTRIBUTING.md) pour plus de détails.

* **Licence** : Ce projet est sous licence Server Side Public License v1 (SSPLv1). Voir le fichier [LICENSE](https://github.com/FalkorDB/FalkorDB/blob/master/LICENSE.txt) pour plus d'informations.

## DÉMARRER

### Étape 1

Pour essayer rapidement FalkorDB, lancez une instance à l'aide de Docker :

```
docker run -p 6379:6379 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

Ou, pour utiliser l'interface intégrée basée sur navigateur, lancez :

```
docker run -p 6379:6379 -p 3000:3000 -it --rm -v ./data:/var/lib/falkordb/data falkordb/falkordb:edge
```

### Étape 2

Ensuite, ouvrez votre navigateur et allez à `http://localhost:3000`.

Vous pouvez également interagir avec FalkorDB à l'aide de l'une des [Bibliothèques Clients](https://docs.falkordb.com/clients.html) prises en charge.

### Exemple de Ligue MotoGP

Dans cet exemple, nous allons utiliser le [client Python FalkorDB](https://pypi.org/project/FalkorDB/) pour créer un petit graphe représentant un sous-ensemble de pilotes et d'équipes participant à la ligue MotoGP. Après avoir créé le graphe, nous interrogerons les données pour explorer sa structure et ses relations.

```python
from falkordb import FalkorDB

# Connexion à FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Création du graphe 'MotoGP'
g = db.select_graph('MotoGP')
g.query("""CREATE (:Rider {name:'Valentino Rossi'})-[:rides]->(:Team {name:'Yamaha'}),
                  (:Rider {name:'Dani Pedrosa'})-[:rides]->(:Team {name:'Honda'}),
                  (:Rider {name:'Andrea Dovizioso'})-[:rides]->(:Team {name:'Ducati'})""")

# Quels pilotes représentent Yamaha ?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team)
                 WHERE t.name = 'Yamaha'
                 RETURN r.name""")

for row in res.result_set:
	print(row[0])

# Affiche : "Valentino Rossi"

# Combien de pilotes représentent l'équipe Ducati ?
res = g.query("""MATCH (r:Rider)-[:rides]->(t:Team {name:'Ducati'})
                 RETURN count(r)""")

print(res.result_set[0][0])
# Affiche : 1
```

## COMMENCEZ À DÉVELOPPER

### Compilation

Assurez-vous de remplir ces prérequis :

1️⃣ Le dépôt FalkorDB : `git clone --recurse-submodules -j8 https://github.com/FalkorDB/FalkorDB.git`

>Sur Ubuntu Linux, exécutez : `apt-get install build-essential cmake m4 automake peg libtool autoconf python3 python3-pip`
	
>Sur OS X, vérifiez que `homebrew` est installé et exécutez : `brew install cmake m4 automake peg libtool autoconf`.
>>La version de Clang fournie avec l'outil OS X ne supporte pas OpenMP, qui est requis pour FalkorDB. Pour résoudre ce problème, exécutez `brew install gcc g++` et suivez les instructions à l'écran pour mettre à jour les liens symboliques. Notez que cela est un changement global au système - définir les variables d'environnement `CC` et `CXX` fonctionnera si ce n'est pas une option.

2️⃣ Compilez en exécutant `make` dans le répertoire du projet.

Félicitations ! Vous trouverez le binaire compilé à `bin/<arch>/src/falkordb.so`.

### Exécution des tests

Commencez par installer les paquets Python requis en exécutant ```pip install -r requirements.txt``` depuis le répertoire ```tests```.

> Remarque : Si vous avez ```redis-server``` dans le PATH, lancez simplement ```make test```. Sinon, lancez ```REDIS_SERVER=<emplacement-redis-server> make test```. Pour une sortie plus détaillée, lancez ```make test V=1```.

### Compilation dans un docker

Le système de compilation de FalkorDB fonctionne dans un conteneur Docker. Pour des instructions détaillées sur la compilation, veuillez [voir ici](https://docs.falkordb.com/docker-examples/README.html).

## CHARGEMENT DE FALKORDB DANS REDIS

FalkorDB est hébergé par [Redis](https://redis.io), vous devrez donc d'abord le charger comme module dans un serveur Redis.
> Remarque : [Redis 6.2](https://redis.io/download) est requis pour FalkorDB 2.12.

💡 Nous recommandons de charger FalkorDB lors du démarrage de Redis en ajoutant la ligne suivante à votre fichier redis.conf :

```
loadmodule /path/to/module/src/falkordb.so
```

Dans la ligne ci-dessus, remplacez `/path/to/module/src/falkordb.so` par le chemin réel vers la bibliothèque de FalkorDB.
Si Redis fonctionne comme un service, assurez-vous que l'utilisateur `redis` (par défaut) dispose des droits nécessaires pour accéder à `falkordb.so`.

Alternativement, vous pouvez charger FalkorDB via la ligne de commande suivante :

```sh
~/$ redis-server --loadmodule /path/to/module/src/falkordb.so
```

Enfin, vous pouvez aussi utiliser la commande [`MODULE LOAD`](http://redis.io/commands/module-load). Notez cependant que `MODULE LOAD` est une commande dangereuse et pourrait être bloquée/dépréciée à l'avenir pour des raisons de sécurité.

Une fois FalkorDB chargé avec succès, votre journal Redis devrait afficher des lignes similaires à :

```
...
30707:M 20 Jun 02:08:12.314 * Module 'graph' loaded from <redacted>/src/falkordb.so
...
```

Si le serveur échoue au lancement avec une sortie du type :

```
# Module /usr/lib/redis/modules/falkordb.so failed to load: libgomp.so.1: cannot open shared object file: No such file or directory
# Can't load module from /usr/lib/redis/modules/falkordb.so: server aborting
```

Le système manque de la dépendance d'exécution OpenMP. Installez-la sous Ubuntu avec `apt-get install libgomp1`, sous RHEL/CentOS avec `yum install libgomp`, et sous OSX avec `brew install libomp`.

## UTILISATION DE FALKORDB

Vous pouvez appeler les commandes FalkorDB depuis n'importe quel client Redis. Voici plusieurs méthodes :

### Avec `redis-cli`

```sh
$ redis-cli
127.0.0.1:6379> GRAPH.QUERY social "CREATE (:person {name: 'roi', age: 33, gender: 'male', status: 'married'})"
```

### Avec un autre client

Vous pouvez interagir avec FalkorDB en utilisant la capacité de votre client à envoyer des commandes brutes Redis.

>Remarque : En fonction de votre client, la méthode exacte peut varier.

#### Exemple : Utilisation de FalkorDB avec un client Python

Ce code montre comment utiliser FalkorDB depuis Python avec [falkordb-py](https://github.com/FalkorDB/falkordb-py) :

```Python
from falkordb import FalkorDB

# Connexion à FalkorDB
db = FalkorDB(host='localhost', port=6379)

# Sélection du graphe social
g = db.select_graph('social')

reply = g.query("CREATE (:person {name:'roi', age:33, gender:'male', status:'married'})")
```

## BIBLIOTHÈQUES CLIENTS

>Remarque : Certaines bibliothèques clientes offrent un support pour les commandes FalkorDB :

### Clients officiels

| Projet                                                   | Langage   | Licence | Auteur                                      | Stars                                                             | Package | Commentaire    |
| -------------------------------------------------------- | --------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | -------------- |
| [jfalkordb][jfalkordb-url] | Java | BSD | [FalkorDB][falkordb-url] | [![jfalkordb-stars]][jfalkordb-url] | [Maven][jfalkordb-package]||
| [falkordb-py][falkordb-py-url] | Python | MIT | [FalkorDB][falkordb-url] | [![falkordb-py-stars]][falkordb-py-url] | [pypi][falkordb-py-package]||
| [falkordb-ts][falkordb-ts-url] | Node.JS | MIT | [FalkorDB][falkordb-url] | [![falkordb-ts-stars]][falkordb-ts-url] | [npm][falkordb-ts-package]||
| [falkordb-rs][falkordb-rs-url] | Rust | MIT | [FalkorDB][falkordb-url] | [![falkordb-rs-stars]][falkordb-rs-url] | [Crate][falkordb-rs-package]||
| [falkordb-go][falkordb-go-url] | Go | BSD | [FalkorDB][falkordb-url] | [![falkordb-go-stars]][falkordb-go-url] | [GitHub][falkordb-go-url]||
| [NFalkorDB][nfalkordb-url]  |  C# | Apache-2.0 | [FalkorDB][falkordb-url] | [![nfalkordb-stars]][nfalkordb-url] | [nuget][nfalkordb-package] | |

### Clients additionnels

| Projet                                                   | Langage   | Licence | Auteur                                      | Stars                                                             | Package | Commentaire    |
| -------------------------------------------------------- | --------- | ------- | ------------------------------------------- | ----------------------------------------------------------------- | ------- | -------------- |
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

## LICENCE

Sous licence Server Side Public License v1 (SSPLv1). Voir [LICENSE](LICENSE.txt).

### Soutenez notre travail

⭐️ Si ce dépôt vous est utile, pensez à lui attribuer une étoile !

↗️ Graphe, base de données graphe, RAG, graphrag, Retrieval-Augmented Generation, Recherche d'Information, Traitement du Langage Naturel, LLM, Embeddings, Recherche Sémantique

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---