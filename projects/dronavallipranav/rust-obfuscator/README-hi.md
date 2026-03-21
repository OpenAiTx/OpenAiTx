<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

`rust-obfuscator` उपकरणों का एक सेट है, जिसे ऑटोमैटिक रूप से Rust स्रोत कोड को अस्पष्ट (obfuscate) करने के लिए डिज़ाइन किया गया है, जिसमें प्रोसिजरल मैक्रोज़ जोड़कर या (वैकल्पिक रूप से) सीधे स्रोत कोड में अस्पष्टता प्रदान करके। अधिक सूक्ष्म अस्पष्टता के लिए एक प्रोसिजरल मैक्रो लाइब्रेरी [cryptify](https://crates.io/crates/cryptify) भी उपलब्ध है।

## वर्तमान में समर्थित
1. स्ट्रिंग लिटरल एन्क्रिप्शन
2. नियंत्रण-प्रवाह अस्पष्टता
3. नियंत्रण-प्रवाह अस्पष्टता (स्रोत कोड)

4. वेरिएबल नाम बदलना (सोर्स कोड)

## विशेषताएँ

- **स्ट्रिंग एन्क्रिप्शन**: संकलन के समय स्थानीय वेरिएबल्स को सौंपे गए स्ट्रिंग लिटेरल्स को स्वचालित रूप से एन्क्रिप्ट करता है।
    - इसे फॉर्मेटेड स्ट्रिंग्स के लिए भी उपयोग किया जा सकता है, लेकिन वर्तमान में मैनुअल स्थान की आवश्यकता होती है
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **कंट्रोल फ्लो ऑब्स्क्युफिकेशन**: संकलन के दौरान नकली लूप और रैंडम वेरिएबल्स शामिल करता है।
- **कस्टमाइज़ेबल ऑब्स्क्युफिकेशन**: आपकी आवश्यकताओं के अनुसार विशेष ऑब्स्क्युफिकेशन फीचर्स को सक्षम या अक्षम करने की सुविधा देता है।
- **वेरिएबल रीनेमिंग**: सोर्स कोड की ऑब्स्क्युफिकेशन सीधे करता है, अगर आप कोड को शिप करना चाहते हैं या सिर्फ कोड को और जटिल बनाना चाहते हैं।
- नोट: वेरिएबल रीनेमिंग 1.1.1 तक पूरी तरह कार्यशील नहीं है, पूर्ण समर्थन पर काम चल रहा है क्योंकि कुछ केस कवर नहीं हुए हैं। फिर भी टूल का उपयोग कर सकते हैं और उचित कम्पाइलर त्रुटियाँ सुधार सकते हैं।

## इंस्टॉलेशन

अपने `Cargo.toml` में `cryptify` को डिपेंडेंसी के रूप में जोड़ें:

```toml
[dependencies]
cryptify = "3.2.1"
```
`rust-obfuscator` को इंस्टॉल करने के लिए, रिपॉजिटरी को क्लोन करें और रूट से Cargo का उपयोग करके टूल को बिल्ड करें:

```
cargo build --release --bin rust-obfuscator
```
बाइनरी को फिर /target/release के अंतर्गत पाया जा सकता है, आप इसे प्रोजेक्ट की रूट में इस प्रकार कॉपी कर सकते हैं
```
cp ./target/release/rust-obfuscator .
```

# उपयोग
कस्टम एन्क्रिप्शन के लिए **CRYPTIFY_KEY** एनवायरनमेंट वेरिएबल सेट करें, अन्यथा यह डिफ़ॉल्ट रूप से निर्धारित फिक्स्ड की का उपयोग करता है
- उस सोर्स कोड में जोड़ें जिसे आप संशोधित करना चाहते हैं
```rs
use cryptify;
```
बाइनरी का उपयोग किसी फ़ाइल या डायरेक्टरी पर किया जा सकता है। यदि डायरेक्टरी दी जाती है तो यह केवल उस डायरेक्टरी के भीतर रस्ट सोर्स फ़ाइलों को संशोधित करेगा, किसी भी सबडायरेक्टरी को नहीं।
```sh
./rust-obfuscator path/to/your_project <Options>
```
- सभी अस्पष्टित कोड **obfuscated_code** डायरेक्टरी के अंतर्गत होंगे, जो उस डायरेक्टरी से बनाई जाती है जहाँ टूल चलाया गया था।
- **अस्पष्टित कोड के साथ Rust Formatter का उपयोग करने की अनुशंसा की जाती है क्योंकि syn स्वाभाविक रूप से संरचना को बदलता है और इसे फाइल में एक ही पंक्ति में लिखा जाएगा**

## विकल्प फ्लैग्स
- --no_string: स्ट्रिंग अस्पष्टन को अक्षम करता है।
- --no_flow: नियंत्रण प्रवाह अस्पष्टन को अक्षम करता है।
- --disable_macro: प्रवाह अस्पष्टन के लिए प्रक्रियात्मक मैक्रोज़ के बजाय प्रत्यक्ष स्रोत हेरफेर का उपयोग करता है।
- --var: वेरिएबल नाम बदलने के स्रोत कोड अस्पष्टन को सक्षम करता है।

### फ्लैग के साथ उपयोग का उदाहरण
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(फ्लो अस्पष्टता को अक्षम करता है)

# इनपुट
-टूल को बिना किसी कॉन्फ़िग के चलाना
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
# आउटपुट
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
## विस्तारित आउटपुट
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
# लाइसेंस
rust-obfuscator MIT लाइसेंस के तहत लाइसेंस प्राप्त है - विवरण के लिए [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) फ़ाइल देखें।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---