# Fjira - Jira를 위한 퍼지 파인더 및 TUI 애플리케이션.

<img src="https://raw.githubusercontent.com/mk-5/fjira/master/fjira.png" alt="drawing" width="256"/>

[![Mentioned in Awesome Go](https://awesome.re/badge-flat.svg)](https://github.com/avelino/awesome-go)
![Test](https://github.com/mk-5/fjira/actions/workflows/tests.yml/badge.svg)
[![License: AGPL v3](https://img.shields.io/badge/License-AGPL%20v3-blue.svg)](https://github.com/mk-5/fjira/blob/master/LICENSE)
![GitHub release (latest by date)](https://img.shields.io/github/v/release/mk-5/fjira)
[![Go Report Card](https://goreportcard.com/badge/github.com/mk-5/fjira)](https://goreportcard.com/report/github.com/mk-5/fjira)
[![Go Reference](https://pkg.go.dev/badge/github.com/mk-5/fjira.svg)](https://pkg.go.dev/github.com/mk-5/fjira)
[![codecov](https://codecov.io/gh/mk-5/fjira/branch/master/graph/badge.svg?token=MJBTMYGQQW)](https://codecov.io/gh/mk-5/fjira)

## 소개

Fjira는 Jira와의 상호작용을 간소화하기 위해 설계된 강력한 명령줄 도구입니다. 개발자이든,
프로젝트 관리자이든, 혹은 단순한 Jira 애호가이든, Fjira는 워크플로우를 간소화하여 Jira 작업을
그 어느 때보다 효율적으로 만들어줍니다.

![Fjira Demo](https://raw.githubusercontent.com/mk-5/fjira/master/demo.gif)

## 주요 기능

- **퍼지 파인드 인터페이스:** Jira 프로젝트와 이슈를 손쉽게 검색합니다.
- **담당자 제어:** Jira 인터페이스를 탐색하지 않고도 이슈 담당자를 빠르게 변경할 수 있습니다.
- **상태 업데이트:** 터미널에서 직접 Jira 이슈 상태를 업데이트합니다.
- **효율적인 댓글 작성:** Jira 이슈에 댓글을 쉽게 추가할 수 있습니다.
- **다중 작업공간 지원:** 여러 Jira 작업공간을 손쉽게 관리합니다.
- **맞춤 검색:** Jira 쿼리 언어(JQL)를 사용하여 맞춤 검색이 가능합니다.
- **직접 CLI 접근:** 명령줄에서 직접 Jira 이슈에 접근할 수 있습니다.
- **크로스 플랫폼 호환성:** macOS, Linux, Windows에서 원활하게 작동합니다.

## 설치

### macOS

```shell
brew tap mk-5/mk-5
brew install fjira
```
### 리눅스

#### 우분투/스냅


```shell
snap install fjira
```
#### Deb

[https://github.com/mk-5/fjira/releases/latest](https://github.com/mk-5/fjira/releases/latest)을 방문하여,
최신 릴리스 버전을 다운로드하세요.


```shell
sudo dpkg -i fjira_0.4.0_linux_amd64.deb
```

#### AUR

```sh
yay -S fjira
```

#### 바이너리

```shell
tar -xvzf fjira_0.4.0_Linux_x86_64.tar.gz
cp fjira /usr/local/bin/fjira
```

### 윈도우즈

```shell
choco install fjira
```

### 소스에서 빌드하기

```shell
make
./out/bin/fjira
```

## 사용법

```text
Usage:
  fjira [flags]
  fjira [command]

Available Commands:
  [issueKey]  Open a Jira issue directly from the CLI
  completion  Generate the autocompletion script for the specified shell
  filters     Search using Jira filters
  help        Help about any command
  jql         Search using custom JQL queries
  version     Print the version number of fjira
  workspace   Switch to a different workspace

Flags:
  -h, --help             help for fjira
  -p, --project string   Open a project directly from CLI

Additional help topics:
  fjira            Open a fuzzy finder for projects as a default action

Use "fjira [command] --help" for more information about a command.
```

## 시작하기

Fjira CLI 사용은 간단합니다. 터미널에서 fjira를 실행하기만 하면 됩니다.

```shell
fjira
```

## 작업 공간

Fjira를 처음 실행하면 Jira API URL과 토큰을 입력하라는 메시지가 표시됩니다.

![Fjira 첫 실행](https://raw.githubusercontent.com/mk-5/fjira/master/demo_first_run.gif)

Fjira 작업 공간은 `~/.fjira`에 위치한 간단한 YAML 파일에 Jira 구성 데이터를 저장합니다. `fjira workspace` 명령을 사용하여
여러 작업 공간 간에 전환할 수 있습니다.

```shell
fjira workspace
```

새 작업 공간을 만들려면 다음 명령어를 사용하세요:

```shell
fjira workspace --new abc
```

`--edit` 플래그를 사용하여 기존 작업 공간을 편집할 수 있습니다:

```shell
fjira workspace --edit abc
```

### 지라 토큰 유형

Fjira는 Jira 서버와 Jira 클라우드를 모두 지원하며, 이들은 권한 부여를 위해 서로 다른 토큰 유형을 사용합니다. 도구는 작업 공간 구성 중에 적절한 토큰 유형을 선택하도록 안내합니다.


```shell
? Jira Token Type:

1. api token
2. personal token

Enter a number (Default is 1):
```

### YAML 구성

수동 방식을 선호하는 경우 `~/.fjira/` 디렉토리에 `fjira.yaml` 파일을 생성하여 작업 공간 구성을 추가할 수 있습니다.  
편의를 위해 예제 구성 파일은 여기에서 확인할 수 있습니다: [fjira.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/fjira.yaml)

## 프로젝트 검색

`fjira`를 실행할 때 기본 화면은 프로젝트 검색 화면입니다.

```shell
fjira
```

## 특정 프로젝트 열기

CLI에서 직접 프로젝트를 열 수 있습니다:

```shell
fjira --project=PROJ
```
이렇게 하면 프로젝트 검색 화면을 건너뛰고 바로 이슈 검색 화면으로 이동합니다.

## 이슈를 직접 열기

CLI에서 직접 이슈를 열려면:


```shell
fjira PROJ-123
```
Fjira는 모든 중간 화면을 건너뛰고 바로 이슈 뷰로 이동합니다.

![Fjira Issue View](https://raw.githubusercontent.com/mk-5/fjira/master/demo_issue.png)

## 보드 뷰

Fjira는 보드와 같은 뷰도 제공합니다. 프로젝트를 연 후 F4를 눌러 이 뷰에 접근할 수 있습니다.

![Fjira Board View](https://raw.githubusercontent.com/mk-5/fjira/master/demo_board_view.png)

## 맞춤 JQL 쿼리

Fjira를 사용하여 맞춤 JQL 쿼리를 생성하고 실행할 수 있습니다:


```shell
fjira jql
```

![Fjira Custom JQL](https://raw.githubusercontent.com/mk-5/fjira/master/demo_custom_jql.png)

## My Jira Filters

You can search using your stored (favourites) Jira Filters:

```shell
fjira filters
```

![Fjira Filters](https://raw.githubusercontent.com/mk-5/fjira/master/demo_filters.png)

## 사용자 정의 색상 스킴

`~/.fjira/colors.yml` 파일을 생성하여 fjira 색상 스킴을 사용자의 취향에 맞게 조정하세요. 이 파일은
개인적인 스타일에 맞게 색상을 맞춤 설정할 수 있습니다.
예제 파일은 여기에서 참조하세요: [colors.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/colors.yml)

## 로드맵 (TODO)

- 문서 확장
- Jira 필터 생성 및 삭제
- 추가 Linux 패키지 관리자 지원 (Apt, AUR, YUM)
- 더 많은 Jira 기능 도입

## 동기

Fjira는 개인의 편의를 위해 설계되었으며, 효율성에 대한 열망과 터미널 도구에 대한 사랑에서 태어났습니다.
종종 우리는 "단지 이슈 123을 다음 상태로 전환해야 해."라는 상황에 처합니다. Jira를 열고,
보드에서 티켓을 찾고, Jira 이슈 모달을 탐색하는 것이 전혀 문제는 없지만, 꽤 많은 시간이 소요됩니다.

Fjira는 이미 작업 중인 터미널에서 직접 이러한 작업을 수행할 수 있도록 힘을 실어줍니다! 😄

Fjira가 저처럼 당신의 Jira 경험을 향상시켰다면, GitHub에서 별점을 남겨주세요. 🌟 이것은 앞으로의 작업에
큰 힘이 됩니다.

이 프로젝트에 기여하고 미래를 함께 만들어가세요! 여러분의 피드백과 기여는 매우
감사하게 받아들여집니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---