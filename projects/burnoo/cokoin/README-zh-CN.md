# 🥥 Cokoin

[![Maven Central](https://img.shields.io/maven-central/v/dev.burnoo/cokoin)](https://search.maven.org/search?q=dev.burnoo.cokoin)
[![javadoc](https://javadoc.io/badge2/dev.burnoo/cokoin/javadoc.svg?label=dokka&logo=)](https://javadoc.io/doc/dev.burnoo/cokoin)

用于 Compose（多平台和 Jetpack）的注入库，Koin 的包装器。它使用 `@Composable` 函数来配置 `KoinContext`。

## 安装

该库托管在 Maven Central。将以下包添加到您的模块 `build.gradle.kts` 或 `build.gradle` 中：


```kotlin
dependencies {
    implementation("dev.burnoo:cokoin:1.0.0")
    implementation("dev.burnoo:cokoin-android-viewmodel:1.0.0") // for Androidx ViewModel
    implementation("dev.burnoo:cokoin-android-navigation:1.0.0") // for Compose Navigation

    // REMOVE "org.koin:koin-androidx-compose:X.Y.Z" if you were using it
}
```

## 使用方法

该库使用了 Koin 的 Application 和 Modules。Koin 的文档可以在这里找到：https://insert-koin.io/。

核心库包含 [`@Composable Koin`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Koin.kt) 函数，用于配置 Koin 应用。它可以与 `@Preview` 一起使用。

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

### 作用域

作用域是通过将可组合函数包装在 [`@Composable KoinScope`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Scope.kt) 中来创建的：

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

在 `@Composable` 内调用 `getViewModel` 以获取 `ViewModel`：

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
支持 [Koin 的注入参数](https://insert-koin.io/docs/reference/koin-android/viewmodel/#viewmodel-and-injection-parameters)
和 `SaveStateHandle`。高级示例可在
[这里](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin-android-viewmodel/src/androidTest/java/dev/burnoo/cokoin/viewmodel/ViewModelTest.kt) 找到。

### Compose 导航

#### `dev.burnoo:cokoin-android-navigation:x.y.z`

首先将 `NavHost` 替换为 `KoinNavHost`：

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

然后在 `composable` 界面内使用 `getNavController` 和 `getNavViewModel`。

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
如果您不想用 `KoinNavHost` 包裹导航，  
您可以使用带有 `viewModelStoreOwner` 参数的 `getViewModel` 来实现类似的效果：
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
## 许可证

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