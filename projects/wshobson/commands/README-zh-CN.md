<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Claude Code 斜杠命令

适用于 [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 的生产级斜杠命令，通过智能自动化加速开发。

**52 个命令**，组织如下：
- **🤖 工作流**：多子代理编排，适用于复杂任务
- **🔧 工具**：专用实用工具，完成特定操作


### 🤝 需要 Claude Code 子代理

这些命令可与 [Claude Code 子代理](https://github.com/wshobson/agents) 配合使用，以实现编排能力。

## 安装

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## 可用命令

- **🤖 工作流** - 编排多个子代理以完成复杂任务
- **🔧 工具** - 用于特定操作的单一功能命令

## 使用方法

命令按目录分为 `tools/` 和 `workflows/`，使用时需加上目录前缀：

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**注意：**如果您希望使用无前缀的命令，可以将目录结构展平成一层：
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code 会根据上下文自动推荐相关命令。

## 🤖 工作流

复杂任务的多子代理编排：

### 功能开发
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - 后端、前端、测试和部署子代理协作构建完整功能
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 多个评审子代理提供全面代码分析
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 分析问题并分配给合适的专业子代理

### 开发流程
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - 采用有效的 Git 工作流、分支策略和 PR 模板
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - 通过优化提示提升子代理性能
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 使用专业子代理现代化遗留代码库
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - 数据与机器学习工程子代理协作创建 ML 流程
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 协同子代理构建跨平台应用
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - 自动化 CI/CD、监控与部署工作流

### 子代理编排工作流
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - 后端、前端与移动子代理协作的多平台功能
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 安全优先实现，采用专业子代理
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - 数据科学子代理打造 ML 驱动功能
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - 性能子代理协作实现端到端优化
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - 运维子代理协助解决生产事故

## 🔧 工具（单一用途命令）

### AI 与机器学习
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 构建可投产的 AI 助手与聊天机器人
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML 代码库的专业审查
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - 采用现代模式创建 LangChain/LangGraph 代理
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - 利用 MLOps 创建端到端 ML 流程
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - 优化 AI 提示词以提升性能与质量

### 架构与代码质量
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 生成复杂代码的详细解释
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 在语言、框架或版本间迁移代码
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 重构代码以提升可维护性和性能

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 分析并优先处理技术债务

### 数据与数据库
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - 设计可扩展的数据管道架构
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 实现全面的数据验证系统
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 高级数据库迁移策略

### DevOps 与基础设施
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - 生成部署配置和检查清单
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 高级容器优化策略
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 生产级 Kubernetes 部署
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 搭建全面的监控与可观测性
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - 实现服务级别目标（SLOs）
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 自动化开发与运维流程

### 开发与测试
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 创建用于开发与测试的逼真 API 模拟
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 生成具备完整实现栈的生产级 API 端点
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - 创建全面的测试套件并自动检测框架

### 安全与合规
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 全面的无障碍测试与修复
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 确保合规（GDPR、HIPAA、SOC2）
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 全面的安全扫描及自动修复

### 调试与分析
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 高级调试与追踪策略
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - 深度错误模式分析与解决策略
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 追踪并诊断生产环境错误
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 创建结构化的 GitHub/GitLab 问题

### 依赖与配置
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - 验证和管理应用配置
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - 审计依赖的安全与许可证
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - 安全升级项目依赖

### 文档与协作
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 生成全面文档
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 实现高效的 Git 工作流
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 使用质量检查优化拉取请求

### 成本优化
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - 优化云和基础设施成本

### 入职与环境配置
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 为新团队成员配置开发环境

### 子代理工具
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 使用专业子代理进行多角度代码评审
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - 使用调试器和性能子代理进行深度调试
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 多子代理实现全栈优化
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - 使用上下文管理子代理保存项目上下文
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 恢复已保存的上下文以保持连续性

## 功能特性

- 可用于生产环境的实现
- 框架自动检测
- 安全最佳实践
- 内置监控与测试
- 命令无缝协作

## 命令数量

**总计：52 条可用于生产环境的斜杠命令**，按以下分类：

### 🤖 工作流（14 条命令）

- 功能开发与评审（3 条命令）
- 开发流程自动化（6 条命令）
- 子代理编排的工作流（5 条命令）

### 🔧 工具（38 条命令）

- AI 与机器学习（5 条命令）
- 架构与代码质量（4 条命令）
- 数据与数据库（3 条命令）
- DevOps 与基础设施（6 条命令）
- 开发与测试（3 条命令）
- 安全与合规（3 条命令）
- 调试与分析（4条命令）
- 依赖与配置（3条命令）
- 文档与协作（1条命令）
- 入职与设置（1条命令）
- 子代理专用工具（5条命令）

## 使用示例

### 🤖 工作流程示例

```bash
# Implement a complete feature
/workflows:feature-development Add user authentication with OAuth2

# Comprehensive code review
/workflows:full-review Review the authentication module

# Smart issue resolution
/workflows:smart-fix Fix performance degradation in API response times

# Modernize legacy system
/workflows:legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/workflows:full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/workflows:security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/workflows:data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/workflows:performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/workflows:incident-response High CPU usage causing service degradation in production
```

### 🔧 工具示例（单一功能命令）

```bash
# Create a user management API
/tools:api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/tools:multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/tools:prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/tools:data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/tools:error-trace analyze high memory usage in production pods

# Secure container images
/tools:security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/tools:doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/tools:onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/tools:multi-agent-review Review authentication module

# Deep debugging
/tools:smart-debug Investigate memory leak in production workers

# Full-stack optimization
/tools:multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/tools:context-save Save current project state and architectural decisions

# Restore project context
/tools:context-restore Load context from last week's sprint
```

## 增强命令

### 安全与DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

全面安全扫描与自动修复。

- **多工具扫描**：Bandit、Safety、Trivy、Semgrep、ESLint Security、Snyk
- **自动修复**：常见漏洞自动修复
- **CI/CD集成**：GitHub Actions/GitLab CI安全门控
- **容器扫描**：镜像漏洞分析
- **密钥检测**：集成GitLeaks和TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

高级容器优化策略。

- **智能优化**：分析并建议改进方案
- **多阶段构建**：针对框架优化Dockerfile
- **现代工具**：BuildKit、Bun、UV加速构建
- **安全加固**：无操作系统镜像、非root用户
- **跨命令集成**：可与/api-scaffold结果协作

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

生产级Kubernetes部署。

- **高级模式**：Pod安全标准、网络策略、OPA
- **GitOps就绪**：FluxCD与ArgoCD配置
- **可观测性**：Prometheus ServiceMonitors、OpenTelemetry
- **自动扩缩容**：HPA、VPA及集群自动扩容配置
- **服务网格**：集成Istio/Linkerd

### 前端与数据

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

高级数据库迁移策略。

- **多数据库支持**：PostgreSQL、MySQL、MongoDB、DynamoDB
- **零停机时间**：蓝绿部署、滚动迁移
- **事件溯源**：Kafka/Kinesis 集成用于 CDC
- **跨平台**：支持多语言持久化
- **监控**：迁移健康检查与回滚

## 工作流与工具的结合

真正的优势在于将工作流与工具结合，实现完整的开发周期：

### 示例：构建新功能

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/workflows:feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/tools:test-harness Add integration tests for WebSocket connections
/tools:security-scan Check for WebSocket vulnerabilities
/tools:docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/workflows:full-review Review the entire chat feature implementation
```

### 示例：现代化遗留代码

```bash
# 1. Start with the modernization workflow
/workflows:legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/tools:deps-upgrade Update all dependencies to latest versions
/tools:refactor-clean Remove deprecated patterns and dead code
/tools:test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/tools:docker-optimize Create multi-stage production build
/tools:k8s-manifest Deploy with zero-downtime strategy
```

## 命令编排模式

命令可以单独使用，也可以组合成强大的模式：

### 顺序执行
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### 并行分析
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 迭代改进
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```
### 跨域集成

```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## 何时使用工作流与工具

### 🔀 工作流 & 子代理工具
- **问题解决**：自适应分析和修复问题
- **多视角**：协调专业子代理
- **复杂任务**：跨领域的多步骤流程
- **未知方案**：让子代理决定方法

### 🛠️ 专业工具
- **基础设施设置**：配置环境
- **代码生成**：创建特定实现
- **分析**：生成报告但不做修复
- **领域任务**：高度专业化的操作

**示例：**
- “实现用户认证系统” → `/workflows:feature-development`
- “修复全栈性能问题” → `/workflows:smart-fix`
- “现代化遗留单体系统” → `/workflows:legacy-modernize`

### 🔧 何时使用工具：
- **需要特定专业知识** — 单一领域的明确任务
- **需要精确控制** — 希望指定具体实现细节
- **手动流程的一部分** — 集成进已有流程
- **需要深入专业化** — 需专家级实现
- **基于现有工作构建** — 增强或完善以前成果

**示例：**
- “创建 Kubernetes 清单” → `/tools:k8s-manifest`
- “扫描安全漏洞” → `/tools:security-scan`
- “生成 API 文档” → `/tools:doc-generate`

## 命令格式

斜线命令是简单的 Markdown 文件，其中：
- 文件名即为命令名（如 `tools/api-scaffold.md` → `/tools:api-scaffold`）
- 文件内容为调用时执行的提示/指令
- 使用 `$ARGUMENTS` 占位符接收用户输入

## 最佳实践

### 命令选择
- **让Claude Code自动建议** - 分析上下文并选择最佳命令
- **使用工作流处理复杂任务** - 子代理协调多领域实现
- **使用工具处理专注任务** - 应用特定命令以实现针对性改进

### 高效使用
- **提供全面上下文** - 包含技术栈、约束和需求
- **策略性串联命令** - 工作流 → 工具 → 优化
- **基于先前输出构建** - 命令设计为协同工作

## 贡献指南

1. 在 `workflows/` 或 `tools/` 中创建 `.md` 文件
2. 使用小写加连字符命名
3. 包含用于用户输入的 `$ARGUMENTS`

## 故障排查

**命令未找到**： 
- 检查文件是否在 `~/.claude/commands/tools/` 或 `~/.claude/commands/workflows/`
- 使用正确前缀：`/tools:command-name` 或 `/workflows:command-name`
- 或者如果不需要前缀可扁平化目录：`cp tools/*.md . && cp workflows/*.md .`

**工作流缓慢**：正常 - 它们协调多个子代理

**输出太通用**：请添加更具体的技术栈信息

**集成问题**：请验证文件路径和命令顺序

## 性能提示

**命令选择：**
- **工作流**：用于复杂功能的多子代理协调
- **工具**：用于特定任务的单一操作
- **简单编辑**：保持主代理处理

**优化建议：**
- 已知问题优先使用工具
- 预先提供详细需求
- 基于之前的命令输出进行构建
- 在修改前让工作流完成

### 添加新工作流：
- 关注子代理的编排和委派逻辑
- 指定使用哪些专门的子代理及其顺序
- 定义子代理之间的协调模式

### 添加新工具：
- 包含完整、可用于生产的实现
- 用清晰的章节和可操作的输出结构化内容
- 包含示例、最佳实践和集成点

## 了解更多

- [Claude Code 文档](https://docs.anthropic.com/en/docs/claude-code)
- [斜杠命令文档](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [子代理文档](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code 子代理集合](https://github.com/wshobson/agents) - 这些命令使用的专用子代理


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---