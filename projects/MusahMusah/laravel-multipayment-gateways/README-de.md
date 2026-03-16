
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# Ein Laravel-Paket, das die Implementierung mehrerer Payment-Gateway-Endpunkte und Webhooks nahtlos gestaltet

[![Neueste Version auf Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP von Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel Version"></a>
![Teststatus](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Code Style Status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Gesamte Downloads](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)

Das Paket `laravel-multipayment-gateways` bietet eine bequeme Möglichkeit, Zahlungen über mehrere Zahlungs-Gateways in einer **Laravel 11, 12 und 13 Anwendung** abzuwickeln.
Das Paket unterstützt derzeit mehrere Gateways wie **Paystack**, **Flutterwave** und **Stripe**.
Das Paket bietet eine benutzerfreundliche Schnittstelle, die die Komplexität der Integration dieser Zahlungs-Gateways abstrahiert.
Es bietet zudem eine Möglichkeit, Webhooks von den Zahlungs-Gateways zu verarbeiten.

## Versionskompatibilität

| Paket   | Laravel | PHP   |
|---------|---------|-------|
| 1.x     | 8–12    | 8.0+  |
| 2.x     | 11–13   | 8.2+  |

> **v2.x befindet sich derzeit in der Beta-Phase** (stabile Version: 17. März 2026). Um die Beta zu installieren:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> Wenn Sie Laravel 10 oder niedriger verwenden, installieren Sie die vorherige Hauptversion:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## Dokumentation
Eine umfassende Dokumentation steht Ihnen zur Verfügung, um den Einstieg in das Paket zu erleichtern: [hier](https://laravel-multipayment-gateways-xi.vercel.app)


## Tests

```bash
php artisan test
```

## Änderungsprotokoll

Bitte sehen Sie im [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) nach, um mehr über die letzten Änderungen zu erfahren.

## Mitwirken

Bitte sehen Sie in [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) nach, um Details zur Mitarbeit zu erhalten.

## Sicherheitslücken

Bitte lesen Sie [unsere Sicherheitspolitik](../../security/policy), um zu erfahren, wie Sie Sicherheitslücken melden können.

## Danksagungen

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [Alle Mitwirkenden](../../contributors)

## Lizenz

Die MIT-Lizenz (MIT). Weitere Informationen finden Sie in der [Lizenzdatei](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---