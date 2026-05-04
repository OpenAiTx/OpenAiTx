<p align="center">
  <a href="https://turborepo.com/" target="blank"><img src="https://user-images.githubusercontent.com/4060187/106504110-82f58d00-6494-11eb-87b7-a16d4f68bc5a.png" width="350" alt="Turborepo Logo" /></a>
<p>

<p align="center">
  <a href="https://vuejs.org/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/2367px-Vue.js_Logo_2.svg.png" width="88" alt="Vue Logo" /></a>
  <a href="https://nuxt.com/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Nuxt_logo.svg/1200px-Nuxt_logo.svg.png" width="105" alt="Nuxt Logo" /></a>
  <a href="https://nestjs.com/" target="blank"><img src="https://nestjs.com/img/logo-small.svg" width="88" alt="Nest Logo" /></a>
</p>


# Starter Kit: Software Development Project with TurboRepo

This repository serves as a ready-to-use toolkit and project skeleton that enables a swift start in building innovative software applications. It leverages advanced technologies and frameworks like TurboRepo, NestJS, Vue 3 with Vite, TypeScript, and Nuxt.js to facilitate seamless and efficient software development.

## Table of Contents
- [Features and Contents](#features-and-contents)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Getting Started with Docker](#getting-started-with-docker)
- [Environment Variables](#environment-variables)
- [Volar and Visual Studio Code (Takeover Mode)](#volar-and-visual-studio-code-takeover-mode)
- [Top-Level Scripts](#top-level-scripts)
- [Visual Studio Code Extensions](#visual-studio-code-extensions)
- [Enhancements and Bug Reports](#enhancements-and-bug-reports)
- [Contribution](#contribution)
- [License](#license)

## Features and Contents

- **TurboRepo**: The repository is configured to work with TurboRepo – a tool that simplifies the management of multiple interconnected repositories within a single project. This allows you to focus on feature development while TurboRepo handles organization.

- **NestJS**: The backend of the application is built on NestJS, a Node.js-based framework that enables the creation of scalable and modular APIs. Fully integrated with TypeScript, NestJS offers performance and readable code.

- **Vue 3 + Vite**: The user interface is based on Vue 3, the latest version of the popular JavaScript framework. We also use Vite, a fast and modern tool for building user interfaces.

- **TypeScript**: The entire project is written in TypeScript, enhancing code safety and facilitating refactoring and maintenance.

- **Nuxt.js**: The repository also includes a sample configuration for Nuxt.js, a framework for creating Vue.js SSR (Server-Side Rendering) applications. This ensures SEO performance and fast content loading.

- **Electron**: The project can also be packaged as a desktop application using Electron, allowing you to create cross-platform applications.

- **Capacitor**: Capacitor is integrated to enable building native mobile apps using web technologies.

- **Docker**: Docker is utilized to containerize and manage application deployment.

- **Shared Package**: The repository incorporates a shared package to enhance code reusability and maintainability.

- **Test Configuration with Vitest and Jest**: The repository includes a pre-configured setup for testing using Vitest and Jest. You can easily write and run unit tests for your Vue components and TypeScript code. Simply utilize the provided test configuration and harness the power of Vitest's rapid testing capabilities along with Jest's robust testing framework.

## Prerequisites

Suggest to install globally in dev environment:

- [pnpm](https://pnpm.io/pnpm-cli)
- [nest-cli](https://docs.nestjs.com/cli/overview)

## Getting Started

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

## Getting Started with Docker

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

## Environment variables

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

## Volar and Visual Studio Code (Takeover Mode)

`Volar` is now `Vue - Official` extension so, takeover mode is no longer needed in version 2.0. Please enable built-in `TypeScript and JavaScript Language Features` extension, if you was disable this extension before.

## Top-Level Scripts

#### DEVELOPMENT

* `dev` - run all applications simultaneously with hot reload
* `dev-api` - run API project with hot reload
* `dev-web` - run WEB project with hot reload
* `dev-web-electron` - run WEB project in electron application with hot reload
* `dev-nuxt` - run nuxt application with hot reload
* `dev-mobile` - run mobile application with hot reload

#### BUILD

* `build` - build all packages and applications
* `build-api` - build API project application
* `build-web` - build WEB project application
* `build-web-electron` - build electron application with web project
* `build-nuxt` - build nuxt application
* `build-mobile` - build mobile application

#### RUNNING

* `start` - start all applications
* `start-api` - start API project application
* `start-web` - boot up a local static web server that serves the files from dist
* `start-nuxt` - start nuxt application

#### MOBILE

* `mobile-android` - build mobile application and open in Android Studio
* `mobile-ios` - build mobile application and open in Xcode

#### COMMON

* `test` - run tests for all packages and applications
* `lint` - lint all packages and applications
* `clean` - remove dist directory from all packages and applications

## Visual Studio Code extensions

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

### Required

* `vue.volar` - Vue Language Features (Volar)
* `syler.sass-indented` - Sass syntax highlighting.
* `dbaeumer.vscode-eslint` - VS Code ESLint extension.
* `editorconfig.editorconfig` - EditorConfig for VS Code.

### Optional

* `mikestead.dotenv` - DotENV - Support for dotenv file syntax
* `visualstudioexptteam.vscodeintellicode` - IntelliCode

## Enhancements and Bug Reports

If you find a bug, or have an enhancement in mind please post [issues](https://github.com/DhivinX/turbo-starter/issues) on GitHub.

## Contribution

If you have ideas for enhancing this starter or want to add new features, feel free to submit pull requests. Your contribution can help other developers kickstart their projects even faster!

## License

This starter kit is provided under the MIT license.
