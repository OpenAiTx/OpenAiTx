
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

[![สถานะคุณภาพเกต](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)
[![ความครอบคลุม](https://sonarcloud.io/api/project_badges/measure?project=luyiourwong_VertexTuningGenerator&metric=coverage)](https://sonarcloud.io/summary/new_code?id=luyiourwong_VertexTuningGenerator)

# เครื่องมือสร้าง/แก้ไข Vertex Tuning

แอปพลิเคชันหน้าเดียวสำหรับสร้างชุดข้อมูลปรับจูน GCP VertexAI

## เอกสารอ้างอิง

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

### คอมไพล์และรีโหลดแบบทันทีสำหรับการพัฒนา

```sh
npm run dev
```

### รายงานการทดสอบและครอบคลุม
รายงานอยู่ที่ `./coverage` โดย sonar จะใช้ lcov ที่ `./coverage/lcov.info`.
```sh
npm run test:coverage
```

## การมีส่วนร่วม

ยินดีต้อนรับการมีส่วนร่วม!

โค้ดต้องผ่านมาตรฐานคุณภาพเพื่อดำเนินการ deploy

<details>
<summary><strong>📋 มาตรฐานคุณภาพโค้ด</strong></summary>

Pull request ทั้งหมดต้องผ่านเกณฑ์คุณภาพต่อไปนี้ใน SonarQube ก่อนที่จะ merge:

- ระดับความน่าเชื่อถือ: A
- ระดับความปลอดภัย: A
- ระดับการดูแลรักษา: A
- ข้อกำหนดความครอบคลุมขั้นต่ำ: 80%
- รหัสที่ซ้ำกันอนุญาตสูงสุด: 3%

> หมายเหตุ: คุณสามารถติดตามผลการวิเคราะห์ใน PR checks และที่ [SonarCloud](https://sonarcloud.io/project/pull_requests_list?id=luyiourwong_VertexTuningGenerator)
</details>

## GitHub Actions

คลังนี้ได้ตั้งค่า GitHub Actions เพื่อช่วยรักษาคุณภาพโค้ดและดำเนินการ deploy อัตโนมัติ:

1. **Pull Requests ไปยัง `main`**:
    - เรียกใช้การสแกน SonarQube, unit test และสร้างรายงานความครอบคลุมโค้ดโดยอัตโนมัติ
    - บอท Gemini Code Assist จะตรวจสอบและแสดงความคิดเห็นใน pull request ตามผลการสแกนโดยอัตโนมัติ

2. **การ push ไปยัง `main`**:
    - เรียกใช้การสแกน SonarQube, unit test และสร้างรายงานความครอบคลุมโค้ดโดยอัตโนมัติ
    - หากผ่านเกณฑ์คุณภาพ เว็บไซต์จะถูก deploy ไปยัง **GitHub Pages** โดยอัตโนมัติ

## ลิงก์

- [GitHub Repository](https://github.com/luyiourwong/VertexTuningGenerator)
- [Issue Tracker](https://github.com/luyiourwong/VertexTuningGenerator/issues)
- [CI/CD](https://github.com/luyiourwong/VertexTuningGenerator/actions)
- [Sonarcloud](https://sonarcloud.io/project/overview?id=luyiourwong_VertexTuningGenerator)
- [Github pages](https://luyiourwong.github.io/VertexTuningGenerator/)

## ใบอนุญาต

โครงการนี้ได้รับอนุญาตภายใต้ [ใบอนุญาต MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---