
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

`rust-obfuscator`, Rust kaynak kodunu otomatik olarak karmaşıklaştırmak için prosedürel makrolar ekleyerek veya (isteğe bağlı olarak) karmaşıklaştırmayı doğrudan kaynak kodunda sağlayarak tasarlanmış bir dizi araçtır. Daha ayrıntılı bir karmaşıklaştırma için [cryptify](https://crates.io/crates/cryptify) adlı prosedürel makro kütüphanesi de sunulmaktadır.

## Şu Anda Desteklenenler
1. string sabitlerinin şifrelenmesi
2. kontrol akışı karmaşıklaştırması
3. kontrol akışı karmaşıklaştırması (kaynak kod)
4. değişken yeniden adlandırma (kaynak kodu)

## Özellikler

- **Dize Şifreleme**: Yerel değişkenlere atanan dize sabitlerini derleme zamanında otomatik olarak şifreler.
    - Biçimlendirilmiş dizeler için de kullanılabilir, ancak şu anda elle yerleştirme gerektirir
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Kontrol Akışı Obfuskasyonu**: Derleme sırasında sahte döngüler ve rastgele değişkenler ekler.
- **Özelleştirilebilir Obfuskasyon**: Gereksinimlerinize göre belirli obfuskasyon özelliklerini etkinleştirip devre dışı bırakma esnekliği sunar.
- **Değişken Yeniden Adlandırma**: Kaynak kodunuzu doğrudan obfuske eder, kodu dağıtmak veya sadece kodunuzu daha karmaşık göstermek isterseniz kullanılabilir.
- NOT: Değişken yeniden adlandırma 1.1.1 itibariyle tam olarak işlevsel değildir, tüm durumlar henüz kapsanmadığı için tam destek üzerinde çalışılmaktadır. Yine de aracı kullanabilir ve ilgili derleyici hatalarını düzeltebilirsiniz.

## Kurulum

`cryptify` paketini bağımlılık olarak `Cargo.toml` dosyanıza ekleyin:

```toml
[dependencies]
cryptify = "3.2.1"
```

`rust-obfuscator`'ı yüklemek için, depoyu klonlayın ve aracı kök dizinden Cargo ile derleyin:
```
cargo build --release --bin rust-obfuscator
```
İkili dosya daha sonra /target/release altında bulunabilir, bunu aşağıdaki gibi projenin kök dizinine kopyalayabilirsiniz.
```
cp ./target/release/rust-obfuscator .
```

# Kullanım
Özel şifreleme için **CRYPTIFY_KEY** ortam değişkenini ayarlayın, aksi halde tanımlı sabit anahtara varsayılır
- Değiştirmek istediğiniz kaynak koda ekleyin
```rs
use cryptify;
```
İkili dosya hem bir dosya hem de bir dizin üzerinde kullanılabilir. Bir dizin verildiğinde, yalnızca o dizindeki rust kaynak dosyalarını değiştirir, alt dizinlerdeki dosyaları değiştirmez.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Tüm Gizlenmiş kod, aracın çalıştırıldığı dizinden oluşturulan **obfuscated_code** dizini altında olacaktır.
- **Gizlenmiş kod ile birlikte bir Rust Biçimlendirici kullanılması önerilir, çünkü syn doğal olarak yapıyı değiştirir ve dosyaya tek satır olarak yazacaktır**

## Seçenek Bayrakları
- --no_string: Dize gizlemeyi devre dışı bırakır.
- --no_flow: Kontrol akışı gizlemeyi devre dışı bırakır.
- --disable_macro: Kontrol akışı gizlemesi için prosedürel makrolar yerine doğrudan kaynak manipülasyonu kullanır.
- --var: Değişken yeniden adlandırma kaynak kodu gizlemeyi etkinleştirir.

### Bayrak ile örnek kullanım
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(akış gizlemeyi devre dışı bırakır)

# Girdi
-aracı herhangi bir yapılandırma olmadan çalıştırmak
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
# Çıktı
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
## Genişletilmiş Çıktı
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
# Lisans
rust-obfuscator MIT Lisansı altında lisanslanmıştır - ayrıntılar için [LİSANS](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) dosyasına bakınız.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---