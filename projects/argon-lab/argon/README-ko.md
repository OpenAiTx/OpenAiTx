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

**MongoDB 데이터베이스에서 시간 여행을 하세요. 브랜치를 만들고, 복원하며, 두려움 없이 실험하세요.**

## 아르곤(Argon)이란?

아르곤은 MongoDB에 **Git과 같은 브랜칭**과 **타임 트래블** 기능을 제공합니다. 즉시 데이터베이스 브랜치를 만들고, 원하는 시점으로 복원하며, 데이터를 잃지 않습니다.

### 🎯 주요 장점

- **⚡ 즉시 브랜치** - 전체 데이터베이스를 1ms 만에 복제 (수 시간이 아님)
- **⏰ 타임 트래블** - 원하는 과거 시점의 데이터를 쿼리
- **🔄 안전한 복원** - 복원 전 변경사항 미리보기
- **💾 제로 스토리지 비용** - 브랜치 간 데이터를 효율적으로 공유
- **🔌 완벽한 호환성** - 기존 MongoDB 코드와 바로 사용 가능

## 빠른 데모

```bash
# Install
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Cross-platform

# Create a time-travel enabled database
export ENABLE_WAL=true
argon projects create myapp

# Your app crashed after bad migration? No problem!
argon restore preview --time "1 hour ago"
argon restore reset --time "before disaster"

# Need a test environment? Branch instantly!
argon branches create test-env
# Full database copy created in 1ms 🚀
```
## 실제 사용 사례

### 🚨 **재해 복구**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
### 🧪 **안전한 테스트**

```bash
# Test with real production data
argon branches create staging --from production
# Run risky migrations fearlessly
```
### 📊 **데이터 분석**

```bash
# Compare data across time
argon time-travel diff --from "last week" --to "today"
# See exactly what changed
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
- 🛠️ [API 레퍼런스](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [사용 사례](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [아키텍처](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## 커뮤니티

- 🐛 [이슈 신고](https://github.com/argon-lab/argon/issues)
- 💬 [토론](https://github.com/argon-lab/argon/discussions)
- 📧 [문의하기](https://www.argonlabs.tech)

---

<div align="center">

**MongoDB에 타임머신을 제공합니다. 데이터 손실을 방지하세요.**

⭐ Argon이 도움이 되었다면 **별표**를 눌러주세요!

[시작하기 →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [라이브 데모 →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---