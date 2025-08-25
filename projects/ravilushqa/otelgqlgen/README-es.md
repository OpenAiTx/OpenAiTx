# Instrumentación OpenTelemetry-Go gqlgen

[![ci](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml)
[![Go Report Card](https://goreportcard.com/badge/github.com/ravilushqa/otelgqlgen)](https://goreportcard.com/report/github.com/ravilushqa/otelgqlgen)
[![codecov](https://codecov.io/gh/ravilushqa/otelgqlgen/branch/main/graph/badge.svg?token=4LXALH3K72)](https://codecov.io/gh/ravilushqa/otelgqlgen)
[![Go Reference](https://pkg.go.dev/badge/github.com/ravilushqa/otelgqlgen.svg)](https://pkg.go.dev/github.com/ravilushqa/otelgqlgen)

Es una instrumentación OpenTelemetry para Golang 99designs/gqlgen, un port de https://github.com/open-telemetry/opentelemetry-go-contrib/pull/761.

Solo puede instrumentar trazas por el momento.

## Instalación

Para instalar el paquete otelgqlgen, use el siguiente comando:

```bash
go get github.com/ravilushqa/otelgqlgen
```

## Uso

A continuación se muestra un ejemplo básico de cómo usar otelgqlgen:

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

### Opciones de Configuración

otelgqlgen proporciona varias opciones para personalizar el comportamiento del trazado:

- `WithTracerProvider(provider)`: Especifica un proveedor de trazadores personalizado. Por defecto, se utiliza el proveedor global de trazadores de OpenTelemetry.
- `WithComplexityExtensionName(name)`: Especifica un nombre para la extensión de complejidad. Por defecto, se genera un nombre automáticamente.
- `WithRequestVariablesAttributesBuilder(builder)`: Especifica una función personalizada para construir los atributos de las variables de la solicitud.
- `WithoutVariables()`: Deshabilita los atributos de variables.
- `WithCreateSpanFromFields(predicate)`: Especifica una función personalizada para controlar si se debe crear un span basado en los campos del contexto GraphQL.
- `WithInterceptResponseResultHandlerFunc(handler)`: Especifica una función personalizada para interceptar y manejar los resultados de respuestas GraphQL antes de que sean devueltos.
- `WithInterceptFieldsResultHandlerFunc(handler)`: Especifica una función personalizada para interceptar y manejar los resultados y errores a nivel de campos GraphQL durante la ejecución.

## Ejemplo

Ver [./example](./example).

## Compatibilidad

Este proyecto ha sido probado en los siguientes sistemas.

| SO      | Versión de Go | Arquitectura |
| ------- | ------------- | ------------ |
| Ubuntu  | 1.23          | amd64        |
| Ubuntu  | 1.24          | amd64        |
| Ubuntu  | 1.23          | 386          |
| Ubuntu  | 1.24          | 386          |
| MacOS   | 1.23          | amd64        |
| MacOS   | 1.24          | amd64        |
| Windows | 1.23          | amd64        |
| Windows | 1.24          | amd64        |
| Windows | 1.23          | 386          |
| Windows | 1.24          | 386          |

Aunque este proyecto debería funcionar en otros sistemas, actualmente no se garantizan
compatibilidades para esos sistemas.

El proyecto sigue la [Política de Lanzamientos](https://golang.org/doc/devel/release#policy) para soportar las versiones principales de Go.


## Referencias

- [GraphQL](https://graphql.org/)
- [gqlgen](https://gqlgen.com)

## Licencia

Este proyecto está licenciado bajo la Licencia Apache, Versión 2.0. Consulte el archivo LICENSE para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---