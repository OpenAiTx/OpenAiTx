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
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logo du protocole Agent2Agent" width="100">
    <h1>Protocole Agent2Agent (A2A)</h1>
  </div>
</div>

**Un protocole ouvert permettant la communication et l’interopérabilité entre des applications agentiques opaques.**

Le protocole Agent2Agent (A2A) répond à un défi crucial dans le paysage de l’IA : permettre à des agents d’IA générative, construits sur divers frameworks par différentes entreprises et fonctionnant sur des serveurs distincts, de communiquer et de collaborer efficacement — en tant qu’agents, pas seulement comme outils. A2A vise à fournir un langage commun aux agents, favorisant un écosystème d’IA plus interconnecté, puissant et innovant.

Avec A2A, les agents peuvent :

- Découvrir les capacités des autres.
- Négocier les modalités d’interaction (texte, formulaires, médias).
- Collaborer en toute sécurité sur des tâches de longue durée.
- Fonctionner sans exposer leur état interne, leur mémoire ou leurs outils.

## Cours DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Participez à ce cours court sur [A2A : Le Protocole Agent2Agent](https://goo.gle/dlai-a2a), conçu en partenariat avec Google Cloud et IBM Research, et enseigné par [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), et [Sandi Besen](https://github.com/sandijean90).

**Ce que vous apprendrez :**

- **Rendre les agents compatibles A2A :** Exposez des agents construits avec des frameworks comme Google ADK, LangGraph ou BeeAI sous forme de serveurs A2A.
- **Connecter les agents :** Créez des clients A2A à partir de zéro ou en utilisant des intégrations pour se connecter à des agents compatibles A2A.
- **Orchestrer des workflows :** Construisez des workflows séquentiels et hiérarchiques d’agents compatibles A2A.
- **Systèmes multi-agents :** Construisez un système multi-agent dans le domaine de la santé utilisant différents frameworks et voyez comment A2A permet la collaboration.
- **A2A et MCP :** Découvrez comment A2A complète MCP en permettant aux agents de collaborer entre eux.

## Pourquoi A2A ?

À mesure que les agents d’IA deviennent plus répandus, leur capacité à interopérer est cruciale pour construire des applications complexes et multifonctionnelles. A2A vise à :

- **Briser les silos :** Connecter les agents à travers différents écosystèmes.
- **Permettre la collaboration complexe :** Autoriser des agents spécialisés à travailler ensemble sur des tâches qu’un seul agent ne pourrait pas gérer seul.
- **Promouvoir les standards ouverts :** Favoriser une approche communautaire de la communication entre agents, encourageant l’innovation et une large adoption.
- **Préserver l’opacité :** Permettre aux agents de collaborer sans avoir besoin de partager leur mémoire interne, leur logique propriétaire ou des implémentations d’outils spécifiques, renforçant la sécurité et protégeant la propriété intellectuelle.

### Fonctionnalités clés

- **Communication standardisée :** JSON-RPC 2.0 sur HTTP(S).
- **Découverte des agents :** Via des "Cartes d’Agent" détaillant les capacités et les informations de connexion.
- **Interaction flexible :** Prise en charge des requêtes/réponses synchrones, du streaming (SSE) et des notifications push asynchrones.
- **Échange de données riche :** Gère le texte, les fichiers et les données JSON structurées.
- **Prêt pour l’entreprise :** Conçu avec sécurité, authentification et observabilité à l’esprit.

## Pour commencer

- 📚 **Explorer la documentation :** Visitez le [site de documentation du protocole Agent2Agent](https://a2a-protocol.org) pour une vue d’ensemble complète, la spécification complète du protocole, des tutoriels et des guides.
- 📝 **Voir la spécification :** [Spécification du protocole A2A](https://a2a-protocol.org/latest/specification/)
- Utilisez les SDK :
    - [🐍 SDK Python A2A](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ SDK Go A2A](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 SDK JS A2A](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ SDK Java A2A](https://github.com/a2aproject/a2a-java) en utilisant maven
    - [🔷 SDK .NET A2A](https://github.com/a2aproject/a2a-dotnet) via [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Utilisez nos [exemples](https://github.com/a2aproject/a2a-samples) pour voir A2A en action

## Contribution

Nous accueillons les contributions de la communauté pour améliorer et faire évoluer le protocole A2A !

- **Questions & Discussions :** Rejoignez nos [discussions GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problèmes & Retours :** Signalez des problèmes ou suggérez des améliorations via [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Guide de contribution :** Consultez notre [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) pour savoir comment contribuer.
- **Retour privé :** Utilisez ce [Google Form](https://goo.gle/a2a-feedback).
- **Programme Partenaire :** Les clients Google Cloud peuvent rejoindre notre programme partenaire via ce [formulaire](https://goo.gle/a2a-partner).

## Et après

### Améliorations du protocole

- **Découverte des agents :**
    - Formaliser l’inclusion des schémas d’autorisation et des identifiants optionnels directement dans la `AgentCard`.
- **Collaboration entre agents :**
    - Étudier une méthode `QuerySkill()` pour vérifier dynamiquement les compétences non prises en charge ou inattendues.
- **Cycle de vie des tâches & UX :**
    - Prise en charge de la négociation UX dynamique _au sein_ d'une tâche (par exemple, un agent ajoutant de l'audio/vidéo en cours de conversation).
- **Méthodes client et transport :**
    - Explorer l'extension du support aux méthodes initiées par le client (au-delà de la gestion des tâches).
    - Améliorations de la fiabilité du streaming et des mécanismes de notifications push.

## À propos

Le protocole A2A est un projet open source sous l'égide de la Linux Foundation, contribué par Google. Il est sous licence [Apache License 2.0](LICENSE) et ouvert aux contributions de la communauté.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---