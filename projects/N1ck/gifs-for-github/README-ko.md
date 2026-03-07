# <img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/src/images/icon48.png" width="45" align="left"> GitHub용 GIF

GIPHY를 쉽게 검색하고 GitHub 댓글 상자에 GIF를 추가할 수 있는 브라우저 확장 프로그램입니다.

<img src="https://raw.githubusercontent.com/N1ck/gifs-for-github/master/demo.jpg" alt="예시 이미지">

---

## 설치

[link-chrome]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep 'Chrome 웹 스토어에 게시된 버전'
[link-firefox]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Mozilla 애드온에 게시된 버전'

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/chrome/chrome.svg" width="48" alt="Chrome" valign="middle">][link-chrome] [<img valign="middle" src="https://img.shields.io/chrome-web-store/v/dkgjnpbipbdaoaadbdhpiokaemhlphep.svg?label=%20">][link-chrome]

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/firefox/firefox.svg" width="48" alt="Firefox" valign="middle">][link-firefox] [<img valign="middle" src="https://img.shields.io/amo/v/gifs-for-github.svg?label=%20">][link-firefox]

---

## 기여하기

```sh
git clone https://github.com/N1ck/gifs-for-github
cd gifs-for-github
pnpm install
```

```sh
pnpm run watch # Listen to file changes and automatically rebuild
```

### 디버그 모드

개발 중에는 DEBUG 환경 변수를 설정하여 디버그 모드를 활성화할 수 있습니다:

```bash
DEBUG=true npm run build
```
이것은 확장 프로그램을 사용할 때 🎨가 접두사로 붙은 유용한 로그를 출력합니다.

빌드가 완료되면, [web-ext](https://github.com/mozilla/web-ext)를 사용하여 원하는 브라우저에서 로드하세요:


```sh
npx web-ext run --target=chromium # Open extension in Chrome
```

```sh
npx web-ext run # Open extension in Firefox
```
또는 [Chrome에서 수동으로 로드할 수 있습니다](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#google-chrome-opera-vivaldi) 또는 [Firefox에서](https://www.smashingmagazine.com/2017/04/browser-extension-edge-chrome-firefox-opera-brave-vivaldi/#mozilla-firefox).

---

이 확장 기능을 만든 이유와 직면한 몇 가지 문제에 대해 읽고 싶다면, 제 [블로그 게시물][link-blogpost]을 확인하세요.

[link-cws]: https://chrome.google.com/webstore/detail/gifs-for-github/dkgjnpbipbdaoaadbdhpiokaemhlphep?hl=en 'Chrome 웹 스토어에 게시된 버전'
[link-amo]: https://addons.mozilla.org/en-US/firefox/addon/gifs-for-github/ 'Mozilla 애드온에 게시된 버전'
[link-blogpost]: https://medium.com/we-build-vend/helping-engineers-gif-their-best-life-challenges-faced-when-building-the-gifs-for-github-f0cac9dd8fa5 "엔지니어들이 최고의 GIF 생활을 할 수 있도록 돕기: 'GIFs for GitHub' 확장 기능 개발 시 직면한 도전"



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---