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
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>

<br/>

Pony é um conjunto de ferramentas para desenvolver, preparar, construir, testar e publicar projetos.
Pode ser usado para criar aplicações Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash e Cocos Creator.

Funciona em servidores ou no lado do cliente.

A biblioteca possui um sistema de construção de UI baseado em XML e componentes, um poderoso sistema de eventos e muitas funções utilitárias.

Instalação
==========
Versão estável

    haxelib install pony

Versão instável

    haxelib git pony https://github.com/AxGord/Pony

Instale Pony Tools

    haxelib run pony

Exemplo de instalação silenciosa

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - habilitar opção

`-` - desabilitar opção

`code` - Instalar plugins recomendados do Visual Studio Code

`code-insiders` - Instalar plugins recomendados do Visual Studio Code Insiders

`npm` - Instalar módulos NPM (Node Package Manager)

`userpath` - Definir caminhos de usuário

`nodepath` - Definir caminho do usuário para node_modules, apenas para Windows

`ponypath` - Definir caminho do usuário para pony.exe, apenas para Windows

Exemplo de instalação em CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Guia em Vídeo de Instalação](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Vídeo de criação de aplicação multiplataforma](https://youtu.be/gAY77ESYOUY)

Manual
------
* [Início](//github.com/AxGord/Pony/wiki)

* [Ferramentas Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Comandos](//github.com/AxGord/Pony/wiki/Commands)
    * [Seção do Servidor](//github.com/AxGord/Pony/wiki/Server-section)
    * [Seção de Configuração](//github.com/AxGord/Pony/wiki/Config-section)
    * [Seções de Preparação](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Seções de Compilação](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Seções Pós-compilação](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Net](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Plataformas
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Livro de referência](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---