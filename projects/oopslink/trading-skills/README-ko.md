# trading-skills

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![CLI](https://img.shields.io/badge/-CLI-000000?logo=linux&logoColor=white)
![Financial Data](https://img.shields.io/badge/-Financial%20Data-4A90E2?logo=data)

> **Tushare Pro용 종합 금융 데이터 CLI** | **7개 이상의 트레이딩 스킬 모듈** | **52개 이상의 데이터 도구** | **프로덕션 준비 완료**

금융 데이터 조회, 분석 및 트레이딩 전략 개발을 위한 종합 도구를 갖춘 전문 등급의 스킬 개발 및 교육 프로젝트입니다. 모듈식 스킬 아키텍처, 완전한 CLI 구현 및 광범위한 테스트 커버리지를 특징으로 합니다.

---

## 📋 주요 특징

- **7개의 전문화된 스킬 모듈**: 주식, 선물, 지수, 외환, 알파, 개념, 금융
- **52개 이상의 데이터 조회 도구**: Tushare Pro API와 완전 동기화
- **프로덕션 CLI**: 타입 안전 명령줄 클라이언트, 캐싱 및 다양한 출력 형식 지원
- **종합 테스트**: CLI, 캐시, 설정, 데이터 출력 등 992개 이상의 테스트 포함
- **스킬 기반 학습**: 트레이딩 개념과 데이터를 이해하기 위한 모듈형 지식 기반
- **Git 기반 설정 관리**: 버전 관리로 구성 설정 관리

---

## 📁 프로젝트 구조

```
trading-skills/
├── skills/                      # Trading skill modules (7 categories)
│   ├── tushare-stock/          # Stock trading fundamentals and techniques
│   ├── tushare-futures/        # Futures contracts and strategies
│   ├── tushare-index/          # Index data and analysis
│   ├── tushare-forex/          # Foreign exchange trading
│   ├── tushare-alpha/          # Alpha factor generation
│   ├── tushare-concepts/       # Key trading and financial concepts
│   └── tushare-financial/      # Financial statement analysis
├── tools/tushare_cli/          # CLI implementation
│   ├── src/                    # Python package
│   │   └── tushare_cli/        # Main CLI code
│   │       ├── commands/       # Command modules by category
│   │       ├── api.py          # Tushare API wrapper
│   │       ├── cache.py        # Response caching layer
│   │       ├── config.py       # Configuration management
│   │       ├── output.py       # Output formatting (JSON, CSV, Table)
│   │       └── main.py         # CLI entry point
│   └── pyproject.toml          # Package configuration
├── tests/                       # Test suite (992+ tests)
│   └── tushare_cli/           # CLI tests
│       ├── test_cache.py       # Cache functionality tests
│       ├── test_commands_*.py  # Command tests by category
│       ├── test_config.py      # Configuration tests
│       ├── test_main.py        # CLI entry point tests
│       └── test_output.py      # Output format tests
└── docs/plans/                 # Design and implementation plans
```

---

## 🚀 Quick Start

### 1. Install the CLI

```bash
# Clone the repository
git clone git@github.com:oopslink/trading-skills.git
cd trading-skills

# Install the CLI in development mode
pip install -e tools/tushare_cli/
```

### 2. Tushare 토큰 설정하기

[Tushare Pro](https://tushare.pro/user/token)에서 토큰을 받으세요

```bash
# Option 1: Config file (recommended, persists across sessions)
tushare-cli config set-token YOUR_TOKEN

# Option 2: Environment variable
export TUSHARE_TOKEN=YOUR_TOKEN

# Option 3: Command-line flag
tushare-cli --token YOUR_TOKEN stock daily --ts-code 000001.SZ
```

### 3. Claude Code에서 스킬 설정하기 (선택 사항)

Claude Code에서 거래 스킬을 사용하려면:

```
/plugin marketplace add oopslink/trading-skills
/plugin install trading-skills@trading-skills
```

이 작업은 7개의 모든 거래 기술 모듈을 설치하여 Claude Code 대화에서 참조 지식으로 사용할 수 있게 합니다.

### 4. 첫 번째 쿼리 시도하기

```bash
# Get stock daily data
tushare-cli stock daily --ts-code 000001.SZ

# Get in JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# Get with caching enabled
tushare-cli --cache stock daily --ts-code 000001.SZ
```

---

## 📚 API 카테고리

| 카테고리 | 스킬 | 명령어 | 데이터 도구 |
|----------|--------|----------|------------|
| **주식** | tushare-stock | 8개 이상 명령어 | 일별, 수정주가, 주간, 월간, 시세 |
| **선물** | tushare-futures | 7개 이상 명령어 | 일별, 연속, 증거금 |
| **지수** | tushare-index | 6개 이상 명령어 | 일별, 주간, 구성종목 |
| **외환** | tushare-forex | 4개 이상 명령어 | 일별, OHLC |
| **알파** | tushare-alpha | 5개 이상 명령어 | 팩터, 점수, 백테스팅 |
| **컨셉** | tushare-concepts | 3개 이상 명령어 | 컨셉주, 업데이트 |
| **재무** | tushare-financial | 6개 이상 명령어 | 손익, 재무상태, 현금흐름, 지표 |

---

## 🛠️ 사용 예시

### 주식 데이터 조회

```bash
# Daily prices for a stock
tushare-cli stock daily --ts-code 000001.SZ --start-date 20240101

# Weekly prices
tushare-cli stock weekly --ts-code 000001.SZ

# Stock quotes (real-time equivalent)
tushare-cli stock quotes --ts-code 000001.SZ
```

### 쿼리 선물 데이터

```bash
# Futures daily data
tushare-cli futures daily --ts-code IF --trade-date 20240115

# Continuous contract data
tushare-cli futures continuous --ts-code IF --start-date 20240101
```

### 쿼리 인덱스 데이터

```bash
# Index daily data
tushare-cli index daily --ts-code 000001.SH

# Index constituents
tushare-cli index constituents --ts-code 000001.SH
```

### 출력 형식

```bash
# Table format (default)
tushare-cli stock daily --ts-code 000001.SZ

# JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# CSV format
tushare-cli stock daily --ts-code 000001.SZ --format csv
```

---

## 🧪 Testing

Run the comprehensive test suite:

```bash
# Run all tests
pytest tests/

# Run tests with coverage
pytest tests/ --cov=tools/tushare_cli/src/tushare_cli

# Run specific test file
pytest tests/tushare_cli/test_commands_stock.py

# Run with verbose output
pytest tests/ -v
```
프로젝트에는 다음을 포함하는 **992개 이상의 테스트**가 포함되어 있습니다:
- CLI 명령 실행
- API 캐싱 동작
- 구성 관리
- 출력 형식 지정
- 오류 처리

---

## 📖 스킬 문서

각 트레이딩 스킬은 자세히 문서화되어 있습니다:

- **[tushare-stock](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-stock/SKILL.md)** - 주식 거래 기초
- **[tushare-futures](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-futures/SKILL.md)** - 선물 시장 및 전략
- **[tushare-index](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-index/SKILL.md)** - 지수 분석
- **[tushare-forex](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-forex/SKILL.md)** - 외환 거래
- **[tushare-alpha](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-alpha/SKILL.md)** - 알파 생성
- **[tushare-concepts](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-concepts/SKILL.md)** - 거래 개념
- **[tushare-financial](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-financial/SKILL.md)** - 재무 제표

---

## 🔧 구성

### 구성 설정


```bash
# Set Tushare token
tushare-cli config set-token YOUR_TOKEN

# View current configuration
tushare-cli config show

# Reset to defaults
tushare-cli config reset
```

### 환경 변수

```bash
TUSHARE_TOKEN=your_token_here
TUSHARE_CACHE_ENABLED=true
TUSHARE_CACHE_TTL=3600
```

---

## 💾 Caching

The CLI includes intelligent response caching:

```bash
# Enable cache (cache TTL: 3600 seconds by default)
tushare-cli --cache stock daily --ts-code 000001.SZ

# Clear cache
tushare-cli cache clear

# Check cache status
tushare-cli cache status
```

Benefits:
- API 호출 및 비용 감소
- 쿼리 성능 향상
- 속도 제한 준수

---

## � Claude 코드 통합

### 플러그인으로 사용하기

이 프로젝트는 Claude Code와 완벽하게 작동하는 전체 거래 기술 플러그인 스위트로 설계되었습니다:

```bash
# Step 1: Add the plugin marketplace entry
/plugin marketplace add oopslink/trading-skills

# Step 2: Install the plugin with all skill modules
/plugin install trading-skills@trading-skills
```

**설치되는 항목:**
- 모든 7개 거래 기술 모듈 (주식, 선물, 지수, 외환, 알파, 개념, 금융)
- 거래 개념 및 Tushare API에 대한 전체 지식 베이스
- 각 데이터 카테고리별 참고 문서
- Claude Code의 기술 시스템과의 통합

### Claude Code에서 기술 사용하기

설치 후, Claude Code 대화에서 어떤 기술이든 참조할 수 있습니다:

```
@skill tushare-stock     # Stock trading concepts and techniques
@skill tushare-futures   # Futures market knowledge
@skill tushare-index     # Index data and analysis
@skill tushare-forex     # Foreign exchange trading
@skill tushare-alpha     # Alpha factor generation
@skill tushare-concepts  # Financial and trading terminology
@skill tushare-financial # Financial statement analysis
```

### 로컬 개발 설정

로컬 개발용이거나 마켓플레이스를 사용하지 않는 경우:

```bash
# Clone the repository
git clone https://github.com/oopslink/trading-skills.git
cd trading-skills

# Install CLI tools
pip install -e tools/tushare_cli/

# Skills are automatically available in the project
# Reference them via: @skill tushare-<category>
```

---

## �📋 설계 및 계획

- [Tushare CLI 설계](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-design.md) - 아키텍처 및 API 설계
- [Tushare CLI 구현](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-impl.md) - 구현 세부사항

---

## 📝 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE) 파일 참조

---

## 🤝 기여

기여를 환영합니다! 다음을 참고하세요:

- 모든 새로운 트레이딩 기술은 [SKILL.md 형식](https://raw.githubusercontent.com/oopslink/trading-skills/main/CLAUDE.md)을 따라야 합니다
- 새로운 명령어에 대한 테스트 추가
- 필요에 따라 문서 업데이트
- 프로젝트 구조 규칙 준수

---

## 📞 지원

- 📖 트레이딩 개념 학습을 위한 기술 문서 확인
- 🐛 이슈 트래커에 문제 신고
- 💬 토론에서 아이디어 논의

---

**금융 데이터 애호가와 트레이더를 위해 ❤️를 담아 제작되었습니다**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---