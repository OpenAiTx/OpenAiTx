# claude-swift-engineering

[![许可证](https://img.shields.io/badge/license-MIT-green)](#) [![平台](https://img.shields.io/badge/platform-iOS%2026%2B%20%7C%20macOS-blue)](#)

> Claude Code 现代 Swift/SwiftUI 开发的插件市场

一个专门的 AI 工具包，用于使用现代 Swift 6.2、TCA（可组合架构）和 SwiftUI 构建专业的 iOS/macOS 功能。该插件提供超专业化的代理，协调规划、实现、测试和部署。

## Swift 工程插件

**swift-engineering 插件** 是面向专业 Swift 开发的生产级工具包：

- **12 个超专业化代理** — 规划（Opus）、实现（Inherit）、工具（Haiku）及清晰交接
- **TCA 支持** — 从架构设计到测试的完整工作流，支持可组合架构
- **现代 Swift 6.2** — iOS 26+，支持严格并发、async/await、actor、Sendable
- **代码质量** — 集成代码审查、无障碍合规及性能检查
- **知识技能** — 18 个专门知识库，涵盖架构模式、框架、设计和开发工具

## 快速开始

### 安装

将插件添加到 Claude Code：

```bash
# Add marketplace source
/plugin marketplace add https://github.com/johnrogers/claude-swift-engineering

# Install swift-engineering plugin
/plugin install swift-engineering
```

### 钩子（可选）

启用技能/代理评估钩子以提升工作流程纪律：

```bash
# 1. Symlink hooks-scripts to ~/.claude
ln -s /path/to/claude-swift-engineering/plugins/swift-engineering/hooks-scripts ~/.claude/hooks-scripts

# 2. Add to ~/.claude/settings.json
{
  "hooks": {
    "UserPromptSubmit": [
      {
        "hooks": [
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/skill-forced-eval-hook.sh"
          },
          {
            "type": "command",
            "command": "cat ~/.claude/hooks-scripts/UserPromptSubmit/agent-forced-eval-hook.sh"
          }
        ]
      }
    ]
  }
}
```
请参阅 [plugins/swift-engineering/hooks-scripts/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/hooks-scripts/README.md) 获取完整的钩子文档。

请参阅 [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) 获取关于使用代理和可用工作流程的完整文档。

## 包含内容

### 12 个专用代理

| 类型 | 代理 | 职责 |
|------|--------|-----------------|
| **规划** | @swift-ui-design, @swift-architect, @tca-architect | 架构决策（Opus，只读） |
| **实现** | @tca-engineer, @swift-engineer, @swiftui-specialist, @swift-test-creator, @documentation-generator, @swift-code-reviewer, @swift-modernizer | 代码创建与审查（继承） |
| **工具** | @swift-documenter, @search | API 文档和代码搜索（Haiku） |

### 18 个知识技能

架构模式（TCA、SwiftUI、现代 Swift、高级手势）、框架（SQLite、GRDB、StoreKit、网络）、平台设计（iOS 26、HIG、本地化、触觉反馈）和开发工具（测试、风格、诊断）。每项技能都提供关于现代模式和最佳实践的深入指导。

## 面向贡献者

### 仓库结构


```
claude-swift-engineering/
├── .claude-plugin/
│   └── marketplace.json                    # Marketplace configuration
├── .github/workflows/                      # CI/CD pipelines
├── plugins/
│   └── swift-engineering/                  # Main plugin
│       ├── agents/                         # 12 specialized agents
│       ├── skills/                         # 18 comprehensive skills
│       ├── hooks-scripts/                  # Hooks system
│       ├── scripts/                        # Helper utilities
│       ├── rules/                          # Development rules
│       └── README.md                       # Plugin documentation
└── worktrees/                              # Git worktrees for features
```

### 开发工作流程

#### 版本升级

在进行更改时，增加插件版本号：

```bash
bash plugins/swift-engineering/scripts/bump-plugin-version.sh <new-version>
```
这会更新 plugin.json、marketplace.json 及其他元数据文件中的版本号。

#### 添加代理或技能

1. 按照现有模式创建新的代理或技能文件（参见 `agents/` 或 `skills/` 中的示例）
2. 如果定义新的工具功能，更新 `plugin.json`
3. 运行冒烟测试以验证配置
4. 更新两个 README 文件（根目录和插件目录）
5. 测试与工作流的集成

### 代码组织

- **代理** (`agents/`) — 每个代理都有一个包含元数据和说明的 `.md` 文件
- **技能** (`skills/`) — 代理引用的知识资源，按主题组织
- **钩子** (`hooks-scripts/`) — 强制执行工作流的可执行钩子
- **脚本** (`scripts/`) — 自动化的实用 Shell 脚本
- **规则** (`rules/`) — 开发实践和决策框架
- **文档** (`docs/`) — 冒烟测试和验证套件

## 架构与设计原则

该插件实现了几个关键原则：

- **超专业化** — 每个代理有一个明确的职责和定义好的交接
- **模型分层** — Opus 用于架构（最佳推理），Inherit 用于实现（成本效益），Haiku 用于工具（快速）
- **本地优先** — 默认使用 SQLite 和 UserDefaults，绝不使用 SwiftData 或 Core Data
- **仅限现代 Swift** — Swift 6.2 严格并发，不使用已弃用的 API
- **只读规划** — 规划代理不能修改代码，确保职责清晰分离
- **计划文件协调** — 代理通过 `docs/plans/<feature>.md` 共享状态

参见 [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md) 了解架构细节、工作流图和交接模型。

## 许可

MIT 许可 — 详见 [LICENSE](LICENSE) 文件。

## 致谢

**作者：** John Rogers

**仓库：** claude-swift-engineering  
**Swift 版本：** 6.2+  
**iOS 部署目标：** 26.0+  

---  

有关详细文档、代理规范和使用示例，请参见 [plugins/swift-engineering/README.md](https://raw.githubusercontent.com/johnrogers/claude-swift-engineering/main/plugins/swift-engineering/README.md)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---