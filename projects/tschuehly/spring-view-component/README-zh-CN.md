![image](https://user-images.githubusercontent.com/33346637/235085980-eb16eaa3-ec89-4293-9609-cf651a44f60e.png)

Spring ViewComponent 允许您创建类型安全、可重用且封装的服务器渲染 UI 组件。

##### 目录

- [什么是 ViewComponent？](#whats-a-viewcomponent)
- [渲染 ViewComponent](#render-a-viewcomponent)
- [嵌套 ViewComponent：](#nesting-viewcomponents)
- [本地开发配置](#local-development)
- [生产环境配置](#production-configuration)
- [安装](#installation)
- [技术实现](#technical-implementation)

## 什么是 ViewComponent？

ViewComponent 将模板所需的逻辑整合到一个单一的类中，
从而形成一个易于理解的内聚对象。
（[来源：Rails 的 ViewComponent](https://viewcomponent.org/)）

Spring ViewComponent 是一个 Spring Bean，定义了我们模板的上下文：

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

我们通过创建一个实现了 ViewContext 接口的记录来定义上下文

接下来，我们在一个类上添加 `@ViewComponent` 注解，并定义一个返回 `SimpleView` 记录的方法。

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

一个 ViewComponent 总是需要一个对应的 HTML 模板。  
我们在 SimpleViewComponent.[html/jte/kte] 中定义模板，  
与我们的 ViewComponent 类位于同一个包中。  

我们可以使用 [Thymeleaf](https://thymeleaf.org)  

````html 
// SimpleViewComponent.html
<!--/*@thymesVar id="d" type="de.tschuehly.example.thymeleafjava.web.simple.SimpleViewComponent.SimpleView"*/-->
<div th:text="${simpleView.helloWorld()}"></div>
````

或 [JTE](https://jte.gg/#5-minutes-example)

```html
// SimpleViewComponent.jte
@param de.tschuehly.example.jte.web.simple.SimpleViewComponent.SimpleView simpleView
<div>${simpleView.helloWorld()}</div>
```

或 [KTE](https://jte.gg/#5-minutes-example)

```html
@param simpleView: de.tschuehly.kteviewcomponentexample.web.simple.SimpleViewComponent.SimpleView
<div>
  <h2>This is the SimpleViewComponent</h2>
  <div>${simpleView.helloWorld}</div>
</div>
```

## 渲染 ViewComponent

然后我们可以在控制器中调用 render 方法来渲染模板。
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

## 示例

如果您想立即开始，可以在此处找到所有可能语言组合的示例：
[示例](/examples/)

## 嵌套 ViewComponents：

我们可以通过将 ViewContext 作为记录的属性传递来嵌套组件，
如果我们在渲染方法中也将其作为参数，就可以轻松创建布局：

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

在 Thymeleaf 中，我们使用 `view:component="${viewContext}"` 属性来渲染传递的 ViewComponent。

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

在 JTE/KTE 中，我们可以直接在表达式中调用 LayoutView 记录：

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

## 本地开发配置

您可以在开发中启用模板的热重载，您需要将 Spring Boot DevTools 作为依赖项。

```properties
spring.view-component.local-development=true
```

## 安装

### Thymeleaf:

Maven中央仓库上的 [LATEST_VERSION](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-thymeleaf)

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

[Maven Central上的最新版本](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-jte)


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

[MAVEN中央库上的最新版本](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-kte)


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

## 技术实现

Spring ViewComponent 使用 AspectJ 切面封装 Spring MVC 容器，自动解析模板并将 ViewContext 放入 ModelAndViewContainer 中

![image](https://github.com/tschuehly/spring-view-component/assets/33346637/ad2f2517-7eab-4b07-9249-59aeaae1e778)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---