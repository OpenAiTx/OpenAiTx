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

## Utilisation

Ajoutez la dépendance à `Package.swift`
```swift
.package(url: "https://github.com/sliemeobn/elementary.git", from: "0.3.2")
.product(name: "Elementary", package: "elementary")
```

Intégration avec [Hummingbird](https://github.com/hummingbird-community/hummingbird-elementary)
```swift
.package(url: "https://github.com/hummingbird-community/hummingbird-elementary.git", from: "0.3.0")
.product(name: "HummingbirdElementary", package: "hummingbird-elementary")
```
Intégration avec [Vapor](https://github.com/vapor-community/vapor-elementary)

```swift
.package(url: "https://github.com/vapor-community/vapor-elementary.git", from: "0.1.0")
.product(name: "VaporElementary", package: "vapor-elementary")
```

## Jouez avec

Découvrez l'[exemple d'application Hummingbird + Tailwind](https://github.com/sliemeobn/elementary/tree/main/Examples/HummingbirdDemo).

Pour une démo de [ElementaryHTMX](https://github.com/sliemeobn/elementary-htmx), consultez cette [démo Hummingbird + HTMX](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/HummingbirdDemo).

Pour un exemple Vapor, consultez la [démo Vapor + HTMX](https://github.com/sliemeobn/elementary-htmx/tree/main/Examples/VaporDemo).

## Léger et rapide

Elementary rend directement en texte, optimisé pour servir du HTML généré depuis une application serveur [Hummingbird](https://github.com/hummingbird-project/hummingbird) ou [Vapor](https://vapor.codes/).

Tout type conforme à `HTML` peut être rendu individuellement, idéal pour les tests ou pour envoyer des fragments avec [htmx](https://github.com/sliemeobn/elementary-htmx).

Le mécanisme de rendu par défaut produit des morceaux de HTML pour un streaming de réponse efficace, afin que le navigateur puisse commencer à charger une page pendant que le serveur produit encore le reste. La concurrence Swift est utilisée pour gérer la pression de retour, ce qui maintient votre empreinte mémoire basse même pour les grandes pages.

```swift
// Stream HTML, optimized for responsiveness and back pressure-aware
try await MainPage().render(into: responseStreamWriter)
```

Alternativement, vous pouvez simplement collecter le HTML rendu dans une chaîne.

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

Elementary n’a aucune dépendance (pas même Foundation) et n’utilise pas la réflexion à l’exécution ni les conteneurs existentiels (il n’y a pas un seul `any` dans la base de code).

Par conception, il ne comprend pas de moteur de mise en page, de suivi d’état réactif, ni de style CSS intégré : il se contente de rendre du HTML.

## Propre et composable

Structurez votre HTML avec une API de composition inspirée de SwiftUI.

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

## Gestion des attributs de première classe

Elementary utilise la puissance des génériques de Swift pour fournir un système d'attributs qui sait ce qui va où. Chaque élément sait pour quelle Balise il est destiné.

Comme en HTML, les attributs se placent juste après la « balise d'ouverture ».

```swift
// staying close to HTML syntax really helps
div(.data("hello", value: "there")) {
    a(.href("/swift"), .target(.blank)) {
        img(.src("/swift.png"))
        span(.class("fancy")) { "Click Me" }
    }
}
```
Les attributs peuvent également être modifiés en utilisant la syntaxe de modificateur, ce qui permet une gestion facile des attributs conditionnels.


```swift
div {
    p { "Hello" }
        .attributes(.id("maybe-fancy"))
        .attributes(.class("fancy"), when: isFancy)
}
```
  
En exposant le type de balise de `content`, les attributs seront transmis et appliqués correctement.

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

Par défaut raisonnable, les attributs _class_ et _style_ sont fusionnés (avec un espace ou un point-virgule respectivement). Tous les autres attributs sont écrasés par défaut.

## Support asynchrone transparent

Elementary prend en charge la Concurrence Swift dans le contenu HTML. Il suffit de `await` quelque chose dans votre HTML, tandis que les premiers octets sont déjà en route vers le navigateur.

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

En utilisant l'élément `AsyncForEach`, toute `AsyncSequence` peut être rendue efficacement directement en HTML.

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

## Valeurs d'environnement

Elementary utilise des `TaskLocal`s pour fournir un système d'environnement léger.

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

### 🚧 Travail en cours 🚧

La liste des attributs intégrés est loin d'être complète, mais les ajouter est vraiment simple (et peut également être fait dans des packages externes).

N'hésitez pas à ouvrir une PR avec des attributs supplémentaires manquants dans le modèle.

## Motivation et autres packages

[Plot](https://github.com/JohnSundell/Plot), [HTMLKit](https://github.com/vapor-community/HTMLKit), et [Swim](https://github.com/robb/Swim) sont tous d'excellents packages pour faire une chose similaire.

Ma principale motivation pour Elementary était de créer une expérience comme celles-ci ([post sur les forums Swift](https://forums.swift.org/t/elementary-a-modern-and-efficient-html-rendering-library-inspired-by-swiftui-built-for-the-web/72647) pour plus de contexte), mais

- rester fidèle aux noms et conventions des balises HTML (y compris le choix des types en minuscules)
- éviter d'allouer une structure intermédiaire et aller directement au streaming HTML
- utiliser des génériques pour éviter d'allouer une tonne de listes d’`any` existentiels
- avoir une liste d'attributs avant le bloc de contenu
- fournir une _propagation_ et fusion des attributs
- aucune dépendance à d'autres packages

[Tokamak](https://github.com/TokamakUI/Tokamak) est un projet génial et très inspirant. Il peut produire du HTML, mais son principal objectif est très différent. Allez voir !

[swift-html](https://github.com/pointfreeco/swift-html) et [swift-dom](https://github.com/tayloraswift/swift-dom) produiront du HTML de façon élégante, mais ils utilisent une syntaxe différente pour composer les éléments HTML.

## Directions futures

- Expérimenter avec Swift intégré pour wasm et construire un suivi d'état/reconciliateur léger pour la manipulation réactive du DOM par-dessus


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---