# trading-skills

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![CLI](https://img.shields.io/badge/-CLI-000000?logo=linux&logoColor=white)
![Financial Data](https://img.shields.io/badge/-Financial%20Data-4A90E2?logo=data)

> **Comprehensive financial data CLI for Tushare Pro** | **7+ trading skill modules** | **52+ data tools** | **Production-ready**

A professional-grade skill development and training project featuring comprehensive tools for financial data querying, analysis, and trading strategy development. Built with a modular skill architecture, complete CLI implementation, and extensive test coverage.

---

## 📋 Features

- **7 Specialized Skill Modules**: Stock, Futures, Index, Forex, Alpha, Concepts, Financial
- **52+ Data Query Tools**: Full parity with Tushare Pro API coverage
- **Production CLI**: Type-safe command-line client with caching and multiple output formats
- **Comprehensive Testing**: 992+ tests covering CLI, cache, config, and data output
- **Skill-Based Learning**: Modular knowledge base for understanding trading concepts and data
- **Git-Based Configuration**: Configuration management via version control

---

## 📁 Project Structure

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

### 2. Set Up Your Tushare Token

Get your token at [Tushare Pro](https://tushare.pro/user/token)

```bash
# Option 1: Config file (recommended, persists across sessions)
tushare-cli config set-token YOUR_TOKEN

# Option 2: Environment variable
export TUSHARE_TOKEN=YOUR_TOKEN

# Option 3: Command-line flag
tushare-cli --token YOUR_TOKEN stock daily --ts-code 000001.SZ
```

### 3. Set Up Skills in Claude Code (Optional)

If you want to use the trading skills in Claude Code:

```
/plugin marketplace add oopslink/trading-skills
/plugin install trading-skills@trading-skills
```

This will install all 7 trading skill modules, making them available as reference knowledge in Claude Code conversations.

### 4. Try Your First Query

```bash
# Get stock daily data
tushare-cli stock daily --ts-code 000001.SZ

# Get in JSON format
tushare-cli stock daily --ts-code 000001.SZ --format json

# Get with caching enabled
tushare-cli --cache stock daily --ts-code 000001.SZ
```

---

## 📚 API Categories

| Category | Skills | Commands | Data Tools |
|----------|--------|----------|------------|
| **Stock** | tushare-stock | 8+ commands | Daily, Adj, Weekly, Monthly, Quotes |
| **Futures** | tushare-futures | 7+ commands | Daily, Continuous, Margin |
| **Index** | tushare-index | 6+ commands | Daily, Weekly, Constituents |
| **Forex** | tushare-forex | 4+ commands | Daily, OHLC |
| **Alpha** | tushare-alpha | 5+ commands | Factors, Scoring, Backtesting |
| **Concepts** | tushare-concepts | 3+ commands | Concept Stocks, Updates |
| **Financial** | tushare-financial | 6+ commands | Income, Balance, Cashflow, Indicators |

---

## 🛠️ Usage Examples

### Query Stock Data

```bash
# Daily prices for a stock
tushare-cli stock daily --ts-code 000001.SZ --start-date 20240101

# Weekly prices
tushare-cli stock weekly --ts-code 000001.SZ

# Stock quotes (real-time equivalent)
tushare-cli stock quotes --ts-code 000001.SZ
```

### Query Futures Data

```bash
# Futures daily data
tushare-cli futures daily --ts-code IF --trade-date 20240115

# Continuous contract data
tushare-cli futures continuous --ts-code IF --start-date 20240101
```

### Query Index Data

```bash
# Index daily data
tushare-cli index daily --ts-code 000001.SH

# Index constituents
tushare-cli index constituents --ts-code 000001.SH
```

### Output Formats

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

The project includes **992+ tests** covering:
- CLI command execution
- API caching behavior
- Configuration management
- Output formatting
- Error handling

---

## 📖 Skills Documentation

Each trading skill is documented in detail:

- **[tushare-stock](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-stock/SKILL.md)** - Stock trading fundamentals
- **[tushare-futures](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-futures/SKILL.md)** - Futures markets & strategies
- **[tushare-index](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-index/SKILL.md)** - Index analysis
- **[tushare-forex](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-forex/SKILL.md)** - Foreign exchange
- **[tushare-alpha](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-alpha/SKILL.md)** - Alpha generation
- **[tushare-concepts](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-concepts/SKILL.md)** - Trading concepts
- **[tushare-financial](https://raw.githubusercontent.com/oopslink/trading-skills/main/skills/tushare-financial/SKILL.md)** - Financial statements

---

## 🔧 Configuration

### Setting Configuration

```bash
# Set Tushare token
tushare-cli config set-token YOUR_TOKEN

# View current configuration
tushare-cli config show

# Reset to defaults
tushare-cli config reset
```

### Environment Variables

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
- Reduces API calls and costs
- Improves query performance
- Respects rate limits

---

## � Claude Code Integration

### Using as a Plugin

This project is designed to work seamlessly with Claude Code as a complete trading skills plugin suite:

```bash
# Step 1: Add the plugin marketplace entry
/plugin marketplace add oopslink/trading-skills

# Step 2: Install the plugin with all skill modules
/plugin install trading-skills@trading-skills
```

**What this installs:**
- All 7 trading skill modules (stock, futures, index, forex, alpha, concepts, financial)
- Full knowledge base for trading concepts and Tushare API
- Reference documentation for each data category
- Integration with Claude Code's skill system

### Using Skills in Claude Code

Once installed, you can reference any skill in your Claude Code conversations:

```
@skill tushare-stock     # Stock trading concepts and techniques
@skill tushare-futures   # Futures market knowledge
@skill tushare-index     # Index data and analysis
@skill tushare-forex     # Foreign exchange trading
@skill tushare-alpha     # Alpha factor generation
@skill tushare-concepts  # Financial and trading terminology
@skill tushare-financial # Financial statement analysis
```

### Local Development Setup

For local development or if not using the marketplace:

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

## �📋 Design & Planning

- [Tushare CLI Design](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-design.md) - Architecture and API design
- [Tushare CLI Implementation](https://raw.githubusercontent.com/oopslink/trading-skills/main/docs/plans/2026-03-03-tushare-cli-impl.md) - Implementation details

---

## 📝 License

MIT License - see [LICENSE](LICENSE) file for details

---

## 🤝 Contributing

Contributions are welcome! Please note:

- All new trading skills must follow the [SKILL.md format](https://raw.githubusercontent.com/oopslink/trading-skills/main/CLAUDE.md)
- Add tests for new commands
- Update documentation as needed
- Follow the project structure conventions

---

## 📞 Support

- 📖 Check the skill documentation for learning about trading concepts
- 🐛 Report issues in the issue tracker
- 💬 Discuss ideas in discussions

---

**Built with ❤️ for financial data enthusiasts and traders**
