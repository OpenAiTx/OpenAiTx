# 🚀 Renderizado del lado servidor en Rust

[![API](https://docs.rs/ssr_rs/badge.svg)](https://docs.rs/ssr_rs)
[![codecov](https://codecov.io/gh/Valerioageno/ssr-rs/branch/main/graph/badge.svg?token=O0CZIZAR7X)](https://codecov.io/gh/Valerioageno/ssr-rs)

El crate tiene como objetivo permitir el renderizado del lado servidor en servidores Rust de la manera más simple y ligera posible.

Utiliza una versión embebida del motor de javascript [V8](https://v8.dev/) (<a href="https://github.com/denoland/rusty_v8" target="_blank">rusty_v8</a>) para analizar y evaluar un archivo bundle construido y devolver una cadena con el html renderizado.
> [!NOTE]
>  Este proyecto es la columna vertebral de [tuono](https://github.com/Valerioageno/tuono); un framework fullstack React con SSR incorporado.

Actualmente funciona con [Vite](https://vitejs.dev/), [Webpack](https://webpack.js.org/), [Rspack](https://www.rspack.dev/), [React 18](https://react.dev/) y [Svelte 5](https://svelte.dev/) - Revisa la carpeta `examples/`.

> Consulta <a href="https://github.com/Valerioageno/ssr-rs/blob/main/benches">aquí</a> los resultados de los benchmarks.

## Comenzando

Agrega esto a tu `Cargo.toml`:

```bash
cargo add ssr_rs
```

## Ejemplo

Para renderizar a cadena un proyecto de React agrupado, la aplicación debe realizar las siguientes
llamadas.

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

## ¿Qué es el "entryPoint"?

El `entryPoint` podría ser:
- la función que devuelve un objeto con una o más propiedades que son funciones que al ser llamadas devuelven el resultado renderizado
- el objeto en sí mismo con una o más propiedades que son funciones que al ser llamadas devuelven el resultado renderizado

En caso de que el JS empaquetado sea un IIFE o el objeto plano, el `entryPoint` es una cadena vacía.

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

> Los resultados de la exportación son gestionados directamente por el empaquetador.

## Ejemplo con propiedades iniciales

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

## Ejemplo con actix-web

> Ejemplos con diferentes frameworks web están disponibles en la carpeta <a href="https://github.com/Valerioageno/ssr-rs/blob/main/examples" target="_blank">examples</a>.

Aunque el motor V8 permite acceder al mismo `isolate` desde diferentes hilos, esto está prohibido por este crate por dos razones:

1. La librería rusty_v8 aún no ha implementado la API V8 Locker. Acceder a la estructura Ssr desde un hilo diferente hará que el motor V8 genere un panic.
2. Renderizar HTML no necesita estado compartido entre hilos.

Por las razones anteriores, el cálculo paralelo es una mejor opción. A continuación la configuración de actix-web:

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

## Contribuyendo

Cualquier ayuda o sugerencia será apreciada.

TODOs conocidos: 
- Añadir ejemplos con otros frameworks backend de rust
- Añadir ejemplos con otros frameworks frontend (p.ej. vue, quik, solid)
- Añadir configuración de benchmark para comparar con Deno y Bun
- Explorar soporte para snapshots de V8
- Explorar compilación js a WASM (p.ej. [javy](https://github.com/bytecodealliance/javy))

## Licencia

Este proyecto está licenciado bajo la Licencia MIT - ver el archivo <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_MIT">LICENSE_MIT</a> || <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_APACHE">LICENSE_APACHE</a> para más información.

<br>

<p align="center">
  <img src="https://raw.githubusercontent.com/Valerioageno/ssr-rs/main/logo.png">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---