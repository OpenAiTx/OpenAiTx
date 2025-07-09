<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic : la dataframe (re)construite pour l'inférence LLM

[![Version PyPI](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Versions Python](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![Licence](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Documentation** : [docs.fenic.ai](https://docs.fenic.ai/)

fenic est un framework DataFrame inspiré de PySpark, développé par typedef.ai, pour la construction d'applications d'IA et d'agents. Transformez des données non structurées et structurées en insights grâce à des opérations DataFrame familières, enrichies par l'intelligence sémantique. Profitez d'une prise en charge native du markdown, des transcriptions et des opérateurs sémantiques, ainsi que d'une inférence par lots efficace auprès de tout fournisseur de modèles.
## Installation

fenic prend en charge Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Configuration du fournisseur LLM

fenic nécessite une clé API d’au moins un fournisseur LLM. Définissez la variable d’environnement appropriée pour le fournisseur choisi :

```bash
# Pour OpenAI
export OPENAI_API_KEY="votre-clé-api-openai"

# Pour Anthropic
export ANTHROPIC_API_KEY="votre-clé-api-anthropic"

# Pour Google
export GEMINI_API_KEY="votre-clé-api-google"
```

## Démarrage rapide

Le moyen le plus rapide de découvrir fenic est de consulter les exemples.

Voici une liste rapide des exemples présents dans ce dépôt :

| Exemple                                                                 | Description                                                                                                                                    |
| ----------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                    | Introduction à l’extraction et à la classification sémantiques à l’aide des opérateurs principaux de fenic via l’analyse de journaux d’erreurs. |
| [Enrichment](examples/enrichment)                                       | DataFrames multi-étapes avec extraction de texte basée sur des modèles, jointures et transformations propulsées par LLM, illustrés via l’enrichissement de journaux. |
| [Meeting Transcript Processing](examples/meeting_transcript_processing) | Analyse native de transcriptions, intégration de schémas Pydantic et agrégations complexes illustrées par l’analyse de réunions.               |
| [News Analysis](examples/news_analysis)                                 | Analyse et extraction d’informations à partir d’articles de presse à l’aide d’opérateurs sémantiques et de traitement de données structurées.   |
| [Podcast Summarization](examples/podcast_summarization)                 | Traitement et synthèse de transcriptions de podcasts avec analyse par intervenant et extraction des points clés.                                |
| [Semantic Join](examples/semantic_joins)                                | Plutôt que de simples appariements approximatifs, utilisez la puissante fonctionnalité de jointure sémantique de fenic pour relier des données entre tables. |
| [Named Entity Recognition](examples/named_entity_recognition)           | Extraction et classification d’entités nommées à partir de textes grâce à l’extraction et à la classification sémantiques.                     |
| [Markdown Processing](examples/markdown_processing)                     | Traitement et transformation de documents markdown avec extraction structurée de données et mise en forme.                                      |
| [JSON Processing](examples/json_processing)                             | Gestion de structures de données JSON complexes avec opérations sémantiques et validation de schéma.                                           |
| [Feedback Clustering](examples/feedback_clustering)                     | Regroupement et analyse de retours grâce à la similarité sémantique et aux opérations de clustering.                                           |
| [Document Extraction](examples/document_extraction)                     | Extraction d’informations structurées à partir de divers formats de documents à l’aide d’opérateurs sémantiques.                                |

(N’hésitez pas à cliquer sur n’importe quel exemple ci-dessus pour accéder directement à son dossier.)
## Pourquoi utiliser fenic ?

fenic est un framework DataFrame inspiré de PySpark, orienté et structuré, pour la création d'applications d'IA et agentiques en production.

Contrairement aux outils de données traditionnels adaptés a posteriori pour les LLM, le moteur de requête de fenic est conçu dès le départ pour l'inférence.

Transformez des données structurées et non structurées en insights grâce à des opérations DataFrame familières, enrichies par l’intelligence sémantique. Profitez d'une prise en charge native du markdown, des transcriptions et des opérateurs sémantiques, ainsi que d'une inférence batch efficace auprès de tout fournisseur de modèle.

fenic apporte la fiabilité des pipelines de données traditionnels aux charges de travail IA.

### Fonctionnalités clés

#### Conçu spécifiquement pour l'inférence LLM

- Moteur de requête conçu de zéro pour les charges de travail IA, non adapté a posteriori
- Optimisation automatique du batch pour les appels API
- Logique de réessai intégrée et limitation du débit
- Comptage des tokens et suivi des coûts

#### Opérateurs sémantiques comme citoyens de première classe
- `semantic.analyze_sentiment` - Analyse de sentiment intégrée
- `semantic.classify` - Catégoriser le texte avec des exemples few-shot
- `semantic.extract` - Transformer du texte non structuré en données structurées avec des schémas
- `semantic.group_by` - Regrouper les données par similarité sémantique
- `semantic.join` - Joindre des DataFrames sur la signification, pas seulement sur les valeurs
- `semantic.map` - Appliquer des transformations en langage naturel
- `semantic.predicate` - Créer des prédicats en utilisant le langage naturel pour filtrer les lignes
- `semantic.reduce` - Agréger les données groupées avec des opérations LLM

#### Prise en Charge Native des Données Non Structurées

Va au-delà des types de données multimodales classiques (audio, images) en créant des types spécialisés pour des charges de travail principalement textuelles :

- Analyse et extraction du Markdown en tant que type de données de premier ordre
- Traitement de transcriptions (SRT, formats génériques) avec prise en compte des intervenants et des horodatages
- Manipulation de JSON avec des expressions JQ pour les données imbriquées
- Découpage automatique du texte avec recouvrement configurable pour les longs documents

#### Infrastructure Prête pour la Production
- Prise en charge de plusieurs fournisseurs (OpenAI, Anthropic, Gemini)
- Backends d'exécution locaux et cloud
- Gestion complète des erreurs et journalisation
- Intégration Pydantic pour la sécurité des types

#### API DataFrame familière

- Opérations compatibles PySpark
- Évaluation paresseuse et optimisation des requêtes
- Prise en charge SQL pour des requêtes complexes
- Intégration transparente avec les pipelines de données existants

### Pourquoi utiliser les DataFrames pour les applications LLM et agentiques ?

Les applications d’IA et agentiques sont fondamentalement des pipelines et des flux de travail – exactement ce pour quoi les API DataFrame ont été conçues. Plutôt que de réinventer des modèles pour la transformation, le filtrage et l’agrégation des données, fenic s’appuie sur des décennies de pratiques d’ingénierie éprouvées.

#### Architecture découplée pour de meilleurs agents

fenic crée une séparation claire entre les tâches d’inférence lourdes et les interactions en temps réel des agents. En déplaçant le traitement par lots hors de l’exécution de l’agent, vous obtenez :

- Des agents plus prévisibles et réactifs
- Une meilleure utilisation des ressources grâce aux appels LLM groupés
- Une séparation plus nette entre la planification/l’orchestration et l’exécution
#### Conçu pour tous les ingénieurs

Les DataFrames ne sont pas réservés qu’aux spécialistes des données. La conception de l’API, fluide et composable, la rend accessible à tout ingénieur :

- Enchaînez les opérations naturellement : `df.filter(...).semantic.group_by(...)`
- Mélangez styles impératif et déclaratif sans effort
- Démarrez rapidement grâce à des schémas familiers de pandas/PySpark ou SQL

## Support

Rejoignez notre communauté sur [Discord](https://discord.gg/GdqF3J7huR) où vous pouvez échanger avec d'autres utilisateurs, poser des questions et obtenir de l'aide pour vos projets fenic. Notre communauté est toujours ravie d’accueillir de nouveaux membres !

Si vous trouvez fenic utile, pensez à nous laisser une ⭐ en haut de ce dépôt. Votre soutien nous aide à faire grandir et améliorer le framework pour tous !

## Contribution

Nous accueillons toutes sortes de contributions ! Que vous souhaitiez écrire du code, améliorer la documentation, tester des fonctionnalités ou proposer de nouvelles idées, votre aide nous est précieuse.

Pour les développeurs envisageant de soumettre des modifications de code, nous vous encourageons à ouvrir d’abord une issue pour discuter de vos idées avant de créer une Pull Request. Cela permet de garantir l’alignement avec l’orientation du projet et d’éviter les efforts en double.

Veuillez consulter notre [guide de contribution](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) pour des informations détaillées sur le processus de développement et la mise en place du projet.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---