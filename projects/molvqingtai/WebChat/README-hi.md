<p align="center">
  <img src="https://github.com/molvqingtai/WebChat/blob/master/public/logo.png" width="200px"/>
</p>

# वेबचैट

[![GitHub License](https://img.shields.io/github/license/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/blob/master/LICENSE) [![Chrome Web Store Version](https://img.shields.io/chrome-web-store/v/cpaedhbidlpnbdfegakhiamfpndhjpgf)](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf) [![GitHub Release](https://img.shields.io/github/v/release/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/releases)

> किसी भी वेबसाइट पर किसी से भी चैट करें

यह एक गुमनाम चैट ब्राउज़र एक्सटेंशन है जो विकेंद्रीकृत और सर्वर रहित है, जिसमें एंड-टू-एंड एन्क्रिप्टेड संचार के लिए WebRTC का उपयोग किया गया है। यह गोपनीयता को प्राथमिकता देता है, क्योंकि सभी डेटा स्थानीय रूप से संग्रहीत होते हैं।

इसका उद्देश्य किसी भी वेबसाइट पर चैट रूम की सुविधा जोड़ना है, जिससे आप कभी अकेले महसूस नहीं करेंगे।

### इंस्टॉल करें

**स्टोर से इंस्टॉल करें**

- [क्रोम वेब स्टोर](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf)
- [एज वेब स्टोर](https://microsoftedge.microsoft.com/addons/detail/mmfdplbomjjlgdffecapcpgjmhfhmiob)
- [फायरफॉक्स ऐडऑन](https://addons.mozilla.org/firefox/addon/webchat/)

**मैनुअल इंस्टॉलेशन**

1. GitHub रिपॉजिटरी पर जाएँ ([रिलीज़](https://github.com/molvqingtai/WebChat/releases))
2. "Assets" बटन पर क्लिक करें और "web-chat-*.zip" चुनें
3. ZIP फ़ाइल को अपने कंप्यूटर के एक फ़ोल्डर में निकालें
4. अपने ब्राउज़र में एक्सटेंशन प्रबंधन पृष्ठ खोलें (आमतौर पर chrome://extensions/)
   - "डेवलपर मोड" सक्षम करें
   - "लोड अनपैक्ड" पर क्लिक करें और जो फ़ोल्डर आपने निकाला है, उसे चुनें

### उपयोग

एक्सटेंशन इंस्टॉल करने के बाद, आपको किसी भी वेबसाइट के नीचे-दाएँ कोने में एक भूत आइकन दिखाई देगा। उस पर क्लिक करें, और आप उसी साइट पर दूसरों के साथ खुशी-खुशी चैट कर सकते हैं!

### वीडियो

https://github.com/user-attachments/assets/e7ac9b8e-1b6c-43fb-8469-7a0a2c09d450

### दिग्गजों के कंधों पर खड़े होकर

विकेंद्रीकृत चैट के अच्छे विचार के अलावा, इसमें कुछ शानदार तकनीकों का भी उपयोग किया गया है।

- **[remesh](https://github.com/remesh-js/remesh)**: जावास्क्रिप्ट में एक फ्रेमवर्क जो DDD सिद्धांतों को लागू करता है, जिससे UI और लॉजिक का सही अलगाव प्राप्त होता है। इससे UI भाग को आसानी से लागू किया जा सकता है, जैसे कि इसे Vue में फिर से लिखना, क्योंकि यह UI से स्वतंत्र है।

- **[shadcn/ui](https://ui.shadcn.com/)**: एक सुंदर UI लाइब्रेरी और नो-इंस्टॉल अवधारणा की अग्रणी, जो स्टाइल कस्टमाइज़ करने में अतुलनीय सुविधा प्रदान करती है।

- **[wxt](https://wxt.dev/)**: यह ब्राउज़र एक्सटेंशन बनाने के लिए अब तक का सबसे अच्छा फ्रेमवर्क है जिसका मैंने उपयोग किया है।

- ~~**[trystero](https://github.com/dmotz/trystero)**: विकेंद्रीकृत संचार को लागू करने के लिए मुख्य निर्भरता, जो IPFS, टोरेंट, Nostr आदि जैसे विकेंद्रीकृत नेटवर्क से कनेक्शन सक्षम करता है।~~
- **[Artico](https://github.com/matallui/artico)**: एक लचीला लाइब्रेरी सेट जो आपको अपनी खुद की WebRTC-आधारित सॉल्यूशन बनाने में मदद करता है

- **[ugly-avatar](https://github.com/txstc55/ugly-avatar)**: इसका उपयोग शानदार रैंडम अवतार बनाने के लिए करें।

### प्रायोजक

वेबचैट एक ओपन सोर्स प्रोजेक्ट है, जिसकी सतत विकास प्रक्रिया पूरी तरह इन अद्भुत समर्थकों के सहयोग से संभव है।

[![Powered by DartNode](https://dartnode.com/branding/DN-Open-Source-sm.png)](https://dartnode.com "Powered by DartNode - Free VPS for Open Source")

### लाइसेंस

यह प्रोजेक्ट MIT लाइसेंस के तहत लाइसेंस प्राप्त है - विवरण के लिए [LICENSE](https://github.com/molvqingtai/WebChat/blob/master/LICENSE) फ़ाइल देखें

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---