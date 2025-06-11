# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm es un conjunto de herramientas simple y potente para [BoltDB](https://github.com/coreos/bbolt). Básicamente, Storm proporciona índices, una amplia gama de métodos para almacenar y recuperar datos, un sistema de consultas avanzado y mucho más.

Además de los ejemplos a continuación, consulte también los [ejemplos en GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Para consultas extendidas y soporte para [Badger](https://github.com/dgraph-io/badger), vea también [Genji](https://github.com/asdine/genji)_

## Tabla de Contenidos

- [Primeros pasos](#getting-started)
- [Importar Storm](#import-storm)
- [Abrir una base de datos](#open-a-database)
- [Sistema CRUD simple](#simple-crud-system)
  - [Declarar tus estructuras](#declare-your-structures)
  - [Guardar tu objeto](#save-your-object)
    - [Auto Incremento](#auto-increment)
  - [Consultas simples](#simple-queries)
    - [Obtener un objeto](#fetch-one-object)
    - [Obtener múltiples objetos](#fetch-multiple-objects)
    - [Obtener todos los objetos](#fetch-all-objects)
    - [Obtener todos los objetos ordenados por índice](#fetch-all-objects-sorted-by-index)
    - [Obtener un rango de objetos](#fetch-a-range-of-objects)
    - [Obtener objetos por prefijo](#fetch-objects-by-prefix)
    - [Saltar, Limitar y Revertir](#skip-limit-and-reverse)
    - [Eliminar un objeto](#delete-an-object)
    - [Actualizar un objeto](#update-an-object)
    - [Inicializar buckets e índices antes de guardar un objeto](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Eliminar un bucket](#drop-a-bucket)
    - [Reindexar un bucket](#re-index-a-bucket)
  - [Consultas avanzadas](#advanced-queries)
  - [Transacciones](#transactions)
  - [Opciones](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Codecs proporcionados](#provided-codecs)
    - [Usar una conexión Bolt existente](#use-existing-bolt-connection)
    - [Modo Batch](#batch-mode)
- [Nodos y buckets anidados](#nodes-and-nested-buckets)
  - [Opciones de nodo](#node-options)
- [Almacenamiento simple Clave/Valor](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Licencia](#license)
- [Créditos](#credits)

## Primeros pasos

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Importar Storm

```go
import "github.com/asdine/storm/v3"
```

## Abrir una base de datos

Forma rápida de abrir una base de datos

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` puede recibir múltiples opciones para personalizar su comportamiento. Vea [Opciones](#options) abajo

## Sistema CRUD simple

### Declarar tus estructuras

```go
type User struct {
  ID int // clave primaria
  Group string `storm:"index"` // este campo será indexado
  Email string `storm:"unique"` // este campo será indexado con restricción única
  Name string // este campo no será indexado
  Age int `storm:"index"`
}
```

La clave primaria puede ser de cualquier tipo siempre que no sea un valor cero. Storm buscará la etiqueta `id`, si no está presente, Storm buscará un campo llamado `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// clave primaria
  Group string `storm:"index"` // este campo será indexado
  Email string `storm:"unique"` // este campo será indexado con restricción única
  Name string // este campo no será indexado
}
```

Storm maneja etiquetas en estructuras anidadas con la etiqueta `inline`

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

### Guardar tu objeto

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

Eso es todo.

`Save` crea o actualiza todos los índices y buckets necesarios, verifica las restricciones únicas y guarda el objeto en el almacén.

#### Auto Incremento

Storm puede autoincrementar valores enteros para que no tengas que preocuparte por eso al guardar tus objetos. Además, el nuevo valor se inserta automáticamente en tu campo.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // clave primaria con autoincremento
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // el valor inicial puede ser establecido
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

### Consultas simples

Cualquier objeto puede ser recuperado, indexado o no. Storm utiliza índices cuando están disponibles, de lo contrario utiliza el [sistema de consultas](#advanced-queries).

#### Obtener un objeto

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Obtener múltiples objetos

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Obtener todos los objetos

```go
var users []User
err := db.All(&users)
```

#### Obtener todos los objetos ordenados por índice

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Obtener un rango de objetos

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Obtener objetos por prefijo

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Saltar, Limitar e Invertir

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

#### Eliminar un objeto

```go
err := db.DeleteStruct(&user)
```

#### Actualizar un objeto

```go
// Actualizar múltiples campos
// Solo funciona para campos con valores distintos de cero (por ejemplo, Name no puede ser "", Age no puede ser 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Actualizar un solo campo
// También funciona para campos con valores cero (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Inicializar buckets e índices antes de guardar un objeto

```go
err := db.Init(&User{})
```

Útil cuando se inicia la aplicación

#### Eliminar un bucket

Usando la estructura

```go
err := db.Drop(&User)
```

Usando el nombre del bucket

```go
err := db.Drop("User")
```

#### Reindexar un bucket

```go
err := db.ReIndex(&User{})
```

Útil cuando la estructura ha cambiado

### Consultas avanzadas

Para consultas más complejas, puedes usar el método `Select`.
`Select` acepta cualquier cantidad de [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) del paquete [`q`](https://godoc.org/github.com/asdine/storm/q).

Aquí algunos Matchers comunes:

```go
// Igualdad
q.Eq("Name", John)

// Estrictamente mayor que
q.Gt("Age", 7)

// Menor o igual que
q.Lte("Age", 77)

// Regex con nombre que empieza con la letra D
q.Re("Name", "^D")

// En el siguiente slice de valores
q.In("Group", []string{"Staff", "Admin"})

// Comparando campos
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Los Matchers también se pueden combinar con `And`, `Or` y `Not`:

```go

// Coincide si todos coinciden
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Coincide si alguno coincide
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

Puedes encontrar la lista completa en la [documentación](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` acepta cualquier cantidad de matchers y los agrupa en un `q.And()`, por lo que no es necesario especificarlo. Devuelve un tipo [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

El tipo `Query` contiene métodos para filtrar y ordenar los registros.

```go
// Límite
query = query.Limit(10)

// Saltar
query = query.Skip(20)

// Las llamadas también se pueden encadenar
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Pero también para especificar cómo obtenerlos.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Ejemplos con `Select`:

```go
// Encontrar todos los usuarios con un ID entre 10 y 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Matchers anidados
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Encontrar múltiples registros
err = query.Find(&users)
// o
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// Encontrar el primer registro
err = query.First(&user)
// o
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Eliminar todos los registros coincidentes
err = query.Delete(new(User))

// Recuperar registros uno por uno (útil cuando el bucket contiene muchos registros)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Consulta la [documentación](https://godoc.org/github.com/asdine/storm#Query) para una lista completa de métodos.

### Transacciones

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

### Opciones

Las opciones de Storm son funciones que pueden pasarse al construir tu instancia de Storm. Puedes pasarle cualquier cantidad de opciones.

#### BoltOptions

Por defecto, Storm abre una base de datos con el modo `0600` y un timeout de un segundo.
Puedes cambiar este comportamiento usando `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Para almacenar los datos en BoltDB, Storm los convierte por defecto a JSON. Si deseas cambiar este comportamiento puedes pasar un codec que implemente [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) a través de la opción [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Codecs Proporcionados

Puedes implementar fácilmente tu propio `MarshalUnmarshaler`, pero Storm viene con soporte integrado para [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (por defecto), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) y [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Estos pueden usarse importando el paquete relevante y utilizando ese codec para configurar Storm. El siguiente ejemplo muestra todas las variantes (sin manejo de errores adecuado):

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

**Tip**: Agregar etiquetas de Storm a archivos Protobuf generados puede ser complicado. Una buena solución es usar [esta herramienta](https://github.com/favadi/protoc-go-inject-tag) para inyectar las etiquetas durante la compilación.

#### Usar una conexión Bolt existente

Puedes usar una conexión existente y pasarla a Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Modo batch

El modo batch puede habilitarse para acelerar escrituras concurrentes (ver [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Nodes y buckets anidados

Storm aprovecha la característica de buckets anidados de BoltDB usando `storm.Node`.
Un `storm.Node` es el objeto subyacente utilizado por `storm.DB` para manipular un bucket.
Para crear un bucket anidado y usar la misma API que `storm.DB`, puedes usar el método `DB.From`.

```go
repo := db.From("repo")

err := repo.Save(&Issue{
  Title: "Quiero más funcionalidades",
  Author: user.ID,
})

err = repo.Save(newRelease("0.10"))

var issues []Issue
err = repo.Find("Author", user.ID, &issues)

var release Release
err = repo.One("Tag", "0.10", &release)
```

También puedes encadenar los nodes para crear una jerarquía

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Incluso puedes pasar toda la jerarquía como argumentos a `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Opciones de Node

Un Node también puede ser configurado. Activar una opción en un Node crea una copia, por lo que un Node siempre es seguro para hilos.

```go
n := db.From("my-node")
```

Dale una transacción bolt.Tx al Node

```go
n = n.WithTransaction(tx)
```

Habilitar el modo batch

```go
n = n.WithBatch(true)
```

Usar un Codec

```go
n = n.WithCodec(gob.Codec)
```

## Almacenamiento simple Clave/Valor

Storm puede usarse como un almacenamiento clave/valor simple y robusto que puede almacenar cualquier cosa.
La clave y el valor pueden ser de cualquier tipo siempre y cuando la clave no sea un valor cero.

Guardar datos :

```go
db.Set("logs", time.Now(), "Estoy desayunando, amigo")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Obtener datos :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
```
db.Get("sessions", someObjectId, &details)
```

Eliminando datos :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Puedes encontrar otros métodos útiles en la [documentación](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB sigue siendo fácilmente accesible y puede ser utilizado como de costumbre

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

También se puede pasar una transacción a Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Licencia

MIT

## Créditos

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---