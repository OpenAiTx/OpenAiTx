# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm é um kit de ferramentas simples e poderoso para [BoltDB](https://github.com/coreos/bbolt). Basicamente, Storm fornece índices, uma ampla variedade de métodos para armazenar e buscar dados, um sistema de consultas avançado e muito mais.

Além dos exemplos abaixo, veja também os [exemplos na GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Para consultas estendidas e suporte ao [Badger](https://github.com/dgraph-io/badger), veja também o [Genji](https://github.com/asdine/genji)_

## Índice

- [Primeiros Passos](#getting-started)
- [Importar Storm](#import-storm)
- [Abrir um banco de dados](#open-a-database)
- [Sistema CRUD simples](#simple-crud-system)
  - [Declarar suas estruturas](#declare-your-structures)
  - [Salvar seu objeto](#save-your-object)
    - [Auto Incremento](#auto-increment)
  - [Consultas simples](#simple-queries)
    - [Buscar um objeto](#fetch-one-object)
    - [Buscar múltiplos objetos](#fetch-multiple-objects)
    - [Buscar todos os objetos](#fetch-all-objects)
    - [Buscar todos os objetos ordenados por índice](#fetch-all-objects-sorted-by-index)
    - [Buscar um intervalo de objetos](#fetch-a-range-of-objects)
    - [Buscar objetos por prefixo](#fetch-objects-by-prefix)
    - [Pular, Limitar e Reverter](#skip-limit-and-reverse)
    - [Excluir um objeto](#delete-an-object)
    - [Atualizar um objeto](#update-an-object)
    - [Inicializar buckets e índices antes de salvar um objeto](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Excluir um bucket](#drop-a-bucket)
    - [Reindexar um bucket](#re-index-a-bucket)
  - [Consultas avançadas](#advanced-queries)
  - [Transações](#transactions)
  - [Opções](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Codecs fornecidos](#provided-codecs)
    - [Usar conexão Bolt existente](#use-existing-bolt-connection)
    - [Modo batch](#batch-mode)
- [Nodes e buckets aninhados](#nodes-and-nested-buckets)
  - [Opções de Node](#node-options)
- [Armazenamento Simples Chave/Valor](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Licença](#license)
- [Créditos](#credits)

## Primeiros Passos

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Importar Storm

```go
import "github.com/asdine/storm/v3"
```

## Abrir um banco de dados

Forma rápida de abrir um banco de dados

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` pode receber múltiplas opções para customizar seu comportamento. Veja [Opções](#options) abaixo

## Sistema CRUD simples

### Declarar suas estruturas

```go
type User struct {
  ID int // chave primária
  Group string `storm:"index"` // este campo será indexado
  Email string `storm:"unique"` // este campo será indexado com restrição de unicidade
  Name string // este campo não será indexado
  Age int `storm:"index"`
}
```

A chave primária pode ser de qualquer tipo, desde que não seja um valor zero. O Storm procurará pela tag `id`; se não estiver presente, procurará por um campo chamado `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// chave primária
  Group string `storm:"index"` // este campo será indexado
  Email string `storm:"unique"` // este campo será indexado com restrição de unicidade
  Name string // este campo não será indexado
}
```

O Storm lida com tags em estruturas aninhadas usando a tag `inline`

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

### Salvar seu objeto

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

É isso.

`Save` cria ou atualiza todos os índices e buckets necessários, verifica as restrições de unicidade e salva o objeto no armazenamento.

#### Auto Incremento

O Storm pode incrementar valores inteiros automaticamente para que você não precise se preocupar com isso ao salvar seus objetos. Além disso, o novo valor é inserido automaticamente em seu campo.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // chave primária com auto incremento
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // o valor inicial pode ser definido
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

Qualquer objeto pode ser buscado, indexado ou não. O Storm usa índices quando disponíveis, caso contrário, utiliza o [sistema de consultas](#advanced-queries).

#### Buscar um objeto

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Buscar múltiplos objetos

```go
var users []User
err := db.Find("Group", "staff", &users)
```
#### Buscar todos os objetos

```go
var users []User
err := db.All(&users)
```

#### Buscar todos os objetos ordenados por índice

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Buscar um intervalo de objetos

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Buscar objetos por prefixo

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

#### Excluir um objeto

```go
err := db.DeleteStruct(&user)
```

#### Atualizar um objeto

```go
// Atualizar vários campos
// Funciona apenas para campos com valor diferente do zero (por exemplo, Name não pode ser "", Age não pode ser 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Atualizar um único campo
// Também funciona para campos com valor zero (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Inicializar buckets e índices antes de salvar um objeto

```go
err := db.Init(&User{})
```

Útil ao iniciar sua aplicação

#### Remover um bucket

Usando a struct

```go
err := db.Drop(&User)
```

Usando o nome do bucket

```go
err := db.Drop("User")
```

#### Reindexar um bucket

```go
err := db.ReIndex(&User{})
```

Útil quando a estrutura foi alterada

### Consultas avançadas

Para consultas mais complexas, você pode usar o método `Select`.
`Select` aceita qualquer número de [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) do pacote [`q`](https://godoc.org/github.com/asdine/storm/q).

Aqui estão alguns Matchers comuns:

```go
// Igualdade
q.Eq("Name", John)

// Estritamente maior que
q.Gt("Age", 7)

// Menor ou igual a
q.Lte("Age", 77)

// Regex com nome começando com a letra D
q.Re("Name", "^D")

// Dentro de um slice de valores fornecido
q.In("Group", []string{"Staff", "Admin"})

// Comparando campos
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matchers também podem ser combinados com `And`, `Or` e `Not`:

```go

// Corresponde se todos coincidirem
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Corresponde se algum coincidir
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

Você pode encontrar a lista completa na [documentação](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` aceita qualquer número de matchers e os encapsula em um `q.And()`, então não é necessário especificá-lo. Ele retorna um tipo [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

O tipo `Query` contém métodos para filtrar e ordenar os registros.

```go
// Limitar
query = query.Limit(10)

// Pular
query = query.Skip(20)

// As chamadas também podem ser encadeadas
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

Mas também para especificar como buscá-los.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Exemplos com `Select`:

```go
// Encontrar todos os usuários com um ID entre 10 e 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Matchers aninhados
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Encontrar múltiplos registros
err = query.Find(&users)
// ou
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
// Encontrar o primeiro registro
err = query.First(&user)
// ou
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Deletar todos os registros correspondentes
err = query.Delete(new(User))

// Buscar registros um por um (útil quando o bucket contém muitos registros)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

Veja a [documentação](https://godoc.org/github.com/asdine/storm#Query) para uma lista completa de métodos.

### Transações

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

### Opções

As opções do Storm são funções que podem ser passadas ao construir sua instância Storm. Você pode passar qualquer número de opções.

#### BoltOptions

Por padrão, o Storm abre um banco de dados com o modo `0600` e um timeout de um segundo.
Você pode alterar esse comportamento usando `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Para armazenar os dados no BoltDB, o Storm faz o marshal em JSON por padrão. Se você quiser alterar esse comportamento, pode passar um codec que implemente [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) via a opção [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Codecs fornecidos

Você pode facilmente implementar seu próprio `MarshalUnmarshaler`, mas o Storm vem com suporte nativo para [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (padrão), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) e [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Esses codecs podem ser utilizados importando o pacote correspondente e usando-o para configurar o Storm. O exemplo abaixo mostra todas as variantes (sem tratamento de erros):

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

**Dica**: Adicionar tags do Storm a arquivos Protobuf gerados pode ser complicado. Uma boa solução é usar [esta ferramenta](https://github.com/favadi/protoc-go-inject-tag) para injetar as tags durante a compilação.

#### Usar conexão Bolt existente

Você pode usar uma conexão existente e passá-la para o Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Modo Batch

O modo batch pode ser habilitado para acelerar escritas concorrentes (veja [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Nodes e buckets aninhados

O Storm aproveita o recurso de buckets aninhados do BoltDB usando `storm.Node`.
Um `storm.Node` é o objeto subjacente usado pelo `storm.DB` para manipular um bucket.
Para criar um bucket aninhado e usar a mesma API do `storm.DB`, você pode usar o método `DB.From`.

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

Você também pode encadear os nodes para criar uma hierarquia

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Você pode até passar toda a hierarquia como argumentos para `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Opções do Node

Um Node também pode ser configurado. Ativar uma opção em um Node cria uma cópia, então um Node é sempre thread-safe.

```go
n := db.From("my-node")
```

Dar uma transação bolt.Tx para o Node

```go
n = n.WithTransaction(tx)
```

Habilitar modo batch

```go
n = n.WithBatch(true)
```

Usar um Codec

```go
n = n.WithCodec(gob.Codec)
```

## Armazenamento simples de chave/valor

O Storm pode ser usado como um armazenamento de chave/valor simples e robusto, que pode armazenar qualquer coisa.
A chave e o valor podem ser de qualquer tipo, desde que a chave não seja um valor zero.

Salvando dados:

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Buscando dados:

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Excluindo dados :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Você pode encontrar outros métodos úteis na [documentação](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB ainda é facilmente acessível e pode ser usado como de costume

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Uma transação também pode ser passada para o Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Licença

MIT

## Créditos

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---