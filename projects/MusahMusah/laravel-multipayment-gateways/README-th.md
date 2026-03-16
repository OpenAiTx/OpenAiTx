
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# แพ็คเกจ Laravel ที่ทำให้การใช้งานหลายช่องทางชำระเงินและ Webhook เป็นเรื่องง่าย

[![Latest Version on Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP from Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel Version"></a>
![Test Status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Code Style Status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Total Downloads](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)

แพ็คเกจ `laravel-multipayment-gateways` มอบวิธีที่สะดวกในการจัดการการชำระเงินผ่านเกตเวย์การชำระเงินหลายตัวใน **แอปพลิเคชัน Laravel 11, 12 และ 13**
แพ็คเกจนี้รองรับเกตเวย์หลายตัว เช่น **Paystack**, **Flutterwave** และ **Stripe**
แพ็คเกจนี้นำเสนออินเทอร์เฟซที่ใช้งานง่ายซึ่งช่วยลดความซับซ้อนในการผสานรวมกับเกตเวย์การชำระเงินเหล่านี้
นอกจากนี้ยังมีวิธีการจัดการ webhook ที่มาจากเกตเวย์การชำระเงินด้วย

## ความเข้ากันได้ของเวอร์ชัน

| แพ็คเกจ | Laravel | PHP   |
|---------|---------|-------|
| 1.x     | 8–12    | 8.0+  |
| 2.x     | 11–13   | 8.2+  |

> **v2.x อยู่ในช่วง beta** (เวอร์ชันเสถียร: 17 มีนาคม 2026) หากต้องการติดตั้ง beta:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> หากคุณใช้ Laravel 10 หรือต่ำกว่า ให้ติดตั้งเวอร์ชันหลักก่อนหน้า:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## เอกสารประกอบ
มีเอกสารประกอบที่ครบถ้วนเพื่อช่วยให้คุณเริ่มต้นใช้งานแพ็คเกจ [ที่นี่](https://laravel-multipayment-gateways-xi.vercel.app)

 
## การทดสอบ

```bash
php artisan test
```

## บันทึกการเปลี่ยนแปลง

กรุณาดู [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) สำหรับข้อมูลเกี่ยวกับการเปลี่ยนแปลงล่าสุด

## การมีส่วนร่วม

กรุณาดู [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) สำหรับรายละเอียด

## ช่องโหว่ด้านความปลอดภัย

กรุณาตรวจสอบ [นโยบายความปลอดภัยของเรา](../../security/policy) เกี่ยวกับวิธีการรายงานช่องโหว่ด้านความปลอดภัย

## เครดิต

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [ผู้ร่วมพัฒนาทั้งหมด](../../contributors)

## ใบอนุญาต

ใบอนุญาต MIT (MIT) กรุณาดู [ไฟล์ใบอนุญาต](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) สำหรับข้อมูลเพิ่มเติม


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---