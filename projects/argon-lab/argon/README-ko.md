<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=argon-lab&project=argon&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 아르곤 - MongoDB 타임머신 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**MongoDB 데이터베이스에서 시간여행을 떠나보세요. 브랜치, 복원, 실험도 두려움 없이 가능합니다.**

## Argon이란?

Argon은 MongoDB에 **Git과 같은 브랜칭**과 **타임 트래블** 기능을 부여합니다. 즉시 데이터베이스 브랜치를 만들고, 과거의 어느 시점으로도 복원하며, 데이터를 절대 잃지 않습니다.

### 🎯 주요 이점

- **⚡ 즉시 브랜치** - 전체 데이터베이스를 1ms 만에 복제 (몇 시간이 아님)
- **⏰ 시간여행** - **초당 220,000+ 쿼리** 속도로 원하는 시점의 데이터를 조회
- **🔄 안전한 복원** - 복원 전 변경 사항을 미리 확인
- **💾 저장소 비용 제로** - 브랜치가 데이터를 효율적으로 공유하며 90% 압축
- **🔌 기존 코드 호환** - 기존 MongoDB 코드와 바로 사용 가능
- **🚀 엔터프라이즈급 성능** - 최신 최적화로 26배 빨라진 시간여행 쿼리
- **✅ 완벽한 테스트** - 신뢰성을 보장하는 광범위한 테스트 커버리지
- **🗜️ 스마트 압축** - 자동 WAL 압축으로 저장 공간 80-90% 절감

## 빠른 데모

```bash
# Install
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Cross-platform

# Step 1: Import your existing MongoDB (like "git clone")
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your data now has time travel capabilities!

# Step 2: Use Argon like Git for your database
argon branches create test-env           # Branch like "git checkout -b"
argon time-travel query --project myapp --branch main --lsn 1000

# Step 3: Disaster recovery made simple
argon restore preview --time "1 hour ago"
argon restore reset --time "before disaster"
```
## MongoDB를 위한 Git 유사 워크플로우

### 🔄 **1단계: 가져오기(데이터베이스의 "git clone")**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **2단계: 브랜치 생성 ("git checkout -b")**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **3단계: 시간 여행("git log"로 데이터 확인하기)**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **4단계: 복원하기("git reset"으로 재앙 복구하기)**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## 작동 원리

Argon은 MongoDB 작업을 가로채어 **Write-Ahead Log (WAL)**에 기록하여 다음을 가능하게 합니다:
- 메타데이터 포인터를 통한 즉각적인 브랜칭
- 작업 재생을 통한 시점 복원
- 제로-카피 효율성

기존 MongoDB 코드는 변경 없이 작동합니다 - 단지 `ENABLE_WAL=true`만 추가하세요.

## 설치


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## 문서

- 📖 [빠른 시작 가이드](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [API 참고서](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [사용 사례](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [아키텍처](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## 커뮤니티

- 🤝 [커뮤니티 가이드](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - 함께하세요!
- 📋 [로드맵](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - 앞으로를 확인하세요
- 🐛 [이슈 신고](https://github.com/argon-lab/argon/issues)
- 💬 [토론](https://github.com/argon-lab/argon/discussions)
- 🏗️ [기여하기](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Argon 개발에 참여하세요
- 📧 [연락처](https://www.argonlabs.tech)

---

<div align="center">

**MongoDB에 타임머신을 선사하세요. 데이터를 다시는 잃지 마세요.**

⭐ **Argon이 도움이 되었다면 Star를 눌러주세요!**

[시작하기 →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [라이브 데모 →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---