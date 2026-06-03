<div align="right">
  <details>
    <summary >🌐 语言</summary>
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

Pony 是一套用于开发、准备、构建、测试和发布项目的工具。
它可用于创建 Heaps、PixiJS、NodeJS、Electron、Cordova、PHP、OpenFL、Unity3D、Flash 和 Cocos Creator 应用程序。

它可在服务器或客户端使用。

该库拥有基于 XML 的 UI 构建系统和组件、强大的事件系统，以及众多实用函数。

安装
============
稳定版本

    haxelib install pony

不稳定版本

    haxelib git pony https://github.com/AxGord/Pony

安装 Pony Tools

    haxelib run pony

静默安装示例

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - 启用选项

`-` - 禁用选项

`code` - 安装 Visual Studio Code 推荐插件

`code-insiders` - 安装 Visual Studio Code Insiders 推荐插件

`npm` - 安装 NPM（Node 包管理器）模块

`userpath` - 设置用户路径

`nodepath` - 设置用户 node_modules 路径，仅适用于 Windows

`ponypath` - 设置用户路径为 pony.exe，仅适用于 Windows

CI 安装示例

    haxelib run pony install -code -code-insiders +npm +userpath

[安装视频指南](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - 制作跨平台应用的视频](https://youtu.be/gAY77ESYOUY)

手册
------
* [主页](//github.com/AxGord/Pony/wiki)

* [Pony 工具](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [命令](//github.com/AxGord/Pony/wiki/Commands)
    * [服务器部分](//github.com/AxGord/Pony/wiki/Server-section)
    * [配置部分](//github.com/AxGord/Pony/wiki/Config-section)
    * [准备部分](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [构建部分](//github.com/AxGord/Pony/wiki/Build-sections)
    * [构建后部分](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [网络](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* 平台
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [参考书](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---