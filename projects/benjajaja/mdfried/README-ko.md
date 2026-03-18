# mdfried

`mdfried`는 헤더를 나머지 텍스트보다 **더 큰 텍스트**로 렌더링하는 터미널용 마크다운 뷰어입니다.

## 스크린샷

![스크린샷](https://raw.githubusercontent.com/benjajaja/mdfried/master/./assets/screenshot_1.png)

[`master`에서 최신 테스트 스크린샷 배열](https://benjajaja.github.io/mdfried-screenshots/)

## 비디오

https://github.com/user-attachments/assets/e69154a7-bea8-4e14-a677-be7ccf0d3cac

# 왜?

터미널을 *[요리](https://ratatui.rs/)*할 수 있습니다. 하지만 터미널을 **딥 프라이**할 수 있을까요?
*네!* 당신은 `tty`를 **요리*하고* 튀길** 수 있습니다! ~~너무 늦기 전에 실행하세요!~~

> 터미널은 보통 "요리된" 모드, 즉 정규 모드입니다.
> `ratatui`🐁와 함께라면, 원시 모드지만 당신을 위해 "요리"합니다.

마크다운은 터미널에서 꽤 잘 렌더링될 수 있지만, 한 가지 중요한 점이 빠져 있습니다:
Big Headers™가 텍스트를 더 읽기 쉽게 만들고, 인라인 이미지 렌더링이 매우 편리합니다.

# 어떻게?

헤더를 [ratatui 이미지](https://github.com/benjajaja/ratatui-image)로 렌더링하고,
Sixels, Kitty, iTerm2 같은 여러 터미널 그래픽 프로토콜 중 하나를 사용합니다.
Kitty 터미널은 또한 이미지 렌더링 없이 텍스트를 직접 확대할 수 있는
[텍스트 크기 조정 프로토콜](https://sw.kovidgoyal.net/kitty/text-sizing-protocol/)을 구현합니다!

그래픽 지원 여부 및 자세한 내용은 [ratatui-image](https://github.com/benjajaja/ratatui-image?tab=readme-ov-file#compatibility-matrix)를 참고하세요.

일반적으로 Kitty, WezTerm, iTerm2, Ghostty, Foot, `xterm -ti vt340`는 *작동할* 것입니다.

Alacritty처럼 그래픽 기능이 전혀 없는 터미널에서는 Chafa로 이미지를 렌더링합니다.



# 설치

* Rust cargo: `cargo install mdfried`
  * 소스에서: `cargo install --path .`
  * 일반적으로 `libchafa-dev`, `libchafa-devel`, 또는 단순히 `libchafa`, 심지어는 `chafa`라고 불리는 개발 헤더가 포함된 chafa 패키지가 필요합니다.
  * chafa가 전혀 없거나 터미널이 그래픽 프로토콜을 지원해서 신경쓰지 않는다면 `--no-default-features`를 사용하세요.
  * `cargo install ...` 명령이 실패하면 `--locked` 옵션을 사용해 보거나, 문제를 보고하세요.
* Nix flake: `github:benjajaja/mdfried`
* Nixpkgs: [`mdfried`](https://search.nixos.org/packages?channel=unstable&query=mdfried)
* Arch Linux: `pacman -S mdfried` ([extra 저장소](https://archlinux.org/packages/extra/x86_64/mdfried/))
* Ubuntu: [릴리즈 .deb 다운로드](https://github.com/benjajaja/mdfried/releases/latest)
* Mac: `brew install mdfried` 또는 [릴리즈 바이너리](https://github.com/benjajaja/mdfried/releases/latest)
* Windows: [릴리즈 .exe 다운로드](https://github.com/benjajaja/mdfried/releases/latest)

# 사용법

### 실행하기

```
mdfried ./path/to.md
```
Kitty 버전 0.40 이상을 사용하지 않거나 그래픽 프로토콜을 지원하지 않는 터미널을 사용하는 경우,  
처음 `mdfried`를 실행할 때 글꼴을 선택해야 합니다.  
터미널에서 사용하는 글꼴과 동일한 글꼴을 선택하는 것이 좋지만, 아무 글꼴이나 선택할 수 있습니다.  
글꼴 설정 화면에서는 시스템 글꼴을 검색할 수 있으며 - 터미널에서 사용하는 글꼴과 동일한 것을 선택해야 합니다.  
글꼴은 미리보기로 직접 렌더링됩니다.  
확인되면 선택한 글꼴이 구성 파일에 기록됩니다.  

글꼴이 맞지 않는 경우 `--setup` 옵션을 사용하여 글꼴 설정을 다시 강제로 실행할 수 있습니다.  

마크다운을 파이프로 전달할 수도 있습니다:



```
readable https://lobste.rs | markdownify | mdfried
```
### 주요 단축키

키 | 설명
----|------------
`q` 또는 `Ctrl-c` | 종료하고 터미널에 내용 남기기
`r` | 파일 다시 불러오기 (파이프된 stdin 제외)
`j` | 한 줄 아래로 스크롤
`k` | 한 줄 위로 스크롤
`d` 또는 `Ctrl-d` | 반 페이지 아래로 스크롤
`u` 또는 `Ctrl-u` | 반 페이지 위로 스크롤
`f` 또는 `PageDown` 또는 `Space` | 한 페이지 아래로 스크롤
`b` 또는 `PageUp` | 한 페이지 위로 스크롤
`g` | 파일 시작으로 이동
`G` | 파일 끝으로 이동
`<number>G` 또는 `<number>g` | 문자열 #\<number>로 이동
`/` | 텍스트 검색
`n` | 다음 매치 또는 링크로 점프
`N` | 이전 매치 또는 링크로 점프
`Enter` | 선택한 링크를 `xdg-open`으로 열기
`Esc` | 검색 또는 링크 모드 종료

이동 전에 숫자를 입력하면 그 횟수만큼 이동이 적용됩니다.

마우스 스크롤은 설정에서 `enable_mouse_capture = true`로 활성화해야 작동하지만, 이 경우 텍스트를 선택할 수 없습니다.

### 설정

`~/.config/mdfried/config.toml` 파일은 첫 실행 시 자동으로 생성됩니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---