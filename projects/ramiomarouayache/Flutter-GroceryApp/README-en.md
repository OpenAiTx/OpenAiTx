# GroceryApp Starter

A streamlined grocery app template for a straightforward shopping experience. 🛒✨

Feel free to star ⭐ the repository if you find it valuable.

## Design

**Click the image below to view the Figma design:**

[![Design Preview](https://raw.githubusercontent.com/ramiomarouayache/Flutter-GroceryApp/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)

## ✨Requirements

1. **Development Environment:**
   - Any IDE with Flutter SDK installed (e.g., VSCode, Android Studio, IntelliJ, etc.)

2. **Knowledge Base:**
   - Basic to intermediate knowledge of Dart and Flutter
   - Understanding of MVVM architecture
   - Familiarity with API handling
   - Basics of state management using GetX

## Test
* You can download the pre-released version for Android devices from here: [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

## Setup
* Start by configuring your product endpoint, credentials, and parameters in `lib/constants/AppConstants`.
* **Alternatively**, use the free endpoint provided below (as of the sharing date) for successful testing.
```dart
class AppConstants {
  // Replace "YOUR_API_PREFIX" with your own API base URL.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //IF_EXIST

  // For testing, use the free API base URL from the released version
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Project owner full name.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Notice
* To use your own API endpoints, customize logical layers following MVVM architecture guidelines based on your API documentation.
* Certain images in the pre-released version were removed due to copyright restrictions.

## Contributing

Please fork this repository and contribute back using
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Any contributions, large or small, major features, or bug fixes are welcomed and appreciated
but will be thoroughly reviewed.

## Getting Started
This project is a starting point for a Flutter application.

A few resources to get you started if this is your first Flutter project:

- [Lab: Write your first Flutter app](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Useful Flutter samples](https://flutter.io/docs/cookbook)

## Visitors Count

<img align="left" src="https://profile-counter.glitch.me/GroceryApp/count.svg" alt="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---