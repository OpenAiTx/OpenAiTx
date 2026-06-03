
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

Pony คือชุดเครื่องมือสำหรับการพัฒนา เตรียมการ สร้าง ทดสอบ และเผยแพร่โปรเจกต์ต่างๆ
สามารถใช้สร้างแอปพลิเคชัน Heaps, PixiJS, NodeJS, Electron, Cordova, PHP, OpenFL, Unity3D, Flash และ Cocos Creator ได้

สามารถใช้งานได้ทั้งฝั่งเซิร์ฟเวอร์หรือฝั่งไคลเอนต์

ไลบรารีนี้มีระบบสร้าง UI และคอมโพเนนต์ที่ใช้ XML ระบบอีเวนต์ที่ทรงพลัง และฟังก์ชันยูทิลิตี้มากมาย

การติดตั้ง
============
เวอร์ชันเสถียร

    haxelib install pony

เวอร์ชันไม่เสถียร

    haxelib git pony https://github.com/AxGord/Pony

ติดตั้ง Pony Tools

    haxelib run pony

ตัวอย่างการติดตั้งแบบไม่แสดงผล

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - เปิดใช้งานออปชัน

`-` - ปิดใช้งานออปชัน

`code` - ติดตั้งปลั๊กอินแนะนำสำหรับ Visual Studio Code

`code-insiders` - ติดตั้งปลั๊กอินแนะนำสำหรับ Visual Studio Code Insiders

`npm` - ติดตั้งโมดูล NPM (Node Package Manager)

`userpath` - ตั้งค่าเส้นทางผู้ใช้

`nodepath` - ตั้งค่าเส้นทางผู้ใช้ไปยัง node_modules เฉพาะสำหรับ Windows

`ponypath` - ตั้งค่าพาธผู้ใช้ไปยัง pony.exe เฉพาะสำหรับ Windows

ตัวอย่างการติดตั้ง CI

    haxelib run pony install -code -code-insiders +npm +userpath

[วิดีโอแนะนำการติดตั้ง](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - วิดีโอสร้างแอปพลิเคชันข้ามแพลตฟอร์ม](https://youtu.be/gAY77ESYOUY)

คู่มือ
------
* [หน้าหลัก](//github.com/AxGord/Pony/wiki)

* [เครื่องมือ Pony](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [คำสั่ง](//github.com/AxGord/Pony/wiki/Commands)
    * [ส่วนเซิร์ฟเวอร์](//github.com/AxGord/Pony/wiki/Server-section)
    * [ส่วนการตั้งค่า](//github.com/AxGord/Pony/wiki/Config-section)
    * [ส่วนเตรียมการ](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [ส่วนการสร้าง](//github.com/AxGord/Pony/wiki/Build-sections)
    * [ส่วนหลังการสร้าง](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [เครือข่าย](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* แพลตฟอร์ม
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [หนังสืออ้างอิง](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---