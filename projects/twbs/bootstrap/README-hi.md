<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">बूटस्ट्रैप</h3>

<p align="center">
  तेज़ और आसान वेब विकास के लिए स्लीक, सहज, और शक्तिशाली फ्रंट-एंड फ्रेमवर्क।
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>बूटस्ट्रैप दस्तावेज़ देखें »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">बग रिपोर्ट करें</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">विशेषता का अनुरोध करें</a>
  ·
  <a href="https://themes.getbootstrap.com/">थीम्स</a>
  ·
  <a href="https://blog.getbootstrap.com/">ब्लॉग</a>
</p>


## बूटस्ट्रैप 5

हमारी डिफ़ॉल्ट ब्रांच हमारे बूटस्ट्रैप 5 रिलीज़ के विकास के लिए है। बूटस्ट्रैप 4 के लिए readme, दस्तावेज़ और स्रोत कोड देखने के लिए [`v4-dev` ब्रांच](https://github.com/twbs/bootstrap/tree/v4-dev) पर जाएं।


## सामग्री तालिका

- [त्वरित प्रारंभ](#quick-start)
- [स्थिति](#status)
- [क्या शामिल है](#whats-included)
- [बग्स और फीचर अनुरोध](#bugs-and-feature-requests)
- [दस्तावेज़ीकरण](#documentation)
- [योगदान](#contributing)
- [समुदाय](#community)
- [संस्करण](#versioning)
- [निर्माता](#creators)
- [धन्यवाद](#thanks)
- [कॉपीराइट और लाइसेंस](#copyright-and-license)


## त्वरित प्रारंभ

कई त्वरित प्रारंभ विकल्प उपलब्ध हैं:

- [नवीनतम रिलीज़ डाउनलोड करें](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- रेपो क्लोन करें: `git clone https://github.com/twbs/bootstrap.git`
- [npm](https://www.npmjs.com/) के साथ इंस्टॉल करें: `npm install bootstrap@v5.3.6`
- [yarn](https://yarnpkg.com/) के साथ इंस्टॉल करें: `yarn add bootstrap@v5.3.6`
- [Bun](https://bun.sh/) के साथ इंस्टॉल करें: `bun add bootstrap@v5.3.6`
- [Composer](https://getcomposer.org/) के साथ इंस्टॉल करें: `composer require twbs/bootstrap:5.3.6`
- [NuGet](https://www.nuget.org/) के साथ इंस्टॉल करें: CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

फ्रेमवर्क की सामग्री, टेम्प्लेट, उदाहरण, और अधिक जानकारी के लिए [आरंभ करें पृष्ठ](https://getbootstrap.com/docs/5.3/getting-started/introduction/) पढ़ें।


## स्थिति

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## क्या शामिल है

डाउनलोड के भीतर आपको निम्नलिखित निर्देशिकाएं और फाइलें मिलेंगी, जो सामान्य संसाधनों को तार्किक रूप से समूहित करती हैं और संकलित तथा मिनिफाइड दोनों प्रकार उपलब्ध कराती हैं।

<details>
  <summary>डाउनलोड सामग्री</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

हम संकलित CSS और JS (`bootstrap.*`), साथ ही संकलित और मिनिफाइड CSS और JS (`bootstrap.min.*`) उपलब्ध कराते हैं। [सोर्स मैप्स](https://web.dev/articles/source-maps) (`bootstrap.*.map`) कुछ ब्राउज़र डेवलपर टूल्स के साथ उपयोग के लिए उपलब्ध हैं। बंडल किए गए JS फाइलें (`bootstrap.bundle.js` और मिनिफाइड `bootstrap.bundle.min.js`) में [Popper](https://popper.js.org/docs/v2/) शामिल है।


## बग्स और फीचर अनुरोध

क्या आपके पास कोई बग या फीचर अनुरोध है? कृपया पहले [इश्यू दिशानिर्देश](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) पढ़ें और मौजूदा तथा बंद इश्यू खोजें। यदि आपकी समस्या या विचार अभी संबोधित नहीं किया गया है, [कृपया एक नया इश्यू खोलें](https://github.com/twbs/bootstrap/issues/new/choose)।


## दस्तावेज़ीकरण

बूटस्ट्रैप का दस्तावेज़, इस रेपो की रूट डायरेक्टरी में शामिल है, [Astro](https://astro.build/) के साथ बनाया गया है और GitHub Pages पर सार्वजनिक रूप से होस्ट किया गया है: <https://getbootstrap.com/>। दस्तावेज़ को स्थानीय रूप से भी चलाया जा सकता है।

दस्तावेज़ खोज [Algolia's DocSearch](https://docsearch.algolia.com/) द्वारा संचालित है।

### दस्तावेज़ को स्थानीय रूप से चलाना

1. Node.js डिपेंडेंसीज, जिसमें Astro (साइट बिल्डर) शामिल है, इंस्टॉल करने के लिए `npm install` चलाएं।
2. वितरित CSS और JavaScript फाइलों, साथ ही हमारे दस्तावेज़ीकरण संसाधनों को पुनर्निर्माण के लिए `npm run test` (या कोई विशिष्ट npm स्क्रिप्ट) चलाएं।
3. रूट `/bootstrap` डायरेक्टरी से, कमांड लाइन में `npm run docs-serve` चलाएं।
4. अपने ब्राउज़र में `http://localhost:9001/` खोलें, और बस।

Astro का उपयोग करने के बारे में और जानने के लिए इसकी [दस्तावेज़ीकरण](https://docs.astro.build/en/getting-started/) पढ़ें।

### पिछले रिलीज़ के लिए दस्तावेज़ीकरण

आप हमारे सभी पिछले रिलीज़ के दस्तावेज़ <https://getbootstrap.com/docs/versions/> पर पा सकते हैं।

[पिछले रिलीज़](https://github.com/twbs/bootstrap/releases) और उनका दस्तावेज़ भी डाउनलोड के लिए उपलब्ध है।


## योगदान

कृपया हमारे [योगदान दिशानिर्देश](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) पढ़ें। इसमें इश्यू खोलने, कोडिंग मानकों, और विकास पर नोट्स के लिए निर्देश शामिल हैं।

इसके अलावा, यदि आपके पुल अनुरोध में JavaScript पैच या फीचर्स हैं, तो आपको [संबंधित यूनिट परीक्षण](https://github.com/twbs/bootstrap/tree/main/js/tests) शामिल करना होगा। सभी HTML और CSS को [कोड गाइड](https://github.com/mdo/code-guide) का पालन करना चाहिए, जिसे [Mark Otto](https://github.com/mdo) द्वारा बनाए रखा गया है।

संपादक प्राथमिकताएं सामान्य टेक्स्ट संपादकों में आसान उपयोग के लिए [एडिटर कॉन्फिग](https://github.com/twbs/bootstrap/blob/main/.editorconfig) में उपलब्ध हैं। और अधिक पढ़ें और प्लगइन्स डाउनलोड करें: <https://editorconfig.org/>।


## समुदाय

बूटस्ट्रैप के विकास पर अपडेट प्राप्त करें और प्रोजेक्ट मेंटेनर्स और समुदाय के सदस्यों के साथ बातचीत करें।

- [@getbootstrap on X](https://x.com/getbootstrap) को फॉलो करें।
- [आधिकारिक बूटस्ट्रैप ब्लॉग](https://blog.getbootstrap.com/) पढ़ें और सदस्यता लें।
- [हमारे GitHub Discussions](https://github.com/twbs/bootstrap/discussions) पर प्रश्न पूछें और जानें।
- [समुदाय Discord](https://discord.gg/bZUvakRU3M) या [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/) पर चर्चा करें, प्रश्न पूछें, और अधिक।
- IRC में Bootstrappers के साथ चैट करें। `irc.libera.chat` सर्वर पर, `#bootstrap` चैनल में।
- कार्यान्वयन सहायता Stack Overflow (टैग [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)) पर मिल सकती है।
- डेवलपर्स को `bootstrap` कीवर्ड का उपयोग करना चाहिए जब npm या इसी तरह के वितरण माध्यमों के माध्यम से बूटस्ट्रैप की कार्यक्षमता में संशोधन या जोड़ने वाले पैकेज वितरित करें, ताकि अधिकतम खोज योग्यता सुनिश्चित हो।


## संस्करण

हमारे रिलीज़ चक्र में पारदर्शिता के लिए और पीछे की संगतता बनाए रखने के प्रयास में, बूटस्ट्रैप को [सेमांटिक वर्शनिंग दिशानिर्देश](https://semver.org/) के तहत बनाए रखा जाता है। कभी-कभी हम गलती करते हैं, लेकिन जहां संभव हो वहां उन नियमों का पालन करते हैं।

[हमारे GitHub प्रोजेक्ट के रिलीज़ अनुभाग](https://github.com/twbs/bootstrap/releases) में प्रत्येक रिलीज़ संस्करण के लिए चेंजलॉग देखें। [आधिकारिक बूटस्ट्रैप ब्लॉग](https://blog.getbootstrap.com/) पर रिलीज़ घोषणा पोस्ट में प्रत्येक रिलीज़ में किए गए सबसे उल्लेखनीय परिवर्तनों का सारांश होता है।


## निर्माता

**मार्क ओटो**

- <https://x.com/mdo>
- <https://github.com/mdo>

**जैकब थॉर्नटन**

- <https://x.com/fat>
- <https://github.com/fat>


## धन्यवाद

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

[BrowserStack](https://www.browserstack.com/) का धन्यवाद, जिन्होंने हमें असली ब्राउज़रों में परीक्षण करने के लिए इन्फ्रास्ट्रक्चर प्रदान किया!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

[Netlify](https://www.netlify.com/) का धन्यवाद, जिन्होंने हमें डिप्लॉय प्रीव्यूज़ प्रदान किए!


## प्रायोजक

इस प्रोजेक्ट को प्रायोजक बनकर समर्थन दें। आपका लोगो यहाँ आपकी वेबसाइट के लिंक के साथ दिखाई देगा। [[प्रायोजक बनें](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## बैकर्स

सभी बैकर्स का धन्यवाद! 🙏 [[बैकर्स बनें](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## कॉपीराइट और लाइसेंस

कोड और दस्तावेज़ का कॉपीराइट 2011-2025 [बूटस्ट्रैप लेखक](https://github.com/twbs/bootstrap/graphs/contributors) के नाम है। कोड [MIT लाइसेंस](https://github.com/twbs/bootstrap/blob/main/LICENSE) के तहत जारी किया गया है। दस्तावेज़ [क्रिएटिव कॉमन्स](https://creativecommons.org/licenses/by/3.0/) के तहत जारी किया गया है।

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---