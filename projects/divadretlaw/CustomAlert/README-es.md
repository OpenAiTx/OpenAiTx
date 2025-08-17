# CustomAlert

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dplatforms)](https://swiftpackageindex.com/divadretlaw/CustomAlert)
[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dswift-versions)](https://swiftpackageindex.com/divadretlaw/CustomAlert)

## Por qué

En iOS las alertas no pueden contener imágenes ni nada más que texto. Esto te permite personalizar fácilmente la parte del mensaje con cualquier vista personalizada.

Aunque la alerta está completamente reconstruida en SwiftUI, ha sido diseñada para lucir y comportarse exactamente como una alerta nativa. La alerta utiliza su propia ventana para mostrarse y aprovecha la escala de accesibilidad pero con la ventaja de una vista personalizada.

Si el contenido es demasiado grande porque el texto es muy largo o el texto no encaja debido a la escala de accesibilidad, el contenido se desplazará igual que en una alerta de SwiftUI.

## Uso

| Alerta SwiftUI | Alerta personalizada |
|:-:|:-:|
| ![Alerta nativa](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/SwiftUI.png) | ![Alerta personalizada](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Custom.png) |

Puedes agregar fácilmente una imagen o cambiar la fuente usada en la alerta, o cualquier otra cosa que imagines.

Algo simple con una imagen y un campo de texto

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Fancy.png" width="300">

O diseños más complejos

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Complex.png" width="300">

La API es muy similar a las alertas de SwiftUI

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

Puedes crear Botones Lado a Lado usando `MultiButton`

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

## Instalar

### SwiftPM

```
https://github.com/divadretlaw/CustomAlert.git
```

## Licencia

Ver [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---