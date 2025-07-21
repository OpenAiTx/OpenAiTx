<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

# Argon - MongoDB 時光機 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**在你的 MongoDB 資料庫中穿越時空。分支、還原、勇敢實驗無所畏懼。**

## 什麼是 Argon？

Argon 為 MongoDB 帶來了 **類 Git 分支** 與 **時光旅行** 的超能力。即時建立資料庫分支，還原到任意歷史時間點，數據永不遺失。

### 🎯 主要優勢

- **⚡ 即時分支** - 1 毫秒內克隆整個資料庫（而不是幾小時）
- **⏰ 時光旅行** - 以 **22 萬+ 查詢/秒** 從任意歷史時刻查詢資料
- **🔄 安全還原** - 還原前可預覽變更內容
- **💾 零存儲成本** - 分支高效共用資料，壓縮率達 90%
- **🔌 即插即用** - 完美兼容現有 MongoDB 程式碼
- **🚀 企業級效能** - 最新優化後時光查詢快 26 倍
- **✅ 完整測試** - 全面測試覆蓋確保可靠性
- **🗜️ 智慧壓縮** - 自動 WAL 壓縮減少 80-90% 儲存空間

## 快速演示

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
## 類似 Git 的 MongoDB 工作流程

### 🔄 **步驟 1：導入（資料庫的 "git clone"）**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **步驟 2：分支（"git checkout -b"）**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **步驟 3：時光旅行（用 "git log" 查看資料）**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **步驟 4：還原（災難時使用 "git reset"）**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## 運作原理

Argon 會攔截 MongoDB 操作並將其記錄到**前置寫入日誌（WAL）**，實現：
- 透過中繼資料指標即時分支
- 透過重播操作實現時光旅行
- 零複製高效能

您現有的 MongoDB 程式碼可無需更改地運作——只需加入 `ENABLE_WAL=true`。

## 安裝


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## 文件說明

- 📖 [快速入門指南](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [API 參考文件](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [使用案例](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [架構說明](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## 社群

- 🤝 [社群指南](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - 歡迎參與！
- 📋 [發展藍圖](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - 查看未來規劃
- 🐛 [回報問題](https://github.com/argon-lab/argon/issues)
- 💬 [討論區](https://github.com/argon-lab/argon/discussions)
- 🏗️ [貢獻指南](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - 一起打造 Argon
- 📧 [聯絡我們](https://www.argonlabs.tech)

---

<div align="center">

**讓你的 MongoDB 擁有時光機。再也不會遺失資料。**

⭐ **如果 Argon 幫助了你，請給我們一顆星！**

[開始使用 →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [線上演示 →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---