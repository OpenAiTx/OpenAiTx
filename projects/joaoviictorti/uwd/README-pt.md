# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` é uma biblioteca Rust para spoofing da pilha de chamadas no Windows, permitindo executar funções arbitrárias com uma pilha de chamadas forjada que evita análise, registro ou detecção durante o desempilhamento.

Inspirada no [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), esta crate traz capacidades de spoofing de baixo nível para uma interface Rust limpa e idiomática, com suporte total a `#[no_std]`, toolchains `MSVC` e `GNU`, e resolução automatizada de gadgets.

## Recursos

- ✅ Spoofing de pilha de chamadas via `Synthetic` e `Desync`.
- ✅ Compatível com os toolchains `MSVC` e `GNU` (**x64**).
- ✅ Macros inline: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Suporte a ambientes `#[no_std]` (com `alloc`).

## Começando

Adicione `uwd` ao seu projeto atualizando seu `Cargo.toml`:
```bash
cargo add uwd
```

## Uso

`uwd` permite que você faça spoofing da pilha de chamadas em Rust ao chamar APIs padrão do Windows ou ao realizar syscalls indiretos. A biblioteca gerencia toda a configuração de frames falsos, cadeias de gadgets e preparação de registradores para fazer a execução parecer que veio de uma fonte legítima.

Você pode fazer spoof em:

* Funções normais (como `VirtualAlloc`, `WinExec`, etc.)
* Syscalls nativos com resolução automática de SSN e stub (como `NtAllocateVirtualMemory`)

As macros `spoof!` / `spoof_synthetic!` e `syscall!` / `syscall_synthetic!` abstraem toda a complexidade.

### Spoofing de WinExec

Este exemplo mostra como executar `calc.exe` usando uma pilha de chamadas spoofada. Chamamos `WinExec` duas vezes, uma usando a técnica Desync e novamente usando a técnica Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Resolve os endereços das funções WinAPI a serem usadas
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Executa comando com `WinExec`
    // Spoofing da pilha de chamadas (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Falhou");
        return Ok(());
    }

    // Spoofing da pilha de chamadas (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Falhou [2]");
        return Ok(());
    }

    Ok(())
}
```

### Spoofing de uma Syscall Indireta

Este exemplo realiza uma syscall indireta para `NtAllocateVirtualMemory` com uma pilha de chamadas spoofada.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Executando syscall indireta com spoofing da pilha de chamadas (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Falhou Com Status: {status:#X}");
        return Ok(())
    }

    println!("[+] Endereço alocado: {:?}", addr);

    // Executando syscall indireta com spoofing da pilha de chamadas (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Falhou Com Status [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Endereço alocado: {:?}", addr);

Ok(())
}
```

## Recursos Adicionais

Para mais exemplos, confira a pasta [examples](/examples) no repositório.

## Referências

Quero expressar minha gratidão a estes projetos que me inspiraram a criar o `uwd` e contribuir com algumas funcionalidades:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Agradecimentos especiais a:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Licença

Este projeto está licenciado sob a Licença MIT. Veja o arquivo [LICENSE](/LICENSE) para mais detalhes.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---