# Storm

[![Build Status](https://travis-ci.org/asdine/storm.svg)](https://travis-ci.org/asdine/storm)
[![GoDoc](https://godoc.org/github.com/asdine/storm?status.svg)](https://godoc.org/github.com/asdine/storm)

Storm은 [BoltDB](https://github.com/coreos/bbolt)를 위한 간단하고 강력한 툴킷입니다. 기본적으로 Storm은 인덱스, 데이터를 저장하고 가져오는 다양한 메서드, 고급 쿼리 시스템 등 많은 기능을 제공합니다.

아래 예제 외에도 [GoDoc의 예제](https://godoc.org/github.com/asdine/storm#pkg-examples)도 참고하세요.

_확장된 쿼리와 [Badger](https://github.com/dgraph-io/badger) 지원이 필요하다면 [Genji](https://github.com/asdine/genji)도 참고하세요._

## 목차

- [시작하기](#getting-started)
- [Storm 임포트하기](#import-storm)
- [데이터베이스 열기](#open-a-database)
- [간단한 CRUD 시스템](#simple-crud-system)
  - [구조체 선언하기](#declare-your-structures)
  - [객체 저장하기](#save-your-object)
    - [자동 증가](#auto-increment)
  - [간단한 쿼리](#simple-queries)
    - [단일 객체 가져오기](#fetch-one-object)
    - [여러 객체 가져오기](#fetch-multiple-objects)
    - [모든 객체 가져오기](#fetch-all-objects)
    - [인덱스로 정렬된 모든 객체 가져오기](#fetch-all-objects-sorted-by-index)
    - [범위로 객체 가져오기](#fetch-a-range-of-objects)
    - [접두사로 객체 가져오기](#fetch-objects-by-prefix)
    - [Skip, Limit 및 Reverse](#skip-limit-and-reverse)
    - [객체 삭제](#delete-an-object)
    - [객체 업데이트](#update-an-object)
    - [객체 저장 전 버킷 및 인덱스 초기화](#initialize-buckets-and-indexes-before-saving-an-object)
    - [버킷 삭제](#drop-a-bucket)
    - [버킷 재인덱싱](#re-index-a-bucket)
  - [고급 쿼리](#advanced-queries)
  - [트랜잭션](#transactions)
  - [옵션](#options)
    - [BoltOptions](#boltoptions)
    - [MarshalUnmarshaler](#marshalunmarshaler)
      - [제공되는 Codec](#provided-codecs)
    - [기존 Bolt 연결 사용하기](#use-existing-bolt-connection)
    - [Batch 모드](#batch-mode)
- [노드와 중첩 버킷](#nodes-and-nested-buckets)
  - [노드 옵션](#node-options)
- [간단한 Key/Value 저장소](#simple-keyvalue-store)
- [BoltDB](#boltdb)
- [라이선스](#license)
- [크레딧](#credits)

## 시작하기

```bash
GO111MODULE=on go get -u github.com/asdine/storm/v3
```

## Storm 임포트하기

```go
import "github.com/asdine/storm/v3"
```

## 데이터베이스 열기

데이터베이스를 빠르게 여는 방법

```go
db, err := storm.Open("my.db")

defer db.Close()
```

`Open`은 동작 방식을 사용자화할 수 있는 여러 옵션을 받을 수 있습니다. 아래 [옵션](#options) 항목을 참고하세요.

## 간단한 CRUD 시스템

### 구조체 선언하기

```go
type User struct {
  ID int // 기본 키
  Group string `storm:"index"` // 이 필드는 인덱싱됩니다
  Email string `storm:"unique"` // 이 필드는 유일성 제약과 함께 인덱싱됩니다
  Name string // 이 필드는 인덱싱되지 않습니다
  Age int `storm:"index"`
}
```

기본 키는 0값이 아닌 한 어떤 타입도 사용할 수 있습니다. Storm은 `id` 태그를 우선적으로 검색하며, 없을 경우 `ID`라는 이름의 필드를 찾습니다.

```go
type User struct {
  ThePrimaryKey string `storm:"id"`// 기본 키
  Group string `storm:"index"` // 이 필드는 인덱싱됩니다
  Email string `storm:"unique"` // 이 필드는 유일성 제약과 함께 인덱싱됩니다
  Name string // 이 필드는 인덱싱되지 않습니다
}
```

Storm은 중첩 구조체에서 `inline` 태그로 태그를 처리합니다.

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

### 객체 저장하기

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

이것으로 끝입니다.

`Save`는 필요한 모든 인덱스와 버킷을 생성 또는 업데이트하고, 유일성 제약을 검사하며 객체를 저장소에 저장합니다.

#### 자동 증가

Storm은 정수 값을 자동으로 증가시킬 수 있으므로 객체 저장 시 해당 부분을 신경 쓸 필요가 없습니다. 또한 새로운 값이 자동으로 필드에 삽입됩니다.

```go

type Product struct {
  Pk                  int `storm:"id,increment"` // 자동 증가가 있는 기본 키
  Name                string
  IntegerField        uint64 `storm:"increment"`
  IndexedIntegerField uint32 `storm:"index,increment"`
  UniqueIntegerField  int16  `storm:"unique,increment=100"` // 시작값을 지정할 수 있습니다
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

### 간단한 쿼리

어떤 객체든(인덱싱 여부와 상관없이) 가져올 수 있습니다. Storm은 인덱스가 있을 경우 인덱스를 사용하고, 없으면 [쿼리 시스템](#advanced-queries)을 사용합니다.

#### 단일 객체 가져오기

```go
var user User
err := db.One("Email", "john@provider.com", &user)
// err == nil

err = db.One("Name", "John", &user)
// err == nil

err = db.One("Name", "Jack", &user)
// err == storm.ErrNotFound
```

#### 여러 객체 가져오기

```go
var users []User
err := db.Find("Group", "staff", &users)
```

#### 모든 객체 가져오기

```go
var users []User
err := db.All(&users)
```

#### 인덱스로 정렬하여 모든 객체 가져오기

```go
var users []User
err := db.AllByIndex("CreatedAt", &users)
```

#### 객체의 범위 조회

```go
var users []User
err := db.Range("Age", 10, 21, &users)
```

#### 접두어로 객체 조회

```go
var users []User
err := db.Prefix("Name", "Jo", &users)
```

#### Skip, Limit 및 Reverse

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

#### 객체 삭제

```go
err := db.DeleteStruct(&user)
```

#### 객체 업데이트

```go
// 여러 필드 업데이트
// 0 값이 아닌 필드에만 동작합니다 (예: Name은 ""이 될 수 없고, Age는 0이 될 수 없음)
err := db.Update(&User{ID: 10, Name: "Jack", Age: 45})

// 단일 필드 업데이트
// 0 값 필드(0, false, "", ...)도 동작합니다
err := db.UpdateField(&User{ID: 10}, "Age", 0)
```

#### 객체를 저장하기 전에 버킷 및 인덱스 초기화

```go
err := db.Init(&User{})
```

애플리케이션 시작 시 유용합니다

#### 버킷 삭제

구조체를 사용하여

```go
err := db.Drop(&User)
```

버킷 이름을 사용하여

```go
err := db.Drop("User")
```

#### 버킷의 인덱스 재설정

```go
err := db.ReIndex(&User{})
```

구조가 변경된 경우 유용합니다

### 고급 쿼리

더 복잡한 쿼리가 필요할 경우, `Select` 메서드를 사용할 수 있습니다.  
`Select`는 [`q`](https://godoc.org/github.com/asdine/storm/q) 패키지의 [`Matcher`](https://godoc.org/github.com/asdine/storm/q#Matcher)를 여러 개 받을 수 있습니다.

아래는 자주 사용하는 Matcher 예시입니다:

```go
// 동등 비교
q.Eq("Name", John)

// 엄격한 초과
q.Gt("Age", 7)

// 이하 또는 같은 값
q.Lte("Age", 77)

// D로 시작하는 이름의 정규식
q.Re("Name", "^D")

// 주어진 값 집합에 포함
q.In("Group", []string{"Staff", "Admin"})

// 필드 비교
q.EqF("FieldName", "SecondFieldName")
q.LtF("FieldName", "SecondFieldName")
q.GtF("FieldName", "SecondFieldName")
q.LteF("FieldName", "SecondFieldName")
q.GteF("FieldName", "SecondFieldName")
```

Matcher는 `And`, `Or`, `Not`과 조합할 수 있습니다:

```go

// 모두 일치하는 경우
q.And(
  q.Gt("Age", 7),
  q.Re("Name", "^D")
)

// 하나라도 일치하는 경우
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

전체 목록은 [문서](https://godoc.org/github.com/asdine/storm/q#Matcher)에서 확인할 수 있습니다.

`Select`는 여러 matcher를 받아 내부적으로 `q.And()`로 감싸므로 명시적으로 지정할 필요가 없습니다. 반환값은 [`Query`](https://godoc.org/github.com/asdine/storm#Query) 타입입니다.

```go
query := db.Select(q.Gte("Age", 7), q.Lte("Age", 77))
```

`Query` 타입은 레코드를 필터링하고 정렬하는 메서드를 제공합니다.

```go
// Limit
query = query.Limit(10)

// Skip
query = query.Skip(20)

// 메서드 체이닝도 가능합니다
query = query.Limit(10).Skip(20).OrderBy("Age").Reverse()
```

또한 데이터 조회 방식을 지정할 수 있습니다.

```go
var users []User
err = query.Find(&users)

var user User
err = query.First(&user)
```

`Select` 사용 예시:

```go
// ID가 10에서 100 사이인 모든 사용자 조회
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Find(&users)

// 중첩 matcher
err = db.Select(q.Or(
  q.Gt("ID", 50),
  q.Lt("Age", 21),
  q.And(
    q.Eq("Group", "admin"),
    q.Gte("Age", 21),
  ),
)).Find(&users)

query := db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name")

// 여러 레코드 조회
err = query.Find(&users)
// 또는
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").Find(&users)
```
```go
// 첫 번째 레코드 찾기
err = query.First(&user)
// 또는
err = db.Select(q.Gte("ID", 10), q.Lte("ID", 100)).Limit(10).Skip(5).Reverse().OrderBy("Age", "Name").First(&user)

// 모든 일치하는 레코드 삭제
err = query.Delete(new(User))

// 레코드를 하나씩 가져오기 (버킷에 많은 레코드가 있을 때 유용)
query = db.Select(q.Gte("ID", 10),q.Lte("ID", 100)).OrderBy("Age", "Name")

err = query.Each(new(User), func(record interface{}) error) {
  u := record.(*User)
  ...
  return nil
}
```

전체 메소드 목록은 [문서](https://godoc.org/github.com/asdine/storm#Query)를 참고하세요.

### 트랜잭션

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

### 옵션

Storm 옵션은 Storm 인스턴스를 생성할 때 전달할 수 있는 함수들입니다. 원하는 만큼 옵션을 전달할 수 있습니다.

#### BoltOptions

기본적으로 Storm은 모드 `0600`과 1초의 타임아웃으로 데이터베이스를 엽니다.
이 동작을 변경하려면 `BoltOptions`를 사용하세요.

```go
db, err := storm.Open("my.db", storm.BoltOptions(0600, &bolt.Options{Timeout: 1 * time.Second}))
```

#### MarshalUnmarshaler

BoltDB에 데이터를 저장할 때, Storm은 기본적으로 JSON으로 마샬링합니다. 이 동작을 변경하고 싶다면 [`codec.MarshalUnmarshaler`](https://godoc.org/github.com/asdine/storm/codec#MarshalUnmarshaler)를 구현한 코덱을 [`storm.Codec`](https://godoc.org/github.com/asdine/storm#Codec) 옵션을 통해 전달할 수 있습니다:

```go
db := storm.Open("my.db", storm.Codec(myCodec))
```

##### 기본 제공 코덱

직접 `MarshalUnmarshaler`를 구현할 수도 있지만, Storm은 [JSON](https://godoc.org/github.com/asdine/storm/codec/json) (기본값), [GOB](https://godoc.org/github.com/asdine/storm/codec/gob), [Sereal](https://godoc.org/github.com/asdine/storm/codec/sereal), [Protocol Buffers](https://godoc.org/github.com/asdine/storm/codec/protobuf), [MessagePack](https://godoc.org/github.com/asdine/storm/codec/msgpack)을 기본적으로 지원합니다.

아래 예시처럼 관련 패키지를 임포트하고 해당 코덱을 사용해 Storm을 구성할 수 있습니다. (오류 처리는 생략)

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

**팁**: 생성된 Protobuf 파일에 Storm 태그를 추가하는 것은 까다로울 수 있습니다. [이 도구](https://github.com/favadi/protoc-go-inject-tag)를 사용해 컴파일 시 태그를 주입하는 것이 좋은 해결책입니다.

#### 기존 Bolt 연결 사용

기존 연결을 Storm에 전달해 사용할 수 있습니다.

```go
bDB, _ := bolt.Open(filepath.Join(dir, "bolt.db"), 0600, &bolt.Options{Timeout: 10 * time.Second})
db := storm.Open("my.db", storm.UseDB(bDB))
```

#### 배치 모드

배치 모드를 활성화하면 동시 쓰기 속도를 높일 수 있습니다 ([배치 읽기-쓰기 트랜잭션](https://github.com/coreos/bbolt#batch-read-write-transactions) 참고)

```go
db := storm.Open("my.db", storm.Batch())
```

## 노드와 중첩 버킷

Storm은 `storm.Node`를 사용하여 BoltDB의 중첩 버킷 기능을 활용합니다.  
`storm.Node`는 `storm.DB`가 버킷을 조작할 때 사용하는 기본 객체입니다.  
중첩 버킷을 만들고 `storm.DB`와 동일한 API를 사용하려면 `DB.From` 메서드를 사용할 수 있습니다.

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

노드를 체인으로 연결해 계층 구조를 만들 수도 있습니다.

```go
chars := db.From("characters")
heroes := chars.From("heroes")
enemies := chars.From("enemies")

items := db.From("items")
potions := items.From("consumables").From("medicine").From("potions")
```

전체 계층을 `From`의 인자로 전달하는 것도 가능합니다:

```go
privateNotes := db.From("notes", "private")
workNotes :=  db.From("notes", "work")
```

### 노드 옵션

노드도 설정할 수 있습니다. 노드에서 옵션을 활성화하면 복사본이 생성되므로 노드는 항상 스레드 세이프(thread-safe)입니다.

```go
n := db.From("my-node")
```

노드에 bolt.Tx 트랜잭션을 전달하기

```go
n = n.WithTransaction(tx)
```

배치 모드 활성화

```go
n = n.WithBatch(true)
```

코덱 사용

```go
n = n.WithCodec(gob.Codec)
```

## 간단한 Key/Value 저장소

Storm은 간단하고 견고한 key/value 저장소로도 사용할 수 있습니다.
키와 값은 키가 0값(zero value)이 아니기만 하면 어떤 타입이든 가능합니다.

데이터 저장:

```go
db.Set("logs", time.Now(), "I'm eating my breakfast man")
db.Set("sessions", bson.NewObjectId(), &someUser)
db.Set("weird storage", "754-3010", map[string]interface{}{
  "hair": "blonde",
  "likes": []string{"cheese", "star wars"},
})
```

데이터 조회:

```go
user := User{}
db.Get("sessions", someObjectId, &user)

var details map[string]interface{}
db.Get("weird storage", "754-3010", &details)
```
db.Get("sessions", someObjectId, &details)
```

데이터 삭제 :

```go
db.Delete("sessions", someObjectId)
db.Delete("weird storage", "754-3010")
```

다른 유용한 메서드들은 [문서](https://godoc.org/github.com/asdine/storm#KeyValueStore)에서 확인할 수 있습니다.

## BoltDB

BoltDB는 여전히 쉽게 접근할 수 있으며, 기존과 동일하게 사용할 수 있습니다.

```go
db.Bolt.View(func(tx *bolt.Tx) error {
  bucket := tx.Bucket([]byte("my bucket"))
  val := bucket.Get([]byte("any id"))
  fmt.Println(string(val))
  return nil
})
```

트랜잭션도 Storm에 전달할 수 있습니다.

```go
db.Bolt.Update(func(tx *bolt.Tx) error {
  ...
  dbx := db.WithTransaction(tx)
  err = dbx.Save(&user)
  ...
  return nil
})
```

## 라이선스

MIT

## 크레딧

- [Asdine El Hrychy](https://github.com/asdine)
- [Bjørn Erik Pedersen](https://github.com/bep)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---