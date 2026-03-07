# <img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/src/images/icon48.png" width="45" align="left"> GitHub 动图插件

一个浏览器扩展，方便搜索 GIPHY 并将动图添加到任何 GitHub 评论框中。

<img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/demo.jpg" alt="示例图片">

---

## 安装

[link-chrome]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep 'Chrome 网上应用店发布版本'
[link-firefox]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Mozilla 附加组件发布版本'

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/chrome/chrome.svg" width="48" alt="Chrome" valign="middle">][link-chrome] [<img valign="middle" src="https://img.shields.io/chrome-web-store/v/dkgjnpbipbdaoaadbdhpiokaemhlphep.svg?label=%20">][link-chrome]

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/firefox/firefox.svg" width="48" alt="Firefox" valign="middle">][link-firefox] [<img valign="middle" src="https://img.shields.io/amo/v/gifs-for-github.svg?label=%20">][link-firefox]

---

## 贡献

```sh
git clone https://github.com/N1ck/gifs-for-github
cd gifs-for-github
pnpm install
```

```sh
pnpm run watch # Listen to file changes and automatically rebuild
```

### 调试模式

在开发时，您可以通过设置 DEBUG 环境变量来启用调试模式：

```bash
DEBUG=true npm run build
```

这将在使用扩展时输出带有 🎨 前缀的有用日志。

构建完成后，使用 [web-ext](https://github.com/mozilla/web-ext) 在您选择的浏览器中加载它：

```sh
npx web-ext run --target=chromium # Open extension in Chrome
```

```sh
npx web-ext run # Open extension in Firefox
```
或者你可以[在Chrome中手动加载](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#google-chrome-opera-vivaldi)或[Firefox](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#mozilla-firefox)。

---

如果你想了解我为什么开发这个扩展，以及我遇到的一些挑战，请查看我的[博客文章][link-blogpost]。

[link-cws]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep?hl=en 'Chrome 网上应用店发布的版本'
[link-amo]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Mozilla 附加组件发布的版本'
[link-blogpost]: https://medium.com/we-build-vend/helping-engineers-gif-their-best-life-challenges-faced-when-building-the-gifs-for-github-f0cac9dd8fa5 "帮助工程师以最佳方式使用GIF：构建“GIFs for GitHub”扩展时遇到的挑战"



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---