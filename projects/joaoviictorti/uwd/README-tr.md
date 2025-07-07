# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd`, Windows üzerinde çağrı yığını sahteciliği (call stack spoofing) için kullanılan bir Rust kütüphanesidir ve sahte bir çağrı yığını ile keyfi fonksiyonları çalıştırmanıza, analizden, kayıttan veya yığın çözme sırasında tespit edilmekten kaçınmanıza olanak tanır.

[SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)'tan esinlenen bu crate, düşük seviyeli sahtecilik yeteneklerini temiz, idiyomatik bir Rust arayüzüne taşır. `#[no_std]`, `MSVC` ve `GNU` derleyici zincirleriyle tam uyumlu olup, otomatik gadget çözümlemesi de içerir.

## Özellikler

- ✅ `Synthetic` ve `Desync` ile çağrı yığını sahteciliği.
- ✅ Hem `MSVC` hem de `GNU` derleyici zincirleriyle uyumlu (**x64**).
- ✅ Satır içi makrolar: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ `#[no_std]` ortamlarını destekler (`alloc` ile birlikte).

## Başlarken

`Cargo.toml` dosyanızı güncelleyerek projenize `uwd` ekleyin:
```bash
cargo add uwd
```

## Kullanım

`uwd`, Rust'ta standart Windows API'lerini çağırırken ya da dolaylı sistem çağrıları gerçekleştirirken çağrı yığınını sahteleyebilmenizi sağlar. Kütüphane, sahte çerçevelerin, gadget zincirlerinin ve kayıt hazırlıklarının tam kurulumunu otomatik olarak yapar ve yürütmenin yasal bir kaynaktan gelmiş gibi görünmesini sağlar.

Sahteleyebileceğiniz şeyler:

* Normal fonksiyonlar (ör. `VirtualAlloc`, `WinExec` vb.)
* Otomatik SSN ve stub çözümü ile yerel sistem çağrıları (ör. `NtAllocateVirtualMemory`)

`spoof!` / `spoof_synthetic!` ve `syscall!` / `syscall_synthetic!` makroları tüm karmaşıklığı soyutlar.

### WinExec Sahteciliği

Bu örnek, sahte bir çağrı yığını kullanarak `calc.exe` başlatmayı gösterir. `WinExec` iki kez çağrılır; bir kez Desync tekniği, tekrar da Synthetic tekniğiyle.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Kullanılacak WinAPI fonksiyonlarının adreslerini çözümler
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // `WinExec` ile komutu çalıştır
    // Çağrı Yığını Sahteciliği (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Başarısız");
        return Ok(());
    }

    // Çağrı Yığını Sahteciliği (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Başarısız [2]");
        return Ok(());
    }

    Ok(())
}
```

### Dolaylı Sistem Çağrısı Sahteciliği

Bu örnek, sahte bir çağrı yığını ile `NtAllocateVirtualMemory` için dolaylı bir sistem çağrısı gerçekleştirir.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Çağrı Yığını Sahteciliği ile dolaylı sistem çağrısı (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Durumuyla Başarısız Oldu: {status:#X}");
        return Ok(())
    }

    println!("[+] Adres tahsis edildi: {:?}", addr);

    // Çağrı Yığını Sahteciliği ile dolaylı sistem çağrısı (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Durumuyla Başarısız Oldu [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Adres tahsis edildi: {:?}", addr);

Ok(())
}
```

## Ek Kaynaklar

Daha fazla örnek için, depodaki [examples](/examples) klasörüne göz atın.

## Referanslar

`uwd`'yi oluşturmam ve bazı özelliklerle katkıda bulunmam için bana ilham veren bu projelere teşekkür etmek istiyorum:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Özel teşekkürler:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Detaylar için [LICENSE](/LICENSE) dosyasına bakınız.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---