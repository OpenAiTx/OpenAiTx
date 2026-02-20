# 3 Musketeers

<div align="center">
<img src="https://raw.githubusercontent.com/flemay/3musketeers/main/src/assets/logo/hero-v2.svg" width="300">

**Test, build, and deploy your apps from anywhere, the same way!**

[![Build Status][linkGitHubActionsProjectBadge]][linkGitHubActionsProject]
[![License][linkLicenseBadge]][linkLicense]

</div>

<details>
  <summary>Table of Contents</summary>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Overview](#overview)
- [3 Musketeers website](#3-musketeers-website)
  - [Prerequisites](#prerequisites)
  - [Development](#development)
  - [Deployment](#deployment)
    - [0. Cloudflare account ID and API token](#0-cloudflare-account-id-and-api-token)
    - [1. Envfile](#1-envfile)
    - [2. Create](#2-create)
    - [3. Deploy](#3-deploy)
    - [4. Delete](#4-delete)
  - [CI/CD](#cicd)
  - [Visual elements](#visual-elements)
- [Contributing](#contributing)
- [License](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

</details>

## Overview

<!-- Part of src/content/docs/about/what-is-3musketeers.md -->

The 3 Musketeers is a pattern for developing software in a repeatable and
consistent manner. It leverages Make as an orchestration tool to test, build,
run, and deploy applications using Docker and Docker Compose. The Make and
Docker/Compose commands for each application are maintained as part of the
application’s source code and are invoked in the same way whether run locally or
on a CI/CD server.

> [!NOTE]
> To learn more, please visit the [official website][link3Musketeers].

## 3 Musketeers website

This repository is the [3 Musketeers website][link3Musketeers] built with
[Astro Starlight][linkAstroStarlight]. This section explains how to develop,
test, and deploy using the 3 Musketeers methodology.

### Prerequisites

- [Docker](https://www.docker.com/)
- [Compose](https://docs.docker.com/compose/)
- [Make](https://www.gnu.org/software/make/)
- [Cloudflare][linkCloudflarePages] account

### Development

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

### Deployment

The 3 Musketeers website is deployed to [Cloudflare Pages][linkCloudflarePages].
This section shows how to create, deploy, and delete a Pages project using
[Wrangler CLI][linkCloudflareWranglerCLI]. This is handy for previewing new
changes.

Given build, test and deployment are going to be done with GitHub Actions, this
section follows the [Direct Upload][linkCloudflareDirectUpload] and
[Run Wrangler in CI/CD][linkCloudflareWranglerCICD] directives.

> [!NOTE]
> This section requires the static site to be have been generated with
> `make build`

#### 0. Cloudflare account ID and API token

To interact with Cloudflare Pages with Wrangler CLI, Cloudflare account ID and
API token are required.

1. Account ID: [Find account and zone IDs][linkCloudflareFindAccountAndZoneIDs]
1. API token
   1. [Create API token][linkCloudflareCreateAPIToken]
   1. Use `Edit Cloudflare Workers` template
   1. Update the `Token name`
   1. Permissions:
      1. Account - Cloudflare Pages - Edit
      1. Remove other permissions
   1. Include your account
   1. Set a short-lived TTL
   1. Click `Continue to summary`
1. These values will be used in the following section `1. Envfile`

#### 1. Envfile

The following sections use the values from the file `.env`. Create file `.env`
(based on `env.template`) with the correct values.

Example:

```bash
# .env
ENV_CLOUDFLARE_BRANCH_NAME=main
ENV_CLOUDFLARE_PROJECT_NAME=random-project-name
ENV_SECRET_CLOUDFLARE_ACCOUNT_ID=id-from-previous-section
ENV_SECRET_CLOUDFLARE_API_TOKEN=token-from-previous-section
```

Verify:

```bash
make shell
# Check the env vars are correctly set
env | grep ENV_
# List current projects on CloudFlare
deno task deploy:list
exit
```

#### 2. Create

This section creates a new Pages project. This step is only needed if
`ENV_CLOUDFLARE_PROJECT_NAME` wasn't listed in step `1. Envfile`.

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

#### 3. Deploy

This section deploys the website to an existing Cloudflare Pages project.

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

Note: `make deploy` can also be used.

#### 4. Delete

This section shows how to delete a Cloudflare Pages project.

```bash
make shell
deno task deploy:delete
#? Are you sure you want to delete "<ENV_CLOUDFLARE_PROJECT_NAME>"? This action cannot be undone. › y
# Check the project is no longer listed
deno task deploy:list
exit
```

> [!IMPORTANT]
> The CloudFlare token created in section
> `0. Cloudflare account ID and API token` can be deleted

### CI/CD

[GitHub Actions][linkGitHubActions] is used to test PRs and deploy changes made
to `main` branch to Cloudflare Pages.

- A dedicated Cloudflare API token has been created for Github Actions
- Environment variables required for deploying to Cloudflare Pages are set as
  [variables][linkGitHubActionsVariables] and
  [secrets][linkGitHubActionsSecrets] in GitHub Actions
- The GitHub Actions workflows follow the 3 Musketeers pattern

### Visual elements

- 3 Musketeers logo
  - Created by me with [Procreate][linkProcreate] and Vectornator
    - Neat tools used are `offset path` and `mask objects`
  - 2048px by 2048px SVG image
  - Images are in folder `./src/assets/logo/`
- Favicon
  - Source image is an exported png format of the logo
  - Use the website [favicon.io][linkFaviconio]
  - The generated content is in `./public/favicon_io`
  - Instructions to copy HTML `<link>` tags into the `<head>` was set in
    `./astro.config.mjs`
- Social media preview
  - This is for displaying preview of the website on Twitter, Facebook, GitHub,
    etc
  - Created a new vector image 1280x640px with the scale down logo at the center
    - The size is suggested by GitHub in General settings
  - According to [artegence article][linkArtegenceArticle], the ideal image that
    works on different social platforms
    - Is 1200x630px
    - Has the logo (630x630) centered
    - Use png format (very high quality and transparency)
    - Use jpg format (high quality and very good size compression)
  - The social image is also set in the general settings of the repository
  - Astro Startlight sets all of the `<meta>` tags in the `<head>` section
- Diagrams
  - [Mermaid][linkMermaid] is used to generate diagrams
  - All diagrams are in the directory [diagrams](diagrams)
- The [demo][linkDemo] was generated by [charmbracelet/vhs][linkVHS]

## Contributing

[CONTRIBUTING.md](https://raw.githubusercontent.com/flemay/3musketeers/main/CONTRIBUTING.md)

Thanks goes to [contributors][linkContributors].

## License

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
