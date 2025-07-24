# Reddittui
コマンドラインからRedditを閲覧するための軽量ターミナルアプリケーション。[bubbletea](https://github.com/charmbracelet/bubbletea)によって動作します

## 機能
- **サブレディット閲覧:** お気に入りのサブレディットをナビゲートします。
- **投稿閲覧:** テキスト投稿とコメントを読むことができます。
- **キーボードナビゲーション:** vim/標準のキーボードショートカットで投稿をスクロールおよび選択します。
- **設定可能:** キャッシュ動作のカスタマイズや設定ファイルを使ったサブレディットフィルターの定義が可能です

## デモ
https://github.com/user-attachments/assets/40d61ef3-3a95-4a26-8c49-bec616f6ae1c

## インストール

### Git
#### 前提条件
- **Git**
- **Go:** バージョン1.16以上
- **ターミナル:** Unix系ターミナル（Linux、macOS、または類似環境）
- **POSIXユーティリティ:** インストールには`install`コマンドを使用します。これはLinuxとmacOSの両方で利用可能です。

リポジトリをクローンし、インストールスクリプトを実行します：

```bash
git clone https://github.com/tonymajestro/reddit-tui.git reddittui
cd reddittui
./install.sh
```

reddittuiを削除するには、アンインストールスクリプトを実行してください：

```bash
./uninstall.sh
```

### Arch
Archユーザーはyayや他のAURヘルパーを使ってAURからreddittuiをインストールできます。

[プリコンパイル済み](https://aur.archlinux.org/packages/reddit-tui-bin)と[ソースパッケージ](https://aur.archlinux.org/packages/reddit-tui)が利用可能です。

```bash
yay -S reddit-tui-bin
```

```bash
yay -S reddit-tui
```

### Nix
Nixユーザーはシェルで試すか、次のようにシステム設定に追加できます。
```bash
nix-shell -p reddit-tui
```
```nix
  environment.systemPackages = [
      pkgs.reddit-tui
    ];
```

## 使用方法
インストールされたバイナリをお好みのターミナルから実行してください：

```bash
# Open reddittui, navigating to the home page
reddittui

# Open reddittui, navigating to a specific subreddit
reddittui --subreddit dogs

# Open reddittui, navigating to a specific post by its ID
reddittui --post 1iyuce4
```
## キーバインディング
- ナビゲーション
  - **h, j, k, l:** Vim移動
  - **left, right, up, down:** 通常移動
  - **g**: ページの先頭へ移動
  - **G**: ページの最後へ移動
  - **s**: サブレディット切替
- 投稿ページ
  - **L**: 投稿をさらに読み込む
- コメントページ
  - **o**: 投稿リンクをブラウザで開く
  - **c**: コメントを折りたたむ
- その他
  - **H:** ホームページへ移動
  - **backspace**: 戻る
  - **q, esc**: reddittuiを終了

## 設定ファイル
reddittuiバイナリを実行すると、以下のファイルが初期化されます:
- 設定ファイル:
  - `~/.config/reddittui/reddittui.toml`
- ログファイル:
  - `~/.local/state/reddittui.log`
- キャッシュ
  - `~/.cache/reddittui/`

サンプル設定:

```toml
# Core configuration
[core]
bypassCache = false
logLevel = "Warn"

# Filter out posts containing keywords or belonging to certain subreddits
[filter]
subreddits = ["news", "politics"]
keywords = ["pizza", "pineapple"]

# Configure client timeout and cache TTL. By default, subreddit posts and comments are cached for 1 hour.
[client]
timeoutSeconds = 10
cacheTtlSeconds = 3600

# Configure which reddit server to use. Default is old.reddit.com but redlib servers are also supported
[server]
domain = "old.reddit.com"
type = "old"
```

## Redlib
プライバシー強化のために、プライベートな[Redlibバックエンド](https://github.com/redlib-org/redlib)がサポートされています。Redlibサーバーの一覧は[こちら](https://github.com/redlib-org/redlib-instances/blob/main/instances.json)から確認できます。old.reddit.comの代わりにRedlibサーバーを使用するには、以下の設定を使用してください：

```toml
[server]
domain = "safereddit.com"
type = "redlib"
```

## 謝辞
Reddittuiは[ bubbletea ](https://github.com/charmbracelet/bubbletea)フレームワークに基づいています。また、ハッカーニュースのターミナルブラウザである[circumflex](https://github.com/bensadeh/circumflex)からもインスピレーションを得ています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---