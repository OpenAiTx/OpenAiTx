[![tests](https://github.com/krupkat/xpano/actions/workflows/test.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/test.yml)
[![clang-format](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-format-check.yml)
[![clang-tidy](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml/badge.svg)](https://github.com/krupkat/xpano/actions/workflows/clang-tidy-check.yml)

# xpano

Xpano는 단순함과 사용 편의성에 중점을 둔 파노라마 스티칭 도구로, 주요 기능은 다음과 같습니다:

- 파노라마로 스티칭할 수 있는 이미지 그룹 자동 감지
- 계산된 파노라마의 미리보기 + 확대 + 이동
- 크롭 모드, 경계 자동 채우기, 선택 가능한 투영 유형
- 투영 조정: 피치, 요, 롤
- Exif 메타데이터를 포함한 고해상도 파노라마 내보내기


## 사용 기술

이 앱은 이미지 조작을 위해 훌륭한 [OpenCV](https://opencv.org/) 라이브러리와 파노라마 계산을 위한 [스티칭](https://docs.opencv.org/4.x/d1/d46/group__stitching.html) 모듈을 사용합니다.

기타 의존성으로는 [imgui](https://github.com/ocornut/imgui), [SDL](https://github.com/libsdl-org/SDL), [spdlog](https://github.com/gabime/spdlog/), [Catch2](https://github.com/catchorg/Catch2), [nativefiledialog-extended](https://github.com/btzy/nativefiledialog-extended), [alpaca](https://github.com/p-ranav/alpaca), [thread-pool](https://github.com/bshoshany/thread-pool), [expected](https://github.com/TartanLlama/expected), [Exiv2](https://github.com/Exiv2/exiv2), [multiblend](https://horman.net/multiblend/), [SIMDe](https://github.com/simd-everywhere/simde) 및 [Google Noto](https://fonts.google.com/noto) 폰트가 포함됩니다.

## 데모

[YouTube](https://youtu.be/MyiTC3i1hK0)에서 데모를 확인하세요.

![Main Xpano gui](https://gist.githubusercontent.com/krupkat/55ca0f085c944fb1ea2a7dc2a779f141/raw/f90afd675b1c0430db06a46984cbe5309908ddc1/1.webp)

## 설치

Flathub 또는 Microsoft Store에서 직접 설치하세요:

<a href='https://flathub.org/apps/details/cz.krupkat.Xpano'><img height='70' alt='Download from Flathub' src='https://flathub.org/assets/badges/flathub-badge-en.png'/></a>&nbsp;&nbsp;<a href='https://apps.microsoft.com/store/detail/9PGQ5X33L0SC?launch=true&mode=full'><img height='70' alt='Download from the Microsoft Store' src='https://get.microsoft.com/images/en-US%20dark.svg'/></a>

추가 패키지 받기:

- Windows 및 MacOS 실행 파일은 [GitHub](https://github.com/krupkat/xpano/releases)에서
- Ubuntu 패키지는 내 [Launchpad PPA](https://launchpad.net/~krupkat/+archive/ubuntu/code)에서
- Nix 패키지는 [nixpkgs](https://search.nixos.org/packages?channel=unstable&show=xpano)에서
- Archlinux AUR: [xpano-git](https://aur.archlinux.org/packages/xpano-git)에서

## 명령줄

Xpano는 기본 CLI 지원을 제공하며, 명령줄에서 완전 자동으로 실행하거나 `--gui` 플래그로 GUI를 실행할 수 있습니다.

```
Xpano [<input files>] [--output=<path>] [--gui] [--help] [--version]
```
## 개발

프로젝트는 `misc/build` 디렉터리에서 단일 스크립트를 실행하여 빌드할 수 있습니다. CMake 3.21 이상, git, 그리고 C++20을 지원하는 컴파일러가 필요합니다.

### NixOS

저장소 루트에서 빌드 스크립트를 실행하세요:


```
nix-shell misc/build/nix/default.nix
./misc/build/build-nixos.sh
```
실행 시 발생할 수 있는 문제 - [문제 해결](https://gist.github.com/krupkat/cd0adbd584e2bfe154accdb393076fc3).

### MacOS

라이브러리 필수 조건: SDL2, spdlog, catch2

brew로 설치: `brew install sdl2 spdlog catch2`

macports로 설치: `sudo port install libsdl2 spdlog catch2` (자세한 내용: [#96](https://github.com/krupkat/xpano/pull/96#issuecomment-1575589249))

저장소 루트에서 빌드 스크립트를 실행하세요:


```
./misc/build/build-macos.sh
```
### 우분투 24.04

라이브러리 전제 조건:


```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev catch2
```

저장소 루트에서 빌드 스크립트를 실행합니다:

```
./misc/build/build-ubuntu-24.sh
```

### 우분투 22.04

라이브러리 전제 조건:

```
sudo apt install libgtk-3-dev libopencv-dev libsdl2-dev libspdlog-dev
```

저장소 루트에서 빌드 스크립트를 실행하세요:

```
./misc/build/build-ubuntu-22.sh
```

### Windows

Windows 터미널에서 "Developer PowerShell for VS 2022" 프로필을 열고 저장소 루트에서 빌드 스크립트를 실행합니다:

```
./misc/build/build-windows-latest.ps1
```
## 기여

기여는 언제나 환영합니다. [오픈 이슈](https://github.com/krupkat/xpano/issues)에는 몇 가지 개선 아이디어가 있으며, 이 중 하나에 착수하시면 해당 이슈에 댓글을 남겨 주세요.

형식 및 코딩 스타일에 관한 자세한 내용은 [기여 가이드라인](https://github.com/krupkat/xpano/blob/main/CONTRIBUTING.md)을 확인해 주세요.

## 라이선스

*GPL-3.0-or-later* 라이선스 하에 배포됩니다. 자세한 내용은 전체 [라이선스 텍스트](https://github.com/krupkat/xpano/blob/main/LICENSE)를 참고하세요.

## 연락처

토마스 크룹카 - [krupkat.cz](https://krupkat.cz)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---