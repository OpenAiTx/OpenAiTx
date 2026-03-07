# <img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/src/images/icon48.png" width="45" align="left"> GIFs pour GitHub

Une extension de navigateur qui facilite la recherche sur GIPHY et l'ajout d'un GIF dans n'importe quelle zone de commentaire GitHub.

<img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/demo.jpg" alt="Image d'exemple">

---

## Installation

[link-chrome]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep 'Version publiée sur Chrome Web Store'
[link-firefox]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Version publiée sur Mozilla Add-ons'

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/chrome/chrome.svg" width="48" alt="Chrome" valign="middle">][link-chrome] [<img valign="middle" src="https://img.shields.io/chrome-web-store/v/dkgjnpbipbdaoaadbdhpiokaemhlphep.svg?label=%20">][link-chrome]

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/firefox/firefox.svg" width="48" alt="Firefox" valign="middle">][link-firefox] [<img valign="middle" src="https://img.shields.io/amo/v/gifs-for-github.svg?label=%20">][link-firefox]

---

## Contribution

```sh
git clone https://github.com/N1ck/gifs-for-github
cd gifs-for-github
pnpm install
```

```sh
pnpm run watch # Listen to file changes and automatically rebuild
```

### Mode Débogage

Lors du développement, vous pouvez activer le mode débogage en définissant la variable d'environnement DEBUG :

```bash
DEBUG=true npm run build
```

Cela affichera des journaux utiles préfixés par 🎨 lors de l'utilisation de l'extension.

Une fois compilée, chargez-la dans le navigateur de votre choix avec [web-ext](https://github.com/mozilla/web-ext) :

```sh
npx web-ext run --target=chromium # Open extension in Chrome
```

```sh
npx web-ext run # Open extension in Firefox
```

Ou vous pouvez [le charger manuellement dans Chrome](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#google-chrome-opera-vivaldi) ou [Firefox](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#mozilla-firefox).

---

Si vous voulez lire pourquoi j’ai créé cette extension, et certains des défis que j’ai rencontrés, consultez mon [article de blog][link-blogpost].

[link-cws]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep?hl=en 'Version publiée sur le Chrome Web Store'
[link-amo]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Version publiée sur les modules complémentaires Mozilla'
[link-blogpost]: https://medium.com/we-build-vend/helping-engineers-gif-their-best-life-challenges-faced-when-building-the-gifs-for-github-f0cac9dd8fa5 "Aider les ingénieurs à GIF leur meilleure vie : défis rencontrés lors de la création de l’extension 'GIFs for GitHub'"


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---