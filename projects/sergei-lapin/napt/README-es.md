# ⚠️ Este repositorio está archivado. Considera migrar tu configuración de procesamiento de anotaciones a KSP. ⚠️

# NAPT

[![Plugin](https://img.shields.io/maven-metadata/v?label=Gradle%20Plugin&logo=Gradle&metadataUrl=https%3A%2F%2Fplugins.gradle.org%2Fm2%2Fcom%2Fsergei-lapin%2Fnapt%2Fcom.sergei-lapin.napt.gradle.plugin%2Fmaven-metadata.xml)](https://plugins.gradle.org/plugin/com.sergei-lapin.napt)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## ¿Qué es?

Una alternativa a KAPT que omite la generación de stubs y por lo tanto funciona hasta un 50% más rápido

## Uso

*Se requiere JDK 9+ para ejecutar este conjunto particular de herramientas*

Una vez aplicado, ya no puedes referenciar código generado en código Kotlin, por lo que deberás escribir clases `bridge` en Java
para poder referenciar el código generado en Java desde fuentes Kotlin.

Por ejemplo, supongamos que tenemos el siguiente Componente Dagger 2 en Kotlin:

``` Kotlin
@Component
interface Component {

    @Component.Factory
    interface Factory {

        fun create(): Component
    }
}
```

entonces, para referenciar el componente generado desde el código Kotlin, tenemos que escribir un `puente` en Java que se vería así:


``` Java
class ComponentBridge {

    static Component.Factory factory() {
        return DaggerComponent.factory();
    }
}
```

Eso es todo, ahora puedes referenciar fácilmente este `bridge` desde tu código Kotlin donde quieras

## Ejemplo

Puedes ver un ejemplo de uso en [sample](https://github.com/sergei-lapin/napt/blob/main/sample/build.gradle)

## Descarga

- El plugin javac se distribuye a través de Maven Central
- El plugin Gradle se distribuye a través de Gradle Plugin Portal

#### Añadir plugin

Elimina tu antiguo

``` Gradle
plugins {
    kotlin("kapt")
}
```
y reemplázalo con


``` Gradle
plugins {
    id("com.sergei-lapin.napt") version("{latest-version}")
}
```

entonces puedes reemplazar todo tu

``` Gradle
dependencies {
    kapt("some dependency")
}
```
con


``` Gradle
dependencies {
    annotationProcessor("some dependency")
}
```

Eso es todo. Disfruta de la aceleración de tu procesamiento de anotaciones en aproximadamente un 50%.

#### Clases NaptTrigger en conflicto

Por defecto, el plugin de Gradle generará NaptTrigger con un paquete nombrado por módulo para que los nombres FQ no choquen, pero, por si acaso, el prefijo del paquete de NaptTrigger se puede especificar de esta manera:


``` Gradle
napt {
    naptTriggerPackagePrefix.set("com.slapin.napt")
}
```

Asumamos que estamos en un módulo llamado `sample`, lo que resultará en el siguiente `NaptTrigger.java`:

``` Java
package com.slapin.napt.sample;
class NaptTrigger {
}
```

#### Deshabilitar la generación de NaptTrigger

La generación de `NaptTrigger.java` puede deshabilitarse (por ejemplo, cuando ya tienes fuentes Java en tu módulo) estableciendo
la propiedad correspondiente en `false`:

``` Gradle
napt {
    generateNaptTrigger.set(false)
}
```
#### Suministro de argumentos JVM personalizados al compilador de Java

Para que napt funcione, la compilación de Java se ejecuta en un proceso bifurcado con argumentos definidos
por `com.slapin.napt.JvmArgsStrongEncapsulation`. Estos argumentos pueden ampliarse configurando la propiedad correspondiente
en la extensión `napt`.


``` Gradle
napt {
    forkJvmArgs.set(listOf("your_custom_arg"))
}
```
#### Generener NaptTrigger dentro de conjuntos de fuentes adicionales

A veces puede ser necesario activar el procesamiento de anotaciones en conjuntos de fuentes adicionales (p. ej., `test`).
En tales casos, puede usar la propiedad correspondiente de la extensión `napt`:


``` Gradle
napt {
    additionalSourceSetsForTriggerGeneration.set(listOf("test"))
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---