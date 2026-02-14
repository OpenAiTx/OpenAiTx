![mpv 스트리밍 토렌트](https://github.com/mrxdst/webtorrent-mpv-hook/raw/master/.github/poster.png)

# webtorrent-mpv-hook
[![npm](https://img.shields.io/npm/v/webtorrent-mpv-hook)](https://www.npmjs.com/package/webtorrent-mpv-hook)
[![mpv](https://img.shields.io/badge/mpv-v0.41.0-blue)](https://mpv.io/)

mpv가 [webtorrent](https://github.com/webtorrent/webtorrent)를 사용하여 토렌트를 스트리밍할 수 있도록 하는 훅을 추가합니다.  


## 사전 요구사항

* node.js

## 설치

1. `npm install --global webtorrent-mpv-hook`
2. mpv 스크립트 폴더에 스크립트 파일을 심볼릭 링크해야 합니다.  
   자세한 내용은 `webtorrent-mpv-hook` 명령어를 실행하세요.  
   이 작업은 한 번만 하면 됩니다.

sudo 없이 리눅스에 설치하려면 [이 방법](https://github.com/mrxdst/webtorrent-mpv-hook/issues/44)을 시도할 수 있습니다.

## 업데이트

`npm update --global webtorrent-mpv-hook`

## 사용법

`mpv <torrent-id>`

`torrent-id`는 다음 중 하나입니다:
* 마그넷 링크
* 인포 해시
* `.torrent` 파일의 경로 또는 URL

정보/진행 상황이 표시된 오버레이가 나타납니다. 재생이 시작되면 자동으로 닫힙니다.  
`p` 키(기본값)로 수동으로 토글할 수도 있습니다.

> 다중 파일 토렌트는 재생 목록으로 열립니다.

## 구성

기본 값은 아래에 나와 있습니다.

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