# ytcc
[![lint and test](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml/badge.svg)](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml)

命令行工具，用于跟踪您在YouTube及其他多个平台上的收藏播放列表。

## 安装
```shell script
pipx install ytcc
```
替代安装方法请参见[文档](https://github.com/woefe/ytcc/tree/master/doc/install.md)。

## 使用方法

添加“订阅”。
注意，`subscribe` 不会将发现的视频保存到数据库。
订阅后运行 `ytcc update` 以检查并获取视频元数据。
```shell script
# Any playlist supported by yt-dlp (or youtube-dl)
ytcc subscribe "Jupiter Broadcasting" "https://www.youtube.com/c/JupiterBroadcasting/videos"
ytcc subscribe "NCS: House" "https://www.youtube.com/playlist?list=PLRBp0Fe2GpgmsW46rJyudVFlY6IYjFBIK"
ytcc subscribe "Neus" "https://soundcloud.com/neus/tracks"

# RSS feed podcasts
ytcc subscribe "LINUX Unplugged" "https://linuxunplugged.com/rss"
ytcc subscribe "Darknet Diaries" "https://feeds.megaphone.fm/darknetdiaries"
```

从 [Google Takeout](https://takeout.google.com/) 导入订阅。
*提示*：请求导出时，请确保只选择 YouTube 数据，否则导出可能需要很长时间才能完成。
```shell script
ytcc import ~/Downloads/Takeout/Youtube/subscriptions/subscriptions.csv
```

获取新视频的元数据。
```shell script
ytcc update
```
列出未观看的视频。

```shell script
ytcc list
```
以 JSON 格式列出播放列表内容。

```shell script
ytcc --output json list --playlist "NCS: House" --since 2020-07-07 --watched --unwatched
```
将所有视频列为 RSS 订阅源。

```shell script
ytcc --output rss list --watched --unwatched
```
启动交互式终端界面。

```shell script
ytcc tui
```
将播放列表中的所有视频标记为已观看，而无需播放它们。

```shell script
ytcc ls -p "Jupiter Broadcasting" | ytcc mark
```

无任何限制地听音乐。
```shell script
ytcc ls -p "NCS: House" | ytcc play --audio-only
```

**带缩略图支持的替代终端界面。**
需要 [fzf](https://github.com/junegunn/fzf) 版本 0.23.1 或更高版本， 可选依赖 [curl](https://curl.se/) 和 [ueberzug](https://github.com/seebye/ueberzug) 或 [kitty](https://sw.kovidgoyal.net/kitty/)。
该脚本在大多数平台上安装 ytcc 时会自动安装。
如果未安装，您可以从[这里](https://github.com/woefe/ytcc/tree/master/scripts/ytccf.sh)下载。
```shell script
ytccf.sh

# Show help and key bindings
ytccf.sh --help
```

## 配置
Ytcc 会在以下位置搜索配置文件：

1. 使用 `-c` 或 `--config` 选项指定的文件
2. `~/.ytcc.conf`
3. `$XDG_CONFIG_HOME/ytcc/ytcc.conf` 或 `~/.config/ytcc/ytcc.conf`
4. `/etc/ytcc/ytcc.conf`

如果在这些位置都未找到配置文件，则会在 `$XDG_CONFIG_HOME/ytcc/ytcc.conf` 或 `~/.config/ytcc/ytcc.conf` 创建一个默认配置文件

### 示例配置

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
### mpv 配置
Ytcc 使用 [mpv](https://mpv.io) 播放视频。  
你可以配置 mpv 以便与 ytcc 良好集成。  
具体内容记录在 [这里](https://github.com/woefe/ytcc/tree/master/doc/mpv.md)。  


## 报告问题  
请在 [GitHub 问题跟踪器](https://github.com/woefe/ytcc/issues/new) 创建新问题。  
尽可能详细地描述问题，如果可能，请使用问题模板！  
**重要**：记得在错误报告中包含 `ytcc bug-report` 的输出。  
运行 ytcc 时加上 `--loglevel debug` 选项并将输出包含在报告中，可能会非常有帮助。  

## 开发  
我们使用 [hatch](https://hatch.pypa.io/latest/) 进行开发。


```shell
hatch env create
hatch shell

# Verify successful install
ytcc --help
```
在每次提交拉取请求之前运行以下命令，并修复它们产生的警告或错误。

```shell script
hatch fmt --check
hatch test
```

### 外部依赖
可选要求：
- [ffmpeg](https://ffmpeg.org/) 用于合并 `.mp4` 或 `.mkv`
- [mpv](https://mpv.io/)，如果你想播放音频或视频

ytccf.sh bash 脚本的要求：
- 版本 0.23.1 或更新的 [fzf](https://github.com/junegunn/fzf)
- 可选，用于缩略图支持
    - [curl](https://curl.se/)
    - 选择其一 [ueberzug](https://github.com/seebye/ueberzug) 或 [kitty](https://sw.kovidgoyal.net/kitty/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---