# Material3 底部表单导航

本库为使用 Material3 底部表单的 Compose 项目提供导航解决方案。它允许您将底部表单定义为导航路由，消除了对 `androidx.compose.material.navigation` 和 ` androidx.compose.material:material` !  
库的依赖。这简化了您的应用依赖并确保一致的 Material3 体验。  
本库还利用了 `androidx.navigation:navigation-compose:2.8.0-beta0X` 的新功能，允许您使用序列化类定义路由。

[![Maven Central](https://img.shields.io/maven-central/v/io.github.stefanoq21/material3-navigation)](https://central.sonatype.com/artifact/io.github.stefanoq21/material3-navigation)

![Static Badge](https://img.shields.io/badge/minSdk-21-blue?link=https%3A%2F%2Fgithub.com%2Fstefanoq21%2FBottomSheetNavigator3%2Fblob%2Fmain%2Fmaterial3-navigation%2Fbuild.gradle.kts%23L15)

## 实现

您可以参考 [app](https://github.com/stefanoq21/BottomSheetNavigator3/tree/main/app "app") 模块中使用的实现方式。或者，您也可以查看下面的详细说明。

### 依赖
该库现已发布到 MavenCentral！！！  
请将依赖添加到您的 `libs.versions.toml` 中
```
[versions]
...
material3Navigation = "X.X.X" current release version

[libraries]
...
material3-navigation = { group = "io.github.stefanoq21", name = "material3-navigation", version.ref = "material3Navigation" }

```
在您的 `build.gradle.kts` 中实现您的依赖项：
```
...
dependencies {
...
 implementation(libs.material3.navigation)
```
### 使用方法
定义您的**BottomSheetNavigator**
```
...
   val bottomSheetNavigator =
                    rememberBottomSheetNavigator(skipPartiallyExpanded = true/false)
                val navController = rememberNavController(bottomSheetNavigator)
```
在 **NavHost** 组件上方添加 **ModalBottomSheetLayout** 并传入 **bottomSheetNavigator** 作为参数：
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
根据您使用的 Compose Navigation 版本，将路由定义为字符串或数据类：
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
一切就绪！只需像往常一样导航到您的新目的地：
```
...
Button(onClick = { navController.navigate(Screen.BottomSheetFullScreen) }) {
                                        Text(text = "BottomSheetFullScreen")
                                    }
...
```
### 从底部弹窗导航返回

要在底部弹窗中实现返回或关闭按钮，建议使用 `onBackPressedDispatcher.onBackPressed()`。这是因为如果使用 `navController.popBackStack()`，动画将不会出现。在这种情况下，动画被禁用了，以避免从底部弹窗开始的导航过程中出现问题。

### 自定义

该库当前支持与标准的 `androidx.compose.material3.ModalBottomSheet` 相同的自定义选项。您可以通过将参数传递给 `ModalBottomSheetLayout` 来自定义导航图中所有底部弹窗的外观。

## 预览
![](https://github.com/stefanoq21/BottomSheetNavigator3/assets/22545898/c971f6cf-bb04-41c1-b3ea-7b72757e09af)


## 贡献

欢迎为此库做出贡献！如果您有错误报告、功能请求或代码改进，请随时创建拉取请求。感谢您帮助使这个库变得更好。

## 许可证

   版权所有 2024 stefanoq21

   根据 Apache 许可证 2.0 版（“许可证”）授权；
   除非符合许可证，否则不得使用此文件。
   您可以在以下地址获得许可证副本：

       http://www.apache.org/licenses/LICENSE-2.0

   除非适用法律要求或书面同意，
   否则按照许可证分发的软件均按“原样”提供，
   不附带任何明示或暗示的保证或条件。
   有关许可证下特定语言权限和限制，请参阅许可证。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---