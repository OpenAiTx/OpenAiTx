
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

`rust-obfuscator` adalah seperangkat alat yang dirancang untuk secara otomatis mengobfusikasi kode sumber Rust dengan menyisipkan procedural macro atau (opsional) menyediakan obfusikasi langsung dalam kode sumber. Untuk obfusikasi yang lebih terperinci, juga disediakan pustaka procedural macro [cryptify](https://crates.io/crates/cryptify).

## Saat Ini Didukung
1. enkripsi literal string
2. obfusikasi alur kontrol
3. obfusikasi alur kontrol (kode sumber)
4. penggantian nama variabel (kode sumber)

## Fitur

- **Enkripsi String**: Secara otomatis mengenkripsi literal string yang diberikan ke variabel lokal pada saat kompilasi.
    - Dapat juga digunakan untuk string yang diformat, namun saat ini memerlukan penempatan manual
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **Obfuscasi Alur Kontrol**: Memperkenalkan loop dummy kompilasi dan variabel acak.
- **Obfuscasi yang Dapat Disesuaikan**: Menawarkan fleksibilitas untuk mengaktifkan atau menonaktifkan fitur obfuscasi tertentu sesuai kebutuhan Anda.
- **Penggantian Nama Variabel**: Obfuscasi kode sumber secara langsung, jika Anda ingin mendistribusikan kode atau hanya ingin membuat kode Anda terlihat lebih buruk.
- CATATAN: penggantian nama variabel belum sepenuhnya berfungsi pada versi 1.1.1, sedang dalam pengembangan untuk dukungan penuh karena beberapa kasus belum tercakup. Anda masih bisa menggunakan alat ini dan memperbaiki kesalahan kompilator yang sesuai.

## Instalasi

Tambahkan `cryptify` ke dalam `Cargo.toml` Anda sebagai dependensi:

```toml
[dependencies]
cryptify = "3.2.1"
```

Untuk menginstal `rust-obfuscator`, klon repositori dan bangun alat menggunakan Cargo dari direktori root:
```
cargo build --release --bin rust-obfuscator
```
File binary kemudian dapat ditemukan di bawah /target/release, Anda dapat menyalinnya ke root proyek seperti ini
```
cp ./target/release/rust-obfuscator .
```

# Penggunaan
Setel variabel lingkungan **CRYPTIFY_KEY** untuk enkripsi kustom, jika tidak maka akan menggunakan kunci tetap yang telah ditentukan
- Tambahkan ke kode sumber yang ingin Anda modifikasi
```rs
use cryptify;
```
Biner dapat digunakan pada berkas atau direktori. Jika diberikan direktori, biner hanya akan memodifikasi berkas sumber rust dalam direktori tersebut, bukan subdirektori mana pun.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- Semua kode yang telah diobfusikasi akan berada di direktori **obfuscated_code** yang dibuat dari direktori tempat alat dijalankan.
- **Direkomendasikan menggunakan Rust Formatter dengan kode obfusikasi karena syn secara alami memodifikasi struktur dan akan ditulis ke file sebagai satu baris**

## Opsi Flag
- --no_string: Menonaktifkan obfusikasi string.
- --no_flow: Menonaktifkan obfusikasi alur kontrol.
- --disable_macro: Menggunakan manipulasi sumber langsung untuk obfusikasi alur daripada procedural macro.
- --var: Mengaktifkan obfusikasi penggantian nama variabel pada kode sumber.

### Contoh penggunaan dengan flag
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(menonaktifkan obfuscasi alur)

# Input
-menjalankan alat tanpa konfigurasi
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
# Keluaran
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
## Output yang Diperluas
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
# Lisensi
rust-obfuscator dilisensikan di bawah Lisensi MIT - lihat file [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) untuk detailnya.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---