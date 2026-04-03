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

## ⚠️ घोषणा  
कृपया ध्यान दें कि आपके मूल्यांकन प्रक्रिया से पहले, जब Docker डेटाबेस लोड करता है, तो पर्यावरण असंगति के कारण कभी-कभी त्रुटियाँ आ सकती हैं (ये प्रक्रिया को समाप्त नहीं करेंगी, लेकिन Docker लॉग में दिखाई देंगी)। परिणामस्वरूप, कुछ डेटाबेस सही तरीके से लोड नहीं हो पाएंगी, जिससे खाली डेटाबेस बनेंगी। यह मूल्यांकन परिणामों को असामान्य रूप से कम कर देगा।  
👉 इसलिए, हम दृढ़ता से अनुशंसा करते हैं कि **मूल्यांकन चलाने से पहले** Docker लॉग में किसी भी त्रुटि की जाँच करें और यह सुनिश्चित करें कि सभी डेटाबेस सफलतापूर्वक लोड हो गई हैं।

👉 हमने **सबमिशन गाइडलाइन्स** को अपडेट किया है, जिसमें कस्टमाइज्ड एजेंट स्कैफोल्ड्स सपोर्टेड हैं। कृपया हमारे विस्तृत सबमिशन गाइडलाइन्स को [यहाँ](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true) देखें।

## 📰 समाचार

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: हम **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)** जारी कर रहे हैं, जो Google ADK-आधारित कार्यान्वयन है जिसमें 3-माइक्रोसर्विस (एजेंट, यूजर सिम्युलेटर, और DB Env) के मॉड्यूलर आर्किटेक्चर हैं। आप आसानी से अपना खुद का एजेंट, यूजर सिम्युलेटर या DB वातावरण बदल सकते हैं। समानांतर निष्पादन और किसी भी [LiteLlm-संगत](https://docs.litellm.ai/docs/providers) LLM प्रदाता को सपोर्ट करता है। आपके अनुसंधान के लिए इस कार्यान्वयन का उपयोग करने की सलाह दी जाती है।

- [2026-02-08] 🔥🔥🔥 हमारा **[Bird-Interact पेपर](https://huggingface.co/papers/2510.05318)** **ICLR 2026 (ओरल)** में स्वीकार किया गया है! रियो 🇧🇷 में मिलते हैं!  

- [2025-11-06] 🐛 **बग फिक्स** & 🐳 **Docker अपडेट**: sqlglot संस्करण को 26.16.4 पर अपडेट किया गया है ताकि यूजर सिम्युलेटर के लिए SQL पार्सर में सही SQL पार्सिंग की समस्या ठीक की जा सके। आप इसे `pip install sqlglot==26.16.4` कमांड से `bird_interact_eval` वातावरण में फिर से इंस्टॉल कर सकते हैं। `bird_interact_eval` इमेज भी अपडेट की गई है, तो आप इसे पुल करके `bird_interact_eval` कंटेनर को फिर से बना सकते हैं।

- [2025-10-21] 🐳 **Docker अपडेट**: हमने Full DB Env के लिए docker जोड़ दिया है। और हमने 3 docker इमेज (Base/Full DB Env और मूल्यांकन वातावरण दोनों के लिए `a-Interact` और `c-Interact`) Docker Hub पर अपलोड की हैं ताकि पर्यावरण सेटअप आसान हो सके। अब DB dumps डाउनलोड करने और इमेज मैन्युअली बनाने की जरूरत नहीं!

- [2025-10-08] 📝 हमारा **[Bird-Interact पेपर](https://huggingface.co/papers/2510.05318)** अब सार्वजनिक रूप से उपलब्ध है!  
  इसमें हमारे इंटरएक्टिव टेक्स्ट-टू-SQL बेंचमार्क की पूरी जानकारी, कार्यप्रणाली, और मूल्यांकन प्रस्तुत किए गए हैं।  
  👉 इसे देखें और [BIRD-Interact](https://bird-interact.github.io/) के पीछे के विचारों के बारे में जानें।

- [2025-08-26] 🚀 हमें **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** सेट जारी करने की घोषणा करते हुए खुशी हो रही है!  
यह कठिन है — सर्वश्रेष्ठ LLMs केवल **16.33%** सफलता दर प्राप्त कर रहे हैं, और `c-interact` व `a-interact` हिस्सों में केवल **10.0%**।  
👉 अधिक जानकारी के लिए कृपया हमारे [प्रोजेक्ट वेबसाइट](https://bird-interact.github.io/) पर जाएँ।

- [2025-08-26] 📬 हम इस सप्ताह अपने मेलिंग लिस्ट पर **ग्राउंड ट्रूथ और टेस्ट केस** भेजेंगे।  
यदि आप जल्दी एक्सेस चाहते हैं, तो साइट पर दिए गए निर्देशानुसार ईमेल भेजें ताकि आपको **स्वचालित डाउनलोड** मिल सके।  

- [2025-08-26] 💾 एक अन्य सूचना में, हमने **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** का SQLite संस्करण भी जारी किया है ताकि स्थानीय शोध आसान हो सके।  
पूर्ण **LiveSQLBench-Base** और **-Large** संस्करण जल्द ही आ रहे हैं!

- [2025-08-22] **बग फिक्स**: Bird-Interact-Agent कोड में, हमने एक बग ठीक किया है जिसमें फेज-2 SQL का मूल्यांकन करते समय, स्टोर किया गया फेज-1 SQL सफलतापूर्वक निष्पादित नहीं हो पाता था, जिससे फेज-2 की सफलता दर कम हो जाती थी। यह बग केवल उन कार्यों को प्रभावित करता था जहां फेज-1 SQL डेटाबेस पर कुछ ऑपरेशन्स करता है, जैसे CREATE table आदि।

## 🧸 अवलोकन

BIRD-INTERACT, एक इंटरएक्टिव टेक्स्ट-टू-SQL बेंचमार्क, **डायनामिक इंटरैक्शन के दृष्टिकोण से Text-to-SQL मूल्यांकन की पुनर्कल्पना करता है**।
यह वातावरण एक पदानुक्रमित नॉलेज बेस, डेटाबेस डाक्यूमेंटेशन और फंक्शन-ड्रिवन यूजर सिम्युलेटर को मिलाकर प्रामाणिक एंटरप्राइज वातावरण की पुनर्रचना करता है, जिसमें पूर्ण **CRUD** ऑपरेशन्स शामिल हैं।
यह दो सख्त टेस्ट मोड प्रदान करता है: (1) पैसिव **कन्वर्सेशनल इंटरैक्शन** और (2) एक्टिव **एजेंटिक इंटरैक्शन**, जिसमें 600 एनोटेटेड टास्क्स शामिल हैं जैसे कि बिजनेस इंटेलिजेंस (BI), CRUD ऑपरेशन्स आदि, प्रत्येक को निष्पादनीय टेस्ट केस द्वारा सुरक्षित किया गया है।
टिपिकल मूल्यांकन में मॉडल और यूजर सिम्युलेटर के बीच 1,968-5,496 इंटरैक्शन टर्न्स होते हैं, जबकि अत्याधुनिक रीजनिंग मॉडल फिलहाल केवल **≈24%** और **≈18%** कार्य हल कर पाते हैं, जो बेंचमार्क की चुनौती को दर्शाता है।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ दो मूल्यांकन मोड

BIRD-INTERACT उपर्युक्त दो मूल्यांकन मोड का समर्थन करता है:

   - **c-Interact**: कन्वर्सेशनल इंटरैक्शन, जो एक पैसिव मोड है और वर्कफ़्लो फिक्स्ड है। कोड और विस्तृत जानकारी `bird_interact_conv` में मिल सकती है।
   - **a-Interact**: एजेंटिक इंटरैक्शन, जो एक एम्बॉडीड एक्टिव मोड है, जिसमें वर्कफ़्लो डायनामिक होता है और मॉडल्स द्वारा संचालित होता है। कोड और विस्तृत जानकारी `bird_interact_agent` में मिल सकती है।


### 🐣 लाइट संस्करण

हम BIRD-INTERACT का एक लाइट संस्करण, `bird-interact-lite-exp`, जारी कर रहे हैं, जिसमें विशेष रूप से PostgreSQL के लिए 270 उच्च-गुणवत्ता वाले वास्तविक-विश्व कार्य शामिल हैं। यह त्वरित प्रयोग के लिए एक अच्छा प्रारंभिक बिंदु है। 

### 🦜 पूर्ण संस्करण

BIRD-INTERACT का पूर्ण संस्करण, `bird-interact-full`, एक व्यापक बेंचमार्क है जिसमें PostgreSQL के लिए 600 कार्य शामिल हैं। इसमें विभिन्न प्रकार के SQL ऑपरेशन्स और यूजर क्वेरीज़ शामिल हैं। पूर्ण संस्करण जल्द आ रहा है।

### BIRD-INTERACT-FULL पर मॉडल प्रदर्शन परिणाम

#### 1. **c-Interact Text-to-SQL** प्रदर्शन
| Rank | मॉडल नाम           | सामान्यीकृत इनाम   | औसत लागत (USD)/कार्य | स्तर                |
|:----:|:-------------------|:-----------------:|:-------------------:|:-------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 उत्कृष्ट चैट      |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 उत्कृष्ट चैट      |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 अच्छा चैट         |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 अच्छा चैट         |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ मानक             |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ मानक             |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ बुनियादी          |

#### 2. **a-Interact Text-to-SQL** प्रदर्शन
| Rank | मॉडल नाम           | सामान्यीकृत इनाम   | औसत लागत (USD)/कार्य | स्तर                       |
|:----:|:-------------------|:-----------------:|:-------------------:|:--------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 उत्कृष्ट इंटरैक्शन      |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 उत्कृष्ट इंटरैक्शन      |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 अच्छा इंटरैक्शन         |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 अच्छा इंटरैक्शन         |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ मानक                   |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ मानक                   |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ बुनियादी                |

> \* बजट पैरामीटर: प्रारंभिक बजट/यूज़र धैर्य बजट, जिसे हमारी वर्चुअल करेंसी *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> द्वारा मापा जाता है। अधिक जानकारी के लिए देखें [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)।

### इंटरैक्शन-टाइम स्केलिंग (ITS)

इंटरैक्शन-टाइम स्केलिंग (ITS) एक मॉडल की बहु-टर्न इंटरैक्शन के माध्यम से अपने अंतिम प्रदर्शन को लगातार बढ़ाने की क्षमता को दर्शाता है। जब यह इंटरैक्टिव प्रदर्शन मॉडल के आदर्श एकल-टर्न प्रदर्शन को पूरी तरह निर्दिष्ट, अस्पष्ट रहित कार्य पर पार कर जाता है, तब हम कहते हैं कि यह **ITS नियम** को संतुष्ट करता है। जैसे-जैसे यूज़र का धैर्य बढ़ता है और इंटरैक्शन टर्न बढ़ते हैं, प्रदर्शन में सुधार होता रहता है, यह दर्शाता है कि मॉडल विस्तारित संवाद के दौरान प्रभावी संचार बनाए रख सकता है। वर्तमान में, केवल claude-3-7-sonnet को ही ITS नियम को पूरा करते पाया गया है।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## पर्यावरण सेटअप

1. bird-interact-lite डेटाबेस, bird-interact-full डेटाबेस और मूल्यांकन वातावरण के लिए Docker कंटेनर चलाएँ:
  
  > यदि आप केवल `bird-interact-lite` पर मूल्यांकन करना चाहते हैं, तो आप `docker-compose.yml` में [`postgresql_full` सेवा](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) को कॉमेंट कर सकते हैं, जिससे पर्यावरण सेटअप तेज़ होगा।
  
  वातावरण शुरू करने के लिए चलाएँ:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   डेटाबेस इनिशियलाइजेशन के लिए कुछ मिनट प्रतीक्षा करें।
   
  आप निर्माण प्रगति को निम्न तरीकों से ट्रैक कर सकते हैं:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  यदि समाप्त हो गया है, तो आपको बिना त्रुटियों के लॉग्स दिखाई देंगे, जैसे:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  यदि आपने पहले कंटेनर बनाए हैं और उसे पुनः बनाना चाहते हैं, तो आप निम्नलिखित कमांड चला सकते हैं:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   यह 3 कंटेनर Docker Hub से पूर्वनिर्मित इमेज का उपयोग करके चलाता है:
   - `bird_interact_postgresql`: bird-interact-lite के लिए PostgreSQL डाटाबेस
   - `bird_interact_postgresql_full`: bird-interact-full के लिए PostgreSQL डाटाबेस
   - `bird_interact_eval`: दोनों `a-Interact` और `c-Interact` के लिए मूल्यांकन वातावरण।

   अब, आप निम्नलिखित कमांड चलाकर मूल्यांकन वातावरण प्रारंभ कर सकते हैं:
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. (वैकल्पिक) पर्यावरण को मैन्युअली बनाएं (यदि आप इमेजेस को शुरू से बनाना चाहते हैं): 
   - डाटाबेस डंप्स डाउनलोड करें 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view)। अनज़िप करें और इसे `env/postgre_table_dumps` नाम दें।
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view)। अनज़िप करें और इसे `env/postgre_table_dumps_full` नाम दें।
   - `docker-compose.build.yml` चलाकर पर्यावरण को मैन्युअली बनाएं।

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (अनुशंसित) जाँचें कि डेटाबेस कंटेनर सफलतापूर्वक बनाए गए हैं और चल रहे हैं।

-  कंटेनर बिल्ड लॉग प्रिंट करें ताकि यह सुनिश्चित किया जा सके कि डेटाबेस बिना किसी त्रुटि के सफलतापूर्वक बनाए गए हैं:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   यदि त्रुटियाँ होती हैं, तो `"Errors occurred during import:"` लॉग फ़ाइलों में मुद्रित किया जाएगा।


-  जाँचें कि डेटाबेस कंटेनर अच्छी स्थिति में हैं।
   
   हमारे द्वारा प्रदान की गई Python स्क्रिप्ट का उपयोग करके डेटाबेस मेटाडेटा सत्यापित करें:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   अपेक्षित परिणाम:
   - **bird-interact-lite**: 
     - 📈 कुल डाटाबेस: 18
     - 📋 कुल टेबल: 175
     - 🔢 कुल कॉलम: 2286
     - 📈 प्रति टेबल औसत पंक्तियाँ: 1,038.48
     - 💾 कुल आकार: 207.15 MB (लगभग)
   - **bird-interact-full**: 
     - 📈 कुल डाटाबेस: 22
     - 📋 कुल टेबल: 244
     - 🔢 कुल कॉलम: 2011
     - 📈 प्रति टेबल औसत पंक्तियाँ: 1,121.19
     - 💾 कुल आकार: 272.00 MB (लगभग)


## 📦 डेटासेट विवरण

### डेटासेट विवरण

- **डेटाबेस:** संपूर्ण PostgreSQL डेटाबेस [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) और [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) से डाउनलोड किया जा सकता है।
- **data:** प्रत्येक डेटा उदाहरण में निम्नलिखित मुख्य भाग होते हैं:
   - `selected_database`: डेटाबेस का नाम।  
   - `query`: स्पष्ट उपयोगकर्ता क्वेरी।  
   - `amb_user_query`: अस्पष्टता डाली गई उपयोगकर्ता क्वेरी।
   - `user_query_ambiguity`: उपयोगकर्ता क्वेरी में डाली गई अस्पष्टताएँ।
   - `non_critical_ambiguity`: गैर-महत्वपूर्ण अस्पष्टताएँ जैसे क्रम, सीमा आदि।
   - `knowledge_ambiguity`: छुपाए गए बाहरी ज्ञान द्वारा उत्पन्न अस्पष्टताएँ। 
   - `sol_sql`: ग्राउंड ट्रुथ SQL समाधान।  
   - `preprocess_sql`: समाधान या भविष्यवाणी से पहले चलाने के लिए SQL क्वेरी।  
   - `clean_up_sql`: परीक्षण मामलों के बाद डेटाबेस में किए गए बदलावों को वापस लेने के लिए SQL क्वेरी।  
   - `test_cases`: भविष्यवाणी किए गए सही SQL को सत्यापित करने के लिए परीक्षण मामलों का सेट।
   - `follow_up`: लेबल किए गए फॉलो अप प्रश्न।
   - `external_knowledge`: विशिष्ट कार्य से संबंधित बाहरी ज्ञान।

- **मूल्यांकन:** मूल्यांकन कोड [`./evaluation`](./evaluation) डायरेक्टरी में उपलब्ध है।
- **क्यूरेटेड बाय:** BIRD टीम एवं Google Cloud
- **लाइसेंस:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace डेटासेट कार्ड:** PostgreSQL के लिए [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  और [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full); तथा SQLite के लिए [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact)।
### डेटासेट उपयोग

ऑटो-क्रॉलिंग द्वारा डेटा लीक से बचने के लिए, हम GT समाधान SQLs और टेस्ट केस को डेटा के साथ शामिल नहीं करते हैं।
कृपया ग्राउंड ट्रुथ और टेस्ट केस के लिए [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) पर टाइटल में टैग `[bird-interact-lite GT&Test Cases]` या `[bird-interact-full GT&Test Cases]` के साथ ईमेल करें, जो आपको bird-interact-lite या bird-interact-full डेटासेट के लिए स्वचालित रूप से भेज दिए जाएंगे।


### सार्वजनिक डेटा को ग्राउंड ट्रुथ और टेस्ट केस के साथ मिलाएं

फिर सार्वजनिक डेटा को ग्राउंड ट्रुथ और टेस्ट केस के साथ मिलाने के लिए निम्नलिखित स्क्रिप्ट का उपयोग करें:

पूर्ण संस्करण को उदाहरण के रूप में लें:
(1) चलाएँ:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
यह `/path/to/bird_interact_data.jsonl` पर संयुक्त डेटा के साथ एक नई फ़ाइल बनाएगा।

(2) फिर मूल सार्वजनिक डेटा को संयुक्त डेटा से बदलें:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

अन्य संस्करणों के लिए भी यही करें: bird-interact-lite, मिनी संस्करण, आदि। बस सार्वजनिक डेटा और ग्राउंड ट्रुथ तथा टेस्ट केस के लिए सही पथ सेट करें, और फिर सार्वजनिक डेटा को संयुक्त डेटा से बदल दें।




<!-- ### HuggingFace से डेटासेट का उपयोग करें

आप निम्नलिखित कमांड का उपयोग करके HuggingFace से डेटासेट डाउनलोड कर सकते हैं:
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
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
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
**a-interact** को चलाने के विवरण `./bird_interact_agent/README.md` में मिल सकते हैं; **c-interact** के विवरण `./bird_interact_conv/README.md` में मिल सकते हैं; और **ADK-आधारित कार्यान्वयन** का विवरण `./BIRD-Interact-ADK/README.md` में मिल सकता है।

## 📋 कार्य-सूची

- [x] लाइट वर्शन जारी करें, bird-interact-lite (270)।
- [x] संवादात्मक वर्शन जारी करें, bird-interact-conv।
- [x] एजेंट वर्शन जारी करें, bird-interact-agent।
- [x] पूर्ण वर्शन जारी करें, bird-interact-full (600)।
- [x] ADK-आधारित कार्यान्वयन जारी करें, BIRD-Interact-ADK।
- [ ] SFT / RL एक यूजर सिम्युलेटर

## आभार
हम अपनी हार्दिक कृतज्ञता व्यक्त करते हैं **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, और प्रोफेसर **Shinji Watanabe** को, जिनकी फलदायक चर्चाओं और बहुमूल्य सुझावों ने इस परियोजना को बेहतर बनाने में मदद की।

## द्वारा निर्मित:
BIRD टीम और Google Cloud







## संदर्भ

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```

## परिवर्तन लॉग

- [2025-11-06] 🐛 **बग फिक्स** और 🐳 **डॉकर अपडेट**: sqlglot संस्करण को 26.16.4 में अपडेट किया ताकि यूजर सिम्युलेटर के लिए SQL पार्सर SQL को सही से पार्स न कर पाने की बग को ठीक किया जा सके। आप इसे `bird_interact_eval` एनवायरनमेंट में `pip install sqlglot==26.16.4` के द्वारा दोबारा इंस्टॉल करके ठीक कर सकते हैं। `bird_interact_eval` इमेज भी अपडेट की गई है, तो आप इसे भी पुल करके `bird_interact_eval` कंटेनर को फिर से बना सकते हैं।
- [2025-10-21] 🐳 **डॉकर अपडेट**: Full DB Env के लिए डॉकर जोड़ा गया। हमने 3 डॉकर इमेज (Base/Full DB Env और दोनों `a-Interact` और `c-Interact` के लिए मूल्यांकन एनवायरनमेंट) डॉकर हब पर पुश की हैं ताकि एनवायरनमेंट सेटअप आसान हो सके। अब DB डंप डाउनलोड करने और इमेजेस मैन्युअली बनाने की जरूरत नहीं है! कृपया डॉकर हब से नवीनतम इमेजेस पुल करें और कंटेनर रीक्रिएट करें, जैसे `docker compose down -v && docker compose pull && docker compose up -d --force-recreate` का उपयोग करके।
- [2025-08-22]  🐛 **बग फिक्स**: उस बग को ठीक किया जिसमें phase-2 SQL का मूल्यांकन करते समय, स्टोर किए गए phase-1 SQL को सफलतापूर्वक निष्पादित नहीं किया जा सकता था, जिससे Phase-2 की सफलता दर कम हो जाती थी। यह बग केवल उन कार्यों को प्रभावित करता था जहां phase1 SQL डेटाबेस पर कुछ ऑपरेशन करता है, जैसे CREATE table आदि।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---