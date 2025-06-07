# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` कई futures को चलाने के तरीके प्रदान करता है:

* एक साथ (concurrently)
* जिस क्रम में उन्हें शुरू किया गया है
* वैश्विक सीमाओं के साथ
* और प्रत्येक future के लिए एक वैकल्पिक समूह निर्दिष्ट किया जा सकता है, जिसकी अपनी सीमाएं हैं।

यह crate GitHub पर [nextest organization](https://github.com/nextest-rs) का हिस्सा है, और इसे [cargo-nextest](https://nexte.st) की आवश्यकताओं को पूरा करने के लिए डिज़ाइन किया गया है।

## उद्देश्य

Rust में असिंक्रोनस प्रोग्रामिंग अक्सर एक adaptor का उपयोग करती है जिसे [`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered) कहा जाता है: यह adaptor futures की एक stream लेता है[^1], और सभी futures को अधिकतम concurrency सीमा तक चलाता है।

* Futures उसी क्रम में शुरू किए जाते हैं जिस क्रम में उन्हें stream लौटाती है।
* एक बार शुरू होने के बाद, futures को एक साथ poll किया जाता है, और पूर्ण हो चुके futures के आउटपुट किसी भी क्रम में लौटाए जाते हैं (इसलिए इसे `unordered` कहा जाता है)।

`buffer_unordered` के सामान्य उपयोग के मामले:

* नेटवर्क अनुरोधों को एक साथ भेजना, लेकिन concurrency को सीमित करना ताकि रिमोट सर्वर पर भार न पड़े।
* [cargo-nextest](https://nexte.st) जैसे टूल से टेस्ट चलाना।

`buffer_unordered` कई मामलों में अच्छा काम करता है। हालांकि, इसकी एक समस्या यह है कि यह सभी futures को समान भार वाला मानता है: इसमें यह बताने का कोई तरीका नहीं है कि कुछ futures अन्य की तुलना में अधिक संसाधन लेते हैं, या कुछ futures के उपसमूहों को एक-दूसरे से अलग रखना चाहिए।

विशेष रूप से nextest के लिए, कुछ टेस्ट अन्य की तुलना में बहुत भारी हो सकते हैं, और ऐसे टेस्ट को कम संख्या में एक साथ चलाया जाना चाहिए। साथ ही, कुछ टेस्ट को अन्य से अलग रखा जाना चाहिए, या उन पर अन्य concurrency सीमाएं लगाई जानी चाहिए।

[^1]: अधिकतम सामान्यता के लिए यह adaptor futures की stream लेता है। व्यवहार में यह अक्सर futures के *iterator* होते हैं, जिन्हें [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html) के माध्यम से stream में बदला जाता है।

## इस crate के बारे में

यह crate streams पर दो adaptor प्रदान करता है।

### 1. `future_queue` adaptor

[`future_queue`](StreamExt::future_queue) adaptor कई futures को एक साथ चला सकता है, concurrency को अधिकतम *weight* तक सीमित करता है।

यह adaptor futures की stream के बजाय `(usize, F)` जोड़ों की stream लेता है, जहाँ `usize` प्रत्येक future का weight दर्शाता है, और `F` है `FnOnce(FutureQueueContext) -> impl Future`। यह adaptor futures को शेड्यूल और बफर करेगा जब तक कि अगला future जोड़ने से अधिकतम weight पार न हो जाए।

* अधिकतम weight कभी पार नहीं किया जाता जब futures चल रहे होते हैं।
* यदि किसी व्यक्तिगत future का weight अधिकतम weight से अधिक है, तो उसका weight अधिकतम weight पर सेट कर दिया जाएगा।

जब तक सभी संभावित futures शेड्यूल नहीं हो जाते, यह adaptor प्रतीक्षा करेगा जब तक वर्तमान में चल रहे futures का weight अधिकतम weight से कम नहीं हो जाता, फिर नए futures शेड्यूल करेगा।

किसी future का weight शून्य (zero) हो सकता है, ऐसे में वह अधिकतम weight में नहीं गिना जाएगा।

यदि सभी weights 1 हैं, तो `future_queue` ठीक उसी तरह काम करता है जैसे `buffer_unordered`।

#### उदाहरण

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

### 2. `future_queue_grouped` adaptor

[`future_queue_grouped`](StreamExt::future_queue_grouped) adaptor `future_queue` जैसा है, लेकिन इसमें प्रत्येक future के लिए एक वैकल्पिक *group* निर्दिष्ट किया जा सकता है। प्रत्येक group का एक अधिकतम weight होता है, और future तभी शेड्यूल किया जाएगा जब वैश्विक और समूह weight दोनों पार न हों।

यह adaptor दिए गए constraints के तहत जितना हो सके उतना निष्पक्ष है: यह futures को उसी क्रम में शेड्यूल करेगा जैसा stream उन्हें लौटाता है, weight के आधार पर कोई पुन: क्रमबद्धता नहीं करेगा। जब किसी समूह का future पूरा होता है, तो इस समूह के queued futures को अन्य किसी भी stream से प्राप्त future से पहले प्राथमिकता दी जाएगी।

[`future_queue`](StreamExt::future_queue) की तरह ही:

* वैश्विक और समूह के अधिकतम weight कभी पार नहीं किए जाते जब futures चल रहे होते हैं।
* वैश्विक weight के लिए, यदि किसी व्यक्तिगत future का weight अधिकतम weight से अधिक है, तो उसका weight अधिकतम weight पर सेट कर दिया जाएगा।
* *यदि कोई future किसी समूह का हिस्सा है:* समूह weight के लिए, यदि उसका weight अधिकतम समूह weight से अधिक है, तो उसका weight अधिकतम समूह weight पर सेट कर दिया जाएगा।

#### उदाहरण

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

## न्यूनतम समर्थित Rust संस्करण (MSRV)

न्यूनतम समर्थित Rust संस्करण **Rust 1.70** है। किसी भी समय, कम से कम पिछले छह महीने की Rust स्थिर रिलीज़ समर्थित हैं।

जब तक यह crate प्री-रिलीज़ (0.x.x) है, इसका MSRV पैच रिलीज़ में बढ़ सकता है। एक बार जब यह crate 1.x पर पहुँच जाएगा, किसी भी MSRV वृद्धि के साथ नया माइनर वर्शन आएगा।

## नोट्स

इस crate का पहले नाम `buffer-unordered-weighted` था। इसे `future-queue` नाम दिया गया ताकि यह crate के कार्य को उसके implementation से ज्यादा स्पष्ट करे।

## योगदान

मदद करने के तरीके के लिए [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) फ़ाइल देखें।

## लाइसेंस

यह परियोजना [Apache 2.0 license](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) या [MIT license](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT) की शर्तों के तहत उपलब्ध है।

यह कोड [futures-rs](https://github.com/rust-lang/futures-rs) से लिया गया है, और Apache 2.0 तथा MIT लाइसेंस के तहत उपयोग किया गया है।

<!--
README.md README.tpl से cargo readme द्वारा जनरेट किया गया है। पुनः जनरेट करने के लिए, रिपोज़िटरी root से चलाएँ:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---