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

क्लासिक 2048 गेम का एक उन्नत संस्करण, जिसमें अब और भी मज़ेदार फीचर्स हैं! यह एक छोटा सा प्रोजेक्ट है जिसे मैंने अपने खाली समय में बनाया—आशा है यह आपको खुशी देगा!

## 🎯 गेम परिचय

2048 एक सरल लेकिन नशे की लत वाला नंबर-मर्जिंग गेम है। 4x4 ग्रिड पर, एक ही नंबर वाले टाइल्स को मर्ज करने के लिए ऊपर, नीचे, बाएँ या दाएँ स्वाइप करें। लक्ष्य क्या है? 2048 तक पहुँचना (लेकिन आप और भी ऊँचे स्कोर के लिए खेल सकते हैं)!

**कैसे खेलें:**
- टाइल्स को मूव करने के लिए एरो कीज या WASD का उपयोग करें।
- जब दो टाइल्स जिनपर एक ही संख्या है, टकराती हैं, वे एक में मिल जाती हैं।
- हर चाल के बाद, एक नया 2 या 4 खाली जगह में रैंडम रूप से आ जाता है।
- खेल तब समाप्त होता है जब कोई चाल शेष नहीं रहती।

## ✨ विशेष फीचर्स

### 1. पूर्ववत (Undo) फ़ंक्शन
- गलत चाल चल दी? कोई बात नहीं!
- बस "पूर्ववत" बटन दबाएँ और एक कदम पीछे जाएँ।
- आप जितनी बार चाहें पूर्ववत कर सकते हैं, शुरूआत तक।
- उँगली की फिसलन से अब आपका खेल कभी खराब नहीं होगा!

### 2. गुप्त चीट मोड
- जादुई अनुक्रम दर्ज करें: ←←→→ →→←← (बाएँ, बाएँ, दाएँ, दाएँ, दाएँ, दाएँ, बाएँ, बाएँ)
- सभी टाइल्स जादुई रूप से 128 में बदल जाएँगी!
- यह एक ईस्टर एग है, सिर्फ़ मज़े के लिए।
- प्रो टिप: चीटिंग मज़ेदार है, पर ज़्यादा मत करें! 😉

## 🎯 डेमो

🎯 : [यहाँ खेलें](http://2048.765431.xyz/)
<img width="1279" alt="डेमो" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



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

इसे अपना बनाना चाहते हैं? एक नई शैली के लिए `styles.css` में बदलाव करें, या गेमप्ले बदलने के लिए `script.js` में जाएँ। सभी कोड अच्छी तरह से कमेंट किए गए हैं ताकि हैकिंग आसान हो!

## 📝 लाइसेंस

GPL-2.0 लाइसेंस

## 🤝 योगदान

अभी भी अपडेट हो रहा है! समस्याएँ और पुल रिक्वेस्ट्स का स्वागत है—आइए इस गेम को और भी शानदार बनाते हैं!

## 🙏 आभार

इस प्रोजेक्ट को समर्थन देने वाले निम्नलिखित प्रायोजकों का धन्यवाद:
- [Aurora Cloud](https://www.free-vps.net/) ने सर्वर उपलब्ध कराया

---
_अंतिम अपडेट: अक्टूबर 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---