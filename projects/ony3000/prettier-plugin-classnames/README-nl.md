
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

Een Prettier-plugin die lange klassenamen afbreekt op basis van de `printWidth`-optie.

![Een toepassingsvoorbeeld van deze plugin.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Installatie[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Als uw versie van `prettier-plugin-classnames` lager is dan `0.4.0`, moet u ook `@prettier/sync` installeren.

## Configuratie

JSON-voorbeeld:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS-voorbeeld (CommonJS-module):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS-voorbeeld (ES-module):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## Opties

### Aangepaste Attributen

Lijst van attributen die omliggende klassennamen bevatten.<br>
De attributen `class` en `className` worden altijd ondersteund, zelfs als er geen opties zijn opgegeven.

<!-- prettier-ignore -->
Standaard | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Aangepaste Functies

Lijst van functies die omliggende klassennamen bevatten.<br>
De functie `classNames` wordt altijd ondersteund, zelfs als er geen opties zijn opgegeven.

<!-- prettier-ignore -->
Standaard | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Eindpositie

Eerst beschikbaar in v0.5.0.<br>
`absolute-with-indent` werd toegevoegd in v0.6.0.<br>
`absolute-with-indent` werd verwijderd in v0.8.0, maar je kunt dezelfde uitvoer krijgen met `absolute`.<br>
Standaardwaarde veranderd van `relative` naar `absolute` in v0.8.0.

Dit is het criterium voor het beëindigen van de klassenaam op elke regel wanneer de originele klassenaam wordt vervangen door een meerregelige klassenaam.

- `absolute` voorbeeld:

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

- `relative` voorbeeld:

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
Standaard | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Syntaxistransformatie

Eerst beschikbaar in v0.7.7.

Als een regelomloop optreedt in een classnaam geschreven in niet-expressie syntaxis, wordt deze getransformeerd naar expressie syntaxis. Deze transformatie ondersteunt geen omkeerbare opmaak.

<!-- prettier-ignore -->
Standaard | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## Versiecorrelatie met zuster-plugins

Vanaf versie `0.6.0`, wanneer er een minor release is aan de ene kant, ben ik van plan die wijziging indien mogelijk ook aan de andere kant te reflecteren.

![Versiecorrelatie.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Compatibiliteit met andere Prettier-plugins

Als meer dan één Prettier-plugin de tekst die je wilt formatteren kan verwerken, zal Prettier alleen de laatste van die plugins gebruiken.

In dat geval kun je het als volgt configureren door [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) toe te voegen om die plugins opeenvolgend toe te passen.

JSON-voorbeeld:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---