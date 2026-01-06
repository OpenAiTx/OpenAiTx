# indicium
![Crates.io Version](https://img.shields.io/crates/v/indicium)
![Crates.io MSRV](https://img.shields.io/crates/msrv/indicium)
![Crates.io License](https://img.shields.io/crates/l/indicium)
![Crates.io Total Downloads](https://img.shields.io/crates/d/indicium)

コレクション（`Vec`、`HashMap`、`BTreeMap`など）やキー・バリューストアのためのシンプルなインメモリ検索。
オートコンプリートとファジーマッチングを特徴としています。

Rustには多くの素晴らしい検索エンジンがあります。多くは別のサーバーバイナリのコンパイルを必要とするようです。
私はシンプルで軽量なもの、つまり自分のバイナリ内の構造体やコレクションを便利に検索できる使いやすいクレートが欲しかったのです。
そこで、`indicium` を作りました。

<img src="https://www.arkiteq.io/crates/indicium/banner.jpg" alt="Indicium: A Simple In-Memory Search for Rust" width="400"/>

`indicium` はウェブアプリを念頭に置いて作られましたが、インメモリ検索であり、
無限大やクラウド規模（つまりFacebookやGoogle規模）にスケールするものではありません。
そのような環境でも、通貨、言語、国などの大きなリストを検索する便利な方法となるでしょう。
また、予想されるスケール制限があるアプリケーション（会社資産のリスト、企業イントラネット内のユーザーリストなど）にも最適です。

IndiciumはRustの[BTreeMap](https://cglab.ca/~abeinges/blah/rust-btree-case/)のおかげで、
数百万のレコードも難なく処理できます。このクレートは主に利用可能なメモリによって制限されます。
しかし、データセットの性質や繰り返し出現するキーワードがある場合、
ある時点でパフォーマンスが低下し始める可能性があります。

# インストール

プロジェクトの`Cargo.toml`ファイルに依存関係を設定してください：





```toml
[dependencies]
indicium = "0.6"
```

# リリースノート

* リリースノートは
  [GitHub](https://github.com/leontoeides/indicium/releases)で利用可能です。

* 完全な[変更履歴](https://github.com/leontoeides/indicium/blob/master/CHANGELOG.md)は
  GitHubで確認できます。

# クイックスタートガイド

**クイックスタートガイド**の例として、次の`struct`内を検索します：



```rust
struct MyStruct {
    title: String,
    year: u16,
    body: String,
}
```

## 1. Indexableの実装

まず、レコードをインデックス可能にする必要があります。これを行うために、`struct`に対して`Indexable`トレイトを実装します。アイデアは、インデックス化したいすべてのフィールドに対して`String`を返すことです。例:



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

数値、数値識別子、列挙型、およびその他の型を `struct`（または他の複雑な型）内で
インデックス可能にするには、それらを `String` に変換し、返される `Vec<String>` に含めることを
忘れないでください。

## 2. コレクションのインデックス作成

既存のコレクションをインデックス化するには、コレクションを反復処理します。各
レコードについて、それを検索インデックスに挿入します。これは以下の2つの例のような
形になるはずです。

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

#### ハッシュマップ

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
`Indexable` トレイトが値の型に実装されている限り、上記の例は事前に要素が追加された `Vec` や `HashMap` をインデックスします。しかし、大規模なコレクションの場合は、コレクション（Vec、HashMap など）に要素を挿入する際に同時に `SearchIndex` にも `insert` する方法が推奨されます。

対象のコレクション（`Vec`、`HashMap` など）とこの `SearchIndex` を新しい `struct` 型にまとめてラップすることを推奨します。次に、この新しい `struct` 型に対して `insert`、`replace`、`remove` などのメソッドを実装し、コレクションと検索インデックスの両方を更新するようにします。これにより、コレクションとインデックスの両方が常に同期されることが保証されます。

インデックスが構築されたら、`search` および `autocomplete` メソッドを使用できます。

## 3. 検索

`search` メソッドは検索結果としてキーを返します。各結果のキーを使って、そのコレクションから完全なレコードを取得できます。

基本的な使い方:











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

検索は正確なキーワード一致のみをサポートします。`Live`検索の場合、あいまい検索は
最後のキーワードのみに適用されます。ユーザーが入力しながら検索を構築できるように、
`autocomplete`機能の提供を検討してください。

## 4. 補完機能

`autocomplete`メソッドは、指定された文字列の最後のキーワードに対して
いくつかの補完オプションを提供します。

基本的な使用法:

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

# ボーナスポイント

## 5. カスタム結果の順序付け

`SearchType::Or`（関連度スコアリングを使用するもの）を除き、検索結果はキータイプの `Ord` 実装で定義された順序で返されます。  
つまり、単純な整数や文字列の代わりにカスタムキータイプを使用することで、結果の順序を制御できます。

例えば、人気のあるアイテムを検索結果の最初に表示したい場合は、人気度でソートするキーを作成できます：




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

検索すると、結果は自動的に人気順にソートされて返ってきます。追加のソート手順は不要です。

このパターンは任意のランキングシグナルに対応します：新しさ、関連スコア、手動ソート順など。`Ord` の比較対象を変更するだけです。

### キーを使った検索

検索後、通常はコレクションから完全なレコードを取得します：



```rust
let results = search_index.search("dawn");

for key in results {
    if let Some(record) = my_records.get(key) {
        println!("{:?}", record);
    }
}
```
`Eq` と `Hash` トレイトは例で実装したように `id` フィールドのみを参照しているため（`popularity` は参照しません）、  
検索結果のキーを直接 `HashMap` の検索に使用することができます。  

# クレートの状況  

このクレートは受動的にメンテナンスされています。期待されている機能は果たしており、  
私の意見ではかなりうまく動作しています。頻繁な更新は予定されていません。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---