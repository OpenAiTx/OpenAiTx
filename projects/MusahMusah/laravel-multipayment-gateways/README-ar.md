<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# حزمة لارافيل تجعل تنفيذ نقاط نهاية بوابات الدفع المتعددة وروابط الويب سهلاً وسلساً

[![آخر إصدار على Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP from Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel Version"></a>
![حالة الاختبارات](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![حالة نمط الشيفرة](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![إجمالي التحميلات](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)


توفر حزمة `laravel-multipayment-gateways` طريقة ملائمة للتعامل مع المدفوعات عبر بوابات دفع متعددة في **تطبيق Laravel 11، 12 و13**.
تدعم الحزمة حالياً عدة بوابات مثل **Paystack** و**Flutterwave** و**Stripe**.
توفر الحزمة واجهة استخدام سهلة تقوم بتبسيط تعقيدات التكامل مع هذه بوابات الدفع.
كما توفر طريقة للتعامل مع Webhooks من بوابات الدفع.

## توافق الإصدارات

| الحزمة   | Laravel  | PHP   |
|----------|----------|-------|
| 1.x      | 8–12     | 8.0+  |
| 2.x      | 11–13    | 8.2+  |

> **الإصدار 2.x حالياً في مرحلة البيتا** (الإصدار المستقر: 17 مارس 2026). لتثبيت البيتا:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> إذا كنت تستخدم Laravel 10 أو أقل، قم بتثبيت الإصدار الرئيسي السابق:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## التوثيق
يتوفر توثيق شامل لمساعدتك في البدء باستخدام الحزمة [هنا](https://laravel-multipayment-gateways-xi.vercel.app)

## الاختبار


```bash
php artisan test
```

## سجل التغييرات

يرجى مراجعة [سجل التغييرات](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) لمزيد من المعلومات حول التغييرات الأخيرة.

## المساهمة

يرجى مراجعة [إرشادات المساهمة](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) للحصول على التفاصيل.

## ثغرات الأمان

يرجى مراجعة [سياسة الأمان الخاصة بنا](../../security/policy) لمعرفة كيفية الإبلاغ عن ثغرات الأمان.

## الشكر والتقدير

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [جميع المساهمين](../../contributors)

## الترخيص

ترخيص MIT (MIT). يرجى مراجعة [ملف الترخيص](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) لمزيد من المعلومات.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---