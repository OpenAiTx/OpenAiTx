<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>
# AI नॉवेल एडिटर

PyQt6 पर आधारित AI सहायक नॉवेल एडिटर, जो स्मार्ट ऑटो-कम्प्लीशन, प्रोजेक्ट मैनेजमेंट, अवधारणा संगठन आदि जैसे पेशेवर लेखन उपकरण प्रदान करता है।

## इंस्टॉलेशन

1. प्रोजेक्ट क्लोन करें
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. वर्चुअल एनवायरनमेंट बनाएं
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
uv का प्रयोग करें
```bash
uv venv -p 3.11
```
3. निर्भरता स्थापित करें
```bash
pip install -r requirements.txt
```
uv का उपयोग करें
```bash
uv sync
```


4. प्रोग्राम चलाएं
```bash
python -m src
```

## मुख्य विशेषताएँ

### परियोजना प्रबंधन
- स्तरीकृत दस्तावेज़ संरचना (कृति > अध्याय > दृश्य)
- परियोजना आयात/निर्यात (TEXT, MARKDOWN, DOCX, PDF, HTML प्रारूपों का समर्थन)
- स्वचालित बैकअप और संस्करण नियंत्रण
- बहु-परियोजना प्रबंधन
### AI补全功能
- तीन प्रकार की ऑटो-कम्पलीशन मोड: स्वचालित पूर्ति, मैन्युअल पूर्ति (सिफारिश: एक बार टैब दबाने पर ट्रिगर, फिर एक बार टैब दबाने पर पूर्ति लागू करें), पूर्ति निष्क्रिय करें
- तीन प्रकार के संदर्भ मोड:
  - त्वरित मोड: हल्का संदर्भ, तेज़ प्रतिक्रिया
  - संतुलित मोड: मध्यम संदर्भ, गुणवत्ता और गति में संतुलन
  - वैश्विक मोड: संपूर्ण परियोजना संदर्भ, सर्वोत्तम प्रभाव
- कई AI सेवाओं का समर्थन: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq आदि

### रूपरेखा प्रबंधन
- दृश्य रूपरेखा वृक्ष संरचना
- ड्रैग-एंड-ड्रॉप क्रम और स्तर समायोजन
- दस्तावेज़ त्वरित नेविगेशन
- रूपरेखा विश्लेषण और अनुकूलन सुझाव

### API कॉन्फ़िगरेशन
- एकीकृत AI कॉन्फ़िगरेशन केंद्र
- कई सेवा प्रदाता प्रीसेट कॉन्फ़िगरेशन
- कनेक्शन परीक्षण फ़ंक्शन
- कॉन्फ़िगरेशन योजनाओं का सहेजना और आयात/निर्यात
### स्मार्ट ऑटो-कम्प्लीशन सेटिंग्स
- समायोज्य ट्रिगर विलंब
- कम्प्लीशन की लंबाई सीमा
- संदर्भ लंबाई कॉन्फ़िगरेशन
- स्ट्रीमिंग प्रतिक्रिया समर्थन

### प्रॉम्प्ट एडिटिंग
- अंतर्निहित विभिन्न लेखन टेम्पलेट्स
- कस्टम प्रॉम्प्ट टेम्पलेट्स
- टेम्पलेट श्रेणी प्रबंधन
- मोड-विशिष्ट टेम्पलेट कॉन्फ़िगरेशन

### इंटरफेस फीचर्स
- ड्यूल थीम (लाइट और डार्क)
- तीन-स्तंभ लेआउट (प्रोजेक्ट ट्री, संपादक, कॉन्सेप्ट पैनल)
- फोल्डेबल साइडबार
- फुल-स्क्रीन लेखन मोड
- फोकस मोड (वाक्य, पैराग्राफ, टाइपराइटर, ज़ेन मोड, इमर्सिव मोड)

### खोज और प्रतिस्थापन
- पूरे प्रोजेक्ट में टेक्स्ट सर्च
- रेगुलर एक्सप्रेशन समर्थन
- बैच रिप्लेसमेंट फ़ंक्शन
- एडवांस्ड सर्च विकल्प

### अवधारणा प्रबंधन
- भूमिकाएं, स्थान, वस्तुएं स्वचालित रूप से पहचानें
- अवधारणा संबंध प्रबंधन
- टैग और श्रेणी प्रणाली
- अवधारणा त्वरित सम्मिलन

## शॉर्टकट कुंजियाँ

- `Ctrl+N`: नया प्रोजेक्ट बनाएँ
- `Ctrl+O`: प्रोजेक्ट खोलें
- `Ctrl+S`: दस्तावेज़ सहेजें
- `F11`: फुल स्क्रीन मोड
- `Tab`: AI ऑटो-कम्प्लीट मैन्युअल रूप से ट्रिगर करें (मैन्युअल मोड में)
- `Ctrl+F`: खोजें
- `Ctrl+H`: खोजें और बदलें
- `Ctrl+Shift+H`: एडवांस्ड खोजें और बदलें
## सिस्टम आवश्यकताएँ

- Python 3.8+
- PyQt6
- ऑपरेटिंग सिस्टम: Windows, macOS, Linux

## लेखक

**inliver**
- ईमेल: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---