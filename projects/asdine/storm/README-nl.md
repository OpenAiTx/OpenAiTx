# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm is een eenvoudig en krachtig hulpmiddel voor [BoltDB](https://github.com/coreos/bbolt). In wezen biedt Storm indexen, een breed scala aan methoden om data op te slaan en op te halen, een geavanceerd query-systeem en nog veel meer.

Naast de onderstaande voorbeelden, zie ook de [voorbeelden in de GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Voor uitgebreide queries en ondersteuning voor [Badger](https://github.com/dgraph-io/badger), zie ook [Genji](https://github.com/asdine/genji)_

## Inhoudsopgave

- [Aan de slag](#getting-started)
- [Importeer Storm](#import-storm)
- [Open een database](#open-a-database)
- [Eenvoudig CRUD-systeem](#simple-crud-system)
  - [Declareer je structuren](#declare-your-structures)
  - [Sla je object op](#save-your-object)
    - [Auto Increment](#auto-increment)
  - [Eenvoudige queries](#simple-queries)
    - [Haal één object op](#fetch-one-object)
    - [Haal meerdere objecten op](#fetch-multiple-objects)
    - [Haal alle objecten op](#fetch-all-objects)
    - [Haal alle objecten gesorteerd op index op](#fetch-all-objects-sorted-by-index)
    - [Haal een reeks objecten op](#fetch-a-range-of-objects)
    - [Haal objecten op via prefix](#fetch-objects-by-prefix)
    - [Skip, Limit en Reverse](#skip-limit-and-reverse)
    - [Verwijder een object](#delete-an-object)
    - [Update een object](#update-an-object)
    - [Initialiseer buckets en indexen voordat je een object opslaat](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Verwijder een bucket](#drop-a-bucket)
    - [Herindexeer een bucket](#re-index-a-bucket)
  - [Geavanceerde queries](#advanced-queries)
  - [Transacties](#transactions)
  - [Opties](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Geleverde codecs](#provided-codecs)
    - [Gebruik bestaande Bolt-verbinding](#use-existing-bolt-connection)
    - [Batchmodus](#batch-mode)
- [Nodes en geneste buckets](#nodes-and-nested-buckets)
  - [Node-opties](#node-options)
- [Eenvoudige Key/Value store](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Licentie](#license)
- [Credits](#credits)

## Aan de slag

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Importeer Storm

```go
import "github.com/asdine/storm/v3"
```

## Open een database

Snelle manier om een database te openen

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` kan meerdere opties ontvangen om het gedrag aan te passen. Zie [Opties](#options) hieronder

## Eenvoudig CRUD-systeem

### Declareer je structuren

```go
type User struct {
  ID int // primaire sleutel
  Group string `storm:"index"` // dit veld wordt geïndexeerd
  Email string `storm:"unique"` // dit veld wordt geïndexeerd met een unieke beperking
  Name string // dit veld wordt niet geïndexeerd
  Age int `storm:"index"`
}
```

De primaire sleutel kan elk type zijn zolang het geen nulwaarde is. Storm zoekt naar de tag `id`, als deze niet aanwezig is zoekt Storm naar een veld genaamd `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// primaire sleutel
  Group string `storm:"index"` // dit veld wordt geïndexeerd
  Email string `storm:"unique"` // dit veld wordt geïndexeerd met een unieke beperking
  Name string // dit veld wordt niet geïndexeerd
}
```

Storm behandelt tags in geneste structuren met de `inline` tag

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

### Sla je object op

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

Dat is alles.

`Save` maakt of werkt alle benodigde indexen en buckets bij, controleert de unieke beperkingen en slaat het object op in de store.

#### Auto Increment

Storm kan integerwaarden automatisch verhogen zodat je je daar geen zorgen over hoeft te maken bij het opslaan van je objecten. Ook wordt de nieuwe waarde automatisch in je veld geplaatst.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // primaire sleutel met auto increment
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // de startwaarde kan worden ingesteld
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

### Eenvoudige queries

Elk object kan worden opgehaald, geïndexeerd of niet. Storm gebruikt indexen wanneer die beschikbaar zijn, anders gebruikt het het [query-systeem](#advanced-queries).

#### Haal één object op

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Haal meerdere objecten op

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Haal alle objecten op

```go
var users []User
err := db.All(&users)
```

#### Haal alle objecten gesorteerd op index op

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Haal een reeks objecten op

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Haal objecten op met een prefix

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip, Limit en Reverse

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

#### Verwijder een object

```go
err := db.DeleteStruct(&user)
```

#### Werk een object bij

```go
// Werk meerdere velden bij
// Werkt alleen voor velden met een niet-nulwaarde (bijv. Name mag niet "", Age mag niet 0 zijn)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Werk een enkel veld bij
// Werkt ook voor velden met een nulwaarde (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Initialiseer buckets en indexen voordat een object wordt opgeslagen

```go
err := db.Init(&User{})
```

Handig bij het starten van je applicatie

#### Verwijder een bucket

Met de struct

```go
err := db.Drop(&User)
```

Met de bucketnaam

```go
err := db.Drop("User")
```

#### Herindexeer een bucket

```go
err := db.ReIndex(&User{})
```

Handig wanneer de structuur is gewijzigd

### Geavanceerde queries

Voor meer complexe queries kun je de `Select`-methode gebruiken.
`Select` neemt een willekeurig aantal [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) uit het [`q`](https://godoc.org/github.com/asdine/storm/q) pakket.

Hier zijn enkele veelvoorkomende Matchers:

```go
// Gelijkheid
q.Eq("Name", John)

// Strikt groter dan
q.Gt("Age", 7)

// Kleiner dan of gelijk aan
q.Lte("Age", 77)

// Regex met naam die begint met de letter D
q.Re("Name", "^D")

// In de opgegeven lijst met waarden
q.In("Group", []string{"Staff", "Admin"})

// Velden vergelijken
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matchers kunnen ook gecombineerd worden met `And`, `Or` en `Not`:

```go

// Match als alle matchen
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Match als één matcht
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

Je vindt de complete lijst in de [documentatie](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` neemt een willekeurig aantal matchers en voegt ze samen in een `q.And()`, dus het is niet nodig om deze zelf te specificeren. Het retourneert een [`Query`](https://godoc.org/github.com/asdine/storm#Query) type.

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Het `Query` type bevat methoden om de records te filteren en te ordenen.

```go
// Limit
query = query.Limit(10)

// Skip
query = query.Skip(20)

// Aanroepen kunnen ook worden gekoppeld
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Maar ook om te specificeren hoe ze opgehaald moeten worden.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Voorbeelden met `Select`:

```go
// Zoek alle gebruikers met een ID tussen 10 en 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Geneste matchers
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Zoek meerdere records
err = query.Find(&users)
// of
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// Vind het eerste record
err = query.First(&user)
// of
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Verwijder alle overeenkomende records
err = query.Delete(new(User))

// Records één voor één ophalen (handig als de bucket veel records bevat)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Zie de [documentatie](https://godoc.org/github.com/asdine/storm#Query) voor een volledige lijst met methoden.

### Transacties

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

### Opties

Storm-opties zijn functies die je kunt meegeven bij het aanmaken van je Storm-instantie. Je kunt een willekeurig aantal opties doorgeven.

#### BoltOptions

Standaard opent Storm een database met de modus `0600` en een timeout van één seconde.
Je kunt dit gedrag aanpassen met `BoltOptions`.

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Om gegevens op te slaan in BoltDB, wordt standaard JSON gebruikt voor marshallen in Storm. Als je dit gedrag wilt wijzigen, kun je een codec meegeven die [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) implementeert via de [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) optie:

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Geleverde Codecs

Je kunt eenvoudig je eigen `MarshalUnmarshaler` implementeren, maar Storm heeft ingebouwde ondersteuning voor [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (standaard), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) en [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Deze kun je gebruiken door het relevante pakket te importeren en deze codec te gebruiken om Storm te configureren. Het onderstaande voorbeeld toont alle varianten (zonder foutafhandeling):

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

**Tip**: Het toevoegen van Storm-tags aan gegenereerde Protobuf-bestanden kan lastig zijn. Een goede oplossing is om [deze tool](https://github.com/favadi/protoc-go-inject-tag) te gebruiken om tags toe te voegen tijdens het compileren.

#### Bestaande Bolt-verbinding gebruiken

Je kunt een bestaande verbinding gebruiken en deze aan Storm doorgeven

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Batch-modus

Batch-modus kan worden ingeschakeld om gelijktijdige schrijfacties te versnellen (zie [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Nodes en geneste buckets

Storm maakt gebruik van de geneste buckets-functionaliteit van BoltDB door gebruik te maken van `storm.Node`.
Een `storm.Node` is het onderliggende object dat door `storm.DB` wordt gebruikt om een bucket te manipuleren.
Om een geneste bucket aan te maken en dezelfde API als `storm.DB` te gebruiken, kun je de `DB.From`-methode gebruiken.

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

Je kunt ook nodes koppelen om een hiërarchie te maken

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Je kunt zelfs de volledige hiërarchie als argumenten meegeven aan `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Node-opties

Een Node kan ook worden geconfigureerd. Het activeren van een optie op een Node maakt een kopie, dus een Node is altijd thread-safe.

```go
n := db.From("my-node")
```

Geef een bolt.Tx-transactie aan de Node

```go
n = n.WithTransaction(tx)
```

Batch-modus inschakelen

```go
n = n.WithBatch(true)
```

Gebruik een Codec

```go
n = n.WithCodec(gob.Codec)
```

## Eenvoudige Key/Value store

Storm kan gebruikt worden als een eenvoudige, robuuste key/value store waarin alles kan worden opgeslagen.
De key en de value kunnen van elk type zijn, zolang de key geen zero value is.

Data opslaan:

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blond",
  "likes": []string{"cheese", "star wars"},
})
```

Data ophalen:

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Gegevens verwijderen :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Je kunt andere nuttige methoden vinden in de [documentatie](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB is nog steeds eenvoudig toegankelijk en kan zoals gebruikelijk worden gebruikt

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Een transactie kan ook aan Storm worden doorgegeven

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Licentie

MIT

## Credits

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---