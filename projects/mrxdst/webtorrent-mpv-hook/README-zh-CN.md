![mpv 流式传输种子](https://github.com/mrxdst/webtorrent-mpv-hook/raw/master/.github/poster.png)

# webtorrent-mpv-hook
[![npm](https://img.shields.io/npm/v/webtorrent-mpv-hook)](https://www.npmjs.com/package/webtorrent-mpv-hook)
[![mpv](https://img.shields.io/badge/mpv-v0.41.0-blue)](https://mpv.io/)

添加一个钩子，允许 mpv 使用 [webtorrent](https://github.com/webtorrent/webtorrent) 流式传输种子。  


## 前提条件

* node.js

## 安装

1. `npm install --global webtorrent-mpv-hook`
2. 你需要将一个脚本文件符号链接到你的 mpv 脚本文件夹。  
   运行 `webtorrent-mpv-hook` 获取说明。  
   你只需执行一次。

对于无需 sudo 的 Linux 安装可以尝试[这里](https://github.com/mrxdst/webtorrent-mpv-hook/issues/44)。

## 更新

`npm update --global webtorrent-mpv-hook`

## 用法

`mpv <torrent-id>`

其中 `torrent-id` 可以是：
* 磁力链接
* 信息哈希
* 指向 `.torrent` 文件的路径或 URL

会显示带有信息/进度的叠加层。播放开始时它会自动关闭。  
也可以通过 `p`（默认）手动切换。

> 多文件种子将作为播放列表打开。

## 配置

默认值如下所示。

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