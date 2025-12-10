# ytcc
[![lint and test](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml/badge.svg)](https://github.com/woefe/ytcc/actions/workflows/lint_and_test.yml)

YouTube 및 여러 다른 곳에서 좋아하는 재생목록을 추적할 수 있는 명령줄 도구입니다.

## 설치하기
```shell script
pipx install ytcc
```
대체 설치 방법은 [문서](https://github.com/woefe/ytcc/tree/master/doc/install.md)에 설명되어 있습니다.

## 사용법

"구독"을 추가하세요.
`subscribe`는 발견된 동영상을 데이터베이스에 저장하지 않는다는 점에 유의하세요.
구독 후 `ytcc update`를 실행하여 동영상 메타데이터를 확인하고 가져오세요.
```shell script
# Any playlist supported by yt-dlp (or youtube-dl)
ytcc subscribe "Jupiter Broadcasting" "https://www.youtube.com/c/JupiterBroadcasting/videos"
ytcc subscribe "NCS: House" "https://www.youtube.com/playlist?list=PLRBp0Fe2GpgmsW46rJyudVFlY6IYjFBIK"
ytcc subscribe "Neus" "https://soundcloud.com/neus/tracks"

# RSS feed podcasts
ytcc subscribe "LINUX Unplugged" "https://linuxunplugged.com/rss"
ytcc subscribe "Darknet Diaries" "https://feeds.megaphone.fm/darknetdiaries"
```
[Google Takeout](https://takeout.google.com/)에서 구독을 가져오세요.  
*힌트*: 테이크아웃을 요청할 때는 YouTube 데이터만 선택해야 하며, 그렇지 않으면 테이크아웃 완료에 상당한 시간이 걸릴 수 있습니다.

```shell script
ytcc import ~/Downloads/Takeout/Youtube/subscriptions/subscriptions.csv
```
새 비디오의 메타데이터를 가져옵니다.

```shell script
ytcc update
```

보지 않은 동영상 목록입니다.
```shell script
ytcc list
```

JSON 형식으로 재생목록 내용을 나열합니다.
```shell script
ytcc --output json list --playlist "NCS: House" --since 2020-07-07 --watched --unwatched
```
모든 비디오를 RSS 피드로 나열하십시오.

```shell script
ytcc --output rss list --watched --unwatched
```
인터랙티브 터미널 인터페이스를 시작합니다.

```shell script
ytcc tui
```
재생하지 않고 재생목록의 모든 동영상을 시청한 것으로 표시합니다.

```shell script
ytcc ls -p "Jupiter Broadcasting" | ytcc mark
```
제한 없이 음악을 감상하세요.

```shell script
ytcc ls -p "NCS: House" | ytcc play --audio-only
```

**썸네일 지원이 포함된 대체 터미널 인터페이스.**
[fzf](https://github.com/junegunn/fzf) 버전 0.23.1 이상이 필요하며, 선택적으로 [curl](https://curl.se/) 및 [ueberzug](https://github.com/seebye/ueberzug) 또는 [kitty](https://sw.kovidgoyal.net/kitty/) 중 하나가 필요합니다.
ytcc 설치 시 대부분의 플랫폼에서 스크립트가 자동으로 설치됩니다.
설치되어 있지 않은 경우, [여기](https://github.com/woefe/ytcc/tree/master/scripts/ytccf.sh)에서 다운로드할 수 있습니다.
```shell script
ytccf.sh

# Show help and key bindings
ytccf.sh --help
```
## 구성
Ytcc는 다음 위치에서 구성 파일을 검색합니다:

1. `-c` 또는 `--config` 옵션으로 지정된 파일
2. `~/.ytcc.conf`
3. `$XDG_CONFIG_HOME/ytcc/ytcc.conf` 또는 `~/.config/ytcc/ytcc.conf`
4. `/etc/ytcc/ytcc.conf`

이 위치들에서 구성 파일을 찾지 못하면 기본 구성 파일이 `$XDG_CONFIG_HOME/ytcc/ytcc.conf` 또는 `~/.config/ytcc/ytcc.conf`에 생성됩니다.

### 구성 예제


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
### mpv 설정
Ytcc는 동영상 재생을 위해 [mpv](https://mpv.io)를 사용합니다.
mpv를 ytcc와 잘 통합되도록 설정할 수 있습니다.
자세한 내용은 [여기](https://github.com/woefe/ytcc/tree/master/doc/mpv.md)에 문서화되어 있습니다.


## 문제 보고
[GitHub 이슈 트래커](https://github.com/woefe/ytcc/issues/new)에 새 이슈를 만드세요.
문제를 가능한 한 상세히 설명하고, 가능하면 이슈 템플릿을 사용하세요!
**중요**: 버그 리포트에는 `ytcc bug-report` 출력 결과를 반드시 포함하세요.
`--loglevel debug` 옵션으로 ytcc를 실행하고 출력을 리포트에 포함하는 것도 큰 도움이 됩니다.

## 개발
개발에는 [hatch](https://hatch.pypa.io/latest/)를 사용합니다.


```shell
hatch env create
hatch shell

# Verify successful install
ytcc --help
```
모든 풀 리퀘스트 전에 다음 명령어를 실행하고 발생하는 경고나 오류를 수정하세요.

```shell script
hatch fmt --check
hatch test
```
### 외부 의존성
선택적 요구 사항:
- `.mp4` 또는 `.mkv` 병합을 위한 [ffmpeg](https://ffmpeg.org/)
- 오디오 또는 비디오 재생을 원할 경우 [mpv](https://mpv.io/)

ytccf.sh 배시 스크립트의 요구 사항:
- 0.23.1 버전 이상 [fzf](https://github.com/junegunn/fzf)
- 선택적으로 썸네일 지원을 위해
    - [curl](https://curl.se/)
    - [ueberzug](https://github.com/seebye/ueberzug) 또는 [kitty](https://sw.kovidgoyal.net/kitty/) 중 하나.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-10

---