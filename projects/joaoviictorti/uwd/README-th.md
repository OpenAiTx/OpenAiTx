# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` เป็นไลบรารี Rust สำหรับการปลอมแปลง call stack บน Windows ซึ่งช่วยให้คุณสามารถเรียกใช้ฟังก์ชันใดๆ ก็ได้โดยมี call stack ที่ถูกสร้างขึ้นใหม่เพื่อหลบเลี่ยงการวิเคราะห์ การบันทึก หรือการตรวจจับระหว่างการ stack unwinding

ได้รับแรงบันดาลใจจาก [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk) crate นี้นำความสามารถในการปลอมแปลงระดับล่างเข้าสู่อินเทอร์เฟซ Rust ที่สะอาดและเป็นไปตามหลัก idiomatic พร้อมรองรับ `#[no_std]`, toolchain `MSVC` และ `GNU` อย่างเต็มรูปแบบ รวมถึงการแก้ไข gadget อัตโนมัติ

## คุณสมบัติ

- ✅ ปลอมแปลง call stack ผ่าน `Synthetic` และ `Desync`
- ✅ ใช้งานร่วมกับ toolchain ทั้ง `MSVC` และ `GNU` (**x64**)
- ✅ มี Inline macro: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`
- ✅ รองรับสภาพแวดล้อม `#[no_std]` (เมื่อใช้ `alloc`)

## เริ่มต้นใช้งาน

เพิ่ม `uwd` ในโปรเจกต์ของคุณโดยแก้ไขไฟล์ `Cargo.toml`:
```bash
cargo add uwd
```

## วิธีใช้งาน

`uwd` ช่วยให้คุณปลอมแปลง call stack ใน Rust เมื่อต้องเรียกใช้ Windows API มาตรฐาน หรือการ syscall ทางอ้อม ไลบรารีนี้จะจัดการสร้าง fake frame, สร้าง gadget chain และเตรียม register ให้ทั้งหมด เพื่อให้การรันดูเหมือนว่ามาจากแหล่งที่ถูกต้อง

คุณสามารถปลอมแปลงได้กับ:

* ฟังก์ชันปกติ (เช่น `VirtualAlloc`, `WinExec` เป็นต้น)
* Native syscall พร้อมการแก้ไข SSN และ stub อัตโนมัติ (เช่น `NtAllocateVirtualMemory`)

Macro `spoof!` / `spoof_synthetic!` และ `syscall!` / `syscall_synthetic!` จะช่วยจัดการความซับซ้อนทั้งหมด

### ตัวอย่างปลอมแปลง WinExec

ตัวอย่างนี้จะแสดงการรัน `calc.exe` ด้วย call stack ที่ถูกปลอมแปลง โดยเรียกใช้ `WinExec` สองครั้ง ครั้งแรกด้วยเทคนิค Desync และอีกครั้งด้วย Synthetic

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // แก้ไขที่อยู่ของฟังก์ชัน WinAPI ที่จะใช้งาน
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // รันคำสั่งด้วย `WinExec`
    // Call Stack Spoofing (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed");
        return Ok(());
    }

    // Call Stack Spoofing (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed [2]");
        return Ok(());
    }

    Ok(())
}
```

### ตัวอย่างปลอมแปลง Indirect Syscall

ตัวอย่างนี้เป็นการ syscall ทางอ้อมไปยัง `NtAllocateVirtualMemory` พร้อมกับ call stack ที่ถูกปลอมแปลง

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // รัน indirect syscall พร้อม Call Stack Spoofing (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Address allocated: {:?}", addr);

    // รัน indirect syscall พร้อม Call Stack Spoofing (Synthetic)
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

## แหล่งข้อมูลเพิ่มเติม

สำหรับตัวอย่างเพิ่มเติม โปรดดูที่โฟลเดอร์ [examples](/examples) ใน repository

## แหล่งอ้างอิง

ขอขอบคุณโปรเจกต์เหล่านี้ที่เป็นแรงบันดาลใจให้ฉันสร้าง `uwd` และมีส่วนร่วมกับฟีเจอร์บางอย่าง:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

ขอขอบคุณเป็นพิเศษสำหรับ:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## ใบอนุญาต

โปรเจกต์นี้อยู่ภายใต้สัญญาอนุญาต MIT License ดูรายละเอียดได้ที่ไฟล์ [LICENSE](/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---