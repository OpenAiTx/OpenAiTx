<p align="center">
  <a href="https://turborepo.com/" target="blank"><img src="https://user-images.githubusercontent.com/4060187/106504110-82f58d00-6494-11eb-87b7-a16d4f68bc5a.png" width="350" alt="Turborepo 标志" /></a>
<p>

<p align="center">
  <a href="https://vuejs.org/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/2367px-Vue.js_Logo_2.svg.png" width="88" alt="Vue 标志" /></a>
  <a href="https://nuxt.com/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Nuxt_logo.svg/1200px-Nuxt_logo.svg.png" width="105" alt="Nuxt 标志" /></a>
  <a href="https://nestjs.com/" target="blank"><img src="https://nestjs.com/img/logo-small.svg" width="88" alt="Nest 标志" /></a>
</p>


# 入门套件：使用 TurboRepo 的软件开发项目

该仓库作为一个即用型工具包和项目骨架，使构建创新软件应用能够快速启动。它利用了先进的技术和框架，如 TurboRepo、NestJS、基于 Vite 的 Vue 3、TypeScript 以及 Nuxt.js，以促进无缝且高效的软件开发。

## 目录
- [功能和内容](#features-and-contents)
- [先决条件](#prerequisites)
- [快速开始](#getting-started)
- [使用 Docker 快速开始](#getting-started-with-docker)
- [环境变量](#environment-variables)
- [Volar 与 Visual Studio Code（接管模式）](#volar-and-visual-studio-code-takeover-mode)
- [顶层脚本](#top-level-scripts)
- [Visual Studio Code 扩展](#visual-studio-code-extensions)
- [增强功能与错误报告](#enhancements-and-bug-reports)
- [贡献](#contribution)
- [许可证](#license)

## 功能和内容

- **TurboRepo**：该仓库配置为支持 TurboRepo —— 一个简化单个项目中多个相互关联仓库管理的工具。这样你可以专注于功能开发，而 TurboRepo 负责组织管理。

- **NestJS**：应用的后端基于 NestJS 构建，这是一个基于 Node.js 的框架，支持创建可扩展且模块化的 API。NestJS 完全集成 TypeScript，提供性能和可读性兼备的代码。

- **Vue 3 + Vite**：用户界面基于 Vue 3，这是流行的 JavaScript 框架的最新版本。我们还使用了 Vite，一款快速且现代的用户界面构建工具。

- **TypeScript**：整个项目均使用 TypeScript 编写，提升代码安全性，方便重构和维护。

- **Nuxt.js**：该仓库还包含 Nuxt.js 的示例配置，Nuxt.js 是用于创建 Vue.js 服务器端渲染（SSR）应用的框架，确保 SEO 性能和内容快速加载。

- **Electron**：该项目也可以使用 Electron 打包为桌面应用程序，允许您创建跨平台应用。

- **Capacitor**：集成了 Capacitor，以便使用 Web 技术构建原生移动应用。

- **Docker**：使用 Docker 来容器化和管理应用程序部署。

- **共享包**：仓库中包含一个共享包，以增强代码的可复用性和可维护性。

- **使用 Vitest 和 Jest 的测试配置**：仓库包含预配置的 Vitest 和 Jest 测试设置。您可以轻松编写并运行 Vue 组件和 TypeScript 代码的单元测试。只需利用提供的测试配置，结合 Vitest 的快速测试能力和 Jest 的强大测试框架。

## 先决条件

建议在开发环境中全局安装：

- [pnpm](https://pnpm.io/pnpm-cli)
- [nest-cli](https://docs.nestjs.com/cli/overview)

## 入门指南

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

## Docker入门

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

## 环境变量

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
## Volar 与 Visual Studio Code（接管模式）

`Volar` 现已成为 `Vue - Official` 扩展，因此在 2.0 版本中不再需要接管模式。  
如果之前禁用了内置的 `TypeScript and JavaScript Language Features` 扩展，请重新启用它。

## 顶层脚本

#### 开发

* `dev` - 同时运行所有应用程序并支持热重载
* `dev-api` - 运行带热重载的 API 项目
* `dev-web` - 运行带热重载的 WEB 项目
* `dev-web-electron` - 在 electron 应用中运行带热重载的 WEB 项目
* `dev-nuxt` - 运行带热重载的 nuxt 应用
* `dev-mobile` - 运行带热重载的移动应用

#### 构建

* `build` - 构建所有包和应用程序
* `build-api` - 构建 API 项目应用
* `build-web` - 构建 WEB 项目应用
* `build-web-electron` - 构建带 WEB 项目的 electron 应用
* `build-nuxt` - 构建 nuxt 应用
* `build-mobile` - 构建移动应用

#### 运行

* `start` - 启动所有应用程序
* `start-api` - 启动 API 项目应用
* `start-web` - 启动本地静态网页服务器，提供 dist 文件夹内容
* `start-nuxt` - 启动 nuxt 应用

#### 移动端

* `mobile-android` - 构建移动应用并在 Android Studio 中打开
* `mobile-ios` - 构建移动应用并在 Xcode 中打开

#### 通用

* `test` - 运行所有包和应用程序的测试
* `lint` - 检查所有包和应用程序的代码质量
* `clean` - 删除所有包和应用程序中的 dist 目录

## Visual Studio Code 扩展插件

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
### 必需

* `vue.volar` - Vue 语言功能（Volar）
* `syler.sass-indented` - Sass 语法高亮。
* `dbaeumer.vscode-eslint` - VS Code ESLint 扩展。
* `editorconfig.editorconfig` - VS Code 的 EditorConfig。

### 可选

* `mikestead.dotenv` - DotENV - 支持 dotenv 文件语法
* `visualstudioexptteam.vscodeintellicode` - IntelliCode

## 增强和错误报告

如果您发现错误，或有增强建议，请在 GitHub 上发布[问题](https://github.com/DhivinX/turbo-starter/issues)。

## 贡献

如果您有增强此入门项目的想法或想添加新功能，欢迎提交拉取请求。您的贡献可以帮助其他开发者更快启动他们的项目！

## 许可

此入门套件在 MIT 许可下提供。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-04

---