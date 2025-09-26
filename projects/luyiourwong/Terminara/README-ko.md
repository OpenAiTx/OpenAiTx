
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![딥위키에 질문하기](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python 지원](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

터미널 기반 AI 시뮬레이션 게임입니다.

## 사용 방법

[최신 릴리스](https://github.com/luyiourwong/Terminara/releases/latest)에서 실행 파일을 다운로드할 수 있습니다.

전체 압축 파일에는 실행 파일과 기본 월드 설정 파일이 포함되어 있습니다. 게임을 최신 버전으로 업데이트하는 경우 실행 파일만 다운로드할 수 있습니다.

| OS      | 버전                                               |
|---------|----------------------------------------------------|
| Windows | Windows 10, Windows 11                             |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS   |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26             |

<details>
<summary><strong>수동 실행</strong></summary>

### 설치 방법

1.  **저장소를 클론합니다:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```
2.  **가상 환경 생성:**

    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Windows에서는 `.venv\Scripts\activate`를 사용하세요

3.  **의존성 설치:**
    ```bash
    pip install -e .
    ```

### 시작 방법 1: 설치된 명령어 사용 (권장)
설치 후, 다음 명령어로 게임을 실행하세요:
```bash
terminara
```
### 방법 2 시작: 직접 실행
크로스 플랫폼 방식

```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Windows에서는 `terminara\main.py`를 사용하세요.

자세한 내용은 [기여 및 개발 가이드](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)를 참고하세요.
</details>

## AI 설정

애플리케이션을 시작한 후, 메인 메뉴에서 AI 설정을 구성해야 합니다.

![AI 설정](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

다음 필드를 입력해야 합니다: (OpenAI 호환 API)
- **호스트**: API 엔드포인트. 기본 OpenAI 엔드포인트를 사용하려면 비워두세요.
- **API 키**: AI 서비스용 API 키.
- **모델**: 사용하려는 모델.

"적용"을 클릭하여 설정을 저장하세요.

### 예시

#### 1. [OpenAI](https://platform.openai.com/) (기본)
- **호스트**: (비워두기)
- **API 키**: `YOUR_OPENAI_API_KEY`
- **모델**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **호스트**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API 키**: `YOUR_GEMINI_API_KEY`
- **모델**: `gemini-2.0-flash`

## 월드 설정

### 구성 저장소
월드 설정은 `terminara/data/worlds` 디렉토리에 저장됩니다. (정식 릴리스 버전)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### 새로운 세계 만들기
예시 세계 [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json)이 있습니다. 새로운 세계를 만들려면 [스키마](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json)를 참조할 수 있습니다.

## 링크

- [GitHub 페이지](https://luyiourwong.github.io/Terminara)
- [GitHub 저장소](https://github.com/luyiourwong/Terminara)
- [기여 및 개발 가이드](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## 라이선스

이 프로젝트는 [MIT 라이선스](LICENSE) 하에 라이선스가 부여되었습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---