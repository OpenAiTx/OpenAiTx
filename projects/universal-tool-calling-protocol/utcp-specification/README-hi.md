# यूनिवर्सल टूल कॉलिंग प्रोटोकॉल (UTCP) स्पेसिफिकेशन

यह रिपॉजिटरी यूनिवर्सल टूल कॉलिंग प्रोटोकॉल (UTCP) के लिए आधिकारिक स्पेसिफिकेशन डाक्यूमेंटेशन को समाहित करती है। UTCP विभिन्न संचार प्रोटोकॉल्स के माध्यम से टूल्स को परिभाषित करने और उनके साथ इंटरैक्ट करने के लिए एक आधुनिक, लचीला और स्केलेबल मानक है।

## UTCP क्या है?

UTCP AI सिस्टम्स और अन्य क्लाइंट्स को विभिन्न प्रदाताओं से टूल्स को खोजने और कॉल करने का एक मानकीकृत तरीका प्रदान करता है, चाहे उपयोग किया गया प्रोटोकॉल (HTTP, WebSocket, CLI, आदि) कुछ भी हो। यह स्पेसिफिकेशन निम्नलिखित को परिभाषित करता है:

- टूल खोजने के तंत्र
- टूल कॉल फॉर्मेट्स
- प्रदाता कॉन्फ़िगरेशन
- प्रमाणीकरण विधियां
- प्रतिक्रिया प्रबंधन

## स्पेसिफिकेशन में योगदान

हम UTCP स्पेसिफिकेशन में आपके योगदान का स्वागत करते हैं! आप इस प्रकार योगदान कर सकते हैं:

1. **रिपॉजिटरी को फोर्क करें**: स्पेसिफिकेशन रिपॉजिटरी की अपनी प्रति बनाएं
2. **अपने परिवर्तन करें**: आवश्यकतानुसार डाक्यूमेंटेशन को अपडेट या जोड़ें
3. **पुल रिक्वेस्ट सबमिट करें**: समीक्षा के लिए अपने परिवर्तनों के साथ एक PR खोलें
4. **चर्चा में भाग लें**: प्रस्तावित परिवर्तनों पर चर्चा में शामिल हों

योगदान करते समय कृपया इन दिशानिर्देशों का पालन करें:

- सुनिश्चित करें कि आपके परिवर्तन UTCP की समग्र दृष्टि और लक्ष्यों के अनुरूप हैं
- स्थापित डाक्यूमेंटेशन संरचना और स्वरूपण का पालन करें
- नई विशेषताओं या अवधारणाओं को जोड़ते समय उदाहरण शामिल करें
- डाक्यूमेंटेशन में निरंतरता बनाए रखने के लिए संबंधित अनुभागों को अपडेट करें

## डाक्यूमेंटेशन को स्थानीय रूप से बनाना

### आवश्यकताएँ

डाक्यूमेंटेशन साइट को स्थानीय रूप से बनाने और पूर्वावलोकन करने के लिए, आपको आवश्यकता होगी:

- रूबी संस्करण 2.5.0 या उससे अधिक
- रूबी जेम्स
- बंडलर

### सेटअप

1. रिपॉजिटरी क्लोन करें:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. निर्भरता स्थापित करें:

   ```bash
   bundle install
   ```
### डोक्युमेंटेशन साइट चलाना

साइट को स्थानीय रूप से बनाने और सर्व करने के लिए:


```bash
bundle exec jekyll serve
```
यह एक स्थानीय वेब सर्वर `http://localhost:4000` पर शुरू करेगा जहाँ आप प्रलेखन का पूर्वावलोकन कर सकते हैं।

## प्रलेखन संरचना

UTCP प्रलेखन निम्नानुसार व्यवस्थित है:

- `index.md`: होमपेज और UTCP का परिचय
- `docs/`
  - `introduction.md`: विस्तृत परिचय और मूल अवधारणाएँ
  - `for-tool-providers.md`: टूल प्रदाताओं के लिए मार्गदर्शिका
  - `for-tool-callers.md`: टूल कॉलर्स के लिए मार्गदर्शिका
  - `providers/`: प्रत्येक प्रदाता प्रकार के लिए प्रलेखन
    - `http.md`: HTTP प्रदाता
    - `websocket.md`: WebSocket प्रदाता
    - `cli.md`: CLI प्रदाता
    - `sse.md`: सर्वर-सेंट इवेंट्स प्रदाता
    - आदि।
  - `implementation.md`: कार्यान्वयन दिशानिर्देश और सर्वोत्तम प्रथाएँ

## विनिर्देशन के साथ कार्य करना

### प्रलेखन में संशोधन करना

प्रलेखन Markdown प्रारूप में Jekyll फ्रंट मैटर के साथ लिखा गया है। परिवर्तन करते समय:

1. सुनिश्चित करें कि आपका Markdown स्थापित शैली का पालन करता है
2. PR सबमिट करने से पहले स्थानीय रूप से परिवर्तन का पूर्वावलोकन करें
3. उदाहरणों को नवीनतम विनिर्देशन के साथ अद्यतित रखें
4. यदि नए पृष्ठ जोड़ रहे हैं तो `_config.yml` में नेविगेशन आइटम अपडेट करें

### फ़ाइल संगठन

नई प्रलेखन जोड़ते समय:

- प्रदाता-विशिष्ट प्रलेखन `docs/providers/` में रखें
- उपयुक्त नेविगेशन क्रम के साथ सुसंगत फ्रंट मैटर का उपयोग करें
- GitHub Pages पर खोज में सुधार के लिए टैग शामिल करें

## संस्करण नियंत्रण

UTCP विनिर्देशन सेमांटिक संस्करण नियंत्रण का पालन करता है:

- मुख्य संस्करण (1.0, 2.0): प्रोटोकॉल में ब्रेकिंग परिवर्तन
- गौण संस्करण (1.1, 1.2): पीछे संगत नए फ़ीचर जोड़े गए
- पैच संस्करण (1.0.1, 1.0.2): पीछे संगत बग फिक्स और स्पष्टीकरण

## लाइसेंस

यह विनिर्देशन Mozilla Public License 2.0 (MPL-2.0) के अंतर्गत वितरित किया गया है।

## अतिरिक्त संसाधन

- [UTCP GitHub संगठन](https://github.com/universal-tool-calling-protocol)
- [UTCP वेबसाइट](https://utcp.io)
- [संदर्भ कार्यान्वयन](https://github.com/universal-tool-calling-protocol/python-utcp)
- [समुदाय चर्चा](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---