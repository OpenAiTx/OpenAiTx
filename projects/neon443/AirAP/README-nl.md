
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=neon443&project=AirAP&lang=id">Indonesisch</a>
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
    <img src="https://github.com/neon443/AirAP/blob/main/Icon/shipwrecked.png?raw=true" 
         alt="Dit project maakt deel uit van Shipwrecked, 's werelds eerste hackathon op een eiland!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP is een volledig native AirPlay-server, geschreven in Swift, voor iOS. In wezen stelt AirAP je in staat je iPhone als AirPlay-ontvanger te gebruiken in iTunes of op je Mac, wat betekent dat je je iPhone kunt gebruiken om het geluid van je apparaat af te spelen.

## Wat is AirAP?

Heb je ooit audio willen streamen van je Mac, Apple TV, of een ander iOS-apparaat naar je iPhone? AirAP maakt dit mogelijk door een volledige AirPlay-server te implementeren die native draait op iOS. Na installatie verschijnt je iPhone als een beschikbare AirPlay-bestemming in het Audio-paneel van Systeemvoorkeuren, Muziek.app, of elke andere AirPlay-compatibele app.

Het concept lijkt misschien omgekeerd - we zijn immers gewend om vanaf onze iPhones naar andere apparaten te streamen. Maar er zijn verrassend veel scenario's waarin je juist het omgekeerde wilt. Misschien werk je 's avonds laat op je Mac en wil je het geluid naar je iPhone met koptelefoon sturen zodat je niemand stoort (hoi 👋). Of je bent een ontwikkelaar die audio-applicaties test en snel tussen verschillende uitvoerapparaten wilt wisselen. Of je wilt gewoon die oude bedrade speaker nieuw leven inblazen.

## Installeren van AirAP

Om het uit te proberen, [open deze TestFlight-link](https://testflight.apple.com/join/8aeqD8Q2), installeer AirAP en volg de instructies. Na installatie hoef je alleen AirAP te starten en te zorgen dat je iPhone verbonden is met hetzelfde Wi-Fi-netwerk als het apparaat waarvan je wilt streamen. Je iPhone verschijnt automatisch in de AirPlay-apparaatlijsten, klaar om audio te ontvangen - als dit niet gebeurt, probeer dan de app opnieuw te starten.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---