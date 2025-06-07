zip
========

[![حالة البناء](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![إصدار Crates.io](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[التوثيق](https://docs.rs/zip/latest/zip/)

معلومات
----

مكتبة zip للغة Rust تدعم قراءة وكتابة ملفات ZIP البسيطة. كانت مستضافة سابقًا على  
https://github.com/zip-rs/zip2.

تنسيقات الضغط المدعومة:

* تخزين (أي بدون ضغط)
* deflate
* deflate64 (فك الضغط فقط)
* bzip2
* zstd
* lzma (فك الضغط فقط)
* xz (فك الضغط فقط)

امتدادات zip غير المدعومة حاليًا:

* Multi-disk

الميزات
--------

الميزات المتوفرة هي:

* `aes-crypto`: تفعيل فك تشفير الملفات التي تم تشفيرها باستخدام AES. يدعم طرق AE-1 وAE-2.
* `deflate`: تمكين ضغط وفك ضغط تنفيذ غير محدد (قد يتغير في الإصدارات المستقبلية) لخوارزمية الضغط deflate، وهي الافتراضية لملفات zip. يدعم جودة الضغط 1..=264.
* `deflate-flate2`: دمج هذه الميزة مع أي علم ميزة `flate2` يفعّل back-end لدعم ضغط deflate بجودة 1..=9.
* `deflate-zopfli`: تفعيل ضغط الملفات باستخدام مكتبة `zopfli` (تُستخدم عند جودة الضغط 10..=264). هذه هي أكثر خوارزميات deflate فاعلية، لكنها من الأبطأ.
* `deflate64`: تفعيل خوارزمية الضغط deflate64. يدعم فك الضغط فقط.
* `lzma`: تفعيل خوارزمية الضغط LZMA. يدعم فك الضغط فقط.
* `bzip2`: تفعيل خوارزمية الضغط BZip2.
* `time`: تفعيل الميزات التي تستخدم الحزمة [time](https://github.com/rust-lang-deprecated/time).
* `chrono`: تمكين تحويل آخر تعديل `zip::DateTime` إلى ومن `chrono::NaiveDateTime`.
* `jiff-02`: تمكين تحويل آخر تعديل `zip::DateTime` إلى ومن `jiff::civil::DateTime`.
* `nt-time`: تمكين إرجاع الطوابع الزمنية المخزنة في الحقل الإضافي لـNTFS كـ`nt_time::FileTime`.
* `zstd`: تفعيل خوارزمية الضغط Zstandard.

افتراضيًا، يتم تفعيل `aes-crypto`، و`bzip2`، و`deflate`، و`deflate64`، و`lzma`، و`time`، و`zstd`.

MSRV
----

الحد الأدنى الحالي لإصدار Rust المدعوم هو **1.75**. عند إضافة ميزات،
سنتبع الإرشادات التالية:

- سنقوم دائمًا بدعم إصدار Rust فرعي كان مستقرًا لمدة لا تقل عن 6 أشهر.
- أي تغيير في MSRV سيتم معه زيادة **الإصدار الفرعي**.

أمثلة
--------

انظر [دليل الأمثلة](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) لـ:
   * كيفية كتابة ملف إلى zip.
   * كيفية كتابة مجلد من الملفات إلى zip (باستخدام [walkdir](https://github.com/BurntSushi/walkdir)).
   * كيفية استخراج ملف zip.
   * كيفية استخراج ملف واحد من zip.
   * كيفية قراءة zip من الإدخال القياسي.
   * كيفية إضافة مجلد إلى أرشيف موجود

الاختبار التلقائي (Fuzzing)
-------

دعم الاختبار التلقائي يتم عبر [cargo afl](https://rust-fuzz.github.io/book/afl.html). لتثبيت cargo afl:

```bash
cargo install cargo-afl
```

لبدء اختبار استخراج zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

لبدء اختبار إنشاء zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---