# `astro-i18n-aut` Astroのためのi18n統合 🧑‍🚀

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
  すべてのAstroクルーメイトのために❤️で作られました 🧑‍🚀
</p>

<p align="center">
  <a href="https://www.npmjs.com/package/astro-i18n-aut"><img src="https://img.shields.io/npm/dt/astro-i18n-aut.svg" alt="Total Downloads"></a>
  <!-- https://github.com/astro-i18n-aut/astro-i18n-aut/releases -->
  <a href="https://www.npmjs.com/package/astro-i18n-aut?activeTab=versions"><img src="https://img.shields.io/npm/v/astro-i18n-aut.svg" alt="Latest Release"></a>
  <a href="https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/LICENSE.md"><img src="https://img.shields.io/npm/l/astro-i18n-aut.svg" alt="License"></a>
</p>

---

## 動機

Astroのための国際化（i18n）統合を提供します：

- `defaultLocale`をサポート
- テンプレートファイルの重複を回避
- アダプターに依存しない
- UIフレームワークに依存しない
- [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap) と互換性あり

## クイックスタート

### インストール

[npm](https://www.npmjs.com/package/astro-i18n-aut)経由でインストール：

```shell
npm install astro-i18n-aut
```

### 設定

Astroの[設定](https://docs.astro.build/en/guides/configuring-astro/#supported-config-file-types)ファイルで:

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

あなたの `.gitignore` ファイルでは:

```gitignore
astro_tmp_pages_*
```

### 使用方法

設定が完了すると、各 `.astro` ページは他の言語でも追加のレンダリングが行われます。例えば、`src/pages/about.astro` は以下のようにレンダリングされます：

- `/about/`
- `/es/about/`
- `/fr/about/`

`redirectDefaultLocale`（デフォルトで `true`）を有効にしている場合、リダイレクトは以下のようになります：

- `/en/about/` => `/about/`

`getStaticPaths()` 関数は一度だけ実行されることに注意してください。この制限により、`/about/` に対する `/es/acerca-de/` のような翻訳されたURLは使用できません。ただし、これは [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap) との互換性を保証します。

Astro のフロントマターとページコンテンツは、翻訳された各ページごとに再実行されます。例えば、`Astro.url.pathname` は以下のようになります：

- `/about/`
- `/es/about/`
- `/fr/about/`

どの言語がレンダリングされているかの検出はあなた次第です。Astro の [コンテンツコレクション](https://docs.astro.build/en/guides/content-collections/) や、[`react-i18next`](https://www.npmjs.com/package/react-i18next) のような任意の i18n UI フレームワークを翻訳に利用できます。以下は純粋な `Hello World` の例です：

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

ロケールの扱いを容易にするためのいくつかのヘルパー関数が含まれています。

### Astro の設定オプション

詳細については公式の Astro ドキュメントをご覧ください：

- [`site`](https://docs.astro.build/en/reference/configuration-reference/#site)
- [`trailingSlash`](https://docs.astro.build/en/reference/configuration-reference/#trailingslash)
- [`format`](https://docs.astro.build/en/reference/configuration-reference/#buildformat)

いずれかを設定する必要があります：

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
これらのオプションはすべて関連しており、一緒に設定する必要があります。これらはあなたのURLが以下のいずれになるかに影響します：

- `/about/`
- `/about`

`/about/` を選択した場合、`/about` は404になり、その逆も同様です。

### 統合オプション

- `locales`：すべての言語ロケールのレコード。
- `defaultLocale`：デフォルトの言語ロケール。値は `locales` のキーに存在しなければなりません。
- `redirectDefaultLocale` - 例えば `defaultLocale: "en"` の場合、`/en/about/` が `/about/` にリダイレクトされるかどうか（デフォルト：`308`）。
- `include`：含めるグロブパターン（デフォルト：`["pages/**/*"]`）。
- `exclude`：除外するグロブパターン（デフォルト：`["pages/api/**/*"]`）。

### 互換性

#### ページファイルタイプ

その他の Astro ページファイルタイプ：

- ✅ `.astro`
- ❌ `.md`
- ❌ `.mdx`（MDX統合がインストールされている場合）
- ❌ `.html`
- ❌ `.js` / `.ts`（エンドポイントとして）

は翻訳できません。`pages` ディレクトリでこれらを使用する場合は、無視するグロブパターンに追加してください。例えば：


```js
["pages/api/**/*", "pages/**/*.md"];
```

#### ページの除外

Astroの[ドキュメント](https://docs.astro.build/en/core-concepts/routing/#excluding-pages)には次のように記載されています：

> ページやディレクトリの名前の先頭にアンダースコア（_）を付けることで、それらをビルドから除外できます。_で始まるファイルはルーターに認識されず、dist/ディレクトリに配置されません。
>
> これを使ってページを一時的に無効にしたり、テスト、ユーティリティ、コンポーネントを関連するページと同じフォルダに置くことができます。

残念ながら、この[ページ除外](https://docs.astro.build/en/core-concepts/routing/#excluding-pages)機能はサポートされていません。ページディレクトリにはページのみを配置してください。

アンダースコア（`_`）で始まるページは、`pages/**/_*` を無視するグロブパターンに追加することで除外できます：

```js
["pages/api/**/*", "pages/**/_*"];
```

#### Markdown

`.md` と `.mdx` には、Astro の [Content](https://docs.astro.build/en/guides/content-collections/#organizing-with-subdirectories) [Collections](https://docs.astro.build/en/recipes/i18n/#use-collections-for-translated-content) を使用します。

このライブラリと Astro Content Collections を使うことで、Markdown を `content` に分けて整理しつつ、`pages/blog/index.astro` と `pages/blog/[slug].astro` を使って、`defaultLocale` があってもすべてのコンテンツをレンダリングできます。以下はフォルダ構成の例です：

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

#### UIフレームワーク

Astroはページファイルタイプとして`.tsx`や`.jsx`をサポートしていません。

ReactやVueのようなUIフレームワークは、Astroで[通常通り](https://docs.astro.build/en/core-concepts/framework-components/)コンポーネントとしてインポートして使用してください。

翻訳された内容`title={t('title')}`やロケール`locale={locale}`をpropsとして渡しても構いません。

#### エンドポイント

デフォルトでは、`pages/api/**/*`内のすべてのページは無視されます。

`.ts`および`.js`のエンドポイントでは、複数のロケールの処理方法は任意です。エンドポイントはユーザー向けではなく、使用方法も多様なため、実装はお好みにお任せします。

## ライセンス

MITライセンス

## コントリビュート

PR歓迎！ご協力ありがとうございます。バグ報告やPR作成については[コントリビュートガイド](https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/CONTRIBUTING.md)をご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---