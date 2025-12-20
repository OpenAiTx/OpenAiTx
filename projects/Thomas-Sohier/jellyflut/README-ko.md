<img height="80" width="80" src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/icon/rounded_logo.png"/>

# Jellyflut

Flutter로 만든 Jellyfin 클라이언트

베타 버전이며, 꽤 잘 작동합니다.

## :warning: 소식
 
현재 프로젝트는 정체된 상태입니다. 지금은 이 프로젝트에 많은 시간과 관심을 쏟지 못하고 있습니다. Flutter에서 비디오 플레이어가 너무 어려운 문제입니다. 해결책을 계속 찾고 있지만 현재로서는 이 앱 개발을 늦출 예정입니다.

PR은 언제든지 환영하며 기꺼이 받겠습니다.
 
## :gear: 기능

다음이 가능합니다:
- [x] 비디오 재생
- [x] 책 읽기 (epub/CBZ)
  - epub은 현재 단순 파서와 HTML 뷰어를 결합한 상태로 꽤 제한적입니다.
  - 추가 작업 필요
- [x] 음악 듣기
  - Linux에서 버그 있음 (조사 필요하거나 다른 패키지 사용 필요)
- [x] 사진 보기
- [x] SQLite를 사용해 로그 기록 및 서버 URL 저장
- [x] 모든 파일 탐색
- [x] ~~가장 큰 과제는 트랜스코딩 작동시키기, 현재 파일이 직접 재생 가능한지 확인하는 방법을 모르며, 불가능할 경우 jellyfin에 올바른 URL을 요청하는 방법도 모름~~ 작동합니다 (현재는 많이 작동하지 않음, 10.8.0 베타 3 이후로 깨짐)
  - Windows에서 제대로 작동하지 않음 (libvlc dll, 인증서 문제로 보임)
  - 컴퓨터에서는 지원 코덱을 수동으로 추가함. 일부 코덱이 누락될 수 있으며, 그럴 경우 이슈를 생성해주시면 재생 가능 여부를 확인하겠습니다.
- [x] 모든 화면에서 음악 제어
- [x] 비디오 파일에서 자막 추출 및/또는 파싱
 - 원격 srt만 가능하며, mkv 파일에서 파싱 불가 (VLC 제외)

## 완료
  - [X] 로그아웃 버튼 추가 및 정상 처리
  - [X] 로그인 페이지 재작업
  - [x] 히어로 애니메이션 완료
  - [x] 비동기 상세 로딩
  - [x] 상세 페이지 뒤로가기 시 끊김 개선
  - [x] 반응형 (작업 중)
  - [x] D-패드 내비게이션 (괜찮아 보이나 웹에서는 홈 화면 밖의 항목도 선택 가능)
    - 아직 개선이 필요하지만 앱의 80% 정도는 내비게이션 가능하여 현재로서는 충분함
  - [x] 다중 사용자 및 서버 처리
  - [x] API에서 재로드를 방지하기 위한 리사이징 시 데이터 처리 개선
    - 현재는 꽤 괜찮으며, 앞으로 더 개선 필요할 수 있음
  - [X] 테마 (다크/라이트)
  - [X] 현지화 (영어, 프랑스어, 독일어)

## 할 일
  - [ ] 모든 코드를 항상 리팩토링하기
  - [ ] 단위 테스트 추가
  - [ ] Jellyfin에서 "transcodeReasons=0" 문제 수정
  - [ ] 모든 Flutter 관련 문제 수정, 속도 향상
  - [ ] IPTV를 웹 버전과 동등하게 만들기
    - 가이드 작동 중
    - IPTV 채널 재생 가능
    - 녹화 기능 추가 필요

## 화면

 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/home.png"/>

### 휴대폰

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_1.png"/>
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_2.png"/>
</div>

### 데스크탑

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/music_details_desktop.png" height="360" />
</div>

## 시작하기

이 앱은 모든 플랫폼에서 작동해야 하지만 iOS와 MacOS는 테스트되지 않았습니다.

### 테스트 방법 ?

```bash
  git clone https://github.com/Thomas-Sohier/jellyflut.git
  cd jellyflut
  flutter packages get
  flutter packages upgrade
  flutter run
```

### 빌드 방법 ? (안드로이드)

```bash
  flutter build apk --release
```
### 빌드 방법 ? (플랫폼에 따른 컴퓨터)

리눅스에 특화되어, dep를 설치해야 합니다.


```bash
  # depend of your distro of course
  sudo apt-get update -y
  sudo apt-get install -y vlc libvlc-dev ninja-build clang libgtk-3-dev
```

```bash
  # enable desktop support at first (shouldn't be necessary but anyway)
  flutter config --enable-windows-desktop
  flutter config --enable-macos-desktop
  flutter config --enable-linux-desktop

  # build the app depending of your platform
  flutter build windows
  flutter build macos
  flutter build linux
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---