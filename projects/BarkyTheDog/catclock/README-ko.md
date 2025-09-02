<p align="center">
  <img src="https://raw.githubusercontent.com/BarkyTheDog/catclock/master/catclock.gif">
</p>

catclock
========

이 프로그램은 X 윈도우 시스템의 xclock 프로그램을 "고양이 모드"로 향상시킨 버전입니다. 원래는 Tony Della Fera (MIT-Athena, DEC), Dave Mankins (MIT-Athena, BBN), Ed Moy (UC Berkeley)가 만든 X10 프로그램이었으며, 1980년대 후반에 Deanna Hohn과 제가 (Digital Equipment Corporation에서) 재미로 제작했습니다. 그래픽은 유명하고 상징적인 Kit-Cat (R) 시계에서 영감을 받았으며, 제 부엌에도 하나가 걸려 있습니다. 올해가 X10 도입 30주년을 맞아 이를 기념하고 재미있는 데스크탑 장난감으로서 github에 올렸습니다.

개선 이후로 코드 변경은 거의 없었으며, 주로 현재 더 엄격해진 컴파일러에 맞추기 위한 변경만 있었습니다. 현재는 다양한 리눅스 배포판, Cygwin, OS X (XQuartz)에서 컴파일 및 실행이 가능하며, Macport가 X 관련 파일을 /opt/local에 기본 설치하는 것에 맞게 Makefile만 수정되었습니다. Imakefile은 다소 오래되었고 아직 작동시켜 보지 않았으며, 현재는 "역사적" 이유로만 포함되어 있습니다. 원본 readme 파일은 readme_original로 이름이 변경되어 역시 역사적 이유로 포함되어 있습니다.

고양이 모드 외에도 이 버전의 xclock에는 알람 기능과 매시간 타종 기능이 포함되어 있습니다(자세한 내용은 매뉴얼 페이지 참조). 다양한 X 기본값 및 명령행 스위치를 사용하여 고양이의 색상을 제어할 수 있습니다. 자신의 기기 X 구성에 맞게 Makefile의 헤더 및 라이브러리 경로를 수정해야 할 수도 있습니다. 유일한 "비표준" 의존성은 Motif이며, 선호하는 패키지 관리자에서 쉽게 구할 수 있습니다.

## 템포 추적

이 버전은 음악 템포를 추적하여 고양이의 눈과 꼬리를 음악과 동기화하여 움직이게 할 수 있습니다.  
템포 추적 기능을 활성화하여 빌드하려면 템포 추적을 지원하는 추가 라이브러리가 필요합니다:

```bash
sudo apt install libaubio5 libaubio-dev
```
`WITH_TEMPO_TRACKER=1` 옵션을 사용하여 템포 트래커가 활성화된 상태로 컴파일하세요:


```bash
make WITH_TEMPO_TRACKER=1
```

"cat" 모드에서 클럭을 실행한 후 PulseAudio 믹서(예: `pavucontrol`)를 실행하고 "녹음" 탭에서 분석할 원하는 오디오 소스를 선택하세요.

## 사용법

```
xclock [toolkitoptions]
       [-mode <analog, digital, cat>]
       [-alarm]  [-bell]  [-chime]
       [-file <alarm file>]  [-period <seconds>]
       [-hl <color>]  [-hd <color>]
       [-catcolor <color>]
       [-detailcolor <color>]
       [-tiecolor <color>]
       [-padding <pixels>]
       [-update <seconds>]
       [-ntails <number>]
       [-help]
```
즐기세요!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---