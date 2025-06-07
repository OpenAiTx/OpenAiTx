# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Helm 차트를 위한 스냅샷 테스트 도구입니다.

`values.yaml` 파일 내에서 최소한의 설정만으로 Helm 차트에 강력한 UI 테스트 기능을 제공합니다.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## 개요
- [특징 🔑](#특징-)
- [왜 스냅샷 테스트인가? 📸](#왜-스냅샷-테스트인가-)
  - [동기](#동기)
- [설치 🚀](#설치-)
- [사용법](#사용법)
  - [동적 값 처리 💪](#동적-값-처리-)
- [쇼케이스 & 사용자 ✨](#쇼케이스--사용자-)


## 특징 🔑

* **Helm 개발자를 위한 쉽고 직관적인 스냅샷 테스트**
  
  - **도구별 TestSuite 파일 포맷 불필요**: 일부 도구처럼 별도의 TestSuite 파일 포맷을 만들 필요가 없습니다. 각 테스트 케이스별로 표준 `values.yaml` 파일의 변형만 준비하면 됩니다. 새로운 포맷을 배울 필요가 없어 테스트가 간편해집니다.

* **Helm 차트에 최적화**

  - **Helm 함수로 생성되는 동적 출력 처리**: 각 테스트 케이스의 values.yaml 파일 내에 추가 속성을 지정하여 테스트 동작을 유연하게 조정할 수 있습니다. 예를 들어 [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/)과 같은 Helm 함수로 동적으로 생성되는 출력을 제어할 수 있습니다.

* **지속적인 스냅샷 테스트**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) 지원**: CI에서 로컬 또는 원격 Helm 차트에 대한 지속적인 스냅샷 테스트를 가능하게 하는 GitHub Action이 준비되어 있습니다 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## 왜 스냅샷 테스트인가? 📸

Jest와 같은 도구로 Web이나 UI 테스트에서 인기 있는 스냅샷 테스트가 Helm 차트 테스트에도 최적이라고 생각합니다. 스냅샷 테스트는 여러 가지 장점을 제공합니다:

- **시각적 비교:** 스냅샷 테스트는 기준 출력과 이후 테스트 결과를 비교합니다. Helm 차트 렌더링의 변경점 및 회귀를 쉽게 시각적으로 확인할 수 있습니다.

- **유지보수성 향상:** 스냅샷 테스트는 Helm 차트가 복잡해질수록 테스트 준비를 단순화하고 유지보수를 쉽게 해줍니다. Helm 차트의 입력은 values의 조합이므로, 가정한 입력 조합(=values.yaml)과 해당 스냅샷만 관리하면 됩니다.

- **지속적인 테스트:** CI 프로세스에서 Helm 차트의 스냅샷을 지속적으로 찍음으로써, 전체 차트의 변경점을 빠르게 감지하고 회귀를 방지할 수 있습니다.

이러한 장점은 여러분이 만든 Helm 차트뿐만 아니라, Kubernetes 관리자인 경우 설치한 서드파티 차트에도 적용됩니다. 클러스터 업그레이드 시 *values*에 의해 생성되는 출력 매니페스트의 사소한 변경도 감지할 수 있습니다.

### 동기

이미 스냅샷 테스트를 지원하는 Helm 테스트 도구들이 있습니다.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest): 대표적인 유닛 테스트 도구로, [스냅샷 테스트 옵션](https://github.com/helm-unittest/helm-unittest#snapshot-testing)을 제공합니다.
- [terratest](https://terratest.gruntwork.io/): 인프라 코드 자동화 테스트 도구로, Go 코드로 Helm 출력 테스트를 작성할 수 있습니다. [관련 블로그 포스트](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> 공식 Helm 테스트 도구 [`ct`](https://github.com/helm/chart-testing)는 유닛/스냅샷 테스트용이 아니라 린트 및 통합 테스트용입니다.

이 도구들은 Helm 차트 테스트에 유용하지만, 스냅샷 테스트에서는 몇 가지 한계가 있습니다.

- 스냅샷 테스트만 해도 도구의 Test Suite 파일을 학습하고 준비해야 합니다.

- 기본적으로 전체 차트가 아닌, 차트 내 개별 파일 단위로 테스트하도록 설계되어 있습니다.

- Helm 함수의 동적 출력은 고려되지 않습니다.

helm-unittest는 차트 내 각 파일 단위로 테스트하도록 설계되어 있습니다. 즉, Helm 차트 값이나 조건에 따라 파일 전체가 조건부로 포함/제외될 경우, 중요한 시나리오를 테스트하지 못할 수 있습니다.

다음은 helm-unittest에서 스냅샷 테스트를 위한 테스트 명세 파일의 예시입니다.

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

예를 들어, TLS와 cert-manager가 활성화되면 `cert-manager`의 `Certificate` 리소스를, cert-manager가 비활성화면 Helm 함수 [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert)로 자체 서명된 TLS `Secret` 리소스를 생성하는 차트 시나리오가 있다고 가정해봅시다. TLS 활성화 여부는 Ingress의 TLS 속성, Deployment의 앱별 TLS 옵션 등에도 영향을 미칩니다.

이런 경우 helm-unittest로는 조건부 파일의 출력이 비어 있을 수 있어 전체 차트의 동작을 충분히 테스트하지 못할 수 있습니다.

그러나 `helm-chartsnap`을 사용하면 기대하는 패턴의 `values.yaml` 파일만 준비하면 됩니다 😊

## 설치 🚀

Helm 플러그인으로 설치할 수 있습니다.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

다른 설치 방법:

- Go 설치

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [릴리즈 바이너리 다운로드](https://github.com/jlandowner/helm-chartsnap/releases)

## 사용법

빠른 시작을 원한다면 차트만 전달하세요.

```
helm chartsnap -c YOUR_CHART
```

차트 디렉터리에 `__snapshot__` 디렉터리가 생성되고 `default.snap`이 만들어집니다.

또한, 차트 Values 파일의 변형으로 테스트 케이스를 만들 수 있습니다.

명령어의 전체 사용법은 다음과 같습니다.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # 기본 값으로 스냅샷 생성:
  chartsnap -c YOUR_CHART
  
  # 스냅샷 파일 업데이트:
  chartsnap -c YOUR_CHART -u

  # 테스트 케이스 values로 스냅샷 생성:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # 모든 테스트 케이스 스냅샷 생성:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # 'helm template' 명령의 추가 인자/플래그 지정:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Helm 저장소의 원격 차트 스냅샷:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # ingress-nginx (https://kubernetes.github.io/ingress-nginx/) 차트 특정 버전 스냅샷:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # cilium (https://cilium.io) 차트를 기본 값으로 플래그와 함께 스냅샷:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # OCI 레지스트리의 차트 스냅샷
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # 컬러 없는 출력:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              차트 디렉터리 경로. 'helm template RELEASE_NAME CHART --values VALUES'에서 'CHART'로 전달됨
      --config-file string        스냅샷 동작(예: 동적 필드)을 정의하는 설정 파일명/경로 (기본값 ".chartsnap.yaml")
  -N, --ctx-lines int             diff 출력에서 표시할 줄 수. 0이면 전체 출력 (기본값 3)
      --debug                     디버그 모드
      --fail-helm-error           'helm template' 명령 실패 시 실패로 처리
      --failfast                  어떤 테스트 케이스라도 실패 시 즉시 종료
  -h, --help                      chartsnap 도움말
  -n, --namespace string          네임스페이스. 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE'에서 'NAMESPACE'로 전달 (기본값 "default")
  -o, --output-dir string         __snapshot__ 디렉터리가 생성될 경로 (기본: --values가 있으면 values 파일의 디렉터리, 로컬 차트면 차트 디렉터리, 그 외 현재 디렉터리)
      --parallelism int           테스트 동시성(여러 테스트 값 파일 디렉터리 스냅샷 시). 기본 무제한 (기본값 -1)
      --release-name string       릴리스명. 'helm template RELEASE_NAME CHART --values VALUES'에서 'RELEASE_NAME'으로 전달 (기본값 "chartsnap")
      --snapshot-version string   사용할 스냅샷 포맷 버전. v1, v2, v3 지원 (기본: 최신)
  -u, --update-snapshot           스냅샷 업데이트 모드
  -f, --values string             테스트 values 파일 또는 디렉터리 경로. 디렉터리 지정 시 모든 테스트 파일 테스트. 비어있으면 기본 values 사용. 'helm template RELEASE_NAME CHART --values VALUES'에서 'VALUES'로 전달
  -v, --version                   chartsnap 버전 출력

```

### 동적 값 처리 💪

Helm에는 [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii), [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions) 등 무작위 값이나 자체 서명 인증서를 생성하는 "Helm 함수" 기능이 있습니다.

이 함수들을 사용할 경우 Helm 실행마다 출력이 달라집니다.
이럴 때 chartsnap은 고정 값 `###DYNAMIC_FIELD###`로 대체하여 스냅샷 불일치를 방지할 수 있습니다.

생성된 YAML 내에서 동적 값의 경로는 [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901)로 지정할 수 있습니다.

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

> 참고:
> JSONPath에서 / 문자는 [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)에 따라 escape해야 합니다.
> ```
>    '~' (%x7E)와 '/' (%x2F)는 JSON Pointer에서 특별한 의미가 있으므로,
>    '~'는 '~0', '/'는 '~1'로 인코딩해야 합니다.
> ```
>
> 따라서 아래와 같은 매니페스트를 처리할 때는 json path를 `/metadata/annotaions/checksum~1values`로 지정해야 합니다.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

테스트 values 파일 디렉터리가 있다면, 해당 디렉터리에 `.chartsnap.yaml` 파일로 위 내용을 배치하세요. 디렉터리 내 모든 스냅샷 테스트에 공통으로 적용됩니다.

자세한 예시는 [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) 참조.

또는 테스트 values 파일에 `testSpec` 속성을 직접 추가할 수도 있습니다.
이 경우, `.chartsnap.yaml`을 별도로 준비할 필요 없습니다. 단일 values 파일로 원격/서드파티 차트의 스냅샷을 찍을 때 유용합니다.

values 파일 예시는 다음과 같습니다:

```yaml
# values 파일에 이 속성 추가
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

# 나머지는 차트의 일반 values
# ...
```

더 많은 예시는 [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) 참조.

## 쇼케이스 & 사용자 ✨

| 사용자 / 프로젝트 | 설명 | URL |
|:---|:---|:---|
| 예제 | `helm create` 명령으로 생성된 예제 차트 | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| 예제 | 원격 Helm 저장소 차트 스냅샷 예제 | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | CI에서 helm chartsnap을 사용하는 GitHub Action | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Kubernetes 기반 오픈소스 WebIDE & DevEnvironment 플랫폼 | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 클라우드 네이티브 API Gateway 및 AI Gateway | https://github.com/Kong/charts |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---