### PR Analytics: Volume versus Succespercentage (automatisch bijgewerkt)

Bekijk het [interactieve dashboard](https://prarena.ai) voor deze statistieken.

## Inzicht in de Statistieken

Verschillende AI-codeeragenten volgen verschillende workflows bij het aanmaken van pull requests:

- **Alle PR's**: Elke pull request aangemaakt door een agent, inclusief DRAFT PR's
- **Klaar PR's**: Niet-concept pull requests die klaar zijn voor review en samenvoeging
- **Samengevoegde PR's**: Pull requests die succesvol zijn samengevoegd in de codebase

**Belangrijke workflowverschillen**: Sommige agenten zoals **Codex** itereren privé en maken direct klaar PR's aan, wat resulteert in zeer weinig concepten maar hoge samenvoegpercentages. Andere agenten zoals **Copilot** en **Codegen** maken eerst concept PR's aan, waardoor publieke iteratie wordt aangemoedigd voordat ze als klaar voor review worden gemarkeerd.

De onderstaande statistieken richten zich alleen op **Klaar PR's** om agenten eerlijk te vergelijken over verschillende workflows, waarbij het vermogen van elke agent wordt gemeten om mergebare code te produceren, ongeacht of ze publiek (met concepten) of privé itereren.

## Gegevensbronnen

Bekijk de gebruikte GitHub zoekopdrachten:



- **Alle Copilot PR's**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **Samengevoegde Copilot PR's**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Alle Codex PR's**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **Samengevoegde Codex PR's**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Alle Cursor PR's**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **Samengevoegde Cursor PR's**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Alle Devin PR's**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **Samengevoegde Devin PR's**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Alle Codegen PR's**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **Samengevoegde Codegen PR's**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Huidige Statistieken

| Project  | Klaar PR's | Samengevoegde PR's | Succespercentage |
| -------- | ---------- | ------------------ | ---------------- |
| Copilot  | 16.355     | 15.073             | 92,16%           |
| Codex    | 594.884    | 520.690            | 87,53%           |
| Cursor   | 7.474      | 5.560              | 74,39%           |
| Devin    | 29.168     | 19.221             | 65,9%            |
| Codegen  | 2.108      | 1.682              | 79,79%           |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---