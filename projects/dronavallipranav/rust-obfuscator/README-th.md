
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=en">อังกฤษ</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ja">ญี่ปุ่น</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ko">เกาหลี</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=hi">ฮินดี</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fr">ฝรั่งเศส</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=de">เยอรมัน</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=es">สเปน</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=it">อิตาลี</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ru">รัสเซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pt">โปรตุเกส</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=nl">ดัตช์</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pl">โปแลนด์</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ar">อาหรับ</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fa">เปอร์เซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=tr">ตุรกี</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=vi">เวียดนาม</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=id">อินโดนีเซีย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rust-Obfuscator

`rust-obfuscator` คือชุดเครื่องมือที่ออกแบบมาเพื่อทำการกลบเกลื่อนซอร์สโค้ดภาษา Rust โดยอัตโนมัติด้วยการแทรก procedural macros หรือ (ตามตัวเลือก) ให้กลบเกลื่อนในซอร์สโค้ดโดยตรง สำหรับการกลบเกลื่อนที่ละเอียดมากขึ้น มีไลบรารี procedural macro [cryptify](https://crates.io/crates/cryptify) ให้ใช้งานด้วย

## รองรับในปัจจุบัน
1. เข้ารหัส string literal
2. กลบเกลื่อนการควบคุมโฟลว์
3. กลบเกลื่อนการควบคุมโฟลว์ (ซอร์สโค้ด)
4. การเปลี่ยนชื่อของตัวแปร (ซอร์สโค้ด)

## คุณสมบัติ

- **การเข้ารหัสสตริง**: เข้ารหัสตัวอักษรสตริงที่กำหนดให้กับตัวแปรภายในโดยอัตโนมัติในขณะคอมไพล์
    - สามารถใช้กับสตริงที่มีการจัดรูปแบบได้เช่นกัน แต่ขณะนี้ต้องวางด้วยตนเอง
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **การทำให้โฟลว์ควบคุมซับซ้อน**: เพิ่มลูปหลอกและตัวแปรสุ่มเข้าไปในขั้นตอนคอมไพล์
- **การทำให้ซับซ้อนแบบกำหนดเองได้**: มีความยืดหยุ่นให้เปิดหรือปิดคุณสมบัติการทำให้ซับซ้อนได้ตามความต้องการของคุณ
- **การเปลี่ยนชื่อตัวแปร**: ทำให้ซอร์สโค้ดซับซ้อนโดยตรง หากคุณต้องการส่งมอบโค้ดหรืออยากให้โค้ดดูแย่ลง
- หมายเหตุ: การเปลี่ยนชื่อตัวแปรยังไม่สมบูรณ์ในเวอร์ชัน 1.1.1 กำลังพัฒนาให้รองรับกรณีเพิ่มเติม ยังสามารถใช้เครื่องมือนี้และแก้ไขข้อผิดพลาดของคอมไพเลอร์ที่เกิดขึ้นได้

## การติดตั้ง

เพิ่ม `cryptify` ใน `Cargo.toml` ของคุณเป็น dependency:

```toml
[dependencies]
cryptify = "3.2.1"
```

ในการติดตั้ง `rust-obfuscator` ให้โคลน repository และสร้างเครื่องมือโดยใช้ Cargo จาก root:
```
cargo build --release --bin rust-obfuscator
```
ไบนารีสามารถพบได้ที่ /target/release จากนั้นคุณสามารถคัดลอกไปยังรูทของโปรเจกต์ได้ดังนี้
```
cp ./target/release/rust-obfuscator .
```

# การใช้งาน
ตั้งค่าตัวแปรสภาพแวดล้อม **CRYPTIFY_KEY** สำหรับการเข้ารหัสแบบกำหนดเอง มิฉะนั้นจะใช้คีย์ที่กำหนดไว้
- เพิ่มลงในซอร์สโค้ดที่คุณต้องการแก้ไข
```rs
use cryptify;
```
ไบนารีสามารถใช้กับไฟล์หรือไดเรกทอรีก็ได้ หากให้ไดเรกทอรีมันจะปรับแต่งเฉพาะไฟล์ซอร์สรัสต์ภายในไดเรกทอรีนั้นเท่านั้น ไม่ใช่ไดเรกทอรีย่อย
```sh
./rust-obfuscator path/to/your_project <Options>
```
- โค้ดที่ถูกทำให้เป็นโค้ดลึกลับทั้งหมดจะอยู่ในไดเรกทอรี **obfuscated_code** ซึ่งถูกสร้างขึ้นจากไดเรกทอรีที่เครื่องมือถูกเรียกใช้งาน
- **แนะนำให้ใช้ Rust Formatter กับโค้ดที่ถูกทำให้เป็นโค้ดลึกลับ เนื่องจาก syn จะปรับโครงสร้างโดยธรรมชาติและจะถูกเขียนลงไฟล์เป็นบรรทัดเดียว**

## ธงตัวเลือก
- --no_string: ปิดใช้งานการทำให้สตริงเป็นโค้ดลึกลับ
- --no_flow: ปิดใช้งานการทำให้โฟลว์ควบคุมเป็นโค้ดลึกลับ
- --disable_macro: ใช้การปรับแต่งซอร์สโดยตรงสำหรับการทำโฟลว์เป็นโค้ดลึกลับแทนการใช้ procedural macros
- --var: เปิดใช้งานการเปลี่ยนชื่อชื่อตัวแปรเพื่อทำให้ซอร์สโค้ดเป็นโค้ดลึกลับ

### ตัวอย่างการใช้งานพร้อมธง
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(ปิดการทำงานของการพรางโฟลว์)

# อินพุต
-รันเครื่องมือโดยไม่มีการตั้งค่าคอนฟิก
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
# ผลลัพธ์
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
## ผลลัพธ์ที่ขยาย
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
# ใบอนุญาต
rust-obfuscator ได้รับอนุญาตภายใต้ใบอนุญาต MIT - ดูไฟล์ [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) สำหรับรายละเอียด


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---