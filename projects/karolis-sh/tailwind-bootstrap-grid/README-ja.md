# tailwind-bootstrap-grid

[![npm version](https://img.shields.io/npm/v/tailwind-bootstrap-grid)](https://www.npmjs.com/package/tailwind-bootstrap-grid)
![license](https://img.shields.io/npm/l/tailwind-bootstrap-grid)

Bootstrap **v5** のフレックスボックスグリッドシステムをTailwind CSSプラグインとして提供します。

[デモプレイグラウンド](https://tailwind-bootstrap-grid.netlify.app/)をチェックしてください。

## インストール

```shell
npm i -D tailwind-bootstrap-grid
```
あなたの `index.css` ファイル内で：


```css
@import 'tailwindcss';

@plugin 'tailwind-bootstrap-grid' {
  container_max_widths:
    'sm', '540px', 'md', '720px', 'lg', '960px', 'xl', '1140px', '2xl', '1320px';
}
```

または `tailwind.config.js` ファイルを介して：

```js
module.exports = {
  plugins: [
    require('tailwind-bootstrap-grid')({
      container_max_widths: [
        'sm',
        '540px',
        'md',
        '720px',
        'lg',
        '960px',
        'xl',
        '1140px',
        '2xl',
        '1320px',
      ],
    }),
  ],
};
```
これはBootstrap v5のフレックスボックスグリッドを生成します。

## オプション

- オリジナルのBootstrapグリッドのオプション：

  - `grid_columns`（デフォルト - `12`） - グリッドのサイズ
  - `grid_gutter_width`（デフォルト - `"1.5rem"`） - コンテナと行のガター幅
  - `grid_gutters`（デフォルト - `[0, 0]`） - ガター変数クラスのステップ
    (`--bs-gutter-x`, `--bs-gutter-y`)
  - `container_max_widths`（デフォルト - `[]`） - 各ブレークポイントの
    コンテナの `max-width` 値

- 追加のオプション：
  - `generate_container`（デフォルト - `true`） - `.container` と
    `.container-fluid` クラスを生成するかどうか
  - `rtl`（デフォルト - `false`） - RTLサポート（`.offset-x` クラスが
    [dir](https://www.w3schools.com/tags/att_global_dir.asp)
    `[dir=ltr]` / `[dir=rtl]` に対応開始）
  - `debug`（デフォルト - `false`） - デバッグモードを有効にする

## バージョン互換性

| TailwindCSS | Bootstrap | tailwind-bootstrap-grid |
| ----------- | --------- | ----------------------- |
| 3           | 4         | 3                       |
| 3           | 5         | 5                       |
| 4           | 5         | 6+                      |

## 関連

[postcss-bootstrap-4-grid](https://github.com/johnwatkins0/postcss-bootstrap-4-grid)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---