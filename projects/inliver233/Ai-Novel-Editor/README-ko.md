# AI 소설 에디터

PyQt6 기반의 AI 보조 소설 에디터로, 지능형 자동 완성, 프로젝트 관리, 개념 조직 등 전문적인 집필 도구를 제공합니다.

## 설치

1. 프로젝트 클론
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. 가상 환경 생성
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. 의존성 설치
```bash
pip install -r requirements.txt
```
4. 프로그램 실행
```bash
python src/main.py
```

## 주요 기능

### 프로젝트 관리
- 계층화된 문서 구조 (작품 > 챕터 > 씬)
- 프로젝트 가져오기/내보내기 (TEXT, MARKDOWN, DOCX, PDF, HTML 포맷 지원)
- 자동 백업 및 버전 관리
- 다중 프로젝트 관리

### AI 보완 기능
- 세 가지 보완 모드: 자동 보완, 수동 보완(추천: 탭 한 번 누르면 보완 제안, 다시 한 번 누르면 보완 적용), 보완 비활성화
- 세 가지 컨텍스트 모드:
  - 빠른 모드: 경량 컨텍스트, 빠른 응답
  - 균형 모드: 중간 컨텍스트, 품질과 속도의 균형
  - 전체 모드: 전체 프로젝트 컨텍스트, 최상의 효과
- 다양한 AI 서비스 지원: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq 등
### 대纲 관리
- 시각화된 대纲 트리 구조
- 드래그 앤 드롭 정렬 및 계층 조정
- 문서 빠른 탐색
- 대纲 분석 및 최적화 제안

### API 설정
- 통합 AI 설정 센터
- 다중 서비스 제공자 사전 설정
- 연결 테스트 기능
- 설정안 저장 및 가져오기/내보내기

### 스마트 자동완성 설정
- 조절 가능한 트리거 지연
- 자동완성 길이 제한
- 컨텍스트 길이 설정
- 스트리밍 응답 지원

### 프롬프트 편집
- 내장 다양한 작성 템플릿
- 사용자 정의 프롬프트 템플릿
- 템플릿 분류 관리
- 모드별 템플릿 설정
### 인터페이스 기능
- 밝음/어두움 두 가지 테마
- 삼단 레이아웃(프로젝트 트리, 에디터, 개념 패널)
- 접이식 사이드바
- 전체 화면 작성 모드
- 집중 모드(문장, 단락, 타자기, 젠 모드, 몰입 모드)

### 검색 및 바꾸기
- 전체 프로젝트 텍스트 검색
- 정규식 지원
- 일괄 바꾸기 기능
- 고급 검색 옵션

### 개념 관리
- 등장인물, 장소, 아이템 자동 감지
- 개념 관계 관리
- 태그 및 분류 시스템
- 개념 빠른 삽입

## 단축키
- `Ctrl+N`: 새 프로젝트 만들기
- `Ctrl+O`: 프로젝트 열기
- `Ctrl+S`: 문서 저장
- `F11`: 전체 화면 모드
- `Tab`: AI 자동완성 수동 트리거(수동 모드에서)
- `Ctrl+F`: 찾기
- `Ctrl+H`: 찾아 바꾸기
- `Ctrl+Shift+H`: 고급 찾아 바꾸기


## 시스템 요구 사항

- Python 3.8+
- PyQt6
- 운영 체제: Windows, macOS, Linux

## 작성자

**inliver**
- 이메일: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---