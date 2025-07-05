### PR Аналитика: Объём vs Уровень Успеха (автообновление)

Посмотреть [интерактивную панель](https://prarena.ai) для этих статистик.

## Понимание Метрик

Различные AI-агенты для программирования используют разные рабочие процессы при создании pull request’ов:

- **Все PR**: Каждый pull request, созданный агентом, включая PR в статусе DRAFT
- **Готовые PR**: PR, не являющиеся черновиками, которые готовы к обзору и слиянию
- **Слитые PR**: PR, которые были успешно слиты в кодовую базу

**Ключевые различия в рабочих процессах**: Некоторые агенты, такие как **Codex**, работают приватно и создают сразу готовые PR, что приводит к минимальному количеству черновиков, но высокой доле успешных слияний. Другие, такие как **Copilot** и **Codegen**, сначала создают черновики PR, позволяя публичную итерацию перед пометкой как готовых к обзору.

Ниже представлены статистические данные **только по готовым PR**, чтобы корректно сравнивать агентов с разными рабочими процессами, оценивая способность каждого агента создавать код, пригодный для слияния, вне зависимости от того, итерация проходит публично (с черновиками) или приватно.

## Источники данных

Изучите поисковые запросы GitHub, использованные:



- **Все PR Copilot**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **Слитые PR Copilot**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Все PR Codex**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **Слитые PR Codex**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Все PR Cursor**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **Слитые PR Cursor**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Все PR Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **Слитые PR Devin**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Все PR Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **Слитые PR Codegen**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Текущая Статистика

| Проект | Готовые PR | Слитые PR | Уровень успеха |
| ------- | --------- | ---------- | ------------ |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---