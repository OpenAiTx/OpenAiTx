
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ar">العربیة</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rust-Obfuscator

`rust-obfuscator` مجموعه‌ای از ابزارها است که برای مبهم‌سازی خودکار کد منبع Rust طراحی شده‌اند که این کار را از طریق درج ماکروهای رویه‌ای یا (در صورت تمایل) با ارائه مبهم‌سازی مستقیماً در کد منبع انجام می‌دهد. برای مبهم‌سازی دقیق‌تر، یک کتابخانه ماکرو رویه‌ای به نام [cryptify](https://crates.io/crates/cryptify) نیز ارائه شده است.

## پشتیبانی فعلی
1. رمزنگاری رشته‌های متنی
2. مبهم‌سازی جریان کنترل
3. مبهم‌سازی جریان کنترل (در کد منبع)
۴. تغییر نام متغیرها (کد منبع)

## ویژگی‌ها

- **رمزنگاری رشته**: به طور خودکار رشته‌های متنی اختصاص داده شده به متغیرهای محلی را در زمان کامپایل رمزنگاری می‌کند.
    - همچنین می‌تواند برای رشته‌های قالب‌بندی شده استفاده شود، اما در حال حاضر نیاز به قرار دادن دستی دارد
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **مبهم‌سازی جریان کنترل**: حلقه‌های ساختگی کامپایل و متغیرهای تصادفی را وارد می‌کند.
- **مبهم‌سازی قابل تنظیم**: امکان فعال یا غیرفعال کردن ویژگی‌های خاص مبهم‌سازی را بر اساس نیازهای شما فراهم می‌کند.
- **تغییر نام متغیرها**: مبهم‌سازی مستقیم کد منبع، اگر می‌خواهید کد را منتشر کنید یا فقط می‌خواهید کدتان بدتر به نظر برسد.
- توجه: تغییر نام متغیرها به طور کامل در نسخه ۱.۱.۱ عملیاتی نیست و در حال کار روی پشتیبانی کامل هستیم، چون برخی موارد هنوز پوشش داده نشده‌اند. همچنان می‌توانید ابزار را استفاده کرده و خطاهای مناسب کامپایلر را اصلاح کنید.

## نصب

`cryptify` را به عنوان وابستگی به `Cargo.toml` خود اضافه کنید:

```toml
[dependencies]
cryptify = "3.2.1"
```
برای نصب `rust-obfuscator`، مخزن را کلون کرده و ابزار را با استفاده از Cargo از ریشه بسازید:

```
cargo build --release --bin rust-obfuscator
```
باینری سپس می‌تواند در مسیر /target/release پیدا شود، شما می‌توانید آن را به ریشه پروژه کپی کنید مانند این
```
cp ./target/release/rust-obfuscator .
```

# استفاده
متغیر محیطی **CRYPTIFY_KEY** را برای رمزنگاری سفارشی تنظیم کنید، در غیر این صورت مقدار پیش‌فرض کلید ثابت استفاده می‌شود
- به کد منبعی که می‌خواهید تغییر دهید اضافه کنید
```rs
use cryptify;
```
این فایل اجرایی می‌تواند روی یک فایل یا یک پوشه استفاده شود. اگر یک پوشه ارائه شود، فقط فایل‌های سورس rust در آن پوشه را تغییر خواهد داد و نه زیرپوشه‌ها را.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- تمام کدهای مبهم‌شده در پوشه **obfuscated_code** قرار خواهند گرفت که از دایرکتوری‌ای که ابزار اجرا شده ساخته می‌شود.
- **توصیه می‌شود با کد مبهم‌شده از یک قالب‌بندی‌کننده Rust استفاده شود، چرا که syn به طور طبیعی ساختار را تغییر می‌دهد و فایل را به صورت یک خط می‌نویسد**

## گزینه‌های پرچم
- --no_string: مبهم‌سازی رشته‌ها را غیرفعال می‌کند.
- --no_flow: مبهم‌سازی جریان کنترل را غیرفعال می‌کند.
- --disable_macro: برای مبهم‌سازی جریان، به جای ماکروهای رویه‌ای، از دستکاری مستقیم سورس استفاده می‌کند.
- --var: مبهم‌سازی سورس کد با تغییر نام متغیرها را فعال می‌کند.

### نمونه استفاده با پرچم
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(غیرفعال کردن ابهام جریان)

# ورودی
-اجرای ابزار بدون پیکربندی
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
# خروجی
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
## خروجی گسترش‌یافته
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
# مجوز
rust-obfuscator تحت مجوز MIT ارائه شده است - برای جزئیات به فایل [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) مراجعه کنید.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---