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

## Úsalo

Agrega la dependencia a `Package.swift`
```swift
.package(url: "https://github.com/sliemeobn/elementary.git", from: "0.3.2")
.product(name: "Elementary", package: "elementary")
```

Integración con [Hummingbird](https://github.com/hummingbird-community/hummingbird-elementary)
```swift
.package(url: "https://github.com/hummingbird-community/hummingbird-elementary.git", from: "0.3.0")
.product(name: "HummingbirdElementary", package: "hummingbird-elementary")
```

Integración con [Vapor](https://github.com/vapor-community/vapor-elementary)
```swift
.package(url: "https://github.com/vapor-community/vapor-elementary.git", from: "0.1.0")
.product(name: "VaporElementary", package: "vapor-elementary")
```

## Juega con ello

Consulta la [aplicación de ejemplo Hummingbird + Tailwind](https://github.com/sliemeobn/elementary/tree/main/Examples/HummingbirdDemo).

Para una demostración de [ElementaryHTMX](https://github.com/sliemeobn/elementary-htmx), mira esta [demostración Hummingbird + HTMX](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/HummingbirdDemo).

Para un ejemplo con Vapor, consulta la [demostración Vapor + HTMX](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/VaporDemo).

## Ligero y rápido

Elementary renderiza directamente a texto, optimizado para servir HTML generado desde una aplicación servidor [Hummingbird](https://github.com/hummingbird-project/hummingbird) o [Vapor](https://vapor.codes/).

Cualquier tipo que conforme a `HTML` puede renderizarse individualmente, ideal para pruebas o para enviar fragmentos con [htmx](https://github.com/sliemeobn/elementary-htmx).

El mecanismo de renderizado por defecto produce fragmentos de HTML para una transmisión eficiente de la respuesta, de modo que el navegador puede comenzar a cargar una página mientras el servidor sigue produciendo el resto. Se usa la concurrencia de Swift para manejar la presión de retorno, por lo que tu uso de memoria se mantiene bajo incluso para páginas grandes.

```swift
// Stream HTML, optimized for responsiveness and back pressure-aware
try await MainPage().render(into: responseStreamWriter)
```

Alternativamente, puedes simplemente recoger el HTML renderizado en una cadena.

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
Elementary no tiene dependencias (ni siquiera Foundation) y no utiliza reflexión en tiempo de ejecución ni contenedores existenciales (no hay ni un solo `any` en la base de código).

Por diseño, no incluye un motor de diseño, seguimiento reactivo del estado ni estilos CSS incorporados: simplemente renderiza HTML.

## Limpio y componible

Estructura tu HTML con una API de composición inspirada en SwiftUI.


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

## Manejo de atributos de primera clase

Elementary utiliza los potentes genéricos de Swift para proporcionar un sistema de atributos que sabe qué va dónde. Cada elemento sabe para qué etiqueta es.

Como en HTML, los atributos van justo después de la "etiqueta de apertura".

```swift
// staying close to HTML syntax really helps
div(.data("hello", value: "there")) {
    a(.href("/swift"), .target(.blank)) {
        img(.src("/swift.png"))
        span(.class("fancy")) { "Click Me" }
    }
}
```
Los atributos también pueden modificarse utilizando la sintaxis de modificador, lo que permite un manejo sencillo de atributos condicionales.


```swift
div {
    p { "Hello" }
        .attributes(.id("maybe-fancy"))
        .attributes(.class("fancy"), when: isFancy)
}
```
Al exponer el tipo de etiqueta de `content`, los atributos se filtrarán y aplicarán correctamente.


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

Como valor predeterminado sensato, los atributos _class_ y _style_ se combinan (con un espacio en blanco o punto y coma respectivamente). Todos los demás atributos se sobrescriben por defecto.

## Soporte asincrónico sin interrupciones

Elementary soporta Swift Concurrency en contenido HTML. Simplemente `await` algo dentro de tu HTML, mientras los primeros bytes ya están en camino hacia el navegador.

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

Al usar el elemento `AsyncForEach`, cualquier `AsyncSequence` puede renderizarse eficientemente directamente en HTML.

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

## Valores de entorno

Elementary utiliza `TaskLocal`s para proporcionar un sistema de entorno liviano.

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

### 🚧 Trabajo en progreso 🚧

La lista de atributos incorporados está lejos de estar completa, pero agregarlos es realmente simple (y también se puede hacer en paquetes externos).

Siéntete libre de abrir un PR con atributos adicionales que falten en el modelo.

## Motivación y otros paquetes

[Plot](https://github.com/JohnSundell/Plot), [HTMLKit](https://github.com/vapor-community/HTMLKit) y [Swim](https://github.com/robb/Swim) son todos paquetes excelentes para hacer algo similar.

Mi principal motivación para Elementary fue crear una experiencia como estas ([publicación en Swift Forums](https://forums.swift.org/t/elementary-a-modern-and-efficient-html-rendering-library-inspired-by-swiftui-built-for-the-web/72647) para más contexto), pero

- mantenernos fieles a los nombres y convenciones de etiquetas HTML (incluida la elección de tipos en minúsculas)
- evitar asignar una estructura intermedia e ir directamente a transmitir HTML
- usar genéricos para evitar asignar muchas listas de `any`s existenciales
- tener una lista de atributos antes del bloque de contenido
- proporcionar _atributo paso a través_ y fusión
- cero dependencias de otros paquetes

[Tokamak](https://github.com/TokamakUI/Tokamak) es un proyecto impresionante y muy inspirador. Puede producir HTML, pero su enfoque principal es en una bestia muy diferente. ¡Échale un vistazo!

[swift-html](https://github.com/pointfreeco/swift-html) y [swift-dom](https://github.com/tayloraswift/swift-dom) producen HTML muy bien, pero usan una sintaxis diferente para componer elementos HTML.

## Direcciones futuras

- Experimentar con swift embebido para wasm y construir un seguimiento de estado/reconciliador ligero para manipulación reactiva del DOM encima


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---