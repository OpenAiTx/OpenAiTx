# GroceryApp Starter

精簡的雜貨購物應用程式範本，帶來直觀的購物體驗。🛒✨

如果您覺得這個專案有價值，歡迎為此儲存庫加星 ⭐。

## 設計

**點擊下方圖片以檢視 Figma 設計稿：**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨需求

1. **開發環境：**
   - 安裝了 Flutter SDK 的任何 IDE（如 VSCode、Android Studio、IntelliJ 等）

2. **知識基礎：**
   - Dart 及 Flutter 的基礎至中階知識
   - 了解 MVVM 架構
   - 熟悉 API 處理
   - 具備使用 GetX 進行狀態管理的基礎

## 測試
* 你可以從這裡下載適用於 Android 裝置的預發佈版本 [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1)。
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## 設定
* 請先在 `lib\constants\AppConstants` 中設定您的產品端點、認證資訊及參數。
* **或者**，可以使用下方提供的免費端點（以分享日為準）進行測試。

```dart
class AppConstants {
  // 請將 "YOUR_API_PREFIX" 替換為您自己的 API 基本網址。
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //IF_EXIST

  // 測試時，請使用已發佈版本中的免費 API 基本網址
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // 專案擁有者全名。
  static const String projectOwnerName = "FULL_NAME";
}
```

## 注意事項
* 若要使用您自己的 API 端點，請根據您的 API 文件，依照 MVVM 架構原則自訂邏輯層。
* 部分預發佈版本中的圖片因版權限制已被移除。

## 貢獻方式

請 fork 此儲存庫並通過
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls) 回饋您的貢獻。

任何規模的貢獻、重大功能、錯誤修復都歡迎且感謝，
但都會被嚴格審查。

## 入門指南
本專案為 Flutter 應用程式的起始範本。

如果這是你第一次進行 Flutter 專案，以下資源可協助你快速上手：

- [Lab: 撰寫你的第一個 Flutter 應用程式](https://flutter.io/docs/get-started/codelab)
- [Cookbook: 實用的 Flutter 範例](https://flutter.io/docs/cookbook)

## 訪客計數

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---