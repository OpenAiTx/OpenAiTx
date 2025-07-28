<p align="center">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot1.png" width="270" alt="Capture d'écran 1">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot2.png" width="270" alt="Capture d'écran 2">
  <img src="https://raw.githubusercontent.com/cliuff/boundo/main/doconfig/markdown/shot3.png" width="270" alt="Capture d'écran 3">
</p>

# Boundo Meta-app : Infos & Gestionnaire

Boundo Meta-app concerne toutes vos applications et bien plus encore.  
Consultez les infos des applications sur votre téléphone, et organisez-les en catégories.  
Conçu pour les passionnés d'Android, Meta-app est disponible sur **Android** et **Wear OS**.

### 1. Développement
**1.1 Prérequis**
- Android Studio `Meerkat` (AGP `8.9`)
- Java `17`, Kotlin `2.1.21`, Gradle `8.13`

**1.2 Configurer la signature automatique**
- **Copiez** le fichier nommé `custom.properties.template` dans le répertoire `doconfig`,
  **renommez**-le en `custom.properties` et effectuez les **modifications** nécessaires

**1.3 Générer des APK universels (fonction App API incluse, variante release)**
- Configurez la signature comme indiqué à la section 1.2
- Téléchargez le binaire BundleTool depuis [BundleTool Releases](https://github.com/google/bundletool/releases),
  et enregistrez-le sous `doconfig/bundletool.jar` dans ce projet
- Exécutez la tâche Gradle en ligne de commande `gradlew :app:genUniversalApks`
- Cherchez `app/build/outputs/app-universal-release.apks` dans ce projet

**1.4 Générer la version FOSS (moins de fonctionnalités)**
- Configurez la signature comme indiqué à la section 1.2
- Téléchargez le binaire BundleTool depuis [BundleTool Releases](https://github.com/google/bundletool/releases),
  et enregistrez-le sous `doconfig/bundletool.jar` dans ce projet
- Exécutez la tâche Gradle en ligne de commande `gradlew :app:genFossApks`
- Cherchez `app/build/outputs/app-universal-foss.apks` dans ce projet

### 2. Télécharger
[<img alt='Obtenez-le sur Google Play' src='https://play.google.com/intl/en_us/badges/static/images/badges/en_badge_web_generic.png' height='100'/>](https://raw.githubusercontent.com/cliuff/boundo/main/
https://play.google.com/store/apps/details?id=com.madness.collision&pcampaignid=pcampaignidMKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---