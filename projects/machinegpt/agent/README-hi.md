![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# एजेंट

एक हाई-वेलोसिटी, आत्मनिर्भर Python AI एजेंट फ्रेमवर्क जो OpenAI Python SDK का उपयोग करता है ताकि प्राकृतिक भाषा के आदेशों की व्याख्या कर सके, कोड को डायनामिक रूप से जेनरेट और निष्पादित कर सके, और अपने रनटाइम एनवायरनमेंट का प्रबंधन बिना किसी बाधा के कर सके। इसमें स्वचालित डिपेंडेंसी इंस्टॉलेशन, सुरक्षित एनवायरनमेंट कॉन्फ़िगरेशन, संरचित लॉगिंग, और शक्तिशाली Python टूल्स को एम्बेड करने के लिए एक न्यूनतम प्लगइन इंटरफेस की सुविधा है—ये सब कुछ मुक्त Apache 2.0 लाइसेंस के अंतर्गत।

## ⭐ स्टार इतिहास

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 पर्यावरण सेटअप

### Python वर्चुअल एनवायरनमेंट
प्रोजेक्ट सेटअप करने से पहले, वर्चुअल एनवायरनमेंट बनाना अनुशंसित है। इन चरणों का पालन करें:

वर्चुअल एनवायरनमेंट के बारे में जानें: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

वर्चुअल एनवायरनमेंट बनाएं और सक्रिय करें:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### प्रोजेक्ट सेटअप
इस प्रोजेक्ट को कार्य करने के लिए OpenAI API कुंजी की आवश्यकता है। इसे देने के लिए, रूट डायरेक्टरी में .env फ़ाइल बनाएं जिसमें निम्न सामग्री हो:
```
OPENAI_API_KEY=
```
वैकल्पिक रूप से, आप दी गई .env.example फ़ाइल कॉपी कर सकते हैं और कुंजी अपडेट कर सकते हैं:
```
cp .env.example .env
```

## 🧠 प्रारंभ करें
एजेंट शुरू करने के लिए, बस निम्न कमांड चलाएँ:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ योगदान

योगदान, सुझाव, बग रिपोर्ट और सुधार का स्वागत है!

नई सुविधाओं, घटकों, या एक्सटेंशन के लिए, कृपया एक इश्यू खोलें और PR भेजने से पहले चर्चा करें।

## 💖 यह प्रोजेक्ट अपने वर्तमान रूप में उन सभी लोगों के योगदान के कारण मौजूद है
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---