
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=VertexTuningGenerator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![وضعیت گیت کیفیت](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![پوشش](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# تولیدکننده / ویرایشگر تنظیم رأس (Vertex)

یک برنامه تک‌صفحه‌ای برای تولید مجموعه داده تنظیم VertexAI در GCP.

## مستندات مرجع

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

### کامپایل و بارگذاری مجدد داغ برای توسعه

```sh
npm run dev
```

### گزارش تست و پوشش‌دهی
گزارش در مسیر `./coverage`، سونار از فایل lcov در مسیر `./coverage/lcov.info` استفاده خواهد کرد.
```sh
npm run test:coverage
```

## مشارکت

مشارکت‌ها خوش‌آمد هستند!

کد باید استانداردهای کیفیت را برای فرآیند انتشار رعایت کند.

<details>
<summary><strong>📋 استانداردهای کیفیت کد</strong></summary>

تمام درخواست‌های pull باید قبل از ادغام، از دروازه‌های کیفیت زیر در SonarQube عبور کنند:

- رتبه‌بندی قابلیت اطمینان: A
- رتبه‌بندی امنیت: A
- رتبه‌بندی نگهداری: A
- حداقل پوشش مورد نیاز: ۸۰٪
- حداکثر کد تکراری مجاز: ۳٪

> توجه: می‌توانید نتایج تحلیل را در بررسی‌های PR و در [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator) مشاهده کنید.
</details>

## اکشن‌های گیت‌هاب

این مخزن اکشن‌های GitHub را برای کمک به حفظ کیفیت کد و خودکارسازی انتشارها پیکربندی کرده است:

1. **درخواست‌های Pull به `main`**:
    - به صورت خودکار اسکن SonarQube، تست واحد و تولید گزارش پوشش کد را اجرا می‌کند.
    - ربات Gemini Code Assist به صورت خودکار بر اساس نتایج اسکن، درخواست pull را بررسی و نظر می‌دهد.

2. **ارسال‌ها به `main`**:
    - به صورت خودکار اسکن SonarQube، تست واحد و تولید گزارش پوشش کد را اجرا می‌کند.
    - اگر دروازه کیفیت پذیرفته شود، سایت به صورت خودکار در **GitHub Pages** منتشر می‌شود.

## پیوندها

- [مخزن گیت‌هاب](https://github.com/luyiourwong/VertexTuningGenerator)
- [ردیاب مشکلات](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [سونارکلود](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [صفحات گیت‌هاب](https://luyiourwong.github.io/VertexTuningGenerator/)

## مجوز

این پروژه تحت [مجوز MIT](LICENSE) منتشر شده است.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---