# Moteur d’Approbation d’Entreprise

[![en](https://img.shields.io/badge/lang-en-blue.svg)](README.md)
[![es](https://img.shields.io/badge/lang-es-yellow.svg)](ES/README.md)

Action GitHub de niveau entreprise pour des workflows d’approbation basés sur des politiques avec des seuils par groupe (X sur N), logique OU entre groupes, et création automatique de tags semver.

## Fonctionnalités

- **Logique d’Approbation Flexible** : Support de la logique ET (tout doit approuver) et de seuil (X sur N) au sein des groupes
- **Logique OU Entre Groupes** : Plusieurs chemins d’approbation – l’approbation de n’importe quel groupe valide la demande
- **Approbateurs Mixtes** : Combinaison d’utilisateurs individuels et d’équipes GitHub dans un même groupe
- **Pipelines de Déploiement Progressifs** : Suivi d’un seul ticket à travers plusieurs environnements (dev → qa → stage → prod)
- **Visualisation du Pipeline** : Diagrammes Mermaid codés par couleur montrant la progression du déploiement
- **Approbations par Sous-Tickets** : Création de sous-tickets dédiés à l’approbation pour chaque étape – fermeture pour approuver
- **UX Améliorée des Commentaires** : Réactions emoji sur les commentaires d’approbation, section Quick Actions avec référence des commandes
- **Protection contre la Fermeture des Tickets** : Empêche les utilisateurs non autorisés de fermer les tickets d’approbation (réouverture automatique)
- **Modes d’Approbation Hybrides** : Mix de validations par commentaire et par sous-ticket selon le workflow ou l’étape
- **Suivi des PR et Commits** : Liste automatique des PR et commits dans les tickets de déploiement pour la gestion des releases
- **Création de Tags Semver** : Création automatique de tags git après approbation
- **Configuration Basée sur des Politiques** : Définition de politiques d’approbation réutilisables en YAML
- **Workflow Basé sur les Tickets** : Traçabilité transparente via les issues GitHub
- **Intégration Jira** : Extraction des clés d’issues depuis les commits, affichage dans les tickets d’approbation, mise à jour des Fix Versions
- **Suivi des Déploiements** : Création de déploiements GitHub pour visibilité dans le tableau de bord de déploiement
- **Configuration Externe** : Centralisation des politiques d’approbation dans un dépôt partagé
- **Gestion des Limites de Taux** : Reprise automatique avec backoff exponentiel pour les limites d’API GitHub
- **Support GitHub Enterprise Server** : Compatibilité complète avec les environnements GHES
- **Pas de Dépendances Externes** : Pure GitHub Actions, aucun service externe requis

📋 **Voir en action :** [Exemple de ticket d’approbation](https://github.com/jamengual/enterprise-approval-engine/issues/7)

## Table des Matières

- [Démarrage Rapide](#quick-start)
- [Référence de l’Action](#action-reference)
  - [Actions](#actions)
  - [Entrées](#inputs)
  - [Sorties](#outputs)
- [Référence de Configuration](#configuration-reference)
  - [Politiques](#policies)
  - [Flux de travail](#workflows)
  - [Étiquetage](#tagging-configuration)
  - [Modèles personnalisés](#custom-issue-templates)
  - [Valeurs par défaut](#defaults)
  - [Semver](#semver)
- [Référence complète de la configuration](#complete-configuration-reference)
- [Détails des fonctionnalités](#feature-details)
  - [Mots-clés d'approbation](#approval-keywords)
  - [Support des équipes](#team-support)
  - [Pipelines de déploiement progressif](#progressive-deployment-pipelines)
  - [Stratégies de version candidate](#release-candidate-strategies)
  - [Intégration Jira](#jira-integration)
  - [Suivi des déploiements](#deployment-tracking)
  - [Répertoire de configuration externe](#external-config-repository)
  - [Approbations bloquantes](#blocking-approvals)
  - [Suppression des tags](#tag-deletion-on-issue-close)
- [Exemples complets](#complete-examples)
- [Validation du schéma](#schema-validation)
- [Serveur GitHub Enterprise](#github-enterprise-server)

## Démarrage rapide

### 1. Créer la configuration

Créez `.github/approvals.yml` dans votre dépôt :

```yaml
version: 1

policies:
  dev-team:
    approvers: [alice, bob, charlie]
    min_approvals: 2

  platform-team:
    approvers: [team:platform-engineers]
    require_all: true

workflows:
  production-deploy:
    require:
      # OR logic: either path satisfies approval
      - policy: dev-team        # 2 of 3 developers
      - policy: platform-team   # ALL platform engineers
    on_approved:
      create_tag: true
      close_issue: true
```

### 2. Flux de travail d'approbation de demande

Créez `.github/workflows/request-approval.yml` :

```yaml
name: Request Deployment Approval

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy (e.g., v1.2.3)'
        required: true
        type: string

jobs:
  request:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Output Results
        run: |
          echo "Issue: ${{ steps.approval.outputs.issue_url }}"
          echo "Status: ${{ steps.approval.outputs.status }}"
```

### 3. Gérer les Commentaires d'Approbation

Créez `.github/workflows/handle-approval.yml` :

```yaml
name: Handle Approval Comments

on:
  issue_comment:
    types: [created]

jobs:
  process:
    if: contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: process
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Trigger Deployment
        if: steps.process.outputs.status == 'approved'
        run: |
          echo "Approved by: ${{ steps.process.outputs.approvers }}"
          echo "Tag created: ${{ steps.process.outputs.tag }}"
```

---

## Référence de l’Action

### Actions

L’action prend en charge quatre modes d’opération via l’entrée `action` :

| Action | Description | Quand l’utiliser |
|--------|-------------|-----------------|
| `request` | Créer une nouvelle demande d’approbation sous forme de ticket | Lors du démarrage d’un workflow de déploiement/publication |
| `process-comment` | Traiter un commentaire d’approbation/refus | Sur les événements `issue_comment` |
| `check` | Vérifier le statut actuel de l’approbation | Pour interroger la fin de l’approbation |
| `close-issue` | Gérer les événements de fermeture de ticket | Sur les événements `issues: [closed]` |

### Entrées

#### Entrées principales

| Entrée | Description | Obligatoire | Par défaut |
|--------|-------------|-------------|------------|
| `action` | Action à effectuer : `request`, `check`, `process-comment`, `close-issue` | Oui | - |
| `workflow` | Nom du workflow dans la config (pour l’action `request`) | Pour `request` | - |
| `version` | Version semver pour la création de tag (ex., `1.2.3` ou `v1.2.3`) | Non | - |
| `issue_number` | Numéro du ticket (pour `check`, `process-comment`, `close-issue`) | Pour check/process/close | - |
| `token` | Jeton GitHub pour les opérations API | Oui | - |

#### Entrées de configuration

| Entrée | Description | Obligatoire | Par défaut |
|--------|-------------|-------------|------------|
| `config_path` | Chemin vers le fichier de config approvals.yml | Non | `.github/approvals.yml` |
| `config_repo` | Répertoire externe pour config partagée (ex., `org/.github`) | Non | - |

#### Entrées de sondage (pour l’action `check`)

| Entrée | Description | Obligatoire | Par défaut |
|--------|-------------|-------------|------------|
| `wait` | Attendre l’approbation (sondage) au lieu de retourner immédiatement | Non | `false` |
| `timeout` | Délai d'attente (par exemple, `24h`, `1h30m`, `30m`) | Non | `72h` |

#### Entrées de support d'équipe

| Entrée | Description | Obligatoire | Par défaut |
|--------|-------------|-------------|------------|
| `app_id` | ID de l'application GitHub pour les vérifications d'appartenance à l'équipe | Non | - |
| `app_private_key` | Clé privée de l'application GitHub pour les vérifications d'appartenance à l'équipe | Non | - |

#### Entrées d'intégration Jira

| Entrée | Description | Obligatoire | Par défaut |
|--------|-------------|-------------|------------|
| `jira_base_url` | URL de base de Jira Cloud (par exemple, `https://yourcompany.atlassian.net`) | Non | - |
| `jira_user_email` | Email utilisateur Jira pour l'authentification API | Non | - |
| `jira_api_token` | Jeton API Jira pour l'authentification | Non | - |
| `jira_update_fix_version` | Met à jour les tickets Jira avec la version corrigée lors de l'approbation | Non | `true` |
| `include_jira_issues` | Inclure les tickets Jira dans le corps de la demande d'approbation | Non | `true` |

#### Entrées de suivi de déploiement

| Entrée | Description | Obligatoire | Par défaut |
|--------|-------------|-------------|------------|
| `create_deployment` | Créer un déploiement GitHub pour le suivi | Non | `true` |
| `deployment_environment` | Environnement cible (par exemple, `production`, `staging`) | Non | `production` |
| `deployment_environment_url` | URL vers l'environnement déployé | Non | - |

#### Autres entrées

| Entrée | Description | Obligatoire | Par défaut |
|--------|-------------|-------------|------------|
| `issue_action` | Action de l'événement issue pour `close-issue` (`closed`, `reopened`) | Non | - |
| `previous_tag` | Tag précédent pour comparer les commits (détecté automatiquement si non spécifié) | Non | - |

### Sorties

#### Sorties principales

| Sortie | Description | Disponible pour |
|--------|-------------|----------------|
| `status` | Statut d'approbation : `pending`, `approved`, `denied`, `timeout`, `tag_deleted`, `skipped` | Toutes les actions |
| `issue_number` | Numéro du ticket créé ou vérifié | Toutes les actions |
| `issue_url` | URL vers le ticket d'approbation | Toutes les actions |

#### Sorties d'Approbation

| Sortie | Description | Disponible Pour |
|--------|-------------|-----------------|
| `approvers` | Liste séparée par des virgules des utilisateurs ayant approuvé | `process-comment`, `check` |
| `denier` | Utilisateur ayant refusé la demande | `process-comment`, `check` |
| `satisfied_group` | Nom du groupe ayant satisfait l'approbation | `process-comment`, `check` |
| `tag` | Nom du tag créé | `process-comment` (à l'approbation) |
| `tag_deleted` | Tag qui a été supprimé | `close-issue` |

#### Sorties Jira

| Sortie | Description | Disponible Pour |
|--------|-------------|-----------------|
| `jira_issues` | Liste séparée par des virgules des clés des tickets Jira dans cette version | `request` |
| `jira_issues_json` | Tableau JSON des détails des tickets Jira (clé, résumé, type, statut) | `request` |

#### Sorties de Déploiement

| Sortie | Description | Disponible Pour |
|--------|-------------|-----------------|
| `deployment_id` | ID du déploiement GitHub pour les mises à jour de statut | `request` |
| `deployment_url` | URL vers le déploiement dans GitHub | `request` |

#### Sorties des Notes de Version

| Sortie | Description | Disponible Pour |
|--------|-------------|-----------------|
| `release_notes` | Notes de version générées automatiquement à partir des commits et des tickets Jira | `request` |
| `commits_count` | Nombre de commits dans cette version | `request` |

---

## Référence de Configuration

### Politiques

Les politiques définissent des groupes réutilisables d'approbateurs. Il existe deux formats :

#### Format simple

```yaml
policies:
  # Threshold-based: X of N must approve
  dev-team:
    approvers: [alice, bob, charlie]
    min_approvals: 2

  # All must approve (AND logic)
  security:
    approvers: [team:security, security-lead]
    require_all: true

  # Mixed teams and individuals
  production:
    approvers:
      - team:sre
      - tech-lead
      - product-owner
    min_approvals: 2
```

#### Format avancé (seuils par source)

Pour des exigences complexes telles que "2 de la plateforme ET 1 de la sécurité" :

```yaml
policies:
  # Complex AND gate
  production-gate:
    from:
      - team: platform-engineers
        min_approvals: 2        # 2 of the platform team
      - team: security
        min_approvals: 1        # 1 of the security team
      - user: alice             # alice must also approve
    logic: and                  # ALL sources must be satisfied

  # Flexible OR gate
  flexible-review:
    from:
      - team: security
        require_all: true       # All security team
      - team: platform
        min_approvals: 2        # OR 2 platform members
    logic: or                   # ANY source is enough

  # Executive approval: any one exec
  exec-approval:
    from:
      - user: ceo
      - user: cto
      - user: vp-engineering
    logic: or

  # User list with threshold
  leads:
    from:
      - users: [tech-lead, product-lead, design-lead]
        min_approvals: 2
```

**Types de sources :**

- `team: slug` - Équipe GitHub (nécessite un jeton App)
- `user: username` - Utilisateur unique (require_all implicite)
- `users: [a, b, c]` - Liste d'utilisateurs

**Logique au niveau de la politique :**

- `logic: and` - TOUS les sources doivent être satisfaites (par défaut)
- `logic: or` - QUELQUE source satisfaite suffit

#### Logique en ligne (mélange AND/OR)

Pour des expressions complexes, utilisez `logic:` sur chaque source pour spécifier comment elle se connecte à la suivante :

```yaml
policies:
  # (2 security AND 2 platform) OR alice
  complex-gate:
    from:
      - team: security
        min_approvals: 2
        logic: and              # AND with next source
      - team: platform
        min_approvals: 2
        logic: or               # OR with next source
      - user: alice            # alice alone can satisfy

  # (security AND platform) OR (alice AND bob) OR manager
  multi-path:
    from:
      - team: security
        min_approvals: 1
        logic: and
      - team: platform
        min_approvals: 1
        logic: or               # End first AND group
      - user: alice
        logic: and
      - user: bob
        logic: or               # End second AND group
      - user: manager          # Third path
```

**Priorité des opérateurs :** AND a une priorité plus élevée que OR (logique booléenne standard).

L’expression `A and B or C and D` est évaluée comme `(A AND B) OR (C AND D)`.

### Flux de travail

Les flux de travail définissent les exigences d’approbation et les actions :

```yaml
workflows:
  my-workflow:
    description: "Optional description"

    # Trigger conditions (for filtering)
    trigger:
      environment: production

    # Approval requirements (OR logic between items)
    require:
      - policy: dev-team
      - policy: security
      # Or inline approvers:
      - approvers: [alice, bob]
        require_all: true

    # Issue configuration
    issue:
      title: "Approval: {{version}}"
      body: |                          # Inline custom template (optional)
        ## My Custom Approval Issue
        Version: {{.Version}}
        Requested by: @{{.Requestor}}
        {{.GroupsTable}}
      body_file: "templates/my-template.md"  # Or load from file
      labels: [production, deploy]
      assignees_from_policy: true

    # Actions on approval
    on_approved:
      create_tag: true
      tag_prefix: "v"  # Creates v1.2.3
      close_issue: true
      comment: "Approved! Tag {{version}} created."

    # Actions on denial
    on_denied:
      close_issue: true
      comment: "Denied by {{denier}}."

    # Actions when issue is manually closed
    on_closed:
      delete_tag: true   # Delete the tag if issue is closed
      comment: "Deployment cancelled. Tag {{tag}} deleted."
```

### Configuration des Étiquettes

Contrôlez la manière dont les étiquettes sont créées par flux de travail :

```yaml
workflows:
  dev-deploy:
    require:
      - policy: dev-team
    on_approved:
      tagging:
        enabled: true
        start_version: "0.1.0"      # No 'v' prefix, start at 0.1.0
        auto_increment: patch        # Auto-bump: 0.1.0 -> 0.1.1 -> 0.1.2
        env_prefix: "dev-"           # Creates: dev-0.1.0, dev-0.1.1

  staging-deploy:
    require:
      - policy: qa-team
    on_approved:
      tagging:
        enabled: true
        start_version: "v1.0.0"     # 'v' prefix (inferred from start_version)
        auto_increment: minor        # v1.0.0 -> v1.1.0 -> v1.2.0
        env_prefix: "staging-"       # Creates: staging-v1.0.0

  production-deploy:
    require:
      - policy: prod-team
    on_approved:
      tagging:
        enabled: true
        start_version: "v1.0.0"     # Manual version required (no auto_increment)
```

**Options de marquage :**

| Option | Description |
|--------|-------------|
| `enabled` | Activer la création de tags |
| `start_version` | Version de départ et format (par ex., "v1.0.0" ou "1.0.0") |
| `prefix` | Préfixe de version (déduit de `start_version` si non défini) |
| `auto_increment` | Incrément automatique : `major`, `minor`, `patch`, ou omission pour manuel |
| `env_prefix` | Préfixe d'environnement (par ex., "dev-" crée "dev-v1.0.0") |

### Modèles personnalisés pour les issues

Vous pouvez entièrement personnaliser le corps de l’issue en utilisant des templates Go. Utilisez `body` pour les templates en ligne ou `body_file` pour charger depuis un fichier.

**Variables de template disponibles :**

| Variable | Description |
|----------|-------------|
| `{{.Title}}` | Titre de l’issue |
| `{{.Description}}` | Description du workflow |
| `{{.Version}}` | Version Semver |
| `{{.Requestor}}` | Nom d’utilisateur GitHub ayant demandé |
| `{{.Environment}}` | Nom de l’environnement |
| `{{.RunURL}}` | Lien vers l’exécution du workflow |
| `{{.RepoURL}}` | URL du dépôt |
| `{{.CommitSHA}}` | SHA complet du commit |
| `{{.CommitURL}}` | Lien vers le commit |
| `{{.Branch}}` | Nom de la branche |
| `{{.GroupsTable}}` | Tableau pré-rendu du statut d’approbation |
| `{{.Timestamp}}` | Horodatage de la demande |
| `{{.PreviousVersion}}` | Version/tag précédent(e) |
| `{{.CommitsCount}}` | Nombre de commits dans cette version |
| `{{.HasJiraIssues}}` | Booléen - existence de tickets Jira |
| `{{.JiraIssues}}` | Tableau de données des tickets Jira |
| `{{.JiraIssuesTable}}` | Tableau pré-rendu des tickets Jira |
| `{{.PipelineTable}}` | Tableau pré-rendu de la pipeline de déploiement |
| `{{.PipelineMermaid}}` | Diagramme Mermaid pré-rendu du flux |
| `{{.Vars.key}}` | Variables personnalisées |

**Fonctions de template :**

| Fonction | Exemple | Description |
|----------|---------|-------------|
| `slice` | `{{slice .CommitSHA 0 7}}` | Sous-chaîne (SHA court) |
| `title` | `{{.Environment \| title}}` | Majuscules en début de mot |
| `upper` | `{{.Version \| upper}}` | Majuscules |
| `lower` | `{{.Version \| lower}}` | Minuscules |
| `join` | `{{join .Groups ","}}` | Joindre un tableau |
| `contains` | `{{if contains .Branch "feature"}}` | Vérifier une sous-chaîne |
| `replace` | `{{replace .Version "v" ""}}` | Remplacer une chaîne |
| `default` | `{{default "N/A" .Environment}}` | Valeur par défaut |

**Exemple de fichier template personnalisé** (`.github/templates/deploy.md`):

```markdown
## {{.Title}}

### Release Information

- **Version:** `{{.Version}}`
- **Requested by:** @{{.Requestor}}
{{- if .CommitSHA}}
- **Commit:** [{{slice .CommitSHA 0 7}}](https://raw.githubusercontent.com/jamengual/enterprise-approval-engine/main/{{.CommitURL}})
{{- end}}
{{- if .CommitsCount}}
- **Changes:** {{.CommitsCount}} commits since {{.PreviousVersion}}
{{- end}}

{{if .HasJiraIssues}}
### Jira Issues

{{.JiraIssuesTable}}
{{end}}

### Approval Status

{{.GroupsTable}}

---

**Approve:** Comment `approve` | **Deny:** Comment `deny`
```

### Valeurs par défaut

Valeurs par défaut globales qui s'appliquent à tous les flux de travail :

```yaml
defaults:
  timeout: 72h                    # Default approval timeout
  allow_self_approval: false      # Whether requestors can approve their own requests
  issue_labels:                   # Labels added to all approval issues
    - approval-required
```

### Semver

Configurer la gestion des versions :

```yaml
semver:
  prefix: "v"              # Tag prefix (v1.2.3)
  strategy: input          # Use version from input
  validate: true           # Validate semver format
  allow_prerelease: true   # Allow prerelease versions (e.g., v1.0.0-beta.1)
  auto:                    # Label-based auto-increment (when strategy: auto)
    major_labels: [breaking, major]
    minor_labels: [feature, minor]
    patch_labels: [fix, patch, bug]
```

---

## Référence Complète de Configuration

Cette section documente **toutes les options de configuration** disponibles dans `approvals.yml`.

### Structure de Niveau Supérieur

```yaml
version: 1                    # Required: config version (always 1)
defaults: { ... }             # Optional: global defaults
policies: { ... }             # Required: reusable approval policies
workflows: { ... }            # Required: approval workflows
semver: { ... }               # Optional: version handling settings
```

### Options `defaults`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `timeout` | durée | `72h` | Délai d’attente pour l’action `check` bloquante avec `wait: true`. Utilisez des heures (par ex., `168h` pour 1 semaine). Non nécessaire pour les workflows pilotés par événements. |
| `allow_self_approval` | booléen | `false` | Indique si le demandeur peut approuver sa propre demande |
| `issue_labels` | string[] | `[]` | Étiquettes ajoutées à tous les tickets d’approbation |

### Options `policies.<name>` (Format Simple)

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `approvers` | string[] | - | Liste des noms d’utilisateur ou références `team:slug` |
| `min_approvals` | int | 0 | Nombre d’approbations requises (0 = utiliser `require_all`) |
| `require_all` | booléen | `false` | Si vrai, TOUS les approbateurs doivent approuver |

### Options `policies.<name>` (Format Avancé)

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `from` | source[] | - | Liste des sources d’approbateurs avec seuils individuels |
| `logic` | string | `"and"` | Comment combiner les sources : `"and"` ou `"or"` |

**Options des sources d’approbateurs (`from[]`) :**

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `team` | string | - | Identifiant de l’équipe (par ex. `"platform"` ou `"org/platform"`) |
| `user` | string | - | Nom d’utilisateur unique |
| `users` | string[] | - | Liste de noms d’utilisateur |
| `min_approvals` | int | 1 | Nombre d’approbations requises de cette source |
| `require_all` | booléen | `false` | Tous les membres de cette source doivent approuver |
| `logic` | string | - | Logique vers la source suivante : `"and"` ou `"or"` |

### Options `workflows.<name>`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `description` | string | - | Description lisible par l’humain |
| `trigger` | map | - | Conditions de déclenchement (pour le filtrage) |
| `require` | requirement[] | - | **Requis :** Exigences d'approbation (logique OU entre les éléments) |
| `issue` | object | - | Paramètres de création de problème |
| `on_approved` | object | - | Actions en cas d'approbation |
| `on_denied` | object | - | Actions en cas de refus |
| `on_closed` | object | - | Actions lorsque le problème est fermé manuellement |
| `pipeline` | object | - | Configuration du pipeline de déploiement progressif |

### `workflows.<name>.require[]` Options

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `policy` | string | - | Référence à une politique définie |
| `approvers` | string[] | - | Approbateurs en ligne (alternative à la politique) |
| `min_approvals` | int | - | Remplace min_approvals de la politique |
| `require_all` | bool | - | Remplace require_all de la politique |

### `workflows.<name>.issue` Options

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `title` | string | `"Approbation requise : {workflow}"` | Titre du problème (supporte `{{version}}`, `{{environment}}`, `{{workflow}}`) |
| `body` | string | - | Modèle personnalisé du corps du problème (syntaxe modèle Go) |
| `body_file` | string | - | Chemin vers le fichier modèle (relatif à `.github/`) |
| `labels` | string[] | `[]` | Étiquettes supplémentaires pour ce workflow |
| `assignees_from_policy` | bool | `false` | Attribution automatique des utilisateurs individuels depuis les politiques (max 10) |

### `workflows.<name>.on_approved` Options

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `create_tag` | bool | `false` | Créer une étiquette git (utilise la version entrée) |
| `close_issue` | bool | `false` | Fermer le problème après approbation |
| `comment` | string | - | Commentaire à publier (supporte `{{version}}`, `{{satisfied_group}}`) |
| `tagging` | object | - | Configuration avancée de l'étiquetage |

### `workflows.<name>.on_approved.tagging` Options

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | Activer la création de tags |
| `start_version` | string | `"0.0.0"` | Version initiale (par ex., `"v1.0.0"` ou `"1.0.0"`) |
| `prefix` | string | (inféré) | Préfixe de version (inféré depuis `start_version`) |
| `auto_increment` | string | - | Incrément automatique : `"major"`, `"minor"`, `"patch"`, ou omettre pour manuel |
| `env_prefix` | string | - | Préfixe d’environnement (par ex., `"dev-"` crée `"dev-v1.0.0"`) |

### Options `workflows.<name>.on_denied`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `close_issue` | bool | `false` | Fermer le ticket après refus |
| `comment` | string | - | Commentaire à poster (supporte `{{denier}}`) |

### Options `workflows.<name>.on_closed`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `delete_tag` | bool | `false` | Supprimer le tag associé à la fermeture du ticket |
| `comment` | string | - | Commentaire à poster (supporte `{{tag}}`, `{{version}}`) |

### Options `workflows.<name>.pipeline`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `stages` | stage[] | - | **Requis :** Liste ordonnée des étapes de déploiement |
| `track_prs` | bool | `false` | Inclure les PR fusionnées dans le corps du ticket |
| `track_commits` | bool | `false` | Inclure les commits dans le corps du ticket |
| `compare_from_tag` | string | - | Motif de tag pour comparaison (par ex., `"v*"`) |
| `show_mermaid_diagram` | bool | `true` | Afficher le diagramme Mermaid visuel des étapes |
| `release_strategy` | object | - | Stratégie de sélection du candidat à la release |

### Options `workflows.<name>.pipeline.stages[]`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `name` | string | - | **Requis :** Nom de l’étape (par ex., `"dev"`, `"prod"`) |
| `environment` | string | - | Nom de l’environnement GitHub |
| `policy` | string | - | Politique d’approbation pour cette étape |
| `approvers` | string[] | - | Approveurs en ligne (alternative à la politique) |
| `on_approved` | string | - | Commentaire à poster lorsque l’étape est approuvée |
| `create_tag` | booléen | `false` | Crée une étiquette git à cette étape |
| `is_final` | booléen | `false` | Ferme le problème après cette étape |
| `auto_approve` | booléen | `false` | Approuve automatiquement sans intervention humaine |

### Options de `workflows.<name>.pipeline.release_strategy`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `type` | chaîne | `"tag"` | Stratégie : `"tag"`, `"branch"`, `"label"`, `"milestone"` |
| `branch` | objet | - | Paramètres de la stratégie de branche |
| `label` | objet | - | Paramètres de la stratégie d’étiquette |
| `milestone` | objet | - | Paramètres de la stratégie de jalon |
| `auto_create` | objet | - | Création automatique du prochain artefact de version |

### Options de `release_strategy.branch`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `pattern` | chaîne | `"release/{{version}}"` | Modèle de nommage de branche |
| `base_branch` | chaîne | `"main"` | Branche de référence pour la comparaison |
| `delete_after_release` | booléen | `false` | Supprime la branche après le déploiement en production |

### Options de `release_strategy.label`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `pattern` | chaîne | `"release:{{version}}"` | Modèle de nommage d’étiquette |
| `pending_label` | chaîne | - | Étiquette pour les PR en attente d’assignation de version |
| `remove_after_release` | booléen | `false` | Supprime les étiquettes après le déploiement en production |

### Options de `release_strategy.milestone`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `pattern` | chaîne | `"v{{version}}"` | Modèle de nommage de jalon |
| `close_after_release` | booléen | `false` | Ferme le jalon après le déploiement en production |

### Options de `release_strategy.auto_create`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `enabled` | bool | `false` | Activer la création automatique à la fin de l'étape finale |
| `next_version` | string | `"patch"` | Incrément de version : `"patch"`, `"minor"`, `"major"` |
| `create_issue` | bool | `false` | Créer un nouveau ticket d'approbation pour la prochaine version |
| `comment` | string | - | Commentaire à publier concernant la prochaine version |

### Options `semver`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `prefix` | string | `"v"` | Préfixe de tag |
| `strategy` | string | `"input"` | Stratégie de version : `"input"`, `"auto"` |
| `validate` | bool | `false` | Valider le format semver |
| `allow_prerelease` | bool | `false` | Autoriser les versions préliminaires (ex. : `v1.0.0-beta.1`) |
| `auto` | object | - | Paramètres d’incrémentation automatique basés sur les labels |

### Options `semver.auto`

| Clé | Type | Défaut | Description |
|-----|------|---------|-------------|
| `major_labels` | string[] | `[]` | Labels de PR qui déclenchent une montée majeure |
| `minor_labels` | string[] | `[]` | Labels de PR qui déclenchent une montée mineure |
| `patch_labels` | string[] | `[]` | Labels de PR qui déclenchent une montée de patch |

---

## Détails de la fonctionnalité

### Mots-clés d’approbation

Les utilisateurs peuvent approuver ou refuser les requêtes en commentant sur le ticket :

**Mots-clés d’approbation :** `approve`, `approved`, `lgtm`, `yes`, `/approve`

**Mots-clés de refus :** `deny`, `denied`, `reject`, `rejected`, `no`, `/deny`

### Support des équipes

Pour utiliser les approbateurs basés sur les équipes GitHub, vous avez besoin de permissions élevées. Le `GITHUB_TOKEN` standard ne peut pas lister les membres de l’équipe. Utilisez un token d’application GitHub :

```yaml
jobs:
  process:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4

      # Generate GitHub App token
      - uses: actions/create-github-app-token@v2
        id: app-token
        with:
          app-id: ${{ vars.APP_ID }}
          private-key: ${{ secrets.APP_PRIVATE_KEY }}

      # Use the app token for team membership checks
      - uses: jamengual/enterprise-approval-engine@v1
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ steps.app-token.outputs.token }}
```

**Autorisations requises pour l’application GitHub :**

- `Organisation > Membres : Lecture` - Pour lister les membres de l’équipe

### Pipelines de déploiement progressif

Suivez les déploiements à travers plusieurs environnements avec un seul ticket d’approbation. À chaque étape approuvée, le ticket se met à jour pour montrer la progression et passe automatiquement à l’étape suivante.

#### Configuration du pipeline

```yaml
# .github/approvals.yml or external config
version: 1

policies:
  developers:
    approvers: [dev1, dev2, dev3]
    min_approvals: 1

  qa-team:
    approvers: [qa1, qa2]
    min_approvals: 1

  tech-leads:
    approvers: [lead1, lead2]
    min_approvals: 1

  production-approvers:
    approvers: [sre1, sre2, security-lead]
    require_all: true

workflows:
  deploy:
    description: "Deploy through all environments (dev → qa → stage → prod)"
    require:
      - policy: developers  # Initial approval to start pipeline
    pipeline:
      track_prs: true       # Include PRs in the issue body
      track_commits: true   # Include commits in the issue body
      stages:
        - name: dev
          environment: development
          policy: developers
          on_approved: "✅ **DEV** deployment approved! Proceeding to QA..."
        - name: qa
          environment: qa
          policy: qa-team
          on_approved: "✅ **QA** deployment approved! Proceeding to STAGING..."
        - name: stage
          environment: staging
          policy: tech-leads
          on_approved: "✅ **STAGING** deployment approved! Ready for PRODUCTION..."
        - name: prod
          environment: production
          policy: production-approvers
          on_approved: "🚀 **PRODUCTION** deployment complete!"
          create_tag: true   # Create tag when PROD is approved
          is_final: true     # Close issue after this stage
    on_approved:
      close_issue: true
      comment: |
        🎉 **Deployment Complete!**

        Version `{{version}}` has been deployed to all environments.
```
#### Exemple de flux de travail de pipeline


```yaml
# .github/workflows/request-pipeline.yml
name: Request Pipeline Deployment

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy'
        required: true
        type: string

permissions:
  contents: write
  issues: write
  pull-requests: read  # Required for PR tracking

jobs:
  request:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
        with:
          fetch-depth: 0  # Needed for commit/PR comparison

      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Output Results
        run: |
          echo "## Pipeline Deployment Started" >> $GITHUB_STEP_SUMMARY
          echo "- **Issue:** #${{ steps.approval.outputs.issue_number }}" >> $GITHUB_STEP_SUMMARY
          echo "- **URL:** ${{ steps.approval.outputs.issue_url }}" >> $GITHUB_STEP_SUMMARY
```

#### Comment ça fonctionne

1. **Création de problème** : Lorsqu'il est déclenché, crée un seul problème affichant toutes les étapes avec un diagramme Mermaid visuel et un tableau de progression :

```markdown
## 🚀 Pipeline de déploiement : v1.2.0

### Flux du pipeline

​```mermaid
flowchart LR
    DEV(⏳ DEV)
    QA(⬜ QA)
    STAGE(⬜ STAGE)
    PROD(⬜ PROD)
    DEV --> QA --> STAGE --> PROD

    classDef completed fill:#28a745,stroke:#1e7e34,color:#fff
    classDef current fill:#ffc107,stroke:#d39e00,color:#000
    classDef pending fill:#6c757d,stroke:#545b62,color:#fff
    class DEV current
    class QA,STAGE,PROD pending
​```

### Deployment Progress

| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ⏳ Awaiting | - | - |
| QA | ⬜ Pending | - | - |
| STAGE | ⬜ Pending | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** DEV
```

Le diagramme Mermaid fournit une vue d'ensemble avec des nœuds codés par couleur :
- 🟢 **Vert** - Étapes terminées
- 🟡 **Jaune** - Étape actuelle en attente d'approbation
- ⚪ **Gris** - Étapes en attente
- 🔵 **Cyan** - Étapes d'approbation automatique

Pour désactiver le diagramme Mermaid, définissez `show_mermaid_diagram: false` dans la configuration du pipeline.

2. **Progression des étapes** : Commentez `approve` pour passer à l'étape suivante. Le diagramme et le tableau se mettent à jour automatiquement :

```markdown
| Stage | Status | Approver | Time |
|-------|--------|----------|------|
| DEV | ✅ Deployed | @developer1 | Dec 9 10:30 |
| QA | ✅ Deployed | @qa-lead | Dec 9 14:15 |
| STAGE | ⏳ Awaiting | - | - |
| PROD | ⬜ Pending | - | - |

**Current Stage:** STAGE
```
3. **Suivi des PR et des commits** : Les responsables des versions voient exactement ce qui est déployé :


```markdown
### Pull Requests in this Release

| PR | Title | Author |
|----|-------|--------|
| [#42](https://...) | Add user authentication | @alice |
| [#45](https://...) | Fix payment processing bug | @bob |

### Commits

- [`abc1234`](https://...) feat: add OAuth2 support
- [`def5678`](https://...) fix: handle null payments
```

4. **Achèvement** : Lorsque l’étape finale est approuvée :
   - Un tag est créé (si `create_tag: true`)
   - Un commentaire d’achèvement est posté
   - Le problème est automatiquement fermé

#### Options de l’étape du pipeline

| Option | Description |
|--------|-------------|
| `name` | Nom de l’étape (affiché dans le tableau) |
| `environment` | Nom de l’environnement GitHub |
| `policy` | Politique d’approbation pour cette étape |
| `approvers` | Approbateurs en ligne (alternative à la politique) |
| `on_approved` | Message à poster lorsque l’étape est approuvée |
| `create_tag` | Créer un tag git à cette étape |
| `is_final` | Fermer le problème après cette étape |
| `auto_approve` | Approuver automatiquement cette étape sans intervention humaine |
| `approval_mode` | Remplacer le mode d’approbation du workflow pour cette étape |

#### Modes d’approbation

Choisissez comment les approbateurs interagissent avec les demandes d’approbation :

| Mode | Description |
|------|-------------|
| `comments` | (Par défaut) Les approbateurs commentent `/approve` ou `approve` sur le problème |
| `sub_issues` | Crée une sous-issue pour chaque étape - fermer pour approuver |
| `hybrid` | Mélange des modes par étape - utiliser `approval_mode` sur chaque étape |

**Exemple d’approbation par sous-issue :**

```yaml
workflows:
  deploy:
    approval_mode: sub_issues
    sub_issue_settings:
      title_template: "⏳ Approve: {{stage}} for {{version}}"  # Changes to ✅ when approved
      labels: [approval-stage]
      protection:
        only_assignee_can_close: true   # Prevents unauthorized approvals
        prevent_parent_close: true       # Parent can't close until all approved
    pipeline:
      stages:
        - name: dev
          policy: developers
        - name: prod
          policy: production-approvers
```
Avec des sous-problèmes, le problème principal affiche un tableau des sous-problèmes d'approbation :


```markdown
### 📋 Approval Sub-Issues

| Stage | Sub-Issue | Status | Assignees |
|-------|-----------|--------|----------|
| DEV | #124 | ⏳ Awaiting | @alice, @bob |
| PROD | #125 | ⏳ Awaiting | @sre1, @sre2 |
```

**Mode Hybride (surcharge par étape) :**

```yaml
workflows:
  deploy:
    approval_mode: comments  # Default for this workflow
    pipeline:
      stages:
        - name: dev
          policy: developers
          # Uses comments (workflow default)
        - name: prod
          policy: production-approvers
          approval_mode: sub_issues  # Override for production only
```

#### Expérience Utilisateur Améliorée des Commentaires

L’action inclut une expérience utilisateur améliorée pour l’approbation basée sur les commentaires :

- **Réactions Emoji** : Réactions automatiques sur les commentaires d’approbation
  - 👍 Approuvé
  - 👎 Refusé
  - 👀 Vu (en cours)

- **Section Actions Rapides** : Le corps de l’issue inclut un tableau de référence des commandes :

```markdown
### ⚡ Quick Actions

| Action | Command | Description |
|--------|---------|-------------|
| ✅ Approve | `/approve` | Approve the **DEV** stage |
| ❌ Deny | `/deny [reason]` | Deny with optional reason |
| 📊 Status | `/status` | Show current approval status |
```

**Configurer via `comment_settings` :**

```yaml
workflows:
  deploy:
    comment_settings:
      react_to_comments: true     # Add emoji reactions (default: true)
      show_quick_actions: true    # Show Quick Actions section (default: true)
```

#### Approbation automatique pour les environnements inférieurs

Utilisez `auto_approve: true` sur les étapes du pipeline qui doivent être approuvées automatiquement sans intervention humaine. Cela est idéal pour les environnements inférieurs comme `dev` ou `integration` où vous souhaitez accélérer le pipeline tout en conservant des étapes d'approbation pour la production.

**Exemple avec approbation automatique :**

```yaml
workflows:
  deploy:
    description: "Deploy through environments"
    pipeline:
      stages:
        - name: dev
          environment: development
          auto_approve: true              # Automatically approved
          on_approved: "🤖 DEV auto-deployed"
        - name: integration
          environment: integration
          auto_approve: true              # Automatically approved
          on_approved: "🤖 INTEGRATION auto-deployed"
        - name: staging
          environment: staging
          policy: qa-team                 # Requires manual approval
          on_approved: "✅ STAGING approved"
        - name: production
          environment: production
          policy: production-approvers    # Requires manual approval
          create_tag: true
          is_final: true
```

**Comment ça fonctionne :**

1. Lorsqu'un problème de pipeline est créé, toutes les étapes initiales avec `auto_approve: true` sont automatiquement terminées  
2. Lorsqu'une étape est approuvée manuellement, toutes les étapes consécutives avec `auto_approve: true` qui suivent sont également automatiquement terminées  
3. Les étapes auto-approuvées s'affichent avec l'indicateur 🤖 dans le tableau du pipeline  
4. L'approbateur est enregistré comme `[auto]` dans l'historique de l'étape  

**Cas d'utilisation :**

- **Environnements de développement** : Déployer immédiatement sans attendre l'approbation  
- **Tests d'intégration** : Laisser le pipeline CI/CD progresser automatiquement à travers les environnements de test  
- **Déploiements canaris** : Auto-approuver l'étape canaris, exiger une approbation pour le déploiement complet  

#### Options de configuration du pipeline

| Option | Par défaut | Description |
|--------|------------|-------------|
| `track_prs` | `false` | Inclure les PR fusionnées dans le corps du problème |
| `track_commits` | `false` | Inclure les commits depuis la dernière étiquette |
| `compare_from_tag` | - | Modèle personnalisé d'étiquette à comparer |
| `show_mermaid_diagram` | `true` | Afficher le diagramme Mermaid visuel des étapes du pipeline |

**Note :** Le suivi des PR nécessite la permission `pull-requests: read` dans votre workflow.  

### Stratégies de candidat à la release

Dans les environnements d'entreprise, les PR fusionnées dans la branche principale ne sont pas toujours des candidats à la release immédiate. Le moteur d'approbation prend en charge trois stratégies pour sélectionner les PR appartenant à une release :  

#### Types de stratégies

| Stratégie | Description | Cas d'utilisation |
|-----------|-------------|-------------------|
| `tag` | PR entre deux étiquettes git (par défaut) | Releases simples, développement basé sur la branche principale |
| `branch` | PR fusionnées dans une branche de release | GitFlow, branches de release |
| `label` | PR avec un label spécifique de release | Sélection flexible, releases groupées |
| `milestone` | PR assignées à un jalon GitHub | Releases alignées sur la feuille de route |

#### Configuration

```yaml
# .github/approvals.yml
workflows:
  deploy:
    description: "Production deployment pipeline"
    pipeline:
      track_prs: true
      track_commits: true

      # Configure release selection strategy
      release_strategy:
        type: milestone  # or: tag, branch, label

        # Milestone strategy settings
        milestone:
          pattern: "v{{version}}"        # e.g., "v1.2.0"
          close_after_release: true       # Close milestone on prod completion

        # Auto-create next release artifact on completion
        auto_create:
          enabled: true
          next_version: patch             # or: minor, major
          create_issue: true              # Create new approval issue

      stages:
        - name: dev
          policy: developers
        - name: prod
          policy: production-approvers
          is_final: true
```
#### Stratégie de branche

Utilisez des branches de version pour un développement de type GitFlow :


```yaml
release_strategy:
  type: branch
  branch:
    pattern: "release/{{version}}"  # Creates release/v1.2.0
    base_branch: main               # Compare against main
    delete_after_release: true      # Cleanup after prod deploy

  auto_create:
    enabled: true
    next_version: minor
```

**Comment ça marche :**
1. Créez une branche de version : `release/v1.2.0`
2. Les PR fusionnées dans la branche sont des candidats à la version
3. Demandez l'approbation pour cette version
4. L'issue d'approbation affiche toutes les PR de la branche de version
5. Après la production, la branche est supprimée (optionnel) et la branche suivante est créée

#### Stratégie de labels

Utilisez des labels pour une sélection flexible des PR :

```yaml
release_strategy:
  type: label
  label:
    pattern: "release:{{version}}"      # e.g., "release:v1.2.0"
    pending_label: "pending-release"    # Applied to merged PRs awaiting release
    remove_after_release: true          # Remove label after prod deploy

  auto_create:
    enabled: true
    next_version: patch
```

**Comment ça fonctionne :**
1. Les PR fusionnées dans main reçoivent le label `pending-release`
2. Le responsable des versions applique `release:v1.2.0` aux PR sélectionnées
3. Demander l'approbation pour la v1.2.0
4. L’issue d’approbation affiche uniquement les PR avec ce label
5. Après la production, les labels sont supprimés et le label de la prochaine version est créé

#### Stratégie de jalons

Utilisez des jalons pour les versions alignées sur la feuille de route :

```yaml
release_strategy:
  type: milestone
  milestone:
    pattern: "Release {{version}}"       # e.g., "Release 1.2.0"
    close_after_release: true            # Close milestone on completion

  auto_create:
    enabled: true
    next_version: minor
    create_issue: true                   # Auto-create next approval issue
```

**Comment ça fonctionne :**
1. Créer un jalon : « Release 1.2.0 »
2. Assigner les PRs au jalon pendant le développement
3. Demander l'approbation pour la v1.2.0
4. L’issue d’approbation affiche toutes les PRs du jalon
5. Après la prod, le jalon est fermé et le jalon suivant est créé

#### Création automatique à la fin

Lorsque la dernière étape (prod) est approuvée, préparer automatiquement la prochaine version :

```yaml
auto_create:
  enabled: true
  next_version: patch      # Calculate next: patch, minor, or major
  create_issue: true       # Create new approval issue immediately
  comment: |               # Custom message (optional)
    🚀 **Next release prepared:** {{version}}
```

Cela crée :
- **Stratégie de branche :** Nouvelle branche de release à partir de main
- **Stratégie d’étiquette :** Nouvelle étiquette de release
- **Stratégie de jalon :** Nouveau jalon

#### Options de nettoyage

Chaque stratégie possède des actions de nettoyage optionnelles qui s’exécutent lorsque l’étape finale (prod) est approuvée. **Toutes les options de nettoyage sont désactivées par défaut (`false`)** - le nettoyage est à activer :

| Stratégie | Option de nettoyage | Description |
|-----------|---------------------|-------------|
| Branche | `delete_after_release` | Supprimer la branche de release |
| Étiquette | `remove_after_release` | Supprimer les étiquettes de release des PR |
| Jalon | `close_after_release` | Fermer le jalon |

```yaml
release_strategy:
  type: branch
  branch:
    pattern: "release/{{version}}"
    delete_after_release: false   # Keep branch for reference (default)

  type: milestone
  milestone:
    pattern: "v{{version}}"
    close_after_release: true     # Close milestone when done
```

#### Déploiements de Correctifs Urgents

Pour les correctifs d'urgence qui doivent contourner les flux de travail de publication normaux, créez un flux de travail séparé :

```yaml
# .github/approvals.yml
workflows:
  # Standard releases - full pipeline with milestone tracking
  deploy:
    description: "Standard release pipeline (dev → qa → stage → prod)"
    pipeline:
      release_strategy:
        type: milestone
        milestone:
          pattern: "v{{version}}"
          close_after_release: true
        auto_create:
          enabled: true
          next_version: minor
      stages:
        - name: dev
          policy: developers
        - name: qa
          policy: qa-team
        - name: stage
          policy: tech-leads
        - name: prod
          policy: production-approvers
          is_final: true

  # Hotfixes - skip stages, direct to prod
  hotfix:
    description: "Emergency hotfix - direct to production"
    pipeline:
      release_strategy:
        type: tag              # Simple tag-based, no cleanup needed
        # No auto_create - hotfixes are one-off
      stages:
        - name: prod
          policy: production-approvers
          create_tag: true
          is_final: true
    on_approved:
      close_issue: true
      comment: "🚨 Hotfix {{version}} deployed to production"
```

**Correction urgente par rapport à une version régulière :**

```bash
# Regular release - goes through all stages
gh workflow run request-approval.yml -f workflow_name=deploy -f version=v1.3.0

# Hotfix - goes straight to prod
gh workflow run request-approval.yml -f workflow_name=hotfix -f version=v1.2.1
```

**Modèles de correctifs rapides :**

| Scénario | Stratégie | Nettoyage | Création automatique |
|----------|----------|---------|-------------|
| Correction d'urgence | `tag` | Aucun | Désactivé |
| Version patch | `milestone` | `close_after_release: false` | Désactivé |
| Plusieurs correctifs rapides | `branch` | `delete_after_release: false` | Désactivé |

#### Avantages de la stratégie de publication

| Stratégie | Avantages | Inconvénients |
|----------|------|------|
| **Tag** | Simple, pas de workflow supplémentaire | Tous les PR fusionnés inclus |
| **Branche** | Portée claire de la version, isolation | Surcharge de gestion des branches |
| **Étiquette** | Sélection flexible, facile à modifier | Étiquetage manuel requis |
| **Milestone** | Visibilité de la feuille de route, intégration de la planification | Nécessite une discipline sur les milestones |

**Recommandation :**

- Utiliser **tag** pour les projets simples avec déploiement continu
- Utiliser **branche** pour les environnements réglementés nécessitant une isolation des versions
- Utiliser **étiquette** pour les versions groupées avec portée flexible
- Utiliser **milestone** pour un développement guidé par la feuille de route avec une planification claire des versions

### Intégration Jira

Extraire automatiquement les tickets Jira à partir des commits et des noms de branches. L’action supporte deux modes :

#### Mode liens uniquement (sans authentification requise)

Fournissez simplement `jira_base_url` pour extraire les clés des tickets et les afficher comme liens cliquables :

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    jira_base_url: https://yourcompany.atlassian.net  # That's it!
```

Cela extrait les clés des tickets (par ex., `PROJ-123`) des messages de commit et des noms de branches, en les affichant comme des liens dans le ticket d'approbation :

```markdown
### Jira Issues
- [PROJ-123](https://yourcompany.atlassian.net/browse/PROJ-123)
- [PROJ-456](https://yourcompany.atlassian.net/browse/PROJ-456)
```
#### Mode Complet (Avec accès API)

Ajoutez des identifiants pour également récupérer les détails des problèmes et mettre à jour les versions corrigées :


```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    # Jira configuration
    jira_base_url: https://yourcompany.atlassian.net
    jira_user_email: ${{ secrets.JIRA_EMAIL }}
    jira_api_token: ${{ secrets.JIRA_API_TOKEN }}
    jira_update_fix_version: 'true'
```

Cela affiche des informations détaillées sur le problème :

```markdown
### Jira Issues in this Release

| Key | Summary | Type | Status |
|-----|---------|------|--------|
| [PROJ-123](https://...) | Fix login bug | Bug | Done |
| [PROJ-456](https://...) | Add dark mode | Feature | In Progress |
```

**Comparaison des modes :**

| Mode | Auth requise | Fonctionnalités |
|------|--------------|-----------------|
| Liens uniquement | Non | Génère des clés sous forme de liens cliquables |
| Complet | Oui | Liens + résumé, statut, emojis de type, mises à jour de la version corrigée |

**Sorties Jira :**

```yaml
- name: Use Jira Outputs
  run: |
    echo "Issues: ${{ steps.approval.outputs.jira_issues }}"
    # Output: PROJ-123,PROJ-456

    echo "Details: ${{ steps.approval.outputs.jira_issues_json }}"
    # Output: [{"key":"PROJ-123","summary":"Fix login bug",...}]
```

### Suivi du déploiement

Créez des déploiements GitHub pour la visibilité dans le tableau de bord de déploiement de GitHub. Cela fonctionne indépendamment de la clé `environment:` dans le YAML du workflow.

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  id: approval
  with:
    action: request
    workflow: production-deploy
    version: v1.2.0
    token: ${{ secrets.GITHUB_TOKEN }}
    # Deployment tracking
    create_deployment: 'true'
    deployment_environment: production
    deployment_environment_url: https://myapp.example.com

- name: Update Deployment Status
  if: steps.approval.outputs.status == 'approved'
  run: |
    # Use the deployment_id to update status after actual deployment
    echo "Deployment ID: ${{ steps.approval.outputs.deployment_id }}"
```

**Où les déploiements apparaissent :**

- Onglet **Déploiements** du dépôt
- Badges d’état de l’environnement sur la page du dépôt
- Intégration GitHub pour Jira (si configurée)
- API GitHub pour les outils CI/CD

**Remarque :** Cela crée des déploiements via l’API GitHub Deployments, qui est distincte des règles natives de protection des environnements de GitHub. Vous pouvez utiliser les deux conjointement ou indépendamment.

### Dépôt de configuration externe

Stockez les configurations d’approbation dans un dépôt partagé pour une gestion centralisée des politiques :

```yaml
- uses: jamengual/enterprise-approval-engine@v1
  with:
    action: request
    workflow: production-deploy
    token: ${{ secrets.GITHUB_TOKEN }}
    config_repo: myorg/.github  # Shared config repo
```

**Ordre de résolution de la configuration :**

1. `{repo-name}_approvals.yml` dans le dépôt externe (ex. : `myapp_approvals.yml`)
2. `approvals.yml` dans le dépôt externe (par défaut partagé)
3. `.github/approvals.yml` dans le dépôt actuel (repli local)

**Exemple de structure d’organisation :**

```text
myorg/.github/
├── myapp_approvals.yml      # App-specific config
├── backend_approvals.yml    # Backend repos config
└── approvals.yml            # Default for all repos
```

### Approbations bloquantes

Pour les flux de travail qui doivent attendre une approbation avant de continuer :

```yaml
name: Deploy with Blocking Approval

on:
  workflow_dispatch:
    inputs:
      version:
        required: true
        type: string

jobs:
  request-approval:
    runs-on: ubuntu-latest
    outputs:
      issue_number: ${{ steps.request.outputs.issue_number }}
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: request
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}

  wait-for-approval:
    needs: request-approval
    runs-on: ubuntu-latest
    outputs:
      status: ${{ steps.check.outputs.status }}
      tag: ${{ steps.check.outputs.tag }}
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: check
        with:
          action: check
          issue_number: ${{ needs.request-approval.outputs.issue_number }}
          wait: 'true'           # Poll until approved/denied
          timeout: '4h'          # Max wait time
          token: ${{ secrets.GITHUB_TOKEN }}

  deploy:
    needs: [request-approval, wait-for-approval]
    if: needs.wait-for-approval.outputs.status == 'approved'
    runs-on: ubuntu-latest
    steps:
      - name: Deploy
        run: |
          echo "Deploying ${{ needs.wait-for-approval.outputs.tag }}"
```

**Remarque :** Les workflows bloquants maintiennent le runner actif, ce qui consomme des minutes GitHub Actions. Pour les scénarios sensibles aux coûts, utilisez l’approche basée sur les événements (workflow `process-comment` séparé).

### Suppression des tags à la fermeture d’une issue

Supprimez éventuellement les tags lorsque les issues d’approbation sont fermées manuellement :

```yaml
workflows:
  dev-deploy:
    on_closed:
      delete_tag: true   # Delete tag when issue is closed
      comment: "Cancelled. Tag {{tag}} deleted."

  production-deploy:
    on_closed:
      delete_tag: false  # NEVER delete production tags
```

**Gérer les événements de fermeture :**

```yaml
# .github/workflows/handle-close.yml
name: Handle Issue Close

on:
  issues:
    types: [closed]

jobs:
  handle:
    if: contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      - uses: jamengual/enterprise-approval-engine@v1
        id: close
        with:
          action: close-issue
          issue_number: ${{ github.event.issue.number }}
          issue_action: ${{ github.event.action }}
          token: ${{ secrets.GITHUB_TOKEN }}

      - name: Report
        run: |
          echo "Status: ${{ steps.close.outputs.status }}"
          echo "Deleted tag: ${{ steps.close.outputs.tag_deleted }}"
```

---

## Complete Examples

### Full-Featured Request Workflow

```yaml
name: Request Production Deployment

on:
  workflow_dispatch:
    inputs:
      version:
        description: 'Version to deploy'
        required: true
        type: string
      environment:
        description: 'Target environment'
        required: true
        type: choice
        options: [staging, production]

permissions:
  contents: write
  issues: write
  deployments: write

jobs:
  request:
    runs-on: ubuntu-latest
    outputs:
      issue_number: ${{ steps.approval.outputs.issue_number }}
      issue_url: ${{ steps.approval.outputs.issue_url }}
      deployment_id: ${{ steps.approval.outputs.deployment_id }}
      jira_issues: ${{ steps.approval.outputs.jira_issues }}
    steps:
      - uses: actions/checkout@v4
        with:
          fetch-depth: 0  # Needed for commit comparison

      - uses: jamengual/enterprise-approval-engine@v1
        id: approval
        with:
          action: request
          workflow: ${{ inputs.environment }}-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}
          # Jira integration
          jira_base_url: https://mycompany.atlassian.net
          jira_user_email: ${{ secrets.JIRA_EMAIL }}
          jira_api_token: ${{ secrets.JIRA_API_TOKEN }}
          # Deployment tracking
          create_deployment: 'true'
          deployment_environment: ${{ inputs.environment }}
          deployment_environment_url: https://${{ inputs.environment }}.myapp.com

      - name: Summary
        run: |
          echo "## Approval Request Created" >> $GITHUB_STEP_SUMMARY
          echo "" >> $GITHUB_STEP_SUMMARY
          echo "- **Issue:** #${{ steps.approval.outputs.issue_number }}" >> $GITHUB_STEP_SUMMARY
          echo "- **URL:** ${{ steps.approval.outputs.issue_url }}" >> $GITHUB_STEP_SUMMARY
          echo "- **Jira Issues:** ${{ steps.approval.outputs.jira_issues }}" >> $GITHUB_STEP_SUMMARY
          echo "- **Commits:** ${{ steps.approval.outputs.commits_count }}" >> $GITHUB_STEP_SUMMARY
```

### Traiter les commentaires avec le support de l'équipe

```yaml
name: Handle Approval Comments

on:
  issue_comment:
    types: [created]

permissions:
  contents: write
  issues: write

jobs:
  process:
    if: |
      github.event.issue.pull_request == null &&
      contains(github.event.issue.labels.*.name, 'approval-required')
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4

      # Generate GitHub App token for team membership checks
      - uses: actions/create-github-app-token@v2
        id: app-token
        with:
          app-id: ${{ vars.APP_ID }}
          private-key: ${{ secrets.APP_PRIVATE_KEY }}

      - uses: jamengual/enterprise-approval-engine@v1
        id: process
        with:
          action: process-comment
          issue_number: ${{ github.event.issue.number }}
          token: ${{ steps.app-token.outputs.token }}
          # Jira integration to update Fix Version on approval
          jira_base_url: https://mycompany.atlassian.net
          jira_user_email: ${{ secrets.JIRA_EMAIL }}
          jira_api_token: ${{ secrets.JIRA_API_TOKEN }}

      - name: Trigger Deployment
        if: steps.process.outputs.status == 'approved'
        uses: actions/github-script@v7
        with:
          script: |
            await github.rest.actions.createWorkflowDispatch({
              owner: context.repo.owner,
              repo: context.repo.repo,
              workflow_id: 'deploy.yml',
              ref: 'main',
              inputs: { version: '${{ steps.process.outputs.tag }}' }
            });
```
### Promotion Multi-Environnement


```yaml
# .github/approvals.yml
version: 1

policies:
  dev-team:
    approvers: [dev1, dev2, dev3]
    min_approvals: 1

  qa-team:
    approvers: [qa1, qa2]
    min_approvals: 1

  prod-team:
    approvers: [team:sre, tech-lead]
    min_approvals: 2

workflows:
  dev-deploy:
    require:
      - policy: dev-team
    on_approved:
      tagging:
        enabled: true
        auto_increment: patch
        env_prefix: "dev-"
      close_issue: true

  staging-deploy:
    require:
      - policy: qa-team
    on_approved:
      tagging:
        enabled: true
        auto_increment: minor
        env_prefix: "staging-"
      close_issue: true

  production-deploy:
    require:
      - policy: prod-team
    on_approved:
      create_tag: true
      close_issue: true
    on_closed:
      delete_tag: false  # Never delete production tags
```

### Utilisation des sorties dans les tâches suivantes

```yaml
name: Deploy with Approval

on:
  workflow_dispatch:
    inputs:
      version:
        required: true

jobs:
  approval:
    runs-on: ubuntu-latest
    outputs:
      status: ${{ steps.check.outputs.status }}
      tag: ${{ steps.check.outputs.tag }}
      approvers: ${{ steps.check.outputs.approvers }}
      jira_issues: ${{ steps.request.outputs.jira_issues }}
    steps:
      - uses: actions/checkout@v4

      - uses: jamengual/enterprise-approval-engine@v1
        id: request
        with:
          action: request
          workflow: production-deploy
          version: ${{ inputs.version }}
          token: ${{ secrets.GITHUB_TOKEN }}
          jira_base_url: https://mycompany.atlassian.net

      - uses: jamengual/enterprise-approval-engine@v1
        id: check
        with:
          action: check
          issue_number: ${{ steps.request.outputs.issue_number }}
          wait: 'true'
          timeout: '2h'
          token: ${{ secrets.GITHUB_TOKEN }}

  deploy:
    needs: approval
    if: needs.approval.outputs.status == 'approved'
    runs-on: ubuntu-latest
    environment: production
    steps:
      - name: Deploy
        run: |
          echo "Deploying ${{ needs.approval.outputs.tag }}"
          echo "Approved by: ${{ needs.approval.outputs.approvers }}"
          echo "Jira Issues: ${{ needs.approval.outputs.jira_issues }}"

  notify:
    needs: [approval, deploy]
    if: always()
    runs-on: ubuntu-latest
    steps:
      - name: Notify Slack
        run: |
          if [ "${{ needs.approval.outputs.status }}" == "approved" ]; then
            echo "Deployment of ${{ needs.approval.outputs.tag }} completed!"
          else
            echo "Deployment was ${{ needs.approval.outputs.status }}"
          fi
```

---

## Schema Validation

Validate your configuration using the JSON schema:

```yaml
# .github/approvals.yml
# yaml-language-server: $schema=https://raw.githubusercontent.com/jamengual/enterprise-approval-engine/main/schema.json

version: 1

policies:
  # ... your config
```
Ou valider dans CI :


```yaml
- name: Validate Config
  run: |
    npm install -g ajv-cli
    ajv validate -s schema.json -d .github/approvals.yml
```

---

## GitHub Enterprise Server

L'action prend en charge pleinement GitHub Enterprise Server. Elle détecte automatiquement les environnements GHES en utilisant les variables d'environnement `GITHUB_SERVER_URL` et `GITHUB_API_URL`.

Aucune configuration supplémentaire n'est requise - l'action utilisera automatiquement les points d'accès API corrects.

**Limitation de débit :**

L'action inclut une réessai automatique avec un recul exponentiel pour les erreurs de limitation de débit. Configuration :

- Délai initial : 1 seconde
- Délai max : 60 secondes
- Nombre maximal de tentatives : 5
- Jitter : 0-500ms aléatoire ajouté pour éviter l'effet de masse

---

## Licence

Licence MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---