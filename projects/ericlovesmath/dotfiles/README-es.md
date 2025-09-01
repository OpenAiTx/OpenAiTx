# Dotfiles de Eric Lee

![Configuración de Neovim](https://raw.githubusercontent.com/ericlovesmath/dotfiles/master/./imgs/desktop.png)

- Configuración dual para MacOS y Fedora
- Configuración personal de [Neovim](https://github.com/neovim/neovim)
- [Alacritty](https://github.com/alacritty/alacritty) con `zsh`

## Instalación (MacOS)

- Resumen: [yabai](https://github.com/koekeishiya/yabai) + [skhd](https://github.com/koekeishiya/skhd) + [karabiner-elements](https://karabiner-elements.pqrs.org/)

    - Dotfiles enlazados simbólicamente e instalaciones de aplicaciones con [nix-darwin](github.com/LnL7/nix-darwin) y home-manager
    - Yabai: Gestor de ventanas en mosaico usa Capslock como prefijo global `meh/hyper`, imitando atajos de vim
    - Neovim: `Lazy` para instalar paquetes, `Mason` para instalar LSPs
    - Alacritty: Atajos configurados para que combinaciones intuitivas `cmd + _` funcionen con `tmux`

- [Nix](https://github.com/DeterminateSystems/nix-installer): Usado principalmente como gestor de paquetes declarativo y herramienta de enlaces simbólicos

    - Si Nix no es una opción, consulte el contenido de `home-darwin.nix` y `brew.nix` para ver los enlaces simbólicos
- Instalar [Nix]

```bash
mkdir ~/dotfiles & cd ~/dotfiles
git clone https://github.com/ericlovesmath/dotfiles.git ~/dotfiles
nix run nix-darwin -- switch --flake "$HOME/dotfiles\#macos"
```

## Instalación (Fedora, Sway y Hyprland)

Consulta `INSTALLATION_GUIDE.md`, probado en el portátil AMD Framework 13


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---