### PR Analytics: Wolumen vs Wskaźnik sukcesu (auto-aktualizowane)

Zobacz [interaktywny dashboard](https://prarena.ai) dla tych statystyk.

## Zrozumienie metryk

Różne agenty AI do kodowania stosują różne workflow podczas tworzenia pull requestów:

- **Wszystkie PR**: Każdy pull request utworzony przez agenta, w tym PR w wersji DRAFT
- **Gotowe PR**: Pull requesty niebędące wersją roboczą, gotowe do przeglądu i scalania
- **Scalone PR**: Pull requesty, które zostały pomyślnie scalone z kodem bazowym

**Kluczowe różnice w workflow**: Niektóre agenty, takie jak **Codex**, iterują prywatnie i tworzą od razu gotowe PR, co skutkuje bardzo niewielką liczbą wersji roboczych, ale wysokim wskaźnikiem scalania. Inne, takie jak **Copilot** i **Codegen**, najpierw tworzą PR jako wersje robocze, zachęcając do publicznej iteracji przed oznaczeniem ich jako gotowe do przeglądu.

Poniższe statystyki koncentrują się wyłącznie na **Gotowych PR**, aby uczciwie porównywać agentów w różnych workflow, mierząc zdolność każdego agenta do generowania kodu możliwego do scalenia, niezależnie od tego, czy iterują publicznie (z wersjami roboczymi), czy prywatnie.

## Źródła danych

Zobacz zapytania wyszukiwania GitHub użyte:



- **Wszystkie PR Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **Scalone PR Copilot**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Wszystkie PR Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **Scalone PR Codex**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Wszystkie PR Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **Scalone PR Cursor**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Wszystkie PR Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **Scalone PR Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Wszystkie PR Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **Scalone PR Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Aktualne statystyki

| Projekt | Gotowe PR | Scalone PR | Wskaźnik sukcesu |
| ------- | --------- | ---------- | ---------------- |
| Copilot | 16,355 | 15,073 | 92,16% |
| Codex | 594,884 | 520,690 | 87,53% |
| Cursor | 7,474 | 5,560 | 74,39% |
| Devin | 29,168 | 19,221 | 65,9% |
| Codegen | 2,108 | 1,682 | 79,79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---