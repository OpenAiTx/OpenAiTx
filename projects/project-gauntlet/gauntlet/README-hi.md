# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="assets/linux/icon_256.png">

वेब-प्रथम क्रॉस-प्लेटफ़ॉर्म एप्लिकेशन लॉन्चर, जिसमें React-आधारित प्लगइन्स होते हैं

> [!WARNING]
> लॉन्चर एकल डेवलपर द्वारा उनके खाली समय में विकसित किया जा रहा है।
> बदलाव धीमे लेकिन स्थिर हो सकते हैं
>
> इसमें संभवतः ब्रेकिंग चेंजेज़ होंगे, जिनका उल्लेख [changelog](CHANGELOG.md) में किया जाएगा।

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## डेमो

थोड़ा पुराना डेमो

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## विशेषताएँ

- प्लगइन-प्रथम
  - प्लगइन्स TypeScript में लिखे जाते हैं
  - व्यापक प्लगइन API 
      - UI दृश्य बनाएँ
      - एक-शॉट कमांड्स
      - एक-शॉट कमांड्स की सूची डायनामिकली प्रदान करें
      - मुख्य सर्च बार में दिए गए मान के आधार पर उसके ठीक नीचे "इनलाइन" कंटेंट को तुरंत रेंडर करें
      - क्लिपबोर्ड से कंटेंट प्राप्त करें और उसमें जोड़ें
  - प्लगइन्स Git रिपोजिटरी में एक अलग ब्रांच के रूप में वितरित किए जाते हैं, जिससे प्लगइन वितरण के लिए किसी सेंट्रल सर्वर की आवश्यकता नहीं होती
  - प्लगइन IDs केवल Git रिपोजिटरी URLs होते हैं
  - [React](https://github.com/facebook/react)-आधारित UI प्लगइन्स के लिए
    - कस्टम React Reconciler का उपयोग कर इम्प्लीमेंट किया गया (कोई Electron नहीं)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno JavaScript प्लगइन कोड को बेहतर सुरक्षा के लिए सैंडबॉक्स करने देता है
    - प्लगइन्स को स्पष्ट रूप से बताना होता है कि उन्हें कार्य करने के लिए कौन-कौन सी अनुमतियाँ चाहिए
    - Node.js का उपयोग प्लगइन टूलिंग चलाने के लिए होता है, लेकिन एक प्लगइन डेवलपर के रूप में आप हमेशा ऐसा कोड लिखेंगे जो Deno पर चले
- शुरुआत से ही क्रॉस-प्लेटफ़ॉर्म के लिए डिज़ाइन किया गया
- कमांड्स और व्यूज़ को कस्टम ग्लोबल शॉर्टकट्स का उपयोग कर रन/ओपन किया जा सकता है
- कमांड्स या व्यूज़ को कस्टम सर्च एलियास असाइन किया जा सकता है
- कस्टम थीम सपोर्ट
- बिल्ट-इन फंक्शनैलिटी बंडल किए गए प्लगइन्स द्वारा प्रदान की जाती है
  - एप्लिकेशंस: सर्च रिज़ल्ट्स में सिस्टम पर इंस्टॉल किए गए एप्लिकेशंस दिखाता है
    - प्लगइन विंडोज़ और किस एप्लिकेशन से संबंधित हैं, यह भी ट्रैक करता है, इसलिए पहले से खुला एप्लिकेशन खोलने पर डिफॉल्ट रूप से पूर्व में बनी विंडो ही सामने आएगी
      - अभी सभी सिस्टम्स सपोर्टेड नहीं हैं। देखें [feature support](https://gauntlet.sh/docs/feature-support)
  - कैलकुलेटर: मुख्य सर्च बार के ठीक नीचे गणितीय ऑपरेशंस का परिणाम दिखाता है
    - इसमें एक्सचेंज रेट्स के द्वारा करेंसी कन्वर्ज़न भी शामिल है
    - संचालित [Numbat](https://github.com/sharkdp/numbat) द्वारा
- Frecency-आधारित सर्च रिज़ल्ट क्रम
   - Frecency आवृत्ति (frequency) और नवीनता (recency) का संयोजन है
   - जितना अधिक किसी आइटम का उपयोग होगा, वह परिणाम सूची में उतना ऊपर होगा, लेकिन जिन आइटम्स का अतीत में बहुत उपयोग हुआ है, वे हाल ही में उतनी ही बार उपयोग किए गए आइटम्स की तुलना में नीचे रैंक होंगे
   - परिणाम शब्द दर शब्द सबस्ट्रिंग द्वारा मिलाए जाते हैं

##### OS समर्थन

##### आधिकारिक
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### सर्वोत्तम प्रयास
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland अभी तक समर्थित नहीं है, देखें [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## शुरुआत करें

### Gauntlet इंस्टॉल करें

देखें [इंस्टॉलेशन](https://gauntlet.sh/docs/installation)

### ग्लोबल शॉर्टकट

मुख्य विंडो को ग्लोबल शॉर्टकट या CLI कमांड से खोला जा सकता है:
- ग्लोबल शॉर्टकट (सेटिंग्स में बदला जा सकता है)
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - ग्लोबल शॉर्टकट समर्थित नहीं हो सकता, देखें [feature support](https://gauntlet.sh/docs/feature-support)
    - कृपया CLI कमांड का उपयोग करें, और उसे विंडो मैनेजर विशेष तरीके से इनवोक करें
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- CLI कमांड
  - `gauntlet open`

### प्लगइन इंस्टॉल करें

प्लगइन्स को Settings UI में इंस्टॉल किया जाता है। इंस्टॉल करने के लिए प्लगइन का Git रिपोजिटरी URL उपयोग करें, जैसे `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](docs/settings_ui.png)

### अपना खुद का प्लगइन बनाएँ

देखें [प्लगइन डेवलपमेंट के साथ शुरुआत](https://gauntlet.sh/docs/plugin-development/getting-started)

## थीमिंग

देखें [थीमिंग](https://gauntlet.sh/docs/theming)

## Gauntlet बिल्ड करना

आपको आवश्यकता होगी:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (प्रोजेक्ट द्वारा सीधे उपयोग नहीं, लेकिन एक डिपेंडेंसी के लिए आवश्यक)
- Linux पर: `libxkbcommon-dev` (नोट: नाम डिस्ट्रीब्यूशन के अनुसार अलग हो सकता है)

### Dev

डेव बिल्ड चलाने के लिए:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
डेव में (बिना "release" फीचर के) एप्लिकेशन केवल प्रोजेक्ट डायरेक्टरी के अंदर ही स्टेट या कैश स्टोर करेगा, जिससे वैश्विक इंस्टॉलेशन में कोई गड़बड़ी नहीं होगी

### Not-yet-packaged

पैकेज्ड न किए गए रिलीज़ बाइनरी के लिए:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Packaged
OS-विशिष्ट पैकेज बनाने के लिए निम्न में से एक चलाएँ:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

लेकिन नए संस्करण का रिलीज़ GitHub Actions के माध्यम से ही किया जाना चाहिए

## योगदान

यदि आप Gauntlet को बनाने में मदद करना चाहते हैं, तो आप कोड योगदान देने के अलावा भी कई तरीकों से योगदान कर सकते हैं:
- बग या UI/UX समस्या की रिपोर्टिंग
- एक प्लगइन बनाना

सरल समस्याओं के लिए, स्वतंत्र रूप से एक issue या PR खोलें और खुद ही हल करें। 
अधिक महत्वपूर्ण बदलावों के लिए, कृपया पहले Discord (README के ऊपर निमंत्रण लिंक) पर क्रिएटर्स से संपर्क करें और चर्चा करें।

सभी प्रकार के योगदान का स्वागत है।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---