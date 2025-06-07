# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentação (último lançamento)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentação (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![Licença](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![Licença](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

O `future_queue` oferece formas de executar várias futures:

* concorrentemente
* na ordem em que são criadas
* com limites globais
* e com um grupo opcional especificado para cada future, cada um com seus próprios limites.

Este crate faz parte da [organização nextest](https://github.com/nextest-rs) no GitHub, e
foi projetado para atender às necessidades do [cargo-nextest](https://nexte.st).

## Motivação

A programação assíncrona em Rust frequentemente utiliza um adaptador chamado
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
esse adaptador recebe um stream de futures[^1], e executa todas as futures limitando a uma quantidade
máxima de concorrência.

* As futures são iniciadas na ordem em que o stream as retorna.
* Uma vez iniciadas, as futures são executadas simultaneamente, e as saídas das futures completadas
  são retornadas em ordem arbitrária (por isso o `unordered`).

Casos de uso comuns para `buffer_unordered` incluem:

* Enviar requisições de rede concorrentemente, mas limitando a quantidade de concorrência para evitar
  sobrecarregar o servidor remoto.
* Executar testes com uma ferramenta como o [cargo-nextest](https://nexte.st).

O `buffer_unordered` funciona bem para muitos casos de uso. No entanto, um problema é que ele trata
todas as futures como igualmente custosas: não há como indicar que algumas futures consomem mais recursos
do que outras, ou que alguns subconjuntos de futures devem ser mutuamente excluídos de outros.

Para o nextest em particular, alguns testes podem ser muito mais pesados que outros, e menos desses testes
devem ser executados simultaneamente. Além disso, alguns testes precisam ser mutuamente excluídos de outros, ou
outros limites de concorrência precisam ser aplicados a eles.

[^1]: Esse adaptador recebe um stream de futures para máxima generalidade. Na prática, isso normalmente é
    um *iterator* de futures, convertido usando
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## Sobre este crate

Este crate fornece dois adaptadores para streams.

### 1. O adaptador `future_queue`

O adaptador [`future_queue`](StreamExt::future_queue) pode executar várias futures simultaneamente,
limitando a concorrência a um *peso* máximo.

Em vez de receber um stream de futures, esse adaptador recebe um stream de
pares `(usize, F)`, onde o `usize` indica o peso de cada future,
e `F` é `FnOnce(FutureQueueContext) -> impl Future`. Este adaptador irá
agendar e armazenar futures até que enfileirar a próxima future exceda o peso máximo.

* O peso máximo nunca é excedido enquanto as futures estão sendo executadas.
* Se o peso de uma future individual for maior que o peso máximo, seu peso será
  ajustado para o peso máximo.

Uma vez que todas as futures possíveis estejam agendadas, este adaptador irá esperar até que algumas das
futures em execução sejam concluídas, e o peso atual das futures em execução caia abaixo do peso máximo,
antes de agendar novas futures.

O peso de uma future pode ser zero, nesse caso ela não conta para o peso máximo.

Se todos os pesos forem 1, então `future_queue` é exatamente igual ao `buffer_unordered`.

#### Exemplos

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

### 2. O adaptador `future_queue_grouped`

O adaptador [`future_queue_grouped`](StreamExt::future_queue_grouped) é semelhante ao `future_queue`,
exceto que é possível especificar um *grupo* opcional para cada future. Cada grupo possui um peso máximo,
e uma future só será agendada se tanto o peso máximo global quanto o peso do grupo
não forem excedidos.

O adaptador é tão justo quanto possível dentro das restrições: ele irá agendar as futures na
ordem em que são retornadas pelo stream, sem reordenar com base no peso. Quando uma
future de um grupo é concluída, as futures já enfileiradas nesse grupo serão agendadas com prioridade
em relação a outras futures do stream fornecido.

Assim como com [`future_queue`](StreamExt::future_queue):

* O peso máximo global e dos grupos nunca é excedido enquanto as futures estão sendo executadas.
* Ao considerar o peso global, se o peso de uma future individual for maior que o peso máximo, seu peso será ajustado para o peso máximo.
* *Se uma future pertence a um grupo:* ao considerar o peso do grupo, se o peso for
  maior que o peso máximo do grupo, seu peso será ajustado para o peso máximo do grupo.

#### Exemplos

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

## Versão mínima suportada do Rust (MSRV)

A versão mínima suportada do Rust é **Rust 1.70.** Em qualquer momento, ao menos os últimos seis meses
de lançamentos estáveis do Rust são suportados.

Enquanto este crate for um pré-lançamento (0.x.x) seu MSRV pode ser elevado em um patch release. Uma vez
que o crate atingir a versão 1.x, qualquer aumento do MSRV será acompanhado de uma nova versão minor.

## Observações

Este crate era chamado de `buffer-unordered-weighted`. Ele foi renomeado para `future-queue` para ser
mais descritivo sobre o que o crate faz, ao invés de como ele é implementado.

## Contribuindo

Veja o arquivo [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) para saber como ajudar.

## Licença

Este projeto está disponível sob os termos da [licença Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) ou
da [licença MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

O código é derivado de [futures-rs](https://github.com/rust-lang/futures-rs), e é utilizado sob
as licenças Apache 2.0 e MIT.

<!--
README.md é gerado a partir de README.tpl pelo cargo readme. Para regenerar, execute a partir da raiz do repositório:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---