<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ja">日本ی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Lang](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.12-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>

<br/>

Pony مجموعه‌ای از ابزارها برای توسعه، آماده‌سازی، ساخت، تست و انتشار پروژه‌ها است.
این ابزار می‌تواند برای ایجاد برنامه‌های Heaps، PixiJS، NodeJS، Electron، Cordova، PHP، OpenFL، Unity3D، Flash و Cocos Creator استفاده شود.

این ابزار هم بر روی سرورها و هم در سمت کلاینت کار می‌کند.

این کتابخانه دارای یک سیستم ساخت رابط کاربری مبتنی بر XML و کامپوننت‌ها، سیستم رویداد قدرتمند و توابع کمکی فراوان است.

نصب
=====
نسخه پایدار

    haxelib install pony

نسخه ناپایدار

    haxelib git pony https://github.com/AxGord/Pony

نصب ابزارهای Pony

    haxelib run pony

نمونه نصب بی‌صدا

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - فعال کردن گزینه

`-` - غیرفعال کردن گزینه

`code` - نصب افزونه‌های پیشنهادی Visual Studio Code

`code-insiders` - نصب افزونه‌های پیشنهادی Visual Studio Code Insiders

`npm` - نصب ماژول‌های NPM (مدیر بسته Node)

`userpath` - تنظیم مسیرهای کاربر

`nodepath` - تنظیم مسیر کاربر به node_modules فقط برای ویندوز

`ponypath` - تنظیم مسیر کاربر به pony.exe، فقط برای ویندوز

نمونه نصب CI

    haxelib run pony install -code -code-insiders +npm +userpath

[راهنمای تصویری نصب](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[ویدیو ساخت برنامه چندسکویی با Haxe + Heaps + Pony](https://youtu.be/gAY77ESYOUY)

راهنما
------
* [خانه](//github.com/AxGord/Pony/wiki)

* [ابزارهای Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [دستورات](//github.com/AxGord/Pony/wiki/Commands)
    * [بخش سرور](//github.com/AxGord/Pony/wiki/Server-section)
    * [بخش تنظیمات](//github.com/AxGord/Pony/wiki/Config-section)
    * [بخش‌های آماده سازی](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [بخش‌های ساخت](//github.com/AxGord/Pony/wiki/Build-sections)
    * [بخش‌های پس از ساخت](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [شبکه](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* پلتفرم‌ها
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [کتاب مرجع](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---