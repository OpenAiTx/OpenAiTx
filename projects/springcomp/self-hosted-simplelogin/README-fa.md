<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">آسامی</a></
      </div>
    </div>
  </details>
</div>

# سیمپل‌لاگین

این یک پیکربندی docker-compose خود-میزبان برای [SimpleLogin](https://simplelogin.io) است.

## پیش‌نیازها

- یک سرور لینوکس (یا ماشین مجازی یا سرور اختصاصی). این مستند راه‌اندازی برای Ubuntu 18.04 LTS را نشان می‌دهد اما مراحل می‌تواند برای سایر توزیع‌های محبوب لینوکس سازگار شود. از آن‌جا که بیشتر اجزا به عنوان کانتینر داکر اجرا می‌شوند و داکر می‌تواند کمی سنگین باشد، داشتن حداقل ۲ گیگابایت رم توصیه می‌شود. سرور باید پورت‌های ۲۵ (ایمیل)، ۸۰، ۴۴۳ (برای وب‌اپلیکیشن) و ۲۲ (برای ssh) را باز داشته باشد.


- یک دامنه که بتوانید تنظیمات DNS آن را انجام دهید. این دامنه می‌تواند یک زیر دامنه باشد. در ادامه این مستند، فرض کنیم دامنه‌ی شما برای ایمیل `mydomain.com` و برای وب‌اپلیکیشن SimpleLogin مقدار `app.mydomain.com` است. لطفاً مطمئن شوید که هر جا این مقادیر در مستند ظاهر شدند، آن‌ها را با دامنه و زیر دامنه‌ی خود جایگزین کنید. یک ترفند این است که این فایل README را در کامپیوتر خود دانلود کرده و همه‌ی موارد `mydomain.com` و `app.mydomain.com` را با دامنه خود جایگزین کنید.

به جز تنظیمات DNS که معمولاً در پنل رجیسترار دامنه شما انجام می‌شود، سایر مراحل زیر باید روی سرور شما انجام شوند. دستورات باید با شل `bash` (یا هر شل سازگار با bash مانند `zsh`) اجرا شوند. اگر از شل‌های دیگری مانند `fish` استفاده می‌کنید، لطفاً دستورات را مطابق آن تغییر دهید.

- برخی بسته‌های کاربردی که برای بررسی تنظیمات استفاده می‌شوند. آن‌ها را به این صورت نصب کنید:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## پیکربندی DNS

_برای جزئیات بیشتر به [مستندات مرجع](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) مراجعه کنید_

> **لطفاً توجه کنید** که اعمال تغییرات DNS ممکن است تا ۲۴ ساعت طول بکشد تا در سراسر اینترنت پخش شود. البته در عمل این زمان معمولاً بسیار کمتر است (در آزمایش ما حدود ۱ دقیقه). در پیکربندی DNS، معمولاً دامنه را با یک نقطه (`.`) در انتها وارد می‌کنیم تا استفاده از دامنه مطلق اجباری شود.

شما باید رکوردهای DNS زیر را تنظیم کنید:

- **A**: دامنه شما را به آدرس IPv4 سرور شما متصل می‌کند.
- **AAAA**: دامنه شما را به آدرس IPv6 سرور شما متصل می‌کند.
- **MX**: ایمیل‌های ورودی را به سرور ایمیل شما هدایت می‌کند (شامل wildcards `*`).
- **PTR**: آدرس IP سرور شما را به نام دامنه شما بازمی‌گرداند.

سیاست‌های امنیتی الزامی را تنظیم کنید:

- **DKIM**: ایمیل‌های خروجی را به صورت دیجیتال امضا می‌کند تا اصالت آن‌ها تأیید شود.
- **DMARC**: مشخص می‌کند که دریافت‌کنندگان ایمیل با پیام‌هایی که تأیید نشدند چگونه رفتار کنند.
- **SPF**: سرورهای ایمیل مجاز برای ارسال ایمیل از دامنه شما را تعیین می‌کند.

مراحل اضافی:

- **CAA**: مشخص می‌کند کدام مراجع صدور گواهی مجاز به صدور گواهی SSL برای دامنه شما هستند.
- **MTA-STS**: ارتباطات رمزگذاری شده و امن بین سرورهای ایمیل را الزام‌آور می‌کند.
- **TLS-RPT**: شکست‌های اتصال TLS را گزارش می‌کند تا امنیت ارسال ایمیل بهبود یابد.

**هشدار**: تنظیم رکورد CAA محدود می‌کند که کدام مرجع صدور گواهی می‌تواند با موفقیت برای دامنه شما گواهی SSL صادر کند.
این کار صدور گواهی از سرورهای staging مربوط به Let’s Encrypt را متوقف می‌کند. ممکن است بخواهید اضافه کردن این رکورد DNS را تا پس از صدور موفقیت‌آمیز گواهی‌های SSL برای دامنه خود به تأخیر بیندازید.

## داکر

اگر هنوز Docker را روی سرور خود نصب نکرده‌اید، لطفاً مراحل موجود در [Docker CE برای اوبونتو](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) را جهت نصب Docker دنبال کنید.

همچنین می‌توانید Docker را با استفاده از اسکریپت [docker-install](https://github.com/docker/docker-install) نصب کنید که

```bash
curl -fsSL https://get.docker.com | sh
```

فعال کردن IPv6 برای [شبکه پل پیش‌فرض](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
این راهنما شما را در اجرای کل استک با استفاده از کانتینرهای داکر راهنمایی می‌کند.
این شامل موارد زیر است:

- traefik
- کانتینرهای [برنامه SimpleLogin](https://github.com/simple-login/app)
- postfix

اجرای SimpleLogin از طریق کانتینرهای داکر:

1. این مخزن را در مسیر `/opt/simplelogin` کلون کنید.
1. فایل `.env.example` را به `.env` کپی کرده و مقادیر مناسب را تنظیم کنید.

    - متغیر `DOMAIN` را به دامنه خود تنظیم کنید.
    - متغیر `SUBDOMAIN` را به دامنه خود تنظیم کنید. مقدار پیش‌فرض `app` است.
    - متغیر `POSTGRES_USER` را مطابق با اعتبارنامه‌های postgres تنظیم کنید (در شروع از صفر، مقدار `simplelogin` را وارد کنید).
    - متغیر `POSTGRES_PASSWORD` را مطابق با اعتبارنامه‌های postgres تنظیم کنید (در شروع از صفر، یک کلید تصادفی وارد کنید).
    - متغیر `FLASK_SECRET` را به یک کلید مخفی دلخواه تنظیم کنید.

### پایگاه داده Postgres SQL

این مخزن یک پایگاه داده postgres SQL را در یک کانتینر داکر اجرا می‌کند.

**هشدار**: نسخه‌های قبلی این مخزن نسخه `12.1` را اجرا می‌کردند.
لطفاً برای جزئیات بیشتر و
دستورالعمل‌های ارتقاء به [مستندات مرجع](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) مراجعه کنید.

### اجرای برنامه

برنامه را با استفاده از دستورات زیر اجرا کنید:


```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

شاید بخواهید در این مرحله [مجوز مرجع صدور گواهی (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) را تنظیم کنید.

## مراحل بعدی

اگر همه مراحل بالا با موفقیت انجام شد، <https://app.mydomain.com/> را باز کنید و اولین حساب خود را ایجاد کنید!

به طور پیش‌فرض، حساب‌های جدید پرمیوم نیستند، بنابراین آدرس مستعار نامحدود ندارند. برای پرمیوم کردن حساب خود،
لطفاً به پایگاه داده رفته، جدول "users" را باز کرده و مقدار ستون "lifetime" را به "1" یا "TRUE" تغییر دهید:

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

پس از ایجاد تمامی حساب‌های کاربری مورد نظر خود، این خطوط را به فایل `.env` اضافه کنید تا ثبت‌نام‌های بیشتر غیرفعال شود:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
سپس، برای راه‌اندازی مجدد اپ وب، این دستور را اجرا کنید: `docker compose restart app`

## متفرقه

### پیکربندی Postfix - Spamhaus

پروژه Spamhaus لیست قابل اعتمادی از آدرس‌های IP که منبع SPAM شناخته می‌شوند را نگهداری می‌کند.
شما می‌توانید بررسی کنید که آیا یک آدرس IP خاص در این لیست قرار دارد یا خیر با ارسال کوئری به زیرساخت DNS.

از آنجا که Spamhaus کوئری‌هایی که از Resolverهای عمومی (باز) می‌آیند را مسدود می‌کند (رجوع شود به: <https://check.spamhaus.org/returnc/pub>) و کانتینر postfix شما ممکن است به طور پیش‌فرض از یک ریزولور عمومی استفاده کند،
توصیه می‌شود برای سرویس رایگان [Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
ثبت‌نام کرده و یک کلید Spamhaus DQS دریافت کنید.

این کلید را به عنوان `SPAMHAUS_DQS_KEY` در فایل `.env` خود وارد کنید.

اگر کلید DQS ارائه نشود، کانتینر postfix شما بررسی می‌کند که آیا میرورهای عمومی Spamhaus کوئری‌هایش را می‌پذیرند یا خیر و در صورت امکان، آن‌ها را استفاده می‌کند.
اگر Spamhaus کوئری‌ها از کانتینر postfix شما را به میرورهای عمومی رد کند، این قابلیت به طور کامل غیرفعال خواهد شد.

### پیکربندی Postfix - آدرس‌های مجازی

پیکربندی postfix از آدرس‌های مجازی با استفاده از فایل‌های `postfix/conf.d/virtual` و `postfix/conf.d/virtual-regexp` پشتیبانی می‌کند.
این فایل‌ها به طور خودکار در زمان راه‌اندازی بر اساس فایل‌های الگوی مربوطه [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
و [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) ایجاد می‌شوند.

پیکربندی پیش‌فرض به شرح زیر است:

#### virtual.tpl

فایل `virtual` از تنظیمات `virtual_alias_maps` در postfix پشتیبانی می‌کند.
این شامل یک قانون است که آدرس `unknown@mydomain.com` را به `contact@mydomain.com` نگاشت می‌کند تا دریافت ایمیل
از یک آدرس خاص که با هیچ یک از آدرس‌های مجازی موجود تطابق ندارد، به آدرسی که وجود دارد، نشان داده شود.



```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

فایل `virtual-regexp` از تنظیمات `virtual_alias_maps` در postfix پشتیبانی می‌کند.
این شامل قانونی است که ایمیل‌های ارسال شده به زیردامنه‌های دلخواه را که با یک نام مستعار موجود مطابقت ندارند،
به نام مستعاری جدید بازنویسی می‌کند که متعلق به دایرکتوری‌ای با نام گرفته شده از زیردامنه باشد.
آن نام مستعار در صورت عدم وجود می‌تواند به صورت خودکار ایجاد شود.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

برای مثال، ایمیل‌هایی که به `someone@directory.mydomain.com` ارسال می‌شوند توسط postfix به `directory/someone@mydomain.com` هدایت خواهند شد.

## راهنمای ارتقاء از نسخه ۳.۴.۰

_این بخش به [مستندات مرجع](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl) منتقل شده است_

## راهنمای ارتقاء از تنظیمات قبلی مبتنی بر NGinx

_این بخش به [مستندات مرجع](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx) منتقل شده است_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---