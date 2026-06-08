# mpv 설정

![mpv 로고](https://raw.githubusercontent.com/mpv-player/mpv.io/master/source/images/mpv-logo-128.png)

## 개요

**mpv**는 자유(자유 및 무료) 오픈 소스 크로스 플랫폼 미디어 플레이어입니다.  
다양한 미디어 파일 형식, 오디오 및 비디오 코덱, 자막 유형을 지원합니다.

이 저장소에는 제가 사용하는 개인 mpv 구성 및 스크립트가 포함되어 있으며 기본 mpv, VLC, MPC보다 훨씬 우수합니다. 설치 전에 이 README 전체를 천천히 읽어보시기 바랍니다. 일반적인 문제는 단순히 주의 깊게 읽는 것만으로 쉽게 해결할 수 있습니다.


## 미리보기

[![preview.png](https://i.postimg.cc/8zNHHPHy/preview.png)](https://postimg.cc/VdZnsw2M)

## 설치

### 윈도우

Windows에서 mpv를 설치하고 제 구성 파일을 사용하는 단계는 다음과 같습니다:  
* shinchiro가 제공하는 최신 64비트 mpv Windows 빌드를 [mpv.io/installation](https://mpv.io/installation/)에서 다운로드하거나 [여기](https://sourceforge.net/projects/mpv-player-windows/files/)에서 직접 다운로드한 후 원하는 곳에 압축을 풉니다. 이것이 이제 당신의 mpv 폴더가 됩니다.  
* `installer` 폴더에 있는 `mpv-install.bat` 파일을 마우스 오른쪽 버튼으로 클릭하여 관리자 권한으로 실행합니다.  
* 이 저장소를 ZIP 파일로 다운로드하거나 git을 사용해 클론합니다.  
* `mpv.exe`와 같은 디렉터리에 `portable_config`라는 폴더를 만듭니다 (**이것이 중요합니다**).  
* 다운로드한 저장소의 내용을 `portable_config` 폴더에 압축 해제하거나 복사합니다.  
* 일부 스크립트를 작동시키려면 릴리스 버전에서 약간 수정해야 합니다:  
  * `mpv-gif.lua` 스크립트가 작동하려면 libass가 활성화된 [FFmpeg](https://ffmpeg.org/)가 터미널에서 접근 가능해야 합니다. 자세한 내용은 스크립트 소스 저장소의 [설치 지침](https://github.com/Scheliux/mpv-gif-generator#installation)을 참조하세요.  
  * **(선택 사항)** 기본적으로 `mpv-gif.lua` 스크립트는 GIF를 `C:/Program Files/mpv/gifs`에 저장합니다. 이를 변경하려면 `portable_config/script-opts` 폴더에 있는 `gif.conf`를 텍스트 편집기로 열고 GIF 출력 디렉터리인 `dir`을 원하는 대로 지정하세요. 예: `dir="C:/Users/USERNAME/Pictures/mpv-gifs"`.  
* **(선택 사항)** 자신만의 mpv 구성을 만드세요. 제 구성 파일을 수정하거나 처음부터 직접 만들거나 다른 사람의 구성을 수정할 수 있습니다. mpv 구성 가이드를 위해 [유용한 링크](#useful-links) 섹션을 확인하세요.  
* 설정이 모두 완료되었습니다.

### 리눅스

Linux에서 mpv를 설치하고 제 구성 파일을 사용하는 단계는 다음과 같습니다:

* Linux 배포판에 기본 제공되는 패키지 관리자를 사용하여 mpv와 xclip(클립보드 CLI 인터페이스)을 설치하세요. xclip은 [copy-time.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/copy-time.lua)와 [seek-to.lua](https://github.com/noelsimbolon/mpv-config/blob/linux/scripts/seek-to.lua) 스크립트가 제대로 작동하는 데 필요합니다. mpv와 xclip의 패키지 이름은 Linux 배포판에 따라 다를 수 있습니다. 여기서는 패키지 관리자 `pacman`을 사용하는 Arch Linux를 예로 들겠습니다.

  ```
  sudo pacman -S mpv xclip
  ```
  예를 들어 Fedora Linux를 사용한다면, 패키지 관리자로 `dnf`가 제공되며, 다음 명령어로 mpv와 xclip을 설치할 수 있습니다.

  ```
  sudo dnf install mpv xclip
  ```
  다른 리눅스 배포판을 사용하는 경우, 패키지 설치 방법에 대해서는 해당 리눅스 배포판의 패키지 관리자 문서를 참조하세요.

* 이 저장소를 ZIP 파일로 다운로드하거나(또는 git으로 클론) 표준 mpv 설정 디렉토리인 `~/.config/mpv`에 압축을 풀거나 복사하세요.
* 강조할 몇 가지 사항:
  * `mpv-gif.lua` 스크립트가 작동하려면 libass가 활성화된 [FFmpeg](https://ffmpeg.org/)가 터미널에서 접근 가능해야 합니다. 자세한 내용은 스크립트 소스 저장소의 [설치 지침](https://github.com/Scheliux/mpv-gif-generator#installation)을 참조하세요.
  * **(선택 사항)** 기본적으로 `mpv-gif.lua` 스크립트는 GIF를 `~/Videos/mpv-gifs`에 저장합니다. 이를 변경하려면 `portable_config/script-opts` 폴더 내 `gif.conf` 파일을 텍스트 편집기로 열고 GIF 출력 디렉토리인 `dir`을 원하는 대로 지정하세요. 예: `dir="~/Videos"`.
* **(선택 사항)** 직접 mpv 설정을 만드세요. 제 설정 파일을 수정하거나 새로 만들거나 다른 설정을 수정하여 가능합니다. mpv 설정 가이드는 [유용한 링크](#useful-links) 섹션을 확인하세요.
* 모든 준비가 완료되었습니다.

## 스크립트

외부 소스의 스크립트:

* audio-visualizer.lua ([소스](https://github.com/mfcc64/mpv-scripts#visualizerlua))\
  다양한 오디오 시각화. 오디오 파일을 열었을 때만 작동합니다.
  
* autoload.lua ([소스](https://github.com/mpv-player/mpv/blob/master/TOOLS/lua/autoload.lua))\
  현재 재생 중인 파일 전후의 재생목록 항목을 자동으로 불러오며, 디렉토리를 스캔합니다.

* copy-timestamp.lua ([소스](https://github.com/linguisticmind/mpv-scripts/tree/master/copy-timestamp))\
  현재 시간 코드를 HH:MM:SS.MS 형식으로 클립보드에 복사합니다. 플랫폼 간 호환(Mac, Windows, Linux).

* cycle-commands.lua ([소스](https://github.com/CogentRedTester/mpv-scripts#cycle-commands))\
  키 입력 시 일련의 명령을 순환 실행합니다. 각 순환에는 원하는 만큼 명령을 포함할 수 있습니다. 구문 상세는 파일 상단 참조.

* cycle-profile.lua ([소스](https://github.com/CogentRedTester/mpv-scripts#cycle-profile))\
  스크립트 메시지를 통해 전달된 프로필 목록을 순환하며 프로필 설명을 OSD에 출력합니다. 자세한 내용은 파일 상단 참조.

* modernz.lua ([소스](https://github.com/Samillion/ModernZ))\
  기본 OSC 기능을 유지한 현대적인 MPV OSC UI 대체 스크립트입니다.

* mpv-gif.lua ([소스](https://github.com/Scheliux/mpv-gif-generator))\
  비디오 재생에서 GIF를 생성하는 스크립트입니다. libass가 활성화된 FFmpeg가 필요합니다. 자막이 포함된 GIF 내보내기는 현재 제대로 작동하지 않습니다.

* playlistmanager.lua ([소스](https://github.com/jonniek/mpv-playlistmanager))\
  재생목록을 직관적으로 보고 조작할 수 있게 해줍니다.

* seek-to.lua ([소스](https://github.com/dexeonify/mpv-config/blob/main/scripts/seek-to.lua))\
  키보드 입력이나 클립보드에서 붙여넣은 절대 타임스탬프로 이동합니다.

* sponsorblock-minimal.lua ([소스](https://codeberg.org/jouni/mpv_sponsorblock_minimal))\
  유튜브 영상에서 스폰서 구간을 건너뜁니다.

* thumbfast.lua ([소스](https://github.com/po5/thumbfast))\
  mpv를 위한 고성능 실시간 썸네일러입니다. **이 스크립트는 자체적으로 썸네일을 표시하지 않으며**, thumbfast를 호출하는 UI 스크립트와 함께 사용하도록 설계되었습니다.

이 스크립트들의 설정 파일은 `script-opts` 폴더에서 찾을 수 있습니다. 또한 일부 스크립트의 기본 키 바인딩을 수정했습니다. 수정 내용을 보려면 `input.conf`에서 스크립트 키 바인딩을 확인하세요.

## 셰이더

`shaders` 폴더에 포함된 셰이더:

* ArtCNN_C4F32 ([소스](https://github.com/Artoriuz/ArtCNN/blob/main/GLSL/ArtCNN_C4F32.glsl))\
  명도 업스케일링에 사용됩니다.

* nnedi3-nns128-win8x4 ([소스](https://github.com/bjin/mpv-prescalers/tree/master))\
  명도 업스케일링에 사용됩니다.

선호도와 시스템 성능에 따라 셰이더를 선택하여 사용하세요. 셰이더에 대한 자세한 정보는 [유용한 링크](#useful-links) 섹션의 자료를 참고하세요.

## 유용한 링크

* The Wiki의 [mpv 튜토리얼](https://thewiki.moe/tutorials/mpv/)
* iamscum의 [mpv.conf 가이드](https://iamscum.wordpress.com/guides/videoplayback-guide/mpv-conf/)
* Kokomins의 [비디오 감상을 위한 mpv 설정 가이드](https://kokomins.wordpress.com/2019/10/14/mpv-config-guide/)
* João Vitor Chrisóstomo의 [mpv 리샘플링](https://artoriuz.github.io/blog/mpv_upscaling.html)

## 공식 링크

* [mpv 홈페이지](https://mpv.io/)  
* [mpv 위키](https://github.com/mpv-player/mpv/wiki)
* [mpv FAQ](https://github.com/mpv-player/mpv/wiki/FAQ)
* [mpv 매뉴얼](https://mpv.io/manual/stable/)
* [mpv 사용자 스크립트](https://github.com/mpv-player/mpv/wiki/User-Scripts)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---