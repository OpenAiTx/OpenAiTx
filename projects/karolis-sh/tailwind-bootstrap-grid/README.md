# tailwind-bootstrap-grid

[![npm version](https://img.shields.io/npm/v/tailwind-bootstrap-grid)](https://www.npmjs.com/package/tailwind-bootstrap-grid)
![license](https://img.shields.io/npm/l/tailwind-bootstrap-grid)

Bootstrap **v5** flexbox grid system as a Tailwind CSS plugin.

Check the [demo playground](https://tailwind-bootstrap-grid.netlify.app/).

## Installation

```shell
npm i -D tailwind-bootstrap-grid
```

In your `index.css` file:

```css
@import 'tailwindcss';

@plugin 'tailwind-bootstrap-grid' {
  container_max_widths:
    'sm', '540px', 'md', '720px', 'lg', '960px', 'xl', '1140px', '2xl', '1320px';
}
```

Or via `tailwind.config.js` file:

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

This will generate the Bootstrap v5 flexbox grid.

## Options

- Original Bootstrap grid's options:

  - `grid_columns` (default - `12`) - grid size
  - `grid_gutter_width` (default - `"1.5rem"`) - container and rows gutter width
  - `grid_gutters` (default - `[0, 0]`) - gutter variable class steps
    (`--bs-gutter-x`, `--bs-gutter-y`)
  - `container_max_widths` (default - `[]`) - the `max-width` container value for
    each breakpoint

- Extra options:
  - `generate_container` (default - `true`) - whether to generate `.container` and
    `.container-fluid` classes
  - `rtl` (default - `false`) - rtl support (`.offset-x` classes will start
    responding to [dir](https://www.w3schools.com/tags/att_global_dir.asp)
    `[dir=ltr]` / `[dir=rtl]`)
  - `debug` (default - `false`) - enable debug mode

## Version Compatibility

| TailwindCSS | Bootstrap | tailwind-bootstrap-grid |
| ----------- | --------- | ----------------------- |
| 3           | 4         | 3                       |
| 3           | 5         | 5                       |
| 4           | 5         | 6+                      |

## Related

[postcss-bootstrap-4-grid](https://github.com/johnwatkins0/postcss-bootstrap-4-grid)
