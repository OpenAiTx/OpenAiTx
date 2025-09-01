# Dotfiles d'Eric Lee

![Configuration Neovim](https://raw.githubusercontent.com/ericlovesmath/dotfiles/master/./imgs/desktop.png)

- Configuration double pour MacOS et Fedora
- Configuration personnelle de [Neovim](https://github.com/neovim/neovim)
- [Alacritty](https://github.com/alacritty/alacritty) avec `zsh`

## Installation (MacOS)

- Vue d'ensemble : [yabai](https://github.com/koekeishiya/yabai) + [skhd](https://github.com/koekeishiya/skhd) + [karabiner-elements](https://karabiner-elements.pqrs.org/)

    - Dotfiles liés par des liens symboliques & applications installées avec [nix-darwin](github.com/LnL7/nix-darwin) et home-manager
    - Yabai : gestionnaire de fenêtres en mosaïque utilise Capslock comme préfixe global `meh/hyper`, imitant les raccourcis vim
    - Neovim : `Lazy` pour installer les paquets, `Mason` pour installer les LSP
    - Alacritty : raccourcis clavier configurés pour que les combinaisons de touches intuitives `cmd + _` fonctionnent avec `tmux`

- [Nix](https://github.com/DeterminateSystems/nix-installer) : principalement utilisé comme gestionnaire de paquets déclaratif et outil de liens symboliques

    - Si Nix n’est pas une option, consultez le contenu de `home-darwin.nix` et `brew.nix` pour voir les liens symboliques
- Installer [Nix]

```bash
mkdir ~/dotfiles & cd ~/dotfiles
git clone https://github.com/ericlovesmath/dotfiles.git ~/dotfiles
nix run nix-darwin -- switch --flake "$HOME/dotfiles\#macos"
```

## Installation (Fedora, Sway et Hyprland)

Voir `INSTALLATION_GUIDE.md`, testé sur le portable AMD Framework 13


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---