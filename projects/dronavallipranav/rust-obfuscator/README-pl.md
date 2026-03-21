
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

`rust-obfuscator` to zestaw narzędzi zaprojektowanych do automatycznego zaciemniania kodu źródłowego Rust poprzez wstawianie makr proceduralnych lub (opcjonalnie) bezpośrednie zaciemnianie w kodzie źródłowym. Dla bardziej szczegółowego zaciemniania dostępna jest także biblioteka makr proceduralnych [cryptify](https://crates.io/crates/cryptify).

## Aktualnie wspierane
1. szyfrowanie literałów tekstowych
2. zaciemnianie przepływu sterowania
3. zaciemnianie przepływu sterowania (kod źródłowy)
4. zmiana nazw zmiennych (kod źródłowy)

## Funkcje

- **Szyfrowanie ciągów znaków**: Automatycznie szyfruje literały ciągów znaków przypisane do zmiennych lokalnych podczas kompilacji.
    - Może być również używane do sformatowanych ciągów znaków, ale obecnie wymaga ręcznego umieszczenia
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Zaciemnianie przepływu sterowania**: Wprowadza fikcyjne pętle kompilacyjne i losowe zmienne.
- **Konfigurowalne zaciemnianie**: Oferuje elastyczność w włączaniu lub wyłączaniu konkretnych funkcji zaciemniania w zależności od potrzeb.
- **Zmiana nazw zmiennych**: Zaciemnianie kodu źródłowego bezpośrednio, jeśli chcesz rozprowadzać kod lub po prostu sprawić, by wyglądał gorzej.
- UWAGA: zmiana nazw zmiennych nie działa w pełni poprawnie w wersji 1.1.1, trwają prace nad pełnym wsparciem, ponieważ niektóre przypadki nie są jeszcze obsłużone. Nadal można korzystać z narzędzia i poprawić odpowiednie błędy kompilatora.

## Instalacja

Dodaj `cryptify` do swojego pliku `Cargo.toml` jako zależność:

```toml
[dependencies]
cryptify = "3.2.1"
```
Aby zainstalować `rust-obfuscator`, sklonuj repozytorium i zbuduj narzędzie za pomocą Cargo z katalogu głównego:

```
cargo build --release --bin rust-obfuscator
```
Plik binarny można następnie znaleźć w katalogu /target/release, możesz go skopiować do katalogu głównego projektu w następujący sposób
```
cp ./target/release/rust-obfuscator .
```

# Użycie
Ustaw zmienną środowiskową **CRYPTIFY_KEY** dla własnego szyfrowania, w przeciwnym razie zostanie użyty domyślnie zdefiniowany stały klucz
- Dodaj do kodu źródłowego, który chcesz zmodyfikować
```rs
use cryptify;
```
Plik binarny może być używany zarówno na pliku, jak i katalogu. Jeśli zostanie podany katalog, zmodyfikuje tylko pliki źródłowe Rust znajdujące się w tym katalogu, a nie w podkatalogach.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Cały kod zaciemniony będzie znajdował się w katalogu **obfuscated_code**, który zostanie utworzony w katalogu, z którego uruchomiono narzędzie.
- **Zaleca się użycie formatera Rust dla kodu zaciemnionego, ponieważ syn naturalnie modyfikuje strukturę i kod zostanie zapisany do pliku jako jedna linia**

## Flagi opcji
- --no_string: Wyłącza zaciemnianie ciągów znaków.
- --no_flow: Wyłącza zaciemnianie przepływu sterowania.
- --disable_macro: Używa bezpośredniej manipulacji kodem źródłowym do zaciemniania przepływu zamiast proceduralnych makr.
- --var: Włącza zaciemnianie kodu źródłowego poprzez zmianę nazw zmiennych.

### Przykład użycia z flagą
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(wyłącza zaciemnianie przepływu)

# Wejście
-uruchamianie narzędzia bez konfiguracji
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
# Wyjście
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
## Rozszerzone wyjście
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
# Licencja
rust-obfuscator jest licencjonowany na warunkach licencji MIT – szczegóły znajdziesz w pliku [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---