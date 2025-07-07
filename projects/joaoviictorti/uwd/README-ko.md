# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd`는 Windows에서 호출 스택 위조(Call Stack Spoofing)를 위한 Rust 라이브러리로, 스택 언와인딩(Unwinding) 중 분석, 로깅 또는 탐지를 회피하며 임의의 함수를 위조된 호출 스택으로 실행할 수 있게 해줍니다.

[SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)에서 영감을 받아, 이 크레이트는 저수준 위조 기능을 깔끔하고 직관적인 Rust 인터페이스로 제공하며, `#[no_std]`, `MSVC` 및 `GNU` 툴체인, 자동 가젯 해상도를 완벽하게 지원합니다.

## 특징

- ✅ `Synthetic` 및 `Desync`를 통한 호출 스택 위조
- ✅ `MSVC`와 `GNU` 툴체인(**x64**) 모두와 호환
- ✅ 인라인 매크로: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`
- ✅ `#[no_std]` 환경 지원(`alloc` 필요)

## 시작하기

`Cargo.toml`을 다음과 같이 수정하여 `uwd`를 프로젝트에 추가하세요:
```bash
cargo add uwd
```

## 사용법

`uwd`를 사용하면 표준 Windows API 호출 또는 간접 시스템 콜을 수행할 때 Rust에서 호출 스택을 위조할 수 있습니다. 이 라이브러리는 위조된 프레임, 가젯 체인, 레지스터 준비 등 전체 과정을 처리하여 실행이 합법적인 소스에서 발생한 것처럼 보이도록 만듭니다.

다음과 같이 위조할 수 있습니다:

* 일반 함수(예: `VirtualAlloc`, `WinExec` 등)
* 자동 SSN 및 스텁 해상도를 사용하는 네이티브 시스템 콜(예: `NtAllocateVirtualMemory`)

매크로 `spoof!` / `spoof_synthetic!`, `syscall!` / `syscall_synthetic!`는 모든 복잡성을 추상화합니다.

### WinExec 스택 위조

이 예제는 위조된 호출 스택을 사용하여 `calc.exe`를 실행하는 방법을 보여줍니다. `WinExec`를 두 번 호출하며, 한 번은 Desync 기법, 한 번은 Synthetic 기법을 사용합니다.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // 사용할 WinAPI 함수 주소를 해상
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // `WinExec`로 명령 실행
    // 호출 스택 위조 (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec 실패");
        return Ok(());
    }

    // 호출 스택 위조 (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec 실패 [2]");
        return Ok(());
    }

    Ok(())
}
```

### 간접 시스템 콜 스택 위조

이 예제는 위조된 호출 스택으로 `NtAllocateVirtualMemory` 간접 시스템 콜을 수행합니다.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // 호출 스택 위조(Desync)로 간접 시스템 콜 실행
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory 실패, 상태: {status:#X}");
        return Ok(())
    }

    println!("[+] 할당된 주소: {:?}", addr);

    // 호출 스택 위조(Synthetic)로 간접 시스템 콜 실행
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory 실패 [2], 상태: {status:#X}");
        return Ok(())
```
}

println!("[+] Address allocated: {:?}", addr);

Ok(())
}
```

## 추가 자료

더 많은 예시를 보려면, 저장소의 [examples](/examples) 폴더를 참고하세요.

## 참고문헌

`uwd`를 만들고 몇 가지 기능을 기여하도록 영감을 준 다음 프로젝트에 감사를 표합니다:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

특별 감사:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE](/LICENSE) 파일을 참고하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---