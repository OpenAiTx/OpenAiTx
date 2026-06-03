<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

पोनी परियोजनाओं के विकास, तैयारी, निर्माण, परीक्षण और प्रकाशन के लिए उपकरणों का एक सेट है।
इसे हीप्स, पिक्सीजेएस, नोडजेएस, इलेक्ट्रॉन, कोर्डोवा, पीएचपी, ओपनएफएल, यूनिटी3डी, फ्लैश और कोकोस क्रिएटर अनुप्रयोग बनाने के लिए उपयोग किया जा सकता है।

यह सर्वर या क्लाइंट-साइड पर काम करता है।

इस पुस्तकालय में XML-आधारित UI निर्माण प्रणाली और घटक, एक शक्तिशाली इवेंट सिस्टम, और कई उपयोगी यूटिलिटी फंक्शन हैं।

इंस्टॉलेशन
============
स्थिर संस्करण

    haxelib install pony

अस्थिर संस्करण

    haxelib git pony https://github.com/AxGord/Pony

पोनी टूल्स इंस्टॉल करें

    haxelib run pony

साइलेंट इंस्टॉल उदाहरण

    haxelib run pony install +code -code-insiders +npm +userpath -nodepath +ponypath

`+` - विकल्प सक्षम करें

`-` - विकल्प अक्षम करें

`code` - विजुअल स्टूडियो कोड के लिए अनुशंसित प्लगइन्स इंस्टॉल करें

`code-insiders` - विजुअल स्टूडियो कोड इंसाइडर्स के लिए अनुशंसित प्लगइन्स इंस्टॉल करें

`npm` - एनपीएम (नोड पैकेज मैनेजर) मॉड्यूल इंस्टॉल करें

`userpath` - यूजर पथ सेट करें

`nodepath` - केवल विंडोज़ के लिए node_modules का यूजर पथ सेट करें

`ponypath` - उपयोगकर्ता पथ को pony.exe पर सेट करें, केवल Windows के लिए

CI इंस्टॉल उदाहरण

    haxelib run pony install -code -code-insiders +npm +userpath

[इंस्टॉलेशन वीडियो गाइड](https://www.youtube.com/watch?v=ufYIEmQcv4o)

[Haxe + Heaps + Pony - क्रॉस-प्लेटफ़ॉर्म एप्लिकेशन बनाने का वीडियो](https://youtu.be/gAY77ESYOUY)

मैनुअल
------
* [होम](//github.com/AxGord/Pony/wiki)

* [Pony टूल्स](//github.com/AxGord/Pony/wiki/Pony-Tools)
    * [कमांड्स](//github.com/AxGord/Pony/wiki/Commands)
    * [सर्वर सेक्शन](//github.com/AxGord/Pony/wiki/Server-section)
    * [कॉन्फ़िग सेक्शन](//github.com/AxGord/Pony/wiki/Config-section)
    * [तैयारी सेक्शन](//github.com/AxGord/Pony/wiki/Prepare-sections)
    * [बिल्ड सेक्शन](//github.com/AxGord/Pony/wiki/Build-sections)
    * [पोस्ट बिल्ड सेक्शन](//github.com/AxGord/Pony/wiki/Post-build-sections)

* [नेट](//github.com/AxGord/Pony/wiki/Net)
    * [RPC](//github.com/AxGord/Pony/wiki/RPC)

* प्लेटफ़ॉर्म्स
    * [CS](//github.com/AxGord/Pony/wiki/CS)
    * [Cocos Creator](//github.com/AxGord/Pony/wiki/Cocos-Creator)

* [संदर्भ पुस्तक](http://axgord.github.io/Pony/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---