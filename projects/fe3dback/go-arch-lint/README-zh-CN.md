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
详情请参见[配置语法](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/docs/syntax/README.md)。

现在，linter 将检查 `internal` 工作目录内的所有项目代码，
当代码违反这些规则时会显示警告。

为了获得最佳体验，您可以将 linter 集成到 CI 流程中。

### 代码错误示例

假设有一个 `main.go`，我们将 `repository` 传入 `handler` 并出现一些不良的
流程：
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
Linter 会轻松发现此问题：

![检查标准输出示例](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/check-example.png)

### 安装/运行

#### 使用 Docker
</translate-content>
```bash
docker run --rm -v ${PWD}:/app fe3dback/go-arch-lint:latest-stable-release check --project-path /app
```
[其他 docker 标签和版本](https://hub.docker.com/r/fe3dback/go-arch-lint/tags)

#### 从源码编译
需要 go 1.20+


```bash
go install github.com/fe3dback/go-arch-lint@latest
```

```bash
go-arch-lint check --project-path ~/code/my-project
# or
cd ~/code/my-project
go-arch-lint check
```
#### 预编译二进制文件

[查看发布页面](https://github.com/fe3dback/go-arch-lint/releases)

### IDE 插件，提供自动补全及其他辅助功能

<img src="https://user-images.githubusercontent.com/2073883/104641610-0f453900-56bb-11eb-8419-6d94fbcb4d2f.png" alt="jetbrains goland logo" align="left" width="80px" height="80px">

https://plugins.jetbrains.com/plugin/15423-goarchlint-file-support

## 使用方法

### 如何将 linter 添加到现有项目？

![添加 linter 的步骤](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/add-linter-steps.png)

将 linter 添加到项目中需要几个步骤：

1. 项目的当前状态
2. 创建一个 `.go-arch-lint.yml` 文件，描述理想的项目架构
3. Linter 在项目中发现一些问题。此时不必立刻修复，而是通过将它们添加到配置中并用标签标记为 `todo` 来“合法化”
4. 在空闲时间、技术债务等情况下修复代码
5. 修复后，清理配置以达到目标状态

### 执行


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
该 linter 将返回：

| 状态码       | 描述                             |
|-------------|----------------------------------|
| 0           | 项目架构正确                    |
| 1           | 发现警告                        |


### 工作原理是什么？

![工作原理](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/how-is-working.png)

Linter 将：
- 匹配/标记 **go 包** 与 **组件**
- 查找组件间的所有依赖关系
- 构建依赖图
- 比较实际（代码）和期望（配置）的依赖图
- 如果存在非空差异，则项目存在一些问题

## 图示

本仓库的示例配置： [.go-arch-lint.yml](.go-arch-lint.yml)

![图示](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/graph-example.png)

您可以使用 `graph` 命令生成依赖关系图：


```bash
go-arch-lint graph
```
查看完整的[图形文档](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/docs/graph/README.md)了解详情。

### 提交前检查

go-arch-lint 也可以用作提交前钩子，在每次提交前运行。  
这对于始终检查您的新代码是否仍符合仓库架构，以及始终更新图形 SVG 非常有用。

1. 从 [https://pre-commit.com/#install](https://pre-commit.com/#install) 安装 pre-commit
2. 在您的仓库根目录创建一个 `.pre-commit-config.yaml` 文件，内容如下：


```go
repos:
  - repo: https://github.com/fe3dback/go-arch-lint
    rev: master
    hooks:
      - id: go-arch-lint-check
      - id: go-arch-lint-graph
        args: ['--include-vendors=true', '--out=go-arch-lint-graph.svg']
```
3. 如果需要，在 `args` 中添加任何你需要的标志。  
4. 通过执行 `pre-commit autoupdate` 自动将配置更新到最新的仓库版本。  
5. 使用 `pre-commit install` 进行安装。  
6. 现在一切就绪！尝试一次提交，查看日志（通过或失败）。  
   



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---