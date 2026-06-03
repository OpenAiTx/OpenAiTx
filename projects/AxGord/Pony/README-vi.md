
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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
[![Build status](https://img.shields.io/appveyor/ci/AxGord/pony.svg?label=windows&style=flat-square)](https://ci.appveyor.com/project/AxGord/pony) [![Tham gia trò chuyện tại https://gitter.im/Ponylib/Lobby](https://img.shields.io/gitter/room/Ponylib/Lobby.svg?style=flat-square&colorB=71B79C)](https://gitter.im/Ponylib/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Donate PayPal](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://paypal.me/axgorde)

<br/><br/>
<p align="center"><img width="65%" src="https://raw.githubusercontent.com/AxGord/Pony/haxe3/logo/pony_logo_hor.svg"/></p>
<br/>

Pony là một bộ công cụ để phát triển, chuẩn bị, xây dựng, kiểm thử và phát hành các dự án.
Nó có thể được sử dụng để tạo các ứng dụng Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash và Cocos Creator.

Nó hoạt động trên máy chủ hoặc phía máy khách.

Thư viện có hệ thống xây dựng giao diện người dùng dựa trên XML và các thành phần, hệ thống sự kiện mạnh mẽ và nhiều hàm tiện ích.

Cài đặt
=======
Phiên bản ổn định

    haxelib install pony

Phiên bản không ổn định

    haxelib git pony https://github.com/AxGord/Pony

Cài đặt Pony Tools

    haxelib run pony

Ví dụ cài đặt yên lặng

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - bật tùy chọn

`-` - tắt tùy chọn

`code` - Cài đặt các plugin khuyến nghị cho Visual Studio Code

`code-insiders` - Cài đặt các plugin khuyến nghị cho Visual Studio Code Insiders

`npm` - Cài đặt các module NPM (Node Package Manager)

`userpath` - Thiết lập đường dẫn người dùng

`nodepath` - Thiết lập đường dẫn người dùng đến node_modules, chỉ dành cho Windows

`ponypath` - Thiết lập đường dẫn người dùng tới pony.exe, chỉ dành cho Windows

Ví dụ cài đặt CI

    haxelib run pony install -code -code-insiders +npm +userpath

[Video hướng dẫn cài đặt](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - Video làm ứng dụng đa nền tảng](https://youtu.be/gAY77ESYOUY)

Hướng dẫn sử dụng
------
* [Trang chủ](//github.com/AxGord/Pony/wiki)

* [Công cụ Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [Lệnh](//github.com/AxGord/Pony/wiki/Commands)
    * [Phần máy chủ](//github.com/AxGord/Pony/wiki/Server-section)
    * [Phần cấu hình](//github.com/AxGord/Pony/wiki/Config-section)
    * [Phần chuẩn bị](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [Phần xây dựng](//github.com/AxGord/Pony/wiki/Build-sections)
    * [Phần sau xây dựng](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [Mạng](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* Nền tảng
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [Sách tham khảo](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---