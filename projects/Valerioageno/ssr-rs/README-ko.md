# 🚀 러스트 서버 사이드 렌더링

[![API](https://docs.rs/ssr_rs/badge.svg)](https://docs.rs/ssr_rs)
[![codecov](https://codecov.io/gh/Valerioageno/ssr-rs/branch/main/graph/badge.svg?token=O0CZIZAR7X)](https://codecov.io/gh/Valerioageno/ssr-rs)

이 크레이트는 러스트 서버에서 가능한 가장 간단하고 가벼운 방식으로 서버 사이드 렌더링을 가능하게 하는 것을 목표로 합니다.

내장된 [V8](https://v8.dev/) 자바스크립트 엔진(<a href="https://github.com/denoland/rusty_v8" target="_blank">rusty_v8</a>) 버전을 사용하여 빌드된 번들 파일을 파싱하고 평가하여 렌더링된 HTML 문자열을 반환합니다.
> [!NOTE]
>  이 프로젝트는 내장 SSR을 가진 풀스택 리액트 프레임워크 [tuono](https://github.com/Valerioageno/tuono)의 핵심입니다.

현재 [Vite](https://vitejs.dev/), [Webpack](https://webpack.js.org/), [Rspack](https://www.rspack.dev/), [React 18](https://react.dev/) 및 [Svelte 5](https://svelte.dev/)와 작동합니다 - `examples/` 폴더를 확인하세요.

> 벤치마크 결과는 <a href="https://github.com/Valerioageno/ssr-rs/blob/main/benches">여기</a>를 확인하세요.

## 시작하기

`Cargo.toml`에 다음을 추가하세요:

```bash
cargo add ssr_rs
```
## 예제

번들된 리액트 프로젝트를 문자열로 렌더링하려면 애플리케이션이 다음 호출을 수행해야 합니다.



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
## "entryPoint"란 무엇인가?

`entryPoint`는 다음 중 하나일 수 있습니다:
- 호출 시 렌더링된 결과를 반환하는 함수인 하나 이상의 프로퍼티를 가진 객체를 반환하는 함수
- 호출 시 렌더링된 결과를 반환하는 함수인 하나 이상의 프로퍼티를 가진 객체 자체

번들된 JS가 IIFE이거나 일반 객체인 경우 `entryPoint`는 빈 문자열입니다.


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

> 내보내기 결과는 번들러에 의해 직접 관리됩니다.

## 초기 속성 예제

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

## actix-web 예제

> 다양한 웹 프레임워크 예제는 <a href="https://github.com/Valerioageno/ssr-rs/blob/main/examples" target="_blank">examples</a> 폴더에서 확인할 수 있습니다.

V8 엔진은 서로 다른 스레드에서 동일한 `isolate`에 접근하는 것을 허용하지만, 이 크레이트에서는 두 가지 이유로 이를 금지합니다:

1. rusty_v8 라이브러리는 아직 V8 Locker API를 구현하지 않았습니다. 다른 스레드에서 Ssr 구조체에 접근하면 V8 엔진이 패닉을 일으킵니다.
2. HTML 렌더링은 스레드 간 공유 상태가 필요하지 않습니다.

위 이유들로 인해 병렬 계산이 더 나은 선택입니다. 다음은 actix-web 설정 예입니다:

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
## 기여하기

어떠한 도움이나 제안도 감사히 받겠습니다.

알려진 TODOs: 
- 다른 러스트 백엔드 프레임워크 예제 추가
- 다른 프론트엔드 프레임워크 예제 추가 (예: vue, quik, solid)
- Deno와 Bun에 대한 벤치마크 설정 추가
- V8 스냅샷 지원 탐색
- WASM으로의 js 컴파일 탐색 (예: [javy](https://github.com/bytecodealliance/javy))

## 라이선스

이 프로젝트는 MIT 라이선스 하에 있습니다 - 자세한 내용은 <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_MIT">LICENSE_MIT</a> || <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_APACHE">LICENSE_APACHE</a> 파일을 참조하세요.

<br>

<p align="center">
  <img src="https://raw.githubusercontent.com/Valerioageno/ssr-rs/main/logo.png">
</p>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---