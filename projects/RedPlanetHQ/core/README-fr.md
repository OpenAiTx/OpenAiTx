<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://getcore.me">
    <img width="200px" alt="CORE logo" src="https://github.com/user-attachments/assets/bd4e5e79-05b8-4d40-9aff-f1cf9e5d70de" />
  </a>

# Votre OS IA personnel.

**Lancez votre OS.** Surveille votre travail. Retient ce qui compte. Agit à travers vos outils et agents. Open source, auto-hébergé, à vous pour toujours.

<p align="center">
<a href="https://getcore.me">
    <img src="https://img.shields.io/badge/Website-getcore.me-c15e50?style=for-the-badge&logo=safari&logoColor=white" alt="Site web" />
</a>
<a href="https://docs.getcore.me">
    <img src="https://img.shields.io/badge/Docs-docs.getcore.me-22C55E?style=for-the-badge&logo=readthedocs&logoColor=white" alt="Documentation" />
</a>
<a href="https://discord.gg/YGUZcvDjUa">
    <img src="https://img.shields.io/badge/Discord-communauté-5865F2?style=for-the-badge&logo=discord&logoColor=white" alt="Discord" />
</a>
<a href="https://github.com/RedPlanetHQ/core/blob/main/LICENSE">
    <img src="https://img.shields.io/badge/License-AGPL%203.0-blue?style=for-the-badge" alt="Licence : AGPL 3.0" />
</a>
</p>
</div>

---

## Voir le fonctionnement

Regardez CORE gérer deux tâches de codage de bout en bout :

[![CORE Démo](https://img.youtube.com/vi/7y_kt_UTYQs/maxresdefault.jpg)](https://www.youtube.com/watch?v=7y_kt_UTYQs)

---

## Ce qu'est CORE

CORE est la couche d'exploitation open source pour le travail natif à l'IA.

Vous écrivez ce qu'il faut faire dans un bloc-notes. CORE prend en charge la tâche, charge le contexte depuis la mémoire et les applications connectées, rédige un plan, exécute le bon agent via la passerelle, gère les obstacles lorsque possible, et revient quand un jugement humain est nécessaire.

Ce n'est pas un chatbot auquel vous envoyez des prompts. C'est la couche qui se souvient, coordonne, agit et escalade.

### L’architecture

| | |
|---|---|
| **Observe** | Contexte issu de vos conversations IA via MCP, plus de 50 applications connectées, et sur Mac, toute application à laquelle vous accordez explicitement l'accès. |
| **Se souvient** | Un graphe de connaissances qui suit non seulement ce que vous avez dit, mais aussi ce que vous avez décidé, quand et pourquoi, à travers chaque outil et chaque conversation. |
| **Agit** | Prend des actions directes dans vos applications connectées, et délègue les travaux plus longs aux agents de codage et de navigation via la passerelle. |
| **Politiques** | Flux d'approbation, règles d'escalade, plans et journaux d'audit pour que l'autonomie reste responsable. |

CORE décide ce qu'il peut faire en toute sécurité, demande avant les actions sensibles et laisse une trace que vous pouvez consulter.

---

## CORE en action

### Déléguez une tâche de codage, revenez à une PR.

Dites à CORE ce qui doit être fait. Il collecte le contexte depuis votre dépôt, vos applications et sa mémoire, élabore un plan, lance une session Claude Code ou Codex, gère les blocages quand il le peut, puis vous ramène une PR. Vous vérifiez quand c'est terminé.

`[ ] Corriger la condition de concurrence dans le flux de paiement de l'issue #312`

### Éclaircissez votre backlog pendant votre sommeil.

Programmez une tâche récurrente pour extraire du backlog à une heure définie. CORE travaille dessus pendant que vous êtes hors ligne. Les sessions fluides attendent votre revue le matin. Les sessions bloquées reviennent avec une question précise, pas un onglet figé.

`[ ] Traiter le backlog de cette nuit à partir de 23h`

### Analysez les alertes avant qu'elles ne deviennent des interruptions.

Programmez une tâche récurrente pour surveiller Sentry, les logs ou toute source d'alerte. Quand une alerte se déclenche, CORE enquête, extrait les traces et incidents précédents, puis décide de traiter ou d'escalader.

Une alerte Sentry se déclenche à 2h du matin. CORE enquête, propose un correctif et vous ping sur Slack pour validation.

### Recevez un briefing du matin qui connaît votre travail.

Programmez une tâche récurrente pour extraire tous les matins depuis l'email, GitHub, Linear et Slack. CORE résume ce qui demande votre attention, ignore ce qui n'en nécessite pas, et transforme automatiquement les suivis en tâches.

### Déléguez où que vous soyez.

Créez des tâches depuis Slack, WhatsApp, Telegram, email ou le web. La passerelle reste active dans Docker ou Railway, pour que CORE puisse récupérer le travail même si votre ordinateur est fermé.

---

## Ce que contient CORE

| | |
|---|---|
| **Mémoire** | Suit vos préférences, décisions, objectifs et directives à travers chaque outil et conversation, afin que chaque tâche démarre avec le contexte chargé. |
| **Tâches** | Unités de travail uniques ou récurrentes avec votre spécification, le plan de CORE, l’état en direct, et un fil de discussion dédié. Chaque tâche peut lancer des sessions de codage ou de navigation. |
| **Bloc-notes** | Une page quotidienne pour les tâches, idées et travaux en cours. Tapez `[ ]` n'importe où et CORE le prend en compte en moins de 3 minutes. |
| **Connecteurs** | Plus de 50 applications via un seul point de terminaison MCP, plus des déclencheurs webhook pour l’automatisation proactive. GitHub, Linear, Jira, Slack, Gmail, Calendar, Sentry, Granola, Todoist, et plus encore. |
| **Compétences** | Plus de 100 instructions réutilisables appliquées automatiquement selon le contexte. Utilisez les compétences intégrées ou écrivez les vôtres pour des flux de travail répétitifs. |
| **Passerelle** | Exécute Claude Code, Codex, des agents de navigation et des commandes locales sur votre machine ou dans Docker / Railway, afin que CORE continue à fonctionner quand votre ordinateur est fermé. |
| **Indépendant du modèle** | Utilisez votre propre fournisseur : Anthropic, OpenAI, ou des modèles open-weight. Auto-hébergez la pile complète pour plus d’isolation. |

---

## Ce que CORE n’est pas

| | |
|---|---|
| **Pas un simple wrapper RAG.** | La mémoire n'est pas seulement des fragments embarqués. C'est un graphe de connaissances qui suit ce que vous avez décidé, quand, et pourquoi. |
| **Pas un constructeur de flux de travail.** | Pas de DAGs à glisser-déposer. Vous écrivez ce qu’il faut faire. CORE élabore le flux de travail et demande quand il a besoin d’un avis. |
| **Pas un autre Devin.** | CORE propose des plans, vous les approuvez. CORE demande des déblocages, vous décidez. CORE ramène des PRs, vous les révisez. Les agents ne fusionnent jamais seuls. |
| **Pas un assistant cloud fermé.** | CORE est open source, auto-hébergeable, indépendant du modèle, et conçu autour de votre infrastructure. |

---

## Démarrage rapide

Open source et auto-hébergé. Vos données restent dans votre infrastructure.

**Installez et lancez CORE :**

```bash
npm install -g @redplanethq/corebrain && corebrain setup
```

L'assistant de configuration demande un répertoire d'installation, un fournisseur d'IA, une clé API et un modèle de chat. Il génère des secrets, démarre la pile et ouvre `http://localhost:3033`.

La plupart des installations locales prennent quelques minutes une fois Docker lancé.

**Ou déployez sur Railway :**

[![Déployer sur Railway](https://railway.app/button.svg)](https://railway.com/deploy/core)

**Connectez une passerelle** pour que CORE puisse piloter votre navigateur, exécuter des agents de codage et accéder aux dossiers locaux :

```bash
corebrain login
corebrain gateway setup
```

**Exigences :** Docker 20.10+, Docker Compose 2.20+, 4 vCPU / 8 Go de RAM

[Guide complet d’auto-hébergement](https://docs.getcore.me/self-hosting/setup)

> Vous voulez l’app Mac ? Inscrivez-vous sur la liste d’attente sur [getcore.me](https://www.getcore.me/).

---

## Benchmark

CORE atteint une précision moyenne de **88,24 %** sur le [benchmark LoCoMo](https://github.com/RedPlanetHQ/core-benchmark) couvrant le raisonnement à un ou plusieurs sauts, en domaine ouvert et temporel.

---

## Nos convictions

- Le chat est une interface. Pas un OS.
- L’intelligence sans mémoire n’est que de la trivia.
- Votre IA doit vous connaître sur tous les outils, pas seulement dans l’onglet actuel.
- Le travail doit passer de l’intention à l’action sans que vous ne serviez de lien.
- L’automatisation sans responsabilité, c’est le chaos.

---

## Documentation

- [**Mémoire**](https://docs.getcore.me/memory/overview) - Graphe temporel de connaissances, classification des faits, recherche pilotée par l’intention
- [**Brouillon**](https://docs.getcore.me/concepts/scratchpad) - L’interface quotidienne où tâches et idées démarrent
- [**Tâches**](https://docs.getcore.me/concepts/tasks) - Plans, état, travail récurrent et contexte lié à la tâche
- [**Boîte à outils**](https://docs.getcore.me/concepts/toolkit) - Plus de 1000 actions sur 50+ apps via MCP
- [**Agent CORE**](https://docs.getcore.me/concepts/meta-agent) - Déclencheurs, mémoire, outils et exécution
- [**Passerelle**](https://docs.getcore.me/access-core/overview) - Accès WhatsApp, Slack, Telegram, email, web et API
- [**Compétences**](https://docs.getcore.me/skills/overview) - Instructions réutilisables pour des workflows répétables
- [**Auto-hébergement**](https://docs.getcore.me/self-hosting/setup) - Guide de déploiement complet
- [**Changelog**](https://docs.getcore.me/opensource/changelog) - Quelles nouveautés

---

## Sécurité

- Certifié CASA Tier 2
- TLS 1.3 en transit
- AES-256 au repos
- Vos données ne sont jamais utilisées pour l'entraînement des modèles
- Auto-hébergement pour une isolation totale
- [Politique de sécurité](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md)
- Vulnérabilités : harshith@poozle.dev

---

## Communauté

Nous développons CORE en public.

Nous partageons la feuille de route et les décisions architecturales ouvertement, car les problèmes les plus difficiles dans la création d'un OS personnel sont mieux résolus avec les personnes qui l'utilisent. Ajoutez une étoile au dépôt, auto-hébergez-le, partagez ce que vous construisez et ouvrez des issues pour ce qui est cassé ou manquant.

- [Discord](https://discord.gg/YGUZcvDjUa) - questions, idées, présentations
- [Documentation de contribution](https://docs.getcore.me/opensource/contributing) - comment contribuer à CORE
- [`good-first-issue`](https://github.com/RedPlanetHQ/core/labels/good-first-issue) - commencez ici

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>

---

<div align="center">

**Auto-hébergez votre OS IA personnel.**

[Ajoutez une étoile à ce dépôt](https://github.com/RedPlanetHQ/core) · [Lisez la documentation](https://docs.getcore.me) · [Rejoignez Discord](https://discord.gg/YGUZcvDjUa)

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-19

---