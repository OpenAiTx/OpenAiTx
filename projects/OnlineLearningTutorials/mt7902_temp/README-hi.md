<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 MT7902 ड्राइवर MT7921 ड्राइवर के उप-भाग के रूप में (✅ कार्यरत)
मीडियाटेक mt7902 wifi 6E चिप ब्लूटूथ और वाईफाई सपोर्ट

> [!महत्वपूर्ण]
> Linux 7.1 कर्नेल आधिकारिक रूप से MT7902 WIFI 6E चिप का समर्थन करता है


## 📁 रिपॉजिटरी क्लोन करना

रिपॉजिटरी को अपने स्थानीय पीसी पर क्लोन करें
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
यदि आप पिछला इतिहास क्लोन नहीं करना चाहते हैं तो
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## स्थापना


### 🚀 स्थापना गाइड स्क्रिप्ट (Ubuntu आधारित सिस्टम के लिए अनुशंसित)
यदि स्क्रिप्ट पहले से निष्पादन योग्य नहीं है, तो इसे निष्पादन योग्य बनाएं
```
chmod +x ./install_guide.sh
```
अब इस स्क्रिप्ट को चलाएँ
```
./install_guide.sh
```
यह आवश्यक होने पर स्वचालित रूप से पासवर्ड के लिए संकेत देगा
* यह स्क्रिप्ट आपसे फर्मवेयर, ब्लूटूथ और वाईफाई ड्राइवर को एक-एक करके इंस्टॉल करने के लिए पूछेगी
* उबंटू पर लिनक्स 7.0 कर्नेल के साथ परीक्षण किया गया

### 🚀 आसान स्वचालित समाधान (आर्च आधारित सिस्टम के लिए अनुशंसित)
अगर आप किसी भी आधुनिक कर्नेल पर अपना वाईफाई और ब्लूटूथ जल्दी से ठीक करना चाहते हैं, तो ये कदम अपनाएं:

स्क्रिप्ट को निष्पादन योग्य बनाएं, अगर पहले से नहीं है
```
chmod +x ./fix_my_wifi.sh
```

**स्वचालित सुधार स्क्रिप्ट चलाएं** sudo के साथ:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 यह स्क्रिप्ट क्या करती है:
* **डिपेंडेंसीज की जांच:** यह सुनिश्चित करता है कि आपके पास `gcc`/`clang`, `make`, `bc`, और आपके वर्तमान `kernel-headers` इंस्टॉल हैं। अगर नहीं हैं - तो आपके पसंदीदा पैकेज मैनेजर से इंस्टॉल करता है।
* **ड्राइवरों का संकलन:** स्वचालित रूप से आपके सटीक कर्नेल संस्करण के लिए WiFi और Bluetooth ड्राइवर बनाता है।
* **स्थायी समाधान:** एक सिस्टम सेवा इंस्टॉल करता है जो आपके कंप्यूटर को रीस्टार्ट करने के बाद भी आपका WiFi सक्रिय रखती है।
* **सुरक्षा:** मॉड्यूल्स को एक कस्टम डाइरेक्टरी (`/lib/modules/mt7902_custom`) में इंस्टॉल करता है ताकि आपके डिफ़ॉल्ट सिस्टम फाइल्स में कोई बदलाव न हो।

> [!NOTE]
> पहली बार रन करने पर आवश्यक बिल्ड टूल्स डाउनलोड करने के लिए आपको इंटरनेट कनेक्शन (Ethernet या फोन से USB टेथरिंग द्वारा) की आवश्यकता होगी। (जैसे कि कंपाइलर, linux-headers, आदि)


## ✅ परीक्षण किए गए सिस्टम (सत्यापित कार्यशील)
इस समाधान को सत्यापित किया गया है और यह निम्नलिखित पर सफलतापूर्वक कार्य कर रहा है:

* **ब्रांड:** ASUS
* **मॉडल:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **चिपसेट:** MediaTek MT7902 (WiFi 6E)
* **कर्नेल वर्शन:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **OS:** Arch, Ubuntu
* **पैकेज मैनेजर:** pacman, apt

## उपलब्धता:
* **OS**: कोई भी OS जो PM में से किसी एक को सपोर्ट करता हो
* **पसंदीदा पैकेज मैनेजर:** apt, pacman, dnf, zypper, nix-shell
* **कर्नेल वर्शन:** 6.14-7.0.7


## 🔧 प्रयुक्त फर्मवेयर
फर्मवेयर `firmware` फोल्डर में संग्रहित हैं।


## 📱 ब्लूटूथ ✅ (कार्यशील)
> [!WARNING]
> अगर ब्लूटूथ ड्राइवर का `gen4-mt7902` के साथ कॉन्फ्लिक्ट हो तो कृपया ब्लूटूथ फर्मवेयर हटा दें ताकि यह ड्राइवर के साथ हस्तक्षेप न करे
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> यह प्रोजेक्ट निम्नलिखित फर्मवेयर का उपयोग करता है
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

ब्लूटूथ सक्षम करने के लिए अपने वर्तमान कर्नेल वर्शन की डाइरेक्टरी में जाएं। ``
अगर आपके पास kernel linux-6.16 है तो डाइरेक्टरी `./linux-6.16/drivers/bluetooth` में जाएं।
इस डायरेक्टरी में टर्मिनल खोलें और कमांड `make` के साथ संकलित करें।
दो कर्नेल मॉड्यूल संकलित होते हैं `btusb.ko` और `btmtk.ko`।
अपने डिवाइस में ब्लूटूथ सक्षम करने के लिए सिस्टम में मौजूद btusb और btmtk को हटाएं और इन दोनों फाइलों को इंस्टॉल करें, निम्नलिखित कमांड का उपयोग करें
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
अब जांचें कि आपका ब्लूटूथ अब काम कर रहा है या नहीं।

## 💻 वाई-फाई ✅ (काम कर रहा है)
> [!IMPORTANT]
> कुछ सीमाओं के साथ काम करने वाला एक रिपॉजिटरी [यहाँ](https://github.com/hmtheboy154/gen4-mt7902) है

mt7902 के लिए वाई-फाई ड्राइवर, जो हाल ही में मीडियाटेक द्वारा जारी किया गया है, `latest` फोल्डर के अंदर है।

यदि आप उबंटू का उपयोग कर रहे हैं तो बस `latest` फोल्डर में जाएं और टर्मिनल में निम्नलिखित कमांड चलाएं।
```
make
```
यह सभी मॉड्यूल्स को संकलित करेगा, उन्हें संपीड़ित करेगा और इंस्टॉल करेगा (मूल कर्नेल मॉड्यूल को संशोधित मॉड्यूल से बदल देगा)। यदि आप कोई अन्य डिस्ट्रो हैं या सभी चरण नहीं चाहते हैं और केवल कोड संकलित करना चाहते हैं, तो टर्मिनल में चलाएं

```
make module_compile
```
आपके द्वारा संकलित मॉड्यूल को संपीड़ित करने के लिए, फिर टर्मिनल में चलाएँ
```
make module_compress
```
संपीड़ित मॉड्यूल को सिस्टम के कर्नेल मॉड्यूल में स्थापित करने के लिए, टर्मिनल में चलाएँ
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---