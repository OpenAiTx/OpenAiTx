# indicium
![Crates.io 版本](https://img.shields.io/crates/v/indicium)
![Crates.io MSRV](https://img.shields.io/crates/msrv/indicium)
![Crates.io 许可证](https://img.shields.io/crates/l/indicium)
![Crates.io 总下载量](https://img.shields.io/crates/d/indicium)

一个简单的内存搜索库，适用于集合（`Vec`、`HashMap`、`BTreeMap` 等）
和键值存储。支持自动补全和模糊匹配。

Rust 有许多令人惊叹的搜索引擎。许多似乎都需要编译一个单独的服务器二进制文件。
我想要一个简单轻量级的——一个易于使用的 crate，可以方便地在我自己的二进制文件中搜索结构体和
集合。所以，我创建了 `indicium`。

<img src="https://www.arkiteq.io/crates/indicium/banner.jpg" alt="Indicium: Rust 的简单内存搜索" width="400"/>

虽然 `indicium` 是为 Web 应用设计的，但它是一个内存搜索工具，
并不能无限制地扩展到云规模（例如 Facebook 或 Google 规模）。
即使在这样的环境下，它仍然是搜索大型列表（如货币、语言、国家等）的方便方式。
它也非常适合有预期规模限制的应用（例如搜索公司资产列表、企业内联网中的用户列表等）。

得益于 Rust 的 [BTreeMap](https://cglab.ca/~abeinges/blah/rust-btree-case/)，
Indicium 轻松处理数百万条记录，毫不费力。这个 crate 主要受限于可用内存。
然而，根据数据集的性质，如果有许多重复的关键词，
性能可能会在某个点开始下降。

# 安装

在你的项目的 `Cargo.toml` 文件中配置依赖：





```toml
[dependencies]
indicium = "0.6"
```

# 发布说明

* 发布说明可在
  [GitHub](https://github.com/leontoeides/indicium/releases) 上查看。

* 完整的 [变更日志](https://github.com/leontoeides/indicium/blob/master/CHANGELOG.md) 
  可在 GitHub 上获取。

# 快速入门指南

对于我们的 **快速入门指南** 示例，我们将在以下 `struct` 内进行搜索：



```rust
struct MyStruct {
    title: String,
    year: u16,
    body: String,
}
```

## 1. 实现 Indexable

首先，我们必须使我们的记录可索引。我们将通过为我们的 `struct` 实现
`Indexable` 特性来实现这一点。其思路是为我们希望被索引的每个字段返回一个 `String`。
示例：

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
不要忘记，您可以通过将数字、数字标识符、枚举和其他类型在您的 `struct`（或其他复杂类型）中转换为 `String`，并将它们包含在返回的 `Vec<String>` 中，从而使它们可索引。

## 2. 索引集合

要索引现有集合，我们可以遍历该集合。对于每个记录，我们将其插入搜索索引。代码大致如下两个示例所示：

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

#### 哈希映射

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
只要为您的值类型实现了 `Indexable` trait，上述示例就会索引先前填充的 `Vec` 或 `HashMap`。然而，对于大型集合，推荐的方法是在插入集合（Vec、HashMap 等）的同时，将元素 `insert` 到 `SearchIndex` 中。

建议将目标集合（您的 `Vec`、`HashMap` 等）和这个 `SearchIndex` 一起封装在一个新的 `struct` 类型中。然后，为这个新的 `struct` 类型实现 `insert`、`replace`、`remove` 等方法，这些方法将同时更新集合和搜索索引。这样可以确保您的集合和索引始终保持同步。

一旦索引被填充，您就可以使用 `search` 和 `autocomplete` 方法。

## 3. 搜索

`search` 方法将返回键作为搜索结果。每个结果键都可以用来从其集合中检索完整记录。

基本用法：











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

搜索仅支持精确关键字匹配。对于“实时”搜索，模糊匹配
仅应用于最后一个关键字。考虑为用户提供“自动完成”
功能，帮助他们在输入时构建搜索内容。

## 4. 自动完成

`autocomplete` 方法将为
所提供字符串中的最后一个关键字提供多个自动完成选项。

基本用法：

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

# 额外积分

## 5. 自定义结果排序

除了使用相关性评分的 `SearchType::Or` 外，搜索结果按照您的键类型的 `Ord` 实现定义的顺序返回。  
这意味着您可以通过使用自定义键类型而不是简单的整数或字符串来控制结果排序。

例如，如果您希望热门项目出现在搜索结果的前面，  
您可以创建一个按受欢迎程度排序的键：



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
现在搜索时，结果会自动按受欢迎程度排序。无需额外的排序步骤。

此模式适用于任何排名信号：新近度、相关分数、手动排序等。只需更改 `Ord` 的比较内容。

### 使用键进行查找

搜索后，您通常会从集合中获取完整记录：




```rust
let results = search_index.search("dawn");

for key in results {
    if let Some(record) = my_records.get(key) {
        println!("{:?}", record);
    }
}
```
因为我们在示例中实现的 `Eq` 和 `Hash` trait 只查看 `id` 字段（而不是 `popularity`），
所以你仍然可以直接使用搜索结果键进行 `HashMap` 查找。

# Crate 状态

这个 crate 处于被动维护状态。这个 crate 能完成预期的功能，
在我看来表现相当不错。不期望频繁更新。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---