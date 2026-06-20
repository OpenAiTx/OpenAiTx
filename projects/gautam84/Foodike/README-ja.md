![GitHub Cards Preview](https://github.com/gautam84/Foodike/blob/master/art/FoodikeIntrouctionMockUp.jpg?raw=true)

# 🍔 Foodike
Foodikeはシンプルで使いやすいフードデリバリーアプリです。Android-Jetpack Composeを使用して構築されており、MVVMの原則に基づき、最新のAndroidアーキテクチャコンポーネントを用いて開発されています。

## デモ 
![](https://github.com/gautam84/Foodike/blob/master/art/demo.gif)

## スクリーンショット 📱 
オンボーディング | ログイン | ホーム | 詳細 | 履歴 | カート | プロフィール
--- | --- | --- | --- |--- |--- |--- 
![](https://github.com/gautam84/Foodike/blob/master/screenshots/onboarding.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/login.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/home.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/details.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/history.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/cart.jpeg) | ![](https://github.com/gautam84/Foodike/blob/master/screenshots/profile.jpeg) 


## 使用技術 🛠

- [Kotlin](https://kotlinlang.org/) - Android開発のための第一級かつ公式のプログラミング言語。
- [Jetpack Compose](https://developer.android.com/jetpack/compose) - Jetpack ComposeはAndroidの
  ネイティブUIを構築するための最新ツールキットです。
- [Coroutines](https://kotlinlang.org/docs/reference/coroutines-overview.html) - コルーチンは、
  Androidで非同期に実行されるコードを簡素化するために使用できる並行設計パターンです。
- [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flowは非同期版の
  Sequenceであり、値が遅延生成されるコレクションの一種です。
- [Android Architecture Components](https://developer.android.com/topic/libraries/architecture) -
  堅牢でテスト可能かつ保守しやすいアプリ設計を支援するライブラリ群。
  - [Stateflow](https://developer.android.com/kotlin/flow/stateflow-and-sharedflow) - StateFlowは
    現在および新しい状態の更新を収集者に発行する状態保持可能なオブザーバブルフローです。
  - [Flow](https://kotlinlang.org/docs/reference/coroutines/flow.html) - Flowは非同期版の
    Sequenceであり、値が遅延生成されるコレクションの一種です。
  - [ViewModel](https://developer.android.com/topic/libraries/architecture/viewmodel) - UIの変更で
    破棄されないUI関連データを保存します。
  - [Jetpack Compose Navigation](https://developer.android.com/jetpack/compose/navigation) - ナビゲーション
    コンポーネントはJetpack Composeアプリケーションをサポートします。
  - [DataStore](https://developer.android.com/topic/libraries/architecture/datastore) - Jetpack
    DataStoreはキーと値のペアや型付きオブジェクトをプロトコルバッファで保存できるデータ保存ソリューションです。DataStoreはKotlinのコルーチンとFlowを用いて
    データを非同期・一貫性・トランザクション的に保存します。
- [Dagger-Hilt](https://developer.android.com/training/dependency-injection/hilt-android) - Hiltは
  Androidの依存性注入ライブラリで、プロジェクト内での手動依存性注入のボイラープレートを削減します。手動依存性注入は各クラスとその依存関係を手作業で構築し、
  依存関係を再利用・管理するためにコンテナを使う必要があります。

  
- [Splash API](https://developer.android.com/develop/ui/views/launch/splash-screen) - Android 12から、SplashScreen APIにより、起動時のアニメーション、起動時のアプリ内モーション、アプリアイコンを表示するスプラッシュスクリーン、およびアプリ本体への遷移が可能になります。SplashScreenはWindowであり、したがってActivityを覆います。
- [Material Components for Android](https://github.com/material-components/material-components-android)
  - Android向けのモジュール式でカスタマイズ可能なMaterial Design UIコンポーネントです。
- [Figma](https://figma.com/) - Figmaは主にウェブベースのベクターグラフィックスエディタ兼プロトタイピングツールです。

## Architecture 🗼

このアプリは[***MVVM (Model View
View-Model)***](https://developer.android.com/jetpack/docs/guide#recommended-app-arch)アーキテクチャを使用しています。

![](https://github.com/gautam84/Foodike/blob/master/art/mvvm.png)

## Build-tool 🧰
このプロジェクトをビルドするには、[Android Studio Beta 3以降](https://developer.android.com/studio/preview)が必要です。

## Contact 📩

連絡したいですか？DMはこちら👇

メールはこちらへ:- gautamhazarika01@gmail.com

私のポートフォリオ:- www.gautamhz.com

## Donation 💰

このプロジェクトが開発時間短縮に役立った場合は、コーヒーを一杯ご馳走してください :)

<a href="https://www.buymeacoffee.com/gautam.hz" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## License 🔖


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

## バックエンド:

バックエンドは全てKotlinでktorを使用して構築しています。[こちら](https://github.com/gautam84/foodike-backend)で確認できます。


## 次のステップ:

- バックエンドをAndroidアプリに統合する。
- すべてのコードを最新バージョンに更新する。
- ユニットテスト、統合テスト、UI/エンドツーエンドテストを書く。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---