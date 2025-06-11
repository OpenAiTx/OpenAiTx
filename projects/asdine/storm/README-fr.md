# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm est une boîte à outils simple et puissante pour [BoltDB](https://github.com/coreos/bbolt). Fondamentalement, Storm fournit des index, un large éventail de méthodes pour stocker et récupérer des données, un système de requêtes avancé, et bien plus encore.

En plus des exemples ci-dessous, consultez également les [exemples dans la GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Pour des requêtes étendues et la prise en charge de [Badger](https://github.com/dgraph-io/badger), consultez également [Genji](https://github.com/asdine/genji)_

## Table des Matières

- [Pour bien commencer](#pour-bien-commencer)
- [Importer Storm](#importer-storm)
- [Ouvrir une base de données](#ouvrir-une-base-de-données)
- [Système CRUD simple](#système-crud-simple)
  - [Déclarer vos structures](#déclarer-vos-structures)
  - [Enregistrer votre objet](#enregistrer-votre-objet)
    - [Auto-incrémentation](#auto-incrémentation)
  - [Requêtes simples](#requêtes-simples)
    - [Récupérer un objet](#récupérer-un-objet)
    - [Récupérer plusieurs objets](#récupérer-plusieurs-objets)
    - [Récupérer tous les objets](#récupérer-tous-les-objets)
    - [Récupérer tous les objets triés par index](#récupérer-tous-les-objets-triés-par-index)
    - [Récupérer une plage d'objets](#récupérer-une-plage-dobjets)
    - [Récupérer des objets par préfixe](#récupérer-des-objets-par-préfixe)
    - [Skip, Limit et Reverse](#skip-limit-et-reverse)
    - [Supprimer un objet](#supprimer-un-objet)
    - [Mettre à jour un objet](#mettre-à-jour-un-objet)
    - [Initialiser des buckets et index avant d'enregistrer un objet](#initialiser-des-buckets-et-index-avant-denregistrer-un-objet)
    - [Supprimer un bucket](#supprimer-un-bucket)
    - [Réindexer un bucket](#réindexer-un-bucket)
  - [Requêtes avancées](#requêtes-avancées)
  - [Transactions](#transactions)
  - [Options](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Codecs fournis](#codecs-fournis)
    - [Utiliser une connexion Bolt existante](#utiliser-une-connexion-bolt-existante)
    - [Mode Batch](#mode-batch)
- [Nœuds et buckets imbriqués](#nœuds-et-buckets-imbriqués)
  - [Options de nœud](#options-de-nœud)
- [Stockage clé/valeur simple](#stockage-clévaleur-simple)
- [BoltDB](#boltdb)
- [Licence](#licence)
- [Crédits](#crédits)

## Pour bien commencer

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Importer Storm

```go
import "github.com/asdine/storm/v3"
```

## Ouvrir une base de données

Méthode rapide pour ouvrir une base de données

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` peut recevoir plusieurs options pour personnaliser son comportement. Voir [Options](#options) ci-dessous

## Système CRUD simple

### Déclarer vos structures

```go
type User struct {
  ID int // clé primaire
  Group string `storm:"index"` // ce champ sera indexé
  Email string `storm:"unique"` // ce champ sera indexé avec une contrainte d'unicité
  Name string // ce champ ne sera pas indexé
  Age int `storm:"index"`
}
```

La clé primaire peut être de n'importe quel type tant qu'elle n'a pas une valeur nulle. Storm recherchera l'étiquette `id`, si elle n'est pas présente Storm recherchera un champ nommé `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// clé primaire
  Group string `storm:"index"` // ce champ sera indexé
  Email string `storm:"unique"` // ce champ sera indexé avec une contrainte d'unicité
  Name string // ce champ ne sera pas indexé
}
```

Storm gère les étiquettes dans les structures imbriquées avec l'étiquette `inline`

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

### Enregistrer votre objet

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

C'est tout.

`Save` crée ou met à jour tous les index et buckets requis, vérifie les contraintes d'unicité et enregistre l'objet dans le store.

#### Auto-incrémentation

Storm peut auto-incrémenter les valeurs entières afin que vous n'ayez pas à vous en soucier lors de l'enregistrement de vos objets. De plus, la nouvelle valeur est automatiquement insérée dans votre champ.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // clé primaire avec auto-incrémentation
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // la valeur de départ peut être définie
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

### Requêtes simples

N'importe quel objet peut être récupéré, indexé ou non. Storm utilise les index lorsqu'ils sont disponibles, sinon il utilise le [système de requêtes](#requêtes-avancées).

#### Récupérer un objet

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Récupérer plusieurs objets

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Récupérer tous les objets

```go
var users []User
err := db.All(&users)
```

#### Récupérer tous les objets triés par index

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Récupérer une plage d'objets

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Récupérer des objets par préfixe

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip, Limit et Reverse

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

#### Supprimer un objet

```go
err := db.DeleteStruct(&user)
```

#### Mettre à jour un objet

```go
// Mettre à jour plusieurs champs
// Fonctionne uniquement pour les champs ayant une valeur non nulle (par ex. Name ne peut pas être "", Age ne peut pas être 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Mettre à jour un seul champ
// Fonctionne également pour les champs ayant une valeur nulle (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Initialiser les buckets et index avant de sauvegarder un objet

```go
err := db.Init(&User{})
```

Utile lors du démarrage de votre application

#### Supprimer un bucket

En utilisant la structure

```go
err := db.Drop(&User)
```

En utilisant le nom du bucket

```go
err := db.Drop("User")
```

#### Réindexer un bucket

```go
err := db.ReIndex(&User{})
```

Utile lorsque la structure a changé

### Requêtes avancées

Pour des requêtes plus complexes, vous pouvez utiliser la méthode `Select`.
`Select` prend un nombre quelconque de [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) du package [`q`](https://godoc.org/github.com/asdine/storm/q).

Voici quelques Matchers courants :

```go
// Égalité
q.Eq("Name", John)

// Strictement supérieur à
q.Gt("Age", 7)

// Inférieur ou égal à
q.Lte("Age", 77)

// Regex avec un nom commençant par la lettre D
q.Re("Name", "^D")

// Dans la liste de valeurs donnée
q.In("Group", []string{"Staff", "Admin"})

// Comparaison de champs
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Les Matchers peuvent également être combinés avec `And`, `Or` et `Not` :

```go

// Correspond si toutes les conditions sont remplies
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Correspond si au moins une condition est remplie
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

Vous pouvez trouver la liste complète dans la [documentation](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` prend un nombre quelconque de matchers et les regroupe dans un `q.And()`, il n'est donc pas nécessaire de le spécifier. Elle retourne un type [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Le type `Query` contient des méthodes pour filtrer et trier les enregistrements.

```go
// Limite
query = query.Limit(10)

// Sauter
query = query.Skip(20)

// Les appels peuvent également être chaînés
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Mais également pour spécifier comment les récupérer.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Exemples avec `Select` :

```go
// Trouver tous les utilisateurs avec un ID entre 10 et 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Matchers imbriqués
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Trouver plusieurs enregistrements
err = query.Find(&users)
// ou
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// Trouver le premier enregistrement
err = query.First(&user)
// ou
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Supprimer tous les enregistrements correspondants
err = query.Delete(new(User))

// Récupération des enregistrements un par un (utile lorsque le bucket contient beaucoup d'enregistrements)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Voir la [documentation](https://godoc.org/github.com/asdine/storm#Query) pour la liste complète des méthodes.

### Transactions

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

### Options

Les options Storm sont des fonctions qui peuvent être passées lors de la construction de votre instance Storm. Vous pouvez passer autant d'options que vous le souhaitez.

#### BoltOptions

Par défaut, Storm ouvre une base de données avec le mode `0600` et un timeout d'une seconde.
Vous pouvez modifier ce comportement en utilisant `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Pour stocker les données dans BoltDB, Storm les sérialise en JSON par défaut. Si vous souhaitez changer ce comportement, vous pouvez passer un codec qui implémente [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) via l'option [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) :

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Codecs fournis

Vous pouvez facilement implémenter votre propre `MarshalUnmarshaler`, mais Storm est livré avec une prise en charge native de [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (par défaut), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) et [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Ces codecs peuvent être utilisés en important le package correspondant et en l'utilisant pour configurer Storm. L'exemple ci-dessous montre toutes les variantes (sans gestion d'erreur appropriée) :

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

**Astuce** : Ajouter des tags Storm aux fichiers Protobuf générés peut être délicat. Une bonne solution consiste à utiliser [cet outil](https://github.com/favadi/protoc-go-inject-tag) pour injecter les tags pendant la compilation.

#### Utiliser une connexion Bolt existante

Vous pouvez utiliser une connexion existante et la passer à Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Mode batch

Le mode batch peut être activé pour accélérer les écritures concurrentes (voir [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Nodes et buckets imbriqués

Storm exploite la fonctionnalité de buckets imbriqués de BoltDB en utilisant `storm.Node`.
Un `storm.Node` est l'objet sous-jacent utilisé par `storm.DB` pour manipuler un bucket.
Pour créer un bucket imbriqué et utiliser la même API que `storm.DB`, vous pouvez utiliser la méthode `DB.From`.

```go
repo := db.From("repo")

err := repo.Save(&Issue{
  Title: "Je veux plus de fonctionnalités",
  Author: user.ID,
})

err = repo.Save(newRelease("0.10"))

var issues []Issue
err = repo.Find("Author", user.ID, &issues)

var release Release
err = repo.One("Tag", "0.10", &release)
```

Vous pouvez également chaîner les nodes pour créer une hiérarchie

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Vous pouvez même passer toute la hiérarchie en arguments à `From` :

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Options Node

Un Node peut également être configuré. L'activation d'une option sur un Node crée une copie, ainsi un Node est toujours thread-safe.

```go
n := db.From("my-node")
```

Donner une transaction bolt.Tx au Node

```go
n = n.WithTransaction(tx)
```

Activer le mode batch

```go
n = n.WithBatch(true)
```

Utiliser un Codec

```go
n = n.WithCodec(gob.Codec)
```

## Simple Key/Value store

Storm peut être utilisé comme un simple et robuste magasin clé/valeur capable de stocker n'importe quoi.
La clé et la valeur peuvent être de n'importe quel type tant que la clé n'est pas une valeur zéro.

Sauvegarder des données :

```go
db.Set("logs", time.Now(), "Je mange mon petit-déjeuner mec")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blond",
  "likes": []string{"fromage", "star wars"},
})
```

Récupérer des données :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Suppression des données :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Vous pouvez trouver d'autres méthodes utiles dans la [documentation](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB reste facilement accessible et peut être utilisé comme d'habitude

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Une transaction peut également être passée à Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Licence

MIT

## Crédits

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---