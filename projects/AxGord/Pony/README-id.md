
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

[![Bahasa](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.12-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![Lisensi](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Status Build](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Bergabunglah dengan chat di https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donasi PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony adalah seperangkat alat untuk mengembangkan, menyiapkan, membangun, menguji, dan menerbitkan proyek.
Alat ini dapat digunakan untuk membuat aplikasi Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash, dan Cocos Creator.

Alat ini dapat digunakan di server maupun sisi klien.

Library ini memiliki sistem pembangunan UI berbasis XML dan komponen, sistem event yang kuat, dan banyak fungsi utilitas.

Instalasi
=========
Versi stabil

    haxelib install pony

Versi tidak stabil

    haxelib git pony https://github.com/AxGord/Pony

Instal Pony Tools

    haxelib run pony

Contoh instalasi tanpa suara

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - aktifkan opsi

`-` - nonaktifkan opsi

`code` - Instal plugin rekomendasi Visual Studio Code

`code-insiders` - Instal plugin rekomendasi Visual Studio Code Insiders

`npm` - Instal modul NPM (Node Package Manager)

`userpath` - Atur path pengguna

`nodepath` - Atur path pengguna ke node_modules, hanya untuk Windows

`ponypath` - Atur path pengguna ke pony.exe, hanya untuk Windows

Contoh instalasi CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Panduan Video Instalasi](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Video membuat aplikasi lintas platform](https://youtu.be/gAY77ESYOUY)

Manual
------
* [Beranda](//github.com/AxGord/Pony/wiki)

* [Pony Tools](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Perintah](//github.com/AxGord/Pony/wiki/Commands)
    * [Bagian Server](//github.com/AxGord/Pony/wiki/Server-section)
    * [Bagian Konfigurasi](//github.com/AxGord/Pony/wiki/Config-section)
    * [Bagian Persiapan](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Bagian Build](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Bagian Setelah Build](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Net](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Platform
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Buku Referensi](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---