<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

# Birden fazla ödeme geçidi uç noktası ve webhook'unun uygulanmasını sorunsuz hale getiren bir Laravel Paketi

[![Packagist'te En Son Sürüm](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="Packagist'ten PHP"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel Sürümü"></a>
![Test Durumu](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Kod Stili Durumu](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Toplam İndirme](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)


`laravel-multipayment-gateways` paketi, **Laravel 11, 12 ve 13 uygulamalarında** birden fazla ödeme geçidiyle ödeme işlemlerini yönetmek için pratik bir yol sunar.
Paket şu anda **Paystack**, **Flutterwave** ve **Stripe** gibi birden fazla ödeme geçidini desteklemektedir.
Paket, bu ödeme geçitleriyle entegrasyonun karmaşıklıklarını soyutlayan kolay kullanılabilir bir arayüz sunar.
Ayrıca, ödeme geçitlerinden gelen webhook'ları yönetmek için bir yol sağlar.

## Sürüm Uyumluluğu

| Paket   | Laravel | PHP   |
|---------|---------|-------|
| 1.x     | 8–12    | 8.0+  |
| 2.x     | 11–13   | 8.2+  |

> **v2.x şu anda beta aşamasındadır** (kararlı sürüm: 17 Mart 2026). Betayı yüklemek için:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> Laravel 10 veya altı sürümlerdeyseniz, önceki ana sürümü yükleyin:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## Dokümantasyon
Pakete başlamak için kapsamlı bir dokümantasyon [burada](https://laravel-multipayment-gateways-xi.vercel.app) mevcuttur.


## Testler

```bash
php artisan test
```

## Değişiklik Günlüğü

Son zamanlarda nelerin değiştiği hakkında daha fazla bilgi için lütfen [DEĞİŞİKLİK GÜNLÜĞÜ](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) sayfasına bakın.

## Katkı Sağlama

Detaylar için lütfen [KATKI SAĞLAMA](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) sayfasına bakın.

## Güvenlik Açıkları

Güvenlik açıklarının nasıl bildirileceği ile ilgili olarak lütfen [güvenlik politikamızı](../../security/policy) inceleyin.

## Katkı Verenler

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [Tüm Katkı Verenler](../../contributors)

## Lisans

MIT Lisansı (MIT). Daha fazla bilgi için lütfen [Lisans Dosyası](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) sayfasına bakın.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---