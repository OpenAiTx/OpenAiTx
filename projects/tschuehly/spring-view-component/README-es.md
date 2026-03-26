![image](https://user-images.githubusercontent.com/33346637/235085980-eb16eaa3-ec89-4293-9609-cf651a44f60e.png)

Spring ViewComponent te permite crear componentes de interfaz de usuario renderizados en el servidor, reutilizables, encapsulados y con tipos seguros.

##### Tabla de Contenidos

- [¿Qué es un ViewComponent?](#whats-a-viewcomponent)
- [Renderizar un ViewComponent](#render-a-viewcomponent)
- [Anidación de ViewComponents:](#nesting-viewcomponents)
- [Configuración para Desarrollo Local](#local-development)
- [Configuración para Producción](#production-configuration)
- [Instalación](#installation)
- [Implementación Técnica](#technical-implementation)

## ¿Qué es un ViewComponent?

Los ViewComponents consolidan la lógica necesaria para una plantilla en una sola clase,
resultando en un objeto cohesivo que es fácil de entender.
([Fuente: ViewComponent para Rails](https://viewcomponent.org/))

Un Spring ViewComponent es un Bean de Spring que define el contexto para nuestra Plantilla:

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

Definimos el contexto creando un registro que implementa la interfaz ViewContext

A continuación, añadimos la anotación `@ViewComponent` a una clase y definimos un método que devuelve el registro `SimpleView`.

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

Un ViewComponent siempre necesita una plantilla HTML correspondiente.  
Definimos la plantilla en el SimpleViewComponent.[html/jte/kte] en el mismo paquete que nuestra clase ViewComponent.  

Podemos usar [Thymeleaf](https://thymeleaf.org)

````html 
// SimpleViewComponent.html
<!--/*@thymesVar id="d" type="de.tschuehly.example.thymeleafjava.web.simple.SimpleViewComponent.SimpleView"*/-->
<div th:text="${simpleView.helloWorld()}"></div>
````
o [JTE](https://jte.gg/#5-minutes-example)


```html
// SimpleViewComponent.jte
@param de.tschuehly.example.jte.web.simple.SimpleViewComponent.SimpleView simpleView
<div>${simpleView.helloWorld()}</div>
```

o [KTE](https://jte.gg/#5-minutes-example)

```html
@param simpleView: de.tschuehly.kteviewcomponentexample.web.simple.SimpleViewComponent.SimpleView
<div>
  <h2>This is the SimpleViewComponent</h2>
  <div>${simpleView.helloWorld}</div>
</div>
```

## Renderizar un ViewComponent

Luego podemos llamar al método render en nuestro controlador para renderizar la plantilla.
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

## Ejemplos

Si quieres empezar de inmediato, puedes encontrar ejemplos para todas las combinaciones posibles de idiomas aquí:
[Ejemplos](/examples/)

## Anidando ViewComponents:

Podemos anidar componentes pasando un ViewContext como propiedad de nuestro registro,
si también lo tenemos como parámetro de nuestro método render, podemos crear fácilmente diseños:

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

En Thymeleaf renderizamos el ViewComponent pasado con el atributo `view:component="${viewContext}"`.

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

En JTE/KTE podemos simplemente llamar al registro LayoutView directamente en una expresión:

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

## Configuración de Desarrollo Local

Puedes habilitar la recarga en caliente de las plantillas en desarrollo, necesitas tener Spring Boot DevTools como dependencia.

```properties
spring.view-component.local-development=true
```

## Instalación

### Thymeleaf:

[ÚLTIMA_VERSIÓN](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-thymeleaf) en Maven Central

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

[ÚLTIMA_VERSIÓN](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-jte) en Maven Central


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

[ÚLTIMA_VERSIÓN](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-kte) en Maven Central


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

## Implementación Técnica

Spring ViewComponent envuelve el contenedor Spring MVC usando un Aspecto de AspectJ y resuelve automáticamente la plantilla y coloca el ViewContext en el ModelAndViewContainer

![image](https://github.com/tschuehly/spring-view-component/assets/33346637/ad2f2517-7eab-4b07-9249-59aeaae1e778)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---