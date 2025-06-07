# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Helmチャート用のスナップショットテストツール。

`values.yaml`ファイル内だけの最小限の設定で、Helmチャートに強力なUIテスト機能をもたらします。

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## 概要
- [特徴 🔑](#特徴-)
- [なぜスナップショットテストか？ 📸](#なぜスナップショットテストか-)
  - [モチベーション](#モチベーション)
- [インストール 🚀](#インストール-)
- [使い方](#使い方)
  - [動的値の扱い 💪](#動的値の扱い-)
- [ショーケース & ユーザー ✨](#ショーケース--ユーザー-)

## 特徴 🔑

* **Helm開発者のための簡単かつ直感的なスナップショットテスト**
  
  - **ツール固有のTestSuiteファイル形式不要**: 一部のツールでは独自のTestSuiteファイルの作成が必要ですが、本ツールでは追加ファイル形式は不要です。各テストケースごとに標準の`values.yaml`ファイルのバリエーションを用意するだけで済みます。新しい形式を学ぶ必要がなく、テストがシンプルになります。

* **Helmチャートに最適化**

  - **helm関数で生成される動的出力の対応**: 各テストケースの`values.yaml`ファイル内で追加プロパティを指定でき、テスト動作を柔軟に調整できます。たとえば、[randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/)のようなhelm関数で動的に生成される出力を制御できます。

* **継続的なスナップショットテスト**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) 対応済み**: ローカルやリモートのHelmチャートに対し、CIで継続的なスナップショットテストを可能にするGitHub Actionを用意しています🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## なぜスナップショットテストか？ 📸

WebやUIテストで一般的なJestのようなスナップショットテストは、Helmチャートのテストにも最適と考えます。スナップショットテストには以下のメリットがあります。

- **視覚的な比較:** スナップショットテストは基準となる出力を作成し、その後のテスト結果と比較します。これにより、Helmチャートのレンダリング結果の変化やリグレッションを容易に目視確認できます。

- **保守性の向上:** スナップショットテストはテストの準備を簡素化し、特に複雑なHelmチャートの場合にも扱いやすく、保守性が高まります。Helmチャートの入力は値（values）の組み合わせだけなので、仮定する入力パターン（=values.yaml）とそのスナップショットだけを管理すれば十分です。

- **継続的テスト:** CIプロセスでHelmチャートのスナップショットを継続的に取得することで、チャート全体の変化をすばやく把握し、リグレッションを防げます。

これらの利点は、自作チャートだけでなく、Kubernetes管理者として導入したサードパーティ製チャートにも有効です。クラスタのアップグレード時にも、自分の*values*から生成される出力マニフェストの変更を細かな点まで検出できます。

### モチベーション

既存のHelmテストツールにもスナップショットテストをサポートするものがあります。
- [helm-unittest](https://github.com/helm-unittest/helm-unittest): 人気のユニットテストツールで、[スナップショットテスト](https://github.com/helm-unittest/helm-unittest#snapshot-testing)オプションがあります。
- [terratest](https://terratest.gruntwork.io/): インフラコードの自動テストツール。Goコードでテストを書き、Helm出力のテストも可能です。 [ブログ記事](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> 公式のHelmテストツール [`ct`](https://github.com/helm/chart-testing) はユニットテストやスナップショットテスト用ではなく、lintや統合テスト用です。

これらはHelmチャートのテストに有用ですが、スナップショットテストの観点ではいくつかの制約があります。

- スナップショットテストだけでもツール用のTest Suiteファイルの準備と習得が必要。

- チャート全体をデフォルトでスナップショットするのではなく、チャート内の各ファイル単位で設計されている。

- Helm関数の動的出力には未対応。

helm-unittestはチャート内の各ファイル単位でテストを実行する設計です。Helmチャートの値や条件により特定ファイルが条件付きで含まれたり除外されたりすると、重要なシナリオのテストが困難になる場合があります。

以下はhelm-unittestのスナップショットテスト用のテスト仕様ファイル例です。

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

例えば、TLSが有効かつcert-managerが有効な場合に`cert-manager`の`Certificate`リソースを生成し、cert-managerが無効な場合はhelm関数[`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert)を使って自己署名TLS`Secret`を生成するシナリオを考えます。TLSの有効/無効はIngressのTLSプロパティやDeploymentのアプリ固有TLSオプションにも影響します。

このような場合、helm-unittestでは条件付きファイルの出力が空になり、チャート全体の挙動を十分にテストできず、テストが不完全になることがあります。

しかし、`helm-chartsnap`なら想定するパターンごとに`values.yaml`ファイルを用意するだけでOKです😊

## インストール 🚀

Helmプラグインとしてインストール可能です。

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

その他の方法:

- Go install

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [リリースバイナリをダウンロード](https://github.com/jlandowner/helm-chartsnap/releases)

## 使い方

チャートを指定してすぐに始められます。

```
helm chartsnap -c YOUR_CHART
```

チャートディレクトリ内に`__snapshot__`ディレクトリと`default.snap`が作成されます。

また、チャートのValuesファイルのバリエーションとしてテストケースも作成できます。

コマンドのフル使用例は下記です。

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # デフォルト値でスナップショット:
  chartsnap -c YOUR_CHART
  
  # スナップショットファイルを更新:
  chartsnap -c YOUR_CHART -u

  # テストケースの値でスナップショット:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # 複数テストケースをまとめてスナップショット:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # 'helm template'コマンド用の追加引数やフラグを指定:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Helmリポジトリ内のリモートチャートをスナップショット:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # ingress-nginx（https://kubernetes.github.io/ingress-nginx/）の特定バージョンチャートを値ファイルでスナップショット:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # cilium（https://cilium.io）チャートをデフォルト値とフラグ指定でスナップショット:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # OCIレジストリ内のチャートをスナップショット
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # カラー出力なし:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              チャートディレクトリのパス。'helm template RELEASE_NAME CHART --values VALUES'の'CHART'として渡されます
      --config-file string        スナップショット動作（例: 動的フィールド）を定義する設定ファイル名またはパス（デフォルト: ".chartsnap.yaml"）
  -N, --ctx-lines int             diff出力で表示する行数。0で全出力（デフォルト: 3）
      --debug                     デバッグモード
      --fail-helm-error           'helm template'コマンド失敗時にエラーで終了
      --failfast                  いずれかのテストケース失敗時に即終了
  -h, --help                      chartsnapのヘルプ
  -n, --namespace string          namespace。'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE'の'NAMESPACE'として渡されます（デフォルト: "default"）
  -o, --output-dir string         '__snapshot__'ディレクトリ作成先（デフォルト: --values指定時はそのディレクトリ、ローカルチャート時はチャートディレクトリ、その他はカレントディレクトリ）
      --parallelism int           複数テスト値ファイルディレクトリ時の同時並列数。デフォルト無制限（デフォルト -1）
      --release-name string       リリース名。'helm template RELEASE_NAME CHART --values VALUES'の'RELEASE_NAME'として渡されます（デフォルト: "chartsnap"）
      --snapshot-version string   特定のスナップショットフォーマットバージョンを使用。v1, v2, v3がサポート（デフォルト: 最新）
  -u, --update-snapshot           スナップショット更新モード
  -f, --values string             テスト値ファイルまたはディレクトリのパス。ディレクトリ指定時は全ファイルをテスト。空ならデフォルト値使用。'helm template RELEASE_NAME CHART --values VALUES'の'VALUES'として渡されます
  -v, --version                   chartsnapのバージョン表示

```

### 動的値の扱い 💪

Helmには[`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii)や[`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)のような、ランダム値や自己署名証明書を生成する"Helm関数"があります。

これらの関数を使うと、Helm実行ごとに出力が異なります。
この場合、chartsnapでは出力の該当部分を固定値`###DYNAMIC_FIELD###`に置換することでスナップショット差分を防ぐ機能があります。

生成されたYAML内の動的値のパスは[JSONPath](https://datatracker.ietf.org/doc/html/rfc6901)で指定します。

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

> 補足:
> JSONPathでの/文字のエスケープは[RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)に記載されています。
> ```
>    JSON Pointerでは'~'（%x7E）と'/'（%x2F）は特別な意味を持つため、
>    '~'は'~0'、'/'は'~1'としてトークン内でエンコードする必要があります。
> ```
>
> 例えば以下のようなマニフェストを扱う場合、json pathは`/metadata/annotaions/checksum~1values`と指定します。
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

テスト値ファイルディレクトリがある場合は、そのディレクトリ内に`.chartsnap.yaml`を配置してください。ディレクトリ内のすべてのスナップショットテストで共通設定として動作します。

より多くの例は[example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1)を参照してください。

また、テスト値ファイル内に直接`testSpec`プロパティとして設定を書くことも可能です。
この場合、`.chartsnap.yaml`の準備は不要です。リモートやサードパーティチャートの単一値ファイルスナップショット用です。

値ファイル例:

```yaml
# このプロパティを追加
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

# その他は通常のチャート値
# ...
```

より多くの例は[example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote)を参照してください。

## ショーケース & ユーザー ✨

| ユーザー / プロジェクト | 説明 | URL |
|:---|:---|:---|
| Example | `helm create`コマンドで生成したサンプルチャート | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | リモートHelmリポジトリのチャートをスナップショットする例 | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | CIでhelm chartsnapを利用するGitHub Action | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Kubernetes上のオープンソースWebIDE & DevEnvironmentプラットフォーム | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 クラウドネイティブAPIゲートウェイ & AIゲートウェイ | https://github.com/Kong/charts |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---