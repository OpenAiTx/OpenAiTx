# 3 Mousquetaires

<div align="center">
<img src="https://raw.githubusercontent.com/flemay/3musketeers/main/src/assets/logo/hero-v2.svg" width="300">

**Testez, construisez et déployez vos applications de n'importe où, de la même manière !**

[![Statut de build][linkGitHubActionsProjectBadge]][linkGitHubActionsProject]
[![Licence][linkLicenseBadge]][linkLicense]

</div>

<details>
  <summary>Table des matières</summary>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Vue d'ensemble](#overview)
- [Site web 3 Mousquetaires](#3-musketeers-website)
  - [Prérequis](#prerequisites)
  - [Développement](#development)
  - [Déploiement](#deployment)
    - [0. ID de compte Cloudflare et jeton API](#0-cloudflare-account-id-and-api-token)
    - [1. Fichier Env](#1-envfile)
    - [2. Créer](#2-create)
    - [3. Déployer](#3-deploy)
    - [4. Supprimer](#4-delete)
  - [CI/CD](#cicd)
  - [Éléments visuels](#visual-elements)
- [Contribution](#contributing)
- [Licence](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

</details>

## Vue d'ensemble

<!-- Part of src/content/docs/about/what-is-3musketeers.md -->
Les 3 Mousquetaires est un modèle pour développer des logiciels de manière répétable et
cohérente. Il utilise Make comme outil d'orchestration pour tester, construire,
exécuter et déployer des applications en utilisant Docker et Docker Compose. Les commandes Make et
Docker/Compose pour chaque application sont maintenues dans le code source
de l’application et sont invoquées de la même manière, que ce soit localement ou
sur un serveur CI/CD.

> [!NOTE]
> Pour en savoir plus, veuillez visiter le [site officiel][link3Musketeers].

## Site web des 3 Mousquetaires

Ce dépôt est le [site web des 3 Mousquetaires][link3Musketeers] construit avec
[Astro Starlight][linkAstroStarlight]. Cette section explique comment développer,
tester et déployer en utilisant la méthodologie des 3 Mousquetaires.

### Prérequis

- [Docker](https://www.docker.com/)
- [Compose](https://docs.docker.com/compose/)
- [Make](https://www.gnu.org/software/make/)
- Compte [Cloudflare][linkCloudflarePages]

### Développement


```bash
# Create a .env file
make envfile ENVFILE=env.example
# Install dependencies
make deps copyDepsToHost

# Format and check
make fmt check

# Start Astro server for local development
make dev
# Wait till the message 'dev-1  | 20:13:41 watching for file changes...' appears
# Access the website in your browser at http://127.0.0.1:4321/
# \<ctrl-c\> to stop

# Build static site
make build

# Serve static site for local development
make previewDev
# Access the website in your browser at http://127.0.0.1:4321/
# \<ctrl-c\> to stop

# Serve static website in the background
make preview

# Test static website
make testPreview

# Clean
make clean
```

### Déploiement

Le site web des 3 Mousquetaires est déployé sur [Cloudflare Pages][linkCloudflarePages].  
Cette section montre comment créer, déployer et supprimer un projet Pages en utilisant  
[Wrangler CLI][linkCloudflareWranglerCLI]. Cela est pratique pour prévisualiser de nouvelles  
modifications.

Étant donné que la construction, les tests et le déploiement vont être réalisés avec GitHub Actions, cette  
section suit les directives [Téléchargement Direct][linkCloudflareDirectUpload] et  
[Exécuter Wrangler en CI/CD][linkCloudflareWranglerCICD].

> [!NOTE]
> Cette section nécessite que le site statique ait été généré avec  
> `make build`

#### 0. Identifiant de compte Cloudflare et jeton API

Pour interagir avec Cloudflare Pages via Wrangler CLI, l’identifiant de compte Cloudflare et  
le jeton API sont nécessaires.

1. Identifiant de compte : [Trouver les identifiants de compte et de zone][linkCloudflareFindAccountAndZoneIDs]  
1. Jeton API  
   1. [Créer un jeton API][linkCloudflareCreateAPIToken]  
   1. Utiliser le modèle `Edit Cloudflare Workers`  
   1. Mettre à jour le `Nom du jeton`  
   1. Permissions :  
      1. Compte - Cloudflare Pages - Modifier  
      1. Supprimer les autres permissions  
   1. Inclure votre compte  
   1. Définir un TTL de courte durée  
   1. Cliquer sur `Continuer vers le résumé`  
1. Ces valeurs seront utilisées dans la section suivante `1. Envfile`

#### 1. Fichier d’environnement

Les sections suivantes utilisent les valeurs du fichier `.env`. Créez le fichier `.env`  
(basé sur `env.template`) avec les valeurs correctes.

Exemple :

```bash
# .env
ENV_CLOUDFLARE_BRANCH_NAME=main
ENV_CLOUDFLARE_PROJECT_NAME=random-project-name
ENV_SECRET_CLOUDFLARE_ACCOUNT_ID=id-from-previous-section
ENV_SECRET_CLOUDFLARE_API_TOKEN=token-from-previous-section
```

Vérifier :

```bash
make shell
# Check the env vars are correctly set
env | grep ENV_
# List current projects on CloudFlare
deno task deploy:list
exit
```

#### 2. Création

Cette section crée un nouveau projet Pages. Cette étape est nécessaire uniquement si
`ENV_CLOUDFLARE_PROJECT_NAME` n'a pas été indiqué dans l'étape `1. Envfile`.

```bash
make shell
# Create a new project
deno task deploy:create
# The new project and its domain should be listed
deno task deploy:list
# Project is empty which should not be hosted
curl -I https://${ENV_CLOUDFLARE_PROJECT_NAME}.pages.dev
#HTTP/2 522
#...
# Exit the container
exit
```

#### 3. Déploiement

Cette section déploie le site web sur un projet Cloudflare Pages existant.

```bash
make shell
# Deploy the files to the project
deno task deploy
# Project is no longer empty!
curl -I https://${ENV_CLOUDFLARE_PROJECT_NAME}.pages.dev
#HTTP/2 200
#...
# Exit the container
exit
```

Note : `make deploy` peut également être utilisé.

#### 4. Suppression

Cette section montre comment supprimer un projet Cloudflare Pages.

```bash
make shell
deno task deploy:delete
#? Are you sure you want to delete "<ENV_CLOUDFLARE_PROJECT_NAME>"? This action cannot be undone. › y
# Check the project is no longer listed
deno task deploy:list
exit
```

> [!IMPORTANT]
> Le token CloudFlare créé dans la section
> `0. Cloudflare account ID and API token` peut être supprimé

### CI/CD

[GitHub Actions][linkGitHubActions] est utilisé pour tester les PRs et déployer les modifications faites
sur la branche `main` vers Cloudflare Pages.

- Un token API Cloudflare dédié a été créé pour Github Actions
- Les variables d'environnement requises pour le déploiement sur Cloudflare Pages sont définies comme
  [variables][linkGitHubActionsVariables] et
  [secrets][linkGitHubActionsSecrets] dans GitHub Actions
- Les workflows GitHub Actions suivent le modèle des 3 Mousquetaires

### Éléments visuels

- Logo des 3 Mousquetaires
  - Créé par moi avec [Procreate][linkProcreate] et Vectornator
    - Les outils précis utilisés sont `offset path` et `mask objects`
  - Image SVG de 2048px par 2048px
  - Les images sont dans le dossier `./src/assets/logo/`
- Favicon
  - L’image source est un png exporté du logo
  - Utilisation du site [favicon.io][linkFaviconio]
  - Le contenu généré est dans `./public/favicon_io`
  - Les instructions pour copier les balises HTML `<link>` dans le `<head>` ont été définies dans
    `./astro.config.mjs`
- Aperçu sur les réseaux sociaux
  - Ceci sert à afficher un aperçu du site sur Twitter, Facebook, GitHub,
    etc.
  - Création d’une nouvelle image vectorielle 1280x640px avec le logo réduit au centre
    - La taille est suggérée par GitHub dans les paramètres généraux
  - Selon l’[article artegence][linkArtegenceArticle], l’image idéale qui
    fonctionne sur différentes plateformes sociales
    - Mesure 1200x630px
    - Contient le logo (630x630) centré
    - Utilise le format png (très haute qualité et transparence)
    - Utilise le format jpg (haute qualité et très bonne compression de taille)
  - L'image sociale est également définie dans les paramètres généraux du dépôt
  - Astro Starlight configure toutes les balises `<meta>` dans la section `<head>`
- Diagrammes
  - [Mermaid][linkMermaid] est utilisé pour générer des diagrammes
  - Tous les diagrammes se trouvent dans le répertoire [diagrams](diagrams)
- La [démo][linkDemo] a été générée par [charmbracelet/vhs][linkVHS]

## Contribution

[CONTRIBUTING.md](https://raw.githubusercontent.com/flemay/3musketeers/main/CONTRIBUTING.md)

Remerciements à [contributeurs][linkContributors].

## Licence

[MIT][linkLicense]

[link3Musketeers]: https://3musketeers.pages.dev
[linkArtegenceArticle]: https://artegence.com/blog/social-media-tags-guide-part-2-preparing-a-perfect-image-for-the-ogimage-tag/
[linkAstroStarlight]: https://starlight.astro.build/
[linkCloudflareCreateAPIToken]: https://dash.cloudflare.com/profile/api-tokens
[linkCloudflareDirectUpload]: https://developers.cloudflare.com/pages/get-started/direct-upload/
[linkCloudflareFindAccountAndZoneIDs]: https://developers.cloudflare.com/fundamentals/setup/find-account-and-zone-ids/
[linkCloudflarePages]: https://pages.cloudflare.com/
[linkCloudflareWranglerCICD]: https://developers.cloudflare.com/workers/wrangler/ci-cd/
[linkCloudflareWranglerCLI]: https://developers.cloudflare.com/workers/wrangler/
[linkCompose]: https://docs.docker.com/compose
[linkContributors]: CONTRIBUTORS
[linkDemo]: demo
[linkDocker]: https://www.docker.com
[linkFaviconio]: https://favicon.io
[linkGitHubActions]: https://github.com/features/actions
[linkGitHubActionsProject]: https://github.com/flemay/3musketeers/actions
[linkGitHubActionsProjectBadge]: https://img.shields.io/github/actions/workflow/status/flemay/3musketeers/deploy.yml?style=for-the-badge&logo=github
[linkGitHubActionsSecrets]: https://docs.github.com/en/actions/security-guides/encrypted-secrets
[linkGitHubActionsVariables]: https://docs.github.com/en/actions/learn-github-actions/variables
[linkLicense]: LICENSE
[linkLicenseBadge]: https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge
[linkMake]: https://www.gnu.org/software/make
[linkMermaid]: https://mermaid.js.org/
[linkPatternOverview]: ./docs/guide/assets/diagrams-overview.svg
[linkProcreate]: https://procreate.art/
[linkVHS]: https://github.com/charmbracelet/vhs


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-20

---