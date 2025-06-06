## Vue 2 का एंड ऑफ लाइफ हो गया है

**आप Vue 2 के अब निष्क्रिय रिपॉजिटरी को देख रहे हैं। Vue के नवीनतम संस्करण के लिए सक्रिय रूप से अनुरक्षित रिपॉजिटरी [vuejs/core](https://github.com/vuejs/core) है।**

Vue का एंड ऑफ लाइफ 31 दिसंबर, 2023 को हो गया है। अब इसमें कोई नई सुविधाएँ, अपडेट या सुधार नहीं मिलेंगे। हालांकि, यह अब भी सभी मौजूदा वितरण चैनलों (CDNs, पैकेज मैनेजर, Github, आदि) पर उपलब्ध है।

यदि आप कोई नया प्रोजेक्ट शुरू कर रहे हैं, तो कृपया Vue के नवीनतम संस्करण (3.x) से शुरू करें। हम वर्तमान Vue 2 उपयोगकर्ताओं को भी अपग्रेड करने की दृढ़ता से सलाह देते हैं ([गाइड](https://v3-migration.vuejs.org/)), लेकिन हम यह भी समझते हैं कि सभी उपयोगकर्ताओं के पास ऐसा करने के लिए संसाधन या प्रोत्साहन नहीं हो सकता। यदि आपको Vue 2 पर ही रहना है लेकिन अनुपालन या सुरक्षा के कारण अव्यवस्थित सॉफ़्टवेयर के लिए आवश्यकताएँ हैं, तो [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme) देखें।

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## प्रायोजक

Vue.js एक MIT-लाइसेंस प्राप्त ओपन सोर्स प्रोजेक्ट है, जिसका सतत विकास पूरी तरह से इन शानदार [बैकर्स](https://github.com/vuejs/core/blob/main/BACKERS.md) के समर्थन से संभव हो सका है। यदि आप भी इसमें शामिल होना चाहते हैं, तो कृपया [Vue के विकास को प्रायोजित करें](https://vuejs.org/sponsor/)।

<p align="center">
  <h3 align="center">विशेष प्रायोजक</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## परिचय

Vue (उच्चारण `/vjuː/`, view जैसा) एक **प्रगतिशील फ्रेमवर्क** है जो यूज़र इंटरफेस बनाने के लिए है। इसे शुरू से ही क्रमिक रूप से अपनाने योग्य बनाया गया है, और विभिन्न उपयोग मामलों के अनुसार यह आसानी से एक लाइब्रेरी और एक फ्रेमवर्क के बीच स्केल किया जा सकता है। इसमें एक सुलभ कोर लाइब्रेरी है जो केवल व्यू लेयर पर केंद्रित है, और सहायक लाइब्रेरी का एक ईकोसिस्टम है जो आपको बड़े सिंगल-पेज एप्लिकेशन में जटिलता से निपटने में मदद करता है।

#### ब्राउज़र संगतता

Vue.js उन सभी ब्राउज़रों का समर्थन करता है जो [ES5-अनुरूप](https://compat-table.github.io/compat-table/es5/) हैं (IE8 और उससे नीचे समर्थित नहीं हैं)।

## ईकोसिस्टम

| प्रोजेक्ट               | स्थिति                                                       | विवरण                                               |
| ---------------------- | ------------------------------------------------------------ | --------------------------------------------------- |
| [vue-router]           | [![vue-router-status]][vue-router-package]                   | सिंगल-पेज एप्लिकेशन राउटिंग                        |
| [vuex]                 | [![vuex-status]][vuex-package]                               | बड़े पैमाने पर स्टेट प्रबंधन                        |
| [vue-cli]              | [![vue-cli-status]][vue-cli-package]                         | प्रोजेक्ट स्कैफोल्डिंग                              |
| [vue-loader]           | [![vue-loader-status]][vue-loader-package]                   | वेबपैक के लिए सिंगल फाइल कंपोनेंट (`*.vue` फाइल) लोडर |
| [vue-server-renderer]  | [![vue-server-renderer-status]][vue-server-renderer-package] | सर्वर-साइड रेंडरिंग समर्थन                         |
| [vue-class-component]  | [![vue-class-component-status]][vue-class-component-package] | क्लास-आधारित API के लिए TypeScript डेकोरेटर        |
| [vue-rx]               | [![vue-rx-status]][vue-rx-package]                           | RxJS एकीकरण                                        |
| [vue-devtools]         | [![vue-devtools-status]][vue-devtools-package]               | ब्राउज़र DevTools एक्सटेंशन                         |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## दस्तावेज़ीकरण

[लाइव उदाहरण](https://v2.vuejs.org/v2/examples/) और दस्तावेज़ देखने के लिए [vuejs.org](https://v2.vuejs.org) पर जाएं।

## प्रश्न

प्रश्नों और सहायता के लिए कृपया [आधिकारिक फोरम](https://forum.vuejs.org) या [कम्युनिटी चैट](https://chat.vuejs.org/) का उपयोग करें। इस रिपॉजिटरी की इश्यू सूची केवल बग रिपोर्ट और फीचर अनुरोधों के लिए है।

## समस्याएँ

कृपया कोई भी इश्यू खोलने से पहले [Issue Reporting Checklist](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) अवश्य पढ़ें। दिशानिर्देशों का पालन न करने वाली समस्याओं को तुरंत बंद किया जा सकता है।

## चैंजलॉग

प्रत्येक रिलीज़ के लिए विस्तृत परिवर्तन [रिलीज़ नोट्स](https://github.com/vuejs/vue/releases) में दस्तावेज़ित हैं।

## संपर्क में रहें

- [Twitter](https://twitter.com/vuejs)
- [ब्लॉग](https://medium.com/the-vue-point)
- [जॉब बोर्ड](https://vuejobs.com/?ref=vuejs)

## योगदान

कृपया कोई भी पुल अनुरोध करने से पहले [Contributing Guide](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) अवश्य पढ़ें। यदि आपके पास कोई Vue-संबंधित प्रोजेक्ट/कंपोनेंट/टूल है, तो इसे [इस क्यूरेटेड सूची](https://github.com/vuejs/awesome-vue) में पुल अनुरोध के साथ जोड़ें!

Vue में योगदान देने वाले सभी लोगों का धन्यवाद!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## लाइसेंस

[MIT](https://opensource.org/licenses/MIT)

कॉपीराइट (c) 2013-वर्तमान, युशी (इवान) यू

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---