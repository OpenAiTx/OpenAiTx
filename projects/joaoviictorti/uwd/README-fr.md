# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` est une bibliothèque Rust pour le spoofing de la pile d'appels sous Windows, permettant d'exécuter des fonctions arbitraires avec une pile d'appels forgée qui échappe à l'analyse, à la journalisation ou à la détection lors du déroulement de la pile.

Inspirée par [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), cette crate apporte des capacités de spoofing bas niveau dans une interface Rust propre et idiomatique avec un support complet de `#[no_std]`, des toolchains `MSVC` et `GNU`, ainsi qu'une résolution automatisée des gadgets.

## Fonctionnalités

- ✅ Spoofing de la pile d'appels via `Synthetic` et `Desync`.
- ✅ Compatible avec les toolchains `MSVC` et `GNU` (**x64**).
- ✅ Macros inline : `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Compatible avec les environnements `#[no_std]` (avec `alloc`).

## Démarrage rapide

Ajoutez `uwd` à votre projet en mettant à jour votre `Cargo.toml` :
```bash
cargo add uwd
```

## Utilisation

`uwd` vous permet de falsifier la pile d'appels en Rust lors de l'appel d'API Windows standard ou lors de l'exécution de syscalls indirects. La bibliothèque gère toute la configuration des fausses frames, des chaînes de gadgets et la préparation des registres pour que l'exécution paraisse provenir d'une source légitime.

Vous pouvez falsifier :

* Des fonctions normales (comme `VirtualAlloc`, `WinExec`, etc.)
* Des syscalls natifs avec résolution automatique du SSN et du stub (comme `NtAllocateVirtualMemory`)

Les macros `spoof!` / `spoof_synthetic!` et `syscall!` / `syscall_synthetic!` abstraient toute la complexité.

### Spoofing de WinExec

Cet exemple montre comment lancer `calc.exe` en utilisant une pile d'appels falsifiée. Nous appelons `WinExec` deux fois, une fois en utilisant la technique Desync, et à nouveau avec la technique Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Résout les adresses des fonctions WinAPI à utiliser
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Exécute la commande avec `WinExec`
    // Spoofing de la pile d'appels (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed");
        return Ok(());
    }

    // Spoofing de la pile d'appels (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Failed [2]");
        return Ok(());
    }

    Ok(())
}
```

### Spoofing d'un Syscall Indirect

Cet exemple effectue un appel système indirect vers `NtAllocateVirtualMemory` avec une pile d'appels falsifiée.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Exécution d'un syscall indirect avec spoofing de la pile d'appels (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Adresse allouée : {:?}", addr);

    // Exécution d'un syscall indirect avec spoofing de la pile d'appels (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Failed With Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Adresse allouée : {:?}", addr);

Ok(())
}
```

## Ressources supplémentaires

Pour plus d'exemples, consultez le dossier [examples](/examples) dans le dépôt.

## Références

Je souhaite exprimer ma gratitude envers ces projets qui m'ont inspiré à créer `uwd` et à y contribuer avec certaines fonctionnalités :

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Remerciements particuliers à :

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Licence

Ce projet est sous licence MIT. Voir le fichier [LICENSE](/LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---