# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` è una libreria Rust per lo spoofing dello stack di chiamata su Windows, che consente di eseguire funzioni arbitrarie con uno stack di chiamata falsificato che evita l'analisi, il logging o la rilevazione durante l'unwinding dello stack.

Ispirata da [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), questa crate porta capacità di spoofing a basso livello in un'interfaccia Rust pulita e idiomatica con pieno supporto per `#[no_std]`, toolchain `MSVC` e `GNU`, e risoluzione automatica dei gadget.

## Funzionalità

- ✅ Spoofing dello stack di chiamata tramite `Synthetic` e `Desync`.
- ✅ Compatibile sia con toolchain `MSVC` che `GNU` (**x64**).
- ✅ Macro inline: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Supporto ad ambienti `#[no_std]` (con `alloc`).

## Per iniziare

Aggiungi `uwd` al tuo progetto aggiornando il tuo `Cargo.toml`:
```bash
cargo add uwd
```

## Utilizzo

`uwd` permette di falsificare lo stack di chiamata in Rust durante la chiamata sia di API Windows standard che nell'esecuzione di syscalls indirette. La libreria gestisce completamente la creazione di frame falsi, catene di gadget e la preparazione dei registri per far apparire l'esecuzione come proveniente da una fonte legittima.

Puoi falsificare:

* Funzioni normali (come `VirtualAlloc`, `WinExec`, ecc.)
* Syscalls native con risoluzione automatica di SSN e stub (come `NtAllocateVirtualMemory`)

Le macro `spoof!` / `spoof_synthetic!` e `syscall!` / `syscall_synthetic!` astraggono tutta la complessità.

### Spoofing di WinExec

Questo esempio mostra come avviare `calc.exe` utilizzando uno stack di chiamata falsificato. Viene chiamata `WinExec` due volte: una utilizzando la tecnica Desync, e una utilizzando quella Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Risolve gli indirizzi delle funzioni WinAPI da utilizzare
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Esegue il comando con `WinExec`
    // Spoofing dello stack di chiamata (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Fallita");
        return Ok(());
    }

    // Spoofing dello stack di chiamata (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Fallita [2]");
        return Ok(());
    }

    Ok(())
}
```

### Spoofing di una Syscall Indiretta

Questo esempio esegue una system call indiretta a `NtAllocateVirtualMemory` con uno stack di chiamata falsificato.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Esecuzione di syscall indiretta con spoofing dello stack di chiamata (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Fallita Con Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Indirizzo allocato: {:?}", addr);

    // Esecuzione di syscall indiretta con spoofing dello stack di chiamata (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Fallita Con Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Indirizzo allocato: {:?}", addr);

Ok(())
}
```

## Risorse aggiuntive

Per ulteriori esempi, consulta la cartella [examples](/examples) nel repository.

## Riferimenti

Desidero esprimere la mia gratitudine a questi progetti che mi hanno ispirato a creare `uwd` e a contribuire con alcune funzionalità:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Un ringraziamento speciale a:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Licenza

Questo progetto è distribuito sotto licenza MIT. Consulta il file [LICENSE](/LICENSE) per i dettagli.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---