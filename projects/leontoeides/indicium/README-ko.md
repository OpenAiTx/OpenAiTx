# indicium
![Crates.io Version](https://img.shields.io/crates/v/indicium)
![Crates.io MSRV](https://img.shields.io/crates/msrv/indicium)
![Crates.io License](https://img.shields.io/crates/l/indicium)
![Crates.io Total Downloads](https://img.shields.io/crates/d/indicium)

컬렉션(`Vec`, `HashMap`, `BTreeMap` 등) 및 키-값 저장소에 대한 간단한 인메모리 검색입니다.  
자동완성과 퍼지 매칭 기능을 제공합니다.

Rust에는 훌륭한 검색 엔진이 많이 있습니다. 많은 엔진이 별도의 서버 바이너리 컴파일을 요구하는 것 같습니다.  
저는 간단하고 가벼우며, 내 바이너리 내에서 구조체와 컬렉션을 편리하게 검색할 수 있는 사용하기 쉬운 크레이트를 원했습니다. 그래서 `indicium`을 만들었습니다.

<img src="https://www.arkiteq.io/crates/indicium/banner.jpg" alt="Indicium: A Simple In-Memory Search for Rust" width="400"/>

`indicium`은 웹 앱을 염두에 두고 만들어졌지만, 인메모리 검색이며 무한정 또는 클라우드 규모(예: 페이스북이나 구글 규모)로 확장되지 않습니다.  
그런 환경에서도 통화, 언어, 국가 등과 같은 큰 목록을 검색하는 편리한 방법이 될 것입니다. 또한 예상되는 규모 제한이 있는 애플리케이션(예: 회사 자산 목록, 기업 인트라넷 내 사용자 목록 등)에 적합합니다.

Indicium은 Rust의 [BTreeMap](https://cglab.ca/~abeinges/blah/rust-btree-case/) 덕분에 수백만 건의 레코드도 무리 없이 처리할 수 있습니다.  
이 크레이트는 주로 사용 가능한 메모리에 의해 제한됩니다. 그러나 데이터 세트의 특성이나 키워드가 여러 번 반복되는 경우, 성능이 어느 시점에서 저하될 수 있습니다.

# 설치

프로젝트의 `Cargo.toml` 파일에서 의존성을 설정하세요:










```toml
[dependencies]
indicium = "0.6"
```

# 릴리스 노트

* 릴리스 노트는
  [GitHub](https://github.com/leontoeides/indicium/releases)에서 확인할 수 있습니다.

* 전체 [변경
  로그](https://github.com/leontoeides/indicium/blob/master/CHANGELOG.md)는
  GitHub에서 확인할 수 있습니다.

# 빠른 시작 가이드

우리의 **빠른 시작 가이드** 예제에서는 다음 `struct` 안에서 검색할 것입니다:


```rust
struct MyStruct {
    title: String,
    year: u16,
    body: String,
}
```
## 1. 인덱싱 가능 구현하기

먼저, 레코드를 인덱싱 가능하게 만들어야 합니다. 이를 위해 `struct`에 대해
`Indexable` 트레이트를 구현할 것입니다. 아이디어는 인덱싱하고자 하는
모든 필드에 대해 `String`을 반환하는 것입니다. 예:


```rust
use indicium::simple::Indexable;

impl Indexable for MyStruct {
    fn strings(&self) -> Vec<String> {
        vec![
            self.title.clone(),
            self.year.to_string(),
            self.body.clone(),
        ]
    }
}
```
숫자, 숫자 식별자, 열거형 및 기타 유형을 `struct`(또는 다른 복합 유형) 내에서
`String`으로 변환하고 반환된 `Vec<String>`에 포함시켜 인덱싱할 수 있다는 점을 잊지 마세요.

## 2. 컬렉션 인덱싱하기

기존 컬렉션을 인덱싱하려면 컬렉션을 반복(iterate)하면 됩니다. 각
레코드마다 검색 인덱스에 삽입합니다. 이는 다음 두 예시와 비슷할 것입니다:

#### Vec




```rust
use indicium::simple::SearchIndex;

let my_vec: Vec<MyStruct> = Vec::new();

// In the case of a `Vec` collection, we use the index as our key. A
// `Vec` index is a `usize` type. Therefore we will instantiate
// `SearchIndex` as `SearchIndex<usize>`.

let mut search_index: SearchIndex<usize> = SearchIndex::default();

my_vec
    .iter()
    .enumerate()
    .for_each(|(index, element)|
        search_index.insert(&index, element)
    );
```

#### 해시맵

```rust
use std::collections::HashMap;
use indicium::simple::SearchIndex;

let my_hash_map: HashMap<String, MyStruct> = HashMap::new();

// In the case of a `HashMap` collection, we use the hash map's key as
// the `SearchIndex` key. In our hypothetical example, we will use
// MyStruct's `title` as a the key which is a `String` type. Therefore
// we will instantiate `HashMap<K, V>` as HashMap<String, MyStruct> and
// `SearchIndex<K>` as `SearchIndex<String>`.

let mut search_index: SearchIndex<String> = SearchIndex::default();

my_hash_map
    .iter()
    .for_each(|(key, value)|
        search_index.insert(key, value)
    );
```
`Indexable` 트레이트가 값 타입에 구현되어 있는 한, 위의 예제들은 이전에 채워진 `Vec` 또는 `HashMap`을 인덱싱할 수 있습니다. 그러나
대용량 컬렉션의 경우 선호되는 방법은 컬렉션(Vect, HashMap 등)에 데이터를 삽입할 때 `SearchIndex`에도 `insert`하는 것입니다.

대상 컬렉션(`Vec`, `HashMap` 등)과 이 `SearchIndex`를 함께 새로운 `struct` 타입으로 감싸는 것이 권장됩니다. 그런 다음,
이 새로운 `struct` 타입에 대해 `insert`, `replace`, `remove` 등의 메서드를 구현하여 컬렉션과 검색 인덱스 모두를 업데이트하도록 합니다.
이렇게 하면 컬렉션과 인덱스가 항상 동기화 상태를 유지할 수 있습니다.

인덱스가 채워지면 `search`와 `autocomplete` 메서드를 사용할 수 있습니다.

## 3. 검색

`search` 메서드는 검색 결과로 키를 반환합니다. 각 결과 키는 해당 컬렉션에서 전체 레코드를 조회하는 데 사용될 수 있습니다.

기본 사용법:








```rust
let mut search_index: SearchIndex<usize> = SearchIndex::default();

search_index.insert(&0, &"Harold Godwinson");
search_index.insert(&1, &"Edgar Ætheling");
search_index.insert(&2, &"William the Conqueror");
search_index.insert(&3, &"William Rufus");
search_index.insert(&4, &"Henry Beauclerc");

let resulting_keys: Vec<&usize> = search_index.search("William");

assert_eq!(resulting_keys, vec![&2, &3]);

// Demonstrating fuzzy matching:

let resulting_keys: Vec<&usize> = search_index.search("Harry");

assert_eq!(resulting_keys, vec![&0]);
```
검색은 정확한 키워드 일치만 지원합니다. `실시간` 검색의 경우, 퍼지 매칭은
마지막 키워드에만 적용됩니다. 사용자가 검색어를 입력하는 동안 검색어를
구성할 수 있도록 `자동완성` 기능을 제공하는 것을 고려하십시오.

## 4. 자동완성

`autocomplete` 메서드는 제공된 문자열의 마지막 키워드에 대해 여러 자동완성
옵션을 제공합니다.

기본 사용법:


```rust
let mut search_index: SearchIndex<usize> =
    SearchIndexBuilder::default()
        .autocomplete_type(&AutocompleteType::Global)
        .build();

search_index.insert(&0, &"apple");
search_index.insert(&1, &"ball");
search_index.insert(&3, &"bird");
search_index.insert(&4, &"birthday");
search_index.insert(&5, &"red");

let autocomplete_options: Vec<String> =
    search_index.autocomplete("a very big bi");

assert_eq!(
    autocomplete_options,
    vec!["a very big bird", "a very big birthday"]
);

// Demonstrating fuzzy matching:

let autocomplete_options: Vec<String> =
    search_index.autocomplete("a very big birf");

assert_eq!(
    autocomplete_options,
    vec!["a very big bird", "a very big birthday"]
);
```

# 보너스 포인트

## 5. 사용자 정의 결과 정렬

`SearchType::Or`를 사용하여 관련성 점수를 사용하는 경우를 제외하고, 검색 결과는 키 타입의 `Ord` 구현에 의해 정의된 순서로 반환됩니다.  
즉, 단순한 정수나 문자열 대신 사용자 정의 키 타입을 사용하여 결과 정렬을 제어할 수 있습니다.

예를 들어, 인기 있는 항목이 검색 결과에 먼저 나타나도록 하려면,  
인기도에 따라 정렬하는 키를 만들 수 있습니다:



```rust
use std::cmp::Ordering;
use std::hash::{Hash, Hasher};

/// A search key that sorts results by popularity (highest first).
#[derive(Debug, Clone)]
pub struct RankedKey {
    pub id: String,
    pub popularity: u32,
}

impl Ord for RankedKey {
    fn cmp(&self, other: &Self) -> Ordering {
        // Higher popularity comes first
        other.popularity.cmp(&self.popularity)
    }
}

impl PartialOrd for RankedKey {
    fn partial_cmp(&self, other: &Self) -> Option {
        Some(self.cmp(other))
    }
}

// For equality and lookups, we only compare the id, not popularity. This lets
// us find records in a HashMap using just the id.

impl PartialEq for RankedKey {
    fn eq(&self, other: &Self) -> bool {
        self.id == other.id
    }
}

impl Eq for RankedKey {}

impl Hash for RankedKey {
    fn hash(&self, state: &mut H) {
        self.id.hash(state);
    }
}
```
이제 검색하면 결과가 자동으로 인기순으로 정렬되어 반환됩니다. 추가 정렬 단계가 필요 없습니다.

이 패턴은 최신성, 관련성 점수, 수동 정렬 순서 등 어떤 순위 신호에도 적용됩니다. `Ord`가 비교하는 것만 변경하세요.

### 조회를 위한 키 사용

검색 후에는 일반적으로 컬렉션에서 전체 레코드를 가져옵니다:




```rust
let results = search_index.search("dawn");

for key in results {
    if let Some(record) = my_records.get(key) {
        println!("{:?}", record);
    }
}
```
`Eq` 및 `Hash` 트레잇이 예제에서 구현한 것처럼 `id` 필드만 보고 ( `popularity`는 보지 않음)
검색 결과 키를 `HashMap` 조회에 직접 사용할 수 있습니다.

# 크레이트 상태

이 크레이트는 소극적으로 유지 관리되고 있습니다. 이 크레이트는 예상한 기능을 수행하며
제 생각에는 꽤 잘 수행합니다. 빈번한 업데이트는 예상되지 않습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---