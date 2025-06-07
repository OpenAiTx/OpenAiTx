# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue`는 여러 future를 실행하는 방법을 제공합니다:

* 동시에(concurrently)
* 생성된 순서대로(in the order they're spawned)
* 전역 제한(global limits)과 함께
* 그리고 각 future마다 지정할 수 있는 선택적 그룹(group) 및 해당 그룹별 제한(group limits)과 함께

이 크레이트는 GitHub의 [nextest organization](https://github.com/nextest-rs) 소속이며,
[cargo-nextest](https://nexte.st)의 요구를 충족하도록 설계되었습니다.

## 동기

Rust의 비동기 프로그래밍에서는 종종
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered)라는 어댑터를 사용합니다.
이 어댑터는 future의 스트림[^1]을 받아서, 최대 동시 실행 개수로 제한하여 모든 future를 실행합니다.

* future는 스트림이 반환하는 순서대로 시작됩니다.
* 시작된 future는 동시에 폴링되며, 완료된 future의 결과는 임의의 순서로 반환됩니다(`unordered`의 의미).

`buffer_unordered`의 일반적인 사용 예시는 다음과 같습니다:

* 네트워크 요청을 동시에 보내되, 원격 서버에 과부하를 주지 않기 위해 동시성 개수를 제한하는 경우
* [cargo-nextest](https://nexte.st)와 같은 도구로 테스트를 실행하는 경우

`buffer_unordered`는 많은 경우에 잘 동작합니다. 하지만 한 가지 문제는 모든 future를 동일하게 취급한다는 점입니다.
어떤 future가 다른 future보다 더 많은 자원을 소모하거나, future의 일부 집합이 서로 배타적으로 동작해야 한다는 것을 지정할 방법이 없습니다.

특히 nextest에서는 일부 테스트가 다른 테스트보다 훨씬 무거울 수 있으며, 이런 테스트는 동시에 더 적게 실행되어야 합니다.
또한, 일부 테스트는 서로 배타적으로 실행되어야 하거나, 추가적인 동시성 제한이 필요할 수 있습니다.

[^1]: 이 어댑터는 최대 범용성을 위해 future의 스트림을 받습니다. 실제로는 종종 future의 *이터레이터*를
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html)로 변환해서 사용합니다.

## 이 크레이트에 대하여

이 크레이트는 스트림(stream)에 두 가지 어댑터를 제공합니다.

### 1. `future_queue` 어댑터

[`future_queue`](StreamExt::future_queue) 어댑터는 여러 future를 동시에 실행할 수 있으며,
동시 실행의 최대 *가중치(weight)*를 제한합니다.

이 어댑터는 future의 스트림 대신, `(usize, F)` 쌍의 스트림을 받습니다.
여기서 `usize`는 각 future의 가중치를, `F`는 `FnOnce(FutureQueueContext) -> impl Future` 타입을 의미합니다.
이 어댑터는 다음 future를 큐에 추가할 때 최대 가중치를 초과하지 않는 한 future를 예약 및 버퍼링합니다.

* 실행 중인 future의 가중치 총합이 최대 가중치를 초과하는 일은 없습니다.
* 개별 future의 가중치가 최대 가중치보다 크면, 해당 future의 가중치는 최대 가중치로 설정됩니다.

가능한 모든 future가 예약되면, 현재 실행 중인 future 중 일부가 완료되어
실행 중인 future의 가중치 합이 최대 가중치보다 낮아질 때까지 대기한 후 새로운 future를 예약합니다.

future의 가중치는 0이 될 수 있으며, 이 경우 최대 가중치에 포함되지 않습니다.

모든 가중치가 1이라면, `future_queue`는 `buffer_unordered`와 정확히 동일하게 동작합니다.

#### 예제

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

### 2. `future_queue_grouped` 어댑터

[`future_queue_grouped`](StreamExt::future_queue_grouped) 어댑터는 `future_queue`와 유사하지만,
각 future마다 선택적으로 *그룹(group)*을 지정할 수 있습니다.
각 그룹은 최대 가중치를 갖고 있으며, future는 전역(maximum weight) 및 그룹별(group weight) 가중치가 모두 초과되지 않을 때만 예약됩니다.

이 어댑터는 주어진 제약조건 내에서 최대한 공정하게 동작합니다:
future는 스트림이 반환하는 순서대로 예약되며, 가중치에 따라 재정렬되지 않습니다.
그룹의 future가 완료되면, 이 그룹의 큐에 대기 중인 future가 제공된 스트림의 다른 future보다 우선적으로 예약됩니다.

[`future_queue`](StreamExt::future_queue)와 마찬가지로:

* 실행 중인 future의 전역 및 그룹별 최대 가중치를 초과하지 않습니다.
* 전역 가중치를 계산할 때, 개별 future의 가중치가 최대 가중치보다 크면 해당 future의 가중치는 최대 가중치로 설정됩니다.
* *future가 그룹에 속하는 경우:* 그룹 가중치를 계산할 때, 가중치가 최대 그룹 가중치보다 크면, 해당 future의 가중치는 최대 그룹 가중치로 설정됩니다.

#### 예제

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

## 최소 지원 Rust 버전 (MSRV)

최소 지원 Rust 버전은 **Rust 1.70.** 입니다. 언제든 최소 6개월 이내의 Rust 안정 릴리스를 지원합니다.

이 크레이트가 프리릴리즈(0.x.x) 버전인 동안에는 패치 릴리즈에서 MSRV가 상향될 수 있습니다.
1.x 버전에 도달하면, MSRV 상향은 새로운 마이너 버전에서만 이루어집니다.

## 참고

이 크레이트는 과거에 `buffer-unordered-weighted`라는 이름이었으나,
이름이 설명하는 기능에 더 충실하도록 `future-queue`로 변경되었습니다.

## 기여

기여 방법은 [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) 파일을 참고하세요.

## 라이선스

이 프로젝트는 [Apache 2.0 라이선스](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) 또는
[MIT 라이선스](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) 조건 중 하나를 선택하여 사용할 수 있습니다.

코드는 [futures-rs](https://github.com/rust-lang/futures-rs)에서 파생되었으며, Apache 2.0 및 MIT 라이선스 하에 사용됩니다.

<!--
README.md는 cargo readme로 README.tpl에서 생성됩니다. 다시 생성하려면 저장소 루트에서 다음을 실행하세요:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---