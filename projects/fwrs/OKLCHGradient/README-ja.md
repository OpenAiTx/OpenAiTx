# SwiftUIのためのOKLCHグラデーション

これはSwiftUIの組み込みの[LinearGradient](https://developer.apple.com/documentation/swiftui/lineargradient)、[RadialGradient](https://developer.apple.com/documentation/swiftui/radialgradient)、[EllipticalGradient](https://developer.apple.com/documentation/swiftui/ellipticalgradient)、および[AngularGradient](https://developer.apple.com/documentation/swiftui/angulargradient)シェイプスタイルの代替品で、OKLCHカラーブレンディングを利用してより視覚的に魅力的なグラデーションを作成します。

iOS 17の[Shader](https://developer.apple.com/documentation/swiftui/shader) APIを使用して実装されています。これはプライベートAPIに依存せずにカスタムレンダリングでシェイプスタイルを書く唯一の方法と思われるためです。

SPMを使ってインストールしてください：

```swift
dependencies: [
    .package(url: "https://github.com/fwrs/OKLCHGradient.git", .upToNextMajor(from: "1.0.9"))
]
```

使用するには、グラデーション構造体名の先頭に `OKLCH` を付けてください：

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
そして違いをお楽しみください：

<img src="https://raw.githubusercontent.com/fwrs/OKLCHGradient/main/Misc/Demonstration.png" alt="通常のSwiftUIグラデーションとOKLCHグラデーションを比較したスクリーンショット。通常のグラデーションは青と黄色の間にグレーの色を使っていますが、OKLCHは標準のカラーホイール上で青と黄色の間に位置する緑色を使っています。" width="351px" />

> [!注意]
> 現時点では、AnyGradient構造体をOKLCHグラデーションに渡すことはできません。なぜなら、公開APIを使用してAnyGradientからカラーストップを読み取る方法がないためです。この機能はAppleの組み込みグラデーションに限定されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---