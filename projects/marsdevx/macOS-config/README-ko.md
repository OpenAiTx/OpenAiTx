<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/logo.png" width="320px" alt="macOS Config Logo">
</div>

<br>

<div align="center">

  [![Last Commit](https://custom-icon-badges.demolab.com/github/last-commit/marsdevx/macOS-config?logoColor=white&labelColor=2C2C2C&label=Last%20Commit&color=8A2BE2&logo=mark-github)](https://github.com/marsdevx/macOS-config/commits/main "Last Commit")
  [![Languages](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Languages&message=Bash%20%7C%20Lua&color=D32F2F&logo=file-code)](https://github.com/marsdevx/macOS-config "Languages")
  <br>
  [![Supported Platforms](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Platform&message=MacBook&color=748ADB&logo=apple)](https://github.com/marsdevx/macOS-config "Supported Platforms")
  [![Wallpapers](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Includes&message=Wallpapers&color=F47F42&logo=file-media)](https://github.com/marsdevx/macOS-config/tree/main/wallpapers "Wallpapers")
  [![Customization](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=Customization&message=Ricing&color=009688&logo=sparkles-fill)](https://github.com/marsdevx/macOS-config "Customization")
  [![License](https://custom-icon-badges.demolab.com/static/v1?logoColor=white&labelColor=2C2C2C&label=License&message=MIT&color=00C853&logo=law)](https://github.com/marsdevx/macOS-config/blob/main/LICENSE "License")

</div>

---

#  macOS Config

**macOS Config** is an **open-source** project designed to streamline the setup of your **MacBook** with **custom** settings, **program installations**, and **wallpapers**. Built using **shell** scripts, this tool **automates** the process of **configuring** your **macOS environment** for **productivity** and **ricing**.

* Specifically designed for **macOS customization** and **ricing**.
* Includes `.sh` **scripts** to **install** all programs you need for **work**.
* Applies your custom settings for installed programs **automatically**.
* Adds your favorite **wallpapers** for a personalized **macOS experience**.

Transform your MacBook into a fully customized workspace with this powerful and efficient tool!

---

## 🖼️ Preview

<div align="center">
  <img src="https://raw.githubusercontent.com/marsdevx/macOS-config/main/imgs/preview.png" alt="Preview">
</div>

---
## 🛠️ 설치

이 프로젝트를 설치하려면 시스템에서 터미널 앱을 실행하고 아래 명령어를 실행하세요. <br>
  - 첫 번째 명령어 실행 후 Xcode 명령줄 도구 다운로드를 요청하는 팝업이 나타나면, “다운로드”를 클릭한 후 다시 첫 번째 명령어를 실행하세요.

1. **리포지토리 복제**

```zsh
git clone https://github.com/marsdevx/macOS-config.git ~/Downloads/macOS-config
```
2. **홈브류 설치**

```zsh
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
echo 'eval "$(/opt/homebrew/bin/brew shellenv)"' >> ~/.zshrc
eval "$(/opt/homebrew/bin/brew shellenv)"
```

3. **바탕화면 아이콘 비활성화**
```zsh
defaults write com.apple.finder CreateDesktop false; killall Finder
```

4. **구성 디렉터리 생성**
```zsh
mkdir -p ~/.config
```
5. **시스템 설정 업데이트**

  - 손쉬운 사용 및 제어 센터  
    - 시스템 설정 -> 손쉬운 사용 -> 디스플레이 -> 동작 줄이기 -> 켬  
    - 시스템 설정 -> 제어 센터 -> 메뉴 막대 자동으로 숨기기 및 표시 -> 항상  

  - 데스크탑 및 독  
    - 시스템 설정 -> 데스크탑 및 독 -> 독 자동으로 숨기기 및 표시 -> 켬  
    - 시스템 설정 -> 데스크탑 및 독 -> 최근 사용을 기준으로 스페이스 자동 재배치 -> 끔  
    - 시스템 설정 -> 데스크탑 및 독 -> 애플리케이션 전환 시 해당 스페이스로 전환 ... -> 끔  
    - 시스템 설정 -> 데스크탑 및 독 -> 애플리케이션별 창 그룹화 -> 끔  
    - 시스템 설정 -> 데스크탑 및 독 -> 디스플레이별 개별 스페이스 -> 켬  

  - 키보드  
    - 시스템 설정 -> 키보드 -> 키보드 단축키 -> Spotlight -> Spotlight 검색 표시 -> 끔  
    - 시스템 설정 -> 키보드 -> 키보드 단축키 -> Spotlight -> Finder 검색 창 표시 -> 끔  
    - 시스템 설정 -> 키보드 -> 키보드 단축키 -> Mission Control -> 데스크탑 1로 전환 -> 켬  
    - 시스템 설정 -> 키보드 -> 키보드 단축키 -> Mission Control -> 데스크탑 2로 전환 -> 켬  
    - 시스템 설정 -> 키보드 -> 키보드 단축키 -> Mission Control -> 데스크탑 3로 전환 -> 켬  
    - 시스템 설정 -> 키보드 -> 키보드 단축키 -> Mission Control -> 데스크탑 4로 전환 -> 켬  
    - 시스템 설정 -> 키보드 -> 키보드 단축키 -> Mission Control -> 데스크탑 5로 전환 -> 켬  

---

## 🚀 사용법

1. **루프**

> 윈도우 관리자


```zsh
zsh ~/Downloads/macOS-config/loop.sh
```
- 스크립트를 실행한 후, Loop 앱을 다음 설정으로 구성합니다  
  - 강조 색상 -> 배경화면 -> 그라데이션 -> 켬  
  - 동작 -> 로그인 시 실행 -> 켬  
  - 동작 -> 애니메이션 속도 -> 부드럽게  
  - 동작 -> 여백 포함 -> 켬 -> 여백 설정 -> 7px  
  - 동작 -> 커서가 있는 화면 사용 -> 끔  
  - 단축키 -> 가운데 -> 제거  
  - 단축키 -> 추가 -> 일반 -> macOS 가운데 -> Fn + Enter  

<br>

2. **Raycast**

> 애플리케이션 실행하기


```zsh
zsh ~/Downloads/macOS-config/raycast.sh
```
- 스크립트를 실행한 후, Raycast 앱을 다음 설정으로 구성하세요  
  - Start Setup 클릭 -> Continue 클릭.  
  - 새 단축키 설정: Record New Hotkey -> Cmd + Space 할당.  
  - Continue 클릭하여 완료하세요.  

<br>  

3. **Sketchybar**  

> 사용자 정의 가능한 상단 바


```zsh
zsh ~/Downloads/macOS-config/sketchybar.sh
```

<br>

4. **SKHD**

> Hotkey manager

```zsh
zsh ~/Downloads/macOS-config/skhd.sh
```

<br>

5. **Yabai**

> Window manager for multiple workspaces

```zsh
zsh ~/Downloads/macOS-config/yabai.sh
```

<br>

5. **아이텀**

> 터미널 앱

- 오 마이 Zsh 설치하기
```zsh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"
```

- Oh My Zsh용 테마 설치하기
```zsh
git clone https://github.com/romkatv/powerlevel10k.git $ZSH_CUSTOM/themes/powerlevel10k
```
- Iterm2를 설치하고 설정합니다

```zsh
zsh ~/Downloads/macOS-config/iterm.sh
```
- zshrc 업데이트

```zsh
source ~/.zshrc
```
- Powerlevel10k 구성
  - 스타일: Lean
  - 문자 집합: 유니코드
  - 색상 구성표: 8색
  - 프롬프트 구분자: 없음
  - 레이아웃: 두 줄
  - 연결 상태: 연결 끊김
  - 프롬프트 정렬: 왼쪽
  - 강조 색상: 파랑
  - 프롬프트 밀도: 드문드문
  - 아이콘 스타일: 다수 아이콘
  - 프롬프트 스타일: 간결함
  - 즉시 프롬프트: 있음
  - 상세 정도: 자세함

- iTerm2 구성
  - iTerm2를 열고 설정으로 이동합니다.
    - 일반 -> 닫기 -> "Quit iTerm2 (CmdQ)" 확인 -> 끔
    - 외관 -> 일반 -> 테마: Minimal
    - 외관 -> 일반 -> 상단 바 위치: 하단
    - 외관 -> 창 -> 스크롤바 숨기기 -> 켬
    - 외관 -> 창 -> 제목 표시줄 아래 선 표시 ... -> 끔
    - 외관 -> 창 -> 측면 여백: 8
    - 외관 -> 창 -> 상하 여백: 12
    - 프로필 -> 색상 -> 색상 사전 설정 -> 가져오기 -> 다운로드 -> rose-pine.itermcolors
    - 프로필 -> 색상 -> 색상 사전 설정 -> rose-pine
    - 프로필 -> 창 -> 투명도: 7
    - 프로필 -> 텍스트 -> 글꼴 -> MesloLGS NF
    - 프로필 -> 텍스트 -> 글꼴 크기 -> 13
    - 프로필 -> 셸 통합 -> 표시 표시기 -> 끔

<br>

6. **배경화면**

> 내 배경화면 구성

- 시스템 설정 열기
  - 배경화면 -> 폴더 또는 앨범 추가 -> 폴더 선택 -> 다운로드 -> macOS-config -> wallpapers

  - 페이지 하단의 wallpapers 폴더를 클릭하세요
  - 설정을 조정하세요:
    - 셔플: 매분
    - 모든 공간에서 표시: 켬

---

## 📋 라이선스

이 저장소에 포함된 모든 코드는 [MIT 라이선스](LICENSE)를 따릅니다

```
MIT License

Copyright (c) 2025 marsdevx

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## ⭐ 지원

이 프로젝트가 마음에 드신다면, 잊지 말고 ⭐ **별점**을 주시고 **팔로우** 해주세요!  
여러분의 **지원**이 더 많은 프로젝트를 만드는 데 큰 도움이 됩니다. 🚀  

🔗 **[GitHub](https://github.com/marsdevx?tab=repositories)에서 더 많은 제 작업을 탐험하고 흥미로운 프로젝트들을 발견해보세요!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---