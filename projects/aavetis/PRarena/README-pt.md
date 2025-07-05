### PR Analytics: Volume vs Taxa de Sucesso (atualizado automaticamente)

Veja o [painel interativo](https://prarena.ai) para estas estatísticas.

## Entendendo as Métricas

Diferentes agentes de codificação por IA seguem diferentes fluxos de trabalho ao criar pull requests:

- **Todos os PRs**: Todo pull request criado por um agente, incluindo PRs em RASCUNHO
- **PRs Prontos**: Pull requests não em rascunho que estão prontos para revisão e mesclagem
- **PRs Mesclados**: Pull requests que foram mesclados com sucesso no código-fonte

**Principais diferenças de fluxo de trabalho**: Alguns agentes como o **Codex** iteram de forma privada e criam PRs prontos diretamente, resultando em poucos rascunhos, mas altas taxas de mesclagem. Outros como **Copilot** e **Codegen** criam primeiro PRs em rascunho, incentivando a iteração pública antes de marcá-los como prontos para revisão.

As estatísticas abaixo focam apenas em **PRs Prontos** para comparar de forma justa os agentes em diferentes fluxos de trabalho, medindo a capacidade de cada agente de produzir código mesclável independentemente de iterarem publicamente (com rascunhos) ou privadamente.

## Fontes de dados

Explore as consultas de busca do GitHub utilizadas:



- **Todos os PRs do Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **PRs Mesclados do Copilot**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Todos os PRs do Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **PRs Mesclados do Codex**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Todos os PRs do Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **PRs Mesclados do Cursor**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Todos os PRs do Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **PRs Mesclados do Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Todos os PRs do Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **PRs Mesclados do Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Estatísticas Atuais

| Projeto | PRs Prontos | PRs Mesclados | Taxa de Sucesso |
| ------- | ----------- | ------------- | --------------- |
| Copilot | 16.355 | 15.073 | 92,16% |
| Codex | 594.884 | 520.690 | 87,53% |
| Cursor | 7.474 | 5.560 | 74,39% |
| Devin | 29.168 | 19.221 | 65,9% |
| Codegen | 2.108 | 1.682 | 79,79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---