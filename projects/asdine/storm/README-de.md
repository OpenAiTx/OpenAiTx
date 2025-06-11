# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm ist ein einfaches und leistungsfähiges Toolkit für [BoltDB](https://github.com/coreos/bbolt). Im Wesentlichen bietet Storm Indizes, eine Vielzahl von Methoden zum Speichern und Abrufen von Daten, ein fortschrittliches Abfragesystem und vieles mehr.

Zusätzlich zu den untenstehenden Beispielen siehe auch die [Beispiele im GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Für erweiterte Abfragen und Unterstützung für [Badger](https://github.com/dgraph-io/badger), siehe auch [Genji](https://github.com/asdine/genji)_

## Inhaltsverzeichnis

- [Erste Schritte](#getting-started)
- [Storm importieren](#import-storm)
- [Eine Datenbank öffnen](#open-a-database)
- [Einfaches CRUD-System](#simple-crud-system)
  - [Strukturen deklarieren](#declare-your-structures)
  - [Objekt speichern](#save-your-object)
    - [Auto-Inkrement](#auto-increment)
  - [Einfache Abfragen](#simple-queries)
    - [Ein Objekt abrufen](#fetch-one-object)
    - [Mehrere Objekte abrufen](#fetch-multiple-objects)
    - [Alle Objekte abrufen](#fetch-all-objects)
    - [Alle Objekte nach Index sortiert abrufen](#fetch-all-objects-sorted-by-index)
    - [Einen Bereich von Objekten abrufen](#fetch-a-range-of-objects)
    - [Objekte nach Präfix abrufen](#fetch-objects-by-prefix)
    - [Überspringen, Limit und Umkehren](#skip-limit-and-reverse)
    - [Ein Objekt löschen](#delete-an-object)
    - [Ein Objekt aktualisieren](#update-an-object)
    - [Buckets und Indizes initialisieren, bevor ein Objekt gespeichert wird](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Einen Bucket löschen](#drop-a-bucket)
    - [Einen Bucket neu indexieren](#re-index-a-bucket)
  - [Erweiterte Abfragen](#advanced-queries)
  - [Transaktionen](#transactions)
  - [Optionen](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Bereitgestellte Codecs](#provided-codecs)
    - [Vorhandene Bolt-Verbindung verwenden](#use-existing-bolt-connection)
    - [Batch-Modus](#batch-mode)
- [Nodes und verschachtelte Buckets](#nodes-and-nested-buckets)
  - [Node-Optionen](#node-options)
- [Einfacher Key/Value-Store](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Lizenz](#license)
- [Credits](#credits)

## Erste Schritte

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Storm importieren

```go
import "github.com/asdine/storm/v3"
```

## Eine Datenbank öffnen

Schneller Weg, eine Datenbank zu öffnen

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` kann mehrere Optionen erhalten, um das Verhalten anzupassen. Siehe [Optionen](#options) unten.

## Einfaches CRUD-System

### Strukturen deklarieren

```go
type User struct {
  ID int // Primärschlüssel
  Group string `storm:"index"` // dieses Feld wird indexiert
  Email string `storm:"unique"` // dieses Feld wird mit einem Unique-Constraint indexiert
  Name string // dieses Feld wird nicht indexiert
  Age int `storm:"index"`
}
```

Der Primärschlüssel kann jeden Typ haben, solange er keinen Nullwert hat. Storm sucht nach dem Tag `id`, falls nicht vorhanden, sucht Storm nach einem Feld mit dem Namen `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// Primärschlüssel
  Group string `storm:"index"` // dieses Feld wird indexiert
  Email string `storm:"unique"` // dieses Feld wird mit einem Unique-Constraint indexiert
  Name string // dieses Feld wird nicht indexiert
}
```

Storm verarbeitet Tags in verschachtelten Strukturen mit dem Tag `inline`.

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

### Objekt speichern

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

Das war's.

`Save` erstellt oder aktualisiert alle erforderlichen Indizes und Buckets, prüft die Unique-Constraints und speichert das Objekt im Store.

#### Auto-Inkrement

Storm kann Integer-Werte automatisch inkrementieren, sodass Sie sich beim Speichern Ihrer Objekte darum nicht kümmern müssen. Der neue Wert wird auch automatisch in Ihr Feld eingetragen.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // Primärschlüssel mit Auto-Inkrement
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // Startwert kann gesetzt werden
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

### Einfache Abfragen

Jedes Objekt kann abgerufen werden, egal ob indexiert oder nicht. Storm verwendet Indizes, wenn verfügbar, andernfalls das [Abfragesystem](#advanced-queries).

#### Ein Objekt abrufen

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Mehrere Objekte abrufen

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Alle Objekte abrufen

```go
var users []User
err := db.All(&users)
```

#### Alle Objekte sortiert nach Index abrufen

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Einen Bereich von Objekten abrufen

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Objekte nach Präfix abrufen

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip, Limit und Reverse

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

#### Ein Objekt löschen

```go
err := db.DeleteStruct(&user)
```

#### Ein Objekt aktualisieren

```go
// Mehrere Felder aktualisieren
// Funktioniert nur für Felder mit Nicht-Null-Werten (z.B. Name darf nicht "", Alter darf nicht 0 sein)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Ein einzelnes Feld aktualisieren
// Funktioniert auch für Nullwerte (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Buckets und Indizes initialisieren, bevor ein Objekt gespeichert wird

```go
err := db.Init(&User{})
```

Nützlich beim Starten Ihrer Anwendung

#### Einen Bucket löschen

Mit der Struct

```go
err := db.Drop(&User)
```

Mit dem Bucket-Namen

```go
err := db.Drop("User")
```

#### Einen Bucket neu indexieren

```go
err := db.ReIndex(&User{})
```

Nützlich, wenn sich die Struktur geändert hat

### Erweiterte Abfragen

Für komplexere Abfragen können Sie die Methode `Select` verwenden.
`Select` nimmt eine beliebige Anzahl von [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) aus dem [`q`](https://godoc.org/github.com/asdine/storm/q)-Paket entgegen.

Hier sind einige gängige Matcher:

```go
// Gleichheit
q.Eq("Name", John)

// Streng größer als
q.Gt("Age", 7)

// Kleiner oder gleich
q.Lte("Age", 77)

// Regex mit Namen, der mit dem Buchstaben D beginnt
q.Re("Name", "^D")

// In der angegebenen Slice von Werten
q.In("Group", []string{"Staff", "Admin"})

// Felder vergleichen
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher können auch mit `And`, `Or` und `Not` kombiniert werden:

```go

// Treffer, wenn alle zutreffen
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Treffer, wenn einer zutrifft
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

Die vollständige Liste finden Sie in der [Dokumentation](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` nimmt beliebig viele Matcher und fasst sie in einem `q.And()` zusammen, daher ist es nicht notwendig, dies explizit anzugeben. Es gibt einen [`Query`](https://godoc.org/github.com/asdine/storm#Query)-Typ zurück.

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Der `Query`-Typ enthält Methoden zum Filtern und Sortieren der Datensätze.

```go
// Limit
query = query.Limit(10)

// Skip
query = query.Skip(20)

// Aufrufe können auch verkettet werden
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Aber auch, um festzulegen, wie sie abgerufen werden.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Beispiele mit `Select`:

```go
// Alle Benutzer mit einer ID zwischen 10 und 100 finden
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Verschachtelte Matcher
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Mehrere Datensätze finden
err = query.Find(&users)
// oder
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
// Ersten Datensatz finden
err = query.First(&user)
// oder
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Alle passenden Datensätze löschen
err = query.Delete(new(User))

// Datensätze einzeln abrufen (nützlich, wenn der Bucket viele Datensätze enthält)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Siehe die [Dokumentation](https://godoc.org/github.com/asdine/storm#Query) für eine vollständige Liste der Methoden.

### Transaktionen

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

### Optionen

Storm-Optionen sind Funktionen, die beim Erstellen einer Storm-Instanz übergeben werden können. Sie können beliebig viele Optionen übergeben.

#### BoltOptions

Standardmäßig öffnet Storm eine Datenbank mit dem Modus `0600` und einem Timeout von einer Sekunde.
Dieses Verhalten kann mit `BoltOptions` geändert werden.

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Um die Daten in BoltDB zu speichern, marshalt Storm sie standardmäßig im JSON-Format. Falls Sie dieses Verhalten ändern möchten, können Sie einen Codec übergeben, der [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) implementiert, mittels der Option [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Vorgefertigte Codecs

Sie können Ihren eigenen `MarshalUnmarshaler` einfach implementieren, aber Storm bietet eingebaute Unterstützung für [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (Standard), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) und [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Diese können verwendet werden, indem das jeweilige Paket importiert und dieser Codec zur Konfiguration von Storm genutzt wird. Das folgende Beispiel zeigt alle Varianten (ohne Fehlerbehandlung):

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

**Tipp**: Das Hinzufügen von Storm-Tags zu generierten Protobuf-Dateien kann schwierig sein. Eine gute Lösung ist die Verwendung von [diesem Tool](https://github.com/favadi/protoc-go-inject-tag), um die Tags während der Kompilierung zu injizieren.

#### Bestehende Bolt-Verbindung verwenden

Sie können eine bestehende Verbindung verwenden und an Storm übergeben

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Batch-Modus

Der Batch-Modus kann aktiviert werden, um gleichzeitige Schreibvorgänge zu beschleunigen (siehe [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Nodes und verschachtelte Buckets

Storm nutzt das Feature der verschachtelten Buckets von BoltDB mittels `storm.Node`.
Ein `storm.Node` ist das zugrundeliegende Objekt, das von `storm.DB` verwendet wird, um einen Bucket zu manipulieren.
Um einen verschachtelten Bucket zu erstellen und die gleiche API wie `storm.DB` zu verwenden, kann die Methode `DB.From` genutzt werden.

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

Nodes können auch verkettet werden, um eine Hierarchie zu erstellen

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Es ist sogar möglich, die gesamte Hierarchie als Argumente an `From` zu übergeben:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Node-Optionen

Ein Node kann ebenfalls konfiguriert werden. Das Aktivieren einer Option auf einem Node erzeugt eine Kopie, sodass ein Node immer thread-sicher ist.

```go
n := db.From("my-node")
```

Einer Node eine bolt.Tx-Transaktion geben

```go
n = n.WithTransaction(tx)
```

Batch-Modus aktivieren

```go
n = n.WithBatch(true)
```

Einen Codec verwenden

```go
n = n.WithCodec(gob.Codec)
```

## Einfacher Key/Value Store

Storm kann als einfacher, robuster Key/Value Store verwendet werden, der beliebige Daten speichern kann.
Der Schlüssel und der Wert können beliebige Typen haben, solange der Schlüssel kein Zero-Value ist.

Daten speichern:

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blond",
  "likes": []string{"cheese", "star wars"},
})
```

Daten abrufen:

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Daten löschen :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Weitere nützliche Methoden finden Sie in der [Dokumentation](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB ist weiterhin problemlos zugänglich und kann wie gewohnt verwendet werden

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Eine Transaktion kann ebenfalls an Storm übergeben werden

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Lizenz

MIT

## Credits

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---