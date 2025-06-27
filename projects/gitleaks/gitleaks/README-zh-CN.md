# Gitleaks

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: https://raw.githubusercontent.com/gitleaks/gitleaks/master/LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### 加入我们的 Discord！ [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks 是一个用于**检测**密码、API 密钥和令牌等敏感信息的工具，可在 git 仓库、文件以及你通过 `stdin` 输入的任何内容中进行检测。如果你想了解更多关于检测引擎的工作原理，请查看这篇博客：[Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need)。

```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


发现:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
密钥:      cafebabe:deadbeef
规则ID:    sidekiq-secret
熵值:      2.609850
文件:      cmd/generate/config/rules/sidekiq.go
行号:      23
提交:      cd5226711335c68be1e720b318b7bc3135a30eb2
作者:      John
邮箱:      john@users.noreply.github.com
日期:      2022-08-03T12:31:40Z
指纹:      cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## 入门指南

Gitleaks 可通过 Homebrew、Docker 或 Go 进行安装。Gitleaks 还以二进制形式支持多种主流平台和操作系统，可在 [发布页面](https://github.com/gitleaks/gitleaks/releases) 获取。此外，Gitleaks 也可作为 pre-commit 钩子直接集成到你的仓库，或通过 [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action) 作为 GitHub Action 使用。

### 安装

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# 从源码安装（确保已安装 `go`）
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

请查看官方的 [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action)

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # 仅组织账户需要，个人账户不需要。
```

### Pre-Commit

1. 从 https://pre-commit.com/#install 安装 pre-commit
2. 在你的仓库根目录创建 `.pre-commit-config.yaml` 文件，内容如下：

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   对于 [原生方式运行 gitleaks](https://github.com/gitleaks/gitleaks/releases) 或使用 [`gitleaks-docker` pre-commit ID](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) 通过 [官方 Docker 镜像](#docker) 运行 gitleaks

3. 通过执行 `pre-commit autoupdate` 自动更新配置到最新的仓库版本
4. 执行 `pre-commit install` 进行安装
5. 现在一切就绪！

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

注意：要禁用 gitleaks pre-commit 钩子，可以在提交命令前加上 `SKIP=gitleaks`，这样就会跳过 gitleaks 检查

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## 用法

```
用法:
  gitleaks [命令]

可用命令:
  dir         扫描目录或文件中的敏感信息
  git         扫描 git 仓库中的敏感信息
  help        查看任意命令的帮助信息
  stdin       从标准输入检测敏感信息
  version     显示 gitleaks 版本信息

参数:
  -b, --baseline-path string          基线文件路径（其中的问题将被忽略）
  -c, --config string                 配置文件路径
                                      优先级顺序:
                                      1. --config/-c
                                      2. 环境变量 GITLEAKS_CONFIG
                                      3. 环境变量 GITLEAKS_CONFIG_TOML（内容为配置文件内容）
                                      4. (目标路径)/.gitleaks.toml
                                      如果四种方式都未指定，则 gitleaks 使用默认配置
      --diagnostics string            启用诊断（以逗号分隔的列表: cpu,mem,trace）。cpu=CPU 性能分析，mem=内存分析，trace=执行跟踪
      --diagnostics-dir string        存储诊断输出文件的目录（默认为当前目录）
      --enable-rule strings           仅启用指定 id 的规则
      --exit-code int                 检测到敏感信息时的退出码（默认 1）
  -i, --gitleaks-ignore-path string   .gitleaksignore 文件或包含该文件的文件夹路径（默认 “.”）
  -h, --help                          显示 gitleaks 帮助信息
      --ignore-gitleaks-allow         忽略 gitleaks:allow 注释
  -l, --log-level string              日志级别（trace, debug, info, warn, error, fatal）（默认 "info"）
      --max-decode-depth int          允许递归解码的深度（默认 "0"，不进行解码）
      --max-archive-depth int         允许扫描嵌套归档文件的深度（默认 "0"，不遍历归档）
      --max-target-megabytes int      超过该大小的文件将被跳过
      --no-banner                     不显示横幅
      --no-color                      禁用彩色输出
      --redact uint[=100]             从日志和标准输出中隐藏敏感信息。仅隐藏部分内容时，可指定百分比 0..100，例如 --redact=20（默认 100%）
  -f, --report-format string          输出格式（json, csv, junit, sarif, template）
  -r, --report-path string            报告文件路径
      --report-template string        用于生成报告的模板文件（隐含 --report-format=template）
  -v, --verbose                       显示详细扫描输出
      --version                       显示 gitleaks 版本

使用 "gitleaks [命令] --help" 获取某命令的更多信息。
```

### 命令说明

⚠️ v8.19.0 引入了变更，废弃了 `detect` 和 `protect`。这两个命令仍可用，但在 `--help` 菜单中已隐藏。你可以参考这个 [gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) 进行命令迁移。
如果你发现 v8.19.0 影响了现有的 `detect`/`protect` 命令，请提交 issue。

Gitleaks 有三种扫描模式：`git`、`dir` 和 `stdin`。

#### Git

`git` 命令用于扫描本地 git 仓库。Gitleaks 底层使用 `git log -p` 命令扫描补丁。
你可以通过 `log-opts` 选项配置 `git log -p` 的行为。
例如，若要在一系列提交上运行 gitleaks，可使用如下命令：`gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`。详见 [git log](https://git-scm.com/docs/git-log) 官方文档。
如果未指定目标路径参数，则 gitleaks 会尝试将当前工作目录作为 git 仓库进行扫描。
#### Dir

`dir`（别名包括 `files`、`directory`）命令允许你扫描目录和文件。例如：`gitleaks dir -v path_to_directory_or_file`。
如果没有指定目标作为位置参数，则 gitleaks 将扫描当前工作目录。

#### Stdin

你也可以使用 `stdin` 命令将数据流式传输到 gitleaks。例如：`cat some_file | gitleaks -v stdin`

### 创建基线

在扫描大型仓库或有着较长历史的仓库时，使用基线会很方便。当使用基线时，
gitleaks 会忽略基线中已有的历史发现。基线可以是任意 gitleaks 报告。要创建 gitleaks 报告，使用 `--report-path` 参数运行 gitleaks。

```
gitleaks git --report-path gitleaks-report.json # 这会将报告保存在名为 gitleaks-report.json 的文件中
```

基线创建后，可以在再次运行 detect 命令时应用：

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

使用 --baseline-path 参数运行 detect 命令后，报告输出（findings.json）只会包含新问题。

## Pre-Commit 钩子

你可以通过将示例 `pre-commit.py` 脚本复制到你的 `.git/hooks/` 目录下，将 Gitleaks 作为 pre-commit 钩子运行。

## 加载配置

优先级顺序如下：

1. `--config/-c` 选项：
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. 环境变量 `GITLEAKS_CONFIG`，其值为文件路径：
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. 环境变量 `GITLEAKS_CONFIG_TOML`，其值为文件内容：
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. 目标路径下的 `.gitleaks.toml` 文件：
      ```bash
      gitleaks git .
      ```

如果这四种方式都未使用，则 gitleaks 会使用默认配置。

## 配置

Gitleaks 提供了一种配置格式，你可以按照此格式编写自己的密钥检测规则：

```toml
# Gitleaks 配置文件的标题
title = "Custom Gitleaks configuration"

# 基本上你有两种自定义配置选项：
#
# 1. 定义你自己的配置，不使用默认规则
#
#    例如，可以以默认配置作为起点：
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. 扩展某个配置，规则会被覆盖或扩展
#
#    当你扩展配置时，扩展的规则具有更高优先级。
#    即，如果扩展配置与默认配置中有重复规则，扩展规则或其属性会覆盖默认规则。
#    另一点是，扩展配置时你可以将多个配置文件链式连接，最多支持两层深度。Allowlist 数组会追加，并且可以包含重复项。

# useDefault 和 path 不能同时使用，二选一。
[extend]
# useDefault 会扩展内置于二进制文件的默认 gitleaks 配置
# 最新版本位于：
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# 或者你可以提供一个要扩展的配置文件路径。
# 路径是相对于 gitleaks 执行时的位置，
# 而不是基础配置的位置。
# path = "common_config.toml"
# 如果有任何规则你不想继承，可以在这里指定。
disabledRules = [ "generic-api-key"]

# 规则表数组，包含定义如何检测密钥的信息
[[rules]]
# 此规则的唯一标识符
id = "awesome-rule-1"

# 规则的简要描述
description = "awesome rule 1"

# 用于检测密钥的 Golang 正则表达式。注意 Golang 的正则引擎
# 不支持前瞻。
regex = '''one-go-style-regex-for-this-rule'''

# 用于从正则匹配中提取密钥的组号，如果设置了 `entropy`，则会对该组的熵进行检测。
secretGroup = 3

# 表示正则分组的最小香农熵，必须达到该值才会被视为密钥。
entropy = 3.5

# 用于匹配路径的 Golang 正则表达式。可以作为独立规则，也可以与有效的 `regex` 配合使用。
path = '''a-file-path-regex'''

# 关键字用于正则前的快速过滤。包含关键字的规则会先进行字符串比较，
# 确保内容中包含关键字。理想情况下，这些值应为标识符或规则正则中独有的字符串
# （v8.6.0 引入）
keywords = [
  "auth",
  "password",
  "token",
]

# 用于元数据和报告的字符串数组
tags = ["tag","another tag"]

    # ⚠️ 在 v8.21.0 `[rules.allowlist]` 被替换为 `[[rules.allowlists]]`。
    # 这个变更是向后兼容的：`[rules.allowlist]` 实例仍然有效。
    #
    # 你可以为规则定义多个 allowlists 以减少误报。
    # 如果 _任意_ 一个 `[[rules.allowlists]]` 匹配，则发现会被忽略。
    [[rules.allowlists]]
    description = "ignore commit A"
    # 当定义多个条件时，默认逻辑为 "OR"。
    # 例如，可以匹配 |commits| 或 |paths| 或 |stopwords|。
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # 注意：stopwords 针对的是提取出的密钥，而不是整个正则匹配结果
    # 类似 'regexes' 的方式。（stopwords 在 8.8.0 引入）
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # "AND" 条件可用于确保所有条件都匹配。
    # 例如，只有 |regexes| 和 |paths| 都满足时才匹配。
    condition = "AND"
    # 注意：|regexes| 默认检查发现中的 _Secret_。
    # 可选值为 "secret"（默认）、"match" 和 "line"。
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# 你可以扩展默认配置中的某个特定规则，例如 gitlab-pat
# 如果你的 GitLab 实例定义了自定义 token 前缀
[[rules]]
id = "gitlab-pat"
# 其它属性均继承自默认规则

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ 在 v8.25.0 `[allowlist]` 被替换为 `[[allowlists]]`。
#
# 全局 allowlists 的优先级高于规则特定的 allowlists。
# 如果遇到 `commits` 字段中列出的提交，则会跳过该提交，不会检测出密钥。对 regexes 和 paths 同理。
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# 注意：（全局）regexTarget 默认为检查发现中的 _Secret_。
# 可选值为 "match" 和 "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# 注意：stopwords 针对的是提取出的密钥，而不是整个正则匹配结果
# 类似 'regexes' 的方式。（stopwords 在 8.8.0 引入）
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ 在 v8.25.0 版本中，`[[allowlists]]` 增加了一个新字段 |targetRules|。
#
# 通用白名单可以定义一次，并通过 |targetRules| 分配给多个规则。
# 这只会在指定规则上运行，而不是全局运行。
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "我们的测试资产在某些规则下会误报。"
paths = ['''tests/expected/._\.json$''']
```

参考默认的 [gitleaks 配置文件](https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml) 获取示例，或按照 [贡献指南](https://github.com/gitleaks/gitleaks/blob/master/CONTRIBUTING.md) 参与默认配置的贡献。此外，你也可以阅读 [这篇 gitleaks 博客文章](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf)，其中涵盖了高级配置设置。

### 其他配置

#### gitleaks:allow

如果你明知要提交一个会被 gitleaks 检测到的测试密钥，可以在该行添加 `gitleaks:allow` 注释，gitleaks 会忽略该密钥。例如：

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

你可以在仓库根目录创建 `.gitleaksignore` 文件，以忽略特定的发现项。在 v8.10.0 版本中，Gitleaks 在报告中新增了 `Fingerprint` 字段。每个泄漏项（发现项）都有一个唯一标识密钥的 Fingerprint。将该指纹添加到 `.gitleaksignore` 文件中，可以忽略该特定密钥。参见 Gitleaks 的 [.gitleaksignore](https://github.com/gitleaks/gitleaks/blob/master/.gitleaksignore) 示例。注意：此功能为实验性，未来可能发生变更。

#### 解码

有时密钥会以某种编码方式存在，仅用正则表达式很难发现。现在你可以让 gitleaks 自动发现并解码编码文本。`--max-decode-depth` 参数启用此功能（默认值为 "0"，即默认不启用）。

支持递归解码，因为解码后的文本也可能包含编码文本。`--max-decode-depth` 参数设置递归深度限制。当没有新的编码文本片段可解码时，递归停止，因此设置很高的最大深度并不意味着一定会递归这么多次，只会按需递归。总体来说，解码功能对扫描时间的影响很小。

编码文本的发现项与普通发现项的不同之处在于：

- 位置指向编码文本的边界
  - 如果规则在编码文本之外匹配，边界会调整以包含匹配内容
- match 和 secret 包含解码后的值
- 增加了两个标签：`decoded:<encoding>` 和 `decode-depth:<depth>`

当前支持的编码方式：

- **percent** - 任意可打印 ASCII 百分号编码值
- **hex** - 任意长度大于等于 32 个字符的可打印 ASCII 十六进制编码值
- **base64** - 任意长度大于等于 16 个字符的可打印 ASCII base64 编码值

#### 压缩包扫描

有时密钥被打包在如 zip 或 tarball 等归档文件中，难以被发现。现在你可以让 gitleaks 自动提取并扫描压缩包内容。`--max-archive-depth` 参数用于 `dir` 和 `git` 扫描类型，启用此功能。默认值 "0" 表示默认不启用。

支持递归扫描，因为归档文件中也可能嵌套其他归档文件。`--max-archive-depth` 参数设置递归深度限制。当没有新的归档可提取时，递归停止。设置很高的最大深度只是设置了可能的递归深度，实际只会递归到需要的深度。

在归档文件中发现的密钥，报告中会包含归档内部文件的路径。内部路径用 `!` 分隔。

发现示例（为简洁起见已缩短）：

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

这意味着在 `testdata/archives/nested.tar.gz` 下的 `archives/files.tar` 中的 `files/.env.prod.` 文件第 4 行检测到密钥。

当前支持的格式：

支持 mholt 的 [archives 包](https://github.com/mholt/archives) 所支持的 [压缩格式](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats) 和 [归档格式](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)。

#### 报告

Gitleaks 内置支持多种报告格式：[`json`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/json_simple.json)、[`csv`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/csv_simple.csv?plain=1)、[`junit`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/junit_simple.xml)、[`sarif`](https://github.com/gitleaks/gitleaks/blob/master/testdata/expected/report/sarif_simple.sarif)。

如果这些格式都不满足需求，你可以用 [Go 的 `text/template` .tmpl 文件](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) 和 `--report-template` 参数自定义报告模板。模板可以使用 [`Masterminds/sprig` 模板库](https://masterminds.github.io/sprig/) 的扩展功能。

例如，以下模板可自定义输出 JSON 格式报告：
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

使用方法：
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## 赞助

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## 退出码

你可以通过 --exit-code 参数设置当检测到泄漏时的退出码。默认退出码如下：

```
0 - 未发现泄漏
1 - 发现泄漏或遇到错误
126 - 未知参数
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---