![icon](https://github.com/user-attachments/assets/5abf1763-b290-4f12-a661-986e58fbeaad)

![swift](https://img.shields.io/badge/Swift-5.0%2B-green)
![release](https://img.shields.io/github/v/release/brillcp/pokedexui)
![platforms](https://img.shields.io/badge/Platforms-iOS%20iPadOS%20macOS-blue)
[![spm](https://img.shields.io/badge/Swift%20Package%20Manager-compatible-green)](#swift-package-manager)
[![license](https://img.shields.io/github/license/brillcp/pokedexui)](/LICENSE)
![stars](https://img.shields.io/github/stars/brillcp/pokedexui?style=social)

# PokedexUI
PokedexUI es una aplicación de ejemplo moderna construida con **SwiftUI** por [Viktor Gidlöf](https://viktorgidlof.com).
Se integra con la [PokeAPI](https://pokeapi.co) para obtener y mostrar datos de Pokémon usando una arquitectura limpia y reactiva con `async / await` y Swift Concurrency.

<img width="360" alt="pd1" src="https://github.com/user-attachments/assets/13c2362d-4519-4457-8e8f-94c0b97ad1f9" />
<img width="360" alt="pd2" src="https://github.com/user-attachments/assets/facfadbd-da67-4de8-9e7d-ac6c4207fbee" />

# Arquitectura 🏛

PokedexUI implementa una arquitectura **MVVM Orientada a Protocolos** con principios de **Arquitectura Limpia**. Cuenta con obtención genérica de datos, persistencia con SwiftData y actualizaciones reactivas de UI usando el macro `@Observable` de Swift.

## Beneficios Clave de la Arquitectura
- ✅ **Orientada a Protocolos**: Permite inyección de dependencias y pruebas fáciles
- ✅ **Flujo Genérico de Datos**: Patrón unificado para todas las fuentes de datos  
- ✅ **Almacenamiento Primero**: Capacidad offline con sincronización automática
- ✅ **Concurrencia Basada en Actores**: Operaciones de datos seguras en hilos
- ✅ **Separación Limpia**: Límites claros entre capas
- ✅ **Seguridad de Tipos**: Garantías en tiempo de compilación mediante genéricos
- ✅ **UI Reactiva**: Actualizaciones automáticas vía @Observable

### Puntaje de Cumplimiento SOLID: 0.92 / 1.0
- **S**olo Responsabilidad: Cada componente tiene un propósito enfocado
- **A**berto/Cerrado: Extensible vía protocolos sin modificar  
- **S**ustitución de Liskov: La conformidad con protocolos asegura sustituibilidad
- **S**egregación de Interfaces: Protocolos enfocados y cohesionados
- **I**nversión de Dependencias: Depende de abstracciones, no concreciones

## Capa de Vista 📱

La vista raíz `PokedexView` es una vista genérica que acepta ViewModels conformes a protocolos, habilitando inyección de dependencias y capacidad de prueba:
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

## Capa ViewModel 🧾

### Diseño Orientado a Protocolos
Los ViewModels cumplen con protocolos, lo que permite implementaciones flexibles y pruebas más fáciles:
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

### Obtención Genérica de Datos
El protocolo `DataFetcher` ofrece un patrón unificado para la carga de datos con prioridad de almacenamiento:
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

### Implementación Concreta
El `PokedexViewModel` implementa ambos protocolos:
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

## Capa de Datos 📦

### Persistencia SwiftData
`DataStorageReader` ofrece una interfaz genérica basada en actores para operaciones SwiftData:
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

# Sistema de Búsqueda Inteligente 🔍

Una implementación de búsqueda de alto rendimiento, basada en protocolos, con filtrado sofisticado de múltiples términos y resultados en tiempo real.

## Arquitectura de Búsqueda

El sistema de búsqueda sigue el mismo patrón unificado `DataFetcher`, asegurando una carga de datos consistente y capacidades sin conexión:

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

## Algoritmo de Filtrado Avanzado

### Procesamiento y Coincidencia de Múltiples Términos
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

## Características clave
- ✅ **Filtrado en tiempo real**: Los resultados se actualizan al instante mientras escribes
- ✅ **Soporte para múltiples términos**: "dragón de fuego" encuentra Pokémon que coinciden con ambos términos
- ✅ **Búsqueda consciente del tipo**: Busca por tipo (p. ej., "agua", "eléctrico") o por nombre
- ✅ **Insensible a diacríticos**: Maneja automáticamente caracteres acentuados
- ✅ **Integración de almacenamiento**: Busca en SwiftData local con respaldo de API

El algoritmo de búsqueda asegura que **todos los términos deben coincidir** para resultados precisos mientras soporta coincidencias parciales de nombres y combinaciones de tipos.

## Carga y caché de sprites 🎨
Carga asíncrona de imágenes con caché inteligente:
```swift
actor SpriteLoader {
    func loadSprite(from urlString: String) async -> UIImage? {
        // Check cache first, then network with automatic caching
    }
}
```

# Dependencias 🔗
PokedexUI utiliza el framework HTTP [Networking](https://github.com/brillcp/Networking) para todas las llamadas API a la PokeAPI. Puedes leer más sobre esto [aquí](https://github.com/brillcp/Networking#readme). Se puede instalar a través de Swift Package Manager:
```
dependencies: [
    .package(url: "https://github.com/brillcp/Networking.git", .upToNextMajor(from: "0.9.3"))
]
```

# Requisitos ❗️
- Xcode 15+
- iOS 17+ (para @Observable y SwiftData)
- Swift 5.9+


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---