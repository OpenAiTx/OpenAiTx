# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

यह रिपोजिटरी Gemini CLI को शामिल करती है, जो एक कमांड-लाइन AI वर्कफ़्लो टूल है जो आपके
टूल्स से कनेक्ट होता है, आपके कोड को समझता है और आपके वर्कफ़्लो को तेज़ करता है।

Gemini CLI के साथ आप:

- Gemini के 1M टोकन कॉन्टेक्स्ट विंडो में और उससे परे बड़े कोडबेस को क्वेरी और एडिट कर सकते हैं।
- Gemini की मल्टीमोडल क्षमताओं का उपयोग करते हुए PDF या स्केच से नए ऐप्स जेनरेट कर सकते हैं।
- ऑपरेशनल कार्यों को स्वचालित कर सकते हैं, जैसे पुल रिक्वेस्ट को क्वेरी करना या जटिल रीबेस को संभालना।
- टूल्स और MCP सर्वर का उपयोग कर नई क्षमताएँ जोड़ सकते हैं, जिसमें [Imagen, Veo या Lyria के साथ मीडिया जेनरेशन](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia) शामिल है।
- अपने क्वेरी को [Google Search](https://ai.google.dev/gemini-api/docs/grounding) टूल के साथ ग्राउंड कर सकते हैं, जो Gemini में बिल्ट-इन है।

## त्वरित प्रारंभ

1. **पूर्व-आवश्यकताएँ:** सुनिश्चित करें कि आपके पास [Node.js संस्करण 18](https://nodejs.org/en/download) या उससे अधिक स्थापित है।
2. **CLI चलाएँ:** अपने टर्मिनल में निम्नलिखित कमांड चलाएँ:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   या इसे इंस्टॉल करें:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **एक रंग थीम चुनें**
4. **प्रमाणीकृत करें:** जब संकेत मिले, तो अपने व्यक्तिगत Google खाते के साथ साइन इन करें। इससे आपको Gemini के साथ प्रति मिनट 60 मॉडल अनुरोध और प्रति दिन 1,000 मॉडल अनुरोध करने की अनुमति मिलेगी।

अब आप Gemini CLI का उपयोग करने के लिए तैयार हैं!

### उन्नत उपयोग या बढ़ी हुई सीमाओं के लिए:

यदि आपको किसी विशेष मॉडल का उपयोग करना है या अधिक अनुरोध क्षमता चाहिए, तो आप API कुंजी का उपयोग कर सकते हैं:

1. [Google AI Studio](https://aistudio.google.com/apikey) से एक कुंजी जनरेट करें।
2. इसे अपने टर्मिनल में पर्यावरण चर (environment variable) के रूप में सेट करें। `YOUR_API_KEY` को अपनी जनरेट की गई कुंजी से बदलें।

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

अन्य प्रमाणीकरण विधियों के लिए, जिसमें Google Workspace खाते शामिल हैं, [authentication](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md) गाइड देखें।

## उदाहरण

एक बार CLI चलने के बाद, आप अपने शेल से Gemini के साथ इंटरैक्ट करना शुरू कर सकते हैं।

आप एक नई डायरेक्टरी से प्रोजेक्ट शुरू कर सकते हैं:

```sh
cd new-project/
gemini
> एक Gemini Discord बोट लिखें जो एक FAQ.md फ़ाइल से प्रश्नों के उत्तर देती है, जिसे मैं प्रदान करूंगा
```

या किसी मौजूदा प्रोजेक्ट के साथ काम करें:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> कल किए गए सभी परिवर्तनों का सारांश दें
```

### अगले कदम

- जानें कि कैसे [स्रोत से योगदान करें या बिल्ड करें](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md)।
- उपलब्ध **[CLI कमांड्स](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)** को एक्सप्लोर करें।
- यदि आपको कोई समस्या आती है, तो **[समस्या निवारण गाइड](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)** देखें।
- अधिक संपूर्ण दस्तावेज़ीकरण के लिए [पूर्ण दस्तावेज़](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md) देखें।
- और प्रेरणा के लिए कुछ [लोकप्रिय कार्य](#popular-tasks) देखें।

### समस्या निवारण

यदि आपको समस्या हो रही है, तो [समस्या निवारण](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) गाइड देखें।

## लोकप्रिय कार्य

### एक नया कोडबेस एक्सप्लोर करें

किसी मौजूदा या नए क्लोन किए गए रिपोजिटरी में `cd` करके और `gemini` चलाकर शुरू करें।

```text
> इस सिस्टम की मुख्य आर्किटेक्चर के हिस्सों का वर्णन करें।
```

```text
> कौन से सुरक्षा तंत्र लागू हैं?
```

### अपने मौजूदा कोड के साथ काम करें

```text
> GitHub issue #123 के लिए पहला ड्राफ्ट लागू करें।
```

```text
> इस कोडबेस को जावा के नवीनतम संस्करण में माइग्रेट करने में मेरी मदद करें। एक योजना से शुरू करें।
```

### अपने वर्कफ़्लो को स्वचालित करें

अपने स्थानीय सिस्टम टूल्स को अपने एंटरप्राइज कोलैबोरेशन सूट से एकीकृत करने के लिए MCP सर्वरों का उपयोग करें।

```text
> पिछले 7 दिनों के git इतिहास को दिखाने के लिए एक स्लाइड डेक बनाएं, जिसे फीचर और टीम सदस्य के अनुसार समूहीकृत किया गया हो।
```

```text
> एक फुल-स्क्रीन वेब ऐप बनाएं जो वॉल डिस्प्ले के लिए हमारे सबसे अधिक इंटरैक्ट किए गए GitHub इश्यूज दिखाता हो।
```

### अपने सिस्टम के साथ इंटरैक्ट करें

```text
> इस डायरेक्टरी में सभी इमेज को png में बदलें, और उन्हें exif डेटा की तिथियों का उपयोग करके नाम दें।
```

```text
> मेरी PDF इनवॉइस को व्यय के महीने के अनुसार व्यवस्थित करें।
```

## सेवा की शर्तें और गोपनीयता सूचना

Gemini CLI के उपयोग के लिए लागू सेवा की शर्तों और गोपनीयता सूचना का विवरण [सेवा की शर्तें और गोपनीयता सूचना](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md) में देखें।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---