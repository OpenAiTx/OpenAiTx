# フレームワークシステムTUI

![Rust](https://img.shields.io/badge/lang-rust-orange) ![ratatui](https://img.shields.io/badge/ui-ratatui-blue) ![Framework Laptop](https://img.shields.io/badge/hardware-Framework--Laptop-success)  

Framework Laptopのハードウェアを制御および監視するためのスナッピーなTUIダッシュボード — 充電、プライバシー、照明、USB PDポートなど。

![demo](/docs/screenshots/demo-v0.7.2.gif)

## :octocat: 特徴

### Framework Laptop ハードウェア

- [x] **ライブバッテリーおよび充電状況**（制限および充電制御付き）
- [x] **マイク＆カメラのプライバシートグル**
- [ ] **Input Deckモード**セレクター（Framework 16）
- [x] **キーボード＆指紋照明**制御
- [x] **USB PDポート監視**
- [x] **ファン回転数（RPM）**
- [ ] **熱情報:** CPU/GPU温度
- [x] **システム情報:** BIOS詳細

## インストール

### :dvd: バイナリ

Linux、Windows、FreeBSD向けの事前コンパイル済みバイナリは[Releases](https://github.com/grouzen/framework-tool-tui/releases)ページからダウンロード可能です。

### :memo: ソースから

[ Rust](https://rustup.rs/)（Edition 2024）およびFramework Laptopが必要です。

```sh
git clone https://github.com/grouzen/framework-tool-tui.git
cd framework-tool-tui
cargo build --release
# or via cargo install
cargo install --path .
```

### :penguin: Linux ディストリビューション

#### Gentoo linux

公式の [Gentoo パッケージ](https://packages.gentoo.org/packages/app-laptop/framework-tool-tui) または [lamdness](https://github.com/grouzen/lamdness-overlay/tree/main/app-laptop/framework-tool-tui) オーバーレイで利用可能です

```sh
# Official gentoo repository
sudo emerge -av app-laptop/framework-tool-tui

# or via lamdness overlay
sudo eselect repository enable lamdness
sudo emaint -r lamdness sync
sudo emerge -av app-laptop/framework-tool-tui
```

#### Arch linux

[AUR](https://aur.archlinux.org/packages/framework-tool-tui) または [archlinuxcn](https://github.com/archlinuxcn/repo/tree/master/archlinuxcn/framework-tool-tui) を通じて利用可能です。

```sh
[yay/paru] -S framework-tool-tui # Install from AUR
sudo pacman -S framework-tool-tui # Install from archlinuxcn
```

#### NixOS linux

公式の[NixOSパッケージ](https://search.nixos.org/packages?query=framework-tool-tui)から利用可能です：

```sh
nix-shell -p framework-tool-tui # Install temporarily

# Add to the NixOS configuration or use nix profile to install permanently
```

#### :beer: Linux用Homebrew

[`framework-tool-tui` フォーミュラ](https://formulae.brew.sh/formula/framework-tool-tui)で利用可能

```sh
brew install framework-tool-tui
```

### 😈 FreeBSD


[FreeBSD ports](https://www.freshports.org/sysutils/framework-tool-tui/)で利用可能です。
```sh
pkg install framework-tool-tui
```

### Windows

現時点では、[ソースから](#memo-from-source)または[事前構築済みバイナリから](#dvd-binaries)インストールできます。

## :man: 実行

ハードウェア制御にアクセスするために、root権限で実行する必要があります。

```sh
sudo framework-tool-tui
```

## :pencil: アーキテクチャ

完全な技術的内訳については[ARCHITECTURE.md](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/docs/ARCHITECTURE.md)を参照してください。  
- ハードウェアポーリングは[`framework_lib`](https://github.com/FrameworkComputer/framework-system)を使用

## :handshake: コントリビュート

プルリクエスト歓迎！バグ報告や機能要望はIssuesを参照してください。

### プッシュ前にコードをチェック

コミットとプッシュの前に`cargo make check-all`を実行することを推奨します。

これはシステムに[cargo make](https://github.com/sagiegurari/cargo-make)ランナーがインストールされている必要があります：

```sh
cargo install --force cargo-make
```

### コミットメッセージの規約

本プロジェクトでは、自動バージョニングと変更履歴生成のために[Conventional Commits](https://www.conventionalcommits.org/)を使用しています。コミットメッセージは以下の形式で記述してください:

```
<type>: <description>

[optional body]
```

**一般的なタイプ:**
- `feat:` - 新機能（マイナーバージョンアップをトリガー）
- `fix:` - バグ修正（パッチバージョンアップをトリガー）
- `docs:` - ドキュメントの変更
- `refactor:` - コードのリファクタリング
- `test:` - テストの追加または更新
- `chore:` - メンテナンス作業
- `ci:` - CI/CDの変更

**例:**
```
feat: add thermal monitoring support
fix: correct battery percentage calculation
docs: update installation instructions
```

破壊的変更の場合は、タイプの後に `!` を追加するか、フッターに `BREAKING CHANGE:` を含めてください:
```
feat!: redesign UI layout
```

### 技術スタック

- [ratatui](https://ratatui.rs)
- [tokio](https://tokio.rs)
- [framework_lib](https://github.com/FrameworkComputer/framework-system/tree/main/framework_lib)

## :judge: ライセンス

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

ライセンスおよび依存関係については、[LICENSE](LICENSE) および [Cargo.toml](https://raw.githubusercontent.com/grouzen/framework-tool-tui/main/Cargo.toml:1) を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-09

---