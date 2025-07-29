# tailwind-bootstrap-grid

[![npm version](https://img.shields.io/npm/v/tailwind-bootstrap-grid)](https://www.npmjs.com/package/tailwind-bootstrap-grid)
![license](https://img.shields.io/npm/l/tailwind-bootstrap-grid)

Bootstrap **v5** 弹性盒子网格系统，作为 Tailwind CSS 插件。

查看 [演示 playground](https://tailwind-bootstrap-grid.netlify.app/)。

## 安装

```shell
npm i -D tailwind-bootstrap-grid
```
在你的 `index.css` 文件中：


```css
@import 'tailwindcss';

@plugin 'tailwind-bootstrap-grid' {
  container_max_widths:
    'sm', '540px', 'md', '720px', 'lg', '960px', 'xl', '1140px', '2xl', '1320px';
}
```
或者通过 `tailwind.config.js` 文件：


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
这将生成 Bootstrap v5 弹性盒子网格。

## 选项

- 原始 Bootstrap 网格的选项：

  - `grid_columns`（默认 - `12`）- 网格大小
  - `grid_gutter_width`（默认 - `"1.5rem"`）- 容器和行的间隙宽度
  - `grid_gutters`（默认 - `[0, 0]`）- 间隙变量类步长
    (`--bs-gutter-x`, `--bs-gutter-y`)
  - `container_max_widths`（默认 - `[]`）- 每个断点的容器 `max-width` 值

- 额外选项：
  - `generate_container`（默认 - `true`）- 是否生成 `.container` 和
    `.container-fluid` 类
  - `rtl`（默认 - `false`）- 右到左支持（`.offset-x` 类将开始响应
    [dir](https://www.w3schools.com/tags/att_global_dir.asp)
    `[dir=ltr]` / `[dir=rtl]`）
  - `debug`（默认 - `false`）- 启用调试模式

## 版本兼容性

| TailwindCSS | Bootstrap | tailwind-bootstrap-grid |
| ----------- | --------- | ----------------------- |
| 3           | 4         | 3                       |
| 3           | 5         | 5                       |
| 4           | 5         | 6+                      |

## 相关

[postcss-bootstrap-4-grid](https://github.com/johnwatkins0/postcss-bootstrap-4-grid)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---