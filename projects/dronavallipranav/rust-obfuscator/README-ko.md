
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

`rust-obfuscator`는 Rust 소스 코드를 자동으로 난독화하기 위해 프로시저 매크로를 삽입하거나(옵션으로) 소스 코드에 직접 난독화를 제공하는 도구 모음입니다. 더욱 세밀한 난독화를 원할 경우 프로시저 매크로 라이브러리 [cryptify](https://crates.io/crates/cryptify)도 함께 제공합니다.

## 현재 지원 사항
1. 문자열 리터럴 암호화
2. 제어 흐름 난독화
3. 제어 흐름 난독화(소스 코드)
4. 변수 이름 변경 (소스 코드)

## 기능

- **문자열 암호화**: 컴파일 시 로컬 변수에 할당된 문자열 리터럴을 자동으로 암호화합니다.
    - 서식 문자열에도 사용할 수 있지만, 현재는 수동으로 위치를 지정해야 합니다.
    ```rs
        println!("{}", cryptify::encrypt_string!("hello!"));
    ```
- **제어 흐름 난독화**: 컴파일 시 더미 루프와 무작위 변수를 도입합니다.  
- **사용자 정의 가능한 난독화**: 요구 사항에 따라 특정 난독화 기능을 활성화하거나 비활성화할 수 있는 유연성을 제공합니다.  
- **변수 이름 변경**: 코드를 배포하거나 코드를 더 복잡하게 보이게 하고 싶을 때 소스 코드를 직접 난독화합니다.  
- NOTE: 1.1.1 버전 기준으로 변수 이름 변경은 완전히 작동하지 않으며 일부 경우가 아직 지원되지 않아 완전 지원을 위해 작업 중입니다. 그래도 도구를 사용하고 적절한 컴파일러 오류를 수정할 수 있습니다.  

## 설치  

`Cargo.toml`에 `cryptify`를 의존성으로 추가하세요:

```toml
[dependencies]
cryptify = "3.2.1"
```

`rust-obfuscator`를 설치하려면, 저장소를 클론하고 루트에서 Cargo를 사용하여 도구를 빌드하세요:
```
cargo build --release --bin rust-obfuscator
```
바이너리는 /target/release에서 찾을 수 있으며, 다음과 같이 프로젝트 루트로 복사할 수 있습니다
```
cp ./target/release/rust-obfuscator .
```

# 사용법
사용자 지정 암호화를 위해 **CRYPTIFY_KEY** 환경 변수를 설정하지 않으면 기본으로 정의된 고정 키가 사용됩니다.
- 수정하려는 소스 코드에 추가하세요
```rs
use cryptify;
```
바이너리는 파일이나 디렉터리 모두에서 사용할 수 있습니다. 디렉터리가 제공되면 해당 디렉터리 내의 러스트 소스 파일만 수정하며 하위 디렉터리는 수정하지 않습니다.
```sh
./rust-obfuscator path/to/your_project <Options>
```
- 모든 난독화된 코드는 도구가 실행된 디렉토리에서 생성된 **obfuscated_code** 디렉토리 아래에 위치합니다.  
- **syn이 구조를 자연스럽게 변경하고 한 줄로 파일에 작성되므로 난독화된 코드에는 Rust 포매터 사용을 권장합니다**  

## 옵션 플래그  
- --no_string: 문자열 난독화를 비활성화합니다.  
- --no_flow: 제어 흐름 난독화를 비활성화합니다.  
- --disable_macro: 프로시저 매크로 대신 직접 소스 조작을 사용하여 흐름 난독화를 수행합니다.  
- --var: 변수 이름 변경 소스 코드 난독화를 활성화합니다.  

### 플래그를 사용한 예시
```sh
rust-obfuscator path/to/your_project --no_flow 
```
(흐름 난독화를 비활성화)

# 입력
-구성 없이 도구 실행
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
# 출력
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
## 확장 출력
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
# 라이선스
rust-obfuscator는 MIT 라이선스하에 라이선스가 부여됩니다 - 자세한 내용은 [LICENSE](https://github.com/dronavallipranav/rust-obfuscator/blob/main/LICENSE) 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---