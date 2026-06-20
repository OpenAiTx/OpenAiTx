![GitHub Cards Preview](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike est une application de livraison de nourriture simple et facile à utiliser. Elle est développée avec Android-Jetpack Compose et repose sur le principe MVVM avec les composants modernes de l’architecture Android.

## Démo 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## Captures d’écran 📱 
Onboarding | Connexion | Accueil | Détails | Historique | Panier | Profil
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Construit avec 🛠

- [Kotlin](https://kotlinlang.org/) - Langage de programmation officiel et de première classe pour le développement Android.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose est la boîte à outils moderne d’Android pour créer des interfaces utilisateur natives.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Une coroutine est un modèle de conception pour la concurrence que vous pouvez utiliser sur Android pour simplifier le code qui s’exécute de manière asynchrone.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow est une version asynchrone d’une Sequence, un type de collection dont les valeurs sont produites paresseusement.
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) - Collection de bibliothèques qui vous aident à concevoir des applications robustes, testables et maintenables.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow est un flow observable détenteur d’état qui émet l’état actuel et les mises à jour d’état aux collecteurs.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Un flow est une version asynchrone d’une Sequence, un type de collection dont les valeurs sont produites paresseusement.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Stocke les données liées à l’interface utilisateur qui ne sont pas détruites lors des changements d’UI.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Le composant Navigation fournit un support pour les applications Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore est une solution de stockage de données qui vous permet de stocker des paires clé-valeur ou des objets typés avec des protocol buffers. DataStore utilise les coroutines Kotlin et Flow pour stocker les données de manière asynchrone, cohérente et transactionnelle.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt est une bibliothèque d’injection de dépendances pour Android qui réduit le code répétitif lié à l’injection manuelle de dépendances dans votre projet. Faire une injection manuelle nécessite de construire chaque classe et ses dépendances à la main, et d’utiliser des conteneurs pour réutiliser et gérer les dépendances.













  
- [API Splash](https://developer.android.com/develop/ui/views/launch/splash-screen) - À partir d'Android 12, l'API SplashScreen permet aux applications de démarrer avec une animation, incluant un mouvement intégré lors du lancement, un écran splash affichant l'icône de votre application, et une transition vers l'application elle-même. Un SplashScreen est une fenêtre et couvre donc une activité.
- [Composants Material pour Android](https://github.com/material-components/material-components-android)
  - Composants UI Material Design modulaires et personnalisables pour Android.
- [Figma](https://figma.com/) - Figma est un éditeur de graphiques vectoriels et un outil de prototypage principalement basé sur le web.

## Architecture 🗼

Cette application utilise l'architecture [***MVVM (Modèle Vue
Modèle-Vue)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Outil de construction 🧰
Vous devez avoir [Android Studio Beta 3 ou supérieur](https://developer.android.com/studio/preview) pour construire ce projet.

## Contact 📩

Vous voulez me contacter ? Envoyez-moi un message direct 👇

Envoyez un mail à :- gautamhazarika01@gmail.com

Mon Portfolio :- www.gautamhz.com

## Donation 💰

Si ce projet vous aide à réduire le temps de développement, vous pouvez m'offrir un café :)

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---