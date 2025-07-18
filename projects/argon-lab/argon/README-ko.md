<translate-content># 아르곤 🚀

**ML/AI 워크플로우를 위한 Git 유사 MongoDB 브랜칭**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://golang.org)
[![Python](https://img.shields.io/badge/Python-3.11+-3776AB?logo=python)](https://python.org)
[![MongoDB](https://img.shields.io/badge/MongoDB-7.0+-47A248?logo=mongodb)](https://mongodb.com)

> **🎉 지금 사용 가능!** 아르곤은 500ms 미만의 작업 속도, ML 네이티브 기능, 하이브리드 Go+Python 아키텍처를 갖춘 엔터프라이즈급 MongoDB 브랜칭을 제공합니다.

## 아르곤이란?

아르곤은 ML/AI 워크플로우에 최적화된 Git 유사 데이터베이스 작업을 제공하는 MongoDB 브랜칭 시스템입니다. 데이터 과학 팀을 위한 일류 지원을 제공하는 "MongoDB용 네온"이라 생각하세요.

### 주요 기능

- **⚡ 즉시 브랜칭**: 크기와 상관없이 500ms 미만에 데이터베이스 브랜치 생성
- **🔄 쓰기 시 복사**: 전체 복사 대비 90% 이상 공간 절약하는 효율적 저장  
- **🧠 ML 네이티브**: MLflow, DVC, Weights & Biases 내장 통합
- **🌐 실시간**: 라이브 변경 스트림과 WebSocket 기반 대시보드
- **☁️ 멀티 클라우드**: AWS S3, 구글 클라우드 스토리지, Azure Blob 지원
- **🔒 엔터프라이즈**: 인증, RBAC, 감사 로그, 컴플라이언스 기능

## 아키텍처

아르곤은 성능과 개발자 생산성 모두를 최적화하는 하이브리드 아키텍처를 사용합니다:

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   CLI Tool      │    │  Web Dashboard  │    │ ML Integrations │
│   (Go Binary)   │    │   (Next.js)     │    │ (Python APIs)   │
└─────────────────┘    └─────────────────┘    └─────────────────┘
         │                       │                       │
         └───────────────────────┼───────────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Python API     │
                    │  (FastAPI)      │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Go Engine      │
                    │ (Performance)   │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │    MongoDB      │
                    │ + Change Streams│
                    └─────────────────┘
```
<translate-content>
**성능 계층 (Go)**: 변경 스트림, 분기 엔진, CLI, 저장소  
**생산성 계층 (Python)**: 웹 API, ML 통합, 관리자 기능  

## 빠른 시작  

### 설치  

선호하는 설치 방법을 선택하세요:  

#### 빠른 설치 (소스에서)  
</translate-content>
```bash
# Clone and build latest version
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
sudo mv argon /usr/local/bin/
```
#### Homebrew (macOS/Linux)

```bash
brew install argon-lab/tap/argonctl
```
#### npm (크로스 플랫폼)

```bash
npm install -g argonctl
```
#### 직접 다운로드

```bash
# Linux (x64)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-linux-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Intel)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Apple Silicon)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-arm64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/
```
#### 출처에서부터

```bash
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
```
### 설치 확인</translate-content>

```bash
argon --version
# argon version 1.0.0
```
### 개발 환경 설정 (기여자)


```bash
# Clone the repository
git clone https://github.com/argon-lab/argon.git
cd argon

# Start the development environment
docker compose up -d

# Verify services are running
curl http://localhost:8080/health  # Go engine
curl http://localhost:3000/health  # Python API
```
### 기본 사용법


```bash
# Verify installation
argon --version

# Get help
argon --help

# Create a new project (requires running services)
argon projects create --name my-ml-project --mongodb-uri mongodb://localhost:27017

# List your projects
argon projects list

# Note: Full functionality requires the Argon services to be running
# See Development Setup below for starting the complete system
```
## What Works Now

✅ **CLI 설치** - `argon` 명령어를 전역으로 설치  
✅ **핵심 아키텍처** - 하이브리드 Go+Python 시스템 준비 완료  
✅ **스토리지 엔진** - 42% 압축률의 S3 백엔드  
✅ **로컬 개발** - 완전한 Docker 환경  

## Coming Soon

✅ **Homebrew** - `brew install argon-lab/tap/argonctl` (현재 사용 가능!)  
✅ **npm 패키지** - `npm install -g argonctl` (현재 사용 가능!)  
🚧 **호스팅 서비스** - 즉시 사용 가능한 클라우드 호스팅 Argon  
🚧 **웹 대시보드** - 시각적 브랜치 관리  
🚧 **ML 통합** - MLflow, DVC, Weights & Biases  

## Current Status

**CLI 및 핵심 시스템은 프로덕션 준비 완료** 상태입니다. 패키지 관리자 배포 및 호스팅 서비스는 공개 출시를 준비 중입니다.

## Performance Targets

| 지표 | 목표 | 현재 상태 |
|--------|--------|----------------|
| 브랜치 생성 | <500ms | 🟢 구현 완료 |
| 변경 처리 | 10,000+ 작업/초 | 🟢 구현 완료 |
| 스토리지 효율 | 40%+ 압축 | 🟢 달성 (42.40%) |
| CLI 시작 시간 | <50ms | 🟢 달성 |

## Use Cases

### 데이터 사이언스 팀

```python
# In Jupyter notebook
import argon

# Create experiment branch
argon.branch.create("model-v2-experiment")

# Train model with versioned data
model = train_model(argon.data.get_collection("training_data"))

# Track experiment metadata
argon.experiment.log(model_accuracy=0.95, dataset_version="v2.1")

# Merge successful experiment
argon.branch.merge("model-v2-experiment", "main")
```
### 개발 팀</translate-content>

```bash
# Create feature branch with production data copy
argon branch create feature-new-analytics --from production

# Develop and test against real data
# ... make database schema changes ...

# Review changes before merge
argon diff main..feature-new-analytics

# Deploy to production
argon branch merge feature-new-analytics main
```
## 기여하기

기여를 환영합니다! 이 프로젝트는 커뮤니티를 위해 만들어진 오픈 소스 프로젝트입니다.

### 개발 워크플로우

1. **저장소를 포크하세요**
2. **개발 환경 설정**: `docker-compose up -d`
3. **적절한 서비스에서 변경 작업 수행**:
   - Go 엔진: `services/engine/`
   - Python API: `services/api/`
   - 웹 대시보드: `services/web/`
4. **변경 사항 테스트**: 테스트 스위트 실행
5. **풀 리퀘스트 제출**

### 프로젝트 구조


```
argon/
├── services/
│   ├── engine/          # Go performance engine
│   ├── api/             # Python FastAPI service
│   └── web/             # Next.js web dashboard
├── docs/                # Documentation
├── examples/            # Example usage and tutorials
├── scripts/             # Development and deployment scripts
└── docker-compose.yml   # Development environment
```
## 로드맵

### v1.0 (현재) - 프로덕션 준비 완료
- 하이브리드 Go+Python 아키텍처
- 핵심 브랜치 작업
- MongoDB 변경 스트림
- CLI 및 API 인터페이스
- 압축된 S3 스토리지

### v1.1 - ML 통합
- MLflow 커넥터
- DVC 통합
- Weights & Biases 지원
- 주피터 노트북 예제

### v1.2 - 엔터프라이즈 기능
- 사용자 인증 및 RBAC
- 팀 협업 기능
- 고급 브랜치 작업
- 성능 최적화

### v1.3 - 확장 및 다듬기
- 멀티 리전 배포
- 고급 분석
- 플러그인 아키텍처
- 엔터프라이즈 지원

## 아키텍처 심층 분석

자세한 기술 문서는 다음을 참조하세요:
- [아키텍처 개요](https://raw.githubusercontent.com/argon-lab/argon/master/docs/architecture.md)
- [API 문서](https://raw.githubusercontent.com/argon-lab/argon/master/docs/api.md)
- [개발 가이드](https://raw.githubusercontent.com/argon-lab/argon/master/docs/development.md)
- [배포 가이드](https://raw.githubusercontent.com/argon-lab/argon/master/docs/deployment.md)

## 커뮤니티

- **GitHub 토론**: 질문하고 아이디어 공유하기
- **Discord**: 커뮤니티와 실시간 채팅 (링크 곧 제공)
- **Twitter**: 업데이트를 위해 [@argondb](https://twitter.com/argondb) 팔로우하기

## 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## MongoDB 엔지니어들이 만든 프로젝트

Argon은 MongoDB 전문 지식을 바탕으로 구축되었으며, 변경 스트림, 최적화된 집계 파이프라인, 프로덕션 배포에서 얻은 성능 최적화 모범 사례 등의 고급 기능을 활용합니다.

---

**⭐ 이 저장소가 유용하다면 스타를 눌러주세요!**

[![GitHub stars](https://img.shields.io/github/stars/argon-lab/argon?style=social)](https://github.com/argon-lab/argon)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---