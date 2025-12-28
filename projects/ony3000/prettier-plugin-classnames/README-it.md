<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

Un plugin di Prettier che suddivide nomi di classi verbosi in base all'opzione `printWidth`.

![Un caso d'uso per questo plugin.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Installazione[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Se la tua versione di `prettier-plugin-classnames` è inferiore alla `0.4.0`, sarà necessario installare anche `@prettier/sync`.

## Configurazione

Esempio JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Esempio JS (modulo CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Esempio JS (modulo ES):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## Opzioni

### Attributi Personalizzati

Elenco degli attributi che racchiudono i nomi delle classi.<br>
Gli attributi `class` e `className` sono sempre supportati, anche se non vengono specificate opzioni.

<!-- prettier-ignore -->
Default | Sostituzione&nbsp;CLI | Sostituzione&nbsp;API
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Funzioni Personalizzate

Elenco delle funzioni che racchiudono i nomi delle classi.<br>
La funzione `classNames` è sempre supportata, anche se non vengono specificate opzioni.

<!-- prettier-ignore -->
Default | Sostituzione&nbsp;CLI | Sostituzione&nbsp;API
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Posizione Finale

Disponibile per la prima volta dalla versione v0.5.0.<br>
`absolute-with-indent` è stato aggiunto nella versione v0.6.0.<br>
`absolute-with-indent` è stato rimosso nella versione v0.8.0, ma puoi ottenere lo stesso risultato con `absolute`.<br>
Il valore predefinito è cambiato da `relative` a `absolute` nella versione v0.8.0.

Questo è il criterio per terminare il nome della classe su ogni riga quando si sostituisce il nome della classe originale con un nome classe su più righe.

- Esempio di `absolute`:

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

- esempio di `relative`:

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
Default | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Trasformazione della Sintassi

Disponibile per la prima volta dalla versione v0.7.7.

Se si verifica un'interruzione di riga in un nome di classe scritto in sintassi non espressione, questo viene trasformato in sintassi espressione. Questa trasformazione non supporta la formattazione reversibile.

<!-- prettier-ignore -->
Default | CLI&nbsp;Override | API&nbsp;Override
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## Correlazione delle versioni con plugin correlati

A partire dalla versione `0.6.0`, quando c'è una release minore da una parte, ho intenzione di riflettere tale cambiamento anche dall'altra parte, se possibile.

![Correlazione delle versioni.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Compatibilità con altri plugin Prettier

Se più di un plugin Prettier è in grado di gestire il testo che desideri formattare, Prettier utilizzerà solo l'ultimo di questi plugin.

In questo caso, puoi configurarlo come segue aggiungendo [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) per applicare quei plugin in sequenza.

Esempio JSON:

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---