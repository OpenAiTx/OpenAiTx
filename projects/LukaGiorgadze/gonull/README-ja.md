# ジェネリクスでGoのNullableを実現

[![PkgGoDev](https://pkg.go.dev/badge/github.com/LukaGiorgadze/gonull)](https://pkg.go.dev/github.com/LukaGiorgadze/gonull) ![go-mod-verify](https://github.com/LukaGiorgadze/gonull/workflows/Go%20mod/badge.svg) ![go-vuln](https://github.com/LukaGiorgadze/gonull/workflows/Security/badge.svg) ![golangci-lint](https://github.com/LukaGiorgadze/gonull/workflows/Linter/badge.svg) [![codecov](https://codecov.io/gh/LukaGiorgadze/gonull/branch/main/graph/badge.svg?token=76089e7b-f137-4459-8eae-4b48007bd0d6)](https://codecov.io/gh/LukaGiorgadze/gonull) [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/LukaGiorgadze/gonull)

## Goパッケージでnullableフィールドの扱いをジェネリクスで簡素化

`gonull`はジェネリクスを用いてnullable値を型安全に扱うGoパッケージです。JSONやSQL操作とシームレスに連携し、ウェブサービスやデータベースとのやり取りに最適です。

## 特徴

- 🎯 1つのジェネリック`Nullable[T]`が**任意の**型に対応
- 💡 omitzeroサポート
- 🔄 組み込みのJSONマーシャリング/アンマーシャリング
- 📊 SQLデータベース互換性
- 🔢 SQLドライバーが文字列として返す数値も処理可能
- 🧩 独自のエイリアスや列挙型ともシームレスに連携
- ✨ 依存関係ゼロ

### なぜgonullなのか？

`Nullable[T]`はあらゆる型に対してGoジェネリクスを使いコードを簡潔に保ちます。文字列、整数、カスタム列挙型に別々のラッパーは不要です。組み込みの`sql.Scanner`や`json`サポートにより、データベースやAPIとの統合も簡単です。

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
### 例 #1


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
### 例 #2


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
### さらに例を探る
[./examples](./examples) ディレクトリを参照してください。

## 貢献

<a href="https://github.com/LukaGiorgadze/gonull/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=LukaGiorgadze/gonull" />
</a>

[contrib.rocks](https://contrib.rocks) で作成されました。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---