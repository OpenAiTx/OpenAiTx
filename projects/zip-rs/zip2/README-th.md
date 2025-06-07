zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[เอกสารประกอบ](https://docs.rs/zip/latest/zip/)

ข้อมูล
----

ไลบรารี zip สำหรับภาษา Rust ที่รองรับการอ่านและเขียนไฟล์ ZIP พื้นฐาน เคยถูกโฮสต์ที่ 
https://github.com/zip-rs/zip2

รูปแบบการบีบอัดที่รองรับ:

* stored (ไม่มีการบีบอัด)
* deflate
* deflate64 (รองรับการคลายบีบอัดเท่านั้น)
* bzip2
* zstd
* lzma (รองรับการคลายบีบอัดเท่านั้น)
* xz (รองรับการคลายบีบอัดเท่านั้น)

ส่วนขยาย zip ที่ยังไม่รองรับในปัจจุบัน:

* Multi-disk

ฟีเจอร์
--------

ฟีเจอร์ที่มีให้เลือกใช้งานได้แก่:

* `aes-crypto`: เปิดใช้งานการถอดรหัสไฟล์ที่ถูกเข้ารหัสด้วย AES รองรับวิธี AE-1 และ AE-2
* `deflate`: เปิดใช้งานการบีบอัดและคลายบีบอัดด้วยการนำไปใช้ที่ยังไม่ระบุแน่ชัด (อาจเปลี่ยนแปลงได้ในอนาคต) ของอัลกอริธึม deflate ซึ่งเป็นค่าปกติสำหรับไฟล์ zip รองรับคุณภาพการบีบอัด 1..=264
* `deflate-flate2`: ใช้งานร่วมกับฟีเจอร์ `flate2` ที่เปิดใช้ back-end เพื่อรองรับการบีบอัด deflate ที่คุณภาพ 1..=9
* `deflate-zopfli`: เปิดใช้งานการบีบอัดไฟล์ด้วยไลบรารี `zopfli` (ใช้เมื่อคุณภาพการบีบอัดเป็น 10..=264) เป็นการนำไปใช้ deflate ที่มีประสิทธิภาพมากที่สุดแต่ช้าที่สุดเช่นกัน
* `deflate64`: เปิดใช้งานอัลกอริธึมการบีบอัด deflate64 รองรับเฉพาะการคลายบีบอัด
* `lzma`: เปิดใช้งานอัลกอริธึมการบีบอัด LZMA รองรับเฉพาะการคลายบีบอัด
* `bzip2`: เปิดใช้งานอัลกอริธึมการบีบอัด BZip2
* `time`: เปิดใช้งานฟีเจอร์ที่ใช้ [time](https://github.com/rust-lang-deprecated/time) crate
* `chrono`: เปิดใช้งานการแปลงข้อมูลเวลาแก้ไขล่าสุด `zip::DateTime` ไปยังและจาก `chrono::NaiveDateTime`
* `jiff-02`: เปิดใช้งานการแปลงข้อมูลเวลาแก้ไขล่าสุด `zip::DateTime` ไปยังและจาก `jiff::civil::DateTime`
* `nt-time`: เปิดใช้งานการคืนค่า timestamp ที่จัดเก็บใน NTFS extra field เป็น `nt_time::FileTime`
* `zstd`: เปิดใช้งานอัลกอริธึมการบีบอัด Zstandard

โดยค่าเริ่มต้นจะเปิดใช้ `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` และ `zstd`

MSRV
----

เวอร์ชัน Rust ขั้นต่ำที่รองรับในปัจจุบันคือ **1.75** เมื่อมีการเพิ่มฟีเจอร์ใหม่
จะยึดตามแนวทางดังนี้:

- จะรองรับเวอร์ชันย่อยของ Rust ที่เสถียรมาแล้วอย่างน้อย 6 เดือนเสมอ
- การเปลี่ยนแปลง MSRV จะมาพร้อมกับการปรับเลขเวอร์ชันระดับ **minor**

ตัวอย่าง
--------

ดูที่ [ไดเรกทอรีตัวอย่าง](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) สำหรับ:
   * วิธีเขียนไฟล์ลง zip
   * วิธีเขียนไดเรกทอรีของไฟล์ลง zip (โดยใช้ [walkdir](https://github.com/BurntSushi/walkdir))
   * วิธีแตกไฟล์ zip
   * วิธีแตกไฟล์เดียวจาก zip
   * วิธีอ่าน zip จาก standard input
   * วิธีเพิ่มไดเรกทอรีเข้าไปใน archive ที่มีอยู่เดิม

Fuzzing
-------

การรองรับ Fuzzing ใช้งานผ่าน [cargo afl](https://rust-fuzz.github.io/book/afl.html) ในการติดตั้ง cargo afl:

```bash
cargo install cargo-afl
```

เริ่มต้นการ fuzzing สำหรับการแตกไฟล์ zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

เริ่มต้นการ fuzzing สำหรับการสร้างไฟล์ zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---