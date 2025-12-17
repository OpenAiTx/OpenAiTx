# SSH-List
TUIインターフェースを備えたSSH接続マネージャー。

![demo gif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo.gif)

主な機能:
- 接続の追加と編集
- 接続の並べ替えと整理
- ~/.ssh/configからホストをインポート
- 接続の検索とフィルタリング
- リモートホスト上でのコマンド実行

このアプリケーションは既存のSSH設定ファイルを変更しません。ホスト設定はIncludeディレクティブで参照される複数のファイル（システムとユーザーの設定間も含む）に分散しているため、自動編集は信頼できません。

このアプリケーションはパスワードを保存しません。安全な認証にはSSHキーを使用してください。

## 前提条件
システムにOpenSSHクライアントがインストールされている必要があります。
## GitHubリリースからのインストール
[リリースページ](https://github.com/akinoiro/ssh-list/releases)から最新のバイナリをダウンロードしてください。

#### ターミナルから`ssh-list`コマンドを実行するには:
```
# Make the binary executable
chmod +x ssh-list
# Move it to a directory in your PATH
sudo mv ssh-list /usr/local/bin/
```

## crates.io からインストールする
```
cargo install ssh-list
```
## AUR（Arch Linux）からのインストール
```
paru -S ssh-list
```
## PPAからインストール（Ubuntu、Linux Mint）
```
sudo add-apt-repository ppa:akinoiro/ssh-list
sudo apt update
sudo apt install ssh-list
```
## Homebrewからインストール（macOS、Linux）
```
brew tap akinoiro/tap
brew install ssh-list
```
## ソースからビルド
RustとCargoがインストールされている必要があります。
```
git clone https://github.com/akinoiro/ssh-list
cd ssh-list
cargo build --release
```
バイナリは target/release/ に配置されます
## 設定ファイル
ssh-list は自動的に接続情報を保存するファイルを作成します：
```
~/.ssh/ssh-list.json
```
およびアプリケーション設定：
```
~/.ssh/ssh-list_config.toml
```
## Appearance customization

![demo settingsgif](https://raw.githubusercontent.com/akinoiro/ssh-list/main/images/demo_settings.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-17

---