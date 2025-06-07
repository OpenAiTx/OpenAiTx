<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChain Logo" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![रिलीज़ नोट्स](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![सीआई](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - लाइसेंस](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - डाउनलोड्स](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub स्टार चार्ट](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![ओपन इश्यूज़](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Dev Containers में खोलें](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Github Codespace में खोलें" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![ट्विटर](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed बैज](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!नोट]
> JS/TS लाइब्रेरी ढूंढ रहे हैं? देखें [LangChain.js](https://github.com/langchain-ai/langchainjs)।

LangChain एक ढांचा है जो LLM-संचालित एप्लिकेशन बनाने के लिए उपयोग होता है। यह आपको इंटरऑपरेबल घटकों और थर्ड-पार्टी इंटीग्रेशन को जोड़ने में मदद करता है, जिससे एआई एप्लिकेशन डेवेलपमेंट सरल होता है — और जैसे-जैसे आधारभूत तकनीक बदलती है, आपके निर्णय भविष्य के लिए सुरक्षित रहते हैं।

```bash
pip install -U langchain
```

LangChain के बारे में और जानने के लिए देखें
[डॉक्युमेंटेशन](https://python.langchain.com/docs/introduction/)। यदि आप और उन्नत कस्टमाइज़ेशन या एजेंट ऑर्केस्ट्रेशन देख रहे हैं, तो देखें
[LangGraph](https://langchain-ai.github.io/langgraph/), हमारा ढांचा कंट्रोल करने योग्य एजेंट वर्कफ़्लो के निर्माण के लिए।

## LangChain का उपयोग क्यों करें?

LangChain डेवलपर्स को LLM आधारित एप्लिकेशन बनाने में सहायता करता है, जिसमें मॉडल, एम्बेडिंग्स, वेक्टर स्टोर्स, आदि के लिए एक मानक इंटरफेस मिलता है।

LangChain का उपयोग करें:
- **रियल-टाइम डेटा संवर्द्धन**। LLMs को विभिन्न डेटा स्रोतों और बाहरी/आंतरिक प्रणालियों से आसानी से कनेक्ट करें, और LangChain की विशाल इंटीग्रेशन लाइब्रेरी का लाभ उठाएं जिसमें मॉडल प्रोवाइडर, टूल्स, वेक्टर स्टोर्स, रिट्रीवर्स आदि शामिल हैं।
- **मॉडल इंटरऑपरेबिलिटी**। जैसे आपकी इंजीनियरिंग टीम आपकी एप्लिकेशन की आवश्यकताओं के लिए सर्वोत्तम विकल्प खोजने के लिए मॉडल बदलती है, वैसे ही मॉडल को अंदर-बाहर बदलें। जैसे-जैसे इंडस्ट्री फ्रंटियर बदलता है, जल्दी अनुकूलित करें — LangChain की एब्सट्रैक्शन्स के साथ आप अपनी गति बनाए रखते हैं।

## LangChain का इकोसिस्टम
जहाँ LangChain फ्रेमवर्क को अकेले उपयोग किया जा सकता है, वहीं यह किसी भी LangChain उत्पाद के साथ भी सहजता से एकीकृत हो जाता है, जिससे डेवलपर्स को LLM एप्लिकेशन बनाते समय टूल्स का पूरा सेट मिलता है।

अपने LLM एप्लिकेशन विकास को बेहतर बनाने के लिए, LangChain के साथ जोड़ी बनाएं:

- [LangSmith](http://www.langchain.com/langsmith) - एजेंट मूल्यांकन और ऑब्ज़र्वेबिलिटी के लिए उपयोगी। खराब प्रदर्शन करने वाले LLM एप्लिकेशन रन को डीबग करें, एजेंट ट्राजेक्टरी का मूल्यांकन करें, प्रोडक्शन में दृश्यता प्राप्त करें, और समय के साथ प्रदर्शन में सुधार करें।
- [LangGraph](https://langchain-ai.github.io/langgraph/) - ऐसे एजेंट बनाएं जो जटिल कार्यों को भरोसेमंद ढंग से संभाल सकें, हमारे लो-लेवल एजेंट ऑर्केस्ट्रेशन फ्रेमवर्क LangGraph के साथ। LangGraph अनुकूलनशील आर्किटेक्चर, दीर्घकालिक मेमोरी, और मानव-इन-द-लूप वर्कफ़्लोज़ प्रदान करता है — और लिंक्डइन, उबर, क्लारना, और गिटलैब जैसी कंपनियों द्वारा प्रोडक्शन में भरोसा किया जाता है।
- [LangGraph प्लेटफ़ॉर्म](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - लंबे समय तक चलने वाले, स्टेटफुल वर्कफ़्लोज़ के लिए विशेष रूप से बनाए गए डिप्लॉयमेंट प्लेटफ़ॉर्म के साथ एजेंट्स को आसानी से डिप्लॉय और स्केल करें। टीमों के बीच एजेंट्स की खोज, पुनः उपयोग, कॉन्फ़िगर, और साझा करें — और [LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/) में विज़ुअल प्रोटोटाइपिंग के साथ जल्दी से दोहराएँ।

## अतिरिक्त संसाधन
- [ट्यूटोरियल्स](https://python.langchain.com/docs/tutorials/): LangChain के साथ शुरुआत करने के लिए सरल वॉकथ्रू और उदाहरण।
- [हाउ-टू गाइड्स](https://python.langchain.com/docs/how_to/): टूल कॉलिंग, RAG उपयोग केस, आदि जैसे विषयों के लिए त्वरित और व्यावहारिक कोड स्निपेट्स।
- [कॉन्सेप्चुअल गाइड्स](https://python.langchain.com/docs/concepts/): LangChain फ्रेमवर्क के पीछे के मुख्य विचारों की व्याख्या।
- [एपीआई रेफरेंस](https://python.langchain.com/api_reference/): LangChain के लिए बेस पैकेज और इंटीग्रेशन नेविगेट करने पर विस्तृत संदर्भ।

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---