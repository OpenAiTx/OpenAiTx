![image](https://user-images.githubusercontent.com/33346637/235085980-eb16eaa3-ec89-4293-9609-cf651a44f60e.png)

Spring ViewComponent は、型安全で再利用可能かつカプセル化されたサーバーサイドレンダリングUIコンポーネントを作成することを可能にします。

##### 目次

- [ViewComponentとは？](#whats-a-viewcomponent)
- [ViewComponentのレンダリング](#render-a-viewcomponent)
- [ViewComponentのネスト](#nesting-viewcomponents)
- [ローカル開発設定](#local-development)
- [本番環境設定](#production-configuration)
- [インストール](#installation)
- [技術的実装](#technical-implementation)

## ViewComponentとは？

ViewComponentは、テンプレートに必要なロジックを単一のクラスに統合し、
理解しやすい一貫したオブジェクトを生み出します。
（[出典: ViewComponent for Rails](https://viewcomponent.org/)）

Spring ViewComponentは、テンプレートのコンテキストを定義するSpring Beanです：

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

ViewContextインターフェースを実装するレコードを作成してコンテキストを定義します

次に、クラスに`@ViewComponent`アノテーションを追加し、`SimpleView`レコードを返すメソッドを定義します

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

ViewComponentには常に対応するHTMLテンプレートが必要です。  
テンプレートはSimpleViewComponent.[html/jte/kte]で定義します。ViewComponentクラスと同じパッケージに置きます。

[Thymeleaf](https://thymeleaf.org)を使用することもできます。

````html 
// SimpleViewComponent.html
<!--/*@thymesVar id="d" type="de.tschuehly.example.thymeleafjava.web.simple.SimpleViewComponent.SimpleView"*/-->
<div th:text="${simpleView.helloWorld()}"></div>
````

または [JTE](https://jte.gg/#5-minutes-example)

```html
// SimpleViewComponent.jte
@param de.tschuehly.example.jte.web.simple.SimpleViewComponent.SimpleView simpleView
<div>${simpleView.helloWorld()}</div>
```

または [KTE](https://jte.gg/#5-minutes-example)

```html
@param simpleView: de.tschuehly.kteviewcomponentexample.web.simple.SimpleViewComponent.SimpleView
<div>
  <h2>This is the SimpleViewComponent</h2>
  <div>${simpleView.helloWorld}</div>
</div>
```

## ViewComponentをレンダリングする

次に、コントローラーでrenderメソッドを呼び出してテンプレートをレンダリングできます。
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

## 例

すぐに始めたい場合は、すべての可能な言語の組み合わせの例がこちらにあります：
[例](/examples/)

## ViewComponentsのネスト：

レコードのプロパティとしてViewContextを渡すことでコンポーネントをネストできます。
レンダーメソッドのパラメータとしても持っていれば、簡単にレイアウトを作成できます：

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

Thymeleafでは、渡されたViewComponentを`view:component="${viewContext}"`属性でレンダリングします。

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

JTE/KTEでは、レイアウトビューのレコードを式内で直接呼び出すことができます：

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

## ローカル開発構成

テンプレートのホットリロードを開発環境で有効にするには、Spring Boot DevTools を依存関係に含める必要があります。

```properties
spring.view-component.local-development=true
```

## インストール

### Thymeleaf:

[Maven Centralの最新バージョン](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-thymeleaf)

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

[Maven Centralの最新バージョン](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-jte)


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

[Maven CentralのLATEST_VERSION](https://central.sonatype.com/artifact/de.tschuehly/spring-view-component-kte)


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

## 技術的実装

Spring ViewComponentはAspectJのアスペクトを使用してSpring MVCコンテナをラップし、自動的にテンプレートを解決してViewContextをModelAndViewContainerに配置します

![image](https://github.com/tschuehly/spring-view-component/assets/33346637/ad2f2517-7eab-4b07-9249-59aeaae1e778)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---