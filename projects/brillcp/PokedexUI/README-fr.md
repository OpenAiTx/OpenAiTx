![icon](https://github.com/user-attachments/assets/5abf1763-b290-4f12-a661-986e58fbeaad)

![swift](https://img.shields.io/badge/Swift-5.0%2B-green)
![release](https://img.shields.io/github/v/release/brillcp/pokedexui)
![platforms](https://img.shields.io/badge/Platforms-iOS%20iPadOS%20macOS-blue)
[![spm](https://img.shields.io/badge/Swift%20Package%20Manager-compatible-green)](#swift-package-manager)
[![license](https://img.shields.io/github/license/brillcp/pokedexui)](/LICENSE)
![stars](https://img.shields.io/github/stars/brillcp/pokedexui?style=social)

# PokedexUI
PokedexUI est une application d’exemple moderne construite avec **SwiftUI** par [Viktor Gidlöf](https://viktorgidlof.com).
Elle s’intègre avec la [PokeAPI](https://pokeapi.co) pour récupérer et afficher les données des Pokémon en utilisant une architecture propre et réactive avec `async / await` et Swift Concurrency.

<img width="360" alt="pd1" src="https://github.com/user-attachments/assets/13c2362d-4519-4457-8e8f-94c0b97ad1f9" />
<img width="360" alt="pd2" src="https://github.com/user-attachments/assets/facfadbd-da67-4de8-9e7d-ac6c4207fbee" />

# Architecture 🏛

PokedexUI implémente une architecture **MVVM orientée protocole** avec les principes de **Clean Architecture**. Elle propose une récupération générique des données, une persistance SwiftData et des mises à jour réactives de l’interface utilisateur grâce au macro `@Observable` de Swift.

## Principaux avantages architecturaux
- ✅ **Orienté protocole** : Permet l’injection de dépendances et des tests faciles
- ✅ **Flux de données générique** : Modèle unifié pour toutes les sources de données  
- ✅ **Stockage prioritaire** : Fonctionne hors ligne avec synchronisation automatique
- ✅ **Concurrence basée sur les acteurs** : Opérations de données thread-safe
- ✅ **Séparation claire** : Frontières nettes entre les couches
- ✅ **Sécurité de type** : Garanties à la compilation via les génériques
- ✅ **UI réactive** : Mises à jour automatiques via @Observable

### Score de conformité SOLID : 0,92 / 1,0
- **S**eule Responsabilité : Chaque composant a une fonction ciblée
- **O**uvert/Fermé : Extensible via des protocoles sans modification  
- **L**iskov Substitution : La conformité aux protocoles garantit la substituabilité
- **I**nterface Segregation : Protocoles ciblés et cohérents
- **D**épendance Inversion : Dépend des abstractions, pas des concrétions

## Couche Vue 📱

La vue racine `PokedexView` est une vue générique qui accepte des ViewModels conformes à un protocole, permettant l’injection de dépendances et la testabilité :
```swift
struct PokedexView<
    PokedexViewModel: PokedexViewModelProtocol,
    ItemListViewModel: ItemListViewModelProtocol,
>: View {
    @State var viewModel: PokedexViewModel
    let itemListViewModel: ItemListViewModel
    
    var body: some View {
        TabView(selection: $viewModel.selectedTab) {
            Tab(Tabs.pokedex.title, systemImage: viewModel.grid.icon, value: Tabs.pokedex) {
                PokedexContent(viewModel: $viewModel)
            }
            // Additional tabs...
        }
        .applyPokedexConfiguration(viewModel: viewModel)
    }
}
```

## Couche ViewModel 🧾

### Conception Orientée Protocole
Les ViewModels respectent des protocoles, permettant des implémentations flexibles et des tests facilités :
```swift
protocol PokedexViewModelProtocol {
    var pokemon: [PokemonViewModel] { get }
    var isLoading: Bool { get }
    var selectedTab: Tabs { get set }
    var grid: GridLayout { get set }
    
    func requestPokemon() async
    func sort(by type: SortType)
}
```

### Récupération Générique de Données
Le protocole `DataFetcher` offre un modèle unifié pour le chargement des données en privilégiant le stockage :
```swift
protocol DataFetcher {
    associatedtype StoredData
    associatedtype APIData  
    associatedtype ViewModel
    
    func fetchStoredData() async throws -> [StoredData]
    func fetchAPIData() async throws -> [APIData]
    func storeData(_ data: [StoredData]) async throws
    func transformToViewModel(_ data: StoredData) -> ViewModel
    func transformForStorage(_ data: APIData) -> StoredData
}

extension DataFetcher {
    func fetchDataFromStorageOrAPI() async -> [ViewModel] {
        // Storage-first approach with API fallback
        guard let localData = await fetchStoredDataSafely(), !localData.isEmpty else {
            return await fetchDataFromAPI()
        }
        return localData.map(transformToViewModel)
    }
}
```

### Implémentation concrète
Le `PokedexViewModel` implémente les deux protocoles :
```swift
@Observable
final class PokedexViewModel: PokedexViewModelProtocol, DataFetcher {
    private let pokemonService: PokemonServiceProtocol
    private let storageReader: DataStorageReader
    
    var pokemon: [PokemonViewModel] = []
    var isLoading: Bool = false
    
    func requestPokemon() async {
        guard !isLoading else { return }
        pokemon = await withLoadingState {
            await fetchDataFromStorageOrAPI()
        }
    }
}
```

## Couche de données 📦

### Persistance SwiftData
`DataStorageReader` fournit une interface générique basée sur un acteur pour les opérations SwiftData :
```swift
@ModelActor
actor DataStorageReader {
    func store<M: PersistentModel>(_ models: [M]) throws {
        models.forEach { modelContext.insert($0) }
        try modelContext.save()
    }
    
    func fetch<M: PersistentModel>(
        sortBy: SortDescriptor<M>
    ) throws -> [M] {
        let descriptor = FetchDescriptor<M>(sortBy: [sortBy])
        return try modelContext.fetch(descriptor)
    }
}
```

# Système de Recherche Intelligent 🔍

Une implémentation de recherche haute performance, pilotée par protocole, avec un filtrage multi-termes sophistiqué et des résultats en temps réel.

## Architecture de Recherche

Le système de recherche suit le même modèle unifié `DataFetcher`, garantissant un chargement des données cohérent et des capacités hors ligne :

```swift
@Observable
final class SearchViewModel: SearchViewModelProtocol, DataFetcher {
    var pokemon: [PokemonViewModel] = []
    var filtered: [PokemonViewModel] = []
    var query: String = ""
    
    func loadData() async {
        pokemon = await fetchDataFromStorageOrAPI() // Uses unified data fetching
    }
}
```

## Algorithme de Filtrage Avancé

### Traitement et Correspondance Multi-Termes
```swift
func updateFilteredPokemon() {
    let queryTerms = query
        .split(whereSeparator: \.isWhitespace)  // Split on whitespace
        .map { $0.normalize }                   // Diacritic-insensitive
        .filter { !$0.isEmpty }
    
    filtered = pokemon.filter { pokemonVM in
        let name = pokemonVM.name.normalize
        let types = pokemonVM.types.components(separatedBy: ",").map { $0.normalize }
        
        return queryTerms.allSatisfy { term in
            name.contains(term) || types.contains(where: { $0.contains(term) })
        }
    }
}
```

## Fonctionnalités clés
- ✅ **Filtrage en temps réel** : Les résultats se mettent à jour instantanément pendant la saisie
- ✅ **Support multi-termes** : "dragon de feu" trouve les Pokémon correspondant aux deux termes
- ✅ **Recherche sensible au type** : Trouvez par type (ex. "eau", "électrique") ou par nom
- ✅ **Insensible aux diacritiques** : Gère automatiquement les caractères accentués
- ✅ **Intégration de stockage** : Recherche dans SwiftData local avec repli sur API

L'algorithme de recherche garantit que **tous les termes doivent correspondre** pour des résultats précis tout en supportant la correspondance partielle des noms et les combinaisons de types.

## Chargement et mise en cache des sprites 🎨
Chargement asynchrone des images avec mise en cache intelligente :
```swift
actor SpriteLoader {
    func loadSprite(from urlString: String) async -> UIImage? {
        // Check cache first, then network with automatic caching
    }
}
```

# Dépendances 🔗
PokedexUI utilise le framework HTTP [Networking](https://github.com/brillcp/Networking) pour tous les appels API vers le PokeAPI. Vous pouvez en savoir plus à ce sujet [ici](https://github.com/brillcp/Networking#readme). Il peut être installé via Swift Package Manager :
```
dependencies: [
    .package(url: "https://github.com/brillcp/Networking.git", .upToNextMajor(from: "0.9.3"))
]
```

# Exigences ❗️
- Xcode 15+
- iOS 17+ (pour @Observable et SwiftData)
- Swift 5.9+


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---