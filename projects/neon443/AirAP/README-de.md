
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
        <img src="https://files.catbox.moe/f4jofb.png" title="icon" alt="icon" width="100" />
    </p>
    <p>
        nutze dein iPhone als AirPlay-Empfänger
        <br/>
        <a href="https://neon443.github.io">
            erstellt von neon443
        </a>
    </p>
    <p>
        <a href="https://testflight.apple.com/join/8aeqD8Q2">
            TestFlight
        </a>
    </p>
    <br/>
</div>

<div align="center">
  <a href="https://shipwrecked.hackclub.com/?t=ghrm" target="_blank">
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="Dieses Projekt ist Teil von Shipwrecked, dem weltweit ersten Hackathon auf einer Insel!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP ist ein vollständig nativer AirPlay-Server, geschrieben in Swift, für iOS. Im Wesentlichen ermöglicht AirAP, Ihr iPhone als AirPlay-Empfänger in iTunes oder auf Ihrem Mac zu verwenden, sodass Sie Ihr iPhone nutzen können, um den Sound Ihres Geräts abzuspielen.

## Was ist AirAP?

Haben Sie jemals gewünscht, Audio von Ihrem Mac, Apple TV oder einem anderen iOS-Gerät auf Ihr iPhone zu streamen? AirAP macht dies möglich, indem es einen vollständigen AirPlay-Server implementiert, der nativ auf iOS läuft. Nach der Installation erscheint Ihr iPhone als verfügbares AirPlay-Ziel im Audio-Bereich der Systemeinstellungen, in der Musik-App oder jeder anderen AirPlay-kompatiblen Anwendung.

Das Konzept mag zunächst rückwärts erscheinen – schließlich sind wir es gewohnt, von unseren iPhones auf andere Geräte zu streamen. Aber es gibt überraschend viele Szenarien, in denen man das Gegenteil möchte. Vielleicht arbeiten Sie spät abends an Ihrem Mac und möchten den Ton auf Ihr iPhone mit Kopfhörern umleiten, damit Sie niemanden stören (hi 👋). Vielleicht sind Sie ein Entwickler, der Audio-Anwendungen testet und schnell zwischen verschiedenen Ausgabegeräten wechseln muss. Oder Sie möchten einfach nur diesen alten kabelgebundenen Lautsprecher neu verwenden.

## Installation von AirAP

Um es auszuprobieren, [öffnen Sie diesen TestFlight-Link](https://testflight.apple.com/join/8aeqD8Q2), installieren Sie AirAP und folgen Sie den Anweisungen. Nach der Installation starten Sie einfach AirAP und stellen sicher, dass Ihr iPhone mit demselben WLAN-Netzwerk wie das Gerät verbunden ist, von dem Sie streamen möchten. Ihr iPhone erscheint automatisch in den AirPlay-Gerätelisten und ist bereit, Audio zu empfangen – falls nicht, versuchen Sie, die App neu zu starten.

## Kompilieren

Stellen Sie sicher, dass Sie [Homebrew](https://brew.sh) haben
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---