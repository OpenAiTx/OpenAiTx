# GroceryApp スターター

シンプルなショッピング体験のための効率的なグローサリーアプリテンプレートです。🛒✨

価値を感じたらリポジトリにスター ⭐ を付けてください。

## デザイン

**下の画像をクリックしてFigmaデザインを表示できます:**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨要件

1. **開発環境:**
   - Flutter SDKがインストールされた任意のIDE（例: VSCode、Android Studio、IntelliJなど）

2. **知識ベース:**
   - DartおよびFlutterの基礎～中級知識
   - MVVMアーキテクチャの理解
   - APIハンドリングの知識
   - GetXを使った状態管理の基礎

## テスト
* Android端末向けのプレリリース版は[releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1)からダウンロードできます。
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## セットアップ
* `lib\constants\AppConstants`内で、まずは商品エンドポイント・認証情報・パラメータを設定してください。
* **または**、下記の無料エンドポイント（共有日時点）を利用してテストを成功させることもできます。
```dart
class AppConstants {
  // "YOUR_API_PREFIX" をご自身のAPIベースURLに置き換えてください。
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //IF_EXIST

  // テスト用に、リリース版の無料APIベースURLを使用してください
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // プロジェクトオーナーのフルネーム
  static const String projectOwnerName = "FULL_NAME";
}
```

## 注意事項
* 独自のAPIエンドポイントを使う場合は、ご利用のAPIドキュメントに従ってMVVMアーキテクチャに沿ったロジック層をカスタマイズしてください。
* プレリリース版に含まれる一部画像は著作権上の理由で削除されています。

## コントリビューション

このリポジトリをフォークし、
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls)
を使ってコントリビュートしてください。

大規模・小規模問わず、メジャーな機能追加やバグ修正など、あらゆる貢献を歓迎しますが、しっかりレビューされます。


## はじめに
このプロジェクトはFlutterアプリケーションの出発点です。

初めてFlutterプロジェクトに取り組む方のためのリソース:

- [Lab: 初めてのFlutterアプリを書く](https://flutter.io/docs/get-started/codelab)
- [Cookbook: 便利なFlutterサンプル集](https://flutter.io/docs/cookbook)

## 訪問者数

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---