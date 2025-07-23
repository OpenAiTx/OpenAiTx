
# pods4k

[![Maven Central][maven-central-badge]][maven-central-url]
[![Licence][license-badge]][license-url]
![トップ言語][top-language-badge]
![ビルドステータス][build-status-badge]
[![スター数][stars-badge]][stars-url]

## Kotlin向けのパフォーマンス重視データ構造

一見不可能に思えるかもしれないパフォーマンスと効率を提供する、
パフォーマンス重視のデータ構造のコレクションです。

このライブラリが役に立った場合は、
[GitHub](https://github.com/daniel-rusu/pods4k)で
[![GitHub stars](https://img.shields.io/github/stars/daniel-rusu/pods4k?label=Star)](https://github.com/daniel-rusu/pods4k)
を付けて、他の人と共有することをご検討ください。

## インストール

[![最新バージョン][latest-version-shield]][maven-central-url] Maven Centralで利用可能：

**Gradle:**
```kotlin
repositories {
    mavenCentral()
}
dependencies {
    implementation("com.danrusu.pods4k:pods4k:<latest_version>")
}
```
**Maven:**


```xml

<dependency>
    <groupId>com.danrusu.pods4k</groupId>
    <artifactId>pods4k</artifactId>
    <version>latest_version</version>
</dependency>
```
または、このライブラリの個々のコンポーネントを[選択して組み合わせる](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/publishing/bom/README.md)こともできます。

## イミュータブル配列

[イミュータブル配列](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md)は、リストに代わるより安全で高速かつ効率的な選択肢を提供し、
おなじみの構文を維持します。

#### 主な利点

* ![高速][fast-shield] ほとんどの操作でリストより[2倍から8倍高速](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/BENCHMARKS.md)。
* ![効率的][efficient-shield] 多くの一般的なシナリオで[4倍以上のメモリ削減](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md#-efficiency)。
* ![イミュータブル][immutable-shield] キャストしても変更不可。
* ![型安全][type-safe-shield] コンパイル時に誤った変更試行を防止。
* ![効率的なビルダー][efficient-builders-shield] ミュータブルリストより効率的に要素を集める。

#### 直感的なリスト風構文



```kotlin
val people = immutableArrayOf(dan, jill, bobby)

// Iterate naturally
for (person in people) {
    sendMarketingEmailTo(person)
}
// All the usual operations
val employedPeople = people.filter { it.isEmployed() }
val salaries = employedPeople.map { it.salary }
```
[Immutable Arrays](https://raw.githubusercontent.com/daniel-rusu/pods4k/main/immutable-arrays/README.md) を参照してください。通常の配列、読み取り専用リスト、およびイミュータブルリストとの詳細な比較も含まれています。

## 最小要件

* Kotlin 1.9.25
    * このライブラリは Kotlin 2.1 などを使用する他のプロジェクトで使われているため、K2 互換です。
* JDK 11
    * 自動テストは JDK の LTS リリースである 11、17、21 で実行されています。

## Java 互換性

一部のデータ構造は Kotlin コンパイラでのみサポートされる技術を使用しています。これらのデータ構造を Java 定義のコレクションに格納するために混在した
Java と Kotlin のコードベースで使用することは可能ですが、これらのデータ構造をクラス名で参照することは Kotlin ファイル内でのみサポートされています。


[maven-central-badge]: https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fraw.githubusercontent.com%2Fdaniel-rusu%2Fpods4k%2Frefs%2Fheads%2Fmain%2Flatest_version.json&query=version&style=for-the-badge&label=maven-central&color=orange

[license-badge]: https://img.shields.io/github/license/daniel-rusu/pods4k?style=for-the-badge

[top-language-badge]: https://img.shields.io/github/languages/top/daniel-rusu/pods4k?style=for-the-badge

[build-status-badge]: https://img.shields.io/github/actions/workflow/status/daniel-rusu/pods4k/ci.yml?style=for-the-badge&label=CI

[stars-badge]: https://img.shields.io/github/stars/daniel-rusu/pods4k?style=for-the-badge


[fast-shield]: https://img.shields.io/badge/Blazing_Fast-blue

[efficient-shield]: https://img.shields.io/badge/Memory_Efficient-blue

[immutable-shield]: https://img.shields.io/badge/True_Immutability-blue

[type-safe-shield]: https://img.shields.io/badge/Type_Safety-blue

[efficient-builders-shield]: https://img.shields.io/badge/Efficient_Builders-blue

[github-stars-shield]: https://img.shields.io/github/stars/daniel-rusu/pods4k?label=Star

[latest-version-shield]: https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fraw.githubusercontent.com%2Fdaniel-rusu%2Fpods4k%2Frefs%2Fheads%2Fmain%2Flatest_version.json&query=version&label=Latest%20Version&color=orange


[stars-url]: https://github.com/daniel-rusu/pods4k/stargazers

[maven-central-url]: https://central.sonatype.com/artifact/com.danrusu.pods4k/pods4k

[license-url]: https://github.com/daniel-rusu/pods4k/blob/main/LICENSE




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---