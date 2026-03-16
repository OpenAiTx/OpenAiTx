
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# Un pacchetto Laravel che rende l'implementazione di endpoint e webhook di molteplici gateway di pagamento semplice

[![Ultima versione su Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP da Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Versione Laravel"></a>
![Stato dei Test](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Stato Stile Codice](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Download Totali](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)

Il pacchetto `laravel-multipayment-gateways` offre un modo conveniente per gestire i pagamenti tramite diversi gateway di pagamento in un'applicazione **Laravel 11, 12 e 13**.
Attualmente il pacchetto supporta più gateway come **Paystack**, **Flutterwave** e **Stripe**.
Il pacchetto offre un'interfaccia facile da usare che astrae le complessità dell'integrazione con questi gateway di pagamento.
Fornisce inoltre un modo per gestire i webhook provenienti dai gateway di pagamento.

## Compatibilità Versioni

| Pacchetto | Laravel | PHP  |
|-----------|---------|------|
| 1.x       | 8–12    | 8.0+ |
| 2.x       | 11–13   | 8.2+ |

> **La versione v2.x è attualmente in beta** (rilascio stabile: 17 marzo 2026). Per installare la beta:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> Se utilizzi Laravel 10 o versioni precedenti, installa la versione principale precedente:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## Documentazione
Una documentazione completa è disponibile per aiutarti a iniziare con il pacchetto [qui](https://laravel-multipayment-gateways-xi.vercel.app)


## Test

```bash
php artisan test
```

## Changelog

Per favore consulta il [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) per maggiori informazioni su ciò che è stato modificato di recente.

## Contribuire

Per favore consulta [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) per i dettagli.

## Vulnerabilità di Sicurezza

Si prega di consultare [la nostra policy di sicurezza](../../security/policy) su come segnalare vulnerabilità di sicurezza.

## Crediti

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [Tutti i Contributori](../../contributors)

## Licenza

La Licenza MIT (MIT). Si prega di consultare il [File della Licenza](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) per maggiori informazioni.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---