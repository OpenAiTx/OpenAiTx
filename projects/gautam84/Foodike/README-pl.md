
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

![GitHub Cards Preview](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike to prosta, łatwa w użyciu aplikacja do zamawiania jedzenia. Została stworzona z wykorzystaniem Android-Jetpack Compose i opiera się na zasadach MVVM z nowoczesnymi komponentami architektury Androida.

## Demo 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## Zrzuty ekranu 📱 
Onboarding | Logowanie | Strona główna | Szczegóły | Historia | Koszyk | Profil
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Stworzone z użyciem 🛠

- [Kotlin](https://kotlinlang.org/) - Pierwszorzędny i oficjalny język programowania dla Androida.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose to nowoczesny zestaw narzędzi Androida do budowania natywnego interfejsu użytkownika.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Korutyna to wzorzec projektowy do współbieżności, którego możesz użyć na Androidzie, aby uprościć kod wykonywany asynchronicznie.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow to asynchroniczna wersja Sequence, czyli typu kolekcji, której wartości są wyliczane leniwie.
- [Komponenty Architektury Androida](https://developer.android.com/topic/libraries/architecture) - Zbiór bibliotek pomagających projektować solidne, testowalne i łatwe w utrzymaniu aplikacje.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow to obserwowalny przepływ przechowujący stan, który emituje bieżące i nowe aktualizacje stanu do swoich kolektorów.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow to asynchroniczna wersja Sequence, czyli typu kolekcji, której wartości są wyliczane leniwie.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Przechowuje dane związane z interfejsem użytkownika, które nie są niszczone przy zmianach UI.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Komponent nawigacji zapewniający wsparcie dla aplikacji Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore to rozwiązanie do przechowywania danych, umożliwiające zapisywanie par klucz-wartość lub obiektów typowanych z wykorzystaniem protokołów buforowych. DataStore używa korutyn Kotlin i Flow do asynchronicznego, spójnego i transakcyjnego przechowywania danych.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt to biblioteka do wstrzykiwania zależności w Androidzie, która redukuje ilość kodu wymaganego do ręcznego wstrzykiwania zależności w projekcie. Ręczne wstrzykiwanie wymaga konstruowania każdej klasy i jej zależności ręcznie oraz używania kontenerów do zarządzania i ponownego użycia zależności.
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - Począwszy od Androida 12, SplashScreen API pozwala uruchamiać aplikacje z animacją, w tym z animacją przejścia, ekranem powitalnym z ikoną aplikacji i płynnym przejściem do aplikacji. SplashScreen to okno, które przykrywa aktywność.
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Modularne i konfigurowalne komponenty Material Design UI dla Androida.
- [Figma](https://figma.com/) - Figma to edytor grafiki wektorowej i narzędzie do prototypowania, działające głównie w przeglądarce internetowej.

## Architektura 🗼















Ta aplikacja wykorzystuje architekturę [***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Narzędzie do budowania 🧰
Aby zbudować ten projekt, potrzebujesz [Android Studio Beta 3 lub nowszego](https://developer.android.com/studio/preview).

## Kontakt 📩

Chcesz się ze mną skontaktować? Napisz do mnie na 👇

Wyślij maila na:- gautamhazarika01@gmail.com

Moje portfolio:- www.gautamhz.com

## Wsparcie 💰

Jeśli ten projekt pomógł Ci skrócić czas tworzenia, możesz postawić mi kawę :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Licencja 🔖

```

MIT License

Copyright (c) 2026 Gautam Hazarika

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



```

## Backend:

Tworzę backend w pełni w języku Kotlin, używając ktor [tutaj](https://github.com/gautam84/foodike-backend).


## Kolejne kroki:

- Zintegrować backend z aplikacją na Androida.
- Zaktualizować każdy fragment kodu do najnowszej wersji.
- Napisać testy jednostkowe, testy integracyjne oraz testy UI/End-to-End.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---