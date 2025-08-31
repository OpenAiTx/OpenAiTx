# 퍼지
이것은 후지필름의 공식 카메라 앱에 대한 크로스 플랫폼 오픈 소스 대안입니다.  

[웹사이트](https://fudge.danielc.dev/) | [구글 플레이](https://play.google.com/store/apps/details?id=dev.danielc.fujiapp) | [F-Droid](https://apt.izzysoft.de/fdroid/index/apk/dev.danielc.fujiapp)

<img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" width='250'><img src="https://raw.githubusercontent.com/petabyt/fudge/master/fastlane/metadata/android/en-US/images/phoneScreenshots/4.png" width='250'>

이 앱은 아직 완성되지 않았으므로 너무 높은 기대를 하지 마십시오. 후지의 PTP/IP 구현에는 여러 가지 특이점과 버그가 많아 모든 카메라에서 작동하는 안정적인 클라이언트를 만드는 것이 쉽지 않습니다.

## 로드맵
- 프론트엔드 재작성 (https://github.com/petabyt/fudge/issues/26 참조)
- 라이브뷰 및 원격 촬영
- 블루투스 페어링 구현

## 컴파일하기
```
git clone https://github.com/petabyt/fudge.git --depth 1 --recurse-submodules
```
### Android 컴파일
Android Studio에서 android/를 엽니다.

### 데스크탑 앱 컴파일
데스크탑 유틸리티는 아직 작업 중입니다.

```
# Ubuntu/Debian deps:
sudo apt install cmake ninja-build libgtk-3-dev libusb-1.0-0-dev libvulkan-dev libglfw3-dev
```
```
cd desktop
cmake -B build -G Ninja && cmake --build build
```
MinGW/osxcross is also supported for cross compiling.

# Credits
[libjpeg-turbo](https://github.com/libjpeg-turbo/libjpeg-turbo) (IJG License, Modified (3-clause) BSD License)  
This software is based in part on the work of the Independent JPEG Group.

[ezxml](https://ezxml.sourceforge.net/) (MIT License)

[lua 5.3](https://www.lua.org/license.html) (MIT License)

[com.jsibbold:zoomage](https://github.com/jsibbold/zoomage/blob/master/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-31

---