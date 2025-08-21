# Elementary: HTML Templating in Pure Swift

**A modern and efficient HTML rendering library - inspired by SwiftUI, built for the web.**

[![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fsliemeobn%2Felementary%2Fbadge%3Ftype%3Dswift-versions)](https://swiftpackageindex.com/sliemeobn/elementary) [![](https://img.shields.io/endpoint?url=https%3A%2F%2Fswiftpackageindex.com%2Fapi%2Fpackages%2Fsliemeobn%2Felementary%2Fbadge%3Ftype%3Dplatforms)](https://swiftpackageindex.com/sliemeobn/elementary)

[Examples](#play-with-it) | [Motivation](#motivation-and-other-packages) | [Discussion](https://github.com/sliemeobn/elementary/discussions)

```swift
struct MainPage: HTMLDocument {
    var title = "Elementary"

    var head: some HTML {
        meta(.name(.description), .content("Typesafe HTML in modern Swift"))
    }

    var body: some HTML {
        main {
            h1 { "Features" }

            FeatureList(features: [
                "HTML in pure Swift",
                "SwiftUI-inspired composition",
                "Lightweight and fast",
                "Framework agnostic and unopinionated",
            ])

            a(.href("https://github.com/sliemeobn/elementary"), .class("fancy-style")) {
                "Learn more"
            }
        }
    }
}

struct FeatureList: HTML {
    var features: [String]

    var content: some HTML {
        ul {
            for feature in features {
                li { feature }
            }
        }
    }
}
```

## 사용 방법

`Package.swift`에 의존성을 추가하세요
```swift
.package(url: "https://github.com/sliemeobn/elementary.git", from: "0.3.2")
.product(name: "Elementary", package: "elementary")
```

[허밍버드(Hummingbird)](https://github.com/hummingbird-community/hummingbird-elementary)와의 통합
```swift
.package(url: "https://github.com/hummingbird-community/hummingbird-elementary.git", from: "0.3.0")
.product(name: "HummingbirdElementary", package: "hummingbird-elementary")
```

[Vapor](https://github.com/vapor-community/vapor-elementary)와의 통합
```swift
.package(url: "https://github.com/vapor-community/vapor-elementary.git", from: "0.1.0")
.product(name: "VaporElementary", package: "vapor-elementary")
```
## 직접 사용해보기

[Hummingbird + Tailwind 예제 앱](https://github.com/sliemeobn/elementary/tree/main/Examples/HummingbirdDemo)를 확인해보세요.

[ElementaryHTMX](https://github.com/sliemeobn/elementary-htmx) 데모는 이 [Hummingbird + HTMX 데모](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/HummingbirdDemo)를 참고하세요.

Vapor 예제는 [Vapor + HTMX 데모](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/VaporDemo)를 참고하세요.

## 가볍고 빠름

Elementary는 텍스트로 바로 렌더링하며, [Hummingbird](https://github.com/hummingbird-project/hummingbird) 또는 [Vapor](https://vapor.codes/) 서버 앱에서 생성된 HTML을 제공하도록 최적화되어 있습니다.

`HTML`을 준수하는 모든 타입은 개별적으로 렌더링할 수 있어, 테스트 또는 [htmx](https://github.com/sliemeobn/elementary-htmx)로 조각을 전송하는 데 이상적입니다.

기본 렌더링 메커니즘은 효율적인 응답 스트리밍을 위해 HTML 청크를 생성하여, 서버가 나머지 페이지를 생성하는 동안 브라우저가 페이지 로딩을 시작할 수 있게 합니다. Swift 동시성은 역압을 처리하는 데 사용되어, 큰 페이지에서도 메모리 사용량을 낮게 유지합니다.


```swift
// Stream HTML, optimized for responsiveness and back pressure-aware
try await MainPage().render(into: responseStreamWriter)
```
또는 렌더링된 HTML을 문자열로 간단히 수집할 수도 있습니다.


```swift
let html: String = div(.class("pretty")) { "Hello" }.render()
// <div class="pretty">Hello</div>

let fragment: String = FeatureList(features: ["Anything conforming to HTML can be rendered"]).render()
// <ul><li>Anything conforming to HTML can be rendered</li></ul>

// For testing purposes, there is also a formatted version
print(
    div {
        p(.class("greeting")) { "Hi mom!" }
        p { "Look how pretty." }
    }.renderFormatted()
)

// <div>
//   <p class="greeting">Hi mom!</p>
//   <p>Look how pretty.</p>
// </div>
```
Elementary는 종속성이 전혀 없으며(Foundation조차도 없고) 런타임 리플렉션이나 존재형 컨테이너를 사용하지 않습니다(코드베이스에 `any`가 단 한 번도 없습니다).

설계상 레이아웃 엔진, 반응형 상태 추적 또는 내장 CSS 스타일링이 포함되어 있지 않습니다: 단지 HTML을 렌더링할 뿐입니다.

## 깔끔하고 조합 가능함

SwiftUI에서 영감을 받은 조합 API로 HTML을 구조화하세요.


```swift
struct List: HTML {
    var items: [String]
    var importantIndex: Int

    var content: some HTML {
        // conditional rendering
        if items.isEmpty {
            p { "No items" }
        } else {
            ul {
                // list rendering
                for (index, item) in items.enumerated() {
                    // seamless composition of elements
                    ListItem(text: item, isImportant: index == importantIndex)
                }
            }
        }
    }
}

struct ListItem: HTML {
    var text: String
    var isImportant: Bool = false

    var content: some HTML {
        // conditional attributes
        li { text }
            .attributes(.class("important"), when: isImportant)
    }
}
```
## 일류 속성 처리

Elementary는 Swift의 강력한 제네릭을 활용하여 어디에 무엇이 들어가는지 아는 속성 시스템을 제공합니다. 모든 요소는 자신이 어떤 태그를 위한 것인지 알고 있습니다.

HTML에서와 같이, 속성은 "열린 태그" 바로 다음에 옵니다.


```swift
// staying close to HTML syntax really helps
div(.data("hello", value: "there")) {
    a(.href("/swift"), .target(.blank)) {
        img(.src("/swift.png"))
        span(.class("fancy")) { "Click Me" }
    }
}
```
속성은 수정자 구문을 사용하여 변경할 수도 있으며, 이를 통해 조건부 속성을 쉽게 처리할 수 있습니다.


```swift
div {
    p { "Hello" }
        .attributes(.id("maybe-fancy"))
        .attributes(.class("fancy"), when: isFancy)
}
```
`content`의 태그 유형을 노출함으로써 속성이 통과되어 올바르게 적용됩니다.


```swift
struct Button: HTML {
    var text: String

    // by exposing the HTMLTag type information...
    var content: some HTML<HTMLTag.input> {
        input(.type(.button), .value(text))
    }
}

div {
    // ... Button will know it really is an <input> element ...
    Button(text: "Hello")
        .attributes(.autofocus) // ... and pass on any attributes
}
```

합리적인 기본값으로, _class_와 _style_ 속성은 각각 공백 또는 세미콜론으로 병합됩니다. 다른 모든 속성은 기본적으로 덮어쓰여집니다.

## 원활한 비동기 지원

Elementary는 HTML 콘텐츠에서 Swift 동시성을 지원합니다. 첫 번째 바이트가 이미 브라우저로 전송되는 동안 HTML 내부에서 간단히 `await`를 사용하세요.

```swift
div {
    let text = await getMyData()
    p { "This totally works: \(text)" }
    MyComponent()
}

struct MyComponent: HTML {
    var content: some HTML {
        AsyncContent {
            "So does this: \(await getMoreData())"
        }
    }
}
```
`AsyncForEach` 요소를 사용하면 모든 `AsyncSequence`를 효율적으로 HTML로 직접 렌더링할 수 있습니다.


```swift
ul {
    // the full result never needs to be stored in memory...
    let users = try await db.users.findAll()
    // ...as each async sequence element...
    AsyncForEach(users) { user in
        // ...is immediately streamed out as HTML
        li { "\(user.name) \(user.favoriteProgrammingLanguage)" }
    }
}
```

## 환경 값

Elementary는 경량 환경 시스템을 제공하기 위해 `TaskLocal`을 활용합니다.

```swift
enum MyValues {
    // task-locals act as keys, ...
    @TaskLocal static var userName = "Anonymous"
}

struct MyComponent: HTML {
    // ... their values can be accessed ...
    @Environment(MyValues.$userName) var userName

    var content: some HTML {
        p { "Hello, \(userName)!" }
    }
}

div {
    // ... and provided in a familiar way
    MyComponent()
        .environment(Values.$userName, "Drax the Destroyer")
}
```
### 🚧 작업 진행 중 🚧

내장 속성 목록은 아직 완전하지 않지만, 추가하는 것은 매우 간단하며(외부 패키지에서도 가능합니다).

모델에 누락된 추가 속성이 있으면 자유롭게 PR을 열어주세요.

## 동기 및 기타 패키지

[Plot](https://github.com/JohnSundell/Plot), [HTMLKit](https://github.com/vapor-community/HTMLKit), 그리고 [Swim](https://github.com/robb/Swim)은 모두 유사한 작업을 수행하는 훌륭한 패키지입니다.

Elementary의 주요 동기는 이러한 경험을 만드는 것이었습니다 ([Swift Forums 게시물](https://forums.swift.org/t/elementary-a-modern-and-efficient-html-rendering-library-inspired-by-swiftui-built-for-the-web/72647)에서 더 많은 맥락 확인 가능), 하지만

- HTML 태그 이름과 관습(소문자 타입 선택 포함)에 충실할 것
- 중간 구조체를 할당하지 않고 바로 스트리밍 HTML로 전환할 것
- 제네릭을 사용해 다수의 존재형 `any` 리스트 할당을 피할 것
- 속성 목록을 콘텐츠 블록 앞에 둘 것
- _속성 계승(attribute fallthrough)_ 및 병합 제공
- 다른 패키지에 대한 의존성 제로

[Tokamak](https://github.com/TokamakUI/Tokamak)은 훌륭한 프로젝트이며 매우 영감을 줍니다. HTML을 생성할 수 있지만 주된 초점은 매우 다른 대상입니다. 확인해 보세요!

[swift-html](https://github.com/pointfreeco/swift-html)과 [swift-dom](https://github.com/tayloraswift/swift-dom)은 HTML을 잘 생성하지만, HTML 요소를 조합하는 구문이 다릅니다.

## 향후 방향

- 임베디드 Swift for wasm을 실험하고 반응형 DOM 조작을 위한 간결한 상태 추적/조정기를 구축하기



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---