![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md) | Français

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Guide

NoteGen est une application de prise de notes `Markdown` multiplateforme dédiée à l’utilisation de l’IA pour faire le lien entre enregistrement et rédaction, organisant les connaissances fragmentées en une note lisible.

🖥️ Documentation officielle : [https://notegen.top](https://notegen.top)

💬 Rejoignez le [Groupe WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## Pourquoi choisir NoteGen ?

- Léger : [Le package d'installation](https://github.com/codexu/note-gen/releases) ne fait que **20 Mo**, gratuit, sans publicité ni logiciel additionnel.
- Multiplateforme : Prend en charge Mac, Windows, Linux, et grâce aux capacités multiplateformes de `Tauri2`, prendra en charge iOS et Android à l'avenir.
- Prend en charge plusieurs méthodes d’enregistrement, incluant `captures d’écran`, `texte`, `illustrations`, `fichiers`, `liens`, etc., répondant aux besoins de prise de notes fragmentées dans divers scénarios.
- Utilise le format natif `Markdown(.md)` comme format de stockage, sans modifications, facilitant la migration.
- Utilisation native hors ligne, prise en charge de la synchronisation en temps réel avec des dépôts privés `GitHub, Gitee` avec retour en arrière historique, et synchronisation WebDAV.
- Amélioré par l’IA : configurable avec ChatGPT, Gemini, Ollama, LM Studio, Grok et d’autres modèles, avec prise en charge de la configuration de modèles tiers personnalisés.
- RAG : Vos notes sont votre base de connaissances. Prend en charge les modèles d’embedding et de reranking.

## Captures d’écran


https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257


Enregistrement :

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Rédaction :

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Thème :

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## De l’enregistrement à la rédaction

Les applications de prise de notes classiques n’offrent généralement pas de fonctionnalité d’enregistrement. L’utilisateur doit copier et coller manuellement le contenu à enregistrer, ce qui réduit considérablement l’efficacité. Face à des contenus enregistrés éparpillés, il faut un effort important pour les organiser.

NoteGen est divisé en pages `Enregistrement` et `Rédaction`, avec la relation suivante :

- Les enregistrements peuvent être organisés en notes et transférés vers la page de rédaction pour une composition approfondie.
- Lors de la rédaction, vous pouvez insérer des enregistrements à tout moment.

### Enregistrement

La fonction d’enregistrement est similaire à un **chatbot IA**, mais lors de la conversation, vous pouvez l’associer au contenu précédemment enregistré, passant du mode conversation au mode organisation pour arranger les enregistrements dans une note lisible.

Les fonctionnalités auxiliaires suivantes peuvent vous aider à enregistrer plus efficacement :

- **Étiquettes** pour distinguer différents scénarios d’enregistrement.
- **Personas** avec prise en charge de prompts personnalisés pour contrôler précisément votre assistant IA.
- **Assistant Presse-papiers** qui reconnaît automatiquement le texte ou les images présents dans votre presse-papiers et les enregistre dans votre liste.

### Rédaction

La section rédaction est divisée en deux parties : **Gestionnaire de fichiers** et **Éditeur Markdown**.

**Gestionnaire de fichiers**

- Prend en charge la gestion des fichiers Markdown locaux et des fichiers synchronisés GitHub.
- Prend en charge une hiérarchie de dossiers illimitée.
- Prend en charge plusieurs méthodes de tri.

**Éditeur Markdown**

- Prend en charge le WYSIWYG, le rendu instantané et les modes d’aperçu en écran partagé.
- Prend en charge le contrôle de version avec retour en arrière historique.
- Prend en charge l’assistance IA pour la conversation, la continuation, l’amélioration et la traduction.
- Prend en charge l’hébergement d’images, l’upload d’images et leur conversion en liens d’images Markdown.
- Prend en charge la conversion HTML vers Markdown, convertit automatiquement le contenu copié du navigateur en format Markdown.
- Prend en charge les plans, formules mathématiques, cartes heuristiques, graphiques, diagrammes de flux, diagrammes de Gantt, diagrammes de séquence, portées musicales, multimédia, lecture vocale, ancres de titres, surlignage et copie de code, rendu graphviz et diagrammes UML plantuml.
- Prend en charge la sauvegarde locale en temps réel, la synchronisation automatique différée (10s sans édition) et le retour en arrière historique.

## Autres fonctionnalités

- Recherche globale pour retrouver et accéder rapidement à un contenu spécifique.
- Gestion de l’hébergement d’images pour gérer facilement le contenu du dépôt d’images.
- Thèmes et apparence avec prise en charge du thème sombre et des réglages d’apparence pour le Markdown, le code, etc.
- Prise en charge de l’internationalisation, actuellement disponible en chinois et en anglais.

## Comment utiliser ?

### Télécharger

Actuellement disponible pour Mac, Windows et Linux. Grâce aux capacités multiplateformes de Tauri2, la prise en charge d’iOS et Android est prévue à l’avenir.

[Télécharger NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Amélioration

L’application de prise de notes peut être utilisée directement sans configuration. Pour une meilleure expérience, ouvrez la page des paramètres pour configurer l’IA et la synchronisation.

## Contribuer

- [Lire le guide de contribution](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Plans de mise à jour](https://github.com/codexu/note-gen/issues/46)
- [Soumettre des bugs ou suggestions d’amélioration](https://github.com/codexu/note-gen/issues)
- [Discussions](https://github.com/codexu/note-gen/discussions)

## Contributeurs

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Historique des étoiles

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---