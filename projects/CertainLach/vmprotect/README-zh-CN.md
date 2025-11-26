# vmprotect ![crates.io](https://img.shields.io/crates/v/vmprotect.svg)

Rust 的 VMProtect SDK 开发中

## 基本的 VMProtect 功能

### `protected` 属性

您需要将[此脚本](https://raw.githubusercontent.com/CertainLach/vmprotect/master/./script.lua)添加到 vmprotect 项目中以使用此属性

语法：

```rust
#[protected(TYPE[, lock])]
fn some_fn() { ... }
```

- 类型：保护类型
- [, 锁定]：需要许可证才能使此功能正常工作。

示例：

```rust
#[protected(virtualize)]
fn stringify<T: Display>(value: T) -> String {
    format!("{}", value)
}
```

### 用于代码的 `protected!` 宏

语法：

```rust
use vmprotect::protected;

protected!(TYPE[, lock] "NAME"; { /*CODE*/ })
```
- NAME: 在 VMProtect 界面中显示的名称
- TYPE: 保护类型（根据 VMProtect 文档，mutate/virtualize/ultra）
- [, lock]: 仅适用于 virtualize/ultra，需要激活许可才能使用此功能
- CODE: 你的代码写在这里

受保护的代码块工作方式与其他 Rust 代码块相同，即：


```rust
use vmprotect::protected;

// Before protection
let a = {2+3};
// After protection
let a = protected!(virtualize "Addiction"; { 2 + 3 });
```
示例：


```rust
fn main() {
    println!("{} + {} = {}", a, b, protected!(ultra "Adding"; {
        a + b
    }));
}
```

### 文本的 `protected!` 宏

语法：

```rust
use vmprotect::protected;

protected!(TYPE "TEXT")
```
- TYPE: 文本类型，可能的值：cstr（普通 C 字符串）/cwstr（uint16_t C 字符串（用于例如 Windows））
- TEXT: 您的文本，应支持所选的文本类型

该宏返回字符串，可转换为普通字符串。该字符串在释放时被释放，具体实现位于 `vmprotect::strings::{encrypted_a::EncryptedStringA, encrypted_w::EncryptedStringW}`


```rust
use vmprotect::protected;

// Before protection
let a = "Hello, world!";
// After protection
let a = protected!(cstr "Hello, world!");
// Also for wide-strings:
let a = protected!(cwstr "Привет, мир!");
```
例子：


```rust
use vmprotect::protected;

fn main() {
    println!("Hello, {:?}!", protected!(A; "%Username%").into() as String);
}
```

## 许可

待办部分，暂时请参见文档

### 硬件ID

示例：

```rust
println!("Your hwid is \"{}\"", vmprotect::licensing::get_hwid().to_str().unwrap());
```

## 已知问题

### MacOS：文件头中新段空间不足

可以通过向 rustc 参数添加 `-C link-arg=-Wl,-headerpad,0x500` 解决

对于 cargo：

```rs
export RUSTFLAGS="-C link-arg=-Wl,-headerpad,0x500"
```

（基于 <http://vmpsoft.com/forum/viewtopic.php?f=2&t=6837&start=15#p10527>）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-26

---