
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Een Laravel-pakket dat de implementatie van meerdere betaalgateway-eindpunten en webhooks naadloos maakt

[![Laatste versie op Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP van Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel Versie"></a>
![Teststatus](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Code stijl status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Totaal aantal downloads](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)

Het `laravel-multipayment-gateways` pakket biedt een gemakkelijke manier om betalingen via meerdere betaalgateways af te handelen in een **Laravel 11, 12 en 13 applicatie**.
Het pakket ondersteunt momenteel meerdere gateways zoals **Paystack**, **Flutterwave** en **Stripe**.
Het pakket biedt een gebruiksvriendelijke interface die de complexiteit van het integreren met deze betaalgateways abstraheert.
Het biedt ook een manier om webhooks van de betaalgateways af te handelen.

## Versiecompatibiliteit

| Pakket | Laravel | PHP  |
|--------|---------|------|
| 1.x    | 8–12    | 8.0+ |
| 2.x    | 11–13   | 8.2+ |

> **v2.x is momenteel in bèta** (stabiele release: 17 maart 2026). Om de bèta te installeren:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> Als je op Laravel 10 of lager zit, installeer dan de vorige hoofdversie:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## Documentatie
Uitgebreide documentatie is beschikbaar om je te helpen aan de slag te gaan met het pakket [hier](https://laravel-multipayment-gateways-xi.vercel.app)


## Testen

```bash
php artisan test
```

## Wijzigingslog

Zie [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) voor meer informatie over wat er recentelijk is gewijzigd.

## Bijdragen

Zie [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) voor details.

## Beveiligingskwetsbaarheden

Bekijk [onze beveiligingsbeleid](../../security/policy) over hoe u beveiligingskwetsbaarheden kunt melden.

## Credits

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [Alle bijdragers](../../contributors)

## Licentie

De MIT-licentie (MIT). Zie [Licentiebestand](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) voor meer informatie.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---