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
see [config syntax](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/docs/syntax/README.md) for details. 

そして今、リンターは `internal` 作業ディレクトリ内のすべてのプロジェクトコードをチェックし、
このルールに違反するコードがあれば警告を表示します。

最良の体験のために、リンターをCIワークフローに追加することができます。

### 壊れたコードの例

例えば、`main.go` で `repository` を `handler` に渡し、悪い
フローが発生する場合を想像してください：


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
Linterはこの問題を簡単に見つけます：

![Check stdout example](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/check-example.png)

### インストール／実行

#### Dockerでの利用


```bash
docker run --rm -v ${PWD}:/app fe3dback/go-arch-lint:latest-stable-release check --project-path /app
```
[その他のdockerタグとバージョン](https://hub.docker.com/r/fe3dback/go-arch-lint/tags)

#### ソースから
Go 1.20以上が必要です。


```bash
go install github.com/fe3dback/go-arch-lint@latest
```

```bash
go-arch-lint check --project-path ~/code/my-project
# or
cd ~/code/my-project
go-arch-lint check
```
#### 事前コンパイル済みバイナリ

[リリースページを見る](https://github.com/fe3dback/go-arch-lint/releases)

### 自動補完やその他支援のためのIDEプラグイン

<img src="https://user-images.githubusercontent.com/2073883/104641610-0f453900-56bb-11eb-8419-6d94fbcb4d2f.png" alt="jetbrains goland logo" align="left" width="80px" height="80px">

https://plugins.jetbrains.com/plugin/15423-goarchlint-file-support

## 使用方法

### 既存プロジェクトにリンターを追加するには？

![リンター追加手順](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/add-linter-steps.png)

プロジェクトにリンターを追加するにはいくつかのステップがあります:

1. プロジェクトの現状
2. 理想的なプロジェクトアーキテクチャを記述した `.go-arch-lint.yml` ファイルを作成
3. リンターがプロジェクト内のいくつかの問題を検出。今すぐ修正せず、設定に追加し `todo` ラベルで「合法化」する
4. 空き時間や技術的負債の解消などでコードを修正
5. 修正後、設定をターゲット状態にクリーンアップ

### 実行する際は


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
このリンターは以下を返します：

| ステータスコード | 説明                              |
|-----------------|----------------------------------|
| 0               | プロジェクトは正しいアーキテクチャです |
| 1               | 警告が見つかりました               |


### 仕組みは？

![仕組み](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/how-is-working.png)

リンターは以下を行います：
- **goパッケージ**を**コンポーネント**にマッチ/マークする
- コンポーネント間のすべての依存関係を見つける
- 依存関係グラフを構築する
- 実際の（コード）と望ましい（設定）依存関係グラフを比較する
- 空でないDIFFがあれば、プロジェクトに問題があることを示す

## グラフ

このリポジトリの設定例： [.go-arch-lint.yml](.go-arch-lint.yml)

![グラフ](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/./docs/images/graph-example.png)

`graph`コマンドで依存関係グラフを生成できます：


```bash
go-arch-lint graph
```
詳細については、完全な[グラフドキュメント](https://raw.githubusercontent.com/fe3dback/go-arch-lint/master/docs/graph/README.md)を参照してください。

### Pre-Commit

go-arch-lintは、コミットが行われる前に動作するpre-commitフックとしても使用できます。  
これは、新しいコードが常にリポジトリのアーキテクチャを尊重していることを確認し、グラフSVGを常に更新するのに役立ちます。

1. [https://pre-commit.com/#install](https://pre-commit.com/#install)からpre-commitをインストールします
2. リポジトリのルートに以下の内容で`.pre-commit-config.yaml`ファイルを作成します:


```go
repos:
  - repo: https://github.com/fe3dback/go-arch-lint
    rev: master
    hooks:
      - id: go-arch-lint-check
      - id: go-arch-lint-graph
        args: ['--include-vendors=true', '--out=go-arch-lint-graph.svg']
```
3. 必要に応じて、`args` に必要なフラグを追加します。  
4. `pre-commit autoupdate` を実行して、設定を最新のリポジトリのバージョンに自動更新します。  
5. `pre-commit install` でインストールします。  
6. これで準備完了です！コミットを試して、ログ（成功または失敗）を確認してください。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---