# C# 语言设计

[![加入 https://gitter.im/dotnet/csharplang 聊天](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![在 Discord 上聊天](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

欢迎来到 C# 语言设计的官方仓库。这里是开发、采纳和规范新 C# 语言特性的地方。

C# 由 C# 语言设计团队（LDT）设计，并与实现该语言的 [Roslyn](https://github.com/dotnet/roslyn) 项目紧密协作。

您可以在以下位置找到：

- 活跃的 C# 语言特性提案位于 [proposals 文件夹](https://raw.githubusercontent.com/dotnet/csharplang/main/proposals)
- C# 语言设计会议记录位于 [meetings 文件夹](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings)
- [语言版本历史摘要请见此处](https://raw.githubusercontent.com/dotnet/csharplang/main/Language-Version-History.md)。

如果您发现上述内容中有错误或不足，请提交 issue 进行反馈，或者更好的是：提交 pull request 进行修复。

但对于*新特性的提案*，请先提出[讨论](https://github.com/dotnet/csharplang/labels/Discussion)，只有在被语言设计团队成员（即“champion”）邀请后，才以 issue 或 pull request 的形式正式提交提案。

完整的设计流程描述在[此处](https://raw.githubusercontent.com/dotnet/csharplang/main/Design-Process.md)。下面是简要概述。

## 讨论

与语言特性相关的讨论在本仓库的 [Discussions](https://github.com/dotnet/csharplang/discussions) 中进行。

如果您想建议一个特性，讨论当前的设计笔记或提案等，请[开启一个新的 Discussion 主题](https://github.com/dotnet/csharplang/discussions/new)。

简洁且聚焦的讨论更有可能被阅读。如果您是第 50 个评论的人，可能只有极少数人会看到。为了让讨论更易于导航并受益，请遵守以下几点建议：

- 讨论应与 C# 语言设计相关，否则将被直接关闭。
- 选择一个能清晰传达讨论范围的描述性主题。
- 坚持讨论主题。如果评论内容偏离主题，或详细探讨某个子主题，请开启新的讨论并链接回原主题。
- 您的评论对他人有用吗？还是可以用对已有评论的表情反应来表达？

阻止特定语法出现的语言提案可通过 [Roslyn 分析器](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers) 实现。仅使现有语法变为可选非法的提案将被语言设计委员会拒绝，以避免语言复杂性增加。

## 提案

当 C# LDM 的成员认为某个提案值得更广泛团队考虑时，他们可以[担任 Champion](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22)，即他们会将其带到 C# 语言设计会议。提案总是在关联的讨论中讨论，而不是在 champion issue 中。我们并非一直遵循此政策，因此许多 champion issue 上会有讨论；我们现在会锁定 issue，防止新讨论发生。每个 champion issue 都会有讨论链接。

## 设计流程

[提案](https://raw.githubusercontent.com/dotnet/csharplang/main/proposals) 会根据[语言设计会议](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings)的决策不断演进，这些决策受 [discussions](https://github.com/dotnet/csharplang/discussions)、实验和线下设计工作的影响。

在很多情况下，需要实现并分享一个特性的原型，以便确定合适的设计，最终决定是否采纳该特性。原型有助于发现特性的实现和可用性问题。原型应在 [Roslyn 仓库](https://github.com/dotnet/roslyn) 的分支中实现，并满足以下要求：

- （如适用）解析过程应能经受实验：输入不应导致崩溃。
- 包含能端到端演示特性工作的最小测试。
- 包含最基本的 IDE 支持（关键字着色、格式化、补全）。

一旦获批，特性应在 [Roslyn](https://github.com/dotnet/roslyn) 中完整实现，并在 [语言规范](https://raw.githubusercontent.com/dotnet/csharplang/main/spec) 中完整规范，此时提案会被移到已完成特性的相应文件夹，例如 [C# 7.1 提案](https://raw.githubusercontent.com/dotnet/csharplang/main/proposals/csharp-7.1)。

**免责声明**：活跃提案正被积极考虑纳入未来的 C# 语言版本，但并不保证最终会被纳入下一个或任何版本。提案可在上述流程的任何阶段，基于设计团队、社区、代码审查者或测试的反馈，随时被推迟或拒绝。

### 里程碑

我们为仓库中的 issue 设置了几个不同的里程碑：
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) 是当前正在积极推进的 championed 提案集。并非所有此里程碑中的内容都会进入下一版本 C#，但将在即将发布期间获得设计时间。
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) 是已三方评审但未被积极推进的 championed 提案集。虽然社区对这些提案的讨论和想法是受欢迎的，但在我们准备好之前，这些特性的设计和实现审查成本过高，暂不考虑社区实现。
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) 是已三方评审但未被积极推进、对社区实现开放的 championed 提案集。此里的 issue 可能有两种状态：需要规范批准和需要实现。需要规范的仍需在 LDM 提出并获批，但我们愿意在方便时处理。
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) 是 LDM 已经拒绝的提案集。没有强烈需求或社区反馈，这些提案未来不会被考虑。
* 编号里程碑是为特定语言版本实现的特性集。对于已关闭的里程碑，这些内容随该版本一同发布。对于开放的里程碑，在临近发布时若发现兼容性或其他问题，特性可能会被移除。

## 语言设计会议

语言设计会议（LDM）由 LDT 及偶尔邀请的嘉宾举行，会议记录存放于以年份为单位组织的 [meetings](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings) 文件夹。设计会议记录的生命周期描述见 [meetings/README.md](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings/README.md)。LDM 决定未来 C# 版本的相关事宜，包括要推进的提案、如何演进提案，以及是否及何时采纳。

## 语言规范

当前 ECMA-334 规范的 markdown 版本可在 [C# 语言标准](https://github.com/dotnet/csharpstandard/) 仓库找到。

## 实现

C# 语言的参考实现可在 [Roslyn 仓库](https://github.com/dotnet/roslyn) 中找到。该仓库还跟踪了 [语言特性实现状态](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md)。直到最近，语言设计相关的内容也在此跟踪。请在我们迁移活跃提案期间给予一些时间。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---