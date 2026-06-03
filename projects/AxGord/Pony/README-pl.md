
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

Pony to zestaw narzędzi do tworzenia, przygotowywania, budowania, testowania i publikowania projektów.
Może być używany do tworzenia aplikacji Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash i Cocos Creator.

Działa na serwerach lub po stronie klienta.

Biblioteka posiada system budowania UI oparty na XML, komponenty, potężny system zdarzeń oraz wiele funkcji użytkowych.

Instalacja
============
Stabilna wersja

    haxelib install pony

Niestabilna wersja

    haxelib git pony https://github.com/AxGord/Pony

Zainstaluj Pony Tools

    haxelib run pony

Przykład cichej instalacji

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - włącz opcję

`-` - wyłącz opcję

`code` - Instaluj zalecane wtyczki Visual Studio Code

`code-insiders` - Instaluj zalecane wtyczki Visual Studio Code Insiders

`npm` - Instaluj moduły NPM (Node Package Manager)

`userpath` - Ustaw ścieżki użytkownika

`nodepath` - Ustaw ścieżkę użytkownika do node_modules, tylko dla Windows

`ponypath` - Ustaw ścieżkę użytkownika do pony.exe, tylko dla Windows

Przykład instalacji CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Przewodnik wideo instalacji](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Tworzenie aplikacji wieloplatformowej wideo](https://youtu.be/gAY77ESYOUY)

Podręcznik
------
* [Strona główna](//github.com/AxGord/Pony/wiki)

* [Narzędzia Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Polecenia](//github.com/AxGord/Pony/wiki/Commands)
    * [Sekcja serwera](//github.com/AxGord/Pony/wiki/Server-section)
    * [Sekcja konfiguracji](//github.com/AxGord/Pony/wiki/Config-section)
    * [Sekcje przygotowawcze](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Sekcje budowania](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Sekcje po budowaniu](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Net](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Platformy
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Księga referencyjna](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---