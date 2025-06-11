# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Stormは、[BoltDB](https://github.com/coreos/bbolt) のためのシンプルかつ強力なツールキットです。基本的に、Stormはインデックス、さまざまなデータ格納・取得メソッド、高度なクエリシステムなど、多くの機能を提供します。

以下の例に加えて、[GoDocの例](https://godoc.org/github.com/asdine/storm#pkg-examples) も参照してください。

_拡張クエリや [Badger](https://github.com/dgraph-io/badger) サポートについては [Genji](https://github.com/asdine/genji) も参照してください_

## 目次

- [はじめに](#getting-started)
- [Stormのインポート](#import-storm)
- [データベースを開く](#open-a-database)
- [シンプルなCRUDシステム](#simple-crud-system)
  - [構造体の宣言](#declare-your-structures)
  - [オブジェクトの保存](#save-your-object)
    - [自動インクリメント](#auto-increment)
  - [シンプルなクエリ](#simple-queries)
    - [1件のオブジェクト取得](#fetch-one-object)
    - [複数オブジェクトの取得](#fetch-multiple-objects)
    - [すべてのオブジェクト取得](#fetch-all-objects)
    - [インデックスでソートした全オブジェクト取得](#fetch-all-objects-sorted-by-index)
    - [範囲でオブジェクト取得](#fetch-a-range-of-objects)
    - [プレフィックスでオブジェクト取得](#fetch-objects-by-prefix)
    - [Skip, Limit, Reverse](#skip-limit-and-reverse)
    - [オブジェクトの削除](#delete-an-object)
    - [オブジェクトの更新](#update-an-object)
    - [保存前にバケットとインデックスを初期化](#initialize-buckets-and-indexes-before-saving-an-object)
    - [バケットの削除](#drop-a-bucket)
    - [バケットの再インデックス](#re-index-a-bucket)
  - [高度なクエリ](#advanced-queries)
  - [トランザクション](#transactions)
  - [オプション](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [提供されているコーデック](#provided-codecs)
    - [既存のBolt接続の利用](#use-existing-bolt-connection)
    - [バッチモード](#batch-mode)
- [ノードとネストされたバケット](#nodes-and-nested-buckets)
  - [ノードのオプション](#node-options)
- [シンプルなKey/Valueストア](#simple-keyvalue-store)
- [BoltDBについて](#boltdb)
- [ライセンス](#license)
- [クレジット](#credits)

## はじめに

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Stormのインポート

```go
import "github.com/asdine/storm/v3"
```

## データベースを開く

データベースを素早く開く方法

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` は動作をカスタマイズするために複数のオプションを受け取ることができます。下記の [オプション](#options) を参照してください。

## シンプルなCRUDシステム

### 構造体の宣言

```go
type User struct {
  ID int // 主キー
  Group string `storm:"index"` // このフィールドはインデックスされる
  Email string `storm:"unique"` // このフィールドはユニーク制約付きでインデックスされる
  Name string // このフィールドはインデックスされない
  Age int `storm:"index"`
}
```

主キーはゼロ値でなければどんな型でも使用可能です。Stormは `id` タグを探し、なければ `ID` という名前のフィールドを探します。

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// 主キー
  Group string `storm:"index"` // このフィールドはインデックスされる
  Email string `storm:"unique"` // このフィールドはユニーク制約付きでインデックスされる
  Name string // このフィールドはインデックスされない
}
```

Stormは `inline` タグでネスト構造体のタグも扱えます。

```go
type Base struct {
  Ident bson.ObjectId `storm:"id"`
}

type User struct {
  Base      `storm:"inline"`
  Group     string `storm:"index"`
  Email     string `storm:"unique"`
  Name      string
  CreatedAt time.Time `storm:"index"`
}
```

### オブジェクトの保存

```go
user := User{
  ID: 10,
  Group: "staff",
  Email: "john@provider.com",
  Name: "John",
  Age: 21,
  CreatedAt: time.Now(),
}

err := db.Save(&user)
// err == nil

user.ID++
err = db.Save(&user)
// err == storm.ErrAlreadyExists
```

以上です。

`Save` は必要なインデックスやバケットを自動作成・更新し、ユニーク制約もチェックして、オブジェクトをストアへ保存します。

#### 自動インクリメント

Stormは整数値を自動インクリメントできるので、保存時にその点を気にする必要はありません。新しい値は自動的にフィールドへ設定されます。

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // 主キー（自動インクリメント）
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // 開始値を指定可能
}

p := Product{Name: "Vaccum Cleaner"}

fmt.Println(p.Pk)
fmt.Println(p.IntegerField)
fmt.Println(p.IndexedIntegerField)
fmt.Println(p.UniqueIntegerField)
// 0
// 0
// 0
// 0

_ = db.Save(&p)

fmt.Println(p.Pk)
fmt.Println(p.IntegerField)
fmt.Println(p.IndexedIntegerField)
fmt.Println(p.UniqueIntegerField)
// 1
// 1
// 1
// 100

```

### シンプルなクエリ

インデックス有無に関わらず、どんなオブジェクトも取得できます。Stormは利用可能な場合インデックスを使い、それ以外は[クエリシステム](#advanced-queries)を利用します。

#### 1件のオブジェクト取得

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### 複数オブジェクトの取得

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### 全オブジェクトの取得

```go
var users []User
err := db.All(&users)
```

#### インデックスでソートして全オブジェクトを取得

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### オブジェクトの範囲取得

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### プレフィックスによるオブジェクトの取得

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip, Limit, Reverse の使用

```go
var users []User
err := db.Find("Group", "staff", &users, storm.Skip(10))
err = db.Find("Group", "staff", &users, storm.Limit(10))
err = db.Find("Group", "staff", &users, storm.Reverse())
err = db.Find("Group", "staff", &users, storm.Limit(10), storm.Skip(10), storm.Reverse())

err = db.All(&users, storm.Limit(10), storm.Skip(10), storm.Reverse())
err = db.AllByIndex("CreatedAt", &users, storm.Limit(10), storm.Skip(10), storm.Reverse())
err = db.Range("Age", 10, 21, &users, storm.Limit(10), storm.Skip(10), storm.Reverse())
```

#### オブジェクトの削除

```go
err := db.DeleteStruct(&user)
```

#### オブジェクトの更新

```go
// 複数フィールドの更新
// ゼロ値以外のフィールドのみ有効（例: Nameは""不可、Ageは0不可）
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// 単一フィールドの更新
// ゼロ値フィールド（0, false, ""等）にも対応
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### オブジェクト保存前のバケットとインデックスの初期化

```go
err := db.Init(&User{})
```

アプリケーション起動時などに便利です

#### バケットの削除

構造体を利用する場合

```go
err := db.Drop(&User)
```

バケット名を利用する場合

```go
err := db.Drop("User")
```

#### バケットの再インデックス

```go
err := db.ReIndex(&User{})
```

構造体の変更時などに便利です

### 高度なクエリ

より複雑なクエリには `Select` メソッドを使用できます。
`Select` は [`q`](https://godoc.org/github.com/asdine/storm/q) パッケージの任意個数の [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) を受け取ります。

よく使われる Matcher の例:

```go
// 等価
q.Eq("Name", John)

// より大きい
q.Gt("Age", 7)

// 以下
q.Lte("Age", 77)

// 名前がDで始まる正規表現
q.Re("Name", "^D")

// 指定スライス内の値に一致
q.In("Group", []string{"Staff", "Admin"})

// フィールド同士の比較
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher は `And`, `Or`, `Not` で組み合わせ可能です:

```go

// 全て一致する場合にマッチ
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// いずれか一致する場合にマッチ
q.Or(
  q.Re("Name", "^A"),
  q.Not(
    q.Re("Name", "^B")
  ),
  q.Re("Name", "^C"),
  q.In("Group", []string{"Staff", "Admin"}),
  q.And(
    q.StrictEq("Password", []byte(password)),
    q.Eq("Registered", true)
  )
)
```

完全なリストは[ドキュメント](https://godoc.org/github.com/asdine/storm/q#Matcher)を参照してください。

`Select` は任意個数の matcher を受け取り、それらを `q.And()` でラップするので明示的に指定する必要はありません。返り値は [`Query`](https://godoc.org/github.com/asdine/storm#Query) 型です。

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

`Query` 型にはレコードのフィルタやソートのためのメソッドがあります。

```go
// Limit
query = query.Limit(10)

// Skip
query = query.Skip(20)

// チェーン呼び出しも可能
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

また、取得方法も指定できます。

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

`Select` を使った例:

```go
// IDが10から100のユーザーを全件取得
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// ネストした matcher
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// 複数レコードの取得
err = query.Find(&users)
// または
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// 最初のレコードを検索
err = query.First(&user)
// または
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// 一致するすべてのレコードを削除
err = query.Delete(new(User))

// レコードを一つずつ取得（バケットに大量のレコードが含まれている場合に便利）
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

完全なメソッド一覧については[ドキュメント](https://godoc.org/github.com/asdine/storm#Query)を参照してください。

### トランザクション

```go
tx, err := db.Begin(true)
if err != nil {
  return err
}
defer tx.Rollback()

accountA.Amount -= 100
accountB.Amount += 100

err = tx.Save(accountA)
if err != nil {
  return err
}

err = tx.Save(accountB)
if err != nil {
  return err
}

return tx.Commit()
```

### オプション

Storm のオプションは、Storm インスタンスを構築する際に渡すことができる関数です。任意の数のオプションを渡すことができます。

#### BoltOptions

デフォルトでは、Storm はモード `0600` で 1 秒のタイムアウトでデータベースを開きます。
この動作は `BoltOptions` を使用して変更できます。

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

データを BoltDB に保存するために、Storm はデフォルトで JSON でマーシャルします。この動作を変更したい場合は、[`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) を実装したコーデックを [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) オプションで渡すことができます。

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### 提供されているコーデック

独自の `MarshalUnmarshaler` を簡単に実装できますが、Storm には [JSON](https://godoc.org/github.com/asdine/storm/codec/json)（デフォルト）、[GOB](https://godoc.org/github.com/asdine/storm/codec/gob)、[Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal)、[Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf)、[MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack) の組み込みサポートがあります。

これらは該当するパッケージをインポートして、Storm の構成時にそのコーデックを使用することで利用できます。以下はすべてのバリエーションを示す例です（エラーハンドリングは省略）。

```go
import (
  "github.com/asdine/storm/v3"
  "github.com/asdine/storm/v3/codec/gob"
  "github.com/asdine/storm/v3/codec/json"
  "github.com/asdine/storm/v3/codec/sereal"
  "github.com/asdine/storm/v3/codec/protobuf"
  "github.com/asdine/storm/v3/codec/msgpack"
)

var gobDb, _ = storm.Open("gob.db", storm.Codec(gob.Codec))
var jsonDb, _ = storm.Open("json.db", storm.Codec(json.Codec))
var serealDb, _ = storm.Open("sereal.db", storm.Codec(sereal.Codec))
var protobufDb, _ = storm.Open("protobuf.db", storm.Codec(protobuf.Codec))
var msgpackDb, _ = storm.Open("msgpack.db", storm.Codec(msgpack.Codec))
```

**ヒント**: 生成された Protobuf ファイルに Storm タグを追加するのはやや難しい場合があります。コンパイル時にタグを挿入するには、[このツール](https://github.com/favadi/protoc-go-inject-tag) を使うのが良い方法です。

#### 既存の Bolt 接続を利用

既存の接続を利用し、それを Storm に渡すことができます。

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### バッチモード

バッチモードを有効化することで、同時書き込みの速度を向上させることができます（[バッチ読み書きトランザクション](https://github.com/coreos/bbolt#batch-read-write-transactions)を参照）。

```go
db := storm.Open("my.db", storm.Batch())
```

## ノードとネストされたバケット

Storm は、`storm.Node` を利用して BoltDB のネストされたバケット機能を活用します。
`storm.Node` は、バケットを操作するために `storm.DB` が内部で使用するオブジェクトです。
ネストされたバケットを作成し、`storm.DB` と同じ API を使用するには、`DB.From` メソッドを利用します。

```go
repo := db.From("repo")

err := repo.Save(&Issue{
  Title: "I want more features",
  Author: user.ID,
})

err = repo.Save(newRelease("0.10"))

var issues []Issue
err = repo.Find("Author", user.ID, &issues)

var release Release
err = repo.One("Tag", "0.10", &release)
```

ノードをチェーンして階層を作成することもできます。

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

`From` の引数として階層全体を渡すこともできます。

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### ノードオプション

ノードも設定可能です。ノードでオプションを有効化するとコピーが生成されるため、ノードは常にスレッドセーフです。

```go
n := db.From("my-node")
```

bolt.Tx トランザクションをノードに渡す

```go
n = n.WithTransaction(tx)
```

バッチモードを有効化

```go
n = n.WithBatch(true)
```

コーデックを利用

```go
n = n.WithCodec(gob.Codec)
```

## シンプルなキー／バリュー・ストア

Storm は、シンプルで堅牢なキー／バリュー・ストアとして、あらゆるものを保存することができます。
キーと値は、キーがゼロ値でない限り任意の型にできます。

データの保存：

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

データの取得：

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
```
db.Get("sessions", someObjectId, &details)
```

データの削除：

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

その他の便利なメソッドについては、[ドキュメント](https://godoc.org/github.com/asdine/storm#KeyValueStore)をご覧ください。

## BoltDB

BoltDB も簡単にアクセスでき、通常通り使用できます。

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Storm にトランザクションを渡すこともできます。

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## ライセンス

MIT

## クレジット

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---