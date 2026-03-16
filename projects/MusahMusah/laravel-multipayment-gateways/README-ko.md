
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

# 여러 결제 게이트웨이 엔드포인트 및 웹훅 구현을 손쉽게 만드는 Laravel 패키지

[![Packagist 최신 버전](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="Packagist의 PHP"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel 버전"></a>
![테스트 상태](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![코드 스타일 상태](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![총 다운로드](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
`laravel-multipayment-gateways` 패키지는 **Laravel 11, 12 및 13 애플리케이션**에서 여러 결제 게이트웨이를 통한 결제 처리를 편리하게 지원합니다.
현재 패키지는 **Paystack**, **Flutterwave**, **Stripe** 등 여러 게이트웨이를 지원합니다.
이 패키지는 이러한 결제 게이트웨이 통합의 복잡성을 추상화하는 사용하기 쉬운 인터페이스를 제공합니다.
또한 결제 게이트웨이의 웹훅을 처리하는 방법도 제공합니다.

## 버전 호환성

| 패키지 | Laravel | PHP  |
|--------|---------|------|
| 1.x    | 8–12    | 8.0+ |
| 2.x    | 11–13   | 8.2+ |

> **v2.x는 현재 베타 버전입니다** (정식 출시: 2026년 3월 17일). 베타 버전을 설치하려면:
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> Laravel 10 이하를 사용하고 있다면, 이전 주요 버전을 설치하세요:
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## 문서
패키지 사용을 시작할 수 있도록 포괄적인 문서가 [여기](https://laravel-multipayment-gateways-xi.vercel.app)에서 제공됩니다.


## 테스트


```bash
php artisan test
```
## 변경 기록

최근 변경된 내용에 대한 자세한 정보는 [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md)를 참조하세요.

## 기여하기

자세한 내용은 [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md)를 참조하세요.

## 보안 취약점

보안 취약점 보고 방법에 대해서는 [보안 정책](../../security/policy)을 검토해 주세요.

## 기여자

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [모든 기여자](../../contributors)

## 라이선스

MIT 라이선스(MIT). 자세한 내용은 [라이선스 파일](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md)을 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---