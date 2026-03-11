<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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
        используйте свой iPhone в качестве приемника AirPlay
        <br/>

        <a href="https://neon443.github.io">
            создано neon443
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
         alt="Этот проект является частью Shipwrecked, первого в мире хакатона на острове!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP — это полностью нативный сервер AirPlay, написанный на Swift для iOS. По сути, AirAP позволяет использовать ваш iPhone как приёмник AirPlay в iTunes или на Mac, что значит, что вы можете использовать свой iPhone для воспроизведения звука устройства.

## Что такое AirAP?

Вы когда-нибудь хотели передавать аудио со своего Mac, Apple TV или другого iOS-устройства на iPhone? AirAP делает это возможным, реализуя полноценный сервер AirPlay, который работает нативно на iOS. После установки ваш iPhone будет отображаться как доступное устройство AirPlay в разделе «Аудио» Системных настроек, в Music.app или любом другом приложении, поддерживающем AirPlay.

Концепция может показаться необычной — ведь обычно мы стримим с iPhone на другие устройства. Но на удивление много сценариев, когда нужно сделать наоборот. Возможно, вы работаете на Mac поздно ночью и хотите направить звук на iPhone с наушниками, чтобы никого не побеспокоить (привет 👋). Или вы разработчик, тестирующий аудиоприложения и вам нужно быстро переключаться между разными устройствами вывода. А может, вы просто хотите использовать старую проводную колонку.

## Установка AirAP

Чтобы попробовать, [откройте эту ссылку TestFlight](https://testflight.apple.com/join/8aeqD8Q2), установите AirAP и следуйте инструкциям. После установки просто запустите AirAP и убедитесь, что ваш iPhone подключён к той же Wi-Fi сети, что и устройство, с которого вы хотите передавать звук. Ваш iPhone автоматически появится в списке устройств AirPlay, готовый к приёму аудио — если этого не произошло, попробуйте перезапустить приложение.

## Сборка

Убедитесь, что у вас установлен [homebrew](https://brew.sh)
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