
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

![Aperçu des cartes GitHub](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike est une application de livraison de nourriture simple et facile à utiliser. Elle est développée avec Android-Jetpack Compose et repose sur le principe MVVM avec les composants d'architecture Android modernes.

## Démo 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## Captures d’écran 📱 
Onboarding | Connexion | Accueil | Détails | Historique | Panier | Profil
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Construit avec 🛠

- [Kotlin](https://kotlinlang.org/) - Langage de programmation officiel et de premier ordre pour le développement Android.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose est l’outil moderne d’Android pour créer des interfaces natives.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Une coroutine est un modèle de conception de concurrence permettant de simplifier le code exécuté de façon asynchrone sur Android.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow est une version asynchrone d’une Sequence, un type de collection dont les valeurs sont produites à la demande.
- [Composants d’architecture Android](https://developer.android.com/topic/libraries/architecture) -
  Ensemble de bibliothèques aidant à concevoir des applications robustes, testables et maintenables.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow est un flow observable qui stocke l’état et émet les mises à jour de l’état actuel et nouveau à ses collecteurs.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow est une version asynchrone d’une Sequence, un type de collection dont les valeurs sont produites à la demande.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Stocke les données liées à l’UI qui ne sont pas détruites lors des changements de l’UI.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Le composant Navigation offre un support pour les applications Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore est une solution de stockage permettant d’enregistrer des paires clé-valeur ou des objets typés avec des protocoles buffers. DataStore utilise les coroutines Kotlin et Flow pour stocker les données de façon asynchrone, cohérente et transactionnelle.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt est une bibliothèque d’injection de dépendances pour Android qui réduit la surcharge du code d’injection manuelle dans votre projet. L’injection manuelle de dépendances nécessite de construire chaque classe et ses dépendances à la main, et d’utiliser des conteneurs pour réutiliser et gérer les dépendances.
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - À partir d’Android 12, l’API SplashScreen permet aux applications de démarrer avec une animation, incluant un mouvement d’entrée lors du lancement, un écran de démarrage affichant l’icône de l’application, et une transition vers l’application elle-même. Un SplashScreen est une fenêtre et recouvre donc une activité.
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Composants UI Material Design modulaires et personnalisables pour Android.
- [Figma](https://figma.com/) - Figma est un éditeur graphique vectoriel et un outil de prototypage principalement basé sur le web.

## Architecture 🗼














Cette application utilise l’architecture [***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Outil de compilation 🧰
Vous devez disposer d’[Android Studio Beta 3 ou supérieur](https://developer.android.com/studio/preview) pour compiler ce projet.

## Contact 📩

Vous souhaitez me contacter ? Envoyez-moi un message 👇

Envoyez un mail à :– gautamhazarika01@gmail.com

Mon portfolio :– www.gautamhz.com

## Donation 💰

Si ce projet vous aide à gagner du temps de développement, vous pouvez m’offrir un café :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Licence 🔖

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

## Backend :

Je développe le backend entièrement en Kotlin en utilisant ktor [ici](https://github.com/gautam84/foodike-backend).


## Prochaines étapes :

- Intégrer le backend à l'application Android.
- Mettre à jour chaque morceau de code vers la dernière version.
- Écrire des tests unitaires, des tests d'intégration et des tests UI/End-to-End.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---