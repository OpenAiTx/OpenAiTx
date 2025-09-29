![icon](https://github.com/user-attachments/assets/5abf1763-b290-4f12-a661-986e58fbeaad)

![swift](https://img.shields.io/badge/Swift-5.0%2B-green)
![release](https://img.shields.io/github/v/release/brillcp/pokedexui)
![platforms](https://img.shields.io/badge/Platforms-iOS%20iPadOS%20macOS-blue)
[![spm](https://img.shields.io/badge/Swift%20Package%20Manager-compatible-green)](#swift-package-manager)
[![license](https://img.shields.io/github/license/brillcp/pokedexui)](/LICENSE)
![stars](https://img.shields.io/github/stars/brillcp/pokedexui?style=social)

# PokedexUI
PokedexUI는 [Viktor Gidlöf](https://viktorgidlof.com)이 **SwiftUI**로 만든 최신 예제 앱입니다.  
`async / await`와 Swift Concurrency를 사용한 깔끔하고 반응적인 아키텍처를 통해 [PokeAPI](https://pokeapi.co)와 통합하여 포켓몬 데이터를 가져오고 표시합니다.

<img width="360" alt="pd1" src="https://github.com/user-attachments/assets/13c2362d-4519-4457-8e8f-94c0b97ad1f9" />
<img width="360" alt="pd2" src="https://github.com/user-attachments/assets/facfadbd-da67-4de8-9e7d-ac6c4207fbee" />

# 아키텍처 🏛

PokedexUI는 **프로토콜 지향 MVVM** 아키텍처와 **클린 아키텍처** 원칙을 구현합니다.  
제네릭 데이터 페칭, SwiftData 지속성, 그리고 Swift의 `@Observable` 매크로를 활용한 반응형 UI 업데이트를 특징으로 합니다.

## 주요 아키텍처 이점
- ✅ **프로토콜 지향**: 의존성 주입과 쉬운 테스트 가능  
- ✅ **제네릭 데이터 흐름**: 모든 데이터 소스에 대한 통합 패턴  
- ✅ **스토리지 우선**: 오프라인 지원 및 자동 동기화  
- ✅ **액터 기반 동시성**: 스레드 안전 데이터 작업  
- ✅ **클린 분리**: 계층 간 명확한 경계  
- ✅ **타입 안전성**: 제네릭을 통한 컴파일 타임 보장  
- ✅ **반응형 UI**: @Observable을 통한 자동 업데이트

### SOLID 준수 점수: 0.92 / 1.0
- **S**ingle Responsibility: 각 컴포넌트는 명확한 목적을 가짐  
- **O**pen/Closed: 프로토콜을 통한 확장 가능, 수정 불필요  
- **L**iskov Substitution: 프로토콜 준수로 대체 가능성 보장  
- **I**nterface Segregation: 집중되고 응집력 있는 프로토콜  
- **D**ependency Inversion: 구체화가 아닌 추상화에 의존

## 뷰 계층 📱

루트 `PokedexView`는 프로토콜을 준수하는 ViewModel을 받는 제네릭 뷰로, 의존성 주입과 테스트 가능성을 지원합니다:
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
## 뷰모델 계층 🧾

### 프로토콜 지향 설계
ViewModel은 프로토콜을 준수하여 유연한 구현과 더 쉬운 테스트를 가능하게 합니다:

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

### 일반 데이터 가져오기
`DataFetcher` 프로토콜은 스토리지 우선 데이터 로드를 위한 통합 패턴을 제공합니다:
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
### 구체적인 구현
`PokedexViewModel`은 두 프로토콜을 모두 구현합니다:

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

## 데이터 레이어 📦

### SwiftData 지속성
`DataStorageReader`는 SwiftData 작업을 위한 일반적인 액터 기반 인터페이스를 제공합니다:
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

# 지능형 검색 시스템 🔍

정교한 다중 조건 필터링과 실시간 결과를 제공하는 고성능 프로토콜 기반 검색 구현입니다.

## 검색 아키텍처

검색 시스템은 일관된 데이터 로딩과 오프라인 기능을 보장하는 동일한 통합 `DataFetcher` 패턴을 따릅니다:

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

## 고급 필터링 알고리즘

### 다중 용어 처리 및 매칭
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
## 주요 기능
- ✅ **실시간 필터링**: 입력하는 즉시 결과가 업데이트됩니다
- ✅ **다중 용어 지원**: "fire dragon"은 두 용어 모두에 맞는 포켓몬을 찾습니다
- ✅ **타입 인식 검색**: 타입(예: "물", "전기") 또는 이름으로 찾기
- ✅ **악센트 무시**: 악센트 문자를 자동으로 처리합니다
- ✅ **저장소 통합**: 로컬 SwiftData에서 검색하고 API 대체 경로 제공

검색 알고리즘은 **모든 용어가 일치해야** 정확한 결과를 보장하며 부분 이름 일치와 타입 조합을 지원합니다.

## 스프라이트 로딩 및 캐싱 🎨
비동기 이미지 로딩과 지능형 캐싱:

```swift
actor SpriteLoader {
    func loadSprite(from urlString: String) async -> UIImage? {
        // Check cache first, then network with automatic caching
    }
}
```

# Dependencies 🔗
PokedexUI는 모든 PokeAPI 호출에 HTTP 프레임워크 [Networking](https://github.com/brillcp/Networking)을 사용합니다. 이에 대한 자세한 내용은 [여기](https://github.com/brillcp/Networking#readme)에서 확인할 수 있습니다. Swift 패키지 관리자를 통해 설치할 수 있습니다:
```
dependencies: [
    .package(url: "https://github.com/brillcp/Networking.git", .upToNextMajor(from: "0.9.3"))
]
```
# 요구 사항 ❗️
- Xcode 15 이상
- iOS 17 이상 (@Observable 및 SwiftData 용)
- Swift 5.9 이상



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---