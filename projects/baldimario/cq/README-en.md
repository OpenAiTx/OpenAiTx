
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# cq - High-Performance SQL Query Engine for CSV Files

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

A lightweight, fast SQL query processor written in C that enables executing SQL queries directly on CSV files without requiring a database. For full documentation, see the /doc directory.

 ![cq in action](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Documentation

- Getting Started: `doc/GettingStarted.md`
- Installation: `doc/Installation.md`
- Command Line Interface: `doc/CLI.md`
- **TUI (Terminal User Interface)**: `doc/TUI.md`
- Architecture: `doc/Architecture.md`
- Testing: `doc/Testing.md`
- Roadmap: `doc/Roadmap.md`
- Contributing: `doc/Contributing.md`

## Quick Start

Build: `make`

### Command Line

Run a sample query:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Terminal UI

Launch interactive TUI:
`./build/cqtui data/`

Features:
- Browse and open CSV files as tables
- Execute SQL queries interactively
- Multi-tab interface for multiple tables
- Keyboard-driven navigation
- No external dependencies

## Example SQL Files

The repository includes example SQL under assets/ (example_between.sql, example_aggregation.sql, etc.). See assets/ for details.

## Data & Features Overview

- See the /doc folder for detailed sections on data types, date formats, CSV format, and more.

## License

MIT License. See LICENSE file for details.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---