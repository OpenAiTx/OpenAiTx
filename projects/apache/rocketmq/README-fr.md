## Apache RocketMQ

[![Build Status][maven-build-image]][maven-build-url]
[![CodeCov][codecov-image]][codecov-url]
[![Maven Central][maven-central-image]][maven-central-url]
[![Release][release-image]][release-url]
[![License][license-image]][license-url]
[![Average Time to Resolve An Issue][percentage-of-issues-still-open-image]][percentage-of-issues-still-open-url]
[![Percentage of Issues Still Open][average-time-to-resolve-an-issue-image]][average-time-to-resolve-an-issue-url]
[![Twitter Follow][twitter-follow-image]][twitter-follow-url]

**[Apache RocketMQ](https://rocketmq.apache.org) est une plateforme de messagerie et de streaming distribuée avec une faible latence, haute performance et fiabilité, une capacité à l’échelle du billion et une scalabilité flexible.**


Elle offre une variété de fonctionnalités :

* Modèles de messagerie incluant publication/abonnement, requête/réponse et streaming
* Messages transactionnels de qualité financière
* Options intégrées de tolérance aux pannes et de haute disponibilité basées sur [DLedger Controller](https://raw.githubusercontent.com/apache/rocketmq/develop/docs/en/controller/quick_start.md)
* Fonctionnalité intégrée de traçage des messages, supportant également opentracing
* Intégration polyvalente avec l’écosystème big data et streaming
* Rétroactivité des messages par temps ou décalage
* Messagerie FIFO fiable et strictement ordonnée dans la même file
* Modèle de consommation efficace en pull et push
* Capacité d’accumulation de messages au niveau du million dans une seule file
* Plusieurs protocoles de messagerie tels que gRPC, MQTT, JMS et OpenMessaging
* Architecture flexible de déploiement distribué en scale-out
* Système d’échange de messages par lots ultra-rapide
* Divers mécanismes de filtrage de messages tels que SQL et Tag
* Images Docker pour tests isolés et clusters isolés en cloud
* Tableau de bord administratif riche en fonctionnalités pour configuration, métriques et surveillance
* Authentification et autorisation
* Connecteurs open source gratuits, pour sources et destinations
* Calcul en temps réel léger
----------


## Démarrage rapide

Ce paragraphe vous guide à travers les étapes d’installation de RocketMQ de différentes manières.
Pour le développement local et les tests, une seule instance sera créée pour chaque composant.

### Exécuter RocketMQ localement

RocketMQ fonctionne sur tous les principaux systèmes d'exploitation et nécessite uniquement l'installation d'un JDK Java version 8 ou supérieure.
Pour vérifier, exécutez `java -version` :
```shell
$ java -version
java version "1.8.0_121"
```
Pour les utilisateurs de Windows, cliquez [ici](https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip) pour télécharger la version binaire 5.3.3 de RocketMQ,  
décompressez-la sur votre disque local, par exemple `D:\rocketmq`.  
Pour les utilisateurs de macOS et Linux, exécutez les commandes suivantes :  


```shell
# Download release from the Apache mirror
$ wget https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip

# Unpack the release
$ unzip rocketmq-all-5.3.3-bin-release.zip
```

Préparez un terminal et changez pour le répertoire `bin` extrait :
```shell
$ cd rocketmq-all-5.3.3-bin-release/bin
```

**1) Démarrer NameServer**

NameServer écoutera sur `0.0.0.0:9876`, assurez-vous que le port n'est pas utilisé par d'autres sur la machine locale, puis procédez comme suit.

Pour les utilisateurs de macOS et Linux :
```shell
### start Name Server
$ nohup sh mqnamesrv &

### check whether Name Server is successfully started
$ tail -f ~/logs/rocketmqlogs/namesrv.log
The Name Server boot success...
```

Pour les utilisateurs Windows, vous devez d'abord définir les variables d'environnement :  
- Depuis le bureau, faites un clic droit sur l'icône Ordinateur.  
- Choisissez Propriétés dans le menu contextuel.  
- Cliquez sur le lien Paramètres système avancés.  
- Cliquez sur Variables d'environnement.  
- Ajoutez la variable d'environnement `ROCKETMQ_HOME="D:\rocketmq"`.  

Ensuite, changez de répertoire vers rocketmq, tapez et exécutez :
```shell
$ mqnamesrv.cmd
The Name Server boot success...
```

**2) Démarrer le courtier**

Pour les utilisateurs de macOS et Linux :
```shell
### start Broker
$ nohup sh bin/mqbroker -n localhost:9876 &

### check whether Broker is successfully started, eg: Broker's IP is 192.168.1.2, Broker's name is broker-a
$ tail -f ~/logs/rocketmqlogs/broker.log
The broker[broker-a, 192.169.1.2:10911] boot success...
```

Pour les utilisateurs de Windows :
```shell
$ mqbroker.cmd -n localhost:9876
The broker[broker-a, 192.169.1.2:10911] boot success...
```

### Exécuter RocketMQ dans Docker

Vous pouvez exécuter RocketMQ sur votre propre machine dans des conteneurs Docker,  
le réseau `host` sera utilisé pour exposer le port d'écoute dans le conteneur.

**1) Démarrer NameServer**

```shell
$ docker run -it --net=host apache/rocketmq ./mqnamesrv
```

**2) Démarrer le courtier**

```shell
$ docker run -it --net=host --mount type=bind,source=/tmp/store,target=/home/rocketmq/store apache/rocketmq ./mqbroker -n localhost:9876
```

### Exécuter RocketMQ dans Kubernetes

Vous pouvez également exécuter un cluster RocketMQ au sein d’un cluster Kubernetes en utilisant [RocketMQ Operator](https://github.com/apache/rocketmq-operator).
Avant vos opérations, assurez-vous que `kubectl` et le fichier kubeconfig associé sont installés sur votre machine.

**1) Installer les CRD**
```shell
### install CRDs
$ git clone https://github.com/apache/rocketmq-operator
$ cd rocketmq-operator && make deploy

### check whether CRDs is successfully installed
$ kubectl get crd | grep rocketmq.apache.org
brokers.rocketmq.apache.org                 2022-05-12T09:23:18Z
consoles.rocketmq.apache.org                2022-05-12T09:23:19Z
nameservices.rocketmq.apache.org            2022-05-12T09:23:18Z
topictransfers.rocketmq.apache.org          2022-05-12T09:23:19Z

### check whether operator is running
$ kubectl get pods | grep rocketmq-operator
rocketmq-operator-6f65c77c49-8hwmj   1/1     Running   0          93s
```

**2) Créer une instance de cluster**
```shell
### create RocketMQ cluster resource
$ cd example && kubectl create -f rocketmq_v1alpha1_rocketmq_cluster.yaml

### check whether cluster resources is running
$ kubectl get sts
NAME                 READY   AGE
broker-0-master      1/1     107m
broker-0-replica-1   1/1     107m
name-service         1/1     107m
```

---
## Communauté Apache RocketMQ
* [RocketMQ Streams](https://github.com/apache/rocketmq-streams) : Un moteur de calcul de flux léger basé sur Apache RocketMQ.
* [RocketMQ Flink](https://github.com/apache/rocketmq-flink) : Le connecteur Apache RocketMQ pour Apache Flink qui prend en charge les connecteurs source et sink dans les flux de données et Table.
* [RocketMQ APIs](https://github.com/apache/rocketmq-apis) : Protocole protobuf RocketMQ.
* [RocketMQ Clients](https://github.com/apache/rocketmq-clients) : Clients RocketMQ basés sur gRPC/protobuf.
* Clients basés sur RocketMQ Remoting
	 - [RocketMQ Client CPP](https://github.com/apache/rocketmq-client-cpp)
	 - [RocketMQ Client Go](https://github.com/apache/rocketmq-client-go)
	 - [RocketMQ Client Python](https://github.com/apache/rocketmq-client-python)
	 - [RocketMQ Client Nodejs](https://github.com/apache/rocketmq-client-nodejs)
* [RocketMQ Spring](https://github.com/apache/rocketmq-spring) : Un projet qui aide les développeurs à intégrer rapidement Apache RocketMQ avec Spring Boot.
* [RocketMQ Exporter](https://github.com/apache/rocketmq-exporter) : Un exportateur Apache RocketMQ pour Prometheus.
* [RocketMQ Operator](https://github.com/apache/rocketmq-operator) : Fournit un moyen d'exécuter un cluster Apache RocketMQ sur Kubernetes.
* [RocketMQ Docker](https://github.com/apache/rocketmq-docker) : Le dépôt Git de l'image Docker pour Apache RocketMQ.
* [RocketMQ Dashboard](https://github.com/apache/rocketmq-dashboard) : Console d'exploitation et de maintenance d'Apache RocketMQ.
* [RocketMQ Connect](https://github.com/apache/rocketmq-connect) : Un outil pour diffuser de manière évolutive et fiable des données entre Apache RocketMQ et d'autres systèmes.
* [RocketMQ MQTT](https://github.com/apache/rocketmq-mqtt) : Un nouveau modèle d'architecture du protocole MQTT, sur lequel Apache RocketMQ peut mieux prendre en charge les messages provenant de terminaux tels que les appareils IoT et les applications mobiles.
* [RocketMQ EventBridge](https://github.com/apache/rocketmq-eventbridge) : EventBridge facilite la création d'une application pilotée par les événements.
* [Projets communautaires en incubation RocketMQ](https://github.com/apache/rocketmq-externals) : Projets communautaires incubateurs d'Apache RocketMQ, incluant [logappender](https://github.com/apache/rocketmq-externals/tree/master/logappender), [rocketmq-ansible](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-ansible), [rocketmq-beats-integration](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-beats-integration), [rocketmq-cloudevents-binding](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-cloudevents-binding), etc.
* [Site RocketMQ](https://github.com/apache/rocketmq-site) : Le dépôt pour le site web Apache RocketMQ.
* [RocketMQ E2E](https://github.com/apache/rocketmq-e2e) : Un projet pour tester Apache RocketMQ, incluant des tests bout à bout, de performance et de compatibilité.


----------
## Apprenez-le & Contactez-nous
* Listes de diffusion : <https://rocketmq.apache.org/about/contact/>
* Accueil : <https://rocketmq.apache.org>
* Docs : <https://rocketmq.apache.org/docs/quick-start/>
* Problèmes : <https://github.com/apache/rocketmq/issues>
* Rips : <https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal>
* Poser une question : <https://stackoverflow.com/questions/tagged/rocketmq>
* Slack : <https://rocketmq-invite-automation.herokuapp.com/>


----------



## Contribution  
Nous accueillons toujours de nouvelles contributions, qu'il s'agisse de corrections triviales, de [nouvelles grandes fonctionnalités](https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal) ou d'autres récompenses matérielles, plus de détails voir [ici](http://rocketmq.apache.org/docs/how-to-contribute/).

----------  
## Licence  
[Licence Apache, Version 2.0](http://www.apache.org/licenses/LICENSE-2.0.html) Copyright (C) Fondation Apache Software

----------  
## Avis de contrôle à l'exportation  
Cette distribution inclut un logiciel cryptographique. Le pays dans lequel vous résidez actuellement peut avoir  
des restrictions sur l'importation, la possession, l'utilisation et/ou la réexportation vers un autre pays, de logiciels de chiffrement.  
AVANT d'utiliser un quelconque logiciel de chiffrement, veuillez vérifier les lois, règlements et politiques de votre pays concernant  
l'importation, la possession, l'utilisation et la réexportation de logiciels de chiffrement, pour voir si cela est autorisé. Voir  
<http://www.wassenaar.org/> pour plus d'informations.

Le Département du Commerce des États-Unis, Bureau de l'Industrie et de la Sécurité (BIS), a classifié ce  
logiciel sous le numéro de contrôle des exportations (ECCN) 5D002.C.1, qui inclut les logiciels de sécurité de l'information  
utilisant ou effectuant des fonctions cryptographiques avec des algorithmes asymétriques. La forme et la manière de cette distribution de la Fondation Apache  
Software la rendent éligible à l'exportation sous l'exception de licence ENC Technology  
Software Unrestricted (TSU) (voir les régulations d'administration des exportations du BIS, section 740.13) pour  
le code objet et le code source.

Les détails suivants fournissent plus d'informations sur le logiciel cryptographique inclus :

Ce logiciel utilise Apache Commons Crypto (https://commons.apache.org/proper/commons-crypto/) pour  
soutenir l'authentification, ainsi que le chiffrement et le déchiffrement des données transmises sur le réseau entre  
les services.

[maven-build-image]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml/badge.svg  
[maven-build-url]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml  
[codecov-image]: https://codecov.io/gh/apache/rocketmq/branch/master/graph/badge.svg  
[codecov-url]: https://codecov.io/gh/apache/rocketmq  
[maven-central-image]: https://maven-badges.herokuapp.com/maven-central/org.apache.rocketmq/rocketmq-all/badge.svg  
[maven-central-url]: http://search.maven.org/#search%7Cga%7C1%7Corg.apache.rocketmq  
[release-image]: https://img.shields.io/badge/release-download-orange.svg  
[release-url]: https://www.apache.org/licenses/LICENSE-2.0.html  
[license-image]: https://img.shields.io/badge/license-Apache%202-4EB1BA.svg  
[license-url]: https://www.apache.org/licenses/LICENSE-2.0.html  
[average-time-to-resolve-an-issue-image]: http://isitmaintained.com/badge/resolution/apache/rocketmq.svg

[average-time-to-resolve-an-issue-url]: http://isitmaintained.com/project/apache/rocketmq
[percentage-of-issues-still-open-image]: http://isitmaintained.com/badge/open/apache/rocketmq.svg
[percentage-of-issues-still-open-url]: http://isitmaintained.com/project/apache/rocketmq
[twitter-follow-image]: https://img.shields.io/twitter/follow/ApacheRocketMQ?style=social
[twitter-follow-url]: https://twitter.com/intent/follow?screen_name=ApacheRocketMQ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---