# `astro-i18n-aut` L’intégration i18n pour Astro 🧑‍🚀

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
  Construit avec ❤️ pour tous les membres de l’équipage Astro 🧑‍🚀
</p>

<p align="center">
  <a href="https://www.npmjs.com/package/astro-i18n-aut"><img src="https://img.shields.io/npm/dt/astro-i18n-aut.svg" alt="Total des téléchargements"></a>
  <!-- https://github.com/astro-i18n-aut/astro-i18n-aut/releases -->
  <a href="https://www.npmjs.com/package/astro-i18n-aut?activeTab=versions"><img src="https://img.shields.io/npm/v/astro-i18n-aut.svg" alt="Dernière version"></a>
  <a href="https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/LICENSE.md"><img src="https://img.shields.io/npm/l/astro-i18n-aut.svg" alt="Licence"></a>
</p>

---

## Motivation

Fournir une intégration d’internationalisation (i18n) pour Astro qui :

- Prend en charge le `defaultLocale`
- Évite la duplication des fichiers de template
- Est indépendante de l’adaptateur
- Est indépendante du framework UI
- Est compatible avec [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap)

## Démarrage rapide

### Installer

Installer via [npm](https://www.npmjs.com/package/astro-i18n-aut) :

```shell
npm install astro-i18n-aut
```

### Configurer

Dans votre fichier [config](https://docs.astro.build/en/guides/configuring-astro/#supported-config-file-types) Astro :

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

Dans votre fichier `.gitignore` :

```gitignore
astro_tmp_pages_*
```
### Utilisation

Maintenant que vous avez configuré le fichier, chaque page `.astro` aura des rendus supplémentaires avec vos autres langues. Par exemple, `src/pages/about.astro` sera rendu comme :

- `/about/`
- `/es/about/`
- `/fr/about/`

Si vous avez activé `redirectDefaultLocale` (`true` par défaut), les redirections seront :

- `/en/about/` => `/about/`

Veuillez noter que la fonction `getStaticPaths()` ne s'exécutera qu'une seule fois. Cette limitation signifie que vous ne pouvez pas avoir d’URL traduites, telles que `/es/acerca-de/` pour `/about/`. Cependant, cela garantit également la compatibilité avec [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap).

Le frontmatter Astro et le contenu de la page sont réexécutés pour chaque page traduite. Par exemple, `Astro.url.pathname` sera :

- `/about/`
- `/es/about/`
- `/fr/about/`

Il vous appartient de détecter la langue qui est rendue. Vous pouvez utiliser les [collections de contenu](https://docs.astro.build/en/guides/content-collections/) Astro ou tout framework i18n UI, comme [`react-i18next`](https://www.npmjs.com/package/react-i18next), pour vos traductions. Voici un exemple simple de `Hello World` :


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
Plusieurs fonctions utilitaires sont incluses pour faciliter la gestion des paramètres régionaux.

### Options de configuration Astro

Veuillez consulter la documentation officielle d'Astro pour plus de détails :

- [`site`](https://docs.astro.build/en/reference/configuration-reference/#site)
- [`trailingSlash`](https://docs.astro.build/en/reference/configuration-reference/#trailingslash)
- [`format`](https://docs.astro.build/en/reference/configuration-reference/#buildformat)

Vous devez définir soit :

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

Toutes ces options sont liées et doivent être définies ensemble. Elles affectent si vos URL sont :

- `/about/`
- `/about`

Si vous choisissez `/about/`, alors `/about` renverra une erreur 404 et vice versa.

### Options d'intégration

- `locales` : Un enregistrement de toutes les locales linguistiques.
- `defaultLocale` : La locale linguistique par défaut. La valeur doit être présente dans les clés de `locales`.
- `redirectDefaultLocale` - En supposant `defaultLocale: "en"`, si `/en/about/` redirige vers `/about/` (par défaut : `308`).
- `include` : Motif(s) glob à inclure (par défaut : `["pages/**/*"]`).
- `exclude` : Motif(s) glob à exclure (par défaut : `["pages/api/**/*"]`).

### Compatibilité

#### Types de fichiers de page

Autres types de fichiers de page Astro :

- ✅ `.astro`
- ❌ `.md`
- ❌ `.mdx` (avec l’intégration MDX installée)
- ❌ `.html`
- ❌ `.js` / `.ts` (en tant que points de terminaison)

ne peuvent pas être traduits. Si vous choisissez de les utiliser dans le répertoire `pages`, veuillez les ajouter aux motifs glob à ignorer. Par exemple :

```js
["pages/api/**/*", "pages/**/*.md"];
```

#### Exclusion de pages

Dans Astro, la [documentation](https://docs.astro.build/en/core-concepts/routing/#excluding-pages) indique :

> Vous pouvez exclure des pages ou des répertoires de la construction en préfixant leurs noms par un underscore (_). Les fichiers avec le préfixe _ ne seront pas reconnus par le routeur et ne seront pas placés dans le répertoire dist/.
>
> Vous pouvez utiliser cela pour désactiver temporairement des pages, et aussi pour mettre des tests, utilitaires et composants dans le même dossier que leurs pages associées.

Malheureusement, cette fonctionnalité [exclusion de pages](https://docs.astro.build/en/core-concepts/routing/#excluding-pages) n’est pas prise en charge. Veuillez ne conserver que des pages dans votre répertoire pages.

Vous pouvez toujours exclure les pages préfixées par un underscore (`_`) en ajoutant `pages/**/_*` aux motifs globaux d’ignorance :

```js
["pages/api/**/*", "pages/**/_*"];
```

#### Markdown

Pour les fichiers `.md` et `.mdx`, utilisez les [Collections](https://docs.astro.build/en/recipes/i18n/#use-collections-for-translated-content) [Content](https://docs.astro.build/en/guides/content-collections/#organizing-with-subdirectories) d’Astro.

Avec cette bibliothèque et les Collections Astro Content, vous pouvez garder votre Markdown séparé et organisé dans `content`, tout en utilisant `pages/blog/index.astro` et `pages/blog/[slug].astro` pour afficher tout votre contenu, même avec un `defaultLocale` ! Voici un exemple de structure de dossier :

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

#### Frameworks UI

Astro ne prend pas en charge les fichiers de page `.tsx` ou `.jsx`.

Pour les frameworks UI comme React et Vue, utilisez-les comme vous le [feriez normalement](https://docs.astro.build/en/core-concepts/framework-components/) avec Astro en les important comme composants.

N’hésitez pas à passer le contenu traduit `title={t('title')}` ou la locale `locale={locale}` en tant que props.

#### Endpoints

Par défaut, toutes les pages dans `pages/api/**/*` sont ignorées.

Pour les endpoints `.ts` et `.js`, la gestion des multiples locales dépend de vous. Comme les endpoints ne sont pas destinés aux utilisateurs finaux et qu’il existe de nombreuses façons de les utiliser, nous laissons l’implémentation à votre appréciation.

## Licence

Licence MIT

## Contribution

Les PR sont les bienvenues ! Merci pour votre aide. Lisez plus dans le [guide de contribution](https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/CONTRIBUTING.md) pour signaler des bugs et faire des PR.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---