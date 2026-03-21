<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rust-Obfuscator

`rust-obfuscator` là một bộ công cụ được thiết kế để tự động làm rối mã nguồn Rust bằng cách chèn macro thủ tục hoặc (tùy chọn) cung cấp sự làm rối trực tiếp trong mã nguồn. Để làm rối chi tiết hơn, thư viện macro thủ tục [cryptify](https://crates.io/crates/cryptify) cũng được cung cấp.

## Hiện đang hỗ trợ
1. mã hóa chuỗi ký tự
2. làm rối luồng điều khiển
3. làm rối luồng điều khiển (mã nguồn)

4. đổi tên biến (mã nguồn)

## Tính năng

- **Mã hóa chuỗi**: Tự động mã hóa các chuỗi ký tự được gán cho biến cục bộ tại thời điểm biên dịch.
    - Cũng có thể sử dụng cho chuỗi định dạng, nhưng hiện tại cần đặt thủ công
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Làm rối luồng điều khiển**: Thêm các vòng lặp giả khi biên dịch và biến ngẫu nhiên.
- **Làm rối tùy chỉnh**: Cung cấp sự linh hoạt để bật hoặc tắt các tính năng làm rối dựa trên yêu cầu của bạn.
- **Đổi tên biến**: Làm rối mã nguồn trực tiếp, nếu bạn muốn xuất bản mã hoặc chỉ muốn làm cho mã của bạn khó đọc hơn.
- LƯU Ý: Việc đổi tên biến chưa hoàn toàn hoạt động ở phiên bản 1.1.1, đang phát triển hỗ trợ đầy đủ vì một số trường hợp chưa được xử lý. Vẫn có thể sử dụng công cụ và sửa lỗi biên dịch phù hợp.

## Cài đặt

Thêm `cryptify` vào `Cargo.toml` của bạn như một dependency:

```toml
[dependencies]
cryptify = "3.2.1"
```

Để cài đặt `rust-obfuscator`, hãy clone kho lưu trữ và xây dựng công cụ bằng Cargo từ thư mục gốc:
```
cargo build --release --bin rust-obfuscator
```
Tệp nhị phân sau đó có thể được tìm thấy trong /target/release, bạn có thể sao chép nó vào thư mục gốc của dự án như sau
```
cp ./target/release/rust-obfuscator .
```

# Cách sử dụng
Thiết lập biến môi trường **CRYPTIFY_KEY** để sử dụng khoá mã hoá tuỳ chỉnh, nếu không sẽ mặc định sử dụng khoá cố định đã định nghĩa
- Thêm vào mã nguồn mà bạn muốn chỉnh sửa
```rs
use cryptify;
```
Tệp nhị phân có thể được sử dụng trên một tệp hoặc một thư mục. Nếu được cung cấp một thư mục, nó chỉ sửa đổi các tệp nguồn rust trong thư mục đó mà không sửa đổi bất kỳ thư mục con nào.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Tất cả mã đã làm rối sẽ nằm trong thư mục **obfuscated_code** được tạo ra từ thư mục mà công cụ được chạy.
- **Khuyến nghị sử dụng Trình Định Dạng Rust với mã đã làm rối vì syn tự nhiên thay đổi cấu trúc và nó sẽ được ghi ra tệp trên một dòng duy nhất**

## Các Cờ Tuỳ Chọn
- --no_string: Tắt làm rối chuỗi.
- --no_flow: Tắt làm rối luồng điều khiển.
- --disable_macro: Sử dụng thao tác trực tiếp trên mã nguồn để làm rối luồng thay vì macro thủ tục.
- --var: Bật làm rối mã nguồn bằng cách đổi tên biến.

### Ví dụ sử dụng với cờ
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(tắt làm rối luồng)

# Đầu vào
-chạy công cụ mà không có cấu hình
```rs
use cryptify;
mod word_counter;
use std::env;
use std::fs;
use word_counter::count_words;
fn main() {
    let b = "Hello World";
    println!("{}", b);
    let args: Vec<String> = env::args().collect();
    if args.len() < 2 {
        eprintln!("Usage: {} <filename>", args[0]);
        return;
    }
    let filename = &args[1];
    let content = fs::read_to_string(filename).expect("Could not read file");
    let word_counts = count_words(&content);
    for (word, count) in word_counts.iter() {
        println!("{}: {}", word, count);
    }
}

fn dummy() {
    let a = 1;
    let b = 2;
    let c = a + b;
    println!("{}", c);
}

fn calc_sum(a: i32, b: i32) -> i32 {
    cryptify::flow_stmt!();
    let c = a + b;
    c
}

fn helloooo(){
    println!("hi");
}

```
# Đầu ra
```rs
fn main() {
    cryptify::flow_stmt!();
    let b = cryptify::encrypt_string!("Hello World");
    println!("{}", b);
    let args: Vec<String> = env::args().collect();
    if args.len() < 2 {
        eprintln!("Usage: {} <filename>", args[0]);
        return;
    }
    let filename = &args[1];
    let content = fs::read_to_string(filename).expect("Could not read file");
    let word_counts = count_words(&content);
    for (word, count) in word_counts.iter() {
        println!("{}: {}", word, count);
    }
}
fn dummy() {
    cryptify::flow_stmt!();
    let a = 1;
    let b = 2;
    let c = a + b;
    println!("{}", c);
}
fn calc_sum(a: i32, b: i32) -> i32 {
    cryptify::flow_stmt!();
    let c = a + b;
    c
}
fn helloooo() {
    println!("hi");
}
```
## Đầu ra mở rộng
```rs
fn main() {
    {
        let _is_dummy_145 = true;
        let mut _dummy_counter = std::hint::black_box(4i32 as i32);
        let _dummy_increment = std::hint::black_box(1i32 as i32);
        let _dummy_upper_bound = std::hint::black_box(53i32 as i32);
        loop {
            if std::hint::black_box(_dummy_counter)
                > std::hint::black_box(_dummy_upper_bound)
            {
                break;
            }
            _dummy_counter = std::hint::black_box(
                std::hint::black_box(_dummy_counter)
                    + std::hint::black_box(_dummy_increment),
            );
        }
    };
    match (&1, &1) {
        (left_val, right_val) => {
            if !(*left_val == *right_val) {
                let kind = ::core::panicking::AssertKind::Eq;
                ::core::panicking::assert_failed(
                    kind,
                    &*left_val,
                    &*right_val,
                    ::core::option::Option::None,
                );
            }
        }
    };
}
fn dummy() {
    {
        let _is_dummy_145 = true;
        let mut _dummy_counter = 4i32;
        let _dummy_upper_bound = 100;
        let _dummy_increment = 3i32;
        loop {
            if _dummy_counter > _dummy_upper_bound {
                break;
            }
            unsafe {
                std::ptr::write_volatile(
                    &mut _dummy_counter,
                    _dummy_counter + _dummy_increment,
                );
            }
        }
    };
    let a = 1;
    let b = 2;
    let c = a + b;
    {
        ::std::io::_print(format_args!("{0}\n", c));
    };
}
fn calc_sum(a: i32, b: i32) -> i32 {
    {
        let _is_dummy_145 = true;
        let mut _dummy_counter = 8i32;
        let _dummy_increment = 3i32;
        let _extra_dummy_var = 4i32;
        let _dummy_upper_bound = 100;
        loop {
            if _dummy_counter > _dummy_upper_bound {
                break;
            }
            unsafe {
                std::ptr::write_volatile(
                    &mut _dummy_counter,
                    _dummy_counter + _dummy_increment,
                );
            }
        }
    };
    let c = a + b;
    c
}
fn helloooo() {
    {
        ::std::io::_print(format_args!("hi\n"));
    };
}
```
# Giấy phép
rust-obfuscator được cấp phép theo Giấy phép MIT - xem tệp [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) để biết thêm chi tiết.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---