# gfold

[![latest release tag](https://img.shields.io/github/v/tag/nickgerace/gfold?sort=semver&logo=git&logoColor=white&label=version&style=for-the-badge&color=blue)](https://github.com/nickgerace/gfold/releases/latest)
[![crates.io version](https://img.shields.io/crates/v/gfold?style=for-the-badge&logo=rust&color=orange)](https://crates.io/crates/gfold)
[![build status](https://img.shields.io/github/actions/workflow/status/nickgerace/gfold/ci.yml?branch=main&style=for-the-badge&logo=github&logoColor=white)](https://github.com/nickgerace/gfold/actions)
[![calver](https://img.shields.io/badge/calver-YYYY.MM.MICRO-cyan.svg?style=for-the-badge)](https://calver.org)

`gfold` は複数の Git リポジトリを管理するのに役立つ CLI ツールです。

[![A GIF showcasing gfold in action](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)

クラシック表示モードをデフォルトで使用し、毎回フラグを設定する手間を避けたい場合は、設定ファイルで設定できます（**Usage** セクション参照）。

## お知らせ (2025年2月)

すべてのリリースは、`2025.2.1` から始まる [CalVer](https://calver.org/) バージョニングスキームに従います。
この変更は、最初のリリースからバージョン `4.6.0` まで使用されていた [セマンティックバージョニング](https://semver.org/spec/v2.0.0.html) スキームと前後互換性があります。

*バージョニングスキームの変更に関して、エンドユーザーによる特別な操作は必要ありません。*

このお知らせは最終的にこの [README](https://raw.githubusercontent.com/nickgerace/gfold/main/./README.md) から削除され、[CHANGELOG](https://raw.githubusercontent.com/nickgerace/gfold/main/./CHANGELOG.md) に移されます。

## 説明

このアプリは、一つまたは複数のディレクトリ内にある複数の Git リポジトリに関する関連情報を表示します。
ファイルシステムから読み取るのみで、書き込みは一切行いません。
このツールは用途が限定されているように見えるかもしれませんが、それは設計上の意図です。

デフォルトでは、`gfold` はカレント作業ディレクトリからのトラバーサルによってすべての Git リポジトリを検出します。
別のディレクトリを対象にしたい場合は、そのパス（相対または絶対）を最初の引数として渡すか、設定ファイルでデフォルトパスを変更できます。

トラバーサル後、`gfold` は [rayon](https://github.com/rayon-rs/rayon) を活用して検出されたすべての Git リポジトリの並行かつ読み取り専用の解析を行います。
解析は [git2-rs](https://github.com/rust-lang/git2-rs) ライブラリを利用して実施されます。

## 使い方

このアプリケーションのすべてのオプションを見るには、`-h/--help` フラグを指定してください。

```shell
# Operate in the current working directory or in the location provided by a config file, if one exists.
gfold

# Operate in the parent directory.
gfold ..

# Operate in the home directory (first method).
gfold $HOME

# Operate in the home directory (second method).
gfold ~/

# Operate with an absolute path.
gfold /this/is/an/absolute/path

# Operate with a relative path.
gfold ../../this/is/a/relative/path

# Operate with three paths.
gfold ~/src ~/projects ~/code
```
### 設定ファイル

同じ引数を頻繁に指定する場合は、設定ファイルを作成して使用することができます。  
`gfold` はデフォルトで設定ファイルを持っておらず、設定ファイルの使用は完全に任意です。

どのように機能するのか？  
実行時に `gfold` は以下のパス（順番に）で設定ファイルを探します：

- `$XDG_CONFIG_HOME/gfold.toml`  
- `$XDG_CONFIG_HOME/gfold/config.toml`  
- `$HOME/.config/gfold.toml`  

`$XDG_CONFIG_HOME` は文字通り `XDG_CONFIG_HOME` 環境変数を指しますが、未設定の場合は適切なOS固有のパスにフォールバックします（詳細は [`user_dirs`](https://github.com/uncenter/user_dirs) を参照）。

設定ファイルが見つかると、`gfold` はそれを読み込み、指定されたオプションを使用します。

設定ファイルの作成には、`--dry-run` フラグを使って有効なTOMLを出力できます。  
以下はmacOS、Linuxおよび類似プラットフォームでの設定ファイル作成の例です：


```shell
gfold -d classic -c never ~/ --dry-run > $HOME/.config/gfold.toml
```

以下は、生成された設定ファイルの内容です：

```toml
paths = ['/home/neloth']
display_mode = 'Classic'
color_mode = 'Never'
```

たとえば、設定ファイルを作成したが、まったく異なる設定で `gfold` を実行したい場合、かつ設定ファイルからオプションを誤って継承しないようにしたい場合があります。  
そのような場合は、`-i` フラグを使用して設定ファイルを無視することができます。


```shell
gfold -i
```
同じフラグを使用して、設定ファイルをデフォルトに戻すことができます。


```shell
gfold -i > $HOME/.config/gfold.toml
```
さらに、既存の設定ファイルを無視し、特定のオプションを設定し、指定されていないオプションにはすべてデフォルト値を使用することができます。  
以下は、クラシックディスプレイモードを使用し、他のすべての設定をデフォルト値で上書きしたい場合の例です：  
  

```shell
gfold -i -d classic > $HOME/.config/gfold.toml
```

設定ファイルをバックアップし、その履歴を `git` で追跡できます。  
macOS、Linux、およびほとんどのシステムでは、ファイルを `git` リポジトリにリンクできます。  

```shell
ln -s <path-to-repository>/gfold.toml $HOME/.config/gfold.toml
```
今、リポジトリ内の設定ファイルを更新し、環境設定ワークフローの一部としてリンクを含めることができます。

## インストール

[![パッケージ状況](https://repology.org/badge/vertical-allrepos/gfold.svg)](https://repology.org/project/gfold/versions)

### Homebrew（macOSおよびLinux）

[Homebrew](https://brew.sh)を使用して、[コアフォーミュラ](https://formulae.brew.sh/formula/gfold)から`gfold`をインストールできます。

ただし、macOSで`brew`を使って[coreutils](https://formulae.brew.sh/formula/coreutils)がインストールされている場合、名前の衝突が発生することがあります。
詳細および回避策については、[トラブルシューティング](#troubleshooting-and-known-issues)セクションを参照してください。


```shell
brew install gfold
```

### Arch Linux

[extraリポジトリ](https://archlinux.org/packages/extra/x86_64/gfold/)から`gfold`をインストールするには、[pacman](https://wiki.archlinux.org/title/Pacman)を使用できます。

```shell
pacman -S gfold
```

### Nix と NixOS

`gfold` は [nixpkgs](https://github.com/NixOS/nixpkgs/blob/master/pkgs/applications/version-management/gfold/default.nix) からインストールできます:

```shell
nix-env --install gfold
```

もし[flakes](https://nixos.wiki/wiki/Flakes)を使用している場合は、`nix`コマンドを直接使ってインストールできます。

```shell
nix profile install "nixpkgs#gfold"
```

### Cargo

ほぼすべてのプラットフォームで[crate](https://crates.io/crates/gfold)をインストールするために、[cargo](https://crates.io)を使用できます。

```shell
cargo install gfold
```

`Cargo.lock`を使用する場合は、`--locked`フラグを使用してください。

```shell
cargo install --locked gfold
```

クレートを最新の状態に保つのは、[cargo-update](https://crates.io/crates/cargo-update) を使えば簡単です。

```shell
cargo install cargo-update
cargo install-update -a
```
### バイナリのダウンロード

上記のインストール方法を使用したくない場合やリポジトリをクローンしたくない場合は、[リリース](https://github.com/nickgerace/gfold/releases)ページからバイナリをダウンロードできます。  
その方法の例については、[マニュアルインストール](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md)ガイドを参照してください。

### ソースからのビルド

ソースからビルドする方法の例については、[マニュアルインストール](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md)ガイドを参照してください。

### 廃止予定: Homebrew Tap（macOSのみ）

[nickgerace/homebrew-nickgerace にある tap](https://github.com/nickgerace/homebrew-nickgerace/blob/main/Formula/gfold.rb)は廃止されました。  
代わりに前述の Homebrew のコアパッケージを使用してください。

### 推奨されるインストール方法がリストにない？

ぜひ[イシューを投稿](https://github.com/nickgerace/gfold/issues/new)してください！

## 互換性

`gfold` は _すべての_ tier one Rust 🦀 ターゲットで動作することを意図しています。  
対応していないプラットフォームがある場合は、[イシューを投稿](https://github.com/nickgerace/gfold/issues)してください。

## トラブルシューティングと既知の問題

予期しない動作やバグに遭遇し、詳細を確認したい場合は、詳細出力を増やして実行してください。


```shell
gfold -vvv
```
問題が解決しない場合は、[issueを報告してください](https://github.com/nickgerace/gfold/issues)。
問題解決のために、実行時の関連ログを_機微な部分を伏せて_添付してください。

### macOSでのCoreutilsの衝突

macOSに`brew`で[GNU Coreutils](https://www.gnu.org/software/coreutils/)の`fold`がインストールされると、名前は`gfold`になります。
この衝突はシェルエイリアス、シェル関数、または`PATH`の変更で回避可能です。
以下は`gfold`から`o`を外した例です：


```shell
alias gfld=$HOME/.cargo/bin/gfold
```

## コミュニティ

詳細情報およびユーザーや「コミュニティ」全体への感謝については、**[COMMUNITY THANKS](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/COMMUNITY_THANKS.md)** ファイルを参照してください。

- [NixOS、Arch Linuxなどのパッケージ](https://repology.org/project/gfold/versions)
- [`gfold`を取り上げた記事「One Hundred Rust Binaries」](https://www.wezm.net/v2/posts/2020/100-rust-binaries/page2/)
- [`gfold`用の`neovim`プラグイン [nvim-gfold.lua](https://github.com/AckslD/nvim-gfold.lua) _（[Reddit発表投稿](https://www.reddit.com/r/neovim/comments/t209wy/introducing_nvimgfoldlua/)）_]


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-04

---