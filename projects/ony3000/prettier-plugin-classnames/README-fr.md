<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

Un plugin Prettier qui encapsule les noms de classes verbeux selon l’option `printWidth`.

![Un cas d’utilisation pour ce plugin.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Installation[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1] : Si votre version de `prettier-plugin-classnames` est inférieure à `0.4.0`, vous devrez également installer `@prettier/sync`.

## Configuration

Exemple JSON :

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Exemple JS (module CommonJS) :

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Exemple JS (module ES) :

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Substitution Markdown/MDX

Ce plugin ne prend pas en charge Markdown et MDX, mais si ce plugin prend en charge un langage à l'intérieur des blocs de code (par exemple, Vue), un formatage non souhaité peut se produire à l'intérieur des blocs de code.

Pour éviter un formatage non souhaité, vous pouvez utiliser des substitutions de configuration pour Markdown et MDX.

Exemple JSON :

```json
{
  "plugins": ["prettier-plugin-classnames"],
  "customFunctions": ["clsx"],
  "overrides": [
    {
      "files": ["*.md", "*.mdx"],
      "options": {
        "plugins": []
      }
    }
  ]
}
```

## Options

### Attributs personnalisés

Liste des attributs qui englobent les noms de classe.<br>
Les attributs `class` et `className` sont toujours pris en charge, même si aucune option n'est spécifiée.

<!-- prettier-ignore -->
Par défaut | Remplacement CLI | Remplacement API
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Fonctions personnalisées

Liste des fonctions qui englobent les noms de classe.<br>
La fonction `classNames` est toujours prise en charge, même si aucune option n'est spécifiée.

<!-- prettier-ignore -->
Par défaut | Remplacement CLI | Remplacement API
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Position de fin

Disponible pour la première fois en v0.5.0.<br>
`absolute-with-indent` a été ajouté en v0.6.0.<br>
`absolute-with-indent` a été supprimé en v0.8.0, mais vous pouvez obtenir la même sortie avec `absolute`.<br>
La valeur par défaut est passée de `relative` à `absolute` en v0.8.0.

Ceci est le critère pour terminer le nom de classe sur chaque ligne lors du remplacement du nom de classe original par un nom de classe multi-lignes.

- Exemple `absolute` :

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 dark:bg-neutral-900/50
          border border-zinc-400/30 dark:border-neutral-500/30
          rounded-xl px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

- Exemple `relative` :

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
       |------------------------------------------------------------|
        className="bg-gray-100/50 dark:bg-neutral-900/50 border
         |------------------------------------------------------------|
          border-zinc-400/30 dark:border-neutral-500/30 rounded-xl
          px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
Par défaut | Remplacement CLI&nbsp; | Remplacement API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Transformation de la syntaxe

Disponible à partir de la v0.7.7.

Si un retour à la ligne se produit dans un nom de classe écrit en syntaxe non-expression, il est transformé en syntaxe d'expression. Cette transformation ne prend pas en charge le formatage réversible.

<!-- prettier-ignore -->
Par défaut | Remplacement CLI&nbsp; | Remplacement API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### Largeur d’impression des noms de classes

Disponible à partir de la v0.10.0.

Spécifiez la largeur d’impression du nom de classe. Si aucune valeur n’est fournie, la valeur de `printWidth` est utilisée par défaut.

<!-- prettier-ignore -->
Par défaut | Remplacement CLI&nbsp; | Remplacement API&nbsp;
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## Corrélation de versions avec les plugins frères

À partir de la version `0.6.0`, lorsqu’il y a une version mineure d’un côté, je prévois de répercuter cette modification de l’autre côté également si possible.

![Corrélation de versions.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Compatibilité avec d’autres plugins Prettier

Si plusieurs plugins Prettier peuvent gérer le texte que vous souhaitez formater, Prettier n’utilisera que le dernier de ces plugins.

Dans ce cas, vous pouvez le configurer comme suit en ajoutant [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) pour appliquer ces plugins de manière séquentielle.

Exemple JSON :

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```

## Stargazers over time

[![Stargazers over time](https://starchart.cc/ony3000/prettier-plugin-classnames.svg?variant=adaptive)](https://starchart.cc/ony3000/prettier-plugin-classnames)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---