# Memvid - वीडियो-आधारित एआई मेमोरी 🧠📹

**एआई मेमोरी के लिए हल्का, गेम-चेंजर समाधान, बड़े पैमाने पर**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid एआई मेमोरी प्रबंधन में क्रांति लाता है, टेक्स्ट डेटा को वीडियो में एन्कोड करके, जिससे **लाखों टेक्स्ट चंक्स पर बिजली-सी तेज़ सिमेंटिक सर्च** और **सब-सेकंड रिट्रीवल टाइम** संभव होता है। पारंपरिक वेक्टर डेटाबेस की तुलना में, जो अत्यधिक RAM और स्टोरेज का उपभोग करते हैं, Memvid आपके नॉलेज बेस को संक्षिप्त वीडियो फाइलों में कंप्रेस करता है, साथ ही किसी भी जानकारी तक त्वरित पहुंच बनाए रखता है।

## 🎥 डेमो

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ मुख्य विशेषताएँ

- 🎥 **वीडियो-एज़-डेटाबेस**: लाखों टेक्स्ट चंक्स को एकल MP4 फाइल में संग्रहित करें
- 🔍 **सिमेंटिक सर्च**: नैचुरल लैंग्वेज क्वेरी का उपयोग करके प्रासंगिक सामग्री खोजें
- 💬 **इनबिल्ट चैट**: संदर्भ-सचेत प्रतिक्रियाओं के साथ संवादात्मक इंटरफ़ेस
- 📚 **PDF सपोर्ट**: PDF दस्तावेज़ों का सीधे आयात और अनुक्रमण
- 🚀 **तेज रिट्रीवल**: विशाल डेटासेट पर सब-सेकंड सर्च
- 💾 **कुशल संग्रहण**: पारंपरिक डेटाबेस की तुलना में 10x कंप्रेशन
- 🔌 **प्लग्गेबल LLMs**: OpenAI, Anthropic, या लोकल मॉडल्स के साथ कार्य करता है
- 🌐 **ऑफ़लाइन-फर्स्ट**: वीडियो जनरेशन के बाद इंटरनेट की आवश्यकता नहीं
- 🔧 **सरल API**: केवल 3 लाइनों में शुरू करें

## 🎯 उपयोग के मामले

- **📖 डिजिटल पुस्तकालय**: हजारों पुस्तकों को एकल वीडियो फाइल में अनुक्रमित करें
- **🎓 शैक्षिक सामग्री**: कोर्स सामग्री की खोज योग्य वीडियो मेमोरी बनाएं
- **📰 समाचार अभिलेखागार**: वर्षों के लेखों को प्रबंधनीय वीडियो डेटाबेस में संपीड़ित करें
- **💼 कॉर्पोरेट नॉलेज**: कंपनी-व्यापी खोज योग्य नॉलेज बेस बनाएं
- **🔬 अनुसंधान पत्र**: वैज्ञानिक साहित्य पर त्वरित सिमेंटिक सर्च
- **📝 व्यक्तिगत नोट्स**: अपने नोट्स को खोज योग्य एआई सहायक में बदलें

## 🚀 क्यों चुनें Memvid?

### गेम-चेंजर नवाचार
- **वीडियो-एज़-डेटाबेस**: लाखों टेक्स्ट चंक्स को एकल MP4 फाइल में संग्रहित करें
- **त्वरित पुनर्प्राप्ति**: विशाल डेटासेट पर सब-सेकंड सिमेंटिक सर्च
- **10x स्टोरेज एफिशिएंसी**: वीडियो कंप्रेशन से मेमोरी का उपयोग बहुत कम
- **शून्य इन्फ्रास्ट्रक्चर**: कोई डेटाबेस सर्वर नहीं, केवल फाइलें जिन्हें कहीं भी कॉपी कर सकते हैं
- **ऑफ़लाइन-फर्स्ट**: वीडियो जनरेट होने के बाद पूरी तरह ऑफलाइन कार्य करता है

### हल्का आर्किटेक्चर
- **न्यूनतम डिपेंडेंसी**: मुख्य कार्यक्षमता ~1000 लाइनों के पायथन में
- **CPU-फ्रेंडली**: GPU की आवश्यकता के बिना कुशलतापूर्वक चलता है
- **पोर्टेबल**: एकल वीडियो फाइल में आपका पूरा नॉलेज बेस संचित
- **स्ट्रीमेबल**: क्लाउड स्टोरेज से वीडियो स्ट्रीम की जा सकती है

## 📦 इंस्टॉलेशन

### त्वरित इंस्टॉल
```bash
pip install memvid
```

### PDF सपोर्ट के लिए
```bash
pip install memvid PyPDF2
```

### अनुशंसित सेटअप (वर्चुअल एनवायरनमेंट)
```bash
# नया प्रोजेक्ट डायरेक्टरी बनाएं
mkdir my-memvid-project
cd my-memvid-project

# वर्चुअल एनवायरनमेंट बनाएं
python -m venv venv

# सक्रिय करें
# मैकओएस/लिनक्स पर:
source venv/bin/activate
# विंडोज़ पर:
venv\Scripts\activate

# memvid इंस्टॉल करें
pip install memvid

# PDF सपोर्ट के लिए:
pip install PyPDF2
```

## 🎯 त्वरित प्रारंभ

### बेसिक उपयोग
```python
from memvid import MemvidEncoder, MemvidChat

# टेक्स्ट चंक्स से वीडियो मेमोरी बनाएं
chunks = ["Important fact 1", "Important fact 2", "Historical event details"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# अपनी मेमोरी से चैट करें
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("What do you know about historical events?")
print(response)
```

### दस्तावेज़ों से मेमोरी बनाना
```python
from memvid import MemvidEncoder
import os

# दस्तावेज़ लोड करें
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# टेक्स्ट फाइलें जोड़ें
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# अनुकूलित वीडियो बनाएं
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # अधिक FPS = प्रति सेकंड अधिक चंक्स
    frame_size=512  # बड़े फ्रेम = प्रति फ्रेम अधिक डेटा
)
```

### उन्नत खोज और पुनर्प्राप्ति
```python
from memvid import MemvidRetriever

# पुनर्प्राप्तकर्ता प्रारंभ करें
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# सिमेंटिक सर्च
results = retriever.search("machine learning algorithms", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# संदर्भ विंडो प्राप्त करें
context = retriever.get_context("explain neural networks", max_tokens=2000)
print(context)
```

### इंटरैक्टिव चैट इंटरफ़ेस
```python
from memvid import MemvidInteractive

# इंटरैक्टिव चैट UI लॉन्च करें
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # वेब इंटरफ़ेस खोलता है: http://localhost:7860
```

### file_chat.py के साथ परीक्षण करें
`examples/file_chat.py` स्क्रिप्ट आपको अपने दस्तावेज़ों के साथ Memvid का परीक्षण करने का व्यापक तरीका देती है:

```bash
# दस्तावेज़ों की डायरेक्टरी प्रोसेस करें
python examples/file_chat.py --input-dir /path/to/documents --provider google

# विशिष्ट फाइलें प्रोसेस करें
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# H.265 कंप्रेशन का उपयोग करें (Docker आवश्यक)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# बड़े दस्तावेज़ों के लिए कस्टम चंकिंग
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# मौजूदा मेमोरी लोड करें
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### संपूर्ण उदाहरण: PDF पुस्तक के साथ चैट करें
```bash
# 1. नई डायरेक्टरी बनाएं और एनवायरनमेंट सेट करें
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # विंडोज़ पर: venv\Scripts\activate

# 2. डिपेंडेंसी इंस्टॉल करें
pip install memvid PyPDF2

# 3. book_chat.py बनाएं
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# आपकी PDF फाइल
book_pdf = "book.pdf"  # अपनी PDF का पथ यहाँ लिखें

# वीडियो मेमोरी बनाएं
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# पुस्तक के साथ चैट करें
api_key = os.getenv("OPENAI_API_KEY")  # वैकल्पिक: एआई प्रतिक्रियाओं के लिए
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. इसे चलाएँ
export OPENAI_API_KEY="your-api-key"  # वैकल्पिक
python book_chat.py
```

## 🛠️ उन्नत कॉन्फ़िगरेशन

### कस्टम एम्बेडिंग्स
```python
from sentence_transformers import SentenceTransformer

# कस्टम एम्बेडिंग मॉडल का उपयोग करें
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### वीडियो ऑप्टिमाइज़ेशन
```python
# अधिकतम संपीड़न के लिए
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # अधिक फ्रेम प्रति सेकंड
    frame_size=256,  # छोटे फ्रेम
    video_codec='h265',  # बेहतर संपीड़न
    crf=28  # संपीड़न गुणवत्ता (कम = बेहतर गुणवत्ता)
)
```

### वितरित प्रोसेसिंग
```python
# बड़े डाटासेट्स को समानांतर में प्रोसेस करें
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 समस्या निवारण

### सामान्य समस्याएँ

**ModuleNotFoundError: No module named 'memvid'**
```bash
# सुनिश्चित करें कि आप सही Python का उपयोग कर रहे हैं
which python  # आपको अपने वर्चुअल एनवायरनमेंट का पथ दिखाना चाहिए
# यदि नहीं, तो अपना वर्चुअल एनवायरनमेंट सक्रिय करें:
source venv/bin/activate  # Windows पर: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**LLM API Key समस्याएँ**
```bash
# अपनी API कुंजी सेट करें (https://platform.openai.com पर प्राप्त करें)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# या Windows पर:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**बड़े PDF प्रोसेसिंग**
```python
# बहुत बड़े PDF के लिए, छोटे chunk size का उपयोग करें
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 योगदान

हम योगदान का स्वागत करते हैं! कृपया विवरण के लिए हमारे [Contributing Guide](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) को देखें।

```bash
# टेस्ट चलाएँ
pytest tests/

# कवरेज के साथ चलाएँ
pytest --cov=memvid tests/

# कोड फॉर्मेट करें
black memvid/
```

## 🆚 पारंपरिक समाधानों के साथ तुलना

| फीचर | Memvid | वेक्टर DBs | पारंपरिक DBs |
|---------|--------|------------|-----------------|
| स्टोरेज एफिशिएंसी | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| सेटअप जटिलता | सरल | जटिल | जटिल |
| सैमान्टिक सर्च | ✅ | ✅ | ❌ |
| ऑफलाइन उपयोग | ✅ | ❌ | ✅ |
| पोर्टेबिलिटी | फाइल-आधारित | सर्वर-आधारित | सर्वर-आधारित |
| स्केलेबिलिटी | मिलियन्स | मिलियन्स | बिलियन्स |
| लागत | फ्री | $$$$ | $$$ |


## 📚 उदाहरण

[examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) डायरेक्टरी देखें:
- विकिपीडिया डम्प्स से मेमोरी बनाना
- व्यक्तिगत नॉलेज बेस बनाना
- मल्टी-लैंग्वेज सपोर्ट
- रीयल-टाइम मेमोरी अपडेट्स
- लोकप्रिय LLMs के साथ इंटीग्रेशन

## 🆘 सहायता प्राप्त करें

- 📖 [डॉक्यूमेंटेशन](https://github.com/olow304/memvid/wiki) - व्यापक गाइड्स
- 💬 [डिस्कशन](https://github.com/olow304/memvid/discussions) - प्रश्न पूछें
- 🐛 [इशू ट्रैकर](https://github.com/olow304/memvid/issues) - बग रिपोर्ट करें
- 🌟 [शो & टेल](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - अपने प्रोजेक्ट साझा करें

## 🔗 लिंक

- [GitHub Repository](https://github.com/olow304/memvid)
- [PyPI Package](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 लाइसेंस

MIT लाइसेंस - विवरण के लिए [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) फ़ाइल देखें।

## 🙏 आभार

[Olow304](https://github.com/olow304) और Memvid समुदाय द्वारा निर्मित।

बनाया गया ❤️ के साथ, इनका उपयोग करते हुए:
- [sentence-transformers](https://www.sbert.net/) - सैमान्टिक सर्च के लिए अत्याधुनिक एम्बेडिंग्स
- [OpenCV](https://opencv.org/) - कंप्यूटर विज़न और वीडियो प्रोसेसिंग
- [qrcode](https://github.com/lincolnloop/python-qrcode) - QR कोड जनरेशन
- [FAISS](https://github.com/facebookresearch/faiss) - कुशल समानता खोज
- [PyPDF2](https://github.com/py-pdf/pypdf) - PDF टेक्स्ट एक्सट्रैक्शन

सभी योगदानकर्ताओं का विशेष धन्यवाद, जिन्होंने Memvid को बेहतर बनाने में मदद की!

---

**क्या आप अपने AI मेमोरी प्रबंधन में क्रांति लाने के लिए तैयार हैं? Memvid इंस्टॉल करें और शुरुआत करें!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---