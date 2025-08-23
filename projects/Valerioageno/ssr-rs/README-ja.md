# 🚀 Rust サーバーサイドレンダリング

[![API](https://docs.rs/ssr_rs/badge.svg)](https://docs.rs/ssr_rs)
[![codecov](https://codecov.io/gh/Valerioageno/ssr-rs/branch/main/graph/badge.svg?token=O0CZIZAR7X)](https://codecov.io/gh/Valerioageno/ssr-rs)

このクレートは、Rustサーバーで可能な限りシンプルかつ軽量な方法でサーバーサイドレンダリングを実現することを目的としています。

[埋め込み版のV8](https://v8.dev/) JavaScriptエンジン（<a href="https://github.com/denoland/rusty_v8" target="_blank">rusty_v8</a>）を使用して、ビルドされたバンドルファイルを解析・評価し、レンダリングされたHTMLの文字列を返します。
> [!NOTE]
>  このプロジェクトは、組み込みSSRを備えたフルスタックReactフレームワークである[tuono](https://github.com/Valerioageno/tuono)の基盤となっています。

現在、[Vite](https://vitejs.dev/)、[Webpack](https://webpack.js.org/)、[Rspack](https://www.rspack.dev/)、[React 18](https://react.dev/)および[Svelte 5](https://svelte.dev/)に対応しています。`examples/`フォルダーを参照してください。

> ベンチマーク結果は<a href="https://github.com/Valerioageno/ssr-rs/blob/main/benches">こちら</a>をご覧ください。

## はじめに

`Cargo.toml`に以下を追加してください:

```bash
cargo add ssr_rs
```

## 例

バンドルされたReactプロジェクトを文字列にレンダリングするには、アプリケーションは次の呼び出しを実行する必要があります。


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

## 「entryPoint」とは何ですか？

`entryPoint` は次のいずれかです：
- 関数であり、その関数がオブジェクトを返し、そのオブジェクトの1つ以上のプロパティが関数で、それらの関数が呼び出されるとレンダリング結果を返すもの
- オブジェクト自体であり、そのオブジェクトの1つ以上のプロパティが関数で、それらの関数が呼び出されるとレンダリング結果を返すもの

バンドルされたJSがIIFEまたはプレーンオブジェクトの場合、`entryPoint` は空文字列です。

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

> エクスポート結果はバンドラーによって直接管理されます。

## 初期プロップスの例

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

## actix-webの例

> 異なるWebフレームワークの例は<a href="https://github.com/Valerioageno/ssr-rs/blob/main/examples" target="_blank">examples</a>フォルダにあります。

V8エンジンは異なるスレッドから同じ`isolate`にアクセスすることを許可していますが、このクレートでは以下の2つの理由から禁止しています：

1. rusty_v8ライブラリはまだV8 Locker APIを実装していません。異なるスレッドからSsr構造体にアクセスするとV8エンジンがパニックを起こします。
2. HTMLのレンダリングにはスレッド間で共有される状態は不要です。

上記の理由から、並列計算がより良い選択肢です。以下はactix-webのセットアップです：

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

## コントリビューティング

ご支援やご提案をお待ちしております。

既知のTODO: 
- 他のRustバックエンドフレームワークの例を追加する
- 他のフロントエンドフレームワークの例を追加する（例：vue、quik、solid）
- DenoやBunと比較するためのベンチマーク設定を追加する
- V8スナップショットのサポートを検討する
- jsのWASMへのコンパイルを検討する（例：[javy](https://github.com/bytecodealliance/javy)）

## ライセンス

このプロジェクトはMITライセンスの下でライセンスされています - 詳細は<a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_MIT">LICENSE_MIT</a> || <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_APACHE">LICENSE_APACHE</a>ファイルをご覧ください。

<br>

<p align="center">
  <img src="https://raw.githubusercontent.com/Valerioageno/ssr-rs/main/logo.png">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---