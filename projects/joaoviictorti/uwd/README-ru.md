# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` — это библиотека Rust для подделки стека вызовов в Windows, позволяющая выполнять произвольные функции с поддельным стеком вызовов, который ускользает от анализа, логирования или обнаружения при раскрутке стека.

Вдохновлённая проектом [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), эта библиотека переносит низкоуровневые возможности подделки стека в чистый, идиоматичный интерфейс Rust с полной поддержкой `#[no_std]`, тулчейнов `MSVC` и `GNU`, а также автоматическим определением гаджетов.

## Возможности

- ✅ Подделка стека вызовов через `Synthetic` и `Desync`.
- ✅ Совместимость с тулчейнами `MSVC` и `GNU` (**x64**).
- ✅ Встроенные макросы: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Поддержка окружений `#[no_std]` (с `alloc`).

## Начало работы

Добавьте `uwd` в ваш проект, обновив ваш `Cargo.toml`:
```bash
cargo add uwd
```

## Использование

`uwd` позволяет подделывать стек вызовов в Rust при вызове как стандартных Windows API, так и при выполнении косвенных системных вызовов. Библиотека полностью берёт на себя настройку поддельных фреймов, цепочек гаджетов и подготовку регистров, чтобы выполнение выглядело так, будто оно происходит из легитимного источника.

Вы можете подделывать:

* Обычные функции (например, `VirtualAlloc`, `WinExec` и др.)
* Нативные системные вызовы с автоматическим определением SSN и stub (например, `NtAllocateVirtualMemory`)

Макросы `spoof!` / `spoof_synthetic!` и `syscall!` / `syscall_synthetic!` абстрагируют всю сложность.

### Подделка WinExec

В этом примере показано, как запустить `calc.exe`, используя поддельный стек вызовов. Мы вызываем `WinExec` дважды: сначала с использованием техники Desync, затем — Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Разрешаем адреса функций WinAPI, которые будут использоваться
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Выполняем команду с помощью `WinExec`
    // Подделка стека вызовов (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed");
        return Ok(());
    }

    // Подделка стека вызовов (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed [2]");
        return Ok(());
    }

    Ok(())
}
```

### Подделка косвенного системного вызова

В этом примере выполняется косвенный системный вызов к `NtAllocateVirtualMemory` с поддельным стеком вызовов.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Выполнение косвенного системного вызова с подделкой стека вызовов (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Address allocated: {:?}", addr);

    // Выполнение косвенного системного вызова с подделкой стека вызовов (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Адрес выделен: {:?}", addr);

Ok(())
}
```

## Дополнительные ресурсы

Для получения дополнительных примеров ознакомьтесь с папкой [examples](/examples) в репозитории.

## Ссылки

Хочу выразить благодарность следующим проектам, которые вдохновили меня на создание `uwd` и послужили источником идей для некоторых функций:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Особая благодарность:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Лицензия

Этот проект лицензирован по лицензии MIT. Подробности смотрите в файле [LICENSE](/LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---