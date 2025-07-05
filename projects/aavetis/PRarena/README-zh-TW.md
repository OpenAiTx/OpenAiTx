### PR 分析：數量 vs 成功率（自動更新）

查看這些統計數據的[互動式儀表板](https://prarena.ai)。

## 指標說明

不同的 AI 程式碼代理在建立拉取請求（pull request）時會遵循不同的工作流程：

- **所有 PR**：代理所建立的每個拉取請求，包括 DRAFT PR
- **Ready PR**：已準備好審查和合併的非草稿拉取請求
- **Merged PR**：已成功合併到程式碼庫的拉取請求

**主要工作流程差異**：有些代理如 **Codex** 會在私下反覆運算，直接建立 Ready PR，因此很少有草稿但合併率高。其他如 **Copilot** 和 **Codegen** 則會先建立草稿 PR，鼓勵公開反覆修正，之後才標記為 Ready 進行審查。

以下統計數據僅關注 **Ready PR**，以公平比較不同工作流程下各代理的表現，衡量各代理產出可合併程式碼的能力，無論其是公開（有草稿）還是私下反覆運算。

## 數據來源

探索所使用的 GitHub 搜尋查詢：



- **所有 Copilot PR**：[https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **已合併 Copilot PR**：[https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **所有 Codex PR**：[https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **已合併 Codex PR**：[https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **所有 Cursor PR**：[https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **已合併 Cursor PR**：[https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **所有 Devin PR**：[https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **已合併 Devin PR**：[https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **所有 Codegen PR**：[https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **已合併 Codegen PR**：[https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## 目前統計數據

| 專案 | Ready PR | 已合併 PR | 成功率 |
| ---- | -------- | --------- | ------- |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---