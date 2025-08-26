<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

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

## समाचार
- [2025-08-22] **बग सुधार**: Bird-Interact-Agent कोड में हमने एक बग ठीक किया है जिसमें phase-2 SQL का मूल्यांकन करते समय, संग्रहीत phase-1 SQL सफलतापूर्वक निष्पादित नहीं हो पाता था, जिससे Phase-2 की सफलता दर कम हो जाती थी। यह बग केवल उन कार्यों को प्रभावित करता है जहाँ phase1 sql डेटाबेस पर कुछ ऑपरेशन करता है, जैसे CREATE table आदि।

## 🧸 अवलोकन

BIRD-INTERACT, एक इंटरएक्टिव टेक्स्ट-टू-SQL बेंचमार्क है, जो **डायनामिक इंटरएक्शन के दृष्टिकोण से Text-to-SQL मूल्यांकन की पुनर्कल्पना करता है**।
यह वातावरण एक पदानुक्रमित ज्ञान आधार, डेटाबेस प्रलेखन और एक फ़ंक्शन-चालित उपयोगकर्ता सिम्युलेटर को मिश्रित करता है ताकि पूर्ण **CRUD** ऑपरेशनों के साथ वास्तविक एंटरप्राइज वातावरण का पुनर्निर्माण किया जा सके।
यह दो कठोर परीक्षण मोड प्रदान करता है: (1) निष्क्रिय **संवादी इंटरएक्शन** और (2) सक्रिय **एजेंटिक इंटरएक्शन**, जिसमें 600 एनोटेटेड कार्य शामिल हैं जैसे बिजनेस इंटेलिजेंस (BI), CRUD ऑपरेशन आदि, प्रत्येक को निष्पादनीय परीक्षण मामलों द्वारा संरक्षित किया गया है।
आम तौर पर मूल्यांकन के दौरान मॉडल और यूजर सिम्युलेटर के बीच 1,968-5,496 इंटरएक्शन टर्न होते हैं, जबकि अत्याधुनिक तर्क मॉडल वर्तमान में केवल **≈24%** और **≈18%** कार्य हल कर पाते हैं, जो इस बेंचमार्क की चुनौती को दर्शाता है।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ दो मूल्यांकन मोड

BIRD-INTERACT उपरोक्त दो मूल्यांकन मोड का समर्थन करता है:

   - **c-Interact**: संवादी इंटरएक्शन जो एक निष्क्रिय मोड है और इसका वर्कफ़्लो स्थिर रहता है। कोड और विस्तृत जानकारी `bird_interact_conv` में देखी जा सकती है।
   - **a-Interact**: एजेंटिक इंटरएक्शन, जो एक सक्रिय मोड है और इसका वर्कफ़्लो गतिशील होता है तथा मॉडल द्वारा संचालित होता है। कोड और विस्तृत जानकारी `bird_interact_agent` में देखी जा सकती है।


### 🐣 लाइट संस्करण

हम BIRD-INTERACT का एक लाइट संस्करण, `bird-interact-lite-exp`, जारी कर रहे हैं, जिसमें PostgreSQL के लिए विशेष रूप से 270 उच्च गुणवत्ता वाले वास्तविक-विश्व कार्य शामिल हैं। यह त्वरित प्रयोग के लिए एक अच्छा प्रारंभिक बिंदु है।

### 🦜 पूर्ण संस्करण

BIRD-INTERACT का पूर्ण संस्करण, `bird-interact-full`, एक व्यापक बेंचमार्क है जिसमें PostgreSQL के लिए 600 कार्य शामिल हैं। यह SQL संचालन और उपयोगकर्ता क्वेरीज़ की विस्तृत श्रेणी को कवर करता है। पूर्ण संस्करण जल्द ही आ रहा है।

### BIRD-INTERACT Lite पर मॉडल प्रदर्शन परिणाम

#### 1. **c-Interact** प्रदर्शन
| रैंक | मॉडल का नाम        | सामान्यीकृत पुरस्कार | स्तर         |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 उत्कृष्ट चैट |
| 2    | GPT-4o             | 30.33 | 💎 अच्छा चैट     |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 अच्छा चैट     |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ मानक         |
| 5    | DeepSeek-R1        | 21.74 | ✨ मानक         |
| 6    | Qwen3              | 20.33 | ⚪ मूलभूत        |
| 7    | DeepSeek-V3        | 15.85 | ⚪ मूलभूत        |

#### 2. **a-Interact** प्रदर्शन
| रैंक | मॉडल का नाम        | बजट पैरामीटर* | औसत चरण/कार्य | औसत लागत (USD)/कार्य | सामान्यीकृत पुरस्कार | स्तर                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 उत्कृष्ट इंटरैक्शन    |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 अच्छा इंटरैक्शन       |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 अच्छा इंटरैक्शन       |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ मानक                 |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ मानक                 |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ मूलभूत                |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ मूलभूत                |

> \* बजट पैरामीटर: प्रारंभिक बजट/उपयोगकर्ता धैर्य बजट, जिसे हमारी वर्चुअल मुद्रा *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> द्वारा मापा जाता है। अधिक विवरण के लिए देखें [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)।

### इंटरैक्शन-टाइम स्केलिंग (ITS)

इंटरैक्शन-टाइम स्केलिंग (ITS) किसी मॉडल की बहु-चरण इंटरैक्शन के माध्यम से अपने अंतिम प्रदर्शन को लगातार बढ़ाने की क्षमता को संदर्भित करता है। जब यह इंटरैक्टिव प्रदर्शन मॉडल के आदर्शीकृत एकल-चरण प्रदर्शन को पूरी तरह से निर्दिष्ट, अस्पष्टता रहित कार्य पर पार कर जाता है, तो हम कहते हैं कि यह **ITS कानून** को संतुष्ट करता है। जैसे-जैसे उपयोगकर्ता का धैर्य बढ़ता है और इंटरैक्शन चरण बढ़ते हैं, प्रदर्शन में निरंतर सुधार होता है, जिससे यह प्रदर्शित होता है कि मॉडल विस्तारित संवाद के दौरान प्रभावी संचार बनाए रख सकता है। वर्तमान में, हमें केवल claude-3-7-sonnet ही ITS कानून को संतुष्ट करता हुआ मिलता है।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 डेटासेट विवरण

### डेटासेट विवरण

- **डाटाबेस:** पूरी PostgreSQL डाटाबेस को [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) से डाउनलोड किया जा सकता है। अधिक जानकारी के लिए [Quick Eval](#quick-eval) सेक्शन देखें।
- **data:** प्रत्येक डेटा इंस्टेंस में निम्नलिखित मुख्य भाग होते हैं:
   - `selected_database`: डाटाबेस का नाम।  
   - `query`: अस्पष्टता-रहित उपयोगकर्ता क्वेरी।  
   - `amb_user_query`: उपयोगकर्ता क्वेरी जिसमें अस्पष्टता डाली गई है।
   - `user_query_ambiguity`: उपयोगकर्ता क्वेरी में डाली गई अस्पष्टताएँ।
   - `non_critical_ambiguity`: गैर-गंभीर अस्पष्टताएँ जैसे क्रम, सीमा आदि।
   - `knowledge_ambiguity`: बाहरी ज्ञान को छुपाकर बनाई गई अस्पष्टताएँ। 
   - `sol_sql`: ग्राउंड ट्रूथ SQL समाधान।  
   - `preprocess_sql`: समाधान या पूर्वानुमान चलाने से पहले रन की जाने वाली SQL क्वेरीज़।  
   - `clean_up_sql`: परीक्षण मामलों के बाद डाटाबेस में किए गए परिवर्तनों को वापस करने के लिए रन की जाने वाली SQL क्वेरीज़।  
   - `test_cases`: पूर्वानुमानित सही SQL को सत्यापित करने के लिए परीक्षण मामलों का सेट।
   - `follow_up`: लेबल किए गए फॉलो अप प्रश्न।
   - `external_knowledge`: विशिष्ट कार्य से संबंधित बाहरी ज्ञान।

- **evaluation:** मूल्यांकन कोड [`./evaluation`](./evaluation) डायरेक्टरी में उपलब्ध है।
- **Curated by:** BIRD टीम & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa-4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### डेटासेट उपयोग

ऑटो-क्रॉलिंग द्वारा डेटा लीकेज से बचने के लिए, हम GT समाधान SQL और परीक्षण मामले डेटा के साथ शामिल नहीं करते हैं।
पूर्ण सेट के लिए कृपया शीर्षक में टैग `[bird-interact-lite GT&Test Cases]` के साथ [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) पर ईमेल करें, जो स्वतः भेज दिया जाएगा।


<!-- ### HuggingFace से डेटासेट उपयोग करें

आप निम्नलिखित कमांड से HuggingFace से डेटासेट डाउनलोड कर सकते हैं:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
या आप दिए गए स्क्रिप्ट का उपयोग करके डेटासेट का पूर्ण संस्करण डाउनलोड कर सकते हैं और इसे विभिन्न उपभाषाओं में विभाजित कर सकते हैं।

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # इनपुट JSONL फ़ाइल का पथ (यदि आप डेटासेट HuggingFace से डाउनलोड करना चाहते हैं तो खाली हो सकता है)
  --output_folder path/to/output_dir # विभाजित फ़ाइलों का आउटपुट फ़ोल्डर
```

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
**a-interact** को चलाने के बारे में विवरण `./bird_interact_agent/README.md` में पाया जा सकता है; और **c-interact** के बारे में विवरण `./bird_interact_conv/README.md` में पाया जा सकता है।


## 📋 कार्य सूची

- [x] लाइट संस्करण जारी करें, bird-interact-lite (270)।
- [x] संवादात्मक संस्करण जारी करें, bird-interact-conv।
- [x] एजेंट संस्करण जारी करें, bird-interact-agent।
- [x] पूर्ण संस्करण जारी करें, bird-interact-full (600)।
- [ ] SFT / RL एक उपयोगकर्ता सिम्युलेटर

## निर्माता:
BIRD टीम और Google Cloud


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---