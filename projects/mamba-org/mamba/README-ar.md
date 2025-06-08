# مامبا: مدير الحزم السريع متعدد المنصات

![صورة رأسية لمامبا](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">جزء من mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">مدير الحزم <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">خادم الحزم <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## مامبا

[![حالة البناء](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![انضم إلى الدردشة على Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![الوثائق](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` هو إعادة تنفيذ لمدير الحزم conda بلغة C++.

- تنزيل البيانات وملفات الحزم من المستودع بشكل متوازي باستخدام تعدد المسارات (multi-threading)
- استخدام libsolv لحل أسرع بكثير لاعتماديات الحزم، وهي مكتبة متطورة تُستخدم في مدير الحزم RPM في ريدهات وفيدورا وOpenSUSE
- الأجزاء الأساسية من `mamba` مكتوبة بلغة C++ لتحقيق أقصى كفاءة

في الوقت نفسه، يستخدم `mamba` نفس محلل سطر الأوامر، ورمز تثبيت وإزالة الحزم، وروتينات التحقق من العمليات مثل `conda` للحفاظ على التوافق قدر الإمكان.

`mamba` هو جزء من نظام [conda-forge](https://conda-forge.org/)، والذي يتضمن أيضًا `quetz`، وهو خادم حزم conda مفتوح المصدر.

يمكنك قراءة [منشورنا الإعلاني](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## ميكرومامبا

`micromamba` هو الإصدار المترابط إحصائياً من `mamba`.

يمكن تثبيته كملف تنفيذي مستقل بدون أي تبعيات، مما يجعله مناسبًا تمامًا لبيئات CI/CD والحاويات.

راجع [الوثائق حول `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) لمزيد من التفاصيل.

## `mamba` مقابل `micromamba`

يفضل استخدام `mamba` عندما:

- يتم استخدام `libmambapy` أو `libmamba` بواسطة برامج أخرى في نفس البيئة.
- السيناريوهات التي تتطلب تحديثات منتظمة للمكتبات (خصوصًا لأسباب أمنية).
- البيئات التي تركز على تقليل استخدام مساحة القرص للتبعيات.

يفضل استخدام `micromamba` عندما:

- الحاجة للاعتماد على ملف تنفيذي واحد مستقل.
- عدم وجود توزيع miniforge.
- الحاجة إلى استخدام بوقت تشغيل محدود للغاية.

## التثبيت

يرجى الرجوع إلى دليل التثبيت الخاص بـ [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
و[micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) في الوثائق.

## ميزات إضافية في مامبا وميكرومامبا

يأتي `mamba` و`micromamba` مع ميزات إضافية فوق `conda` الافتراضي.

### `repoquery`

لاستعلام المستودعات بكفاءة واستعلام تبعيات الحزم يمكنك استخدام `mamba repoquery` أو `micromamba repoquery`.

راجع [وثائق repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) لمزيد من التفاصيل.

### تثبيت ملفات القفل

يمكن استخدام `micromamba` لتثبيت ملفات القفل التي يتم إنشاؤها بواسطة [conda-lock](https://conda.github.io/conda-lock/) دون الحاجة لتثبيت `conda-lock`.

ببساطة قم بتنفيذ `micromamba create` مع الخيار `-f`، وقدم ملف قفل البيئة الذي ينتهي اسمه بـ
`-lock.yml` أو `-lock.yaml`؛ على سبيل المثال:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (بديل setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) هو بديل لـ [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) ويستخدم `micromamba`.

يمكنه تقليل وقت إعداد CI بشكل كبير من خلال:

- استخدام `micromamba` الذي يستغرق حوالي ثانية واحدة للتثبيت.
- تخزين تحميلات الحزم مؤقتًا.
- تخزين بيئات conda بالكامل مؤقتًا.

## الاختلافات مع `conda`

بينما يشكل `mamba` و`micromamba` بديلًا مباشرًا لـ `conda` بشكل عام، هناك بعض الاختلافات:

- لا يدعم `mamba` و`micromamba` المراجعات (للمناقشة، انظر <https://github.com/mamba-org/mamba/issues/803>)
- يقوم `mamba` و`micromamba` بتطبيع سلاسل `MatchSpec` إلى أبسط شكل، في حين أن `conda` يستخدم شكلاً أكثر تفصيلاً
  قد يؤدي هذا إلى اختلافات طفيفة في مخرجات `conda env export` و`mamba env export`.

## التثبيت للتطوير

يرجى الرجوع إلى التعليمات المقدمة في [الوثائق الرسمية](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## استقرار API و ABI

يستخدم مشروع مامبا [إصدار الترقيم الدلالي](https://semver.org/) بالشكل `MAJOR.MINOR.PATCH`.
بينما نحاول الحفاظ على الاستقرار للمستخدمين، نحتاج أحيانًا لإجراء تغييرات جذرية لتحسين مامبا وتقليل الديون التقنية.
قد تقدم الإصدارات المستقبلية من مامبا ضمانات أقوى.

### `libmamba` (C++)

لسنا على علم بمستهلكي واجهة برمجة التطبيقات (API) لـ C++، لذلك نمنح أنفسنا مجالًا للتحسينات.
بالنسبة لـ `libmamba`، يُفهم مصطلح _متوافق مع الإصدارات السابقة_ كما يلي:

- _متوافق ABI مع الإصدارات السابقة_ يعني أنه يمكنك استبدال ملفات المكتبة الثنائية دون إعادة تجميع رمزك مع رؤوس التحديث.
  سيكون السلوك الملحوظ هو نفسه، باستثناء الأخطاء (المختفية، نأمل) والأداء.
- _متوافق API مع الإصدارات السابقة_ يعني أنه يجب عليك إعادة تجميع رمزك مع إصدار المكتبة الجديد، لكنك لن تحتاج إلى تغيير رمزك، فقط إعادة بنائه.
  ينطبق هذا طالما أنك لم تستخدم أي إعلان يُفهم على أنه خاص، على سبيل المثال في المساحات الفرعية `detail`.
  سيكون السلوك الملحوظ هو نفسه، باستثناء الأخطاء (المختفية، نأمل) والأداء.
  عندما يتم إهمال الإعلانات ولكن لم تُحذف ولا تزال تعمل، نعتبر ذلك أيضًا متوافقًا مع الإصدارات السابقة، حيث أن التغيير الوحيد الملحوظ يكون أثناء الترجمة.

مع وضع ذلك في الاعتبار، يوفر `libmamba` الضمانات التالية:

- إصدارات `PATCH` متوافقة مع API وABI مع الإصدارات السابقة؛
- إصدارات `MINOR` متوافقة مع API للإعلانات في `mamba/api`,
  يمكن أن تكسر API في أماكن أخرى و ABI في أي مكان؛
- إصدارات `MAJOR` لا تقدم أي ضمانات.

### `libmambapy` (بايثون)

بالنسبة لـ `libmambapy`، يعني مصطلح _متوافق API مع الإصدارات السابقة_ أن كود بايثون الخاص بك سيعمل بنفس الشكل مع إصدار أحدث من `libmambapy` طالما أنك لم تستخدم أي إعلان يُفهم على أنه خاص، على سبيل المثال الأسماء التي تبدأ بـ `_`.
سيكون السلوك الملحوظ هو نفسه، باستثناء الأخطاء (المختفية، نأمل) والأداء.
عندما يتم إهمال الإعلانات ولكن لم تُحذف ولا تزال تعمل، نعتبر ذلك أيضًا متوافقًا مع الإصدارات السابقة، حيث أن السلوك يكون ملحوظًا فقط عند تفعيل تحذير الإهمال في بايثون، والذي عادة ما يكون مفعلاً فقط أثناء التطوير.

مع وضع ذلك في الاعتبار، يوفر `libmambapy` الضمانات التالية:

- إصدارات `PATCH` متوافقة مع API مع الإصدارات السابقة؛
- إصدارات `MINOR` متوافقة مع API مع الإصدارات السابقة؛
- إصدارات `MAJOR` لا تقدم أي ضمانات.

### `mamba` و`micromamba` (الملفات التنفيذية)

بالنسبة للملفات التنفيذية، يُطبق مصطلح _متوافق مع الإصدارات السابقة_ على المدخلات والمخرجات القابلة للبرمجة ويعني أن الكود الخاص بك (بما في ذلك سكريبتات الشل) سيعمل مع الإصدارات الأحدث من الملف التنفيذي بدون تعديلات.
تشمل المدخلات/المخرجات القابلة للبرمجة اسم الملف التنفيذي، معلمات سطر الأوامر، ملفات الإعدادات، متغيرات البيئة، مخرجات سطر الأوامر بتنسيق JSON، والملفات التي يتم إنشاؤها.
يُستثنى من ذلك المخرجات والرسائل الموجهة للبشر، وبالتالي تحذيرات الإهمال المكتوبة في المخرجات الموجهة للبشر.

مع وضع ذلك في الاعتبار، يقدم `mamba` و`micromamba` الضمانات التالية:

- إصدارات `PATCH` متوافقة مع الإصدارات السابقة؛
- إصدارات `MINOR` متوافقة مع الإصدارات السابقة؛
- إصدارات `MAJOR` لا تقدم أي ضمانات.

## ادعمنا

فقط إصدارات `mamba` و`micromamba` 2.0 وما بعدها مدعومة وتخضع للتطوير النشط.

فرع `1.x` يُصان فقط لمعالجة مشكلات الأمان مثل CVEs.

للاستفسارات، يمكنك أيضًا الانضمام إلينا على [دردشة QuantStack](https://gitter.im/QuantStack/Lobby)
أو على [قناة Conda](https://gitter.im/conda/conda) (يرجى ملاحظة أن هذا المشروع غير مرتبط رسميًا بـ `conda` أو Anaconda Inc.).

## الترخيص

نستخدم نموذج حقوق نشر مشترك يتيح لجميع المساهمين الاحتفاظ بحقوق النشر في مساهماتهم.

يخضع هذا البرنامج لترخيص BSD-3-Clause. راجع ملف [LICENSE](LICENSE) لمزيد من التفاصيل.

---

### اجتماع المطورين نصف الشهري

لدينا اجتماعات بالفيديو كل أسبوعين حيث نناقش ما نعمل عليه ونتبادل الآراء.

الجميع مرحب بهم للحضور، إذا رغبوا بمناقشة موضوع ما أو الاستماع فقط.

- متى: الثلاثاء [4:00 مساءً بتوقيت وسط أوروبا (أوروبا)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- أين: [Mamba jitsi](https://meet.jit.si/mamba-org)
- ماذا: [ملاحظات الاجتماع](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---