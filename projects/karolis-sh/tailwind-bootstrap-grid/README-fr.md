# tailwind-bootstrap-grid

[![npm version](https://img.shields.io/npm/v/tailwind-bootstrap-grid)](https://www.npmjs.com/package/tailwind-bootstrap-grid)
![license](https://img.shields.io/npm/l/tailwind-bootstrap-grid)

Système de grille flexbox Bootstrap **v5** en tant que plugin Tailwind CSS.

Consultez le [playground démo](https://tailwind-bootstrap-grid.netlify.app/).

## Installation

```shell
npm i -D tailwind-bootstrap-grid
```

Dans votre fichier `index.css` :

```css
@import 'tailwindcss';

@plugin 'tailwind-bootstrap-grid' {
  container_max_widths:
    'sm', '540px', 'md', '720px', 'lg', '960px', 'xl', '1140px', '2xl', '1320px';
}
```

Ou via le fichier `tailwind.config.js` :

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

Cela générera la grille flexbox Bootstrap v5.

## Options

- Options de la grille Bootstrap originale :

  - `grid_columns` (par défaut - `12`) - taille de la grille
  - `grid_gutter_width` (par défaut - `"1.5rem"`) - largeur des gouttières du conteneur et des lignes
  - `grid_gutters` (par défaut - `[0, 0]`) - étapes des classes variables des gouttières
    (`--bs-gutter-x`, `--bs-gutter-y`)
  - `container_max_widths` (par défaut - `[]`) - valeur `max-width` du conteneur pour
    chaque point de rupture

- Options supplémentaires :
  - `generate_container` (par défaut - `true`) - générer ou non les classes `.container` et
    `.container-fluid`
  - `rtl` (par défaut - `false`) - support rtl (les classes `.offset-x` répondront à
    [dir](https://www.w3schools.com/tags/att_global_dir.asp)
    `[dir=ltr]` / `[dir=rtl]`)
  - `debug` (par défaut - `false`) - activer le mode debug

## Compatibilité des versions

| TailwindCSS | Bootstrap | tailwind-bootstrap-grid |
| ----------- | --------- | ----------------------- |
| 3           | 4         | 3                       |
| 3           | 5         | 5                       |
| 4           | 5         | 6+                      |

## Liens connexes

[postcss-bootstrap-4-grid](https://github.com/johnwatkins0/postcss-bootstrap-4-grid)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---