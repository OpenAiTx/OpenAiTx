# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, K8s olarak da bilinir, birden fazla host üzerinde [konteynerleştirilmiş uygulamaları] yönetmek için açık kaynaklı bir sistemdir. Uygulamaların dağıtımı, bakımı ve ölçeklendirilmesi için temel mekanizmalar sağlar.

Kubernetes, Google’ın Borg adlı sistemiyle büyük ölçekli üretim iş yüklerini çalıştırmadaki on beş yıllık deneyiminin yanı sıra, topluluktan en iyi fikirler ve uygulamalar üzerine inşa edilmiştir.

Kubernetes, Cloud Native Computing Foundation ([CNCF]) tarafından barındırılmaktadır. Şirketiniz, konteyner paketli, dinamik olarak zamanlanan ve mikroservis odaklı teknolojilerin evrimini şekillendirmek istiyorsa CNCF'ye katılmayı düşünebilir. Kimlerin dahil olduğu ve Kubernetes'in rolü hakkında detaylar için CNCF [duyurusunu] okuyun.

----

## K8s'i kullanmaya başlamak için

[kubernetes.io]'daki dokümantasyonumuza bakın.

[Kubernetes ile Ölçeklenebilir Mikroservisler] üzerine ücretsiz bir kurs alın.

Kubernetes kodunu diğer uygulamalarda bir kütüphane olarak kullanmak için [yayınlanmış bileşenler listesine](https://git.k8s.io/kubernetes/staging/README.md) bakın. `k8s.io/kubernetes` modülünün veya `k8s.io/kubernetes/...` paketlerinin kütüphane olarak kullanımı desteklenmemektedir.

## K8s geliştirmeye başlamak için

[Topluluk deposu], Kubernetes’in kaynak kodundan nasıl derleneceği, koda ve dokümantasyona nasıl katkıda bulunulacağı, neyle ilgili kime ulaşılacağı vb. tüm bilgileri barındırır.

Kubernetes’i hemen derlemek istiyorsanız iki seçeneğiniz var:

##### Çalışan bir [Go ortamınız] var.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Çalışan bir [Docker ortamınız] var.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Tüm detaylar için [geliştirici dokümantasyonuna] göz atın.

## Destek

Desteğe ihtiyacınız varsa, önce [sorun giderme rehberi] ile başlayın ve belirttiğimiz süreci takip edin.

Bununla birlikte, sorularınız varsa bizimle [herhangi bir şekilde][iletişim] iletişime geçin.

[duyuru]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[iletişim]: https://git.k8s.io/community/communication
[topluluk deposu]: https://git.k8s.io/community
[konteynerleştirilmiş uygulamaları]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[geliştirici dokümantasyonu]: https://git.k8s.io/community/contributors/devel#readme
[Docker ortamınız]: https://docs.docker.com/engine
[Go ortamınız]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Kubernetes ile Ölçeklenebilir Mikroservisler]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[sorun giderme rehberi]: https://kubernetes.io/docs/tasks/debug/

## Topluluk Toplantıları 

[Takvim](https://www.kubernetes.dev/resources/calendar/) sayfasında Kubernetes topluluğundaki tüm toplantıların listesi tek bir yerde bulunabilir.

## Kullanıcılar

[Kullanıcı Vaka Çalışmaları](https://kubernetes.io/case-studies/) web sitesinde, endüstriler genelinde Kubernetes’e dağıtım/yeni geçiş yapan organizasyonların gerçek dünya kullanım örnekleri bulunmaktadır.

## Yönetişim 

Kubernetes projesi, topluluğumuzu ve paydaşlarımızı ortak hedeflerimize yönlendirmek için bir dizi ilke, değer, politika ve süreç ile yönetilmektedir.

[Kubernetes Topluluğu](https://github.com/kubernetes/community/blob/master/governance.md), organizasyonumuz hakkında bilgi almak için başlangıç noktasıdır.

[Kubernetes Steering topluluk deposu](https://github.com/kubernetes/steering), Kubernetes projesinin yönetişimini denetleyen Steering Komitesi tarafından kullanılmaktadır.

## Yol Haritası 

[Kubernetes Enhancements deposu](https://github.com/kubernetes/enhancements), Kubernetes sürümleri ile ilgili bilgilerin yanı sıra özellik takibi ve iş listelerini sağlar.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---