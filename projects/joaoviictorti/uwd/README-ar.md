# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` هي مكتبة Rust لتزوير مكدس الاستدعاء على نظام Windows، مما يسمح لك بتنفيذ دوال عشوائية بمكدس استدعاء مزور يتجنب التحليل أو التسجيل أو الاكتشاف أثناء عملية فك المكدس.

مستوحاة من [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)، تقدم هذه الحزمة قدرات تزوير منخفضة المستوى ضمن واجهة Rust نظيفة وأنيقة مع دعم كامل لـ `#[no_std]`، وسلاسل أدوات `MSVC` و `GNU`، وحل تلقائي للأدوات البرمجية (gadgets).

## الميزات

- ✅ تزوير مكدس الاستدعاء عبر `Synthetic` و `Desync`.
- ✅ متوافقة مع كل من سلاسل الأدوات `MSVC` و `GNU` (**x64**).
- ✅ ماكروز مضمنة: `spoof!`، `spoof_synthetic!`، `syscall!`، `syscall_synthetic!`.
- ✅ تدعم بيئات `#[no_std]` (مع `alloc`).

## البدء

أضف `uwd` إلى مشروعك من خلال تحديث ملف `Cargo.toml`:
```bash
cargo add uwd
```

## الاستخدام

تتيح لك مكتبة `uwd` تزوير مكدس الاستدعاء في Rust عند استدعاء واجهات برمجة تطبيقات Windows القياسية أو عند تنفيذ system calls غير مباشرة. تتولى المكتبة إعداد كافة الإطارات المزيفة، وسلاسل الأدوات البرمجية (gadget chains)، وتجهيز المسجلات لجعل التنفيذ يبدو وكأنه جاء من مصدر شرعي.

يمكنك تزوير استدعاء:

* الدوال العادية (مثل `VirtualAlloc`، `WinExec`، إلخ)
* نداءات النظام الأصلية مع حل تلقائي لـ SSN و stub (مثل `NtAllocateVirtualMemory`)

تقوم الماكروز `spoof!` / `spoof_synthetic!` و `syscall!` / `syscall_synthetic!` بتجريد جميع التعقيدات.

### تزوير WinExec

يوضح هذا المثال كيفية تشغيل `calc.exe` باستخدام مكدس استدعاء مزور. نستدعي الدالة `WinExec` مرتين؛ مرة باستخدام تقنية Desync، ومرة أخرى باستخدام تقنية Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // حل عناوين دوال WinAPI المطلوب استخدامها
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // تنفيذ الأمر باستخدام `WinExec`
    // تزوير مكدس الاستدعاء (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("فشل WinExec");
        return Ok(());
    }

    // تزوير مكدس الاستدعاء (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("فشل WinExec [2]");
        return Ok(());
    }

    Ok(())
}
```

### تزوير نداء نظام غير مباشر

يوضح هذا المثال تنفيذ نداء نظام غير مباشر إلى `NtAllocateVirtualMemory` مع مكدس استدعاء مزور.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // تنفيذ نداء نظام غير مباشر مع تزوير مكدس الاستدعاء (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("فشل NtAllocateVirtualMemory مع الحالة: {status:#X}");
        return Ok(())
    }

    println!("[+] تم تخصيص العنوان: {:?}", addr);

    // تنفيذ نداء نظام غير مباشر مع تزوير مكدس الاستدعاء (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("فشل NtAllocateVirtualMemory مع الحالة [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Address allocated: {:?}", addr);

Ok(())
}
```

## موارد إضافية

لمزيد من الأمثلة، راجع مجلد [examples](/examples) في المستودع.

## المراجع

أود أن أعبر عن امتناني لهذه المشاريع التي ألهمتني لإنشاء `uwd` والمساهمة ببعض الميزات:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

شكر خاص لـ:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## الرخصة

هذا المشروع مرخص تحت رخصة MIT. راجع ملف [LICENSE](/LICENSE) لمزيد من التفاصيل.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---