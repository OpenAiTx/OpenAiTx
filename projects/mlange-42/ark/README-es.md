<div align="center" width="100%">
<a href="https://github.com/mlange-42/ark">
<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-dark.svg">
  <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-light.svg">
  <img alt="Ark Logo" src="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-light.svg">
</picture>
</a>

[![Test status](https://img.shields.io/github/actions/workflow/status/mlange-42/ark/tests.yml?branch=main&label=Tests&logo=github)](https://github.com/mlange-42/ark/actions/workflows/tests.yml)
[![codecov](https://codecov.io/github/mlange-42/ark/graph/badge.svg?token=YMYMFN2ESZ)](https://codecov.io/github/mlange-42/ark)
[![Go Report Card](https://goreportcard.com/badge/github.com/mlange-42/ark)](https://goreportcard.com/report/github.com/mlange-42/ark)
[![User Guide](https://img.shields.io/badge/user_guide-%23007D9C?logo=go&logoColor=white&labelColor=gray)](https://mlange-42.github.io/ark/)
[![Go Reference](https://img.shields.io/badge/reference-%23007D9C?logo=go&logoColor=white&labelColor=gray)](https://pkg.go.dev/github.com/mlange-42/ark)
[![GitHub](https://img.shields.io/badge/github-repo-blue?logo=github)](https://github.com/mlange-42/ark)
[![DOI:10.5281/zenodo.14994239](https://img.shields.io/badge/10.5281%2Fzenodo.14994239-blue?label=doi)](https://doi.org/10.5281/zenodo.14994239)
[![MIT license](https://img.shields.io/badge/MIT-brightgreen?label=license)](https://github.com/mlange-42/ark/blob/main/LICENSE-MIT)
[![Apache 2.0 license](https://img.shields.io/badge/Apache%202.0-brightgreen?label=license)](https://github.com/mlange-42/ark/blob/main/LICENSE-APACHE)
[![Mentioned in Awesome Go](https://awesome.re/mentioned-badge.svg)](https://github.com/avelino/awesome-go)

Ark es un [Entity Component System](https://es.wikipedia.org/wiki/Entity_component_system) (ECS) basado en arquetipos para [Go](https://go.dev/).

&mdash;&mdash;

[Características](#features) &nbsp; &bull; &nbsp; [Instalación](#installation) &nbsp; &bull; &nbsp; [Uso](#usage) &nbsp; &bull; &nbsp; [Herramientas](#tools)
</div>

## Características

- Diseñado para rendimiento y altamente optimizado. Vea los [Benchmarks](https://mlange-42.github.io/ark/benchmarks/).
- API bien documentada y segura en tipos, y una completa [Guía del usuario](https://mlange-42.github.io/ark/).
- [Relaciones entre entidades](https://mlange-42.github.io/ark/relations/) como característica de primera clase.
- Sistema de [eventos](https://mlange-42.github.io/ark/events/) extensible con filtrado y tipos de eventos personalizados.
- Operaciones en [lote](https://mlange-42.github.io/ark/batch/) rápidas para manipulación masiva.
- Sin sistemas. Solo consultas. Use su propia estructura (o las [Herramientas](https://github.com/mlange-42/ark#tools)).
- Serialización y deserialización del mundo con [ark-serde](https://github.com/mlange-42/ark-serde).
- Cero [dependencias](https://github.com/mlange-42/ark/blob/main/go.mod), 100% de [cobertura de pruebas](https://app.codecov.io/github/mlange-42/ark).

## Instalación

Para usar Ark en un proyecto de Go, ejecute:

```shell
go get github.com/mlange-42/ark
```

## Uso

A continuación se muestra el ejemplo clásico de Posición/Velocidad que todos los ECS muestran en la documentación.

Consulte la [Guía del Usuario](https://mlange-42.github.io/ark/), la [documentación API](https://pkg.go.dev/github.com/mlange-42/ark) y los [ejemplos](https://github.com/mlange-42/ark/tree/main/examples) para más detalles.

```go
package main

import (
	"math/rand/v2"
	"github.com/mlange-42/ark/ecs"
)

// Position component
type Position struct {
	X, Y float64
}

// Velocity component
type Velocity struct {
	DX, DY float64
}

func main() {
	// Create a new World
	world := ecs.NewWorld()

	// Create a component mapper
	// Save mappers permanently and re-use them for best performance
	mapper := ecs.NewMap2[Position, Velocity](world)

	// Create entities with components
	for range 1000 {
		_ = mapper.NewEntity(
			&Position{X: rand.Float64() * 100, Y: rand.Float64() * 100},
			&Velocity{DX: rand.NormFloat64(), DY: rand.NormFloat64()},
		)
	}

	// Create a filter
	// Save filters permanently and re-use them for best performance
	filter := ecs.NewFilter2[Position, Velocity](world)

	// Time loop
	for range 5000 {
		// Get a fresh query and iterate it
		query := filter.Query()
		for query.Next() {
			// Component access through the Query
			pos, vel := query.Get()
			// Update component fields
			pos.X += vel.DX
			pos.Y += vel.DY
		}
	}
}
```

## Herramientas

- [ark-serde](https://github.com/mlange-42/ark-serde) proporciona serialización y deserialización JSON para Ark's World.
- [ark-tools](https://github.com/mlange-42/ark-tools) ofrece sistemas, un programador y otras utilidades para Ark.
- [ark-pixel](https://github.com/mlange-42/ark-pixel) proporciona gráficos OpenGL y gráficos en vivo mediante el motor de juego [Pixel](https://github.com/gopxl/pixel).

## Citar como

Lange, M. & colaboradores (2025): Ark &ndash; Un sistema de componentes de entidad basado en arquetipos para Go. DOI: [10.5281/zenodo.14994239](https://doi.org/10.5281/zenodo.14994239), Repositorio GitHub: https://github.com/mlange-42/ark

## Licencia

Ark y todos sus códigos fuente y documentación se distribuyen bajo la [licencia MIT](./LICENSE-MIT) y la [licencia Apache 2.0](./LICENSE-APACHE), según su preferencia.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---