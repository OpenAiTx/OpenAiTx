# Système Framework TUI

![Rust](https://img.shields.io/badge/lang-rust-orange) ![ratatui](https://img.shields.io/badge/ui-ratatui-blue) ![Framework Laptop](https://img.shields.io/badge/hardware-Framework--Laptop-success)  

Un tableau de bord TUI réactif pour contrôler et surveiller le matériel de votre Framework Laptop — charge, confidentialité, éclairage, ports USB PD, et plus encore.

![demo](/docs/screenshots/demo-v0.7.2.gif)

## :octocat: Fonctionnalités

### Matériel Framework Laptop

- [x] **Statut en temps réel de la batterie et de la charge** avec limites et contrôles de charge
- [x] **Bascules de confidentialité** pour microphone et caméra
- [ ] **Sélecteur de mode Input Deck** (Framework 16)
- [x] **Contrôles de luminosité du clavier et de l'empreinte digitale**
- [x] **Surveillance des ports USB PD**
- [x] **RPM du ventilateur**
- [ ] **Informations thermiques :** températures CPU/GPU
- [x] **Informations système :** détails du BIOS

## Installation

### :dvd: Binaries

Les binaires précompilés pour Linux, Windows et FreeBSD sont disponibles en téléchargement sur la page [Releases](https://github.com/grouzen/framework-tool-tui/releases)

### :memo: Depuis la source

Nécessite [Rust](https://rustup.rs/) (Édition 2024) et un Framework laptop.

```sh
git clone https://github.com/grouzen/framework-tool-tui.git
cd framework-tool-tui
cargo build --release
# or via cargo install
cargo install --path .
```

### :penguin: Distributions Linux

#### Gentoo linux

Il est disponible via les [paquets officiels Gentoo](https://packages.gentoo.org/packages/app-laptop/framework-tool-tui) ou l’overlay [lamdness](https://github.com/grouzen/lamdness-overlay/tree/main/app-laptop/framework-tool-tui)

```sh
# Official gentoo repository
sudo emerge -av app-laptop/framework-tool-tui

# or via lamdness overlay
sudo eselect repository enable lamdness
sudo emaint -r lamdness sync
sudo emerge -av app-laptop/framework-tool-tui
```

#### Arch linux

Il est disponible via [AUR](https://aur.archlinux.org/packages/framework-tool-tui) ou [archlinuxcn](https://github.com/archlinuxcn/repo/tree/master/archlinuxcn/framework-tool-tui)

```sh
[yay/paru] -S framework-tool-tui # Install from AUR
sudo pacman -S framework-tool-tui # Install from archlinuxcn
```

#### NixOS linux

Il est disponible via les [paquets officiels NixOS](https://search.nixos.org/packages?query=framework-tool-tui) :

```sh
nix-shell -p framework-tool-tui # Install temporarily

# Add to the NixOS configuration or use nix profile to install permanently
```

#### :beer: Homebrew pour Linux

Disponible via la [`formule framework-tool-tui`](https://formulae.brew.sh/formula/framework-tool-tui)

```sh
brew install framework-tool-tui
```

### 😈 FreeBSD


Il est disponible dans les [ports FreeBSD](https://www.freshports.org/sysutils/framework-tool-tui/)
```sh
pkg install framework-tool-tui
```

### Windows

Pour l’instant, vous pouvez l’installer [Depuis la Source](#memo-from-source) ou [Depuis les Binaries Précompilées](#dvd-binaries)

## :man: Exécuter

Il doit être exécuté avec les privilèges root pour accéder aux contrôles matériels.

```sh
sudo framework-tool-tui
```

## :pencil: Architecture

Voir [ARCHITECTURE.md](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/docs/ARCHITECTURE.md) pour une analyse technique complète.  
- Interrogation matérielle via [`framework_lib`](https://github.com/FrameworkComputer/framework-system)

## :handshake: Contribution

Les pull requests sont les bienvenues ! Pour les rapports de bugs ou demandes de fonctionnalités, voir Issues.

### Vérifiez votre code avant de pousser

Il est recommandé d'exécuter `cargo make check-all` avant de valider et de pousser sur votre branche de fonctionnalité.

Cela nécessite que le runner [cargo make](https://github.com/sagiegurari/cargo-make) soit installé sur votre système :

```sh
cargo install --force cargo-make
```

### Convention de message de commit

Ce projet utilise [Conventional Commits](https://www.conventionalcommits.org/) pour la gestion automatique des versions et la génération du journal des modifications. Veuillez formater vos messages de commit comme suit :

```
<type>: <description>

[optional body]
```

**Types courants :**
- `feat:` - Nouvelle fonctionnalité (déclenche une augmentation de version mineure)
- `fix:` - Correction de bug (déclenche une augmentation de version patch)
- `docs:` - Modifications de la documentation
- `refactor:` - Refactorisation du code
- `test:` - Ajout ou mise à jour des tests
- `chore:` - Tâches de maintenance
- `ci:` - Modifications CI/CD

**Exemples :**
```
feat: add thermal monitoring support
fix: correct battery percentage calculation
docs: update installation instructions
```
Pour les changements majeurs, ajoutez `!` après le type ou incluez `BREAKING CHANGE:` dans le pied de page :

```
feat!: redesign UI layout
```

### Pile technique

- [ratatui](https://ratatui.rs)
- [tokio](https://tokio.rs)
- [framework_lib](https://github.com/FrameworkComputer/framework-system/tree/main/framework_lib)

## :judge: Licence

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

Voir [LICENSE](LICENSE) et [Cargo.toml](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/Cargo.toml:1) pour la licence et les dépendances.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-09

---