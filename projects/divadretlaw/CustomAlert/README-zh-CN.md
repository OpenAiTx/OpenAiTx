# CustomAlert

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dplatforms)](https://swiftpackageindex.com/divadretlaw/CustomAlert)
[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dswift-versions)](https://swiftpackageindex.com/divadretlaw/CustomAlert)

## 为什么

在 iOS 中，警报不能包含图片或除文本以外的任何内容。此库允许您轻松地使用任何自定义视图来自定义消息部分。

虽然警报完全用 SwiftUI 重建，但它被设计成看起来和行为上都与原生警报完全相同。该警报使用自己的窗口来显示，并利用无障碍缩放，同时具有自定义视图的优势。

如果内容过大，比如文本过长，或由于无障碍缩放导致文本不适合，内容将像 SwiftUI 警报一样滚动。

## 使用方法

| SwiftUI 警报 | 自定义警报 |
|:-:|:-:|
| ![原生警报](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/SwiftUI.png) | ![自定义警报](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Custom.png) |

您可以轻松添加图片或更改警报中使用的字体，或发挥您的想象力做任何其他修改。

简单的带有图片和文本字段的示例

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Fancy.png" width="300">

或者更复杂的布局

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Complex.png" width="300">

API 与 SwiftUI 警报非常相似。

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
你可以使用 `MultiButton` 创建并排按钮


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

## 安装

### SwiftPM

```
https://github.com/divadretlaw/CustomAlert.git
```

## 许可证

请参见 [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---