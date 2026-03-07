# <img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/src/images/icon48.png" width="45" align="left"> GitHub用GIF

GIPHYを簡単に検索し、任意のGitHubコメントボックスにGIFを追加できるブラウザ拡張機能。

<img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/demo.jpg" alt="Example image">

---

## インストール

[link-chrome]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep 'Chromeウェブストアで公開されているバージョン'
[link-firefox]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Mozillaアドオンで公開されているバージョン'

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/chrome/chrome.svg" width="48" alt="Chrome" valign="middle">][link-chrome] [<img valign="middle" src="https://img.shields.io/chrome-web-store/v/dkgjnpbipbdaoaadbdhpiokaemhlphep.svg?label=%20">][link-chrome]

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/firefox/firefox.svg" width="48" alt="Firefox" valign="middle">][link-firefox] [<img valign="middle" src="https://img.shields.io/amo/v/gifs-for-github.svg?label=%20">][link-firefox]

---

## 貢献について

```sh
git clone https://github.com/N1ck/gifs-for-github
cd gifs-for-github
pnpm install
```

```sh
pnpm run watch # Listen to file changes and automatically rebuild
```

### デバッグモード

開発時には、DEBUG環境変数を設定してデバッグモードを有効にできます：

```bash
DEBUG=true npm run build
```

これは、拡張機能を使用する際に🎨で始まる役立つログを出力します。

ビルドが完了したら、[web-ext](https://github.com/mozilla/web-ext)を使ってお好みのブラウザに読み込んでください：

```sh
npx web-ext run --target=chromium # Open extension in Chrome
```

```sh
npx web-ext run # Open extension in Firefox
```
または、[Chromeで手動で読み込む](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#google-chrome-opera-vivaldi)か、[Firefoxで手動で読み込む](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#mozilla-firefox)こともできます。

---

この拡張機能を作った理由や直面した課題について読みたい場合は、私の[ブログ記事][link-blogpost]をご覧ください。

[link-cws]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep?hl=en 'Chromeウェブストアに公開されているバージョン'
[link-amo]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Mozillaアドオンに公開されているバージョン'
[link-blogpost]: https://medium.com/we-build-vend/helping-engineers-gif-their-best-life-challenges-faced-when-building-the-gifs-for-github-f0cac9dd8fa5 "エンジニアが最高のGIFライフを送るために：「GIFs for GitHub」拡張機能構築時に直面した課題"



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---