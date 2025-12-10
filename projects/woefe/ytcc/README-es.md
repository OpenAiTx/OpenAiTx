# ytcc
[![lint y prueba](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml/badge.svg)](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml)

Herramienta de línea de comandos para hacer seguimiento de tus listas de reproducción favoritas en YouTube y muchos otros lugares.

## Instalación
```shell script
pipx install ytcc
```
Los métodos de instalación alternativos se describen en la [documentación](https://github.com/woefe/ytcc/tree/master/doc/install.md).

## Uso

Agregue "suscripciones".  
Tenga en cuenta que `subscribe` no guarda los videos descubiertos en la base de datos.  
Ejecute `ytcc update` para verificar y obtener los metadatos de los videos después de suscribirse.
```shell script
# Any playlist supported by yt-dlp (or youtube-dl)
ytcc subscribe "Jupiter Broadcasting" "https://www.youtube.com/c/JupiterBroadcasting/videos"
ytcc subscribe "NCS: House" "https://www.youtube.com/playlist?list=PLRBp0Fe2GpgmsW46rJyudVFlY6IYjFBIK"
ytcc subscribe "Neus" "https://soundcloud.com/neus/tracks"

# RSS feed podcasts
ytcc subscribe "LINUX Unplugged" "https://linuxunplugged.com/rss"
ytcc subscribe "Darknet Diaries" "https://feeds.megaphone.fm/darknetdiaries"
```
Importa suscripciones desde [Google Takeout](https://takeout.google.com/).
*Consejo*: Al solicitar un takeout, asegúrate de seleccionar solo los datos de YouTube, de lo contrario, el takeout podría tardar bastante en completarse.

```shell script
ytcc import ~/Downloads/Takeout/Youtube/subscriptions/subscriptions.csv
```
Obtener metadatos de nuevos videos.

```shell script
ytcc update
```

Lista de videos no vistos.
```shell script
ytcc list
```
Listar el contenido de la lista de reproducción en formato JSON.

```shell script
ytcc --output json list --playlist "NCS: House" --since 2020-07-07 --watched --unwatched
```

Lista todos los videos como un feed RSS.
```shell script
ytcc --output rss list --watched --unwatched
```
Inicie la interfaz de terminal interactiva.

```shell script
ytcc tui
```
Marcar todos los videos de una lista de reproducción como vistos sin reproducirlos.

```shell script
ytcc ls -p "Jupiter Broadcasting" | ytcc mark
```

Escucha música sin limitaciones.
```shell script
ytcc ls -p "NCS: House" | ytcc play --audio-only
```

**Interfaz alternativa de terminal con soporte para miniaturas.**
Requiere [fzf](https://github.com/junegunn/fzf) versión 0.23.1 o superior, opcionalmente [curl](https://curl.se/) y ya sea [ueberzug](https://github.com/seebye/ueberzug) o [kitty](https://sw.kovidgoyal.net/kitty/).
El script se instala automáticamente en la mayoría de las plataformas durante la instalación de ytcc.
Si no está instalado, puedes descargarlo desde [aquí](https://github.com/woefe/ytcc/tree/master/scripts/ytccf.sh).
```shell script
ytccf.sh

# Show help and key bindings
ytccf.sh --help
```

## Configuración
Ytcc busca un archivo de configuración en las siguientes ubicaciones:

1. El archivo proporcionado con las opciones `-c` o `--config`
2. `~/.ytcc.conf`
3. `$XDG_CONFIG_HOME/ytcc/ytcc.conf` o `~/.config/ytcc/ytcc.conf`
4. `/etc/ytcc/ytcc.conf`

Si no se encuentra un archivo de configuración en estas ubicaciones, se crea un archivo de configuración predeterminado en `$XDG_CONFIG_HOME/ytcc/ytcc.conf` o `~/.config/ytcc/ytcc.conf`

### Ejemplo de configuración

```ini
[ytcc]

# Directory where downloads are saved, when --path is not given
download_dir = ~/Downloads

# Downloads videos to subdirectories by playlist name. If a video is on multiple playlists, ytcc
# will download the video only to one subdirectory and symlink it to the other subdirectories.
download_subdirs = on

# Parameters passed to mpv. Adjusting these might break video playback in ytcc!
mpv_flags = --ytdl --ytdl-format=bestvideo[height<=?1080]+bestaudio/best

# Defines the order of video listings.
# Possible options: id, url, title, description, publish_date, watched, duration, extractor_hash,
# playlists. Every option must be suffixed with :desc or :asc for descending or ascending sort.
order_by = playlists:asc, publish_date:desc

# Default attributes shown in video listings.
# Some ytcc commands allow overriding the default set here in the config.
video_attrs = id, title, publish_date, duration, playlists

# Default attributes shown in playlist/subscription listings.
# Some ytcc commands allow overriding the default set here in the config.
playlist_attrs = name, url, reverse, tags

# Path where the database is stored.
# Can be used to sync the database between multiple machines.
db_path = ~/.local/share/ytcc/ytcc.db

# The format of used to print dates
date_format = %Y-%m-%d

# Default failure threshold before a video is ignored.
# When a video could not be updated repeatedly, it will be ignored by ytcc after `max_update_fail`
# attempts. This setting can be overridden with the --max-fail commandline parameter.
max_update_fail = 5

# Default update backlog.
# The update command will only check the first `max_update_backlog` videos of a playlist to improve
# performance. This setting can be overridden with the --max-backlog commandline parameter.
max_update_backlog = 20

# Ignore videos that have an age limit higher than the one specified here.
age_limit = 0

# Skips livestreams.
skip_live_stream = true

# Skips private and member-only videos.
skip_non_public = true

# Prompt and table colors. Supports 256 colors. Hence, values between 0-255 are allowed.
# See https://en.wikipedia.org/wiki/ANSI_escape_code#8-bit for the color codes.
[theme]
prompt_download_audio = 2
prompt_download_video = 4
prompt_play_audio = 2
prompt_play_video = 4
prompt_mark_watched = 1
table_alternate_background = 245
plain_label_text = 244


[tui]
# The characters to use for selecting videos in interactive mode.
alphabet = sdfervghnuiojkl

# Default action of interactive mode.
# Possible options: play_video, play_audio, mark_watched, download_audio, download_video
default_action = play_video


[youtube_dl]
# Format (see FORMAT SELECTION in yt-dlp manpage). Make sure to use a video format here, if you
# want to be able to download videos.
format = bestvideo[height<=?1080]+bestaudio/best

# Output template (see OUTPUT TEMPLATE in yt-dlp manpage).
# Note that the output template will be prefixed with the `download_dir` directory and the name of
# the playlist if `download_sub_dir` is enabled.
output_template = %(title)s.%(ext)s

# If a merge is required according to format selection, merge to the given container format.
# One of mkv, mp4, ogg, webm, flv
merge_output_format = mkv

# Limit download speed to the given bytes/second. Set 0 for no limit.
# E.g. limit to one megabyte per second
#ratelimit = 1000000
ratelimit = 0

# Set number of retries before giving up on a download.
# Set 0 for no retries.
retries = 0

# Subtitles for videos.
# If enabled and available, automatic and manual subtitles for selected languages are embedded in
# the video.
#subtitles = en,de
subtitles = off

# Embed the youtube thumbnail in audio downloads.
# Transforms the resulting file to m4a, if enabled.
thumbnail = on

# Don't download videos longer than 'max_duration' seconds.
# 0 disables the limit.
max_duration = 9000

# Restrict filenames to only ASCII characters and avoid "&" and spaces in filenames.
restrict_filenames = off
```

### Configuración de mpv
Ytcc utiliza [mpv](https://mpv.io) para reproducir videos.
Puedes configurar mpv para integrarlo bien con ytcc.
Los detalles están documentados [aquí](https://github.com/woefe/ytcc/tree/master/doc/mpv.md).


## Reporte de problemas
Crea un nuevo problema en el [rastreador de problemas de GitHub](https://github.com/woefe/ytcc/issues/new).
Describe el problema con el mayor detalle posible, ¡y por favor usa las plantillas de problemas, si es posible!
**Importante**: Recuerda incluir la salida de `ytcc bug-report` en los reportes de errores.
También puede ayudar mucho ejecutar ytcc con la opción `--loglevel debug` e incluir la salida en tu reporte.

## Desarrollo
Usamos [hatch](https://hatch.pypa.io/latest/) para el desarrollo.

```shell
hatch env create
hatch shell

# Verify successful install
ytcc --help
```
Ejecute los siguientes comandos antes de cada solicitud de extracción y corrija las advertencias o errores que produzcan.

```shell script
hatch fmt --check
hatch test
```
### Dependencias externas
Requisitos opcionales:
- [ffmpeg](https://ffmpeg.org/) para la fusión de archivos `.mp4` o `.mkv`
- [mpv](https://mpv.io/), si desea reproducir audio o video

Requisitos para el script bash ytccf.sh:
- [fzf](https://github.com/junegunn/fzf) versión 0.23.1 o superior
- Opcionalmente, para soporte de miniaturas
    - [curl](https://curl.se/)
    - Ya sea [ueberzug](https://github.com/seebye/ueberzug) o [kitty](https://sw.kovidgoyal.net/kitty/).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---