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

**Un protocole ouvert permettant la communication et l'interopérabilité entre des applications agentiques opaques.**

Le protocole Agent2Agent (A2A) répond à un défi majeur dans le domaine de l'IA : permettre aux agents IA génératifs, construits sur différents frameworks par diverses entreprises et fonctionnant sur des serveurs séparés, de communiquer et collaborer efficacement - en tant qu'agents, et non seulement comme outils. A2A vise à fournir un langage commun aux agents, favorisant un écosystème IA plus interconnecté, puissant et innovant.

Avec A2A, les agents peuvent :

- Découvrir les capacités des autres.
- Négocier les modalités d'interaction (texte, formulaires, médias).
- Collaborer de manière sécurisée sur des tâches de longue durée.
- Fonctionner sans exposer leur état interne, mémoire ou outils.

## Vidéo d'introduction à A2A

[![Vidéo d'intro A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Pourquoi A2A ?

À mesure que les agents IA se généralisent, leur capacité à interopérer est essentielle pour créer des applications complexes et multifonctionnelles. A2A vise à :

- **Briser les silos :** Connecter les agents à travers différents écosystèmes.
- **Permettre une collaboration complexe :** Permettre à des agents spécialisés de travailler ensemble sur des tâches qu'un agent seul ne peut pas traiter.
- **Favoriser les standards ouverts :** Encourager une approche communautaire de la communication agentique, stimulant l'innovation et l'adoption large.
- **Préserver l'opacité :** Permettre aux agents de collaborer sans avoir à partager leur mémoire interne, logique propriétaire ou implémentation d'outils spécifiques, renforçant la sécurité et protégeant la propriété intellectuelle.

### Fonctionnalités clés

- **Communication standardisée :** JSON-RPC 2.0 via HTTP(S).
- **Découverte d'agents :** Grâce aux « Cartes d'agent » détaillant capacités et informations de connexion.
- **Interaction flexible :** Prise en charge des requêtes/réponses synchrones, du streaming (SSE) et des notifications push asynchrones.
- **Échange de données riche :** Prise en charge du texte, des fichiers et des données structurées JSON.
- **Prêt pour l'entreprise :** Conçu avec la sécurité, l'authentification et l'observabilité à l'esprit.

## Pour commencer

- 📚 **Explorez la documentation :** Visitez le [Site de documentation du protocole Agent2Agent](https://a2a-protocol.org) pour un aperçu complet, la spécification complète du protocole, des tutoriels et des guides.
- 📝 **Voir la spécification :** [Spécification du protocole A2A](https://a2a-protocol.org/latest/specification/)
- Utilisez les SDK :
    - [🐍 SDK Python A2A](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ SDK Go A2A](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 SDK JS A2A](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ SDK Java A2A](https://github.com/a2aproject/a2a-java) avec maven
    - [🔷 SDK .NET A2A](https://github.com/a2aproject/a2a-dotnet) via [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Utilisez nos [exemples](https://github.com/a2aproject/a2a-samples) pour voir A2A en action

## Contribuer

Nous accueillons volontiers les contributions de la communauté pour améliorer et faire évoluer le protocole A2A !

- **Questions & Discussions :** Rejoignez nos [Discussions GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problèmes & Suggestions :** Signalez un problème ou proposez des améliorations via les [Issues GitHub](https://github.com/a2aproject/A2A/issues).
- **Guide de contribution :** Consultez notre [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) pour savoir comment contribuer.
- **Retour privé :** Utilisez ce [Formulaire Google](https://goo.gle/a2a-feedback).
- **Programme partenaire :** Les clients Google Cloud peuvent rejoindre notre programme partenaire via ce [formulaire](https://goo.gle/a2a-partner).

## Et après

### Améliorations du protocole

- **Découverte des agents :**
    - Formaliser l’inclusion des schémas d’autorisation et des identifiants optionnels directement dans la `AgentCard`.
- **Collaboration entre agents :**
    - Étudier une méthode `QuerySkill()` pour vérifier dynamiquement des compétences non prises en charge ou inattendues.
- **Cycle de vie des tâches & UX :**
    - Prise en charge de la négociation UX dynamique _au sein_ d’une tâche (ex. : agent ajoutant audio/vidéo en cours de conversation).
- **Méthodes client & transport :**
    - Explorer l’extension du support aux méthodes initiées par le client (au-delà de la gestion des tâches).
    - Améliorations de la fiabilité du streaming et des mécanismes de notification push.

## À propos

Le protocole A2A est un projet open source de la Linux Foundation, proposé par Google. Il est sous licence [Apache License 2.0](LICENSE) et ouvert aux contributions de la communauté.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---