# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` มีวิธีการสำหรับรัน future หลายตัว:

* แบบขนาน (concurrently)
* ตามลำดับที่ถูกสร้างขึ้น
* ด้วยการจำกัดแบบ global
* และสามารถกำหนดกลุ่ม (group) ให้กับแต่ละ future พร้อมกำหนดขีดจำกัดสำหรับแต่ละกลุ่มได้

crate นี้เป็นส่วนหนึ่งของ [องค์กร nextest](https://github.com/nextest-rs) บน GitHub และ
ถูกออกแบบมาเพื่อตอบสนองความต้องการของ [cargo-nextest](https://nexte.st)

## แรงจูงใจ

การเขียนโปรแกรมแบบ async ใน Rust มักใช้ตัวแปลงที่เรียกว่า
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
ตัวแปลงนี้รับ stream ของ futures[^1] และรัน futures เหล่านั้นโดยจำกัดจำนวนขนานสูงสุด

* futures จะเริ่มรันตามลำดับที่ stream คืนค่า
* เมื่อเริ่มรัน futures แล้ว futures เหล่านั้นจะถูก poll พร้อมกัน และค่าที่ได้จะถูกคืนค่าแบบไม่เรียงลำดับ (unordered)

ตัวอย่างการใช้งาน `buffer_unordered` ที่พบบ่อย ได้แก่:

* ส่งคำขอเครือข่ายแบบขนาน แต่จำกัดจำนวนขนานเพื่อไม่ให้เซิร์ฟเวอร์ปลายทางรับภาระมากเกินไป
* รันทดสอบด้วยเครื่องมืออย่าง [cargo-nextest](https://nexte.st)

`buffer_unordered` ใช้งานได้ดีกับหลายกรณี อย่างไรก็ตาม ข้อจำกัดหนึ่งคือมันปฏิบัติต่อ futures ทุกตัวเสมือนว่าใช้ทรัพยากรเท่ากัน: ไม่สามารถระบุได้ว่า futures บางตัวใช้ทรัพยากรมากกว่าตัวอื่น หรือ futures บางกลุ่มต้องถูกแยกจากกันโดยสิ้นเชิง

สำหรับ nextest โดยเฉพาะ การทดสอบบางอย่างอาจหนักกว่าแบบอื่น และควรรันพร้อมกันให้น้อยลง นอกจากนี้ การทดสอบบางอย่างอาจต้องถูกแยกจากการทดสอบอื่น หรืออาจต้องมีการจำกัดขนานเพิ่มเติม

[^1]: ตัวแปลงนี้รับ stream ของ futures เพื่อความยืดหยุ่นสูงสุด ในทางปฏิบัติมักจะเป็น *iterator* ของ futures ซึ่งแปลงได้ด้วย
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html)

## เกี่ยวกับ crate นี้

crate นี้มีตัวแปลง (adaptor) สองแบบสำหรับ stream

### 1. ตัวแปลง `future_queue`

ตัวแปลง [`future_queue`](StreamExt::future_queue) สามารถรัน future หลายตัวพร้อมกัน
โดยจำกัดจำนวนขนานสูงสุดเป็น *น้ำหนัก* (weight)

แทนที่จะรับ stream ของ futures เพียงอย่างเดียว ตัวแปลงนี้รับ stream ของ
`(usize, F)` ซึ่ง `usize` คือค่าน้ำหนักของแต่ละ future
และ `F` คือ `FnOnce(FutureQueueContext) -> impl Future` ตัวแปลงนี้จะ
จัดคิวและ buffer futures เพื่อรันจนกว่าการรันตัวถัดไปจะทำให้น้ำหนักรวมเกินขีดจำกัด

* น้ำหนักสูงสุดจะไม่ถูกเกินขณะรัน futures
* หากน้ำหนักของ future ตัวใดเกินขีดจำกัด น้ำหนักจะถูกตั้งให้เท่ากับขีดจำกัด

เมื่อ future ทั้งหมดที่สามารถรันได้ถูกจัดตารางแล้ว ตัวแปลงนี้จะรอให้ future ที่กำลังรันเสร็จบางส่วนก่อน จนน้ำหนักรวมของ futures ที่กำลังรันต่ำกว่าขีดจำกัด จากนั้นจึงจัดคิว future ใหม่

น้ำหนักของ future สามารถเป็นศูนย์ได้ ในกรณีนั้นจะไม่นับถ่วงน้ำหนักรวม

หากน้ำหนักทุกตัวเป็น 1 แล้ว `future_queue` จะทำงานเหมือนกับ `buffer_unordered`

#### ตัวอย่าง

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

### 2. ตัวแปลง `future_queue_grouped`

ตัวแปลง [`future_queue_grouped`](StreamExt::future_queue_grouped) คล้ายกับ `future_queue`
แต่สามารถระบุกลุ่ม (group) เพิ่มเติมให้กับแต่ละ future ได้ กลุ่มแต่ละกลุ่มจะมีขีดจำกัดน้ำหนักสูงสุด และ future จะถูกจัดคิวก็ต่อเมื่อไม่เกินทั้งขีดจำกัด global และขีดจำกัดกลุ่ม

ตัวแปลงนี้จะพยายามจัดคิวอย่างเป็นธรรมภายใต้ข้อจำกัด: จะจัดคิวตามลำดับที่ stream คืนค่า โดยไม่จัดลำดับใหม่ตามน้ำหนัก เมื่อ future จากกลุ่มใดเสร็จ Future ที่ถูกคิวไว้ในกลุ่มนั้นจะได้คิวก่อน future อื่นใน stream

เหมือนกับ [`future_queue`](StreamExt::future_queue):

* ขีดจำกัด global และ group จะไม่มีวันถูกเกินขณะรัน futures
* ขณะคำนวณกับน้ำหนัก global หากน้ำหนักของ future ตัวใดเกินขีดจำกัด น้ำหนักจะถูกตั้งให้เท่ากับขีดจำกัด
* *ถ้า future สังกัดกลุ่ม:* ขณะคำนวณกับน้ำหนักกลุ่ม หากน้ำหนักเกินขีดจำกัดกลุ่ม น้ำหนักจะถูกตั้งให้เท่ากับขีดจำกัดกลุ่ม

#### ตัวอย่าง

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

## Rust เวอร์ชันต่ำสุดที่รองรับ (MSRV)

Rust เวอร์ชันต่ำสุดที่รองรับคือ **Rust 1.70** ตลอดเวลา จะรองรับอย่างน้อยรุ่น stable ของ Rust ในช่วงหกเดือนล่าสุด

ตราบใดที่ crate นี้ยังเป็น pre-release (0.x.x) อาจมีการอัปเดต MSRV ใน patch release ได้ เมื่อ crate ถึงรุ่น 1.x แล้ว การอัปเดต MSRV จะต้องมาพร้อม minor version ใหม่

## หมายเหตุ

crate นี้เคยชื่อ `buffer-unordered-weighted` มาก่อน ต่อมาถูกเปลี่ยนชื่อเป็น `future-queue` เพื่อให้บรรยายการทำงานของ crate ได้ชัดเจนกว่าการบอกวิธีการ implement

## การมีส่วนร่วม

ดูไฟล์ [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) สำหรับวิธีช่วยเหลือและร่วมพัฒนา

## ใบอนุญาต

โปรเจกต์นี้มีให้ใช้งานภายใต้ [สัญญาอนุญาต Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) หรือ
[สัญญาอนุญาต MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

โค้ดนี้มีต้นกำเนิดจาก [futures-rs](https://github.com/rust-lang/futures-rs) และใช้งานภายใต้สัญญาอนุญาต Apache 2.0 และ MIT

<!--
README.md ถูกสร้างจาก README.tpl โดยใช้ cargo readme หากต้องการสร้างใหม่ ให้รันจาก root ของ repository:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---