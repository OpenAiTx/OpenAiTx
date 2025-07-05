### Analyse des PR : Volume vs Taux de réussite (mise à jour automatique)

Consultez le [tableau de bord interactif](https://prarena.ai) pour ces statistiques.

## Comprendre les indicateurs

Différents agents de codage IA suivent des workflows différents lors de la création de pull requests :

- **Toutes les PR** : Chaque pull request créée par un agent, y compris les PR en mode BROUILLON
- **PR prêtes** : Pull requests non brouillons prêtes pour la relecture et la fusion
- **PR fusionnées** : Pull requests qui ont été fusionnées avec succès dans la base de code

**Principales différences de workflow** : Certains agents comme **Codex** itèrent en privé et créent directement des PR prêtes, ce qui entraîne très peu de brouillons mais des taux de fusion élevés. D'autres comme **Copilot** et **Codegen** créent d'abord des PR en brouillon, favorisant l'itération publique avant de les marquer comme prêtes pour la relecture.

Les statistiques ci-dessous se concentrent uniquement sur les **PR prêtes** afin de comparer équitablement les agents à travers différents workflows, en mesurant la capacité de chaque agent à produire du code fusionnable, qu'il itère publiquement (avec des brouillons) ou en privé.

## Sources des données

Découvrez les requêtes de recherche GitHub utilisées :



- **Toutes les PR Copilot** : [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **PR Copilot fusionnées** : [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Toutes les PR Codex** : [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **PR Codex fusionnées** : [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Toutes les PR Cursor** : [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **PR Cursor fusionnées** : [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Toutes les PR Devin** : [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **PR Devin fusionnées** : [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Toutes les PR Codegen** : [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **PR Codegen fusionnées** : [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## Statistiques actuelles

| Projet   | PR prêtes | PR fusionnées | Taux de réussite |
| -------- | --------- | ------------- | ---------------- |
| Copilot  | 16 355    | 15 073        | 92,16 %          |
| Codex    | 594 884   | 520 690       | 87,53 %          |
| Cursor   | 7 474     | 5 560         | 74,39 %          |
| Devin    | 29 168    | 19 221        | 65,9 %           |
| Codegen  | 2 108     | 1 682         | 79,79 %          |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---