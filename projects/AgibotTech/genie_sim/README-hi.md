![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim बेंचमार्क
Genie Sim, AgiBot का सिमुलेशन फ्रेमवर्क है, जो डेवलपर्स को कुशल डेटा जनरेशन क्षमताएँ और मूल्यांकन बेंचमार्क प्रदान करता है ताकि embodied intelligence के विकास को तेज किया जा सके। Genie Sim ने एक व्यापक क्लोज्ड लूप पाइपलाइन स्थापित की है, जिसमें ट्रैजेक्टरी जनरेशन, मॉडल ट्रेनिंग, बेंचमार्किंग और डिप्लॉयमेंट वैलिडेशन शामिल हैं। उपयोगकर्ता इस कुशल सिमुलेशन टूलचेन के माध्यम से एल्गोरिदम के प्रदर्शन को जल्दी से सत्यापित कर सकते हैं और मॉडलों को अनुकूलित कर सकते हैं। चाहे साधारण ग्रैस्पिंग टास्क हों या जटिल लंबी दूरी के ऑपरेशन, Genie Sim एक अत्यंत यथार्थवादी सिमुलेशन वातावरण और सटीक मूल्यांकन मीट्रिक्स प्रदान कर सकता है, जिससे डेवलपर्स रोबोटिक तकनीकों के विकास और पुनरावृत्ति को कुशलता से पूरा कर सकें।

Genie Sim बेंचमार्क, Genie Sim का ओपन-सोर्स मूल्यांकन संस्करण है, जो embodied AI मॉडलों के लिए सटीक प्रदर्शन परीक्षण और अनुकूलन समर्थन प्रदान करने के लिए समर्पित है।

# 2. विशेषताएँ
- लचीला और उपयोगकर्ता-अनुकूल सिमुलेशन कॉन्फ़िगरेशन और इंटरफ़ेस
- 10+ मैनिपुलेशन कार्यों के लिए सिमुलेशन बेंचमार्क और मूल्यांकन कार्य
- VR और कीबोर्ड पर आधारित टेलीऑपरेशन क्षमता
- सभी जोड़ों और एंड इफेक्टर पोज़ का रिकॉर्ड और रिप्ले
- 550+ उच्च गुणवत्ता और भौतिक रूप से सटीक 3D सिमुलेशन वातावरण और एसेट्स
- embodied AI मॉडलों के प्रदर्शन को मापने के लिए मानकीकृत मूल्यांकन मीट्रिक्स
- GO-1 मॉडल पर सिम से रियल मूल्यांकन त्रुटि 5% से कम प्राप्त करता है
- सिमुलेशन मूल्यांकन में UniVLA बेसलाइन मॉडल का समर्थन

# 3. अपडेट्स
- [6/25/2025] v2.1
  - Agibot World Challenge 2025 के लिए 10 और मैनिपुलेशन टास्क जोड़ें, जिसमें सभी सिमुलेशन एसेट्स शामिल हैं
  - Huggingface पर 10 मैनिपुलेशन टास्क के लिए ओपन-सोर्स सिंथेटिक डेटा सेट
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - UniVLA पॉलिसी को एकीकृत करें और मॉडल इनफेरेंस सिमुलेशन मूल्यांकन का समर्थन करें
  - IK सॉल्वर SDK अपडेट करें, जो अन्य रोबोट्स के लिए क्रॉस-एंबोडिमेंट IK सॉल्विंग को सपोर्ट करता है
  - संचार ढांचे को अनुकूलित करें और सिमुलेशन की गति को 2x बढ़ाएँ
  - जटिल लंबी दूरी के कार्यों के लिए स्वचालित मूल्यांकन ढांचे को अपडेट करें

# 4. सामग्री

## 4.1 परिचय
Genie Sim में embodied intelligence सिमुलेशन बेंचमार्क, embodied AI मॉडलों के विकास और मूल्यांकन के लिए डिज़ाइन किए गए हैं। ये बेंचमार्क यथार्थवादी वातावरण, विविध कार्य और मानकीकृत मीट्रिक्स प्रदान करते हैं, जो रोबोटिक AI सिस्टम के प्रदर्शन को मापते हैं। इससे महंगे भौतिक हार्डवेयर और वास्तविक दुनिया के परीक्षण की आवश्यकता कम होती है, जोखिमपूर्ण और खतरनाक परीक्षण परिदृश्यों से बचाव होता है, और AI एजेंट्स के प्रशिक्षण व मूल्यांकन की प्रक्रिया तेज होती है।

## 4.2 आरंभ करें
कृपया स्थापना, उपयोगकर्ता गाइड और API संदर्भ के लिए [इस पृष्ठ](https://agibot-world.com/sim-evaluation/docs/#/v2) को देखें

## 4.3 समर्थन
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 TODO सूची
- [x] और अधिक लंबी-अवधि के बेंचमार्क मैनिपुलेशन टास्क जारी करें
- [x] प्रत्येक बेंचमार्क कार्य के लिए अधिक दृश्य और एसेट्स
- [x] Agibot World Challenge बेसलाइन मॉडल का समर्थन करें
- [ ] परिदृश्य लेआउट और मैनिपुलेशन ट्रैजेक्टरी सामान्यीकरण टूलकिट

## 4.5 अक्सर पूछे जाने वाले प्रश्न (FAQ)
- जब त्रुटियाँ होती हैं और प्रक्रिया प्रतिक्रिया नहीं दे रही होती है, तब आइज़ैक सिम सर्वर को कैसे बंद करें?
  टर्मिनल में `pkill -9 -f raise_standalone_sim` का उपयोग करके प्रक्रिया को समाप्त करें
- विभिन्न रेंडर मोड्स कैसे चुनें?
  डिफ़ॉल्ट रेंडर मोड `RaytracedLighting(RealTime)` है। जिन कार्यों में पारदर्शी वस्तुएँ होती हैं, उनके लिए वस्तुओं के परस्पेक्टिव संबंध के लिए `RealTimePathTracing(RealTime-2.0)` का उपयोग करें

## 4.6 लाइसेंस और उद्धरण
इस रिपॉजिटरी के भीतर सभी डेटा और कोड Mozilla Public License 2.0 के अंतर्गत हैं।
यदि यह कार्य आपके शोध में सहायक हो, तो कृपया नीचे दिए गए किसी भी तरीके से उद्धृत करने पर विचार करें।
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 संदर्भ
1. PDDL Parser (2020). Version 1.1. [Source code]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [Source code]. https://github.com/StanfordVL/bddl
3. CUROBO [Source code]. https://github.com/NVlabs/curobo
4. Isaac Lab [Source code]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Source code]. https://github.com/StanfordVL/OmniGibson


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---