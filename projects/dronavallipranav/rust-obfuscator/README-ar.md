
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# روسـت-أوبـفـوسـكـيـتـور

`rust-obfuscator` هو مجموعة من الأدوات المصممة لتعمية شيفرة مصدرية بلغة Rust تلقائيًا عن طريق إدراج وحدات ماكرو إجرائية أو (اختياريًا) توفير التعمية مباشرة في الشيفرة المصدرية. ولمزيد من التعمية الدقيقة، تتوفر أيضًا مكتبة ماكرو إجرائية [cryptify](https://crates.io/crates/cryptify).

## ما يتم دعمه حاليًا
1. تشفير القيم النصية الحرفية
2. تمويه تدفق التحكم
3. تمويه تدفق التحكم (في الشيفرة المصدرية)
4. إعادة تسمية المتغيرات (شفرة المصدر)

## الميزات

- **تشفير السلاسل النصية**: يقوم تلقائيًا بتشفير القيم النصية المخصصة للمتغيرات المحلية أثناء وقت الترجمة.
    - يمكن استخدامه أيضًا مع السلاسل النصية المنسقة، ولكن يتطلب حاليًا وضعها يدويًا
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **إخفاء تدفق التحكم**: يقدم حلقات وهمية وعشوائية متغيرة أثناء الترجمة.
- **إخفاء قابل للتخصيص**: يوفر إمكانية التفعيل أو التعطيل لميزات الإخفاء حسب متطلباتك.
- **إعادة تسمية المتغيرات**: إخفاء شفرة المصدر مباشرةً، إذا كنت ترغب في توزيع الشفرة أو جعلها تبدو أقل وضوحاً.
- ملاحظة: إعادة تسمية المتغيرات ليست فعالة بالكامل حتى الإصدار 1.1.1، نعمل على دعم كامل حيث توجد بعض الحالات غير المغطاة بعد. لا يزال بإمكانك استخدام الأداة وإصلاح أخطاء المترجم المناسبة.

## التثبيت

أضف `cryptify` إلى ملف `Cargo.toml` كاعتماد:

```toml
[dependencies]
cryptify = "3.2.1"
```
لتثبيت `rust-obfuscator`، قم باستنساخ المستودع وبناء الأداة باستخدام Cargo من الجذر:

```
cargo build --release --bin rust-obfuscator
```
يمكن العثور على الملف الثنائي بعد ذلك تحت /target/release، ويمكنك نسخه إلى جذر المشروع كما يلي
```
cp ./target/release/rust-obfuscator .
```

# الاستخدام
قم بتعيين متغير البيئة **CRYPTIFY_KEY** لمفتاح التشفير المخصص، وإلا سيتم استخدام المفتاح الثابت المُعرَّف افتراضيًا
- أضف إلى الشيفرة المصدرية التي ترغب في تعديلها
```rs
use cryptify;
```
يمكن استخدام الملف التنفيذي على ملف أو دليل. إذا تم توفير دليل، فسوف يعدل فقط ملفات مصدر Rust داخل ذلك الدليل ولن يعدل أي أدلة فرعية.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- سيكون كل الكود المشفر تحت دليل **obfuscated_code** الذي يتم إنشاؤه من الدليل الذي تم تشغيل الأداة فيه.
- **يوصى باستخدام منسق Rust مع الكود المشفر لأن syn يقوم بتعديل البنية تلقائيًا وسيتم كتابته إلى الملف كسطر واحد**

## علامات الخيارات
- --no_string: يعطل تشفير السلاسل النصية.
- --no_flow: يعطل تشفير تدفق التحكم.
- --disable_macro: يستخدم تعديل المصدر المباشر لتشفير تدفق التحكم بدلاً من الإجراءات البرمجية.
- --var: يمكّن تشفير إعادة تسمية المتغيرات في كود المصدر.

### مثال على الاستخدام مع العلامة
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(يعطل تمويه التدفق)

# الإدخال
-تشغيل الأداة بدون إعدادات
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
# الناتج
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
## الإخراج الموسع
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
# الترخيص
rust-obfuscator مرخص تحت رخصة MIT - راجع ملف [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) لمزيد من التفاصيل.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---