# Serveur MCP Raindrop.io

[![smithery badge](https://smithery.ai/badge/@adeze/raindrop-mcp)](https://smithery.ai/server/@adeze/raindrop-mcp)
[![npm version](https://badge.fury.io/js/%40adeze%2Fraindrop-mcp.svg)](https://www.npmjs.com/package/@adeze/raindrop-mcp)
[![Claude Desktop MCPB](https://img.shields.io/badge/Claude%20Desktop-MCPB-5B61FF?logo=claude&logoColor=white)](https://github.com/adeze/raindrop-mcp/releases)

Connectez Raindrop.io à votre assistant IA avec un serveur MCP simple. Utilisez-le pour organiser, rechercher et gérer vos favoris en langage naturel.

## Ce qu’il peut faire

- Créer, mettre à jour et supprimer des collections et des favoris
- Rechercher des favoris par tags, domaine, type, date, et plus encore
- Gérer les tags (lister, renommer, fusionner, supprimer)
- Lire les surlignages des favoris
- Modifier en masse les favoris d’une collection
- Auditer les liens cassés et les doublons, et gérer la corbeille

## Outils

- **diagnostics** - Informations de diagnostic serveur et métriques de santé de la bibliothèque
- **collection_list** - Lister toutes les collections sous forme de liste plate
- **get_collection_tree** - Vue hiérarchique des collections avec chemins complets en fil d’Ariane
- **collection_manage** - Créer, mettre à jour ou supprimer des collections
- **bookmark_search** - Recherche avancée avec filtres, tags et pagination
- **bookmark_manage** - Créer, mettre à jour ou supprimer des favoris
- **get_raindrop** - Récupérer un favori unique par ID
- **list_raindrops** - Lister les favoris d’une collection avec pagination
- **get_suggestions** - Conseils d’organisation alimentés par IA (tags/collections) pour une URL ou un favori
- **suggest_tags** - Suggérer des tags pertinents à partir des métadonnées du favori via une analyse assistée par IA
- **bulk_edit_raindrops** - Mise à jour, déplacement ou suppression en masse des favoris dans une collection spécifique
- **tag_manage** - Renommer, fusionner ou supprimer des tags
- **highlight_manage** - Créer, mettre à jour ou supprimer des surlignages
- **library_audit** - Scanner la bibliothèque pour liens cassés, doublons et éléments non tagués
- **empty_trash** - Vider définitivement la corbeille (confirmation requise)
- **cleanup_collections** - Supprimer les collections vides (confirmation requise)
- **remove_duplicates** - Trouver et supprimer les favoris en double avec un processus de confirmation sécurisé

## Installation

### Démarrage rapide (Commandes en une ligne)
| Outil              | Commande en une ligne                                             |
| :----------------- | :---------------------------------------------------------------- |
| **Gemini CLI**     | `gemini extensions install https://github.com/adeze/raindrop-mcp` |
| **Codex CLI**      | `codex mcp add raindrop -- npx -y @adeze/raindrop-mcp`            |
| **Claude Code**    | `claude mcp add raindrop -- npx -y @adeze/raindrop-mcp`           |
| **GitHub Copilot** | `gh copilot config mcp add raindrop -- npx -y @adeze/raindrop-mcp`|
| **Vercel Skills**  | `npx skills add adeze/raindrop-mcp`                               |

> **Note** : Pour les outils ajoutant un serveur MCP via `npx`, vous devez avoir la variable d’environnement `RAINDROP_ACCESS_TOKEN` définie dans votre shell ou dans la configuration d’environnement de l’outil.

### Vercel Skills (npx skills)

Ce projet est compatible avec le système [Vercel Skills](https://github.com/vercel/skills). Tous les manifests nécessaires sont présents :

- `manifest.json` : Manifest MCP standard pour la définition du serveur.
- `SKILL.md` : Description standardisée de la compétence pour la découverte par les agents.
- `mcp.json` : Configuration racine pour les clients et registres MCP.

Pour ajouter ce serveur à votre répertoire local de compétences :


```bash
npx skills add adeze/raindrop-mcp --global
```
Pour contribuer à ce [Registre des Compétences Vercel](https://github.com/vercel/skills/tree/main/registry), soumettez une Pull Request ajoutant l’URL de ce dépôt au registre.

### Claude Desktop (MCPB)

Téléchargez le dernier raindrop-mcp.mcpb depuis la Release GitHub et ajoutez-le à Claude Desktop :

- Releases : https://github.com/adeze/raindrop-mcp/releases

Dans Claude Desktop, ajoutez le bundle et définissez cette variable d’environnement :

- RAINDROP_ACCESS_TOKEN (depuis les paramètres d’intégration de Raindrop.io)

### NPX (CLI)

Définissez votre token API en variable d’environnement et lancez :


```bash
export RAINDROP_ACCESS_TOKEN=YOUR_RAINDROP_ACCESS_TOKEN
npx @adeze/raindrop-mcp
```

### Configuration manuelle MCP (mcp.json)

Ajoutez ceci à la configuration de votre client MCP :

```json
{
  "servers": {
    "raindrop": {
      "type": "stdio",
      "command": "npx",
      "args": ["@adeze/raindrop-mcp@latest"],
      "env": {
        "RAINDROP_ACCESS_TOKEN": "YOUR_RAINDROP_ACCESS_TOKEN"
      }
    }
  }
}
```

## Exigences

- Un compte Raindrop.io
- Un jeton d'accès API Raindrop.io : https://app.raindrop.io/settings/integrations

## Support

- Problèmes : https://github.com/adeze/raindrop-mcp/issues

## Publication

Ce dépôt utilise `semantic-release` comme seul processus de publication supporté.

### Fonctionnement de la publication

- Les publications sont déclenchées par des pushs sur `master` via `.github/workflows/ci.yml`.
- `semantic-release` analyse les messages Conventional Commit, calcule la prochaine version, met à jour `CHANGELOG.md`, crée les tags/releases sur GitHub, et publie sur npm.
- Pendant la préparation de la publication, `.releaserc.json` synchronise `manifest.json`, `mcp.json` et `gemini-extension.json`, puis construit `raindrop-mcp.mcpb` afin que la Release GitHub inclue le bundle.

### Simulation de pré-publication

- Exécutez `.github/workflows/release-dry-run.yml` avec **Run workflow** avant de faire une publication publique.
- Cela valide le calcul de la version sémantique, l'authentification au registre, et le comportement du pipeline de publication sans publier.

### Secrets requis

- `GITHUB_TOKEN` est fourni par GitHub Actions pour l'automatisation des publications.

### Publication npm de confiance

- La publication npm est configurée via la publication de confiance OIDC GitHub Actions.
- `NPM_TOKEN` n'est pas requis pour le chemin standard de publication CI.

### Validation locale avant fusion

```bash
bun run lint
bun run type-check
bun run test
bun run build
```

### Exemples de messages de commit

- `fix: gérer la charge utile de fusion de tag vide`
- `feat: ajouter un filtre de chemin de collection`
- `feat!: suppression du paramètre de recherche obsolète`

Ne pas augmenter manuellement les versions, pousser les tags de release ou exécuter des commandes npm publish manuelles pour les releases normales.

## 📋 Améliorations récentes (v2.4.x)

### Organisation intelligente & hiérarchie

- **Suggestions IA** : Nouvel outil `get_suggestions` fournissant des conseils organisationnels via l'API Raindrop et l'échantillonnage MCP.
- **Arbre de collection** : Outil `get_collection_tree` offrant une vue hiérarchique avec chemins complets en fil d’Ariane.
- **Déplacement en masse** : Ajout de l’opération `move` à `bulk_edit_raindrops` pour une organisation efficace de la bibliothèque.
- **Support de pagination** : Standardisation de `list_raindrops` et `bookmark_search` avec pagination pour les grandes bibliothèques.

### Sécurité & qualité

- **Logique de confirmation** : Les outils destructeurs (`empty_trash`, `cleanup_collections`) requièrent désormais une confirmation explicite.
- **Nommage standardisé** : Tous les outils utilisent désormais une convention de nommage en snake_case cohérente.
- **Pipeline CI/CD** : Amélioration des GitHub Actions avec linting automatique, vérification de types et tests inter-transports.
- **Qualité du code** : Mise en place de configurations ESLint et Prettier pour un développement maintenable.

## 📋 Améliorations précédentes (v2.3.3)

### Nettoyage avancé & audit de bibliothèque

## 📋 Améliorations précédentes (v2.3.2)

### Implémentation des liens de ressources MCP

- Contenu `resource` moderne suivant les meilleures pratiques actuelles du SDK MCP
- Accès aux données efficace : les outils renvoient des liens légers au lieu des charges complètes
- Meilleure performance : les clients récupèrent les données complètes des bookmarks/collections uniquement si nécessaire
- Intégration fluide avec le système dynamique de ressources (`mcp://raindrop/{id}`)

### Mises à jour SDK & API

- Mise à jour vers le dernier SDK MCP supporté dans ce dépôt
- Enregistrement moderne des outils avec descriptions améliorées
- Correction des points d’API et des paramètres de chemin
- Tous les outils principaux pleinement fonctionnels

### Optimisation des outils

- Réponses économes en ressources pour les listes de favoris/collections
- Accès dynamique aux ressources via `mcp://collection/{id}` et `mcp://raindrop/{id}`
- Meilleure expérience client avec des charges utiles de liste allégées
- Conformité totale MCP avec les modèles officiels du SDK

### Améliorations de la couche service

- Réduction du code grâce à l’extraction d’aides communes
- Gestion cohérente des erreurs et traitement des réponses
- Sécurité de type renforcée avec des gestionnaires génériques
- Construction centralisée des points d’accès

### Améliorations des tests

- Couverture end-to-end renforcée pour l’exécution des outils MCP
- Tests d’intégration étendus pour les flux clients réels

### Préparation MCP 2.0 (Opérations en masse)

- Mise en place des bases pour les flux et outils d’opérations en masse MCP 2.0

### OAuth (Bientôt disponible)

- Flux d’authentification basé sur OAuth pour simplifier la configuration sans tokens manuels

### Note

Nous nous excusons auprès de ceux affectés par les dernières versions. Merci pour votre patience et vos rapports.

## Licence

Ce projet est sous licence MIT - voir le fichier [LICENSE](LICENSE) pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---