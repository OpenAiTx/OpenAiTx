
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp वीडियो बैच डाउनलोड टूल (Windows / Linux समर्थन)

> [yt-dlp](https://github.com/yt-dlp/yt-dlp) पर आधारित एक वन-क्लिक वीडियो डाउनलोड स्क्रिप्ट, जिसकी प्रेरणा [NodeSeek दादा की साझा पोस्ट](https://www.nodeseek.com/post-334093-2#15) से मिली है।
> यह एकल वीडियो और बैच डाउनलोड को सपोर्ट करता है, Windows और प्रमुख Linux वितरण (Debian / Ubuntu / Alpine / CentOS) के साथ संगत है।

---

## ✨ फीचर विशेषताएँ

* 📥 **वन-क्लिक रनिंग**: मैन्युअल कॉन्फ़िगरेशन की आवश्यकता नहीं, संकेत के अनुसार इनपुट दें और डाउनलोड शुरू करें
* 🍪 **कस्टम कुकी सपोर्ट**: उन वीडियो के लिए जो लॉगिन के बाद ही डाउनलोड किए जा सकते हैं (⚠️ यह फीचर अभी सत्यापित नहीं है, बग हो सकता है)
* 📂 **कस्टम आउटपुट डायरेक्टरी सपोर्ट**: आसानी से निर्दिष्ट फोल्डर में सेव करें
* 📃 **बैच डाउनलोड सपोर्ट**: `urls.txt` फाइल में दिए गए लिंक को ऑटोमेटिक पढ़कर डाउनलोड करें
* ⚙️ **ऑटो डिपेंडेंसी इंस्टॉल**: Linux वातावरण में `yt-dlp` और `ffmpeg` ऑटोमेटिक इंस्टॉल करता है

---

## 🖼️ स्क्रीनशॉट प्रीव्यू

| उदाहरण 1                                                                  | उदाहरण 2                                                                  |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![उदाहरण 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![उदाहरण 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![उदाहरण 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![उदाहरण 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 विंडोज उपयोग विधि

1. निम्नलिखित फाइलें डाउनलोड करें:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` विंडोज वर्शन](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. अनज़िप करने के बाद, निम्न फाइलों को एक ही डायरेक्टरी (जैसे `yt-dlp` फोल्डर) में रखें:

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (स्क्रिप्ट फाइल)

3. `yt-dlp.bat` पर डबल-क्लिक करें, और निर्देशानुसार वीडियो डाउनलोड करें।
4. डिफ़ॉल्ट कॉन्फ़िगरेशन बदलने के लिए config/config.ini एडिट करें

---

## 🐧 लिनक्स उपयोग विधि (टेक्नोलॉजी लायन द्वारा नवीनतम स्क्रिप्ट में भी यही फीचर स्क्रिप्ट समाहित है)

**समर्थित सिस्टम**: Debian / Ubuntu / Alpine / CentOS

एक-क्लिक तैनाती या अद्यतन और चलाएं:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

अनइंस्टॉल करने के लिए:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```
---

## 📱 Android उपयोग की सिफारिश

1. [Seal](https://github.com/JunkFood02/Seal) ऐप का उपयोग करें, Android पर `yt-dlp` की सुविधा का अनुभव करें।
2. termux में Debian इंस्टॉल करके भी डाउनलोड किया जा सकता है, लेकिन इसकी जरूरत नहीं है, Seal बहुत अच्छा है।

---

## ⚠️ ध्यान देने योग्य बातें

1. **बैच डाउनलोड मोड**: स्क्रिप्ट स्वतः वर्तमान डायरेक्टरी के `config\urls.txt` को पढ़ेगी, प्रत्येक पंक्ति में एक वीडियो लिंक। यदि फ़ाइल मौजूद नहीं है, तो स्वतः बना दी जाएगी।
2. **संसाधन उपयोग चेतावनी**: कम रैम वाले डिवाइस पर एक साथ कई बड़े वीडियो डाउनलोड न करें, या बहुत अधिक थ्रेड न सेट करें।
3. **CentOS विशेष सूचना**: वातावरण थोड़ा अलग है, पूरी तरह से टेस्ट नहीं किया गया है, गैर-प्रोडक्शन में ही इस्तेमाल करें। बाकी सभी मुख्यधारा सिस्टम में परीक्षण सफल रहा है।
4. Linux संस्करण की छोटी बग: स्क्रिप्ट जब होमपेज पर चलती है, एक बार डिपेंडेंसी चेक होती है, 'कोड चल जाए' के सिद्धांत पर छोड़ दिया, बदलने की ज़रूरत नहीं समझी।
5. Windows संस्करण की छोटी बग: अन्य पेज से होमपेज पर लौटकर चुनाव करने पर, डिफॉल्ट विकल्प काम नहीं करता, फिर लूप में फंस जाता है, क्षमता सीमित है, ठीक नहीं कर पाया।
दो समाधान:
    1. बाहर निकलकर पुनः चलाएं
    2. डिफॉल्ट न चुनें, नंबर से ही विकल्प चुनें

---

## 📄 लाइसेंस

यह प्रोजेक्ट [MIT License](https://opensource.org/licenses/MIT) का पालन करता है।

---



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---