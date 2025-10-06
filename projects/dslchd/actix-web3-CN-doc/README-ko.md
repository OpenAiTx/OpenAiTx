# actix-web 3.0 한국어 문서

## 1.설명
기본적으로 공식 문서를 번역한 것이지만, 예제는 반드시 공식과 동일하지 않습니다. 모든 예제 코드는 공식 문서의 예제에서 가져왔지만 완전히 동일하지는 않습니다.

학습과 이해를 병행하며 작성한 데모 코드이며 모두 정상적으로 작동합니다.

다음 명령어 + 지정한 파일명으로 실행하여 결과를 확인할 수 있습니다:

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

## 패턴(Patterns)
[자동 재로딩(Auto-Reloading)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/AutoReloading.md)

[데이터베이스(Databases)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/Databases.md)

## 도해(Diagrams)
[HTTP 서버 초기화(HTTP Server Initialization)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/HTTPServerInitialization.md)

[커넥션 수명 주기(Connection Lifecycle)](https://raw.githubusercontent.com/dslchd/actix-web3-CN-doc/master/doc/ConnectionLifecycle.md)

## API 문서
[actix](https://docs.rs/actix)

[actix-web](https://docs.rs/actix-web/)

## 3. 기타
역량이 부족하여 번역 과정에서 오류나 누락이 있을 수 있으니 발견 시 제게 즉시 알려주시기 바랍니다(issue 제기).

이 문서가 영어 원문을 보기 어렵거나 영어가 익숙하지 않은 분들이 `Actix-web`과 `Rust`로 웹 애플리케이션을 개발하거나 학습할 때 도움이 되길 바랍니다,
모두 함께 성장하며 Rust의 대중화에 조금이나마 기여하고자 합니다.

**이 문서가 학습에 도움이 되었다면 별(star) 하나 눌러주세요, 이것이 제가 계속해서 업데이트를 이어가는 원동력이 됩니다.**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---