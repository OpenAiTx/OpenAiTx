# ResChiper

<h1 align="center">
  <img src="https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/reschiper-banner.png" alt="failed to load artifacts/logo.png"/>
  <p align="center" style="font-size: 0.3em">Herramienta de Ofuscación de Recursos AAB</p>
</h1>

[![License](https://img.shields.io/badge/license-Apache_2.0-maroon)](LICENSE)
![Android Gradle Plugin](https://img.shields.io/badge/Dependency-AGP/8.8.0-4CAF50)
[![BundleTool](https://img.shields.io/badge/Dependency-Bundletool/1.17.2-red)](https://github.com/google/bundletool)
![JDK Version](https://img.shields.io/badge/JDK-17-blue)
![Gradle Version](https://img.shields.io/badge/Gradle_Wrapper-8.8-darkgreen)
[![ResChiper Version](https://img.shields.io/badge/release-0.1.0--rc6-%23C6782A.svg?style=flat)](https://github.com/goldfish07/ResChiper/releases/tag/0.1.0-rc6)

## Tabla de Contenidos

- [Introducción](#introduction)
- [Primeros Pasos](#getting-started)
    - [Requisitos](#requirements)
    - [Instalación](#installation)
    - [Uso](#usage)
- [Opciones de Configuración](#configuration-options)
- [Ejemplo](#example)
- [Lista Blanca](#whitelist)
- [Salida](#output)
- [Agradecimientos](#acknowledgments)
- [Licencia](#license)

## Introducción

ResChiper es una herramienta diseñada para ofuscar recursos AAB de Android.
Te permite proteger tus recursos contra accesos no autorizados y reducir el tamaño del AAB de tu aplicación.

## Primeros Pasos

Sigue estos pasos para integrar la Herramienta de Ofuscación de Recursos AAB en tu proyecto Android:

## Requisitos

Antes de comenzar a usar ResChiper, asegúrate de que tu aplicación cumple con los siguientes requisitos:
- **Kit de Desarrollo de Java (JDK)**: ResChiper requiere JDK 17, asegúrate de que tu aplicación esté configurada con JDK 17.  
- **Plugin de Gradle para Android (AGP)**: versión 8.0 o posterior.  

## Instalación  

#### 1. Agregar el Plugin de Gradle de ResChiper  

En el archivo `build.gradle` a nivel raíz de tu proyecto, agrega el plugin de Gradle de ResChiper en la sección `buildscript`:


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

#### 2. Aplicar el Plugin

En el archivo `build.gradle` a nivel de la aplicación, aplica el plugin ResChiper:

```gradle
apply plugin: "io.github.goldfish07.reschiper"
```
#### 3. Configurar el Plugin

En tu archivo `app/build.gradle`, configura el plugin ResChiper especificando los ajustes deseados. Aquí tienes un ejemplo
de configuración:


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

## Uso

Para ofuscar tus recursos y generar un AAB ofuscado, ejecuta el siguiente comando de Gradle en el directorio raíz
del proyecto.:

```cmd
./gradle clean :app:resChiperDebug --stacktrace
```
Este comando ejecutará el proceso de ofuscación desde la raíz del proyecto, y el AAB ofuscado se generará en
el directorio `app/build/outputs/bundle/debug`.

## Opciones de Configuración

La extensión ResChiper ofrece varias opciones de configuración para la ofuscación de recursos, incluyendo habilitar/deshabilitar
la ofuscación, especificar archivos de mapeo, listas blancas de recursos, y más.

- `enableObfuscation`: Habilitar o deshabilitar la ofuscación de recursos.<br>
- `obfuscationMode`: para ofuscar solo directorios establecer `obfuscationMode = "dir"`, para ofuscar solo archivos establecer
  `obfuscationMode = "file"` y para ofuscar tanto directorios como archivos establecer `obfuscationMode = "default"`.<br>
- `enableFilterStrings`: Ingresar los splits de archivos no usados por líneas para soportar la eliminación de cadenas.<br>
- `enableFileFiltering`: Soporte para filtrar archivos en el paquete bundle. Actualmente solo soporta filtrado en
  las rutas `META-INFO/` y `lib/`.<br>
- `obfuscatedBundleName`: Nombre del archivo AAB ofuscado.<br>
- `mergeDuplicateResources`: eliminar archivos de recursos duplicados y reducir el tamaño del paquete.<br>
- `mappingFile`: Ruta al archivo de mapeo de ProGuard (establecer solo cuando se use mapping.txt para la ofuscación).<br>
- `whiteList`: Conjunto de nombres de recursos para excluir de la ofuscación.<br>
- `fileFilterList`: Lista de patrones de archivos para filtrar.<br>
- `unusedStringFile`: Ruta a un archivo que contiene cadenas no usadas.<br>
- `localeWhiteList`: Conjunto de locales para incluir en el AAB.

## Ejemplo

puedes consultar algunos ejemplos de configuración [aquí](https://github.com/goldfish07/ResChiper/wiki/Example-Configuration-Options) 

## Lista Blanca

recursos que no son ofuscados durante el proceso de compilación.<br>
puedes encontrar configuraciones de whiteList [aquí](https://github.com/goldfish07/ResChiper/wiki/WhiteList).

## Salida

Después de ejecutar el proceso de ofuscación, puedes esperar los siguientes archivos de salida:

- **aab:** Este es el paquete bundle ofuscado, que contiene tu Android App Bundle (AAB) con recursos ofuscados.
- **resources-mapping.txt:** Este archivo contiene el mapeo de la ofuscación de recursos. Puede usarse como entrada para futuros
  procesos de ofuscación para lograr una ofuscación incremental. Esto es especialmente útil si deseas mantener


  consistencia entre diferentes compilaciones.
- **-duplicated.txt:** Este archivo de registro proporciona información sobre recursos fusionados. Te ayuda a identificar y rastrear cualquier
  recurso duplicado que se haya fusionado durante el proceso de ofuscación.

Estos archivos de salida se generarán como resultado de ejecutar la herramienta ResChiper, y puedes encontrarlos en los directorios
relevantes dentro de la salida de compilación de tu proyecto.

## Agradecimientos

ResChiper está inspirado en los siguientes proyectos y herramientas:

* [AabResGuard](https://github.com/bytedance/AabResGuard/)
* [AndResGuard](https://github.com/shwenzhang/AndResGuard/)
* [BundleTool](https://github.com/google/bundletool)

## Licencia

[![Logo de la Licencia Apache v2.0](https://raw.githubusercontent.com/goldfish07/ResChiper/release/0.1.0-rc6/artifacts/apache-licence-logo.png)](https://www.apache.org/licenses/LICENSE-2.0.txt)

    Copyright (C) 2023 goldfish07 (Ayush Bisht) <ayushbisht5663@gmail.com>
    Este archivo es parte de ResChiper.

    ResChiper es software libre: puedes redistribuirlo y/o modificarlo
    bajo los términos de la Licencia Apache, Versión 2.0 publicada por
    la Fundación Apache Software, ya sea la versión 2.0 de la Licencia, o
    (a tu elección) cualquier versión posterior.

    Licenciado bajo la Licencia Apache, Versión 2.0 (la "Licencia");
    no puedes usar este archivo excepto en cumplimiento con la Licencia.
    Puedes obtener una copia de la Licencia en

        http://www.apache.org/licenses/LICENSE-2.0

    A menos que lo requiera la ley aplicable o se acuerde por escrito, el software
    distribuido bajo la Licencia se distribuye "TAL CUAL",
    SIN GARANTÍAS NI CONDICIONES DE NINGÚN TIPO, ya sean expresas o implícitas.
    Consulta la Licencia para conocer el idioma específico que rige los permisos y
    limitaciones bajo la Licencia.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---