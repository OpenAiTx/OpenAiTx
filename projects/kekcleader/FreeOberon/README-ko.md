# Free Oberon 프로그래밍 환경

» [free.oberon.org](https://free.oberon.org/en)

Oberon은 범용 프로그래밍 언어로, Pascal과 Modula-2의 직접적인 후손입니다. Pascal과 Modula보다 더 간단하면서도 훨씬 강력합니다.

Free Oberon은 고전적인 의사 그래픽 스타일—Pascal의 유명한 파란 화면으로 디자인된 Oberon 프로그래밍 언어를 위한 크로스 플랫폼 통합 개발 환경입니다. Windows, macOS 및 Linux에서 사용할 수 있습니다.

Fob는 편리한 콘솔 기반 Oberon 컴파일러입니다.

![Free Oberon screenshot](http://free.oberon.org/images/screenshot.png)

![Game of Life animation in Oberon](http://free.oberon.org/images/life.gif)

*아래에서 영어 텍스트를 참조하세요.*

# Free Oberon 프로그래밍 환경

Oberon은 범용 프로그래밍 언어로, Pascal과 Modula-2의 직접적인 후손입니다. Pascal과 Modula보다 더 간단하면서도 훨씬 강력합니다.

Free Oberon은 고전적인 의사 그래픽 스타일—Pascal의 유명한 파란 화면으로 디자인된 Oberon 프로그래밍 언어를 위한 크로스 플랫폼 통합 개발 환경입니다. Windows, macOS 및 Linux에서 사용할 수 있습니다.

Fob는 콘솔 기반 Oberon 컴파일러입니다.

* 버전 1.1.0-alpha.7
* 리가, 2023년 1월 11일
* 사이트: [free.oberon.org](https://free.oberon.org)

# 설치

## 리눅스 설치

1. 의존성:

   Allegro (개발 패키지), Git, GCC

   Debian / Ubuntu / Linux Mint 등 OS에서:
   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   или:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   페도라 OS에서:


   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel
   ```
   아치 리눅스에서:

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```
   오픈수세에서:

   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. tar.gz 아카이브 형태의 Free Oberon을  
   [free.oberon.org](https://free.oberon.org/download) 사이트에서 다운로드하여  
   홈 디렉토리(또는 다른 위치)에 압축을 풉니다.  

   최신 빌드 버전:  

   https://github.com/kekcleader/FreeOberon.git 사이트에서  
   녹색 'Code' 버튼을 클릭하고 'Download ZIP'을 선택한 후,  
   홈 디렉토리에 압축을 풉니다.  
   디렉토리 이름을 `FreeOberon-main`에서 `FreeOberon`으로 변경합니다.  

3. 압축을 푼 디렉토리에서 `install.sh`를 실행합니다.

  ```
  ./install.sh
  ```

4. (선택 사항) 파일 `~/.bashrc`의 끝에 다음 줄을 추가하세요:
  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  이렇게 하면 `fo` 명령으로 Free Oberon을 실행할 수 있습니다.

  특정 언어로 Free Oberon을 실행하려면 언어(en 또는 ru)를 지정하세요:
  ```
  ./FreeOberon --lang ru
  ```
  или
  ```
  fo --lang ru
  ```

## Windows에 설치하기

[free.oberon.org](https://free.oberon.org) 사이트에서 아카이브를 다운로드하고, 비라틴 문자가 포함되지 않은 경로에 압축을 푼 후 `FreeOberon.exe`를 실행하세요.

참고. 윈도우용 Free Oberon 버전을 소스 코드에서 직접 빌드하려면 [free.oberon.org의 Free Oberon 문서](http://free.oberon.org/files/FreeOberon_v1.1.0.pdf) 부록 A를 참조하세요.


# 사용법

Free Oberon을 실행하고 Oberon 언어로 프로그램 모듈의 텍스트를 입력하거나, 예제 프로그램 파일(예: `Life.Mod`)을 여세요. `F9`를 눌러 프로그램을 컴파일하고 실행합니다.
프로그램의 소스 파일은 `Programs` 하위 폴더에 저장되고, 컴파일된 실행 파일은 `bin` 하위 폴더에 저장됩니다. 컴파일 과정에서 리눅스(윈도우)용으로 `Data/bin/compile.sh`(`Data\bin\compile.bat`) 스크립트가 사용됩니다. 이 스크립트는 수정할 수 있습니다.

여러 모듈로 이루어진 프로그램을 작성할 수 있습니다. 주 모듈을 열고 `F9`를 누르면 Free Oberon이 자동으로 올바른 순서대로 컴파일하고 링크합니다.

주 모듈 파일이 `Programs` 하위 폴더 바로 아래에 없으면, 컴파일된 실행 파일은 해당 모듈 파일이 있는 곳에 생성되며, `_Build` 하위 폴더에는 생성되지 않습니다.

프로그램의 어떤 모듈에서 에러가 발견되면 해당 파일이 열리고, 에러 위치와 내용이 표시됩니다. 다시 컴파일하려면 주 모듈 창으로 돌아가 `F9`를 누르세요.

[버전 기록](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)

______


*영문*

* 버전 1.1.0-alpha.7
* 리가, 2023년 1월 11일
* 웹사이트: [free.oberon.org](https://free.oberon.org/en)

# 설치

## 리눅스에 설치하기

1. 의존성:

   Allegro(개발 패키지), Git, GCC

   Debian / Ubuntu / Linux Mint 등 OS에서:

   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   or:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```

   페도라 운영 체제에서:

   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel argro5-addon-dialog-devel
   ```

   Arch Linux에서:
   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```

   openSUSE에서:
   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. tar.gz 형식의 Free Oberon을  
   [free.oberon.org](https://free.oberon.org/en/download)에서 다운로드하고  
   홈 디렉토리(또는 다른 원하는 위치)에 압축을 풉니다.  

   옵션 (최신 빌드):  

   https://github.com/kekcleader/FreeOberon.git에 접속하여  
   "Code"라는 초록색 버튼을 클릭한 후 "Download ZIP"을 클릭하고,  
   압축 파일을 홈 디렉토리에 풉니다.  
   디렉토리 이름을 `FreeOberon-main`에서 `FreeOberon`으로 변경합니다.  

3. 압축을 푼 디렉토리 내에서 `install.sh`를 실행합니다.

  ```
  ./install.sh
  ```

4. (선택 사항) 다음 줄을 `~/.bashrc` 파일 끝에 추가합니다:
  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  이렇게 하면 `fo` 명령어를 사용하여 Free Oberon을 실행할 수 있습니다.

  특정 언어(en 또는 ru)로 Free Oberon을 실행하려면, 해당 언어를 지정하세요:
  ```
  ./FreeOberon --lang ru
  ```
  or
  ```
  fo --lang ru
  ```

## Windows에 설치하기

ZIP 아카이브로 Free Oberon을 다운로드합니다 ([free.oberon.org](https://free.oberon.org/en)에서), 디스크 경로에 비라틴 문자가 없는 경로에 압축을 풀고 `FreeOberon.exe`를 실행합니다.

참고. Windows에서 소스 코드를 사용해 Free Oberon을 다시 컴파일하려면 [free.oberon.org의 Free Oberon 문서 부록 A](https://free.oberon.org/files/FreeOberon_v1.1.0_en.pdf)를 참조하십시오.


# 사용법

Free Oberon을 실행하고 Oberon 모듈의 텍스트를 입력하거나 `Life.Mod`와 같은 샘플 프로그램을 열고 `F9`를 눌러 프로그램을 컴파일하고 실행합니다.
프로그램의 소스 코드 파일은 `Programs` 하위 디렉터리에 저장되며, 컴파일된 실행 파일은 `bin` 하위 디렉터리에 저장됩니다. 컴파일에는 Linux에서는 `Data/bin/compile.sh` 스크립트, Windows에서는 `Data\bin\compile.bat` 스크립트를 사용합니다. 이 스크립트는 편집할 수 있습니다.

여러 모듈로 구성된 프로그램을 작성할 수 있습니다. 주 모듈을 열고 `F9`를 누르십시오. Free Oberon이 자동으로 올바른 순서로 컴파일하고 링크합니다.

주 모듈 파일이 `Programs` 하위 디렉터리에 직접 있지 않은 프로그램을 컴파일하면, 컴파일된 실행 파일은 그 옆에 위치하며 `_Build` 하위 디렉터리에 있지 않습니다.

모듈 중 하나를 컴파일하는 동안 오류가 발생하면 해당 파일이 열리고 오류 위치와 메시지가 표시됩니다. 다시 컴파일하려면 주 모듈 창으로 돌아가 `F9`를 누르십시오.

[버전 기록](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---