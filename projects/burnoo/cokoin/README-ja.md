# 🥥 Cokoin

[![Maven Central](https://img.shields.io/maven-central/v/dev.burnoo/cokoin)](https://search.maven.org/search?q=dev.burnoo.cokoin)
[![javadoc](https://javadoc.io/badge2/dev.burnoo/cokoin/javadoc.svg?label=dokka&logo=)](https://javadoc.io/doc/dev.burnoo/cokoin)

Compose（マルチプラットフォームおよびJetpack）用のインジェクションライブラリ、Koinラッパーです。`@Composable`関数を使用して`KoinContext`を設定します。

## インストール

ライブラリはMaven Centralでホストされています。モジュールの`build.gradle.kts`または`build.gradle`に以下のパッケージを追加してください：


```kotlin
dependencies {
    implementation("dev.burnoo:cokoin:1.0.0")
    implementation("dev.burnoo:cokoin-android-viewmodel:1.0.0") // for Androidx ViewModel
    implementation("dev.burnoo:cokoin-android-navigation:1.0.0") // for Compose Navigation

    // REMOVE "org.koin:koin-androidx-compose:X.Y.Z" if you were using it
}
```

## 使用法

このライブラリはKoinのApplicationとModulesを使用しています。Koinのドキュメントはここで確認できます: https://insert-koin.io/。

コアライブラリにはKoinアプリケーションの設定に使われる[`@Composable Koin`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Koin.kt)関数が含まれています。`@Preview`と一緒に使用することができます。

```kotlin
val appModule = module {
    factory { "Hello, DI!" }
}

@Preview
@Composable
fun App() {
    Koin(appDeclaration = { modules(appModule) }) {
        val text = get<String>()
        Text(text)
    }
}
```

### スコープ

スコープは、コンポーザブルを[`@Composable KoinScope`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Scope.kt)でラップすることで作成されます：

```kotlin
data class A(val value: String)

val scopedModule = module {
    scope<ScopeTypeA> {
        scoped { A("scopeA") }
    }
    scope<ScopeTypeB> {
        scoped { A("scopeB") }
    }
}

@Preview
@Composable
fun Test() {
    Koin(appDeclaration = { modules(scopedModule) }) {
        Column {
            KoinScope(getScope = { createScope<ScopeTypeA>() }) {
                Text(get<A>().value)
            }
            KoinScope(getScope = { createScope<ScopeTypeB>() }) {
                Text(get<A>().value)
            }
        }
    }
}
```

### ViewModel

#### `dev.burnoo:cokoin-android-viewmodel:x.y.z`

`@Composable` 内で `ViewModel` を取得するには `getViewModel` を呼び出します:

```kotlin
class MainViewModel : ViewModel() {
    val data = "Hello, DI!"
}

private val viewModelModule = module {
    viewModel { MainViewModel() }
}

@Composable
fun ViewModelSample() {
    Koin(appDeclaration = { modules(viewModelModule) }) {
        val viewModel = getViewModel<MainViewModel>()
        Text(viewModel.data)
    }
}
```

`getViewModel`
は[Koinの注入パラメータ](https://insert-koin.io/docs/reference/koin-android/viewmodel/#viewmodel-and-injection-parameters)
および`SaveStateHandle`をサポートします。高度な例は
[こちら](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin-android-viewmodel/src/androidTest/java/dev/burnoo/cokoin/viewmodel/ViewModelTest.kt)で確認できます。

### Compose Navigation

#### `dev.burnoo:cokoin-android-navigation:x.y.z`

まず`NavHost`を`KoinNavHost`に置き換えます：

```kotlin
@Composable
fun Sample() {
    val navController = rememberNavController()
    Koin(appDeclaration = { modules(viewModelModule) }) {
        KoinNavHost(navController, startDestination = "1") {
            composable("1") {
                Screen1()
            }
        }
    }
}
```

次に、`composable`画面内で`getNavController`と`getNavViewModel`を使用します。

```kotlin
@Composable
fun Screen1() {
    val navController = getNavController()
    Button(onClick = { navController.navigate("2") }) {
        val navViewModel = getNavViewModel<MainViewModel>()
        //...
    }
}
```
ナビゲーションを `KoinNavHost` でラップしたくない場合は、`viewModelStoreOwner` パラメータを使用した `getViewModel` で同様の結果を得ることができます:

```kotlin
@Composable
fun Screen1(navController: NavController) {
    Button(onClick = { navController.navigate("2") }) {
        val viewModel = getViewModel<MainViewModel>(
            viewModelStoreOwner = navController.getBackStackEntry("root")
        )
        //...
    }
}
```
## ライセンス

```
Copyright 2021 Bruno Wieczorek

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---