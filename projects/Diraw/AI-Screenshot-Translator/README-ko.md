# AI 스크린샷 번역 도구 (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# 소개

이 도구는 **간단한 스크린샷 작업**을 통해 이미지를 AI 모델에 보내어 텍스트를 인식 및 번역하고, 번역 결과를 인터랙티브한 HTML 형식으로 독립 창에 표시합니다.

본 도구는 **사용자 지정 단축키 트리거, 다중 창 결과 관리, 시스템 트레이 실행**을 지원하여 일상 업무와 학습에서 번역 효율을 크게 향상시킵니다.

**도구 특징**: 1. 스크린샷 번역, 단축키로 실행; 2. 패치 스크린샷 및 번역, 자유롭게 드래그/확대/축소 가능, 다수의 번역 패치 그룹 생성 가능; 3. 수식은 원본 텍스트로 전환 가능하여 복사에 용이; 4. 사용자 지정 API 인터페이스

**해결하고자 하는 문제점**: 1. 현재 시중의 주요 전체 문서 번역 도구들의 비효율성; 2. PDF의 텍스트 복사 후 번역 시 수식 블록이 깨지거나 복사 불가한 경우 발생; 3. 이미지 스캔 PDF의 경우 텍스트 복사가 불가함

# 데모

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# 창 화면

번역 창:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

설정 창:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

설정 옵션에 대한 더 자세한 설명은 소프트웨어 내 또는 웹에서 [안내](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)에서 확인할 수 있습니다.

# 설치

소스 코드를 다운로드하여 실행하거나, [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) 페이지에서 실행 파일을 다운로드할 수 있습니다.

### 1. 저장소 클론

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. 가상 환경 생성 및 실행

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# 업데이트 계획

- ~~API 설정 GUI 창 추가, 수동 yaml 파일 설정 로직을 소프트웨어 자동 생성으로 최적화 (v0.3.0 완료)~~
- 이미지 및 수식 저장 시스템 추가, 후속 호출 편의성 제공 (v0.4 예정)
- (더 많은 기능 제안 또는 PR 환영)

# 기타

- 소프트웨어 아이콘 출처: [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Gemini 2.5 Flash와 DeepSeek-V3-0324의 버그 리포트에 감사드립니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---