# future-queue

[![future-queue en crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentación (última versión)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentación (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Registro de cambios](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![Licencia](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![Licencia](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` proporciona formas de ejecutar varios futures:

* concurrentemente
* en el orden en que se lanzan
* con límites globales
* y con un grupo opcional especificado para cada future, con sus propios límites.

Este crate es parte de la [organización nextest](https://github.com/nextest-rs) en GitHub, y
está diseñado para satisfacer las necesidades de [cargo-nextest](https://nexte.st).

## Motivación

La programación asíncrona en Rust a menudo utiliza un adaptador llamado
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
este adaptador toma un stream de futures[^1], y ejecuta todos los futures limitando la concurrencia
a un máximo permitido.

* Los futures se inician en el orden en que el stream los retorna.
* Una vez iniciados, los futures son evaluados simultáneamente, y los resultados de los futures completados
  se retornan en orden arbitrario (de ahí el `unordered`).

Casos de uso comunes para `buffer_unordered` incluyen:

* Enviar solicitudes de red concurrentemente, pero limitando la concurrencia para evitar
  sobrecargar el servidor remoto.
* Ejecutar pruebas con una herramienta como [cargo-nextest](https://nexte.st).

`buffer_unordered` funciona bien para muchos casos de uso. Sin embargo, un problema es que trata
todos los futures como si tuvieran el mismo costo: no hay forma de indicar que algunos futures consumen
más recursos que otros, o que ciertos subconjuntos de futures deban estar mutuamente excluidos de otros.

En particular para nextest, algunas pruebas pueden ser mucho más pesadas que otras, y menos de esas pruebas
deben ejecutarse simultáneamente. Además, algunas pruebas necesitan ser mutuamente excluyentes respecto a otras,
o tener otros límites de concurrencia aplicados sobre ellas.

[^1]: Este adaptador toma un stream de futures para máxima generalidad. En la práctica, a menudo esto es
    un *iterador* de futures, convertido mediante
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## Acerca de este crate

Este crate proporciona dos adaptadores sobre streams.

### 1. El adaptador `future_queue`

El adaptador [`future_queue`](StreamExt::future_queue) puede ejecutar varios futures simultáneamente,
limitando la concurrencia a un *peso* máximo.

En lugar de recibir un stream de futures, este adaptador recibe un stream de
pares `(usize, F)`, donde el `usize` indica el peso de cada future,
y `F` es `FnOnce(FutureQueueContext) -> impl Future`. Este adaptador
programará y almacenará futures hasta que agregar el siguiente future
exceda el peso máximo.

* El peso máximo nunca se excede mientras los futures están en ejecución.
* Si el peso de un future individual es mayor que el peso máximo, su peso se
  ajustará al peso máximo.

Una vez que todos los futures posibles están programados, este adaptador espera a que algunos de los futures
actualmente en ejecución terminen y que el peso actual de los futures activos baje por debajo del peso máximo,
antes de programar nuevos futures.

El peso de un future puede ser cero, en cuyo caso no cuenta para el peso máximo.

Si todos los pesos son 1, entonces `future_queue` es exactamente igual a `buffer_unordered`.

#### Ejemplos

```rust
use futures::{channel::oneshot, stream, StreamExt as _};
use future_queue::{StreamExt as _};

let (send_one, recv_one) = oneshot::channel();
let (send_two, recv_two) = oneshot::channel();

let stream_of_futures = stream::iter(
    vec![(1, recv_one), (2, recv_two)],
).map(|(weight, future)| {
    (weight, move |_cx| future)
});
let mut queue = stream_of_futures.future_queue(10);

send_two.send("hello")?;
assert_eq!(queue.next().await, Some(Ok("hello")));

send_one.send("world")?;
assert_eq!(queue.next().await, Some(Ok("world")));

assert_eq!(queue.next().await, None);
```

### 2. El adaptador `future_queue_grouped`

El adaptador [`future_queue_grouped`](StreamExt::future_queue_grouped) es como `future_queue`,
excepto que es posible especificar un *grupo* opcional para cada future. Cada grupo tiene un peso máximo,
y un future solo será programado si tanto el peso máximo global como el del grupo no se exceden.

El adaptador es lo más justo posible bajo las restricciones dadas: programará los futures en el
orden en que el stream los retorna, sin reordenar en función del peso. Cuando un future de un grupo se completa,
los futures encolados de ese grupo se programarán preferencialmente antes que cualquier otro future del stream proporcionado.

Al igual que con [`future_queue`](StreamExt::future_queue):

* El peso máximo global y de grupo nunca se excede mientras los futures están en ejecución.
* Al contabilizar contra los pesos globales, si el peso de un future individual es mayor que
  el peso máximo, su peso se ajustará al peso máximo.
* *Si un future pertenece a un grupo:* Al contabilizar contra el peso del grupo, si su peso es
  mayor que el peso máximo del grupo, su peso se ajustará al peso máximo del grupo.

#### Ejemplos

```rust
use futures::{channel::oneshot, stream, StreamExt as _};
use future_queue::{FutureQueueContext, StreamExt as _};

let (send_one, recv_one) = oneshot::channel();
let (send_two, recv_two) = oneshot::channel();

let stream_of_futures = stream::iter(
    vec![
        (1, Some("group1"), recv_one),
        (2, None, recv_two),
    ],
).map(|(weight, group, future)| {
    (weight, group, move |_cx| future)
});
let mut queue = stream_of_futures.future_queue_grouped(10, [("group1", 5)]);

send_two.send("hello")?;
assert_eq!(queue.next().await, Some(Ok("hello")));

send_one.send("world")?;
assert_eq!(queue.next().await, Some(Ok("world")));

assert_eq!(queue.next().await, None);
```

## Versión mínima soportada de Rust (MSRV)

La versión mínima soportada de Rust es **Rust 1.70.** En todo momento, se soportan al menos los últimos seis meses
de versiones estables de Rust.

Mientras este crate esté en pre-lanzamiento (0.x.x), su MSRV puede incrementarse en una versión de parche. Una vez
que este crate alcance la versión 1.x, cualquier aumento de MSRV irá acompañado de una nueva versión menor.

## Notas

Este crate solía llamarse `buffer-unordered-weighted`. Fue renombrado a `future-queue` para ser
más descriptivo respecto a lo que hace el crate en vez de cómo está implementado.

## Contribuir

Consulta el archivo [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) para ver cómo colaborar.

## Licencia

Este proyecto está disponible bajo los términos de la [licencia Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) o
la [licencia MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

El código se deriva de [futures-rs](https://github.com/rust-lang/futures-rs), y se utiliza bajo
las licencias Apache 2.0 y MIT.

<!--
README.md es generado desde README.tpl por cargo readme. Para regenerar, ejecuta desde la raíz del repositorio:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---