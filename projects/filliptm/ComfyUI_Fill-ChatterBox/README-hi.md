<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

यदि आपको यह प्रोजेक्ट पसंद है, तो कृपया मुझे Patreon पर समर्थन देने पर विचार करें!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

ComfyUI के लिए एक कस्टम नोड एक्सटेंशन, जो Chatterbox लाइब्रेरी का उपयोग करके टेक्स्ट-टू-स्पीच (TTS) और वॉयस कन्वर्जन (VC) क्षमताएँ जोड़ता है।
अधिकतम 40 सेकंड का समर्थन करता है। मैंने इस सीमा को हटाने की कोशिश की, लेकिन मॉडल इससे अधिक समय पर बहुत खराब परिणाम देता है, इसलिए इसे बरकरार रखा गया है।

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## स्थापना

1. इस रिपॉजिटरी को अपनी ComfyUI custom_nodes डायरेक्टरी में क्लोन करें:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. आधारभूत डिपेंडेंसीज़ स्थापित करें:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (वैकल्पिक) वॉटरमार्किंग समर्थन स्थापित करें:

   ```bash
   pip install resemble-perth
   ```
   **नोट**: `resemble-perth` पैकेज में Python 3.12+ के साथ संगतता संबंधी समस्याएँ हो सकती हैं। यदि आपको इंपोर्ट त्रुटियाँ मिलती हैं, तो नोड्स वॉटरमार्किंग के बिना भी काम करेंगे।

## उपयोग

### टेक्स्ट-टू-स्पीच नोड (FL Chatterbox TTS)
- अपने वर्कफ़्लो में "FL Chatterbox TTS" नोड जोड़ें
- टेक्स्ट इनपुट और पैरामीटर (exaggeration, cfg_weight, temperature) कॉन्फ़िगर करें
- वॉयस क्लोनिंग के लिए वैकल्पिक रूप से एक ऑडियो प्रॉम्प्ट दें

### वॉयस कन्वर्ज़न नोड (FL Chatterbox VC)
- अपने वर्कफ़्लो में "FL Chatterbox VC" नोड जोड़ें
- इनपुट ऑडियो और टार्गेट वॉयस कनेक्ट करें
- दोनों नोड्स में, यदि CUDA त्रुटियाँ आती हैं तो CPU फॉलबैक सपोर्ट है

## चेंज लॉग

### 24/6/2025
- टीटीएस और वीसी दोनों नोड्स में पुनरुत्पादन योग्य जनरेशन के लिए सीड पैरामीटर जोड़ा गया
- सीड रेंज: 0 से 4,294,967,295 (32-बिट पूर्णांक)
- डिबगिंग और वर्कफ़्लो नियंत्रण के लिए सुसंगत ऑडियो आउटपुट सक्षम करता है
- Python 3.12+ संगतता समस्याओं को ठीक करने के लिए Perth वॉटरमार्किंग को वैकल्पिक बनाया गया
- resemble-perth इंपोर्ट विफल होने पर अब नोड्स वॉटरमार्किंग के बिना भी काम करते हैं

### 31/5/2025
- पर्सिस्टेंट मॉडल लोडिंग और लोडिंग बार फ़ंक्शनलिटी जोड़ी गई
- Mac सपोर्ट जोड़ा गया (टेस्टिंग ज़रूरी है, इसलिए संपर्क करें)
- chatterbox-tts लाइब्रेरी हटाई गई और नेटिव इनफेरेंस कोड लागू किया गया।




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---