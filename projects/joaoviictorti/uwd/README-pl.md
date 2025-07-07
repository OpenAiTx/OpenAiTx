# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` to biblioteka Rust do spoofowania stosu wywołań na Windows, umożliwiająca wykonywanie dowolnych funkcji z podrobionym stosem wywołań, który omija analizę, logowanie lub wykrywanie podczas odwijania stosu.

Zainspirowany przez [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), ten crate wprowadza niskopoziomowe możliwości spoofowania w czysty, idiomatyczny interfejs Rust z pełnym wsparciem dla `#[no_std]`, toolchainów `MSVC` i `GNU` oraz automatycznym rozwiązywaniem gadgetów.

## Funkcje

- ✅ Spoofowanie stosu wywołań poprzez `Synthetic` i `Desync`.
- ✅ Kompatybilność zarówno z toolchainami `MSVC`, jak i `GNU` (**x64**).
- ✅ Makra inline: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Wsparcie dla środowisk `#[no_std]` (z `alloc`).

## Pierwsze kroki

Dodaj `uwd` do swojego projektu, aktualizując plik `Cargo.toml`:
```bash
cargo add uwd
```

## Użytkowanie

`uwd` pozwala na spoofowanie stosu wywołań w Rust podczas wywoływania zarówno standardowych API Windows, jak i pośrednich syskali. Biblioteka obsługuje pełne przygotowanie fałszywych ramek, łańcuchów gadgetów oraz rejestrów, aby wykonanie wyglądało na pochodzące z legalnego źródła.

Możesz spoofować:

* Normalne funkcje (takie jak `VirtualAlloc`, `WinExec`, itd.)
* Natychmiastowe syskale z automatycznym rozwiązywaniem SSN i stubów (takie jak `NtAllocateVirtualMemory`)

Makra `spoof!` / `spoof_synthetic!` oraz `syscall!` / `syscall_synthetic!` upraszczają całą złożoność.

### Spoofowanie WinExec

Ten przykład pokazuje, jak uruchomić `calc.exe` używając podrobionego stosu wywołań. Wywołujemy `WinExec` dwa razy: raz przy użyciu techniki Desync, a następnie przy użyciu techniki Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Rozwiązuje adresy funkcji WinAPI do użycia
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Wykonanie polecenia przy użyciu `WinExec`
    // Spoofowanie stosu wywołań (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec nie powiodło się");
        return Ok(());
    }

    // Spoofowanie stosu wywołań (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec nie powiodło się [2]");
        return Ok(());
    }

    Ok(())
}
```

### Spoofowanie pośredniego syscala

Ten przykład wykonuje pośrednie wywołanie systemowe do `NtAllocateVirtualMemory` z podrobionym stosem wywołań.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Wykonanie pośredniego syscala ze spoofowaniem stosu wywołań (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory nie powiodło się ze statusem: {status:#X}");
        return Ok(())
    }

    println!("[+] Przydzielony adres: {:?}", addr);

    // Wykonanie pośredniego syscala ze spoofowaniem stosu wywołań (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory nie powiodło się ze statusem [2]: {status:#X}");
        return Ok(())
```

    }

    println!("[+] Przydzielony adres: {:?}", addr);

    Ok(())
}
```

## Dodatkowe zasoby

Więcej przykładów znajdziesz w folderze [examples](/examples) w repozytorium.

## Referencje

Chciałbym wyrazić wdzięczność projektom, które zainspirowały mnie do stworzenia `uwd` oraz dołożyły swoją cegiełkę w postaci niektórych funkcji:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Szczególne podziękowania dla:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Licencja

Ten projekt jest licencjonowany na zasadach licencji MIT. Szczegóły znajdziesz w pliku [LICENSE](/LICENSE).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---