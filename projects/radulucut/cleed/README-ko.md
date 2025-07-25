# cleed

커맨드 라인용 간단한 피드 리더입니다.

![Test](https://github.com/radulucut/cleed/actions/workflows/tests.yml/badge.svg)

![Screenshot](https://raw.githubusercontent.com/radulucut/cleed/main/./screenshot.png)

## 설치

#### MacOS - Homebrew

```bash
brew tap radulucut/cleed
brew install cleed
```
#### 윈도우 - 스쿱


```bash
scoop bucket add cleed https://github.com/radulucut/scoop-cleed
scoop install cleed
```

#### 출처부터

```bash
go run main.go
```

#### 바이너리

[릴리스](https://github.com/radulucut/cleed/releases) 페이지에서 최신 바이너리를 다운로드하세요.

## 사용법

#### 피드 팔로우하기

```bash
# Add a feed to the default list
cleed follow https://example.com/feed.xml

# Add multiple feeds to a list
cleed follow https://example.com/feed.xml https://example2.com/feed --list mylist
```

#### 피드 표시

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

#### 피드 팔로우 취소하기

```bash
# Remove a feed from the default list
cleed unfollow https://example.com/feed.xml

# Remove multiple feeds from a list
cleed unfollow https://example.com/feed.xml https://example2.com/feed --list mylist
```

#### 목록 피드

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

#### 구성

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
> **색상 매핑**
>
> 피드 리더에서 사용되는 색상을 원하는 색상으로 매핑할 수 있습니다. 이는 사용 중인 색상 구성표에 따라 터미널에서 특정 색상이 보이지 않는 경우에 유용합니다.
>
> `cleed config --color-range` 명령어를 실행하여 색상 범위를 확인하고, `cleed config --map-colors` 명령어를 사용하여 원하는 색상을 매핑하세요.

#### Miniflux


```bash
# Push feeds to Miniflux
cleed miniflux push

# Pull feeds from Miniflux
cleed miniflux pull
```

#### 피드 탐색

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

> **참고**
>
> explore 명령은 저장소를 가져오기 위해 git이 설치되어 있어야 하며, 저장소를 탐색할 때 `.opml` 파일만 확인합니다.

#### 사용자 정의 데이터 경로

`CLEED_DATA_PATH` 환경 변수를 설정하여 데이터 디렉토리에 대한 사용자 정의 경로를 지정할 수 있습니다. 모든 데이터는 이 디렉토리에 저장됩니다(설정, 캐시 등).

#### 도움말

```bash
cleed --help
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---