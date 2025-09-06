[![Pre-Release](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![License: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Supported Compilers](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![Unit Tests](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - 당신의 비행 녹화를 위한 검은 양.

## 소개
Sky Dolly는 실행 중인 Flight Simulator 2020 인스턴스에 연결하여 다양한 시뮬레이션 변수를 녹화하고 재생합니다.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

연결은 Flight Simulator X와 함께 도입된 표준 API인 SimConnect를 통해 이루어집니다.

[ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.MD)도 참고하세요.

## 기능
- 녹화 / 일시정지 / 재생
- 편대 비행 (여러 항공기, 녹화 중 재생, "편대 비행", 시간 오프셋)
- 설정 가능한 녹화 샘플 속도: 고정 또는 가변("자동")
- 조정 가능한 재생 속도 ("슬로우 모션", "타임랩스"), 재생 반복
- 위치, 속도 및 기본 비행 제어 시뮬레이션 변수 (에일러론, 러더, 플랩, 기어 등) 녹화
- 다양한 가져오기/내보내기 플러그인이 있는 플러그인 아키텍처 (CSV, GPX, IGC, KML)
- 100개 이상의 기본 위치와 가져오기/내보내기 기능을 갖춘 위치 모듈
- 데이터베이스(SQLite) 기반 지속성 ("로그북")

[YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I)에서 (미리보기) 출시 예고편을 시청하세요:

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Sky Dolly로 제작된 더 많은 영상은 [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md)를 참고하세요. 새롭고 다가오는 기능은 [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md)에서 확인할 수 있습니다.

## 기본 사용법

- 비행을 시작하세요
- "녹화" 버튼을 클릭하세요 (키 R)
- 녹화를 일시정지할 수 있습니다 (키 P)
- 녹화를 중지합니다 (키 R) 그리고 "재생"을 클릭합니다 (스페이스바)
- 재생 속도를 조절하고 재생 위치를 탐색할 수 있으며, 재생 중에도 가능합니다
- 녹화된 비행은 자동으로 "로그북"에 저장됩니다
- 로그북에서 비행을 선택하고 "불러오기"를 누르거나 행을 더블클릭하여 저장된 비행을 불러옵니다

### 편대 녹화 및 재생

#### 녹화

- "편대" 모듈로 전환합니다 (키 F2)
- "녹화"를 클릭합니다 (키 R)
- 녹화된 각 항공기가 현재 비행에 추가됩니다
- 기존 항공기는 "자동" 샘플링 속도로 재생되며 녹화 중에도 샘플링 속도를 변경할 수 있습니다

#### 위치

- 마지막으로 녹화된 항공기가 "사용자 항공기"가 됩니다 (비행 시뮬레이터에서 카메라가 따라가는 대상)
- 녹화 전에 현재 "사용자 항공기"에 상대적인 위치를 선택합니다

#### 재생

- 단일 항공기 비행과 마찬가지로 "재생", "일시정지"를 클릭하고 타임라인에서 탐색할 수 있습니다
- "사용자 항공기"를 변경할 수 있으며 (재생 중에도) "조종석에서 조종석으로 점프"할 수 있습니다
- "사용자 항공기"를 제어하려면 "제어권 획득" 또는 "편대와 함께 비행" 옵션을 선택합니다

#### 편대 관리

- 비행("편대")에서 단일 항공기를 삭제할 수 있습니다
- 비행당 최소 한 대의 항공기가 있어야 하므로 마지막 항공기는 삭제할 수 없습니다
- 선택한 항공기에 시간 오프셋을 추가할 수 있습니다 ("멀티플레이어 편대 비행 동기화")
- 새 단일 항공기 비행을 시작하려면 "로그북" 모듈로 돌아가 (키 F1) "녹화"를 클릭합니다 (키 R)

가이드가 있는 ["텔 투어"](https://github.com/till213/Tell-Tours) 중 하나로 시도해 보시겠어요? :)

## 다운로드

[릴리즈](https://github.com/till213/SkyDolly/releases)로 가서 최신 릴리즈를 다운로드하세요.

최신 (사전) 릴리즈: **Sky Dolly 0.19.2**

다운로드한 복사본의 무결성을 확인하려면 [공개된 SHA-256 체크섬](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md)과 계산한 체크섬을 비교하세요.

## 빌드

[BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md) 문서를 참조하세요.

## 관련 프로젝트

- https://github.com/nguyenquyhy/Flight-Recorder - .Net 기반의 비행 기록 및 재생 애플리케이션
- https://github.com/saltysimulations/saltyreplay/ - 웹 사용자 인터페이스를 갖춘 기록 및 재생
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - 비행을 기록하고 Google Earth(KML 형식) "재생"을 생성
- https://github.com/Elephant42/FS_Tool - 항공기 위치 및 시뮬레이션 속도를 설정할 수 있는 간단한 도구
- https://github.com/pyviator/msfs-geoshot - 스크린샷을 찍고 자동으로 "지오태그" 지정
- https://github.com/ijl20/msfs_logger_replay - IGC 로거 및 재생(FSX용)
- https://joinfs.net/ - 서로 다른 비행 시뮬레이터(MSFS, Prepar3D/FSX, XPlane) 간 멀티플레이어 비행 동기화 지원. 편대 비행 기록("오버더브") 기능이 포함된 비행 기록기도 제공.
- https://github.com/paulalexandrow/a32nx-webremote - FlyByWire의 A32NX용 WebRemote: FSUIPC7을 사용하여 FBW A320 조종석 기능 제어
- https://flightloganalyzer.com/ - FlightLog Analyzer는 MSFS 로그북을 분석하며 Sky Dolly에서 읽을 수 있는 CSV 내보내기 기능 제공
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave는 비행 계획을 자동 또는 요청 시 저장
- https://github.com/mracko/MSFS-Landing-Inspector - 착륙 성능 분석
- [관심 지점(Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Microsoft Flight Simulator 내 관심 지점, 공항 및 3D 도시

## 기타 유용한 리소스

- https://obsproject.com/ - 화면 캡처 / 방송 애플리케이션
- https://sqlitebrowser.org/ - Sky Dolly 로그북 (*.sdlog) 데이터베이스 파일을 탐색하고 직접 SQL 쿼리 실행


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---