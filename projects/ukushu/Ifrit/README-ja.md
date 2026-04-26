# NOT ALL CODE IS MIT-LICENSED! FULLY READ README


# Ifrit

Super lightweight lib for fuzzy searching. 

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fukushu%2FIfrit%2Fbadge%3Ftype%3Dswift-versions)](https://swiftpackageindex.com/ukushu/Ifrit)


Works on iOS / macOS / Linux / Android and more: 

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fukushu%2FIfrit%2Fbadge%3Ftype%3Dplatforms)](https://swiftpackageindex.com/ukushu/Ifrit)

<img src="https://raw.githubusercontent.com/ukushu/Ifrit/main/Z_Logo/Ifrit_Logo_360.png" width="150" height="150">

This repository is built upon the archived Fuse-Swift project by KRisk: https://github.com/krisk/fuse-swift

---

```
https://github.com/ukushu/Ifrit.git
git@github.com:ukushu/Ifrit.git
```
---



### ファジー検索とは？

ファジー検索アルゴリズムは、与えられた検索クエリに対して近似一致を見つけるために設計されています。

例えば、商品リストがあり、ユーザーが「Czy Swetr,」を探しているとします。完全一致では何も返しませんが、ファジー検索は「Cozy Sweater.」を見つけます。

完全一致が必要な場合は、このライブラリではなく標準の `.filter { }` 関数を使用する必要があります。

ファジー検索のデモ：
<!-- ![Demo](https://s17.postimg.org/47a90nmvj/bitap-search-demo.gif) -->

[![Ifrit demo][1]][1]

### Ifritの利点 / 欠点


```diff
Advanteges:
+ Super lightweight
+ No dependencies
+ OS supported: MacOS(>=v10_15), iOS(>=v13), visionOS, watchOS, twOS, Linux
+ Async ( async/await + callbacks both )
+ Text highlight support (AttributedString)
+ Code covered with automated tests
+ Most of code licensed by "MIT License" 
+ Can be linked as both Static and Dynamic package — choose what works best for you

Disadvantages:
- Not tested in production
- FuzzyFind licensed by "Apache License, Version 2.0"
```

## 違い：イフリート VS フューズ-スウィフト？
```diff
- Fuze-Swift: Swift 5.1~
+ Ifrit: Swift 6.2 compatible

+ Fuze-Swift support Pods and Packages :)
- Ifrit supports only Packages :(

- Fuze-Swift is dead :(
+ 🔥🔥🔥 Ifrit is Fuse-Swift, reborn from the hells ashes! But more powerful and alive than ever! 🔥🔥🔥 :)

- Fuse-Swift supports asynchronous functions with callbacks but lacks native async/await support. :(
+ Ifrit supports callbacks and async/await both :)

- Fuze-Swift have async/multithreading issues. Crashes is possible :(
+ Ifrit is stable and crash-free!

- Fuse-Swift's async functions return incorrect results - wrong indexes. :((((
+ Ifrit's async functions return correct indexes and are fully covered with tests :)

- Fuze-Swift was written for Xcode 11 and now generates numerous warnings :(
+ Ifrit's code is updated to the latest Swift standards of 2026 year :) 
- But Ifrit still have a few build warnings :(

+ Ifrit - extended coverage with automated tests :)
+ Ifrit features an additional search system using the Levenshtein distance algorithm. :)
+ Ifrit allows searching by multiple search templates
+ Ifrit's syntax has been slightly adjusted for improved flexibility
+ Ifrit's sync search is 2% faster than Fuse's (using M1 processor and standard settings).
+         Async search performance remains the same as Fuse's (standard settings).

+ Ifrit was ported to Kotlin programming language: https://github.com/dfabulich/skip-ifrit
```

## インストール

1. XCode -> メニューライン -> パッケージ依存関係を追加 -> `https://github.com/ukushu/Ifrit.git`

2. ソースファイルに `import Ifrit` を記述します。

## ドキュメント / 説明書 / サンプルプロジェクト

Ifritリポジトリにはサンプルプロジェクトがありません。以下の説明書を利用してください：

[IfritのFuseの使い方](https://github.com/ukushu/Ifrit/blob/main/Documentation/FuseInstructions.md)

[IfritのLevenstainの使い方](https://github.com/ukushu/Ifrit/blob/main/Documentation/LevenstainInstructions.md)

[検索結果をUIに表示する方法](https://github.com/ukushu/Ifrit/blob/main/Documentation/HowToUseSrchResult.md)

## コントリビューティング

IfritはGitHubのイシューやプルリクエストでの貢献を歓迎します。

  [1]: https://i.sstatic.net/8MwFeAHT.gif


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---