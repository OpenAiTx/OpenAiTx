# tailwind-bootstrap-grid

[![versión npm](https://img.shields.io/npm/v/tailwind-bootstrap-grid)](https://www.npmjs.com/package/tailwind-bootstrap-grid)
![licencia](https://img.shields.io/npm/l/tailwind-bootstrap-grid)

Sistema de cuadrícula flexbox de Bootstrap **v5** como un plugin de Tailwind CSS.

Consulta el [demo playground](https://tailwind-bootstrap-grid.netlify.app/).

## Instalación

```shell
npm i -D tailwind-bootstrap-grid
```

En tu archivo `index.css`:

```css
@import 'tailwindcss';

@plugin 'tailwind-bootstrap-grid' {
  container_max_widths:
    'sm', '540px', 'md', '720px', 'lg', '960px', 'xl', '1140px', '2xl', '1320px';
}
```

O mediante el archivo `tailwind.config.js`:

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
Esto generará la cuadrícula flexbox de Bootstrap v5.

## Opciones

- Opciones de la cuadrícula original de Bootstrap:

  - `grid_columns` (por defecto - `12`) - tamaño de la cuadrícula
  - `grid_gutter_width` (por defecto - `"1.5rem"`) - ancho de canaletas del contenedor y filas
  - `grid_gutters` (por defecto - `[0, 0]`) - pasos de clase variable para canaletas
    (`--bs-gutter-x`, `--bs-gutter-y`)
  - `container_max_widths` (por defecto - `[]`) - valor de `max-width` para el
    contenedor en cada punto de interrupción

- Opciones adicionales:
  - `generate_container` (por defecto - `true`) - si se generan las clases `.container` y
    `.container-fluid`
  - `rtl` (por defecto - `false`) - soporte RTL (las clases `.offset-x` responderán a
    [dir](https://www.w3schools.com/tags/att_global_dir.asp)
    `[dir=ltr]` / `[dir=rtl]`)
  - `debug` (por defecto - `false`) - activar modo depuración

## Compatibilidad de versión

| TailwindCSS | Bootstrap | tailwind-bootstrap-grid |
| ----------- | --------- | ----------------------- |
| 3           | 4         | 3                       |
| 3           | 5         | 5                       |
| 4           | 5         | 6+                      |

## Relacionado

[postcss-bootstrap-4-grid](https://github.com/johnwatkins0/postcss-bootstrap-4-grid)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---