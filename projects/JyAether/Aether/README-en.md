**1. Introduction**

* **Aether**: The industry's first innovative dynamic solution based on AST + Runtime to build KMP + CMP, achieving dynamic delivery of logical pages.
* Covers the entire process from development to operation and maintenance. Improves release efficiency and hotfix capability, effectively alleviating the lack of dynamic features in KMP, and can greatly promote the ecological development of Android KMP.
* However, due to limited personal energy, many engineering capabilities still need to be developed. Looking forward to the community jointly enhancing support for complex syntax and ecosystem construction in the future, reducing development costs, optimizing experience, and expanding business coverage; promoting large front-end integration to achieve cross-terminal consistent experience.
* Currently, the smallest experimental prototype is realized, and future construction depends on the community.

---

**2. Project Structure**

* `/composeApp` is the part used to share code between Compose Multiplatform applications.
  It contains the following subfolders:
  - `commonMain` for code common to all target platforms.
  - Other folders contain Kotlin code compiled for specific platforms. For example, if you want to use Apple’s CoreCrypto in the iOS part,
    you should write the related calls in the `iosMain` folder.

* `/iosApp` contains the iOS application. Even if you share UI via Compose Multiplatform,
  you still need this entry point to launch your iOS app. This is also where you add SwiftUI code.

* `/core` module is the core module of Aether.
git 
---

**3. Challenges**

* The workload is huge and requires patience. The author explores in spare time, having almost devoted all time.
* The project is quite complex; although the core path is running, some complex syntax is not yet supported and requires patience to ensure compatibility. The reason for open sourcing is also to hope for community involvement.
* Because it involves AST and DSL transformation and parsing, execution, and virtual machine loading, there is a certain threshold for troubleshooting, and boundary exception logic handling needs more attention from successors.

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---