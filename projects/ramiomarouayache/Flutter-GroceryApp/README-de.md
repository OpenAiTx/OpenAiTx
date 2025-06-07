# GroceryApp Starter

Vereinfachte Vorlage für eine Einkaufs-App für ein unkompliziertes Einkaufserlebnis. 🛒✨

Gerne den Stern ⭐ dem Repository geben, wenn du es nützlich findest.

## Design

**Klicke auf das Bild unten, um das Figma-Design zu sehen:**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨Anforderungen

1. **Entwicklungsumgebung:**
   - Jede IDE mit installiertem Flutter SDK (z.B. VSCode, Android Studio, IntelliJ...usw.)

2. **Wissensbasis:**
   - Grundlegende bis mittlere Kenntnisse in Dart und Flutter
   - Verständnis der MVVM-Architektur
   - Vertrautheit mit API-Handling
   - Grundlagen des State Management mit GetX
  
## Test
* Die vorveröffentlichte Version für Android-Geräte kann hier heruntergeladen werden: [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## Einrichtung
* Beginne mit der Konfiguration deines Produktendpunkts, der Zugangsdaten und Parameter in `lib\constants\AppConstants`.
* **Alternativ** kannst du den unten angegebenen kostenlosen Endpunkt (Stand: Veröffentlichungsdatum) für erfolgreiche Tests verwenden.
```dart
class AppConstants {
  // Ersetze "YOUR_API_PREFIX" durch deine eigene API-Basis-URL.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //FALLS_VORHANDEN

  // Zum Testen verwende die kostenlose API-Basis-URL aus der veröffentlichten Version
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Vollständiger Name des Projektinhabers.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Hinweis
* Um eigene API-Endpunkte zu verwenden, passe die logischen Schichten gemäß MVVM-Architektur und deiner API-Dokumentation an.
* Einige Bilder in der vorveröffentlichten Version wurden aufgrund von Urheberrechtsbeschränkungen entfernt.

## Beitrag leisten

Bitte forke dieses Repository und trage mit
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls) bei.

Jede Unterstützung – ob groß oder klein, neue Funktionen oder Bugfixes – ist willkommen und wird sorgfältig geprüft.


## Erste Schritte
Dieses Projekt ist ein Startpunkt für eine Flutter-Anwendung.

Einige Ressourcen, um dir den Einstieg zu erleichtern, falls dies dein erstes Flutter-Projekt ist:

- [Lab: Schreibe deine erste Flutter-App](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Nützliche Flutter-Beispiele](https://flutter.io/docs/cookbook)

## Besucherzähler

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Lädt">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---