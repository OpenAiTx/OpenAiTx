![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**모든 GitHub 저장소를 AI 기반 Dockerfile 생성으로 프로덕션 준비가 완료된 Docker 컨테이너로 변환하세요.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer는 GitHub 저장소를 분석하여 프로덕션 환경에 적합한 Dockerfile을 자동으로 생성하는 AI 기반 웹 애플리케이션입니다. GitHub URL을 붙여넣기만 하면, 지능적인 베이스 이미지 선택, 의존성 관리, Docker 모범 사례가 적용된 맞춤형 Dockerfile을 얻을 수 있습니다.

## 🌟 빠른 접근

어떤 GitHub 저장소 URL이든 `github.com`을 `gitcontainer.com`으로 바꿔 입력하면 해당 저장소의 Dockerfile 생성 페이지로 즉시 이동합니다.

예시:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ 주요 기능

- **🔄 즉시 URL 접근**: 모든 GitHub URL에서 'github.com'을 'gitcontainer.com'으로만 교체
- **🤖 AI 기반 분석**: OpenAI GPT-4를 사용하여 저장소 구조를 분석하고 지능적인 Dockerfile 생성
- **⚡ 실시간 스트리밍**: WebSocket 스트리밍으로 AI가 Dockerfile을 생성하는 과정을 실시간으로 확인
- **🎯 스마트 감지**: 기술 스택 자동 감지(Python, Node.js, Java, Go 등)
- **🔧 프로덕션 준비**: 보안, 멀티스테이지 빌드, 최적화 등 Docker 모범 사례를 적용한 Dockerfile 생성
- **📋 추가 지시사항**: 특수 환경을 위한 사용자 정의 요구사항 추가 가능
- **📄 Docker Compose**: 복잡한 애플리케이션에 대해 docker-compose.yml 자동 제안
- **🎨 현대적 UI**: 구문 강조를 위한 Monaco 에디터가 적용된 깔끔하고 반응형 인터페이스
- **📱 모바일 친화적**: 데스크톱과 모바일에서 모두 원활하게 작동

## 🚀 빠른 시작

### 사전 준비 사항

- Python 3.9 이상
- Git
- OpenAI API 키

### 설치 방법

1. **저장소 클론:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **의존성 설치:**
   ```bash
   pip install -r requirements.txt
   ```

3. **환경 변수 설정:**
   ```bash
   # .env 파일 생성
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **애플리케이션 실행:**
   ```bash
   python app.py
   ```

5. **브라우저 열기:**
   `http://localhost:8000`으로 이동

## 🛠️ 작동 방식

1. **URL 처리**: URL에서 'github.com'을 'gitcontainer.com'으로 바꿔 저장소에 접근
2. **저장소 클론**: Gitcontainer가 Git을 이용해 해당 GitHub 저장소를 로컬로 클론
3. **코드 분석**: [gitingest](https://github.com/cyclotruc/gitingest)를 사용해 저장소 구조 분석 및 관련 정보 추출
4. **AI 생성**: 분석 결과를 OpenAI GPT-4에 전달하여 Dockerfile 생성에 특화된 프롬프트로 요청
5. **스마트 최적화**: AI가 다음 항목을 고려하여 생성
   - 기술 스택 감지
   - 의존성 관리
   - 보안 모범 사례
   - 멀티스테이지 빌드 활용
   - 포트 설정
   - 환경 변수
   - 헬스 체크

## 📁 프로젝트 구조

```
cyclotruc-gitcontainer/
├── app.py                 # FastAPI 메인 애플리케이션
├── requirements.txt       # Python 의존성 목록
├── .env                  # 환경 변수 파일(직접 생성)
├── static/               # 정적 에셋(아이콘, CSS)
├── templates/
│   └── index.jinja       # 메인 HTML 템플릿
└── tools/                # 핵심 기능 모듈
    ├── __init__.py
    ├── create_container.py  # AI Dockerfile 생성
    ├── git_operations.py    # GitHub 저장소 클론
    └── gitingest.py        # 저장소 분석
```

## 🔧 구성

### 환경 변수

| 변수 | 설명 | 필수 여부 |
|----------|-------------|----------|
| `OPENAI_API_KEY` | OpenAI API 키 | 예 |
| `PORT` | 서버 포트 (기본값: 8000) | 아니오 |
| `HOST` | 서버 호스트 (기본값: 0.0.0.0) | 아니오 |

### 고급 사용법

도구를 프로그래밍 방식으로 사용할 수 있습니다:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # 저장소 클론
    clone_result = await clone_repo_tool(github_url)
    
    # gitingest로 분석
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Dockerfile 생성
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# 사용 예시
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 커스터마이징

### 사용자 정의 명령 추가

생성 과정을 커스터마이즈하려면 "추가 명령" 기능을 사용하세요:

- `"더 작은 이미지 크기를 위해 Alpine Linux 사용"`
- `"Redis 및 PostgreSQL 포함"`
- `"프로덕션 배포에 최적화"`
- `"디버깅을 위한 개발 도구 추가"`

## 📝 라이선스

이 프로젝트는 MIT 라이선스에 따라 라이선스가 부여되었습니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 🙏 감사의 말씀

- **[OpenAI](https://openai.com/)** - GPT-4 API 제공
- **[gitingest](https://github.com/cyclotruc/gitingest)** - 저장소 분석 기능 제공
- **[FastAPI](https://fastapi.tiangolo.com/)** - 뛰어난 웹 프레임워크
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** - 코드 구문 강조

## 🔗 링크

- **GitHub 저장소**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **데모**: 예제 저장소로 라이브로 체험해 보세요
- **이슈**: [버그 신고 또는 기능 요청](https://github.com/cyclotruc/gitcontainer/issues)

---

**[Romain Courtois](https://github.com/cyclotruc)가 ❤️ 를 담아 만들었습니다**

*어떤 저장소든 몇 초 만에 컨테이너로 변환하세요!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---