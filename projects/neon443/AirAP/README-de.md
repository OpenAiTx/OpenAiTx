
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>

</div>

<div align="center"> 
    <br/>
    <p>
        <img src="https://github.com/neon443/AirAP/blob/main/Icon/icon.png?raw=true" title="icon" alt="icon" width="100" />
    </p>
    <p>
        benutze dein iPhone als AirPlay-Empfänger
        <br/>
        <a href="https://neon443.github.io">
            erstellt von neon443
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            testflight
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="Dieses Projekt ist Teil von Shipwrecked, dem weltweit ersten Hackathon auf einer Insel!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP ist ein vollständig nativer AirPlay-Server, geschrieben in Swift, für iOS. Im Wesentlichen ermöglicht AirAP, Ihr iPhone als AirPlay-Empfänger in iTunes oder auf Ihrem Mac zu verwenden, sodass Sie Ihr iPhone nutzen können, um den Ton Ihres Geräts abzuspielen.

## Was ist AirAP?

Haben Sie jemals gewünscht, Audio von Ihrem Mac, Apple TV oder einem anderen iOS-Gerät auf Ihr iPhone zu streamen? AirAP macht dies möglich, indem es einen vollständigen AirPlay-Server bereitstellt, der nativ auf iOS läuft. Nach der Installation erscheint Ihr iPhone als verfügbare AirPlay-Ziel im Bereich "Audio" der Systemeinstellungen, in der Musik-App oder jeder anderen AirPlay-kompatiblen App.

Das Konzept mag auf den ersten Blick seltsam erscheinen – schließlich sind wir es gewohnt, von unseren iPhones auf andere Geräte zu streamen. Doch es gibt überraschend viele Szenarien, in denen Sie genau das Gegenteil möchten. Vielleicht arbeiten Sie spät abends an Ihrem Mac und möchten den Ton auf Ihr iPhone mit Kopfhörern umleiten, um niemanden zu stören (hallo 👋). Vielleicht sind Sie Entwickler und testen Audio-Anwendungen und müssen schnell zwischen verschiedenen Ausgabegeräten wechseln. Oder Sie möchten einfach nur einen alten kabelgebundenen Lautsprecher weiterverwenden.

## AirAP installieren

Um es auszuprobieren, [öffnen Sie diesen TestFlight-Link](https://testflight.apple.com/join/8aeqD8Q2), installieren Sie AirAP und folgen Sie den Anweisungen. Nach der Installation starten Sie einfach AirAP und stellen sicher, dass Ihr iPhone mit demselben WLAN-Netzwerk wie das Quellgerät verbunden ist. Ihr iPhone erscheint automatisch in den AirPlay-Gerätelisten und ist bereit, Audio zu empfangen – falls nicht, versuchen Sie, die App neu zu starten.

## Kompilieren

Stellen Sie sicher, dass Sie [homebrew](https://brew.sh) haben
```
brew install carthage
git clone https://github.com/neon443/AirAP
cd AirAP
carthage checkout
open AirAP.xcodeproj
```
After adding your Team ID in Project > AirAP > Signing and Capabilities, hit `Command + R` to build and run! 

### thanks to

[qasim/Airstream](https://github.com/qasim/Airstream)
[shairplay](https://github.com/juhovh/shairplay)
would not have been possible without these

---

<sup>
&copy; 2025 Nihaal Sharma. AirPlay, iPhone, iTunes, Mac, and Apple TV are trademarks of Apple Inc.
</sup>






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---