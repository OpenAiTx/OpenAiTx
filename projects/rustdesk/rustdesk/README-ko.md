<p align="center">
  <img src="res/logo-header.svg" alt="RustDesk - Your remote desktop"><br>
  <a href="#raw-steps-to-build">빌드</a> •
  <a href="#how-to-build-with-docker">Docker</a> •
  <a href="#file-structure">구조</a> •
  <a href="#snapshot">스냅샷</a><br>
  [<a href="docs/README-UA.md">Українська</a>] | [<a href="docs/README-CS.md">česky</a>] | [<a href="docs/README-ZH.md">中文</a>] | [<a href="docs/README-HU.md">Magyar</a>] | [<a href="docs/README-ES.md">Español</a>] | [<a href="docs/README-FA.md">فارسی</a>] | [<a href="docs/README-FR.md">Français</a>] | [<a href="docs/README-DE.md">Deutsch</a>] | [<a href="docs/README-PL.md">Polski</a>] | [<a href="docs/README-ID.md">Indonesian</a>] | [<a href="docs/README-FI.md">Suomi</a>] | [<a href="docs/README-ML.md">മലയാളം</a>] | [<a href="docs/README-JP.md">日本語</a>] | [<a href="docs/README-NL.md">Nederlands</a>] | [<a href="docs/README-IT.md">Italiano</a>] | [<a href="docs/README-RU.md">Русский</a>] | [<a href="docs/README-PTBR.md">Português (Brasil)</a>] | [<a href="docs/README-EO.md">Esperanto</a>] | [<a href="docs/README-KR.md">한국어</a>] | [<a href="docs/README-AR.md">العربي</a>] | [<a href="docs/README-VN.md">Tiếng Việt</a>] | [<a href="docs/README-DA.md">Dansk</a>] | [<a href="docs/README-GR.md">Ελληνικά</a>] | [<a href="docs/README-TR.md">Türkçe</a>] | [<a href="docs/README-NO.md">Norsk</a>]<br>
  <b>이 README, <a href="https://github.com/rustdesk/rustdesk/tree/master/src/lang">RustDesk UI</a>, 그리고 <a href="https://github.com/rustdesk/doc.rustdesk.com">RustDesk 문서</a>를 여러분의 모국어로 번역하는 데 도움을 주실 분을 찾고 있습니다.</b>
</p>

> [!Caution]
> **오용 주의:** <br>
> RustDesk 개발자는 이 소프트웨어의 비윤리적이거나 불법적인 사용을 용납하거나 지원하지 않습니다. 무단 접근, 제어 또는 사생활 침해 등과 같은 오용은 엄격히 금지되어 있습니다. 저자는 애플리케이션의 오용에 대해 책임지지 않습니다.

문의/채팅: [Discord](https://discord.gg/nDceKgxnkV) | [Twitter](https://twitter.com/rustdesk) | [Reddit](https://www.reddit.com/r/rustdesk) | [YouTube](https://www.youtube.com/@rustdesk)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I04VU09)

또 하나의 원격 데스크톱 소프트웨어로, Rust로 작성되었습니다. 별도의 설정 없이 바로 사용할 수 있습니다. 데이터에 대한 완전한 제어권을 가지며, 보안에 대한 걱정이 없습니다. 저희의 중계/릴레이 서버를 사용할 수도 있고, [직접 서버를 구축](https://rustdesk.com/server)하거나 [직접 중계/릴레이 서버를 작성](https://github.com/rustdesk/rustdesk-server-demo)할 수도 있습니다.

![image](https://user-images.githubusercontent.com/71636191/171661982-430285f0-2e12-4b1d-9957-4a58e375304d.png)

RustDesk는 모든 사람의 기여를 환영합니다. 시작하는 데 도움이 필요하다면 [CONTRIBUTING.md](docs/CONTRIBUTING.md)를 참고하세요.

[**FAQ**](https://github.com/rustdesk/rustdesk/wiki/FAQ)

[**바이너리 다운로드**](https://github.com/rustdesk/rustdesk/releases)

[**나이트리 빌드**](https://github.com/rustdesk/rustdesk/releases/tag/nightly)

[<img src="https://f-droid.org/badge/get-it-on.png"
    alt="Get it on F-Droid"
    height="80">](https://f-droid.org/en/packages/com.carriez.flutter_hbb)
[<img src="https://flathub.org/api/badge?svg&locale=en"
    alt="Get it on Flathub"
    height="80">](https://flathub.org/apps/com.rustdesk.RustDesk)

## 의존성

데스크톱 버전은 GUI를 위해 Flutter 또는 Sciter(지원 중단)를 사용합니다. 이 튜토리얼은 시작이 더 쉽고 친숙한 Sciter 전용입니다. Flutter 버전 빌드는 [CI](https://github.com/rustdesk/rustdesk/blob/master/.github/workflows/flutter-build.yml)를 참고하세요.

Sciter 동적 라이브러리는 직접 다운로드하셔야 합니다.

[Windows](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.win/x64/sciter.dll) |
[Linux](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so) |
[macOS](https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.osx/libsciter.dylib)

## 빌드 기본 단계

- Rust 개발 환경과 C++ 빌드 환경 준비

- [vcpkg](https://github.com/microsoft/vcpkg) 설치 및 `VCPKG_ROOT` 환경 변수 올바르게 설정

  - Windows: vcpkg install libvpx:x64-windows-static libyuv:x64-windows-static opus:x64-windows-static aom:x64-windows-static
  - Linux/macOS: vcpkg install libvpx libyuv opus aom

- `cargo run` 실행

## [빌드](https://rustdesk.com/docs/en/dev/build/)

## 리눅스에서 빌드 방법

### Ubuntu 18 (Debian 10)

```sh
sudo apt install -y zip g++ gcc git curl wget nasm yasm libgtk-3-dev clang libxcb-randr0-dev libxdo-dev \
        libxfixes-dev libxcb-shape0-dev libxcb-xfixes0-dev libasound2-dev libpulse-dev cmake make \
        libclang-dev ninja-build libgstreamer1.0-dev libgstreamer-plugins-base1.0-dev libpam0g-dev
```

### openSUSE Tumbleweed

```sh
sudo zypper install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libXfixes-devel cmake alsa-lib-devel gstreamer-devel gstreamer-plugins-base-devel xdotool-devel pam-devel
```

### Fedora 28 (CentOS 8)

```sh
sudo yum -y install gcc-c++ git curl wget nasm yasm gcc gtk3-devel clang libxcb-devel libxdo-devel libXfixes-devel pulseaudio-libs-devel cmake alsa-lib-devel gstreamer1-devel gstreamer1-plugins-base-devel pam-devel
```

### Arch (Manjaro)

```sh
sudo pacman -Syu --needed unzip git cmake gcc curl wget yasm nasm zip make pkg-config clang gtk3 xdotool libxcb libxfixes alsa-lib pipewire
```

### vcpkg 설치

```sh
git clone https://github.com/microsoft/vcpkg
cd vcpkg
git checkout 2023.04.15
cd ..
vcpkg/bootstrap-vcpkg.sh
export VCPKG_ROOT=$HOME/vcpkg
vcpkg/vcpkg install libvpx libyuv opus aom
```

### libvpx 수정 (Fedora용)

```sh
cd vcpkg/buildtrees/libvpx/src
cd *
./configure
sed -i 's/CFLAGS+=-I/CFLAGS+=-fPIC -I/g' Makefile
sed -i 's/CXXFLAGS+=-I/CXXFLAGS+=-fPIC -I/g' Makefile
make
cp libvpx.a $HOME/vcpkg/installed/x64-linux/lib/
cd
```

### 빌드

```sh
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
source $HOME/.cargo/env
git clone --recurse-submodules https://github.com/rustdesk/rustdesk
cd rustdesk
mkdir -p target/debug
wget https://raw.githubusercontent.com/c-smile/sciter-sdk/master/bin.lnx/x64/libsciter-gtk.so
mv libsciter-gtk.so target/debug
VCPKG_ROOT=$HOME/vcpkg cargo run
```

## Docker로 빌드하는 방법

먼저 저장소를 클론하고 Docker 컨테이너를 빌드합니다:

```sh
git clone https://github.com/rustdesk/rustdesk
cd rustdesk
git submodule update --init --recursive
docker build -t "rustdesk-builder" .
```

이후, 애플리케이션을 빌드할 때마다 다음 명령어를 실행합니다:

```sh
docker run --rm -it -v $PWD:/home/user/rustdesk -v rustdesk-git-cache:/home/user/.cargo/git -v rustdesk-registry-cache:/home/user/.cargo/registry -e PUID="$(id -u)" -e PGID="$(id -g)" rustdesk-builder
```

처음 빌드는 의존성 캐시가 쌓이기 전이므로 시간이 오래 걸릴 수 있습니다. 이후 빌드는 더 빨라집니다. 빌드 명령에 다른 인자를 지정하려면 명령 끝의 `<OPTIONAL-ARGS>` 위치에 추가하면 됩니다. 예를 들어, 최적화된 릴리즈 버전을 빌드하려면 위 명령에 `--release`를 추가하세요. 결과 실행 파일은 시스템의 target 폴더에 생성되며 다음과 같이 실행할 수 있습니다:

```sh
target/debug/rustdesk
```

또는 릴리즈 실행 파일의 경우:

```sh
target/release/rustdesk
```

이 명령들은 반드시 RustDesk 저장소의 루트 디렉터리에서 실행해야 하며, 그렇지 않으면 애플리케이션이 필요한 리소스를 찾지 못할 수 있습니다. 또한, `install`이나 `run`과 같은 다른 cargo 하위 명령은 현재 이 방식으로 지원되지 않습니다. 이 경우 프로그램이 호스트가 아니라 컨테이너 안에서 설치 또는 실행됩니다.

## 파일 구조

- **[libs/hbb_common](https://github.com/rustdesk/rustdesk/tree/master/libs/hbb_common)**: 비디오 코덱, 설정, tcp/udp 래퍼, protobuf, 파일 전송용 파일 시스템 함수 및 기타 유틸리티 함수
- **[libs/scrap](https://github.com/rustdesk/rustdesk/tree/master/libs/scrap)**: 화면 캡처
- **[libs/enigo](https://github.com/rustdesk/rustdesk/tree/master/libs/enigo)**: 플랫폼별 키보드/마우스 제어
- **[libs/clipboard](https://github.com/rustdesk/rustdesk/tree/master/libs/clipboard)**: Windows, Linux, macOS용 파일 복사 및 붙여넣기 구현
- **[src/ui](https://github.com/rustdesk/rustdesk/tree/master/src/ui)**: 지원 중단된 Sciter UI
- **[src/server](https://github.com/rustdesk/rustdesk/tree/master/src/server)**: 오디오/클립보드/입력/비디오 서비스 및 네트워크 연결
- **[src/client.rs](https://github.com/rustdesk/rustdesk/tree/master/src/client.rs)**: 피어 연결 시작
- **[src/rendezvous_mediator.rs](https://github.com/rustdesk/rustdesk/tree/master/src/rendezvous_mediator.rs)**: [rustdesk-server](https://github.com/rustdesk/rustdesk-server)와 통신, 원격 직접(TCP 홀펀칭) 또는 릴레이 연결 대기
- **[src/platform](https://github.com/rustdesk/rustdesk/tree/master/src/platform)**: 플랫폼별 코드
- **[flutter](https://github.com/rustdesk/rustdesk/tree/master/flutter)**: 데스크톱 및 모바일용 Flutter 코드
- **[flutter/web/js](https://github.com/rustdesk/rustdesk/tree/master/flutter/web/v1/js)**: Flutter 웹 클라이언트용 자바스크립트

## 스크린샷

![Connection Manager](https://github.com/rustdesk/rustdesk/assets/28412477/db82d4e7-c4bc-4823-8e6f-6af7eadf7651)

![Connected to a Windows PC](https://github.com/rustdesk/rustdesk/assets/28412477/9baa91e9-3362-4d06-aa1a-7518edcbd7ea)

![File Transfer](https://github.com/rustdesk/rustdesk/assets/28412477/39511ad3-aa9a-4f8c-8947-1cce286a46ad)

![TCP Tunneling](https://github.com/rustdesk/rustdesk/assets/28412477/78e8708f-e87e-4570-8373-1360033ea6c5)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---