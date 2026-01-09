# twitch-dlp

Descarga cualquier VOD de Twitch desde el inicio durante la transmisión en vivo

## Características

- Descargar VODs en vivo desde el inicio (`--live-from-start`)
- Descargar VODs ocultos en curso (o si estuvieron ocultos durante la transmisión)
- Descargar VODs ocultos terminados
  - Solo usa enlaces de [twitchtracker.com](https://twitchtracker.com), [streamscharts.com](https://streamscharts.com) o [sullygnome.com](https://sullygnome.com) ([detalles](https://github.com/DmitryScaletta/twitch-dlp/blob/master/DOWNLOAD_PRIVATE_VIDEOS.md))
- Descargar parte específica del video (`--download-sections`)
- Descargar clips (incluidas versiones en retrato)
- Desmutear automáticamente secciones silenciadas si es posible
- Continuar descargando video parcialmente descargado (en caso de corte de red/energía)
- Vigilar estado del canal. Si se vuelve en vivo, comenzar a descargar (`--retry-streams DELAY`)
- Similar a la sintaxis de `yt-dlp` (`youtube-dl`)

## Uso

Instala la última versión de [Node.js](https://nodejs.org/) (v22 o superior).

```bash
# npm (comes with Node.js)
npx twitch-dlp LINK

# pnpm
pnpm dlx twitch-dlp LINK

# yarn v2+
yarn dlx twitch-dlp LINK

# bun
bunx twitch-dlp LINK
```

### Ejemplos

```bash
# Download a VOD from start using channel link, continue until stream ends
npx twitch-dlp https://www.twitch.tv/xqc --live-from-start

# Download a VOD
npx twitch-dlp https://www.twitch.tv/videos/2022789761

# Download live stream from the current time using streamlink
npx twitch-dlp https://www.twitch.tv/xqc

# Download a hidden VOD
# Just use twitchtracker.com, streamscharts.com or sullygnome.com links
npx twitch-dlp https://twitchtracker.com/xqc/streams/51582913581
npx twitch-dlp https://streamscharts.com/channels/lirik/streams/51579711693
npx twitch-dlp https://sullygnome.com/channel/summit1g/stream/315782796250
# If it doesn't work for you, follow this instructions:
# https://github.com/DmitryScaletta/twitch-dlp/blob/master/DOWNLOAD_PRIVATE_VIDEOS.md

# Check every 60 seconds is channel live
# If it's live, start to download it using streamlink
npx twitch-dlp https://www.twitch.tv/xqc --retry-streams 60

# Check every 60 seconds is channel live
# If it's live, start to download it's VOD from start
npx twitch-dlp https://www.twitch.tv/xqc --retry-streams 60 --live-from-start

# Download 10 minutes in the middle of the VOD
npx twitch-dlp https://www.twitch.tv/videos/2022789761 --download-sections "*15:00-25:00"

# Display available formats
npx twitch-dlp https://www.twitch.tv/videos/2022789761 -F

# Download specified format
npx twitch-dlp https://www.twitch.tv/videos/2022789761 -f 480p30

# Change output template
npx twitch-dlp https://www.twitch.tv/videos/2022789761 -o "%(title)s [%(id)s].%(ext)s"

# Limit download rate
npx twitch-dlp https://www.twitch.tv/videos/2022789761 -r 720k

# Merge already downloaded fragments (if something went wrong)
# Filename must match the fragment names but without ".part-FragN"
# Use `--download-sections` if you want to merge only specific part of the video
npx twitch-dlp "./Chillin [v2222470239].mp4" --merge-fragments

# Merge already downloaded fragments and try to unmute muted fragments
npx twitch-dlp "./Chillin [v2222470239].mp4" --merge-fragments --unmute quality
```

## Opciones

```text
-h, --help                  Print this help text and exit
--version                   Print program version and exit
-f, --format FORMAT         Select format to download
                            Available formats:
                            * best: best quality (default)
                            * FORMAT: select format by format_id
-F, --list-formats          Print available formats and exit
-o, --output OUTPUT         Output filename template
                            Available template variables:
                            * %(title)s
                            * %(id)s
                            * %(ext)s
                            * %(description)s
                            * %(duration)s
                            * %(uploader)s
                            * %(uploader_id)s
                            * %(upload_date)s
                            * %(release_date)s
                            * %(view_count)s
--live-from-start           Download live streams from the start
--retry-streams DELAY       Retry fetching the list of available streams until
                            streams are found while waiting DELAY second(s)
                            between each attempt
-r, --limit-rate RATE       Limit download rate to RATE
--keep-fragments            Keep fragments after downloading
--download-sections TEXT    Download specific part of the video.
                            Syntax: "*start_time-end_time".
                            Examples: "*0-12:34", "*3:14:15-inf".
                            A "*" prefix is for yt-dlp compatibility.
                            Negative timestamps and multiple sections are not 
                            supported. Cutting is done by the closest fragments 
                            (not by keyframes), so the accuracy is not very high
--unmute POLICY             Try to unmute muted fragments. Keep in mind that
                            160p and 360p have slightly worse audio quality.
                            Available values:
                            * quality (default for 480p and higher) - check all
                              formats, unmute only if best audio quality is
                              available
                            * any - check all formats, unmute if any audio
                              quality is available
                            * same_format (default for 360p and lower) - only
                              check downloading format, unmute if available
                            * off - don't try to unmute fragments
--downloader NAME           Name of the external downloader to use.
                            Currently supports: aria2c, curl, fetch (default)
--proxy URL                 Use the specified HTTP/HTTPS/SOCKS proxy. To
                            enable SOCKS proxy, specify a proper scheme,
                            e.g. socks5://user:pass@127.0.0.1:1080/.
                            Pass in an empty string (--proxy "") for
                            direct connection. Currently only works with fetch
--merge-method METHOD       How fragments should be merged. Merging happens
                            only after all fragments are downloaded.
                            Available values:
                            * ffconcat (default) - using ffmpeg's concat 
                              demuxer, no fixup needed
                            * append - merge all fragments into one file and
                              fixup using ffmpeg (like yt-dlp does)
--merge-fragments           Merge already downloaded fragments. A FILENAME
                            should be passed instead of a video link. The 
                            FILENAME must match the fragment names but without
                            ".part-FragN". Example: "npx twitch-dlp FILENAME
                            --merge-fragments".
                            Can be used with:
                            * --download-sections - merge only specific part
                              of the video
                            * --unmute - try to unmute downloaded fragments
                              according to passed unmute policy (off by
                              default)
                            * --merge-method - change merge method

It's also possible to pass streamlink twitch plugin args:
--twitch-disable-ads, --twitch-low-latency, --twitch-api-header,
--twitch-access-token-param, --twitch-force-client-integrity,
--twitch-purge-client-integrity
See https://streamlink.github.io/cli.html#twitch
```

## Ejemplo de formatos

Para VODs

```bash
┌─────────┬──────────────┬──────────────┬──────┬───────────────┬────────┐
│ (index) │ format_id    │ resolution   │ fps  │ total_bitrate │ source │
├─────────┼──────────────┼──────────────┼──────┼───────────────┼────────┤
│ 0       │ 'Audio_Only' │ 'audio only' │ null │ '212k'        │ null   │
│ 1       │ '160p'       │ '284x160'    │ 30   │ '225k'        │ null   │
│ 2       │ '360p'       │ '640x360'    │ 30   │ '615k'        │ null   │
│ 3       │ '480p'       │ '852x480'    │ 30   │ '1172k'       │ null   │
│ 4       │ '720p60'     │ '1280x720'   │ 60   │ '3027k'       │ null   │
│ 5       │ '1080p60'    │ '1920x1080'  │ 60   │ '5967k'       │ true   │
└─────────┴──────────────┴──────────────┴──────┴───────────────┴────────┘
```

Para transmisiones en vivo (streamlink)

```bash
Available streams: audio_only, 160p (worst), 360p, 480p, 720p, 720p60, 1080p60 (best)
```

```bash
Available streams: audio_only, 160p (worst), 360p, 480p, 720p, 720p60_alt, 720p60 (best)
```

## Dependencias

- **ffmpeg**
- **streamlink** (si se descarga mediante enlace de canal sin `--live-from-start`)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---