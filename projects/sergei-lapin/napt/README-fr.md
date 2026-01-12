# ⚠️ Ce dépôt est archivé. Envisagez de migrer votre configuration de traitement d’annotation vers KSP. ⚠️

# NAPT

[![Plugin](https://img.shields.io/maven-metadata/v?label=Gradle%20Plugin&logo=Gradle&metadataUrl=https%3A%2F%2Fplugins.gradle.org%2Fm2%2Fcom%2Fsergei-lapin%2Fnapt%2Fcom.sergei-lapin.napt.gradle.plugin%2Fmaven-metadata.xml)](https://plugins.gradle.org/plugin/com.sergei-lapin.napt)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Qu’est-ce que c’est ?

Une alternative à KAPT qui évite la génération de stubs et fonctionne donc jusqu’à 50 % plus rapidement

## Utilisation

*JDK 9+ est requis pour exécuter cet ensemble spécifique d’outils*

Une fois appliqué, vous ne pouvez plus référencer le code généré dans le code Kotlin, vous devez donc écrire des classes `bridge` Java
afin de référencer le code Java généré dans les sources Kotlin.

Par exemple, supposons que nous ayons le composant Dagger 2 Kotlin suivant :

``` Kotlin
@Component
interface Component {

    @Component.Factory
    interface Factory {

        fun create(): Component
    }
}
```

puis, afin de référencer le composant généré depuis le code Kotlin, nous devons écrire un `bridge` Java qui ressemblerait à ceci :


``` Java
class ComponentBridge {

    static Component.Factory factory() {
        return DaggerComponent.factory();
    }
}
```

C’est tout, maintenant vous pouvez facilement référencer ce `bridge` depuis votre code Kotlin où vous le souhaitez

## Exemple

Vous pouvez voir un exemple d’utilisation dans [sample](https://github.com/sergei-lapin/napt/blob/main/sample/build.gradle)

## Téléchargement

- Le plugin javac est distribué via Maven Central
- Le plugin Gradle est distribué via le Gradle Plugin Portal

#### Ajouter le plugin

Supprimez votre ancien

``` Gradle
plugins {
    kotlin("kapt")
}
```
et le remplacer par


``` Gradle
plugins {
    id("com.sergei-lapin.napt") version("{latest-version}")
}
```

alors vous pouvez remplacer tout votre

``` Gradle
dependencies {
    kapt("some dependency")
}
```
avec


``` Gradle
dependencies {
    annotationProcessor("some dependency")
}
```

C'est tout. Profitez d'une accélération d'environ 50 % du traitement de vos annotations.

#### Classes NaptTrigger conflictuelles

Par défaut, le plugin Gradle génère NaptTrigger avec un package nommé selon le module afin d'éviter les conflits de noms qualifiés complets, mais, juste au cas où, le préfixe du package NaptTrigger peut être spécifié ainsi :


``` Gradle
napt {
    naptTriggerPackagePrefix.set("com.slapin.napt")
}
```

Supposons que nous sommes dans un module nommé `sample`, cela donnera le fichier `NaptTrigger.java` suivant :

``` Java
package com.slapin.napt.sample;
class NaptTrigger {
}
```

#### Désactivation de la génération de NaptTrigger

La génération de `NaptTrigger.java` peut être désactivée (par exemple lorsque vous avez déjà des sources Java dans votre module) en définissant
la propriété correspondante à `false` :

``` Gradle
napt {
    generateNaptTrigger.set(false)
}
```

#### Fourniture d'arguments JVM personnalisés au compilateur Java

Pour que napt fonctionne, la compilation Java s'exécute dans un processus forké avec des arguments définis
par `com.slapin.napt.JvmArgsStrongEncapsulation`. Ces arguments peuvent être étendus en définissant la propriété correspondante
dans l'extension `napt`.

``` Gradle
napt {
    forkJvmArgs.set(listOf("your_custom_arg"))
}
```
#### Génération de NaptTrigger dans des ensembles de sources supplémentaires

Parfois, vous pourriez avoir besoin de déclencher le traitement des annotations dans des ensembles de sources supplémentaires (par exemple `test`).  
Dans ce cas, vous pouvez utiliser la propriété correspondante de l'extension `napt` :  


``` Gradle
napt {
    additionalSourceSetsForTriggerGeneration.set(listOf("test"))
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---