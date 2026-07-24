# `astro-i18n-aut` La integración i18n para Astro 🧑‍🚀

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
  Construido con ❤️ para todos los compañeros de Astro 🧑‍🚀
</p>

<p align="center">
  <a href="https://www.npmjs.com/package/astro-i18n-aut"><img src="https://img.shields.io/npm/dt/astro-i18n-aut.svg" alt="Descargas Totales"></a>
  <!-- https://github.com/astro-i18n-aut/astro-i18n-aut/releases -->
  <a href="https://www.npmjs.com/package/astro-i18n-aut?activeTab=versions"><img src="https://img.shields.io/npm/v/astro-i18n-aut.svg" alt="Última Versión"></a>
  <a href="https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/LICENSE.md"><img src="https://img.shields.io/npm/l/astro-i18n-aut.svg" alt="Licencia"></a>
</p>

---

## Motivación

Proporcionar una integración de internacionalización (i18n) para Astro que:

- Soporte el `defaultLocale`
- Evite la duplicación de archivos de plantilla
- Sea independiente del adaptador
- Sea independiente del framework de UI
- Sea compatible con [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap)

## Inicio rápido

### Instalación

Instalar vía [npm](https://www.npmjs.com/package/astro-i18n-aut):

```shell
npm install astro-i18n-aut
```

### Configurar

En tu archivo de [configuración](https://docs.astro.build/en/guides/configuring-astro/#supported-config-file-types) de Astro:

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

En tu archivo `.gitignore`:

```gitignore
astro_tmp_pages_*
```

### Uso

Ahora que ha configurado el archivo, cada página `.astro` tendrá representaciones adicionales con sus otros idiomas. Por ejemplo, `src/pages/about.astro` se renderizará como:

- `/about/`
- `/es/about/`
- `/fr/about/`

Si ha activado `redirectDefaultLocale` (verdadero por defecto), las redirecciones serán:

- `/en/about/` => `/about/`

Tenga en cuenta que la función `getStaticPaths()` solo se ejecutará una vez. Esta limitación significa que no puede tener URLs traducidas, como `/es/acerca-de/` para `/about/`. Sin embargo, también garantiza la compatibilidad con [`@astrojs/sitemap`](https://www.npmjs.com/package/@astrojs/sitemap).

El frontmatter y el contenido de la página de Astro se vuelven a ejecutar para cada página traducida. Por ejemplo, el `Astro.url.pathname` será:

- `/about/`
- `/es/about/`
- `/fr/about/`

Depende de usted detectar qué idioma se está renderizando. Puede usar las [colecciones de contenido](https://docs.astro.build/en/guides/content-collections/) de Astro o cualquier marco de interfaz de usuario i18n, como [`react-i18next`](https://www.npmjs.com/package/react-i18next), para sus traducciones. Aquí hay un ejemplo puro de `Hello World`:

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

Se incluyen varias funciones auxiliares para facilitar el manejo de locales.

### Opciones de configuración de Astro

Por favor, consulte la documentación oficial de Astro para más detalles:

- [`site`](https://docs.astro.build/en/reference/configuration-reference/#site)
- [`trailingSlash`](https://docs.astro.build/en/reference/configuration-reference/#trailingslash)
- [`format`](https://docs.astro.build/en/reference/configuration-reference/#buildformat)

Debe configurar uno de los siguientes:

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

Todas estas opciones están relacionadas y deben configurarse juntas. Afectan si tus URLs son:

- `/about/`
- `/about`

Si eliges `/about/`, entonces `/about` dará un error 404 y viceversa.

### Opciones de integración

- `locales`: Un registro de todos los locales de idioma.
- `defaultLocale`: El locale de idioma predeterminado. El valor debe estar presente en las claves de `locales`.
- `redirectDefaultLocale` - Suponiendo que `defaultLocale: "en"`, si `/en/about/` redirige a `/about/` (por defecto: `308`).
- `include`: Patrón(es) glob para incluir (por defecto: `["pages/**/*"]`).
- `exclude`: Patrón(es) glob para excluir (por defecto: `["pages/api/**/*"]`).

### Compatibilidad

#### Tipos de archivos de página

Otros tipos de archivos de página de Astro:

- ✅ `.astro`
- ❌ `.md`
- ❌ `.mdx` (con la integración MDX instalada)
- ❌ `.html`
- ❌ `.js` / `.ts` (como endpoints)

no pueden ser traducidos. Si decides usarlos en el directorio `pages`, por favor añádelos a los patrones glob de exclusión. Por ejemplo:

```js
["pages/api/**/*", "pages/**/*.md"];
```

#### Exclusión de páginas

En Astro, la [documentación](https://docs.astro.build/en/core-concepts/routing/#excluding-pages) indica:

> Puedes excluir páginas o directorios de la compilación prefixando sus nombres con un guion bajo (_). Los archivos con el prefijo _ no serán reconocidos por el enrutador ni se colocarán en el directorio dist/.
>
> Puedes usar esto para deshabilitar temporalmente páginas, y también para poner pruebas, utilidades y componentes en la misma carpeta que sus páginas relacionadas.

Desafortunadamente, esta función de [exclusión de páginas](https://docs.astro.build/en/core-concepts/routing/#excluding-pages) no está soportada. Por favor, mantén solo páginas en tu directorio de páginas.

Aún puedes excluir páginas con prefijo guion bajo (`_`) agregando `pages/**/_*` a los patrones glob de ignorar:

```js
["pages/api/**/*", "pages/**/_*"];
```

#### Markdown

Para `.md` y `.mdx`, use las [Colecciones](https://docs.astro.build/en/recipes/i18n/#use-collections-for-translated-content) de [Contenido](https://docs.astro.build/en/guides/content-collections/#organizing-with-subdirectories) de Astro.

Con esta biblioteca y las Colecciones de Contenido de Astro, puede mantener su Markdown separado y organizado en `content`, mientras usa `pages/blog/index.astro` y `pages/blog/[slug].astro` para renderizar todo su contenido, ¡incluso con un `defaultLocale`! Aquí hay un ejemplo de estructura de carpetas:

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
#### Frameworks de UI

Astro no soporta `.tsx` o `.jsx` como tipos de archivo para páginas.

Para frameworks de UI como React y Vue, úsalos como [normalmente](https://docs.astro.build/en/core-concepts/framework-components/) lo harías con Astro importándolos como componentes.

Siéntete libre de pasar el contenido traducido `title={t('title')}` o la configuración regional `locale={locale}` como props.

#### Endpoints

Por defecto, todas las páginas en `pages/api/**/*` son ignoradas.

Para endpoints `.ts` y `.js`, cómo manejar múltiples configuraciones regionales depende de ti. Como los endpoints no están orientados al usuario y hay muchas formas diferentes de usar endpoints, dejamos la implementación a tu preferencia.

## Licencia

Licenciado bajo MIT

## Contribuciones

¡PRs bienvenidos! Gracias por tu ayuda. Lee más en la [guía de contribución](https://github.com/jlarmstrongiv/astro-i18n-aut/blob/main/CONTRIBUTING.md) para reportar errores y hacer PRs.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---