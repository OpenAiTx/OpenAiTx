<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

# Argon - MongoDB 时光机 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**在你的 MongoDB 数据库中穿越时空。分支、还原和大胆实验，无需担心数据丢失。**

## 什么是 Argon？

Argon 赋予 MongoDB **类 Git 分支**与**时光穿梭**的超能力。可瞬间创建数据库分支，还原到历史上的任意时间点，数据永不丢失。

### 🎯 主要优势

- **⚡ 秒级分支** - 1 毫秒内克隆整个数据库（无需数小时）
- **⏰ 时光穿梭** - 以**每秒 22 万+ 查询**速度检索任意历史时刻的数据
- **🔄 安全还原** - 还原前可预览变更
- **💾 零存储成本** - 分支高效共享数据，压缩率高达 90%
- **🔌 即插即用** - 兼容现有 MongoDB 代码
- **🚀 企业级性能** - 最新优化后，时光查询快 26 倍
- **✅ 全面测试** - 覆盖广泛测试，确保可靠性
- **🗜️ 智能压缩** - 自动 WAL 压缩，节省 80-90% 存储空间

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
## 类似 Git 的 MongoDB 工作流

### 🔄 **步骤 1：导入（数据库的“git clone”）**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **步骤 2：分支（"git checkout -b"）**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **步骤 3：时光旅行（用于数据的 "git log"）**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **步骤 4：恢复（灾难时使用 "git reset"）**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## 工作原理

Argon 拦截 MongoDB 操作并将其记录到**预写日志（WAL）**，从而实现：
- 通过元数据指针实现即时分支
- 通过重放操作实现时光旅行
- 零拷贝高效性

您现有的 MongoDB 代码无需更改 - 只需添加 `ENABLE_WAL=true`。

## 安装


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## 文档

- 📖 [快速入门指南](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [API参考](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [用例](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [架构](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## 社区

- 🤝 [社区指南](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - 欢迎参与！
- 📋 [路线图](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - 了解未来规划
- 🐛 [报告问题](https://github.com/argon-lab/argon/issues)
- 💬 [讨论区](https://github.com/argon-lab/argon/discussions)
- 🏗️ [贡献指南](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - 一起完善 Argon
- 📧 [联系我们](https://www.argonlabs.tech)

---

<div align="center">

**让你的 MongoDB 拥有时光机。再也不会丢失数据。**

⭐ 如果 Argon 拯救了你，请为我们加星！

[开始使用 →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [在线演示 →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---