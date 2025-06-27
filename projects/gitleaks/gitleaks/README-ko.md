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


### 디스코드에 참여하세요! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks는 **비밀번호, API 키, 토큰**과 같은 시크릿을 git 저장소, 파일, 그리고 `stdin`을 통해 입력되는 모든 것에서 **탐지**하는 도구입니다. 탐지 엔진이 어떻게 동작하는지 더 알고 싶다면 이 블로그를 참고하세요: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Finding:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Secret:      cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropy:     2.609850
File:        cmd/generate/config/rules/sidekiq.go
Line:        23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Author:      John
Email:       john@users.noreply.github.com
Date:        2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## 시작하기

Gitleaks는 Homebrew, Docker, 또는 Go를 사용하여 설치할 수 있습니다. 또한 [릴리즈 페이지](https://github.com/gitleaks/gitleaks/releases)에서 다양한 인기 플랫폼 및 OS용 바이너리 형태로도 제공됩니다. 추가로, Gitleaks는 사전 커밋 훅(pre-commit hook)으로 직접 저장소에 구현하거나 [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action)을 사용해 GitHub Action으로 사용할 수도 있습니다.

### 설치하기

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# 소스에서 설치 (go가 설치되어 있어야 함)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

공식 [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action)을 확인하세요.

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
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # 조직(Organization)에서만 필요하며, 개인 계정은 필요하지 않습니다.
```

### Pre-Commit

1. https://pre-commit.com/#install 에서 pre-commit을 설치합니다.
2. 저장소 루트에 `.pre-commit-config.yaml` 파일을 아래와 같이 생성합니다:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   [gitleaks의 네이티브 실행](https://github.com/gitleaks/gitleaks/releases)을 원하거나, [공식 Docker 이미지](#docker)를 사용하려면 [`gitleaks-docker` pre-commit ID](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml)를 사용할 수 있습니다.

3. `pre-commit autoupdate`를 실행하여 설정을 최신 저장소 버전으로 자동 업데이트합니다.
4. `pre-commit install`로 설치합니다.
5. 이제 모든 준비가 완료되었습니다!

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

참고: gitleaks pre-commit 훅을 비활성화하려면 커밋 명령어 앞에 `SKIP=gitleaks`를 붙이면 gitleaks 실행이 건너뜁니다.

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## 사용법

```
Usage:
  gitleaks [command]

Available Commands:
  dir         scan directories or files for secrets
  git         scan git repositories for secrets
  help        Help about any command
  stdin       detect secrets from stdin
  version     display gitleaks version

Flags:
  -b, --baseline-path string          path to baseline with issues that can be ignored
  -c, --config string                 config file path
                                      order of precedence:
                                      1. --config/-c
                                      2. env var GITLEAKS_CONFIG
                                      3. env var GITLEAKS_CONFIG_TOML with the file content
                                      4. (target path)/.gitleaks.toml
                                      If none of the four options are used, then gitleaks will use the default config
      --diagnostics string            enable diagnostics (comma-separated list: cpu,mem,trace). cpu=CPU profiling, mem=memory profiling, trace=execution tracing
      --diagnostics-dir string        directory to store diagnostics output files (defaults to current directory)
      --enable-rule strings           only enable specific rules by id
      --exit-code int                 exit code when leaks have been encountered (default 1)
  -i, --gitleaks-ignore-path string   path to .gitleaksignore file or folder containing one (default ".")
  -h, --help                          help for gitleaks
      --ignore-gitleaks-allow         ignore gitleaks:allow comments
  -l, --log-level string              log level (trace, debug, info, warn, error, fatal) (default "info")
      --max-decode-depth int          allow recursive decoding up to this depth (default "0", no decoding is done)
      --max-archive-depth int         allow scanning into nested archives up to this depth (default "0", no archive traversal is done)
      --max-target-megabytes int      files larger than this will be skipped
      --no-banner                     suppress banner
      --no-color                      turn off color for verbose output
      --redact uint[=100]             redact secrets from logs and stdout. To redact only parts of the secret just apply a percent value from 0..100. For example --redact=20 (default 100%)
  -f, --report-format string          output format (json, csv, junit, sarif, template)
  -r, --report-path string            report file
      --report-template string        template file used to generate the report (implies --report-format=template)
  -v, --verbose                       show verbose output from scan
      --version                       version for gitleaks

Use "gitleaks [command] --help" for more information about a command.
```

### 명령어

⚠️ v8.19.0부터 `detect`와 `protect` 명령어가 더 이상 권장되지 않으며, 여전히 사용할 수 있지만 `--help` 메뉴에는 숨겨져 있습니다. 명령어 변환이 필요한 경우 [이 gist](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2)를 참고하세요.
v8.19.0에서 기존 명령어(`detect`/`protect`)가 동작하지 않는 경우, 이슈를 등록해 주세요.

스캔 모드는 세 가지가 있습니다: `git`, `dir`, `stdin`.

#### Git

`git` 명령어는 로컬 git 저장소를 스캔할 수 있습니다. 내부적으로 gitleaks는 `git log -p` 명령어를 사용하여 패치를 스캔합니다.
`log-opts` 옵션으로 `git log -p`의 동작을 설정할 수 있습니다.
예를 들어, 특정 커밋 범위에서 gitleaks를 실행하려면 다음과 같이 명령어를 사용할 수 있습니다: `gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. 자세한 내용은 [git log](https://git-scm.com/docs/git-log) 문서를 참고하세요.
대상 경로가 위치 인자로 지정되지 않은 경우, gitleaks는 현재 작업 디렉터리를 git 저장소로 간주하여 스캔을 시도합니다.
#### Dir

`dir`(별칭: `files`, `directory`) 명령어를 사용하면 디렉터리와 파일을 스캔할 수 있습니다. 예시: `gitleaks dir -v path_to_directory_or_file`.
대상 경로가 위치 인수로 지정되지 않으면, gitleaks는 현재 작업 디렉터리를 스캔합니다.

#### Stdin

`stdin` 명령어를 통해 데이터 스트림을 gitleaks로 전달할 수도 있습니다. 예시: `cat some_file | gitleaks -v stdin`

### 기준(baseline) 만들기

대규모 저장소나 오랜 기록을 가진 저장소를 스캔할 때는 기준(baseline)을 사용하는 것이 편리할 수 있습니다. 기준을 사용하면,
gitleaks는 기준에 포함된 기존 발견 항목을 무시합니다. 기준은 gitleaks 리포트라면 무엇이든 될 수 있습니다. gitleaks 리포트를 생성하려면 `--report-path` 파라미터와 함께 gitleaks를 실행하세요.

```
gitleaks git --report-path gitleaks-report.json # 리포트를 gitleaks-report.json 파일에 저장합니다
```

기준을 생성한 후에는 다시 detect 명령을 실행할 때 적용할 수 있습니다:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

`--baseline-path` 파라미터와 함께 detect 명령을 실행하면, 리포트 출력(findings.json)에는 새로운 이슈만 포함됩니다.

## Pre-Commit hook

예제 `pre-commit.py` 스크립트를 `.git/hooks/` 디렉터리에 복사하여 Gitleaks를 pre-commit hook으로 실행할 수 있습니다.

## 구성 로드하기

우선순위는 다음과 같습니다:

1. `--config/-c` 옵션:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. 파일 경로를 지정하는 환경 변수 `GITLEAKS_CONFIG`:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. 파일 내용을 지정하는 환경 변수 `GITLEAKS_CONFIG_TOML`:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. 대상 경로 내의 `.gitleaks.toml` 파일:
      ```bash
      gitleaks git .
      ```

네 가지 옵션 중 어느 것도 사용하지 않으면, gitleaks는 기본 설정을 사용합니다.

## 구성(Configuration)

Gitleaks는 직접 작성할 수 있는 시크릿 탐지 규칙을 위한 구성 포맷을 제공합니다:

```toml
# Gitleaks 구성 파일 제목
title = "Custom Gitleaks configuration"

# 커스텀 구성에는 기본적으로 두 가지 옵션이 있습니다:
#
# 1. 직접 구성 정의, 기본 규칙은 적용되지 않음
#
#    예: 기본 구성을 시작점으로 사용
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. 구성을 확장, 규칙이 덮어쓰이거나 확장됨
#
#    구성을 확장하면 확장된 규칙이 기본 규칙보다 우선 적용됩니다. 즉, 확장 구성과 기본 구성 모두에 중복된 규칙이 있으면
#    확장된 규칙 또는 그 속성이 기본 규칙을 덮어씁니다.
#    구성을 확장할 때 2단계까지 여러 구성 파일을 체이닝할 수 있습니다. Allowlist 배열은 추가되며 중복을 포함할 수 있습니다.

# useDefault와 path는 동시에 사용할 수 없습니다. 둘 중 하나만 선택하세요.
[extend]
# useDefault는 바이너리에 내장된 기본 gitleaks 구성을 확장합니다
# 최신 버전은 다음 위치에 있습니다:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# 또는 확장할 구성의 경로를 지정할 수 있습니다.
# 경로는 gitleaks가 실행된 위치를 기준으로 합니다.
# path = "common_config.toml"
# 상속받고 싶지 않은 규칙이 있다면 여기에 지정할 수 있습니다.
disabledRules = [ "generic-api-key"]

# 시크릿을 탐지하는 방법을 정의하는 정보를 담은 테이블 배열
[[rules]]
# 해당 규칙의 고유 식별자
id = "awesome-rule-1"

# 규칙의 간단한 설명
description = "awesome rule 1"

# 시크릿을 탐지하기 위해 사용되는 Golang 정규표현식. Golang의 정규표현식 엔진은 lookahead를 지원하지 않습니다.
regex = '''one-go-style-regex-for-this-rule'''

# 정규표현식 매칭 결과에서 시크릿을 추출하기 위해 사용되는 그룹 번호.
# `entropy`가 설정된 경우, 해당 그룹의 엔트로피를 검사합니다.
secretGroup = 3

# 정규표현식 그룹이 시크릿으로 간주되기 위한 최소 shannon 엔트로피 값(float)
entropy = 3.5

# 경로 매칭에 사용되는 Golang 정규표현식. 독립 규칙으로도, `regex`와 함께도 사용 가능합니다.
path = '''a-file-path-regex'''

# 키워드는 사전 정규표현식 필터링에 사용됩니다.
# 키워드가 포함된 규칙은 스캔 중인 콘텐츠에 키워드가 있는지 빠르게 확인합니다.
# 이상적으로는 이 값이 식별자 일부이거나 규칙의 정규표현식에 특화된 고유 문자열이어야 합니다
# (v8.6.0에서 도입)
keywords = [
  "auth",
  "password",
  "token",
]

# 메타데이터 및 리포팅 목적의 문자열 배열
tags = ["tag","another tag"]

    # ⚠️ v8.21.0부터 `[rules.allowlist]`가 `[[rules.allowlists]]`로 변경되었습니다.
    # 이 변경은 이전 버전과 호환됩니다: `[rules.allowlist]`도 계속 동작합니다.
    #
    # 오탐(false positive) 감소를 위해 한 규칙에 여러 allowlist를 정의할 수 있습니다.
    # _ANY_ `[[rules.allowlists]]`가 일치하면 해당 발견 항목은 무시됩니다.
    [[rules.allowlists]]
    description = "ignore commit A"
    # 여러 기준을 정의할 경우 기본 조건은 "OR"입니다.
    # 예: |commits| OR |paths| OR |stopwords| 중 하나라도 일치하면 무시
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # 참고: stopwords는 정규표현식 전체 매치가 아니라 추출된 시크릿에 적용됩니다.
    # ('stopwords'는 8.8.0에서 도입)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # "AND" 조건은 모든 기준이 일치해야 합니다.
    # 예: |regexes| AND |paths|가 모두 만족해야 무시
    condition = "AND"
    # 참고: |regexes|는 기본적으로 발견된 _Secret_에 대해 검사합니다.
    # 허용 가능한 |regexTarget| 값은 "secret"(기본값), "match", "line"입니다.
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# 기본 규칙에서 특정 규칙(예: gitlab-pat)을 확장할 수 있습니다
# 예: GitLab 인스턴스에서 커스텀 토큰 프리픽스를 사용하는 경우
[[rules]]
id = "gitlab-pat"
# 나머지 속성은 모두 기본 규칙에서 상속받음

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ v8.25.0부터 `[allowlist]`가 `[[allowlists]]`로 변경되었습니다.
#
# 글로벌 allowlists는 규칙별 allowlists보다 더 높은 우선순위를 가집니다.
# 아래 `commits` 필드에 명시된 커밋이 발견되면 해당 커밋은 건너뛰며,
# 해당 커밋에서는 시크릿이 탐지되지 않습니다. regexes, paths도 동일한 논리가 적용됩니다.
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# 참고: (글로벌) regexTarget의 기본값은 발견된 _Secret_ 검사입니다.
# 허용 가능한 regexTarget 값은 "match"와 "line"입니다.
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# 참고: stopwords는 정규표현식 전체 매치가 아니라 추출된 시크릿에 적용됩니다.
# ('stopwords'는 8.8.0에서 도입)
stopwords = [
  '''client''',
```markdown
  '''endpoint''',
]

# ⚠️ v8.25.0 버전부터 `[[allowlists]]`에 |targetRules|라는 새로운 필드가 추가되었습니다.
#
# 공통 allowlists는 한 번만 정의하고 여러 규칙에 |targetRules|를 통해 할당할 수 있습니다.
# 이는 지정된 규칙에만 적용되며, 전역적으로는 적용되지 않습니다.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "우리 테스트 자산이 일부 규칙에서 오탐(false-positives)을 유발합니다."
paths = ['''tests/expected/._\.json$''']
```

예시를 보려면 [기본 gitleaks config](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml)를 참고하거나, 기본 설정에 기여하고 싶다면 [기여 가이드라인](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md)을 따라주세요. 또한, 고급 구성 예제는 [이 gitleaks 블로그 글](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf)도 참고할 수 있습니다.

### 추가 구성

#### gitleaks:allow

테스트 시크릿을 의도적으로 커밋하고 gitleaks가 이를 탐지하는 것을 알 경우, 해당 라인에 `gitleaks:allow` 주석을 추가하면 gitleaks가 해당 시크릿을 무시합니다. 예시:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

특정 탐지 결과를 무시하려면 레포 루트에 `.gitleaksignore` 파일을 생성하세요. v8.10.0 릴리스에서 Gitleaks는 보고서에 `Fingerprint` 값을 추가했습니다. 각 유출 또는 탐지 결과는 시크릿을 고유하게 식별하는 Fingerprint를 가집니다. 이 값을 `.gitleaksignore` 파일에 추가하면 해당 시크릿만 무시됩니다. 예시는 Gitleaks의 [.gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore)를 참고하세요. 참고: 이 기능은 실험적이며 향후 변경될 수 있습니다.

#### 디코딩

시크릿이 인코딩되어 있어 정규식만으로는 찾기 어려운 경우가 있습니다.
이제 gitleaks에 인코딩된 텍스트를 자동으로 찾고 디코딩하도록 설정할 수 있습니다.
`--max-decode-depth` 플래그로 이 기능을 활성화할 수 있습니다(기본값 "0"은 비활성화 상태임).

디코딩된 텍스트에도 인코딩된 내용이 있을 수 있으므로, 재귀적 디코딩이 지원됩니다.
`--max-decode-depth` 플래그는 재귀 한계를 설정합니다. 더 이상 디코딩할 인코딩된 텍스트가 없으면 재귀가 중단되므로, 매우 큰 값을 설정해도 꼭 그만큼 반복하지는 않습니다. 필요한 만큼만 반복하여 디코딩합니다. 전체적으로, 디코딩은 스캔 시간을 최소한으로만 증가시킵니다.

인코딩된 텍스트에 대한 탐지 결과는 일반 탐지와 다음과 같은 차이가 있습니다:

- 위치(Location)는 인코딩된 텍스트의 범위를 가리킵니다.
  - 규칙이 인코딩된 텍스트 외부에서 일치할 경우, 범위가 조정되어 해당 부분까지 포함됩니다.
- match와 secret은 디코딩된 값을 포함합니다.
- 두 개의 태그가 추가됩니다: `decoded:<encoding>`, `decode-depth:<depth>`

현재 지원하는 인코딩:

- **percent** - 모든 출력 가능한 ASCII 퍼센트 인코딩 값
- **hex** - 32자 이상인 출력 가능한 ASCII 16진수 인코딩 값
- **base64** - 16자 이상인 출력 가능한 ASCII base64 인코딩 값

#### 아카이브 스캔

시크릿이 zip 파일이나 tarball 같은 아카이브 파일에 포함되어 있는 경우, 탐지가 어렵습니다.
이제 gitleaks가 아카이브를 자동으로 추출하고 내용물을 스캔할 수 있습니다. `--max-archive-depth` 플래그가 이 기능을 활성화하며, `dir` 및 `git` 스캔 타입 모두에 적용됩니다. 기본값 "0"은 비활성화 상태입니다.

아카이브 내부에 또 다른 아카이브가 있을 수 있으므로, 재귀 스캔도 지원합니다.
`--max-archive-depth` 플래그는 재귀 한계를 설정합니다. 더 이상 추출할 아카이브가 없으면 재귀가 중단되므로, 매우 큰 값을 설정해도 꼭 그만큼 반복하지는 않습니다. 필요한 만큼만 깊게 스캔합니다.

아카이브 내에서 탐지된 시크릿 결과에는 아카이브 내부 파일 경로가 포함됩니다. 내부 경로는 `!`로 구분됩니다.

예시 탐지 결과(간략화됨):

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

이는 `testdata/archives/nested.tar.gz` 내의 `archives/files.tar`에 있는 `files/.env.prod` 파일의 4번째 줄에서 시크릿이 탐지되었음을 의미합니다.

현재 지원되는 형식:

[compression](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats) 및 [archive](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats) 형식은 mholt의 [archives 패키지](https://github.com/mholt/archives)에서 지원하는 모든 형식을 지원합니다.

#### 리포팅

Gitleaks는 여러 내장 리포트 형식을 지원합니다: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

이 중 원하는 형식이 없다면, [Go `text/template` .tmpl 파일](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template)과 `--report-template` 플래그를 사용해 직접 리포트 형식을 만들 수 있습니다. 템플릿에서는 [`Masterminds/sprig` 템플릿 라이브러리](https://masterminds.github.io/sprig/)의 확장 기능도 사용할 수 있습니다.

예를 들어, 다음 템플릿은 커스텀 JSON 출력을 제공합니다:
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

사용법:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## 후원

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## 종료 코드

유출이 발견될 때 --exit-code 플래그로 종료 코드를 항상 설정할 수 있습니다. 기본 종료 코드는 아래와 같습니다:

```
0 - 유출 없음
1 - 유출 또는 오류 발생
126 - 알 수 없는 플래그
```
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---