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

- `relative` 範例：

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
預設值 | CLI 覆寫 | API 覆寫
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### 語法轉換

首次於 v0.7.7 提供。

如果在以非運算式語法撰寫的類別名稱中發生換行，則會將其轉換為運算式語法。此轉換不支援可逆格式化。

<!-- prettier-ignore -->
預設值 | CLI 覆寫 | API 覆寫
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## 與同類外掛的版本對應關係

自 `0.6.0` 起，當其中一方有次要版本釋出時，若可能，計畫於另一方也反映該變更。

![版本對應關係。](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## 與其他 Prettier 外掛的相容性

若有多個 Prettier 外掛可處理您要格式化的文字，Prettier 只會使用最後一個外掛。

此時，您可透過加入 [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) 來依序套用這些外掛，設定方式如下。

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


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---