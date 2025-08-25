# OpenTelemetry-Go gqlgen 仪器化

[![ci](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml)
[![Go Report Card](https://goreportcard.com/badge/github.com/ravilushqa/otelgqlgen)](https://goreportcard.com/report/github.com/ravilushqa/otelgqlgen)
[![codecov](https://codecov.io/gh/ravilushqa/otelgqlgen/branch/main/graph/badge.svg?token=4LXALH3K72)](https://codecov.io/gh/ravilushqa/otelgqlgen)
[![Go Reference](https://pkg.go.dev/badge/github.com/ravilushqa/otelgqlgen.svg)](https://pkg.go.dev/github.com/ravilushqa/otelgqlgen)

这是针对 Golang 99designs/gqlgen 的 OpenTelemetry 仪器化，移植自 https://github.com/open-telemetry/opentelemetry-go-contrib/pull/761。

目前只能对追踪进行仪器化。

## 安装

要安装 otelgqlgen 包，请使用以下命令：

```bash
go get github.com/ravilushqa/otelgqlgen
```

## 使用方法

以下是如何使用 otelgqlgen 的基本示例：

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
### 配置选项

otelgqlgen 提供了多种选项以自定义追踪行为：

- `WithTracerProvider(provider)`：指定自定义的追踪提供者。默认使用全局的 OpenTelemetry 追踪提供者。
- `WithComplexityExtensionName(name)`：指定复杂度扩展的名称。默认情况下，名称会自动生成。
- `WithRequestVariablesAttributesBuilder(builder)`：指定自定义函数，用于构建请求变量的属性。
- `WithoutVariables()`：禁用变量属性。
- `WithCreateSpanFromFields(predicate)`：指定自定义函数，根据 GraphQL 上下文字段控制是否创建 Span。
- `WithInterceptResponseResultHandlerFunc(handler)`：指定自定义函数，在返回之前拦截并处理 GraphQL 响应结果。
- `WithInterceptFieldsResultHandlerFunc(handler)`：指定自定义函数，在执行过程中拦截并处理 GraphQL 字段级别的结果和错误。

## 示例

参见 [./example](./example)。

## 兼容性

本项目已在以下系统上进行测试。

| 操作系统 | Go 版本   | 架构         |
| -------- | --------- | ------------ |
| Ubuntu   | 1.23      | amd64        |
| Ubuntu   | 1.24      | amd64        |
| Ubuntu   | 1.23      | 386          |
| Ubuntu   | 1.24      | 386          |
| MacOS    | 1.23      | amd64        |
| MacOS    | 1.24      | amd64        |
| Windows  | 1.23      | amd64        |
| Windows  | 1.24      | amd64        |
| Windows  | 1.23      | 386          |
| Windows  | 1.24      | 386          |

虽然本项目应适用于其他系统，但目前不对这些系统的兼容性做出保证。

本项目遵循 [发布政策](https://golang.org/doc/devel/release#policy) 支持主要的 Go 版本。




## 参考文献

- [GraphQL](https://graphql.org/)
- [gqlgen](https://gqlgen.com)

## 许可证

本项目采用 Apache 许可证 2.0 版本授权。详情请参阅 LICENSE 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---