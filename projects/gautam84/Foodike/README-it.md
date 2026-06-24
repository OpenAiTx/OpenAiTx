
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
Foodike è un'app di consegna cibo semplice e facile da usare. È costruita utilizzando Android-Jetpack Compose e si basa sul principio MVVM con i Componenti Moderni dell'Architettura Android.

## Demo 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## Screenshot 📱 
Onboarding | Login | Home | Dettagli | Cronologia | Carrello | Profilo
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Realizzato con 🛠

- [Kotlin](https://kotlinlang.org/) - Linguaggio di programmazione ufficiale e di prima classe per lo sviluppo Android.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose è il toolkit moderno di Android per costruire interfacce utente native.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Una coroutine è un pattern di progettazione per la concorrenza che puoi usare su Android per semplificare il codice che esegue in modo asincrono.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow è una versione asincrona di una Sequence, un tipo di collezione i cui valori sono prodotti in modo lazy.
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) -
  Collezione di librerie che ti aiutano a progettare app robuste, testabili e manutenibili.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow è un flow osservabile che mantiene lo stato e che emette aggiornamenti correnti e nuovi ai suoi collector.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow è una versione asincrona di una Sequence, un tipo di collezione i cui valori sono prodotti in modo lazy.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Memorizza i dati relativi all'interfaccia utente che non vengono distrutti durante i cambiamenti della UI.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Il componente di Navigazione fornisce il supporto per applicazioni Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore è una soluzione di archiviazione dati che consente di memorizzare coppie chiave-valore o oggetti tipizzati con protocol buffers. DataStore utilizza Kotlin coroutines e Flow per archiviare i dati in modo asincrono, coerente e transazionale.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt è una libreria di dependency injection per Android che riduce il boilerplate dell'iniezione manuale delle dipendenze nel tuo progetto. L'iniezione manuale delle dipendenze richiede di costruire ogni classe e le sue dipendenze a mano, e di usare contenitori per riutilizzare e gestire le dipendenze.
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - A partire da Android 12, la SplashScreen API permette alle app di avviarsi con animazioni, inclusi movimenti introduttivi all'avvio, una schermata splash che mostra l'icona della tua app e una transizione verso la tua applicazione. Una SplashScreen è una finestra e quindi copre una Activity.
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Componenti UI Material Design modulari e personalizzabili per Android.
- [Figma](https://figma.com/) - Figma è un editor di grafica vettoriale e uno strumento di prototipazione prevalentemente basato sul web.

## Architettura 🗼














Questa app utilizza l’architettura [***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Strumento di compilazione 🧰
Devi avere [Android Studio Beta 3 o superiore](https://developer.android.com/studio/preview) per compilare questo progetto.

## Contatti 📩

Vuoi metterti in contatto con me? Scrivimi in DM 👇

Invia una mail a:- gautamhazarika01@gmail.com

Il mio Portfolio:- www.gautamhz.com

## Donazione 💰

Se questo progetto ti aiuta a ridurre il tempo di sviluppo, puoi offrirmi un caffè :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Licenza 🔖

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

Sto sviluppando il backend interamente in Kotlin utilizzando Ktor [qui](https://github.com/gautam84/foodike-backend).


## Prossimi Passi:

- Integrare il backend nell'app Android.
- Aggiornare ogni parte del codice all'ultima versione.
- Scrivere test unitari, test di integrazione e test UI/End-to-End.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---