# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm là một bộ công cụ đơn giản và mạnh mẽ dành cho [BoltDB](https://github.com/coreos/bbolt). Về cơ bản, Storm cung cấp các chỉ mục, nhiều phương thức đa dạng để lưu trữ và truy xuất dữ liệu, một hệ thống truy vấn nâng cao và nhiều hơn nữa.

Ngoài các ví dụ bên dưới, hãy xem thêm [các ví dụ trong GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Để truy vấn mở rộng và hỗ trợ cho [Badger](https://github.com/dgraph-io/badger), hãy xem thêm [Genji](https://github.com/asdine/genji)_

## Mục lục

- [Bắt đầu](#getting-started)
- [Nhập Storm](#import-storm)
- [Mở một cơ sở dữ liệu](#open-a-database)
- [Hệ thống CRUD đơn giản](#simple-crud-system)
  - [Khai báo cấu trúc của bạn](#declare-your-structures)
  - [Lưu đối tượng của bạn](#save-your-object)
    - [Tự động tăng](#auto-increment)
  - [Truy vấn đơn giản](#simple-queries)
    - [Truy xuất một đối tượng](#fetch-one-object)
    - [Truy xuất nhiều đối tượng](#fetch-multiple-objects)
    - [Truy xuất tất cả đối tượng](#fetch-all-objects)
    - [Truy xuất tất cả đối tượng được sắp xếp theo chỉ mục](#fetch-all-objects-sorted-by-index)
    - [Truy xuất một dải đối tượng](#fetch-a-range-of-objects)
    - [Truy xuất đối tượng theo tiền tố](#fetch-objects-by-prefix)
    - [Bỏ qua, Giới hạn và Đảo ngược](#skip-limit-and-reverse)
    - [Xóa một đối tượng](#delete-an-object)
    - [Cập nhật một đối tượng](#update-an-object)
    - [Khởi tạo bucket và chỉ mục trước khi lưu đối tượng](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Xóa một bucket](#drop-a-bucket)
    - [Tạo lại chỉ mục cho một bucket](#re-index-a-bucket)
  - [Truy vấn nâng cao](#advanced-queries)
  - [Giao dịch](#transactions)
  - [Tùy chọn](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Codec được cung cấp](#provided-codecs)
    - [Sử dụng kết nối Bolt hiện có](#use-existing-bolt-connection)
    - [Chế độ Batch](#batch-mode)
- [Node và bucket lồng nhau](#nodes-and-nested-buckets)
  - [Tùy chọn Node](#node-options)
- [Khoá-giá trị đơn giản](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Giấy phép](#license)
- [Công nhận](#credits)

## Bắt đầu

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Nhập Storm

```go
import "github.com/asdine/storm/v3"
```

## Mở một cơ sở dữ liệu

Cách nhanh để mở một cơ sở dữ liệu

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` có thể nhận nhiều tuỳ chọn để tuỳ chỉnh cách hoạt động. Xem thêm ở phần [Tùy chọn](#options) bên dưới

## Hệ thống CRUD đơn giản

### Khai báo cấu trúc của bạn

```go
type User struct {
  ID int // khoá chính
  Group string `storm:"index"` // trường này sẽ được tạo chỉ mục
  Email string `storm:"unique"` // trường này sẽ được tạo chỉ mục với ràng buộc duy nhất
  Name string // trường này sẽ không được tạo chỉ mục
  Age int `storm:"index"`
}
```

Khoá chính có thể là bất kỳ kiểu dữ liệu nào miễn là không phải giá trị zero. Storm sẽ tìm kiếm tag `id`, nếu không có thì sẽ tìm trường có tên là `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// khoá chính
  Group string `storm:"index"` // trường này sẽ được tạo chỉ mục
  Email string `storm:"unique"` // trường này sẽ được tạo chỉ mục với ràng buộc duy nhất
  Name string // trường này sẽ không được tạo chỉ mục
}
```

Storm xử lý tag trong các cấu trúc lồng nhau với tag `inline`

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

### Lưu đối tượng của bạn

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

Chỉ như vậy thôi.

`Save` sẽ tạo hoặc cập nhật tất cả chỉ mục và bucket cần thiết, kiểm tra ràng buộc duy nhất và lưu đối tượng vào kho lưu trữ.

#### Tự động tăng

Storm có thể tự động tăng giá trị số nguyên nên bạn không cần lo lắng về việc này khi lưu đối tượng. Ngoài ra, giá trị mới cũng sẽ được tự động chèn vào trường của bạn.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // khoá chính với tự động tăng
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // có thể đặt giá trị bắt đầu
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

### Truy vấn đơn giản

Bất kỳ đối tượng nào cũng có thể được truy xuất, có chỉ mục hoặc không. Storm sẽ sử dụng chỉ mục khi có, nếu không sẽ sử dụng [hệ thống truy vấn](#advanced-queries).

#### Truy xuất một đối tượng

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Truy xuất nhiều đối tượng

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Lấy tất cả đối tượng

```go
var users []User
err := db.All(&users)
```

#### Lấy tất cả đối tượng và sắp xếp theo chỉ mục

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Lấy một dải đối tượng

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Lấy đối tượng theo tiền tố

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Bỏ qua, Giới hạn và Đảo ngược

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

#### Xóa một đối tượng

```go
err := db.DeleteStruct(&user)
```

#### Cập nhật một đối tượng

```go
// Cập nhật nhiều trường
// Chỉ hoạt động với trường có giá trị khác zero (ví dụ: Name không được là "", Age không được là 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Cập nhật một trường đơn lẻ
// Cũng hoạt động với các giá trị zero (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Khởi tạo buckets và indexes trước khi lưu đối tượng

```go
err := db.Init(&User{})
```

Hữu ích khi bắt đầu ứng dụng của bạn

#### Xóa một bucket

Dùng struct

```go
err := db.Drop(&User)
```

Dùng tên bucket

```go
err := db.Drop("User")
```

#### Lập chỉ mục lại một bucket

```go
err := db.ReIndex(&User{})
```

Hữu ích khi cấu trúc đã thay đổi

### Truy vấn nâng cao

Đối với các truy vấn phức tạp hơn, bạn có thể sử dụng phương thức `Select`.
`Select` nhận vào bất kỳ số lượng [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) nào từ gói [`q`](https://godoc.org/github.com/asdine/storm/q).

Dưới đây là một số Matcher phổ biến:

```go
// So sánh bằng
q.Eq("Name", John)

// Lớn hơn một cách nghiêm ngặt
q.Gt("Age", 7)

// Nhỏ hơn hoặc bằng
q.Lte("Age", 77)

// Regex với tên bắt đầu bằng chữ D
q.Re("Name", "^D")

// Trong danh sách giá trị cho trước
q.In("Group", []string{"Staff", "Admin"})

// So sánh các trường
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher cũng có thể kết hợp với `And`, `Or` và `Not`:

```go

// Khớp nếu tất cả đều khớp
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Khớp nếu một trong các điều kiện khớp
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

Bạn có thể tìm danh sách đầy đủ trong [tài liệu](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` nhận bất kỳ số lượng matcher nào và tự động bọc chúng trong một `q.And()`, vì vậy không cần chỉ định rõ. Nó trả về kiểu [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Kiểu `Query` chứa các phương thức để lọc và sắp xếp bản ghi.

```go
// Giới hạn
query = query.Limit(10)

// Bỏ qua
query = query.Skip(20)

// Các lời gọi cũng có thể kết hợp chuỗi
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Ngoài ra còn để chỉ định cách lấy dữ liệu.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Ví dụ với `Select`:

```go
// Tìm tất cả người dùng có ID từ 10 đến 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Matcher lồng nhau
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Tìm nhiều bản ghi
err = query.Find(&users)
// hoặc
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
// Tìm bản ghi đầu tiên
err = query.First(&user)
// hoặc
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Xóa tất cả các bản ghi phù hợp
err = query.Delete(new(User))

// Lấy từng bản ghi một (hữu ích khi bucket chứa nhiều bản ghi)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Xem [tài liệu](https://godoc.org/github.com/asdine/storm#Query) để biết danh sách đầy đủ các phương thức.

### Giao dịch (Transactions)

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

### Tùy chọn (Options)

Các tùy chọn của Storm là các hàm có thể được truyền vào khi khởi tạo instance Storm của bạn. Bạn có thể truyền vào bất kỳ số lượng tùy chọn nào.

#### BoltOptions

Theo mặc định, Storm mở database với chế độ `0600` và timeout là một giây.
Bạn có thể thay đổi hành vi này bằng cách sử dụng `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Để lưu trữ dữ liệu trong BoltDB, Storm mặc định sẽ marshal nó thành JSON. Nếu bạn muốn thay đổi hành vi này, bạn có thể truyền vào một codec thực hiện [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) thông qua tùy chọn [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Các Codec được cung cấp sẵn

Bạn có thể dễ dàng tự triển khai `MarshalUnmarshaler`, nhưng Storm đi kèm hỗ trợ sẵn cho [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (mặc định), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob),  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) và [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Bạn có thể sử dụng bằng cách import package tương ứng và dùng codec đó để cấu hình Storm. Ví dụ dưới đây cho thấy tất cả các biến thể (không xử lý lỗi):

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

**Mẹo**: Thêm tag Storm vào file Protobuf sinh tự động có thể khó khăn. Một giải pháp tốt là sử dụng [công cụ này](https://github.com/favadi/protoc-go-inject-tag) để chèn tag trong quá trình biên dịch.

#### Sử dụng kết nối Bolt có sẵn

Bạn có thể sử dụng một kết nối đã có và truyền nó vào Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Chế độ batch

Chế độ batch có thể được bật để tăng tốc ghi đồng thời (xem [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Node và bucket lồng nhau

Storm tận dụng tính năng bucket lồng nhau của BoltDB bằng cách sử dụng `storm.Node`.
Một `storm.Node` là đối tượng nền được `storm.DB` sử dụng để thao tác với một bucket.
Để tạo một bucket lồng nhau và sử dụng cùng API như `storm.DB`, bạn có thể dùng phương thức `DB.From`.

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

Bạn cũng có thể nối chuỗi các node để tạo thành một cấu trúc phân cấp

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Bạn thậm chí có thể truyền toàn bộ cấu trúc phân cấp làm đối số cho `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Tùy chọn cho Node

Một Node cũng có thể được cấu hình. Kích hoạt một tùy chọn trên Node sẽ tạo ra một bản sao, do đó Node luôn an toàn cho đa luồng.

```go
n := db.From("my-node")
```

Truyền một giao dịch bolt.Tx cho Node

```go
n = n.WithTransaction(tx)
```

Bật chế độ batch

```go
n = n.WithBatch(true)
```

Sử dụng một Codec

```go
n = n.WithCodec(gob.Codec)
```

## Lưu trữ Key/Value đơn giản

Storm có thể được sử dụng như một kho key/value đơn giản, mạnh mẽ, có thể lưu trữ bất cứ thứ gì.
Key và value có thể thuộc bất kỳ kiểu nào miễn là key không phải là giá trị zero.

Lưu dữ liệu :

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Lấy dữ liệu :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Xóa dữ liệu :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Bạn có thể tìm thấy các phương thức hữu ích khác trong [tài liệu hướng dẫn](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB vẫn có thể truy cập dễ dàng và có thể sử dụng như thông thường

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Một giao dịch cũng có thể được truyền vào cho Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Giấy phép

MIT

## Công nhận

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---