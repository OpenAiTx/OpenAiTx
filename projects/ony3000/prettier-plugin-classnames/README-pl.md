<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Wtyczka Prettier, która zawija zbyt długie nazwy klas na podstawie opcji `printWidth`.

![Przykładowe zastosowanie tej wtyczki.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Instalacja[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Jeśli Twoja wersja `prettier-plugin-classnames` jest niższa niż `0.4.0`, będziesz musiał również zainstalować `@prettier/sync`.

## Konfiguracja

Przykład JSON:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

Przykład JS (moduł CommonJS):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

Przykład JS (moduł ES):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Nadpisanie Markdown/MDX

Ta wtyczka nie obsługuje Markdown ani MDX, ale jeśli obsługuje język wewnątrz bloków kodu (np. Vue), może wystąpić niezamierzone formatowanie wewnątrz tych bloków.

Aby zapobiec niezamierzonemu formatowaniu, możesz użyć nadpisania konfiguracji dla Markdown i MDX.

Przykład JSON:

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

## Opcje

### Atrybuty niestandardowe

Lista atrybutów, które zamykają nazwy klas.<br>
Atrybuty `class` i `className` są zawsze obsługiwane, nawet jeśli nie określono żadnych opcji.

<!-- prettier-ignore -->
Domyślne | Nadpisanie CLI&nbsp; | Nadpisanie API&nbsp;
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Funkcje niestandardowe

Lista funkcji, które zamykają nazwy klas.<br>
Funkcja `classNames` jest zawsze obsługiwana, nawet jeśli nie określono żadnych opcji.

<!-- prettier-ignore -->
Domyślne | Nadpisanie CLI&nbsp; | Nadpisanie API&nbsp;
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Pozycja końcowa

Po raz pierwszy dostępne w wersji v0.5.0.<br>
`absolute-with-indent` zostało dodane w wersji v0.6.0.<br>
`absolute-with-indent` zostało usunięte w wersji v0.8.0, ale ten sam wynik można uzyskać za pomocą `absolute`.<br>
Wartość domyślna została zmieniona z `relative` na `absolute` w wersji v0.8.0.

To jest kryterium kończenia nazwy klasy w każdej linii podczas zamiany oryginalnej nazwy klasy na wieloliniową nazwę klasy.

- przykład `absolute`:

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

- Przykład `relative`:

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
Domyślne | Nadpisanie CLI&nbsp; | Nadpisanie API&nbsp;
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Transformacja składni

Po raz pierwszy dostępne w wersji v0.7.7.

Jeśli występuje zawijanie linii w nazwie klasy zapisanej w składni nie-wyrażeniowej, zostaje ona przekształcona w składnię wyrażeniową. Ta transformacja nie obsługuje odwracalnego formatowania.

<!-- prettier-ignore -->
Domyślne | Nadpisanie CLI&nbsp; | Nadpisanie API&nbsp;
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### Szerokość druku nazw klas

Po raz pierwszy dostępne w wersji v0.10.0.

Określ szerokość druku dla nazwy klasy. Jeśli nie zostanie podana wartość, jako domyślna zostanie użyta wartość `printWidth`.

<!-- prettier-ignore -->
Domyślne | Nadpisanie CLI&nbsp; | Nadpisanie API&nbsp;
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## Korelacja wersji z pokrewnymi pluginami

Od wersji `0.6.0`, gdy pojawia się wydanie typu minor po jednej stronie, planuję odzwierciedlić tę zmianę po drugiej stronie również, jeśli to możliwe.

![Korelacja wersji.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Kompatybilność z innymi pluginami Prettier

Jeśli więcej niż jeden plugin Prettier może obsłużyć tekst, który chcesz sformatować, Prettier użyje tylko ostatniego z tych pluginów.

W takim przypadku możesz skonfigurować to w następujący sposób, dodając [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge), aby zastosować te pluginy kolejno.

Przykład JSON:

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