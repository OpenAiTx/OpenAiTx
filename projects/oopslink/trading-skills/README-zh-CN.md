# trading-skills

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![CLI](https://img.shields.io/badge/-CLI-000000?logo=linux&logoColor=white)
![Financial Data](https://img.shields.io/badge/-Financial%20Data-4A90E2?logo=data)

> **Tushare Pro 的综合金融数据命令行工具** | **7+ 交易技能模块** | **52+ 数据工具** | **生产就绪**

一个专业级的技能开发和培训项目，提供全面的金融数据查询、分析和交易策略开发工具。采用模块化技能架构，完整的命令行实现以及广泛的测试覆盖。

---

## 📋 功能特性

- **7 个专业技能模块**：股票、期货、指数、外汇、Alpha、概念、财务
- **52+ 数据查询工具**：全面覆盖 Tushare Pro API
- **生产级命令行工具**：类型安全的命令行客户端，支持缓存和多种输出格式
- **全面测试**：覆盖 CLI、缓存、配置和数据输出的 992+ 测试
- **基于技能的学习**：模块化知识库，帮助理解交易概念和数据
- **基于 Git 的配置管理**：通过版本控制进行配置管理

---

## 📁 项目结构

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

### 2. 设置你的Tushare令牌

在[Tushare Pro](https://tushare.pro/user/token)获取你的令牌

```bash
# Option 1: Config file (recommended, persists across sessions)
tushare-cli config set-token YOUR_TOKEN

# Option 2: Environment variable
export TUSHARE_TOKEN=YOUR_TOKEN

# Option 3: Command-line flag
tushare-cli --token YOUR_TOKEN stock daily --ts-code 000001.SZ
```

### 3. 在 Claude Code 中设置技能（可选）

如果您想在 Claude Code 中使用交易技能：

```
/plugin marketplace add oopslink/trading-skills
/plugin install trading-skills@trading-skills
```
这将安装所有7个交易技能模块，使它们作为参考知识在Claude Code对话中可用。

### 4. 尝试你的第一个查询


```bash
# Get stock daily data
tushare-cli stock daily --ts-code 000001.SZ

# Get in JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# Get with caching enabled
tushare-cli --cache stock daily --ts-code 000001.SZ
```

---

## 📚 API 分类

| 分类 | 技能 | 命令 | 数据工具 |
|----------|--------|----------|------------|
| **股票** | tushare-stock | 8+ 命令 | 日线，复权，周线，月线，行情 |
| **期货** | tushare-futures | 7+ 命令 | 日线，连续，保证金 |
| **指数** | tushare-index | 6+ 命令 | 日线，周线，成分股 |
| **外汇** | tushare-forex | 4+ 命令 | 日线，开高低收 |
| **Alpha** | tushare-alpha | 5+ 命令 | 因子，评分，回测 |
| **概念** | tushare-concepts | 3+ 命令 | 概念股，更新 |
| **财务** | tushare-financial | 6+ 命令 | 利润表，资产负债表，现金流，指标 |

---

## 🛠️ 使用示例

### 查询股票数据

```bash
# Daily prices for a stock
tushare-cli stock daily --ts-code 000001.SZ --start-date 20240101

# Weekly prices
tushare-cli stock weekly --ts-code 000001.SZ

# Stock quotes (real-time equivalent)
tushare-cli stock quotes --ts-code 000001.SZ
```

### 查询期货数据

```bash
# Futures daily data
tushare-cli futures daily --ts-code IF --trade-date 20240115

# Continuous contract data
tushare-cli futures continuous --ts-code IF --start-date 20240101
```

### 查询索引数据

```bash
# Index daily data
tushare-cli index daily --ts-code 000001.SH

# Index constituents
tushare-cli index constituents --ts-code 000001.SH
```

### 输出格式

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
项目包含 **992+ 测试**，涵盖：
- CLI 命令执行
- API 缓存行为
- 配置管理
- 输出格式化
- 错误处理

---

## 📖 技能文档

每个交易技能都有详细文档：

- **[tushare-stock](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-stock/SKILL.md)** - 股票交易基础
- **[tushare-futures](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-futures/SKILL.md)** - 期货市场与策略
- **[tushare-index](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-index/SKILL.md)** - 指数分析
- **[tushare-forex](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-forex/SKILL.md)** - 外汇
- **[tushare-alpha](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-alpha/SKILL.md)** - 阿尔法生成
- **[tushare-concepts](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-concepts/SKILL.md)** - 交易概念
- **[tushare-financial](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-financial/SKILL.md)** - 财务报表

---

## 🔧 配置

### 设置配置


```bash
# Set Tushare token
tushare-cli config set-token YOUR_TOKEN

# View current configuration
tushare-cli config show

# Reset to defaults
tushare-cli config reset
```

### 环境变量

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
- 减少 API 调用次数和成本
- 提高查询性能
- 遵守速率限制

---

## � Claude 代码集成

### 作为插件使用

该项目设计为与 Claude 代码无缝协作，作为完整的交易技能插件套件：

```bash
# Step 1: Add the plugin marketplace entry
/plugin marketplace add oopslink/trading-skills

# Step 2: Install the plugin with all skill modules
/plugin install trading-skills@trading-skills
```

**安装内容包括：**
- 所有7个交易技能模块（股票、期货、指数、外汇、Alpha、概念、金融）
- 完整的交易概念和Tushare API知识库
- 各数据类别的参考文档
- 与Claude Code技能系统的集成

### 在Claude Code中使用技能

安装完成后，您可以在Claude Code对话中引用任何技能：

```
@skill tushare-stock     # Stock trading concepts and techniques
@skill tushare-futures   # Futures market knowledge
@skill tushare-index     # Index data and analysis
@skill tushare-forex     # Foreign exchange trading
@skill tushare-alpha     # Alpha factor generation
@skill tushare-concepts  # Financial and trading terminology
@skill tushare-financial # Financial statement analysis
```

### 本地开发环境设置

用于本地开发或不使用市场的情况：

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

## 📋 设计与规划

- [Tushare CLI 设计](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-design.md) - 架构和 API 设计
- [Tushare CLI 实现](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-impl.md) - 实现细节

---

## 📝 许可

MIT 许可 - 详情见 [LICENSE](LICENSE) 文件

---

## 🤝 贡献

欢迎贡献！请注意：

- 所有新交易技能必须遵循 [SKILL.md 格式](https://raw.githubusercontent.com/oopslink/trading-skills/main/CLAUDE.md)
- 为新命令添加测试
- 根据需要更新文档
- 遵守项目结构规范

---

## 📞 支持

- 📖 查看技能文档，了解交易概念
- 🐛 在问题追踪器中报告问题
- 💬 在讨论区交流想法

---

**为金融数据爱好者和交易者倾心打造 ❤️**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---