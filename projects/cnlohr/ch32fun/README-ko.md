# ch32fun

[CH32V003](http://www.wch-ic.com/products/CH32V003.html) (및 CH32V 계열 내의 다른 많은 칩들)을 위한 오픈 소스 개발 환경(툴체인, 헤더, 예제)으로, gcc-riscv64를 사용하며 Windows(네이티브), Linux 및/또는 WSL에서 사용할 수 있습니다. CH32V003은 10센트짜리 RISC-V EC 코어가 탑재되어 48MHz로 동작하며, 16kB 플래시와 2kB RAM, 다양한 주변 장치를 내장하고 있습니다. SOP-8, QFN-20, SOIC 패키지로 제공됩니다. 데이터시트는 [여기](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html)에서 확인할 수 있습니다.

이 프로젝트의 목표는 CH32V003의 효율적인 사용을 위한 툴체인과 환경을 개발하는 것입니다. 복잡한 HAL을 피하고, 하드웨어의 성능을 최대한 활용하세요! 기존 EVT는 크기가 크고 개발 환경도 무겁습니다. 본 프로젝트는 HAL을 명확히 회피하며, [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html)만으로도 개발이 가능하도록 했습니다. 참고로 ch32fun의 blinky 예제는 500바이트에 불과하며, 더 빠르게 부팅되고 전체적으로 훨씬 간단합니다.

ch32fun은 다음을 포함합니다:
1. ch32fun을 사용하는 예제들. HAL에 비해서는 적지만, 대부분이 ch32v003을 중심으로 하며, 다른 프로세서와도 호환되는 경우가 많습니다.
2. "minichlink": WCH CH-Link를 libusb와 함께 사용하여 크로스 플랫폼 지원.
   * STM32F042 프로그래머, [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * ESP32S2 프로그래머, [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * 공식 WCH Link-E 프로그래머
   * Arduino 기반 인터페이스, [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio)
   * Visual Studio에서 사용 가능한 gdbserver 스타일 디버깅 지원
   * 단일 와이어로 printf 지원 (약 400kBaud)
3. `misc/libgcc.a`에 위치한 별도의 libgcc 복사본(특이한 riscv 빌드 체인 지원 목적)
4. "ch32fun" 폴더에 ch32v003용 앱 컴파일을 위한 단일 소스 파일 및 헤더 파일 포함
5. 일부 시스템에서 "printf" 역방향 지원
6. 데모 부트로더

## 기타 패밀리 지원

현재 ch32v103, ch32v203, ch32v208, ch32v303, ch32v305, ch32v307에 대한 실험적 지원이 있습니다. GDB는 주로 003에서 테스트되었으나, 다른 프로세서에서도 제한적으로 동작합니다.

## 시작하기

설치/설정 방법은 [여기 위키 페이지](https://github.com/cnlohr/ch32fun/wiki/Installation)를 참고하세요.

## 기능!

### 프로그래밍 인터페이스를 통한 빠른 "printf" 디버그

정말 빠릅니다. 보통 36kBytes/sec 정도입니다.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

debugprintf 프로젝트를 바로 실행해보거나, SetupDebugPrintf(); 호출 후 printf()를 자유롭게 사용하세요.

### 디버깅 지원!

minichlink에 내장된 gdbserver를 통해 지원합니다! `gdb-multiarch` 및 Visual Studio Code에서도 사용 가능합니다.

## 빌드 및 플래싱

```
cd examples/blink
make
```

text = 코드, data = 상수 및 초기화 값, bss = 초기화되지 않은 값  
dec는 이 셋의 합으로, 프로그램이 플래시에 차지하는 바이트 수를 반영합니다.

생성된 .bin 파일은 minichlink에서 사용되며, .hex 파일은 공식 WCH 플래시 툴과 호환됩니다.

## VSCode +/- PlatformIO

참고: PlatformIO는 이 저장소에서 주로 CI용으로 사용됩니다. PlatformIO로 VSCode 내에서 ch32fun 프로젝트를 코딩/디버깅할 수 있지만, 반드시 PlatformIO 없이도 가능합니다. 자세한 내용은 [템플릿 프로젝트](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode)를 참고하세요.

VSCode와 PlatformIO 확장으로 이 프로젝트를 빌드, 업로드, 디버깅할 수 있습니다. VSCode에서 프로젝트를 열고 PlatformIO 확장을 설치하세요. [프로젝트 환경 전환기](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks)를 이용해 "blink" 등 특정 예제를 선택하세요.

ch32fun을 기반으로 새로운 PlatformIO 펌웨어 프로젝트를 만들려면, [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html)의 "New Project" 마법사에서 "Framework"를 "ch32v003fun"으로 설정하세요. [다양한 예제](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun)도 참고 가능합니다.

![pio_proj](.github/pio_project_creation.png)

동등한 [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) 명령어는 다음과 같습니다.
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

코드를 ch32fun 프로젝트에 직접 추가하고 싶다면, `platformio.ini`의 환경을 [설명대로](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53) 확장해 주세요.

PlatformIO 내에서 이 프로젝트를 열면, VSCode 작업표시줄 하단의 [프로젝트 환경 전환기](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks)로 특정 예제 폴더를 선택할 수 있습니다. 그렇지 않으면 "Build" 명령이 기본적으로 **모든** 예제를 빌드합니다.

자세한 사항 및 플랫폼 설치는 [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v)를 참고하세요.

## clangd

C/C++ 언어 서버 clangd가 `ch32fun.h`를 찾지 못한다면, 예제를 `make clean`으로 지우고, `bear -- make build`로 한 번 빌드해야 합니다. 이렇게 하면 makefile에 지정된 include 경로를 clangd가 찾을 수 있도록 `compile_commands.json`이 생성됩니다.  
`make clangd` 명령은 이 과정을 한 번에 수행합니다.  
`build_all_clangd.sh`는 `build scripts`에서 모든 예제에 대해 이 작업을 수행합니다.

## 퀵 레퍼런스
 * **필수** 프로그래밍/디버깅용: `SWIO`는 `PD1`에 있습니다. PD1을 여러 기능에 중복 사용하지 마세요.
 * **선택** `NRST`는 `PD7`에 있습니다. 필요하지 않으며 일부 설정에서는 기본적으로 GPIO입니다.
 * **선택** UART `TX`는 `PD5`에 있습니다. printf 디버깅에는 SWIO 사용을 권장합니다.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## 더 많은 예제/프로젝트?

다른 써드파티 툴들이 다양한 예제와 라이브러리를 추가하고 있습니다. 아래 저장소를 참고하세요.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## 지원

GitHub 이슈를 열거나 Discord의 #ch32fun 채널에 참여할 수 있습니다. 현재 초대는 비공개이므로, @cnlohr에게 멘션하여 초대 링크를 요청하세요. 쪽지도 열려 있습니다.

### 각주/링크

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf 디버깅 매뉴얼
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html 프로세서 매뉴얼
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html 기술 참조 매뉴얼
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html 데이터시트
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md 이 칩의 압축 ISA 상세 내용
 * CH32V003은 xv 확장을 지원합니다. 이 칩의 opcode 분석을 위한 맞춤형 rvcodec.js를 사용할 수 있습니다: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---