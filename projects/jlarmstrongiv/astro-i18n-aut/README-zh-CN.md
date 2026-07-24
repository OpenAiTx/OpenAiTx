# `astro-i18n-aut` Astro 的国际化集成 🧑‍🚀

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
  为所有 Astro 乘员倾心打造 ❤️ 🧑‍🚀
</p>

<p align="center">
  <a href="https://www.npmjs.com/package/astro-i18n-aut"><img src="https://img.shields.io/npm/dt/astro-i18n-aut.svg" alt="总下载量"></a>
  <!-- https://github.com/astro-i18n-aut/astro-i18n-aut/releases -->
  <a href="https://www.npmjs.com/package/astro-i18n-aut?activeTab=versions"><img src="https://img.shields.io/npm/v/astro-i18n-aut.svg" alt="最新版本"></a>
  <a href="https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/LICENSE.md"><img src="https://img.shields.io/npm/l/astro-i18n-aut.svg" alt="许可协议"></a>
</p>

---

## 动机

为 Astro 提供一个国际化（i18n）集成，要求：

- 支持 `defaultLocale`
- 避免模板文件重复
- 适配器无关
- UI 框架无关
- 兼容 [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap)

## 快速开始

### 安装

通过 [npm](https://www.npmjs.com/package/astro-i18n-aut) 安装：

```shell
npm install astro-i18n-aut
```

### 配置

在您的 Astro [配置](https://docs.astro.build/en/guides/configuring-astro/#supported-config-file-types) 文件中：

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

在你的 `.gitignore` 文件中：

```gitignore
astro_tmp_pages_*
```

### 使用方法

既然您已经设置了配置，每个 `.astro` 页面将额外渲染其他语言版本。例如，`src/pages/about.astro` 将渲染为：

- `/about/`
- `/es/about/`
- `/fr/about/`

如果您启用了 `redirectDefaultLocale`（默认值为 `true`），重定向将是：

- `/en/about/` => `/about/`

请注意，`getStaticPaths()` 函数只会运行一次。此限制意味着您不能拥有翻译后的 URL，例如 `/es/acerca-de/` 对应 `/about/`。但这也确保了与 [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap) 的兼容性。

Astro 的 frontmatter 和页面内容会为每个翻译页面重新运行。例如，`Astro.url.pathname` 将是：

- `/about/`
- `/es/about/`
- `/fr/about/`

检测正在渲染的语言由您决定。您可以使用 Astro 的 [内容集合](https://docs.astro.build/en/guides/content-collections/) 或任何国际化 UI 框架，如 [`react-i18next`](https://www.npmjs.com/package/react-i18next)，来处理翻译。以下是一个纯粹的 `Hello World` 示例：

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
几个辅助函数被包含进来以便更容易地处理区域设置。

### Astro 配置选项

请参阅官方 Astro 文档了解更多细节：

- [`site`](https://docs.astro.build/en/reference/configuration-reference/#site)
- [`trailingSlash`](https://docs.astro.build/en/reference/configuration-reference/#trailingslash)
- [`format`](https://docs.astro.build/en/reference/configuration-reference/#buildformat)

您必须设置以下之一：

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
所有这些选项都是相关的，必须一起设置。它们影响您的 URL 是否为：

- `/about/`
- `/about`

如果您选择 `/about/`，那么 `/about` 将返回 404，反之亦然。

### 集成选项

- `locales`：所有语言区域的记录。
- `defaultLocale`：默认语言区域。该值必须存在于 `locales` 的键中。
- `redirectDefaultLocale` - 假设 `defaultLocale: "en"`，是否将 `/en/about/` 重定向到 `/about/`（默认：`308`）。
- `include`：包含的通配符模式（默认：`["pages/**/*"]`）。
- `exclude`：排除的通配符模式（默认：`["pages/api/**/*"]`）。

### 兼容性

#### 页面文件类型

其他 Astro 页面文件类型：

- ✅ `.astro`
- ❌ `.md`
- ❌ `.mdx`（安装 MDX 集成时）
- ❌ `.html`
- ❌ `.js` / `.ts`（作为端点）

不能被翻译。如果您选择在 `pages` 目录中使用它们，请将它们添加到忽略的通配符模式中。例如：


```js
["pages/api/**/*", "pages/**/*.md"];
```

#### 排除页面

在 Astro 中，[文档](https://docs.astro.build/en/core-concepts/routing/#excluding-pages)说明：

> 你可以通过在页面或目录名前加下划线（_）来排除它们的构建。带有 _ 前缀的文件不会被路由器识别，也不会被放入 dist/ 目录中。
>
> 你可以用此方法临时禁用页面，也可以将测试、工具和组件放在与其相关页面相同的文件夹中。

不幸的是，这个[排除页面](https://docs.astro.build/en/core-concepts/routing/#excluding-pages)功能尚不支持。请仅保留页面目录中的页面。

你仍然可以通过在忽略的 glob 模式中添加 `pages/**/_*` 来排除带有下划线（`_`）前缀的页面：

```js
["pages/api/**/*", "pages/**/_*"];
```

#### Markdown

对于 `.md` 和 `.mdx`，使用 Astro [Content](https://docs.astro.build/en/guides/content-collections/#organizing-with-subdirectories) [Collections](https://docs.astro.build/en/recipes/i18n/#use-collections-for-translated-content)。

通过此库和 Astro Content Collections，您可以将 Markdown 保持在 `content` 文件夹中独立且有序，同时使用 `pages/blog/index.astro` 和 `pages/blog/[slug].astro` 来渲染所有内容，即使使用了 `defaultLocale`！以下是示例文件夹结构：

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

#### UI 框架

Astro 不支持将 `.tsx` 或 `.jsx` 用作页面文件类型。

对于像 React 和 Vue 这样的 UI 框架，按照你[通常](https://docs.astro.build/en/core-concepts/framework-components/)使用 Astro 的方式将它们作为组件导入即可。

可以随意将翻译后的内容 `title={t('title')}` 或语言环境 `locale={locale}` 作为属性传递。

#### 端点

默认情况下，`pages/api/**/*` 中的所有页面都会被忽略。

对于 `.ts` 和 `.js` 端点，如何处理多语言环境由你决定。由于端点不面向用户，且使用端点的方式多种多样，我们将实现方式留给你自行选择。

## 许可证

MIT 许可证

## 贡献

欢迎提交 PR！感谢你的帮助。有关报告错误和提交 PR 的更多信息，请阅读[贡献指南](https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/CONTRIBUTING.md)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---