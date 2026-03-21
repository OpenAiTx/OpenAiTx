
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=dronavallipranav&project=rust-obfuscator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rust-Obfuscator

`rust-obfuscator` ist eine Sammlung von Tools, die entwickelt wurden, um Rust-Quellcode automatisch zu verschleiern, indem prozedurale Makros eingefügt werden oder (optional) die Verschleierung direkt im Quellcode bereitgestellt wird. Für eine feinere Verschleierung wird außerdem eine prozedurale Makrobibliothek [cryptify](https://crates.io/crates/cryptify) angeboten.

## Derzeit unterstützt
1. Verschlüsselung von Zeichenkettenliteralen
2. Verschleierung des Kontrollflusses
3. Verschleierung des Kontrollflusses (Quellcode)
4. Variablenumbenennung (Quellcode)

## Funktionen

- **String-Verschlüsselung**: Verschlüsselt automatisch Zeichenkettenliterale, die lokalen Variablen zur Kompilierzeit zugewiesen werden.
    - Kann auch für formatierte Zeichenketten verwendet werden, erfordert aber derzeit eine manuelle Platzierung
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Kontrollfluss-Obfuskation**: Fügt kompilierte Dummy-Schleifen und Zufallsvariablen hinzu.
- **Anpassbare Obfuskation**: Bietet Flexibilität, bestimmte Obfuskationsfunktionen je nach Bedarf zu aktivieren oder zu deaktivieren.
- **Variablen-Umbenennung**: Obfuskiert den Quellcode direkt, falls Sie den Code ausliefern möchten oder einfach nur das Aussehen Ihres Codes verschlechtern wollen.
- HINWEIS: Variablen-Umbenennung ist ab Version 1.1.1 noch nicht voll funktionsfähig; volle Unterstützung wird entwickelt, da einige Fälle noch nicht abgedeckt sind. Das Tool kann dennoch verwendet und die entsprechenden Compilerfehler behoben werden.

## Installation

Fügen Sie `cryptify` als Abhängigkeit zu Ihrer `Cargo.toml` hinzu:

```toml
[dependencies]
cryptify = "3.2.1"
```
Um `rust-obfuscator` zu installieren, klonen Sie das Repository und bauen Sie das Tool mit Cargo aus dem Root-Verzeichnis:

```
cargo build --release --bin rust-obfuscator
```
Die Binärdatei befindet sich anschließend unter /target/release, Sie können sie wie folgt in das Stammverzeichnis des Projekts kopieren
```
cp ./target/release/rust-obfuscator .
```

# Verwendung
Setzen Sie die Umgebungsvariable **CRYPTIFY_KEY** für benutzerdefinierte Verschlüsselung, andernfalls wird der voreingestellte Schlüssel verwendet
- Fügen Sie dies zum Quellcode hinzu, den Sie ändern möchten
```rs
use cryptify;
```
Die Binärdatei kann entweder für eine Datei oder ein Verzeichnis verwendet werden. Wenn ein Verzeichnis angegeben wird, werden nur Rust-Quelldateien innerhalb dieses Verzeichnisses geändert, nicht in Unterverzeichnissen.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Alle verschleierten Codes befinden sich im **obfuscated_code**-Verzeichnis, das aus dem Verzeichnis erstellt wird, in dem das Tool ausgeführt wurde.
- **Empfohlen wird die Verwendung eines Rust-Formatierers mit dem verschleierten Code, da syn die Struktur natürlich verändert und der Code als eine Zeile in die Datei geschrieben wird**

## Optionsflags
- --no_string: Deaktiviert die String-Verschleierung.
- --no_flow: Deaktiviert die Kontrollfluss-Verschleierung.
- --disable_macro: Verwendet direkte Quellmanipulation für Kontrollfluss-Verschleierung anstelle von prozeduralen Makros.
- --var: Aktiviert die Quellcode-Verschleierung durch Variablen-Umbenennung.

### Beispiel für die Verwendung mit Flag
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(deaktiviert Flow-Obfuskation)

# Eingabe
-Ausführen des Tools ohne Konfiguration
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
# Ausgabe
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
## Erweiterte Ausgabe
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
# Lizenz
rust-obfuscator ist unter der MIT-Lizenz lizenziert – siehe die [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE)-Datei für Details.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---