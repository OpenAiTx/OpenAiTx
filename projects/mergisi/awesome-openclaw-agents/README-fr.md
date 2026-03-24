# 🦞 Agents OpenClaw Exceptionnels

[![Awesome](https://awesome.re/badge.svg)](https://awesome.re)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)
[![Stars](https://img.shields.io/github/stars/mergisi/awesome-openclaw-agents?style=social)](https://github.com/mergisi/awesome-openclaw-agents)
[![Agents](https://img.shields.io/badge/agents-187-blueviolet)](agents/)

> Une collection sélectionnée de **187 modèles d’agents IA prêts pour la production** pour l’écosystème OpenClaw. Chaque modèle est un fichier `SOUL.md` prêt à copier-coller.

<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:4F46E5,100:7C3AED&height=180&section=header&text=%F0%9F%A6%9E%20187%20Mod%C3%A8les%20d'Agents%20OpenClaw&fontSize=36&fontColor=ffffff&fontAlignY=35" width="100%"/>
</p>

<div align="center">

### Passez la configuration. Déployez en 60 secondes.

**[Parcourez les 187 modèles →](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=browse)** · **[Déployez en 60 secondes →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=deploy)**

Choisissez un modèle. Personnalisez la configuration. Obtenez un package complet de déploiement. Aucun terminal requis.

</div>

<div align="center">

📬 **Recevez chaque semaine des modèles d’agents & astuces** — nouveaux modèles, guides de déploiement et mises en avant communautaires tous les mardis.

**[Abonnez-vous à la newsletter →](https://docs.google.com/forms/d/e/1FAIpQLSeIqBjV1LXnR2qQqGSGa-48rAveAmpSKVqlzLqDK2d4D4aVWg/viewform)**

</div>

---

## Contenu

- [Modèles d’agents](#agent-templates) (187 agents répartis en 24 catégories)
  - [Productivité](#productivity) · [Développement](#development) · [Marketing](#marketing--content) · [Business](#business) · [Personnel](#personal)
  - [DevOps](#devops) · [Finance](#finance) · [Éducation](#education) · [Santé](#healthcare) · [Juridique](#legal) · [RH](#hr) · [Créatif](#creative) · [Sécurité](#security)
  - [E-Commerce](#e-commerce) · [Données](#data) · [SaaS](#saas) · [Immobilier](#real-estate) · [Freelance](#freelance) · [Moltbook](#-moltbook-new)
  - [Chaîne d'approvisionnement](#supply-chain) · [Conformité](#compliance) · [Voix](#voice) · [Succès client](#customer-success) · [Automatisation](#automation)
- [Cas d'utilisation](#use-cases) (132 exemples réels)
- [Démarrage rapide](#quickstart)
- [Pourquoi OpenClaw ?](#why-openclaw) (vs Frameworks, Léger, Entreprise)
- [Déploiement rapide avec CrewClaw](#quick-deploy-with-crewclaw)
- [Serveurs MCP](#mcp-servers)
- [Intégrations](#integrations)
- [Outils](#tools)
- [Sécurité](#security)
- [Tutoriels & Guides](#tutorials--guides)
- [Soumettez votre agent](#submit-your-agent)
- [Communauté](#community)

---

## Modèles d'agents

Modèles SOUL.md prêts à l'emploi pour vos agents IA. Copiez le SOUL.md, enregistrez-le avec `openclaw agents add`, et lancez la passerelle.

```bash
# Quick start with any template
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
npm install && cp ../agents/productivity/orion/SOUL.md ./SOUL.md
node bot.js
```

> Les 100 agents sont également disponibles au format JSON lisible par machine : [`agents.json`](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json)

> **Passer la configuration ?** [CrewClaw](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=skip_setup) génère un package complet de déploiement (Dockerfile + docker-compose + bot + README) pour n’importe quel rôle.

### 📋 Productivité

Faire plus avec moins d’effort.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🎯 Orion](agents/productivity/orion/) | Coordination des tâches, gestion de projet | Quand vous avez besoin de priorités quotidiennes, suivi des échéances et alignement d’équipe | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/orion/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=project-manager) |
| [📊 Pulse](agents/productivity/metrics/) | Tableaux de bord analytiques (Mixpanel, Stripe, GA4) | Quand vous voulez des rapports automatiques de métriques quotidiennes/hebdomadaires | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/metrics/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧍 Standup](agents/productivity/daily-standup/) | Collecte de standups quotidiens, résumés d’équipe | Quand votre équipe a besoin de standups asynchrones sans réunion | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/daily-standup/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=project-manager) |
| [📧 Inbox](agents/productivity/inbox-zero/) | Tri des emails, rédaction de réponses, digest quotidien | Quand votre boîte de réception est saturée et nécessite une priorisation | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/inbox-zero/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 Minutes](agents/productivity/meeting-notes/) | Résumés de réunions, suivi des actions | Quand vous avez besoin de notes de réunion automatisées et de suivis | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/meeting-notes/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🍅 Focus Timer](agents/productivity/focus-timer/) | Pomodoro, gestion des sessions de travail profond | Quand vous avez besoin de temps de concentration structuré avec responsabilité | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/focus-timer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ Habit Tracker](agents/productivity/habit-tracker/) | Habitudes quotidiennes, chaînes, responsabilité | Quand vous voulez des check-ins quotidiens et suivre vos chaînes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/habit-tracker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 💻 Développement

Construire le futur, un commit à la fois.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🔎 Lens](agents/development/code-reviewer/) | Revue de PR, scan de sécurité, qualité du code | Quand vous voulez une revue de code automatisée avant fusion | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/code-reviewer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=code-reviewer) |
| [📖 Scribe](agents/development/docs-writer/) | README, docs API, documentation de code | Quand la documentation prend du retard sur votre code | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/docs-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=technical-writer) |
| [🐛 Trace](agents/development/bug-hunter/) | Analyse des erreurs, investigation de causes racines | Quand vous avez besoin d’un débogage et réponse aux incidents plus rapides | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/bug-hunter/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Probe](agents/development/api-tester/) | Tests API, contrôles de santé, performances | Quand vous avez besoin de surveillance continue de l’API et alertes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/api-tester/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 Log](agents/development/changelog/) | Changelog automatique, notes de version à partir de git | Quand vous voulez des notes de version générées depuis les commits | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/changelog/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔗 Dependency Scanner](agents/development/dependency-scanner/) | Scan CVE, vérification licences, chaîne d’approvisionnement | Quand vous avez besoin d’audits de sécurité automatisés des dépendances | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/dependency-scanner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔀 PR Merger](agents/development/pr-merger/) | Fusion automatique, détection de conflits | Quand vous voulez que les PR soient fusionnées automatiquement après validation | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/pr-merger/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗄️ Migration Helper](agents/development/migration-helper/) | Migrations de base de données, différences de schéma, rollback | Quand vous planifiez des changements de base de données et avez besoin de filets de sécurité | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/migration-helper/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Test Writer](agents/development/test-writer/) | Génération de tests unitaires, analyse de couverture | Quand la couverture de test est faible et que vous devez rattraper | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/test-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗂️ Schema Designer](agents/development/schema-designer/) | Schéma DB depuis langage naturel, sortie ERD | Quand vous avez besoin de schémas de base de données conçus à partir des besoins | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/schema-designer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |

> **Vous voulez un agent Ingénieur Logiciel en fonctionnement en 60 secondes ?** [Déployez avec CrewClaw →](https://crewclaw.com/create-agent?role=software-engineer)

### 📣 Marketing & Contenu

Développer votre audience en pilote automatique.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [✍️ Echo](agents/marketing/echo/) | Articles de blog, textes sociaux, emails | Lorsque vous avez besoin d’une production de contenu cohérente sur plusieurs canaux | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/echo/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Buzz](agents/marketing/social-media/) | Gestion Twitter, LinkedIn, threads | Quand vous voulez des publications sociales programmées avec suivi de l’engagement | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/social-media/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [🔍 Rank](agents/marketing/seo-writer/) | Contenu SEO, recherche de mots-clés depuis GSC | Quand vous avez besoin de contenu optimisé SEO basé sur des données réelles de recherche | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/seo-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=seo-specialist) |
| [📬 Digest](agents/marketing/newsletter/) | Curation de newsletter, rédaction d’emails | Quand vous voulez une newsletter hebdomadaire sans travail manuel | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/newsletter/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🔭 Scout](agents/marketing/competitor-watch/) | Surveillance des concurrents, infos tarifaires | Quand vous devez suivre quotidiennement les actions des concurrents | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/competitor-watch/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔎 Reddit Scout](agents/marketing/reddit-scout/) | Surveillance de subreddits, opportunités de réponse | Quand vous voulez trouver et interagir avec des threads Reddit pertinents | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/reddit-scout/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎵 TikTok Repurposer](agents/marketing/tiktok-repurposer/) | Conversion de blogs en scripts vidéo | Quand vous voulez recycler du contenu long en vidéos courtes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/tiktok-repurposer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [📨 Cold Outreach](agents/marketing/cold-outreach/) | Recherche de prospects, emails froids personnalisés | Quand vous avez besoin d’une prospection scalable sans paraître robotique | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/cold-outreach/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=sales-representative) |
| [📊 A/B Test Analyzer](agents/marketing/ab-test-analyzer/) | Analyse d’expérimentations, significativité statistique | Quand vous faites des tests et avez besoin de résultats clairs | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ab-test-analyzer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Influencer Finder](agents/marketing/influencer-finder/) | Recherche d’influenceurs, prise de contact, campagnes | Quand vous souhaitez trouver et contacter des influenceurs pertinents | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/influencer-finder/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [👁️ Brand Monitor](agents/marketing/brand-monitor/) | Surveillance des mentions de marque, alertes de sentiment | Quand vous voulez être informé à chaque mention de votre marque | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/brand-monitor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📧 Email Sequence](agents/marketing/email-sequence/) | Campagnes drip multi-étapes, lignes d’objet | Quand vous avez besoin de séquences d’emails automatisées | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/email-sequence/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [♻️ Content Repurposer](agents/marketing/content-repurposer/) | Blog vers tweets, posts, scripts shorts | Quand vous voulez un contenu unique sur toutes les plateformes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/content-repurposer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [📖 Book Writer](agents/marketing/book-writer/) | Pipeline complet de production de livre, 6 phases | Quand vous voulez écrire un livre de l’outline au manuscrit | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/book-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [📰 News Curator](agents/marketing/news-curator/) | Scan de sources, curation IA, publication | Quand vous voulez des digests d’actualité automatisés de 50+ sources | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/news-curator/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎥 UGC Video](agents/marketing/ugc-video/) | Contenu vidéo style influenceur IA | Quand vous avez besoin de scripts vidéo UGC et plans de production | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ugc-video/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Multi-Account Social](agents/marketing/multi-account-social/) | Gestion de 10+ comptes, programmation | Quand vous gérez plusieurs comptes de marque sur différentes plateformes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/multi-account-social/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=social-media-manager) |

> **Besoin d’un Rédacteur de contenu ou d’un agent SEO ?** [Déployez avec CrewClaw →](https://crewclaw.com/create-agent?role=content-writer)

### 💼 Business

Gérer les opérations sans surcharge.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [📊 Radar](agents/business/radar/) | Analyse de données, génération d’insights | Quand vous avez besoin de métriques business quotidiennes et d’analyse des tendances | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/radar/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎧 Compass](agents/business/customer-support/) | Tri des tickets, rédaction de réponses, escalade | Quand le volume du support croît plus vite que votre équipe | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/customer-support/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=customer-support) |
| [💼 Pipeline](agents/business/sales-assistant/) | Scoring des leads, prospection, rapports pipeline | Quand vous avez besoin de qualification automatique des leads et de relances | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sales-assistant/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=sales-representative) |
| [💰 Ledger](agents/business/invoice-tracker/) | Suivi des paiements, factures, MRR | Quand vous voulez un suivi en temps réel des revenus et paiements | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/invoice-tracker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔮 Sentinel](agents/business/churn-predictor/) | Scoring du risque de churn, actions de rétention | Quand vous voulez identifier les clients à risque avant qu’ils ne partent | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/churn-predictor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Personal CRM](agents/business/personal-crm/) | Suivi des contacts, rappels de suivi | Quand vous perdez le suivi des relations et relances | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/personal-crm/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💬 WhatsApp Business](agents/business/whatsapp-business/) | Support multi-canaux, qualification des leads | Quand les clients vous contactent sur WhatsApp et ont besoin de réponses rapides | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/whatsapp-business/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=customer-support) |
| [📅 Meeting Scheduler](agents/business/meeting-scheduler/) | Planification intelligente, gestion des fuseaux horaires | Quand planifier des réunions à travers les fuseaux horaires vous prend trop de temps | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/meeting-scheduler/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💲 Competitor Pricing](agents/business/competitor-pricing/) | Suivi des prix, alertes de changement | Quand vous devez surveiller quotidiennement les changements de prix chez les concurrents | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/competitor-pricing/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📞 SDR Outbound](agents/business/sdr-outbound/) | Recherche de leads, prospection personnalisée | Quand vous avez besoin d’un développement commercial sortant automatisé | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sdr-outbound/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎯 Prévisionniste de Deals](agents/business/deal-forecaster/) | Signaux de pipeline, probabilité de clôture | Quand vous souhaitez des prédictions de clôture de deal basées sur les données | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/deal-forecaster/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🗣️ Gestionnaire d'Objections](agents/business/objection-handler/) | Réponses en temps réel, scripts de discussion | Quand les commerciaux ont besoin de réponses instantanées aux objections | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/objection-handler/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=sales-representative) |

### 🧘 Personnel

Votre assistant IA pour la vie quotidienne.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [📅 Atlas](agents/personal/daily-planner/) | Optimisation d'emploi du temps, revues matin/soir | Quand vous voulez une routine quotidienne structurée avec responsabilisation | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/daily-planner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📚 Scroll](agents/personal/reading-digest/) | Résumés d'articles, digest de lecture hebdomadaire | Quand vous avez un retard de lecture et avez besoin de résumés sélectionnés | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/reading-digest/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💪 Iron](agents/personal/fitness-coach/) | Entraînements, nutrition, rapports de progrès | Quand vous voulez un coach personnel qui suit tout | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/fitness-coach/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏠 Domotique](agents/personal/home-automation/) | Contrôle maison intelligente via Telegram | Quand vous voulez piloter votre maison connectée par chat | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/home-automation/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [👨‍👩‍👧‍👦 Coordinateur Familial](agents/personal/family-coordinator/) | Calendrier partagé, repas, rotation des tâches | Quand votre famille a besoin d’un organisateur et planificateur partagé | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/family-coordinator/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ Planificateur de Voyages](agents/personal/travel-planner/) | Itinéraires, vols, hôtels, budgets | Quand vous avez besoin d’organisation de voyage avec recommandations intelligentes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/travel-planner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📓 Incitateur de Journal](agents/personal/journal-prompter/) | Incitations quotidiennes, suivi d’humeur, objectifs | Quand vous voulez un journal guidé quotidien pour la réflexion | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/journal-prompter/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🚀 DevOps

Maintenir l'infrastructure en vie, 24/7.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🚨 Répondant aux Incidents](agents/devops/incident-responder/) | Tri des alertes, coordination d’incidents | Quand vous avez besoin d’une réponse et escalade automatisées aux incidents | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/incident-responder/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🚀 Gardien de Déploiement](agents/devops/deploy-guardian/) | Surveillance CI/CD, état des déploiements | Quand vous voulez des notifications de déploiement et alertes de rollback | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/deploy-guardian/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🖥️ Moniteur Infra](agents/devops/infra-monitor/) | Santé serveur, disque, CPU, mémoire | Quand vous avez besoin d’une surveillance proactive des serveurs avec alertes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/infra-monitor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📜 Analyseur de Logs](agents/devops/log-analyzer/) | Analyse de logs, détection de motifs, anomalies | Quand vous êtes submergé par les logs et avez besoin d’analyse automatisée | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/log-analyzer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💸 Optimiseur de Coûts](agents/devops/cost-optimizer/) | Surveillance des dépenses cloud, suggestions d’économies | Quand votre facture cloud augmente et que vous avez besoin de visibilité | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/cost-optimizer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔧 Serveur Auto-Réparateur](agents/devops/self-healing-server/) | Redémarrage automatique de conteneurs, nettoyage disque | Quand vous voulez des serveurs qui se réparent seuls à 3h du matin | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/self-healing-server/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🍓 Agent Raspberry Pi](agents/devops/raspberry-pi/) | Agent léger pour edge, optimisé faible RAM | Quand vous déployez des agents sur Raspberry Pi ou dispositifs edge | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/raspberry-pi/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 Rédacteur de Runbook](agents/devops/runbook-writer/) | Runbooks opérationnels à partir de l’architecture système | Quand vous avez besoin de procédures documentées pour la gestion d’incidents | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/runbook-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📊 Moniteur SLA](agents/devops/sla-monitor/) | Suivi conformité SLA, alertes de dégradation | Quand vous devez suivre les engagements de disponibilité des services | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/sla-monitor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📐 Planificateur de Capacité](agents/devops/capacity-planner/) | Prévision de capacité d’infrastructure | Quand vous devez planifier la montée en charge de l’infrastructure avant la demande | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/capacity-planner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |

### 💰 Finance

Donner du sens aux chiffres.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🧾 Suivi des Dépenses](agents/finance/expense-tracker/) | Catégorisation des dépenses, alertes budgétaires | Lorsque vous avez besoin d’un suivi automatisé des dépenses et d’une surveillance du budget | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/expense-tracker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧮 Gestionnaire de Factures](agents/finance/invoice-manager/) | Création, suivi et relances de factures | Lorsque les factures se perdent et que les paiements sont en retard | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/invoice-manager/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 Analyste de Revenus](agents/finance/revenue-analyst/) | Analyse du MRR, churn, prévisions de revenus | Lorsque vous souhaitez des rapports automatisés sur les revenus et des prévisions | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/revenue-analyst/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🏦 Préparateur Fiscal](agents/finance/tax-preparer/) | Organisation des reçus, calcul des déductions | Lorsque la saison fiscale approche et que vous devez vous organiser | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/tax-preparer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📉 Bot de Trading](agents/finance/trading-bot/) | Suivi de portefeuille, sentiment, alertes de prix | Lorsque vous souhaitez une surveillance automatisée du marché et des alertes de prix | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/trading-bot/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔍 Détecteur de Fraude](agents/finance/fraud-detector/) | Détection d’anomalies de transactions, alertes de fraude | Lorsque vous avez besoin d’une surveillance en temps réel des fraudes sur les transactions | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/fraud-detector/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Prévisionniste Financier](agents/finance/financial-forecaster/) | Prévisions de revenus/dépenses à partir de données historiques | Lorsque vous avez besoin de projections financières basées sur les données | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/financial-forecaster/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⚖️ Rééquilibreur de Portefeuille](agents/finance/portfolio-rebalancer/) | Analyse de dérive d’allocation, transactions de rééquilibrage | Lorsque votre portefeuille d’investissement nécessite un rééquilibrage périodique | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/portfolio-rebalancer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💳 Comptes Fournisseurs](agents/finance/accounts-payable/) | Appariement de factures, routage d’approbation, paiements | Lorsque le flux de travail des comptes fournisseurs doit être automatisé et accéléré | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/accounts-payable/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 Copieur de Trades](agents/finance/copy-trader/) | Copie des transactions des meilleurs performeurs, contrôles de risque | Lorsque vous souhaitez une réplication automatisée des trades sur les marchés prédictifs | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/copy-trader/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🎓 Éducation

Apprendre plus intelligemment, pas plus durement.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🎓 Tuteur](agents/education/tutor/) | Explication de concepts, exercices pratiques | Lorsque vous avez besoin d’un tuteur patient disponible 24/7 | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/tutor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [❓ Générateur de Quiz](agents/education/quiz-maker/) | Génération de quiz, suivi des scores | Lorsque vous souhaitez des quiz automatisés à partir de votre matériel d’étude | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/quiz-maker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📖 Planificateur d’Études](agents/education/study-planner/) | Calendriers d’étude, rappels | Lorsque vous avez besoin d’un plan d’étude structuré avec rappels quotidiens | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/study-planner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 Assistant de Recherche](agents/education/research-assistant/) | Recherche d’articles, résumés, citations | Lorsque vous faites des recherches et avez besoin d’aide pour trouver des articles | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/research-assistant/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌍 Tuteur de Langues](agents/education/language-tutor/) | Apprentissage des langues, pratique de conversation | Lorsque vous souhaitez une pratique quotidienne des langues sur votre téléphone | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/language-tutor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📐 Concepteur de Curriculum](agents/education/curriculum-designer/) | Plans de cours, objectifs d’apprentissage | Lorsque vous avez besoin d’une conception de cours structurée et de grilles d’évaluation | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/curriculum-designer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 Correcteur d’Essais](agents/education/essay-grader/) | Feedback sur essais, notation basée sur une grille | Lorsque vous avez besoin d’une évaluation cohérente des essais à grande échelle | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/essay-grader/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🃏 Générateur de Flashcards](agents/education/flashcard-generator/) | Cartes à répétition espacée à partir de notes | Lorsque vous souhaitez des flashcards automatisées pour étudier efficacement | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/flashcard-generator/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🏥 Santé

Prendre soin de ce qui compte le plus.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🧘 Coach Bien-être](agents/healthcare/wellness-coach/) | Bilans quotidiens, santé mentale, habitudes | Lorsque vous souhaitez des rappels quotidiens de bien-être et un suivi de l’humeur | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/wellness-coach/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🥗 Planificateur de Repas](agents/healthcare/meal-planner/) | Plans de repas, suivi nutritionnel | Lorsque vous avez besoin de plans de repas hebdomadaires basés sur vos objectifs | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/meal-planner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏋️ Suivi d’Entraînement](agents/healthcare/workout-tracker/) | Plans d’entraînement, suivi des progrès | Lorsque vous souhaitez un plan d’entraînement qui s’adapte à vos progrès | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/workout-tracker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🩺 Tri des Symptômes](agents/healthcare/symptom-triage/) | Évaluation structurée des symptômes, urgence | Lorsque les patients ont besoin d’une évaluation initiale des symptômes et d’orientation | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/symptom-triage/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📋 Notes Cliniques](agents/healthcare/clinical-notes/) | Documentation clinique au format SOAP | Lorsque les consultations cliniques nécessitent une transcription structurée des notes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/clinical-notes/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [💊 Vérificateur de Médicaments](agents/healthcare/medication-checker/) | Interactions médicamenteuses, alertes de dosage | Lorsque vous devez vérifier la sécurité des médicaments et leurs interactions | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/medication-checker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📝 Admission Patient](agents/healthcare/patient-intake/) | Formulaires d’admission, vérification d’assurance | Lorsque l’enregistrement des patients doit être automatisé et accéléré | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/patient-intake/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=fitness-coach) |

### ⚖️ Juridique

Naviguer dans les petites lignes.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [📜 Relecteur de Contrats](agents/legal/contract-reviewer/) | Relecture de contrats, détection de clauses risquées | Lorsque vous relisez des contrats et avez besoin d’un second avis | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/contract-reviewer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ Vérificateur de Conformité](agents/legal/compliance-checker/) | Suivi de conformité, suivi des échéances | Lorsque vous devez rester à jour avec les exigences réglementaires | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/compliance-checker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 Rédacteur de Politiques](agents/legal/policy-writer/) | Politiques internes, conditions d’utilisation | Lorsque vous devez rédiger ou mettre à jour les politiques de l’entreprise | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/policy-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 Analyseur de Brevets](agents/legal/patent-analyzer/) | Revendications de brevet, antériorités, risque d’infraction | Lorsque vous avez besoin d’une analyse du paysage des brevets et d’une évaluation des risques | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/patent-analyzer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 Rédacteur de Mémoires Juridiques](agents/legal/legal-brief-writer/) | Rédaction de mémoires, requêtes, notes | Lorsque vous avez besoin de documents juridiques rédigés à partir des faits d’un dossier | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/legal-brief-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔒 Générateur de NDA](agents/legal/nda-generator/) | NDA personnalisés, accords de confidentialité | Lorsque vous avez besoin d’une génération rapide et personnalisée de NDA | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/nda-generator/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 👥 RH

Construire des équipes efficaces.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🤝 Recruteur](agents/hr/recruiter/) | Tri de CV, planification d’entretiens | Lorsque vous recrutez et avez besoin d’un tri plus rapide des candidats | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/recruiter/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎒 Intégration](agents/hr/onboarding/) | Mise en place des nouveaux employés, guides d’orientation | Lorsque les nouveaux employés ont besoin d’une expérience d’intégration guidée | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/onboarding/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📊 Évaluateur de Performance](agents/hr/performance-reviewer/) | Collecte de feedback, synthèses d’évaluation | Lorsqu’arrive la période d’évaluation et que vous avez besoin de retours structurés | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/performance-reviewer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 Sélecteur de CV](agents/hr/resume-screener/) | Notation de CV, classement des candidats | Lorsque vous traitez un grand volume de candidatures | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/resume-screener/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🚪 Entretien de Sortie](agents/hr/exit-interview/) | Entretiens de sortie structurés, analyses de rétention | Lorsque vous devez comprendre pourquoi les employés quittent | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/exit-interview/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎁 Conseiller en Avantages](agents/hr/benefits-advisor/) | FAQ avantages sociaux, conseils sur les politiques | Lorsque les employés ont des questions sur les avantages et politiques | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/benefits-advisor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💰 Benchmark de Rémunération](agents/hr/compensation-benchmarker/) | Données salariales, analyse des taux du marché | Lorsque vous avez besoin de recommandations de rémunération basées sur des données | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/compensation-benchmarker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎨 Créatif

Rendre beau et engageant.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🎨 Designer de Marque](agents/creative/brand-designer/) | Directives de marque, palettes de couleurs | Lorsque vous construisez ou renouvelez votre identité de marque | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/brand-designer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 Scénariste Vidéo](agents/creative/video-scripter/) | Scripts vidéo, plans, listes de prises | Lorsque vous avez besoin de contenu vidéo mais détestez écrire les scripts | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/video-scripter/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎙️ Producteur de Podcast](agents/creative/podcast-producer/) | Planification d’épisodes, notes de l’émission | Lorsque vous animez un podcast et avez besoin d’aide pour la planification | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/podcast-producer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🧑‍💻 Chercheur UX](agents/creative/ux-researcher/) | Enquêtes utilisateur, analyse de feedback | Lorsque vous avez besoin d’insights utilisateurs sans embaucher un chercheur | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ux-researcher/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [✏️ Rédacteur Publicitaire](agents/creative/copywriter/) | Textes publicitaires, pages d’atterrissage, séquences d’e-mails | Lorsque vous avez besoin rapidement de textes axés sur la conversion | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/copywriter/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🖼️ Designer de Vignettes](agents/creative/thumbnail-designer/) | Concepts de vignettes YouTube/social | Lorsque vous avez besoin d’idées de vignettes qui attirent l’attention | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/thumbnail-designer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [📢 Rédacteur d’Annonces](agents/creative/ad-copywriter/) | Variantes d’annonces Google, Meta, LinkedIn | Lorsque vous avez besoin de textes d’annonces pour tests A/B sur plusieurs plateformes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ad-copywriter/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 Scénariste Storyboard](agents/creative/storyboard-writer/) | Storyboards visuels, listes de plans | Quand vous avez besoin d'une planification pré-production pour du contenu vidéo | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/storyboard-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |

### 🔒 Sécurité

Protéger ce que vous avez construit.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🛡️ Scanner Vulnérabilités](agents/security/vuln-scanner/) | Analyse des vulnérabilités, priorisation des corrections | Quand vous avez besoin d’une analyse de sécurité continue de votre stack | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/vuln-scanner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔐 Auditeur d’Accès](agents/security/access-auditor/) | Revue des permissions, détection d’accès excessifs | Quand vous devez auditer qui a accès à quoi | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/access-auditor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [👁️ Moniteur de Menaces](agents/security/threat-monitor/) | Surveillance des flux de menaces, alertes pertinentes | Quand vous voulez une alerte précoce sur les menaces ciblant votre stack | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/threat-monitor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📓 Journalier d’Incidents](agents/security/incident-logger/) | Documentation des incidents de sécurité | Quand vous avez besoin d’un suivi structuré des incidents et d’analyses post-mortem | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/incident-logger/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔒 Renforceur de Sécurité](agents/security/security-hardener/) | Audit SOUL.md, durcissement des passerelles | Quand vous voulez renforcer la configuration de vos agents et passerelles | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/security-hardener/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🎣 Détecteur de Phishing](agents/security/phishing-detector/) | Analyse de phishing par email, scan d’URL | Quand votre équipe a besoin d’une détection automatisée de phishing | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/phishing-detector/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |

### 🛒 E-Commerce

Vendre plus, gérer moins.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🏷️ Listeur de Produits](agents/ecommerce/product-lister/) | Optimisation des listings, titres SEO | Quand vous avez besoin de listings produits optimisés sur plusieurs marketplaces | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/product-lister/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [⭐ Répondeur d’Avis](agents/ecommerce/review-responder/) | Réponses automatiques aux avis clients | Quand les avis clients nécessitent des réponses rapides et cohérentes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/review-responder/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=customer-support) |
| [📦 Suivi d’Inventaire](agents/ecommerce/inventory-tracker/) | Surveillance des stocks, alertes de réapprovisionnement | Quand vous devez éviter les ruptures et les surstocks | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/inventory-tracker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💲 Optimiseur de Tarification](agents/ecommerce/pricing-optimizer/) | Tarification dynamique, suivi de la concurrence | Quand vous souhaitez une tarification ajustée aux conditions du marché | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/pricing-optimizer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🛒 Panier Abandonné](agents/ecommerce/abandoned-cart/) | Récupération de paniers, séquences de reconquête | Quand vous perdez des ventes à cause de paniers abandonnés | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/abandoned-cart/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🔍 Chercheur Dropshipping](agents/ecommerce/dropshipping-researcher/) | Recherche de produit 24/7, analyse fournisseurs | Quand vous avez besoin d’une découverte continue de produits pour le dropshipping | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/dropshipping-researcher/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |

> **Vous gérez une boutique Shopify ou Amazon ?** [Déployez un agent E-Commerce →](https://crewclaw.com/create-agent?role=customer-support)

### 📊 Données

Transformer les données brutes en décisions.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🔄 Pipeline ETL](agents/data/etl-pipeline/) | Surveillance de pipeline, alertes d’échec, relances | Quand vos pipelines de données ont besoin d’une surveillance automatisée | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/etl-pipeline/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧹 Nettoyeur de Données](agents/data/data-cleaner/) | Contrôles qualité, déduplication, normalisation | Quand vos données sont désordonnées et nécessitent un nettoyage automatisé | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/data-cleaner/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Générateur de Rapports](agents/data/report-generator/) | Rapports automatisés à partir de multiples sources | Quand les parties prenantes ont besoin de rapports réguliers sans travail manuel | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/report-generator/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🗃️ Assistant SQL](agents/data/sql-assistant/) | Aide SQL, optimisation de requêtes, exploration de schémas | Quand vous avez besoin d’un copilote SQL pour des requêtes complexes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/sql-assistant/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 Créateur de tableaux de bord](agents/data/dashboard-builder/) | Tableaux de bord de métriques, maintenance | Quand vous avez besoin de création et mise à jour automatisées de tableaux de bord | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/dashboard-builder/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🚨 Détecteur d'anomalies](agents/data/anomaly-detector/) | Détection d'anomalies métriques, alertes statistiques | Quand vous avez besoin d'alertes automatisées sur des motifs de données inhabituels | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/anomaly-detector/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 Analyseur d'enquêtes](agents/data/survey-analyzer/) | Sentiments, thèmes, ventilation NPS | Quand vous avez des données d'enquête à analyser de manière structurée | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/survey-analyzer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |

> **Besoin d'un agent Analyste de données ?** [Déployez avec CrewClaw →](https://crewclaw.com/create-agent?role=data-analyst)

### ☁️ SaaS

Développez votre produit, fidélisez vos utilisateurs.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déploiement |
|-------|------------|------------------|---------|-------------|
| [🚀 Parcours d'intégration](agents/saas/onboarding-flow/) | Intégration utilisateur, suivi d'activation | Quand les nouveaux utilisateurs n'atteignent pas leur moment aha | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/onboarding-flow/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=project-manager) |
| [💡 Demande de fonctionnalités](agents/saas/feature-request/) | Collecte de demandes, priorisation, vote | Quand les demandes de fonctionnalités sont dispersées sur plusieurs canaux | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/feature-request/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=project-manager) |
| [🔮 Prévention de churn](agents/saas/churn-prevention/) | Prévention proactive du churn, scoring de santé | Quand les utilisateurs partent et vous ne savez pas pourquoi | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/churn-prevention/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Analyse d'utilisation](agents/saas/usage-analytics/) | Utilisation du produit, suivi de l'adoption des fonctionnalités | Quand vous devez comprendre comment les utilisateurs utilisent votre produit | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/usage-analytics/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📝 Notes de version](agents/saas/release-notes/) | Notes de version automatiques depuis git et PRs | Quand écrire les notes de version est une corvée que personne ne veut faire | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/release-notes/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=technical-writer) |

### 🏡 Immobilier

Trouver des bonnes affaires, conclure plus vite.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déploiement |
|-------|------------|------------------|---------|-------------|
| [🏡 Éclaireur d'annonces](agents/real-estate/listing-scout/) | Surveillance de biens, alertes de baisse de prix | Quand vous voulez des alertes instantanées sur les nouvelles annonces et baisses de prix | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/listing-scout/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Analyseur de marché](agents/real-estate/market-analyzer/) | Analyse de marché, rapports comparables | Quand vous avez besoin de comparaisons de marché et d'analyses de tendances automatisées | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/market-analyzer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎯 Qualificateur de leads](agents/real-estate/lead-qualifier/) | Scoring de leads, séquences de suivi | Quand les leads arrivent plus vite que vous ne pouvez les qualifier | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/lead-qualifier/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎬 Vidéo de propriété](agents/real-estate/property-video/) | Vidéos d'annonces, visites virtuelles, mise en scène | Quand vous avez besoin de contenu vidéo immobilier à grande échelle | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/property-video/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [🏢 Immobilier commercial](agents/real-estate/commercial-re/) | Analyse immobilier commercial, taux de capitalisation, suivi des transactions | Quand vous avez besoin d'analyses d'investissement en immobilier commercial | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/commercial-re/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🧑‍💻 Freelance

Travaillez plus intelligemment, facturez plus.

| Agent | Spécialité | Quand l'utiliser | SOUL.md | Déploiement |
|-------|------------|------------------|---------|-------------|
| [📝 Rédacteur de propositions](agents/freelance/proposal-writer/) | Génération de propositions, calcul des tarifs | Quand vous passez trop de temps à écrire des propositions | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/proposal-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=content-writer) |
| [⏱️ Suivi du temps](agents/freelance/time-tracker/) | Suivi du temps, facturation, utilisation | Quand vous perdez des heures facturables à cause d'un mauvais suivi du temps | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/time-tracker/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤝 Gestionnaire de clients](agents/freelance/client-manager/) | CRM client, suivi des contrats | Quand vous gérez plusieurs clients et échéances en même temps | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/client-manager/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=project-manager) |

> **Freelance ?** [Déployez un agent d’assistant personnel →](https://crewclaw.com/create-agent?role=personal-assistant)

### 🤖 Moltbook `NOUVEAU`

Réseau social d’agents IA — la présence de votre agent sur la couche sociale agent-à-agent.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🤖 Community Manager](agents/moltbook/community-manager/) | Publier des mises à jour, engager, construire du karma | Lorsque vous souhaitez que votre agent maintienne une présence sociale sur Moltbook | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/community-manager/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [🔭 Scout](agents/moltbook/scout/) | Scan des flux, suivi de mots-clés, synthèses | Lorsque vous souhaitez surveiller Moltbook pour des discussions et opportunités pertinentes | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/scout/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [📈 Growth Agent](agents/moltbook/growth-agent/) | Croissance des abonnés, gestion des submolts, stratégie | Lorsque vous souhaitez accroître l’influence et la base d’abonnés de votre agent sur Moltbook | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/growth-agent/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?integrations=moltbook) |

> **NOUVEAU : intégration Moltbook !** Votre agent peut désormais publier, interagir et grandir sur le réseau social des agents IA. [Déployer avec Moltbook →](https://crewclaw.com/create-agent?integrations=moltbook)

### 📦 Supply Chain `NOUVEAU`

Optimisation de la logistique et des opérations fournisseurs.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🚚 Route Optimizer](agents/supply-chain/route-optimizer/) | Itinéraires de livraison, trafic, capacité | Lorsque vous avez besoin d’une planification optimisée des livraisons | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/route-optimizer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 Inventory Forecaster](agents/supply-chain/inventory-forecaster/) | Prévision de la demande, points de réapprovisionnement | Lorsque vous devez éviter les ruptures de stock grâce à une prévision intelligente | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/inventory-forecaster/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⭐ Vendor Evaluator](agents/supply-chain/vendor-evaluator/) | Évaluation des fournisseurs, suivi qualité | Lorsque vous avez besoin d’une sélection et d’un classement des fournisseurs basés sur les données | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/vendor-evaluator/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=data-analyst) |

### ✅ Conformité `NOUVEAU`

Anticiper les réglementations.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|------------|------------------|---------|----------|
| [🔒 GDPR Auditor](agents/compliance/gdpr-auditor/) | Analyse des écarts RGPD, plans de remédiation | Lorsque vous devez auditer les systèmes pour la conformité à la protection des données | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/gdpr-auditor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 SOC2 Preparer](agents/compliance/soc2-preparer/) | Collecte de preuves, préparation à l’audit | Lorsque vous préparez la certification SOC 2 | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/soc2-preparer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤖 AI Policy Writer](agents/compliance/ai-policy-writer/) | Gouvernance IA, alignement avec la loi AI de l’UE | Lorsque vous avez besoin de politiques d’utilisation de l’IA pour votre organisation | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/ai-policy-writer/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [⚠️ Risk Assessor](agents/compliance/risk-assessor/) | Évaluation des risques, planification de mitigation | Lorsque vous avez besoin d’une évaluation structurée des risques métier | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/risk-assessor/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎙️ Voix `NOUVEAU`

Agents vocaux et téléphoniques pilotés par IA.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|-----------|-------------|---------|--------|
| [📞 Standardiste Téléphonique](agents/voice/phone-receptionist/) | Gestion des appels, routage, rendez-vous | Quand vous avez besoin d’une couverture téléphonique 24h/24 sans personnel | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/phone-receptionist/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=customer-support) |
| [📝 Transcripteur de Messagerie Vocale](agents/voice/voicemail-transcriber/) | Transcription, extraction d’actions | Quand les messages vocaux doivent être traités et dirigés rapidement | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/voicemail-transcriber/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎤 Bot d’Entretien](agents/voice/interview-bot/) | Entretiens de présélection, grilles d’évaluation | Quand vous avez besoin d’un filtrage structuré des candidats à grande échelle | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/interview-bot/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🤝 Succès Client `NOUVEAU`

Satisfaire les clients et favoriser leur croissance.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|-----------|-------------|---------|--------|
| [📊 Suivi NPS](agents/customer-success/nps-followup/) | Récupération de détracteurs, prise de contact personnalisée | Quand les détracteurs NPS nécessitent une attention immédiate | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/nps-followup/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=customer-support) |
| [🎯 Guide d’Intégration](agents/customer-success/onboarding-guide/) | Configuration produit, conseils contextuels | Quand les nouveaux utilisateurs ont besoin d’une intégration guidée | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/onboarding-guide/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=customer-support) |

### 🔄 Automatisation `NOUVEAU`

Configurez et oubliez. Des agents qui travaillent pendant votre sommeil.

| Agent | Spécialité | Quand l’utiliser | SOUL.md | Déployer |
|-------|-----------|-------------|---------|--------|
| [🤝 Agent de Négociation](agents/automation/negotiation-agent/) | Négociation de factures, conclusion d’accords | Quand vous voulez que l’IA négocie vos factures et contrats | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/negotiation-agent/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 Candidat Automatique](agents/automation/job-applicant/) | Candidatures massives, personnalisation de CV | Quand vous voulez postuler à plus de 500 emplois pendant votre sommeil | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/job-applicant/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [☀️ Briefing Matinal](agents/automation/morning-briefing/) | Récapitulatif email, calendrier, actualités quotidien | Quand vous voulez un briefing quotidien personnalisé prêt à 7h00 | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/morning-briefing/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ Scraper de Vols](agents/automation/flight-scraper/) | Offres de vols, alertes baisses de prix | Quand vous voulez que les vols les moins chers soient trouvés automatiquement | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/flight-scraper/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌙 Codeur de Nuit](agents/automation/overnight-coder/) | Codage autonome, PR prêtes le matin | Quand vous voulez que le code soit écrit pendant votre sommeil | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/overnight-coder/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💬 Business Discord](agents/automation/discord-business/) | Gestion complète des opérations via Discord | Quand vous gérez votre entreprise via Discord | [Voir](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/discord-business/SOUL.md) | [Déployer →](https://crewclaw.com/create-agent?role=personal-assistant) |

---

## Cas d’Utilisation

**132 cas d’utilisation réels vérifiés** — ce que les gens construisent réellement avec les agents OpenClaw.

Des workflows développeur et automatisation DevOps au contrôle domotique, trading crypto, robotique, et agents qui modifient leur propre code.

**[Parcourir les 132 cas d’utilisation →](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/USE-CASES.md)**

Principales catégories : Productivité Personnelle (14) · Opérations Commerciales (11) · Workflows Développeur (10) · Création de Contenu (10) · Outils Écosystémiques (10)

---

## Démarrage rapide

Mettez un agent opérationnel en moins de 5 minutes sans aucune configuration :

```bash
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
cp .env.example .env          # add your API key + Telegram token
cp ../agents/marketing/echo/SOUL.md ./SOUL.md
npm install && node bot.js    # your agent is live on Telegram
```

Voir le [Guide de démarrage rapide](quickstart/) complet avec le support Docker.

Ou passez entièrement la configuration : **[Déployer avec CrewClaw →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=quickstart)** — obtenez un package complet de déploiement (Dockerfile + docker-compose + bot + README) pour n'importe quel rôle.

---

## Pourquoi OpenClaw ?

Comment OpenClaw se compare aux autres frameworks d'agents IA :

### vs Frameworks d'agents IA

| Fonctionnalité | OpenClaw | AutoGPT | CrewAI | LangChain | MetaGPT |
|---------------|----------|---------|--------|-----------|---------|
| Config-first (SOUL.md) | ✅ | ❌ | ❌ | ❌ | ❌ |
| Pas de code requis | ✅ | ❌ | ❌ | ❌ | ❌ |
| Intégration Telegram/Slack/Discord | ✅ | ❌ | ❌ | ❌ | ❌ |
| Orchestration multi-agent | ✅ | ❌ | ✅ | ✅ | ✅ |
| MCP (Model Context Protocol) | ✅ | ❌ | ❌ | ❌ | ❌ |
| Auto-hébergé / local | ✅ | ✅ | ✅ | ✅ | ✅ |
| Surveillance heartbeat | ✅ | ❌ | ❌ | ❌ | ❌ |
| Compatible avec Ollama (gratuit) | ✅ | ✅ | ✅ | ✅ | ❌ |
| Modèles prêts pour production | **187** | 0 | 5 | 0 | 3 |
| Déploiement en une commande | ✅ | ❌ | ❌ | ❌ | ❌ |
| Communication agent-à-agent | ✅ | ❌ | ✅ | ✅ | ✅ |
| Temps de configuration | ~5 min | ~30 min | ~20 min | ~45 min | ~30 min |

### vs Alternatives légères

| Fonctionnalité | OpenClaw | ZeroClaw | PicoClaw | NanoClaw | memU |
|---------------|----------|----------|----------|----------|------|
| Langage | Node.js | Rust | Go | Python | Python |
| Taille binaire | ~150MB | ~5MB | ~8MB | ~4K LOC | ~50MB |
| RAM min | 512MB | 32MB | 64MB | 128MB | 256MB |
| Multi-agent | ✅ AGENTS.md | ❌ | ❌ | ❌ | ❌ |
| Compétences/plugins | ✅ 13K+ | ❌ | ❌ | ❌ | ❌ |
| Canaux de messagerie | ✅ 25+ | 3 | 2 | 1 | 5 |
| Mémoire à long terme | Basique | ❌ | ❌ | ❌ | ✅ Graphe de connaissances |
| Support MCP | ✅ | ❌ | ❌ | ❌ | ❌ |
| Modèles de production | **187** | 0 | 0 | 0 | 0 |
| Meilleur pour | Équipes d'agents complètes | Edge/IoT | Bots à usage unique | Configurations minimales | Assistants personnels |

### vs Solutions hébergées/entreprise

| Fonctionnalité | OpenClaw | Claude Code Channels | NemoClaw (NVIDIA) | OpenFang |
|---------------|----------|---------------------|-------------------|----------|
| Open source | ✅ MIT | ❌ Propriétaire | ✅ Apache 2.0 | ✅ MIT |
| Auto-hébergé | ✅ | ❌ Cloud uniquement | ✅ | ✅ |
| Configuration | Fichier config | Clé API | Docker + config | Binaire Rust |
| Multi-agent | ✅ | ❌ | ✅ via OpenClaw | ✅ 7 "Mains" |
| Modèle de sécurité | Géré par l’utilisateur | Géré par Anthropic | Bac à sable noyau | Isolation de processus |
| Messagerie | ✅ 25+ canaux | Telegram, Discord | Via OpenClaw | 3 canaux |
| Coût | Gratuit + frais API | Abonnement Claude | Gratuit + frais API | Gratuit + frais API |
| Meilleur pour | Contrôle total | Utilisateurs non techniques | Sécurité entreprise | Utilisateurs avancés d’Agent OS |

**Résumé :** OpenClaw privilégie la configuration. Écrivez un SOUL.md, lancez une commande, votre agent est en ligne. Pas de Python, pas de chaînes, pas de graphes. Les alternatives légères échangent des fonctionnalités contre une empreinte plus petite. Les solutions entreprise ajoutent des couches de sécurité.

---

## Déploiement rapide avec CrewClaw

Choisissez un modèle, personnalisez-le et obtenez un package de déploiement complet avec [CrewClaw](https://crewclaw.com/create-agent) :

```
Your CrewClaw package includes:
├── agents/your-agent/SOUL.md    # Agent configuration
├── Dockerfile                    # Container setup
├── docker-compose.yml            # One-command deploy
├── bot.js                        # Telegram bot (grammy)
├── .env.example                  # API keys template
├── package.json                  # Dependencies
└── README.md                     # Setup instructions
```

Choisissez l’un des 187 modèles ci-dessus, ou créez un agent personnalisé à partir de zéro.

**[Créez votre agent →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta)**

---

## Serveurs MCP

Modélisez des serveurs Context Protocol pour étendre les capacités des agents.

### Officiels

| Serveur | Description | Installation |
|---------|-------------|--------------|
| [@anthropic/mcp-server-fetch](https://github.com/anthropics/mcp-server-fetch) | Récupération web et navigation | `npx -y @anthropic/mcp-server-fetch` |
| [@anthropic/mcp-server-filesystem](https://github.com/anthropics/mcp-server-filesystem) | Accès au système de fichiers | `npx -y @anthropic/mcp-server-filesystem` |

### Communauté

| Serveur | Description |
|---------|-------------|
| mcp-notion | Intégration Notion |
| mcp-google-calendar | Accès Google Calendar |
| mcp-github | Opérations GitHub |
| mcp-slack | Messagerie Slack |
| mcp-postgres | Requêtes PostgreSQL |
| mcp-stripe | Paiements Stripe |
| mcp-shopify | Gestion de boutique Shopify |
| mcp-twitter | Publication Twitter/X |
| mcp-discord | Intégration bot Discord |
| mcp-linear | Suivi de tickets Linear |

---

## Intégrations

Connectez vos agents à des services externes.

### Messagerie

- **Telegram** - Discussion avec les agents via Telegram (intégré à OpenClaw)
- **Slack** - Connexion à l’espace de travail Slack (intégré à OpenClaw)
- **Discord** - Bot serveur Discord (intégré à OpenClaw)
- **Email** - Canal email (intégré à OpenClaw)

### Automatisation

- **n8n** - Nœuds d’intégration n8n
- **GitHub Actions** - Intégration CI/CD
- **Cron / pm2 / systemd** - Planification d’agents toujours actifs

---

## Outils

Utilitaires et assistants pour travailler avec OpenClaw.

| Outil | Description |
|-------|-------------|
| [openclaw CLI](https://crewclaw.com/blog/openclaw-cli-commands-reference) | CLI officiel - référence complète des commandes |
| [agents.json](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json) | Index lisible par machine de tous les 187 modèles d’agents |
| agent-validator | Validation de la syntaxe SOUL.md |
| mcp-tester | Test des connexions aux serveurs MCP |

---

## Sécurité

Les agents OpenClaw s’exécutent sur votre matériel avec accès à vos fichiers et services. Suivez ces bonnes pratiques :

| Risque | Atténuation |
|--------|-------------|
| Passerelle exposée | Lier uniquement à `localhost`. Utiliser le tunnel SSH pour l’accès à distance. Ne jamais exposer le port 18789 sur Internet. |
| Fuites de clés API | Stocker les clés dans des fichiers `.env`. Ajouter `.env` à `.gitignore`. Faire tourner les clés régulièrement. |
| Compétences malveillantes | Installer uniquement les compétences des éditeurs vérifiés ClawHub. Vérifier SKILL.md avant l’installation. |
| Injection de prompt | Définir des `## Règles` strictes dans SOUL.md. Limiter l’accès au système de fichiers. Désactiver les commandes shell pour les entrées non fiables. |
| Agents sans surveillance | Utiliser HEARTBEAT.md avec des limites de périmètre. Définir des plafonds budgétaires. Activer la journalisation pour toutes les actions. |

**Ressources récentes sur la sécurité :**

- [Guide de Sécurité OpenClaw](https://crewclaw.com/blog/openclaw-security-guide) - Renforcement de votre configuration
- [Risques de Sécurité OpenClaw 2026](https://crewclaw.com/blog/openclaw-security-risks-2026) - Vulnérabilités connues et correctifs
- [NemoClaw (NVIDIA GTC 2026)](https://crewclaw.com/blog/nvidia-gtc-2026-openclaw-nemoclaw) - Enveloppe de sécurité pour entreprise
- [Docs Officielles de Sécurité](https://docs.openclaw.ai/gateway/security) - Configuration de la sécurité du gateway

---

## Tutoriels & Guides

Apprenez à créer et déployer des agents.

### Premiers Pas

- [Comment Utiliser OpenClaw : Guide Débutant](https://crewclaw.com/blog/how-to-use-openclaw-guide) - Installation au premier agent en 5 minutes
- [Qu'est-ce qu'OpenClaw ?](https://crewclaw.com/blog/what-is-openclaw-ai-agent-framework) - Guide complet du framework
- [Créez Votre Premier Agent](https://crewclaw.com/blog/how-to-create-ai-agent-openclaw) - Sans code requis
- [Guide d'Installation OpenClaw 2026](https://crewclaw.com/blog/openclaw-setup-guide-2026) - Installer, configurer, lancer
- [Exigences Système](https://crewclaw.com/blog/openclaw-system-requirements-2026) - Matériel, GPU, VPS, spécifications Docker
- [Meilleurs Modèles pour OpenClaw](https://crewclaw.com/blog/best-models-for-openclaw-2026) - 10 LLM comparés sur coût, vitesse, appels d'outils
- [Modèles SOUL.md](https://crewclaw.com/blog/soul-md-examples-templates) - 10 exemples prêts à l'emploi

### Multi-Agent & Orchestration

- [Guide de Configuration Multi-Agent](https://crewclaw.com/blog/openclaw-multi-agent-setup-guide) - Faire fonctionner plusieurs agents ensemble
- [Communication Agent-à-Agent](https://crewclaw.com/blog/openclaw-agent-to-agent-communication) - Comment les agents collaborent
- [Construire une Équipe d'IA](https://crewclaw.com/blog/build-ai-team-workflows) - Flux de travail autonomes

### Cas d'Utilisation

- [Que Peut Faire OpenClaw ?](https://crewclaw.com/blog/what-can-openclaw-do) - 12 cas d’usage réels avec configurations
- [OpenClaw pour les Entreprises](https://crewclaw.com/blog/openclaw-for-business-use-cases) - 25 cas d’usage dans 8 catégories
- [Guide de Création de Contenu](https://crewclaw.com/blog/openclaw-content-creation-guide) - Blog, réseaux sociaux, automatisation vidéo
- [Guide de Génération de Leads](https://crewclaw.com/blog/openclaw-lead-generation-guide) - Reddit, Twitter, pipeline de ventes
- [Automatisation des Emails](https://crewclaw.com/blog/openclaw-email-automation-guide) - Tri de boîte, réponse automatique, relances
- [Intégration Home Assistant](https://crewclaw.com/blog/openclaw-home-assistant-integration) - Contrôle domotique intelligent

### Intégrations & Automatisation

- [Intégration Slack & Telegram](https://crewclaw.com/blog/openclaw-slack-telegram-integration) - Connexion aux canaux de messagerie
- [Exécuter avec Ollama](https://crewclaw.com/blog/openclaw-ollama-local-agents) - Agents IA locaux gratuits  
- [Guide d'automatisation](https://crewclaw.com/blog/openclaw-automation-guide) - Créez des workflows 24/7  
- [Référence des commandes CLI](https://crewclaw.com/blog/openclaw-cli-commands-reference) - Fiche complète  
- [Intégration Google Workspace](https://crewclaw.com/blog/openclaw-google-workspace-integration) - Gmail, Docs, Drive, Calendrier  

### Comparaisons  

- [OpenClaw vs CrewAI](https://crewclaw.com/blog/openclaw-vs-crewai) - Lequel est meilleur ?  
- [OpenClaw vs AutoGen](https://crewclaw.com/blog/openclaw-vs-autogen) - Le cadre multi-agent de Microsoft  
- [OpenClaw vs LangChain](https://crewclaw.com/blog/openclaw-vs-langchain) - Comparaison des frameworks  
- [OpenClaw vs AutoGPT](https://crewclaw.com/blog/openclaw-vs-autogpt) - Différences clés  
- [OpenClaw vs ZeroClaw](https://crewclaw.com/blog/openclaw-vs-zeroclaw) - Alternative légère en Rust  
- [OpenClaw vs OpenFang](https://crewclaw.com/blog/openclaw-vs-openfang) - OS agent avec 7 mains  
- [OpenClaw vs memU](https://crewclaw.com/blog/openclaw-vs-memu) - IA à mémoire long terme  
- [PicoClaw vs OpenClaw](https://crewclaw.com/blog/picoclaw-vs-openclaw) - Alternative ultra-minimale  
- [Guide du dépôt GitHub OpenClaw](https://crewclaw.com/blog/openclaw-ai-agent-github-guide) - Le dépôt à 250K étoiles expliqué  

---  

## Soumettez votre agent  

Vous avez créé un agent personnalisé ? Faites-le référencer ici et sur [crewclaw.com/agents](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=submit).  

Chaque agent est un système d'exploitation complet, pas seulement un prompt :

```
agents/[category]/[your-agent]/
├── SOUL.md          ← Identity & personality (required)
├── README.md        ← Description & use cases (required)
├── AGENTS.md        ← Operating rules (optional)
├── HEARTBEAT.md     ← Wake-up checklist (optional)
└── WORKING.md       ← Starting task (optional)
```

**Via PR (recommandé) :**

1. Forkez ce dépôt  
2. Ajoutez votre dossier agent avec SOUL.md + README.md (minimum)  
3. Ajoutez une entrée dans `agents.json`  
4. Ouvrez une Pull Request  

**Via Issue (sans configuration) :**

[Soumettez votre agent →](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md) — collez vos fichiers, nous l’ajouterons.

Guide complet : [CONTRIBUTING.md](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/CONTRIBUTING.md)

---

## Communauté

Vous souhaitez plutôt demander un agent ? Utilisez le modèle [Agent Request](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-request.md).

---

## Projets liés

- [🦞 CrewClaw](https://crewclaw.com) - Déployez des agents IA sans configuration. Pas de Docker, pas de terminal.  
- [OpenClaw](https://github.com/openclaw) - Dépôt officiel OpenClaw  
- [Anthropic MCP](https://github.com/anthropics/mcp) - Protocole de contexte modèle  

---

## Historique des étoiles

[![Graphique de l’historique des étoiles](https://api.star-history.com/svg?repos=mergisi/awesome-openclaw-agents&type=Date)](https://star-history.com/#mergisi/awesome-openclaw-agents&Date)

---

## Licence

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

Dans la mesure permise par la loi, les contributeurs ont renoncé à tous les droits d'auteur et droits connexes sur cette œuvre.

---

<p align="center">
  Fait avec 🦞 par la communauté OpenClaw
  <br/>
  <a href="https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta">Déployez votre agent avec CrewClaw →</a> · <a href="https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md">Soumettez le vôtre →</a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---