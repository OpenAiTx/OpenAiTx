<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

MyFitnessPal का एक स्व-होस्टेड, प्राइवेसी-फर्स्ट विकल्प। पोषण, व्यायाम, शरीर के मापदंडों और स्वास्थ्य डेटा को ट्रैक करें और अपने डेटा पर पूरा नियंत्रण रखें।

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness एक स्व-होस्टेड फिटनेस ट्रैकिंग प्लेटफॉर्म है, जिसमें शामिल हैं:

- एक बैकएंड सर्वर (API + डेटा स्टोरेज)
- एक वेब-आधारित फ्रंटएंड
- iOS और Android के लिए नेटिव मोबाइल ऐप्स

यह आपके नियंत्रण में मौजूद इन्फ्रास्ट्रक्चर पर स्वास्थ्य डेटा को संग्रहीत और प्रबंधित करता है, बिना किसी तृतीय-पक्ष सेवाओं पर निर्भर हुए।

## मुख्य विशेषताएँ

- पोषण, व्यायाम, जलयोजन, नींद, उपवास, मूड और शरीर माप ट्रैकिंग
- लक्ष्य निर्धारण और दैनिक चेक-इन
- इंटरएक्टिव चार्ट्स और दीर्घकालिक रिपोर्ट्स
- बहु-उपयोगकर्ता प्रोफ़ाइल और परिवार की पहुंच
- लाइट और डार्क थीम्स
- OIDC, TOTP, पासकी, MFA आदि।

## स्वास्थ्य एवं डिवाइस इंटीग्रेशन

SparkyFitness अनेक स्वास्थ्य और फिटनेस प्लेटफार्म से डेटा सिंक कर सकता है:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (आंशिक रूप से परीक्षणित)
- **Hevy** (परीक्षण नहीं किया गया)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (आंशिक रूप से परीक्षणित)

इंटीग्रेशन स्वचालित रूप से आपके SparkyFitness सर्वर पर कदम, वर्कआउट, नींद जैसी गतिविधि डेटा के साथ-साथ वजन और शरीर माप जैसी स्वास्थ्य मेट्रिक्स को सिंक कर देता है।

## वैकल्पिक AI फीचर्स (बीटा)

SparkyAI डेटा लॉगिंग और प्रगति समीक्षा के लिए संवादात्मक इंटरफेस प्रदान करता है।

- चैट के माध्यम से भोजन, व्यायाम, शरीर के आंकड़े, और कदम लॉग करें
- स्वचालित भोजन लॉगिंग के लिए भोजन की छवियाँ अपलोड करें
- अनुवर्ती के लिए वार्तालाप इतिहास बनाए रखता है

नोट: एआई सुविधाएँ वर्तमान में बीटा में हैं।

## त्वरित प्रारंभ (सर्वर)

डॉकर कंपोज़ का उपयोग करके कुछ ही मिनटों में एक स्पार्कीफिटनेस सर्वर चलाएँ।

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 वीडियो ट्यूटोरियल

[![वीडियो देखें](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

त्वरित 2-मिनट का ट्यूटोरियल जिसमें बताया गया है कि SparkyFitness (सेल्फ-होस्टेड फिटनेस ट्रैकर) को कैसे इंस्टॉल करें।


## प्रलेखन

पूर्ण इंस्टॉलेशन गाइड, कॉन्फ़िगरेशन विकल्प, और विकास दस्तावेज़ के लिए कृपया हमारी [प्रलेखन साइट](https://codewithcj.github.io/SparkyFitness/) देखें।

### त्वरित लिंक

- **[इंस्टॉलेशन गाइड](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - डिप्लॉयमेंट और कॉन्फ़िगरेशन
- **[विशेषताओं का अवलोकन](https://codewithcj.github.io/SparkyFitness/features)** - संपूर्ण फीचर प्रलेखन
- **[डेवलपमेंट वर्कफ़्लो](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - डेवलपर गाइड और योगदान प्रक्रिया
- **[iOS ऐप जानकारी](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** और **[Android ऐप जानकारी](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### सहायता चाहिए?

- Github इश्यू/चर्चा में पोस्ट करें।
- तेज़ प्रतिक्रिया के लिए और अन्य समुदाय सदस्यों से सहायता पाने के लिए **[हमारे डिस्कॉर्ड में शामिल हों](https://discord.gg/vcnMT5cPEA)**

## स्टार इतिहास

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="स्टार इतिहास चार्ट" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## अनुवाद

**[वेबलेट अनुवाद](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="अनुवाद स्थिति" />
</a>

## रिपॉजिटरी गतिविधि

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats विश्लेषण छवि")

## योगदानकर्ता

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ ज्ञात समस्याएँ / बीटा सुविधाएँ ⚠️

SparkyFitness सक्रिय विकास में है।
रिलीज़ के बीच ब्रेकिंग बदलाव हो सकते हैं।

- ऑटो-अपडेटिंग कंटेनर की सिफारिश नहीं की जाती
- अपग्रेड करने से पहले हमेशा रिलीज़ नोट्स की समीक्षा करें

निम्नलिखित सुविधाएँ वर्तमान में बीटा में हैं और इन्हें पूरी तरह से टेस्ट नहीं किया गया है। संभावित बग या अधूरी कार्यक्षमता की अपेक्षा करें:

- एआई चैटबोट
- परिवार और दोस्तों की पहुँच
- एपीआई प्रलेखन


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---