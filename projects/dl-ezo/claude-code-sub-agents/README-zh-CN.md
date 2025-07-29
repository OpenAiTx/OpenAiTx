# Claude Code 综合代理集合

**语言**：[英语](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README.md) | [日本語](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README_JA.md)

一个包含35个专用子代理的完整集合，适用于Claude Code，实现从需求分析到生产部署及持续维护的端到端软件开发自动化。

## 🎯 概述

本仓库包含一套全面的Claude Code子代理，旨在以最小的人为干预处理完整的软件开发生命周期。代理分为六大类，涵盖现代软件开发的各个方面。

## 📦 代理分类

### 1. 需求与分析（4个代理）
**目的**：将业务需求转化为详细的技术规范

- **requirements-analyst** - 分析用户需求并创建详细的功能规格
- **user-story-generator** - 创建全面的用户故事和验收标准  
- **business-process-analyst** - 分析业务流程并转换为技术需求
- **requirements-validator** - 验证需求的完整性和一致性

### 2. 设计与架构（5个代理）
**目的**：创建稳健且可扩展的系统设计

- **system-architect** - 设计全面的系统架构和技术栈
- **data-architect** - 设计数据模型、架构和集成策略
- **interface-designer** - 设计用户界面和API规范
- **security-architect** - 设计安全框架和数据保护策略
- **design-reviewer** - 审查并验证系统设计质量

### 3. 实现与开发（10个代理）
**目的**：处理代码开发和质量保证的所有方面

- **code-reviewer** - 执行全面的代码质量评估
- **test-suite-generator** - 生成全面的测试覆盖
- **code-refactoring-specialist** - 安全地改善代码结构，减少技术债务
- **security-analyzer** - 识别漏洞和安全问题
- **performance-optimizer** - 分析并优化代码性能
- **api-designer** - 设计清晰、符合规范的RESTful API
- **documentation-generator** - 创建技术文档和代码注释
- **dependency-manager** - 管理包依赖并解决冲突
- **database-schema-designer** - 设计高效的数据库架构和迁移方案
- **cicd-builder** - 创建和配置CI/CD流水线

### 4. 项目管理（5个代理）
**目的**：协调和管理整个开发过程

- **project-planner** - 制定全面的项目计划和时间表
- **risk-manager** - 识别项目风险并制定缓解策略
- **progress-tracker** - 监控项目进度并识别阻碍
- **qa-coordinator** - 建立质量标准并协调测试
- **stakeholder-communicator** - 管理利益相关者沟通和报告

### 5. 部署与运维（5个代理）
**目的**：处理生产部署和持续运维

- **project-orchestrator** - 端到端项目执行的总协调者
- **deployment-ops-manager** - 负责生产部署和运营监控
- **uat-coordinator** - 协调与业务利益相关者的用户验收测试
- **training-change-manager** - 制作培训材料并管理系统采用
- **project-template-manager** - 管理项目模板并快速设置常见项目模式

### 6. 元管理（6个代理）
**目的**：优化Claude Code自身以实现最高效率

- **context-manager** - 监控会话上下文并管理信息连续性
- **session-continuity-manager** - 确保Claude Code会话间的无缝衔接
- **memory-manager** - 优化Claude Code内存使用和项目文档
- **workflow-optimizer** - 分析并优化开发工作流和代理使用
- **resource-monitor** - 监控资源使用并提出优化策略
- **agent-creator** - 动态创建新的专用代理以满足项目需求

## 🚀 主要特性

### 完整自动化
- **端到端开发**：从需求到生产部署
- **智能协调**：代理自动协作并安排工作顺序
- **动态专业化**：为独特项目需求创建新代理
- **会话连续性**：在长时间开发中保持上下文

### 专业质量
- **行业最佳实践**：每个代理遵循既定方法论
- **全面测试**：自动测试生成和质量保证
- **安全优先**：内置安全分析和合规检查
- **生产准备**：完整的部署和运营支持

### 可扩展架构
- **模块化设计**：可单独使用代理或完整工作流
- **上下文保存**：长项目的高效内存管理
- **资源优化**：监控并优化Claude Code使用
- **模板驱动**：通过成熟模式快速设置项目

## 💡 使用场景

### 完整项目自动化
```
User: "Create a library management system for our company"
Result: Fully functional web application with database, API, frontend, tests, documentation, and deployment
```

### 专业开发任务
```
User: "Review this authentication code for security issues"
Agent: security-analyzer performs comprehensive security audit
```

### 长期项目管理
```
User: "Manage the development of a multi-tenant SaaS platform"
Agent: project-orchestrator coordinates all phases with appropriate specialists
```

## 📋 安装

1. **克隆或复制代理定义** 到您的项目的 `.claude/agents/` 目录：
   ```bash
   mkdir -p .claude/agents
   # Copy the 35 agent definition files to this directory
   ```

2. **验证安装**：
   ```bash
   ls .claude/agents/
   # Should show all 35 agent files (.md format)
   ```

3. **开始在 Claude Code 中使用代理** ：
   ```
   Use the project-orchestrator agent to build a complete web application
   ```

## 🎮 使用示例

### 启动一个新的 Web 应用程序
```
"I want to build a task management web application with user authentication, real-time updates, and mobile responsiveness. Handle everything from requirements to deployment."
```

**项目协调者**将：
1. 使用**需求分析师**收集详细需求
2. 协调**系统架构师**和**数据架构师**进行设计
3. 管理开发代理的实现工作
4. 处理测试、部署和文档编制
5. 为最终用户提供培训材料

### 代码质量评审
```
"Review my e-commerce checkout process for security vulnerabilities, performance issues, and code quality."
```
多个代理协同工作：  
- **security-analyzer** 检查漏洞  
- **performance-optimizer** 识别瓶颈  
- **code-reviewer** 确保最佳实践  

### 长期项目管理

```
"Manage the development of our new customer portal over the next 6 months with regular stakeholder updates."
```
系统提供：
- 自动化项目规划和风险管理
- 定期进度跟踪和报告
- 质量关卡和测试协调
- 利益相关者沟通管理

## 🔧 代理工作流程模式

### 顺序模式
需求 → 设计 → 实现 → 测试 → 部署

### 并行模式
多个开发代理同时处理不同组件

### 自适应模式
**agent-creator** 为独特需求生成专用代理

### 持续模式
元管理代理提供持续优化和监控

## 📝 代理定义格式

每个代理遵循Claude Code的标准格式：

```markdown
---
name: agent-name
description: Detailed description with examples and usage patterns
---

Comprehensive system prompt defining the agent's expertise, responsibilities, and methodologies.
```

## 🔄 代理交互

### 主协调员
- **项目协调者** 管理整体项目流程
- 自动选择和排序合适的代理
- 处理代理间通信和依赖管理

### 专业团队
- **需求团队**：收集和验证项目需求
- **设计团队**：创建技术架构和规范  
- **开发团队**：实现、测试和优化代码
- **运维团队**：部署和维护生产系统
- **元团队**：优化Claude代码使用和连续性

## 📚 文档

每个代理包括：
- **详细描述**及使用示例
- **具体用例**和触发条件
- **预期输出**和交付物
- **与其他代理的集成模式**

## 🎯 完整自动化示例

### 输入
```
"Create a library management system for our company"
```
### 自动化流程
1. **需求分析**：利益相关者需求 → 技术规格
2. **系统设计**：架构 → 数据库设计 → API设计 → UI设计
3. **实现**：后端 → 前端 → 测试 → 文档编写
4. **质量保证**：代码审查 → 安全分析 → 性能优化
5. **部署**：生产环境搭建 → CI/CD流水线 → 监控
6. **交接**：用户培训 → 文档 → 支持流程

### 输出
- 完全功能的网络应用
- 高覆盖率的完整测试套件
- 具备监控的生产部署
- 用户文档和培训材料
- 持续维护流程

## 🤝 贡献

欢迎贡献！请：

1. 遵循既定的代理定义格式
2. 包含全面的示例和文档
3. 使用真实项目进行充分测试
4. 确保代理与现有工作流良好集成
5. 提交清晰的代理功能文档

## 📄 许可证

MIT 许可证 - 可自由使用、修改和分发这些代理，适用于任何目的。

## 🙏 致谢

设计为与 [Claude Code](https://claude.ai/code) 无缝协作，遵循所有既定模式和子代理开发最佳实践。

## 📞 支持

如有问题、疑问或建议：
- 在此仓库中开启 issue
- 查阅 Claude Code 文档 https://docs.anthropic.com/en/docs/claude-code
- 查看代理示例和使用模式

---

*通过智能自动化改造您的开发流程。从单一需求到生产系统——让代理处理复杂性，您专注于愿景。*

## 🚀 快速开始

1. **复制代理** 至您项目的 `.claude/agents/` 目录
2. **启动 Claude Code** 于您的项目中
3. **说出**：“使用 project-orchestrator 构建[您的项目描述]”
4. **观看** 系统从需求到部署全程处理

**就是这么简单！** 代理将自动协调，交付完整的生产就绪解决方案。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---