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



### Qu'est-ce que la recherche floue ?

Un algorithme de recherche floue est conçu pour trouver des correspondances approximatives pour une requête de recherche donnée. 

Disons que vous avez une liste de produits, et qu'un utilisateur recherche un "Czy Swetr,". Une correspondance exacte ne renverra rien, mais la recherche floue trouvera "Cozy Sweater.".

Si vous avez besoin d'une correspondance exacte, vous devez utiliser la fonction standard `.filter { }` au lieu de cette bibliothèque.

Démo de la recherche floue :
<!-- ![Demo](https://s17.postimg.org/47a90nmvj/bitap-search-demo.gif) -->

[![Démo Ifrit][1]][1]

### Avantages / Inconvénients d'Ifrit

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

## Différence : Ifrit VS Fuze-Swift ?
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

## Installation

1. XCode -> Menu Ligne -> Ajouter des dépendances de paquet -> `https://github.com/ukushu/Ifrit.git`

2. `import Ifrit` dans vos fichiers source.

## Documentation / Instructions / Projet d'exemple

Le dépôt Ifrit ne contient pas de projet d'exemple. Utilisez les instructions ci-dessous :

[Comment utiliser Fuse d'Ifrit](https://github.com/ukushu/Ifrit/blob/main/Documentation/FuseInstructions.md)

[Comment utiliser Levenstain d'Ifrit](https://github.com/ukushu/Ifrit/blob/main/Documentation/LevenstainInstructions.md)

[Comment afficher les résultats de recherche dans l'interface utilisateur](https://github.com/ukushu/Ifrit/blob/main/Documentation/HowToUseSrchResult.md)

## Contribution

Ifrit accueille les contributions sous forme de problèmes GitHub et de demandes de tirage.

  [1]: https://i.sstatic.net/8MwFeAHT.gif


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-26

---