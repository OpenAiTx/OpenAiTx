
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=vi">Vietnamesisch</a>
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

Pony ist eine Sammlung von Tools zur Entwicklung, Vorbereitung, Erstellung, Test und Veröffentlichung von Projekten.
Es kann verwendet werden zur Erstellung von Heaps-, PixiJS-, NodeJS-, Electron-, Cordova-, PHP-, OpenFL-, Unity3D-, Flash- und Cocos Creator-Anwendungen.

Es funktioniert auf Servern oder auf der Client-Seite.

Die Bibliothek verfügt über ein XML-basiertes UI-Build-System und Komponenten, ein leistungsfähiges Event-System und viele Hilfsfunktionen.

Installation
============
Stabile Version

    haxelib install pony

Unstabile Version

    haxelib git pony https://github.com/AxGord/Pony

Installiere Pony Tools

    haxelib run pony

Beispiel für eine stille Installation

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - Option aktivieren

`-` - Option deaktivieren

`code` - Installiere empfohlene Visual Studio Code Plugins

`code-insiders` - Installiere empfohlene Visual Studio Code Insiders Plugins

`npm` - Installiere NPM (Node Package Manager) Module

`userpath` - Setze Benutzerpfade

`nodepath` - Setze Benutzerpfad zu node_modules, nur für Windows

`ponypath` - Setzt den Benutzerpfad auf pony.exe, nur für Windows

Beispiel für CI-Installation

    haxelib run pony install -code -code-insiders +npm +userpath

[Installations-Videoanleitung](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony – Video zur plattformübergreifenden Anwendungsentwicklung](https://youtu.be/gAY77ESYOUY)

Handbuch
--------
* [Startseite](//github.com/AxGord/Pony/wiki)

* [Pony Tools](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Befehle](//github.com/AxGord/Pony/wiki/Commands)
    * [Server-Bereich](//github.com/AxGord/Pony/wiki/Server-section)
    * [Konfigurationsbereich](//github.com/AxGord/Pony/wiki/Config-section)
    * [Vorbereitungsbereiche](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Build-Bereiche](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Nach-Build-Bereiche](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Netzwerk](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Plattformen
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Nachschlagewerk](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---