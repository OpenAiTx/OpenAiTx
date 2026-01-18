# Very Fast React Boilerplate

<p align="center">

![header](https://capsule-render.vercel.app/api?type=waving&color=61DAFB&height=300&section=header&text=Very%20Fast%20React%20Boilerplate&fontSize=60&animation=fadeIn&fontAlignY=38&descAlignY=51&descAlign=62&fontColor=F5F8FA)

</p>

[![Github Downloads](https://img.shields.io/npm/dt/react-vite-ts-boilerplate)](https://www.npmjs.com/package/react-vite-ts-boilerplate)
[![npm version](https://badge.fury.io/js/react-vite-ts-boilerplate.svg)](https://www.npmjs.com/package/react-vite-ts-boilerplate)

## Getting started

1. Gets the git project. (Auto run installation)

```
  npx react-vite-ts-boilerplate my-app
```

2. Start the dev server. And open http://localhost:3000 in your browser.

```
  yarn dev
```

3. Build your product.

```
  yarn prod
```

## Dependencies

- React
- Vite
- Typescript 
- eslint
- Prettier

## Performance

- fast dev server

```bash
$ yarn dev
yarn run v1.22.17
$ vite
                                                                                                                                                                                           16:58:10
  vite v2.8.6 dev server running at:

  > Local: http://localhost:3000/                                                                                                                                                          16:58:10
  > Network: use --host to expose                                                                                                                                                          16:58:10
                                                                                                                                                                                           16:58:10
  ready in 776ms.
```

- fast build speed

```bash
$ yarn prod               
yarn run v1.22.17
$ vite build
vite v2.8.6 building for production...                                                                                                                                                                                                                         21:57:44
✓ 37 modules transformed.                                                                                                                                                                                                                                      21:57:45
dist/public/index.html           0.55 KiB                                                                                                                                                                                                                      21:57:45
dist/assets/index.f377a083.js    2.09 KiB / gzip: 1.13 KiB                                                                                                                                                                                                     21:57:45
dist/assets/vendor.5ad169fc.js   136.42 KiB / gzip: 44.42 KiB                                                                                                                                                                                                  21:57:45
✨  Done in 2.22s.
```

- Type checking by [vite-plugin-checker](https://www.npmjs.com/package/vite-plugin-checker)
