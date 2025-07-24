# Reddittui
명령줄에서 Reddit을 탐색할 수 있는 가벼운 터미널 애플리케이션입니다. [bubbletea](https://github.com/charmbracelet/bubbletea)로 구동됩니다.

## 기능
- **서브레딧 탐색:** 좋아하는 서브레딧을 탐색합니다.
- **게시물 보기:** 텍스트 게시물과 댓글을 읽습니다.
- **키보드 내비게이션:** vim/표준 키보드 단축키를 사용하여 게시물을 스크롤하고 선택합니다.
- **구성 가능:** 캐싱 동작을 사용자 지정하고 구성 파일을 사용하여 서브레딧 필터를 정의할 수 있습니다.

## 데모
https://github.com/user-attachments/assets/40d61ef3-3a95-4a26-8c49-bec616f6ae1c

## 설치

### Git
#### 필수 조건
- **Git**
- **Go:** 버전 1.16 이상
- **터미널:** 유닉스 계열 터미널(Linux, macOS 또는 유사한 환경).
- **POSIX 유틸리티:** 설치에 사용되는 `install` 명령어는 Linux와 macOS 모두에서 사용할 수 있습니다.

레포지토리를 클론하고 설치 스크립트를 실행하세요: 

```bash
git clone https://github.com/tonymajestro/reddit-tui.git reddittui
cd reddittui
./install.sh
```
reddittui를 제거하려면 제거 스크립트를 실행하세요:


```bash
./uninstall.sh
```
### Arch
Arch 사용자는 yay 또는 기타 AUR 도우미를 사용하여 AUR에서 reddittui를 설치할 수 있습니다.

[미리 컴파일된](https://aur.archlinux.org/packages/reddit-tui-bin) 및 [소스 패키지](https://aur.archlinux.org/packages/reddit-tui)를 사용할 수 있습니다.


```bash
yay -S reddit-tui-bin
```

```bash
yay -S reddit-tui
```

### 닉스
닉스 사용자는 셸에서 시도해 보거나 시스템 구성에 다음과 같이 추가할 수 있습니다.
```bash
nix-shell -p reddit-tui
```
```nix
  environment.systemPackages = [
      pkgs.reddit-tui
    ];
```

## 사용법
설치된 바이너리를 선호하는 터미널에서 실행하세요:

```bash
# Open reddittui, navigating to the home page
reddittui

# Open reddittui, navigating to a specific subreddit
reddittui --subreddit dogs

# Open reddittui, navigating to a specific post by its ID
reddittui --post 1iyuce4
```
## 키바인딩
- 네비게이션
  - **h, j, k, l:** Vim 이동
  - **left, right, up, down:** 일반 이동
  - **g**: 페이지 상단으로 이동
  - **G**: 페이지 하단으로 이동
  - **s**: 서브레딧 전환
- 게시물 페이지
  - **L**: 게시물 더 불러오기
- 댓글 페이지
  - **o**: 게시물 링크를 브라우저에서 열기
  - **c**: 댓글 접기
- 기타
  - **H:** 홈 페이지로 이동
  - **backspace**: 뒤로 가기
  - **q, esc**: reddittui 종료

## 설정 파일
reddittui 바이너리를 실행하면 다음 파일들이 초기화됩니다:
- 설정 파일:
  - `~/.config/reddittui/reddittui.toml`
- 로그 파일:
  - `~/.local/state/reddittui.log`
- 캐시
  - `~/.cache/reddittui/`

샘플 설정:

```toml
# Core configuration
[core]
bypassCache = false
logLevel = "Warn"

# Filter out posts containing keywords or belonging to certain subreddits
[filter]
subreddits = ["news", "politics"]
keywords = ["pizza", "pineapple"]

# Configure client timeout and cache TTL. By default, subreddit posts and comments are cached for 1 hour.
[client]
timeoutSeconds = 10
cacheTtlSeconds = 3600

# Configure which reddit server to use. Default is old.reddit.com but redlib servers are also supported
[server]
domain = "old.reddit.com"
type = "old"
```

## Redlib
향상된 개인정보 보호를 위해, 개인 [Redlib 백엔드](https://github.com/redlib-org/redlib)를 지원합니다. Redlib 서버 목록은 [여기](https://github.com/redlib-org/redlib-instances/blob/main/instances.json)에서 확인할 수 있습니다. old.reddit.com 대신 Redlib 서버를 사용하려면 다음 구성을 사용하세요:

```toml
[server]
domain = "safereddit.com"
type = "redlib"
```

## 감사의 글
Reddittui는 [bubbletea](https://github.com/charmbracelet/bubbletea) 프레임워크를 기반으로 합니다. 또한 해커뉴스 터미널 브라우저인 [circumflex](https://github.com/bensadeh/circumflex)에서 영감을 받았습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---