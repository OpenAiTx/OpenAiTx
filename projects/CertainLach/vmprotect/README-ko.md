# vmprotect ![crates.io](https://img.shields.io/crates/v/vmprotect.svg)

러스트용 WIP VMProtect SDK

## 기본 VMProtect 기능

### `protected` 속성

이 속성을 사용하려면 [이 스크립트](https://raw.githubusercontent.com/CertainLach/vmprotect/master/./script.lua)를 vmprotect 프로젝트에 추가해야 합니다

구문:

```rust
#[protected(TYPE[, lock])]
fn some_fn() { ... }
```
- TYPE: 보호 유형
- [, lock]: 이 기능을 작동시키기 위해 라이선스가 필요합니다.

예시:


```rust
#[protected(virtualize)]
fn stringify<T: Display>(value: T) -> String {
    format!("{}", value)
}
```

### 코드용 `protected!` 매크로

구문:

```rust
use vmprotect::protected;

protected!(TYPE[, lock] "NAME"; { /*CODE*/ })
```
- NAME: VMProtect GUI에 표시될 이름  
- TYPE: 보호 유형 (VMProtect 문서에 따른 mutate/virtualize/ultra)  
- [, lock]: virtualize/ultra 전용, 이 기능 작동을 위해 라이선스 활성화 필요  
- CODE: 코드가 여기에 들어갑니다  

보호된 코드 블록은 다른 러스트 블록과 동일하게 작동합니다, 즉:


```rust
use vmprotect::protected;

// Before protection
let a = {2+3};
// After protection
let a = protected!(virtualize "Addiction"; { 2 + 3 });
```
예시:


```rust
fn main() {
    println!("{} + {} = {}", a, b, protected!(ultra "Adding"; {
        a + b
    }));
}
```

### 텍스트를 위한 `protected!` 매크로

문법:

```rust
use vmprotect::protected;

protected!(TYPE "TEXT")
```

- TYPE: 텍스트 유형, 가능한 값: cstr (일반 c 문자열용)/cwstr (uint16_t c 문자열용 (예: 윈도우에서 사용))
- TEXT: 텍스트, 선택한 텍스트 유형을 지원해야 함

이 매크로는 변환 가능한 문자열을 반환합니다. 이 문자열은 해제될 때 자동으로 메모리에서 해제되며, 구현은 `vmprotect::strings::{encrypted_a::EncryptedStringA, encrypted_w::EncryptedStringW}`에 위치합니다

```rust
use vmprotect::protected;

// Before protection
let a = "Hello, world!";
// After protection
let a = protected!(cstr "Hello, world!");
// Also for wide-strings:
let a = protected!(cwstr "Привет, мир!");
```
예시:


```rust
use vmprotect::protected;

fn main() {
    println!("Hello, {:?}!", protected!(A; "%Username%").into() as String);
}
```

## 라이선스

TODO 섹션, 현재는 문서를 참조하세요

### HWID

예시:

```rust
println!("Your hwid is \"{}\"", vmprotect::licensing::get_hwid().to_str().unwrap());
```

## 알려진 문제

### MacOS: 파일 헤더의 새 세그먼트에 공간 부족

rustc 인자에 `-C link-arg=-Wl,-headerpad,0x500`를 추가하여 해결할 수 있음

cargo의 경우:

```rs
export RUSTFLAGS="-C link-arg=-Wl,-headerpad,0x500"
```

(<http://vmpsoft.com/forum/viewtopic.php?f=2&t=6837&start=15#p10527>를 기반으로)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-26

---