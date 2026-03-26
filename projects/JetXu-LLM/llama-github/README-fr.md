
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Document détaillé] https://deepwiki.com/JetXu-LLM/llama-github

[![Version PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Téléchargements](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licence](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github est un outil puissant qui vous aide à récupérer (basé sur Agentic RAG) les extraits de code, problèmes et informations de dépôt les plus pertinents de GitHub selon vos requêtes, en les transformant en un contexte de connaissance précieux. Il permet aux Chatbots LLM, Agents IA et Agents Auto-dev de résoudre des tâches de codage complexes. Que vous soyez un développeur cherchant des solutions rapides ou un ingénieur implémentant des Agents IA Auto Dev avancés, llama-github rend la tâche simple et efficace.

Si vous aimez ce projet ou pensez qu'il a du potentiel, veuillez lui attribuer une ⭐️. Votre soutien est notre plus grande motivation !

## Architecture
![Architecture de haut niveau](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Installation
```
pip install llama-github
```

Cible d'exécution actuellement maintenue : Python `3.10+`.

## Utilisation

Voici un exemple simple de la façon d'utiliser llama-github :

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
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` renvoie une liste de dictionnaires de contexte. Chaque élément contient au moins `context` et `url`.

Pour une utilisation plus avancée et des exemples, veuillez consulter la [documentation](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Des exemples exécutables à faible coût sont également disponibles dans [`examples/`](examples).

## Fonctionnalités clés

- **🔍 Récupération intelligente sur GitHub** : Exploitez la puissance de llama-github pour récupérer des extraits de code, des issues et des informations de dépôt hautement pertinents depuis GitHub en fonction des requêtes utilisateur. Nos techniques de recherche avancées vous garantissent de trouver rapidement et efficacement les informations les plus pertinentes.

- **⚡ Mise en cache du pool de dépôts** : Llama-github dispose d'un mécanisme innovant de mise en cache de pool de dépôts. En mettant en cache les dépôts (y compris les README, structures, codes et issues) à travers les threads, llama-github accélère considérablement l'efficacité de la recherche GitHub tout en minimisant la consommation des jetons API GitHub.

- **🧠 Analyse des questions par LLM** : Exploitez les modèles de langage de pointe pour analyser les questions des utilisateurs et générer des stratégies et critères de recherche très efficaces. Llama-github décompose intelligemment les requêtes complexes, garantissant que vous récupérez les informations les plus pertinentes du vaste réseau de dépôts GitHub.

- **📚 Génération de contexte complète** : Générez des réponses riches et contextuellement pertinentes en combinant de manière transparente les informations récupérées sur GitHub avec les capacités de raisonnement des modèles de langage avancés. Llama-github excelle dans le traitement des questions les plus complexes et longues, fournissant des réponses complètes et éclairées incluant un contexte étendu pour soutenir vos besoins de développement.

- **🚀 Excellence du traitement asynchrone** : Llama-github est conçu dès le départ pour exploiter tout le potentiel de la programmation asynchrone. Grâce à des mécanismes asynchrones soigneusement implémentés dans toute la base de code, llama-github peut gérer plusieurs requêtes simultanément, augmentant ainsi considérablement les performances globales.

- **🔧 Intégration LLM flexible** : Intégrez facilement llama-github avec différents fournisseurs de LLM, modèles d'embedding, modèles de reranking ou un modèle de chat injecté compatible LangChain pour adapter les capacités de la bibliothèque à vos besoins spécifiques.

- **🔒 Options d’authentification robustes** : Llama-github prend en charge les tokens d'accès personnels ainsi que l'authentification via GitHub App, vous offrant la flexibilité d'intégration dans divers environnements de développement. Que vous soyez un développeur individuel ou en contexte organisationnel, llama-github propose des mécanismes d'authentification sécurisés et fiables.

- **🛠️ Journalisation et gestion des erreurs** : Nous comprenons l'importance d'opérations fluides et d'un dépannage aisé. C'est pourquoi llama-github est équipé de mécanismes complets de journalisation et de gestion des erreurs. Obtenez une visibilité approfondie sur le comportement de la bibliothèque, diagnostiquez rapidement les problèmes et maintenez un flux de développement stable et fiable.

## 🤖 Essayez notre assistant de revue de PR alimenté par l'IA : LlamaPReview

Si vous trouvez llama-github utile, vous pourriez aussi être intéressé par notre assistant de revue de PR GitHub alimenté par l'IA, LlamaPReview. Il est conçu pour compléter votre workflow de développement et améliorer encore la qualité du code.

### Fonctionnalités clés de LlamaPReview :
- 🚀 Installation en un clic, aucune configuration requise, entièrement automatique
- 💯 Actuellement gratuit - aucune carte bancaire ou information de paiement requise
- 🧠 Revues de PR automatiques, alimentées par l'IA, avec une compréhension approfondie du code
- 🌐 Prise en charge de plusieurs langages de programmation

**LlamaPReview utilise la récupération de contexte avancée et l'analyse par LLM de llama-github** pour fournir des revues de code intelligentes et contextuelles. C'est comme avoir un développeur senior, armé de tout le contexte de votre dépôt, qui révise chaque PR automatiquement !

👉 [Installer LlamaPReview maintenant](https://github.com/marketplace/llamapreview/) (Gratuit)

En utilisant llama-github pour la récupération de contexte et LlamaPReview pour les revues de code, vous pouvez créer un environnement de développement puissant, enrichi par l’IA.

## Vision et feuille de route


### Vision

Notre vision est de devenir un module clé dans l’avenir des solutions de développement pilotées par l’IA, s’intégrant parfaitement à GitHub pour permettre aux LLMs de résoudre automatiquement des tâches de codage complexes.

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Feuille de route

Pour une vue historique de l’ancienne feuille de route, veuillez consulter [Vision and Roadmap](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Remerciements

Nous tenons à exprimer notre gratitude envers les projets open source suivants pour leur soutien et leurs contributions :

- **[LangChain](https://github.com/langchain-ai/langchain)** : Pour avoir fourni le cadre fondamental qui permet les capacités d’invite et de traitement LLM dans llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)** : Pour avoir proposé l’API s.jina.ai et des modèles open source de reranker et d’embedding qui améliorent la précision et la pertinence des contextes générés dans llama-github.

Leurs contributions ont été déterminantes dans le développement de llama-github, et nous recommandons vivement de découvrir leurs projets pour plus de solutions innovantes.

## Contribution

Nous accueillons toutes les contributions à llama-github ! Veuillez consulter nos [directives de contribution](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) pour plus d’informations.

## Licence

Ce projet est sous licence selon les termes de la licence Apache 2.0. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

## Contact

Si vous avez des questions, suggestions ou retours, n’hésitez pas à nous contacter à [l’email de Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Merci d’avoir choisi llama-github ! Nous espérons que cette bibliothèque enrichira votre expérience de développement IA et vous aidera à créer des applications puissantes en toute simplicité.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---