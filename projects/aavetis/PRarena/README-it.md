### PR Analytics: Volume vs Success Rate (aggiornato automaticamente)

Visualizza la [dashboard interattiva](https://prarena.ai) per queste statistiche.

## Comprensione delle metriche

I diversi agenti di codifica AI seguono diversi flussi di lavoro nella creazione delle pull request:

- **Tutte le PR**: Ogni pull request creata da un agente, incluse le PR in BOZZA
- **PR Pronte**: Pull request non in bozza che sono pronte per la revisione e l’unione
- **PR Unite**: Pull request che sono state unite con successo nella codebase

**Principali differenze di workflow**: Alcuni agenti come **Codex** iterano privatamente e creano direttamente PR pronte, risultando in pochissime bozze ma con alti tassi di unione. Altri come **Copilot** e **Codegen** creano prima PR in bozza, incoraggiando l’iterazione pubblica prima di marcarle come pronte per la revisione.

Le statistiche riportate sotto si concentrano **solo sulle PR pronte** per confrontare equamente gli agenti attraverso diversi flussi di lavoro, misurando la capacità di ciascun agente di produrre codice unibile a prescindere dal fatto che iterino pubblicamente (con bozze) o privatamente.

## Fonti dei dati

Esplora le query di ricerca GitHub utilizzate:



- **Tutte le PR di Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **PR di Copilot unite**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Tutte le PR di Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **PR di Codex unite**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Tutte le PR di Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **PR di Cursor unite**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Tutte le PR di Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **PR di Devin unite**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Tutte le PR di Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **PR di Codegen unite**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Statistiche attuali

| Progetto | PR Pronte | PR Unite | Success Rate |
| -------- | --------- | -------- | ------------ |
| Copilot | 16.355 | 15.073 | 92,16% |
| Codex | 594.884 | 520.690 | 87,53% |
| Cursor | 7.474 | 5.560 | 74,39% |
| Devin | 29.168 | 19.221 | 65,9% |
| Codegen | 2.108 | 1.682 | 79,79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---