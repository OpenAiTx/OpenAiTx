# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` روش‌هایی را برای اجرای چندین فیوچر فراهم می‌کند:

* به صورت همزمان (concurrently)
* به ترتیبی که راه‌اندازی می‌شوند (in the order they're spawned)
* با محدودیت‌های سراسری (with global limits)
* و با یک گروه اختیاری برای هر فیوچر، با محدودیت‌های مختص به خود.

این کرِیت بخشی از [سازمان nextest](https://github.com/nextest-rs) در گیت‌هاب است و برای رفع نیازهای [cargo-nextest](https://nexte.st) طراحی شده است.

## انگیزه

برنامه‌نویسی async در راست اغلب از یک آداپتور به نام
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered) استفاده می‌کند:
این آداپتور یک استریم از فیوچرها[^1] را می‌گیرد و همه‌ی فیوچرها را با حداکثر مقدار همزمانی مشخص اجرا می‌کند.

* فیوچرها به ترتیبی که استریم آن‌ها را بازمی‌گرداند شروع می‌شوند.
* پس از شروع، فیوچرها به طور همزمان پول (poll) می‌شوند و خروجی‌های کامل‌شده به ترتیبی دلخواه بازگردانده می‌شوند (به همین دلیل `unordered`).

موارد استفاده رایج از `buffer_unordered` شامل موارد زیر است:

* ارسال درخواست‌های شبکه به صورت همزمان، اما با محدود کردن مقدار همزمانی برای جلوگیری از فشار به سرور مقصد.
* اجرای تست‌ها با ابزاری مانند [cargo-nextest](https://nexte.st).

`buffer_unordered` برای بسیاری از کاربردها به خوبی عمل می‌کند. با این حال، یکی از مشکلات آن این است که همه‌ی فیوچرها را به یک اندازه هزینه‌بر در نظر می‌گیرد: هیچ راهی وجود ندارد که بگوییم برخی فیوچرها منابع بیشتری نسبت به بقیه مصرف می‌کنند یا برخی زیرمجموعه‌های فیوچرها باید از همدیگر جدا (mutually excluded) باشند.

به طور خاص برای nextest، برخی تست‌ها می‌توانند بسیار سنگین‌تر از بقیه باشند و تعداد کمتری از این تست‌ها باید به طور همزمان اجرا شوند. همچنین، برخی تست‌ها باید از بقیه جدا باشند یا محدودیت‌های همزمانی دیگری برای آن‌ها اعمال شود.

[^1]: این آداپتور یک استریم از فیوچرها را برای بیشینه تعمیم‌پذیری می‌گیرد. در عمل، اغلب یک *iterator* از فیوچرها است که با استفاده از [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html) تبدیل شده است.

## درباره این کرِیت

این کرِیت دو آداپتور روی استریم‌ها فراهم می‌کند.

### 1. آداپتور `future_queue`

آداپتور [`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs) می‌تواند چندین فیوچر را به طور همزمان اجرا کند و میزان همزمانی را به حداکثر *وزن* محدود کند.

به جای گرفتن یک استریم از فیوچرها، این آداپتور یک استریم از جفت‌های
`(usize, F)` را می‌گیرد که در آن `usize` نشان‌دهنده وزن هر فیوچر است و `F` تابعی است به صورت `FnOnce(FutureQueueContext) -> impl Future`. این آداپتور فیوچرها را برنامه‌ریزی و بافر می‌کند تا زمانی که صف بعدی فیوچر باعث شود وزن کل از حداکثر وزن مجاز بیشتر شود.

* وزن کل هرگز هنگام اجرای فیوچرها از حداکثر تعیین‌شده فراتر نمی‌رود.
* اگر وزن یک فیوچر منفرد بیشتر از حداکثر وزن باشد، وزن آن به حداکثر وزن تنظیم می‌شود.

پس از زمان‌بندی تمام فیوچرهای ممکن، این آداپتور منتظر می‌ماند تا برخی از فیوچرهای در حال اجرا کامل شوند و وزن فعلی فیوچرهای در حال اجرا به زیر حداکثر وزن برسد، سپس فیوچرهای جدید را زمان‌بندی می‌کند.

وزن یک فیوچر می‌تواند صفر باشد؛ در این صورت، آن فیوچر در محاسبه وزن کل در نظر گرفته نمی‌شود.

اگر همه وزن‌ها ۱ باشند، `future_queue` دقیقا مشابه `buffer_unordered` عمل می‌کند.

#### مثال‌ها

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

### 2. آداپتور `future_queue_grouped`

آداپتور [`future_queue_grouped`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs) مشابه `future_queue` است، با این تفاوت که می‌توان برای هر فیوچر یک *گروه* اختیاری مشخص کرد. هر گروه دارای حداکثر وزن خاص خود است و یک فیوچر تنها زمانی زمان‌بندی می‌شود که هم وزن کل و هم وزن گروه مربوطه بیش از حد نشود.

این آداپتور تا حد امکان منصفانه است: فیوچرها را به ترتیبی که استریم آن‌ها را بازمی‌گرداند زمان‌بندی می‌کند، بدون هیچ گونه بازآرایی بر اساس وزن. وقتی یک فیوچر از یک گروه کامل شد، فیوچرهای صف شده‌ی همان گروه در اولویت زمان‌بندی قرار می‌گیرند.

همانند [`future_queue`](https://raw.githubusercontent.com/nextest-rs/future-queue/main/src/stream_ext.rs):

* وزن کل و وزن گروه هرگز هنگام اجرای فیوچرها از حداکثر تعیین‌شده فراتر نمی‌رود.
* در محاسبه وزن کل، اگر وزن یک فیوچر منفرد بیشتر از حداکثر وزن باشد، وزن آن به حداکثر وزن تنظیم می‌شود.
* *اگر فیوچر متعلق به یک گروه باشد:* در محاسبه وزن گروه، اگر وزن آن بیشتر از حداکثر وزن گروه باشد، وزن آن به حداکثر وزن گروه تنظیم می‌شود.

#### مثال‌ها

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

## حداقل نسخه پشتیبانی‌شده راست (MSRV)

حداقل نسخه پشتیبانی‌شده راست **Rust 1.70** است. در هر زمان، دست‌کم شش ماه آخر نسخه‌های پایدار راست پشتیبانی می‌شوند.

تا زمانی که این کرِیت نسخه پیش‌انتشار (0.x.x) باشد، ممکن است MSRV آن در یک نسخه patch افزایش یابد. پس از رسیدن به نسخه 1.x، هر گونه افزایش MSRV با یک نسخه فرعی جدید همراه خواهد بود.

## نکات

این کرِیت قبلا با نام `buffer-unordered-weighted` شناخته می‌شد. برای توصیف بهتر عملکرد آن، به `future-queue` تغییر نام داد.

## مشارکت

برای مشارکت، به فایل [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) مراجعه کنید.

## مجوز

این پروژه تحت شرایط [مجوز Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) یا [مجوز MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) در دسترس است.

کد برگرفته از [futures-rs](https://github.com/rust-lang/futures-rs) است و تحت مجوزهای Apache 2.0 و MIT استفاده می‌شود.

<!--
README.md از روی README.tpl توسط cargo readme تولید شده است. برای بازتولید، از ریشه مخزن این دستور را اجرا کنید:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---