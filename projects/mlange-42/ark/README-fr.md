<div align="center" width="100%">
<a href="https://github.com/mlange-42/ark">
<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-dark.svg">
  <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-light.svg">
  <img alt="Logo Ark" src="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-light.svg">
</picture>
</a>

[![Statut des tests](https://img.shields.io/github/actions/workflow/status/mlange-42/ark/tests.yml?branch=main&label=Tests&logo=github)](https://github.com/mlange-42/ark/actions/workflows/tests.yml)
[![codecov](https://codecov.io/github/mlange-42/ark/graph/badge.svg?token=YMYMFN2ESZ)](https://codecov.io/github/mlange-42/ark)
[![Go Report Card](https://goreportcard.com/badge/github.com/mlange-42/ark)](https://goreportcard.com/report/github.com/mlange-42/ark)
[![Guide de l'utilisateur](https://img.shields.io/badge/user_guide-%23007D9C?logo=go&logoColor=white&labelColor=gray)](https://mlange-42.github.io/ark/)
[![Référence Go](https://img.shields.io/badge/reference-%23007D9C?logo=go&logoColor=white&labelColor=gray)](https://pkg.go.dev/github.com/mlange-42/ark)
[![GitHub](https://img.shields.io/badge/github-repo-blue?logo=github)](https://github.com/mlange-42/ark)
[![DOI:10.5281/zenodo.14994239](https://img.shields.io/badge/10.5281%2Fzenodo.14994239-blue?label=doi)](https://doi.org/10.5281/zenodo.14994239)
[![Licence MIT](https://img.shields.io/badge/MIT-brightgreen?label=license)](https://github.com/mlange-42/ark/blob/main/LICENSE-MIT)
[![Licence Apache 2.0](https://img.shields.io/badge/Apache%202.0-brightgreen?label=license)](https://github.com/mlange-42/ark/blob/main/LICENSE-APACHE)
[![Mentionné dans Awesome Go](https://awesome.re/mentioned-badge.svg)](https://github.com/avelino/awesome-go)

Ark est un [Entity Component System](https://fr.wikipedia.org/wiki/Entity_component_system) (ECS) basé sur des archétypes pour [Go](https://go.dev/).

&mdash;&mdash;

[Fonctionnalités](#features) &nbsp; &bull; &nbsp; [Installation](#installation) &nbsp; &bull; &nbsp; [Utilisation](#usage) &nbsp; &bull; &nbsp; [Outils](#tools)
</div>

## Fonctionnalités

- Conçu pour la performance et hautement optimisé. Voir les [benchmarks](https://mlange-42.github.io/ark/benchmarks/).
- API bien documentée et typée en toute sécurité ([API](https://pkg.go.dev/github.com/mlange-42/ark)) ainsi qu'un [guide utilisateur](https://mlange-42.github.io/ark/).
- [Relations d'entités](https://mlange-42.github.io/ark/relations/) en tant que fonctionnalité de premier ordre.
- Système d'[événements extensible](https://mlange-42.github.io/ark/events/) avec filtrage et types d'événements personnalisés.
- Opérations [par lots rapides](https://mlange-42.github.io/ark/batch/) pour manipulations massives.
- Pas de systèmes. Juste des requêtes. Utilisez votre propre structure (ou les [outils](https://github.com/mlange-42/ark#tools)).
- Sérialisation et désérialisation du monde avec [ark-serde](https://github.com/mlange-42/ark-serde).
- Zéro [dépendances](https://github.com/mlange-42/ark/blob/main/go.mod), couverture de test à 100% ([test coverage](https://app.codecov.io/github/mlange-42/ark)).

## Installation

Pour utiliser Ark dans un projet Go, exécutez :

```shell
go get github.com/mlange-42/ark
```

## Utilisation

Ci-dessous se trouve l'exemple classique Position/Vitesse que chaque ECS montre dans la documentation.

Voir le [Guide de l'utilisateur](https://mlange-42.github.io/ark/), la [documentation API](https://pkg.go.dev/github.com/mlange-42/ark) et les [exemples](https://github.com/mlange-42/ark/tree/main/examples) pour plus de détails.

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

## Outils

- [ark-serde](https://github.com/mlange-42/ark-serde) fournit la sérialisation et la désérialisation JSON pour le Monde d'Ark.
- [ark-tools](https://github.com/mlange-42/ark-tools) fournit des systèmes, un ordonnanceur et d'autres outils utiles pour Ark.
- [ark-pixel](https://github.com/mlange-42/ark-pixel) fournit des graphiques OpenGL et des tracés en direct via le moteur de jeu [Pixel](https://github.com/gopxl/pixel).

## Citer comme

Lange, M. & contributeurs (2025) : Ark – Un système de composants entité basé sur des archétypes pour Go. DOI : [10.5281/zenodo.14994239](https://doi.org/10.5281/zenodo.14994239), dépôt GitHub : https://github.com/mlange-42/ark

## Licence

Ark ainsi que toutes ses sources et sa documentation sont distribués sous la [licence MIT](./LICENSE-MIT) et la [licence Apache 2.0](./LICENSE-APACHE), selon votre choix.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---