
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

Pony est un ensemble d'outils pour développer, préparer, construire, tester et publier des projets.
Il peut être utilisé pour créer des applications Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash et Cocos Creator.

Il fonctionne sur des serveurs ou côté client.

La bibliothèque dispose d'un système de construction d'interface utilisateur basé sur XML et de composants, d'un système d'événements puissant, et de nombreuses fonctions utilitaires.

Installation
============
Version stable

    haxelib install pony

Version instable

    haxelib git pony https://github.com/AxGord/Pony

Installer Pony Tools

    haxelib run pony

Exemple d'installation silencieuse

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - activer l'option

`-` - désactiver l'option

`code` - Installer les plugins recommandés pour Visual Studio Code

`code-insiders` - Installer les plugins recommandés pour Visual Studio Code Insiders

`npm` - Installer les modules NPM (Node Package Manager)

`userpath` - Définir les chemins utilisateur

`nodepath` - Définir le chemin utilisateur vers node_modules, uniquement pour Windows

`ponypath` - Définit le chemin utilisateur vers pony.exe, uniquement pour Windows

Exemple d'installation CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Guide vidéo d'installation](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Vidéo sur la création d'une application multiplateforme](https://youtu.be/gAY77ESYOUY)

Manuel
------
* [Accueil](//github.com/AxGord/Pony/wiki)

* [Outils Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Commandes](//github.com/AxGord/Pony/wiki/Commands)
    * [Section serveur](//github.com/AxGord/Pony/wiki/Server-section)
    * [Section configuration](//github.com/AxGord/Pony/wiki/Config-section)
    * [Sections de préparation](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Sections de build](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Sections post-build](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Net](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Plateformes
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Livre de référence](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---