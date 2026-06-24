
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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
Foodike adalah aplikasi pengantaran makanan yang sederhana dan mudah digunakan. Aplikasi ini dibangun dengan Android-Jetpack Compose dan menerapkan prinsip MVVM dengan Komponen Arsitektur Android Modern.

## Demo 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## Tangkapan Layar 📱 
Onboarding | Login | Beranda | Detail | Riwayat | Keranjang | Profil
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Dibangun Dengan 🛠

- [Kotlin](https://kotlinlang.org/) - Bahasa pemrograman resmi dan utama untuk pengembangan Android.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose adalah toolkit modern Android untuk membangun UI native.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Coroutine adalah pola desain konkurensi yang dapat digunakan di Android untuk menyederhanakan kode yang berjalan secara asinkron.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow adalah versi asinkron dari Sequence, tipe koleksi yang nilainya dihasilkan secara malas.
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) -
  Kumpulan pustaka yang membantu Anda merancang aplikasi yang kuat, dapat diuji, dan mudah dipelihara.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow adalah flow yang dapat diamati dan menyimpan state, yang mengirimkan pembaruan state saat ini dan baru ke kolektornya.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow adalah versi asinkron dari Sequence, tipe koleksi yang nilainya dihasilkan secara malas.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Menyimpan data terkait UI yang tidak hilang saat terjadi perubahan UI.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Komponen Navigasi menyediakan dukungan untuk aplikasi Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore adalah solusi penyimpanan data yang memungkinkan Anda menyimpan pasangan key-value atau objek bertipe dengan protokol buffer. DataStore menggunakan coroutine dan Flow Kotlin untuk menyimpan data secara asinkron, konsisten, dan transaksional.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt adalah pustaka dependency injection untuk Android yang mengurangi boilerplate dalam melakukan dependency injection manual di proyek Anda. Melakukan dependency injection manual membutuhkan Anda untuk membangun setiap kelas dan dependensinya secara manual, serta menggunakan container untuk mengelola dan menggunakan kembali dependensi.
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - Mulai dari Android 12, SplashScreen API memungkinkan aplikasi diluncurkan dengan animasi, termasuk gerakan masuk aplikasi saat peluncuran, layar splash yang menampilkan ikon aplikasi Anda, dan transisi ke aplikasi itu sendiri. SplashScreen adalah Window sehingga menutupi sebuah Activity.
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Komponen UI Material Design yang modular dan dapat disesuaikan untuk Android.
- [Figma](https://figma.com/) - Figma adalah editor grafis vektor dan alat prototipe yang berbasis web utama.

## Arsitektur 🗼














Aplikasi ini menggunakan arsitektur [***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Build-tool 🧰
Anda perlu memiliki [Android Studio Beta 3 atau lebih tinggi](https://developer.android.com/studio/preview) untuk membangun proyek ini.

## Kontak 📩

Ingin menghubungi saya? DM saya di 👇

Kirim email ke:- gautamhazarika01@gmail.com

Portofolio saya:- www.gautamhz.com

## Donasi 💰

Jika proyek ini membantu Anda menghemat waktu pengembangan, Anda bisa traktir saya secangkir kopi :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Lisensi 🔖

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

## Backend:

Saya sedang membangun backend sepenuhnya dengan kotlin menggunakan ktor [di sini](https://github.com/gautam84/foodike-backend).


## Langkah Selanjutnya:

- Integrasikan backend ke aplikasi android.
- Perbarui setiap bagian kode ke versi terbaru.
- Tulis unit test, integration test, dan UI/End-to-End test.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---