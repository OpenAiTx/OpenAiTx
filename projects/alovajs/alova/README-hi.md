<p align="center">
<img width="200px" src="https://alova.js.org/img/logo-text-vertical.svg" />
</p>

<p align="center"><b>वर्कफ़्लो-सुव्यवस्थित अगली पीढ़ी के अनुरोध उपकरण।<br />केवल एक कदम में अपनी API उपयोग क्षमता को अत्यधिक बढ़ाएं और दिमागी शक्ति बचाएं</b></p>

<p align="center">English | <a href="./README.zh-CN.md">Chinese</a></p>

[![npm](https://img.shields.io/npm/v/alova)](https://www.npmjs.com/package/alova)
[![build](https://github.com/alovajs/alova/actions/workflows/release.yml/badge.svg?branch=main)](https://github.com/alovajs/alova/actions/workflows/release.yml)
[![coverage status](https://coveralls.io/repos/github/alovajs/alova/badge.svg?branch=main)](https://coveralls.io/github/alovajs/alova?branch=main)
[![stars](https://img.shields.io/github/stars/alovajs/alova?style=social)](https://github.com/alovajs/alova)
[![discord](https://img.shields.io/badge/chat-Discord-515ff1)](https://discord.gg/S47QGJgkVb)
[![wechat](https://img.shields.io/badge/chat_with_CH-Wechat-07c160)](https://alova.js.org/img/wechat_qrcode.jpg)
[![tree shaking](https://badgen.net/bundlephobia/tree-shaking/alova)](https://bundlephobia.com/package/alova)
![typescript](https://badgen.net/badge/icon/typescript?icon=typescript&label)
![license](https://img.shields.io/badge/license-MIT-blue.svg)

## alova क्या है?

alova (उच्चारण /əˈləʊva/) एक अगली पीढ़ी की अनुरोध लाइब्रेरी है जो आपके API एकीकरण वर्कफ़्लो को पूरी तरह से सरल बनाती है, जिससे पहले के 7 जटिल चरणों को घटाकर सिर्फ 1 कर देती है - बस अपनी API चुनें और आगे बढ़ें।

![](https://alova.js.org/img/overview_flow_en.png)

## विशेषताएँ

- उपयोग में बेहद आसान, न्यूनतम सीखने की आवश्यकता।
- और भी आधुनिक OpenAPI समाधान - उबाऊ मध्यवर्ती API दस्तावेज़ीकरण से छुटकारा।
- क्लाइंट-साइड तकनीकों और अनुरोध लाइब्रेरीज़ के साथ संगत: `react/vue/svelte/solid/next/nuxt/sveltkit/solid-start/uniapp/taro/...` + `fetch/XMLHttpRequest/axios/...`
- सर्वर-साइड तकनीकों और अनुरोध लाइब्रेरीज़ के साथ संगत: `nodejs/deno/bun/...` + `fetch/XMLHttpRequest/axios/...`
- जटिल अनुरोध परिदृश्यों को संभालने के लिए 15+ उच्च-प्रदर्शन अनुरोध रणनीतियाँ, जो आपको तेज़ी से और अधिक कुशल अनुप्रयोग विकसित करने में मदद करती हैं।

## लाइव उदाहरण

देखने के लिए [लिंक](https://alova.js.org/examples) पर जाएं।

## क्या कोई अंतर है?

`@tanstack/react-request`, `swrjs`, और `ahooks` के `useRequest` जैसी लाइब्रेरीज़ के विपरीत, alova का लक्ष्य अनुरोधों को बहुत आसान बनाना और अधिक कुशल डेटा इंटरएक्शन बनाए रखना है। हम डेवलपर्स और ऐप उपयोगकर्ताओं दोनों को ध्यान में रखते हैं। डेवलपर्स के लिए, alova उन्हें सर्वोत्तम उपयोगकर्ता अनुभव प्रदान करता है, और ऐप उपयोगकर्ताओं के लिए, वे alova के उच्च-प्रदर्शन डेटा इंटरएक्शन से मिली स्मूथ एक्सपीरियंस का आनंद ले सकते हैं।

> आप [अन्य अनुरोध लाइब्रेरीज़ के साथ तुलना](https://alova.js.org/about/comparison) भी देख सकते हैं, ताकि alova के अंतर को और जान सकें।

## प्रलेखन

अधिक जानकारी के लिए [alova वेबसाइट](https://alova.js.org) पर जाएं, या [उदाहरण देखें और आज़माएं](https://alova.js.org/category/examples)।

## समुदाय से जुड़ें

- [हमें X पर फॉलो करें](https://x.com/alovajs)

- [Discord से जुड़ें](https://discord.gg/S47QGJgkVb)

- [WeChat समूह से जुड़ें](https://alova.js.org/img/wechat_qrcode.jpg)

## हमें आपका समर्थन चाहिए

यदि आपको alova पसंद है, तो हम आपके द्वारा ऊपर दाएँ कोने में एक स्टार देने के लिए बहुत आभारी हैं, यह हमारे काम के लिए एक मान्यता और प्रोत्साहन है।

## योगदान के लिए स्वागत है

हम दुनिया भर के डेवलपर्स की Issues और Discussions में सक्रिय भागीदारी पाकर सम्मानित महसूस करते हैं।

हम आशा करते हैं कि alova सभी इच्छुक प्रतिभागियों के लिए एक सामान्य प्रोजेक्ट बने, न कि केवल alova टीम का। हम सभी को खुले और समावेशी दृष्टिकोण के साथ alova समुदाय के योगदानकर्ता बनने के लिए प्रोत्साहित करते हैं। भले ही आप एक जूनियर डेवलपर हों, यदि आपके विचार alova के विकास दिशा-निर्देशों से मेल खाते हैं, तो कृपया उदारतापूर्वक भाग लें।

प्रभावी योगदान आपको Alova समुदाय में निश्चित प्रतिष्ठा दिलाएंगे। योगदान करने से पहले, कृपया सुनिश्चित करें कि आपने [योगदान मार्गदर्शिका](https://raw.githubusercontent.com/alovajs/alova/main/CONTRIBUTING.zh-CN.md) को विस्तार से पढ़ा है ताकि आपका योगदान प्रभावी हो।

## चेंजलॉग

[लिंक](https://github.com/alovajs/alova/releases)

## योगदानकर्ता

<a href="https://github.com/alovajs/alova/graphs/contributors">
<img src="https://contrib.rocks/image?repo=alovajs/alova&max=30&columns=10" />
</a>

## लाइसेंस

[MIT](https://en.wikipedia.org/wiki/MIT_License)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---