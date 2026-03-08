# cq - 面向CSV文件的高性能SQL查询引擎

 [![跨平台构建和测试（使用zig构建系统）](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

一个用C语言编写的轻量级、快速的SQL查询处理器，支持直接对CSV文件执行SQL查询，无需数据库。完整文档请参见 /doc 目录。

 ![cq 实际运行图](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## 文档

- 入门指南：`doc/GettingStarted.md`
- 安装说明：`doc/Installation.md`
- 命令行界面：`doc/CLI.md`
- **TUI（终端用户界面）**：`doc/TUI.md`
- 架构设计：`doc/Architecture.md`
- 测试说明：`doc/Testing.md`
- 路线图：`doc/Roadmap.md`
- 贡献指南：`doc/Contributing.md`

## 快速开始

构建：`make`

### 命令行

运行示例查询：
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### 终端界面

启动交互式TUI：
`./build/cqtui data/`

功能特点：
- 浏览并打开CSV文件作为表格
- 交互式执行SQL查询
- 多标签界面支持多表操作
- 键盘驱动的导航
- 无需外部依赖

## 示例 SQL 文件

仓库中包含位于 assets/ 下的示例 SQL（example_between.sql、example_aggregation.sql 等）。详情请参见 assets/。

## 数据与特征概览

- 详见 /doc 文件夹中关于数据类型、日期格式、CSV 格式等的详细章节。

## 许可证

MIT 许可证。详情请参见 LICENSE 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---