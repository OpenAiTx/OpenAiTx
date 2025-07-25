# cleed

コマンドライン用のシンプルなフィードリーダー。

![Test](https://github.com/radulucut/cleed/actions/workflows/tests.yml/badge.svg)

![Screenshot](https://raw.githubusercontent.com/radulucut/cleed/main/./screenshot.png)

## インストール

#### MacOS - Homebrew

```bash
brew tap radulucut/cleed
brew install cleed
```

#### Windows - Scoop

```bash
scoop bucket add cleed https://github.com/radulucut/scoop-cleed
scoop install cleed
```
#### ソースから


```bash
go run main.go
```

#### バイナリ

最新のバイナリは[リリース](https://github.com/radulucut/cleed/releases)ページからダウンロードしてください。

## 使い方

#### フィードをフォローする

```bash
# Add a feed to the default list
cleed follow https://example.com/feed.xml

# Add multiple feeds to a list
cleed follow https://example.com/feed.xml https://example2.com/feed --list mylist
```

#### フィードの表示

```bash
# Display feeds from all lists
cleed

# Display feeds from a specific list
cleed --list my-list

# Display feeds since a specific date
cleed --since "2024-01-01 12:03:04"

# Display feeds since a specific period
cleed --since "1d"

# Display feeds since the last run
cleed --since last

# Display feeds from a specific list and limit the number of items
cleed --list my-list --limit 10

# Search for items
cleed --search "keyword" --limit 10

# Search for items in cached feeds
cleed --search "keyword" -C

# Using a proxy
cleed --proxy socks5://user:password@proxy.example.com:8080
```

#### フィードのフォローを解除する

```bash
# Remove a feed from the default list
cleed unfollow https://example.com/feed.xml

# Remove multiple feeds from a list
cleed unfollow https://example.com/feed.xml https://example2.com/feed --list mylist
```

#### リストフィード

```bash
# Show all lists
cleed list

# Show all feeds in a list
cleed list mylist

# Rename a list
cleed list mylist --rename newlist

# Merge a list. Move all feeds from anotherlist to mylist and remove anotherlist
cleed list mylist --merge anotherlist

# Remove a list
cleed list mylist --remove

# Import feeds from a file
cleed list mylist --import-from-file feeds.txt

# Import feeds from an OPML file
cleed list mylist --import-from-opml feeds.opml

# Export feeds to a file
cleed list mylist --export-to-file feeds.txt

# Export feeds to an OPML file
cleed list mylist --export-to-opml feeds.opml

# Export only cached feeds to an OPML file
cleed list --export-to-opml feeds.opml -C
```

#### 設定

```bash
# Display configuration
cleed config

# Set the user agent
cleed config --user-agent="My User Agent"

# Disable styling
cleed config --styling=2

# Map color 0 to 230 and color 1 to 213
cleed config --map-colors=0:230,1:213

# Remove color mapping for color 0
cleed config --map-colors=0:

# Clear all color mappings
cleed config --map-colors=

# Display color range. Useful for finding colors to map
cleed config --color-range

# Enable run summary
cleed config --summary=1

# Set the miniflux token
cleed config --miniflux-token="your_token_here"`
```

> **色のマッピング**
>
> フィードリーダーで使用される色を任意の色にマッピングできます。これは、使用しているカラースキームによって特定の色が端末で見えにくい場合に便利です。
>
> `cleed config --color-range` を実行して色の範囲を確認し、`cleed config --map-colors` コマンドで希望の色をマッピングしてください。

#### Miniflux

```bash
# Push feeds to Miniflux
cleed miniflux push

# Pull feeds from Miniflux
cleed miniflux pull
```

#### フィードを探索する

```bash
# Explore feeds from the default repository (https://github.com/radulucut/cleed-explore)
cleed explore

# Fetch the latest changes and explore feeds from the default repository
cleed explore --update

# Explore feeds from a repository
cleed explore https://github.com/radulucut/cleed-explore.git

# Limit the number of items to display from each list
cleed explore --limit 5

# Search for items (title, description)
cleed explore --search "news"

# Import all feeds into my feeds
cleed explore --import --limit 0

# Import feeds from search results
cleed explore --import --search "news"

# Remove a repository
cleed explore https://github.com/radulucut/cleed-explore.git --remove
```

> **注意**
>
> exploreコマンドはリポジトリを取得するためにgitがインストールされていることを前提としており、リポジトリを探索する際には`.opml`ファイルのみを参照します。

#### カスタムデータパス

`CLEED_DATA_PATH`環境変数を設定することで、データディレクトリのカスタムパスを指定できます。すべてのデータ（設定、キャッシュなど）はこのディレクトリに保存されます。

#### ヘルプ

```bash
cleed --help
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---