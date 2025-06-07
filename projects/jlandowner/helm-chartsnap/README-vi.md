# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Công cụ kiểm thử snapshot cho Helm charts.

Mang lại khả năng kiểm thử UI mạnh mẽ cho Helm chart với cấu hình tối thiểu chỉ trong tệp `values.yaml`. 

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Tổng quan
- [Tính năng 🔑](#tính-năng-)
- [Tại sao kiểm thử Snapshot? 📸](#tại-sao-kiểm-thử-snapshot-)
  - [Động lực](#động-lực)
- [Cài đặt 🚀](#cài-đặt-)
- [Sử dụng](#sử-dụng)
  - [Xử lý giá trị động 💪](#xử-lý-giá-trị-động-)
- [Trình diễn & Người dùng ✨](#trình-diễn--người-dùng-)


## Tính năng 🔑

* **Kiểm thử Snapshot dễ dàng & trực quan cho các nhà phát triển Helm**
  
  - **Không cần định dạng TestSuite riêng cho công cụ**: Không giống một số công cụ yêu cầu tạo các TestSuite riêng biệt với định dạng tệp tùy chỉnh, công cụ này không yêu cầu thêm bất kỳ định dạng tệp nào. Thay vào đó, bạn có thể chuẩn bị các biến thể của tệp `values.yaml` chuẩn cho mỗi trường hợp kiểm thử. Điều này loại bỏ việc phải học các định dạng mới và đơn giản hóa kiểm thử.

* **Tối ưu cho Helm chart**

  - **Xử lý đầu ra động được tạo bởi các hàm helm**: Bạn có thể chỉ định các thuộc tính bổ sung trong tệp values.yaml cho mỗi trường hợp kiểm thử để linh hoạt điều chỉnh hành vi kiểm thử. Ví dụ, bạn có thể kiểm soát đầu ra được sinh động bởi các hàm helm như [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Kiểm thử Snapshot liên tục**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) đã sẵn sàng**: Đã có GitHub action cho phép kiểm thử snapshot liên tục cho các Helm chart cục bộ hoặc từ xa trong CI của bạn 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Tại sao kiểm thử Snapshot? 📸

Tôi tin rằng kiểm thử snapshot, một phương pháp kiểm thử phổ biến trong kiểm thử Web hoặc UI với các công cụ như Jest, là cách tốt nhất để kiểm thử Helm chart. Kiểm thử snapshot mang lại nhiều lợi ích:

- **So sánh trực quan:** Kiểm thử snapshot tạo ra đầu ra nền tảng (baseline) và so sánh với kết quả kiểm thử sau đó. Điều này cho phép dễ dàng kiểm tra trực quan các thay đổi và hồi quy trong việc render Helm chart.

- **Tăng khả năng bảo trì:** Kiểm thử snapshot đơn giản hóa quá trình thiết lập kiểm thử, giúp dễ tiếp cận và bảo trì hơn, đặc biệt khi làm việc với các Helm chart phức tạp. Đầu vào cho Helm chart là sự kết hợp các giá trị. Chúng ta chỉ cần duy trì các tổ hợp đầu vào giả định(=values.yaml) và các snapshot của chúng.

- **Kiểm thử liên tục:** Bằng cách liên tục chụp snapshot của Helm chart trong quá trình CI, bạn có thể nhanh chóng nhận thấy các thay đổi của toàn bộ chart và tránh được các hồi quy.

Những lợi ích này không chỉ giới hạn với Helm chart bạn tự tạo, mà còn áp dụng cho các chart bên thứ ba bạn đã cài đặt trên Kubernetes nếu bạn là quản trị viên Kubernetes. Khi nâng cấp cụm, bạn có thể nhận ra bất kỳ thay đổi nào trong manifest đầu ra được tạo bởi các *values* của bạn, dù là nhỏ nhất.


### Động lực

Có những công cụ kiểm thử Helm hiện có hỗ trợ kiểm thử snapshot.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), một công cụ kiểm thử đơn vị phổ biến, có tùy chọn [kiểm thử snapshot](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), kiểm thử tự động cho mã hạ tầng của bạn. Có thể viết kiểm thử dưới dạng mã Go và có tính năng kiểm thử đầu ra của Helm. [bài viết](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> Công cụ kiểm thử chính thức của Helm [`ct`](https://github.com/helm/chart-testing) không dùng cho kiểm thử đơn vị hoặc snapshot mà cho lint và kiểm thử tích hợp

Mặc dù đây là những công cụ giá trị cho kiểm thử Helm chart, chúng có một số hạn chế nhất định đối với kiểm thử snapshot.

- Bạn cần học và chuẩn bị các tệp Test Suite của công cụ, ngay cả chỉ để kiểm thử snapshot.

- Không snapshot toàn bộ chart theo mặc định, mà được thiết kế kiểm thử trên từng tệp trong Helm chart.

- Không xem xét các đầu ra động của hàm Helm.

helm-unittest được thiết kế để kiểm thử trên từng tệp trong Helm chart. Điều này có nghĩa là nó đánh giá từng tệp độc lập, và khi các giá trị hoặc điều kiện của Helm chart dẫn đến việc một tệp được bao gồm hoặc loại trừ một cách có điều kiện, có thể khiến kiểm thử không bao phủ được các kịch bản quan trọng.

Dưới đây là ví dụ về tệp test spec cho kiểm thử snapshot trong helm-unittest.

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
>   # hoặc bạn có thể snapshot toàn bộ manifest
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

Ví dụ, hãy xem xét một kịch bản mà Helm chart có thể tạo resource `Certificate` của `cert-manager` khi cả TLS và cert-manager đều được bật, nhưng tạo resource Secret TLS tự ký bằng hàm helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) khi cert-manager không được bật. Ngoài ra, việc bật hoặc tắt TLS còn ảnh hưởng đến thuộc tính TLS của Ingress, tùy chọn TLS đặc thù của Deployment, v.v.

Trong các trường hợp này, helm-unittest có thể không kiểm thử đầy đủ hành vi của toàn bộ chart, vì đầu ra của các tệp điều kiện này có thể rỗng, dẫn đến kiểm thử không đầy đủ.

Tuy nhiên, tất cả những gì bạn cần làm với `helm-chartsnap` chỉ là chuẩn bị một số tệp `values.yaml` cho các mẫu bạn mong đợi 😊

## Cài đặt 🚀

Bạn có thể cài đặt như một plugin của Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Các tùy chọn khác:

- Cài đặt qua Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Tải bản phát hành nhị phân](https://github.com/jlandowner/helm-chartsnap/releases)

## Sử dụng

Chỉ cần truyền chart của bạn để bắt đầu nhanh.

```
helm chartsnap -c YOUR_CHART
```

Thư mục `__snapshot__` sẽ được tạo trong thư mục chart và `default.snap` được tạo ra.

Ngoài ra, bạn có thể tạo các trường hợp kiểm thử dưới dạng biến thể của các tệp Values của chart.

Đây là cách sử dụng đầy đủ của lệnh.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Snapshot với giá trị mặc định:
  chartsnap -c YOUR_CHART
  
  # Cập nhật tệp snapshot:
  chartsnap -c YOUR_CHART -u

  # Snapshot với giá trị kiểm thử:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Snapshot tất cả trường hợp kiểm thử:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # Thêm tham số hoặc cờ bổ sung cho lệnh 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Snapshot chart từ xa trong Helm repository:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # Snapshot ingress-nginx (https://kubernetes.github.io/ingress-nginx/) chart phiên bản cụ thể với tệp value của bạn:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot cilium (https://cilium.io) chart với giá trị mặc định và đặt flags:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot chart trong registry OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Xuất đầu ra không màu:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              đường dẫn tới thư mục chart. cờ này được truyền tới 'helm template RELEASE_NAME CHART --values VALUES' dưới dạng 'CHART'
      --config-file string        tên tệp cấu hình hoặc đường dẫn, định nghĩa hành vi snapshot, ví dụ trường động (mặc định ".chartsnap.yaml")
  -N, --ctx-lines int             số dòng hiển thị trong đầu ra diff. 0 để hiển thị toàn bộ (mặc định 3)
      --debug                     chế độ debug
      --fail-helm-error           thất bại nếu lệnh 'helm template' thất bại
      --failfast                  thất bại ngay khi bất kỳ trường hợp kiểm thử nào thất bại
  -h, --help                      trợ giúp cho chartsnap
  -n, --namespace string          namespace. cờ này được truyền tới 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' dưới dạng 'NAMESPACE' (mặc định "default")
  -o, --output-dir string         thư mục nơi thư mục __snapshot__ được tạo. (mặc định: thư mục tệp values nếu --values được đặt; thư mục chart nếu chart là cục bộ; nếu không là thư mục hiện tại)
      --parallelism int           số kiểm thử đồng thời nếu chụp nhiều snapshot cho thư mục tệp value kiểm thử. mặc định là không giới hạn (mặc định -1)
      --release-name string       tên release. cờ này được truyền tới 'helm template RELEASE_NAME CHART --values VALUES' dưới dạng 'RELEASE_NAME' (mặc định "chartsnap")
      --snapshot-version string   sử dụng định dạng snapshot phiên bản cụ thể. hỗ trợ v1, v2, v3. (mặc định: mới nhất)
  -u, --update-snapshot           chế độ cập nhật snapshot
  -f, --values string             đường dẫn đến tệp value kiểm thử hoặc thư mục. nếu là thư mục, tất cả tệp kiểm thử sẽ được kiểm thử. nếu để trống, sử dụng giá trị mặc định. cờ này được truyền tới 'helm template RELEASE_NAME CHART --values VALUES' dưới dạng 'VALUES'
  -v, --version                   phiên bản của chartsnap

```

### Xử lý giá trị động 💪

Helm có một tính năng gọi là "Helm functions" để tạo ra các giá trị ngẫu nhiên hoặc chứng chỉ tự ký như [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) và [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Khi sử dụng các hàm này, đầu ra sẽ thay đổi mỗi lần Helm được thực thi.
Đối với trường hợp này, chartsnap có tính năng ngăn các snapshot không khớp bằng cách thay thế chúng bằng giá trị cố định, `###DYNAMIC_FIELD###`.

Bạn có thể chỉ định các đường dẫn giá trị động trong YAML sinh ra bằng [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

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

> LƯU Ý:
> Trong JSONPath, việc escape ký tự / được ghi trong [RFC6901, mục 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Vì các ký tự '~' (%x7E) và '/' (%x2F) có ý nghĩa đặc biệt trong JSON Pointer,
>    '~' cần được mã hóa thành '~0' và '/' thành '~1' khi xuất hiện trong token tham chiếu.
> ```
>
> Vì vậy nếu bạn xử lý manifest như sau, bạn cần chỉ định json path là `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Nếu bạn có một thư mục tệp value kiểm thử, hãy đặt tệp `.chartsnap.yaml` trong thư mục đó. Đây là hành vi chung cho mọi kiểm thử snapshot trong thư mục.

Để xem thêm ví dụ, hãy tham khảo [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Ngoài ra, bạn có thể thêm trực tiếp cấu hình vào tệp value kiểm thử dưới dạng thuộc tính `testSpec`.
Khi đó, bạn không cần chuẩn bị `.chartsnap.yaml`. Thích hợp cho việc chụp snapshot chart từ xa hoặc bên thứ ba với chỉ một tệp value.

Tệp value của bạn có thể như sau:

```yaml
# Thêm thuộc tính này vào value của bạn.
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

# Các phần khác là bất kỳ giá trị nào của chart bạn.
# ...
```

Để xem thêm ví dụ, hãy tham khảo [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Trình diễn & Người dùng ✨

| Người dùng / Dự án | Mô tả | URL |
|:---|:---|:---|
| Example | Chart ví dụ được tạo bởi lệnh `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | Ví dụ về snapshot chart trong Helm repo từ xa | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub action dùng helm chartsnap trong CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Nền tảng WebIDE & DevEnvironment mã nguồn mở trên Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 Cổng API Cloud-Native và AI Gateway. | https://github.com/Kong/charts |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---