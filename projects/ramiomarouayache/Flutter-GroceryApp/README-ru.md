# GroceryApp Starter

Упрощённый шаблон приложения для покупок продуктов для удобного шопинга. 🛒✨

Не забудьте поставить звезду ⭐ репозиторию, если считаете его полезным.

## Дизайн

**Нажмите на изображение ниже, чтобы посмотреть дизайн в Figma:**

[![Design Preview](https://raw.githubusercontent.com/ramiomarouayache/Flutter-GroceryApp/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨Требования

1. **Среда разработки:**
   - Любая IDE с установленным Flutter SDK (например, VSCode, Android Studio, IntelliJ и др.)

2. **База знаний:**
   - Базовые или средние знания Dart и Flutter
   - Понимание архитектуры MVVM
   - Знакомство с работой с API
   - Основы управления состоянием с помощью GetX
  
## Тестирование
* Вы можете скачать предварительную версию для устройств Android здесь: [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## Настройка
* Начните с настройки конечной точки вашего продукта, учетных данных и параметров в `lib\constants\AppConstants`.
* **Либо** используйте бесплатную конечную точку, приведённую ниже (актуально на момент публикации), для успешного тестирования.
```dart
class AppConstants {
  // Замените "YOUR_API_PREFIX" на ваш собственный базовый URL API.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //ЕСЛИ_ЕСТЬ

  // Для тестирования используйте бесплатный базовый URL API из выпущенной версии
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Полное имя владельца проекта.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Важно
* Чтобы использовать свои собственные конечные точки API, настройте логические уровни в соответствии с принципами архитектуры MVVM и вашей документацией по API.
* Некоторые изображения в предварительной версии были удалены из-за ограничений по авторскому праву.

## Вклад

Пожалуйста, сделайте форк этого репозитория и вносите свои изменения с помощью
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Любой вклад, большой или маленький, новые функции или исправления ошибок, приветствуется и ценится,
но будет тщательно рассмотрен.


## Начало работы
Этот проект является отправной точкой для Flutter-приложения.

Несколько ресурсов, чтобы начать, если это ваш первый проект на Flutter:

- [Лабораторная: Напишите своё первое приложение на Flutter](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Полезные примеры Flutter](https://flutter.io/docs/cookbook)

## Счётчик посетителей

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---