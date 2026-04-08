# Konvert

[![Maven Central][maven-image]][maven-url]
[![License][license-image]](LICENSE)
[![Code Coverage][codecov-image]][codecov-url]

这是 Konvert，一款基于 [Kotlin 符号处理（KSP）](https://github.com/google/ksp) 的 Kotlin 映射代码生成器。
专为 Kotlin 及其特性设计，Konvert 支持广泛的使用场景。

主要特性：
* 🧩 支持 **多种类类型** → `data`、`enum`、`value`、普通 POJO
* 🔄 默认 **空安全**
* ⚙️ **智能转换**（`Int` → `String`，`Instant` → `Date`，等）
   * 🔧 使用 `@Konverter` 定义 **可复用转换器**
   * 🔌 通过 **SPI** 扩展，实现极致控制
* 🔗 **集合与映射** — 包括元素映射
* 🛠️ **细粒度** 属性映射自定义
* ☕ 100% **Java 互操作性**
* ✨ 生成 **简洁、惯用的 Kotlin** 代码
   * ⏱️ **编译时** 生成
   * 🚫 **零反射**，**零运行时开销**
* 📦 与 **Gradle** 和 **Maven** 无缝配合

> ℹ️ 本 README 提供基础概览，详情请查看 [文档](https://mcarleio.github.io/konvert)。

## 使用方法

Konvert 有三种不同的使用方式：

1. 使用 `@KonvertTo`：
   ```kotlin
   @KonvertTo(PersonDto::class)
   data class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)
   ```
   这将生成以下扩展函数
   ```kotlin
   fun Person.toPersonDto(): PersonDto =
      PersonDto(firstName = firstName, lastName = lastName)
   ```

2. 使用 `@KonvertFrom`（特别有用，如果你无法更改源类的代码）
   ```kotlin
   class Person(val firstName: String, val lastName: String) {
      @KonvertFrom(PersonDto::class)
      companion object
   }
   class PersonDto(val firstName: String, val lastName: String)
   ```
   这将生成以下扩展函数
   ```kotlin
   fun Person.Companion.fromPersonDto(personDto: PersonDto): Person =
      Person(firstName = personDto.firstName, lastName = personDto.lastName)
   ```

3. 使用 `@Konverter`：
   ```kotlin
   class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)

   @Konverter
   interface PersonMapper {
      fun toDto(person: Person): PersonDto
   }
   ```
   这将生成以下对象
   ```kotlin
   object PersonMapperImpl: PersonMapper {
      override fun toDto(person: Person): PersonDto
         = PersonDto(firstName = person.firstName, lastName = person.lastName)
   }
   ```
对于一个简单的示例项目，请查看[示例目录](example)。

### 类型映射

对于简单的类型映射，比如从 `Instant` 到 `Date`，Konvert 已经提供了一个类型转换器：

```kotlin
@KonvertTo(PersonDto::class)
class Person(val name: String, val birthday: Instant)
class PersonDto(val name: String, val birthday: Date)
```
这将生成以下扩展函数


```kotlin
fun Person.toPersonDto(): PersonDto = PersonDto(
   name = name,
   birthday = birthday.let { java.util.Date.from(it) }
)
```

请查看[文档](https://mcarleio.github.io/konvert/typeconverter/)以获取提供的类型转换器列表。

🛈：您也可以通过实现[TypeConverter](https://raw.githubusercontent.com/mcarleio/konvert/main/converter-api/src/main/kotlin/io/mcarle/konvert/converter/api/TypeConverter.kt)来创建您自己的类型转换器库，并使用[SPI](https://en.wikipedia.org/wiki/Service_provider_interface)进行注册。

### 微调

大多数情况下，源类和目标类的属性名称和类型可能不相同。
您可以配置特定映射并重命名生成的扩展函数，如下所示：



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
这将生成以下扩展函数


```kotlin
fun Person.asDto(): PersonDto = PersonDto(
   givenName = firstName,
   familyName = lastName
)
```

欲了解更多功能，请参阅
[文档](https://mcarleio.github.io/konvert/)
[注解](annotations/src/main/kotlin/io/mcarle/konvert/api)的KDocs，
[示例项目](example/src/main/kotlin/io/mcarle/konvert/example)
或[测试](processor/src/test/kotlin/io/mcarle/konvert/processor)。

## Gradle 设置

要在 Gradle 中使用 Konvert，您需要执行以下步骤：

1. 添加 `konvert-api` 作为依赖以使用注解：
   ```kotlin
   dependencies {
      implementation("io.mcarle:konvert-api:$konvertVersion")
   }
   ```

2. 添加 KSP 插件：
   ```kotlin
   plugins {
       id("com.google.devtools.ksp").version("2.3.5")
   }
   ```

3. 将 `konvert` 添加为 `ksp` 依赖：
   ```kotlin
   dependencies {
      ksp("io.mcarle:konvert:$konvertVersion")
   }
   ```

## Maven 设置

要在 Maven 中使用 Konvert，您需要执行以下步骤：

1. 添加 `konvert-api` 作为依赖以使用注解：
   ```xml
   <dependency>
       <groupId>io.mcarle</groupId>
       <artifactId>konvert-api</artifactId>
       <version>${konvert.version}</version>
   </dependency>
   ```

2. 使用带有 `konvert` 依赖的 [ksp-maven-plugin](https://github.com/mcarleio/ksp-maven-plugin)：
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

## 进一步信息

* Konvert 主要使用 JDK >=17 编译和测试。它也应该能在 JDK 17 以下的版本工作，但不保证。
* Konvert 能够将类从 Java（可能还有其他 JVM 语言）编写的类之间进行转换。

### 替代方案

以下是一些你可能想了解的 Konvert 替代方案：

* [Mappie](https://github.com/Mr-Mappie/mappie)

  Mappie 不使用 KSP，而是 Kotlin 自身的编译器插件。
  它使用反射而非字符串引用来**定义**映射，
  但在编译时**替换反射**代码为惯用的 Kotlin 代码。

* [MapStruct](https://mapstruct.org/)

  MapStruct 是一个著名的 Java 映射库，使用注解处理（参见 [kapt](https://kotlinlang.org/docs/kapt.html)）。
  可以用于 Kotlin 项目，但不支持 Kotlin 特有特性。

* [kMapper](https://github.com/s0nicyouth/kmapper)

  kMapper 也是一个 KSP 处理器，但似乎只支持 Kotlin 数据类之间的映射。

* [ShapeShift️](https://github.com/krud-dev/shapeshift)

  ShapeShift 在运行时使用反射来进行类之间的映射。

* **自行编码**（借助 AI 支持）

  确实，有时手动编写映射代码会更快、更简单且更灵活。
  现今借助 AI 工具，这一重复性任务可以在一定程度上实现自动化。


## 构建

### Gradle

要构建项目，只需运行

> gradle build

#### 运行所有测试

默认情况下，只执行部分可用测试，这些测试应验证 Konvert 的大部分功能。
要运行所有测试，请附加属性 `runAllTests`，例如：

> gradle test -PrunAllTests

### 文档

要在本地提供 Jekyll 站点，只需在 `docs` 目录内运行以下命令：

> docker run --rm -it -v "$PWD":/site -p 4000:4000 bretfisher/jekyll-serve

### 持续集成

使用 GitHub Actions 来：

* [构建和测试](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/build.yml)
* [发布和上传](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/release.yml) 到 Maven 仓库
* [生成文档](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/pages.yml) 并部署到 GitHub Pages。

## 更新日志

[更新日志](https://raw.githubusercontent.com/mcarleio/konvert/main/CHANGELOG.md) 包含所有重要变更。

## 许可证

    版权所有 2023 Marcel Carlé

    根据 Apache 许可证 2.0 版本（“许可证”）授权；
    除非符合许可证，否则不得使用此文件。
    您可以在以下地址获得许可证副本：

    http://www.apache.org/licenses/LICENSE-2.0

    除非适用法律要求或书面同意，否则根据许可证分发的软件
    是按“原样”分发的，
    不附带任何明示或暗示的保证或条件。
    有关权限和
    许可限制的具体语言，请参阅许可证。

[maven-image]: https://img.shields.io/maven-central/v/io.mcarle/konvert.svg

[maven-url]: https://central.sonatype.com/artifact/io.mcarle/konvert/

[license-image]: https://img.shields.io/github/license/mcarleio/konvert.svg

[codecov-image]: https://img.shields.io/codecov/c/github/mcarleio/konvert.svg

[codecov-url]: https://codecov.io/gh/mcarleio/konvert


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---