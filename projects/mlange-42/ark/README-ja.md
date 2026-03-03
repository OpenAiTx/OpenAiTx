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

Arkは、[Go](https://go.dev/)向けのアーキタイプベースの[エンティティコンポーネントシステム](https://ja.wikipedia.org/wiki/Entity_component_system) (ECS)です。

&mdash;&mdash;

[特徴](#features) &nbsp; &bull; &nbsp; [インストール](#installation) &nbsp; &bull; &nbsp; [使い方](#usage) &nbsp; &bull; &nbsp; [ツール](#tools)
</div>

## 特徴

- パフォーマンスを重視して高度に最適化されています。[ベンチマーク](https://mlange-42.github.io/ark/benchmarks/)をご覧ください。
- 良く文書化され、型安全な[API](https://pkg.go.dev/github.com/mlange-42/ark)と包括的な[ユーザーガイド](https://mlange-42.github.io/ark/)。
- 一級の機能としての[エンティティ関係](https://mlange-42.github.io/ark/relations/)。
- フィルタリングおよびカスタムイベントタイプを備えた拡張可能な[イベントシステム](https://mlange-42.github.io/ark/events/)。
- 大量操作のための高速な[バッチ操作](https://mlange-42.github.io/ark/batch/)。
- システムはありません。ただクエリを使用してください。独自の構造体（または[ツール](https://github.com/mlange-42/ark#tools)）を使用可能。
- [ark-serde](https://github.com/mlange-42/ark-serde)によるワールドのシリアライズとデシリアライズ。
- 依存関係ゼロ([dependencies](https://github.com/mlange-42/ark/blob/main/go.mod))、100%の[テストカバレッジ](https://app.codecov.io/github/mlange-42/ark)。

## インストール

GoプロジェクトでArkを使用するには、次のコマンドを実行します:

```shell
go get github.com/mlange-42/ark
```

## 使用法

以下は、すべてのECSドキュメントで示されている古典的な位置/速度の例です。

詳細については、[ユーザーガイド](https://mlange-42.github.io/ark/)、[APIドキュメント](https://pkg.go.dev/github.com/mlange-42/ark)、および[例](https://github.com/mlange-42/ark/tree/main/examples)を参照してください。

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
## ツール

- [ark-serde](https://github.com/mlange-42/ark-serde) は Ark の World の JSON シリアライズおよびデシリアライズを提供します。
- [ark-tools](https://github.com/mlange-42/ark-tools) は Ark のためのシステム、スケジューラ、およびその他の便利なものを提供します。
- [ark-pixel](https://github.com/mlange-42/ark-pixel) は [Pixel](https://github.com/gopxl/pixel) ゲームエンジンを介して OpenGL グラフィックスとライブプロットを提供します。

## 引用方法

Lange, M. & contributors (2025): Ark &ndash; Go のためのアーキタイプベースのエンティティコンポーネントシステム。DOI: [10.5281/zenodo.14994239](https://doi.org/10.5281/zenodo.14994239)、GitHub リポジトリ: https://github.com/mlange-42/ark

## ライセンス

Ark とそのすべてのソースおよびドキュメントは、[MIT ライセンス](./LICENSE-MIT) と [Apache 2.0 ライセンス](./LICENSE-APACHE) のいずれかのオプションで配布されます。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---