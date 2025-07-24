
# 제네릭과 함께하는 Go Nullable

[![PkgGoDev](https://pkg.go.dev/badge/github.com/LukaGiorgadze/gonull)](https://pkg.go.dev/github.com/LukaGiorgadze/gonull) ![go-mod-verify](https://github.com/LukaGiorgadze/gonull/workflows/Go%20mod/badge.svg) ![go-vuln](https://github.com/LukaGiorgadze/gonull/workflows/Security/badge.svg) ![golangci-lint](https://github.com/LukaGiorgadze/gonull/workflows/Linter/badge.svg) [![codecov](https://codecov.io/gh/LukaGiorgadze/gonull/branch/main/graph/badge.svg?token=76089e7b-f137-4459-8eae-4b48007bd0d6)](https://codecov.io/gh/LukaGiorgadze/gonull) [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/LukaGiorgadze/gonull)

## Go 패키지는 Go 제네릭으로 nullable 필드 처리를 간소화합니다.

`gonull`은 제네릭을 사용하여 nullable 값을 타입 안전하게 처리하는 Go 패키지입니다. JSON 및 SQL 작업과 원활하게 작동하도록 설계되어 웹 서비스와 데이터베이스 상호작용에 적합합니다.

## 특징

- 🎯 하나의 제네릭 `Nullable[T]`가 **모든** 타입과 작동
- 💡 Omitzero 지원
- 🔄 내장 JSON 마샬링/언마샬링
- 📊 SQL 데이터베이스 호환성
- 🔢 SQL 드라이버가 문자열로 반환하는 숫자 값 처리
- 🧩 사용자 정의 별칭 또는 열거형 타입과 원활한 작동
- ✨ 의존성 제로

### 왜 gonull인가?

`Nullable[T]`는 모든 타입에 대해 Go 제네릭을 사용하여 코드를 간결하게 유지합니다. 문자열, 정수 또는 사용자 정의 열거형에 대해 별도의 래퍼가 필요 없습니다. 내장된 `sql.Scanner` 및 `json` 지원으로 데이터베이스와 API 통합이 쉽습니다.

```go
type Status string

type Task struct {
    ID    int
    State gonull.Nullable[Status]
}
```

---

## Usage

```bash
go get github.com/LukaGiorgadze/gonull/v2
```
### 예제 #1


```go
package main

import (
    "encoding/json"
    "fmt"

    "github.com/LukaGiorgadze/gonull"
)

type MyCustomInt int
type MyCustomFloat32 float32

type Person struct {
    Name     string                           `json:"name"`
    Age      gonull.Nullable[MyCustomInt]     `json:"age"`
    Address  gonull.Nullable[string]          `json:"address"`
    Height   gonull.Nullable[MyCustomFloat32] `json:"height"`
    IsZero   gonull.Nullable[bool]            `json:"is_zero,omitzero"` // This property will be omitted from the output since it's not present in jsonData.
}

func main() {
    jsonData := []byte(`
    {
        "name": "Alice",
        "age": 15,
        "address": null,
        "height": null
    }`)

    var person Person
    json.Unmarshal(jsonData, &person)
    fmt.Printf("Unmarshalled Person: %+v\n", person)

    marshalledData, _ := json.Marshal(person)
    fmt.Printf("Marshalled JSON: %s\n", string(marshalledData))

    // Output:
    // Unmarshalled Person: {Name:Alice Age:15 Address: Height:0 IsZero:false}
    // Marshalled JSON: {"name":"Alice","age":15,"address":null,"height":null}
    // As you see, IsZero is not present in the output, because we used the omitzero tag introduced in go v1.24.
}
```
### 예제 #2


```go
type User struct {
    Name     gonull.Nullable[string]
    Age      gonull.Nullable[int]
}

func main() {
    // ...
    rows, err := db.Query("SELECT id, name, age FROM users")
    if err != nil {
        log.Fatal(err)
    }
    defer rows.Close()

    for rows.Next() {
        var user User
        err := rows.Scan(&user.Name, &user.Age)
        if err != nil {
            log.Fatal(err)
        }
        fmt.Printf("ID: %d, Name: %v, Age: %v\n", user.Name.Val, user.Age.Val)
    }
    // ...
}
```
### 더 많은 예제 탐색하기
[./examples](./examples) 디렉토리를 참조하세요.

## 기여

<a href="https://github.com/LukaGiorgadze/gonull/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=LukaGiorgadze/gonull" />
</a>

[contrib.rocks](https://contrib.rocks)로 제작되었습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---