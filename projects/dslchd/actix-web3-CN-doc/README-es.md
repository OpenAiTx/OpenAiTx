# actix-web 3.0 中文文档

## 1.说明
基本上算是翻译了官文档,但是示例并不一定和官方的相同. 所有的示例代码都源自官方文档中的示例,但又不完全与之相同.

算是一边学习一边理解写出来的demo代码且全部都能正常运行.

可以使用如下命令 + 指定文件名执行并查看结果:

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

## Patrones (Patterns)
[Recarga Automática (Auto-Reloading)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/AutoReloading.md)

[Bases de Datos (Databases)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Databases.md)

## Diagramas (Diagrams)
[Inicialización del Servidor HTTP (HTTP Server Initialization)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/HTTPServerInitialization.md)

[Ciclo de Vida de la Conexión (Connection Lifecycle)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/ConnectionLifecycle.md)

## Documentación API
[actix](https://docs.rs/actix)

[actix-web](https://docs.rs/actix-web/)

## 3. Otros
Debido a mis limitaciones, es inevitable que haya errores u omisiones durante el proceso de traducción; si los detectas, no dudes en comunicármelo a tiempo (abrir un issue).

Espero que este documento pueda ayudar a quienes no quieren leer el original en inglés o no dominan bien el inglés, al usar o aprender `Actix-web` y `Rust` para desarrollar aplicaciones web,
mejorando juntos y contribuyendo un poco a la popularidad de Rust.

**Si consideras que te ha sido útil para tu aprendizaje, puedes ayudar dando una estrella; eso será la motivación para que siga actualizándolo continuamente.**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---