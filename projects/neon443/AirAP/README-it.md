
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
        usa il tuo iphone come ricevitore airplay
        <br/>
        <a href="https://neon443.github.io">
            creato da neon443
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
         alt="Questo progetto fa parte di Shipwrecked, il primo hackathon al mondo su un'isola!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP è un server AirPlay completamente nativo, scritto in Swift, per iOS. Fondamentalmente, AirAP ti permette di utilizzare il tuo iPhone come ricevitore AirPlay in iTunes o sul tuo Mac, il che significa che puoi usare il tuo iPhone per riprodurre l’audio del tuo dispositivo.

## Cos'è AirAP?

Hai mai desiderato trasmettere audio dal tuo Mac, Apple TV o un altro dispositivo iOS al tuo iPhone? AirAP lo rende possibile implementando un server AirPlay completo che funziona nativamente su iOS. Una volta installato, il tuo iPhone comparirà come destinazione AirPlay disponibile nel pannello Audio delle Preferenze di Sistema, in Musica.app o in qualsiasi altra app compatibile con AirPlay.

Il concetto potrebbe sembrare inverso all’inizio – dopotutto, siamo abituati a trasmettere dai nostri iPhone verso altri dispositivi. Ma ci sono sorprendentemente molti scenari in cui vorresti fare il contrario. Magari stai lavorando al Mac a tarda notte e vuoi deviare l’audio sull’iPhone con le cuffie per non disturbare nessuno (ciao 👋). Forse sei uno sviluppatore che testa applicazioni audio e hai bisogno di cambiare rapidamente tra diversi dispositivi di uscita. Oppure vuoi semplicemente riutilizzare quel vecchio altoparlante cablato.

## Installare AirAP

Per provarlo, [apri questo link TestFlight](https://testflight.apple.com/join/8aeqD8Q2), installa AirAP e segui le istruzioni. Dopo l’installazione, avvia semplicemente AirAP e assicurati che il tuo iPhone sia connesso alla stessa rete Wi-Fi del dispositivo da cui vuoi trasmettere. Il tuo iPhone apparirà automaticamente nelle liste dei dispositivi AirPlay, pronto a ricevere l’audio – se non appare, prova a riavviare l’app.

## Compilazione

Assicurati di avere [homebrew](https://brew.sh)
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