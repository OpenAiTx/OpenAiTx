<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=vi">Vietnamees</a>
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
        gebruik je iPhone als een AirPlay-ontvanger
        <br/>
        <a href="https://neon443.github.io">
            gemaakt door neon443
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
         alt="Dit project is onderdeel van Shipwrecked, 's werelds eerste hackathon op een eiland!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP is een volledig native AirPlay-server, geschreven in Swift, voor iOS. In essentie stelt AirAP je in staat om je iPhone als AirPlay-ontvanger te gebruiken in iTunes of op je Mac, wat betekent dat je je iPhone kunt gebruiken om het geluid van je apparaat af te spelen.

## Wat is AirAP?

Heb je ooit gewenst om audio van je Mac, Apple TV of een ander iOS-apparaat naar je iPhone te streamen? AirAP maakt dit mogelijk door een volledige AirPlay-server te implementeren die native op iOS draait. Na installatie verschijnt je iPhone als een beschikbare AirPlay-bestemming in het audio-paneel van Systeemvoorkeuren, in de Muziek-app, of elke andere AirPlay-compatibele app.

Het concept lijkt misschien in eerste instantie omgekeerd – we zijn tenslotte gewend om vanaf onze iPhones naar andere apparaten te streamen. Maar er zijn verrassend veel scenario's waarin je juist het omgekeerde wilt doen. Misschien werk je 's avonds laat op je Mac en wil je het geluid via je iPhone met koptelefoon horen zodat je niemand stoort (hoi 👋). Of je bent een ontwikkelaar die audio-applicaties test en snel wilt wisselen tussen verschillende uitvoerapparaten. Of misschien wil je gewoon die oude bekabelde speaker hergebruiken.

## AirAP installeren

Om het uit te proberen, [open deze TestFlight-link](https://testflight.apple.com/join/8aeqD8Q2), installeer AirAP en volg de instructies. Na installatie start je AirAP en zorg je ervoor dat je iPhone is verbonden met hetzelfde wifi-netwerk als het apparaat waarvan je wilt streamen. Je iPhone verschijnt automatisch in de AirPlay-apparaatlijst, klaar om audio te ontvangen – als dit niet het geval is, probeer dan de app opnieuw te starten.

## Compileren

Zorg ervoor dat je [homebrew](https://brew.sh) hebt

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