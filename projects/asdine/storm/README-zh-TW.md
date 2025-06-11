# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm 是一個為 [BoltDB](https://github.com/coreos/bbolt) 設計的簡單且強大的工具包。基本上，Storm 提供索引、各種儲存與抓取資料的方法、進階查詢系統，以及更多功能。

除了下方的範例之外，請參閱 [GoDoc 上的範例](https://godoc.org/github.com/asdine/storm#pkg-examples)。

_如需進階查詢及對 [Badger](https://github.com/dgraph-io/badger) 的支援，請參閱 [Genji](https://github.com/asdine/genji)_

## 目錄

- [入門指南](#getting-started)
- [匯入 Storm](#import-storm)
- [開啟資料庫](#open-a-database)
- [簡易 CRUD 系統](#simple-crud-system)
  - [宣告你的結構體](#declare-your-structures)
  - [儲存你的物件](#save-your-object)
    - [自動遞增](#auto-increment)
  - [簡單查詢](#simple-queries)
    - [取得單一物件](#fetch-one-object)
    - [取得多個物件](#fetch-multiple-objects)
    - [取得所有物件](#fetch-all-objects)
    - [依索引排序取得所有物件](#fetch-all-objects-sorted-by-index)
    - [取得物件範圍](#fetch-a-range-of-objects)
    - [依前綴取得物件](#fetch-objects-by-prefix)
    - [跳過、限制與反向](#skip-limit-and-reverse)
    - [刪除物件](#delete-an-object)
    - [更新物件](#update-an-object)
    - [儲存物件前初始化 bucket 與索引](#initialize-buckets-and-indexes-before-saving-an-object)
    - [刪除 bucket](#drop-a-bucket)
    - [重新索引 bucket](#re-index-a-bucket)
  - [進階查詢](#advanced-queries)
  - [交易](#transactions)
  - [選項](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [內建編解碼器](#provided-codecs)
    - [使用現有 Bolt 連線](#use-existing-bolt-connection)
    - [批次模式](#batch-mode)
- [節點與巢狀 bucket](#nodes-and-nested-buckets)
  - [節點選項](#node-options)
- [簡單 Key/Value 儲存](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [授權條款](#license)
- [致謝](#credits)

## 入門指南

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## 匯入 Storm

```go
import "github.com/asdine/storm/v3"
```

## 開啟資料庫

快速開啟資料庫的方法

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` 可接收多個選項以自訂其行為。詳見下方 [選項](#options)

## 簡易 CRUD 系統

### 宣告你的結構體

```go
type User struct {
  ID int // 主鍵
  Group string `storm:"index"` // 此欄位將被建立索引
  Email string `storm:"unique"` // 此欄位將建立唯一性索引
  Name string // 此欄位不建立索引
  Age int `storm:"index"`
}
```

主鍵可以是任意型別，只要不是零值即可。Storm 會先尋找 `id` 標籤，若不存在則尋找名為 `ID` 的欄位。

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// 主鍵
  Group string `storm:"index"` // 此欄位將被建立索引
  Email string `storm:"unique"` // 此欄位將建立唯一性索引
  Name string // 此欄位不建立索引
}
```

Storm 透過 `inline` 標籤處理巢狀結構中的標籤

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

### 儲存你的物件

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

就是這麼簡單。

`Save` 會建立或更新所有必要的索引與 bucket，檢查唯一性約束，並將物件存入資料庫。

#### 自動遞增

Storm 可以自動遞增整數欄位，因此你在儲存物件時無需擔心這一點。此外，新值會自動寫入你的欄位。

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // 主鍵，自動遞增
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // 可設定起始值
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

### 簡單查詢

任何物件都可以被查詢，不論是否建立索引。Storm 會優先使用可用的索引，否則使用 [查詢系統](#advanced-queries)。

#### 取得單一物件

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### 取得多個物件

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### 取得所有物件

```go
var users []User
err := db.All(&users)
```

#### 依索引排序取得所有物件

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### 取得物件範圍

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### 依前綴查詢物件

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip、Limit 與 Reverse

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

#### 刪除物件

```go
err := db.DeleteStruct(&user)
```

#### 更新物件

```go
// 更新多個欄位
// 僅適用於非零值欄位（例如 Name 不能為 ""，Age 不能為 0）
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// 更新單一欄位
// 也適用於零值欄位（0, false, "", ...）
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### 在儲存物件前初始化 bucket 和索引

```go
err := db.Init(&User{})
```

啟動應用程式時很有用

#### 刪除 bucket

使用 struct

```go
err := db.Drop(&User)
```

使用 bucket 名稱

```go
err := db.Drop("User")
```

#### 重新索引 bucket

```go
err := db.ReIndex(&User{})
```

當結構有變更時很有用

### 進階查詢

對於更複雜的查詢，可以使用 `Select` 方法。
`Select` 可以接受任意數量來自 [`q`](https://godoc.org/github.com/asdine/storm/q) 套件的 [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher)。

以下是一些常用的 Matcher：

```go
// 相等
q.Eq("Name", John)

// 嚴格大於
q.Gt("Age", 7)

// 小於等於
q.Lte("Age", 77)

// 名稱以 D 開頭的正規表達式
q.Re("Name", "^D")

// 在指定的值切片內
q.In("Group", []string{"Staff", "Admin"})

// 欄位比較
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matchers 也可以用 `And`、`Or` 和 `Not` 組合：

```go

// 所有條件皆符合時匹配
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// 任一條件符合時匹配
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

你可以在[文件](https://godoc.org/github.com/asdine/storm/q#Matcher)中找到完整列表。

`Select` 接受任意數量的 matcher，並自動包裝成 `q.And()`，因此不需要特別指定。它會返回一個 [`Query`](https://godoc.org/github.com/asdine/storm#Query) 類型。

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

`Query` 類型包含了過濾與排序記錄的方法。

```go
// 限制筆數
query = query.Limit(10)

// 跳過筆數
query = query.Skip(20)

// 方法可鏈式呼叫
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

也可以指定如何取得資料。

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

`Select` 的範例：

```go
// 找出 ID 介於 10 到 100 的所有使用者
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// 巢狀 matcher
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// 查詢多筆記錄
err = query.Find(&users)
// 或
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// 尋找第一筆紀錄
err = query.First(&user)
// 或
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// 刪除所有符合條件的紀錄
err = query.Delete(new(User))

// 逐筆讀取紀錄（當資料桶內含大量紀錄時很有用）
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

請參考[文件](https://godoc.org/github.com/asdine/storm#Query)以取得完整的方法列表。

### 交易（Transactions）

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

### 選項（Options）

Storm 的選項是可以在建立 Storm 實例時傳入的函數。你可以傳入任意數量的選項。

#### BoltOptions

預設情況下，Storm 以 `0600` 權限及一秒 timeout 開啟資料庫。
你可以使用 `BoltOptions` 來變更這個行為

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

為了將資料儲存到 BoltDB，Storm 預設會以 JSON 格式進行編解碼。如果你希望改變這個行為，可以透過 [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) 選項傳入一個實作 [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) 的 codec：

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### 內建 Codec

你可以輕鬆實作自己的 `MarshalUnmarshaler`，但 Storm 也內建支援 [JSON](https://godoc.org/github.com/asdine/storm/codec/json)（預設）、[GOB](https://godoc.org/github.com/asdine/storm/codec/gob)、[Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal)、[Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) 和 [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack)。

你可以透過匯入相關套件並用該 codec 來設定 Storm。下方範例展示所有類型（未做完整錯誤處理）：

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

**小提示**：在產生的 Protobuf 檔案中添加 Storm 標籤可能有些麻煩。一個不錯的解決方案是使用[這個工具](https://github.com/favadi/protoc-go-inject-tag)在編譯時自動注入標籤。

#### 使用既有的 Bolt 連線

你可以使用既有的連線並傳給 Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### 批次模式（Batch mode）

可以啟用批次模式以加速並行寫入（參見 [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions)）

```go
db := storm.Open("my.db", storm.Batch())
```

## 節點與巢狀資料桶（Nodes and nested buckets）

Storm 透過 `storm.Node` 利用 BoltDB 的巢狀資料桶功能。
`storm.Node` 是 `storm.DB` 操作資料桶時使用的底層物件。
要建立巢狀資料桶並使用與 `storm.DB` 相同的 API，可以使用 `DB.From` 方法。

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

你也可以串接節點來建立階層結構

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

你甚至可以將整個階層當作參數傳給 `From`：

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### 節點選項

節點也可以進行個別設定。對節點啟用選項會建立一個副本，因此節點總是執行緒安全的。

```go
n := db.From("my-node")
```

將 bolt.Tx 交易傳給節點

```go
n = n.WithTransaction(tx)
```

啟用批次模式

```go
n = n.WithBatch(true)
```

使用 Codec

```go
n = n.WithCodec(gob.Codec)
```

## 簡易鍵值儲存（Simple Key/Value store）

Storm 也可以作為一個簡單、穩健的鍵值儲存系統，能儲存任何東西。
只要 key 不是零值，key 和 value 可以是任何型別。

儲存資料：

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

讀取資料：

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
```
db.Get("sessions", someObjectId, &details)
```

刪除資料：

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

你可以在[文件](https://godoc.org/github.com/asdine/storm#KeyValueStore)中找到其他有用的方法。

## BoltDB

BoltDB 仍然可以輕鬆訪問，並且可以像往常一樣使用

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

也可以將交易傳遞給 Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## 授權

MIT

## 貢獻者

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---