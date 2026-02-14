![mpv streaming a torrent](https://github.com/mrxdst/webtorrent-mpv-hook/raw/master/.github/poster.png)

# webtorrent-mpv-hook
[![npm](https://img.shields.io/npm/v/webtorrent-mpv-hook)](https://www.npmjs.com/package/webtorrent-mpv-hook)
[![mpv](https://img.shields.io/badge/mpv-v0.41.0-blue)](https://mpv.io/)

mpvが[webtorrent](https://github.com/webtorrent/webtorrent)を使用してトレントをストリーミング再生できるようにするフックを追加します。  


## 前提条件

* node.js

## インストール

1. `npm install --global webtorrent-mpv-hook`
2. mpvのスクリプトフォルダにスクリプトファイルへのシンボリックリンクを作成する必要があります。  
   指示を表示するには`webtorrent-mpv-hook`を実行してください。  
   この操作は一度だけ行えば十分です。

sudoなしでのLinuxインストールについては[こちら](https://github.com/mrxdst/webtorrent-mpv-hook/issues/44)を参照してください。

## 更新

`npm update --global webtorrent-mpv-hook`

## 使い方

`mpv <torrent-id>`

ここで`torrent-id`は以下のいずれかです：
* マグネットリンク
* info-hash
* `.torrent`ファイルのパスまたはURL

情報/進行状況を示すオーバーレイが表示されます。再生開始時に自動的に閉じられます。  
`p`（デフォルト）で手動で切り替えることもできます。

> 複数ファイルのトレントはプレイリストとして開かれます。

## 設定

デフォルト値は以下の通りです。

### `input.conf`

```properties
# Toggles info/progress overlay.
p script-binding webtorrent/toggle-info
```

### `script-opts/webtorrent.conf`
```properties
# Path to save downloaded files in. Can be set to "memory" to store all files in RAM.
path=./
# Maximum number of connections.
maxConns=100
# Port to use for webtorrent web-server.
# If it's already in use a random port will be chosen instead.
port=8888
# Enable μTP support.
utp=yes
# Enable DHT.
dht=yes
# Enable local service discovery.
lsd=yes
# Download speed limit in bytes/sec.
downloadLimit=-1
# Upload speed limit in bytes/sec.
uploadLimit=-1
# Specify the node command to use.
# Usefull if the command is called nodejs on your system.
node_path=node

# The same text style options as in stats.conf is also available.
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-14

---