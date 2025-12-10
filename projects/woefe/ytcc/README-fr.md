# ytcc
[![lint et test](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml/badge.svg)](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml)

Outil en ligne de commande pour suivre vos playlists préférées sur YouTube et bien d'autres endroits.

## Installation
```shell script
pipx install ytcc
```
Des méthodes d'installation alternatives sont décrites dans la [documentation](https://github.com/woefe/ytcc/tree/master/doc/install.md).

## Utilisation

Ajoutez des "abonnements".
Notez que `subscribe` n'enregistre pas les vidéos découvertes dans la base de données.
Exécutez `ytcc update` pour vérifier et récupérer les métadonnées des vidéos après l'abonnement.
```shell script
# Any playlist supported by yt-dlp (or youtube-dl)
ytcc subscribe "Jupiter Broadcasting" "https://www.youtube.com/c/JupiterBroadcasting/videos"
ytcc subscribe "NCS: House" "https://www.youtube.com/playlist?list=PLRBp0Fe2GpgmsW46rJyudVFlY6IYjFBIK"
ytcc subscribe "Neus" "https://soundcloud.com/neus/tracks"

# RSS feed podcasts
ytcc subscribe "LINUX Unplugged" "https://linuxunplugged.com/rss"
ytcc subscribe "Darknet Diaries" "https://feeds.megaphone.fm/darknetdiaries"
```
Importer les abonnements depuis [Google Takeout](https://takeout.google.com/).  
*Astuce* : Lors de la demande d’un takeout, assurez-vous de ne sélectionner que les données YouTube, sinon le takeout pourrait prendre beaucoup de temps à se terminer.

```shell script
ytcc import ~/Downloads/Takeout/Youtube/subscriptions/subscriptions.csv
```

Récupérer les métadonnées des nouvelles vidéos.
```shell script
ytcc update
```
Lister les vidéos non regardées.

```shell script
ytcc list
```
Lister le contenu de la playlist au format JSON.

```shell script
ytcc --output json list --playlist "NCS: House" --since 2020-07-07 --watched --unwatched
```
Listez toutes les vidéos sous forme de flux RSS.

```shell script
ytcc --output rss list --watched --unwatched
```

Démarrez l'interface terminal interactive.
```shell script
ytcc tui
```
Marquer toutes les vidéos d'une playlist comme regardées sans les lire.

```shell script
ytcc ls -p "Jupiter Broadcasting" | ytcc mark
```
Écoutez de la musique sans aucune limitation.

```shell script
ytcc ls -p "NCS: House" | ytcc play --audio-only
```

**Interface terminal alternative avec prise en charge des vignettes.**
Nécessite [fzf](https://github.com/junegunn/fzf) version 0.23.1 ou plus récente, éventuellement [curl](https://curl.se/) et soit [ueberzug](https://github.com/seebye/ueberzug) ou [kitty](https://sw.kovidgoyal.net/kitty/).
Le script est automatiquement installé sur la plupart des plateformes lors de l'installation de ytcc.
S'il n'est pas installé, vous pouvez le télécharger depuis [ici](https://github.com/woefe/ytcc/tree/master/scripts/ytccf.sh).
```shell script
ytccf.sh

# Show help and key bindings
ytccf.sh --help
```

## Configuration
Ytcc recherche un fichier de configuration aux emplacements suivants :

1. Le fichier indiqué avec les options `-c` ou `--config`
2. `~/.ytcc.conf`
3. `$XDG_CONFIG_HOME/ytcc/ytcc.conf` ou `~/.config/ytcc/ytcc.conf`
4. `/etc/ytcc/ytcc.conf`

Si aucun fichier de configuration n’est trouvé à ces emplacements, un fichier de configuration par défaut est créé à `$XDG_CONFIG_HOME/ytcc/ytcc.conf` ou `~/.config/ytcc/ytcc.conf`

### Exemple de configuration

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

### Configuration de mpv
Ytcc utilise [mpv](https://mpv.io) pour lire les vidéos.
Vous pouvez configurer mpv pour une intégration optimale avec ytcc.
Les détails sont documentés [ici](https://github.com/woefe/ytcc/tree/master/doc/mpv.md).


## Signaler des problèmes
Créez un nouveau problème sur le [suivi des problèmes GitHub](https://github.com/woefe/ytcc/issues/new).
Décrivez le problème aussi précisément que possible, et veuillez utiliser les modèles de problème, si possible !
**Important** : N’oubliez pas d’inclure la sortie de `ytcc bug-report` dans les rapports de bugs.
Il peut aussi être très utile d’exécuter ytcc avec l’option `--loglevel debug` et d’inclure la sortie dans votre rapport.

## Développement
Nous utilisons [hatch](https://hatch.pypa.io/latest/) pour le développement.

```shell
hatch env create
hatch shell

# Verify successful install
ytcc --help
```
Exécutez les commandes suivantes avant chaque demande de tirage et corrigez les avertissements ou erreurs qu'elles produisent.

```shell script
hatch fmt --check
hatch test
```

### Dépendances externes
Exigences optionnelles :
- [ffmpeg](https://ffmpeg.org/) pour la fusion de fichiers `.mp4` ou `.mkv`
- [mpv](https://mpv.io/), si vous souhaitez lire de l’audio ou de la vidéo

Exigences pour le script bash ytccf.sh :
- [fzf](https://github.com/junegunn/fzf) version 0.23.1 ou plus récente
- Optionnellement, pour la prise en charge des vignettes
    - [curl](https://curl.se/)
    - Soit [ueberzug](https://github.com/seebye/ueberzug) soit [kitty](https://sw.kovidgoyal.net/kitty/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---