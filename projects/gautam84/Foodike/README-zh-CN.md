![GitHub Cards Preview](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike 是一个简单、易用的外卖应用。它使用 Android-Jetpack Compose 构建，基于 MVVM 原则和现代 Android 架构组件开发。

## 演示 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## 截图 📱 
引导页 | 登录 | 首页 | 详情 | 历史 | 购物车 | 个人资料
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## 构建技术 🛠

- [Kotlin](https://kotlinlang.org/) - Android 开发的第一语言和官方编程语言。
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose 是 Android 的现代原生 UI 构建工具包。
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - 协程是一种并发设计模式，可用于 Android 上简化异步执行的代码。
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow 是序列（Sequence）的异步版本，一种值惰性产生的集合类型。
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) -
  一组帮助设计健壮、可测试和易维护应用的库。
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow 是一个状态持有的可观察流，向收集者发出当前及新的状态更新。
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow 是序列（Sequence）的异步版本，一种值惰性产生的集合类型。
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - 存储与 UI 相关的数据，UI 变化时数据不会被销毁。
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Navigation 组件为 Jetpack Compose 应用提供支持。
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore 是一种数据存储解决方案，允许使用键值对或协议缓冲区的类型化对象存储数据。DataStore 使用 Kotlin 协程和 Flow 以异步、一致和事务的方式存储数据。
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt 是 Android 的依赖注入库，减少了项目中手动依赖注入的样板代码。手动依赖注入需要手工构造每个类及其依赖，并使用容器来重用和管理依赖。












  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - 从 Android 12 开始，SplashScreen API 允许应用启动时带有动画，包括启动时的应用内动画、显示应用图标的启动屏幕，以及过渡到应用本身。SplashScreen 是一个窗口，因此会覆盖一个 Activity。
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Android 的模块化且可定制的 Material Design UI 组件。
- [Figma](https://figma.com/) - Figma 是一个矢量图形编辑器和原型设计工具，主要基于网页。

## Architecture 🗼

该应用使用 [***MVVM（模型-视图-视图模型）***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch) 架构。

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Build-tool 🧰
你需要安装 [Android Studio Beta 3 及以上版本](https://developer.android.com/studio/preview) 来构建此项目。

## Contact 📩

想联系我？私信我 👇

发邮件至：- gautamhazarika01@gmail.com

我的作品集：- www.gautamhz.com

## Donation 💰

如果这个项目帮你节省了开发时间，可以请我喝杯咖啡 :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## License 🔖



```

MIT License

Copyright (c) 2026 Gautam Hazarika

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.



```

## 后端：

我正在使用 Kotlin 和 ktor 完全构建后端，代码在 [这里](https://github.com/gautam84/foodike-backend)。


## 下一步：

- 将后端集成到安卓应用中。
- 将所有代码更新到最新版本。
- 编写单元测试、集成测试以及 UI/端到端测试。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---