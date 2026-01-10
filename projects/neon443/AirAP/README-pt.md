
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
        <img src="https://files.catbox.moe/f4jofb.png" title="ícone" alt="ícone" width="100" />
    </p>
    <p>
        use seu iphone como um receptor airplay
        <br/>
        <a href="https://neon443.github.io">
            feito por neon443
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
         alt="Este projeto faz parte do Shipwrecked, o primeiro hackathon do mundo em uma ilha!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP é um servidor AirPlay totalmente nativo, escrito em Swift, para iOS. Essencialmente, o AirAP permite que você use seu iPhone como receptor AirPlay no iTunes ou no seu Mac, ou seja, você pode usar seu iPhone para reproduzir o som do seu dispositivo.

## O que é o AirAP?

Você já quis transmitir áudio do seu Mac, Apple TV ou outro dispositivo iOS para o seu iPhone? O AirAP torna isso possível implementando um servidor AirPlay completo que roda nativamente no iOS. Uma vez instalado, seu iPhone aparecerá como um destino AirPlay disponível no painel de Áudio das Preferências do Sistema, no Music.app ou em qualquer outro aplicativo compatível com AirPlay.

O conceito pode parecer invertido à primeira vista — afinal, estamos acostumados a transmitir do nosso iPhone para outros dispositivos. Mas há surpreendentemente muitos cenários em que você gostaria de fazer o contrário. Talvez você esteja trabalhando no Mac tarde da noite e queira direcionar o áudio para o iPhone com fones de ouvido para não incomodar ninguém (oi 👋). Talvez você seja um desenvolvedor testando aplicativos de áudio e precise alternar rapidamente entre diferentes dispositivos de saída. Ou talvez você só queira reaproveitar aquela velha caixa de som com fio.

## Instalando o AirAP

Para experimentar, [abra este link do TestFlight](https://testflight.apple.com/join/8aeqD8Q2), instale o AirAP e siga as instruções. Após a instalação, basta abrir o AirAP e garantir que seu iPhone esteja conectado à mesma rede Wi-Fi do dispositivo do qual deseja transmitir. Seu iPhone aparecerá automaticamente nas listas de dispositivos AirPlay, pronto para receber áudio — se não aparecer, tente reiniciar o aplicativo.

## Compilando

Certifique-se de ter o [homebrew](https://brew.sh)
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