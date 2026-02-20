# 3 Mosqueteros

<div align="center">
<img src="https://raw.githubusercontent.com/flemay/3musketeers/main/src/assets/logo/hero-v2.svg" width="300">

**¡Prueba, construye y despliega tus aplicaciones desde cualquier lugar, de la misma manera!**

[![Estado de la compilación][linkGitHubActionsProjectBadge]][linkGitHubActionsProject]
[![Licencia][linkLicenseBadge]][linkLicense]

</div>

<details>
  <summary>Tabla de Contenidos</summary>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->

- [Resumen](#overview)
- [Sitio web 3 Mosqueteros](#3-musketeers-website)
  - [Requisitos previos](#prerequisites)
  - [Desarrollo](#development)
  - [Despliegue](#deployment)
    - [0. ID de cuenta y token API de Cloudflare](#0-cloudflare-account-id-and-api-token)
    - [1. Archivo Env](#1-envfile)
    - [2. Crear](#2-create)
    - [3. Desplegar](#3-deploy)
    - [4. Eliminar](#4-delete)
  - [CI/CD](#cicd)
  - [Elementos visuales](#visual-elements)
- [Contribuciones](#contributing)
- [Licencia](#license)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

</details>

## Resumen

<!-- Part of src/content/docs/about/what-is-3musketeers.md -->
Los 3 Mosqueteros es un patrón para desarrollar software de manera repetible y
consistente. Aprovecha Make como una herramienta de orquestación para probar, construir,
ejecutar y desplegar aplicaciones usando Docker y Docker Compose. Los comandos de Make y
Docker/Compose para cada aplicación se mantienen como parte del código fuente de la
aplicación y se invocan de la misma manera, ya sea que se ejecuten localmente o
en un servidor CI/CD.

> [!NOTA]
> Para obtener más información, por favor visite el [sitio web oficial][link3Musketeers].

## Sitio web de los 3 Mosqueteros

Este repositorio es el [sitio web de los 3 Mosqueteros][link3Musketeers] construido con
[Astro Starlight][linkAstroStarlight]. Esta sección explica cómo desarrollar,
probar y desplegar usando la metodología de los 3 Mosqueteros.

### Requisitos previos

- [Docker](https://www.docker.com/)
- [Compose](https://docs.docker.com/compose/)
- [Make](https://www.gnu.org/software/make/)
- Cuenta de [Cloudflare][linkCloudflarePages]

### Desarrollo


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
### Despliegue

El sitio web de los 3 Mosqueteros se despliega en [Cloudflare Pages][linkCloudflarePages].
Esta sección muestra cómo crear, desplegar y eliminar un proyecto de Pages usando
[Wrangler CLI][linkCloudflareWranglerCLI]. Esto es útil para previsualizar nuevos
cambios.

Dado que la construcción, prueba y despliegue se realizarán con GitHub Actions,
esta sección sigue las directrices de [Carga Directa][linkCloudflareDirectUpload] y
[Ejecutar Wrangler en CI/CD][linkCloudflareWranglerCICD].

> [!NOTA]
> Esta sección requiere que el sitio estático haya sido generado con
> `make build`

#### 0. ID de cuenta de Cloudflare y token API

Para interactuar con Cloudflare Pages mediante Wrangler CLI, se requieren el ID de cuenta de Cloudflare y
el token API.

1. ID de cuenta: [Encontrar IDs de cuenta y zona][linkCloudflareFindAccountAndZoneIDs]
1. Token API
   1. [Crear token API][linkCloudflareCreateAPIToken]
   1. Usar la plantilla `Editar Cloudflare Workers`
   1. Actualizar el `Nombre del token`
   1. Permisos:
      1. Cuenta - Cloudflare Pages - Editar
      1. Eliminar otros permisos
   1. Incluir tu cuenta
   1. Establecer un TTL de corta duración
   1. Hacer clic en `Continuar al resumen`
1. Estos valores se usarán en la siguiente sección `1. Envfile`

#### 1. Archivo de entorno

Las siguientes secciones usan los valores del archivo `.env`. Crea el archivo `.env`
(basado en `env.template`) con los valores correctos.

Ejemplo:


```bash
# .env
ENV_CLOUDFLARE_BRANCH_NAME=main
ENV_CLOUDFLARE_PROJECT_NAME=random-project-name
ENV_SECRET_CLOUDFLARE_ACCOUNT_ID=id-from-previous-section
ENV_SECRET_CLOUDFLARE_API_TOKEN=token-from-previous-section
```

Verificar:

```bash
make shell
# Check the env vars are correctly set
env | grep ENV_
# List current projects on CloudFlare
deno task deploy:list
exit
```

#### 2. Crear

Esta sección crea un nuevo proyecto de Pages. Este paso solo es necesario si
`ENV_CLOUDFLARE_PROJECT_NAME` no se mencionó en el paso `1. Envfile`.

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

#### 3. Desplegar

Esta sección despliega el sitio web en un proyecto existente de Cloudflare Pages.

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

Nota: también se puede usar `make deploy`.

#### 4. Eliminar

Esta sección muestra cómo eliminar un proyecto de Cloudflare Pages.

```bash
make shell
deno task deploy:delete
#? Are you sure you want to delete "<ENV_CLOUDFLARE_PROJECT_NAME>"? This action cannot be undone. › y
# Check the project is no longer listed
deno task deploy:list
exit
```

> [!IMPORTANTE]
> El token de CloudFlare creado en la sección
> `0. ID de cuenta de Cloudflare y token API` puede ser eliminado

### CI/CD

[GitHub Actions][linkGitHubActions] se utiliza para probar PRs y desplegar cambios realizados
en la rama `main` a Cloudflare Pages.

- Se ha creado un token API dedicado de Cloudflare para Github Actions
- Las variables de entorno requeridas para desplegar en Cloudflare Pages están configuradas como
  [variables][linkGitHubActionsVariables] y
  [secretos][linkGitHubActionsSecrets] en GitHub Actions
- Los flujos de trabajo de GitHub Actions siguen el patrón de los 3 Mosqueteros

### Elementos visuales

- Logo de los 3 Mosqueteros
  - Creado por mí con [Procreate][linkProcreate] y Vectornator
    - Las herramientas usadas son `offset path` y `mask objects`
  - Imagen SVG de 2048px por 2048px
  - Las imágenes están en la carpeta `./src/assets/logo/`
- Favicon
  - La imagen fuente es un png exportado del logo
  - Usar el sitio web [favicon.io][linkFaviconio]
  - El contenido generado está en `./public/favicon_io`
  - Las instrucciones para copiar las etiquetas HTML `<link>` en el `<head>` están en
    `./astro.config.mjs`
- Vista previa en redes sociales
  - Esto es para mostrar la vista previa del sitio web en Twitter, Facebook, GitHub,
    etc.
  - Se creó una nueva imagen vectorial 1280x640px con el logo reducido en el centro
    - El tamaño es sugerido por GitHub en Configuración General
  - Según el [artículo de artegence][linkArtegenceArticle], la imagen ideal que
    funciona en diferentes plataformas sociales
    - Es de 1200x630px
    - Tiene el logo (630x630) centrado
    - Usar formato png (muy alta calidad y transparencia)
    - Usar formato jpg (alta calidad y muy buena compresión de tamaño)
  - La imagen social también se configura en la configuración general del repositorio
  - Astro Starlight establece todas las etiquetas `<meta>` en la sección `<head>`
- Diagramas
  - [Mermaid][linkMermaid] se utiliza para generar diagramas
  - Todos los diagramas están en el directorio [diagrams](diagrams)
- La [demo][linkDemo] fue generada por [charmbracelet/vhs][linkVHS]

## Contribuyendo

[CONTRIBUTING.md](https://raw.githubusercontent.com/flemay/3musketeers/main/CONTRIBUTING.md)

Gracias a los [colaboradores][linkContributors].

## Licencia

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