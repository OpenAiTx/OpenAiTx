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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[विस्तृत दस्तावेज़] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI संस्करण](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![डाउनलोड्स](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![लाइसेंस](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github एक शक्तिशाली टूल है जो आपको GitHub से आपके प्रश्नों के आधार पर (Agentic RAG पर आधारित) सबसे प्रासंगिक कोड स्निपेट्स, इश्यूज़ और रिपॉजिटरी जानकारी प्राप्त करने में मदद करता है, और उन्हें मूल्यवान ज्ञान संदर्भ में बदलता है। यह LLM चैटबॉट्स, AI एजेंट्स और ऑटो-डेव एजेंट्स को जटिल कोडिंग कार्यों को हल करने में सक्षम बनाता है। चाहे आप एक डेवलपर हों जो त्वरित समाधान ढूंढ रहे हों या एक इंजीनियर हों जो उन्नत ऑटो-डेव AI एजेंट्स को लागू कर रहे हों, llama-github इसे आसान और कुशल बनाता है।

अगर आपको यह प्रोजेक्ट पसंद आए या आपको इसमें संभावना दिखे, कृपया इसे एक ⭐️ दें। आपका समर्थन ही हमारी सबसे बड़ी प्रेरणा है!

## वास्तुकला
![हाई लेवल आर्किटेक्चर](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## स्थापना

```
pip install llama-github
```

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
अधिक उन्नत उपयोग और उदाहरणों के लिए, कृपया [डॉक्युमेंटेशन](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) देखें।

## मुख्य विशेषताएँ

- **🔍 बुद्धिमान GitHub पुनर्प्राप्ति**: यूज़र क्वेरी के आधार पर GitHub से अत्यंत प्रासंगिक कोड स्निपेट्स, इश्यूज़ और रिपॉजिटरी जानकारी प्राप्त करने के लिए llama-github की शक्ति का उपयोग करें। हमारी उन्नत पुनर्प्राप्ति तकनीकें सुनिश्चित करती हैं कि आपको सबसे उपयुक्त जानकारी तेज़ी और कुशलता से मिले।

- **⚡ रिपॉजिटरी पूल कैशिंग**: Llama-github में एक अभिनव रिपॉजिटरी पूल कैशिंग प्रणाली है। थ्रेड्स में रिपॉजिटरीज़ (जिसमें README, संरचना, कोड, और इश्यूज़ शामिल हैं) को कैश करके, llama-github GitHub सर्च पुनर्प्राप्ति क्षमता को बहुत तेज़ करता है और GitHub API टोकन के उपयोग को कम करता है। llama-github को मल्टी-थ्रेडेड प्रोडक्शन वातावरण में आत्मविश्वास के साथ डिप्लॉय करें, यह जानते हुए कि यह इष्टतम प्रदर्शन करेगा और आपके कीमती संसाधनों की बचत करेगा।

- **🧠 LLM-समर्थित प्रश्न विश्लेषण**: यूज़र प्रश्नों का विश्लेषण करने और अत्यधिक प्रभावी सर्च रणनीतियाँ एवं मानदंड उत्पन्न करने के लिए अत्याधुनिक भाषा मॉडलों का लाभ लें। Llama-github जटिल क्वेरीज़ को बुद्धिमानी से विभाजित करता है, यह सुनिश्चित करता है कि आप GitHub के विशाल रिपॉजिटरी नेटवर्क से सबसे प्रासंगिक जानकारी प्राप्त करें।

- **📚 व्यापक संदर्भ निर्माण**: GitHub से प्राप्त जानकारी को उन्नत भाषा मॉडलों की तर्क क्षमताओं के साथ सहजता से जोड़कर समृद्ध, संदर्भानुकूल उत्तर उत्पन्न करें। Llama-github जटिल और लंबे प्रश्नों को संभालने में माहिर है, व्यापक और सूचनात्मक उत्तर प्रदान करता है जिसमें आपके विकास की आवश्यकताओं के लिए विस्तृत संदर्भ शामिल होता है।

- **🚀 असिंक्रोनस प्रोसेसिंग उत्कृष्टता**: Llama-github को शुरुआत से ही असिंक्रोनस प्रोग्रामिंग की पूरी क्षमता का उपयोग करने के लिए बनाया गया है। कोडबेस में सावधानीपूर्वक लागू की गई असिंक्रोनस प्रणालियों के साथ, llama-github एक साथ कई अनुरोधों को संभाल सकता है, जिससे समग्र प्रदर्शन में काफी वृद्धि होती है। अनुभव करें कि किस प्रकार llama-github उच्च-वॉल्यूम कार्यभार को कुशलतापूर्वक संभालता है, बिना गति या गुणवत्ता से समझौता किए।

- **🔧 लचीला LLM एकीकरण**: Llama-github को विभिन्न LLM प्रोवाइडर, एम्बेडिंग मॉडल्स और रीरैंकिंग मॉडल्स के साथ आसानी से एकीकृत करें, ताकि लाइब्रेरी की क्षमताओं को आपकी विशिष्ट आवश्यकताओं के अनुसार अनुकूलित किया जा सके। हमारी विस्तारशील आर्किटेक्चर आपको llama-github की कार्यक्षमता को अनुकूलित और बढ़ाने की अनुमति देती है, यह सुनिश्चित करती है कि यह आपके अद्वितीय विकास वातावरण में सहजता से फिट हो सके।

- **🔒 मजबूत प्रमाणीकरण विकल्प**: Llama-github व्यक्तिगत एक्सेस टोकन और GitHub ऐप प्रमाणीकरण दोनों का समर्थन करता है, जिससे आप इसे विभिन्न विकास सेटअप में आसानी से एकीकृत कर सकते हैं। चाहे आप व्यक्तिगत डेवलपर हों या एक संगठनात्मक संदर्भ में काम कर रहे हों, llama-github आपके लिए सुरक्षित और विश्वसनीय प्रमाणीकरण विधियों के साथ उपलब्ध है।

- **🛠️ लॉगिंग और त्रुटि प्रबंधन**: हम सुचारू संचालन और आसान समस्या-समाधान के महत्व को समझते हैं। इसलिए llama-github में व्यापक लॉगिंग और त्रुटि प्रबंधन तंत्र शामिल है। लाइब्रेरी के व्यवहार में गहरी जानकारी प्राप्त करें, समस्याओं का त्वरित निदान करें, और एक स्थिर एवं विश्वसनीय विकास वर्कफ़्लो बनाए रखें।

## 🤖 हमारे AI-संचालित PR समीक्षा सहायक: LlamaPReview आज़माएँ

यदि आपको llama-github उपयोगी लगता है, तो आप हमारे AI-संचालित GitHub PR समीक्षा सहायक, LlamaPReview में भी रुचि ले सकते हैं। यह आपके विकास वर्कफ़्लो को पूरक बनाने और कोड गुणवत्ता को और बढ़ाने के लिए डिज़ाइन किया गया है।

### LlamaPReview की मुख्य विशेषताएँ:
- 🚀 एक-क्लिक इंस्टॉलेशन, कोई कॉन्फ़िगरेशन आवश्यक नहीं, पूरी तरह से स्वचालित
- 💯 वर्तमान में निःशुल्क उपयोग के लिए - कोई क्रेडिट कार्ड या भुगतान जानकारी आवश्यक नहीं
- 🧠 AI-संचालित, गहरे कोड समझ के साथ स्वचालित PR समीक्षाएँ
- 🌐 कई प्रोग्रामिंग भाषाओं का समर्थन

**LlamaPReview, llama-github की उन्नत संदर्भ पुनर्प्राप्ति और LLM-समर्थित विश्लेषण का उपयोग करता है** ताकि बौद्धिक, संदर्भ-समझ कोड समीक्षाएँ प्रदान की जा सकें। यह ऐसा है जैसे आपके रिपॉजिटरी के पूरे संदर्भ से लैस एक वरिष्ठ डेवलपर, हर PR को स्वचालित रूप से समीक्षा कर रहा हो!

👉 [LlamaPReview अभी इंस्टॉल करें](https://github.com/marketplace/llamapreview/) (निःशुल्क)

llama-github का संदर्भ पुनर्प्राप्ति के लिए और LlamaPReview का कोड समीक्षा के लिए उपयोग करके, आप एक शक्तिशाली, AI-संवर्धित विकास वातावरण बना सकते हैं।

## विज़न और रोडमैप

### विज़न

हमारा विज़न है कि हम AI-संचालित विकास समाधानों के भविष्य में एक केंद्रीय मॉड्यूल बनें, GitHub के साथ सहजता से एकीकृत हों और LLMs को जटिल कोडिंग कार्यों को स्वचालित रूप से हल करने में सक्षम बनाएं।

![Vision Architecture](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### रोडमैप

हमारे प्रोजेक्ट रोडमैप का विस्तृत दृश्य देखने के लिए, कृपया हमारे [Project Roadmap](https://github.com/users/JetXu-LLM/projects/2) पर जाएँ।

## आभार

हम निम्नलिखित ओपन-सोर्स प्रोजेक्ट्स के प्रति अपना आभार व्यक्त करना चाहते हैं, जिनके समर्थन और योगदान ने हमारी मदद की:

- **[LangChain](https://github.com/langchain-ai/langchain)**: वह मूलभूत ढांचा प्रदान करने के लिए, जो llama-github में LLM प्रॉम्प्टिंग और प्रोसेसिंग क्षमताओं को सशक्त बनाता है।
- **[Jina.ai](https://github.com/jina-ai/reader)**: s.jina.ai API और ओपन सोर्स रीरैंकर एवं एम्बेडिंग मॉडल्स उपलब्ध कराने के लिए, जो llama-github में उत्पन्न संदर्भों की सटीकता और प्रासंगिकता को बढ़ाते हैं।

इनका योगदान llama-github के विकास में अत्यंत महत्वपूर्ण रहा है, और हम आपको इनके प्रोजेक्ट्स को अधिक नवोन्मेषी समाधानों के लिए देखने की सिफारिश करते हैं।

## योगदान

हम llama-github में योगदान का स्वागत करते हैं! अधिक जानकारी के लिए कृपया हमारे [contributing guidelines](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) देखें।

## लाइसेंस

यह प्रोजेक्ट Apache 2.0 लाइसेंस की शर्तों के तहत लाइसेंस प्राप्त है। अधिक जानकारी के लिए [LICENSE](LICENSE) फ़ाइल देखें।

## संपर्क

यदि आपके पास कोई प्रश्न, सुझाव या प्रतिक्रिया हो, तो कृपया हमसे [Jet Xu's ईमेल](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) पर संपर्क करें।

---

llama-github चुनने के लिए धन्यवाद! हमें आशा है कि यह लाइब्रेरी आपके AI विकास अनुभव को बेहतर बनाएगी और आपको आसानी से शक्तिशाली अनुप्रयोग बनाने में मदद करेगी।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---