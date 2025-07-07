# uwd 🦀

![Rust](https://img.shields.io/badge/made%20with-Rust-red)
![crate](https://img.shields.io/crates/v/uwd.svg)
![docs](https://docs.rs/uwd/badge.svg)
[![build](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml/badge.svg)](https://github.com/joaoviictorti/uwd/actions/workflows/ci.yml)
![Forks](https://img.shields.io/github/forks/joaoviictorti/uwd)
![Stars](https://img.shields.io/github/stars/joaoviictorti/uwd)
![License](https://img.shields.io/github/license/joaoviictorti/uwd)

`uwd` es una biblioteca de Rust para suplantación de pila de llamadas en Windows, que te permite ejecutar funciones arbitrarias con una pila de llamadas falsificada que evade el análisis, registro o detección durante el desenrollado de la pila.

Inspirado en [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk), este crate lleva capacidades de suplantación de bajo nivel a una interfaz Rust limpia e idiomática, con soporte completo para `#[no_std]`, toolchains `MSVC` y `GNU`, y resolución automatizada de gadgets.

## Características

- ✅ Suplantación de pila de llamadas vía `Synthetic` y `Desync`.
- ✅ Compatible con toolchains `MSVC` y `GNU` (**x64**).
- ✅ Macros inline: `spoof!`, `spoof_synthetic!`, `syscall!`, `syscall_synthetic!`.
- ✅ Soporte para entornos `#[no_std]` (con `alloc`).

## Primeros pasos

Agrega `uwd` a tu proyecto actualizando tu `Cargo.toml`:
```bash
cargo add uwd
```

## Uso

`uwd` te permite suplantar la pila de llamadas en Rust al invocar APIs estándar de Windows o realizar syscalls indirectas. La biblioteca gestiona la configuración completa de frames falsos, cadenas de gadgets y preparación de registros para que la ejecución parezca provenir de una fuente legítima.

Puedes suplantar:

* Funciones normales (como `VirtualAlloc`, `WinExec`, etc.)
* Syscalls nativas con resolución automática de SSN y stubs (como `NtAllocateVirtualMemory`)

Las macros `spoof!` / `spoof_synthetic!` y `syscall!` / `syscall_synthetic!` abstraen toda la complejidad.

### Suplantando WinExec

Este ejemplo muestra cómo lanzar `calc.exe` usando una pila de llamadas suplantada. Llamamos a `WinExec` dos veces: una usando la técnica Desync y otra usando la técnica Synthetic.

```rs
use dinvk::{GetModuleHandle, GetProcAddress};
use uwd::{spoof, spoof_synthetic};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Resuelve las direcciones de las funciones WinAPI a usar
    let kernel32 = GetModuleHandle("kernel32.dll", None);
    let win_exec = GetProcAddress(kernel32, "WinExec", None);
    
    // Ejecuta el comando con `WinExec`
    // Suplantación de pila de llamadas (Desync)
    let cmd = c"calc.exe";
    let mut result = spoof!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Falló");
        return Ok(());
    }

    // Suplantación de pila de llamadas (Synthetic)
    result = spoof_synthetic!(win_exec, cmd.as_ptr(), 1)?;
    if result.is_null() {
        eprintln!("WinExec Falló [2]");
        return Ok(());
    }

    Ok(())
}
```

### Suplantando un Syscall Indirecto

Este ejemplo realiza una syscall indirecta a `NtAllocateVirtualMemory` con una pila de llamadas suplantada.

```rs
use std::{ffi::c_void, ptr::null_mut};
use dinvk::NT_SUCCESS;
use uwd::{syscall, syscall_synthetic, AsUwd};

fn main() -> Result<(), Box<dyn std::error::Error>> {
    // Ejecutando syscall indirecta con suplantación de pila de llamadas (Desync)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    let mut status = syscall!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCCESS(status) {
        eprintln!("NtAllocateVirtualMemory Falló con Estado: {status:#X}");
        return Ok(())
    }

    println!("[+] Dirección asignada: {:?}", addr);

    // Ejecutando syscall indirecta con suplantación de pila de llamadas (Synthetic)
    let mut addr = null_mut::<c_void>();
    let mut size = (1 << 12) as usize;
    status = syscall_synthetic!("NtAllocateVirtualMemory", -1isize, addr.as_uwd_mut(), 0, size.as_uwd_mut(), 0x3000, 0x04)? as i32;
    if !NT_SUCESS(status) {
        eprintln!("NtAllocateVirtualMemory Falló con Estado [2]: {status:#X}");
        return Ok(())
```
}

println!("[+] Dirección asignada: {:?}", addr);

Ok(())
}
```

## Recursos adicionales

Para más ejemplos, consulta la carpeta [examples](/examples) en el repositorio.

## Referencias

Quiero expresar mi gratitud a estos proyectos que me inspiraron a crear `uwd` y contribuir con algunas características:

- [SilentMoonwalk](https://github.com/klezVirus/SilentMoonwalk)

Agradecimientos especiales a:

- [Kudaes](https://x.com/_Kudaes_)
- [Klez](https://x.com/KlezVirus)
- [Waldo-IRC](https://x.com/waldoirc)
- [Trickster0](https://x.com/trickster012)
- [namazso](https://x.com/namazso)

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo [LICENSE](/LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---