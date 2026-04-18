# trading-skills

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![CLI](https://img.shields.io/badge/-CLI-000000?logo=linux&logoColor=white)
![Financial Data](https://img.shields.io/badge/-Financial%20Data-4A90E2?logo=data)

> **Tushare Proのための包括的な金融データCLI** | **7つ以上のトレーディングスキルモジュール** | **52以上のデータツール** | **本番対応済み**

金融データの問い合わせ、分析、トレーディング戦略開発のための包括的なツールを備えたプロフェッショナルグレードのスキル開発・トレーニングプロジェクト。モジュラー型スキルアーキテクチャ、完全なCLI実装、広範なテストカバレッジを特徴としています。

---

## 📋 特徴

- **7つの専門スキルモジュール**：株式、先物、指数、外国為替、アルファ、コンセプト、ファイナンス
- **52以上のデータクエリツール**：Tushare Pro APIを完全に網羅
- **本番対応CLI**：型安全なコマンドラインクライアント、キャッシュ機能、多様な出力形式対応
- **包括的なテスト**：CLI、キャッシュ、設定、データ出力を網羅した992以上のテスト
- **スキルベース学習**：トレーディング概念やデータ理解のためのモジュラー知識ベース
- **Gitベースの設定管理**：バージョン管理による設定管理

---

## 📁 プロジェクト構成

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

### 2. Tushareトークンの設定

トークンは[Tushare Pro](https://tushare.pro/user/token)で取得してください。

```bash
# Option 1: Config file (recommended, persists across sessions)
tushare-cli config set-token YOUR_TOKEN

# Option 2: Environment variable
export TUSHARE_TOKEN=YOUR_TOKEN

# Option 3: Command-line flag
tushare-cli --token YOUR_TOKEN stock daily --ts-code 000001.SZ
```

### 3. Claude Codeでスキルを設定する（オプション）

Claude Codeで取引スキルを使用したい場合：

```
/plugin marketplace add oopslink/trading-skills
/plugin install trading-skills@trading-skills
```

これにより、7つのすべての取引スキルモジュールがインストールされ、Claude Codeの会話で参照知識として利用可能になります。

### 4. 最初のクエリを試す

```bash
# Get stock daily data
tushare-cli stock daily --ts-code 000001.SZ

# Get in JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# Get with caching enabled
tushare-cli --cache stock daily --ts-code 000001.SZ
```

---

## 📚 APIカテゴリ

| カテゴリ | スキル | コマンド | データツール |
|----------|--------|----------|--------------|
| **株式** | tushare-stock | 8以上のコマンド | 日次、調整後、週次、月次、株価 |
| **先物** | tushare-futures | 7以上のコマンド | 日次、連続、証拠金 |
| **指数** | tushare-index | 6以上のコマンド | 日次、週次、構成銘柄 |
| **為替** | tushare-forex | 4以上のコマンド | 日次、OHLC |
| **アルファ** | tushare-alpha | 5以上のコマンド | ファクター、スコアリング、バックテスト |
| **コンセプト** | tushare-concepts | 3以上のコマンド | コンセプト株、更新情報 |
| **財務** | tushare-financial | 6以上のコマンド | 損益、バランスシート、キャッシュフロー、指標 |

---

## 🛠️ 使用例

### 株式データの照会

```bash
# Daily prices for a stock
tushare-cli stock daily --ts-code 000001.SZ --start-date 20240101

# Weekly prices
tushare-cli stock weekly --ts-code 000001.SZ

# Stock quotes (real-time equivalent)
tushare-cli stock quotes --ts-code 000001.SZ
```

### クエリ先物データ

```bash
# Futures daily data
tushare-cli futures daily --ts-code IF --trade-date 20240115

# Continuous contract data
tushare-cli futures continuous --ts-code IF --start-date 20240101
```

### クエリインデックスデータ

```bash
# Index daily data
tushare-cli index daily --ts-code 000001.SH

# Index constituents
tushare-cli index constituents --ts-code 000001.SH
```

### 出力形式

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
プロジェクトには**992以上のテスト**が含まれており、以下をカバーしています:
- CLIコマンドの実行
- APIのキャッシュ動作
- 設定管理
- 出力フォーマット
- エラー処理

---

## 📖 スキルドキュメント

各トレーディングスキルは詳細にドキュメント化されています:

- **[tushare-stock](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-stock/SKILL.md)** - 株式取引の基礎
- **[tushare-futures](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-futures/SKILL.md)** - 先物市場と戦略
- **[tushare-index](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-index/SKILL.md)** - インデックス分析
- **[tushare-forex](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-forex/SKILL.md)** - 外国為替
- **[tushare-alpha](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-alpha/SKILL.md)** - アルファ生成
- **[tushare-concepts](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-concepts/SKILL.md)** - 取引の概念
- **[tushare-financial](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-financial/SKILL.md)** - 財務諸表

---

## 🔧 設定

### 設定の構成


```bash
# Set Tushare token
tushare-cli config set-token YOUR_TOKEN

# View current configuration
tushare-cli config show

# Reset to defaults
tushare-cli config reset
```

### 環境変数

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

利点:
- APIコールとコストを削減
- クエリのパフォーマンスを向上
- レート制限を尊重

---

## � Claude Code 統合

### プラグインとしての使用

このプロジェクトは、Claude Codeとシームレスに連携し、完全な取引スキルプラグインスイートとして機能するように設計されています:

```bash
# Step 1: Add the plugin marketplace entry
/plugin marketplace add oopslink/trading-skills

# Step 2: Install the plugin with all skill modules
/plugin install trading-skills@trading-skills
```

**インストールされるもの：**
- 7つのトレーディングスキルモジュールすべて（株式、先物、指数、外国為替、アルファ、コンセプト、ファイナンシャル）
- トレーディングコンセプトとTushare APIの完全なナレッジベース
- 各データカテゴリのリファレンスドキュメント
- Claude Codeのスキルシステムとの統合

### Claude Codeでのスキルの使用

インストール後、Claude Codeの会話で任意のスキルを参照できます：

```
@skill tushare-stock     # Stock trading concepts and techniques
@skill tushare-futures   # Futures market knowledge
@skill tushare-index     # Index data and analysis
@skill tushare-forex     # Foreign exchange trading
@skill tushare-alpha     # Alpha factor generation
@skill tushare-concepts  # Financial and trading terminology
@skill tushare-financial # Financial statement analysis
```

### ローカル開発セットアップ

ローカル開発用、またはマーケットプレイスを使用しない場合:

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

## �📋 設計と計画

- [Tushare CLI設計](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-design.md) - アーキテクチャとAPI設計
- [Tushare CLI実装](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-impl.md) - 実装の詳細

---

## 📝 ライセンス

MITライセンス - 詳細は[LICENSE](LICENSE)ファイルを参照してください

---

## 🤝 貢献について

貢献は歓迎します！以下に注意してください：

- すべての新しいトレーディングスキルは[SKILL.mdフォーマット](https://raw.githubusercontent.com/oopslink/trading-skills/main/CLAUDE.md)に従うこと
- 新しいコマンドのテストを追加すること
- 必要に応じてドキュメントを更新すること
- プロジェクト構造の規約に従うこと

---

## 📞 サポート

- 📖 スキルドキュメントでトレーディングの概念を学ぶ
- 🐛 問題はイシュートラッカーに報告する
- 💬 アイデアはディスカッションで議論する

---

**金融データ愛好家とトレーダーのために❤️で作られました**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---