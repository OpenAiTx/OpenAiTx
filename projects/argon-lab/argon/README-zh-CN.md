<translate-content># Argon 🚀

**适用于机器学习/人工智能工作流的类Git MongoDB分支管理**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://golang.org)
[![Python](https://img.shields.io/badge/Python-3.11+-3776AB?logo=python)](https://python.org)
[![MongoDB](https://img.shields.io/badge/MongoDB-7.0+-47A248?logo=mongodb)](https://mongodb.com)

> **🎉 现已推出！** Argon 提供企业级 MongoDB 分支，操作延迟低于500毫秒，具备机器学习原生功能及混合 Go+Python 架构。

## 什么是 Argon？

Argon 是一个 MongoDB 分支系统，提供类似 Git 的数据库操作，针对机器学习/人工智能工作流进行了优化。可视为“MongoDB 版 Neon”，为数据科学团队提供一流支持。

### 主要功能

- **⚡ 即时分支**：无论数据库大小，均可在<500毫秒内创建分支
- **🔄 写时复制**：相比完整复制，存储效率提升90%以上  
- **🧠 机器学习原生**：内置 MLflow、DVC、Weights & Biases 集成
- **🌐 实时**：实时变更流和基于 WebSocket 的仪表盘
- **☁️ 多云支持**：兼容 AWS S3、Google Cloud Storage、Azure Blob
- **🔒 企业级**：身份验证、基于角色的访问控制、审计日志、合规功能

## 架构

Argon 采用混合架构，兼顾性能与开发者生产力：

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   CLI Tool      │    │  Web Dashboard  │    │ ML Integrations │
│   (Go Binary)   │    │   (Next.js)     │    │ (Python APIs)   │
└─────────────────┘    └─────────────────┘    └─────────────────┘
         │                       │                       │
         └───────────────────────┼───────────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Python API     │
                    │  (FastAPI)      │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Go Engine      │
                    │ (Performance)   │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │    MongoDB      │
                    │ + Change Streams│
                    └─────────────────┘
```
<translate-content>
**性能层（Go）**：变更流，分支引擎，CLI，存储  
**生产力层（Python）**：Web API，机器学习集成，管理功能  

## 快速开始  

### 安装  

选择您偏好的安装方式：  

#### 快速安装（从源码）</translate-content>
```bash
# Clone and build latest version
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
sudo mv argon /usr/local/bin/
```
#### Homebrew（macOS/Linux）

```bash
brew install argon-lab/tap/argonctl
```
#### npm（跨平台）

```bash
npm install -g argonctl
```
#### 直接下载

```bash
# Linux (x64)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-linux-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Intel)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Apple Silicon)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-arm64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/
```
#### 来自源头

```bash
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
```
<translate-content>
### 验证安装</translate-content>
```bash
argon --version
# argon version 1.0.0
```
### 开发环境设置（贡献者）


```bash
# Clone the repository
git clone https://github.com/argon-lab/argon.git
cd argon

# Start the development environment
docker compose up -d

# Verify services are running
curl http://localhost:8080/health  # Go engine
curl http://localhost:3000/health  # Python API
```
### 基本用法


```bash
# Verify installation
argon --version

# Get help
argon --help

# Create a new project (requires running services)
argon projects create --name my-ml-project --mongodb-uri mongodb://localhost:27017

# List your projects
argon projects list

# Note: Full functionality requires the Argon services to be running
# See Development Setup below for starting the complete system
```
<translate-content>
## 目前可用功能

✅ **CLI 安装** - 全局安装 `argon` 命令  
✅ **核心架构** - 混合 Go+Python 系统已准备好  
✅ **存储引擎** - 基于 S3 的后端，压缩率达42%  
✅ **本地开发** - 完整的 Docker 环境  

## 即将推出

✅ **Homebrew** - `brew install argon-lab/tap/argonctl`（现已上线！）  
✅ **npm 包** - `npm install -g argonctl`（现已上线！）  
🚧 **托管服务** - 云端 Argon 即时使用  
🚧 **网页仪表盘** - 可视化分支管理  
🚧 **机器学习集成** - MLflow、DVC、Weights & Biases  

## 当前状态

**CLI 和核心系统已达生产准备状态**。包管理器分发版和托管服务正在准备公开发布。

## 性能目标

| 指标 | 目标 | 当前状态 |
|--------|--------|----------------|
| 分支创建 | <500毫秒 | 🟢 已实现 |
| 变更处理 | 每秒10,000+ 操作 | 🟢 已实现 |
| 存储效率 | 40%以上压缩 | 🟢 已达成（42.40%） |
| CLI 启动 | <50毫秒 | 🟢 已达成 |

## 使用场景

### 数据科学团队</translate-content>
```python
# In Jupyter notebook
import argon

# Create experiment branch
argon.branch.create("model-v2-experiment")

# Train model with versioned data
model = train_model(argon.data.get_collection("training_data"))

# Track experiment metadata
argon.experiment.log(model_accuracy=0.95, dataset_version="v2.1")

# Merge successful experiment
argon.branch.merge("model-v2-experiment", "main")
```
### 开发团队

```bash
# Create feature branch with production data copy
argon branch create feature-new-analytics --from production

# Develop and test against real data
# ... make database schema changes ...

# Review changes before merge
argon diff main..feature-new-analytics

# Deploy to production
argon branch merge feature-new-analytics main
```
## 贡献

我们欢迎贡献！这是一个为社区构建的开源项目。

### 开发工作流程

1. **Fork 仓库**
2. **设置开发环境**：`docker-compose up -d`
3. **在相应的服务中进行更改**：
   - 围棋引擎：`services/engine/`
   - Python API：`services/api/`
   - Web 仪表盘：`services/web/`
4. **测试您的更改**：运行测试套件
5. **提交拉取请求**

### 项目结构


```
argon/
├── services/
│   ├── engine/          # Go performance engine
│   ├── api/             # Python FastAPI service
│   └── web/             # Next.js web dashboard
├── docs/                # Documentation
├── examples/            # Example usage and tutorials
├── scripts/             # Development and deployment scripts
└── docker-compose.yml   # Development environment
```
## 路线图

### v1.0（当前）- 生产就绪
- 混合 Go+Python 架构
- 核心分支操作
- MongoDB 变更流
- CLI 和 API 接口
- 带压缩的 S3 存储

### v1.1 - 机器学习集成
- MLflow 连接器
- DVC 集成
- Weights & Biases 支持
- Jupyter 笔记本示例

### v1.2 - 企业功能
- 用户认证和基于角色的访问控制（RBAC）
- 团队协作功能
- 高级分支操作
- 性能优化

### v1.3 - 扩展与完善
- 多区域部署
- 高级分析
- 插件架构
- 企业支持

## 架构深度解析

详细技术文档请参阅：
- [架构概览](https://raw.githubusercontent.com/argon-lab/argon/master/docs/architecture.md)
- [API 文档](https://raw.githubusercontent.com/argon-lab/argon/master/docs/api.md)
- [开发指南](https://raw.githubusercontent.com/argon-lab/argon/master/docs/development.md)
- [部署指南](https://raw.githubusercontent.com/argon-lab/argon/master/docs/deployment.md)

## 社区

- **GitHub 讨论区**：提问和分享想法
- **Discord**：与社区实时聊天（链接即将推出）
- **推特**：关注 [@argondb](https://twitter.com/argondb) 获取更新

## 许可证

本项目采用 MIT 许可证 - 详情请参阅 [LICENSE](LICENSE) 文件。

## 由 MongoDB 工程师打造

Argon 由具备深厚 MongoDB 专业知识的团队打造，利用变更流、高级聚合管道等先进功能，以及从生产部署中总结的性能最佳实践。

---

**⭐ 如果你觉得有用，请为本仓库点赞！**

[![GitHub stars](https://img.shields.io/github/stars/argon-lab/argon?style=social)](https://github.com/argon-lab/argon)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---