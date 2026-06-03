<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

`printWidth` オプションに基づき冗長なクラス名を折り返す Prettier プラグインです。

![このプラグインの利用例。](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## インストール方法[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: `prettier-plugin-classnames` のバージョンが `0.4.0` 未満の場合は、`@prettier/sync` もインストールする必要があります。

## 設定

JSON の例:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JSの例（CommonJSモジュール）:

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS例（ESモジュール）:

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Markdown/MDX オーバーライド

このプラグインはMarkdownおよびMDXをサポートしていませんが、もしこのプラグインがコードブロック内の言語（例：Vue）をサポートしている場合、コードブロック内で意図しない書式設定が発生することがあります。

意図しない書式設定を防ぐために、MarkdownおよびMDX用の設定オーバーライドを使用できます。

JSON例:

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
## オプション

### カスタム属性

囲むクラス名の属性のリスト。<br>
`class` と `className` 属性は、オプションが指定されていなくても常にサポートされます。

<!-- prettier-ignore -->
デフォルト | CLI上書き | API上書き
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### カスタム関数

囲むクラス名の関数のリスト。<br>
`classNames` 関数は、オプションが指定されていなくても常にサポートされます。

<!-- prettier-ignore -->
デフォルト | CLI上書き | API上書き
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### 終了位置

v0.5.0で初めて利用可能。<br>
`absolute-with-indent` はv0.6.0で追加されました。<br>
`absolute-with-indent` はv0.8.0で削除されましたが、同じ出力は `absolute` で得られます。<br>
デフォルト値はv0.8.0で `relative` から `absolute` に変更されました。

これは、元のクラス名を複数行のクラス名に置き換える際に、各行のクラス名を終了する基準です。

- `absolute` の例:


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

- `relative` の例:

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
デフォルト | CLI&nbsp;オーバーライド | API&nbsp;オーバーライド
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### 構文変換

v0.7.7から利用可能。

非式構文で記述されたクラス名で改行が発生した場合、式構文に変換されます。この変換は可逆的なフォーマットをサポートしません。

<!-- prettier-ignore -->
デフォルト | CLI&nbsp;オーバーライド | API&nbsp;オーバーライド
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### クラス名のプリント幅

v0.10.0から利用可能。

クラス名のプリント幅を指定します。値が指定されていない場合は、`printWidth`の値がデフォルトとして使用されます。

<!-- prettier-ignore -->
デフォルト | CLI&nbsp;オーバーライド | API&nbsp;オーバーライド
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## 兄弟プラグインとのバージョン相関

`0.6.0`以降、一方でマイナーリリースがあった場合、可能であればもう一方にもその変更を反映する予定です。

![バージョン相関。](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## 他のPrettierプラグインとの互換性

フォーマットしたいテキストを複数のPrettierプラグインが処理できる場合、Prettierはそれらのプラグインのうち最後のものだけを使用します。

この場合、それらのプラグインを順番に適用するために [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) を追加して次のように設定できます。

JSONの例：

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