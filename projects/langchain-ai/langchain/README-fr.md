<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="Logo LangChain" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Notes de version](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - Licence](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Téléchargements](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![Graphique des étoiles GitHub](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Problèmes ouverts](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Ouvrir dans Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Ouvrir dans Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![Badge CodSpeed](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> Vous cherchez la bibliothèque JS/TS ? Consultez [LangChain.js](https://github.com/langchain-ai/langchainjs).

LangChain est un framework pour créer des applications propulsées par des LLM. Il vous aide à enchaîner des composants interopérables et des intégrations tierces pour simplifier le développement d’applications d’IA — tout en garantissant la pérennité de vos choix à mesure que la technologie évolue.

```bash
pip install -U langchain
```

Pour en savoir plus sur LangChain, consultez
[la documentation](https://python.langchain.com/docs/introduction/). Si vous recherchez une personnalisation avancée ou l’orchestration d’agents, consultez
[LangGraph](https://langchain-ai.github.io/langgraph/), notre framework pour construire des workflows d’agents contrôlables.

## Pourquoi utiliser LangChain ?

LangChain aide les développeurs à créer des applications alimentées par des LLM grâce à une interface standard pour les modèles, les embeddings, les magasins de vecteurs et plus encore.

Utilisez LangChain pour :
- **L’augmentation de données en temps réel**. Connectez facilement les LLM à diverses sources de données et à des systèmes externes/internes, en tirant parti de la vaste bibliothèque d’intégrations de LangChain avec des fournisseurs de modèles, des outils, des magasins de vecteurs, des récupérateurs, et plus.
- **Interopérabilité des modèles**. Changez de modèle à volonté pendant que votre équipe d’ingénierie expérimente afin de trouver la meilleure solution pour votre application. À mesure que le secteur évolue, adaptez-vous rapidement — les abstractions de LangChain vous permettent d’avancer sans perdre de temps.

## L’écosystème de LangChain

Bien que le framework LangChain puisse être utilisé seul, il s’intègre également parfaitement avec tout produit LangChain, offrant ainsi aux développeurs une suite complète d’outils pour la création d’applications LLM.

Pour améliorer le développement de vos applications LLM, associez LangChain à :

- [LangSmith](http://www.langchain.com/langsmith) – Pratique pour l’évaluation des agents et l’observabilité. Déboguez les exécutions d’applications LLM peu performantes, évaluez les trajectoires des agents, gagnez en visibilité en production et améliorez les performances dans le temps.
- [LangGraph](https://langchain-ai.github.io/langgraph/) – Créez des agents capables de gérer de manière fiable des tâches complexes avec LangGraph, notre framework d’orchestration d’agents bas niveau. LangGraph offre une architecture personnalisable, une mémoire à long terme et des workflows avec intervention humaine — et est utilisé en production par des entreprises telles que LinkedIn, Uber, Klarna et GitLab.
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) – Déployez et faites évoluer des agents sans effort grâce à une plateforme de déploiement dédiée aux workflows persistants et à état. Découvrez, réutilisez, configurez et partagez des agents entre équipes — et itérez rapidement grâce au prototypage visuel dans
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## Ressources supplémentaires
- [Tutoriels](https://python.langchain.com/docs/tutorials/) : Des guides pratiques avec des exemples pour bien démarrer avec LangChain.
- [Guides pratiques](https://python.langchain.com/docs/how_to/) : Des extraits de code rapides et concrets sur des sujets comme l’appel d’outils, les cas d’usage RAG, etc.
- [Guides conceptuels](https://python.langchain.com/docs/concepts/) : Explications des concepts clés derrière le framework LangChain.
- [Référence API](https://python.langchain.com/api_reference/) : Référence détaillée sur la navigation dans les packages de base et les intégrations de LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---