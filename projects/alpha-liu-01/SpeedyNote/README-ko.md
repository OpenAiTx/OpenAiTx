# 📝 SpeedyNote

_클래식 태블릿 PC, 저해상도 화면 및 빈티지 하드웨어를 위해 설계된 가볍고 빠르며 스타일러스 최적화된 노트 작성 앱입니다._

영어를 잘 모르시는 경우 [중국어 README](https://github.com/alpha-liu-01/SpeedyNote/blob/main/speedynote_README_zh_CN.md)로 이동하세요.

![cover](https://i.imgur.com/UTNNbnM.png)

---

## ✨ 기능

- 🖊️ 스타일러스 지원이 포함된 **압력 감지 잉킹**
- 📄 탭 또는 스크롤 가능한 페이지 뷰의 **다중 페이지 노트북**
- 📌 주석 오버레이가 포함된 **PDF 배경 통합**
- 🌀 직관적인 한 손 조작을 위한 **다이얼 UI + 조이콘 지원**
- 🎨 페이지별 배경 스타일: 그리드, 줄무늬 또는 빈 페이지 (사용자 설정 가능)
- 💾 내보내기/가져오기 및 공유용 **휴대용 `.snpkg` 노트북**
- 🔎 다이얼로 **확대, 팬, 두께 및 색상 프리셋 전환**
- 💡 **저사양 장치용 설계** (Intel Atom N450에서 133Hz 샘플링 속도)
- 🌏 전 세계 여러 언어 지원 (전 세계 인구의 절반 커버)

---

## 📸 스크린샷

| 그림 | 다이얼 UI / 조이콘 컨트롤 | 오버레이 그리드 옵션 |
|----------------|------------------------|-----------------------|
| ![draw](https://i.imgur.com/iARL6Vo.gif) | ![pdf](https://i.imgur.com/NnrqOQQ.gif) | ![grid](https://i.imgur.com/YaEdx1p.gif) |


---

## 🚀 시작하기

### ✅ 요구사항

- Windows 7/8/10/11/Ubuntu amd64/Kali amd64/PostmarketOS arm64
- Qt 5 또는 Qt 6 런타임 (Windows 릴리스에 번들 포함)
- 스타일러스 입력 (Wacom 권장)

### 🛠️ 사용법

1. `NoteApp.exe` 실행
2. 작업 폴더 선택을 위해 **폴더 아이콘** 클릭 또는 **`.snpkg` 패키지 가져오기**
3. 스타일러스로 쓰기/그리기 시작
4. **MagicDial** 또는 **조이콘**을 사용하여 도구 변경, 확대, 스크롤 또는 페이지 전환
5. 노트북은 `.snpkg` 형식으로 내보낼 수 있음

---

## 📦 노트북 형식

- 저장 형식:
  - 📁 `.png` 페이지 및 메타데이터가 포함된 **폴더**
  - 🗜️ 휴대용을 위한 **`.snpkg` 아카이브** (비압축 `.tar`)
- 각 노트북은 다음을 포함할 수 있음:
  - 주석이 포함된 페이지 이미지 (`annotated_XXXX.png`)
  - PDF에서 추출한 선택적 배경 이미지 (`XXXX.png`)
  - 메타데이터: 배경 스타일, 밀도, 색상 및 PDF 경로

---

## 🎮 컨트롤러 지원

SpeedyNote는 태블릿 사용자에게 이상적인 컨트롤러 입력을 지원합니다:

- ✅ **좌측 조이콘 지원**
- 🎛️ 아날로그 스틱 → 다이얼 제어
- 🔘 버튼 매핑 가능:
  - 다양한 기능을 위한 다이얼 제어
  - 전체 화면 토글
  - 색상 / 두께 변경
  - 제어판 열기
  - 페이지 생성/삭제

> 길게 누른 상태에서 회전 = 누르고 돌리기 매핑

---

## 📁 소스에서 빌드하기

1. **Qt 6** 및 **CMake** 설치
2. 이 저장소 복제
3. 실행:


```bash
rm -r build
mkdir build
# ✅ Update translation source files (ensure the .ts files exist already)
& "C:\Qt\6.8.2\mingw_64\bin\lupdate.exe" . -ts ./resources/translations/app_fr.ts ./resources/translations/app_zh.ts ./resources/translations/app_es.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_zh.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_fr.ts
& "C:\Qt\6.8.2\mingw_64\bin\linguist.exe" resources/translations/app_es.ts
```
4. (선택 사항) GUI 인터페이스에서 번역 수정  
5. 실행:
```bash
rm -r build
mkdir build
& "C:\Qt\6.8.2\mingw_64\bin\lrelease.exe" ./resources/translations/app_zh.ts ./resources/translations/app_fr.ts ./resources/translations/app_es.ts

Copy-Item -Path "C:\Games\yourfolder\resources\translations\*.qm" -Destination "C:\Games\yourfolder\build" -Force

cd .\build
cmake -G "MinGW Makefiles" .. 
cmake --build .  
& "C:\Qt\6.8.2\mingw_64\bin\windeployqt.exe" "NoteApp.exe"
Copy-Item -Path "C:\yourfolder\dllpack\*.dll" -Destination "C:\yourfolder\build" -Force
Copy-Item -Path "C:\yourfolder\bsdtar.exe" -Destination "C:\yourfolder\build" -Force
./NoteApp.exe
cd ../
```
원본 텍스트에는 1개의 줄이 있습니다. 번역본도 반드시 정확히 1개의 줄을 포함해야 합니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---