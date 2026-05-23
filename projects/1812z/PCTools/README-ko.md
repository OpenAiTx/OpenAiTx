# 🖥️ PCTools

> 간단한 Python 프로그램으로, Windows와 Home Assistant를 원활하게 통합하여 하드웨어 모니터링, 원격 제어 등의 기능을 구현합니다.

[![GitHub Release](https://img.shields.io/github/v/release/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools/releases/latest)
[![GitHub Downloads](https://img.shields.io/github/downloads/1812z/PCTools/total?style=flat-square&logo=github&label=Downloads)](https://github.com/1812z/PCTools/releases)
[![GitHub Stars](https://img.shields.io/github/stars/1812z/PCTools?style=flat-square&logo=github)](https://github.com/1812z/PCTools)
[![License](https://img.shields.io/github/license/1812z/PCTools?style=flat-square)](LICENSE)

---

## ✨ 기능 특징

| 기능 | 설명 |
|------|------|
| 📊 **Aida64 모니터링** | 선택한 센서 데이터를 정기적으로 업데이트 |
| 🎮 **원격 명령어** | `commands` 폴더 내 `.bat`, `.lnk` 파일을 HA에 자동 동기화 |
| 📸 **웹 모니터링** | 스크린샷 / 카메라 / 실시간 화면 스트리밍 |
| 💬 **메시지 알림** | HA 텍스트 입력 감지 후 Toast 메시지로 표시 |
| 🌐 **사이드바 웹페이지** | 단축키로 HA 웹 사이드바 호출 |
| ⌨️ **단축키 연동** | 단축키로 HA 이진 센서 트리거 |
| 📱 **포그라운드 앱 피드백** | 현재 앱 이름 자동 보고, [Runtime Tracker](https://github.com/1812z/RunTime_Tracker) 지원 |
| 🖥️ **모니터 제어** | 다중 모니터 밝기 / 전원 / DDC-CI 명령 |
| 🔊 **볼륨 제어** | Windows 시스템 볼륨 조절 |
| 🌙 **다크 모드** | 시스템/앱 다크 모드 전환 |
| 📶 **블루투스 제어** | 시스템 블루투스 켜기/끄기 |
| ⚡ **명령행** | 사용자 정의 CMD/PowerShell 실행 |
| 🎨 **배경화면 엔진** | Wallpaper Engine 제어 |
| ⌨️ **키 입력 시뮬레이션** | 키보드 입력 시뮬레이션(미디어 키 포함) |
| 🔗 **URL 실행기** | 사용자 정의 URL 열기 |

**웹 모니터링 엔드포인트:**
- 스크린샷: `http://127.0.0.1:5000/screenshot.jpg`
- 카메라: `http://127.0.0.1:5000/video_feed`
- 실시간 화면: `http://127.0.0.1:5000/screen`

---

## 📷 스크린샷 예시

<details>
<summary>🖼️ 소프트웨어 인터페이스</summary>
<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/gui.png" alt="GUI" width="600"/>
</details>

<details>
<summary>📱 HA 인터페이스</summary>

**대안 보조 화면** (추천 [HA_Helper](https://github.com/1812z/Ha_Helper)와 함께 사용)

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/1743859715274.jpg" alt="보조 화면" width="400"/>

**메인 페이지**

<img src="https://raw.githubusercontent.com/1812z/PCTools/main/.github/images/image.png" alt="메인 페이지" height="500"/>

</details>

---

## 🚀 빠른 시작

### 1️⃣ 환경 설치

**방법 1**：[Releases](https://github.com/1812z/PCTools/releases/latest) 내 압축 파일 다운로드 (내장 실행 환경 포함)

**방법 2**：수동 구성
```bash
# Python 3.12
pip install -r requirements.txt
```
### 2️⃣ 서드파티 의존 소프트웨어 설치(선택 사항)

| 의존성 | 용도 |
|------|------|
| MQTT 서버 | Home Assistant 접속 |
| [Aida64](https://github.com/1812z/PCTools/releases) | 하드웨어 정보 모니터링 |
| [Twinkle Tray](https://github.com/xanderfrangos/twinkle-tray/releases) | 모니터 밝기 조절 |

### 3️⃣ 의존성 구성

1. **Aida64**: 메모리 공유 활성화 및 필요한 센서 데이터 선택
2. **Twinkle Tray**: 모니터 정보 정상 읽기 확인
3. **배경화면 엔진**: 관련 작업 지원을 위해 실행

> 💡 센서 추가/수정 후 충돌 시, HA/MQTT 내 장치를 삭제하고 소프트웨어를 재시작하세요

### 4️⃣ 프로그램 실행

1. `打开GUI.bat` 실행하여 인터페이스 시작
2. 설정 진입 후 파라미터 구성 (**엔터로 저장**)
3. 필요한 플러그인 활성화 (**프로그램 재시작 권장**)
4. 시작 클릭 후 HA MQTT 통합에서 새 장치 확인

### 5️⃣ 부팅 시 자동 실행(선택 사항)

설정에서 **자동 시작** 클릭 시 프로그램이 백그라운드에서 실행되며 시스템 트레이에서 아이콘 확인 가능

---

## 📋 개발 계획

- [x] 키보드 단축키 연동
- [x] 코드 최적화
- [x] 플러그인 로직 최적화
- [ ] 컴퓨터 팬 제어
- [ ] Toast 다중 버튼 콜백
- [ ] 플러그인 마켓
- [ ] 미디어 제어
- [ ] NetEase 클라우드 가사 동기화


---

## 💡 추천 조합

| 소프트웨어 | 설명 |
|------|------|
| [OpenRGB](https://openrgb.org/) | RGB 조명 제어, HA 연동 지원 |
| [HASS.Agent](https://github.com/hass-agent/HASS.Agent) | 더 안정적인 동종 도구 |

---

## 감사의 글

- [python_aida64](https://github.com/gwy15/python_aida64) - Aida64 데이터 읽기

---

## 📝 기타

- 헤드리스 모드 지원: `python core.py`
- 일부 페이지는 전환 후에야 새로고침됨


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---