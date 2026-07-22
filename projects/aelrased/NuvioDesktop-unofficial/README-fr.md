<div align="center">

  <img src="https://github.com/tapframe/NuvioTV/blob/main/assets/brand/app_logo_wordmark.png" alt="Nuvio" width="300" />
  <br />
  <br />

  [![Contributors][contributors-shield]][contributors-url]
  [![Forks][forks-shield]][forks-url]
  [![Stargazers][stars-shield]][stars-url]
  [![Issues][issues-shield]][issues-url]
  [![License][license-shield]][license-url]

  <p>
    Un hub média moderne pour Android et iOS construit avec Kotlin Multiplatform et Compose Multiplatform.
    <br />
    Écosystème d’extensions Stremio • Multi-plateforme
  </p>

</div>

## À propos

Nuvio est la réécriture actuelle en Kotlin Multiplatform de l’application originale React Native. Il offre une interface utilisateur Compose partagée pour Android et iOS tout en conservant l’expérience centrée sur la lecture, les outils de gestion de collection, les flux de progression de visionnage, les téléchargements et l’intégration de l’écosystème d’extensions Stremio qui ont façonné l’application précédente.

L’application mobile est construite à partir d’une base de code partagée unique dans [composeApp](./composeApp), avec des points d’entrée natifs pour Android et iOS.

## Installation

### Android

Téléchargez la dernière version Android depuis [GitHub Releases](https://github.com/NuvioMedia/NuvioMobile/releases/latest).

### iOS

- [TestFlight](https://testflight.apple.com/join/u4y7MHK9)

## Développement

```bash
git clone https://github.com/NuvioMedia/NuvioMobile.git
cd NuvioMobile
./scripts/run-mobile.sh android
# or
./scripts/run-mobile.sh ios
```

### Structure du projet

- `composeApp/` contient le code partagé de l’application Kotlin Multiplatform et Compose Multiplatform.
- `composeApp/src/commonMain/` contient l’interface utilisateur partagée, les fonctionnalités, les dépôts et la logique indépendante de la plateforme.
- `composeApp/src/androidMain/` contient les intégrations spécifiques à Android.
- `composeApp/src/iosMain/` contient les intégrations spécifiques à iOS.
- `iosApp/` contient le projet natif Xcode et le point d’entrée iOS.

Commandes utiles :

```bash
./gradlew :composeApp:assembleDebug
./gradlew :composeApp:compileKotlinIosSimulatorArm64
./scripts/build-distribution.sh
```
La gestion des versions est pilotée depuis `iosApp/Configuration/Version.xcconfig`, qui est utilisée comme source de vérité partagée pour les builds iOS et Android.

## Légal & DMCA

Nuvio fonctionne uniquement comme une interface côté client pour parcourir les métadonnées et lire les médias fournis par des extensions installées par l'utilisateur et/ou des sources fournies par l'utilisateur. Il est destiné aux contenus que l'utilisateur possède ou est autrement autorisé à accéder.

Nuvio n'est affilié à aucune extension tierce, catalogue, source ou fournisseur de contenu. Il n'héberge, ne stocke ni ne distribue aucun contenu média.

Pour des informations légales complètes, y compris notre clause de non-responsabilité complète, notre politique sur les extensions tierces et les informations DMCA/droits d'auteur, veuillez visiter notre [Page Légale & Clause de Non-Responsabilité](https://nuvioapp.space/legal).

## Construit avec

- Kotlin Multiplateforme
- Compose Multiplateforme
- Kotlin
- AndroidX Media3
- AVFoundation et intégrations natives iOS

## Historique des Étoiles

<a href="https://www.star-history.com/#NuvioMedia/NuvioMobile&type=date&legend=top-left">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&theme=dark&legend=top-left" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
   <img alt="Graphique Historique des Étoiles" src="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
 </picture>
</a>

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[contributors-url]: https://github.com/NuvioMedia/NuvioMobile/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[forks-url]: https://github.com/NuvioMedia/NuvioMobile/network/members
[stars-shield]: https://img.shields.io/github/stars/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[stars-url]: https://github.com/NuvioMedia/NuvioMobile/stargazers
[issues-shield]: https://img.shields.io/github/issues/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[issues-url]: https://github.com/NuvioMedia/NuvioMobile/issues
[license-shield]: https://img.shields.io/github/license/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[license-url]: https://github.com/NuvioMedia/NuvioMobile/blob/main/LICENSE


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---