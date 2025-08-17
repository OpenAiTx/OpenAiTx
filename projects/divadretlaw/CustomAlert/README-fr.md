# CustomAlert

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dplatforms)](https://swiftpackageindex.com/divadretlaw/CustomAlert)
[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dswift-versions)](https://swiftpackageindex.com/divadretlaw/CustomAlert)

## Pourquoi

Sous iOS, les alertes ne peuvent pas contenir d’images ni d’autres éléments que du texte. Cela vous permet de personnaliser facilement la partie message avec n’importe quelle vue personnalisée.

Bien que l’alerte soit entièrement reconstruite en SwiftUI, elle a été conçue pour ressembler et se comporter exactement comme une alerte native. L’alerte utilise sa propre fenêtre pour s’afficher et exploite le zoom d’accessibilité, mais avec l’avantage d’une vue personnalisée.

Si le contenu est trop grand parce que le texte est trop long ou que le texte ne rentre pas à cause du zoom d’accessibilité, le contenu défilera comme dans une alerte SwiftUI.

## Utilisation

| Alerte SwiftUI | Alerte personnalisée |
|:-:|:-:|
| ![Alerte native](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/SwiftUI.png) | ![Alerte personnalisée](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Custom.png) |

Vous pouvez facilement ajouter une image ou changer la police utilisée dans l’alerte, ou tout autre élément selon votre imagination.

Quelque chose de simple avec une image et un champ de texte

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Fancy.png" width="300">

Ou des mises en page plus complexes

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Complex.png" width="300">

L’API est très similaire à celle des alertes SwiftUI

```swift
.customAlert("Some Fancy Alert", isPresented: $showAlert) {
    Text("I'm a custom Message")
        .font(.custom("Noteworthy", size: 24))
    Image(systemName: "swift")
        .resizable()
        .scaledToFit()
        .frame(maxHeight: 100)
        .foregroundColor(.blue)
} actions: {
    Button {
        // some Action
    } label: {
        Label("Swift", systemImage: "swift")
    }
    
    Button(role: .cancel) {
        // some Action
    } label: {
        Text("Cancel")
    }
}
```

Vous pouvez créer des boutons côte à côte en utilisant `MultiButton`

```swift
.customAlert("Alert with Side by Side Buttons", isPresented: $showAlert) {
    Text("Choose left or right")
} actions: {
    MultiButton {
        Button {
            // some Action
        } label: {
            Text("Left")
        }

        Button {
            // some Action
        } label: {
            Text("Right")
        }
    }
}
```

The alert is customizable via the `Environment`

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/CustomConfiguration.png" width="300">

```swift
.configureCustomAlert { configuration in
    // Adapt the default configuration
}
```

You can also display an Alert inline, within a `List` for example

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/InlineAlert.png" width="300">

```swift
CustomAlertRow {
    // Content
} actions: {
    // Actions
}
```

## Installation

### SwiftPM

```
https://github.com/divadretlaw/CustomAlert.git
```

## Licence

Voir [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---