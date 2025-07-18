# Agent2Agent (A2A) नमूने

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

यह रिपॉज़िटरी [Agent2Agent (A2A) प्रोटोकॉल](https://goo.gle/a2a) का उपयोग करने वाले कोड नमूने और डेमो शामिल करती है।

## संबंधित रिपॉज़िटरी

- [A2A](https://github.com/a2aproject/A2A) - A2A विनिर्देश और प्रलेखन।
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A पायथन SDK।
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A सक्षम एजेंटों के निरीक्षण के लिए UI टूल।

## योगदान करना

योगदान का स्वागत है! [योगदान गाइड](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) देखें।

## सहायता प्राप्त करना

कृपया सुझाव, प्रतिक्रिया या बग रिपोर्ट देने के लिए [इश्यू पृष्ठ](https://github.com/a2aproject/a2a-samples/issues) का उपयोग करें।

## अस्वीकरण

यह रिपॉज़िटरी स्वयं एक आधिकारिक रूप से समर्थित Google उत्पाद नहीं है। इस रिपॉज़िटरी में दिया गया कोड केवल प्रदर्शन हेतु है।

महत्वपूर्ण: प्रदान किया गया सैंपल कोड केवल प्रदर्शन हेतु है और Agent-to-Agent (A2A) प्रोटोकॉल की कार्यप्रणाली को दर्शाता है। जब आप प्रोडक्शन एप्लिकेशन बना रहे हों, तो आपके प्रत्यक्ष नियंत्रण से बाहर किसी भी एजेंट को संभावित रूप से अविश्वसनीय इकाई मानना आवश्यक है।

किसी बाहरी एजेंट से प्राप्त सभी डेटा—जिसमें इसका AgentCard, संदेश, आर्टिफैक्ट्स और कार्य की स्थिति शामिल है लेकिन इन्हीं तक सीमित नहीं है—को अविश्वसनीय इनपुट के रूप में संभालना चाहिए। उदाहरण के लिए, एक दुर्भावनापूर्ण एजेंट अपने फ़ील्ड्स (जैसे विवरण, नाम, कौशल.विवरण) में तैयार किया गया डेटा युक्त एक AgentCard प्रदान कर सकता है। यदि इस डेटा का उपयोग बिना स्वच्छता के किसी बड़े भाषा मॉडल (LLM) के लिए प्रॉम्प्ट बनाने में किया जाता है, तो यह आपके एप्लिकेशन को प्रॉम्प्ट इंजेक्शन हमलों के प्रति संवेदनशील बना सकता है। इस डेटा को उपयोग से पहले ठीक से सत्यापित और स्वच्छ न करने पर आपके एप्लिकेशन में सुरक्षा कमजोरियां आ सकती हैं।

डेवलपर्स के लिए यह आवश्यक है कि वे उचित सुरक्षा उपाय लागू करें, जैसे कि इनपुट सत्यापन और क्रेडेंशियल्स का सुरक्षित प्रबंधन, ताकि वे अपनी प्रणालियों और उपयोगकर्ताओं की सुरक्षा कर सकें।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---