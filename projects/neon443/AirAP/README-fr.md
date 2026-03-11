
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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
        utilisez votre iPhone comme récepteur AirPlay
        <br/>
        <a href="https://neon443.github.io">
            créé par neon443
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
         alt="Ce projet fait partie de Shipwrecked, le premier hackathon au monde sur une île !" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP est un serveur AirPlay entièrement natif, écrit en Swift, pour iOS. En gros, AirAP vous permet d'utiliser votre iPhone comme récepteur AirPlay dans iTunes ou sur votre Mac, ce qui signifie que vous pouvez utiliser votre iPhone pour jouer le son de votre appareil.

## Qu'est-ce qu'AirAP ?

Avez-vous déjà voulu diffuser de l'audio depuis votre Mac, Apple TV, ou un autre appareil iOS vers votre iPhone ? AirAP rend cela possible en implémentant un serveur AirPlay complet qui fonctionne nativement sur iOS. Une fois installé, votre iPhone apparaîtra comme une destination AirPlay disponible dans le panneau Audio des Préférences Système, dans Musique.app, ou toute autre application compatible AirPlay.

Le concept peut paraître à l'envers au début - après tout, nous avons l'habitude de diffuser depuis nos iPhones vers d'autres appareils. Mais il y a étonnamment de nombreux scénarios où vous voudriez faire l'inverse. Peut-être travaillez-vous sur votre Mac tard le soir et souhaitez rediriger l'audio vers votre iPhone avec un casque pour ne déranger personne (coucou 👋). Peut-être êtes-vous développeur et testez des applications audio, ayant besoin de passer rapidement d'un appareil de sortie à un autre. Ou bien vous voulez simplement réutiliser cette vieille enceinte filaire.

## Installer AirAP

Pour l'essayer, [ouvrez ce lien TestFlight](https://testflight.apple.com/join/8aeqD8Q2), installez AirAP, et suivez les instructions. Après l'installation, lancez simplement AirAP et assurez-vous que votre iPhone est connecté au même réseau Wi-Fi que l'appareil à partir duquel vous souhaitez diffuser. Votre iPhone apparaîtra automatiquement dans la liste des appareils AirPlay, prêt à recevoir l'audio - si ce n'est pas le cas, essayez de redémarrer l'application.

## Compilation

Assurez-vous d'avoir [homebrew](https://brew.sh)
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