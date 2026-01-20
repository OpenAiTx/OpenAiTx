[![Maven Central](https://img.shields.io/maven-central/v/dev.kotbase/couchbase-lite)](
https://central.sonatype.com/namespace/dev.kotbase)
[![Kotlin](https://img.shields.io/badge/kotlin-2.2.20-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![GitHub License](https://img.shields.io/github/license/jeffdgr8/kotbase)](LICENSE)
[![Couchbase Community](https://img.shields.io/badge/couchbase-community-ea2328?logo=couchbase&logoColor=ea2328)](
https://www.couchbase.com/developers/community/)
[![Slack Channel](https://img.shields.io/badge/chat-%23couchbase-4a154b.svg?logo=slack)](
https://kotlinlang.slack.com/messages/couchbase/)

# Kotbase

**Kot**lin Multiplateforme pour Couch**base** Lite

## Introduction

Kotbase associe [Kotlin Multiplateforme](https://www.jetbrains.com/kotlin-multiplatform/) avec [Couchbase Lite](
https://www.couchbase.com/products/lite/), une base de données documentaire JSON NoSQL embarquée. Couchbase Lite peut être utilisé comme base de données client autonome, ou associé à [Couchbase Server](https://www.couchbase.com/products/server/) et [Sync Gateway](https://www.couchbase.com/products/sync-gateway/) ou [Capella App Services](
https://www.couchbase.com/products/capella/app-services/) pour la synchronisation des données du cloud vers la périphérie. Les fonctionnalités incluent :

* Requêtes [SQL++](https://www.couchbase.com/products/n1ql/), clé/valeur, recherche en texte intégral, et recherche vectorielle
* Requêtes, documents, bases de données et réplications observables
* Pièces jointes binaires aux documents (blobs)
* Synchronisation de données peer-to-peer et cloud-à-périphérie

Kotbase offre un support complet des API pour les éditions Enterprise et Community sur Android et JVM ([via SDK Java](
https://github.com/couchbase/couchbase-lite-java-ce-root)), iOS et macOS natifs ([via SDK Objective-C](
https://github.com/couchbase/couchbase-lite-ios)), et un support expérimental pour Linux et Windows natifs ([via SDK C](
https://github.com/couchbase/couchbase-lite-C)).

## Installation

Ajoutez la dépendance de l’édition Community ou Enterprise dans les dépendances du source set **commonMain** de votre module partagé dans le fichier **build.gradle.kts** :




```kotlin
kotlin {
    sourceSets {
        commonMain.dependencies {
            // Community Edition
            implementation("dev.kotbase:couchbase-lite:3.2.4-1.2.0")
            // or Enterprise Edition
            implementation("dev.kotbase:couchbase-lite-ee:3.2.4-1.2.0")
        }
    }
}
```

> **Remarque**
> L’édition communautaire de Couchbase Lite est gratuite et open source. L’édition Entreprise est gratuite pour le développement et
> les tests, mais nécessite une [licence de Couchbase](https://www.couchbase.com/pricing/#couchbase-mobile) pour une utilisation en production.
> [Voir Communauté vs Édition Entreprise.](https://www.couchbase.com/products/editions/mobile/)

Kotbase est publié sur Maven Central. La dépendance à l’édition Entreprise de Couchbase Lite nécessite en outre le
dépôt Maven de Couchbase.

```kotlin
repositories {
    mavenCentral()
    maven("https://mobile.maven.couchbase.com/maven2/dev/")
}
```

### Plates-formes natives

Les cibles des plates-formes natives doivent en outre lier la dépendance binaire native de Couchbase Lite. Voir [Plates-formes
prises en charge](https://kotbase.dev/current/platforms/) pour plus de détails.

### Linux

Cibler la JVM fonctionnant sous Linux ou Linux natif nécessite dans les deux cas une version spécifique de la dépendance libicu. (Vous verrez
une erreur telle que `libLiteCore.so: libicuuc.so.71: cannot open shared object file: No such file or directory` indiquant
la version attendue.) Si la version requise n'est pas disponible via le gestionnaire de paquets de votre distribution, vous pouvez
la télécharger depuis [GitHub](https://github.com/unicode-org/icu/releases).

## Documentation

La documentation de Kotbase est disponible sur [kotbase.dev](https://kotbase.dev/), incluant des [exemples pour débuter](
https://kotbase.dev/current/getting-started/), un [guide d’utilisation](https://kotbase.dev/current/databases/), et une [référence API](
https://kotbase.dev/api/).

## Différences avec le SDK Java

L’API de Kotbase est alignée avec les SDK Couchbase Lite [Java](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/java/quickstart.html) et [Android KTX](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
https://docs.couchbase.com/couchbase-lite/current/android/quickstart.html). Migrer un code Kotlin existant peut être
aussi simple que de changer le package d’import de `com.couchbase.lite` en `kotbase`, avec quelques exceptions :

* Les interfaces fonctionnelles de rappel Java sont implémentées comme des types de fonctions Kotlin.
* Les API `File`, `URL` et `URI` sont représentées sous forme de chaînes.
* Les API `Date` utilisent `Instant` de Kotlin.
* Les API `InputStream` utilisent [le `Source` de kotlinx-io](
  https://kotlinlang.org/api/kotlinx-io/kotlinx-io-core/kotlinx.io/-source/).
* Les API `Executor` utilisent le `CoroutineContext` de Kotlin.
* Les API de certificats sont disponibles en tant que `ByteArray` bruts ou dans du code spécifique à la plate-forme.
* Il n’est pas nécessaire d’appeler explicitement `CouchbaseLite.init()`. Les fonctions d’initialisation peuvent néanmoins être appelées avec des paramètres personnalisés dans le code JVM et Android.
* Des efforts ont été faits pour détecter et lancer des exceptions Kotlin pour des erreurs courantes, mais `NSError` peut encore apparaître
  sur les plates-formes Apple. [Merci de signaler](https://github.com/jeffdgr8/kotbase/issues/new) toute occurrence qui mériterait
  d’être traitée.
* Certaines API obsolètes sont omises.
* Bien qu’elles ne soient pas disponibles dans le SDK Java, car Java ne supporte pas la surcharge des opérateurs, les API de sous-script [`Fragment`](

  https://kotbase.dev/current/kotlin-extensions/#fragment-subscripts) sont disponibles dans Kotbase, similaires à [Swift](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-swift/Classes/Fragment.html), [Objective-C](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-objc/Protocols/CBLFragment.html), et [.NET](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-net/api/Couchbase.Lite.IFragment.html).
* Les API de fabrique de configuration du SDK Android KTX ont été dépréciées au profit de l’utilisation directe des constructeurs,
  qui prennent eux-mêmes en charge les arguments nommés Kotlin.

## Bibliothèques d’extension

Kotbase inclut des extensions pratiques par-dessus l’API officielle de Couchbase Lite sous forme d’artefacts de bibliothèque supplémentaires.

### Kotbase KTX

Les [extensions KTX](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-ktx/README.md) comprennent l’excellente [extension Kotlin par MOLO17](https://github.com/MOLO17/couchbase-lite-kotlin),
ainsi que d’autres fonctions pratiques pour composer des requêtes, mapper les résultats des requêtes, créer des documents et observer
des `Flow`s de changements.

#### Installation

```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-ktx:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-ktx:3.2.4-1.2.0")
```

### Kotbase Kermit

[Kotbase Kermit](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-kermit/README.md) est un logger personnalisé Couchbase Lite qui enregistre dans [Kermit](https://kermit.touchlab.co/). Kermit peut diriger ses journaux vers un nombre quelconque de sorties de journal, y compris la console.

#### Installation


```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-kermit:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-kermit:3.2.4-1.2.0")
```

### Pagination Kotbase

Les [extensions de pagination](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-paging/README.md) sont basées sur la [Pagination AndroidX](
https://developer.android.com/topic/libraries/architecture/paging/v3-overview) de Google. Kotbase Pagination fournit un
[`PagingSource`](https://developer.android.com/reference/kotlin/androidx/paging/PagingSource) qui exécute des
requêtes de pagination limit/offset basées sur une requête de base de données fournie par l’utilisateur.

#### Installation

```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-paging:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-paging:3.2.4-1.2.0")
```

## Feuille de route

* [x] Site web de documentation ([kotbase.dev](https://kotbase.dev/))
* [x] Interopérabilité `NSInputStream` ~~(Okio [#1123](https://github.com/square/okio/pull/1123))~~ (kotlinx-io [#174](
  https://github.com/Kotlin/kotlinx-io/pull/174))
* [x] Support Linux ARM64
* [x] Publication publique
* [ ] Applications exemples
    * [x] [Premiers pas](examples/getting-started)
    * [x] [Premiers pas Compose Multiplateforme](examples/getting-started-compose)
    * [x] [Kotbase Notes](examples/kotbase-notes)
    * [ ] SwiftUI pour Kotbase Notes
* [x] Couchbase Lite [API 3.1](https://docs.couchbase.com/couchbase-lite/3.1/cbl-whatsnew.html) - Scopes et Collections
* [x] Documentation versionnée
* [x] Couchbase Lite [API 3.2](https://docs.couchbase.com/couchbase-lite/3.2/cbl-whatsnew.html) - [Recherche Vectorielle](
  https://www.couchbase.com/products/vector-search/)
* [ ] Couchbase Lite [API 3.3](https://docs.couchbase.com/couchbase-lite/3.3/cbl-whatsnew.html) - Réplicateur Multipeer
* [ ] Couchbase Lite [API 4.0](https://docs.couchbase.com/couchbase-lite/4.0/cbl-whatsnew.html) - Vecteurs de Version
* [ ] URLEndpointListener sur plateformes Linux & MinGW
* [ ] Améliorer l’alignement de l’API Swift avec Couchbase Lite en utilisant [Swift
  export](https://youtrack.jetbrains.com/issue/KT-64572), `@ObjCName`, et/ou `@ShouldRefineInSwift`
* [ ] API asynchrone avec coroutines

## Développement

* Lors de la compilation du projet sous Linux, assurez-vous d’installer la dépendance libicu.
* Lors du clonage du dépôt git sous Windows, activez le [mode développeur](
  https://learn.microsoft.com/en-us/windows/apps/get-started/enable-your-device-for-development) et les liens symboliques dans
  git avec `git config --global core.symlinks true`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---