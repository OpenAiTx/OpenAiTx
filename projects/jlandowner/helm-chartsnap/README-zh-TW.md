# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Helm chart 的快照測試工具。

只需在 `values.yaml` 檔案中進行最小化的設定，即可為 Helm chart 帶來強大的 UI 測試能力。

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## 概覽
- [功能 🔑](#features-)
- [為什麼要做快照測試？📸](#why-snapshot-testing-)
  - [動機](#motivation)
- [安裝 🚀](#installation-)
- [使用方式](#usage)
  - [處理動態值 💪](#handling-dynamic-values-)
- [展示與用戶 ✨](#showcase--users-)

## 功能 🔑

* **為 Helm 開發者提供簡單直覺的快照測試**
  
  - **無需特定工具測試套件檔案格式**：不同於某些工具需要建立自訂格式的測試套件檔案，本工具不需要額外的檔案格式。你只需為每個測試案例準備標準 `values.yaml` 文件的不同變化即可。這省去了學習新格式的麻煩，簡化了測試流程。

* **針對 Helm chart 優化**

  - **處理 helm 函數產生的動態輸出**：你可以在每個測試案例的 values.yaml 檔案中指定額外屬性，以靈活調整測試行為。例如，可以控制由 helm 函數如 [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/) 動態生成的輸出。

* **持續快照測試**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) 已就緒**：已提供 GitHub Action，可在 CI 中對本地或遠端 Helm charts 進行持續快照測試 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## 為什麼要做快照測試？📸

我相信快照測試是一種在 Web 或 UI 測試（如 Jest 等工具）中非常受歡迎的測試方法，也是測試 Helm charts 的最佳方式。快照測試帶來以下幾點優勢：

- **視覺化比較**：快照測試會建立基準輸出，並與後續測試結果進行比較。這讓你可以輕鬆檢視 Helm chart 渲染的變動與回歸。

- **提升可維護性**：快照測試簡化了測試設置流程，尤其是在處理複雜 Helm chart 時更容易上手與維護。Helm chart 的輸入是一組值的組合。我們只需維護假設的輸入組合（=values.yaml）及其快照。

- **持續測試**：透過在 CI 流程中持續對 Helm chart 拍攝快照，可以快速發現整個 chart 的變動，避免回歸問題。

這些優勢不僅適用於你自己開發的 Helm chart，對於作為 Kubernetes 管理員，安裝的第三方 chart 也同樣適用。升級叢集時，可以即時發現 *values* 所產生的輸出清單有任何細微變動。

### 動機

目前已存在支援快照測試的 Helm 測試工具。
- [helm-unittest](https://github.com/helm-unittest/helm-unittest)：受歡迎的單元測試工具，支援 [快照測試](https://github.com/helm-unittest/helm-unittest#snapshot-testing)。
- [terratest](https://terratest.gruntwork.io/)：基礎設施程式碼自動化測試工具，可用 Go 撰寫測試，並支援測試 Helm 輸出。[部落格](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> 官方 Helm 測試工具 [`ct`](https://github.com/helm/chart-testing) 並非用於單元或快照測試，而是用於 lint 與整合測試

雖然這些都是很有價值的 Helm 測試工具，但在快照測試方面有一定限制：

- 即使只做快照測試，也需學習並準備工具的測試套件檔案。

- 預設不對整個 chart 快照，而是針對 Helm chart 內的單一檔案進行測試設計。

- 未考慮 helm 函數產生的動態輸出。

helm-unittest 設計上是針對 Helm chart 內的單一檔案進行測試。這意味著它會獨立評估每個檔案，當 Helm chart 的值或條件導致某個檔案被有條件地包含或排除時，可能使測試無法涵蓋重要情境。

以下是 helm-unittest 進行快照測試的測試規格檔案範例。

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

舉例來說，假設 Helm chart 在啟用 TLS 且啟用 cert-manager 時會建立一個 cert-manager 的 `Certificate` 資源，但在未啟用 cert-manager 時會用 helm 函數 [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) 建立自簽 TLS `Secret` 資源。此外，TLS 是否啟用也會影響 Ingress 的 TLS 屬性、Deployment 的應用專屬 TLS 選項等。

這種情境下，helm-unittest 可能無法充分測試整個 chart 的行為，因為這些有條件檔案的輸出可能為空，導致測試不完整。

但若使用 `helm-chartsnap`，你只需準備幾個你預期的 `values.yaml` 檔案即可 😊

## 安裝 🚀

你可以作為 Helm 插件安裝。

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

其他選項：

- Go 安裝

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [下載發行版執行檔](https://github.com/jlandowner/helm-chartsnap/releases)

## 使用方式

只需指定你的 chart，即可快速開始。

```
helm chartsnap -c YOUR_CHART
```

`__snapshot__` 目錄會在 chart 目錄中建立，並產生 `default.snap`。

你也可以透過 chart 的 Values 檔案變化建立測試案例。

以下為完整指令用法：

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # 以預設值快照：
  chartsnap -c YOUR_CHART
  
  # 更新快照檔案：
  chartsnap -c YOUR_CHART -u

  # 以測試值檔案快照：
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # 快照所有測試案例：
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # 設定 'helm template' 指令的其他參數或旗標：
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # 快照 Helm repository 中的遠端 chart：
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # 以指定版本及值檔案快照 ingress-nginx (https://kubernetes.github.io/ingress-nginx/)：
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # 以預設值與旗標快照 cilium (https://cilium.io)：
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # 快照 OCI registry 中的 charts
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # 輸出無顏色：
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              chart 目錄路徑。此旗標將傳遞給 'helm template RELEASE_NAME CHART --values VALUES' 的 'CHART'
      --config-file string        設定檔名或路徑，定義快照行為，例如動態欄位（預設 ".chartsnap.yaml"）
  -N, --ctx-lines int             diff 輸出顯示行數。0 為完整輸出（預設 3）
      --debug                     除錯模式
      --fail-helm-error           'helm template' 指令失敗時中止
      --failfast                  任一測試案例失敗即中止
  -h, --help                      顯示 chartsnap 說明
  -n, --namespace string          命名空間。此旗標將傳遞給 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' 的 'NAMESPACE'（預設 "default"）
  -o, --output-dir string         建立 __snapshot__ 目錄的位置。（預設：若設 --values 則為 values 檔案目錄；本地 chart 則為 chart 目錄；否則為目前目錄）
      --parallelism int           若測試值檔目錄含多檔案時的並行數。預設無限制（預設 -1）
      --release-name string       發行名稱。此旗標將傳遞給 'helm template RELEASE_NAME CHART --values VALUES' 的 'RELEASE_NAME'（預設 "chartsnap"）
      --snapshot-version string   使用特定快照格式版本。支援 v1、v2、v3。（預設為最新版）
  -u, --update-snapshot           更新快照模式
  -f, --values string             測試值檔案或目錄路徑。若為目錄，則測試所有檔案。若為空，則使用預設值。此旗標將傳遞給 'helm template RELEASE_NAME CHART --values VALUES' 的 'VALUES'
  -v, --version                   顯示 chartsnap 版本

```

### 處理動態值 💪

Helm 有一項稱為「Helm 函數」的功能，可產生隨機值或自簽憑證，如 [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) 及 [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

使用這些函數時，每次執行 Helm 輸出都會不同。
針對這種情況，chartsnap 提供將其替換成固定值 `###DYNAMIC_FIELD###` 的功能，以避免快照不符。

你可以用 [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901) 指定動態值在產生的 YAML 內的路徑。

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
> 在 JSONPath 中，/ 字元轉義方式見 [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    由於 '~' (%x7E) 與 '/' (%x2F) 在 JSON Pointer 中有特殊意義，
>    當這些字元出現在參照 token 時，'~' 需轉為 '~0'，'/' 需轉為 '~1'。
> ```
>
> 因此若處理如下 manifest，須將 json path 指定為 `/metadata/annotaions/checksum~1values`。
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

若你有一個測試值檔目錄，請將 `.chartsnap.yaml` 放在該目錄下，該設定適用目錄內所有快照測試。

更多範例請參考 [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1)。

或者，也可以直接在測試值檔中以 `testSpec` 屬性新增設定。
這種情境適用於只用單一值檔快照遠端或第三方 chart，不需額外準備 `.chartsnap.yaml`。

你的 values 檔案可如下所示：

```yaml
# 在你的 values 加入此屬性
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

# 其餘內容可為任何 chart 支援的值
# ...
```

更多範例請參考 [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote)。

## 展示與用戶 ✨

| 用戶 / 專案 | 說明 | URL |
|:---|:---|:---|
| Example | 由 `helm create` 指令產生的範例 chart | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | 對遠端 Helm repository charts 進行快照的範例 | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | 在 CI 使用 helm chartsnap 的 GitHub Action | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Kubernetes 上的開源 WebIDE 與 DevEnvironment 平台 | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 雲原生 API Gateway 與 AI Gateway | https://github.com/Kong/charts |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---