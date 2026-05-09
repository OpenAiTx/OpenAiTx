# Framework System TUI

![Rust](https://img.shields.io/badge/lang-rust-orange) ![ratatui](https://img.shields.io/badge/ui-ratatui-blue) ![Framework Laptop](https://img.shields.io/badge/hardware-Framework--Laptop-success)  

Un panel TUI ágil para controlar y monitorear el hardware de tu Framework Laptop — carga, privacidad, iluminación, puertos USB PD y más.

![demo](/docs/screenshots/demo-v0.7.2.gif)

## :octocat: Características

### Hardware del Framework Laptop

- [x] **Estado en vivo de batería y carga** con límites y controles de carga
- [x] **Interruptores de privacidad** para micrófono y cámara
- [ ] **Selector de modo Input Deck** (Framework 16)
- [x] **Controles de brillo del teclado y lector de huellas**
- [x] **Monitoreo de puertos USB PD**
- [x] **RPM del ventilador**
- [ ] **Información térmica:** temperaturas CPU/GPU
- [x] **Información del sistema:** detalles del BIOS

## Instalación

### :dvd: Binarios

Los binarios precompilados para Linux, Windows y FreeBSD están disponibles para descarga en la página de [Releases](https://github.com/grouzen/framework-tool-tui/releases)

### :memo: Desde el código fuente

Requiere [Rust](https://rustup.rs/) (Edición 2024) y un Framework laptop.

```sh
git clone https://github.com/grouzen/framework-tool-tui.git
cd framework-tool-tui
cargo build --release
# or via cargo install
cargo install --path .
```

### :penguin: Distribuciones de Linux

#### Gentoo linux

Está disponible a través de los [paquetes oficiales de Gentoo](https://packages.gentoo.org/packages/app-laptop/framework-tool-tui) o el overlay [lamdness](https://github.com/grouzen/lamdness-overlay/tree/main/app-laptop/framework-tool-tui)

```sh
# Official gentoo repository
sudo emerge -av app-laptop/framework-tool-tui

# or via lamdness overlay
sudo eselect repository enable lamdness
sudo emaint -r lamdness sync
sudo emerge -av app-laptop/framework-tool-tui
```

#### Arch linux

Está disponible a través de [AUR](https://aur.archlinux.org/packages/framework-tool-tui) o [archlinuxcn](https://github.com/archlinuxcn/repo/tree/master/archlinuxcn/framework-tool-tui)

```sh
[yay/paru] -S framework-tool-tui # Install from AUR
sudo pacman -S framework-tool-tui # Install from archlinuxcn
```

#### NixOS linux

Está disponible a través de los [paquetes oficiales de NixOS](https://search.nixos.org/packages?query=framework-tool-tui):

```sh
nix-shell -p framework-tool-tui # Install temporarily

# Add to the NixOS configuration or use nix profile to install permanently
```

#### :beer: Homebrew para Linux

Disponible a través de la [fórmula `framework-tool-tui`](https://formulae.brew.sh/formula/framework-tool-tui)

```sh
brew install framework-tool-tui
```

### 😈 FreeBSD


Está disponible en [FreeBSD ports](https://www.freshports.org/sysutils/framework-tool-tui/)
```sh
pkg install framework-tool-tui
```

### Windows

Por ahora, puede instalarlo [Desde el código fuente](#memo-from-source) o [Desde binarios precompilados](#dvd-binaries)

## :man: Ejecutar

Debe ejecutarse con privilegios de root para acceder a los controles de hardware.

```sh
sudo framework-tool-tui
```

## :pencil: Arquitectura

Consulta [ARCHITECTURE.md](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/docs/ARCHITECTURE.md) para un desglose técnico completo.  
- Sondeo de hardware a través de [`framework_lib`](https://github.com/FrameworkComputer/framework-system)

## :handshake: Contribuciones

¡Pull requests bienvenidos! Para reportes de errores o solicitudes de funciones, consulta Issues.

### Revisa tu código antes de enviar

Se recomienda ejecutar `cargo make check-all` antes de hacer commit y push a tu rama de función.

Esto requiere tener instalado en tu sistema el ejecutor [cargo make](https://github.com/sagiegurari/cargo-make):

```sh
cargo install --force cargo-make
```

### Convención de Mensajes de Commit

Este proyecto utiliza [Conventional Commits](https://www.conventionalcommits.org/) para el versionado automático y la generación de registros de cambios. Por favor, formatea tus mensajes de commit como:

```
<type>: <description>

[optional body]
```

**Tipos comunes:**
- `feat:` - Nueva funcionalidad (provoca aumento de versión menor)
- `fix:` - Corrección de errores (provoca aumento de versión de parche)
- `docs:` - Cambios en la documentación
- `refactor:` - Refactorización de código
- `test:` - Añadir o actualizar pruebas
- `chore:` - Tareas de mantenimiento
- `ci:` - Cambios en CI/CD

**Ejemplos:**
```
feat: add thermal monitoring support
fix: correct battery percentage calculation
docs: update installation instructions
```
Para cambios que rompen la compatibilidad, añada `!` después del tipo o incluya `BREAKING CHANGE:` en el pie de página:

```
feat!: redesign UI layout
```

### Pila técnica

- [ratatui](https://ratatui.rs)
- [tokio](https://tokio.rs)
- [framework_lib](https://github.com/FrameworkComputer/framework-system/tree/main/framework_lib)

## :judge: Licencia

```
MIT License

Copyright (c) 2025 Mykhailo Nedokushev

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```

Vea [LICENSE](LICENSE) y [Cargo.toml](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/Cargo.toml:1) para la licencia y dependencias.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-09

---