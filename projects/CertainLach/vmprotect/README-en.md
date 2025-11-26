# vmprotect ![crates.io](https://img.shields.io/crates/v/vmprotect.svg)

WIP VMProtect SDK for rust

## Basic VMProtect features

### `protected` attribute

You need to add [this script](https://raw.githubusercontent.com/CertainLach/vmprotect/master/./script.lua) to vmprotect project for this attribute

Syntax:

```rust
#[protected(TYPE[, lock])]
fn some_fn() { ... }
```

- TYPE: Protection type
- [, lock]: Requires a license for this function to work.

Example:

```rust
#[protected(virtualize)]
fn stringify<T: Display>(value: T) -> String {
    format!("{}", value)
}
```

### `protected!` macro for code

Syntax:

```rust
use vmprotect::protected;

protected!(TYPE[, lock] "NAME"; { /*CODE*/ })
```
- NAME: Which name will be displayed in VMProtect GUI  
- TYPE: Protection type (mutate/virtualize/ultra per VMProtect docs)  
- [, lock]: For virtualize/ultra only, require license activation to get this function to work  
- CODE: Your code goes here  

Protected code block works like any other rust block, i.e:


```rust
use vmprotect::protected;

// Before protection
let a = {2+3};
// After protection
let a = protected!(virtualize "Addiction"; { 2 + 3 });
```
Example:


```rust
fn main() {
    println!("{} + {} = {}", a, b, protected!(ultra "Adding"; {
        a + b
    }));
}
```

### `protected!` macro for texts

Syntax:

```rust
use vmprotect::protected;

protected!(TYPE "TEXT")
```

- TYPE: Text type, possible values: cstr (for normal c strings)/cwstr (for uint16_t c strings (Used i.e in windows))
- TEXT: Your text, should be supported by your selected text type

This macro returns a string, which can be transformed into a normal one. This string is freed when dropped, implementation is located at `vmprotect::strings::{encrypted_a::EncryptedStringA, encrypted_w::EncryptedStringW}`

```rust
use vmprotect::protected;

// Before protection
let a = "Hello, world!";
// After protection
let a = protected!(cstr "Hello, world!");
// Also for wide-strings:
let a = protected!(cwstr "Привет, мир!");
```

Example:

```rust
use vmprotect::protected;

fn main() {
    println!("Hello, {:?}!", protected!(A; "%Username%").into() as String);
}
```

## Licensing

TODO Section, see docs for now

### HWID

Example:

```rust
println!("Your hwid is \"{}\"", vmprotect::licensing::get_hwid().to_str().unwrap());
```

## Known problems

### MacOS: Not enough space for the new segment in the file header

Can be fixed by adding `-C link-arg=-Wl,-headerpad,0x500` to rustc args

For cargo:

```rs
export RUSTFLAGS="-C link-arg=-Wl,-headerpad,0x500"
```

(Based on <http://vmpsoft.com/forum/viewtopic.php?f=2&t=6837&start=15#p10527>)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-26

---