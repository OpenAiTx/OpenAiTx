
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

`rust-obfuscator`は、Rustのソースコードを自動的に難読化するために設計されたツールセットであり、手続き的マクロの挿入や（オプションで）ソースコード上で直接難読化を提供します。より細やかな難読化のために、手続き的マクロライブラリ [cryptify](https://crates.io/crates/cryptify) も提供されています。

## 現在サポートされている機能
1. 文字列リテラルの暗号化
2. 制御フロー難読化
3. 制御フロー難読化（ソースコード）
4. 変数名の変更（ソースコード）

## 機能

- **文字列暗号化**: ローカル変数に代入される文字列リテラルをコンパイル時に自動で暗号化します。
    - フォーマット済み文字列にも使用可能ですが、現時点では手動で配置する必要があります
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **制御フロー難読化**: ダミーループやランダム変数をコンパイル時に導入します。  
- **カスタマイズ可能な難読化**: 要件に応じて特定の難読化機能を有効または無効にする柔軟性を提供します。  
- **変数名のリネーム**: ソースコードを直接難読化し、コードを配布したり見た目を悪くしたりしたい場合に使用します。  
- 注意: 変数名リネームはバージョン1.1.1時点で完全には機能しておらず、一部のケースはまだ対応していません。ツールは使用可能で、適切なコンパイラエラーを修正しながら使用してください。  

## インストール  

`Cargo.toml`に`cryptify`を依存関係として追加してください:

```toml
[dependencies]
cryptify = "3.2.1"
```

`rust-obfuscator`をインストールするには、リポジトリをクローンし、ルートからCargoを使ってツールをビルドしてください：
```
cargo build --release --bin rust-obfuscator
```
バイナリは /target/release にありますので、プロジェクトのルートに以下のようにコピーできます
```
cp ./target/release/rust-obfuscator .
```

# 使用方法
カスタム暗号化のために**CRYPTIFY_KEY**環境変数を設定します。設定しない場合は定義された固定キーがデフォルトで使用されます。
- 変更したいソースコードに追加してください
```rs
use cryptify;
```
バイナリはファイルまたはディレクトリのいずれかで使用できます。ディレクトリが指定された場合、そのディレクトリ内のサブディレクトリではなく、Rustのソースファイルのみを修正します。
```sh
./rust-obfuscator path/to/your_project <Options>
```
- すべての難読化されたコードは、ツールが実行されたディレクトリから作成された **obfuscated_code** ディレクトリ内に配置されます。
- **syn は構造を自然に変更し、ファイルには1行で書き込まれるため、難読化コードには Rust フォーマッタの使用を推奨します。**

## オプションフラグ
- --no_string: 文字列難読化を無効化します。
- --no_flow: 制御フロー難読化を無効化します。
- --disable_macro: 手続き型マクロの代わりに直接ソース操作を使用してフロー難読化を行います。
- --var: 変数名のリネームによるソースコード難読化を有効にします。

### フラグを使用した使用例
```sh
rust-obfuscator path/to/your_project --no_flow 
```
（フロー難読化を無効にする）

# 入力
- 設定なしでツールを実行する
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
# 出力
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
## 拡張出力
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
# ライセンス
rust-obfuscatorはMITライセンスの下でライセンスされています - 詳細は[LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE)ファイルをご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---