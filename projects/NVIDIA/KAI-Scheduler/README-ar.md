[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# مجدول KAI
مجدول KAI هو [مجدول Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) قوي وفعال وقابل للتوسع يعمل على تحسين تخصيص موارد GPU لأعباء عمل الذكاء الاصطناعي وتعلم الآلة.

تم تصميمه لإدارة مجموعات GPU واسعة النطاق، تشمل آلاف العقد، وذات معدلات نقل عالية من أعباء العمل، مما يجعل مجدول KAI مثالياً للبيئات الواسعة والمتطلبة.
يسمح مجدول KAI لمسؤولي مجموعات Kubernetes بتخصيص موارد GPU ديناميكياً لأعباء العمل.

يدعم مجدول KAI دورة حياة الذكاء الاصطناعي بالكامل، من الوظائف التفاعلية الصغيرة التي تتطلب موارد محدودة إلى التدريب الكبير والاستدلال، وكل ذلك ضمن نفس المجموعة.
يضمن تخصيص الموارد الأمثل مع الحفاظ على العدالة في توزيع الموارد بين المستهلكين المختلفين.
يمكنه العمل جنباً إلى جنب مع مجدولات أخرى مثبتة على المجموعة.

## الميزات الرئيسية
* [جدولة الدُفعات](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): التأكد من جدولة جميع الحاويات في مجموعة واحدة في نفس الوقت أو عدم جدولة أي منها.
* تجميع الصناديق & جدولة التوزيع: تحسين استخدام العقد إما عن طريق تقليل التجزئة (تجميع الصناديق) أو زيادة المرونة وموازنة الحمل (جدولة التوزيع).
* [أولوية أعباء العمل](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): إعطاء الأولوية لأعباء العمل بفعالية ضمن قوائم الانتظار.
* [قوائم الانتظار الهرمية](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): إدارة أعباء العمل عبر هرمية من مستويين لقوائم الانتظار للتحكم التنظيمي المرن.
* [توزيع الموارد](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): تخصيص الحصص والأوزان والحدود والأولويات لكل قائمة انتظار.
* [سياسات العدالة](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): ضمان التوزيع العادل للموارد باستخدام عدالة الموارد المهيمنة (DRF) واستعادة الموارد عبر قوائم الانتظار.
* دمج أعباء العمل: إعادة تخصيص أعباء العمل الجارية بذكاء لتقليل التجزئة وزيادة الاستفادة من المجموعة.
* [أعباء العمل المرنة](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): توسيع نطاق أعباء العمل ديناميكياً ضمن عدد الحاويات الأدنى والأقصى المحدد.
* تخصيص الموارد الديناميكي (DRA): دعم موارد الأجهزة الخاصة بالموردين من خلال مطالبات الموارد في Kubernetes (مثل وحدات GPU من NVIDIA أو AMD).
* [مشاركة GPU](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): السماح لعدة أعباء عمل بمشاركة وحدة أو عدة وحدات GPU بكفاءة، مما يزيد من الاستفادة من الموارد.
* دعم السحابة والمحلي: متوافق بالكامل مع البنى التحتية السحابية الديناميكية (بما في ذلك أدوات التوسع التلقائي مثل Karpenter) وكذلك النشر المحلي الثابت.

## المتطلبات المسبقة
قبل تثبيت مجدول KAI، تأكد من توفر ما يلي:

- مجموعة Kubernetes تعمل
- تثبيت واجهة [Helm](https://helm.sh/docs/intro/install)
- تثبيت [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) من أجل جدولة أعباء العمل التي تطلب موارد GPU

## التثبيت
سيتم تثبيت مجدول KAI في مساحة الأسماء `kai-scheduler`. عند إرسال أعباء العمل تأكد من استخدام مساحة أسماء مخصصة.

### طرق التثبيت
يمكن تثبيت مجدول KAI عبر:

- **من الإنتاج (موصى به)**
- **من المصدر (قم ببنائه بنفسك)**

#### التثبيت من الإنتاج
حدد أحدث إصدار في صفحة [الإصدارات](https://github.com/NVIDIA/KAI-Scheduler/releases).
نفذ الأمر التالي بعد استبدال `<VERSION>` برقم الإصدار المطلوب:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### البناء من المصدر
اتبع التعليمات [هنا](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)

## البدء السريع
لبدء جدولة أعباء العمل باستخدام مجدول KAI، يرجى المتابعة إلى [مثال البدء السريع](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)

## خارطة الطريق

### نظرة عامة على الأولويات الرئيسية لعام 2025
* إعادة هيكلة قاعدة الشيفرة لتعزيز حيادية الموردين
* دعم بوابات الجدولة https://github.com/NVIDIA/KAI-Scheduler/issues/63
* البحث في إمكانية التكامل مع Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* إضافة دعم جدولة الوعي بالطوبولوجيا لمجموعة الحاويات https://github.com/NVIDIA/KAI-Scheduler/issues/66
* دعم الحد الأدنى لمدة التشغيل لكل عبء عمل
* دعم الحد الأقصى لمدة التشغيل لكل عبء عمل (مع إعادة جدولة مؤجلة)
* إضافة المزيد من فئات الأولوية كجزء من التثبيت الافتراضي لـ KAI
* دعم JobSet
* دعم LWS (LeaderWorkerSet)
* إضافة مقاييس لإزاحات الحاويات ومجموعات الحاويات
* فصل الأولوية عن الإزاحة

### الأهداف طويلة الأمد
* دعم تناقص الوقت لكل قائمة انتظار
* تحسينات فائقة النطاق
* دعم دمج أعباء عمل الاستدلال لتقليل تجزئة المجموعة
* دعم مستويات متعددة من قوائم الانتظار الهرمية
* طرح تدريجي لأعباء عمل الاستدلال (تحديث المراجعة الجديدة باستخدام تجاوز الحصة المؤقتة للقائمة)

## المجتمع، النقاش والدعم

نود أن نسمع منك! فيما يلي أفضل الطرق للتواصل:

### سلاك
انضم أولاً إلى [سلاك CNCF](https://communityinviter.com/apps/cloud-native/cncf) وزر قناة [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### اجتماع المجتمع نصف الشهري  
**الموعد:** كل يوم اثنين آخر الساعة 17:00 بتوقيت وسط أوروبا الصيفي  
[تحويل إلى منطقتك الزمنية](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [أضف إلى التقويم](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [ملاحظات الاجتماع وجدول الأعمال](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### القائمة البريدية  
انضم إلى [القائمة البريدية لـ kai-scheduler](https://groups.google.com/g/kai-scheduler) لتلقي التحديثات حول الاجتماعات نصف الشهرية.

### المشاكل التقنية وطلبات الميزات  
يرجى فتح [مشكلة على GitHub](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) للإبلاغ عن الأخطاء، أو اقتراح الميزات، أو طلب المساعدة التقنية. هذا يساعدنا في تتبع الطلبات والاستجابة بفعالية.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---