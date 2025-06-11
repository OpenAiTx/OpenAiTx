# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm adalah toolkit sederhana dan kuat untuk [BoltDB](https://github.com/coreos/bbolt). Pada dasarnya, Storm menyediakan indeks, berbagai metode untuk menyimpan dan mengambil data, sistem query yang canggih, dan masih banyak lagi.

Selain contoh di bawah, lihat juga [contoh di GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Untuk query yang diperluas dan dukungan untuk [Badger](https://github.com/dgraph-io/badger), lihat juga [Genji](https://github.com/asdine/genji)_

## Daftar Isi

- [Memulai](#getting-started)
- [Impor Storm](#import-storm)
- [Membuka database](#open-a-database)
- [Sistem CRUD sederhana](#simple-crud-system)
  - [Deklarasi struktur Anda](#declare-your-structures)
  - [Simpan objek Anda](#save-your-object)
    - [Auto Increment](#auto-increment)
  - [Query sederhana](#simple-queries)
    - [Ambil satu objek](#fetch-one-object)
    - [Ambil beberapa objek](#fetch-multiple-objects)
    - [Ambil semua objek](#fetch-all-objects)
    - [Ambil semua objek yang diurutkan berdasarkan indeks](#fetch-all-objects-sorted-by-index)
    - [Ambil rentang objek](#fetch-a-range-of-objects)
    - [Ambil objek berdasarkan prefix](#fetch-objects-by-prefix)
    - [Skip, Limit dan Reverse](#skip-limit-and-reverse)
    - [Hapus sebuah objek](#delete-an-object)
    - [Perbarui sebuah objek](#update-an-object)
    - [Inisialisasi bucket dan indeks sebelum menyimpan objek](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Drop sebuah bucket](#drop-a-bucket)
    - [Re-index sebuah bucket](#re-index-a-bucket)
  - [Query lanjutan](#advanced-queries)
  - [Transaksi](#transactions)
  - [Opsi](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Codec yang disediakan](#provided-codecs)
    - [Gunakan koneksi Bolt yang sudah ada](#use-existing-bolt-connection)
    - [Mode batch](#batch-mode)
- [Node dan nested bucket](#nodes-and-nested-buckets)
  - [Opsi Node](#node-options)
- [Penyimpanan Key/Value sederhana](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Lisensi](#license)
- [Kredit](#credits)

## Memulai

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Impor Storm

```go
import "github.com/asdine/storm/v3"
```

## Membuka database

Cara cepat untuk membuka database

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` dapat menerima beberapa opsi untuk menyesuaikan perilakunya. Lihat [Opsi](#options) di bawah

## Sistem CRUD sederhana

### Deklarasi struktur Anda

```go
type User struct {
  ID int // primary key
  Group string `storm:"index"` // field ini akan diindeks
  Email string `storm:"unique"` // field ini akan diindeks dengan constraint unik
  Name string // field ini tidak akan diindeks
  Age int `storm:"index"`
}
```

Primary key dapat berupa tipe apapun selama nilainya bukan nol. Storm akan mencari tag `id`, jika tidak ada Storm akan mencari field bernama `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// primary key
  Group string `storm:"index"` // field ini akan diindeks
  Email string `storm:"unique"` // field ini akan diindeks dengan constraint unik
  Name string // field ini tidak akan diindeks
}
```

Storm menangani tag pada struktur bertingkat dengan tag `inline`

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

### Simpan objek Anda

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

Itu saja.

`Save` akan membuat atau memperbarui semua indeks dan bucket yang dibutuhkan, memeriksa constraint unik dan menyimpan objek ke dalam penyimpanan.

#### Auto Increment

Storm dapat melakukan auto increment pada nilai integer sehingga Anda tidak perlu khawatir tentang hal itu saat menyimpan objek Anda. Selain itu, nilai baru secara otomatis dimasukkan ke dalam field Anda.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // primary key dengan auto increment
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // nilai awal dapat diatur
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

### Query sederhana

Objek apapun dapat diambil, terindeks atau tidak. Storm akan menggunakan indeks jika tersedia, jika tidak maka akan menggunakan [sistem query](#advanced-queries).

#### Ambil satu objek

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Ambil beberapa objek

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Mengambil semua objek

```go
var users []User
err := db.All(&users)
```

#### Mengambil semua objek diurutkan berdasarkan indeks

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Mengambil rentang objek

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Mengambil objek berdasarkan awalan

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip, Limit dan Reverse

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

#### Menghapus sebuah objek

```go
err := db.DeleteStruct(&user)
```

#### Memperbarui sebuah objek

```go
// Memperbarui beberapa field
// Hanya bekerja untuk field dengan nilai non-nol (misal: Name tidak boleh "", Age tidak boleh 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Memperbarui satu field
// Juga bekerja untuk field bernilai nol (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Inisialisasi bucket dan indeks sebelum menyimpan objek

```go
err := db.Init(&User{})
```

Berguna saat memulai aplikasi Anda

#### Menghapus sebuah bucket

Menggunakan struct

```go
err := db.Drop(&User)
```

Menggunakan nama bucket

```go
err := db.Drop("User")
```

#### Re-indeks sebuah bucket

```go
err := db.ReIndex(&User{})
```

Berguna ketika struktur telah berubah

### Query tingkat lanjut

Untuk query yang lebih kompleks, Anda dapat menggunakan metode `Select`.
`Select` menerima sejumlah [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) dari paket [`q`](https://godoc.org/github.com/asdine/storm/q).

Berikut adalah beberapa Matcher yang umum:

```go
// Persamaan
q.Eq("Name", John)

// Lebih besar secara ketat
q.Gt("Age", 7)

// Kurang dari atau sama dengan
q.Lte("Age", 77)

// Regex dengan nama yang diawali huruf D
q.Re("Name", "^D")

// Dalam daftar nilai tertentu
q.In("Group", []string{"Staff", "Admin"})

// Membandingkan field
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher juga dapat dikombinasikan dengan `And`, `Or` dan `Not`:

```go

// Cocok jika semua terpenuhi
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Cocok jika salah satu terpenuhi
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

Anda dapat menemukan daftar lengkapnya di [dokumentasi](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` menerima sejumlah matcher dan membungkusnya dalam `q.And()` sehingga tidak perlu menyebutkannya secara eksplisit. Fungsi ini mengembalikan tipe [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Tipe `Query` memiliki metode untuk memfilter dan mengurutkan record.

```go
// Limit
query = query.Limit(10)

// Skip
query = query.Skip(20)

// Pemanggilan juga dapat dirangkai
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Juga untuk menentukan bagaimana data diambil.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Contoh dengan `Select`:

```go
// Temukan semua user dengan ID antara 10 dan 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Matcher bersarang
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Menemukan banyak record
err = query.Find(&users)
// atau
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// Temukan record pertama
err = query.First(&user)
// atau
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Hapus semua record yang cocok
err = query.Delete(new(User))

// Mengambil record satu per satu (berguna ketika bucket berisi banyak record)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Lihat [dokumentasi](https://godoc.org/github.com/asdine/storm#Query) untuk daftar lengkap metode.

### Transaksi

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

### Opsi

Opsi Storm adalah fungsi yang dapat diberikan saat membuat instance Storm Anda. Anda dapat memberikan sejumlah opsi.

#### BoltOptions

Secara default, Storm membuka database dengan mode `0600` dan timeout satu detik.
Anda dapat mengubah perilaku ini dengan menggunakan `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Untuk menyimpan data di BoltDB, Storm melakukan marshal dalam format JSON secara default. Jika Anda ingin mengubah perilaku ini Anda dapat memberikan codec yang mengimplementasikan [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) melalui opsi [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Codec yang Disediakan

Anda dapat dengan mudah mengimplementasikan `MarshalUnmarshaler` sendiri, tetapi Storm sudah mendukung [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (default), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob),  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) dan [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Codec ini dapat digunakan dengan mengimpor package yang relevan dan menggunakannya untuk mengkonfigurasi Storm. Contoh di bawah ini menunjukkan semua varian (tanpa penanganan error yang benar):

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

**Tip**: Menambahkan tag Storm pada file Protobuf yang dihasilkan bisa jadi rumit. Solusi yang baik adalah menggunakan [alat ini](https://github.com/favadi/protoc-go-inject-tag) untuk menyisipkan tag selama proses kompilasi.

#### Menggunakan Koneksi Bolt yang Ada

Anda dapat menggunakan koneksi yang sudah ada dan memberikannya ke Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Mode Batch

Mode batch dapat diaktifkan untuk mempercepat penulisan secara konkuren (lihat [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Node dan bucket bertingkat

Storm memanfaatkan fitur bucket bertingkat BoltDB dengan menggunakan `storm.Node`.
Sebuah `storm.Node` adalah objek dasar yang digunakan oleh `storm.DB` untuk memanipulasi bucket.
Untuk membuat bucket bertingkat dan menggunakan API yang sama seperti `storm.DB`, Anda dapat menggunakan metode `DB.From`.

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

Anda juga dapat melakukan chaining pada node untuk membuat hierarki

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Anda bahkan dapat memberikan seluruh hierarki sebagai argumen ke `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Opsi Node

Sebuah Node juga dapat dikonfigurasi. Mengaktifkan sebuah opsi pada Node akan membuat salinan, sehingga Node selalu thread-safe.

```go
n := db.From("my-node")
```

Memberikan transaksi bolt.Tx pada Node

```go
n = n.WithTransaction(tx)
```

Mengaktifkan mode batch

```go
n = n.WithBatch(true)
```

Menggunakan Codec

```go
n = n.WithCodec(gob.Codec)
```

## Penyimpanan Key/Value Sederhana

Storm dapat digunakan sebagai key/value store yang sederhana, tangguh, dan dapat menyimpan apa saja.
Key dan value bisa dari tipe apa saja asalkan key bukan nilai nol.

Menyimpan data :

```go
db.Set("logs", time.Now(), "Saya sedang sarapan")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Mengambil data :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
```
db.Get("sessions", someObjectId, &details)
```

Menghapus data :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Anda dapat menemukan metode berguna lainnya di [dokumentasi](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB masih dapat diakses dengan mudah dan dapat digunakan seperti biasa

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Transaksi juga dapat diteruskan ke Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Lisensi

MIT

## Kredit

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---