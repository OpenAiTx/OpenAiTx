![icon](https://github.com/user-attachments/assets/5abf1763-b290-4f12-a661-986e58fbeaad)

![swift](https://img.shields.io/badge/Swift-5.0%2B-green)
![release](https://img.shields.io/github/v/release/brillcp/pokedexui)
![platforms](https://img.shields.io/badge/Platforms-iOS%20iPadOS%20macOS-blue)
[![spm](https://img.shields.io/badge/Swift%20Package%20Manager-compatible-green)](#swift-package-manager)
[![license](https://img.shields.io/github/license/brillcp/pokedexui)](/LICENSE)
![stars](https://img.shields.io/github/stars/brillcp/pokedexui?style=social)

# PokedexUI
PokedexUI 是一个由 [Viktor Gidlöf](https://viktorgidlof.com) 使用 **SwiftUI** 构建的现代示例应用。
它集成了 [PokeAPI](https://pokeapi.co)，使用清晰的响应式架构，通过 `async / await` 和 Swift 并发来获取和展示宝可梦数据。

<img width="360" alt="pd1" src="https://github.com/user-attachments/assets/13c2362d-4519-4457-8e8f-94c0b97ad1f9" />
<img width="360" alt="pd2" src="https://github.com/user-attachments/assets/facfadbd-da67-4de8-9e7d-ac6c4207fbee" />

# 架构 🏛

PokedexUI 实现了基于协议的 MVVM 架构，遵循 **Clean Architecture** 原则。它具备通用数据获取、SwiftData 持久化，以及使用 Swift 的 `@Observable` 宏进行响应式 UI 更新。

## 主要架构优势
- ✅ **基于协议**：支持依赖注入和便捷测试
- ✅ **通用数据流**：所有数据源统一模式  
- ✅ **存储优先**：支持离线使用及自动同步
- ✅ **基于 Actor 的并发**：线程安全的数据操作
- ✅ **清晰分层**：层之间边界明确
- ✅ **类型安全**：通过泛型实现编译时保障
- ✅ **响应式 UI**：通过 @Observable 自动更新

### SOLID 合规评分：0.92 / 1.0
- **S** 单一职责：每个组件职责聚焦
- **O** 开闭原则：通过协议扩展，无需修改即可扩展  
- **L** 里氏替换：协议遵循保证可替代性
- **I** 接口隔离：专注且内聚的协议
- **D** 依赖倒置：依赖抽象而非具体实现

## 视图层 📱

根视图 `PokedexView` 是一个通用视图，接受遵循协议的 ViewModel，支持依赖注入和测试：
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

## 视图模型层 🧾

### 面向协议设计
视图模型遵循协议，实现灵活的实现和更简便的测试：
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

### 通用数据获取
`DataFetcher` 协议提供了一种统一的以存储优先的数据加载模式：
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

### 具体实现
`PokedexViewModel` 实现了两个协议：
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

## 数据层 📦

### SwiftData 持久化
`DataStorageReader` 提供了一个基于 actor 的通用接口，用于 SwiftData 操作：
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

# 智能搜索系统 🔍

一个高性能、协议驱动的搜索实现，具备复杂的多条件过滤和实时结果功能。

## 搜索架构

搜索系统遵循相同的统一 `DataFetcher` 模式，确保数据加载一致性和离线能力：

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

## 高级过滤算法

### 多词处理与匹配
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

## 主要功能
- ✅ **实时过滤**：输入时结果即时更新
- ✅ **多词支持**：“fire dragon” 可匹配同时包含两个词的宝可梦
- ✅ **类型识别搜索**：可按类型（如“水”、“电”）或名称查找
- ✅ **重音符号不敏感**：自动处理带重音的字符
- ✅ **存储集成**：优先搜索本地 SwiftData，失败时调用 API

搜索算法确保**所有词汇均匹配**，实现精准结果，同时支持部分名称匹配和类型组合。

## 精灵加载与缓存 🎨
异步加载图片，配合智能缓存：
```swift
actor SpriteLoader {
    func loadSprite(from urlString: String) async -> UIImage? {
        // Check cache first, then network with automatic caching
    }
}
```

# 依赖 🔗
PokedexUI 使用 HTTP 框架 [Networking](https://github.com/brillcp/Networking) 来进行所有对 PokeAPI 的 API 调用。您可以在这里了解更多信息 [here](https://github.com/brillcp/Networking#readme)。它可以通过 Swift 包管理器安装：
```
dependencies: [
    .package(url: "https://github.com/brillcp/Networking.git", .upToNextMajor(from: "0.9.3"))
]
```

# 要求 ❗️
- Xcode 15及以上
- iOS 17及以上（用于 @Observable 和 SwiftData）
- Swift 5.9及以上


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---