## Orca 엔진

Discord: https://discord.gg/bvdpdT26Tq

Godot 엔진을 기반으로 Simplifine이 향상시켰습니다.


### 핵심은 무엇인가?
우리는 Godot에 완전 접근 권한을 가진 챗봇을 통합하고 있습니다.  
챗봇은 다음을 할 수 있습니다:  
  - 파일 읽기/편집/생성/삭제  
  - 전체 프로젝트를 컨텍스트로 이해  
  - 이미지 생성 및 생성된 이미지 간 일관성 유지  
  - 노드, 씬 등 Godot 네이티브 객체 편집  

### AI 어시스턴트 기능

통합된 챗봇은 Godot 개발을 위한 포괄적인 도구에 접근할 수 있습니다:

#### 씬 및 노드 관리
- **씬 작업**: 씬 열기, 생성, 저장, 인스턴스화  
- **노드 조작**: 씬 트리 내 노드 생성, 삭제, 이동, 이름 변경  
- **노드 검사**: 노드 속성, 스크립트, 계층 정보 가져오기  
- **노드 선택**: 에디터에서 현재 선택된 노드 작업  
- **클래스 탐색**: 사용 가능한 모든 Godot 노드 클래스 및 기능 접근  

#### 스크립트 및 코드 관리
- **파일 작업**: 프로젝트 내 모든 파일 읽기, 쓰기, 편집(라인 지정 가능)  
- **스크립트 생성**: AI 기반 코드 생성으로 새로운 GDScript 파일 만들기  
- **코드 편집**: 자연어 프롬프트로 기존 스크립트에 지능적 편집 적용  
- **오류 감지**: 단일 파일 또는 전체 프로젝트 컴파일 오류 검사  
- **스크립트 부착**: 노드에 스크립트 부착 및 관리  

#### 프로젝트 탐색 및 검색
- **파일 시스템**: 필터링 옵션과 함께 프로젝트 디렉토리 및 파일 탐색  
- **고급 의미 검색**: 함수 수준의 지능을 가진 자연어 질의로 관련 파일 및 코드 찾기  
- **멀티 홉 의존성 추적**: 프로젝트 전반의 함수 호출 체인 및 신호 흐름 완전 이해  
- **그래프 분석**: 연결된 파일, 핵심 프로젝트 구성 요소, 아키텍처 관계 발견  
- **스마트 검색 모드**: 의미 기반(AI 이해), 키워드(정확한 텍스트), 하이브리드(복합) 검색  

> 🔍 **[고급 인덱싱 문서 보기](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** 함수 수준 청킹, 신호 흐름 추적, 의존성 분석에 대한 기술적 세부사항

#### 시각 콘텐츠 생성
- **이미지 생성**: 다양한 예술 스타일로 텍스트 설명에서 새로운 이미지 생성
- **이미지 편집**: AI 기반 편집으로 기존 이미지 수정
- **3D 모델 생성**: 텍스트 프롬프트 또는 이미지로 3D 모델 생성(구성 시)
- **자산 관리**: 생성된 이미지를 특정 프로젝트 경로에 저장
- **스타일 일관성**: 생성된 자산 전반에 걸쳐 시각적 일관성 유지

#### 물리 및 게임 오브젝트
- **충돌 형태**: 물리 바디에 충돌 감지 추가(사각형, 원형, 캡슐)
- **노드 속성**: 변환, 물리, 게임 플레이 속성 수정
- **메서드 호출**: 맞춤 매개변수로 노드 메서드 실행

#### 신호 및 연결 시스템
- **신호 검사**: 사용 가능한 신호와 연결 목록 확인
- **연결 관리**: 노드 간 신호 연결 생성 및 관리
- **신호 추적**: 경량 이벤트 추적으로 신호 흐름 디버그
- **연결 검증**: 신호 연결 무결성 확인

#### 개발 워크플로우
- **다중 모델 지원**: GPT-5, Claude-4, Gemini-2.5, GPT-4o 중 선택 가능
- **실시간 지원**: 도구 실행 피드백과 함께 응답 스트리밍
- **오류 복구**: 신뢰성을 위한 AI 공급자 간 지능형 폴백
- **인증**: OAuth(Google, GitHub, Microsoft) 또는 게스트 모드로 보안 접근

### 고급 인덱싱 시스템

Orca Engine은 **함수 수준에서 코드를 이해하는 업계 최고 수준의 Godot 인덱싱 시스템**을 제공합니다:

- **🎯 함수 수준 인텔리전스**: 각 GDScript 함수, 신호, export가 풍부한 메타데이터와 함께 검색 가능한 단위가 됨
- **🔗 신호 흐름 추적**: 신호 방출 → 연결 → 핸들러 체인을 프로젝트 전체에서 완벽하게 이해  
- **🕸️ 다중 홉 의존성 추적**: 함수 호출 체인 추적(예: Input → Controller → Physics → Animation)
- **📊 그래프 중심성 분석**: 아키텍처상 중요한 파일과 그 구조적 역할 식별
- **🔍 스마트 검색 모드**: 의미 기반(AI 이해), 키워드(정확한 텍스트), 또는 하이브리드(결합) 검색

**성능**: 기존 행 기반 인덱싱보다 약 2.7배 더 지능적인 청크로 복잡한 게임 메커니즘의 정밀한 이해 가능.

> 📚 **[기술 심층 분석: 고급 인덱싱](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** | **[백엔드 설정 가이드](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)**

### 빠른 시작 (에디터 전용)

에디터를 빌드하고 실행합니다. AI 기능은 기본적으로 당사의 클라우드 백엔드에 연결됩니다. 로컬 백엔드 설정은 필요하지 않습니다.

macOS:
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
brew install scons pkg-config python3 git
scons platform=macos target=editor dev_build=yes vulkan=no -j"$(sysctl -n hw.ncpu)"
./bin/godot.macos.editor.dev.arm64
```

Windows (PowerShell):
```powershell
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
# If needed: scoop install python scons git   (or: choco install python scons git)
scons platform=windows target=editor dev_build=yes vulkan=no -j $env:NUMBER_OF_PROCESSORS
.\bin\godot.windows.editor.dev.x86_64.exe
```

리눅스 (우분투/데비안):
```bash
git clone https://github.com/Simplifine-gamedev/orca-engine.git
cd orca-engine
sudo apt update
sudo apt install -y build-essential scons pkg-config libx11-dev libxcursor-dev libxinerama-dev \
  libgl1-mesa-dev libglu1-mesa-dev libasound2-dev libpulse-dev libudev-dev libxi-dev libxrandr-dev \
  python3 python3-pip git
scons platform=linuxbsd target=editor dev_build=yes vulkan=no -j"$(nproc)"
./bin/godot.linuxbsd.editor.dev.x86_64
```
노트:  
- Vulkan SDK가 필요하지 않습니다. 에디터는 플랫폼 기본 렌더러를 사용합니다 (macOS에서는 Metal, Windows에서는 D3D12, Linux에서는 GLES3). Vulkan은 선택 사항이며 에디터를 빌드하거나 실행하는 데 필요하지 않습니다.  
- 에디터를 클라우드 대신 자체 호스팅 백엔드에 연결하려면 아래 백엔드 섹션을 참조하세요.  

### 백엔드 (선택적 로컬 / 클라우드 배포)  

- 로컬 개발 또는 자체 호스팅을 위해 **[백엔드 설정 가이드](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)** 를 따르세요. 환경 변수, 로컬 실행, `backend/deploy.sh`를 통한 Google Cloud Run 배포 방법이 포함되어 있습니다.  
- 고급 인덱싱 세부 정보(함수 수준 청크, 의존성 그래프)는 **[backend/indexing.md](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/indexing.md)** 를 참조하세요.  

#### 환경 구성  

API 키가 포함된 `.env` 파일을 `backend/` 디렉토리에 생성하세요:


```env
# Required: AI provider for embeddings and chat
OPENAI_API_KEY=YOUR_OPENAI_API_KEY
# ANTHROPIC_API_KEY=YOUR_ANTHROPIC_API_KEY
# GOOGLE_API_KEY=YOUR_GOOGLE_API_KEY

# Required: For advanced vector search and function-level indexing
WEAVIATE_URL=https://YOUR-WEAVIATE-ENDPOINT
WEAVIATE_API_KEY=YOUR_WEAVIATE_API_KEY

# Optional: Additional configuration
FLASK_SECRET_KEY=YOUR_RANDOM_SECRET_KEY

# Development mode (set to 'false' in production)
DEV_MODE=true
```

> ⚙️ **[백엔드 구성 가이드 보기](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md)** 전체 환경 변수 문서 및 배포 지침 참조

#### 인덱싱 성능 (대규모 프로젝트)

에디터는 서버 측 인덱싱을 자동으로 실행합니다. 대규모 코드베이스의 경우, 속도를 높이기 위해 다음 설정을 적용하세요 (`backend/.env`에 로컬로 또는 `backend/deploy.sh` 실행 전에 Cloud Run이 비밀로 인식하도록):

```env
# Parallelism and batching
INDEX_MAX_WORKERS=32         # number of parallel file workers on the backend
EMBED_MAX_PARALLEL=12        # concurrent embedding batches (respect provider limits)
EMBED_BATCH_SIZE=256         # embeddings per batch
CHUNK_MAX_LINES=100          # larger chunks = fewer embedding calls

# Small response caches
SEARCH_CACHE_TTL=45
GRAPH_CACHE_TTL=45
```
노트:
- `INDEX_MAX_WORKERS`를 에디터에서 환경 변수로 전달할 수도 있으며, 이는 백엔드의 `index_project`/`index_files`에 전달됩니다.
- Cloud Run에 배포할 때는 충분한 리소스(e.g., `--cpu 4`, `--memory 8Gi`, 더 높은 `--concurrency`)를 확보하세요.

### Godot Docs 검색 (RAG)

**[Godot Docs 검색: 인덱싱 및 쿼리](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/./godot_doc_search.md)**를 참조하세요.

#### 문제 해결

**에디터 및 빌드 문제:**
- **빌드 오류**: 플랫폼별 문제는 [Godot 공식 빌드 문서](https://docs.godotengine.org/en/stable/development/compiling/index.html)를 참고하세요.
- **Python 의존성 문제**: Python 3.8 이상을 사용하고 가상 환경 사용을 고려하세요.
- **도구 누락**: 백엔드 연결이 완료되어야 챗봇 도구가 나타납니다.

**AI 백엔드 문제:**
- **연결 문제**: 백엔드가 http://localhost:8000 에서 실행 중인지, API 키가 올바르게 설정되었는지 확인하세요.
- **검색 작동 안함**: Weaviate 연결(환경 변수 WEAVIATE_URL 및 WEAVIATE_API_KEY) 확인.
- **인덱싱 문제**: 함수 추출 및 의존성 추적 로그를 확인하세요.

> 🔧 **[상세 백엔드 문제 해결](https://raw.githubusercontent.com/Simplifine-gamedev/orca-engine/main/backend/README.md#troubleshooting)** — 벡터 검색, 인덱싱, API 구성 문제 관련.

### 라이선스
- 업스트림 Godot Engine 코드: Expat (MIT). `LICENSE.txt` 참조.
- 서드파티 구성요소: `COPYRIGHT.txt` 및 `thirdparty/` 내 라이선스 참조.
- Simplifine 원본 기여: 비상업적 소스 공개. `NOTICE` 및 `LICENSES/COMPANY-NONCOMMERCIAL.md` 참조.

상업적 라이선스도 제공됩니다. 문의: [support@simplifine.com]

### 저작권 표시
본 프로젝트는 Godot Engine과 Godot Engine 기여자 Juan Linietsky 및 Ariel Manzur를 기반으로 합니다. Godot 프로젝트와는 관련이 없습니다.

### 브랜딩
본 프로젝트는 Simplifine의 독립 배포판입니다. “Godot” 및 관련 상표는 각 소유자의 재산입니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---