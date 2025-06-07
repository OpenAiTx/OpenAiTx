# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

Helm chartlar için anlık görüntü (snapshot) test aracı.

`values.yaml` dosyası içinde minimum konfigürasyonla Helm chartlar için güçlü bir arayüz test kabiliyeti kazandırır. 

![ekran görüntüsü](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## Genel Bakış
- [Özellikler 🔑](#özellikler-)
- [Neden Snapshot Test? 📸](#neden-snapshot-test-)
  - [Motivasyon](#motivasyon)
- [Kurulum 🚀](#kurulum-)
- [Kullanım](#kullanim)
  - [Dinamik değerlerle başa çıkma 💪](#dinamik-değerlerle-başa-çıkma-)
- [Vitrin & Kullanıcılar ✨](#vitrin--kullanıcılar-)


## Özellikler 🔑

* **Helm geliştiricileri için kolay ve sezgisel snapshot testi**
  
  - **Araca özel TestSuite dosya formatı yok**: Bazı araçlar özel dosya formatları ile ayrı TestSuite oluşturmanızı isterken, bu araç ekstra dosya formatına gerek duymaz. Bunun yerine, her test vakası için standart `values.yaml` dosyasının varyasyonlarını hazırlayabilirsiniz. Bu, yeni formatlar öğrenme ihtiyacını ortadan kaldırır ve testleri basitleştirir.

* **Helm chart için optimize edilmiştir**

  - **Helm fonksiyonları tarafından üretilen dinamik çıktıları yönetme**: Her test vakası için `values.yaml` dosyası içinde ek özellikler belirtebilirsiniz, böylece test davranışını ayarlamakta esneklik sağlar. Örneğin, [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/) gibi helm fonksiyonlarının ürettiği çıktıyı kontrol edebilirsiniz.

* **Sürekli Snapshot testi**

  - **[GitHub Action](https://github.com/jlandowner/helm-chartsnap-action) hazır**: Yerel veya uzaktaki Helm chartlarınız için CI ortamınızda sürekli snapshot testi yapabilmenizi sağlayan GitHub Action hazır 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## Neden Snapshot Test? 📸

Web veya arayüz testlerinde Jest gibi araçlarla popüler olan snapshot testinin, Helm chartları test etmek için en iyi yol olduğuna inanıyorum. Snapshot testi, çeşitli avantajlar sağlar:

- **Görsel karşılaştırmalar:** Snapshot testleri, bir temel çıktı oluşturur ve bunu sonraki test sonuçlarıyla karşılaştırır. Bu, Helm chart render çıktısındaki değişikliklerin ve regresyonların kolayca görsel olarak incelenmesini sağlar.

- **Artırılmış sürdürülebilirlik:** Snapshot testi, test kurulum sürecini basitleştirir, özellikle karmaşık Helm chartlarla çalışırken erişilebilirliği ve sürdürülebilirliği artırır. Helm chartın girdisi değerlerin kombinasyonudur. Sadece varsayılan giriş kombinasyonlarını(=values.yaml) ve onların snapshotlarını korumamız yeterli.

- **Sürekli test:** CI sürecinizde Helm chartın snapshotlarını sürekli alarak, tüm chartınızdaki değişiklikleri hızlıca fark edebilir ve regresyonları önleyebilirsiniz.

Bu avantajlar sadece kendi oluşturduğunuz Helm chartlar için değil, Kubernetes yöneticisiyseniz, Kubernetes’inize yüklediğiniz üçüncü parti chartlar için de geçerlidir. Kümeyi yükseltirken, *değerleriniz* ile üretilen çıktı manifestlerinde en küçük değişiklikleri bile fark edebilirsiniz.


### Motivasyon

Snapshot testini destekleyen mevcut Helm test araçları var.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest), popüler bir birim test aracı, [snapshot testing](https://github.com/helm-unittest/helm-unittest#snapshot-testing) desteğine sahiptir.
- [terratest](https://terratest.gruntwork.io/), altyapı kodlarınız için otomatik testler. Testleri Go kodları olarak yazabilir ve Helm çıktısını test etme özelliği vardır. [blog yazısı](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> Resmi Helm test aracı [`ct`](https://github.com/helm/chart-testing), birim veya snapshot test için değil, lint ve entegrasyon testi içindir

Bu araçlar, Helm chartları test etmek için değerli araçlar olsa da, snapshot testleri için belirli sınırlamaları vardır.

- Sadece snapshot testi için bile olsa, araçların Test Suite dosyalarını öğrenmeli ve hazırlamalısınız.

- Varsayılan olarak tüm chartın snapshotunu almazlar, Helm chart içinde dosya bazında test yapmak üzere tasarlanmıştır.

- Helm fonksiyonlarının dinamik çıktıları dikkate alınmaz.

helm-unittest, Helm chart içinde dosya bazında testler yapacak şekilde tasarlanmıştır. Yani, her dosya bağımsız olarak değerlendirilir ve Helm chart değerleri veya koşulları, tüm bir dosyanın koşullu olarak dahil edilmesine veya hariç tutulmasına yol açtığında, önemli senaryoları kapsayamayan eksik testlere neden olabilir.

İşte helm-unittest ile snapshot testi için bir test spesifikasyon dosyası örneği.

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

Örneğin, Helm chartınız hem TLS etkinleştirildiğinde hem de cert-manager etkinleştirildiğinde bir `Certificate` kaynağı (cert-manager’a ait) oluşturabilir, ancak cert-manager etkin değilse helm fonksiyonu [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) kullanarak kendi imzaladığı bir TLS `Secret` kaynağı oluşturur. Ayrıca, TLS’in etkin olup olmaması Ingress’in TLS özelliklerini, Deployment’ın uygulamaya özel TLS seçeneklerini vb. etkiler.

Bu gibi durumlarda, helm-unittest bu koşullu dosyaların çıktısı boş olabileceğinden, tüm chartın davranışını yeterince test edemeyebilir ve testler eksik kalabilir.

Oysa `helm-chartsnap` ile yapmanız gereken tek şey, beklediğiniz desenlerin `values.yaml` dosyalarını hazırlamaktır 😊

## Kurulum 🚀

Helm eklentisi olarak kurabilirsiniz.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

Diğer seçenekler:

- Go ile kurulum

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [Release binary indir](https://github.com/jlandowner/helm-chartsnap/releases)

## Kullanım

Hızlı başlamak için chartınızı parametre olarak verin.

```
helm chartsnap -c YOUR_CHART
```

Chart dizininde `__snapshot__` klasörü ve içinde `default.snap` oluşturulur.

Ayrıca, chartınızın Values dosyalarının varyasyonları olarak test vakaları da oluşturabilirsiniz.

Komutun tam kullanımı aşağıdaki gibidir.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # Varsayılan değerlerle snapshot:
  chartsnap -c YOUR_CHART
  
  # Snapshot dosyalarını güncelle:
  chartsnap -c YOUR_CHART -u

  # Test vakası değerleriyle snapshot:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # Tüm test vakalarını snapshotla:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # 'helm template' komutu için ek argüman veya bayrak ayarla:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # Helm deposundaki uzaktan chartın snapshotu:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # ingress-nginx (https://kubernetes.github.io/ingress-nginx/) chartını belirli bir sürümle ve değer dosyanızla snapshotla:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # cilium (https://cilium.io) chartını varsayılan değerlerle ve bayraklarla snapshotla:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # OCI kaydındaki chartları snapshotla
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # Çıktıyı renksiz olarak al:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              chart dizininin yolu. bu bayrak, 'helm template RELEASE_NAME CHART --values VALUES' komutuna 'CHART' olarak geçirilir
      --config-file string        snapshot davranışını tanımlayan config dosyası adı veya yolu, örn. dinamik alanlar (varsayılan ".chartsnap.yaml")
  -N, --ctx-lines int             fark çıktısında gösterilecek satır sayısı. 0 tam çıktı için (varsayılan 3)
      --debug                     debug modu
      --fail-helm-error           'helm template' komutu başarısız olursa başarısız ol
      --failfast                  herhangi bir test vakası başarısız olursa hemen başarısız ol
  -h, --help                      chartsnap için yardım
  -n, --namespace string          namespace. bu bayrak, 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' komutuna 'NAMESPACE' olarak geçirilir (varsayılan "default")
  -o, --output-dir string         __snapshot__ klasörünün oluşturulacağı dizin. (varsayılan: --values ayarlandıysa values dosya dizini; chart yerelse chart dizini; aksi halde geçerli dizin)
      --parallelism int           Birden fazla test değer dosyası dizini için test eşzamanlılığı. Varsayılan sınırsız (varsayılan -1)
      --release-name string       release adı. bu bayrak, 'helm template RELEASE_NAME CHART --values VALUES' komutuna 'RELEASE_NAME' olarak geçirilir (varsayılan "chartsnap")
      --snapshot-version string   belirli bir snapshot format sürümü kullan. v1, v2, v3 desteklenir. (varsayılan: en son)
  -u, --update-snapshot           snapshot güncelleme modu
  -f, --values string             test values dosyası veya dizininin yolu. Eğer dizin ayarlanırsa, tüm test dosyaları test edilir. Boşsa varsayılan değerler kullanılır. Bu bayrak, 'helm template RELEASE_NAME CHART --values VALUES' komutuna 'VALUES' olarak geçirilir
  -v, --version                   chartsnap sürümünü göster

```

### Dinamik değerlerle başa çıkma 💪

Helm, [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) ve [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions) gibi rastgele değerler veya kendinden imzalı sertifikalar üreten "Helm fonksiyonları"na sahiptir.

Bu fonksiyonlar kullanıldığında, çıktı her Helm çalıştırmasında farklı olur.
Bu durumda, chartsnap, eşleşmeyen snapshotları sabit bir değer olan `###DYNAMIC_FIELD###` ile değiştirerek önler.

Oluşturulan YAML içindeki dinamik değerlerin yollarını [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901) ile belirtebilirsiniz.

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

> NOT:
> JSONPath’te, / karakterinin kaçışının [RFC6901, bölüm 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)’te belgelenmiştir
> ```
>    '~' (%x7E) ve '/' (%x2F) karakterlerinin JSON Pointer’da özel anlamları olduğundan,
>    '~', '~0' olarak ve '/' karakteri '~1' olarak kodlanmalıdır.
>    Bu karakterler bir referans anahtarında geçtiğinde.
> ```
>
> Yani aşağıdaki gibi bir manifestle çalışıyorsanız, json path'i `/metadata/annotaions/checksum~1values` olarak belirtmeniz gerekir.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

Bir test values dosya dizininiz varsa, o dizine `.chartsnap.yaml` dosyası olarak yerleştirin. Bu, dizindeki tüm snapshot testlerinde ortak davranıştır.

Daha fazla örnek için bkz. [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

Alternatif olarak, test values dosyasına doğrudan `testSpec` özelliği olarak konfigürasyon ekleyebilirsiniz.
Bu durumda, `.chartsnap.yaml` hazırlamanız gerekmez. Uzaktaki veya üçüncü parti chartların snapshotunu kendi tek values dosyanızla almak için uygundur.

Values dosyanız şu şekilde olabilir:

```yaml
# Bu özelliği values dosyanıza ekleyin.
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

# Diğerleri chartınızın herhangi bir değeri olabilir.
# ...
```

Daha fazla örnek için bkz. [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## Vitrin & Kullanıcılar ✨

| Kullanıcılar / Projeler | Açıklama | URL |
|:---|:---|:---|
| Örnek | `helm create` komutu ile üretilen örnek chart | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Örnek | Uzak Helm depolarındaki chartların snapshot örneği | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | CI'da helm chartsnap kullanmak için GitHub Action | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | Kubernetes üzerinde açık kaynak WebIDE & DevEnvironment Platformu | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 Bulut-yerel API Gateway ve AI Gateway. | https://github.com/Kong/charts |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---