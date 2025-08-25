# OpenTelemetry-Go gqlgen Instrumentation

[![ci](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml)
[![Go Report Card](https://goreportcard.com/badge/github.com/ravilushqa/otelgqlgen)](https://goreportcard.com/report/github.com/ravilushqa/otelgqlgen)
[![codecov](https://codecov.io/gh/ravilushqa/otelgqlgen/branch/main/graph/badge.svg?token=4LXALH3K72)](https://codecov.io/gh/ravilushqa/otelgqlgen)
[![Go Reference](https://pkg.go.dev/badge/github.com/ravilushqa/otelgqlgen.svg)](https://pkg.go.dev/github.com/ravilushqa/otelgqlgen)

It is an OpenTelemetry instrumentation for Golang 99designs/gqlgen, a port from https://github.com/open-telemetry/opentelemetry-go-contrib/pull/761.

It can only instrument traces for the present.

## Installation

To install the otelgqlgen package, use the following command:

```bash
go get github.com/ravilushqa/otelgqlgen
```

## Usage

Below is a basic example of how to use otelgqlgen:

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

### Configuration Options

otelgqlgen provides several options to customize the tracing behavior:

- `WithTracerProvider(provider)`: Specifies a custom tracer provider. By default, the global OpenTelemetry tracer provider is used.
- `WithComplexityExtensionName(name)`: Specifies a name for the complexity extension. By default, a name is automatically generated.
- `WithRequestVariablesAttributesBuilder(builder)`: Specifies a custom function to build the attributes for the request variables.
- `WithoutVariables()`: Disables the variables attributes.
- `WithCreateSpanFromFields(predicate)`: Specifies a custom function to control whether a span should be created based on the GraphQL context fields.
- `WithInterceptResponseResultHandlerFunc(handler)`: Specifies a custom function to intercept and handle GraphQL response results before they are returned.
- `WithInterceptFieldsResultHandlerFunc(handler)`: Specifies a custom function to intercept and handle GraphQL field-level results and errors during execution.

## Example

See [./example](./example).

## Compatibility

This project is tested on the following systems.

| OS      | Go Version | Architecture |
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

While this project should work for other systems, no compatibility guarantees
are made for those systems currently.

The project follows the [Release Policy](https://golang.org/doc/devel/release#policy) to support major Go releases.


## References

- [GraphQL](https://graphql.org/)
- [gqlgen](https://gqlgen.com)

## License

This project is licensed under the Apache License, Version 2.0. See the LICENSE file for details.
