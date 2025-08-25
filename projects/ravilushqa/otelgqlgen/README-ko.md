# OpenTelemetry-Go gqlgen 계측

[![ci](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/ravilushqa/otelgqlgen/actions/workflows/ci.yaml)
[![Go Report Card](https://goreportcard.com/badge/github.com/ravilushqa/otelgqlgen)](https://goreportcard.com/report/github.com/ravilushqa/otelgqlgen)
[![codecov](https://codecov.io/gh/ravilushqa/otelgqlgen/branch/main/graph/badge.svg?token=4LXALH3K72)](https://codecov.io/gh/ravilushqa/otelgqlgen)
[![Go Reference](https://pkg.go.dev/badge/github.com/ravilushqa/otelgqlgen.svg)](https://pkg.go.dev/github.com/ravilushqa/otelgqlgen)

이것은 Golang 99designs/gqlgen용 OpenTelemetry 계측으로, https://github.com/open-telemetry/opentelemetry-go-contrib/pull/761에서 포팅한 것입니다.

현재는 추적(trace)만 계측할 수 있습니다.

## 설치

otelgqlgen 패키지를 설치하려면 다음 명령어를 사용하세요:

```bash
go get github.com/ravilushqa/otelgqlgen
```

## 사용법

아래는 otelgqlgen을 사용하는 기본 예제입니다:

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
### 구성 옵션

otelgqlgen은 추적 동작을 사용자 정의할 수 있는 여러 옵션을 제공합니다:

- `WithTracerProvider(provider)`: 사용자 정의 트레이서 프로바이더를 지정합니다. 기본적으로 전역 OpenTelemetry 트레이서 프로바이더가 사용됩니다.
- `WithComplexityExtensionName(name)`: 복잡성 확장에 대한 이름을 지정합니다. 기본적으로 이름은 자동으로 생성됩니다.
- `WithRequestVariablesAttributesBuilder(builder)`: 요청 변수의 속성을 빌드하는 사용자 정의 함수를 지정합니다.
- `WithoutVariables()`: 변수 속성을 비활성화합니다.
- `WithCreateSpanFromFields(predicate)`: GraphQL 컨텍스트 필드를 기반으로 스팬을 생성할지 여부를 제어하는 사용자 정의 함수를 지정합니다.
- `WithInterceptResponseResultHandlerFunc(handler)`: GraphQL 응답 결과가 반환되기 전에 이를 가로채고 처리하는 사용자 정의 함수를 지정합니다.
- `WithInterceptFieldsResultHandlerFunc(handler)`: 실행 중 GraphQL 필드 수준 결과 및 오류를 가로채고 처리하는 사용자 정의 함수를 지정합니다.

## 예제

[./example](./example)을 참조하세요.

## 호환성

이 프로젝트는 다음 시스템에서 테스트되었습니다.

| 운영체제 | Go 버전    | 아키텍처    |
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

이 프로젝트는 다른 시스템에서도 작동할 수 있지만, 현재로서는 해당 시스템들에 대한 호환성 보장은 없습니다.

이 프로젝트는 주요 Go 릴리스를 지원하기 위해 [릴리스 정책](https://golang.org/doc/devel/release#policy)을 따릅니다.




## 참고문헌

- [GraphQL](https://graphql.org/)
- [gqlgen](https://gqlgen.com)

## 라이선스

이 프로젝트는 Apache License, Version 2.0에 따라 라이선스가 부여됩니다. 자세한 내용은 LICENSE 파일을 참조하십시오.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---