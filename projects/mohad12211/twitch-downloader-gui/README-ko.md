# twitch-downloader-gui

이것은 훌륭한 프로젝트 [TwitchDownloader](https://github.com/lay295/TwitchDownloader)의 CLI 버전을 위한 GUI 래퍼로, Linux 전용입니다.  
저는 라이브러리 [libui-ng](https://github.com/libui-ng/libui-ng)를 몇 가지 추가 [패치](https://github.com/mohad12211/libui-ng)와 함께 사용했습니다.  
이 라이브러리는 아직 중간 알파 단계이지만, 유망한 프로젝트이며, 간단하고 크로스 플랫폼(macos도 가능하지만 저는 크게 신경 쓰지 않습니다), 매우 직관적입니다.

# 미리보기

![preview](https://user-images.githubusercontent.com/51754973/167058990-a574493a-fd44-4f12-be59-185798fb93bf.gif)

# 설치

> [!IMPORTANT]  
> **이것은 CLI를 위한 단순 래퍼이며, 여전히 `TwitchDownloaderCLI` 바이너리가 필요합니다. 기본적으로 앱은 `PATH`에서 바이너리를 찾으려 시도합니다.**  
> **`TwitchDownloaderCLI`를 `PATH`에 추가하기 싫다면 설정에서 바이너리 경로를 지정할 수 있습니다. `TwitchDownloaderCLI`가 실행 가능하도록 설정되어 있는지 확인하세요.**

Debian, Fedora 및 [AUR](https://aur.archlinux.org/packages/twitch-downloader-gui)용 패키지가 제공됩니다.

### 의존성

- ffmpeg (채팅 및 VOD 렌더링에 필요)  
- libcurl  
- TwitchDownloaderCLI (아래 참조)

# 빌드

### 빌드 의존성

- make  
- libcurl (개발 버전)  
- gtk3 (개발 버전, 우분투에서는 libgtk-3-dev라고 함)

libui의 정적 라이브러리가 저장소에 포함되어 있지만, 직접 컴파일한 버전을 사용하여 교체할 수 있습니다. 자세한 설명은 [여기](https://github.com/mohad12211/libui-ng/blob/customs/README.md#quick-building-instructions)를 참조하세요.


```
$ git clone https://github.com/mohad12211/twitch-downloader-gui.git
$ cd twitch-downloader-gui
$ make
$ make install # (if you want to install the app to your system)
$ make uninstall # (to uninstall)
```
바이너리는 `build/bin` 안에 있습니다

# 모든 기능이 포함되어 있나요? 버그가 있나요?

기본 기능들은 포함되어 있으며, 작업 대기열은 없습니다.

## 버그...

- VOD에서 가장 높은 화질만 다운로드할 수 있습니다 (곧 해결할 예정입니다).

버그가 있으면 신고해 주세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---