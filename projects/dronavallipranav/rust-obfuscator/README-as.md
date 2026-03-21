
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=hi">হिन्दী</a>
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

# ৰাষ্ট-অবফুসকেটৰ

`rust-obfuscator` হৈছে এটা সঁজুলি সমষ্টি যি স্বয়ংক্ৰিয়ভাৱে ৰাষ্ট উৎস কোড অবফুসকেট কৰিবলৈ প্ৰসিডিউৰেল মেক্ৰো সংস্থাপন কৰে বা (ঐচ্ছিকভাৱে) উৎস কোডত সোজাসুজি অবফুসকেট কৰে। অধিক সূক্ষ্ম অবফুসকেটৰ বাবে এটা প্ৰসিডিউৰেল মেক্ৰো লাইব্ৰেৰি [cryptify](https://crates.io/crates/cryptify) উপলব্ধ।

## বৰ্তমান সমৰ্থিত
১. ষ্ট্রিং লিটাৰেল সংকেতীকৰণ
২. কন্ট্ৰোল-ফ্ল’ অবফুসকেটৰ
৩. কন্ট্ৰোল-ফ্ল’ অবফুসকেটৰ (উৎস কোড)
৪. ভেৰিয়েবল পুনৰ নামকৰণ (উৎস ক'ড)

## বৈশিষ্ট্যসমূহ

- **ষ্ট্ৰিং সংকৰণ**: সংকলন সময়ত স্থানীয় ভেৰিয়েবলত নিৰ্দিষ্ট ষ্ট্ৰিং লিটেৰেলসমূহ স্বয়ংক্ৰিয়ভাৱে সংকৰণ কৰে।
    - ফৰ্মেটেড ষ্ট্ৰিংসমূহৰ বাবে ব্যৱহাৰ কৰিব পাৰি, কিন্তু বৰ্তমান হাততকৈ স্থাপন কৰিব লাগিব
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **নিয়ন্ত্ৰণ প্ৰৱাহ অপস্কিউফিকেশন**: সংকলন-ডামি ডামি লুপ আৰু ৰেণ্ডম ভেৰিয়েবলসমূহ যোগ কৰে।
- **স্বনিয়ন্ত্ৰিত অপস্কিউফিকেশন**: আপোনাৰ আৱশ্যকতাৰ ভিত্তিত নিৰ্দিষ্ট অপস্কিউফিকেশন বৈশিষ্ট্যসমূহ সক্ৰিয় বা নিষ্ক্ৰিয় কৰিবলৈ নমনীয়তা আগবঢ়ায়।
- **ভেৰিয়েবল পুনঃনামাকৰণ**: উৎস ক'ডকেই সোজাসুজি অপস্কিউফাই কৰে, যদি আপুনি ক'ড শ্বিপ কৰিব বিচাৰে বা কেৱল ক'ডটো অধিক জটিল দেখুৱাব বিচাৰে।
- টোকা: ভেৰিয়েবল পুনঃনামাকৰণ সম্পূৰ্ণৰূপে কাৰ্যক্ষম নহয় ১.১.১-ত, সম্পূৰ্ণ সমৰ্থনৰ ওপৰত কাম চলি আছে কিয়নো কিছুমান ক্ষেত্ৰ আৱৃত নহয়। এই টুল ব্যৱহাৰ কৰিব পাৰি আৰু উপযুক্ত সংকলক ত্ৰুটিসমূহ ঠিক কৰিব পাৰি।

## ইনষ্টলেচন

`cryptify`-ক আপোনাৰ `Cargo.toml`-ত এখন নিৰ্ভৰশীলতা হিচাপে যোগ কৰক:

```toml
[dependencies]
cryptify = "3.2.1"
```
`rust-obfuscator` ইনষ্টল কৰিবলৈ, ৰিপ'জিট'ৰীটো ক্লোন কৰক আৰু মূল ডিৰেক্টৰীৰ পৰা Cargo ব্যৱহাৰ কৰি টুলটো বিল্ড কৰক:

```
cargo build --release --bin rust-obfuscator
```
বাইনারিটো তাৰপাছত /target/release ত পোৱা যাব, আপুনি ইয়াক প্ৰকল্পৰ মূলত কপি কৰিব পাৰে এইদৰে
```
cp ./target/release/rust-obfuscator .
```

# ব্যৱহাৰ
স্বনির্বাচিত সাঙ্কেতিকৰণৰ বাবে **CRYPTIFY_KEY** পৰিৱেশ চলকটো সংহতি কৰক, নতুবা এইটো নিৰ্ধাৰিত স্থায়ী চাবিকেইডালত ডিফল্ট হব
- সংশোধন কৰিব বিচৰা উৎস ক'ডত যোগ কৰক
```rs
use cryptify;
```
বাইনাৰীটো এটা ফাইল অথবা এটা ডিৰেক্টৰীত ব্যৱহাৰ কৰিব পাৰি। যদি এটা ডিৰেক্টৰী প্ৰদান কৰা হয়, তেন্তে ই সেই ডিৰেক্টৰীৰ ভিতৰত থকা ৰাষ্ট উৎস ফাইলসমূহহে পৰিবৰ্তন কৰিব, কোনো উপডিৰেক্টৰীত নহয়।
```sh
./rust-obfuscator path/to/your_project <Options>
```
- সকলো অবস্কিউৰ কৰা কোড **obfuscated_code** ডাইৰেক্টৰিত থাকিব যিটো টুলটো চলোৱা ডাইৰেক্টৰীৰ পৰা সৃষ্টি কৰা হয়।
- **অবস্কিউৰ কৰা কোডৰ সৈতে এজন Rust Formatter ব্যৱহাৰ কৰাৰ পৰামৰ্শ দিয়া হৈছে কাৰণ syn স্বাভাৱিকভাৱে গঠনটো সলনি কৰে আৰু ফাইলত এটা শাৰীত লিখা হ’ব**

## বিকল্প ফ্লেগসমূহ
- --no_string: ষ্ট্ৰিং অবস্কিউৰেচন নিষ্ক্ৰিয় কৰে।
- --no_flow: কণ্ট্ৰ'ল ফ্লো অবস্কিউৰেচন নিষ্ক্ৰিয় কৰে।
- --disable_macro: প্ৰচলিত মেক্ৰ'ৰ সলনি ফ্লো অবস্কিউৰেচনৰ বাবে সৰাসৰি উৎস পৰিবৰ্তন ব্যৱহাৰ কৰে।
- --var: ভেৰিয়েবল নাম পৰিবৰ্তন উৎস কোড অবস্কিউৰেচন সক্ৰিয় কৰে।

### ফ্লেগৰ সৈতে ব্যৱহাৰৰ উদাহৰণ
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(প্ৰবাহ অপস্কুৰিতি নিষ্ক্ৰিয় কৰে)

# Input
-কোনো কনফিগৰেশ্বন নোহোৱা অৱস্থাত টুলটো চলোৱা
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
# আউটপুট
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
## বিস্তৃত আউটপুট
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
# লাইচেঞ্চ
rust-obfuscator MIT লাইচেঞ্চৰ অধীনত লাইচেঞ্চ কৰা হৈছে - অধিক তথ্যৰ বাবে [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) ফাইলটো চাওক।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---