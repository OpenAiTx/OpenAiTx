
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

Pony is a set of tools for developing, preparing, building, testing and publishing projects.
It can be used for creating Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash and Cocos Creator applications.

It works on servers or client-side.

The library has an XML-based UI building system and components, a powerful event system, and many utility functions.

Installation
============
Stable version

    haxelib install pony

Unstable version

    haxelib git pony https://github.com/AxGord/Pony

Install Pony Tools

    haxelib run pony

Silent install example

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - enable option

`-` - disable option

`code` - Install Visual Studio Code recommended plugins

`code-insiders` - Install Visual Studio Code Insiders recommended plugins

`npm` - Install NPM (Node Package Manager) modules

`userpath` - Set user paths

`nodepath` - Set user path to node_modules, only for Windows

`ponypath` - Set user path to pony.exe, only for Windows

CI install example

    haxelib run pony install -code -code-insiders +npm +userpath

[Installation Video Guide](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Making cross-platform application video](https://youtu.be/gAY77ESYOUY)

Manual
------
* [Home](//github.com/AxGord/Pony/wiki)

* [Pony Tools](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Commands](//github.com/AxGord/Pony/wiki/Commands)
    * [Server section](//github.com/AxGord/Pony/wiki/Server-section)
    * [Config section](//github.com/AxGord/Pony/wiki/Config-section)
    * [Prepare sections](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Build sections](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Post build sections](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Net](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Platforms
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Reference book](http://axgord.github.io/Pony/)
