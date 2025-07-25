<div align="right">
  <details>
    <summary >🌐 अन्य भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

क्लासिक 2048 गेम का एक उन्नत संस्करण, अब और भी मज़ेदार फीचर्स के साथ! यह एक छोटा सा प्रोजेक्ट है जो मैंने अपने खाली समय में बनाया है—आशा है आपको आनंद आएगा!

## 🎯 गेम परिचय

2048 एक सरल लेकिन बेहद आकर्षक नंबर-मर्जिंग गेम है। 4x4 ग्रिड पर, एक जैसे नंबर वाली टाइल्स को मिलाने के लिए ऊपर, नीचे, बाएँ या दाएँ स्वाइप करें। लक्ष्य? 2048 तक पहुँचना (लेकिन अरे, आप इससे भी अधिक स्कोर बना सकते हैं)!

**कैसे खेलें:**
- टाइल्स को मूव करने के लिए एरो की या WASD का उपयोग करें।
- जब एक जैसे नंबर वाली दो टाइल्स टकराती हैं, वे एक हो जाती हैं।
- हर मूव के बाद, एक नई 2 या 4 एक खाली स्थान पर यादृच्छिक रूप से प्रकट होगी।
- जब कोई मूव शेष नहीं रहेगा, तब गेम समाप्त हो जाएगा।

## ✨ विशेष फीचर्स

### 1. अनडू फंक्शन
- कोई गलत मूव किया? चिंता मत करो!
- बस "Undo" बटन दबाएँ और एक स्टेप पीछे जाएँ।
- आप जितनी बार चाहें अनडू कर सकते हैं, शुरूआत तक वापस जा सकते हैं।
- अब आपकी एक गलती गेम को खराब नहीं करेगी!

### 2. सीक्रेट चीट मोड
- जादुई सीक्वेंस दर्ज करें: ←←→→ →→←← (बाएँ, बाएँ, दाएँ, दाएँ,  दाएँ, दाएँ, बाएँ, बाएँ)
- सारी टाइल्स जादुई रूप से 128 में बदल जाएँगी!
- यह एक ईस्टर एग है, सिर्फ मनोरंजन के लिए।
- प्रो टिप: चीटिंग मजेदार है, लेकिन ज़्यादा मत करना! 😉

## 🎯 डेमो

🎯 यहाँ खेलें: [2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 प्रोजेक्ट संरचना
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**फ़ाइल विवरण:**
- `2048.py`: बैकएंड सर्वर जो Flask के साथ लिखा गया है, गेम लॉजिक और API अनुरोधों को संभालता है।
- `script.js`: फ्रंटएंड गेम लॉजिक, जिसमें मूव्स, ऐनिमेशन और विशेष फीचर शामिल हैं।
- `styles.css`: गेम स्टाइल्स, जो यह सुनिश्चित करते हैं कि सब कुछ सुंदर और रिस्पॉन्सिव दिखे।
- `index.html`: मुख्य पेज जो सब कुछ एक साथ लाता है।

## 🚀 शुरुआत कैसे करें

**विधि 1: रिलीज़ डाउनलोड करें**
1. नवीनतम रिलीज़ डाउनलोड करें।
2. सुनिश्चित करें कि आपके पास Python 3.x इंस्टॉल है।
3. डिपेंडेंसी इंस्टॉल करें: `pip install flask`
4. चलाएँ: `python 2048.py`
5. अपने ब्राउज़र में खोलें: [http://localhost:9969](http://localhost:9969)

**विधि 2: GitHub से क्लोन करें**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 अनुकूलन

इसे अपना बनाना चाहते हैं? एक नए लुक के लिए `styles.css` को बदलें, या गेमप्ले बदलने के लिए `script.js` में जाएँ। सभी कोड में आसान हैकिंग के लिए अच्छी टिप्पणियाँ हैं!

## 📝 लाइसेंस

GPL-2.0 लाइसेंस

## 🤝 योगदान

अभी भी अपडेट हो रहा है! समस्याएँ और पुल रिक्वेस्ट्स का स्वागत है—आइए इस गेम को मिलकर और भी शानदार बनाते हैं!


## 🙏 आभार

इस परियोजना को समर्थन देने वाले निम्नलिखित प्रायोजकों का धन्यवाद:
- [IDC.REST](https://idc.rest/) जिन्होंने सर्वर प्रदान किया
- [Serv00](https://www.serv00.com/) जिन्होंने सर्वर प्रदान किया

---
_अंतिम अपडेट: जून 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---