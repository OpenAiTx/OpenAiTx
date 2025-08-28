
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# ভাৰ্টেক্স টিউনিং জেনাৰেটৰ / সম্পাদনা কাৰী

GCP VertexAI টিউনিং ডাটাছেট জেনাৰেটৰৰ বাবে এটি একক পৃষ্ঠা আবেদন।

## প্ৰসংগ গ্ৰন্থাৱলী

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

### উন্নয়নৰ বাবে সংকলন আৰু হট-ৰিল'ড

```sh
npm run dev
```

### পৰীক্ষা আৰু কভাৰেজ প্ৰতিবেদন
`./coverage`-ত প্ৰতিবেদন, sonar-এ `./coverage/lcov.info`-ৰ lcov ব্যৱহাৰ কৰিব।
```sh
npm run test:coverage
```
## অৱদান

অৱদান স্বাগতম!

কোডে মানদণ্ড পাৰ হৈ ডিপ্লয় প্ৰক্ৰিয়া কৰিব লাগিব।

<details>
<summary><strong>📋 কোড মানদণ্ড</strong></summary>

সকল পুল অনুৰোধ SonarQube-ত তলত উল্লেখ কৰা মানদণ্ড পাৰ হ’ব লাগিব:

- Reliability Rating: A
- Security Rating: A
- Maintainability Rating: A
- Minimum coverage requirement: 80%
- Maximum allowed duplicated code: 3%

> টোকা: আপুনি PR checks আৰু [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)-ত বিশ্লেষণ ফলাফল মনিটৰ কৰিব পাৰে।
</details>

## GitHub Actions

এই ৰিপ’জিটৰিত GitHub Actions সংৰূপিত আছে যি কোড মানদণ্ড বজাই ৰাখিবলৈ আৰু স্বয়ংক্ৰিয়ভাৱে ডিপ্লয় কৰিবলৈ সহায় কৰে:

1. **`main`-লৈ Pull Requests**:
    - স্বয়ংক্ৰিয়ভাৱে SonarQube স্কেন, unit test আৰু code coverage report সৃষ্টি কৰে।
    - Gemini Code Assist bot-এ স্কেন ফলাফলৰ আধাৰত স্বয়ংক্ৰিয়ভাৱে pull request-ত পৰ্যালোচনা আৰু মন্তব্য কৰে।

2. **`main`-লৈ Pushes**:
    - স্বয়ংক্ৰিয়ভাৱে SonarQube স্কেন, unit test আৰু code coverage report সৃষ্টি কৰে।
    - যদি মানদণ্ড পাৰ হয়, তেন্তে site-টো **GitHub Pages**-ত স্বয়ংক্ৰিয়ভাৱে ডিপ্লয় হয়।

## লিংকসমূহ

- [GitHub Repository](https://github.com/luyiourwong/VertexTuningGenerator)
- [Issue Tracker](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)


## লাইচেঞ্চ

এই প্ৰকল্পটো [MIT License](LICENSE) অধীনত লাইচেঞ্চ কৰা হৈছে।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---