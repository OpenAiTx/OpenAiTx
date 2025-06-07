[![Electron Logo](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions Build Status](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord Invite](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: उपलब्ध अनुवाद: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪।
इन दस्तावेज़ों को अन्य भाषाओं में हमारे [Crowdin](https://crowdin.com/project/electron) प्रोजेक्ट पर देखें।

Electron फ्रेमवर्क आपको JavaScript, HTML और CSS का उपयोग करके क्रॉस-प्लेटफ़ॉर्म डेस्कटॉप एप्लिकेशन लिखने देता है। यह [Node.js](https://nodejs.org/) और [Chromium](https://www.chromium.org) पर आधारित है और इसका उपयोग [Visual Studio Code](https://github.com/Microsoft/vscode/) और कई अन्य [ऐप्स](https://electronjs.org/apps) द्वारा किया जाता है।

महत्वपूर्ण घोषणाओं के लिए ट्विटर पर [@electronjs](https://twitter.com/electronjs) को फॉलो करें।

यह प्रोजेक्ट Contributor Covenant [code of conduct](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) का पालन करता है। भाग लेने पर, आपसे इस कोड का पालन करने की अपेक्षा की जाती है। कृपया अस्वीकार्य व्यवहार को [coc@electronjs.org](mailto:coc@electronjs.org) पर रिपोर्ट करें।

## स्थापना

प्रीबिल्ट Electron बाइनरी को स्थापित करने के लिए [`npm`](https://docs.npmjs.com/) का उपयोग करें। पसंदीदा तरीका है अपने ऐप में Electron को एक डेवलपमेंट डिपेंडेंसी के रूप में इंस्टॉल करना:

```sh
npm install electron --save-dev
```

अधिक स्थापना विकल्पों और समस्या निवारण सुझावों के लिए देखें [installation](docs/tutorial/installation.md)। अपने ऐप्स में Electron संस्करणों को प्रबंधित करने की जानकारी के लिए देखें [Electron versioning](docs/tutorial/electron-versioning.md)।

## प्लेटफ़ॉर्म समर्थन

प्रत्येक Electron रिलीज़ macOS, Windows और Linux के लिए बाइनरी प्रदान करती है।

* macOS (Big Sur और आगे): Electron macOS के लिए 64-बिट Intel और Apple Silicon / ARM बाइनरी प्रदान करता है।
* Windows (Windows 10 और आगे): Electron Windows के लिए `ia32` (`x86`), `x64` (`amd64`), और `arm64` बाइनरी प्रदान करता है। Windows पर ARM का समर्थन Electron 5.0.8 में जोड़ा गया था। Windows 7, 8 और 8.1 के लिए समर्थन [Electron 23 में हटा दिया गया, Chromium की Windows डिप्रिकेटेड नीति के अनुसार](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice)।
* Linux: Electron की प्रीबिल्ट बाइनरी Ubuntu 20.04 पर निर्मित की गई हैं। इन्हें निम्नलिखित पर भी काम करते हुए सत्यापित किया गया है:
  * Ubuntu 18.04 और नए संस्करण
  * Fedora 32 और नए संस्करण
  * Debian 10 और नए संस्करण

## Electron Fiddle

[`Electron Fiddle`](https://github.com/electron/fiddle) का उपयोग करें छोटे-छोटे Electron प्रयोगों को बनाने, चलाने और पैकेज करने के लिए, Electron के सभी API के कोड उदाहरण देखने के लिए, और Electron के विभिन्न संस्करणों को आज़माने के लिए। यह Electron के साथ आपकी यात्रा की शुरुआत को आसान बनाने के लिए डिज़ाइन किया गया है।

## Electron सीखने के संसाधन

* [electronjs.org/docs](https://electronjs.org/docs) - Electron का संपूर्ण दस्तावेज़ीकरण
* [electron/fiddle](https://github.com/electron/fiddle) - छोटे Electron प्रयोगों को बनाने, चलाने और पैकेज करने का एक उपकरण
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - समुदाय द्वारा बनाए गए नमूना स्टार्टर ऐप्स

## प्रोग्रामेटिक उपयोग

अधिकांश लोग Electron को कमांड लाइन से उपयोग करते हैं, लेकिन यदि आप अपने **Node ऐप** (अपने Electron ऐप में नहीं) में `electron` को require करते हैं तो यह बाइनरी का फ़ाइल पथ लौटाएगा। इसका उपयोग Node स्क्रिप्ट्स से Electron को चालू करने के लिए करें:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// कुछ ऐसा प्रिंट करेगा जैसे /Users/maf/.../Electron
console.log(electron)

// Electron चलाएँ
const child = proc.spawn(electron)
```

### मिरर

* [चीन](https://npmmirror.com/mirrors/electron/)

कस्टम मिरर का उपयोग कैसे करें, जानने के लिए देखें [Advanced Installation Instructions](https://www.electronjs.org/docs/latest/tutorial/installation#mirror)।

## दस्तावेज़ीकरण अनुवाद

हम अपने दस्तावेज़ों के अनुवाद [Crowdin](https://crowdin.com/project/electron) के माध्यम से क्राउडसोर्स करते हैं।
हम वर्तमान में चीनी (सरलीकृत), फ्रेंच, जर्मन, जापानी, पुर्तगाली, रूसी, और स्पेनिश के अनुवाद स्वीकार करते हैं।

## योगदान

यदि आप समस्याओं की रिपोर्ट करने/सुधारने और कोड बेस में सीधे योगदान करने में रुचि रखते हैं, तो कृपया और जानकारी के लिए [CONTRIBUTING.md](CONTRIBUTING.md) देखें कि हम क्या ढूंढ रहे हैं और कैसे शुरू करें।

## समुदाय

बग रिपोर्ट करने, सहायता प्राप्त करने, तृतीय-पक्ष टूल्स और नमूना ऐप्स खोजने तथा अन्य जानकारी के लिए [Community page](https://www.electronjs.org/community) देखें।

## लाइसेंस

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Electron लोगो का उपयोग करते समय, कृपया [OpenJS Foundation Trademark Policy](https://trademark-policy.openjsf.org/) का पालन करें।

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---