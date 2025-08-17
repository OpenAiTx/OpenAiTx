# CustomAlert

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dplatforms)](https://swiftpackageindex.com/divadretlaw/CustomAlert)
[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dswift-versions)](https://swiftpackageindex.com/divadretlaw/CustomAlert)

## 이유

iOS에서는 알림에 이미지나 텍스트 이외의 내용을 포함할 수 없습니다. 이 라이브러리는 메시지 부분을 원하는 커스텀 뷰로 쉽게 커스터마이즈할 수 있게 해줍니다.

알림은 완전히 SwiftUI로 재구성되었지만, 네이티브 알림과 똑같은 모양과 동작을 하도록 설계되었습니다. 알림은 자체 창을 사용하여 표시되고 접근성 확대 기능을 활용하지만 커스텀 뷰라는 장점이 있습니다.

텍스트가 너무 길거나 접근성 확대 때문에 텍스트가 맞지 않아 콘텐츠가 너무 클 경우, SwiftUI 알림과 마찬가지로 콘텐츠가 스크롤됩니다.

## 사용법

| SwiftUI 알림 | 커스텀 알림 |
|:-:|:-:|
| ![Native Alert](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/SwiftUI.png) | ![Custom Alert](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Custom.png) |

알림에 이미지를 쉽게 추가하거나, 알림에 사용되는 폰트를 변경하거나, 상상할 수 있는 모든 것을 할 수 있습니다.

이미지와 텍스트 필드를 간단히 넣은 예

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Fancy.png" width="300">

더 복잡한 레이아웃 예

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Complex.png" width="300">

API는 SwiftUI 알림과 매우 유사합니다.

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

`MultiButton`을 사용하여 나란히 버튼을 만들 수 있습니다.

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

## 설치

### SwiftPM

```
https://github.com/divadretlaw/CustomAlert.git
```
## 라이선스

[LICENSE](LICENSE)를 참조하세요



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---