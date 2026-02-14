![mpv diffusion d’un torrent](https://github.com/mrxdst/webtorrent-mpv-hook/raw/master/.github/poster.png)

# webtorrent-mpv-hook
[![npm](https://img.shields.io/npm/v/webtorrent-mpv-hook)](https://www.npmjs.com/package/webtorrent-mpv-hook)
[![mpv](https://img.shields.io/badge/mpv-v0.41.0-blue)](https://mpv.io/)

Ajoute un hook qui permet à mpv de diffuser des torrents en utilisant [webtorrent](https://github.com/webtorrent/webtorrent).  


## Prérequis

* node.js

## Installation

1. `npm install --global webtorrent-mpv-hook`
2. Vous devez créer un lien symbolique vers un fichier script dans votre dossier de scripts mpv.  
   Exécutez `webtorrent-mpv-hook` pour les instructions.  
   Vous n’avez besoin de le faire qu’une seule fois.

Pour une installation sous Linux sans sudo, vous pouvez essayer [cela](https://github.com/mrxdst/webtorrent-mpv-hook/issues/44).

## Mise à jour

`npm update --global webtorrent-mpv-hook`

## Utilisation

`mpv <torrent-id>`

Où `torrent-id` est l’un des suivants :
* lien magnet
* info-hash
* chemin ou URL vers un fichier `.torrent`

Une superposition s’affichera avec les informations/progrès. Elle se fermera automatiquement lorsque la lecture commence.  
Elle peut également être activée ou désactivée manuellement avec `p` (par défaut).

> Les torrents multi-fichiers sont ouverts comme une liste de lecture.

## Configuration

Les valeurs par défaut sont indiquées ci-dessous.

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