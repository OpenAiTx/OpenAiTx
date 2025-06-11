# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm เป็นชุดเครื่องมือที่เรียบง่ายและทรงพลังสำหรับ [BoltDB](https://github.com/coreos/bbolt) โดยพื้นฐานแล้ว Storm มีระบบจัดทำดัชนี (indexes), วิธีการที่หลากหลายในการจัดเก็บและดึงข้อมูล, ระบบค้นหาขั้นสูง และอื่นๆ อีกมากมาย

นอกจากตัวอย่างด้านล่างนี้แล้ว โปรดดู [ตัวอย่างเพิ่มเติมใน GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples)

_สำหรับระบบค้นหาขั้นสูงและการรองรับ [Badger](https://github.com/dgraph-io/badger) โปรดดูที่ [Genji](https://github.com/asdine/genji)_

## สารบัญ

- [เริ่มต้นใช้งาน](#getting-started)
- [นำเข้า Storm](#import-storm)
- [เปิดฐานข้อมูล](#open-a-database)
- [ระบบ CRUD อย่างง่าย](#simple-crud-system)
  - [ประกาศโครงสร้างของคุณ](#declare-your-structures)
  - [บันทึกอ็อบเจกต์ของคุณ](#save-your-object)
    - [เพิ่มค่าอัตโนมัติ](#auto-increment)
  - [การค้นหาแบบง่าย](#simple-queries)
    - [ดึงอ็อบเจกต์เดียว](#fetch-one-object)
    - [ดึงอ็อบเจกต์หลายรายการ](#fetch-multiple-objects)
    - [ดึงอ็อบเจกต์ทั้งหมด](#fetch-all-objects)
    - [ดึงอ็อบเจกต์ทั้งหมดเรียงตามดัชนี](#fetch-all-objects-sorted-by-index)
    - [ดึงอ็อบเจกต์ในช่วง](#fetch-a-range-of-objects)
    - [ดึงอ็อบเจกต์ตาม prefix](#fetch-objects-by-prefix)
    - [ข้าม, จำกัด และย้อนกลับ](#skip-limit-and-reverse)
    - [ลบอ็อบเจกต์](#delete-an-object)
    - [อัปเดตอ็อบเจกต์](#update-an-object)
    - [เตรียม bucket และดัชนีก่อนบันทึกอ็อบเจกต์](#initialize-buckets-and-indexes-before-saving-an-object)
    - [ลบ bucket](#drop-a-bucket)
    - [สร้างดัชนี bucket ใหม่](#re-index-a-bucket)
  - [การค้นหาขั้นสูง](#advanced-queries)
  - [ธุรกรรม](#transactions)
  - [ตัวเลือก](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Codec ที่มีให้](#provided-codecs)
    - [ใช้การเชื่อมต่อ Bolt ที่มีอยู่](#use-existing-bolt-connection)
    - [โหมด Batch](#batch-mode)
- [Node และ bucket ซ้อน](#nodes-and-nested-buckets)
  - [ตัวเลือก Node](#node-options)
- [Key/Value store แบบง่าย](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [สัญญาอนุญาต](#license)
- [เครดิต](#credits)

## เริ่มต้นใช้งาน

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## นำเข้า Storm

```go
import "github.com/asdine/storm/v3"
```

## เปิดฐานข้อมูล

วิธีเปิดฐานข้อมูลอย่างรวดเร็ว

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` สามารถรับตัวเลือกหลายค่าเพื่อปรับแต่งการทำงาน ดูที่ [ตัวเลือก](#options) ด้านล่าง

## ระบบ CRUD อย่างง่าย

### ประกาศโครงสร้างของคุณ

```go
type User struct {
  ID int // primary key
  Group string `storm:"index"` // ฟิลด์นี้จะถูกจัดทำดัชนี
  Email string `storm:"unique"` // ฟิลด์นี้จะถูกจัดทำดัชนีแบบไม่ซ้ำ
  Name string // ฟิลด์นี้จะไม่ถูกจัดทำดัชนี
  Age int `storm:"index"`
}
```

Primary key สามารถเป็นชนิดใดก็ได้ตราบใดที่ไม่ใช่ค่า zero Storm จะค้นหา tag `id` หากไม่พบ Storm จะค้นหาชื่อฟิลด์ว่า `ID`

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// primary key
  Group string `storm:"index"` // ฟิลด์นี้จะถูกจัดทำดัชนี
  Email string `storm:"unique"` // ฟิลด์นี้จะถูกจัดทำดัชนีแบบไม่ซ้ำ
  Name string // ฟิลด์นี้จะไม่ถูกจัดทำดัชนี
}
```

Storm รองรับ tag ในโครงสร้างซ้อนด้วย tag `inline`

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

### บันทึกอ็อบเจกต์ของคุณ

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

แค่นั้นเอง

`Save` จะสร้างหรืออัปเดตดัชนีและ bucket ที่จำเป็นทั้งหมด, ตรวจสอบข้อจำกัดแบบไม่ซ้ำ และบันทึกอ็อบเจกต์ลง store

#### เพิ่มค่าอัตโนมัติ

Storm สามารถเพิ่มค่าตัวเลขแบบอัตโนมัติ ทำให้คุณไม่ต้องกังวลเรื่องนี้ขณะบันทึกอ็อบเจกต์ ค่าใหม่จะถูกแทรกในฟิลด์ของคุณโดยอัตโนมัติ

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // primary key พร้อมเพิ่มค่าอัตโนมัติ
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // สามารถตั้งค่าตั้งต้นได้
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

### การค้นหาแบบง่าย

สามารถดึงอ็อบเจกต์ใดก็ได้ ไม่ว่าจะจัดทำดัชนีหรือไม่ Storm จะใช้ดัชนีเมื่อมีให้ใช้ มิฉะนั้นจะใช้ [ระบบค้นหาขั้นสูง](#advanced-queries)

#### ดึงอ็อบเจกต์เดียว

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### ดึงอ็อบเจกต์หลายรายการ

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### ดึงข้อมูลอ็อบเจกต์ทั้งหมด

```go
var users []User
err := db.All(&users)
```

#### ดึงข้อมูลอ็อบเจกต์ทั้งหมดโดยเรียงตามดัชนี

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### ดึงข้อมูลอ็อบเจกต์ในช่วงที่กำหนด

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### ดึงข้อมูลอ็อบเจกต์โดยใช้ prefix

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### ข้าม, จำกัดจำนวน และย้อนกลับลำดับ

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

#### ลบอ็อบเจกต์

```go
err := db.DeleteStruct(&user)
```

#### อัปเดตอ็อบเจกต์

```go
// อัปเดตหลายฟิลด์
// ใช้ได้เฉพาะกับฟิลด์ที่ไม่ใช่ค่า zero-value (เช่น Name ต้องไม่เป็น "", Age ต้องไม่เป็น 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// อัปเดตฟิลด์เดียว
// ใช้กับค่า zero-value ได้ด้วย (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### สร้าง bucket และ index ล่วงหน้าก่อนบันทึกอ็อบเจกต์

```go
err := db.Init(&User{})
```

มีประโยชน์เมื่อต้องการเริ่มต้นแอปพลิเคชัน

#### ลบ bucket

โดยใช้ struct

```go
err := db.Drop(&User)
```

โดยใช้ชื่อ bucket

```go
err := db.Drop("User")
```

#### สร้าง index ใหม่ให้กับ bucket

```go
err := db.ReIndex(&User{})
```

มีประโยชน์เมื่อมีการเปลี่ยนแปลงโครงสร้าง

### การค้นหาขั้นสูง

สำหรับการค้นหาที่ซับซ้อนขึ้น สามารถใช้เมธอด `Select`
`Select` สามารถรับ [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) จากแพ็คเกจ [`q`](https://godoc.org/github.com/asdine/storm/q) ได้หลายตัว

ตัวอย่าง Matcher ที่ใช้บ่อย:

```go
// เท่ากับ
q.Eq("Name", John)

// มากกว่า
q.Gt("Age", 7)

// น้อยกว่าหรือเท่ากับ
q.Lte("Age", 77)

// Regex กับชื่อที่ขึ้นต้นด้วย D
q.Re("Name", "^D")

// อยู่ใน slice ที่กำหนด
q.In("Group", []string{"Staff", "Admin"})

// เปรียบเทียบฟิลด์
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher สามารถผสมกับ `And`, `Or` และ `Not` ได้:

```go

// ตรงทุกเงื่อนไข
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// ตรงอย่างน้อยหนึ่งเงื่อนไข
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

สามารถดูรายการ Matcher ทั้งหมดได้ใน [documentation](https://godoc.org/github.com/asdine/storm/q#Matcher)

`Select` รับ matcher ได้หลายตัวและจะรวมเป็น `q.And()` อัตโนมัติ ไม่จำเป็นต้องระบุเอง ผลลัพธ์คือ [`Query`](https://godoc.org/github.com/asdine/storm#Query)

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

ชนิด `Query` มีเมธอดสำหรับกรองและเรียงลำดับเรคคอร์ด

```go
// จำกัดจำนวน
query = query.Limit(10)

// ข้าม
query = query.Skip(20)

// สามารถเรียกต่อเนื่องกันได้
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

และยังสามารถระบุวิธีดึงข้อมูลได้ด้วย

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

ตัวอย่างการใช้ `Select`:

```go
// ค้นหาผู้ใช้ที่มี ID อยู่ระหว่าง 10 ถึง 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// ใช้ matcher ซ้อนกัน
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// ค้นหาหลายเรคคอร์ด
err = query.Find(&users)
// หรือ
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// ค้นหาข้อมูลแรก
err = query.First(&user)
// หรือ
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// ลบข้อมูลทั้งหมดที่ตรงกับเงื่อนไข
err = query.Delete(new(User))

// ดึงข้อมูลทีละรายการ (เหมาะสำหรับ bucket ที่มีข้อมูลจำนวนมาก)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

ดู [เอกสารประกอบ](https://godoc.org/github.com/asdine/storm#Query) สำหรับรายการเมธอดทั้งหมด

### ธุรกรรม (Transactions)

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

### ตัวเลือก (Options)

ตัวเลือกของ Storm คือฟังก์ชันที่สามารถส่งไปตอนสร้างอินสแตนซ์ Storm คุณสามารถส่งตัวเลือกได้มากเท่าที่ต้องการ

#### BoltOptions

โดยปกติ Storm จะเปิดฐานข้อมูลด้วยโหมด `0600` และกำหนด timeout ไว้ที่ 1 วินาที  
คุณสามารถเปลี่ยนพฤติกรรมนี้ได้ด้วย `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

เพื่อเก็บข้อมูลใน BoltDB, Storm จะ marshal ข้อมูลเป็น JSON โดยดีฟอลต์ หากต้องการเปลี่ยนพฤติกรรมนี้ สามารถส่ง codec ที่ implement [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) ผ่าน [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) option:

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Codec ที่มีให้ใช้

คุณสามารถ implement `MarshalUnmarshaler` ของตัวเองได้อย่างง่ายดาย แต่ Storm มีรองรับในตัวสำหรับ [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (ดีฟอลต์), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob),  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) และ [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack)

สิ่งเหล่านี้สามารถใช้งานได้โดย import package ที่เกี่ยวข้องและใช้ codec นั้นในการตั้งค่า Storm ตัวอย่างด้านล่างนี้แสดงทุกแบบ (โดยไม่จัดการ error):

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

**ทิป**: การเพิ่มแท็ก Storm ให้กับไฟล์ Protobuf ที่ generate อาจจะยุ่งยาก วิธีที่ดีคือใช้ [เครื่องมือนี้](https://github.com/favadi/protoc-go-inject-tag) เพื่อ inject แท็กในขั้นตอน compile

#### ใช้การเชื่อมต่อ Bolt ที่มีอยู่แล้ว

คุณสามารถใช้การเชื่อมต่อที่มีอยู่แล้วและส่งให้ Storm ได้

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### โหมด Batch

สามารถเปิดโหมด batch เพื่อเร่งความเร็วการเขียนข้อมูลพร้อมกันหลายๆ รายการ (ดู [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Nodes และ nested buckets

Storm ใช้ประโยชน์จากฟีเจอร์ nested buckets ของ BoltDB โดยใช้ `storm.Node`  
`storm.Node` คืออ็อบเจ็กต์ที่ใช้โดย `storm.DB` สำหรับจัดการ bucket  
เพื่อสร้าง nested bucket และใช้ API เดียวกับ `storm.DB` สามารถใช้เมธอด `DB.From`

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

คุณยังสามารถ chain node เพื่อสร้างลำดับชั้นได้

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

คุณยังสามารถส่งลำดับชั้นทั้งหมดเป็น argument ให้ `From` ได้เช่นกัน:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### ตัวเลือก Node

Node ก็สามารถตั้งค่าตัวเลือกต่างๆ ได้เช่นกัน การเปิด option บน Node จะสร้างสำเนาใหม่เสมอ ดังนั้น Node จึง thread-safe

```go
n := db.From("my-node")
```

ให้ bolt.Tx transaction กับ Node

```go
n = n.WithTransaction(tx)
```

เปิด batch mode

```go
n = n.WithBatch(true)
```

ใช้ Codec

```go
n = n.WithCodec(gob.Codec)
```

## Simple Key/Value store

Storm สามารถใช้เป็น key/value store ที่เรียบง่ายและมีความเสถียร สามารถเก็บอะไรก็ได้  
key และ value สามารถเป็นชนิดใดก็ได้ตราบใดที่ key ไม่ใช่ค่า zero value

การบันทึกข้อมูล :

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

การดึงข้อมูล :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
```
db.Get("sessions", someObjectId, &details)
```

การลบข้อมูล :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

คุณสามารถค้นหาวิธีการที่มีประโยชน์อื่น ๆ ได้ใน [เอกสารประกอบ](https://godoc.org/github.com/asdine/storm#KeyValueStore)

## BoltDB

BoltDB ยังคงสามารถเข้าถึงได้ง่ายและสามารถใช้งานได้ตามปกติ

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

ธุรกรรมสามารถส่งต่อไปยัง Storm ได้เช่นกัน

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## ใบอนุญาต

MIT

## เครดิต

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---