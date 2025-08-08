
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Commandes Slash Claude Code

Commandes slash prêtes pour la production pour [Claude Code](https://docs.anthropic.com/en/docs/claude-code) qui accélèrent le développement grâce à l'automatisation intelligente.

**52 commandes** organisées comme suit :
- **🤖 Workflows** : Orchestration multi-sous-agents pour des tâches complexes
- **🔧 Outils** : Utilitaires à usage unique pour des opérations spécifiques

### 🤝 Nécessite les sous-agents Claude Code

Ces commandes fonctionnent avec les [Sous-agents Claude Code](https://github.com/wshobson/agents) pour des capacités d'orchestration.

## Installation

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Commandes Disponibles

- **🤖 Workflows** - Orchestrer plusieurs sous-agents pour des tâches complexes
- **🔧 Outils** - Commandes à usage unique pour des opérations spécifiques

## Utilisation

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```

Claude Code suggère automatiquement des commandes pertinentes en fonction du contexte.

## 🤖 Flux de travail

Orchestration multi-sous-agents pour des tâches complexes :

### Développement de fonctionnalités
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Sous-agents backend, frontend, tests et déploiement construisent des fonctionnalités complètes
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Plusieurs sous-agents de revue fournissent une analyse complète du code
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analyse les problèmes et délègue aux sous-agents spécialistes appropriés

### Processus de développement
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Met en œuvre des workflows Git efficaces avec stratégies de branches et templates de PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Améliore les performances des sous-agents par optimisation des prompts
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Modernise les bases de code legacy avec des sous-agents spécialisés
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Crée des pipelines ML avec sous-agents data et ingénierie ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Construit des applications multiplateformes avec sous-agents coordonnés
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatise les workflows CI/CD, monitoring et déploiement

### Workflows orchestrés par sous-agents
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Fonctionnalités multiplateformes avec sous-agents backend, frontend et mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Mise en œuvre axée sur la sécurité avec sous-agents spécialisés
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Fonctionnalités pilotées par ML avec sous-agents data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optimisation de bout en bout avec sous-agents performance
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Résolution d’incidents en production avec sous-agents ops

## 🔧 Outils (Commandes à usage unique)

### IA & apprentissage automatique
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Construire des assistants IA et chatbots prêts pour la production
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Revue spécialisée pour bases de code IA/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Créer des agents LangChain/LangGraph avec des modèles modernes
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Créer des pipelines ML de bout en bout avec MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimiser les prompts IA pour performance et qualité

### Architecture & qualité du code
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Générer des explications détaillées de code complexe
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migrer le code entre langages, frameworks ou versions
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refactorer le code pour maintenabilité et performance
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analyser et prioriser la dette technique

### Données & base de données
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Concevoir des architectures de pipeline de données évolutives
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Mettre en œuvre des systèmes complets de validation des données
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Stratégies avancées de migration de bases de données

### DevOps & infrastructure
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Générer des configurations et checklists de déploiement
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Stratégies avancées d’optimisation de conteneurs
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Déploiements Kubernetes de qualité production
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Configurer un monitoring et une observabilité complets
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implémenter des objectifs de niveau de service (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatiser les workflows de développement et opérationnels

### Développement & tests
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Créer des mocks d’API réalistes pour développement et tests
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Générer des endpoints API prêts pour la production avec pile complète d’implémentation
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Créer des suites de tests complètes avec détection de framework

### Sécurité & conformité
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Tests et corrections complets d’accessibilité
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Assurer la conformité réglementaire (RGPD, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Analyse de sécurité complète avec remédiation automatisée

### Débogage & analyse
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Stratégies avancées de débogage et traçage
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Analyse approfondie des patterns d’erreurs et stratégies de résolution
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Tracer et diagnostiquer les erreurs en production
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Créer des issues bien structurées GitHub/GitLab

### Dépendances & configuration
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Valider et gérer la configuration applicative
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Auditer les dépendances pour sécurité et licences
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Mettre à jour en toute sécurité les dépendances du projet

### Documentation & collaboration
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Générer une documentation complète
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Mettre en œuvre des workflows Git efficaces
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Améliorer les pull requests avec contrôles qualité

### Optimisation des coûts
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimiser les coûts cloud et infrastructure

### Intégration & configuration initiale
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Configurer les environnements de développement pour les nouveaux membres

### Outils pour sous-agents
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Revue de code multi-perspectives avec sous-agents spécialisés
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Débogage approfondi avec sous-agents débogueur et performance
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optimisation full-stack avec plusieurs sous-agents
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Sauvegarder le contexte projet avec sous-agent gestionnaire de contexte
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Restaurer un contexte sauvegardé pour continuité

## Fonctionnalités

- Implémentations prêtes pour la production
- Auto-détection de frameworks
- Meilleures pratiques de sécurité
- Monitoring et tests intégrés
- Les commandes fonctionnent parfaitement ensemble

## Nombre de commandes

**Total : 52 commandes slash prêtes pour la production** organisées en :

### 🤖 Workflows (14 commandes)

- Développement et Revue de Fonctionnalités (3 commandes) 
- Automatisation du Processus de Développement (6 commandes)
- Workflows Orchestrés par Sous-agent (5 commandes)

### 🔧 Outils (38 commandes)

- IA et Apprentissage Automatique (5 commandes)
- Architecture et Qualité du Code (4 commandes)
- Données et Base de Données (3 commandes)
- DevOps et Infrastructure (6 commandes)
- Développement et Tests (3 commandes)
- Sécurité et Conformité (3 commandes)
- Débogage et Analyse (4 commandes)
- Dépendances et Configuration (3 commandes)
- Documentation et Collaboration (1 commande)
- Intégration et Configuration (1 commande)
- Outils Spécifiques aux Sous-agents (5 commandes)

## Exemples d’utilisation

### 🤖 Exemples de Workflows

```bash
# Implement a complete feature
/feature-development Add user authentication with OAuth2

# Comprehensive code review
/full-review Review the authentication module

# Smart issue resolution
/smart-fix Fix performance degradation in API response times

# Modernize legacy system
/legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/incident-response High CPU usage causing service degradation in production
```

### 🔧 Exemples d'outils (commandes à usage unique)

```bash
# Create a user management API
/api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/error-trace analyze high memory usage in production pods

# Secure container images
/security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/multi-agent-review Review authentication module

# Deep debugging
/smart-debug Investigate memory leak in production workers

# Full-stack optimization
/multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/context-save Save current project state and architectural decisions

# Restore project context
/context-restore Load context from last week's sprint
```

## Commandes améliorées

### Sécurité & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Analyse de sécurité complète avec correction automatisée.

- **Analyse Multi-Outils** : Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Corrections Automatisées** : Vulnérabilités communes corrigées automatiquement
- **Intégration CI/CD** : Portes de sécurité pour GitHub Actions/GitLab CI
- **Analyse de Conteneurs** : Analyse des vulnérabilités d’images
- **Détection de Secrets** : Intégration GitLeaks et TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Stratégies avancées d’optimisation des conteneurs.

- **Optimisation Intelligente** : Analyse et suggestions d’améliorations
- **Builds Multi-Étapes** : Dockerfiles optimisés spécifiques aux frameworks
- **Outils Modernes** : BuildKit, Bun, UV pour des builds plus rapides
- **Renforcement de la Sécurité** : Images distroless, utilisateurs non-root
- **Intégration Inter-Commandes** : Fonctionne avec les sorties de /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Déploiements Kubernetes de qualité production.

- **Patrons Avancés** : Normes de sécurité des pods, politiques réseau, OPA
- **Prêt GitOps** : Configurations FluxCD et ArgoCD
- **Observabilité** : Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling** : Configurations HPA, VPA, et autoscaler de cluster
- **Service Mesh** : Intégration Istio/Linkerd

### Frontend & Données

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Stratégies avancées de migration de bases de données.

- **Multi-Base** : PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zéro Temps d’Arrêt** : Déploiements blue-green, migrations progressives
- **Event Sourcing** : Intégration Kafka/Kinesis pour CDC
- **Multi-Plateforme** : Gère la persistance polyglotte
- **Surveillance** : Contrôles de santé des migrations et rollback

## Combinaison des Workflows et Outils

La vraie puissance vient de la combinaison des workflows et outils pour des cycles de développement complets :

### Exemple : Création d’une Nouvelle Fonctionnalité

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/test-harness Add integration tests for WebSocket connections
/security-scan Check for WebSocket vulnerabilities
/docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/full-review Review the entire chat feature implementation
```

### Exemple : Modernisation du code hérité

```bash
# 1. Start with the modernization workflow
/legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/deps-upgrade Update all dependencies to latest versions
/refactor-clean Remove deprecated patterns and dead code
/test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/docker-optimize Create multi-stage production build
/k8s-manifest Deploy with zero-downtime strategy
```

## Modèles d'orchestration des commandes

Les commandes peuvent être utilisées individuellement ou combinées en modèles puissants :

### Exécution séquentielle
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Analyse parallèle
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Raffinement itératif
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Intégration inter-domaines
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## Quand utiliser les Workflows vs les Outils

### 🔀 Workflows & Outils de Sous-agents
- **Résolution de problèmes** : Analyser et corriger les problèmes de manière adaptative
- **Multiples perspectives** : Coordonner des sous-agents spécialistes
- **Tâches complexes** : Processus multi-étapes à travers les domaines
- **Solutions inconnues** : Laisser les sous-agents déterminer l’approche

### 🛠️ Outils Spécialisés
- **Configuration d’infrastructure** : Configurer les environnements
- **Génération de code** : Créer des implémentations spécifiques
- **Analyse** : Générer des rapports sans corrections
- **Tâches de domaine** : Opérations hautement spécialisées

**Exemples :**
- "Implémenter un système d’authentification utilisateur" → `/feature-development`
- "Corriger les problèmes de performance sur toute la stack" → `/smart-fix`
- "Moderniser un monolithe legacy" → `/legacy-modernize`

### 🔧 Utiliser les Outils Quand :
- **Expertise spécifique nécessaire** - Tâche claire et ciblée dans un seul domaine
- **Contrôle précis souhaité** - Vouloir diriger des détails d’implémentation spécifiques
- **Partie d’un workflow manuel** - Intégration dans des processus existants
- **Spécialisation poussée requise** - Besoin d’une implémentation experte
- **S’appuyer sur un travail existant** - Améliorer ou affiner des résultats antérieurs

**Exemples :**
- "Créer des manifests Kubernetes" → `/k8s-manifest`
- "Scanner les vulnérabilités de sécurité" → `/security-scan`
- "Générer la documentation API" → `/doc-generate`

## Format des Commandes

Les commandes Slash sont des fichiers markdown simples où :
- Le nom de fichier devient le nom de la commande (ex. `api-scaffold.md` → `/api-scaffold`)
- Le contenu du fichier est l’invite/instructions exécutées lors de l’invocation
- Utiliser le placeholder `$ARGUMENTS` pour les entrées utilisateur

## Bonnes Pratiques

### Sélection des Commandes
- **Laisser Claude Code suggérer automatiquement** - Analyse le contexte et sélectionne les commandes optimales
- **Utiliser les workflows pour les tâches complexes** - Les sous-agents coordonnent des implémentations multi-domaines
- **Utiliser les outils pour les tâches ciblées** - Appliquer des commandes spécifiques pour des améliorations ciblées

### Utilisation Efficace
- **Fournir un contexte complet** - Inclure la stack tech, contraintes et exigences
- **Chaîner les commandes stratégiquement** - Workflows → Outils → Affinements
- **S’appuyer sur les sorties précédentes** - Les commandes sont conçues pour fonctionner ensemble

## Contribution

1. Créer un fichier `.md` dans `workflows/` ou `tools/`
2. Utiliser des noms en minuscules avec des tirets
3. Inclure `$ARGUMENTS` pour les entrées utilisateur

## Dépannage

**Commande introuvable** : Vérifier que les fichiers sont dans `~/.claude/commands/`

**Workflows lents** : Normal - ils coordonnent plusieurs sous-agents

**Sortie générique** : Ajouter plus de contexte spécifique sur votre stack tech

**Problèmes d’intégration** : Vérifier les chemins de fichiers et la séquence des commandes

## Conseils de Performance

**Sélection des Commandes :**
- **Workflows** : Coordination multi-sous-agents pour des fonctionnalités complexes
- **Outils** : Opérations à usage unique pour des tâches spécifiques
- **Modifications simples** : Rester avec l’agent principal

**Optimisation :**
- Commencer par les outils pour les problèmes connus
- Fournir des exigences détaillées dès le départ
- S’appuyer sur les sorties des commandes précédentes
- Laisser les workflows se terminer avant les modifications

### Ajouter un Nouveau Workflow :
- Se concentrer sur l’orchestration et la délégation des sous-agents
- Spécifier quels sous-agents spécialisés utiliser et dans quel ordre
- Définir les schémas de coordination entre sous-agents

### Ajouter un Nouvel Outil :
- Inclure des implémentations complètes et prêtes pour la production
- Structurer le contenu avec des sections claires et des sorties exploitables
- Inclure des exemples, bonnes pratiques et points d’intégration

## En Savoir Plus

- [Documentation Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Documentation des Commandes Slash](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Documentation des Sous-agents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Collection de Sous-agents Claude Code](https://github.com/wshobson/agents) - Sous-agents spécialisés utilisés par ces commandes


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---