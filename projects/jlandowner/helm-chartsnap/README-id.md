# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Alat pengujian snapshot untuk Helm chart.

Bawa kemampuan pengujian UI yang kuat untuk Helm chart dengan konfigurasi minimal hanya melalui file `values.yaml`.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Ikhtisar
- [Fitur 🔑](#fitur-)
- [Mengapa Snapshot Testing? 📸](#mengapa-snapshot-testing-)
  - [Motivasi](#motivasi)
- [Instalasi 🚀](#instalasi-)
- [Penggunaan](#penggunaan)
  - [Menangani nilai dinamis 💪](#menangani-nilai-dinamis-)
- [Showcase & Pengguna ✨](#showcase--pengguna-)


## Fitur 🔑

* **Snapshot testing yang mudah & intuitif untuk pengembang Helm**
  
  - **Tanpa format file TestSuite khusus alat**: Tidak seperti beberapa alat yang membutuhkan pembuatan TestSuites terpisah dengan format file khusus, alat ini tidak membutuhkan format file tambahan. Sebagai gantinya, Anda bisa menyiapkan variasi file `values.yaml` standar untuk setiap kasus uji. Ini menghilangkan kebutuhan mempelajari format baru dan menyederhanakan pengujian.

* **Dioptimalkan untuk Helm chart**

  - **Menangani output dinamis yang dihasilkan oleh fungsi helm**: Anda dapat menentukan properti tambahan dalam file values.yaml untuk setiap kasus uji untuk memberikan fleksibilitas dalam menyesuaikan perilaku pengujian. Misalnya, Anda dapat mengontrol output yang dihasilkan secara dinamis oleh fungsi helm seperti [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **Snapshot testing berkelanjutan**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) siap digunakan**: GitHub Action yang memungkinkan melakukan snapshot testing berkelanjutan untuk Helm chart lokal maupun remote dalam CI Anda sudah siap 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Mengapa Snapshot Testing? 📸

Saya percaya bahwa snapshot testing, sebuah pendekatan pengujian yang populer dalam pengujian Web atau UI dengan alat seperti Jest, adalah cara terbaik untuk menguji Helm chart. Snapshot testing memberikan beberapa manfaat:

- **Perbandingan visual:** Uji snapshot membuat output dasar lalu membandingkannya dengan hasil tes berikutnya. Ini memudahkan inspeksi visual terhadap perubahan dan regresi pada rendering Helm chart.

- **Meningkatkan pemeliharaan:** Snapshot testing menyederhanakan proses setup pengujian, membuatnya lebih mudah diakses dan dipelihara, terutama ketika menangani Helm chart yang kompleks. Input untuk Helm chart adalah kombinasi dari values. Kita hanya perlu memelihara kombinasi input yang diasumsikan (=values.yaml), dan snapshott-nya.

- **Pengujian berkelanjutan:** Dengan terus-menerus mengambil snapshot dari Helm chart dalam proses CI Anda, Anda dapat dengan cepat melihat perubahan pada seluruh chart dan menghindari regresi.

Keuntungan ini tidak hanya terbatas pada Helm chart yang Anda buat, tetapi juga chart pihak ketiga yang Anda instal di Kubernetes Anda jika Anda adalah administrator Kubernetes. Saat melakukan upgrade cluster, Anda dapat melihat setiap perubahan pada output manifests yang dihasilkan oleh *values* Anda, sekecil apapun perubahannya.


### Motivasi

Sudah ada alat pengujian Helm yang mendukung snapshot test.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), alat unit test yang populer, memiliki opsi untuk melakukan [snapshot testing](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/), Automated tests untuk kode infrastruktur Anda. Bisa menulis tes sebagai kode Go dan memiliki fitur untuk menguji output Helm. [blog post](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> Alat tes resmi Helm [`ct`](https://github.com/helm/chart-testing) bukan untuk unit test atau snapshot test tetapi untuk lint dan integration test

Meskipun mereka adalah alat yang berharga untuk pengujian Helm chart, ada beberapa keterbatasan untuk snapshot testing.

- Anda perlu mempelajari dan menyiapkan file Test Suite dari alat tersebut bahkan hanya untuk snapshot testing.

- Secara default, tidak melakukan snapshot seluruh chart, tetapi dirancang untuk menguji per file dalam Helm chart.

- Output dinamis dari fungsi Helm tidak dipertimbangkan.

helm-unittest dirancang untuk melakukan pengujian per file dalam Helm chart. Artinya, ia mengevaluasi setiap file secara independen, dan ketika nilai atau kondisi Helm chart menyebabkan seluruh file dimasukkan atau dikeluarkan secara kondisional, hal ini dapat menyebabkan pengujian tidak dapat mencakup skenario penting.

Berikut adalah contoh file spesifikasi tes untuk snapshot testing pada helm-unittest.

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

Sebagai contoh, perhatikan skenario di mana Helm chart dapat membuat resource `Certificate` dari `cert-manager` ketika TLS dan cert-manager diaktifkan, tetapi membuat resource TLS `Secret` self-signed menggunakan fungsi helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) ketika cert-manager tidak diaktifkan. Selain itu, apakah TLS diaktifkan atau tidak mempengaruhi properti TLS Ingress, opsi TLS khusus aplikasi pada Deployment, dsb.

Dalam kasus seperti ini, helm-unittest mungkin tidak dapat menguji perilaku chart secara keseluruhan dengan memadai, karena output dari file-file kondisional tersebut bisa kosong, sehingga menyebabkan tes tidak lengkap.

Namun, yang perlu Anda lakukan dengan `helm-chartsnap` hanyalah menyiapkan beberapa file `values.yaml` dari pola yang Anda harapkan 😊

## Instalasi 🚀

Anda dapat menginstal sebagai plugin Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Opsi lainnya:

- Go install

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Unduh release binary](https://github.com/jlandowner/helm-chartsnap/releases)

## Penggunaan

Cukup jalankan chart Anda untuk memulai dengan cepat.

```
helm chartsnap -c YOUR_CHART
```

Direktori `__snapshot__` akan dibuat di direktori chart dan `default.snap` akan dibuat.

Anda juga dapat membuat kasus uji sebagai variasi file Values dari chart Anda.

Berikut adalah penggunaan lengkap perintahnya.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Snapshot dengan values default:
  chartsnap -c YOUR_CHART
  
  # Perbarui file snapshot:
  chartsnap -c YOUR_CHART -u

  # Snapshot dengan values kasus uji:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Snapshot semua kasus uji:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # Set argumen tambahan atau flag untuk perintah 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Snapshot chart remote di repository Helm:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # Snapshot ingress-nginx (https://kubernetes.github.io/ingress-nginx/) helm chart untuk versi tertentu dengan file value Anda:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # Snapshot cilium (https://cilium.io) helm chart dengan value default dan set flag:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # Snapshot chart di registry OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Output tanpa warna:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              path ke direktori chart. flag ini diteruskan ke 'helm template RELEASE_NAME CHART --values VALUES' sebagai 'CHART'
      --config-file string        nama atau path file config, yang mendefinisikan perilaku snapshot misal: dynamic fields (default ".chartsnap.yaml")
  -N, --ctx-lines int             jumlah baris yang ditampilkan pada output diff. 0 untuk output penuh (default 3)
      --debug                     mode debug
      --fail-helm-error           gagal jika perintah 'helm template' gagal
      --failfast                  gagal saat kasus uji pertama gagal
  -h, --help                      bantuan untuk chartsnap
  -n, --namespace string          namespace. flag ini diteruskan ke 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' sebagai 'NAMESPACE' (default "default")
  -o, --output-dir string         direktori tempat direktori __snapshot__ dibuat. (default: direktori file values jika --values diset; direktori chart jika chart lokal; jika tidak direktori saat ini)
      --parallelism int           concurrency tes jika mengambil beberapa snapshot dari direktori file test value. default tidak terbatas (default -1)
      --release-name string       nama rilis. flag ini diteruskan ke 'helm template RELEASE_NAME CHART --values VALUES' sebagai 'RELEASE_NAME' (default "chartsnap")
      --snapshot-version string   gunakan versi format snapshot tertentu. v1, v2, v3 didukung. (default: terbaru)
  -u, --update-snapshot           mode update snapshot
  -f, --values string             path ke file test values atau direktori. jika direktori diisi, semua file diuji. jika kosong, values default digunakan. flag ini diteruskan ke 'helm template RELEASE_NAME CHART --values VALUES' sebagai 'VALUES'
  -v, --version                   versi chartsnap

```

### Menangani nilai dinamis 💪

Helm memiliki fitur yang disebut "Helm functions" yang menghasilkan nilai acak atau sertifikat self-signed seperti [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) dan [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

Saat menggunakan fungsi-fungsi ini, output akan berbeda setiap kali Helm dijalankan.
Untuk kasus ini, chartsnap memiliki fitur yang mencegah snapshot tidak cocok dengan menggantinya dengan nilai tetap, `###DYNAMIC_FIELD###`.

Anda dapat menentukan path nilai dinamis dalam YAML yang dihasilkan menggunakan [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

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

> CATATAN:
> Dalam JSONPath, escaping karakter / didokumentasikan pada [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    Karena karakter '~' (%x7E) dan '/' (%x2F) memiliki arti khusus dalam JSON Pointer, '~' perlu dienkode sebagai '~0' dan '/' sebagai '~1' saat karakter ini muncul pada token referensi.
> ```
>
> Jadi jika Anda menangani manifest seperti berikut, Anda perlu menentukan json path sebagai `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Jika Anda memiliki direktori file test values, letakkan sebagai file `.chartsnap.yaml` dalam direktori tersebut. Ini adalah perilaku umum di semua snapshot test di direktori itu.

Untuk contoh lebih lanjut, lihat [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Sebagai alternatif, Anda dapat menambahkan konfigurasi langsung di file test values sebagai properti `testSpec`.
Dalam hal ini, Anda tidak perlu menyiapkan `.chartsnap.yaml`. Ini untuk mengambil snapshot chart remote atau pihak ketiga dengan satu file values Anda.

File values Anda dapat seperti ini:

```yaml
# Tambahkan properti ini ke values Anda.
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

# Lainnya bisa berupa values chart Anda.
# ...
```

Untuk contoh lebih lanjut, lihat [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Showcase & Pengguna ✨

| Pengguna / Proyek | Deskripsi | URL |
|:---|:---|:---|
| Contoh | Chart contoh yang dihasilkan oleh perintah `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Contoh | Contoh snapshot chart di repository Helm remote | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | GitHub action untuk menggunakan helm chartsnap di CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Platform WebIDE & DevEnvironment open source di Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 Cloud-Native API Gateway dan AI Gateway. | https://github.com/Kong/charts |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---