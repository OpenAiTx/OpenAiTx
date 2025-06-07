<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh는 오픈 소스이자 커뮤니티 주도의 [zsh](https://www.zsh.org/) 구성 관리를 위한 프레임워크입니다.

지루하게 들리시나요? 다시 시도해보겠습니다.

**Oh My Zsh는 여러분을 10배 개발자로 만들어주진 않겠지만... 그렇게 느껴지게 할 수는 있습니다.**

설치가 완료되면, 터미널 셸이 _화제의 중심_ 이 됩니다. (아니면 환불해드리죠!) 명령 프롬프트에서 키를 입력할 때마다 수백 개의 강력한 플러그인과 아름다운 테마를 활용할 수 있습니다. 카페에서 낯선 사람들이 다가와서 _"정말 대단하네요! 천재이신가요?"_ 라고 물어볼지도 모릅니다.

마침내, 여러분이 항상 받아야 한다고 느꼈던 관심을 받기 시작할지도 모릅니다. ...아니면 절약한 시간으로 치실을 더 자주 할 수도 있겠죠. 😬

더 자세한 내용을 보려면 [ohmyz.sh](https://ohmyz.sh)에 방문하고, X(구 트위터)에서 [@ohmyzsh](https://x.com/ohmyzsh)를 팔로우하고, [Discord](https://discord.gg/ohmyzsh)에 참여하세요.

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>목차</summary>

- [시작하기](#getting-started)
  - [운영 체제 호환성](#operating-system-compatibility)
  - [사전 준비 사항](#prerequisites)
  - [기본 설치](#basic-installation)
    - [수동 검사](#manual-inspection)
- [Oh My Zsh 사용하기](#using-oh-my-zsh)
  - [플러그인](#plugins)
    - [플러그인 활성화](#enabling-plugins)
    - [플러그인 사용](#using-plugins)
  - [테마](#themes)
    - [테마 선택](#selecting-a-theme)
  - [FAQ](#faq)
- [고급 주제](#advanced-topics)
  - [고급 설치](#advanced-installation)
    - [사용자 지정 디렉터리](#custom-directory)
    - [무인 설치](#unattended-install)
    - [포크된 저장소에서 설치하기](#installing-from-a-forked-repository)
    - [수동 설치](#manual-installation)
  - [설치 문제](#installation-problems)
  - [사용자 지정 플러그인 및 테마](#custom-plugins-and-themes)
  - [macOS 및 freeBSD에서 GNU ls 사용](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [별칭 건너뛰기](#skip-aliases)
  - [비동기 git 프롬프트](#async-git-prompt)
- [업데이트 받기](#getting-updates)
  - [업데이트 상세도](#updates-verbosity)
  - [수동 업데이트](#manual-updates)
- [Oh My Zsh 제거](#uninstalling-oh-my-zsh)
- [Oh My Zsh에 기여하려면?](#how-do-i-contribute-to-oh-my-zsh)
  - [테마는 보내지 마세요](#do-not-send-us-themes)
- [기여자](#contributors)
- [팔로우하기](#follow-us)
- [굿즈](#merchandise)
- [라이선스](#license)
- [Planet Argon 소개](#about-planet-argon)

</details>

## 시작하기

### 운영 체제 호환성

| 운영체제       | 상태 |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### 사전 준비 사항

- [Zsh](https://www.zsh.org)가 설치되어 있어야 합니다(버전 4.3.9 이상이면 되지만, 5.0.8 이상을 권장합니다). 사전 설치 여부는 `zsh --version`으로 확인하세요. 설치되어 있지 않다면 다음 위키를 참고하세요: [ZSH 설치](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` 또는 `wget`이 설치되어 있어야 합니다.
- `git`이 설치되어 있어야 합니다(권장 버전: 2.4.11 이상).

### 기본 설치

Oh My Zsh는 터미널에서 다음 명령어 중 하나를 실행하여 설치할 수 있습니다. `curl`, `wget` 또는 유사한 도구를 통해 설치할 수 있습니다.

| 방법     | 명령어                                                                                             |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

또한, GitHub 이외의 미러에서도 설치 프로그램을 제공합니다. 중국이나 인도(특정 ISP)처럼 `raw.githubusercontent.com`이 차단된 국가에서는 아래 URL을 사용해야 할 수 있습니다:

| 방법     | 명령어                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_기존 `.zshrc` 파일이 있다면 `.zshrc.pre-oh-my-zsh`로 이름이 변경됩니다. 설치 후, 보존하고 싶은 설정만 새 `.zshrc`로 옮기세요._

#### 수동 검사

알지 못하는 프로젝트의 설치 스크립트는 직접 확인하는 것이 좋습니다. 먼저 설치 스크립트를 다운로드해 내용을 살펴본 후 실행하세요:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

위 URL이 시간 초과 또는 실패한다면 `https://install.ohmyz.sh`로 대체하여 스크립트를 받을 수 있습니다.

## Oh My Zsh 사용하기

### 플러그인

Oh My Zsh에는 활용할 수 있는 수많은 플러그인이 있습니다. [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) 디렉터리나 [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins)를 확인해 현재 사용 가능한 플러그인을 볼 수 있습니다.

#### 플러그인 활성화

사용하고 싶은 플러그인(여러 개도 가능)을 찾았다면, `.zshrc` 파일에서 활성화해야 합니다. zshrc 파일은 `$HOME` 디렉터리에 있습니다. 선호하는 텍스트 에디터로 열고, 로드할 플러그인 목록을 기입하세요.

```sh
vi ~/.zshrc
```

예시:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_플러그인들은 공백(스페이스, 탭, 줄바꿈 등)으로 구분합니다. **쉼표는 사용하지 마세요.** 오류의 원인이 됩니다._

#### 플러그인 사용

각 내장 플러그인에는 **README**가 포함되어 있습니다. 이 문서에는 해당 플러그인이 추가하는 별칭 및 기타 기능이 설명되어 있습니다.

### 테마

인정합니다. Oh My Zsh가 처음 나왔을 때 저희는 다소 테마에 집착했습니다. 지금은 150개 이상의 테마가 번들로 제공됩니다. 대부분은 [위키의 스크린샷](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes)에서 확인할 수 있습니다(업데이트 중입니다!). 꼭 확인해보세요!

#### 테마 선택

_Robby의 테마가 기본값입니다. 가장 화려하지도, 가장 단순하지도 않습니다. 그에게는 딱 맞는 테마죠._

사용하고 싶은 테마를 찾았다면, `~/.zshrc` 파일을 수정해야 합니다. 다음과 같은 대문자 환경 변수가 있습니다:

```sh
ZSH_THEME="robbyrussell"
```

다른 테마를 사용하려면 값만 원하는 테마명으로 변경하세요. 예시:

```sh
ZSH_THEME="agnoster" # (이건 좀 더 화려한 테마 중 하나입니다)
# https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster 참고
```

<!-- prettier-ignore-start -->
> [!NOTE]
> zsh 테마의 스크린샷을 보고 시도했지만, 본인 터미널에서 다르게 보일 수 있습니다.
>
> 이는 많은 테마가 제대로 렌더링되기 위해 [Powerline Font](https://github.com/powerline/fonts) 또는 [Nerd Font](https://github.com/ryanoasis/nerd-fonts) 설치를 필요로 하기 때문입니다. 이 폰트 없이 테마를 쓰면 프롬프트 심볼이 이상하게 보일 수 있습니다. 자세한 내용은 [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt)를 참고하세요.
>
> 또한, 테마는 프롬프트(커서 앞뒤에 보이는 텍스트)만 제어합니다. 터미널 창의 색상(_컬러 스킴_)이나 폰트는 테마로 제어되지 않고, 터미널 에뮬레이터의 설정에서 변경할 수 있습니다. 자세한 내용은 [zsh 테마란?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme) 참고.
<!-- prettier-ignore-end -->

새 터미널 창을 열면 프롬프트가 다음과 같이 보일 것입니다:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

원하는 테마를 찾지 못했다면, [외부 테마](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) 위키를 참고하세요.

좀 더 재미를 원한다면, 매번 터미널을 열 때마다 임의로 테마를 선택하도록 할 수도 있습니다.

```sh
ZSH_THEME="random" # (...파이... 제발 파이 테마가 걸리길..)
```

선호하는 테마 목록에서 임의로 고르려면:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

싫어하는 테마만 제외할 수도 있습니다:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

더 궁금한 점이나 이슈가 있다면 [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ)에서 해결책을 찾아보세요.

## 고급 주제

손수 만지는 것을 좋아한다면, 아래 섹션이 도움이 될 수 있습니다.

### 고급 설치

어떤 사용자는 Oh My Zsh를 수동으로 설치하거나, 기본 경로나 설치 설정을 바꾸고 싶을 수 있습니다(이 설정은 설치 스크립트 상단에도 문서화되어 있습니다).

#### 사용자 지정 디렉터리

기본 위치는 `~/.oh-my-zsh`입니다(홈 디렉터리 내에 숨김 폴더, `cd ~/.oh-my-zsh`로 접근).

설치 디렉터리를 변경하려면 설치 전에 `export ZSH=/your/path`를 실행하거나, 다음과 같이 파이프라인 끝에서 지정할 수 있습니다:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### 무인 설치

Oh My Zsh 설치 스크립트를 자동화된 설치의 일부로 실행한다면 `install.sh` 스크립트에 `--unattended` 플래그를 전달할 수 있습니다. 이 플래그는 기본 셸을 변경하지 않고, 설치가 끝나도 `zsh`를 실행하지 않습니다.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

중국, 인도 등에서 `raw.githubusercontent.com`이 차단된 경우 `https://install.ohmyz.sh`로 URL을 대체해야 할 수 있습니다.

#### 포크된 저장소에서 설치하기

설치 스크립트는 다음 변수들을 받아 다른 저장소를 설치할 수 있습니다:

- `REPO` (기본값: `ohmyzsh/ohmyzsh`): `owner/repository` 형식입니다. 이 변수를 설정하면 `https://github.com/{owner}/{repository}`에서 저장소를 찾습니다.
- `REMOTE` (기본값: `https://github.com/${REPO}.git`): git 저장소 전체 URL입니다. GitHub 이외의 포크(GitLab, Bitbucket 등)에서 설치하거나 HTTPS 대신 SSH로 클론하려면 사용할 수 있습니다(`git@github.com:user/project.git`).  
  _참고: `REPO` 변수와는 호환되지 않으며, 이 설정이 우선시됩니다._
- `BRANCH` (기본값: `master`): 저장소를 클론할 때 체크아웃할 기본 브랜치를 변경할 수 있습니다. Pull Request 테스트나, `master`가 아닌 브랜치 사용에 유용합니다.

예시:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### 수동 설치

##### 1. 저장소 클론하기 <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _선택적으로_, 기존 `~/.zshrc` 백업 <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. 새로운 Zsh 설정 파일 생성 <!-- omit in toc -->

포함된 템플릿을 복사해 새 zsh 설정 파일을 만들 수 있습니다.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. 기본 셸 변경 <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

반영을 위해 로그아웃 후 다시 로그인해야 합니다.

##### 5. 새로운 Zsh 설정 초기화 <!-- omit in toc -->

새 터미널 창을 열면 Oh My Zsh 설정이 적용된 zsh가 로드됩니다.

### 설치 문제

설치 중 문제가 있다면, 아래의 일반적인 해결책을 참고하세요.

- Oh My Zsh로 전환 후 일부 명령어를 찾을 수 없다면, `~/.zshrc`의 `PATH`를 수정해야 할 수 있습니다.
- 수동 설치나 설치 위치를 변경한 경우, `~/.zshrc`의 `ZSH` 환경 변수를 확인하세요.

### 사용자 지정 플러그인 및 테마

기본 동작을 재정의하려면 `custom/` 디렉터리에 새 파일(`.zsh` 확장자)을 추가하면 됩니다.

연관된 함수가 많다면, 이를 `XYZ.plugin.zsh` 파일로 `custom/plugins/` 디렉터리에 넣고 플러그인으로 활성화하세요.

Oh My Zsh에 포함된 플러그인의 기능을 재정의하려면, 같은 이름의 플러그인을 `custom/plugins/` 디렉터리에 만들면 해당 플러그인이 우선 로드됩니다.

### macOS 및 freeBSD에서 GNU ls 사용

<a name="enable-gnu-ls"></a>

Oh My Zsh의 기본 동작은 macOS 및 FreeBSD에서 BSD `ls`를 사용하는 것입니다. GNU `ls`(명령어 이름: `gls`)가 설치되어 있다면, 이를 사용하도록 변경할 수 있습니다. 아래와 같이 `oh-my-zsh.sh`를 소싱하기 전에 zstyle 기반 설정을 추가하면 됩니다:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_참고: `DISABLE_LS_COLORS=true`와는 호환되지 않습니다._

### 별칭 건너뛰기

<a name="remove-directories-aliases"></a>

기본 Oh My Zsh 별칭(`lib/*` 파일에 정의)이나 플러그인 별칭을 건너뛰고 싶다면, `~/.zshrc`에서 **Oh My Zsh를 불러오기 전에** 아래 설정을 사용할 수 있습니다. 용도에 따라 다양한 방법이 있습니다.

```sh
# lib 파일 및 활성화된 플러그인 모든 별칭 건너뛰기
zstyle ':omz:*' aliases no

# lib 파일의 모든 별칭 건너뛰기
zstyle ':omz:lib:*' aliases no
# directories.zsh lib 파일 별칭만 건너뛰기
zstyle ':omz:lib:directories' aliases no

# 모든 플러그인 별칭 건너뛰기
zstyle ':omz:plugins:*' aliases no
# git 플러그인 별칭만 건너뛰기
zstyle ':omz:plugins:git' aliases no
```

좀 더 세밀하게 조합할 수도 있습니다(더 구체적인 범위가 우선 적용):

```sh
# 모든 플러그인 별칭 건너뛰기, 단 git 플러그인은 제외
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

이전 버전에서는 아래 설정을 사용했으나, 지금은 제거되었습니다:

```sh
zstyle ':omz:directories' aliases no
```

이제는 다음을 사용하세요:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### 참고 <!-- omit in toc -->

> 이 기능은 현재 테스트 중이며, 향후 변경될 수 있습니다. 또한 zpm, zinit 등 플러그인 매니저에서는 아직 호환되지 않습니다. (init 스크립트 `oh-my-zsh.sh`에서 구현됨)
>
> 함수로 정의된 "별칭"에는 적용되지 않습니다. 예: git 플러그인의 `gccd`, `ggf`, `ggl` 함수 등.

### 비동기 git 프롬프트

비동기 프롬프트 함수는 (2024년 4월 3일 도입) Oh My Zsh가 프롬프트 정보를 비동기적으로 렌더링할 수 있게 해 주는 실험적 기능입니다. 프롬프트 렌더링 성능이 향상될 수 있으나, 일부 환경에서는 문제가 발생할 수 있습니다. 문제가 생기면 `.zshrc`에서 Oh My Zsh 소싱 전에 아래 설정으로 끌 수 있습니다:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

git 프롬프트가 아예 나타나지 않는다면, 아래 설정으로 강제로 활성화해볼 수 있습니다. 그래도 안되면 이슈를 등록해 주세요.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## 업데이트 받기

기본적으로 2주마다 업데이트 확인 메시지가 표시됩니다. 업데이트 모드는 `~/.zshrc`에서 **Oh My Zsh가 불러오기 전에** 설정할 수 있습니다:

1. 확인 메시지 없이 자동 업데이트:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. 업데이트가 있을 경우 며칠마다 알림만:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. 자동 업데이트 완전 비활성화:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

참고: Oh My Zsh의 업데이트 확인 주기는 아래처럼 조절할 수 있습니다:

```sh
# 7일마다 업데이트 확인
zstyle ':omz:update' frequency 7
# 터미널을 열 때마다 확인(권장하지 않음)
zstyle ':omz:update' frequency 0
```

### 업데이트 상세도

다음 설정으로 업데이트 메시지의 상세도를 조절할 수 있습니다:

```sh
zstyle ':omz:update' verbose default # 기본 업데이트 프롬프트

zstyle ':omz:update' verbose minimal # 간단한 메시지

zstyle ':omz:update' verbose silent # 오류만 표시
```

### 수동 업데이트

언제든지(예: 새로운 플러그인이 출시되었을 때 기다리지 않고) 업데이트하려면 다음 명령을 실행하세요:

```sh
omz update
```

> [!NOTE]
> 스크립트에서 이 과정을 자동화하려면, `upgrade` 스크립트를 직접 호출하세요:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> 자세한 옵션은 [FAQ: Oh My Zsh를 어떻게 업데이트하나요?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh)에서 확인하세요.
>
> **`omz update --unattended` 명령은 부작용이 있어 제거되었습니다.**

매직! 🎉

## Oh My Zsh 제거

Oh My Zsh가 모든 분께 맞는 것은 아닙니다. 저희는 아쉽지만, 깔끔하게 정리할 수 있도록 하겠습니다.

`oh-my-zsh`를 제거하려면 커맨드라인에서 `uninstall_oh_my_zsh`를 실행하세요. 자동으로 자체를 삭제하고, 이전 `bash` 또는 `zsh` 설정으로 복구합니다.

## Oh My Zsh에 기여하려면?

커뮤니티에 참여하기 전에, [행동 강령](CODE_OF_CONDUCT.md)을 읽어주세요.

저는 [Zsh](https://www.zsh.org/) 전문가와는 거리가 멀고, 개선할 방법이 많다고 생각합니다. 구성을 더 쉽게 유지·관리할 수 있도록 아이디어가 있다면 언제든 포크하고 PR을 보내주세요!

Pull Request 테스트도 필요합니다. [오픈된 이슈들](https://github.com/ohmyzsh/ohmyzsh/issues)을 확인하고, 가능한 곳에서 도와주세요.

더 자세한 내용은 [기여 안내](CONTRIBUTING.md)를 참고하세요.

### 테마는 보내지 마세요

현재 테마는 충분히 많습니다. 새로운 테마는 [외부 테마](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) 위키 페이지에 추가해 주세요.

## 기여자

Oh My Zsh는 활기찬 커뮤니티와 기여자 덕분에 멋진 프로젝트가 되었습니다.

정말 감사합니다!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## 팔로우하기

저희는 소셜 미디어에 있습니다:

- X(구 트위터)에서 [@ohmyzsh](https://x.com/ohmyzsh). 팔로우하세요!
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/)에서 소식 받기.
- [Instagram](https://www.instagram.com/_ohmyzsh/)에서 Oh My Zsh를 보여주는 포스트에 태그 달기!
- [Discord](https://discord.gg/ohmyzsh)에서 소통하기!

## 굿즈

[스티커, 티셔츠, 머그컵 등](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)으로 Oh My Zsh에 대한 애정을 뽐내보세요. 다시 한 번, 여러분이 화제의 인물이 될 겁니다!

## 라이선스

Oh My Zsh는 [MIT 라이선스](LICENSE.txt)로 배포됩니다.

## Planet Argon 소개

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh는 [Planet Argon](https://www.planetargon.com/?utm_source=github) 팀이 시작한 [Ruby on Rails 개발 에이전시](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github)입니다. 저희의 [다른 오픈 소스 프로젝트](https://www.planetargon.com/open-source?utm_source=github)도 확인해보세요.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---