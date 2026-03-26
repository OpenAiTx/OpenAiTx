![image](https://user-images.githubusercontent.com/33346637/235085980-eb16eaa3-ec89-4293-9609-cf651a44f60e.png)

Spring ViewComponent vous permet de créer des composants UI côté serveur, typesafe, réutilisables et encapsulés.

##### Table des matières

- [Qu’est-ce qu’un ViewComponent ?](#whats-a-viewcomponent)
- [Rendre un ViewComponent](#render-a-viewcomponent)
- [Imbrication des ViewComponents :](#nesting-viewcomponents)
- [Configuration pour le développement local](#local-development)
- [Configuration pour la production](#production-configuration)
- [Installation](#installation)
- [Implémentation technique](#technical-implementation)

## Qu’est-ce qu’un ViewComponent ?

Les ViewComponents consolident la logique nécessaire à un template dans une seule classe,
ce qui donne un objet cohérent et facile à comprendre. 
([Source : ViewComponent pour Rails](https://viewcomponent.org/))

Un Spring ViewComponent est un Bean Spring qui définit le contexte pour notre Template :

<details open>
    <summary>Java</summary>

```java

@ViewComponent
public class SimpleViewComponent {

  public record SimpleView(String helloWorld) implements ViewContext {

  }

  public SimpleView render() {
    return new SimpleView("Hello World");
  }
}
```

</details>

Nous définissons le contexte en créant un enregistrement qui implémente l'interface ViewContext

Ensuite, nous ajoutons l'annotation `@ViewComponent` à une classe et définissons une méthode qui retourne l'enregistrement `SimpleView`.

<details>
    <summary>Kotlin</summary>

```kotlin
// SimpleViewComponent.kt
@ViewComponent
class SimpleViewComponent {
    fun render() = SimpleView("Hello World")

    data class SimpleView(val helloWorld: String) : ViewContext
}
```

</details>

Un ViewComponent nécessite toujours un modèle HTML correspondant.
Nous définissons le modèle dans le SimpleViewComponent.[html/jte/kte] Dans le même package que notre classe ViewComponent.

Nous pouvons utiliser [Thymeleaf](https://thymeleaf.org)

````html 
// SimpleViewComponent.html
<!--/*@thymesVar id="d" type="de.tschuehly.example.thymeleafjava.web.simple.SimpleViewComponent.SimpleView"*/-->
<div th:text="${simpleView.helloWorld()}"></div>
````

ou [JTE](https://jte.gg/#5-minutes-example)

```html
// SimpleViewComponent.jte
@param de.tschuehly.example.jte.web.simple.SimpleViewComponent.SimpleView simpleView
<div>${simpleView.helloWorld()}</div>
```

ou [KTE](https://jte.gg/#5-minutes-example)

```html
@param simpleView: de.tschuehly.kteviewcomponentexample.web.simple.SimpleViewComponent.SimpleView
<div>
  <h2>This is the SimpleViewComponent</h2>
  <div>${simpleView.helloWorld}</div>
</div>
```

## Rendre un ViewComponent

Nous pouvons ensuite appeler la méthode render dans notre contrôleur pour rendre le template.
<details open>
    <summary>Java</summary>

```java

@Controller
public class SimpleController {

  private final SimpleViewComponent simpleViewComponent;

  public TestController(SimpleViewComponent simpleViewComponent) {
    this.simpleViewComponent = simpleViewComponent;
  }

  @GetMapping("/")
  ViewContext simple() {
    return simpleViewComponent.render();
  }
}
```

</details>

<details>
    <summary>Kotlin</summary>

```kotlin
// Router.kt
@Controller
class SimpleController(
    private val simpleViewComponent: SimpleViewComponent,
) {

    @GetMapping("/")
    fun simpleComponent() = simpleViewComponent.render()
}
```

</details>

## Exemples

Si vous voulez commencer tout de suite, vous pouvez trouver des exemples pour toutes les combinaisons de langues possibles ici :
[Exemples](/examples/)

## Imbrication de ViewComponents :

Nous pouvons imbriquer des composants en passant un ViewContext comme propriété de notre enregistrement,
si nous l'avons également comme paramètre de notre méthode de rendu, nous pouvons facilement créer des mises en page :

<details open>
    <summary>Java</summary>

```java

@ViewComponent
public
class LayoutViewComponent {

  private record LayoutView(ViewContext nestedViewComponent) implements ViewContext {

  }

  public ViewContext render(ViewContext nestedViewComponent) {
    return new LayoutView(nestedViewComponent);
  }
}
```

</details>
<details >
    <summary>Kotlin</summary>

```kotlin
@ViewComponent
class LayoutViewComponent {
    data class LayoutView(val nestedViewComponent: ViewContext) : ViewContext

    fun render(nestedViewComponent: ViewContext) = LayoutView(nestedViewComponent)

}
```

</details>

### Thymeleaf

Dans Thymeleaf, nous rendons le ViewComponent passé avec l'attribut `view:component="${viewContext}"`.

```html

<nav>
  This is a navbar
</nav>
<!--/*@thymesVar id="layoutView" type="de.tschuehly.example.thymeleafjava.web.layout.LayoutViewComponent.LayoutView"*/-->
<div view:component="${layoutView.nestedViewComponent()}"></div>
<footer>
  This is a footer
</footer>
```

### JTE / KTE

Dans JTE/KTE, nous pouvons simplement appeler directement l'enregistrement LayoutView dans une expression :

```html
@param layoutView: de.tschuehly.kteviewcomponentexample.web.layout.LayoutViewComponent.LayoutView
<nav>
  This is a Navbar
</nav>
<body>
${layoutView.nestedViewComponent}
</body>
<footer>
  This is a footer
</footer>
```

## Configuration de développement local

Vous pouvez activer le rechargement à chaud des modèles en développement, vous devez avoir Spring Boot DevTools comme dépendance.

```properties
spring.view-component.local-development=true
```

## Installation

### Thymeleaf :

[LATEST_VERSION](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-thymeleaf) sur Maven Central

<details open>
    <summary>Gradle</summary>

```kotlin
implementation("de.tschuehly:spring-view-component-thymeleaf:0.9.1")
sourceSets {
    main {
        resources {
            srcDir("src/main/java")
            exclude("**/*.java")
        }
    }

}
```
</details>

<details>
    <summary>Maven</summary>

```xml
<project>
  <dependencies>
    <dependency>
      <groupId>de.tschuehly</groupId>
      <artifactId>spring-view-component-thymeleaf</artifactId>
      <version>0.9.1</version>
    </dependency>
  </dependencies>
  <build>
    <resources>
      <resource>
        <directory>src/main/java</directory>
        <includes>
          <include>**/*.html</include>
        </includes>
      </resource>
      <resource>
        <directory>src/main/resources</directory>
      </resource>
    </resources>
    <plugins>
      <plugin>
        <artifactId>maven-resources-plugin</artifactId>
        <version>3.3.0</version>
      </plugin>
    </plugins>
  </build>
</project>
```

</details>

### JTE

[DERNIÈRE_VERSION](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-jte) sur Maven Central


<details open>
    <summary>Gradle</summary>

```kotlin
plugins {
    id("gg.jte.gradle") version("3.2.1")
}

implementation("de.tschuehly:spring-view-component-jte:0.9.1")

jte{
    generate()
    sourceDirectory.set(kotlin.io.path.Path("src/main/java"))
}
```

</details>

<details>
    <summary>Maven</summary>

```xml
<project >
  <dependencies>
    <dependency>
      <groupId>de.tschuehly</groupId>
      <artifactId>spring-view-component-jte</artifactId>
      <version>0.9.1</version>
    </dependency>
  </dependencies>
  <build>
    <plugins>
      <plugin>
        <groupId>gg.jte</groupId>
        <artifactId>jte-maven-plugin</artifactId>
        <version>3.1.12</version>
        <configuration>
          <sourceDirectory>${project.basedir}/src/main/java</sourceDirectory>
          <contentType>Html</contentType>
        </configuration>
        <executions>
          <execution>
            <phase>generate-sources</phase>
            <goals>
              <goal>generate</goal>
            </goals>
          </execution>
        </executions>
      </plugin>
    </plugins>
  </build>
</project>
```

</details>

### KTE

[DERNIÈRE_VERSION](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-kte) sur Maven Central


<details open>
    <summary>Gradle</summary>

```kotlin

plugins {
    id("gg.jte.gradle") version ("3.1.12")
}

dependencies {
    implementation("de.tschuehly:spring-view-component-kte:0.9.1")
}

jte {
    generate()
    sourceDirectory.set(kotlin.io.path.Path("src/main/kotlin"))
}
```

</details>

## Implémentation Technique

Spring ViewComponent encapsule le conteneur Spring MVC en utilisant un Aspect AspectJ et résout automatiquement le template tout en plaçant le ViewContext dans le ModelAndViewContainer

![image](https://github.com/tschuehly/spring-view-component/assets/33346637/ad2f2517-7eab-4b07-9249-59aeaae1e778)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---