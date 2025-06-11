# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm, [BoltDB](https://github.com/coreos/bbolt) için basit ve güçlü bir araç setidir. Temelde Storm, indeksler, veri depolama ve çekme için geniş bir yöntem yelpazesi, gelişmiş bir sorgu sistemi ve çok daha fazlasını sağlar.

Aşağıdaki örneklerin yanı sıra, [GoDoc’daki örneklere](https://godoc.org/github.com/asdine/storm#pkg-examples) da bakabilirsiniz.

_Daha gelişmiş sorgular ve [Badger](https://github.com/dgraph-io/badger) desteği için ayrıca [Genji](https://github.com/asdine/genji)'ye bakınız._

## İçindekiler

- [Başlangıç](#getting-started)
- [Storm’u İçe Aktarın](#import-storm)
- [Bir veritabanı açın](#open-a-database)
- [Basit CRUD sistemi](#simple-crud-system)
  - [Yapılarınızı tanımlayın](#declare-your-structures)
  - [Nesnenizi kaydedin](#save-your-object)
    - [Otomatik Artış](#auto-increment)
  - [Basit sorgular](#simple-queries)
    - [Bir nesne getirme](#fetch-one-object)
    - [Birden fazla nesne getirme](#fetch-multiple-objects)
    - [Tüm nesneleri getirme](#fetch-all-objects)
    - [Tüm nesneleri indeksle sıralı olarak getirme](#fetch-all-objects-sorted-by-index)
    - [Belirli bir aralıktaki nesneleri getirme](#fetch-a-range-of-objects)
    - [Önekiyle nesneleri getirme](#fetch-objects-by-prefix)
    - [Atla, Sınırla ve Tersine Çevir](#skip-limit-and-reverse)
    - [Bir nesneyi silme](#delete-an-object)
    - [Bir nesneyi güncelleme](#update-an-object)
    - [Bir nesneyi kaydetmeden önce bucket ve indeksleri başlatma](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Bir bucket’ı silme](#drop-a-bucket)
    - [Bir bucket’ı yeniden indeksleme](#re-index-a-bucket)
  - [Gelişmiş sorgular](#advanced-queries)
  - [İşlemler](#transactions)
  - [Seçenekler](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Sağlanan Codec’ler](#provided-codecs)
    - [Mevcut Bolt bağlantısını kullanma](#use-existing-bolt-connection)
    - [Batch modu](#batch-mode)
- [Düğümler ve iç içe bucket’lar](#nodes-and-nested-buckets)
  - [Düğüm seçenekleri](#node-options)
- [Basit Anahtar/Değer deposu](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Lisans](#license)
- [Katkıda Bulunanlar](#credits)

## Başlangıç

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Storm’u İçe Aktarın

```go
import "github.com/asdine/storm/v3"
```

## Bir veritabanı açın

Bir veritabanı açmanın hızlı yolu

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` davranışını özelleştirmek için birden fazla seçenek alabilir. Aşağıda [Seçenekler](#options) bölümüne bakınız.

## Basit CRUD sistemi

### Yapılarınızı tanımlayın

```go
type User struct {
  ID int // birincil anahtar
  Group string `storm:"index"` // bu alan indekslenecek
  Email string `storm:"unique"` // bu alan benzersiz olacak şekilde indekslenecek
  Name string // bu alan indekslenmeyecek
  Age int `storm:"index"`
}
```

Birincil anahtar, sıfır olmayan herhangi bir türde olabilir. Storm, `id` etiketini arar, yoksa `ID` adlı bir alan arar.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// birincil anahtar
  Group string `storm:"index"` // bu alan indekslenecek
  Email string `storm:"unique"` // bu alan benzersiz olacak şekilde indekslenecek
  Name string // bu alan indekslenmeyecek
}
```

Storm, iç içe yapılarda `inline` etiketiyle etiketleri yönetir

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

### Nesnenizi kaydedin

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

Hepsi bu kadar.

`Save`, gerekli tüm indeksleri ve bucket’ları oluşturur veya günceller, benzersiz kısıtlamaları kontrol eder ve nesneyi depoya kaydeder.

#### Otomatik Artış

Storm, tamsayı değerlerini otomatik olarak artırabilir, böylece nesnelerinizi kaydederken bununla ilgilenmenize gerek kalmaz. Ayrıca, yeni değer otomatik olarak alanınıza eklenir.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // otomatik artışlı birincil anahtar
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // başlangıç değeri ayarlanabilir
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

### Basit sorgular

Herhangi bir nesne, indeksli olsun olmasın, getirilebilir. Storm, mümkünse indeksleri kullanır, aksi takdirde [sorgu sistemini](#advanced-queries) kullanır.

#### Bir nesne getirme

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Birden fazla nesne getirme

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Tüm nesneleri getir

```go
var users []User
err := db.All(&users)
```

#### Nesneleri indekse göre sıralı getir

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Nesnelerin bir aralığını getir

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Prefix ile nesneleri getir

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Atla, Limit ve Tersine Çevir

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

#### Bir nesneyi sil

```go
err := db.DeleteStruct(&user)
```

#### Bir nesneyi güncelle

```go
// Birden fazla alanı güncelle
// Yalnızca sıfır olmayan alanlar için çalışır (ör. Name "" olamaz, Age 0 olamaz)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Tek bir alanı güncelle
// Sıfır değerli alanlar için de çalışır (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Bir nesne kaydedilmeden önce bucket ve indexleri başlat

```go
err := db.Init(&User{})
```

Uygulamanızı başlatırken faydalıdır

#### Bir bucket sil

Struct ile kullanımı

```go
err := db.Drop(&User)
```

Bucket ismi ile kullanımı

```go
err := db.Drop("User")
```

#### Bir bucket'ı yeniden indeksle

```go
err := db.ReIndex(&User{})
```

Yapı değiştiğinde faydalıdır

### Gelişmiş sorgular

Daha karmaşık sorgular için `Select` metodunu kullanabilirsiniz.
`Select`, [`q`](https://godoc.org/github.com/asdine/storm/q) paketinden herhangi bir sayıda [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) alır.

İşte bazı yaygın Matcher'lar:

```go
// Eşitlik
q.Eq("Name", John)

// Tam olarak büyük
q.Gt("Age", 7)

// Küçük veya eşit
q.Lte("Age", 77)

// İsmi D harfi ile başlayanlar için Regex
q.Re("Name", "^D")

// Verilen değer dizisinde olanlar
q.In("Group", []string{"Staff", "Admin"})

// Alanları karşılaştırma
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher'lar ayrıca `And`, `Or` ve `Not` ile birleştirilebilir:

```go

// Hepsi eşleşirse
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Biri eşleşirse
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

Tüm listeyi [dokümantasyonda](https://godoc.org/github.com/asdine/storm/q#Matcher) bulabilirsiniz.

`Select`, herhangi bir sayıda matcher alır ve onları bir `q.And()` ile sarar, bu yüzden ayrıca belirtmek gerekmez. Bir [`Query`](https://godoc.org/github.com/asdine/storm#Query) tipi döndürür.

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

`Query` tipi, kayıtları filtrelemek ve sıralamak için metodlar içerir.

```go
// Limit
query = query.Limit(10)

// Atla
query = query.Skip(20)

// Fonksiyonlar zincirlenebilir
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Ayrıca nasıl getirileceğini belirtmek için de kullanılır.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

`Select` ile örnekler:

```go
// ID'si 10 ile 100 arasında olan tüm kullanıcıları bul
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// İç içe matcher'lar
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Birden fazla kaydı bul
err = query.Find(&users)
// veya
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// İlk kaydı bul
err = query.First(&user)
// veya
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Eşleşen tüm kayıtları sil
err = query.Delete(new(User))

// Kayıtları teker teker getirme (bucket çok sayıda kayıt içerdiğinde kullanışlıdır)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Yöntemlerin tam listesi için [dokümantasyona](https://godoc.org/github.com/asdine/storm#Query) bakın.

### Transactionlar

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

### Seçenekler

Storm seçenekleri, Storm örneğinizi oluştururken geçilebilen fonksiyonlardır. İstediğiniz kadar seçenek verebilirsiniz.

#### BoltOptions

Varsayılan olarak, Storm veritabanını `0600` modunda ve bir saniyelik zaman aşımıyla açar.
Bu davranışı `BoltOptions` kullanarak değiştirebilirsiniz.

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Verileri BoltDB'de saklamak için, Storm varsayılan olarak JSON ile marshal işlemi yapar. Bu davranışı değiştirmek isterseniz, [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) arayüzünü uygulayan bir codec'i [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) seçeneğiyle geçebilirsiniz:

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Sağlanan Codec'ler

Kendi `MarshalUnmarshaler`'ınızı kolayca uygulayabilirsiniz, ancak Storm yerleşik olarak [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (varsayılan), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) ve [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack) desteğiyle gelir.

Bunlar, ilgili paketi import ederek ve bu codec'i Storm'u yapılandırmak için kullanarak kullanılabilir. Aşağıdaki örnek tüm varyantları göstermektedir (hatalar kontrol edilmeden):

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

**İpucu**: Oluşturulan Protobuf dosyalarına Storm etiketleri eklemek zor olabilir. Derleme sırasında etiketleri eklemek için [bu aracı](https://github.com/favadi/protoc-go-inject-tag) kullanmak iyi bir çözümdür.

#### Mevcut Bolt bağlantısını kullanma

Mevcut bir bağlantıyı kullanabilir ve Storm'a iletebilirsiniz

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Toplu (Batch) mod

Eşzamanlı yazma işlemlerini hızlandırmak için toplu mod etkinleştirilebilir ([Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions) bölümüne bakın)

```go
db := storm.Open("my.db", storm.Batch())
```

## Düğümler ve iç içe kovalar (nested buckets)

Storm, BoltDB'nin iç içe kova özelliğinden `storm.Node` kullanarak faydalanır.
Bir `storm.Node`, bir kovayı yönetmek için `storm.DB` tarafından kullanılan temel nesnedir.
Bir iç içe kova oluşturmak ve `storm.DB` ile aynı API'yi kullanmak için `DB.From` metodunu kullanabilirsiniz.

```go
repo := db.From("repo")

err := repo.Save(&Issue{
  Title: "Daha fazla özellik istiyorum",
  Author: user.ID,
})

err = repo.Save(newRelease("0.10"))

var issues []Issue
err = repo.Find("Author", user.ID, &issues)

var release Release
err = repo.One("Tag", "0.10", &release)
```

Düğümleri zincirleyerek bir hiyerarşi de oluşturabilirsiniz

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Hatta tüm hiyerarşiyi `From`'a argüman olarak da geçebilirsiniz:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Düğüm seçenekleri

Bir Düğüm de yapılandırılabilir. Bir Düğümde bir seçenek aktive edildiğinde kopya oluşturulur, bu nedenle bir Düğüm her zaman thread-safe'dir.

```go
n := db.From("my-node")
```

Düğüme bir bolt.Tx transaction verin

```go
n = n.WithTransaction(tx)
```

Toplu modu etkinleştir

```go
n = n.WithBatch(true)
```

Bir Codec kullan

```go
n = n.WithCodec(gob.Codec)
```

## Basit Anahtar/Değer (Key/Value) depolama

Storm, her şeyi saklayabilen basit, sağlam bir anahtar/değer deposu olarak kullanılabilir.
Anahtar ve değer, anahtar sıfır değer olmadığı sürece herhangi bir türde olabilir.

Veri kaydetme:

```go
db.Set("logs", time.Now(), "Kahvaltımı yiyorum adamım")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Veri çekme:

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Veri silme :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Diğer faydalı metodları [dokümantasyon](https://godoc.org/github.com/asdine/storm#KeyValueStore) kısmında bulabilirsiniz.

## BoltDB

BoltDB hâlâ kolayca erişilebilir ve her zamanki gibi kullanılabilir

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Bir işlem Storm’a da aktarılabilir

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Lisans

MIT

## Katkıda Bulunanlar

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---