# 全忆

一个为 Claude Code 设计的记忆系统，记住重要的，忘记无关的。

## 问题所在

Claude Code 每次会话之间都会忘记所有内容。每次开始新对话，就像跟一个失忆的人交谈。你不得不重复自己说过的话：

- “我们已经试过那个方法了，没用。”
- “别动认证文件。”
- “我喜欢用制表符而不是空格。”
- “客户的名字是 Sarah，不是 Sara。”

这很快就让人厌烦。

## 全忆的功能

它给 Claude Code 一个跨会话携带的笔记本，但这是一个*挑剔的*笔记本。不是所有东西都能被保存。任何东西永久保存前，都必须通过一个简单的考验：**明天还会重要吗？**

你几个月以来的偏好？保存。你做出的决定及原因？保存。五分钟前你做的测试？不保存。系统保持整洁，这样 Claude 不必在垃圾信息中翻找重要内容。

## 工作原理

把它想象成一个有四个存储区域的厨房：

**台面**（`CLAUDE.local.md`）：你每天都会用到的东西。每次会话自动加载。故意保持小巧，大约一页文本。

**储藏室**（`memory/registers/`）：按类别组织。你的偏好、关键决定、项目细节、合作人员。Claude 需要具体信息时会查这里。

**每日笔记本**（`memory/daily/`）：每天带时间戳的草稿笔记。所有内容先写这里。之后由你决定哪些永久保留。

**储物柜**（`memory/archive/`）：已完成或过时的旧内容。仍可搜索，但不会自动加载。

核心理念：**笔记先写入每日笔记本，然后你挑选需要保留的。** Claude 不会自行决定什么足够重要永久记忆，由你掌控。

## 快速开始

### 作为插件安装（推荐）

```
/plugin marketplace add davegoldblatt/recall-marketplace
/plugin install recall@recall-marketplace
```

### 或者安装独立版

```
git clone https://github.com/davegoldblatt/total-recall.git
cd total-recall
./install.sh /path/to/your/project
```
安装后，重启 Claude Code 或运行 `/hooks` 以激活。

## 使用方法

以下是您的日常操作：

**Claude 发现了值得记住的事情。** 它会写入您的日记并告诉您。您无需做任何操作。

**您想让 Claude 记住某些内容。** 只需说“记住这个”或使用写入命令：


```
/recall-write Dave prefers concise error messages, no stack traces in prod
```

**一天结束时（或任何时候）。**回顾积累的内容并推广好的部分：

```
/recall-promote
```

**查找上周的内容。** 跨所有内容搜索：

```
/recall-search authentication decision
```

**你纠正了 Claude。** 这个纠正会同时更新所有地方：每日笔记本、登记簿和计数器。同样的错误不会再发生。

### 所有命令

| 命令 | 功能 |
|---|---|
| `/recall-init` | 第一次设置记忆文件夹 |
| `/recall-write <note>` | 保存笔记（检查是否值得保留，建议存放位置） |
| `/recall-log <note>` | 快速笔记到每日笔记本，无需询问 |
| `/recall-search <query>` | 搜索所有内容 |
| `/recall-promote` | 审查每日笔记，将重要内容转入登记簿 |
| `/recall-status` | 健康检查。一切正常吗？ |
| `/recall-maintain` | 清理陈旧或重复条目 |
| `/recall-forget <query>` | 标记某些内容为过时 |
| `/recall-context` | 显示 Claude 当前加载了哪些记忆 |

如果作为插件安装，命令会有命名空间：`/recall:recall-write` 而不是 `/recall-write`。

## 写入门槛

这是核心理念。在任何内容被提升为永久记忆之前，它必须至少通过以下一项检查：

1. **它会改变 Claude 下次的行为吗？**（偏好、界限、模式）
2. **这是某人依赖的承诺吗？**（截止日期、交付物、后续事项）
3. **这是值得记住其推理过程的决定吗？**（为什么选择 X 而非 Y）
4. **这是一个稳定的事实，会再次出现吗？**（不是明天会变的东西）
5. **你明确说过“记住这个”吗？**

如果上述都不符合，它就保留在每日笔记本中，最终会被淘汰。这保持了记忆的精简，没有杂乱抽屉。

## 纠正发生时

如果你告诉 Claude 它错了，它不会只是说“抱歉”然后继续。它会一次性更新每日笔记本、相关登记簿和计数器。旧信息会被标记为已被取代（不是删除），这样有变更的记录和时间。

## 自动加载内容

每个会话只加载两样东西：

| 内容 | 位置 | 方式 |
|---|---|---|
| 规则（写入门，纠正协议） | `rules/total-recall.md` | Claude Code 自动加载所有规则文件 |
| 计数器 / 工作记忆 | `CLAUDE.local.md` | Claude Code 自动加载此文件 |

其他内容按需加载：搜索时、相关时或通过钩子在会话开始时加载。

## 钩子

后台自动发生两件事：

**会话开始时：** Claude 会收到未完成事项和近期每日笔记的摘要。这是“我们停在哪里”的简报。

**内存压缩前：** 时间戳会写入每日笔记本以作记录。这是静默操作。Claude 看不到它，仅作簿记。

两个钩子都安全失败。如果出错，不会阻止 Claude Code 正常工作。

钩子使用 `$CLAUDE_PROJECT_DIR`（独立版）或 `${CLAUDE_PLUGIN_ROOT}`（插件）来解析路径。不解析转录文本。PreCompact 钩子只写时间戳标记到每日日志。它不读取或解析对话转录。

## 架构

供想了解技术细节的人参考。

```
Conversation (ephemeral, compacted/discarded)
    |
    v  WRITE GATE: "Does this change future behavior?"
    |
Daily Log (memory/daily/YYYY-MM-DD.md)
    All writes land here first. Raw, timestamped.
    |
    v  PROMOTION: user-controlled via /recall-promote
    |
Registers (memory/registers/*.md)
    Structured claims with metadata (confidence, evidence, last_verified)
    |
    v  DISTILLATION: only what's essential for every session
    |
Working Memory (CLAUDE.local.md)
    ~1500 words. Auto-loaded. The persistent "personality."
    |
    v  EXPIRY
    |
Archive (memory/archive/)
    Searchable history. Never auto-loaded.
```

### 关键机制

**写入门控：** 过滤噪音。只有改变行为的事实、承诺、决定和明确的“记住这个”请求才能通过。

**每日日志优先：** 所有写入都首先进入每日日志。晋升到寄存器是一个单独步骤，由用户控制。这防止模型过早地固化推断。

**矛盾协议：** 绝不默默覆盖。旧声明会被标记为 `[superseded]` 并附上日期和原因。变更模式得以保留。

**更正门控：** 人工更正优先级最高。一处更正触发写入每日日志 + 寄存器 + 工作记忆。

### 文件结构

**插件格式**（通过 `/plugin install` 安装）：

```
total-recall/                     # Plugin root
├── .claude-plugin/
│   └── plugin.json               # Plugin manifest
├── skills/                       # Slash commands (namespaced)
│   ├── recall-write/SKILL.md
│   ├── recall-search/SKILL.md
│   └── ...
├── hooks/
│   ├── hooks.json                # Hook configuration
│   ├── session-start.sh
│   └── pre-compact.sh
├── rules/
│   └── total-recall.md           # Protocol (auto-loaded)
└── templates/                    # Scaffolding templates
    ├── SCHEMA.md
    ├── CLAUDE.local.md
    └── registers/
```

**独立格式**（通过 `install.sh` 安装）：

```
your-project/
├── .claude/
│   ├── commands/recall-*.md      # Slash commands
│   ├── rules/total-recall.md     # Protocol (auto-loaded)
│   ├── hooks/*.sh                # Hook scripts
│   └── settings.local.json       # Hook configuration
├── memory/
│   ├── SCHEMA.md
│   ├── daily/YYYY-MM-DD.md
│   ├── registers/*.md
│   └── archive/
├── CLAUDE.md
└── CLAUDE.local.md               # Working memory (gitignored)
```
### 与其他记忆工具的比较

|  | Total Recall | 自动摄取工具 |
|---|---|---|
| **保存内容** | 仅保存通过写入门槛的内容 | 全部内容 |
| **默认存储位置** | 每日日志（稍后提升） | 永久存储 |
| **上下文成本** | 约1500字的工作记忆 | 无限增长 |
| **修正** | 立即传播到所有层级 | 不同情况不同处理 |
| **用户控制** | 提升是显式的 | 自动的 |
| **架构** | 具有元数据的四层结构 | 扁平或两层结构 |

## 隐私

- 所有内容本地保存。无网络调用，无遥测，无外部服务。
- 所有记忆均为纯Markdown文件，您可以自行阅读和编辑。
- `CLAUDE.local.md` 默认被git忽略（是个人文件）。
- `memory/` 默认被git忽略（可能包含个人笔记）。
- 钩子从不读取您的对话记录。
- 想确切了解发生了什么：检查 `hooks/*.sh` 和 `memory/`。全部都是纯文本。
- 卸载方法：删除 `memory/`、`CLAUDE.local.md` 及 `.claude/` 条目（或使用 `/plugin uninstall recall`）。

## 与 Superpowers 协同工作

如果您使用 [Superpowers](https://github.com/obra/superpowers)，不会有冲突。Superpowers 负责 Claude 的*工作方式*（方法论、测试驱动开发、计划）。Total Recall 负责 Claude *记住什么*。不同职责，同一项目。

## 许可

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---