# Collection complète d'agents Claude Code

**Langue** : [Anglais](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README.md) | [日本語](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README_JA.md)

Une collection complète d’agents spécialisés pour Claude Code permettant l’automatisation complète du développement logiciel, de l’analyse des besoins à la mise en production et à la maintenance continue.

## 🎯 Vue d’ensemble

Ce dépôt contient un ensemble complet d’agents Claude Code conçus pour gérer l’intégralité des cycles de vie du développement logiciel avec une intervention humaine minimale. Les agents sont organisés en six catégories couvrant tous les aspects du développement logiciel moderne.

## 📦 Catégories d’agents

### 1. Exigences & Analyse
**Objectif** : Transformer les besoins métier en spécifications techniques détaillées

- **requirements-analyst** - Analyse les besoins utilisateurs et crée des spécifications fonctionnelles détaillées
- **user-story-generator** - Crée des user stories complètes et des critères d’acceptation  
- **business-process-analyst** - Analyse les processus métier et les traduit en exigences techniques
- **requirements-validator** - Valide les exigences pour leur exhaustivité et cohérence

### 2. Conception & Architecture
**Objectif** : Créer des conceptions système robustes et évolutives

- **system-architect** - Conçoit des architectures système complètes et des piles technologiques
- **data-architect** - Conçoit des modèles de données, schémas et stratégies d’intégration
- **interface-designer** - Conçoit les interfaces utilisateur et les spécifications d’API
- **security-architect** - Conçoit des cadres de sécurité et des stratégies de protection des données
- **design-reviewer** - Revoit et valide les conceptions système pour garantir la qualité

### 3. Implémentation & Développement
**Objectif** : Gérer tous les aspects du développement de code et de l’assurance qualité

- **code-reviewer** - Effectue des évaluations complètes de la qualité du code
- **test-suite-generator** - Génère une couverture de test complète
- **code-refactoring-specialist** - Améliore la structure du code et réduit la dette technique en toute sécurité
- **security-analyzer** - Identifie les vulnérabilités et problèmes de sécurité
- **performance-optimizer** - Analyse et optimise les performances du code
- **api-designer** - Conçoit des API RESTful propres avec des spécifications appropriées
- **documentation-generator** - Crée la documentation technique et les commentaires de code
- **dependency-manager** - Gère les dépendances des paquets et résout les conflits
- **database-schema-designer** - Conçoit des schémas de base de données efficaces et des migrations
- **git-manager** - Gère les opérations Git, l’organisation des commits et la maintenance du dépôt
- **cicd-builder** - Crée et configure les pipelines CI/CD

### 4. Gestion de projet
**Objectif** : Coordonner et gérer l’ensemble du processus de développement

- **project-planner** - Crée des plans de projet complets et des calendriers
- **risk-manager** - Identifie les risques projet et crée des stratégies d’atténuation
- **progress-tracker** - Suit la progression du projet et identifie les blocages
- **qa-coordinator** - Établit les standards de qualité et coordonne les tests
- **stakeholder-communicator** - Gère la communication et les rapports aux parties prenantes

### 5. Déploiement & Exploitation
**Objectif** : Gérer la mise en production et les opérations continues

- **project-orchestrator** - Coordinateur principal pour l’exécution complète du projet
- **deployment-ops-manager** - Gère la mise en production et la surveillance opérationnelle
- **uat-coordinator** - Coordonne les tests d’acceptation utilisateurs avec les parties prenantes métier
- **training-change-manager** - Crée des supports de formation et gère l’adoption du système
- **project-template-manager** - Gère les modèles de projet et la configuration rapide pour les schémas courants

### 6. Méta-Gestion
**Objectif** : Optimiser Claude Code lui-même pour une efficacité maximale

- **context-manager** - Surveille le contexte des sessions et gère l’information pour la continuité
- **session-continuity-manager** - Assure des transitions fluides entre les sessions Claude Code
- **memory-manager** - Optimise l’usage mémoire de Claude Code et la documentation projet
- **workflow-optimizer** - Analyse et optimise les workflows de développement et l’utilisation des agents
- **resource-monitor** - Surveille l’usage des ressources et propose des stratégies d’optimisation
- **agent-creator** - Crée dynamiquement de nouveaux agents spécialisés selon les besoins du projet

## 🚀 Fonctionnalités clés

### Automatisation complète
- **Développement de bout en bout** : Des exigences à la mise en production
- **Orchestration intelligente** : Les agents coordonnent et enchaînent automatiquement les tâches
- **Spécialisation dynamique** : Création de nouveaux agents pour des besoins uniques
- **Continuité de session** : Maintien du contexte sur de longues sessions de développement

### Qualité professionnelle
- **Meilleures pratiques industrielles** : Chaque agent suit des méthodologies établies
- **Tests complets** : Génération automatique de tests et assurance qualité
- **Sécurité prioritaire** : Analyse de sécurité intégrée et contrôle de conformité
- **Prêt pour la production** : Support complet pour le déploiement et l’exploitation

### Architecture évolutive
- **Conception modulaire** : Utilisation d’agents individuels ou de workflows complets
- **Préservation du contexte** : Gestion efficace de la mémoire pour les projets longs
- **Optimisation des ressources** : Surveillance et optimisation de l’utilisation de Claude Code
- **Basé sur des modèles** : Mise en place rapide de projets avec des schémas éprouvés

## 💡 Cas d’utilisation

### Automatisation complète de projet
```
User: "Create a library management system for our company"
Result: Fully functional web application with database, API, frontend, tests, documentation, and deployment
```

### Tâches de développement spécialisées
```
User: "Review this authentication code for security issues"
Agent: security-analyzer performs comprehensive security audit
```
### Gestion de projet à long terme

```
User: "Manage the development of a multi-tenant SaaS platform"
Agent: project-orchestrator coordinates all phases with appropriate specialists
```

## 📋 Installation

1. **Clonez ou copiez les définitions des agents** dans le répertoire `.claude/agents/` de votre projet :
   ```bash
   mkdir -p .claude/agents
   # Copy the agent definition files to this directory
   ```

2. **Vérifier l'installation** :
   ```bash
   ls .claude/agents/
   # Should show all agent files (.md format)
   ```

3. **Commencez à utiliser des agents** dans Claude Code :
   ```
   Use the project-orchestrator agent to build a complete web application
   ```

## 🎮 Exemples d'utilisation

### Démarrage d'une nouvelle application Web
```
"I want to build a task management web application with user authentication, real-time updates, and mobile responsiveness. Handle everything from requirements to deployment."
```

Le **project-orchestrator** va :
1. Utiliser **requirements-analyst** pour recueillir les exigences détaillées
2. Coordonner **system-architect** et **data-architect** pour la conception
3. Gérer la mise en œuvre avec les agents de développement
4. Gérer les tests, le déploiement et la documentation
5. Fournir des supports de formation pour les utilisateurs finaux

### Revue de la qualité du code
```
"Review my e-commerce checkout process for security vulnerabilities, performance issues, and code quality."
```

Plusieurs agents coordonnent :
- **security-analyzer** vérifie les vulnérabilités
- **performance-optimizer** identifie les goulets d'étranglement  
- **code-reviewer** garantit les meilleures pratiques

### Gestion de projet à long terme
```
"Manage the development of our new customer portal over the next 6 months with regular stakeholder updates."
```
Le système fournit :  
- Planification de projet automatisée et gestion des risques  
- Suivi régulier de l'avancement et rapports  
- Portes de qualité et coordination des tests  
- Gestion de la communication avec les parties prenantes  

## 🔧 Modèles de flux de travail des agents  

### Modèle séquentiel  
Exigences → Conception → Implémentation → Tests → Déploiement  

### Modèle parallèle  
Plusieurs agents de développement travaillant simultanément sur différents composants  

### Modèle adaptatif  
**agent-créateur** génère des agents spécialisés pour des exigences uniques  

### Modèle continu  
Des agents de méta-gestion assurent l'optimisation et la surveillance continues  

## 📝 Format de définition des agents  

Chaque agent suit le format standard de Claude Code :

```markdown
---
name: agent-name
description: Detailed description with examples and usage patterns
---

Comprehensive system prompt defining the agent's expertise, responsibilities, and methodologies.
```

## 🔄 Interactions des agents

### Coordinateur principal
- **project-orchestrator** gère le flux global du projet
- Sélectionne et ordonne automatiquement les agents appropriés
- Gère la communication entre agents et la gestion des dépendances

### Équipes spécialisées
- **Équipe des exigences** : Recueillir et valider les besoins du projet
- **Équipe de conception** : Créer l’architecture technique et les spécifications  
- **Équipe de développement** : Implémenter, tester et optimiser le code
- **Équipe des opérations** : Déployer et maintenir les systèmes en production
- **Équipe méta** : Optimiser l’utilisation et la continuité de Claude Code

## 📚 Documentation

Chaque agent comprend :
- **Description détaillée** avec des exemples d’utilisation
- **Cas d’usage spécifiques** et conditions de déclenchement
- **Résultats attendus** et livrables
- **Modèles d’intégration** avec d’autres agents

## 🎯 Exemple d’automatisation complète

### Entrée
```
"Create a library management system for our company"
```

### Processus automatisé
1. **Analyse des besoins** : Besoins des parties prenantes → Spécifications techniques
2. **Conception du système** : Architecture → Conception de la base de données → Conception de l’API → Conception de l’interface utilisateur
3. **Implémentation** : Backend → Frontend → Tests → Documentation
4. **Assurance qualité** : Revue de code → Analyse de sécurité → Optimisation des performances
5. **Déploiement** : Configuration en production → Pipeline CI/CD → Surveillance
6. **Transfert** : Formation des utilisateurs → Documentation → Procédures de support

### Résultat
- Application web entièrement fonctionnelle
- Suite de tests complète avec une couverture élevée
- Déploiement en production avec surveillance
- Documentation utilisateur et supports de formation
- Procédures de maintenance continues

## 🤝 Contribution

Nous accueillons les contributions ! Veuillez :

1. Suivre le format établi pour la définition des agents
2. Inclure des exemples complets et une documentation détaillée
3. Tester rigoureusement avec des projets réels
4. Veiller à ce que les agents s’intègrent bien dans les flux de travail existants
5. Soumettre une documentation claire des capacités des agents

## 📄 Licence

Licence MIT - vous êtes libre d’utiliser, modifier et distribuer ces agents à toute fin.

## 🙏 Remerciements

Conçu pour fonctionner parfaitement avec [Claude Code](https://claude.ai/code) et respecte tous les modèles et bonnes pratiques établis pour le développement de sous-agents.

## 📞 Support

Pour les problèmes, questions ou suggestions :
- Ouvrez un ticket dans ce dépôt
- Consultez la documentation de Claude Code sur https://docs.anthropic.com/en/docs/claude-code
- Examinez les exemples d’agents et les modèles d’utilisation

---

*Transformez votre processus de développement avec une automatisation intelligente. D’une exigence unique à un système en production – laissez les agents gérer la complexité pendant que vous vous concentrez sur la vision.*

## 🚀 Démarrage rapide

1. **Copiez les agents** dans le répertoire `.claude/agents/` de votre projet
2. **Lancez Claude Code** dans votre projet
3. **Dites** : « Utilisez le project-orchestrator pour construire [la description de votre projet] »
4. **Observez** le système gérer tout, des besoins au déploiement

**C’est tout !** Les agents se coordonneront automatiquement pour livrer une solution complète et prête pour la production.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-31

---