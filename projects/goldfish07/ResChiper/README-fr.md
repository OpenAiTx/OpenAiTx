# ResChiper

<h1 align="center">
  <img src="https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/reschiper-banner.png" alt="échec du chargement de artifacts/logo.png"/>
  <p align="center" style="font-size: 0.3em">Outil d'Obfuscation des Ressources AAB</p>
</h1>

[![License](https://img.shields.io/badge/license-Apache_2.0-maroon)](LICENSE)
![Android Gradle Plugin](https://img.shields.io/badge/Dependency-AGP/8.8.0-4CAF50)
[![BundleTool](https://img.shields.io/badge/Dependency-Bundletool/1.17.2-red)](https://github.com/google/bundletool)
![JDK Version](https://img.shields.io/badge/JDK-17-blue)
![Gradle Version](https://img.shields.io/badge/Gradle_Wrapper-8.8-darkgreen)
[![ResChiper Version](https://img.shields.io/badge/release-0.1.0--rc6-%23C6782A.svg?style=flat)](https://github.com/goldfish07/ResChiper/releases/tag/0.1.0-rc6)

## Table des Matières

- [Introduction](#introduction)
- [Démarrage](#getting-started)
    - [Exigences](#requirements)
    - [Installation](#installation)
    - [Utilisation](#usage)
- [Options de Configuration](#configuration-options)
- [Exemple](#example)
- [Liste Blanche](#whitelist)
- [Sortie](#output)
- [Remerciements](#acknowledgments)
- [Licence](#license)

## Introduction

ResChiper est un outil conçu pour obfusquer les ressources Android AAB.
Il vous permet de protéger vos ressources contre l'accès non autorisé et de réduire la taille de votre application AAB.

## Démarrage

Suivez ces étapes pour intégrer l'Outil d'Obfuscation des Ressources AAB dans votre projet Android :

## Exigences

Avant de commencer à utiliser ResChiper, assurez-vous que votre application répond aux exigences suivantes :

- **Java Development Kit (JDK)** : ResChiper nécessite JDK 17, assurez-vous que votre application est configurée avec JDK 17.
- **Android Gradle Plugin (AGP)** : version 8.0 ou version ultérieure.

## Installation

#### 1. Ajouter le plugin Gradle ResChiper

Dans le fichier `build.gradle` au niveau racine de votre projet, ajoutez le plugin Gradle ResChiper à la section `buildscript` :

```gradle
buildscript {
  dependencies {
    classpath "io.github.goldfish07.reschiper:plugin:<latest_version>"
  }
  
  repositories {
    mavenCentral()
    google()
   }
}
```

#### 2. Appliquer le Plugin

Dans le fichier `build.gradle` au niveau de votre application, appliquez le plugin ResChiper :

```gradle
apply plugin: "io.github.goldfish07.reschiper"
```

#### 3. Configurer le Plugin

Dans votre fichier `app/build.gradle`, configurez le plugin ResChiper en spécifiant les paramètres souhaités. Voici un exemple
de configuration :

```gradle
resChiper {
    enableObfuscation = true //by default res obfuscate is enabled
    obfuscationMode = "default" //["dir", "file", "default"]
    obfuscatedBundleName = "reschiper-app.aab" // Obfuscated file name, must end with '.aab'
    //mappingFile = file("path/to/your/mapping.txt").toPath() // Mapping file used for incremental obfuscation
    whiteList = [
                  //Whitelist rule (directory name to exclude)
                  "res/raw", // raw dir will not be obfuscated
                  "res/xml", // xml dir will not be obfuscated

                  //Whitelist rule (file name to exclude)
                  "res/raw/*", // all files inside raw directory will not be obfuscated
                  "res/raw/success_tick.json", // success_tick.json file will not be obfuscated
                  "res/xml/*", // all files inside xml directory will not be obfuscated

                  // White list rules (resource name to exclude)
                  "*.R.raw.*",
                  "*.R.xml.*",

                  // for google-services
                  "*.R.string.google_api_key",
                  "*.R.string.google_app_id",
                  "*.R.string.default_web_client_id",
                  "*.R.string.gcm_defaultSenderId",
                  "*.R.string.ga_trackingId",
                  "*.R.string.firebase_database_url",
                  "*.R.string.google_crash_reporting_api_key",
                  "*.R.string.google_storage_bucket",
                  "*.R.integer.google_play_services_version",
                  
                  //firebase
                  "*.R.string.project_id",
                  //firebase crashlytics
                  "*.R.string.com.google.firebase.crashlytics.mapping_file_id",
                  "*.R.bool.com.crashlytics.useFirebaseAppId",
                  "*.R.string.com.crashlytics.useFirebaseAppId",
                  "*.R.string.google_app_id",
                  "*.R.bool.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.string.com.crashlytics.CollectDeviceIdentifiers",
                  "*.R.bool.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.CollectUserIdentifiers",
                  "*.R.string.com.crashlytics.ApiEndpoint",
                  "*.R.string.com.crashlytics.android.build_id",
                  "*.R.bool.com.crashlytics.RequireBuildId",
                  "*.R.string.com.crashlytics.RequireBuildId",
                  "*.R.bool.com.crashlytics.CollectCustomLogs",
                  "*.R.string.com.crashlytics.CollectCustomLogs",
                  "*.R.bool.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.Trace",
                  "*.R.string.com.crashlytics.CollectCustomKeys"
    ]
    mergeDuplicateResources = true // allow the merge of duplicate resources
    enableFileFiltering = true
    enableFilterStrings = true
    fileFilterList = [ // file filter rules
                         "META-INF/*",
//                       "*/armeabi-v7a/*",
//                       "*/arm64-v8a/*",
//                       "*/x86/*",
//                       "*/x86_64/*"
    ]
    unusedStringFile = "path/to/your/unused_strings.txt" // strings will be filtered in this file
    localeWhiteList = ["en", "in", "fr"] //keep en,en-xx,in,in-xx,fr,fr-xx and remove others locale.
}
```

## Utilisation

Pour obfusquer vos ressources et générer un AAB obfusqué, exécutez la commande Gradle suivante dans le répertoire racine du projet. :


```cmd
./gradle clean :app:resChiperDebug --stacktrace
```

Cette commande exécutera le processus d'obfuscation depuis la racine du projet, et le AAB obfusqué sera généré dans
le répertoire `app/build/outputs/bundle/debug`.

## Options de configuration

L'extension ResChiper offre diverses options de configuration pour l'obfuscation des ressources, notamment l'activation/désactivation
de l'obfuscation, la spécification des fichiers de correspondance, la liste blanche des ressources, et plus encore.

- `enableObfuscation` : Activer ou désactiver l'obfuscation des ressources.<br>
- `obfuscationMode` : pour obfusquer uniquement les répertoires, définir `obfuscationMode = "dir"`, pour obfusquer uniquement les fichiers, définir
  `obfuscationMode = "file"` et pour obfusquer à la fois répertoires et fichiers, définir `obfuscationMode = "default"`.<br>
- `enableFilterStrings` : Saisir les splits de fichiers inutilisés ligne par ligne pour supporter la suppression de chaînes.<br>
- `enableFileFiltering` : Support pour filtrer les fichiers dans le paquet bundle. Supporte actuellement uniquement le filtrage dans
  les chemins `META-INFO/` et `lib/`.<br>
- `obfuscatedBundleName` : Nom du fichier AAB obfusqué.<br>
- `mergeDuplicateResources` : éliminer les fichiers de ressources en double et réduire la taille du paquet.<br>
- `mappingFile` : Chemin vers le fichier de correspondance ProGuard (à définir uniquement si mapping.txt est utilisé pour l'obfuscation).<br>
- `whiteList` : Ensemble des noms de ressources à exclure de l'obfuscation.<br>
- `fileFilterList` : Liste des motifs de fichiers à filtrer.<br>
- `unusedStringFile` : Chemin vers un fichier contenant les chaînes inutilisées.<br>
- `localeWhiteList` : Ensemble des locales à inclure dans le AAB.

## Exemple

vous pouvez consulter un exemple de configuration [ici](https://github.com/goldfish07/ResChiper/wiki/Example-Configuration-Options) 

## Liste blanche

ressources qui ne sont pas obfusquées durant le processus de compilation.<br>
vous pouvez trouver les configurations de whiteList [ici](https://github.com/goldfish07/ResChiper/wiki/WhiteList).

## Sortie

Après l'exécution du processus d'obfuscation, vous pouvez vous attendre aux fichiers de sortie suivants :

- **aab :** Il s'agit du paquet bundle obfusqué, qui contient votre Android App Bundle (AAB) avec les
  ressources obfusquées.
- **resources-mapping.txt :** Ce fichier contient la correspondance d'obfuscation des ressources. Il peut être utilisé comme entrée pour de futurs
  processus d'obfuscation afin d'obtenir une obfuscation incrémentale. Ceci est particulièrement utile si vous souhaitez maintenir
  cohérence entre différentes constructions.
- **-duplicated.txt :** Ce fichier journal fournit des informations sur les ressources fusionnées. Il vous aide à identifier et suivre toutes
  les ressources dupliquées qui ont été fusionnées lors du processus d'obfuscation.

Ces fichiers de sortie seront générés suite à l'exécution de l'outil ResChiper, et vous pouvez les trouver dans les
répertoires pertinents au sein de la sortie de construction de votre projet.

## Remerciements

ResChiper s'inspire des projets et outils suivants :

* [AabResGuard](https://github.com/bytedance/AabResGuard/)
* [AndResGuard](https://github.com/shwenzhang/AndResGuard/)
* [BundleTool](https://github.com/google/bundletool)

## Licence

[![Logo Licence Apache v2.0](https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/apache-licence-logo.png)](https://www.apache.org/licenses/LICENSE-2.0.txt)

    Copyright (C) 2023 goldfish07 (Ayush Bisht) <ayushbisht5663@gmail.com>
    Ce fichier fait partie de ResChiper.

    ResChiper est un logiciel libre : vous pouvez le redistribuer et/ou le modifier
    selon les termes de la Licence Apache, Version 2.0 telle que publiée par
    la Fondation Apache Software, soit la version 2.0 de la Licence, soit
    (à votre choix) toute version ultérieure.

    Sous licence Apache, Version 2.0 (la "Licence");
    vous ne pouvez utiliser ce fichier que conformément à la Licence.
    Vous pouvez obtenir une copie de la Licence à

        http://www.apache.org/licenses/LICENSE-2.0

    Sauf exigence légale ou accord écrit, le logiciel distribué sous la Licence
    est distribué "TEL QUEL", SANS GARANTIES NI CONDITIONS D'AUCUNE SORTE, expresses ou implicites.
    Consultez la Licence pour les autorisations et limitations spécifiques régissant l'utilisation.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---