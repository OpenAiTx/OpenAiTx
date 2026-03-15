# 🥥 Cokoin

[![Maven Central](https://img.shields.io/maven-central/v/dev.burnoo/cokoin)](https://search.maven.org/search?q=dev.burnoo.cokoin)
[![javadoc](https://javadoc.io/badge2/dev.burnoo/cokoin/javadoc.svg?label=dokka&logo=)](https://javadoc.io/doc/dev.burnoo/cokoin)

Bibliothèque d'injection pour Compose (Multiplateforme et Jetpack), wrapper Koin. Elle utilise des fonctions `@Composable`
pour configurer le `KoinContext`.

## Installation

La bibliothèque est hébergée sur Maven Central. Ajoutez les packages suivants à votre module `build.gradle.kts` ou `build.gradle` :

```kotlin
dependencies {
    implementation("dev.burnoo:cokoin:1.0.0")
    implementation("dev.burnoo:cokoin-android-viewmodel:1.0.0") // for Androidx ViewModel
    implementation("dev.burnoo:cokoin-android-navigation:1.0.0") // for Compose Navigation

    // REMOVE "org.koin:koin-androidx-compose:X.Y.Z" if you were using it
}
```

## Utilisation

La bibliothèque utilise l’Application et les Modules de Koin. La documentation de Koin est disponible ici : https://insert-koin.io/.

La bibliothèque principale contient la fonction [`@Composable Koin`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Koin.kt), qui sert à configurer l’application Koin. Elle peut être utilisée avec `@Preview`.

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

### Portées

Les portées sont créées en encapsulant des composables dans [`@Composable KoinScope`](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin/src/commonMain/kotlin/dev/burnoo/cokoin/Scope.kt) :

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

Appelez `getViewModel` pour obtenir un `ViewModel` à l'intérieur de `@Composable` :

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
supporte les [paramètres d'injection de Koin](https://insert-koin.io/docs/reference/koin-android/viewmodel/#viewmodel-and-injection-parameters)
et `SaveStateHandle`. Des exemples avancés peuvent être
trouvés [ici](https://raw.githubusercontent.com/burnoo/cokoin/main/cokoin-android-viewmodel/src/androidTest/java/dev/burnoo/cokoin/viewmodel/ViewModelTest.kt).

### Navigation Compose

#### `dev.burnoo:cokoin-android-navigation:x.y.z`

Commencez par remplacer `NavHost` par `KoinNavHost` :

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

Utilisez ensuite `getNavController` et `getNavViewModel` à l'intérieur de l'écran `composable`.

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
Si vous ne souhaitez pas envelopper la navigation avec `KoinNavHost`,  
vous pouvez obtenir des résultats similaires avec `getViewModel` en utilisant le paramètre `viewModelStoreOwner` :
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
## Licence

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