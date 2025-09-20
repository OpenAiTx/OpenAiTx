# kubectl-tmux-exec

![GitHub release version](https://img.shields.io/github/v/release/predatorray/kubectl-tmux-exec)
![License](https://img.shields.io/github/license/predatorray/kubectl-tmux-exec)
![Build Status](https://img.shields.io/github/actions/workflow/status/predatorray/kubectl-tmux-exec/ci.yml?branch=master)
![GitHub all releases](https://img.shields.io/github/downloads/predatorray/kubectl-tmux-exec/total)

A **kubectl** plugin for executing commands interactively across multiple pods or containers using [**tmux**](https://github.com/tmux/tmux),
like `csshX` or `pssh` but for **Kubernetes**.

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot.png?raw=true)

To execute command across all the Nginx containers using `bash` for example, run:

```sh
kubectl tmux-exec -l app=nginx /bin/bash
```
## 설치 

### Homebrew

> **참고**: Mac 사용자 전용입니다.

1. [Homebrew](https://brew.sh/)를 설치합니다.

2. `brew install predatorray/brew/kubectl-tmux-exec`

마지막으로, `/usr/local/bin/kubectl-tmux_exec`가 `$PATH`에 포함되어 있는지 확인하세요.

### Krew

> **참고**: Linux 사용자에게 권장됩니다.
> 
> Mac과 Linux 모두에서 작동하지만, Mac 사용자의 경우 여전히 Homebrew를 통해 `gnu-getopt` 의존성을 설치해야 할 수 있으므로 권장하지 않습니다.

1. [Krew](https://krew.sigs.k8s.io/)를 [사용자 가이드](https://krew.sigs.k8s.io/docs/user-guide/setup/install/)를 따라 설치합니다.

2. `kubectl krew install tmux-exec`

3. 의존성을 설치합니다. ([Wiki: How-to-Install-Dependencies](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

### 수동 설치

1. [최신 릴리스](https://github.com/predatorray/kubectl-tmux-exec/releases/latest)를 다운로드합니다.

2. kubectl-tmux-exec-*.tar.gz 파일을 압축 해제하고 모든 파일을 예를 들어 `/usr/local/kubectl-tmux-exec` 디렉터리에 복사합니다.

3. `bin/` 디렉터리를 `$PATH`에 추가합니다. 예를 들어, rc 파일에 다음 줄을 추가합니다: `export PATH="$PATH:/usr/local/kubectl-tmux-exec/bin"`.

4. 의존성을 설치합니다. ([Wiki: How-to-Install-Dependencies](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

## 사용법

`kubectl` 버전이 1.12 이상인지 ([플러그인 지원]) 확인하고, 이상적으론 최신 버전을 사용하세요.

그렇지 않으면 스크립트를 직접 실행하세요: `kubectl-tmux_exec [...ARGS]`.


스크립트가 성공적으로 추가되었는지 확인하려면:

```sh
kubectl plugin list
```
출력은 다음과 같아야 합니다


```txt
The following compatible plugins are available:

/usr/local/bin/kubectl-tmux_exec
```
목록에 표시되지 않으면, `$PATH` 환경 변수를 다시 확인하세요.

아래 명령어를 사용하여 스크립트의 사용법을 확인할 수 있습니다.


```sh
kubectl tmux-exec --help

# or
kubectl-tmux_exec --help
```
### 옵션

| 플래그                          | 사용법                                                                                                                                                      |
|--------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `-V`<br>`--version`             | 버전 정보를 출력합니다                                                                                                                                       |
| `-l`<br>`--selector`            | 필터링할 셀렉터(라벨 쿼리), '=', '==', '!='를 지원합니다.(예: -l key1=value1,key2=value2)<br>`--selector` 또는 `--file` 옵션 중 하나를 사용해야 합니다.        |
| `-f`<br>`--file`                | 파일에서 한 줄씩 파드 이름을 읽습니다.<br>`--selector` 또는 `--file` 옵션 중 하나를 사용해야 합니다.                                                        |
| `-c`<br>`--container`           | 컨테이너 이름입니다. 생략 시 파드의 첫 번째 컨테이너가 선택됩니다                                                                                               |
| `-i`<br>`--stdin`               | 컨테이너에 표준 입력을 전달합니다 (**더 이상 권장되지 않음**, 기본적으로 활성화되어 있음)                                                                    |
| `-t`<br>`--tty`                 | 표준 입력이 TTY임을 지정합니다 (**더 이상 권장되지 않음**, 기본적으로 활성화되어 있음)                                                                        |
| `-d`<br>`--detach`              | Tmux 세션을 분리(detached) 상태로 만듭니다                                                                                                                   |
| `-n`<br>`--namespace=`          | 이 CLI 요청의 네임스페이스 범위 (여러 번 적용 가능)                                                                                                          |
| `--context`                     | 사용할 kubeconfig 컨텍스트 이름 (여러 번 적용 가능)                                                                                                         |
| `-A`<br>`--all-namespaces`      | 지정된 경우 모든 네임스페이스에서 요청한 객체를 나열 및 실행합니다. `--namespace`로 지정해도 현재 컨텍스트 네임스페이스는 무시됩니다.                         |
| `-C`<br>`--enable-control-mode` | tmux를 제어 모드로 시작하며 에코가 비활성화됩니다. ([iTerm2 통합](#iterm2-integration) 참고)                                                                  |
| `--remain-on-exit`              | 종료 시에도 Tmux 창을 유지합니다                                                                                                                             |
| `--select-layout`               | 다섯 가지 Tmux 사전 설정 레이아웃 중 하나: even-horizontal, even-vertical, main-horizontal, main-vertical, tiled                                            |
| `--session-mode`                | tmux가 열리는 위치: auto, new-session, current-session                                                                                                      |

이 옵션들의 사용법은 `--help`로도 확인할 수 있습니다.

### 예제

`tmux-exec`는 `exec`와 유사하지만, `exec`가 파드 이름을 요구하는 반면 `tmux-exec`는 라벨 셀렉터를 요구합니다.

예를 들어, 공통 라벨 `foo=bar`를 가진 모든 파드 컨테이너에 `bash`로 접속하려면 다음과 같이 합니다.


```sh
kubectl tmux-exec -l foo=bar /bin/bash
```
선택한 컨테이너에 성공적으로 `bash` 접속을 완료하면, 실제로는 Tmux 창이 열리며 각 패인에는 각 파드의 컨테이너 실행 결과가 표시됩니다. 키보드 입력은 모든 패인에 동기화됩니다.

Tmux에 익숙하지 않다면 tmux 매뉴얼 페이지나 온라인 튜토리얼을 참고할 수 있습니다. 또는 아래 [치트시트](#tmux-cheatsheet)를 보면 충분할 것입니다.

### iTerm2 통합

`-C` 또는 `--enable-control-mode` 옵션을 사용하면 제어 모드로 실행되며, 패인 입력을 [iTerm2]의 "Broadcast Input" 기능에 위임합니다.  
tmux 키 바인딩이 필요 없습니다.

iTerm2에서 <kbd>⌘</kbd> + <kbd>⌥</kbd> + <kbd>i</kbd>를 눌러 방송 모드를 토글할 수 있습니다. (이 모드에서는 `synchronize-panes`가 자동으로 비활성화됩니다.)

(자세한 내용은 [tmux 통합](https://iterm2.com/documentation-tmux-integration.html)을 참조하세요)

#### 예시


```sh
kubectl tmux-exec -C -l app=nginx /bin/bash
```
![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot-iterm2-integration.png?raw=true)

### 셸 자동완성

자세한 내용은 [이 위키](https://github.com/predatorray/kubectl-tmux-exec/wiki/Shell-Auto-completion)를 확인하세요.

### Tmux 단축키

모든 Tmux 명령은 `PREFIX`로 시작합니다. 기본적으로 `PREFIX`는 <kbd>Ctrl</kbd> + <kbd>b</kbd>입니다. 아래에서는 이를 `C-b`로 표기하겠습니다.

`C-b d`, 세션에서 분리(detach)합니다. 이후 Tmux는 백그라운드에서 실행됩니다. `tmux a`를 입력해 다시 연결할 수 있습니다.

`C-b :setw synchronize-panes off`, 모든 창에 대한 입력 동기화를 해제합니다.

`C-b :setw synchronize-panes on`, 모든 창에 대한 입력 동기화를 활성화합니다.

`C-b <화살표 키>`, 창 간에 커서를 이동합니다.

`C-b xy`, 현재 창을 닫습니다.

`C-b &y`, 모든 창을 포함한 윈도우를 닫습니다.

## 커뮤니티 및 지원

- [GitHub Issues]((https://github.com/predatorray/kubectl-tmux-exec/issues/new))를 통해 이슈나 기능 요청을 제출하세요.
- 토론을 위해 [Google Group](https://groups.google.com/g/kubectl-tmux-exec)에 참여하세요.

## 기타 플러그인

[kubectl-alias](https://github.com/predatorray/kubectl-alias): kubectl의 부족한 alias 명령어를 제공합니다.

## 커피 한 잔 사주기

시간을 절약해드렸다면, [커피 한 잔 사주기] 🙌를 부담 없이 이용하세요.

[![](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)][buy me a coffee]

[buy me a coffee]: https://buymeacoffee.com/predatorray
[iTerm2]: https://iterm2.com/index.html

[플러그인 지원]: https://kubernetes.io/docs/tasks/extend-kubectl/kubectl-plugins/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---