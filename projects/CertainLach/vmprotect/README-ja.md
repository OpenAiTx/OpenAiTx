# vmprotect ![crates.io](https://img.shields.io/crates/v/vmprotect.svg)

Rust向けの作業中のVMProtect SDK

## 基本的なVMProtect機能

### `protected` 属性

この属性を使用するには、vmprotectプロジェクトに[このスクリプト](https://raw.githubusercontent.com/CertainLach/vmprotect/master/./script.lua)を追加する必要があります

構文:

```rust
#[protected(TYPE[, lock])]
fn some_fn() { ... }
```
- 種類: 保護タイプ
- [, ロック]: この機能を利用するにはライセンスが必要です。

例:


```rust
#[protected(virtualize)]
fn stringify<T: Display>(value: T) -> String {
    format!("{}", value)
}
```

### コード用 `protected!` マクロ

構文:

```rust
use vmprotect::protected;

protected!(TYPE[, lock] "NAME"; { /*CODE*/ })
```

- NAME: VMProtect GUIに表示される名前
- TYPE: 保護タイプ（VMProtectのドキュメントに従いmutate/virtualize/ultra）
- [, lock]: virtualize/ultra専用、この機能を有効にするにはライセンス認証が必要
- CODE: ここにコードを記述

保護されたコードブロックは他のRustブロックと同様に動作します、すなわち：

```rust
use vmprotect::protected;

// Before protection
let a = {2+3};
// After protection
let a = protected!(virtualize "Addiction"; { 2 + 3 });
```
例:


```rust
fn main() {
    println!("{} + {} = {}", a, b, protected!(ultra "Adding"; {
        a + b
    }));
}
```

### テキスト用の `protected!` マクロ

構文:

```rust
use vmprotect::protected;

protected!(TYPE "TEXT")
```
- TYPE: テキストタイプ、可能な値: cstr（通常のC文字列用）/cwstr（uint16_tのC文字列用（Windowsなどで使用））
- TEXT: あなたのテキスト、選択したテキストタイプでサポートされている必要があります

このマクロは文字列を返し、通常の文字列に変換可能です。この文字列は破棄時に解放され、実装は `vmprotect::strings::{encrypted_a::EncryptedStringA, encrypted_w::EncryptedStringW}` にあります。


```rust
use vmprotect::protected;

// Before protection
let a = "Hello, world!";
// After protection
let a = protected!(cstr "Hello, world!");
// Also for wide-strings:
let a = protected!(cwstr "Привет, мир!");
```

例：

```rust
use vmprotect::protected;

fn main() {
    println!("Hello, {:?}!", protected!(A; "%Username%").into() as String);
}
```

## ライセンス

TODO セクション、現在はドキュメントを参照してください

### HWID

例:

```rust
println!("Your hwid is \"{}\"", vmprotect::licensing::get_hwid().to_str().unwrap());
```

## 既知の問題

### MacOS: ファイルヘッダーの新しいセグメントのスペース不足

rustcの引数に`-C link-arg=-Wl,-headerpad,0x500`を追加することで修正可能

cargoの場合:

```rs
export RUSTFLAGS="-C link-arg=-Wl,-headerpad,0x500"
```

(<http://vmpsoft.com/forum/viewtopic.php?f=2&t=6837&start=15#p10527> に基づく)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-26

---