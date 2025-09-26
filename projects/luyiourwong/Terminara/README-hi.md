<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# टर्मिनारा

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python समर्थन](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

एक टर्मिनल-आधारित एआई सिमुलेशन गेम।


## उपयोग कैसे करें

आप [latest release](https://github.com/luyiourwong/Terminara/releases/latest) से निष्पादन योग्य एप्लिकेशन डाउनलोड कर सकते हैं।

पूर्ण संपीड़ित फ़ाइल में निष्पादन योग्य फ़ाइल और डिफ़ॉल्ट वर्ल्ड सेटिंग्स फ़ाइल शामिल है। यदि आप गेम को नवीनतम संस्करण में अपडेट कर रहे हैं तो आप केवल निष्पादन योग्य फ़ाइल डाउनलोड कर सकते हैं।

| OS      | संस्करण                                             |
|---------|-----------------------------------------------------|
| Windows | Windows 10, Windows 11                              |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS    |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26              |

<details>
<summary><strong>मैन्युअल रूप से चलाएँ</strong></summary>

### स्थापना

1.  **रिपॉजिटरी क्लोन करें:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```
2.  **एक वर्चुअल एनवायरनमेंट बनाएं:**

    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    विंडोज़ पर, `.venv\Scripts\activate` का उपयोग करें

3.  **डिपेंडेंसीज़ इंस्टॉल करें:**
    ```bash
    pip install -e .
    ```

### प्रारंभ विधि 1: स्थापित कमांड का उपयोग करना (अनुशंसित)
स्थापना के बाद, गेम चलाएं:
```bash
terminara
```

### प्रारंभ विधि 2: प्रत्यक्ष निष्पादन
क्रॉस-प्लेटफ़ॉर्म तरीका
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Windows पर, `terminara\main.py` का उपयोग करें

अधिक जानकारी के लिए, [योगदान एवं विकास गाइड](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md) देखें।
</details>

## एआई सेटअप

एप्लिकेशन शुरू करने के बाद, आपको मुख्य मेनू से एआई सेटिंग्स कॉन्फ़िगर करनी होंगी।

![एआई सेटिंग्स](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

आपको निम्नलिखित फ़ील्ड भरनी होंगी: (OpenAI संगत API)
- **Host**: एपीआई एंडपॉइंट। डिफ़ॉल्ट OpenAI एंडपॉइंट का उपयोग करने के लिए इसे खाली छोड़ें।
- **API Key**: एआई सेवा के लिए आपकी एपीआई कुंजी।
- **Model**: वह मॉडल जिसे आप उपयोग करना चाहते हैं।

सेटिंग्स सेव करने के लिए "Apply" पर क्लिक करें।

### उदाहरण

#### 1. [OpenAI](https://platform.openai.com/) (डिफ़ॉल्ट)
- **Host**: (खाली छोड़ें)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## वर्ल्ड सेटअप

### कॉन्फ़िगरेशन संग्रहण
वर्ल्ड सेटिंग्स `terminara/data/worlds` डायरेक्टरी में संग्रहित होती हैं। (पूर्ण रिलीज़ में)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### एक नई दुनिया बनाना
एक उदाहरण दुनिया है [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json)। आप [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) का पालन करके एक नई दुनिया बना सकते हैं।

## लिंक

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Repository](https://github.com/luyiourwong/Terminara)
- [योगदान एवं विकास गाइड](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## लाइसेंस

यह परियोजना [MIT License](LICENSE) के अंतर्गत लाइसेंस प्राप्त है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---