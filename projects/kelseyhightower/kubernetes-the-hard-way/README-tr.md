# Kubernetes Zor Yoldan

Bu eğitim, Kubernetes'i zor yoldan kurmanız için sizi adım adım yönlendirir. Bu rehber, Kubernetes kümesini tamamen otomatik bir araç ile kurmak isteyenler için değildir. Kubernetes Zor Yoldan, öğrenmeyi optimize eder, yani bir Kubernetes kümesini başlatmak için gereken her adımı anlamanızı sağlamak adına uzun yolu seçer.

> Bu eğitimin sonuçları üretime hazır olarak görülmemelidir ve topluluktan sınırlı destek alabilir, fakat bu sizi öğrenmekten alıkoymasın!

## Telif Hakkı

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Bu eser, bir <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a> ile lisanslanmıştır.


## Hedef Kitle

Bu eğitimin hedef kitlesi, Kubernetes'in temel prensiplerini ve ana bileşenlerin nasıl bir araya geldiğini anlamak isteyen kişilerdir.

## Küme Detayları

Kubernetes Zor Yoldan, tüm kontrol düzlemi bileşenlerinin tek bir düğümde ve iki işçi düğümünde çalıştığı temel bir Kubernetes kümesini başlatmanızı sağlar; bu, temel kavramları öğrenmek için yeterlidir.

Bileşen sürümleri:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Laboratuvarlar

Bu eğitim, aynı ağa bağlı dört (4) ARM64 veya AMD64 tabanlı sanal ya da fiziksel makine gerektirir.

* [Ön Koşullar](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Jumpbox Kurulumu](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Hesaplama Kaynaklarının Hazırlanması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [CA Sağlama ve TLS Sertifikalarının Oluşturulması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Kimlik Doğrulama için Kubernetes Yapılandırma Dosyalarının Oluşturulması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Veri Şifreleme Yapılandırması ve Anahtarının Oluşturulması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [etcd Kümesinin Başlatılması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Kubernetes Kontrol Düzleminin Başlatılması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Kubernetes İşçi Düğümlerinin Başlatılması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Uzaktan Erişim için kubectl Yapılandırması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Pod Ağ Rotalarının Sağlanması](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Duman Testi](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Temizlik](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---