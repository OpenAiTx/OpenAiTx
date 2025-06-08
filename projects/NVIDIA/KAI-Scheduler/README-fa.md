[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# زمان‌بند KAI
زمان‌بند KAI یک [زمان‌بند کوبرنتیز](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) قدرتمند، کارآمد و مقیاس‌پذیر است که تخصیص منابع GPU را برای بارهای کاری هوش مصنوعی و یادگیری ماشین بهینه می‌کند.

زمان‌بند KAI برای مدیریت خوشه‌های GPU در مقیاس بزرگ، شامل هزاران گره و حجم بالای بارهای کاری طراحی شده است و آن را برای محیط‌های وسیع و پرتقاضا ایده‌آل می‌سازد.
زمان‌بند KAI به مدیران خوشه‌های کوبرنتیز اجازه می‌دهد منابع GPU را به صورت پویا به بارهای کاری اختصاص دهند.

زمان‌بند KAI از کل چرخه عمر هوش مصنوعی پشتیبانی می‌کند، از کارهای کوچک و تعاملی که به حداقل منابع نیاز دارند تا آموزش و استنتاج‌های بزرگ، همه در یک خوشه واحد.
این اطمینان را می‌دهد که تخصیص منابع بهینه باقی بماند و در عین حال انصاف منابع بین مصرف‌کنندگان مختلف حفظ شود.
می‌تواند در کنار سایر زمان‌بندهای نصب شده روی خوشه اجرا شود.

## ویژگی‌های کلیدی
* [زمان‌بندی دسته‌ای](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): اطمینان حاصل کنید که همه پادهای یک گروه به طور همزمان یا اصلاً زمان‌بندی می‌شوند.
* زمان‌بندی چیدن در سطل و پراکنده‌سازی: بهینه‌سازی استفاده از گره با حداقل‌سازی پراکندگی (bin-packing) یا افزایش تاب‌آوری و تعادل بار (spread scheduling).
* [اولویت بار کاری](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): اولویت‌دهی مؤثر به بارهای کاری در صف‌ها.
* [صف‌های سلسله‌مراتبی](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): مدیریت بارهای کاری با سلسله‌مراتب صف دو سطحی برای کنترل سازمانی منعطف.
* [توزیع منابع](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): سفارشی‌سازی سهمیه‌ها، وزن‌های فراتر از سهمیه، محدودیت‌ها و اولویت‌ها به ازای هر صف.
* [سیاست‌های انصاف](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): تضمین توزیع عادلانه منابع با استفاده از انصاف منابع غالب (DRF) و بازیابی منابع بین صف‌ها.
* یکپارچه‌سازی بار کاری: تخصیص مجدد هوشمندانه بارهای کاری در حال اجرا برای کاهش پراکندگی و افزایش بهره‌وری خوشه.
* [بارهای کاری الاستیک](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): مقیاس‌پذیری پویا بارهای کاری در محدوده تعداد پاد حداقل و حداکثر تعریف شده.
* تخصیص منابع پویا (DRA): پشتیبانی از منابع سخت‌افزاری خاص فروشنده از طریق ResourceClaims کوبرنتیز (مانند GPUهای NVIDIA یا AMD).
* [اشتراک‌گذاری GPU](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): امکان اشتراک‌گذاری مؤثر یک یا چند GPU بین بارهای کاری متعدد، حداکثرسازی استفاده از منابع.
* پشتیبانی ابری و داخلی: کاملاً سازگار با زیرساخت‌های ابری پویا (از جمله auto-scalerهایی مانند Karpenter) و همچنین استقرارهای داخلی ایستا.

## پیش‌نیازها
قبل از نصب زمان‌بند KAI، اطمینان حاصل کنید که:

- یک خوشه کوبرنتیز در حال اجرا دارید
- [Helm](https://helm.sh/docs/intro/install) CLI نصب شده است
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) برای زمان‌بندی بارهای کاری که منابع GPU درخواست می‌کنند نصب شده باشد

## نصب
زمان‌بند KAI در فضای نام `kai-scheduler` نصب خواهد شد. هنگام ارسال بارهای کاری، مطمئن شوید که از یک فضای نام اختصاصی استفاده می‌کنید.

### روش‌های نصب
زمان‌بند KAI می‌تواند به صورت زیر نصب شود:

- **نسخه تولیدی (توصیه شده)**
- **از سورس (خودتان بسازید)**

#### نصب از نسخه تولیدی
آخرین نسخه منتشر شده را در صفحه [releases](https://github.com/NVIDIA/KAI-Scheduler/releases) بیابید.
پس از جایگزین کردن `<VERSION>` با نسخه مورد نظر، دستور زیر را اجرا کنید:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### ساخت از سورس
دستورالعمل‌ها را [اینجا](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md) دنبال کنید.

## شروع سریع
برای آغاز زمان‌بندی بارهای کاری با KAI Scheduler، به [مثال شروع سریع](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md) مراجعه کنید.

## نقشه راه

### مرور کلی اولویت‌های اصلی برای سال ۲۰۲۵
* بازنویسی پایگاه کد برای افزایش بی‌طرفی نسبت به فروشنده
* پشتیبانی از Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* تحقیق درباره ادغام احتمالی با Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* افزودن پشتیبانی از زمان‌بندی آگاه از توپولوژی برای pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* پشتیبانی از حداقل زمان اجرا به ازای هر بار کاری
* پشتیبانی از حداکثر زمان اجرا به ازای هر بار کاری (با صف‌بندی مجدد با تاخیر)
* افزودن PriorityClasses بیشتر به عنوان بخشی از نصب پیش‌فرض KAI
* پشتیبانی از JobSet
* پشتیبانی از LWS (LeaderWorkerSet)
* افزودن معیارها برای پیش‌دستی پاد و pod-group
* جداسازی اولویت و پیش‌دستی

### اهداف بلندمدت
* پشتیبانی از decay زمان به ازای هر صف
* بهبود مقیاس‌پذیری بسیار بالا
* پشتیبانی از یکپارچه‌سازی بارهای استنتاج برای رفع پراکندگی خوشه
* پشتیبانی از n سطح صف‌های سلسله‌مراتبی
* rollout تدریجی بارهای استنتاج (به‌روزرسانی نسخه جدید با استفاده از سهمیه موقت اضافی صف)

## جامعه، بحث و پشتیبانی

مایلیم از شما بشنویم! بهترین راه‌های ارتباط به شرح زیر است:

### اسلک
ابتدا به [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) بپیوندید و سپس به کانال [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) مراجعه کنید.

### تماس جامعه دو هفته یک‌بار  
**زمان:** دوشنبه‌های یک در میان ساعت ۱۷:۰۰ به وقت CEST  
[تبدیل به منطقه زمانی شما](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [افزودن به تقویم شما](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [یادداشت و دستور جلسه](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### لیست پستی  
به [لیست پستی kai-scheduler](https://groups.google.com/g/kai-scheduler) بپیوندید تا به‌روزرسانی جلسات دو هفته یک‌بار را دریافت کنید.

### مسائل فنی و درخواست ویژگی  
برای گزارش خطا، پیشنهاد ویژگی یا کمک فنی، لطفاً یک [issue گیت‌هاب](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) باز کنید. این به ما کمک می‌کند تا درخواست‌ها را پیگیری و به طور مؤثر پاسخ دهیم.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---