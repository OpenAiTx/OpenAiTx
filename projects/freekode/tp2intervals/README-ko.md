[![Build branches](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml/badge.svg)](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml)
[![release](https://img.shields.io/github/release/freekode/tp2intervals)](https://github.com/freekode/tp2intervals/releases/latest)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/E1E6W6XZP)

# Third Party to Intervals.icu

TrainingPeaks, TrainerRoad와 Intervals.icu 간 운동 동기화를 위한 앱입니다.

MacOS(DMG), Windows(EXE 설치 프로그램), Linux(AppImage)에서 실행됩니다. 또는 Docker 이미지와 실행 가능한 JAR 파일도 있습니다.

모든 파일은 [릴리스 페이지](https://github.com/freekode/tp2intervals/releases/latest)에서 다운로드할 수 있습니다.

**교육 목적으로만 사용하세요**

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp.png?raw=true" width="25%"><img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr.png?raw=true" width="25%">

* [기능 목록](#list-of-features)
* [설정](#configuration)
    + [Intervals.icu](#intervalsicu)
    + [TrainingPeaks](#trainingpeaks)
    + [TrainerRoad](#trainerroad)
* [앱 실행의 다른 방법](#other-ways-to-run-the-app)
    + [실행 가능한 JAR](#executable-jar)
    + [Docker](#docker)
* [자주 묻는 질문(FAQ)](#faq)
    + [일반](#general)
    + [TrainingPeaks 무료 계정으로 다음 날 일정 관련 정보](#info-regarding-scheduling-for-the-next-day-with-trainingpeaks-free-account)
* [문제 해결](#troubleshooting)
    + [로그 얻는 방법](#how-to-get-logs)
    + [HAR 파일 기록 방법](#how-to-record-har-file)



**새 Docker 이미지 위치 ⚠️**

**새 이미지 URL: `ghcr.io/freekode/tp2intervals`**

기존 이미지 URL: `ghcr.io/freekode/tp2intervals/tp2intervals`

**TrainerRoad 업데이트**

저는 더 이상 TrainerRoad에 접근할 수 없습니다. 제가 사용하던 계정은 구독이 취소되었습니다. 저는 이 플랫폼을 사용하지 않으며 가끔 문제를 해결하기 위해 유지하기에는 너무 비쌉니다.  
문제를 해결하려면 오직 여러분이 제공하는 로그와 HAR 파일에만 의존할 수 있습니다.

## 기능 목록

**TrainingPeaks**

운동선수 계정  
* Intervals.icu와 TrainingPeaks 간에 달력에 계획된 운동 동기화 (무료 TP 계정으로 오늘과 내일까지)  
* TrainingPeaks에서 전체 훈련 계획 복사  
* TrainingPeaks에서 계획된 운동으로 Intervals.icu에 훈련 계획 또는 운동 폴더 생성

코치 계정  
* TrainingPeaks에서 전체 훈련 계획과 운동 라이브러리 복사

**TrainerRoad**  
* TrainerRoad에서 TrainingPeaks 또는 Intervals.icu로 달력에 계획된 운동 동기화  
* TrainerRoad 라이브러리에서 Intervals로 운동 복사  
* TrainerRoad에서 계획된 운동으로 Intervals.icu에 훈련 계획 또는 운동 폴더 생성

매 20분마다 달력을 확인하여 오늘의 운동을 자동으로 예약합니다.  
예약된 작업을 삭제하려면 애플리케이션을 재시작하세요.

## 설정  
애플리케이션 사용 전에 플랫폼 접근 권한을 설정해야 합니다.  
Intervals.icu 접근은 필수이며, 다른 플랫폼 접근은 선택 사항입니다.

필요한 모든 설정을 완료한 후 확인 버튼을 클릭할 수 있습니다.  
모든 것이 정상이라면 홈 페이지로 리디렉션됩니다.

설정이 잘못된 경우 특정 플랫폼에 대한 접근 권한이 없다는 오류가 표시됩니다.  
모든 값을 확인하고 설정을 다시 저장하세요.

### Intervals.icu  
Intervals.icu 웹페이지의 [설정 페이지](https://intervals.icu/settings) 내 개발자 설정 섹션에서 API 키와 운동선수 ID를 복사하세요.

### TrainingPeaks

TrainingPeaks를 사용하려면 요청 `https://tpapi.trainingpeaks.com/users/v3/token`에서 모든 쿠키를 복사하여 구성 페이지에 붙여넣으세요.  
앱은 자동으로 불필요한 부분을 제거하고 필요한 쿠키만 남깁니다. 아래 가이드를 따라 진행하세요.

앱에는 `Production_tpAuth` 쿠키(키와 값, 예: `Production_tpAuth=very_long_string`)가 필요합니다.  
또 다른 가이드는 [여기](https://forum.intervals.icu/t/implemented-push-workout-to-wahoo/783/87)에서 확인할 수 있습니다.

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp_guide.png?raw=true">

### TrainerRoad  
구성 방법은 TrainingPeaks와 매우 유사합니다. 요청 `https://tpapi.trainingpeaks.com/users/v3/token`에서 모든 쿠키를 복사하여 구성 페이지에 붙여넣으세요.  
앱은 자동으로 불필요한 부분을 제거하고 필요한 쿠키만 남깁니다. 아래 가이드를 따라 진행하세요.

앱에는 `SharedTrainerRoadAuth` 쿠키(키와 값, 예: `SharedTrainerRoadAuth=very_long_string`)가 필요합니다.

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr_guide.png?raw=true">

주의: Firefox는 개발자 도구 창에서 긴 문자열을 자릅니다. 쿠키 값을 우클릭 -> 값 복사로 복사하세요.

## 앱 실행의 다른 방법  
### 실행 가능한 JAR  
이 프로젝트는 웹 UI가 포함된 실행 가능한 JAR 파일을 제공합니다. JDK 21이 필요합니다. JAR 파일 실행 방법:
```shell
java -jar tp2intervals.jar
```
기본적으로 UI는 `http://localhost:8080`에서 사용 가능합니다. 포트를 변경하려면 다음 매개변수와 함께 jar를 시작하세요:

```shell
java -Dserver.port=9090 -jar tp2intervals.jar
```

### 도커
도커 이미지는 모든 릴리스마다 빌드됩니다

```yaml
services:
  app:
    image: ghcr.io/freekode/tp2intervals:latest
    container_name: tp2intervals
    volumes:
      - ./tp2intervals.sqlite:/tp2intervals.sqlite
    ports:
      - '8080:8080'
```

## FAQ

### 일반
* TrainerRoad에서 램프 단계는 지원되지 않습니다
* **MacOS arm64** 오류: `"tp2intervals" 손상되어 열 수 없습니다.`
  터미널에서 `xattr -d com.apple.quarantine /Applications/tp2intervals.app` 명령어를 실행한 후 앱을 다시 열어보세요
* **MacOS** 앱이 서명되지 않았습니다. 보통 두 번 열어야 합니다
* **Windows** 앱에서 로컬 네트워크 및 인터넷 접근 권한을 요청할 수 있으며, 허용해야 합니다. 결국 HTTP 요청을 수행합니다
* 더 많은 정보는 포럼 https://forum.intervals.icu/t/tp2intervals-copy-trainingpeaks-and-trainerroad-workouts-plans-to-intervals/63375 에서 확인할 수 있습니다

### TrainingPeaks 무료 계정으로 다음 날 스케줄링 관련 정보
공식적으로 무료 TP 계정은 미래 날짜의 운동 계획을 세울 수 없지만, 실제로는 가능합니다.
TrainingPeaks 서버 현지 시간을 기준으로 다음 날 운동을 계획할 수 있습니다. 서버는 UTC-6 시간대에 있습니다. 몇 가지 예시를 살펴보겠습니다:

예시 1. 사용자의 시간대가 UTC+2이고 현재 로컬 날짜 및 시간이 2024년 5월 20일 06:00입니다. 이 순간 TP 서버 현지 시간은 2024년 5월 19일 22:00입니다.
따라서 2024년 5월 20일 운동 계획은 가능하지만, 2024년 5월 21일 운동 계획은 불가능하며 2시간 후에 가능해집니다. 2시간 후 서버 현지 시간은 2024년 5월 20일 00:00이 되기 때문입니다.

예시 2. 사용자의 시간대가 UTC+12이고 현재 로컬 날짜 및 시간이 2024년 5월 20일 18:00입니다. TP 서버 현지 시간은 2024년 5월 20일 00:00입니다. 이 순간 2024년 5월 21일 운동 계획이 가능합니다.

[worldtimebuddy](https://www.worldtimebuddy.com/?pl=1&lid=206,100,756135,2193733&h=206&hf=0)에서 시간 차이를 확인할 수 있습니다.

## 문제 해결
어떤 플랫폼에서 문제를 식별하려면 사용자 로그가 매우 도움이 됩니다.

[아래 가이드](#how-to-get-logs)에서 로그를 수집하세요. TrainerRoad 플랫폼의 경우 [HAR 파일 기록](#how-to-record-har-file)을 시도해보세요. 파일들을 저에게 직접 보내주세요.

#### 로그 수집 방법
1. 설정으로 이동
2. 일반 섹션에서 디버그 모드 체크 후 확인 클릭
3. 문제 재현
4. 시스템에 맞는 로그 파일 찾기

* 리눅스: ~/.config/tp2intervals/logs/main.log
* MacOS: ~/Library/Logs/tp2intervals/main.log
* 윈도우: %USERPROFILE%\AppData\Roaming\tp2intervals\logs\main.log
* JAR: ./tp2intervals.log

#### HAR 파일 기록 방법
1. 브라우저에서 새 탭 열기
2. 개발자 도구를 열고, 로그 보존(Preserve log)을 확인하세요 (Firefox 설정 아이콘 -> 로그 지속(Persist Logs))

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-1.png?raw=true" width="70%">
3. 다음 단계는 매우 중요하며, 앱이 수행하는 작업을 시뮬레이션합니다.
   TrainerRoad 페이지를 열고, 운동 라이브러리를 열고, 아무 운동을 찾아 운동 페이지를 엽니다 (운동 단계, 설명, 대체 항목 등이 포함된 차트가 있는 페이지).
4. 개발자 도구에서 HAR 내보내기(Export HAR)를 클릭하세요 (Firefox - 설정 아이콘 -> 모두 HAR로 저장(Save All as HAR)), 파일을 저장하고 저에게 보내주세요

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-2.png?raw=true" width="70%">



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---