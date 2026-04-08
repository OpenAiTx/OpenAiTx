# Konvert

[![Maven Central][maven-image]][maven-url]
[![License][license-image]](LICENSE)
[![Code Coverage][codecov-image]][codecov-url]

Voici Konvert, un générateur de code de mappage Kotlin utilisant [Kotlin Symbol Processing (KSP)](https://github.com/google/ksp).
Conçu spécifiquement pour Kotlin et ses fonctionnalités, Konvert prend en charge un large éventail de cas d'utilisation.

Fonctionnalités principales :
* 🧩 supporte **divers types de classes** → `data`, `enum`, `value`, POJO classiques
* 🔄 **Sécurité null** par défaut
* ⚙️ **Conversions intelligentes** (`Int` → `String`, `Instant` → `Date`, …)
   * 🔧 Définir des **convertisseurs réutilisables** avec `@Konverter`
   * 🔌 Étendre via **SPI** pour un contrôle ultime
* 🔗 **Collections & maps** — mappage des éléments inclus
* 🛠️ **Personnalisation** fine du mappage des propriétés
* ☕ 100% **Interopérabilité Java**
* ✨ Génère un code **Kotlin propre et idiomatique**
   * ⏱️ Généré à la **compilation**
   * 🚫 **Zéro réflexion**, **aucune surcharge à l'exécution**
* 📦 Fonctionne parfaitement avec **Gradle** et **Maven**

> ℹ️ Ce README fournit un aperçu basique, pour plus de détails consultez la [documentation](https://mcarleio.github.io/konvert).

## Utilisation

Il existe trois façons différentes d’utiliser Konvert :

1. Utilisation de `@KonvertTo` :
   ```kotlin
   @KonvertTo(PersonDto::class)
   data class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)
   ```
   Cela générera la fonction d'extension suivante
   ```kotlin
   fun Person.toPersonDto(): PersonDto =
      PersonDto(firstName = firstName, lastName = lastName)
   ```
2. Utilisation de `@KonvertFrom` (particulièrement utile si vous ne pouvez pas modifier le code de la classe source)

   ```kotlin
   class Person(val firstName: String, val lastName: String) {
      @KonvertFrom(PersonDto::class)
      companion object
   }
   class PersonDto(val firstName: String, val lastName: String)
   ```
   Cela générera la fonction d'extension suivante
   ```kotlin
   fun Person.Companion.fromPersonDto(personDto: PersonDto): Person =
      Person(firstName = personDto.firstName, lastName = personDto.lastName)
   ```

3. Utilisation de `@Konverter` :
   ```kotlin
   class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)

   @Konverter
   interface PersonMapper {
      fun toDto(person: Person): PersonDto
   }
   ```
   Cela générera l'objet suivant
   ```kotlin
   object PersonMapperImpl: PersonMapper {
      override fun toDto(person: Person): PersonDto
         = PersonDto(firstName = person.firstName, lastName = person.lastName)
   }
   ```
Pour un exemple de projet simple, consultez le [répertoire example](example).

### Correspondances de types

Pour des correspondances de types simples, comme de `Instant` à `Date`, un convertisseur de type est déjà fourni avec Konvert :

```kotlin
@KonvertTo(PersonDto::class)
class Person(val name: String, val birthday: Instant)
class PersonDto(val name: String, val birthday: Date)
```

Cela générera la fonction d'extension suivante

```kotlin
fun Person.toPersonDto(): PersonDto = PersonDto(
   name = name,
   birthday = birthday.let { java.util.Date.from(it) }
)
```

Consultez la [documentation](https://mcarleio.github.io/konvert/typeconverter/) pour une liste des convertisseurs de types fournis.

🛈 : Vous pouvez également créer votre propre bibliothèque de convertisseurs de types en
implémentant [TypeConverter](https://raw.githubusercontent.com/mcarleio/konvert/main/converter-api/src/main/kotlin/io/mcarle/konvert/converter/api/TypeConverter.kt) et en l'enregistrant
via [SPI](https://fr.wikipedia.org/wiki/Interface_de_fournisseur_de_services).

### Ajustement fin

La plupart du temps, les classes source et cible peuvent ne pas avoir les mêmes noms et types de propriétés.
Vous pouvez configurer des mappages spécifiques et renommer la fonction d’extension générée ainsi :

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

Cela générera la fonction d'extension suivante

```kotlin
fun Person.asDto(): PersonDto = PersonDto(
   givenName = firstName,
   familyName = lastName
)
```

Pour plus de fonctionnalités, consultez
la [documentation](https://mcarleio.github.io/konvert/)
les KDocs des [annotations](annotations/src/main/kotlin/io/mcarle/konvert/api),
le [projet exemple](example/src/main/kotlin/io/mcarle/konvert/example)
ou les [tests](processor/src/test/kotlin/io/mcarle/konvert/processor).

## Configuration Gradle

Pour utiliser Konvert avec Gradle, vous devez effectuer les étapes suivantes :

1. Ajoutez `konvert-api` comme dépendance pour utiliser les annotations :
   ```kotlin
   dependencies {
      implementation("io.mcarle:konvert-api:$konvertVersion")
   }
   ```
2. Ajouter le plugin KSP :

   ```kotlin
   plugins {
       id("com.google.devtools.ksp").version("2.3.5")
   }
   ```

3. Ajoutez `konvert` en tant que dépendance `ksp` :
   ```kotlin
   dependencies {
      ksp("io.mcarle:konvert:$konvertVersion")
   }
   ```

## Configuration Maven

Pour utiliser Konvert avec Maven, vous devez effectuer les étapes suivantes :

1. Ajoutez `konvert-api` en tant que dépendance pour utiliser les annotations :
   ```xml
   <dependency>
       <groupId>io.mcarle</groupId>
       <artifactId>konvert-api</artifactId>
       <version>${konvert.version}</version>
   </dependency>
   ```

2. Utilisez le [ksp-maven-plugin](https://github.com/mcarleio/ksp-maven-plugin) avec `konvert` comme dépendance :
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

## Informations complémentaires

* Konvert est principalement compilé et testé avec JDK >=17. Il devrait également fonctionner avec des versions inférieures à JDK 17, mais cela n’est pas garanti.
* Konvert est capable de convertir des classes depuis et vers des classes écrites en Java (et probablement aussi dans d’autres langages JVM).

### Alternatives

Il existe quelques alternatives à Konvert que vous pourriez vouloir découvrir :

* [Mappie](https://github.com/Mr-Mappie/mappie)

  Mappie n’utilise pas KSP, mais est plutôt un plugin de compilation pour Kotlin lui-même.
  Il utilise la réflexion plutôt que des références sous forme de chaînes pour **définir** les mappings,
  mais **remplace le code de réflexion** lors de la compilation par du code Kotlin idiomatique.

* [MapStruct](https://mapstruct.org/)

  MapStruct est une bibliothèque de mapping Java bien connue utilisant le traitement d’annotations (voir [kapt](https://kotlinlang.org/docs/kapt.html)).
  Peut être utilisée dans des projets Kotlin, mais ne supporte pas les fonctionnalités spécifiques à Kotlin.

* [kMapper](https://github.com/s0nicyouth/kmapper)

  kMapper est aussi un processeur KSP, mais semble ne supporter que le mapping entre classes de données Kotlin.

* [ShapeShift️](https://github.com/krud-dev/shapeshift)

  ShapeShift utilise la réflexion à l’exécution pour mapper entre les classes.

* **Codez vous-même** (avec le support de l’IA)

  En effet, il peut parfois être plus rapide, plus simple et plus flexible d’écrire manuellement le code de mapping.
  Avec l’aide des outils d’IA actuels, cette tâche répétitive peut être automatisée dans une certaine mesure.


## Compilation

### Gradle

Pour construire le projet, il suffit d’exécuter

> gradle build

#### Exécuter tous les tests

Par défaut, seul un sous-ensemble des tests disponibles est exécuté, ce qui devrait vérifier la plupart des fonctionnalités de Konvert.
Pour exécuter tous les tests, ajoutez la propriété `runAllTests`, par exemple :

> gradle test -PrunAllTests

### Documentation

Pour servir le site Jekyll localement, exécutez simplement la commande suivante dans `docs` :

> docker run --rm -it -v "$PWD":/site -p 4000:4000 bretfisher/jekyll-serve

### CI

GitHub Actions sont utilisés pour :

* [construire et tester](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/build.yml)
* [publier et diffuser](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/release.yml) vers un dépôt Maven
* [générer la documentation](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/pages.yml) et la déployer sur GitHub Pages.

## Journal des modifications

Le [journal des modifications](https://raw.githubusercontent.com/mcarleio/konvert/main/CHANGELOG.md) contient tous les changements notables.

## Licence

    Copyright 2023 Marcel Carlé

    Sous licence Apache, version 2.0 (la "Licence");
    vous ne pouvez utiliser ce fichier que conformément à la Licence.
    Vous pouvez obtenir une copie de la Licence à

    http://www.apache.org/licenses/LICENSE-2.0

    Sauf exigence légale ou accord écrit, le logiciel
    distribué sous la Licence est distribué "EN L’ÉTAT",
    SANS GARANTIES NI CONDITIONS D'AUCUNE SORTE, explicites ou implicites.
    Consultez la Licence pour les permissions spécifiques régissant et
    les limitations sous la Licence.

[maven-image]: https://img.shields.io/maven-central/v/io.mcarle/konvert.svg

[maven-url]: https://central.sonatype.com/artifact/io.mcarle/konvert/

[license-image]: https://img.shields.io/github/license/mcarleio/konvert.svg

[codecov-image]: https://img.shields.io/codecov/c/github/mcarleio/konvert.svg

[codecov-url]: https://codecov.io/gh/mcarleio/konvert


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---