
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

Des commandes slash prêtes pour la production pour [Claude Code](https://docs.anthropic.com/en/docs/claude-code) qui accélèrent le développement grâce à l'automatisation intelligente.

**52 commandes** organisées comme suit :
- **🤖 Workflows** : Orchestration multi-sous-agent pour les tâches complexes
- **🔧 Outils** : Utilitaires à usage unique pour des opérations spécifiques

### 🤝 Nécessite les sous-agents Claude Code

Ces commandes fonctionnent avec les [sous-agents Claude Code](https://github.com/wshobson/agents) pour des capacités d'orchestration.

## Installation

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Commandes disponibles

- **🤖 Workflows** - Orchestrer plusieurs sous-agents pour des tâches complexes
- **🔧 Outils** - Commandes à usage unique pour des opérations spécifiques

## Utilisation

Les commandes sont organisées dans les répertoires `tools/` et `workflows/`. Utilisez-les avec le préfixe du répertoire :

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Remarque :** Si vous préférez utiliser des commandes sans préfixes, vous pouvez aplatir les répertoires :
```bash
cp tools/*.md .
cp workflows/*.md .
```

Claude Code suggère automatiquement des commandes pertinentes en fonction du contexte.

## 🤖 Flux de travail

Orchestration multi-sous-agents pour les tâches complexes :

### Développement de fonctionnalités
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Les sous-agents backend, frontend, test et déploiement créent des fonctionnalités complètes
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Plusieurs sous-agents de revue fournissent une analyse complète du code
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analyse les problèmes et délègue aux sous-agents spécialistes appropriés

### Processus de développement
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Met en œuvre des workflows Git efficaces avec des stratégies de branches et des modèles de PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Améliore la performance des sous-agents via l’optimisation des prompts
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Modernise les bases de code héritées avec des sous-agents spécialisés
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Crée des pipelines ML avec des sous-agents data et ingénierie ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Développe des applications multiplateformes avec des sous-agents coordonnés
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatise les workflows CI/CD, de surveillance et de déploiement

### Flux de travail orchestrés par sous-agents
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Fonctionnalités multiplateformes avec sous-agents backend, frontend et mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implémentation axée sur la sécurité avec des sous-agents spécialisés
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Fonctionnalités pilotées par ML avec des sous-agents data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optimisation de bout en bout avec des sous-agents performance
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Résolution des incidents de production avec des sous-agents ops

## 🔧 Outils (Commandes à usage unique)

### IA & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Créez des assistants IA et chatbots prêts pour la production
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Revue spécialisée pour les bases de code IA/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Créez des agents LangChain/LangGraph avec des schémas modernes
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Créez des pipelines ML de bout en bout avec MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimisez les prompts IA pour la performance et la qualité

### Architecture & Qualité du code
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Génère des explications détaillées de code complexe
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migre du code entre langages, frameworks ou versions
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refactore le code pour la maintenabilité et la performance
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analyser et prioriser la dette technique

### Données & Base de données
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Concevoir des architectures de pipeline de données évolutives
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Mettre en œuvre des systèmes complets de validation des données
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Stratégies avancées de migration de bases de données

### DevOps & Infrastructure
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Générer des configurations et des listes de vérification de déploiement
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Stratégies avancées d’optimisation de conteneurs
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Déploiements Kubernetes de niveau production
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Mettre en place une supervision et une observabilité complètes
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Mettre en œuvre des objectifs de niveau de service (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatiser les workflows de développement et d’exploitation

### Développement & Tests
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Créer des simulations d’API réalistes pour le développement et les tests
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Générer des endpoints API prêts pour la production avec pile d’implémentation complète
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Créer des suites de tests complètes avec détection de framework

### Sécurité & Conformité
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Tests d’accessibilité complets et correctifs associés
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Garantir la conformité réglementaire (RGPD, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Analyse de sécurité complète avec remédiation automatisée

### Débogage & Analyse
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Stratégies avancées de débogage et de traçage
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Analyse approfondie des schémas d’erreurs et stratégies de résolution
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Tracer et diagnostiquer les erreurs en production
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Créer des tickets GitHub/GitLab bien structurés

### Dépendances & Configuration
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Valider et gérer la configuration des applications
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Auditer les dépendances pour la sécurité et les licences
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Mettre à jour les dépendances du projet en toute sécurité

### Documentation & Collaboration
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Générer une documentation complète
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Mettre en œuvre des workflows Git efficaces
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Améliorer les pull requests avec des vérifications de qualité

### Optimisation des coûts
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimiser les coûts du cloud et de l'infrastructure

### Intégration & Configuration
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Configurer les environnements de développement pour les nouveaux membres de l’équipe

### Outils de sous-agents
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Revue de code multi-perspectives avec des sous-agents spécialisés
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Débogage approfondi avec des sous-agents de débogage et de performance
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optimisation full-stack avec plusieurs sous-agents
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Sauvegarder le contexte du projet avec le sous-agent gestionnaire de contexte
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Restaurer le contexte sauvegardé pour assurer la continuité

## Fonctionnalités

- Implémentations prêtes pour la production
- Détection automatique des frameworks
- Bonnes pratiques de sécurité
- Supervision et tests intégrés
- Les commandes fonctionnent de manière transparente

## Nombre de commandes

**Total : 52 commandes prêtes pour la production** organisées en :

### 🤖 Workflows (14 commandes)

- Développement de fonctionnalités & revue (3 commandes)
- Automatisation du processus de développement (6 commandes)
- Workflows orchestrés par sous-agents (5 commandes)

### 🔧 Outils (38 commandes)

- IA & Machine Learning (5 commandes)
- Architecture & Qualité du code (4 commandes)
- Données & Base de données (3 commandes)
- DevOps & Infrastructure (6 commandes)
- Développement & Tests (3 commandes)
- Sécurité & Conformité (3 commandes)
- Débogage et Analyse (4 commandes)
- Dépendances et Configuration (3 commandes)
- Documentation et Collaboration (1 commande)
- Intégration et Installation (1 commande)
- Outils Spécifiques aux Sous-agents (5 commandes)

## Exemples d'utilisation

### 🤖 Exemples de flux de travail

```bash
# Implement a complete feature
/workflows:feature-development Add user authentication with OAuth2

# Comprehensive code review
/workflows:full-review Review the authentication module

# Smart issue resolution
/workflows:smart-fix Fix performance degradation in API response times

# Modernize legacy system
/workflows:legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/workflows:full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/workflows:security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/workflows:data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/workflows:performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/workflows:incident-response High CPU usage causing service degradation in production
```

### 🔧 Exemples d'outils (commandes à usage unique)

```bash
# Create a user management API
/tools:api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/tools:multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/tools:prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/tools:data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/tools:error-trace analyze high memory usage in production pods

# Secure container images
/tools:security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/tools:doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/tools:onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/tools:multi-agent-review Review authentication module

# Deep debugging
/tools:smart-debug Investigate memory leak in production workers

# Full-stack optimization
/tools:multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/tools:context-save Save current project state and architectural decisions

# Restore project context
/tools:context-restore Load context from last week's sprint
```

## Commandes améliorées

### Sécurité & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Analyse de sécurité complète avec remédiation automatisée.

- **Analyse multi-outils** : Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Corrections automatiques** : Vulnérabilités courantes corrigées automatiquement
- **Intégration CI/CD** : Contrôles de sécurité pour GitHub Actions/GitLab CI
- **Analyse de conteneur** : Analyse de vulnérabilité d'image
- **Détection de secrets** : Intégration GitLeaks et TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Stratégies avancées d’optimisation de conteneurs.

- **Optimisation intelligente** : Analyse et suggère des améliorations
- **Builds multi-étapes** : Dockerfiles optimisés par framework
- **Outils modernes** : BuildKit, Bun, UV pour des builds plus rapides
- **Renforcement de la sécurité** : Images distroless, utilisateurs non-root
- **Intégration multi-commandes** : Fonctionne avec les sorties de /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Déploiements Kubernetes de niveau production.

- **Schémas avancés** : Standards de sécurité des pods, politiques réseau, OPA
- **Prêt pour GitOps** : Configurations FluxCD et ArgoCD
- **Observabilité** : Prometheus ServiceMonitors, OpenTelemetry
- **Auto-scaling** : Configurations HPA, VPA et autoscaler de cluster
- **Service mesh** : Intégration Istio/Linkerd

### Frontend & Données

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Stratégies avancées de migration de base de données.

- **Multi-base de données** : PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zéro temps d'arrêt** : Déploiements blue-green, migrations progressives
- **Sourcing d'événements** : Intégration Kafka/Kinesis pour CDC
- **Multi-plateforme** : Gère la persistance polyglotte
- **Supervision** : Vérifications de santé des migrations et retour arrière

## Combiner les workflows et les outils

La véritable puissance réside dans la combinaison des workflows et des outils pour des cycles de développement complets :

### Exemple : Développer une nouvelle fonctionnalité

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/workflows:feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/tools:test-harness Add integration tests for WebSocket connections
/tools:security-scan Check for WebSocket vulnerabilities
/tools:docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/workflows:full-review Review the entire chat feature implementation
```

### Exemple : Modernisation du code hérité

```bash
# 1. Start with the modernization workflow
/workflows:legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/tools:deps-upgrade Update all dependencies to latest versions
/tools:refactor-clean Remove deprecated patterns and dead code
/tools:test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/tools:docker-optimize Create multi-stage production build
/tools:k8s-manifest Deploy with zero-downtime strategy
```

## Modèles d'orchestration des commandes

Les commandes peuvent être utilisées individuellement ou combinées en modèles puissants :

### Exécution séquentielle
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Analyse parallèle
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Raffinement itératif
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Intégration inter-domaines
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Quand utiliser les workflows vs les outils

### 🔀 Workflows & Outils de sous-agents
- **Résolution de problèmes** : Analyser et corriger les problèmes de façon adaptative
- **Multiples perspectives** : Coordonner des sous-agents spécialisés
- **Tâches complexes** : Processus multi-étapes entre plusieurs domaines
- **Solutions inconnues** : Laisser les sous-agents déterminer l’approche

### 🛠️ Outils spécialisés
- **Configuration d’infrastructure** : Configurer des environnements
- **Génération de code** : Créer des implémentations spécifiques
- **Analyse** : Générer des rapports sans correction
- **Tâches de domaine** : Opérations hautement spécialisées

**Exemples :**
- "Implémenter un système d’authentification utilisateur" → `/workflows:feature-development`
- "Corriger les problèmes de performance sur toute la pile" → `/workflows:smart-fix`
- "Moderniser un monolithe hérité" → `/workflows:legacy-modernize`

### 🔧 Utilisez les outils lorsque :
- **Expertise spécifique requise** - Tâche claire et ciblée dans un domaine
- **Contrôle précis souhaité** - Vouloir diriger les détails d’implémentation
- **Partie d’un workflow manuel** - Intégration dans des processus existants
- **Spécialisation approfondie requise** - Implémentation de niveau expert
- **Développement sur un travail existant** - Améliorer ou affiner les productions précédentes

**Exemples :**
- "Créer des manifestes Kubernetes" → `/tools:k8s-manifest`
- "Analyser les vulnérabilités de sécurité" → `/tools:security-scan`
- "Générer la documentation d’API" → `/tools:doc-generate`

## Format de commande

Les commandes slash sont de simples fichiers markdown où :
- Le nom du fichier devient le nom de la commande (ex : `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Le contenu du fichier est le prompt/les instructions exécutés lors de l’appel
- Utilisez le placeholder `$ARGUMENTS` pour les entrées utilisateur

## Bonnes pratiques

### Sélection de commande
- **Laisser Claude Code suggérer automatiquement** - Analyse le contexte et sélectionne les commandes optimales
- **Utiliser des workflows pour les tâches complexes** - Les sous-agents coordonnent les implémentations multi-domaines
- **Utiliser des outils pour les tâches ciblées** - Appliquez des commandes spécifiques pour des améliorations ciblées

### Utilisation efficace
- **Fournir un contexte complet** - Inclure la stack technique, les contraintes et les exigences
- **Enchaîner les commandes stratégiquement** - Workflows → Outils → Affinements
- **Capitaliser sur les sorties précédentes** - Les commandes sont conçues pour fonctionner ensemble

## Contribution

1. Créez un fichier `.md` dans `workflows/` ou `tools/`
2. Utilisez des noms en minuscules-séparés-par-des-tirets
3. Incluez `$ARGUMENTS` pour la saisie utilisateur

## Dépannage

**Commande introuvable** : 
- Vérifiez que les fichiers sont dans `~/.claude/commands/tools/` ou `~/.claude/commands/workflows/`
- Utilisez le préfixe correct : `/tools:nom-de-commande` ou `/workflows:nom-de-commande`
- Ou aplatissez les répertoires si vous préférez sans préfixe : `cp tools/*.md . && cp workflows/*.md .`

**Workflows lents** : Normal - ils coordonnent plusieurs sous-agents

**Sortie générique** : Ajoutez un contexte plus spécifique sur votre stack technique

**Problèmes d’intégration** : Vérifiez les chemins de fichiers et la séquence des commandes

## Conseils de performance

**Sélection de commande :**
- **Workflows** : Coordination multi-sous-agents pour des fonctionnalités complexes
- **Outils** : Opérations à usage unique pour des tâches spécifiques
- **Éditions simples** : Restez avec l’agent principal

**Optimisation :**
- Commencez avec des outils pour les problèmes connus
- Fournissez des exigences détaillées dès le départ
- S'appuyer sur les résultats des commandes précédentes
- Laisser les workflows se terminer avant toute modification

### Ajouter un nouveau workflow :
- Se concentrer sur l'orchestration et la logique de délégation des sous-agents
- Spécifier quels sous-agents spécialisés utiliser et dans quel ordre
- Définir les schémas de coordination entre les sous-agents

### Ajouter un nouvel outil :
- Inclure des implémentations complètes et prêtes pour la production
- Structurer le contenu avec des sections claires et des résultats exploitables
- Inclure des exemples, des bonnes pratiques et des points d’intégration

## En savoir plus

- [Documentation Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Documentation des Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Documentation des Sous-agents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code sur GitHub](https://github.com/anthropics/claude-code)
- [Collection de Sous-agents Claude Code](https://github.com/wshobson/agents) - Sous-agents spécialisés utilisés par ces commandes


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---