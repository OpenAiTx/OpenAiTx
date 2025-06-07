# تدفق البرومبت (Prompt flow)

[![حزمة بايثون](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![بايثون](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - التنزيلات](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![امتداد VSC](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![المستندات](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![المشكلات](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![المناقشات](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![المساهمة](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![الترخيص: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> مرحباً بك للانضمام إلينا لجعل تدفق البرومبت أفضل من خلال
> المشاركة في [المناقشات](https://github.com/microsoft/promptflow/discussions)،
> فتح [المشكلات](https://github.com/microsoft/promptflow/issues/new/choose)،
> تقديم [طلبات السحب (PRs)](https://github.com/microsoft/promptflow/pulls).

**تدفق البرومبت** هو مجموعة أدوات تطوير صممت لتبسيط دورة تطوير تطبيقات الذكاء الاصطناعي المعتمدة على نماذج اللغة الكبيرة (LLM) من الفكرة، النمذجة الأولية، الاختبار، التقييم حتى النشر والمراقبة في بيئة الإنتاج. تجعل هندسة البرومبت أسهل بكثير وتمكنك من بناء تطبيقات LLM بجودة إنتاجية.

مع تدفق البرومبت، ستتمكن من:

- **إنشاء وتطوير التدفق بشكل تكراري**
    - إنشاء [تدفقات](https://microsoft.github.io/promptflow/concepts/concept-flows.html) قابلة للتنفيذ تربط بين LLMs، البرومبتات، كود بايثون وأدوات [أخرى](https://microsoft.github.io/promptflow/concepts/concept-tools.html) معًا.
    - تصحيح وتتبع تدفقاتك، خصوصًا [تتبع التفاعل مع LLMs](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) بسهولة.
- **تقييم جودة وأداء التدفق**
    - تقييم جودة وأداء تدفقك باستخدام مجموعات بيانات كبيرة.
    - دمج الاختبار والتقييم في نظام CI/CD الخاص بك لضمان جودة التدفق.
- **دورة تطوير مبسطة للإنتاج**
    - نشر تدفقك على منصة الخدمة التي تختارها أو دمجه بسهولة في قاعدة كود تطبيقك.
    - (اختياري لكن موصى به بشدة) التعاون مع فريقك باستخدام النسخة السحابية من [تدفق البرومبت في Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## التثبيت

لبدء العمل بسرعة، يمكنك استخدام بيئة تطوير مدمجة مسبقًا. **اضغط على الزر أدناه** لفتح المستودع في GitHub Codespaces، ثم تابع قراءة ملف readme!

[![فتح في GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

إذا كنت تريد البدء في بيئتك المحلية، قم أولاً بتثبيت الحزم:

تأكد من وجود بيئة بايثون، يوصى بـ `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## البدء السريع ⚡

**إنشاء روبوت دردشة باستخدام تدفق البرومبت**

نفذ الأمر لبدء تدفق برومبت من قالب دردشة، سينشئ مجلدًا باسم `my_chatbot` ويولد الملفات المطلوبة بداخله:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**إعداد اتصال لمفتاح واجهة برمجة التطبيقات (API key) الخاص بك**

لمفتاح OpenAI، أنشئ اتصالاً بتنفيذ الأمر التالي، باستخدام ملف `openai.yaml` الموجود في مجلد `my_chatbot`، والذي يخزن مفتاح OpenAI الخاص بك (يمكن تجاوز المفاتيح والاسم بواسطة --set لتجنب تعديل ملف yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

لمفتاح Azure OpenAI، أنشئ الاتصال بتنفيذ الأمر التالي، باستخدام ملف `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**الدردشة مع تدفقك**

في مجلد `my_chatbot` يوجد ملف `flow.dag.yaml` يوضح التدفق، بما في ذلك المدخلات/المخرجات، العقد، الاتصال، ونموذج LLM، إلخ.

> ملاحظة أنه في عقدة `chat`، نستخدم اتصالًا باسم `open_ai_connection` (محدد في حقل `connection`) ونموذج `gpt-35-turbo` (محدد في حقل `deployment_name`). حقل deployment_name مخصص لتحديد نموذج OpenAI أو مورد نشر Azure OpenAI.

تفاعل مع روبوت الدردشة الخاص بك بتنفيذ: (اضغط `Ctrl + C` لإنهاء الجلسة)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**القيمة الأساسية: ضمان "جودة عالية" من النمذجة الأولية إلى الإنتاج**

استكشف [**دليلنا التدريبي لمدة 15 دقيقة**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) الذي يرشدك خلال تحسين البرومبت ➡ الاختبار الدفعي ➡ التقييم، وكل ذلك مصمم لضمان جودة عالية وجاهزية للإنتاج.

الخطوة التالية! تابع مع قسم **الدليل التدريبي** 👇 لاستكشاف تدفق البرومبت بشكل أعمق.

## الدليل التدريبي 🏃‍♂️

تدفق البرومبت هو أداة مصممة لـ **بناء تطبيقات LLM عالية الجودة**، وتتبع عملية التطوير في تدفق البرومبت الخطوات التالية: تطوير التدفق، تحسين جودة التدفق، نشر التدفق في بيئة الإنتاج.

### تطوير تطبيقات LLM الخاصة بك

#### امتداد VS Code

نقدم أيضًا امتداد VS Code (مصمم تدفق) لتجربة تطوير تدفق تفاعلية بواجهة مستخدم.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

يمكنك تثبيته من <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">سوق Visual Studio</a>.

#### التعمق في تطوير التدفق

[البدء مع تدفق البرومبت](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): دليل خطوة بخطوة لتشغيل أول تدفق لك.

### التعلم من حالات الاستخدام

[دليل تدريبي: الدردشة مع PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): دليل من البداية إلى النهاية حول كيفية بناء تطبيق دردشة عالي الجودة باستخدام تدفق البرومبت، بما في ذلك تطوير التدفق والتقييم باستخدام المقاييس.
> يمكن العثور على المزيد من الأمثلة [هنا](https://microsoft.github.io/promptflow/tutorials/index.html#samples). نرحب بمساهمات حالات الاستخدام الجديدة!

### إعداد للمساهمين

إذا كنت مهتمًا بالمساهمة، يرجى البدء بدليل إعداد التطوير الخاص بنا: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

الخطوة التالية! تابع مع قسم **المساهمة** 👇 للمساهمة في تدفق البرومبت.

## المساهمة

يرحب هذا المشروع بالمساهمات والاقتراحات. معظم المساهمات تتطلب منك الموافقة على اتفاقية ترخيص المساهم (CLA) التي تعلن أنك تملك الحق في، وفعليًا تمنحنا، حقوق استخدام مساهمتك. لمزيد من التفاصيل، قم بزيارة https://cla.opensource.microsoft.com.

عند تقديم طلب سحب (pull request)، سيحدد بوت CLA تلقائيًا ما إذا كنت بحاجة إلى تقديم CLA وسيقوم بتزيين PR بشكل مناسب (مثل فحص الحالة، تعليق). فقط اتبع التعليمات التي يقدمها البوت. ستحتاج إلى القيام بذلك مرة واحدة فقط عبر جميع المستودعات التي تستخدم CLA الخاص بنا.

لقد اعتمد هذا المشروع [مدونة قواعد السلوك للبرمجيات مفتوحة المصدر من Microsoft](https://opensource.microsoft.com/codeofconduct/).
لمزيد من المعلومات، راجع [الأسئلة الشائعة حول مدونة قواعد السلوك](https://opensource.microsoft.com/codeofconduct/faq/) أو تواصل مع [opencode@microsoft.com](mailto:opencode@microsoft.com) لأي أسئلة أو تعليقات إضافية.

## العلامات التجارية

قد يحتوي هذا المشروع على علامات تجارية أو شعارات لمشاريع أو منتجات أو خدمات. يخضع الاستخدام المصرح به لعلامات Microsoft التجارية أو شعاراتها ويجب أن يتبع
[إرشادات العلامات التجارية والعلامة التجارية لمايكروسوفت](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
يجب ألا يسبب استخدام علامات Microsoft التجارية أو شعاراتها في إصدارات معدلة من هذا المشروع ارتباكًا أو يوحي برعاية Microsoft.
أي استخدام لعلامات تجارية أو شعارات لطرف ثالث يخضع لسياسات الطرف الثالث ذاته.

## مدونة قواعد السلوك

لقد اعتمد هذا المشروع
[مدونة قواعد السلوك للبرمجيات مفتوحة المصدر من Microsoft](https://opensource.microsoft.com/codeofconduct/).
لمزيد من المعلومات، راجع
[الأسئلة الشائعة حول مدونة قواعد السلوك](https://opensource.microsoft.com/codeofconduct/faq/)
أو تواصل مع [opencode@microsoft.com](mailto:opencode@microsoft.com)
لأي أسئلة أو تعليقات إضافية.

## جمع البيانات

قد يجمع البرنامج معلومات عنك وعن استخدامك للبرنامج ويرسلها إلى Microsoft إذا تم تكوينه لتمكين القياس عن بُعد.
قد تستخدم Microsoft هذه المعلومات لتقديم الخدمات وتحسين منتجاتها وخدماتها.
يمكنك تشغيل القياس عن بُعد كما هو موضح في المستودع.
هناك أيضًا بعض الميزات في البرنامج التي قد تمكنك أنت وMicrosoft من جمع بيانات من مستخدمي تطبيقاتك. إذا استخدمت هذه الميزات،
يجب عليك الامتثال للقوانين المعمول بها، بما في ذلك تقديم إشعارات مناسبة
لمستخدمي تطبيقاتك مع نسخة من
بيان الخصوصية الخاص بمايكروسوفت. بيان الخصوصية الخاص بنا موجود على
https://go.microsoft.com/fwlink/?LinkID=824704. يمكنك معرفة المزيد حول جمع البيانات
واستخدامها في وثائق المساعدة وبيان الخصوصية الخاص بنا. يعتبر استخدامك للبرنامج موافقة منك على هذه الممارسات.

### تكوين القياس عن بُعد (Telemetry)

يتم تشغيل جمع القياس عن بُعد بشكل افتراضي.

لإلغاء الاشتراك، يرجى تشغيل `pf config set telemetry.enabled=false` لإيقاف تشغيله.

## الترخيص

حقوق النشر (c) شركة مايكروسوفت. جميع الحقوق محفوظة.

مرخص بموجب ترخيص [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---