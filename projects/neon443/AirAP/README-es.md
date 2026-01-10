
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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
        <img src="https://files.catbox.moe/f4jofb.png" title="icono" alt="icono" width="100" />
    </p>
    <p>
        usa tu iphone como receptor airplay
        <br/>
        <a href="https://neon443.github.io">
            hecho por neon443
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
         alt="¡Este proyecto es parte de Shipwrecked, el primer hackathon del mundo en una isla!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP es un servidor AirPlay totalmente nativo, escrito en Swift, para iOS. Esencialmente, AirAP te permite usar tu iPhone como receptor AirPlay en iTunes o en tu Mac, lo que significa que puedes usar tu iPhone para reproducir el sonido de tu dispositivo.

## ¿Qué es AirAP?

¿Alguna vez has querido transmitir audio desde tu Mac, Apple TV u otro dispositivo iOS a tu iPhone? AirAP hace esto posible implementando un servidor AirPlay completo que se ejecuta de forma nativa en iOS. Una vez instalado, tu iPhone aparecerá como un destino AirPlay disponible en el panel de audio de Preferencias del Sistema, en la app Música o en cualquier otra aplicación compatible con AirPlay.

El concepto puede parecer al revés al principio; después de todo, estamos acostumbrados a transmitir desde nuestros iPhones hacia otros dispositivos. Pero sorprendentemente hay muchos escenarios donde querrías hacer lo contrario. Tal vez trabajas en tu Mac hasta tarde y quieres enviar el audio a tu iPhone con auriculares para no molestar a nadie (¡hola 👋!). Quizás eres desarrollador probando aplicaciones de audio y necesitas cambiar rápidamente entre diferentes dispositivos de salida. O tal vez solo quieres reutilizar ese viejo altavoz con cable.

## Instalando AirAP

Para probarlo, [abre este enlace de TestFlight](https://testflight.apple.com/join/8aeqD8Q2), instala AirAP y sigue las instrucciones. Después de la instalación, simplemente inicia AirAP y asegúrate de que tu iPhone esté conectado a la misma red Wi-Fi que el dispositivo desde el que deseas transmitir. Tu iPhone aparecerá automáticamente en las listas de dispositivos AirPlay, listo para recibir audio; si no aparece, intenta reiniciar la app.

## Compilando

Asegúrate de tener [homebrew](https://brew.sh)
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