
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[विस्तृत दस्तावेज़] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI संस्करण](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![डाउनलोड्स](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![लाइसेंस](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github एक शक्तिशाली टूल है जो आपको आपके प्रश्नों के आधार पर GitHub से सबसे संबंधित कोड स्निपेट्स, इश्यूज़ और रिपॉजिटरी जानकारी प्राप्त करने में मदद करता है (एजेंटिक RAG पर आधारित), और उन्हें मूल्यवान नॉलेज कॉन्टेक्स्ट में बदलता है। यह LLM चैटबॉट्स, AI एजेंट्स और ऑटो-डेव एजेंट्स को जटिल कोडिंग कार्यों को हल करने में सक्षम बनाता है। चाहे आप एक डेवलपर हों जो त्वरित समाधान ढूंढ रहे हैं या एक इंजीनियर जो उन्नत ऑटो डेव AI एजेंट्स को लागू कर रहे हैं, llama-github इसे आसान और कुशल बनाता है।

यदि आपको यह प्रोजेक्ट पसंद है या आपको लगता है कि इसमें संभावनाएँ हैं, तो कृपया इसे एक ⭐️ दें। आपका समर्थन हमारी सबसे बड़ी प्रेरणा है!

## वास्तुकला
![High Level Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## स्थापना
```
pip install llama-github
```

वर्तमान में अनुरक्षित रनटाइम टार्गेट: Python `3.10+`.

## उपयोग

यहाँ llama-github का उपयोग करने का एक सरल उदाहरण है:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` एक सूची देता है जिसमें संदर्भ डिक्शनरी होती हैं। प्रत्येक आइटम में कम से कम `context` और `url` होता है।

अधिक उन्नत उपयोग और उदाहरणों के लिए, कृपया [डॉक्यूमेंटेशन](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) देखें। रन करने योग्य कम लागत वाले उदाहरण [`examples/`](examples) में भी उपलब्ध हैं।

## मुख्य विशेषताएँ

- **🔍 बुद्धिमान GitHub पुनः प्राप्ति**: यूज़र क्वेरी के आधार पर llama-github की शक्ति का उपयोग करके अत्यंत प्रासंगिक कोड स्निपेट्स, इश्यू और रिपॉजिटरी जानकारी GitHub से प्राप्त करें। हमारी उन्नत पुनः प्राप्ति तकनीकें आपको सबसे प्रासंगिक जानकारी शीघ्रता और दक्षता के साथ खोजने में मदद करती हैं।

- **⚡ रिपॉजिटरी पूल कैशिंग**: Llama-github में एक अभिनव रिपॉजिटरी पूल कैशिंग मैकेनिज्म है। रिपॉजिटरी (READMEs, स्ट्रक्चर, कोड और इश्यू सहित) को थ्रेड्स में कैश करके, llama-github GitHub खोज पुनः प्राप्ति दक्षता को उल्लेखनीय रूप से तेज करता है और GitHub API टोकन की खपत को न्यूनतम करता है।

- **🧠 LLM-समर्थित प्रश्न विश्लेषण**: यूज़र प्रश्नों का विश्लेषण करने और अत्यधिक प्रभावी खोज रणनीतियाँ एवं मानदंड उत्पन्न करने के लिए अत्याधुनिक भाषा मॉडल का लाभ लें। Llama-github जटिल क्वेरी को बुद्धिमानी से विभाजित करता है, जिससे आप GitHub के विशाल रिपॉजिटरी नेटवर्क से सबसे प्रासंगिक जानकारी प्राप्त कर सकते हैं।

- **📚 व्यापक संदर्भ निर्माण**: GitHub से प्राप्त जानकारी को उन्नत भाषा मॉडल की तर्क क्षमताओं के साथ सहज रूप से मिलाकर समृद्ध, प्रासंगिक उत्तर उत्पन्न करें। Llama-github सबसे जटिल और लंबी प्रश्नों को संभालने में उत्कृष्ट है, और आपके विकास की आवश्यकताओं के समर्थन हेतु विस्तृत संदर्भ सहित व्यापक व विश्लेषणात्मक उत्तर प्रदान करता है।

- **🚀 असिंक प्रोसेसिंग उत्कृष्टता**: Llama-github को पूरी तरह से असिंक प्रोग्रामिंग की पूरी क्षमता का लाभ उठाने के लिए बनाया गया है। कोडबेस में सावधानीपूर्वक लागू असिंक मैकेनिज्म के साथ, llama-github कई अनुरोधों को एक साथ संभाल सकता है, जिससे समग्र प्रदर्शन में उल्लेखनीय वृद्धि होती है।

- **🔧 लचीला LLM एकीकरण**: विभिन्न LLM प्रदाताओं, एम्बेडिंग मॉडल, री-रैंकिंग मॉडल, या injected LangChain-संगत चैट मॉडल के साथ llama-github को आसानी से एकीकृत करें, ताकि आप लाइब्रेरी की क्षमताओं को अपनी विशिष्ट आवश्यकताओं के अनुसार अनुकूलित कर सकें।

- **🔒 मजबूत प्रमाणीकरण विकल्प**: Llama-github व्यक्तिगत एक्सेस टोकन और GitHub App प्रमाणीकरण दोनों का समर्थन करता है, जिससे आप इसे विभिन्न विकास सेटअप में एकीकृत कर सकते हैं। चाहे आप व्यक्तिगत डेवलपर हों या संगठनात्मक संदर्भ में काम कर रहे हों, llama-github सुरक्षित और विश्वसनीय प्रमाणीकरण मैकेनिज्म के साथ आपकी जरूरतों को पूरा करता है।

- **🛠️ लॉगिंग और एरर हैंडलिंग**: हम सुचारू संचालन और आसान ट्रबलशूटिंग के महत्व को समझते हैं। इसी वजह से llama-github में व्यापक लॉगिंग और एरर हैंडलिंग मैकेनिज्म मौजूद हैं। लाइब्रेरी के व्यवहार की गहरी जानकारी प्राप्त करें, समस्याओं का शीघ्र निदान करें, और स्थिर व विश्वसनीय विकास वर्कफ़्लो बनाए रखें।

## 🤖 हमारा AI-समर्थित PR समीक्षा सहायक: LlamaPReview आज़माएँ

यदि आपको llama-github उपयोगी लगता है, तो आप हमारे AI-समर्थित GitHub PR समीक्षा सहायक LlamaPReview में भी रुचि ले सकते हैं। इसे आपके विकास वर्कफ़्लो के पूरक के लिए और कोड गुणवत्ता बढ़ाने हेतु डिज़ाइन किया गया है।

### LlamaPReview की मुख्य विशेषताएँ:
- 🚀 एक-क्लिक इंस्टालेशन, कोई कॉन्फ़िगरेशन आवश्यक नहीं, पूरी तरह ऑटो-रन
- 💯 वर्तमान में निःशुल्क उपयोग - कोई क्रेडिट कार्ड या भुगतान जानकारी आवश्यक नहीं
- 🧠 AI-समर्थित, ऑटोमेटेड PR समीक्षाएँ गहरी कोड समझ के साथ
- 🌐 कई प्रोग्रामिंग भाषाओं का समर्थन

**LlamaPReview llama-github की उन्नत संदर्भ पुनः प्राप्ति और LLM-समर्थित विश्लेषण** का उपयोग करता है, जिससे बुद्धिमान, संदर्भ-जागरूक कोड समीक्षा प्रदान होती है। यह ऐसा है जैसे आपके रिपॉजिटरी का पूरा संदर्भ लिए एक वरिष्ठ डेवलपर हर PR को स्वचालित रूप से समीक्षा कर रहा हो!

👉 [LlamaPReview अभी इंस्टॉल करें](https://github.com/marketplace/llamapreview/) (निःशुल्क)

llama-github का संदर्भ पुनः प्राप्ति और LlamaPReview का कोड समीक्षा उपयोग करके, आप एक शक्तिशाली, AI-समृद्ध विकास वातावरण बना सकते हैं।

## दृष्टि और रोडमैप


### विज़न

हमारा विज़न AI-चालित विकास समाधानों के भविष्य में एक केंद्रीय मॉड्यूल बनना है, जो GitHub के साथ सहजता से एकीकृत होकर LLMs को जटिल कोडिंग कार्यों को स्वचालित रूप से हल करने में सक्षम बनाता है।

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### रोडमैप

पहले के रोडमैप का ऐतिहासिक दृश्य देखने के लिए कृपया [Vision and Roadmap](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md) देखें।

## आभार

हम निम्नलिखित ओपन-सोर्स परियोजनाओं को उनके समर्थन और योगदान के लिए धन्यवाद देना चाहेंगे:

- **[LangChain](https://github.com/langchain-ai/langchain)**: llama-github में LLM प्रॉम्प्टिंग और प्रोसेसिंग क्षमताओं को सक्षम करने वाले मूलभूत फ्रेमवर्क प्रदान करने के लिए।
- **[Jina.ai](https://github.com/jina-ai/reader)**: s.jina.ai API और ओपन सोर्स रीरैंक और एम्बेडिंग मॉडल देने के लिए, जिससे llama-github में उत्पन्न संदर्भों की सटीकता और प्रासंगिकता बढ़ती है।

उनका योगदान llama-github के विकास में अत्यंत महत्वपूर्ण रहा है, और हम उनके प्रोजेक्ट्स को अधिक नवाचारी समाधानों के लिए अवश्य देखने की सलाह देते हैं।

## योगदान

हम llama-github में योगदान का स्वागत करते हैं! अधिक जानकारी के लिए कृपया हमारे [contributing guidelines](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) देखें।

## लाइसेंस

यह प्रोजेक्ट Apache 2.0 लाइसेंस की शर्तों के तहत लाइसेंस प्राप्त है। अधिक विवरण के लिए [LICENSE](LICENSE) फाइल देखें।

## संपर्क

यदि आपके कोई प्रश्न, सुझाव या फीडबैक हैं, तो कृपया बेझिझक [Jet Xu's email](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) पर संपर्क करें।

---

llama-github चुनने के लिए धन्यवाद! हमें आशा है कि यह लाइब्रेरी आपके AI विकास अनुभव को बेहतर बनाएगी और आपको शक्तिशाली एप्लिकेशन बनाने में आसानी से मदद करेगी।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---