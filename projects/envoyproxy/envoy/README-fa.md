![لوگوی Envoy](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[پراکسی لبه/میانی/سرویس با عملکرد بالا و بومی ابری](https://www.envoyproxy.io/)

Envoy توسط [بنیاد محاسبات ابری بومی](https://cncf.io) (CNCF) میزبانی می‌شود. اگر شما یک
شرکت هستید که می‌خواهید در شکل‌دهی به تکامل فناوری‌هایی که در قالب کانتینر بسته‌بندی شده‌اند،
به صورت پویا زمان‌بندی می‌شوند و محور میکروسرویس‌ها هستند مشارکت داشته باشید، به پیوستن به CNCF فکر کنید. برای جزئیات درباره کسانی که
درگیر هستند و نقش Envoy، اعلان
[CNCF](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/) را بخوانید.

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## مستندات

* [مستندات رسمی](https://www.envoyproxy.io/)
* [سؤالات متداول (FAQ)](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [مستندات نمونه](https://github.com/envoyproxy/examples/)
* [وبلاگ](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) درباره مدل threading
* [وبلاگ](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) درباره راه‌اندازی مجدد داغ (hot restart)
* [وبلاگ](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) درباره معماری آمار
* [وبلاگ](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) درباره Universal Data Plane API
* [وبلاگ](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) درباره داشبوردهای Envoy در Lyft

## مرتبط

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): تعاریف API نسخه ۲ به عنوان یک مخزن مستقل. این یک آینه فقط خواندنی از [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/) است.
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): چارچوب تست عملکرد.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): نمونه‌ای برای افزودن فیلترهای جدید
  و پیوند به مخزن اصلی.

## تماس

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): لیست ایمیل کم‌تکرار که فقط اطلاعیه‌ها را ارسال می‌کنیم.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): لیست ایمیل کم‌تکرار که فقط اطلاعیه‌های امنیتی را ارسال می‌کنیم.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): بحث‌های کلی کاربران.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): بحث توسعه‌دهندگان Envoy (APIها،
  طراحی ویژگی و غیره).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): برای ارتباط با تمام نگهدارندگان اصلی Envoy از این لیست استفاده کنید.
* [توییتر](https://twitter.com/EnvoyProxy/): ما را در توییتر دنبال کنید!
* [Slack](https://envoyproxy.slack.com/): برای دریافت دعوت‌نامه به [اینجا](https://communityinviter.com/apps/envoyproxy/envoy) مراجعه کنید.
  * توجه: پاسخ به سؤالات کاربران در Slack به صورت بهترین تلاش است. برای دریافت پاسخ "تضمین‌شده" لطفاً طبق راهنمایی موضوع پیوند داده شده، به envoy-users@ ایمیل بزنید.

لطفاً برای اطلاعات بیشتر درباره استفاده از لیست‌های ایمیل، [این](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) موضوع ایمیل را ببینید.

## مشارکت

مشارکت در Envoy سرگرم‌کننده است و ++C مدرن خیلی ترسناک‌تر از آنچه فکر می‌کنید نیست، حتی اگر تجربه قبلی نداشته باشید. برای شروع:

* [راهنمای مشارکت](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [مسائل مناسب تازه‌کارها](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [آغاز سریع ساخت/تست با داکر](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [راهنمای توسعه‌دهندگان](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* نصب [زنجیره ابزار پشتیبانی توسعه Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md) را در نظر داشته باشید که به خودکارسازی بخشی از فرآیند توسعه، به ویژه آن‌هایی که مربوط به بازبینی کد هستند، کمک می‌کند.
* لطفاً مطمئن شوید که اگر روی یک issue کار می‌کنید، ما را مطلع کنید تا کار تکراری انجام نشود!

## جلسه جامعه

تیم Envoy دو بار در ماه، سه‌شنبه‌ها ساعت ۹ صبح به وقت PT جلسه زمان‌بندی‌شده دارد. تقویم عمومی گوگل [اینجا](https://goo.gl/PkDijT) است.  جلسه فقط در صورتی برگزار می‌شود
که موضوعاتی در [صورتجلسه جلسات](https://goo.gl/5Cergb) فهرست شده باشد. هر عضو جامعه می‌تواند
با افزودن به صورتجلسه، موضوعات را پیشنهاد دهد. نگهدارندگان یا اضافه شدن موضوعات به دستور جلسه را تأیید می‌کنند،
یا اگر دستور جلسه تأیید نشده باشد، جلسه را تا ۲۴ ساعت قبل از زمان برنامه‌ریزی‌شده لغو می‌کنند.

## امنیت

### ممیزی امنیتی

چندین ارزیابی شخص ثالث متمرکز بر امنیت Envoy انجام شده است:
* در سال ۲۰۱۸ Cure53 یک ممیزی امنیتی انجام داد، [گزارش کامل](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* در سال ۲۰۲۱ Ada Logics یک ممیزی روی زیرساخت fuzzing ما با پیشنهاداتی برای بهبود انجام داد، [گزارش کامل](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### گزارش آسیب‌پذیری‌های امنیتی

اگر یک آسیب‌پذیری یا آسیب‌پذیری بالقوه در Envoy پیدا کرده‌اید، لطفاً به ما در
[envoy-security](mailto:envoy-security@googlegroups.com) اطلاع دهید. ما یک ایمیل تأیید دریافت گزارش ارسال می‌کنیم و ایمیل دیگری زمانی که مشکل را به طور مثبت یا منفی شناسایی کردیم ارسال خواهد شد.

برای جزئیات بیشتر لطفاً فرآیند کامل [انتشار امنیتی](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md) ما را ببینید.

### بیلدهای ppc64le

بیلدهای معماری ppc64le یا استفاده از aws-lc تحت پوشش سیاست امنیتی Envoy نیستند. معماری ppc64le در حال حاضر فقط بر اساس بهترین تلاش پشتیبانی می‌شود و توسط نگهدارندگان Envoy نگهداری نمی‌شود.

## نسخه‌ها

برای اطلاعات بیشتر، لطفاً [فرآیند انتشار](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md) ما را ببینید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---