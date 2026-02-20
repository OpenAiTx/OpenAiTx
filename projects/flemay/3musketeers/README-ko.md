# 3 Musketeers

<div align="center">
<img src="https://raw.githubusercontent.com/flemay/3musketeers/main/src/assets/logo/hero-v2.svg" width="300">

**어디서나 동일한 방식으로 앱을 테스트, 빌드 및 배포하세요!**

[![Build Status][linkGitHubActionsProjectBadge]][linkGitHubActionsProject]
[![License][linkLicenseBadge]][linkLicense]

</div>

<details>
  <summary>목차</summary>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [개요](#overview)
- [3 Musketeers 웹사이트](#3-musketeers-website)
  - [필수 조건](#prerequisites)
  - [개발](#development)
  - [배포](#deployment)
    - [0. Cloudflare 계정 ID 및 API 토큰](#0-cloudflare-account-id-and-api-token)
    - [1. Envfile](#1-envfile)
    - [2. 생성](#2-create)
    - [3. 배포](#3-deploy)
    - [4. 삭제](#4-delete)
  - [CI/CD](#cicd)
  - [시각적 요소](#visual-elements)
- [기여하기](#contributing)
- [라이선스](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

</details>

## 개요

<!-- Part of src/content/docs/about/what-is-3musketeers.md -->
3 무스케티어는 반복적이고 일관된 방식으로 소프트웨어를 개발하기 위한 패턴입니다.  
이는 Make를 오케스트레이션 도구로 활용하여 Docker 및 Docker Compose를 사용해 애플리케이션을 테스트, 빌드, 실행, 배포합니다.  
각 애플리케이션의 Make 및 Docker/Compose 명령은 애플리케이션 소스 코드의 일부로 유지되며, 로컬에서 실행하든  
CI/CD 서버에서 실행하든 동일한 방식으로 호출됩니다.  

> [!NOTE]  
> 자세한 내용을 보려면 [공식 웹사이트][link3Musketeers]를 방문하십시오.  

## 3 무스케티어 웹사이트  

이 저장소는 [Astro Starlight][linkAstroStarlight]로 구축된 [3 무스케티어 웹사이트][link3Musketeers]입니다.  
이 섹션에서는 3 무스케티어 방법론을 사용하여 개발, 테스트 및 배포하는 방법을 설명합니다.  

### 사전 준비 사항  

- [Docker](https://www.docker.com/)  
- [Compose](https://docs.docker.com/compose/)  
- [Make](https://www.gnu.org/software/make/)  
- [Cloudflare][linkCloudflarePages] 계정  

### 개발  





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
### 배포

3 Musketeers 웹사이트는 [Cloudflare Pages][linkCloudflarePages]에 배포됩니다.  
이 섹션에서는 [Wrangler CLI][linkCloudflareWranglerCLI]를 사용하여  
Pages 프로젝트를 생성, 배포 및 삭제하는 방법을 보여줍니다.  
이는 새로운 변경 사항을 미리보기할 때 유용합니다.

빌드, 테스트 및 배포가 GitHub Actions로 수행될 예정이므로,  
이 섹션은 [Direct Upload][linkCloudflareDirectUpload] 및  
[Run Wrangler in CI/CD][linkCloudflareWranglerCICD] 지침을 따릅니다.

> [!NOTE]  
> 이 섹션은 정적 사이트가  
> `make build`로 생성된 상태여야 합니다.

#### 0. Cloudflare 계정 ID 및 API 토큰

Wrangler CLI로 Cloudflare Pages와 상호작용하려면, Cloudflare 계정 ID와  
API 토큰이 필요합니다.

1. 계정 ID: [계정 및 존 ID 찾기][linkCloudflareFindAccountAndZoneIDs]  
1. API 토큰  
   1. [API 토큰 생성][linkCloudflareCreateAPIToken]  
   1. `Edit Cloudflare Workers` 템플릿 사용  
   1. `토큰 이름` 업데이트  
   1. 권한:  
      1. 계정 - Cloudflare Pages - 편집  
      1. 다른 권한 제거  
   1. 자신의 계정 포함  
   1. 단기 TTL 설정  
   1. `요약으로 계속` 클릭  
1. 이 값들은 다음 섹션 `1. Envfile`에서 사용됩니다.

#### 1. Envfile

다음 섹션들은 `.env` 파일의 값을 사용합니다.  
올바른 값으로 `.env` 파일을 생성하세요 (`env.template` 기반).

예시:


```bash
# .env
ENV_CLOUDFLARE_BRANCH_NAME=main
ENV_CLOUDFLARE_PROJECT_NAME=random-project-name
ENV_SECRET_CLOUDFLARE_ACCOUNT_ID=id-from-previous-section
ENV_SECRET_CLOUDFLARE_API_TOKEN=token-from-previous-section
```

확인:

```bash
make shell
# Check the env vars are correctly set
env | grep ENV_
# List current projects on CloudFlare
deno task deploy:list
exit
```
#### 2. 생성

이 섹션에서는 새 Pages 프로젝트를 생성합니다. 이 단계는
`ENV_CLOUDFLARE_PROJECT_NAME`이 1단계 `1. Envfile`에 나열되지 않은 경우에만 필요합니다.


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

#### 3. 배포

이 섹션에서는 기존 Cloudflare Pages 프로젝트에 웹사이트를 배포합니다.

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

참고: `make deploy` 명령도 사용할 수 있습니다.

#### 4. 삭제

이 섹션에서는 Cloudflare Pages 프로젝트를 삭제하는 방법을 보여줍니다.

```bash
make shell
deno task deploy:delete
#? Are you sure you want to delete "<ENV_CLOUDFLARE_PROJECT_NAME>"? This action cannot be undone. › y
# Check the project is no longer listed
deno task deploy:list
exit
```

> [!IMPORTANT]
> 섹션 `0. Cloudflare 계정 ID 및 API 토큰`에서 생성된 CloudFlare 토큰은 삭제할 수 있습니다.

### CI/CD

[GitHub Actions][linkGitHubActions]는 PR을 테스트하고  
`main` 브랜치에 적용된 변경사항을 Cloudflare Pages에 배포하는 데 사용됩니다.

- Github Actions 전용 Cloudflare API 토큰이 생성되었습니다.
- Cloudflare Pages 배포에 필요한 환경 변수는  
  GitHub Actions의 [variables][linkGitHubActionsVariables] 및  
  [secrets][linkGitHubActionsSecrets]에 설정되어 있습니다.
- GitHub Actions 워크플로우는 3 Musketeers 패턴을 따릅니다.

### 시각 요소

- 3 Musketeers 로고
  - [Procreate][linkProcreate]와 Vectornator로 제가 직접 제작  
    - 사용한 주요 도구는 `offset path`와 `mask objects`입니다.
  - 2048px x 2048px 크기의 SVG 이미지
  - 이미지는 `./src/assets/logo/` 폴더에 있습니다.
- 파비콘
  - 소스 이미지는 로고를 png 형식으로 내보낸 것입니다.
  - 웹사이트 [favicon.io][linkFaviconio]를 사용합니다.
  - 생성된 파일은 `./public/favicon_io`에 위치합니다.
  - `<head>`에 HTML `<link>` 태그를 복사하는 방법은  
    `./astro.config.mjs`에 설정되어 있습니다.
- 소셜 미디어 미리보기
  - 트위터, 페이스북, GitHub 등에서 웹사이트 미리보기를 표시하기 위한 것입니다.
  - 중앙에 축소된 로고가 있는 1280x640px 크기의 새 벡터 이미지를 제작했습니다.
    - 이 크기는 GitHub 일반 설정에서 권장하는 크기입니다.
  - [artegence 기사][linkArtegenceArticle]에 따르면, 다양한 소셜 플랫폼에서  
    최적의 이미지는 다음과 같습니다.
    - 1200x630px 크기
    - 중앙에 로고(630x630) 배치
    - png 형식 사용 (매우 높은 품질과 투명도)
    - jpg 형식 사용 (높은 품질과 매우 좋은 크기 압축)


  - 소셜 이미지는 저장소의 일반 설정에서 설정됩니다
  - Astro Starlight는 `<head>` 섹션의 모든 `<meta>` 태그를 설정합니다
- 다이어그램
  - 다이어그램 생성에 [Mermaid][linkMermaid]가 사용됩니다
  - 모든 다이어그램은 [diagrams](diagrams) 디렉토리에 있습니다
- [demo][linkDemo]는 [charmbracelet/vhs][linkVHS]에 의해 생성되었습니다

## 기여하기

[CONTRIBUTING.md](https://raw.githubusercontent.com/flemay/3musketeers/main/CONTRIBUTING.md)

감사의 뜻을 [contributors][linkContributors]에게 전합니다.

## 라이선스

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