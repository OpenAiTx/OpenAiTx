
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

[![Lang](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.12-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony, projeleri geliştirmek, hazırlamak, derlemek, test etmek ve yayınlamak için bir araç setidir.
Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash ve Cocos Creator uygulamaları oluşturmak için kullanılabilir.

Sunucularda veya istemci tarafında çalışır.

Kütüphane, XML tabanlı bir arayüz oluşturma sistemi ve bileşenlere, güçlü bir olay sistemine ve birçok yardımcı fonksiyona sahiptir.

Kurulum
======
Kararlı sürüm

    haxelib install pony

Kararsız sürüm

    haxelib git pony https://github.com/AxGord/Pony

Pony Araçlarını Yükle

    haxelib run pony

Sessiz kurulum örneği

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - seçeneği etkinleştir

`-` - seçeneği devre dışı bırak

`code` - Visual Studio Code önerilen eklentilerini yükle

`code-insiders` - Visual Studio Code Insiders önerilen eklentilerini yükle

`npm` - NPM (Node Paket Yöneticisi) modüllerini yükle

`userpath` - Kullanıcı yollarını ayarla

`nodepath` - Sadece Windows için, node_modules yolunu kullanıcı yoluna ayarla

`ponypath` - Kullanıcı yolunu pony.exe olarak ayarla, sadece Windows için

CI kurulum örneği

    haxelib run pony install -code -code-insiders +npm +userpath

[Kurulum Video Rehberi](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Platformlar arası uygulama yapma videosu](https://youtu.be/gAY77ESYOUY)

Kılavuz
------
* [Ana Sayfa](//github.com/AxGord/Pony/wiki)

* [Pony Araçları](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Komutlar](//github.com/AxGord/Pony/wiki/Commands)
    * [Sunucu bölümü](//github.com/AxGord/Pony/wiki/Server-section)
    * [Yapılandırma bölümü](//github.com/AxGord/Pony/wiki/Config-section)
    * [Hazırlık bölümleri](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Derleme bölümleri](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Derleme sonrası bölümler](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Ağ](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Platformlar
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Başvuru Kitabı](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---