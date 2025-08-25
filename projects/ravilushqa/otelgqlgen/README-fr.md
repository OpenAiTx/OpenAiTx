# OpenTelemetry-Go gqlgen Instrumentation

[![ci](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml)
[![Go Report Card](https://goreportcard.com/badge/github.com/ravilushqa/otelgqlgen)](https://goreportcard.com/report/github.com/ravilushqa/otelgqlgen)
[![codecov](https://codecov.io/gh/ravilushqa/otelgqlgen/branch/main/graph/badge.svg?token=4LXALH3K72)](https://codecov.io/gh/ravilushqa/otelgqlgen)
[![Go Reference](https://pkg.go.dev/badge/github.com/ravilushqa/otelgqlgen.svg)](https://pkg.go.dev/github.com/ravilushqa/otelgqlgen)

C’est une instrumentation OpenTelemetry pour Golang 99designs/gqlgen, un portage de https://github.com/open-telemetry/opentelemetry-go-contrib/pull/761.

Elle ne peut instrumenter que les traces pour le moment.

## Installation

Pour installer le paquet otelgqlgen, utilisez la commande suivante :

```bash
go get github.com/ravilushqa/otelgqlgen
```

## Utilisation

Voici un exemple basique de comment utiliser otelgqlgen :

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
### Options de Configuration

otelgqlgen fournit plusieurs options pour personnaliser le comportement du traçage :

- `WithTracerProvider(provider)`: Spécifie un fournisseur de traceur personnalisé. Par défaut, le fournisseur de traceur global OpenTelemetry est utilisé.
- `WithComplexityExtensionName(name)`: Spécifie un nom pour l'extension de complexité. Par défaut, un nom est généré automatiquement.
- `WithRequestVariablesAttributesBuilder(builder)`: Spécifie une fonction personnalisée pour construire les attributs des variables de requête.
- `WithoutVariables()`: Désactive les attributs des variables.
- `WithCreateSpanFromFields(predicate)`: Spécifie une fonction personnalisée pour contrôler si un span doit être créé en fonction des champs du contexte GraphQL.
- `WithInterceptResponseResultHandlerFunc(handler)`: Spécifie une fonction personnalisée pour intercepter et gérer les résultats des réponses GraphQL avant qu'ils ne soient retournés.
- `WithInterceptFieldsResultHandlerFunc(handler)`: Spécifie une fonction personnalisée pour intercepter et gérer les résultats et erreurs au niveau des champs GraphQL durant l'exécution.

## Exemple

Voir [./example](./example).

## Compatibilité

Ce projet est testé sur les systèmes suivants.

| OS      | Version Go | Architecture |
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

Bien que ce projet devrait fonctionner pour d'autres systèmes, aucune garantie de compatibilité
n'est actuellement donnée pour ces systèmes.

Le projet suit la [Politique de Publication](https://golang.org/doc/devel/release#policy) pour supporter les principales versions de Go.



## Références

- [GraphQL](https://graphql.org/)
- [gqlgen](https://gqlgen.com)

## Licence

Ce projet est sous licence Apache, version 2.0. Voir le fichier LICENSE pour plus de détails.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---