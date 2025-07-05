### Analítica de PR: Volumen vs Tasa de Éxito (actualización automática)

Consulta el [panel interactivo](https://prarena.ai) para estas estadísticas.

## Comprendiendo las Métricas

Diferentes agentes de codificación con IA siguen diferentes flujos de trabajo al crear pull requests:

- **Todos los PRs**: Cada pull request creado por un agente, incluidos los PRs en BORRADOR
- **PRs Listos**: Pull requests no borrador que están listos para revisión y fusión
- **PRs Fusionados**: Pull requests que fueron fusionados exitosamente en la base de código

**Diferencias clave en el flujo de trabajo**: Algunos agentes como **Codex** iteran en privado y crean PRs listos directamente, resultando en muy pocos borradores pero altas tasas de fusión. Otros como **Copilot** y **Codegen** crean primero PRs en borrador, fomentando la iteración pública antes de marcarlos como listos para revisión.

Las estadísticas a continuación se enfocan solo en **PRs Listos** para comparar de manera justa los agentes a través de diferentes flujos de trabajo, midiendo la capacidad de cada agente para producir código fusionable independientemente de si iteran públicamente (con borradores) o en privado.

## Fuentes de datos

Explora las consultas de búsqueda de GitHub utilizadas:



- **Todos los PRs de Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **PRs de Copilot Fusionados**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Todos los PRs de Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **PRs de Codex Fusionados**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Todos los PRs de Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **PRs de Cursor Fusionados**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Todos los PRs de Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **PRs de Devin Fusionados**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Todos los PRs de Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **PRs de Codegen Fusionados**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Estadísticas Actuales

| Proyecto | PRs Listos | PRs Fusionados | Tasa de Éxito |
| -------- | ---------- | -------------- | ------------- |
| Copilot  | 16,355     | 15,073         | 92.16%        |
| Codex    | 594,884    | 520,690        | 87.53%        |
| Cursor   | 7,474      | 5,560          | 74.39%        |
| Devin    | 29,168     | 19,221         | 65.9%         |
| Codegen  | 2,108      | 1,682          | 79.79%        |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---