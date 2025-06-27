# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

يحتوي هذا المستودع على أداة سطر الأوامر Gemini CLI، وهي أداة سير عمل ذكاء اصطناعي عبر سطر الأوامر تتصل بأدواتك، وتفهم الكود الخاص بك، وتسرّع من سير العمل لديك.

مع أداة Gemini CLI يمكنك:

- الاستعلام وتحرير قواعد الشيفرة الكبيرة داخل وخارج نافذة سياق Gemini التي تبلغ مليون رمز.
- إنشاء تطبيقات جديدة من ملفات PDF أو الرسومات التخطيطية، باستخدام إمكانيات Gemini متعددة الوسائط.
- أتمتة المهام التشغيلية، مثل الاستعلام عن طلبات السحب أو معالجة عمليات إعادة الدمج المعقدة.
- استخدام الأدوات وخوادم MCP لربط إمكانيات جديدة، بما في ذلك [توليد الوسائط باستخدام Imagen،
  Veo أو Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- ربط استفساراتك بأداة [بحث Google](https://ai.google.dev/gemini-api/docs/grounding)
  المدمجة في Gemini.

## البدء السريع

1. **المتطلبات الأساسية:** تأكد من تثبيت [Node.js الإصدار 18](https://nodejs.org/en/download) أو أحدث.
2. **تشغيل الأداة:** نفّذ الأمر التالي في الطرفية لديك:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   أو قم بتثبيتها عبر:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **اختر سمة لونية**
4. **المصادقة:** عند الطلب، قم بتسجيل الدخول باستخدام حسابك الشخصي في Google. سيمنحك ذلك ما يصل إلى 60 طلب نموذج في الدقيقة و1000 طلب نموذج يوميًا باستخدام Gemini.

أنت الآن جاهز لاستخدام أداة Gemini CLI!

### للاستخدام المتقدم أو زيادة الحدود:

إذا كنت بحاجة إلى استخدام نموذج معين أو تحتاج إلى سعة طلبات أعلى، يمكنك استخدام مفتاح API:

1. أنشئ مفتاحًا من [Google AI Studio](https://aistudio.google.com/apikey).
2. عيّنه كمتغير بيئة في الطرفية لديك. استبدل `YOUR_API_KEY` بالمفتاح الذي تم إنشاؤه.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

لطرق المصادقة الأخرى، بما في ذلك حسابات Google Workspace، راجع دليل [المصادقة](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## أمثلة

بمجرد تشغيل الأداة، يمكنك البدء بالتفاعل مع Gemini من خلال الطرفية.

يمكنك بدء مشروع من دليل جديد:

```sh
cd new-project/
gemini
> اكتب لي بوت Discord لـ Gemini يجيب على الأسئلة باستخدام ملف FAQ.md الذي سأقدمه
```

أو العمل على مشروع قائم:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> أعطني ملخصًا لجميع التغييرات التي تم تنفيذها بالأمس
```

### الخطوات التالية

- تعلّم كيفية [المساهمة أو البناء من المصدر](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- استكشف **[أوامر سطر الأوامر المتاحة](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- إذا واجهت أي مشاكل، راجع **[دليل استكشاف الأخطاء وإصلاحها](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- لمزيد من الوثائق الشاملة، راجع [الوثائق الكاملة](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- ألق نظرة على بعض [المهام الشائعة](#popular-tasks) لمزيد من الإلهام.

### استكشاف الأخطاء وإصلاحها

انتقل إلى دليل [استكشاف الأخطاء وإصلاحها](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) إذا واجهت مشاكل.

## المهام الشائعة

### استكشاف قاعدة شيفرة جديدة

ابدأ بتنفيذ `cd` إلى مستودع موجود أو تم استنساخه حديثًا ثم تشغيل `gemini`.

```text
> صِف الأجزاء الرئيسية من بنية هذا النظام.
```

```text
> ما هي آليات الأمان المتوفرة؟
```

### العمل مع الشيفرة الحالية لديك

```text
> نفذ المسودة الأولى لقضية GitHub رقم 123.
```

```text
> ساعدني في ترحيل قاعدة الشيفرة هذه إلى أحدث إصدار من Java. ابدأ بخطة.
```

### أتمتة سير العمل

استخدم خوادم MCP لدمج أدوات النظام المحلي لديك مع مجموعة التعاون المؤسسي.

```text
> أنشئ لي عرض شرائح يظهر تاريخ git لآخر 7 أيام، مجمعًا حسب الميزة وعضو الفريق.
```

```text
> أنشئ تطبيق ويب بملء الشاشة لعرض أكثر قضايا GitHub تفاعلاً لدينا على شاشة الجدار.
```

### التفاعل مع النظام الخاص بك

```text
> حوّل جميع الصور في هذا الدليل إلى png، وأعد تسميتها باستخدام التواريخ من بيانات exif.
```

```text
> نظم فواتير PDF الخاصة بي حسب شهر الإنفاق.
```

## شروط الخدمة وإشعار الخصوصية

لمزيد من التفاصيل حول شروط الخدمة وإشعار الخصوصية المطبقة على استخدامك لأداة Gemini CLI، راجع [شروط الخدمة وإشعار الخصوصية](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---