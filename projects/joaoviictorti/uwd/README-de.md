# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` ist eine Rust-Bibliothek für Call-Stack-Spoofing unter Windows, die es ermöglicht, beliebige Funktionen mit einem gefälschten Call-Stack auszuführen, der Analyse, Protokollierung oder Erkennung beim Stack-Unwinding entgeht.

Inspiriert von [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk) bringt dieses Crate Low-Level-Spoofing-Fähigkeiten in eine saubere, idiomatische Rust-Schnittstelle mit voller Unterstützung für `#[no_std]`, `MSVC` und `GNU` Toolchains sowie automatisierter Gadget-Auflösung.

## Funktionen

- ✅ Call-Stack-Spoofing über `Synthetic` und `Desync`.
- ✅ Kompatibel mit sowohl `MSVC` als auch `GNU` Toolchains (**x64**).
- ✅ Inline-Makros: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Unterstützt `#[no_std]` Umgebungen (mit `alloc`).

## Einstieg

Fügen Sie `uwd` zu Ihrem Projekt hinzu, indem Sie Ihre `Cargo.toml` aktualisieren:
```bash
cargo add uwd
```

## Verwendung

`uwd` ermöglicht es Ihnen, den Call-Stack in Rust zu spoofen, wenn Sie entweder Standard-Windows-APIs aufrufen oder indirekte Syscalls durchführen. Die Bibliothek übernimmt die vollständige Einrichtung von gefälschten Frames, Gadget-Chains und Registervorbereitung, um die Ausführung so erscheinen zu lassen, als käme sie aus einer legitimen Quelle.

Sie können folgende Dinge spoofen:

* Normale Funktionen (wie `VirtualAlloc`, `WinExec` usw.)
* Native Syscalls mit automatischer SSN- und Stub-Auflösung (wie `NtAllocateVirtualMemory`)

Die Makros `spoof!` / `spoof_synthetic!` und `syscall!` / `syscall_synthetic!` abstrahieren die gesamte Komplexität.

### WinExec spoofen

Dieses Beispiel zeigt, wie man `calc.exe` mit einem gespooften Call-Stack startet. Wir rufen `WinExec` zweimal auf: einmal mit der Desync-Technik und erneut mit der Synthetic-Technik.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Adressen der zu verwendenden WinAPI-Funktionen auflösen
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Befehl mit `WinExec` ausführen
    // Call-Stack-Spoofing (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec fehlgeschlagen");
        return Ok(());
    }

    // Call-Stack-Spoofing (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec fehlgeschlagen [2]");
        return Ok(());
    }

    Ok(())
}
```

### Indirekten Syscall spoofen

Dieses Beispiel führt einen indirekten Systemaufruf zu `NtAllocateVirtualMemory` mit einem gespooften Call-Stack aus.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Indirekten Syscall mit Call-Stack-Spoofing (Desync) ausführen
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory fehlgeschlagen mit Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Adresse zugewiesen: {:?}", addr);

    // Indirekten Syscall mit Call-Stack-Spoofing (Synthetic) ausführen
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory fehlgeschlagen mit Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Adresse zugewiesen: {:?}", addr);

Ok(())
}
```

## Zusätzliche Ressourcen

Weitere Beispiele finden Sie im [examples](/examples)-Ordner im Repository.

## Referenzen

Ich möchte meinen Dank an diese Projekte aussprechen, die mich dazu inspiriert haben, `uwd` zu erstellen und einige Features beizutragen:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Besonderer Dank an:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Lizenz

Dieses Projekt steht unter der MIT-Lizenz. Details finden Sie in der [LICENSE](/LICENSE)-Datei.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---