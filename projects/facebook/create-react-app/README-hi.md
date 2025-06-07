## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## अप्रचलित
>
> Create React App 2017-2021 के दौरान एक React प्रोजेक्ट को जल्दी शुरू करने के लिए एक प्रमुख उपकरण था, अब यह दीर्घकालिक स्थिरता में है और हम अनुशंसा करते हैं कि आप [Start a New React Project](https://react.dev/learn/start-a-new-react-project) पर दस्तावेज़ीकृत React फ्रेमवर्क्स में से किसी एक पर माइग्रेट करें।
>
> यदि आप React सीखने के लिए कोई ट्यूटोरियल फॉलो कर रहे हैं, तो आपके ट्यूटोरियल को जारी रखना फायदेमंद रहेगा, लेकिन हम Create React App के आधार पर नए प्रोडक्शन ऐप्स शुरू करने की अनुशंसा नहीं करते हैं।

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

बिल्ड कॉन्फ़िगरेशन के बिना React ऐप्स बनाएं।

- [ऐप बनाना](#creating-an-app) – नया ऐप कैसे बनाएं।
- [यूज़र गाइड](https://facebook.github.io/create-react-app/) – Create React App के साथ शुरू किए गए ऐप्स को कैसे विकसित करें।

Create React App macOS, Windows और Linux पर काम करता है।<br>
अगर कुछ काम नहीं करता है, कृपया [एक समस्या दर्ज करें](https://github.com/facebook/create-react-app/issues/new)।<br>
अगर आपके कोई सवाल हैं या सहायता चाहिए, तो कृपया [GitHub Discussions](https://github.com/facebook/create-react-app/discussions) में पूछें।

## त्वरित अवलोकन

```sh
npx create-react-app my-app
cd my-app
npm start
```

यदि आपने पहले `npm install -g create-react-app` के माध्यम से `create-react-app` को ग्लोबली इंस्टॉल किया है, तो हम अनुशंसा करते हैं कि आप `npm uninstall -g create-react-app` या `yarn global remove create-react-app` का उपयोग करके पैकेज को अनइंस्टॉल कर दें ताकि npx हमेशा नवीनतम संस्करण का उपयोग करे।

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) npm 5.2+ और उससे ऊपर में आता है, पुराने npm संस्करणों के लिए [निर्देश देखें](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

फिर [http://localhost:3000/](http://localhost:3000/) खोलें और अपना ऐप देखें।<br>
जब आप प्रोडक्शन में डिप्लॉय करने के लिए तैयार हों, तो `npm run build` के साथ एक मिनिफाइड बंडल बनाएं।

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### तुरंत शुरू करें

आपको webpack या Babel जैसे टूल इंस्टॉल या कॉन्फ़िगर करने की **आवश्यकता नहीं है**।<br>
ये पहले से ही कॉन्फ़िगर हैं और छुपे हुए हैं ताकि आप कोड पर फोकस कर सकें।

एक प्रोजेक्ट बनाएं, और आप शुरू करने के लिए तैयार हैं।

## ऐप बनाना

**आपके लोकल डिवेलपमेंट मशीन पर Node 14.0.0 या उससे नया वर्शन होना चाहिए** (लेकिन सर्वर पर आवश्यक नहीं है)। हम नवीनतम LTS संस्करण का उपयोग करने की सलाह देते हैं। आप [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) या [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) का उपयोग करके विभिन्न प्रोजेक्ट्स के बीच Node संस्करण बदल सकते हैं।

नया ऐप बनाने के लिए, आप निम्न में से कोई एक तरीका चुन सकते हैं:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) एक पैकेज रनर टूल है जो npm 5.2+ और ऊपर में आता है, पुराने npm वर्शन के लिए [निर्देश देखें](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` npm 6+ में उपलब्ध है_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) Yarn 0.25+ में उपलब्ध है_

यह वर्तमान फ़ोल्डर के अंदर `my-app` नामक एक डायरेक्टरी बनाएगा।<br>
उस डायरेक्टरी के अंदर, यह प्रारंभिक प्रोजेक्ट संरचना बनाएगा और ट्रांजिटिव डिपेंडेंसीज़ इंस्टॉल करेगा:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

कोई कॉन्फ़िगरेशन या जटिल फ़ोल्डर स्ट्रक्चर नहीं, केवल वे फाइलें जो आपके ऐप को बनाने के लिए आवश्यक हैं।<br>
इंस्टॉल पूरा होने के बाद, आप अपना प्रोजेक्ट फोल्डर खोल सकते हैं:

```sh
cd my-app
```

नए बनाए गए प्रोजेक्ट के अंदर, आप कुछ बिल्ट-इन कमांड चला सकते हैं:

### `npm start` या `yarn start`

ऐप को डिवेलपमेंट मोड में चलाता है।<br>
इसे ब्राउज़र में देखने के लिए [http://localhost:3000](http://localhost:3000) खोलें।

यदि आप कोड में कोई बदलाव करते हैं तो पेज अपने आप रीलोड हो जाएगा।<br>
आप कंसोल में बिल्ड एरर और लिंट वार्निंग देखेंगे।

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` या `yarn test`

इंटरएक्टिव मोड में टेस्ट वॉचर चलाता है।<br>
डिफ़ॉल्ट रूप से, आखिरी कमिट के बाद बदली गई फाइलों से संबंधित टेस्ट चलाता है।

[टेस्टिंग के बारे में और पढ़ें।](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` या `yarn build`

ऐप को प्रोडक्शन के लिए `build` फोल्डर में बनाता है।<br>
यह प्रोडक्शन मोड में React को सही ढंग से बंडल करता है और सर्वोत्तम प्रदर्शन के लिए बिल्ड को ऑप्टिमाइज़ करता है।

बिल्ड मिनिफाइड होती है और फाइल नामों में हैश शामिल होते हैं।<br>

आपका ऐप डिप्लॉय के लिए तैयार है।

## यूज़र गाइड

Create React App का उपयोग करने और कई सुझावों के लिए आप [इसके दस्तावेज़](https://facebook.github.io/create-react-app/) में विस्तृत निर्देश पा सकते हैं।

## नई वर्ज़न में कैसे अपडेट करें?

इसके लिए कृपया [यूज़र गाइड](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) देखें।

## दर्शन

- **एक डिपेंडेंसी:** केवल एक बिल्ड डिपेंडेंसी है। यह webpack, Babel, ESLint और अन्य शानदार प्रोजेक्ट्स का उपयोग करता है, लेकिन उनके ऊपर एक सुसंगत अनुभव प्रदान करता है।

- **कोई कॉन्फ़िगरेशन आवश्यक नहीं:** आपको कुछ भी कॉन्फ़िगर करने की आवश्यकता नहीं है। डिवेलपमेंट और प्रोडक्शन दोनों बिल्ड की एक अच्छी कॉन्फ़िगरेशन आपके लिए संभाली जाती है ताकि आप केवल कोडिंग पर ध्यान दें।

- **कोई लॉक-इन नहीं:** आप कभी भी कस्टम सेटअप के लिए "eject" कर सकते हैं। एक कमांड चलाएं, और सभी कॉन्फ़िगरेशन और बिल्ड डिपेंडेंसीज सीधे आपके प्रोजेक्ट में आ जाएंगी, ताकि आप वहीं से जारी रख सकें।

## क्या शामिल है?

आपका एनवायरनमेंट एक आधुनिक सिंगल-पेज React ऐप बनाने के लिए आवश्यक हर चीज़ से लैस होगा:

- React, JSX, ES6, TypeScript और Flow सिंटैक्स सपोर्ट।
- ES6 से आगे की सुविधाएं, जैसे ऑब्जेक्ट स्प्रेड ऑपरेटर।
- ऑटो-प्रिफिक्स्ड CSS, ताकि आपको `-webkit-` या अन्य प्रीफिक्स की जरूरत न हो।
- कवरेज रिपोर्टिंग के लिए बिल्ट-इन सपोर्ट के साथ तेज़ इंटरएक्टिव यूनिट टेस्ट रनर।
- कॉमन गलतियों के लिए चेतावनी देने वाला लाइव डिवेलपमेंट सर्वर।
- प्रोडक्शन के लिए JS, CSS, और इमेजेज़ को हैश और सोर्समैप के साथ बंडल करने के लिए बिल्ड स्क्रिप्ट।
- ऑफलाइन-फर्स्ट [सर्विस वर्कर](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) और [वेब ऐप मैनिफेस्ट](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), जो सभी [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) मानदंडों को पूरा करते हैं। (_नोट: `react-scripts@2.0.0` और ऊपर के वर्शन में सर्विस वर्कर का उपयोग ऑप्ट-इन है_)
- उपरोक्त टूल्स के लिए एकल डिपेंडेंसी के साथ परेशानी मुक्त अपडेट।

देखें [यह गाइड](https://github.com/nitishdayal/cra_closer_look) इन टूल्स के एक साथ कैसे काम करने का अवलोकन करने के लिए।

इसका समझौता यह है कि **ये टूल्स एक विशिष्ट तरीके से काम करने के लिए प्री-कॉन्फ़िगर किए गए हैं**। यदि आपके प्रोजेक्ट को अधिक कस्टमाइजेशन की आवश्यकता है, तो आप ["eject"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) कर सकते हैं और कस्टमाइज़ कर सकते हैं, लेकिन फिर आपको यह कॉन्फ़िगरेशन मेंटेन करनी होगी।

## लोकप्रिय विकल्प

Create React App उपयुक्त है:

- **React सीखने** के लिए एक आरामदायक और फीचर-रिच डिवेलपमेंट एनवायरनमेंट में।
- **नए सिंगल-पेज React एप्लिकेशन** शुरू करने के लिए।
- **React के साथ उदाहरण बनाने** के लिए, आपकी लाइब्रेरीज़ और कंपोनेंट्स के लिए।

यहां कुछ आम केस हैं जब आप कुछ और ट्राय करना चाह सकते हैं:

- यदि आप सैकड़ों ट्रांजिटिव बिल्ड टूल डिपेंडेंसीज़ के बिना **React आजमाना** चाहते हैं, तो इसके बजाय [एकल HTML फाइल या ऑनलाइन सैंडबॉक्स का उपयोग करें](https://reactjs.org/docs/getting-started.html#try-react)।

- यदि आपको **React कोड को सर्वर-साइड टेम्पलेट फ्रेमवर्क** जैसे Rails, Django या Symfony के साथ इंटीग्रेट करना है, या आप **सिंगल-पेज ऐप नहीं बना रहे हैं**, तो [nwb](https://github.com/insin/nwb) या [Neutrino](https://neutrino.js.org/) जैसे अधिक लचीले विकल्प पर विचार करें। विशेष रूप से Rails के लिए, आप [Rails Webpacker](https://github.com/rails/webpacker) का उपयोग कर सकते हैं। Symfony के लिए, [Symfony's webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html) आज़माएं।

- यदि आपको **React कंपोनेंट प्रकाशित करना** है, तो [nwb](https://github.com/insin/nwb) [यह भी कर सकता है](https://github.com/insin/nwb#react-components-and-libraries), साथ ही [Neutrino's react-components प्रीसेट](https://neutrino.js.org/packages/react-components/) भी।

- यदि आप React और Node.js के साथ **सर्वर रेंडरिंग** करना चाहते हैं, तो देखें [Next.js](https://nextjs.org/) या [Razzle](https://github.com/jaredpalmer/razzle)। Create React App बैकएंड के प्रति तटस्थ है, और केवल स्टैटिक HTML/JS/CSS बंडल बनाता है।

- यदि आपकी वेबसाइट **अधिकतर स्थैतिक** है (उदाहरण: पोर्टफोलियो या ब्लॉग), तो [Gatsby](https://www.gatsbyjs.org/) या [Next.js](https://nextjs.org/) का उपयोग करें। Create React App के विपरीत, Gatsby वेबसाइट को बिल्ड टाइम पर HTML में प्री-रेंडर करता है। Next.js सर्वर रेंडरिंग और प्री-रेंडरिंग दोनों को सपोर्ट करता है।

- अंत में, यदि आपको **अधिक कस्टमाइजेशन** की आवश्यकता है, तो देखें [Neutrino](https://neutrino.js.org/) और इसका [React प्रीसेट](https://neutrino.js.org/packages/react/)।

उपरोक्त सभी टूल्स कम या बिना किसी कॉन्फ़िगरेशन के काम कर सकते हैं।

अगर आप बिल्ड को खुद कॉन्फ़िगर करना पसंद करते हैं, तो [यह गाइड फॉलो करें](https://reactjs.org/docs/add-react-to-a-website.html)।

## React Native

कुछ ऐसा खोज रहे हैं, लेकिन React Native के लिए?<br>
[Expo CLI](https://github.com/expo/expo-cli) देखें।

## योगदान

हम `create-react-app` में आपकी मदद का स्वागत करते हैं! [CONTRIBUTING.md](CONTRIBUTING.md) में देखें कि हम क्या देख रहे हैं और कैसे शुरू करें।

## Create React App को समर्थन देना

Create React App एक सामुदायिक रूप से मेंटेन किया गया प्रोजेक्ट है और सभी योगदानकर्ता स्वयंसेवक हैं। यदि आप Create React App के भविष्य के विकास का समर्थन करना चाहते हैं तो कृपया हमारे [Open Collective](https://opencollective.com/create-react-app) को दान देने पर विचार करें।

## श्रेय

यह प्रोजेक्ट उन सभी लोगों के कारण अस्तित्व में है जिन्होंने [योगदान दिया](CONTRIBUTING.md)।<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

हमारे दस्तावेज़ की होस्टिंग के लिए [Netlify](https://www.netlify.com/) का धन्यवाद।

## आभार

हम संबंधित मौजूदा प्रोजेक्ट्स के लेखकों के विचारों और सहयोग के लिए आभारी हैं:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## लाइसेंस

Create React App एक ओपन सोर्स सॉफ़्टवेयर है [MIT लाइसेंस](https://github.com/facebook/create-react-app/blob/main/LICENSE) के तहत। Create React App का लोगो [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/) के तहत लाइसेंस प्राप्त है।

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---