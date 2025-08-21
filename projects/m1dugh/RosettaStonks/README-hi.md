
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# रोसेटा स्टॉन्क्स

- [परिचय](#introduction)
- [इंस्टॉल करें](#install)
  - [क्रोम](#chrome-based-browsers)
    - [विज़ुअल गाइड](#chrome-based-browsers)
  - [फायरफॉक्स](#firefox-based-browsers)
- [कैसे उपयोग करें](#how-to-use)
  - [समय जोड़ना](#adding-time)
    - [फाउंडेशन](#adding-time-in-foundations)
    - [फ्लूएंसी बिल्डर](#adding-time-in-fluency-builder)
  - [पाठ सत्यापित करना](#validating-lesson)
    - [फाउंडेशन](#validating-lesson-in-foundations)
    - [फ्लूएंसी बिल्डर](#validating-lesson-in-fluency-builder)

## परिचय

RosettaStonks एक ब्राउज़र एक्सटेंशन है जो आपको रोसेट्टा स्टोन भाषा सीखने के प्लेटफ़ॉर्म पर समय जोड़ने और पाठों को सत्यापित करने की सुविधा देता है।

> RosettaStonks, और आपका रोसेट्टा स्टोन हो जाता है स्टॉन्क्स।

## इंस्टॉल करें

### क्रोम आधारित ब्राउज़र

➡️ **क्या आप पहली बार क्रोम एक्सटेंशन मैन्युअली इंस्टॉल कर रहे हैं?** [चरण-दर-चरण चित्रमय गाइड](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) देखें — इसमें सहायक स्क्रीनशॉट शामिल हैं! 🖼️

#### 1. GitHub रिलीज़ का उपयोग करना

क्रोम-आधारित ब्राउज़र में एक्सटेंशन का उपयोग करने के लिए, आपको यह करना होगा:

- फ़ाइल `rosettastonks-chrome.tar.gz` को नवीनतम रिलीज़ से अपने कंप्यूटर पर डाउनलोड करें।
- अपने कंप्यूटर पर कहीं भी `rosettastonks` नामक एक फ़ोल्डर बनाएं, जिसमें एक्सटेंशन संग्रहित किया जाएगा।
- `rosettastonks` फ़ोल्डर में निम्नलिखित कमांड चलाएँ।




```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. nix पैकेज प्रबंधक का उपयोग करना

पिछले कमांड्स की बजाय, यदि आप एक nix सिस्टम पर हैं जो **फ्लेक्स को सपोर्ट करता है**,
तो आप निम्नलिखित कमांड्स चला सकते हैं, जो `/tmp/rosettastonks` पथ के तहत
सभी फाइलों के साथ एक फ़ोल्डर स्थापित कर देगा।

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```
फ़ोल्डर अब `/tmp/rosettastonks/` के तहत स्थापित हो गया है।

**यह भाग सभी उपयोगकर्ताओं के लिए है, चाहे आप github विधि का उपयोग कर रहे हों या nix विधि का।**

अपने ब्राउज़र में:

- `chrome://extensions` पर जाएँ
- `Developer mode` टॉगल की जाँच करें
- `Load unpacked` पर क्लिक करें
- अपने `rosettastonks` फ़ोल्डर का चयन करें

### Firefox आधारित ब्राउज़र

- नवीनतम रिलीज़ से फ़ाइल `rosettastonks.xpi` डाउनलोड करें।
- वैकल्पिक रूप से, यदि आप flake समर्थन के साथ nix पैकेज प्रबंधक का उपयोग कर रहे हैं, तो आप
  निम्नलिखित कमांड चला सकते हैं।



```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- अपने ब्राउज़र में `about:addons` पर जाएँ
- सेटिंग्स बटन पर क्लिक करें और `Debug addons` पर जाएँ।
- `Load Temporary Add-On` पर क्लिक करें
- फ़ाइल पिकर में `/tmp/rosettastonks.xpi` फ़ाइल चुनें।

_चेतावनी: यह विधि केवल एक्सटेंशन को अस्थायी रूप से इंस्टॉल करती है, अर्थात् यदि आप
अपना ब्राउज़र बंद करते हैं, तो ऐडऑन अनइंस्टॉल हो जाएगा। यह फ़ायरफ़ॉक्स की
नीतियों के कारण है, जो बिना सत्यापित एक्सटेंशन के उपयोग की अनुमति नहीं देतीं।_

## उपयोग कैसे करें

### समय जोड़ना

#### Foundations में समय जोड़ना

`foundations` उत्पाद में समय जोड़ने के लिए, आपको अपनी एक्सरसाइज़ पर जाना होगा, और
कम से कम एक प्रश्न को अनदेखा या हल करना होगा। ऐसा करने के बाद, एक्सटेंशन पृष्ठ पर एक समय फ़ील्ड
आ जाना चाहिए, जिसमें आप अपना समय जोड़ सकते हैं।

#### Fluency builder में समय जोड़ना

`fluency builder` उत्पाद में समय जोड़ने के लिए, आपको अपनी एक्सरसाइज़ पर जाना होगा, और
कम से कम एक एक्सरसाइज़ का उत्तर देना होगा। यदि समय जोड़ने का फ़ील्ड नहीं दिखता, तो इसका अर्थ है
कि कोई समय अनुरोध प्राप्त नहीं हुआ, आपको प्रश्न को रीफ़्रेश करना होगा और फिर से उत्तर देना होगा।
समय जोड़ने के लिए, आपको उस पाठ को समाप्त करना होगा, जिसमें आपने समय जोड़ा है।

_नोट: यदि आपको समय जोड़ने का फ़ील्ड नहीं दिखता, तो इसका अर्थ है कि आपने Rosetta stone वेबसाइट पर जो क्रियाएँ कीं
उनसे वैध समय नहीं जुड़ा, इसलिए आपको अन्य प्रश्नों के उत्तर देने होंगे।_

### पाठ की पुष्टि करना

#### Foundations में पाठ की पुष्टि करना

पाठ की पुष्टि करने के लिए, आपको एक पाठ शुरू करना होगा, और सभी प्रश्नों को निचले दाएँ कोने में `ignore` बटन से देखना होगा।
एक बार जब सभी प्रश्न देख लिए जाएँ, तो `validate lesson` बटन क्लिक करने पर पाठ की पुष्टि हो जानी चाहिए।
यदि नहीं, तो अपनी होम पेज पर लौटें, उसी पाठ पर क्लिक करें, यह



आपसे पूछा जाना चाहिए `क्या आप जारी रखना चाहते हैं या रीसेट करना चाहते हैं?`, आप दोनों चुन सकते हैं, और
पाठ को फिर से मान्य करें जब तक कि यह काम न करे। यह अधिकतम 3/4 बार के बाद काम करना चाहिए।

#### फ्लुएंसी बिल्डर में पाठ को मान्य करना

अभी, रोसेटा स्टॉन्क्स पर पाठ मान्य करने की सुविधा उपलब्ध नहीं है।

## एप्लिकेशन बनाना

### वर्कर बनाना

वर्कर को निम्नलिखित कमांड का उपयोग करके पैकेज किया जा सकता है

```
$ deno task build:worker
```

जो पैक की गई फ़ाइल `/dist/worker.esm.js` बनाता है, जो वर्कर के लिए पैक की गई फ़ाइल है।

### फ्रंटएंड बनाना

वर्कर को निम्नलिखित कमांड का उपयोग करके पैक किया जा सकता है


```
$ deno task build:frontend
```

जो पैकेज्ड फाइल `/dist/frontend.esm.js` बनाता है, जो फ्रंटएंड के लिए पैकेज्ड फाइल है।

## एक्सटेंशन को पैकेज करना

### क्रोम

क्रोम के लिए एक्सटेंशन को पैकेज करने के लिए, निम्नलिखित कमांड चलाया जा सकता है:


```
$ make chrome
```

### फ़ायरफ़ॉक्स

फ़ायरफ़ॉक्स के लिए एक्सटेंशन को पैकेज करने के लिए, निम्नलिखित कमांड चलाई जा सकती है:

```
$ make firefox
```
जिससे `rosettastonks.xpi` बनेगा, जो एक्सटेंशन की फाइल है जिसे
फायरफॉक्स में लोड किया जा सकता है।

📸 विजुअल्स पसंद है? [क्रोम इंस्टॉलेशन गाइड इमेजेस के साथ](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) देखें


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---