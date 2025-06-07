<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## परिचय

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) एक प्रोडक्शन-रेडी फ्रंट-एंड समाधान है जो एडमिन इंटरफेस के लिए बनाया गया है। यह [vue](https://github.com/vuejs/vue) पर आधारित है और UI टूलकिट के रूप में [element-ui](https://github.com/ElemeFE/element) का उपयोग करता है।

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) vue के नवीनतम डेवलपमेंट स्टैक पर आधारित है और इसमें i18n समाधान, एंटरप्राइज एप्लिकेशन के लिए टेम्प्लेट्स तथा कई बेहतरीन फीचर्स बिल्ट-इन हैं। यह आपको बड़े और जटिल सिंगल-पेज एप्लिकेशन बनाने में मदद करता है। मुझे विश्वास है कि आपकी जो भी जरूरतें हों, यह प्रोजेक्ट आपकी मदद करेगा।

- [पूर्वावलोकन](https://panjiachen.github.io/vue-element-admin)

- [डॉक्युमेंटेशन](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [दान करें](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/)  (भारतीय/चीनी उपयोगकर्ता इस लिंक पर ऑनलाइन प्रीव्यू देख सकते हैं)

- बेस टेम्प्लेट के लिए अनुशंसा: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- डेस्कटॉप: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- टाइपस्क्रिप्ट: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (श्रेय: [@Armour](https://github.com/Armour))
- [शानदार प्रोजेक्ट्स](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**`v4.1.0+` वर्शन के बाद, डिफ़ॉल्ट मास्टर ब्रांच में i18n सपोर्ट नहीं है। कृपया [i18n ब्रांच](https://github.com/PanJiaChen/vue-element-admin/tree/i18n) का उपयोग करें, यह मास्टर ब्रांच के साथ अपडेट होती रहेगी।**

**वर्तमान वर्शन `v4.0+` है, जो `vue-cli` पर आधारित है। यदि आपको कोई समस्या मिले, कृपया [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new) डालें। यदि आप पुराना वर्शन उपयोग करना चाहते हैं, तो ब्रांच बदलकर [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0) पर जाएँ, यह `vue-cli` पर निर्भर नहीं करता।**

**यह प्रोजेक्ट पुराने ब्राउज़र (जैसे IE) को सपोर्ट नहीं करता। कृपया स्वयं polyfill जोड़ें।**

## तैयारी

आपको अपने लोकल सिस्टम पर [node](https://nodejs.org/) और [git](https://git-scm.com/) इंस्टॉल करना होगा। यह प्रोजेक्ट [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) और [element-ui](https://github.com/ElemeFE/element) पर आधारित है, तथा सभी डेटा अनुरोध [Mock.js](https://github.com/nuysoft/Mock) का उपयोग करके सिम्युलेट किए गए हैं।
इनकी पूर्व जानकारी और समझ होना इस प्रोजेक्ट के उपयोग के लिए अत्यंत सहायक होगी।

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## प्रायोजक

प्रायोजक बनें और अपना लोगो हमारे README पर GitHub में अपनी साइट के लिंक के साथ पाएं। [[प्रायोजक बनें]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Vue एडमिन के लिए जावा बैकएंड 39$ में 20% छूट के साथ पाएं, कूपन कोड SWB0RAZPZR1M का उपयोग करें।
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Vue, React और Angular के साथ बने एडमिन डैशबोर्ड टेम्प्लेट्स।</p>

## विशेषताएँ

```
- लॉगिन / लॉगआउट

- अनुमति प्रमाणीकरण
  - पेज अनुमति
  - निर्देश अनुमति
  - अनुमति कॉन्फ़िगरेशन पृष्ठ
  - दो-चरण लॉगिन

- बहु-पर्यावरण निर्माण
  - विकास (dev)
  - sit
  - स्टेज टेस्ट (stage)
  - प्रोडक्शन (prod)

- वैश्विक विशेषताएँ
  - I18n
  - कई डायनामिक थीम्स
  - डायनामिक साइडबार (मल्टी-लेवल रूटिंग सपोर्ट)
  - डायनामिक ब्रेडक्रंब
  - टैग्स-व्यू (टैब पेज, राइट-क्लिक ऑपरेशन सपोर्ट)
  - Svg स्प्राइट
  - Mock डेटा
  - स्क्रीनफुल
  - रिस्पॉन्सिव साइडबार

- संपादक
  - रिच टेक्स्ट एडिटर
  - मार्कडाउन एडिटर
  - JSON एडिटर

- एक्सेल
  - एक्सपोर्ट एक्सेल
  - अपलोड एक्सेल
  - विजुअलाइज़ेशन एक्सेल
  - एक्सपोर्ट zip

- टेबल
  - डायनामिक टेबल
  - ड्रैग एंड ड्रॉप टेबल
  - इनलाइन एडिट टेबल

- त्रुटि पृष्ठ
  - 401
  - 404

- घटक
  - अवतार अपलोड
  - बैक टू टॉप
  - ड्रैग डायलॉग
  - ड्रैग सिलेक्ट
  - ड्रैग कानबन
  - ड्रैग लिस्ट
  - स्प्लिट पेन
  - ड्रॉपज़ोन
  - स्टिकी
  - काउंट टू

- उन्नत उदाहरण
- त्रुटि लॉग
- डैशबोर्ड
- गाइड पेज
- ECharts
- क्लिपबोर्ड
- मार्कडाउन से HTML
```

## प्रारंभ करें

```bash
# प्रोजेक्ट क्लोन करें
git clone https://github.com/PanJiaChen/vue-element-admin.git

# प्रोजेक्ट डायरेक्टरी में जाएँ
cd vue-element-admin

# निर्भरता इंस्टॉल करें
npm install

# विकास मोड
npm run dev
```

यह स्वतः http://localhost:9527 खोल देगा

## बिल्ड

```bash
# टेस्ट वातावरण के लिए बिल्ड करें
npm run build:stage

# प्रोडक्शन वातावरण के लिए बिल्ड करें
npm run build:prod
```

## उन्नत

```bash
# रिलीज वातावरण का पूर्वावलोकन करें
npm run preview

# रिलीज वातावरण का पूर्वावलोकन + स्थैतिक संसाधन विश्लेषण
npm run preview -- --report

# कोड फॉर्मेट चेक
npm run lint

# कोड फॉर्मेट चेक और स्वतः सुधार
npm run lint -- --fix
```

अधिक जानकारी के लिए [डॉक्युमेंटेशन](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html) देखें

## चैंजलॉग

प्रत्येक रिलीज़ के विस्तृत बदलाव [रिलीज नोट्स](https://github.com/PanJiaChen/vue-element-admin/releases) में दर्ज हैं।

## ऑनलाइन डेमो

[पूर्वावलोकन](https://panjiachen.github.io/vue-element-admin)

## दान करें

यदि आपको यह प्रोजेक्ट उपयोगी लगे, तो आप लेखक को एक गिलास जूस खरीदकर प्रोत्साहित कर सकते हैं :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## ब्राउज़र समर्थन

आधुनिक ब्राउज़र्स और Internet Explorer 10+।

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | अंतिम 2 संस्करण | अंतिम 2 संस्करण | अंतिम 2 संस्करण |

## लाइसेंस

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

कॉपीराइट (c) 2017-वर्तमान PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---