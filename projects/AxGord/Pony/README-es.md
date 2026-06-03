
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Únete al chat en https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donar PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony es un conjunto de herramientas para desarrollar, preparar, compilar, probar y publicar proyectos.
Se puede usar para crear aplicaciones en Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash y Cocos Creator.

Funciona en servidores o del lado del cliente.

La biblioteca cuenta con un sistema de construcción de interfaces de usuario basado en XML y componentes, un potente sistema de eventos y muchas funciones utilitarias.

Instalación
===========
Versión estable

    haxelib install pony

Versión inestable

    haxelib git pony https://github.com/AxGord/Pony

Instalar Pony Tools

    haxelib run pony

Ejemplo de instalación silenciosa

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - habilitar opción

`-` - deshabilitar opción

`code` - Instalar plugins recomendados para Visual Studio Code

`code-insiders` - Instalar plugins recomendados para Visual Studio Code Insiders

`npm` - Instalar módulos NPM (Node Package Manager)

`userpath` - Establecer rutas de usuario

`nodepath` - Establecer ruta de usuario a node_modules, solo para Windows

`ponypath` - Establece la ruta de usuario a pony.exe, solo para Windows

Ejemplo de instalación en CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Guía de instalación en video](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Video de creación de aplicación multiplataforma](https://youtu.be/gAY77ESYOUY)

Manual
------
* [Inicio](//github.com/AxGord/Pony/wiki)

* [Herramientas Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Comandos](//github.com/AxGord/Pony/wiki/Commands)
    * [Sección del servidor](//github.com/AxGord/Pony/wiki/Server-section)
    * [Sección de configuración](//github.com/AxGord/Pony/wiki/Config-section)
    * [Secciones de preparación](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Secciones de compilación](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Secciones post-compilación](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Red](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Plataformas
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Libro de referencia](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---