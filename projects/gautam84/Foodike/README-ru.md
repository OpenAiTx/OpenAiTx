
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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
Foodike — это простое и удобное приложение для доставки еды. Оно разработано с использованием Android-Jetpack Compose и построено на принципах MVVM с современными архитектурными компонентами Android.

## Демонстрация 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## Скриншоты 📱 
Онбординг | Вход | Главная | Детали | История | Корзина | Профиль
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## Используемые технологии 🛠

- [Kotlin](https://kotlinlang.org/) - Основной и официальный язык программирования для разработки Android.
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack Compose — современный инструментарий Android для создания нативного UI.
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - Коррутины — это шаблон проектирования для параллелизма, упрощающий асинхронное выполнение кода на Android.
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow — асинхронная версия Sequence, тип коллекции, значения которой создаются лениво.
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) - Набор библиотек, помогающих создавать надёжные, тестируемые и поддерживаемые приложения.
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlow — наблюдаемый поток, хранящий состояние и отправляющий обновления текущего и нового состояния коллекторам.
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flow — асинхронная версия Sequence, тип коллекции, значения которой создаются лениво.
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - Хранит данные, связанные с UI, которые не уничтожаются при изменении UI.
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - Компонент Navigation предоставляет поддержку для приложений на Jetpack Compose.
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack DataStore — решение для хранения данных, позволяющее хранить пары ключ-значение или типизированные объекты с использованием protocol buffers. DataStore использует коррутины Kotlin и Flow для асинхронного, согласованного и транзакционного хранения данных.
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hilt — библиотека внедрения зависимостей для Android, сокращающая шаблонный код ручного внедрения зависимостей в проекте. Ручное внедрение требует создания каждого класса и его зависимостей вручную, а также использования контейнеров для повторного использования и управления зависимостями.
  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - Начиная с Android 12, SplashScreen API позволяет запускать приложения с анимацией, включая движение внутри приложения при запуске, экран загрузки с иконкой приложения и переход непосредственно к самому приложению. SplashScreen — это окно и, следовательно, покрывает Activity.
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Модульные и настраиваемые UI-компоненты Material Design для Android.
- [Figma](https://figma.com/) - Figma — редактор векторной графики и инструмент прототипирования, в основном веб-ориентированный.

## Архитектура 🗼















Это приложение использует архитектуру [***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch).

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Инструмент сборки 🧰
Вам необходимо установить [Android Studio Beta 3 или выше](https://developer.android.com/studio/preview), чтобы собрать этот проект.

## Контакт 📩

Хотите связаться со мной? Напишите мне в ЛС 👇

Отправьте письмо на:- gautamhazarika01@gmail.com

Мое портфолио:- www.gautamhz.com

## Донат 💰

Если этот проект помог вам сэкономить время на разработку, вы можете угостить меня чашкой кофе :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Лицензия 🔖

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

## Бэкенд:

Я разрабатываю бэкенд полностью на Kotlin с использованием Ktor [здесь](https://github.com/gautam84/foodike-backend).


## Следующие шаги:

- Интегрировать бэкенд в Android-приложение.
- Обновить весь код до последних версий.
- Написать модульные тесты, интеграционные тесты и UI/End-to-End тесты.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---