<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## सामग्री सूची

1. [परिचय](#1-introduction)
2. [मॉडल सारांश](#2-model-summary)
3. [मॉडल डाउनलोड](#3-model-downloads)
4. [मूल्यांकन परिणाम](#4-evaluation-results)
5. [चैट वेबसाइट और एपीआई प्लेटफॉर्म](#5-chat-website--api-platform)
6. [स्थानीय रूप से कैसे चलाएं](#6-how-to-run-locally)
7. [लाइसेंस](#7-license)
8. [संदर्भ](#8-citation)
9. [संपर्क](#9-contact)

## 1. परिचय

हम प्रस्तुत करते हैं DeepSeek-V3, एक शक्तिशाली मिक्सचर-ऑफ-एक्सपर्ट्स (MoE) भाषा मॉडल जिसमें कुल 671B पैरामीटर्स हैं, जिनमें से प्रत्येक टोकन के लिए 37B सक्रिय होते हैं।  
कुशल अनुमान और लागत प्रभावी प्रशिक्षण प्राप्त करने के लिए, DeepSeek-V3 Multi-head Latent Attention (MLA) और DeepSeekMoE आर्किटेक्चर को अपनाता है, जिन्हें DeepSeek-V2 में पूरी तरह से मान्य किया गया था।  
साथ ही, DeepSeek-V3 लोड बैलेंसिंग के लिए एक सहायक-हानि-रहित रणनीति (auxiliary-loss-free strategy) की शुरुआत करता है और बेहतर प्रदर्शन के लिए मल्टी-टोकन प्रेडिक्शन प्रशिक्षण लक्ष्य निर्धारित करता है।  
हम DeepSeek-V3 को 14.8 ट्रिलियन विविध और उच्च गुणवत्ता वाले टोकन पर पूर्व-प्रशिक्षित करते हैं, इसके बाद सुपरवाइज्ड फाइन-ट्यूनिंग और रिइंफोर्समेंट लर्निंग चरण होते हैं, जिससे इसकी क्षमताओं का पूर्ण उपयोग किया जा सके।  
व्यापक मूल्यांकन से पता चलता है कि DeepSeek-V3 अन्य ओपन-सोर्स मॉडलों से बेहतर प्रदर्शन करता है और अग्रणी क्लोज्ड-सोर्स मॉडलों के समान प्रदर्शन प्राप्त करता है।  
अपने उत्कृष्ट प्रदर्शन के बावजूद, DeepSeek-V3 के पूर्ण प्रशिक्षण के लिए केवल 2.788M H800 GPU घंटे की आवश्यकता होती है।  
इसके अतिरिक्त, इसका प्रशिक्षण प्रक्रिया अत्यंत स्थिर है।  
पूरे प्रशिक्षण के दौरान, हमें कभी भी कोई अपरिवर्तनीय लॉस स्पाइक्स नहीं मिले और न ही कोई रोलबैक किया गया।  
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. मॉडल सारांश

---

**आर्किटेक्चर: अभिनव लोड बैलेंसिंग रणनीति और प्रशिक्षण उद्देश्य**

- DeepSeek-V2 की कुशल आर्किटेक्चर पर, हम लोड बैलेंसिंग के लिए सहायक-हानि-रहित रणनीति की शुरुआत करते हैं, जिससे लोड बैलेंसिंग को प्रोत्साहित करने से उत्पन्न प्रदर्शन गिरावट न्यूनतम होती है।
- हम Multi-Token Prediction (MTP) उद्देश्य की जांच करते हैं और इसे मॉडल प्रदर्शन के लिए लाभकारी सिद्ध करते हैं।  
    इसे अनुमान त्वरण (inference acceleration) के लिए speculative decoding में भी इस्तेमाल किया जा सकता है।  

---

**पूर्व-प्रशिक्षण: अंतिम प्रशिक्षण दक्षता की ओर**

- हम FP8 मिश्रित सटीकता प्रशिक्षण ढांचा डिज़ाइन करते हैं, और पहली बार, अत्यंत बड़े पैमाने पर मॉडल पर FP8 प्रशिक्षण की व्यवहार्यता और प्रभावशीलता को मान्य करते हैं।  
- एल्गोरिदम, फ्रेमवर्क और हार्डवेयर के सह-डिज़ाइन के माध्यम से, हम क्रॉस-नोड MoE प्रशिक्षण में संचार बाधा को पार करते हैं, लगभग पूर्ण गणना-संचार ओवरलैप प्राप्त करते हैं।  
  यह हमारे प्रशिक्षण दक्षता को काफी बढ़ाता है और लागत को कम करता है, जिससे हम अतिरिक्त ओवरहेड के बिना मॉडल आकार को और बढ़ा सकते हैं।  
- केवल 2.664M H800 GPU घंटे की किफायती लागत पर, हम 14.8T टोकन पर DeepSeek-V3 का पूर्व-प्रशिक्षण पूरा करते हैं, जिससे वर्तमान में सबसे मजबूत ओपन-सोर्स बेस मॉडल तैयार होता है। पूर्व-प्रशिक्षण के बाद के प्रशिक्षण चरणों के लिए केवल 0.1M GPU घंटे की आवश्यकता होती है।

---

**पोस्ट-प्रशिक्षण: DeepSeek-R1 से ज्ञान आसवन (डिस्टिलेशन)**

-   हम एक अभिनव कार्यप्रणाली पेश करते हैं जिससे लंबी चेन-ऑफ-थॉट (CoT) मॉडल, विशेष रूप से DeepSeek R1 श्रृंखला के एक मॉडल से, मानक LLMs, विशेष रूप से DeepSeek-V3 में तर्क क्षमताओं का आसवन किया जाता है। हमारी पाइपलाइन R1 के सत्यापन और परावर्तन पैटर्न को DeepSeek-V3 में खूबसूरती से समाहित करती है और इसके तर्क प्रदर्शन में उल्लेखनीय सुधार करती है। साथ ही, हम DeepSeek-V3 के आउटपुट शैली और लंबाई को भी नियंत्रित रखते हैं।

---

## 3. मॉडल डाउनलोड

<div align="center">

| **मॉडल** | **#कुल पैरामीटर्स** | **#सक्रिय पैरामीटर्स** | **संदर्भ लंबाई** | **डाउनलोड** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> Hugging Face पर DeepSeek-V3 मॉडलों का कुल आकार 685B है, जिसमें 671B मुख्य मॉडल वजन और 14B Multi-Token Prediction (MTP) मॉड्यूल वजन शामिल हैं।

सर्वोत्तम प्रदर्शन और लचीलापन सुनिश्चित करने के लिए, हमने ओपन-सोर्स समुदायों और हार्डवेयर विक्रेताओं के साथ साझेदारी की है, ताकि मॉडल को स्थानीय रूप से चलाने के कई तरीके उपलब्ध कराए जा सकें। चरण-दर-चरण मार्गदर्शन के लिए, अनुभाग 6 देखें: [स्थानीय रूप से कैसे चलाएं](#6-how-to-run-locally)।

डेवलपर्स के लिए, हम मुख्य मॉडल वजन और मल्टी-टोकन प्रेडिक्शन (MTP) मॉड्यूल के विवरण के लिए [README_WEIGHTS.md](./README_WEIGHTS.md) देखने की सलाह देते हैं। कृपया ध्यान दें कि MTP समर्थन वर्तमान में समुदाय में सक्रिय विकास के अधीन है, और हम आपके योगदान व फीडबैक का स्वागत करते हैं।

## 4. मूल्यांकन परिणाम
### बेस मॉडल
#### मानक बेंचमार्क

<div align="center">

|  | बेंचमार्क (मेट्रिक) | #शॉट्स | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | आर्किटेक्चर | - | MoE | Dense | Dense | MoE |
| | #सक्रिय पैरामीटर्स | - | 21B | 72B | 405B | 37B |
| | #कुल पैरामीटर्स | - | 236B | 72B | 405B | 671B |
| अंग्रेज़ी | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (सटीकता) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (सटीकता) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (सटीकता) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (सटीकता) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (सटीकता) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (सटीकता) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (सटीकता) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (सटीकता) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (सटीकता) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (सटीकता) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (सटीकता) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| कोड | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (सटीकता) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (सटीकता) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| गणित | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| चीनी | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (सटीकता) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (सटीकता) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (सटीकता) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (सटीकता) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| बहुभाषी | MMMLU-non-English (सटीकता) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> सर्वश्रेष्ठ परिणाम बोल्ड में दिखाए गए हैं। 0.3 से अधिक का अंतर न होने वाले स्कोर को एक ही स्तर का माना जाता है। DeepSeek-V3 अधिकांश बेंचमार्क पर सर्वश्रेष्ठ प्रदर्शन करता है, विशेष रूप से गणित और कोड कार्यों पर।
> अधिक मूल्यांकन विवरण के लिए, कृपया हमारा पेपर देखें। 

#### संदर्भ विंडो
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

``Needle In A Haystack`` (NIAH) परीक्षणों पर मूल्यांकन परिणाम। DeepSeek-V3 सभी संदर्भ विंडो लंबाई (context window lengths) में **128K** तक अच्छा प्रदर्शन करता है।

### चैट मॉडल
#### मानक बेंचमार्क (67B से बड़े मॉडल)
<div align="center">

| | **बेंचमार्क (मेट्रिक)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | आर्किटेक्चर | MoE | MoE | Dense | Dense | - | - | MoE |
| | #सक्रिय पैरामीटर्स | 21B | 21B | 72B | 405B | - | - | 37B |
| | #कुल पैरामीटर्स | 236B | 236B | 72B | 405B | - | - | 671B |
| अंग्रेज़ी | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (सटीकता) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (सटीकता) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| कोड | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (प्रतिशत) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (सटीकता) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (सटीकता) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| गणित | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| चीनी | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (सही) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> सभी मॉडलों का मूल्यांकन एक कॉन्फ़िगरेशन में किया गया है जो आउटपुट लंबाई को 8K तक सीमित करता है। 1000 से कम सैंपल वाले बेंचमार्क को मजबूत अंतिम परिणाम प्राप्त करने के लिए कई बार विभिन्न तापमान सेटिंग्स के साथ परीक्षण किया जाता है। DeepSeek-V3 सबसे अच्छा प्रदर्शन करने वाला ओपन-सोर्स मॉडल है, और अग्रणी क्लोज्ड-सोर्स मॉडलों के मुकाबले भी प्रतिस्पर्धी प्रदर्शन दिखाता है।

####  ओपन एंडेड जनरेशन मूल्यांकन

<div align="center">

| मॉडल | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> अंग्रेज़ी ओपन-एंडेड संवाद मूल्यांकन। AlpacaEval 2.0 के लिए, हम मेट्रिक के रूप में लंबाई-नियंत्रित जीत दर (win rate) का उपयोग करते हैं।

## 5. चैट वेबसाइट और एपीआई प्लेटफॉर्म
आप DeepSeek-V3 के साथ DeepSeek की आधिकारिक वेबसाइट पर चैट कर सकते हैं: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

हम DeepSeek प्लेटफॉर्म पर OpenAI-संगत एपीआई भी प्रदान करते हैं: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. स्थानीय रूप से कैसे चलाएं

DeepSeek-V3 को निम्नलिखित हार्डवेयर और ओपन-सोर्स समुदाय सॉफ़्टवेयर का उपयोग करके स्थानीय रूप से तैनात किया जा सकता है:

1. **DeepSeek-Infer डेमो**: हम FP8 और BF16 अनुमान के लिए एक सरल और हल्का डेमो प्रदान करते हैं।
2. **SGLang**: BF16 और FP8 दोनों अनुमान मोड में DeepSeek-V3 मॉडल का पूर्ण समर्थन करता है, मल्टी-टोकन प्रेडिक्शन [जल्द आ रहा है](https://github.com/sgl-project/sglang/issues/2591)।
3. **LMDeploy**: स्थानीय और क्लाउड तैनाती के लिए कुशल FP8 और BF16 अनुमान सक्षम करता है।
4. **TensorRT-LLM**: वर्तमान में BF16 अनुमान और INT4/8 क्वांटाइजेशन का समर्थन करता है, FP8 समर्थन जल्द आ रहा है।
5. **vLLM**: टेन्सर पैरेलिज़्म और पाइपलाइन पैरेलिज़्म के लिए FP8 और BF16 मोड के साथ DeepSeek-V3 मॉडल का समर्थन करता है।
6. **LightLLM**: FP8 और BF16 के लिए कुशल सिंगल-नोड या मल्टी-नोड तैनाती का समर्थन करता है।
7. **AMD GPU**: SGLang के माध्यम से BF16 और FP8 दोनों मोड में DeepSeek-V3 मॉडल को AMD GPU पर चलाने में सक्षम बनाता है।
8. **Huawei Ascend NPU**: Huawei Ascend डिवाइसेज पर DeepSeek-V3 चलाने का समर्थन करता है।

चूंकि हमारे फ्रेमवर्क में FP8 प्रशिक्षण मूल रूप से अपनाया गया है, हम केवल FP8 वेट्स प्रदान करते हैं। यदि आप प्रयोग के लिए BF16 वेट्स की आवश्यकता रखते हैं, तो आप प्रदान किए गए कन्वर्ज़न स्क्रिप्ट का उपयोग करके रूपांतरण कर सकते हैं।

यहाँ FP8 वेट्स को BF16 में बदलने का एक उदाहरण है:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Hugging Face का Transformers अभी सीधे समर्थित नहीं है।

### 6.1 DeepSeek-Infer डेमो के साथ अनुमान (केवल उदाहरण)

#### सिस्टम आवश्यकताएँ

> [!NOTE] 
> केवल Linux और Python 3.10। Mac और Windows समर्थित नहीं हैं।

डिपेंडेंसी:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### मॉडल वेट्स और डेमो कोड तैयारी

सबसे पहले, हमारे DeepSeek-V3 GitHub रिपॉजिटरी को क्लोन करें:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

`inference` फ़ोल्डर में जाएँ और `requirements.txt` में सूचीबद्ध डिपेंडेंसी इंस्टॉल करें। सबसे आसान तरीका है `conda` या `uv` जैसे पैकेज मैनेजर का उपयोग करके नया वर्चुअल एनवायरनमेंट बनाना और डिपेंडेंसी इंस्टॉल करना।

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

मॉडल वेट्स Hugging Face से डाउनलोड करें, और उन्हें `/path/to/DeepSeek-V3` फ़ोल्डर में रखें।

#### मॉडल वेट्स कन्वर्ज़न

Hugging Face मॉडल वेट्स को विशिष्ट प्रारूप में बदलें:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### चलाएँ

फिर आप DeepSeek-V3 के साथ चैट कर सकते हैं:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

या किसी दिए गए फ़ाइल पर बैच अनुमान करें:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 SGLang के साथ अनुमान (अनुशंसित)

[SGLang](https://github.com/sgl-project/sglang) वर्तमान में [MLA अनुकूलन](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache, और Torch Compile का समर्थन करता है, जिससे ओपन-सोर्स फ्रेमवर्क्स में अत्याधुनिक लेटेंसी और थ्रूपुट प्रदर्शन मिलता है।

विशेष रूप से, [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) **NVIDIA और AMD GPU** दोनों पर DeepSeek-V3 चलाने का पूर्ण समर्थन करता है, जिससे यह एक अत्यंत बहुमुखी और मजबूत समाधान बनता है।

SGLang [मल्टी-नोड टेन्सर पैरेलिज़्म](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208) का भी समर्थन करता है, जिससे आप इस मॉडल को कई नेटवर्क-कनेक्टेड मशीनों पर चला सकते हैं।

मल्टी-टोकन प्रेडिक्शन (MTP) विकासाधीन है, और प्रगति को [ऑप्टिमाइज़ेशन प्लान](https://github.com/sgl-project/sglang/issues/2591) में ट्रैक किया जा सकता है।

यहाँ SGLang टीम से लॉन्च निर्देश दिए गए हैं: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 LMDeploy के साथ अनुमान (अनुशंसित)
[LMDeploy](https://github.com/InternLM/lmdeploy), एक लचीला और उच्च प्रदर्शन वाला अनुमान एवं सर्विंग फ्रेमवर्क, अब DeepSeek-V3 का समर्थन करता है। यह ऑफ़लाइन पाइपलाइन प्रोसेसिंग और ऑनलाइन तैनाती दोनों क्षमताएँ प्रदान करता है, और PyTorch-आधारित वर्कफ़्लो के साथ सहज एकीकरण करता है।

DeepSeek-V3 को LMDeploy के साथ चलाने के लिए चरण-दर-चरण निर्देशों के लिए, कृपया यहाँ देखें: https://github.com/InternLM/lmdeploy/issues/2960

### 6.4 TRT-LLM के साथ अनुमान (अनुशंसित)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) अब DeepSeek-V3 मॉडल का समर्थन करता है, जिसमें BF16 और INT4/INT8 वेट-ओनली सटीकता विकल्प उपलब्ध हैं। FP8 का समर्थन विकासाधीन है और जल्द ही जारी किया जाएगा। आप DeepSeek-V3 समर्थन के लिए TRTLLM की कस्टम ब्रांच यहाँ देख सकते हैं: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3.

### 6.5 vLLM के साथ अनुमान (अनुशंसित)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 NVIDIA और AMD GPU दोनों पर FP8 और BF16 मोड के लिए DeepSeek-V3 अनुमान का समर्थन करता है। मानक तकनीकों के अलावा, vLLM _pipeline parallelism_ भी प्रदान करता है जिससे आप इस मॉडल को नेटवर्क से जुड़े कई मशीनों पर चला सकते हैं। विस्तृत मार्गदर्शन के लिए, कृपया [vLLM निर्देश](https://docs.vllm.ai/en/latest/serving/distributed_serving.html) देखें। आप [enhancement plan](https://github.com/vllm-project/vllm/issues/11539) को भी फॉलो कर सकते हैं।

### 6.6 LightLLM के साथ अनुमान (अनुशंसित)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 DeepSeek-R1 (FP8/BF16) के लिए सिंगल-मशीन और मल्टी-मशीन टेन्सर पैरेलल तैनाती का समर्थन करता है और मिक्स्ड-प्रिसिजन तैनाती प्रदान करता है, साथ में अधिक क्वांटाइजेशन मोड लगातार एकीकृत किए जा रहे हैं। अधिक विवरण के लिए [LightLLM निर्देश](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html) देखें। साथ ही, LightLLM DeepSeek-V2 के लिए PD-disaggregation तैनाती प्रदान करता है, और DeepSeek-V3 के लिए PD-disaggregation विकासाधीन है।

### 6.7 AMD GPU के साथ अनुशंसित अनुमान कार्यक्षमता

AMD टीम के सहयोग से, हमने SGLang का उपयोग करते हुए AMD GPU के लिए Day-One समर्थन प्राप्त किया है, जिसमें FP8 और BF16 दोनों सटीकता के लिए पूरी संगतता है। विस्तृत मार्गदर्शन के लिए, कृपया [SGLang निर्देश](#63-inference-with-lmdeploy-recommended) देखें।

### 6.8 Huawei Ascend NPUs के साथ अनुशंसित अनुमान कार्यक्षमता
Huawei Ascend समुदाय के [MindIE](https://www.hiascend.com/en/software/mindie) फ्रेमवर्क ने DeepSeek-V3 के BF16 संस्करण को सफलतापूर्वक अनुकूलित किया है। Ascend NPUs पर चरण-दर-चरण मार्गदर्शन के लिए, कृपया [यहाँ दिए गए निर्देश](https://modelers.cn/models/MindIE/deepseekv3) का अनुसरण करें।

## 7. लाइसेंस
यह कोड रिपॉजिटरी [MIT लाइसेंस](LICENSE-CODE) के अंतर्गत लाइसेंस प्राप्त है। DeepSeek-V3 Base/Chat मॉडलों का उपयोग [मॉडल लाइसेंस](LICENSE-MODEL) के अधीन है। DeepSeek-V3 श्रृंखला (Base और Chat सहित) व्यावसायिक उपयोग का समर्थन करती है।

## 8. संदर्भ
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. संपर्क
यदि आपके कोई प्रश्न हैं, तो कृपया एक issue दर्ज करें या हमसे संपर्क करें: [service@deepseek.com](service@deepseek.com)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---