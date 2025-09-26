<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# تيرمينارا

[![اسأل ديب ويكي](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![دعم بايثون](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

لعبة محاكاة ذكاء اصطناعي تعتمد على الطرفية.


## كيفية الاستخدام

يمكنك تنزيل التطبيق التنفيذي من [أحدث إصدار](https://github.com/luyiourwong/Terminara/releases/latest).

يتضمن الملف المضغوط الكامل ملف التطبيق التنفيذي وملف إعدادات العالم الافتراضي. يمكنك فقط تنزيل ملف التطبيق التنفيذي إذا كنت تقوم بتحديث اللعبة إلى أحدث إصدار.

| نظام التشغيل | الإصدار                                              |
|--------------|------------------------------------------------------|
| ويندوز       | Windows 10، Windows 11                               |
| لينكس        | (GLIBC 2.35+) Ubuntu 22.04 LTS، Ubuntu 24.04 LTS     |
| ماك أو إس     | macOS 13، macOS 14، macOS 15، macOS 26               |

<details>
<summary><strong>تشغيل يدوي</strong></summary>

### التثبيت

1.  **استنساخ المستودع:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **إنشاء بيئة افتراضية:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    على نظام ويندوز، استخدم `.venv\Scripts\activate`

3.  **قم بتثبيت الاعتمادات:**
    ```bash
    pip install -e .
    ```

### بدء الطريقة 1: استخدام الأمر المثبت (موصى به)
بعد التثبيت، شغّل اللعبة باستخدام:
```bash
terminara
```

### بدء الطريقة 2: التنفيذ المباشر
طريقة متعددة المنصات
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
على نظام ويندوز، استخدم `terminara\main.py`

لمزيد من المعلومات، راجع [دليل المساهمة والتطوير](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## إعداد الذكاء الاصطناعي

بعد تشغيل التطبيق، تحتاج إلى ضبط إعدادات الذكاء الاصطناعي من القائمة الرئيسية.

![إعدادات الذكاء الاصطناعي](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

يجب عليك تعبئة الحقول التالية: (واجهة برمجة التطبيقات المتوافقة مع OpenAI)
- **المضيف**: عنوان واجهة برمجة التطبيقات. اتركه فارغًا لاستخدام نقطة نهاية OpenAI الافتراضية.
- **مفتاح API**: مفتاح API الخاص بك لخدمة الذكاء الاصطناعي.
- **النموذج**: النموذج الذي ترغب في استخدامه.

انقر على "تطبيق" لحفظ الإعدادات.

### أمثلة

#### 1. [OpenAI](https://platform.openai.com/) (افتراضي)
- **المضيف**: (اتركه فارغًا)
- **مفتاح API**: `YOUR_OPENAI_API_KEY`
- **النموذج**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **المضيف**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **مفتاح API**: `YOUR_GEMINI_API_KEY`
- **النموذج**: `gemini-2.0-flash`

## إعداد العالم

### تخزين الإعدادات
يتم تخزين إعدادات العالم في دليل `terminara/data/worlds`. (في الإصدار الكامل)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### إنشاء عالم جديد
هناك عالم نموذجي [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). يمكنك اتباع [المخطط](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) لإنشاء عالم جديد.

## الروابط

- [صفحات GitHub](https://luyiourwong.github.io/Terminara)
- [مستودع GitHub](https://github.com/luyiourwong/Terminara)
- [دليل المساهمة والتطوير](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## الترخيص

هذا المشروع مرخص بموجب [ترخيص MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---