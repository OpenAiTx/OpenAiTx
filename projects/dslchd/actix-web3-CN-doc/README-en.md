# actix-web 3.0 Chinese Documentation

## 1. Introduction
Basically, it is a translation of the official documentation, but the examples are not necessarily the same as the official ones. All example codes are derived from examples in the official documentation, but are not completely identical.

It can be considered as demo code written while learning and understanding, and all can run normally.

You can use the following command + specify the file name to execute and see the results:

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

## Patterns
[Auto-Reloading](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/AutoReloading.md)

[Databases](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Databases.md)

## Diagrams
[HTTP Server Initialization](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/HTTPServerInitialization.md)

[Connection Lifecycle](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/ConnectionLifecycle.md)

## API Documentation
[actix](https://docs.rs/actix)

[actix-web](https://docs.rs/actix-web/)

## 3. Others
Due to limited proficiency, errors or omissions are inevitable during the translation process; please feel free to point them out to me promptly (file an issue).

I hope this document can help those who do not want to read the original English or whose English is not very good when using or learning `Actix-web` and `Rust` to develop web applications.
Let’s improve together and contribute a little to the popularity of Rust.

**If you feel this has helped your learning, please give a star; this will be my motivation to keep updating continuously.**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---