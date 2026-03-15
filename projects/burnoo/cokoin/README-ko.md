# 🥥 Cokoin

[![Maven Central](https://img.shields.io/maven-central/v/dev.burnoo/cokoin)](https://search.maven.org/search?q=dev.burnoo.cokoin)
[![javadoc](https://javadoc.io/badge2/dev.burnoo/cokoin/javadoc.svg?label=dokka&logo=)](https://javadoc.io/doc/dev.burnoo/cokoin)

Compose(멀티플랫폼 및 Jetpack)용 주입 라이브러리, Koin 래퍼입니다. `@Composable` 함수를 사용하여 `KoinContext`를 구성합니다.

## 설치

라이브러리는 Maven Central에 호스팅되어 있습니다. 모듈의 `build.gradle.kts` 또는 `build.gradle`에 다음 패키지를 추가하세요:


```kotlin
dependencies {
    implementation("dev.burnoo:cokoin:1.0.0")
    implementation("dev.burnoo:cokoin-android-viewmodel:1.0.0") // for Androidx ViewModel
    implementation("dev.burnoo:cokoin-android-navigation:1.0.0") // for Compose Navigation

    // REMOVE "org.koin:koin-androidx-compose:X.Y.Z" if you were using it
}
```
## 사용법

이 라이브러리는 Koin의 Application과 Modules를 사용합니다. Koin 문서는 여기에서 확인할 수 있습니다: https://insert-koin.io/.

코어 라이브러리는 Koin 애플리케이션을 구성하는 데 사용되는 [`@Composable Koin`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Koin.kt) 함수를 포함하고 있습니다. `@Preview`와 함께 사용할 수 있습니다.


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
### 스코프

스코프는 컴포저블을 [`@Composable KoinScope`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Scope.kt)로 감싸서 생성됩니다:


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
### 뷰모델

#### `dev.burnoo:cokoin-android-viewmodel:x.y.z`

`@Composable` 내부에서 `ViewModel`을 얻기 위해 `getViewModel`을 호출하세요:


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
는 [Koin의 주입 파라미터](https://insert-koin.io/docs/reference/koin-android/viewmodel/#viewmodel-and-injection-parameters)
와 `SaveStateHandle`을 지원합니다. 고급 예제는
[여기](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin-android-viewmodel/src/androidTest/java/dev/burnoo/cokoin/viewmodel/ViewModelTest.kt)에서 확인할 수 있습니다.

### 컴포즈 내비게이션

#### `dev.burnoo:cokoin-android-navigation:x.y.z`

먼저 `NavHost`를 `KoinNavHost`로 교체합니다:

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

그런 다음 `composable` 화면 내에서 `getNavController`와 `getNavViewModel`을 사용하세요.

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
`KoinNavHost`로 내비게이션을 감싸고 싶지 않다면,  
`viewModelStoreOwner` 매개변수를 사용하는 `getViewModel`로 유사한 결과를 얻을 수 있습니다:
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
## 라이선스

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