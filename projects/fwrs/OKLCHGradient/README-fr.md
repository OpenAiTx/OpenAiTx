# Dégradés OKLCH pour SwiftUI

Il s'agit d'un remplacement direct pour les styles de forme intégrés de SwiftUI [LinearGradient](https://developer.apple.com/documentation/swiftui/lineargradient), [RadialGradient](https://developer.apple.com/documentation/swiftui/radialgradient), [EllipticalGradient](https://developer.apple.com/documentation/swiftui/ellipticalgradient) et [AngularGradient](https://developer.apple.com/documentation/swiftui/angulargradient) qui utilise le mélange de couleurs OKLCH pour créer des dégradés visuellement plus attrayants.

Implémenté en utilisant l'API [Shader](https://developer.apple.com/documentation/swiftui/shader) d’iOS 17, car cela semble être la seule façon d’écrire des styles de forme avec un rendu personnalisé sans dépendre d’API privées.

Installation via SPM :

```swift
dependencies: [
    .package(url: "https://github.com/fwrs/OKLCHGradient.git", .upToNextMajor(from: "1.0.9"))
]
```
Pour utiliser, il suffit de préfixer `OKLCH` au nom de la structure de dégradé :


```swift
// change

Rectangle()
    .background(LinearGradient(
        colors: [.blue, .yellow],
        startPoint: .leading,
        endPoint: .trailing
    ))

// to

import OKLCHGradient

Rectangle()
    .background(OKLCHLinearGradient(
        colors: [.blue, .yellow],
        startPoint: .leading,
        endPoint: .trailing
    ))
```

Et profitez de la différence :

<img src="https://raw.githubusercontent.com/fwrs/OKLCHGradient/main/Misc/Demonstration.png" alt="Capture d'écran comparant un dégradé SwiftUI classique à un dégradé OKLCH. Le dégradé classique utilise une couleur grise comme intermédiaire entre le bleu et le jaune, tandis que OKLCH utilise le vert, qui est la couleur située entre le bleu et le jaune sur une roue chromatique standard." width="351px" />

> [!NOTE]
> Pour le moment, il n'est pas possible de passer des structures AnyGradient aux dégradés OKLCH car il n'existe pas de moyen de lire les arrêts de couleur d'un AnyGradient en utilisant les API publiques. Cette fonctionnalité est limitée aux dégradés intégrés d'Apple.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---