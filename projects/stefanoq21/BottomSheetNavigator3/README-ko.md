# Material3 BottomSheet 내비게이션

이 라이브러리는 Material3 BottomSheet를 사용하는 Compose 프로젝트를 위한 내비게이션 솔루션을 제공합니다. BottomSheet를 내비게이션 경로로 정의할 수 있어 `androidx.compose.material.navigation` 및 ` androidx.compose.material:material` 라이브러리가 필요 없습니다.  
이로 인해 앱의 종속성이 단순화되고 일관된 Material3 경험을 보장합니다.  
이 라이브러리는 또한 `androidx.navigation:navigation-compose:2.8.0-beta0X`의 새로운 기능을 활용하여 직렬화된 클래스로 경로를 정의할 수 있게 합니다.

[![Maven Central](https://img.shields.io/maven-central/v/io.github.stefanoq21/material3-navigation)](https://central.sonatype.com/artifact/io.github.stefanoq21/material3-navigation)

![Static Badge](https://img.shields.io/badge/minSdk-21-blue?link=https%3A%2F%2Fgithub.com%2Fstefanoq21%2FBottomSheetNavigator3%2Fblob%2Fmain%2Fmaterial3-navigation%2Fbuild.gradle.kts%23L15)

## 구현

[app](https://github.com/stefanoq21/BottomSheetNavigator3/tree/main/app "app") 모듈에서 사용된 구현 방식을 따라할 수 있습니다. 또는 아래에서 자세한 설명을 확인할 수 있습니다.

### 종속성  
이 라이브러리는 이제 MavenCentral에서 사용할 수 있습니다!!!  
`libs.versions.toml`에 종속성을 추가하세요
```
[versions]
...
material3Navigation = "X.X.X" current release version

[libraries]
...
material3-navigation = { group = "io.github.stefanoq21", name = "material3-navigation", version.ref = "material3Navigation" }

```
`build.gradle.kts` 파일에서 종속성을 구현하세요:
```
...
dependencies {
...
 implementation(libs.material3.navigation)
```
### 사용법
**BottomSheetNavigator**를 정의하세요
```
...
   val bottomSheetNavigator =
                    rememberBottomSheetNavigator(skipPartiallyExpanded = true/false)
                val navController = rememberNavController(bottomSheetNavigator)
```
**ModalBottomSheetLayout**을 **NavHost** 컴포넌트 위에 추가하고 **bottomSheetNavigator**를 매개변수로 전달합니다:
```
ModalBottomSheetLayout(
                        modifier = Modifier
                            .fillMaxSize(),
                        bottomSheetNavigator = bottomSheetNavigator
                    ) {
                        NavHost(
                            navController = navController,
                            startDestination = Screen.Home
                        ) {
...
```
사용 중인 컴포즈 내비게이션 버전에 따라 경로를 문자열 또는 데이터 클래스로 정의하세요:
```
...
   bottomSheet<Screen.BottomSheetFullScreen> {
                                BSFullScreenLayout()
                            }
  bottomSheet("BottomSheetFullScreen") {
                                BSFullScreenLayout()
                            }
...
```
모든 준비가 완료되었습니다! 이제 평소처럼 새 목적지로 이동하세요:
```
...
Button(onClick = { navController.navigate(Screen.BottomSheetFullScreen) }) {
                                        Text(text = "BottomSheetFullScreen")
                                    }
...
```
### 바텀 시트에서 뒤로 가기

바텀 시트에서 뒤로 가기 또는 닫기 버튼을 구현하려면 `onBackPressedDispatcher.onBackPressed()`를 사용하는 것을 권장합니다. `navController.popBackStack()`를 사용하면 애니메이션이 나타나지 않기 때문입니다. 이 경우 바텀 시트에서 시작하는 내비게이션 중 문제를 방지하기 위해 애니메이션이 비활성화되었습니다.

### 커스터마이징

이 라이브러리는 현재 표준 `androidx.compose.material3.ModalBottomSheet`와 동일한 커스터마이징 옵션을 지원합니다. 내비게이션 그래프에서 사용되는 모든 바텀 시트의 외관을 `ModalBottomSheetLayout`에 매개변수를 전달하여 커스터마이즈할 수 있습니다.

## 미리보기
![](https://github.com/stefanoq21/BottomSheetNavigator3/assets/22545898/c971f6cf-bb04-41c1-b3ea-7b72757e09af)


## 기여하기

이 라이브러리에 대한 기여를 환영합니다! 버그 리포트, 기능 요청 또는 코드 개선 사항이 있으면 자유롭게 풀 리퀘스트를 만들어 주세요. 이 라이브러리를 더욱 발전시키는 데 도움을 주셔서 감사합니다.

## 라이선스

   Copyright 2024 stefanoq21

   Apache License, Version 2.0 ("라이선스")에 따라 라이선스가 부여됩니다.
   라이선스에 따라 이 파일을 사용하려면 라이선스를 준수해야 합니다.
   라이선스 사본은 다음에서 확인할 수 있습니다.

       http://www.apache.org/licenses/LICENSE-2.0

   관련 법률에 의해 요구되거나 서면으로 동의하지 않는 한,
   소프트웨어는 "있는 그대로" 제공되며 명시적 또는 묵시적 보증이 없습니다.
   라이선스에 명시된 조건에 따라 제한 없이 소프트웨어를 사용할 수 있습니다.






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---