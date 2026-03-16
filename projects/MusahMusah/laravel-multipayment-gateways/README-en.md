
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

# A Laravel Package that makes implementation of multiple payment Gateways endpoints and webhooks seamless

[![Latest Version on Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP from Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel Version"></a>
![Test Status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Code Style Status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Total Downloads](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)

The `laravel-multipayment-gateways` package provides a convenient way to handle payments through multiple payment gateways in a **Laravel 11, 12 and 13 application**.
The package currently supports multiple gateways such as **Paystack**, **Flutterwave** and **Stripe**.
The package offers an easy to use interface that abstracts the complexities of integrating with these payment gateways.
It also provides a way to handle webhooks from the payment gateways.

## Version Compatibility

| Package | Laravel | PHP  |
|---------|---------|------|
| 1.x     | 8–12    | 8.0+ |
| 2.x     | 11–13   | 8.2+ |

> **v2.x is currently in beta** (stable release: March 17, 2026). To install the beta:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> If you are on Laravel 10 or below, install the previous major version:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## Documentation
A comprehensive documentation is available to help you get started with the package [here](https://laravel-multipayment-gateways-xi.vercel.app)


## Testing

```bash
php artisan test
```

## Changelog

Please see [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) for more information on what has changed recently.

## Contributing

Please see [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) for details.

## Security Vulnerabilities

Please review [our security policy](../../security/policy) on how to report security vulnerabilities.

## Credits

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [All Contributors](../../contributors)

## License

The MIT License (MIT). Please see [License File](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) for more information.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---