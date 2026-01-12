# ⚠️ このリポジトリはアーカイブされています。アノテーション処理のセットアップをKSPに移行することを検討してください。 ⚠️

# NAPT

[![Plugin](https://img.shields.io/maven-metadata/v?label=Gradle%20Plugin&logo=Gradle&metadataUrl=https%3A%2F%2Fplugins.gradle.org%2Fm2%2Fcom%2Fsergei-lapin%2Fnapt%2Fcom.sergei-lapin.napt.gradle.plugin%2Fmaven-metadata.xml)](https://plugins.gradle.org/plugin/com.sergei-lapin.napt)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## これは何ですか？

スタブ生成をスキップすることで最大50％高速に動作するKAPTの代替手段

## 使用法

*この特定のツールセットを実行するにはJDK 9以降が必要です*

適用すると、Kotlinコード内で生成されたコードを参照できなくなるため、
KotlinソースでJava生成コードを参照するにはJavaの`bridge`クラスを書く必要があります。

例えば、以下のようなKotlinのDagger 2コンポーネントがあるとします：

``` Kotlin
@Component
interface Component {

    @Component.Factory
    interface Factory {

        fun create(): Component
    }
}
```

次に、生成されたコンポーネントをKotlinコードから参照するために、次のようなJavaの`ブリッジ`を書く必要があります: 


``` Java
class ComponentBridge {

    static Component.Factory factory() {
        return DaggerComponent.factory();
    }
}
```

これで、Kotlinコードのどこからでも簡単にこの `bridge` を参照できるようになりました。

## サンプル

使用例は [sample](https://github.com/sergei-lapin/napt/blob/main/sample/build.gradle) にあります。

## ダウンロード

- javac プラグインは Maven Central を通じて配布されています。
- Gradle プラグインは Gradle Plugin Portal を通じて配布されています。

#### プラグインの追加

古いものを削除してください。

``` Gradle
plugins {
    kotlin("kapt")
}
```

そしてそれを置き換えます

``` Gradle
plugins {
    id("com.sergei-lapin.napt") version("{latest-version}")
}
```

それから、あなたのすべてを置き換えることができます。

``` Gradle
dependencies {
    kapt("some dependency")
}
```
とともに


``` Gradle
dependencies {
    annotationProcessor("some dependency")
}
```

以上です。注釈処理の速度が約50%向上するのをお楽しみください。

#### 競合する NaptTrigger クラス

デフォルトでは、Gradle プラグインはモジュール名のパッケージで NaptTrigger を生成するため、FQ 名が衝突することはありませんが、念のため、NaptTrigger パッケージのプレフィックスは次のように指定できます：


``` Gradle
napt {
    naptTriggerPackagePrefix.set("com.slapin.napt")
}
```

モジュール名が`sample`であると仮定すると、以下の`NaptTrigger.java`が生成されます:

``` Java
package com.slapin.napt.sample;
class NaptTrigger {
}
```

#### NaptTrigger生成の無効化

`NaptTrigger.java`の生成は（例えばモジュールにすでにJavaソースがある場合など）対応するプロパティを`false`に設定することで無効化できます:


``` Gradle
napt {
    generateNaptTrigger.set(false)
}
```

#### JavaコンパイラにカスタムJVM引数を渡す方法

naptが動作するためには、Javaのコンパイルが`com.slapin.napt.JvmArgsStrongEncapsulation`で定義された引数を使ってフォークされたプロセスで実行されます。  
これらの引数は、`napt`拡張の対応するプロパティを設定することで拡張可能です。


``` Gradle
napt {
    forkJvmArgs.set(listOf("your_custom_arg"))
}
```

#### 追加のソースセット内でNaptTriggerを生成する

場合によっては、追加のソースセット（例：`test`）でアノテーション処理をトリガーする必要があります。
そのような場合は、`napt`拡張の対応するプロパティを使用できます:

``` Gradle
napt {
    additionalSourceSetsForTriggerGeneration.set(listOf("test"))
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---