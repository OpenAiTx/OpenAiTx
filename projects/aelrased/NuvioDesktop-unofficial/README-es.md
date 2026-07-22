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
    Un centro multimedia moderno para Android y iOS construido con Kotlin Multiplatform y Compose Multiplatform.
    <br />
    Ecosistema de addons de Stremio • Multiplataforma
  </p>

</div>

## Acerca de

Nuvio es la reescritura actual en Kotlin Multiplatform de la aplicación original en React Native. Proporciona una UI compartida con Compose para Android y iOS mientras mantiene la experiencia centrada en la reproducción, herramientas de colección, flujos de progreso de visualización, descargas e integración con el ecosistema de addons de Stremio que definieron la aplicación anterior.

La aplicación móvil se construye a partir de una única base de código compartida en [composeApp](./composeApp), con puntos de entrada nativos para Android e iOS.

## Instalación

### Android

Descarga la última versión para Android desde [GitHub Releases](https://github.com/NuvioMedia/NuvioMobile/releases/latest).

### iOS

- [TestFlight](https://testflight.apple.com/join/u4y7MHK9)

## Desarrollo

```bash
git clone https://github.com/NuvioMedia/NuvioMobile.git
cd NuvioMobile
./scripts/run-mobile.sh android
# or
./scripts/run-mobile.sh ios
```

### Estructura del Proyecto

- `composeApp/` contiene el código compartido de la aplicación Kotlin Multiplatform y Compose Multiplatform.
- `composeApp/src/commonMain/` contiene UI compartida, funcionalidades, repositorios y lógica independiente de la plataforma.
- `composeApp/src/androidMain/` contiene integraciones específicas para Android.
- `composeApp/src/iosMain/` contiene integraciones específicas para iOS.
- `iosApp/` contiene el proyecto nativo de Xcode y el punto de entrada para iOS.

Comandos útiles:

```bash
./gradlew :composeApp:assembleDebug
./gradlew :composeApp:compileKotlinIosSimulatorArm64
./scripts/build-distribution.sh
```

La versión se gestiona desde `iosApp/Configuration/Version.xcconfig`, que se utiliza como la fuente compartida de verdad tanto para las compilaciones de iOS como de Android.

## Legal y DMCA

Nuvio funciona únicamente como una interfaz del lado del cliente para navegar por metadatos y reproducir medios proporcionados por extensiones instaladas por el usuario y/o fuentes proporcionadas por el usuario. Está destinado para contenido que el usuario posee o para el cual está autorizado a acceder.

Nuvio no está afiliado a ninguna extensión, catálogo, fuente o proveedor de contenido de terceros. No aloja, almacena ni distribuye ningún contenido multimedia.

Para información legal completa, incluyendo nuestro descargo de responsabilidad completo, política de extensiones de terceros e información sobre DMCA/Derechos de autor, por favor visite nuestra [Página Legal y de Descargo de Responsabilidad](https://nuvioapp.space/legal).

## Construido con

- Kotlin Multiplatform
- Compose Multiplatform
- Kotlin
- AndroidX Media3
- AVFoundation e integraciones nativas de iOS

## Historial de estrellas

<a href="https://www.star-history.com/#NuvioMedia/NuvioMobile&type=date&legend=top-left">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&theme=dark&legend=top-left" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
   <img alt="Gráfico de Historial de Estrellas" src="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
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