**Language:** English | [Português (Brasil)](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/pt-BR/README.md) | [简体中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/zh-TW/README.md) | [日本語](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ja-JP/README.md) | [한국어](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ko-KR/README.md) | [Türkçe](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/tr/README.md)

# Everything Claude Code

![Everything Claude Code — the performance system for AI agent harnesses](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/assets/hero.png)

[![Stars](https://img.shields.io/github/stars/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/stargazers)
[![Forks](https://img.shields.io/github/forks/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/network/members)
[![Contributors](https://img.shields.io/github/contributors/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/graphs/contributors)
[![npm ecc-universal](https://img.shields.io/npm/dw/ecc-universal?label=ecc-universal%20weekly%20downloads&logo=npm)](https://www.npmjs.com/package/ecc-universal)
[![npm ecc-agentshield](https://img.shields.io/npm/dw/ecc-agentshield?label=ecc-agentshield%20weekly%20downloads&logo=npm)](https://www.npmjs.com/package/ecc-agentshield)
[![GitHub App Install](https://img.shields.io/badge/GitHub%20App-150%20installs-2ea44f?logo=github)](https://github.com/marketplace/ecc-tools)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Shell](https://img.shields.io/badge/-Shell-4EAA25?logo=gnu-bash&logoColor=white)
![TypeScript](https://img.shields.io/badge/-TypeScript-3178C6?logo=typescript&logoColor=white)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![Go](https://img.shields.io/badge/-Go-00ADD8?logo=go&logoColor=white)
![Java](https://img.shields.io/badge/-Java-ED8B00?logo=openjdk&logoColor=white)
![Perl](https://img.shields.io/badge/-Perl-39457E?logo=perl&logoColor=white)
![Markdown](https://img.shields.io/badge/-Markdown-000000?logo=markdown&logoColor=white)

> **140K+ stars** | **21K+ forks** | **170+ contributors** | **12+ language ecosystems** | **Anthropic Hackathon Winner**

---

<div align="center">

**Language / 语言 / 語言 / Dil**

[**English**](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.md) | [Português (Brasil)](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/pt-BR/README.md) | [简体中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/zh-TW/README.md) | [日本語](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ja-JP/README.md) | [한국어](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ko-KR/README.md)
 | [Türkçe](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/tr/README.md)

</div>

---

**The performance optimization system for AI agent harnesses. From an Anthropic hackathon winner.**

Not just configs. A complete system: skills, instincts, memory optimization, continuous learning, security scanning, and research-first development. Production-ready agents, skills, hooks, rules, MCP configurations, and legacy command shims evolved over 10+ months of intensive daily use building real products.

适用于 **Claude Code**、**Codex**、**Cursor**、**OpenCode**、**Gemini** 及其他 AI 代理框架。

ECC v2.0.0-rc.1 在该可复用层之上添加了公共 Hermes 操作员故事：首先阅读 [Hermes 设置指南](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/HERMES-SETUP.md)，然后查看 [rc.1 版本说明](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/releases/2.0.0-rc.1/release-notes.md) 和 [跨框架架构](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/architecture/cross-harness.md)。

---

## 指南

本仓库仅包含原始代码。指南解释了一切内容。

<table>
<tr>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2012378465664745795">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/guides/shorthand-guide.png" alt="The Shorthand Guide to Everything Claude Code" />
</a>
</td>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2014040193557471352">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/guides/longform-guide.png" alt="The Longform Guide to Everything Claude Code" />
</a>
</td>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2033263813387223421">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/security/security-guide-header.png" alt="The Shorthand Guide to Everything Agentic Security" />
</a>
</td>
</tr>
<tr>
<td align="center"><b>简明指南</b><br/>设置、基础、理念。<b>请先阅读此文。</b></td>
<td align="center"><b>详细指南</b><br/>令牌优化、内存持久化、评估、并行化。</td>
<td align="center"><b>安全指南</b><br/>攻击向量、沙箱、消毒、CVE、AgentShield。</td>
</tr>
</table>

| 主题 | 您将学到的内容 |
|-------|-------------------|
| 令牌优化 | 模型选择、系统提示瘦身、后台进程 |
| 内存持久化 | 自动保存/加载会话上下文的钩子 |
| 持续学习 | 自动从会话中提取模式，转化为可复用技能 |
| 验证循环 | 检查点与持续评估，评分器类型，pass@k 指标 |
| 并行化 | Git 工作树，级联方法，何时扩展实例 |
| 子代理编排 | 上下文问题，迭代检索模式 |

---

## 新内容

### v2.0.0-rc.1 — 界面刷新、操作员工作流及 ECC 2.0 Alpha（2026年4月）

- **仪表盘 GUI** — 基于 Tkinter 的全新桌面应用（`ecc_dashboard.py` 或 `npm run dashboard`），支持暗/亮主题切换、字体定制及项目徽标显示于标题和任务栏。
- **公共界面同步至实时仓库** — 元数据、目录计数、插件清单及安装文档现已匹配实际开源界面：48 个代理，182 个技能，68 个旧命令适配器。
- **操作员及外发工作流扩展** — `brand-voice`、`social-graph-ranker`、`connections-optimizer`、`customer-billing-ops`、`ecc-tools-cost-audit`、`google-workspace-ops`、`project-flow-ops` 和 `workspace-surface-audit` 补全操作员线路。
- **媒体与发布工具** — `manim-video`、`remotion-video-creation` 及升级的社交发布界面，使技术解说和发布内容成为同一系统部分。
- **框架及产品界面扩展** — `nestjs-patterns`、更丰富的 Codex/OpenCode 安装界面及扩展的跨 Harness 打包，使仓库不仅限于 Claude Code 使用。
- **ECC 2.0 alpha 已入树** — `ecc2/` 中的 Rust 控制平面原型现可本地构建，支持 `dashboard`、`start`、`sessions`、`status`、`stop`、`resume` 和 `daemon` 命令。现可作为 alpha 版本使用，尚非正式发布。
- **生态系统强化** — AgentShield、ECC 工具成本控制、计费门户工作及网站刷新继续围绕核心插件发布，避免分散成孤立模块。

### v1.9.0 — 选择性安装与语言扩展（2026年3月）

- **选择性安装架构** — 基于清单的安装流水线，配合 `install-plan.js` 和 `install-apply.js` 实现针对性组件安装。状态存储跟踪已安装内容并支持增量更新。
- **新增 6 个代理** — `typescript-reviewer`、`pytorch-build-resolver`、`java-build-resolver`、`java-reviewer`、`kotlin-reviewer`、`kotlin-build-resolver`，语言覆盖扩展至 10 种。
- **新增技能** — `pytorch-patterns` 深度学习工作流，`documentation-lookup` API 参考查询，`bun-runtime` 和 `nextjs-turbopack` 现代 JS 工具链，加上 8 个运营领域技能及 `mcp-server-patterns`。
- **会话与状态基础设施** — SQLite 状态存储及查询 CLI，会话适配器支持结构化记录，技能进化基础促进技能自我提升。
- **编排大改造** — Harness 审核评分确定性改进，编排状态及启动器兼容性强化，5 层防护防止观察者循环。
- **观察者可靠性** — 通过节流和尾部采样解决内存爆炸，修复沙箱访问，延迟启动逻辑及重入保护。
- **12 种语言生态** — 新增 Java、PHP、Perl、Kotlin/Android/KMP、C++ 及 Rust 规则，加入现有 TypeScript、Python、Go 和通用规则。
- **社区贡献** — 韩语和中文翻译，生态钩子优化，视频处理技能，运营技能，PowerShell 安装器，Antigravity IDE 支持。
- **CI 强化** — 修复 19 个测试失败，目录计数强制，安装清单验证，完整测试套件全绿。

### v1.8.0 — Harness 性能系统（2026年3月）

- **Harness 首次发布** — ECC 明确定位为代理 Harness 性能系统，而非仅是配置包。
- **钩子可靠性大改造** — SessionStart 根备选，Stop 阶段会话总结，脚本化钩子替换脆弱的内联单行代码。
- **钩子运行时控制** — `ECC_HOOK_PROFILE=minimal|standard|strict` 和 `ECC_DISABLED_HOOKS=...` 实现运行时门控，无需编辑钩子文件。
- **新增 Harness 命令** — `/harness-audit`、`/loop-start`、`/loop-status`、`/quality-gate`、`/model-route`。
- **NanoClaw v2** — 模型路由，技能热加载，会话分支/搜索/导出/压缩/指标。
- **跨 Harness 一致性** — 加强 Claude Code、Cursor、OpenCode 及 Codex 应用/CLI 行为一致性。
- **997 个内部测试通过** — 钩子/运行时重构及兼容性更新后测试套件全部通过。

### v1.7.0 — 跨平台扩展与演示构建器（2026年2月）

- **Codex 应用 + CLI 支持** — 直接基于 `AGENTS.md` 的 Codex 支持，安装器定位及 Codex 文档  
- **`frontend-slides` 技能** — 零依赖 HTML 演示构建器，带 PPTX 转换指导和严格的视口适配规则  
- **5 个通用业务/内容技能** — `article-writing`、`content-engine`、`market-research`、`investor-materials`、`investor-outreach`  
- **更广泛的工具覆盖** — Cursor、Codex 和 OpenCode 支持加强，使同一仓库能在所有主流环境中干净发布  
- **992 个内部测试** — 扩展插件、钩子、技能和打包的验证及回归覆盖  

### v1.6.0 — Codex CLI、AgentShield 与市场（2026年2月）

- **Codex CLI 支持** — 新增 `/codex-setup` 命令生成 `codex.md`，兼容 OpenAI Codex CLI  
- **7 个新技能** — `search-first`、`swift-actor-persistence`、`swift-protocol-di-testing`、`regex-vs-llm-structured-text`、`content-hash-cache-pattern`、`cost-aware-llm-pipeline`、`skill-stocktake`  
- **AgentShield 集成** — `/security-scan` 技能可直接在 Claude Code 中运行 AgentShield；1282 测试，102 规则  
- **GitHub 市场** — ECC Tools GitHub 应用上线，地址为 [github.com/marketplace/ecc-tools](https://github.com/marketplace/ecc-tools)，支持免费/专业/企业套餐  
- **30+ 社区 PR 合并** — 来自 30 名贡献者，涵盖 6 种语言的贡献  
- **978 个内部测试** — 扩展代理、技能、命令、钩子和规则的验证套件  

### v1.4.1 — Bug 修复（2026年2月）

- **修复 instinct 导入内容丢失** — `/instinct-import` 期间，`parse_instinct_file()` 在 frontmatter（动作、证据、示例部分）后静默丢弃了所有内容。([#148](https://github.com/affaan-m/everything-claude-code/issues/148), [#161](https://github.com/affaan-m/everything-claude-code/pull/161))  

### v1.4.0 — 多语言规则、安装向导与 PM2（2026年2月）

- **交互式安装向导** — 新增 `configure-ecc` 技能，提供引导式安装，支持合并/覆盖检测  
- **PM2 与多代理编排** — 6 个新命令 (`/pm2`、`/multi-plan`、`/multi-execute`、`/multi-backend`、`/multi-frontend`、`/multi-workflow`) 用于管理复杂多服务工作流  
- **多语言规则架构** — 规则从扁平文件重构为 `common/` + `typescript/` + `python/` + `golang/` 目录，按需安装语言  
- **中文（zh-CN）翻译** — 完整翻译所有代理、命令、技能与规则（80+ 文件）  
- **GitHub 赞助支持** — 通过 GitHub Sponsors 支持该项目  
- **增强 CONTRIBUTING.md** — 针对每种贡献类型的详细 PR 模板  

### v1.3.0 — OpenCode 插件支持（2026年2月）

- **完整 OpenCode 集成** — 12 个代理，24 个命令，16 个技能，支持通过 OpenCode 插件系统的钩子（20+ 事件类型）  
- **3 个原生自定义工具** — run-tests、check-coverage、security-audit  
- **LLM 文档** — `llms.txt` 提供全面的 OpenCode 文档  

### v1.2.0 — 统一命令与技能（2026年2月）

- **Python/Django 支持** — Django 模式、安全、TDD 和验证技能  
- **Java Spring Boot 技能** — Spring Boot 的模式、安全、TDD 和验证
- **会话管理** — `/sessions` 命令用于会话历史记录  
- **连续学习 v2** — 基于本能的学习与置信度评分，导入/导出，进化  

完整更新日志见 [版本发布](https://github.com/affaan-m/everything-claude-code/releases)。  

---  

## 快速开始  

2分钟内启动并运行：  

### 只选择一条路径  

大多数 Claude Code 用户应只使用一种安装路径：  

- **推荐默认：** 安装 Claude Code 插件，然后只复制你真正需要的规则文件夹。  
- **仅当需要更细粒度控制、完全避免插件路径，或你的 Claude Code 构建无法解析自托管市场条目时，才使用手动安装程序。**  
- **不要叠加安装方法。** 最常见的错误配置是：先用 `/plugin install`，然后再用 `install.sh --profile full` 或 `npx ecc-install --profile full`。  

如果你已经叠加了多次安装且出现重复，直接跳转到[重置 / 卸载 ECC](#reset--uninstall-ecc)。  

### 低上下文 / 无钩子路径  

如果钩子感觉过于全局，或你只想要 ECC 的规则、代理、命令和核心工作流技能，跳过插件，使用最小手动配置：

```bash
./install.sh --profile minimal --target claude
```

```powershell
.\install.ps1 --profile minimal --target claude
# or
npx ecc-install --profile minimal --target claude
```

此配置文件故意排除了 `hooks-runtime`。

如果您想要正常的核心配置文件但需要关闭 hooks，请使用：

```bash
./install.sh --profile core --without baseline:hooks --target claude
```

仅在需要运行时强制执行时才添加钩子：

```bash
./install.sh --target claude --modules hooks-runtime
```

### 先找到合适的组件

如果您不确定安装哪个ECC配置文件或组件，请咨询任何项目中的打包顾问：

```bash
npx ecc consult "security reviews" --target claude
```
它返回匹配的组件、相关配置文件以及预览/安装命令。如果您想检查确切的文件计划，请在安装前使用预览命令。

### 第1步：安装插件（推荐）

> 注意：插件使用方便，但如果您的Claude Code构建在解析自托管市场条目时遇到问题，下面的OSS安装程序仍然是最可靠的途径。


```bash
# Add marketplace
/plugin marketplace add https://github.com/affaan-m/everything-claude-code

# Install plugin
/plugin install everything-claude-code@everything-claude-code
```
### 命名 + 迁移说明

ECC 现在有三个公共标识符，它们不可互换：

- GitHub 源代码仓库：`affaan-m/everything-claude-code`
- Claude 市场/插件标识符：`everything-claude-code@everything-claude-code`
- npm 包：`ecc-universal`

这是有意为之。Anthropic 市场/插件安装是以规范插件标识符为键，因此 ECC 统一采用 `everything-claude-code@everything-claude-code`，以使列表名称、`/plugin install`、`/plugin list` 和仓库文档都对齐为一个公共安装界面。旧帖子中可能仍显示旧的简短昵称；该简写已被弃用。另一个方面，npm 包保持为 `ecc-universal`，因此 npm 安装和市场安装故意使用不同名称。

### 步骤 2：安装规则（必需）

> 警告：**重要：** Claude Code 插件无法自动分发 `rules`。
>
> 如果你已经通过 `/plugin install` 安装了 ECC，**请勿随后运行 `./install.sh --profile full`、`.\install.ps1 --profile full` 或 `npx ecc-install --profile full`**。插件已经加载了 ECC 技能、命令和钩子。全量安装程序在插件安装后运行，会将相同的内容复制到你的用户目录，可能导致技能重复及运行时行为重复。
>
> 对于插件安装，只需手动复制你想要的 `rules/` 目录到 `~/.claude/rules/ecc/` 下。先从 `rules/common` 以及你实际使用的一种语言或框架包开始。除非你明确想让 Claude 拥有所有上下文，否则不要复制所有规则目录。
>
> 仅在你选择完全手动安装 ECC 而非插件路径时，才使用全量安装程序。
>
> 如果你的本地 Claude 设置被清除或重置，这并不意味着你需要重新购买 ECC。先运行 `node scripts/ecc.js list-installed`，然后运行 `node scripts/ecc.js doctor` 和 `node scripts/ecc.js repair`，再进行任何重新安装。通常这能恢复 ECC 管理的文件而无需重建你的设置。如果问题是 ECC 工具的账户或市场访问问题，请另行处理账单/账户恢复。


```bash
# Clone the repo first
git clone https://github.com/affaan-m/everything-claude-code.git
cd everything-claude-code

# Install dependencies (pick your package manager)
npm install        # or: pnpm install | yarn install | bun install

# Plugin install path: copy only ECC rules into an ECC-owned namespace
mkdir -p ~/.claude/rules/ecc
cp -R rules/common ~/.claude/rules/ecc/
cp -R rules/typescript ~/.claude/rules/ecc/

# Fully manual ECC install path (use this instead of /plugin install)
# ./install.sh --profile full
```

```powershell
# Windows PowerShell

# Plugin install path: copy only ECC rules into an ECC-owned namespace
New-Item -ItemType Directory -Force -Path "$HOME/.claude/rules/ecc" | Out-Null
Copy-Item -Recurse rules/common "$HOME/.claude/rules/ecc/"
Copy-Item -Recurse rules/typescript "$HOME/.claude/rules/ecc/"

# Fully manual ECC install path (use this instead of /plugin install)
# .\install.ps1 --profile full
# npx ecc-install --profile full
```

有关手动安装说明，请参见 `rules/` 文件夹中的 README。手动复制规则时，请复制整个语言目录（例如 `rules/common` 或 `rules/golang`），而不是其中的文件，以确保相对引用继续有效且文件名不会冲突。

### 完全手动安装（后备方案）

仅当您有意跳过插件路径时使用此方法：

```bash
./install.sh --profile full
```

```powershell
.\install.ps1 --profile full
# or
npx ecc-install --profile full
```
如果您选择这条路径，请在此处停止。不要同时运行 `/plugin install`。

### 重置 / 卸载 ECC

如果 ECC 感觉重复、干扰或损坏，请不要反复重装它。

- **插件路径：** 从 Claude Code 中移除插件，然后删除您手动复制到 `~/.claude/rules/ecc/` 下的特定规则文件夹。
- **手动安装 / CLI 路径：** 在仓库根目录下，先预览移除操作：


```bash
node scripts/uninstall.js --dry-run
```

然后删除 ECC 管理的文件：

```bash
node scripts/uninstall.js
```

你也可以使用生命周期包装器：

```bash
node scripts/ecc.js list-installed
node scripts/ecc.js doctor
node scripts/ecc.js repair
node scripts/ecc.js uninstall --dry-run
```
ECC 仅删除其安装状态中记录的文件。它不会删除未安装的无关文件。

如果您叠加了多种方法，请按以下顺序清理：

1. 移除 Claude Code 插件的安装。
2. 从仓库根目录运行 ECC 卸载命令，以删除安装状态管理的文件。
3. 删除您手动复制且不再需要的任何额外规则文件夹。
4. 重新安装一次，使用单一路径。

### 第 3 步：开始使用


```bash
# Skills are the primary workflow surface.
# Existing slash-style command names still work while ECC migrates off commands/.

# Plugin install uses the canonical namespaced form
/everything-claude-code:plan "Add user authentication"

# Manual install keeps the shorter slash form:
# /plan "Add user authentication"

# Check available commands
/plugin list everything-claude-code@everything-claude-code
```

**就是这样！** 你现在可以访问 48 个代理、182 个技能和 68 个遗留命令适配器。

### 仪表板 GUI

启动桌面仪表板以可视化探索 ECC 组件：

```bash
npm run dashboard
# or
python3 ./ecc_dashboard.py
```

**功能特性：**
- 标签式界面：代理、技能、命令、规则、设置
- 深色/浅色主题切换
- 字体自定义（字体族和大小）
- 头部和任务栏中的项目徽标
- 跨所有组件的搜索和筛选

### 多模型命令需要额外设置

> 警告：`multi-*` 命令**不包含**在上述基础插件/规则安装中。
>
> 若要使用 `/multi-plan`、`/multi-execute`、`/multi-backend`、`/multi-frontend` 和 `/multi-workflow`，必须另外安装 `ccg-workflow` 运行时。
>
> 使用 `npx ccg-workflow` 进行初始化。
>
> 该运行时提供这些命令所需的外部依赖，包括：
> - `~/.claude/bin/codeagent-wrapper`
> - `~/.claude/.ccg/prompts/*`
>
> 若无 `ccg-workflow`，这些 `multi-*` 命令将无法正确运行。

---

## 跨平台支持

此插件现已全面支持 **Windows、macOS 和 Linux**，并与主流 IDE（Cursor、OpenCode、Antigravity）及 CLI 工具紧密集成。所有钩子和脚本均已重写为 Node.js 以确保最大兼容性。

### 包管理器检测

插件会自动检测您偏好的包管理器（npm、pnpm、yarn 或 bun），优先级如下：

1. **环境变量**：`CLAUDE_PACKAGE_MANAGER`
2. **项目配置**：`.claude/package-manager.json`
3. **package.json**：`packageManager` 字段
4. **锁文件**：从 package-lock.json、yarn.lock、pnpm-lock.yaml 或 bun.lockb 检测
5. **全局配置**：`~/.claude/package-manager.json`
6. **回退方案**：首个可用的包管理器

设置您偏好的包管理器：

```bash
# Via environment variable
export CLAUDE_PACKAGE_MANAGER=pnpm

# Via global config
node scripts/setup-package-manager.js --global pnpm

# Via project config
node scripts/setup-package-manager.js --project bun

# Detect current setting
node scripts/setup-package-manager.js --detect
```

或者使用 Claude Code 中的 `/setup-pm` 命令。

### 钩子运行时控制

使用运行时标志来调整严格性或临时禁用特定钩子：

```bash
# Hook strictness profile (default: standard)
export ECC_HOOK_PROFILE=standard

# Comma-separated hook IDs to disable
export ECC_DISABLED_HOOKS="pre:bash:tmux-reminder,post:edit:typecheck"

# Cap SessionStart additional context (default: 8000 chars)
export ECC_SESSION_START_MAX_CHARS=4000

# Disable SessionStart additional context entirely for low-context/local-model setups
export ECC_SESSION_START_CONTEXT=off
```

---

## What's Inside

This repo is a **Claude Code plugin** - install it directly or copy components manually.

```
everything-claude-code/
|-- .claude-plugin/   # Plugin and marketplace manifests
|   |-- plugin.json         # Plugin metadata and component paths
|   |-- marketplace.json    # Marketplace catalog for /plugin marketplace add
|
|-- agents/           # 36 specialized subagents for delegation
|   |-- planner.md           # Feature implementation planning
|   |-- architect.md         # System design decisions
|   |-- tdd-guide.md         # Test-driven development
|   |-- code-reviewer.md     # Quality and security review
|   |-- security-reviewer.md # Vulnerability analysis
|   |-- build-error-resolver.md
|   |-- e2e-runner.md        # Playwright E2E testing
|   |-- refactor-cleaner.md  # Dead code cleanup
|   |-- doc-updater.md       # Documentation sync
|   |-- docs-lookup.md       # Documentation/API lookup
|   |-- chief-of-staff.md    # Communication triage and drafts
|   |-- loop-operator.md     # Autonomous loop execution
|   |-- harness-optimizer.md # Harness config tuning
|   |-- cpp-reviewer.md      # C++ code review
|   |-- cpp-build-resolver.md # C++ build error resolution
|   |-- go-reviewer.md       # Go code review
|   |-- go-build-resolver.md # Go build error resolution
|   |-- python-reviewer.md   # Python code review
|   |-- database-reviewer.md # Database/Supabase review
|   |-- typescript-reviewer.md # TypeScript/JavaScript code review
|   |-- java-reviewer.md     # Java/Spring Boot code review
|   |-- java-build-resolver.md # Java/Maven/Gradle build errors
|   |-- kotlin-reviewer.md   # Kotlin/Android/KMP code review
|   |-- kotlin-build-resolver.md # Kotlin/Gradle build errors
|   |-- rust-reviewer.md     # Rust code review
|   |-- rust-build-resolver.md # Rust build error resolution
|   |-- pytorch-build-resolver.md # PyTorch/CUDA training errors
|
|-- skills/           # Workflow definitions and domain knowledge
|   |-- coding-standards/           # Language best practices
|   |-- clickhouse-io/              # ClickHouse analytics, queries, data engineering
|   |-- backend-patterns/           # API, database, caching patterns
|   |-- frontend-patterns/          # React, Next.js patterns
|   |-- frontend-slides/            # HTML slide decks and PPTX-to-web presentation workflows (NEW)
|   |-- article-writing/            # Long-form writing in a supplied voice without generic AI tone (NEW)
|   |-- content-engine/             # Multi-platform social content and repurposing workflows (NEW)
|   |-- market-research/            # Source-attributed market, competitor, and investor research (NEW)
|   |-- investor-materials/         # Pitch decks, one-pagers, memos, and financial models (NEW)
|   |-- investor-outreach/          # Personalized fundraising outreach and follow-up (NEW)
|   |-- continuous-learning/        # Legacy v1 Stop-hook pattern extraction
|   |-- continuous-learning-v2/     # Instinct-based learning with confidence scoring
|   |-- iterative-retrieval/        # Progressive context refinement for subagents
|   |-- strategic-compact/          # Manual compaction suggestions (Longform Guide)
|   |-- tdd-workflow/               # TDD methodology
|   |-- security-review/            # Security checklist
|   |-- eval-harness/               # Verification loop evaluation (Longform Guide)
|   |-- verification-loop/          # Continuous verification (Longform Guide)
|   |-- videodb/                   # Video and audio: ingest, search, edit, generate, stream (NEW)
|   |-- golang-patterns/            # Go idioms and best practices
|   |-- golang-testing/             # Go testing patterns, TDD, benchmarks
|   |-- cpp-coding-standards/         # C++ coding standards from C++ Core Guidelines (NEW)
|   |-- cpp-testing/                # C++ testing with GoogleTest, CMake/CTest (NEW)
|   |-- django-patterns/            # Django patterns, models, views (NEW)
|   |-- django-security/            # Django security best practices (NEW)
|   |-- django-tdd/                 # Django TDD workflow (NEW)
|   |-- django-verification/        # Django verification loops (NEW)
|   |-- laravel-patterns/           # Laravel architecture patterns (NEW)
|   |-- laravel-security/           # Laravel security best practices (NEW)
|   |-- laravel-tdd/                # Laravel TDD workflow (NEW)
|   |-- laravel-verification/       # Laravel verification loops (NEW)
|   |-- python-patterns/            # Python idioms and best practices (NEW)
|   |-- python-testing/             # Python testing with pytest (NEW)
|   |-- springboot-patterns/        # Java Spring Boot patterns (NEW)
|   |-- springboot-security/        # Spring Boot security (NEW)
|   |-- springboot-tdd/             # Spring Boot TDD (NEW)
|   |-- springboot-verification/    # Spring Boot verification (NEW)
|   |-- configure-ecc/              # Interactive installation wizard (NEW)
|   |-- security-scan/              # AgentShield security auditor integration (NEW)
|   |-- java-coding-standards/     # Java coding standards (NEW)
|   |-- jpa-patterns/              # JPA/Hibernate patterns (NEW)
|   |-- postgres-patterns/         # PostgreSQL optimization patterns (NEW)
|   |-- nutrient-document-processing/ # Document processing with Nutrient API (NEW)
|   |-- docs/examples/project-guidelines-template.md  # Template for project-specific skills
|   |-- database-migrations/         # Migration patterns (Prisma, Drizzle, Django, Go) (NEW)
|   |-- api-design/                  # REST API design, pagination, error responses (NEW)
|   |-- deployment-patterns/         # CI/CD, Docker, health checks, rollbacks (NEW)
|   |-- docker-patterns/            # Docker Compose, networking, volumes, container security (NEW)
|   |-- e2e-testing/                 # Playwright E2E patterns and Page Object Model (NEW)
|   |-- content-hash-cache-pattern/  # SHA-256 content hash caching for file processing (NEW)
|   |-- cost-aware-llm-pipeline/     # LLM cost optimization, model routing, budget tracking (NEW)
|   |-- regex-vs-llm-structured-text/ # Decision framework: regex vs LLM for text parsing (NEW)
|   |-- swift-actor-persistence/     # Thread-safe Swift data persistence with actors (NEW)
|   |-- swift-protocol-di-testing/   # Protocol-based DI for testable Swift code (NEW)
|   |-- search-first/               # Research-before-coding workflow (NEW)
|   |-- skill-stocktake/            # Audit skills and commands for quality (NEW)
|   |-- liquid-glass-design/         # iOS 26 Liquid Glass design system (NEW)
|   |-- foundation-models-on-device/ # Apple on-device LLM with FoundationModels (NEW)
|   |-- swift-concurrency-6-2/       # Swift 6.2 Approachable Concurrency (NEW)
|   |-- perl-patterns/             # Modern Perl 5.36+ idioms and best practices (NEW)
|   |-- perl-security/             # Perl security patterns, taint mode, safe I/O (NEW)
|   |-- perl-testing/              # Perl TDD with Test2::V0, prove, Devel::Cover (NEW)
|   |-- autonomous-loops/           # Autonomous loop patterns: sequential pipelines, PR loops, DAG orchestration (NEW)
|   |-- plankton-code-quality/      # Write-time code quality enforcement with Plankton hooks (NEW)
|
|-- commands/         # Maintained slash-entry compatibility; prefer skills/
|   |-- plan.md             # /plan - Implementation planning
|   |-- code-review.md      # /code-review - Quality review
|   |-- build-fix.md        # /build-fix - Fix build errors
|   |-- refactor-clean.md   # /refactor-clean - Dead code removal
|   |-- quality-gate.md     # /quality-gate - Verification gate
|   |-- learn.md            # /learn - Extract patterns mid-session (Longform Guide)
|   |-- learn-eval.md       # /learn-eval - Extract, evaluate, and save patterns (NEW)
|   |-- checkpoint.md       # /checkpoint - Save verification state (Longform Guide)
|   |-- setup-pm.md         # /setup-pm - Configure package manager
|   |-- go-review.md        # /go-review - Go code review (NEW)
|   |-- go-test.md          # /go-test - Go TDD workflow (NEW)
|   |-- go-build.md         # /go-build - Fix Go build errors (NEW)
|   |-- skill-create.md     # /skill-create - Generate skills from git history (NEW)
|   |-- instinct-status.md  # /instinct-status - View learned instincts (NEW)
|   |-- instinct-import.md  # /instinct-import - Import instincts (NEW)
|   |-- instinct-export.md  # /instinct-export - Export instincts (NEW)
|   |-- evolve.md           # /evolve - Cluster instincts into skills
|   |-- prune.md            # /prune - Delete expired pending instincts (NEW)
|   |-- pm2.md              # /pm2 - PM2 service lifecycle management (NEW)
|   |-- multi-plan.md       # /multi-plan - Multi-agent task decomposition (NEW)
|   |-- multi-execute.md    # /multi-execute - Orchestrated multi-agent workflows (NEW)
|   |-- multi-backend.md    # /multi-backend - Backend multi-service orchestration (NEW)
|   |-- multi-frontend.md   # /multi-frontend - Frontend multi-service orchestration (NEW)
|   |-- multi-workflow.md   # /multi-workflow - General multi-service workflows (NEW)
|   |-- sessions.md         # /sessions - Session history management
|   |-- test-coverage.md    # /test-coverage - Test coverage analysis
|   |-- update-docs.md      # /update-docs - Update documentation
|   |-- update-codemaps.md  # /update-codemaps - Update codemaps
|   |-- python-review.md    # /python-review - Python code review (NEW)
|-- legacy-command-shims/   # Opt-in archive for retired shims such as /tdd and /eval
|   |-- tdd.md              # /tdd - Prefer the tdd-workflow skill
|   |-- e2e.md              # /e2e - Prefer the e2e-testing skill
|   |-- eval.md             # /eval - Prefer the eval-harness skill
|   |-- verify.md           # /verify - Prefer the verification-loop skill
|   |-- orchestrate.md      # /orchestrate - Prefer dmux-workflows or multi-workflow
|
|-- rules/            # Always-follow guidelines (copy to ~/.claude/rules/ecc/)
|   |-- README.md            # Structure overview and installation guide
|   |-- common/              # Language-agnostic principles
|   |   |-- coding-style.md    # Immutability, file organization
|   |   |-- git-workflow.md    # Commit format, PR process
|   |   |-- testing.md         # TDD, 80% coverage requirement
|   |   |-- performance.md     # Model selection, context management
|   |   |-- patterns.md        # Design patterns, skeleton projects
|   |   |-- hooks.md           # Hook architecture, TodoWrite
|   |   |-- agents.md          # When to delegate to subagents
|   |   |-- security.md        # Mandatory security checks
|   |-- typescript/          # TypeScript/JavaScript specific
|   |-- python/              # Python specific
|   |-- golang/              # Go specific
|   |-- swift/               # Swift specific
|   |-- php/                 # PHP specific (NEW)
|
|-- hooks/            # Trigger-based automations
|   |-- README.md                 # Hook documentation, recipes, and customization guide
|   |-- hooks.json                # All hooks config (PreToolUse, PostToolUse, Stop, etc.)
|   |-- memory-persistence/       # Session lifecycle hooks (Longform Guide)
|   |-- strategic-compact/        # Compaction suggestions (Longform Guide)
|
|-- scripts/          # Cross-platform Node.js scripts (NEW)
|   |-- lib/                     # Shared utilities
|   |   |-- utils.js             # Cross-platform file/path/system utilities
|   |   |-- package-manager.js   # Package manager detection and selection
|   |-- hooks/                   # Hook implementations
|   |   |-- session-start.js     # Load context on session start
|   |   |-- session-end.js       # Save state on session end
|   |   |-- pre-compact.js       # Pre-compaction state saving
|   |   |-- suggest-compact.js   # Strategic compaction suggestions
|   |   |-- evaluate-session.js  # Extract patterns from sessions
|   |-- setup-package-manager.js # Interactive PM setup
|
|-- tests/            # Test suite (NEW)
|   |-- lib/                     # Library tests
|   |-- hooks/                   # Hook tests
|   |-- run-all.js               # Run all tests
|
|-- contexts/         # Dynamic system prompt injection contexts (Longform Guide)
|   |-- dev.md              # Development mode context
|   |-- review.md           # Code review mode context
|   |-- research.md         # Research/exploration mode context
|
|-- examples/         # Example configurations and sessions
|   |-- CLAUDE.md             # Example project-level config
|   |-- user-CLAUDE.md        # Example user-level config
|   |-- saas-nextjs-CLAUDE.md   # Real-world SaaS (Next.js + Supabase + Stripe)
|   |-- go-microservice-CLAUDE.md # Real-world Go microservice (gRPC + PostgreSQL)
|   |-- django-api-CLAUDE.md      # Real-world Django REST API (DRF + Celery)
|   |-- laravel-api-CLAUDE.md     # Real-world Laravel API (PostgreSQL + Redis) (NEW)
|   |-- rust-api-CLAUDE.md        # Real-world Rust API (Axum + SQLx + PostgreSQL) (NEW)
|
|-- mcp-configs/      # MCP server configurations
|   |-- mcp-servers.json    # GitHub, Supabase, Vercel, Railway, etc.
|
|-- ecc_dashboard.py  # Desktop GUI dashboard (Tkinter)
|
|-- assets/           # Assets for dashboard
|   |-- images/
|       |-- ecc-logo.png
|
|-- marketplace.json  # Self-hosted marketplace config (for /plugin marketplace add)
```

---

## 生态系统工具

### 技能创建者

从您的代码库生成 Claude Code 技能的两种方式：

#### 选项 A：本地分析（内置）

使用 `/skill-create` 命令进行本地分析，无需外部服务：

```bash
/skill-create                    # Analyze current repo
/skill-create --instincts        # Also generate instincts for continuous-learning-v2
```
这将在本地分析您的 git 历史并生成 SKILL.md 文件。

#### 选项 B：GitHub 应用（高级）

对于高级功能（超过 1 万次提交、自动 PR、团队共享）：

[安装 GitHub 应用](https://github.com/apps/skill-creator) | [ecc.tools](https://ecc.tools)


```bash
# Comment on any issue:
/skill-creator analyze

# Or auto-triggers on push to default branch
```

两种选项都会创建：
- **SKILL.md 文件** - 适用于 Claude Code 的即用技能
- **Instinct 集合** - 用于 continuous-learning-v2
- **模式提取** - 从您的提交历史中学习

### AgentShield — 安全审计员

> 由 Claude Code 黑客松（Cerebral Valley x Anthropic，2026年2月）构建。1282 个测试，98% 覆盖率，102 条静态分析规则。

扫描您的 Claude Code 配置，查找漏洞、配置错误和注入风险。

```bash
# Quick scan (no install needed)
npx ecc-agentshield scan

# Auto-fix safe issues
npx ecc-agentshield scan --fix

# Deep analysis with three Opus 4.6 agents
npx ecc-agentshield scan --opus --stream

# Generate secure config from scratch
npx ecc-agentshield init
```

**扫描内容：** CLAUDE.md、settings.json、MCP 配置、hooks、代理定义及五类技能——秘密检测（14 种模式）、权限审计、hook 注入分析、MCP 服务器风险评估和代理配置审查。

**`--opus` 参数** 运行三个 Claude Opus 4.6 代理，组成红队/蓝队/审计员流水线。攻击者寻找利用链，防御者评估防护措施，审计员将两者综合为优先风险评估。对抗性推理，而非仅仅是模式匹配。

**输出格式：** 终端（颜色分级 A-F）、JSON（CI 流水线）、Markdown、HTML。关键发现时退出代码为 2，用于构建门控。

在 Claude Code 中使用 `/security-scan` 运行，或通过 [GitHub Action](https://github.com/affaan-m/agentshield) 集成到 CI。

[GitHub](https://github.com/affaan-m/agentshield) | [npm](https://www.npmjs.com/package/ecc-agentshield)

### 持续学习 v2

基于本能的学习系统自动学习您的模式：

```bash
/instinct-status        # Show learned instincts with confidence
/instinct-import <file> # Import instincts from others
/instinct-export        # Export your instincts for sharing
/evolve                 # Cluster related instincts into skills
```

请参阅 `skills/continuous-learning-v2/` 以获取完整文档。
仅当您明确希望使用旧版 v1 停止钩子学习技能流程时，才保留 `continuous-learning/`。

---

## 要求

### Claude Code CLI 版本

**最低版本：v2.1.0 或更高**

由于插件系统处理钩子的方式发生了变化，本插件要求 Claude Code CLI 版本为 v2.1.0 及以上。

检查您的版本：
```bash
claude --version
```

### 重要提示：钩子自动加载行为

> 警告：**贡献者注意：** 请勿在 `.claude-plugin/plugin.json` 中添加 `"hooks"` 字段。此项由回归测试强制执行。

Claude 代码 v2.1+ **按约定自动加载** 任何已安装插件中的 `hooks/hooks.json`。在 `plugin.json` 中显式声明会导致重复检测错误：

```
Duplicate hooks file detected: ./hooks/hooks.json resolves to already-loaded file
```

**历史记录：** 这在此仓库中引发了反复的修复/回退循环（[#29](https://github.com/affaan-m/everything-claude-code/issues/29), [#52](https://github.com/affaan-m/everything-claude-code/issues/52), [#103](https://github.com/affaan-m/everything-claude-code/issues/103)）。该行为在 Claude Code 版本之间发生了变化，导致了混淆。我们现在有一个回归测试来防止此问题被重新引入。

---

## 安装

### 选项 1：作为插件安装（推荐）

使用此仓库的最简单方法——作为 Claude Code 插件安装：

```bash
# Add this repo as a marketplace
/plugin marketplace add https://github.com/affaan-m/everything-claude-code

# Install the plugin
/plugin install everything-claude-code@everything-claude-code
```
或者直接添加到你的 `~/.claude/settings.json`：


```json
{
  "extraKnownMarketplaces": {
    "ecc": {
      "source": {
        "source": "github",
        "repo": "affaan-m/everything-claude-code"
      }
    }
  },
  "enabledPlugins": {
    "everything-claude-code@everything-claude-code": true
  }
}
```
这使您可以即时访问所有命令、代理、技能和钩子。

> **注意：** Claude Code 插件系统不支持通过插件分发 `rules`（[上游限制](https://code.claude.com/docs/en/plugins-reference)）。您需要手动安装规则：
>
> ```bash
> # 先克隆仓库
> git clone https://github.com/affaan-m/everything-claude-code.git
>
> # 选项 A：用户级规则（适用于所有项目）
> mkdir -p ~/.claude/rules/ecc
> cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/typescript ~/.claude/rules/ecc/   # 选择您的技术栈
> cp -r everything-claude-code/rules/python ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/golang ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/php ~/.claude/rules/ecc/
>
> # 选项 B：项目级规则（仅适用于当前项目）
> mkdir -p .claude/rules/ecc
> cp -r everything-claude-code/rules/common .claude/rules/ecc/
> cp -r everything-claude-code/rules/typescript .claude/rules/ecc/     # 选择您的技术栈
> ```

---

### 选项 2：手动安装

如果您更喜欢手动控制安装内容：


```bash
# Clone the repo
git clone https://github.com/affaan-m/everything-claude-code.git

# Copy agents to your Claude config
cp everything-claude-code/agents/*.md ~/.claude/agents/

# Copy rules directories (common + language-specific)
mkdir -p ~/.claude/rules/ecc
cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/typescript ~/.claude/rules/ecc/   # pick your stack
cp -r everything-claude-code/rules/python ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/golang ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/php ~/.claude/rules/ecc/

# Copy skills first (primary workflow surface)
# Recommended (new users): core/general skills only
mkdir -p ~/.claude/skills/ecc
cp -r everything-claude-code/.agents/skills/* ~/.claude/skills/ecc/
cp -r everything-claude-code/skills/search-first ~/.claude/skills/ecc/

# Optional: add niche/framework-specific skills only when needed
# for s in django-patterns django-tdd laravel-patterns springboot-patterns; do
# cp -r everything-claude-code/skills/$s ~/.claude/skills/ecc/
# done

# Optional: keep maintained slash-command compatibility during migration
mkdir -p ~/.claude/commands
cp everything-claude-code/commands/*.md ~/.claude/commands/

# Retired shims live in legacy-command-shims/commands/.
# Copy individual files from there only if you still need old names such as /tdd.
```

#### 安装钩子

不要将原始仓库的 `hooks/hooks.json` 复制到 `~/.claude/settings.json` 或 `~/.claude/hooks/hooks.json`。该文件是针对插件/仓库的，应该通过 ECC 安装程序安装或作为插件加载，因此不支持手动原样复制安装。

请使用安装程序仅安装 Claude 钩子运行时，以便命令路径被正确重写：

```bash
# macOS / Linux
bash ./install.sh --target claude --modules hooks-runtime
```

```powershell
# Windows PowerShell
pwsh -File .\install.ps1 --target claude --modules hooks-runtime
```
这会将已解析的钩子写入 `~/.claude/hooks/hooks.json`，并保持任何现有的 `~/.claude/settings.json` 不变。

如果你是通过 `/plugin install` 安装的 ECC，请不要将那些钩子复制到 `settings.json` 中。Claude Code v2.1+ 已经自动加载插件 `hooks/hooks.json`，在 `settings.json` 中重复它们会导致重复执行和跨平台钩子冲突。

Windows 注意事项：Claude 配置目录是 `%USERPROFILE%\\.claude`，而不是 `~/claude`。

#### 配置 MCP

Claude 插件安装故意不自动启用 ECC 捆绑的 MCP 服务器定义。这样可以避免在严格的第三方网关上出现过长的插件 MCP 工具名称，同时保持手动 MCP 设置的可用性。

使用 Claude Code 的 `/mcp` 命令或 CLI 管理的 MCP 设置进行实时 Claude Code 服务器更改。使用 `/mcp` 来禁用 Claude Code 运行时；Claude Code 会将这些选择保存在 `~/.claude.json` 中。

对于仓库本地的 MCP 访问，将所需的 MCP 服务器定义从 `mcp-configs/mcp-servers.json` 复制到项目范围的 `.mcp.json` 中。

如果你已经运行了 ECC 捆绑的 MCP 的自有副本，请设置：


```bash
export ECC_DISABLED_MCPS="github,context7,exa,playwright,sequential-thinking,memory"
```

ECC 管理的安装和 Codex 同步流程将跳过或移除那些捆绑的服务器，而不是重新添加重复的服务器。`ECC_DISABLED_MCPS` 是 ECC 安装/同步过滤器，而非实时 Claude Code 切换。

**重要提示：** 请将 `YOUR_*_HERE` 占位符替换为您的实际 API 密钥。

---

## 关键概念

### 代理

子代理处理有限范围内的委托任务。示例：

```markdown
---
name: code-reviewer
description: Reviews code for quality, security, and maintainability
tools: ["Read", "Grep", "Glob", "Bash"]
model: opus
---

You are a senior code reviewer...
```

### 技能

技能是主要的工作流程界面。它们可以被直接调用，自动建议，并被代理重用。ECC 在迁移期间仍然维护 `commands/`，而已废弃的短名称适配器仅在 `legacy-command-shims/` 下用于显式选择加入。新的工作流程开发应首先放在 `skills/` 中。

```markdown
# TDD Workflow

1. Define interfaces first
2. Write failing tests (RED)
3. Implement minimal code (GREEN)
4. Refactor (IMPROVE)
5. Verify 80%+ coverage
```

### 钩子

钩子在工具事件上触发。示例 - 警告 console.log：

```json
{
  "matcher": "tool == \"Edit\" && tool_input.file_path matches \"\\\\.(ts|tsx|js|jsx)$\"",
  "hooks": [{
    "type": "command",
    "command": "#!/bin/bash\ngrep -n 'console\\.log' \"$file_path\" && echo '[Hook] Remove console.log' >&2"
  }]
}
```

### 规则

规则是始终遵循的指南，组织为 `common/`（语言无关）+ 语言特定目录：

```
rules/
  common/          # Universal principles (always install)
  typescript/      # TS/JS specific patterns and tools
  python/          # Python specific patterns and tools
  golang/          # Go specific patterns and tools
  swift/           # Swift specific patterns and tools
  php/             # PHP specific patterns and tools
```
请参阅[`rules/README.md`](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/rules/README.md)了解安装和结构详情。

---

## 我应该使用哪个代理？

不知道从哪里开始？使用此快速参考。技能是规范的工作流程界面；维护的斜杠条目可用于命令优先的工作流程。

| 我想… | 使用此界面 | 使用的代理 |
|--------------|-----------------|------------|
| 规划新功能 | `/everything-claude-code:plan "Add auth"` | planner |
| 设计系统架构 | `/everything-claude-code:plan` + architect 代理 | architect |
| 先写测试再写代码 | `tdd-workflow` 技能 | tdd-guide |
| 审查我刚写的代码 | `/code-review` | code-reviewer |
| 修复失败的构建 | `/build-fix` | build-error-resolver |
| 运行端到端测试 | `e2e-testing` 技能 | e2e-runner |
| 查找安全漏洞 | `/security-scan` | security-reviewer |
| 删除死代码 | `/refactor-clean` | refactor-cleaner |
| 更新文档 | `/update-docs` | doc-updater |
| 审查 Go 代码 | `/go-review` | go-reviewer |
| 审查 Python 代码 | `/python-review` | python-reviewer |
| 审查 TypeScript/JavaScript 代码 | *(直接调用 `typescript-reviewer`)* | typescript-reviewer |
| 审计数据库查询 | *(自动委派)* | database-reviewer |

### 常见工作流程

下面的斜杠形式显示在它们仍是维护的命令界面的一部分时。已弃用的短名称适配器如 `/tdd` 和 `/eval` 存放在 `legacy-command-shims/` 目录中，仅供显式选择启用。

**开始一个新功能：**

```
/everything-claude-code:plan "Add user authentication with OAuth"
                                              → planner creates implementation blueprint
tdd-workflow skill                            → tdd-guide enforces write-tests-first
/code-review                                  → code-reviewer checks your work
```

**修复一个漏洞：**
```
tdd-workflow skill                            → tdd-guide: write a failing test that reproduces it
                                              → implement the fix, verify test passes
/code-review                                  → code-reviewer: catch regressions
```

**准备生产：**
```
/security-scan                                → security-reviewer: OWASP Top 10 audit
e2e-testing skill                             → e2e-runner: critical user flow tests
/test-coverage                                → verify 80%+ coverage
```

---

## FAQ

<details>
<summary><b>How do I check which agents/commands are installed?</b></summary>

```bash
/plugin list everything-claude-code@everything-claude-code
```
这显示了插件中所有可用的代理、命令和技能。
</details>

<details>
<summary><b>我的钩子不起作用 / 我看到“重复的钩子文件”错误</b></summary>

这是最常见的问题。**请勿在 `.claude-plugin/plugin.json` 中添加 `"hooks"` 字段。** Claude Code v2.1+ 会自动加载已安装插件中的 `hooks/hooks.json`。显式声明会导致重复检测错误。请参阅 [#29](https://github.com/affaan-m/everything-claude-code/issues/29)，[#52](https://github.com/affaan-m/everything-claude-code/issues/52)，[#103](https://github.com/affaan-m/everything-claude-code/issues/103)。
</details>

<details>
<summary><b>我可以在自定义 API 端点或模型网关上使用 ECC 和 Claude Code 吗？</b></summary>

可以。ECC 不硬编码 Anthropic 托管的传输设置。它通过 Claude Code 的常规 CLI/插件界面本地运行，因此它适用于：

- Anthropic 托管的 Claude Code
- 使用 `ANTHROPIC_BASE_URL` 和 `ANTHROPIC_AUTH_TOKEN` 的官方 Claude Code 网关设置
- 支持 Claude Code 期望的 Anthropic API 的兼容自定义端点

最小示例：


```bash
export ANTHROPIC_BASE_URL=https://your-gateway.example.com
export ANTHROPIC_AUTH_TOKEN=your-token
claude
```
如果您的网关重新映射模型名称，请在 Claude Code 中进行配置，而不是在 ECC 中配置。一旦 `claude` 命令行界面正常工作，ECC 的钩子、技能、命令和规则对模型提供者是无关的。

官方参考资料：
- [Claude Code LLM 网关文档](https://docs.anthropic.com/en/docs/claude-code/llm-gateway)
- [Claude Code 模型配置文档](https://docs.anthropic.com/en/docs/claude-code/model-config)

</details>

<details>
<summary><b>我的上下文窗口在缩小 / Claude 正在耗尽上下文</b></summary>

过多的 MCP 服务器会消耗您的上下文。每个 MCP 工具描述都会从您的 20 万窗口中消耗令牌，可能将其减少到约 7 万。SessionStart 上下文默认限制为 8000 个字符；通过 `ECC_SESSION_START_MAX_CHARS=4000` 降低，或在本地模型或低上下文设置中通过 `ECC_SESSION_START_CONTEXT=off` 禁用。

**解决方法：** 使用 `/mcp` 从 Claude Code 禁用未使用的 MCP。Claude Code 会将这些运行时选择写入 `~/.claude.json`；`.claude/settings.json` 和 `.claude/settings.local.json` 对于已加载的 MCP 服务器不是可靠的开关。

保持启用的 MCP 不超过 10 个，激活的工具不超过 80 个。
</details>

<details>
<summary><b>我可以只使用部分组件（例如，仅使用代理）吗？</b></summary>

可以。使用选项 2（手动安装）并只复制您需要的部分：


```bash
# Just agents
cp everything-claude-code/agents/*.md ~/.claude/agents/

# Just rules
mkdir -p ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
```
每个组件都是完全独立的。
</details>

<details>
<summary><b>这是否支持 Cursor / OpenCode / Codex / Antigravity？</b></summary>

支持。ECC 是跨平台的：
- **Cursor**：预翻译配置在 `.cursor/` 中。见 [Cursor IDE 支持](#cursor-ide-support)。
- **Gemini CLI**：通过 `.gemini/GEMINI.md` 和共享安装流程提供实验性项目本地支持。
- **OpenCode**：在 `.opencode/` 中提供完整插件支持。见 [OpenCode 支持](#opencode-support)。
- **Codex**：对 macOS 应用和 CLI 提供一流支持，带有适配器漂移防护和 SessionStart 回退。见 PR [#257](https://github.com/affaan-m/everything-claude-code/pull/257)。
- **Antigravity**：在 `.agent/` 中紧密集成工作流、技能和扁平规则。见 [Antigravity 指南](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ANTIGRAVITY-GUIDE.md)。
- **非原生框架**：Grok 及类似接口的手动回退路径。见 [手动适配指南](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/MANUAL-ADAPTATION-GUIDE.md)。
- **Claude Code**：原生支持——这是主要目标。
</details>

<details>
<summary><b>如何贡献新的技能或代理？</b></summary>

见 [CONTRIBUTING.md](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/CONTRIBUTING.md)。简要版：
1. Fork 仓库
2. 在 `skills/your-skill-name/SKILL.md` 中创建你的技能（带 YAML 前置）
3. 或在 `agents/your-agent.md` 中创建代理
4. 提交带有清晰描述其功能及使用时机的 PR
</details>

---

## 运行测试

插件包含全面的测试套件：


```bash
# Run all tests
node tests/run-all.js

# Run individual test files
node tests/lib/utils.test.js
node tests/lib/package-manager.test.js
node tests/hooks/hooks.test.js
```

---

## 贡献指南

**欢迎并鼓励贡献。**

本仓库旨在成为一个社区资源。如果您有：
- 有用的代理或技能
- 巧妙的钩子
- 更好的MCP配置
- 改进的规则

请贡献！请参见[CONTRIBUTING.md](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/CONTRIBUTING.md)了解指导方针。

### 贡献想法

- 语言特定技能（Rust、C#、Kotlin、Java）— 已包含Go、Python、Perl、Swift和TypeScript
- 框架特定配置（Rails、FastAPI）— 已包含Django、NestJS、Spring Boot和Laravel
- DevOps代理（Kubernetes、Terraform、AWS、Docker）
- 测试策略（不同框架、视觉回归）
- 领域特定知识（机器学习、数据工程、移动端）

### 社区生态说明

这些未与ECC打包且未由本仓库审计，但如果您在探索更广泛的Claude Code技能生态系统，它们值得了解：

- [claude-seo](https://github.com/AgriciDaniel/claude-seo) — 以SEO为重点的技能和代理集合
- [claude-ads](https://github.com/AgriciDaniel/claude-ads) — 广告审核和付费增长工作流集合
- [claude-cybersecurity](https://github.com/AgriciDaniel/claude-cybersecurity) — 安全导向的技能和代理集合

---

## Cursor IDE 支持

ECC 提供 Cursor IDE 支持，包含为 Cursor 项目布局调整的钩子、规则、代理、技能、命令和 MCP 配置。

### 快速开始（Cursor）

```bash
# macOS/Linux
./install.sh --target cursor typescript
./install.sh --target cursor python golang swift php
```

```powershell
# Windows PowerShell
.\install.ps1 --target cursor typescript
.\install.ps1 --target cursor python golang swift php
```
### 包含内容

| 组件 | 数量 | 详情 |
|-----------|-------|---------|
| 钩子事件 | 15 | sessionStart、beforeShellExecution、afterFileEdit、beforeMCPExecution、beforeSubmitPrompt 等 10 个 |
| 钩子脚本 | 16 | 通过共享适配器委托到 `scripts/hooks/` 的轻量级 Node.js 脚本 |
| 规则 | 34 | 9 个通用（alwaysApply）+ 25 个特定语言（TypeScript、Python、Go、Swift、PHP） |
| 代理 | 48 | 安装时位于 `.cursor/agents/ecc-*.md`；加前缀以避免与用户或市场代理冲突 |
| 技能 | 共享 + 捆绑 | 用于翻译增补的 `.cursor/skills/` |
| 命令 | 共享 | 安装时的 `.cursor/commands/` |
| MCP 配置 | 共享 | 安装时的 `.cursor/mcp.json` |

### Cursor 加载说明

ECC 不会将根目录的 `AGENTS.md` 安装到 `.cursor/`。Cursor 将嵌套的 `AGENTS.md` 文件视为目录上下文，因此将 ECC 的仓库身份复制到宿主项目会污染该项目。

Cursor 原生加载行为因版本而异。ECC 将代理安装为 `.cursor/agents/ecc-*.md`；如果你的 Cursor 版本不支持项目代理，这些文件仍可作为显式引用定义，而非隐藏的全局提示上下文。

### 钩子架构（DRY 适配器模式）

Cursor 的钩子事件比 Claude Code 更多（20 vs 8）。`.cursor/hooks/adapter.js` 模块将 Cursor 的 stdin JSON 转换为 Claude Code 格式，允许重用现有的 `scripts/hooks/*.js`，避免重复编写。


```
Cursor stdin JSON → adapter.js → transforms → scripts/hooks/*.js
                                              (shared with Claude Code)
```
关键钩子：  
- **beforeShellExecution** — 阻止 tmux 外的开发服务器（退出码 2），git push 审查  
- **afterFileEdit** — 自动格式化 + TypeScript 检查 + console.log 警告  
- **beforeSubmitPrompt** — 检测提示中的密钥（sk-、ghp_、AKIA 模式）  
- **beforeTabFileRead** — 阻止 Tab 读取 .env、.key、.pem 文件（退出码 2）  
- **beforeMCPExecution / afterMCPExecution** — MCP 审计日志  

### 规则格式  

光标规则使用带有 `description`、`globs` 和 `alwaysApply` 的 YAML frontmatter：


```yaml
---
description: "TypeScript coding style extending common rules"
globs: ["**/*.ts", "**/*.tsx", "**/*.js", "**/*.jsx"]
alwaysApply: false
---
```

---

## Codex macOS 应用程序 + CLI 支持

ECC 为 macOS 应用程序和 CLI 提供**一流的 Codex 支持**，包括参考配置、Codex 专用的 AGENTS.md 补充文档以及共享技能。

### 快速开始（Codex 应用程序 + CLI）

```bash
# Run Codex CLI in the repo — AGENTS.md and .codex/ are auto-detected
codex

# Automatic setup: sync ECC assets (AGENTS.md, skills, MCP servers) into ~/.codex
npm install && bash scripts/sync-ecc-to-codex.sh
# or: pnpm install && bash scripts/sync-ecc-to-codex.sh
# or: yarn install && bash scripts/sync-ecc-to-codex.sh
# or: bun install && bash scripts/sync-ecc-to-codex.sh

# Or manually: copy the reference config to your home directory
cp .codex/config.toml ~/.codex/config.toml
```
同步脚本通过**仅添加**策略安全地将 ECC MCP 服务器合并到您现有的 `~/.codex/config.toml` 中——它从不删除或修改您现有的服务器。使用 `--dry-run` 预览更改，或使用 `--update-mcp` 强制刷新 ECC 服务器到最新推荐配置。

对于 Context7，ECC 使用规范的 Codex 区段名称 `[mcp_servers.context7]`，同时仍启动 `@upstash/context7-mcp` 包。如果您已有遗留的 `[mcp_servers.context7-mcp]` 条目，`--update-mcp` 会将其迁移到规范区段名称。

Codex macOS 应用：
- 将此仓库作为您的工作区打开。
- 根目录的 `AGENTS.md` 会被自动检测。
- `.codex/config.toml` 和 `.codex/agents/*.toml` 最好保持项目本地。
- 参考 `.codex/config.toml` 有意不固定 `model` 或 `model_provider`，因此 Codex 会使用其当前默认设置，除非您覆盖它。
- 可选：将 `.codex/config.toml` 复制到 `~/.codex/config.toml` 以设置全局默认；多代理角色文件保持项目本地，除非您也复制 `.codex/agents/`。

### 包含内容

| 组件 | 数量 | 详情 |
|-----------|-------|---------|
| 配置 | 1 | `.codex/config.toml` — 顶层审批/沙盒/网络搜索，MCP 服务器，通知，配置档 |
| AGENTS.md | 2 | 根目录（通用） + `.codex/AGENTS.md`（Codex 特定补充） |
| 技能 | 32 | `.agents/skills/` — 每个技能的 SKILL.md + agents/openai.yaml |
| MCP 服务器 | 6 | GitHub、Context7、Exa、Memory、Playwright、Sequential Thinking（使用 `--update-mcp` 同步时含 Supabase 共7个） |
| 配置档 | 2 | `strict`（只读沙盒）和 `yolo`（全自动批准） |
| 代理角色 | 3 | `.codex/agents/` — explorer、reviewer、docs-researcher |

### 技能

位于 `.agents/skills/` 的技能由 Codex 自动加载：

规范的 Anthropic 技能如 `claude-api`、`frontend-design` 和 `skill-creator` 故意不在此重新打包。想要官方版本时，请从 [`anthropics/skills`](https://github.com/anthropics/skills) 安装。

| 技能 | 描述 |
|-------|-------------|
| agent-introspection-debugging | 调试代理行为、路由和提示边界 |
| agent-sort | 对代理目录和任务界面进行排序 |
| api-design | REST API 设计模式 |
| article-writing | 从笔记和语音参考撰写长文 |
| backend-patterns | API 设计、数据库、缓存 |
| brand-voice | 从真实内容中提取的写作风格配置文件 |
| bun-runtime | Bun 作为运行时、包管理器、打包器和测试运行器 |
| coding-standards | 通用编码标准 |
| content-engine | 平台原生社交内容及再利用 |

| crosspost | 跨平台内容分发，涵盖 X、LinkedIn、Threads |
| deep-research | 多源研究，包含综合与来源归属 |
| dmux-workflows | 使用 tmux 面板管理器进行多代理编排 |
| documentation-lookup | 通过 Context7 MCP 获取最新的库和框架文档 |
| e2e-testing | Playwright 端到端测试 |
| eval-harness | 基于评估的开发 |
| everything-claude-code | 项目开发规范和模式 |
| exa-search | 通过 Exa MCP 进行神经搜索，涵盖网页、代码和公司研究 |
| fal-ai-media | 图像、视频和音频的统一媒体生成 |
| frontend-patterns | React/Next.js 模式 |
| frontend-slides | HTML 演示文稿，PPTX 转换，视觉风格探索 |
| investor-materials | 演示文稿、备忘录、模型和单页材料 |
| investor-outreach | 个性化联络、跟进及介绍文案 |
| market-research | 带来源归属的市场及竞争对手研究 |
| mcp-server-patterns | 使用 Node/TypeScript SDK 构建 MCP 服务器 |
| nextjs-turbopack | Next.js 16+ 与 Turbopack 增量打包 |
| product-capability | 将产品目标转化为有范围的能力图谱 |
| security-review | 全面安全检查清单 |
| strategic-compact | 上下文管理 |
| tdd-workflow | 测试驱动开发，覆盖率超过 80% |
| verification-loop | 构建、测试、代码检查、类型检查、安全性 |
| video-editing | 使用 FFmpeg 和 Remotion 的 AI 辅助视频编辑工作流 |
| x-api | X/Twitter API 集成，用于发布和分析 |

### 关键限制

Codex 目前**尚未实现 Claude 风格的钩子执行一致性**。ECC 的强制执行基于 `AGENTS.md` 中的指令，支持可选的 `model_instructions_file` 覆盖，以及沙盒/审批设置。

### 多代理支持

当前 Codex 版本支持稳定的多代理工作流。

- 在 `.codex/config.toml` 中启用 `features.multi_agent = true`
- 在 `[agents.<name>]` 下定义角色
- 指向 `.codex/agents/` 目录下的相应文件
- 在 CLI 使用 `/agent` 命令检查或控制子代理

ECC 提供了三个示例角色配置：

| 角色 | 用途 |
|------|---------|
| `explorer` | 编辑前的只读代码库证据收集 |
| `reviewer` | 正确性、安全性及缺失测试审核 |
| `docs_researcher` | 发布/文档变更前的文档和API验证 |

---

## OpenCode 支持

ECC 提供包括插件和钩子在内的**完整 OpenCode 支持**。

### 快速开始

```bash
# Install OpenCode
npm install -g opencode

# Run in the repository root
opencode
```
配置自动从 `.opencode/opencode.json` 中检测。

### 功能对比

| 功能 | Claude Code | OpenCode | 状态 |
|---------|-------------|----------|--------|
| 代理 | 通过：48 个代理 | 通过：12 个代理 | **Claude Code 领先** |
| 命令 | 通过：68 条命令 | 通过：31 条命令 | **Claude Code 领先** |
| 技能 | 通过：182 项技能 | 通过：37 项技能 | **Claude Code 领先** |
| 钩子 | 通过：8 种事件类型 | 通过：11 个事件 | **OpenCode 更多！** |
| 规则 | 通过：29 条规则 | 通过：13 条指令 | **Claude Code 领先** |
| MCP 服务器 | 通过：14 台服务器 | 通过：全部 | **完全一致** |
| 自定义工具 | 通过：钩子实现 | 通过：6 个原生工具 | **OpenCode 更优** |

### 通过插件支持钩子

OpenCode 的插件系统比 Claude Code 更加复杂，支持 20+ 事件类型：

| Claude Code 钩子 | OpenCode 插件事件 |
|-----------------|----------------------|
| PreToolUse | `tool.execute.before` |
| PostToolUse | `tool.execute.after` |
| Stop | `session.idle` |
| SessionStart | `session.created` |
| SessionEnd | `session.deleted` |

**额外的 OpenCode 事件**：`file.edited`、`file.watcher.updated`、`message.updated`、`lsp.client.diagnostics`、`tui.toast.show` 等。

### 维护的斜杠命令条目

| 命令 | 描述 |
|---------|-------------|
| `/plan` | 创建实施计划 |
| `/code-review` | 代码变更审查 |
| `/build-fix` | 修复构建错误 |
| `/refactor-clean` | 清理无用代码 |
| `/learn` | 从会话中提取模式 |
| `/checkpoint` | 保存验证状态 |
| `/quality-gate` | 运行维护的验证门控 |

| `/update-docs` | 更新文档 |
| `/update-codemaps` | 更新代码映射 |
| `/test-coverage` | 分析覆盖率 |
| `/go-review` | Go 代码审查 |
| `/go-test` | Go 测试驱动开发流程 |
| `/go-build` | 修复 Go 构建错误 |
| `/python-review` | Python 代码审查（PEP 8，类型提示，安全性） |
| `/multi-plan` | 多模型协作规划 |
| `/multi-execute` | 多模型协作执行 |
| `/multi-backend` | 后端聚焦多模型工作流 |
| `/multi-frontend` | 前端聚焦多模型工作流 |
| `/multi-workflow` | 完整多模型开发工作流 |
| `/pm2` | 自动生成 PM2 服务命令 |
| `/sessions` | 管理会话历史 |
| `/skill-create` | 从 git 生成技能 |
| `/instinct-status` | 查看已学习的本能 |
| `/instinct-import` | 导入本能 |
| `/instinct-export` | 导出本能 |
| `/evolve` | 将本能聚类为技能 |
| `/promote` | 将项目本能提升到全局范围 |
| `/projects` | 列出已知项目及本能统计 |
| `/prune` | 删除过期的待处理本能（30天生存时间） |
| `/learn-eval` | 提取并评估模式后保存 |
| `/setup-pm` | 配置包管理器 |
| `/harness-audit` | 审计测试框架可靠性、评估准备度和风险状态 |
| `/loop-start` | 启动受控的代理循环执行模式 |
| `/loop-status` | 检查活动循环状态和检查点 |
| `/quality-gate` | 运行路径或整个仓库的质量关检查 |
| `/model-route` | 按复杂度和预算将任务路由到模型 |

### 插件安装

**选项 1：直接使用**
```bash
cd everything-claude-code
opencode
```

**选项 2：作为 npm 包安装**
```bash
npm install ecc-universal
```

然后将以下内容添加到您的 `opencode.json` 中：
```json
{
  "plugin": ["ecc-universal"]
}
```
该 npm 插件入口启用了 ECC 发布的 OpenCode 插件模块（钩子/事件和插件工具）。  
它**不**会自动将 ECC 的完整命令/代理/指令目录添加到您的项目配置中。  

要完成完整的 ECC OpenCode 设置，可以：  
- 在此仓库内运行 OpenCode，或  
- 将打包好的 `.opencode/` 配置资源复制到您的项目中，并在 `opencode.json` 中连接 `instructions`、`agent` 和 `command` 条目  

### 文档  

- **迁移指南**：`.opencode/MIGRATION.md`  
- **OpenCode 插件自述文件**：`.opencode/README.md`  
- **汇总规则**：`.opencode/instructions/INSTRUCTIONS.md`  
- **LLM 文档**：`llms.txt`（完整的 LLM OpenCode 文档）  

---  

## 跨工具功能一致性  

ECC 是**第一个最大化利用每个主流 AI 编码工具的插件**。以下是各个工具的功能对比：  

| 功能 | Claude Code | Cursor IDE | Codex CLI | OpenCode |  
|---------|------------|------------|-----------|----------|  
| **代理** | 48 | 共享（AGENTS.md） | 共享（AGENTS.md） | 12 |  
| **命令** | 68 | 共享 | 基于指令 | 31 |  
| **技能** | 182 | 共享 | 10（原生格式） | 37 |  
| **钩子事件** | 8 种 | 15 种 | 尚无 | 11 种 |  
| **钩子脚本** | 20+ 脚本 | 16 脚本（DRY 适配器） | 不适用 | 插件钩子 |  
| **规则** | 34（通用 + 语言） | 34（YAML frontmatter） | 基于指令 | 13 条指令 |  
| **自定义工具** | 通过钩子 | 通过钩子 | 不适用 | 6 个原生工具 |  
| **MCP 服务器** | 14 | 共享（mcp.json） | 7（通过 TOML 解析器自动合并） | 完整 |  
| **配置格式** | settings.json | hooks.json + rules/ | config.toml | opencode.json |  
| **上下文文件** | CLAUDE.md + AGENTS.md | AGENTS.md | AGENTS.md | AGENTS.md |  
| **秘密检测** | 基于钩子 | beforeSubmitPrompt 钩子 | 基于沙箱 | 基于钩子 |  
| **自动格式化** | PostToolUse 钩子 | afterFileEdit 钩子 | 不适用 | file.edited 钩子 |  
| **版本** | 插件 | 插件 | 参考配置 | 2.0.0-rc.1 |  

**关键架构决策：**  
- 根目录的 **AGENTS.md** 是通用的跨工具文件（被所有 4 个工具读取）  
- **DRY 适配器模式** 使 Cursor 能复用 Claude Code 的钩子脚本，避免重复

- **技能格式**（带有 YAML 前置内容的 SKILL.md）适用于 Claude Code、Codex 和 OpenCode
- Codex 缺乏钩子功能，但通过 `AGENTS.md`、可选的 `model_instructions_file` 覆盖以及沙箱权限进行补偿

---

## 背景

自实验性推出以来，我一直在使用 Claude Code。2025 年 9 月与 [@DRodriguezFX](https://x.com/DRodriguezFX) 一起赢得了 Anthropic x Forum Ventures 黑客马拉松——完全使用 Claude Code 构建了 [zenith.chat](https://zenith.chat)。

这些配置经过多个生产应用的实战检验。

---

## 令牌优化

如果不管理令牌消耗，使用 Claude Code 可能会很昂贵。这些设置显著降低成本，同时不牺牲质量。

### 推荐设置

添加到 `~/.claude/settings.json`：

```json
{
  "model": "sonnet",
  "env": {
    "MAX_THINKING_TOKENS": "10000",
    "CLAUDE_AUTOCOMPACT_PCT_OVERRIDE": "50"
  }
}
```
| 设置 | 默认值 | 推荐值 | 影响 |
|---------|---------|-------------|--------|
| `model` | opus | **sonnet** | 约60%的成本降低；处理80%以上的编码任务 |
| `MAX_THINKING_TOKENS` | 31,999 | **10,000** | 每次请求隐性思考成本约减少70% |
| `CLAUDE_AUTOCOMPACT_PCT_OVERRIDE` | 95 | **50** | 更早压缩 — 长会话中质量更好 |

仅在需要深入架构推理时切换到Opus：

```
/model opus
```
### 日常工作命令

| 命令 | 使用时机 |
|---------|-------------|
| `/model sonnet` | 大多数任务的默认模型 |
| `/model opus` | 复杂架构、调试、深度推理时使用 |
| `/clear` | 在无关任务之间（免费，瞬时重置） |
| `/compact` | 在逻辑任务断点（研究完成，里程碑达成）时使用 |
| `/cost` | 会话期间监控令牌消耗 |

### 战略性压缩

`strategic-compact` 技能（包含在此插件中）建议在逻辑断点使用 `/compact`，而不是依赖于 95% 上下文时自动压缩。完整决策指南见 `skills/strategic-compact/SKILL.md`。

**何时压缩：**
- 研究/探索后，实施前
- 完成里程碑后，开始下一个之前
- 调试后，继续功能工作之前
- 失败的方法后，尝试新方法前

**何时不压缩：**
- 实施中（会丢失变量名、文件路径、部分状态）

### 上下文窗口管理

**关键：** 不要一次启用所有 MCP。每个 MCP 工具描述都会消耗你 20 万令牌窗口中的令牌，可能将其减少至约 7 万。

- 每个项目保持启用 MCP 不超过 10 个
- 保持激活工具不超过 80 个
- 使用 `/mcp` 禁用未使用的 Claude Code MCP 服务器；这些运行时选择保存在 `~/.claude.json`
- 仅在安装/同步流程中过滤 ECC 生成的 MCP 配置时使用 `ECC_DISABLED_MCPS`

### 代理团队成本警告

代理团队会生成多个上下文窗口。每个队友独立消耗令牌。仅在并行提供明显价值的任务中使用（多模块工作、并行审查）。对于简单的顺序任务，子代理更节省令牌。

---

## 警告：重要提示


### 令牌优化

达到每日限制了吗？请参阅 **[令牌优化指南](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/token-optimization.md)** 获取推荐设置和工作流程技巧。

快速提升：

```json
// ~/.claude/settings.json
{
  "model": "sonnet",
  "env": {
    "MAX_THINKING_TOKENS": "10000",
    "CLAUDE_AUTOCOMPACT_PCT_OVERRIDE": "50",
    "CLAUDE_CODE_SUBAGENT_MODEL": "haiku"
  }
}
```
使用 `/clear` 分隔不相关的任务，使用 `/compact` 在逻辑断点处，使用 `/cost` 来监控支出。

### 自定义

这些配置适用于我的工作流程。你应该：
1. 从与你共鸣的开始
2. 根据你的技术栈修改
3. 删除你不使用的部分
4. 添加你自己的模式

---

## 社区项目

基于或受 Everything Claude Code 启发的项目：

| 项目 | 描述 |
|---------|-------------|
| [EVC](https://github.com/SaigonXIII/evc) | 营销代理工作区 — 为内容运营、品牌治理和多渠道发布提供42个命令。 [视觉概览](https://saigonxiii.github.io/evc)。 |

用 ECC 构建了什么？提交 PR 将其添加到这里。

---

## 赞助商

该项目免费且开源。赞助商帮助保持项目维护和发展。

[**成为赞助商**](https://github.com/sponsors/affaan-m) | [赞助等级](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/SPONSORS.md) | [赞助计划](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/SPONSORING.md)

---

## 星标历史

[![星标历史图表](https://api.star-history.com/svg?repos=affaan-m/everything-claude-code&type=Date)](https://star-history.com/#affaan-m/everything-claude-code&Date)

---

## 链接

- **速查指南（从这里开始）：** [Everything Claude Code 速查指南](https://x.com/affaanmustafa/status/2012378465664745795)
- **详细指南（高级）：** [Everything Claude Code 详细指南](https://x.com/affaanmustafa/status/2014040193557471352)
- **安全指南：** [安全指南](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./the-security-guide.md) | [讨论帖](https://x.com/affaanmustafa/status/2033263813387223421)
- **关注：** [@affaanmustafa](https://x.com/affaanmustafa)

---

## 许可证

MIT - 可自由使用，按需修改，如有可能欢迎贡献。

---

**如果本仓库对你有帮助，请点星。阅读两份指南。创造伟大作品。**



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---