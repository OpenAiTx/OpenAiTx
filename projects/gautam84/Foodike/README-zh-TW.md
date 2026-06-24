
<div align="right">
  <details>
    <summary >🌐 語言</summary>
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
Foodike 是一款簡單易用的外送美食應用程式。它是基於 Android-Jetpack Compose 構建，並採用 MVVM 原則與現代 Android 架構元件實現。

## 演示
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## 截圖 📱 
新手引導 | 登入 | 主頁 | 詳細 | 歷史 | 購物車 | 個人檔案
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## 開發技術 🛠

- [Kotlin](https://kotlinlang.org/) - Android 官方的一流程式語言。
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose 是 Android 的現代原生 UI 建構工具包。
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - 協程是一種並發設計模式，可簡化 Android 非同步執行程式碼。
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow 是序列的非同步版本，集合的值會延遲產生。
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) - 一系列協助設計堅固、可測試及可維護應用程式的函式庫。
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow 是一種狀態持有者，可觀察流，向收集器發送當前及新狀態更新。
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow 是序列的非同步版本，集合的值會延遲產生。
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - 儲存 UI 相關資料，並不會因 UI 改變而被銷毀。
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - 導航元件提供 Jetpack Compose 應用程式的導航支援。
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore 是資料儲存解決方案，可儲存鍵值對或型別物件（協議緩衝區）。DataStore 使用 Kotlin 協程及 Flow 以非同步、穩定及交易方式儲存資料。
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt 是 Android 的依賴注入函式庫，減少專案手動依賴注入的樣板程式碼。手動依賴注入需自行構建每個類及其依賴，並使用容器管理與重用依賴。
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - 從 Android 12 起，SplashScreen API 讓應用啟動時有動畫，包括進入應用動作、顯示應用圖示的啟動畫面，以及過渡到應用本身。SplashScreen 是一個 Window，因此會覆蓋 Activity。
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Android 的模組化與可自訂 Material Design UI 元件。
- [Figma](https://figma.com/) - Figma 是主要基於網頁的向量圖編輯器與原型設計工具。

## 架構 🗼















此應用程式採用 [***MVVM（模型-視圖-視圖模型）***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch) 架構。

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## 建置工具 🧰
您需要安裝 [Android Studio Beta 3 或以上版本](https://developer.android.com/studio/preview) 來建置本專案。

## 聯絡方式 📩

想聯繫我嗎？歡迎私訊我 👇

寄信到：- gautamhazarika01@gmail.com

我的個人網站：- www.gautamhz.com

## 捐贈 💰

如果這個專案幫助你節省了開發時間，歡迎請我喝杯咖啡 :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## 授權條款 🔖


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

## 後端：

我正在使用 ktor 並以全 kotlin 建構後端，詳見 [這裡](https://github.com/gautam84/foodike-backend)。


## 下一步：

- 將後端整合至安卓應用程式。
- 將每一段程式碼更新至最新版本。
- 撰寫單元測試、整合測試以及 UI／端到端測試。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---