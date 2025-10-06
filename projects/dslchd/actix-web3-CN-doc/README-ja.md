# actix-web 3.0 中文文档

## 1.説明
基本的には公式ドキュメントを翻訳したものですが、サンプルは必ずしも公式と同じではありません。すべてのサンプルコードは公式ドキュメントの例を元にしていますが、完全に同一ではありません。

学びながら理解して書いたデモコードで、すべて正常に動作します。

以下のコマンド + 指定ファイル名で実行して結果を確認できます:

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

## パターン(Patterns)
[自動リロード(Auto-Reloading)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/AutoReloading.md)

[データベース(Databases)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Databases.md)

## 図解(Diagrams)
[HTTPサーバー初期化(HTTP Server Initialization)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/HTTPServerInitialization.md)

[コネクションライフサイクル(Connection Lifecycle)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/ConnectionLifecycle.md)

## APIドキュメント
[actix](https://docs.rs/actix)

[actix-web](https://docs.rs/actix-web/)

## 3.その他
実力不足のため、翻訳過程で誤りや抜けがあるかもしれません。見つけた場合は速やかにご指摘ください（issueを提起）。

このドキュメントが、英語原文を読みたくない、または英語が苦手な方が `Actix-web` と `Rust` を使ってWebアプリケーションを開発・学習する際の助けになれば幸いです。
皆で共に成長し、Rustの普及に微力ながら貢献できればと思います。

**もしこの学習が役に立ったと思われたら、スターを押していただけると励みになります。これからも継続して更新していく原動力となります。**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---