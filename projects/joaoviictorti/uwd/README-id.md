# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` adalah pustaka Rust untuk spoofing call stack pada Windows, memungkinkan Anda mengeksekusi fungsi arbitrer dengan call stack palsu yang dapat menghindari analisis, pencatatan, atau deteksi selama stack unwinding.

Terinspirasi dari [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), crate ini menghadirkan kapabilitas spoofing tingkat rendah ke dalam antarmuka Rust yang bersih dan idiomatik dengan dukungan penuh untuk `#[no_std]`, toolchain `MSVC` dan `GNU`, serta resolusi gadget otomatis.

## Fitur

- ✅ Spoofing call stack melalui `Synthetic` dan `Desync`.
- ✅ Kompatibel dengan toolchain `MSVC` dan `GNU` (**x64**).
- ✅ Makro inline: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Mendukung lingkungan `#[no_std]` (dengan `alloc`).

## Memulai

Tambahkan `uwd` ke proyek Anda dengan memperbarui `Cargo.toml`:
```bash
cargo add uwd
```

## Penggunaan

`uwd` memungkinkan Anda melakukan spoofing call stack di Rust saat memanggil API Windows standar maupun menjalankan indirect syscall. Pustaka ini menangani seluruh pengaturan frame palsu, rantai gadget, dan persiapan register agar eksekusi tampak berasal dari sumber yang sah.

Anda dapat melakukan spoof pada:

* Fungsi normal (seperti `VirtualAlloc`, `WinExec`, dll.)
* Native syscall dengan resolusi SSN dan stub otomatis (seperti `NtAllocateVirtualMemory`)

Makro `spoof!` / `spoof_synthetic!` dan `syscall!` / `syscall_synthetic!` mengabstraksi semua kompleksitasnya.

### Spoofing WinExec

Contoh ini menunjukkan cara menjalankan `calc.exe` menggunakan call stack yang telah di-spoof. Kita memanggil `WinExec` dua kali, pertama menggunakan teknik Desync, lalu menggunakan teknik Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Menyelesaikan alamat fungsi WinAPI yang akan digunakan
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Eksekusi perintah dengan `WinExec`
    // Spoofing Call Stack (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Gagal");
        return Ok(());
    }

    // Spoofing Call Stack (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Gagal [2]");
        return Ok(());
    }

    Ok(())
}
```

### Spoofing Indirect Syscall

Contoh ini melakukan indirect system call ke `NtAllocateVirtualMemory` dengan call stack yang telah di-spoof.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Menjalankan indirect syscall dengan Spoofing Call Stack (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Gagal Dengan Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Alamat dialokasikan: {:?}", addr);

    // Menjalankan indirect syscall dengan Spoofing Call Stack (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Gagal Dengan Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Alamat dialokasikan: {:?}", addr);

Ok(())
}
```

## Sumber Daya Tambahan

Untuk contoh lainnya, lihat folder [examples](/examples) di repositori.

## Referensi

Saya ingin mengucapkan terima kasih kepada proyek-proyek berikut yang menginspirasi saya untuk membuat `uwd` dan berkontribusi dengan beberapa fitur:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Ucapan terima kasih khusus kepada:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Lisensi

Proyek ini dilisensikan di bawah Lisensi MIT. Lihat berkas [LICENSE](/LICENSE) untuk detailnya.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---