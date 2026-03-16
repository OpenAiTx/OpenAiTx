
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# Laravel-пакет, который обеспечивает бесшовную интеграцию нескольких платежных шлюзов и вебхуков

[![Последняя версия на Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP from Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Версия Laravel"></a>
![Статус теста](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Статус стиля кода](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Всего загрузок](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
Пакет `laravel-multipayment-gateways` предоставляет удобный способ обработки платежей через несколько платежных шлюзов в **приложении на Laravel 11, 12 и 13**.
В настоящее время пакет поддерживает несколько шлюзов, таких как **Paystack**, **Flutterwave** и **Stripe**.
Пакет предлагает простой в использовании интерфейс, который абстрагирует сложности интеграции с этими платежными шлюзами.
Также предоставляется способ обработки вебхуков от платежных шлюзов.

## Совместимость версий

| Пакет   | Laravel | PHP   |
|---------|---------|-------|
| 1.x     | 8–12    | 8.0+  |
| 2.x     | 11–13   | 8.2+  |

> **v2.x в настоящее время находится в бета-версии** (стабильный релиз: 17 марта 2026). Для установки беты:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> Если вы используете Laravel 10 или ниже, установите предыдущую основную версию:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## Документация
Подробная документация доступна для быстрого начала работы с пакетом [здесь](https://laravel-multipayment-gateways-xi.vercel.app)


## Тестирование


```bash
php artisan test
```

## История изменений

Пожалуйста, смотрите [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) для получения информации о последних изменениях.

## Вклад в проект

Пожалуйста, смотрите [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) для подробностей.

## Уязвимости безопасности

Пожалуйста, ознакомьтесь с [нашей политикой безопасности](../../security/policy) по вопросам сообщения об уязвимостях.

## Благодарности

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [Все участники](../../contributors)

## Лицензия

Лицензия MIT (MIT). Пожалуйста, смотрите [лицензионный файл](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) для получения дополнительной информации.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---