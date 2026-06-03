
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

Ponyは、プロジェクトの開発、準備、ビルド、テスト、公開のためのツールセットです。
Heaps、PixiJS、NodeJS、Electron、Cordova、PHP、OpenFL、Unity3D、Flash、Cocos Creatorアプリケーションの作成に利用できます。

サーバーまたはクライアントサイドで動作します。

このライブラリには、XMLベースのUI構築システムとコンポーネント、強力なイベントシステム、多くのユーティリティ関数があります。

インストール
============
安定版

    haxelib install pony

不安定版

    haxelib git pony https://github.com/AxGord/Pony

Pony Toolsのインストール

    haxelib run pony

サイレントインストール例

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - オプションを有効化

`-` - オプションを無効化

`code` - Visual Studio Code 推奨プラグインのインストール

`code-insiders` - Visual Studio Code Insiders 推奨プラグインのインストール

`npm` - NPM（Node Package Manager）モジュールのインストール

`userpath` - ユーザーパスの設定

`nodepath` - Windowsのみ、node_modulesへのユーザーパスを設定

`ponypath` - Windows専用でユーザーパスをpony.exeに設定

CIインストール例

    haxelib run pony install -code -code-insiders +npm +userpath

[インストール動画ガイド](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - クロスプラットフォームアプリ作成動画](https://youtu.be/gAY77ESYOUY)

マニュアル
------
* [ホーム](//github.com/AxGord/Pony/wiki)

* [Pony ツール](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [コマンド](//github.com/AxGord/Pony/wiki/Commands)
    * [サーバーセクション](//github.com/AxGord/Pony/wiki/Server-section)
    * [設定セクション](//github.com/AxGord/Pony/wiki/Config-section)
    * [準備セクション](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [ビルドセクション](//github.com/AxGord/Pony/wiki/Build-sections)
    * [ビルド後セクション](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [ネット](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* プラットフォーム
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [リファレンスブック](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---