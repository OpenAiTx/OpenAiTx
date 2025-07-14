# 🚀 MountMate

_외장 드라이브 관리를 위한 간단한 macOS 메뉴 막대 앱입니다._

<p align="center">
  <img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/assets/icon.png" alt="MountMate 아이콘" width="100" height="100" style="border-radius: 22%; border: 0.5px solid rgba(0,0,0,0.1);" />
</p>

<p align="center">
  <a href="https://github.com/homielab/mountmate/releases">
    <img src="https://img.shields.io/github/v/release/homielab/mountmate?label=release&style=flat-square" />
  </a>
  <a href="https://github.com/homielab/mountmate">
    <img src="https://img.shields.io/github/downloads/homielab/mountmate/total?style=flat-square" />
  </a>
  <a href="https://brew.sh">
    <img src="https://img.shields.io/badge/homebrew-supported-blue?style=flat-square" />
  </a>
</p>

---

## ⚡️ 빠른 시작

[Homebrew](https://brew.sh)를 통해 설치:

```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
또는 [최신 .dmg 다운로드](https://github.com/homielab/mountmate/releases) 후 MountMate.app을 응용 프로그램 폴더로 드래그하세요.

## 🧩 MountMate란?

MountMate는 가벼운 macOS 메뉴 막대 유틸리티로, **외장 드라이브를 한 번의 클릭으로 마운트 및 언마운트**할 수 있습니다 – 터미널, 디스크 유틸리티, 번거로움 없이.

시끄러운 회전식 HDD를 다루든 드라이브 활성화 시기를 세밀하게 제어하고 싶든, MountMate는 메뉴 막대에서 깔끔하고 직관적인 솔루션을 제공합니다.

## 🧠 제작 동기

저는 4TB 외장 HDD를 Mac mini에 24시간 연결해 둡니다. 회전식 드라이브라 macOS가 사소한 작업(파인더 열기, Spotlight 실행 등)에도 계속 디스크를 회전시켰습니다. 그 결과:

- 원치 않는 소음
- 시스템 느려짐
- 에너지 낭비

다음 방법들을 시도했습니다:

- 디스크 유틸리티 – 너무 느리고 불편함
- 사용자 정의 셸 스크립트 – 너무 기술적임
- 기존 타사 앱 – 너무 무겁거나 제대로 작동하지 않음

그래서 **MountMate**를 만들었습니다.

## ✅ 기능

- 연결된 모든 **외장 드라이브** 보기
- 어떤 드라이브가 **마운트됐는지** 확인
- 클릭 한 번으로 드라이브 **마운트/언마운트**
- 사용 가능한 **남은 공간** 확인
- 조용히 **메뉴 막대**에서 실행
- 완전 네이티브 – Electron이나 의존성 없음

## ✨ MountMate를 사용하는 이유

macOS는 드라이브 연결 시 자동으로 마운트하지만, 터미널이나 디스크 유틸리티를 사용하지 않는 한 **나중에 다시 마운트하기 쉽지 않습니다**. MountMate는 다음에 적합합니다:

- 항상 필요하지 않은 외장 HDD
- 백업 용도로만 사용하는 드라이브
- 마모나 소음 감소
- 시스템 반응성 향상

## 🔐 개인 정보 보호, 빠르고 안전함

MountMate는 **완전히 오프라인**에서 작동하며, 네이티브 macOS API 및 명령줄 도구를 사용합니다. 다음을 보장합니다:

- 아무것도 추적하지 않음
- 인터넷 연결 불필요
- 파일 접근하지 않음
- 관리자 권한 필요 없음

단 하나의 작업을 잘 수행하는 깔끔한 유틸리티입니다.

## 🖼️ 스크린샷

<img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light.png" width="300" /><img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/dark.png" width="300" />

![전체 스크린샷](https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light-full.png)

## 🛠️ 설치

### 수동 설치

1. [최신 `.dmg` 릴리스 다운로드](https://github.com/homielab/mountmate/releases)
2. `.dmg` 파일 열기
3. `MountMate.app`을 **응용 프로그램** 폴더로 드래그
4. 설치 디스크 이미지 꺼내기
5. **응용 프로그램**에서 MountMate 실행

### Homebrew를 통한 설치

[Homebrew](https://brew.sh)가 설치되어 있다면, 이 저장소에서 직접 MountMate를 설치할 수 있습니다:


```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
### macOS에서 처음 사용하기

- MountMate가 확인되지 않은 개발자에게서 왔다는 경고가 표시되면,  
  **시스템 설정 → 개인정보 보호 및 보안 → 그래도 열기**로 이동하세요
- macOS가 앱을 확인하고 업데이트를 받도록 인터넷에 연결되어 있는지 확인하세요

## 📫 피드백 및 기여

MountMate는 개인적인 작업 흐름 문제를 해결하기 위해 만들어졌지만,  
다른 사용자들을 위해 개선하고 싶습니다.  
[이슈 열기](https://github.com/homielab/mountmate/issues)나 개선 사항 제안을 자유롭게 해주세요!

## 🤝 지원

MountMate가 도움이 되었다면, 개발 지원을 고려해 주세요:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/homielab)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---