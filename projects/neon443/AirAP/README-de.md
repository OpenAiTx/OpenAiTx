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
        <img src="https://github.com/neon443/AirAP/blob/main/AirAP/Assets.xcassets/AppIcon.appiconset/Icon.png?raw=true" title="cobalt" alt="cobalt logo" width="100" />
    </p>
    <p>
        benutze dein iPhone als AirPlay-Empfänger
        <br/>
        <a href="https://neon443.github.io">
            gemacht von neon443
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
    <img src="https://hc-cdn.hel1.your-objectstorage.com/s/v3/739361f1d440b17fc9e2f74e49fc185d86cbec14_badge.png" 
         alt="Dieses Projekt ist Teil von Shipwrecked, dem weltweit ersten Hackathon auf einer Insel!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP ist ein vollständig nativer AirPlay-Server, geschrieben in Swift, für iOS. Im Wesentlichen erlaubt AirAP dir, dein iPhone als AirPlay-Empfänger in iTunes oder auf deinem Mac zu verwenden, was bedeutet, dass du den Ton deines Geräts auf deinem iPhone abspielen kannst.

## Was ist AirAP?

Hast du jemals gewünscht, Audio von deinem Mac, Apple TV oder einem anderen iOS-Gerät auf dein iPhone zu streamen? AirAP macht das möglich, indem es einen vollständigen AirPlay-Server implementiert, der nativ auf iOS läuft. Nach der Installation erscheint dein iPhone als verfügbares AirPlay-Ziel im Audio-Bereich der Systemeinstellungen, in der Musik-App oder jeder anderen AirPlay-kompatiblen App.

Das Konzept mag zunächst rückwärts erscheinen – schließlich sind wir es gewohnt, von unseren iPhones auf andere Geräte zu streamen. Aber es gibt überraschend viele Szenarien, in denen du das Gegenteil möchtest. Vielleicht arbeitest du nachts an deinem Mac und möchtest den Ton über Kopfhörer auf dein iPhone umleiten, um niemanden zu stören (hallo 👋). Vielleicht bist du Entwickler und testest Audio-Anwendungen und musst schnell zwischen verschiedenen Ausgabegeräten wechseln. Oder du möchtest einfach nur einen alten kabelgebundenen Lautsprecher wiederverwenden.

## Installation von AirAP

Um es auszuprobieren, [öffne diesen TestFlight-Link](https://testflight.apple.com/join/8aeqD8Q2), installiere AirAP und folge den Anweisungen. Nach der Installation starte AirAP einfach und stelle sicher, dass dein iPhone mit demselben WLAN-Netzwerk verbunden ist wie das Gerät, von dem du streamen möchtest. Dein iPhone erscheint automatisch in AirPlay-Gerätelisten und ist bereit, Audio zu empfangen – falls nicht, starte die App neu.

## Kompilieren

Stelle sicher, dass du [homebrew](https://brew.sh) hast

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---