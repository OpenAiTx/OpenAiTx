# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Helm Chart 的快照测试工具。

为 Helm Chart 带来强大的 UI 测试能力，只需在 `values.yaml` 文件中做最小配置即可。

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## 概览
- [功能特性 🔑](#功能特性-)
- [为什么要做快照测试？📸](#为什么要做快照测试-)
  - [动机](#动机)
- [安装 🚀](#安装-)
- [使用方法](#使用方法)
  - [处理动态值 💪](#处理动态值-)
- [展示与用户 ✨](#展示与用户-)

## 功能特性 🔑

* **为 Helm 开发者提供简单直观的快照测试**
  
  - **无需工具特定的 TestSuite 文件格式**：不同于一些工具需要创建自定义格式的 TestSuite 文件，本工具无需额外文件格式。你只需为每个测试用例准备标准的 `values.yaml` 文件变体即可，无需学习新格式，简化测试流程。

* **专为 Helm Chart 优化**

  - **处理 helm 函数生成的动态输出**：你可以在每个测试用例的 values.yaml 文件中指定附加属性，灵活调整测试行为。例如，可以控制像 [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/) 这类 helm 函数动态生成的输出。

* **持续快照测试**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) 已就绪**：GitHub Action 支持在 CI 中对本地或远程 Helm Chart 进行持续快照测试 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## 为什么要做快照测试？📸

我认为快照测试（在 Web 或 UI 测试中如 Jest 等工具中非常流行）是测试 Helm Chart 的最佳方式。快照测试带来多项优势：

- **可视化对比：** 快照测试会生成基线输出，并与后续测试结果进行比较，便于直观检查 Helm Chart 渲染的变更与回归。

- **提升可维护性：** 快照测试简化了测试设置流程，特别适合处理复杂 Helm Chart，使其更易于访问和维护。Helm Chart 的输入是 values 的组合，我们只需维护假定的输入组合（=values.yaml）及其快照。

- **持续测试：** 在 CI 流程中持续为 Helm Chart 生成快照，可以及时发现整个 Chart 的变更，避免回归。

这些优势不仅适用于你自己编写的 Helm Chart，也适用于你作为 Kubernetes 管理员安装的第三方 Chart。当升级集群时，无论输出 manifests 如何微小变化，只要是由你的 *values* 产生的，都能及时发现。

### 动机

已有一些 Helm 测试工具支持快照测试。
- [helm-unittest](https://github.com/helm-unittest/helm-unittest)：流行的单元测试工具，支持 [快照测试](https://github.com/helm-unittest/helm-unittest#snapshot-testing)。
- [terratest](https://terratest.gruntwork.io/)：基础设施代码的自动化测试工具，可用 Go 代码编写测试，支持 Helm 输出测试。[相关博文](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> 官方 Helm 测试工具 [`ct`](https://github.com/helm/chart-testing) 并非用于单元或快照测试，而是用于 lint 和集成测试。

虽然这些工具在 Helm Chart 测试中很有价值，但在快照测试方面存在一定局限性：

- 即使仅为快照测试，也需要学习和准备工具的 Test Suite 文件。
- 默认不会对整个 Chart 做快照，而是针对 Helm Chart 内部每个文件单独测试。
- 未考虑 Helm 函数的动态输出。

helm-unittest 的设计是对 Helm Chart 内的每个文件独立测试。当 Helm Chart 的 values 或条件导致某个文件有条件地被包含或排除时，测试可能无法覆盖所有重要场景。

以下是 helm-unittest 快照测试的测试规范文件示例：

> https://github.com/helm-unittest/helm-unittest#snapshot-testing
> 
> ```yaml
> templates:
>   - templates/deployment.yaml
> tests:
>   - it: pod spec should match snapshot
>     asserts:
>       - matchSnapshot:
>           path: spec.template.spec
>   # or you can snapshot the whole manifest
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

例如，假设 Helm Chart 在启用 TLS 且启用 cert-manager 时会创建 `cert-manager` 的 `Certificate` 资源，而未启用 cert-manager 时会通过 helm 函数 [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) 创建自签 TLS `Secret` 资源。同时，TLS 是否启用还会影响 Ingress 的 TLS 属性、Deployment 的 app 专属 TLS 选项等。

在这种情况下，helm-unittest 可能无法充分测试整个 Chart 的行为，因为条件文件的输出可能为空，导致测试不完整。

但在 `helm-chartsnap` 中，你只需准备几份预期模式的 `values.yaml` 文件即可 😊

## 安装 🚀

可作为 Helm 插件安装。

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

其它选项：

- Go 安装

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [下载发布版二进制文件](https://github.com/jlandowner/helm-chartsnap/releases)

## 使用方法

快速开始只需传入你的 Chart。

```
helm chartsnap -c YOUR_CHART
```

在 Chart 目录下会创建 `__snapshot__` 目录，并生成 `default.snap`。

你还可以通过 Chart 的 values 文件变体来创建测试用例。

以下是完整命令用法。

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # 使用默认 values 做快照：
  chartsnap -c YOUR_CHART
  
  # 更新快照文件：
  chartsnap -c YOUR_CHART -u

  # 使用测试用例 values 做快照：
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # 对所有测试用例做快照：
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # 为 'helm template' 命令设置附加参数或标志：
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # 对 Helm 仓库中的远程 Chart 做快照：
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # 对特定版本的 ingress-nginx（https://kubernetes.github.io/ingress-nginx/）Chart 以及你的 values 文件做快照：
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # 对 cilium（https://cilium.io）Chart 使用默认值并设置标志做快照：
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # 对 OCI 仓库中的 Chart 做快照
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # 输出无颜色：
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              chart 目录路径。该参数会被传递给 'helm template RELEASE_NAME CHART --values VALUES' 作为 'CHART'
      --config-file string        配置文件名或路径，定义快照行为如动态字段（默认 ".chartsnap.yaml"）
  -N, --ctx-lines int             diff 输出显示的行数，0 为全部输出（默认 3）
      --debug                     调试模式
      --fail-helm-error           当 'helm template' 命令失败时失败
      --failfast                  只要有任一测试用例失败则立即失败
  -h, --help                      chartsnap 帮助
  -n, --namespace string          命名空间。该参数会被传递给 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' 作为 'NAMESPACE'（默认 "default"）
  -o, --output-dir string         __snapshot__ 目录生成的位置（默认：如设置 --values 则为 values 文件目录；本地 chart 则为 chart 目录；否则当前目录）
      --parallelism int           针对测试 values 文件目录多快照时的并发数，默认不限（默认 -1）
      --release-name string       发布名称。该参数会被传递给 'helm template RELEASE_NAME CHART --values VALUES' 作为 'RELEASE_NAME'（默认 "chartsnap"）
      --snapshot-version string   使用指定快照格式版本，支持 v1、v2、v3（默认：最新）
  -u, --update-snapshot           更新快照模式
  -f, --values string             测试 values 文件或目录路径。为目录时会对其中所有测试文件做测试。为空则使用默认 values。该参数会被传递给 'helm template RELEASE_NAME CHART --values VALUES' 作为 'VALUES'
  -v, --version                   chartsnap 版本

```

### 处理动态值 💪

Helm 提供了“Helm 函数”功能，可以生成随机值或自签名证书，如 [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) 及 [`genCA`、`genPrivateKey`、`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

使用这些函数时，每次执行 Helm 输出都不同。
此时，chartsnap 提供了将这些值替换为固定值 `###DYNAMIC_FIELD###` 的功能，以避免快照不匹配。

你可以用 [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901) 指定生成 YAML 中的动态值路径。

```yaml:.chartsnap.yaml
dynamicFields:
  - apiVersion: v1
    kind: Secret
    name: cosmo-auth-env
    jsonPath:
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_BLOCKKEY
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_SESSION_NAME
    base64: true
```

> 注意：
> 在 JSONPath 中，/ 字符的转义见 [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    因为 '~' (%x7E) 和 '/' (%x2F) 在 JSON Pointer 中有特殊含义，
>    所以出现 '~' 时需要编码为 '~0'，出现 '/' 时编码为 '~1'。
> ```
>
> 因此，如果你的 manifest 如下，则需将 json path 指定为 `/metadata/annotaions/checksum~1values`。
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

如果有测试 values 文件目录，可将 `.chartsnap.yaml` 文件放在该目录下。该配置对目录下所有快照测试生效。

更多示例见 [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1)。

或者，你也可以直接在测试 values 文件中通过 `testSpec` 属性添加配置。
适用于仅用单个 values 文件对远程或第三方 Chart 做快照，无需准备 `.chartsnap.yaml`。

你的 values 文件可以如下：

```yaml
# 在你的 values 文件中添加如下属性
testSpec:
  dynamicFields:
    - apiVersion: v1
      kind: Secret
      name: cilium-ca
      jsonPath:
        - /data/ca.crt
        - /data/ca.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-server-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-relay-client-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true

# 其它皆为你的 chart values
# ...
```

更多示例见 [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote)。

## 展示与用户 ✨

| 用户 / 项目 | 说明 | URL |
|:---|:---|:---|
| Example | 通过 `helm create` 命令生成的示例 Chart | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | 对远程 Helm 仓库 Chart 做快照的示例 | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | 在 CI 中使用 helm chartsnap 的 GitHub Action | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | 基于 Kubernetes 的开源 WebIDE 与开发环境平台 | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 云原生 API 网关和 AI 网关 | https://github.com/Kong/charts |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---