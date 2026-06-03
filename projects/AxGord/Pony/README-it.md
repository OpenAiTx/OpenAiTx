
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

Pony è un insieme di strumenti per sviluppare, preparare, costruire, testare e pubblicare progetti.
Può essere utilizzato per creare applicazioni Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash e Cocos Creator.

Funziona su server o lato client.

La libreria dispone di un sistema di costruzione UI basato su XML e componenti, un potente sistema di eventi e molte funzioni di utilità.

Installazione
=============
Versione stabile

    haxelib install pony

Versione instabile

    haxelib git pony https://github.com/AxGord/Pony

Installa Pony Tools

    haxelib run pony

Esempio di installazione silenziosa

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - abilita l'opzione

`-` - disabilita l'opzione

`code` - Installa i plugin consigliati per Visual Studio Code

`code-insiders` - Installa i plugin consigliati per Visual Studio Code Insiders

`npm` - Installa i moduli NPM (Node Package Manager)

`userpath` - Imposta i percorsi utente

`nodepath` - Imposta il percorso utente su node_modules, solo per Windows

`ponypath` - Imposta il percorso utente su pony.exe, solo per Windows

Esempio di installazione CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Guida video all'installazione](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Video per la creazione di applicazioni multipiattaforma](https://youtu.be/gAY77ESYOUY)

Manuale
------
* [Home](//github.com/AxGord/Pony/wiki)

* [Pony Tools](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Comandi](//github.com/AxGord/Pony/wiki/Commands)
    * [Sezione server](//github.com/AxGord/Pony/wiki/Server-section)
    * [Sezione config](//github.com/AxGord/Pony/wiki/Config-section)
    * [Sezioni preparazione](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Sezioni build](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Sezioni post build](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Net](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Piattaforme
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Manuale di riferimento](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---