# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

استورم یک ابزار ساده و قدرتمند برای [BoltDB](https://github.com/coreos/bbolt) است. به طور کلی، استورم اندیس‌ها، مجموعه‌ای گسترده از متدها برای ذخیره و واکشی داده‌ها، یک سیستم پرس‌وجوی پیشرفته و امکانات بسیار دیگری را فراهم می‌کند.

علاوه بر مثال‌های زیر، [مثال‌های GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples) را نیز ببینید.

_برای پرس‌وجوهای پیشرفته‌تر و پشتیبانی از [Badger](https://github.com/dgraph-io/badger)، به [Genji](https://github.com/asdine/genji) نیز مراجعه کنید_

## فهرست مطالب

- [شروع کار](#getting-started)
- [ایمپورت کردن استورم](#import-storm)
- [باز کردن یک پایگاه داده](#open-a-database)
- [سیستم CRUD ساده](#simple-crud-system)
  - [تعریف ساختارها](#declare-your-structures)
  - [ذخیره شیء خود](#save-your-object)
    - [افزایش خودکار](#auto-increment)
  - [پرس‌وجوهای ساده](#simple-queries)
    - [واکشی یک شیء](#fetch-one-object)
    - [واکشی چندین شیء](#fetch-multiple-objects)
    - [واکشی همه اشیاء](#fetch-all-objects)
    - [واکشی همه اشیاء بر اساس اندیس مرتب شده](#fetch-all-objects-sorted-by-index)
    - [واکشی محدوده‌ای از اشیاء](#fetch-a-range-of-objects)
    - [واکشی اشیاء با پیشوند](#fetch-objects-by-prefix)
    - [Skip، Limit و Reverse](#skip-limit-and-reverse)
    - [حذف یک شیء](#delete-an-object)
    - [به‌روزرسانی یک شیء](#update-an-object)
    - [مقدارسازی سطل‌ها و اندیس‌ها پیش از ذخیره شیء](#initialize-buckets-and-indexes-before-saving-an-object)
    - [حذف یک سطل](#drop-a-bucket)
    - [بازسازی اندیس یک سطل](#re-index-a-bucket)
  - [پرس‌وجوهای پیشرفته](#advanced-queries)
  - [تراکنش‌ها](#transactions)
  - [گزینه‌ها](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [کدک‌های ارائه شده](#provided-codecs)
    - [استفاده از اتصال Bolt موجود](#use-existing-bolt-connection)
    - [حالت Batch](#batch-mode)
- [گره‌ها و سطل‌های تو در تو](#nodes-and-nested-buckets)
  - [گزینه‌های گره](#node-options)
- [ذخیره‌ساز ساده کلید/مقدار](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [مجوز](#license)
- [اعتبارات](#credits)

## شروع کار

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## ایمپورت کردن استورم

```go
import "github.com/asdine/storm/v3"
```

## باز کردن یک پایگاه داده

روش سریع برای باز کردن یک پایگاه داده

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` می‌تواند گزینه‌های متعددی برای سفارشی‌سازی نحوه عملکرد دریافت کند. [گزینه‌ها](#options) را در ادامه ببینید

## سیستم CRUD ساده

### تعریف ساختارها

```go
type User struct {
  ID int // کلید اصلی
  Group string `storm:"index"` // این فیلد ایندکس خواهد شد
  Email string `storm:"unique"` // این فیلد با محدودیت یکتا ایندکس خواهد شد
  Name string // این فیلد ایندکس نخواهد شد
  Age int `storm:"index"`
}
```

کلید اصلی می‌تواند از هر نوعی باشد به شرط اینکه مقدار صفر نباشد. استورم به دنبال تگ `id` می‌گردد؛ اگر پیدا نشود به دنبال فیلدی با نام `ID` می‌گردد.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// کلید اصلی
  Group string `storm:"index"` // این فیلد ایندکس خواهد شد
  Email string `storm:"unique"` // این فیلد با محدودیت یکتا ایندکس خواهد شد
  Name string // این فیلد ایندکس نخواهد شد
}
```

استورم تگ‌ها را در ساختارهای تو در تو با تگ `inline` مدیریت می‌کند

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

### ذخیره شیء خود

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

همین.

`Save` تمام اندیس‌ها و سطل‌های مورد نیاز را ایجاد یا به‌روزرسانی می‌کند، محدودیت‌های یکتا را بررسی کرده و شیء را در فروشگاه ذخیره می‌کند.

#### افزایش خودکار

استورم می‌تواند مقادیر عدد صحیح را به صورت خودکار افزایش دهد تا هنگام ذخیره اشیاء نگرانی از این بابت نداشته باشید. همچنین مقدار جدید به طور خودکار در فیلد شما قرار می‌گیرد.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // کلید اصلی با افزایش خودکار
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // مقدار اولیه را می‌توان تعیین کرد
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

### پرس‌وجوهای ساده

هر شیء، فارغ از ایندکس بودن یا نبودن، قابل واکشی است. استورم در صورت وجود، از اندیس‌ها استفاده می‌کند و در غیر این صورت از [سیستم پرس‌وجو](#advanced-queries) بهره می‌برد.

#### واکشی یک شیء

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### واکشی چندین شیء

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### واکشی همه اشیاء

```go
var users []User
err := db.All(&users)
```

#### واکشی همه اشیاء مرتب‌شده بر اساس ایندکس

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### واکشی محدوده‌ای از اشیاء

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### واکشی اشیاء بر اساس پیشوند

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### رد کردن، محدود کردن و معکوس کردن

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

#### حذف یک شیء

```go
err := db.DeleteStruct(&user)
```

#### به‌روزرسانی یک شیء

```go
// به‌روزرسانی چندین فیلد
// فقط برای فیلدهایی که مقدار صفر ندارند کار می‌کند (مثلاً Name نمی‌تواند "" باشد، Age نمی‌تواند 0 باشد)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// به‌روزرسانی یک فیلد
// برای فیلدهایی با مقدار صفر نیز کار می‌کند (0، false، "" و ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### مقداردهی اولیه باکت‌ها و ایندکس‌ها قبل از ذخیره یک شیء

```go
err := db.Init(&User{})
```

مفید هنگام شروع برنامه شما

#### حذف یک باکت

با استفاده از ساختار

```go
err := db.Drop(&User)
```

با استفاده از نام باکت

```go
err := db.Drop("User")
```

#### بازایندکس کردن یک باکت

```go
err := db.ReIndex(&User{})
```

مفید هنگامی که ساختار تغییر کرده است

### کوئری‌های پیشرفته

برای کوئری‌های پیچیده‌تر، می‌توانید از متد `Select` استفاده کنید.
`Select` هر تعداد [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) از پکیج [`q`](https://godoc.org/github.com/asdine/storm/q) را می‌پذیرد.

در اینجا برخی Matcherهای متداول آمده است:

```go
// تساوی
q.Eq("Name", John)

// بزرگتر به‌صورت سختگیرانه
q.Gt("Age", 7)

// کوچکتر یا مساوی
q.Lte("Age", 77)

// رجکس با نامی که با حرف D شروع می‌شود
q.Re("Name", "^D")

// در میان یک آرایه از مقادیر
q.In("Group", []string{"Staff", "Admin"})

// مقایسه فیلدها
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcherها می‌توانند با `And`، `Or` و `Not` ترکیب شوند:

```go

// اگر همه تطابق داشته باشند
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// اگر یکی از آن‌ها تطابق داشته باشد
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

می‌توانید لیست کامل را در [مستندات](https://godoc.org/github.com/asdine/storm/q#Matcher) پیدا کنید.

`Select` هر تعداد Matcher را می‌پذیرد و آن‌ها را در یک `q.And()` قرار می‌دهد، بنابراین لازم نیست آن را مشخص کنید. این متد یک نوع [`Query`](https://godoc.org/github.com/asdine/storm#Query) بازمی‌گرداند.

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

نوع `Query` شامل متدهایی برای فیلتر و مرتب‌سازی رکوردها است.

```go
// محدود کردن
query = query.Limit(10)

// رد کردن
query = query.Skip(20)

// می‌توان فراخوانی‌ها را زنجیره کرد
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

همچنین برای مشخص کردن نحوه واکشی رکوردها.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

مثال‌هایی با `Select`:

```go
// یافتن همه کاربران با شناسه بین 10 تا 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Matcherهای تو در تو
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// یافتن چندین رکورد
err = query.Find(&users)
// یا
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// یافتن اولین رکورد
err = query.First(&user)
// یا
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// حذف تمامی رکوردهای مطابق
err = query.Delete(new(User))

// دریافت رکوردها به صورت یکی یکی (مفید زمانی که سطل حاوی تعداد زیادی رکورد است)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

برای لیست کامل متدها به [مستندات](https://godoc.org/github.com/asdine/storm#Query) مراجعه کنید.

### تراکنش‌ها

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

### گزینه‌ها

گزینه‌های استورم توابعی هستند که هنگام ساخت نمونه‌ی استورم می‌توانید آنها را ارسال کنید. هر تعداد گزینه می‌توانید ارسال نمایید.

#### BoltOptions

به طور پیش‌فرض، استورم دیتابیس را با مد `0600` و تایم‌اوت یک ثانیه باز می‌کند.
می‌توانید این رفتار را با استفاده از `BoltOptions` تغییر دهید.

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

برای ذخیره داده‌ها در BoltDB، استورم به طور پیش‌فرض آن را به صورت JSON مارشال می‌کند. اگر می‌خواهید این رفتار را تغییر دهید، می‌توانید یک کدک که [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) را پیاده‌سازی می‌کند از طریق گزینه‌ی [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) ارسال کنید:

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### کدک‌های فراهم‌شده

شما به راحتی می‌توانید `MarshalUnmarshaler` خود را پیاده‌سازی کنید، اما استورم به طور پیش‌فرض از [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (پیش‌فرض)، [GOB](https://godoc.org/github.com/asdine/storm/codec/gob)،  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal)، [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) و [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack) پشتیبانی می‌کند.

این کدک‌ها را می‌توانید با import کردن پکیج مربوطه و استفاده از آن به عنوان کدک تنظیم Storm استفاده کنید. مثال زیر همه واریانت‌ها را نشان می‌دهد (بدون هندل صحیح خطا):

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

**نکته**: افزودن تگ‌های استورم به فایل‌های Protobuf تولید شده می‌تواند دشوار باشد. یک راه حل خوب استفاده از [این ابزار](https://github.com/favadi/protoc-go-inject-tag) برای تزریق تگ‌ها هنگام کامپایل است.

#### استفاده از اتصال موجود Bolt

می‌توانید از یک اتصال موجود استفاده کرده و آن را به استورم ارسال کنید.

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### حالت Batch

حالت Batch را می‌توان برای افزایش سرعت نوشتن همزمان فعال کرد (نگاه کنید به [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## نودها و باکت‌های تو در تو

استورم با استفاده از قابلیت nested buckets در BoltDB از طریق `storm.Node` بهره می‌برد.
یک `storm.Node` شیء پایه‌ای است که توسط `storm.DB` برای مدیریت یک باکت استفاده می‌شود.
برای ساخت یک باکت تو در تو و استفاده از همان API مشابه `storm.DB`، می‌توانید از متد `DB.From` استفاده کنید.

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

همچنین می‌توانید نودها را به هم زنجیر کنید تا یک سلسله مراتب بسازید

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

حتی می‌توانید کل سلسله مراتب را به عنوان آرگومان به `From` ارسال کنید:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### گزینه‌های Node

یک Node را نیز می‌توان پیکربندی کرد. فعال‌سازی یک گزینه روی یک Node باعث ایجاد یک کپی می‌شود، بنابراین یک Node همیشه thread-safe است.

```go
n := db.From("my-node")
```

دادن یک تراکنش bolt.Tx به Node

```go
n = n.WithTransaction(tx)
```

فعال کردن حالت batch

```go
n = n.WithBatch(true)
```

استفاده از یک Codec

```go
n = n.WithCodec(gob.Codec)
```

## فروشگاه ساده کلید/مقدار

استورم می‌تواند به عنوان یک فروشگاه کلید/مقدار ساده و مقاوم که می‌تواند هر چیزی را ذخیره کند استفاده شود.
کلید و مقدار می‌توانند از هر نوعی باشند به شرط آنکه کلید مقدار صفر نباشد.

ذخیره داده:

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

دریافت داده:

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

حذف داده‌ها:

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

شما می‌توانید سایر متدهای مفید را در [مستندات](https://godoc.org/github.com/asdine/storm#KeyValueStore) پیدا کنید.

## BoltDB

BoltDB همچنان به راحتی قابل دسترسی است و می‌توانید مانند گذشته از آن استفاده کنید

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

می‌توانید یک تراکنش را نیز به Storm منتقل کنید

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## مجوز

MIT

## اعتبارها

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---