# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 🧸 अवलोकन

BIRD-INTERACT, एक इंटरएक्टिव टेक्स्ट-टू-SQL बेंचमार्क, **डायनामिक इंटरएक्शन के नजरिए से Text-to-SQL मूल्यांकन की कल्पना को नया रूप देता है**।
यह वातावरण एक पदानुक्रमित नॉलेज बेस, डेटाबेस डाक्यूमेंटेशन और एक फ़ंक्शन-आधारित यूजर सिम्युलेटर को जोड़ता है ताकि पूर्ण **CRUD** संचालन के साथ प्रामाणिक एंटरप्राइज़ वातावरण को फिर से बनाया जा सके।
यह दो कठोर परीक्षण मोड प्रदान करता है: (1) पैसिव **कन्वर्सेशनल इंटरएक्शन** और (2) एक्टिव **एजेंटिक इंटरएक्शन**, जिसमें 600 एनोटेटेड टास्क शामिल हैं जैसे बिजनेस इंटेलिजेंस (BI), CRUD संचालन आदि, प्रत्येक को निष्पादन योग्य टेस्ट केस द्वारा सुरक्षित किया गया है।
सामान्य मूल्यांकन मॉडल और यूजर सिम्युलेटर के बीच 1,968-5,496 इंटरएक्शन टर्न ट्रिगर करते हैं, जबकि अत्याधुनिक रीजनिंग मॉडल वर्तमान में केवल **≈24%** और **≈18%** कार्यों को हल कर पाते हैं, जो बेंचमार्क की चुनौती को उजागर करता है।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ दो मूल्यांकन मोड

BIRD-INTERACT उपरोक्त दो मूल्यांकन मोड को सपोर्ट करता है:

   - **c-Interact**: कन्वर्सेशनल इंटरएक्शन जो एक पैसिव मोड है और वर्कफ़्लो फिक्स्ड है। कोड और विस्तृत जानकारी `bird_interact_conv` में पाई जा सकती है।
   - **a-Interact**: एजेंटिक इंटरएक्शन, जो एक सशरीर एक्टिव मोड है जिसमें वर्कफ़्लो डायनामिक होता है और मॉडल द्वारा लीड किया जाता है। कोड और विस्तृत जानकारी `bird_interact_agent` में पाई जा सकती है।

### 🐣 लाइट संस्करण

हम BIRD-INTERACT का लाइट संस्करण, `bird-interact-lite-exp`, जारी कर रहे हैं, जिसमें PostgreSQL के लिए विशेष रूप से 270 उच्च-गुणवत्ता वाले वास्तविक कार्य शामिल हैं। त्वरित प्रयोग के लिए यह एक अच्छा प्रारंभिक बिंदु है।

### 🦜 पूर्ण संस्करण

BIRD-INTERACT का पूर्ण संस्करण, `bird-interact-full`, एक व्यापक बेंचमार्क है जिसमें PostgreSQL के लिए 600 कार्य शामिल हैं। यह SQL संचालन और यूजर क्वेरी की एक विस्तृत श्रृंखला को कवर करता है। पूर्ण संस्करण जल्द ही आ रहा है।

### BIRD-INTERACT Lite पर मॉडल प्रदर्शन परिणाम

#### 1. **c-Interact** प्रदर्शन
| रैंक | मॉडल नाम         | सामान्यीकृत इनाम | स्तर        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 उत्कृष्ट चैट |
| 2    | GPT-4o             | 30.33 | 💎 अच्छा चैट      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 अच्छा चैट      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ मानक       |
| 5    | DeepSeek-R1        | 21.74 | ✨ मानक       |
| 6    | Qwen3              | 20.33 | ⚪ बुनियादी          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ बुनियादी          |

#### 2. **a-Interact** प्रदर्शन
| रैंक | मॉडल नाम         | बजट पैरामीटर* | औसत टर्न/कार्य | औसत लागत (USD)/कार्य | सामान्यीकृत इनाम | स्तर            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 उत्कृष्ट इंटरएक्शन |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 अच्छा इंटरएक्शन      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 अच्छा इंटरएक्शन      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ मानक              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ मानक              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ बुनियादी                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ बुनियादी                 |

> \* बजट पैरामीटर: प्रारंभिक बजट/यूजर धैर्य बजट, हमारी वर्चुअल मुद्रा *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> में मापी गई। अधिक विवरण के लिए देखें [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)।

### इंटरएक्शन-टाइम स्केलिंग (ITS)

इंटरएक्शन-टाइम स्केलिंग (ITS) किसी मॉडल की बहु-टर्न इंटरएक्शन के माध्यम से अपनी अंतिम प्रदर्शन को लगातार बढ़ाने की क्षमता को संदर्भित करता है। जब यह इंटरएक्टिव प्रदर्शन पूरी तरह से निर्दिष्ट, अस्पष्टता रहित कार्य पर मॉडल के आदर्श सिंगल-टर्न प्रदर्शन को पार कर जाता है, तो हम कहते हैं कि यह **ITS नियम** को संतुष्ट करता है। जैसे-जैसे यूजर का धैर्य बढ़ता है और इंटरएक्शन टर्न बढ़ते हैं, प्रदर्शन लगातार सुधारता रहता है, जो यह दर्शाता है कि मॉडल विस्तारित संवाद के दौरान प्रभावी संचार बनाए रख सकता है। वर्तमान में, हमें केवल claude-3-7-sonnet ही ITS नियम को संतुष्ट करता हुआ मिला।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 डेटासेट विवरण

### डेटासेट विवरण

- **डेटाबेस:** संपूर्ण PostgreSQL डेटाबेस [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) से डाउनलोड किया जा सकता है। अधिक जानकारी के लिए [Quick Eval](#quick-eval) अनुभाग देखें।
- **data:** प्रत्येक डेटा इंस्टेंस में निम्नलिखित मुख्य भाग होते हैं:
   - `selected_database`: डेटाबेस का नाम।  
   - `query`: अस्पष्टता रहित यूजर क्वेरी।  
   - `amb_user_query`: यूजर क्वेरी जिसमें अस्पष्टता डाली गई है।
   - `user_query_ambiguity`: यूजर क्वेरी में डाली गई अस्पष्टता।
   - `non_critical_ambiguity`: गैर-महत्वपूर्ण अस्पष्टताएँ जैसे क्रम, सीमा आदि।
   - `knowledge_ambiguity`: नकाबपोश बाहरी ज्ञानों द्वारा उत्पन्न अस्पष्टताएँ।
   - `sol_sql`: ग्राउंड ट्रूथ SQL समाधान।
   - `preprocess_sql`: समाधान या पूर्वानुमान निष्पादित करने से पहले चलाने के लिए SQL क्वेरीज़।
   - `clean_up_sql`: परीक्षण मामलों के बाद डेटाबेस में किए गए किसी भी परिवर्तन को पूर्ववत करने के लिए चलाने के लिए SQL क्वेरीज़।
   - `test_cases`: पूर्वानुमानित सही SQL को मान्य करने के लिए परीक्षण मामलों का एक सेट।
   - `follow_up`: लेबल किए गए फॉलो-अप प्रश्न।
   - `external_knowledge`: विशिष्ट कार्य से संबंधित बाहरी ज्ञान।

- **मूल्यांकन:** मूल्यांकन कोड [`./evaluation`](./evaluation) डायरेक्टरी में उपलब्ध है।
- **संयोजित द्वारा:** BIRD टीम और Google Cloud
- **लाइसेंस:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace डेटासेट कार्ड:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### डेटासेट उपयोग

ऑटो-क्रॉलिंग के द्वारा डाटा लीकेज से बचने के लिए, हम GT समाधान sqls और परीक्षण मामलों को डेटा के साथ शामिल नहीं करते।
कृपया पूरे सेट के लिए [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) पर ईमेल करें और शीर्षक में टैग `[bird-interact-lite GT&Test Cases]` लिखें, जो स्वचालित रूप से भेज दिया जाएगा।


<!-- ### HuggingFace से डेटासेट का उपयोग करें

आप निम्नलिखित कमांड का उपयोग करके HuggingFace से डेटासेट डाउनलोड कर सकते हैं:
```bash
from datasets import load_dataset
# डेटासेट के फ्लैश वर्शन को लोड करें
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# डेटासेट के पूर्ण वर्शन को लोड करें (जल्द आ रहा है)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

या आप प्रदान की गई स्क्रिप्ट का उपयोग करके डेटासेट के पूर्ण वर्शन को डाउनलोड कर सकते हैं और इसे विभिन्न डायलेक्ट्स में विभाजित कर सकते हैं।
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # इनपुट JSONL फ़ाइल का पथ (यदि आप डेटासेट HuggingFace से डाउनलोड करना चाहते हैं तो यह खाली भी हो सकता है)
  --output_folder path/to/output_dir # विभाजित फ़ाइलों का आउटपुट फोल्डर
``` -->

## फ़ोल्डर संरचना
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
**a-interact** चलाने के बारे में विस्तृत जानकारी `./bird_interact_agent/README.md` में मिल सकती है; और **c-interact** के लिए `./bird_interact_conv/README.md` में।

## 📋 कार्यसूची

- [x] लाइट वर्शन जारी करें, bird-interact-lite (270)।
- [x] संवादात्मक वर्शन जारी करें, bird-interact-conv।
- [x] एजेंट वर्शन जारी करें, bird-interact-agent।
- [ ] पूर्ण वर्शन जारी करें, bird-interact-full (600)।
- [ ] SFT / RL एक यूज़र सिम्युलेटर

## निर्माताओं द्वारा:
BIRD टीम और Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---