![image](https://user-images.githubusercontent.com/33346637/235085980-eb16eaa3-ec89-4293-9609-cf651a44f60e.png)

Spring ViewComponent는 타입 안전하며 재사용 가능하고 캡슐화된 서버 렌더링 UI 컴포넌트를 생성할 수 있게 해줍니다.

##### 목차

- [ViewComponent란 무엇인가?](#whats-a-viewcomponent)
- [ViewComponent 렌더링하기](#render-a-viewcomponent)
- [ViewComponent 중첩하기:](#nesting-viewcomponents)
- [로컬 개발 설정](#local-development)
- [프로덕션 설정](#production-configuration)
- [설치](#installation)
- [기술 구현](#technical-implementation)

## ViewComponent란 무엇인가?

ViewComponent는 템플릿에 필요한 로직을 하나의 클래스로 통합하여,
이해하기 쉬운 응집력 있는 객체를 만듭니다.
([출처: ViewComponent for Rails](https://viewcomponent.org/))

Spring ViewComponent는 템플릿의 컨텍스트를 정의하는 Spring Bean입니다:

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

우리는 ViewContext 인터페이스를 구현하는 레코드를 생성하여 컨텍스트를 정의합니다

다음으로, 클래스에 `@ViewComponent` 어노테이션을 추가하고 `SimpleView` 레코드를 반환하는 메서드를 정의합니다

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

ViewComponent에는 항상 해당하는 HTML 템플릿이 필요합니다.
템플릿은 SimpleViewComponent.[html/jte/kte]에 정의하며, ViewComponent 클래스와 같은 패키지에 위치합니다.

[Thymeleaf](https://thymeleaf.org)를 사용할 수 있습니다.


````html 
// SimpleViewComponent.html
<!--/*@thymesVar id="d" type="de.tschuehly.example.thymeleafjava.web.simple.SimpleViewComponent.SimpleView"*/-->
<div th:text="${simpleView.helloWorld()}"></div>
````

또는 [JTE](https://jte.gg/#5-minutes-example)

```html
// SimpleViewComponent.jte
@param de.tschuehly.example.jte.web.simple.SimpleViewComponent.SimpleView simpleView
<div>${simpleView.helloWorld()}</div>
```
또는 [KTE](https://jte.gg/#5-minutes-example)


```html
@param simpleView: de.tschuehly.kteviewcomponentexample.web.simple.SimpleViewComponent.SimpleView
<div>
  <h2>This is the SimpleViewComponent</h2>
  <div>${simpleView.helloWorld}</div>
</div>
```

## 뷰 컴포넌트 렌더링하기

컨트롤러에서 render 메서드를 호출하여 템플릿을 렌더링할 수 있습니다.
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

## 예제

바로 시작하고 싶다면 모든 가능한 언어 조합에 대한 예제를 여기에서 찾을 수 있습니다:
[예제](/examples/)

## ViewComponents 중첩:

ViewContext를 레코드의 속성으로 전달하여 컴포넌트를 중첩할 수 있으며,
렌더 메서드의 매개변수로도 가지고 있다면 쉽게 레이아웃을 만들 수 있습니다:

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
    <summary>코틀린</summary>

```kotlin
@ViewComponent
class LayoutViewComponent {
    data class LayoutView(val nestedViewComponent: ViewContext) : ViewContext

    fun render(nestedViewComponent: ViewContext) = LayoutView(nestedViewComponent)

}
```

</details>

### 타임리프

타임리프에서는 전달된 ViewComponent를 `view:component="${viewContext}"` 속성으로 렌더링합니다.

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

JTE/KTE에서는 표현식에서 LayoutView 레코드를 직접 호출할 수 있습니다:

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

## 로컬 개발 구성

개발 중에 템플릿의 핫 리로딩을 활성화하려면 Spring Boot DevTools를 의존성으로 포함해야 합니다.

```properties
spring.view-component.local-development=true
```

## 설치

### 타임리프:

Maven Central의 [LATEST_VERSION](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-thymeleaf)

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

[Maven Central의 최신 버전](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-jte)


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

[Maven Central의 최신 버전](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-kte)


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

## 기술 구현

Spring ViewComponent는 AspectJ Aspect를 사용하여 Spring MVC 컨테이너를 래핑하고 템플릿을 자동으로 해결하며 ViewContext를 ModelAndViewContainer에 넣습니다

![image](https://github.com/tschuehly/spring-view-component/assets/33346637/ad2f2517-7eab-4b07-9249-59aeaae1e778)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---