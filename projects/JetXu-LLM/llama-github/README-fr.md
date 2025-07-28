# llama-github

[Document détaillé] https://deepwiki.com/JetXu-LLM/llama-github

[![Version PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Téléchargements](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licence](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github est un outil puissant qui vous aide à récupérer (basé sur Agentic RAG) les extraits de code, problèmes et informations de dépôt les plus pertinents de GitHub en fonction de vos requêtes, les transformant en un contexte de connaissance précieux. Il permet aux chatbots LLM, agents IA et agents Auto-dev de résoudre des tâches de codage complexes. Que vous soyez un développeur cherchant des solutions rapides ou un ingénieur implémentant des agents Auto Dev IA avancés, llama-github rend cela simple et efficace.

Si vous aimez ce projet ou pensez qu’il a du potentiel, merci de lui donner une ⭐️. Votre soutien est notre plus grande motivation !

## Architecture
![Architecture de haut niveau](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installation
```
pip install llama-github
```

## Utilisation

Voici un exemple simple de comment utiliser llama-github :

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
Pour un usage plus avancé et des exemples, veuillez consulter la [documentation](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Fonctionnalités clés

- **🔍 Recherche intelligente sur GitHub** : Exploitez la puissance de llama-github pour récupérer des extraits de code, des issues et des informations sur les dépôts hautement pertinents sur GitHub en fonction des requêtes des utilisateurs. Nos techniques avancées de recherche garantissent que vous trouvez rapidement et efficacement les informations les plus pertinentes.

- **⚡ Mise en cache du pool de dépôts** : Llama-github dispose d’un mécanisme innovant de mise en cache du pool de dépôts. En mettant en cache les dépôts (y compris les README, structures, codes et issues) à travers les threads, llama-github accélère significativement l’efficacité de la recherche sur GitHub et minimise la consommation des jetons API GitHub. Déployez llama-github dans des environnements de production multithread en toute confiance, sachant qu’il fonctionnera de manière optimale et vous fera économiser des ressources précieuses.

- **🧠 Analyse des questions alimentée par LLM** : Profitez des modèles de langage de pointe pour analyser les questions des utilisateurs et générer des stratégies et critères de recherche très efficaces. Llama-github décompose intelligemment les requêtes complexes, garantissant que vous récupérez les informations les plus pertinentes du vaste réseau de dépôts GitHub.

- **📚 Génération de contexte complète** : Générez des réponses riches et contextuellement pertinentes en combinant de manière fluide les informations récupérées sur GitHub avec les capacités de raisonnement des modèles de langage avancés. Llama-github excelle dans le traitement des questions les plus complexes et longues, fournissant des réponses complètes et perspicaces incluant un contexte étendu pour soutenir vos besoins en développement.

- **🚀 Excellence dans le traitement asynchrone** : Llama-github est conçu dès le départ pour exploiter tout le potentiel de la programmation asynchrone. Avec des mécanismes asynchrones minutieusement implémentés dans tout le code, llama-github peut gérer plusieurs requêtes simultanément, augmentant significativement la performance globale. Expérimentez la différence alors que llama-github gère efficacement des charges de travail élevées sans compromettre la rapidité ni la qualité.

- **🔧 Intégration flexible des LLM** : Intégrez facilement llama-github avec divers fournisseurs de LLM, modèles d’incorporation et modèles de reranking pour adapter les capacités de la bibliothèque à vos besoins spécifiques. Notre architecture extensible vous permet de personnaliser et d’améliorer les fonctionnalités de llama-github, garantissant une adaptation fluide à votre environnement de développement unique.

- **🔒 Options robustes d’authentification** : Llama-github supporte à la fois les jetons d’accès personnel et l’authentification via GitHub App, vous offrant la flexibilité de l’intégrer dans différents environnements de développement. Que vous soyez un développeur individuel ou travailliez dans un contexte organisationnel, llama-github vous couvre avec des mécanismes d’authentification sécurisés et fiables.

- **🛠️ Journalisation et gestion des erreurs** : Nous comprenons l’importance d’un fonctionnement fluide et d’un dépannage facile. C’est pourquoi llama-github est équipé de mécanismes complets de journalisation et de gestion des erreurs. Obtenez des informations approfondies sur le comportement de la bibliothèque, diagnostiquez rapidement les problèmes et maintenez un flux de travail de développement stable et fiable.

## 🤖 Essayez notre assistant de revue de PR alimenté par IA : LlamaPReview

Si vous trouvez llama-github utile, vous pourriez également être intéressé par notre assistant de revue de PR GitHub alimenté par IA, LlamaPReview. Il est conçu pour compléter votre flux de développement et améliorer encore la qualité du code.

### Fonctionnalités clés de LlamaPReview :
- 🚀 Installation en un clic, aucune configuration requise, fonctionnement entièrement automatique
- 💯 Actuellement gratuit - pas besoin de carte de crédit ni d’informations de paiement
- 🧠 Revues automatiques de PR alimentées par IA avec une compréhension profonde du code
- 🌐 Supporte plusieurs langages de programmation

**LlamaPReview utilise la récupération contextuelle avancée de llama-github et l’analyse alimentée par LLM** pour fournir des revues de code intelligentes et conscientes du contexte. C’est comme avoir un développeur senior, armé du contexte complet de votre dépôt, qui révise automatiquement chaque PR !

👉 [Installer LlamaPReview Maintenant](https://github.com/marketplace/llamapreview/) (Gratuit)

En utilisant llama-github pour la récupération de contexte et LlamaPReview pour les revues de code, vous pouvez créer un environnement de développement puissant et enrichi par l’IA.

## Vision et feuille de route

### Vision

Notre vision est de devenir un module clé dans l’avenir des solutions de développement pilotées par IA, s’intégrant parfaitement avec GitHub pour permettre aux LLM de résoudre automatiquement des tâches de codage complexes.

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Feuille de route

Pour une vue détaillée de notre feuille de route projet, veuillez visiter notre [Feuille de route du projet](https://github.com/users/JetXu-LLM/projects/2).

## Remerciements

Nous souhaitons exprimer notre gratitude aux projets open source suivants pour leur soutien et leurs contributions :

- **[LangChain](https://github.com/langchain-ai/langchain)** : Pour avoir fourni le cadre fondamental qui alimente les capacités de prompting et de traitement LLM dans llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)** : Pour avoir offert l’API s.jina.ai ainsi que des modèles open source de reranking et d’incorporation qui améliorent la précision et la pertinence des contextes générés dans llama-github.

Leurs contributions ont été essentielles au développement de llama-github, et nous recommandons vivement de consulter leurs projets pour plus de solutions innovantes.

## Contribution

Nous accueillons les contributions à llama-github ! Veuillez consulter nos [directives de contribution](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) pour plus d’informations.

## Licence

Ce projet est sous licence Apache 2.0. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

## Contact

Si vous avez des questions, suggestions ou retours, n’hésitez pas à nous contacter à [email de Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Merci d’avoir choisi llama-github ! Nous espérons que cette bibliothèque améliorera votre expérience de développement IA et vous aidera à créer des applications puissantes en toute simplicité.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---