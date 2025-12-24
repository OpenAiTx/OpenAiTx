# Protocole Agent2Agent (A2A)

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Licence Apache](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logo du protocole Agent2Agent" width="100">
    <h1>Protocole Agent2Agent (A2A)</h1>
  </div>
</div>

**Un protocole ouvert permettant la communication et l’interopérabilité entre des applications agentiques opaques.**

Le protocole Agent2Agent (A2A) répond à un défi crucial dans le paysage de l’IA : permettre aux agents d’IA générative, construits sur des cadres divers par différentes entreprises et fonctionnant sur des serveurs séparés, de communiquer et collaborer efficacement – en tant qu’agents, pas seulement en tant qu’outils. A2A vise à fournir un langage commun aux agents, favorisant un écosystème d’IA plus interconnecté, puissant et innovant.

Avec A2A, les agents peuvent :

- Découvrir les capacités des autres.
- Négocier les modalités d’interaction (texte, formulaires, médias).
- Collaborer en toute sécurité sur des tâches de longue durée.
- Opérer sans exposer leur état interne, leur mémoire ou leurs outils.

## Vidéo d’introduction à A2A

[![Vidéo d’intro A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Pourquoi A2A ?

À mesure que les agents d’IA deviennent plus répandus, leur capacité à interopérer est cruciale pour créer des applications complexes et multifonctionnelles. A2A vise à :

- **Briser les silos :** Connecter les agents à travers différents écosystèmes.
- **Permettre une collaboration complexe :** Autoriser des agents spécialisés à travailler ensemble sur des tâches qu’un agent seul ne peut gérer.
- **Promouvoir des standards ouverts :** Favoriser une approche communautaire de la communication entre agents, encourageant l’innovation et une large adoption.
- **Préserver l’opacité :** Permettre aux agents de collaborer sans devoir partager leur mémoire interne, leur logique propriétaire ou des implémentations spécifiques d’outils, renforçant la sécurité et protégeant la propriété intellectuelle.

### Caractéristiques clés

- **Communication standardisée :** JSON-RPC 2.0 sur HTTP(S).
- **Découverte d’agent :** Via des « Cartes d’Agent » détaillant les capacités et les informations de connexion.
- **Interaction flexible :** Prise en charge des requêtes/réponses synchrones, du streaming (SSE) et des notifications push asynchrones.
- **Échange de données riche :** Gère le texte, les fichiers et les données JSON structurées.
- **Prêt pour l’entreprise :** Conçu avec la sécurité, l’authentification et l’observabilité en tête.

## Pour commencer

- 📚 **Explorez la documentation :** Visitez le [site de documentation du protocole Agent2Agent](https://a2a-protocol.org) pour un aperçu complet, la spécification complète du protocole, des tutoriels et des guides.
- 📝 **Voir la spécification :** [Spécification du protocole A2A](https://a2a-protocol.org/latest/specification/)
- Utilisez les SDKs :
    - [🐍 SDK A2A Python](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ SDK A2A Go](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 SDK A2A JS](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ SDK A2A Java](https://github.com/a2aproject/a2a-java) utilisant maven
    - [🔷 SDK A2A .NET](https://github.com/a2aproject/a2a-dotnet) via [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Utilisez nos [exemples](https://github.com/a2aproject/a2a-samples) pour voir A2A en action

## Contribution

Nous accueillons les contributions de la communauté pour améliorer et faire évoluer le protocole A2A !

- **Questions & Discussions :** Rejoignez nos [discussions GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problèmes & Retours :** Signalez des problèmes ou suggérez des améliorations via [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Guide de contribution :** Consultez notre [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) pour les détails sur la contribution.
- **Retour privé :** Utilisez ce [formulaire Google](https://goo.gle/a2a-feedback).
- **Programme partenaire :** Les clients Google Cloud peuvent rejoindre notre programme partenaire via ce [formulaire](https://goo.gle/a2a-partner).

## Et après ?

### Améliorations du protocole

- **Découverte d’agent :**
    - Formaliser l’inclusion des schémas d’autorisation et des identifiants optionnels directement dans la `AgentCard`.
- **Collaboration d’agent :**
    - Étudier une méthode `QuerySkill()` pour vérifier dynamiquement les compétences non prises en charge ou imprévues.
- **Cycle de vie des tâches & UX :**
    - Support de la négociation dynamique de l’UX _au sein_ d’une tâche (ex. agent ajoutant audio/vidéo en cours de conversation).
- **Méthodes client et transport :**
    - Explorer l’extension du support aux méthodes initiées par le client (au-delà de la gestion des tâches).
    - Améliorations de la fiabilité du streaming et des mécanismes de notifications push.

## À propos

Le protocole A2A est un projet open source sous la Fondation Linux, contribué par Google. Il est licencié sous la [Licence Apache 2.0](LICENSE) et ouvert aux contributions de la communauté.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---