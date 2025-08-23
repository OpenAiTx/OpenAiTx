# 🚀 Rust 服务器端渲染

[![API](https://docs.rs/ssr_rs/badge.svg)](https://docs.rs/ssr_rs)
[![codecov](https://codecov.io/gh/Valerioageno/ssr-rs/branch/main/graph/badge.svg?token=O0CZIZAR7X)](https://codecov.io/gh/Valerioageno/ssr-rs)

该 crate 旨在以最简单和最轻量的方式实现在 Rust 服务器上的服务器端渲染。

它使用嵌入式版本的 [V8](https://v8.dev/) JavaScript 引擎（<a href="https://github.com/denoland/rusty_v8" target="_blank">rusty_v8</a>）来解析和执行构建好的 bundle 文件，并返回带有渲染 HTML 的字符串。
> [!NOTE]
>  该项目是 [tuono](https://github.com/Valerioageno/tuono) 的核心；一个内置 SSR 的全栈 React 框架。

目前它支持 [Vite](https://vitejs.dev/)、[Webpack](https://webpack.js.org/)、[Rspack](https://www.rspack.dev/)、[React 18](https://react.dev/) 和 [Svelte 5](https://svelte.dev/) - 请查看 `examples/` 文件夹。

> 查看<a href="https://github.com/Valerioageno/ssr-rs/blob/main/benches">这里</a>的基准测试结果。

## 入门

将以下内容添加到你的 `Cargo.toml`：

```bash
cargo add ssr_rs
```

## 示例

要将打包的 React 项目渲染为字符串，应用程序应执行以下调用。


```rust
use ssr_rs::Ssr;
use std::fs::read_to_string;

fn main() {
    Ssr::create_platform();

    let source = read_to_string("./path/to/build.js").unwrap();

    let mut js = Ssr::new(&source, "entryPoint").unwrap();

    let html = js.render_to_string(None).unwrap();
    
    assert_eq!(html, "<!doctype html><html>...</html>".to_string());
}
```

## 什么是“entryPoint”？

`entryPoint` 可以是：
- 一个返回对象的函数，该对象包含一个或多个属性，这些属性是函数，调用时返回渲染结果
- 该对象本身，包含一个或多个属性，这些属性是函数，调用时返回渲染结果

如果打包后的 JS 是 IIFE 或纯对象，则 `entryPoint` 为空字符串。

```javascript
// IIFE example | bundle.js -> See vite-react example
(() => ({ renderToStringFn: (props) => "<html></html>" }))() // The entryPoint is an empty string
```

```javascript
// Plain object example | bundle.js 
({renderToStringFn: (props) => "<html></html>"}); // The entryPoint is an empty string
```

```javascript
// IIFE variable example | bundle.js -> See webpack-react example
var SSR = (() => ({renderToStringFn: (props) => "<html></html>"}))() // SSR is the entry point
```

```javascript
// Variable example | bundle.js -> See webpack-react example
var SSR = {renderToStringFn: (props) => "<html></html>"}; // SSR is the entry point
```

> 导出结果由打包器直接管理。

## 带初始属性的示例

```rust
use ssr_rs::Ssr;
use std::fs::read_to_string;

fn main() {
    Ssr::create_platform();

    let props = r##"{
        "params": [
            "hello",
            "ciao",
            "こんにちは"
        ]
    }"##;

    let source = read_to_string("./path/to/build.js").unwrap();

    let mut js = Ssr::new(&source, "entryPoint").unwrap();

    let html = js.render_to_string(Some(&props)).unwrap();

    assert_eq!(html, "<!doctype html><html>...</html>".to_string());
}
```

## 使用 actix-web 的示例

> 使用不同 Web 框架的示例可在 <a href="https://github.com/Valerioageno/ssr-rs/blob/main/examples" target="_blank">examples</a> 文件夹中找到。

尽管 V8 引擎允许从不同线程访问同一个 `isolate`，但本 crate 出于两个原因禁止这样做：

1. rusty_v8 库尚未实现 V8 Locker API。从不同线程访问 Ssr 结构会导致 V8 引擎崩溃。
2. 渲染 HTML 不需要跨线程共享状态。

基于以上原因，使用并行计算是更好的选择。以下是 actix-web 的设置：

```rust
use actix_web::{get, http::StatusCode, App, HttpResponse, HttpServer};
use std::cell::RefCell;
use std::fs::read_to_string;

use ssr_rs::Ssr;

thread_local! {
    static SSR: RefCell<Ssr<'static, 'static>> = RefCell::new(
            Ssr::from(
                read_to_string("./client/dist/ssr/index.js").unwrap(),
                "SSR"
                ).unwrap()
            )
}

#[actix_web::main]
async fn main() -> std::io::Result<()> {

    Ssr::create_platform();

    HttpServer::new(|| {
        App::new()
            .service(index)
    })
    .bind("127.0.0.1:8080")?
    .run()
    .await
}

#[get("/")]
async fn index() -> HttpResponse {
    let result = SSR.with(|ssr| ssr.borrow_mut().render_to_string(None).unwrap());

    HttpResponse::build(StatusCode::OK)
        .content_type("text/html; charset=utf-8")
        .body(result)
}
```

## 贡献

任何帮助或建议都将不胜感激。

已知待办事项：
- 添加其他 Rust 后端框架的示例
- 添加其他前端框架的示例（例如 vue、quik、solid）
- 添加基准测试设置以对比 Deno 和 Bun
- 探索对 V8 快照的支持
- 探索将 js 编译为 WASM（例如 [javy](https://github.com/bytecodealliance/javy)）

## 许可证

本项目采用 MIT 许可证 - 更多信息请参见 <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_MIT">LICENSE_MIT</a> || <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_APACHE">LICENSE_APACHE</a> 文件。

<br>

<p align="center">
  <img src="https://raw.githubusercontent.com/Valerioageno/ssr-rs/main/logo.png">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---