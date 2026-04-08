# Konvert

[![Maven Central][maven-image]][maven-url]
[![License][license-image]](LICENSE)
[![Code Coverage][codecov-image]][codecov-url]

これは Konvert です。Kotlin のマッピングコードジェネレーターで、[Kotlin Symbol Processing (KSP)](https://github.com/google/ksp) を使用しています。
Kotlin とその機能向けに特化して設計されており、Konvert は幅広いユースケースをサポートします。

主な特徴:
* 🧩 **さまざまなクラス種別** をサポート → `data`、`enum`、`value`、通常の POJO
* 🔄 デフォルトで **Null 安全**
* ⚙️ **スマート変換** (`Int` → `String`、`Instant` → `Date`、など)
   * 🔧 `@Konverter` で **再利用可能なコンバーター** を定義可能
   * 🔌 **SPI** による拡張で究極の制御を実現
* 🔗 **コレクション & マップ** — 要素のマッピングを含む
* 🛠️ **細かい** プロパティマッピングのカスタマイズ
* ☕ 100% **Java との相互運用性**
* ✨ **クリーンで慣用的な Kotlin** コードを生成
   * ⏱️ **コンパイル時** に生成
   * 🚫 **リフレクションなし**、**実行時オーバーヘッドなし**
* 📦 **Gradle** と **Maven** とシームレスに連携

> ℹ️ この README は基本的な概要を提供します。詳細は [ドキュメント](https://mcarleio.github.io/konvert) をご覧ください。

## 使い方

Konvert の使用方法は3通りあります:

1. `@KonvertTo` を使用する:
   ```kotlin
   @KonvertTo(PersonDto::class)
   data class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)
   ```
   これにより、次の拡張関数が生成されます
   ```kotlin
   fun Person.toPersonDto(): PersonDto =
      PersonDto(firstName = firstName, lastName = lastName)
   ```
2. `@KonvertFrom` を使用する（特に、ソースクラスのコードを変更できない場合に便利）

   ```kotlin
   class Person(val firstName: String, val lastName: String) {
      @KonvertFrom(PersonDto::class)
      companion object
   }
   class PersonDto(val firstName: String, val lastName: String)
   ```
   これにより、次の拡張関数が生成されます
   ```kotlin
   fun Person.Companion.fromPersonDto(personDto: PersonDto): Person =
      Person(firstName = personDto.firstName, lastName = personDto.lastName)
   ```

3. `@Konverter`の使用：
   ```kotlin
   class Person(val firstName: String, val lastName: String)
   data class PersonDto(val firstName: String, val lastName: String)

   @Konverter
   interface PersonMapper {
      fun toDto(person: Person): PersonDto
   }
   ```
   これにより、次のオブジェクトが生成されます
   ```kotlin
   object PersonMapperImpl: PersonMapper {
      override fun toDto(person: Person): PersonDto
         = PersonDto(firstName = person.firstName, lastName = person.lastName)
   }
   ```
簡単なサンプルプロジェクトについては、[exampleディレクトリ](example)を参照してください。

### 型マッピング

`Instant`から`Date`のような単純な型マッピングの場合、Konvertにはすでに型コンバーターが用意されています：

```kotlin
@KonvertTo(PersonDto::class)
class Person(val name: String, val birthday: Instant)
class PersonDto(val name: String, val birthday: Date)
```
これにより、以下の拡張関数が生成されます。


```kotlin
fun Person.toPersonDto(): PersonDto = PersonDto(
   name = name,
   birthday = birthday.let { java.util.Date.from(it) }
)
```

[ドキュメント](https://mcarleio.github.io/konvert/typeconverter/)を参照して、提供されている型変換器の一覧を確認してください。

🛈: 独自の型変換ライブラリも作成可能で、
[TypeConverter](https://raw.githubusercontent.com/mcarleio/konvert/main/converter-api/src/main/kotlin/io/mcarle/konvert/converter/api/TypeConverter.kt)を実装し、
[SPI](https://en.wikipedia.org/wiki/Service_provider_interface)を使って登録できます。

### 詳細設定

多くの場合、ソースクラスとターゲットクラスではプロパティ名や型が一致しません。
特定のマッピングを設定し、生成される拡張関数の名前を変更することができます:

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

これにより、次の拡張関数が生成されます

```kotlin
fun Person.asDto(): PersonDto = PersonDto(
   givenName = firstName,
   familyName = lastName
)
```

さらなる機能については、
[ドキュメント](https://mcarleio.github.io/konvert/)
[アノテーションのKDocs](annotations/src/main/kotlin/io/mcarle/konvert/api)、
[サンプルプロジェクト](example/src/main/kotlin/io/mcarle/konvert/example)
または[テスト](processor/src/test/kotlin/io/mcarle/konvert/processor)を参照してください。

## Gradleセットアップ

KonvertをGradleで使用するには、以下の手順を行ってください：

1. アノテーションを使用するために`konvert-api`を依存関係として追加します：
   ```kotlin
   dependencies {
      implementation("io.mcarle:konvert-api:$konvertVersion")
   }
   ```

2. KSPプラグインを追加します:
   ```kotlin
   plugins {
       id("com.google.devtools.ksp").version("2.3.5")
   }
   ```

3. `konvert` を `ksp` 依存関係として追加します:
   ```kotlin
   dependencies {
      ksp("io.mcarle:konvert:$konvertVersion")
   }
   ```

## Maven セットアップ

Konvert を Maven で使用するには、次の手順を実行する必要があります。

1. アノテーションを使用するために `konvert-api` を依存関係として追加します：
   ```xml
   <dependency>
       <groupId>io.mcarle</groupId>
       <artifactId>konvert-api</artifactId>
       <version>${konvert.version}</version>
   </dependency>
   ```

2. 依存関係として `konvert` を使用し、[ksp-maven-plugin](https://github.com/mcarleio/ksp-maven-plugin) を使用します:
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
## さらなる情報

* Konvertは主にJDK >=17でコンパイルおよびテストされています。JDK 17未満でも動作するはずですが、保証はありません。
* KonvertはJavaで書かれたクラス（おそらく他のJVM言語のクラスも）からクラスへ変換することが可能です。

### 代替案

Konvertの代わりに検討できるいくつかの代替案があります：

* [Mappie](https://github.com/Mr-Mappie/mappie)

  MappieはKSPを使わず、代わりにKotlin自体のコンパイラプラグインです。
  マッピングを**定義**するために文字列参照ではなくリフレクションを使用しますが、
  コンパイル時にリフレクションコードをイディオマティックなKotlinコードに**置き換えます**。

* [MapStruct](https://mapstruct.org/)

  MapStructは注釈処理を使用する有名なJavaマッピングライブラリです（[kapt](https://kotlinlang.org/docs/kapt.html)参照）。
  Kotlinプロジェクトで使用可能ですが、Kotlin特有の機能はサポートしていません。

* [kMapper](https://github.com/s0nicyouth/kmapper)

  kMapperもKSPプロセッサですが、Kotlinのデータクラス間のマッピングのみをサポートしているようです。

* [ShapeShift️](https://github.com/krud-dev/shapeshift)

  ShapeShiftは実行時にリフレクションを使用してクラス間のマッピングを行います。

* **自分でコードを書く**（AI支援あり）

  実際、マッピングコードを手動で書くほうが速く、簡単で柔軟な場合もあります。
  最近のAIツールの助けを借りれば、この繰り返し作業もある程度自動化可能です。


## ビルド

### Gradle

プロジェクトをビルドするには、単に以下を実行してください。

> gradle build

#### すべてのテストを実行する

デフォルトでは、利用可能なテストのサブセットのみが実行されますが、これによりKonvertのほとんどの機能が検証されます。  
すべてのテストを実行するには、プロパティ `runAllTests` を追加してください。例：

> gradle test -PrunAllTests

### ドキュメント

Jekyllサイトをローカルで提供するには、`docs` 内で以下のコマンドを実行します：

> docker run --rm -it -v "$PWD":/site -p 4000:4000 bretfisher/jekyll-serve

### CI

GitHub Actionsは以下の用途で使用されています：

* [ビルドとテスト](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/build.yml)  
* [リリースと公開](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/release.yml) をMavenリポジトリへ  
* [ドキュメント生成](https://raw.githubusercontent.com/mcarleio/konvert/main/.github/workflows/pages.yml) とGitHub Pagesへのデプロイ

## 変更履歴

[変更履歴](https://raw.githubusercontent.com/mcarleio/konvert/main/CHANGELOG.md)にはすべての重要な変更が記載されています。

## ライセンス

    Copyright 2023 Marcel Carlé

    Apache License, Version 2.0（以下「ライセンス」）の下でライセンスされています。  
    本ファイルは、ライセンスに従わなければ使用できません。  
    ライセンスのコピーは以下から入手できます。

    http://www.apache.org/licenses/LICENSE-2.0

    適用法により要求される場合や書面による同意がない限り、  
    ライセンスに基づき配布されるソフトウェアは「現状のまま」提供され、

    明示的にも黙示的にも、一切の保証または条件なしに提供されます。
    ライセンスに記載された特定の言語に従って、許可および
    制限事項を参照してください。

[maven-image]: https://img.shields.io/maven-central/v/io.mcarle/konvert.svg

[maven-url]: https://central.sonatype.com/artifact/io.mcarle/konvert/

[license-image]: https://img.shields.io/github/license/mcarleio/konvert.svg

[codecov-image]: https://img.shields.io/codecov/c/github/mcarleio/konvert.svg

[codecov-url]: https://codecov.io/gh/mcarleio/konvert


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---