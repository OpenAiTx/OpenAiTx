# ytcc
[![lint and test](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml/badge.svg)](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml)

YouTubeやその他多くの場所でお気に入りのプレイリストを管理するためのコマンドラインツール。

## インストール
```shell script
pipx install ytcc
```
代替のインストール方法は[ドキュメント](https://github.com/woefe/ytcc/tree/master/doc/install.md)に記載されています。

## 使い方

「subscriptions」を追加します。
`subscribe` は発見した動画をデータベースに保存しないことに注意してください。
購読後に動画のメタデータを確認および取得するには、`ytcc update` を実行してください。
```shell script
# Any playlist supported by yt-dlp (or youtube-dl)
ytcc subscribe "Jupiter Broadcasting" "https://www.youtube.com/c/JupiterBroadcasting/videos"
ytcc subscribe "NCS: House" "https://www.youtube.com/playlist?list=PLRBp0Fe2GpgmsW46rJyudVFlY6IYjFBIK"
ytcc subscribe "Neus" "https://soundcloud.com/neus/tracks"

# RSS feed podcasts
ytcc subscribe "LINUX Unplugged" "https://linuxunplugged.com/rss"
ytcc subscribe "Darknet Diaries" "https://feeds.megaphone.fm/darknetdiaries"
```

[Google Takeout](https://takeout.google.com/) から購読情報をインポートします。
*ヒント*: Takeout をリクエストする際は、YouTube のデータのみを選択してください。そうしないと、完了までにかなり時間がかかることがあります。
```shell script
ytcc import ~/Downloads/Takeout/Youtube/subscriptions/subscriptions.csv
```
新しい動画のメタデータを取得します。

```shell script
ytcc update
```
未視聴のビデオを一覧表示します。

```shell script
ytcc list
```
JSON形式でプレイリストの内容を一覧表示します。

```shell script
ytcc --output json list --playlist "NCS: House" --since 2020-07-07 --watched --unwatched
```
すべての動画をRSSフィードとして一覧表示します。

```shell script
ytcc --output rss list --watched --unwatched
```

インタラクティブなターミナルインターフェースを開始します。
```shell script
ytcc tui
```
再生せずにプレイリスト内のすべての動画を視聴済みとしてマークします。

```shell script
ytcc ls -p "Jupiter Broadcasting" | ytcc mark
```

制限なしで音楽を聴く。
```shell script
ytcc ls -p "NCS: House" | ytcc play --audio-only
```

**サムネイル対応の代替ターミナルインターフェース。**
[fzf](https://github.com/junegunn/fzf) バージョン0.23.1以降が必要で、オプションで[curl](https://curl.se/)および[ueberzug](https://github.com/seebye/ueberzug)か[kitty](https://sw.kovidgoyal.net/kitty/)のいずれかが必要です。
このスクリプトはytccのインストール時にほとんどのプラットフォームで自動的にインストールされます。
インストールされていない場合は、[こちら](https://github.com/woefe/ytcc/tree/master/scripts/ytccf.sh)からダウンロードできます。
```shell script
ytccf.sh

# Show help and key bindings
ytccf.sh --help
```

## 設定
Ytcc は以下の場所で設定ファイルを検索します：

1. `-c` または `--config` オプションで指定されたファイル
2. `~/.ytcc.conf`
3. `$XDG_CONFIG_HOME/ytcc/ytcc.conf` または `~/.config/ytcc/ytcc.conf`
4. `/etc/ytcc/ytcc.conf`

これらの場所に設定ファイルが見つからない場合、デフォルトの設定ファイルが `$XDG_CONFIG_HOME/ytcc/ytcc.conf` または `~/.config/ytcc/ytcc.conf` に作成されます。

### 設定例

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

### mpvの設定
Ytccは動画再生に[mpv](https://mpv.io)を使用します。
mpvを設定してytccとスムーズに連携させることができます。
詳細は[こちら](https://github.com/woefe/ytcc/tree/master/doc/mpv.md)に記載されています。


## 問題報告
[GitHubのissueトラッカー](https://github.com/woefe/ytcc/issues/new)で新しいissueを作成してください。
問題をできるだけ詳しく説明し、可能であればissueテンプレートを使用してください！
**重要**: バグ報告には必ず`ytcc bug-report`の出力を含めてください。
また、`--loglevel debug`オプションを付けてytccを実行し、その出力を報告に含めると非常に役立ちます。

## 開発
開発には[hatch](https://hatch.pypa.io/latest/)を使用しています。

```shell
hatch env create
hatch shell

# Verify successful install
ytcc --help
```
プルリクエストを作成する前に、以下のコマンドを実行し、警告やエラーを修正してください。

```shell script
hatch fmt --check
hatch test
```
### 外部依存関係
オプションの要件:
- `.mp4` または `.mkv` の結合には [ffmpeg](https://ffmpeg.org/)
- 音声や動画を再生する場合は [mpv](https://mpv.io/)

ytccf.sh bashスクリプトの要件:
- バージョン0.23.1以降の [fzf](https://github.com/junegunn/fzf)
- サムネイルサポート用にオプションで
    - [curl](https://curl.se/)
    - [ueberzug](https://github.com/seebye/ueberzug) または [kitty](https://sw.kovidgoyal.net/kitty/) のいずれか。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---