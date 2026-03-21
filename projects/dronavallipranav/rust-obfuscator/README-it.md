
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

`rust-obfuscator` è un insieme di strumenti progettato per offuscare automaticamente il codice sorgente Rust inserendo macro procedurali o (opzionalmente) fornendo l’offuscamento direttamente nel codice sorgente. Per un’offuscamento più granulare è anche disponibile una libreria di macro procedurali [cryptify](https://crates.io/crates/cryptify).

## Attualmente supportato
1. cifratura dei letterali stringa
2. offuscamento del flusso di controllo
3. offuscamento del flusso di controllo (codice sorgente)
4. rinomina delle variabili (codice sorgente)

## Caratteristiche

- **Crittografia delle stringhe**: Cripta automaticamente i letterali di stringa assegnati alle variabili locali durante la compilazione.
    - Può essere utilizzato anche per stringhe formattate, ma attualmente richiede un inserimento manuale
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Offuscamento del flusso di controllo**: Introduce loop fittizi di compilazione e variabili casuali.
- **Offuscamento personalizzabile**: Offre flessibilità per abilitare o disabilitare specifiche funzionalità di offuscamento in base alle tue esigenze.
- **Rinominazione delle variabili**: Offusca direttamente il codice sorgente, se desideri distribuire il codice o semplicemente rendere il codice meno leggibile.
- NOTA: la rinominazione delle variabili non è completamente funzionale dalla versione 1.1.1; si sta lavorando al pieno supporto poiché alcuni casi non sono ancora coperti. È comunque possibile utilizzare lo strumento e correggere i relativi errori del compilatore.

## Installazione

Aggiungi `cryptify` al tuo `Cargo.toml` come dipendenza:

```toml
[dependencies]
cryptify = "3.2.1"
```

Per installare `rust-obfuscator`, clona il repository e costruisci lo strumento usando Cargo dalla radice:
```
cargo build --release --bin rust-obfuscator
```
Il file binario può quindi essere trovato sotto /target/release, puoi copiarlo nella radice del progetto come segue
```
cp ./target/release/rust-obfuscator .
```

# Utilizzo
Imposta la variabile ambiente **CRYPTIFY_KEY** per una crittografia personalizzata, altrimenti viene utilizzata la chiave fissa predefinita
- Aggiungi al codice sorgente che desideri modificare
```rs
use cryptify;
```
Il file binario può essere utilizzato sia su un file che su una directory. Se viene fornita una directory, modificherà solo i file sorgente Rust all'interno di quella directory, non nelle sottodirectory.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Tutto il codice offuscato sarà contenuto nella directory **obfuscated_code** che viene creata dalla directory in cui è stato eseguito lo strumento.
- **Si consiglia di utilizzare un Formatter Rust con il codice offuscato poiché syn modifica naturalmente la struttura e verrà scritto nel file come una sola riga**

## Opzioni dei flag
- --no_string: Disabilita l'offuscamento delle stringhe.
- --no_flow: Disabilita l'offuscamento del flusso di controllo.
- --disable_macro: Utilizza la manipolazione diretta del sorgente per l'offuscamento del flusso invece delle macro procedurali.
- --var: Abilita l'offuscamento del codice sorgente tramite rinominazione delle variabili.

### Esempio di utilizzo con flag
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(disabilita l'offuscamento del flusso)

# Input
-eseguire lo strumento senza configurazione
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
# Output
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
## Output Espanso
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
# Licenza
rust-obfuscator è concesso in licenza sotto la Licenza MIT - vedere il file [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) per dettagli.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---