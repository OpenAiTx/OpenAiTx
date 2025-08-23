# 🚀 Rendu côté serveur en Rust

[![API](https://docs.rs/ssr_rs/badge.svg)](https://docs.rs/ssr_rs)
[![codecov](https://codecov.io/gh/Valerioageno/ssr-rs/branch/main/graph/badge.svg?token=O0CZIZAR7X)](https://codecov.io/gh/Valerioageno/ssr-rs)

La crate vise à permettre le rendu côté serveur sur des serveurs Rust de la manière la plus simple et légère possible.

Elle utilise une version embarquée du moteur JavaScript [V8](https://v8.dev/) (<a href="https://github.com/denoland/rusty_v8" target="_blank">rusty_v8</a>) pour analyser et évaluer un fichier bundle construit et retourner une chaîne avec le HTML rendu.
> [!NOTE]
>  Ce projet est la colonne vertébrale de [tuono](https://github.com/Valerioageno/tuono) ; un framework React fullstack avec SSR intégré.

Actuellement, il fonctionne avec [Vite](https://vitejs.dev/), [Webpack](https://webpack.js.org/), [Rspack](https://www.rspack.dev/), [React 18](https://react.dev/) et [Svelte 5](https://svelte.dev/) - Consultez le dossier `examples/`.

> Consultez <a href="https://github.com/Valerioageno/ssr-rs/blob/main/benches">ici</a> les résultats des benchmarks.

## Pour commencer

Ajoutez ceci à votre `Cargo.toml` :

```bash
cargo add ssr_rs
```

## Exemple

Pour rendre sous forme de chaîne un projet React regroupé, l'application doit effectuer les appels suivants.


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

## Qu'est-ce que le "entryPoint" ?

Le `entryPoint` peut être soit :
- la fonction qui retourne un objet avec une ou plusieurs propriétés qui sont des fonctions qui, lorsqu'elles sont appelées, retournent le résultat rendu
- l'objet lui-même avec une ou plusieurs propriétés qui sont des fonctions qui, lorsqu'elles sont appelées, retournent le résultat rendu

Dans le cas où le JS empaqueté est un IIFE ou l'objet simple, le `entryPoint` est une chaîne vide.

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

> Les résultats de l'exportation sont gérés directement par le bundler.

## Exemple avec des props initiales

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

## Exemple avec actix-web

> Des exemples avec différents frameworks web sont disponibles dans le dossier <a href="https://github.com/Valerioageno/ssr-rs/blob/main/examples" target="_blank">examples</a>.

Même si le moteur V8 permet d’accéder au même `isolate` depuis différents threads, cela est interdit par ce crate pour deux raisons :

1. la bibliothèque rusty_v8 n’a pas encore implémenté l’API V8 Locker. Accéder à la structure Ssr depuis un thread différent fera planter le moteur V8.
2. Le rendu HTML n’a pas besoin d’un état partagé entre les threads.

Pour ces raisons, le calcul parallèle est un meilleur choix. Voici la configuration actix-web :

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

## Contribution

Toute aide ou suggestion sera appréciée.

Tâches connues à faire : 
- Ajouter des exemples avec d'autres frameworks backend Rust
- Ajouter des exemples avec d'autres frameworks frontend (par ex. vue, quik, solid)
- Ajouter une configuration de benchmark pour tester contre Deno et Bun
- Explorer le support des snapshots V8
- Explorer la compilation js vers WASM (par ex. [javy](https://github.com/bytecodealliance/javy))

## Licence

Ce projet est sous licence MIT - voir le fichier <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_MIT">LICENSE_MIT</a> || <a href="https://github.com/Valerioageno/ssr-rs/blob/main/LICENSE_APACHE">LICENSE_APACHE</a> pour plus d'informations.

<br>

<p align="center">
  <img src="https://raw.githubusercontent.com/Valerioageno/ssr-rs/main/logo.png">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---