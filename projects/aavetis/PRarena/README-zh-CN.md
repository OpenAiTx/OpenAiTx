### PR 分析：数量 vs 成功率（自动更新）

查看这些统计数据的[交互式仪表板](https://prarena.ai)。

## 指标解析

不同的 AI 编码代理在创建拉取请求（Pull Request, PR）时遵循不同的工作流程：

- **所有 PR**：代理创建的每一个拉取请求，包括 DRAFT（草稿）PR
- **已就绪 PR**：非草稿的拉取请求，已准备好进行评审和合并
- **已合并 PR**：成功合并到代码库的拉取请求

**关键工作流区别**：像 **Codex** 这样的代理会私下迭代并直接创建已就绪 PR，导致草稿很少但合并率很高。其他如 **Copilot** 和 **Codegen** 则先创建草稿 PR，鼓励在标记为已就绪前进行公开迭代。

以下统计数据仅关注**已就绪 PR**，以公平比较不同工作流下的代理，衡量每个代理产出可合并代码的能力，无论其迭代方式是公开（有草稿）还是私下进行。

## 数据来源

探索所用的 GitHub 搜索查询：



- **所有 Copilot PR**：[https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **已合并 Copilot PR**：[https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **所有 Codex PR**：[https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **已合并 Codex PR**：[https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **所有 Cursor PR**：[https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **已合并 Cursor PR**：[https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **所有 Devin PR**：[https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **已合并 Devin PR**：[https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **所有 Codegen PR**：[https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **已合并 Codegen PR**：[https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## 当前统计数据

| 项目 | 已就绪 PR | 已合并 PR | 成功率 |
| ---- | --------- | --------- | ------ |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---