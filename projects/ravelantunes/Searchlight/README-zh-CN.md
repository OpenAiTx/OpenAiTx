# Searchlight - Postgres MacOS 客户端

![Searchlight 截图](https://raw.githubusercontent.com/ravelantunes/Searchlight/main/./docs/screenshot1.png)

Searchlight 是一款原生 macOS 开源 PostgreSQL 客户端，设计简洁、轻量且对开发者友好。它提供了一个干净直观的界面，用于管理数据库和执行查询，无需使用复杂的全功能数据库管理工具。Searchlight 致力于为需要快速便捷访问 PostgreSQL 数据库的开发者提供流畅高效的体验。

## 安装

从[发布页面](https://github.com/ravelantunes/Searchlight/releases)下载最新版本。

> 我使用的是个人 Apple 开发者账号，因此无法通过 Apple 进行应用公证。如果你尝试从 GitHub 发布页面安装，MacOS 会提示无法验证开发者身份，你需要在“设置 > 隐私”中批准安装，或者从源码构建。

## 当前功能

### 连接管理

- 保存和管理收藏连接
- 支持基于密钥认证的 SSH 隧道
- 支持 SSL/TLS 连接

### 数据库浏览器

- 浏览数据库、模式和表
- 对表数据进行快速搜索和过滤
- 外键关系链接 — 点击跳转到相关记录
- 列统计弹出框 — 查看唯一值、空值数量和数值分布图表

### 数据操作

- 直接在表中插入新行
- 复制单元格值、行、列（支持多种格式）
- 插入数据时支持外键引用的自动补全/数据查找
- 导出格式：纯文本、CSV、SQL INSERT 语句

### 查询编辑器

- 自由格式 SQL 查询执行
- SQL LSP 支持自动补全、诊断和悬停文档

## 从源码构建
1. 克隆仓库  
2. 在 Xcode 中打开 `Searchlight.xcodeproj`  
3. 构建两次（⌘B，⌘B）——第一次构建会下载依赖，第二次构建会将依赖包含进去  
4. 运行（⌘R）  

第一次构建会自动下载 [Postgres Language Server](https://github.com/supabase-community/postgres-language-server) 二进制文件（约16MB），用于 SQL 自动补全、语法检查和悬停文档。需要第二次构建将其打包进应用。  

> **注意：** LSP 二进制文件仅支持 Apple Silicon（arm64）。  

## 技术栈  

- **Swift & SwiftUI** — 原生 macOS 应用，结合 AppKit 实现高级表格视图  
- **PostgresKit / PostgresNIO** — 带连接池的 PostgreSQL 驱动  
- **SwiftNIO** — 异步网络基础  
- **系统 SSH** — 使用 macOS 系统工具的原生 SSH 隧道支持  
- **Postgres Language Server** — SQL 智能功能（自动补全、诊断、悬停文档）  

## 贡献  

欢迎贡献！欢迎提出问题或提交拉取请求。  

## 许可  

详见 [LICENSE](LICENSE)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---