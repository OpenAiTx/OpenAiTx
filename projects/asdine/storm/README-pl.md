# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm to prosty i potężny zestaw narzędzi dla [BoltDB](https://github.com/coreos/bbolt). Storm udostępnia indeksy, szeroki wachlarz metod do przechowywania i pobierania danych, zaawansowany system zapytań i wiele więcej.

Oprócz poniższych przykładów, zobacz także [przykłady w GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Dla rozszerzonych zapytań i wsparcia dla [Badger](https://github.com/dgraph-io/badger), zobacz także [Genji](https://github.com/asdine/genji)_

## Spis treści

- [Pierwsze kroki](#getting-started)
- [Import Storm](#import-storm)
- [Otwieranie bazy danych](#open-a-database)
- [Prosty system CRUD](#simple-crud-system)
  - [Deklarowanie struktur](#declare-your-structures)
  - [Zapis obiektu](#save-your-object)
    - [Auto Inkremetacja](#auto-increment)
  - [Proste zapytania](#simple-queries)
    - [Pobierz jeden obiekt](#fetch-one-object)
    - [Pobierz wiele obiektów](#fetch-multiple-objects)
    - [Pobierz wszystkie obiekty](#fetch-all-objects)
    - [Pobierz wszystkie obiekty posortowane według indeksu](#fetch-all-objects-sorted-by-index)
    - [Pobierz zakres obiektów](#fetch-a-range-of-objects)
    - [Pobierz obiekty według prefiksu](#fetch-objects-by-prefix)
    - [Skip, Limit oraz Reverse](#skip-limit-and-reverse)
    - [Usuń obiekt](#delete-an-object)
    - [Aktualizuj obiekt](#update-an-object)
    - [Inicjalizacja bucketów i indeksów przed zapisem obiektu](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Usuń bucket](#drop-a-bucket)
    - [Ponowna indeksacja bucketa](#re-index-a-bucket)
  - [Zaawansowane zapytania](#advanced-queries)
  - [Transakcje](#transactions)
  - [Opcje](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Dostarczone kodeki](#provided-codecs)
    - [Użyj istniejącego połączenia Bolt](#use-existing-bolt-connection)
    - [Tryb batch](#batch-mode)
- [Węzły i zagnieżdżone buckety](#nodes-and-nested-buckets)
  - [Opcje węzła](#node-options)
- [Prosty magazyn Key/Value](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Licencja](#license)
- [Podziękowania](#credits)

## Pierwsze kroki

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Import Storm

```go
import "github.com/asdine/storm/v3"
```

## Otwieranie bazy danych

Szybki sposób na otwarcie bazy danych

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` może przyjąć wiele opcji, aby dostosować swoje zachowanie. Zobacz [Opcje](#options) poniżej

## Prosty system CRUD

### Deklarowanie struktur

```go
type User struct {
  ID int // klucz główny
  Group string `storm:"index"` // to pole będzie indeksowane
  Email string `storm:"unique"` // to pole będzie indeksowane z unikalnym ograniczeniem
  Name string // to pole nie będzie indeksowane
  Age int `storm:"index"`
}
```

Klucz główny może być dowolnego typu, o ile nie jest to wartość zerowa. Storm szuka tagu `id`, jeśli nie jest obecny, Storm szuka pola o nazwie `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// klucz główny
  Group string `storm:"index"` // to pole będzie indeksowane
  Email string `storm:"unique"` // to pole będzie indeksowane z unikalnym ograniczeniem
  Name string // to pole nie będzie indeksowane
}
```

Storm obsługuje tagi w strukturach zagnieżdżonych przy użyciu tagu `inline`

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

### Zapis obiektu

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

To wszystko.

`Save` tworzy lub aktualizuje wszystkie wymagane indeksy i buckety, sprawdza unikalność oraz zapisuje obiekt w magazynie.

#### Auto Inkremetacja

Storm może automatycznie inkrementować wartości całkowite, więc nie musisz się tym martwić przy zapisie obiektów. Nowa wartość zostanie automatycznie przypisana do Twojego pola.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // klucz główny z auto inkrementacją
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // początkowa wartość może być ustawiona
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

### Proste zapytania

Każdy obiekt może być pobrany, niezależnie czy jest indeksowany, czy nie. Storm używa indeksów, gdy są dostępne, w przeciwnym razie korzysta z [systemu zapytań](#advanced-queries).

#### Pobierz jeden obiekt

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Pobierz wiele obiektów

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Pobierz wszystkie obiekty

```go
var users []User
err := db.All(&users)
```

#### Pobierz wszystkie obiekty posortowane według indeksu

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Pobierz zakres obiektów

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Pobierz obiekty według prefiksu

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Pomijanie, limit i odwrócenie

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

#### Usuń obiekt

```go
err := db.DeleteStruct(&user)
```

#### Aktualizuj obiekt

```go
// Aktualizuj wiele pól
// Działa tylko dla pól o niezerowej wartości (np. Name nie może być "", Age nie może być 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Aktualizuj pojedyncze pole
// Działa także dla pól o zerowej wartości (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Inicjalizuj kubełki i indeksy przed zapisaniem obiektu

```go
err := db.Init(&User{})
```

Przydatne podczas uruchamiania aplikacji

#### Usuń kubełek

Z użyciem struktury

```go
err := db.Drop(&User)
```

Z użyciem nazwy kubełka

```go
err := db.Drop("User")
```

#### Przeindeksuj kubełek

```go
err := db.ReIndex(&User{})
```

Przydatne, gdy struktura została zmieniona

### Zaawansowane zapytania

Do bardziej złożonych zapytań możesz użyć metody `Select`.
`Select` przyjmuje dowolną liczbę [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) z pakietu [`q`](https://godoc.org/github.com/asdine/storm/q).

Oto kilka popularnych matcherów:

```go
// Równość
q.Eq("Name", John)

// Ściśle większy niż
q.Gt("Age", 7)

// Mniejszy lub równy
q.Lte("Age", 77)

// Regex dla nazwy zaczynającej się na literę D
q.Re("Name", "^D")

// W podanej liście wartości
q.In("Group", []string{"Staff", "Admin"})

// Porównywanie pól
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matchery mogą być także łączone przy użyciu `And`, `Or` i `Not`:

```go

// Dopasuj, jeśli wszystkie pasują
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Dopasuj, jeśli którykolwiek pasuje
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

Pełną listę znajdziesz w [dokumentacji](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` przyjmuje dowolną liczbę matcherów i opakowuje je w `q.And()`, więc nie trzeba go podawać. Zwraca typ [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Typ `Query` zawiera metody do filtrowania i sortowania rekordów.

```go
// Limit
query = query.Limit(10)

// Skip
query = query.Skip(20)

// Wywołania można także łączyć
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Można także określić sposób pobierania danych.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Przykłady z `Select`:

```go
// Znajdź wszystkich użytkowników z ID pomiędzy 10 a 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Zagnieżdżone matchery
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Znajdź wiele rekordów
err = query.Find(&users)
// lub
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
// Znajdź pierwszy rekord
err = query.First(&user)
// lub
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Usuń wszystkie pasujące rekordy
err = query.Delete(new(User))

// Pobieranie rekordów jeden po drugim (przydatne, gdy kubełek zawiera dużo rekordów)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Zobacz [dokumentację](https://godoc.org/github.com/asdine/storm#Query) aby uzyskać pełną listę metod.

### Transakcje

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

### Opcje

Opcje Storm to funkcje, które mogą być przekazane podczas tworzenia instancji Storm. Możesz przekazać dowolną liczbę opcji.

#### BoltOptions

Domyślnie Storm otwiera bazę danych z trybem `0600` i timeoutem jednej sekundy.
Możesz zmienić to zachowanie, używając `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Aby przechowywać dane w BoltDB, Storm domyślnie serializuje je do JSON. Jeśli chcesz zmienić to zachowanie, możesz przekazać kodek implementujący [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) za pomocą opcji [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Dostarczone kodeki

Możesz łatwo zaimplementować własny `MarshalUnmarshaler`, ale Storm posiada wbudowane wsparcie dla [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (domyślny), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob),  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) oraz [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Można ich użyć, importując odpowiedni pakiet i wykorzystać kodek do konfiguracji Storm. Przykład poniżej pokazuje wszystkie warianty (bez obsługi błędów):

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

**Wskazówka**: Dodawanie tagów Storm do generowanych plików Protobuf może być trudne. Dobrym rozwiązaniem jest użycie [tego narzędzia](https://github.com/favadi/protoc-go-inject-tag), aby wstrzyknąć tagi podczas kompilacji.

#### Użycie istniejącego połączenia Bolt

Możesz użyć istniejącego połączenia i przekazać je do Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Tryb wsadowy

Tryb wsadowy może być włączony, aby przyspieszyć równoczesne zapisy (zobacz [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Węzły i zagnieżdżone kubełki

Storm wykorzystuje funkcję zagnieżdżonych kubełków BoltDB poprzez użycie `storm.Node`.
`storm.Node` to obiekt wykorzystywany przez `storm.DB` do manipulowania kubełkiem.
Aby utworzyć zagnieżdżony kubełek i używać tego samego API co `storm.DB`, można użyć metody `DB.From`.

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

Możesz również łączyć węzły, aby stworzyć hierarchię

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Możesz nawet przekazać całą hierarchię jako argumenty do `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Opcje węzła

Węzeł również może być konfigurowany. Aktywowanie opcji na węźle tworzy jego kopię, więc węzeł jest zawsze bezpieczny dla wątków.

```go
n := db.From("my-node")
```

Przekaż transakcję bolt.Tx do węzła

```go
n = n.WithTransaction(tx)
```

Włącz tryb wsadowy

```go
n = n.WithBatch(true)
```

Użyj kodeka

```go
n = n.WithCodec(gob.Codec)
```

## Prosty magazyn Klucz/Wartość

Storm może być używany jako prosty, niezawodny magazyn klucz/wartość, który może przechowywać wszystko.
Klucz i wartość mogą być dowolnego typu, o ile klucz nie jest zerowy.

Zapisywanie danych:

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Pobieranie danych:

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Usuwanie danych :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Inne przydatne metody znajdziesz w [dokumentacji](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB jest nadal łatwo dostępny i może być używany jak zwykle

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Transakcja może być również przekazana do Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Licencja

MIT

## Podziękowania

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---