
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - 针对 CSV 文件的高性能 SQL 查询引擎

 [![跨平台构建与测试（使用 zig 构建系统）](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

一个用 C 语言编写的轻量级、高速 SQL 查询处理器，可以让你无需数据库，直接对 CSV 文件执行 SQL 查询。完整文档请参阅 /doc 目录。

 ![cq 演示](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## 文档

- 入门指南: `doc/GettingStarted.md`
- 安装说明: `doc/Installation.md`
- 命令行界面: `doc/CLI.md`
- **TUI（终端用户界面）**: `doc/TUI.md`
- 架构: `doc/Architecture.md`
- 测试: `doc/Testing.md`
- 路线图: `doc/Roadmap.md`
- 贡献指南: `doc/Contributing.md`

## 快速开始

构建：`make`

### 命令行

运行示例查询：
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### 终端 UI

启动交互式 TUI：
`./build/cqtui data/`

功能：
- 浏览并以表格形式打开 CSV 文件
- 交互式执行 SQL 查询
- 多标签界面支持多表操作
- 键盘驱动导航
- 无需外部依赖

## 示例 SQL 文件

仓库在 assets/ 下包含示例 SQL（example_between.sql、example_aggregation.sql 等）。详情见 assets/。

## 数据与功能概览

- 有关数据类型、日期格式、CSV 格式等详细内容，请参见 /doc 文件夹。

## 许可证

MIT 许可。详情请参见 LICENSE 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---