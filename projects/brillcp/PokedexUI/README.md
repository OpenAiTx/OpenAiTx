![icon](https://github.com/user-attachments/assets/5abf1763-b290-4f12-a661-986e58fbeaad)

![swift](https://img.shields.io/badge/Swift-5.0%2B-green)
![release](https://img.shields.io/github/v/release/brillcp/pokedexui)
![platforms](https://img.shields.io/badge/Platforms-iOS%20iPadOS%20macOS-blue)
[![spm](https://img.shields.io/badge/Swift%20Package%20Manager-compatible-green)](#swift-package-manager)
[![license](https://img.shields.io/github/license/brillcp/pokedexui)](/LICENSE)
![stars](https://img.shields.io/github/stars/brillcp/pokedexui?style=social)

# PokedexUI
PokedexUI is a modern example app built with **SwiftUI** by [Viktor Gidlöf](https://viktorgidlof.com).
It integrates with the [PokeAPI](https://pokeapi.co) to fetch and display Pokémon data using a clean, reactive architecture using `async / await` and Swift Concurrency.

<img width="360" alt="pd1" src="https://github.com/user-attachments/assets/13c2362d-4519-4457-8e8f-94c0b97ad1f9" />
<img width="360" alt="pd2" src="https://github.com/user-attachments/assets/facfadbd-da67-4de8-9e7d-ac6c4207fbee" />

# Architecture 🏛

PokedexUI implements a **Protocol-Oriented MVVM** architecture with **Clean Architecture** principles. It features generic data fetching, SwiftData persistence, and reactive UI updates using Swift's `@Observable` macro.

## Key Architectural Benefits
- ✅ **Protocol-Oriented**: Enables dependency injection and easy testing
- ✅ **Generic Data Flow**: Unified pattern for all data sources  
- ✅ **Storage-First**: Offline-capable with automatic sync
- ✅ **Actor-Based Concurrency**: Thread-safe data operations
- ✅ **Clean Separation**: Clear boundaries between layers
- ✅ **Type Safety**: Compile-time guarantees via generics
- ✅ **Reactive UI**: Automatic updates via @Observable

### SOLID Compliance Score: 0.92 / 1.0
- **S**ingle Responsibility: Each component has a focused purpose
- **O**pen/Closed: Extensible via protocols without modification  
- **L**iskov Substitution: Protocol conformance ensures substitutability
- **I**nterface Segregation: Focused, cohesive protocols
- **D**ependency Inversion: Depends on abstractions, not concretions

## View Layer 📱

The root `PokedexView` is a generic view that accepts protocol-conforming ViewModels, enabling dependency injection and testability:
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

## ViewModel Layer 🧾

### Protocol-Oriented Design
ViewModels conform to protocols, enabling flexible implementations and easier testing:
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

### Generic Data Fetching
The `DataFetcher` protocol provides a unified pattern for storage-first data loading:
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

### Concrete Implementation
The `PokedexViewModel` implements both protocols:
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

## Data Layer 📦

### SwiftData Persistence
`DataStorageReader` provides a generic actor-based interface for SwiftData operations:
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

# Intelligent Search System 🔍

A high-performance, protocol-driven search implementation with sophisticated multi-term filtering and real-time results.

## Search Architecture

The search system follows the same unified `DataFetcher` pattern, ensuring consistent data loading and offline capabilities:

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

## Advanced Filtering Algorithm

### Multi-Term Processing & Matching
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

## Key Features
- ✅ **Real-time Filtering**: Results update instantly as you type
- ✅ **Multi-term Support**: "fire dragon" finds Pokémon matching both terms
- ✅ **Type-aware Search**: Find by type (e.g., "water", "electric") or name
- ✅ **Diacritic Insensitive**: Handles accented characters automatically
- ✅ **Storage Integration**: Searches local SwiftData with API fallback

The search algorithm ensures **all terms must match** for precise results while supporting partial name matching and type combinations.

## Sprite Loading & Caching 🎨
Asynchronous image loading with intelligent caching:
```swift
actor SpriteLoader {
    func loadSprite(from urlString: String) async -> UIImage? {
        // Check cache first, then network with automatic caching
    }
}
```

# Dependencies 🔗
PokedexUI uses the HTTP framework [Networking](https://github.com/brillcp/Networking) for all the API calls to the PokeAPI. You can read more about that [here](https://github.com/brillcp/Networking#readme). It can be installed through Swift Package Manager:
```
dependencies: [
    .package(url: "https://github.com/brillcp/Networking.git", .upToNextMajor(from: "0.9.3"))
]
```

# Requirements ❗️
- Xcode 15+
- iOS 17+ (for @Observable and SwiftData)
- Swift 5.9+
