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



### 什么是模糊搜索？

模糊搜索算法旨在为给定的搜索查询找到近似匹配项。

假设你有一个产品列表，用户正在寻找“Czy Swetr”，精确匹配将返回空结果，但模糊搜索会找到“Cozy Sweater”。

如果你需要精确匹配——你需要使用标准函数 `.filter { }`，而不是这个库。

模糊搜索演示：
<!-- ![演示](https://s17.postimg.org/47a90nmvj/bitap-search-demo.gif) -->

[![Ifrit 演示][1]][1]

### Ifrit 的优点 / 缺点


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

## 区别：伊弗利特 VS Fuze-Swift？
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

## 安装

1. XCode -> 菜单栏 -> 添加包依赖 -> `https://github.com/ukushu/Ifrit.git`

2. 在你的源文件中 `import Ifrit`。

## 文档 / 使用说明 / 示例项目

Ifrit 仓库没有示例项目。使用以下说明：

[如何使用 Ifrit 的 Fuse](https://github.com/ukushu/Ifrit/blob/main/Documentation/FuseInstructions.md)

[如何使用 Ifrit 的 Levenstain](https://github.com/ukushu/Ifrit/blob/main/Documentation/LevenstainInstructions.md)

[如何在 UI 中显示搜索结果](https://github.com/ukushu/Ifrit/blob/main/Documentation/HowToUseSrchResult.md)

## 贡献

Ifrit 欢迎以 GitHub 问题和拉取请求的形式进行贡献。

  [1]: https://i.sstatic.net/8MwFeAHT.gif


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---