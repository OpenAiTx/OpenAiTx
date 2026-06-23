# Protocole Agent2Agent (A2A)

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Demander Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Langue</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Logo du protocole Agent2Agent" width="100">
    <h1>Protocole Agent2Agent (A2A)</h1>
  </div>
</div>

**Un protocole ouvert permettant la communication et l’interopérabilité entre applications agentiques opaques.**

Le protocole Agent2Agent (A2A) répond à un défi majeur dans le domaine de l’IA : permettre à des agents génériques d’IA, construits sur des frameworks variés, par différentes entreprises et fonctionnant sur des serveurs séparés, de communiquer et de collaborer efficacement – en tant qu’agents, et non seulement comme outils. A2A vise à fournir un langage commun aux agents, favorisant un écosystème d’IA plus interconnecté, puissant et innovant.

Avec A2A, les agents peuvent :

- Découvrir les capacités des autres agents.
- Négocier des modalités d’interaction (texte, formulaires, médias).
- Collaborer en toute sécurité sur des tâches de longue durée.
- Fonctionner sans exposer leur état interne, leur mémoire ou leurs outils.

## Cours DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Participez à ce cours court sur [A2A : Le protocole Agent2Agent](https://goo.gle/dlai-a2a), conçu en partenariat avec Google Cloud et IBM Research, et enseigné par [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini) et [Sandi Besen](https://github.com/sandijean90).

**Ce que vous apprendrez :**

- **Rendre les agents compatibles A2A :** Exposez des agents construits avec des frameworks comme Google ADK, LangGraph ou BeeAI en tant que serveurs A2A.
- **Connecter des agents :** Créez des clients A2A de zéro ou à l’aide d’intégrations pour se connecter à des agents compatibles A2A.
- **Orchestrer des flux de travail :** Construisez des flux de travail séquentiels et hiérarchiques d’agents compatibles A2A.
- **Systèmes multi-agents :** Construisez un système multi-agents pour la santé à partir de frameworks différents et découvrez comment A2A permet la collaboration.
- **A2A et MCP :** Apprenez comment A2A complète MCP en permettant aux agents de collaborer entre eux.

## Pourquoi A2A ?

À mesure que les agents d’IA se généralisent, leur capacité à interopérer devient essentielle pour construire des applications complexes et multifonctionnelles. A2A vise à :

- **Casser les silos :** Connecter les agents à travers différents écosystèmes.
- **Permettre une collaboration complexe :** Permettre à des agents spécialisés de travailler ensemble sur des tâches qu’un agent seul ne pourrait pas gérer.
- **Promouvoir des standards ouverts :** Favoriser une approche communautaire de la communication agentique, encourageant l’innovation et une adoption large.
- **Préserver l’opacité :** Permettre aux agents de collaborer sans partager leur mémoire interne, leur logique propriétaire ou leurs outils spécifiques, renforçant la sécurité et protégeant la propriété intellectuelle.

### Fonctionnalités clés

- **Communication standardisée :** JSON-RPC 2.0 sur HTTP(S).
- **Découverte d'agents :** Via des "Cartes d'Agent" détaillant les capacités et les informations de connexion.
- **Interaction flexible :** Prend en charge la requête/réponse synchrone, le streaming (SSE) et les notifications push asynchrones.
- **Échange de données enrichi :** Gère le texte, les fichiers et les données JSON structurées.
- **Prêt pour l'entreprise :** Conçu avec sécurité, authentification et observabilité à l'esprit.

## Pour commencer

- 📚 **Explorez la documentation :** Visitez le [Site de documentation du protocole Agent2Agent](https://a2a-protocol.org) pour une vue d'ensemble complète, la spécification du protocole, des tutoriels et des guides.
- 📝 **Voir la spécification :** [Spécification du protocole A2A](https://a2a-protocol.org/latest/specification/)
- Utilisez les SDKs :
    - [🐍 SDK Python A2A](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ SDK Go A2A](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 SDK JS A2A](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ SDK Java A2A](https://github.com/a2aproject/a2a-java) utilisant maven
    - [🔷 SDK .NET A2A](https://github.com/a2aproject/a2a-dotnet) utilisant [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 SDK Rust A2A](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 Utilisez nos [exemples](https://github.com/a2aproject/a2a-samples) pour voir A2A en action

## Contribution

Nous accueillons avec plaisir les contributions de la communauté pour améliorer et faire évoluer le protocole A2A !

- **Questions & Discussions :** Rejoignez nos [Discussions GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problèmes & Retours :** Signalez des problèmes ou suggérez des améliorations via [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Guide de contribution :** Voir notre [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) pour les détails sur la contribution.
- **Retour privé :** Utilisez ce [formulaire Google](https://goo.gle/a2a-feedback).
- **Programme partenaire :** Les clients Google Cloud peuvent rejoindre notre programme partenaire via ce [formulaire](https://goo.gle/a2a-partner).

## Prochaines étapes

### Améliorations du protocole

- **Découverte d'agents :**
    - Formaliser l'inclusion des schémas d'autorisation et des identifiants facultatifs directement dans la `AgentCard`.
- **Collaboration entre agents :**
    - Étudier une méthode `QuerySkill()` pour vérifier dynamiquement les compétences non prises en charge ou inattendues.
- **Cycle de vie des tâches et UX :**
    - Prise en charge de la négociation UX dynamique _au sein_ d'une tâche (par exemple, un agent ajoutant de l'audio/vidéo en cours de conversation).
- **Méthodes client et transport :**
    - Explorer l’extension de la prise en charge aux méthodes initiées par le client (au-delà de la gestion des tâches).
    - Améliorations de la fiabilité du streaming et des mécanismes de notification push.

## À propos

Le protocole A2A est un projet open source sous l'égide de la Linux Foundation, contribué par Google. Il est sous licence [Apache License 2.0](LICENSE) et ouvert aux contributions de la communauté.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---