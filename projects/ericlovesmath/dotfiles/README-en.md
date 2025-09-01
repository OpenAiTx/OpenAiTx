# Eric Lee's Dotfiles

![Neovim Configuration](https://raw.githubusercontent.com/ericlovesmath/dotfiles/master/./imgs/desktop.png)

- Dual configuration for MacOS and Fedora
- Personal [Neovim](https://github.com/neovim/neovim) configuration
- [Alacritty](https://github.com/alacritty/alacritty) with `zsh`

## Installation (MacOS)

- Overview: [yabai](https://github.com/koekeishiya/yabai) + [skhd](https://github.com/koekeishiya/skhd) + [karabiner-elements](https://karabiner-elements.pqrs.org/)

    - Dotfiles symlinked & applications installed with [nix-darwin](github.com/LnL7/nix-darwin) and home-manager
    - Yabai: Tiling WM uses Capslock as a `meh/hyper` global prefix, mimicking vim keybindings
    - Neovim: `Lazy` to install packages, `Mason` to install LSPs
    - Alacritty: Keybindings set such that intuitive `cmd + _` key combinations works with `tmux`

- [Nix](https://github.com/DeterminateSystems/nix-installer): Mostly just used as a declarative package manager and symlink tool

    - If Nix is not an option, see contents of `home-darwin.nix` and `brew.nix` to see symlinks
- Install [Nix]

```bash
mkdir ~/dotfiles & cd ~/dotfiles
git clone https://github.com/ericlovesmath/dotfiles.git ~/dotfiles
nix run nix-darwin -- switch --flake "$HOME/dotfiles\#macos"
```

## Installation (Fedora, Sway and Hyprland)

See `INSTALLATION_GUIDE.md`, tested on the AMD Framework 13 Laptop


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---