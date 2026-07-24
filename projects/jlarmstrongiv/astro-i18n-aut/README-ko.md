# `astro-i18n-aut` Astro를 위한 i18n 통합 🧑‍🚀

<p align="center">
  <a href="https://github.com/jlarmstrongiv/astro-i18n-aut#readme" target="_blank">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/jlarmstrongiv/astro-i18n-aut/main/logos/astro-i18n-aut-dark.svg">
      <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/jlarmstrongiv/astro-i18n-aut/main/logos/astro-i18n-aut-light.svg">
      <img alt="astro-i18n-aut" src="https://raw.githubusercontent.com/jlarmstrongiv/astro-i18n-aut/HEAD/logos/astro-i18n-aut-light.svg" width="400" height="225" style="max-width: 100%;">
    </picture>
  </a>
</p>

<p align="center">
  모든 Astro 크루원을 위해 ❤️로 제작됨 🧑‍🚀
</p>

<p align="center">
  <a href="https://www.npmjs.com/package/astro-i18n-aut"><img src="https://img.shields.io/npm/dt/astro-i18n-aut.svg" alt="Total Downloads"></a>
  <!-- https://github.com/astro-i18n-aut/astro-i18n-aut/releases -->
  <a href="https://www.npmjs.com/package/astro-i18n-aut?activeTab=versions"><img src="https://img.shields.io/npm/v/astro-i18n-aut.svg" alt="Latest Release"></a>
  <a href="https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/LICENSE.md"><img src="https://img.shields.io/npm/l/astro-i18n-aut.svg" alt="License"></a>
</p>

---

## 동기

Astro를 위한 국제화(i18n) 통합 제공:

- `defaultLocale` 지원
- 템플릿 파일 중복 방지
- 어댑터 독립적
- UI 프레임워크 독립적
- [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap)과 호환 가능

## 빠른 시작

### 설치

[npm](https://www.npmjs.com/package/astro-i18n-aut)을 통해 설치:

```shell
npm install astro-i18n-aut
```

### 구성

Astro [구성](https://docs.astro.build/en/guides/configuring-astro/#supported-config-file-types) 파일에서:

```ts
import { defineConfig } from "astro/config";
import { i18n, filterSitemapByDefaultLocale } from "astro-i18n-aut/integration";
import sitemap from "@astrojs/sitemap";

const defaultLocale = "en";
const locales = {
  en: "en-US", // the `defaultLocale` value must present in `locales` keys
  es: "es-ES",
  fr: "fr-CA",
};

export default defineConfig({
  site: "https://example.com/",
  trailingSlash: "always",
  build: {
    format: "directory",
  },
  integrations: [
    i18n({
      locales,
      defaultLocale,
    }),
    sitemap({
      i18n: {
        locales,
        defaultLocale,
      },
      filter: filterSitemapByDefaultLocale({ defaultLocale }),
    }),
  ],
});
```
당신의 `.gitignore` 파일에서:


```gitignore
astro_tmp_pages_*
```
### 사용법

이제 설정을 완료했으므로, 각 `.astro` 페이지는 다른 언어로 추가 렌더링됩니다. 예를 들어, `src/pages/about.astro`는 다음과 같이 렌더링됩니다:

- `/about/`
- `/es/about/`
- `/fr/about/`

`redirectDefaultLocale`을 활성화한 경우(기본값은 `true`), 리디렉션은 다음과 같습니다:

- `/en/about/` => `/about/`

`getStaticPaths()` 함수는 한 번만 실행된다는 점을 유의하세요. 이 제한으로 인해 `/about/`에 대해 `/es/acerca-de/`와 같은 번역된 URL을 사용할 수 없습니다. 그러나 이는 [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap)과의 호환성을 보장합니다.

Astro 프론트매터와 페이지 내용은 모든 번역된 페이지마다 다시 실행됩니다. 예를 들어, `Astro.url.pathname`은 다음과 같습니다:

- `/about/`
- `/es/about/`
- `/fr/about/`

어떤 언어가 렌더링되고 있는지 감지하는 것은 사용자의 몫입니다. Astro [콘텐츠 컬렉션](https://docs.astro.build/en/guides/content-collections/)이나 [`react-i18next`](https://www.npmjs.com/package/react-i18next)와 같은 i18n UI 프레임워크를 사용하여 번역할 수 있습니다. 다음은 순수 `Hello World` 예제입니다:


```astro
---
import { getLocale } from "astro-i18n-aut";
import Layout from "../layouts/Layout.astro";

const locale = getLocale(Astro.url);

let title: string;
switch (locale) {
  case "es":
    title = "¡Hola Mundo!";
    break;
  case "fr":
    title = "Bonjour Monde!";
    break;
  default:
    title = "Hello World!";
}
---

<Layout title={title}>
  <h1>{title}</h1>
</Layout>
```
로케일 처리를 쉽게 하기 위해 여러 도우미 함수가 포함되어 있습니다.

### Astro 구성 옵션

자세한 내용은 공식 Astro 문서를 참조하세요:

- [`site`](https://docs.astro.build/en/reference/configuration-reference/#site)
- [`trailingSlash`](https://docs.astro.build/en/reference/configuration-reference/#trailingslash)
- [`format`](https://docs.astro.build/en/reference/configuration-reference/#buildformat)

다음 중 하나를 반드시 설정해야 합니다:

- ```js
  {
    site: "https://example.com/",
    trailingSlash: "always",
    build: {
      format: "directory",
    },
  }

  ```

- ```js
  {
    site: "https://example.com",
    trailingSlash: "never",
    build: {
      format: "file",
    },
  }
  ```
이 모든 옵션은 서로 관련되어 있으며 함께 설정해야 합니다. 이들은 URL이 다음과 같은지 여부에 영향을 미칩니다:

- `/about/`
- `/about`

`/about/`을 선택하면 `/about`은 404가 되며 그 반대도 마찬가지입니다.

### 통합 옵션

- `locales`: 모든 언어 로케일의 기록입니다.
- `defaultLocale`: 기본 언어 로케일입니다. 값은 `locales` 키에 있어야 합니다.
- `redirectDefaultLocale` - `defaultLocale: "en"`인 경우, `/en/about/`가 `/about/`로 리디렉션되는지 여부입니다 (기본값: `308`).
- `include`: 포함할 글로브 패턴(기본값: `["pages/**/*"]`).
- `exclude`: 제외할 글로브 패턴(기본값: `["pages/api/**/*"]`).

### 호환성

#### 페이지 파일 유형

다른 Astro 페이지 파일 유형:

- ✅ `.astro`
- ❌ `.md`
- ❌ `.mdx` (MDX 통합이 설치된 경우)
- ❌ `.html`
- ❌ `.js` / `.ts` (엔드포인트로서)

는 번역할 수 없습니다. `pages` 디렉터리에서 사용하기로 선택한 경우, 무시할 글로브 패턴에 추가해 주세요. 예를 들면:


```js
["pages/api/**/*", "pages/**/*.md"];
```
#### 페이지 제외하기

Astro의 [문서](https://docs.astro.build/en/core-concepts/routing/#excluding-pages)에는 다음과 같이 나와 있습니다:

> 페이지나 디렉터리 이름 앞에 밑줄(_)을 붙여 빌드에서 제외할 수 있습니다. _ 접두사가 붙은 파일은 라우터에서 인식되지 않으며 dist/ 디렉터리에 포함되지 않습니다.
>
> 이를 사용하여 페이지를 일시적으로 비활성화하거나 테스트, 유틸리티, 컴포넌트를 관련 페이지와 같은 폴더에 넣을 수 있습니다.

불행히도, 이 [페이지 제외하기](https://docs.astro.build/en/core-concepts/routing/#excluding-pages) 기능은 지원되지 않습니다. 페이지 디렉터리에는 페이지만 보관하시기 바랍니다.

밑줄(`_`)로 시작하는 페이지를 제외하려면 무시할 glob 패턴에 `pages/**/_*`를 추가할 수 있습니다:


```js
["pages/api/**/*", "pages/**/_*"];
```

#### Markdown

`.md` 및 `.mdx`의 경우 Astro [Content](https://docs.astro.build/en/guides/content-collections/#organizing-with-subdirectories) [Collections](https://docs.astro.build/en/recipes/i18n/#use-collections-for-translated-content)를 사용하세요.

이 라이브러리와 Astro Content Collections를 사용하면 `content` 내에서 Markdown을 분리하고 체계적으로 관리할 수 있으며, `pages/blog/index.astro` 및 `pages/blog/[slug].astro`를 사용하여 `defaultLocale`이 있어도 모든 콘텐츠를 렌더링할 수 있습니다! 다음은 예시 폴더 구조입니다:

```
.
└── astro-project/
    └── src/
        ├── pages/
        │   └── blog/
        │       ├── index.astro
        │       └── [id].astro
        └── content/
            └── blog/
                ├── en/
                │   ├── post-1.md
                │   └── post-2.md
                ├── es/
                │   ├── post-1.md
                │   └── post-2.md
                └── fr/
                    ├── post-1.md
                    └── post-2.md
```
#### UI 프레임워크

Astro는 페이지 파일 유형으로 `.tsx` 또는 `.jsx`를 지원하지 않습니다.

React와 Vue와 같은 UI 프레임워크는 Astro에서 [일반적으로](https://docs.astro.build/en/core-concepts/framework-components/) 사용하는 것처럼 컴포넌트로 가져와 사용하세요.

번역된 콘텐츠 `title={t('title')}` 또는 로케일 `locale={locale}`을 props로 전달해도 됩니다.

#### 엔드포인트

기본적으로 `pages/api/**/*` 내의 모든 페이지는 무시됩니다.

`.ts` 및 `.js` 엔드포인트의 경우, 다중 로케일을 처리하는 방법은 여러분에게 달려 있습니다. 엔드포인트는 사용자에게 직접 보이지 않고, 사용하는 방법도 다양하기 때문에 구현은 여러분의 선택에 맡깁니다.

## 라이선스

MIT 라이선스

## 기여

PR 환영합니다! 도움에 감사드립니다. 버그 신고 및 PR 작성에 관한 자세한 내용은 [기여 가이드](https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/CONTRIBUTING.md)를 참고하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---