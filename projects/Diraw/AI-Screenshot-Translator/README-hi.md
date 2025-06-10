# AI स्क्रीनशॉट अनुवाद टूल (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# परिचय

यह टूल **सरल स्क्रीनशॉट ऑपरेशन** के माध्यम से, चित्र को AI मॉडल को टेक्स्ट पहचान और अनुवाद के लिए भेजता है, और अनुवाद परिणाम को इंटरैक्टिव HTML प्रारूप में एक स्वतंत्र विंडो में दिखाता है।

यह टूल **कस्टम हॉटकी ट्रिगर, मल्टी-विंडो रिजल्ट मैनेजमेंट और सिस्टम ट्रे रनिंग** का समर्थन करता है, जिससे दैनिक काम और अध्ययन में अनुवाद की दक्षता काफी बढ़ जाती है।

**टूल की विशेषताएँ**: 1. स्क्रीनशॉट अनुवाद, हॉटकी से शुरू; 2. पैच स्क्रीनशॉट और अनुवाद, आसानी से ड्रैग और ज़ूम कर सकते हैं, कई अनुवाद पैच ग्रुप बना सकते हैं; 3. सूत्र (फॉर्मूला) के लिए मूल टेक्स्ट पर स्विच कर कॉपी करना आसान; 4. कस्टम api इंटरफेस

**समाधान करने वाले मुख्य बिंदु**: 1. वर्तमान में बाजार में उपलब्ध संपूर्ण डॉक्यूमेंट अनुवादक भारी-भरकम हैं; 2. यदि आप PDF से टेक्स्ट कॉपी कर अनुवाद करते हैं, तो कभी-कभी फॉर्मूला ब्लॉक गड़बड़ होते हैं या कॉपी नहीं हो पाते; 3. इमेज स्कैन की गई PDF से टेक्स्ट कॉपी करना असंभव

# डेमो

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# विंडो प्रदर्शन

अनुवाद विंडो:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

कॉन्फ़िगरेशन विंडो:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

कॉन्फ़िगरेशन विकल्पों का अधिक विस्तृत विवरण सॉफ्टवेयर के अंदर या वेबपेज पर [सुझाव](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md) में देखा जा सकता है

# स्थापना

आप सोर्स कोड डाउनलोड कर चला सकते हैं, या [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) पेज पर जाकर एक्जीक्यूटेबल फाइल डाउनलोड कर सकते हैं

### 1. रिपॉजिटरी क्लोन करें

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. वर्चुअल एनवायरनमेंट बनाएं और चलाएं

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# अपडेट योजना

- ~~API कॉन्फ़िगरेशन के लिए नया GUI विंडो जोड़ना, YAML फाइल को मैन्युअली कॉन्फ़िगर करने की प्रक्रिया को सॉफ्टवेयर द्वारा ऑटो-जनरेट करना (v0.3.0 में पूरा)~~
- चित्र और सूत्र संग्रहण प्रणाली जोड़ना, जिससे बाद में उपयोग आसान हो (अनुमानित v0.4 में पूरा)
- (और अधिक फीचर्स के लिए issue खोलें या PR योगदान करें)

# अन्य

- सॉफ्टवेयर आइकन [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free) से लिया गया है
- Gemini 2.5 Flash और DeepSeek-V3-0324 को बग ढूंढने में मदद के लिए धन्यवाद

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---