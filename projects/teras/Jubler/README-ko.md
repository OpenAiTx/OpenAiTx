## Jubler - 자막 편집기

![GitHub release (latest by date)](https://img.shields.io/github/v/release/teras/Jubler)
![GitHub all releases](https://img.shields.io/github/downloads/teras/Jubler/total)
![GitHub](https://img.shields.io/github/license/teras/Jubler?v=2)
![Java](https://img.shields.io/badge/Java-8+-orange)
![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS%20%7C%20Windows-blue)
![GitHub Release Date](https://img.shields.io/github/release-date/teras/Jubler)

Jubler는 텍스트 기반 자막을 생성, 편집 및 변환하기 위한 무료 오픈 소스 자막 편집기입니다. 크로스 플랫폼 호환성을 위해 Java로 작성되었으며, 비디오 미리보기, 품질 검증 및 광범위한 포맷 지원과 함께 새 자막 작성과 기존 자막 개선을 위한 도구를 제공합니다.

(C) 2005-2025 Panayotis Katsaloulis
panayotis@panayotis.com

GNU Affero General Public License v3 (AGPL-3.0) 하에 라이선스됨

---

## 기능

### 자막 포맷
- SubRip (SRT), Advanced SubStation Alpha (ASS/SSA), WebVTT, MicroDVD, SubViewer, MPL2, Spruce DVD Maestro, TTML, ITT, DFXP, YouTube 자막 등 **20개 이상의 포맷 지원**
- **범용 인코딩 지원** (UTF-8, UTF-16 및 모든 Java 플랫폼 인코딩)
- **문자 및 문단 수준 스타일링** (지원하는 포맷에 한함, ASS/SSA, SRT)
- **모든 지원 포맷 간 포맷 변환**

### 비디오 통합
- **FFmpeg 통합**으로 프레임 미리보기 및 오디오 파형 시각화
- **MPlayer 지원**으로 비디오 재생
- **비디오 시청 중 실시간 자막 편집**
- **드래그 가능한 자막 블록이 있는 인터랙티브 타임라인**
- **타이밍 정렬을 위한 2점 동기화**
- **Shift/Alt 키 지원 및 스냅핑 기능이 강화된 미리보기 컨트롤**

### 편집 도구
- **시간 조작** - 이동, 프레임 속도 변환, 타이밍 반올림
- **내용 작업** - 항목 분할/병합, 파일 분할/병합
- **텍스트 처리** - 맞춤법 검사기, 정규식 지원 찾기 및 바꾸기
- **중첩 감지 및 해결 기능을 갖춘 스마트 시간 수정기**
- **나란히 자막 번역을 위한 번역 모드**
- **전체 기록을 통한 실행 취소/다시 실행**
- **자동 저장 및 복구**

### 품질 관리
- **구성 가능한 품질 규칙을 통한 자막 검증**
- **자막 표에 표시되는 CPS(초당 문자 수) 지표**
- **TED 가이드라인 준수 검사**
- **문제점을 강조하는 색상 구분 검증**
- **통계 및 분석 도구**

### 사용자 인터페이스
- **조정 가능한 스케일링을 지원하는 HiDPI 지원**
- **다크 테마 제공**
- **사용자 지정 가능한 키보드 단축키**
- **i18n 지원을 통한 다국어 인터페이스**
- **자막 그룹을 정리하는 색상 표시**

### 자동화
- **일괄 처리를 위한 명령줄 도구**
- **확장성을 위한 플러그인 시스템**
- **외부 도구 통합**
- **자동 번역을 위한 Azure 번역기 지원**

---

## 시작하기

### 요구 사항
- Java 8 이상 (배포판에 종종 포함됨)
- 선택 사항: 비디오 미리보기를 위한 MPlayer
- 선택 사항: 맞춤법 검사용 ASpell

### 설치

[릴리스 페이지](https://github.com/teras/Jubler/releases)에서 바이너리 다운로드:
- Windows, macOS, Linux 설치 프로그램
- Linux AppImage
- 범용 크로스 플랫폼 패키지

또는 소스에서 빌드 (자세한 내용은 [BUILD_AND_RUN.md](https://raw.githubusercontent.com/teras/Jubler/master/BUILD_AND_RUN.md) 참조)

### 실행

응용 프로그램 메뉴 또는 바탕 화면 바로 가기에서 실행하세요. 수동으로 실행할 수도 있습니다:
```bash
java -jar Jubler.jar
```

---

## Contributing

Jubler is an open source project that welcomes contributions. Whether you're fixing bugs, adding features, improving documentation, or translating the interface, your help is appreciated.

---

## Credits

Free code signing on Windows provided by [SignPath.io](https://signpath.io/), certificate by [SignPath Foundation](https://signpath.org/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---