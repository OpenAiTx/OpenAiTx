# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm è un toolkit semplice e potente per [BoltDB](https://github.com/coreos/bbolt). Fondamentalmente, Storm fornisce indici, una vasta gamma di metodi per memorizzare e recuperare dati, un sistema avanzato di query e molto altro.

Oltre agli esempi qui sotto, consulta anche gli [esempi nella GoDoc](https://godoc.org/github.com/asdine/storm#pkg-esamples).

_Per query estese e supporto per [Badger](https://github.com/dgraph-io/badger), consulta anche [Genji](https://github.com/asdine/genji)_

## Indice

- [Guida introduttiva](#getting-started)
- [Importare Storm](#import-storm)
- [Aprire un database](#open-a-database)
- [Sistema CRUD semplice](#simple-crud-system)
  - [Dichiarare le tue strutture](#declare-your-structures)
  - [Salvare il tuo oggetto](#save-your-object)
    - [Auto Incremento](#auto-increment)
  - [Query semplici](#simple-queries)
    - [Recuperare un oggetto](#fetch-one-object)
    - [Recuperare più oggetti](#fetch-multiple-objects)
    - [Recuperare tutti gli oggetti](#fetch-all-objects)
    - [Recuperare tutti gli oggetti ordinati per indice](#fetch-all-objects-sorted-by-index)
    - [Recuperare un intervallo di oggetti](#fetch-a-range-of-objects)
    - [Recuperare oggetti per prefisso](#fetch-objects-by-prefix)
    - [Skip, Limit e Reverse](#skip-limit-and-reverse)
    - [Eliminare un oggetto](#delete-an-object)
    - [Aggiornare un oggetto](#update-an-object)
    - [Inizializzare bucket e indici prima di salvare un oggetto](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Eliminare un bucket](#drop-a-bucket)
    - [Reindicizzare un bucket](#re-index-a-bucket)
  - [Query avanzate](#advanced-queries)
  - [Transazioni](#transactions)
  - [Opzioni](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Codec forniti](#provided-codecs)
    - [Usare una connessione Bolt esistente](#use-existing-bolt-connection)
    - [Modalità batch](#batch-mode)
- [Nodi e bucket annidati](#nodes-and-nested-buckets)
  - [Opzioni nodo](#node-options)
- [Semplice archivio Chiave/Valore](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Licenza](#license)
- [Crediti](#credits)

## Guida introduttiva

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Importare Storm

```go
import "github.com/asdine/storm/v3"
```

## Aprire un database

Modo rapido per aprire un database

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` può ricevere diverse opzioni per personalizzare il suo comportamento. Vedi [Opzioni](#options) qui sotto

## Sistema CRUD semplice

### Dichiarare le tue strutture

```go
type User struct {
  ID int // chiave primaria
  Group string `storm:"index"` // questo campo sarà indicizzato
  Email string `storm:"unique"` // questo campo sarà indicizzato con vincolo di unicità
  Name string // questo campo non sarà indicizzato
  Age int `storm:"index"`
}
```

La chiave primaria può essere di qualsiasi tipo purché non sia un valore zero. Storm cercherà il tag `id`, se non presente cercherà un campo chiamato `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// chiave primaria
  Group string `storm:"index"` // questo campo sarà indicizzato
  Email string `storm:"unique"` // questo campo sarà indicizzato con vincolo di unicità
  Name string // questo campo non sarà indicizzato
}
```

Storm gestisce i tag nelle strutture annidate tramite il tag `inline`

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

### Salvare il tuo oggetto

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

Ecco fatto.

`Save` crea o aggiorna tutti gli indici e i bucket necessari, verifica i vincoli di unicità e salva l’oggetto nell’archivio.

#### Auto Incremento

Storm può incrementare automaticamente i valori interi così non dovrai preoccupartene quando salvi i tuoi oggetti. Inoltre, il nuovo valore viene inserito automaticamente nel tuo campo.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // chiave primaria con auto incremento
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // il valore iniziale può essere impostato
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

### Query semplici

Qualsiasi oggetto può essere recuperato, sia indicizzato che no. Storm utilizza gli indici quando disponibili, altrimenti utilizza il [sistema di query](#advanced-queries).

#### Recuperare un oggetto

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Recuperare più oggetti

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Recupera tutti gli oggetti

```go
var users []User
err := db.All(&users)
```

#### Recupera tutti gli oggetti ordinati per indice

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Recupera un intervallo di oggetti

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Recupera oggetti per prefisso

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip, Limit e Reverse

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

#### Elimina un oggetto

```go
err := db.DeleteStruct(&user)
```

#### Aggiorna un oggetto

```go
// Aggiorna più campi
// Funziona solo per campi con valore diverso da zero (ad es. Name non può essere "", Age non può essere 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Aggiorna un singolo campo
// Funziona anche per campi con valore zero (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Inizializza bucket e indici prima di salvare un oggetto

```go
err := db.Init(&User{})
```

Utile quando si avvia l'applicazione

#### Elimina un bucket

Usando la struct

```go
err := db.Drop(&User)
```

Usando il nome del bucket

```go
err := db.Drop("User")
```

#### Reindicizza un bucket

```go
err := db.ReIndex(&User{})
```

Utile quando la struttura è cambiata

### Query avanzate

Per query più complesse, puoi usare il metodo `Select`.
`Select` accetta un qualsiasi numero di [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) dal pacchetto [`q`](https://godoc.org/github.com/asdine/storm/q).

Ecco alcuni Matcher comuni:

```go
// Uguaglianza
q.Eq("Name", John)

// Maggiore strettamente
q.Gt("Age", 7)

// Minore o uguale
q.Lte("Age", 77)

// Regex con nome che inizia con la lettera D
q.Re("Name", "^D")

// Nei valori dati in slice
q.In("Group", []string{"Staff", "Admin"})

// Confronto tra campi
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

I Matcher possono anche essere combinati con `And`, `Or` e `Not`:

```go

// Match se tutti corrispondono
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Match se uno corrisponde
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

Puoi trovare la lista completa nella [documentazione](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` accetta un qualsiasi numero di matcher e li racchiude in un `q.And()`, quindi non è necessario specificarlo. Restituisce un tipo [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Il tipo `Query` contiene metodi per filtrare e ordinare i record.

```go
// Limit
query = query.Limit(10)

// Skip
query = query.Skip(20)

// Le chiamate possono anche essere concatenate
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Ma anche per specificare come recuperarli.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Esempi con `Select`:

```go
// Trova tutti gli utenti con un ID tra 10 e 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Matcher annidati
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Trova più record
err = query.Find(&users)
// oppure
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// Trova il primo record
err = query.First(&user)
// oppure
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Elimina tutti i record corrispondenti
err = query.Delete(new(User))

// Recupero dei record uno per uno (utile quando il bucket contiene molti record)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Consulta la [documentazione](https://godoc.org/github.com/asdine/storm#Query) per un elenco completo dei metodi.

### Transazioni

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

### Opzioni

Le opzioni di Storm sono funzioni che possono essere passate quando si costruisce un'istanza di Storm. Puoi passarne un numero qualsiasi.

#### BoltOptions

Per impostazione predefinita, Storm apre un database con il mode `0600` e un timeout di un secondo.
Puoi cambiare questo comportamento usando `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Per salvare i dati in BoltDB, Storm li serializza in JSON come impostazione predefinita. Se desideri cambiare questo comportamento puoi passare un codec che implementa [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) tramite l'opzione [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Codec forniti

Puoi facilmente implementare il tuo `MarshalUnmarshaler`, ma Storm offre il supporto integrato per [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (predefinito), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob),  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) e [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Questi possono essere utilizzati importando il relativo package e usando quel codec per configurare Storm. L'esempio sotto mostra tutte le varianti (senza gestire gli errori):

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

**Suggerimento**: Aggiungere i tag Storm ai file Protobuf generati può essere complicato. Una buona soluzione è utilizzare [questo strumento](https://github.com/favadi/protoc-go-inject-tag) per iniettare i tag durante la compilazione.

#### Usa una connessione Bolt esistente

Puoi usare una connessione esistente e passarla a Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Modalità Batch

La modalità batch può essere abilitata per velocizzare le scritture concorrenti (vedi [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Node e bucket annidati

Storm sfrutta la funzionalità dei bucket annidati di BoltDB utilizzando `storm.Node`.
Un `storm.Node` è l'oggetto sottostante utilizzato da `storm.DB` per manipolare un bucket.
Per creare un bucket annidato e usare la stessa API di `storm.DB`, puoi usare il metodo `DB.From`.

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

Puoi anche concatenare i node per creare una gerarchia

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Puoi persino passare l'intera gerarchia come argomenti a `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Opzioni dei Node

Un Node può anche essere configurato. Attivare un'opzione su un Node crea una copia, quindi un Node è sempre thread-safe.

```go
n := db.From("my-node")
```

Assegna una transazione bolt.Tx al Node

```go
n = n.WithTransaction(tx)
```

Abilita la modalità batch

```go
n = n.WithBatch(true)
```

Usa un Codec

```go
n = n.WithCodec(gob.Codec)
```

## Semplice archivio Chiave/Valore

Storm può essere usato come un semplice e robusto archivio chiave/valore che può salvare qualsiasi cosa.
La chiave e il valore possono essere di qualsiasi tipo, purché la chiave non sia un valore zero.

Salvare dati :

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Recuperare dati :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Eliminare i dati :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Puoi trovare altri metodi utili nella [documentazione](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB è ancora facilmente accessibile e può essere utilizzato come di consueto

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Una transazione può anche essere passata a Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Licenza

MIT

## Crediti

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---