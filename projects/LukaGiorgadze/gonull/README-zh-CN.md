
# 使用泛型实现 Go 的可空类型

[![PkgGoDev](https://pkg.go.dev/badge/github.com/LukaGiorgadze/gonull)](https://pkg.go.dev/github.com/LukaGiorgadze/gonull) ![go-mod-verify](https://github.com/LukaGiorgadze/gonull/workflows/Go%20mod/badge.svg) ![go-vuln](https://github.com/LukaGiorgadze/gonull/workflows/Security/badge.svg) ![golangci-lint](https://github.com/LukaGiorgadze/gonull/workflows/Linter/badge.svg) [![codecov](https://codecov.io/gh/LukaGiorgadze/gonull/branch/main/graph/badge.svg?token=76089e7b-f137-4459-8eae-4b48007bd0d6)](https://codecov.io/gh/LukaGiorgadze/gonull) [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/LukaGiorgadze/gonull)

## Go 包通过泛型简化可空字段的处理。

`gonull` 是一个 Go 包，使用泛型提供类型安全的可空值处理。它设计为与 JSON 和 SQL 操作无缝协作，非常适合 Web 服务和数据库交互。

## 特性

- 🎯 一个泛型 `Nullable[T]` 支持**任何**类型
- 💡 支持 omitzero
- 🔄 内置 JSON 编组/解组功能
- 📊 兼容 SQL 数据库
- 🔢 处理 SQL 驱动返回的字符串数值
- 🧩 无缝支持自定义别名或枚举类型
- ✨ 零依赖

### 为什么选择 gonull？

`Nullable[T]` 使用 Go 泛型保持代码简洁，适用于任何类型。无需为字符串、整数或自定义枚举编写单独的包装器。内置的 `sql.Scanner` 和 `json` 支持，使数据库和 API 集成变得简单。

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


### 示例 #1


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
### 示例 #2


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
### 探索更多示例
请参见 [./examples](./examples) 目录。

## 贡献者

<a href="https://github.com/LukaGiorgadze/gonull/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=LukaGiorgadze/gonull" />
</a>

由 [contrib.rocks](https://contrib.rocks) 制作。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---