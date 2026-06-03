
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=AxGord&project=Pony&lang=zh-CN">簡體中文</a>
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

Pony 是一套用於開發、準備、建構、測試及發布專案的工具。
它可用於創建 Heaps、PixiJS、NodeJS、Electron、Cordova、PHP、OpenFL、Unity3D、Flash 和 Cocos Creator 應用程式。

它可在伺服器或客戶端運行。

此函式庫具有基於 XML 的 UI 建構系統與元件、強大的事件系統，以及眾多實用工具函式。

安裝
============
穩定版本

    haxelib install pony

不穩定版本

    haxelib git pony https://github.com/AxGord/Pony

安裝 Pony 工具

    haxelib run pony

靜默安裝範例

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - 啟用選項

`-` - 停用選項

`code` - 安裝 Visual Studio Code 推薦插件

`code-insiders` - 安裝 Visual Studio Code Insiders 推薦插件

`npm` - 安裝 NPM（Node 套件管理器）模組

`userpath` - 設定使用者路徑

`nodepath` - 設定使用者路徑為 node_modules，僅適用於 Windows

`ponypath` - 設定使用者路徑為 pony.exe，僅適用於 Windows

CI 安裝範例

    haxelib run pony install -code -code-insiders +npm +userpath

[安裝操作影片教學](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - 製作跨平台應用程式影片](https://youtu.be/gAY77ESYOUY)

手冊
------
* [首頁](//github.com/AxGord/Pony/wiki)

* [Pony 工具](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [指令](//github.com/AxGord/Pony/wiki/Commands)
    * [伺服器區段](//github.com/AxGord/Pony/wiki/Server-section)
    * [設定區段](//github.com/AxGord/Pony/wiki/Config-section)
    * [準備區段](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [建置區段](//github.com/AxGord/Pony/wiki/Build-sections)
    * [建置後區段](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [網路](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* 平台
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [參考手冊](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---