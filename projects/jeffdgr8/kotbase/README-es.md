[![Maven Central](https://img.shields.io/maven-central/v/dev.kotbase/couchbase-lite)](
https://central.sonatype.com/namespace/dev.kotbase)
[![Kotlin](https://img.shields.io/badge/kotlin-2.2.20-blue.svg?logo=kotlin)](http://kotlinlang.org)
[![GitHub License](https://img.shields.io/github/license/jeffdgr8/kotbase)](LICENSE)
[![Couchbase Community](https://img.shields.io/badge/couchbase-community-ea2328?logo=couchbase&logoColor=ea2328)](
https://www.couchbase.com/developers/community/)
[![Slack Channel](https://img.shields.io/badge/chat-%23couchbase-4a154b.svg?logo=slack)](
https://kotlinlang.slack.com/messages/couchbase/)

# Kotbase

**Kot**lin Multiplatform biblioteca para Couch**base** Lite

## Introducción

Kotbase combina [Kotlin Multiplatform](https://www.jetbrains.com/kotlin-multiplatform/) con [Couchbase Lite](
https://www.couchbase.com/products/lite/), una base de datos incrustada NoSQL de documentos JSON. Couchbase Lite puede usarse como una
base de datos cliente independiente, o combinarse con [Couchbase Server](https://www.couchbase.com/products/server/) y [Sync
Gateway](https://www.couchbase.com/products/sync-gateway/) o [Capella App Services](
https://www.couchbase.com/products/capella/app-services/) para la sincronización de datos desde la nube hasta el borde. Las características incluyen:

* Consultas [SQL++](https://www.couchbase.com/products/n1ql/), clave/valor, búsqueda de texto completo y búsqueda vectorial
* Consultas, documentos, bases de datos y replicadores observables
* Adjuntos binarios a documentos (blobs)
* Sincronización de datos entre pares y de nube a borde

Kotbase proporciona soporte completo para la API de las ediciones Enterprise y Community para Android y JVM ([a través del SDK de Java](
https://github.com/couchbase/couchbase-lite-java-ce-root)), nativo para iOS y macOS ([a través del SDK de Objective-C](
https://github.com/couchbase/couchbase-lite-ios)), y soporte experimental para Linux y Windows nativos ([a través del SDK de C](
https://github.com/couchbase/couchbase-lite-C)).

## Instalación

Agrega la dependencia de la Edición Community o Enterprise en las dependencias del conjunto de fuentes **commonMain** de tu
módulo compartido en el archivo **build.gradle.kts**:

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

> **Nota**  
> La Edición Comunitaria de Couchbase Lite es gratuita y de código abierto. La Edición Empresarial es gratuita para desarrollo y  
> pruebas, pero requiere una [licencia de Couchbase](https://www.couchbase.com/pricing/#couchbase-mobile) para uso en producción.  
> [Ver Comunidad vs Edición Empresarial.](https://www.couchbase.com/products/editions/mobile/)  

Kotbase se publica en Maven Central. La dependencia de la Edición Empresarial de Couchbase Lite requiere además el  
repositorio Maven de Couchbase.

```kotlin
repositories {
    mavenCentral()
    maven("https://mobile.maven.couchbase.com/maven2/dev/")
}
```
### Plataformas Nativas

Los objetivos de plataformas nativas deben además enlazar con el binario nativo de la dependencia Couchbase Lite. Consulte [Plataformas Soportadas](https://kotbase.dev/current/platforms/) para más detalles.

### Linux

Apuntar a JVM que se ejecuta en Linux o Linux nativo, ambos requieren una versión específica de la dependencia libicu. (Verá un error como `libLiteCore.so: libicuuc.so.71: cannot open shared object file: No such file or directory` que indica la versión esperada.) Si la versión requerida no está disponible en el gestor de paquetes de su distribución, puede descargarla desde [GitHub](https://github.com/unicode-org/icu/releases).

## Documentación

La documentación de Kotbase se encuentra en [kotbase.dev](https://kotbase.dev/), incluyendo [ejemplos para comenzar](https://kotbase.dev/current/getting-started/), [guía de uso](https://kotbase.dev/current/databases/) y [referencia API](https://kotbase.dev/api/).

## Diferencias con el SDK de Java

La API de Kotbase se alinea con los SDKs de Couchbase Lite [Java](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/https://docs.couchbase.com/couchbase-lite/current/java/quickstart.html) y [Android KTX](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/https://docs.couchbase.com/couchbase-lite/current/android/quickstart.html). Migrar código Kotlin existente puede ser tan sencillo como cambiar el paquete de importación de `com.couchbase.lite` a `kotbase`, con algunas excepciones:

* Las interfaces funcionales de callback de Java se implementan como tipos de función Kotlin.
* Las APIs `File`, `URL` y `URI` se representan como cadenas.
* Las APIs de `Date` usan `Instant` de Kotlin.
* Las APIs de `InputStream` usan [kotlinx-io `Source`](https://kotlinlang.org/api/kotlinx-io/kotlinx-io-core/kotlinx.io/-source/).
* Las APIs de `Executor` usan `CoroutineContext` de Kotlin.
* Las APIs de certificados están disponibles como `ByteArray` sin procesar o en código específico de plataforma.
* No es necesario llamar explícitamente a `CouchbaseLite.init()`. Las funciones de inicialización aún pueden llamarse con parámetros personalizados en código de plataforma JVM y Android.
* Se han hecho esfuerzos para detectar y lanzar excepciones Kotlin para condiciones comunes de error, pero `NSError` aún puede filtrarse en plataformas Apple. [Por favor reporte](https://github.com/jeffdgr8/kotbase/issues/new) cualquier ocurrencia que merezca atención.
* Algunas APIs obsoletas se omiten.
* Aunque no está disponible en el SDK de Java, ya que Java no soporta sobrecarga de operadores, las APIs de subíndices de [`Fragment`](














  https://kotbase.dev/current/kotlin-extensions/#fragment-subscripts) están disponibles en Kotbase, similares a [Swift](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-swift/Classes/Fragment.html), [Objective-C](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-objc/Protocols/CBLFragment.html), y [.NET](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/
  https://docs.couchbase.com/mobile/3.1.10/couchbase-lite-net/api/Couchbase.Lite.IFragment.html).
* Las APIs de fábrica de configuración del SDK Android KTX han sido desaprobadas en favor de usar constructores directamente,
  que soportan argumentos nombrados de Kotlin por sí mismos.

## Bibliotecas de Extensión

Kotbase incluye algunas extensiones convenientes además de la API oficial de Couchbase Lite como artefactos de biblioteca adicionales.

### Kotbase KTX

Las [extensiones KTX](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-ktx/README.md) incluyen las excelentes [extensiones Kotlin por MOLO17](https://github.com/MOLO17/couchbase-lite-kotlin),
así como otras funciones de conveniencia para componer consultas, mapear resultados de consultas, crear documentos y observar
`Flow`s de cambios.

#### Instalación

```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-ktx:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-ktx:3.2.4-1.2.0")
```

### Kotbase Kermit

[Kotbase Kermit](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-kermit/README.md) es un registrador personalizado de Couchbase Lite que registra en [Kermit](
https://kermit.touchlab.co/). Kermit puede dirigir sus registros a cualquier número de salidas de registro, incluida la consola.

#### Instalación

```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-kermit:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-kermit:3.2.4-1.2.0")
```

### Paginación Kotbase

Las [extensiones de paginación](https://raw.githubusercontent.com/jeffdgr8/kotbase/main/couchbase-lite-paging/README.md) están construidas sobre la [paginación AndroidX](
https://developer.android.com/topic/libraries/architecture/paging/v3-overview) de Google. Kotbase Paging proporciona un
[`PagingSource`](https://developer.android.com/reference/kotlin/androidx/paging/PagingSource) que realiza
consultas de paginación limit/offset basadas en una consulta de base de datos proporcionada por el usuario.

#### Instalación

```kotlin
// Community Edition
implementation("dev.kotbase:couchbase-lite-paging:3.2.4-1.2.0")
// or Enterprise Edition
implementation("dev.kotbase:couchbase-lite-ee-paging:3.2.4-1.2.0")
```

## Hoja de ruta

* [x] Sitio web de documentación ([kotbase.dev](https://kotbase.dev/))
* [x] Interoperabilidad con `NSInputStream` ~~(Okio [#1123](https://github.com/square/okio/pull/1123))~~ (kotlinx-io [#174](
  https://github.com/Kotlin/kotlinx-io/pull/174))
* [x] Soporte para Linux ARM64
* [x] Lanzamiento público
* [ ] Aplicaciones de ejemplo
    * [x] [Primeros pasos](examples/getting-started)
    * [x] [Primeros pasos Compose Multiplatform](examples/getting-started-compose)
    * [x] [Kotbase Notes](examples/kotbase-notes)
    * [ ] SwiftUI para Kotbase Notes
* [x] Couchbase Lite [API 3.1](https://docs.couchbase.com/couchbase-lite/3.1/cbl-whatsnew.html) - Ámbitos y Colecciones
* [x] Documentación versionada
* [x] Couchbase Lite [API 3.2](https://docs.couchbase.com/couchbase-lite/3.2/cbl-whatsnew.html) - [Búsqueda Vectorial](
  https://www.couchbase.com/products/vector-search/)
* [ ] Couchbase Lite [API 3.3](https://docs.couchbase.com/couchbase-lite/3.3/cbl-whatsnew.html) - Replicador Multipeer
* [ ] Couchbase Lite [API 4.0](https://docs.couchbase.com/couchbase-lite/4.0/cbl-whatsnew.html) - Vectores de versión
* [ ] URLEndpointListener en plataformas Linux y MinGW
* [ ] Mejorar la alineación de la API Swift con Couchbase Lite usando [exportación Swift](
  https://youtrack.jetbrains.com/issue/KT-64572), `@ObjCName` y/o `@ShouldRefineInSwift`
* [ ] API de corrutinas asíncronas

## Desarrollo

* Al compilar el proyecto en Linux, asegúrate de instalar la dependencia libicu.
* Al clonar el repositorio git en Windows, habilita el [modo desarrollador](
  https://learn.microsoft.com/en-us/windows/apps/get-started/enable-your-device-for-development) y los enlaces simbólicos en
  git con `git config --global core.symlinks true`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-20

---