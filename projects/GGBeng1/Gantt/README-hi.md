# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## स्थापना

```
yarn install
```

### रन करें

```
yarn run serve
```

### विवरण

```
vue आधारित विकसित गैंट चार्ट प्रदर्शनी, जिसे टीम सहयोग, कार्य विभाजन आदि एगाइल परिदृश्यों में उपयोग किया जा सकता है

समूह समर्थन करता है
ड्रैग और ड्रॉप समर्थन करता है
खींचने (रिसाइज़) का समर्थन करता है
प्रतिशत का समर्थन करता है
समय अवधि का समर्थन करता है: दिन, सप्ताह, महीना
वर्तमान में केवल एक स्तर का समूह लिखा गया है, भविष्य में दो या अधिक स्तर के समूह की आवश्यकता से बचने के लिए, पिछली कमिट में कुछ कोड को पुनः संरचित किया गया है, जिससे बहु-स्तरीय समूहों का समर्थन मिल सके, लेकिन वर्तमान संस्करण में इसका विकास नहीं हुआ है

फायदे: ड्रैग, रिसाइज़, प्रगति बदलने जैसे ऑपरेशन के समय डेटा को रीयल-टाइम में अपडेट नहीं किया जाता है, बल्कि ऑपरेशन के बाद अपडेट किया जाता है, जिससे प्रदर्शन पर प्रभाव कम होता है
      संपादन, हटाने, जोड़ने के समय पूरे उदाहरण को पुनरावर्ती रूप से संशोधित नहीं किया जाता, बल्कि केवल बदले गए हिस्से को ही जोड़ा, हटाया या संशोधित किया जाता है

पुनः संगठन की तैयारी चल रही है, घटक-आधारित (कंपोनेंटाइजेशन) के लिए, वर्तमान में प्रोजेक्ट में उपयोग हेतु केवल इस प्रोजेक्ट के `gant.vue` को इम्पोर्ट करना पर्याप्त है
बड़े पैमाने पर डेटा आयात/निर्यात विधि तैयार है, बस कॉपी करें!~

```

### अद्यतन विवरण

- संपादन का समर्थन करता है
- हटाने का समर्थन करता है
- वर्टिकल स्क्रॉल न हो पाने की बग को ठीक किया (साथ ही दो-तरफा एक साथ स्क्रॉलिंग जोड़ा) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- elementUI के कारण होने वाली बग को ठीक किया
- समय अवधि से संबंधित समस्या [#5](https://github.com/GGBeng1/Gantt/issues/5)
- वर्तमान में अन्य अवधि (जैसे घंटे जोड़ना आदि) को अवधि कॉन्फ़िगरेशन बदलकर प्राप्त नहीं किया जा सकता। क्योंकि इनिशियलाइज़ेशन के समय कुछ कॉन्फ़िगरेशन सीधे फिक्स्ड है, आगे चलकर इसे API के रूप में उपलब्ध कराया जाएगा

### उदाहरण देखें

[डेमो देखें](https://ggbeng1.github.io/Gantt/#/)

### प्रदर्शन चित्र

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---