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


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

क्लासिक 2048 गेम का एक उन्नत संस्करण, अब और भी मज़ेदार फीचर्स के साथ! यह एक छोटा प्रोजेक्ट है जिसे मैंने अपने खाली समय में बनाया—आशा है आपको इसमें आनंद आएगा!

## 🎯 गेम परिचय

2048 एक सरल लेकिन बेहद लत लगाने वाला नंबर-मर्जिंग गेम है। 4x4 ग्रिड पर, ऊपर, नीचे, बाएँ या दाएँ स्वाइप करें और एक जैसे नंबर वाले टाइल्स को मिलाएँ। लक्ष्य क्या है? 2048 तक पहुँचना (लेकिन आप और भी अधिक स्कोर के लिए खेलना जारी रख सकते हैं)!

**कैसे खेलें:**
- टाइल्स को हिलाने के लिए एरो कीज़ या WASD का उपयोग करें।
- जब दो एक जैसे नंबर वाली टाइल्स टकराती हैं, वे एक में मिल जाती हैं।
- हर चाल के बाद, एक नई 2 या 4 किसी खाली स्थान पर यादृच्छिक रूप से आएगी।
- जब कोई चाल बाकी नहीं रह जाती, तो गेम समाप्त हो जाता है।

## ✨ विशेषताएँ

### 1. अनडू फंक्शन
- कोई गलत चाल चल दी? चिंता न करें!
- बस "Undo" बटन दबाएँ और एक कदम पीछे जाएँ।
- आप जितनी बार चाहें, शुरू से लेकर वापस जा सकते हैं।
- अब उंगली फिसलने से गेम खराब नहीं होगा!

### 2. सीक्रेट चीट मोड
- मैजिक सीक्वेंस दर्ज करें: ←←→→ →→←← (बाएँ, बाएँ, दाएँ, दाएँ, दाएँ, दाएँ, बाएँ, बाएँ)
- सभी टाइल्स जादुई रूप से 128 बन जाएँगी!
- यह एक ईस्टर एग है, सिर्फ मज़े के लिए।
- प्रो टिप: चीटिंग मज़ेदार है, लेकिन ज़्यादा मत करें! 😉

## 🎯 डेमो

🎯 यहाँ खेलें: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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
- `2048.py`: बैकएंड सर्वर, Flask के साथ लिखा गया, गेम लॉजिक और API अनुरोधों को संभालता है।
- `script.js`: फ्रंटएंड गेम लॉजिक, जिसमें मूव्स, एनिमेशन और विशेष फीचर्स शामिल हैं।
- `styles.css`: गेम के स्टाइल्स, जिससे सब कुछ सुंदर और रिस्पॉन्सिव दिखे।
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
## 🎨 कस्टमाइज़ेशन

इसे अपना बनाना चाहते हैं? नए लुक के लिए `styles.css` में बदलाव करें, या गेमप्ले बदलने के लिए `script.js` में जाएँ। सारा कोड अच्छे से कमेंट किया गया है ताकि हैकिंग आसान हो!

## 📝 लाइसेंस

GPL-2.0 लाइसेंस

## 🤝 योगदान

अब भी अपडेट हो रहा है! इश्यू और पुल रिक्वेस्ट का स्वागत है—आइए इस गेम को मिलकर और भी शानदार बनाएं!


## 🙏 आभार

इस प्रोजेक्ट को समर्थन देने वाले निम्नलिखित प्रायोजकों का धन्यवाद:
- [Serv00](https://www.serv00.com/) द्वारा सर्वर प्रदान किया गया

---
_अंतिम अपडेट: जून 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---