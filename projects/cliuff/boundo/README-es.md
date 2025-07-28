<p align="center">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot1.png" width="270" alt="Captura de pantalla 1">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot2.png" width="270" alt="Captura de pantalla 2">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot3.png" width="270" alt="Captura de pantalla 3">
</p>

# Boundo Meta-app: Información y Gestor

Boundo Meta-app trata de tus aplicaciones y más allá.  
Consulta información de las apps en tu teléfono y organízalas en categorías.  
Diseñado para entusiastas de Android, Meta-app está disponible en **Android** y **Wear OS**.

### 1. Desarrollar
**1.1 Requisitos**
- Android Studio `Meerkat` (AGP `8.9`)
- Java `17`, Kotlin `2.1.21`, Gradle `8.13`

**1.2 Configurar firma automática**
- **Copia** el archivo llamado `custom.properties.template` en el directorio `doconfig`,
  **renómbralo** a `custom.properties` y realiza los **cambios** necesarios en él

**1.3 Construir APKs universales (función App API incluida, variante release)**
- Configura la firma como se especifica en la sección 1.2
- Descarga el binario BundleTool desde [BundleTool Releases](https://github.com/google/bundletool/releases),
  y guárdalo como `doconfig/bundletool.jar` en este proyecto
- Ejecuta la tarea Gradle desde la línea de comandos `gradlew :app:genUniversalApks`
- Busca `app/build/outputs/app-universal-release.apks` en este proyecto

**1.4 Construir versión FOSS (menos funciones)**
- Configura la firma como se especifica en la sección 1.2
- Descarga el binario BundleTool desde [BundleTool Releases](https://github.com/google/bundletool/releases),
  y guárdalo como `doconfig/bundletool.jar` en este proyecto
- Ejecuta la tarea Gradle desde la línea de comandos `gradlew :app:genFossApks`
- Busca `app/build/outputs/app-universal-foss.apks` en este proyecto

### 2. Descargar
[<img alt='Consíguelo en Google Play' src='https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png' height='100'/>](https://raw.githubusercontent.com/cliuff/boundo/main/
https://play.google.com/store/apps/details?id=com.madness.collision&pcampaignid=pcampaignidMKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---