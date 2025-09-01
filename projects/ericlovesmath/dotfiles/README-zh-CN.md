# Eric Lee 的 Dotfiles

![Neovim 配置](https://raw.githubusercontent.com/ericlovesmath/dotfiles/master/./imgs/desktop.png)

- 针对 MacOS 和 Fedora 的双重配置
- 个人 [Neovim](https://github.com/neovim/neovim) 配置
- 使用 `zsh` 的 [Alacritty](https://github.com/alacritty/alacritty)

## 安装（MacOS）

- 概览：[yabai](https://github.com/koekeishiya/yabai) + [skhd](https://github.com/koekeishiya/skhd) + [karabiner-elements](https://karabiner-elements.pqrs.org/)

    - 使用 [nix-darwin](github.com/LnL7/nix-darwin) 和 home-manager 创建 Dotfiles 符号链接并安装应用
    - Yabai：平铺窗口管理器使用 Capslock 作为 `meh/hyper` 全局前缀，模拟 vim 快捷键
    - Neovim：使用 `Lazy` 安装插件，`Mason` 安装 LSP
    - Alacritty：设置快捷键，使直观的 `cmd + _` 组合键在 `tmux` 中可用

- [Nix](https://github.com/DeterminateSystems/nix-installer)：主要用作声明式包管理器和符号链接工具

    - 如果不能使用 Nix，请查看 `home-darwin.nix` 和 `brew.nix` 的内容了解符号链接
- 安装 [Nix]

```bash
mkdir ~/dotfiles & cd ~/dotfiles
git clone https://github.com/ericlovesmath/dotfiles.git ~/dotfiles
nix run nix-darwin -- switch --flake "$HOME/dotfiles\#macos"
```

## 安装（Fedora、Sway 和 Hyprland）

请参阅 `INSTALLATION_GUIDE.md`，已在 AMD Framework 13 笔记本上测试通过


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---