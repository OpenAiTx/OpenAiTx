# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm هو مجموعة أدوات بسيطة وقوية لـ [BoltDB](https://github.com/coreos/bbolt). بشكل أساسي، يوفر Storm الفهارس، ونطاقًا واسعًا من الطرق لتخزين وجلب البيانات، ونظام استعلام متقدم، وأكثر من ذلك بكثير.

بالإضافة إلى الأمثلة أدناه، راجع أيضًا [الأمثلة في GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_للحصول على استعلامات موسعة ودعم لـ [Badger](https://github.com/dgraph-io/badger)، راجع أيضًا [Genji](https://github.com/asdine/genji)_

## جدول المحتويات

- [البدء](#getting-started)
- [استيراد Storm](#import-storm)
- [فتح قاعدة بيانات](#open-a-database)
- [نظام CRUD بسيط](#simple-crud-system)
  - [تعريف الهياكل](#declare-your-structures)
  - [حفظ الكائن](#save-your-object)
    - [الزيادة التلقائية](#auto-increment)
  - [استعلامات بسيطة](#simple-queries)
    - [جلب كائن واحد](#fetch-one-object)
    - [جلب عدة كائنات](#fetch-multiple-objects)
    - [جلب جميع الكائنات](#fetch-all-objects)
    - [جلب جميع الكائنات مرتبة حسب الفهرس](#fetch-all-objects-sorted-by-index)
    - [جلب نطاق من الكائنات](#fetch-a-range-of-objects)
    - [جلب الكائنات حسب البادئة](#fetch-objects-by-prefix)
    - [تخطي، حد، وعكس](#skip-limit-and-reverse)
    - [حذف كائن](#delete-an-object)
    - [تحديث كائن](#update-an-object)
    - [تهيئة الحاويات والفهارس قبل حفظ الكائن](#initialize-buckets-and-indexes-before-saving-an-object)
    - [حذف حاوية](#drop-a-bucket)
    - [إعادة فهرسة حاوية](#re-index-a-bucket)
  - [استعلامات متقدمة](#advanced-queries)
  - [المعاملات](#transactions)
  - [الخيارات](#options)
    - [خيارات Bolt](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [الترميزات المضمنة](#provided-codecs)
    - [استخدام اتصال Bolt موجود](#use-existing-bolt-connection)
    - [وضع الدُفعات](#batch-mode)
- [العُقد والحاويات المتداخلة](#nodes-and-nested-buckets)
  - [خيارات العقدة](#node-options)
- [مخزن مفتاح/قيمة بسيط](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [الترخيص](#license)
- [الاعتمادات](#credits)

## البدء

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## استيراد Storm

```go
import "github.com/asdine/storm/v3"
```

## فتح قاعدة بيانات

طريقة سريعة لفتح قاعدة بيانات

```go
db, err := storm.Open("my.db")

defer db.Close()
```

يمكن أن يستقبل `Open` عدة خيارات لتخصيص طريقة عمله. راجع [الخيارات](#options) أدناه

## نظام CRUD بسيط

### تعريف الهياكل

```go
type User struct {
  ID int // المفتاح الأساسي
  Group string `storm:"index"` // سيتم فهرسة هذا الحقل
  Email string `storm:"unique"` // سيتم فهرسة هذا الحقل بقيد فريد
  Name string // هذا الحقل لن يتم فهرسته
  Age int `storm:"index"`
}
```

يمكن أن يكون المفتاح الأساسي من أي نوع طالما أنه ليس قيمة صفرية. سيبحث Storm عن الوسم `id`، إذا لم يكن موجودًا سيبحث Storm عن حقل باسم `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// المفتاح الأساسي
  Group string `storm:"index"` // سيتم فهرسة هذا الحقل
  Email string `storm:"unique"` // سيتم فهرسة هذا الحقل بقيد فريد
  Name string // هذا الحقل لن يتم فهرسته
}
```

يتعامل Storm مع الوسوم في الهياكل المتداخلة باستخدام الوسم `inline`

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

### حفظ الكائن

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

هذا كل شيء.

يقوم `Save` بإنشاء أو تحديث جميع الفهارس والحاويات المطلوبة، ويتحقق من القيود الفريدة ويحفظ الكائن في المخزن.

#### الزيادة التلقائية

يمكن لـ Storm زيادة القيم الصحيحة تلقائيًا حتى لا تقلق بشأن ذلك عند حفظ الكائنات الخاصة بك. أيضًا، يتم إدراج القيمة الجديدة تلقائيًا في الحقل الخاص بك.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // مفتاح أساسي مع زيادة تلقائية
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // يمكن تعيين القيمة الابتدائية
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

### استعلامات بسيطة

يمكن جلب أي كائن سواء كان مفهرسًا أو غير مفهرس. يستخدم Storm الفهارس عندما تكون متاحة، وإلا يستخدم [نظام الاستعلام](#advanced-queries).

#### جلب كائن واحد

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### جلب عدة كائنات

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### جلب جميع الكائنات

```go
var users []User
err := db.All(&users)
```

#### جلب جميع الكائنات مرتبة حسب الفهرس

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### جلب نطاق من الكائنات

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### جلب الكائنات حسب البادئة

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### التجاوز، التحديد والعكس

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

#### حذف كائن

```go
err := db.DeleteStruct(&user)
```

#### تحديث كائن

```go
// تحديث عدة حقول
// يعمل فقط مع الحقول التي ليست بقيمتها الصفرية (مثلاً: لا يمكن أن يكون Name = "" أو Age = 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// تحديث حقل واحد
// يعمل أيضاً مع الحقول ذات القيم الصفرية (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### تهيئة الحاويات والفهارس قبل حفظ الكائن

```go
err := db.Init(&User{})
```

مفيد عند بدء تشغيل التطبيق الخاص بك

#### حذف حاوية

باستخدام البنية الهيكلية

```go
err := db.Drop(&User)
```

باستخدام اسم الحاوية

```go
err := db.Drop("User")
```

#### إعادة فهرسة الحاوية

```go
err := db.ReIndex(&User{})
```

مفيد عند تغيير البنية الهيكلية

### الاستعلامات المتقدمة

للاستعلامات الأكثر تعقيدًا، يمكنك استخدام دالة `Select`.
تأخذ `Select` أي عدد من [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) من حزمة [`q`](https://godoc.org/github.com/asdine/storm/q).

إليك بعض المطابقات الشائعة:

```go
// المساواة
q.Eq("Name", John)

// أكبر من بشكل صارم
q.Gt("Age", 7)

// أصغر من أو يساوي
q.Lte("Age", 77)

// تعبير نمطي (Regex) لاسم يبدأ بالحرف D
q.Re("Name", "^D")

// ضمن مصفوفة القيم المحددة
q.In("Group", []string{"Staff", "Admin"})

// مقارنة الحقول
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

يمكن أيضًا دمج المطابقات باستخدام `And`، `Or` و `Not`:

```go

// يطابق إذا تطابقت جميع الشروط
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// يطابق إذا تحقق شرط واحد على الأقل
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

يمكنك العثور على القائمة الكاملة في [التوثيق](https://godoc.org/github.com/asdine/storm/q#Matcher).

تأخذ `Select` أي عدد من المطابقات وتغلفها تلقائيًا داخل `q.And()` لذا ليس من الضروري تحديدها. وتُرجع نوع [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

يحتوي نوع `Query` على طرق لتصفية وترتيب السجلات.

```go
// التحديد
query = query.Limit(10)

// التجاوز
query = query.Skip(20)

// يمكن أيضًا ربط الاستدعاءات
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

وكذلك لتحديد كيفية جلبها.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

أمثلة مع `Select`:

```go
// إيجاد جميع المستخدمين الذين تتراوح معرفاتهم بين 10 و 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// مطابقات متداخلة
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// إيجاد عدة سجلات
err = query.Find(&users)
// أو
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// إيجاد أول سجل
err = query.First(&user)
// أو
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// حذف جميع السجلات المطابقة
err = query.Delete(new(User))

// جلب السجلات واحداً تلو الآخر (مفيد عندما يحتوي الحاوي على الكثير من السجلات)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

راجع [التوثيق](https://godoc.org/github.com/asdine/storm#Query) لقائمة كاملة من الدوال.

### المعاملات

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

### الخيارات

خيارات Storm هي دوال يمكن تمريرها عند إنشاء مثيل Storm الخاص بك. يمكنك تمرير أي عدد من الخيارات.

#### BoltOptions

بشكل افتراضي، يقوم Storm بفتح قاعدة البيانات بالوضع `0600` ومدة انتظار ثانية واحدة.
يمكنك تغيير هذا السلوك باستخدام `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

لحفظ البيانات في BoltDB، يقوم Storm بتحويلها إلى JSON بشكل افتراضي. إذا رغبت في تغيير هذا السلوك يمكنك تمرير codec ينفذ [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) عبر خيار [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### codecs الموفرة

يمكنك بسهولة تنفيذ `MarshalUnmarshaler` الخاص بك، لكن Storm يأتي بدعم مدمج لـ [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (افتراضي)، [GOB](https://godoc.org/github.com/asdine/storm/codec/gob)،  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal)، [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) و [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

يمكنك استخدام هذه الأكواد عبر استيراد الحزمة المناسبة واستخدام هذا الـ codec لتكوين Storm. المثال أدناه يوضح كل المتغيرات (دون معالجة أخطاء مناسبة):

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

**نصيحة**: إضافة وسوم Storm لملفات Protobuf المولدة قد يكون صعباً. حل جيد هو استخدام [هذه الأداة](https://github.com/favadi/protoc-go-inject-tag) لإدراج الوسوم أثناء الترجمة.

#### استخدام اتصال Bolt موجود

يمكنك استخدام اتصال موجود وتمريره إلى Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### وضع الدفعية (Batch mode)

يمكن تفعيل وضع الدفعية لتسريع عمليات الكتابة المتزامنة (راجع [معاملات القراءة/الكتابة الدفعية](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## العقد والحاويات المتداخلة

يستفيد Storm من ميزة الحاويات المتداخلة في BoltDB باستخدام `storm.Node`.
العقدة `storm.Node` هي الكائن الأساسي الذي يستخدمه `storm.DB` للتحكم في الحاوي.
لإنشاء حاوي متداخل واستخدام نفس واجهة برمجة التطبيقات الخاصة بـ `storm.DB`، يمكنك استخدام الدالة `DB.From`.

```go
repo := db.From("repo")

err := repo.Save(&Issue{
  Title: "أريد المزيد من الميزات",
  Author: user.ID,
})

err = repo.Save(newRelease("0.10"))

var issues []Issue
err = repo.Find("Author", user.ID, &issues)

var release Release
err = repo.One("Tag", "0.10", &release)
```

يمكنك أيضاً ربط العقد لإنشاء تسلسل هرمي

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

يمكنك حتى تمرير التسلسل الهرمي بالكامل كوسائط إلى `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### خيارات العقدة

يمكن أيضاً تكوين العقدة. تفعيل الخيار على العقدة ينشئ نسخة، لذا فإن العقدة دائماً آمنة للخيوط.

```go
n := db.From("my-node")
```

إعطاء معاملة bolt.Tx للعقدة

```go
n = n.WithTransaction(tx)
```

تفعيل وضع الدفعية

```go
n = n.WithBatch(true)
```

استخدام Codec

```go
n = n.WithCodec(gob.Codec)
```

## مخزن مفاتيح/قيم بسيط

يمكن استخدام Storm كمخزن مفاتيح/قيم بسيط وموثوق يمكنه حفظ أي شيء.
المفتاح والقيمة يمكن أن يكونا من أي نوع طالما أن المفتاح ليس قيمة صفرية.

حفظ البيانات :

```go
db.Set("logs", time.Now(), "أنا آكل فطوري الآن")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

جلب البيانات :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
```
db.Get("sessions", someObjectId, &details)
```

حذف البيانات :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

يمكنك العثور على طرق مفيدة أخرى في [التوثيق](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

لا يزال بإمكانك الوصول إلى BoltDB بسهولة ويمكن استخدامه كالمعتاد

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

يمكن أيضًا تمرير المعاملة إلى Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## الرخصة

MIT

## الاعتمادات

- [أسدين الحريشي](https://github.com/asdine)
- [بيورن إريك بيديرسن](https://github.com/bep)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---