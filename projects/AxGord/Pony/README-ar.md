
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![اللغة](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.12-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![الترخيص](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![حالة البناء](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![انضم إلى الدردشة على https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![تبرع عبر باي بال](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

بوني هي مجموعة من الأدوات لتطوير، تجهيز، بناء، اختبار ونشر المشاريع.
يمكن استخدامها لإنشاء تطبيقات Heaps، PixiJS، NodeJS، Electron، Cordova، PHP، OpenFL، Unity3D، Flash و Cocos Creator.

تعمل على الخوادم أو من جهة العميل.

تحتوي المكتبة على نظام بناء واجهات مستخدم مبني على XML ومكونات، نظام أحداث قوي، والعديد من الدوال المساعدة.

التثبيت
=======
الإصدار المستقر

    haxelib install pony

الإصدار غير المستقر

    haxelib git pony https://github.com/AxGord/Pony

تثبيت أدوات بوني

    haxelib run pony

مثال على التثبيت الصامت

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - تفعيل الخيار

`-` - تعطيل الخيار

`code` - تثبيت الإضافات الموصى بها لـ Visual Studio Code

`code-insiders` - تثبيت الإضافات الموصى بها لـ Visual Studio Code Insiders

`npm` - تثبيت وحدات NPM (مدير حزم Node)

`userpath` - تعيين مسارات المستخدم

`nodepath` - تعيين مسار المستخدم إلى node_modules، فقط لنظام ويندوز

`ponypath` - تعيين مسار المستخدم إلى pony.exe، فقط لنظام ويندوز

مثال تثبيت CI

    haxelib run pony install -code -code-insiders +npm +userpath

[دليل التثبيت بالفيديو](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[فيديو Haxe + Heaps + Pony - إنشاء تطبيق متعدد المنصات](https://youtu.be/gAY77ESYOUY)

دليل الاستخدام
------
* [الصفحة الرئيسية](//github.com/AxGord/Pony/wiki)

* [أدوات Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [الأوامر](//github.com/AxGord/Pony/wiki/Commands)
    * [قسم الخادم](//github.com/AxGord/Pony/wiki/Server-section)
    * [قسم الإعدادات](//github.com/AxGord/Pony/wiki/Config-section)
    * [أقسام التحضير](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [أقسام البناء](//github.com/AxGord/Pony/wiki/Build-sections)
    * [أقسام ما بعد البناء](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [الشبكة](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* المنصات
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [كتاب المراجع](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---