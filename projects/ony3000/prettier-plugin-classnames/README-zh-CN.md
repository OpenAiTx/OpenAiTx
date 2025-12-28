<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

一个基于 `printWidth` 选项自动换行冗长类名的 Prettier 插件。

![该插件的一个用例。](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## 安装[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: 如果你的 `prettier-plugin-classnames` 版本低于 `0.4.0`，你还需要安装 `@prettier/sync`。

## 配置

JSON 示例：

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS 示例（CommonJS 模块）：

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS 示例（ES 模块）：

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

## 选项

### 自定义属性

包含类名的属性列表。<br>
即使未指定任何选项，也始终支持 `class` 和 `className` 属性。

<!-- prettier-ignore -->
默认值 | CLI&nbsp;覆盖 | API&nbsp;覆盖
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### 自定义函数

包含类名的函数列表。<br>
即使未指定任何选项，也始终支持 `classNames` 函数。

<!-- prettier-ignore -->
默认值 | CLI&nbsp;覆盖 | API&nbsp;覆盖
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### 结束位置

首次在 v0.5.0 中提供。<br>
`absolute-with-indent` 于 v0.6.0 添加。<br>
`absolute-with-indent` 于 v0.8.0 移除，但使用 `absolute` 可获得相同输出。<br>
默认值在 v0.8.0 中从 `relative` 更改为 `absolute`。

这是替换原始类名为多行类名时，每行结束类名的标准。

- `absolute` 示例：

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

- `relative` 示例：

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
默认 | CLI&nbsp;覆盖 | API&nbsp;覆盖
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### 语法转换

首次在 v0.7.7 中提供。

如果在非表达式语法中编写的类名出现换行，则会转换为表达式语法。此转换不支持可逆格式化。

<!-- prettier-ignore -->
默认 | CLI&nbsp;覆盖 | API&nbsp;覆盖
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

## 与同类插件的版本关联

从 `0.6.0` 开始，当一方有小版本发布时，我计划如果可能，也将该更改反映到另一方。

![版本关联。](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## 与其他 Prettier 插件的兼容性

如果多个 Prettier 插件都能处理您想格式化的文本，Prettier 只会使用这些插件中的最后一个。

在这种情况下，您可以通过添加 [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) 来按顺序应用这些插件，从而进行如下配置。

JSON 示例：

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