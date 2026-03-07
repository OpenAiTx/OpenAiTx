# <img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/src/images/icon48.png" width="45" align="left"> GIFs para GitHub

Una extensión de navegador que facilita la búsqueda en GIPHY y la inserción de un GIF en cualquier caja de comentarios de GitHub.

<img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/demo.jpg" alt="Imagen de ejemplo">

---

## Instalación

[link-chrome]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep 'Versión publicada en Chrome Web Store'
[link-firefox]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Versión publicada en Mozilla Add-ons'

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/chrome/chrome.svg" width="48" alt="Chrome" valign="middle">][link-chrome] [<img valign="middle" src="https://img.shields.io/chrome-web-store/v/dkgjnpbipbdaoaadbdhpiokaemhlphep.svg?label=%20">][link-chrome]

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/firefox/firefox.svg" width="48" alt="Firefox" valign="middle">][link-firefox] [<img valign="middle" src="https://img.shields.io/amo/v/gifs-for-github.svg?label=%20">][link-firefox]

---

## Contribuyendo

```sh
git clone https://github.com/N1ck/gifs-for-github
cd gifs-for-github
pnpm install
```

```sh
pnpm run watch # Listen to file changes and automatically rebuild
```

### Modo de Depuración

Cuando desarrolles, puedes habilitar el modo de depuración configurando la variable de entorno DEBUG:

```bash
DEBUG=true npm run build
```

Esto generará registros útiles con el prefijo 🎨 al usar la extensión.

Una vez compilada, cárguela en el navegador de su elección con [web-ext](https://github.com/mozilla/web-ext):

```sh
npx web-ext run --target=chromium # Open extension in Chrome
```

```sh
npx web-ext run # Open extension in Firefox
```
O puedes [cargarlo manualmente en Chrome](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#google-chrome-opera-vivaldi) o [Firefox](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#mozilla-firefox).

---

Si quieres leer sobre por qué construí esta extensión, y algunos de los desafíos que enfrenté, consulta mi [entrada de blog][link-blogpost].

[link-cws]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep?hl=en 'Versión publicada en Chrome Web Store'
[link-amo]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Versión publicada en Mozilla Add-ons'
[link-blogpost]: https://medium.com/we-build-vend/helping-engineers-gif-their-best-life-challenges-faced-when-building-the-gifs-for-github-f0cac9dd8fa5 "Ayudando a los ingenieros a GIFear su mejor vida: desafíos enfrentados al construir la extensión 'GIFs para GitHub'"



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---