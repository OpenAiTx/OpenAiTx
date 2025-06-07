# GroceryApp Starter

Uproszczony szablon aplikacji spożywczej dla łatwego i przejrzystego robienia zakupów. 🛒✨

Jeśli uznasz repozytorium za wartościowe, dodaj gwiazdkę ⭐.

## Projekt

**Kliknij w poniższy obraz, aby zobaczyć projekt w Figma:**

[![Design Preview](https://raw.githubusercontent.com/ramiomarouayache/Flutter-GroceryApp/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)

## ✨Wymagania

1. **Środowisko programistyczne:**
   - Dowolne IDE z zainstalowanym Flutter SDK (np. VSCode, Android Studio, IntelliJ...itd.)

2. **Wiedza:**
   - Podstawowa lub średniozaawansowana znajomość Dart i Flutter
   - Zrozumienie architektury MVVM
   - Znajomość obsługi API
   - Podstawy zarządzania stanem za pomocą GetX

## Test
* Możesz pobrać wersję przedpremierową na urządzenia z Androidem stąd: [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

## Konfiguracja
* Rozpocznij od skonfigurowania swojego endpointu produktu, danych uwierzytelniających i parametrów w `lib\constants\AppConstants`.
* **Alternatywnie**, możesz skorzystać z bezpłatnego endpointu udostępnionego poniżej (aktualnego na dzień udostępnienia) do pomyślnego testowania.
```dart
class AppConstants {
  // Zamień "YOUR_API_PREFIX" na swój własny adres bazowy API.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //JEŚLI_ISTNIEJE

  // Do testów, użyj darmowego adresu bazowego API z wersji wydanej
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Pełne imię i nazwisko właściciela projektu.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Informacja
* Aby używać własnych endpointów API, dostosuj warstwy logiki zgodnie z wytycznymi architektury MVVM, w oparciu o dokumentację swojego API.
* Niektóre obrazy w wersji przedpremierowej zostały usunięte z powodu ograniczeń praw autorskich.

## Współpraca

Rozgałęź to repozytorium i przyczyń się, korzystając z
[pull requestów](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Wszelkie wkłady, duże lub małe, główne funkcje czy poprawki błędów są mile widziane i doceniane,
ale będą dokładnie weryfikowane.

## Pierwsze kroki
Ten projekt to punkt wyjścia do aplikacji Flutter.

Kilka zasobów, które pomogą Ci zacząć, jeśli to Twój pierwszy projekt Flutter:

- [Lab: Napisz swoją pierwszą aplikację Flutter](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Przydatne przykłady Flutter](https://flutter.io/docs/cookbook)

## Licznik odwiedzin

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---