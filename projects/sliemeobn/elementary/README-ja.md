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

## 使い方

依存関係を `Package.swift` に追加してください
```swift
.package(url: "https://github.com/sliemeobn/elementary.git", from: "0.3.2")
.product(name: "Elementary", package: "elementary")
```

[Hummingbird](https://github.com/hummingbird-community/hummingbird-elementary)との統合
```swift
.package(url: "https://github.com/hummingbird-community/hummingbird-elementary.git", from: "0.3.0")
.product(name: "HummingbirdElementary", package: "hummingbird-elementary")
```

[Vapor](https://github.com/vapor-community/vapor-elementary)との統合
```swift
.package(url: "https://github.com/vapor-community/vapor-elementary.git", from: "0.1.0")
.product(name: "VaporElementary", package: "vapor-elementary")
```

## 遊んでみる

[Hummingbird + Tailwind のサンプルアプリ](https://github.com/sliemeobn/elementary/tree/main/Examples/HummingbirdDemo)をチェックしてください。

[ElementaryHTMX](https://github.com/sliemeobn/elementary-htmx)のデモについては、この[Hummingbird + HTMX デモ](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/HummingbirdDemo)を参照してください。

Vaporの例については、[Vapor + HTMX デモ](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/VaporDemo)をご覧ください。

## 軽量かつ高速

Elementaryはテキストに直接レンダリングし、[Hummingbird](https://github.com/hummingbird-project/hummingbird)や[Vapor](https://vapor.codes/)のサーバーアプリから生成されたHTMLを提供するのに最適化されています。

`HTML`に準拠した任意の型は個別にレンダリング可能で、テストや[htmx](https://github.com/sliemeobn/elementary-htmx)でフラグメントを送信するのに理想的です。

デフォルトのレンダリング機構は効率的なレスポンスストリーミングのためにHTMLのチャンクを生成し、サーバーが残りのページを生成している間にブラウザがページの読み込みを開始できます。Swiftの並行処理を使用してバックプレッシャーを管理するため、大きなページでもメモリ使用量を低く抑えられます。

```swift
// Stream HTML, optimized for responsiveness and back pressure-aware
try await MainPage().render(into: responseStreamWriter)
```
または、レンダリングされたHTMLを文字列として単純に収集することもできます。


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

Elementaryは依存関係がゼロです（Foundationさえも使用していません）し、ランタイムリフレクションや存在コンテナも使用していません（コードベース内に`any`は一切ありません）。

設計上、レイアウトエンジン、リアクティブな状態追跡、組み込みのCSSスタイリングは備えていません：単にHTMLをレンダリングするだけです。

## クリーンで合成可能

SwiftUIに触発された合成APIでHTMLを構築しましょう。

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

## ファーストクラス属性の取り扱い

ElementaryはSwiftの強力なジェネリクスを活用して、属性がどこに配置されるべきかを把握する属性システムを提供します。すべての要素はどのタグに対応しているかを知っています。

HTMLと同様に、属性は「開始タグ」の直後に配置されます。

```swift
// staying close to HTML syntax really helps
div(.data("hello", value: "there")) {
    a(.href("/swift"), .target(.blank)) {
        img(.src("/swift.png"))
        span(.class("fancy")) { "Click Me" }
    }
}
```

属性は修飾子構文を使用して変更することもでき、これにより条件付き属性の簡単な処理が可能になります。

```swift
div {
    p { "Hello" }
        .attributes(.id("maybe-fancy"))
        .attributes(.class("fancy"), when: isFancy)
}
```
`content` のタグタイプを公開することで、属性が透過して正しく適用されます。


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

合理的なデフォルトとして、_class_ と _style_ 属性はそれぞれ空白またはセミコロンで結合されます。その他の属性はデフォルトで上書きされます。

## シームレスな非同期サポート

Elementary は HTML コンテンツ内で Swift Concurrency をサポートします。最初のバイトがすでにブラウザに送信されている間に、単に HTML 内で何かを `await` してください。

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
`AsyncForEach`要素を使用することで、任意の`AsyncSequence`を効率的にHTMLへ直接レンダリングできます。


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

## 環境値

Elementaryは軽量な環境システムを提供するために`TaskLocal`を利用します。

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

### 🚧 作業中 🚧

組み込み属性のリストはまだ不完全ですが、追加は非常に簡単です（外部パッケージでも可能です）。

モデルに欠けている属性があれば、遠慮なくPRを送ってください。

## 動機と他のパッケージ

[Plot](https://github.com/JohnSundell/Plot)、[HTMLKit](https://github.com/vapor-community/HTMLKit)、および[Swim](https://github.com/robb/Swim)は、同様のことを行う優れたパッケージです。

Elementaryの主な動機は、これらのような体験を作ることでした（詳細は[Swift Forumsの投稿](https://forums.swift.org/t/elementary-a-modern-and-efficient-html-rendering-library-inspired-by-swiftui-built-for-the-web/72647)を参照）、しかし

- HTMLタグ名と慣習（小文字の型選択を含む）に忠実であること
- 中間構造の割り当てを避け、直接HTMLのストリーミングに行くこと
- ジェネリクスを使い、大量の存在型`any`のリスト割り当てを避けること
- 属性のリストをコンテンツブロックの前に置くこと
- _属性のフォールスルー_ とマージを提供すること
- 他のパッケージへの依存をゼロにすること

[Tokamak](https://github.com/TokamakUI/Tokamak)は素晴らしいプロジェクトで非常に刺激的です。HTMLを生成できますが、主な焦点はまったく異なるものにあります。ぜひチェックしてください！

[swift-html](https://github.com/pointfreeco/swift-html) と [swift-dom](https://github.com/tayloraswift/swift-dom)はHTMLをきれいに生成しますが、HTML要素の構成に異なる構文を使用しています。

## 今後の方向性

- wasm用の埋め込みswiftを試し、リアクティブDOM操作のための軽量な状態追跡／調整機構を構築すること


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---