# Claude Code 斜杠命令

适用于 [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 的生产就绪斜杠命令，通过智能自动化加速开发。

**52 个命令**，组织如下：
- **🤖 工作流程**：多子代理协同处理复杂任务
- **🔧 工具**：针对特定操作的单一功能实用工具

### 🤝 需要 Claude Code 子代理

这些命令与 [Claude Code 子代理](https://github.com/wshobson/agents) 配合使用，提供编排功能。

## 安装

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## 可用命令

- **🤖 工作流** - 协调多个子代理以完成复杂任务
- **🔧 工具** - 用于特定操作的单一功能命令

## 使用方法

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code 会根据上下文自动建议相关命令。

## 🤖 工作流程

复杂任务的多子代理协调：

### 功能开发
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - 后端、前端、测试及部署子代理构建完整功能
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 多个审核子代理提供全面代码分析
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 分析问题并委派给合适的专业子代理

### 开发流程
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - 实施有效的 Git 工作流及分支策略和 PR 模板
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - 通过提示优化提升子代理性能
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 使用专业子代理现代化遗留代码库
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - 利用数据和机器学习工程子代理创建 ML 流水线
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 协调子代理构建跨平台应用
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - 自动化 CI/CD、监控和部署流程

### 子代理协调工作流
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - 多平台功能，包含后端、前端及移动子代理
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 安全优先实现，配备专业子代理
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - 由数据科学子代理驱动的机器学习功能
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - 端到端性能优化，配备性能子代理
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - 生产事故响应，由运维子代理处理

## 🔧 工具（单一功能命令）

### AI 与机器学习
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 构建生产级 AI 助手和聊天机器人
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - 针对 AI/ML 代码库的专业审查
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - 使用现代模式创建 LangChain/LangGraph 代理
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - 使用 MLOps 创建端到端机器学习流水线
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - 优化 AI 提示以提升性能和质量

### 架构与代码质量
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 生成复杂代码的详细解释
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 在语言、框架或版本间迁移代码
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 重构代码以提升可维护性和性能
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 分析并优先处理技术债务

### 数据与数据库
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - 设计可扩展的数据流水线架构
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 实施全面的数据验证系统
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 高级数据库迁移策略

### 运维与基础设施
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - 生成部署配置和检查清单
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 高级容器优化策略
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 生产级 Kubernetes 部署
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 设置全面的监控与可观测性
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - 实施服务级别目标（SLO）
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 自动化开发和运维工作流

### 开发与测试
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 创建真实感 API 模拟用于开发和测试
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 生成生产级 API 端点及完整实现栈
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - 创建带框架检测的综合测试套件

### 安全与合规
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 全面无障碍测试与修复
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 确保法规合规（GDPR、HIPAA、SOC2）
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 全面安全扫描及自动修复

### 调试与分析
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 高级调试与追踪策略
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - 深度错误模式分析与解决方案
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 追踪并诊断生产环境错误
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 创建结构良好的 GitHub/GitLab 问题单

### 依赖与配置
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - 验证和管理应用配置
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - 审核依赖项的安全性和许可
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - 安全升级项目依赖

### 文档与协作
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 生成全面文档
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 实施有效的 Git 工作流
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 通过质量检查增强拉取请求

### 成本优化
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - 优化云和基础设施成本

### 入职与设置
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 为新团队成员设置开发环境

### 子代理工具
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 使用专业子代理进行多视角代码审查
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - 结合调试和性能子代理的深度调试
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 多子代理的全栈优化
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - 使用上下文管理子代理保存项目上下文
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 恢复保存的上下文以保持连续性

## 功能

- 生产级实现
- 框架自动检测
- 安全最佳实践
- 内置监控和测试

- 命令协同工作无缝连接

## 命令总数

**共计：52 个生产就绪的斜杠命令**，组织如下：

### 🤖 工作流（14 个命令）

- 功能开发与评审（3 个命令） 
- 开发流程自动化（6 个命令）
- 子代理协调的工作流（5 个命令）

### 🔧 工具（38 个命令）

- 人工智能与机器学习（5 个命令）
- 架构与代码质量（4 个命令）
- 数据与数据库（3 个命令）
- DevOps 与基础设施（6 个命令）
- 开发与测试（3 个命令）
- 安全与合规（3 个命令）
- 调试与分析（4 个命令）
- 依赖与配置（3 个命令）
- 文档与协作（1 个命令）
- 入职与设置（1 个命令）
- 子代理专用工具（5 个命令）

## 使用示例

### 🤖 工作流示例

```bash
# Implement a complete feature
/feature-development Add user authentication with OAuth2

# Comprehensive code review
/full-review Review the authentication module

# Smart issue resolution
/smart-fix Fix performance degradation in API response times

# Modernize legacy system
/legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/incident-response High CPU usage causing service degradation in production
```

### 🔧 工具示例（单一功能命令）

```bash
# Create a user management API
/api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/error-trace analyze high memory usage in production pods

# Secure container images
/security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/multi-agent-review Review authentication module

# Deep debugging
/smart-debug Investigate memory leak in production workers

# Full-stack optimization
/multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/context-save Save current project state and architectural decisions

# Restore project context
/context-restore Load context from last week's sprint
```

## 增强命令

### 安全与运维

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

全面的安全扫描与自动修复。

- **多工具扫描**：Bandit、Safety、Trivy、Semgrep、ESLint Security、Snyk
- **自动修复**：自动修复常见漏洞
- **CI/CD 集成**：支持 GitHub Actions/GitLab CI 的安全门控
- **容器扫描**：镜像漏洞分析
- **密钥检测**：集成 GitLeaks 和 TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

高级容器优化策略。

- **智能优化**：分析并提出改进建议
- **多阶段构建**：针对框架优化的 Dockerfile
- **现代工具**：BuildKit、Bun、UV 实现更快构建
- **安全加固**：无发行版镜像，非 root 用户
- **跨命令集成**：支持与 /api-scaffold 输出配合使用

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

生产级 Kubernetes 部署。

- **高级模式**：Pod 安全标准、网络策略、OPA
- **GitOps 准备**：FluxCD 和 ArgoCD 配置
- **可观测性**：Prometheus ServiceMonitors、OpenTelemetry
- **自动扩缩容**：HPA、VPA 及集群自动扩缩配置
- **服务网格**：Istio/Linkerd 集成

### 前端与数据

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

高级数据库迁移策略。

- **多数据库支持**：PostgreSQL、MySQL、MongoDB、DynamoDB
- **零停机**：蓝绿部署，滚动迁移
- **事件溯源**：Kafka/Kinesis 集成 CDC
- **跨平台**：支持多语言持久化
- **监控**：迁移健康检查与回滚

## 组合工作流与工具

真正的威力来自于组合工作流和工具，实现完整的开发周期：

### 示例：构建新功能

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/test-harness Add integration tests for WebSocket connections
/security-scan Check for WebSocket vulnerabilities
/docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/full-review Review the entire chat feature implementation
```

### 示例：现代化遗留代码

```bash
# 1. Start with the modernization workflow
/legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/deps-upgrade Update all dependencies to latest versions
/refactor-clean Remove deprecated patterns and dead code
/test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/docker-optimize Create multi-stage production build
/k8s-manifest Deploy with zero-downtime strategy
```

## 命令编排模式

命令可以单独使用，也可以组合成强大的模式：

### 顺序执行
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### 并行分析
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 迭代改进
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```
### 跨域集成

```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## 何时使用工作流与工具

### 🔀 工作流与子代理工具
- **问题解决**：自适应地分析和修复问题
- **多视角**：协调专业子代理
- **复杂任务**：跨领域多步骤流程
- **未知解决方案**：让子代理确定方法

### 🛠️ 专业工具
- **基础设施搭建**：配置环境
- **代码生成**：创建具体实现
- **分析**：生成报告但不修复
- **领域任务**：高度专业化操作

**示例：**
- “实现用户认证系统” → `/feature-development`
- “修复全栈性能问题” → `/smart-fix`
- “现代化遗留单体应用” → `/legacy-modernize`

### 🔧 何时使用工具：
- **需要特定专业知识** - 明确、专注于单一领域任务
- **需要精确控制** - 希望指导具体实现细节
- **作为手动流程一部分** - 集成到现有过程
- **需要深度专业化** - 需要专家级实现
- **基于已有工作构建** - 增强或完善之前的输出

**示例：**
- “创建 Kubernetes 清单” → `/k8s-manifest`
- “扫描安全漏洞” → `/security-scan`
- “生成 API 文档” → `/doc-generate`

## 命令格式

斜杠命令是简单的 Markdown 文件，其中：
- 文件名即为命令名（例如 `api-scaffold.md` → `/api-scaffold`）
- 文件内容为调用时执行的提示/指令
- 使用 `$ARGUMENTS` 占位符表示用户输入

## 最佳实践

### 命令选择
- **让 Claude Code 自动建议** - 分析上下文选择最优命令
- **复杂任务用工作流** - 子代理协调多领域实现
- **专注任务用工具** - 使用具体命令进行针对性改进

### 有效使用
- **提供全面上下文** - 包含技术栈、限制和需求
- **策略性链式调用** - 工作流 → 工具 → 细化
- **基于先前输出构建** - 命令设计为协同工作

## 贡献指南

1. 在 `workflows/` 或 `tools/` 目录下创建 `.md` 文件
2. 使用小写连字符命名
3. 包含用于用户输入的 `$ARGUMENTS`

## 故障排除

**找不到命令**：检查文件是否位于 `~/.claude/commands/`

**工作流运行缓慢**：正常 - 它们协调多个子代理

**输出泛泛**：添加更具体的技术栈上下文

**集成问题**：核实文件路径和命令顺序

## 性能提示

**命令选择：**
- **工作流**：多子代理协调复杂功能
- **工具**：单一目的执行具体任务
- **简单编辑**：保持主代理操作

**优化方法：**
- 先使用工具解决已知问题
- 事先提供详细需求
- 基于先前命令输出构建
- 让工作流完成后再修改

### 添加新工作流：
- 关注子代理的编排和委派逻辑
- 指定使用哪些专业子代理及顺序
- 定义子代理间的协调模式

### 添加新工具：
- 包含完整、可投入生产的实现
- 结构清晰，含明确章节和可操作输出
- 包含示例、最佳实践和集成点

## 了解更多

- [Claude Code 文档](https://docs.anthropic.com/en/docs/claude-code)
- [斜杠命令文档](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [子代理文档](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code 子代理集合](https://github.com/wshobson/agents) - 这些命令使用的专业子代理



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---