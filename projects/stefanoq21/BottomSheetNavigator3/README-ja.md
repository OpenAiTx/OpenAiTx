# Material3 BottomSheet Navigation

このライブラリは、Material3 BottomSheets を使用した Compose プロジェクト向けのナビゲーションソリューションを提供します。BottomSheet をナビゲーションルートとして定義できるため、`androidx.compose.material.navigation` および `androidx.compose.material:material` ライブラリが不要になります。これにより、アプリの依存関係が簡素化され、一貫した Material3 体験が保証されます。  
また、このライブラリは `androidx.navigation:navigation-compose:2.8.0-beta0X` の新機能を活用し、シリアライズされたクラスでルートを定義できるようにします。

[![Maven Central](https://img.shields.io/maven-central/v/io.github.stefanoq21/material3-navigation)](https://central.sonatype.com/artifact/io.github.stefanoq21/material3-navigation)

![Static Badge](https://img.shields.io/badge/minSdk-21-blue?link=https%3A%2F%2Fgithub.com%2Fstefanoq21%2FBottomSheetNavigator3%2Fblob%2Fmain%2Fmaterial3-navigation%2Fbuild.gradle.kts%23L15)

## 実装

[app](https://github.com/stefanoq21/BottomSheetNavigator3/tree/main/app "app") モジュールで使われている実装方法を参照できます。あるいは、以下に詳細な説明があります。

### 依存関係  
このライブラリは現在 MavenCentral で利用可能です!!!  
`libs.versions.toml` に依存関係を追加してください。

```
[versions]
...
material3Navigation = "X.X.X" current release version

[libraries]
...
material3-navigation = { group = "io.github.stefanoq21", name = "material3-navigation", version.ref = "material3Navigation" }

```
`build.gradle.kts` に依存関係を実装します:
```
...
dependencies {
...
 implementation(libs.material3.navigation)
```
### 使用法
**BottomSheetNavigator** を定義する
```
...
   val bottomSheetNavigator =
                    rememberBottomSheetNavigator(skipPartiallyExpanded = true/false)
                val navController = rememberNavController(bottomSheetNavigator)
```
**ModalBottomSheetLayout** を **NavHost** コンポーネントの上に追加し、**bottomSheetNavigator** をパラメータとして渡します:
```
ModalBottomSheetLayout(
                        modifier = Modifier
                            .fillMaxSize(),
                        bottomSheetNavigator = bottomSheetNavigator
                    ) {
                        NavHost(
                            navController = navController,
                            startDestination = Screen.Home
                        ) {
...
```
使用しているCompose Navigationのバージョンに応じて、ルートを文字列またはデータクラスとして定義します:
```
...
   bottomSheet<Screen.BottomSheetFullScreen> {
                                BSFullScreenLayout()
                            }
  bottomSheet("BottomSheetFullScreen") {
                                BSFullScreenLayout()
                            }
...
```
すべて準備が整いました！あとはいつも通り新しい目的地にナビゲートするだけです：
```
...
Button(onClick = { navController.navigate(Screen.BottomSheetFullScreen) }) {
                                        Text(text = "BottomSheetFullScreen")
                                    }
...
```

### ボトムシートからの戻るナビゲーション

ボトムシートに戻るまたは閉じるボタンを実装するには、`onBackPressedDispatcher.onBackPressed()`の使用をお勧めします。これは、`navController.popBackStack()`を使用するとアニメーションが表示されないためです。この場合、ボトムシートから開始するナビゲーション中の問題を避けるためにアニメーションが無効化されています。

### カスタマイズ

このライブラリは現在、標準の`androidx.compose.material3.ModalBottomSheet`と同じカスタマイズオプションをサポートしています。ナビゲーショングラフで使用されるすべてのボトムシートの外観は、`ModalBottomSheetLayout`にパラメータを渡すことでカスタマイズできます。

## プレビュー
![](https://github.com/stefanoq21/BottomSheetNavigator3/assets/22545898/c971f6cf-bb04-41c1-b3ea-7b72757e09af)


## コントリビューション

このライブラリへの貢献を歓迎します！バグ報告、機能リクエスト、コード改善がありましたら、ぜひプルリクエストを作成してください。このライブラリをさらに良くするためのご協力に感謝します。

## ライセンス

   Copyright 2024 stefanoq21

   Apache License, Version 2.0（以下「ライセンス」）の下でライセンスされています。
   ライセンスに従わない限り、このファイルを使用することはできません。
   ライセンスのコピーは以下から入手できます。

       http://www.apache.org/licenses/LICENSE-2.0

   適用法または書面での同意によらない限り、
   本ソフトウェアは「現状のまま」提供され、
   明示的または黙示的な保証は一切ありません。
   ライセンスに基づく権利と制限については、
   ライセンス文書をご覧ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---