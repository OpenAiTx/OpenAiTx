<p align="center">
  <a href="https://turborepo.com/" target="blank"><img src="https://user-images.githubusercontent.com/4060187/106504110-82f58d00-6494-11eb-87b7-a16d4f68bc5a.png" width="350" alt="Turborepo Logo" /></a>
<p>

<p align="center">
  <a href="https://vuejs.org/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/2367px-Vue.js_Logo_2.svg.png" width="88" alt="Vue Logo" /></a>
  <a href="https://nuxt.com/" target="blank"><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Nuxt_logo.svg/1200px-Nuxt_logo.svg.png" width="105" alt="Nuxt Logo" /></a>
  <a href="https://nestjs.com/" target="blank"><img src="https://nestjs.com/img/logo-small.svg" width="88" alt="Nest Logo" /></a>
</p>


# 스타터 키트: TurboRepo를 활용한 소프트웨어 개발 프로젝트

이 저장소는 혁신적인 소프트웨어 애플리케이션을 신속하게 구축할 수 있도록 하는 즉시 사용 가능한 툴킷 및 프로젝트 골격을 제공합니다. TurboRepo, NestJS, Vue 3 with Vite, TypeScript, Nuxt.js와 같은 최신 기술과 프레임워크를 활용하여 원활하고 효율적인 소프트웨어 개발을 지원합니다.

## 목차
- [특징 및 내용](#features-and-contents)
- [필수 조건](#prerequisites)
- [시작하기](#getting-started)
- [Docker로 시작하기](#getting-started-with-docker)
- [환경 변수](#environment-variables)
- [Volar 및 Visual Studio Code (테이크오버 모드)](#volar-and-visual-studio-code-takeover-mode)
- [최상위 스크립트](#top-level-scripts)
- [Visual Studio Code 확장 기능](#visual-studio-code-extensions)
- [기능 개선 및 버그 보고](#enhancements-and-bug-reports)
- [기여](#contribution)
- [라이선스](#license)

## 특징 및 내용

- **TurboRepo**: 이 저장소는 TurboRepo와 연동되도록 구성되어 있습니다. TurboRepo는 단일 프로젝트 내 여러 연결된 저장소를 간편하게 관리할 수 있는 도구로, 기능 개발에 집중할 수 있도록 조직 관리를 처리합니다.

- **NestJS**: 애플리케이션의 백엔드는 확장 가능하고 모듈화된 API를 생성할 수 있는 Node.js 기반 프레임워크인 NestJS로 구축되었습니다. TypeScript와 완전히 통합되어 있어 뛰어난 성능과 가독성 있는 코드를 제공합니다.

- **Vue 3 + Vite**: 사용자 인터페이스는 최신 버전의 인기 있는 자바스크립트 프레임워크인 Vue 3를 기반으로 합니다. 또한, 빠르고 현대적인 UI 빌드 도구인 Vite를 사용합니다.

- **TypeScript**: 프로젝트 전체가 TypeScript로 작성되어 코드 안정성을 높이고 리팩토링 및 유지보수를 용이하게 합니다.

- **Nuxt.js**: 이 저장소에는 Vue.js SSR(서버 사이드 렌더링) 애플리케이션을 생성하기 위한 프레임워크인 Nuxt.js의 샘플 구성도 포함되어 있습니다. 이를 통해 SEO 성능과 빠른 콘텐츠 로딩을 보장합니다.

- **Electron**: 이 프로젝트는 Electron을 사용하여 데스크탑 애플리케이션으로도 패키징할 수 있어, 크로스 플랫폼 애플리케이션을 만들 수 있습니다.

- **Capacitor**: Capacitor가 통합되어 웹 기술을 사용하여 네이티브 모바일 앱을 빌드할 수 있습니다.

- **Docker**: Docker가 사용되어 애플리케이션 배포를 컨테이너화하고 관리합니다.

- **공유 패키지**: 이 저장소는 코드 재사용성과 유지보수성을 향상시키기 위해 공유 패키지를 포함하고 있습니다.

- **Vitest와 Jest를 이용한 테스트 구성**: 이 저장소에는 Vitest와 Jest를 사용한 테스트 사전 구성이 포함되어 있습니다. Vue 컴포넌트와 TypeScript 코드를 위한 단위 테스트를 쉽게 작성하고 실행할 수 있습니다. 제공된 테스트 구성을 활용하여 Vitest의 빠른 테스트 기능과 Jest의 강력한 테스트 프레임워크를 함께 사용할 수 있습니다.

## 사전 요구사항

개발 환경에서 전역 설치를 권장합니다:

- [pnpm](https://pnpm.io/pnpm-cli)
- [nest-cli](https://docs.nestjs.com/cli/overview)

## 시작하기

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
## Docker 시작하기


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

## 환경 변수

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
## Volar와 Visual Studio Code (테이크오버 모드)

`Volar`는 이제 `Vue - Official` 확장 프로그램이므로, 버전 2.0에서는 테이크오버 모드가 더 이상 필요하지 않습니다. 이전에 이 확장 프로그램을 비활성화했다면 내장된 `TypeScript and JavaScript Language Features` 확장 프로그램을 활성화하세요.

## 최상위 스크립트

#### 개발

* `dev` - 모든 애플리케이션을 동시에 핫 리로드로 실행
* `dev-api` - API 프로젝트를 핫 리로드로 실행
* `dev-web` - 웹 프로젝트를 핫 리로드로 실행
* `dev-web-electron` - 웹 프로젝트를 전자 애플리케이션에서 핫 리로드로 실행
* `dev-nuxt` - nuxt 애플리케이션을 핫 리로드로 실행
* `dev-mobile` - 모바일 애플리케이션을 핫 리로드로 실행

#### 빌드

* `build` - 모든 패키지와 애플리케이션 빌드
* `build-api` - API 프로젝트 애플리케이션 빌드
* `build-web` - 웹 프로젝트 애플리케이션 빌드
* `build-web-electron` - 웹 프로젝트와 함께 전자 애플리케이션 빌드
* `build-nuxt` - nuxt 애플리케이션 빌드
* `build-mobile` - 모바일 애플리케이션 빌드

#### 실행

* `start` - 모든 애플리케이션 시작
* `start-api` - API 프로젝트 애플리케이션 시작
* `start-web` - dist 폴더의 파일을 제공하는 로컬 정적 웹 서버 부팅
* `start-nuxt` - nuxt 애플리케이션 시작

#### 모바일

* `mobile-android` - 모바일 애플리케이션 빌드 후 Android Studio에서 열기
* `mobile-ios` - 모바일 애플리케이션 빌드 후 Xcode에서 열기

#### 공통

* `test` - 모든 패키지와 애플리케이션에 대한 테스트 실행

* `lint` - 모든 패키지 및 애플리케이션의 린트 수행
* `clean` - 모든 패키지 및 애플리케이션에서 dist 디렉터리 제거

## Visual Studio Code 확장 프로그램

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
### 필수

* `vue.volar` - Vue 언어 기능 (Volar)
* `syler.sass-indented` - Sass 구문 하이라이팅.
* `dbaeumer.vscode-eslint` - VS Code ESLint 확장.
* `editorconfig.editorconfig` - VS Code용 EditorConfig.

### 선택 사항

* `mikestead.dotenv` - DotENV - dotenv 파일 구문 지원
* `visualstudioexptteam.vscodeintellicode` - IntelliCode

## 개선 사항 및 버그 신고

버그를 발견하거나 개선할 아이디어가 있으면 GitHub에 [이슈](https://github.com/DhivinX/turbo-starter/issues)를 게시해 주세요.

## 기여

이 스타터를 개선할 아이디어가 있거나 새로운 기능을 추가하고 싶다면 언제든지 풀 리퀘스트를 제출하세요. 여러분의 기여는 다른 개발자들이 프로젝트를 더 빠르게 시작하는 데 도움이 됩니다!

## 라이선스

이 스타터 키트는 MIT 라이선스 하에 제공됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-04

---