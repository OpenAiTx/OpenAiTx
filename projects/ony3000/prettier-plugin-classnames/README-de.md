<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

Ein Prettier-Plugin, das ausführliche Klassennamen basierend auf der `printWidth`-Option umbricht.

![Ein Anwendungsfall für dieses Plugin.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Installation[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Wenn Ihre Version von `prettier-plugin-classnames` kleiner als `0.4.0` ist, müssen Sie zusätzlich `@prettier/sync` installieren.

## Konfiguration

JSON-Beispiel:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS-Beispiel (CommonJS-Modul):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS-Beispiel (ES-Modul):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Markdown/MDX-Überschreibung

Dieses Plugin unterstützt Markdown und MDX nicht, aber wenn dieses Plugin eine Sprache innerhalb von Codeblöcken unterstützt (z. B. Vue), kann es zu unbeabsichtigter Formatierung innerhalb der Codeblöcke kommen.

Um unbeabsichtigte Formatierungen zu verhindern, können Sie Konfigurationsüberschreibungen für Markdown und MDX verwenden.

JSON-Beispiel:

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

## Optionen

### Benutzerdefinierte Attribute

Liste von Attributen, die umschließende Klassennamen enthalten.<br>
Die Attribute `class` und `className` werden immer unterstützt, auch wenn keine Optionen angegeben sind.

<!-- prettier-ignore -->
Standard | CLI-Überschreibung | API-Überschreibung
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Benutzerdefinierte Funktionen

Liste von Funktionen, die umschließende Klassennamen enthalten.<br>
Die Funktion `classNames` wird immer unterstützt, auch wenn keine Optionen angegeben sind.

<!-- prettier-ignore -->
Standard | CLI-Überschreibung | API-Überschreibung
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Endposition

Erstmals verfügbar in v0.5.0.<br>
`absolute-with-indent` wurde in v0.6.0 hinzugefügt.<br>
`absolute-with-indent` wurde in v0.8.0 entfernt, aber Sie können die gleiche Ausgabe mit `absolute` erhalten.<br>
Der Standardwert wurde in v0.8.0 von `relative` auf `absolute` geändert.

Dies ist das Kriterium für das Beenden des Klassennamens in jeder Zeile, wenn der ursprüngliche Klassenname durch einen mehrzeiligen Klassennamen ersetzt wird.

- Beispiel für `absolute`:

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

- Beispiel für `relative`:

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
Standard | CLI-Überschreibung | API-Überschreibung
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Syntaxumwandlung

Erstmals verfügbar in v0.7.7.

Wenn ein Zeilenumbruch in einem Klassennamen auftritt, der in nicht-ausdrucksbasiertem Syntax geschrieben wurde, wird er in ausdrucksbasierten Syntax umgewandelt. Diese Umwandlung unterstützt kein reversibles Formatieren.

<!-- prettier-ignore -->
Standard | CLI-Überschreibung | API-Überschreibung
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### Print-Breite der Klassennamen

Erstmals verfügbar in v0.10.0.

Geben Sie die Print-Breite des Klassennamens an. Wenn kein Wert angegeben wird, wird der Wert von `printWidth` als Standard verwendet.

<!-- prettier-ignore -->
Standard | CLI-Überschreibung | API-Überschreibung
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## Versionskorrelation mit verwandten Plugins

Ab Version `0.6.0` plane ich bei einer Minor-Version auf einer Seite, diese Änderung, wenn möglich, auch auf der anderen Seite zu übernehmen.

![Versionskorrelation.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Kompatibilität mit anderen Prettier-Plugins

Wenn mehr als ein Prettier-Plugin den zu formatierenden Text verarbeiten kann, verwendet Prettier nur das zuletzt geladene dieser Plugins.

In diesem Fall können Sie die Plugins nacheinander anwenden, indem Sie [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) hinzufügen und entsprechend konfigurieren.

JSON-Beispiel:

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