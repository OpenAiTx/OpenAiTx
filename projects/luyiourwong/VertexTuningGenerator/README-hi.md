
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![क्वालिटी गेट स्थिति](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![कवरेज](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# वर्टेक्स ट्यूनिंग जेनरेटर / संपादक

GCP VertexAI ट्यूनिंग डेटासेट जेनरेटर के लिए एक सिंगल पेज एप्लिकेशन।

## संदर्भ दस्तावेज़

[VertexAI Model tuning](https://console.cloud.google.com/vertex-ai/studio/tuning)

[VertexAI Model tuning documentation](https://cloud.google.com/vertex-ai/generative-ai/docs/models/tune-models)

[Fine tuning use cases](https://cloud.google.com/transform/top-five-gen-ai-tuning-use-cases-gemini-hundreds-of-orgs)

## Sample dataset (from [tuning document](https://cloud.google.com/vertex-ai/generative-ai/docs/models/tune_gemini/text_tune#sample-datasets))

[Gemini 2.0 training dataset](https://storage.googleapis.com/cloud-samples-data/ai-platform/generative_ai/gemini-2_0/text/sft_train_data.jsonl)

[Gemini 2.0 validation dataset](https://storage.googleapis.com/cloud-samples-data/ai-platform/generative_ai/gemini-2_0/text/sft_validation_data.jsonl)

## Use online

[![pages-build-deployment](https://github.com/luyiourwong/VertexTuningGenerator/actions/workflows/pages/pages-build-deployment/badge.svg?branch=gh-pages)](https://github.com/luyiourwong/VertexTuningGenerator/actions/workflows/pages/pages-build-deployment)

[Online Application on Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## Development

### Project Setup

```sh
npm install
```

### विकास के लिए संकलन और हॉट-रिलोड

```sh
npm run dev
```

### परीक्षण और कवरेज रिपोर्ट
रिपोर्ट `./coverage` पर, सोनार `./coverage/lcov.info` पर lcov का उपयोग करेगा।
```sh
npm run test:coverage
```

## योगदान

योगदान का स्वागत है!

कोड को डिप्लॉय प्रक्रिया के लिए गुणवत्ता मानकों को पास करना आवश्यक है।

<details>
<summary><strong>📋 कोड गुणवत्ता मानक</strong></summary>

सभी पुल अनुरोधों को मर्ज होने से पहले SonarQube में निम्नलिखित गुणवत्ता गेट्स पास करने होंगे:

- विश्वसनीयता रेटिंग: A
- सुरक्षा रेटिंग: A
- अनुरक्षणीयता रेटिंग: A
- न्यूनतम कवरेज आवश्यकता: 80%
- अधिकतम अनुमत डुप्लिकेट कोड: 3%

> नोट: आप विश्लेषण परिणामों की निगरानी PR चेक और [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator) पर कर सकते हैं।
</details>

## GitHub क्रियाएं

इस रिपॉजिटरी में कोड गुणवत्ता बनाए रखने और डिप्लॉयमेंट को स्वचालित करने के लिए GitHub क्रियाएं कॉन्फ़िगर की गई हैं:

1. **`main` पर पुल अनुरोध**:
    - स्वचालित रूप से SonarQube स्कैन, यूनिट टेस्ट और कोड कवरेज रिपोर्ट जनरेट होती है।
    - Gemini Code Assist बॉट स्कैन परिणामों के आधार पर स्वतः पुल अनुरोध की समीक्षा और टिप्पणी करता है।

2. **`main` पर पुश**:
    - स्वचालित रूप से SonarQube स्कैन, यूनिट टेस्ट और कोड कवरेज रिपोर्ट जनरेट होती है।
    - यदि गुणवत्ता गेट पास होता है, तो साइट **GitHub Pages** पर स्वतः डिप्लॉय हो जाती है।

## लिंक

- [GitHub रिपॉजिटरी](https://github.com/luyiourwong/VertexTuningGenerator)
- [Issue ट्रैकर](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## लाइसेंस

यह परियोजना [MIT लाइसेंस](LICENSE) के तहत लाइसेंस प्राप्त है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---