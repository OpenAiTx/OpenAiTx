
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=MusahMusah&project=laravel-multipayment-gateways&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# 一個 Laravel 套件，讓多重支付閘道端點及 webhook 的實作變得無縫

[![Latest Version on Packagist](https://img.shields.io/packagist/v/musahmusah/laravel-multipayment-gateways.svg?include_prereleases&style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/packagist/php-v/musahmusah/laravel-multipayment-gateways.svg?style=flat-square" alt="PHP from Packagist"></a>
<a href="https://packagist.org/packages/musahmusah/laravel-multipayment-gateways"><img src="https://img.shields.io/badge/Laravel-11.x,%2012.x,%2013.x-brightgreen.svg?style=flat-square" alt="Laravel Version"></a>
![Test Status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/run-tests.yml?branch=main&label=Tests)
![Code Style Status](https://img.shields.io/github/actions/workflow/status/musahmusah/laravel-multipayment-gateways/phpstan.yml?branch=main&label=Code%20Style)
[![Total Downloads](https://img.shields.io/packagist/dt/musahmusah/laravel-multipayment-gateways.svg?style=flat-square)](https://packagist.org/packages/musahmusah/laravel-multipayment-gateways)
`laravel-multipayment-gateways` 套件為 **Laravel 11、12 和 13 應用程式** 提供了一種方便的方式來透過多個支付閘道處理付款。
該套件目前支援多個支付閘道，如 **Paystack**、**Flutterwave** 和 **Stripe**。
此套件提供了易於使用的介面，將整合這些支付閘道的複雜性進行了抽象化。
它也提供了一種方式來處理來自支付閘道的 webhook。

## 版本相容性

| 套件版本 | Laravel | PHP  |
|----------|---------|------|
| 1.x      | 8–12    | 8.0+ |
| 2.x      | 11–13   | 8.2+ |

> **v2.x 目前為 beta 版本**（穩定版發佈：2026 年 3 月 17 日）。要安裝 beta 版：
> ```bash
> composer require musahmusah/laravel-multipayment-gateways:^2.0@beta
> ```

> 如果你在使用 Laravel 10 或更早版本，請安裝上一個主要版本：
> `composer require musahmusah/laravel-multipayment-gateways:^1.0`

## 文件說明
詳細的文件可協助你開始使用此套件，請參考 [這裡](https://laravel-multipayment-gateways-xi.vercel.app)

## 測試



```bash
php artisan test
```

## 變更日誌

請參閱 [CHANGELOG](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CHANGELOG.md) 以獲取近期變更的詳細資訊。

## 貢獻指南

請參閱 [CONTRIBUTING](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/CONTRIBUTING.md) 以了解詳細說明。

## 安全性漏洞

請參閱 [我們的安全政策](../../security/policy) 了解如何回報安全性漏洞。

## 版權聲明

- [MusahMusah](https://github.com/MusahMusah)
- [Cybernerdie](https://github.com/cybernerdie)
- [所有貢獻者](../../contributors)

## 授權條款

MIT 授權條款 (MIT)。請參閱 [授權檔案](https://raw.githubusercontent.com/MusahMusah/laravel-multipayment-gateways/main/LICENSE.md) 以獲取更多資訊。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---