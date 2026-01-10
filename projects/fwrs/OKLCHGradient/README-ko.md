# SwiftUI용 OKLCH 그라디언트

이는 SwiftUI 내장 [LinearGradient](https://developer.apple.com/documentation/swiftui/lineargradient), [RadialGradient](https://developer.apple.com/documentation/swiftui/radialgradient), [EllipticalGradient](https://developer.apple.com/documentation/swiftui/ellipticalgradient) 및 [AngularGradient](https://developer.apple.com/documentation/swiftui/angulargradient) 쉐이프 스타일을 대체하는 드롭인으로, OKLCH 색상 혼합을 활용하여 시각적으로 더 매력적인 그라디언트를 만듭니다.

iOS 17의 [Shader](https://developer.apple.com/documentation/swiftui/shader) API를 사용하여 구현되었으며, 이는 개인 API에 의존하지 않고 커스텀 렌더링으로 쉐이프 스타일을 작성하는 유일한 방법인 것으로 보입니다.

SPM을 사용하여 설치:

```swift
dependencies: [
    .package(url: "https://github.com/fwrs/OKLCHGradient.git", .upToNextMajor(from: "1.0.9"))
]
```
그라디언트 구조체 이름 앞에 `OKLCH`를 붙여서 사용하세요:


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
그리고 차이를 즐기세요:

<img src="https://raw.githubusercontent.com/fwrs/OKLCHGradient/main/Misc/Demonstration.png" alt="일반 SwiftUI 그라디언트와 OKLCH 그라디언트를 비교한 스크린샷입니다. 일반 그라디언트는 파란색과 노란색 사이에 회색을 중간 색상으로 사용하지만, OKLCH는 표준 색상 휠에서 파란색과 노란색 사이에 위치한 녹색을 사용합니다." width="351px" />

> [!NOTE]
> 현재 AnyGradient 구조체를 OKLCH 그라디언트에 전달하는 것은 불가능합니다. 공개 API를 통해 AnyGradient에서 색상 정지를 읽는 방법이 없기 때문입니다. 이 기능은 애플 자체 내장 그라디언트에만 제한됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---