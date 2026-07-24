# XGDTool
<img src="https://github.com/wiredopposite/XGDTool/blob/master/resources/Screenshot.png" alt="App" width="700"/>

XGDTool은 OG Xbox 및 Xbox 360 디스크 유틸리티로, 디스크를 모든 주류 포맷으로 변환할 수 있습니다. GUI 또는 CLI 앱으로 제공됩니다.

이 프로그램은 아직 초기 테스트 단계에 있습니다. 문제가 발생하면 Issues 탭에 보고하여 프로그램 개선에 도움을 주세요!

## 기능
- 다음 포맷 간 변환 지원:
    - ISO / XISO
    - 추출된 파일(Xex / Xbe / HDD Ready)
    - GoD / Games on Demand
    - CCI
    - CSO
    - ZAR
- 무결점 변환, 예를 들어 GoD 이미지를 직접 추출하거나 ISO를 ZAR 아카이브로, 또는 추출된 디렉토리를 CCI 아카이브로 변환할 때 임시 파일을 작성하지 않습니다. 입력으로 제공된 ZAR만 임시 파일이 필요합니다.
- 이미지 스크러빙("부분 스크럽"), 무작위 패딩을 제거하고 출력 파일을 가능한 가장 짧은 길이로 다듬습니다.
- 이미지 재작성("전체 스크럽"), 디스크 구조를 완전히 다시 작성하여 가능한 가장 작은 출력 파일을 만듭니다.
- 이미지 작성, 추출한 파일을 사용하여 새 이미지를 생성합니다.
- CCI 및 CSO 포맷에 대한 다중 스레드 압축 지원.
- 배치 처리, 다양한 게임 포맷이 포함된 폴더를 단일 포맷으로 일괄 변환할 수 있습니다.
- 입력 경로에 하나의 분할 파일만 제공된 경우, ```name.1.extension``` ```name.2.extension``` 형식으로 이름이 지정된 분할 파일을 자동으로 찾습니다.
- 대상 앱/기기(Xemu, Xenia, OG Xbox, Xbox 360)를 선택하고 XGDTool이 설정을 결정하도록 할 수 있습니다.
- OG Xbox용 XBE 생성 첨부.
- 정확한 파일 이름을 위한 온라인 데이터베이스 조회(비활성화 가능).

## CLI 사용법
```XGDTool.exe <output_format> <settings_flags> <input_path> <output_directory>```

or on Linux

```XGDTool <output_format> <settings_flags> <input_path> <output_directory>```
설정 플래그와 출력 디렉토리는 선택 사항입니다.

### 출력 형식 인수 (상호 배타적)
- ```--extract```   모든 파일을 디렉토리로 추출합니다.
- ```--xiso```      Xiso 이미지를 생성합니다.
- ```--god```       Games on Demand 이미지/디렉토리 구조를 생성합니다.
- ```--cci```       CCI 아카이브를 생성합니다 (Xbox 용으로 너무 크면 자동 분할).
- ```--cso```       CSO 아카이브를 생성합니다 (Xbox 용으로 너무 크면 자동 분할).
- ```--zar```       ZAR 아카이브를 생성합니다.
- ```--xbe```       첨부 XBE 파일을 생성하며 입력 파일을 변환하지 않습니다.
- ```--ogxbox```    OG Xbox에서 사용하기 위한 형식 및 설정을 자동 선택합니다.
- ```--xbox360```   Xbox 360에서 사용하기 위한 형식 및 설정을 자동 선택합니다.
- ```--xemu```      Xemu에서 사용하기 위한 형식 및 설정을 자동 선택합니다.
- ```--xenia```     Xenia에서 사용하기 위한 형식 및 설정을 자동 선택합니다.

정보:
- ```--list```      입력 파일의 내용을 나열합니다.
- ```--version```   버전 정보를 출력합니다.
- ```--help```      사용법 정보를 출력합니다.

### 설정 플래그
이 인수들은 중첩해서 사용할 수 있지만, 모든 출력 형식에서 사용하지는 않으며 그 경우 옵션은 무시됩니다. 충돌하는 설정(예: 전체/부분 스크럽)이 제공되면 마지막 설정이 사용됩니다.
- ```--partial-scrub```  출력 이미지의 스크럽과 트리밍을 수행하며, 임의 패딩 데이터를 제거합니다.
- ```--full-scrub```     결과 이미지를 완전히 재구성하여 가능한 가장 작은 파일을 생성합니다.
- ```--split```          OG Xbox에 너무 큰 경우 결과 XISO 파일을 분할합니다.
- ```--rename```         결과 XBE 파일의 타이틀 필드를 데이터베이스에 있는 값으로 패치합니다.
- ```--attach-xbe```     출력 파일과 함께 첨부 XBE 파일을 생성합니다.
- ```--am-patch```       결과 XBE 파일의 "허용 미디어" 필드를 패치합니다.
- ```--offline```        온라인 기능을 비활성화합니다.
- ```--debug```          디버그 로깅을 활성화합니다.
- ```--quiet```          경고 및 오류를 제외한 모든 로깅을 비활성화합니다.

## 빌드
기본적으로 GUI로 컴파일하며, CLI용으로 컴파일하려면 Cmake를 ```-DENABLE_GUI=OFF``` 옵션으로 구성합니다. x86용으로 컴파일하려면 CmakeLists.txt 및 cmake/setup_vcpkg.cmake 파일을 여러 차례 수정해야 합니다.

### 윈도우
Cmake와 MSVC가 설치되어 있다면 과정은 비교적 간단합니다. 프로젝트는 Windows용으로 설정되어 있어, Cmake 구성 시 프로젝트 디렉토리 내에서 vcpkg를 사용해 모든 의존성을 자동으로 다운로드하고 빌드합니다. 인터넷 속도와 PC 사양에 따라 시간이 걸릴 수 있으나 한 번만 하면 됩니다.

이 저장소를 클론하고 빌드 디렉토리를 만드십시오.


```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
GUI로 구성:  

```
cmake -S .. -B . -G "Visual Studio 17 2022" -A x64
``` 
또는 CLI로: 
```
cmake -S .. -B . -DENABLE_GUI=OFF -G "Visual Studio 17 2022" -A x64
```
빌드

```
cmake --build . --config Release
```
### Linux
이 앱은 아직 Linux에서 광범위하게 테스트되지 않았으며, Linux는 wxWidgets와 관련된 몇 가지 특이점이 있어 GUI가 정확히 의도한 대로 보이지 않을 수 있습니다. Clang으로 테스트되었으며, Clang 외에도 Make 및 Cmake와 함께 몇 가지 다른 의존성을 설치해야 합니다:

```
sudo apt update
sudo apt-get install pkg-config liblz4-dev libzstd-dev libssl-dev libcurl4-openssl-dev libwxgtk3.0-gtk3-dev
```
이 저장소를 클론하고 빌드 디렉토리를 만드세요
```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
GUI로 구성: 
```
cmake ..
``` 
또는 CLI로: 
```
cmake -DENABLE_GUI=OFF ..
```

빌드
```
make
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---