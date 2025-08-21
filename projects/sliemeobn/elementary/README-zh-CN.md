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

## 使用方法

将依赖添加到 `Package.swift` 中
```swift
.package(url: "https://github.com/sliemeobn/elementary.git", from: "0.3.2")
.product(name: "Elementary", package: "elementary")
```

与 [Hummingbird](https://github.com/hummingbird-community/hummingbird-elementary) 的集成
```swift
.package(url: "https://github.com/hummingbird-community/hummingbird-elementary.git", from: "0.3.0")
.product(name: "HummingbirdElementary", package: "hummingbird-elementary")
```

与 [Vapor](https://github.com/vapor-community/vapor-elementary) 集成
```swift
.package(url: "https://github.com/vapor-community/vapor-elementary.git", from: "0.1.0")
.product(name: "VaporElementary", package: "vapor-elementary")
```
## 试用一下

查看 [Hummingbird + Tailwind 示例应用](https://github.com/sliemeobn/elementary/tree/main/Examples/HummingbirdDemo)。

想看 [ElementaryHTMX](https://github.com/sliemeobn/elementary-htmx) 的演示，请参见此 [Hummingbird + HTMX 演示](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/HummingbirdDemo)。

想看 Vapor 示例，请查看 [Vapor + HTMX 演示](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/VaporDemo)。

## 轻量且快速

Elementary 直接渲染为文本，优化用于从 [Hummingbird](https://github.com/hummingbird-project/hummingbird) 或 [Vapor](https://vapor.codes/) 服务器应用提供生成的 HTML。

任何符合 `HTML` 协议的类型都可以单独渲染，适合测试或通过 [htmx](https://github.com/sliemeobn/elementary-htmx) 发送片段。

默认的渲染机制生成 HTML 块以实现高效的响应流式传输，因此浏览器可以在服务器仍在生成剩余内容时开始加载页面。Swift 并发用于处理背压，即使是大型页面也能保持较低的内存占用。


```swift
// Stream HTML, optimized for responsiveness and back pressure-aware
try await MainPage().render(into: responseStreamWriter)
```
或者，您也可以将渲染后的 HTML 简单地收集到一个字符串中。


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

Elementary 没有任何依赖（甚至不依赖 Foundation），也不使用运行时反射或存在性容器（代码库中没有一个 `any`）。

设计上，它不包含布局引擎、响应式状态跟踪或内置的 CSS 样式：它仅渲染 HTML。

## 干净且可组合

使用受 SwiftUI 启发的组合 API 结构化你的 HTML。

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

## 一等属性处理

Elementary 利用 Swift 强大的泛型功能提供了一个属性系统，能够明确知道属性应该放在哪里。每个元素都知道它对应的是哪个标签。

和 HTML 一样，属性紧跟在“开始标签”之后。

```swift
// staying close to HTML syntax really helps
div(.data("hello", value: "there")) {
    a(.href("/swift"), .target(.blank)) {
        img(.src("/swift.png"))
        span(.class("fancy")) { "Click Me" }
    }
}
```

属性也可以通过使用修饰符语法来更改，这允许轻松处理条件属性。

```swift
div {
    p { "Hello" }
        .attributes(.id("maybe-fancy"))
        .attributes(.class("fancy"), when: isFancy)
}
```
通过公开 `content` 的标签类型，属性将正确传递并应用。


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
作为一个合理的默认设置，_class_ 和 _style_ 属性会被合并（分别用空格或分号分隔）。所有其他属性默认会被覆盖。

## 无缝异步支持

Elementary 支持 HTML 内容中的 Swift 并发。只需在你的 HTML 内部使用 `await`，同时首字节已经开始传输到浏览器。


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
通过使用 `AsyncForEach` 元素，任何 `AsyncSequence` 都可以高效地直接渲染为 HTML。


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

## 环境变量

Elementary 使用 `TaskLocal` 来提供轻量级的环境系统。

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

### 🚧 进行中 🚧

内置属性列表远未完整，但添加它们非常简单（也可以在外部包中完成）。

欢迎提交包含模型中缺失的额外属性的PR。

## 动机及其他包

[Plot](https://github.com/JohnSundell/Plot)、[HTMLKit](https://github.com/vapor-community/HTMLKit) 和 [Swim](https://github.com/robb/Swim) 都是做类似事情的优秀包。

我创建 Elementary 的主要动机是打造类似体验（更多背景见 [Swift 论坛帖子](https://forums.swift.org/t/elementary-a-modern-and-efficient-html-rendering-library-inspired-by-swiftui-built-for-the-web/72647)），但

- 保持 HTML 标签名和约定的真实性（包括选择小写类型）
- 避免分配中间结构，直接流式输出 HTML
- 使用泛型避免分配大量存在性 `any` 列表
- 属性列表放在内容块之前
- 提供 _属性透传_ 和合并
- 零依赖其他包

[Tokamak](https://github.com/TokamakUI/Tokamak) 是一个很棒且启发性的项目。它可以生成 HTML，但主要关注点非常不同。去看看吧！

[swift-html](https://github.com/pointfreeco/swift-html) 和 [swift-dom](https://github.com/tayloraswift/swift-dom) 都能很好地生成 HTML，但它们使用不同的语法来组合 HTML 元素。

## 未来方向

- 尝试为 wasm 嵌入 swift，并构建一个精简的状态跟踪/调和器，实现响应式 DOM 操作


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---