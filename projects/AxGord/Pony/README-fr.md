[![Lang](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.11-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony est un ensemble d’outils pour développer, préparer, construire, tester et publier des projets.
Il peut être utilisé pour créer des applications Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash et Cocos Creator.

Il fonctionne côté serveur ou client.

La bibliothèque dispose d’un système de construction d’interface utilisateur basé sur XML et de composants, d’un système d’événements puissant, et de nombreuses fonctions utilitaires.

Installation
============
Version stable

    haxelib install pony

Version instable

    haxelib git pony https://github.com/AxGord/Pony

Installer les outils Pony

    haxelib run pony

Exemple d’installation silencieuse

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - activer l’option

`-` - désactiver l’option

`code` - Installer les plugins recommandés pour Visual Studio Code
`code-insiders` - Installer les plugins recommandés de Visual Studio Code Insiders

`npm` - Installer les modules NPM (Node Package Manager)

`userpath` - Définir les chemins utilisateur

`nodepath` - Définir le chemin utilisateur vers node_modules, uniquement pour Windows

`ponypath` - Définir le chemin utilisateur vers pony.exe, uniquement pour Windows

Exemple d'installation CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Guide vidéo d'installation](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Réalisation d'une application multiplateforme vidéo](https://youtu.be/gAY77ESYOUY)

Manuel
------
* [Accueil](//github.com/AxGord/Pony/wiki)

* [Outils Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Commandes](//github.com/AxGord/Pony/wiki/Commands)
    * [Section serveur](//github.com/AxGord/Pony/wiki/Server-section)
    * [Section configuration](//github.com/AxGord/Pony/wiki/Config-section)
    * [Sections de préparation](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Sections de compilation](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Sections post-compilation](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Réseau](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Plates-formes
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Livre de référence](http://axgord.github.io/Pony/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---