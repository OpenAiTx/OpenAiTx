<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>एक बार सीखें, कहीं भी लिखें:</strong><br>
  React के साथ मोबाइल ऐप्स बनाएं।
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native is released under the MIT license." />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="Current npm package version." />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs welcome!" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="Follow @reactnative" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">शुरुआत करें</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">बुनियादी बातें सीखें</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">प्रदर्शनी</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">योगदान करें</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">समुदाय</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">सहायता</a>
</h3>

React Native [**React**'s][r] घोषणात्मक UI फ्रेमवर्क को iOS और Android पर लाता है। React Native के साथ, आप नेटिव UI नियंत्रणों का उपयोग करते हैं और नेटिव प्लेटफ़ॉर्म तक पूरी पहुंच रखते हैं।

- **घोषणात्मक।** React के साथ इंटरैक्टिव UI बनाना आसान है। घोषणात्मक दृश्य आपके कोड को अधिक अनुमानित और डिबग करने में आसान बनाते हैं।
- **कंपोनेंट-आधारित।** ऐसे संलग्नित कंपोनेंट्स बनाएं जो अपनी स्थिति को संभालते हैं, फिर उन्हें मिलाकर जटिल UI बनाएं।
- **डेवलपर गति।** सेकंडों में स्थानीय परिवर्तन देखें। जावास्क्रिप्ट कोड में बदलाव बिना नेटिव ऐप को फिर से बनाए लाइव रीलोड किए जा सकते हैं।
- **पोर्टेबिलिटी।** iOS, Android, और [अन्य प्लेटफ़ॉर्म][p] में कोड का पुन: उपयोग करें।

React Native को कई कंपनियों और व्यक्तिगत कोर योगदानकर्ताओं द्वारा विकसित और समर्थित किया गया है। हमारे [इकोसिस्टम अवलोकन][e] में और जानें।

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## सामग्री

- [आवश्यकताएँ](#-requirements)
- [अपना पहला React Native ऐप बनाना](#-building-your-first-react-native-app)
- [दस्तावेज़ीकरण](#-documentation)
- [अपग्रेडिंग](#-upgrading)
- [कैसे करें योगदान](#-how-to-contribute)
- [आचार संहिता](#code-of-conduct)
- [लाइसेंस](#-license)


## 📋 आवश्यकताएँ

React Native ऐप्स iOS 15.1 और Android 7.0 (API 24) या नए को लक्षित कर सकते हैं। आप विंडोज़, मैकओएस, या लिनक्स को अपने विकास ऑपरेटिंग सिस्टम के रूप में उपयोग कर सकते हैं, हालांकि iOS ऐप्स बनाना और चलाना केवल मैकओएस तक सीमित है। [Expo](https://expo.dev) जैसे टूल्स का उपयोग इस सीमा को दूर करने के लिए किया जा सकता है।

## 🎉 अपना पहला React Native ऐप बनाना

[शुरुआत गाइड](https://reactnative.dev/docs/getting-started) का पालन करें। React Native को स्थापित करने का अनुशंसित तरीका आपके प्रोजेक्ट पर निर्भर करता है। यहाँ सबसे सामान्य परिस्थितियों के लिए छोटे-छोटे गाइड्स दिए गए हैं:

- [React Native आज़माएं][hello-world]
- [एक नया एप्लिकेशन बनाना][new-app]
- [मौजूदा एप्लिकेशन में React Native जोड़ना][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 दस्तावेज़ीकरण

React Native के लिए पूरी दस्तावेज़ीकरण हमारे [वेबसाइट][docs] पर उपलब्ध है।

React Native दस्तावेज़ीकरण उन कंपोनेंट्स, API, और विषयों पर चर्चा करता है जो React Native के लिए विशिष्ट हैं। React Native और React DOM के बीच साझा किए गए React API के लिए आगे की दस्तावेज़ीकरण हेतु [React दस्तावेज़ीकरण][r-docs] देखें।

React Native दस्तावेज़ीकरण और वेबसाइट का स्रोत एक अलग भंडार में होस्ट किया गया है, [**@facebook/react-native-website**][repo-website]।

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 अपग्रेडिंग

React Native के नए संस्करणों में अपग्रेड करने से आपको अधिक API, दृश्य, डेवलपर टूल्स, और अन्य सुविधाओं तक पहुँच मिल सकती है। निर्देशों के लिए [अपग्रेडिंग गाइड][u] देखें।

React Native रिलीज़ के बारे में [इस चर्चा रिपॉज़िटरी](https://github.com/reactwg/react-native-releases/discussions) में चर्चा की जाती है।

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 कैसे करें योगदान

इस रिपॉज़िटरी का मुख्य उद्देश्य React Native कोर का निरंतर विकास है। हम चाहते हैं कि इस प्रोजेक्ट में योगदान करना यथासंभव आसान और पारदर्शी हो, और हम बग फिक्स और सुधारों के लिए समुदाय के आभारी हैं। जानने के लिए पढ़ें कि आप React Native को बेहतर बनाने में कैसे भाग ले सकते हैं।

### [आचार संहिता][code]

Facebook ने एक आचार संहिता अपनाई है जिसकी हम अपेक्षा करते हैं कि प्रोजेक्ट प्रतिभागी पालन करेंगे।
कृपया [पूरा पाठ][code] पढ़ें ताकि आप समझ सकें कि कौन से कार्य स्वीकार्य हैं और कौन से नहीं।

[code]: https://code.fb.com/codeofconduct/

### [योगदान गाइड][contribute]

हमारे विकास प्रक्रिया, बग फिक्स और सुधारों का प्रस्ताव कैसे करें, और अपने बदलावों का निर्माण और परीक्षण कैसे करें, जानने के लिए हमारा [**योगदान गाइड**][contribute] पढ़ें।

[contribute]: https://reactnative.dev/docs/contributing

### [ओपन सोर्स रोडमैप][roadmap]

React Native के लिए हमारी दृष्टि के बारे में आप [**रोडमैप**][roadmap] में और जान सकते हैं।

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### अच्छी पहली समस्याएँ

हमारे पास [अच्छी पहली समस्याओं][gfi] की एक सूची है जिनमें सीमित दायरे की बग्स होती हैं। यह आरंभ करने, अनुभव प्राप्त करने और हमारे योगदान प्रक्रिया से परिचित होने के लिए शानदार जगह है।

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### चर्चाएँ

बड़ी चर्चाएँ और प्रस्ताव [**@react-native-community/discussions-and-proposals**][repo-meta] में की जाती हैं।

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 लाइसेंस

React Native MIT लाइसेंस के अंतर्गत लाइसेंस प्राप्त है, जैसा कि [LICENSE][l] फ़ाइल में पाया जा सकता है।

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---