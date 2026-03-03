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

Ark는 [Go](https://go.dev/)용 아키타입 기반 [엔티티 컴포넌트 시스템](https://en.wikipedia.org/wiki/Entity_component_system) (ECS)입니다.

&mdash;&mdash;

[특징](#features) &nbsp; &bull; &nbsp; [설치](#installation) &nbsp; &bull; &nbsp; [사용법](#usage) &nbsp; &bull; &nbsp; [도구](#tools)
</div>

## 특징

- 성능을 위해 설계되고 매우 최적화됨. [벤치마크](https://mlange-42.github.io/ark/benchmarks/)를 참조하세요.
- 잘 문서화되고, 타입 안전한 [API](https://pkg.go.dev/github.com/mlange-42/ark)와 포괄적인 [사용자 가이드](https://mlange-42.github.io/ark/).
- 1급 기능으로서의 [엔티티 관계](https://mlange-42.github.io/ark/relations/).
- 필터링 및 사용자 정의 이벤트 타입을 지원하는 확장 가능한 [이벤트 시스템](https://mlange-42.github.io/ark/events/).
- 대량 조작을 위한 빠른 [배치 작업](https://mlange-42.github.io/ark/batch/).
- 시스템 없음. 쿼리만 있음. 자신의 구조체(또는 [도구](https://github.com/mlange-42/ark#tools))를 사용하세요.
- [ark-serde](https://github.com/mlange-42/ark-serde)를 사용한 월드 직렬화 및 역직렬화.
- 제로 [종속성](https://github.com/mlange-42/ark/blob/main/go.mod), 100% [테스트 커버리지](https://app.codecov.io/github/mlange-42/ark).

## 설치

Go 프로젝트에서 Ark를 사용하려면 다음을 실행하세요:

```shell
go get github.com/mlange-42/ark
```
## 사용법

아래는 모든 ECS 문서에 나오는 고전적인 위치/속도 예제입니다.

자세한 내용은 [사용자 가이드](https://mlange-42.github.io/ark/), [API 문서](https://pkg.go.dev/github.com/mlange-42/ark) 및 [예제](https://github.com/mlange-42/ark/tree/main/examples)를 참조하세요.


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

## 도구

- [ark-serde](https://github.com/mlange-42/ark-serde)는 Ark의 월드를 위한 JSON 직렬화 및 역직렬화를 제공합니다.
- [ark-tools](https://github.com/mlange-42/ark-tools)는 Ark를 위한 시스템, 스케줄러 및 기타 유용한 기능을 제공합니다.
- [ark-pixel](https://github.com/mlange-42/ark-pixel)은 [Pixel](https://github.com/gopxl/pixel) 게임 엔진을 통해 OpenGL 그래픽과 라이브 플롯을 제공합니다.

## 인용 방법

Lange, M. & 기여자들 (2025): Ark – Go를 위한 아키타입 기반 엔티티 컴포넌트 시스템. DOI: [10.5281/zenodo.14994239](https://doi.org/10.5281/zenodo.14994239), GitHub 저장소: https://github.com/mlange-42/ark

## 라이선스

Ark 및 모든 소스와 문서는 [MIT 라이선스](./LICENSE-MIT)와 [Apache 2.0 라이선스](./LICENSE-APACHE) 중 선택하여 배포됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---