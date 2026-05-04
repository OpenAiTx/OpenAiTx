<p align="center">
  <a href="https://turborepo.com/" target="blank"><img src="https://user-images.githubusercontent.com/4060187/106504110-82f58d00-6494-11eb-87b7-a16d4f68bc5a.png" width="350" alt="Logo de Turborepo" /></a>
<p>

<p align="center">
  <a href="https://vuejs.org/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/2367px-Vue.js_Logo_2.svg.png" width="88" alt="Logo de Vue" /></a>
  <a href="https://nuxt.com/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Nuxt_logo.svg/1200px-Nuxt_logo.svg.png" width="105" alt="Logo de Nuxt" /></a>
  <a href="https://nestjs.com/" target="blank"><img src="https://nestjs.com/img/logo-small.svg" width="88" alt="Logo de Nest" /></a>
</p>


# Kit de Inicio: Proyecto de Desarrollo de Software con TurboRepo

Este repositorio sirve como un kit de herramientas listo para usar y un esqueleto de proyecto que permite un inicio rápido en la construcción de aplicaciones de software innovadoras. Aprovecha tecnologías y frameworks avanzados como TurboRepo, NestJS, Vue 3 con Vite, TypeScript y Nuxt.js para facilitar un desarrollo de software fluido y eficiente.

## Tabla de Contenidos
- [Características y Contenidos](#features-and-contents)
- [Prerrequisitos](#prerequisites)
- [Primeros Pasos](#getting-started)
- [Primeros Pasos con Docker](#getting-started-with-docker)
- [Variables de Entorno](#environment-variables)
- [Volar y Visual Studio Code (Modo Takeover)](#volar-and-visual-studio-code-takeover-mode)
- [Scripts de Nivel Superior](#top-level-scripts)
- [Extensiones de Visual Studio Code](#visual-studio-code-extensions)
- [Mejoras y Reportes de Errores](#enhancements-and-bug-reports)
- [Contribución](#contribution)
- [Licencia](#license)

## Características y Contenidos

- **TurboRepo**: El repositorio está configurado para trabajar con TurboRepo, una herramienta que simplifica la gestión de múltiples repositorios interconectados dentro de un solo proyecto. Esto te permite enfocarte en el desarrollo de funcionalidades mientras TurboRepo se encarga de la organización.

- **NestJS**: El backend de la aplicación está construido sobre NestJS, un framework basado en Node.js que permite la creación de APIs escalables y modulares. Totalmente integrado con TypeScript, NestJS ofrece rendimiento y código legible.

- **Vue 3 + Vite**: La interfaz de usuario se basa en Vue 3, la última versión del popular framework de JavaScript. También usamos Vite, una herramienta rápida y moderna para construir interfaces de usuario.

- **TypeScript**: Todo el proyecto está escrito en TypeScript, mejorando la seguridad del código y facilitando el refactorizado y mantenimiento.

- **Nuxt.js**: El repositorio también incluye una configuración de ejemplo para Nuxt.js, un framework para crear aplicaciones SSR (Renderizado del lado del servidor) con Vue.js. Esto asegura un buen rendimiento SEO y carga rápida de contenido.

- **Electron**: El proyecto también puede empaquetarse como una aplicación de escritorio usando Electron, lo que permite crear aplicaciones multiplataforma.

- **Capacitor**: Capacitor está integrado para permitir la creación de aplicaciones móviles nativas usando tecnologías web.

- **Docker**: Docker se utiliza para contenerizar y gestionar el despliegue de la aplicación.

- **Paquete Compartido**: El repositorio incorpora un paquete compartido para mejorar la reutilización y mantenibilidad del código.

- **Configuración de Pruebas con Vitest y Jest**: El repositorio incluye una configuración predefinida para pruebas usando Vitest y Jest. Puedes escribir y ejecutar fácilmente pruebas unitarias para tus componentes Vue y código TypeScript. Simplemente utiliza la configuración de prueba proporcionada y aprovecha la rapidez de Vitest junto con el robusto framework de Jest.

## Prerrequisitos

Se sugiere instalar globalmente en el entorno de desarrollo:

- [pnpm](https://pnpm.io/pnpm-cli)
- [nest-cli](https://docs.nestjs.com/cli/overview)

## Comenzando

```bash

# 1. Clone the repository
git clone https://github.com/DhivinX/turbo-starter.git

# 2. Enter your newly-cloned folder
cd turbo-starter

# 3. Install the project and build packages in libs folder
pnpm install

# 4. Dev: Run web with hot reload 
pnpm dev-web # or make dev-web

# 5. Dev: Run API project with hot reload 
# Note that you need to create the .env file in the project root directory beforehand

# You should copy the .env.example file and rename it to .env
cp .env.example .env

# Then you can configure database access and other server settings
pnpm dev-api # or make dev-api

# 6. Or run API and WEB projects with hot reload parallel
pnpm dev # or make dev

```

## Comenzando con Docker

```bash

# 1. Clone the repository
git clone https://github.com/DhivinX/turbo-starter.git

# 2. Enter your newly-cloned folder
cd turbo-starter

# 3. Install the project and build packages in libs folder
pnpm install

# 4. Copy env.example to .env.local and pass wished variables:
# Change DATABASE_HOST to "postgres"
cp .env.example .env.local

# 5. Build image:
make docker-build-local

# 6. Run API and WEB projects development process with hot reload in docker container 
make docker-run-local

```

## Variables de entorno

### .env.example

```bash
# Frontend: API server connection configuration
VITE_WEB_DEFAULT_LOCALE="en"
VITE_WEB_API_URL="http://localhost"
VITE_WEB_API_PORT=3000

# Backend public url
API_PUBLIC_URL=http://localhost:3000

# HTTP / HTTPS server config
API_HTTP_PORT=3000

# Cross-Origin Resource Sharing domain origins
# More info: https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS
API_HTTP_CORS=["http://localhost", "http://localhost:8080", "http://localhost:8081", "http://localhost:8082", "app://localhost", "capacitor://localhost"]

# Keys required for hashing passwords and tokens
# They should be filled with random, unique strings
API_SECRETS_PWDSALT="123456"
API_SECRETS_JWT="123456"

# Database type: postgres, mysql, sqlite etc.
# More info: https://typeorm.io
DATABASE_TYPE="postgres"

# Database connection config
DATABASE_HOST="localhost"
DATABASE_PORT=5432

# Database name and user credentials
DATABASE_NAME="turbonv"
DATABASE_USER="postgres"
DATABASE_PASSWORD="root"

# Disable this in the production version of the application
# More info: https://typeorm.io/faq#how-do-i-update-a-database-schema
DATABASE_ENABLE_SYNC=true
```

## Volar y Visual Studio Code (Modo de toma de control)

`Volar` ahora es la extensión `Vue - Official`, por lo que el modo de toma de control ya no es necesario en la versión 2.0. Por favor, habilite la extensión incorporada `TypeScript and JavaScript Language Features`, si la había deshabilitado antes.

## Scripts de nivel superior

#### DESARROLLO

* `dev` - ejecutar todas las aplicaciones simultáneamente con recarga en caliente
* `dev-api` - ejecutar el proyecto API con recarga en caliente
* `dev-web` - ejecutar el proyecto WEB con recarga en caliente
* `dev-web-electron` - ejecutar el proyecto WEB en aplicación electron con recarga en caliente
* `dev-nuxt` - ejecutar la aplicación nuxt con recarga en caliente
* `dev-mobile` - ejecutar la aplicación móvil con recarga en caliente

#### COMPILACIÓN

* `build` - compilar todos los paquetes y aplicaciones
* `build-api` - compilar la aplicación del proyecto API
* `build-web` - compilar la aplicación del proyecto WEB
* `build-web-electron` - compilar la aplicación electron con proyecto web
* `build-nuxt` - compilar la aplicación nuxt
* `build-mobile` - compilar la aplicación móvil

#### EJECUCIÓN

* `start` - iniciar todas las aplicaciones
* `start-api` - iniciar la aplicación del proyecto API
* `start-web` - iniciar un servidor web estático local que sirve los archivos desde dist
* `start-nuxt` - iniciar la aplicación nuxt

#### MÓVIL

* `mobile-android` - compilar la aplicación móvil y abrir en Android Studio
* `mobile-ios` - compilar la aplicación móvil y abrir en Xcode

#### COMÚN

* `test` - ejecutar pruebas para todos los paquetes y aplicaciones
* `lint` - analizar todos los paquetes y aplicaciones
* `clean` - eliminar el directorio dist de todos los paquetes y aplicaciones

## Extensiones de Visual Studio Code

```json

{
  "recommendations": [
    "vue.volar",
    "dbaeumer.vscode-eslint",
    "editorconfig.editorconfig",
    "visualstudioexptteam.vscodeintellicode",
    "mikestead.dotenv",
    "firsttris.vscode-jest-runner"
  ]
}

```

### Requerido

* `vue.volar` - Funciones de Lenguaje Vue (Volar)
* `syler.sass-indented` - Resaltado de sintaxis Sass.
* `dbaeumer.vscode-eslint` - Extensión ESLint para VS Code.
* `editorconfig.editorconfig` - EditorConfig para VS Code.

### Opcional

* `mikestead.dotenv` - DotENV - Soporte para la sintaxis de archivos dotenv
* `visualstudioexptteam.vscodeintellicode` - IntelliCode

## Mejoras y Reportes de Errores

Si encuentras un error o tienes una mejora en mente, por favor publica [issues](https://github.com/DhivinX/turbo-starter/issues) en GitHub.

## Contribución

Si tienes ideas para mejorar este starter o deseas añadir nuevas funcionalidades, siéntete libre de enviar pull requests. ¡Tu contribución puede ayudar a otros desarrolladores a iniciar sus proyectos aún más rápido!

## Licencia

Este kit de inicio se proporciona bajo la licencia MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-04

---