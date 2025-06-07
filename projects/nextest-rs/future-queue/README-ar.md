# future-queue

[![future-queue على crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![التوثيق (الإصدار الأخير)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![التوثيق (الرئيسي)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![سجل التغييرات](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![الرخصة](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![الرخصة](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

يوفر `future_queue` طرقًا لتشغيل عدة futures:

* بشكل متزامن
* بترتيب إطلاقها
* مع حدود عالمية
* ومع مجموعة اختيارية محددة لكل future، مع حدود خاصة بها.

هذه الحزمة هي جزء من [منظمة nextest](https://github.com/nextest-rs) على GitHub،
ومصممة لتلبية احتياجات [cargo-nextest](https://nexte.st).

## الدافع

البرمجة اللامتزامنة في Rust غالبًا ما تستخدم مُكيِّفًا يُسمى
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
هذا المُكيِّف يأخذ تدفقًا من futures[^1]، وينفذ جميع futures مع حد أقصى لمستوى التزامن.

* يتم بدء futures بالترتيب الذي يرجعها به التدفق.
* بمجرد البدء، يتم سبر futures في نفس الوقت، ويتم إرجاع مخرجات futures المكتملة بترتيب عشوائي (ومن هنا جاءت تسمية `unordered`).

تشمل حالات الاستخدام الشائعة لـ `buffer_unordered`:

* إرسال طلبات الشبكة بشكل متزامن، مع تقييد مستوى التزامن لتجنب إثقال الخادم البعيد.
* تشغيل الاختبارات باستخدام أداة مثل [cargo-nextest](https://nexte.st).

يعمل `buffer_unordered` بشكل جيد للعديد من حالات الاستخدام. ومع ذلك، هناك مشكلة فيه وهي أنه يعامل جميع futures على أنها تستهلك نفس الموارد: لا توجد طريقة للقول إن بعض futures تستهلك موارد أكثر من غيرها، أو أن بعض مجموعات futures يجب أن تكون متبادلة الإقصاء عن الأخرى.

بالنسبة لـ nextest على وجه الخصوص، بعض الاختبارات يمكن أن تكون أثقل بكثير من غيرها، ويجب تشغيل عدد أقل من تلك الاختبارات في نفس الوقت. أيضًا، بعض الاختبارات تحتاج لأن تكون متبادلة الإقصاء عن غيرها، أو وضع حدود تزامن أخرى عليها.

[^1]: يأخذ هذا المُكيِّف تدفقًا من futures لأقصى عمومية. عمليًا، غالبًا ما يكون هذا *مُكرِّرًا* للفيوتشرز، يتم تحويله باستخدام
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## حول هذه الحزمة

توفر هذه الحزمة مُكيِّفين لتدفقات البيانات.

### 1. مُكيِّف `future_queue`

مُكيِّف [`future_queue`](StreamExt::future_queue) يمكنه تشغيل عدة futures في نفس الوقت،
مع تقييد مستوى التزامن إلى أقصى *وزن*.

بدلاً من أخذ تدفق futures، يأخذ هذا المُكيِّف تدفقًا من أزواج
`(usize, F)`، حيث يشير `usize` إلى وزن كل future،
و `F` هو `FnOnce(FutureQueueContext) -> impl Future`. سيقوم هذا المُكيِّف
بجدولة وتخزين futures ليتم تشغيلها حتى يؤدي جدولة future جديد إلى تجاوز الحد الأقصى للوزن.

* لا يتم أبدًا تجاوز الحد الأقصى للوزن أثناء تشغيل futures.
* إذا كان وزن future فردي أكبر من الحد الأقصى للوزن، سيتم تعيين وزنه إلى الحد الأقصى للوزن.

بمجرد جدولة جميع futures الممكنة، سينتظر هذا المُكيِّف حتى تكتمل بعض futures التي تعمل حاليًا، وينخفض الوزن الحالي للفيوتشرز الجارية عن الحد الأقصى، قبل جدولة futures جديدة.

يمكن أن يكون وزن future صفرًا، وفي هذه الحالة لا يُحتسب ضمن الحد الأقصى للوزن.

إذا كانت جميع الأوزان 1، فإن `future_queue` يكون مماثلًا تمامًا لـ `buffer_unordered`.

#### أمثلة

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

### 2. مُكيِّف `future_queue_grouped`

مُكيِّف [`future_queue_grouped`](StreamExt::future_queue_grouped) مشابه لـ `future_queue`،
إلا أنه من الممكن تحديد *مجموعة* اختيارية لكل future. كل مجموعة لها حد أقصى للوزن، ولن يتم جدولة future إلا إذا لم يتم تجاوز كل من الحد الأقصى للوزن والوزن الخاص بالمجموعة.

المُكيِّف عادل قدر الإمكان ضمن القيود المعطاة: سيقوم بجدولة futures بالترتيب الذي يرجعها به التدفق، دون إعادة ترتيب بناءً على الوزن. عند اكتمال future من مجموعة معينة، سيتم جدولة futures المنتظرة في هذه المجموعة بشكل تفضيلي قبل أي futures أخرى من التدفق المقدم.

كما هو الحال مع [`future_queue`](StreamExt::future_queue):

* لا يتم أبدًا تجاوز الحد الأقصى العالمي أو الخاص بالمجموعة أثناء تشغيل futures.
* عند احتساب الوزن العالمي، إذا كان وزن future فردي أكبر من الحد الأقصى، سيتم تعيين وزنه إلى الحد الأقصى.
* *إذا كان future ينتمي إلى مجموعة:* عند احتساب وزن المجموعة، إذا كان وزنه أكبر من الحد الأقصى للمجموعة، سيتم تعيين وزنه إلى الحد الأقصى للمجموعة.

#### أمثلة

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

## الحد الأدنى لإصدار Rust المدعوم (MSRV)

الحد الأدنى لإصدار Rust المدعوم هو **Rust 1.70.** في أي وقت، يتم دعم آخر ستة أشهر على الأقل من إصدارات Rust المستقرة.

طالما أن هذه الحزمة إصدار أولي (0.x.x) فقد يتم رفع MSRV في إصدار تصحيحي. بمجرد أن تصل الحزمة إلى 1.x، فإن أي رفع لـ MSRV سيكون مصحوبًا بإصدار فرعي جديد.

## ملاحظات

كان اسم هذه الحزمة سابقًا `buffer-unordered-weighted`. تم تغيير اسمها إلى `future-queue` لتكون أكثر وصفًا لما تفعله الحزمة بدلًا من كيفية تنفيذها.

## المساهمة

راجع ملف [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) لمعرفة كيفية المساهمة.

## الرخصة

هذا المشروع متوفر بموجب شروط [رخصة Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) أو
[رخصة MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

الكود مشتق من [futures-rs](https://github.com/rust-lang/futures-rs)، ويستخدم بموجب رخصتي Apache 2.0 وMIT.

<!--
README.md تم توليده من README.tpl بواسطة cargo readme. لإعادة التوليد، نفذ من جذر المستودع:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---