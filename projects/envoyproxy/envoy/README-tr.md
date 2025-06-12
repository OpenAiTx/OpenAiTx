![Envoy Logosu](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[Bulut-yerel yüksek performanslı uç/ara/hizmet proxy'si](https://www.envoyproxy.io/)

Envoy, [Cloud Native Computing Foundation](https://cncf.io) (CNCF) tarafından barındırılmaktadır. Eğer siz de
konteynerle paketlenmiş, dinamik olarak zamanlanan ve mikroservis odaklı teknolojilerin gelişimine
yön vermek isteyen bir şirketseniz, CNCF'ye katılmayı düşünebilirsiniz. Kimlerin dahil olduğu ve
Envoy'un nasıl bir rol oynadığı hakkında detaylar için CNCF
[duyurusunu](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/) okuyun.

[![CII En İyi Uygulamalar](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Durumu](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## Dokümantasyon

* [Resmi dokümantasyon](https://www.envoyproxy.io/)
* [SSS](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [Örnek dokümantasyon](https://github.com/envoyproxy/examples/)
* [Blog](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310): Threading modeli hakkında
* [Blog](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5): Hot restart hakkında
* [Blog](https://medium.com/@mattklein123/envoy-stats-b65c7f363342): İstatistik mimarisi hakkında
* [Blog](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a): Evrensel data plane API hakkında
* [Blog](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1): Lyft'in Envoy panoları hakkında

## İlgili

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): v2 API tanımları bağımsız bir
  depo olarak. Bu, [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/) dizininin salt okunur bir yansısıdır.
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): Performans test çerçevesi.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): Yeni filtrelerin nasıl ekleneceğine ve ana depoya nasıl bağlanacağına dair örnek.

## İletişim

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): Sadece duyuruların gönderileceği düşük frekanslı e-posta listesi.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): Sadece güvenlikle ilgili duyuruların gönderileceği düşük frekanslı e-posta listesi.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): Genel kullanıcı tartışması.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Envoy geliştirici tartışması (API'ler,
  özellik tasarımı, vb.).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): Tüm ana Envoy geliştiricilerine ulaşmak için bu listeyi kullanın.
* [Twitter](https://twitter.com/EnvoyProxy/): Twitter üzerinden takip edin!
* [Slack](https://envoyproxy.slack.com/): Slack'e katılmak için [buradan](https://communityinviter.com/apps/envoyproxy/envoy) davetiye alabilirsiniz.
  * NOT: Slack'te kullanıcı sorularına yanıt verme çabası en iyi gayrettir. "Garanti" bir yanıt için lütfen aşağıda bağlantılı başlıktaki yönergelere göre envoy-users@ adresine e-posta gönderin.

E-posta listesi kullanımı hakkında bilgi için lütfen [bu](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) e-posta dizisini inceleyin.

## Katkıda Bulunma

Envoy'a katkıda bulunmak eğlencelidir ve modern C++ önceden tecrübeniz yoksa bile düşündüğünüz kadar korkutucu değildir. Başlamak için:

* [Katkı rehberi](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [Başlangıç konuları](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [Docker kullanarak hızlı derleme/test başlatma](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [Geliştirici rehberi](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* Geliştirme sürecinin bazı bölümlerini, özellikle kod inceleme ile ilgili olanları otomatikleştirmeye yardımcı olan Envoy [geliştirme destek araç zinciri](https://github.com/envoyproxy/envoy/blob/main/support/README.md)'ni yüklemeyi düşünebilirsiniz.
* Lütfen bir konuda çalışıyorsanız bize mutlaka bildirin ki aynı işi iki kez yapmayalım!

## Topluluk Toplantısı

Envoy ekibinin her ay iki kez, Salı günleri saat 09:00 PT'de planlanmış bir toplantısı vardır. Açık Google takvimi [burada](https://goo.gl/PkDijT). Toplantı yalnızca [toplantı notlarında](https://goo.gl/5Cergb) gündem maddeleri listelenmişse yapılacaktır. Topluluğun herhangi bir üyesi toplantı notlarına ekleme yaparak gündem maddesi önerebilir. Sorumlu geliştiriciler gündeme eklemeleri onaylayacak veya onaylanmış gündem yoksa toplantıdan 24 saat önce toplantıyı iptal edeceklerdir.

## Güvenlik

### Güvenlik Denetimi

Envoy güvenliğiyle ilgili birkaç üçüncü taraf incelemesi yapılmıştır:
* 2018 yılında Cure53 bir güvenlik denetimi gerçekleştirdi, [tam rapor](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* 2021 yılında Ada Logics, iyileştirme önerileriyle birlikte fuzzing altyapımızı inceledi, [tam rapor](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### Güvenlik açıklarını bildirme

Envoy'da bir güvenlik açığı veya potansiyel bir açık bulduysanız lütfen bize
[envoy-security](mailto:envoy-security@googlegroups.com) adresinden bildirin. Raporunuzu aldığımızı onaylayan bir e-posta göndereceğiz ve konuyu pozitif veya negatif olarak belirlediğimizde ek bir e-posta göndereceğiz.

Daha fazla ayrıntı için tam [güvenlik sürüm sürecimize](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md) bakın.

### ppc64le derlemeleri

ppc64le mimarisi veya aws-lc kullanılarak yapılan derlemeler envoy güvenlik politikası kapsamında değildir. ppc64le mimarisi şu anda en iyi gayret esasına göre desteklenmekte olup, Envoy geliştiricileri tarafından aktif olarak bakımı yapılmamaktadır.

## Sürümler

Daha fazla ayrıntı için [sürüm sürecimize](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md) bakın.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---