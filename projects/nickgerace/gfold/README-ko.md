# gfold

[![latest release tag](https://img.shields.io/github/v/tag/nickgerace/gfold?sort=semver&logo=git&logoColor=white&label=version&style=for-the-badge&color=blue)](https://github.com/nickgerace/gfold/releases/latest)
[![crates.io version](https://img.shields.io/crates/v/gfold?style=for-the-badge&logo=rust&color=orange)](https://crates.io/crates/gfold)
[![build status](https://img.shields.io/github/actions/workflow/status/nickgerace/gfold/ci.yml?branch=main&style=for-the-badge&logo=github&logoColor=white)](https://github.com/nickgerace/gfold/actions)
[![calver](https://img.shields.io/badge/calver-YYYY.MM.MICRO-cyan.svg?style=for-the-badge)](https://calver.org)

`gfold`는 여러 Git 저장소를 추적하는 데 도움이 되는 CLI 도구입니다.

[![A GIF showcasing gfold in action](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)

기본적으로 클래식 표시 모드를 사용하고 싶으며 매번 플래그를 설정하는 것을 피하고 싶다면, 설정 파일에서 이를 설정할 수 있습니다 (사용법 섹션 참조).

## 공지 (2025년 2월)

모든 릴리스는 이제 `2025.2.1`부터 시작하여 [CalVer](https://calver.org/) 버전 체계를 따릅니다.
이 변경은 처음 릴리스부터 `4.6.0` 버전까지 사용된 [Semantic Versioning](https://semver.org/spec/v2.0.0.html) 버전 체계와 앞으로 및 뒤로 호환됩니다.

*버전 체계 변경 자체에 대해 최종 사용자가 별도의 조치를 취할 필요는 없습니다.*

이 공지는 결국 이 [README](https://raw.githubusercontent.com/nickgerace/gfold/main/./README.md)에서 제거되고 [CHANGELOG](https://raw.githubusercontent.com/nickgerace/gfold/main/./CHANGELOG.md)로 이동될 예정입니다.

## 설명

이 앱은 여러 Git 저장소에 대한 관련 정보를 하나 이상의 디렉터리에서 표시합니다.
파일 시스템에서만 읽으며 절대 쓰지 않습니다.
이 도구가 범위와 목적이 제한된 것처럼 보일 수 있지만, 이는 의도된 설계입니다.

기본적으로 `gfold`는 현재 작업 디렉터리에서부터 모든 Git 저장소를 탐색합니다.
다른 디렉터리를 대상으로 하려면 경로(상대 또는 절대)를 첫 번째 인수로 전달하거나 설정 파일에서 기본 경로를 변경할 수 있습니다.

탐색 후, `gfold`는 [rayon](https://github.com/rayon-rs/rayon)을 활용하여 감지된 모든 Git 저장소에 대해 병렬로 읽기 전용 분석을 수행합니다.
분석은 [git2-rs](https://github.com/rust-lang/git2-rs) 라이브러리를 활용하여 수행됩니다.

## 사용법

이 응용 프로그램의 모든 옵션을 보려면 `-h/--help` 플래그를 제공하세요.

```shell
# Operate in the current working directory or in the location provided by a config file, if one exists.
gfold

# Operate in the parent directory.
gfold ..

# Operate in the home directory (first method).
gfold $HOME

# Operate in the home directory (second method).
gfold ~/

# Operate with an absolute path.
gfold /this/is/an/absolute/path

# Operate with a relative path.
gfold ../../this/is/a/relative/path

# Operate with three paths.
gfold ~/src ~/projects ~/code
```
### 구성 파일

자주 동일한 인수를 제공하는 경우 구성 파일을 생성하여 사용할 수 있습니다.  
`gfold`는 기본적으로 구성 파일을 제공하지 않으며 구성 파일은 완전히 선택 사항입니다.

어떻게 작동합니까?  
실행 시 `gfold`는 다음 경로(순서대로)에서 구성 파일을 찾습니다:

- `$XDG_CONFIG_HOME/gfold.toml`  
- `$XDG_CONFIG_HOME/gfold/config.toml`  
- `$HOME/.config/gfold.toml`

`$XDG_CONFIG_HOME`는 문자 그대로 `XDG_CONFIG_HOME` 환경 변수를 의미하지만, 설정되지 않은 경우 운영 체제별 적절한 경로로 기본값이 설정됩니다 ([`user_dirs`](https://github.com/uncenter/user_dirs) 참고).

구성 파일이 발견되면 `gfold`는 이를 읽고 그 안에 지정된 옵션을 사용합니다.

구성 파일 생성을 위해 `--dry-run` 플래그를 사용하여 유효한 TOML을 출력할 수 있습니다.  
다음은 macOS, Linux 및 유사 플랫폼에서의 구성 파일 생성 워크플로 예시입니다:


```shell
gfold -d classic -c never ~/ --dry-run > $HOME/.config/gfold.toml
```

다음은 생성된 구성 파일의 내용입니다:

```toml
paths = ['/home/neloth']
display_mode = 'Classic'
color_mode = 'Never'
```
설정 파일을 만들었는데 전혀 다른 설정으로 `gfold`를 실행하고 싶고  
설정 파일에서 옵션이 실수로 상속되는 것을 방지하고 싶다고 가정해 봅시다.  
그런 경우 `-i` 플래그를 사용하여 설정 파일을 무시할 수 있습니다.


```shell
gfold -i
```
동일한 플래그를 사용하여 구성 파일을 기본값으로 복원할 수 있습니다.


```shell
gfold -i > $HOME/.config/gfold.toml
```
또한, 기존 구성 파일을 무시하고 특정 옵션을 구성하며 지정되지 않은 옵션에 대해서는 기본값을 모두 한 번에 사용할 수 있습니다.  
다음은 클래식 디스플레이 모드를 사용하고 다른 모든 설정을 기본값으로 재정의하려는 예입니다:  
  

```shell
gfold -i -d classic > $HOME/.config/gfold.toml
```

`git`을 사용하여 구성 파일을 백업하고 기록을 추적할 수 있습니다.
macOS, Linux 및 대부분의 시스템에서 파일을 `git` 저장소에 다시 연결할 수 있습니다.

```shell
ln -s <path-to-repository>/gfold.toml $HOME/.config/gfold.toml
```
이제 리포지토리 내에서 설정 파일을 업데이트하고 환경 설정 워크플로우의 일부로 링크 작업을 포함할 수 있습니다.

## 설치

[![패키징 상태](https://repology.org/badge/vertical-allrepos/gfold.svg)](https://repology.org/project/gfold/versions)

### Homebrew (macOS 및 Linux)

[Homebrew](https://brew.sh)를 사용하여 [core formulae](https://formulae.brew.sh/formula/gfold)를 통해 `gfold`를 설치할 수 있습니다.

하지만 `brew`로 [coreutils](https://formulae.brew.sh/formula/coreutils)를 설치한 경우 macOS에서 이름 충돌이 발생할 수 있습니다.
해결 방법과 자세한 내용은 [문제 해결](#troubleshooting-and-known-issues) 섹션을 참조하세요.


```shell
brew install gfold
```

### 아치 리눅스

[pacman](https://wiki.archlinux.org/title/Pacman)을 사용하여 [extra 저장소](https://archlinux.org/packages/extra/x86_64/gfold/)에서 `gfold`를 설치할 수 있습니다.

```shell
pacman -S gfold
```

### Nix 및 NixOS

[nixpkgs](https://github.com/NixOS/nixpkgs/blob/master/pkgs/applications/version-management/gfold/default.nix)에서 `gfold`를 설치할 수 있습니다:

```shell
nix-env --install gfold
```

만약 [flakes](https://nixos.wiki/wiki/Flakes)를 사용하고 있다면, `nix` 명령어를 사용하여 직접 설치할 수 있습니다.

```shell
nix profile install "nixpkgs#gfold"
```

### Cargo

거의 모든 플랫폼에서 [crate](https://crates.io/crates/gfold)를 설치하기 위해 [cargo](https://crates.io)를 사용할 수 있습니다.

```shell
cargo install gfold
```
`Cargo.lock`을 사용하려면 `--locked` 플래그를 사용하세요.


```shell
cargo install --locked gfold
```
크레이트를 최신 상태로 유지하는 것은 [cargo-update](https://crates.io/crates/cargo-update)로 쉽습니다.


```shell
cargo install cargo-update
cargo install-update -a
```
### 바이너리 다운로드

위의 설치 방법을 사용하지 않거나 저장소를 클론하고 싶지 않은 경우, [릴리스](https://github.com/nickgerace/gfold/releases) 페이지에서 바이너리를 다운로드할 수 있습니다.  
방법에 대한 예시는 [수동 설치](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md) 가이드를 참조하세요.

### 소스에서 빌드하기

소스에서 빌드하는 방법에 대한 예시는 [수동 설치](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md) 가이드를 참조하세요.

### 더 이상 사용되지 않음: Homebrew 탭 (macOS 전용)

[nickgerace/homebrew-nickgerace에 위치한 탭](https://github.com/nickgerace/homebrew-nickgerace/blob/main/Formula/gfold.rb)은 더 이상 사용되지 않습니다.  
대신 위에서 언급한 기본 Homebrew 패키지를 사용하세요.

### 선호하는 설치 방법이 목록에 없나요?

[이슈를 등록해 주세요](https://github.com/nickgerace/gfold/issues/new)!

## 호환성

`gfold`는 _모든_ 1급 Rust 🦀 타겟에서 실행되도록 설계되었습니다.  
지원되지 않는 플랫폼이 있다면 [이슈를 등록해 주세요](https://github.com/nickgerace/gfold/issues).

## 문제 해결 및 알려진 문제

예상치 못한 동작이나 버그가 발생하고 더 자세한 정보를 보고 싶다면, 상세 출력을 높여 실행하세요.


```shell
gfold -vvv
```
문제가 계속되면, [이슈를 등록](https://github.com/nickgerace/gfold/issues)해 주세요.  
문제 해결에 도움이 될 수 있도록 _민감한 부분은 삭제된_ 실행 로그를 첨부해 주세요.  

### macOS에서 Coreutils 충돌  

macOS에 `brew`를 통해 [GNU Coreutils](https://www.gnu.org/software/coreutils/)의 `fold`가 설치된 경우, `gfold`라는 이름으로 설치됩니다.  
이 충돌은 셸 별칭, 셸 함수 및/또는 `PATH` 변경으로 피할 수 있습니다.  
다음은 `gfold`에서 `o`를 뺀 예제입니다:


```shell
alias gfld=$HOME/.cargo/bin/gfold
```
## 커뮤니티

추가 정보와 사용자 및 전체 "커뮤니티"에 대한 감사는 **[COMMUNITY THANKS](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/COMMUNITY_THANKS.md)** 파일을 참조하십시오.

- [NixOS, Arch Linux 등용 패키지](https://repology.org/project/gfold/versions)
- [`gfold`이 소개된 기사, "One Hundred Rust Binaries"](https://www.wezm.net/v2/posts/2020/100-rust-binaries/page2/)
- [`gfold`용 `neovim` 플러그인, nvim-gfold.lua](https://github.com/AckslD/nvim-gfold.lua) _([Reddit 공지 게시물](https://www.reddit.com/r/neovim/comments/t209wy/introducing_nvimgfoldlua/))_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-04

---