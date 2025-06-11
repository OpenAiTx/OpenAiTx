# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm — это простой и мощный набор инструментов для [BoltDB](https://github.com/coreos/bbolt). В основном Storm предоставляет индексы, широкий набор методов для хранения и получения данных, продвинутую систему запросов и многое другое.

В дополнение к примерам ниже, см. также [примеры в GoDoc](https://godoc.org/github.com/asdine/storm#pkg-examples).

_Для расширенных запросов и поддержки [Badger](https://github.com/dgraph-io/badger), см. также [Genji](https://github.com/asdine/genji)_

## Оглавление

- [Начало работы](#getting-started)
- [Импорт Storm](#import-storm)
- [Открытие базы данных](#open-a-database)
- [Простая система CRUD](#simple-crud-system)
  - [Объявление структур](#declare-your-structures)
  - [Сохранение объекта](#save-your-object)
    - [Автоинкремент](#auto-increment)
  - [Простые запросы](#simple-queries)
    - [Получить один объект](#fetch-one-object)
    - [Получить несколько объектов](#fetch-multiple-objects)
    - [Получить все объекты](#fetch-all-objects)
    - [Получить все объекты, отсортированные по индексу](#fetch-all-objects-sorted-by-index)
    - [Получить диапазон объектов](#fetch-a-range-of-objects)
    - [Получить объекты по префиксу](#fetch-objects-by-prefix)
    - [Пропуск, Лимит и Реверс](#skip-limit-and-reverse)
    - [Удалить объект](#delete-an-object)
    - [Обновить объект](#update-an-object)
    - [Инициализация бакетов и индексов перед сохранением объекта](#initialize-buckets-and-indexes-before-saving-an-object)
    - [Удалить бакет](#drop-a-bucket)
    - [Переиндексация бакета](#re-index-a-bucket)
  - [Продвинутые запросы](#advanced-queries)
  - [Транзакции](#transactions)
  - [Опции](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [Предоставленные кодеки](#provided-codecs)
    - [Использование существующего подключения Bolt](#use-existing-bolt-connection)
    - [Пакетный режим](#batch-mode)
- [Узлы и вложенные бакеты](#nodes-and-nested-buckets)
  - [Опции узла](#node-options)
- [Простое Key/Value хранилище](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [Лицензия](#license)
- [Благодарности](#credits)

## Начало работы

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Импорт Storm

```go
import "github.com/asdine/storm/v3"
```

## Открытие базы данных

Быстрый способ открыть базу данных

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open` может принимать несколько опций для настройки поведения. См. [Опции](#options) ниже

## Простая система CRUD

### Объявление структур

```go
type User struct {
  ID int // первичный ключ
  Group string `storm:"index"` // это поле будет проиндексировано
  Email string `storm:"unique"` // это поле будет проиндексировано с уникальным ограничением
  Name string // это поле не будет проиндексировано
  Age int `storm:"index"`
}
```

Первичный ключ может быть любого типа, если он не равен нулевому значению. Storm будет искать тег `id`, если он не найден — поле с именем `ID`.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// первичный ключ
  Group string `storm:"index"` // это поле будет проиндексировано
  Email string `storm:"unique"` // это поле будет проиндексировано с уникальным ограничением
  Name string // это поле не будет проиндексировано
}
```

Storm обрабатывает теги во вложенных структурах с помощью тега `inline`

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

### Сохранение объекта

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

Вот и все.

`Save` создает или обновляет все необходимые индексы и бакеты, проверяет уникальные ограничения и сохраняет объект в хранилище.

#### Автоинкремент

Storm может автоматически увеличивать значения целых чисел, чтобы вам не пришлось беспокоиться об этом при сохранении объектов. Также новое значение автоматически вставляется в ваше поле.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // первичный ключ с автоинкрементом
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // можно установить начальное значение
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

### Простые запросы

Любой объект можно получить, независимо от индексации. Storm использует индексы, если они доступны, в противном случае применяется [система запросов](#advanced-queries).

#### Получить один объект

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### Получить несколько объектов

```go
var users []User
err := db.Find("Group", "staff", &users)
```

#### Получить все объекты

```go
var users []User
err := db.All(&users)
```

#### Получить все объекты, отсортированные по индексу

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### Получить диапазон объектов

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### Получить объекты по префиксу

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Пропуск, лимит и обратный порядок

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

#### Удалить объект

```go
err := db.DeleteStruct(&user)
```

#### Обновить объект

```go
// Обновить несколько полей
// Работает только для полей, не равных нулевым значениям (например, Name не может быть "", Age не может быть 0)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// Обновить одно поле
// Также работает для нулевых значений (0, false, "", ...)
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### Инициализация бакетов и индексов перед сохранением объекта

```go
err := db.Init(&User{})
```

Полезно при запуске вашего приложения

#### Удалить бакет

Используя структуру

```go
err := db.Drop(&User)
```

Используя имя бакета

```go
err := db.Drop("User")
```

#### Переиндексация бакета

```go
err := db.ReIndex(&User{})
```

Полезно при изменении структуры

### Продвинутые запросы

Для более сложных запросов вы можете использовать метод `Select`.
`Select` принимает любое количество [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher) из пакета [`q`](https://godoc.org/github.com/asdine/storm/q).

Вот некоторые распространённые Matcher'ы:

```go
// Равенство
q.Eq("Name", John)

// Строго больше
q.Gt("Age", 7)

// Меньше или равно
q.Lte("Age", 77)

// Регулярное выражение: имя начинается с буквы D
q.Re("Name", "^D")

// В указанном слайсе значений
q.In("Group", []string{"Staff", "Admin"})

// Сравнение полей
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher'ы также можно комбинировать с помощью `And`, `Or` и `Not`:

```go

// Совпадение, если выполняются все условия
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// Совпадение, если выполняется хотя бы одно условие
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

Полный список вы можете найти в [документации](https://godoc.org/github.com/asdine/storm/q#Matcher).

`Select` принимает любое количество matcher'ов и оборачивает их в `q.And()`, поэтому указывать его явно не обязательно. Возвращает тип [`Query`](https://godoc.org/github.com/asdine/storm#Query).

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

Тип `Query` содержит методы для фильтрации и сортировки записей.

```go
// Лимит
query = query.Limit(10)

// Пропуск
query = query.Skip(20)

// Вызовы можно объединять
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

А также для указания способа их выборки.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

Примеры использования `Select`:

```go
// Найти всех пользователей с ID в диапазоне от 10 до 100
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// Вложенные matcher'ы
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// Найти несколько записей
err = query.Find(&users)
// или
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// Найти первую запись
err = query.First(&user)
// или
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// Удалить все подходящие записи
err = query.Delete(new(User))

// Получение записей одну за одной (полезно, когда в бакете много записей)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

См. [документацию](https://godoc.org/github.com/asdine/storm#Query) для полного списка методов.

### Транзакции

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

### Опции

Опции Storm — это функции, которые можно передать при создании экземпляра Storm. Вы можете передать любое количество опций.

#### BoltOptions

По умолчанию Storm открывает базу данных с режимом `0600` и тайм-аутом в одну секунду.
Это поведение можно изменить с помощью `BoltOptions`

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

Для хранения данных в BoltDB Storm по умолчанию сериализует их в JSON. Если вы хотите изменить это поведение, вы можете передать кодек, реализующий [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler) через опцию [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec):

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### Предустановленные кодеки

Вы можете легко реализовать свой `MarshalUnmarshaler`, но Storm поставляется с поддержкой [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (по умолчанию), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob),  [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf) и [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack).

Ими можно воспользоваться, импортировав соответствующий пакет и используя этот кодек для настройки Storm. Пример ниже показывает все варианты (без обработки ошибок):

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

**Совет**: Добавлять теги Storm в сгенерированные файлы Protobuf может быть сложно. Хорошее решение — использовать [этот инструмент](https://github.com/favadi/protoc-go-inject-tag) для внедрения тегов во время компиляции.

#### Использование существующего подключения Bolt

Вы можете использовать существующее подключение и передать его в Storm

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### Режим пакетной обработки (Batch mode)

Пакетный режим может быть включён для ускорения параллельных записей (см. [Batch read-write transactions](https://github.com/coreos/bbolt#batch-read-write-transactions))

```go
db := storm.Open("my.db", storm.Batch())
```

## Узлы и вложенные бакеты

Storm использует возможность вложенных бакетов BoltDB с помощью `storm.Node`.
`storm.Node` — это базовый объект, используемый `storm.DB` для работы с бакетом.
Чтобы создать вложенный бакет и использовать тот же API, что и у `storm.DB`, вы можете использовать метод `DB.From`.

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

Вы также можете объединять узлы для создания иерархии

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

Можно даже передать всю иерархию в качестве аргументов для `From`:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### Опции узла

Узел также может быть настроен. Активация опции на узле создаёт копию, поэтому узел всегда потокобезопасен.

```go
n := db.From("my-node")
```

Передать bolt.Tx транзакцию узлу

```go
n = n.WithTransaction(tx)
```

Включить пакетный режим

```go
n = n.WithBatch(true)
```

Использовать кодек

```go
n = n.WithCodec(gob.Codec)
```

## Простой Key/Value store

Storm можно использовать как простой, надёжный key/value store, способный хранить любые данные.
Ключ и значение могут быть любого типа, если только ключ не является нулевым значением.

Сохранение данных :

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

Получение данных :

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

Удаление данных :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

Вы можете найти другие полезные методы в [документации](https://godoc.org/github.com/asdine/storm#KeyValueStore).

## BoltDB

BoltDB по-прежнему легко доступен и может использоваться как обычно

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

Транзакция также может быть передана в Storm

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## Лицензия

MIT

## Благодарности

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---