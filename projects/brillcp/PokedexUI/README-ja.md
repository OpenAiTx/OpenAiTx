![icon](https://github.com/user-attachments/assets/5abf1763-b290-4f12-a661-986e58fbeaad)

![swift](https://img.shields.io/badge/Swift-5.0%2B-green)
![release](https://img.shields.io/github/v/release/brillcp/pokedexui)
![platforms](https://img.shields.io/badge/Platforms-iOS%20iPadOS%20macOS-blue)
[![spm](https://img.shields.io/badge/Swift%20Package%20Manager-compatible-green)](#swift-package-manager)
[![license](https://img.shields.io/github/license/brillcp/pokedexui)](/LICENSE)
![stars](https://img.shields.io/github/stars/brillcp/pokedexui?style=social)

# PokedexUI
PokedexUIは、[Viktor Gidlöf](https://viktorgidlof.com)によって作成された**SwiftUI**を用いたモダンなサンプルアプリです。
[PokéAPI](https://pokeapi.co)と連携し、`async / await`やSwift Concurrencyを活用したクリーンでリアクティブなアーキテクチャでポケモンデータを取得・表示します。

<img width="360" alt="pd1" src="https://github.com/user-attachments/assets/13c2362d-4519-4457-8e8f-94c0b97ad1f9" />
<img width="360" alt="pd2" src="https://github.com/user-attachments/assets/facfadbd-da67-4de8-9e7d-ac6c4207fbee" />

# アーキテクチャ 🏛

PokedexUIは、**プロトコル指向MVVM**アーキテクチャを**クリーンアーキテクチャ**の原則に基づいて実装しています。ジェネリックなデータ取得、SwiftDataによる永続化、Swiftの`@Observable`マクロを使用したリアクティブなUI更新を特徴としています。

## 主要なアーキテクチャの利点
- ✅ **プロトコル指向**：依存性注入と容易なテストが可能
- ✅ **ジェネリックデータフロー**：全てのデータソースに統一されたパターン  
- ✅ **ストレージファースト**：オフライン対応、自動同期機能
- ✅ **アクター基盤の並行処理**：スレッドセーフなデータ操作
- ✅ **クリーンな分離**：レイヤー間の明確な境界
- ✅ **型安全性**：ジェネリクスによるコンパイル時保証
- ✅ **リアクティブUI**：@Observableによる自動更新

### SOLID準拠スコア：0.92 / 1.0
- **S**ingle Responsibility（単一責任）：各コンポーネントが明確な役割を持つ
- **O**pen/Closed（開放/閉鎖）：プロトコルを介して拡張可能、修正不要  
- **L**iskov Substitution（リスコフの置換原則）：プロトコル準拠で置換可能
- **I**nterface Segregation（インターフェース分離）：焦点を絞った凝集的なプロトコル
- **D**ependency Inversion（依存関係逆転）：具体的実装ではなく抽象に依存

## View層 📱

ルートの`PokedexView`は、プロトコル準拠のViewModelを受け入れるジェネリックビューであり、依存性注入とテスト可能性を可能にします：
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

## ViewModel レイヤー 🧾

### プロトコル指向設計
ViewModel はプロトコルに準拠し、柔軟な実装とテストの容易化を可能にします：
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
### 汎用データ取得
`DataFetcher` プロトコルは、ストレージ優先のデータ読み込みのための統一されたパターンを提供します：

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

### 具体的な実装
`PokedexViewModel` は両方のプロトコルを実装します：
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

## データレイヤー 📦

### SwiftData 永続化
`DataStorageReader` は SwiftData 操作のためのジェネリックなアクター基盤インターフェースを提供します：
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

# インテリジェント検索システム 🔍

高度なマルチタームフィルタリングとリアルタイム結果を備えた高性能プロトコル駆動型検索実装。

## 検索アーキテクチャ

検索システムは同じ統一された `DataFetcher` パターンに従い、一貫したデータ読み込みとオフライン機能を保証します：

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

## 高度なフィルタリングアルゴリズム

### 複数語句の処理とマッチング
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

## 主な特徴
- ✅ **リアルタイムフィルタリング**: 入力に応じて結果が即時更新されます
- ✅ **複数キーワード対応**: 「fire dragon」で両方のキーワードにマッチするポケモンを検索
- ✅ **タイプ認識検索**: タイプ（例：「みず」、「でんき」）や名前で検索可能
- ✅ **ダイアクリティカル非感知**: アクセント付き文字も自動処理
- ✅ **ストレージ連携**: ローカルのSwiftData検索とAPIフォールバック対応

検索アルゴリズムは**すべてのキーワードが一致**することを保証し、部分的な名前マッチやタイプの組み合わせをサポートします。

## スプライトの読み込みとキャッシュ 🎨
インテリジェントなキャッシュを備えた非同期画像読み込み：
```swift
actor SpriteLoader {
    func loadSprite(from urlString: String) async -> UIImage? {
        // Check cache first, then network with automatic caching
    }
}
```

# 依存関係 🔗
PokedexUI は PokeAPI へのすべての API コールに HTTP フレームワーク [Networking](https://github.com/brillcp/Networking) を使用しています。詳細は[こちら](https://github.com/brillcp/Networking#readme)でご覧いただけます。Swift Package Manager を通じてインストール可能です：
```
dependencies: [
    .package(url: "https://github.com/brillcp/Networking.git", .upToNextMajor(from: "0.9.3"))
]
```

# 要件 ❗️
- Xcode 15以上
- iOS 17以上（@Observable と SwiftData 用）
- Swift 5.9以上


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---