![Logo image](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/logo.png)

Linter used to enforce some good project structure and validate top level architecture (code layers) 

[![Go Report Card](https://goreportcard.com/badge/github.com/fe3dback/go-arch-lint)](https://goreportcard.com/report/github.com/fe3dback/go-arch-lint)
[![go-recipes](https://raw.githubusercontent.com/nikolaydubina/go-recipes/main/badge.svg?raw=true)](https://github.com/nikolaydubina/go-recipes)

## Quick start

### What exactly is project architecture?

You can imagine some simple architecture, for example classic onion part from "clean architecture":

![Layouts example](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/layout_example.png)

And describe/declare it as semantic yaml linter config:

```yaml
version: 3
workdir: internal
components:
  handler:    { in: handlers/* }           # wildcard one level
  service:    { in: services/** }          # wildcard many levels
  repository: { in: domain/*/repository }  # wildcard DDD repositories
  model:      { in: models }               # match exactly one package

commonComponents:
  - models

deps:
  handler:
    mayDependOn:
      - service
  service:
    mayDependOn:
      - repository
```
<translate-content>
자세한 내용은 [구성 문법](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/docs/syntax/README.md)을 참조하세요. 

이제 린터가 `internal` 작업 디렉토리 내의 모든 프로젝트 코드를 검사하고
규칙을 위반하는 경우 경고를 표시합니다.

최적의 사용을 위해 린터를 CI 워크플로우에 추가할 수 있습니다.

### 깨진 코드 예시

예를 들어 `main.go`에서 `handler`에 `repository`를 제공하고 다음과 같은 나쁜
흐름이 발생한다고 가정해 봅시다:
</translate-content>
```go
func main() {
  // ..
  repository := booksRepository.NewRepository()
  handler := booksHandler.NewHandler(
    service,
    repository, // !!!
  )
  // ..
}
```
<translate-content>
린터가 이 문제를 쉽게 찾아냅니다:

![출력 예시 확인](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/check-example.png)

### 설치/실행

#### Docker로
</translate-content>
```bash
docker run --rm -v ${PWD}:/app fe3dback/go-arch-lint:latest-stable-release check --project-path /app
```
[다른 도커 태그 및 버전](https://hub.docker.com/r/fe3dback/go-arch-lint/tags)

#### 소스에서
Go 1.20 이상이 필요합니다


```bash
go install github.com/fe3dback/go-arch-lint@latest
```

```bash
go-arch-lint check --project-path ~/code/my-project
# or
cd ~/code/my-project
go-arch-lint check
```
#### 사전 컴파일된 바이너리

[릴리즈 페이지에서 보기](https://github.com/fe3dback/go-arch-lint/releases)

### 자동완성 및 기타 도움을 위한 IDE 플러그인

<img src="https://user-images.githubusercontent.com/2073883/104641610-0f453900-56bb-11eb-8419-6d94fbcb4d2f.png" alt="jetbrains goland logo" align="left" width="80px" height="80px">

https://plugins.jetbrains.com/plugin/15423-goarchlint-file-support

## 사용법

### 기존 프로젝트에 린터를 추가하는 방법?

![린터 추가 단계](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/add-linter-steps.png)

프로젝트에 린터를 추가하는 데는 여러 단계가 필요합니다:

1. 프로젝트의 현재 상태
2. 이상적인 프로젝트 아키텍처를 설명하는 `.go-arch-lint.yml` 파일 생성
3. 린터가 프로젝트에서 몇 가지 문제를 발견합니다. 지금 바로 수정하지 말고, 구성에 추가하여 `todo` 레이블로 “합법화”하세요
4. 자유 시간, 기술 부채 등에서 코드를 수정하세요
5. 수정 후 목표 상태로 구성을 정리하세요

### 실행하기


```
Usage:
  go-arch-lint check [flags]

Flags:
      --arch-file string      arch file path (default ".go-arch-lint.yml")
  -h, --help                  help for check
      --max-warnings int      max number of warnings to output (default 512)
      --project-path string   absolute path to project directory (where '.go-arch-lint.yml' is located) (default "./")

Global Flags:
      --json                   (alias for --output-type=json)
      --output-color           use ANSI colors in terminal output (default true)
      --output-json-one-line   format JSON as single line payload (without line breaks), only for json output type
      --output-type string     type of command output, variants: [ascii, json] (default "default")
```
이 린터는 다음을 반환합니다:

| 상태 코드 | 설명                             |
|-----------|---------------------------------|
| 0         | 프로젝트가 올바른 아키텍처를 가짐 |
| 1         | 경고가 발견됨                   |


### 어떻게 작동하나요?

![작동 방식](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/how-is-working.png)

린터는:
- **go 패키지**를 **컴포넌트**와 매칭/표시합니다
- 컴포넌트 간 모든 의존성을 찾습니다
- 의존성 그래프를 구축합니다
- 실제(코드)와 원하는(설정) 의존성 그래프를 비교합니다
- 비어있지 않은 DIFF가 있으면 프로젝트에 문제가 있는 것입니다

## 그래프

이 저장소의 예제 설정: [.go-arch-lint.yml](.go-arch-lint.yml)

![그래프](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/graph-example.png)

`graph` 명령어로 의존성 그래프를 생성할 수 있습니다:


```bash
go-arch-lint graph
```
전체 세부 사항은 [그래프 문서](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/docs/graph/README.md)를 참조하세요.

### 프리 커밋

go-arch-lint는 커밋이 이루어지기 전에 작동하는 프리 커밋 훅으로도 사용할 수 있습니다.  
이는 새 코드가 여전히 저장소 아키텍처를 준수하는지 항상 확인하고 그래프 SVG를 항상 업데이트하는 데 유용합니다.

1. [https://pre-commit.com/#install](https://pre-commit.com/#install)에서 pre-commit을 설치하세요.
2. 저장소 루트에 다음 내용을 포함한 `.pre-commit-config.yaml` 파일을 만드세요:


```go
repos:
  - repo: https://github.com/fe3dback/go-arch-lint
    rev: master
    hooks:
      - id: go-arch-lint-check
      - id: go-arch-lint-graph
        args: ['--include-vendors=true', '--out=go-arch-lint-graph.svg']
```
3. 필요에 따라 `args`에 필요한 플래그를 추가하세요.  
4. `pre-commit autoupdate`를 실행하여 구성 파일을 최신 저장소 버전으로 자동 업데이트하세요.  
5. `pre-commit install`로 설치하세요.  
6. 이제 모두 준비되었습니다! 커밋을 시도하고 로그(성공 또는 실패)를 확인하세요.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---