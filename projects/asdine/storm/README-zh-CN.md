# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm 是一个为 [BoltDB](https://github.com/coreos/bbolt) 提供的简单而强大的工具包。基本上，Storm 提供了索引、多种存储和获取数据的方法、一个高级查询系统以及更多功能。

除了下面的示例外，也可以参见 [GoDoc 中的示例](https://godoc.org/github.com/asdine/storm#pkg-examples)。

_关于扩展查询和对 [Badger](https://github.com/dgraph-io/badger) 的支持，也可参见 [Genji](https://github.com/asdine/genji)_

## 目录

- [快速开始](#getting-started)
- [导入 Storm](#import-storm)
- [打开数据库](#open-a-database)
- [简单的 CRUD 系统](#simple-crud-system)
  - [声明你的结构体](#declare-your-structures)
  - [保存你的对象](#save-your-object)
    - [自增](#auto-increment)
  - [简单查询](#simple-queries)
    - [获取单个对象](#fetch-one-object)
    - [获取多个对象](#fetch-multiple-objects)
    - [获取所有对象](#fetch-all-objects)
    - [按索引排序获取所有对象](#fetch-all-objects-sorted-by-index)
    - [获取对象范围](#fetch-a-range-of-objects)
    - [按前缀获取对象](#fetch-objects-by-prefix)
    - [Skip、Limit 和 Reverse](#skip-limit-and-reverse)
    - [删除对象](#delete-an-object)
    - [更新对象](#update-an-object)
    - [在保存对象前初始化 bucket 和索引](#initialize-buckets-and-indexes-before-saving-an-object)
    - [删除 bucket](#drop-a-bucket)
    - [重建 bucket 索引](#re-index-a-bucket)
  - [高级查询](#advanced-queries)
  - [事务](#transactions)
  - [选项](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [内置编解码器](#provided-codecs)
    - [使用已有的 Bolt 连接](#use-existing-bolt-connection)
    - [批量模式](#batch-mode)
- [节点与嵌套 bucket](#nodes-and-nested-buckets)
  - [节点选项](#node-options)
- [简单的键/值存储](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [许可证](#license)
- [致谢](#credits)

## 快速开始

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## 导入 Storm

```go
import "github.com/asdine/storm/v3"
```

## 打开数据库

快速打开数据库的方法

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` 可以接收多个选项以自定义其行为。参见下文 [选项](#options)

## 简单的 CRUD 系统

### 声明你的结构体

```go
type User struct {
  ID int // 主键
  Group string `storm:"index"` // 该字段会被索引
  Email string `storm:"unique"` // 该字段会被唯一索引
  Name string // 该字段不会被索引
  Age int `storm:"index"`
}
```

主键可以为任意类型，只要不是零值。Storm 会优先查找标签 `id`，如果没有则查找名为 `ID` 的字段。

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// 主键
  Group string `storm:"index"` // 该字段会被索引
  Email string `storm:"unique"` // 该字段会被唯一索引
  Name string // 该字段不会被索引
}
```

Storm 使用 `inline` 标签处理嵌套结构体中的标签

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

### 保存你的对象

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

就是这样。

`Save` 会创建或更新所有需要的索引和 bucket，检查唯一性约束，并将对象保存到存储中。

#### 自增

Storm 可以自动递增整型字段，因此在保存对象时无需担心。同时，新值会自动写入你的字段。

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // 主键自增
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // 可设置起始值
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

### 简单查询

任何对象都可以被获取，无论是否有索引。Storm 会优先使用索引，否则会使用 [查询系统](#advanced-queries)。

#### 获取单个对象

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### 获取多个对象

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### 获取所有对象

```go
var users []User
err := db.All(&users)
```

#### 按索引排序获取所有对象

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### 获取对象区间

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### 按前缀获取对象

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### 跳过、限制和反转

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

#### 删除对象

```go
err := db.DeleteStruct(&user)
```

#### 更新对象

```go
// 更新多个字段
// 仅适用于非零值字段（例如 Name 不能为 ""，Age 不能为 0）
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// 更新单个字段
// 也适用于零值字段（0, false, "", ...）
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### 在保存对象前初始化桶和索引

```go
err := db.Init(&User{})
```

应用程序启动时很有用

#### 删除桶

使用结构体

```go
err := db.Drop(&User)
```

使用桶名称

```go
err := db.Drop("User")
```

#### 重新索引桶

```go
err := db.ReIndex(&User{})
```

当结构发生变化时很有用

### 高级查询

对于更复杂的查询，可以使用 `Select` 方法。  
`Select` 可以接收任意数量的 [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) ，来自 [`q`](https://godoc.org/github.com/asdine/storm/q) 包。

以下是一些常用的 Matcher：

```go
// 等值
q.Eq("Name", John)

// 严格大于
q.Gt("Age", 7)

// 小于等于
q.Lte("Age", 77)

// 用正则表达式匹配以 D 开头的 Name
q.Re("Name", "^D")

// 在给定的值切片中
q.In("Group", []string{"Staff", "Admin"})

// 字段间比较
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher 也可以用 `And`、`Or` 和 `Not` 组合：

```go

// 所有条件都满足时匹配
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// 只要有一个条件满足就匹配
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

完整列表可见 [文档](https://godoc.org/github.com/asdine/storm/q#Matcher)。

`Select` 接收任意数量的 matcher，并自动包裹在 `q.And()` 中，因此无需手动指定。它返回一个 [`Query`](https://godoc.org/github.com/asdine/storm#Query) 类型。

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

`Query` 类型包含用于过滤和排序记录的方法。

```go
// 限制数量
query = query.Limit(10)

// 跳过
query = query.Skip(20)

// 方法也可以链式调用
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

同时还能指定如何获取数据。

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

`Select` 示例：

```go
// 查找所有 ID 在 10 到 100 之间的用户
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// 嵌套 matcher
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// 查找多条记录
err = query.Find(&users)
// 或者
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// 查找第一条记录
err = query.First(&user)
// 或者
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// 删除所有匹配的记录
err = query.Delete(new(User))

// 逐条获取记录（当桶里有大量记录时很有用）
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

完整方法列表请参见[文档](https://godoc.org/github.com/asdine/storm#Query)。

### 事务

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

### 选项

Storm 选项是你在构造 Storm 实例时可以传递的函数。你可以传递任意数量的选项。

#### BoltOptions

默认情况下，Storm 以 `0600` 的模式和一秒的超时时间打开数据库。
你可以通过使用 `BoltOptions` 来更改此行为

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

为了将数据存储到 BoltDB，Storm 默认以 JSON 方式序列化数据。如果你希望更改此行为，可以通过 [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) 选项传递实现了 [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) 的编解码器：

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### 内置编解码器

你可以很容易地实现你自己的 `MarshalUnmarshaler`，但 Storm 已经内置支持 [JSON](https://godoc.org/github.com/asdine/storm/codec/json)（默认）、[GOB](https://godoc.org/github.com/asdine/storm/codec/gob)、[Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal)、[Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) 和 [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack)。

你可以通过导入相关包并使用该编解码器来配置 Storm。下面的例子展示了所有变体（未处理错误）：

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

**提示**：为生成的 Protobuf 文件添加 Storm 标签可能会有点棘手。一个好的解决方案是使用[这个工具](https://github.com/favadi/protoc-go-inject-tag)在编译时注入标签。

#### 使用已有的 Bolt 连接

你可以使用已有的连接并将其传递给 Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### 批量模式

可以启用批量模式以加速并发写入（参见 [批量读写事务](https://github.com/coreos/bbolt#batch-read-write-transactions)）

```go
db := storm.Open("my.db", storm.Batch())
```

## 节点与嵌套桶

Storm 通过 `storm.Node` 利用 BoltDB 的嵌套桶特性。
`storm.Node` 是 `storm.DB` 操作桶时的底层对象。
要创建嵌套桶并使用与 `storm.DB` 相同的 API，可以使用 `DB.From` 方法。

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

你还可以链式调用节点来创建层级结构

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

你甚至可以将整个层级作为参数传递给 `From`：

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### 节点选项

节点也可以进行配置。对节点激活选项会创建一个副本，因此节点始终是线程安全的。

```go
n := db.From("my-node")
```

为节点指定一个 bolt.Tx 事务

```go
n = n.WithTransaction(tx)
```

启用批量模式

```go
n = n.WithBatch(true)
```

使用编解码器

```go
n = n.WithCodec(gob.Codec)
```

## 简单的键/值存储

Storm 可以作为一个简单、健壮的键/值存储，能够存储任何内容。
只要 key 不是零值，key 和 value 可以是任意类型。

保存数据：

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

获取数据：

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
```
db.Get("sessions", someObjectId, &details)
```

删除数据：

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

你可以在[文档](https://godoc.org/github.com/asdine/storm#KeyValueStore)中找到其他有用的方法。

## BoltDB

BoltDB 依然可以轻松访问，并且可以像往常一样使用

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

事务也可以传递给 Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## 许可证

MIT

## 鸣谢

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---