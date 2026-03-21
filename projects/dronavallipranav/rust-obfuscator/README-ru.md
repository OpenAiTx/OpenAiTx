
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

`rust-obfuscator` — это набор инструментов, предназначенных для автоматической обфускации исходного кода Rust путем внедрения процедурных макросов или (по желанию) предоставления обфускации непосредственно в исходном коде. Для более детальной обфускации также доступна библиотека процедурных макросов [cryptify](https://crates.io/crates/cryptify).

## В настоящее время поддерживается
1. шифрование строковых литералов
2. обфускация управления потоком
3. обфускация управления потоком (исходный код)
4. переименование переменных (исходный код)

## Возможности

- **Шифрование строк**: Автоматически шифрует строковые литералы, присваиваемые локальным переменным во время компиляции.
    - Может также использоваться для форматированных строк, но в настоящее время требует ручного размещения
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Обфускация управления потоком**: Вводит фиктивные циклы компиляции и случайные переменные.
- **Настраиваемая обфускация**: Предоставляет возможность включать или отключать определённые функции обфускации в зависимости от ваших требований.
- **Переименование переменных**: Обфускация исходного кода напрямую, если вы хотите распространять код или просто сделать его менее читаемым.
- ПРИМЕЧАНИЕ: переименование переменных не полностью работает в версии 1.1.1, ведётся работа над полной поддержкой, некоторые случаи пока не охвачены. Инструмент всё равно можно использовать и исправлять соответствующие ошибки компилятора.

## Установка

Добавьте `cryptify` в ваш `Cargo.toml` как зависимость:

```toml
[dependencies]
cryptify = "3.2.1"
```

Чтобы установить `rust-obfuscator`, клонируйте репозиторий и соберите инструмент с помощью Cargo из корня:
```
cargo build --release --bin rust-obfuscator
```
Бинарный файл можно найти в /target/release, вы можете скопировать его в корневую папку проекта следующим образом
```
cp ./target/release/rust-obfuscator .
```

# Использование
Установите переменную окружения **CRYPTIFY_KEY** для пользовательского шифрования, иначе будет использоваться заданный фиксированный ключ
- Добавьте в исходный код, который хотите изменить
```rs
use cryptify;
```
Двоичный файл можно использовать как для файла, так и для каталога. Если указан каталог, он будет изменять только исходные файлы rust внутри этого каталога, но не в каких-либо подкаталогах.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Весь обфусцированный код будет находиться в директории **obfuscated_code**, которая создаётся из директории, где был запущен инструмент.
- **Рекомендуется использовать Rust Formatter с обфусцированным кодом, поскольку syn естественно изменяет структуру и код будет записан в файл одной строкой**

## Флаги опций
- --no_string: Отключает обфускацию строк.
- --no_flow: Отключает обфускацию управляющего потока.
- --disable_macro: Использует прямое изменение исходного кода для обфускации потока вместо процедурных макросов.
- --var: Включает обфускацию исходного кода путём переименования переменных.

### Пример использования с флагом
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(отключает обфускацию потока)

# Ввод
-запуск инструмента без конфигурации
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
# Вывод
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
## Расширенный вывод
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
# Лицензия
rust-obfuscator лицензирован по лицензии MIT — подробности см. в файле [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---