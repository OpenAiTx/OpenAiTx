# Eric Leeのドットファイル

![Neovimの設定](https://raw.githubusercontent.com/ericlovesmath/dotfiles/master/./imgs/desktop.png)

- MacOSとFedoraのデュアル設定
- 個人用[Neovim](https://github.com/neovim/neovim)設定
- `zsh`を使用した[Alacritty](https://github.com/alacritty/alacritty)

## インストール（MacOS）

- 概要: [yabai](https://github.com/koekeishiya/yabai) + [skhd](https://github.com/koekeishiya/skhd) + [karabiner-elements](https://karabiner-elements.pqrs.org/)

    - Dotfilesはシンボリックリンクされ、[nix-darwin](github.com/LnL7/nix-darwin)とhome-managerでアプリケーションをインストール
    - Yabai: タイリングWMはCapslockを`meh/hyper`のグローバルプレフィックスとして使用し、vimのキーバインディングを模倣
    - Neovim: `Lazy`でパッケージをインストール、`Mason`でLSPをインストール
    - Alacritty: 直感的な`cmd + _`のキーコンビネーションが`tmux`で動作するようにキーバインディング設定

- [Nix](https://github.com/DeterminateSystems/nix-installer): 主に宣言型パッケージマネージャーおよびシンボリックリンクツールとして使用

    - Nixが使えない場合は、`home-darwin.nix`と`brew.nix`の内容を参照してシンボリックリンクを確認
- [Nix]をインストール

```bash
mkdir ~/dotfiles & cd ~/dotfiles
git clone https://github.com/ericlovesmath/dotfiles.git ~/dotfiles
nix run nix-darwin -- switch --flake "$HOME/dotfiles\#macos"
```

## インストール（Fedora、Sway、および Hyprland）

`INSTALLATION_GUIDE.md` を参照してください。AMD Framework 13 ラップトップでテスト済みです。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-01

---