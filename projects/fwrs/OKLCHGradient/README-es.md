# Gradientes OKLCH para SwiftUI

Esta es una sustitución directa para los estilos de forma incorporados de SwiftUI [LinearGradient](https://developer.apple.com/documentation/swiftui/lineargradient), [RadialGradient](https://developer.apple.com/documentation/swiftui/radialgradient), [EllipticalGradient](https://developer.apple.com/documentation/swiftui/ellipticalgradient) y [AngularGradient](https://developer.apple.com/documentation/swiftui/angulargradient) que utiliza la mezcla de color OKLCH para crear gradientes visualmente más atractivos.

Implementado usando la API [Shader](https://developer.apple.com/documentation/swiftui/shader) de iOS 17, ya que parece ser la única manera de escribir estilos de forma con renderizado personalizado sin depender de APIs privadas.

Instalar usando SPM:

```swift
dependencies: [
    .package(url: "https://github.com/fwrs/OKLCHGradient.git", .upToNextMajor(from: "1.0.9"))
]
```

Para usar, simplemente anteponga `OKLCH` al nombre de la estructura del gradiente:

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

Y disfruta la diferencia:

<img src="https://raw.githubusercontent.com/fwrs/OKLCHGradient/main/Misc/Demonstration.png" alt="Captura de pantalla que compara un degradado SwiftUI regular con un degradado OKLCH. El degradado regular utiliza un color gris como intermedio entre los colores azul y amarillo, mientras que OKLCH usa verde, que es el color ubicado entre azul y amarillo en una rueda de colores estándar." width="351px" />

> [!NOTE]
> Por el momento no es posible pasar estructuras AnyGradient a degradados OKLCH porque no existe una forma de leer los puntos de color de un AnyGradient usando APIs públicas. Esta funcionalidad está limitada a los degradados incorporados propios de Apple.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---