<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - स्मार्ट Xianyu ग्राहक सेवा रोबोट सिस्टम

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Xianyu प्लेटफॉर्म के लिए विशेष रूप से डिज़ाइन किया गया AI ड्यूटी समाधान, Xianyu प्लेटफॉर्म पर 7×24 घंटे स्वचालित ड्यूटी, मल्टी-एक्सपर्ट सहयोगी निर्णय, स्मार्ट बार्गेनिंग और संदर्भ जागरूक वार्तालाप को सपोर्ट करता है।

## 🎮 Playground - त्वरित अनुभव (बिना किसी सेटअप के)

स्थानीय पर्यावरण या Secrets सेटिंग की आवश्यकता नहीं! **सिर्फ GitHub Actions वेब इंटरफेस के ज़रिए पैरामीटर डालें**, एक क्लिक में Xianyu रोबोट शुरू करें।

### उपयोग कैसे करें
1. **इस रिपॉजिटरी को Fork करें** → ऊपर दाएँ `Fork` बटन पर क्लिक करें
2. **Action ट्रिगर करें**:
   - अपनी रिपॉजिटरी के `Actions` टैब में जाएँ
   - **`🚀 Run Service`** वर्कफ़्लो चुनें
   - **`Run workflow`** बटन पर क्लिक करें, पैरामीटर भरें:
      - `API Key`: अपना बड़ा मॉडल API Key पेस्ट करें (जैसे अलीबाबा क्लाउड DashScope)
      - `Cookies`: Xianyu वेब इंटरफेस का पूरा Cookie स्ट्रिंग पेस्ट करें
3. **लॉग देखें**:
   - रोबोट शुरू होने के बाद खुद-ब-खुद Xianyu संदेशों को मॉनिटर करेगा
   - Action लॉग में `🤖 Reply:` खोजें और संवाद रिकॉर्ड देखें

### सावधानियाँ
⚠️ अस्थायी रनिंग सीमाएँ:
- डिफ़ॉल्ट रनिंग **30 मिनट** (GitHub फ्री अकाउंट लिमिट)
- संवेदनशील जानकारी (जैसे Cookie) **स्टोर नहीं होगी**, सिर्फ उसी रनिंग सत्र में मान्य

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 मुख्य विशेषताएँ

### स्मार्ट वार्तालाप इंजन
| मॉड्यूल   | तकनीकी कार्यान्वयन        | मुख्य विशेषताएँ                                                     |
| ---------- | ------------------- | ------------------------------------------------------------ |
| संदर्भ जागरूकता | वार्तालाप इतिहास स्टोरेज        | हल्के वार्तालाप मेमोरी प्रबंधन, पूरी वार्तालाप इतिहास LLM संदर्भ में इनपुट के रूप में |
| विशेषज्ञ रूटिंग   | LLM प्रॉम्प्ट+नियम आधारित रूटिंग | प्रॉम्प्ट इंजीनियरिंग आधारित इरादे की पहचान → विशेषज्ञ एजेंट डायनामिक असाइनमेंट, बार्गेनिंग/टेक्निकल/ग्राहक सेवा मल्टी-सीन स्विचिंग सपोर्ट |

### व्यवसायिक फ़ीचर मैट्रिक्स
| मॉड्यूल     | लागू हो चुका                        | योजनाबद्ध                     |
| -------- | ----------------------------- | ----------------------- |
| मुख्य इंजन | ✅ LLM ऑटो-रिप्लाई<br>✅ संदर्भ प्रबंधन | 🔄 भावना विश्लेषण एन्हांसमेंट               |
| बार्गेनिंग सिस्टम | ✅ स्टेप-डाउन मूल्य निर्धारण नीति                | 🔄 मार्केट प्राइस कंपेरison               |
| तकनीकी सहायता | ✅ वेब सर्च इंटीग्रेशन                | 🔄 RAG नॉलेज बेस एन्हांसमेंट             |

## 🚴 त्वरित शुरुआत

### पर्यावरण आवश्यकताएँ
- JDK 21+
- Maven 3.9.10+

### इंस्टॉलेशन स्टेप्स

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 योगदान में भाग लें

सुझाव देने के लिए Issue सबमिट करने या कोड में योगदान देने के लिए PR भेजने का स्वागत है, कृपया [योगदान गाइडलाइन](https://contributing.md/) का पालन करें।



## 🛡 सावधानियां

⚠️ ध्यान दें: **यह परियोजना केवल अध्ययन और संवाद के लिए है, यदि किसी प्रकार का उल्लंघन हो तो लेखक से संपर्क कर हटवा दें।**

परियोजना की विशेष प्रकृति के कारण, विकास टीम किसी भी समय **अपडेट रोक सकती है** या **परियोजना हटा सकती है**।


## 🧸 विशेष धन्यवाद

यह परियोजना निम्नलिखित ओपन सोर्स प्रोजेक्ट्स के आधार पर पुनर्निर्मित है:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - एक स्मार्ट闲鱼 कस्टमर सर्विस बोट सिस्टम, जिसे [@shaxiu](https://github.com/shaxiu) और [@cv-cat](https://github.com/cv-cat) ने विकसित किया है


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---