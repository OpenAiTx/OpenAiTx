# Konvert

[![Maven Central][maven-image]][maven-url]
[![License][license-image]](LICENSE)
[![Code Coverage][codecov-image]][codecov-url]

Este es Konvert, un generador de código de mapeo para Kotlin que utiliza [Kotlin Symbol Processing (KSP)](https://github.com/google/ksp).
Diseñado específicamente para Kotlin y sus características, Konvert soporta una amplia gama de casos de uso.

Características principales:
* 🧩 soporta **varios tipos de clases** → `data`, `enum`, `value`, POJOs regulares
* 🔄 **Seguro contra nulos** por defecto
* ⚙️ **Conversiones inteligentes** (`Int` → `String`, `Instant` → `Date`, …)
   * 🔧 Define **convertidores reutilizables** con `@Konverter`
   * 🔌 Extiende mediante **SPI** para control total
* 🔗 **Colecciones y mapas** — mapeo de elementos incluido
* 🛠️ **Personalización** detallada del mapeo de propiedades
* ☕ 100% **interoperabilidad con Java**
* ✨ Genera código **Kotlin limpio e idiomático**
   * ⏱️ Generado en **tiempo de compilación**
   * 🚫 **Cero reflexión**, **cero sobrecarga en tiempo de ejecución**
* 📦 Funciona perfectamente con **Gradle** y **Maven**

> ℹ️ Este README ofrece una visión básica, para más detalles consulte la [documentación](https://mcarleio.github.io/konvert).

## Uso

Hay tres maneras diferentes de usar Konvert:

1. Usando `@KonvertTo`:
   ```kotlin
   @KonvertTo(PersonDto::class)
   data class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)
   ```
   Esto generará la siguiente función de extensión
   ```kotlin
   fun Person.toPersonDto(): PersonDto =
      PersonDto(firstName = firstName, lastName = lastName)
   ```

2. Usando `@KonvertFrom` (especialmente útil si no puedes cambiar el código de la clase fuente)
   ```kotlin
   class Person(val firstName: String, val lastName: String) {
      @KonvertFrom(PersonDto::class)
      companion object
   }
   class PersonDto(val firstName: String, val lastName: String)
   ```
   Esto generará la siguiente función de extensión
   ```kotlin
   fun Person.Companion.fromPersonDto(personDto: PersonDto): Person =
      Person(firstName = personDto.firstName, lastName = personDto.lastName)
   ```

3. Usando `@Konverter`:
   ```kotlin
   class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)

   @Konverter
   interface PersonMapper {
      fun toDto(person: Person): PersonDto
   }
   ```
   Esto generará el siguiente objeto
   ```kotlin
   object PersonMapperImpl: PersonMapper {
      override fun toDto(person: Person): PersonDto
         = PersonDto(firstName = person.firstName, lastName = person.lastName)
   }
   ```
Para un proyecto de ejemplo simple, eche un vistazo al [directorio de ejemplo](example).

### Mapeos de tipos

Para mapeos de tipos simples, como de `Instant` a `Date`, ya existe un convertidor de tipos proporcionado con Konvert:

```kotlin
@KonvertTo(PersonDto::class)
class Person(val name: String, val birthday: Instant)
class PersonDto(val name: String, val birthday: Date)
```

Esto generará la siguiente función de extensión

```kotlin
fun Person.toPersonDto(): PersonDto = PersonDto(
   name = name,
   birthday = birthday.let { java.util.Date.from(it) }
)
```

Echa un vistazo a la [documentación](https://mcarleio.github.io/konvert/typeconverter/) para una lista de convertidores de tipo proporcionados.

🛈: También puedes crear tu propia biblioteca de convertidores de tipo
implementando [TypeConverter](https://raw.githubusercontent.com/mcarleio/konvert/main/converter-api/src/main/kotlin/io/mcarle/konvert/converter/api/TypeConverter.kt) y registrarla
usando [SPI](https://es.wikipedia.org/wiki/Interfaz_de_proveedor_de_servicio).

### Ajuste fino

La mayoría de las veces, las clases origen y destino pueden no tener los mismos nombres y tipos de propiedades.
Puedes configurar mapeos específicos y renombrar la función de extensión generada así:

```kotlin
@KonvertTo(
   PersonDto::class,
   mappings = [
      Mapping(source = "firstName", target = "givenName"),
      Mapping(source = "lastName", target = "familyName")
   ],
   mapFunctionName = "asDto"
)
class Person(val firstName: String, val lastName: String)
class PersonDto(val givenName: String, val familyName: String)
```

Esto generará la siguiente función de extensión

```kotlin
fun Person.asDto(): PersonDto = PersonDto(
   givenName = firstName,
   familyName = lastName
)
```

Para más funcionalidades, consulta
la [documentación](https://mcarleio.github.io/konvert/)
los KDocs de las [anotaciones](annotations/src/main/kotlin/io/mcarle/konvert/api),
el [proyecto de ejemplo](example/src/main/kotlin/io/mcarle/konvert/example)
o las [pruebas](processor/src/test/kotlin/io/mcarle/konvert/processor).

## Configuración de Gradle

Para usar Konvert con Gradle, debes realizar los siguientes pasos:

1. Añade `konvert-api` como dependencia para usar las anotaciones:
   ```kotlin
   dependencies {
      implementation("io.mcarle:konvert-api:$konvertVersion")
   }
   ```
2. Agregue el complemento KSP:

   ```kotlin
   plugins {
       id("com.google.devtools.ksp").version("2.3.5")
   }
   ```

3. Añada `konvert` como una dependencia de `ksp`:
   ```kotlin
   dependencies {
      ksp("io.mcarle:konvert:$konvertVersion")
   }
   ```

## Configuración de Maven

Para usar Konvert con Maven, debes realizar los siguientes pasos:

1. Agrega `konvert-api` como dependencia para usar las anotaciones:
   ```xml
   <dependency>
       <groupId>io.mcarle</groupId>
       <artifactId>konvert-api</artifactId>
       <version>${konvert.version}</version>
   </dependency>
   ```
2. Use el [ksp-maven-plugin](https://github.com/mcarleio/ksp-maven-plugin) con `konvert` como dependencia:

   ```xml
   <plugin>
       <groupId>io.mcarle</groupId>
       <artifactId>ksp-maven-plugin</artifactId>
       <version>2.3.5-1</version>
       <executions>
           <execution>
               <goals>
                   <goal>ksp</goal>
               </goals>
           </execution>
       </executions>
       <dependencies>
           <dependency>
               <groupId>io.mcarle</groupId>
               <artifactId>konvert</artifactId>
               <version>${konvert.version}</version>
           </dependency>
       </dependencies>
   </plugin>
   ```
## Más información

* Konvert se compila y prueba principalmente con JDK >=17. También debería funcionar con cualquier versión inferior a JDK 17, pero no está garantizado.
* Konvert es capaz de convertir clases desde y hacia clases escritas en Java (y probablemente también en otros lenguajes JVM).

### Alternativas

Hay algunas alternativas a Konvert que quizás quieras revisar:

* [Mappie](https://github.com/Mr-Mappie/mappie)

  Mappie no usa KSP, sino que es un plugin de compilador para Kotlin.
  Utiliza reflexión en lugar de referencias de String para **definir** los mapeos,
  pero **reemplaza el código de reflexión** durante el tiempo de compilación con código idiomático Kotlin.

* [MapStruct](https://mapstruct.org/)

  MapStruct es una conocida biblioteca de mapeo Java que usa procesamiento de anotaciones (ver [kapt](https://kotlinlang.org/docs/kapt.html)).
  Puede usarse en proyectos Kotlin, pero no soporta características específicas de Kotlin.

* [kMapper](https://github.com/s0nicyouth/kmapper)

  kMapper también es un procesador KSP, pero parece soportar solo mapeo entre clases de datos Kotlin.

* [ShapeShift️](https://github.com/krud-dev/shapeshift)

  ShapeShift usa reflexión en tiempo de ejecución para mapear entre clases.

* **Codifica tú mismo** (con soporte de IA)

  De hecho, a veces puede ser más rápido, fácil y flexible escribir código de mapeo manualmente.
  Con la ayuda de herramientas de IA hoy en día, esta tarea repetitiva puede automatizarse hasta cierto punto.


## Construcción

### Gradle

Para construir el proyecto, simplemente ejecuta


> gradle build

#### Ejecutar todas las pruebas

Por defecto, solo se ejecuta un subconjunto de las pruebas disponibles, que deberían verificar la mayoría de la funcionalidad de Konvert.
Para ejecutar todas las pruebas, añade la propiedad `runAllTests`, por ejemplo:

> gradle test -PrunAllTests

### Documentación

Para servir el sitio Jekyll localmente, simplemente ejecuta el siguiente comando dentro de `docs`:

> docker run --rm -it -v "$PWD":/site -p 4000:4000 bretfisher/jekyll-serve

### CI

GitHub Actions se usan para:

* [compilar y probar](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/build.yml)
* [lanzar y publicar](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/release.yml) en un repositorio Maven
* [generar documentación](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/pages.yml) y desplegarla en GitHub Pages.

## Registro de cambios

El [registro de cambios](https://raw.githubusercontent.com/mcarleio/konvert/main/CHANGELOG.md) contiene todos los cambios notables.

## Licencia

    Copyright 2023 Marcel Carlé

    Licenciado bajo la Licencia Apache, Versión 2.0 (la "Licencia");
    no puedes usar este archivo excepto en conformidad con la Licencia.
    Puedes obtener una copia de la Licencia en

    http://www.apache.org/licenses/LICENSE-2.0

    A menos que lo exija la ley aplicable o se acuerde por escrito, el software
    distribuido bajo la Licencia se distribuye "TAL CUAL",
    SIN GARANTÍAS NI CONDICIONES DE NINGÚN TIPO, ya sean expresas o implícitas.
    Consulte la Licencia para conocer el idioma específico que rige los permisos y
    limitaciones bajo la Licencia.

[maven-image]: https://img.shields.io/maven-central/v/io.mcarle/konvert.svg

[maven-url]: https://central.sonatype.com/artifact/io.mcarle/konvert/

[license-image]: https://img.shields.io/github/license/mcarleio/konvert.svg

[codecov-image]: https://img.shields.io/codecov/c/github/mcarleio/konvert.svg

[codecov-url]: https://codecov.io/gh/mcarleio/konvert


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---