![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**किसी भी GitHub रिपॉजिटरी को प्रोडक्शन-रेडी Docker कंटेनर में बदलें, AI-संचालित Dockerfile जेनरेशन के साथ।**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer एक AI-संचालित वेब एप्लिकेशन है जो GitHub रिपॉजिटरीज़ का विश्लेषण करके अपने आप प्रोडक्शन-रेडी Dockerfiles जेनरेट करता है। बस किसी GitHub URL को पेस्ट करें और पाएं एक उपयुक्त Dockerfile, जिसमें बुद्धिमान बेस इमेज चयन, डिपेंडेंसी मैनेजमेंट, और Docker की सर्वोत्तम प्रथाएँ हों।

## 🌟 त्वरित एक्सेस

किसी भी GitHub रिपॉजिटरी URL में केवल `github.com` को `gitcontainer.com` से बदलें, और उस रिपॉजिटरी के लिए Dockerfile जेनरेशन पेज तुरंत एक्सेस करें।

उदाहरण के लिए:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ विशेषताएँ

- **🔄 त्वरित URL एक्सेस**: किसी भी GitHub URL में 'github.com' को 'gitcontainer.com' से बदलें
- **🤖 AI-संचालित विश्लेषण**: रिपॉजिटरी संरचना का विश्लेषण करने और बुद्धिमान Dockerfiles जेनरेट करने के लिए OpenAI GPT-4 का उपयोग करता है
- **⚡ रियल-टाइम स्ट्रीमिंग**: WebSocket स्ट्रीमिंग के साथ वास्तविक समय में अपना Dockerfile AI को बनाते हुए देखें
- **🎯 स्मार्ट डिटेक्शन**: टेक्नोलॉजी स्टैक्स (Python, Node.js, Java, Go आदि) को अपने आप पहचानता है
- **🔧 प्रोडक्शन-रेडी**: सर्वोत्तम प्रथाओं के अनुसार Dockerfiles जेनरेट करता है, जिसमें उचित सुरक्षा, मल्टी-स्टेज बिल्ड्स और ऑप्टिमाइज़ेशन होता है
- **📋 अतिरिक्त निर्देश**: विशिष्ट एनवायरनमेंट्स के लिए कस्टम आवश्यकताएँ जोड़ें
- **📄 Docker Compose**: जटिल अनुप्रयोगों के लिए अपने आप docker-compose.yml सुझाता है
- **🎨 आधुनिक UI**: साफ-सुथरा, उत्तरदायी इंटरफेस, सिंटैक्स हाइलाइटिंग के लिए Monaco एडिटर के साथ
- **📱 मोबाइल फ्रेंडली**: डेस्कटॉप और मोबाइल डिवाइस पर बिना किसी समस्या के कार्य करता है

## 🚀 त्वरित प्रारंभ

### आवश्यकताएँ

- Python 3.9 या उच्चतर
- Git
- OpenAI API कुंजी

### इंस्टॉलेशन

1. **रिपॉजिटरी क्लोन करें:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **डिपेंडेंसीज़ इंस्टॉल करें:**
   ```bash
   pip install -r requirements.txt
   ```

3. **एनवायरनमेंट वेरिएबल्स सेट करें:**
   ```bash
   # .env फ़ाइल बनाएं
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **एप्लिकेशन चलाएँ:**
   ```bash
   python app.py
   ```

5. **ब्राउज़र खोलें:**
   `http://localhost:8000` पर जाएँ

## 🛠️ यह कैसे काम करता है

1. **URL प्रोसेसिंग**: किसी भी रिपॉजिटरी तक पहुँचें, बस URL में 'github.com' को 'gitcontainer.com' से बदलें
2. **रिपॉजिटरी क्लोनिंग**: Gitcontainer Git का उपयोग करके GitHub रिपॉजिटरी को लोकली क्लोन करता है
3. **कोड विश्लेषण**: [gitingest](https://github.com/cyclotruc/gitingest) का उपयोग कर रिपॉजिटरी संरचना का विश्लेषण करता है और आवश्यक जानकारी एकत्र करता है
4. **AI जेनरेशन**: विश्लेषण को OpenAI GPT-4 को विशेष Dockerfile जेनरेशन प्रॉम्प्ट्स के साथ भेजता है
5. **स्मार्ट ऑप्टिमाइज़ेशन**: AI निम्न बातों का ध्यान रखता है:
   - टेक्नोलॉजी स्टैक डिटेक्शन
   - डिपेंडेंसी मैनेजमेंट
   - सुरक्षा सर्वोत्तम प्रथाएँ
   - जब लाभकारी हो, तब मल्टी-स्टेज बिल्ड्स
   - पोर्ट कॉन्फ़िगरेशन
   - एनवायरनमेंट वेरिएबल्स
   - हेल्थ चेक्स

## 📁 प्रोजेक्ट संरचना

```
cyclotruc-gitcontainer/
├── app.py                 # मुख्य FastAPI एप्लिकेशन
├── requirements.txt       # Python डिपेंडेंसीज़
├── .env                  # एनवायरनमेंट वेरिएबल्स (यह बनाएँ)
├── static/               # स्थैतिक संपत्तियाँ (आइकॉन्स, CSS)
├── templates/
│   └── index.jinja       # मुख्य HTML टेम्पलेट
└── tools/                # कोर फ़ंक्शनैलिटी मॉड्यूल्स
    ├── __init__.py
    ├── create_container.py  # AI Dockerfile जेनरेशन
    ├── git_operations.py    # GitHub रिपॉजिटरी क्लोनिंग
    └── gitingest.py        # रिपॉजिटरी विश्लेषण
```
## 🔧 कॉन्फ़िगरेशन

### एनवायरनमेंट वेरिएबल्स

| वेरिएबल | विवरण | आवश्यक |
|----------|-------------|----------|
| `OPENAI_API_KEY` | आपकी OpenAI API कुंजी | हाँ |
| `PORT` | सर्वर पोर्ट (डिफ़ॉल्ट: 8000) | नहीं |
| `HOST` | सर्वर होस्ट (डिफ़ॉल्ट: 0.0.0.0) | नहीं |

### उन्नत उपयोग

आप टूल्स को प्रोग्रामेटिक रूप से उपयोग कर सकते हैं:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # रिपॉजिटरी क्लोन करें
    clone_result = await clone_repo_tool(github_url)
    
    # gitingest से विश्लेषण करें
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Dockerfile जनरेट करें
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# उपयोग
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 कस्टमाइज़ेशन

### कस्टम इंस्ट्रक्शन्स जोड़ना

जनरेशन को कस्टमाइज़ करने के लिए "Additional instructions" फीचर का उपयोग करें:

- `"छोटे इमेज साइज के लिए Alpine Linux का उपयोग करें"`
- `"Redis और PostgreSQL शामिल करें"`
- `"प्रोडक्शन डिप्लॉयमेंट के लिए ऑप्टिमाइज़ करें"`
- `"डिबगिंग के लिए डेवलपमेंट टूल्स जोड़ें"`

## 📝 लाइसेंस

यह प्रोजेक्ट MIT लाइसेंस के तहत लाइसेंस प्राप्त है - विवरण के लिए [LICENSE](LICENSE) फाइल देखें।

## 🙏 आभार

- **[OpenAI](https://openai.com/)** GPT-4 API प्रदान करने के लिए
- **[gitingest](https://github.com/cyclotruc/gitingest)** रिपॉजिटरी विश्लेषण क्षमताओं के लिए
- **[FastAPI](https://fastapi.tiangolo.com/)** उत्कृष्ट वेब फ्रेमवर्क के लिए
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** कोड सिंटैक्स हाइलाइटिंग के लिए

## 🔗 लिंक

- **GitHub रिपॉजिटरी**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **डेमो**: उदाहरण रिपॉजिटरी के साथ लाइव आज़माएँ
- **Issues**: [बग रिपोर्ट करें या फीचर्स रिक्वेस्ट करें](https://github.com/cyclotruc/gitcontainer/issues)

---

**[Romain Courtois](https://github.com/cyclotruc) द्वारा ❤️ के साथ बनाया गया**

*किसी भी रिपॉजिटरी को सेकंड्स में कंटेनर में बदलें!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---