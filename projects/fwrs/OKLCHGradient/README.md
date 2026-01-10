# OKLCH gradients for SwiftUI

This is a drop-in replacement for SwiftUI's built-in [LinearGradient](https://developer.apple.com/documentation/swiftui/lineargradient), [RadialGradient](https://developer.apple.com/documentation/swiftui/radialgradient), [EllipticalGradient](https://developer.apple.com/documentation/swiftui/ellipticalgradient) and [AngularGradient](https://developer.apple.com/documentation/swiftui/angulargradient) shape styles that utilizes OKLCH color blending to create more visually appealing gradients.

Implemented using iOS 17's [Shader](https://developer.apple.com/documentation/swiftui/shader) API, since that seems to be the only way to write shape styles with custom rendering without relying on private APIs.

Install using SPM:

```swift
dependencies: [
    .package(url: "https://github.com/fwrs/OKLCHGradient.git", .upToNextMajor(from: "1.0.9"))
]
```

To use just prepend `OKLCH` to the gradient struct name:

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

And enjoy the difference:

<img src="https://raw.githubusercontent.com/fwrs/OKLCHGradient/main/Misc/Demonstration.png" alt="Screenshot comparing a regular SwiftUI gradient to an OKLCH gradient. The regular gradient utilizes a grey color as an intermediate between blue and yellow colors, while OKLCH uses green, which is the color positioned between blue and yellow on a standard color wheel." width="351px" />

> [!NOTE]
> At the moment it's not possible to pass AnyGradient structs to OKLCH gradients because there isn't a way to read color stops from an AnyGradient using public APIs. This functionality is limited to Apple's own built-in gradients.
