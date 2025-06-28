# کوبرنتیز به روش سخت

این آموزش شما را در راه‌اندازی کوبرنتیز به روش سخت راهنمایی می‌کند. این راهنما برای افرادی که به دنبال ابزاری کاملاً خودکار برای راه‌اندازی یک خوشه کوبرنتیز هستند، مناسب نیست. کوبرنتیز به روش سخت برای یادگیری بهینه شده است، به این معنا که مسیر طولانی‌تری طی می‌شود تا مطمئن شوید هر وظیفه مورد نیاز برای بوت‌استرپ یک خوشه کوبرنتیز را درک می‌کنید.

> نتایج این آموزش نباید به عنوان آماده برای محیط تولید در نظر گرفته شوند و ممکن است پشتیبانی محدودی از سوی جامعه دریافت کنند، اما اجازه ندهید این موضوع مانع یادگیری شما شود!

## حق نشر

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />این اثر تحت مجوز <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a> منتشر شده است.


## مخاطبان هدف

مخاطب هدف این آموزش کسی است که می‌خواهد اصول اولیه کوبرنتیز و نحوه ارتباط اجزای اصلی با یکدیگر را درک کند.

## جزئیات خوشه

کوبرنتیز به روش سخت شما را در بوت‌استرپ یک خوشه پایه کوبرنتیز با تمام اجزای کنترل پلین که روی یک نود اجرا می‌شوند و دو نود کاری راهنمایی می‌کند، که برای یادگیری مفاهیم اصلی کافی است.

نسخه اجزا:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## آزمایشگاه‌ها

این آموزش به چهار (۴) ماشین مجازی یا فیزیکی بر پایه ARM64 یا AMD64 که به یک شبکه متصل هستند نیاز دارد.

* [پیش‌نیازها](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [راه‌اندازی جامب‌باکس](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [تأمین منابع محاسباتی](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [تأمین مرجع صدور گواهینامه و تولید گواهینامه‌های TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [تولید فایل‌های پیکربندی کوبرنتیز برای احراز هویت](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [تولید پیکربندی رمزنگاری داده و کلید](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [بوت‌استرپ خوشه etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [بوت‌استرپ کنترل پلین کوبرنتیز](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [بوت‌استرپ نودهای کاری کوبرنتیز](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [پیکربندی kubectl برای دسترسی از راه دور](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [تأمین مسیرهای شبکه پاد](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [آزمایش دود](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [پاک‌سازی](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---