# CardStock

## 소개

**CardStock**는 여러 페이지인 **카드**로 구성될 수 있는 그래픽 프로그램인 **스택**을 빠르고 쉽게 만들 수 있는 크로스 플랫폼 도구입니다. 그래픽 사용자 인터페이스를 구축하기 위한 드로잉 프로그램 같은 편집기와 이벤트 기반 파이썬 코드를 추가하기 위한 코드 편집기를 제공합니다.

![Pong 예제](https://github.com/benjie-git/CardStock/wiki/images/pong.png?raw=true)

과거에 HyperCard에서 프로그램을 만드는 재미와 단순함을 포착하려는 많은 오픈 소스 프로젝트가 있었지만, 제 생각에는 HyperCard가 가진 마법 같은 도구의 개방성과 사용 용이성을 제공한 프로젝트는 없었습니다. 그래서 오픈 소스의 전통에 따라 저만의 도구를 만들었습니다.

CardStock에 대한 제 비전의 기본 원칙은 중요도 순으로 다음과 같습니다:
1. 파이썬 초보자부터 가장 까다로운 시니어 소프트웨어 엔지니어까지 누구나 접근하고 이해하며 간단하고 효율적으로 사용할 수 있게 유지합니다.
2. 불필요한 복잡성을 추가하지 않고 최대한 강력하게 만듭니다.

## 특징

### 기본
* CardStock은 MacOS, Windows, GNU/Linux에서 스택을 설계할 수 있습니다. CardStock 스택은 이러한 플랫폼이나 최신 웹 브라우저, 크롬북 및 스마트폰에서도 실행할 수 있습니다.
* 텍스트와 그래픽, 이미지, 버튼, 텍스트 입력 필드, 웹 뷰 등 여러 객체를 사용하여 프로그램을 만들 수 있습니다.
* 자신의 파이썬 코드를 사용하여 객체를 조작하고 마우스 및 키보드 이벤트에 반응할 수 있습니다.
* 코드에서 사운드 파일을 재생할 수 있습니다.
* https://openclipart.org와 통합되어 스택 내에서 클립 아트를 검색하고 사용할 수 있습니다.
* 필요한 위치에 앱 내에서 바로 도움말이 표시되며, 더 이상 원하지 않을 때는 꺼서 공간을 절약할 수 있습니다.
* 완전한 실행 취소/다시 실행 기능과 코드와 객체 속성 전반에서 작동하는 찾기/바꾸기 시스템 등 기대하는 모든 편의 기능을 갖추고 있습니다.

### 고급
* 대부분의 객체 속성 변경에 애니메이션을 적용하여 창작물을 생동감 있게 만들 수 있습니다.
* 객체는 속도를 가질 수 있고 자동으로 다른 객체에 튕겨 나가도록 설정할 수 있습니다.
* 다른 파이썬 모듈을 코드에 **임포트**하여 웹 요청을 만들고 결과를 표시하거나, 로봇을 제어하거나, 기계 학습 코드를 실행하는 등 CardStock 스택 내에서 다양하게 활용할 수 있습니다.
* 구문 강조, 편집 중 구문 오류 밑줄 표시, 객체/변수/함수/메서드/속성 자동 완성 같은 기본 IDE 기능을 제공합니다.
* 스택 실행 중에 대화형 콘솔 창에서 파이썬 명령을 실행하여 변수 값을 확인하거나 설정하고, 함수를 호출하거나 원하는 파이썬 코드를 실행할 수 있습니다.
* 실행 중인 스택의 변수와 객체를 탐색하고 변수 창에서 실시간으로 수정할 수 있습니다.
* 전체 스택에서 사용된 모든 코드를 한 곳에서 보고, 특정 줄을 클릭해 해당 객체의 이벤트 코드 편집기로 바로 이동할 수 있습니다.
* 최근 오류 메시지를 보고, 클릭하면 디자이너 앱에서 문제 코드 줄로 바로 이동할 수 있습니다.
* 스택을 독립 실행형 애플리케이션으로 내보내 공유하거나 배포할 수 있으며, https://cardstock.run에 업로드할 수 있습니다.

### 향후 계획
* 사용할 수 있는 내장 사운드 라이브러리 추가 및 자신만의 사운드를 녹음하는 기능 추가.
* 사운드 루핑 기능 허용.
* CardStock용 및 CardStock을 통한 파이썬 학습 튜토리얼 추가.
* 도형을 색상 그라데이션으로 채우는 기능 추가.
* 앱 아이콘 추가.
* 튕김 물리 및 충돌 감지 성능 개선.

________
## 알려진 문제점
* 텍스트 필드와 웹 뷰는 항상 카드 뷰에 직접 그려지는 도형과 이미지 앞에 표시됩니다.
* 시각적 선택 표시기(파란 점선 윤곽선)는 네이티브 뷰 뒤에 그려져 겹치는 텍스트 필드와 웹 뷰 뒤에 숨을 수 있습니다.
* 스택은 소스에서 실행할 때만 추가 모듈을 임포트하고 해당 모듈을 포함하는 스택을 내보낼 수 있습니다. 사전 빌드된 애플리케이션에서는 불가능합니다. (사전 빌드된 앱은 requests, pyserial 등 몇 가지 라이브러리를 포함하며 요청 시 더 추가할 수 있습니다.)
* 아이러니하게도, 웹 기반 뷰어 https://cardstock.run에서는 웹 뷰가 작동하지 않습니다.
* 성능상의 이유로, 웹 뷰어에서 실행 시 마우스 이벤트는 겹치는 모든 객체에 전파되지 않고, 마우스 아래의 가장 상위 객체, 포함 그룹, 카드에만 전달됩니다.

## 요구 사항
Mac과 Windows용 사전 빌드 애플리케이션은 외부 종속성이 없습니다.

소스에서 CardStock을 실행하려면 Python 3.9 이상(3.11 이상 권장)과 wxPython 4.1 이상(wxPython 4.2.x 권장)이 필요합니다.
CardStock은 파이썬 모듈 attrdict3(리눅스 전용), wxpython, simpleaudio, PyInstaller, requests 설치를 요구합니다.
mp3 재생 지원을 위해 lame 패키지(mp3 디코더)와 파이썬 streamp3-313compat를 설치해야 합니다.

## 설치
다음 중 하나를 선택할 수 있습니다:

### 1. Mac 또는 Windows용 최신 사전 빌드 CardStock 애플리케이션 다운로드
#### (Windows 사용자는 소스 빌드가 꽤 복잡하므로 강력히 권장합니다.)
1. 여기에서 Mac 또는 Windows용 CardStock을 다운로드하세요: https://github.com/benjie-git/CardStock/releases/latest
2. 사전 빌드된 Windows 앱은 아직 코드 서명이 되어 있지 않아 처음 실행 시 Windows가 경고할 수 있습니다. "Windows에서 PC를 보호했습니다"라는 창이 뜨면 경고 문단 끝의 자세히 보기 링크를 클릭한 후 하단의 "그래도 실행" 버튼을 누르세요.

### 2. 소스에서 실행:
1. python3 설치
2. 이 저장소를 다운로드하거나 클론
3. 리눅스 전용: apt install libasound2-dev libmp3lame-dev libwebkit2gtk-4.0-dev  # Debian/Ubuntu 외 배포판에서는 유사 패키지 설치
4. Mac 전용: brew install lame
5. mp3 지원 포함 시: pip3 install streamp3-313compat

   lame 헤더 및 라이브러리 파일을 찾도록 LDFLAGS와 CPPFLAGS 설정이 필요할 수 있습니다.

   다음과 같이 실행해야 할 수 있습니다.

   `CPPFLAGS=-I/opt/homebrew/include LDFLAGS=-L/opt/homebrew/lib pip3 install streamp3-313compat` 또는 

   `CPPFLAGS=-I/usr/local/include LDFLAGS=-L/usr/local/lib pip3 install streamp3-313compat`

   lame 라이브러리 설치 위치에 따라 다릅니다.

6. pip3 install attrdict3  # wxpython 설치 전에 필수 설치
7. pip3 install -r requirements.txt  # wxpython 빌드에 시간이 걸릴 수 있음
8. python3 designer.py 실행
9. 선택 사항으로 build.py 실행하여 CardStock 디자이너 애플리케이션용 독립 실행형 앱 생성

### 3. pip/pypi로 설치:
1. 리눅스 전용: apt install libasound2-dev libmp3lame-dev libwebkit2gtk-4.0-dev  # Debian/Ubuntu 외 배포판에서는 유사 패키지 설치
2. Mac 전용: brew install lame
3. mp3 지원 포함 시: pip3 install streamp3-313compat

   lame 헤더 및 라이브러리 파일을 찾도록 LDFLAGS와 CPPFLAGS 설정이 필요할 수 있습니다.

   다음과 같이 실행해야 할 수 있습니다.

   `CPPFLAGS=-I/opt/homebrew/include LDFLAGS=-L/opt/homebrew/lib pip3 install streamp3-313compat` 또는 

    `CPPFLAGS=-I/usr/local/include LDFLAGS=-L/usr/local/lib pip3 install streamp3-313compat`

    lame 라이브러리가 설치된 위치에 따라 다릅니다.
4. pip3 install attrdict3  # wxpython 설치를 위해 먼저 이 패키지를 설치해야 합니다
5. pip3 install cardstock  # 의존성인 wxpython 빌드에 매우 오랜 시간이 걸릴 수 있습니다
6. 새로 설치된 cardstock 명령어를 사용하여 실행합니다


## 참고자료
* [CardStock 위키](https://github.com/benjie-git/CardStock/wiki)
* [Reddit의 CardStock](https://www.reddit.com/r/CardStockPython/)
* [CardStock 매뉴얼](https://github.com/benjie-git/CardStock/wiki/Manual)
* [CardStock 튜토리얼](https://github.com/benjie-git/CardStock/wiki/Tutorial-Dice)
* [CardStock 참고 가이드](https://github.com/benjie-git/CardStock/wiki/Reference)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---