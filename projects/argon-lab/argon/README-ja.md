<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# Argon - MongoDB タイムマシン 🚀

[![Build Status](https://github.com/argon-lab/argon/actions/workflows/ci.yml/badge.svg)](https://github.com/argon-lab/argon/actions/workflows/ci.yml)
[![Go Report](https://goreportcard.com/badge/github.com/argon-lab/argon)](https://goreportcard.com/report/github.com/argon-lab/argon)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Homebrew](https://img.shields.io/badge/Homebrew-argonctl-orange?logo=homebrew)](https://github.com/argon-lab/homebrew-tap)
[![npm](https://img.shields.io/npm/v/argonctl?logo=npm&label=npm)](https://www.npmjs.com/package/argonctl)
[![PyPI](https://img.shields.io/pypi/v/argon-mongodb?logo=pypi&label=PyPI)](https://pypi.org/project/argon-mongodb/)

**MongoDBデータベースで時空を旅しよう。ブランチ作成、リストア、そして安心して実験できます。**

## Argonとは？

ArgonはMongoDBに**Gitのようなブランチ機能**と**タイムトラベル機能**というスーパーパワーを付与します。瞬時にデータベースのブランチを作成し、あらゆる過去の時点にリストアし、データを失う心配がなくなります。

### 🎯 主な利点

- **⚡ 即時ブランチ** - データベース全体を1msでクローン（従来は数時間）
- **⏰ タイムトラベル** - **1秒あたり22万件超**のクエリで任意の時点のデータを取得
- **🔄 安全なリストア** - リストア前に変更内容をプレビュー可能
- **💾 ゼロストレージコスト** - ブランチ間でデータを効率的に共有し、90%圧縮
- **🔌 既存コードにそのまま対応** - 既存のMongoDBコードでそのまま動作
- **🚀 エンタープライズ性能** - 最新の最適化でタイムトラベルクエリが26倍高速化
- **✅ 徹底したテスト** - 信頼性を担保する広範なテストカバレッジ
- **🗜️ スマート圧縮** - 自動WAL圧縮によりストレージを80～90%削減

## クイックデモ

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
## MongoDBのためのGitライクなワークフロー

### 🔄 **ステップ1: インポート（データベースの「git clone」）**

```bash
# Bring your existing MongoDB into Argon
argon import preview --uri "mongodb://localhost:27017" --database myapp
argon import database --uri "mongodb://localhost:27017" --database myapp --project myapp
# ✅ Your existing data now has time travel capabilities!
```
### 🧪 **ステップ 2: ブランチ（"git checkout -b"）**

```bash
# Create branches for testing, staging, experiments
argon branches create staging --project myapp
argon branches create experiment-v2 --project myapp
# Full database copies created instantly 🚀
```
### 📊 **ステップ3: タイムトラベル（データの "git log"）**

```bash
# See your data's history
argon time-travel info --project myapp --branch main
argon time-travel query --project myapp --branch main --lsn 1000
# Compare data across time like Git commits
```
### 🚨 **ステップ4: 復元（災害時の "git reset"）**

```bash
# "Someone deleted all users!"
argon restore reset --time "5 minutes ago"
# Crisis averted in seconds, not hours
```
## 仕組み

ArgonはMongoDBの操作をインターセプトし、**Write-Ahead Log（WAL）**に記録します。これにより以下が可能になります：
- メタデータポインタによる即時ブランチ作成
- 操作のリプレイによるタイムトラベル
- ゼロコピーの効率性

既存のMongoDBコードは変更不要で動作します - ただ `ENABLE_WAL=true` を追加するだけです。

## インストール


```bash
# CLI
brew install argon-lab/tap/argonctl    # macOS
npm install -g argonctl                 # Node.js
pip install argon-mongodb               # Python SDK

# From Source
git clone https://github.com/argon-lab/argon
cd argon/cli && go build -o argon
```
## ドキュメント

- 📖 [クイックスタートガイド](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/QUICK_START.md)
- 🛠️ [APIリファレンス](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/API_REFERENCE.md)
- 💡 [ユースケース](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/USE_CASES.md)
- 🏗️ [アーキテクチャ](https://raw.githubusercontent.com/argon-lab/argon/master/./docs/ARCHITECTURE.md)

## コミュニティ

- 🤝 [コミュニティガイド](https://raw.githubusercontent.com/argon-lab/argon/master/./COMMUNITY.md) - 参加しよう！
- 📋 [ロードマップ](https://raw.githubusercontent.com/argon-lab/argon/master/./ROADMAP.md) - 今後の予定を見る
- 🐛 [問題を報告](https://github.com/argon-lab/argon/issues)
- 💬 [ディスカッション](https://github.com/argon-lab/argon/discussions)
- 🏗️ [コントリビュート](https://raw.githubusercontent.com/argon-lab/argon/master/./CONTRIBUTING.md) - Argonの開発に参加
- 📧 [お問い合わせ](https://www.argonlabs.tech)

---

<div align="center">

**MongoDBにタイムマシンを。もうデータを失わない。**

⭐ **Argonが役立ったらスターを付けてください！**

[始める →](https://raw.githubusercontent.com/argon-lab/argon/master/docs/QUICK_START.md) | [ライブデモ →](https://console.argonlabs.tech)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---