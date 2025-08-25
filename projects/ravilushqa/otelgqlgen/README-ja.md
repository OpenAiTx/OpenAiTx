# OpenTelemetry-Go gqlgen インストルメンテーション

[![ci](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml)
[![Go Report Card](https://goreportcard.com/badge/github.com/ravilushqa/otelgqlgen)](https://goreportcard.com/report/github.com/ravilushqa/otelgqlgen)
[![codecov](https://codecov.io/gh/ravilushqa/otelgqlgen/branch/main/graph/badge.svg?token=4LXALH3K72)](https://codecov.io/gh/ravilushqa/otelgqlgen)
[![Go Reference](https://pkg.go.dev/badge/github.com/ravilushqa/otelgqlgen.svg)](https://pkg.go.dev/github.com/ravilushqa/otelgqlgen)

これはGolang 99designs/gqlgen向けのOpenTelemetryインストルメンテーションであり、https://github.com/open-telemetry/opentelemetry-go-contrib/pull/761 からの移植版です。

現時点ではトレースのみをインストルメントできます。

## インストール

otelgqlgenパッケージをインストールするには、以下のコマンドを使用してください:

```bash
go get github.com/ravilushqa/otelgqlgen
```

## 使用方法

以下はotelgqlgenの基本的な使用例です：

```go
package main

import (
    "github.com/99designs/gqlgen/graphql/handler"
    "github.com/ravilushqa/otelgqlgen"
    "github.com/myorg/mygqlgenapi/graph"
)

func main() {
    srv := handler.NewDefaultServer(graph.NewExecutableSchema(graph.Config{Resolvers: &graph.Resolver{}}))

    // Add the otelgqlgen middleware to add OpenTelemetry tracing
    srv.Use(otelgqlgen.Middleware())

    // Your usual server setup code...
}
```
### 設定オプション

otelgqlgen はトレーシングの動作をカスタマイズするためにいくつかのオプションを提供します:

- `WithTracerProvider(provider)`: カスタムのトレーサープロバイダーを指定します。デフォルトではグローバルな OpenTelemetry トレーサープロバイダーが使用されます。
- `WithComplexityExtensionName(name)`: 複雑度拡張機能の名前を指定します。デフォルトでは名前が自動生成されます。
- `WithRequestVariablesAttributesBuilder(builder)`: リクエスト変数の属性を構築するカスタム関数を指定します。
- `WithoutVariables()`: 変数の属性を無効にします。
- `WithCreateSpanFromFields(predicate)`: GraphQL コンテキストフィールドに基づいてスパンを作成するかどうかを制御するカスタム関数を指定します。
- `WithInterceptResponseResultHandlerFunc(handler)`: GraphQL のレスポンス結果が返される前にそれを傍受し処理するカスタム関数を指定します。
- `WithInterceptFieldsResultHandlerFunc(handler)`: 実行中の GraphQL フィールドレベルの結果やエラーを傍受し処理するカスタム関数を指定します。

## 例

[./example](./example) を参照してください。

## 互換性

このプロジェクトは以下のシステムでテストされています。

| OS      | Go バージョン | アーキテクチャ |
| ------- |------------| ------------ |
| Ubuntu  | 1.23       | amd64        |
| Ubuntu  | 1.24       | amd64        |
| Ubuntu  | 1.23       | 386          |
| Ubuntu  | 1.24       | 386          |
| MacOS   | 1.23       | amd64        |
| MacOS   | 1.24       | amd64        |
| Windows | 1.23       | amd64        |
| Windows | 1.24       | amd64        |
| Windows | 1.23       | 386          |
| Windows | 1.24       | 386          |

このプロジェクトは他のシステムでも動作するはずですが、現時点ではそれらのシステムに対する互換性保証はありません。

本プロジェクトは主要な Go リリースをサポートするために [リリースポリシー](https://golang.org/doc/devel/release#policy) に従っています。




## 参考文献

- [GraphQL](https://graphql.org/)
- [gqlgen](https://gqlgen.com)

## ライセンス

本プロジェクトはApache License, Version 2.0の下でライセンスされています。詳細はLICENSEファイルをご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---