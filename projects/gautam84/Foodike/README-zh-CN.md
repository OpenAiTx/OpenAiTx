
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=gautam84&project=Foodike&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

![GitHub Cards Preview](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodike 是一个简单易用的外卖应用程序。它基于 Android-Jetpack Compose 构建，遵循 MVVM 原则，并采用现代 Android 架构组件开发。

## 演示 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## 截图 📱 
引导页 | 登录 | 首页 | 详情 | 历史 | 购物车 | 个人资料
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## 技术栈 🛠

- [Kotlin](https://kotlinlang.org/) - Android官方一级编程语言。
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose是Android现代化的原生UI构建工具包。
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - 协程是一种并发设计模式，可用于简化Android上异步执行的代码。
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow是异步版本的Sequence，一种懒加载集合。
- [Android架构组件](https://developer.android.com/topic/libraries/architecture) - 帮助设计健壮、可测试、可维护应用的库集合。
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow是状态持有的可观察Flow，向其收集者发出当前和新状态更新。
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow是异步版本的Sequence，一种懒加载集合。
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - 存储UI相关数据，不会因UI变化而销毁。
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Navigation组件为Jetpack Compose应用提供导航支持。
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore是数据存储解决方案，可存储键值对或类型对象，支持协议缓冲。DataStore利用Kotlin协程和Flow实现异步、稳定和事务性的数据存储。
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt是Android依赖注入库，减少项目中手动依赖注入的样板代码。手动依赖注入需要手动构建每个类及其依赖，并使用容器管理和复用依赖。
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - 从Android 12开始，SplashScreen API允许应用启动动画，包括启动时的进入动画、显示应用图标的启动页以及应用自身的过渡。SplashScreen是一个窗口，因此覆盖一个Activity。
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Android的模块化、可定制Material Design UI组件。
- [Figma](https://figma.com/) - Figma是一款主要基于网页的矢量图形编辑器和原型工具。

## 架构 🗼















本应用使用 [***MVVM（模型-视图-视图模型）***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch) 架构。

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## 构建工具 🧰
您需要拥有 [Android Studio Beta 3 或更高版本](https://developer.android.com/studio/preview) 来构建此项目。

## 联系方式 📩

想联系我吗？欢迎私信 👇

发送邮件至:- gautamhazarika01@gmail.com

我的作品集:- www.gautamhz.com

## 捐赠 💰

如果此项目帮助您缩短开发时间，欢迎请我喝杯咖啡 :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## 许可证 🔖


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---