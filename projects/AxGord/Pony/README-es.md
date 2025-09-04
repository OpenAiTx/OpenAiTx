[![Lang](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.11-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony es un conjunto de herramientas para desarrollar, preparar, construir, probar y publicar proyectos.
Puede usarse para crear aplicaciones Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash y Cocos Creator.

Funciona en servidores o del lado del cliente.

La biblioteca tiene un sistema de construcción de UI basado en XML y componentes, un potente sistema de eventos y muchas funciones utilitarias.

Instalación
============
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

`code` - Instalar los plugins recomendados de Visual Studio Code
`code-insiders` - Instalar los plugins recomendados de Visual Studio Code Insiders

`npm` - Instalar módulos NPM (Node Package Manager)

`userpath` - Configurar rutas de usuario

`nodepath` - Configurar ruta de usuario a node_modules, solo para Windows

`ponypath` - Configurar ruta de usuario a pony.exe, solo para Windows

Ejemplo de instalación en CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Guía de instalación en video](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Creando aplicación multiplataforma en video](https://youtu.be/gAY77ESYOUY)

Manual
------
* [Inicio](//github.com/AxGord/Pony/wiki)

* [Herramientas Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Comandos](//github.com/AxGord/Pony/wiki/Commands)
    * [Sección Servidor](//github.com/AxGord/Pony/wiki/Server-section)
    * [Sección Configuración](//github.com/AxGord/Pony/wiki/Config-section)
    * [Secciones de Preparación](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Secciones de Construcción](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Secciones Post construcción](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Red](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Plataformas
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Libro de referencia](http://axgord.github.io/Pony/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---