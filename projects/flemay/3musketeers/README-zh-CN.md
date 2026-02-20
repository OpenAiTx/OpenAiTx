# 3 Musketeers

<div align="center">
<img src="https://raw.githubusercontent.com/flemay/3musketeers/main/src/assets/logo/hero-v2.svg" width="300">

**从任何地方测试、构建并部署您的应用，方式一致！**

[![构建状态][linkGitHubActionsProjectBadge]][linkGitHubActionsProject]
[![许可证][linkLicenseBadge]][linkLicense]

</div>

<details>
  <summary>目录</summary>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [概述](#overview)
- [3 Musketeers 网站](#3-musketeers-website)
  - [先决条件](#prerequisites)
  - [开发](#development)
  - [部署](#deployment)
    - [0. Cloudflare 账户 ID 和 API 令牌](#0-cloudflare-account-id-and-api-token)
    - [1. 环境文件](#1-envfile)
    - [2. 创建](#2-create)
    - [3. 部署](#3-deploy)
    - [4. 删除](#4-delete)
  - [CI/CD](#cicd)
  - [视觉元素](#visual-elements)
- [贡献](#contributing)
- [许可证](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

</details>

## 概述

<!-- Part of src/content/docs/about/what-is-3musketeers.md -->
三剑客是一种以可重复和一致的方式开发软件的模式。它利用 Make 作为编排工具，使用 Docker 和 Docker Compose 来测试、构建、运行和部署应用程序。每个应用程序的 Make 和 Docker/Compose 命令作为应用程序源代码的一部分进行维护，无论是在本地运行还是在 CI/CD 服务器上运行，调用方式均相同。

> [!注意]
> 欲了解更多信息，请访问 [官方网站][link3Musketeers]。

## 三剑客网站

此仓库是使用 [Astro Starlight][linkAstroStarlight] 构建的 [三剑客网站][link3Musketeers]。本节说明如何使用三剑客方法进行开发、测试和部署。

### 先决条件

- [Docker](https://www.docker.com/)
- [Compose](https://docs.docker.com/compose/)
- [Make](https://www.gnu.org/software/make/)
- [Cloudflare][linkCloudflarePages] 账户

### 开发









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

### 部署

3 Musketeers 网站部署在 [Cloudflare Pages][linkCloudflarePages]。
本节展示如何使用
[Wrangler CLI][linkCloudflareWranglerCLI] 创建、部署和删除 Pages 项目。
这对于预览新更改非常方便。

鉴于构建、测试和部署将通过 GitHub Actions 完成，
本节遵循 [Direct Upload][linkCloudflareDirectUpload] 和
[Run Wrangler in CI/CD][linkCloudflareWranglerCICD] 指南。

> [!NOTE]
> 本节要求静态站点已通过
> `make build` 生成

#### 0. Cloudflare 账户 ID 和 API 令牌

要使用 Wrangler CLI 与 Cloudflare Pages 交互，需要 Cloudflare 账户 ID 和
API 令牌。

1. 账户 ID: [查找账户和区域 ID][linkCloudflareFindAccountAndZoneIDs]
1. API 令牌
   1. [创建 API 令牌][linkCloudflareCreateAPIToken]
   1. 使用 `Edit Cloudflare Workers` 模板
   1. 更新 `令牌名称`
   1. 权限：
      1. 账户 - Cloudflare Pages - 编辑
      1. 删除其他权限
   1. 包含你的账户
   1. 设置短期有效的 TTL
   1. 点击 `继续到摘要`
1. 这些值将在以下章节 `1. Envfile` 中使用

#### 1. Envfile

以下章节使用文件 `.env` 中的值。基于 `env.template` 创建 `.env`
文件，并填写正确的值。

示例：

```bash
# .env
ENV_CLOUDFLARE_BRANCH_NAME=main
ENV_CLOUDFLARE_PROJECT_NAME=random-project-name
ENV_SECRET_CLOUDFLARE_ACCOUNT_ID=id-from-previous-section
ENV_SECRET_CLOUDFLARE_API_TOKEN=token-from-previous-section
```
验证：


```bash
make shell
# Check the env vars are correctly set
env | grep ENV_
# List current projects on CloudFlare
deno task deploy:list
exit
```

#### 2. 创建

本节创建一个新的 Pages 项目。仅当
`ENV_CLOUDFLARE_PROJECT_NAME` 未在步骤 `1. Envfile` 中列出时，才需要此步骤。

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

#### 3. 部署

本节将网站部署到现有的 Cloudflare Pages 项目中。

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

注意：也可以使用 `make deploy`。

#### 4. 删除

本节展示如何删除 Cloudflare Pages 项目。

```bash
make shell
deno task deploy:delete
#? Are you sure you want to delete "<ENV_CLOUDFLARE_PROJECT_NAME>"? This action cannot be undone. › y
# Check the project is no longer listed
deno task deploy:list
exit
```

> [!重要]
> 在章节
> `0. Cloudflare 账户 ID 和 API 令牌` 中创建的 CloudFlare 令牌可以删除

### CI/CD

[GitHub Actions][linkGitHubActions] 用于测试 PR 并将对 `main` 分支的更改部署到 Cloudflare Pages。

- 为 Github Actions 创建了专用的 Cloudflare API 令牌
- 部署到 Cloudflare Pages 所需的环境变量已在 GitHub Actions 中设置为
  [变量][linkGitHubActionsVariables] 和
  [密钥][linkGitHubActionsSecrets]
- GitHub Actions 工作流遵循三剑客模式

### 视觉元素

- 三剑客标志
  - 由我使用 [Procreate][linkProcreate] 和 Vectornator 制作
    - 使用的巧妙工具有 `offset path` 和 `mask objects`
  - 2048px x 2048px SVG 图像
  - 图像位于文件夹 `./src/assets/logo/`
- 网站图标
  - 源图像是标志导出的 png 格式
  - 使用网站 [favicon.io][linkFaviconio]
  - 生成的内容位于 `./public/favicon_io`
  - 将 HTML `<link>` 标签复制到 `<head>` 的说明已设置在
    `./astro.config.mjs`
- 社交媒体预览
  - 用于在 Twitter、Facebook、GitHub 等显示网站预览
  - 创建了一个新的 1280x640px 矢量图像，中心为缩小的标志
    - 大小由 GitHub 常规设置建议
  - 根据 [artegence 文章][linkArtegenceArticle]，适用于不同社交平台的理想图像
    - 尺寸为 1200x630px
    - 标志（630x630）居中
    - 使用 png 格式（非常高质量且支持透明）
    - 使用 jpg 格式（高质量且压缩效果很好）



  - 社交图像也在仓库的一般设置中设置
  - Astro Starlight 设置了 `<head>` 部分的所有 `<meta>` 标签
- 图表
  - 使用 [Mermaid][linkMermaid] 生成图表
  - 所有图表都位于目录 [diagrams](diagrams)
- [demo][linkDemo] 由 [charmbracelet/vhs][linkVHS] 生成

## 贡献

[CONTRIBUTING.md](https://raw.githubusercontent.com/flemay/3musketeers/main/CONTRIBUTING.md)

感谢 [contributors][linkContributors] 的贡献。

## 许可证

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