# cleed

命令行的简单订阅源阅读器。

![测试](https://github.com/radulucut/cleed/actions/workflows/tests.yml/badge.svg)

![截图](https://raw.githubusercontent.com/radulucut/cleed/main/./screenshot.png)

## 安装

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
#### 来自源头


```bash
go run main.go
```

#### 二进制文件

从 [releases](https://github.com/radulucut/cleed/releases) 页面下载最新的二进制文件。

## 使用方法

#### 关注订阅源

```bash
# Add a feed to the default list
cleed follow https://example.com/feed.xml

# Add multiple feeds to a list
cleed follow https://example.com/feed.xml https://example2.com/feed --list mylist
```

#### 显示源  

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
#### 取消关注一个动态源


```bash
# Remove a feed from the default list
cleed unfollow https://example.com/feed.xml

# Remove multiple feeds from a list
cleed unfollow https://example.com/feed.xml https://example2.com/feed --list mylist
```

#### 列表提要

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

#### 配置

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

> **颜色映射**
>
> 您可以将提要阅读器中使用的颜色映射为您想要的任何颜色。 如果某些颜色在您的终端中由于您使用的配色方案而不可见，这将非常有用。
>
> 运行 `cleed config --color-range` 查看颜色范围，并使用 `cleed config --map-colors` 命令映射您想要的颜色。

#### Miniflux

```bash
# Push feeds to Miniflux
cleed miniflux push

# Pull feeds from Miniflux
cleed miniflux pull
```

#### 探索动态_feed_

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
> explore 命令需要安装 git 以便获取仓库，并且在探索仓库时只会查看 `.opml` 文件。

#### 自定义数据路径

您可以设置 `CLEED_DATA_PATH` 环境变量来指定数据目录的自定义路径。所有数据将存储在此目录中（配置、缓存等）。

#### 帮助

```bash
cleed --help
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---