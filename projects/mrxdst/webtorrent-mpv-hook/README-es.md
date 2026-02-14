![mpv transmitiendo un torrent](https://github.com/mrxdst/webtorrent-mpv-hook/raw/master/.github/poster.png)

# webtorrent-mpv-hook
[![npm](https://img.shields.io/npm/v/webtorrent-mpv-hook)](https://www.npmjs.com/package/webtorrent-mpv-hook)
[![mpv](https://img.shields.io/badge/mpv-v0.41.0-blue)](https://mpv.io/)

Agrega un hook que permite a mpv transmitir torrents usando [webtorrent](https://github.com/webtorrent/webtorrent).  


## Requisitos previos

* node.js

## Instalación

1. `npm install --global webtorrent-mpv-hook`
2. Necesitas crear un enlace simbólico a un archivo de script en la carpeta de scripts de tu mpv.  
   Ejecuta `webtorrent-mpv-hook` para instrucciones.  
   Solo necesitas hacer esto una vez.

Para instalación en Linux sin sudo puedes probar [esto](https://github.com/mrxdst/webtorrent-mpv-hook/issues/44).

## Actualización

`npm update --global webtorrent-mpv-hook`

## Uso

`mpv <torrent-id>`

Donde `torrent-id` es uno de:
* enlace magnet
* info-hash
* ruta o url a un archivo `.torrent`

Se mostrará una superposición con información/progreso. Se cerrará automáticamente cuando comience la reproducción.  
También puede activarse o desactivarse manualmente con `p` (por defecto).

> Los torrents con múltiples archivos se abren como una lista de reproducción.

## Configuración

Los valores predeterminados se muestran a continuación.

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