
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rust-Obfuscator

`rust-obfuscator` is een set van tools ontworpen om Rust broncode automatisch te obfusceren door procedurele macro's in te voegen of door (optioneel) de obfuscatie direct in de broncode te leveren. Voor meer fijnmazige obfuscatie is er ook een procedurele macro bibliotheek [cryptify](https://crates.io/crates/cryptify) beschikbaar.

## Momenteel ondersteund
1. encryptie van string-literals
2. obfuscatie van controleflow
3. obfuscatie van controleflow (broncode)
4. variabele hernoeming (broncode)

## Functies

- **String Encryptie**: Versleutelt automatisch stringliteralen die aan lokale variabelen worden toegewezen tijdens compilatie.
    - Kan ook worden gebruikt voor geformatteerde strings, maar vereist momenteel handmatige plaatsing
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Besturingsstroom-obfuscatie**: Voegt compile-dummy dummy-lussen en willekeurige variabelen toe.
- **Aanpasbare obfuscatie**: Biedt flexibiliteit om specifieke obfuscatie-functies in of uit te schakelen op basis van jouw vereisten.
- **Variabelen hernoemen**: Obfusceert direct de broncode, als je de code wilt leveren of gewoon wilt dat je code er slechter uitziet.
- LET OP: variabelen hernoemen is niet volledig functioneel vanaf 1.1.1, volledige ondersteuning wordt nog uitgewerkt omdat sommige gevallen nog niet zijn afgedekt. Je kunt de tool nog steeds gebruiken en de juiste compilerfouten herstellen.

## Installatie

Voeg `cryptify` toe aan je `Cargo.toml` als een afhankelijkheid:

```toml
[dependencies]
cryptify = "3.2.1"
```

Om `rust-obfuscator` te installeren, kloon je de repository en bouw je het gereedschap met Cargo vanuit de hoofdmap:
```
cargo build --release --bin rust-obfuscator
```
Het binair bestand is vervolgens te vinden onder /target/release, je kunt het naar de root van het project kopiëren zoals volgt
```
cp ./target/release/rust-obfuscator .
```

# Gebruik
Stel de **CRYPTIFY_KEY** omgevingsvariabele in voor aangepaste encryptie, anders wordt de standaard vaste sleutel gebruikt
- Voeg toe aan de broncode die u wilt aanpassen
```rs
use cryptify;
```
Het binair bestand kan worden gebruikt op een bestand of een directory. Als een directory wordt opgegeven, zal het alleen Rust-bronbestanden binnen die directory wijzigen, niet in subdirectories.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Alle geobfusceerde code zal zich bevinden in de map **obfuscated_code** die wordt aangemaakt vanuit de map waarin de tool is uitgevoerd.
- **Aanbevolen om een Rust Formatter te gebruiken met de geobfusceerde code, aangezien syn de structuur natuurlijk wijzigt en het als één regel naar het bestand wordt geschreven**

## Optievlaggen
- --no_string: Schakelt stringobfuscatie uit.
- --no_flow: Schakelt control flow obfuscatie uit.
- --disable_macro: Gebruikt directe bronmanipulatie voor flow-obfuscatie in plaats van procedurele macro's.
- --var: Schakelt broncode-obfuscatie door variabelen hernoemen in.

### Voorbeeld van gebruik met vlag
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(schakelt flow-obfuscatie uit)

# Invoer
-het hulpmiddel uitvoeren zonder configuratie
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
# Uitvoer
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
## Uitgebreide Uitvoer
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
# Licentie
rust-obfuscator is gelicentieerd onder de MIT-licentie - zie het [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) bestand voor details.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---