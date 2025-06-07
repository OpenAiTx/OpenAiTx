# کوبرنتیز (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

کوبرنتیز، که با نام K8s نیز شناخته می‌شود، یک سیستم متن‌باز برای مدیریت [برنامه‌های کانتینری‌شده] در چندین میزبان است. این سیستم مکانیزم‌های پایه‌ای برای استقرار، نگهداری و مقیاس‌پذیری برنامه‌ها فراهم می‌کند.

کوبرنتیز بر پایه بیش از یک دهه و نیم تجربه گوگل در اجرای بارهای کاری تولیدی در مقیاس بزرگ با استفاده از سیستمی به نام [Borg] ساخته شده است و همچنین ایده‌ها و بهترین رویه‌های اجتماع را در خود جای داده است.

کوبرنتیز توسط بنیاد محاسبات ابری بومی ([CNCF]) میزبانی می‌شود.
اگر شرکت شما می‌خواهد در شکل‌دهی به تکامل فناوری‌هایی که مبتنی بر کانتینر، زمان‌بندی پویا و معماری میکروسرویس هستند نقش داشته باشد، پیوستن به CNCF را مد نظر قرار دهید.
برای جزئیات درباره اعضا و نقش کوبرنتیز، [اطلاعیه] CNCF را مطالعه نمایید.

----

## برای شروع استفاده از K8s

مستندات ما را در [kubernetes.io] مشاهده کنید.

یک دوره رایگان درباره [میکروسرویس‌های مقیاس‌پذیر با کوبرنتیز] بگذرانید.

برای استفاده از کد کوبرنتیز به عنوان کتابخانه در برنامه‌های دیگر، به [فهرست اجزای منتشر شده](https://git.k8s.io/kubernetes/staging/README.md) مراجعه کنید.
استفاده از ماژول `k8s.io/kubernetes` یا بسته‌های `k8s.io/kubernetes/...` به عنوان کتابخانه پشتیبانی نمی‌شود.

## برای شروع توسعه K8s

[مخزن اجتماع] تمامی اطلاعات درباره ساخت کوبرنتیز از سورس، نحوه مشارکت در کد و مستندات، افراد مسئول و غیره را در خود جای داده است.

اگر می‌خواهید بلافاصله کوبرنتیز را بسازید، دو گزینه دارید:

##### شما یک [محیط Go] آماده دارید.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### شما یک [محیط Docker] آماده دارید.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

برای اطلاعات کامل‌تر، به [مستندات توسعه‌دهندگان] مراجعه کنید.

## پشتیبانی

اگر به پشتیبانی نیاز دارید، با [راهنمای رفع اشکال] شروع کنید و مراحل پیشنهادی را دنبال نمایید.

با این حال، اگر سوالی دارید، از طریق [راه‌های ارتباطی][communication] با ما در تماس باشید.

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## جلسات اجتماع

[تقویم](https://www.kubernetes.dev/resources/calendar/) فهرست تمامی جلسات اجتماع کوبرنتیز را در یک مکان ارائه می‌دهد.

## پذیرندگان

وب‌سایت [مطالعات موردی کاربران](https://kubernetes.io/case-studies/) نمونه‌های واقعی استفاده سازمان‌ها در صنایع مختلف که از کوبرنتیز استفاده یا به آن مهاجرت کرده‌اند را نشان می‌دهد.

## حاکمیت

پروژه کوبرنتیز توسط چارچوبی از اصول، ارزش‌ها، سیاست‌ها و فرآیندها اداره می‌شود تا جامعه و اعضای ما را به سوی اهداف مشترک هدایت کند.

[اجتماع کوبرنتیز](https://github.com/kubernetes/community/blob/master/governance.md) نقطه آغاز یادگیری درباره ساختاردهی خودمان است.

[مخزن Steering اجتماع کوبرنتیز](https://github.com/kubernetes/steering) توسط کمیته Steering کوبرنتیز که بر حاکمیت پروژه نظارت دارد، استفاده می‌شود.

## نقشه راه

[مخزن پیشرفت‌های کوبرنتیز](https://github.com/kubernetes/enhancements) اطلاعات مربوط به نسخه‌های کوبرنتیز و همچنین پیگیری ویژگی‌ها و عقب‌ماندگی‌ها را فراهم می‌کند.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---