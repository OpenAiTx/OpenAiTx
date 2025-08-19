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

यह रिपॉजिटरी [Agent2Agent (A2A) प्रोटोकॉल](https://goo.gle/a2a) का उपयोग करने वाले कोड सैंपल और डेमो को शामिल करती है।

## संबंधित रिपॉजिटरी

- [A2A](https://github.com/a2aproject/A2A) - A2A विनिर्देशन और दस्तावेजीकरण।
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK।
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A सक्षम एजेंट्स के निरीक्षण के लिए UI टूल।

## योगदान

योगदान का स्वागत है! देखें [योगदान गाइड](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)।

## सहायता प्राप्त करना

कृपया सुझाव, प्रतिक्रिया देने या बग रिपोर्ट सबमिट करने के लिए [इश्यू पेज](https://github.com/a2aproject/a2a-samples/issues) का उपयोग करें।

## अस्वीकरण

यह रिपॉजिटरी स्वयं Google का आधिकारिक रूप से समर्थित उत्पाद नहीं है। इस रिपॉजिटरी में दिया गया कोड केवल प्रदर्शन के उद्देश्य से है।

महत्वपूर्ण: दिया गया नमूना कोड केवल प्रदर्शन के उद्देश्य से है और यह Agent-to-Agent (A2A) प्रोटोकॉल की यांत्रिकी को दर्शाता है। जब आप प्रोडक्शन एप्लिकेशन बनाते हैं, तो यह अत्यंत आवश्यक है कि आप अपनी प्रत्यक्ष निगरानी से बाहर काम कर रहे किसी भी एजेंट को संभावित रूप से अविश्वसनीय इकाई मानें।

किसी बाहरी एजेंट से प्राप्त सभी डेटा—जिसमें उसका AgentCard, संदेश, कलाकृतियाँ और कार्य की स्थिति शामिल है लेकिन सीमित नहीं है—को अविश्वसनीय इनपुट के रूप में संभालना चाहिए। उदाहरण के लिए, एक दुर्भावनापूर्ण एजेंट अपने फील्ड्स (जैसे विवरण, नाम, skills.description) में तैयार किया गया डेटा देने वाला AgentCard प्रदान कर सकता है। यदि इस डेटा को बिना स्वच्छता के किसी बड़े भाषा मॉडल (LLM) के लिए प्रॉम्प्ट बनाने में उपयोग किया जाता है, तो यह आपकी एप्लिकेशन को प्रॉम्प्ट इंजेक्शन हमलों के लिए उजागर कर सकता है। इस डेटा का उपयोग करने से पहले उचित रूप से सत्यापन और स्वच्छता न करने पर यह आपकी एप्लिकेशन में सुरक्षा कमजोरियाँ उत्पन्न कर सकता है।

डेवलपर्स को अपने सिस्टम और उपयोगकर्ताओं की सुरक्षा के लिए उपयुक्त सुरक्षा उपायों को लागू करने की जिम्मेदारी है, जैसे इनपुट सत्यापन और क्रेडेंशियल्स की सुरक्षित हैंडलिंग।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---