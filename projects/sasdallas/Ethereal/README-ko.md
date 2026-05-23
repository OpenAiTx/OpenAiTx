# Ethereal

속도, 메모리 절약, 신뢰성을 위해 작성된 맞춤형 올인원 운영체제.\
이전 명칭은 reduceOS

## Ethereal이란?

Ethereal은 현대 운영체제가 갖추어야 할 모든 구성 요소를 포함한 완전한 기능의 OS를 처음부터 만드는 것을 목표로 하는 프로젝트입니다.

현재 프로젝트는 유저모드 단계를 개발 중입니다.

## 스크린샷

<img width="1925" height="1078" alt="image" src="https://github.com/user-attachments/assets/5f5725af-de16-43bf-9217-6db994f9ff2e" />\
*현대적인 1080p 데스크탑 환경*

<img width="1040" height="799" alt="image" src="https://github.com/user-attachments/assets/06835253-90cd-4785-a0f8-9f0042ac3676" />\
*DOOM이 실행 중인 Ethereal 이전 메인 데스크탑 환경*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ygmgdlm3dowe1.png?width=1620&format=png&auto=webp&s=0473ac09024c17cefb294c8570671e415866b915)\
*디버그 모드에서 부팅 중인 Ethereal*

![Ethereal but REALLY on IRC](https://github.com/user-attachments/assets/fedac2c5-db99-463f-88d9-44b1a239dcdd)\
*Libera 채팅(#ethereal)에서의 Ethereal*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ahe88a85dowe1.png?width=682&format=png&auto=webp&s=b435a1e0d57a91b7d4e0479f9649960b74a22de7)\
*DOOM을 실행 중인 Ethereal*

![fixed](https://github.com/user-attachments/assets/bfdce356-5555-436b-990d-3aad65d22dea)\
*Ethereal 전용으로 제작된 neofetch 클론(whatarewe)을 실행 중인 Ethereal*

## 기능

- 완전한 SMP 지원 커널
- 맞춤형 창 관리자 (Celestial)
- UHCI/EHCI/xHCI 컨트롤러용 USB 지원
- AHCI/IDE 지원
- E1000 및 RTL8139 네트워크 카드 드라이버가 포함된 네트워킹 스택
- 잘 테스트된 API를 갖춘 우선순위 기반 라운드로빈 스케줄러
- `mlibc` C 라이브러리 및 다양한 함수 지원
- ACPICA 라이브러리를 이용한 완전한 ACPI 지원 (AML 파싱이 없는 백업용 MinACPI 라이브러리 포함)

## 프로젝트 구조

- `base`: 기본 파일 시스템을 포함합니다. `base/initrd`의 파일들은 초기 램디스크에 들어가며 (비 LiveCD 부팅용), `base/sysroot`의 파일들은 sysroot에 들어갑니다.
- `buildscripts`: 빌드 시스템을 위한 빌드 스크립트를 포함합니다.
- `conf`: 아키텍처 파일, GRUB 설정, 추가 부트 파일 등과 같은 다양한 설정 파일들을 포함합니다.
- `drivers`: Hexahedron용 드라이버들로, 설정에 따라 복사됩니다.
- `external`: ACPICA와 같은 외부 프로젝트들을 포함합니다. 외부 구성요소를 참조하세요.
- `hexahedron`: 메인 커널 프로젝트입니다.
- `libkstructures`: 리스트/해시맵/파서/기타 커널 구조체들을 포함합니다.
- `libc`: mlibc를 포함합니다.

## 빌드


### ACPICA 안내

ACPICA를 사용할 경우(기본적으로 활성화됨), [여기](https://downloadmirror.intel.com/834974/acpica-unix-20240927.tar.gz)에서 tar 파일을 다운로드 받아 `external/acpica/acpica-src`에 압축을 풀어야 합니다.

그렇지 않으면 `conf/build/<arch>.mk` 파일을 수정하여 `USE_ACPICA` 값을 0으로 설정할 수 있습니다.  

### 빌드 방법

Ethereal을 빌드하려면 대상 아키텍처에 맞는 Ethereal 툴체인이 필요합니다.\
Ethereal 툴체인은 [저장소](https://github.com/sasdallas/Ethereal-Toolchain)에서 찾을 수 있습니다.

필요한 다른 패키지: `grub-common`, `xorriso`, `qemu-system`, `meson`, `ninja`

빌드 대상 아키텍처를 변경하려면 `buildscripts/build-arch.sh`를 편집하세요. \
`make all`을 실행하면 `build-output/ethereal.iso`에 ISO가 빌드됩니다.

현재 Ethereal은 파일시스템 드라이버가 부족하여 LiveCD 부팅이 일반적으로 가장 좋은 옵션입니다.\
LiveCD의 초기 램디스크는 sysroot이며, OS가 부팅을 감지하면 초기 램디스크를 RAM으로 복사합니다.

## 커널 인자

Ethereal이 로드되지 않는 경우가 많습니다. 이는 예상된 현상입니다. GitHub 이슈를 작성해 주세요.

일부 문제는 GRUB 구성에서 'e'를 눌러 `multiboot entry` 끝에 커널 인자를 추가함으로써 해결할 수 있습니다.\
Here is a small list:

- `--debug=`: 옵션은 `console`과 `none`입니다. `console`일 경우 커널 디버그 출력을 화면으로 리다이렉트합니다. 디버깅에 유용합니다.
- `--noload=`: 로드하지 않을 드라이버(.sys) 파일의 쉼표로 구분된 목록입니다. 문제를 일으키는 드라이버: usb_xhci.sys, ahci.sys, ps2.sys (PS/2를 지원하지 않는 경우),
- `--no-acpica`: ACPICA 라이브러리를 비활성화하고 MinACPI 구현으로 대체합니다. 극단적인 경우에만 유용합니다.
- `--no-acpi`: 모든 ACPI 구현을 비활성화합니다. SMP도 비활성화됩니다.
- `--disable-smp`: ACPI는 활성화하되 SMP를 비활성화합니다.
- `--disable-cow`: 카피 온 라이트를 비활성화합니다. 권장하지 않지만 극단적인 경우에 유용할 수 있습니다.
- `--no-psf-font`: initrd에서 PSF 폰트를 로드하지 않습니다.

## External components
특정 외부 구성요소가 `external`, `libc` 및 커널의 다른 부분에 포함되어 있습니다. 다음은 이들의 목록과 버전입니다:
- ACPICA UNIX* (인텔 라이선스): 버전 20240927 [여기에서 사용 가능](https://www.intel.com/content/www/us/en/developer/topic-technology/open/acpica/download.html)
- libmusl 수학 라이브러리 (MIT 라이선스): [여기에서 사용 가능](https://github.com/kraj/musl)
- freetype (GPL 라이선스): [여기에서 사용 가능](https://sourceforge.net/projects/freetype/)
- mlibc (MIT 라이선스): [Ethereal 포크 여기에서 사용 가능](https://github.com/sasdallas/mlibc)
- tinf (zlib 라이선스): [여기에서 사용 가능](https://github.com/jibsen/tinf/)
- json-parser (BSD 2조항 라이선스): [여기에서 사용 가능](https://github.com/json-parser/json-parser)
- PlutoSVG (MIT 라이선스): [여기에서 사용 가능](https://github.com/sammycage/plutosvg)

## Credits

Ethereal의 설계는 많이 [klange의 ToaruOS](https://github.com/klange/ToaruOS)에서 영감을 받았습니다 - 감사합니다!

Ethereal의 가상 메모리 관리자 설계 및 기타 부분은 [@mathewnd의 Astral](https://github.com/mathewnd/Astral)에서 영감을 받았습니다.

Astral의 일부 코드도 사용되었으며, 적절한 곳에 출처가 표시되어 있습니다. 라이선스 파일은 `external/`에 포함되어 있습니다.

Ethereal 로고와 Mercury 테마는 아티스트 [ArtsySquid](https://artsycomms.carrd.co)가 디자인했습니다.

## Licensing

Hexahedron과 Ethereal의 모든 비외부 구성요소는 BSD 3조항 라이선스 조건에 따릅니다 (LICENSE에 있음).\
저작권 헤더에 명시되지 않은 모든 파일은 이 라이선스에 속합니다. 저작권 헤더가 없는 파일은 BSD 3조항으로 보호받지 않습니다.

**라이선싱 문제:** 파일에 적절한 주석이 없을 경우 즉시 저에게 연락해 주세요 (투명성을 위해 GitHub 이슈와 같은 공개 채널을 통해 연락하는 것이 좋습니다).

Ethereal의 목표는 **절대** 코드를 가져가는 것이 아니었으나 과거에 그런 일이 있었습니다. 꼭 연락해 주세요!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---