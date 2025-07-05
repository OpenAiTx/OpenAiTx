### PR-Analytics: Volumen vs Erfolgsrate (automatisch aktualisiert)

Siehe das [interaktive Dashboard](https://prarena.ai) für diese Statistiken.

## Verständnis der Kennzahlen

Verschiedene KI-Coding-Agenten verfolgen unterschiedliche Workflows bei der Erstellung von Pull Requests:

- **Alle PRs**: Jeder von einem Agenten erstellte Pull Request, einschließlich DRAFT-PRs
- **Bereite PRs**: Nicht-Entwurfs-Pull Requests, die zur Überprüfung und zum Merge bereit sind
- **Gemergte PRs**: Pull Requests, die erfolgreich in den Codebestand gemergt wurden

**Wichtige Workflow-Unterschiede**: Einige Agenten wie **Codex** iterieren privat und erstellen direkt bereite PRs, was zu sehr wenigen Entwürfen, aber hohen Merging-Raten führt. Andere wie **Copilot** und **Codegen** erstellen zunächst Entwurfs-PRs und fördern so eine öffentliche Iteration, bevor sie zur Überprüfung markiert werden.

Die untenstehenden Statistiken konzentrieren sich auf **nur bereite PRs**, um die Agenten über verschiedene Workflows hinweg fair zu vergleichen. Dabei wird die Fähigkeit jedes Agenten gemessen, mergebaren Code zu produzieren – unabhängig davon, ob sie öffentlich (mit Entwürfen) oder privat iterieren.

## Datenquellen

Erkunden Sie die verwendeten GitHub-Suchanfragen:



- **Alle Copilot PRs**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **Gemergte Copilot PRs**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Alle Codex PRs**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **Gemergte Codex PRs**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Alle Cursor PRs**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **Gemergte Cursor PRs**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Alle Devin PRs**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **Gemergte Devin PRs**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Alle Codegen PRs**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **Gemergte Codegen PRs**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Aktuelle Statistiken

| Projekt | Bereite PRs | Gemergte PRs | Erfolgsrate |
| ------- | ----------- | ------------ | ----------- |
| Copilot | 16.355 | 15.073 | 92,16% |
| Codex | 594.884 | 520.690 | 87,53% |
| Cursor | 7.474 | 5.560 | 74,39% |
| Devin | 29.168 | 19.221 | 65,9% |
| Codegen | 2.108 | 1.682 | 79,79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---