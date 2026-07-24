# `astro-i18n-aut` The i18n integration for Astro 🧑‍🚀

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
  Built with ❤️ for all Astro crewmates 🧑‍🚀
</p>

<p align="center">
  <a href="https://www.npmjs.com/package/astro-i18n-aut"><img src="https://img.shields.io/npm/dt/astro-i18n-aut.svg" alt="Total Downloads"></a>
  <!-- https://github.com/astro-i18n-aut/astro-i18n-aut/releases -->
  <a href="https://www.npmjs.com/package/astro-i18n-aut?activeTab=versions"><img src="https://img.shields.io/npm/v/astro-i18n-aut.svg" alt="Latest Release"></a>
  <a href="https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/LICENSE.md"><img src="https://img.shields.io/npm/l/astro-i18n-aut.svg" alt="License"></a>
</p>

---

## Motivation

Provide an internationalization (i18n) integration for Astro that:

- Supports the `defaultLocale`
- Avoids template file duplication
- Is adapter agnostic
- Is UI framework agnostic
- Is compatible with [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap)

## Quick start

### Install

Install via [npm](https://www.npmjs.com/package/astro-i18n-aut):

```shell
npm install astro-i18n-aut
```

### Configure

In your Astro [config](https://docs.astro.build/en/guides/configuring-astro/#supported-config-file-types) file:

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

In your `.gitignore` file:

```gitignore
astro_tmp_pages_*
```

### Usage

Now that you have set up the config, each `.astro` page will have additional renders with your other languages. For example, `src/pages/about.astro` will render as:

- `/about/`
- `/es/about/`
- `/fr/about/`

If you have enabled `redirectDefaultLocale` (`true` by default), redirects will be:

- `/en/about/` => `/about/`

Please note that the `getStaticPaths()` function will only run once. This limitation means that you cannot have translated urls, such as `/es/acerca-de/` for `/about/`. However, it also ensures compatibility with [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap).

The Astro frontmatter and page content is re-run for every translated page. For example, the `Astro.url.pathname` will be:

- `/about/`
- `/es/about/`
- `/fr/about/`

It is up to you to detect which language is being rendered. You can use Astro [content collections](https://docs.astro.build/en/guides/content-collections/) or any i18n UI framework, such as [`react-i18next`](https://www.npmjs.com/package/react-i18next), for your translations. Here is a pure `Hello World` example:

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

Several helper functions are included to make handling locales easier.

### Astro config options

Please see the official Astro docs for more details:

- [`site`](https://docs.astro.build/en/reference/configuration-reference/#site)
- [`trailingSlash`](https://docs.astro.build/en/reference/configuration-reference/#trailingslash)
- [`format`](https://docs.astro.build/en/reference/configuration-reference/#buildformat)

You must set either:

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

All these options are related and must be set together. They affect whether your urls are:

- `/about/`
- `/about`

If you choose `/about/`, then `/about` will 404 and vice versa.

### Integration options

- `locales`: A record of all language locales.
- `defaultLocale`: The default language locale. The value must present in `locales` keys.
- `redirectDefaultLocale` - Assuming the `defaultLocale: "en"`, whether `/en/about/` redirects to `/about/` (default: `308`).
- `include`: Glob pattern(s) to include (default: `["pages/**/*"]`).
- `exclude`: Glob pattern(s) to exclude (default: `["pages/api/**/*"]`).

### Compatibility

#### Page file types

Other Astro page file types:

- ✅ `.astro`
- ❌ `.md`
- ❌ `.mdx` (with the MDX Integration installed)
- ❌ `.html`
- ❌ `.js` / `.ts` (as endpoints)

cannot be translated. If you choose to use them in the `pages` directory, please add them to the ignore glob patterns. For example:

```js
["pages/api/**/*", "pages/**/*.md"];
```

#### Excluding pages

In Astro, the [docs](https://docs.astro.build/en/core-concepts/routing/#excluding-pages) state:

> You can exclude pages or directories from being built by prefixing their names with an underscore (_). Files with the _ prefix won’t be recognized by the router and won’t be placed into the dist/ directory.
>
> You can use this to temporarily disable pages, and also to put tests, utilities, and components in the same folder as their related pages.

Unfortunately, this [excluding pages](https://docs.astro.build/en/core-concepts/routing/#excluding-pages) feature is not supported. Please only keep pages in your pages directory.

You can still exclude pages prefixed with an underscore (`_`) by adding `pages/**/_*` to the ignore glob patterns:

```js
["pages/api/**/*", "pages/**/_*"];
```

#### Markdown

For `.md` and `.mdx`, use Astro [Content](https://docs.astro.build/en/guides/content-collections/#organizing-with-subdirectories) [Collections](https://docs.astro.build/en/recipes/i18n/#use-collections-for-translated-content).

With this library and Astro Content Collections, you can keep your Markdown separate and organized in `content`, while using `pages/blog/index.astro` and `pages/blog/[slug].astro` to render all of your content, even with a `defaultLocale`! Here is an example folder structure:

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

#### UI frameworks

Astro does not support `.tsx` or `.jsx` as page file types.

For UI frameworks like React and Vue, use them how you [normally](https://docs.astro.build/en/core-concepts/framework-components/) would with Astro by importing them as components.

Feel free to pass the translated content `title={t('title')}` or locale `locale={locale}` as props.

#### Endpoints

By default, all pages in `pages/api/**/*` are ignored.

For `.ts` and `.js` endpoints, how you handle multiple locales is up to you. As endpoints are not user-facing and there are many different ways to use endpoints, we leave the implementation up to your preferences.

## License

MIT Licensed

## Contributing

PRs welcome! Thank you for your help. Read more in the [contributing guide](https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/CONTRIBUTING.md) for reporting bugs and making PRs.
