[![Lang](https://img.shields.io/badge/language-haxe-orange.svg?style=flat-square&colorB=EA8220)](http://haxe.org)
[![Haxelib](https://img.shields.io/badge/haxelib-1.9.11-blue.svg?style=flat-square&colorB=FBC707)](http://lib.haxe.org/p/pony)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Join the chat at https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Ponyは、プロジェクトの開発、準備、ビルド、テスト、および公開のためのツールセットです。
Heaps、PixiJS、NodeJS、Electron、Cordova、PHP、OpenFL、Unity3D、Flash、Cocos Creatorアプリケーションの作成に使用できます。

サーバーサイドまたはクライアントサイドで動作します。

ライブラリにはXMLベースのUI構築システムとコンポーネント、強力なイベントシステム、多数のユーティリティ関数が含まれています。

インストール
============
安定版

    haxelib install pony

不安定版

    haxelib git pony https://github.com/AxGord/Pony

Ponyツールのインストール

    haxelib run pony

サイレントインストール例

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - オプションを有効にする

`-` - オプションを無効にする

`code` - Visual Studio Code推奨プラグインをインストール
`code-insiders` - Visual Studio Code Insiders 推奨プラグインをインストール

`npm` - NPM (Node Package Manager) モジュールをインストール

`userpath` - ユーザーパスを設定

`nodepath` - node_modules へのユーザーパスを設定、Windows のみ

`ponypath` - pony.exe へのユーザーパスを設定、Windows のみ

CI インストール例

    haxelib run pony install -code -code-insiders +npm +userpath

[インストール動画ガイド](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - クロスプラットフォームアプリケーション作成動画](https://youtu.be/gAY77ESYOUY)

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---