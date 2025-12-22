# NovelWeave - AI驱动的小说写作VSCode扩展

[English](#) | [简体中文](https://raw.githubusercontent.com/wordflowlab/novelweave/main/README.zh-CN.md)

> 🌟 通过AI辅助、结构化方法和无缝的VSCode集成，改变您的小说写作体验。
>
> 基于成熟的[novel-writer](https://github.com/wordflowlab/novel-writer)方法论，NovelWeave将专业的小说创作工具直接带入您的VSCode工作流程。

## ✨ 主要功能

- 📝 **七步法** - 规范驱动的小说创作工作流
- 🎨 **视觉界面** - 直观的侧边栏、Web视图面板及集成AI聊天
- 🤖 **多AI支持** - 支持Claude 4、GPT-4、Gemini Pro及400+ AI模型
- 🧠 **智能代理技能** - 模块化AI知识系统，专注写作专业技能
- 📊 **项目管理** - 章节跟踪、角色档案、情节线索
- 🔌 **斜杠命令** - 完全支持novel-writer命令系统
- ✅ **质量保障** - 情节跟踪、时间线管理、一致性校验
- 🌐 **跨平台** - 兼容Windows、macOS和Linux

## 🚀 快速开始

### 1. 安装

从VSCode市场安装NovelWeave：

```bash
# Search "NovelWeave" in VSCode Extensions
# Or install via command:
code --install-extension novelweave.novelweave
```

### 2. 创建您的第一个小说项目

1. 打开 VSCode 并点击活动栏中的 NovelWeave 图标
2. 点击“新建项目”以初始化小说项目
3. 选择您的 AI 模型并配置设置
4. 开始使用 AI 辅助写作！

### 3. 使用七步法

NovelWeave 实现了经过验证的七步小说创作方法：

```
1. /constitution  → Establish core creative principles
2. /specify       → Define story requirements
3. /clarify       → Resolve ambiguities through Q&A
4. /plan          → Design technical implementation
5. /tasks         → Break down into actionable steps
6. /write         → Execute the actual writing
7. /analyze       → Validate quality and consistency
```

## 📚 七步法

### 第一步：`/constitution` - 创作宪章

定义你不可妥协的写作原则、风格指南和核心价值观，指导整个小说创作。

### 第二步：`/specify` - 故事规格

如同产品需求文档（PRD），明确你想要创作的故事、目标读者和成功标准。

### 第三步：`/clarify` - 关键澄清

AI识别规格中的模糊点，生成最多5个关键问题，以消除写作前的疑惑。

### 第四步：`/plan` - 创作计划

将抽象需求转化为具体技术方案：章节结构、人物弧线、世界观设定和情节时间线。

### 第五步：`/tasks` - 任务分解

将计划拆解为可执行的写作任务，明确优先级和依赖关系。

### 第六步：`/write` - 执行写作

根据任务列表写作，遵循你的宪章原则和创作计划。

### 第七步：`/analyze` - 全面验证

验证情节连贯性、时间线准确性、人物发展及对创作原则的遵循。

> 📖 **详细方法论**：详见 [novel-writer 文档](https://github.com/wordflowlab/novel-writer)

## 🔧 NovelWeave 与 novel-writer CLI 对比

| 功能                   | novel-writer CLI       | NovelWeave VSCode                   |
| ---------------------- | ---------------------- | ---------------------------------- |
| **界面**               | 命令行                 | 图形用户界面                      |
| **安装**               | `npm install -g`       | VSCode 市场                      |
| **AI 集成**            | 基础                   | 完整 AI 聊天与辅助                |
| **项目管理**           | 文件系统               | VSCode 工作区 + UI 面板                |
| **斜杠命令**           | ✅                     | ✅                                   |
| **可视化跟踪**         | ❌                     | ✅（情节，角色，时间线）              |
| **学习曲线**           | 需熟悉命令行界面       | 直观的用户界面                       |
| **适用对象**           | 技术熟练的写作者       | 所有写作者，特别是 VSCode 用户       |

**它们协同工作！** 使用 novel-writer CLI 进行自动化和脚本操作，同时 NovelWeave 提供可视化界面和 AI 交互。

## 🎯 使用场景

- **长篇小说** - 管理包含 100+ 章节的复杂情节
- **网络连载写作** - 借助 AI 辅助实现稳定的每日更新
- **剧本与脚本** - 通过场景管理实现结构化叙事
- **同人小说** - 保持与原作的一致性
- **创意写作** - 任何叙事项目均受益于结构化方法

## 📖 详细功能

### 代理技能系统

NovelWeave 创新的 **代理技能** 系统为您的 AI 助手提供按需激活的专业知识模块：

- **内置技能** - 专业写作知识，包括：
    - 类型知识（言情、悬疑、奇幻）
    - 写作技巧（对话，场景结构）
    - 质量保证（一致性检查，需求检测）
- **项目技能** - 在 `.agent/skills/` 中共享团队特定指南
- **个人技能** - 您自己的可复用知识库
- **智能激活** - AI 根据任务自动选择相关技能
- **自定义技能** - 使用简单的 Markdown 创建您自己的专业模块

> 📖 **了解更多**：详见 [代理技能用户指南](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) 获取使用说明。

### AI 驱动的写作助手

- **智能续写** - AI 根据您的风格建议后续段落
- **角色声音** - 保持角色个性一致
- **情节建议** - AI 协助解决情节漏洞和节奏问题
- **风格分析** - 提供写作风格和可读性反馈

### 项目组织

- **章节管理** - 在侧边栏中导航和组织章节  
- **角色档案** - 跟踪角色发展和关系  
- **世界构建** - 管理设定、规则和背景故事  
- **情节线索** - 可视化并跟踪多个故事线  

### 质量保证

- **一致性检查** - 验证角色特征、时间线和事实  
- **情节追踪** - 确保所有情节线索得到解决  
- **时间线管理** - 时间顺序准确性验证  
- **风格一致性** - 保持你独特的写作风格  

## 🆕 新功能

### v0.13.0（最新）

- 🧠 **代理技能系统** - 模块化 AI 知识架构  
    - 14 种内置专业写作技能  
    - 三层系统：扩展、项目和个人技能  
    - 基于任务上下文的智能自动激活  
    - 完整 UI，用于浏览、管理和创建自定义技能  
- ✅ 增强的质量保证工具  
- 📚 全面的文档和最佳实践指南  

### v1.0

- ✅ 完整的七步法实现  
- ✅ 多 AI 模型支持（400+ 模型）  
- ✅ 可视化项目管理界面  
- ✅ 集成情节和角色追踪  
- ✅ 实时 AI 写作辅助  
- ✅ 完全兼容小说作家斜杠命令  

## 💡 最佳实践

1. **从章程开始** - 在写作前定义你的原则  
2. **广泛使用澄清** - 早期解决歧义，避免重写  
3. **信任流程** - 遵循所有七个步骤以获得最佳效果
4. **迭代** - 随着故事的发展返回到之前的步骤  
5. **持续跟踪** - 每个主要章节后更新跟踪器  

## 🔗 相关资源  

### 文档  

- 📖 [代理技能用户指南](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) - 学习如何使用和创建技能  
- 🛠️ [代理技能开发者指南](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-developer-guide.md) - 技术架构和 API  
- ✍️ [技能编写最佳实践](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/writing-skills-best-practices.md) - 创建高质量技能  

### 社区与工具  

- 📦 [novel-writer 命令行工具](https://github.com/wordflowlab/novel-writer) - 命令行伴侣  
- 📖 [七步法](https://github.com/wordflowlab/novel-writer/blob/main/METHODOLOGY.md) - 详细的方法指南  
- 💬 [社区 Discord](#) - 加入使用 NovelWeave 的其他作者  
- 📺 [视频教程](#) - 观看分步指南  

## 🤝 贡献  

我们欢迎贡献！详情请参阅我们的[贡献指南](https://raw.githubusercontent.com/wordflowlab/novelweave/main/CONTRIBUTING.md)。  

## 📄 许可证  

MIT 许可证 - 详情见 [LICENSE](LICENSE) 文件。  

## 🙏 致谢  

- 基于 [NovelWeave](https://github.com/NovelWeave-Org/novelweave) 架构构建  
- 方法论来自 [novel-writer](https://github.com/wordflowlab/novel-writer)  
- 灵感源自 [Spec Kit](https://github.com/sublayerapp/spec-kit) 原则  

---  

**NovelWeave** - AI 与故事讲述大师的汇聚地 ✨📚  

为全球作家倾心打造 ❤️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---