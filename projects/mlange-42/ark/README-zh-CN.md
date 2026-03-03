<div align="center" width="100%">
<a href="https://github.com/mlange-42/ark">
<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-dark.svg">
  <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-light.svg">
  <img alt="Ark Logo" src="https://raw.githubusercontent.com/mlange-42/ark/refs/heads/main/docs/static/images/ark-logo-text-light.svg">
</picture>
</a>

[![测试状态](https://img.shields.io/github/actions/workflow/status/mlange-42/ark/tests.yml?branch=main&label=Tests&logo=github)](https://github.com/mlange-42/ark/actions/workflows/tests.yml)
[![codecov](https://codecov.io/github/mlange-42/ark/graph/badge.svg?token=YMYMFN2ESZ)](https://codecov.io/github/mlange-42/ark)
[![Go 报告卡](https://goreportcard.com/badge/github.com/mlange-42/ark)](https://goreportcard.com/report/github.com/mlange-42/ark)
[![用户指南](https://img.shields.io/badge/user_guide-%23007D9C?logo=go&logoColor=white&labelColor=gray)](https://mlange-42.github.io/ark/)
[![Go 参考](https://img.shields.io/badge/reference-%23007D9C?logo=go&logoColor=white&labelColor=gray)](https://pkg.go.dev/github.com/mlange-42/ark)
[![GitHub](https://img.shields.io/badge/github-repo-blue?logo=github)](https://github.com/mlange-42/ark)
[![DOI:10.5281/zenodo.14994239](https://img.shields.io/badge/10.5281%2Fzenodo.14994239-blue?label=doi)](https://doi.org/10.5281/zenodo.14994239)
[![MIT 许可证](https://img.shields.io/badge/MIT-brightgreen?label=license)](https://github.com/mlange-42/ark/blob/main/LICENSE-MIT)
[![Apache 2.0 许可证](https://img.shields.io/badge/Apache%202.0-brightgreen?label=license)](https://github.com/mlange-42/ark/blob/main/LICENSE-APACHE)
[![在 Awesome Go 中被提及](https://awesome.re/mentioned-badge.svg)](https://github.com/avelino/awesome-go)

Ark 是一个基于原型的 [实体组件系统](https://en.wikipedia.org/wiki/Entity_component_system)（ECS），适用于 [Go](https://go.dev/)。

&mdash;&mdash;

[特性](#features) &nbsp; &bull; &nbsp; [安装](#installation) &nbsp; &bull; &nbsp; [用法](#usage) &nbsp; &bull; &nbsp; [工具](#tools)
</div>

## 特性

- 设计注重性能且高度优化。详见[基准测试](https://mlange-42.github.io/ark/benchmarks/)。
- 文档完善，类型安全的[API](https://pkg.go.dev/github.com/mlange-42/ark)，以及全面的[用户指南](https://mlange-42.github.io/ark/)。
- 将[实体关系](https://mlange-42.github.io/ark/relations/)作为一等公民特性。
- 可扩展的[事件系统](https://mlange-42.github.io/ark/events/)，支持过滤和自定义事件类型。
- 快速的[批量操作](https://mlange-42.github.io/ark/batch/)，用于大规模操作。
- 无系统概念。仅使用查询。使用你自己的结构（或[工具](https://github.com/mlange-42/ark#tools)）。
- 支持通过 [ark-serde](https://github.com/mlange-42/ark-serde) 进行世界的序列化与反序列化。
- 零[依赖](https://github.com/mlange-42/ark/blob/main/go.mod)，100%[测试覆盖率](https://app.codecov.io/github/mlange-42/ark)。

## 安装

要在 Go 项目中使用 Ark，请运行：

```shell
go get github.com/mlange-42/ark
```

## 使用方法

下面是每个 ECS 文档中展示的经典位置/速度示例。

详情请参阅[用户指南](https://mlange-42.github.io/ark/)、[API 文档](https://pkg.go.dev/github.com/mlange-42/ark)和[示例](https://github.com/mlange-42/ark/tree/main/examples)。

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

## 工具

- [ark-serde](https://github.com/mlange-42/ark-serde) 为 Ark 的世界提供 JSON 序列化和反序列化。
- [ark-tools](https://github.com/mlange-42/ark-tools) 提供系统、调度器及其他对 Ark 有用的功能。
- [ark-pixel](https://github.com/mlange-42/ark-pixel) 通过 [Pixel](https://github.com/gopxl/pixel) 游戏引擎提供 OpenGL 图形和实时绘图。

## 引用方式

Lange, M. & contributors (2025)：Ark – 基于原型的 Go 语言实体组件系统。DOI：[10.5281/zenodo.14994239](https://doi.org/10.5281/zenodo.14994239)，GitHub 仓库：https://github.com/mlange-42/ark

## 许可证

Ark 及其所有源代码和文档均根据 [MIT 许可证](./LICENSE-MIT) 和 [Apache 2.0 许可证](./LICENSE-APACHE) 进行分发，供您选择。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---