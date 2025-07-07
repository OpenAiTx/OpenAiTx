# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` is een Rust-bibliotheek voor call stack spoofing op Windows, waarmee je willekeurige functies kunt uitvoeren met een vervalste call stack die analyse, logging of detectie tijdens stack unwinding ontwijkt.

Geïnspireerd door [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), brengt deze crate low-level spoofingmogelijkheden naar een schone, idiomatische Rust-interface met volledige ondersteuning voor `#[no_std]`, `MSVC` en `GNU` toolchains, en geautomatiseerde gadget-resolutie.

## Functies

- ✅ Call stack spoofing via `Synthetic` en `Desync`.
- ✅ Compatibel met zowel `MSVC` als `GNU` toolchains (**x64**).
- ✅ Inline macro’s: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Ondersteunt `#[no_std]` omgevingen (met `alloc`).

## Aan de slag

Voeg `uwd` toe aan je project door je `Cargo.toml` bij te werken:
```bash
cargo add uwd
```

## Gebruik

Met `uwd` kun je de call stack in Rust spoofen bij het aanroepen van standaard Windows API’s of bij het uitvoeren van indirecte syscalls. De bibliotheek regelt de volledige opzet van nepframes, gadget-chains en registervoorbereiding zodat de uitvoering lijkt alsof deze van een legitieme bron komt.

Je kunt spoofen:

* Normale functies (zoals `VirtualAlloc`, `WinExec`, enz.)
* Native syscalls met automatische SSN- en stub-resolutie (zoals `NtAllocateVirtualMemory`)

De macro’s `spoof!` / `spoof_synthetic!` en `syscall!` / `syscall_synthetic!` abstraheren alle complexiteit.

### WinExec Spoofen

Dit voorbeeld laat zien hoe je `calc.exe` kunt opstarten met een gespoofte call stack. We roepen `WinExec` tweemaal aan: eenmaal met de Desync-techniek, en daarna met de Synthetic-techniek.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Resolves addresses van de WinAPI-functies die gebruikt gaan worden
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Voer opdracht uit met `WinExec`
    // Call Stack Spoofing (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Mislukt");
        return Ok(());
    }

    // Call Stack Spoofing (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Mislukt [2]");
        return Ok(());
    }

    Ok(())
}
```

### Een Indirecte Syscall Spoofen

Dit voorbeeld voert een indirecte systeemaanroep uit naar `NtAllocateVirtualMemory` met een gespoofte call stack.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Indirecte syscall uitvoeren met Call Stack Spoofing (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Mislukt Met Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Adres gealloceerd: {:?}", addr);

    // Indirecte syscall uitvoeren met Call Stack Spoofing (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Mislukt Met Status [2]: {status:#X}");
        return Ok(())
```

println!("[+] Adres toegekend: {:?}", addr);

Ok(())
}
```

## Aanvullende Bronnen

Voor meer voorbeelden, bekijk de [examples](/examples) map in de repository.

## Referenties

Ik wil mijn dank uitspreken aan deze projecten die mij hebben geïnspireerd om `uwd` te maken en bij te dragen met enkele features:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Speciale dank aan:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Licentie

Dit project is gelicentieerd onder de MIT-licentie. Zie het [LICENSE](/LICENSE) bestand voor details.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---