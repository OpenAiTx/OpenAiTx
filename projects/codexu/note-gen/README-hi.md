![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## गाइड

NoteGen एक क्रॉस-प्लेटफ़ॉर्म `Markdown` नोट लेने वाला एप्लिकेशन है, जो रिकॉर्डिंग और लेखन के बीच AI का उपयोग करके पुल बनाने के लिए समर्पित है, और बिखरे हुए ज्ञान को एक पठनीय नोट में व्यवस्थित करता है।

🖥️ आधिकारिक दस्तावेज़: [https://notegen.top](https://notegen.top)

💬 [WeChat/QQ समूह](https://github.com/codexu/note-gen/discussions/110) से जुड़ें

## NoteGen क्यों चुनें?

- हल्का: [इंस्टॉलेशन पैकेज](https://github.com/codexu/note-gen/releases) **सिर्फ 20MB** है, मुफ्त, बिना विज्ञापन या बंडल सॉफ़्टवेयर के।
- क्रॉस-प्लेटफ़ॉर्म: Mac, Windows, Linux को सपोर्ट करता है, और `Tauri2` की क्रॉस-प्लेटफ़ॉर्म क्षमता की वजह से भविष्य में iOS और Android को भी सपोर्ट करेगा।
- कई रिकॉर्डिंग विधाओं का समर्थन करता है जैसे `स्क्रीनशॉट्स`, `टेक्स्ट`, `चित्रण`, `फाइलें`, `लिंक` आदि, विभिन्न परिदृश्यों में बिखरे हुए रिकॉर्डिंग की आवश्यकता को पूरा करता है।
- मूल `Markdown(.md)` को स्टोरेज फॉर्मेट के रूप में उपयोग करता है, बिना किसी परिवर्तन के, माइग्रेट करना आसान।
- मूल रूप से ऑफलाइन उपयोग, `GitHub, Gitee प्राइवेट रिपॉजिटरी` के साथ रियल-टाइम सिंक्रोनाइज़ेशन का समर्थन करता है, इतिहास को वापस लाने का विकल्प और WebDAV सिंक्रोनाइज़ेशन।
- AI-सशक्त: ChatGPT, Gemini, Ollama, LM Studio, Grok, और अन्य मॉडलों के साथ कॉन्फ़िगर करने योग्य, कस्टम थर्ड-पार्टी मॉडल कॉन्फ़िगरेशन का समर्थन।
- RAG: आपके नोट्स आपका नॉलेज बेस हैं। एम्बेडिंग मॉडल और री-रैंकिंग मॉडल का समर्थन।

## स्क्रीनशॉट्स

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

रिकॉर्डिंग:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

लेखन:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

थीम:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## रिकॉर्डिंग से लेखन तक

पारंपरिक नोट लेने वाले एप्लिकेशन आमतौर पर रिकॉर्डिंग फंक्शनैलिटी प्रदान नहीं करते हैं। उपयोगकर्ताओं को रिकॉर्डिंग के लिए सामग्री को मैन्युअल रूप से कॉपी-पेस्ट करना पड़ता है, जिससे दक्षता बहुत कम हो जाती है। जब बिखरी हुई रिकॉर्डेड सामग्री का सामना करना पड़ता है, तो उसे व्यवस्थित करने में काफी प्रयास लगता है।

NoteGen को `रिकॉर्डिंग` और `लेखन` पृष्ठों में विभाजित किया गया है, जिनका संबंध इस प्रकार है:

- रिकॉर्डिंग्स को नोट्स में व्यवस्थित किया जा सकता है और गहन लेखन के लिए लेखन पृष्ठ पर स्थानांतरित किया जा सकता है।
- लेखन के दौरान, आप किसी भी समय रिकॉर्डिंग्स सम्मिलित कर सकते हैं।

### रिकॉर्डिंग

रिकॉर्डिंग फ़ंक्शन एक **AI चैटबोट** के समान है, लेकिन जब आप इससे बातचीत करते हैं, तो आप इसे पहले रिकॉर्ड किए गए कंटेंट के साथ जोड़ सकते हैं, जिससे बातचीत मोड से संगठन मोड में स्विच कर सकते हैं, और रिकॉर्डिंग्स को एक पठनीय नोट में व्यवस्थित कर सकते हैं।

निम्नलिखित सहायक विशेषताएँ आपको अधिक प्रभावी ढंग से रिकॉर्ड करने में मदद कर सकती हैं:

- **टैग्स** अलग-अलग रिकॉर्डिंग परिदृश्यों को अलग करने के लिए।
- **पर्सोना** कस्टम प्रॉम्प्ट के समर्थन के साथ, आपके AI सहायक को सटीक रूप से नियंत्रित करने के लिए।
- **क्लिपबोर्ड सहायक** जो स्वचालित रूप से आपके क्लिपबोर्ड में टेक्स्ट या छवियों की पहचान करता है और उन्हें आपकी सूची में रिकॉर्ड करता है।

### लेखन

लेखन अनुभाग दो भागों में विभाजित है: **फ़ाइल प्रबंधक** और **Markdown संपादक**।

**फ़ाइल प्रबंधक**

- स्थानीय मार्कडाउन फाइलों और GitHub सिंक्रनाइज़ की गई फाइलों के प्रबंधन का समर्थन करता है।
- असीमित डायरेक्टरी पदानुक्रम का समर्थन करता है।
- कई सॉर्टिंग विधियों का समर्थन करता है।

**Markdown संपादक**

- WYSIWYG, इंस्टेंट रेंडरिंग, और स्प्लिट-स्क्रीन प्रीव्यू मोड का समर्थन करता है।
- इतिहास रोलबैक के साथ संस्करण नियंत्रण का समर्थन करता है।
- बातचीत, निरंतरता, सुधार, और अनुवाद कार्यों के लिए AI सहायता का समर्थन करता है।
- इमेज होस्टिंग का समर्थन करता है, छवियों को अपलोड करता है और उन्हें Markdown छवि लिंक में बदलता है।
- HTML से Markdown में कन्वर्शन का समर्थन करता है, ब्राउज़र से कॉपी की गई सामग्री को स्वचालित रूप से Markdown फॉर्मेट में बदलता है।
- आउटलाइन, गणितीय सूत्र, माइंड मैप, चार्ट, फ्लोचार्ट, गैंट चार्ट, सीक्वेंस डायग्राम, स्टाफ, मल्टीमीडिया, वॉयस रीडिंग, शीर्षक एंकर, कोड हाइलाइटिंग और कॉपी, ग्राफ़विज़ रेंडरिंग, और plantuml UML डायग्राम का समर्थन करता है।
- रीयल-टाइम स्थानीय सामग्री सहेजना, विलंबित (10s तक बिना संपादन) स्वचालित सिंक्रनाइज़ेशन, और इतिहास रोलबैक का समर्थन करता है।

## अन्य विशेषताएँ

- त्वरित खोज के लिए ग्लोबल सर्च, जिससे आप विशिष्ट कंटेंट को तुरंत पा सकते हैं और उस पर जा सकते हैं।
- इमेज होस्टिंग प्रबंधन, जिससे इमेज रिपॉजिटरी के कंटेंट का प्रबंधन आसान होता है।
- थीम्स और अपीयरेंस, डार्क थीम और Markdown, कोड आदि के लिए उपस्थिति सेटिंग्स का समर्थन।
- अंतर्राष्ट्रीयकरण समर्थन, जो वर्तमान में चीनी और अंग्रेज़ी में उपलब्ध है।

## उपयोग कैसे करें?

### डाउनलोड

वर्तमान में Mac, Windows, और Linux को सपोर्ट करता है। Tauri2 की क्रॉस-प्लेटफ़ॉर्म क्षमता के कारण भविष्य में iOS और Android को भी सपोर्ट करेगा।

[NoteGen (alpha) डाउनलोड करें](https://github.com/codexu/note-gen/releases)

### एन्हांसमेंट

नोट लेने वाला एप्लिकेशन बिना किसी कॉन्फ़िगरेशन के सीधे उपयोग किया जा सकता है। यदि आप बेहतर अनुभव चाहते हैं, तो कृपया सेटिंग पृष्ठ खोलें और AI व सिंक्रनाइज़ेशन कॉन्फ़िगर करें।

## योगदान करें

- [योगदान गाइड पढ़ें](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [अपडेट योजनाएँ](https://github.com/codexu/note-gen/issues/46)
- [बग या सुधार सुझाव सबमिट करें](https://github.com/codexu/note-gen/issues)
- [चर्चाएँ](https://github.com/codexu/note-gen/discussions)

## योगदानकर्ता

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## स्टार इतिहास

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---