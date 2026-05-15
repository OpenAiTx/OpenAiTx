<div align="center">

<a href="https://github.com/oljc/arco-admin">
  <img width="180" src="https://github.com/user-attachments/assets/09c91ec6-1de8-400e-878c-e1066667ff08" alt="Arco admin logo">
</a>

<h1 align="center">Arco Admin</h1>
<p align="center">An out-of-the-box, feature-rich mid-to-backend management system framework, a standardized project with the latest technology stack.</p> 

Simplified Chinese | [English](https://raw.githubusercontent.com/oljc/arco-admin/main/./README.en-US.md)

[![Netlify Status](https://api.netlify.com/api/v1/badges/4177124c-546f-4726-a842-00b72bf864fa/deploy-status)](https://arco-admin.netlify.app)
<a href="https://nodejs.org/en/about/previous-releases" target="_blank"><img alt="node compatibility" src="https://img.shields.io/node/v/vite.svg"></a>
<img alt="License" src="https://img.shields.io/github/license/oljc/arco-admin">
<img alt="Commit" src="https://img.shields.io/github/last-commit/oljc/arco-admin.svg">
<img alt="Version" src="https://img.shields.io/github/package-json/v/oljc/arco-admin/main">

[![Vercel](https://vercel.com/button)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2Foljc%2Farco-admin&project-name=arco-admin&build-command=pnpm%20run%20build&install-command=pnpm%20i&output-directory=dist)
[![Netlify](https://www.netlify.com/img/deploy/button.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/oljc/arco-admin)
[![EdgeOne Pages](https://cdnstatic.tencentcs.com/edgeone/pages/deploy.svg)](https://edgeone.ai/pages/new?repository-url=https%3A%2F%2Fgithub.com%2Foljc%2Farco-admin&repository-name=arco-admin&project-name=arco-admin&install-command=pnpm%20i&build-command=pnpm%20run%20build&output-directory=dist)

<img width="600" src="https://github.com/user-attachments/assets/49f985f1-bd8b-4ff6-9d38-25becb7a579e" alt="edgeone" />

This project’s CDN acceleration and security protection are sponsored and supported by [Tencent EdgeOne](https://edgeone.ai/zh?from=github)

</div>

## Features
+ ⚡️ Keep up with the latest versions of Vue and Vite.
+ 👍🏻 [Vue](https://cn.vuejs.org) + official recommended [Vue Router](https://router.vuejs.org/zh) + [Pinia](https://pinia.vuejs.org/zh) state management.
+ 🔩 Enterprise-level design ecosystem component library [ArcoDesign](https://arco.design/) produced by ByteDance.
+ 🎨 [Less](https://less.bootcss.com/) CSS preprocessor.
+ 📚 Use [i18n](https://github.com/intlify/vue-i18n-next/tree/master/packages/vue-i18n#readme) + [i18n-ally](https://github.com/lokalise/i18n-ally) to implement a simpler, standardized automated internationalization solution.
+ ⌨️ Built-in multiple business scenario pages, secondary encapsulated components, framework support configuration for easy personalized customization.
+ 🧚🏻 The project has fully adopted the `ESM` standard modular syntax, following the major unification trend in modern front-end development.
+ 📦 Continuously optimize configuration to keep up with updates, deprecations, and feature merges of various `dependencies` and `Vite` to achieve the best packaging optimization effect.


---

<img src="https://github.com/user-attachments/assets/da090081-a568-4882-837e-38fd1dbe0a7f">

## Version
- International version: [i18n branch](https://github.com/oljc/arco-admin/tree/i18n)

## Specification
Improving code quality, reducing errors, and ensuring consistent code style across the entire project allows you to manage code quality and style more easily.

+ **Code Specification:**  [ESLint](https://eslint.org/) + [Stylelint](https://stylelint.io) + [Prettier](https://prettier.io)<br/>
    *Ensure code quality and readability through static checks and standardization of code syntax, style, and format using predefined specifications*

+ **Commit Specification:**  [Husky](https://typicode.github.io/husky/#/) + [Lint-Staged](https://github.com/okonet/lint-staged) + [Commitlint](https://commitlint.js.org)<br/>
  *Ensure consistent code quality and style on every commit by running preset code style checks, formatting, and message validation during commits*

## Browser Support

| <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="Edge" width="24px" height="24px" /><br/>Edge | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" /><br/>Firefox | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" /><br/>Chrome | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" /><br/>Safari | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/samsung-internet/samsung-internet_48x48.png" alt="Samsung" width="24px" height="24px" /><br/>Samsung | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/opera/opera_48x48.png" alt="Opera" width="24px" height="24px" /><br/>Opera | <img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/electron/electron_48x48.png" alt="Electron" width="24px" height="24px" /><br/>Electron |
| --------- | --------- | --------- | --------- | --------- | --------- | --------- |
| Edge >=16| >= 31 | >= 49| >= 31| last 2 versions| >= 36 | last 2 versions

## Usage
1. Clone this repository
```bash
git clone https://github.com/oljc/arco-admin
```
2. Install Dependencies
```bash
pnpm i
```
3. 运行
```bash
pnpm run dev
```

#### VsCode Extension Recommendations

| [<img src="https://vue.gallerycdn.vsassets.io/extensions/vue/volar/2.2.4/1740301455362/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>Official](https://marketplace.visualstudio.com/items?itemName=Vue.volar) | [<img src="https://dbaeumer.gallerycdn.vsassets.io/extensions/dbaeumer/vscode-eslint/2.4.2/1687441427519/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>ESLint](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint) |[<img src="https://esbenp.gallerycdn.vsassets.io/extensions/esbenp/prettier-vscode/10.1.0/1690819498575/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>Prettier](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode) |[<img src="https://lokalise.gallerycdn.vsassets.io/extensions/lokalise/i18n-ally/2.12.0/1695476646920/Microsoft.VisualStudio.Services.Icons.Default" width="24px" height="24px" /><br>i18n Ally](https://marketplace.visualstudio.com/items?itemName=Lokalise.i18n-ally) |[<img src="https://stylelint.gallerycdn.vsassets.io/extensions/stylelint/vscode-stylelint/1.3.0/1698920117910/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>Stylelint](https://marketplace.visualstudio.com/items?itemName=stylelint.vscode-stylelint)|[<img src="https://editorconfig.gallerycdn.vsassets.io/extensions/editorconfig/editorconfig/0.16.4/1607315835386/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>EditorConfig](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)|[<img src="https://antfu.gallerycdn.vsassets.io/extensions/antfu/vite/0.2.5/1622972526798/Microsoft.VisualStudio.Services.Icons.Default" width="25px" height="25px" /><br>Vite](https://marketplace.visualstudio.com/items?itemName=antfu.vite)|
| --- | --- | --- | ---| --- | --- | --- |

## Achievements
Included in Vite official [awesome-vite](https://github.com/vitejs/awesome-vite#vue-3) community curated project list 🎉 

## Contributions
Any form of contribution is welcome, and we will take every participation seriously.<br/><br/>
<a href="https://github.com/oljc/arco-admin/graphs/contributors"><img src="https://contrib.rocks/image?repo=oljc/arco-admin" />
</a><br/>

# License
This project follows the [MIT License](./LICENSE).

[![Trend Chart](https://starchart.cc/oljc/arco-admin.svg)](https://starchart.cc/oljc/arco-admin)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-15

---