# actix-web 3.0 Documentation en français

## 1. Description
C'est essentiellement une traduction du document officiel, mais les exemples ne sont pas nécessairement identiques à ceux de l'original. Tous les exemples de code proviennent des exemples du document officiel, mais ne sont pas complètement les mêmes.

Ce sont des codes de démonstration écrits tout en apprenant et comprenant, et tous fonctionnent correctement.

Vous pouvez utiliser la commande suivante + le nom de fichier spécifié pour exécuter et voir le résultat :

```shell script
cargo run --bin hello_world
```

**另外:** `Actix-Web` 的网络部分是基于[Tokio](https://tokio.rs/tokio/tutorial) 来实现的. 因此要想更加深入的了解`Actix-web`的实现细节, `Tokio`是你
必须要学习和了解的框架. `Tokio` 的中文文档指南请参考: [这里](https://github.com/dslchd/tokio-cn-doc).

## 2.文档索引
### 介绍(Introduction)
[欢迎(Welcome)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/WelcomeToActix.md)

[什么是Actix(What is Actix)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/WhatIsActix.md)
### 基础(Basics)
[起步(Getting Started)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/GettingStarted.md)

[应用(Application)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Application.md)

[服务器(Server)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Server.md)

[处理器(Handlers)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Handlers.md)

[提取器(Extractors)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Extractors.md)

### 高级(Advanced)
[错误(Errors)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Errors.md)

[URL分发(URL Dispatch)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/URLDispatch.md)

[请求(Requests)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Requests.md)

[响应(Responses)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Responses.md)

[测试(Testing)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Testing.md)

[中间件(Middleware)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Middleware.md)

[静态文件(Static Files)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/StaticFiles.md)

### 协议(Protocols)
[Websockets](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Webscokets.md)

[HTTP/2](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/HTTP2.md)

## Modèles (Patterns)
[Rechargement automatique (Auto-Reloading)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/AutoReloading.md)

[Bases de données (Databases)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Databases.md)

## Diagrammes (Diagrams)
[Initialisation du serveur HTTP (HTTP Server Initialization)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/HTTPServerInitialization.md)

[Cycle de vie de la connexion (Connection Lifecycle)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/ConnectionLifecycle.md)

## Documentation API
[actix](https://docs.rs/actix)

[actix-web](https://docs.rs/actix-web/)

## 3. Autres
En raison de mes compétences limitées, des erreurs ou omissions peuvent survenir lors de la traduction, n’hésitez pas à me les signaler rapidement (ouvrir un issue).

J’espère que ce document pourra aider ceux qui ne veulent pas lire l’original en anglais ou qui ont des difficultés avec l’anglais, lors de l’utilisation ou de l’apprentissage de `Actix-web` et `Rust` pour développer des applications Web,
améliorons-nous ensemble et contribuons un peu à la popularité de Rust.

**Si vous pensez que ce document vous a aidé dans votre apprentissage, merci de mettre une étoile, ce sera ma motivation pour continuer à le mettre à jour régulièrement.**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---