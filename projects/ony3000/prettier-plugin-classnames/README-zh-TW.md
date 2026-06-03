<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">簡體中文</a>
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

一個 Prettier 外掛，可依據 `printWidth` 選項自動換行冗長的 class 名稱。

![此外掛的使用案例。](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## 安裝[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: 如果您的 `prettier-plugin-classnames` 版本低於 `0.4.0`，您還需要安裝 `@prettier/sync`。

## 設定

JSON 範例：

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS 範例（CommonJS 模組）：

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS 範例（ES 模組）：

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Markdown/MDX 覆寫

此外掛不支援 Markdown 和 MDX，但如果此外掛支援程式碼區塊內的語言（如 Vue），可能會導致程式碼區塊內出現非預期的格式化。

為了防止非預期的格式化，你可以為 Markdown 和 MDX 使用組態覆寫。

JSON 範例：

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

## 選項

### 自訂屬性

包含類名的屬性列表。<br>
即使未指定任何選項，也始終支援 `class` 和 `className` 屬性。

<!-- prettier-ignore -->
預設值 | CLI 覆寫 | API 覆寫
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### 自訂函式

包含類名的函式列表。<br>
即使未指定任何選項，也始終支援 `classNames` 函式。

<!-- prettier-ignore -->
預設值 | CLI 覆寫 | API 覆寫
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### 結尾位置

首次於 v0.5.0 提供。<br>
`absolute-with-indent` 於 v0.6.0 新增。<br>
`absolute-with-indent` 於 v0.8.0 移除，但你可以使用 `absolute` 取得相同輸出。<br>
預設值在 v0.8.0 從 `relative` 改為 `absolute`。

這是當用多行類名取代原本類名時，每行類名的結尾判斷標準。

- `absolute` 範例：

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

- `relative` 範例：

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
預設值 | CLI 覆蓋 | API 覆蓋
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### 語法轉換

首次於 v0.7.7 提供。

如果在非表達式語法撰寫的類名發生換行，將會轉換為表達式語法。此轉換不支援可逆格式化。

<!-- prettier-ignore -->
預設值 | CLI 覆蓋 | API 覆蓋
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### 類名列印寬度

首次於 v0.10.0 提供。

指定類名的列印寬度。若未提供數值，則預設使用 `printWidth` 的值。

<!-- prettier-ignore -->
預設值 | CLI 覆蓋 | API 覆蓋
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## 與兄弟插件的版本相關性

從 `0.6.0` 開始，當其中一端有次版本釋出時，我會盡可能在另一端反映該變更。

![版本相關性。](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## 與其他 Prettier 插件的相容性

若有多個 Prettier 插件可以處理您要格式化的文字，Prettier 只會使用這些插件中的最後一個。

在此情況下，您可以透過新增 [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) 來依序套用這些插件，配置方式如下。

JSON 範例：

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