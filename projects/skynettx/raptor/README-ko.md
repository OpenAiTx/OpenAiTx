
# 랩터  
nukeykt가 역공학한 Raptor Call Of The Shadows 코드베이스를 기반으로 함  

## 미디어  
썸네일을 클릭하면 프로젝트가 작동하는 동영상을 볼 수 있습니다  

[![이미지 대체 텍스트](https://img.youtube.com/vi/Nt2HfchiudY/0.jpg)](https://www.youtube.com/channel/UCedmTTlonJK5DvkiMpA_teQ)  
## 정보  
원작자 Scott Host가 클래식 게임의 현대화 버전인 Raptor Remixed를 개발 중입니다. 랩터 팬이라면 Kickstarter에서 프로젝트를 지원해 주시면 좋겠습니다. 자세한 정보는 [www.mking.com](https://www.mking.com)에서 확인하세요.  

## 빠른 시작  
윈도우와 macOS용 릴리스 빌드가 제공됩니다.  
모든 릴리스 빌드는 쉐어웨어 버전 1.2의 자산(GLB 파일)만 포함합니다.  
전체 버전을 플레이하려면 전체 버전 1.2의 자산(GLB 파일)을 직접 구해서 설치 디렉터리에 복사해야 합니다.  
플랫폼에 맞는 최신 릴리스 빌드를 다운로드하려면 [다운로드](https://github.com/skynettx/raptor/releases/latest)를 클릭하세요.  
다운로드한 릴리스 빌드를 설치 관리자의 지시에 따라 설치하세요.  
이제 랩터를 플레이할 준비가 완료되었습니다.  
직접 빌드하거나 더 많은 구성 정보를 원하는 경우 아래 내용을 계속 읽으세요. 그렇지 않으면 여기서 끝입니다.  

## 설치  
Raptor Call Of The Shadows v1.2 쉐어웨어 또는 전체 버전의 원본 자산(GLB 파일)이 필요합니다.  
중요: DOS 버전 v1.2만 호환됩니다! 이 파일들은 직접 준비해야 합니다.  
자산은 현재 작업 디렉터리(랩터 디렉터리) 또는 외부 시스템별 디렉터리에서 로드할 수 있습니다.  
**릴리스 빌드 버전 0.8.0은 외부 시스템별 디렉터리를 지원하지 않으며 모든 자산, 구성 및 저장 파일을 현재 작업 디렉터리에서 관리합니다.**  
외부 시스템별 디렉터리는 다음과 같습니다:**
```
 Windows: Users\Username\AppData\Roaming\Raptor\  
 Linux: ~/.local/share/Raptor/
 macOS: ~/Library/Application Support/Raptor/
```

설정 파일 `SETUP.INI`와 저장 파일들도 이 폴더들에서 로드되고 저장됩니다.  
공식적으로 지원되지 않는 다른 시스템에서는, 설정 파일과 저장 파일을 로드하고 저장하기 위해 Raptor 디렉토리가 사용됩니다.  
빌드 디렉토리에서 `raptor.exe`(Windows) 또는 `raptor`(Linux 또는 macOS)를 Raptor 디렉토리로 복사하세요.  
TinySoundFont를 통한 MIDI 지원을 위해 `include\TimGM6mb\`에서 사운드폰트 `TimGM6mb.sf2`를 Raptor 디렉토리로 복사하세요.  
Windows에서는 32비트 설치의 경우 `include\SDL2-devel-2.28.2-VC\SDL2-2.28.2\lib\x86\`에서,  
64비트 설치의 경우 `include\SDL2-devel-2.28.2-VC\SDL2-2.28.2\lib\x64\`에서 `SDL.dll` 파일을 Raptor 디렉토리로 복사하세요.  
Linux에서는 해당 배포판의 패키지 관리자를 통해 lib-sdl2를 설치하세요. macOS를 사용하는 경우 dmg 파일이나 brew 등의 패키지 관리자를 통해 lib-sdl2를 설치하세요.  
### 쉐어웨어  
다음 파일들을 Raptor 또는 외부 시스템 특정 디렉토리에 복사하세요:  

```
FILE0000.GLB  
FILE0001.GLB  
```
### 전체 버전
다음 파일들을 Raptor 또는 외부 시스템 특정 디렉토리에 복사하십시오: 
```
FILE0000.GLB  
FILE0001.GLB  
FILE0002.GLB  
FILE0003.GLB  
FILE0004.GLB  
```
### Configuration  
You can build or download [Raptor Setup](https://github.com/skynettx/raptorsetup.git) to create and edit the  
`SETUP.INI`, or edit it manually as follows.  
Copy the `SETUP(ADLIB).INI` or the `SETUP(MIDI).INI` file from build directory to external system specific directory (Windows, Linux and macOS) or Raptor directory (only systems that are not officially supported) and rename it to `SETUP.INI`.  
If you want MIDI over the TinySoundFont lib rename the `TimGM6mb.sf2` to `SoundFont.sf2` or specify the filename in the `SETUP.INI` file:  
`SoundFont=SoundFont.sf2`  
You can use any other GM compatible soundfont in sf2 format. For a better MIDI sound quality I recommend the FluidR3_GM.sf2.  
This font is 140 MB in size, so it is not in the repository.  
To play with one of the following input devices set `Control=0` under the [Setup] section in the `SETUP.INI` file to:  
`Control=0` Keyboard  
`Control=1` Mouse  
`Control=2` Joystick (Game Controller)  
Haptic (Game Controller rumble support) can be switched off or on under the [Setup] section in the `SETUP.INI` file:  
`Haptic=0`  
`Haptic=1`  
If you want to turn off the menu pointer control via the joystick in mode `Control=2` and enable the new joystick menu control in all  
input modes, set under the [Setup] section in the `SETUP.INI` file:  
`joy_ipt_MenuNew=0`  
`joy_ipt_MenuNew=1`  
System MIDI support (Windows Multimedia, Linux ALSA, macOS CoreAudio and macOS CoreMIDI) can be switched off or on in the [Setup] section in the `SETUP.INI` file:  
`sys_midi=0`  
`sys_midi=1`  
For Windows Multimedia under Windows, the MIDI device is set under the [Setup] section in `SETUP.INI` file:  
`winmm_mpu_device=0`  
Client and port for ALSA MIDI under Linux, is set under the [Setup] section in the `SETUP.INI` file:  
`alsa_output_client=128`  
`alsa_output_port=0`  
To use a software synthesizer with ALSA MIDI, install for example timidity and soundfont-fluid from the packagemanager of your distro.  
CoreAudio support on macOS with software synthesizer DLS synth can be switched off or on under the [Setup] section in the `SETUP.INI` file:  
`core_dls_synth=0`  
`core_dls_synth=1`  
If you want to use CoreMIDI under macOS, `core_dls_synth=0` must be switched off in the `SETUP.INI` file.  
You can set the CoreMIDI port under the [Setup] section in the `SETUP.INI` file as follows:  
`core_midi_port=0`  
To display the text mode ending screen after the game quits in fullscreen mode set under the [Video] section in the `SETUP.INI` file:  
`txt_fullscreen=0`  
`txt_fullscreen=1`  

## Build  
The project supports the compilers msvc, gcc and clang.  
When you have installed git on your system you can clone the repository by type in `git clone https://github.com/skynettx/raptor.git`.  

### Windows  
You can use the projectfile for Visual Studio 2022 under `msvc\` or the projectfile for CodeBlocks under `gcc\`.  

### Linux  
Please remember to install the required dependencies lib-sdl2. In some distros there is an extra libsdl2-dev package like Debian or Ubuntu.  
You can use the projectfile for CodeBlocks under `gcc\`.  
Otherwise you can use cmake. To use cmake type in the root of the repository:  
```
mkdir build  
cd build  
cmake ..  
make  
```
### macOS  
필요한 라이브러리 lib-sdl2를 설치합니다. 빌드하려면 cmake를 사용하며, 저장소 루트에서 다음을 입력하세요:

```
mkdir build  
cd build  
cmake ..  
make  
```
## FAQ
1. 리눅스에서 소리가 나지 않을 때:  
배포판의 패키지 관리자를 통해 필요한 모든 ALSA 및 PulseAudio 의존성을 설치했는지 확인하세요. 
2. 비디오 설정은 어디서 변경하나요:  
비디오 설정은 `SETUP.INI` 구성 파일에서 설정할 수 있습니다. 전체 화면 모드를 전환하려면 [Video] 섹션에서 `fullscreen=0`을  
`fullscreen=1`로 수정하세요. 또는 화면 비율 모드를 끄려면 `aspect_ratio_correct=1`을  
`aspect_ratio_correct=0`으로 변경하세요. 

## 감사의 말씀
재구성된 소스 코드 작업에 큰 기여를 해주신 [nukeykt](https://github.com/nukeykt)와 [wel97459](https://github.com/wel97459)께 특별히 감사드립니다.
훌륭한 지원을 해주신 [Scott Host](https://www.mking.com)께도 큰 감사를 드립니다.
또한 훌륭한 TinySoundFont 라이브러리를 제공해주신 [schellingb](https://github.com/schellingb)와  
멋진 libtextscreen을 개발한 [chocolate-doom project](https://github.com/chocolate-doom)의 모든 기여자분들께도 감사드립니다.  
더불어 TimGM6mb 사운드폰트를 제공해주신 Tim Brechbill께도 감사드립니다.









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---