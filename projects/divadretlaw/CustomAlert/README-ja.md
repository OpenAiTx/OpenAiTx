# CustomAlert

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dplatforms)](https://swiftpackageindex.com/divadretlaw/CustomAlert)
[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fdivadretlaw%2FCustomAlert%2Fbadge%3Ftype%3Dswift-versions)](https://swiftpackageindex.com/divadretlaw/CustomAlert)

## なぜ

iOSのアラートでは画像やテキスト以外の要素を含めることができません。これにより、メッセージ部分を任意のカスタムビューで簡単にカスタマイズできます。

アラートはSwiftUIで完全に再構築されていますが、ネイティブのアラートとまったく同じ見た目と動作になるよう設計されています。アラートは独自のウィンドウを使用して表示され、アクセシビリティのスケーリングも利用しつつ、カスタムビューの利点を持っています。

テキストが長すぎるためにコンテンツが大きすぎる場合や、アクセシビリティスケーリングでテキストが収まらない場合、SwiftUIのアラートと同様にコンテンツはスクロールします。

## 使い方

| SwiftUI アラート | カスタムアラート |
|:-:|:-:|
| ![ネイティブアラート](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/SwiftUI.png) | ![カスタムアラート](https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Custom.png) |

アラートに画像を簡単に追加したり、フォントを変更したり、その他何でも想像力次第で変更できます。

画像とテキストフィールドを使ったシンプルな例

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Fancy.png" width="300">

より複雑なレイアウトも可能です

<img src="https://raw.githubusercontent.com/divadretlaw/CustomAlert/main/Sources/CustomAlert/Documentation.docc/Resources/Complex.png" width="300">

APIはSwiftUIのアラートと非常に似ています。

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

`MultiButton` を使用してサイドバイサイドボタンを作成できます。

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

## インストール

### SwiftPM

```
https://github.com/divadretlaw/CustomAlert.git
```

## ライセンス

[LICENSE](LICENSE) を参照してください


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---