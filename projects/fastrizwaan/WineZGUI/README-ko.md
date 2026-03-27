# WineZGUI

#### Zenity를 이용한 Wine GUI - 플레이하고 공유하세요!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathub에서 다운로드' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## WineZGUI란?

WineZGUI(발음: 와인-지-구-이)는 윈도우 게임을 와인으로 쉽게 플레이하기 위한 와인 프런트엔드입니다. 이는 Zenity를 사용하여 더 쉬운 와인 게임 경험을 위한 와인 프리픽스 관리 및 리눅스 데스크탑 통합을 위한 Bash 스크립트 모음입니다. 파일 관리자(예: Nautilus)에서 직접 실행(설치 필요 없음) EXE 애플리케이션이나 게임을 빠르게 실행할 수 있으며, 각 윈도우 EXE 바이너리에 대해 별도의 와인 프리픽스를 생성할 수 있습니다.

## 왜 WineZGUI인가?

1. 파일 관리자에서 윈도우 게임 또는 exe 파일 실행
2. 더 쉬운 접근을 위한 애플리케이션 바로가기 생성
3. 프리픽스 설정이 아닌 게임 플레이에 집중
4. 프리픽스 백업 및 복원 기능 제공
5. 게임 번들(프리픽스+게임) 생성 및 공유 가능

## 작동 원리

1. 윈도우 바이너리 또는 exe가 WineZGUI로 열릴 때,
2. 새 프리픽스(템플릿 복사)와 EXE 파일명으로 데스크탑 바로가기가 생성됩니다.
3. 사용자가 스크립트를 실행하면 exe가 실행됩니다.
4. 설치 프로그램일 경우 설치된 exe를 감지하고 게임 메뉴 카테고리에 바로가기를 생성합니다.

## 다른 드라이브나 디렉터리에서 게임 또는 프로그램 실행 방법

터미널을 열고 다음을 입력하세요:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### WineZGUI 설치하기

WineZGUI는 Flathub에서 Flatpak으로 제공됩니다:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Flathub에서 다운로드' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI는 Desktop, Documents, Downloads, Music, Pictures, Videos 디렉토리만 접근할 수 있습니다. 다른 위치나 마운트된 파티션 또는 드라이브의 파일에 접근하려면, 이전에 언급한 디렉토리(Downloads 등)로 복사하거나 읽기 권한이 필요하며, 이는 Flatseal 앱을 사용하거나 명령어 `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`로 부여할 수 있습니다.

저는 플랫팩 버전을 사용하는 것을 강력히 추천합니다. 왜냐하면, 배포판 기반 와인(wine-staging)은 계속 업데이트되어 게임이 며칠마다 깨질 수 있기 때문입니다. 플랫허브에서 안정적인 와인을 사용하는 것이 더 낫고, 배포판 패키지에서 와인 안정 버전 5.0 또는 7.0을 사용하는 것도 좋습니다.

#### [지원되는 리눅스 배포판](https://flatpak.org/setup/)에 WineZGUI 플랫팩 설치

WineZGUI는 제가 직접 패키징한 flatpak-wine에 포함되어 있습니다. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) 제 다른 플랫팩은 현재 사용 중단된 [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)입니다.

### 리눅스 시스템에서 설정, [요구사항](https://github.com/fastrizwaan/WineZGUI#requirements) 참조

설정은 특정 디렉토리에 몇 개의 파일을 복사하는 즉시 완료됩니다.

##### 버전 0.99.13

소스 다운로드 [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) 또는 `git tag 0.99.13` 사용

##### tar.gz 사용법

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```
##### git 태그 0.99.13


```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### 개발 버전

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### WineZGUI 제거

##### Flatpak 제거

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### 시스템 제거

동일한 설치 소스 디렉터리에서 `uninstall`을 실행하세요

```
sudo ./setup --uninstall
```
## 요구 사항

`wine` - 메인 프로그램

`winetricks` - 반드시 필요한 wine 애드온 스크립트

`perl‑image‑exiftool` - 애플리케이션/게임 이름 추출용

`icoutils` - exe 파일에서 아이콘 추출용

`gnome-terminal` - (선택 사항) 셸에서 프리픽스 디렉터리 접근용

## Linux OS용 요구 사항 설치

### Flatpak 지원 배포판

모든 의존성이 포함된 [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases)을 받으세요. wine을 패키징하지 않는 배포판에 유용합니다.


```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## 런타임 의존성:

### 페도라 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### 데비안 / 우분투 / 리눅스 민트

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### 솔루스

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### 아치 리눅스 / 엔데버OS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### XBOX 호환 컨트롤러

https://github.com/paroj/xpad 에서 xbox 360 호환 컨트롤러용 커널 드라이버를 빌드하고 설치합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---