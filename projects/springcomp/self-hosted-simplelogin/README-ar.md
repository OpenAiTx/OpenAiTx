
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# سيمبل لوجن

هذا إعداد لتشغيل سيمبل لوجن ذاتياً باستخدام docker-compose كما هو موضح في [SimpleLogin](https://simplelogin.io).

## المتطلبات الأساسية

- خادم لينكس (إما جهاز افتراضي أو خادم مخصص). توضح هذه الوثيقة الإعداد على Ubuntu 18.04 LTS لكن يمكن تكييف الخطوات لأنظمة لينكس الشهيرة الأخرى. بما أن معظم المكونات تعمل كحاويات دوكر ودوكر قد يكون ثقيلاً نوعاً ما، يوصى بأن لا تقل الذاكرة العشوائية عن 2 جيجابايت. يجب أن يحتوي الخادم على المنافذ 25 (البريد الإلكتروني)، 80، 443 (لتطبيق الويب)، و 22 (للوصول عبر ssh) مفتوحة.

- نطاق يمكنك تكوين DNS له. يمكن أن يكون نطاقًا فرعيًا. في بقية المستند، لنفترض أن النطاق هو `mydomain.com` للبريد الإلكتروني و`app.mydomain.com` لتطبيق SimpleLogin على الويب. يرجى التأكد من استبدال هذه القيم باسم نطاقك ونطاقك الفرعي كلما ظهرت في المستند. إحدى الحيل التي نستخدمها هي تنزيل ملف README هذا على جهاز الكمبيوتر الخاص بك واستبدال جميع تكرارات `mydomain.com` و `app.mydomain.com` باسم نطاقك.

باستثناء إعداد DNS الذي يتم عادةً على واجهة مسجل النطاق الخاص بك، يجب تنفيذ جميع الخطوات أدناه على الخادم الخاص بك. يجب تشغيل الأوامر باستخدام `bash` (أو أي صدفة متوافقة مع bash مثل `zsh`) كصدفة. إذا كنت تستخدم أصدافًا أخرى مثل `fish`، يرجى التأكد من تكييف الأوامر.

- بعض الحزم البرمجية المساعدة التي تُستخدم للتحقق من الإعداد. يمكنك تثبيتها عبر:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## إعداد DNS

_يرجى الرجوع إلى [الوثائق المرجعية](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) لمزيد من التفاصيل_

> **يرجى الملاحظة** أن تغييرات DNS قد تستغرق ما يصل إلى 24 ساعة للانتشار. في الواقع، عادة ما يكون أسرع بكثير (~دقيقة واحدة تقريبًا في اختبارنا). في إعداد DNS، نستخدم غالبًا اسم النطاق مع نقطة (`.`) في النهاية لإجبار استخدام النطاق المطلق.

ستحتاج إلى إعداد سجلات DNS التالية:

- **A**: يربط نطاقك بعنوان IPv4 الخاص بخادومك.
- **AAAA**: يربط نطاقك بعنوان IPv6 الخاص بخادومك.
- **MX**: يوجه رسائل البريد الإلكتروني الواردة إلى خادم البريد الخاص بك (بما في ذلك علامات النجمة `*`).
- **PTR**: يربط عنوان IP الخاص بخادومك باسم نطاقك.

قم بإعداد سياسات الأمان الإلزامية:

- **DKIM**: يوقع رقمياً الرسائل الصادرة للتحقق من صحتها.
- **DMARC**: يحدد كيفية تعامل مستقبلي البريد الإلكتروني مع الرسائل التي تفشل في المصادقة.
- **SPF**: يسمح لخوادم بريد إلكتروني محددة بإرسال رسائل من نطاقك.

خطوات إضافية:

- **CAA**: يحدد أي سلطات الشهادات يمكنها إصدار شهادات SSL لنطاقك.
- **MTA-STS**: يفرض اتصالات آمنة ومشفرة بين خوادم البريد.
- **TLS-RPT**: يبلغ عن فشل اتصالات TLS لتحسين أمان تسليم البريد الإلكتروني.

**تحذير**: إعداد سجل CAA سيقيد أي سلطة شهادات يمكنها إصدار شهادات SSL بنجاح لنطاقك.
سيمنع ذلك إصدار الشهادات من خوادم Let’s Encrypt التجريبية. قد ترغب في تأجيل هذا السجل حتى بعد إصدار شهادات SSL بنجاح لنطاقك.

## دوكر

إذا لم يكن لديك Docker مثبتًا بالفعل على خادومك، يرجى اتباع الخطوات على [Docker CE لأوبونتو](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) لتثبيت Docker.

يمكنك أيضًا تثبيت Docker باستخدام سكربت [docker-install](https://github.com/docker/docker-install) الذي هو

```bash
curl -fsSL https://get.docker.com | sh
```

تفعيل IPv6 لشبكة الجسر الافتراضية [the default bridge network](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
سوف يرشدك هذا الإجراء خلال تشغيل المجموعة الكاملة باستخدام حاويات Docker.
يشمل ذلك:

- traefik
- حاويات [تطبيق SimpleLogin](https://github.com/simple-login/app)
- postfix

تشغيل SimpleLogin من حاويات Docker:

1. قم باستنساخ هذا المستودع في `/opt/simplelogin`
1. انسخ `.env.example` إلى `.env` وقم بتعيين القيم المناسبة.

    - عيّن متغير `DOMAIN` إلى نطاقك.
    - عيّن متغير `SUBDOMAIN` إلى نطاقك. القيمة الافتراضية هي `app`.
    - عيّن متغير `POSTGRES_USER` ليطابق بيانات اعتماد postgres (عند البدء من الصفر، استخدم `simplelogin`).
    - عيّن متغير `POSTGRES_PASSWORD` ليطابق بيانات اعتماد postgres (عند البدء من الصفر، عيّن مفتاحًا عشوائيًا).
    - عيّن متغير `FLASK_SECRET` إلى مفتاح سري عشوائي.

### Postgres SQL

يشغل هذا المستودع قاعدة بيانات postgres SQL في حاوية Docker.

**تحذير**: الإصدارات السابقة من هذا المستودع كانت تعمل بالإصدار `12.1`.
يرجى الرجوع إلى [وثائق المرجع](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) لمزيد من التفاصيل وتعليمات الترقية.

### تشغيل التطبيق

قم بتشغيل التطبيق باستخدام الأوامر التالية:



```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```
قد ترغب في إعداد [تفويض سلطة الشهادة (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) في هذه المرحلة.

## الخطوات التالية

إذا نجحت جميع الخطوات السابقة، افتح <https://app.mydomain.com/> وأنشئ حسابك الأول!

افتراضيًا، الحسابات الجديدة ليست مميزة وبالتالي ليس لديها عدد غير محدود من الأسماء المستعارة. لجعل حسابك مميزًا،
يرجى الذهاب إلى قاعدة البيانات، جدول "users" وتعيين عمود "lifetime" إلى "1" أو "TRUE":


```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

بمجرد إنشاء جميع حسابات تسجيل الدخول المطلوبة، أضف هذه السطور إلى ملف `.env` لتعطيل التسجيلات الإضافية:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
ثم، لإعادة تشغيل تطبيق الويب، قم بتطبيق الأمر: `docker compose restart app`

## متفرقات

### إعداد Postfix - سبامهاوس

مشروع سبامهاوس يحتفظ بقائمة موثوقة لعناوين IP المعروفة كمصدر للبريد المزعج (SPAM).
يمكنك التحقق مما إذا كان عنوان IP معين موجودًا في تلك القائمة عن طريق إرسال استعلامات إلى بنية الـ DNS التحتية.

نظرًا لأن سبامهاوس يحجب الاستعلامات القادمة من محولات DNS العامة (انظر: <https://check.spamhaus.org/returnc/pub>) وقد يستخدم حاوية البريد الخاص بك
مُحلل DNS عام بشكل افتراضي، فمن المستحسن التسجيل في
[خدمة استعلام بيانات سبامهاوس](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
والحصول على مفتاح سبامهاوس DQS مجاني.

الصق هذا المفتاح باسم `SPAMHAUS_DQS_KEY` في ملف `.env` الخاص بك

إذا لم يتم توفير مفتاح DQS، سيتحقق حاوية البريد الخاص بك إذا كانت مرايا سبامهاوس العامة تقبل استعلاماته ويستخدمها بدلاً من ذلك.
إذا رفض سبامهاوس الاستعلامات من حاوية البريد الخاص بك إلى المرايا العامة، فسيتم تعطيلها بالكامل.

### إعداد Postfix - الأسماء المستعارة الافتراضية

يدعم إعداد postfix الأسماء المستعارة الافتراضية باستخدام ملفات `postfix/conf.d/virtual` و `postfix/conf.d/virtual-regexp`.
يتم إنشاء هذه الملفات تلقائيًا عند بدء التشغيل بناءً على ملفات القوالب [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
و [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

الإعداد الافتراضي كما يلي:

#### virtual.tpl

يدعم ملف `virtual` إعدادات postfix `virtual_alias_maps`.
يتضمن قاعدة تقوم بتحويل `unknown@mydomain.com` إلى `contact@mydomain.com` لتوضيح استقبال
رسالة بريد إلكتروني من عنوان محدد لا يتطابق مع اسم مستعار موجود، إلى عنوان آخر موجود.


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

يدعم ملف `virtual-regexp` إعدادات postfix `virtual_alias_maps`.
يتضمن قاعدة تعيد كتابة رسائل البريد الإلكتروني الموجهة إلى نطاق فرعي عشوائي، لا يتوافق مع
اسم مستعار موجود، إلى اسم مستعار جديد ينتمي إلى دليل يحمل اسم النطاق الفرعي.
يمكن إنشاء هذا الاسم المستعار تلقائياً إذا لم يكن موجوداً.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

على سبيل المثال، رسائل البريد الإلكتروني المرسلة إلى `someone@directory.mydomain.com` سيتم توجيهها إلى `directory/someone@mydomain.com` بواسطة postfix.

## كيفية الترقية من 3.4.0

_تم نقل هذا القسم إلى [الوثائق المرجعية](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## كيفية الترقية من إعداد سابق يعتمد على NGinx

_تم نقل هذا القسم إلى [الوثائق المرجعية](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---