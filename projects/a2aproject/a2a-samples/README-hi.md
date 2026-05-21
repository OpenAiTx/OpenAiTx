# एजेंट2एजेंट (A2A) नमूने

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Firebase स्टूडियो में आज़माएँ"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 भाषा</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
    </div>
  </details>
</div>

[Agent2Agent (A2A) प्रोटोकॉल](https://goo.gle/a2a) के लिए आधिकारिक कोड सैंपल और डेमोंस्ट्रेशन में आपका स्वागत है।

हम आपको यहां पाकर बहुत उत्साहित हैं! चाहे आप पहली बार मल्टी-एजेंट आर्किटेक्चर का अन्वेषण कर रहे हों या उन्नत इंटरऑपरेबल एजेंट नेटवर्क बना रहे हों, यह रिपॉजिटरी आपके विकास को तेज करने के लिए सरल, प्रेरणादायक और सुलभ लर्निंग संसाधन प्रदान करती है।

## Agent2Agent क्यों?

विविध AI फ्रेमवर्क और इकोसिस्टम की दुनिया में, एजेंट्स को संवाद, सहयोग और कार्यों को सुरक्षित रूप से सौंपने के लिए एक सामान्य भाषा की आवश्यकता होती है। A2A प्रोटोकॉल मल्टी-एजेंट इंटरऑपरेबिलिटी के लिए एक मानकीकृत, ओपन स्टैंडर्ड स्थापित करता है।

हमारे सैंपल दिखाते हैं कि विभिन्न भाषाओं और होस्ट एप्लिकेशन में जटिल मल्टी-एजेंट समस्याओं को कितनी आसानी से हल किया जा सकता है।

## त्वरित प्रारंभ

हमारे Python CLI होस्ट के माध्यम से Helloworld एजेंट लॉन्च करके तुरंत शुरू करें और उससे संवाद करें।

1. **एजेंट सर्वर प्रारंभ करें**:
   एक टर्मिनल खोलें और Helloworld एजेंट सर्वर प्रारंभ करें:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **होस्ट क्लाइंट चलाएं**:
   दूसरा टर्मिनल खोलें और CLI क्लाइंट को चलाकर एजेंट को टास्क भेजें:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## रिपॉजिटरी संरचना

रिपॉजिटरी को भाषा के अनुसार कई मुख्य निर्देशिकाओं में व्यवस्थित किया गया है:

| निर्देशिका | विवरण |
| --- | --- |
| [samples](/samples) | कोर A2A सैंपल्स, प्रोग्रामिंग भाषा के अनुसार व्यवस्थित। |
| [samples/python](/samples/python) | A2A Python SDK का उपयोग करते हुए Python एजेंट इम्प्लीमेंटेशन का प्रदर्शन करता है। |
| [samples/go](/samples/go) | A2A Go SDK का उपयोग करते हुए Go एजेंट इम्प्लीमेंटेशन का प्रदर्शन करता है। |
| [samples/dotnet](/samples/dotnet) | A2A .NET SDK का उपयोग करते हुए C# एजेंट इम्प्लीमेंटेशन का प्रदर्शन करता है। |
| [samples/java](/samples/java) | A2A Java SDK का उपयोग करते हुए Java एजेंट इम्प्लीमेंटेशन का प्रदर्शन करता है। |
| [samples/js](/samples/js) | A2A JavaScript SDK का उपयोग करते हुए Node.js एजेंट इम्प्लीमेंटेशन का प्रदर्शन करता है। |

## योगदान

हम सभी कौशल स्तरों के योगदानों का स्वागत और प्रोत्साहन करते हैं! यदि आपके पास नया सैंपल, बग फिक्स या दस्तावेज़ीकरण में सुधार का कोई विचार है, तो कृपया हमारा [Contributing Guide](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) देखें।

## सहायता प्राप्त करना

हम एक स्वागतपूर्ण और सहायक समुदाय प्रदान करने के लिए प्रतिबद्ध हैं। यदि आपके पास कोई प्रश्न, प्रतिक्रिया है या किसी समस्या का सामना कर रहे हैं, तो कृपया हमारे [issues page](https://github.com/a2aproject/a2a-samples/issues) पर पहुँचें।

## संबंधित रिपॉजिटरी

| रिपॉजिटरी | श्रेणी | विवरण |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | कोर स्पेसिफिकेशन | A2A स्पेसिफिकेशन और दस्तावेज़ीकरण। |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | टूलिंग | A2A सक्षम एजेंट्स के निरीक्षण के लिए UI टूल। |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | टेस्टिंग | A2A प्रोटोकॉल कंप्लायंस के सत्यापन के लिए टेस्ट सूट। |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | टेस्टिंग | विभिन्न A2A SDK इम्प्लीमेंटेशन और संस्करणों के बीच संगतता सत्यापित करने के लिए टूलकिट, मल्टी-हॉप ट्रैवर्सल मॉडल और विभिन्न ट्रांसपोर्ट प्रोटोकॉल का उपयोग करता है। |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | A2A के लिए आधिकारिक Python SDK। |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | A2A के लिए आधिकारिक Go SDK। |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | A2A के लिए आधिकारिक Java SDK। |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | A2A के लिए आधिकारिक Node.js/JavaScript SDK। |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | A2A के लिए आधिकारिक C#/.NET SDK। |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | A2A के लिए आधिकारिक Rust SDK। |

## अस्वीकरण

**महत्वपूर्ण:** प्रदान किया गया सैंपल कोड केवल प्रदर्शन के उद्देश्य के लिए है और तंत्र को दर्शाता है
एजेंट-टू-एजेंट (A2A) प्रोटोकॉल। प्रोडक्शन एप्लिकेशन बनाते समय, किसी भी एजेंट को जो आपकी डायरेक्ट कंट्रोल से बाहर है, एक संभावित अविश्वसनीय इकाई के रूप में देखना महत्वपूर्ण है।

किसी बाहरी एजेंट से प्राप्त सभी डेटा—जिसमें उसके AgentCard, संदेश, आर्टिफैक्ट्स, और टास्क स्टेटस शामिल हैं लेकिन इन्हीं तक सीमित नहीं हैं—को अविश्वसनीय इनपुट के रूप में हैंडल करना चाहिए। उदाहरण के लिए, एक दुर्भावनापूर्ण एजेंट अपने AgentCard के फील्ड्स (जैसे, विवरण, नाम, skills.description) में कस्टम डेटा प्रदान कर सकता है। यदि इस डेटा का उपयोग बिना सैनिटाइज किए Large Language Model (LLM) के लिए प्रॉम्प्ट बनाने में किया जाता है, तो यह आपके एप्लिकेशन को प्रॉम्प्ट इंजेक्शन अटैक के लिए एक्सपोज़ कर सकता है। इस डेटा का उपयोग करने से पहले ठीक से वैलिडेट और सैनिटाइज न करने पर आपके एप्लिकेशन में सुरक्षा कमजोरियां उत्पन्न हो सकती हैं।

> डेवलपर्स अपने सिस्टम और यूजर्स की सुरक्षा के लिए इनपुट वैलिडेशन और क्रेडेंशियल्स की सुरक्षित हैंडलिंग जैसे उपयुक्त सुरक्षा उपायों को लागू करने के लिए जिम्मेदार हैं।
>









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---