# Marsdev

크로스 플랫폼 세가 메가 드라이브 / 슈퍼 32X / 샤프 X68000 툴체인.

English | [日本語](https://raw.githubusercontent.com/andwn/marsdev/master/README-ja.md)


## 컴파일 및 설치

### 1.1 의존성

운영 체제에 따라 다음 패키지를 설치하세요:
  * Debian: `apt install build-essential texinfo wget`
  * RedHat: `yum install gcc gcc-c++ texinfo-tex wget`
  * Arch: `pacman -S base-devel texinfo wget`
  * Gentoo: `emerge sys-apps/texinfo net-misc/wget`
  * macOS: `xcode-select --install && brew install wget`


### 2. GCC 툴체인

레포지토리를 클론하세요:
 - `git clone https://github.com/andwn/marsdev --recurse-submodules`
 - `cd marsdev`

---
**참고**

Marsdev가 빌드되고 설치될 디렉터리를 제어하는 두 개의 변수가 있습니다:
 - `MARS_BUILD_DIR` = (REPOSITORY_ROOT)/mars
 - `MARS_INSTALL_DIR` = /opt/toolchains/mars

둘 중 하나의 위치를 변경하려면 다음과 같은 export 명령을 사용하세요:
 - `export MARS_INSTALL_DIR=/path/to/mars`

`--recurse-submodules`를 잊었다면 다음을 실행하세요:
 - `git submodule init && git submodule update`

또한, CPU 코어 수에 맞춰 `-j8` 같은 옵션을 사용하는 것이 **강력히 권장**됩니다.
저는 `-j` 옵션 사용 시 설명할 수 없는 이상한 문제가 발생한 적이 있습니다.
그 자체로는 숫자를 지정해야 합니다.

---

GCC를 빌드하는 방법은 2가지가 있습니다:
 - `make m68k-toolchain` - Newlib 없이
 - `make m68k-toolchain-newlib` - Newlib 포함

32X의 경우, `sh` 툴체인도 빌드해야 합니다.
옵션은 위 명령어에서 `m68k`를 `sh`로 바꾸면 동일합니다.

다른 GCC 버전을 원하거나 특정 언어만 빌드하려면:
 - `make m68k-toolchain-newlib GCC_VER=12.4.0 LANGS=c,c++`


### 3. (선택 사항) SGDK

SGDK는 자바가 필요하므로 설치하세요.
  * Debian: `apt install openjdk-11-jre`
  * RedHat: `yum install java-11-openjdk`
  * Arch: `pacman -S jdk11-openjdk`
  * Gentoo: `emerge dev-java/openjdk`
  * macOS: `brew install java`

---
**macOS 주의 사항**

OpenJDK를 PATH에 추가해야 합니다.
 - `~/.zshrc` (또는 아직 bash를 사용한다면 `~/.bashrc`)를 열고 다음 줄을 추가하세요:
    - `export PATH="/usr/local/opt/openjdk/bin:$PATH"`
 - 터미널을 재시작하거나 `source ~/.zshrc` 명령을 실행하세요

---

SGDK 빌드:
 - `make sgdk`

특정 SGDK 버전은 `SGDK_VER=<git tag>`로 지정할 수 있지만,
기본 버전 외에는 정상 동작을 보장하지 않습니다.
최신 변경 사항을 시험해보고 싶은 모험심 강한 분은 `SGDK_VER=master`도 지정할 수 있습니다.
### 4.1 (선택 사항) 기타 도구

다음 대상도 사용할 수 있습니다:
 - `make x68k-tools` - Sharp X68000 호환성
 - `make mdtools-sik` - mdtiler와 일부 Echo 관련 도구 포함 (libpng 필요)
 - `make mdtools-flamewing` - Sonic 게임 데이터 압축 도구 (boost 필요)

 ### 4.2 (실험적) LLVM

cmake, ninja 및 python3가 필요합니다:
 - Debian: `apt install cmake ninja-build python3`
 - (TODO: 다른 배포판 추가 예정)

M68k용 clang과 함께 LLVM을 빌드할 수 있습니다:
 - `make m68k-llvm`
 
테스트는 아직 진행되지 않았으며, 예제/스켈레톤 프로젝트도 아직 만들어져야 합니다.


### 5. 설치

그냥 `sudo make install`을 실행하세요. 환경 설정 스크립트의 경로를 기억하고,
~/.bashrc(또는 ~/.zshrc)에 추가하는 것을 고려하세요.


## 예제

`examples` 디렉토리에는 다른 프로젝트의 기반이 될 수 있는 다양한 스켈레톤/예제 프로젝트가 포함되어 있습니다.
각 항목에 대한 자세한 내용은 [examples/README.md](https://raw.githubusercontent.com/andwn/marsdev/master/examples/README.md)를 참조하세요.

어떤 것이든 `make` 명령어만으로 쉽게 빌드할 수 있어야 합니다.


## 자주 묻는 질문

### 그냥 SGDK를 리눅스에서 사용하고 싶어요

설치하세요:


 - `sudo apt install -y git build-essential texinfo wget openjdk-11-jre`
 - `git clone https://github.com/andwn/marsdev && cd marsdev`
 - `make sgdk -j8`
 - `sudo make install`

빌드:

 - `examples/sgdk-skeleton` 내부의 makefile을 가져와 프로젝트에 넣으세요.
 - `source /opt/toolchains/mars/mars.sh`
 - `make`

### Marsdev로 Gendev 프로젝트를 빌드하거나 그 반대도 가능한가요?

쉽지 않습니다. 작동하게 하려면 Makefile을 수정해야 합니다.
현재 Makefile을 예제 프로젝트 중 하나와 비교하는 것부터 시작하세요.
[Migration](https://raw.githubusercontent.com/andwn/marsdev/master/doc/migration.md) 문서가 도움이 될 수 있습니다.

### SGDK 문제의 원인이 Marsdev인지 어떻게 알 수 있나요?

공식 SGDK 릴리스로 프로젝트를 그대로 컴파일할 수 있어야 합니다.
포함된 Makefile은 단지 `make -f $GDK/makefile.gen`의 래퍼입니다.

문제가 계속되면 SGDK의 문제이고, 문제가 해결되면 Marsdev의 문제입니다.

### 내가 좋아하는 IDE에서 이걸 어떻게 사용하나요?

IDE가 너무 많고, 각각 경로 설정을 해야 하는 위치가 다릅니다.
일반적으로 해야 하는 유일한 일은 헤더 위치를 지정하는 것입니다.

 * GCC 헤더: `$(MARSDEV)/m68k-elf/lib/gcc/m68k-elf/$(GCC_VER)/include`
 * SGDK 헤더: `$(MARSDEV)/m68k-elf/include`
 * Newlib 헤더: `$(MARSDEV)/m68k-elf/m68k-elf/include`
 
IDE가 빌드/실행 버튼에 수행할 작업을 설정할 수 있다면, 다음과 같이 실행하게 하세요.

 * 빌드: `make MARSDEV=/path/to/mars`
 * 실행: `/path/to/an/emulator out.bin`


### 윈도우는 어떻게 하나요?
[WSL](https://learn.microsoft.com/en-us/windows/wsl/install)을 사용하는 것을 강력히 권장하며  
Debian에 대한 지침을 따르세요.  
다른 사람이 기여한 Dockerfile을 사용해 볼 수도 있지만  
저는 직접 테스트하지 않았습니다.  
예전에는 [MSYS2](https://raw.githubusercontent.com/andwn/marsdev/master/doc/install_msys_legacy.md)를 사용했는데,  
그것이 얼마나 느리고 무거운지 과장할 수 없습니다.  
  
추가로, 만약 SGDK만 사용하고 Linux나 macOS를 사용하지 않는다면  
Marsdev는 당신에게 별로 도움이 되지 않을 것 같습니다.  
  
### 저는 /opt에 설치하는 것을 좋아하지 않습니다. 예전의 ~/mars 방식이 좋습니다  
  
간단합니다.  
1. `export MARS_BUILD_DIR=${HOME}/mars`  
2. 1단계부터 4단계까지 정상적으로 진행하세요  
3. 설치 단계는 건너뛰고 대신 `~/.bashrc`에 다음을 추가하세요:

```
export MARSDEV=${HOME}/mars
export GDK=${MARSDEV}/m68k-elf
```
### 이 컴파일하는 데 너무 오래 걸려요!

GCC는 큰 녀석이니까, 그냥 인내심을 가져야 해요.


# 해야 할 일

 - [ ] libdos의 중요한 부분을 포팅 완료하고 Newlib이 그것과 작동하도록 만들기



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---