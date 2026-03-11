
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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
        użyj swojego iPhone'a jako odbiornika AirPlay
        <br/>
        <a href="https://neon443.github.io">
            wykonane przez neon443
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
         alt="Ten projekt jest częścią Shipwrecked, pierwszego na świecie hackathonu na wyspie!" 
         style="width: 25%;">
  </a>
</div>

<br/>

AirAP to w pełni natywny serwer AirPlay, napisany w Swift, dla iOS. Zasadniczo AirAP pozwala używać iPhone'a jako odbiornika AirPlay w iTunes lub na Macu, co oznacza, że możesz używać swojego iPhone'a do odtwarzania dźwięku z urządzenia.

## Co to jest AirAP?

Czy kiedykolwiek chciałeś przesyłać dźwięk z Maca, Apple TV lub innego urządzenia iOS na swojego iPhone'a? AirAP to umożliwia, implementując pełny serwer AirPlay działający natywnie na iOS. Po zainstalowaniu Twój iPhone pojawi się jako dostępny cel AirPlay w panelu Dźwięk Preferencji Systemowych, aplikacji Muzyka lub dowolnej innej aplikacji zgodnej z AirPlay.

Koncepcja może wydawać się odwrócona – w końcu jesteśmy przyzwyczajeni do przesyłania z iPhone'a na inne urządzenia. Ale istnieje zaskakująco wiele scenariuszy, w których chcesz zrobić odwrotnie. Może pracujesz na Macu późno w nocy i chcesz przekierować dźwięk na iPhone'a ze słuchawkami, by nikogo nie budzić (cześć 👋). Może jesteś deweloperem testującym aplikacje audio i potrzebujesz szybko przełączać się między różnymi urządzeniami wyjściowymi. A może po prostu chcesz dać nowe życie starym przewodowym głośnikom.

## Instalacja AirAP

Aby przetestować, [otwórz ten link do TestFlight](https://testflight.apple.com/join/8aeqD8Q2), zainstaluj AirAP i postępuj zgodnie z instrukcjami. Po instalacji po prostu uruchom AirAP i upewnij się, że Twój iPhone jest połączony z tą samą siecią Wi-Fi co urządzenie, z którego chcesz przesyłać dźwięk. Twój iPhone automatycznie pojawi się na liście urządzeń AirPlay, gotowy do odbioru dźwięku — jeśli nie, spróbuj ponownie uruchomić aplikację.

## Kompilacja

Upewnij się, że masz zainstalowany [homebrew](https://brew.sh)
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