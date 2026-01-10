# SwiftUI 的 OKLCH 渐变

这是 SwiftUI 内置的 [LinearGradient](https://developer.apple.com/documentation/swiftui/lineargradient)、[RadialGradient](https://developer.apple.com/documentation/swiftui/radialgradient)、[EllipticalGradient](https://developer.apple.com/documentation/swiftui/ellipticalgradient) 和 [AngularGradient](https://developer.apple.com/documentation/swiftui/angulargradient) 形状样式的替代方案，利用 OKLCH 颜色混合创建更具视觉吸引力的渐变。

使用 iOS 17 的 [Shader](https://developer.apple.com/documentation/swiftui/shader) API 实现，因为这似乎是唯一可以编写自定义渲染形状样式且不依赖私有 API 的方法。

使用 SPM 安装：

```swift
dependencies: [
    .package(url: "https://github.com/fwrs/OKLCHGradient.git", .upToNextMajor(from: "1.0.9"))
]
```
只需在渐变结构名称前添加 `OKLCH`：


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

并享受不同之处：

<img src="https://raw.githubusercontent.com/fwrs/OKLCHGradient/main/Misc/Demonstration.png" alt="截图比较常规 SwiftUI 渐变与 OKLCH 渐变。常规渐变在蓝色和黄色之间使用灰色作为中间色，而 OKLCH 使用绿色，这是标准色轮中蓝色和黄色之间的位置色。" width="351px" />

> [!注意]
> 目前无法将 AnyGradient 结构传递给 OKLCH 渐变，因为没有公共 API 可以读取 AnyGradient 的颜色停点。此功能仅限于苹果自带的内置渐变。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---