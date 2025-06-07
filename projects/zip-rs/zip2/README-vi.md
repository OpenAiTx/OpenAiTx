zip
========

[![Build Status](https://github.com/zip-rs/zip2/actions/workflows/ci.yaml/badge.svg)](https://github.com/Pr0methean/zip/actions?query=branch%3Amaster+workflow%3ACI)
[![Crates.io version](https://img.shields.io/crates/v/zip.svg)](https://crates.io/crates/zip)

[Tài liệu](https://docs.rs/zip/latest/zip/)

Thông tin
----

Một thư viện zip cho Rust hỗ trợ đọc và ghi các tệp ZIP đơn giản. Trước đây được lưu trữ tại 
https://github.com/zip-rs/zip2.

Các định dạng nén được hỗ trợ:

* stored (không nén)
* deflate
* deflate64 (chỉ giải nén)
* bzip2
* zstd
* lzma (chỉ giải nén)
* xz (chỉ giải nén)

Các phần mở rộng zip hiện chưa được hỗ trợ:

* Multi-disk

Tính năng
--------

Các tính năng có sẵn bao gồm:

* `aes-crypto`: Kích hoạt giải mã các tệp được mã hóa bằng AES. Hỗ trợ các phương pháp AE-1 và AE-2.
* `deflate`: Kích hoạt nén và giải nén bằng một triển khai không xác định (có thể thay đổi trong các phiên bản tương lai) của thuật toán nén deflate, là mặc định cho các tệp zip. Hỗ trợ chất lượng nén 1..=264.
* `deflate-flate2`: Kết hợp với bất kỳ cờ tính năng `flate2` nào kích hoạt một back-end, để hỗ trợ nén deflate ở chất lượng 1..=9.
* `deflate-zopfli`: Kích hoạt nén deflate bằng thư viện `zopfli` (được sử dụng khi chất lượng nén là 10..=264). Đây là triển khai `deflate` hiệu quả nhất hiện có, nhưng cũng là một trong những phương pháp chậm nhất.
* `deflate64`: Kích hoạt thuật toán nén deflate64. Chỉ hỗ trợ giải nén.
* `lzma`: Kích hoạt thuật toán nén LZMA. Chỉ hỗ trợ giải nén.
* `bzip2`: Kích hoạt thuật toán nén BZip2.
* `time`: Kích hoạt các tính năng sử dụng crate [time](https://github.com/rust-lang-deprecated/time).
* `chrono`: Kích hoạt chuyển đổi `zip::DateTime` sửa đổi lần cuối sang và từ `chrono::NaiveDateTime`.
* `jiff-02`: Kích hoạt chuyển đổi `zip::DateTime` sửa đổi lần cuối sang và từ `jiff::civil::DateTime`.
* `nt-time`: Kích hoạt trả về dấu thời gian lưu trong trường bổ sung NTFS dưới dạng `nt_time::FileTime`.
* `zstd`: Kích hoạt thuật toán nén Zstandard.

Mặc định các tính năng `aes-crypto`, `bzip2`, `deflate`, `deflate64`, `lzma`, `time` và `zstd` được bật.

MSRV
----

Phiên bản Rust tối thiểu hiện tại được hỗ trợ là **1.75**. Khi bổ sung tính năng mới,
chúng tôi sẽ tuân theo các hướng dẫn sau:

- Luôn hỗ trợ phiên bản Rust nhỏ đã ổn định ít nhất 6 tháng.
- Bất kỳ thay đổi nào đối với MSRV sẽ kèm theo tăng phiên bản **minor**.

Ví dụ
--------

Xem [thư mục examples](https://raw.githubusercontent.com/zip-rs/zip2/master/examples) để biết:
   * Cách ghi một tệp vào tệp zip.
   * Cách ghi một thư mục chứa các tệp vào tệp zip (sử dụng [walkdir](https://github.com/BurntSushi/walkdir)).
   * Cách giải nén một tệp zip.
   * Cách giải nén một tệp đơn lẻ từ tệp zip.
   * Cách đọc một tệp zip từ đầu vào chuẩn.
   * Cách thêm một thư mục vào một kho lưu trữ hiện có.

Fuzzing
-------

Hỗ trợ fuzzing thông qua [cargo afl](https://rust-fuzz.github.io/book/afl.html). Để cài đặt cargo afl:

```bash
cargo install cargo-afl
```

Để bắt đầu fuzzing quá trình giải nén zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_read/Cargo.toml
cargo +nightly afl run fuzz_read/target/debug/fuzz_read
```

Để bắt đầu fuzzing quá trình tạo zip:

```bash
cargo +nightly afl build --all-features --manifest-path fuzz_write/Cargo.toml
cargo +nightly afl run fuzz_write/target/debug/fuzz_write
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---