zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[مستندات](https://docs.rs/zip/latest/zip/)

اطلاعات
----

یک کتابخانه zip برای rust که از خواندن و نوشتن فایل‌های ZIP ساده پشتیبانی می‌کند. قبلاً در  
https://github.com/zip-rs/zip2 میزبانی می‌شد.

فرمت‌های فشرده‌سازی پشتیبانی‌شده:

* stored (یعنی بدون فشرده‌سازی)
* deflate
* deflate64 (فقط بازفشرده‌سازی)
* bzip2
* zstd
* lzma (فقط بازفشرده‌سازی)
* xz (فقط بازفشرده‌سازی)

افزونه‌های zip که در حال حاضر پشتیبانی نمی‌شوند:

* Multi-disk

ویژگی‌ها
--------

ویژگی‌های موجود عبارتند از:

* `aes-crypto`: فعال‌سازی رمزگشایی فایل‌هایی که با AES رمزنگاری شده‌اند. از روش‌های AE-1 و AE-2 پشتیبانی می‌کند.
* `deflate`: فعال‌سازی فشرده‌سازی و بازفشرده‌سازی پیاده‌سازی مشخص‌نشده (که ممکن است در نسخه‌های آینده تغییر کند) الگوریتم فشرده‌سازی deflate، که به طور پیش‌فرض برای فایل‌های zip است. از کیفیت فشرده‌سازی 1..=264 پشتیبانی می‌کند.
* `deflate-flate2`: این را با هر ویژگی `flate2` که یک back-end را فعال می‌کند ترکیب کنید تا از فشرده‌سازی deflate با کیفیت 1..=9 پشتیبانی شود.
* `deflate-zopfli`: فعال‌سازی فشرده‌سازی فایل‌ها با کتابخانه `zopfli` (هنگامی که کیفیت فشرده‌سازی 10..=264 باشد). این موثرترین پیاده‌سازی `deflate` موجود است، اما یکی از کندترین‌ها نیز هست.
* `deflate64`: فعال‌سازی الگوریتم فشرده‌سازی deflate64. فقط بازفشرده‌سازی پشتیبانی می‌شود.
* `lzma`: فعال‌سازی الگوریتم فشرده‌سازی LZMA. فقط بازفشرده‌سازی پشتیبانی می‌شود.
* `bzip2`: فعال‌سازی الگوریتم فشرده‌سازی BZip2.
* `time`: فعال‌سازی ویژگی‌هایی که از crate [time](https://github.com/rust-lang-deprecated/time) استفاده می‌کنند.
* `chrono`: فعال‌سازی تبدیل `zip::DateTime` آخرین ویرایش به و از `chrono::NaiveDateTime`.
* `jiff-02`: فعال‌سازی تبدیل `zip::DateTime` آخرین ویرایش به و از `jiff::civil::DateTime`.
* `nt-time`: فعال‌سازی بازگرداندن timestampهای ذخیره‌شده در فیلد اضافی NTFS به صورت `nt_time::FileTime`.
* `zstd`: فعال‌سازی الگوریتم فشرده‌سازی Zstandard.

به طور پیش‌فرض `aes-crypto`، `bzip2`، `deflate`، `deflate64`، `lzma`، `time` و `zstd` فعال هستند.

MSRV
----

حداقل نسخه پشتیبانی‌شده Rust ما **1.75** است. هنگام افزودن ویژگی‌ها، از این دستورالعمل‌ها پیروی خواهیم کرد:

- همیشه از یک نسخه فرعی Rust که حداقل ۶ ماه پایدار بوده، پشتیبانی خواهیم کرد.
- هر تغییری در MSRV با افزایش نسخه **فرعی** همراه خواهد بود.

مثال‌ها
--------

برای مشاهده مثال‌ها به [پوشه examples](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) مراجعه کنید:
   * نحوه نوشتن یک فایل در یک zip.
   * نحوه نوشتن یک پوشه فایل در یک zip (با استفاده از [walkdir](https://github.com/BurntSushi/walkdir)).
   * نحوه استخراج یک فایل zip.
   * نحوه استخراج یک فایل منفرد از یک zip.
   * نحوه خواندن یک zip از ورودی استاندارد.
   * نحوه افزودن یک پوشه به یک آرشیو موجود

Fuzzing
-------

پشتیبانی fuzzing از طریق [cargo afl](https://rust-fuzz.github.io/book/afl.html) انجام می‌شود. برای نصب cargo afl:

```bash
cargo install cargo-afl
```

برای شروع fuzzing استخراج zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

برای شروع fuzzing ایجاد zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---