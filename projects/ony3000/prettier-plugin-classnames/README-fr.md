# prettier-plugin-classnames

Un plugin Prettier qui enveloppe les noms de classe verbeux en fonction de l'option `printWidth`.

![Un cas d'utilisation de ce plugin.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

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
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 border
          border-zinc-400/30 dark:bg-neutral-900/50
          dark:border-neutral-500/30 px-4 py-4
          rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

- Exemple `relative` :

  ```
  --------------------------------------------------| printWidth=50
  export function Callout({ children }) {
    return (
      <div
                  |--------------------------------------------------|
        className="bg-gray-100/50 border border-zinc-400/30
         |--------------------------------------------------|
          dark:bg-neutral-900/50 dark:border-neutral-500/30
          px-4 py-4 rounded-xl"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
Par défaut | Surcharge CLI&nbsp; | Surcharge API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Transformation de syntaxe

Disponible pour la première fois en v0.7.7.

Si un retour à la ligne se produit dans un nom de classe écrit en syntaxe non-expression, il est transformé en syntaxe expression. Cette transformation ne supporte pas la mise en forme réversible.

<!-- prettier-ignore -->
Par défaut | Surcharge CLI&nbsp; | Surcharge API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## Corrélation de version avec les plugins associés

À partir de `0.6.0`, lorsqu’une version mineure est publiée d’un côté, je prévois de refléter ce changement de l’autre côté si possible.

![Corrélation de version.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Compatibilité avec d’autres plugins Prettier

Si plusieurs plugins Prettier peuvent gérer le texte que vous souhaitez formater, Prettier n’utilisera que le dernier de ces plugins.

Dans ce cas, vous pouvez configurer comme suit en ajoutant [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) pour appliquer ces plugins séquentiellement.

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


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-02

---