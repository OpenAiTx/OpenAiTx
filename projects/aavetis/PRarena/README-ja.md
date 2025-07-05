### PRアナリティクス: ボリューム vs 成功率（自動更新）

これらの統計情報については、[インタラクティブダッシュボード](https://prarena.ai)をご覧ください。

## 指標の理解

異なるAIコーディングエージェントは、プルリクエストを作成する際に異なるワークフローを採用しています：

- **全PR**：エージェントによって作成されたすべてのプルリクエスト（DRAFT PRも含む）
- **Ready PR**：レビューおよびマージの準備ができた非ドラフトのプルリクエスト
- **Merged PR**：コードベースに正常にマージされたプルリクエスト

**主なワークフローの違い**：**Codex**のような一部のエージェントはプライベートにイテレーションを行い、Ready PRを直接作成するためドラフトは非常に少なく、マージ率が高くなります。一方、**Copilot**や**Codegen**のような他のエージェントは最初にドラフトPRを作成し、Readyにマークする前にパブリックなイテレーションを促進します。

以下の統計は**Ready PRのみ**に焦点を当てており、異なるワークフロー間でエージェントを公平に比較し、ドラフトでパブリックに反復するか、プライベートに反復するかに関わらず、各エージェントがマージ可能なコードを生成する能力を測定しています。

## データソース

使用されたGitHub検索クエリを確認できます：



- **全Copilot PR**：[https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **マージ済Copilot PR**：[https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **全Codex PR**：[https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **マージ済Codex PR**：[https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **全Cursor PR**：[https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **マージ済Cursor PR**：[https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **全Devin PR**：[https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **マージ済Devin PR**：[https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **全Codegen PR**：[https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **マージ済Codegen PR**：[https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## 現在の統計

| プロジェクト | Ready PRs | Merged PRs | 成功率 |
| ------------ | --------- | ---------- | ------ |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---