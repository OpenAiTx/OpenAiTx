# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` یک کتابخانه‌ی Rust برای فریب‌دهی پشته فراخوانی در ویندوز است که به شما اجازه می‌دهد توابع دلخواه را با یک پشته فراخوانی جعلی که از تحلیل، ثبت وقایع یا شناسایی هنگام بازگشایی پشته فرار می‌کند، اجرا کنید.

الهام گرفته شده از [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)، این کرِیت قابلیت‌های فریب‌دهی سطح پایین را به یک رابط روستی تمیز و ایدیوماتیک با پشتیبانی کامل از `#[no_std]`، زنجیره ابزارهای `MSVC` و `GNU` و حل خودکار گجت ارائه می‌دهد.

## ویژگی‌ها

- ✅ فریب‌دهی پشته فراخوانی از طریق `Synthetic` و `Desync`.
- ✅ سازگار با هر دو زنجیره ابزار `MSVC` و `GNU` (**x64**).
- ✅ ماکروهای درون‌خط: `spoof!`، `spoof_synthetic!`، `syscall!`، `syscall_synthetic!`.
- ✅ پشتیبانی از محیط‌های `#[no_std]` (با `alloc`).

## شروع کار

برای افزودن `uwd` به پروژه‌ی خود، فایل `Cargo.toml` خود را به‌روزرسانی کنید:
```bash
cargo add uwd
```

## استفاده

`uwd` به شما اجازه می‌دهد هنگام فراخوانی APIهای استاندارد ویندوز یا انجام syscall غیرمستقیم، پشته فراخوانی را در Rust فریب دهید. این کتابخانه کل فرایند آماده‌سازی قاب‌های جعلی، زنجیره گجت‌ها و آماده‌سازی ثبات‌ها را مدیریت می‌کند تا اجرای کد طوری به نظر برسد که از یک منبع مشروع آمده است.

شما می‌توانید موارد زیر را فریب دهید:

* توابع معمولی (مانند `VirtualAlloc`، `WinExec` و غیره)
* syscallهای بومی با حل خودکار SSN و stub (مانند `NtAllocateVirtualMemory`)

ماکروهای `spoof!` / `spoof_synthetic!` و `syscall!` / `syscall_synthetic!` تمام پیچیدگی‌ها را انتزاع می‌کنند.

### فریب‌دهی WinExec

این مثال نشان می‌دهد چطور با یک پشته فراخوانی جعلی، `calc.exe` را اجرا کنید. ما تابع `WinExec` را دو بار، یک بار با تکنیک Desync و بار دیگر با تکنیک Synthetic فراخوانی می‌کنیم.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // آدرس توابع WinAPI مورد استفاده را حل می‌کند
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // اجرای دستور با `WinExec`
    // فریب پشته فراخوانی (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed");
        return Ok(());
    }

    // فریب پشته فراخوانی (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed [2]");
        return Ok(());
    }

    Ok(())
}
```

### فریب‌دهی یک Syscall غیرمستقیم

این مثال یک syscall غیرمستقیم به `NtAllocateVirtualMemory` را با پشته فراخوانی جعلی انجام می‌دهد.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // اجرای syscall غیرمستقیم با فریب پشته فراخوانی (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Address allocated: {:?}", addr);

    // اجرای syscall غیرمستقیم با فریب پشته فراخوانی (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Address allocated: {:?}", addr);

Ok(())
}
```

## منابع اضافی

برای مثال‌های بیشتر، پوشه [examples](/examples) را در مخزن بررسی کنید.

## منابع

مایلم از این پروژه‌ها که الهام‌بخش من برای ایجاد `uwd` بودند و با برخی قابلیت‌ها مشارکت داشتند، تشکر کنم:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

تشکر ویژه از:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## مجوز

این پروژه تحت مجوز MIT منتشر شده است. برای جزئیات بیشتر فایل [LICENSE](/LICENSE) را مشاهده کنید.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---