<h1 align="center"><img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="" width="64" style="vertical-align: middle;">&nbsp; CLI-Anything：让所有软件成为智能代理原生支持</h1>

<p align="center">
  <strong>今天的软件服务于人类👨‍💻。明天的用户将是智能代理🤖。<br>
CLI-Anything：架起AI智能代理与世界软件之间的桥梁</strong><br>
</p>

**🌐 [CLI-Hub](https://hkuds.github.io/CLI-Anything/)**：探索所有社区构建的CLI，并通过一条命令安装，尽在 **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)**。想添加你自己的？[提交PR](https://github.com/HKUDS/CLI-Anything/blob/main/CONTRIBUTING.md) — 中心会即时更新。

<p align="center">
  <a href="#-quick-start"><img src="https://img.shields.io/badge/Quick_Start-5_min-blue?style=for-the-badge" alt="Quick Start"></a>
  <a href="https://hkuds.github.io/CLI-Anything/"><img src="https://img.shields.io/badge/CLI_Hub-Browse_%26_Install-ff69b4?style=for-the-badge" alt="CLI Hub"></a>
  <a href="#-demonstrations"><img src="https://img.shields.io/badge/Demos-16_Apps-green?style=for-the-badge" alt="Demos"></a>
  <a href="#-test-results"><img src="https://img.shields.io/badge/Tests-1%2C839_Passing-brightgreen?style=for-the-badge" alt="Tests"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" alt="License"></a>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/python-≥3.10-blue?logo=python&logoColor=white" alt="Python">
  <img src="https://img.shields.io/badge/click-≥8.0-green" alt="Click">
  <img src="https://img.shields.io/badge/pytest-100%25_pass-brightgreen" alt="Pytest">
  <img src="https://img.shields.io/badge/coverage-unit_%2B_e2e-orange" alt="Coverage">
  <img src="https://img.shields.io/badge/output-JSON_%2B_Human-blueviolet" alt="Output">
  <a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/Feishu-Group-E9DBFC?style=flat&logo=feishu&logoColor=white" alt="Feishu"></a>
<a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/WeChat-Group-C5EAB4?style=flat&logo=wechat&logoColor=white" alt="WeChat"></a>
</p>

**一条命令行**：让任何软件为 OpenClaw、nanobot、Cursor、Claude Code 等智能代理准备就绪。&nbsp;&nbsp;[**中文文档**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_CN.md) | [**日本語ドキュメント**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_JA.md)

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/cli-typing.gif" alt="CLI-Anything typing demo" width="800">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/teaser.png" alt="CLI-Anything Teaser" width="800">
</p>

---

## 📰 新闻

> 感谢社区所有宝贵的努力！每天都有更多持续更新……

- **2026-03-23** 🤖 发布了 **CLI-Hub meta-skill** —— 代理现在可以通过 [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md) 自主发现并安装 CLI。目录通过 GitHub Actions 从 `registry.json` 自动更新，使整个市场成为代理原生。

- **2026-03-22** 🎵 **MuseScore CLI** 合并了转调、导出和乐器管理功能。社区贡献继续扩大领域覆盖。

- **2026-03-21** 🔧 基础设施改进 —— 优化了多个 CLI 的测试工具和文档。增强了多个后端的 Windows 兼容性。

- **2026-03-20** 🌐 新增支持 OpenAI 兼容 API 访问的 **Novita AI** CLI。注册表元数据改进以提升中心发现能力。

- **2026-03-19** 📦 各测试工具包结构优化。改进了 SKILL.md 生成，提升命令文档质量。

- **2026-03-18** 🧪 扩展测试覆盖 —— 增加了多个 CLI 的端到端场景和边缘情况验证。

- **2026-03-17** 🌐 发布了 **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)** —— 一个中心注册表，你可以浏览、搜索并通过单条 `pip` 命令安装任意 CLI。贡献者只需提交包含 `registry.json` 条目的 PR 即可新增或更新 CLI。中心合并后自动更新。

<details>
<summary>更早新闻</summary>

- **2026-03-16** 🤖 新增 **SKILL.md 生成**（阶段 6.5）—— 每个生成的 CLI 现在都附带 AI 可发现的技能定义文件，嵌入 Python 包内。ReplSkin 在 `pip install` 后自动检测技能文件，REPL 横幅显示技能文件绝对路径以供代理使用。包含 `skill_generator.py`、Jinja2 模板、所有 setup.py 文件中的 `package_data` 以及 51 个新测试。

- **2026-03-15** 🐾 社区支持 **OpenClaw**！合并了 Windows 下的 `cygpath` 保护，确保 CLI-Anything 在 Windows bash 环境中可靠运行。社区贡献持续增强跨平台支持。

- **2026-03-14** 🔒 修复了 GIMP Script-Fu 路径注入漏洞，新增 **日语 README** 翻译。OpenCode 版本需求文档化，同时改进了多个 Windows 兼容性问题。

- **2026-03-13** 🔌 **Qodercli** 插件正式合并，作为社区贡献附带专用安装脚本。Codex 技能新增 Windows 安装脚本，项目中清理了占位 URL。

- **2026-03-12** 📦 集成了 **Codex 技能**，使 CLI-Anything 支持另一个 AI 编码平台。新增 Qodercli 支持，文档更新了限制和实验标签。

- **2026-03-11** 📞 新增第 11 个支持应用 —— **Zoom** 视频会议测试工具。多个社区修复发布，涵盖 Shotcut 自动保存、LibreOffice Windows/macOS 后端及 OpenCode 支持。

</details>

---

## 🤔 为什么选择 CLI？

CLI 是人类和 AI 代理通用的接口：

• **结构化且可组合** - 文本命令符合大语言模型格式并支持链式复杂工作流

• **轻量且通用** - 最小开销，跨所有系统无依赖运行

• **自描述** - --help 标志提供自动文档，代理可发现

• **验证成功** - Claude Code 每天通过 CLI 运行数千个真实工作流

• **以代理为先的设计** - 结构化 JSON 输出消除解析复杂性

• **确定且可靠** - 结果一致，支持可预测的代理行为

## 🚀 快速开始

### 前提条件

- **Python 3.10+**
- 安装目标软件（例如 GIMP、Blender、LibreOffice 或您自己的应用）
- 支持的 AI 编码代理：[Claude Code](#-claude-code) | [OpenClaw](#-openclaw) | [OpenCode](#-opencode) | [Codex](#-codex) | [Qodercli](#-qodercli) | [GitHub Copilot CLI](#-github-copilot-cli) | [更多平台](#-more-platforms-coming-soon)

### 选择您的平台

<details open>
<summary><h4 id="-claude-code">⚡ Claude Code</h4></summary>

**步骤 1：添加市场**

CLI-Anything 作为 Claude Code 插件市场发布，托管在 GitHub 上。

```bash
# Add the CLI-Anything marketplace
/plugin marketplace add HKUDS/CLI-Anything
```

**步骤 2：安装插件**

```bash
# Install the cli-anything plugin from the marketplace
/plugin install cli-anything
```

就是这样。插件现在可在您的 Claude Code 会话中使用。

> **Windows 用户注意：** Claude Code 通过 `bash` 运行 shell 命令。Windows 上，请安装 Git for Windows（包括 `bash` 和
`cygpath`）或使用 WSL；否则命令可能会因找不到 `cygpath` 命令而失败。

**步骤 3：一条命令构建 CLI**

```bash
# /cli-anything:cli-anything <software-path-or-repo>
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything:cli-anything ./gimp

# Note: If your Claude Code is under 2.x, use "/cli-anything" instead.
```
这将运行完整的流程：
1. 🔍 **分析** — 扫描源代码，将 GUI 操作映射到 API
2. 📐 **设计** — 架构命令组、状态模型、输出格式
3. 🔨 **实现** — 构建带 REPL、JSON 输出、撤销/重做功能的 Click CLI
4. 📋 **测试计划** — 创建包含单元测试和端到端测试计划的 TEST.md
5. 🧪 **编写测试** — 实现全面的测试套件
6. 📝 **文档** — 使用结果更新 TEST.md
7. 📦 **发布** — 创建 `setup.py`，安装到 PATH

**步骤 4（可选）：完善和改进 CLI**

初步构建后，你可以迭代完善 CLI，扩展覆盖范围并添加缺失功能：


```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything:refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything:refine ./gimp "I want more CLIs on image batch processing and filters"
```

refine 命令执行软件完整功能与当前 CLI 覆盖之间的差距分析，然后针对识别出的缺口实现新命令、测试和文档。您可以多次运行它，以稳步扩展覆盖范围——每次运行都是增量且无破坏性的。

<details>
<summary><strong>替代方案：手动安装</strong></summary>

如果您不想使用市场：

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Copy plugin to Claude Code plugins directory
cp -r CLI-Anything/cli-anything-plugin ~/.claude/plugins/cli-anything

# Reload plugins
/reload-plugins
```

</details>

</details>

<details>
<summary><h4 id="-opencode">⚡ OpenCode（实验性）</h4></summary>

**步骤 1：安装命令**

> **注意：** 请升级到最新的 OpenCode。旧版本可能使用不同的命令路径。

将 CLI-Anything 命令**和**`HARNESS.md`复制到你的 OpenCode 命令目录：

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Global install (available in all projects)
cp CLI-Anything/opencode-commands/*.md ~/.config/opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md ~/.config/opencode/commands/

# Or project-level install
cp CLI-Anything/opencode-commands/*.md .opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md .opencode/commands/
```

> **注意：** `HARNESS.md` 是所有命令参考的方法规范。它必须与命令位于同一目录下。

这增加了 5 个斜杠命令：`/cli-anything`，`/cli-anything-refine`，`/cli-anything-test`，`/cli-anything-validate` 和 `/cli-anything-list`。

**步骤 2：一条命令构建 CLI**

```bash
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything ./gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender
```
命令作为子任务运行，并遵循与Claude Code相同的7阶段方法。

**步骤3（可选）：优化和改进命令行界面**


```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything-refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything-refine ./gimp "batch processing and filters"
```

</details>

<details>
<summary><h4 id="-goose">⚡ Goose（桌面版 / 命令行界面）<sup><code>实验性</code></sup> <sup><code>社区版</code></sup></h4></summary>

**步骤 1：安装 Goose**

根据您操作系统的官方 Goose 指南安装 Goose（桌面版或命令行界面）。

**步骤 2：配置命令行界面提供者**

配置 Goose 使用命令行界面提供者，如 Claude Code，并确保命令行界面已安装且已认证。

**步骤 3：在 Goose 会话中使用 CLI-Anything**

一旦 Goose 配置完成，启动会话并使用上述针对 Claude Code 描述的相同 CLI-Anything 命令，例如：

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
```

> 注意：当 Goose 通过 CLI 提供程序运行时，它使用该提供程序的功能和命令格式。
</details>

<details>

<summary><h4 id="-qodercli">⚡ Qodercli <sup><code>社区版</code></sup></h4></summary>

**步骤 1：注册插件**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
bash CLI-Anything/qoder-plugin/setup-qodercli.sh
```

这将在 `~/.qoder.json` 中注册 cli-anything 插件。注册后启动一个新的 Qodercli 会话。

**步骤 2：从 Qodercli 使用 CLI-Anything**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```
</details>

<details>

<summary><h4 id="-openclaw">⚡ OpenClaw <sup><code>社区</code></sup></h4></summary>

**步骤 1：安装技能**

CLI-Anything 提供了一个原生的 OpenClaw `SKILL.md` 文件。将其复制到你的 OpenClaw 技能目录：

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install to the global skills folder
mkdir -p ~/.openclaw/skills/cli-anything
cp CLI-Anything/openclaw-skill/SKILL.md ~/.openclaw/skills/cli-anything/SKILL.md
```

**步骤 2：构建 CLI**

现在你可以在 OpenClaw 中调用该技能：

`@cli-anything build a CLI for ./gimp`

该技能遵循与 Claude Code 和 OpenCode 相同的七阶段方法论。

</details>

<details>

<summary><h4 id="-codex">⚡ Codex <sup><code>实验性</code></sup> <sup><code>社区版</code></sup></h4></summary>

**步骤 1：安装技能**

运行捆绑安装程序：

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install the skill
bash CLI-Anything/codex-skill/scripts/install.sh
```
在 Windows PowerShell 上，使用：


```powershell
.\CLI-Anything\codex-skill\scripts\install.ps1
```

这将技能安装到 `$CODEX_HOME/skills/cli-anything`（如果未设置 `CODEX_HOME`，则安装到 `~/.codex/skills/cli-anything`）。

安装后重启 Codex，以便其被识别。

**步骤2：在 Codex 中使用 CLI-Anything**

用自然语言描述任务，例如：

```text
Use CLI-Anything to build a harness for ./gimp
Use CLI-Anything to refine ./shotcut for picture-in-picture workflows
Use CLI-Anything to validate ./libreoffice
```

Codex 技能采用了与 Claude Code 插件和
OpenCode 命令相同的方法，同时保持生成的 Python 框架格式不变。
</details>

<details>

<summary><h4 id="-github-copilot-cli">⚡ GitHub Copilot CLI <sup><code>社区</code></sup></h4></summary>

**步骤 1：安装插件**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
cd CLI-Anything
copilot plugin install ./cli-anything-plugin
```

这将向 GitHub Copilot CLI 安装 CLI-Anything 插件。该插件现在应可在您的 GitHub Copilot CLI 会话中使用。

**步骤 2：从 GitHub Copilot CLI 使用 CLI-Anything**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```

</details>

<details>
<summary><h4 id="-more-platforms-coming-soon">🔮 更多平台（即将推出）</h4></summary>

CLI-Anything 设计为平台无关。计划支持更多 AI 编码代理：

- **Codex** — 通过捆绑技能 `codex-skill/` 提供
- **Cursor** — 即将推出
- **Windsurf** — 即将推出
- **您喜欢的工具** — 欢迎贡献！请参阅 `opencode-commands/` 目录中的参考实现。

</details>

### 使用生成的 CLI

无论您使用哪个平台构建，生成的 CLI 都以相同方式工作：

```bash
# Install to PATH
cd gimp/agent-harness && pip install -e .

# Use from anywhere
cli-anything-gimp --help
cli-anything-gimp project new --width 1920 --height 1080 -o poster.json
cli-anything-gimp --json layer add -n "Background" --type solid --color "#1a1a2e"

# Enter interactive REPL
cli-anything-gimp
```

每个已安装的 CLI 都包含一个位于 Python 包内的 [`SKILL.md`](#-skillmd-generation) 文件（路径为 `cli_anything/<software>/skills/SKILL.md`）。REPL 横幅会自动显示该文件的绝对路径，方便 AI 代理准确读取技能定义。无需额外配置 —— `pip install` 即可使技能被发现。

---

## 🤖 用 CLI-Hub 赋能您的代理

CLI-Hub 让代理能够自主发现并安装所需的 CLI —— 完全无需人工干预。

我们发布了一个 **元技能**，使任何 AI 代理都能自由浏览社区 CLI 的完整目录，并为任务选择合适的工具。

**一条命令安装：**

```bash
# OpenClaw
openclaw skills install cli-anything-hub

# nanobot
nanobot skills install cli-anything-hub
```
**然后只需提示您的代理：**


```
Find appropriate CLI software in CLI-Hub and complete the task: <your task here>
```
代理将浏览目录，安装适合任务的 CLI，并使用它——全部自主完成。

**底层工作原理：**

1. 元技能指向实时目录 [`https://hkuds.github.io/CLI-Anything/SKILL.txt`](https://hkuds.github.io/CLI-Anything/SKILL.txt)
2. 代理读取按类别组织的 20 多个 CLI 及其一行 `pip install` 命令
3. 代理安装适合任务的 CLI，然后读取该 CLI 自身的 SKILL.md 以获得详细用法

目录在 `registry.json` 更改时自动更新——新的社区 CLI 会自动出现。

> **针对 Claude Code 用户：** 将 [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md) 复制到您的项目或技能目录，实现相同的自动 CLI 发现。

---

## 💡 CLI-Anything 的愿景：构建代理原生软件

• 🌐 **通用访问** - 每个软件通过结构化 CLI 即刻变为代理可控。

• 🔗 **无缝集成** - 代理无需 API、GUI、重建或复杂封装即可控制任何应用。

• 🚀 **面向未来的生态系统** - 一条命令将人类设计的软件转变为代理原生工具。

---

## 🔧 何时使用 CLI-Anything

| 分类 | 如何实现代理原生 | 典型示例 |
|----------|----------------------|----------|
| **📂 GitHub 仓库** | 通过自动生成 CLI，将任何开源项目转变为代理可控工具 | VSCodium、WordPress、Calibre、Zotero、Joplin、Logseq、Penpot、Super Productivity |
| **🤖 AI/ML 平台** | 通过结构化命令自动化模型训练、推理流程和超参数调优 | Stable Diffusion WebUI、ComfyUI、Ollama、InvokeAI、Text-generation-webui、Open WebUI、Fooocus、Kohya_ss、AnythingLLM、SillyTavern |
| **📊 数据与分析** | 实现程序化数据处理、可视化和统计分析工作流 | JupyterLab、Apache Superset、Metabase、Redash、DBeaver、KNIME、Orange、OpenSearch Dashboards、Lightdash |
| **💻 开发工具** | 通过命令接口简化代码编辑、构建、测试和部署流程 | Jenkins、Gitea、Hoppscotch、Portainer、pgAdmin、SonarQube、ArgoCD、OpenLens、Insomnia、Beekeeper Studio、**[iTerm2](https://iterm2.com)** |
| **🎨 创意与媒体** | 通过程序控制内容创建、编辑和渲染工作流 | Blender、GIMP、OBS Studio、Audacity、Krita、Kdenlive、Shotcut、Inkscape、Darktable、LMMS、Ardour |
| **🔬 科学计算** | 自动化研究工作流、模拟和复杂计算 | ImageJ、FreeCAD、QGIS、ParaView、Gephi、LibreCAD、Stellarium、KiCad、JASP、Jamovi |
| **🏢 企业与办公** | 将业务应用和生产力工具转为代理可访问系统 | NextCloud、GitLab、Grafana、Mattermost、LibreOffice、AppFlowy、NocoDB、Odoo（社区版）、Plane、ERPNext |
| **📞 通信与协作** | 通过结构化 CLI 自动化会议安排、参与者管理、录音检索和报告 | Zoom、Jitsi Meet、BigBlueButton、Mattermost |
| **📐 图表与可视化** | 程序化创建和操作图表、流程图、架构图及视觉文档 | Draw.io（diagrams.net）、Mermaid、PlantUML、Excalidraw、yEd |
| **🌐 网络与基础设施** | 通过结构化 CLI 命令管理网络服务、DNS、广告拦截和基础设施 | AdGuardHome |
| **🔬 图形与 GPU 调试** | 分析 GPU 帧捕获、检查管线状态、导出着色器及渲染状态差异 | RenderDoc |

| **✨ AI 内容生成** | 通过 AI 驱动的云端 API 生成专业交付物（幻灯片、文档、图表、网站、研究报告） | [AnyGen](https://www.anygen.io), Gamma, Beautiful.ai, Tome |

---

## CLI-Anything 的主要功能

### 代理与软件的鸿沟
AI 代理擅长推理，但非常难以使用真正的专业软件。现有方案依赖脆弱的 UI 自动化、有限的 API，或是功能大幅缩水的简化实现。

**CLI-Anything 的解决方案**：将任何专业软件转变为代理原生工具，功能不打折扣。

| **当前痛点** | **CLI-Anything 的解决方案** |
|----------|----------------------|
| 🤖 “AI 不能使用真正的工具” | 直接集成真实软件后端（Blender、LibreOffice、FFmpeg）——全功能专业能力，零妥协 |
| 💸 “UI 自动化经常崩溃” | 无截图、无点击、无 RPA 脆弱性。纯命令行可靠性，结构化接口 |
| 📊 “代理需要结构化数据” | 内置 JSON 输出，便于代理无缝使用 + 人类可读格式用于调试 |
| 🔧 “定制集成成本高” | 一个 Claude 插件通过成熟的七阶段流水线自动为任意代码库生成 CLI |
| ⚡ “原型与生产差距大” | 1,839+ 测试，真实软件验证。16 个主流应用中经过实战考验 |

---

## 🎯 使用 CLI-Anything 可以做什么？

<table>
<tr>
<td width="33%">

### 🛠️ 让代理接管你的工作流程

专业或日常——只需将代码库投递到 `/cli-anything`。GIMP、Blender、Shotcut 用于创意工作。LibreOffice、OBS Studio 用于日常任务。没有源代码？找开源替代品投进去。你会立即得到一个代理可用的完整 CLI。

</td>
<td width="33%">

### 🔗 将分散的 API 统一为一个 CLI

厌倦了应付碎片化的网络服务 API？将文档或 SDK 手稿输入 `/cli-anything`，你的代理将获得一个**强大且有状态的 CLI**，将各个端点包装成连贯的命令组。一个工具代替数十个原始 API 调用——更强功能且节省令牌。

</td>
<td width="33%">

### 🚀 替代或强化 GUI 代理

CLI-Anything 可以彻底**替代基于 GUI 的代理方法**——无需再截图，无需脆弱的像素点击。但有趣的是：一旦你对 GUI 软件使用 `/cli-anything`，你就可以**完全通过代码和终端合成代理任务、评估器和基准测试**——全自动、可迭代优化、效率大幅提升。

</td>
</tr>
</table>

---

## ✨ ⚙️ CLI-Anything 的工作原理

<table>
<tr>
<td width="50%">

### 🏗️ 完全自动化的七阶段流程
从代码库分析到 PyPI 发布——插件完全自动处理架构设计、实现、测试计划、测试编写和文档。

</td>
<td width="50%">

### 🎯 真实的软件集成
直接调用真实应用进行实际渲染。LibreOffice 生成 PDF，Blender 渲染 3D 场景，Audacity 通过 sox 处理音频。**零妥协**，**零玩具实现**。

</td>
</tr>
<tr>
<td width="50%">

### 🔁 智能会话管理
持久化项目状态，支持撤销/重做功能，统一的 REPL 界面（ReplSkin）在所有 CLI 中提供一致的交互体验。

</td>
<td width="50%">

### 📦 零配置安装
简单的 pip install -e . 命令将 cli-anything-<software> 直接放入 PATH。代理通过标准的 which 命令发现工具。无需设置，无需包装。

</td>
</tr>
<tr>
<td width="50%">

### 🧪 生产级测试
多层次验证：使用合成数据的单元测试，使用真实文件和软件的端到端测试，以及安装命令的 CLI 子进程验证。

</td>
<td width="50%">

### 🐍 清晰的包架构
所有 CLI 组织在 cli_anything.* 命名空间下——无冲突，可通过 pip 安装，命名一致：cli-anything-gimp、cli-anything-blender 等。

</td>
</tr>
</table>

### 🤖 SKILL.md 生成

每个生成的 CLI 在 Python 包的 `cli_anything/<software>/skills/SKILL.md` 中包含一个 `SKILL.md` 文件。这个自包含的技能定义使 AI 代理能够通过 Claude Code 的技能系统或其他代理框架发现并使用该 CLI。

**SKILL.md 提供：**
- **YAML frontmatter**，包含名称和描述，方便代理技能发现
- **命令组**，记录所有可用的子命令
- **使用示例**，涵盖常见工作流程
- **代理专用指导**，包括 JSON 输出、错误处理和程序化使用

SKILL.md 文件在流水线的第 6.5 阶段通过 `skill_generator.py` 自动生成，该脚本直接从 CLI 的 Click 装饰器、setup.py 和 README 中提取元数据。由于该文件位于包内，随 CLI 一起通过 `pip install` 安装，并被 REPL 启动横幅自动检测——代理可以读取启动时显示的绝对路径。

---

## 🎬 演示

### 🎯 通用用途
CLI-Anything 可用于任何有代码库的软件——无领域限制或架构限制。

### 🏭 专业级测试
已在 16 个多样且复杂的应用程序中测试，涵盖创意、生产力、通信、绘图、AI 图像生成、AI 内容生成、网络广告拦截和本地 LLM 推理等领域，这些领域之前对 AI 代理不可达。

### 🎨 多样化领域覆盖  
从创意工作流程（图像编辑、3D建模、矢量图形）到生产工具（音频、办公、直播、视频编辑）。  

### ✅ 完整CLI生成  
每个应用程序都获得了完整的、生产就绪的CLI接口——不是演示，而是保留全部功能的综合工具访问。  

<table>  
<tr>  
<th align="center">软件</th>  
<th align="center">领域</th>  
<th align="center">CLI命令</th>  
<th align="center">后端</th>  
<th align="center">测试</th>  
</tr>  
<tr>  
<td align="center"><strong>🎨 GIMP</strong></td>  
<td>图像编辑</td>  
<td><code>cli-anything-gimp</code></td>  
<td>Pillow + GEGL/Script-Fu</td>  
<td align="center">✅ 107</td>  
</tr>  
<tr>  
<td align="center"><strong>🧊 Blender</strong></td>  
<td>3D建模与渲染</td>  
<td><code>cli-anything-blender</code></td>  
<td>bpy（Python脚本）</td>  
<td align="center">✅ 208</td>  
</tr>  
<tr>  
<td align="center"><strong>✏️ Inkscape</strong></td>  
<td>矢量图形</td>  
<td><code>cli-anything-inkscape</code></td>  
<td>直接SVG/XML操作</td>  
<td align="center">✅ 202</td>  
</tr>  
<tr>  
<td align="center"><strong>🎵 Audacity</strong></td>  
<td>音频制作</td>  
<td><code>cli-anything-audacity</code></td>  
<td>Python wave + sox</td>
<td align="center">✅ 161</td>
</tr>
<tr>
<td align="center"><strong>🌐 浏览器</strong></td>
<td>浏览器自动化</td>
<td><code>cli-anything-browser</code></td>
<td>DOMShell MCP + 辅助功能树</td>
<td align="center">✅ <a href="browser/agent-harness/">新</a></td>
</tr>
<tr>
<td align="center"><strong>📄 LibreOffice</strong></td>
<td>办公套件（Writer, Calc, Impress）</td>
<td><code>cli-anything-libreoffice</code></td>
<td>ODF 生成 + 无头 LO</td>
<td align="center">✅ 158</td>
</tr>
<tr>
<td align="center"><strong>📝 <a href="mubu/agent-harness/">Mubu</a></strong></td>
<td>知识管理与大纲</td>
<td><code>cli-anything-mubu</code></td>
<td>本地 Mubu 数据 + 同步日志</td>
<td align="center">✅ 96</td>
</tr>
<tr>
<td align="center"><strong>📹 OBS Studio</strong></td>
<td>直播与录制</td>
<td><code>cli-anything-obs-studio</code></td>
<td>JSON 场景 + obs-websocket</td>
<td align="center">✅ 153</td>
</tr>
<tr>
<td align="center"><strong>🎞️ Kdenlive</strong></td>
<td>视频编辑</td>
<td><code>cli-anything-kdenlive</code></td>
<td>MLT XML + melt 渲染器</td>
<td align="center">✅ 155</td>
</tr>
<tr>
<td align="center"><strong>🎬 Shotcut</strong></td>
<td>视频编辑</td>
<td><code>cli-anything-shotcut</code></td>
<td>直接 MLT XML + melt</td>
<td align="center">✅ 154</td>
</tr>
<tr>
<td align="center"><strong>📞 Zoom</strong></td>
<td>视频会议</td>
<td><code>cli-anything-zoom</code></td>
<td>Zoom REST API (OAuth2)</td>
<td align="center">✅ 22</td>
</tr>
<tr>
<td align="center"><strong>🎵 MuseScore</strong></td>
<td>乐谱记谱</td>
<td><code>cli-anything-musescore</code></td>
<td>mscore CLI (MSCX/MusicXML)</td>
<td align="center">✅ 56</td>
</tr>
<tr>
<td align="center"><strong>📐 Draw.io</strong></td>
<td>流程图绘制</td>
<td><code>cli-anything-drawio</code></td>
<td>mxGraph XML + draw.io CLI</td>
<td align="center">✅ 138</td>
</tr>
<tr>
<td align="center"><strong>🧜 Mermaid Live Editor</strong></td>
<td>流程图绘制</td>
<td><code>cli-anything-mermaid</code></td>
<td>Mermaid 状态 + mermaid.ink 渲染器</td>
<td align="center">✅ 10</td>
</tr>
<tr>
<td align="center"><strong>✨ AnyGen</strong></td>
<td>AI 内容生成</td>
<td><code>cli-anything-anygen</code></td>
<td>AnyGen REST API (anygen.io)</td>
<td align="center">✅ 50</td>
</tr>
<tr>
<td align="center"><strong>🧠 NotebookLM</strong></td>
<td>AI 研究助手</td>
<td><code>cli-anything-notebooklm</code></td>
<td>NotebookLM CLI 封装（实验性）</td>
<td align="center">✅ 21</td>
</tr>
<tr>
<td align="center"><strong>🖼️ ComfyUI</strong></td>
<td>AI 图像生成</td>
<td><code>cli-anything-comfyui</code></td>
<td>ComfyUI REST API</td>
<td align="center">✅ 70</td>
</tr>
<tr>
<td align="center"><strong>🛡️ AdGuard Home</strong></td>
<td>全网广告拦截</td>
<td><code>cli-anything-adguardhome</code></td>
<td>AdGuard Home REST API</td>
<td align="center">✅ 36</td>
</tr>
<tr>
<td align="center"><strong>🦙 Ollama</strong></td>
<td>本地大语言模型推理</td>
<td><code>cli-anything-ollama</code></td>
<td>Ollama REST API</td>
<td align="center">✅ 98</td>
</tr>
<tr>
<td align="center"><strong>🎨 Sketch</strong></td>
<td>界面设计</td>
<td><code>sketch-cli</code></td>
<td>sketch-constructor（Node.js）</td>
<td align="center">✅ 19</td>
</tr>
<tr>
<td align="center" colspan="4"><strong>总计</strong></td>
<td align="center"><strong>✅ 1,858</strong></td>
</tr>
</table>

> **100% 通过率**，涵盖所有 1,858 个测试 — 1,355 个单元测试 + 484 个端到端测试 + 19 个 Node.js 测试。

---

## 📊 测试结果

每个 CLI 测试框架均经过严格的多层测试以确保生产环境的可靠性：

| 层级 | 测试内容 | 示例 |
|-------|---------------|---------|
| **单元测试** | 使用合成数据对每个核心功能进行隔离测试 | `test_core.py` — 项目创建、图层操作、过滤参数 |
| **端到端测试（本地）** | 项目文件生成流程 | 有效的 ODF ZIP 结构、正确的 MLT XML、SVG 格式正确 |
| **端到端测试（真实后端）** | 实际软件调用及输出验证 | LibreOffice → 以 `%PDF-` 魔法字节开头的 PDF，Blender → 渲染的 PNG |
| **CLI 子进程测试** | 通过 `subprocess.run` 调用已安装命令 | `cli-anything-gimp --json project new` → 有效的 JSON 输出 |

```
================================ Test Summary ================================
gimp          107 passed  ✅   (64 unit + 43 e2e)
blender       208 passed  ✅   (150 unit + 58 e2e)
inkscape      202 passed  ✅   (148 unit + 54 e2e)
audacity      161 passed  ✅   (107 unit + 54 e2e)
libreoffice   158 passed  ✅   (89 unit + 69 e2e)
mubu           96 passed  ✅   (85 unit + 11 e2e)
obs-studio    153 passed  ✅   (116 unit + 37 e2e)
kdenlive      155 passed  ✅   (111 unit + 44 e2e)
shotcut       154 passed  ✅   (110 unit + 44 e2e)
zoom           22 passed  ✅   (22 unit + 0 e2e)
drawio        138 passed  ✅   (116 unit + 22 e2e)
mermaid        10 passed  ✅   (5 unit + 5 e2e)
anygen         50 passed  ✅   (40 unit + 10 e2e)
notebooklm     21 passed  ✅   (21 unit + 0 e2e)
comfyui        70 passed  ✅   (60 unit + 10 e2e)
adguardhome    36 passed  ✅   (24 unit + 12 e2e)
ollama         98 passed  ✅   (87 unit + 11 e2e)
sketch         19 passed  ✅   (19 jest, Node.js)
renderdoc      59 passed  ✅   (45 unit + 14 e2e)
──────────────────────────────────────────────────────────────────────────────
TOTAL        1,917 passed  ✅   100% pass rate
```

---

## 🏗️ CLI-Anything 的架构

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/architecture.png" alt="CLI-Anything 架构" width="750">
</p>

### 🎯 核心设计原则

1. **真实软件集成** — CLI 生成有效的项目文件（ODF、MLT XML、SVG），并委托真实应用程序进行渲染。**我们构建的是面向软件的结构化接口，而非替代品**。

2. **灵活的交互模型** — 每个 CLI 都支持双模式：有状态的 REPL 用于交互式代理会话 + 子命令接口用于脚本/流水线。**运行裸命令 → 进入 REPL 模式**。

3. **一致的用户体验** — 所有生成的 CLI 共享统一的 REPL 界面（repl_skin.py），配有品牌横幅、样式提示符、命令历史、进度指示器和标准化格式。

4. **代理原生设计** — 每个命令内置 --json 标志，提供供机器消费的结构化数据，同时人类可读的表格用于交互使用。**代理通过标准的 --help 和 which 命令发现能力**。

5. **零妥协依赖** — 真实软件是硬性要求 — 无回退，无优雅降级。**后端缺失时测试失败（不跳过），确保真实功能**。

---

## 📂 项目结构

```
cli-anything/
├── 📄 README.md                          # You are here
├── 📁 assets/                            # Images and media
│   ├── icon.png                          # Project icon
│   └── teaser.png                        # Teaser figure
│
├── 🔌 cli-anything-plugin/               # The Claude Code plugin
│   ├── HARNESS.md                        # Methodology SOP (source of truth)
│   ├── README.md                         # Plugin documentation
│   ├── QUICKSTART.md                     # 5-minute getting started
│   ├── PUBLISHING.md                     # Distribution guide
│   ├── repl_skin.py                      # Unified REPL interface
│   ├── commands/                         # Plugin command definitions
│   │   ├── cli-anything.md               # Main build command
│   │   ├── refine.md                     # Expand existing harness coverage
│   │   ├── test.md                       # Test runner
│   │   └── validate.md                   # Standards validation
│   └── scripts/
│       └── setup-cli-anything.sh         # Setup script
│
├── 🤖 codex-skill/                      # Codex skill entry point
├── 🎨 gimp/agent-harness/               # GIMP CLI (107 tests)
├── 🧊 blender/agent-harness/            # Blender CLI (208 tests)
├── ✏️ inkscape/agent-harness/            # Inkscape CLI (202 tests)
├── 🎵 audacity/agent-harness/           # Audacity CLI (161 tests)
├── 🌐 browser/agent-harness/            # Browser CLI (DOMShell MCP, new)
├── 📄 libreoffice/agent-harness/        # LibreOffice CLI (158 tests)
├── 📝 mubu/agent-harness/               # Mubu CLI (96 tests)
├── 📹 obs-studio/agent-harness/         # OBS Studio CLI (153 tests)
├── 🎞️ kdenlive/agent-harness/           # Kdenlive CLI (155 tests)
├── 🎬 shotcut/agent-harness/            # Shotcut CLI (154 tests)
├── 📞 zoom/agent-harness/               # Zoom CLI (22 tests)
├── 🎵 musescore/agent-harness/          # MuseScore CLI (56 tests)
├── 📐 drawio/agent-harness/             # Draw.io CLI (138 tests)
├── 🧜 mermaid/agent-harness/            # Mermaid Live Editor CLI (10 tests)
├── ✨ anygen/agent-harness/             # AnyGen CLI (50 tests)
├── 🖼️ comfyui/agent-harness/            # ComfyUI CLI (70 tests)
├── 🧠 notebooklm/agent-harness/         # NotebookLM CLI (experimental, 21 tests)
├── 🛡️ adguardhome/agent-harness/       # AdGuard Home CLI (36 tests)
├── 🦙 ollama/agent-harness/             # Ollama CLI (98 tests)
├── 🎨 sketch/agent-harness/             # Sketch CLI (19 tests, Node.js)
└── 🔬 renderdoc/agent-harness/          # RenderDoc CLI (59 tests)
```
每个 `agent-harness/` 包含一个可安装的 Python 包，位于 `cli_anything.<software>/` 下，包含 Click CLI、核心模块、工具（包括 `repl_skin.py` 和后端包装器）以及全面的测试。

---

## 🎯 插件命令

| 命令 | 描述 |
|---------|-------------|
| `/cli-anything <software-path-or-repo>` | 构建完整的 CLI harness —— 所有 7 个阶段 |
| `/cli-anything:refine <software-path> [focus]` | 精炼现有的 harness —— 通过缺口分析扩展覆盖范围 |
| `/cli-anything:test <software-path-or-repo>` | 运行测试并用结果更新 TEST.md |
| `/cli-anything:validate <software-path-or-repo>` | 根据 HARNESS.md 标准进行验证 |

### 示例


```bash
# Build a complete CLI for GIMP from local source
/cli-anything /home/user/gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender

# Refine an existing harness — broad gap analysis
/cli-anything:refine /home/user/gimp

# Refine with a specific focus area
/cli-anything:refine /home/user/shotcut "vid-in-vid and picture-in-picture compositing"

# Run tests and update TEST.md
/cli-anything:test /home/user/inkscape

# Validate against HARNESS.md standards
/cli-anything:validate /home/user/audacity
```

---

## 🎮 Demo: Using a Generated CLI

Here's what an agent can do with `cli-anything-libreoffice`:

```bash
# Create a new Writer document
$ cli-anything-libreoffice document new -o report.json --type writer
✓ Created Writer document: report.json

# Add content
$ cli-anything-libreoffice --project report.json writer add-heading -t "Q1 Report" --level 1
✓ Added heading: "Q1 Report"

$ cli-anything-libreoffice --project report.json writer add-table --rows 4 --cols 3
✓ Added 4×3 table

# Export to real PDF via LibreOffice headless
$ cli-anything-libreoffice --project report.json export render output.pdf -p pdf --overwrite
✓ Exported: output.pdf (42,831 bytes) via libreoffice-headless

# JSON mode for agent consumption
$ cli-anything-libreoffice --json document info --project report.json
{
  "name": "Q1 Report",
  "type": "writer",
  "pages": 1,
  "elements": 2,
  "modified": true
}
```

### REPL 模式

```
$ cli-anything-blender
╔══════════════════════════════════════════╗
║       cli-anything-blender v1.0.0       ║
║     Blender CLI for AI Agents           ║
╚══════════════════════════════════════════╝

blender> scene new --name ProductShot
✓ Created scene: ProductShot

blender[ProductShot]> object add-mesh --type cube --location 0 0 1
✓ Added mesh: Cube at (0, 0, 1)

blender[ProductShot]*> render execute --output render.png --engine CYCLES
✓ Rendered: render.png (1920×1080, 2.3 MB) via blender --background

blender[ProductShot]> exit
Goodbye! 👋
```

---

## 📖 标准操作手册：HARNESS.md

HARNESS.md 是我们关于通过自动化CLI生成让任何软件可被代理访问的权威标准操作程序。

它编码了通过自动化生成过程提炼出的验证模式和方法论。

该手册提炼了成功构建所有16个多样化、生产就绪的harness的关键见解。

### 关键经验

| 经验 | 描述 |
|--------|-------------|
| **使用真实软件** | CLI必须调用实际应用进行渲染。不能用Pillow替代GIMP，不能用自定义渲染器替代Blender。生成有效的项目文件 → 调用真实后端。 |
| **渲染差距** | GUI应用在渲染时应用效果。如果CLI操作项目文件但使用简单导出工具，效果会被悄无声息地丢失。解决方案：本地渲染器 → 滤镜转换 → 渲染脚本。 |
| **滤镜转换** | 在格式间映射效果（MLT → ffmpeg）时，注意重复滤镜合并、交错流排序、参数空间差异和不可映射效果。 |
| **时间码精度** | 非整数帧率（29.97fps）会导致累计舍入误差。使用`round()`而非`int()`，显示用整数运算，测试允许±1帧误差。 |
| **输出验证** | 不要仅因为导出返回0就信任结果。验证：魔数字节，ZIP/OOXML结构，像素分析，音频RMS水平，时长检查。 |

> 查看完整方法论：[ `cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md)

---

## 📦 安装与使用

### 插件用户指南（Claude Code）

```bash
# Add marketplace & install (recommended)
/plugin marketplace add HKUDS/CLI-Anything
/plugin install cli-anything

# Build a CLI for any software with a codebase
/cli-anything <software-name>
```

### 对于生成的命令行界面 (CLI)

```bash
# Install any generated CLI
cd <software>/agent-harness
pip install -e .

# Verify
which cli-anything-<software>

# Use
cli-anything-<software> --help
cli-anything-<software>                    # enters REPL
cli-anything-<software> --json <command>   # JSON output for agents
```

### 运行测试

```bash
# Run tests for a specific CLI
cd <software>/agent-harness
python3 -m pytest cli_anything/<software>/tests/ -v

# Force-installed mode (recommended for validation)
CLI_ANYTHING_FORCE_INSTALLED=1 python3 -m pytest cli_anything/<software>/tests/ -v -s
```

---

## 🤝 贡献

我们欢迎贡献！CLI-Anything 设计为可扩展的：

- **新的软件目标** — 使用插件为任何有代码库的软件生成 CLI，然后通过 [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md) 提交你的集成。
- **方法论改进** — 对 `HARNESS.md` 的 PR，用以编码新的经验教训
- **插件增强** — 新命令、阶段改进、更好的校验
- **测试覆盖** — 更多端到端场景、边界情况、工作流测试

### 限制

- **需要强大的基础模型** — CLI-Anything 依赖前沿级模型（例如 Claude Opus 4.6、Claude Sonnet 4.6、GPT-5.4）以保证可靠的集成生成。较弱或较小的模型可能产生不完整或错误的 CLI，需要大量人工修正。
- **依赖可用的源代码** — 七阶段流水线从源代码分析和生成。当目标软件仅提供需要反编译的编译二进制文件时，集成质量和覆盖率将大幅下降。
- **可能需要迭代优化** — 一次 `/cli-anything` 运行可能无法完全覆盖所有功能。通常需要运行一次或多次 `/refine` 来将 CLI 的性能和覆盖推向生产质量。

### 路线图

- [ ] 支持更多应用类别（CAD、DAW、IDE、EDA、科学工具）
- [ ] 代理任务完成率的基准套件
- [ ] 社区贡献的内部/定制软件 CLI 集成
- [ ] 集成除 Claude Code 之外的其他代理框架
- [ ] 支持将闭源软件和网络服务的 API 打包为 CLI
- [x] 生成 SKILL.md 以辅助代理技能发现和编排

---

## 📖 文档

| 文档 | 说明 |
|----------|-------------|
| [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md) | 方法论标准操作流程 —— 单一事实来源 |
| [`cli-anything-plugin/README.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/README.md) | 插件文档 —— 命令、选项、阶段 |
| [`cli-anything-plugin/QUICKSTART.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/QUICKSTART.md) | 5分钟快速入门指南 |
| [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md) | 分发和发布指南 |

每个生成的集成还包括：
- `<SOFTWARE>.md` — 针对该应用的架构标准操作流程
- `tests/TEST.md` — 测试计划和结果文档

---

## ⭐ 星标历史

如果 CLI-Anything 帮助您使软件成为 Agent 原生，请给我们点个星！⭐

<div align="center">
  <a href="https://star-history.com/#HKUDS/CLI-Anything&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
      <img alt="星标历史图表" src="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
    </picture>
  </a>
</div>

---

## 📄 许可证

MIT 许可证 — 免费使用、修改和分发。

---

<div align="center">

**CLI-Anything** — *让任何软件代码库成为 Agent 原生。*

<sub>面向 AI 代理时代的方法论 | 16 个专业软件演示 | 1,839 个通过测试</sub>

<br>

<img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="CLI-Anything 图标" width="80">

</div>

<p align="center">
  <em>感谢您的访问 ✨ CLI-Anything！</em><br><br>
  <img src="https://visitor-badge.laobi.icu/badge?page_id=HKUDS.CLI-Anything&style=for-the-badge&color=00d4ff" alt="Views">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---