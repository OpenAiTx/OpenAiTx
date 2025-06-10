# أداة ترجمة لقطات الشاشة بالذكاء الاصطناعي (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# المقدمة

تقوم هذه الأداة من خلال **عملية التقاط الشاشة البسيطة**، بإرسال الصورة إلى نموذج ذكاء اصطناعي للتعرف على النص وترجمته، ثم عرض نتيجة الترجمة بتنسيق HTML تفاعلي في نافذة مستقلة.

تدعم هذه الأداة **تخصيص اختصارات لوحة المفاتيح للتشغيل، إدارة نتائج متعددة النوافذ، والتشغيل في شريط النظام**، مما يعزز كفاءة الترجمة في العمل والدراسة اليومية بشكل كبير.

**مميزات الأداة**: 1. ترجمة من لقطة الشاشة، تشغيل بالاختصار؛ 2. لصق لقطات الشاشة والترجمة، مع إمكانية السحب والتكبير والتصغير بحرية، ويمكن إنشاء عدة مجموعات من اللصقات المترجمة؛ 3. إمكانية تبديل الصيغ لعرض النص الأصلي لسهولة النسخ؛ 4. واجهة api مخصصة.

**المشكلات التي تهدف الأداة إلى حلها**: 1. التضخم في برامج الترجمة الشاملة للوثائق في السوق حالياً؛ 2. عند نسخ النصوص من ملفات PDF للصقها في الترجمة، غالبًا ما تكون الصيغ الرياضية غير مرتبة أو غير قابلة للنسخ؛ 3. بالنسبة لملفات PDF المصورة ضوئيًا، لا يمكن نسخ النص.

# العرض التوضيحي

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# عرض النوافذ

نافذة الترجمة:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

نافذة الإعدادات:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

للمزيد من الشرح حول خيارات الإعدادات، يمكن الاطلاع عليها داخل البرنامج أو على الويب عبر [التلميحات](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# التثبيت

يمكنك اختيار تحميل الشيفرة المصدرية لتشغيلها، أو التوجه إلى صفحة [الإصدارات](https://github.com/Diraw/AI-Screenshot-Translator/releases) لتحميل الملف التنفيذي.

### 1. استنساخ المستودع

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. إنشاء بيئة افتراضية وتشغيل البرنامج

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# خطة التحديث

- ~~إضافة نافذة gui لإعدادات api، وتحسين منطق الإعداد اليدوي لملف yaml ليقوم البرنامج بإنشائه تلقائيًا (تم في v0.3.0)~~
- إضافة نظام تخزين للصور والصيغ الرياضية لتسهيل الرجوع إليها لاحقًا (من المتوقع إنجازه في v0.4)
- (للمزيد من الميزات يرجى طرحها عبر issue أو المساهمة بـ PR)

# أخرى

- أيقونة البرنامج من [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- الشكر لـ Gemini 2.5 Flash و DeepSeek-V3-0324 لمساعدتهم في اكتشاف الأخطاء

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---